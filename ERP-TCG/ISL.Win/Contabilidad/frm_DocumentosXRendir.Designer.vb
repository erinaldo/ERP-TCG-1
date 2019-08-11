<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DocumentosXRendir
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
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdItemGasto")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis1")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis2")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAsiento")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsiento")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoFuncion")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProrrateo")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdItemGasto")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis1")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis2")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vehiculo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoAsiento")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsiento")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoFuncion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigenProrrateo")
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DocumentosXRendir))
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdItemGasto")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis1")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis2")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAsiento")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsiento")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoFuncion")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigenProrrateo")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.GridAgregado = New ISL.Controles.Grilla(Me.components)
        Me.MenuAgregado = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarAnalisis = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.Año1 = New ISL.Win.Año()
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecAplicacion = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMesAplicacion = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosaAplicacion = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecIGV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecSinIgv = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecImporte = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecNoGravada = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMesDocumento = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboItemGasto = New ISL.Controles.Combo(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.DecTotalDoc = New ISL.Controles.NumeroDecimal(Me.components)
        Me.FecEmision = New ISL.Controles.Fecha(Me.components)
        Me.DecTotalIgv = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecTotalImponible = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarCabecera = New System.Windows.Forms.ToolStripMenuItem()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.gridDetallePersonal = New ISL.Controles.Grilla(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.GridAgregado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAgregado.SuspendLayout()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        Me.Año1.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.FecAplicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMesAplicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosaAplicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecSinIgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.DecNoGravada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMesDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTotalDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecEmision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTotalIgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTotalImponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.gridDetallePersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.GridAgregado)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1165, 269)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'GridAgregado
        '
        Me.GridAgregado.ContextMenuStrip = Me.MenuAgregado
        Me.GridAgregado.DataSource = Me.UltraDataSource3
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.GridAgregado.DisplayLayout.Appearance = Appearance1
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 3
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 4
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 5
        UltraGridColumn12.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 7
        UltraGridColumn22.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 8
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 9
        UltraGridColumn31.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 11
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 10
        UltraGridColumn67.Hidden = True
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn68.CellAppearance = Appearance2
        UltraGridColumn68.Header.VisiblePosition = 12
        UltraGridColumn68.Hidden = True
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn69.CellAppearance = Appearance3
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn69.Header.Appearance = Appearance4
        UltraGridColumn69.Header.VisiblePosition = 19
        UltraGridColumn69.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn69.Width = 90
        UltraGridColumn70.Header.Caption = "Mon."
        UltraGridColumn70.Header.VisiblePosition = 18
        UltraGridColumn70.Width = 30
        UltraGridColumn71.Header.Caption = "Periodo"
        UltraGridColumn71.Header.VisiblePosition = 13
        UltraGridColumn71.Width = 71
        UltraGridColumn72.Header.VisiblePosition = 20
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 21
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 22
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 23
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 24
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 25
        UltraGridColumn78.Header.VisiblePosition = 15
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 16
        UltraGridColumn79.Width = 75
        UltraGridColumn80.Header.VisiblePosition = 17
        UltraGridColumn80.Width = 606
        UltraGridColumn81.Header.VisiblePosition = 26
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 14
        UltraGridColumn82.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn82.Width = 78
        UltraGridColumn83.Header.VisiblePosition = 27
        UltraGridColumn83.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn21, UltraGridColumn22, UltraGridColumn30, UltraGridColumn31, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83})
        Me.GridAgregado.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.GridAgregado.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.GridAgregado.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.BorderColor = System.Drawing.SystemColors.Window
        Me.GridAgregado.DisplayLayout.GroupByBox.Appearance = Appearance5
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GridAgregado.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance6
        Me.GridAgregado.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.GridAgregado.DisplayLayout.GroupByBox.Hidden = True
        Appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance7.BackColor2 = System.Drawing.SystemColors.Control
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GridAgregado.DisplayLayout.GroupByBox.PromptAppearance = Appearance7
        Me.GridAgregado.DisplayLayout.MaxColScrollRegions = 1
        Me.GridAgregado.DisplayLayout.MaxRowScrollRegions = 1
        Me.GridAgregado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.GridAgregado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GridAgregado.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.GridAgregado.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.GridAgregado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GridAgregado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridAgregado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GridAgregado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Me.GridAgregado.DisplayLayout.Override.RowAppearance = Appearance8
        Me.GridAgregado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridAgregado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GridAgregado.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.GridAgregado.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.GridAgregado.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GridAgregado.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.GridAgregado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAgregado.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridAgregado.Location = New System.Drawing.Point(3, 105)
        Me.GridAgregado.Name = "GridAgregado"
        Me.GridAgregado.Size = New System.Drawing.Size(1159, 161)
        Me.GridAgregado.TabIndex = 35
        Me.GridAgregado.Text = "Grilla2"
        '
        'MenuAgregado
        '
        Me.MenuAgregado.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuAgregado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarAnalisis})
        Me.MenuAgregado.Name = "mnu_Transferencias"
        Me.MenuAgregado.Size = New System.Drawing.Size(122, 30)
        '
        'EliminarAnalisis
        '
        Me.EliminarAnalisis.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarAnalisis.Name = "EliminarAnalisis"
        Me.EliminarAnalisis.Size = New System.Drawing.Size(121, 26)
        Me.EliminarAnalisis.Text = "Eliminar"
        '
        'UltraDataSource3
        '
        UltraDataColumn13.DataType = GetType(Double)
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataColumn27.DataType = GetType(Date)
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28})
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.Año1)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion4)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(3, 3)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1159, 102)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Año1
        '
        Me.Año1.Año = 2017
        Me.Año1.BackColor = System.Drawing.Color.Transparent
        Me.Año1.Controls.Add(Me.numAño)
        Me.Año1.Controls.Add(Me.NumeroEntero1)
        Me.Año1.Location = New System.Drawing.Point(1020, 25)
        Me.Año1.Name = "Año1"
        Me.Año1.Size = New System.Drawing.Size(54, 23)
        Me.Año1.TabIndex = 6
        '
        'numAño
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance9
        Me.numAño.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAño.ForeColor = System.Drawing.Color.Black
        Me.numAño.FormatString = ""
        Me.numAño.Location = New System.Drawing.Point(1, 0)
        Me.numAño.MaskInput = "nnnn"
        Me.numAño.MaxValue = 2020
        Me.numAño.MinValue = 2000
        Me.numAño.Name = "numAño"
        Me.numAño.NullText = "0"
        Me.numAño.Size = New System.Drawing.Size(52, 21)
        Me.numAño.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAño.TabIndex = 0
        Me.numAño.Value = 2011
        '
        'NumeroEntero1
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.Appearance = Appearance10
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
        Me.NumeroEntero1.Value = 2011
        '
        'Etiqueta10
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance11
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(1021, 4)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta10.TabIndex = 5
        Me.Etiqueta10.Text = "Ejercicio:"
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion5.Controls.Add(Me.FecAplicacion)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion5.Controls.Add(Me.cboMesAplicacion)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion5.Controls.Add(Me.txtGlosaAplicacion)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion5.Controls.Add(Me.DecIGV)
        Me.Agrupacion5.Controls.Add(Me.DecSinIgv)
        Me.Agrupacion5.Controls.Add(Me.DecImporte)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Agrupacion5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(602, 3)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(413, 96)
        Me.Agrupacion5.TabIndex = 18
        Me.Agrupacion5.Text = "Datos de Asiento de Aplicacion"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta12
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance12
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(181, 72)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta12.TabIndex = 299
        Me.Etiqueta12.Text = "Fecha:"
        '
        'FecAplicacion
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecAplicacion.Appearance = Appearance13
        Me.FecAplicacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecAplicacion.Enabled = False
        Me.FecAplicacion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecAplicacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecAplicacion.Location = New System.Drawing.Point(221, 71)
        Me.FecAplicacion.Name = "FecAplicacion"
        Me.FecAplicacion.Size = New System.Drawing.Size(100, 22)
        Me.FecAplicacion.TabIndex = 298
        '
        'Etiqueta11
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance14
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(174, 48)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(44, 15)
        Me.Etiqueta11.TabIndex = 297
        Me.Etiqueta11.Text = "Periodo:"
        '
        'cboMesAplicacion
        '
        Appearance15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesAplicacion.Appearance = Appearance15
        Me.cboMesAplicacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMesAplicacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMesAplicacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMesAplicacion.Enabled = False
        Me.cboMesAplicacion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMesAplicacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesAplicacion.Location = New System.Drawing.Point(221, 46)
        Me.cboMesAplicacion.Name = "cboMesAplicacion"
        Me.cboMesAplicacion.Size = New System.Drawing.Size(51, 22)
        Me.cboMesAplicacion.TabIndex = 296
        Me.cboMesAplicacion.ValueMember = "Id"
        '
        'Etiqueta9
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance16
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(183, 24)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta9.TabIndex = 265
        Me.Etiqueta9.Text = "Glosa:"
        '
        'txtGlosaAplicacion
        '
        Me.txtGlosaAplicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaAplicacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaAplicacion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaAplicacion.Location = New System.Drawing.Point(221, 21)
        Me.txtGlosaAplicacion.Name = "txtGlosaAplicacion"
        Me.txtGlosaAplicacion.Size = New System.Drawing.Size(187, 22)
        Me.txtGlosaAplicacion.TabIndex = 22
        '
        'Etiqueta8
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance17
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(31, 48)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(26, 15)
        Me.Etiqueta8.TabIndex = 263
        Me.Etiqueta8.Text = "IGV:"
        '
        'Etiqueta7
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance18
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(6, 24)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta7.TabIndex = 262
        Me.Etiqueta7.Text = "SubTotal:"
        '
        'Etiqueta6
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance19
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(25, 75)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(32, 15)
        Me.Etiqueta6.TabIndex = 261
        Me.Etiqueta6.Text = "Total:"
        '
        'DecIGV
        '
        Appearance20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIGV.Appearance = Appearance20
        Me.DecIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecIGV.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecIGV.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIGV.Location = New System.Drawing.Point(63, 45)
        Me.DecIGV.Name = "DecIGV"
        Me.DecIGV.NullText = "0.00"
        Me.DecIGV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecIGV.ReadOnly = True
        Me.DecIGV.Size = New System.Drawing.Size(100, 22)
        Me.DecIGV.TabIndex = 21
        '
        'DecSinIgv
        '
        Appearance21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecSinIgv.Appearance = Appearance21
        Me.DecSinIgv.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecSinIgv.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecSinIgv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecSinIgv.Location = New System.Drawing.Point(63, 20)
        Me.DecSinIgv.Name = "DecSinIgv"
        Me.DecSinIgv.NullText = "0.00"
        Me.DecSinIgv.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecSinIgv.ReadOnly = True
        Me.DecSinIgv.Size = New System.Drawing.Size(100, 22)
        Me.DecSinIgv.TabIndex = 20
        '
        'DecImporte
        '
        Appearance22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecImporte.Appearance = Appearance22
        Me.DecImporte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecImporte.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecImporte.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecImporte.Location = New System.Drawing.Point(63, 71)
        Me.DecImporte.Name = "DecImporte"
        Me.DecImporte.NullText = "0.00"
        Me.DecImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecImporte.ReadOnly = True
        Me.DecImporte.Size = New System.Drawing.Size(100, 22)
        Me.DecImporte.TabIndex = 19
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion4.Controls.Add(Me.DecNoGravada)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion4.Controls.Add(Me.cboMesDocumento)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta29)
        Me.Agrupacion4.Controls.Add(Me.cboItemGasto)
        Me.Agrupacion4.Controls.Add(Me.DecTotalDoc)
        Me.Agrupacion4.Controls.Add(Me.FecEmision)
        Me.Agrupacion4.Controls.Add(Me.DecTotalIgv)
        Me.Agrupacion4.Controls.Add(Me.DecTotalImponible)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta19)
        Me.Agrupacion4.Controls.Add(Me.decTC)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion4.Controls.Add(Me.cboMoneda)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Agrupacion4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(3, 3)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(599, 96)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.Text = "Datos Generales del Documento Asociado"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta13
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance23
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(511, 30)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta13.TabIndex = 297
        Me.Etiqueta13.Text = "NoGravada:"
        '
        'DecNoGravada
        '
        Appearance24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecNoGravada.Appearance = Appearance24
        Me.DecNoGravada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecNoGravada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecNoGravada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecNoGravada.Location = New System.Drawing.Point(511, 45)
        Me.DecNoGravada.Name = "DecNoGravada"
        Me.DecNoGravada.NullText = "0.00"
        Me.DecNoGravada.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecNoGravada.Size = New System.Drawing.Size(81, 22)
        Me.DecNoGravada.TabIndex = 296
        '
        'Etiqueta5
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance25
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(195, 24)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(44, 15)
        Me.Etiqueta5.TabIndex = 295
        Me.Etiqueta5.Text = "Periodo:"
        '
        'cboMesDocumento
        '
        Appearance26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesDocumento.Appearance = Appearance26
        Me.cboMesDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMesDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMesDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMesDocumento.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMesDocumento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesDocumento.Location = New System.Drawing.Point(246, 20)
        Me.cboMesDocumento.Name = "cboMesDocumento"
        Me.cboMesDocumento.Size = New System.Drawing.Size(55, 22)
        Me.cboMesDocumento.TabIndex = 11
        Me.cboMesDocumento.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance27
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(349, 24)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta2.TabIndex = 293
        Me.Etiqueta2.Text = "SubTotal:"
        '
        'Etiqueta1
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance28
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(374, 48)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(26, 15)
        Me.Etiqueta1.TabIndex = 292
        Me.Etiqueta1.Text = "IGV:"
        '
        'Etiqueta17
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta17.Appearance = Appearance29
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta17.Location = New System.Drawing.Point(368, 74)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(32, 15)
        Me.Etiqueta17.TabIndex = 291
        Me.Etiqueta17.Text = "Total:"
        '
        'Etiqueta29
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta29.Appearance = Appearance30
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta29.Location = New System.Drawing.Point(15, 48)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(45, 15)
        Me.Etiqueta29.TabIndex = 263
        Me.Etiqueta29.Text = "Emision:"
        '
        'cboItemGasto
        '
        Appearance31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.Appearance = Appearance31
        Me.cboItemGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboItemGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboItemGasto.DropDownListWidth = 400
        Me.cboItemGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboItemGasto.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemGasto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.ImageList = Me.imagenes
        Me.cboItemGasto.Location = New System.Drawing.Point(67, 71)
        Me.cboItemGasto.Name = "cboItemGasto"
        Me.cboItemGasto.Size = New System.Drawing.Size(279, 22)
        Me.cboItemGasto.TabIndex = 14
        Me.cboItemGasto.ValueMember = "Id"
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
        'DecTotalDoc
        '
        Appearance32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalDoc.Appearance = Appearance32
        Me.DecTotalDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotalDoc.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotalDoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalDoc.Location = New System.Drawing.Point(405, 71)
        Me.DecTotalDoc.Name = "DecTotalDoc"
        Me.DecTotalDoc.NullText = "0.00"
        Me.DecTotalDoc.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotalDoc.ReadOnly = True
        Me.DecTotalDoc.Size = New System.Drawing.Size(100, 22)
        Me.DecTotalDoc.TabIndex = 17
        '
        'FecEmision
        '
        Appearance33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecEmision.Appearance = Appearance33
        Me.FecEmision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecEmision.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecEmision.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecEmision.Location = New System.Drawing.Point(67, 45)
        Me.FecEmision.Name = "FecEmision"
        Me.FecEmision.Size = New System.Drawing.Size(100, 22)
        Me.FecEmision.TabIndex = 12
        '
        'DecTotalIgv
        '
        Appearance34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalIgv.Appearance = Appearance34
        Me.DecTotalIgv.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotalIgv.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotalIgv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalIgv.Location = New System.Drawing.Point(406, 44)
        Me.DecTotalIgv.Name = "DecTotalIgv"
        Me.DecTotalIgv.NullText = "0.00"
        Me.DecTotalIgv.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotalIgv.ReadOnly = True
        Me.DecTotalIgv.Size = New System.Drawing.Size(100, 22)
        Me.DecTotalIgv.TabIndex = 16
        '
        'DecTotalImponible
        '
        Appearance35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalImponible.Appearance = Appearance35
        Me.DecTotalImponible.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotalImponible.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotalImponible.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalImponible.Location = New System.Drawing.Point(405, 20)
        Me.DecTotalImponible.Name = "DecTotalImponible"
        Me.DecTotalImponible.NullText = "0.00"
        Me.DecTotalImponible.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotalImponible.Size = New System.Drawing.Size(100, 22)
        Me.DecTotalImponible.TabIndex = 15
        '
        'Etiqueta4
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance36
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(171, 48)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(68, 15)
        Me.Etiqueta4.TabIndex = 260
        Me.Etiqueta4.Text = "Tipo Cambio:"
        '
        'Etiqueta19
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta19.Appearance = Appearance37
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta19.Location = New System.Drawing.Point(16, 74)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta19.TabIndex = 262
        Me.Etiqueta19.Text = "I. Gasto:"
        '
        'decTC
        '
        Appearance38.ForeColor = System.Drawing.Color.Black
        Me.decTC.Appearance = Appearance38
        Me.decTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTC.ForeColor = System.Drawing.Color.Black
        Me.decTC.FormatString = ""
        Me.decTC.Location = New System.Drawing.Point(246, 45)
        Me.decTC.MaskInput = "{double:6.4}"
        Me.decTC.Name = "decTC"
        Me.decTC.NullText = "0.00"
        Me.decTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTC.Size = New System.Drawing.Size(100, 22)
        Me.decTC.TabIndex = 13
        '
        'Etiqueta3
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance39
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(14, 24)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta3.TabIndex = 257
        Me.Etiqueta3.Text = "Moneda:"
        '
        'cboMoneda
        '
        Appearance40.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance40
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(67, 20)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.ReadOnly = True
        Me.cboMoneda.Size = New System.Drawing.Size(100, 22)
        Me.cboMoneda.TabIndex = 10
        Me.cboMoneda.ValueMember = "Id"
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarCabecera})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(121, 30)
        '
        'AgregarCabecera
        '
        Me.AgregarCabecera.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarCabecera.Name = "AgregarCabecera"
        Me.AgregarCabecera.Size = New System.Drawing.Size(120, 26)
        Me.AgregarCabecera.Text = "Agregar"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.gridDetallePersonal)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 269)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1165, 157)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'gridDetallePersonal
        '
        Me.gridDetallePersonal.DataSource = Me.UltraDataSource3
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Appearance41.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridDetallePersonal.DisplayLayout.Appearance = Appearance41
        UltraGridColumn28.Header.VisiblePosition = 0
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 1
        UltraGridColumn29.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 2
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 3
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 4
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 5
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 6
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 7
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 8
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 9
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 11
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 10
        UltraGridColumn42.Hidden = True
        Appearance42.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn43.CellAppearance = Appearance42
        UltraGridColumn43.Header.VisiblePosition = 12
        UltraGridColumn43.Hidden = True
        Appearance43.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn44.CellAppearance = Appearance43
        Appearance44.TextHAlignAsString = "Right"
        UltraGridColumn44.Header.Appearance = Appearance44
        UltraGridColumn44.Header.VisiblePosition = 20
        UltraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn44.Width = 90
        UltraGridColumn45.Header.Caption = "Mon."
        UltraGridColumn45.Header.VisiblePosition = 19
        UltraGridColumn45.Width = 37
        UltraGridColumn46.Header.Caption = "Periodo"
        UltraGridColumn46.Header.VisiblePosition = 13
        UltraGridColumn46.Width = 53
        UltraGridColumn47.Header.VisiblePosition = 21
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 14
        UltraGridColumn48.Width = 56
        UltraGridColumn49.Header.VisiblePosition = 23
        UltraGridColumn50.Header.VisiblePosition = 24
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 25
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 22
        UltraGridColumn53.Header.Caption = "Tipo"
        UltraGridColumn53.Header.VisiblePosition = 16
        UltraGridColumn53.Width = 38
        UltraGridColumn54.Header.VisiblePosition = 17
        UltraGridColumn54.Width = 73
        UltraGridColumn62.Header.VisiblePosition = 18
        UltraGridColumn62.Width = 607
        UltraGridColumn63.Header.VisiblePosition = 26
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 15
        UltraGridColumn64.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn64.Width = 70
        UltraGridColumn65.Header.VisiblePosition = 27
        UltraGridColumn65.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn28, UltraGridColumn29, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65})
        Me.gridDetallePersonal.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridDetallePersonal.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridDetallePersonal.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance45.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.gridDetallePersonal.DisplayLayout.GroupByBox.Appearance = Appearance45
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridDetallePersonal.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance46
        Me.gridDetallePersonal.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridDetallePersonal.DisplayLayout.GroupByBox.Hidden = True
        Appearance47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance47.BackColor2 = System.Drawing.SystemColors.Control
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridDetallePersonal.DisplayLayout.GroupByBox.PromptAppearance = Appearance47
        Me.gridDetallePersonal.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDetallePersonal.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridDetallePersonal.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDetallePersonal.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDetallePersonal.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridDetallePersonal.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridDetallePersonal.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDetallePersonal.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDetallePersonal.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridDetallePersonal.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDetallePersonal.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance48.BorderColor = System.Drawing.Color.Silver
        Me.gridDetallePersonal.DisplayLayout.Override.RowAppearance = Appearance48
        Me.gridDetallePersonal.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDetallePersonal.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridDetallePersonal.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridDetallePersonal.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridDetallePersonal.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridDetallePersonal.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.gridDetallePersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDetallePersonal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDetallePersonal.Location = New System.Drawing.Point(2, 2)
        Me.gridDetallePersonal.Name = "gridDetallePersonal"
        Me.gridDetallePersonal.Size = New System.Drawing.Size(1161, 153)
        Me.gridDetallePersonal.TabIndex = 36
        Me.gridDetallePersonal.Text = "Grilla2"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(384, 179)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 24
        Me.ugb_Espera.Visible = False
        '
        'frm_DocumentosXRendir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1165, 426)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.Agrupacion2)
        Me.Controls.Add(Me.Agrupacion1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_DocumentosXRendir"
        Me.Text = "Documentos Por Rendir"
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.GridAgregado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAgregado.ResumeLayout(False)
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        Me.Año1.ResumeLayout(False)
        Me.Año1.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.FecAplicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMesAplicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosaAplicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecSinIgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.DecNoGravada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMesDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTotalDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecEmision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTotalIgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTotalImponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.gridDetallePersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents MenuAgregado As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarAnalisis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents cboItemGasto As ISL.Controles.Combo
    Friend WithEvents FecEmision As ISL.Controles.Fecha
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents decTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents DecTotalDoc As ISL.Controles.NumeroDecimal
    Friend WithEvents DecTotalIgv As ISL.Controles.NumeroDecimal
    Friend WithEvents DecTotalImponible As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cboMesDocumento As ISL.Controles.Combo
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents DecIGV As ISL.Controles.NumeroDecimal
    Friend WithEvents DecSinIgv As ISL.Controles.NumeroDecimal
    Friend WithEvents DecImporte As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosaAplicacion As ISL.Controles.Texto
    Friend WithEvents AgregarCabecera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero1 As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents cboMesAplicacion As ISL.Controles.Combo
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents FecAplicacion As ISL.Controles.Fecha
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents DecNoGravada As ISL.Controles.NumeroDecimal
    Friend WithEvents GridAgregado As ISL.Controles.Grilla
    Friend WithEvents gridDetallePersonal As ISL.Controles.Grilla
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ugb_Espera As ISL.Win.Espere

End Class
