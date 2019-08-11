<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteRecorrido
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
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Motriz")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModeloFuncional")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModeloFuncional")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModelo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modelo")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaPropietaria")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmpresaPropietaria")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoCombustible")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConfiguracionVehicularMTC")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioFabricacion")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroSerieMotor")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Color")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ancho")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Largo")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Alto")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tara")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cubicaje")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroEjes")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroNeumaticos")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroNeumaticosRepuesto")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Odometro")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Horometro")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("monto")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterialCombustible")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroSerieChasis")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConfiguracionNeumaticos")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ConfiguracionNeumaticos")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CapacidadTanque")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlota")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEstado")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaAntigua")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Motriz")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModeloFuncional")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ModeloFuncional")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModelo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modelo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaPropietaria")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EmpresaPropietaria")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoCombustible")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConfiguracionVehicularMTC")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AnioFabricacion")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroSerieMotor")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Color")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ancho")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Largo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Alto")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tara")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cubicaje")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroEjes")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroNeumaticos")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroNeumaticosRepuesto")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroMTC")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Odometro")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Horometro")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("monto")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterialCombustible")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroSerieChasis")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConfiguracionNeumaticos")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ConfiguracionNeumaticos")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CapacidadTanque")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlota")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEstado")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlacaAntigua")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Motriz")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModeloFuncional")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModeloFuncional")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModelo")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modelo")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaPropietaria")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmpresaPropietaria")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoCombustible")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConfiguracionVehicularMTC")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioFabricacion")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroSerieMotor")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Color")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ancho")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Largo")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Alto")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tara")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cubicaje")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroEjes")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroNeumaticos")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroNeumaticosRepuesto")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Odometro")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Horometro")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("monto")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterialCombustible")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroSerieChasis")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConfiguracionNeumaticos")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ConfiguracionNeumaticos")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CapacidadTanque")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlota")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEstado")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaAntigua")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOperacion")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOperacion")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOperacion")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoViaje")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmIdeal")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmDiferencia")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmMuerto")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmReal")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoOperacion")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOperacion")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOperacion")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoViaje")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoViaje")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaViaje")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmIdeal")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmDiferencia")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmMuerto")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmReal")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.griVehiculo_T = New ISL.Controles.Grilla(Me.components)
        Me.odVehiculo = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.griVehiculo_C = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Espere1 = New ISL.Win.Espere
        Me.Gri_Recorridos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.odReporteRecorrido = New ISL.Controles.OrigenDatos(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraExpandableGroupBox7 = New Infragistics.Win.Misc.UltraExpandableGroupBox
        Me.UltraExpandableGroupBoxPanel8 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
        Me.ConjuntoTabs = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.rfHasta = New System.Windows.Forms.DateTimePicker
        Me.rfDesde = New System.Windows.Forms.DateTimePicker
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.TabReporteCombustible = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griVehiculo_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griVehiculo_C, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Gri_Recorridos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odReporteRecorrido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox7.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel8.SuspendLayout()
        CType(Me.ConjuntoTabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConjuntoTabs.SuspendLayout()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.TabReporteCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabReporteCombustible.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griVehiculo_T)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(274, 130)
        '
        'griVehiculo_T
        '
        Me.griVehiculo_T.DataSource = Me.odVehiculo
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn1.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1.Width = 44
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn4.CellAppearance = Appearance6
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 155
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 12
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 13
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 7
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 9
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 10
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 11
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 30
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 31
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 32
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 33
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 34
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 35
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 36
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 37
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 38
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 39
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 40
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 41
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 42
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 43
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 44
        UltraGridColumn45.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45})
        Me.griVehiculo_T.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griVehiculo_T.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVehiculo_T.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griVehiculo_T.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griVehiculo_T.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griVehiculo_T.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griVehiculo_T.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griVehiculo_T.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griVehiculo_T.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVehiculo_T.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griVehiculo_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griVehiculo_T.Location = New System.Drawing.Point(0, 0)
        Me.griVehiculo_T.Name = "griVehiculo_T"
        Me.griVehiculo_T.Size = New System.Drawing.Size(274, 130)
        Me.griVehiculo_T.TabIndex = 5
        '
        'odVehiculo
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        Me.odVehiculo.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45})
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griVehiculo_C)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(274, 130)
        '
        'griVehiculo_C
        '
        Me.griVehiculo_C.DataSource = Me.odVehiculo
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn46.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        UltraGridColumn46.Header.VisiblePosition = 0
        UltraGridColumn46.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn46.Width = 44
        UltraGridColumn47.Header.VisiblePosition = 1
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 2
        UltraGridColumn48.Hidden = True
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn49.CellAppearance = Appearance8
        UltraGridColumn49.Header.VisiblePosition = 3
        UltraGridColumn49.Width = 155
        UltraGridColumn50.Header.VisiblePosition = 4
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 5
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 6
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 12
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 13
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 7
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 8
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 9
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 10
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 14
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 15
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 11
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 16
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 17
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 18
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 19
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 20
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 21
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 22
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 23
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 24
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 25
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 26
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 27
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 28
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 29
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 30
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 31
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 32
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 33
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 34
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 35
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 36
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 37
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 38
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 39
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 40
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 41
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 42
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 43
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 44
        UltraGridColumn90.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90})
        Me.griVehiculo_C.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griVehiculo_C.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVehiculo_C.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griVehiculo_C.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griVehiculo_C.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griVehiculo_C.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griVehiculo_C.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griVehiculo_C.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griVehiculo_C.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVehiculo_C.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griVehiculo_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griVehiculo_C.Location = New System.Drawing.Point(0, 0)
        Me.griVehiculo_C.Name = "griVehiculo_C"
        Me.griVehiculo_C.Size = New System.Drawing.Size(274, 130)
        Me.griVehiculo_C.TabIndex = 6
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Espere1)
        Me.UltraTabPageControl1.Controls.Add(Me.Gri_Recorridos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(997, 268)
        '
        'Espere1
        '
        Me.Espere1.Location = New System.Drawing.Point(300, 30)
        Me.Espere1.Name = "Espere1"
        Me.Espere1.Size = New System.Drawing.Size(397, 68)
        Me.Espere1.TabIndex = 808
        Me.Espere1.Visible = False
        '
        'Gri_Recorridos
        '
        Me.Gri_Recorridos.DataSource = Me.odReporteRecorrido
        UltraGridColumn91.Header.VisiblePosition = 0
        UltraGridColumn92.Header.VisiblePosition = 1
        UltraGridColumn93.Header.VisiblePosition = 2
        UltraGridColumn93.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn94.Header.VisiblePosition = 3
        UltraGridColumn95.Header.VisiblePosition = 4
        UltraGridColumn96.Header.VisiblePosition = 5
        UltraGridColumn96.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn97.Header.VisiblePosition = 6
        UltraGridColumn97.Width = 71
        UltraGridColumn98.Header.VisiblePosition = 7
        UltraGridColumn98.Width = 71
        UltraGridColumn99.Header.VisiblePosition = 8
        UltraGridColumn100.Header.VisiblePosition = 9
        UltraGridColumn101.Header.VisiblePosition = 10
        UltraGridColumn102.Header.VisiblePosition = 11
        UltraGridColumn103.Header.VisiblePosition = 12
        UltraGridColumn104.Header.VisiblePosition = 13
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        UltraGridColumn105.CellAppearance = Appearance9
        UltraGridColumn105.Header.VisiblePosition = 17
        UltraGridColumn106.Header.VisiblePosition = 14
        UltraGridColumn107.Header.VisiblePosition = 15
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        UltraGridColumn108.CellAppearance = Appearance10
        UltraGridColumn108.Header.VisiblePosition = 16
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108})
        Me.Gri_Recorridos.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.Gri_Recorridos.DisplayLayout.MaxColScrollRegions = 1
        Me.Gri_Recorridos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.Gri_Recorridos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Gri_Recorridos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Gri_Recorridos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Gri_Recorridos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Gri_Recorridos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Gri_Recorridos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Gri_Recorridos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Gri_Recorridos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.Gri_Recorridos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.Gri_Recorridos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Gri_Recorridos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gri_Recorridos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gri_Recorridos.Location = New System.Drawing.Point(0, 0)
        Me.Gri_Recorridos.Name = "Gri_Recorridos"
        Me.Gri_Recorridos.Size = New System.Drawing.Size(997, 268)
        Me.Gri_Recorridos.TabIndex = 803
        Me.Gri_Recorridos.TabStop = False
        '
        'odReporteRecorrido
        '
        Me.odReporteRecorrido.Band.Columns.AddRange(New Object() {UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63})
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(256, 182)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 805
        Me.ugb_Espera.Visible = False
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraExpandableGroupBox7)
        Me.UltraGroupBox1.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(999, 164)
        Me.UltraGroupBox1.TabIndex = 806
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBox7
        '
        Me.UltraExpandableGroupBox7.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox7.ContentAreaAppearance = Appearance12
        Me.UltraExpandableGroupBox7.Controls.Add(Me.UltraExpandableGroupBoxPanel8)
        Me.UltraExpandableGroupBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox7.ExpandedSize = New System.Drawing.Size(299, 162)
        Me.UltraExpandableGroupBox7.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox7.Location = New System.Drawing.Point(192, 0)
        Me.UltraExpandableGroupBox7.Name = "UltraExpandableGroupBox7"
        Me.UltraExpandableGroupBox7.Size = New System.Drawing.Size(299, 162)
        Me.UltraExpandableGroupBox7.TabIndex = 806
        Me.UltraExpandableGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel8
        '
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.ConjuntoTabs)
        Me.UltraExpandableGroupBoxPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel8.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel8.Name = "UltraExpandableGroupBoxPanel8"
        Me.UltraExpandableGroupBoxPanel8.Size = New System.Drawing.Size(278, 156)
        Me.UltraExpandableGroupBoxPanel8.TabIndex = 0
        '
        'ConjuntoTabs
        '
        Me.ConjuntoTabs.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ConjuntoTabs.Controls.Add(Me.UltraTabPageControl2)
        Me.ConjuntoTabs.Controls.Add(Me.UltraTabPageControl3)
        Me.ConjuntoTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConjuntoTabs.Location = New System.Drawing.Point(0, 0)
        Me.ConjuntoTabs.Name = "ConjuntoTabs"
        Me.ConjuntoTabs.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ConjuntoTabs.Size = New System.Drawing.Size(278, 156)
        Me.ConjuntoTabs.TabIndex = 807
        Me.ConjuntoTabs.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopRight
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Tractos"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Carretas"
        Me.ConjuntoTabs.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(274, 130)
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption
        Appearance7.BackColorAlpha = Infragistics.Win.Alpha.UseAlphaLevel
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance7
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(190, 162)
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(2, 0)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(190, 162)
        Me.UltraExpandableGroupBox2.TabIndex = 30
        Me.UltraExpandableGroupBox2.Text = "Fechas"
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Label4)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Label3)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.rfHasta)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.rfDesde)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(167, 156)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.Location = New System.Drawing.Point(21, 103)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(130, 36)
        Me.UltraLabel1.TabIndex = 271
        Me.UltraLabel1.Text = """Rango de fechas de la Operación"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 270
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Desde:"
        '
        'rfHasta
        '
        Me.rfHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfHasta.Location = New System.Drawing.Point(53, 53)
        Me.rfHasta.Name = "rfHasta"
        Me.rfHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfHasta.TabIndex = 269
        '
        'rfDesde
        '
        Me.rfDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfDesde.Location = New System.Drawing.Point(53, 19)
        Me.rfDesde.Name = "rfDesde"
        Me.rfDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfDesde.TabIndex = 268
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(997, 268)
        '
        'TabReporteCombustible
        '
        Me.TabReporteCombustible.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.TabReporteCombustible.Controls.Add(Me.UltraTabPageControl1)
        Me.TabReporteCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabReporteCombustible.Location = New System.Drawing.Point(0, 164)
        Me.TabReporteCombustible.Name = "TabReporteCombustible"
        Me.TabReporteCombustible.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.TabReporteCombustible.Size = New System.Drawing.Size(999, 291)
        Me.TabReporteCombustible.TabIndex = 807
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Información"
        Me.TabReporteCombustible.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        Me.TabReporteCombustible.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'frm_ReporteRecorrido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 455)
        Me.Controls.Add(Me.TabReporteCombustible)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Name = "frm_ReporteRecorrido"
        Me.Text = "Reporte de recorridos"
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griVehiculo_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griVehiculo_C, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Gri_Recorridos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odReporteRecorrido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox7.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel8.ResumeLayout(False)
        CType(Me.ConjuntoTabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConjuntoTabs.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        CType(Me.TabReporteCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabReporteCombustible.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraExpandableGroupBox7 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel8 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rfHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gri_Recorridos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents TabReporteCombustible As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Espere1 As ISL.Win.Espere
    Friend WithEvents odVehiculo As ISL.Controles.OrigenDatos
    Friend WithEvents ConjuntoTabs As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griVehiculo_T As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griVehiculo_C As ISL.Controles.Grilla
    Friend WithEvents odReporteRecorrido As ISL.Controles.OrigenDatos
End Class
