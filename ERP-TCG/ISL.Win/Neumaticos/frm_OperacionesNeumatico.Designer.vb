<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OperacionesNeumatico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_OperacionesNeumatico))
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdNeumatico")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNeumatico")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoActual")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Condicion")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete1")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete2")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete3")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete4")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cocada")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoSoles")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoDolares")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kilometraje")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVida")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngreso")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDiseño")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Diseño")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMedida")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTotalNeumatico")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoDolxMilKm")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CocadaOriginal")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CocadaMinima")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoActualDolares")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoCascoDolares")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmProyectado")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinVida")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDisenoNeu")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lugar")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLog")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdNeumatico")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNeumatico")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoActual")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Condicion")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete1")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete2")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete3")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete4")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cocada")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoSoles")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoDolares")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Kilometraje")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigente")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVida")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaIngreso")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDiseño")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Diseño")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMedida")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTotalNeumatico")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoDolxMilKm")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CocadaOriginal")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CocadaMinima")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoActualDolares")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoCascoDolares")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmProyectado")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFinVida")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDisenoNeu")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Lugar")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLog")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdNeumatico")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNeumatico")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMedida")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDiseño")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Diseño")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVida")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngreso")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoActual")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Condicion")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoSoles")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoDolares")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete1")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete2")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete3")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete4")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cocada")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kilometraje")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTotalNeumatico")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoDolxMilKm")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CocadaOriginal")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CocadaMinima")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoCascoDolares")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoActualDolares")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmProyectado")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinVida")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDisenoNeu")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndLugar")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lugar")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndLog")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdNeumatico")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNeumatico")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMedida")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDiseño")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Diseño")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigente")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVida")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaIngreso")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoActual")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Condicion")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoSoles")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoDolares")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete1")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete2")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete3")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete4")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cocada")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Kilometraje")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTotalNeumatico")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoDolxMilKm")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CocadaOriginal")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CocadaMinima")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoCascoDolares")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoActualDolares")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmProyectado")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFinVida")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDisenoNeu")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndLugar")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Lugar")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndLog")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
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
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVidaNeumatico")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMotivo")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMontaje")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndInspeccion")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOperacion")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmVehiculo")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmNeumatico")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete1")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete2")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete3")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete4")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cocada")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CocadaMinima")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Presion")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Posicion")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Diseño")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdNeumatico")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNeumatico")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmRecorridoNeu")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Motivo")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdResponsable")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConductor")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndObservacion")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVidaNeumatico")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMotivo")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndMontaje")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndInspeccion")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOperacion")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmVehiculo")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmNeumatico")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete1")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete2")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete3")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete4")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cocada")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CocadaMinima")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Presion")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Posicion")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Diseño")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdNeumatico")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNeumatico")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmRecorridoNeu")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Motivo")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdResponsable")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConductor")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndObservacion")
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
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVidaNeumatico")
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdNeumatico")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNeumatico")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Diseño")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Posicion")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMontaje")
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndInspeccion")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOperacion")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cocada")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete1")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete2")
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete3")
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ribete4")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Presion")
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMotivo")
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CocadaMinima")
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmVehiculo")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmNeumatico")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmRecorridoNeu")
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Motivo")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdResponsable")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConductor")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndObservacion")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVidaNeumatico")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdNeumatico")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNeumatico")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Diseño")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Posicion")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndMontaje")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndInspeccion")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOperacion")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cocada")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete1")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete2")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete3")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ribete4")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Presion")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMotivo")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CocadaMinima")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmVehiculo")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmNeumatico")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmRecorridoNeu")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Motivo")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdResponsable")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConductor")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndObservacion")
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_Vehiculos = New ISL.Controles.Grilla(Me.components)
        Me.mcOperaciones = New ISL.Controles.MenuContextual(Me.components)
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InspecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.agDispositivos = New ISL.Controles.Agrupacion(Me.components)
        Me.pnl_R3 = New System.Windows.Forms.Panel()
        Me.lblLlanta5e = New System.Windows.Forms.Label()
        Me.picLlanta5e = New System.Windows.Forms.PictureBox()
        Me.pnl_R2 = New System.Windows.Forms.Panel()
        Me.lblLlanta5d = New System.Windows.Forms.Label()
        Me.picLlanta5d = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pbAlmacen = New System.Windows.Forms.PictureBox()
        Me.pnl_Eje4 = New System.Windows.Forms.Panel()
        Me.lblLlanta4c = New System.Windows.Forms.Label()
        Me.lblLlanta4a = New System.Windows.Forms.Label()
        Me.lblLlanta4b = New System.Windows.Forms.Label()
        Me.lblLlanta4d = New System.Windows.Forms.Label()
        Me.picLlanta4c = New System.Windows.Forms.PictureBox()
        Me.picLlanta4d = New System.Windows.Forms.PictureBox()
        Me.picLlanta4b = New System.Windows.Forms.PictureBox()
        Me.picLlanta4a = New System.Windows.Forms.PictureBox()
        Me.pnl_Eje2 = New System.Windows.Forms.Panel()
        Me.lblLlanta2c = New System.Windows.Forms.Label()
        Me.lblLlanta2b = New System.Windows.Forms.Label()
        Me.lblLlanta2d = New System.Windows.Forms.Label()
        Me.lblLlanta2a = New System.Windows.Forms.Label()
        Me.picLlanta2a = New System.Windows.Forms.PictureBox()
        Me.picLlanta2d = New System.Windows.Forms.PictureBox()
        Me.picLlanta2c = New System.Windows.Forms.PictureBox()
        Me.picLlanta2b = New System.Windows.Forms.PictureBox()
        Me.pnl_Eje3 = New System.Windows.Forms.Panel()
        Me.lblLlanta3c = New System.Windows.Forms.Label()
        Me.lblLlanta3b = New System.Windows.Forms.Label()
        Me.lblLlanta3d = New System.Windows.Forms.Label()
        Me.lblLlanta3a = New System.Windows.Forms.Label()
        Me.picLlanta3a = New System.Windows.Forms.PictureBox()
        Me.picLlanta3b = New System.Windows.Forms.PictureBox()
        Me.picLlanta3c = New System.Windows.Forms.PictureBox()
        Me.picLlanta3d = New System.Windows.Forms.PictureBox()
        Me.pnl_Eje1 = New System.Windows.Forms.Panel()
        Me.lblLlanta1d = New System.Windows.Forms.Label()
        Me.lblLlanta1c = New System.Windows.Forms.Label()
        Me.lblLlanta1b = New System.Windows.Forms.Label()
        Me.lblLlanta1a = New System.Windows.Forms.Label()
        Me.picLlanta1c = New System.Windows.Forms.PictureBox()
        Me.picLlanta1d = New System.Windows.Forms.PictureBox()
        Me.picLlanta1b = New System.Windows.Forms.PictureBox()
        Me.picLlanta1a = New System.Windows.Forms.PictureBox()
        Me.pnl_Almacen = New System.Windows.Forms.Panel()
        Me.grid_Codigos = New ISL.Controles.Grilla(Me.components)
        Me.odCodigo = New ISL.Controles.OrigenDatos(Me.components)
        Me.pnlDestino = New System.Windows.Forms.Panel()
        Me.picAlmacen = New System.Windows.Forms.PictureBox()
        Me.picBaja = New System.Windows.Forms.PictureBox()
        Me.picReencauche = New System.Windows.Forms.PictureBox()
        Me.picReparar = New System.Windows.Forms.PictureBox()
        Me.pnlRepuestos = New System.Windows.Forms.Panel()
        Me.lblLlanta5c = New System.Windows.Forms.Label()
        Me.picLlanta5c = New System.Windows.Forms.PictureBox()
        Me.picEliminarMon = New System.Windows.Forms.PictureBox()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.grid_VidasNeumatico = New ISL.Controles.Grilla(Me.components)
        Me.odVidas = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtPosicion = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.ndCostoTotalDol = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtMedida = New ISL.Controles.Texto(Me.components)
        Me.lblMarca = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtDiseño = New ISL.Controles.Texto(Me.components)
        Me.txtMarcaN = New ISL.Controles.Texto(Me.components)
        Me.txtEstado = New ISL.Controles.Texto(Me.components)
        Me.ndKmTotalNeu = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.ndCocada = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndRibete1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndRibete2 = New ISL.Controles.NumeroEntero(Me.components)
        Me.ndRibete3 = New ISL.Controles.NumeroEntero(Me.components)
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grid_Operaciones = New ISL.Controles.Grilla(Me.components)
        Me.mcSubMenuOperaciones = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.odOperaciones = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndRibete4 = New ISL.Controles.NumeroEntero(Me.components)
        Me.ndKmVehiculo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTipo = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtConfiguracion = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtMarca = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtPlaca = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.grid_Neumaticos = New ISL.Controles.Grilla(Me.components)
        Me.odInspeccion = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnActualizarKmVeh = New ISL.Controles.Boton(Me.components)
        Me.btnInspeccion = New ISL.Controles.Boton(Me.components)
        Me.btnCalcularKmNeu = New ISL.Controles.Boton(Me.components)
        Me.ndOdometro = New ISL.Controles.NumeroDecimal(Me.components)
        Me.ndKMInspeccion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.dtpFechaInspeccion = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTipoInps = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtConfigInsp = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtMarcaInsp = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtPlacaInsp = New ISL.Controles.Texto(Me.components)
        Me.tcVehiculo = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.grid_Vehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcOperaciones.SuspendLayout()
        Me.utpDetalle.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.agDispositivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agDispositivos.SuspendLayout()
        Me.pnl_R3.SuspendLayout()
        CType(Me.picLlanta5e, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_R2.SuspendLayout()
        CType(Me.picLlanta5d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Eje4.SuspendLayout()
        CType(Me.picLlanta4c, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta4d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta4b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta4a, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Eje2.SuspendLayout()
        CType(Me.picLlanta2a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta2d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta2c, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta2b, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Eje3.SuspendLayout()
        CType(Me.picLlanta3a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta3b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta3c, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta3d, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Eje1.SuspendLayout()
        CType(Me.picLlanta1c, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta1d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta1b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLlanta1a, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Almacen.SuspendLayout()
        CType(Me.grid_Codigos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDestino.SuspendLayout()
        CType(Me.picAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReencauche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReparar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRepuestos.SuspendLayout()
        CType(Me.picLlanta5c, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEliminarMon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.grid_VidasNeumatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odVidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.txtPosicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndCostoTotalDol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiseño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarcaN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndKmTotalNeu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.ndCocada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndRibete1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndRibete2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndRibete3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.grid_Operaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcSubMenuOperaciones.SuspendLayout()
        CType(Me.odOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.ndRibete4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndKmVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.grid_Neumaticos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odInspeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ndOdometro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndKMInspeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInspeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoInps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConfigInsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarcaInsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlacaInsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcVehiculo.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.grid_Vehiculos)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1228, 676)
        '
        'grid_Vehiculos
        '
        Me.grid_Vehiculos.ContextMenuStrip = Me.mcOperaciones
        Me.grid_Vehiculos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Vehiculos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Vehiculos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Vehiculos.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_Vehiculos.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Vehiculos.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_Vehiculos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_Vehiculos.DisplayLayout.Override.CellPadding = 0
        Me.grid_Vehiculos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Vehiculos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_Vehiculos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Vehiculos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Vehiculos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Vehiculos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_Vehiculos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Vehiculos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.grid_Vehiculos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_Vehiculos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_Vehiculos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_Vehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Vehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Vehiculos.Location = New System.Drawing.Point(0, 0)
        Me.grid_Vehiculos.Name = "grid_Vehiculos"
        Me.grid_Vehiculos.Size = New System.Drawing.Size(1228, 676)
        Me.grid_Vehiculos.TabIndex = 0
        Me.grid_Vehiculos.Text = "Información de vehículos"
        '
        'mcOperaciones
        '
        Me.mcOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcOperaciones.ForeColor = System.Drawing.Color.Black
        Me.mcOperaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarToolStripMenuItem, Me.AsignarConfiguracionToolStripMenuItem, Me.InspecciónToolStripMenuItem})
        Me.mcOperaciones.Name = "MenuContextual1"
        Me.mcOperaciones.Size = New System.Drawing.Size(178, 70)
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar"
        '
        'AsignarConfiguracionToolStripMenuItem
        '
        Me.AsignarConfiguracionToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.AsignarConfiguracionToolStripMenuItem.Name = "AsignarConfiguracionToolStripMenuItem"
        Me.AsignarConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AsignarConfiguracionToolStripMenuItem.Text = "Asignar Configuracion"
        '
        'InspecciónToolStripMenuItem
        '
        Me.InspecciónToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Information
        Me.InspecciónToolStripMenuItem.Name = "InspecciónToolStripMenuItem"
        Me.InspecciónToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.InspecciónToolStripMenuItem.Text = "Inspección"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.SplitContainer1)
        Me.utpDetalle.Controls.Add(Me.agrDatoGeneral)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1228, 676)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 52)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.agDispositivos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Agrupacion4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Agrupacion1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1228, 624)
        Me.SplitContainer1.SplitterDistance = 536
        Me.SplitContainer1.TabIndex = 203
        '
        'agDispositivos
        '
        Me.agDispositivos.Controls.Add(Me.pnl_R3)
        Me.agDispositivos.Controls.Add(Me.pnl_R2)
        Me.agDispositivos.Controls.Add(Me.Label9)
        Me.agDispositivos.Controls.Add(Me.pbAlmacen)
        Me.agDispositivos.Controls.Add(Me.pnl_Eje4)
        Me.agDispositivos.Controls.Add(Me.pnl_Eje2)
        Me.agDispositivos.Controls.Add(Me.pnl_Eje3)
        Me.agDispositivos.Controls.Add(Me.pnl_Eje1)
        Me.agDispositivos.Controls.Add(Me.pnl_Almacen)
        Me.agDispositivos.Controls.Add(Me.pnlDestino)
        Me.agDispositivos.Controls.Add(Me.pnlRepuestos)
        Me.agDispositivos.Controls.Add(Me.picEliminarMon)
        Me.agDispositivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agDispositivos.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agDispositivos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agDispositivos.Location = New System.Drawing.Point(0, 0)
        Me.agDispositivos.Name = "agDispositivos"
        Me.agDispositivos.Size = New System.Drawing.Size(536, 624)
        Me.agDispositivos.TabIndex = 0
        Me.agDispositivos.Text = "Operaciones"
        Me.agDispositivos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'pnl_R3
        '
        Me.pnl_R3.BackgroundImage = CType(resources.GetObject("pnl_R3.BackgroundImage"), System.Drawing.Image)
        Me.pnl_R3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnl_R3.Controls.Add(Me.lblLlanta5e)
        Me.pnl_R3.Controls.Add(Me.picLlanta5e)
        Me.pnl_R3.Location = New System.Drawing.Point(127, 380)
        Me.pnl_R3.Name = "pnl_R3"
        Me.pnl_R3.Size = New System.Drawing.Size(34, 82)
        Me.pnl_R3.TabIndex = 7
        Me.pnl_R3.Visible = False
        '
        'lblLlanta5e
        '
        Me.lblLlanta5e.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta5e.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta5e.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta5e.Location = New System.Drawing.Point(3, -3)
        Me.lblLlanta5e.Name = "lblLlanta5e"
        Me.lblLlanta5e.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta5e.TabIndex = 0
        Me.lblLlanta5e.Text = "R-3"
        Me.lblLlanta5e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLlanta5e
        '
        Me.picLlanta5e.AccessibleDescription = ""
        Me.picLlanta5e.AccessibleName = ""
        Me.picLlanta5e.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta5e.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta5e.Location = New System.Drawing.Point(1, 0)
        Me.picLlanta5e.Name = "picLlanta5e"
        Me.picLlanta5e.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta5e.TabIndex = 70
        Me.picLlanta5e.TabStop = False
        Me.picLlanta5e.Tag = "-3"
        '
        'pnl_R2
        '
        Me.pnl_R2.BackgroundImage = CType(resources.GetObject("pnl_R2.BackgroundImage"), System.Drawing.Image)
        Me.pnl_R2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnl_R2.Controls.Add(Me.lblLlanta5d)
        Me.pnl_R2.Controls.Add(Me.picLlanta5d)
        Me.pnl_R2.Location = New System.Drawing.Point(85, 379)
        Me.pnl_R2.Name = "pnl_R2"
        Me.pnl_R2.Size = New System.Drawing.Size(34, 82)
        Me.pnl_R2.TabIndex = 6
        Me.pnl_R2.Visible = False
        '
        'lblLlanta5d
        '
        Me.lblLlanta5d.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta5d.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta5d.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta5d.Location = New System.Drawing.Point(3, -3)
        Me.lblLlanta5d.Name = "lblLlanta5d"
        Me.lblLlanta5d.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta5d.TabIndex = 0
        Me.lblLlanta5d.Text = "R-2"
        Me.lblLlanta5d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLlanta5d
        '
        Me.picLlanta5d.AccessibleDescription = ""
        Me.picLlanta5d.AccessibleName = ""
        Me.picLlanta5d.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta5d.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta5d.Location = New System.Drawing.Point(1, 0)
        Me.picLlanta5d.Name = "picLlanta5d"
        Me.picLlanta5d.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta5d.TabIndex = 70
        Me.picLlanta5d.TabStop = False
        Me.picLlanta5d.Tag = "-2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label9.Location = New System.Drawing.Point(384, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 14)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ALMACEN"
        '
        'pbAlmacen
        '
        Me.pbAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbAlmacen.Location = New System.Drawing.Point(267, 27)
        Me.pbAlmacen.Name = "pbAlmacen"
        Me.pbAlmacen.Size = New System.Drawing.Size(288, 30)
        Me.pbAlmacen.TabIndex = 110
        Me.pbAlmacen.TabStop = False
        '
        'pnl_Eje4
        '
        Me.pnl_Eje4.BackgroundImage = CType(resources.GetObject("pnl_Eje4.BackgroundImage"), System.Drawing.Image)
        Me.pnl_Eje4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnl_Eje4.Controls.Add(Me.lblLlanta4c)
        Me.pnl_Eje4.Controls.Add(Me.lblLlanta4a)
        Me.pnl_Eje4.Controls.Add(Me.lblLlanta4b)
        Me.pnl_Eje4.Controls.Add(Me.lblLlanta4d)
        Me.pnl_Eje4.Controls.Add(Me.picLlanta4c)
        Me.pnl_Eje4.Controls.Add(Me.picLlanta4d)
        Me.pnl_Eje4.Controls.Add(Me.picLlanta4b)
        Me.pnl_Eje4.Controls.Add(Me.picLlanta4a)
        Me.pnl_Eje4.Location = New System.Drawing.Point(11, 271)
        Me.pnl_Eje4.Name = "pnl_Eje4"
        Me.pnl_Eje4.Size = New System.Drawing.Size(154, 82)
        Me.pnl_Eje4.TabIndex = 4
        Me.pnl_Eje4.Tag = "4"
        Me.pnl_Eje4.Visible = False
        '
        'lblLlanta4c
        '
        Me.lblLlanta4c.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta4c.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta4c.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta4c.Location = New System.Drawing.Point(92, -7)
        Me.lblLlanta4c.Name = "lblLlanta4c"
        Me.lblLlanta4c.Size = New System.Drawing.Size(32, 20)
        Me.lblLlanta4c.TabIndex = 2
        Me.lblLlanta4c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta4a
        '
        Me.lblLlanta4a.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta4a.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta4a.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta4a.Location = New System.Drawing.Point(0, -4)
        Me.lblLlanta4a.Name = "lblLlanta4a"
        Me.lblLlanta4a.Size = New System.Drawing.Size(32, 15)
        Me.lblLlanta4a.TabIndex = 0
        Me.lblLlanta4a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta4b
        '
        Me.lblLlanta4b.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta4b.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta4b.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta4b.Location = New System.Drawing.Point(29, -4)
        Me.lblLlanta4b.Name = "lblLlanta4b"
        Me.lblLlanta4b.Size = New System.Drawing.Size(32, 15)
        Me.lblLlanta4b.TabIndex = 1
        Me.lblLlanta4b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta4d
        '
        Me.lblLlanta4d.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta4d.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta4d.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta4d.Location = New System.Drawing.Point(122, -8)
        Me.lblLlanta4d.Name = "lblLlanta4d"
        Me.lblLlanta4d.Size = New System.Drawing.Size(32, 20)
        Me.lblLlanta4d.TabIndex = 3
        Me.lblLlanta4d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLlanta4c
        '
        Me.picLlanta4c.AccessibleDescription = ""
        Me.picLlanta4c.AccessibleName = ""
        Me.picLlanta4c.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta4c.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta4c.Location = New System.Drawing.Point(92, 0)
        Me.picLlanta4c.Name = "picLlanta4c"
        Me.picLlanta4c.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta4c.TabIndex = 71
        Me.picLlanta4c.TabStop = False
        Me.picLlanta4c.Tag = ""
        '
        'picLlanta4d
        '
        Me.picLlanta4d.AccessibleDescription = ""
        Me.picLlanta4d.AccessibleName = ""
        Me.picLlanta4d.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta4d.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta4d.Location = New System.Drawing.Point(122, 0)
        Me.picLlanta4d.Name = "picLlanta4d"
        Me.picLlanta4d.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta4d.TabIndex = 70
        Me.picLlanta4d.TabStop = False
        Me.picLlanta4d.Tag = ""
        '
        'picLlanta4b
        '
        Me.picLlanta4b.AccessibleDescription = ""
        Me.picLlanta4b.AccessibleName = ""
        Me.picLlanta4b.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta4b.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta4b.Location = New System.Drawing.Point(31, 0)
        Me.picLlanta4b.Name = "picLlanta4b"
        Me.picLlanta4b.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta4b.TabIndex = 66
        Me.picLlanta4b.TabStop = False
        Me.picLlanta4b.Tag = ""
        '
        'picLlanta4a
        '
        Me.picLlanta4a.AccessibleDescription = ""
        Me.picLlanta4a.AccessibleName = ""
        Me.picLlanta4a.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta4a.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta4a.Location = New System.Drawing.Point(0, 0)
        Me.picLlanta4a.Name = "picLlanta4a"
        Me.picLlanta4a.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta4a.TabIndex = 67
        Me.picLlanta4a.TabStop = False
        Me.picLlanta4a.Tag = ""
        '
        'pnl_Eje2
        '
        Me.pnl_Eje2.BackgroundImage = CType(resources.GetObject("pnl_Eje2.BackgroundImage"), System.Drawing.Image)
        Me.pnl_Eje2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnl_Eje2.Controls.Add(Me.lblLlanta2c)
        Me.pnl_Eje2.Controls.Add(Me.lblLlanta2b)
        Me.pnl_Eje2.Controls.Add(Me.lblLlanta2d)
        Me.pnl_Eje2.Controls.Add(Me.lblLlanta2a)
        Me.pnl_Eje2.Controls.Add(Me.picLlanta2a)
        Me.pnl_Eje2.Controls.Add(Me.picLlanta2d)
        Me.pnl_Eje2.Controls.Add(Me.picLlanta2c)
        Me.pnl_Eje2.Controls.Add(Me.picLlanta2b)
        Me.pnl_Eje2.Location = New System.Drawing.Point(11, 109)
        Me.pnl_Eje2.Name = "pnl_Eje2"
        Me.pnl_Eje2.Size = New System.Drawing.Size(154, 82)
        Me.pnl_Eje2.TabIndex = 2
        Me.pnl_Eje2.Tag = "2"
        Me.pnl_Eje2.Visible = False
        '
        'lblLlanta2c
        '
        Me.lblLlanta2c.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta2c.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta2c.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta2c.Location = New System.Drawing.Point(92, -4)
        Me.lblLlanta2c.Name = "lblLlanta2c"
        Me.lblLlanta2c.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta2c.TabIndex = 2
        Me.lblLlanta2c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta2b
        '
        Me.lblLlanta2b.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta2b.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta2b.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta2b.Location = New System.Drawing.Point(29, -4)
        Me.lblLlanta2b.Name = "lblLlanta2b"
        Me.lblLlanta2b.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta2b.TabIndex = 1
        Me.lblLlanta2b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta2d
        '
        Me.lblLlanta2d.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta2d.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta2d.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta2d.Location = New System.Drawing.Point(122, -4)
        Me.lblLlanta2d.Name = "lblLlanta2d"
        Me.lblLlanta2d.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta2d.TabIndex = 3
        Me.lblLlanta2d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta2a
        '
        Me.lblLlanta2a.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta2a.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta2a.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta2a.Location = New System.Drawing.Point(1, -4)
        Me.lblLlanta2a.Name = "lblLlanta2a"
        Me.lblLlanta2a.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta2a.TabIndex = 0
        Me.lblLlanta2a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLlanta2a
        '
        Me.picLlanta2a.AccessibleDescription = ""
        Me.picLlanta2a.AccessibleName = ""
        Me.picLlanta2a.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta2a.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta2a.Location = New System.Drawing.Point(0, 0)
        Me.picLlanta2a.Name = "picLlanta2a"
        Me.picLlanta2a.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta2a.TabIndex = 67
        Me.picLlanta2a.TabStop = False
        Me.picLlanta2a.Tag = ""
        '
        'picLlanta2d
        '
        Me.picLlanta2d.AccessibleDescription = ""
        Me.picLlanta2d.AccessibleName = ""
        Me.picLlanta2d.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta2d.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta2d.Location = New System.Drawing.Point(122, 0)
        Me.picLlanta2d.Name = "picLlanta2d"
        Me.picLlanta2d.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta2d.TabIndex = 70
        Me.picLlanta2d.TabStop = False
        Me.picLlanta2d.Tag = ""
        '
        'picLlanta2c
        '
        Me.picLlanta2c.AccessibleDescription = ""
        Me.picLlanta2c.AccessibleName = ""
        Me.picLlanta2c.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta2c.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta2c.Location = New System.Drawing.Point(92, 0)
        Me.picLlanta2c.Name = "picLlanta2c"
        Me.picLlanta2c.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta2c.TabIndex = 71
        Me.picLlanta2c.TabStop = False
        Me.picLlanta2c.Tag = ""
        '
        'picLlanta2b
        '
        Me.picLlanta2b.AccessibleDescription = ""
        Me.picLlanta2b.AccessibleName = ""
        Me.picLlanta2b.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta2b.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta2b.Location = New System.Drawing.Point(31, 0)
        Me.picLlanta2b.Name = "picLlanta2b"
        Me.picLlanta2b.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta2b.TabIndex = 66
        Me.picLlanta2b.TabStop = False
        Me.picLlanta2b.Tag = ""
        '
        'pnl_Eje3
        '
        Me.pnl_Eje3.BackgroundImage = CType(resources.GetObject("pnl_Eje3.BackgroundImage"), System.Drawing.Image)
        Me.pnl_Eje3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnl_Eje3.Controls.Add(Me.lblLlanta3c)
        Me.pnl_Eje3.Controls.Add(Me.lblLlanta3b)
        Me.pnl_Eje3.Controls.Add(Me.lblLlanta3d)
        Me.pnl_Eje3.Controls.Add(Me.lblLlanta3a)
        Me.pnl_Eje3.Controls.Add(Me.picLlanta3a)
        Me.pnl_Eje3.Controls.Add(Me.picLlanta3b)
        Me.pnl_Eje3.Controls.Add(Me.picLlanta3c)
        Me.pnl_Eje3.Controls.Add(Me.picLlanta3d)
        Me.pnl_Eje3.Location = New System.Drawing.Point(11, 190)
        Me.pnl_Eje3.Name = "pnl_Eje3"
        Me.pnl_Eje3.Size = New System.Drawing.Size(154, 82)
        Me.pnl_Eje3.TabIndex = 3
        Me.pnl_Eje3.Tag = "3"
        Me.pnl_Eje3.Visible = False
        '
        'lblLlanta3c
        '
        Me.lblLlanta3c.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta3c.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta3c.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta3c.Location = New System.Drawing.Point(92, -3)
        Me.lblLlanta3c.Name = "lblLlanta3c"
        Me.lblLlanta3c.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta3c.TabIndex = 2
        Me.lblLlanta3c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta3b
        '
        Me.lblLlanta3b.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta3b.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta3b.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta3b.Location = New System.Drawing.Point(29, -3)
        Me.lblLlanta3b.Name = "lblLlanta3b"
        Me.lblLlanta3b.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta3b.TabIndex = 1
        Me.lblLlanta3b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta3d
        '
        Me.lblLlanta3d.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta3d.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta3d.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta3d.Location = New System.Drawing.Point(122, -3)
        Me.lblLlanta3d.Name = "lblLlanta3d"
        Me.lblLlanta3d.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta3d.TabIndex = 3
        Me.lblLlanta3d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta3a
        '
        Me.lblLlanta3a.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta3a.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta3a.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta3a.Location = New System.Drawing.Point(0, -3)
        Me.lblLlanta3a.Name = "lblLlanta3a"
        Me.lblLlanta3a.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta3a.TabIndex = 0
        Me.lblLlanta3a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLlanta3a
        '
        Me.picLlanta3a.AccessibleDescription = ""
        Me.picLlanta3a.AccessibleName = ""
        Me.picLlanta3a.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta3a.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta3a.Location = New System.Drawing.Point(0, 0)
        Me.picLlanta3a.Name = "picLlanta3a"
        Me.picLlanta3a.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta3a.TabIndex = 67
        Me.picLlanta3a.TabStop = False
        Me.picLlanta3a.Tag = ""
        '
        'picLlanta3b
        '
        Me.picLlanta3b.AccessibleDescription = ""
        Me.picLlanta3b.AccessibleName = ""
        Me.picLlanta3b.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta3b.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta3b.Location = New System.Drawing.Point(31, 0)
        Me.picLlanta3b.Name = "picLlanta3b"
        Me.picLlanta3b.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta3b.TabIndex = 66
        Me.picLlanta3b.TabStop = False
        Me.picLlanta3b.Tag = ""
        '
        'picLlanta3c
        '
        Me.picLlanta3c.AccessibleDescription = ""
        Me.picLlanta3c.AccessibleName = ""
        Me.picLlanta3c.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta3c.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta3c.Location = New System.Drawing.Point(92, 0)
        Me.picLlanta3c.Name = "picLlanta3c"
        Me.picLlanta3c.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta3c.TabIndex = 71
        Me.picLlanta3c.TabStop = False
        Me.picLlanta3c.Tag = ""
        '
        'picLlanta3d
        '
        Me.picLlanta3d.AccessibleDescription = ""
        Me.picLlanta3d.AccessibleName = ""
        Me.picLlanta3d.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta3d.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta3d.Location = New System.Drawing.Point(122, 0)
        Me.picLlanta3d.Name = "picLlanta3d"
        Me.picLlanta3d.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta3d.TabIndex = 70
        Me.picLlanta3d.TabStop = False
        Me.picLlanta3d.Tag = ""
        '
        'pnl_Eje1
        '
        Me.pnl_Eje1.BackgroundImage = CType(resources.GetObject("pnl_Eje1.BackgroundImage"), System.Drawing.Image)
        Me.pnl_Eje1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnl_Eje1.Controls.Add(Me.lblLlanta1d)
        Me.pnl_Eje1.Controls.Add(Me.lblLlanta1c)
        Me.pnl_Eje1.Controls.Add(Me.lblLlanta1b)
        Me.pnl_Eje1.Controls.Add(Me.lblLlanta1a)
        Me.pnl_Eje1.Controls.Add(Me.picLlanta1c)
        Me.pnl_Eje1.Controls.Add(Me.picLlanta1d)
        Me.pnl_Eje1.Controls.Add(Me.picLlanta1b)
        Me.pnl_Eje1.Controls.Add(Me.picLlanta1a)
        Me.pnl_Eje1.Location = New System.Drawing.Point(11, 27)
        Me.pnl_Eje1.Name = "pnl_Eje1"
        Me.pnl_Eje1.Size = New System.Drawing.Size(154, 82)
        Me.pnl_Eje1.TabIndex = 0
        Me.pnl_Eje1.Tag = "1"
        Me.pnl_Eje1.Visible = False
        '
        'lblLlanta1d
        '
        Me.lblLlanta1d.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta1d.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta1d.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta1d.Location = New System.Drawing.Point(123, -4)
        Me.lblLlanta1d.Name = "lblLlanta1d"
        Me.lblLlanta1d.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta1d.TabIndex = 3
        Me.lblLlanta1d.Tag = ""
        Me.lblLlanta1d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta1c
        '
        Me.lblLlanta1c.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta1c.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta1c.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta1c.Location = New System.Drawing.Point(93, -4)
        Me.lblLlanta1c.Name = "lblLlanta1c"
        Me.lblLlanta1c.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta1c.TabIndex = 2
        Me.lblLlanta1c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta1b
        '
        Me.lblLlanta1b.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta1b.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta1b.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta1b.Location = New System.Drawing.Point(30, -4)
        Me.lblLlanta1b.Name = "lblLlanta1b"
        Me.lblLlanta1b.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta1b.TabIndex = 1
        Me.lblLlanta1b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLlanta1a
        '
        Me.lblLlanta1a.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta1a.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta1a.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta1a.Location = New System.Drawing.Point(1, -4)
        Me.lblLlanta1a.Name = "lblLlanta1a"
        Me.lblLlanta1a.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta1a.TabIndex = 0
        Me.lblLlanta1a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLlanta1c
        '
        Me.picLlanta1c.AccessibleDescription = ""
        Me.picLlanta1c.AccessibleName = ""
        Me.picLlanta1c.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta1c.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta1c.Location = New System.Drawing.Point(93, 0)
        Me.picLlanta1c.Name = "picLlanta1c"
        Me.picLlanta1c.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta1c.TabIndex = 69
        Me.picLlanta1c.TabStop = False
        Me.picLlanta1c.Tag = ""
        '
        'picLlanta1d
        '
        Me.picLlanta1d.AccessibleDescription = ""
        Me.picLlanta1d.AccessibleName = ""
        Me.picLlanta1d.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta1d.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta1d.Location = New System.Drawing.Point(123, 0)
        Me.picLlanta1d.Name = "picLlanta1d"
        Me.picLlanta1d.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta1d.TabIndex = 68
        Me.picLlanta1d.TabStop = False
        Me.picLlanta1d.Tag = ""
        '
        'picLlanta1b
        '
        Me.picLlanta1b.AccessibleDescription = ""
        Me.picLlanta1b.AccessibleName = ""
        Me.picLlanta1b.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta1b.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta1b.Location = New System.Drawing.Point(30, 0)
        Me.picLlanta1b.Name = "picLlanta1b"
        Me.picLlanta1b.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta1b.TabIndex = 62
        Me.picLlanta1b.TabStop = False
        Me.picLlanta1b.Tag = ""
        '
        'picLlanta1a
        '
        Me.picLlanta1a.AccessibleDescription = ""
        Me.picLlanta1a.AccessibleName = ""
        Me.picLlanta1a.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta1a.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta1a.Location = New System.Drawing.Point(1, 0)
        Me.picLlanta1a.Name = "picLlanta1a"
        Me.picLlanta1a.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta1a.TabIndex = 68
        Me.picLlanta1a.TabStop = False
        Me.picLlanta1a.Tag = ""
        '
        'pnl_Almacen
        '
        Me.pnl_Almacen.Controls.Add(Me.grid_Codigos)
        Me.pnl_Almacen.Location = New System.Drawing.Point(267, 58)
        Me.pnl_Almacen.Name = "pnl_Almacen"
        Me.pnl_Almacen.Size = New System.Drawing.Size(288, 404)
        Me.pnl_Almacen.TabIndex = 109
        '
        'grid_Codigos
        '
        Me.grid_Codigos.DataSource = Me.odCodigo
        UltraGridColumn42.Header.VisiblePosition = 0
        UltraGridColumn42.Hidden = True
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn43.Header.Appearance = Appearance1
        UltraGridColumn43.Header.Caption = "Codigo"
        UltraGridColumn43.Header.VisiblePosition = 1
        UltraGridColumn43.Width = 68
        UltraGridColumn44.Header.VisiblePosition = 2
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 3
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 4
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 5
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 6
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 7
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 8
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 9
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 10
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 11
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 12
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 13
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 14
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 15
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 16
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 17
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 18
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 19
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 20
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 21
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 22
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 23
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 24
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 25
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 26
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 27
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 28
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 29
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 30
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 31
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 32
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 33
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 34
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 35
        UltraGridColumn77.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 36
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 37
        UltraGridColumn7.Header.VisiblePosition = 38
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 39
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.grid_Codigos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_Codigos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Codigos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Codigos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Codigos.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_Codigos.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Codigos.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_Codigos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Codigos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_Codigos.DisplayLayout.Override.CellPadding = 0
        Me.grid_Codigos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Codigos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_Codigos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance2.TextHAlignAsString = "Left"
        Me.grid_Codigos.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.grid_Codigos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance3.Image = Global.ISL.Win.My.Resources.Resources.Neumatico
        Me.grid_Codigos.DisplayLayout.Override.RowSelectorAppearance = Appearance3
        Me.grid_Codigos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Codigos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Codigos.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grid_Codigos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_Codigos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_Codigos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_Codigos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Codigos.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Codigos.Location = New System.Drawing.Point(0, 0)
        Me.grid_Codigos.Name = "grid_Codigos"
        Me.grid_Codigos.Size = New System.Drawing.Size(288, 404)
        Me.grid_Codigos.TabIndex = 0
        Me.grid_Codigos.Text = "Grilla3"
        '
        'odCodigo
        '
        UltraDataColumn27.DataType = GetType(Double)
        UltraDataColumn29.DataType = GetType(Double)
        UltraDataColumn29.DefaultValue = 0.0R
        UltraDataColumn34.DataType = GetType(Date)
        Me.odCodigo.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40})
        '
        'pnlDestino
        '
        Me.pnlDestino.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlDestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDestino.Controls.Add(Me.picAlmacen)
        Me.pnlDestino.Controls.Add(Me.picBaja)
        Me.pnlDestino.Controls.Add(Me.picReencauche)
        Me.pnlDestino.Controls.Add(Me.picReparar)
        Me.pnlDestino.Location = New System.Drawing.Point(177, 27)
        Me.pnlDestino.Name = "pnlDestino"
        Me.pnlDestino.Size = New System.Drawing.Size(83, 354)
        Me.pnlDestino.TabIndex = 1
        '
        'picAlmacen
        '
        Me.picAlmacen.AccessibleDescription = ""
        Me.picAlmacen.AccessibleName = ""
        Me.picAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.picAlmacen.Image = CType(resources.GetObject("picAlmacen.Image"), System.Drawing.Image)
        Me.picAlmacen.Location = New System.Drawing.Point(3, 3)
        Me.picAlmacen.Name = "picAlmacen"
        Me.picAlmacen.Size = New System.Drawing.Size(75, 75)
        Me.picAlmacen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picAlmacen.TabIndex = 65
        Me.picAlmacen.TabStop = False
        Me.picAlmacen.Tag = "ALMACEN"
        '
        'picBaja
        '
        Me.picBaja.AccessibleDescription = ""
        Me.picBaja.AccessibleName = ""
        Me.picBaja.BackColor = System.Drawing.Color.Transparent
        Me.picBaja.Image = CType(resources.GetObject("picBaja.Image"), System.Drawing.Image)
        Me.picBaja.Location = New System.Drawing.Point(3, 273)
        Me.picBaja.Name = "picBaja"
        Me.picBaja.Size = New System.Drawing.Size(75, 75)
        Me.picBaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBaja.TabIndex = 69
        Me.picBaja.TabStop = False
        Me.picBaja.Tag = "BAJA"
        '
        'picReencauche
        '
        Me.picReencauche.AccessibleDescription = ""
        Me.picReencauche.AccessibleName = ""
        Me.picReencauche.BackColor = System.Drawing.Color.Transparent
        Me.picReencauche.Image = CType(resources.GetObject("picReencauche.Image"), System.Drawing.Image)
        Me.picReencauche.Location = New System.Drawing.Point(3, 183)
        Me.picReencauche.Name = "picReencauche"
        Me.picReencauche.Size = New System.Drawing.Size(75, 75)
        Me.picReencauche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picReencauche.TabIndex = 68
        Me.picReencauche.TabStop = False
        Me.picReencauche.Tag = "REENCAUCHE"
        '
        'picReparar
        '
        Me.picReparar.AccessibleDescription = ""
        Me.picReparar.AccessibleName = ""
        Me.picReparar.BackColor = System.Drawing.Color.Transparent
        Me.picReparar.Image = CType(resources.GetObject("picReparar.Image"), System.Drawing.Image)
        Me.picReparar.Location = New System.Drawing.Point(3, 93)
        Me.picReparar.Name = "picReparar"
        Me.picReparar.Size = New System.Drawing.Size(75, 75)
        Me.picReparar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picReparar.TabIndex = 67
        Me.picReparar.TabStop = False
        Me.picReparar.Tag = "REPARACION"
        '
        'pnlRepuestos
        '
        Me.pnlRepuestos.BackgroundImage = CType(resources.GetObject("pnlRepuestos.BackgroundImage"), System.Drawing.Image)
        Me.pnlRepuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlRepuestos.Controls.Add(Me.lblLlanta5c)
        Me.pnlRepuestos.Controls.Add(Me.picLlanta5c)
        Me.pnlRepuestos.Location = New System.Drawing.Point(43, 379)
        Me.pnlRepuestos.Name = "pnlRepuestos"
        Me.pnlRepuestos.Size = New System.Drawing.Size(34, 82)
        Me.pnlRepuestos.TabIndex = 5
        Me.pnlRepuestos.Visible = False
        '
        'lblLlanta5c
        '
        Me.lblLlanta5c.BackColor = System.Drawing.Color.Transparent
        Me.lblLlanta5c.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlanta5c.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLlanta5c.Location = New System.Drawing.Point(2, -4)
        Me.lblLlanta5c.Name = "lblLlanta5c"
        Me.lblLlanta5c.Size = New System.Drawing.Size(32, 12)
        Me.lblLlanta5c.TabIndex = 0
        Me.lblLlanta5c.Text = "R-1"
        Me.lblLlanta5c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLlanta5c
        '
        Me.picLlanta5c.AccessibleDescription = ""
        Me.picLlanta5c.AccessibleName = ""
        Me.picLlanta5c.BackColor = System.Drawing.Color.Transparent
        Me.picLlanta5c.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLlanta5c.InitialImage = Nothing
        Me.picLlanta5c.Location = New System.Drawing.Point(0, 0)
        Me.picLlanta5c.Name = "picLlanta5c"
        Me.picLlanta5c.Size = New System.Drawing.Size(32, 82)
        Me.picLlanta5c.TabIndex = 71
        Me.picLlanta5c.TabStop = False
        Me.picLlanta5c.Tag = "-1"
        '
        'picEliminarMon
        '
        Me.picEliminarMon.AccessibleDescription = ""
        Me.picEliminarMon.AccessibleName = ""
        Me.picEliminarMon.BackColor = System.Drawing.Color.Transparent
        Me.picEliminarMon.Image = CType(resources.GetObject("picEliminarMon.Image"), System.Drawing.Image)
        Me.picEliminarMon.Location = New System.Drawing.Point(182, 387)
        Me.picEliminarMon.Name = "picEliminarMon"
        Me.picEliminarMon.Size = New System.Drawing.Size(75, 75)
        Me.picEliminarMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEliminarMon.TabIndex = 112
        Me.picEliminarMon.TabStop = False
        Me.picEliminarMon.Tag = "BAJA"
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.grid_VidasNeumatico)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 156)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(688, 204)
        Me.Agrupacion4.TabIndex = 1
        Me.Agrupacion4.Text = "Vidas:"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grid_VidasNeumatico
        '
        Me.grid_VidasNeumatico.DataSource = Me.odVidas
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn78.CellAppearance = Appearance4
        UltraGridColumn78.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn78.Header.Appearance = Appearance5
        UltraGridColumn78.Header.VisiblePosition = 0
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn79.Header.Appearance = Appearance6
        UltraGridColumn79.Header.VisiblePosition = 1
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn80.Header.Appearance = Appearance7
        UltraGridColumn80.Header.Caption = "Cod. Neumatico"
        UltraGridColumn80.Header.VisiblePosition = 5
        UltraGridColumn80.Hidden = True
        UltraGridColumn80.Width = 92
        UltraGridColumn81.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance8.TextHAlignAsString = "Center"
        UltraGridColumn81.Header.Appearance = Appearance8
        UltraGridColumn81.Header.VisiblePosition = 2
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn82.Header.Appearance = Appearance9
        UltraGridColumn82.Header.VisiblePosition = 3
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn83.Header.Appearance = Appearance10
        UltraGridColumn83.Header.VisiblePosition = 4
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn84.Header.Appearance = Appearance11
        UltraGridColumn84.Header.VisiblePosition = 13
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance12.TextHAlignAsString = "Center"
        UltraGridColumn85.Header.Appearance = Appearance12
        UltraGridColumn85.Header.VisiblePosition = 9
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn86.Header.Appearance = Appearance13
        UltraGridColumn86.Header.VisiblePosition = 14
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance14.TextHAlignAsString = "Center"
        UltraGridColumn87.Header.Appearance = Appearance14
        UltraGridColumn87.Header.VisiblePosition = 15
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance15.TextHAlignAsString = "Center"
        UltraGridColumn88.Header.Appearance = Appearance15
        UltraGridColumn88.Header.VisiblePosition = 16
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance16.TextHAlignAsString = "Center"
        UltraGridColumn89.Header.Appearance = Appearance16
        UltraGridColumn89.Header.VisiblePosition = 8
        UltraGridColumn89.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn89.Width = 48
        Appearance17.TextHAlignAsString = "Center"
        UltraGridColumn90.CellAppearance = Appearance17
        UltraGridColumn90.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance18.TextHAlignAsString = "Center"
        UltraGridColumn90.Header.Appearance = Appearance18
        UltraGridColumn90.Header.Caption = "N° Vida"
        UltraGridColumn90.Header.VisiblePosition = 6
        UltraGridColumn90.Width = 47
        UltraGridColumn91.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn91.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance19.TextHAlignAsString = "Center"
        UltraGridColumn91.Header.Appearance = Appearance19
        UltraGridColumn91.Header.Caption = "Fecha Ingreso"
        UltraGridColumn91.Header.VisiblePosition = 10
        UltraGridColumn91.Width = 84
        UltraGridColumn92.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance20.TextHAlignAsString = "Center"
        UltraGridColumn92.Header.Appearance = Appearance20
        UltraGridColumn92.Header.Caption = "Estado"
        UltraGridColumn92.Header.VisiblePosition = 11
        UltraGridColumn92.Width = 46
        UltraGridColumn93.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance21.TextHAlignAsString = "Center"
        UltraGridColumn93.Header.Appearance = Appearance21
        UltraGridColumn93.Header.VisiblePosition = 7
        UltraGridColumn93.Width = 59
        UltraGridColumn94.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance22.TextHAlignAsString = "Center"
        UltraGridColumn94.Header.Appearance = Appearance22
        UltraGridColumn94.Header.VisiblePosition = 17
        UltraGridColumn94.Hidden = True
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn95.CellAppearance = Appearance23
        UltraGridColumn95.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance24.TextHAlignAsString = "Center"
        UltraGridColumn95.Header.Appearance = Appearance24
        UltraGridColumn95.Header.Caption = "Costo S/."
        UltraGridColumn95.Header.VisiblePosition = 21
        UltraGridColumn95.Hidden = True
        UltraGridColumn95.Width = 70
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn96.CellAppearance = Appearance25
        UltraGridColumn96.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance26.TextHAlignAsString = "Center"
        UltraGridColumn96.Header.Appearance = Appearance26
        UltraGridColumn96.Header.Caption = "Costo $"
        UltraGridColumn96.Header.VisiblePosition = 18
        UltraGridColumn96.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn96.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn96.Width = 66
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn97.CellAppearance = Appearance27
        UltraGridColumn97.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance28.TextHAlignAsString = "Center"
        UltraGridColumn97.Header.Appearance = Appearance28
        UltraGridColumn97.Header.Caption = "R1"
        UltraGridColumn97.Header.VisiblePosition = 22
        UltraGridColumn97.Width = 35
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn98.CellAppearance = Appearance29
        UltraGridColumn98.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance30.TextHAlignAsString = "Center"
        UltraGridColumn98.Header.Appearance = Appearance30
        UltraGridColumn98.Header.Caption = "R2"
        UltraGridColumn98.Header.VisiblePosition = 23
        UltraGridColumn98.Width = 37
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn99.CellAppearance = Appearance31
        UltraGridColumn99.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance32.TextHAlignAsString = "Center"
        UltraGridColumn99.Header.Appearance = Appearance32
        UltraGridColumn99.Header.Caption = "R3"
        UltraGridColumn99.Header.VisiblePosition = 24
        UltraGridColumn99.Width = 34
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn100.CellAppearance = Appearance33
        UltraGridColumn100.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance34.TextHAlignAsString = "Center"
        UltraGridColumn100.Header.Appearance = Appearance34
        UltraGridColumn100.Header.Caption = "R4"
        UltraGridColumn100.Header.VisiblePosition = 25
        UltraGridColumn100.Hidden = True
        UltraGridColumn100.Width = 37
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn101.CellAppearance = Appearance35
        UltraGridColumn101.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance36.TextHAlignAsString = "Center"
        UltraGridColumn101.Header.Appearance = Appearance36
        UltraGridColumn101.Header.VisiblePosition = 26
        UltraGridColumn101.Width = 52
        Appearance37.TextHAlignAsString = "Right"
        UltraGridColumn102.CellAppearance = Appearance37
        UltraGridColumn102.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn102.Format = "#,##0.00"
        Appearance38.TextHAlignAsString = "Center"
        UltraGridColumn102.Header.Appearance = Appearance38
        UltraGridColumn102.Header.VisiblePosition = 12
        UltraGridColumn102.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn102.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn102.Width = 78
        UltraGridColumn103.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance39.TextHAlignAsString = "Center"
        UltraGridColumn103.Header.Appearance = Appearance39
        UltraGridColumn103.Header.VisiblePosition = 20
        UltraGridColumn103.Width = 89
        UltraGridColumn104.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn104.Format = "#,##0.00"
        UltraGridColumn104.Header.VisiblePosition = 27
        UltraGridColumn104.Hidden = True
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn105.CellAppearance = Appearance40
        UltraGridColumn105.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance41.TextHAlignAsString = "Center"
        UltraGridColumn105.Header.Appearance = Appearance41
        UltraGridColumn105.Header.Caption = "Costo $ x 1000 Km"
        UltraGridColumn105.Header.VisiblePosition = 19
        UltraGridColumn105.Width = 106
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn106.CellAppearance = Appearance42
        UltraGridColumn106.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance43.TextHAlignAsString = "Center"
        UltraGridColumn106.Header.Appearance = Appearance43
        UltraGridColumn106.Header.Caption = "Cocada Orig."
        UltraGridColumn106.Header.VisiblePosition = 28
        UltraGridColumn106.Width = 78
        UltraGridColumn107.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn107.Header.VisiblePosition = 29
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn108.Header.VisiblePosition = 30
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn109.Header.VisiblePosition = 31
        UltraGridColumn109.Hidden = True
        Appearance44.TextHAlignAsString = "Right"
        UltraGridColumn110.CellAppearance = Appearance44
        UltraGridColumn110.Format = "#,##0.00"
        Appearance45.TextHAlignAsString = "Center"
        UltraGridColumn110.Header.Appearance = Appearance45
        UltraGridColumn110.Header.Caption = "Km Proy"
        UltraGridColumn110.Header.VisiblePosition = 32
        UltraGridColumn111.Header.VisiblePosition = 33
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 34
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 35
        UltraGridColumn3.Header.VisiblePosition = 36
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 37
        UltraGridColumn9.Header.VisiblePosition = 38
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 39
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn3, UltraGridColumn4, UltraGridColumn9, UltraGridColumn10})
        Me.grid_VidasNeumatico.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid_VidasNeumatico.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_VidasNeumatico.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_VidasNeumatico.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_VidasNeumatico.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_VidasNeumatico.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid_VidasNeumatico.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_VidasNeumatico.DisplayLayout.Override.CellPadding = 0
        Appearance46.TextHAlignAsString = "Left"
        Me.grid_VidasNeumatico.DisplayLayout.Override.HeaderAppearance = Appearance46
        Me.grid_VidasNeumatico.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_VidasNeumatico.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_VidasNeumatico.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_VidasNeumatico.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_VidasNeumatico.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_VidasNeumatico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_VidasNeumatico.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_VidasNeumatico.Location = New System.Drawing.Point(3, 17)
        Me.grid_VidasNeumatico.Name = "grid_VidasNeumatico"
        Me.grid_VidasNeumatico.Size = New System.Drawing.Size(682, 184)
        Me.grid_VidasNeumatico.TabIndex = 0
        Me.grid_VidasNeumatico.Text = "Grilla1"
        '
        'odVidas
        '
        UltraDataColumn53.DataType = GetType(Integer)
        UltraDataColumn53.DefaultValue = 0
        UltraDataColumn54.DataType = GetType(Date)
        UltraDataColumn58.DataType = GetType(Double)
        UltraDataColumn59.DataType = GetType(Double)
        UltraDataColumn60.DataType = GetType(Double)
        UltraDataColumn60.DefaultValue = 0.0R
        UltraDataColumn61.DataType = GetType(Double)
        UltraDataColumn61.DefaultValue = 0.0R
        UltraDataColumn62.DataType = GetType(Double)
        UltraDataColumn62.DefaultValue = 0.0R
        UltraDataColumn63.DataType = GetType(Double)
        UltraDataColumn63.DefaultValue = 0.0R
        UltraDataColumn64.DataType = GetType(Double)
        UltraDataColumn64.DefaultValue = 0.0R
        UltraDataColumn65.DataType = GetType(Double)
        UltraDataColumn67.DataType = GetType(Double)
        UltraDataColumn68.DataType = GetType(Double)
        UltraDataColumn69.DataType = GetType(Double)
        UltraDataColumn69.DefaultValue = 0.0R
        UltraDataColumn73.DataType = GetType(Double)
        UltraDataColumn73.DefaultValue = 0.0R
        UltraDataColumn74.DataType = GetType(Date)
        Me.odVidas.Band.Columns.AddRange(New Object() {UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(688, 156)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Detalles de Neumatico"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.txtPosicion)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion3.Controls.Add(Me.txtCodigo)
        Me.Agrupacion3.Controls.Add(Me.ndCostoTotalDol)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion3.Controls.Add(Me.txtMedida)
        Me.Agrupacion3.Controls.Add(Me.lblMarca)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion3.Controls.Add(Me.txtDiseño)
        Me.Agrupacion3.Controls.Add(Me.txtMarcaN)
        Me.Agrupacion3.Controls.Add(Me.txtEstado)
        Me.Agrupacion3.Controls.Add(Me.ndKmTotalNeu)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(5, 22)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(502, 129)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.Text = "Datos Neumaticos:"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtPosicion
        '
        Appearance47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPosicion.Appearance = Appearance47
        Me.txtPosicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPosicion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPosicion.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosicion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPosicion.Location = New System.Drawing.Point(369, 101)
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.ReadOnly = True
        Me.txtPosicion.Size = New System.Drawing.Size(117, 21)
        Me.txtPosicion.TabIndex = 15
        '
        'Etiqueta18
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance48
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta18.Location = New System.Drawing.Point(316, 104)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta18.TabIndex = 14
        Me.Etiqueta18.Text = "Posicion:"
        '
        'txtCodigo
        '
        Appearance49.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance49
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(124, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(153, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'ndCostoTotalDol
        '
        Appearance50.ForeColor = System.Drawing.Color.Black
        Me.ndCostoTotalDol.Appearance = Appearance50
        Me.ndCostoTotalDol.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.ndCostoTotalDol.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndCostoTotalDol.ForeColor = System.Drawing.Color.Black
        Me.ndCostoTotalDol.Location = New System.Drawing.Point(369, 73)
        Me.ndCostoTotalDol.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndCostoTotalDol.Name = "ndCostoTotalDol"
        Me.ndCostoTotalDol.NullText = "0.00"
        Me.ndCostoTotalDol.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndCostoTotalDol.ReadOnly = True
        Me.ndCostoTotalDol.Size = New System.Drawing.Size(117, 22)
        Me.ndCostoTotalDol.TabIndex = 11
        '
        'Etiqueta8
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance51
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(13, 103)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(104, 15)
        Me.Etiqueta8.TabIndex = 12
        Me.Etiqueta8.Text = "Km. Total Recorrido:"
        '
        'Etiqueta17
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance52
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta17.Location = New System.Drawing.Point(291, 77)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(72, 15)
        Me.Etiqueta17.TabIndex = 10
        Me.Etiqueta17.Text = "Costo Total $:"
        '
        'txtMedida
        '
        Appearance53.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMedida.Appearance = Appearance53
        Me.txtMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMedida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMedida.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedida.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMedida.Location = New System.Drawing.Point(124, 74)
        Me.txtMedida.Name = "txtMedida"
        Me.txtMedida.ReadOnly = True
        Me.txtMedida.Size = New System.Drawing.Size(153, 21)
        Me.txtMedida.TabIndex = 9
        '
        'lblMarca
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Me.lblMarca.Appearance = Appearance54
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMarca.Location = New System.Drawing.Point(80, 48)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 15)
        Me.lblMarca.TabIndex = 4
        Me.lblMarca.Text = "Marca:"
        '
        'Etiqueta4
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance55
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(322, 49)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(41, 15)
        Me.Etiqueta4.TabIndex = 6
        Me.Etiqueta4.Text = "Diseño:"
        '
        'Etiqueta5
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance56
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(76, 23)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(41, 15)
        Me.Etiqueta5.TabIndex = 0
        Me.Etiqueta5.Text = "Codigo:"
        '
        'Etiqueta6
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance57
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(75, 78)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta6.TabIndex = 8
        Me.Etiqueta6.Text = "Medida:"
        '
        'txtDiseño
        '
        Appearance58.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDiseño.Appearance = Appearance58
        Me.txtDiseño.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiseño.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDiseño.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiseño.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDiseño.Location = New System.Drawing.Point(369, 47)
        Me.txtDiseño.Name = "txtDiseño"
        Me.txtDiseño.ReadOnly = True
        Me.txtDiseño.Size = New System.Drawing.Size(117, 21)
        Me.txtDiseño.TabIndex = 7
        '
        'txtMarcaN
        '
        Appearance59.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMarcaN.Appearance = Appearance59
        Me.txtMarcaN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaN.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMarcaN.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaN.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMarcaN.Location = New System.Drawing.Point(124, 46)
        Me.txtMarcaN.Name = "txtMarcaN"
        Me.txtMarcaN.ReadOnly = True
        Me.txtMarcaN.Size = New System.Drawing.Size(153, 21)
        Me.txtMarcaN.TabIndex = 5
        '
        'txtEstado
        '
        Appearance60.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEstado.Appearance = Appearance60
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEstado.Location = New System.Drawing.Point(369, 20)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(117, 21)
        Me.txtEstado.TabIndex = 3
        '
        'ndKmTotalNeu
        '
        Appearance61.ForeColor = System.Drawing.Color.Black
        Me.ndKmTotalNeu.Appearance = Appearance61
        Me.ndKmTotalNeu.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.ndKmTotalNeu.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndKmTotalNeu.ForeColor = System.Drawing.Color.Black
        Me.ndKmTotalNeu.FormatString = "#,##0.00"
        Me.ndKmTotalNeu.Location = New System.Drawing.Point(124, 100)
        Me.ndKmTotalNeu.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndKmTotalNeu.Name = "ndKmTotalNeu"
        Me.ndKmTotalNeu.NullText = "0.00"
        Me.ndKmTotalNeu.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndKmTotalNeu.ReadOnly = True
        Me.ndKmTotalNeu.Size = New System.Drawing.Size(153, 22)
        Me.ndKmTotalNeu.TabIndex = 13
        '
        'Etiqueta7
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance62
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(322, 22)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta7.TabIndex = 2
        Me.Etiqueta7.Text = "Estado:"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.ndCocada)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel4)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel5)
        Me.Agrupacion2.Controls.Add(Me.ndRibete1)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel6)
        Me.Agrupacion2.Controls.Add(Me.ndRibete2)
        Me.Agrupacion2.Controls.Add(Me.ndRibete3)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel9)
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(513, 22)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(162, 129)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.Text = "Ribetes:"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ndCocada
        '
        Appearance63.ForeColor = System.Drawing.Color.Black
        Me.ndCocada.Appearance = Appearance63
        Me.ndCocada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.ndCocada.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndCocada.ForeColor = System.Drawing.Color.Black
        Me.ndCocada.Location = New System.Drawing.Point(69, 101)
        Me.ndCocada.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndCocada.Name = "ndCocada"
        Me.ndCocada.NullText = "0.00"
        Me.ndCocada.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndCocada.ReadOnly = True
        Me.ndCocada.Size = New System.Drawing.Size(79, 20)
        Me.ndCocada.TabIndex = 7
        '
        'UltraLabel4
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Appearance64.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance64
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(17, 104)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(45, 15)
        Me.UltraLabel4.TabIndex = 6
        Me.UltraLabel4.Text = "Cocada:"
        '
        'UltraLabel5
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Appearance65.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance65
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(14, 21)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(49, 15)
        Me.UltraLabel5.TabIndex = 0
        Me.UltraLabel5.Text = "Ribete 1:"
        '
        'ndRibete1
        '
        Appearance66.ForeColor = System.Drawing.Color.Black
        Me.ndRibete1.Appearance = Appearance66
        Me.ndRibete1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.ndRibete1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndRibete1.ForeColor = System.Drawing.Color.Black
        Me.ndRibete1.FormatProvider = New System.Globalization.CultureInfo("es-PE")
        Me.ndRibete1.FormatString = ""
        Me.ndRibete1.Location = New System.Drawing.Point(69, 19)
        Me.ndRibete1.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndRibete1.Name = "ndRibete1"
        Me.ndRibete1.NullText = "0"
        Me.ndRibete1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndRibete1.ReadOnly = True
        Me.ndRibete1.Size = New System.Drawing.Size(79, 20)
        Me.ndRibete1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.ndRibete1.SpinIncrement = 1
        Me.ndRibete1.TabIndex = 1
        '
        'UltraLabel6
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Appearance67.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance67
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(14, 48)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(49, 15)
        Me.UltraLabel6.TabIndex = 2
        Me.UltraLabel6.Text = "Ribete 2:"
        '
        'ndRibete2
        '
        Appearance68.ForeColor = System.Drawing.Color.Black
        Me.ndRibete2.Appearance = Appearance68
        Me.ndRibete2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.ndRibete2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndRibete2.ForeColor = System.Drawing.Color.Black
        Me.ndRibete2.Location = New System.Drawing.Point(69, 46)
        Me.ndRibete2.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndRibete2.Name = "ndRibete2"
        Me.ndRibete2.Nullable = True
        Me.ndRibete2.NullText = "0"
        Me.ndRibete2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndRibete2.ReadOnly = True
        Me.ndRibete2.Size = New System.Drawing.Size(79, 20)
        Me.ndRibete2.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.ndRibete2.SpinIncrement = 1
        Me.ndRibete2.TabIndex = 3
        '
        'ndRibete3
        '
        Appearance69.ForeColor = System.Drawing.Color.Black
        Me.ndRibete3.Appearance = Appearance69
        Me.ndRibete3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.ndRibete3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndRibete3.ForeColor = System.Drawing.Color.Black
        Me.ndRibete3.Location = New System.Drawing.Point(69, 75)
        Me.ndRibete3.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndRibete3.Name = "ndRibete3"
        Me.ndRibete3.Nullable = True
        Me.ndRibete3.NullText = "0"
        Me.ndRibete3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndRibete3.ReadOnly = True
        Me.ndRibete3.Size = New System.Drawing.Size(79, 20)
        Me.ndRibete3.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.ndRibete3.SpinIncrement = 1
        Me.ndRibete3.TabIndex = 5
        '
        'UltraLabel9
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Appearance70.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance70
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(14, 77)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(49, 15)
        Me.UltraLabel9.TabIndex = 4
        Me.UltraLabel9.Text = "Ribete 3:"
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(688, 264)
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 360)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(688, 264)
        Me.UltraExpandableGroupBox1.TabIndex = 2
        Me.UltraExpandableGroupBox1.Text = "Operaciones:"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.grid_Operaciones)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(682, 241)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'grid_Operaciones
        '
        Me.grid_Operaciones.ContextMenuStrip = Me.mcSubMenuOperaciones
        Me.grid_Operaciones.DataSource = Me.odOperaciones
        UltraGridColumn114.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance71.TextHAlignAsString = "Center"
        UltraGridColumn114.Header.Appearance = Appearance71
        UltraGridColumn114.Header.VisiblePosition = 0
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance72.TextHAlignAsString = "Center"
        UltraGridColumn115.Header.Appearance = Appearance72
        UltraGridColumn115.Header.VisiblePosition = 1
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance73.TextHAlignAsString = "Center"
        UltraGridColumn116.Header.Appearance = Appearance73
        UltraGridColumn116.Header.VisiblePosition = 2
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance74.TextHAlignAsString = "Center"
        UltraGridColumn117.Header.Appearance = Appearance74
        UltraGridColumn117.Header.VisiblePosition = 9
        UltraGridColumn117.Width = 68
        UltraGridColumn118.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance75.TextHAlignAsString = "Center"
        UltraGridColumn118.Header.Appearance = Appearance75
        UltraGridColumn118.Header.VisiblePosition = 3
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance76.TextHAlignAsString = "Center"
        UltraGridColumn119.Header.Appearance = Appearance76
        UltraGridColumn119.Header.VisiblePosition = 4
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance77.TextHAlignAsString = "Center"
        UltraGridColumn120.Header.Appearance = Appearance77
        UltraGridColumn120.Header.VisiblePosition = 5
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance78.TextHAlignAsString = "Center"
        UltraGridColumn121.Header.Appearance = Appearance78
        UltraGridColumn121.Header.VisiblePosition = 6
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn122.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance79.TextHAlignAsString = "Center"
        UltraGridColumn122.Header.Appearance = Appearance79
        UltraGridColumn122.Header.Caption = "Fecha"
        UltraGridColumn122.Header.VisiblePosition = 8
        UltraGridColumn122.Width = 80
        Appearance80.TextHAlignAsString = "Right"
        UltraGridColumn123.CellAppearance = Appearance80
        UltraGridColumn123.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn123.Format = "#,##0.00"
        Appearance81.TextHAlignAsString = "Center"
        UltraGridColumn123.Header.Appearance = Appearance81
        UltraGridColumn123.Header.Caption = "KM Vehiculo"
        UltraGridColumn123.Header.VisiblePosition = 11
        UltraGridColumn123.Width = 73
        Appearance82.TextHAlignAsString = "Right"
        UltraGridColumn124.CellAppearance = Appearance82
        UltraGridColumn124.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn124.Format = "#,##0.00"
        Appearance83.TextHAlignAsString = "Center"
        UltraGridColumn124.Header.Appearance = Appearance83
        UltraGridColumn124.Header.Caption = "KM Recorrido Neu."
        UltraGridColumn124.Header.VisiblePosition = 12
        UltraGridColumn124.Width = 102
        UltraGridColumn125.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance84.TextHAlignAsString = "Center"
        UltraGridColumn125.Header.Appearance = Appearance84
        UltraGridColumn125.Header.VisiblePosition = 13
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance85.TextHAlignAsString = "Center"
        UltraGridColumn126.Header.Appearance = Appearance85
        UltraGridColumn126.Header.VisiblePosition = 14
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance86.TextHAlignAsString = "Center"
        UltraGridColumn127.Header.Appearance = Appearance86
        UltraGridColumn127.Header.VisiblePosition = 15
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance87.TextHAlignAsString = "Center"
        UltraGridColumn128.Header.Appearance = Appearance87
        UltraGridColumn128.Header.VisiblePosition = 16
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance88.TextHAlignAsString = "Center"
        UltraGridColumn129.Header.Appearance = Appearance88
        UltraGridColumn129.Header.VisiblePosition = 17
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance89.TextHAlignAsString = "Center"
        UltraGridColumn130.Header.Appearance = Appearance89
        UltraGridColumn130.Header.VisiblePosition = 18
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance90.TextHAlignAsString = "Center"
        UltraGridColumn131.Header.Appearance = Appearance90
        UltraGridColumn131.Header.VisiblePosition = 19
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance91.TextHAlignAsString = "Center"
        UltraGridColumn132.Header.Appearance = Appearance91
        UltraGridColumn132.Header.VisiblePosition = 20
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance92.TextHAlignAsString = "Center"
        UltraGridColumn133.Header.Appearance = Appearance92
        UltraGridColumn133.Header.VisiblePosition = 21
        UltraGridColumn133.Hidden = True
        Appearance93.TextHAlignAsString = "Center"
        UltraGridColumn134.CellAppearance = Appearance93
        UltraGridColumn134.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance94.TextHAlignAsString = "Center"
        UltraGridColumn134.Header.Appearance = Appearance94
        UltraGridColumn134.Header.Caption = "Pos"
        UltraGridColumn134.Header.VisiblePosition = 10
        UltraGridColumn134.Width = 33
        UltraGridColumn135.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance95.TextHAlignAsString = "Center"
        UltraGridColumn135.Header.Appearance = Appearance95
        UltraGridColumn135.Header.VisiblePosition = 7
        UltraGridColumn135.Width = 91
        UltraGridColumn136.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn136.Header.VisiblePosition = 22
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn137.Header.VisiblePosition = 23
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn138.Header.VisiblePosition = 24
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn139.Header.VisiblePosition = 25
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn140.Header.VisiblePosition = 26
        UltraGridColumn140.Hidden = True
        Appearance96.TextHAlignAsString = "Right"
        UltraGridColumn141.CellAppearance = Appearance96
        UltraGridColumn141.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn141.Format = "#,##0.00"
        UltraGridColumn141.Header.VisiblePosition = 27
        UltraGridColumn141.Hidden = True
        UltraGridColumn142.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance97.TextHAlignAsString = "Center"
        UltraGridColumn142.Header.Appearance = Appearance97
        UltraGridColumn142.Header.VisiblePosition = 28
        UltraGridColumn142.Width = 135
        UltraGridColumn143.Header.VisiblePosition = 29
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.Header.VisiblePosition = 30
        UltraGridColumn144.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 31
        UltraGridColumn1.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn1})
        Me.grid_Operaciones.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.grid_Operaciones.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Operaciones.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Operaciones.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Operaciones.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Operaciones.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_Operaciones.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid_Operaciones.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_Operaciones.DisplayLayout.Override.CellPadding = 0
        Appearance98.TextHAlignAsString = "Left"
        Me.grid_Operaciones.DisplayLayout.Override.HeaderAppearance = Appearance98
        Me.grid_Operaciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Operaciones.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Operaciones.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Operaciones.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_Operaciones.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_Operaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Operaciones.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Operaciones.Location = New System.Drawing.Point(0, 0)
        Me.grid_Operaciones.Name = "grid_Operaciones"
        Me.grid_Operaciones.Size = New System.Drawing.Size(682, 241)
        Me.grid_Operaciones.TabIndex = 0
        Me.grid_Operaciones.Text = "Grilla2"
        '
        'mcSubMenuOperaciones
        '
        Me.mcSubMenuOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcSubMenuOperaciones.ForeColor = System.Drawing.Color.Black
        Me.mcSubMenuOperaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmEliminar})
        Me.mcSubMenuOperaciones.Name = "MenuContextual1"
        Me.mcSubMenuOperaciones.Size = New System.Drawing.Size(111, 26)
        '
        'tsmEliminar
        '
        Me.tsmEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmEliminar.Name = "tsmEliminar"
        Me.tsmEliminar.Size = New System.Drawing.Size(110, 22)
        Me.tsmEliminar.Text = "Eliminar"
        Me.tsmEliminar.ToolTipText = "Actualizar"
        '
        'odOperaciones
        '
        UltraDataColumn89.DataType = GetType(Date)
        UltraDataColumn89.DefaultValue = New Date(CType(0, Long))
        UltraDataColumn90.DataType = GetType(Double)
        UltraDataColumn90.DefaultValue = 0.0R
        UltraDataColumn91.DataType = GetType(Double)
        UltraDataColumn91.DefaultValue = 0.0R
        UltraDataColumn101.DataType = GetType(Integer)
        UltraDataColumn101.DefaultValue = 0
        UltraDataColumn108.DataType = GetType(Double)
        UltraDataColumn108.DefaultValue = 0.0R
        UltraDataColumn112.DataType = GetType(Integer)
        Me.odOperaciones.Band.Columns.AddRange(New Object() {UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112})
        '
        'agrDatoGeneral
        '
        Me.agrDatoGeneral.Controls.Add(Me.UltraLabel7)
        Me.agrDatoGeneral.Controls.Add(Me.ndRibete4)
        Me.agrDatoGeneral.Controls.Add(Me.ndKmVehiculo)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta3)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta1)
        Me.agrDatoGeneral.Controls.Add(Me.txtTipo)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta2)
        Me.agrDatoGeneral.Controls.Add(Me.txtConfiguracion)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta35)
        Me.agrDatoGeneral.Controls.Add(Me.txtMarca)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta12)
        Me.agrDatoGeneral.Controls.Add(Me.txtPlaca)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(1228, 52)
        Me.agrDatoGeneral.TabIndex = 0
        Me.agrDatoGeneral.Text = "Vehiculo"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel7
        '
        Appearance99.BackColor = System.Drawing.Color.Transparent
        Appearance99.ForeColor = System.Drawing.Color.Navy
        Appearance99.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance99
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(1061, 24)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel7.TabIndex = 11
        Me.UltraLabel7.Text = "Ribete 4:"
        Me.UltraLabel7.Visible = False
        '
        'ndRibete4
        '
        Appearance100.ForeColor = System.Drawing.Color.Black
        Me.ndRibete4.Appearance = Appearance100
        Me.ndRibete4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.ndRibete4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndRibete4.ForeColor = System.Drawing.Color.Black
        Me.ndRibete4.Location = New System.Drawing.Point(950, 21)
        Me.ndRibete4.MaskInput = "{LOC}nnnnnnn.nn"
        Me.ndRibete4.Name = "ndRibete4"
        Me.ndRibete4.Nullable = True
        Me.ndRibete4.NullText = "0"
        Me.ndRibete4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndRibete4.ReadOnly = True
        Me.ndRibete4.Size = New System.Drawing.Size(105, 19)
        Me.ndRibete4.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.ndRibete4.SpinIncrement = 1
        Me.ndRibete4.TabIndex = 10
        Me.ndRibete4.Visible = False
        '
        'ndKmVehiculo
        '
        Appearance101.ForeColor = System.Drawing.Color.Black
        Me.ndKmVehiculo.Appearance = Appearance101
        Me.ndKmVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndKmVehiculo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndKmVehiculo.ForeColor = System.Drawing.Color.Black
        Me.ndKmVehiculo.FormatString = "#,##0.00"
        Me.ndKmVehiculo.Location = New System.Drawing.Point(812, 20)
        Me.ndKmVehiculo.Name = "ndKmVehiculo"
        Me.ndKmVehiculo.NullText = "0.00"
        Me.ndKmVehiculo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndKmVehiculo.Size = New System.Drawing.Size(132, 22)
        Me.ndKmVehiculo.TabIndex = 9
        '
        'Etiqueta3
        '
        Appearance102.BackColor = System.Drawing.Color.Transparent
        Appearance102.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance102
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(743, 24)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(63, 15)
        Me.Etiqueta3.TabIndex = 8
        Me.Etiqueta3.Text = "Kilometraje:"
        '
        'Etiqueta1
        '
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance103
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(368, 24)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(29, 15)
        Me.Etiqueta1.TabIndex = 4
        Me.Etiqueta1.Text = "Tipo:"
        '
        'txtTipo
        '
        Appearance104.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipo.Appearance = Appearance104
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipo.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipo.Location = New System.Drawing.Point(403, 20)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(146, 21)
        Me.txtTipo.TabIndex = 5
        '
        'Etiqueta2
        '
        Appearance105.BackColor = System.Drawing.Color.Transparent
        Appearance105.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance105
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(555, 24)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(74, 15)
        Me.Etiqueta2.TabIndex = 6
        Me.Etiqueta2.Text = "Configuracion:"
        '
        'txtConfiguracion
        '
        Appearance106.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtConfiguracion.Appearance = Appearance106
        Me.txtConfiguracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConfiguracion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtConfiguracion.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfiguracion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtConfiguracion.Location = New System.Drawing.Point(635, 20)
        Me.txtConfiguracion.Name = "txtConfiguracion"
        Me.txtConfiguracion.ReadOnly = True
        Me.txtConfiguracion.Size = New System.Drawing.Size(100, 21)
        Me.txtConfiguracion.TabIndex = 7
        '
        'Etiqueta35
        '
        Appearance107.BackColor = System.Drawing.Color.Transparent
        Appearance107.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta35.Appearance = Appearance107
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta35.Location = New System.Drawing.Point(160, 24)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta35.TabIndex = 2
        Me.Etiqueta35.Text = "Marca:"
        '
        'txtMarca
        '
        Appearance108.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMarca.Appearance = Appearance108
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMarca.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMarca.Location = New System.Drawing.Point(203, 20)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(157, 21)
        Me.txtMarca.TabIndex = 3
        '
        'Etiqueta12
        '
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance109
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(12, 24)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta12.TabIndex = 0
        Me.Etiqueta12.Text = "Placa:"
        '
        'txtPlaca
        '
        Appearance110.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPlaca.Appearance = Appearance110
        Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPlaca.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPlaca.Location = New System.Drawing.Point(54, 20)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.ReadOnly = True
        Me.txtPlaca.Size = New System.Drawing.Size(100, 21)
        Me.txtPlaca.TabIndex = 1
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion5)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1228, 676)
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.grid_Neumaticos)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(0, 77)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(1228, 599)
        Me.Agrupacion5.TabIndex = 1
        Me.Agrupacion5.Text = "Operaciones"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grid_Neumaticos
        '
        Me.grid_Neumaticos.DataSource = Me.odInspeccion
        Appearance111.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn145.CellAppearance = Appearance111
        Appearance112.TextHAlignAsString = "Center"
        UltraGridColumn145.Header.Appearance = Appearance112
        UltraGridColumn145.Header.VisiblePosition = 0
        UltraGridColumn145.Hidden = True
        Appearance113.TextHAlignAsString = "Center"
        UltraGridColumn146.Header.Appearance = Appearance113
        UltraGridColumn146.Header.VisiblePosition = 3
        UltraGridColumn146.Hidden = True
        Appearance114.TextHAlignAsString = "Center"
        UltraGridColumn147.Header.Appearance = Appearance114
        UltraGridColumn147.Header.VisiblePosition = 1
        UltraGridColumn147.Hidden = True
        Appearance115.TextHAlignAsString = "Center"
        UltraGridColumn148.Header.Appearance = Appearance115
        UltraGridColumn148.Header.Caption = "Codigo Neu"
        UltraGridColumn148.Header.VisiblePosition = 2
        UltraGridColumn148.Width = 83
        Appearance116.TextHAlignAsString = "Center"
        UltraGridColumn149.Header.Appearance = Appearance116
        UltraGridColumn149.Header.VisiblePosition = 4
        UltraGridColumn149.Hidden = True
        Appearance117.TextHAlignAsString = "Center"
        UltraGridColumn150.Header.Appearance = Appearance117
        UltraGridColumn150.Header.VisiblePosition = 5
        UltraGridColumn150.Hidden = True
        Appearance118.TextHAlignAsString = "Center"
        UltraGridColumn151.Header.Appearance = Appearance118
        UltraGridColumn151.Header.VisiblePosition = 6
        UltraGridColumn151.Hidden = True
        Appearance119.TextHAlignAsString = "Center"
        UltraGridColumn152.Header.Appearance = Appearance119
        UltraGridColumn152.Header.VisiblePosition = 7
        UltraGridColumn152.Hidden = True
        Appearance120.TextHAlignAsString = "Center"
        UltraGridColumn153.Header.Appearance = Appearance120
        UltraGridColumn153.Header.VisiblePosition = 8
        Appearance121.TextHAlignAsString = "Center"
        UltraGridColumn154.Header.Appearance = Appearance121
        UltraGridColumn154.Header.VisiblePosition = 9
        Appearance122.TextHAlignAsString = "Center"
        UltraGridColumn155.Header.Appearance = Appearance122
        UltraGridColumn155.Header.VisiblePosition = 10
        UltraGridColumn155.Width = 101
        Appearance123.TextHAlignAsString = "Center"
        UltraGridColumn156.CellAppearance = Appearance123
        Appearance124.TextHAlignAsString = "Center"
        UltraGridColumn156.Header.Appearance = Appearance124
        UltraGridColumn156.Header.Caption = "Pos"
        UltraGridColumn156.Header.VisiblePosition = 11
        UltraGridColumn156.Width = 43
        Appearance125.TextHAlignAsString = "Center"
        UltraGridColumn157.Header.Appearance = Appearance125
        UltraGridColumn157.Header.VisiblePosition = 12
        UltraGridColumn157.Hidden = True
        Appearance126.TextHAlignAsString = "Center"
        UltraGridColumn158.Header.Appearance = Appearance126
        UltraGridColumn158.Header.VisiblePosition = 13
        UltraGridColumn158.Hidden = True
        Appearance127.TextHAlignAsString = "Center"
        UltraGridColumn159.Header.Appearance = Appearance127
        UltraGridColumn159.Header.Caption = "CodigoOper"
        UltraGridColumn159.Header.VisiblePosition = 14
        UltraGridColumn159.Hidden = True
        Appearance128.TextHAlignAsString = "Center"
        UltraGridColumn160.Header.Appearance = Appearance128
        UltraGridColumn160.Header.VisiblePosition = 15
        UltraGridColumn160.Hidden = True
        Appearance129.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance129.TextHAlignAsString = "Right"
        UltraGridColumn161.CellAppearance = Appearance129
        UltraGridColumn161.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance130.TextHAlignAsString = "Center"
        UltraGridColumn161.Header.Appearance = Appearance130
        UltraGridColumn161.Header.VisiblePosition = 23
        UltraGridColumn161.Width = 62
        Appearance131.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance131.TextHAlignAsString = "Right"
        UltraGridColumn162.CellAppearance = Appearance131
        UltraGridColumn162.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance132.TextHAlignAsString = "Center"
        UltraGridColumn162.Header.Appearance = Appearance132
        UltraGridColumn162.Header.Caption = "Ribete 1"
        UltraGridColumn162.Header.VisiblePosition = 19
        UltraGridColumn162.Width = 57
        Appearance133.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance133.TextHAlignAsString = "Right"
        UltraGridColumn163.CellAppearance = Appearance133
        UltraGridColumn163.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance134.TextHAlignAsString = "Center"
        UltraGridColumn163.Header.Appearance = Appearance134
        UltraGridColumn163.Header.Caption = "Ribete 2"
        UltraGridColumn163.Header.VisiblePosition = 20
        UltraGridColumn163.Width = 64
        Appearance135.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance135.TextHAlignAsString = "Right"
        UltraGridColumn164.CellAppearance = Appearance135
        UltraGridColumn164.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance136.TextHAlignAsString = "Center"
        UltraGridColumn164.Header.Appearance = Appearance136
        UltraGridColumn164.Header.Caption = "Ribete 3"
        UltraGridColumn164.Header.VisiblePosition = 21
        UltraGridColumn164.Width = 64
        Appearance137.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance137.TextHAlignAsString = "Right"
        UltraGridColumn165.CellAppearance = Appearance137
        UltraGridColumn165.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance138.TextHAlignAsString = "Center"
        UltraGridColumn165.Header.Appearance = Appearance138
        UltraGridColumn165.Header.Caption = "Ribete 4"
        UltraGridColumn165.Header.VisiblePosition = 22
        UltraGridColumn165.Hidden = True
        UltraGridColumn165.Width = 62
        Appearance139.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance139.TextHAlignAsString = "Right"
        UltraGridColumn166.CellAppearance = Appearance139
        UltraGridColumn166.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance140.TextHAlignAsString = "Center"
        UltraGridColumn166.Header.Appearance = Appearance140
        UltraGridColumn166.Header.VisiblePosition = 24
        UltraGridColumn166.Width = 58
        Appearance141.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn167.CellAppearance = Appearance141
        UltraGridColumn167.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance142.TextHAlignAsString = "Center"
        UltraGridColumn167.Header.Appearance = Appearance142
        UltraGridColumn167.Header.VisiblePosition = 25
        UltraGridColumn167.Width = 156
        Appearance143.TextHAlignAsString = "Center"
        UltraGridColumn168.Header.Appearance = Appearance143
        UltraGridColumn168.Header.VisiblePosition = 26
        UltraGridColumn168.Hidden = True
        Appearance144.TextHAlignAsString = "Center"
        UltraGridColumn169.Header.Appearance = Appearance144
        UltraGridColumn169.Header.VisiblePosition = 27
        UltraGridColumn169.Hidden = True
        Appearance145.TextHAlignAsString = "Right"
        UltraGridColumn170.CellAppearance = Appearance145
        UltraGridColumn170.Format = "#,##0.00"
        Appearance146.TextHAlignAsString = "Center"
        UltraGridColumn170.Header.Appearance = Appearance146
        UltraGridColumn170.Header.Caption = "KM Vehiculo Op Ant."
        UltraGridColumn170.Header.VisiblePosition = 16
        UltraGridColumn170.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn170.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn170.Width = 121
        Appearance147.TextHAlignAsString = "Right"
        UltraGridColumn171.CellAppearance = Appearance147
        UltraGridColumn171.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn171.Format = "#,##0.00"
        Appearance148.TextHAlignAsString = "Center"
        UltraGridColumn171.Header.Appearance = Appearance148
        UltraGridColumn171.Header.Caption = "KM Neumatico"
        UltraGridColumn171.Header.VisiblePosition = 18
        UltraGridColumn171.MaskInput = "{LOC}n,nnn,nnn.nn"
        UltraGridColumn171.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn171.Width = 97
        Appearance149.TextHAlignAsString = "Right"
        UltraGridColumn172.CellAppearance = Appearance149
        UltraGridColumn172.Format = "#,##0.00"
        UltraGridColumn172.Header.VisiblePosition = 17
        UltraGridColumn172.Hidden = True
        UltraGridColumn172.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn172.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn172.Width = 107
        UltraGridColumn173.Header.VisiblePosition = 28
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.Header.VisiblePosition = 29
        UltraGridColumn174.Hidden = True
        UltraGridColumn175.Header.VisiblePosition = 30
        UltraGridColumn175.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 31
        UltraGridColumn2.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn2})
        Me.grid_Neumaticos.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.grid_Neumaticos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Neumaticos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Neumaticos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Neumaticos.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_Neumaticos.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Neumaticos.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_Neumaticos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Neumaticos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_Neumaticos.DisplayLayout.Override.CellPadding = 0
        Appearance150.TextHAlignAsString = "Left"
        Me.grid_Neumaticos.DisplayLayout.Override.HeaderAppearance = Appearance150
        Me.grid_Neumaticos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Neumaticos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Neumaticos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_Neumaticos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Neumaticos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grid_Neumaticos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_Neumaticos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_Neumaticos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_Neumaticos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Neumaticos.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Neumaticos.Location = New System.Drawing.Point(3, 17)
        Me.grid_Neumaticos.Name = "grid_Neumaticos"
        Me.grid_Neumaticos.Size = New System.Drawing.Size(1222, 579)
        Me.grid_Neumaticos.TabIndex = 0
        Me.grid_Neumaticos.Text = "Grilla1"
        '
        'odInspeccion
        '
        UltraDataColumn124.DataType = GetType(Integer)
        UltraDataColumn124.DefaultValue = 0
        UltraDataColumn128.DataType = GetType(Date)
        UltraDataColumn128.DefaultValue = New Date(CType(0, Long))
        UltraDataColumn129.DataType = GetType(Integer)
        UltraDataColumn129.DefaultValue = 0
        UltraDataColumn130.DataType = GetType(Integer)
        UltraDataColumn130.DefaultValue = 0
        UltraDataColumn131.DataType = GetType(Integer)
        UltraDataColumn131.DefaultValue = 0
        UltraDataColumn132.DataType = GetType(Integer)
        UltraDataColumn132.DefaultValue = 0
        UltraDataColumn133.DataType = GetType(Integer)
        UltraDataColumn133.DefaultValue = 0
        UltraDataColumn134.DataType = GetType(Double)
        UltraDataColumn134.DefaultValue = 0.0R
        UltraDataColumn138.DataType = GetType(Double)
        UltraDataColumn138.DefaultValue = 0.0R
        UltraDataColumn139.DataType = GetType(Decimal)
        UltraDataColumn139.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        UltraDataColumn140.DataType = GetType(Double)
        UltraDataColumn140.DefaultValue = 0.0R
        UltraDataColumn144.DataType = GetType(Integer)
        Me.odInspeccion.Band.Columns.AddRange(New Object() {UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.btnActualizarKmVeh)
        Me.UltraGroupBox1.Controls.Add(Me.btnInspeccion)
        Me.UltraGroupBox1.Controls.Add(Me.btnCalcularKmNeu)
        Me.UltraGroupBox1.Controls.Add(Me.ndOdometro)
        Me.UltraGroupBox1.Controls.Add(Me.ndKMInspeccion)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta16)
        Me.UltraGroupBox1.Controls.Add(Me.dtpFechaInspeccion)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta15)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta9)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta10)
        Me.UltraGroupBox1.Controls.Add(Me.txtTipoInps)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta11)
        Me.UltraGroupBox1.Controls.Add(Me.txtConfigInsp)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta13)
        Me.UltraGroupBox1.Controls.Add(Me.txtMarcaInsp)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta14)
        Me.UltraGroupBox1.Controls.Add(Me.txtPlacaInsp)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1228, 77)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Vehiculo"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnActualizarKmVeh
        '
        Appearance151.ForeColor = System.Drawing.Color.Navy
        Me.btnActualizarKmVeh.Appearance = Appearance151
        Me.btnActualizarKmVeh.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnActualizarKmVeh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizarKmVeh.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarKmVeh.ForeColor = System.Drawing.Color.Black
        Me.btnActualizarKmVeh.Location = New System.Drawing.Point(782, 47)
        Me.btnActualizarKmVeh.Name = "btnActualizarKmVeh"
        Me.btnActualizarKmVeh.Size = New System.Drawing.Size(112, 25)
        Me.btnActualizarKmVeh.TabIndex = 16
        Me.btnActualizarKmVeh.Text = "Actualizar Km. Veh."
        '
        'btnInspeccion
        '
        Appearance152.ForeColor = System.Drawing.Color.Navy
        Me.btnInspeccion.Appearance = Appearance152
        Me.btnInspeccion.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnInspeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInspeccion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInspeccion.ForeColor = System.Drawing.Color.Black
        Me.btnInspeccion.Location = New System.Drawing.Point(664, 47)
        Me.btnInspeccion.Name = "btnInspeccion"
        Me.btnInspeccion.Size = New System.Drawing.Size(112, 25)
        Me.btnInspeccion.TabIndex = 15
        Me.btnInspeccion.Text = "Imprimir Inspeccion"
        '
        'btnCalcularKmNeu
        '
        Appearance153.ForeColor = System.Drawing.Color.Navy
        Me.btnCalcularKmNeu.Appearance = Appearance153
        Me.btnCalcularKmNeu.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCalcularKmNeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalcularKmNeu.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularKmNeu.ForeColor = System.Drawing.Color.Black
        Me.btnCalcularKmNeu.Location = New System.Drawing.Point(614, 46)
        Me.btnCalcularKmNeu.Name = "btnCalcularKmNeu"
        Me.btnCalcularKmNeu.Size = New System.Drawing.Size(25, 25)
        Me.btnCalcularKmNeu.TabIndex = 12
        Me.btnCalcularKmNeu.Text = "i"
        '
        'ndOdometro
        '
        Appearance154.ForeColor = System.Drawing.Color.Black
        Me.ndOdometro.Appearance = Appearance154
        Me.ndOdometro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.ndOdometro.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndOdometro.ForeColor = System.Drawing.Color.Black
        Me.ndOdometro.Location = New System.Drawing.Point(508, 21)
        Me.ndOdometro.MaskInput = "{LOC}nn,nnn,nnn.nn"
        Me.ndOdometro.Name = "ndOdometro"
        Me.ndOdometro.NullText = "0.00"
        Me.ndOdometro.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndOdometro.ReadOnly = True
        Me.ndOdometro.Size = New System.Drawing.Size(100, 22)
        Me.ndOdometro.TabIndex = 9
        '
        'ndKMInspeccion
        '
        Appearance155.ForeColor = System.Drawing.Color.Black
        Me.ndKMInspeccion.Appearance = Appearance155
        Me.ndKMInspeccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.ndKMInspeccion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndKMInspeccion.ForeColor = System.Drawing.Color.Black
        Me.ndKMInspeccion.Location = New System.Drawing.Point(508, 49)
        Me.ndKMInspeccion.MaskInput = "{LOC}nn,nnn,nnn.nn"
        Me.ndKMInspeccion.Name = "ndKMInspeccion"
        Me.ndKMInspeccion.NullText = "0.00"
        Me.ndKMInspeccion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndKMInspeccion.Size = New System.Drawing.Size(100, 22)
        Me.ndKMInspeccion.TabIndex = 11
        '
        'Etiqueta16
        '
        Appearance156.BackColor = System.Drawing.Color.Transparent
        Appearance156.FontData.BoldAsString = "False"
        Appearance156.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance156
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(680, 23)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(92, 15)
        Me.Etiqueta16.TabIndex = 13
        Me.Etiqueta16.Text = "Fecha Inspeccion:"
        '
        'dtpFechaInspeccion
        '
        Appearance157.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dtpFechaInspeccion.Appearance = Appearance157
        Me.dtpFechaInspeccion.DateTime = New Date(2011, 11, 29, 0, 0, 0, 0)
        Me.dtpFechaInspeccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Standard
        Me.dtpFechaInspeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInspeccion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dtpFechaInspeccion.Location = New System.Drawing.Point(782, 22)
        Me.dtpFechaInspeccion.MaskInput = "{date}"
        Me.dtpFechaInspeccion.Name = "dtpFechaInspeccion"
        Me.dtpFechaInspeccion.Size = New System.Drawing.Size(100, 21)
        Me.dtpFechaInspeccion.TabIndex = 14
        Me.dtpFechaInspeccion.Value = New Date(2011, 11, 29, 0, 0, 0, 0)
        '
        'Etiqueta15
        '
        Appearance158.BackColor = System.Drawing.Color.Transparent
        Appearance158.FontData.BoldAsString = "False"
        Appearance158.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance158
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(395, 51)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(104, 15)
        Me.Etiqueta15.TabIndex = 10
        Me.Etiqueta15.Text = "KM Nvo. Inspeccion:"
        '
        'Etiqueta9
        '
        Appearance159.BackColor = System.Drawing.Color.Transparent
        Appearance159.FontData.BoldAsString = "False"
        Appearance159.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance159
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(444, 23)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta9.TabIndex = 8
        Me.Etiqueta9.Text = "Odometro:"
        '
        'Etiqueta10
        '
        Appearance160.BackColor = System.Drawing.Color.Transparent
        Appearance160.FontData.BoldAsString = "False"
        Appearance160.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance160
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(222, 51)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(29, 15)
        Me.Etiqueta10.TabIndex = 6
        Me.Etiqueta10.Text = "Tipo:"
        '
        'txtTipoInps
        '
        Appearance161.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoInps.Appearance = Appearance161
        Me.txtTipoInps.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoInps.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoInps.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoInps.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoInps.Location = New System.Drawing.Point(266, 49)
        Me.txtTipoInps.Name = "txtTipoInps"
        Me.txtTipoInps.ReadOnly = True
        Me.txtTipoInps.Size = New System.Drawing.Size(100, 21)
        Me.txtTipoInps.TabIndex = 7
        '
        'Etiqueta11
        '
        Appearance162.BackColor = System.Drawing.Color.Transparent
        Appearance162.FontData.BoldAsString = "False"
        Appearance162.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance162
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(14, 51)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(74, 15)
        Me.Etiqueta11.TabIndex = 2
        Me.Etiqueta11.Text = "Configuracion:"
        '
        'txtConfigInsp
        '
        Appearance163.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtConfigInsp.Appearance = Appearance163
        Me.txtConfigInsp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConfigInsp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtConfigInsp.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfigInsp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtConfigInsp.Location = New System.Drawing.Point(94, 49)
        Me.txtConfigInsp.Name = "txtConfigInsp"
        Me.txtConfigInsp.ReadOnly = True
        Me.txtConfigInsp.Size = New System.Drawing.Size(100, 21)
        Me.txtConfigInsp.TabIndex = 3
        '
        'Etiqueta13
        '
        Appearance164.BackColor = System.Drawing.Color.Transparent
        Appearance164.FontData.BoldAsString = "False"
        Appearance164.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance164
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(222, 25)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta13.TabIndex = 4
        Me.Etiqueta13.Text = "Marca:"
        '
        'txtMarcaInsp
        '
        Appearance165.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMarcaInsp.Appearance = Appearance165
        Me.txtMarcaInsp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaInsp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMarcaInsp.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaInsp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMarcaInsp.Location = New System.Drawing.Point(266, 23)
        Me.txtMarcaInsp.Name = "txtMarcaInsp"
        Me.txtMarcaInsp.ReadOnly = True
        Me.txtMarcaInsp.Size = New System.Drawing.Size(100, 21)
        Me.txtMarcaInsp.TabIndex = 5
        '
        'Etiqueta14
        '
        Appearance166.BackColor = System.Drawing.Color.Transparent
        Appearance166.FontData.BoldAsString = "False"
        Appearance166.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance166
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Location = New System.Drawing.Point(14, 25)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta14.TabIndex = 0
        Me.Etiqueta14.Text = "Placa:"
        '
        'txtPlacaInsp
        '
        Appearance167.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPlacaInsp.Appearance = Appearance167
        Me.txtPlacaInsp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacaInsp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPlacaInsp.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlacaInsp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPlacaInsp.Location = New System.Drawing.Point(94, 23)
        Me.txtPlacaInsp.Name = "txtPlacaInsp"
        Me.txtPlacaInsp.ReadOnly = True
        Me.txtPlacaInsp.Size = New System.Drawing.Size(100, 21)
        Me.txtPlacaInsp.TabIndex = 1
        '
        'tcVehiculo
        '
        Me.tcVehiculo.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcVehiculo.Controls.Add(Me.UltraTabPageControl7)
        Me.tcVehiculo.Controls.Add(Me.utpDetalle)
        Me.tcVehiculo.Controls.Add(Me.UltraTabPageControl1)
        Me.tcVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcVehiculo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcVehiculo.Location = New System.Drawing.Point(0, 0)
        Me.tcVehiculo.Name = "tcVehiculo"
        Me.tcVehiculo.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcVehiculo.Size = New System.Drawing.Size(1230, 699)
        Me.tcVehiculo.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Operaciones"
        UltraTab3.Key = "Inspecciones"
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Inspecciones"
        Me.tcVehiculo.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.tcVehiculo.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1228, 676)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(417, 315)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 25
        Me.ugb_Espera.Visible = False
        '
        'frm_OperacionesNeumatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1230, 699)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.tcVehiculo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_OperacionesNeumatico"
        Me.Text = "Operaciones e Inspecciones"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.grid_Vehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcOperaciones.ResumeLayout(False)
        Me.utpDetalle.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.agDispositivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agDispositivos.ResumeLayout(False)
        Me.agDispositivos.PerformLayout()
        Me.pnl_R3.ResumeLayout(False)
        CType(Me.picLlanta5e, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_R2.ResumeLayout(False)
        CType(Me.picLlanta5d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Eje4.ResumeLayout(False)
        CType(Me.picLlanta4c, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta4d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta4b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta4a, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Eje2.ResumeLayout(False)
        CType(Me.picLlanta2a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta2d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta2c, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta2b, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Eje3.ResumeLayout(False)
        CType(Me.picLlanta3a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta3b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta3c, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta3d, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Eje1.ResumeLayout(False)
        CType(Me.picLlanta1c, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta1d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta1b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLlanta1a, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Almacen.ResumeLayout(False)
        CType(Me.grid_Codigos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDestino.ResumeLayout(False)
        CType(Me.picAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReencauche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReparar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRepuestos.ResumeLayout(False)
        CType(Me.picLlanta5c, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEliminarMon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.grid_VidasNeumatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odVidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.txtPosicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndCostoTotalDol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiseño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarcaN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndKmTotalNeu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.ndCocada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndRibete1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndRibete2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndRibete3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.grid_Operaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcSubMenuOperaciones.ResumeLayout(False)
        CType(Me.odOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        Me.agrDatoGeneral.PerformLayout()
        CType(Me.ndRibete4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndKmVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        CType(Me.grid_Neumaticos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odInspeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.ndOdometro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndKMInspeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInspeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoInps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConfigInsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarcaInsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlacaInsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcVehiculo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcVehiculo As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grid_Vehiculos As ISL.Controles.Grilla
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents agDispositivos As ISL.Controles.Agrupacion
    Friend WithEvents pnl_R2 As System.Windows.Forms.Panel
    Friend WithEvents lblLlanta5d As System.Windows.Forms.Label
    Friend WithEvents picLlanta5d As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pbAlmacen As System.Windows.Forms.PictureBox
    Friend WithEvents pnl_Eje4 As System.Windows.Forms.Panel
    Friend WithEvents lblLlanta4c As System.Windows.Forms.Label
    Friend WithEvents lblLlanta4a As System.Windows.Forms.Label
    Friend WithEvents lblLlanta4b As System.Windows.Forms.Label
    Friend WithEvents lblLlanta4d As System.Windows.Forms.Label
    Friend WithEvents picLlanta4c As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta4d As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta4b As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta4a As System.Windows.Forms.PictureBox
    Friend WithEvents pnl_Eje2 As System.Windows.Forms.Panel
    Friend WithEvents lblLlanta2c As System.Windows.Forms.Label
    Friend WithEvents lblLlanta2b As System.Windows.Forms.Label
    Friend WithEvents lblLlanta2d As System.Windows.Forms.Label
    Friend WithEvents lblLlanta2a As System.Windows.Forms.Label
    Friend WithEvents picLlanta2a As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta2d As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta2c As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta2b As System.Windows.Forms.PictureBox
    Friend WithEvents pnl_Eje3 As System.Windows.Forms.Panel
    Friend WithEvents lblLlanta3c As System.Windows.Forms.Label
    Friend WithEvents lblLlanta3b As System.Windows.Forms.Label
    Friend WithEvents lblLlanta3d As System.Windows.Forms.Label
    Friend WithEvents lblLlanta3a As System.Windows.Forms.Label
    Friend WithEvents picLlanta3a As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta3b As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta3c As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta3d As System.Windows.Forms.PictureBox
    Friend WithEvents pnl_Eje1 As System.Windows.Forms.Panel
    Friend WithEvents lblLlanta1d As System.Windows.Forms.Label
    Friend WithEvents lblLlanta1c As System.Windows.Forms.Label
    Friend WithEvents lblLlanta1b As System.Windows.Forms.Label
    Friend WithEvents lblLlanta1a As System.Windows.Forms.Label
    Friend WithEvents picLlanta1c As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta1d As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta1b As System.Windows.Forms.PictureBox
    Friend WithEvents picLlanta1a As System.Windows.Forms.PictureBox
    Friend WithEvents pnl_Almacen As System.Windows.Forms.Panel
    Friend WithEvents pnlDestino As System.Windows.Forms.Panel
    Friend WithEvents picAlmacen As System.Windows.Forms.PictureBox
    Friend WithEvents picBaja As System.Windows.Forms.PictureBox
    Friend WithEvents picReencauche As System.Windows.Forms.PictureBox
    Friend WithEvents picReparar As System.Windows.Forms.PictureBox
    Friend WithEvents pnlRepuestos As System.Windows.Forms.Panel
    Friend WithEvents lblLlanta5c As System.Windows.Forms.Label
    Friend WithEvents picLlanta5c As System.Windows.Forms.PictureBox
    Friend WithEvents picEliminarMon As System.Windows.Forms.PictureBox
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents grid_Codigos As ISL.Controles.Grilla
    Friend WithEvents odCodigo As ISL.Controles.OrigenDatos
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtTipo As ISL.Controles.Texto
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents txtConfiguracion As ISL.Controles.Texto
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents txtMarca As ISL.Controles.Texto
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents txtPlaca As ISL.Controles.Texto
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents txtDiseño As ISL.Controles.Texto
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents txtMedida As ISL.Controles.Texto
    Friend WithEvents lblMarca As ISL.Controles.Etiqueta
    Friend WithEvents txtMarcaN As ISL.Controles.Texto
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents txtEstado As ISL.Controles.Texto
    Friend WithEvents ndKmTotalNeu As ISL.Controles.NumeroDecimal
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents ndCocada As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndRibete1 As ISL.Controles.NumeroEntero
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndRibete2 As ISL.Controles.NumeroEntero
    Friend WithEvents ndRibete3 As ISL.Controles.NumeroEntero
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents grid_VidasNeumatico As ISL.Controles.Grilla
    Friend WithEvents grid_Operaciones As ISL.Controles.Grilla
    Friend WithEvents odVidas As ISL.Controles.OrigenDatos
    Friend WithEvents odOperaciones As ISL.Controles.OrigenDatos
    Friend WithEvents mcOperaciones As ISL.Controles.MenuContextual
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents txtTipoInps As ISL.Controles.Texto
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents txtConfigInsp As ISL.Controles.Texto
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents txtMarcaInsp As ISL.Controles.Texto
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents txtPlacaInsp As ISL.Controles.Texto
    Friend WithEvents grid_Neumaticos As ISL.Controles.Grilla
    Friend WithEvents odInspeccion As ISL.Controles.OrigenDatos
    Friend WithEvents InspecciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents dtpFechaInspeccion As ISL.Controles.Fecha
    Friend WithEvents ndKMInspeccion As ISL.Controles.NumeroDecimal
    Friend WithEvents ndOdometro As ISL.Controles.NumeroDecimal
    Friend WithEvents btnCalcularKmNeu As ISL.Controles.Boton
    Friend WithEvents ndCostoTotalDol As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents ndKmVehiculo As ISL.Controles.NumeroDecimal
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents mcSubMenuOperaciones As ISL.Controles.MenuContextual
    Friend WithEvents tsmEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnInspeccion As ISL.Controles.Boton
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents pnl_R3 As System.Windows.Forms.Panel
    Friend WithEvents lblLlanta5e As System.Windows.Forms.Label
    Friend WithEvents picLlanta5e As System.Windows.Forms.PictureBox
    Friend WithEvents btnActualizarKmVeh As ISL.Controles.Boton
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndRibete4 As ISL.Controles.NumeroEntero
    Friend WithEvents txtPosicion As ISL.Controles.Texto
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents ugb_Espera As ISL.Win.Espere

End Class
