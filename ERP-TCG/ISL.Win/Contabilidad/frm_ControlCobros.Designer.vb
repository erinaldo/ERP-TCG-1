<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ControlCobros
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
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoCajaBanco")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMe")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsiento")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FlujoCaja", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocumentoCancelacion")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCodigoObligacion")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroBoucher")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medio")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAsiento")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsiento")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorriente")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoCajaBanco")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoDocumento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMN")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMe")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlujoCaja")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsiento")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FlujoCaja")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DocumentoCancelacion")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCodigoObligacion")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroBoucher")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medio")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoAsiento")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsiento")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorriente")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoCajaBanco")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlujoCaja")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroBoucher")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnulado")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abrev_Empresa")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndElectronico")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Item")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnticipo")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAfectaAnticipo")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto_Anticipo")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ControlCobros))
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPersonaEmpresa")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersona")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaActividad")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Email")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Contacto")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresa")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dni")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("oePersona")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("oeEmpresa")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoCajaBanco")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroBoucher")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnulado")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abrev_Empresa")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Item")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnticipo")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAfectaAnticipo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto_Anticipo")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPersonaEmpresa")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActividad")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oePersona")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oeEmpresa")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GridCobros = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextualCobro = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExtornarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GridAnticipos = New ISL.Controles.Grilla(Me.components)
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.ordCliente = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gridDocumentos = New ISL.Controles.Grilla(Me.components)
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.tabAsociados = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.dtpFechaEjercicio = New System.Windows.Forms.DateTimePicker()
        Me.cboCliente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtRuc = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.GridCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextualCobro.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.GridAnticipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel2.ClientArea.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        CType(Me.tabAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAsociados.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.GridCobros)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1116, 235)
        '
        'GridCobros
        '
        Me.GridCobros.ContextMenuStrip = Me.MenuContextualCobro
        Me.GridCobros.DataSource = Me.UltraDataSource1
        UltraGridColumn38.Header.VisiblePosition = 0
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 7
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn40.Header.VisiblePosition = 1
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn41.Header.VisiblePosition = 2
        UltraGridColumn41.Width = 82
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance1
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn42.Format = "#,##0.00"
        UltraGridColumn42.Header.Caption = "Monto S/."
        UltraGridColumn42.Header.VisiblePosition = 5
        UltraGridColumn42.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn43.CellAppearance = Appearance2
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn43.Format = "#,##0.00"
        UltraGridColumn43.Header.Caption = "Monto $"
        UltraGridColumn43.Header.VisiblePosition = 6
        UltraGridColumn43.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn44.Header.Caption = "Cuenta Bancaria"
        UltraGridColumn44.Header.VisiblePosition = 10
        UltraGridColumn44.Width = 250
        UltraGridColumn45.Header.VisiblePosition = 8
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 11
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 12
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 3
        UltraGridColumn48.Width = 173
        UltraGridColumn49.Header.VisiblePosition = 13
        UltraGridColumn49.Width = 176
        UltraGridColumn50.Header.VisiblePosition = 14
        UltraGridColumn50.Width = 158
        UltraGridColumn51.Header.VisiblePosition = 9
        UltraGridColumn52.Header.VisiblePosition = 4
        UltraGridColumn52.Width = 141
        UltraGridColumn53.Header.VisiblePosition = 18
        UltraGridColumn53.Width = 325
        UltraGridColumn54.Header.VisiblePosition = 16
        UltraGridColumn55.Header.VisiblePosition = 17
        UltraGridColumn100.Header.VisiblePosition = 15
        UltraGridColumn10.Header.VisiblePosition = 19
        UltraGridColumn10.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn100, UltraGridColumn10})
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridBand1.SummaryFooterCaption = ""
        Me.GridCobros.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.GridCobros.DisplayLayout.MaxColScrollRegions = 1
        Me.GridCobros.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridCobros.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GridCobros.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GridCobros.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridCobros.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.GridCobros.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GridCobros.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GridCobros.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridCobros.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GridCobros.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridCobros.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GridCobros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCobros.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCobros.Location = New System.Drawing.Point(0, 0)
        Me.GridCobros.Name = "GridCobros"
        Me.GridCobros.Size = New System.Drawing.Size(1116, 235)
        Me.GridCobros.TabIndex = 0
        Me.GridCobros.TabStop = False
        Me.GridCobros.Text = "Cobros"
        '
        'MenuContextualCobro
        '
        Me.MenuContextualCobro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExtornarToolStripMenuItem})
        Me.MenuContextualCobro.Name = "MenuContextualCobro"
        Me.MenuContextualCobro.Size = New System.Drawing.Size(119, 26)
        '
        'ExtornarToolStripMenuItem
        '
        Me.ExtornarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.ExtornarToolStripMenuItem.Name = "ExtornarToolStripMenuItem"
        Me.ExtornarToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ExtornarToolStripMenuItem.Text = "Extornar"
        '
        'UltraDataSource1
        '
        UltraDataColumn9.DataType = GetType(Boolean)
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.GridAnticipos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1116, 235)
        '
        'GridAnticipos
        '
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Hidden = True
        UltraGridColumn80.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn80.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn80.Header.VisiblePosition = 1
        UltraGridColumn76.Header.VisiblePosition = 2
        UltraGridColumn76.Width = 113
        UltraGridColumn77.Header.VisiblePosition = 3
        UltraGridColumn77.Width = 175
        UltraGridColumn78.Header.VisiblePosition = 4
        UltraGridColumn78.Width = 91
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn79.CellAppearance = Appearance3
        UltraGridColumn79.Header.VisiblePosition = 5
        UltraGridColumn79.Width = 107
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn80, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79})
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridBand2.SummaryFooterCaption = ""
        Me.GridAnticipos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.GridAnticipos.DisplayLayout.MaxColScrollRegions = 1
        Me.GridAnticipos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridAnticipos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GridAnticipos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GridAnticipos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridAnticipos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.GridAnticipos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GridAnticipos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GridAnticipos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridAnticipos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GridAnticipos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridAnticipos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GridAnticipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAnticipos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridAnticipos.Location = New System.Drawing.Point(0, 0)
        Me.GridAnticipos.Name = "GridAnticipos"
        Me.GridAnticipos.Size = New System.Drawing.Size(1116, 235)
        Me.GridAnticipos.TabIndex = 1
        Me.GridAnticipos.TabStop = False
        Me.GridAnticipos.Text = "Anticipos"
        '
        'UltraDataSource2
        '
        UltraDataColumn59.DataType = GetType(Boolean)
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69})
        Me.UltraDataSource2.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "16 (Ok).ico")
        Me.imagenes.Images.SetKeyName(1, "16 (Money bag).ico")
        Me.imagenes.Images.SetKeyName(2, "16 (Minus).ico")
        Me.imagenes.Images.SetKeyName(3, "16 (Delete).ico")
        Me.imagenes.Images.SetKeyName(4, "16 (File new).ico")
        '
        'ordCliente
        '
        UltraDataColumn75.DataType = GetType(Boolean)
        Me.ordCliente.Band.Columns.AddRange(New Object() {UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.SplitContainer1)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1124, 602)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Busqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 52)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridDocumentos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1118, 547)
        Me.SplitContainer1.SplitterDistance = 285
        Me.SplitContainer1.TabIndex = 16
        Me.SplitContainer1.TabStop = False
        '
        'gridDocumentos
        '
        Me.gridDocumentos.DataSource = Me.UltraDataSource2
        UltraGridColumn101.Header.VisiblePosition = 0
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 1
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn103.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn103.Header.Caption = "TipoDoc."
        UltraGridColumn103.Header.VisiblePosition = 3
        UltraGridColumn103.Width = 138
        UltraGridColumn104.Header.VisiblePosition = 4
        UltraGridColumn104.Width = 70
        UltraGridColumn105.Header.VisiblePosition = 5
        UltraGridColumn105.Width = 100
        UltraGridColumn106.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn106.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn106.Header.Caption = "Fec Emision"
        UltraGridColumn106.Header.VisiblePosition = 6
        UltraGridColumn106.Width = 86
        UltraGridColumn107.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn107.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn107.Header.Caption = "Fec Venc."
        UltraGridColumn107.Header.VisiblePosition = 7
        UltraGridColumn107.Width = 80
        UltraGridColumn108.Header.VisiblePosition = 11
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 12
        UltraGridColumn109.Hidden = True
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn110.CellAppearance = Appearance4
        UltraGridColumn110.Format = "#,##0.00"
        UltraGridColumn110.Header.VisiblePosition = 9
        UltraGridColumn110.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn111.CellAppearance = Appearance5
        UltraGridColumn111.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn111.Format = "#,##0.00"
        UltraGridColumn111.Header.VisiblePosition = 10
        UltraGridColumn111.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn112.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn112.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn112.Header.Caption = "Cliente"
        UltraGridColumn112.Header.VisiblePosition = 2
        UltraGridColumn112.Width = 300
        UltraGridColumn113.Header.VisiblePosition = 13
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 14
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 15
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn116.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn116.Header.Caption = "Mon."
        UltraGridColumn116.Header.VisiblePosition = 8
        UltraGridColumn116.Width = 50
        UltraGridColumn117.Header.VisiblePosition = 16
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 17
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.Header.Caption = "Detraccion"
        UltraGridColumn119.Header.VisiblePosition = 18
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 19
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.Header.VisiblePosition = 20
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.Header.VisiblePosition = 21
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn123.Header.Caption = "Monto a Cobrar"
        UltraGridColumn123.Header.VisiblePosition = 22
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.Header.VisiblePosition = 23
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 24
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 25
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 26
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.VisiblePosition = 27
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.Header.VisiblePosition = 28
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.VisiblePosition = 29
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.Header.VisiblePosition = 30
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.Header.VisiblePosition = 31
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.Header.VisiblePosition = 32
        UltraGridColumn133.Hidden = True
        UltraGridColumn134.Header.VisiblePosition = 33
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 34
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 35
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.Header.VisiblePosition = 36
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.Header.VisiblePosition = 37
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.Header.VisiblePosition = 38
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.Header.VisiblePosition = 39
        UltraGridColumn140.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 40
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 41
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 42
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 43
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 44
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 45
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 46
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 47
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 48
        UltraGridColumn9.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        UltraGridBand3.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentos.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.gridDocumentos.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDocumentos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDocumentos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDocumentos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDocumentos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridDocumentos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDocumentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridDocumentos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDocumentos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridDocumentos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDocumentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDocumentos.Location = New System.Drawing.Point(0, 0)
        Me.gridDocumentos.Name = "gridDocumentos"
        Me.gridDocumentos.Size = New System.Drawing.Size(1118, 285)
        Me.gridDocumentos.TabIndex = 0
        Me.gridDocumentos.TabStop = False
        Me.gridDocumentos.Text = "Documentos"
        '
        'UltraPanel2
        '
        '
        'UltraPanel2.ClientArea
        '
        Me.UltraPanel2.ClientArea.Controls.Add(Me.tabAsociados)
        Me.UltraPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel2.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(1118, 258)
        Me.UltraPanel2.TabIndex = 17
        '
        'tabAsociados
        '
        Me.tabAsociados.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabAsociados.Controls.Add(Me.UltraTabPageControl1)
        Me.tabAsociados.Controls.Add(Me.UltraTabPageControl2)
        Me.tabAsociados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAsociados.Location = New System.Drawing.Point(0, 0)
        Me.tabAsociados.Name = "tabAsociados"
        Me.tabAsociados.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabAsociados.Size = New System.Drawing.Size(1118, 258)
        Me.tabAsociados.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.tabAsociados.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Cobros"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Anticipos"
        Me.tabAsociados.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tabAsociados.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1116, 235)
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.dtpFechaEjercicio)
        Me.Agrupacion3.Controls.Add(Me.cboCliente)
        Me.Agrupacion3.Controls.Add(Me.txtRuc)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion3.Controls.Add(Me.cboMes)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.Agrupacion3.Location = New System.Drawing.Point(3, 17)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1118, 35)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'dtpFechaEjercicio
        '
        Me.dtpFechaEjercicio.CustomFormat = "yyyy"
        Me.dtpFechaEjercicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaEjercicio.Location = New System.Drawing.Point(81, 9)
        Me.dtpFechaEjercicio.Name = "dtpFechaEjercicio"
        Me.dtpFechaEjercicio.ShowUpDown = True
        Me.dtpFechaEjercicio.Size = New System.Drawing.Size(52, 21)
        Me.dtpFechaEjercicio.TabIndex = 1
        '
        'cboCliente
        '
        Me.cboCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.CheckedListSettings.ListSeparator = ","
        Me.cboCliente.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn56.Header.VisiblePosition = 0
        UltraGridColumn56.Hidden = True
        UltraGridColumn56.Width = 19
        UltraGridColumn57.Header.VisiblePosition = 1
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.Width = 18
        UltraGridColumn58.Header.VisiblePosition = 2
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.Width = 31
        UltraGridColumn59.Header.VisiblePosition = 3
        UltraGridColumn59.Hidden = True
        UltraGridColumn59.Width = 28
        UltraGridColumn60.Header.VisiblePosition = 4
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.Width = 25
        UltraGridColumn61.Header.VisiblePosition = 5
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.Width = 17
        UltraGridColumn62.Header.VisiblePosition = 6
        UltraGridColumn62.Hidden = True
        UltraGridColumn62.Width = 25
        UltraGridColumn63.Header.VisiblePosition = 7
        UltraGridColumn63.Hidden = True
        UltraGridColumn63.Width = 25
        UltraGridColumn64.Header.VisiblePosition = 8
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.Width = 25
        UltraGridColumn65.Header.VisiblePosition = 9
        UltraGridColumn65.Hidden = True
        UltraGridColumn65.Width = 54
        UltraGridColumn66.Header.VisiblePosition = 10
        UltraGridColumn66.Width = 200
        UltraGridColumn67.Header.VisiblePosition = 11
        UltraGridColumn67.Hidden = True
        UltraGridColumn67.Width = 54
        UltraGridColumn68.Header.VisiblePosition = 12
        UltraGridColumn68.Hidden = True
        UltraGridColumn68.Width = 55
        UltraGridColumn69.Header.VisiblePosition = 13
        UltraGridColumn69.Width = 198
        UltraGridColumn70.Header.VisiblePosition = 14
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 15
        UltraGridColumn71.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71})
        Me.cboCliente.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.DropDownWidth = 400
        Me.cboCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.Location = New System.Drawing.Point(506, 7)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(400, 23)
        Me.cboCliente.TabIndex = 6
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRuc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(388, 7)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(111, 22)
        Me.txtRuc.TabIndex = 5
        Me.txtRuc.TabStop = False
        '
        'Etiqueta1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance6
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(304, 12)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(86, 15)
        Me.Etiqueta1.TabIndex = 4
        Me.Etiqueta1.Text = "Cliente (RUC):"
        '
        'Etiqueta7
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance7
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(137, 12)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta7.TabIndex = 2
        Me.Etiqueta7.Text = "Mes:"
        '
        'cboMes
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Appearance = Appearance8
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Location = New System.Drawing.Point(173, 8)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(125, 22)
        Me.cboMes.TabIndex = 3
        Me.cboMes.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance9
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(18, 12)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta2.TabIndex = 0
        Me.Etiqueta2.Text = "Ejercicio:"
        '
        'frm_ControlCobros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 602)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_ControlCobros"
        Me.Text = "Control de Cobros"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.GridCobros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextualCobro.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.GridAnticipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel2.ClientArea.ResumeLayout(False)
        Me.UltraPanel2.ResumeLayout(False)
        CType(Me.tabAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAsociados.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents gridDocumentos As ISL.Controles.Grilla
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents GridCobros As ISL.Controles.Grilla
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents cboCliente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtRuc As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ordCliente As ISL.Controles.OrigenDatos
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents MenuContextualCobro As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExtornarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents dtpFechaEjercicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents tabAsociados As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GridAnticipos As ISL.Controles.Grilla
End Class
