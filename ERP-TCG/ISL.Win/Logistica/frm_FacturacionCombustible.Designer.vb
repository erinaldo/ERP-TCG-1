<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FacturacionCombustible
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
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroLinea")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnit")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGravado")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMaterial")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioIGV")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaVeh")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegConsumoCombustible")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoReferencia")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDetalleDocumento")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaGrifo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaTanqueo")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroLinea")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnit")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Igv")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGravado")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodMaterial")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioIGV")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVale")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlacaVeh")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRegConsumoCombustible")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoReferencia")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodViaje")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDetalleDocumento")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
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
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaVeh")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KilometrosTanqueo")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGalon", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueo")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoGls")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccion")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCredito")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegistroInventario")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrifo")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMaterial")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomGrifo")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomDireccion")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomLugar")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodViaje")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaTanqueo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlacaVeh")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KilometrosTanqueo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadGalon")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTanqueo")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVale")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoGls")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaGrifo")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDireccion")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCredito")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRegistroInventario")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGrifo")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodMaterial")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NomGrifo")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NomDireccion")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NomLugar")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaViaje")
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.grilisDetDocCom = New ISL.Controles.Grilla(Me.components)
        Me.odTanqueosFacturados = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.chkPrecios = New ISL.Controles.Chequear(Me.components)
        Me.BtnLimpiaTodo = New ISL.Controles.Boton(Me.components)
        Me.btnImportar = New ISL.Controles.Boton(Me.components)
        Me.decPrecio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.btnExportar = New ISL.Controles.Boton(Me.components)
        Me.btnAplicarPrecio = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.gbMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.chkTodasDirecciones = New ISL.Controles.Chequear(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rfHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfDesde = New System.Windows.Forms.DateTimePicker()
        Me.BtnQuitar = New ISL.Controles.Boton(Me.components)
        Me.btnAgregar = New ISL.Controles.Boton(Me.components)
        Me.btnListarTanqueos = New ISL.Controles.Boton(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grid_ListRegComsumoComb = New ISL.Controles.Grilla(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odTanqueos = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Ficha1 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboDireccion = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Texto1 = New ISL.Controles.Texto(Me.components)
        Me.decTipoCambio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decIgv = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decImporte = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboLugar = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboProveedor = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiEstado = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoPago = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecMovDoc = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ficConCombustible = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.grilisDetDocCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odTanqueosFacturados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.chkPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.chkTodasDirecciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.grid_ListRegComsumoComb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.odTanqueos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ficha1.SuspendLayout()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.cboDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Texto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decIgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecMovDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficConCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficConCombustible.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1195, 484)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.grilisDetDocCom)
        Me.Agrupacion1.Controls.Add(Me.UltraGroupBox2)
        Me.Agrupacion1.Controls.Add(Me.gbMateriales)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1195, 484)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grilisDetDocCom
        '
        Me.grilisDetDocCom.DataSource = Me.odTanqueosFacturados
        UltraGridColumn62.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn62.Header.VisiblePosition = 0
        UltraGridColumn62.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn62.Width = 27
        UltraGridColumn63.Header.VisiblePosition = 1
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 5
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.Width = 130
        UltraGridColumn65.Header.VisiblePosition = 13
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 2
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 18
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.Caption = "Fecha"
        UltraGridColumn68.Header.VisiblePosition = 16
        UltraGridColumn68.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn68.Width = 136
        UltraGridColumn69.Header.VisiblePosition = 17
        UltraGridColumn69.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn70.CellAppearance = Appearance1
        UltraGridColumn70.Header.Caption = "Cantidad(Gal)"
        UltraGridColumn70.Header.VisiblePosition = 7
        UltraGridColumn70.MaskInput = "{double:9.4}"
        UltraGridColumn70.Width = 74
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn71.CellAppearance = Appearance2
        UltraGridColumn71.Header.Caption = "Precio"
        UltraGridColumn71.Header.VisiblePosition = 9
        UltraGridColumn71.MaskInput = "{double:9.4}"
        UltraGridColumn71.Width = 80
        UltraGridColumn72.Header.VisiblePosition = 19
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 10
        UltraGridColumn73.MaskInput = "{double:9.4}"
        UltraGridColumn73.Width = 70
        UltraGridColumn74.Header.VisiblePosition = 20
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn75.DefaultCellValue = "False"
        UltraGridColumn75.Header.Caption = "Ind"
        UltraGridColumn75.Header.CheckBoxAlignment = Infragistics.Win.UltraWinGrid.HeaderCheckBoxAlignment.Center
        UltraGridColumn75.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn75.Header.VisiblePosition = 8
        UltraGridColumn75.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn75.Width = 54
        UltraGridColumn76.Header.VisiblePosition = 21
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.Caption = "Codigo"
        UltraGridColumn77.Header.VisiblePosition = 3
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn78.CellAppearance = Appearance3
        UltraGridColumn78.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn78.Header.Caption = "Precio(Igv)"
        UltraGridColumn78.Header.VisiblePosition = 11
        UltraGridColumn78.MaskInput = "{double:9.4}"
        UltraGridColumn78.Width = 75
        UltraGridColumn79.Header.VisiblePosition = 4
        UltraGridColumn79.Width = 111
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn80.CellAppearance = Appearance4
        UltraGridColumn80.Header.VisiblePosition = 12
        UltraGridColumn80.MaskInput = "{double:9.4}"
        UltraGridColumn80.Width = 76
        UltraGridColumn81.Header.Caption = "Nro Vale"
        UltraGridColumn81.Header.VisiblePosition = 15
        UltraGridColumn82.Header.Caption = "Tracto"
        UltraGridColumn82.Header.VisiblePosition = 14
        UltraGridColumn83.Header.VisiblePosition = 22
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 23
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.Caption = "Viaje"
        UltraGridColumn85.Header.VisiblePosition = 6
        UltraGridColumn85.Width = 122
        UltraGridColumn86.Header.VisiblePosition = 24
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 25
        UltraGridColumn87.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87})
        Me.grilisDetDocCom.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grilisDetDocCom.DisplayLayout.MaxColScrollRegions = 1
        Me.grilisDetDocCom.DisplayLayout.MaxRowScrollRegions = 1
        Me.grilisDetDocCom.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilisDetDocCom.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grilisDetDocCom.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grilisDetDocCom.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grilisDetDocCom.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grilisDetDocCom.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grilisDetDocCom.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grilisDetDocCom.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grilisDetDocCom.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilisDetDocCom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grilisDetDocCom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grilisDetDocCom.Location = New System.Drawing.Point(2, 48)
        Me.grilisDetDocCom.Name = "grilisDetDocCom"
        Me.grilisDetDocCom.Size = New System.Drawing.Size(1191, 101)
        Me.grilisDetDocCom.TabIndex = 1
        Me.grilisDetDocCom.TabStop = False
        '
        'odTanqueosFacturados
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn14.DataType = GetType(Boolean)
        UltraDataColumn14.DefaultValue = False
        Me.odTanqueosFacturados.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.chkPrecios)
        Me.UltraGroupBox2.Controls.Add(Me.BtnLimpiaTodo)
        Me.UltraGroupBox2.Controls.Add(Me.btnImportar)
        Me.UltraGroupBox2.Controls.Add(Me.decPrecio)
        Me.UltraGroupBox2.Controls.Add(Me.btnExportar)
        Me.UltraGroupBox2.Controls.Add(Me.btnAplicarPrecio)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta16)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(2, 2)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1191, 46)
        Me.UltraGroupBox2.TabIndex = 0
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkPrecios
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.chkPrecios.Appearance = Appearance5
        Me.chkPrecios.AutoSize = True
        Me.chkPrecios.BackColor = System.Drawing.Color.Transparent
        Me.chkPrecios.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkPrecios.Checked = True
        Me.chkPrecios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrecios.ForeColor = System.Drawing.Color.Black
        Me.chkPrecios.Location = New System.Drawing.Point(230, 18)
        Me.chkPrecios.Name = "chkPrecios"
        Me.chkPrecios.Size = New System.Drawing.Size(90, 17)
        Me.chkPrecios.TabIndex = 39
        Me.chkPrecios.Text = "Por Direccion"
        '
        'BtnLimpiaTodo
        '
        Appearance6.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.BtnLimpiaTodo.Appearance = Appearance6
        Me.BtnLimpiaTodo.BackColorInternal = System.Drawing.Color.Transparent
        Me.BtnLimpiaTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiaTodo.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnLimpiaTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiaTodo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnLimpiaTodo.Location = New System.Drawing.Point(1087, 3)
        Me.BtnLimpiaTodo.Name = "BtnLimpiaTodo"
        Me.BtnLimpiaTodo.Size = New System.Drawing.Size(101, 40)
        Me.BtnLimpiaTodo.TabIndex = 5
        Me.BtnLimpiaTodo.TabStop = False
        Me.BtnLimpiaTodo.Text = "Limpiar todo"
        '
        'btnImportar
        '
        Appearance7.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnImportar.Appearance = Appearance7
        Me.btnImportar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnImportar.Location = New System.Drawing.Point(481, 7)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(101, 31)
        Me.btnImportar.TabIndex = 4
        Me.btnImportar.TabStop = False
        Me.btnImportar.Text = "Importar"
        '
        'decPrecio
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.decPrecio.Appearance = Appearance8
        Me.decPrecio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decPrecio.ForeColor = System.Drawing.Color.Black
        Me.decPrecio.Location = New System.Drawing.Point(61, 15)
        Me.decPrecio.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Me.decPrecio.Name = "decPrecio"
        Me.decPrecio.NullText = "0.00"
        Me.decPrecio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decPrecio.Size = New System.Drawing.Size(127, 21)
        Me.decPrecio.TabIndex = 1
        '
        'btnExportar
        '
        Appearance9.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnExportar.Appearance = Appearance9
        Me.btnExportar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnExportar.Location = New System.Drawing.Point(374, 7)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(101, 32)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.TabStop = False
        Me.btnExportar.Text = "Exportar"
        '
        'btnAplicarPrecio
        '
        Appearance10.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnAplicarPrecio.Appearance = Appearance10
        Me.btnAplicarPrecio.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAplicarPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAplicarPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicarPrecio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAplicarPrecio.Location = New System.Drawing.Point(194, 9)
        Me.btnAplicarPrecio.Name = "btnAplicarPrecio"
        Me.btnAplicarPrecio.Size = New System.Drawing.Size(30, 32)
        Me.btnAplicarPrecio.TabIndex = 2
        Me.btnAplicarPrecio.TabStop = False
        '
        'Etiqueta16
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta16.Appearance = Appearance11
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(17, 19)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta16.TabIndex = 0
        Me.Etiqueta16.Text = "Precio:"
        '
        'gbMateriales
        '
        Me.gbMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbMateriales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbMateriales.ExpandedSize = New System.Drawing.Size(1191, 333)
        Me.gbMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.gbMateriales.Location = New System.Drawing.Point(2, 149)
        Me.gbMateriales.Name = "gbMateriales"
        Me.gbMateriales.Size = New System.Drawing.Size(1191, 333)
        Me.gbMateriales.TabIndex = 2
        Me.gbMateriales.TabStop = False
        Me.gbMateriales.Text = "Consumo de Combustible No Facturado"
        Me.gbMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.chkTodasDirecciones)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label1)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.rfHasta)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.rfDesde)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.BtnQuitar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnAgregar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnListarTanqueos)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 25)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1185, 305)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'chkTodasDirecciones
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.FontData.BoldAsString = "True"
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.chkTodasDirecciones.Appearance = Appearance12
        Me.chkTodasDirecciones.AutoSize = True
        Me.chkTodasDirecciones.BackColor = System.Drawing.Color.Transparent
        Me.chkTodasDirecciones.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkTodasDirecciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodasDirecciones.ForeColor = System.Drawing.Color.Black
        Me.chkTodasDirecciones.Location = New System.Drawing.Point(587, 13)
        Me.chkTodasDirecciones.Name = "chkTodasDirecciones"
        Me.chkTodasDirecciones.Size = New System.Drawing.Size(116, 17)
        Me.chkTodasDirecciones.TabIndex = 38
        Me.chkTodasDirecciones.Text = "Todas Direcciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(174, 15)
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
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'rfHasta
        '
        Me.rfHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfHasta.Location = New System.Drawing.Point(218, 11)
        Me.rfHasta.Name = "rfHasta"
        Me.rfHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfHasta.TabIndex = 3
        Me.rfHasta.TabStop = False
        '
        'rfDesde
        '
        Me.rfDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfDesde.Location = New System.Drawing.Point(59, 11)
        Me.rfDesde.Name = "rfDesde"
        Me.rfDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfDesde.TabIndex = 1
        Me.rfDesde.TabStop = False
        '
        'BtnQuitar
        '
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        Me.BtnQuitar.Appearance = Appearance13
        Me.BtnQuitar.BackColorInternal = System.Drawing.Color.Transparent
        Me.BtnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnQuitar.Location = New System.Drawing.Point(480, 5)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(101, 31)
        Me.BtnQuitar.TabIndex = 6
        Me.BtnQuitar.TabStop = False
        Me.BtnQuitar.Text = "Quitar"
        '
        'btnAgregar
        '
        Appearance14.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnAgregar.Appearance = Appearance14
        Me.btnAgregar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAgregar.Location = New System.Drawing.Point(373, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(101, 31)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.TabStop = False
        Me.btnAgregar.Text = "Agregar"
        '
        'btnListarTanqueos
        '
        Appearance15.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListarTanqueos.Appearance = Appearance15
        Me.btnListarTanqueos.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListarTanqueos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListarTanqueos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarTanqueos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListarTanqueos.Location = New System.Drawing.Point(331, 5)
        Me.btnListarTanqueos.Name = "btnListarTanqueos"
        Me.btnListarTanqueos.Size = New System.Drawing.Size(30, 32)
        Me.btnListarTanqueos.TabIndex = 4
        Me.btnListarTanqueos.TabStop = False
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.grid_ListRegComsumoComb)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 43)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1185, 262)
        Me.UltraGroupBox1.TabIndex = 7
        Me.UltraGroupBox1.Text = "Listado de Consumos no Facturado"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grid_ListRegComsumoComb
        '
        Me.grid_ListRegComsumoComb.ContextMenuStrip = Me.ContextMenuStrip1
        Me.grid_ListRegComsumoComb.DataSource = Me.odTanqueos
        UltraGridColumn88.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn88.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn88.Header.VisiblePosition = 0
        UltraGridColumn88.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn88.Width = 36
        Appearance16.TextHAlignAsString = "Left"
        UltraGridColumn89.CellAppearance = Appearance16
        UltraGridColumn89.Header.Caption = "Viaje"
        UltraGridColumn89.Header.VisiblePosition = 2
        UltraGridColumn89.Width = 109
        Appearance17.TextHAlignAsString = "Center"
        UltraGridColumn90.CellAppearance = Appearance17
        UltraGridColumn90.Header.Caption = "Fecha"
        UltraGridColumn90.Header.VisiblePosition = 4
        UltraGridColumn90.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn90.Width = 123
        Appearance18.TextHAlignAsString = "Left"
        UltraGridColumn91.CellAppearance = Appearance18
        UltraGridColumn91.Header.Caption = "Tracto"
        UltraGridColumn91.Header.VisiblePosition = 5
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn92.CellAppearance = Appearance19
        UltraGridColumn92.Header.Caption = "KM Tanqueo"
        UltraGridColumn92.Header.VisiblePosition = 6
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn93.CellAppearance = Appearance20
        UltraGridColumn93.Header.Caption = "Cant(Gls)"
        UltraGridColumn93.Header.VisiblePosition = 7
        Appearance21.TextHAlignAsString = "Center"
        UltraGridColumn94.CellAppearance = Appearance21
        UltraGridColumn94.Header.Caption = "Full/Rell"
        UltraGridColumn94.Header.VisiblePosition = 8
        UltraGridColumn94.Width = 48
        Appearance22.TextHAlignAsString = "Left"
        UltraGridColumn95.CellAppearance = Appearance22
        UltraGridColumn95.Header.Caption = "Nro Vale"
        UltraGridColumn95.Header.VisiblePosition = 9
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn96.CellAppearance = Appearance23
        UltraGridColumn96.Header.Caption = "Saldo(Gls)"
        UltraGridColumn96.Header.VisiblePosition = 18
        UltraGridColumn96.Width = 86
        UltraGridColumn97.Header.VisiblePosition = 1
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 3
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.Header.VisiblePosition = 10
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 11
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 12
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 13
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 14
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 29
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 15
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 16
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 17
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 19
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 20
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.Header.VisiblePosition = 21
        UltraGridColumn110.Hidden = True
        UltraGridColumn111.Header.VisiblePosition = 22
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 23
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 24
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 25
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 26
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 27
        UltraGridColumn116.Width = 240
        UltraGridColumn117.Header.VisiblePosition = 28
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 30
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.Header.VisiblePosition = 31
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 32
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.Header.VisiblePosition = 33
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.Header.VisiblePosition = 34
        UltraGridColumn122.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122})
        Me.grid_ListRegComsumoComb.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid_ListRegComsumoComb.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListRegComsumoComb.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_ListRegComsumoComb.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_ListRegComsumoComb.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_ListRegComsumoComb.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_ListRegComsumoComb.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_ListRegComsumoComb.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_ListRegComsumoComb.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_ListRegComsumoComb.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListRegComsumoComb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_ListRegComsumoComb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_ListRegComsumoComb.Location = New System.Drawing.Point(3, 16)
        Me.grid_ListRegComsumoComb.Name = "grid_ListRegComsumoComb"
        Me.grid_ListRegComsumoComb.Size = New System.Drawing.Size(1179, 243)
        Me.grid_ListRegComsumoComb.TabIndex = 0
        Me.grid_ListRegComsumoComb.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'odTanqueos
        '
        UltraDataColumn27.DataType = GetType(Boolean)
        UltraDataColumn31.DataType = GetType(Double)
        UltraDataColumn33.DataType = GetType(Boolean)
        Me.odTanqueos.Band.Columns.AddRange(New Object() {UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61})
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Ficha1)
        Me.UltraTabPageControl5.Controls.Add(Me.agrDatoGeneral)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1197, 612)
        '
        'Ficha1
        '
        Me.Ficha1.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl2)
        Me.Ficha1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ficha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha1.Location = New System.Drawing.Point(0, 105)
        Me.Ficha1.Name = "Ficha1"
        Me.Ficha1.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.Ficha1.Size = New System.Drawing.Size(1197, 507)
        Me.Ficha1.TabIndex = 1
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Tanqueo"
        Me.Ficha1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4})
        Me.Ficha1.TabStop = False
        Me.Ficha1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1195, 484)
        '
        'agrDatoGeneral
        '
        Me.agrDatoGeneral.Controls.Add(Me.cboDireccion)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta3)
        Me.agrDatoGeneral.Controls.Add(Me.Texto1)
        Me.agrDatoGeneral.Controls.Add(Me.decTipoCambio)
        Me.agrDatoGeneral.Controls.Add(Me.decTotal)
        Me.agrDatoGeneral.Controls.Add(Me.decIgv)
        Me.agrDatoGeneral.Controls.Add(Me.decImporte)
        Me.agrDatoGeneral.Controls.Add(Me.cboLugar)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta2)
        Me.agrDatoGeneral.Controls.Add(Me.cboProveedor)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta12)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta1)
        Me.agrDatoGeneral.Controls.Add(Me.etiEstado)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta11)
        Me.agrDatoGeneral.Controls.Add(Me.txtSerie)
        Me.agrDatoGeneral.Controls.Add(Me.txtNumero)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta9)
        Me.agrDatoGeneral.Controls.Add(Me.cboTipoPago)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta8)
        Me.agrDatoGeneral.Controls.Add(Me.cboMoneda)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta7)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta10)
        Me.agrDatoGeneral.Controls.Add(Me.fecMovDoc)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta6)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta5)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(1197, 105)
        Me.agrDatoGeneral.TabIndex = 0
        Me.agrDatoGeneral.Text = "Datos Generales"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboDireccion
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.cboDireccion.Appearance = Appearance24
        Me.cboDireccion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDireccion.DisplayMember = "Nombre"
        Me.cboDireccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDireccion.ForeColor = System.Drawing.Color.Black
        Me.cboDireccion.Location = New System.Drawing.Point(415, 79)
        Me.cboDireccion.Name = "cboDireccion"
        Me.cboDireccion.Size = New System.Drawing.Size(267, 21)
        Me.cboDireccion.TabIndex = 18
        Me.cboDireccion.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance25
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(346, 80)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(63, 14)
        Me.Etiqueta3.TabIndex = 17
        Me.Etiqueta3.Text = "EE.SS./Dir.:"
        '
        'Texto1
        '
        Appearance26.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance26.TextHAlignAsString = "Left"
        Me.Texto1.Appearance = Appearance26
        Me.Texto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Texto1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Texto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Texto1.Location = New System.Drawing.Point(573, 50)
        Me.Texto1.MaxLength = 10
        Me.Texto1.Name = "Texto1"
        Me.Texto1.Size = New System.Drawing.Size(109, 21)
        Me.Texto1.TabIndex = 16
        Me.Texto1.TabStop = False
        Me.Texto1.Text = "POR GENERAR    "
        '
        'decTipoCambio
        '
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.decTipoCambio.Appearance = Appearance27
        Me.decTipoCambio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTipoCambio.ForeColor = System.Drawing.Color.Black
        Me.decTipoCambio.Location = New System.Drawing.Point(415, 50)
        Me.decTipoCambio.MaskInput = "{LOC}nnnnnnnn.nnnn"
        Me.decTipoCambio.Name = "decTipoCambio"
        Me.decTipoCambio.NullText = "0.00"
        Me.decTipoCambio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTipoCambio.ReadOnly = True
        Me.decTipoCambio.Size = New System.Drawing.Size(89, 21)
        Me.decTipoCambio.TabIndex = 12
        Me.decTipoCambio.TabStop = False
        '
        'decTotal
        '
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.decTotal.Appearance = Appearance28
        Me.decTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotal.ForeColor = System.Drawing.Color.Black
        Me.decTotal.Location = New System.Drawing.Point(743, 74)
        Me.decTotal.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Me.decTotal.Name = "decTotal"
        Me.decTotal.NullText = "0.00"
        Me.decTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotal.ReadOnly = True
        Me.decTotal.Size = New System.Drawing.Size(129, 21)
        Me.decTotal.TabIndex = 24
        Me.decTotal.TabStop = False
        '
        'decIgv
        '
        Appearance29.ForeColor = System.Drawing.Color.Black
        Me.decIgv.Appearance = Appearance29
        Me.decIgv.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decIgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decIgv.ForeColor = System.Drawing.Color.Black
        Me.decIgv.Location = New System.Drawing.Point(743, 47)
        Me.decIgv.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Me.decIgv.Name = "decIgv"
        Me.decIgv.NullText = "0.00"
        Me.decIgv.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decIgv.ReadOnly = True
        Me.decIgv.Size = New System.Drawing.Size(129, 21)
        Me.decIgv.TabIndex = 22
        Me.decIgv.TabStop = False
        '
        'decImporte
        '
        Appearance30.ForeColor = System.Drawing.Color.Black
        Me.decImporte.Appearance = Appearance30
        Me.decImporte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImporte.ForeColor = System.Drawing.Color.Black
        Me.decImporte.Location = New System.Drawing.Point(743, 23)
        Me.decImporte.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Me.decImporte.Name = "decImporte"
        Me.decImporte.NullText = "0.00"
        Me.decImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImporte.ReadOnly = True
        Me.decImporte.Size = New System.Drawing.Size(129, 21)
        Me.decImporte.TabIndex = 20
        Me.decImporte.TabStop = False
        '
        'cboLugar
        '
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Appearance = Appearance31
        Me.cboLugar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugar.DisplayMember = "Nombre"
        Me.cboLugar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugar.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Location = New System.Drawing.Point(73, 78)
        Me.cboLugar.Name = "cboLugar"
        Me.cboLugar.Size = New System.Drawing.Size(267, 21)
        Me.cboLugar.TabIndex = 8
        Me.cboLugar.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance32
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(32, 82)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta2.TabIndex = 7
        Me.Etiqueta2.Text = "Lugar:"
        '
        'cboProveedor
        '
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.cboProveedor.Appearance = Appearance33
        Me.cboProveedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboProveedor.DisplayMember = "Nombre"
        Me.cboProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.ForeColor = System.Drawing.Color.Black
        Me.cboProveedor.Location = New System.Drawing.Point(74, 51)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(266, 21)
        Me.cboProveedor.TabIndex = 6
        Me.cboProveedor.ValueMember = "Id"
        '
        'Etiqueta12
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance34
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(705, 78)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta12.TabIndex = 23
        Me.Etiqueta12.Text = "Total:"
        '
        'Etiqueta1
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance35
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(10, 55)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta1.TabIndex = 5
        Me.Etiqueta1.Text = "Proveedor:"
        '
        'etiEstado
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Me.etiEstado.Appearance = Appearance36
        Me.etiEstado.AutoSize = True
        Me.etiEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEstado.Location = New System.Drawing.Point(26, 27)
        Me.etiEstado.Name = "etiEstado"
        Me.etiEstado.Size = New System.Drawing.Size(42, 14)
        Me.etiEstado.TabIndex = 0
        Me.etiEstado.Text = "N° Doc:"
        '
        'Etiqueta11
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance37
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(715, 51)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(22, 14)
        Me.Etiqueta11.TabIndex = 21
        Me.Etiqueta11.Text = "Igv:"
        '
        'txtSerie
        '
        Appearance38.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance38.TextHAlignAsString = "Right"
        Me.txtSerie.Appearance = Appearance38
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerie.Location = New System.Drawing.Point(73, 23)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(42, 21)
        Me.txtSerie.TabIndex = 1
        '
        'txtNumero
        '
        Appearance39.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance39.TextHAlignAsString = "Right"
        Me.txtNumero.Appearance = Appearance39
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumero.Location = New System.Drawing.Point(122, 23)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(79, 21)
        Me.txtNumero.TabIndex = 2
        '
        'Etiqueta9
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance40
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(693, 27)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta9.TabIndex = 19
        Me.Etiqueta9.Text = "Importe:"
        '
        'cboTipoPago
        '
        Appearance41.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Appearance = Appearance41
        Me.cboTipoPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoPago.DisplayMember = "Nombre"
        Me.cboTipoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Location = New System.Drawing.Point(573, 23)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(109, 21)
        Me.cboTipoPago.TabIndex = 14
        Me.cboTipoPago.ValueMember = "Id"
        '
        'Etiqueta8
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance42
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(511, 25)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta8.TabIndex = 13
        Me.Etiqueta8.Text = "Tipo Pago:"
        '
        'cboMoneda
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance43
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(415, 23)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(88, 21)
        Me.cboMoneda.TabIndex = 10
        Me.cboMoneda.TabStop = False
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta7
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance44
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(362, 27)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta7.TabIndex = 9
        Me.Etiqueta7.Text = "Moneda:"
        '
        'Etiqueta10
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance45
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(207, 27)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta10.TabIndex = 3
        Me.Etiqueta10.Text = "Fecha:"
        '
        'fecMovDoc
        '
        Appearance46.ForeColor = System.Drawing.Color.Black
        Me.fecMovDoc.Appearance = Appearance46
        Me.fecMovDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecMovDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecMovDoc.ForeColor = System.Drawing.Color.Black
        Me.fecMovDoc.Location = New System.Drawing.Point(251, 23)
        Me.fecMovDoc.Name = "fecMovDoc"
        Me.fecMovDoc.Size = New System.Drawing.Size(89, 21)
        Me.fecMovDoc.TabIndex = 4
        '
        'Etiqueta6
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance47
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(387, 55)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(22, 14)
        Me.Etiqueta6.TabIndex = 11
        Me.Etiqueta6.Text = "TC:"
        '
        'Etiqueta5
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance48
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(527, 53)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta5.TabIndex = 15
        Me.Etiqueta5.Text = "Estado:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'ficConCombustible
        '
        Me.ficConCombustible.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficConCombustible.Controls.Add(Me.UltraTabPageControl5)
        Me.ficConCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficConCombustible.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficConCombustible.Location = New System.Drawing.Point(0, 0)
        Me.ficConCombustible.Name = "ficConCombustible"
        Me.ficConCombustible.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficConCombustible.Size = New System.Drawing.Size(1199, 635)
        Me.ficConCombustible.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl5
        UltraTab3.Text = "Factura Combustible"
        Me.ficConCombustible.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3})
        Me.ficConCombustible.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1197, 612)
        '
        'frm_FacturacionCombustible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1199, 635)
        Me.Controls.Add(Me.ficConCombustible)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_FacturacionCombustible"
        Me.Text = "Facturacion de Combustible"
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.grilisDetDocCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odTanqueosFacturados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.chkPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.chkTodasDirecciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.grid_ListRegComsumoComb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.odTanqueos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ficha1.ResumeLayout(False)
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        Me.agrDatoGeneral.PerformLayout()
        CType(Me.cboDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Texto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decIgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecMovDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficConCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficConCombustible.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents ficConCombustible As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gbMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoPago As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents fecMovDoc As ISL.Controles.Fecha
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents cboLugar As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboProveedor As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents etiEstado As ISL.Controles.Etiqueta
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Ficha1 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnListarTanqueos As ISL.Controles.Boton
    Friend WithEvents grilisDetDocCom As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnAplicarPrecio As ISL.Controles.Boton
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents odTanqueos As ISL.Controles.OrigenDatos
    Friend WithEvents odTanqueosFacturados As ISL.Controles.OrigenDatos
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents decPrecio As ISL.Controles.NumeroDecimal
    Friend WithEvents decTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents decIgv As ISL.Controles.NumeroDecimal
    Friend WithEvents decImporte As ISL.Controles.NumeroDecimal
    Friend WithEvents decTipoCambio As ISL.Controles.NumeroDecimal
    Friend WithEvents BtnQuitar As ISL.Controles.Boton
    Friend WithEvents btnAgregar As ISL.Controles.Boton
    Friend WithEvents Texto1 As ISL.Controles.Texto
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents btnImportar As ISL.Controles.Boton
    Friend WithEvents btnExportar As ISL.Controles.Boton
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grid_ListRegComsumoComb As ISL.Controles.Grilla
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rfHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboDireccion As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents BtnLimpiaTodo As ISL.Controles.Boton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkTodasDirecciones As ISL.Controles.Chequear
    Friend WithEvents chkPrecios As ISL.Controles.Chequear

End Class
