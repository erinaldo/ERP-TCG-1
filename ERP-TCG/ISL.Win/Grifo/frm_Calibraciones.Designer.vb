﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Calibraciones
    Inherits frm_MenuPadre

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenComercial")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadPendiente")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadAtender")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoInventario")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndImpuesto")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PDscto")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dscto")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadReal")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenComercial")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadPendiente")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadAtender")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoUnitario")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoInventario")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioTotal")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndImpuesto")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PDscto")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dscto")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadReal")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Material", -1)
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDivisible")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMaterial")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMaterial")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Familia")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubFamilia")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUnidadMedida")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serial")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfectoIgv")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndActivoFijo")
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
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPlanTrabajoEquipo")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPlanTrabajoEquipo")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioTotal")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrden")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroGuia")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRecepcion")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEntrega")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPago")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorMaterial")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorServicio")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacion")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorAprobacionEmergencia")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorRechazo")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenOrigen")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacenDestino")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MovimientoInventario")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorDocumentoAsociado")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorVariasEntregas")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrdenCompra")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperacion")
        Dim UltraGridColumn314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOrden")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialServicio")
        Dim UltraGridColumn325 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn326 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreSubEstado")
        Dim UltraGridColumn327 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUsuario")
        Dim UltraGridColumn328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenDocumento")
        Dim UltraGridColumn330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn332 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieNumero")
        Dim UltraGridColumn333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AlmacenOrigen")
        Dim UltraGridColumn334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AlmacenDestino")
        Dim UltraGridColumn335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOperDocAsoc")
        Dim UltraGridColumn336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioEjecucion")
        Dim UltraGridColumn337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioEjecucion")
        Dim UltraGridColumn388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenOrigen")
        Dim UltraGridColumn389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim UltraGridColumn390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenDestino")
        Dim UltraGridColumn391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim UltraGridColumn392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroGuia")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaRecepcion")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEntrega")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaPago")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Impuesto")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorMaterial")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorServicio")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacion")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorAprobacionEmergencia")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorRechazo")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenOrigen")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacenDestino")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorDocumentoAsociado")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorVariasEntregas")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrdenCompra")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCompra")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MaterialServicio")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreSubEstado")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreUsuario")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenDocumento")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieNumero")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AlmacenOrigen")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AlmacenDestino")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperDocAsoc")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioEjecucion")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioEjecucion")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenOrigen")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenOrigen")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenDestino")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenDestino")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn400 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn401 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn402 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn407 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial")
        Dim UltraGridColumn408 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn409 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn410 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn411 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn412 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn413 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn414 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn415 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn416 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn417 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn418 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn419 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn420 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn421 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn422 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocAsoc")
        Dim UltraGridColumn423 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFactSer")
        Dim UltraGridColumn424 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn425 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCantidadVariable")
        Dim UltraGridColumn426 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenReferencia")
        Dim UltraGridColumn427 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturadoProducto")
        Dim UltraGridColumn428 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedorTrabajador")
        Dim UltraGridColumn429 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaAlterna")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresa")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Empresa")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajadorAprobacion")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TrabajadorAprobacion")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OrdenComercial")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoExistencia")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCompra")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreTipoCompra")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Impuesto")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DocAsoc")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFactSer")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFacturado")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCantidadVariable")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenReferencia")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFacturadoProducto")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVendedorTrabajador")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaAlterna")
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
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Empresa", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CorreoEnvioXml")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEmpresa")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEmpresa")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruc")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionTanqueo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgentePercepcion")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgenteRetencion")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBuenContribuyente")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCanjeDocumento")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaLetras")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaCheque")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Morosidad")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNivelComercial")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndClasificacion")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoriaEmpresaSGI")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRelacionada")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionFiscal")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbar1")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quitar")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarOS")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarGuia")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EjecutarOS")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarNotaSalida")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quitar")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarOS")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarGuia")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EjecutarOS")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("GenerarNotaSalida")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Empresa", -1)
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CorreoEnvioXml")
        Dim UltraGridColumn455 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn456 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEmpresa")
        Dim UltraGridColumn457 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEmpresa")
        Dim UltraGridColumn458 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn459 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruc")
        Dim UltraGridColumn460 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn461 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn462 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionTanqueo")
        Dim UltraGridColumn463 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn464 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn465 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgentePercepcion")
        Dim UltraGridColumn466 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgenteRetencion")
        Dim UltraGridColumn467 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBuenContribuyente")
        Dim UltraGridColumn468 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCanjeDocumento")
        Dim UltraGridColumn469 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaLetras")
        Dim UltraGridColumn470 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaCheque")
        Dim UltraGridColumn471 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Morosidad")
        Dim UltraGridColumn472 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim UltraGridColumn473 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNivelComercial")
        Dim UltraGridColumn474 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndClasificacion")
        Dim UltraGridColumn475 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn476 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn477 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoriaEmpresaSGI")
        Dim UltraGridColumn478 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRelacionada")
        Dim UltraGridColumn479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionFiscal")
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
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Empresa", -1)
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CorreoEnvioXml")
        Dim UltraGridColumn480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEmpresa")
        Dim UltraGridColumn482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEmpresa")
        Dim UltraGridColumn483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruc")
        Dim UltraGridColumn485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionTanqueo")
        Dim UltraGridColumn488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgentePercepcion")
        Dim UltraGridColumn491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgenteRetencion")
        Dim UltraGridColumn492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBuenContribuyente")
        Dim UltraGridColumn493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCanjeDocumento")
        Dim UltraGridColumn494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaLetras")
        Dim UltraGridColumn495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaCheque")
        Dim UltraGridColumn496 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Morosidad")
        Dim UltraGridColumn497 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim UltraGridColumn498 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNivelComercial")
        Dim UltraGridColumn499 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndClasificacion")
        Dim UltraGridColumn500 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn501 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn502 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoriaEmpresaSGI")
        Dim UltraGridColumn503 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRelacionada")
        Dim UltraGridColumn504 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionFiscal")
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacen")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Costo")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockMinimo")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockMaximo")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("StockActual")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox10 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griOrdenComercialMaterial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odOrdenComMat = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.gbeMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griAlmacenMaterial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.EMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraGroupBox12 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.chkTipoMaterial = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboDestinoViaje = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboOrigenViaje = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkTransporte = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chbBuscarCod = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnBuscarMat = New Infragistics.Win.Misc.UltraButton()
        Me.txtMaterial = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btn_ActualizarDetOrden = New Infragistics.Win.Misc.UltraButton()
        Me.griDetalleOrden = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odDetalleOrden = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griOrdenSalida = New ISL.Controles.Grilla(Me.components)
        Me.odOrdenIngreso = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griOrdenComercial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odOrdenComercial = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnEliminar = New Infragistics.Win.Misc.UltraButton()
        Me.btnAnular = New Infragistics.Win.Misc.UltraButton()
        Me.btnAtender = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.colorTerminado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.colorEvaluado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorParcial = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorAtendido = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorAnulado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.grbNroOrden = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNroOrden = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.rdbNroOrden = New System.Windows.Forms.RadioButton()
        Me.rdbDatosBasicos = New System.Windows.Forms.RadioButton()
        Me.grbDatosBasicos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbMonedaB = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbgClienteB = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.odEmpresa = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ficDetalleOrdenComercial = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.upMenu = New Infragistics.Win.Misc.UltraPanel()
        Me.btnBoletearSer = New Infragistics.Win.Misc.UltraButton()
        Me.btnFacturarSer = New Infragistics.Win.Misc.UltraButton()
        Me.ClientArea_Fill_Panel = New Infragistics.Win.Misc.UltraPanel()
        Me._ClientArea_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnuDetalle = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._ClientArea_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._ClientArea_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._ClientArea_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboTipoPago = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbgClienteAlterno = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboVendedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkFacturado = New System.Windows.Forms.CheckBox()
        Me.chkFactSer = New System.Windows.Forms.CheckBox()
        Me.btnCrearCtaCte = New Infragistics.Win.Misc.UltraButton()
        Me.txtCodSaldoCtaCte = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbgCliente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblOperacion = New Infragistics.Win.Misc.UltraLabel()
        Me.cbDocumento = New System.Windows.Forms.CheckBox()
        Me.cbRuc = New System.Windows.Forms.CheckBox()
        Me.decTipoCambio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnEmitirDoc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.decTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decImpuesto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decSubTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbMoneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.grbDocAsoc = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtEstadoDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNumero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtSerie = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmbTipoDocumento = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.dtpFechaDoc = New System.Windows.Forms.DateTimePicker()
        Me.txtEstado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtOrden = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbNumeroOrden = New Infragistics.Win.Misc.UltraLabel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odAlmacenMaterial = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ficOrdenComercial = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox10.SuspendLayout()
        CType(Me.griOrdenComercialMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenComMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.griAlmacenMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox12.SuspendLayout()
        CType(Me.chkTipoMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDestinoViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrigenViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chbBuscarCod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.griDetalleOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odDetalleOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.griOrdenSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox11.SuspendLayout()
        CType(Me.colorTerminado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorEvaluado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorParcial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAtendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbNroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNroOrden.SuspendLayout()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosBasicos.SuspendLayout()
        CType(Me.cmbMonedaB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgClienteB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.ficDetalleOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalleOrdenComercial.SuspendLayout()
        Me.upMenu.ClientArea.SuspendLayout()
        Me.upMenu.SuspendLayout()
        Me.ClientArea_Fill_Panel.SuspendLayout()
        CType(Me.mnuDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgClienteAlterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodSaldoCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decImpuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDocAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDocAsoc.SuspendLayout()
        CType(Me.txtEstadoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.odAlmacenMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOrdenComercial.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox10)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1213, 289)
        '
        'UltraGroupBox10
        '
        Me.UltraGroupBox10.Controls.Add(Me.griOrdenComercialMaterial)
        Me.UltraGroupBox10.Controls.Add(Me.gbeMateriales)
        Me.UltraGroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox10.Name = "UltraGroupBox10"
        Me.UltraGroupBox10.Size = New System.Drawing.Size(1213, 289)
        Me.UltraGroupBox10.TabIndex = 0
        Me.UltraGroupBox10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOrdenComercialMaterial
        '
        Me.griOrdenComercialMaterial.DataSource = Me.odOrdenComMat
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenComercialMaterial.DisplayLayout.Appearance = Appearance1
        UltraGridColumn26.Header.VisiblePosition = 0
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 1
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.Caption = "SubAlmacen"
        UltraGridColumn28.Header.VisiblePosition = 16
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.Width = 161
        UltraGridColumn29.Header.VisiblePosition = 13
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn30.Width = 311
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn31.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn31.Header.Caption = "UM"
        UltraGridColumn31.Header.VisiblePosition = 4
        UltraGridColumn31.Width = 42
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn32.CellAppearance = Appearance2
        UltraGridColumn32.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn32.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn32.Header.VisiblePosition = 17
        UltraGridColumn32.Width = 269
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn33.CellAppearance = Appearance3
        UltraGridColumn33.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn33.Format = "#,###,###,##0.000"
        UltraGridColumn33.Header.VisiblePosition = 5
        UltraGridColumn33.MaskInput = "{double:9.3}"
        UltraGridColumn33.Width = 72
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn34.CellAppearance = Appearance4
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance5.ImageVAlign = Infragistics.Win.VAlign.Middle
        UltraGridColumn34.CellButtonAppearance = Appearance5
        UltraGridColumn34.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn34.Format = "#,###,###,##0.000"
        UltraGridColumn34.Header.Caption = "Pendiente"
        UltraGridColumn34.Header.VisiblePosition = 12
        UltraGridColumn34.MaskInput = "{double:9.3}"
        UltraGridColumn34.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn34.Width = 80
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn35.CellAppearance = Appearance6
        UltraGridColumn35.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn35.Format = "#,###,###,##0.000"
        UltraGridColumn35.Header.Caption = "Atender"
        UltraGridColumn35.Header.VisiblePosition = 14
        UltraGridColumn35.MaskInput = "{double:9.3}"
        UltraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn35.Width = 80
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn36.CellAppearance = Appearance7
        UltraGridColumn36.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn36.Format = "#,###,###,##0.000"
        UltraGridColumn36.Header.Caption = "CostoU."
        UltraGridColumn36.Header.VisiblePosition = 7
        UltraGridColumn36.MaskInput = "{double:9.3}"
        UltraGridColumn36.Width = 80
        UltraGridColumn37.Header.VisiblePosition = 27
        UltraGridColumn37.Hidden = True
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn38.CellAppearance = Appearance8
        UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn38.Format = "#,###,###,##0.000"
        UltraGridColumn38.Header.Caption = "PrecioU."
        UltraGridColumn38.Header.VisiblePosition = 8
        UltraGridColumn38.MaskInput = "{double:9.3}"
        UltraGridColumn38.Width = 80
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn39.CellAppearance = Appearance9
        UltraGridColumn39.Format = "#,###,###,##0.000"
        UltraGridColumn39.Header.VisiblePosition = 9
        UltraGridColumn39.MaskInput = "{double:9.3}"
        UltraGridColumn39.Width = 80
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn40.Header.Caption = "IGV"
        UltraGridColumn40.Header.VisiblePosition = 6
        UltraGridColumn40.Width = 47
        UltraGridColumn41.Header.VisiblePosition = 18
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 19
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 20
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 21
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 22
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 23
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 24
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 2
        UltraGridColumn48.Width = 76
        UltraGridColumn49.Header.Caption = "Almacen"
        UltraGridColumn49.Header.VisiblePosition = 15
        UltraGridColumn49.Width = 195
        UltraGridColumn50.Header.VisiblePosition = 25
        UltraGridColumn50.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn51.CellAppearance = Appearance10
        UltraGridColumn51.Header.Caption = "%Dscto"
        UltraGridColumn51.Header.VisiblePosition = 10
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn52.CellAppearance = Appearance11
        UltraGridColumn52.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn52.Header.VisiblePosition = 11
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.MaskInput = "{double:4.2}"
        UltraGridColumn52.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn52.Width = 59
        UltraGridColumn53.Header.VisiblePosition = 26
        UltraGridColumn53.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53})
        Me.griOrdenComercialMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griOrdenComercialMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercialMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenComercialMaterial.DisplayLayout.GroupByBox.Appearance = Appearance12
        Appearance13.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercialMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance13
        Me.griOrdenComercialMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercialMaterial.DisplayLayout.GroupByBox.Hidden = True
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance14.BackColor2 = System.Drawing.SystemColors.Control
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercialMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance14
        Me.griOrdenComercialMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenComercialMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenComercialMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenComercialMaterial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenComercialMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercialMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercialMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenComercialMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenComercialMaterial.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.griOrdenComercialMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenComercialMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenComercialMaterial.DisplayLayout.Override.RowAppearance = Appearance15
        Me.griOrdenComercialMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenComercialMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenComercialMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenComercialMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenComercialMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenComercialMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenComercialMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenComercialMaterial.Location = New System.Drawing.Point(3, 3)
        Me.griOrdenComercialMaterial.Name = "griOrdenComercialMaterial"
        Me.griOrdenComercialMaterial.Size = New System.Drawing.Size(484, 283)
        Me.griOrdenComercialMaterial.TabIndex = 0
        Me.griOrdenComercialMaterial.Text = "Grilla2"
        '
        'odOrdenComMat
        '
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Double)
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataColumn15.DataType = GetType(Boolean)
        UltraDataColumn26.DataType = GetType(Double)
        UltraDataColumn27.DataType = GetType(Double)
        UltraDataColumn28.DataType = GetType(Double)
        Me.odOrdenComMat.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28})
        '
        'Filtro
        '
        Me.Filtro.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2007
        '
        'gbeMateriales
        '
        Me.gbeMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbeMateriales.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeMateriales.ExpandedSize = New System.Drawing.Size(723, 283)
        Me.gbeMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.gbeMateriales.Location = New System.Drawing.Point(487, 3)
        Me.gbeMateriales.Name = "gbeMateriales"
        Me.gbeMateriales.Size = New System.Drawing.Size(723, 283)
        Me.gbeMateriales.TabIndex = 1
        Me.gbeMateriales.Text = "Materiales"
        Me.gbeMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGroupBox13)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGroupBox12)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(700, 277)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UltraGroupBox13
        '
        Me.UltraGroupBox13.Controls.Add(Me.griAlmacenMaterial)
        Me.UltraGroupBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox13.Location = New System.Drawing.Point(0, 40)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(700, 237)
        Me.UltraGroupBox13.TabIndex = 3
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griAlmacenMaterial
        '
        Me.griAlmacenMaterial.DataSource = Me.EMaterialBindingSource
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Appearance16.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAlmacenMaterial.DisplayLayout.Appearance = Appearance16
        UltraGridColumn54.Header.VisiblePosition = 0
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 1
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn56.Header.Caption = ""
        UltraGridColumn56.Header.VisiblePosition = 3
        UltraGridColumn56.Width = 29
        UltraGridColumn57.Header.VisiblePosition = 4
        UltraGridColumn58.Header.Caption = "Material"
        UltraGridColumn58.Header.VisiblePosition = 6
        UltraGridColumn58.Width = 289
        UltraGridColumn59.Header.Caption = "Codigo"
        UltraGridColumn59.Header.VisiblePosition = 5
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 19
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 8
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 10
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 11
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 12
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 13
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 14
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 18
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 17
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 16
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 21
        UltraGridColumn70.Width = 101
        UltraGridColumn71.Header.VisiblePosition = 22
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 23
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 24
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 25
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 26
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 27
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 15
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 9
        UltraGridColumn78.Hidden = True
        UltraGridColumn78.Width = 213
        UltraGridColumn79.Header.VisiblePosition = 7
        UltraGridColumn79.Hidden = True
        UltraGridColumn79.Width = 233
        UltraGridColumn80.Header.VisiblePosition = 2
        UltraGridColumn80.Hidden = True
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn81.CellAppearance = Appearance17
        UltraGridColumn81.Header.VisiblePosition = 20
        UltraGridColumn81.MaskInput = "{double:9.2}"
        UltraGridColumn81.Width = 91
        UltraGridColumn82.Header.VisiblePosition = 28
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 29
        UltraGridColumn83.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83})
        Me.griAlmacenMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griAlmacenMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAlmacenMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance18.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance18.BorderColor = System.Drawing.SystemColors.Window
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.Appearance = Appearance18
        Appearance19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance19
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.Hidden = True
        Appearance20.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance20.BackColor2 = System.Drawing.SystemColors.Control
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAlmacenMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance20
        Me.griAlmacenMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.griAlmacenMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griAlmacenMaterial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAlmacenMaterial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAlmacenMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAlmacenMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAlmacenMaterial.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Cell
        Me.griAlmacenMaterial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAlmacenMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAlmacenMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Me.griAlmacenMaterial.DisplayLayout.Override.RowAppearance = Appearance21
        Me.griAlmacenMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAlmacenMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAlmacenMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAlmacenMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAlmacenMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griAlmacenMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAlmacenMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlmacenMaterial.Location = New System.Drawing.Point(3, 3)
        Me.griAlmacenMaterial.Name = "griAlmacenMaterial"
        Me.griAlmacenMaterial.Size = New System.Drawing.Size(694, 231)
        Me.griAlmacenMaterial.TabIndex = 0
        Me.griAlmacenMaterial.Text = "Grilla2"
        '
        'EMaterialBindingSource
        '
        Me.EMaterialBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_Material)
        '
        'UltraGroupBox12
        '
        Me.UltraGroupBox12.Controls.Add(Me.chkTipoMaterial)
        Me.UltraGroupBox12.Controls.Add(Me.UltraLabel27)
        Me.UltraGroupBox12.Controls.Add(Me.cboDestinoViaje)
        Me.UltraGroupBox12.Controls.Add(Me.cboOrigenViaje)
        Me.UltraGroupBox12.Controls.Add(Me.UltraLabel28)
        Me.UltraGroupBox12.Controls.Add(Me.chkTransporte)
        Me.UltraGroupBox12.Controls.Add(Me.chbBuscarCod)
        Me.UltraGroupBox12.Controls.Add(Me.btnBuscarMat)
        Me.UltraGroupBox12.Controls.Add(Me.txtMaterial)
        Me.UltraGroupBox12.Controls.Add(Me.UltraLabel20)
        Me.UltraGroupBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox12.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox12.Name = "UltraGroupBox12"
        Me.UltraGroupBox12.Size = New System.Drawing.Size(700, 40)
        Me.UltraGroupBox12.TabIndex = 0
        Me.UltraGroupBox12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkTipoMaterial
        '
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.chkTipoMaterial.Appearance = Appearance22
        Me.chkTipoMaterial.BackColor = System.Drawing.Color.Transparent
        Me.chkTipoMaterial.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkTipoMaterial.Location = New System.Drawing.Point(403, 13)
        Me.chkTipoMaterial.Name = "chkTipoMaterial"
        Me.chkTipoMaterial.Size = New System.Drawing.Size(109, 22)
        Me.chkTipoMaterial.TabIndex = 3
        Me.chkTipoMaterial.Text = "Compra Venta"
        '
        'UltraLabel27
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UltraLabel27.Appearance = Appearance23
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Location = New System.Drawing.Point(24, 48)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(45, 15)
        Me.UltraLabel27.TabIndex = 353
        Me.UltraLabel27.Text = "Origen :"
        '
        'cboDestinoViaje
        '
        Me.cboDestinoViaje.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDestinoViaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDestinoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDestinoViaje.Location = New System.Drawing.Point(366, 41)
        Me.cboDestinoViaje.Name = "cboDestinoViaje"
        Me.cboDestinoViaje.Size = New System.Drawing.Size(225, 22)
        Me.cboDestinoViaje.TabIndex = 356
        '
        'cboOrigenViaje
        '
        Me.cboOrigenViaje.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboOrigenViaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOrigenViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOrigenViaje.Location = New System.Drawing.Point(75, 40)
        Me.cboOrigenViaje.Name = "cboOrigenViaje"
        Me.cboOrigenViaje.Size = New System.Drawing.Size(225, 22)
        Me.cboOrigenViaje.TabIndex = 355
        '
        'UltraLabel28
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UltraLabel28.Appearance = Appearance24
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Location = New System.Drawing.Point(318, 48)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(46, 15)
        Me.UltraLabel28.TabIndex = 354
        Me.UltraLabel28.Text = "Destino:"
        '
        'chkTransporte
        '
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.chkTransporte.Appearance = Appearance25
        Me.chkTransporte.AutoSize = True
        Me.chkTransporte.BackColor = System.Drawing.Color.Transparent
        Me.chkTransporte.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkTransporte.Location = New System.Drawing.Point(618, 13)
        Me.chkTransporte.Name = "chkTransporte"
        Me.chkTransporte.Size = New System.Drawing.Size(76, 18)
        Me.chkTransporte.TabIndex = 5
        Me.chkTransporte.Text = "Transporte"
        Me.chkTransporte.Visible = False
        '
        'chbBuscarCod
        '
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.chbBuscarCod.Appearance = Appearance26
        Me.chbBuscarCod.BackColor = System.Drawing.Color.Transparent
        Me.chbBuscarCod.BackColorInternal = System.Drawing.Color.Transparent
        Me.chbBuscarCod.Location = New System.Drawing.Point(552, 11)
        Me.chbBuscarCod.Name = "chbBuscarCod"
        Me.chbBuscarCod.Size = New System.Drawing.Size(60, 22)
        Me.chbBuscarCod.TabIndex = 4
        Me.chbBuscarCod.Text = "Codigo"
        Me.chbBuscarCod.Visible = False
        '
        'btnBuscarMat
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Appearance27.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnBuscarMat.Appearance = Appearance27
        Me.btnBuscarMat.Location = New System.Drawing.Point(367, 8)
        Me.btnBuscarMat.Name = "btnBuscarMat"
        Me.btnBuscarMat.Size = New System.Drawing.Size(30, 28)
        Me.btnBuscarMat.TabIndex = 2
        '
        'txtMaterial
        '
        Me.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMaterial.Location = New System.Drawing.Point(76, 12)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(288, 22)
        Me.txtMaterial.TabIndex = 1
        '
        'UltraLabel20
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Appearance28.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance28
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(11, 16)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel20.TabIndex = 0
        Me.UltraLabel20.Text = "Materiales:"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox7)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox6)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1213, 289)
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.btn_ActualizarDetOrden)
        Me.UltraGroupBox7.Controls.Add(Me.griDetalleOrden)
        Me.UltraGroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox7.Location = New System.Drawing.Point(0, 147)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(1213, 142)
        Me.UltraGroupBox7.TabIndex = 1
        Me.UltraGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btn_ActualizarDetOrden
        '
        Appearance29.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance29.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btn_ActualizarDetOrden.Appearance = Appearance29
        Me.btn_ActualizarDetOrden.Enabled = False
        Me.btn_ActualizarDetOrden.Location = New System.Drawing.Point(2, 3)
        Me.btn_ActualizarDetOrden.Name = "btn_ActualizarDetOrden"
        Me.btn_ActualizarDetOrden.Size = New System.Drawing.Size(41, 23)
        Me.btn_ActualizarDetOrden.TabIndex = 366
        '
        'griDetalleOrden
        '
        Me.griDetalleOrden.DataSource = Me.odDetalleOrden
        Appearance30.BackColor = System.Drawing.SystemColors.Window
        Appearance30.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griDetalleOrden.DisplayLayout.Appearance = Appearance30
        UltraGridColumn84.Header.VisiblePosition = 0
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 1
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 2
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 3
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.Caption = "Almacen"
        UltraGridColumn88.Header.VisiblePosition = 10
        UltraGridColumn88.Width = 221
        UltraGridColumn89.Header.Caption = "SubAlmacen"
        UltraGridColumn89.Header.VisiblePosition = 11
        UltraGridColumn89.Width = 203
        UltraGridColumn90.Header.VisiblePosition = 12
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 13
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 4
        UltraGridColumn93.Header.VisiblePosition = 5
        UltraGridColumn93.Width = 298
        UltraGridColumn94.Header.Caption = "UM"
        UltraGridColumn94.Header.VisiblePosition = 6
        UltraGridColumn94.Width = 48
        UltraGridColumn95.Header.VisiblePosition = 14
        UltraGridColumn95.Hidden = True
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn96.CellAppearance = Appearance31
        UltraGridColumn96.Header.VisiblePosition = 7
        UltraGridColumn96.MaskInput = "{double:9.3}"
        UltraGridColumn96.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn96.Width = 90
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn97.CellAppearance = Appearance32
        UltraGridColumn97.Header.VisiblePosition = 15
        UltraGridColumn97.Hidden = True
        UltraGridColumn97.MaskInput = "{double:9.4}"
        UltraGridColumn97.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn97.Width = 90
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn98.CellAppearance = Appearance33
        UltraGridColumn98.Header.VisiblePosition = 8
        UltraGridColumn98.MaskInput = "{double:9.3}"
        UltraGridColumn98.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn98.Width = 90
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn99.CellAppearance = Appearance34
        UltraGridColumn99.Header.VisiblePosition = 9
        UltraGridColumn99.MaskInput = "{double:9.3}"
        UltraGridColumn99.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn99.Width = 90
        UltraGridColumn100.Header.VisiblePosition = 16
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 17
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 18
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 19
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 20
        UltraGridColumn104.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104})
        Me.griDetalleOrden.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griDetalleOrden.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleOrden.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance35.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance35.BorderColor = System.Drawing.SystemColors.Window
        Me.griDetalleOrden.DisplayLayout.GroupByBox.Appearance = Appearance35
        Appearance36.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleOrden.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance36
        Me.griDetalleOrden.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleOrden.DisplayLayout.GroupByBox.Hidden = True
        Appearance37.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance37.BackColor2 = System.Drawing.SystemColors.Control
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance37.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleOrden.DisplayLayout.GroupByBox.PromptAppearance = Appearance37
        Me.griDetalleOrden.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleOrden.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDetalleOrden.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetalleOrden.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleOrden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDetalleOrden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDetalleOrden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalleOrden.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleOrden.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleOrden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Me.griDetalleOrden.DisplayLayout.Override.RowAppearance = Appearance38
        Me.griDetalleOrden.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleOrden.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleOrden.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalleOrden.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleOrden.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griDetalleOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleOrden.Location = New System.Drawing.Point(3, 3)
        Me.griDetalleOrden.Name = "griDetalleOrden"
        Me.griDetalleOrden.Size = New System.Drawing.Size(1207, 136)
        Me.griDetalleOrden.TabIndex = 2
        Me.griDetalleOrden.Text = "Grilla2"
        '
        'odDetalleOrden
        '
        UltraDataColumn41.DataType = GetType(Double)
        UltraDataColumn42.DataType = GetType(Double)
        UltraDataColumn43.DataType = GetType(Double)
        UltraDataColumn44.DataType = GetType(Double)
        UltraDataColumn46.DataType = GetType(Date)
        UltraDataColumn48.DataType = GetType(Date)
        UltraDataColumn49.DataType = GetType(Boolean)
        Me.odDetalleOrden.Band.Columns.AddRange(New Object() {UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49})
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.griOrdenSalida)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(1213, 147)
        Me.UltraGroupBox6.TabIndex = 0
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOrdenSalida
        '
        Me.griOrdenSalida.DataSource = Me.odOrdenIngreso
        UltraGridColumn105.Header.VisiblePosition = 0
        UltraGridColumn105.Hidden = True
        UltraGridColumn129.Header.VisiblePosition = 1
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.Caption = "Nro Orden"
        UltraGridColumn130.Header.VisiblePosition = 2
        UltraGridColumn130.Width = 103
        UltraGridColumn131.Header.VisiblePosition = 5
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.Header.VisiblePosition = 6
        UltraGridColumn132.Hidden = True
        UltraGridColumn138.Header.VisiblePosition = 7
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.Header.VisiblePosition = 10
        UltraGridColumn139.Hidden = True
        UltraGridColumn139.Width = 95
        UltraGridColumn140.Header.Caption = "Fecha"
        UltraGridColumn140.Header.VisiblePosition = 3
        UltraGridColumn140.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn140.Width = 140
        UltraGridColumn141.Header.VisiblePosition = 13
        UltraGridColumn141.Hidden = True
        UltraGridColumn142.Header.VisiblePosition = 14
        UltraGridColumn142.Hidden = True
        UltraGridColumn143.Header.VisiblePosition = 15
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.Header.VisiblePosition = 16
        UltraGridColumn144.Hidden = True
        UltraGridColumn145.Header.VisiblePosition = 17
        UltraGridColumn145.Hidden = True
        UltraGridColumn146.Header.VisiblePosition = 18
        UltraGridColumn146.Hidden = True
        UltraGridColumn147.Header.VisiblePosition = 19
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.Header.VisiblePosition = 20
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.Header.VisiblePosition = 21
        UltraGridColumn149.Hidden = True
        UltraGridColumn150.Header.VisiblePosition = 22
        UltraGridColumn150.Hidden = True
        UltraGridColumn151.Header.VisiblePosition = 23
        UltraGridColumn151.Hidden = True
        UltraGridColumn152.Header.VisiblePosition = 24
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.VisiblePosition = 25
        UltraGridColumn153.Hidden = True
        UltraGridColumn154.Header.Caption = "Movimiento Inventario"
        UltraGridColumn154.Header.VisiblePosition = 4
        UltraGridColumn154.Width = 177
        UltraGridColumn155.Header.VisiblePosition = 26
        UltraGridColumn155.Hidden = True
        UltraGridColumn156.Header.VisiblePosition = 27
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.Header.Caption = "Referencia"
        UltraGridColumn157.Header.VisiblePosition = 11
        UltraGridColumn157.Hidden = True
        UltraGridColumn157.Width = 141
        UltraGridColumn158.Header.VisiblePosition = 28
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 29
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.Header.VisiblePosition = 30
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.Header.VisiblePosition = 31
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.Header.Caption = "IdUsuario"
        UltraGridColumn162.Header.VisiblePosition = 32
        UltraGridColumn162.Hidden = True
        UltraGridColumn163.Header.VisiblePosition = 33
        UltraGridColumn163.Hidden = True
        UltraGridColumn313.Header.VisiblePosition = 34
        UltraGridColumn313.Hidden = True
        UltraGridColumn314.Header.VisiblePosition = 35
        UltraGridColumn314.Hidden = True
        UltraGridColumn315.Header.VisiblePosition = 36
        UltraGridColumn315.Hidden = True
        UltraGridColumn316.Header.VisiblePosition = 37
        UltraGridColumn316.Hidden = True
        UltraGridColumn317.Header.VisiblePosition = 38
        UltraGridColumn317.Hidden = True
        UltraGridColumn318.Header.Caption = "Tipo Orden"
        UltraGridColumn318.Header.VisiblePosition = 9
        UltraGridColumn318.Hidden = True
        UltraGridColumn318.Width = 231
        UltraGridColumn319.Header.VisiblePosition = 8
        UltraGridColumn319.Width = 78
        UltraGridColumn320.Header.Caption = "Estado"
        UltraGridColumn320.Header.VisiblePosition = 12
        UltraGridColumn320.Width = 120
        UltraGridColumn321.Header.VisiblePosition = 39
        UltraGridColumn321.Hidden = True
        UltraGridColumn322.Header.VisiblePosition = 40
        UltraGridColumn322.Hidden = True
        UltraGridColumn323.Header.VisiblePosition = 41
        UltraGridColumn323.Hidden = True
        UltraGridColumn324.Header.VisiblePosition = 42
        UltraGridColumn324.Hidden = True
        UltraGridColumn325.Header.VisiblePosition = 43
        UltraGridColumn325.Hidden = True
        UltraGridColumn326.Header.VisiblePosition = 44
        UltraGridColumn326.Hidden = True
        UltraGridColumn327.Header.Caption = "Usuario"
        UltraGridColumn327.Header.VisiblePosition = 50
        UltraGridColumn327.Width = 122
        UltraGridColumn328.Header.VisiblePosition = 45
        UltraGridColumn328.Hidden = True
        UltraGridColumn329.Header.VisiblePosition = 46
        UltraGridColumn329.Hidden = True
        UltraGridColumn330.Header.VisiblePosition = 47
        UltraGridColumn330.Hidden = True
        UltraGridColumn331.Header.Caption = "Documento Asoc."
        UltraGridColumn331.Header.VisiblePosition = 48
        UltraGridColumn331.Width = 189
        UltraGridColumn332.Header.Caption = "N° Documento"
        UltraGridColumn332.Header.VisiblePosition = 49
        UltraGridColumn332.Width = 128
        UltraGridColumn333.Header.VisiblePosition = 52
        UltraGridColumn333.Hidden = True
        UltraGridColumn334.Header.VisiblePosition = 53
        UltraGridColumn334.Hidden = True
        UltraGridColumn335.Header.VisiblePosition = 54
        UltraGridColumn335.Hidden = True
        UltraGridColumn336.Header.VisiblePosition = 55
        UltraGridColumn336.Hidden = True
        UltraGridColumn337.Header.VisiblePosition = 51
        UltraGridColumn337.Width = 107
        UltraGridColumn388.Header.VisiblePosition = 56
        UltraGridColumn388.Hidden = True
        UltraGridColumn389.Header.VisiblePosition = 57
        UltraGridColumn389.Hidden = True
        UltraGridColumn390.Header.VisiblePosition = 58
        UltraGridColumn390.Hidden = True
        UltraGridColumn391.Header.VisiblePosition = 59
        UltraGridColumn391.Hidden = True
        UltraGridColumn392.Header.VisiblePosition = 60
        UltraGridColumn392.Hidden = True
        UltraGridColumn393.Header.VisiblePosition = 61
        UltraGridColumn393.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn105, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn313, UltraGridColumn314, UltraGridColumn315, UltraGridColumn316, UltraGridColumn317, UltraGridColumn318, UltraGridColumn319, UltraGridColumn320, UltraGridColumn321, UltraGridColumn322, UltraGridColumn323, UltraGridColumn324, UltraGridColumn325, UltraGridColumn326, UltraGridColumn327, UltraGridColumn328, UltraGridColumn329, UltraGridColumn330, UltraGridColumn331, UltraGridColumn332, UltraGridColumn333, UltraGridColumn334, UltraGridColumn335, UltraGridColumn336, UltraGridColumn337, UltraGridColumn388, UltraGridColumn389, UltraGridColumn390, UltraGridColumn391, UltraGridColumn392, UltraGridColumn393})
        Me.griOrdenSalida.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griOrdenSalida.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.griOrdenSalida.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenSalida.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenSalida.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance39.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenSalida.DisplayLayout.Override.CellAppearance = Appearance39
        Me.griOrdenSalida.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenSalida.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenSalida.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenSalida.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance40.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenSalida.DisplayLayout.Override.RowAppearance = Appearance40
        Me.griOrdenSalida.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenSalida.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenSalida.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.griOrdenSalida.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griOrdenSalida.Dock = System.Windows.Forms.DockStyle.Top
        Me.griOrdenSalida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenSalida.Location = New System.Drawing.Point(3, 3)
        Me.griOrdenSalida.Name = "griOrdenSalida"
        Me.griOrdenSalida.Size = New System.Drawing.Size(1207, 131)
        Me.griOrdenSalida.TabIndex = 4
        '
        'odOrdenIngreso
        '
        UltraDataColumn57.DataType = GetType(Date)
        UltraDataColumn58.DataType = GetType(Date)
        UltraDataColumn59.DataType = GetType(Date)
        UltraDataColumn60.DataType = GetType(Date)
        UltraDataColumn61.DataType = GetType(Double)
        UltraDataColumn62.DataType = GetType(Double)
        UltraDataColumn63.DataType = GetType(Boolean)
        UltraDataColumn64.DataType = GetType(Boolean)
        UltraDataColumn65.DataType = GetType(Boolean)
        UltraDataColumn66.DataType = GetType(Boolean)
        UltraDataColumn67.DataType = GetType(Boolean)
        UltraDataColumn73.DataType = GetType(Boolean)
        UltraDataColumn75.DataType = GetType(Boolean)
        UltraDataColumn78.DataType = GetType(Boolean)
        Me.odOrdenIngreso.Band.Columns.AddRange(New Object() {UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1221, 495)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.griOrdenComercial)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 159)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1221, 336)
        Me.UltraGroupBox3.TabIndex = 5
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOrdenComercial
        '
        Me.griOrdenComercial.DataSource = Me.odOrdenComercial
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Appearance41.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenComercial.DisplayLayout.Appearance = Appearance41
        UltraGridColumn394.Header.VisiblePosition = 0
        UltraGridColumn394.Hidden = True
        UltraGridColumn395.Header.VisiblePosition = 1
        UltraGridColumn395.Hidden = True
        UltraGridColumn396.Header.VisiblePosition = 2
        UltraGridColumn396.Hidden = True
        UltraGridColumn397.Header.VisiblePosition = 3
        UltraGridColumn397.Hidden = True
        UltraGridColumn398.Header.VisiblePosition = 6
        UltraGridColumn398.Width = 211
        UltraGridColumn399.Header.VisiblePosition = 7
        UltraGridColumn399.Hidden = True
        UltraGridColumn400.Header.VisiblePosition = 8
        UltraGridColumn400.Hidden = True
        UltraGridColumn401.Header.VisiblePosition = 15
        UltraGridColumn401.Width = 149
        UltraGridColumn402.Header.VisiblePosition = 10
        UltraGridColumn402.Hidden = True
        UltraGridColumn403.Header.VisiblePosition = 9
        UltraGridColumn403.Width = 65
        UltraGridColumn404.Header.VisiblePosition = 11
        UltraGridColumn404.Hidden = True
        UltraGridColumn405.Header.VisiblePosition = 18
        UltraGridColumn405.Hidden = True
        UltraGridColumn405.Width = 231
        UltraGridColumn406.Header.VisiblePosition = 5
        UltraGridColumn407.Header.VisiblePosition = 4
        UltraGridColumn407.Width = 114
        UltraGridColumn408.Header.VisiblePosition = 17
        UltraGridColumn408.Width = 248
        UltraGridColumn409.Header.VisiblePosition = 19
        UltraGridColumn409.Hidden = True
        UltraGridColumn410.Header.VisiblePosition = 27
        UltraGridColumn410.Hidden = True
        UltraGridColumn411.Header.VisiblePosition = 20
        UltraGridColumn411.Hidden = True
        UltraGridColumn411.MaskInput = "{double:9.3}"
        UltraGridColumn412.Header.VisiblePosition = 28
        UltraGridColumn412.Hidden = True
        UltraGridColumn412.MaskInput = "{double:9.3}"
        UltraGridColumn413.Header.Caption = "TipoCompra"
        UltraGridColumn413.Header.VisiblePosition = 21
        UltraGridColumn413.Hidden = True
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn414.CellAppearance = Appearance42
        UltraGridColumn414.Format = "#,###,###,##0.00"
        UltraGridColumn414.Header.VisiblePosition = 12
        UltraGridColumn414.MaskInput = "{double:9.2}"
        UltraGridColumn414.Width = 73
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn415.CellAppearance = Appearance43
        UltraGridColumn415.Format = "#,###,###,##0.00"
        UltraGridColumn415.Header.VisiblePosition = 13
        UltraGridColumn415.MaskInput = "{double:9.2}"
        UltraGridColumn415.Width = 73
        Appearance44.TextHAlignAsString = "Right"
        UltraGridColumn416.CellAppearance = Appearance44
        UltraGridColumn416.Format = "#,###,###,##0.00"
        UltraGridColumn416.Header.VisiblePosition = 14
        UltraGridColumn416.MaskInput = "{double:9.2}"
        UltraGridColumn416.Width = 74
        UltraGridColumn417.Header.VisiblePosition = 22
        UltraGridColumn417.Hidden = True
        UltraGridColumn418.Header.VisiblePosition = 23
        UltraGridColumn418.Hidden = True
        UltraGridColumn419.Header.VisiblePosition = 24
        UltraGridColumn419.Hidden = True
        UltraGridColumn420.Header.VisiblePosition = 25
        UltraGridColumn420.Hidden = True
        UltraGridColumn421.Header.VisiblePosition = 26
        UltraGridColumn421.Hidden = True
        UltraGridColumn422.Header.VisiblePosition = 16
        UltraGridColumn422.Width = 104
        UltraGridColumn423.Header.VisiblePosition = 29
        UltraGridColumn423.Hidden = True
        UltraGridColumn424.Header.VisiblePosition = 30
        UltraGridColumn424.Hidden = True
        UltraGridColumn425.Header.VisiblePosition = 31
        UltraGridColumn425.Hidden = True
        UltraGridColumn426.Header.VisiblePosition = 32
        UltraGridColumn426.Hidden = True
        UltraGridColumn427.Header.VisiblePosition = 33
        UltraGridColumn427.Hidden = True
        UltraGridColumn428.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn428.Header.Caption = "Vendedor"
        UltraGridColumn428.Header.VisiblePosition = 34
        UltraGridColumn428.Hidden = True
        UltraGridColumn428.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn428.Width = 258
        UltraGridColumn429.Header.VisiblePosition = 35
        UltraGridColumn429.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn394, UltraGridColumn395, UltraGridColumn396, UltraGridColumn397, UltraGridColumn398, UltraGridColumn399, UltraGridColumn400, UltraGridColumn401, UltraGridColumn402, UltraGridColumn403, UltraGridColumn404, UltraGridColumn405, UltraGridColumn406, UltraGridColumn407, UltraGridColumn408, UltraGridColumn409, UltraGridColumn410, UltraGridColumn411, UltraGridColumn412, UltraGridColumn413, UltraGridColumn414, UltraGridColumn415, UltraGridColumn416, UltraGridColumn417, UltraGridColumn418, UltraGridColumn419, UltraGridColumn420, UltraGridColumn421, UltraGridColumn422, UltraGridColumn423, UltraGridColumn424, UltraGridColumn425, UltraGridColumn426, UltraGridColumn427, UltraGridColumn428, UltraGridColumn429})
        Me.griOrdenComercial.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griOrdenComercial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance45.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Appearance = Appearance45
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance46
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Hidden = True
        Appearance47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance47.BackColor2 = System.Drawing.SystemColors.Control
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.PromptAppearance = Appearance47
        Me.griOrdenComercial.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenComercial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenComercial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenComercial.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.griOrdenComercial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenComercial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance48.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenComercial.DisplayLayout.Override.RowAppearance = Appearance48
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenComercial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenComercial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenComercial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenComercial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenComercial.Location = New System.Drawing.Point(3, 3)
        Me.griOrdenComercial.Name = "griOrdenComercial"
        Me.griOrdenComercial.Size = New System.Drawing.Size(1215, 330)
        Me.griOrdenComercial.TabIndex = 1
        Me.griOrdenComercial.Text = "Grilla2"
        '
        'odOrdenComercial
        '
        UltraDataColumn124.DataType = GetType(Date)
        UltraDataColumn127.DataType = GetType(Short)
        UltraDataColumn129.DataType = GetType(Short)
        UltraDataColumn130.DataType = GetType(Double)
        UltraDataColumn132.DataType = GetType(Double)
        UltraDataColumn133.DataType = GetType(Double)
        UltraDataColumn134.DataType = GetType(Double)
        UltraDataColumn136.DataType = GetType(Date)
        UltraDataColumn138.DataType = GetType(Date)
        UltraDataColumn139.DataType = GetType(Boolean)
        UltraDataColumn141.DataType = GetType(Boolean)
        UltraDataColumn142.DataType = GetType(Boolean)
        UltraDataColumn143.DataType = GetType(Boolean)
        UltraDataColumn145.DataType = GetType(Boolean)
        Me.odOrdenComercial.Band.Columns.AddRange(New Object() {UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147})
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.btnEliminar)
        Me.UltraGroupBox2.Controls.Add(Me.btnAnular)
        Me.UltraGroupBox2.Controls.Add(Me.btnAtender)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 127)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1221, 32)
        Me.UltraGroupBox2.TabIndex = 4
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEliminar
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.btnEliminar.Appearance = Appearance49
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(177, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 26)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAnular
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.ForeColor = System.Drawing.Color.Navy
        Me.btnAnular.Appearance = Appearance50
        Me.btnAnular.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnular.Enabled = False
        Me.btnAnular.Location = New System.Drawing.Point(90, 3)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(87, 26)
        Me.btnAnular.TabIndex = 4
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAtender
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.btnAtender.Appearance = Appearance51
        Me.btnAtender.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAtender.Enabled = False
        Me.btnAtender.Location = New System.Drawing.Point(3, 3)
        Me.btnAtender.Name = "btnAtender"
        Me.btnAtender.Size = New System.Drawing.Size(87, 26)
        Me.btnAtender.TabIndex = 1
        Me.btnAtender.Text = "Atender"
        Me.btnAtender.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox11)
        Me.UltraGroupBox1.Controls.Add(Me.grbNroOrden)
        Me.UltraGroupBox1.Controls.Add(Me.rdbNroOrden)
        Me.UltraGroupBox1.Controls.Add(Me.rdbDatosBasicos)
        Me.UltraGroupBox1.Controls.Add(Me.grbDatosBasicos)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1221, 127)
        Me.UltraGroupBox1.TabIndex = 3
        Me.UltraGroupBox1.Text = "Buscar"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox11
        '
        Me.UltraGroupBox11.Controls.Add(Me.colorTerminado)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel26)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel25)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel24)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel23)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel22)
        Me.UltraGroupBox11.Controls.Add(Me.colorEvaluado)
        Me.UltraGroupBox11.Controls.Add(Me.colorParcial)
        Me.UltraGroupBox11.Controls.Add(Me.colorAtendido)
        Me.UltraGroupBox11.Controls.Add(Me.colorAnulado)
        Me.UltraGroupBox11.Location = New System.Drawing.Point(413, 77)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(661, 42)
        Me.UltraGroupBox11.TabIndex = 344
        Me.UltraGroupBox11.Text = "Estados"
        Me.UltraGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorTerminado
        '
        Me.colorTerminado.Color = System.Drawing.Color.LightGreen
        Me.colorTerminado.Location = New System.Drawing.Point(602, 16)
        Me.colorTerminado.Name = "colorTerminado"
        Me.colorTerminado.Size = New System.Drawing.Size(46, 22)
        Me.colorTerminado.TabIndex = 356
        Me.colorTerminado.Text = "LightGreen"
        '
        'UltraLabel26
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Appearance52.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance52
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel26.Location = New System.Drawing.Point(535, 20)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel26.TabIndex = 355
        Me.UltraLabel26.Text = "Terminada:"
        '
        'UltraLabel25
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Appearance53.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance53
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(429, 20)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel25.TabIndex = 354
        Me.UltraLabel25.Text = "Anulada:"
        '
        'UltraLabel24
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Appearance54.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance54
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(319, 20)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel24.TabIndex = 353
        Me.UltraLabel24.Text = "Atendido:"
        '
        'UltraLabel23
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Appearance55.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance55
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(141, 20)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(120, 15)
        Me.UltraLabel23.TabIndex = 352
        Me.UltraLabel23.Text = "Atendido Parcialmente:"
        '
        'UltraLabel22
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Appearance56.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance56
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(27, 20)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(53, 15)
        Me.UltraLabel22.TabIndex = 351
        Me.UltraLabel22.Text = "Evaluado:"
        '
        'colorEvaluado
        '
        Me.colorEvaluado.Color = System.Drawing.Color.PaleGoldenrod
        Me.colorEvaluado.Location = New System.Drawing.Point(89, 16)
        Me.colorEvaluado.Name = "colorEvaluado"
        Me.colorEvaluado.Size = New System.Drawing.Size(46, 22)
        Me.colorEvaluado.TabIndex = 349
        Me.colorEvaluado.Text = "PaleGoldenrod"
        '
        'colorParcial
        '
        Me.colorParcial.Color = System.Drawing.Color.PaleTurquoise
        Me.colorParcial.Location = New System.Drawing.Point(267, 16)
        Me.colorParcial.Name = "colorParcial"
        Me.colorParcial.Size = New System.Drawing.Size(46, 22)
        Me.colorParcial.TabIndex = 348
        Me.colorParcial.Text = "PaleTurquoise"
        '
        'colorAtendido
        '
        Me.colorAtendido.Color = System.Drawing.Color.SandyBrown
        Me.colorAtendido.Location = New System.Drawing.Point(377, 16)
        Me.colorAtendido.Name = "colorAtendido"
        Me.colorAtendido.Size = New System.Drawing.Size(46, 22)
        Me.colorAtendido.TabIndex = 347
        Me.colorAtendido.Text = "SandyBrown"
        '
        'colorAnulado
        '
        Me.colorAnulado.Color = System.Drawing.Color.LightCoral
        Me.colorAnulado.Location = New System.Drawing.Point(483, 16)
        Me.colorAnulado.Name = "colorAnulado"
        Me.colorAnulado.Size = New System.Drawing.Size(46, 22)
        Me.colorAnulado.TabIndex = 346
        Me.colorAnulado.Text = "LightCoral"
        '
        'grbNroOrden
        '
        Me.grbNroOrden.Controls.Add(Me.UltraLabel19)
        Me.grbNroOrden.Controls.Add(Me.txtNroOrden)
        Me.grbNroOrden.Location = New System.Drawing.Point(413, 35)
        Me.grbNroOrden.Name = "grbNroOrden"
        Me.grbNroOrden.Size = New System.Drawing.Size(220, 39)
        Me.grbNroOrden.TabIndex = 343
        Me.grbNroOrden.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel19
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Appearance57.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance57
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(6, 13)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel19.TabIndex = 344
        Me.UltraLabel19.Text = "Orden:"
        '
        'txtNroOrden
        '
        Me.txtNroOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroOrden.Location = New System.Drawing.Point(51, 9)
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.Size = New System.Drawing.Size(155, 22)
        Me.txtNroOrden.TabIndex = 0
        '
        'rdbNroOrden
        '
        Me.rdbNroOrden.AutoSize = True
        Me.rdbNroOrden.BackColor = System.Drawing.Color.Transparent
        Me.rdbNroOrden.ForeColor = System.Drawing.Color.Navy
        Me.rdbNroOrden.Location = New System.Drawing.Point(413, 18)
        Me.rdbNroOrden.Name = "rdbNroOrden"
        Me.rdbNroOrden.Size = New System.Drawing.Size(72, 17)
        Me.rdbNroOrden.TabIndex = 342
        Me.rdbNroOrden.Text = "NroOrden"
        Me.rdbNroOrden.UseVisualStyleBackColor = False
        '
        'rdbDatosBasicos
        '
        Me.rdbDatosBasicos.AutoSize = True
        Me.rdbDatosBasicos.BackColor = System.Drawing.Color.Transparent
        Me.rdbDatosBasicos.Checked = True
        Me.rdbDatosBasicos.ForeColor = System.Drawing.Color.Navy
        Me.rdbDatosBasicos.Location = New System.Drawing.Point(11, 18)
        Me.rdbDatosBasicos.Name = "rdbDatosBasicos"
        Me.rdbDatosBasicos.Size = New System.Drawing.Size(88, 17)
        Me.rdbDatosBasicos.TabIndex = 341
        Me.rdbDatosBasicos.TabStop = True
        Me.rdbDatosBasicos.Text = "DatosBasicos"
        Me.rdbDatosBasicos.UseVisualStyleBackColor = False
        '
        'grbDatosBasicos
        '
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel15)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel18)
        Me.grbDatosBasicos.Controls.Add(Me.cmbMonedaB)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel16)
        Me.grbDatosBasicos.Controls.Add(Me.dtpFechaInicio)
        Me.grbDatosBasicos.Controls.Add(Me.dtpFechaFin)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel14)
        Me.grbDatosBasicos.Controls.Add(Me.cboEstado)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel13)
        Me.grbDatosBasicos.Controls.Add(Me.cbgClienteB)
        Me.grbDatosBasicos.Location = New System.Drawing.Point(11, 35)
        Me.grbDatosBasicos.Name = "grbDatosBasicos"
        Me.grbDatosBasicos.Size = New System.Drawing.Size(392, 84)
        Me.grbDatosBasicos.TabIndex = 340
        Me.grbDatosBasicos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel15
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Appearance58.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance58
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(6, 9)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel15.TabIndex = 337
        Me.UltraLabel15.Text = "Desde:"
        '
        'UltraLabel18
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Appearance59.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance59
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(7, 62)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel18.TabIndex = 339
        Me.UltraLabel18.Text = "Cliente:"
        '
        'cmbMonedaB
        '
        Me.cmbMonedaB.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbMonedaB.Location = New System.Drawing.Point(210, 5)
        Me.cmbMonedaB.Name = "cmbMonedaB"
        Me.cmbMonedaB.Size = New System.Drawing.Size(173, 22)
        Me.cmbMonedaB.TabIndex = 0
        '
        'UltraLabel16
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Appearance60.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance60
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(8, 35)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel16.TabIndex = 338
        Me.UltraLabel16.Text = "Hasta:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(51, 6)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(99, 21)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(51, 32)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(99, 21)
        Me.dtpFechaFin.TabIndex = 2
        '
        'UltraLabel14
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Appearance61.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance61
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(162, 35)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel14.TabIndex = 336
        Me.UltraLabel14.Text = "Estado:"
        '
        'cboEstado
        '
        Me.cboEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstado.Location = New System.Drawing.Point(210, 31)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(173, 22)
        Me.cboEstado.TabIndex = 3
        Me.cboEstado.ValueMember = "Id"
        '
        'UltraLabel13
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Appearance62.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance62
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(156, 9)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel13.TabIndex = 335
        Me.UltraLabel13.Text = "Moneda:"
        '
        'cbgClienteB
        '
        Me.cbgClienteB.DataSource = Me.odEmpresa
        Appearance63.BackColor = System.Drawing.SystemColors.Window
        Appearance63.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbgClienteB.DisplayLayout.Appearance = Appearance63
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 6
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Width = 250
        UltraGridColumn8.Header.VisiblePosition = 10
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn10.Header.VisiblePosition = 25
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 14
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 16
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 23
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 20
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 21
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 13
        UltraGridColumn19.Header.VisiblePosition = 15
        UltraGridColumn20.Header.VisiblePosition = 17
        UltraGridColumn21.Header.VisiblePosition = 18
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn24.Header.VisiblePosition = 24
        UltraGridColumn25.Header.VisiblePosition = 19
        UltraGridColumn106.Header.VisiblePosition = 11
        UltraGridColumn106.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn106})
        Me.cbgClienteB.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.cbgClienteB.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgClienteB.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance64.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance64.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance64.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgClienteB.DisplayLayout.GroupByBox.Appearance = Appearance64
        Appearance65.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgClienteB.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance65
        Me.cbgClienteB.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance66.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance66.BackColor2 = System.Drawing.SystemColors.Control
        Appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance66.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgClienteB.DisplayLayout.GroupByBox.PromptAppearance = Appearance66
        Me.cbgClienteB.DisplayLayout.MaxColScrollRegions = 1
        Me.cbgClienteB.DisplayLayout.MaxRowScrollRegions = 1
        Appearance67.BackColor = System.Drawing.SystemColors.Window
        Appearance67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbgClienteB.DisplayLayout.Override.ActiveCellAppearance = Appearance67
        Appearance68.BackColor = System.Drawing.SystemColors.Highlight
        Appearance68.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbgClienteB.DisplayLayout.Override.ActiveRowAppearance = Appearance68
        Me.cbgClienteB.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cbgClienteB.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance69.BackColor = System.Drawing.SystemColors.Window
        Me.cbgClienteB.DisplayLayout.Override.CardAreaAppearance = Appearance69
        Appearance70.BorderColor = System.Drawing.Color.Silver
        Appearance70.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbgClienteB.DisplayLayout.Override.CellAppearance = Appearance70
        Me.cbgClienteB.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbgClienteB.DisplayLayout.Override.CellPadding = 0
        Appearance71.BackColor = System.Drawing.SystemColors.Control
        Appearance71.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance71.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance71.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgClienteB.DisplayLayout.Override.GroupByRowAppearance = Appearance71
        Appearance72.TextHAlignAsString = "Left"
        Me.cbgClienteB.DisplayLayout.Override.HeaderAppearance = Appearance72
        Me.cbgClienteB.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cbgClienteB.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance73.BackColor = System.Drawing.SystemColors.Window
        Appearance73.BorderColor = System.Drawing.Color.Silver
        Me.cbgClienteB.DisplayLayout.Override.RowAppearance = Appearance73
        Me.cbgClienteB.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance74.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbgClienteB.DisplayLayout.Override.TemplateAddRowAppearance = Appearance74
        Me.cbgClienteB.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbgClienteB.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgClienteB.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbgClienteB.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbgClienteB.Location = New System.Drawing.Point(55, 58)
        Me.cbgClienteB.Name = "cbgClienteB"
        Me.cbgClienteB.Size = New System.Drawing.Size(328, 23)
        Me.cbgClienteB.TabIndex = 333
        '
        'odEmpresa
        '
        Me.odEmpresa.DataSource = GetType(ERP.EntidadesWCF.e_Empresa)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1221, 495)
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.ficDetalleOrdenComercial)
        Me.UltraGroupBox5.Controls.Add(Me.upMenu)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 151)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(1221, 344)
        Me.UltraGroupBox5.TabIndex = 1
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficDetalleOrdenComercial
        '
        Me.ficDetalleOrdenComercial.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficDetalleOrdenComercial.Controls.Add(Me.UltraTabPageControl3)
        Me.ficDetalleOrdenComercial.Controls.Add(Me.UltraTabPageControl4)
        Me.ficDetalleOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalleOrdenComercial.Location = New System.Drawing.Point(3, 29)
        Me.ficDetalleOrdenComercial.Name = "ficDetalleOrdenComercial"
        Me.ficDetalleOrdenComercial.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficDetalleOrdenComercial.Size = New System.Drawing.Size(1215, 312)
        Me.ficDetalleOrdenComercial.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Detalle"
        UltraTab6.TabPage = Me.UltraTabPageControl4
        UltraTab6.Text = "OrdenSalida"
        Me.ficDetalleOrdenComercial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab6})
        Me.ficDetalleOrdenComercial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1213, 289)
        '
        'upMenu
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Me.upMenu.Appearance = Appearance75
        '
        'upMenu.ClientArea
        '
        Me.upMenu.ClientArea.Controls.Add(Me.btnBoletearSer)
        Me.upMenu.ClientArea.Controls.Add(Me.btnFacturarSer)
        Me.upMenu.ClientArea.Controls.Add(Me.ClientArea_Fill_Panel)
        Me.upMenu.ClientArea.Controls.Add(Me._ClientArea_Toolbars_Dock_Area_Left)
        Me.upMenu.ClientArea.Controls.Add(Me._ClientArea_Toolbars_Dock_Area_Right)
        Me.upMenu.ClientArea.Controls.Add(Me._ClientArea_Toolbars_Dock_Area_Bottom)
        Me.upMenu.ClientArea.Controls.Add(Me._ClientArea_Toolbars_Dock_Area_Top)
        Me.upMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.upMenu.Location = New System.Drawing.Point(3, 3)
        Me.upMenu.Name = "upMenu"
        Me.upMenu.Size = New System.Drawing.Size(1215, 26)
        Me.upMenu.TabIndex = 0
        '
        'btnBoletearSer
        '
        Appearance76.BackColor = System.Drawing.Color.Gainsboro
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Me.btnBoletearSer.Appearance = Appearance76
        Me.btnBoletearSer.Location = New System.Drawing.Point(711, 0)
        Me.btnBoletearSer.Name = "btnBoletearSer"
        Me.btnBoletearSer.Size = New System.Drawing.Size(87, 23)
        Me.btnBoletearSer.TabIndex = 365
        Me.btnBoletearSer.Text = "Bolet. Serv."
        Me.btnBoletearSer.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnFacturarSer
        '
        Appearance77.BackColor = System.Drawing.Color.Gainsboro
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Me.btnFacturarSer.Appearance = Appearance77
        Me.btnFacturarSer.Location = New System.Drawing.Point(621, 0)
        Me.btnFacturarSer.Name = "btnFacturarSer"
        Me.btnFacturarSer.Size = New System.Drawing.Size(87, 23)
        Me.btnFacturarSer.TabIndex = 364
        Me.btnFacturarSer.Text = "Fact. Serv."
        Me.btnFacturarSer.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ClientArea_Fill_Panel
        '
        Me.ClientArea_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClientArea_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClientArea_Fill_Panel.Location = New System.Drawing.Point(0, 28)
        Me.ClientArea_Fill_Panel.Name = "ClientArea_Fill_Panel"
        Me.ClientArea_Fill_Panel.Size = New System.Drawing.Size(1215, 0)
        Me.ClientArea_Fill_Panel.TabIndex = 0
        '
        '_ClientArea_Toolbars_Dock_Area_Left
        '
        Me._ClientArea_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._ClientArea_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._ClientArea_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._ClientArea_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ClientArea_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 28)
        Me._ClientArea_Toolbars_Dock_Area_Left.Name = "_ClientArea_Toolbars_Dock_Area_Left"
        Me._ClientArea_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 0)
        Me._ClientArea_Toolbars_Dock_Area_Left.ToolbarsManager = Me.mnuDetalle
        '
        'mnuDetalle
        '
        Me.mnuDetalle.DesignerFlags = 1
        Me.mnuDetalle.DockWithinContainer = Me.upMenu.ClientArea
        Me.mnuDetalle.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4, ButtonTool5, ButtonTool11})
        UltraToolbar1.Text = "UltraToolbar1"
        Me.mnuDetalle.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance78.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance78
        ButtonTool6.SharedPropsInternal.Caption = "Agregar"
        ButtonTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance79.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        ButtonTool7.SharedPropsInternal.AppearancesSmall.Appearance = Appearance79
        ButtonTool7.SharedPropsInternal.Caption = "Quitar"
        ButtonTool7.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool8.SharedPropsInternal.Caption = "GenerarOS"
        ButtonTool8.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool9.SharedPropsInternal.Caption = "GenerarGuia"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool10.SharedPropsInternal.Caption = "EjecutarOS"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool12.SharedPropsInternal.Caption = "GenerarNotaSalida"
        ButtonTool12.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnuDetalle.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool12})
        '
        '_ClientArea_Toolbars_Dock_Area_Right
        '
        Me._ClientArea_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._ClientArea_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._ClientArea_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._ClientArea_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ClientArea_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1215, 28)
        Me._ClientArea_Toolbars_Dock_Area_Right.Name = "_ClientArea_Toolbars_Dock_Area_Right"
        Me._ClientArea_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 0)
        Me._ClientArea_Toolbars_Dock_Area_Right.ToolbarsManager = Me.mnuDetalle
        '
        '_ClientArea_Toolbars_Dock_Area_Bottom
        '
        Me._ClientArea_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._ClientArea_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._ClientArea_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._ClientArea_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ClientArea_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 26)
        Me._ClientArea_Toolbars_Dock_Area_Bottom.Name = "_ClientArea_Toolbars_Dock_Area_Bottom"
        Me._ClientArea_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1215, 0)
        Me._ClientArea_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.mnuDetalle
        '
        '_ClientArea_Toolbars_Dock_Area_Top
        '
        Me._ClientArea_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._ClientArea_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._ClientArea_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._ClientArea_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ClientArea_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._ClientArea_Toolbars_Dock_Area_Top.Name = "_ClientArea_Toolbars_Dock_Area_Top"
        Me._ClientArea_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1215, 28)
        Me._ClientArea_Toolbars_Dock_Area_Top.ToolbarsManager = Me.mnuDetalle
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.cboTipoPago)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel21)
        Me.UltraGroupBox4.Controls.Add(Me.cbgClienteAlterno)
        Me.UltraGroupBox4.Controls.Add(Me.cboVendedor)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox4.Controls.Add(Me.chkFacturado)
        Me.UltraGroupBox4.Controls.Add(Me.chkFactSer)
        Me.UltraGroupBox4.Controls.Add(Me.btnCrearCtaCte)
        Me.UltraGroupBox4.Controls.Add(Me.txtCodSaldoCtaCte)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel29)
        Me.UltraGroupBox4.Controls.Add(Me.cbgCliente)
        Me.UltraGroupBox4.Controls.Add(Me.lblOperacion)
        Me.UltraGroupBox4.Controls.Add(Me.cbDocumento)
        Me.UltraGroupBox4.Controls.Add(Me.cbRuc)
        Me.UltraGroupBox4.Controls.Add(Me.decTipoCambio)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox4.Controls.Add(Me.btnEmitirDoc)
        Me.UltraGroupBox4.Controls.Add(Me.UltraGroupBox9)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox4.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox4.Controls.Add(Me.dtpFechaPago)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox4.Controls.Add(Me.dtpFecha)
        Me.UltraGroupBox4.Controls.Add(Me.cmbMoneda)
        Me.UltraGroupBox4.Controls.Add(Me.grbDocAsoc)
        Me.UltraGroupBox4.Controls.Add(Me.txtEstado)
        Me.UltraGroupBox4.Controls.Add(Me.txtOrden)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox4.Controls.Add(Me.lbNumeroOrden)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1221, 151)
        Me.UltraGroupBox4.TabIndex = 0
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboTipoPago
        '
        Appearance80.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Appearance = Appearance80
        Me.cboTipoPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance81.Image = 7
        EditorButton1.Appearance = Appearance81
        Me.cboTipoPago.ButtonsRight.Add(EditorButton1)
        Me.cboTipoPago.DisplayMember = "Nombre"
        Me.cboTipoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoPago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Location = New System.Drawing.Point(551, 5)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(230, 22)
        Me.cboTipoPago.TabIndex = 14
        Me.cboTipoPago.ValueMember = "Id"
        '
        'UltraLabel21
        '
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Appearance82.ForeColor = System.Drawing.Color.Navy
        Appearance82.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance82
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(492, 60)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(56, 15)
        Me.UltraLabel21.TabIndex = 19
        Me.UltraLabel21.Text = "Vendedor:"
        '
        'cbgClienteAlterno
        '
        EditorButton2.Key = "Left"
        Me.cbgClienteAlterno.ButtonsLeft.Add(EditorButton2)
        EditorButton3.Key = "Right"
        Me.cbgClienteAlterno.ButtonsRight.Add(EditorButton3)
        Me.cbgClienteAlterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbgClienteAlterno.DataSource = Me.odEmpresa
        Appearance83.BackColor = System.Drawing.SystemColors.Window
        Appearance83.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbgClienteAlterno.DisplayLayout.Appearance = Appearance83
        UltraGridColumn107.Header.VisiblePosition = 0
        UltraGridColumn455.Header.VisiblePosition = 1
        UltraGridColumn455.Hidden = True
        UltraGridColumn456.Header.VisiblePosition = 6
        UltraGridColumn456.Hidden = True
        UltraGridColumn457.Header.VisiblePosition = 2
        UltraGridColumn458.Header.VisiblePosition = 3
        UltraGridColumn459.Header.VisiblePosition = 4
        UltraGridColumn460.Header.VisiblePosition = 8
        UltraGridColumn460.Width = 300
        UltraGridColumn461.Header.VisiblePosition = 10
        UltraGridColumn461.Hidden = True
        UltraGridColumn462.Header.VisiblePosition = 7
        UltraGridColumn463.Header.VisiblePosition = 25
        UltraGridColumn463.Hidden = True
        UltraGridColumn464.Header.VisiblePosition = 9
        UltraGridColumn465.Header.VisiblePosition = 12
        UltraGridColumn465.Hidden = True
        UltraGridColumn466.Header.VisiblePosition = 14
        UltraGridColumn466.Hidden = True
        UltraGridColumn467.Header.VisiblePosition = 16
        UltraGridColumn467.Hidden = True
        UltraGridColumn468.Header.VisiblePosition = 23
        UltraGridColumn468.Hidden = True
        UltraGridColumn469.Header.VisiblePosition = 20
        UltraGridColumn469.Hidden = True
        UltraGridColumn470.Header.VisiblePosition = 21
        UltraGridColumn470.Hidden = True
        UltraGridColumn471.Header.VisiblePosition = 13
        UltraGridColumn472.Header.VisiblePosition = 15
        UltraGridColumn473.Header.VisiblePosition = 17
        UltraGridColumn474.Header.VisiblePosition = 18
        UltraGridColumn475.Header.VisiblePosition = 5
        UltraGridColumn475.Hidden = True
        UltraGridColumn476.Header.VisiblePosition = 22
        UltraGridColumn477.Header.VisiblePosition = 24
        UltraGridColumn478.Header.VisiblePosition = 19
        UltraGridColumn478.Hidden = True
        UltraGridColumn479.Header.VisiblePosition = 11
        UltraGridColumn479.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn107, UltraGridColumn455, UltraGridColumn456, UltraGridColumn457, UltraGridColumn458, UltraGridColumn459, UltraGridColumn460, UltraGridColumn461, UltraGridColumn462, UltraGridColumn463, UltraGridColumn464, UltraGridColumn465, UltraGridColumn466, UltraGridColumn467, UltraGridColumn468, UltraGridColumn469, UltraGridColumn470, UltraGridColumn471, UltraGridColumn472, UltraGridColumn473, UltraGridColumn474, UltraGridColumn475, UltraGridColumn476, UltraGridColumn477, UltraGridColumn478, UltraGridColumn479})
        Me.cbgClienteAlterno.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.cbgClienteAlterno.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgClienteAlterno.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance84.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance84.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance84.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgClienteAlterno.DisplayLayout.GroupByBox.Appearance = Appearance84
        Appearance85.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgClienteAlterno.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance85
        Me.cbgClienteAlterno.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance86.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance86.BackColor2 = System.Drawing.SystemColors.Control
        Appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance86.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgClienteAlterno.DisplayLayout.GroupByBox.PromptAppearance = Appearance86
        Me.cbgClienteAlterno.DisplayLayout.MaxColScrollRegions = 1
        Me.cbgClienteAlterno.DisplayLayout.MaxRowScrollRegions = 1
        Appearance87.BackColor = System.Drawing.SystemColors.Window
        Appearance87.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbgClienteAlterno.DisplayLayout.Override.ActiveCellAppearance = Appearance87
        Appearance88.BackColor = System.Drawing.SystemColors.Highlight
        Appearance88.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbgClienteAlterno.DisplayLayout.Override.ActiveRowAppearance = Appearance88
        Me.cbgClienteAlterno.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgClienteAlterno.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance89.BackColor = System.Drawing.SystemColors.Window
        Me.cbgClienteAlterno.DisplayLayout.Override.CardAreaAppearance = Appearance89
        Appearance90.BorderColor = System.Drawing.Color.Silver
        Appearance90.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbgClienteAlterno.DisplayLayout.Override.CellAppearance = Appearance90
        Me.cbgClienteAlterno.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbgClienteAlterno.DisplayLayout.Override.CellPadding = 0
        Appearance91.BackColor = System.Drawing.SystemColors.Control
        Appearance91.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance91.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance91.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgClienteAlterno.DisplayLayout.Override.GroupByRowAppearance = Appearance91
        Appearance92.TextHAlignAsString = "Left"
        Me.cbgClienteAlterno.DisplayLayout.Override.HeaderAppearance = Appearance92
        Me.cbgClienteAlterno.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance93.BackColor = System.Drawing.SystemColors.Window
        Appearance93.BorderColor = System.Drawing.Color.Silver
        Me.cbgClienteAlterno.DisplayLayout.Override.RowAppearance = Appearance93
        Me.cbgClienteAlterno.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance94.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbgClienteAlterno.DisplayLayout.Override.TemplateAddRowAppearance = Appearance94
        Me.cbgClienteAlterno.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbgClienteAlterno.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgClienteAlterno.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbgClienteAlterno.DisplayMember = "Nombre"
        Me.cbgClienteAlterno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbgClienteAlterno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgClienteAlterno.Location = New System.Drawing.Point(1025, 52)
        Me.cbgClienteAlterno.Name = "cbgClienteAlterno"
        Me.cbgClienteAlterno.Size = New System.Drawing.Size(303, 23)
        Me.cbgClienteAlterno.TabIndex = 368
        Me.cbgClienteAlterno.ValueMember = "Id"
        Me.cbgClienteAlterno.Visible = False
        '
        'cboVendedor
        '
        Me.cboVendedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboVendedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboVendedor.Location = New System.Drawing.Point(551, 56)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(230, 22)
        Me.cboVendedor.TabIndex = 20
        '
        'UltraLabel11
        '
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Appearance95.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance95
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(1063, 10)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(56, 15)
        Me.UltraLabel11.TabIndex = 366
        Me.UltraLabel11.Text = "Vendedor:"
        Me.UltraLabel11.Visible = False
        '
        'chkFacturado
        '
        Me.chkFacturado.AutoSize = True
        Me.chkFacturado.BackColor = System.Drawing.Color.Transparent
        Me.chkFacturado.ForeColor = System.Drawing.Color.Navy
        Me.chkFacturado.Location = New System.Drawing.Point(1179, 60)
        Me.chkFacturado.Name = "chkFacturado"
        Me.chkFacturado.Size = New System.Drawing.Size(120, 17)
        Me.chkFacturado.TabIndex = 22
        Me.chkFacturado.Text = "Servicio Facturado?"
        Me.chkFacturado.UseVisualStyleBackColor = False
        Me.chkFacturado.Visible = False
        '
        'chkFactSer
        '
        Me.chkFactSer.AutoSize = True
        Me.chkFactSer.BackColor = System.Drawing.Color.Transparent
        Me.chkFactSer.ForeColor = System.Drawing.Color.Navy
        Me.chkFactSer.Location = New System.Drawing.Point(477, 122)
        Me.chkFactSer.Name = "chkFactSer"
        Me.chkFactSer.Size = New System.Drawing.Size(100, 17)
        Me.chkFactSer.TabIndex = 24
        Me.chkFactSer.Text = "Servicio Carga?"
        Me.chkFactSer.UseVisualStyleBackColor = False
        '
        'btnCrearCtaCte
        '
        Appearance96.BackColor = System.Drawing.Color.Transparent
        Me.btnCrearCtaCte.Appearance = Appearance96
        Me.btnCrearCtaCte.AutoSize = True
        Me.btnCrearCtaCte.Enabled = False
        Me.btnCrearCtaCte.Location = New System.Drawing.Point(1191, 88)
        Me.btnCrearCtaCte.Name = "btnCrearCtaCte"
        Me.btnCrearCtaCte.Size = New System.Drawing.Size(10, 10)
        Me.btnCrearCtaCte.TabIndex = 28
        Me.btnCrearCtaCte.Visible = False
        '
        'txtCodSaldoCtaCte
        '
        Me.txtCodSaldoCtaCte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodSaldoCtaCte.Enabled = False
        Me.txtCodSaldoCtaCte.Location = New System.Drawing.Point(1052, 90)
        Me.txtCodSaldoCtaCte.MaxLength = 20
        Me.txtCodSaldoCtaCte.Name = "txtCodSaldoCtaCte"
        Me.txtCodSaldoCtaCte.ReadOnly = True
        Me.txtCodSaldoCtaCte.Size = New System.Drawing.Size(133, 22)
        Me.txtCodSaldoCtaCte.TabIndex = 28
        Me.txtCodSaldoCtaCte.Tag = "Numero Documento"
        Me.txtCodSaldoCtaCte.Visible = False
        '
        'UltraLabel29
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel29.Appearance = Appearance97
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Enabled = False
        Me.UltraLabel29.Location = New System.Drawing.Point(1001, 94)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(45, 15)
        Me.UltraLabel29.TabIndex = 27
        Me.UltraLabel29.Text = "Cta Cte:"
        Me.UltraLabel29.Visible = False
        '
        'cbgCliente
        '
        EditorButton4.Key = "Left"
        Me.cbgCliente.ButtonsLeft.Add(EditorButton4)
        EditorButton5.Key = "Right"
        Me.cbgCliente.ButtonsRight.Add(EditorButton5)
        Me.cbgCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbgCliente.DataSource = Me.odEmpresa
        Appearance98.BackColor = System.Drawing.SystemColors.Window
        Appearance98.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbgCliente.DisplayLayout.Appearance = Appearance98
        UltraGridColumn108.Header.VisiblePosition = 0
        UltraGridColumn480.Header.VisiblePosition = 1
        UltraGridColumn480.Hidden = True
        UltraGridColumn481.Header.VisiblePosition = 6
        UltraGridColumn481.Hidden = True
        UltraGridColumn482.Header.VisiblePosition = 2
        UltraGridColumn483.Header.VisiblePosition = 3
        UltraGridColumn484.Header.VisiblePosition = 4
        UltraGridColumn485.Header.VisiblePosition = 8
        UltraGridColumn485.Width = 300
        UltraGridColumn486.Header.VisiblePosition = 10
        UltraGridColumn486.Hidden = True
        UltraGridColumn487.Header.VisiblePosition = 7
        UltraGridColumn488.Header.VisiblePosition = 25
        UltraGridColumn488.Hidden = True
        UltraGridColumn489.Header.VisiblePosition = 9
        UltraGridColumn490.Header.VisiblePosition = 12
        UltraGridColumn490.Hidden = True
        UltraGridColumn491.Header.VisiblePosition = 14
        UltraGridColumn491.Hidden = True
        UltraGridColumn492.Header.VisiblePosition = 16
        UltraGridColumn492.Hidden = True
        UltraGridColumn493.Header.VisiblePosition = 23
        UltraGridColumn493.Hidden = True
        UltraGridColumn494.Header.VisiblePosition = 20
        UltraGridColumn494.Hidden = True
        UltraGridColumn495.Header.VisiblePosition = 21
        UltraGridColumn495.Hidden = True
        UltraGridColumn496.Header.VisiblePosition = 13
        UltraGridColumn497.Header.VisiblePosition = 15
        UltraGridColumn498.Header.VisiblePosition = 17
        UltraGridColumn499.Header.VisiblePosition = 18
        UltraGridColumn500.Header.VisiblePosition = 5
        UltraGridColumn500.Hidden = True
        UltraGridColumn501.Header.VisiblePosition = 22
        UltraGridColumn502.Header.VisiblePosition = 24
        UltraGridColumn503.Header.VisiblePosition = 19
        UltraGridColumn503.Hidden = True
        UltraGridColumn504.Header.VisiblePosition = 11
        UltraGridColumn504.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn108, UltraGridColumn480, UltraGridColumn481, UltraGridColumn482, UltraGridColumn483, UltraGridColumn484, UltraGridColumn485, UltraGridColumn486, UltraGridColumn487, UltraGridColumn488, UltraGridColumn489, UltraGridColumn490, UltraGridColumn491, UltraGridColumn492, UltraGridColumn493, UltraGridColumn494, UltraGridColumn495, UltraGridColumn496, UltraGridColumn497, UltraGridColumn498, UltraGridColumn499, UltraGridColumn500, UltraGridColumn501, UltraGridColumn502, UltraGridColumn503, UltraGridColumn504})
        Me.cbgCliente.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.cbgCliente.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgCliente.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance99.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance99.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance99.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.GroupByBox.Appearance = Appearance99
        Appearance100.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgCliente.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance100
        Me.cbgCliente.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance101.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance101.BackColor2 = System.Drawing.SystemColors.Control
        Appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance101.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgCliente.DisplayLayout.GroupByBox.PromptAppearance = Appearance101
        Me.cbgCliente.DisplayLayout.MaxColScrollRegions = 1
        Me.cbgCliente.DisplayLayout.MaxRowScrollRegions = 1
        Appearance102.BackColor = System.Drawing.SystemColors.Window
        Appearance102.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbgCliente.DisplayLayout.Override.ActiveCellAppearance = Appearance102
        Appearance103.BackColor = System.Drawing.SystemColors.Highlight
        Appearance103.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbgCliente.DisplayLayout.Override.ActiveRowAppearance = Appearance103
        Me.cbgCliente.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgCliente.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance104.BackColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.Override.CardAreaAppearance = Appearance104
        Appearance105.BorderColor = System.Drawing.Color.Silver
        Appearance105.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbgCliente.DisplayLayout.Override.CellAppearance = Appearance105
        Me.cbgCliente.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbgCliente.DisplayLayout.Override.CellPadding = 0
        Appearance106.BackColor = System.Drawing.SystemColors.Control
        Appearance106.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance106.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance106.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.Override.GroupByRowAppearance = Appearance106
        Appearance107.TextHAlignAsString = "Left"
        Me.cbgCliente.DisplayLayout.Override.HeaderAppearance = Appearance107
        Me.cbgCliente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance108.BackColor = System.Drawing.SystemColors.Window
        Appearance108.BorderColor = System.Drawing.Color.Silver
        Me.cbgCliente.DisplayLayout.Override.RowAppearance = Appearance108
        Me.cbgCliente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance109.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbgCliente.DisplayLayout.Override.TemplateAddRowAppearance = Appearance109
        Me.cbgCliente.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbgCliente.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgCliente.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbgCliente.DisplayMember = "Nombre"
        Me.cbgCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbgCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgCliente.Location = New System.Drawing.Point(72, 57)
        Me.cbgCliente.Name = "cbgCliente"
        Me.cbgCliente.Size = New System.Drawing.Size(338, 23)
        Me.cbgCliente.TabIndex = 9
        Me.cbgCliente.ValueMember = "Id"
        '
        'lblOperacion
        '
        Appearance110.BackColor = System.Drawing.Color.Transparent
        Appearance110.ForeColor = System.Drawing.Color.Red
        Appearance110.TextVAlignAsString = "Middle"
        Me.lblOperacion.Appearance = Appearance110
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacion.Location = New System.Drawing.Point(586, 126)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(0, 0)
        Me.lblOperacion.TabIndex = 25
        '
        'cbDocumento
        '
        Me.cbDocumento.AutoSize = True
        Me.cbDocumento.BackColor = System.Drawing.Color.Transparent
        Me.cbDocumento.ForeColor = System.Drawing.Color.Navy
        Me.cbDocumento.Location = New System.Drawing.Point(10, 84)
        Me.cbDocumento.Name = "cbDocumento"
        Me.cbDocumento.Size = New System.Drawing.Size(15, 14)
        Me.cbDocumento.TabIndex = 11
        Me.cbDocumento.UseVisualStyleBackColor = False
        '
        'cbRuc
        '
        Me.cbRuc.AutoSize = True
        Me.cbRuc.BackColor = System.Drawing.Color.Transparent
        Me.cbRuc.ForeColor = System.Drawing.Color.Navy
        Me.cbRuc.Location = New System.Drawing.Point(416, 58)
        Me.cbRuc.Name = "cbRuc"
        Me.cbRuc.Size = New System.Drawing.Size(47, 17)
        Me.cbRuc.TabIndex = 10
        Me.cbRuc.Text = "RUC"
        Me.cbRuc.UseVisualStyleBackColor = False
        '
        'decTipoCambio
        '
        Me.decTipoCambio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTipoCambio.Location = New System.Drawing.Point(694, 31)
        Me.decTipoCambio.MaskInput = "{double:2.3}"
        Me.decTipoCambio.MaxValue = 5.0R
        Me.decTipoCambio.MinValue = 0R
        Me.decTipoCambio.Name = "decTipoCambio"
        Me.decTipoCambio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTipoCambio.Size = New System.Drawing.Size(44, 22)
        Me.decTipoCambio.TabIndex = 18
        Me.decTipoCambio.TabStop = False
        '
        'UltraLabel12
        '
        Appearance111.BackColor = System.Drawing.Color.Transparent
        Appearance111.ForeColor = System.Drawing.Color.Navy
        Appearance111.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance111
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(660, 35)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(28, 15)
        Me.UltraLabel12.TabIndex = 17
        Me.UltraLabel12.Text = "T.C.:"
        '
        'btnEmitirDoc
        '
        Appearance112.BackColor = System.Drawing.Color.Gainsboro
        Appearance112.ForeColor = System.Drawing.Color.Navy
        Me.btnEmitirDoc.Appearance = Appearance112
        Me.btnEmitirDoc.Enabled = False
        Me.btnEmitirDoc.Location = New System.Drawing.Point(477, 84)
        Me.btnEmitirDoc.Name = "btnEmitirDoc"
        Me.btnEmitirDoc.Size = New System.Drawing.Size(87, 28)
        Me.btnEmitirDoc.TabIndex = 23
        Me.btnEmitirDoc.Text = "Emi. Doc."
        Me.btnEmitirDoc.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGroupBox9
        '
        Me.UltraGroupBox9.Controls.Add(Me.decTotal)
        Me.UltraGroupBox9.Controls.Add(Me.decImpuesto)
        Me.UltraGroupBox9.Controls.Add(Me.decSubTotal)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox9.Location = New System.Drawing.Point(570, 84)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(494, 34)
        Me.UltraGroupBox9.TabIndex = 26
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decTotal
        '
        Me.decTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotal.Location = New System.Drawing.Point(383, 6)
        Me.decTotal.MaskInput = "{double:9.2}"
        Me.decTotal.Name = "decTotal"
        Me.decTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotal.ReadOnly = True
        Me.decTotal.Size = New System.Drawing.Size(100, 22)
        Me.decTotal.TabIndex = 5
        '
        'decImpuesto
        '
        Me.decImpuesto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImpuesto.Location = New System.Drawing.Point(238, 6)
        Me.decImpuesto.MaskInput = "{double:9.2}"
        Me.decImpuesto.Name = "decImpuesto"
        Me.decImpuesto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImpuesto.ReadOnly = True
        Me.decImpuesto.Size = New System.Drawing.Size(100, 22)
        Me.decImpuesto.TabIndex = 3
        '
        'decSubTotal
        '
        Me.decSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSubTotal.Location = New System.Drawing.Point(65, 6)
        Me.decSubTotal.MaskInput = "{double:9.2}"
        Me.decSubTotal.Name = "decSubTotal"
        Me.decSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSubTotal.ReadOnly = True
        Me.decSubTotal.Size = New System.Drawing.Size(100, 22)
        Me.decSubTotal.TabIndex = 1
        '
        'UltraLabel10
        '
        Appearance113.BackColor = System.Drawing.Color.Transparent
        Appearance113.ForeColor = System.Drawing.Color.Navy
        Appearance113.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance113
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(344, 10)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel10.TabIndex = 4
        Me.UltraLabel10.Text = "Total:"
        '
        'UltraLabel7
        '
        Appearance114.BackColor = System.Drawing.Color.Transparent
        Appearance114.ForeColor = System.Drawing.Color.Navy
        Appearance114.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance114
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(7, 10)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel7.TabIndex = 0
        Me.UltraLabel7.Text = "SubTotal:"
        '
        'UltraLabel9
        '
        Appearance115.BackColor = System.Drawing.Color.Transparent
        Appearance115.ForeColor = System.Drawing.Color.Navy
        Appearance115.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance115
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(173, 10)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(55, 15)
        Me.UltraLabel9.TabIndex = 2
        Me.UltraLabel9.Text = "Impuesto:"
        '
        'UltraLabel6
        '
        Appearance116.BackColor = System.Drawing.Color.Transparent
        Appearance116.ForeColor = System.Drawing.Color.Navy
        Appearance116.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance116
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(819, 10)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel6.TabIndex = 21
        Me.UltraLabel6.Text = "Glosa:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Location = New System.Drawing.Point(860, 6)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(186, 69)
        Me.txtGlosa.TabIndex = 22
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Enabled = False
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(551, 32)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(103, 21)
        Me.dtpFechaPago.TabIndex = 16
        '
        'UltraLabel5
        '
        Appearance117.BackColor = System.Drawing.Color.Transparent
        Appearance117.ForeColor = System.Drawing.Color.Navy
        Appearance117.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance117
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(483, 35)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(67, 15)
        Me.UltraLabel5.TabIndex = 15
        Me.UltraLabel5.Text = "FechaCobro:"
        '
        'UltraLabel4
        '
        Appearance118.BackColor = System.Drawing.Color.Transparent
        Appearance118.ForeColor = System.Drawing.Color.Navy
        Appearance118.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance118
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(491, 10)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel4.TabIndex = 13
        Me.UltraLabel4.Text = "TipoCobro:"
        '
        'UltraLabel3
        '
        Appearance119.BackColor = System.Drawing.Color.Transparent
        Appearance119.ForeColor = System.Drawing.Color.Navy
        Appearance119.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance119
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(277, 35)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel3.TabIndex = 6
        Me.UltraLabel3.Text = "Moneda:"
        '
        'UltraLabel2
        '
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Appearance120.ForeColor = System.Drawing.Color.Navy
        Appearance120.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance120
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(257, 10)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(68, 15)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "FechaOrden:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(331, 6)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(134, 21)
        Me.dtpFecha.TabIndex = 3
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbMoneda.Location = New System.Drawing.Point(331, 31)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(134, 22)
        Me.cmbMoneda.TabIndex = 7
        Me.cmbMoneda.ValueMember = "Id"
        '
        'grbDocAsoc
        '
        Me.grbDocAsoc.Controls.Add(Me.txtEstadoDoc)
        Me.grbDocAsoc.Controls.Add(Me.txtNumero)
        Me.grbDocAsoc.Controls.Add(Me.UltraLabel1)
        Me.grbDocAsoc.Controls.Add(Me.txtSerie)
        Me.grbDocAsoc.Controls.Add(Me.cmbTipoDocumento)
        Me.grbDocAsoc.Controls.Add(Me.dtpFechaDoc)
        Me.grbDocAsoc.Enabled = False
        Me.grbDocAsoc.Location = New System.Drawing.Point(25, 84)
        Me.grbDocAsoc.Name = "grbDocAsoc"
        Me.grbDocAsoc.Size = New System.Drawing.Size(446, 60)
        Me.grbDocAsoc.TabIndex = 12
        Me.grbDocAsoc.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtEstadoDoc
        '
        Me.txtEstadoDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstadoDoc.Location = New System.Drawing.Point(241, 33)
        Me.txtEstadoDoc.Name = "txtEstadoDoc"
        Me.txtEstadoDoc.ReadOnly = True
        Me.txtEstadoDoc.Size = New System.Drawing.Size(199, 22)
        Me.txtEstadoDoc.TabIndex = 5
        '
        'txtNumero
        '
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Location = New System.Drawing.Point(320, 6)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(120, 22)
        Me.txtNumero.TabIndex = 4
        '
        'UltraLabel1
        '
        Appearance121.BackColor = System.Drawing.Color.Transparent
        Appearance121.ForeColor = System.Drawing.Color.Navy
        Appearance121.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance121
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 35)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(57, 15)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "FechaDoc:"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Location = New System.Drawing.Point(241, 6)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(73, 22)
        Me.txtSerie.TabIndex = 3
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(6, 6)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(229, 22)
        Me.cmbTipoDocumento.TabIndex = 0
        '
        'dtpFechaDoc
        '
        Me.dtpFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDoc.Location = New System.Drawing.Point(69, 33)
        Me.dtpFechaDoc.Name = "dtpFechaDoc"
        Me.dtpFechaDoc.Size = New System.Drawing.Size(166, 21)
        Me.dtpFechaDoc.TabIndex = 2
        '
        'txtEstado
        '
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Location = New System.Drawing.Point(72, 31)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(159, 22)
        Me.txtEstado.TabIndex = 5
        '
        'txtOrden
        '
        Me.txtOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOrden.Location = New System.Drawing.Point(72, 6)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.ReadOnly = True
        Me.txtOrden.Size = New System.Drawing.Size(159, 22)
        Me.txtOrden.TabIndex = 1
        '
        'UltraLabel8
        '
        Appearance122.BackColor = System.Drawing.Color.Transparent
        Appearance122.ForeColor = System.Drawing.Color.Navy
        Appearance122.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance122
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(24, 60)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel8.TabIndex = 8
        Me.UltraLabel8.Text = "Cliente:"
        '
        'UltraLabel17
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Appearance123.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance123
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(24, 35)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel17.TabIndex = 4
        Me.UltraLabel17.Text = "Estado:"
        '
        'lbNumeroOrden
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Appearance124.TextVAlignAsString = "Middle"
        Me.lbNumeroOrden.Appearance = Appearance124
        Me.lbNumeroOrden.AutoSize = True
        Me.lbNumeroOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumeroOrden.Location = New System.Drawing.Point(27, 10)
        Me.lbNumeroOrden.Name = "lbNumeroOrden"
        Me.lbNumeroOrden.Size = New System.Drawing.Size(39, 15)
        Me.lbNumeroOrden.TabIndex = 0
        Me.lbNumeroOrden.Text = "Orden:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'odAlmacenMaterial
        '
        UltraDataColumn148.DataType = GetType(Boolean)
        UltraDataColumn156.DataType = GetType(Double)
        UltraDataColumn164.DataType = GetType(Double)
        UltraDataColumn165.DataType = GetType(Double)
        UltraDataColumn166.DataType = GetType(Double)
        Me.odAlmacenMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171})
        '
        'ficOrdenComercial
        '
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabPageControl2)
        Me.ficOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOrdenComercial.Location = New System.Drawing.Point(0, 0)
        Me.ficOrdenComercial.Name = "ficOrdenComercial"
        Me.ficOrdenComercial.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOrdenComercial.Size = New System.Drawing.Size(1223, 518)
        Me.ficOrdenComercial.TabIndex = 0
        UltraTab7.TabPage = Me.UltraTabPageControl1
        UltraTab7.Text = "Lista"
        UltraTab8.TabPage = Me.UltraTabPageControl2
        UltraTab8.Text = "Mantenimiento"
        Me.ficOrdenComercial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab7, UltraTab8})
        Me.ficOrdenComercial.TabStop = False
        Me.ficOrdenComercial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1221, 495)
        '
        'frm_Calibraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 518)
        Me.Controls.Add(Me.ficOrdenComercial)
        Me.Name = "frm_Calibraciones"
        Me.Text = "Calibraciones"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox10.ResumeLayout(False)
        CType(Me.griOrdenComercialMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenComMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        CType(Me.griAlmacenMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox12.ResumeLayout(False)
        Me.UltraGroupBox12.PerformLayout()
        CType(Me.chkTipoMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDestinoViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrigenViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chbBuscarCod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        CType(Me.griDetalleOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odDetalleOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.griOrdenSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox11.ResumeLayout(False)
        Me.UltraGroupBox11.PerformLayout()
        CType(Me.colorTerminado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorEvaluado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorParcial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAtendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbNroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNroOrden.ResumeLayout(False)
        Me.grbNroOrden.PerformLayout()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosBasicos.ResumeLayout(False)
        Me.grbDatosBasicos.PerformLayout()
        CType(Me.cmbMonedaB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgClienteB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.ficDetalleOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalleOrdenComercial.ResumeLayout(False)
        Me.upMenu.ClientArea.ResumeLayout(False)
        Me.upMenu.ResumeLayout(False)
        Me.ClientArea_Fill_Panel.ResumeLayout(False)
        CType(Me.mnuDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgClienteAlterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodSaldoCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox9.ResumeLayout(False)
        Me.UltraGroupBox9.PerformLayout()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decImpuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDocAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDocAsoc.ResumeLayout(False)
        Me.grbDocAsoc.PerformLayout()
        CType(Me.txtEstadoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.odAlmacenMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOrdenComercial.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficOrdenComercial As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griOrdenComercial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Filtro As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents odOrdenComercial As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odOrdenComMat As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odDetalleOrden As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents cmbMonedaB As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbMoneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents grbDocAsoc As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtEstadoDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNumero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSerie As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmbTipoDocumento As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents dtpFechaDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEstado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtOrden As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbNumeroOrden As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decTipoCambio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnEmitirDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox9 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents decTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents decImpuesto As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents decSubTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAtender As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbgClienteB As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents rdbNroOrden As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDatosBasicos As System.Windows.Forms.RadioButton
    Friend WithEvents grbDatosBasicos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents colorEvaluado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorParcial As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorAtendido As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorAnulado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents grbNroOrden As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNroOrden As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents odAlmacenMaterial As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ficDetalleOrdenComercial As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox10 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griOrdenComercialMaterial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gbeMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griDetalleOrden As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents odEmpresa As System.Windows.Forms.BindingSource
    Friend WithEvents cbRuc As System.Windows.Forms.CheckBox
    Friend WithEvents cbDocumento As System.Windows.Forms.CheckBox
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblOperacion As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAnular As Infragistics.Win.Misc.UltraButton
    Friend WithEvents colorTerminado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbgCliente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griAlmacenMaterial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox12 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chbBuscarCod As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnBuscarMat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtMaterial As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    ' Friend WithEvents _ClientArea_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents mnuDetalle As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    'Friend WithEvents _ClientArea_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    'Friend WithEvents _ClientArea_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    'Friend WithEvents _ClientArea_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents chkTransporte As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboDestinoViaje As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboOrigenViaje As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCrearCtaCte As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtCodSaldoCtaCte As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents upMenu As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents ClientArea_Fill_Panel As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents _ClientArea_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _ClientArea_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _ClientArea_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _ClientArea_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents btnFacturarSer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chkFactSer As System.Windows.Forms.CheckBox
    Friend WithEvents chkFacturado As System.Windows.Forms.CheckBox
    Friend WithEvents btnBoletearSer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_ActualizarDetOrden As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboVendedor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkTipoMaterial As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnEliminar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbgClienteAlterno As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboTipoPago As ISL.Controles.ComboMaestros
    Friend WithEvents EMaterialBindingSource As BindingSource
    Friend WithEvents odOrdenIngreso As Controles.OrigenDatos
    Friend WithEvents griOrdenSalida As Controles.Grilla
End Class
