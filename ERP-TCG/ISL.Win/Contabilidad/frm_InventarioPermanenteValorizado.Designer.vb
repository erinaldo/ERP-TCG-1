<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_InventarioPermanenteValorizado
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejecicio")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mes")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorTotal")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCuenta")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomCuenta")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCuenta")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NomCuenta")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacen")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ejecicio")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mes")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorTotal")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Item")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMaterial")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidMedida")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMat")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDoc")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOper")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantIng")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostUnitIng")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoTotalIng")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantSal")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostUnitSal")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoTotalSal")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantTotal")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnit")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoTotal")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoFuncion")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegistroInventario")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoFila")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Entradas", 178346563)
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Salidas", 178346564)
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup3 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("SaldoFinal", 178346565)
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup4 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Documento", 178346566)
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Item")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodMaterial")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidMedida")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMat")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDoc")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOper")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantIng")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostUnitIng")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoTotalIng")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantSal")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostUnitSal")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoTotalSal")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantTotal")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoUnit")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoTotal")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoFuncion")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoDocumento")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRegistroInventario")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoFila")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrifo")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccion")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGrifo")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDireccion")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_CortesPeriodo = New ISL.Controles.Grilla(Me.components)
        Me.od_Cortes = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.grid_kardex = New ISL.Controles.Grilla(Me.components)
        Me.od_Kardex = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.gb_Montos = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DecTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecIngresos = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecEgresos = New ISL.Controles.NumeroDecimal(Me.components)
        Me.gb_SubAlmacen = New System.Windows.Forms.GroupBox()
        Me.grid_ListaSubAlmacen = New ISL.Controles.Grilla(Me.components)
        Me.odSubAlmacen = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.gb_Periodo = New System.Windows.Forms.GroupBox()
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbCuenta = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboAlmacen = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cbo_Mes = New ISL.Controles.Combo(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.Año1 = New ISL.Win.Año()
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.tc_RegInvPermVal = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.odCuenta = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grid_CortesPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.od_Cortes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.grid_kardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.od_Kardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        Me.gb_Montos.SuspendLayout()
        CType(Me.DecTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_SubAlmacen.SuspendLayout()
        CType(Me.grid_ListaSubAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odSubAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Periodo.SuspendLayout()
        CType(Me.cmbCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Año1.SuspendLayout()
        CType(Me.object_abe9bf2e_f506_4416_bb16_36035415a385, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tc_RegInvPermVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_RegInvPermVal.SuspendLayout()
        CType(Me.odCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.grid_CortesPeriodo)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1162, 477)
        '
        'grid_CortesPeriodo
        '
        Me.grid_CortesPeriodo.DataSource = Me.od_Cortes
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 74
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 146
        UltraGridColumn39.Header.VisiblePosition = 4
        UltraGridColumn39.Width = 227
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn39, UltraGridColumn6})
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.Caption = "Nro Cuenta"
        UltraGridColumn10.Header.VisiblePosition = 3
        UltraGridColumn10.Width = 55
        UltraGridColumn11.Header.Caption = "Descripcion"
        UltraGridColumn11.Header.VisiblePosition = 4
        UltraGridColumn11.Width = 227
        UltraGridColumn12.Header.VisiblePosition = 5
        UltraGridColumn12.Width = 146
        UltraGridColumn40.Header.VisiblePosition = 6
        UltraGridColumn40.Width = 243
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn40})
        Me.grid_CortesPeriodo.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_CortesPeriodo.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid_CortesPeriodo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_CortesPeriodo.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_CortesPeriodo.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_CortesPeriodo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_CortesPeriodo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_CortesPeriodo.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_CortesPeriodo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_CortesPeriodo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_CortesPeriodo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_CortesPeriodo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_CortesPeriodo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_CortesPeriodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_CortesPeriodo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_CortesPeriodo.Location = New System.Drawing.Point(0, 0)
        Me.grid_CortesPeriodo.Name = "grid_CortesPeriodo"
        Me.grid_CortesPeriodo.Size = New System.Drawing.Size(1162, 477)
        Me.grid_CortesPeriodo.TabIndex = 10
        '
        'od_Cortes
        '
        Me.od_Cortes.AllowAdd = False
        Me.od_Cortes.AllowDelete = False
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
        Me.od_Cortes.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        Me.od_Cortes.Band.Columns.AddRange(New Object() {UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        Me.od_Cortes.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object(-1) {}, New Object() {CType("Band 1", Object), CType(New Infragistics.Win.UltraWinDataSource.UltraDataRowsCollection(New Infragistics.Win.UltraWinDataSource.UltraDataRow(-1) {}, Nothing), Object)})})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_Espera)
        Me.UltraTabPageControl2.Controls.Add(Me.grid_kardex)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1162, 477)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(509, 301)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 18
        Me.ugb_Espera.Visible = False
        '
        'grid_kardex
        '
        Me.grid_kardex.DataSource = Me.od_Kardex
        UltraGridBand3.ColHeaderLines = 2
        UltraGridColumn13.Header.VisiblePosition = 22
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.Header.VisiblePosition = 26
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        UltraGridColumn15.CellAppearance = Appearance1
        UltraGridColumn15.CellMultiLine = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn15.Header.VisiblePosition = 2
        Appearance2.TextVAlignAsString = "Middle"
        UltraGridColumn15.MergedCellAppearance = Appearance2
        UltraGridColumn15.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(269, 20)
        UltraGridColumn15.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn15.Width = 210
        UltraGridColumn44.Header.VisiblePosition = 27
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn45.Header.VisiblePosition = 28
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.TextVAlignAsString = "Middle"
        UltraGridColumn16.CellAppearance = Appearance3
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridColumn16.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Never
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn16.RowLayoutColumnInfo.ParentGroupKey = "Documento"
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 20)
        UltraGridColumn16.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 23)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn16.Width = 91
        Appearance4.TextHAlignAsString = "Center"
        UltraGridColumn17.CellAppearance = Appearance4
        UltraGridColumn17.Header.Caption = "Tipo Doc."
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn17.RowLayoutColumnInfo.ParentGroupKey = "Documento"
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(57, 20)
        UltraGridColumn17.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 23)
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 1
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn17.Width = 116
        UltraGridColumn18.Header.VisiblePosition = 12
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 3
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn18.RowLayoutColumnInfo.ParentGroupKey = "Documento"
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(46, 0)
        UltraGridColumn18.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 23)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn19.Header.VisiblePosition = 13
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 5
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn19.RowLayoutColumnInfo.ParentGroupKey = "Documento"
        UltraGridColumn19.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 23)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 3
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn20.CellAppearance = Appearance5
        UltraGridColumn20.Header.Caption = "Tipo Oper."
        UltraGridColumn20.Header.TextOrientation = New Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal)
        UltraGridColumn20.Header.VisiblePosition = 14
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 11
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn20.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 4
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance6
        UltraGridColumn21.Header.Caption = "Cantidad"
        UltraGridColumn21.Header.VisiblePosition = 3
        UltraGridColumn21.MaskInput = ""
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn21.RowLayoutColumnInfo.ParentGroupKey = "Entradas"
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 20)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn21.Width = 88
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance7
        UltraGridColumn22.Header.Caption = "Costo Unit."
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn22.MaskInput = "{LOC}nn,nnn,nnn.nnnn"
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn22.RowLayoutColumnInfo.ParentGroupKey = "Entradas"
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 20)
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn22.Width = 85
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance8
        UltraGridColumn23.Header.Caption = "Valor"
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridColumn23.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn23.RowLayoutColumnInfo.ParentGroupKey = "Entradas"
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 20)
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 4
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn24.CellAppearance = Appearance9
        UltraGridColumn24.Format = ""
        UltraGridColumn24.Header.Caption = "Cantidad"
        UltraGridColumn24.Header.VisiblePosition = 6
        UltraGridColumn24.MaskInput = ""
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn24.RowLayoutColumnInfo.ParentGroupKey = "Salidas"
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(75, 20)
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn24.Width = 69
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance10
        UltraGridColumn25.Header.Caption = "Costo Unit."
        UltraGridColumn25.Header.VisiblePosition = 7
        UltraGridColumn25.MaskInput = "{LOC}nn,nnn,nnn.nnnn"
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn25.RowLayoutColumnInfo.ParentGroupKey = "Salidas"
        UltraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 20)
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 1
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn25.Width = 85
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn26.CellAppearance = Appearance11
        UltraGridColumn26.Header.Caption = "Costo Total"
        UltraGridColumn26.Header.VisiblePosition = 8
        UltraGridColumn26.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 3
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn26.RowLayoutColumnInfo.ParentGroupKey = "Salidas"
        UltraGridColumn26.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 20)
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn26.Width = 72
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn27.CellAppearance = Appearance12
        UltraGridColumn27.Header.Caption = "Cantidad"
        UltraGridColumn27.Header.VisiblePosition = 9
        UltraGridColumn27.MaskInput = "{double:-9.4}"
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn27.RowLayoutColumnInfo.ParentGroupKey = "SaldoFinal"
        UltraGridColumn27.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 20)
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn27.Width = 70
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn28.CellAppearance = Appearance13
        UltraGridColumn28.Format = """#,###,##0.00"""
        UltraGridColumn28.Header.Caption = "Costo Unit."
        UltraGridColumn28.Header.VisiblePosition = 10
        UltraGridColumn28.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn28.RowLayoutColumnInfo.ParentGroupKey = "SaldoFinal"
        UltraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn28.Width = 80
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn29.CellAppearance = Appearance14
        UltraGridColumn29.Header.Caption = "Costo Total"
        UltraGridColumn29.Header.VisiblePosition = 11
        UltraGridColumn29.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn29.RowLayoutColumnInfo.ParentGroupKey = "SaldoFinal"
        UltraGridColumn29.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 20)
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn29.Width = 86
        UltraGridColumn30.Header.VisiblePosition = 16
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn31.Header.VisiblePosition = 17
        UltraGridColumn31.Hidden = True
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn32.Header.VisiblePosition = 18
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn33.Header.VisiblePosition = 19
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn34.Header.VisiblePosition = 20
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn35.Header.VisiblePosition = 21
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn36.Header.VisiblePosition = 23
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 24
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn38.Header.VisiblePosition = 25
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 44)
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn46.Header.VisiblePosition = 29
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 9
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn43, UltraGridColumn15, UltraGridColumn44, UltraGridColumn45, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn46})
        Appearance15.BackColor = System.Drawing.Color.LightCyan
        UltraGridGroup1.CellAppearance = Appearance15
        Appearance16.BackColor = System.Drawing.Color.PowderBlue
        Appearance16.ForeColor = System.Drawing.Color.Blue
        UltraGridGroup1.Header.Appearance = Appearance16
        UltraGridGroup1.Key = "Entradas"
        UltraGridGroup1.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup1.RowLayoutGroupInfo.OriginX = 13
        UltraGridGroup1.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup1.RowLayoutGroupInfo.SpanX = 6
        UltraGridGroup1.RowLayoutGroupInfo.SpanY = 5
        Appearance17.BackColor = System.Drawing.Color.LightSalmon
        UltraGridGroup2.CellAppearance = Appearance17
        Appearance18.ForeColor = System.Drawing.Color.Red
        UltraGridGroup2.Header.Appearance = Appearance18
        UltraGridGroup2.Key = "Salidas"
        UltraGridGroup2.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup2.RowLayoutGroupInfo.OriginX = 19
        UltraGridGroup2.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup2.RowLayoutGroupInfo.SpanX = 5
        UltraGridGroup2.RowLayoutGroupInfo.SpanY = 5
        Appearance19.BackColor = System.Drawing.Color.LightGreen
        UltraGridGroup3.CellAppearance = Appearance19
        Appearance20.ForeColor = System.Drawing.Color.Green
        UltraGridGroup3.Header.Appearance = Appearance20
        UltraGridGroup3.Header.Caption = "Saldo Final"
        UltraGridGroup3.Key = "SaldoFinal"
        UltraGridGroup3.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup3.RowLayoutGroupInfo.OriginX = 24
        UltraGridGroup3.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup3.RowLayoutGroupInfo.SpanX = 6
        UltraGridGroup3.RowLayoutGroupInfo.SpanY = 5
        UltraGridGroup4.Key = "Documento"
        UltraGridGroup4.RowLayoutGroupInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.Top
        UltraGridGroup4.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup4.RowLayoutGroupInfo.OriginX = 2
        UltraGridGroup4.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup4.RowLayoutGroupInfo.SpanX = 7
        UltraGridGroup4.RowLayoutGroupInfo.SpanY = 4
        UltraGridBand3.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2, UltraGridGroup3, UltraGridGroup4})
        UltraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        Me.grid_kardex.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.grid_kardex.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_kardex.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_kardex.DisplayLayout.Override.ColumnHeaderTextOrientation = New Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal)
        Me.grid_kardex.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_kardex.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_kardex.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_kardex.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_kardex.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_kardex.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_kardex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_kardex.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_kardex.Location = New System.Drawing.Point(0, 155)
        Me.grid_kardex.Name = "grid_kardex"
        Me.grid_kardex.Size = New System.Drawing.Size(1162, 322)
        Me.grid_kardex.TabIndex = 9
        '
        'od_Kardex
        '
        Me.od_Kardex.AllowAdd = False
        Me.od_Kardex.AllowDelete = False
        UltraDataColumn20.DataType = GetType(Date)
        Me.od_Kardex.Band.Columns.AddRange(New Object() {UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43})
        Me.od_Kardex.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object(-1) {})})
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.gb_Montos)
        Me.Agrupacion2.Controls.Add(Me.gb_SubAlmacen)
        Me.Agrupacion2.Controls.Add(Me.gb_Periodo)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1162, 155)
        Me.Agrupacion2.TabIndex = 5
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gb_Montos
        '
        Me.gb_Montos.BackColor = System.Drawing.Color.Transparent
        Me.gb_Montos.Controls.Add(Me.Label3)
        Me.gb_Montos.Controls.Add(Me.Label2)
        Me.gb_Montos.Controls.Add(Me.Label1)
        Me.gb_Montos.Controls.Add(Me.DecTotal)
        Me.gb_Montos.Controls.Add(Me.Etiqueta9)
        Me.gb_Montos.Controls.Add(Me.DecSaldo)
        Me.gb_Montos.Controls.Add(Me.Etiqueta5)
        Me.gb_Montos.Controls.Add(Me.Etiqueta10)
        Me.gb_Montos.Controls.Add(Me.DecIngresos)
        Me.gb_Montos.Controls.Add(Me.Etiqueta6)
        Me.gb_Montos.Controls.Add(Me.DecEgresos)
        Me.gb_Montos.ForeColor = System.Drawing.Color.Navy
        Me.gb_Montos.Location = New System.Drawing.Point(885, 6)
        Me.gb_Montos.Name = "gb_Montos"
        Me.gb_Montos.Size = New System.Drawing.Size(219, 144)
        Me.gb_Montos.TabIndex = 253
        Me.gb_Montos.TabStop = False
        Me.gb_Montos.Text = "Resumen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 254
        Me.Label3.Text = "(-)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 7)
        Me.Label2.TabIndex = 253
        Me.Label2.Text = "_____________________________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 252
        Me.Label1.Text = "(+)"
        '
        'DecTotal
        '
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.DecTotal.Appearance = Appearance21
        Me.DecTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotal.ForeColor = System.Drawing.Color.Black
        Me.DecTotal.Location = New System.Drawing.Point(79, 105)
        Me.DecTotal.Name = "DecTotal"
        Me.DecTotal.NullText = "0.00"
        Me.DecTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotal.ReadOnly = True
        Me.DecTotal.Size = New System.Drawing.Size(115, 21)
        Me.DecTotal.TabIndex = 250
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta9.Location = New System.Drawing.Point(11, 108)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta9.TabIndex = 249
        Me.Etiqueta9.Text = "Valor Total:"
        '
        'DecSaldo
        '
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.DecSaldo.Appearance = Appearance22
        Me.DecSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecSaldo.ForeColor = System.Drawing.Color.Black
        Me.DecSaldo.Location = New System.Drawing.Point(80, 17)
        Me.DecSaldo.Name = "DecSaldo"
        Me.DecSaldo.NullText = "0.00"
        Me.DecSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecSaldo.ReadOnly = True
        Me.DecSaldo.Size = New System.Drawing.Size(114, 21)
        Me.DecSaldo.TabIndex = 246
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta5.Location = New System.Drawing.Point(9, 20)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(66, 14)
        Me.Etiqueta5.TabIndex = 243
        Me.Etiqueta5.Text = "Saldo Inicial:"
        '
        'Etiqueta10
        '
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta10.Location = New System.Drawing.Point(9, 74)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta10.TabIndex = 251
        Me.Etiqueta10.Text = "Egresos:"
        '
        'DecIngresos
        '
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.DecIngresos.Appearance = Appearance23
        Me.DecIngresos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecIngresos.ForeColor = System.Drawing.Color.Black
        Me.DecIngresos.Location = New System.Drawing.Point(80, 43)
        Me.DecIngresos.Name = "DecIngresos"
        Me.DecIngresos.NullText = "0.00"
        Me.DecIngresos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecIngresos.ReadOnly = True
        Me.DecIngresos.Size = New System.Drawing.Size(114, 21)
        Me.DecIngresos.TabIndex = 247
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta6.Location = New System.Drawing.Point(9, 47)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta6.TabIndex = 244
        Me.Etiqueta6.Text = "Ingresos:"
        '
        'DecEgresos
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.DecEgresos.Appearance = Appearance24
        Me.DecEgresos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecEgresos.ForeColor = System.Drawing.Color.Black
        Me.DecEgresos.Location = New System.Drawing.Point(80, 70)
        Me.DecEgresos.Name = "DecEgresos"
        Me.DecEgresos.NullText = "0.00"
        Me.DecEgresos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecEgresos.ReadOnly = True
        Me.DecEgresos.Size = New System.Drawing.Size(114, 21)
        Me.DecEgresos.TabIndex = 248
        '
        'gb_SubAlmacen
        '
        Me.gb_SubAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.gb_SubAlmacen.Controls.Add(Me.grid_ListaSubAlmacen)
        Me.gb_SubAlmacen.ForeColor = System.Drawing.Color.Navy
        Me.gb_SubAlmacen.Location = New System.Drawing.Point(387, 6)
        Me.gb_SubAlmacen.Name = "gb_SubAlmacen"
        Me.gb_SubAlmacen.Size = New System.Drawing.Size(492, 143)
        Me.gb_SubAlmacen.TabIndex = 254
        Me.gb_SubAlmacen.TabStop = False
        Me.gb_SubAlmacen.Text = "Sub Almacenes:"
        '
        'grid_ListaSubAlmacen
        '
        Me.grid_ListaSubAlmacen.DataSource = Me.odSubAlmacen
        UltraGridColumn115.Header.VisiblePosition = 0
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 1
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 2
        UltraGridColumn117.Width = 76
        UltraGridColumn118.Header.VisiblePosition = 3
        UltraGridColumn118.Width = 369
        UltraGridColumn119.Header.VisiblePosition = 4
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 12
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.Header.VisiblePosition = 5
        UltraGridColumn121.Hidden = True
        UltraGridColumn121.Width = 276
        UltraGridColumn122.Header.VisiblePosition = 6
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.Header.VisiblePosition = 7
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.Header.VisiblePosition = 8
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 9
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 10
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 11
        UltraGridColumn127.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127})
        Me.grid_ListaSubAlmacen.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.grid_ListaSubAlmacen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_ListaSubAlmacen.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListaSubAlmacen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_ListaSubAlmacen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_ListaSubAlmacen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_ListaSubAlmacen.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_ListaSubAlmacen.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_ListaSubAlmacen.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_ListaSubAlmacen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_ListaSubAlmacen.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_ListaSubAlmacen.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_ListaSubAlmacen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListaSubAlmacen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_ListaSubAlmacen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_ListaSubAlmacen.Location = New System.Drawing.Point(3, 16)
        Me.grid_ListaSubAlmacen.Name = "grid_ListaSubAlmacen"
        Me.grid_ListaSubAlmacen.Size = New System.Drawing.Size(486, 124)
        Me.grid_ListaSubAlmacen.TabIndex = 4
        Me.grid_ListaSubAlmacen.Text = "Listado de Sub Almacenes"
        '
        'odSubAlmacen
        '
        Me.odSubAlmacen.AllowAdd = False
        Me.odSubAlmacen.AllowDelete = False
        UltraDataColumn45.DataType = GetType(Boolean)
        UltraDataColumn54.DataType = GetType(Boolean)
        Me.odSubAlmacen.Band.Columns.AddRange(New Object() {UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56})
        '
        'gb_Periodo
        '
        Me.gb_Periodo.BackColor = System.Drawing.Color.Transparent
        Me.gb_Periodo.Controls.Add(Me.Etiqueta13)
        Me.gb_Periodo.Controls.Add(Me.Etiqueta1)
        Me.gb_Periodo.Controls.Add(Me.cmbCuenta)
        Me.gb_Periodo.Controls.Add(Me.cboAlmacen)
        Me.gb_Periodo.Controls.Add(Me.Etiqueta2)
        Me.gb_Periodo.Controls.Add(Me.cbo_Mes)
        Me.gb_Periodo.Controls.Add(Me.cboCentro)
        Me.gb_Periodo.Controls.Add(Me.Año1)
        Me.gb_Periodo.Controls.Add(Me.Etiqueta4)
        Me.gb_Periodo.Controls.Add(Me.Etiqueta3)
        Me.gb_Periodo.ForeColor = System.Drawing.Color.Navy
        Me.gb_Periodo.Location = New System.Drawing.Point(11, 6)
        Me.gb_Periodo.Name = "gb_Periodo"
        Me.gb_Periodo.Size = New System.Drawing.Size(370, 143)
        Me.gb_Periodo.TabIndex = 252
        Me.gb_Periodo.TabStop = False
        Me.gb_Periodo.Text = "Periodo:"
        '
        'Etiqueta13
        '
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance25
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(6, 75)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta13.TabIndex = 257
        Me.Etiqueta13.Text = "Almacen:"
        '
        'Etiqueta1
        '
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance26
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(6, 105)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta1.TabIndex = 16
        Me.Etiqueta1.Text = "Cuenta:"
        '
        'cmbCuenta
        '
        Me.cmbCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbCuenta.CheckedListSettings.ListSeparator = ","
        Me.cmbCuenta.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn41.Header.VisiblePosition = 0
        UltraGridColumn41.Width = 74
        UltraGridColumn42.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        UltraGridColumn42.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.VisibleRows
        UltraGridColumn42.Header.VisiblePosition = 1
        UltraGridColumn42.Width = 213
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn41, UltraGridColumn42})
        Me.cmbCuenta.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.cmbCuenta.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cmbCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbCuenta.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cmbCuenta.Location = New System.Drawing.Point(62, 100)
        Me.cmbCuenta.Name = "cmbCuenta"
        Me.cmbCuenta.Size = New System.Drawing.Size(289, 22)
        Me.cmbCuenta.TabIndex = 15
        Me.cmbCuenta.ValueMember = "Id"
        '
        'cboAlmacen
        '
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Appearance = Appearance27
        Me.cboAlmacen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboAlmacen.DisplayMember = "Nombre"
        Me.cboAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAlmacen.DropDownListWidth = 280
        Me.cboAlmacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Location = New System.Drawing.Point(62, 71)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(289, 21)
        Me.cboAlmacen.TabIndex = 256
        Me.cboAlmacen.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance28
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(6, 48)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(42, 14)
        Me.Etiqueta2.TabIndex = 255
        Me.Etiqueta2.Text = "Centro:"
        '
        'cbo_Mes
        '
        Appearance29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbo_Mes.Appearance = Appearance29
        Me.cbo_Mes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cbo_Mes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbo_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbo_Mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Mes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbo_Mes.Location = New System.Drawing.Point(234, 18)
        Me.cbo_Mes.Name = "cbo_Mes"
        Me.cbo_Mes.Size = New System.Drawing.Size(52, 21)
        Me.cbo_Mes.TabIndex = 12
        Me.cbo_Mes.ValueMember = "Id"
        '
        'cboCentro
        '
        Appearance30.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance30
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownListWidth = 180
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(62, 44)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(94, 21)
        Me.cboCentro.TabIndex = 254
        Me.cboCentro.ValueMember = "Id"
        '
        'Año1
        '
        Me.Año1.Año = 2015
        Me.Año1.Controls.Add(Me.object_abe9bf2e_f506_4416_bb16_36035415a385)
        Me.Año1.Controls.Add(Me.NumeroEntero1)
        Me.Año1.Location = New System.Drawing.Point(62, 17)
        Me.Año1.Name = "Año1"
        Me.Año1.Size = New System.Drawing.Size(54, 23)
        Me.Año1.TabIndex = 11
        '
        'object_abe9bf2e_f506_4416_bb16_36035415a385
        '
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.Appearance = Appearance31
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.ForeColor = System.Drawing.Color.Black
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.FormatString = ""
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.Location = New System.Drawing.Point(1, 0)
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.MaskInput = "nnnn"
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.MaxValue = 2020
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.MinValue = 2000
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.Name = "object_abe9bf2e_f506_4416_bb16_36035415a385"
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.NullText = "0"
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.Size = New System.Drawing.Size(52, 21)
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.TabIndex = 0
        Me.object_abe9bf2e_f506_4416_bb16_36035415a385.Value = 2012
        '
        'NumeroEntero1
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.Appearance = Appearance32
        Me.NumeroEntero1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero1.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.FormatString = ""
        Me.NumeroEntero1.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero1.MaskInput = "nnnn"
        Me.NumeroEntero1.MaxValue = 2020
        Me.NumeroEntero1.MinValue = 2000
        Me.NumeroEntero1.Name = "NumeroEntero1"
        Me.NumeroEntero1.NullText = "0"
        Me.NumeroEntero1.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero1.TabIndex = 0
        Me.NumeroEntero1.Value = 2012
        '
        'Etiqueta4
        '
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance33
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(200, 21)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(30, 14)
        Me.Etiqueta4.TabIndex = 13
        Me.Etiqueta4.Text = "Mes:"
        '
        'Etiqueta3
        '
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance34
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(6, 19)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta3.TabIndex = 14
        Me.Etiqueta3.Text = "Ejercicio:"
        '
        'tc_RegInvPermVal
        '
        Me.tc_RegInvPermVal.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tc_RegInvPermVal.Controls.Add(Me.UltraTabPageControl2)
        Me.tc_RegInvPermVal.Controls.Add(Me.UltraTabPageControl1)
        Me.tc_RegInvPermVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_RegInvPermVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_RegInvPermVal.Location = New System.Drawing.Point(0, 0)
        Me.tc_RegInvPermVal.Name = "tc_RegInvPermVal"
        Me.tc_RegInvPermVal.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tc_RegInvPermVal.Size = New System.Drawing.Size(1164, 500)
        Me.tc_RegInvPermVal.TabIndex = 3
        UltraTab1.Key = "Listado"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tc_RegInvPermVal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tc_RegInvPermVal.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1162, 477)
        '
        'odCuenta
        '
        Me.odCuenta.Band.Columns.AddRange(New Object() {UltraDataColumn57, UltraDataColumn58})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_InventarioPermanenteValorizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1164, 500)
        Me.Controls.Add(Me.tc_RegInvPermVal)
        Me.Name = "frm_InventarioPermanenteValorizado"
        Me.Text = "Inventario Valorizado"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grid_CortesPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.od_Cortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.grid_kardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.od_Kardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.gb_Montos.ResumeLayout(False)
        Me.gb_Montos.PerformLayout()
        CType(Me.DecTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_SubAlmacen.ResumeLayout(False)
        CType(Me.grid_ListaSubAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odSubAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Periodo.ResumeLayout(False)
        Me.gb_Periodo.PerformLayout()
        CType(Me.cmbCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Año1.ResumeLayout(False)
        Me.Año1.PerformLayout()
        CType(Me.object_abe9bf2e_f506_4416_bb16_36035415a385, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tc_RegInvPermVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_RegInvPermVal.ResumeLayout(False)
        CType(Me.odCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tc_RegInvPermVal As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents cbo_Mes As ISL.Controles.Combo
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents object_abe9bf2e_f506_4416_bb16_36035415a385 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero1 As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents DecTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents DecEgresos As ISL.Controles.NumeroDecimal
    Friend WithEvents DecIngresos As ISL.Controles.NumeroDecimal
    Friend WithEvents DecSaldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents grid_kardex As ISL.Controles.Grilla
    Friend WithEvents od_Kardex As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grid_CortesPeriodo As ISL.Controles.Grilla
    Friend WithEvents gb_Periodo As System.Windows.Forms.GroupBox
    Friend WithEvents gb_Montos As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents od_Cortes As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Private WithEvents cmbCuenta As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents odCuenta As ISL.Controles.OrigenDatos
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents cboAlmacen As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents gb_SubAlmacen As System.Windows.Forms.GroupBox
    Friend WithEvents grid_ListaSubAlmacen As ISL.Controles.Grilla
    Friend WithEvents odSubAlmacen As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Filtro1 As ISL.Controles.Filtro

End Class
