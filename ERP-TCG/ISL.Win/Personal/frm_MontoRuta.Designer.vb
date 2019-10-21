<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MontoRuta
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOcupacion")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoContrato")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocupacion")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoContrato")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTermino")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigencia")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sueldo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTruncamiento")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModalidadContrato")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModalidadContrato")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCargado")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoSolo")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAcompañado")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeCopiloto")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeAyudante")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kilometraje")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigencia")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoSolo")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroPiloto")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroCopiloto")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNacional")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoria")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCargado")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoSolo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoAcompañado")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeCopiloto")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeAyudante")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Kilometraje")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigencia")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BonoSolo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BonoCruceroPiloto")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BonoCruceroCopiloto")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndNacional")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCategoria")
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCargado")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoSolo")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAcompañado")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeCopiloto")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeAyudante")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kilometraje")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigencia")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoSolo")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroPiloto")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroCopiloto")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNacional")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoria")
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
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCargado")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoSolo")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAcompañado")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeCopiloto")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeAyudante")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kilometraje")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigencia")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoSolo")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroPiloto")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroCopiloto")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNacional")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoria")
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
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grilla1 = New ISL.Controles.Grilla(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.griHistorialMontoRutas = New ISL.Controles.Grilla(Me.components)
        Me.odMontoRuta = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficHistorial = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.chkIndCategoria = New System.Windows.Forms.CheckBox()
        Me.chkIndNacional = New System.Windows.Forms.CheckBox()
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.numCuenta = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.numCruceroP = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numCruceroC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numBonoSolo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.btnQuitar = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.rdbVacio = New System.Windows.Forms.RadioButton()
        Me.rdbCargado = New System.Windows.Forms.RadioButton()
        Me.numPorcentajeCopi = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numPorcentajeAyu = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.numMontoAcompañado = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.numMontoSolo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboOrigen = New ISL.Controles.Combo(Me.components)
        Me.cboDestino = New ISL.Controles.Combo(Me.components)
        Me.cboTipoVehiculo = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.griImportarMontos = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorDuplicado = New ISL.Controles.Colores(Me.components)
        Me.btnLimpiar = New Infragistics.Win.Misc.UltraButton()
        Me.btnVerificar = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorNoRegistrados = New ISL.Controles.Colores(Me.components)
        Me.btnImportar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.griMontoRutas = New ISL.Controles.Grilla(Me.components)
        Me.mnuMontoRuta = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuVigencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuImportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.rdbVacios = New System.Windows.Forms.RadioButton()
        Me.rdbCargados = New System.Windows.Forms.RadioButton()
        Me.rdbTodos = New System.Windows.Forms.RadioButton()
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboRuta = New ISL.Controles.Combo(Me.components)
        Me.cboTipoFiltro = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.rdbFechas = New System.Windows.Forms.RadioButton()
        Me.agrFechas = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.rdbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.ficMantenimiento = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ficMontoRuta = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.Grilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.griHistorialMontoRutas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMontoRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.ficHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficHistorial.SuspendLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.numCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCruceroP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCruceroC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBonoSolo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPorcentajeCopi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPorcentajeAyu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMontoAcompañado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMontoSolo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.griImportarMontos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.colorDuplicado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorNoRegistrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.griMontoRutas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMontoRuta.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFechas.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.ficMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMantenimiento.SuspendLayout()
        CType(Me.ficMontoRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMontoRuta.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Grilla1)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1219, 198)
        '
        'Grilla1
        '
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 2
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.Width = 212
        UltraGridColumn23.Header.VisiblePosition = 6
        UltraGridColumn23.Width = 264
        UltraGridColumn28.Header.VisiblePosition = 7
        UltraGridColumn28.Width = 211
        UltraGridColumn29.Header.VisiblePosition = 9
        UltraGridColumn30.Header.VisiblePosition = 10
        UltraGridColumn31.Header.VisiblePosition = 11
        UltraGridColumn31.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn32.Header.VisiblePosition = 12
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 13
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 14
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 15
        UltraGridColumn35.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn36.CellAppearance = Appearance1
        UltraGridColumn36.Header.VisiblePosition = 8
        UltraGridColumn36.MaskInput = "{double:9.2}"
        UltraGridColumn36.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1.Header.VisiblePosition = 16
        UltraGridColumn3.Header.VisiblePosition = 17
        UltraGridColumn3.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 18
        UltraGridColumn5.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 19
        UltraGridColumn7.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 20
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn1, UltraGridColumn3, UltraGridColumn5, UltraGridColumn7, UltraGridColumn9})
        Me.Grilla1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Grilla1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.Grilla1.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grilla1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.Grilla1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.Grilla1.DisplayLayout.GroupByBox.Hidden = True
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grilla1.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.Grilla1.DisplayLayout.MaxColScrollRegions = 1
        Me.Grilla1.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grilla1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grilla1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grilla1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.Grilla1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance5.BorderColor = System.Drawing.Color.Silver
        Me.Grilla1.DisplayLayout.Override.CellAppearance = Appearance5
        Me.Grilla1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grilla1.DisplayLayout.Override.CellPadding = 0
        Me.Grilla1.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grilla1.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.Grilla1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.Grilla1.DisplayLayout.Override.GroupByRowAppearance = Appearance6
        Appearance7.TextHAlignAsString = "Left"
        Me.Grilla1.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.Grilla1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Me.Grilla1.DisplayLayout.Override.RowAppearance = Appearance8
        Me.Grilla1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grilla1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.Grilla1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.Grilla1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grilla1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grilla1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.Grilla1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla1.Location = New System.Drawing.Point(0, 0)
        Me.Grilla1.Name = "Grilla1"
        Me.Grilla1.Size = New System.Drawing.Size(1219, 198)
        Me.Grilla1.TabIndex = 0
        Me.Grilla1.TabStop = False
        Me.Grilla1.Text = "Grilla1"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.Agrupacion6)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1219, 198)
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.griHistorialMontoRutas)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(1219, 198)
        Me.Agrupacion6.TabIndex = 0
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griHistorialMontoRutas
        '
        Me.griHistorialMontoRutas.DataSource = Me.odMontoRuta
        UltraGridColumn43.Header.VisiblePosition = 0
        UltraGridColumn43.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Width = 156
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn6.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 5
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 11
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance9
        UltraGridColumn12.Header.VisiblePosition = 6
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.Width = 92
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance10
        UltraGridColumn13.Header.VisiblePosition = 7
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn14.CellAppearance = Appearance11
        UltraGridColumn14.Header.Caption = "% Copiloto"
        UltraGridColumn14.Header.VisiblePosition = 8
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn14.Width = 99
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn15.CellAppearance = Appearance12
        UltraGridColumn15.Header.Caption = "% Ayudante"
        UltraGridColumn15.Header.VisiblePosition = 9
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn15.Width = 94
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn16.CellAppearance = Appearance13
        UltraGridColumn16.Header.VisiblePosition = 10
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn53.Header.VisiblePosition = 12
        UltraGridColumn53.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn57.Header.VisiblePosition = 15
        UltraGridColumn57.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 13
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 14
        UltraGridColumn55.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 16
        UltraGridColumn38.Header.VisiblePosition = 17
        UltraGridColumn39.Header.VisiblePosition = 18
        UltraGridColumn42.Header.VisiblePosition = 19
        UltraGridColumn46.Header.VisiblePosition = 20
        UltraGridColumn49.Header.VisiblePosition = 21
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn43, UltraGridColumn2, UltraGridColumn4, UltraGridColumn6, UltraGridColumn8, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn53, UltraGridColumn57, UltraGridColumn54, UltraGridColumn55, UltraGridColumn24, UltraGridColumn38, UltraGridColumn39, UltraGridColumn42, UltraGridColumn46, UltraGridColumn49})
        Me.griHistorialMontoRutas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griHistorialMontoRutas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.griHistorialMontoRutas.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griHistorialMontoRutas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.griHistorialMontoRutas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griHistorialMontoRutas.DisplayLayout.GroupByBox.Hidden = True
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griHistorialMontoRutas.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.griHistorialMontoRutas.DisplayLayout.MaxColScrollRegions = 1
        Me.griHistorialMontoRutas.DisplayLayout.MaxRowScrollRegions = 1
        Me.griHistorialMontoRutas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHistorialMontoRutas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHistorialMontoRutas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griHistorialMontoRutas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance17.BorderColor = System.Drawing.Color.Silver
        Me.griHistorialMontoRutas.DisplayLayout.Override.CellAppearance = Appearance17
        Me.griHistorialMontoRutas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griHistorialMontoRutas.DisplayLayout.Override.CellPadding = 0
        Me.griHistorialMontoRutas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griHistorialMontoRutas.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griHistorialMontoRutas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griHistorialMontoRutas.DisplayLayout.Override.GroupByRowAppearance = Appearance18
        Appearance19.TextHAlignAsString = "Left"
        Me.griHistorialMontoRutas.DisplayLayout.Override.HeaderAppearance = Appearance19
        Me.griHistorialMontoRutas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Me.griHistorialMontoRutas.DisplayLayout.Override.RowAppearance = Appearance20
        Me.griHistorialMontoRutas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griHistorialMontoRutas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griHistorialMontoRutas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griHistorialMontoRutas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griHistorialMontoRutas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griHistorialMontoRutas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griHistorialMontoRutas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHistorialMontoRutas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griHistorialMontoRutas.Location = New System.Drawing.Point(3, 3)
        Me.griHistorialMontoRutas.Name = "griHistorialMontoRutas"
        Me.griHistorialMontoRutas.Size = New System.Drawing.Size(1213, 192)
        Me.griHistorialMontoRutas.TabIndex = 0
        Me.griHistorialMontoRutas.TabStop = False
        Me.griHistorialMontoRutas.Text = "Grilla1"
        '
        'odMontoRuta
        '
        UltraDataColumn7.DataType = GetType(Boolean)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Decimal)
        UltraDataColumn11.DataType = GetType(Decimal)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Boolean)
        UltraDataColumn14.DataType = GetType(Boolean)
        UltraDataColumn17.DataType = GetType(Double)
        UltraDataColumn18.DataType = GetType(Double)
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn20.DataType = GetType(Short)
        UltraDataColumn21.DataType = GetType(Boolean)
        UltraDataColumn22.DataType = GetType(Boolean)
        Me.odMontoRuta.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22})
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ficHistorial)
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion5)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1221, 372)
        '
        'ficHistorial
        '
        Me.ficHistorial.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficHistorial.Controls.Add(Me.UltraTabPageControl5)
        Me.ficHistorial.Controls.Add(Me.UltraTabPageControl6)
        Me.ficHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficHistorial.Location = New System.Drawing.Point(0, 151)
        Me.ficHistorial.Name = "ficHistorial"
        Me.ficHistorial.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficHistorial.Size = New System.Drawing.Size(1221, 221)
        Me.ficHistorial.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.ficHistorial.TabIndex = 1
        UltraTab3.TabPage = Me.UltraTabPageControl5
        UltraTab3.Text = "Nuevo"
        UltraTab3.Visible = False
        UltraTab4.TabPage = Me.UltraTabPageControl6
        UltraTab4.Text = "Historial"
        Me.ficHistorial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.ficHistorial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1219, 198)
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.chkIndCategoria)
        Me.Agrupacion5.Controls.Add(Me.chkIndNacional)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta16)
        Me.Agrupacion5.Controls.Add(Me.numCuenta)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion5.Controls.Add(Me.numCruceroP)
        Me.Agrupacion5.Controls.Add(Me.numCruceroC)
        Me.Agrupacion5.Controls.Add(Me.numBonoSolo)
        Me.Agrupacion5.Controls.Add(Me.btnQuitar)
        Me.Agrupacion5.Controls.Add(Me.btnAgregar)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion5.Controls.Add(Me.rdbVacio)
        Me.Agrupacion5.Controls.Add(Me.rdbCargado)
        Me.Agrupacion5.Controls.Add(Me.numPorcentajeCopi)
        Me.Agrupacion5.Controls.Add(Me.numPorcentajeAyu)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion5.Controls.Add(Me.numMontoAcompañado)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion5.Controls.Add(Me.numMontoSolo)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion5.Controls.Add(Me.cboOrigen)
        Me.Agrupacion5.Controls.Add(Me.cboDestino)
        Me.Agrupacion5.Controls.Add(Me.cboTipoVehiculo)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(1221, 151)
        Me.Agrupacion5.TabIndex = 0
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkIndCategoria
        '
        Me.chkIndCategoria.AutoSize = True
        Me.chkIndCategoria.BackColor = System.Drawing.Color.Transparent
        Me.chkIndCategoria.Checked = True
        Me.chkIndCategoria.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIndCategoria.ForeColor = System.Drawing.Color.Navy
        Me.chkIndCategoria.Location = New System.Drawing.Point(199, 122)
        Me.chkIndCategoria.Name = "chkIndCategoria"
        Me.chkIndCategoria.Size = New System.Drawing.Size(116, 17)
        Me.chkIndCategoria.TabIndex = 12
        Me.chkIndCategoria.Text = "CalcularXCategoria"
        Me.chkIndCategoria.UseVisualStyleBackColor = False
        '
        'chkIndNacional
        '
        Me.chkIndNacional.AutoSize = True
        Me.chkIndNacional.BackColor = System.Drawing.Color.Transparent
        Me.chkIndNacional.Checked = True
        Me.chkIndNacional.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIndNacional.ForeColor = System.Drawing.Color.Navy
        Me.chkIndNacional.Location = New System.Drawing.Point(84, 122)
        Me.chkIndNacional.Name = "chkIndNacional"
        Me.chkIndNacional.Size = New System.Drawing.Size(91, 17)
        Me.chkIndNacional.TabIndex = 11
        Me.chkIndNacional.Text = "RutaNacional"
        Me.chkIndNacional.UseVisualStyleBackColor = False
        '
        'Etiqueta16
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance21
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(213, 99)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta16.TabIndex = 9
        Me.Etiqueta16.Text = "Cuenta:"
        '
        'numCuenta
        '
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.numCuenta.Appearance = Appearance22
        Me.numCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCuenta.ForeColor = System.Drawing.Color.Black
        Me.numCuenta.Location = New System.Drawing.Point(262, 95)
        Me.numCuenta.MaskInput = "nn"
        Me.numCuenta.MaxValue = 5
        Me.numCuenta.MinValue = 0
        Me.numCuenta.Name = "numCuenta"
        Me.numCuenta.NullText = "0"
        Me.numCuenta.Size = New System.Drawing.Size(28, 21)
        Me.numCuenta.TabIndex = 10
        '
        'Etiqueta15
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance23
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(594, 70)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(87, 14)
        Me.Etiqueta15.TabIndex = 25
        Me.Etiqueta15.Text = "CruceroCopiloto:"
        '
        'Etiqueta14
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance24
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(607, 43)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(74, 14)
        Me.Etiqueta14.TabIndex = 23
        Me.Etiqueta14.Text = "CruceroPiloto:"
        '
        'Etiqueta10
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance25
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(626, 14)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta10.TabIndex = 21
        Me.Etiqueta10.Text = "BonoSolo:"
        '
        'numCruceroP
        '
        Appearance26.ForeColor = System.Drawing.Color.Black
        Me.numCruceroP.Appearance = Appearance26
        Me.numCruceroP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCruceroP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCruceroP.ForeColor = System.Drawing.Color.Black
        Me.numCruceroP.FormatString = "#,##0.00"
        Me.numCruceroP.Location = New System.Drawing.Point(687, 39)
        Me.numCruceroP.MaskInput = "{double:3.2}"
        Me.numCruceroP.MaxValue = 100.0R
        Me.numCruceroP.MinValue = 0.0R
        Me.numCruceroP.Name = "numCruceroP"
        Me.numCruceroP.Nullable = True
        Me.numCruceroP.NullText = "0.00"
        Me.numCruceroP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numCruceroP.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numCruceroP.Size = New System.Drawing.Size(60, 21)
        Me.numCruceroP.TabIndex = 24
        '
        'numCruceroC
        '
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.numCruceroC.Appearance = Appearance27
        Me.numCruceroC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCruceroC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCruceroC.ForeColor = System.Drawing.Color.Black
        Me.numCruceroC.FormatString = "#,##0.00"
        Me.numCruceroC.Location = New System.Drawing.Point(687, 66)
        Me.numCruceroC.Name = "numCruceroC"
        Me.numCruceroC.Nullable = True
        Me.numCruceroC.NullText = "0.00"
        Me.numCruceroC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numCruceroC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numCruceroC.Size = New System.Drawing.Size(60, 21)
        Me.numCruceroC.TabIndex = 26
        '
        'numBonoSolo
        '
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.numBonoSolo.Appearance = Appearance28
        Me.numBonoSolo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numBonoSolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numBonoSolo.ForeColor = System.Drawing.Color.Black
        Me.numBonoSolo.FormatString = "#,##0.00"
        Me.numBonoSolo.Location = New System.Drawing.Point(687, 12)
        Me.numBonoSolo.Name = "numBonoSolo"
        Me.numBonoSolo.Nullable = True
        Me.numBonoSolo.NullText = "0.00"
        Me.numBonoSolo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numBonoSolo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numBonoSolo.Size = New System.Drawing.Size(60, 21)
        Me.numBonoSolo.TabIndex = 22
        '
        'btnQuitar
        '
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Appearance29.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnQuitar.Appearance = Appearance29
        Me.btnQuitar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnQuitar.Location = New System.Drawing.Point(936, 52)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(96, 30)
        Me.btnQuitar.TabIndex = 28
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.Visible = False
        '
        'btnAgregar
        '
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Appearance30.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.btnAgregar.Appearance = Appearance30
        Me.btnAgregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregar.Location = New System.Drawing.Point(936, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(96, 30)
        Me.btnAgregar.TabIndex = 27
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Visible = False
        '
        'Etiqueta12
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance31
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(41, 97)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta12.TabIndex = 6
        Me.Etiqueta12.Text = "Carga:"
        '
        'rdbVacio
        '
        Me.rdbVacio.AutoSize = True
        Me.rdbVacio.BackColor = System.Drawing.Color.Transparent
        Me.rdbVacio.ForeColor = System.Drawing.Color.Navy
        Me.rdbVacio.Location = New System.Drawing.Point(155, 97)
        Me.rdbVacio.Name = "rdbVacio"
        Me.rdbVacio.Size = New System.Drawing.Size(52, 17)
        Me.rdbVacio.TabIndex = 8
        Me.rdbVacio.Text = "Vacio"
        Me.rdbVacio.UseVisualStyleBackColor = False
        '
        'rdbCargado
        '
        Me.rdbCargado.AutoSize = True
        Me.rdbCargado.BackColor = System.Drawing.Color.Transparent
        Me.rdbCargado.Checked = True
        Me.rdbCargado.ForeColor = System.Drawing.Color.Navy
        Me.rdbCargado.Location = New System.Drawing.Point(84, 97)
        Me.rdbCargado.Name = "rdbCargado"
        Me.rdbCargado.Size = New System.Drawing.Size(65, 17)
        Me.rdbCargado.TabIndex = 7
        Me.rdbCargado.TabStop = True
        Me.rdbCargado.Text = "Cargado"
        Me.rdbCargado.UseVisualStyleBackColor = False
        '
        'numPorcentajeCopi
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.numPorcentajeCopi.Appearance = Appearance32
        Me.numPorcentajeCopi.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numPorcentajeCopi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPorcentajeCopi.ForeColor = System.Drawing.Color.Black
        Me.numPorcentajeCopi.FormatString = "#,##0.00"
        Me.numPorcentajeCopi.Location = New System.Drawing.Point(517, 63)
        Me.numPorcentajeCopi.MaskInput = "{double:3.2}"
        Me.numPorcentajeCopi.MaxValue = 100.0R
        Me.numPorcentajeCopi.MinValue = 0.0R
        Me.numPorcentajeCopi.Name = "numPorcentajeCopi"
        Me.numPorcentajeCopi.Nullable = True
        Me.numPorcentajeCopi.NullText = "0.00"
        Me.numPorcentajeCopi.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numPorcentajeCopi.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numPorcentajeCopi.Size = New System.Drawing.Size(60, 21)
        Me.numPorcentajeCopi.TabIndex = 18
        '
        'numPorcentajeAyu
        '
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.numPorcentajeAyu.Appearance = Appearance33
        Me.numPorcentajeAyu.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numPorcentajeAyu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPorcentajeAyu.ForeColor = System.Drawing.Color.Black
        Me.numPorcentajeAyu.FormatString = "#,##0.00"
        Me.numPorcentajeAyu.Location = New System.Drawing.Point(517, 90)
        Me.numPorcentajeAyu.MaskInput = "{double:3.2}"
        Me.numPorcentajeAyu.MaxValue = 100.0R
        Me.numPorcentajeAyu.MinValue = 0.0R
        Me.numPorcentajeAyu.Name = "numPorcentajeAyu"
        Me.numPorcentajeAyu.Nullable = True
        Me.numPorcentajeAyu.NullText = "0.00"
        Me.numPorcentajeAyu.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numPorcentajeAyu.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numPorcentajeAyu.Size = New System.Drawing.Size(60, 21)
        Me.numPorcentajeAyu.TabIndex = 20
        '
        'Etiqueta7
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance34
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(445, 94)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(66, 14)
        Me.Etiqueta7.TabIndex = 19
        Me.Etiqueta7.Text = "% Ayudante:"
        '
        'Etiqueta6
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance35
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(451, 67)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta6.TabIndex = 17
        Me.Etiqueta6.Text = "% Copiloto:"
        '
        'numMontoAcompañado
        '
        Appearance36.ForeColor = System.Drawing.Color.Black
        Me.numMontoAcompañado.Appearance = Appearance36
        Me.numMontoAcompañado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numMontoAcompañado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMontoAcompañado.ForeColor = System.Drawing.Color.Black
        Me.numMontoAcompañado.FormatString = "#,##0.00"
        Me.numMontoAcompañado.Location = New System.Drawing.Point(517, 36)
        Me.numMontoAcompañado.Name = "numMontoAcompañado"
        Me.numMontoAcompañado.Nullable = True
        Me.numMontoAcompañado.NullText = "0.00"
        Me.numMontoAcompañado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numMontoAcompañado.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numMontoAcompañado.Size = New System.Drawing.Size(60, 21)
        Me.numMontoAcompañado.TabIndex = 16
        '
        'Etiqueta5
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance37
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(406, 40)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(105, 14)
        Me.Etiqueta5.TabIndex = 15
        Me.Etiqueta5.Text = "Monto Acompañado:"
        '
        'Etiqueta4
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance38
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(448, 13)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(63, 14)
        Me.Etiqueta4.TabIndex = 13
        Me.Etiqueta4.Text = "Monto Solo:"
        '
        'numMontoSolo
        '
        Appearance39.ForeColor = System.Drawing.Color.Black
        Me.numMontoSolo.Appearance = Appearance39
        Me.numMontoSolo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numMontoSolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMontoSolo.ForeColor = System.Drawing.Color.Black
        Me.numMontoSolo.FormatString = "#,##0.00"
        Me.numMontoSolo.Location = New System.Drawing.Point(517, 9)
        Me.numMontoSolo.Name = "numMontoSolo"
        Me.numMontoSolo.Nullable = True
        Me.numMontoSolo.NullText = "0.00"
        Me.numMontoSolo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numMontoSolo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numMontoSolo.Size = New System.Drawing.Size(60, 21)
        Me.numMontoSolo.TabIndex = 14
        '
        'Etiqueta8
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance40
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(38, 43)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta8.TabIndex = 2
        Me.Etiqueta8.Text = "Origen:"
        '
        'Etiqueta17
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance41
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(34, 70)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta17.TabIndex = 4
        Me.Etiqueta17.Text = "Destino:"
        '
        'cboOrigen
        '
        Appearance42.ForeColor = System.Drawing.Color.Black
        Me.cboOrigen.Appearance = Appearance42
        Me.cboOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboOrigen.Location = New System.Drawing.Point(84, 39)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(304, 21)
        Me.cboOrigen.TabIndex = 3
        Me.cboOrigen.ValueMember = "Id"
        '
        'cboDestino
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.cboDestino.Appearance = Appearance43
        Me.cboDestino.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestino.ForeColor = System.Drawing.Color.Black
        Me.cboDestino.Location = New System.Drawing.Point(84, 66)
        Me.cboDestino.Name = "cboDestino"
        Me.cboDestino.Size = New System.Drawing.Size(304, 21)
        Me.cboDestino.TabIndex = 5
        Me.cboDestino.ValueMember = "Id"
        '
        'cboTipoVehiculo
        '
        Appearance44.ForeColor = System.Drawing.Color.Black
        Me.cboTipoVehiculo.Appearance = Appearance44
        Me.cboTipoVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoVehiculo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoVehiculo.ForeColor = System.Drawing.Color.Black
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(84, 12)
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(304, 21)
        Me.cboTipoVehiculo.TabIndex = 1
        Me.cboTipoVehiculo.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance45
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(7, 16)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "TipoVehiculo:"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion9)
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion8)
        Me.UltraTabPageControl4.Enabled = False
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1221, 372)
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.griImportarMontos)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 64)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(1221, 308)
        Me.Agrupacion9.TabIndex = 1
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griImportarMontos
        '
        Me.griImportarMontos.DataSource = Me.odMontoRuta
        UltraGridColumn91.Header.VisiblePosition = 0
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 1
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 2
        UltraGridColumn93.Width = 99
        UltraGridColumn94.Header.VisiblePosition = 3
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 4
        UltraGridColumn95.Width = 215
        UltraGridColumn96.Header.VisiblePosition = 5
        UltraGridColumn96.Width = 197
        UltraGridColumn97.Header.Caption = "Cargado"
        UltraGridColumn97.Header.VisiblePosition = 6
        Appearance46.TextHAlignAsString = "Right"
        UltraGridColumn98.CellAppearance = Appearance46
        UltraGridColumn98.Header.VisiblePosition = 7
        UltraGridColumn98.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn98.Width = 68
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn99.CellAppearance = Appearance47
        UltraGridColumn99.Header.Caption = "MontoAcom."
        UltraGridColumn99.Header.VisiblePosition = 8
        UltraGridColumn99.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn100.CellAppearance = Appearance48
        UltraGridColumn100.Header.Caption = "% Copiloto"
        UltraGridColumn100.Header.VisiblePosition = 9
        UltraGridColumn100.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance49.TextHAlignAsString = "Center"
        UltraGridColumn101.CellAppearance = Appearance49
        UltraGridColumn101.Header.VisiblePosition = 11
        UltraGridColumn101.Hidden = True
        UltraGridColumn101.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn102.Header.VisiblePosition = 10
        UltraGridColumn102.Hidden = True
        UltraGridColumn102.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn103.Header.VisiblePosition = 12
        UltraGridColumn103.Hidden = True
        UltraGridColumn103.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn104.Header.VisiblePosition = 15
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 13
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 14
        UltraGridColumn106.Hidden = True
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance50
        UltraGridColumn25.Header.VisiblePosition = 16
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance51.TextHAlignAsString = "Right"
        UltraGridColumn27.CellAppearance = Appearance51
        UltraGridColumn27.Header.Caption = "CruceroPiloto"
        UltraGridColumn27.Header.VisiblePosition = 17
        UltraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance52.TextHAlignAsString = "Right"
        UltraGridColumn37.CellAppearance = Appearance52
        UltraGridColumn37.Header.Caption = "CruceroCopiloto"
        UltraGridColumn37.Header.VisiblePosition = 18
        UltraGridColumn37.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance53.TextHAlignAsString = "Right"
        UltraGridColumn44.CellAppearance = Appearance53
        UltraGridColumn44.Header.VisiblePosition = 19
        UltraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn44.Width = 47
        UltraGridColumn47.Header.Caption = "Nacional"
        UltraGridColumn47.Header.VisiblePosition = 20
        UltraGridColumn47.Width = 50
        UltraGridColumn50.Header.VisiblePosition = 21
        UltraGridColumn50.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn25, UltraGridColumn27, UltraGridColumn37, UltraGridColumn44, UltraGridColumn47, UltraGridColumn50})
        Me.griImportarMontos.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griImportarMontos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance54.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance54.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance54.BorderColor = System.Drawing.SystemColors.Window
        Me.griImportarMontos.DisplayLayout.GroupByBox.Appearance = Appearance54
        Appearance55.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griImportarMontos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance55
        Me.griImportarMontos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griImportarMontos.DisplayLayout.GroupByBox.Hidden = True
        Appearance56.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance56.BackColor2 = System.Drawing.SystemColors.Control
        Appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance56.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griImportarMontos.DisplayLayout.GroupByBox.PromptAppearance = Appearance56
        Me.griImportarMontos.DisplayLayout.MaxColScrollRegions = 1
        Me.griImportarMontos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griImportarMontos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griImportarMontos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griImportarMontos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griImportarMontos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance57.BorderColor = System.Drawing.Color.Silver
        Me.griImportarMontos.DisplayLayout.Override.CellAppearance = Appearance57
        Me.griImportarMontos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griImportarMontos.DisplayLayout.Override.CellPadding = 0
        Me.griImportarMontos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griImportarMontos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griImportarMontos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griImportarMontos.DisplayLayout.Override.GroupByRowAppearance = Appearance58
        Appearance59.TextHAlignAsString = "Left"
        Me.griImportarMontos.DisplayLayout.Override.HeaderAppearance = Appearance59
        Me.griImportarMontos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance60.BorderColor = System.Drawing.Color.Silver
        Me.griImportarMontos.DisplayLayout.Override.RowAppearance = Appearance60
        Me.griImportarMontos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griImportarMontos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griImportarMontos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griImportarMontos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griImportarMontos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griImportarMontos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griImportarMontos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griImportarMontos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griImportarMontos.Location = New System.Drawing.Point(3, 3)
        Me.griImportarMontos.Name = "griImportarMontos"
        Me.griImportarMontos.Size = New System.Drawing.Size(1215, 302)
        Me.griImportarMontos.TabIndex = 14
        Me.griImportarMontos.TabStop = False
        Me.griImportarMontos.Text = "Grilla1"
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion8.Controls.Add(Me.colorDuplicado)
        Me.Agrupacion8.Controls.Add(Me.btnLimpiar)
        Me.Agrupacion8.Controls.Add(Me.btnVerificar)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion8.Controls.Add(Me.colorNoRegistrados)
        Me.Agrupacion8.Controls.Add(Me.btnImportar)
        Me.Agrupacion8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion8.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(1221, 64)
        Me.Agrupacion8.TabIndex = 0
        Me.Agrupacion8.Text = "Importar Montos"
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta18
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance61
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(419, 35)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta18.TabIndex = 38
        Me.Etiqueta18.Text = "Duplicadas:"
        '
        'colorDuplicado
        '
        Me.colorDuplicado.Color = System.Drawing.Color.Cyan
        Me.colorDuplicado.Location = New System.Drawing.Point(487, 32)
        Me.colorDuplicado.Name = "colorDuplicado"
        Me.colorDuplicado.Size = New System.Drawing.Size(44, 21)
        Me.colorDuplicado.TabIndex = 37
        Me.colorDuplicado.Text = "Cyan"
        '
        'btnLimpiar
        '
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Appearance62.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnLimpiar.Appearance = Appearance62
        Me.btnLimpiar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLimpiar.Location = New System.Drawing.Point(187, 27)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(84, 30)
        Me.btnLimpiar.TabIndex = 36
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnVerificar
        '
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Appearance63.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnVerificar.Appearance = Appearance63
        Me.btnVerificar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnVerificar.Location = New System.Drawing.Point(97, 27)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(84, 30)
        Me.btnVerificar.TabIndex = 35
        Me.btnVerificar.Text = "Verificar"
        '
        'Etiqueta13
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance64
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(281, 35)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(82, 14)
        Me.Etiqueta13.TabIndex = 34
        Me.Etiqueta13.Text = "Rutas Inactivas:"
        '
        'colorNoRegistrados
        '
        Me.colorNoRegistrados.Color = System.Drawing.Color.Magenta
        Me.colorNoRegistrados.Location = New System.Drawing.Point(369, 32)
        Me.colorNoRegistrados.Name = "colorNoRegistrados"
        Me.colorNoRegistrados.Size = New System.Drawing.Size(44, 21)
        Me.colorNoRegistrados.TabIndex = 21
        Me.colorNoRegistrados.Text = "Magenta"
        '
        'btnImportar
        '
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Appearance65.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.btnImportar.Appearance = Appearance65
        Me.btnImportar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnImportar.Location = New System.Drawing.Point(7, 27)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(84, 30)
        Me.btnImportar.TabIndex = 20
        Me.btnImportar.Text = "Importar"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1229, 401)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1229, 401)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.griMontoRutas)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(3, 114)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1223, 284)
        Me.Agrupacion3.TabIndex = 1
        Me.Agrupacion3.Text = "Lista"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griMontoRutas
        '
        Me.griMontoRutas.ContextMenuStrip = Me.mnuMontoRuta
        Me.griMontoRutas.DataSource = Me.odMontoRuta
        UltraGridColumn75.Header.VisiblePosition = 0
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 1
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 2
        UltraGridColumn77.Width = 101
        UltraGridColumn78.Header.VisiblePosition = 3
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 4
        UltraGridColumn79.Width = 232
        UltraGridColumn80.Header.VisiblePosition = 5
        UltraGridColumn80.Width = 205
        UltraGridColumn81.Header.Caption = "Cargado"
        UltraGridColumn81.Header.VisiblePosition = 6
        UltraGridColumn81.Width = 52
        Appearance66.TextHAlignAsString = "Right"
        UltraGridColumn82.CellAppearance = Appearance66
        UltraGridColumn82.Header.VisiblePosition = 7
        UltraGridColumn82.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn82.Width = 70
        Appearance67.TextHAlignAsString = "Right"
        UltraGridColumn83.CellAppearance = Appearance67
        UltraGridColumn83.Header.Caption = "MontoAcom."
        UltraGridColumn83.Header.VisiblePosition = 8
        UltraGridColumn83.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance68.TextHAlignAsString = "Right"
        UltraGridColumn84.CellAppearance = Appearance68
        UltraGridColumn84.Header.Caption = "% Copiloto"
        UltraGridColumn84.Header.VisiblePosition = 9
        UltraGridColumn84.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance69.TextHAlignAsString = "Center"
        UltraGridColumn85.CellAppearance = Appearance69
        UltraGridColumn85.Header.Caption = "% Ayudante"
        UltraGridColumn85.Header.VisiblePosition = 10
        UltraGridColumn85.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn86.Header.VisiblePosition = 11
        UltraGridColumn86.Hidden = True
        UltraGridColumn86.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn87.Header.VisiblePosition = 12
        UltraGridColumn87.Hidden = True
        UltraGridColumn87.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn88.Header.VisiblePosition = 15
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 13
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 14
        UltraGridColumn90.Hidden = True
        Appearance70.TextHAlignAsString = "Right"
        UltraGridColumn26.CellAppearance = Appearance70
        UltraGridColumn26.Header.VisiblePosition = 16
        UltraGridColumn26.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance71.TextHAlignAsString = "Right"
        UltraGridColumn40.CellAppearance = Appearance71
        UltraGridColumn40.Header.Caption = "CruceroPiloto"
        UltraGridColumn40.Header.VisiblePosition = 17
        UltraGridColumn40.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance72.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance72
        UltraGridColumn41.Header.Caption = "CruceroCopiloto"
        UltraGridColumn41.Header.VisiblePosition = 18
        UltraGridColumn41.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance73.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance73
        UltraGridColumn45.Header.VisiblePosition = 19
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn45.Width = 48
        UltraGridColumn48.Header.Caption = "Nacional"
        UltraGridColumn48.Header.VisiblePosition = 20
        UltraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn48.Width = 52
        UltraGridColumn51.Header.VisiblePosition = 21
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn26, UltraGridColumn40, UltraGridColumn41, UltraGridColumn45, UltraGridColumn48, UltraGridColumn51})
        Me.griMontoRutas.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griMontoRutas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance74.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance74.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance74.BorderColor = System.Drawing.SystemColors.Window
        Me.griMontoRutas.DisplayLayout.GroupByBox.Appearance = Appearance74
        Appearance75.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griMontoRutas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance75
        Me.griMontoRutas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griMontoRutas.DisplayLayout.GroupByBox.Hidden = True
        Appearance76.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance76.BackColor2 = System.Drawing.SystemColors.Control
        Appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance76.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griMontoRutas.DisplayLayout.GroupByBox.PromptAppearance = Appearance76
        Me.griMontoRutas.DisplayLayout.MaxColScrollRegions = 1
        Me.griMontoRutas.DisplayLayout.MaxRowScrollRegions = 1
        Me.griMontoRutas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMontoRutas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMontoRutas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMontoRutas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance77.BorderColor = System.Drawing.Color.Silver
        Me.griMontoRutas.DisplayLayout.Override.CellAppearance = Appearance77
        Me.griMontoRutas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMontoRutas.DisplayLayout.Override.CellPadding = 0
        Me.griMontoRutas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMontoRutas.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griMontoRutas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance78.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griMontoRutas.DisplayLayout.Override.GroupByRowAppearance = Appearance78
        Appearance79.TextHAlignAsString = "Left"
        Me.griMontoRutas.DisplayLayout.Override.HeaderAppearance = Appearance79
        Me.griMontoRutas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance80.BorderColor = System.Drawing.Color.Silver
        Me.griMontoRutas.DisplayLayout.Override.RowAppearance = Appearance80
        Me.griMontoRutas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMontoRutas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMontoRutas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griMontoRutas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griMontoRutas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griMontoRutas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griMontoRutas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMontoRutas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMontoRutas.Location = New System.Drawing.Point(3, 16)
        Me.griMontoRutas.Name = "griMontoRutas"
        Me.griMontoRutas.Size = New System.Drawing.Size(1217, 265)
        Me.griMontoRutas.TabIndex = 0
        Me.griMontoRutas.TabStop = False
        Me.griMontoRutas.Text = "Grilla1"
        '
        'mnuMontoRuta
        '
        Me.mnuMontoRuta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuNuevo, Me.ToolStripMenuEditar, Me.ToolStripMenuEliminar, Me.ToolStripMenuVigencia, Me.ToolStripMenuImportar})
        Me.mnuMontoRuta.Name = "ContextMenuStrip1"
        Me.mnuMontoRuta.Size = New System.Drawing.Size(165, 114)
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
        Me.ToolStripMenuVigencia.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.ToolStripMenuVigencia.Name = "ToolStripMenuVigencia"
        Me.ToolStripMenuVigencia.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuVigencia.Text = "CambiarVigencia"
        Me.ToolStripMenuVigencia.Visible = False
        '
        'ToolStripMenuImportar
        '
        Me.ToolStripMenuImportar.Enabled = False
        Me.ToolStripMenuImportar.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.ToolStripMenuImportar.Name = "ToolStripMenuImportar"
        Me.ToolStripMenuImportar.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuImportar.Text = "Importar"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.Agrupacion7)
        Me.Agrupacion2.Controls.Add(Me.rdbFechas)
        Me.Agrupacion2.Controls.Add(Me.agrFechas)
        Me.Agrupacion2.Controls.Add(Me.rdbDatosAdicionales)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(3, 3)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1223, 111)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.rdbVacios)
        Me.Agrupacion7.Controls.Add(Me.rdbCargados)
        Me.Agrupacion7.Controls.Add(Me.rdbTodos)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion7.Controls.Add(Me.cboRuta)
        Me.Agrupacion7.Controls.Add(Me.cboTipoFiltro)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion7.Location = New System.Drawing.Point(180, 39)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(630, 63)
        Me.Agrupacion7.TabIndex = 3
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rdbVacios
        '
        Me.rdbVacios.AutoSize = True
        Me.rdbVacios.BackColor = System.Drawing.Color.Transparent
        Me.rdbVacios.ForeColor = System.Drawing.Color.Navy
        Me.rdbVacios.Location = New System.Drawing.Point(541, 37)
        Me.rdbVacios.Name = "rdbVacios"
        Me.rdbVacios.Size = New System.Drawing.Size(57, 17)
        Me.rdbVacios.TabIndex = 6
        Me.rdbVacios.Text = "Vacios"
        Me.rdbVacios.UseVisualStyleBackColor = False
        '
        'rdbCargados
        '
        Me.rdbCargados.AutoSize = True
        Me.rdbCargados.BackColor = System.Drawing.Color.Transparent
        Me.rdbCargados.ForeColor = System.Drawing.Color.Navy
        Me.rdbCargados.Location = New System.Drawing.Point(447, 36)
        Me.rdbCargados.Name = "rdbCargados"
        Me.rdbCargados.Size = New System.Drawing.Size(70, 17)
        Me.rdbCargados.TabIndex = 5
        Me.rdbCargados.Text = "Cargados"
        Me.rdbCargados.UseVisualStyleBackColor = False
        '
        'rdbTodos
        '
        Me.rdbTodos.AutoSize = True
        Me.rdbTodos.BackColor = System.Drawing.Color.Transparent
        Me.rdbTodos.Checked = True
        Me.rdbTodos.ForeColor = System.Drawing.Color.Navy
        Me.rdbTodos.Location = New System.Drawing.Point(370, 36)
        Me.rdbTodos.Name = "rdbTodos"
        Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rdbTodos.TabIndex = 4
        Me.rdbTodos.TabStop = True
        Me.rdbTodos.Text = "Todos"
        Me.rdbTodos.UseVisualStyleBackColor = False
        '
        'Etiqueta9
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance81
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(51, 11)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(30, 14)
        Me.Etiqueta9.TabIndex = 0
        Me.Etiqueta9.Text = "Ruta:"
        '
        'cboRuta
        '
        Appearance82.ForeColor = System.Drawing.Color.Black
        Me.cboRuta.Appearance = Appearance82
        Me.cboRuta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboRuta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRuta.ForeColor = System.Drawing.Color.Black
        Me.cboRuta.Location = New System.Drawing.Point(88, 7)
        Me.cboRuta.Name = "cboRuta"
        Me.cboRuta.Size = New System.Drawing.Size(510, 21)
        Me.cboRuta.TabIndex = 1
        Me.cboRuta.ValueMember = "Id"
        '
        'cboTipoFiltro
        '
        Appearance83.ForeColor = System.Drawing.Color.Black
        Me.cboTipoFiltro.Appearance = Appearance83
        Me.cboTipoFiltro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoFiltro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoFiltro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoFiltro.ForeColor = System.Drawing.Color.Black
        Me.cboTipoFiltro.Location = New System.Drawing.Point(88, 33)
        Me.cboTipoFiltro.Name = "cboTipoFiltro"
        Me.cboTipoFiltro.Size = New System.Drawing.Size(186, 21)
        Me.cboTipoFiltro.TabIndex = 3
        Me.cboTipoFiltro.ValueMember = "Id"
        '
        'Etiqueta11
        '
        Appearance84.BackColor = System.Drawing.Color.Transparent
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance84
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(10, 37)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta11.TabIndex = 2
        Me.Etiqueta11.Text = "TipoVehiculo:"
        '
        'rdbFechas
        '
        Me.rdbFechas.AutoSize = True
        Me.rdbFechas.BackColor = System.Drawing.Color.Transparent
        Me.rdbFechas.ForeColor = System.Drawing.Color.Navy
        Me.rdbFechas.Location = New System.Drawing.Point(8, 22)
        Me.rdbFechas.Name = "rdbFechas"
        Me.rdbFechas.Size = New System.Drawing.Size(60, 17)
        Me.rdbFechas.TabIndex = 0
        Me.rdbFechas.Text = "Fechas"
        Me.rdbFechas.UseVisualStyleBackColor = False
        '
        'agrFechas
        '
        Me.agrFechas.Controls.Add(Me.Etiqueta1)
        Me.agrFechas.Controls.Add(Me.fecDesde)
        Me.agrFechas.Controls.Add(Me.fecHasta)
        Me.agrFechas.Controls.Add(Me.Etiqueta2)
        Me.agrFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFechas.ForeColor = System.Drawing.Color.Black
        Me.agrFechas.Location = New System.Drawing.Point(8, 39)
        Me.agrFechas.Name = "agrFechas"
        Me.agrFechas.Size = New System.Drawing.Size(166, 63)
        Me.agrFechas.TabIndex = 1
        Me.agrFechas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta1
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance85
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(6, 11)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Desde:"
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(51, 8)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(104, 20)
        Me.fecDesde.TabIndex = 1
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(51, 33)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(104, 20)
        Me.fecHasta.TabIndex = 3
        '
        'Etiqueta2
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance86
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(6, 36)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Hasta:"
        '
        'rdbDatosAdicionales
        '
        Me.rdbDatosAdicionales.AutoSize = True
        Me.rdbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rdbDatosAdicionales.Checked = True
        Me.rdbDatosAdicionales.ForeColor = System.Drawing.Color.Navy
        Me.rdbDatosAdicionales.Location = New System.Drawing.Point(180, 22)
        Me.rdbDatosAdicionales.Name = "rdbDatosAdicionales"
        Me.rdbDatosAdicionales.Size = New System.Drawing.Size(110, 17)
        Me.rdbDatosAdicionales.TabIndex = 2
        Me.rdbDatosAdicionales.TabStop = True
        Me.rdbDatosAdicionales.Text = "Datos Adicionales"
        Me.rdbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1229, 401)
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.ficMantenimiento)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1229, 401)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficMantenimiento
        '
        Me.ficMantenimiento.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficMantenimiento.Controls.Add(Me.UltraTabPageControl3)
        Me.ficMantenimiento.Controls.Add(Me.UltraTabPageControl4)
        Me.ficMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMantenimiento.Location = New System.Drawing.Point(3, 3)
        Me.ficMantenimiento.Name = "ficMantenimiento"
        Me.ficMantenimiento.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficMantenimiento.Size = New System.Drawing.Size(1223, 395)
        Me.ficMantenimiento.TabIndex = 0
        UltraTab5.TabPage = Me.UltraTabPageControl3
        UltraTab5.Text = "Nuevo"
        UltraTab6.TabPage = Me.UltraTabPageControl4
        UltraTab6.Text = "Importar"
        UltraTab6.Visible = False
        Me.ficMantenimiento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        Me.ficMantenimiento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1221, 372)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ficMontoRuta
        '
        Me.ficMontoRuta.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficMontoRuta.Controls.Add(Me.UltraTabPageControl1)
        Me.ficMontoRuta.Controls.Add(Me.UltraTabPageControl2)
        Me.ficMontoRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMontoRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMontoRuta.Location = New System.Drawing.Point(0, 0)
        Me.ficMontoRuta.Name = "ficMontoRuta"
        Me.ficMontoRuta.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficMontoRuta.Size = New System.Drawing.Size(1231, 424)
        Me.ficMontoRuta.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficMontoRuta.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficMontoRuta.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1229, 401)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(417, 178)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 2
        Me.ugb_Espera.Visible = False
        '
        'frm_MontoRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 424)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficMontoRuta)
        Me.Name = "frm_MontoRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monto Ruta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.Grilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        CType(Me.griHistorialMontoRutas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMontoRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.ficHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficHistorial.ResumeLayout(False)
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.numCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCruceroP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCruceroC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBonoSolo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPorcentajeCopi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPorcentajeAyu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMontoAcompañado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMontoSolo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        CType(Me.griImportarMontos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        Me.Agrupacion8.PerformLayout()
        CType(Me.colorDuplicado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorNoRegistrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.griMontoRutas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMontoRuta.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFechas.ResumeLayout(False)
        Me.agrFechas.PerformLayout()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.ficMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMantenimiento.ResumeLayout(False)
        CType(Me.ficMontoRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMontoRuta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficMontoRuta As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents griMontoRutas As ISL.Controles.Grilla
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents rdbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents odMontoRuta As ISL.Controles.OrigenDatos
    Private WithEvents mnuMontoRuta As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuVigencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents ficMantenimiento As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents cboOrigen As ISL.Controles.Combo
    Friend WithEvents cboDestino As ISL.Controles.Combo
    Friend WithEvents cboTipoVehiculo As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ficHistorial As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grilla1 As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents griHistorialMontoRutas As ISL.Controles.Grilla
    Friend WithEvents numPorcentajeCopi As ISL.Controles.NumeroDecimal
    Friend WithEvents numPorcentajeAyu As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents numMontoAcompañado As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents numMontoSolo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents rdbVacio As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCargado As System.Windows.Forms.RadioButton
    Friend WithEvents btnQuitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents rdbFechas As System.Windows.Forms.RadioButton
    Friend WithEvents agrFechas As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents cboRuta As ISL.Controles.Combo
    Friend WithEvents cboTipoFiltro As ISL.Controles.Combo
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents griImportarMontos As ISL.Controles.Grilla
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents ToolStripMenuImportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnImportar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents colorNoRegistrados As ISL.Controles.Colores
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents rdbVacios As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCargados As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents btnVerificar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents numCruceroP As ISL.Controles.NumeroDecimal
    Friend WithEvents numCruceroC As ISL.Controles.NumeroDecimal
    Friend WithEvents numBonoSolo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents numCuenta As ISL.Controles.NumeroEntero
    Friend WithEvents chkIndNacional As System.Windows.Forms.CheckBox
    Friend WithEvents btnLimpiar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chkIndCategoria As System.Windows.Forms.CheckBox
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents colorDuplicado As ISL.Controles.Colores
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
