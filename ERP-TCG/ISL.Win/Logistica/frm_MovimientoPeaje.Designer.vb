<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MovimientoPeaje
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
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroTarjeta")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresado")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoOperacion")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroTarjeta")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresa")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Empresa")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIngresado")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoOperacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MovimientoPeaje))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroTarjeta")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresado")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoOperacion")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModeloTracto")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoOperacion")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modelo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROrigen")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RDestino")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grifo")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LugTanqueo")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueo")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGls")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KM")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cons")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dist")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rend")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rutas")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pesos")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RendEsperado")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlsEsperado")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desviacion")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresado")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModif")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModif")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqOrigen")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqDestino")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoOperacion")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROrigen")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RDestino")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grifo")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LugTanqueo")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KM")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueo")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGls")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cons")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dist")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rend")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rutas")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pesos")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RendEsperado")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlsEsperado")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desviacion")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresado")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModif")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModif")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqOrigen")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqDestino")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 2")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 2", 1)
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoOperacion")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROrigen")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RDestino")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grifo")
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LugTanqueo")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kilometraje")
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueo")
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGls")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cons")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dist")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rend")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rutas")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pesos")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RendEsperado")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlsEsperado")
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desviacion")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresado")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModif")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModif")
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqOrigen")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqDestino")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataBand2 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVale")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaTanqueo")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoOperacion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ROrigen")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RDestino")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaGrifo")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Grifo")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LugTanqueo")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Kilometraje")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTanqueo")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadGls")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cons")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dist")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rend")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rutas")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pesos")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RendEsperado")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlsEsperado")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Desviacion")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIngresado")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModif")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModif")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqOrigen")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqDestino")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodViaje")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaViaje")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoOperacion")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ROrigen")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RDestino")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaGrifo")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Grifo")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LugTanqueo")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KM")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTanqueo")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadGls")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cons")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dist")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rend")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rutas")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pesos")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RendEsperado")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlsEsperado")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Desviacion")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIngresado")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModif")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModif")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqOrigen")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqDestino")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModeloTracto")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoOperacion")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modelo")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ROrigen")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RDestino")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaGrifo")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Grifo")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LugTanqueo")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTanqueo")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadGls")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KM")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cons")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dist")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rend")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rutas")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pesos")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RendEsperado")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlsEsperado")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Desviacion")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIngresado")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModif")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModif")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqOrigen")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqDestino")
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KilometrosTanqueo")
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGalon")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccion")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCredito")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueo")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegistroInventario")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoGls")
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrifo")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaVeh")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMaterial")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomGrifo")
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomDireccion")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomLugar")
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueoNoAsoc")
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIsl")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodViaje")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaTanqueo")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KilometrosTanqueo")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadGalon")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVale")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaGrifo")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDireccion")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCredito")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTanqueo")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRegistroInventario")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoGls")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn184 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn185 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn186 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn187 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn188 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGrifo")
        Dim UltraDataColumn189 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlacaVeh")
        Dim UltraDataColumn190 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn191 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodMaterial")
        Dim UltraDataColumn192 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn193 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn194 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaViaje")
        Dim UltraDataColumn195 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NomGrifo")
        Dim UltraDataColumn196 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NomDireccion")
        Dim UltraDataColumn197 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NomLugar")
        Dim UltraDataColumn198 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTanqueoNoAsoc")
        Dim UltraDataColumn199 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn200 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIsl")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroTarjeta")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresado")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoOperacion")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn201 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn202 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn203 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn204 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn205 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn206 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn207 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn208 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn209 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn210 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn211 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn212 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn213 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn214 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn215 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn216 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn217 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn218 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn219 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn220 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn221 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn222 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn223 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn224 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn225 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn226 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn227 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn228 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn229 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn230 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn231 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn232 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn233 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn234 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn235 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn236 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraDataColumn237 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn238 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn239 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn240 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn241 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn242 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn243 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn244 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn245 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn246 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn247 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn248 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn249 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn250 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn251 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn252 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn253 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn254 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn255 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn256 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn257 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn258 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn259 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn260 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn261 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn262 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn263 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn264 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn265 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn266 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn267 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn268 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn269 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn270 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn271 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraDataColumn272 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn273 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn274 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn275 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdItemGasto")
        Dim UltraDataColumn276 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn277 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn278 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn279 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn280 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn281 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis1")
        Dim UltraDataColumn282 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis2")
        Dim UltraDataColumn283 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn284 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn285 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn286 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn287 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn288 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn289 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn290 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn291 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vehiculo")
        Dim UltraDataColumn292 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn293 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaContable")
        Dim UltraDataColumn294 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn295 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn296 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoFuncion")
        Dim UltraDataColumn297 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoAsiento")
        Dim UltraDataColumn298 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsiento")
        Dim UltraDataColumn299 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn300 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn301 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigenProrrateo")
        Dim UltraDataColumn302 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn303 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn304 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn305 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn306 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn307 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn308 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn309 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega")
        Dim UltraDataColumn310 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn311 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn312 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn313 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn314 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn315 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn316 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemandaDetalle")
        Dim UltraDataColumn317 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn318 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn319 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn320 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn321 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn322 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasCarga")
        Dim UltraDataColumn323 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasDescarga")
        Dim UltraDataColumn324 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn325 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cargar")
        Dim UltraDataColumn326 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descarga")
        Dim UltraDataColumn327 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPesoTnDescarga")
        Dim UltraDataColumn328 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn329 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn330 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn331 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn332 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn333 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClienteFinal")
        Dim UltraDataColumn334 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoEstiba")
        Dim UltraDataColumn335 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoEstibaDescarga")
        Dim UltraDataColumn336 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AdelantoFlete")
        Dim UltraDataColumn337 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgvConsolidado")
        Dim UltraDataColumn338 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoEfectivoDeposito")
        Dim UltraDataColumn339 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FalsoFlete")
        Dim UltraDataColumn340 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MotivoConsolidado")
        Dim UltraDataColumn341 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn342 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn343 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn344 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn345 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn346 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn347 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn348 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn349 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn350 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn351 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn352 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn353 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn354 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn355 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn356 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn357 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn358 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn359 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn360 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn361 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn362 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn363 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn364 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn365 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn366 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn367 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn368 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn369 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn370 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn371 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn372 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Espera2 = New ISL.Win.Espere()
        Me.griMovimientoPeajeImportar = New ISL.Controles.Grilla(Me.components)
        Me.odMovimientoPeaje = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New ISL.Controles.Boton(Me.components)
        Me.btnValidar = New ISL.Controles.Boton(Me.components)
        Me.btnBuscar = New Infragistics.Win.Misc.UltraButton()
        Me.btnGuardar = New ISL.Controles.Boton(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griMovPeajeCovisol = New ISL.Controles.Grilla(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpHastaCovisol = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesdeCovisol = New System.Windows.Forms.DateTimePicker()
        Me.btnNuevoCovisol = New ISL.Controles.Boton(Me.components)
        Me.btnValidarCovisol = New ISL.Controles.Boton(Me.components)
        Me.btnBuscarCovisol = New Infragistics.Win.Misc.UltraButton()
        Me.btnGuardarCovisol = New ISL.Controles.Boton(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOrdenesdeTransferencia = New ISL.Controles.Agrupacion(Me.components)
        Me.ugb_Espera3 = New ISL.Win.Espere()
        Me.grid_ListaAsociaMP = New ISL.Controles.Grilla(Me.components)
        Me.odRegConsumoCombustible = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.lblExpande = New Infragistics.Win.Misc.UltraLabel()
        Me.btnExpande1 = New ISL.Controles.Boton(Me.components)
        Me.btnExpande2 = New ISL.Controles.Boton(Me.components)
        Me.btnExpande3 = New ISL.Controles.Boton(Me.components)
        Me.gbTanqueosNoAsociados = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btn_ListarTanqNoAsoc = New Infragistics.Win.Misc.UltraButton()
        Me.grid_ListaMPnoAsoc = New ISL.Controles.Grilla(Me.components)
        Me.odTanqueosNoAsociados = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridListaMovimientoPeaje = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tcComprobanteDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColorMontoIncorrecto = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.grupoDetalle = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta34 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuenta = New ISL.Controles.Combo(Me.components)
        Me.cboGastonFuncion = New ISL.Controles.Combo(Me.components)
        Me.cboItemGasto = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.grupoCabeceraAsiento = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.dtpFechaEjercicio = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cbeCtaCte = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboTipoDocumento = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoCompra = New ISL.Controles.Combo(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficConCombustible = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.gbeConsultar = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.ChkSeleccion = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grFiltro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboTractoLista = New ISL.Controles.Combo(Me.components)
        Me.grupoEstado = New ISL.Controles.Agrupacion(Me.components)
        Me.ColorReembolsado = New ISL.Controles.Colores(Me.components)
        Me.ColorPendiente = New ISL.Controles.Colores(Me.components)
        Me.ColorHabilitada = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorLiquidada = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorNoReembolsado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.lblVehi = New ISL.Controles.Etiqueta(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rfHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.EMovimientoDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraDataSource4 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ogdOperacionDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tcComprobanteCompra = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f = New ISL.Controles.NumeroEntero(Me.components)
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53 = New ISL.Controles.NumeroEntero(Me.components)
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero3 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero4 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero5 = New ISL.Controles.NumeroEntero(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LstDetalleDocumentoCombustibleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griMovimientoPeajeImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMovimientoPeaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griMovPeajeCovisol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.agrOrdenesdeTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOrdenesdeTransferencia.SuspendLayout()
        CType(Me.grid_ListaAsociaMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odRegConsumoCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.gbTanqueosNoAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTanqueosNoAsociados.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.grid_ListaMPnoAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odTanqueosNoAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.gridListaMovimientoPeaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.tcComprobanteDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcComprobanteDetalle.SuspendLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.ColorMontoIncorrecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDetalle.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGastonFuncion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoCabeceraAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoCabeceraAsiento.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbeCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.ficConCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficConCombustible.SuspendLayout()
        CType(Me.gbeConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeConsultar.SuspendLayout()
        Me.ChkSeleccion.SuspendLayout()
        CType(Me.grFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grFiltro.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoEstado.SuspendLayout()
        CType(Me.ColorReembolsado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorHabilitada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorLiquidada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorNoReembolsado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMovimientoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcComprobanteCompra.SuspendLayout()
        CType(Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_dad2a13d_427e_4777_870d_044a3363ce53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LstDetalleDocumentoCombustibleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griMovimientoPeajeImportar)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl3.Controls.Add(Me.ugb_Espera)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1237, 497)
        '
        'ugb_Espera2
        '
        Me.ugb_Espera2.Location = New System.Drawing.Point(406, 96)
        Me.ugb_Espera2.Name = "ugb_Espera2"
        Me.ugb_Espera2.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera2.TabIndex = 18
        Me.ugb_Espera2.Visible = False
        '
        'griMovimientoPeajeImportar
        '
        Me.griMovimientoPeajeImportar.DataSource = Me.odMovimientoPeaje
        UltraGridColumn33.Header.VisiblePosition = 2
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.Width = 110
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Width = 110
        UltraGridColumn63.Header.VisiblePosition = 1
        UltraGridColumn63.Width = 80
        UltraGridColumn65.Header.VisiblePosition = 3
        UltraGridColumn65.Width = 45
        UltraGridColumn72.Header.VisiblePosition = 4
        UltraGridColumn72.Width = 90
        UltraGridColumn73.Header.VisiblePosition = 5
        UltraGridColumn73.Width = 60
        UltraGridColumn74.Header.VisiblePosition = 6
        UltraGridColumn74.Width = 100
        UltraGridColumn75.Header.VisiblePosition = 7
        UltraGridColumn75.Hidden = True
        UltraGridColumn75.Width = 110
        UltraGridColumn76.Header.VisiblePosition = 9
        UltraGridColumn76.Width = 240
        UltraGridColumn77.Header.VisiblePosition = 8
        UltraGridColumn77.Hidden = True
        UltraGridColumn77.Width = 110
        UltraGridColumn78.Header.VisiblePosition = 10
        UltraGridColumn78.Width = 60
        UltraGridColumn79.Header.VisiblePosition = 11
        UltraGridColumn79.Width = 120
        UltraGridColumn80.Header.VisiblePosition = 12
        UltraGridColumn80.Hidden = True
        UltraGridColumn80.Width = 110
        UltraGridColumn81.Header.VisiblePosition = 13
        UltraGridColumn81.Width = 50
        UltraGridColumn82.Header.VisiblePosition = 14
        UltraGridColumn82.Hidden = True
        UltraGridColumn82.Width = 110
        UltraGridColumn83.Header.VisiblePosition = 18
        UltraGridColumn83.Hidden = True
        UltraGridColumn83.Width = 110
        UltraGridColumn84.Header.VisiblePosition = 15
        UltraGridColumn84.Hidden = True
        UltraGridColumn84.Width = 110
        UltraGridColumn85.Header.VisiblePosition = 17
        UltraGridColumn85.Hidden = True
        UltraGridColumn85.Width = 110
        UltraGridColumn86.Header.VisiblePosition = 19
        UltraGridColumn86.Hidden = True
        UltraGridColumn86.Width = 110
        UltraGridColumn87.Header.VisiblePosition = 16
        UltraGridColumn87.Hidden = True
        UltraGridColumn87.Width = 80
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn33, UltraGridColumn37, UltraGridColumn63, UltraGridColumn65, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87})
        Me.griMovimientoPeajeImportar.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griMovimientoPeajeImportar.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griMovimientoPeajeImportar.DisplayLayout.MaxColScrollRegions = 1
        Me.griMovimientoPeajeImportar.DisplayLayout.MaxRowScrollRegions = 1
        Me.griMovimientoPeajeImportar.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovimientoPeajeImportar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griMovimientoPeajeImportar.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMovimientoPeajeImportar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMovimientoPeajeImportar.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMovimientoPeajeImportar.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griMovimientoPeajeImportar.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMovimientoPeajeImportar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griMovimientoPeajeImportar.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMovimientoPeajeImportar.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMovimientoPeajeImportar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.griMovimientoPeajeImportar.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griMovimientoPeajeImportar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMovimientoPeajeImportar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMovimientoPeajeImportar.ImageList = Me.imagenes
        Me.griMovimientoPeajeImportar.Location = New System.Drawing.Point(0, 48)
        Me.griMovimientoPeajeImportar.Name = "griMovimientoPeajeImportar"
        Me.griMovimientoPeajeImportar.Size = New System.Drawing.Size(1237, 449)
        Me.griMovimientoPeajeImportar.TabIndex = 4
        Me.griMovimientoPeajeImportar.Text = "Comprobante Compra"
        '
        'odMovimientoPeaje
        '
        UltraDataColumn6.DataType = GetType(Double)
        Me.odMovimientoPeaje.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Controls.Add(Me.btnValidar)
        Me.Panel2.Controls.Add(Me.btnBuscar)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1237, 48)
        Me.Panel2.TabIndex = 19
        '
        'btnNuevo
        '
        Appearance1.Image = 4
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance1.TextHAlignAsString = "Left"
        Me.btnNuevo.Appearance = Appearance1
        Me.btnNuevo.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.ImageList = Me.imagenes
        Me.btnNuevo.Location = New System.Drawing.Point(262, 6)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(80, 30)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnValidar
        '
        Appearance2.Image = 8
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance2.TextHAlignAsString = "Left"
        Me.btnValidar.Appearance = Appearance2
        Me.btnValidar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValidar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.ForeColor = System.Drawing.Color.Black
        Me.btnValidar.ImageList = Me.imagenes
        Me.btnValidar.Location = New System.Drawing.Point(90, 6)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(80, 30)
        Me.btnValidar.TabIndex = 0
        Me.btnValidar.Text = "Validar"
        '
        'btnBuscar
        '
        Appearance3.Image = 10
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance3.TextHAlignAsString = "Left"
        Me.btnBuscar.Appearance = Appearance3
        Me.btnBuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ImageList = Me.imagenes
        Me.btnBuscar.Location = New System.Drawing.Point(4, 6)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(80, 30)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        '
        'btnGuardar
        '
        Appearance4.Image = 1
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance4.TextHAlignAsString = "Left"
        Me.btnGuardar.Appearance = Appearance4
        Me.btnGuardar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.ImageList = Me.imagenes
        Me.btnGuardar.Location = New System.Drawing.Point(176, 6)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 30)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(403, 3)
        Me.ugb_Espera.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(463, 68)
        Me.ugb_Espera.TabIndex = 3
        Me.ugb_Espera.Visible = False
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griMovPeajeCovisol)
        Me.UltraTabPageControl6.Controls.Add(Me.Panel1)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1237, 497)
        '
        'griMovPeajeCovisol
        '
        Me.griMovPeajeCovisol.DataSource = Me.odMovimientoPeaje
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.Width = 110
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn30.Width = 110
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn31.Width = 80
        UltraGridColumn34.Header.VisiblePosition = 3
        UltraGridColumn34.Width = 45
        UltraGridColumn35.Header.VisiblePosition = 4
        UltraGridColumn35.Width = 90
        UltraGridColumn36.Header.VisiblePosition = 5
        UltraGridColumn36.Width = 60
        UltraGridColumn38.Header.VisiblePosition = 6
        UltraGridColumn38.Width = 100
        UltraGridColumn49.Header.VisiblePosition = 7
        UltraGridColumn49.Hidden = True
        UltraGridColumn49.Width = 110
        UltraGridColumn51.Header.VisiblePosition = 9
        UltraGridColumn51.Width = 240
        UltraGridColumn58.Header.VisiblePosition = 8
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.Width = 110
        UltraGridColumn59.Header.VisiblePosition = 10
        UltraGridColumn59.Width = 60
        UltraGridColumn60.Header.VisiblePosition = 11
        UltraGridColumn60.Width = 120
        UltraGridColumn61.Header.VisiblePosition = 12
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.Width = 110
        UltraGridColumn62.Header.VisiblePosition = 13
        UltraGridColumn62.Width = 50
        UltraGridColumn64.Header.VisiblePosition = 14
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.Width = 110
        UltraGridColumn66.Header.VisiblePosition = 18
        UltraGridColumn66.Hidden = True
        UltraGridColumn66.Width = 110
        UltraGridColumn67.Header.VisiblePosition = 15
        UltraGridColumn67.Hidden = True
        UltraGridColumn67.Width = 110
        UltraGridColumn68.Header.VisiblePosition = 17
        UltraGridColumn68.Hidden = True
        UltraGridColumn68.Width = 110
        UltraGridColumn69.Header.VisiblePosition = 19
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.Width = 110
        UltraGridColumn70.Header.VisiblePosition = 16
        UltraGridColumn70.Hidden = True
        UltraGridColumn70.Width = 80
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn38, UltraGridColumn49, UltraGridColumn51, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn64, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70})
        Me.griMovPeajeCovisol.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griMovPeajeCovisol.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griMovPeajeCovisol.DisplayLayout.MaxColScrollRegions = 1
        Me.griMovPeajeCovisol.DisplayLayout.MaxRowScrollRegions = 1
        Me.griMovPeajeCovisol.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovPeajeCovisol.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griMovPeajeCovisol.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMovPeajeCovisol.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMovPeajeCovisol.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMovPeajeCovisol.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griMovPeajeCovisol.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMovPeajeCovisol.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griMovPeajeCovisol.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMovPeajeCovisol.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMovPeajeCovisol.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.griMovPeajeCovisol.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griMovPeajeCovisol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMovPeajeCovisol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMovPeajeCovisol.ImageList = Me.imagenes
        Me.griMovPeajeCovisol.Location = New System.Drawing.Point(0, 64)
        Me.griMovPeajeCovisol.Name = "griMovPeajeCovisol"
        Me.griMovPeajeCovisol.Size = New System.Drawing.Size(1237, 433)
        Me.griMovPeajeCovisol.TabIndex = 5
        Me.griMovPeajeCovisol.Text = "Comprobante Compra"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtpHastaCovisol)
        Me.Panel1.Controls.Add(Me.dtpDesdeCovisol)
        Me.Panel1.Controls.Add(Me.btnNuevoCovisol)
        Me.Panel1.Controls.Add(Me.btnValidarCovisol)
        Me.Panel1.Controls.Add(Me.btnBuscarCovisol)
        Me.Panel1.Controls.Add(Me.btnGuardarCovisol)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1237, 64)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(151, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Hasta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(9, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Desde:"
        '
        'dtpHastaCovisol
        '
        Me.dtpHastaCovisol.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHastaCovisol.Location = New System.Drawing.Point(190, 3)
        Me.dtpHastaCovisol.Name = "dtpHastaCovisol"
        Me.dtpHastaCovisol.Size = New System.Drawing.Size(98, 21)
        Me.dtpHastaCovisol.TabIndex = 9
        '
        'dtpDesdeCovisol
        '
        Me.dtpDesdeCovisol.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesdeCovisol.Location = New System.Drawing.Point(51, 3)
        Me.dtpDesdeCovisol.Name = "dtpDesdeCovisol"
        Me.dtpDesdeCovisol.Size = New System.Drawing.Size(98, 21)
        Me.dtpDesdeCovisol.TabIndex = 8
        '
        'btnNuevoCovisol
        '
        Appearance5.Image = 4
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance5.TextHAlignAsString = "Left"
        Me.btnNuevoCovisol.Appearance = Appearance5
        Me.btnNuevoCovisol.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnNuevoCovisol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoCovisol.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNuevoCovisol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCovisol.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoCovisol.ImageList = Me.imagenes
        Me.btnNuevoCovisol.Location = New System.Drawing.Point(260, 28)
        Me.btnNuevoCovisol.Name = "btnNuevoCovisol"
        Me.btnNuevoCovisol.Size = New System.Drawing.Size(80, 30)
        Me.btnNuevoCovisol.TabIndex = 6
        Me.btnNuevoCovisol.Text = "Nuevo"
        '
        'btnValidarCovisol
        '
        Appearance6.Image = 8
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance6.TextHAlignAsString = "Left"
        Me.btnValidarCovisol.Appearance = Appearance6
        Me.btnValidarCovisol.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnValidarCovisol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValidarCovisol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarCovisol.ForeColor = System.Drawing.Color.Black
        Me.btnValidarCovisol.ImageList = Me.imagenes
        Me.btnValidarCovisol.Location = New System.Drawing.Point(88, 28)
        Me.btnValidarCovisol.Name = "btnValidarCovisol"
        Me.btnValidarCovisol.Size = New System.Drawing.Size(80, 30)
        Me.btnValidarCovisol.TabIndex = 3
        Me.btnValidarCovisol.Text = "Validar"
        '
        'btnBuscarCovisol
        '
        Appearance7.Image = 10
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance7.TextHAlignAsString = "Left"
        Me.btnBuscarCovisol.Appearance = Appearance7
        Me.btnBuscarCovisol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCovisol.ImageList = Me.imagenes
        Me.btnBuscarCovisol.Location = New System.Drawing.Point(2, 28)
        Me.btnBuscarCovisol.Name = "btnBuscarCovisol"
        Me.btnBuscarCovisol.Size = New System.Drawing.Size(80, 30)
        Me.btnBuscarCovisol.TabIndex = 4
        Me.btnBuscarCovisol.Text = "Buscar"
        '
        'btnGuardarCovisol
        '
        Appearance8.Image = 1
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance8.TextHAlignAsString = "Left"
        Me.btnGuardarCovisol.Appearance = Appearance8
        Me.btnGuardarCovisol.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGuardarCovisol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarCovisol.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGuardarCovisol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCovisol.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarCovisol.ImageList = Me.imagenes
        Me.btnGuardarCovisol.Location = New System.Drawing.Point(174, 28)
        Me.btnGuardarCovisol.Name = "btnGuardarCovisol"
        Me.btnGuardarCovisol.Size = New System.Drawing.Size(80, 30)
        Me.btnGuardarCovisol.TabIndex = 5
        Me.btnGuardarCovisol.Text = "Guardar"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.agrOrdenesdeTransferencia)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1237, 597)
        '
        'agrOrdenesdeTransferencia
        '
        Me.agrOrdenesdeTransferencia.Controls.Add(Me.ugb_Espera3)
        Me.agrOrdenesdeTransferencia.Controls.Add(Me.grid_ListaAsociaMP)
        Me.agrOrdenesdeTransferencia.Controls.Add(Me.agrMenuLista)
        Me.agrOrdenesdeTransferencia.Controls.Add(Me.gbTanqueosNoAsociados)
        Me.agrOrdenesdeTransferencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOrdenesdeTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOrdenesdeTransferencia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrOrdenesdeTransferencia.Location = New System.Drawing.Point(0, 0)
        Me.agrOrdenesdeTransferencia.Name = "agrOrdenesdeTransferencia"
        Me.agrOrdenesdeTransferencia.Size = New System.Drawing.Size(1237, 597)
        Me.agrOrdenesdeTransferencia.TabIndex = 0
        Me.agrOrdenesdeTransferencia.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ugb_Espera3
        '
        Me.ugb_Espera3.Location = New System.Drawing.Point(312, 25)
        Me.ugb_Espera3.Name = "ugb_Espera3"
        Me.ugb_Espera3.Size = New System.Drawing.Size(396, 65)
        Me.ugb_Espera3.TabIndex = 19
        Me.ugb_Espera3.Visible = False
        '
        'grid_ListaAsociaMP
        '
        Me.grid_ListaAsociaMP.AllowDrop = True
        Me.grid_ListaAsociaMP.DataSource = Me.odRegConsumoCombustible
        Appearance9.TextVAlignAsString = "Middle"
        UltraGridColumn2.CellAppearance = Appearance9
        UltraGridColumn2.Header.Fixed = True
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 8
        Appearance10.TextVAlignAsString = "Middle"
        UltraGridColumn3.CellAppearance = Appearance10
        UltraGridColumn3.Header.Caption = "Placa/Viaje/NroVale"
        UltraGridColumn3.Header.Fixed = True
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Width = 110
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Center"
        Appearance11.TextVAlignAsString = "Middle"
        UltraGridColumn4.CellAppearance = Appearance11
        UltraGridColumn4.Header.Caption = "Marca/F. Viaje/ F. Tanqueo"
        UltraGridColumn4.Header.Fixed = True
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Width = 119
        Appearance12.TextVAlignAsString = "Middle"
        UltraGridColumn5.CellAppearance = Appearance12
        UltraGridColumn5.Header.VisiblePosition = 46
        UltraGridColumn5.Hidden = True
        Appearance13.TextVAlignAsString = "Middle"
        UltraGridColumn6.CellAppearance = Appearance13
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 80
        Appearance14.TextHAlignAsString = "Center"
        Appearance14.TextVAlignAsString = "Middle"
        UltraGridColumn7.CellAppearance = Appearance14
        UltraGridColumn7.Header.Caption = "Modelo/Carreta"
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Width = 80
        Appearance15.TextVAlignAsString = "Middle"
        UltraGridColumn8.CellAppearance = Appearance15
        UltraGridColumn8.Header.VisiblePosition = 5
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 60
        Appearance16.TextVAlignAsString = "Middle"
        UltraGridColumn9.CellAppearance = Appearance16
        UltraGridColumn9.Header.VisiblePosition = 6
        UltraGridColumn9.Width = 172
        Appearance17.TextVAlignAsString = "Middle"
        UltraGridColumn10.CellAppearance = Appearance17
        UltraGridColumn10.Header.VisiblePosition = 7
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 8
        Appearance18.TextVAlignAsString = "Middle"
        UltraGridColumn11.CellAppearance = Appearance18
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn11.Width = 173
        Appearance19.TextVAlignAsString = "Middle"
        UltraGridColumn12.CellAppearance = Appearance19
        UltraGridColumn12.Header.VisiblePosition = 9
        UltraGridColumn12.Width = 150
        Appearance20.TextVAlignAsString = "Middle"
        UltraGridColumn13.CellAppearance = Appearance20
        UltraGridColumn13.Header.VisiblePosition = 10
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Width = 8
        Appearance21.TextVAlignAsString = "Middle"
        UltraGridColumn14.CellAppearance = Appearance21
        UltraGridColumn14.Header.VisiblePosition = 11
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.Width = 8
        Appearance22.TextVAlignAsString = "Middle"
        UltraGridColumn15.CellAppearance = Appearance22
        UltraGridColumn15.Header.VisiblePosition = 12
        UltraGridColumn15.Width = 35
        Appearance23.TextVAlignAsString = "Middle"
        UltraGridColumn16.CellAppearance = Appearance23
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        Appearance24.TextVAlignAsString = "Middle"
        UltraGridColumn17.CellAppearance = Appearance24
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Width = 150
        Appearance25.TextVAlignAsString = "Middle"
        UltraGridColumn18.CellAppearance = Appearance25
        UltraGridColumn18.Header.VisiblePosition = 17
        Appearance26.TextVAlignAsString = "Middle"
        UltraGridColumn19.CellAppearance = Appearance26
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Width = 100
        Appearance27.TextVAlignAsString = "Middle"
        UltraGridColumn20.CellAppearance = Appearance27
        UltraGridColumn20.Header.Caption = "Full"
        UltraGridColumn20.Header.VisiblePosition = 20
        UltraGridColumn20.Width = 30
        Appearance28.TextVAlignAsString = "Middle"
        UltraGridColumn21.CellAppearance = Appearance28
        UltraGridColumn21.Header.Caption = "Gls"
        UltraGridColumn21.Header.VisiblePosition = 21
        UltraGridColumn21.Width = 65
        Appearance29.TextVAlignAsString = "Middle"
        UltraGridColumn22.CellAppearance = Appearance29
        UltraGridColumn22.Header.VisiblePosition = 22
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.Width = 63
        Appearance30.TextVAlignAsString = "Middle"
        UltraGridColumn23.CellAppearance = Appearance30
        UltraGridColumn23.Header.VisiblePosition = 23
        UltraGridColumn23.Width = 60
        Appearance31.BackColor = System.Drawing.Color.SkyBlue
        Appearance31.TextVAlignAsString = "Middle"
        UltraGridColumn24.CellAppearance = Appearance31
        UltraGridColumn24.Header.VisiblePosition = 19
        UltraGridColumn24.Width = 80
        Appearance32.TextVAlignAsString = "Middle"
        UltraGridColumn25.CellAppearance = Appearance32
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.Width = 81
        Appearance33.TextVAlignAsString = "Middle"
        UltraGridColumn26.CellAppearance = Appearance33
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.Width = 84
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance34.FontData.BoldAsString = "True"
        Appearance34.TextHAlignAsString = "Right"
        Appearance34.TextVAlignAsString = "Middle"
        UltraGridColumn27.CellAppearance = Appearance34
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Width = 45
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance35.FontData.BoldAsString = "True"
        Appearance35.TextHAlignAsString = "Right"
        Appearance35.TextVAlignAsString = "Middle"
        UltraGridColumn28.CellAppearance = Appearance35
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.Width = 45
        Appearance36.TextVAlignAsString = "Middle"
        UltraGridColumn32.CellAppearance = Appearance36
        UltraGridColumn32.Header.VisiblePosition = 28
        UltraGridColumn32.Width = 45
        Appearance37.TextVAlignAsString = "Middle"
        UltraGridColumn39.CellAppearance = Appearance37
        UltraGridColumn39.Header.Caption = "Metas"
        UltraGridColumn39.Header.VisiblePosition = 29
        UltraGridColumn39.Width = 150
        Appearance38.TextVAlignAsString = "Middle"
        UltraGridColumn40.CellAppearance = Appearance38
        UltraGridColumn40.Header.VisiblePosition = 30
        UltraGridColumn40.Width = 150
        Appearance39.TextVAlignAsString = "Middle"
        UltraGridColumn41.CellAppearance = Appearance39
        UltraGridColumn41.Header.VisiblePosition = 13
        UltraGridColumn41.Width = 220
        UltraGridColumn42.Header.Caption = "Carga"
        UltraGridColumn42.Header.VisiblePosition = 14
        UltraGridColumn42.Width = 125
        UltraGridColumn43.Header.VisiblePosition = 31
        UltraGridColumn43.Width = 50
        UltraGridColumn44.Header.VisiblePosition = 32
        UltraGridColumn44.Width = 50
        Appearance40.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance40.FontData.BoldAsString = "True"
        Appearance40.TextHAlignAsString = "Right"
        Appearance40.TextVAlignAsString = "Middle"
        UltraGridColumn45.CellAppearance = Appearance40
        UltraGridColumn45.Header.VisiblePosition = 33
        UltraGridColumn45.Width = 50
        UltraGridColumn46.Header.VisiblePosition = 34
        UltraGridColumn46.Width = 150
        UltraGridColumn47.Header.VisiblePosition = 35
        UltraGridColumn47.Width = 70
        UltraGridColumn48.Header.VisiblePosition = 36
        UltraGridColumn48.Width = 45
        UltraGridColumn50.Header.VisiblePosition = 37
        UltraGridColumn52.Header.Caption = "Usuario Crea"
        UltraGridColumn52.Header.VisiblePosition = 38
        UltraGridColumn52.Width = 70
        UltraGridColumn53.Header.Caption = "Fecha Crea"
        UltraGridColumn53.Header.VisiblePosition = 39
        UltraGridColumn53.Width = 100
        UltraGridColumn54.Header.Caption = "Usuario Modif"
        UltraGridColumn54.Header.VisiblePosition = 40
        UltraGridColumn54.Width = 70
        UltraGridColumn55.Header.Caption = "Fecha Modif"
        UltraGridColumn55.Header.VisiblePosition = 41
        UltraGridColumn55.Width = 100
        UltraGridColumn56.Header.VisiblePosition = 42
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 43
        UltraGridColumn57.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 44
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 45
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 47
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn32, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn50, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91})
        Appearance41.TextVAlignAsString = "Middle"
        UltraGridBand3.Header.Appearance = Appearance41
        UltraGridBand3.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Appearance42.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        UltraGridBand3.Override.RowAppearance = Appearance42
        UltraGridBand4.ColHeadersVisible = False
        Appearance43.TextVAlignAsString = "Middle"
        UltraGridColumn92.CellAppearance = Appearance43
        UltraGridColumn92.Header.Fixed = True
        UltraGridColumn92.Header.VisiblePosition = 2
        UltraGridColumn92.Hidden = True
        Appearance44.TextVAlignAsString = "Middle"
        UltraGridColumn93.CellAppearance = Appearance44
        UltraGridColumn93.Header.Fixed = True
        UltraGridColumn93.Header.VisiblePosition = 3
        UltraGridColumn93.Hidden = True
        Appearance45.BackColor = System.Drawing.Color.Khaki
        Appearance45.TextVAlignAsString = "Middle"
        UltraGridColumn94.CellAppearance = Appearance45
        UltraGridColumn94.Header.Fixed = True
        UltraGridColumn94.Header.VisiblePosition = 0
        UltraGridColumn94.Width = 91
        Appearance46.TextHAlignAsString = "Center"
        Appearance46.TextVAlignAsString = "Middle"
        UltraGridColumn95.CellAppearance = Appearance46
        UltraGridColumn95.Format = ""
        UltraGridColumn95.Header.Fixed = True
        UltraGridColumn95.Header.VisiblePosition = 1
        UltraGridColumn95.Width = 119
        Appearance47.TextVAlignAsString = "Middle"
        UltraGridColumn96.CellAppearance = Appearance47
        UltraGridColumn96.Header.VisiblePosition = 4
        UltraGridColumn96.Hidden = True
        UltraGridColumn96.Width = 60
        Appearance48.TextHAlignAsString = "Center"
        Appearance48.TextVAlignAsString = "Middle"
        UltraGridColumn97.CellAppearance = Appearance48
        UltraGridColumn97.Header.VisiblePosition = 5
        UltraGridColumn97.Width = 80
        Appearance49.TextVAlignAsString = "Middle"
        UltraGridColumn98.CellAppearance = Appearance49
        UltraGridColumn98.Header.VisiblePosition = 6
        UltraGridColumn98.Hidden = True
        Appearance50.TextVAlignAsString = "Middle"
        UltraGridColumn99.CellAppearance = Appearance50
        UltraGridColumn99.Header.VisiblePosition = 7
        UltraGridColumn99.Width = 172
        Appearance51.TextVAlignAsString = "Middle"
        UltraGridColumn100.CellAppearance = Appearance51
        UltraGridColumn100.Header.VisiblePosition = 8
        UltraGridColumn100.Hidden = True
        Appearance52.TextVAlignAsString = "Middle"
        UltraGridColumn101.CellAppearance = Appearance52
        UltraGridColumn101.Header.VisiblePosition = 9
        UltraGridColumn101.Width = 173
        Appearance53.TextVAlignAsString = "Middle"
        UltraGridColumn102.CellAppearance = Appearance53
        UltraGridColumn102.Header.VisiblePosition = 10
        UltraGridColumn102.Width = 150
        Appearance54.TextVAlignAsString = "Middle"
        UltraGridColumn103.CellAppearance = Appearance54
        UltraGridColumn103.Header.VisiblePosition = 11
        UltraGridColumn103.Hidden = True
        Appearance55.TextVAlignAsString = "Middle"
        UltraGridColumn104.CellAppearance = Appearance55
        UltraGridColumn104.Header.VisiblePosition = 12
        UltraGridColumn104.Hidden = True
        Appearance56.TextHAlignAsString = "Right"
        Appearance56.TextVAlignAsString = "Middle"
        UltraGridColumn105.CellAppearance = Appearance56
        UltraGridColumn105.Format = "#,##0.00"
        UltraGridColumn105.Header.VisiblePosition = 13
        UltraGridColumn105.Width = 35
        Appearance57.TextVAlignAsString = "Middle"
        UltraGridColumn106.CellAppearance = Appearance57
        UltraGridColumn106.Header.VisiblePosition = 14
        UltraGridColumn106.Width = 220
        Appearance58.TextVAlignAsString = "Middle"
        UltraGridColumn107.CellAppearance = Appearance58
        UltraGridColumn107.Header.Caption = "Carga"
        UltraGridColumn107.Header.VisiblePosition = 15
        UltraGridColumn107.Width = 125
        Appearance59.TextVAlignAsString = "Middle"
        UltraGridColumn108.CellAppearance = Appearance59
        UltraGridColumn108.Header.VisiblePosition = 16
        UltraGridColumn108.Hidden = True
        Appearance60.TextVAlignAsString = "Middle"
        UltraGridColumn109.CellAppearance = Appearance60
        UltraGridColumn109.Header.VisiblePosition = 17
        UltraGridColumn109.Width = 150
        Appearance61.TextVAlignAsString = "Middle"
        UltraGridColumn110.CellAppearance = Appearance61
        UltraGridColumn110.Header.VisiblePosition = 18
        Appearance62.TextVAlignAsString = "Middle"
        UltraGridColumn111.CellAppearance = Appearance62
        UltraGridColumn111.Header.VisiblePosition = 19
        UltraGridColumn111.Width = 100
        Appearance63.BackColor = System.Drawing.Color.SkyBlue
        Appearance63.TextHAlignAsString = "Right"
        Appearance63.TextVAlignAsString = "Middle"
        UltraGridColumn112.CellAppearance = Appearance63
        UltraGridColumn112.Format = "#,##0.00"
        UltraGridColumn112.Header.VisiblePosition = 20
        UltraGridColumn112.Width = 80
        Appearance64.TextVAlignAsString = "Middle"
        UltraGridColumn113.CellAppearance = Appearance64
        UltraGridColumn113.Header.VisiblePosition = 21
        UltraGridColumn113.Width = 30
        Appearance65.TextVAlignAsString = "Middle"
        UltraGridColumn114.CellAppearance = Appearance65
        UltraGridColumn114.Header.VisiblePosition = 22
        UltraGridColumn114.Width = 65
        Appearance66.TextVAlignAsString = "Middle"
        UltraGridColumn115.CellAppearance = Appearance66
        UltraGridColumn115.Header.VisiblePosition = 23
        UltraGridColumn115.Hidden = True
        UltraGridColumn115.Width = 63
        Appearance67.TextVAlignAsString = "Middle"
        UltraGridColumn116.CellAppearance = Appearance67
        UltraGridColumn116.Header.VisiblePosition = 24
        UltraGridColumn116.Width = 60
        Appearance68.TextVAlignAsString = "Middle"
        UltraGridColumn117.CellAppearance = Appearance68
        UltraGridColumn117.Header.VisiblePosition = 25
        UltraGridColumn117.Hidden = True
        UltraGridColumn117.Width = 81
        Appearance69.TextVAlignAsString = "Middle"
        UltraGridColumn118.CellAppearance = Appearance69
        UltraGridColumn118.Header.VisiblePosition = 26
        UltraGridColumn118.Hidden = True
        UltraGridColumn118.Width = 84
        Appearance70.TextVAlignAsString = "Middle"
        UltraGridColumn119.CellAppearance = Appearance70
        UltraGridColumn119.Header.VisiblePosition = 27
        UltraGridColumn119.Width = 45
        Appearance71.BackColor = System.Drawing.Color.Silver
        Appearance71.TextHAlignAsString = "Right"
        Appearance71.TextVAlignAsString = "Middle"
        UltraGridColumn120.CellAppearance = Appearance71
        UltraGridColumn120.Header.VisiblePosition = 28
        UltraGridColumn120.Width = 45
        Appearance72.TextVAlignAsString = "Middle"
        UltraGridColumn122.CellAppearance = Appearance72
        UltraGridColumn122.Header.VisiblePosition = 29
        UltraGridColumn122.Width = 45
        Appearance73.TextVAlignAsString = "Middle"
        UltraGridColumn124.CellAppearance = Appearance73
        UltraGridColumn124.Header.Caption = "Metas"
        UltraGridColumn124.Header.VisiblePosition = 30
        UltraGridColumn124.Width = 150
        Appearance74.TextVAlignAsString = "Middle"
        UltraGridColumn125.CellAppearance = Appearance74
        UltraGridColumn125.Header.VisiblePosition = 31
        UltraGridColumn125.Width = 150
        Appearance75.TextVAlignAsString = "Middle"
        UltraGridColumn126.CellAppearance = Appearance75
        UltraGridColumn126.Header.VisiblePosition = 32
        UltraGridColumn126.Width = 50
        Appearance76.TextVAlignAsString = "Middle"
        UltraGridColumn127.CellAppearance = Appearance76
        UltraGridColumn127.Header.VisiblePosition = 33
        UltraGridColumn127.Width = 50
        Appearance77.TextVAlignAsString = "Middle"
        UltraGridColumn154.CellAppearance = Appearance77
        UltraGridColumn154.Header.VisiblePosition = 34
        UltraGridColumn154.Width = 50
        Appearance78.TextVAlignAsString = "Middle"
        UltraGridColumn155.CellAppearance = Appearance78
        UltraGridColumn155.Header.VisiblePosition = 35
        UltraGridColumn155.Width = 150
        Appearance79.TextVAlignAsString = "Middle"
        UltraGridColumn156.CellAppearance = Appearance79
        UltraGridColumn156.Header.VisiblePosition = 36
        UltraGridColumn156.Width = 70
        Appearance80.TextVAlignAsString = "Middle"
        UltraGridColumn157.CellAppearance = Appearance80
        UltraGridColumn157.Header.VisiblePosition = 37
        UltraGridColumn157.Width = 45
        Appearance81.TextVAlignAsString = "Middle"
        UltraGridColumn158.CellAppearance = Appearance81
        UltraGridColumn158.Header.VisiblePosition = 38
        Appearance82.TextVAlignAsString = "Middle"
        UltraGridColumn159.CellAppearance = Appearance82
        UltraGridColumn159.Header.VisiblePosition = 39
        UltraGridColumn159.Width = 70
        Appearance83.TextVAlignAsString = "Middle"
        UltraGridColumn160.CellAppearance = Appearance83
        UltraGridColumn160.Header.VisiblePosition = 40
        UltraGridColumn160.Width = 100
        Appearance84.TextVAlignAsString = "Middle"
        UltraGridColumn161.CellAppearance = Appearance84
        UltraGridColumn161.Header.VisiblePosition = 41
        UltraGridColumn161.Width = 70
        Appearance85.TextVAlignAsString = "Middle"
        UltraGridColumn162.CellAppearance = Appearance85
        UltraGridColumn162.Header.VisiblePosition = 42
        UltraGridColumn162.Width = 100
        Appearance86.TextVAlignAsString = "Middle"
        UltraGridColumn163.CellAppearance = Appearance86
        UltraGridColumn163.Header.VisiblePosition = 43
        UltraGridColumn163.Hidden = True
        Appearance87.TextVAlignAsString = "Middle"
        UltraGridColumn164.CellAppearance = Appearance87
        UltraGridColumn164.Header.VisiblePosition = 44
        UltraGridColumn164.Hidden = True
        Appearance88.TextVAlignAsString = "Middle"
        UltraGridColumn165.CellAppearance = Appearance88
        UltraGridColumn165.Header.VisiblePosition = 45
        UltraGridColumn165.Hidden = True
        Appearance89.TextVAlignAsString = "Middle"
        UltraGridColumn166.CellAppearance = Appearance89
        UltraGridColumn166.Header.VisiblePosition = 46
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.Header.VisiblePosition = 47
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn122, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167})
        Appearance90.TextVAlignAsString = "Middle"
        UltraGridBand4.Header.Appearance = Appearance90
        UltraGridBand4.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        UltraGridBand5.ColHeadersVisible = False
        Appearance91.TextVAlignAsString = "Middle"
        UltraGridColumn168.CellAppearance = Appearance91
        UltraGridColumn168.Header.VisiblePosition = 4
        UltraGridColumn168.Hidden = True
        UltraGridColumn168.Width = 8
        Appearance92.TextVAlignAsString = "Middle"
        UltraGridColumn169.CellAppearance = Appearance92
        UltraGridColumn169.Header.VisiblePosition = 3
        UltraGridColumn169.Hidden = True
        UltraGridColumn169.Width = 87
        Appearance93.TextVAlignAsString = "Middle"
        UltraGridColumn170.CellAppearance = Appearance93
        UltraGridColumn170.Header.VisiblePosition = 2
        UltraGridColumn170.Hidden = True
        UltraGridColumn170.Width = 31
        Appearance94.BackColor = System.Drawing.Color.Khaki
        Appearance94.TextHAlignAsString = "Right"
        Appearance94.TextVAlignAsString = "Middle"
        UltraGridColumn171.CellAppearance = Appearance94
        UltraGridColumn171.Header.Fixed = True
        UltraGridColumn171.Header.VisiblePosition = 0
        UltraGridColumn171.Width = 72
        UltraGridColumn172.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance95.TextHAlignAsString = "Center"
        Appearance95.TextVAlignAsString = "Middle"
        UltraGridColumn172.CellAppearance = Appearance95
        UltraGridColumn172.Header.Fixed = True
        UltraGridColumn172.Header.VisiblePosition = 1
        UltraGridColumn172.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn172.Width = 119
        Appearance96.TextVAlignAsString = "Middle"
        UltraGridColumn173.CellAppearance = Appearance96
        UltraGridColumn173.Header.VisiblePosition = 5
        UltraGridColumn173.Hidden = True
        UltraGridColumn173.Width = 60
        Appearance97.TextVAlignAsString = "Middle"
        UltraGridColumn174.CellAppearance = Appearance97
        UltraGridColumn174.Header.VisiblePosition = 6
        UltraGridColumn174.Width = 80
        Appearance98.TextVAlignAsString = "Middle"
        UltraGridColumn175.CellAppearance = Appearance98
        UltraGridColumn175.Header.VisiblePosition = 7
        UltraGridColumn175.Hidden = True
        Appearance99.TextVAlignAsString = "Middle"
        UltraGridColumn176.CellAppearance = Appearance99
        UltraGridColumn176.Header.VisiblePosition = 8
        UltraGridColumn176.Width = 172
        Appearance100.TextVAlignAsString = "Middle"
        UltraGridColumn177.CellAppearance = Appearance100
        UltraGridColumn177.Header.VisiblePosition = 9
        UltraGridColumn177.Hidden = True
        Appearance101.TextVAlignAsString = "Middle"
        UltraGridColumn178.CellAppearance = Appearance101
        UltraGridColumn178.Header.VisiblePosition = 10
        UltraGridColumn178.Width = 173
        Appearance102.TextVAlignAsString = "Middle"
        UltraGridColumn179.CellAppearance = Appearance102
        UltraGridColumn179.Header.VisiblePosition = 11
        UltraGridColumn179.Width = 150
        Appearance103.TextVAlignAsString = "Middle"
        UltraGridColumn180.CellAppearance = Appearance103
        UltraGridColumn180.Header.VisiblePosition = 15
        UltraGridColumn180.Hidden = True
        Appearance104.TextVAlignAsString = "Middle"
        UltraGridColumn181.CellAppearance = Appearance104
        UltraGridColumn181.Header.VisiblePosition = 16
        UltraGridColumn181.Hidden = True
        Appearance105.TextVAlignAsString = "Middle"
        UltraGridColumn182.CellAppearance = Appearance105
        UltraGridColumn182.Header.VisiblePosition = 12
        UltraGridColumn182.Width = 35
        Appearance106.TextVAlignAsString = "Middle"
        UltraGridColumn183.CellAppearance = Appearance106
        UltraGridColumn183.Header.VisiblePosition = 13
        UltraGridColumn183.Width = 220
        Appearance107.TextVAlignAsString = "Middle"
        UltraGridColumn184.CellAppearance = Appearance107
        UltraGridColumn184.Header.Caption = "Carga"
        UltraGridColumn184.Header.VisiblePosition = 14
        UltraGridColumn184.Width = 125
        Appearance108.TextVAlignAsString = "Middle"
        UltraGridColumn185.CellAppearance = Appearance108
        UltraGridColumn185.Header.VisiblePosition = 17
        UltraGridColumn185.Hidden = True
        Appearance109.TextVAlignAsString = "Middle"
        UltraGridColumn186.CellAppearance = Appearance109
        UltraGridColumn186.Header.VisiblePosition = 18
        UltraGridColumn186.Width = 150
        Appearance110.TextVAlignAsString = "Middle"
        UltraGridColumn187.CellAppearance = Appearance110
        UltraGridColumn187.Header.VisiblePosition = 19
        Appearance111.TextVAlignAsString = "Middle"
        UltraGridColumn188.CellAppearance = Appearance111
        UltraGridColumn188.Header.VisiblePosition = 20
        UltraGridColumn188.Width = 100
        Appearance112.BackColor = System.Drawing.Color.SkyBlue
        Appearance112.TextHAlignAsString = "Right"
        Appearance112.TextVAlignAsString = "Middle"
        UltraGridColumn189.CellAppearance = Appearance112
        UltraGridColumn189.Format = "#,##0.00"
        UltraGridColumn189.Header.VisiblePosition = 21
        UltraGridColumn189.Width = 80
        Appearance113.TextVAlignAsString = "Middle"
        UltraGridColumn190.CellAppearance = Appearance113
        UltraGridColumn190.Header.VisiblePosition = 22
        UltraGridColumn190.Width = 30
        Appearance114.TextHAlignAsString = "Right"
        Appearance114.TextVAlignAsString = "Middle"
        UltraGridColumn191.CellAppearance = Appearance114
        UltraGridColumn191.Header.VisiblePosition = 23
        UltraGridColumn191.Width = 65
        Appearance115.TextVAlignAsString = "Middle"
        UltraGridColumn192.CellAppearance = Appearance115
        UltraGridColumn192.Header.VisiblePosition = 24
        UltraGridColumn192.Hidden = True
        UltraGridColumn192.Width = 63
        Appearance116.TextVAlignAsString = "Middle"
        UltraGridColumn193.CellAppearance = Appearance116
        UltraGridColumn193.Header.VisiblePosition = 25
        UltraGridColumn193.Width = 60
        Appearance117.TextVAlignAsString = "Middle"
        UltraGridColumn194.CellAppearance = Appearance117
        UltraGridColumn194.Header.VisiblePosition = 26
        UltraGridColumn194.Hidden = True
        Appearance118.TextVAlignAsString = "Middle"
        UltraGridColumn195.CellAppearance = Appearance118
        UltraGridColumn195.Header.VisiblePosition = 27
        UltraGridColumn195.Hidden = True
        Appearance119.TextHAlignAsString = "Right"
        Appearance119.TextVAlignAsString = "Middle"
        UltraGridColumn196.CellAppearance = Appearance119
        UltraGridColumn196.Format = "#,##0.00"
        UltraGridColumn196.Header.VisiblePosition = 28
        UltraGridColumn196.Width = 45
        Appearance120.BackColor = System.Drawing.Color.Silver
        Appearance120.TextHAlignAsString = "Right"
        Appearance120.TextVAlignAsString = "Middle"
        UltraGridColumn197.CellAppearance = Appearance120
        UltraGridColumn197.Format = "#,##0.00"
        UltraGridColumn197.Header.VisiblePosition = 29
        UltraGridColumn197.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn197.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn197.Width = 45
        Appearance121.TextHAlignAsString = "Right"
        Appearance121.TextVAlignAsString = "Middle"
        UltraGridColumn198.CellAppearance = Appearance121
        UltraGridColumn198.Header.VisiblePosition = 30
        UltraGridColumn198.Width = 45
        Appearance122.TextVAlignAsString = "Middle"
        UltraGridColumn199.CellAppearance = Appearance122
        UltraGridColumn199.Header.Caption = "Metas"
        UltraGridColumn199.Header.VisiblePosition = 31
        UltraGridColumn199.Width = 150
        Appearance123.TextVAlignAsString = "Middle"
        UltraGridColumn200.CellAppearance = Appearance123
        UltraGridColumn200.Header.VisiblePosition = 32
        UltraGridColumn200.Width = 150
        Appearance124.TextHAlignAsString = "Right"
        Appearance124.TextVAlignAsString = "Middle"
        UltraGridColumn201.CellAppearance = Appearance124
        UltraGridColumn201.Format = "#,##0.00"
        UltraGridColumn201.Header.VisiblePosition = 33
        UltraGridColumn201.MaskInput = "{double:6.2}"
        UltraGridColumn201.Width = 50
        Appearance125.TextHAlignAsString = "Right"
        Appearance125.TextVAlignAsString = "Middle"
        UltraGridColumn202.CellAppearance = Appearance125
        UltraGridColumn202.Format = "#,##0.00"
        UltraGridColumn202.Header.VisiblePosition = 34
        UltraGridColumn202.MaskInput = "{double:6.2}"
        UltraGridColumn202.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn202.Width = 50
        Appearance126.TextHAlignAsString = "Right"
        Appearance126.TextVAlignAsString = "Middle"
        UltraGridColumn203.CellAppearance = Appearance126
        UltraGridColumn203.Format = "#,##0.00"
        UltraGridColumn203.Header.VisiblePosition = 35
        UltraGridColumn203.MaskInput = "{double:6.2}"
        UltraGridColumn203.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn203.Width = 50
        Appearance127.TextVAlignAsString = "Middle"
        UltraGridColumn204.CellAppearance = Appearance127
        UltraGridColumn204.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn204.Header.VisiblePosition = 36
        UltraGridColumn204.Width = 150
        UltraGridColumn1.Header.VisiblePosition = 37
        Appearance128.TextHAlignAsString = "Center"
        Appearance128.TextVAlignAsString = "Middle"
        UltraGridColumn206.CellAppearance = Appearance128
        UltraGridColumn206.Header.VisiblePosition = 38
        UltraGridColumn206.Width = 45
        Appearance129.TextHAlignAsString = "Center"
        Appearance129.TextVAlignAsString = "Middle"
        UltraGridColumn207.CellAppearance = Appearance129
        UltraGridColumn207.Header.VisiblePosition = 39
        Appearance130.TextVAlignAsString = "Middle"
        UltraGridColumn208.CellAppearance = Appearance130
        UltraGridColumn208.Header.VisiblePosition = 40
        UltraGridColumn208.Width = 70
        UltraGridColumn209.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance131.TextHAlignAsString = "Center"
        Appearance131.TextVAlignAsString = "Middle"
        UltraGridColumn209.CellAppearance = Appearance131
        UltraGridColumn209.Header.VisiblePosition = 41
        UltraGridColumn209.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn209.Width = 100
        Appearance132.TextVAlignAsString = "Middle"
        UltraGridColumn210.CellAppearance = Appearance132
        UltraGridColumn210.Header.VisiblePosition = 42
        UltraGridColumn210.Width = 70
        UltraGridColumn211.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance133.TextHAlignAsString = "Center"
        Appearance133.TextVAlignAsString = "Middle"
        UltraGridColumn211.CellAppearance = Appearance133
        UltraGridColumn211.Header.VisiblePosition = 43
        UltraGridColumn211.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn211.Width = 100
        Appearance134.TextVAlignAsString = "Middle"
        UltraGridColumn212.CellAppearance = Appearance134
        UltraGridColumn212.Header.VisiblePosition = 44
        UltraGridColumn212.Hidden = True
        Appearance135.TextVAlignAsString = "Middle"
        UltraGridColumn213.CellAppearance = Appearance135
        UltraGridColumn213.Header.VisiblePosition = 45
        UltraGridColumn213.Hidden = True
        Appearance136.TextVAlignAsString = "Middle"
        UltraGridColumn214.CellAppearance = Appearance136
        UltraGridColumn214.Header.VisiblePosition = 46
        UltraGridColumn214.Hidden = True
        Appearance137.TextVAlignAsString = "Middle"
        UltraGridColumn215.CellAppearance = Appearance137
        UltraGridColumn215.Header.VisiblePosition = 47
        UltraGridColumn215.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn1, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215})
        Appearance138.TextVAlignAsString = "Middle"
        UltraGridBand5.Header.Appearance = Appearance138
        UltraGridBand5.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Me.grid_ListaAsociaMP.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.grid_ListaAsociaMP.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.grid_ListaAsociaMP.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.grid_ListaAsociaMP.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListaAsociaMP.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_ListaAsociaMP.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_ListaAsociaMP.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid_ListaAsociaMP.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_ListaAsociaMP.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_ListaAsociaMP.DisplayLayout.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Me.grid_ListaAsociaMP.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_ListaAsociaMP.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_ListaAsociaMP.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.grid_ListaAsociaMP.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_ListaAsociaMP.DisplayLayout.Override.HeaderPlacement = Infragistics.Win.UltraWinGrid.HeaderPlacement.FixedOnTop
        Me.grid_ListaAsociaMP.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_ListaAsociaMP.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_ListaAsociaMP.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListaAsociaMP.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_ListaAsociaMP.DisplayLayout.UseFixedHeaders = True
        Me.grid_ListaAsociaMP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_ListaAsociaMP.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_ListaAsociaMP.Location = New System.Drawing.Point(2, 25)
        Me.grid_ListaAsociaMP.Name = "grid_ListaAsociaMP"
        Me.grid_ListaAsociaMP.Size = New System.Drawing.Size(1233, 359)
        Me.grid_ListaAsociaMP.TabIndex = 1
        '
        'odRegConsumoCombustible
        '
        UltraDataColumn25.DataType = GetType(Date)
        UltraDataColumn35.DataType = GetType(Double)
        UltraDataColumn42.DataType = GetType(Double)
        UltraDataColumn44.DataType = GetType(Double)
        UltraDataColumn47.DataType = GetType(Double)
        UltraDataColumn48.DataType = GetType(Double)
        UltraDataColumn49.DataType = GetType(Double)
        UltraDataColumn50.DataType = GetType(Double)
        UltraDataColumn51.DataType = GetType(Double)
        UltraDataColumn54.DataType = GetType(Double)
        UltraDataColumn55.DataType = GetType(Double)
        UltraDataColumn56.DataType = GetType(Double)
        UltraDataColumn58.DataType = GetType(Boolean)
        UltraDataColumn62.DataType = GetType(Date)
        UltraDataColumn62.DefaultValue = New Date(CType(0, Long))
        UltraDataColumn64.DataType = GetType(Date)
        UltraDataColumn64.DefaultValue = New Date(CType(0, Long))
        UltraDataBand2.Columns.AddRange(New Object() {UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68})
        UltraDataBand1.ChildBands.AddRange(New Object() {UltraDataBand2})
        UltraDataColumn72.DataType = GetType(Date)
        UltraDataColumn82.DataType = GetType(Double)
        UltraDataColumn105.DataType = GetType(Boolean)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115})
        Me.odRegConsumoCombustible.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn152.DataType = GetType(Boolean)
        Me.odRegConsumoCombustible.Band.Columns.AddRange(New Object() {UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162})
        '
        'agrMenuLista
        '
        Me.agrMenuLista.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None
        Me.agrMenuLista.Controls.Add(Me.lblExpande)
        Me.agrMenuLista.Controls.Add(Me.btnExpande1)
        Me.agrMenuLista.Controls.Add(Me.btnExpande2)
        Me.agrMenuLista.Controls.Add(Me.btnExpande3)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(2, 2)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1233, 23)
        Me.agrMenuLista.TabIndex = 0
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'lblExpande
        '
        Appearance139.BackColor = System.Drawing.Color.Transparent
        Appearance139.TextVAlignAsString = "Middle"
        Me.lblExpande.Appearance = Appearance139
        Me.lblExpande.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblExpande.Location = New System.Drawing.Point(1052, 0)
        Me.lblExpande.Name = "lblExpande"
        Me.lblExpande.Size = New System.Drawing.Size(100, 23)
        Me.lblExpande.TabIndex = 3
        Me.lblExpande.Text = "Expandir en nivel:"
        '
        'btnExpande1
        '
        Appearance140.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnExpande1.Appearance = Appearance140
        Me.btnExpande1.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExpande1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExpande1.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExpande1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpande1.ForeColor = System.Drawing.Color.Black
        Me.btnExpande1.Location = New System.Drawing.Point(1152, 0)
        Me.btnExpande1.Name = "btnExpande1"
        Me.btnExpande1.Size = New System.Drawing.Size(27, 23)
        Me.btnExpande1.TabIndex = 4
        Me.btnExpande1.Text = "1"
        Me.btnExpande1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnExpande2
        '
        Appearance141.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnExpande2.Appearance = Appearance141
        Me.btnExpande2.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExpande2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExpande2.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExpande2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpande2.ForeColor = System.Drawing.Color.Black
        Me.btnExpande2.Location = New System.Drawing.Point(1179, 0)
        Me.btnExpande2.Name = "btnExpande2"
        Me.btnExpande2.Size = New System.Drawing.Size(27, 23)
        Me.btnExpande2.TabIndex = 5
        Me.btnExpande2.Text = "2"
        Me.btnExpande2.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnExpande3
        '
        Appearance142.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnExpande3.Appearance = Appearance142
        Me.btnExpande3.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExpande3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExpande3.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExpande3.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpande3.ForeColor = System.Drawing.Color.Black
        Me.btnExpande3.Location = New System.Drawing.Point(1206, 0)
        Me.btnExpande3.Name = "btnExpande3"
        Me.btnExpande3.Size = New System.Drawing.Size(27, 23)
        Me.btnExpande3.TabIndex = 6
        Me.btnExpande3.Text = "3"
        Me.btnExpande3.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'gbTanqueosNoAsociados
        '
        Me.gbTanqueosNoAsociados.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbTanqueosNoAsociados.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.gbTanqueosNoAsociados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbTanqueosNoAsociados.ExpandedSize = New System.Drawing.Size(1233, 211)
        Me.gbTanqueosNoAsociados.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTanqueosNoAsociados.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.gbTanqueosNoAsociados.Location = New System.Drawing.Point(2, 384)
        Me.gbTanqueosNoAsociados.Name = "gbTanqueosNoAsociados"
        Me.gbTanqueosNoAsociados.Size = New System.Drawing.Size(1233, 211)
        Me.gbTanqueosNoAsociados.TabIndex = 2
        Me.gbTanqueosNoAsociados.Text = "Peajes no asociados"
        Me.gbTanqueosNoAsociados.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.btn_ListarTanqNoAsoc)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.grid_ListaMPnoAsoc)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(3, 25)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(1227, 183)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'btn_ListarTanqNoAsoc
        '
        Appearance143.TextVAlignAsString = "Top"
        Me.btn_ListarTanqNoAsoc.Appearance = Appearance143
        Me.btn_ListarTanqNoAsoc.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button
        Me.btn_ListarTanqNoAsoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn_ListarTanqNoAsoc.ImageList = Me.imagenes
        Me.btn_ListarTanqNoAsoc.Location = New System.Drawing.Point(3, 2)
        Me.btn_ListarTanqNoAsoc.Name = "btn_ListarTanqNoAsoc"
        Me.btn_ListarTanqNoAsoc.Size = New System.Drawing.Size(31, 15)
        Me.btn_ListarTanqNoAsoc.TabIndex = 0
        Me.btn_ListarTanqNoAsoc.Text = "* * *"
        '
        'grid_ListaMPnoAsoc
        '
        Me.grid_ListaMPnoAsoc.DataSource = Me.odTanqueosNoAsociados
        UltraGridColumn216.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn216.Header.VisiblePosition = 0
        UltraGridColumn216.Hidden = True
        UltraGridColumn216.Width = 27
        UltraGridColumn217.Header.VisiblePosition = 20
        UltraGridColumn217.Hidden = True
        UltraGridColumn218.Header.Caption = "Viaje"
        UltraGridColumn218.Header.VisiblePosition = 1
        UltraGridColumn218.Hidden = True
        UltraGridColumn218.Width = 125
        UltraGridColumn219.Header.VisiblePosition = 2
        UltraGridColumn219.Hidden = True
        UltraGridColumn220.Header.Caption = "Fecha"
        UltraGridColumn220.Header.VisiblePosition = 3
        UltraGridColumn220.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn220.Width = 151
        Appearance144.TextHAlignAsString = "Right"
        UltraGridColumn221.CellAppearance = Appearance144
        UltraGridColumn221.Header.Caption = "KM Tanqueo"
        UltraGridColumn221.Header.VisiblePosition = 5
        UltraGridColumn221.MaskInput = "{double:9.4}"
        UltraGridColumn221.Width = 82
        Appearance145.TextHAlignAsString = "Right"
        UltraGridColumn222.CellAppearance = Appearance145
        UltraGridColumn222.Header.Caption = "Can(Gls)"
        UltraGridColumn222.Header.VisiblePosition = 6
        UltraGridColumn222.MaskInput = "{double:9.4}"
        UltraGridColumn222.Width = 77
        UltraGridColumn223.Header.Caption = "Nro Vale"
        UltraGridColumn223.Header.VisiblePosition = 8
        UltraGridColumn223.Width = 113
        UltraGridColumn224.Header.VisiblePosition = 9
        UltraGridColumn224.Hidden = True
        UltraGridColumn225.Header.VisiblePosition = 10
        UltraGridColumn225.Hidden = True
        UltraGridColumn226.Header.VisiblePosition = 11
        UltraGridColumn226.Hidden = True
        UltraGridColumn227.Header.VisiblePosition = 12
        UltraGridColumn227.Hidden = True
        UltraGridColumn228.Header.VisiblePosition = 13
        UltraGridColumn228.Hidden = True
        UltraGridColumn229.Header.Caption = "Full/Rell"
        UltraGridColumn229.Header.VisiblePosition = 7
        UltraGridColumn229.Width = 63
        UltraGridColumn230.Header.VisiblePosition = 14
        UltraGridColumn230.Hidden = True
        UltraGridColumn231.Header.VisiblePosition = 15
        UltraGridColumn231.Hidden = True
        UltraGridColumn232.Header.VisiblePosition = 16
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.Header.VisiblePosition = 17
        UltraGridColumn233.Hidden = True
        Appearance146.TextHAlignAsString = "Right"
        UltraGridColumn234.CellAppearance = Appearance146
        UltraGridColumn234.Header.Caption = "Saldo(Gls)"
        UltraGridColumn234.Header.VisiblePosition = 18
        UltraGridColumn234.Hidden = True
        UltraGridColumn234.Width = 74
        UltraGridColumn235.Header.VisiblePosition = 19
        UltraGridColumn235.Hidden = True
        UltraGridColumn272.Header.VisiblePosition = 21
        UltraGridColumn272.Hidden = True
        UltraGridColumn273.Header.VisiblePosition = 22
        UltraGridColumn273.Hidden = True
        UltraGridColumn274.Header.VisiblePosition = 23
        UltraGridColumn274.Hidden = True
        UltraGridColumn275.Header.VisiblePosition = 24
        UltraGridColumn275.Hidden = True
        UltraGridColumn276.Header.VisiblePosition = 25
        UltraGridColumn276.Hidden = True
        UltraGridColumn277.Header.VisiblePosition = 26
        UltraGridColumn277.Hidden = True
        Appearance147.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn278.CellAppearance = Appearance147
        UltraGridColumn278.Header.Caption = "Tracto"
        UltraGridColumn278.Header.VisiblePosition = 4
        UltraGridColumn278.Width = 87
        UltraGridColumn279.Header.VisiblePosition = 27
        UltraGridColumn279.Hidden = True
        UltraGridColumn280.Header.VisiblePosition = 28
        UltraGridColumn280.Hidden = True
        UltraGridColumn281.Header.VisiblePosition = 29
        UltraGridColumn281.Hidden = True
        UltraGridColumn282.Header.VisiblePosition = 30
        UltraGridColumn283.Header.VisiblePosition = 31
        UltraGridColumn283.Hidden = True
        UltraGridColumn283.Width = 71
        UltraGridColumn284.Header.Caption = "Grifo"
        UltraGridColumn284.Header.VisiblePosition = 32
        UltraGridColumn284.Width = 238
        UltraGridColumn285.Header.Caption = "Direccion"
        UltraGridColumn285.Header.VisiblePosition = 34
        UltraGridColumn285.Width = 241
        UltraGridColumn286.Header.Caption = "Lugar"
        UltraGridColumn286.Header.VisiblePosition = 33
        UltraGridColumn286.Width = 166
        UltraGridColumn287.Header.VisiblePosition = 35
        UltraGridColumn287.Hidden = True
        UltraGridColumn288.Header.VisiblePosition = 36
        UltraGridColumn288.Hidden = True
        UltraGridColumn289.Header.VisiblePosition = 37
        UltraGridColumn289.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289})
        Me.grid_ListaMPnoAsoc.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.grid_ListaMPnoAsoc.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_ListaMPnoAsoc.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_ListaMPnoAsoc.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListaMPnoAsoc.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_ListaMPnoAsoc.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_ListaMPnoAsoc.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_ListaMPnoAsoc.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_ListaMPnoAsoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_ListaMPnoAsoc.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_ListaMPnoAsoc.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_ListaMPnoAsoc.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListaMPnoAsoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_ListaMPnoAsoc.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_ListaMPnoAsoc.Location = New System.Drawing.Point(0, 0)
        Me.grid_ListaMPnoAsoc.Name = "grid_ListaMPnoAsoc"
        Me.grid_ListaMPnoAsoc.Size = New System.Drawing.Size(1227, 183)
        Me.grid_ListaMPnoAsoc.TabIndex = 1
        '
        'odTanqueosNoAsociados
        '
        UltraDataColumn163.DataType = GetType(Boolean)
        UltraDataColumn176.DataType = GetType(Boolean)
        Me.odTanqueosNoAsociados.Band.Columns.AddRange(New Object() {UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172, UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181, UltraDataColumn182, UltraDataColumn183, UltraDataColumn184, UltraDataColumn185, UltraDataColumn186, UltraDataColumn187, UltraDataColumn188, UltraDataColumn189, UltraDataColumn190, UltraDataColumn191, UltraDataColumn192, UltraDataColumn193, UltraDataColumn194, UltraDataColumn195, UltraDataColumn196, UltraDataColumn197, UltraDataColumn198, UltraDataColumn199, UltraDataColumn200})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.gridListaMovimientoPeaje)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1239, 710)
        '
        'gridListaMovimientoPeaje
        '
        Me.gridListaMovimientoPeaje.DataSource = Me.odMovimientoPeaje
        UltraGridColumn71.Header.VisiblePosition = 2
        UltraGridColumn71.Hidden = True
        UltraGridColumn71.Width = 110
        UltraGridColumn88.Header.VisiblePosition = 0
        UltraGridColumn88.Width = 110
        UltraGridColumn121.Header.VisiblePosition = 1
        UltraGridColumn121.Width = 80
        UltraGridColumn123.Header.VisiblePosition = 3
        UltraGridColumn123.Width = 45
        UltraGridColumn128.Header.VisiblePosition = 4
        UltraGridColumn128.Width = 90
        UltraGridColumn129.Header.VisiblePosition = 5
        UltraGridColumn129.Width = 60
        UltraGridColumn130.Header.VisiblePosition = 6
        UltraGridColumn130.Width = 100
        UltraGridColumn131.Header.VisiblePosition = 7
        UltraGridColumn131.Hidden = True
        UltraGridColumn131.Width = 110
        UltraGridColumn132.Header.VisiblePosition = 9
        UltraGridColumn132.Width = 240
        UltraGridColumn133.Header.VisiblePosition = 8
        UltraGridColumn133.Hidden = True
        UltraGridColumn133.Width = 110
        UltraGridColumn134.Header.VisiblePosition = 10
        UltraGridColumn134.Width = 60
        UltraGridColumn135.Header.VisiblePosition = 11
        UltraGridColumn135.Width = 120
        UltraGridColumn136.Header.VisiblePosition = 12
        UltraGridColumn136.Hidden = True
        UltraGridColumn136.Width = 110
        UltraGridColumn137.Header.VisiblePosition = 13
        UltraGridColumn137.Width = 50
        UltraGridColumn138.Header.VisiblePosition = 14
        UltraGridColumn138.Hidden = True
        UltraGridColumn138.Width = 110
        UltraGridColumn139.Header.VisiblePosition = 18
        UltraGridColumn139.Hidden = True
        UltraGridColumn139.Width = 110
        UltraGridColumn140.Header.VisiblePosition = 15
        UltraGridColumn140.Hidden = True
        UltraGridColumn140.Width = 110
        UltraGridColumn141.Header.VisiblePosition = 17
        UltraGridColumn141.Hidden = True
        UltraGridColumn141.Width = 110
        UltraGridColumn142.Header.VisiblePosition = 19
        UltraGridColumn142.Hidden = True
        UltraGridColumn142.Width = 110
        UltraGridColumn143.Header.VisiblePosition = 16
        UltraGridColumn143.Hidden = True
        UltraGridColumn143.Width = 80
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn71, UltraGridColumn88, UltraGridColumn121, UltraGridColumn123, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143})
        Me.gridListaMovimientoPeaje.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.gridListaMovimientoPeaje.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridListaMovimientoPeaje.DisplayLayout.MaxColScrollRegions = 1
        Me.gridListaMovimientoPeaje.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridListaMovimientoPeaje.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridListaMovimientoPeaje.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridListaMovimientoPeaje.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridListaMovimientoPeaje.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridListaMovimientoPeaje.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridListaMovimientoPeaje.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridListaMovimientoPeaje.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridListaMovimientoPeaje.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridListaMovimientoPeaje.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridListaMovimientoPeaje.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridListaMovimientoPeaje.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.gridListaMovimientoPeaje.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridListaMovimientoPeaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridListaMovimientoPeaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridListaMovimientoPeaje.ImageList = Me.imagenes
        Me.gridListaMovimientoPeaje.Location = New System.Drawing.Point(0, 57)
        Me.gridListaMovimientoPeaje.Name = "gridListaMovimientoPeaje"
        Me.gridListaMovimientoPeaje.Size = New System.Drawing.Size(1239, 653)
        Me.gridListaMovimientoPeaje.TabIndex = 1
        Me.gridListaMovimientoPeaje.Text = "Comprobante Compra"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Label2)
        Me.Agrupacion1.Controls.Add(Me.Label1)
        Me.Agrupacion1.Controls.Add(Me.dtpHasta)
        Me.Agrupacion1.Controls.Add(Me.dtpDesde)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1239, 57)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Busca"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(155, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(194, 20)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(98, 21)
        Me.dtpHasta.TabIndex = 5
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(55, 20)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(98, 21)
        Me.dtpDesde.TabIndex = 4
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.tcComprobanteDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1239, 710)
        '
        'tcComprobanteDetalle
        '
        Me.tcComprobanteDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tcComprobanteDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.tcComprobanteDetalle.Controls.Add(Me.UltraTabPageControl6)
        Me.tcComprobanteDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcComprobanteDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcComprobanteDetalle.Location = New System.Drawing.Point(0, 190)
        Me.tcComprobanteDetalle.Name = "tcComprobanteDetalle"
        Me.tcComprobanteDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tcComprobanteDetalle.Size = New System.Drawing.Size(1239, 520)
        Me.tcComprobanteDetalle.TabIndex = 2
        UltraTab2.Key = "Tab1"
        UltraTab2.TabPage = Me.UltraTabPageControl3
        UltraTab2.Text = "PostPago Pex"
        UltraTab6.Key = "Tab2"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "PrePago Covisol"
        Me.tcComprobanteDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab6})
        Me.tcComprobanteDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1237, 497)
        '
        'UltraExpandableGroupBox1
        '
        Appearance148.BackColor = System.Drawing.Color.White
        Appearance148.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance148
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(1239, 190)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(1239, 190)
        Me.UltraExpandableGroupBox1.TabIndex = 0
        Me.UltraExpandableGroupBox1.Text = "Datos Generales"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ugb_Espera2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Agrupacion2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.grupoDetalle)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.grupoCabeceraAsiento)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1233, 167)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.ColorMontoIncorrecto)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(632, 5)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(208, 41)
        Me.Agrupacion2.TabIndex = 21
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorMontoIncorrecto
        '
        Me.ColorMontoIncorrecto.Location = New System.Drawing.Point(151, 10)
        Me.ColorMontoIncorrecto.Name = "ColorMontoIncorrecto"
        Me.ColorMontoIncorrecto.Size = New System.Drawing.Size(43, 21)
        Me.ColorMontoIncorrecto.TabIndex = 1
        Me.ColorMontoIncorrecto.TabStop = False
        Me.ColorMontoIncorrecto.Text = "Control"
        '
        'Etiqueta10
        '
        Appearance149.BackColor = System.Drawing.Color.Transparent
        Appearance149.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance149
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(11, 14)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(135, 15)
        Me.Etiqueta10.TabIndex = 0
        Me.Etiqueta10.Text = "Monto Factura Incorrecto:"
        '
        'grupoDetalle
        '
        Appearance150.BackColor = System.Drawing.Color.White
        Appearance150.BackColor2 = System.Drawing.Color.White
        Me.grupoDetalle.ContentAreaAppearance = Appearance150
        Me.grupoDetalle.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.grupoDetalle.Dock = System.Windows.Forms.DockStyle.Left
        Me.grupoDetalle.ExpandedSize = New System.Drawing.Size(320, 167)
        Me.grupoDetalle.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.grupoDetalle.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.grupoDetalle.Location = New System.Drawing.Point(310, 0)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Size = New System.Drawing.Size(320, 167)
        Me.grupoDetalle.TabIndex = 3
        Me.grupoDetalle.Text = "Detalle"
        Me.grupoDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta34)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboCuenta)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboGastonFuncion)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboItemGasto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta19)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta32)
        Me.UltraExpandableGroupBoxPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(297, 161)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        '
        'Etiqueta34
        '
        Me.Etiqueta34.AutoSize = True
        Me.Etiqueta34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta34.Location = New System.Drawing.Point(2, 26)
        Me.Etiqueta34.Name = "Etiqueta34"
        Me.Etiqueta34.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta34.TabIndex = 2
        Me.Etiqueta34.Text = "Distribucion:"
        '
        'cboCuenta
        '
        Appearance151.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuenta.Appearance = Appearance151
        Me.cboCuenta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuenta.DropDownListWidth = 400
        Me.cboCuenta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuenta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuenta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuenta.ImageList = Me.imagenes
        Me.cboCuenta.Location = New System.Drawing.Point(71, 2)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(225, 19)
        Me.cboCuenta.TabIndex = 1
        Me.cboCuenta.ValueMember = "Id"
        '
        'cboGastonFuncion
        '
        Appearance152.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboGastonFuncion.Appearance = Appearance152
        Me.cboGastonFuncion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboGastonFuncion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGastonFuncion.DropDownListWidth = 400
        Me.cboGastonFuncion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboGastonFuncion.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGastonFuncion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboGastonFuncion.ImageList = Me.imagenes
        Me.cboGastonFuncion.Location = New System.Drawing.Point(71, 24)
        Me.cboGastonFuncion.Name = "cboGastonFuncion"
        Me.cboGastonFuncion.Size = New System.Drawing.Size(225, 19)
        Me.cboGastonFuncion.TabIndex = 3
        Me.cboGastonFuncion.ValueMember = "Id"
        '
        'cboItemGasto
        '
        Appearance153.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.Appearance = Appearance153
        Me.cboItemGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboItemGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboItemGasto.DropDownListWidth = 400
        Me.cboItemGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboItemGasto.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemGasto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.ImageList = Me.imagenes
        Me.cboItemGasto.Location = New System.Drawing.Point(71, 47)
        Me.cboItemGasto.Name = "cboItemGasto"
        Me.cboItemGasto.Size = New System.Drawing.Size(225, 19)
        Me.cboItemGasto.TabIndex = 5
        Me.cboItemGasto.ValueMember = "Id"
        '
        'Etiqueta19
        '
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta19.Location = New System.Drawing.Point(7, 49)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(64, 15)
        Me.Etiqueta19.TabIndex = 4
        Me.Etiqueta19.Text = "Item Gasto:"
        '
        'Etiqueta32
        '
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta32.Location = New System.Drawing.Point(26, 4)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta32.TabIndex = 0
        Me.Etiqueta32.Text = "Cuenta:"
        '
        'grupoCabeceraAsiento
        '
        Appearance154.BackColor = System.Drawing.Color.White
        Appearance154.BackColor2 = System.Drawing.Color.White
        Me.grupoCabeceraAsiento.ContentAreaAppearance = Appearance154
        Me.grupoCabeceraAsiento.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.grupoCabeceraAsiento.Dock = System.Windows.Forms.DockStyle.Left
        Me.grupoCabeceraAsiento.ExpandedSize = New System.Drawing.Size(310, 167)
        Me.grupoCabeceraAsiento.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.grupoCabeceraAsiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoCabeceraAsiento.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.grupoCabeceraAsiento.Location = New System.Drawing.Point(0, 0)
        Me.grupoCabeceraAsiento.Name = "grupoCabeceraAsiento"
        Me.grupoCabeceraAsiento.Size = New System.Drawing.Size(310, 167)
        Me.grupoCabeceraAsiento.TabIndex = 0
        Me.grupoCabeceraAsiento.Text = "Cabecera Asiento"
        Me.grupoCabeceraAsiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.dtpFechaEjercicio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta7)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cboMes)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta2)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cbeCtaCte)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cboTipoDocumento)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta26)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cboMoneda)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta31)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta1)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta3)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cboTipoCompra)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(287, 161)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'dtpFechaEjercicio
        '
        Me.dtpFechaEjercicio.CustomFormat = "yyyy"
        Me.dtpFechaEjercicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaEjercicio.Location = New System.Drawing.Point(66, 2)
        Me.dtpFechaEjercicio.Name = "dtpFechaEjercicio"
        Me.dtpFechaEjercicio.ShowUpDown = True
        Me.dtpFechaEjercicio.Size = New System.Drawing.Size(52, 21)
        Me.dtpFechaEjercicio.TabIndex = 24
        '
        'Etiqueta7
        '
        Appearance155.BackColor = System.Drawing.Color.Transparent
        Appearance155.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance155
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(126, 6)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(28, 15)
        Me.Etiqueta7.TabIndex = 22
        Me.Etiqueta7.Text = "Mes:"
        '
        'cboMes
        '
        Appearance156.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Appearance = Appearance156
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Location = New System.Drawing.Point(163, 2)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(114, 22)
        Me.cboMes.TabIndex = 23
        Me.cboMes.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance157.BackColor = System.Drawing.Color.Transparent
        Appearance157.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance157
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(3, 4)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta2.TabIndex = 21
        Me.Etiqueta2.Text = "Ejercicio:"
        '
        'cbeCtaCte
        '
        Me.cbeCtaCte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbeCtaCte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbeCtaCte.CheckedListSettings.ListSeparator = ","
        Me.cbeCtaCte.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cbeCtaCte.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cbeCtaCte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbeCtaCte.DropDownWidth = 400
        Me.cbeCtaCte.Location = New System.Drawing.Point(3, 49)
        Me.cbeCtaCte.Name = "cbeCtaCte"
        Me.cbeCtaCte.Size = New System.Drawing.Size(274, 23)
        Me.cbeCtaCte.TabIndex = 14
        '
        'cboTipoDocumento
        '
        Appearance158.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDocumento.Appearance = Appearance158
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.DropDownListWidth = 400
        Me.cboTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDocumento.ImageList = Me.imagenes
        Me.cboTipoDocumento.Location = New System.Drawing.Point(64, 77)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(213, 22)
        Me.cboTipoDocumento.TabIndex = 1
        Me.cboTipoDocumento.ValueMember = "Id"
        '
        'Etiqueta26
        '
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta26.Location = New System.Drawing.Point(10, 81)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta26.TabIndex = 0
        Me.Etiqueta26.Text = "Tipo Doc:"
        '
        'cboMoneda
        '
        Appearance159.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance159
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(64, 103)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(75, 22)
        Me.cboMoneda.TabIndex = 16
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta31
        '
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(10, 30)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(59, 15)
        Me.Etiqueta31.TabIndex = 10
        Me.Etiqueta31.Text = "Proveedor:"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(2, 131)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta1.TabIndex = 19
        Me.Etiqueta1.Text = "T. Compra:"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(14, 106)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta3.TabIndex = 15
        Me.Etiqueta3.Text = "Moneda:"
        '
        'cboTipoCompra
        '
        Appearance160.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoCompra.Appearance = Appearance160
        Me.cboTipoCompra.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoCompra.DropDownListWidth = 400
        Me.cboTipoCompra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoCompra.ImageList = Me.imagenes
        Me.cboTipoCompra.Location = New System.Drawing.Point(64, 128)
        Me.cboTipoCompra.Name = "cboTipoCompra"
        Me.cboTipoCompra.Size = New System.Drawing.Size(213, 22)
        Me.cboTipoCompra.TabIndex = 20
        Me.cboTipoCompra.ValueMember = "Id"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.ficConCombustible)
        Me.UltraTabPageControl4.Controls.Add(Me.gbeConsultar)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1239, 710)
        '
        'ficConCombustible
        '
        Me.ficConCombustible.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficConCombustible.Controls.Add(Me.UltraTabPageControl5)
        Me.ficConCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficConCombustible.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficConCombustible.Location = New System.Drawing.Point(0, 90)
        Me.ficConCombustible.Name = "ficConCombustible"
        Me.ficConCombustible.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficConCombustible.Size = New System.Drawing.Size(1239, 620)
        Me.ficConCombustible.TabIndex = 3
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Lista"
        Me.ficConCombustible.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5})
        Me.ficConCombustible.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1237, 597)
        '
        'gbeConsultar
        '
        Me.gbeConsultar.Controls.Add(Me.ChkSeleccion)
        Me.gbeConsultar.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbeConsultar.ExpandedSize = New System.Drawing.Size(1239, 90)
        Me.gbeConsultar.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.gbeConsultar.Location = New System.Drawing.Point(0, 0)
        Me.gbeConsultar.Name = "gbeConsultar"
        Me.gbeConsultar.Size = New System.Drawing.Size(1239, 90)
        Me.gbeConsultar.TabIndex = 2
        Me.gbeConsultar.Text = "Consultar "
        Me.gbeConsultar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ChkSeleccion
        '
        Me.ChkSeleccion.Controls.Add(Me.grFiltro)
        Me.ChkSeleccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkSeleccion.Location = New System.Drawing.Point(3, 20)
        Me.ChkSeleccion.Name = "ChkSeleccion"
        Me.ChkSeleccion.Size = New System.Drawing.Size(1233, 67)
        Me.ChkSeleccion.TabIndex = 0
        '
        'grFiltro
        '
        Appearance161.BackColor = System.Drawing.Color.White
        Appearance161.BackColor2 = System.Drawing.Color.White
        Me.grFiltro.ContentAreaAppearance = Appearance161
        Me.grFiltro.Controls.Add(Me.UltraGroupBox6)
        Me.grFiltro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grFiltro.Location = New System.Drawing.Point(0, 0)
        Me.grFiltro.Name = "grFiltro"
        Me.grFiltro.Size = New System.Drawing.Size(1233, 67)
        Me.grFiltro.TabIndex = 0
        Me.grFiltro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraGroupBox6
        '
        Appearance162.BackColor = System.Drawing.Color.White
        Appearance162.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption
        Me.UltraGroupBox6.ContentAreaAppearance = Appearance162
        Me.UltraGroupBox6.Controls.Add(Me.cboTractoLista)
        Me.UltraGroupBox6.Controls.Add(Me.grupoEstado)
        Me.UltraGroupBox6.Controls.Add(Me.lblVehi)
        Me.UltraGroupBox6.Controls.Add(Me.Label8)
        Me.UltraGroupBox6.Controls.Add(Me.rfHasta)
        Me.UltraGroupBox6.Controls.Add(Me.rfDesde)
        Me.UltraGroupBox6.Controls.Add(Me.Label9)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox6.Location = New System.Drawing.Point(2, 2)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(1229, 63)
        Me.UltraGroupBox6.TabIndex = 1
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboTractoLista
        '
        Appearance163.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Appearance = Appearance163
        Me.cboTractoLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTractoLista.DisplayMember = ""
        Me.cboTractoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTractoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTractoLista.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Location = New System.Drawing.Point(67, 37)
        Me.cboTractoLista.Name = "cboTractoLista"
        Me.cboTractoLista.Size = New System.Drawing.Size(96, 21)
        Me.cboTractoLista.TabIndex = 22
        Me.cboTractoLista.ValueMember = "Id"
        '
        'grupoEstado
        '
        Me.grupoEstado.Controls.Add(Me.ColorReembolsado)
        Me.grupoEstado.Controls.Add(Me.ColorPendiente)
        Me.grupoEstado.Controls.Add(Me.ColorHabilitada)
        Me.grupoEstado.Controls.Add(Me.Etiqueta4)
        Me.grupoEstado.Controls.Add(Me.Etiqueta5)
        Me.grupoEstado.Controls.Add(Me.ColorLiquidada)
        Me.grupoEstado.Controls.Add(Me.Etiqueta9)
        Me.grupoEstado.Controls.Add(Me.ColorNoReembolsado)
        Me.grupoEstado.Controls.Add(Me.Etiqueta6)
        Me.grupoEstado.Controls.Add(Me.Etiqueta8)
        Me.grupoEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoEstado.Location = New System.Drawing.Point(318, 19)
        Me.grupoEstado.Name = "grupoEstado"
        Me.grupoEstado.Size = New System.Drawing.Size(684, 41)
        Me.grupoEstado.TabIndex = 20
        Me.grupoEstado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorReembolsado
        '
        Me.ColorReembolsado.Location = New System.Drawing.Point(609, 9)
        Me.ColorReembolsado.Name = "ColorReembolsado"
        Me.ColorReembolsado.Size = New System.Drawing.Size(44, 21)
        Me.ColorReembolsado.TabIndex = 9
        Me.ColorReembolsado.TabStop = False
        Me.ColorReembolsado.Text = "Control"
        '
        'ColorPendiente
        '
        Me.ColorPendiente.Location = New System.Drawing.Point(74, 10)
        Me.ColorPendiente.Name = "ColorPendiente"
        Me.ColorPendiente.Size = New System.Drawing.Size(43, 21)
        Me.ColorPendiente.TabIndex = 1
        Me.ColorPendiente.TabStop = False
        Me.ColorPendiente.Text = "Control"
        '
        'ColorHabilitada
        '
        Me.ColorHabilitada.Location = New System.Drawing.Point(199, 10)
        Me.ColorHabilitada.Name = "ColorHabilitada"
        Me.ColorHabilitada.Size = New System.Drawing.Size(44, 21)
        Me.ColorHabilitada.TabIndex = 3
        Me.ColorHabilitada.TabStop = False
        Me.ColorHabilitada.Text = "Control"
        '
        'Etiqueta4
        '
        Appearance164.BackColor = System.Drawing.Color.Transparent
        Appearance164.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance164
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(11, 14)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Pendiente:"
        '
        'Etiqueta5
        '
        Appearance165.BackColor = System.Drawing.Color.Transparent
        Appearance165.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance165
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(137, 15)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Habilitada:"
        '
        'ColorLiquidada
        '
        Me.ColorLiquidada.Location = New System.Drawing.Point(336, 10)
        Me.ColorLiquidada.Name = "ColorLiquidada"
        Me.ColorLiquidada.Size = New System.Drawing.Size(43, 21)
        Me.ColorLiquidada.TabIndex = 5
        Me.ColorLiquidada.TabStop = False
        Me.ColorLiquidada.Text = "Control"
        '
        'Etiqueta9
        '
        Appearance166.BackColor = System.Drawing.Color.Transparent
        Appearance166.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance166
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(528, 14)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(75, 15)
        Me.Etiqueta9.TabIndex = 8
        Me.Etiqueta9.Text = "Reembolsado:"
        '
        'ColorNoReembolsado
        '
        Me.ColorNoReembolsado.Location = New System.Drawing.Point(467, 10)
        Me.ColorNoReembolsado.Name = "ColorNoReembolsado"
        Me.ColorNoReembolsado.Size = New System.Drawing.Size(44, 21)
        Me.ColorNoReembolsado.TabIndex = 7
        Me.ColorNoReembolsado.TabStop = False
        Me.ColorNoReembolsado.Text = "Control"
        '
        'Etiqueta6
        '
        Appearance167.BackColor = System.Drawing.Color.Transparent
        Appearance167.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance167
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(278, 14)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta6.TabIndex = 4
        Me.Etiqueta6.Text = "Liquidada:"
        '
        'Etiqueta8
        '
        Appearance168.BackColor = System.Drawing.Color.Transparent
        Appearance168.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance168
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(405, 14)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(59, 15)
        Me.Etiqueta8.TabIndex = 6
        Me.Etiqueta8.Text = "Cancelado:"
        '
        'lblVehi
        '
        Me.lblVehi.AutoSize = True
        Me.lblVehi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblVehi.Location = New System.Drawing.Point(11, 41)
        Me.lblVehi.Name = "lblVehi"
        Me.lblVehi.Size = New System.Drawing.Size(50, 15)
        Me.lblVehi.TabIndex = 17
        Me.lblVehi.Text = "Vehiculo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(20, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Desde:"
        '
        'rfHasta
        '
        Me.rfHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfHasta.Location = New System.Drawing.Point(217, 7)
        Me.rfHasta.Name = "rfHasta"
        Me.rfHasta.Size = New System.Drawing.Size(95, 21)
        Me.rfHasta.TabIndex = 3
        '
        'rfDesde
        '
        Me.rfDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfDesde.Location = New System.Drawing.Point(67, 7)
        Me.rfDesde.Name = "rfDesde"
        Me.rfDesde.Size = New System.Drawing.Size(96, 21)
        Me.rfDesde.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(172, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Hasta:"
        '
        'UltraDataSource1
        '
        UltraDataColumn236.DataType = GetType(Boolean)
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn201, UltraDataColumn202, UltraDataColumn203, UltraDataColumn204, UltraDataColumn205, UltraDataColumn206, UltraDataColumn207, UltraDataColumn208, UltraDataColumn209, UltraDataColumn210, UltraDataColumn211, UltraDataColumn212, UltraDataColumn213, UltraDataColumn214, UltraDataColumn215, UltraDataColumn216, UltraDataColumn217, UltraDataColumn218, UltraDataColumn219, UltraDataColumn220, UltraDataColumn221, UltraDataColumn222, UltraDataColumn223, UltraDataColumn224, UltraDataColumn225, UltraDataColumn226, UltraDataColumn227, UltraDataColumn228, UltraDataColumn229, UltraDataColumn230, UltraDataColumn231, UltraDataColumn232, UltraDataColumn233, UltraDataColumn234, UltraDataColumn235, UltraDataColumn236})
        '
        'UltraDataSource2
        '
        UltraDataColumn271.DataType = GetType(Boolean)
        UltraDataColumn272.DataType = GetType(Date)
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn237, UltraDataColumn238, UltraDataColumn239, UltraDataColumn240, UltraDataColumn241, UltraDataColumn242, UltraDataColumn243, UltraDataColumn244, UltraDataColumn245, UltraDataColumn246, UltraDataColumn247, UltraDataColumn248, UltraDataColumn249, UltraDataColumn250, UltraDataColumn251, UltraDataColumn252, UltraDataColumn253, UltraDataColumn254, UltraDataColumn255, UltraDataColumn256, UltraDataColumn257, UltraDataColumn258, UltraDataColumn259, UltraDataColumn260, UltraDataColumn261, UltraDataColumn262, UltraDataColumn263, UltraDataColumn264, UltraDataColumn265, UltraDataColumn266, UltraDataColumn267, UltraDataColumn268, UltraDataColumn269, UltraDataColumn270, UltraDataColumn271, UltraDataColumn272})
        '
        'EMovimientoDocumentoBindingSource
        '
        Me.EMovimientoDocumentoBindingSource.DataSource = GetType(ISL.EntidadesWCF.e_MovimientoDocumento)
        '
        'UltraDataSource4
        '
        Me.UltraDataSource4.Band.Columns.AddRange(New Object() {UltraDataColumn273, UltraDataColumn274, UltraDataColumn275, UltraDataColumn276, UltraDataColumn277, UltraDataColumn278, UltraDataColumn279, UltraDataColumn280, UltraDataColumn281, UltraDataColumn282, UltraDataColumn283, UltraDataColumn284, UltraDataColumn285, UltraDataColumn286, UltraDataColumn287, UltraDataColumn288, UltraDataColumn289, UltraDataColumn290, UltraDataColumn291, UltraDataColumn292, UltraDataColumn293, UltraDataColumn294, UltraDataColumn295, UltraDataColumn296, UltraDataColumn297, UltraDataColumn298, UltraDataColumn299, UltraDataColumn300, UltraDataColumn301})
        '
        'ogdOperacionDetalle
        '
        UltraDataColumn306.DataType = GetType(Double)
        UltraDataColumn307.DataType = GetType(Double)
        UltraDataColumn308.DataType = GetType(Boolean)
        UltraDataColumn309.DataType = GetType(Boolean)
        UltraDataColumn312.DataType = GetType(Double)
        UltraDataColumn313.DataType = GetType(Object)
        UltraDataColumn314.DataType = GetType(Double)
        UltraDataColumn319.DataType = GetType(Boolean)
        UltraDataColumn328.DataType = GetType(Boolean)
        Me.ogdOperacionDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn302, UltraDataColumn303, UltraDataColumn304, UltraDataColumn305, UltraDataColumn306, UltraDataColumn307, UltraDataColumn308, UltraDataColumn309, UltraDataColumn310, UltraDataColumn311, UltraDataColumn312, UltraDataColumn313, UltraDataColumn314, UltraDataColumn315, UltraDataColumn316, UltraDataColumn317, UltraDataColumn318, UltraDataColumn319, UltraDataColumn320, UltraDataColumn321, UltraDataColumn322, UltraDataColumn323, UltraDataColumn324, UltraDataColumn325, UltraDataColumn326, UltraDataColumn327, UltraDataColumn328, UltraDataColumn329, UltraDataColumn330, UltraDataColumn331, UltraDataColumn332, UltraDataColumn333, UltraDataColumn334, UltraDataColumn335, UltraDataColumn336, UltraDataColumn337, UltraDataColumn338, UltraDataColumn339, UltraDataColumn340})
        '
        'UltraDataSource3
        '
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn341, UltraDataColumn342, UltraDataColumn343, UltraDataColumn344, UltraDataColumn345, UltraDataColumn346, UltraDataColumn347, UltraDataColumn348, UltraDataColumn349, UltraDataColumn350, UltraDataColumn351, UltraDataColumn352, UltraDataColumn353, UltraDataColumn354, UltraDataColumn355, UltraDataColumn356, UltraDataColumn357, UltraDataColumn358, UltraDataColumn359, UltraDataColumn360, UltraDataColumn361, UltraDataColumn362, UltraDataColumn363, UltraDataColumn364, UltraDataColumn365, UltraDataColumn366, UltraDataColumn367, UltraDataColumn368, UltraDataColumn369, UltraDataColumn370, UltraDataColumn371, UltraDataColumn372})
        '
        'tcComprobanteCompra
        '
        Me.tcComprobanteCompra.Controls.Add(Me.UltraTabPageControl1)
        Me.tcComprobanteCompra.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcComprobanteCompra.Controls.Add(Me.UltraTabPageControl2)
        Me.tcComprobanteCompra.Controls.Add(Me.UltraTabPageControl4)
        Me.tcComprobanteCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcComprobanteCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcComprobanteCompra.Location = New System.Drawing.Point(0, 0)
        Me.tcComprobanteCompra.Name = "tcComprobanteCompra"
        Me.tcComprobanteCompra.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcComprobanteCompra.Size = New System.Drawing.Size(1241, 733)
        Me.tcComprobanteCompra.TabIndex = 0
        UltraTab3.Key = "Lista"
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Lista"
        UltraTab4.Key = "Mantenimiento"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Mantenimiento"
        UltraTab1.Key = "Asignar"
        UltraTab1.TabPage = Me.UltraTabPageControl4
        UltraTab1.Text = "Asignar Viaje"
        Me.tcComprobanteCompra.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab1})
        Me.tcComprobanteCompra.TabStop = False
        Me.tcComprobanteCompra.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1239, 710)
        '
        'object_855f81c2_3cbe_4b7a_881f_c489a882030f
        '
        Appearance169.ForeColor = System.Drawing.Color.Black
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Appearance = Appearance169
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.ForeColor = System.Drawing.Color.Black
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.FormatString = ""
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Location = New System.Drawing.Point(1, 0)
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Margin = New System.Windows.Forms.Padding(142, 43, 142, 43)
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.MaskInput = "nnnn"
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.MaxValue = 2020
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.MinValue = 2000
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Name = "object_855f81c2_3cbe_4b7a_881f_c489a882030f"
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.NullText = "0"
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Size = New System.Drawing.Size(2714, 21)
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.TabIndex = 0
        Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f.Value = 2013
        '
        'object_dad2a13d_427e_4777_870d_044a3363ce53
        '
        Appearance170.ForeColor = System.Drawing.Color.Black
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Appearance = Appearance170
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.ForeColor = System.Drawing.Color.Black
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.FormatString = ""
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Location = New System.Drawing.Point(1, 0)
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Margin = New System.Windows.Forms.Padding(191, 54, 191, 54)
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.MaskInput = "nnnn"
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.MaxValue = 2020
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.MinValue = 2000
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Name = "object_dad2a13d_427e_4777_870d_044a3363ce53"
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.NullText = "0"
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Size = New System.Drawing.Size(3620, 21)
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.TabIndex = 0
        Me.object_dad2a13d_427e_4777_870d_044a3363ce53.Value = 2013
        '
        'object_b0dda586_e2d5_4d7e_8bc1_45e71784c992
        '
        Appearance171.ForeColor = System.Drawing.Color.Black
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Appearance = Appearance171
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.ForeColor = System.Drawing.Color.Black
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.FormatString = ""
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Location = New System.Drawing.Point(1, 0)
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Margin = New System.Windows.Forms.Padding(2567, 350, 2567, 350)
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.MaskInput = "nnnn"
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.MaxValue = 2020
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.MinValue = 2000
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Name = "object_b0dda586_e2d5_4d7e_8bc1_45e71784c992"
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.NullText = "0"
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Size = New System.Drawing.Size(48202, 21)
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.TabIndex = 0
        Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992.Value = 2013
        '
        'NumeroEntero3
        '
        Appearance172.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.Appearance = Appearance172
        Me.NumeroEntero3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero3.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.FormatString = ""
        Me.NumeroEntero3.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero3.Margin = New System.Windows.Forms.Padding(2567, 350, 2567, 350)
        Me.NumeroEntero3.MaskInput = "nnnn"
        Me.NumeroEntero3.MaxValue = 2020
        Me.NumeroEntero3.MinValue = 2000
        Me.NumeroEntero3.Name = "NumeroEntero3"
        Me.NumeroEntero3.NullText = "0"
        Me.NumeroEntero3.Size = New System.Drawing.Size(48202, 21)
        Me.NumeroEntero3.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero3.TabIndex = 0
        Me.NumeroEntero3.Value = 2013
        '
        'NumeroEntero4
        '
        Appearance173.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.Appearance = Appearance173
        Me.NumeroEntero4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero4.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.FormatString = ""
        Me.NumeroEntero4.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero4.Margin = New System.Windows.Forms.Padding(2567, 350, 2567, 350)
        Me.NumeroEntero4.MaskInput = "nnnn"
        Me.NumeroEntero4.MaxValue = 2020
        Me.NumeroEntero4.MinValue = 2000
        Me.NumeroEntero4.Name = "NumeroEntero4"
        Me.NumeroEntero4.NullText = "0"
        Me.NumeroEntero4.Size = New System.Drawing.Size(48202, 21)
        Me.NumeroEntero4.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero4.TabIndex = 0
        Me.NumeroEntero4.Value = 2011
        '
        'NumeroEntero5
        '
        Appearance174.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.Appearance = Appearance174
        Me.NumeroEntero5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero5.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.FormatString = ""
        Me.NumeroEntero5.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero5.Margin = New System.Windows.Forms.Padding(2567, 350, 2567, 350)
        Me.NumeroEntero5.MaskInput = "nnnn"
        Me.NumeroEntero5.MaxValue = 2020
        Me.NumeroEntero5.MinValue = 2000
        Me.NumeroEntero5.Name = "NumeroEntero5"
        Me.NumeroEntero5.NullText = "0"
        Me.NumeroEntero5.Size = New System.Drawing.Size(48202, 21)
        Me.NumeroEntero5.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero5.TabIndex = 0
        Me.NumeroEntero5.Value = 2011
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LstDetalleDocumentoCombustibleBindingSource
        '
        Me.LstDetalleDocumentoCombustibleBindingSource.DataMember = "lstDetalleDocumentoCombustible"
        Me.LstDetalleDocumentoCombustibleBindingSource.DataSource = Me.EMovimientoDocumentoBindingSource
        '
        'frm_MovimientoPeaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1241, 733)
        Me.Controls.Add(Me.tcComprobanteCompra)
        Me.Name = "frm_MovimientoPeaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento Peaje"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griMovimientoPeajeImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMovimientoPeaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griMovPeajeCovisol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.agrOrdenesdeTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOrdenesdeTransferencia.ResumeLayout(False)
        CType(Me.grid_ListaAsociaMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odRegConsumoCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.gbTanqueosNoAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTanqueosNoAsociados.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.grid_ListaMPnoAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odTanqueosNoAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.gridListaMovimientoPeaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.tcComprobanteDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcComprobanteDetalle.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.ColorMontoIncorrecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDetalle.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.PerformLayout()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGastonFuncion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoCabeceraAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoCabeceraAsiento.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbeCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.ficConCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficConCombustible.ResumeLayout(False)
        CType(Me.gbeConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeConsultar.ResumeLayout(False)
        Me.ChkSeleccion.ResumeLayout(False)
        CType(Me.grFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grFiltro.ResumeLayout(False)
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        Me.UltraGroupBox6.PerformLayout()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoEstado.ResumeLayout(False)
        Me.grupoEstado.PerformLayout()
        CType(Me.ColorReembolsado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPendiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorHabilitada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorLiquidada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorNoReembolsado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMovimientoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcComprobanteCompra.ResumeLayout(False)
        CType(Me.object_855f81c2_3cbe_4b7a_881f_c489a882030f, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_dad2a13d_427e_4777_870d_044a3363ce53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_b0dda586_e2d5_4d7e_8bc1_45e71784c992, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LstDetalleDocumentoCombustibleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcComprobanteCompra As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridListaMovimientoPeaje As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tcComprobanteDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoCompra As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoDocumento As ISL.Controles.Combo
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents UltraDataSource4 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents Año As ISL.Win.Año
    Friend WithEvents object_855f81c2_3cbe_4b7a_881f_c489a882030f As ISL.Controles.NumeroEntero
    Friend WithEvents object_dad2a13d_427e_4777_870d_044a3363ce53 As ISL.Controles.NumeroEntero
    Friend WithEvents object_b0dda586_e2d5_4d7e_8bc1_45e71784c992 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero3 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero4 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero5 As ISL.Controles.NumeroEntero
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grupoCabeceraAsiento As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ogdOperacionDetalle As ISL.Controles.OrigenDatos
    Private WithEvents cbeCtaCte As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents EMovimientoDocumentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents btnValidar As ISL.Controles.Boton
    Friend WithEvents btnGuardar As ISL.Controles.Boton
    Friend WithEvents btnBuscar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents grupoDetalle As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Etiqueta34 As ISL.Controles.Etiqueta
    Friend WithEvents cboCuenta As ISL.Controles.Combo
    Friend WithEvents cboGastonFuncion As ISL.Controles.Combo
    Friend WithEvents cboItemGasto As ISL.Controles.Combo
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents dtpFechaEjercicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents odTanqueosNoAsociados As ISL.Controles.OrigenDatos
    Friend WithEvents odRegConsumoCombustible As ISL.Controles.OrigenDatos
    Friend WithEvents ficConCombustible As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrOrdenesdeTransferencia As ISL.Controles.Agrupacion
    Friend WithEvents grid_ListaAsociaMP As ISL.Controles.Grilla
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents lblExpande As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnExpande1 As ISL.Controles.Boton
    Friend WithEvents btnExpande2 As ISL.Controles.Boton
    Friend WithEvents btnExpande3 As ISL.Controles.Boton
    Friend WithEvents gbTanqueosNoAsociados As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btn_ListarTanqNoAsoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents grid_ListaMPnoAsoc As ISL.Controles.Grilla
    Friend WithEvents gbeConsultar As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents ChkSeleccion As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grFiltro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rfHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblVehi As ISL.Controles.Etiqueta
    Friend WithEvents odMovimientoPeaje As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents LstDetalleDocumentoCombustibleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnNuevo As ISL.Controles.Boton
    Friend WithEvents griMovimientoPeajeImportar As ISL.Controles.Grilla
    Friend WithEvents grupoEstado As ISL.Controles.Agrupacion
    Friend WithEvents ColorReembolsado As ISL.Controles.Colores
    Friend WithEvents ColorPendiente As ISL.Controles.Colores
    Friend WithEvents ColorHabilitada As ISL.Controles.Colores
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents ColorLiquidada As ISL.Controles.Colores
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents ColorNoReembolsado As ISL.Controles.Colores
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents ugb_Espera2 As ISL.Win.Espere
    Friend WithEvents ugb_Espera3 As ISL.Win.Espere
    Friend WithEvents cboTractoLista As ISL.Controles.Combo
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griMovPeajeCovisol As ISL.Controles.Grilla
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpHastaCovisol As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesdeCovisol As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNuevoCovisol As ISL.Controles.Boton
    Friend WithEvents btnValidarCovisol As ISL.Controles.Boton
    Friend WithEvents btnBuscarCovisol As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGuardarCovisol As ISL.Controles.Boton
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents ColorMontoIncorrecto As ISL.Controles.Colores
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta

End Class
