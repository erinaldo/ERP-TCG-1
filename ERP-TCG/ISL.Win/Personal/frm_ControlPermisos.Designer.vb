<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ControlPermisos
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
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdJefeArea")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdJefeAdministracion")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngreso")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JefeArea")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JefeAdministracion")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasPermiso")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasExcedidos")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Motivo")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPermiso")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndConfirmaSalida")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaConfirmaSalida")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ControlPermisos))
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndConfirmaIngreso")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaConfirmaIngreso")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPapeleta")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSituacionAdministrativa")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOcupacion")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocupacion")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVenta")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioVta")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinVta")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVendidos")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalDias")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinVtaVacaciones")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioVtaVacaciones")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuardarSalidaConfirmada", 0)
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuardarIngresoConfirmado", 1)
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup0", 962923485)
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup1", 962923486)
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdJefeArea")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdJefeAdministracion")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaSalida")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaIngreso")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("JefeArea")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("JefeAdministracion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasPermiso")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasExcedidos")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Motivo")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPermiso")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndConfirmaSalida")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaConfirmaSalida")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndConfirmaIngreso")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaConfirmaIngreso")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPapeleta")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSituacionAdministrativa")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOcupacion")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ocupacion")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndVenta")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicioVta")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFinVta")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVendidos")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalDias")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFinVtaVacaciones")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicioVtaVacaciones")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdJefeArea")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdJefeAdministracion")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngreso")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JefeArea")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JefeAdministracion")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasPermiso")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasExcedidos")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Motivo")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPermiso")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndConfirmaSalida")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaConfirmaSalida")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndConfirmaIngreso")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaConfirmaIngreso")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPapeleta")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSituacionAdministrativa")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOcupacion")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocupacion")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVenta")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioVta")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinVta")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVendidos")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalDias")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinVtaVacaciones")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioVtaVacaciones")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdJefeArea")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdJefeAdministracion")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSalida")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngreso")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JefeArea")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JefeAdministracion")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasPermiso")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasExcedidos")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Motivo")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPermiso")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndConfirmaSalida")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaConfirmaSalida")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndConfirmaIngreso")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaConfirmaIngreso")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPapeleta")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSituacionAdministrativa")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOcupacion")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocupacion")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVenta")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioVta")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinVta")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVendidos")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalDias")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinVtaVacaciones")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioVtaVacaciones")
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
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.cboTrabajadores = New ISL.Controles.Combo(Me.components)
        Me.cboJefeArea = New ISL.Controles.Combo(Me.components)
        Me.cboJefeAdministrador = New ISL.Controles.Combo(Me.components)
        Me.cboSituacionAdministrativa = New ISL.Controles.Combo(Me.components)
        Me.tabLista = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.griControlPermisos = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiInsertar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiActualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.odCtrlPermisos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.agrOperaciones = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFilaActualizada = New ISL.Controles.Colores(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Colores1 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores3 = New ISL.Controles.Colores(Me.components)
        Me.Colores4 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.R = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores2 = New ISL.Controles.Colores(Me.components)
        Me.ColoresExcedidos = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.ckbMostrarTodos = New System.Windows.Forms.CheckBox()
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.tabMantenimiento = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.griDetalles = New ISL.Controles.Grilla(Me.components)
        Me.tspControlPermiso = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitar = New System.Windows.Forms.ToolStripButton()
        Me.agrProcesoNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.chkGoce = New System.Windows.Forms.CheckBox()
        Me.chkPapeleta = New System.Windows.Forms.CheckBox()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griPermisosHistorial = New ISL.Controles.Grilla(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.chbVenta = New System.Windows.Forms.CheckBox()
        Me.fecFinVta = New System.Windows.Forms.DateTimePicker()
        Me.fecInicioVta = New System.Windows.Forms.DateTimePicker()
        Me.txtOcupacion = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.chkConfirmarIngreso = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkConfirmarSalida = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFecha = New System.Windows.Forms.DateTimePicker()
        Me.fecIngresoConfirmado = New System.Windows.Forms.DateTimePicker()
        Me.fecIngreso = New System.Windows.Forms.DateTimePicker()
        Me.fecSalidaConfirmada = New System.Windows.Forms.DateTimePicker()
        Me.fecSalida = New System.Windows.Forms.DateTimePicker()
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.agrDatosBasicos = New ISL.Controles.Agrupacion(Me.components)
        Me.FotoTrabajador = New System.Windows.Forms.PictureBox()
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.fecFechaIngreso = New ISL.Controles.Fecha(Me.components)
        Me.chkDisponible = New ISL.Controles.Chequear(Me.components)
        Me.txtCargo = New ISL.Controles.Texto(Me.components)
        Me.etiFechaIngreso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCargo = New ISL.Controles.Etiqueta(Me.components)
        Me.txtArea = New ISL.Controles.Texto(Me.components)
        Me.etiArea = New ISL.Controles.Etiqueta(Me.components)
        Me.ficCtrlPermisos = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCentroBus = New ISL.Controles.Combo(Me.components)
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboJefeArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboJefeAdministrador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSituacionAdministrativa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLista.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.griControlPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odCtrlPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOperaciones.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.ColorFilaActualizada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresExcedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        Me.tabMantenimiento.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.griDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspControlPermiso.SuspendLayout()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoNegocio.SuspendLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griPermisosHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOcupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkConfirmarIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkConfirmarSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBasicos.SuspendLayout()
        CType(Me.FotoTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficCtrlPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCtrlPermisos.SuspendLayout()
        CType(Me.cboCentroBus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTrabajadores
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Appearance = Appearance1
        Me.cboTrabajadores.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajadores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadores.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Location = New System.Drawing.Point(84, 43)
        Me.cboTrabajadores.Name = "cboTrabajadores"
        Me.cboTrabajadores.Size = New System.Drawing.Size(385, 22)
        Me.cboTrabajadores.TabIndex = 1
        Me.cboTrabajadores.ValueMember = "Id"
        '
        'cboJefeArea
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboJefeArea.Appearance = Appearance2
        Me.cboJefeArea.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboJefeArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboJefeArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboJefeArea.ForeColor = System.Drawing.Color.Black
        Me.cboJefeArea.Location = New System.Drawing.Point(84, 250)
        Me.cboJefeArea.Name = "cboJefeArea"
        Me.cboJefeArea.Size = New System.Drawing.Size(385, 22)
        Me.cboJefeArea.TabIndex = 17
        Me.cboJefeArea.ValueMember = "Id"
        '
        'cboJefeAdministrador
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.cboJefeAdministrador.Appearance = Appearance3
        Me.cboJefeAdministrador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboJefeAdministrador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboJefeAdministrador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboJefeAdministrador.ForeColor = System.Drawing.Color.Black
        Me.cboJefeAdministrador.Location = New System.Drawing.Point(84, 277)
        Me.cboJefeAdministrador.Name = "cboJefeAdministrador"
        Me.cboJefeAdministrador.Size = New System.Drawing.Size(385, 22)
        Me.cboJefeAdministrador.TabIndex = 18
        Me.cboJefeAdministrador.ValueMember = "Id"
        '
        'cboSituacionAdministrativa
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboSituacionAdministrativa.Appearance = Appearance4
        Me.cboSituacionAdministrativa.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboSituacionAdministrativa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboSituacionAdministrativa.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboSituacionAdministrativa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSituacionAdministrativa.ForeColor = System.Drawing.Color.Black
        Me.cboSituacionAdministrativa.Location = New System.Drawing.Point(84, 149)
        Me.cboSituacionAdministrativa.Name = "cboSituacionAdministrativa"
        Me.cboSituacionAdministrativa.Size = New System.Drawing.Size(385, 22)
        Me.cboSituacionAdministrativa.TabIndex = 13
        Me.cboSituacionAdministrativa.ValueMember = "Id"
        '
        'tabLista
        '
        Me.tabLista.Controls.Add(Me.Agrupacion1)
        Me.tabLista.Controls.Add(Me.agrOperaciones)
        Me.tabLista.Location = New System.Drawing.Point(1, 22)
        Me.tabLista.Name = "tabLista"
        Me.tabLista.Size = New System.Drawing.Size(982, 638)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.griControlPermisos)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 77)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(982, 561)
        Me.Agrupacion1.TabIndex = 10
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griControlPermisos
        '
        Me.griControlPermisos.ContextMenuStrip = Me.MenuContextual1
        Me.griControlPermisos.DataSource = Me.odCtrlPermisos
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 3
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 4
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Format = "dd/MM/yyyy"
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn35.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 36)
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn36.Format = "dd/MM/yyyy hh:mm tt"
        UltraGridColumn36.Header.Caption = "Salida"
        UltraGridColumn36.Header.VisiblePosition = 8
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn36.RowLayoutColumnInfo.ParentGroupKey = "NewGroup0"
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(120, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn37.Format = "dd/MM/yyyy hh:mm tt"
        UltraGridColumn37.Header.Caption = "Ingreso"
        UltraGridColumn37.Header.VisiblePosition = 9
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn37.RowLayoutColumnInfo.ParentGroupKey = "NewGroup0"
        UltraGridColumn37.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(122, 0)
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn38.Header.VisiblePosition = 6
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(226, 0)
        UltraGridColumn38.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 36)
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn38.Width = 217
        UltraGridColumn39.Header.VisiblePosition = 18
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(172, 0)
        UltraGridColumn39.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 36)
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn39.Width = 154
        UltraGridColumn40.Header.VisiblePosition = 19
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(157, 0)
        UltraGridColumn40.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 36)
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn40.Width = 141
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance5
        UltraGridColumn41.Header.VisiblePosition = 11
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance6
        UltraGridColumn42.Header.VisiblePosition = 15
        UltraGridColumn42.MaskInput = "{LOC}nn,nnn,nnn"
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn42.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 36)
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn42.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn43.Header.VisiblePosition = 20
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 36)
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn43.Width = 189
        UltraGridColumn44.Header.VisiblePosition = 7
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 36)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn44.Width = 152
        UltraGridColumn45.Header.VisiblePosition = 17
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(147, 0)
        UltraGridColumn45.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 36)
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn45.Width = 141
        UltraGridColumn46.Header.VisiblePosition = 21
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 22
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn48.Header.Caption = "ConfirmaSalida"
        UltraGridColumn48.Header.VisiblePosition = 10
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn48.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn48.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(75, 0)
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn49.CellAppearance = Appearance7
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        UltraGridColumn49.CellButtonAppearance = Appearance8
        UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn49.Header.Caption = "Salida"
        UltraGridColumn49.Header.VisiblePosition = 12
        UltraGridColumn49.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn49.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn49.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn49.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn49.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(142, 0)
        UltraGridColumn49.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn49.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn49.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        UltraGridColumn50.CellButtonAppearance = Appearance9
        UltraGridColumn50.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn50.Header.Caption = "ConfirmaIngreso"
        UltraGridColumn50.Header.VisiblePosition = 13
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn50.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn50.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        Appearance10.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn51.CellAppearance = Appearance10
        Appearance11.Image = CType(resources.GetObject("Appearance11.Image"), Object)
        UltraGridColumn51.CellButtonAppearance = Appearance11
        UltraGridColumn51.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn51.Header.Caption = "Ingreso"
        UltraGridColumn51.Header.VisiblePosition = 14
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn51.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn51.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(137, 0)
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn52.Header.VisiblePosition = 23
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 24
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.Caption = "Papeleta"
        UltraGridColumn54.Header.VisiblePosition = 16
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(49, 0)
        UltraGridColumn54.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 36)
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn54.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn54.Width = 42
        UltraGridColumn55.Header.VisiblePosition = 25
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 26
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 27
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 28
        UltraGridColumn58.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 29
        UltraGridColumn1.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 30
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn4.Header.VisiblePosition = 31
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn7.Header.VisiblePosition = 32
        UltraGridColumn7.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 33
        UltraGridColumn104.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 34
        UltraGridColumn100.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 35
        UltraGridColumn106.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 36
        UltraGridColumn109.Hidden = True
        Appearance12.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Appearance12.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn112.CellAppearance = Appearance12
        Appearance13.Image = CType(resources.GetObject("Appearance13.Image"), Object)
        Appearance13.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn112.CellButtonAppearance = Appearance13
        UltraGridColumn112.Header.Caption = "Guardar"
        UltraGridColumn112.Header.VisiblePosition = 37
        UltraGridColumn112.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn112.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn112.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn112.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn112.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(48, 0)
        UltraGridColumn112.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn112.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn112.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        Appearance14.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Appearance14.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn113.CellAppearance = Appearance14
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Appearance15.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn113.CellButtonAppearance = Appearance15
        UltraGridColumn113.Header.Caption = "Guardar"
        UltraGridColumn113.Header.VisiblePosition = 38
        UltraGridColumn113.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn113.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn113.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn113.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn113.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(47, 0)
        UltraGridColumn113.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn113.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn113.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn1, UltraGridColumn3, UltraGridColumn4, UltraGridColumn7, UltraGridColumn104, UltraGridColumn100, UltraGridColumn106, UltraGridColumn109, UltraGridColumn112, UltraGridColumn113})
        UltraGridGroup1.Header.Caption = "Fechas Solicitadas"
        UltraGridGroup1.Key = "NewGroup0"
        UltraGridGroup1.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup1.RowLayoutGroupInfo.OriginX = 6
        UltraGridGroup1.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup1.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup1.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup2.Header.Caption = "Fechas Confirmadas"
        UltraGridGroup2.Key = "NewGroup1"
        UltraGridGroup2.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup2.RowLayoutGroupInfo.OriginX = 10
        UltraGridGroup2.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup2.RowLayoutGroupInfo.SpanX = 12
        UltraGridGroup2.RowLayoutGroupInfo.SpanY = 3
        UltraGridBand1.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2})
        UltraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        Me.griControlPermisos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griControlPermisos.DisplayLayout.MaxColScrollRegions = 1
        Me.griControlPermisos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griControlPermisos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griControlPermisos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griControlPermisos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griControlPermisos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griControlPermisos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griControlPermisos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griControlPermisos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griControlPermisos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griControlPermisos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griControlPermisos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griControlPermisos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griControlPermisos.Location = New System.Drawing.Point(3, 3)
        Me.griControlPermisos.Name = "griControlPermisos"
        Me.griControlPermisos.Size = New System.Drawing.Size(976, 555)
        Me.griControlPermisos.TabIndex = 10
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiInsertar, Me.tsmiActualizar, Me.tsmiEliminar})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 70)
        '
        'tsmiInsertar
        '
        Me.tsmiInsertar.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.tsmiInsertar.Name = "tsmiInsertar"
        Me.tsmiInsertar.Size = New System.Drawing.Size(120, 22)
        Me.tsmiInsertar.Text = "Insertar"
        '
        'tsmiActualizar
        '
        Me.tsmiActualizar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsmiActualizar.Name = "tsmiActualizar"
        Me.tsmiActualizar.Size = New System.Drawing.Size(120, 22)
        Me.tsmiActualizar.Text = "Actualizar"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(120, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        '
        'odCtrlPermisos
        '
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn7.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Date)
        UltraDataColumn12.DataType = GetType(Integer)
        UltraDataColumn13.DataType = GetType(Integer)
        UltraDataColumn19.DataType = GetType(Boolean)
        UltraDataColumn20.DataType = GetType(Date)
        UltraDataColumn21.DataType = GetType(Boolean)
        UltraDataColumn22.DataType = GetType(Date)
        UltraDataColumn25.DataType = GetType(Boolean)
        UltraDataColumn30.DataType = GetType(Boolean)
        UltraDataColumn31.DataType = GetType(Date)
        UltraDataColumn32.DataType = GetType(Date)
        UltraDataColumn33.DataType = GetType(Short)
        UltraDataColumn35.DataType = GetType(Long)
        UltraDataColumn36.DataType = GetType(Date)
        UltraDataColumn37.DataType = GetType(Date)
        Me.odCtrlPermisos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'agrOperaciones
        '
        Me.agrOperaciones.Controls.Add(Me.UltraGroupBox2)
        Me.agrOperaciones.Controls.Add(Me.UltraGroupBox1)
        Me.agrOperaciones.Controls.Add(Me.Agrupacion2)
        Me.agrOperaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrOperaciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOperaciones.ForeColor = System.Drawing.Color.Black
        Me.agrOperaciones.Location = New System.Drawing.Point(0, 0)
        Me.agrOperaciones.Name = "agrOperaciones"
        Me.agrOperaciones.Size = New System.Drawing.Size(982, 77)
        Me.agrOperaciones.TabIndex = 9
        Me.agrOperaciones.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta8)
        Me.UltraGroupBox2.Controls.Add(Me.ColorFilaActualizada)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(652, 9)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(148, 64)
        Me.UltraGroupBox2.TabIndex = 27
        Me.UltraGroupBox2.Text = "Estado Registros"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta8
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Appearance = Appearance16
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(6, 28)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(81, 15)
        Me.Etiqueta8.TabIndex = 22
        Me.Etiqueta8.Text = "Fila Actualizada"
        '
        'ColorFilaActualizada
        '
        Me.ColorFilaActualizada.Color = System.Drawing.Color.PaleTurquoise
        Me.ColorFilaActualizada.Location = New System.Drawing.Point(91, 22)
        Me.ColorFilaActualizada.Name = "ColorFilaActualizada"
        Me.ColorFilaActualizada.Size = New System.Drawing.Size(48, 22)
        Me.ColorFilaActualizada.TabIndex = 21
        Me.ColorFilaActualizada.Text = "PaleTurquoise"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Colores1)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta15)
        Me.UltraGroupBox1.Controls.Add(Me.Colores3)
        Me.UltraGroupBox1.Controls.Add(Me.Colores4)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta13)
        Me.UltraGroupBox1.Controls.Add(Me.R)
        Me.UltraGroupBox1.Controls.Add(Me.Colores2)
        Me.UltraGroupBox1.Controls.Add(Me.ColoresExcedidos)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta12)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta11)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(280, 8)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(366, 65)
        Me.UltraGroupBox1.TabIndex = 26
        Me.UltraGroupBox1.Text = "Alertas"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Colores1
        '
        Me.Colores1.Color = System.Drawing.Color.LightSteelBlue
        Me.Colores1.Location = New System.Drawing.Point(80, 37)
        Me.Colores1.Name = "Colores1"
        Me.Colores1.Size = New System.Drawing.Size(43, 22)
        Me.Colores1.TabIndex = 16
        Me.Colores1.Text = "LightSteelBlue"
        '
        'Etiqueta15
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Appearance = Appearance17
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(127, 16)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(73, 15)
        Me.Etiqueta15.TabIndex = 25
        Me.Etiqueta15.Text = "Llega Mañana"
        '
        'Colores3
        '
        Me.Colores3.Color = System.Drawing.Color.Gainsboro
        Me.Colores3.Location = New System.Drawing.Point(315, 13)
        Me.Colores3.Name = "Colores3"
        Me.Colores3.Size = New System.Drawing.Size(43, 22)
        Me.Colores3.TabIndex = 20
        Me.Colores3.Text = "Gainsboro"
        '
        'Colores4
        '
        Me.Colores4.Color = System.Drawing.Color.Khaki
        Me.Colores4.Location = New System.Drawing.Point(201, 13)
        Me.Colores4.Name = "Colores4"
        Me.Colores4.Size = New System.Drawing.Size(43, 22)
        Me.Colores4.TabIndex = 24
        Me.Colores4.Text = "Khaki"
        '
        'Etiqueta13
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Appearance = Appearance18
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(250, 16)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta13.TabIndex = 21
        Me.Etiqueta13.Text = "De Permiso"
        '
        'R
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.R.Appearance = Appearance19
        Me.R.AutoSize = True
        Me.R.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R.ForeColor = System.Drawing.Color.Black
        Me.R.Location = New System.Drawing.Point(25, 17)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(54, 15)
        Me.R.TabIndex = 4
        Me.R.Text = "Excedidos"
        '
        'Colores2
        '
        Me.Colores2.Color = System.Drawing.Color.LightGreen
        Me.Colores2.Location = New System.Drawing.Point(201, 37)
        Me.Colores2.Name = "Colores2"
        Me.Colores2.Size = New System.Drawing.Size(43, 22)
        Me.Colores2.TabIndex = 18
        Me.Colores2.Text = "LightGreen"
        '
        'ColoresExcedidos
        '
        Me.ColoresExcedidos.Color = System.Drawing.Color.Salmon
        Me.ColoresExcedidos.Location = New System.Drawing.Point(80, 13)
        Me.ColoresExcedidos.Name = "ColoresExcedidos"
        Me.ColoresExcedidos.Size = New System.Drawing.Size(43, 22)
        Me.ColoresExcedidos.TabIndex = 2
        Me.ColoresExcedidos.Text = "Salmon"
        '
        'Etiqueta12
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Appearance = Appearance20
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(141, 43)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(59, 15)
        Me.Etiqueta12.TabIndex = 19
        Me.Etiqueta12.Text = "Llegan hoy"
        '
        'Etiqueta11
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Appearance = Appearance21
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(5, 42)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(74, 15)
        Me.Etiqueta11.TabIndex = 17
        Me.Etiqueta11.Text = "Salen Mañana"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.cboCentroBus)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion2.Controls.Add(Me.ckbMostrarTodos)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta50)
        Me.Agrupacion2.Controls.Add(Me.fecDesde)
        Me.Agrupacion2.Controls.Add(Me.fecHasta)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(6, 8)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(269, 65)
        Me.Agrupacion2.TabIndex = 23
        Me.Agrupacion2.Text = "     Fechas/Todos"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ckbMostrarTodos
        '
        Me.ckbMostrarTodos.AutoSize = True
        Me.ckbMostrarTodos.Location = New System.Drawing.Point(6, 1)
        Me.ckbMostrarTodos.Name = "ckbMostrarTodos"
        Me.ckbMostrarTodos.Size = New System.Drawing.Size(15, 14)
        Me.ckbMostrarTodos.TabIndex = 22
        Me.ckbMostrarTodos.UseVisualStyleBackColor = True
        '
        'Etiqueta50
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta50.Appearance = Appearance24
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta50.Location = New System.Drawing.Point(7, 20)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta50.TabIndex = 13
        Me.Etiqueta50.Text = "Desde:"
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(46, 16)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(85, 21)
        Me.fecDesde.TabIndex = 11
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(177, 16)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(85, 21)
        Me.fecHasta.TabIndex = 14
        '
        'Etiqueta6
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance25
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(141, 20)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta6.TabIndex = 15
        Me.Etiqueta6.Text = "Hasta:"
        '
        'tabMantenimiento
        '
        Me.tabMantenimiento.Controls.Add(Me.Agrupacion3)
        Me.tabMantenimiento.Controls.Add(Me.tspControlPermiso)
        Me.tabMantenimiento.Controls.Add(Me.agrProcesoNegocio)
        Me.tabMantenimiento.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabMantenimiento.Name = "tabMantenimiento"
        Me.tabMantenimiento.Size = New System.Drawing.Size(982, 638)
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.griDetalles)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 356)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(982, 282)
        Me.Agrupacion3.TabIndex = 1
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDetalles
        '
        Me.griDetalles.DataSource = Me.odCtrlPermisos
        UltraGridColumn59.Header.VisiblePosition = 0
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.EditorComponent = Me.cboTrabajadores
        UltraGridColumn60.Header.Caption = "Trabajador"
        UltraGridColumn60.Header.VisiblePosition = 2
        UltraGridColumn60.Width = 181
        UltraGridColumn61.Header.VisiblePosition = 3
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.EditorComponent = Me.cboJefeArea
        UltraGridColumn62.Header.Caption = "JefeArea"
        UltraGridColumn62.Header.VisiblePosition = 27
        UltraGridColumn62.Width = 195
        UltraGridColumn63.EditorComponent = Me.cboJefeAdministrador
        UltraGridColumn63.Header.Caption = "JefeAdministracion"
        UltraGridColumn63.Header.VisiblePosition = 28
        UltraGridColumn63.Width = 191
        UltraGridColumn64.Header.VisiblePosition = 1
        UltraGridColumn64.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn65.Format = "dd/MM/yyyy hh:mm tt"
        UltraGridColumn65.Header.VisiblePosition = 7
        UltraGridColumn65.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn65.Width = 122
        UltraGridColumn66.Format = "dd/MM/yyyy hh:mm tt"
        UltraGridColumn66.Header.VisiblePosition = 8
        UltraGridColumn66.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn66.Width = 122
        UltraGridColumn67.Header.Caption = "TrabajadorNombre"
        UltraGridColumn67.Header.VisiblePosition = 5
        UltraGridColumn67.Hidden = True
        UltraGridColumn67.Width = 249
        UltraGridColumn68.EditorComponent = Me.cboJefeArea
        UltraGridColumn68.Header.Caption = "JefeAreaNombre"
        UltraGridColumn68.Header.VisiblePosition = 19
        UltraGridColumn68.Hidden = True
        UltraGridColumn68.Width = 198
        UltraGridColumn69.Header.Caption = "JefeAdministracionNombre"
        UltraGridColumn69.Header.VisiblePosition = 20
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.Width = 190
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn70.CellAppearance = Appearance26
        UltraGridColumn70.Header.VisiblePosition = 14
        UltraGridColumn70.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn70.Width = 61
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn71.CellAppearance = Appearance27
        UltraGridColumn71.Header.VisiblePosition = 15
        UltraGridColumn71.MaskInput = "{LOC}nn,nnn,nnn"
        UltraGridColumn71.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn71.Width = 68
        UltraGridColumn72.Header.VisiblePosition = 17
        UltraGridColumn72.Width = 181
        UltraGridColumn73.Header.Caption = "MotivoNombre"
        UltraGridColumn73.Header.VisiblePosition = 6
        UltraGridColumn73.Hidden = True
        UltraGridColumn73.Width = 192
        UltraGridColumn74.Header.VisiblePosition = 18
        UltraGridColumn74.Width = 139
        UltraGridColumn75.Header.VisiblePosition = 21
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 22
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 9
        UltraGridColumn77.Width = 23
        UltraGridColumn78.Format = "dd/MM/yyyy hh:mm tt"
        UltraGridColumn78.Header.VisiblePosition = 10
        UltraGridColumn78.Width = 103
        UltraGridColumn79.Header.VisiblePosition = 11
        UltraGridColumn79.Width = 22
        UltraGridColumn80.Format = "dd/MM/yyyy hh:mm tt"
        UltraGridColumn80.Header.VisiblePosition = 12
        UltraGridColumn81.Header.VisiblePosition = 23
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 24
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.Caption = "Papeleta"
        UltraGridColumn83.Header.VisiblePosition = 16
        UltraGridColumn83.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn83.Width = 42
        UltraGridColumn84.EditorComponent = Me.cboSituacionAdministrativa
        UltraGridColumn84.Header.Caption = "Motivo"
        UltraGridColumn84.Header.VisiblePosition = 4
        UltraGridColumn84.Width = 138
        UltraGridColumn85.Header.VisiblePosition = 25
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 26
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 29
        UltraGridColumn87.Width = 132
        UltraGridColumn2.Header.VisiblePosition = 30
        UltraGridColumn2.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 31
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 32
        UltraGridColumn6.Hidden = True
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance28
        UltraGridColumn8.Header.VisiblePosition = 33
        UltraGridColumn8.Width = 66
        UltraGridColumn101.Header.VisiblePosition = 34
        UltraGridColumn101.Hidden = True
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn102.CellAppearance = Appearance29
        UltraGridColumn102.Header.VisiblePosition = 13
        UltraGridColumn102.Width = 48
        UltraGridColumn107.Header.Caption = "FinVtaVacaciones"
        UltraGridColumn107.Header.VisiblePosition = 35
        UltraGridColumn110.Header.Caption = "InicioVtaVacaciones"
        UltraGridColumn110.Header.VisiblePosition = 36
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn2, UltraGridColumn5, UltraGridColumn6, UltraGridColumn8, UltraGridColumn101, UltraGridColumn102, UltraGridColumn107, UltraGridColumn110})
        Me.griDetalles.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griDetalles.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalles.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalles.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetalles.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalles.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalles.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalles.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalles.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalles.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalles.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalles.Location = New System.Drawing.Point(3, 3)
        Me.griDetalles.Name = "griDetalles"
        Me.griDetalles.Size = New System.Drawing.Size(976, 276)
        Me.griDetalles.TabIndex = 12
        '
        'tspControlPermiso
        '
        Me.tspControlPermiso.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tspControlPermiso.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbQuitar})
        Me.tspControlPermiso.Location = New System.Drawing.Point(0, 331)
        Me.tspControlPermiso.Name = "tspControlPermiso"
        Me.tspControlPermiso.Size = New System.Drawing.Size(982, 25)
        Me.tspControlPermiso.TabIndex = 2
        Me.tspControlPermiso.Text = "ToolStrip1"
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(95, 22)
        Me.tsbAgregar.Text = "Agregar (Ins)"
        '
        'tsbQuitar
        '
        Me.tsbQuitar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsbQuitar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitar.Name = "tsbQuitar"
        Me.tsbQuitar.Size = New System.Drawing.Size(88, 22)
        Me.tsbQuitar.Text = "Quitar (Del)"
        '
        'agrProcesoNegocio
        '
        Me.agrProcesoNegocio.Controls.Add(Me.chkGoce)
        Me.agrProcesoNegocio.Controls.Add(Me.chkPapeleta)
        Me.agrProcesoNegocio.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta18)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta17)
        Me.agrProcesoNegocio.Controls.Add(Me.chbVenta)
        Me.agrProcesoNegocio.Controls.Add(Me.fecFinVta)
        Me.agrProcesoNegocio.Controls.Add(Me.fecInicioVta)
        Me.agrProcesoNegocio.Controls.Add(Me.txtOcupacion)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta16)
        Me.agrProcesoNegocio.Controls.Add(Me.cboSituacionAdministrativa)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta10)
        Me.agrProcesoNegocio.Controls.Add(Me.chkConfirmarIngreso)
        Me.agrProcesoNegocio.Controls.Add(Me.chkConfirmarSalida)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta7)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta5)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta4)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta1)
        Me.agrProcesoNegocio.Controls.Add(Me.cboJefeAdministrador)
        Me.agrProcesoNegocio.Controls.Add(Me.cboJefeArea)
        Me.agrProcesoNegocio.Controls.Add(Me.fecFecha)
        Me.agrProcesoNegocio.Controls.Add(Me.fecIngresoConfirmado)
        Me.agrProcesoNegocio.Controls.Add(Me.fecIngreso)
        Me.agrProcesoNegocio.Controls.Add(Me.fecSalidaConfirmada)
        Me.agrProcesoNegocio.Controls.Add(Me.fecSalida)
        Me.agrProcesoNegocio.Controls.Add(Me.etiTrabajador)
        Me.agrProcesoNegocio.Controls.Add(Me.cboTrabajadores)
        Me.agrProcesoNegocio.Controls.Add(Me.txtGlosa)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta3)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta2)
        Me.agrProcesoNegocio.Controls.Add(Me.agrDatosBasicos)
        Me.agrProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.agrProcesoNegocio.Name = "agrProcesoNegocio"
        Me.agrProcesoNegocio.Size = New System.Drawing.Size(982, 331)
        Me.agrProcesoNegocio.TabIndex = 0
        Me.agrProcesoNegocio.Text = "Datos"
        Me.agrProcesoNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkGoce
        '
        Me.chkGoce.AutoSize = True
        Me.chkGoce.BackColor = System.Drawing.Color.Transparent
        Me.chkGoce.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkGoce.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGoce.ForeColor = System.Drawing.Color.Navy
        Me.chkGoce.Location = New System.Drawing.Point(113, 226)
        Me.chkGoce.Name = "chkGoce"
        Me.chkGoce.Size = New System.Drawing.Size(54, 17)
        Me.chkGoce.TabIndex = 16
        Me.chkGoce.Text = "Goce:"
        Me.chkGoce.UseVisualStyleBackColor = False
        '
        'chkPapeleta
        '
        Me.chkPapeleta.AutoSize = True
        Me.chkPapeleta.BackColor = System.Drawing.Color.Transparent
        Me.chkPapeleta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPapeleta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPapeleta.ForeColor = System.Drawing.Color.Navy
        Me.chkPapeleta.Location = New System.Drawing.Point(29, 226)
        Me.chkPapeleta.Name = "chkPapeleta"
        Me.chkPapeleta.Size = New System.Drawing.Size(72, 17)
        Me.chkPapeleta.TabIndex = 15
        Me.chkPapeleta.Text = "Papeleta:"
        Me.chkPapeleta.UseVisualStyleBackColor = False
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox1.Expanded = False
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(604, 312)
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.RightOutsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(956, 16)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(23, 312)
        Me.UltraExpandableGroupBox1.TabIndex = 283
        Me.UltraExpandableGroupBox1.TabStop = False
        Me.UltraExpandableGroupBox1.Text = "Historial Permisos Trabajador"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griPermisosHistorial)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(200, 100)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'griPermisosHistorial
        '
        Me.griPermisosHistorial.DataSource = Me.odCtrlPermisos
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 5
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn15.Header.VisiblePosition = 8
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn15.Width = 64
        UltraGridColumn16.Header.VisiblePosition = 9
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn16.Width = 69
        UltraGridColumn17.Header.VisiblePosition = 6
        UltraGridColumn17.Width = 108
        UltraGridColumn18.Header.VisiblePosition = 15
        UltraGridColumn18.Width = 134
        UltraGridColumn19.Header.VisiblePosition = 16
        UltraGridColumn19.Width = 126
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance30
        UltraGridColumn20.Header.VisiblePosition = 10
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn20.Width = 61
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance31
        UltraGridColumn21.Header.VisiblePosition = 11
        UltraGridColumn21.MaskInput = "{LOC}nn,nnn,nnn"
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn21.Width = 74
        UltraGridColumn22.Header.VisiblePosition = 13
        UltraGridColumn22.Width = 181
        UltraGridColumn23.Header.VisiblePosition = 7
        UltraGridColumn23.Width = 165
        UltraGridColumn24.Header.VisiblePosition = 14
        UltraGridColumn25.Header.VisiblePosition = 17
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 18
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 19
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 20
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 21
        UltraGridColumn29.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 22
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 23
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 24
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.Caption = "Papeleta"
        UltraGridColumn91.Header.VisiblePosition = 12
        UltraGridColumn91.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn91.Width = 41
        UltraGridColumn92.Header.VisiblePosition = 25
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 26
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 27
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 28
        UltraGridColumn96.Header.VisiblePosition = 29
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 30
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 31
        UltraGridColumn98.Hidden = True
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn99.CellAppearance = Appearance32
        UltraGridColumn99.Header.VisiblePosition = 32
        UltraGridColumn99.Width = 66
        UltraGridColumn103.Header.VisiblePosition = 33
        UltraGridColumn103.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 34
        UltraGridColumn105.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 35
        UltraGridColumn108.Hidden = True
        UltraGridColumn111.Header.VisiblePosition = 36
        UltraGridColumn111.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn103, UltraGridColumn105, UltraGridColumn108, UltraGridColumn111})
        Me.griPermisosHistorial.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griPermisosHistorial.DisplayLayout.MaxColScrollRegions = 1
        Me.griPermisosHistorial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPermisosHistorial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPermisosHistorial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPermisosHistorial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPermisosHistorial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griPermisosHistorial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griPermisosHistorial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPermisosHistorial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPermisosHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPermisosHistorial.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPermisosHistorial.Location = New System.Drawing.Point(0, 0)
        Me.griPermisosHistorial.Name = "griPermisosHistorial"
        Me.griPermisosHistorial.Size = New System.Drawing.Size(200, 100)
        Me.griPermisosHistorial.TabIndex = 11
        '
        'Etiqueta18
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta18.Appearance = Appearance33
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta18.Location = New System.Drawing.Point(347, 306)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(23, 15)
        Me.Etiqueta18.TabIndex = 282
        Me.Etiqueta18.Text = "Fin:"
        Me.Etiqueta18.Visible = False
        '
        'Etiqueta17
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta17.Appearance = Appearance34
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta17.Location = New System.Drawing.Point(204, 306)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta17.TabIndex = 281
        Me.Etiqueta17.Text = "Inicio:"
        Me.Etiqueta17.Visible = False
        '
        'chbVenta
        '
        Me.chbVenta.AutoSize = True
        Me.chbVenta.BackColor = System.Drawing.Color.Transparent
        Me.chbVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVenta.ForeColor = System.Drawing.Color.Navy
        Me.chbVenta.Location = New System.Drawing.Point(85, 304)
        Me.chbVenta.Name = "chbVenta"
        Me.chbVenta.Size = New System.Drawing.Size(113, 17)
        Me.chbVenta.TabIndex = 19
        Me.chbVenta.Text = "VenderVacaciones"
        Me.chbVenta.UseVisualStyleBackColor = False
        Me.chbVenta.Visible = False
        '
        'fecFinVta
        '
        Me.fecFinVta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFinVta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFinVta.Location = New System.Drawing.Point(375, 302)
        Me.fecFinVta.Name = "fecFinVta"
        Me.fecFinVta.Size = New System.Drawing.Size(94, 21)
        Me.fecFinVta.TabIndex = 21
        Me.fecFinVta.Visible = False
        '
        'fecInicioVta
        '
        Me.fecInicioVta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecInicioVta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecInicioVta.Location = New System.Drawing.Point(243, 302)
        Me.fecInicioVta.Name = "fecInicioVta"
        Me.fecInicioVta.Size = New System.Drawing.Size(90, 21)
        Me.fecInicioVta.TabIndex = 20
        Me.fecInicioVta.Visible = False
        '
        'txtOcupacion
        '
        Appearance35.ForeColor = System.Drawing.Color.Black
        Me.txtOcupacion.Appearance = Appearance35
        Me.txtOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOcupacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOcupacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacion.ForeColor = System.Drawing.Color.Black
        Me.txtOcupacion.Location = New System.Drawing.Point(84, 70)
        Me.txtOcupacion.MaxLength = 3000
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.ReadOnly = True
        Me.txtOcupacion.Size = New System.Drawing.Size(385, 22)
        Me.txtOcupacion.TabIndex = 2
        Me.txtOcupacion.TabStop = False
        '
        'Etiqueta16
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta16.Appearance = Appearance36
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(21, 74)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(60, 15)
        Me.Etiqueta16.TabIndex = 276
        Me.Etiqueta16.Text = "Ocupacion:"
        '
        'Etiqueta10
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance37
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(1, 152)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(80, 15)
        Me.Etiqueta10.TabIndex = 272
        Me.Etiqueta10.Text = "Situacion Adm:"
        '
        'chkConfirmarIngreso
        '
        Me.chkConfirmarIngreso.AutoSize = True
        Me.chkConfirmarIngreso.BackColor = System.Drawing.Color.Transparent
        Me.chkConfirmarIngreso.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkConfirmarIngreso.Location = New System.Drawing.Point(251, 123)
        Me.chkConfirmarIngreso.Name = "chkConfirmarIngreso"
        Me.chkConfirmarIngreso.Size = New System.Drawing.Size(71, 17)
        Me.chkConfirmarIngreso.TabIndex = 10
        Me.chkConfirmarIngreso.Text = "Confirmar"
        '
        'chkConfirmarSalida
        '
        Me.chkConfirmarSalida.AutoSize = True
        Me.chkConfirmarSalida.BackColor = System.Drawing.Color.Transparent
        Me.chkConfirmarSalida.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkConfirmarSalida.Location = New System.Drawing.Point(251, 99)
        Me.chkConfirmarSalida.Name = "chkConfirmarSalida"
        Me.chkConfirmarSalida.Size = New System.Drawing.Size(71, 17)
        Me.chkConfirmarSalida.TabIndex = 5
        Me.chkConfirmarSalida.Text = "Confirmar"
        '
        'Etiqueta7
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance38
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(2, 126)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(79, 15)
        Me.Etiqueta7.TabIndex = 267
        Me.Etiqueta7.Text = "Fecha Ingreso:"
        '
        'Etiqueta5
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance39
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(10, 100)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(71, 15)
        Me.Etiqueta5.TabIndex = 266
        Me.Etiqueta5.Text = "Fecha Salida:"
        '
        'Etiqueta4
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance40
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(27, 281)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(55, 15)
        Me.Etiqueta4.TabIndex = 265
        Me.Etiqueta4.Text = "Jefe Adm:"
        '
        'Etiqueta1
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance41
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(26, 254)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(55, 15)
        Me.Etiqueta1.TabIndex = 264
        Me.Etiqueta1.Text = "Jefe Area:"
        '
        'fecFecha
        '
        Me.fecFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFecha.Location = New System.Drawing.Point(84, 20)
        Me.fecFecha.Name = "fecFecha"
        Me.fecFecha.Size = New System.Drawing.Size(105, 20)
        Me.fecFecha.TabIndex = 0
        '
        'fecIngresoConfirmado
        '
        Me.fecIngresoConfirmado.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.fecIngresoConfirmado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecIngresoConfirmado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecIngresoConfirmado.Location = New System.Drawing.Point(322, 122)
        Me.fecIngresoConfirmado.Name = "fecIngresoConfirmado"
        Me.fecIngresoConfirmado.Size = New System.Drawing.Size(146, 21)
        Me.fecIngresoConfirmado.TabIndex = 11
        '
        'fecIngreso
        '
        Me.fecIngreso.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.fecIngreso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecIngreso.Location = New System.Drawing.Point(84, 123)
        Me.fecIngreso.Name = "fecIngreso"
        Me.fecIngreso.Size = New System.Drawing.Size(146, 21)
        Me.fecIngreso.TabIndex = 8
        '
        'fecSalidaConfirmada
        '
        Me.fecSalidaConfirmada.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.fecSalidaConfirmada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecSalidaConfirmada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecSalidaConfirmada.Location = New System.Drawing.Point(322, 97)
        Me.fecSalidaConfirmada.Name = "fecSalidaConfirmada"
        Me.fecSalidaConfirmada.Size = New System.Drawing.Size(146, 21)
        Me.fecSalidaConfirmada.TabIndex = 6
        '
        'fecSalida
        '
        Me.fecSalida.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.fecSalida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecSalida.Location = New System.Drawing.Point(84, 97)
        Me.fecSalida.Name = "fecSalida"
        Me.fecSalida.Size = New System.Drawing.Size(146, 21)
        Me.fecSalida.TabIndex = 3
        '
        'etiTrabajador
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.etiTrabajador.Appearance = Appearance42
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTrabajador.Location = New System.Drawing.Point(18, 47)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(63, 15)
        Me.etiTrabajador.TabIndex = 244
        Me.etiTrabajador.Text = "Trabajador:"
        '
        'txtGlosa
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Appearance = Appearance43
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Location = New System.Drawing.Point(84, 176)
        Me.txtGlosa.MaxLength = 3000
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(385, 45)
        Me.txtGlosa.TabIndex = 14
        '
        'Etiqueta3
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance44
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(43, 22)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta3.TabIndex = 242
        Me.Etiqueta3.Text = "Fecha:"
        '
        'Etiqueta2
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance45
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(43, 176)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta2.TabIndex = 240
        Me.Etiqueta2.Text = "Glosa:"
        '
        'agrDatosBasicos
        '
        Me.agrDatosBasicos.Controls.Add(Me.FotoTrabajador)
        Me.agrDatosBasicos.Controls.Add(Me.verActivo)
        Me.agrDatosBasicos.Controls.Add(Me.fecFechaIngreso)
        Me.agrDatosBasicos.Controls.Add(Me.chkDisponible)
        Me.agrDatosBasicos.Controls.Add(Me.txtCargo)
        Me.agrDatosBasicos.Controls.Add(Me.etiFechaIngreso)
        Me.agrDatosBasicos.Controls.Add(Me.etiCargo)
        Me.agrDatosBasicos.Controls.Add(Me.txtArea)
        Me.agrDatosBasicos.Controls.Add(Me.etiArea)
        Me.agrDatosBasicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosBasicos.ForeColor = System.Drawing.Color.Black
        Me.agrDatosBasicos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.agrDatosBasicos.Location = New System.Drawing.Point(474, 18)
        Me.agrDatosBasicos.Name = "agrDatosBasicos"
        Me.agrDatosBasicos.Size = New System.Drawing.Size(238, 303)
        Me.agrDatosBasicos.TabIndex = 21
        Me.agrDatosBasicos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.agrDatosBasicos.Visible = False
        '
        'FotoTrabajador
        '
        Me.FotoTrabajador.Location = New System.Drawing.Point(37, 5)
        Me.FotoTrabajador.Name = "FotoTrabajador"
        Me.FotoTrabajador.Size = New System.Drawing.Size(169, 182)
        Me.FotoTrabajador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoTrabajador.TabIndex = 262
        Me.FotoTrabajador.TabStop = False
        Me.FotoTrabajador.Visible = False
        '
        'verActivo
        '
        Me.verActivo.AutoSize = True
        Me.verActivo.BackColor = System.Drawing.Color.Transparent
        Me.verActivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.Black
        Me.verActivo.Location = New System.Drawing.Point(181, 279)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 235
        Me.verActivo.TabStop = False
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'fecFechaIngreso
        '
        Appearance46.ForeColor = System.Drawing.Color.Black
        Me.fecFechaIngreso.Appearance = Appearance46
        Me.fecFechaIngreso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.fecFechaIngreso.Location = New System.Drawing.Point(10, 277)
        Me.fecFechaIngreso.Name = "fecFechaIngreso"
        Me.fecFechaIngreso.ReadOnly = True
        Me.fecFechaIngreso.Size = New System.Drawing.Size(90, 21)
        Me.fecFechaIngreso.TabIndex = 103
        Me.fecFechaIngreso.TabStop = False
        '
        'chkDisponible
        '
        Me.chkDisponible.AutoSize = True
        Me.chkDisponible.BackColor = System.Drawing.Color.Transparent
        Me.chkDisponible.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisponible.ForeColor = System.Drawing.Color.Black
        Me.chkDisponible.Location = New System.Drawing.Point(102, 279)
        Me.chkDisponible.Name = "chkDisponible"
        Me.chkDisponible.Size = New System.Drawing.Size(73, 17)
        Me.chkDisponible.TabIndex = 104
        Me.chkDisponible.TabStop = False
        Me.chkDisponible.Text = "Disponible"
        '
        'txtCargo
        '
        Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCargo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCargo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(10, 238)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Size = New System.Drawing.Size(218, 22)
        Me.txtCargo.TabIndex = 102
        Me.txtCargo.TabStop = False
        Me.txtCargo.Text = "[CARGO]"
        '
        'etiFechaIngreso
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.etiFechaIngreso.Appearance = Appearance47
        Me.etiFechaIngreso.AutoSize = True
        Me.etiFechaIngreso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.etiFechaIngreso.Location = New System.Drawing.Point(10, 262)
        Me.etiFechaIngreso.Name = "etiFechaIngreso"
        Me.etiFechaIngreso.Size = New System.Drawing.Size(75, 15)
        Me.etiFechaIngreso.TabIndex = 0
        Me.etiFechaIngreso.Text = "F. de Ingreso:"
        '
        'etiCargo
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.etiCargo.Appearance = Appearance48
        Me.etiCargo.AutoSize = True
        Me.etiCargo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCargo.ForeColor = System.Drawing.Color.Black
        Me.etiCargo.Location = New System.Drawing.Point(9, 224)
        Me.etiCargo.Name = "etiCargo"
        Me.etiCargo.Size = New System.Drawing.Size(37, 15)
        Me.etiCargo.TabIndex = 0
        Me.etiCargo.Text = "Cargo:"
        '
        'txtArea
        '
        Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(10, 202)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(218, 22)
        Me.txtArea.TabIndex = 100
        Me.txtArea.TabStop = False
        Me.txtArea.Text = "[AREA]"
        '
        'etiArea
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.etiArea.Appearance = Appearance49
        Me.etiArea.AutoSize = True
        Me.etiArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiArea.ForeColor = System.Drawing.Color.Black
        Me.etiArea.Location = New System.Drawing.Point(10, 188)
        Me.etiArea.Name = "etiArea"
        Me.etiArea.Size = New System.Drawing.Size(31, 15)
        Me.etiArea.TabIndex = 0
        Me.etiArea.Text = "Area:"
        '
        'ficCtrlPermisos
        '
        Me.ficCtrlPermisos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficCtrlPermisos.Controls.Add(Me.tabLista)
        Me.ficCtrlPermisos.Controls.Add(Me.tabMantenimiento)
        Me.ficCtrlPermisos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCtrlPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficCtrlPermisos.Location = New System.Drawing.Point(0, 0)
        Me.ficCtrlPermisos.Name = "ficCtrlPermisos"
        Me.ficCtrlPermisos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficCtrlPermisos.Size = New System.Drawing.Size(984, 661)
        Me.ficCtrlPermisos.TabIndex = 10
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.tabLista
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.tabMantenimiento
        UltraTab2.Text = "Mantenimiento"
        Me.ficCtrlPermisos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficCtrlPermisos.TabStop = False
        Me.ficCtrlPermisos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(982, 638)
        '
        'Etiqueta9
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance23
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(2, 44)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(41, 15)
        Me.Etiqueta9.TabIndex = 23
        Me.Etiqueta9.Text = "Centro:"
        '
        'cboCentroBus
        '
        Appearance22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroBus.Appearance = Appearance22
        Me.cboCentroBus.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentroBus.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroBus.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentroBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroBus.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroBus.Location = New System.Drawing.Point(46, 40)
        Me.cboCentroBus.Name = "cboCentroBus"
        Me.cboCentroBus.Size = New System.Drawing.Size(132, 21)
        Me.cboCentroBus.TabIndex = 24
        Me.cboCentroBus.ValueMember = "Id"
        '
        'frm_ControlPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.ficCtrlPermisos)
        Me.KeyPreview = True
        Me.Name = "frm_ControlPermisos"
        Me.Text = "Control Permisos"
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboJefeArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboJefeAdministrador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSituacionAdministrativa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLista.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.griControlPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odCtrlPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOperaciones.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.ColorFilaActualizada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresExcedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        Me.tabMantenimiento.ResumeLayout(False)
        Me.tabMantenimiento.PerformLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.griDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspControlPermiso.ResumeLayout(False)
        Me.tspControlPermiso.PerformLayout()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoNegocio.ResumeLayout(False)
        Me.agrProcesoNegocio.PerformLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griPermisosHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOcupacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkConfirmarIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkConfirmarSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosBasicos.ResumeLayout(False)
        Me.agrDatosBasicos.PerformLayout()
        CType(Me.FotoTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficCtrlPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCtrlPermisos.ResumeLayout(False)
        CType(Me.cboCentroBus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficCtrlPermisos As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tabLista As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents agrOperaciones As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents tabMantenimiento As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrProcesoNegocio As ISL.Controles.Agrupacion
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajadores As ISL.Controles.Combo
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents fecFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecIngresoConfirmado As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecSalidaConfirmada As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboJefeAdministrador As ISL.Controles.Combo
    Friend WithEvents cboJefeArea As ISL.Controles.Combo
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents agrDatosBasicos As ISL.Controles.Agrupacion
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents fecFechaIngreso As ISL.Controles.Fecha
    Friend WithEvents chkDisponible As ISL.Controles.Chequear
    Friend WithEvents txtCargo As ISL.Controles.Texto
    Friend WithEvents etiFechaIngreso As ISL.Controles.Etiqueta
    Friend WithEvents etiCargo As ISL.Controles.Etiqueta
    Friend WithEvents txtArea As ISL.Controles.Texto
    Friend WithEvents etiArea As ISL.Controles.Etiqueta
    Friend WithEvents FotoTrabajador As System.Windows.Forms.PictureBox
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents chkConfirmarIngreso As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkConfirmarSalida As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents odCtrlPermisos As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents tsmiInsertar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresExcedidos As ISL.Controles.Colores
    Friend WithEvents R As ISL.Controles.Etiqueta
    Friend WithEvents Colores2 As ISL.Controles.Colores
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents Colores1 As ISL.Controles.Colores
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Colores3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents ckbMostrarTodos As System.Windows.Forms.CheckBox
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents cboSituacionAdministrativa As ISL.Controles.Combo
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Colores4 As ISL.Controles.Colores
    Friend WithEvents txtOcupacion As ISL.Controles.Texto
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents griControlPermisos As ISL.Controles.Grilla
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents griPermisosHistorial As ISL.Controles.Grilla
    Friend WithEvents fecFinVta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecInicioVta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents chbVenta As System.Windows.Forms.CheckBox
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents tspControlPermiso As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitar As System.Windows.Forms.ToolStripButton
    Friend WithEvents griDetalles As ISL.Controles.Grilla
    Friend WithEvents chkPapeleta As System.Windows.Forms.CheckBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents ColorFilaActualizada As ISL.Controles.Colores
    Friend WithEvents chkGoce As System.Windows.Forms.CheckBox
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents cboCentroBus As ISL.Controles.Combo
End Class
