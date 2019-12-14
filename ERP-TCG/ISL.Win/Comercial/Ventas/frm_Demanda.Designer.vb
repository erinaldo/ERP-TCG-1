<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Demanda
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
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAtendida")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalComision")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 2")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCancelacion", 0)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala", 1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador", 2)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSolicita", 3)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala", 4)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoEscala", 5)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Justificacion", 6)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 7)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRecepcion", 8)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoPredemanda", 9)
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", -1)
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega ")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 2", -1)
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tercero")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Demanda))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcularIgv")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcularSinIgv")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteFinal")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteCalcularIgv")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteCalcularSinIgv")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClienteFinal")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCarga")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcularIgv")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcularSinIgv")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteFinal")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionLugarLlegada", 0)
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionLugarPartida", 1)
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador", 2)
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIGVConsolidado", 3)
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado", 4)
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoConsolidado", 5)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstiba", 6)
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionOrigen", 7)
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionDestino", 8)
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 9)
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionLugarPartida", 10)
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionLugarLlegada", 11)
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoCarga", 12)
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteFinal", 13)
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material", 14)
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente", 15)
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargar", 16)
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descarga", 17)
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete", 18)
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstibaDescarga", 19)
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Programado", 20)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorProgramar", 21)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoEfectivoDeposito", 22, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario", 23)
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FalsoFlete", 24)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContactoCarga", 25)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContactoDescarga", 26)
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lugar")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FlujoCaja")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigencia")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Lugar")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FlujoCaja")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlujoCaja")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigencia")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo13 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Comentario de Consolidado", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo14 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Modificar Flete Unitario", Infragistics.Win.ToolTipImage.[Default], "Valida Flete Unitario", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim CalculatorButton1 As Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton = New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton(15)
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim CalculatorButton2 As Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton = New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton(15)
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton6 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarCliente")
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton7 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoCliente")
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton8 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarCliente")
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton9 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoCliente")
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo15 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Telefono", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo16 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("RUC Cliente", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim EditorButton10 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarClienteFinal")
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton11 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarComisionista")
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton12 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoComisionista")
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton13 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarCliente")
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo17 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccione Cliente", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionDetalle")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContacto")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoFlete")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoComision")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndOperacion")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacionDetalle")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTercero")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdContacto")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Igv")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoFlete")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AdelantoFlete")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoComision")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFacturado")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndOperacion")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoDocumento")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Telefono", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarCliente")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoCliente")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditar")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Observaciones del Contrato de Terceros", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Refencia del Punto de Llegada ", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
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
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdComisionista")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuario")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Justificacion")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdComisionista")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuario")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Justificacion")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEscala")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioSeguimiento")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaOrigen")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaDestino")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaDestino")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaNoche")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaOperaciones")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaSeguimiento")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecha")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo6 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Estados Viaje", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo5 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Estados", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo12 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Trabajador / Vehiculos No Disponible", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo11 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("No Disponibles", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo7 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el piloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo8 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el piloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo9 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el piloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo10 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el copiloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraToolTipInfo4 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Ingrese observacion", Infragistics.Win.ToolTipImage.[Default], "", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega ")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataBand2 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tercero")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Contacto")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Igv")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAtendida")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalComision")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Selec")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("COD_VEHICULO")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PLACA_VEH")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IND_MOTRIZ")
        Dim UltraDataColumn184 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TIPO_VEH")
        Dim UltraDataColumn185 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MARCA_VEH")
        Dim UltraDataColumn186 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ULT_FEC_OPER")
        Dim UltraDataColumn187 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ULT_DESTINO")
        Dim UltraDataColumn188 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOperacion")
        Dim UltraDataColumn189 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoMantenimiento")
        Dim UltraDataColumn190 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("REFERENCIA")
        Dim UltraDataColumn191 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FECH_REF")
        Dim UltraDataColumn192 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CAN_HOROMETRO")
        Dim UltraDataColumn193 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn194 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ModeloFuncional")
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griLista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramarViaje = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoAsignada = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarDemanda = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevertirDemandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griFactura = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarDetalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoDetalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDuplicar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdDemandaDetalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.exgruFlete = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel11 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griTarifasProveedor = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdTarifasProveedor = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtGlosaCostoEstibaDesc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCostoEstibaDescarga = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.chkConsolidado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtConsolidado = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.chkCostoEstivaDescarga = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtMotivoConsolidado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chkIGVConsolidado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtCostoEstiba = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.chkCostoEstiva = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.chkIndFalsoFlete = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel37 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtAdelantoFlete = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.verValidaFU = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtComision = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtSubtotal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.verFacturado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.lblSubtotal = New Infragistics.Win.Misc.UltraLabel()
        Me.CalFleteUnitarioIGV = New ISL.Controles.NumeroCalculadora(Me.components)
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.verIncluyeIgv = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtFleteTotalDetalle = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.CalFleteUnitario = New ISL.Controles.NumeroCalculadora(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.opPagoCont = New ISL.Controles.Opciones(Me.components)
        Me.verCargar = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verDescarga = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verPagoContraEntrega = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.exgruDetalle = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel40 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtTelfDescarga = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtTelfCarga = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboContactoDescarga = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboContactoCarga = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel38 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboDireccionLlegada = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboDireccionPartida = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtApellidoMaterno = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNombreComisonista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtApellidoPaternoComisionista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtTelefonoComisionista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboDestinoDetalle = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboOrigenDetalle = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRucComisionista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtRucCLienteFinal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtRucCLiente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboMaterial = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboTipoCarga = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboClienteFinal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboComisionista = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCantidad = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblClienteFinal = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetalleTercero = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdDetalleTercero = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.chkIndPlantilla = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtTelefonoContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtApellidoMaternoContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNombreContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtApellidoPaternoContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtRucContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtRucEmpresaTransportista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboContacto = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboTercero = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.numCantidadTercero = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel66 = New Infragistics.Win.Misc.UltraLabel()
        Me.numSubTotalTercero = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel67 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtObservacionTercero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel43 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtReferenciaTercero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.numFleteTotalTerc = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.numIgvTerc = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.cboMonedaT = New ISL.Controles.Combo(Me.components)
        Me.btnAgregarTerc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.numFleteUnitarioTerc = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel33 = New Infragistics.Win.Misc.UltraLabel()
        Me.numComisionTerc = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel34 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel35 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDemandaRapida = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdDemandaRapida = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraExpandableGroupBox3 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraExpandableGroupBox7 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel7 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.numDiasAntes = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorPorVencer = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorVencidas = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboZonaPreDemanda = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnConsultaPreDemanda = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.griDisponibleVehiculo = New ISL.Controles.Grilla(Me.components)
        Me.ogdDisponibleVehiculos = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel8 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraExpandableGroupBox4 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel10 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.lblListoRegistro = New Infragistics.Win.Misc.UltraLabel()
        Me.btnConsultarDisponibles = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel59 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboZonaDisponibles = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta47 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorParihueleroD = New ISL.Controles.Colores(Me.components)
        Me.ColorPlataformaD = New ISL.Controles.Colores(Me.components)
        Me.ColorCamion20M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTolvaVolteoD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion65M3D = New ISL.Controles.Colores(Me.components)
        Me.ColorContenedorD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta222 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorGraneleroD = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgonD = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgonLargoD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamionetaD = New ISL.Controles.Colores(Me.components)
        Me.ColorVolqueteD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion30M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCaliceraD = New ISL.Controles.Colores(Me.components)
        Me.ColorCamion40M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorMediaBarandaD = New ISL.Controles.Colores(Me.components)
        Me.exgruDisponibleNo = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ColorAdvertencia = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorPiloto = New ISL.Controles.Colores(Me.components)
        Me.ColorAyudante = New ISL.Controles.Colores(Me.components)
        Me.ColorCarreta = New ISL.Controles.Colores(Me.components)
        Me.ColorTracto = New ISL.Controles.Colores(Me.components)
        Me.ColorCopiloto = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabDemandaCargas = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.chkExcluirDemandas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkTercerizadoFiltro = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verViajeRetorno = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboUsuario = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel62 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtTotalComisionLista = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtTotalFlotaLista = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorAprobada = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCancelada = New ISL.Controles.Colores(Me.components)
        Me.colorCambio = New ISL.Controles.Colores(Me.components)
        Me.VerAsignada = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorParcial = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorAsignada = New ISL.Controles.Colores(Me.components)
        Me.ColorGenerada = New ISL.Controles.Colores(Me.components)
        Me.etiDemandaGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabs = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExpandableGroupBox9 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel9 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel36 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkTercerizacion = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.udtHoraSolicita = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udtHoraAtencion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udtHoraRecepcion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtFechaRecepcion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblNumeroDemanda = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox14 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtComisionTotal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtFleteTotal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.NroDemanda = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.cboDestino = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboEscala = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboOrigen = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboTipoVehiculo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.numNroUnidades = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtMotivoEscala = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chkEscala = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtFechaAtencion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtSolicita = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNumero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtObservacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.exgruConsultas = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ficConsultas = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ogdListaDemanda = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.MenuDetalleTercero = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarContratoTercero = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdVehiculoEstadoSituacional = New ISL.Controles.OrigenDatos(Me.components)
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ficDemanda = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaRegistro.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        CType(Me.ogdDemandaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruFlete.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel11.SuspendLayout()
        CType(Me.griTarifasProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdTarifasProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.txtGlosaCostoEstibaDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCostoEstivaDescarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivoConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIGVConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCostoEstiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIndFalsoFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verValidaFU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verFacturado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalFleteUnitarioIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIncluyeIgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalFleteUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.opPagoCont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verDescarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verPagoContraEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruDetalle.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.txtTelfDescarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelfCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContactoDescarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContactoCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDireccionLlegada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDireccionPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreComisonista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoPaternoComisionista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoComisionista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDestinoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrigenDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucComisionista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucCLienteFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucCLiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClienteFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboComisionista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.griDetalleTercero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDetalleTercero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox6.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout()
        CType(Me.chkIndPlantilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaternoContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoPaternoContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucEmpresaTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTercero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacionTercero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferenciaTercero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonedaT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griDemandaRapida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDemandaRapida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox3.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout()
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox7.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel7.SuspendLayout()
        CType(Me.numDiasAntes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPorVencer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVencidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboZonaPreDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.griDisponibleVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDisponibleVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel8.SuspendLayout()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox4.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel10.SuspendLayout()
        CType(Me.cboZonaDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.ColorParihueleroD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPlataformaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion20M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTolvaVolteoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion65M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorContenedorD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorGraneleroD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFurgonD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFurgonLargoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamionetaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVolqueteD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion30M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCaliceraD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCamion40M3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorMediaBarandaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruDisponibleNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruDisponibleNo.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.ColorAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAyudante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCopiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.tabDemandaCargas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDemandaCargas.SuspendLayout()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.chkExcluirDemandas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTercerizadoFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verViajeRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.ColorAprobada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCancelada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerAsignada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorParcial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAsignada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorGenerada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.tabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabs.SuspendLayout()
        CType(Me.UltraExpandableGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox9.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel9.SuspendLayout()
        CType(Me.chkTercerizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udtHoraSolicita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udtHoraAtencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udtHoraRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox14.SuspendLayout()
        CType(Me.NroDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNroUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivoEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaAtencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSolicita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruConsultas.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.ficConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficConsultas.SuspendLayout()
        CType(Me.ogdListaDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalleTercero.SuspendLayout()
        CType(Me.ogdVehiculoEstadoSituacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDemanda.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.agrListaRegistro)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1344, 522)
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.griLista)
        Me.agrListaRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaRegistro.Location = New System.Drawing.Point(0, 0)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(1344, 522)
        Me.agrListaRegistro.TabIndex = 1
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.Text = "Lista Registro"
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griLista
        '
        Me.griLista.AllowDrop = True
        Me.griLista.ContextMenuStrip = Me.Menu
        UltraGridColumn100.Header.VisiblePosition = 0
        UltraGridColumn100.Hidden = True
        UltraGridColumn100.Width = 85
        UltraGridColumn30.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn30.Header.VisiblePosition = 1
        UltraGridColumn30.Width = 90
        UltraGridColumn101.Header.VisiblePosition = 7
        UltraGridColumn101.Width = 148
        UltraGridColumn102.Header.VisiblePosition = 9
        UltraGridColumn102.Width = 118
        UltraGridColumn103.Header.VisiblePosition = 10
        UltraGridColumn103.Width = 111
        UltraGridColumn131.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn131.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn131.Header.Caption = "F.Atencion"
        UltraGridColumn131.Header.VisiblePosition = 3
        UltraGridColumn131.Width = 60
        UltraGridColumn132.Format = "#,###,###,##0.000"
        UltraGridColumn132.Header.VisiblePosition = 12
        UltraGridColumn132.MaskInput = "{LOC}$ n,nnn,nnn.nn"
        UltraGridColumn132.Width = 80
        UltraGridColumn133.Format = "#,###,##0.000"
        UltraGridColumn133.Header.Caption = "T.Comision"
        UltraGridColumn133.Header.VisiblePosition = 13
        UltraGridColumn133.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn133.Width = 60
        UltraGridColumn134.Header.VisiblePosition = 14
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.Caption = "Select"
        UltraGridColumn135.Header.VisiblePosition = 15
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 18
        UltraGridColumn136.Hidden = True
        UltraGridColumn136.Width = 150
        UltraGridColumn137.Header.VisiblePosition = 19
        UltraGridColumn137.Hidden = True
        UltraGridColumn137.Width = 150
        UltraGridColumn138.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn138.Header.VisiblePosition = 5
        UltraGridColumn138.Width = 200
        UltraGridColumn139.Header.VisiblePosition = 16
        UltraGridColumn139.Width = 150
        UltraGridColumn140.Header.VisiblePosition = 6
        UltraGridColumn140.Width = 100
        UltraGridColumn141.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn141.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn141.Header.VisiblePosition = 17
        UltraGridColumn141.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn141.Width = 207
        UltraGridColumn104.Header.VisiblePosition = 20
        UltraGridColumn105.Header.VisiblePosition = 21
        UltraGridColumn35.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn35.Header.Caption = "F.Cancelacion"
        UltraGridColumn35.Header.VisiblePosition = 24
        UltraGridColumn36.Header.VisiblePosition = 22
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 26
        UltraGridColumn5.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn5.Header.Caption = "F.Solicitada"
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn6.Header.VisiblePosition = 8
        UltraGridColumn7.Header.VisiblePosition = 23
        UltraGridColumn8.Header.VisiblePosition = 25
        UltraGridColumn11.Format = "#,###,###,##0.000"
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.MaskInput = "{LOC}$ n,nnn,nnn.nn"
        UltraGridColumn12.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn12.Header.Caption = "F.Recepcion"
        UltraGridColumn12.Header.VisiblePosition = 4
        UltraGridColumn12.Width = 76
        UltraGridColumn13.Header.VisiblePosition = 27
        UltraGridColumn13.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn100, UltraGridColumn30, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn104, UltraGridColumn105, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        UltraGridBand1.SummaryFooterCaption = "Totales:"
        UltraGridColumn106.Header.VisiblePosition = 0
        UltraGridColumn106.Hidden = True
        UltraGridColumn106.Width = 91
        UltraGridColumn107.Header.VisiblePosition = 1
        UltraGridColumn107.Width = 49
        UltraGridColumn108.Header.VisiblePosition = 2
        UltraGridColumn108.Width = 260
        UltraGridColumn109.Header.VisiblePosition = 3
        UltraGridColumn109.Width = 252
        UltraGridColumn110.Header.VisiblePosition = 4
        UltraGridColumn110.Width = 239
        UltraGridColumn111.Header.VisiblePosition = 5
        UltraGridColumn111.Width = 79
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn112.CellAppearance = Appearance1
        UltraGridColumn112.Header.VisiblePosition = 6
        UltraGridColumn113.Header.VisiblePosition = 7
        UltraGridColumn114.Header.VisiblePosition = 8
        UltraGridColumn115.Header.VisiblePosition = 9
        UltraGridColumn116.Header.VisiblePosition = 10
        UltraGridColumn117.Header.VisiblePosition = 11
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117})
        UltraGridBand2.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.HeaderIcons
        UltraGridBand2.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.None
        UltraGridColumn118.Header.VisiblePosition = 0
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.Header.VisiblePosition = 1
        UltraGridColumn119.Width = 240
        UltraGridColumn120.Header.VisiblePosition = 2
        UltraGridColumn120.Width = 197
        UltraGridColumn121.Header.VisiblePosition = 3
        UltraGridColumn121.Width = 66
        UltraGridColumn122.Header.VisiblePosition = 4
        UltraGridColumn122.Width = 72
        UltraGridColumn123.Header.VisiblePosition = 5
        UltraGridColumn124.Header.VisiblePosition = 6
        UltraGridColumn125.Header.VisiblePosition = 7
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.ImageList = Me.imagenes
        Me.griLista.Location = New System.Drawing.Point(2, 18)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1340, 502)
        Me.griLista.TabIndex = 1
        Me.griLista.Tag = ""
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Insert, Me.Update, Me.Delete, Me.ProgramarViaje, Me.EstadoAsignada, Me.CancelarDemanda, Me.EnviarCorreoToolStripMenuItem, Me.RevertirDemandaToolStripMenuItem})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(161, 180)
        '
        'Insert
        '
        Me.Insert.Image = CType(resources.GetObject("Insert.Image"), System.Drawing.Image)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(160, 22)
        Me.Insert.Text = "Nuevo"
        Me.Insert.ToolTipText = "Insertar una nueva Pre-Demanda"
        '
        'Update
        '
        Me.Update.Image = CType(resources.GetObject("Update.Image"), System.Drawing.Image)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(160, 22)
        Me.Update.Text = "Actualizar"
        Me.Update.ToolTipText = "Actualizar o modificar la Pre-Demanda seleccionada"
        '
        'Delete
        '
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(160, 22)
        Me.Delete.Text = "Eliminar"
        Me.Delete.ToolTipText = "Eliminar la Pre-Demanda seleccionada"
        '
        'ProgramarViaje
        '
        Me.ProgramarViaje.Image = CType(resources.GetObject("ProgramarViaje.Image"), System.Drawing.Image)
        Me.ProgramarViaje.Name = "ProgramarViaje"
        Me.ProgramarViaje.Size = New System.Drawing.Size(160, 22)
        Me.ProgramarViaje.Text = "Programar Viaje"
        Me.ProgramarViaje.ToolTipText = "Programar Viaje de la Demanda seleccionada"
        '
        'EstadoAsignada
        '
        Me.EstadoAsignada.Image = Global.ISL.Win.My.Resources.Resources.Siguiente
        Me.EstadoAsignada.Name = "EstadoAsignada"
        Me.EstadoAsignada.Size = New System.Drawing.Size(160, 22)
        Me.EstadoAsignada.Text = "Estado Asignada"
        Me.EstadoAsignada.ToolTipText = "Cambiar el estado de una demanda de PARCIAL a ASIGNADA"
        '
        'CancelarDemanda
        '
        Me.CancelarDemanda.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        Me.CancelarDemanda.Name = "CancelarDemanda"
        Me.CancelarDemanda.Size = New System.Drawing.Size(160, 22)
        Me.CancelarDemanda.Text = "Cancelar"
        '
        'EnviarCorreoToolStripMenuItem
        '
        Me.EnviarCorreoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.send_email
        Me.EnviarCorreoToolStripMenuItem.Name = "EnviarCorreoToolStripMenuItem"
        Me.EnviarCorreoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EnviarCorreoToolStripMenuItem.Text = "Enviar Correo"
        '
        'RevertirDemandaToolStripMenuItem
        '
        Me.RevertirDemandaToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.back
        Me.RevertirDemandaToolStripMenuItem.Name = "RevertirDemandaToolStripMenuItem"
        Me.RevertirDemandaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RevertirDemandaToolStripMenuItem.Text = "Revertir Demanda"
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
        Me.imagenes.Images.SetKeyName(11, "")
        Me.imagenes.Images.SetKeyName(12, "")
        Me.imagenes.Images.SetKeyName(13, "")
        Me.imagenes.Images.SetKeyName(14, "")
        Me.imagenes.Images.SetKeyName(15, "")
        Me.imagenes.Images.SetKeyName(16, "")
        Me.imagenes.Images.SetKeyName(17, "")
        Me.imagenes.Images.SetKeyName(18, "edit.png")
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griFactura)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1344, 522)
        '
        'griFactura
        '
        Me.griFactura.ContextMenuStrip = Me.MenuDetalle
        Me.griFactura.DataSource = Me.ogdDemandaDetalle
        Appearance2.BackColor = System.Drawing.Color.White
        Me.griFactura.DisplayLayout.Appearance = Appearance2
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.Header.VisiblePosition = 2
        UltraGridColumn19.Width = 250
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.Header.Enabled = False
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn20.Width = 100
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance3.BackColor = System.Drawing.Color.PaleTurquoise
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance3
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn21.Header.Caption = "Cant."
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.MaskInput = "{double:5.3}"
        UltraGridColumn21.Width = 60
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance4
        UltraGridColumn22.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn22.Format = "#,##0.0000"
        UltraGridColumn22.Header.Caption = "F.Unitario"
        UltraGridColumn22.Header.Enabled = False
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.MaskInput = "{LOC}nn,nnn.nnnn"
        UltraGridColumn22.Width = 78
        UltraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn23.Header.Caption = "Fact."
        UltraGridColumn23.Header.VisiblePosition = 6
        UltraGridColumn23.Width = 27
        UltraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn24.Header.Caption = "Cont.Ent."
        UltraGridColumn24.Header.VisiblePosition = 7
        UltraGridColumn24.Width = 48
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn25.Header.VisiblePosition = 8
        UltraGridColumn25.Width = 100
        UltraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn28.CellAppearance = Appearance5
        UltraGridColumn28.Header.VisiblePosition = 9
        UltraGridColumn28.Width = 50
        UltraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance6.BackColor = System.Drawing.Color.LemonChiffon
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn29.CellAppearance = Appearance6
        UltraGridColumn29.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn29.Format = "#,###,##0.000"
        UltraGridColumn29.Header.VisiblePosition = 11
        UltraGridColumn29.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn29.Width = 80
        UltraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn31.Header.VisiblePosition = 12
        UltraGridColumn31.Width = 200
        UltraGridColumn32.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance7.BackColor = System.Drawing.Color.LemonChiffon
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn32.CellAppearance = Appearance7
        UltraGridColumn32.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn32.Format = "#,##0.00"
        UltraGridColumn32.Header.VisiblePosition = 13
        UltraGridColumn32.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn32.Width = 60
        UltraGridColumn54.Header.VisiblePosition = 14
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 15
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 16
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 17
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 18
        UltraGridColumn58.Width = 100
        UltraGridColumn59.Header.VisiblePosition = 19
        UltraGridColumn59.Width = 100
        UltraGridColumn60.Header.VisiblePosition = 20
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.Caption = "I. Igv"
        UltraGridColumn61.Header.VisiblePosition = 10
        UltraGridColumn61.Width = 28
        UltraGridColumn62.Header.VisiblePosition = 21
        UltraGridColumn62.Width = 200
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn28, UltraGridColumn29, UltraGridColumn31, UltraGridColumn32, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62})
        UltraGridBand4.SummaryFooterCaption = "Totales:"
        Me.griFactura.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griFactura.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griFactura.DisplayLayout.GroupByBox.Hidden = True
        Me.griFactura.DisplayLayout.MaxColScrollRegions = 1
        Me.griFactura.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griFactura.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griFactura.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griFactura.DisplayLayout.Override.CellPadding = 2
        Me.griFactura.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griFactura.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griFactura.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance8.TextVAlignAsString = "Middle"
        Me.griFactura.DisplayLayout.Override.RowAppearance = Appearance8
        Me.griFactura.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griFactura.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griFactura.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griFactura.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griFactura.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griFactura.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griFactura.Location = New System.Drawing.Point(0, 0)
        Me.griFactura.Name = "griFactura"
        Me.griFactura.Size = New System.Drawing.Size(1344, 522)
        Me.griFactura.TabIndex = 2
        Me.griFactura.Tag = ""
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarDetalleToolStripMenuItem, Me.NuevoDetalleToolStripMenuItem, Me.mnuEliminar, Me.mnuDuplicar})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(165, 108)
        '
        'EditarDetalleToolStripMenuItem
        '
        Me.EditarDetalleToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarDetalleToolStripMenuItem.Name = "EditarDetalleToolStripMenuItem"
        Me.EditarDetalleToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.EditarDetalleToolStripMenuItem.Text = "Editar Detalle"
        '
        'NuevoDetalleToolStripMenuItem
        '
        Me.NuevoDetalleToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.NuevoDetalleToolStripMenuItem.Name = "NuevoDetalleToolStripMenuItem"
        Me.NuevoDetalleToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.NuevoDetalleToolStripMenuItem.Text = "Nuevo Detalle"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Image = CType(resources.GetObject("mnuEliminar.Image"), System.Drawing.Image)
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEliminar.Size = New System.Drawing.Size(164, 26)
        Me.mnuEliminar.Text = "Quitar"
        '
        'mnuDuplicar
        '
        Me.mnuDuplicar.Image = CType(resources.GetObject("mnuDuplicar.Image"), System.Drawing.Image)
        Me.mnuDuplicar.Name = "mnuDuplicar"
        Me.mnuDuplicar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuDuplicar.Size = New System.Drawing.Size(164, 26)
        Me.mnuDuplicar.Text = "Duplicar"
        '
        'ogdDemandaDetalle
        '
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn5.DefaultValue = 0R
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn6.DefaultValue = 0R
        UltraDataColumn7.DataType = GetType(Boolean)
        UltraDataColumn8.DataType = GetType(Boolean)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn11.DefaultValue = 0R
        UltraDataColumn12.DataType = GetType(Object)
        UltraDataColumn13.DataType = GetType(Double)
        UltraDataColumn13.DefaultValue = 0R
        UltraDataColumn21.DataType = GetType(Boolean)
        Me.ogdDemandaDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22})
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.griDetalle)
        Me.UltraTabPageControl8.Controls.Add(Me.exgruFlete)
        Me.UltraTabPageControl8.Controls.Add(Me.exgruDetalle)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1342, 413)
        '
        'griDetalle
        '
        Me.griDetalle.ContextMenuStrip = Me.MenuDetalle
        Appearance9.BackColor = System.Drawing.Color.White
        Me.griDetalle.DisplayLayout.Appearance = Appearance9
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.Hidden = True
        UltraGridColumn128.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn128.Header.Enabled = False
        UltraGridColumn128.Header.VisiblePosition = 2
        UltraGridColumn128.Width = 250
        UltraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn26.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn26.Header.VisiblePosition = 3
        UltraGridColumn26.Width = 100
        UltraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance10.BackColor = System.Drawing.Color.PaleTurquoise
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn27.CellAppearance = Appearance10
        UltraGridColumn27.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn27.Header.Caption = "Cant."
        UltraGridColumn27.Header.VisiblePosition = 5
        UltraGridColumn27.MaskInput = "{double:5.3}"
        UltraGridColumn27.Width = 44
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn129.CellAppearance = Appearance11
        UltraGridColumn129.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn129.Format = "#,##0.000"
        UltraGridColumn129.Header.Caption = "F.Unitario"
        UltraGridColumn129.Header.Enabled = False
        UltraGridColumn129.Header.VisiblePosition = 6
        UltraGridColumn129.MaskInput = "{LOC}nn,nnn.nnnn"
        UltraGridColumn129.Width = 78
        UltraGridColumn130.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn130.Header.Caption = "Fact."
        UltraGridColumn130.Header.VisiblePosition = 14
        UltraGridColumn130.Width = 37
        UltraGridColumn142.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn142.Header.Caption = "Cont.Ent."
        UltraGridColumn142.Header.VisiblePosition = 17
        UltraGridColumn142.Width = 48
        UltraGridColumn143.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn143.Header.Caption = "Material"
        UltraGridColumn143.Header.VisiblePosition = 4
        UltraGridColumn143.Width = 84
        UltraGridColumn144.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance12.TextHAlignAsString = "Center"
        UltraGridColumn144.CellAppearance = Appearance12
        UltraGridColumn144.Header.VisiblePosition = 19
        UltraGridColumn144.Width = 38
        UltraGridColumn145.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance13.BackColor = System.Drawing.Color.YellowGreen
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn145.CellAppearance = Appearance13
        UltraGridColumn145.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn145.Format = "#,###,##0.000"
        UltraGridColumn145.Header.VisiblePosition = 10
        UltraGridColumn145.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn145.Width = 54
        UltraGridColumn146.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn146.Header.VisiblePosition = 22
        UltraGridColumn146.Width = 200
        UltraGridColumn147.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance14.BackColor = System.Drawing.Color.Gold
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn147.CellAppearance = Appearance14
        UltraGridColumn147.Format = "#,##0.00"
        UltraGridColumn147.Header.VisiblePosition = 21
        UltraGridColumn147.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn147.Width = 48
        UltraGridColumn148.Header.VisiblePosition = 24
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn149.Format = "#,##0.000"
        UltraGridColumn149.Header.Caption = "F.Unit IGV"
        UltraGridColumn149.Header.VisiblePosition = 7
        UltraGridColumn149.Hidden = True
        UltraGridColumn149.MaskInput = "{LOC}nn,nnn.nnnn"
        UltraGridColumn150.Header.VisiblePosition = 25
        UltraGridColumn150.Hidden = True
        UltraGridColumn151.Header.VisiblePosition = 26
        UltraGridColumn151.Hidden = True
        UltraGridColumn152.Header.Enabled = False
        UltraGridColumn152.Header.VisiblePosition = 27
        UltraGridColumn152.Hidden = True
        UltraGridColumn152.Width = 100
        UltraGridColumn153.Header.VisiblePosition = 28
        UltraGridColumn153.Hidden = True
        UltraGridColumn153.Width = 100
        UltraGridColumn154.Header.VisiblePosition = 29
        UltraGridColumn154.Hidden = True
        UltraGridColumn97.Header.Caption = "I. Igv"
        UltraGridColumn97.Header.VisiblePosition = 20
        UltraGridColumn97.Width = 28
        UltraGridColumn98.Header.Caption = "Cliente Final"
        UltraGridColumn98.Header.VisiblePosition = 30
        UltraGridColumn98.Hidden = True
        UltraGridColumn98.Width = 200
        UltraGridColumn33.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn33.Header.Caption = "Dir.Llegada"
        UltraGridColumn33.Header.Enabled = False
        UltraGridColumn33.Header.VisiblePosition = 36
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.Width = 234
        UltraGridColumn34.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn34.Header.Caption = "Dir.Partida"
        UltraGridColumn34.Header.Enabled = False
        UltraGridColumn34.Header.VisiblePosition = 35
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.Width = 229
        UltraGridColumn38.Header.VisiblePosition = 37
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.Caption = "I.C.IGV"
        UltraGridColumn39.Header.VisiblePosition = 31
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn40.CellAppearance = Appearance15
        UltraGridColumn40.Format = "#,##0.0000"
        UltraGridColumn40.Header.VisiblePosition = 23
        UltraGridColumn40.Width = 70
        UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn41.Header.Caption = "Motivo Consolidado"
        UltraGridColumn41.Header.VisiblePosition = 32
        UltraGridColumn41.Width = 110
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance16
        UltraGridColumn42.Format = "#,##0.000"
        UltraGridColumn42.Header.Caption = "C.Estiba"
        UltraGridColumn42.Header.VisiblePosition = 12
        UltraGridColumn42.MaskInput = "{LOC}nn,nnn.nnnn"
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn43.Header.Caption = "Origen"
        UltraGridColumn43.Header.Enabled = False
        UltraGridColumn43.Header.VisiblePosition = 33
        UltraGridColumn43.Width = 184
        UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn44.Header.Caption = "Destino"
        UltraGridColumn44.Header.Enabled = False
        UltraGridColumn44.Header.VisiblePosition = 34
        UltraGridColumn44.Width = 177
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn46.CellAppearance = Appearance17
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn46.Format = "#,###,##0.000"
        UltraGridColumn46.Header.VisiblePosition = 9
        UltraGridColumn46.Width = 59
        UltraGridColumn45.Header.VisiblePosition = 38
        UltraGridColumn47.Header.VisiblePosition = 39
        UltraGridColumn48.Header.VisiblePosition = 40
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.Caption = "Cliente Final"
        UltraGridColumn49.Header.VisiblePosition = 41
        UltraGridColumn50.Header.VisiblePosition = 42
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 43
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 15
        UltraGridColumn53.Header.VisiblePosition = 16
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn224.CellAppearance = Appearance18
        UltraGridColumn224.Format = "#,##0.000"
        UltraGridColumn224.Header.VisiblePosition = 11
        UltraGridColumn224.MaskInput = "{LOC}nn,nnn.nnnn"
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn2.CellAppearance = Appearance19
        UltraGridColumn2.Format = "#,##0.000"
        UltraGridColumn2.Header.Caption = "C.Estiba Desc"
        UltraGridColumn2.Header.VisiblePosition = 13
        UltraGridColumn2.MaskInput = "{LOC}nn,nnn.nnnn"
        UltraGridColumn3.Header.VisiblePosition = 44
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 45
        UltraGridColumn4.Hidden = True
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn14.CellAppearance = Appearance20
        UltraGridColumn14.Format = "###,##0.000"
        UltraGridColumn14.Header.Caption = "Tipo PC"
        UltraGridColumn14.Header.VisiblePosition = 18
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn223.CellAppearance = Appearance21
        UltraGridColumn223.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn223.Format = "#,##0.000"
        UltraGridColumn223.Header.Caption = "F.Unit IGV"
        UltraGridColumn223.Header.VisiblePosition = 8
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1.Header.VisiblePosition = 46
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1.Width = 54
        UltraGridColumn15.Header.Caption = "Contacto Carga"
        UltraGridColumn15.Header.VisiblePosition = 47
        UltraGridColumn16.Header.Caption = "Contacto Desc"
        UltraGridColumn16.Header.VisiblePosition = 48
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn128, UltraGridColumn26, UltraGridColumn27, UltraGridColumn129, UltraGridColumn130, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn97, UltraGridColumn98, UltraGridColumn33, UltraGridColumn34, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn46, UltraGridColumn45, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn224, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn14, UltraGridColumn223, UltraGridColumn1, UltraGridColumn15, UltraGridColumn16})
        UltraGridBand5.SummaryFooterCaption = "Totales:"
        Me.griDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griDetalle.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griDetalle.DisplayLayout.GroupByBox.Hidden = True
        Me.griDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalle.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griDetalle.DisplayLayout.Override.CellPadding = 2
        Me.griDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalle.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance22.TextVAlignAsString = "Middle"
        Me.griDetalle.DisplayLayout.Override.RowAppearance = Appearance22
        Me.griDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griDetalle.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalle.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griDetalle.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griDetalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalle.Location = New System.Drawing.Point(0, 291)
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(1342, 122)
        Me.griDetalle.TabIndex = 2
        Me.griDetalle.Tag = ""
        '
        'exgruFlete
        '
        Me.exgruFlete.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Appearance23.BackColor = System.Drawing.Color.White
        Appearance23.BackColor2 = System.Drawing.Color.White
        Me.exgruFlete.ContentAreaAppearance = Appearance23
        Me.exgruFlete.Controls.Add(Me.UltraExpandableGroupBoxPanel11)
        Me.exgruFlete.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruFlete.ExpandedSize = New System.Drawing.Size(1342, 127)
        Me.exgruFlete.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.exgruFlete.Location = New System.Drawing.Point(0, 164)
        Me.exgruFlete.Name = "exgruFlete"
        Me.exgruFlete.Size = New System.Drawing.Size(1342, 127)
        Me.exgruFlete.TabIndex = 1
        Me.exgruFlete.Text = "Flete"
        Me.exgruFlete.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel11
        '
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.griTarifasProveedor)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.UltraGroupBox2)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.UltraGroupBox1)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Agrupacion6)
        Me.UltraExpandableGroupBoxPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel11.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel11.Name = "UltraExpandableGroupBoxPanel11"
        Me.UltraExpandableGroupBoxPanel11.Size = New System.Drawing.Size(1336, 104)
        Me.UltraExpandableGroupBoxPanel11.TabIndex = 0
        '
        'griTarifasProveedor
        '
        Me.griTarifasProveedor.DataSource = Me.ogdTarifasProveedor
        UltraGridColumn63.Header.VisiblePosition = 0
        UltraGridColumn64.Header.VisiblePosition = 1
        UltraGridColumn65.Header.VisiblePosition = 2
        UltraGridColumn66.Header.VisiblePosition = 3
        UltraGridColumn67.Header.VisiblePosition = 4
        UltraGridColumn68.Header.VisiblePosition = 5
        UltraGridColumn69.Header.VisiblePosition = 6
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 7
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 8
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 9
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 10
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 11
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 12
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 13
        UltraGridColumn76.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76})
        Me.griTarifasProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griTarifasProveedor.Location = New System.Drawing.Point(901, 3)
        Me.griTarifasProveedor.Name = "griTarifasProveedor"
        Me.griTarifasProveedor.Size = New System.Drawing.Size(435, 98)
        Me.griTarifasProveedor.TabIndex = 2
        '
        'ogdTarifasProveedor
        '
        Me.ogdTarifasProveedor.Band.Columns.AddRange(New Object() {UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36})
        '
        'UltraGroupBox2
        '
        Appearance24.BackColor = System.Drawing.Color.White
        Appearance24.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance24
        Me.UltraGroupBox2.Controls.Add(Me.txtGlosaCostoEstibaDesc)
        Me.UltraGroupBox2.Controls.Add(Me.txtCostoEstibaDescarga)
        Me.UltraGroupBox2.Controls.Add(Me.chkConsolidado)
        Me.UltraGroupBox2.Controls.Add(Me.txtConsolidado)
        Me.UltraGroupBox2.Controls.Add(Me.chkCostoEstivaDescarga)
        Me.UltraGroupBox2.Controls.Add(Me.txtMotivoConsolidado)
        Me.UltraGroupBox2.Controls.Add(Me.chkIGVConsolidado)
        Me.UltraGroupBox2.Controls.Add(Me.txtCostoEstiba)
        Me.UltraGroupBox2.Controls.Add(Me.chkCostoEstiva)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(591, 1)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(310, 103)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtGlosaCostoEstibaDesc
        '
        Me.txtGlosaCostoEstibaDesc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaCostoEstibaDesc.Location = New System.Drawing.Point(6, 78)
        Me.txtGlosaCostoEstibaDesc.MaxLength = 500
        Me.txtGlosaCostoEstibaDesc.Multiline = True
        Me.txtGlosaCostoEstibaDesc.Name = "txtGlosaCostoEstibaDesc"
        Me.txtGlosaCostoEstibaDesc.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosaCostoEstibaDesc.Size = New System.Drawing.Size(298, 19)
        Me.txtGlosaCostoEstibaDesc.TabIndex = 8
        UltraToolTipInfo13.ToolTipText = "Comentario de Consolidado"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtGlosaCostoEstibaDesc, UltraToolTipInfo13)
        Me.txtGlosaCostoEstibaDesc.Visible = False
        '
        'txtCostoEstibaDescarga
        '
        Me.txtCostoEstibaDescarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCostoEstibaDescarga.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCostoEstibaDescarga.Enabled = False
        Me.txtCostoEstibaDescarga.InputMask = "{double:15.2}"
        Me.txtCostoEstibaDescarga.Location = New System.Drawing.Point(239, 53)
        Me.txtCostoEstibaDescarga.Name = "txtCostoEstibaDescarga"
        Me.txtCostoEstibaDescarga.NonAutoSizeHeight = 20
        Me.txtCostoEstibaDescarga.Size = New System.Drawing.Size(65, 21)
        Me.txtCostoEstibaDescarga.TabIndex = 7
        Me.txtCostoEstibaDescarga.Text = "0.00"
        '
        'chkConsolidado
        '
        Appearance143.ForeColor = System.Drawing.Color.Navy
        Me.chkConsolidado.Appearance = Appearance143
        Me.chkConsolidado.AutoSize = True
        Me.chkConsolidado.Location = New System.Drawing.Point(6, 6)
        Me.chkConsolidado.Name = "chkConsolidado"
        Me.chkConsolidado.Size = New System.Drawing.Size(84, 18)
        Me.chkConsolidado.TabIndex = 0
        Me.chkConsolidado.Text = "Consolidado"
        '
        'txtConsolidado
        '
        Me.txtConsolidado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtConsolidado.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtConsolidado.InputMask = "{double:15.2}"
        Me.txtConsolidado.Location = New System.Drawing.Point(102, 5)
        Me.txtConsolidado.Name = "txtConsolidado"
        Me.txtConsolidado.NonAutoSizeHeight = 20
        Me.txtConsolidado.Size = New System.Drawing.Size(98, 21)
        Me.txtConsolidado.TabIndex = 1
        Me.txtConsolidado.Text = "0.00"
        '
        'chkCostoEstivaDescarga
        '
        Appearance144.ForeColor = System.Drawing.Color.Navy
        Me.chkCostoEstivaDescarga.Appearance = Appearance144
        Me.chkCostoEstivaDescarga.AutoSize = True
        Me.chkCostoEstivaDescarga.Location = New System.Drawing.Point(143, 55)
        Me.chkCostoEstivaDescarga.Name = "chkCostoEstivaDescarga"
        Me.chkCostoEstivaDescarga.Size = New System.Drawing.Size(93, 18)
        Me.chkCostoEstivaDescarga.TabIndex = 6
        Me.chkCostoEstivaDescarga.Text = "C.Estiba Desc"
        '
        'txtMotivoConsolidado
        '
        Me.txtMotivoConsolidado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMotivoConsolidado.Location = New System.Drawing.Point(6, 30)
        Me.txtMotivoConsolidado.MaxLength = 500
        Me.txtMotivoConsolidado.Multiline = True
        Me.txtMotivoConsolidado.Name = "txtMotivoConsolidado"
        Me.txtMotivoConsolidado.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoConsolidado.Size = New System.Drawing.Size(298, 19)
        Me.txtMotivoConsolidado.TabIndex = 3
        Me.txtMotivoConsolidado.Visible = False
        '
        'chkIGVConsolidado
        '
        Appearance145.ForeColor = System.Drawing.Color.Navy
        Me.chkIGVConsolidado.Appearance = Appearance145
        Me.chkIGVConsolidado.AutoSize = True
        Me.chkIGVConsolidado.Location = New System.Drawing.Point(206, 6)
        Me.chkIGVConsolidado.Name = "chkIGVConsolidado"
        Me.chkIGVConsolidado.Size = New System.Drawing.Size(80, 18)
        Me.chkIGVConsolidado.TabIndex = 2
        Me.chkIGVConsolidado.Text = "Incluye IGV"
        '
        'txtCostoEstiba
        '
        Me.txtCostoEstiba.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCostoEstiba.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCostoEstiba.Enabled = False
        Me.txtCostoEstiba.InputMask = "{double:15.2}"
        Me.txtCostoEstiba.Location = New System.Drawing.Point(73, 53)
        Me.txtCostoEstiba.Name = "txtCostoEstiba"
        Me.txtCostoEstiba.NonAutoSizeHeight = 20
        Me.txtCostoEstiba.Size = New System.Drawing.Size(65, 21)
        Me.txtCostoEstiba.TabIndex = 5
        Me.txtCostoEstiba.Text = "0.00"
        '
        'chkCostoEstiva
        '
        Appearance146.ForeColor = System.Drawing.Color.Navy
        Me.chkCostoEstiva.Appearance = Appearance146
        Me.chkCostoEstiva.AutoSize = True
        Me.chkCostoEstiva.Location = New System.Drawing.Point(6, 55)
        Me.chkCostoEstiva.Name = "chkCostoEstiva"
        Me.chkCostoEstiva.Size = New System.Drawing.Size(64, 18)
        Me.chkCostoEstiva.TabIndex = 4
        Me.chkCostoEstiva.Text = "C.Estiba"
        '
        'UltraGroupBox1
        '
        Appearance147.BackColor = System.Drawing.Color.White
        Appearance147.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance147
        Me.UltraGroupBox1.Controls.Add(Me.cboMoneda)
        Me.UltraGroupBox1.Controls.Add(Me.chkIndFalsoFlete)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel18)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel37)
        Me.UltraGroupBox1.Controls.Add(Me.txtAdelantoFlete)
        Me.UltraGroupBox1.Controls.Add(Me.btnAgregar)
        Me.UltraGroupBox1.Controls.Add(Me.verValidaFU)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel29)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel28)
        Me.UltraGroupBox1.Controls.Add(Me.txtComision)
        Me.UltraGroupBox1.Controls.Add(Me.txtSubtotal)
        Me.UltraGroupBox1.Controls.Add(Me.verFacturado)
        Me.UltraGroupBox1.Controls.Add(Me.lblSubtotal)
        Me.UltraGroupBox1.Controls.Add(Me.CalFleteUnitarioIGV)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel21)
        Me.UltraGroupBox1.Controls.Add(Me.verIncluyeIgv)
        Me.UltraGroupBox1.Controls.Add(Me.txtFleteTotalDetalle)
        Me.UltraGroupBox1.Controls.Add(Me.CalFleteUnitario)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 1)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(450, 103)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboMoneda
        '
        Appearance148.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance148
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(10, 53)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(35, 21)
        Me.cboMoneda.TabIndex = 5
        Me.cboMoneda.ValueMember = "Id"
        '
        'chkIndFalsoFlete
        '
        Appearance149.ForeColor = System.Drawing.Color.Navy
        Me.chkIndFalsoFlete.Appearance = Appearance149
        Me.chkIndFalsoFlete.AutoSize = True
        Me.chkIndFalsoFlete.Location = New System.Drawing.Point(302, 74)
        Me.chkIndFalsoFlete.Name = "chkIndFalsoFlete"
        Me.chkIndFalsoFlete.Size = New System.Drawing.Size(77, 18)
        Me.chkIndFalsoFlete.TabIndex = 17
        Me.chkIndFalsoFlete.Text = "Falso Flete"
        '
        'UltraLabel18
        '
        Appearance150.BackColor = System.Drawing.Color.Transparent
        Appearance150.ForeColor = System.Drawing.Color.Navy
        Appearance150.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance150
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(6, 10)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(102, 15)
        Me.UltraLabel18.TabIndex = 0
        Me.UltraLabel18.Text = "Flete Uni (Sin IGV): "
        '
        'UltraLabel37
        '
        Appearance151.BackColor = System.Drawing.Color.Transparent
        Appearance151.ForeColor = System.Drawing.Color.Navy
        Appearance151.TextVAlignAsString = "Middle"
        Me.UltraLabel37.Appearance = Appearance151
        Me.UltraLabel37.AutoSize = True
        Me.UltraLabel37.Location = New System.Drawing.Point(305, 32)
        Me.UltraLabel37.Name = "UltraLabel37"
        Me.UltraLabel37.Size = New System.Drawing.Size(53, 15)
        Me.UltraLabel37.TabIndex = 13
        Me.UltraLabel37.Text = "Comisión: "
        '
        'txtAdelantoFlete
        '
        Appearance152.TextHAlignAsString = "Right"
        Me.txtAdelantoFlete.Appearance = Appearance152
        Me.txtAdelantoFlete.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAdelantoFlete.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtAdelantoFlete.InputMask = "{double:4.2}"
        Me.txtAdelantoFlete.Location = New System.Drawing.Point(361, 5)
        Me.txtAdelantoFlete.Name = "txtAdelantoFlete"
        Me.txtAdelantoFlete.NonAutoSizeHeight = 20
        Me.txtAdelantoFlete.NullText = "0.00"
        Me.txtAdelantoFlete.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtAdelantoFlete.Size = New System.Drawing.Size(78, 21)
        Me.txtAdelantoFlete.TabIndex = 12
        Me.txtAdelantoFlete.Text = "0.00"
        '
        'btnAgregar
        '
        Appearance153.BorderColor = System.Drawing.Color.White
        Appearance153.Image = CType(resources.GetObject("Appearance153.Image"), Object)
        Me.btnAgregar.Appearance = Appearance153
        Me.btnAgregar.ImageList = Me.imagenes
        Me.btnAgregar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(396, 58)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(42, 41)
        Me.btnAgregar.TabIndex = 0
        '
        'verValidaFU
        '
        Appearance154.ForeColor = System.Drawing.Color.Navy
        Me.verValidaFU.Appearance = Appearance154
        Me.verValidaFU.AutoSize = True
        Me.verValidaFU.Checked = True
        Me.verValidaFU.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verValidaFU.Location = New System.Drawing.Point(229, 8)
        Me.verValidaFU.Name = "verValidaFU"
        Me.verValidaFU.Size = New System.Drawing.Size(14, 13)
        Me.verValidaFU.TabIndex = 2
        UltraToolTipInfo14.ToolTipText = "Modificar Flete Unitario"
        UltraToolTipInfo14.ToolTipTitle = "Valida Flete Unitario"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.verValidaFU, UltraToolTipInfo14)
        '
        'UltraLabel29
        '
        Appearance155.BackColor = System.Drawing.Color.Transparent
        Appearance155.ForeColor = System.Drawing.Color.Navy
        Appearance155.TextVAlignAsString = "Middle"
        Me.UltraLabel29.Appearance = Appearance155
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Location = New System.Drawing.Point(285, 9)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(76, 15)
        Me.UltraLabel29.TabIndex = 11
        Me.UltraLabel29.Text = "AdelantoFlete: "
        '
        'UltraLabel28
        '
        Appearance156.BackColor = System.Drawing.Color.Transparent
        Appearance156.ForeColor = System.Drawing.Color.Navy
        Appearance156.TextVAlignAsString = "Middle"
        Me.UltraLabel28.Appearance = Appearance156
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Location = New System.Drawing.Point(2, 33)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(106, 15)
        Me.UltraLabel28.TabIndex = 3
        Me.UltraLabel28.Text = "Flete Uni (Con IGV): "
        '
        'txtComision
        '
        Appearance157.TextHAlignAsString = "Right"
        Me.txtComision.Appearance = Appearance157
        Me.txtComision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtComision.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtComision.Enabled = False
        Me.txtComision.InputMask = "{double:4.2}"
        Me.txtComision.Location = New System.Drawing.Point(360, 29)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.NonAutoSizeHeight = 20
        Me.txtComision.NullText = "0.00"
        Me.txtComision.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtComision.Size = New System.Drawing.Size(78, 21)
        Me.txtComision.TabIndex = 14
        Me.txtComision.Text = "0.00"
        '
        'txtSubtotal
        '
        Appearance158.TextHAlignAsString = "Right"
        Me.txtSubtotal.Appearance = Appearance158
        Me.txtSubtotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSubtotal.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtSubtotal.InputMask = "{double:10.4}"
        Me.txtSubtotal.Location = New System.Drawing.Point(111, 53)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.NonAutoSizeHeight = 20
        Me.txtSubtotal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(110, 21)
        Me.txtSubtotal.TabIndex = 7
        Me.txtSubtotal.Text = "0.0000"
        '
        'verFacturado
        '
        Appearance159.ForeColor = System.Drawing.Color.Navy
        Me.verFacturado.Appearance = Appearance159
        Me.verFacturado.Checked = True
        Me.verFacturado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verFacturado.Location = New System.Drawing.Point(302, 54)
        Me.verFacturado.Name = "verFacturado"
        Me.verFacturado.Size = New System.Drawing.Size(75, 20)
        Me.verFacturado.TabIndex = 15
        Me.verFacturado.Text = "Facturado"
        '
        'lblSubtotal
        '
        Appearance160.BackColor = System.Drawing.Color.Transparent
        Appearance160.ForeColor = System.Drawing.Color.Navy
        Appearance160.TextVAlignAsString = "Middle"
        Me.lblSubtotal.Appearance = Appearance160
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(60, 56)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 15)
        Me.lblSubtotal.TabIndex = 6
        Me.lblSubtotal.Text = "Subtotal: "
        '
        'CalFleteUnitarioIGV
        '
        Appearance161.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance161.TextHAlignAsString = "Right"
        Me.CalFleteUnitarioIGV.Appearance = Appearance161
        Me.CalFleteUnitarioIGV.AutoSize = False
        CalculatorButton1.Key = "."
        CalculatorButton1.KeyCodeAlternateValue = 190
        CalculatorButton1.KeyCodeValue = 110
        CalculatorButton1.Text = ","
        Me.CalFleteUnitarioIGV.Buttons.AddRange(New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton() {CalculatorButton1})
        Me.CalFleteUnitarioIGV.ButtonsLeft.Add(EditorButton4)
        Me.CalFleteUnitarioIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CalFleteUnitarioIGV.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CalFleteUnitarioIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalFleteUnitarioIGV.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CalFleteUnitarioIGV.ImageList = Me.imagenes
        Me.CalFleteUnitarioIGV.Location = New System.Drawing.Point(111, 28)
        Me.CalFleteUnitarioIGV.Name = "CalFleteUnitarioIGV"
        Me.CalFleteUnitarioIGV.NullText = "0.00"
        Me.CalFleteUnitarioIGV.Size = New System.Drawing.Size(110, 20)
        Me.CalFleteUnitarioIGV.TabIndex = 4
        Me.CalFleteUnitarioIGV.Text = "0.0000"
        '
        'UltraLabel21
        '
        Appearance162.BackColor = System.Drawing.Color.Transparent
        Appearance162.ForeColor = System.Drawing.Color.Navy
        Appearance162.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance162
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(45, 80)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel21.TabIndex = 8
        Me.UltraLabel21.Text = "Flete Total: "
        '
        'verIncluyeIgv
        '
        Appearance163.ForeColor = System.Drawing.Color.Navy
        Me.verIncluyeIgv.Appearance = Appearance163
        Me.verIncluyeIgv.AutoSize = True
        Me.verIncluyeIgv.Location = New System.Drawing.Point(225, 78)
        Me.verIncluyeIgv.Name = "verIncluyeIgv"
        Me.verIncluyeIgv.Size = New System.Drawing.Size(47, 18)
        Me.verIncluyeIgv.TabIndex = 10
        Me.verIncluyeIgv.Text = "I.IGV"
        '
        'txtFleteTotalDetalle
        '
        Appearance164.TextHAlignAsString = "Right"
        Me.txtFleteTotalDetalle.Appearance = Appearance164
        Me.txtFleteTotalDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFleteTotalDetalle.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtFleteTotalDetalle.InputMask = "{double:10.4}"
        Me.txtFleteTotalDetalle.Location = New System.Drawing.Point(111, 77)
        Me.txtFleteTotalDetalle.Name = "txtFleteTotalDetalle"
        Me.txtFleteTotalDetalle.NonAutoSizeHeight = 20
        Me.txtFleteTotalDetalle.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFleteTotalDetalle.ReadOnly = True
        Me.txtFleteTotalDetalle.Size = New System.Drawing.Size(110, 21)
        Me.txtFleteTotalDetalle.TabIndex = 9
        Me.txtFleteTotalDetalle.Text = "0.0000"
        '
        'CalFleteUnitario
        '
        Appearance165.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance165.TextHAlignAsString = "Right"
        Me.CalFleteUnitario.Appearance = Appearance165
        Me.CalFleteUnitario.AutoSize = False
        CalculatorButton2.Key = "."
        CalculatorButton2.KeyCodeAlternateValue = 190
        CalculatorButton2.KeyCodeValue = 110
        CalculatorButton2.Text = ","
        Me.CalFleteUnitario.Buttons.AddRange(New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton() {CalculatorButton2})
        Me.CalFleteUnitario.ButtonsLeft.Add(EditorButton5)
        Me.CalFleteUnitario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CalFleteUnitario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CalFleteUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalFleteUnitario.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CalFleteUnitario.ImageList = Me.imagenes
        Me.CalFleteUnitario.Location = New System.Drawing.Point(111, 6)
        Me.CalFleteUnitario.Name = "CalFleteUnitario"
        Me.CalFleteUnitario.NullText = "0.00"
        Me.CalFleteUnitario.Size = New System.Drawing.Size(110, 20)
        Me.CalFleteUnitario.TabIndex = 1
        Me.CalFleteUnitario.Text = "0.0000"
        '
        'Agrupacion6
        '
        Appearance166.BackColor = System.Drawing.Color.White
        Appearance166.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion6.ContentAreaAppearance = Appearance166
        Me.Agrupacion6.Controls.Add(Me.opPagoCont)
        Me.Agrupacion6.Controls.Add(Me.verCargar)
        Me.Agrupacion6.Controls.Add(Me.verDescarga)
        Me.Agrupacion6.Controls.Add(Me.verPagoContraEntrega)
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion6.Location = New System.Drawing.Point(456, 1)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(132, 102)
        Me.Agrupacion6.TabIndex = 1
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'opPagoCont
        '
        Appearance167.ForeColor = System.Drawing.Color.Navy
        Me.opPagoCont.Appearance = Appearance167
        Me.opPagoCont.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opPagoCont.CheckedIndex = 0
        Me.opPagoCont.Enabled = False
        Me.opPagoCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opPagoCont.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem13.DataValue = "Default Item"
        ValueListItem13.DisplayText = "Efectivo"
        ValueListItem14.DataValue = "ValueListItem1"
        ValueListItem14.DisplayText = "Deposito"
        ValueListItem15.DataValue = "ValueListItem2"
        ValueListItem15.DisplayText = "Otros"
        Me.opPagoCont.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem13, ValueListItem14, ValueListItem15})
        Me.opPagoCont.Location = New System.Drawing.Point(25, 54)
        Me.opPagoCont.Name = "opPagoCont"
        Me.opPagoCont.Size = New System.Drawing.Size(72, 42)
        Me.opPagoCont.TabIndex = 3
        Me.opPagoCont.Text = "Efectivo"
        '
        'verCargar
        '
        Appearance168.ForeColor = System.Drawing.Color.Navy
        Me.verCargar.Appearance = Appearance168
        Me.verCargar.AutoSize = True
        Me.verCargar.Location = New System.Drawing.Point(6, 2)
        Me.verCargar.Name = "verCargar"
        Me.verCargar.Size = New System.Drawing.Size(56, 17)
        Me.verCargar.TabIndex = 0
        Me.verCargar.Text = "Cargar"
        '
        'verDescarga
        '
        Appearance169.ForeColor = System.Drawing.Color.Navy
        Me.verDescarga.Appearance = Appearance169
        Me.verDescarga.AutoSize = True
        Me.verDescarga.Location = New System.Drawing.Point(6, 19)
        Me.verDescarga.Name = "verDescarga"
        Me.verDescarga.Size = New System.Drawing.Size(70, 17)
        Me.verDescarga.TabIndex = 1
        Me.verDescarga.Text = "Descarga"
        '
        'verPagoContraEntrega
        '
        Appearance170.ForeColor = System.Drawing.Color.Navy
        Me.verPagoContraEntrega.Appearance = Appearance170
        Me.verPagoContraEntrega.AutoSize = True
        Me.verPagoContraEntrega.Location = New System.Drawing.Point(6, 37)
        Me.verPagoContraEntrega.Name = "verPagoContraEntrega"
        Me.verPagoContraEntrega.Size = New System.Drawing.Size(124, 17)
        Me.verPagoContraEntrega.TabIndex = 2
        Me.verPagoContraEntrega.Text = "Pago ContraEntrega"
        '
        'exgruDetalle
        '
        Me.exgruDetalle.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Appearance171.BackColor = System.Drawing.Color.White
        Appearance171.BackColor2 = System.Drawing.Color.White
        Me.exgruDetalle.ContentAreaAppearance = Appearance171
        Me.exgruDetalle.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.exgruDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruDetalle.ExpandedSize = New System.Drawing.Size(1342, 164)
        Me.exgruDetalle.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.exgruDetalle.Location = New System.Drawing.Point(0, 0)
        Me.exgruDetalle.Name = "exgruDetalle"
        Me.exgruDetalle.Size = New System.Drawing.Size(1342, 164)
        Me.exgruDetalle.TabIndex = 0
        Me.exgruDetalle.Text = "Detalle"
        Me.exgruDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel41)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel40)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtTelfDescarga)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtTelfCarga)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboContactoDescarga)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboContactoCarga)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel38)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel39)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboDireccionLlegada)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboDireccionPartida)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtApellidoMaterno)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtNombreComisonista)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtApellidoPaternoComisionista)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtTelefonoComisionista)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboDestinoDetalle)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboOrigenDetalle)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel13)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtRucComisionista)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtRucCLienteFinal)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtRucCLiente)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboMaterial)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboTipoCarga)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboClienteFinal)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboComisionista)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboCliente)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel19)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel17)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel12)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtCantidad)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel15)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblClienteFinal)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel25)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel10)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel14)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1336, 141)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UltraLabel41
        '
        Appearance172.BackColor = System.Drawing.Color.Transparent
        Appearance172.ForeColor = System.Drawing.Color.Navy
        Appearance172.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance172
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Location = New System.Drawing.Point(245, 123)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(77, 15)
        Me.UltraLabel41.TabIndex = 13
        Me.UltraLabel41.Text = "Telf Descarga:"
        '
        'UltraLabel40
        '
        Appearance173.BackColor = System.Drawing.Color.Transparent
        Appearance173.ForeColor = System.Drawing.Color.Navy
        Appearance173.TextVAlignAsString = "Middle"
        Me.UltraLabel40.Appearance = Appearance173
        Me.UltraLabel40.AutoSize = True
        Me.UltraLabel40.Location = New System.Drawing.Point(39, 122)
        Me.UltraLabel40.Name = "UltraLabel40"
        Me.UltraLabel40.Size = New System.Drawing.Size(60, 15)
        Me.UltraLabel40.TabIndex = 11
        Me.UltraLabel40.Text = "Telf Carga:"
        '
        'txtTelfDescarga
        '
        Me.txtTelfDescarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTelfDescarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelfDescarga.Location = New System.Drawing.Point(323, 118)
        Me.txtTelfDescarga.Name = "txtTelfDescarga"
        Me.txtTelfDescarga.ReadOnly = True
        Me.txtTelfDescarga.Size = New System.Drawing.Size(135, 21)
        Me.txtTelfDescarga.TabIndex = 14
        '
        'txtTelfCarga
        '
        Me.txtTelfCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTelfCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelfCarga.Location = New System.Drawing.Point(105, 118)
        Me.txtTelfCarga.Name = "txtTelfCarga"
        Me.txtTelfCarga.ReadOnly = True
        Me.txtTelfCarga.Size = New System.Drawing.Size(135, 21)
        Me.txtTelfCarga.TabIndex = 12
        '
        'cboContactoDescarga
        '
        Me.cboContactoDescarga.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboContactoDescarga.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Appearance174.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton6.Appearance = Appearance174
        EditorButton6.Key = "btnEditarCliente"
        Appearance175.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton7.Appearance = Appearance175
        EditorButton7.Key = "btnNuevoCliente"
        EditorButton7.Visible = False
        Me.cboContactoDescarga.ButtonsRight.Add(EditorButton6)
        Me.cboContactoDescarga.ButtonsRight.Add(EditorButton7)
        Me.cboContactoDescarga.DisplayMember = "Nombre"
        Me.cboContactoDescarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboContactoDescarga.Location = New System.Drawing.Point(105, 95)
        Me.cboContactoDescarga.Name = "cboContactoDescarga"
        Me.cboContactoDescarga.Size = New System.Drawing.Size(353, 22)
        Me.cboContactoDescarga.TabIndex = 10
        Me.cboContactoDescarga.ValueMember = "Id"
        '
        'cboContactoCarga
        '
        Me.cboContactoCarga.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboContactoCarga.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Appearance176.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton8.Appearance = Appearance176
        EditorButton8.Key = "btnEditarCliente"
        Appearance177.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton9.Appearance = Appearance177
        EditorButton9.Key = "btnNuevoCliente"
        EditorButton9.Visible = False
        Me.cboContactoCarga.ButtonsRight.Add(EditorButton8)
        Me.cboContactoCarga.ButtonsRight.Add(EditorButton9)
        Me.cboContactoCarga.DisplayMember = "Nombre"
        Me.cboContactoCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboContactoCarga.Location = New System.Drawing.Point(105, 72)
        Me.cboContactoCarga.Name = "cboContactoCarga"
        Me.cboContactoCarga.Size = New System.Drawing.Size(353, 22)
        Me.cboContactoCarga.TabIndex = 8
        Me.cboContactoCarga.ValueMember = "Id"
        '
        'UltraLabel38
        '
        Appearance178.BackColor = System.Drawing.Color.Transparent
        Appearance178.ForeColor = System.Drawing.Color.Navy
        Appearance178.TextVAlignAsString = "Middle"
        Me.UltraLabel38.Appearance = Appearance178
        Me.UltraLabel38.AutoSize = True
        Me.UltraLabel38.Location = New System.Drawing.Point(-2, 99)
        Me.UltraLabel38.Name = "UltraLabel38"
        Me.UltraLabel38.Size = New System.Drawing.Size(102, 15)
        Me.UltraLabel38.TabIndex = 9
        Me.UltraLabel38.Text = "Contacto Descarga:"
        '
        'UltraLabel39
        '
        Appearance179.BackColor = System.Drawing.Color.Transparent
        Appearance179.ForeColor = System.Drawing.Color.Navy
        Appearance179.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance179
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Location = New System.Drawing.Point(17, 77)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(85, 15)
        Me.UltraLabel39.TabIndex = 7
        Me.UltraLabel39.Text = "Contacto Carga:"
        '
        'cboDireccionLlegada
        '
        Me.cboDireccionLlegada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDireccionLlegada.DisplayMember = "Nombre"
        Me.cboDireccionLlegada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDireccionLlegada.Location = New System.Drawing.Point(540, 26)
        Me.cboDireccionLlegada.Name = "cboDireccionLlegada"
        Me.cboDireccionLlegada.Size = New System.Drawing.Size(345, 23)
        Me.cboDireccionLlegada.TabIndex = 18
        Me.cboDireccionLlegada.ValueMember = "Id"
        '
        'cboDireccionPartida
        '
        Me.cboDireccionPartida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDireccionPartida.DisplayMember = "Nombre"
        Me.cboDireccionPartida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDireccionPartida.Location = New System.Drawing.Point(540, 3)
        Me.cboDireccionPartida.Name = "cboDireccionPartida"
        Me.cboDireccionPartida.Size = New System.Drawing.Size(345, 23)
        Me.cboDireccionPartida.TabIndex = 16
        Me.cboDireccionPartida.ValueMember = "Id"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoMaterno.Enabled = False
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(655, 96)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(115, 21)
        Me.txtApellidoMaterno.TabIndex = 26
        '
        'txtNombreComisonista
        '
        Me.txtNombreComisonista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombreComisonista.Enabled = False
        Me.txtNombreComisonista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreComisonista.Location = New System.Drawing.Point(770, 96)
        Me.txtNombreComisonista.Name = "txtNombreComisonista"
        Me.txtNombreComisonista.Size = New System.Drawing.Size(115, 21)
        Me.txtNombreComisonista.TabIndex = 27
        '
        'txtApellidoPaternoComisionista
        '
        Me.txtApellidoPaternoComisionista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoPaternoComisionista.Enabled = False
        Me.txtApellidoPaternoComisionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaternoComisionista.Location = New System.Drawing.Point(540, 96)
        Me.txtApellidoPaternoComisionista.Name = "txtApellidoPaternoComisionista"
        Me.txtApellidoPaternoComisionista.Size = New System.Drawing.Size(115, 21)
        Me.txtApellidoPaternoComisionista.TabIndex = 25
        '
        'txtTelefonoComisionista
        '
        Me.txtTelefonoComisionista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTelefonoComisionista.Enabled = False
        Me.txtTelefonoComisionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoComisionista.Location = New System.Drawing.Point(888, 96)
        Me.txtTelefonoComisionista.Name = "txtTelefonoComisionista"
        Me.txtTelefonoComisionista.Size = New System.Drawing.Size(106, 21)
        Me.txtTelefonoComisionista.TabIndex = 28
        UltraToolTipInfo15.ToolTipText = "Telefono"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtTelefonoComisionista, UltraToolTipInfo15)
        '
        'cboDestinoDetalle
        '
        Me.cboDestinoDetalle.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDestinoDetalle.DisplayMember = "Destino"
        Me.cboDestinoDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDestinoDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestinoDetalle.Location = New System.Drawing.Point(105, 26)
        Me.cboDestinoDetalle.Name = "cboDestinoDetalle"
        Me.cboDestinoDetalle.Size = New System.Drawing.Size(353, 21)
        Me.cboDestinoDetalle.TabIndex = 4
        Me.cboDestinoDetalle.ValueMember = "IdDestino"
        '
        'cboOrigenDetalle
        '
        Me.cboOrigenDetalle.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboOrigenDetalle.DisplayMember = "Nombre"
        Me.cboOrigenDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOrigenDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigenDetalle.Location = New System.Drawing.Point(105, 3)
        Me.cboOrigenDetalle.Name = "cboOrigenDetalle"
        Me.cboOrigenDetalle.Size = New System.Drawing.Size(353, 21)
        Me.cboOrigenDetalle.TabIndex = 1
        Me.cboOrigenDetalle.ValueMember = "Id"
        '
        'UltraLabel1
        '
        Appearance180.BackColor = System.Drawing.Color.Transparent
        Appearance180.ForeColor = System.Drawing.Color.Navy
        Appearance180.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance180
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(56, 31)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Destino:"
        '
        'UltraLabel13
        '
        Appearance181.BackColor = System.Drawing.Color.Transparent
        Appearance181.ForeColor = System.Drawing.Color.Navy
        Appearance181.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance181
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(61, 7)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel13.TabIndex = 0
        Me.UltraLabel13.Text = "Origen:"
        '
        'txtRucComisionista
        '
        Me.txtRucComisionista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucComisionista.Enabled = False
        Me.txtRucComisionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucComisionista.Location = New System.Drawing.Point(888, 72)
        Me.txtRucComisionista.Name = "txtRucComisionista"
        Me.txtRucComisionista.Size = New System.Drawing.Size(106, 21)
        Me.txtRucComisionista.TabIndex = 24
        '
        'txtRucCLienteFinal
        '
        Me.txtRucCLienteFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucCLienteFinal.Enabled = False
        Me.txtRucCLienteFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucCLienteFinal.Location = New System.Drawing.Point(888, 49)
        Me.txtRucCLienteFinal.Name = "txtRucCLienteFinal"
        Me.txtRucCLienteFinal.ReadOnly = True
        Me.txtRucCLienteFinal.Size = New System.Drawing.Size(106, 21)
        Me.txtRucCLienteFinal.TabIndex = 21
        '
        'txtRucCLiente
        '
        Me.txtRucCLiente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucCLiente.Enabled = False
        Me.txtRucCLiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucCLiente.Location = New System.Drawing.Point(4, 49)
        Me.txtRucCLiente.Name = "txtRucCLiente"
        Me.txtRucCLiente.ReadOnly = True
        Me.txtRucCLiente.Size = New System.Drawing.Size(100, 21)
        Me.txtRucCLiente.TabIndex = 5
        UltraToolTipInfo16.ToolTipText = "RUC Cliente"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtRucCLiente, UltraToolTipInfo16)
        '
        'cboMaterial
        '
        Me.cboMaterial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMaterial.DisplayMember = "Nombre"
        Me.cboMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMaterial.Location = New System.Drawing.Point(738, 119)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(147, 22)
        Me.cboMaterial.TabIndex = 32
        Me.cboMaterial.ValueMember = "Id"
        '
        'cboTipoCarga
        '
        Me.cboTipoCarga.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoCarga.DisplayMember = "Nombre"
        Me.cboTipoCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoCarga.Location = New System.Drawing.Point(540, 119)
        Me.cboTipoCarga.Name = "cboTipoCarga"
        Me.cboTipoCarga.Size = New System.Drawing.Size(145, 22)
        Me.cboTipoCarga.TabIndex = 30
        Me.cboTipoCarga.ValueMember = "Id"
        '
        'cboClienteFinal
        '
        Me.cboClienteFinal.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance182.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton10.Appearance = Appearance182
        EditorButton10.Key = "btnEditarClienteFinal"
        EditorButton10.Visible = False
        Me.cboClienteFinal.ButtonsRight.Add(EditorButton10)
        Me.cboClienteFinal.DisplayMember = "Nombre"
        Me.cboClienteFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteFinal.Location = New System.Drawing.Point(540, 50)
        Me.cboClienteFinal.Name = "cboClienteFinal"
        Me.cboClienteFinal.Size = New System.Drawing.Size(345, 22)
        Me.cboClienteFinal.TabIndex = 20
        Me.cboClienteFinal.ValueMember = "Id"
        '
        'cboComisionista
        '
        Me.cboComisionista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance183.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton11.Appearance = Appearance183
        EditorButton11.Key = "btnEditarComisionista"
        EditorButton11.Text = ""
        Appearance184.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton12.Appearance = Appearance184
        EditorButton12.Key = "btnNuevoComisionista"
        EditorButton12.Visible = False
        Me.cboComisionista.ButtonsRight.Add(EditorButton11)
        Me.cboComisionista.ButtonsRight.Add(EditorButton12)
        Me.cboComisionista.DisplayMember = "Nombre"
        Me.cboComisionista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboComisionista.Location = New System.Drawing.Point(540, 73)
        Me.cboComisionista.Name = "cboComisionista"
        Me.cboComisionista.Size = New System.Drawing.Size(345, 22)
        Me.cboComisionista.TabIndex = 23
        Me.cboComisionista.ValueMember = "Id"
        '
        'cboCliente
        '
        Me.cboCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCliente.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Appearance185.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton13.Appearance = Appearance185
        EditorButton13.Key = "btnEditarCliente"
        Me.cboCliente.ButtonsRight.Add(EditorButton13)
        Me.cboCliente.DisplayMember = "Nombre"
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.Location = New System.Drawing.Point(105, 49)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(353, 22)
        Me.cboCliente.TabIndex = 6
        UltraToolTipInfo17.ToolTipText = "Seleccione Cliente"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboCliente, UltraToolTipInfo17)
        Me.cboCliente.ValueMember = "Id"
        '
        'UltraLabel19
        '
        Appearance186.BackColor = System.Drawing.Color.Transparent
        Appearance186.ForeColor = System.Drawing.Color.Navy
        Appearance186.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance186
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(476, 123)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(62, 15)
        Me.UltraLabel19.TabIndex = 29
        Me.UltraLabel19.Text = "Tipo Carga:"
        '
        'UltraLabel17
        '
        Appearance187.BackColor = System.Drawing.Color.Transparent
        Appearance187.ForeColor = System.Drawing.Color.Navy
        Appearance187.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance187
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(478, 30)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel17.TabIndex = 17
        Me.UltraLabel17.Text = "D. Llegada:"
        '
        'UltraLabel12
        '
        Appearance188.BackColor = System.Drawing.Color.Transparent
        Appearance188.ForeColor = System.Drawing.Color.Navy
        Appearance188.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance188
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(482, 7)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(58, 15)
        Me.UltraLabel12.TabIndex = 15
        Me.UltraLabel12.Text = "D. Partida:"
        '
        'txtCantidad
        '
        Appearance189.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance189.TextHAlignAsString = "Right"
        Me.txtCantidad.Appearance = Appearance189
        Me.txtCantidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCantidad.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCantidad.InputMask = "{double:5.3}"
        Me.txtCantidad.Location = New System.Drawing.Point(934, 119)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.NonAutoSizeHeight = 20
        Me.txtCantidad.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCantidad.Size = New System.Drawing.Size(60, 21)
        Me.txtCantidad.TabIndex = 34
        Me.txtCantidad.Text = "1.000"
        '
        'UltraLabel15
        '
        Appearance190.BackColor = System.Drawing.Color.Transparent
        Appearance190.ForeColor = System.Drawing.Color.Navy
        Appearance190.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance190
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(2, 32)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel15.TabIndex = 2
        Me.UltraLabel15.Text = "Cliente"
        '
        'lblClienteFinal
        '
        Appearance191.BackColor = System.Drawing.Color.Transparent
        Appearance191.ForeColor = System.Drawing.Color.Navy
        Appearance191.TextVAlignAsString = "Middle"
        Me.lblClienteFinal.Appearance = Appearance191
        Me.lblClienteFinal.AutoSize = True
        Me.lblClienteFinal.Location = New System.Drawing.Point(469, 53)
        Me.lblClienteFinal.Name = "lblClienteFinal"
        Me.lblClienteFinal.Size = New System.Drawing.Size(69, 15)
        Me.lblClienteFinal.TabIndex = 19
        Me.lblClienteFinal.Text = "Cliente Final:"
        '
        'UltraLabel25
        '
        Appearance192.BackColor = System.Drawing.Color.Transparent
        Appearance192.ForeColor = System.Drawing.Color.Navy
        Appearance192.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance192
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Location = New System.Drawing.Point(467, 77)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(71, 15)
        Me.UltraLabel25.TabIndex = 22
        Me.UltraLabel25.Text = "Comisionista:"
        '
        'UltraLabel10
        '
        Appearance193.BackColor = System.Drawing.Color.Transparent
        Appearance193.ForeColor = System.Drawing.Color.Navy
        Appearance193.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance193
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(888, 122)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(40, 15)
        Me.UltraLabel10.TabIndex = 33
        Me.UltraLabel10.Text = "Cantid:"
        '
        'UltraLabel14
        '
        Appearance194.BackColor = System.Drawing.Color.Transparent
        Appearance194.ForeColor = System.Drawing.Color.Navy
        Appearance194.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance194
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(691, 123)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel14.TabIndex = 31
        Me.UltraLabel14.Text = "Material:"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.griDetalleTercero)
        Me.UltraTabPageControl9.Controls.Add(Me.UltraExpandableGroupBox6)
        Me.UltraTabPageControl9.Enabled = False
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1342, 413)
        '
        'griDetalleTercero
        '
        Me.griDetalleTercero.DataSource = Me.ogdDetalleTercero
        Appearance46.BackColor = System.Drawing.Color.White
        Me.griDetalleTercero.DisplayLayout.Appearance = Appearance46
        UltraGridColumn77.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn77.Header.VisiblePosition = 0
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn78.Header.VisiblePosition = 1
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn79.Header.VisiblePosition = 2
        UltraGridColumn79.Hidden = True
        UltraGridColumn79.Width = 250
        UltraGridColumn80.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn80.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn80.Header.Caption = "Tercero"
        UltraGridColumn80.Header.VisiblePosition = 3
        UltraGridColumn80.Width = 250
        UltraGridColumn81.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn81.Header.Caption = "Contacto"
        UltraGridColumn81.Header.VisiblePosition = 4
        UltraGridColumn81.Width = 200
        UltraGridColumn82.Header.Caption = "Moneda"
        UltraGridColumn82.Header.VisiblePosition = 5
        UltraGridColumn82.Width = 50
        Appearance47.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn83.CellAppearance = Appearance47
        UltraGridColumn83.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn83.Format = ""
        UltraGridColumn83.Header.Caption = "F.Unitario"
        UltraGridColumn83.Header.VisiblePosition = 8
        UltraGridColumn83.MaskInput = "{double:9.4}"
        UltraGridColumn83.Width = 75
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn84.CellAppearance = Appearance48
        UltraGridColumn84.Format = ""
        UltraGridColumn84.Header.VisiblePosition = 10
        UltraGridColumn84.MaskInput = "{double:5.4}"
        UltraGridColumn84.Width = 50
        UltraGridColumn85.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance49.TextHAlignAsString = "Right"
        UltraGridColumn85.CellAppearance = Appearance49
        UltraGridColumn85.Format = ""
        UltraGridColumn85.Header.VisiblePosition = 11
        UltraGridColumn85.MaskInput = "{double:9.4}"
        UltraGridColumn85.Width = 100
        UltraGridColumn86.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance50.BackColor = System.Drawing.Color.PaleTurquoise
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn86.CellAppearance = Appearance50
        UltraGridColumn86.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn86.Header.VisiblePosition = 12
        UltraGridColumn86.Hidden = True
        UltraGridColumn86.MaskInput = ""
        UltraGridColumn86.Width = 60
        UltraGridColumn87.Header.VisiblePosition = 13
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance51.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance51.TextHAlignAsString = "Right"
        UltraGridColumn88.CellAppearance = Appearance51
        UltraGridColumn88.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn88.Format = ""
        UltraGridColumn88.Header.VisiblePosition = 6
        UltraGridColumn88.MaskInput = "{double:5.4}"
        UltraGridColumn88.Width = 50
        UltraGridColumn89.Header.VisiblePosition = 14
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 16
        UltraGridColumn90.Hidden = True
        UltraGridColumn90.Width = 100
        UltraGridColumn91.Header.Caption = "Plantilla"
        UltraGridColumn91.Header.VisiblePosition = 15
        UltraGridColumn91.Width = 28
        UltraGridColumn92.Header.VisiblePosition = 17
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 18
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 19
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 20
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 21
        UltraGridColumn96.Hidden = True
        UltraGridColumn99.Header.VisiblePosition = 22
        UltraGridColumn99.Hidden = True
        UltraGridColumn126.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn126.Header.VisiblePosition = 26
        UltraGridColumn126.Width = 300
        UltraGridColumn127.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn127.Header.Caption = "Referencia Punto de Llegada"
        UltraGridColumn127.Header.VisiblePosition = 23
        UltraGridColumn127.Width = 300
        UltraGridColumn155.Header.VisiblePosition = 24
        UltraGridColumn155.Hidden = True
        UltraGridColumn156.Header.VisiblePosition = 25
        UltraGridColumn156.Hidden = True
        Appearance52.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance52.TextHAlignAsString = "Right"
        UltraGridColumn157.CellAppearance = Appearance52
        UltraGridColumn157.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn157.Header.VisiblePosition = 7
        UltraGridColumn157.MaskInput = "{double:5.2}"
        UltraGridColumn157.Width = 50
        Appearance53.TextHAlignAsString = "Right"
        UltraGridColumn158.CellAppearance = Appearance53
        UltraGridColumn158.Format = ""
        UltraGridColumn158.Header.VisiblePosition = 9
        UltraGridColumn158.MaskInput = "{double:9.4}"
        UltraGridColumn158.Width = 75
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn99, UltraGridColumn126, UltraGridColumn127, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158})
        UltraGridBand7.SummaryFooterCaption = "Totales:"
        Me.griDetalleTercero.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griDetalleTercero.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griDetalleTercero.DisplayLayout.GroupByBox.Hidden = True
        Me.griDetalleTercero.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleTercero.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalleTercero.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleTercero.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalleTercero.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleTercero.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleTercero.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance54.TextVAlignAsString = "Middle"
        Me.griDetalleTercero.DisplayLayout.Override.RowAppearance = Appearance54
        Me.griDetalleTercero.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griDetalleTercero.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleTercero.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griDetalleTercero.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griDetalleTercero.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalleTercero.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleTercero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleTercero.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleTercero.Location = New System.Drawing.Point(0, 149)
        Me.griDetalleTercero.Name = "griDetalleTercero"
        Me.griDetalleTercero.Size = New System.Drawing.Size(1342, 264)
        Me.griDetalleTercero.TabIndex = 5
        Me.griDetalleTercero.Tag = ""
        '
        'ogdDetalleTercero
        '
        UltraDataColumn41.DataType = GetType(Object)
        UltraDataColumn43.DataType = GetType(Double)
        UltraDataColumn43.DefaultValue = 0R
        UltraDataColumn44.DataType = GetType(Double)
        UltraDataColumn45.DataType = GetType(Double)
        UltraDataColumn45.DefaultValue = 0R
        UltraDataColumn46.DataType = GetType(Double)
        UltraDataColumn46.DefaultValue = 0R
        UltraDataColumn48.DataType = GetType(Double)
        UltraDataColumn48.DefaultValue = 0R
        UltraDataColumn51.DataType = GetType(Boolean)
        Me.ogdDetalleTercero.Band.Columns.AddRange(New Object() {UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63})
        '
        'UltraExpandableGroupBox6
        '
        Me.UltraExpandableGroupBox6.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Appearance55.BackColor = System.Drawing.Color.White
        Appearance55.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox6.ContentAreaAppearance = Appearance55
        Me.UltraExpandableGroupBox6.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.UltraExpandableGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox6.ExpandedSize = New System.Drawing.Size(1342, 149)
        Me.UltraExpandableGroupBox6.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox6.Name = "UltraExpandableGroupBox6"
        Me.UltraExpandableGroupBox6.Size = New System.Drawing.Size(1342, 149)
        Me.UltraExpandableGroupBox6.TabIndex = 0
        Me.UltraExpandableGroupBox6.Text = "Detalle"
        Me.UltraExpandableGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.chkIndPlantilla)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtTelefonoContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtApellidoMaternoContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtNombreContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtApellidoPaternoContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtRucContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtRucEmpresaTransportista)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboTercero)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.numCantidadTercero)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraLabel66)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.numSubTotalTercero)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraLabel67)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtObservacionTercero)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraLabel43)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtReferenciaTercero)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.numFleteTotalTerc)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.numIgvTerc)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboMonedaT)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.btnAgregarTerc)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraLabel27)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraLabel7)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.numFleteUnitarioTerc)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraLabel31)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraLabel33)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.numComisionTerc)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraLabel34)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraLabel35)
        Me.UltraExpandableGroupBoxPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(1336, 126)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        '
        'chkIndPlantilla
        '
        Appearance56.FontData.BoldAsString = "True"
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.chkIndPlantilla.Appearance = Appearance56
        Me.chkIndPlantilla.AutoSize = True
        Me.chkIndPlantilla.Location = New System.Drawing.Point(572, 98)
        Me.chkIndPlantilla.Name = "chkIndPlantilla"
        Me.chkIndPlantilla.Size = New System.Drawing.Size(158, 18)
        Me.chkIndPlantilla.TabIndex = 41
        Me.chkIndPlantilla.Text = "USAR COMO PLANTILLA"
        '
        'txtTelefonoContacto
        '
        Me.txtTelefonoContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTelefonoContacto.Enabled = False
        Me.txtTelefonoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoContacto.Location = New System.Drawing.Point(436, 48)
        Me.txtTelefonoContacto.Name = "txtTelefonoContacto"
        Me.txtTelefonoContacto.Size = New System.Drawing.Size(106, 21)
        Me.txtTelefonoContacto.TabIndex = 40
        UltraToolTipInfo1.ToolTipText = "Telefono"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtTelefonoContacto, UltraToolTipInfo1)
        '
        'txtApellidoMaternoContacto
        '
        Me.txtApellidoMaternoContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoMaternoContacto.Enabled = False
        Me.txtApellidoMaternoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaternoContacto.Location = New System.Drawing.Point(206, 48)
        Me.txtApellidoMaternoContacto.Name = "txtApellidoMaternoContacto"
        Me.txtApellidoMaternoContacto.Size = New System.Drawing.Size(115, 21)
        Me.txtApellidoMaternoContacto.TabIndex = 38
        '
        'txtNombreContacto
        '
        Me.txtNombreContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombreContacto.Enabled = False
        Me.txtNombreContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreContacto.Location = New System.Drawing.Point(321, 48)
        Me.txtNombreContacto.Name = "txtNombreContacto"
        Me.txtNombreContacto.Size = New System.Drawing.Size(115, 21)
        Me.txtNombreContacto.TabIndex = 39
        '
        'txtApellidoPaternoContacto
        '
        Me.txtApellidoPaternoContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoPaternoContacto.Enabled = False
        Me.txtApellidoPaternoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaternoContacto.Location = New System.Drawing.Point(91, 48)
        Me.txtApellidoPaternoContacto.Name = "txtApellidoPaternoContacto"
        Me.txtApellidoPaternoContacto.Size = New System.Drawing.Size(115, 21)
        Me.txtApellidoPaternoContacto.TabIndex = 37
        '
        'txtRucContacto
        '
        Me.txtRucContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucContacto.Enabled = False
        Me.txtRucContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucContacto.Location = New System.Drawing.Point(436, 25)
        Me.txtRucContacto.Name = "txtRucContacto"
        Me.txtRucContacto.Size = New System.Drawing.Size(106, 21)
        Me.txtRucContacto.TabIndex = 31
        '
        'txtRucEmpresaTransportista
        '
        Me.txtRucEmpresaTransportista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucEmpresaTransportista.Enabled = False
        Me.txtRucEmpresaTransportista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucEmpresaTransportista.Location = New System.Drawing.Point(436, 2)
        Me.txtRucEmpresaTransportista.Name = "txtRucEmpresaTransportista"
        Me.txtRucEmpresaTransportista.Size = New System.Drawing.Size(106, 21)
        Me.txtRucEmpresaTransportista.TabIndex = 30
        '
        'cboContacto
        '
        Me.cboContacto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboContacto.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Appearance57.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton1.Appearance = Appearance57
        EditorButton1.Key = "btnEditarCliente"
        Appearance58.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton2.Appearance = Appearance58
        EditorButton2.Key = "btnNuevoCliente"
        EditorButton2.Visible = False
        Me.cboContacto.ButtonsRight.Add(EditorButton1)
        Me.cboContacto.ButtonsRight.Add(EditorButton2)
        Me.cboContacto.DisplayMember = "Nombre"
        Me.cboContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboContacto.Location = New System.Drawing.Point(91, 25)
        Me.cboContacto.Name = "cboContacto"
        Me.cboContacto.Size = New System.Drawing.Size(339, 22)
        Me.cboContacto.TabIndex = 29
        Me.cboContacto.ValueMember = "Id"
        '
        'cboTercero
        '
        Me.cboTercero.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance59.Image = CType(resources.GetObject("Appearance59.Image"), Object)
        EditorButton3.Appearance = Appearance59
        EditorButton3.Key = "btnEditar"
        Me.cboTercero.ButtonsRight.Add(EditorButton3)
        Me.cboTercero.DisplayMember = "Nombre"
        Me.cboTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTercero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTercero.Location = New System.Drawing.Point(91, 2)
        Me.cboTercero.Name = "cboTercero"
        Me.cboTercero.Size = New System.Drawing.Size(339, 21)
        Me.cboTercero.TabIndex = 28
        Me.cboTercero.ValueMember = "Id"
        '
        'numCantidadTercero
        '
        Appearance60.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance60.TextHAlignAsString = "Right"
        Me.numCantidadTercero.Appearance = Appearance60
        Me.numCantidadTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCantidadTercero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numCantidadTercero.InputMask = "{double:5.2}"
        Me.numCantidadTercero.Location = New System.Drawing.Point(394, 99)
        Me.numCantidadTercero.Name = "numCantidadTercero"
        Me.numCantidadTercero.NonAutoSizeHeight = 20
        Me.numCantidadTercero.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numCantidadTercero.Size = New System.Drawing.Size(50, 21)
        Me.numCantidadTercero.TabIndex = 27
        Me.numCantidadTercero.Text = "1.00"
        '
        'UltraLabel66
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Appearance61.TextVAlignAsString = "Middle"
        Me.UltraLabel66.Appearance = Appearance61
        Me.UltraLabel66.AutoSize = True
        Me.UltraLabel66.Location = New System.Drawing.Point(340, 102)
        Me.UltraLabel66.Name = "UltraLabel66"
        Me.UltraLabel66.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel66.TabIndex = 26
        Me.UltraLabel66.Text = "Cantidad:"
        '
        'numSubTotalTercero
        '
        Appearance62.TextHAlignAsString = "Right"
        Me.numSubTotalTercero.Appearance = Appearance62
        Me.numSubTotalTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numSubTotalTercero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numSubTotalTercero.InputMask = "{double:10.4}"
        Me.numSubTotalTercero.Location = New System.Drawing.Point(634, 24)
        Me.numSubTotalTercero.Name = "numSubTotalTercero"
        Me.numSubTotalTercero.NonAutoSizeHeight = 20
        Me.numSubTotalTercero.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numSubTotalTercero.ReadOnly = True
        Me.numSubTotalTercero.Size = New System.Drawing.Size(75, 21)
        Me.numSubTotalTercero.TabIndex = 25
        Me.numSubTotalTercero.Text = "0.0000"
        '
        'UltraLabel67
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Appearance63.TextVAlignAsString = "Middle"
        Me.UltraLabel67.Appearance = Appearance63
        Me.UltraLabel67.AutoSize = True
        Me.UltraLabel67.Location = New System.Drawing.Point(576, 28)
        Me.UltraLabel67.Name = "UltraLabel67"
        Me.UltraLabel67.Size = New System.Drawing.Size(56, 15)
        Me.UltraLabel67.TabIndex = 24
        Me.UltraLabel67.Text = "Sub Total: "
        '
        'txtObservacionTercero
        '
        Me.txtObservacionTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionTercero.Location = New System.Drawing.Point(715, 1)
        Me.txtObservacionTercero.Multiline = True
        Me.txtObservacionTercero.Name = "txtObservacionTercero"
        Me.txtObservacionTercero.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionTercero.Size = New System.Drawing.Size(150, 90)
        Me.txtObservacionTercero.TabIndex = 23
        UltraToolTipInfo2.ToolTipText = "Observaciones del Contrato de Terceros"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtObservacionTercero, UltraToolTipInfo2)
        '
        'UltraLabel43
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Appearance64.TextVAlignAsString = "Middle"
        Me.UltraLabel43.Appearance = Appearance64
        Me.UltraLabel43.AutoSize = True
        Me.UltraLabel43.Location = New System.Drawing.Point(3, 8)
        Me.UltraLabel43.Name = "UltraLabel43"
        Me.UltraLabel43.Size = New System.Drawing.Size(88, 15)
        Me.UltraLabel43.TabIndex = 22
        Me.UltraLabel43.Text = "Emp.Transporte:"
        '
        'txtReferenciaTercero
        '
        Me.txtReferenciaTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtReferenciaTercero.Location = New System.Drawing.Point(4, 72)
        Me.txtReferenciaTercero.Multiline = True
        Me.txtReferenciaTercero.Name = "txtReferenciaTercero"
        Me.txtReferenciaTercero.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReferenciaTercero.Size = New System.Drawing.Size(538, 22)
        Me.txtReferenciaTercero.TabIndex = 21
        UltraToolTipInfo3.ToolTipText = "Refencia del Punto de Llegada "
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtReferenciaTercero, UltraToolTipInfo3)
        '
        'numFleteTotalTerc
        '
        Appearance65.TextHAlignAsString = "Right"
        Me.numFleteTotalTerc.Appearance = Appearance65
        Me.numFleteTotalTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numFleteTotalTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numFleteTotalTerc.InputMask = "{double:10.4}"
        Me.numFleteTotalTerc.Location = New System.Drawing.Point(634, 69)
        Me.numFleteTotalTerc.Name = "numFleteTotalTerc"
        Me.numFleteTotalTerc.NonAutoSizeHeight = 20
        Me.numFleteTotalTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numFleteTotalTerc.ReadOnly = True
        Me.numFleteTotalTerc.Size = New System.Drawing.Size(75, 21)
        Me.numFleteTotalTerc.TabIndex = 13
        Me.numFleteTotalTerc.Text = "0.0000"
        '
        'numIgvTerc
        '
        Appearance66.TextHAlignAsString = "Right"
        Me.numIgvTerc.Appearance = Appearance66
        Me.numIgvTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numIgvTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numIgvTerc.InputMask = "{double:10.4}"
        Me.numIgvTerc.Location = New System.Drawing.Point(634, 47)
        Me.numIgvTerc.Name = "numIgvTerc"
        Me.numIgvTerc.NonAutoSizeHeight = 20
        Me.numIgvTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numIgvTerc.ReadOnly = True
        Me.numIgvTerc.Size = New System.Drawing.Size(75, 21)
        Me.numIgvTerc.TabIndex = 11
        Me.numIgvTerc.Text = "0.0000"
        '
        'cboMonedaT
        '
        Appearance67.ForeColor = System.Drawing.Color.Black
        Me.cboMonedaT.Appearance = Appearance67
        Me.cboMonedaT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMonedaT.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMonedaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonedaT.ForeColor = System.Drawing.Color.Black
        Me.cboMonedaT.Location = New System.Drawing.Point(94, 99)
        Me.cboMonedaT.Name = "cboMonedaT"
        Me.cboMonedaT.Size = New System.Drawing.Size(40, 21)
        Me.cboMonedaT.TabIndex = 5
        Me.cboMonedaT.ValueMember = "Id"
        '
        'btnAgregarTerc
        '
        Appearance68.Image = CType(resources.GetObject("Appearance68.Image"), Object)
        Me.btnAgregarTerc.Appearance = Appearance68
        Me.btnAgregarTerc.ImageList = Me.imagenes
        Me.btnAgregarTerc.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarTerc.Location = New System.Drawing.Point(871, 61)
        Me.btnAgregarTerc.Name = "btnAgregarTerc"
        Me.btnAgregarTerc.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarTerc.TabIndex = 14
        '
        'UltraLabel27
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Appearance69.TextVAlignAsString = "Middle"
        Me.UltraLabel27.Appearance = Appearance69
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Location = New System.Drawing.Point(44, 103)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel27.TabIndex = 4
        Me.UltraLabel27.Text = "Moneda:"
        '
        'UltraLabel7
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Appearance70.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance70
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(570, 72)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "Flete Total: "
        '
        'numFleteUnitarioTerc
        '
        Appearance71.TextHAlignAsString = "Right"
        Me.numFleteUnitarioTerc.Appearance = Appearance71
        Me.numFleteUnitarioTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numFleteUnitarioTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numFleteUnitarioTerc.InputMask = "{double:10.4}"
        Me.numFleteUnitarioTerc.Location = New System.Drawing.Point(634, 2)
        Me.numFleteUnitarioTerc.Name = "numFleteUnitarioTerc"
        Me.numFleteUnitarioTerc.NonAutoSizeHeight = 20
        Me.numFleteUnitarioTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numFleteUnitarioTerc.Size = New System.Drawing.Size(75, 21)
        Me.numFleteUnitarioTerc.TabIndex = 9
        Me.numFleteUnitarioTerc.Text = "0.0000"
        '
        'UltraLabel31
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Appearance72.TextVAlignAsString = "Middle"
        Me.UltraLabel31.Appearance = Appearance72
        Me.UltraLabel31.AutoSize = True
        Me.UltraLabel31.Location = New System.Drawing.Point(603, 50)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(27, 15)
        Me.UltraLabel31.TabIndex = 10
        Me.UltraLabel31.Text = "IGV:"
        '
        'UltraLabel33
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Appearance73.TextVAlignAsString = "Middle"
        Me.UltraLabel33.Appearance = Appearance73
        Me.UltraLabel33.AutoSize = True
        Me.UltraLabel33.Location = New System.Drawing.Point(39, 30)
        Me.UltraLabel33.Name = "UltraLabel33"
        Me.UltraLabel33.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel33.TabIndex = 2
        Me.UltraLabel33.Text = "Contacto:"
        '
        'numComisionTerc
        '
        Appearance74.TextHAlignAsString = "Right"
        Me.numComisionTerc.Appearance = Appearance74
        Me.numComisionTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numComisionTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numComisionTerc.InputMask = "{double:4.2}"
        Me.numComisionTerc.Location = New System.Drawing.Point(199, 100)
        Me.numComisionTerc.Name = "numComisionTerc"
        Me.numComisionTerc.NonAutoSizeHeight = 20
        Me.numComisionTerc.NullText = "0.00"
        Me.numComisionTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numComisionTerc.Size = New System.Drawing.Size(50, 21)
        Me.numComisionTerc.TabIndex = 7
        Me.numComisionTerc.Text = "100.00"
        '
        'UltraLabel34
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Appearance75.TextVAlignAsString = "Middle"
        Me.UltraLabel34.Appearance = Appearance75
        Me.UltraLabel34.AutoSize = True
        Me.UltraLabel34.Location = New System.Drawing.Point(141, 103)
        Me.UltraLabel34.Name = "UltraLabel34"
        Me.UltraLabel34.Size = New System.Drawing.Size(53, 15)
        Me.UltraLabel34.TabIndex = 6
        Me.UltraLabel34.Text = "Comisión: "
        '
        'UltraLabel35
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Appearance76.TextVAlignAsString = "Middle"
        Me.UltraLabel35.Appearance = Appearance76
        Me.UltraLabel35.AutoSize = True
        Me.UltraLabel35.Location = New System.Drawing.Point(556, 6)
        Me.UltraLabel35.Name = "UltraLabel35"
        Me.UltraLabel35.Size = New System.Drawing.Size(75, 15)
        Me.UltraLabel35.TabIndex = 8
        Me.UltraLabel35.Text = "Flete Unitario: "
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griDemandaRapida)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraExpandableGroupBox3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 3)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1336, 0)
        '
        'griDemandaRapida
        '
        Me.griDemandaRapida.DataSource = Me.ogdDemandaRapida
        UltraGridColumn159.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn159.Header.Caption = "Select"
        UltraGridColumn159.Header.VisiblePosition = 1
        UltraGridColumn159.Width = 38
        UltraGridColumn160.Header.VisiblePosition = 0
        UltraGridColumn160.Hidden = True
        UltraGridColumn160.Width = 85
        UltraGridColumn161.Header.VisiblePosition = 2
        UltraGridColumn161.Hidden = True
        UltraGridColumn161.Width = 91
        UltraGridColumn162.Header.VisiblePosition = 3
        UltraGridColumn162.Width = 64
        UltraGridColumn163.Header.VisiblePosition = 4
        UltraGridColumn163.Hidden = True
        UltraGridColumn163.Width = 199
        UltraGridColumn164.Header.VisiblePosition = 5
        UltraGridColumn164.Width = 200
        UltraGridColumn165.Header.VisiblePosition = 6
        UltraGridColumn165.Hidden = True
        UltraGridColumn165.Width = 111
        UltraGridColumn166.Header.VisiblePosition = 14
        UltraGridColumn166.Width = 150
        Appearance99.BackColor = System.Drawing.Color.Aqua
        Appearance99.TextHAlignAsString = "Right"
        UltraGridColumn167.CellAppearance = Appearance99
        UltraGridColumn167.Header.VisiblePosition = 7
        UltraGridColumn167.Hidden = True
        Appearance100.BackColor = System.Drawing.Color.LemonChiffon
        UltraGridColumn168.CellAppearance = Appearance100
        UltraGridColumn168.Header.VisiblePosition = 8
        UltraGridColumn168.Width = 300
        UltraGridColumn169.Header.VisiblePosition = 9
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 10
        UltraGridColumn170.Hidden = True
        UltraGridColumn170.Width = 61
        UltraGridColumn171.Header.VisiblePosition = 11
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.Header.VisiblePosition = 12
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 15
        UltraGridColumn173.Width = 150
        UltraGridColumn174.Header.VisiblePosition = 13
        UltraGridColumn174.Width = 200
        UltraGridColumn175.Header.VisiblePosition = 16
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.Header.VisiblePosition = 17
        UltraGridColumn176.Hidden = True
        UltraGridColumn176.Width = 150
        UltraGridColumn177.Header.VisiblePosition = 18
        UltraGridColumn177.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177})
        Me.griDemandaRapida.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griDemandaRapida.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griDemandaRapida.DisplayLayout.GroupByBox.Hidden = True
        Me.griDemandaRapida.DisplayLayout.MaxColScrollRegions = 1
        Me.griDemandaRapida.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDemandaRapida.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDemandaRapida.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDemandaRapida.DisplayLayout.Override.CellPadding = 0
        Me.griDemandaRapida.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDemandaRapida.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDemandaRapida.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDemandaRapida.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDemandaRapida.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griDemandaRapida.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDemandaRapida.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDemandaRapida.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDemandaRapida.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDemandaRapida.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDemandaRapida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDemandaRapida.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDemandaRapida.Location = New System.Drawing.Point(0, 26)
        Me.griDemandaRapida.Name = "griDemandaRapida"
        Me.griDemandaRapida.Size = New System.Drawing.Size(1336, 0)
        Me.griDemandaRapida.TabIndex = 1
        Me.griDemandaRapida.Tag = ""
        '
        'ogdDemandaRapida
        '
        UltraDataColumn64.DataType = GetType(Boolean)
        UltraDataColumn64.DefaultValue = False
        UltraDataColumn67.DataType = GetType(Date)
        UltraDataColumn76.DataType = GetType(Boolean)
        Me.ogdDemandaRapida.Band.Columns.AddRange(New Object() {UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82})
        '
        'UltraExpandableGroupBox3
        '
        Appearance101.BackColor = System.Drawing.Color.White
        Appearance101.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox3.ContentAreaAppearance = Appearance101
        Me.UltraExpandableGroupBox3.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.UltraExpandableGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox3.Expanded = False
        Me.UltraExpandableGroupBox3.ExpandedSize = New System.Drawing.Size(1336, 52)
        Me.UltraExpandableGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox3.Name = "UltraExpandableGroupBox3"
        Me.UltraExpandableGroupBox3.Size = New System.Drawing.Size(1336, 26)
        Me.UltraExpandableGroupBox3.TabIndex = 0
        Me.UltraExpandableGroupBox3.Text = "Consultas"
        Me.UltraExpandableGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraExpandableGroupBox7)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.cboZonaPreDemanda)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.btnConsultaPreDemanda)
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(1177, 29)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel5.Visible = False
        '
        'UltraExpandableGroupBox7
        '
        Me.UltraExpandableGroupBox7.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance102.BackColor = System.Drawing.Color.White
        Appearance102.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox7.ContentAreaAppearance = Appearance102
        Me.UltraExpandableGroupBox7.Controls.Add(Me.UltraExpandableGroupBoxPanel7)
        Me.UltraExpandableGroupBox7.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox7.ExpandedSize = New System.Drawing.Size(320, 29)
        Me.UltraExpandableGroupBox7.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox7.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox7.Location = New System.Drawing.Point(857, 0)
        Me.UltraExpandableGroupBox7.Name = "UltraExpandableGroupBox7"
        Me.UltraExpandableGroupBox7.Size = New System.Drawing.Size(320, 29)
        Me.UltraExpandableGroupBox7.TabIndex = 3
        Me.UltraExpandableGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel7
        '
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.numDiasAntes)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Etiqueta7)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.ColorPorVencer)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Etiqueta8)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.ColorVencidas)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Etiqueta9)
        Me.UltraExpandableGroupBoxPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel7.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel7.Name = "UltraExpandableGroupBoxPanel7"
        Me.UltraExpandableGroupBoxPanel7.Size = New System.Drawing.Size(299, 23)
        Me.UltraExpandableGroupBoxPanel7.TabIndex = 0
        '
        'numDiasAntes
        '
        Appearance103.ForeColor = System.Drawing.Color.Black
        Me.numDiasAntes.Appearance = Appearance103
        Me.numDiasAntes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numDiasAntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDiasAntes.ForeColor = System.Drawing.Color.Black
        Me.numDiasAntes.FormatString = ""
        Me.numDiasAntes.Location = New System.Drawing.Point(172, 1)
        Me.numDiasAntes.MaskInput = "nn"
        Me.numDiasAntes.MaxValue = 30
        Me.numDiasAntes.MinValue = 1
        Me.numDiasAntes.Name = "numDiasAntes"
        Me.numDiasAntes.NullText = "0"
        Me.numDiasAntes.Size = New System.Drawing.Size(41, 21)
        Me.numDiasAntes.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numDiasAntes.TabIndex = 3
        Me.numDiasAntes.Value = 1
        '
        'Etiqueta7
        '
        Appearance104.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance104
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(219, 5)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(26, 14)
        Me.Etiqueta7.TabIndex = 4
        Me.Etiqueta7.Text = "Días"
        '
        'ColorPorVencer
        '
        Me.ColorPorVencer.Location = New System.Drawing.Point(248, 1)
        Me.ColorPorVencer.Name = "ColorPorVencer"
        Me.ColorPorVencer.Size = New System.Drawing.Size(43, 21)
        Me.ColorPorVencer.TabIndex = 5
        Me.ColorPorVencer.Text = "Control"
        '
        'Etiqueta8
        '
        Appearance105.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance105
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(107, 5)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta8.TabIndex = 2
        Me.Etiqueta8.Text = "Por Vencer:"
        Me.ToolTip1.SetToolTip(Me.Etiqueta8, "Color de fondo para las demandas generadas")
        '
        'ColorVencidas
        '
        Me.ColorVencidas.Color = System.Drawing.Color.Red
        Me.ColorVencidas.Location = New System.Drawing.Point(58, 1)
        Me.ColorVencidas.Name = "ColorVencidas"
        Me.ColorVencidas.Size = New System.Drawing.Size(43, 21)
        Me.ColorVencidas.TabIndex = 1
        Me.ColorVencidas.Text = "Red"
        '
        'Etiqueta9
        '
        Appearance106.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance106
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(3, 5)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta9.TabIndex = 0
        Me.Etiqueta9.Text = "Vencidas:"
        Me.ToolTip1.SetToolTip(Me.Etiqueta9, "Color de fondo para las demandas generadas")
        '
        'cboZonaPreDemanda
        '
        Appearance107.ForeColor = System.Drawing.Color.Black
        Me.cboZonaPreDemanda.Appearance = Appearance107
        Me.cboZonaPreDemanda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboZonaPreDemanda.DisplayMember = "Nombre"
        Me.cboZonaPreDemanda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboZonaPreDemanda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboZonaPreDemanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZonaPreDemanda.ForeColor = System.Drawing.Color.Black
        Me.cboZonaPreDemanda.Location = New System.Drawing.Point(87, 6)
        Me.cboZonaPreDemanda.Name = "cboZonaPreDemanda"
        Me.cboZonaPreDemanda.Size = New System.Drawing.Size(200, 21)
        Me.cboZonaPreDemanda.TabIndex = 2
        Me.cboZonaPreDemanda.ValueMember = "Id"
        Me.cboZonaPreDemanda.Visible = False
        '
        'UltraLabel3
        '
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Appearance108.ForeColor = System.Drawing.Color.Navy
        Appearance108.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance108
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(51, 10)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel3.TabIndex = 1
        Me.UltraLabel3.Text = "Zona:"
        Me.UltraLabel3.Visible = False
        '
        'btnConsultaPreDemanda
        '
        Appearance109.Image = 13
        Appearance109.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance109.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnConsultaPreDemanda.Appearance = Appearance109
        Me.btnConsultaPreDemanda.ImageList = Me.imagenes
        Me.btnConsultaPreDemanda.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnConsultaPreDemanda.Location = New System.Drawing.Point(3, 0)
        Me.btnConsultaPreDemanda.Name = "btnConsultaPreDemanda"
        Me.btnConsultaPreDemanda.Size = New System.Drawing.Size(40, 30)
        Me.btnConsultaPreDemanda.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion9)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1336, 0)
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.griDisponibleVehiculo)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 26)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(1336, 0)
        Me.Agrupacion9.TabIndex = 6
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griDisponibleVehiculo
        '
        Me.griDisponibleVehiculo.DataSource = Me.ogdDisponibleVehiculos
        UltraGridColumn178.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn178.GroupByMode = Infragistics.Win.UltraWinGrid.GroupByMode.Value
        UltraGridColumn178.Header.VisiblePosition = 0
        UltraGridColumn178.Hidden = True
        UltraGridColumn179.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn179.GroupByMode = Infragistics.Win.UltraWinGrid.GroupByMode.Value
        UltraGridColumn179.Header.VisiblePosition = 2
        UltraGridColumn179.Hidden = True
        UltraGridColumn179.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn179.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn179.Width = 109
        UltraGridColumn180.Header.VisiblePosition = 3
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.Caption = "Viaje"
        UltraGridColumn181.Header.VisiblePosition = 4
        UltraGridColumn181.Hidden = True
        UltraGridColumn181.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn181.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn181.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn181.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn181.Width = 87
        UltraGridColumn182.Header.VisiblePosition = 5
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 12
        UltraGridColumn183.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn183.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn183.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn183.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn183.Width = 100
        UltraGridColumn184.Header.VisiblePosition = 14
        UltraGridColumn184.Hidden = True
        UltraGridColumn185.Header.Caption = "Disponible En"
        UltraGridColumn185.Header.VisiblePosition = 13
        UltraGridColumn185.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn185.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn185.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn185.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn185.Width = 100
        UltraGridColumn186.Header.VisiblePosition = 15
        UltraGridColumn186.Hidden = True
        UltraGridColumn187.Header.VisiblePosition = 16
        UltraGridColumn187.Hidden = True
        UltraGridColumn187.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn187.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn187.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn187.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn187.Width = 124
        UltraGridColumn188.Header.VisiblePosition = 31
        UltraGridColumn188.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn188.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn188.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn188.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn188.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn188.Width = 50
        UltraGridColumn189.Header.VisiblePosition = 17
        UltraGridColumn189.Hidden = True
        Appearance110.Image = 7
        UltraGridColumn190.CellAppearance = Appearance110
        Appearance111.Image = 3
        UltraGridColumn190.CellButtonAppearance = Appearance111
        UltraGridColumn190.Header.VisiblePosition = 8
        UltraGridColumn190.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn190.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn190.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn190.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn190.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn190.Width = 200
        UltraGridColumn191.Header.VisiblePosition = 26
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.VisiblePosition = 9
        UltraGridColumn192.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn192.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn192.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn192.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn192.Width = 212
        UltraGridColumn193.Header.VisiblePosition = 27
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 36
        UltraGridColumn194.Hidden = True
        UltraGridColumn194.Width = 223
        UltraGridColumn195.Header.VisiblePosition = 28
        UltraGridColumn195.Hidden = True
        UltraGridColumn196.Header.VisiblePosition = 10
        UltraGridColumn196.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn196.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn196.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn196.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn196.Width = 70
        UltraGridColumn197.Header.VisiblePosition = 29
        UltraGridColumn197.Hidden = True
        UltraGridColumn198.Header.VisiblePosition = 11
        UltraGridColumn198.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn198.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn198.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn198.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn198.Width = 60
        UltraGridColumn199.Header.VisiblePosition = 32
        UltraGridColumn199.Hidden = True
        UltraGridColumn200.Header.VisiblePosition = 30
        UltraGridColumn200.Hidden = True
        UltraGridColumn201.Header.VisiblePosition = 18
        UltraGridColumn201.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn201.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn201.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn201.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn201.Width = 80
        UltraGridColumn202.Header.VisiblePosition = 6
        UltraGridColumn202.Hidden = True
        UltraGridColumn202.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn202.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn202.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn202.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn202.Width = 66
        UltraGridColumn203.Header.VisiblePosition = 33
        UltraGridColumn203.Hidden = True
        UltraGridColumn204.Header.VisiblePosition = 34
        UltraGridColumn204.Hidden = True
        UltraGridColumn205.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn205.Header.Caption = "Select"
        UltraGridColumn205.Header.VisiblePosition = 1
        UltraGridColumn205.Hidden = True
        UltraGridColumn205.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn205.Width = 35
        UltraGridColumn206.Header.VisiblePosition = 35
        UltraGridColumn206.Hidden = True
        UltraGridColumn207.Header.VisiblePosition = 23
        UltraGridColumn207.Width = 100
        UltraGridColumn208.Header.VisiblePosition = 37
        UltraGridColumn208.Hidden = True
        UltraGridColumn209.Header.VisiblePosition = 38
        UltraGridColumn209.Hidden = True
        UltraGridColumn210.Header.VisiblePosition = 39
        UltraGridColumn210.Hidden = True
        UltraGridColumn211.Header.VisiblePosition = 40
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.VisiblePosition = 19
        UltraGridColumn212.Width = 200
        Appearance112.Image = 3
        Appearance112.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn213.CellAppearance = Appearance112
        Appearance113.Image = 1
        UltraGridColumn213.CellButtonAppearance = Appearance113
        UltraGridColumn213.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn213.Header.Caption = "Comentario - Observacion"
        UltraGridColumn213.Header.VisiblePosition = 22
        UltraGridColumn213.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn213.Width = 300
        UltraGridColumn214.Header.VisiblePosition = 41
        UltraGridColumn214.Hidden = True
        UltraGridColumn215.Header.VisiblePosition = 42
        UltraGridColumn215.Hidden = True
        UltraGridColumn216.Header.VisiblePosition = 43
        UltraGridColumn216.Hidden = True
        UltraGridColumn217.Header.VisiblePosition = 44
        UltraGridColumn217.Hidden = True
        UltraGridColumn217.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn217.Width = 100
        UltraGridColumn218.Header.VisiblePosition = 45
        UltraGridColumn218.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn218.Width = 100
        UltraGridColumn219.Header.VisiblePosition = 46
        UltraGridColumn219.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn219.Width = 100
        UltraGridColumn220.Header.VisiblePosition = 47
        UltraGridColumn220.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn220.Width = 100
        UltraGridColumn221.Header.VisiblePosition = 25
        UltraGridColumn221.Width = 100
        UltraGridColumn222.Header.Caption = "Bloque"
        UltraGridColumn222.Header.VisiblePosition = 24
        UltraGridColumn222.Hidden = True
        UltraGridColumn222.Width = 35
        UltraGridColumn225.Header.Caption = "TN"
        UltraGridColumn225.Header.VisiblePosition = 21
        UltraGridColumn225.Width = 50
        UltraGridColumn226.Header.VisiblePosition = 7
        UltraGridColumn226.Width = 80
        UltraGridColumn227.Header.VisiblePosition = 20
        UltraGridColumn228.Header.VisiblePosition = 48
        UltraGridColumn228.Hidden = True
        UltraGridColumn228.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn228.Width = 50
        UltraGridColumn229.Header.VisiblePosition = 49
        UltraGridColumn229.Hidden = True
        UltraGridColumn230.Header.VisiblePosition = 50
        UltraGridColumn230.Hidden = True
        UltraGridColumn231.Header.VisiblePosition = 51
        UltraGridColumn231.Hidden = True
        UltraGridColumn232.Header.VisiblePosition = 52
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.Header.VisiblePosition = 53
        UltraGridColumn233.Hidden = True
        UltraGridColumn234.Header.VisiblePosition = 54
        UltraGridColumn234.Hidden = True
        UltraGridColumn235.Header.Caption = "Capacidad"
        UltraGridColumn235.Header.VisiblePosition = 55
        UltraGridColumn235.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn235.Width = 50
        UltraGridColumn236.Header.VisiblePosition = 56
        UltraGridColumn236.Hidden = True
        UltraGridColumn237.Header.VisiblePosition = 57
        UltraGridColumn237.Hidden = True
        UltraGridColumn238.Header.VisiblePosition = 58
        UltraGridColumn239.Header.VisiblePosition = 59
        UltraGridColumn240.Header.VisiblePosition = 60
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240})
        UltraGridBand9.GroupHeadersVisible = False
        UltraGridBand9.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDisponibleVehiculo.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.griDisponibleVehiculo.DisplayLayout.MaxColScrollRegions = 1
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDisponibleVehiculo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griDisponibleVehiculo.DisplayLayout.Override.CellPadding = 1
        Me.griDisponibleVehiculo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDisponibleVehiculo.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDisponibleVehiculo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDisponibleVehiculo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDisponibleVehiculo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDisponibleVehiculo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDisponibleVehiculo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDisponibleVehiculo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDisponibleVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDisponibleVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDisponibleVehiculo.ImageList = Me.imagenes
        Me.griDisponibleVehiculo.Location = New System.Drawing.Point(2, 0)
        Me.griDisponibleVehiculo.Name = "griDisponibleVehiculo"
        Me.griDisponibleVehiculo.Size = New System.Drawing.Size(1332, 0)
        Me.griDisponibleVehiculo.TabIndex = 1
        Me.griDisponibleVehiculo.Tag = ""
        '
        'ogdDisponibleVehiculos
        '
        Me.ogdDisponibleVehiculos.Band.Columns.AddRange(New Object() {UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143})
        '
        'UltraExpandableGroupBox2
        '
        Appearance114.BackColor = System.Drawing.Color.White
        Appearance114.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance114
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel8)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox2.Expanded = False
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(1336, 87)
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(1336, 26)
        Me.UltraExpandableGroupBox2.TabIndex = 5
        Me.UltraExpandableGroupBox2.Text = "Consultas"
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel8
        '
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.UltraExpandableGroupBox4)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.exgruDisponibleNo)
        Me.UltraExpandableGroupBoxPanel8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel8.Name = "UltraExpandableGroupBoxPanel8"
        Me.UltraExpandableGroupBoxPanel8.Size = New System.Drawing.Size(1177, 64)
        Me.UltraExpandableGroupBoxPanel8.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel8.Visible = False
        '
        'UltraExpandableGroupBox4
        '
        Appearance115.BackColor = System.Drawing.Color.White
        Appearance115.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox4.ContentAreaAppearance = Appearance115
        Me.UltraExpandableGroupBox4.Controls.Add(Me.UltraExpandableGroupBoxPanel10)
        Me.UltraExpandableGroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox4.ExpandedSize = New System.Drawing.Size(220, 64)
        Me.UltraExpandableGroupBox4.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox4.Name = "UltraExpandableGroupBox4"
        Me.UltraExpandableGroupBox4.Size = New System.Drawing.Size(220, 64)
        Me.UltraExpandableGroupBox4.TabIndex = 53
        Me.UltraExpandableGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel10
        '
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.lblListoRegistro)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.btnConsultarDisponibles)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.UltraLabel59)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.cboZonaDisponibles)
        Me.UltraExpandableGroupBoxPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel10.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel10.Name = "UltraExpandableGroupBoxPanel10"
        Me.UltraExpandableGroupBoxPanel10.Size = New System.Drawing.Size(199, 58)
        Me.UltraExpandableGroupBoxPanel10.TabIndex = 0
        '
        'lblListoRegistro
        '
        Appearance116.BackColor = System.Drawing.Color.Transparent
        Appearance116.ForeColor = System.Drawing.Color.Navy
        Appearance116.TextVAlignAsString = "Middle"
        Me.lblListoRegistro.Appearance = Appearance116
        Me.lblListoRegistro.AutoSize = True
        Me.lblListoRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListoRegistro.Location = New System.Drawing.Point(4, 43)
        Me.lblListoRegistro.Name = "lblListoRegistro"
        Me.lblListoRegistro.Size = New System.Drawing.Size(80, 14)
        Me.lblListoRegistro.TabIndex = 55
        Me.lblListoRegistro.Text = "Lista Registro:"
        '
        'btnConsultarDisponibles
        '
        Appearance117.Image = "266.png"
        Appearance117.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance117.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnConsultarDisponibles.Appearance = Appearance117
        Me.btnConsultarDisponibles.ImageList = Me.imagenes
        Me.btnConsultarDisponibles.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnConsultarDisponibles.Location = New System.Drawing.Point(156, 11)
        Me.btnConsultarDisponibles.Name = "btnConsultarDisponibles"
        Me.btnConsultarDisponibles.Size = New System.Drawing.Size(40, 30)
        Me.btnConsultarDisponibles.TabIndex = 21
        '
        'UltraLabel59
        '
        Appearance118.BackColor = System.Drawing.Color.Transparent
        Appearance118.ForeColor = System.Drawing.Color.Navy
        Appearance118.TextVAlignAsString = "Middle"
        Me.UltraLabel59.Appearance = Appearance118
        Me.UltraLabel59.AutoSize = True
        Me.UltraLabel59.Location = New System.Drawing.Point(4, 2)
        Me.UltraLabel59.Name = "UltraLabel59"
        Me.UltraLabel59.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel59.TabIndex = 22
        Me.UltraLabel59.Text = "Zona:"
        '
        'cboZonaDisponibles
        '
        Appearance119.ForeColor = System.Drawing.Color.Black
        Me.cboZonaDisponibles.Appearance = Appearance119
        Me.cboZonaDisponibles.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboZonaDisponibles.DisplayMember = "Nombre"
        Me.cboZonaDisponibles.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboZonaDisponibles.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboZonaDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZonaDisponibles.ForeColor = System.Drawing.Color.Black
        Me.cboZonaDisponibles.Location = New System.Drawing.Point(4, 18)
        Me.cboZonaDisponibles.Name = "cboZonaDisponibles"
        Me.cboZonaDisponibles.Size = New System.Drawing.Size(150, 21)
        Me.cboZonaDisponibles.TabIndex = 23
        Me.cboZonaDisponibles.ValueMember = "Id"
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance120.BackColor = System.Drawing.Color.White
        Appearance120.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance120
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(585, 64)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(352, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(585, 64)
        Me.UltraExpandableGroupBox1.TabIndex = 49
        Me.UltraExpandableGroupBox1.Text = "T.V"
        UltraToolTipInfo6.ToolTipText = "Estados Viaje"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBox1, UltraToolTipInfo6)
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta47)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorParihueleroD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorPlataformaD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCamion20M3D)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta29)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta28)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorTolvaVolteoD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta27)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta25)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCamion65M3D)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorContenedorD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta222)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorGraneleroD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorFurgonD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorFurgonLargoD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta24)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta30)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta21)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCamionetaD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorVolqueteD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta31)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta32)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta23)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCamion30M3D)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta20)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta26)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCaliceraD)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorCamion40M3D)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta22)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ColorMediaBarandaD)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(562, 58)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        UltraToolTipInfo5.ToolTipText = "Estados"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBoxPanel4, UltraToolTipInfo5)
        '
        'Etiqueta47
        '
        Appearance121.BackColor = System.Drawing.Color.Transparent
        Appearance121.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta47.Appearance = Appearance121
        Me.Etiqueta47.AutoSize = True
        Me.Etiqueta47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta47.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta47.Location = New System.Drawing.Point(251, 23)
        Me.Etiqueta47.Name = "Etiqueta47"
        Me.Etiqueta47.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta47.TabIndex = 42
        Me.Etiqueta47.Text = "Parihuelero:"
        '
        'ColorParihueleroD
        '
        Me.ColorParihueleroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorParihueleroD.Location = New System.Drawing.Point(317, 19)
        Me.ColorParihueleroD.Name = "ColorParihueleroD"
        Me.ColorParihueleroD.Size = New System.Drawing.Size(44, 19)
        Me.ColorParihueleroD.TabIndex = 43
        Me.ColorParihueleroD.Text = "Control"
        '
        'ColorPlataformaD
        '
        Me.ColorPlataformaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPlataformaD.Location = New System.Drawing.Point(86, 0)
        Me.ColorPlataformaD.Name = "ColorPlataformaD"
        Me.ColorPlataformaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorPlataformaD.TabIndex = 15
        Me.ColorPlataformaD.Text = "Control"
        '
        'ColorCamion20M3D
        '
        Me.ColorCamion20M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion20M3D.Location = New System.Drawing.Point(513, 0)
        Me.ColorCamion20M3D.Name = "ColorCamion20M3D"
        Me.ColorCamion20M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion20M3D.TabIndex = 31
        Me.ColorCamion20M3D.Text = "Control"
        '
        'Etiqueta29
        '
        Appearance122.BackColor = System.Drawing.Color.Transparent
        Appearance122.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance122
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta29.Location = New System.Drawing.Point(363, 23)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta29.TabIndex = 28
        Me.Etiqueta29.Text = "Camioneta:"
        '
        'Etiqueta28
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance123
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(154, 3)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta28.TabIndex = 18
        Me.Etiqueta28.Text = "Furgon:"
        '
        'ColorTolvaVolteoD
        '
        Me.ColorTolvaVolteoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTolvaVolteoD.Location = New System.Drawing.Point(317, 38)
        Me.ColorTolvaVolteoD.Name = "ColorTolvaVolteoD"
        Me.ColorTolvaVolteoD.Size = New System.Drawing.Size(44, 19)
        Me.ColorTolvaVolteoD.TabIndex = 25
        Me.ColorTolvaVolteoD.Text = "Control"
        '
        'Etiqueta27
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance124
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(372, 3)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta27.TabIndex = 16
        Me.Etiqueta27.Text = "Volquete:"
        '
        'Etiqueta25
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta25.Appearance = Appearance125
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(258, 4)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta25.TabIndex = 22
        Me.Etiqueta25.Text = "Granelero:"
        '
        'ColorCamion65M3D
        '
        Me.ColorCamion65M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion65M3D.Location = New System.Drawing.Point(425, 38)
        Me.ColorCamion65M3D.Name = "ColorCamion65M3D"
        Me.ColorCamion65M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion65M3D.TabIndex = 37
        Me.ColorCamion65M3D.Text = "Control"
        '
        'ColorContenedorD
        '
        Me.ColorContenedorD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorContenedorD.Location = New System.Drawing.Point(199, 38)
        Me.ColorContenedorD.Name = "ColorContenedorD"
        Me.ColorContenedorD.Size = New System.Drawing.Size(44, 19)
        Me.ColorContenedorD.TabIndex = 27
        Me.ColorContenedorD.Text = "Control"
        '
        'Etiqueta222
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta222.Appearance = Appearance126
        Me.Etiqueta222.AutoSize = True
        Me.Etiqueta222.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta222.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta222.Location = New System.Drawing.Point(473, 3)
        Me.Etiqueta222.Name = "Etiqueta222"
        Me.Etiqueta222.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta222.TabIndex = 30
        Me.Etiqueta222.Text = "20 M3:"
        '
        'ColorGraneleroD
        '
        Me.ColorGraneleroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorGraneleroD.Location = New System.Drawing.Point(317, 0)
        Me.ColorGraneleroD.Name = "ColorGraneleroD"
        Me.ColorGraneleroD.Size = New System.Drawing.Size(44, 19)
        Me.ColorGraneleroD.TabIndex = 23
        Me.ColorGraneleroD.Text = "Control"
        '
        'ColorFurgonD
        '
        Me.ColorFurgonD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonD.Location = New System.Drawing.Point(199, 0)
        Me.ColorFurgonD.Name = "ColorFurgonD"
        Me.ColorFurgonD.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonD.TabIndex = 19
        Me.ColorFurgonD.Text = "Control"
        '
        'ColorFurgonLargoD
        '
        Me.ColorFurgonLargoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonLargoD.Location = New System.Drawing.Point(86, 19)
        Me.ColorFurgonLargoD.Name = "ColorFurgonLargoD"
        Me.ColorFurgonLargoD.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonLargoD.TabIndex = 39
        Me.ColorFurgonLargoD.Text = "Control"
        '
        'Etiqueta24
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Appearance127.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance127
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(24, 3)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta24.TabIndex = 14
        Me.Etiqueta24.Text = "Plataforma:"
        '
        'Etiqueta30
        '
        Appearance128.BackColor = System.Drawing.Color.Transparent
        Appearance128.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance128
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta30.Location = New System.Drawing.Point(246, 41)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta30.TabIndex = 24
        Me.Etiqueta30.Text = "Tolva Volteo:"
        '
        'Etiqueta21
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance129
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(365, 42)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta21.TabIndex = 36
        Me.Etiqueta21.Text = "65 / 50 M3:"
        '
        'ColorCamionetaD
        '
        Me.ColorCamionetaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamionetaD.Location = New System.Drawing.Point(425, 19)
        Me.ColorCamionetaD.Name = "ColorCamionetaD"
        Me.ColorCamionetaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamionetaD.TabIndex = 29
        Me.ColorCamionetaD.Text = "Control"
        '
        'ColorVolqueteD
        '
        Me.ColorVolqueteD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorVolqueteD.Location = New System.Drawing.Point(425, 0)
        Me.ColorVolqueteD.Name = "ColorVolqueteD"
        Me.ColorVolqueteD.Size = New System.Drawing.Size(44, 19)
        Me.ColorVolqueteD.TabIndex = 17
        Me.ColorVolqueteD.Text = "Control"
        '
        'Etiqueta31
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Appearance130.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance130
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta31.Location = New System.Drawing.Point(11, 22)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta31.TabIndex = 26
        Me.Etiqueta31.Text = "Furgon Largo:"
        '
        'Etiqueta32
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta32.Appearance = Appearance131
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta32.Location = New System.Drawing.Point(2, 41)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(84, 14)
        Me.Etiqueta32.TabIndex = 40
        Me.Etiqueta32.Text = "Media Baranda:"
        '
        'Etiqueta23
        '
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Appearance132.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance132
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(473, 41)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta23.TabIndex = 34
        Me.Etiqueta23.Text = "40 M3:"
        '
        'ColorCamion30M3D
        '
        Me.ColorCamion30M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion30M3D.Location = New System.Drawing.Point(513, 19)
        Me.ColorCamion30M3D.Name = "ColorCamion30M3D"
        Me.ColorCamion30M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion30M3D.TabIndex = 33
        Me.ColorCamion30M3D.Text = "Control"
        '
        'Etiqueta20
        '
        Appearance133.BackColor = System.Drawing.Color.Transparent
        Appearance133.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta20.Appearance = Appearance133
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(132, 41)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta20.TabIndex = 38
        Me.Etiqueta20.Text = "Contenedor:"
        '
        'Etiqueta26
        '
        Appearance134.BackColor = System.Drawing.Color.Transparent
        Appearance134.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance134
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(148, 23)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta26.TabIndex = 20
        Me.Etiqueta26.Text = "Calicera:"
        '
        'ColorCaliceraD
        '
        Me.ColorCaliceraD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCaliceraD.Location = New System.Drawing.Point(199, 19)
        Me.ColorCaliceraD.Name = "ColorCaliceraD"
        Me.ColorCaliceraD.Size = New System.Drawing.Size(44, 19)
        Me.ColorCaliceraD.TabIndex = 21
        Me.ColorCaliceraD.Text = "Control"
        '
        'ColorCamion40M3D
        '
        Me.ColorCamion40M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion40M3D.Location = New System.Drawing.Point(513, 38)
        Me.ColorCamion40M3D.Name = "ColorCamion40M3D"
        Me.ColorCamion40M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion40M3D.TabIndex = 35
        Me.ColorCamion40M3D.Text = "Control"
        '
        'Etiqueta22
        '
        Appearance135.BackColor = System.Drawing.Color.Transparent
        Appearance135.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta22.Appearance = Appearance135
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(473, 23)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta22.TabIndex = 32
        Me.Etiqueta22.Text = "30 M3:"
        '
        'ColorMediaBarandaD
        '
        Me.ColorMediaBarandaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorMediaBarandaD.Location = New System.Drawing.Point(86, 38)
        Me.ColorMediaBarandaD.Name = "ColorMediaBarandaD"
        Me.ColorMediaBarandaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorMediaBarandaD.TabIndex = 41
        Me.ColorMediaBarandaD.Text = "Control"
        '
        'exgruDisponibleNo
        '
        Me.exgruDisponibleNo.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance136.BackColor = System.Drawing.Color.White
        Appearance136.BackColor2 = System.Drawing.Color.White
        Me.exgruDisponibleNo.ContentAreaAppearance = Appearance136
        Me.exgruDisponibleNo.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.exgruDisponibleNo.Dock = System.Windows.Forms.DockStyle.Right
        Me.exgruDisponibleNo.ExpandedSize = New System.Drawing.Size(240, 64)
        Me.exgruDisponibleNo.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruDisponibleNo.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exgruDisponibleNo.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.exgruDisponibleNo.Location = New System.Drawing.Point(937, 0)
        Me.exgruDisponibleNo.Name = "exgruDisponibleNo"
        Me.exgruDisponibleNo.Size = New System.Drawing.Size(240, 64)
        Me.exgruDisponibleNo.TabIndex = 48
        Me.exgruDisponibleNo.Text = "No"
        UltraToolTipInfo12.ToolTipText = "Trabajador / Vehiculos No Disponible"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.exgruDisponibleNo, UltraToolTipInfo12)
        Me.exgruDisponibleNo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorAdvertencia)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta19)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta15)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorPiloto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorAyudante)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorCarreta)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorTracto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorCopiloto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta14)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta18)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta17)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta16)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(217, 58)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        UltraToolTipInfo11.ToolTipText = "No Disponibles"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.UltraExpandableGroupBoxPanel3, UltraToolTipInfo11)
        '
        'ColorAdvertencia
        '
        Me.ColorAdvertencia.Color = System.Drawing.Color.Red
        Me.ColorAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAdvertencia.Location = New System.Drawing.Point(69, 0)
        Me.ColorAdvertencia.Name = "ColorAdvertencia"
        Me.ColorAdvertencia.Size = New System.Drawing.Size(44, 19)
        Me.ColorAdvertencia.TabIndex = 12
        Me.ColorAdvertencia.Text = "Red"
        '
        'Etiqueta19
        '
        Appearance137.BackColor = System.Drawing.Color.Transparent
        Appearance137.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta19.Appearance = Appearance137
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(29, 21)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta19.TabIndex = 19
        Me.Etiqueta19.Text = "Tracto:"
        '
        'Etiqueta15
        '
        Appearance138.BackColor = System.Drawing.Color.White
        Appearance138.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance138
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(2, 2)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta15.TabIndex = 11
        Me.Etiqueta15.Text = "Advertencia:"
        '
        'ColorPiloto
        '
        Me.ColorPiloto.Color = System.Drawing.Color.Lime
        Me.ColorPiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPiloto.Location = New System.Drawing.Point(170, 0)
        Me.ColorPiloto.Name = "ColorPiloto"
        Me.ColorPiloto.Size = New System.Drawing.Size(44, 19)
        Me.ColorPiloto.TabIndex = 18
        Me.ColorPiloto.Text = "Lime"
        UltraToolTipInfo7.ToolTipText = "Color que especifica si el piloto no se encuentra disponible para el viaje"
        UltraToolTipInfo7.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorPiloto, UltraToolTipInfo7)
        '
        'ColorAyudante
        '
        Me.ColorAyudante.Color = System.Drawing.Color.Blue
        Me.ColorAyudante.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAyudante.Location = New System.Drawing.Point(170, 38)
        Me.ColorAyudante.Name = "ColorAyudante"
        Me.ColorAyudante.Size = New System.Drawing.Size(44, 19)
        Me.ColorAyudante.TabIndex = 15
        Me.ColorAyudante.Text = "Blue"
        UltraToolTipInfo8.ToolTipText = "Color que especifica si el piloto no se encuentra disponible para el viaje"
        UltraToolTipInfo8.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorAyudante, UltraToolTipInfo8)
        '
        'ColorCarreta
        '
        Me.ColorCarreta.Color = System.Drawing.Color.Yellow
        Me.ColorCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCarreta.Location = New System.Drawing.Point(69, 38)
        Me.ColorCarreta.Name = "ColorCarreta"
        Me.ColorCarreta.Size = New System.Drawing.Size(44, 19)
        Me.ColorCarreta.TabIndex = 22
        Me.ColorCarreta.Text = "Yellow"
        '
        'ColorTracto
        '
        Me.ColorTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTracto.Location = New System.Drawing.Point(69, 19)
        Me.ColorTracto.Name = "ColorTracto"
        Me.ColorTracto.Size = New System.Drawing.Size(44, 19)
        Me.ColorTracto.TabIndex = 16
        Me.ColorTracto.Text = "Control"
        UltraToolTipInfo9.ToolTipText = "Color que especifica si el piloto no se encuentra disponible para el viaje"
        UltraToolTipInfo9.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorTracto, UltraToolTipInfo9)
        '
        'ColorCopiloto
        '
        Me.ColorCopiloto.Color = System.Drawing.Color.Aqua
        Me.ColorCopiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCopiloto.Location = New System.Drawing.Point(170, 19)
        Me.ColorCopiloto.Name = "ColorCopiloto"
        Me.ColorCopiloto.Size = New System.Drawing.Size(44, 19)
        Me.ColorCopiloto.TabIndex = 14
        Me.ColorCopiloto.Text = "Aqua"
        UltraToolTipInfo10.ToolTipText = "Color que especifica si el copiloto no se encuentra disponible para el viaje"
        UltraToolTipInfo10.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorCopiloto, UltraToolTipInfo10)
        '
        'Etiqueta14
        '
        Appearance139.BackColor = System.Drawing.Color.Transparent
        Appearance139.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance139
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(134, 2)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta14.TabIndex = 17
        Me.Etiqueta14.Text = "Piloto:"
        '
        'Etiqueta18
        '
        Appearance140.BackColor = System.Drawing.Color.Transparent
        Appearance140.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance140
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(115, 40)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta18.TabIndex = 20
        Me.Etiqueta18.Text = "Ayudante:"
        '
        'Etiqueta17
        '
        Appearance141.BackColor = System.Drawing.Color.Transparent
        Appearance141.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance141
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(121, 22)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta17.TabIndex = 13
        Me.Etiqueta17.Text = "Copiloto:"
        '
        'Etiqueta16
        '
        Appearance142.BackColor = System.Drawing.Color.Transparent
        Appearance142.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance142
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(24, 40)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta16.TabIndex = 21
        Me.Etiqueta16.Text = "Carreta:"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.tabDemandaCargas)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1346, 638)
        '
        'tabDemandaCargas
        '
        Appearance25.BackColor = System.Drawing.Color.White
        Appearance25.BackColor2 = System.Drawing.Color.White
        Me.tabDemandaCargas.ClientAreaAppearance = Appearance25
        Me.tabDemandaCargas.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.tabDemandaCargas.Controls.Add(Me.UltraTabPageControl5)
        Me.tabDemandaCargas.Controls.Add(Me.UltraTabPageControl6)
        Me.tabDemandaCargas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDemandaCargas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDemandaCargas.Location = New System.Drawing.Point(0, 93)
        Me.tabDemandaCargas.Name = "tabDemandaCargas"
        Me.tabDemandaCargas.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.tabDemandaCargas.Size = New System.Drawing.Size(1346, 545)
        Me.tabDemandaCargas.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.tabDemandaCargas.TabIndex = 18
        UltraTab7.TabPage = Me.UltraTabPageControl5
        UltraTab7.Text = "Cargas"
        UltraTab8.TabPage = Me.UltraTabPageControl6
        UltraTab8.Text = "Cargas Operaciones"
        Me.tabDemandaCargas.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab7, UltraTab8})
        Me.tabDemandaCargas.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1344, 522)
        '
        'agrBusqueda
        '
        Appearance26.BackColor = System.Drawing.Color.White
        Appearance26.BackColor2 = System.Drawing.Color.White
        Me.agrBusqueda.ContentAreaAppearance = Appearance26
        Me.agrBusqueda.Controls.Add(Me.UltraGroupBox3)
        Me.agrBusqueda.Controls.Add(Me.verViajeRetorno)
        Me.agrBusqueda.Controls.Add(Me.UltraGroupBox13)
        Me.agrBusqueda.Controls.Add(Me.cboUsuario)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel62)
        Me.agrBusqueda.Controls.Add(Me.UltraGroupBox4)
        Me.agrBusqueda.Controls.Add(Me.Agrupacion3)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1346, 93)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Busqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox3
        '
        Appearance27.BackColor = System.Drawing.Color.White
        Appearance27.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance27
        Me.UltraGroupBox3.Controls.Add(Me.chkExcluirDemandas)
        Me.UltraGroupBox3.Controls.Add(Me.chkTercerizadoFiltro)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(635, 19)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(151, 67)
        Me.UltraGroupBox3.TabIndex = 60
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkExcluirDemandas
        '
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.chkExcluirDemandas.Appearance = Appearance28
        Me.chkExcluirDemandas.AutoSize = True
        Me.chkExcluirDemandas.Checked = True
        Me.chkExcluirDemandas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExcluirDemandas.Location = New System.Drawing.Point(6, 31)
        Me.chkExcluirDemandas.Name = "chkExcluirDemandas"
        Me.chkExcluirDemandas.Size = New System.Drawing.Size(138, 18)
        Me.chkExcluirDemandas.TabIndex = 60
        Me.chkExcluirDemandas.Text = "Excluir Dem.Asignadas"
        '
        'chkTercerizadoFiltro
        '
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.chkTercerizadoFiltro.Appearance = Appearance29
        Me.chkTercerizadoFiltro.AutoSize = True
        Me.chkTercerizadoFiltro.Location = New System.Drawing.Point(6, 7)
        Me.chkTercerizadoFiltro.Name = "chkTercerizadoFiltro"
        Me.chkTercerizadoFiltro.Size = New System.Drawing.Size(87, 18)
        Me.chkTercerizadoFiltro.TabIndex = 58
        Me.chkTercerizadoFiltro.Text = "Tercerizados"
        '
        'verViajeRetorno
        '
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.verViajeRetorno.Appearance = Appearance30
        Me.verViajeRetorno.AutoSize = True
        Me.verViajeRetorno.BackColor = System.Drawing.Color.Transparent
        Me.verViajeRetorno.BackColorInternal = System.Drawing.Color.Transparent
        Me.verViajeRetorno.Location = New System.Drawing.Point(161, 63)
        Me.verViajeRetorno.Name = "verViajeRetorno"
        Me.verViajeRetorno.Size = New System.Drawing.Size(109, 18)
        Me.verViajeRetorno.TabIndex = 57
        Me.verViajeRetorno.Text = "Incluir V. Retorno"
        Me.verViajeRetorno.Visible = False
        '
        'UltraGroupBox13
        '
        Appearance31.BackColor = System.Drawing.Color.White
        Appearance31.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox13.ContentAreaAppearance = Appearance31
        Me.UltraGroupBox13.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox13.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel20)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(6, 19)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(150, 70)
        Me.UltraGroupBox13.TabIndex = 51
        Me.UltraGroupBox13.Text = "F.Atencion"
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecHasta
        '
        Me.fecHasta.DateTime = New Date(2015, 4, 6, 0, 0, 0, 0)
        Me.fecHasta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecHasta.Location = New System.Drawing.Point(50, 43)
        Me.fecHasta.MaskInput = ""
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(90, 22)
        Me.fecHasta.TabIndex = 50
        Me.fecHasta.Value = New Date(2015, 4, 6, 0, 0, 0, 0)
        '
        'UltraLabel6
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Appearance32.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance32
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(7, 49)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel6.TabIndex = 49
        Me.UltraLabel6.Text = "Hasta:"
        '
        'fecDesde
        '
        Me.fecDesde.DateTime = New Date(2015, 4, 6, 0, 0, 0, 0)
        Me.fecDesde.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDesde.Location = New System.Drawing.Point(50, 20)
        Me.fecDesde.MaskInput = ""
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(90, 22)
        Me.fecDesde.TabIndex = 48
        Me.fecDesde.Value = New Date(2015, 4, 6, 0, 0, 0, 0)
        '
        'UltraLabel20
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Appearance33.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance33
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(4, 26)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel20.TabIndex = 47
        Me.UltraLabel20.Text = "Desde:"
        '
        'cboUsuario
        '
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.cboUsuario.Appearance = Appearance34
        Me.cboUsuario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboUsuario.DisplayMember = "Login"
        Me.cboUsuario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboUsuario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsuario.ForeColor = System.Drawing.Color.Black
        Me.cboUsuario.Location = New System.Drawing.Point(163, 40)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(100, 21)
        Me.cboUsuario.TabIndex = 2
        Me.cboUsuario.ValueMember = "Id"
        '
        'UltraLabel62
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Appearance35.TextVAlignAsString = "Middle"
        Me.UltraLabel62.Appearance = Appearance35
        Me.UltraLabel62.AutoSize = True
        Me.UltraLabel62.Location = New System.Drawing.Point(164, 21)
        Me.UltraLabel62.Name = "UltraLabel62"
        Me.UltraLabel62.Size = New System.Drawing.Size(46, 15)
        Me.UltraLabel62.TabIndex = 1
        Me.UltraLabel62.Text = "Usuario:"
        '
        'UltraGroupBox4
        '
        Appearance36.BackColor = System.Drawing.Color.White
        Appearance36.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox4.ContentAreaAppearance = Appearance36
        Me.UltraGroupBox4.Controls.Add(Me.txtTotalComisionLista)
        Me.UltraGroupBox4.Controls.Add(Me.txtTotalFlotaLista)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel24)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel26)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(816, 19)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(200, 58)
        Me.UltraGroupBox4.TabIndex = 4
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.UltraGroupBox4.Visible = False
        '
        'txtTotalComisionLista
        '
        Me.txtTotalComisionLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTotalComisionLista.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtTotalComisionLista.InputMask = "{double:15.2}"
        Me.txtTotalComisionLista.Location = New System.Drawing.Point(73, 28)
        Me.txtTotalComisionLista.Name = "txtTotalComisionLista"
        Me.txtTotalComisionLista.NonAutoSizeHeight = 20
        Me.txtTotalComisionLista.ReadOnly = True
        Me.txtTotalComisionLista.Size = New System.Drawing.Size(120, 21)
        Me.txtTotalComisionLista.TabIndex = 3
        Me.txtTotalComisionLista.Text = "0.00"
        '
        'txtTotalFlotaLista
        '
        Me.txtTotalFlotaLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTotalFlotaLista.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtTotalFlotaLista.InputMask = "{double:15.2}"
        Me.txtTotalFlotaLista.Location = New System.Drawing.Point(73, 5)
        Me.txtTotalFlotaLista.Name = "txtTotalFlotaLista"
        Me.txtTotalFlotaLista.NonAutoSizeHeight = 20
        Me.txtTotalFlotaLista.ReadOnly = True
        Me.txtTotalFlotaLista.Size = New System.Drawing.Size(120, 21)
        Me.txtTotalFlotaLista.TabIndex = 1
        Me.txtTotalFlotaLista.Text = "0.00"
        '
        'UltraLabel24
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Appearance37.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance37
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(5, 31)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(64, 15)
        Me.UltraLabel24.TabIndex = 2
        Me.UltraLabel24.Text = "Comision T: "
        '
        'UltraLabel26
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Appearance38.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance38
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Location = New System.Drawing.Point(9, 9)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel26.TabIndex = 0
        Me.UltraLabel26.Text = "Flete Total: "
        '
        'Agrupacion3
        '
        Appearance39.BackColor = System.Drawing.Color.White
        Appearance39.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion3.ContentAreaAppearance = Appearance39
        Me.Agrupacion3.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion3.Controls.Add(Me.ColorAprobada)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion3.Controls.Add(Me.ColorCancelada)
        Me.Agrupacion3.Controls.Add(Me.colorCambio)
        Me.Agrupacion3.Controls.Add(Me.VerAsignada)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta45)
        Me.Agrupacion3.Controls.Add(Me.ColorParcial)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion3.Controls.Add(Me.ColorAsignada)
        Me.Agrupacion3.Controls.Add(Me.ColorGenerada)
        Me.Agrupacion3.Controls.Add(Me.etiDemandaGenerada)
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion3.Location = New System.Drawing.Point(273, 19)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(360, 70)
        Me.Agrupacion3.TabIndex = 3
        Me.Agrupacion3.Text = "Estados de Atencion"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta2
        '
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance40
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(238, 48)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta2.TabIndex = 57
        Me.Etiqueta2.Text = "Aprobada:"
        '
        'ColorAprobada
        '
        Me.ColorAprobada.Location = New System.Drawing.Point(304, 44)
        Me.ColorAprobada.Name = "ColorAprobada"
        Me.ColorAprobada.Size = New System.Drawing.Size(43, 21)
        Me.ColorAprobada.TabIndex = 56
        Me.ColorAprobada.Text = "Control"
        '
        'Etiqueta1
        '
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance41
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(238, 25)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta1.TabIndex = 55
        Me.Etiqueta1.Text = "Cancelada:"
        '
        'ColorCancelada
        '
        Me.ColorCancelada.Color = System.Drawing.Color.Plum
        Me.ColorCancelada.Location = New System.Drawing.Point(304, 21)
        Me.ColorCancelada.Name = "ColorCancelada"
        Me.ColorCancelada.Size = New System.Drawing.Size(43, 21)
        Me.ColorCancelada.TabIndex = 54
        Me.ColorCancelada.Text = "Plum"
        '
        'colorCambio
        '
        Me.colorCambio.Color = System.Drawing.Color.Cyan
        Me.colorCambio.Location = New System.Drawing.Point(189, 44)
        Me.colorCambio.Name = "colorCambio"
        Me.colorCambio.Size = New System.Drawing.Size(44, 21)
        Me.colorCambio.TabIndex = 53
        Me.colorCambio.Text = "Cyan"
        '
        'VerAsignada
        '
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.VerAsignada.Appearance = Appearance42
        Me.VerAsignada.Location = New System.Drawing.Point(117, 21)
        Me.VerAsignada.Name = "VerAsignada"
        Me.VerAsignada.Size = New System.Drawing.Size(70, 20)
        Me.VerAsignada.TabIndex = 4
        Me.VerAsignada.Text = "Asignada:"
        '
        'Etiqueta45
        '
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta45.Appearance = Appearance43
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(123, 48)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(64, 14)
        Me.Etiqueta45.TabIndex = 52
        Me.Etiqueta45.Text = "Actualizado:"
        '
        'ColorParcial
        '
        Me.ColorParcial.Color = System.Drawing.Color.Yellow
        Me.ColorParcial.Location = New System.Drawing.Point(65, 44)
        Me.ColorParcial.Name = "ColorParcial"
        Me.ColorParcial.Size = New System.Drawing.Size(43, 21)
        Me.ColorParcial.TabIndex = 3
        Me.ColorParcial.Text = "Yellow"
        '
        'Etiqueta4
        '
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance44
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(20, 48)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta4.TabIndex = 2
        Me.Etiqueta4.Text = "Parcial:"
        '
        'ColorAsignada
        '
        Me.ColorAsignada.Color = System.Drawing.Color.LimeGreen
        Me.ColorAsignada.Location = New System.Drawing.Point(189, 21)
        Me.ColorAsignada.Name = "ColorAsignada"
        Me.ColorAsignada.Size = New System.Drawing.Size(43, 21)
        Me.ColorAsignada.TabIndex = 5
        Me.ColorAsignada.Text = "LimeGreen"
        '
        'ColorGenerada
        '
        Me.ColorGenerada.Color = System.Drawing.Color.White
        Me.ColorGenerada.Location = New System.Drawing.Point(65, 21)
        Me.ColorGenerada.Name = "ColorGenerada"
        Me.ColorGenerada.Size = New System.Drawing.Size(43, 21)
        Me.ColorGenerada.TabIndex = 1
        Me.ColorGenerada.Text = "White"
        '
        'etiDemandaGenerada
        '
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.etiDemandaGenerada.Appearance = Appearance45
        Me.etiDemandaGenerada.AutoSize = True
        Me.etiDemandaGenerada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDemandaGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiDemandaGenerada.Location = New System.Drawing.Point(6, 25)
        Me.etiDemandaGenerada.Name = "etiDemandaGenerada"
        Me.etiDemandaGenerada.Size = New System.Drawing.Size(56, 14)
        Me.etiDemandaGenerada.TabIndex = 0
        Me.etiDemandaGenerada.Text = "Generada:"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.tabs)
        Me.utpDetalle.Controls.Add(Me.UltraExpandableGroupBox9)
        Me.utpDetalle.Controls.Add(Me.exgruConsultas)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1346, 638)
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.tabs.Controls.Add(Me.UltraTabPageControl8)
        Me.tabs.Controls.Add(Me.UltraTabPageControl9)
        Me.tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabs.ImageList = Me.imagenes
        Me.tabs.Location = New System.Drawing.Point(0, 202)
        Me.tabs.Name = "tabs"
        Me.tabs.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.tabs.Size = New System.Drawing.Size(1346, 436)
        Me.tabs.TabIndex = 2
        Appearance77.Image = 10
        UltraTab1.SelectedAppearance = Appearance77
        UltraTab1.TabPage = Me.UltraTabPageControl8
        UltraTab1.Text = "Detalle Carga"
        Appearance78.Image = 9
        UltraTab2.SelectedAppearance = Appearance78
        UltraTab2.TabPage = Me.UltraTabPageControl9
        UltraTab2.Text = "Contrato Tercero"
        UltraTab2.Visible = False
        Me.tabs.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tabs.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(1342, 413)
        '
        'UltraExpandableGroupBox9
        '
        Me.UltraExpandableGroupBox9.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Appearance79.BackColor = System.Drawing.Color.White
        Appearance79.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox9.ContentAreaAppearance = Appearance79
        Me.UltraExpandableGroupBox9.Controls.Add(Me.UltraExpandableGroupBoxPanel9)
        Me.UltraExpandableGroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox9.ExpandedSize = New System.Drawing.Size(1346, 176)
        Me.UltraExpandableGroupBox9.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox9.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox9.Location = New System.Drawing.Point(0, 26)
        Me.UltraExpandableGroupBox9.Name = "UltraExpandableGroupBox9"
        Me.UltraExpandableGroupBox9.Size = New System.Drawing.Size(1346, 176)
        Me.UltraExpandableGroupBox9.TabIndex = 1
        Me.UltraExpandableGroupBox9.Text = "Datos Generales"
        Me.UltraExpandableGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel9
        '
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel36)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.chkTercerizacion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.udtHoraSolicita)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.udtHoraAtencion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.udtHoraRecepcion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel30)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.dtFechaRecepcion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.lblNumeroDemanda)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraGroupBox14)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.NroDemanda)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.cboDestino)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.cboEscala)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.cboOrigen)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.cboTipoVehiculo)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.numNroUnidades)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.txtMotivoEscala)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.chkEscala)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel16)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.dtFechaAtencion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel11)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel9)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.dtSolicita)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel5)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.txtNumero)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.txtObservacion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel8)
        Me.UltraExpandableGroupBoxPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel9.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel9.Name = "UltraExpandableGroupBoxPanel9"
        Me.UltraExpandableGroupBoxPanel9.Size = New System.Drawing.Size(1340, 153)
        Me.UltraExpandableGroupBoxPanel9.TabIndex = 0
        '
        'UltraLabel36
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Appearance80.TextVAlignAsString = "Middle"
        Me.UltraLabel36.Appearance = Appearance80
        Me.UltraLabel36.AutoSize = True
        Me.UltraLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel36.Location = New System.Drawing.Point(8, 129)
        Me.UltraLabel36.Name = "UltraLabel36"
        Me.UltraLabel36.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel36.TabIndex = 17
        Me.UltraLabel36.Text = "Observac:"
        '
        'chkTercerizacion
        '
        Appearance81.FontData.BoldAsString = "True"
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.chkTercerizacion.Appearance = Appearance81
        Me.chkTercerizacion.AutoSize = True
        Me.chkTercerizacion.Location = New System.Drawing.Point(471, 104)
        Me.chkTercerizacion.Name = "chkTercerizacion"
        Me.chkTercerizacion.Size = New System.Drawing.Size(117, 17)
        Me.chkTercerizacion.TabIndex = 27
        Me.chkTercerizacion.Text = "TERCERIZACION"
        Me.chkTercerizacion.Visible = False
        '
        'udtHoraSolicita
        '
        Appearance82.FontData.BoldAsString = "False"
        Me.udtHoraSolicita.Appearance = Appearance82
        Me.udtHoraSolicita.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.udtHoraSolicita.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.udtHoraSolicita.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.udtHoraSolicita.Location = New System.Drawing.Point(155, 28)
        Me.udtHoraSolicita.MaskInput = "{LOC}hh:mm"
        Me.udtHoraSolicita.Name = "udtHoraSolicita"
        Me.udtHoraSolicita.Nullable = False
        Me.udtHoraSolicita.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.udtHoraSolicita.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.udtHoraSolicita.Size = New System.Drawing.Size(55, 21)
        Me.udtHoraSolicita.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.udtHoraSolicita.TabIndex = 6
        Me.udtHoraSolicita.Tag = ""
        Me.udtHoraSolicita.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'udtHoraAtencion
        '
        Appearance83.FontData.BoldAsString = "False"
        Me.udtHoraAtencion.Appearance = Appearance83
        Me.udtHoraAtencion.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.udtHoraAtencion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.udtHoraAtencion.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.udtHoraAtencion.Location = New System.Drawing.Point(155, 53)
        Me.udtHoraAtencion.MaskInput = "{LOC}hh:mm"
        Me.udtHoraAtencion.Name = "udtHoraAtencion"
        Me.udtHoraAtencion.Nullable = False
        Me.udtHoraAtencion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.udtHoraAtencion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.udtHoraAtencion.Size = New System.Drawing.Size(55, 21)
        Me.udtHoraAtencion.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.udtHoraAtencion.TabIndex = 9
        Me.udtHoraAtencion.Tag = ""
        Me.udtHoraAtencion.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'udtHoraRecepcion
        '
        Appearance84.FontData.BoldAsString = "False"
        Me.udtHoraRecepcion.Appearance = Appearance84
        Me.udtHoraRecepcion.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.udtHoraRecepcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.udtHoraRecepcion.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.udtHoraRecepcion.Location = New System.Drawing.Point(381, 51)
        Me.udtHoraRecepcion.MaskInput = "{LOC}hh:mm"
        Me.udtHoraRecepcion.Name = "udtHoraRecepcion"
        Me.udtHoraRecepcion.Nullable = False
        Me.udtHoraRecepcion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.udtHoraRecepcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.udtHoraRecepcion.Size = New System.Drawing.Size(55, 21)
        Me.udtHoraRecepcion.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.udtHoraRecepcion.TabIndex = 12
        Me.udtHoraRecepcion.Tag = ""
        Me.udtHoraRecepcion.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel30
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Appearance85.TextVAlignAsString = "Middle"
        Me.UltraLabel30.Appearance = Appearance85
        Me.UltraLabel30.AutoSize = True
        Me.UltraLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel30.Location = New System.Drawing.Point(226, 55)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel30.TabIndex = 10
        Me.UltraLabel30.Text = "F.Recepcion:"
        '
        'dtFechaRecepcion
        '
        Me.dtFechaRecepcion.DateTime = New Date(2015, 3, 17, 0, 0, 0, 0)
        Me.dtFechaRecepcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.dtFechaRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaRecepcion.Location = New System.Drawing.Point(297, 51)
        Me.dtFechaRecepcion.MaskInput = ""
        Me.dtFechaRecepcion.Name = "dtFechaRecepcion"
        Me.dtFechaRecepcion.Size = New System.Drawing.Size(80, 21)
        Me.dtFechaRecepcion.TabIndex = 11
        Me.dtFechaRecepcion.Value = New Date(2015, 3, 17, 0, 0, 0, 0)
        '
        'lblNumeroDemanda
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Appearance86.TextVAlignAsString = "Middle"
        Me.lblNumeroDemanda.Appearance = Appearance86
        Me.lblNumeroDemanda.AutoSize = True
        Me.lblNumeroDemanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroDemanda.Location = New System.Drawing.Point(306, 7)
        Me.lblNumeroDemanda.Name = "lblNumeroDemanda"
        Me.lblNumeroDemanda.Size = New System.Drawing.Size(72, 14)
        Me.lblNumeroDemanda.TabIndex = 2
        Me.lblNumeroDemanda.Text = "Nº Demanda:"
        '
        'UltraGroupBox14
        '
        Me.UltraGroupBox14.Controls.Add(Me.txtComisionTotal)
        Me.UltraGroupBox14.Controls.Add(Me.txtFleteTotal)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel22)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel23)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel32)
        Me.UltraGroupBox14.Location = New System.Drawing.Point(881, 7)
        Me.UltraGroupBox14.Name = "UltraGroupBox14"
        Me.UltraGroupBox14.Size = New System.Drawing.Size(245, 94)
        Me.UltraGroupBox14.TabIndex = 28
        Me.UltraGroupBox14.Visible = False
        '
        'txtComisionTotal
        '
        Me.txtComisionTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtComisionTotal.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtComisionTotal.InputMask = "{double:15.2}"
        Me.txtComisionTotal.Location = New System.Drawing.Point(9, 68)
        Me.txtComisionTotal.Name = "txtComisionTotal"
        Me.txtComisionTotal.NonAutoSizeHeight = 20
        Me.txtComisionTotal.ReadOnly = True
        Me.txtComisionTotal.Size = New System.Drawing.Size(98, 20)
        Me.txtComisionTotal.TabIndex = 3
        Me.txtComisionTotal.Text = "0.00"
        '
        'txtFleteTotal
        '
        Me.txtFleteTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFleteTotal.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtFleteTotal.InputMask = "{double:15.2}"
        Me.txtFleteTotal.Location = New System.Drawing.Point(9, 35)
        Me.txtFleteTotal.Name = "txtFleteTotal"
        Me.txtFleteTotal.NonAutoSizeHeight = 20
        Me.txtFleteTotal.ReadOnly = True
        Me.txtFleteTotal.Size = New System.Drawing.Size(98, 20)
        Me.txtFleteTotal.TabIndex = 1
        Me.txtFleteTotal.Text = "0.00"
        '
        'UltraLabel22
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Appearance87.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance87
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(7, 55)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel22.TabIndex = 2
        Me.UltraLabel22.Text = "Comision T: "
        '
        'UltraLabel23
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Appearance88.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance88
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(9, 22)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel23.TabIndex = 0
        Me.UltraLabel23.Text = "Flete Total: "
        '
        'UltraLabel32
        '
        Appearance89.BackColor = System.Drawing.Color.Transparent
        Appearance89.ForeColor = System.Drawing.Color.Navy
        Appearance89.TextVAlignAsString = "Middle"
        Me.UltraLabel32.Appearance = Appearance89
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Location = New System.Drawing.Point(111, 21)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel32.TabIndex = 4
        Me.UltraLabel32.Text = "Moneda:"
        '
        'NroDemanda
        '
        Me.NroDemanda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NroDemanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NroDemanda.Location = New System.Drawing.Point(380, 3)
        Me.NroDemanda.MaskInput = "nnnnn"
        Me.NroDemanda.MaxValue = 10000
        Me.NroDemanda.MinValue = 1
        Me.NroDemanda.Name = "NroDemanda"
        Me.NroDemanda.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.NroDemanda.Size = New System.Drawing.Size(60, 21)
        Me.NroDemanda.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NroDemanda.TabIndex = 3
        Me.NroDemanda.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI
        Me.NroDemanda.Value = 1
        '
        'cboDestino
        '
        Me.cboDestino.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboDestino.DisplayMember = "Destino"
        Me.cboDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestino.Location = New System.Drawing.Point(69, 102)
        Me.cboDestino.Name = "cboDestino"
        Me.cboDestino.Size = New System.Drawing.Size(371, 21)
        Me.cboDestino.TabIndex = 16
        Me.cboDestino.ValueMember = "IdDestino"
        '
        'cboEscala
        '
        Me.cboEscala.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboEscala.DisplayMember = "Nombre"
        Me.cboEscala.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEscala.Enabled = False
        Me.cboEscala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEscala.Location = New System.Drawing.Point(531, 53)
        Me.cboEscala.Name = "cboEscala"
        Me.cboEscala.Size = New System.Drawing.Size(300, 21)
        Me.cboEscala.TabIndex = 25
        Me.cboEscala.ValueMember = "Id"
        '
        'cboOrigen
        '
        Me.cboOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboOrigen.DisplayMember = "Nombre"
        Me.cboOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigen.Location = New System.Drawing.Point(69, 78)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(371, 21)
        Me.cboOrigen.TabIndex = 14
        Me.cboOrigen.ValueMember = "Id"
        '
        'cboTipoVehiculo
        '
        Me.cboTipoVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoVehiculo.DisplayMember = "Nombre"
        Me.cboTipoVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(531, 29)
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(200, 21)
        Me.cboTipoVehiculo.TabIndex = 23
        Me.cboTipoVehiculo.ValueMember = "Id"
        '
        'numNroUnidades
        '
        Me.numNroUnidades.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numNroUnidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numNroUnidades.Location = New System.Drawing.Point(531, 3)
        Me.numNroUnidades.MaskInput = "nnnnn"
        Me.numNroUnidades.MaxValue = 10000
        Me.numNroUnidades.MinValue = 1
        Me.numNroUnidades.Name = "numNroUnidades"
        Me.numNroUnidades.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numNroUnidades.Size = New System.Drawing.Size(60, 21)
        Me.numNroUnidades.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numNroUnidades.TabIndex = 20
        Me.numNroUnidades.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI
        Me.numNroUnidades.Value = 1
        '
        'txtMotivoEscala
        '
        Me.txtMotivoEscala.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMotivoEscala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoEscala.Location = New System.Drawing.Point(459, 77)
        Me.txtMotivoEscala.MaxLength = 500
        Me.txtMotivoEscala.Multiline = True
        Me.txtMotivoEscala.Name = "txtMotivoEscala"
        Me.txtMotivoEscala.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoEscala.Size = New System.Drawing.Size(372, 21)
        Me.txtMotivoEscala.TabIndex = 26
        Me.txtMotivoEscala.Visible = False
        '
        'chkEscala
        '
        Appearance90.FontData.BoldAsString = "False"
        Appearance90.ForeColor = System.Drawing.Color.Navy
        Me.chkEscala.Appearance = Appearance90
        Me.chkEscala.AutoSize = True
        Me.chkEscala.Location = New System.Drawing.Point(471, 54)
        Me.chkEscala.Name = "chkEscala"
        Me.chkEscala.Size = New System.Drawing.Size(58, 17)
        Me.chkEscala.TabIndex = 24
        Me.chkEscala.Text = "Escala:"
        '
        'UltraLabel2
        '
        Appearance91.BackColor = System.Drawing.Color.Transparent
        Appearance91.ForeColor = System.Drawing.Color.Navy
        Appearance91.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance91
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(456, 7)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(77, 14)
        Me.UltraLabel2.TabIndex = 19
        Me.UltraLabel2.Text = "Nro Unidades:"
        '
        'UltraLabel4
        '
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Appearance92.ForeColor = System.Drawing.Color.Navy
        Appearance92.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance92
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(22, 55)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel4.TabIndex = 7
        Me.UltraLabel4.Text = "F.Atenc:"
        '
        'UltraLabel16
        '
        Appearance93.BackColor = System.Drawing.Color.Transparent
        Appearance93.ForeColor = System.Drawing.Color.Navy
        Appearance93.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance93
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(20, 106)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel16.TabIndex = 15
        Me.UltraLabel16.Text = "Destino:"
        '
        'dtFechaAtencion
        '
        Me.dtFechaAtencion.DateTime = New Date(2015, 3, 17, 0, 0, 0, 0)
        Me.dtFechaAtencion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.dtFechaAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaAtencion.Location = New System.Drawing.Point(68, 52)
        Me.dtFechaAtencion.MaskInput = ""
        Me.dtFechaAtencion.Name = "dtFechaAtencion"
        Me.dtFechaAtencion.Size = New System.Drawing.Size(80, 21)
        Me.dtFechaAtencion.TabIndex = 8
        Me.dtFechaAtencion.Value = New Date(2015, 3, 17, 0, 0, 0, 0)
        '
        'UltraLabel11
        '
        Appearance94.BackColor = System.Drawing.Color.Transparent
        Appearance94.ForeColor = System.Drawing.Color.Navy
        Appearance94.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance94
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(25, 82)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel11.TabIndex = 13
        Me.UltraLabel11.Text = "Origen:"
        '
        'UltraLabel9
        '
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Appearance95.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance95
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(9, 32)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(57, 14)
        Me.UltraLabel9.TabIndex = 4
        Me.UltraLabel9.Text = "F. Solicita:"
        '
        'dtSolicita
        '
        Me.dtSolicita.DateTime = New Date(2015, 3, 17, 0, 0, 0, 0)
        Me.dtSolicita.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.dtSolicita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtSolicita.Location = New System.Drawing.Point(69, 28)
        Me.dtSolicita.MaskInput = ""
        Me.dtSolicita.Name = "dtSolicita"
        Me.dtSolicita.Size = New System.Drawing.Size(80, 21)
        Me.dtSolicita.TabIndex = 5
        Me.dtSolicita.Value = New Date(2015, 3, 17, 0, 0, 0, 0)
        '
        'UltraLabel5
        '
        Appearance96.BackColor = System.Drawing.Color.Transparent
        Appearance96.ForeColor = System.Drawing.Color.Navy
        Appearance96.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance96
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(24, 7)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel5.TabIndex = 0
        Me.UltraLabel5.Text = "Codigo:"
        '
        'txtNumero
        '
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(69, 3)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(120, 21)
        Me.txtNumero.TabIndex = 1
        '
        'txtObservacion
        '
        Me.txtObservacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(68, 126)
        Me.txtObservacion.MaxLength = 500
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(763, 21)
        Me.txtObservacion.TabIndex = 18
        UltraToolTipInfo4.ToolTipText = "Ingrese observacion"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtObservacion, UltraToolTipInfo4)
        '
        'UltraLabel8
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Appearance97.ForeColor = System.Drawing.Color.Navy
        Appearance97.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance97
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(455, 33)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel8.TabIndex = 22
        Me.UltraLabel8.Text = "Tipo Vehículo:"
        '
        'exgruConsultas
        '
        Me.exgruConsultas.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Appearance98.BackColor = System.Drawing.Color.White
        Appearance98.BackColor2 = System.Drawing.Color.White
        Me.exgruConsultas.ContentAreaAppearance = Appearance98
        Me.exgruConsultas.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.exgruConsultas.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruConsultas.Expanded = False
        Me.exgruConsultas.ExpandedSize = New System.Drawing.Size(1346, 26)
        Me.exgruConsultas.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exgruConsultas.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.exgruConsultas.Location = New System.Drawing.Point(0, 0)
        Me.exgruConsultas.Name = "exgruConsultas"
        Me.exgruConsultas.Size = New System.Drawing.Size(1346, 26)
        Me.exgruConsultas.TabIndex = 0
        Me.exgruConsultas.Text = "Consultas Pre Demanda / Disponibilidad"
        Me.exgruConsultas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ficConsultas)
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1340, 3)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel2.Visible = False
        '
        'ficConsultas
        '
        Me.ficConsultas.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficConsultas.Controls.Add(Me.UltraTabPageControl1)
        Me.ficConsultas.Controls.Add(Me.UltraTabPageControl2)
        Me.ficConsultas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficConsultas.Location = New System.Drawing.Point(0, 0)
        Me.ficConsultas.Name = "ficConsultas"
        Me.ficConsultas.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficConsultas.Size = New System.Drawing.Size(1340, 3)
        Me.ficConsultas.TabIndex = 0
        UltraTab5.TabPage = Me.UltraTabPageControl1
        UltraTab5.Text = "Pre Demanda"
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "Disponibilidad Trabajador / Vehiculos"
        Me.ficConsultas.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        Me.ficConsultas.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1336, 0)
        '
        'ogdListaDemanda
        '
        UltraDataColumn145.DataType = GetType(Decimal)
        UltraDataColumn150.DataType = GetType(Decimal)
        UltraDataColumn152.DataType = GetType(Decimal)
        UltraDataColumn153.DataType = GetType(Boolean)
        UltraDataColumn154.DataType = GetType(Boolean)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155})
        UltraDataBand2.Columns.AddRange(New Object() {UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163})
        Me.ogdListaDemanda.Band.ChildBands.AddRange(New Object() {UltraDataBand1, UltraDataBand2})
        UltraDataColumn169.DataType = GetType(Date)
        UltraDataColumn170.DataType = GetType(Decimal)
        UltraDataColumn171.DataType = GetType(Decimal)
        Me.ogdListaDemanda.Band.Columns.AddRange(New Object() {UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172, UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179})
        '
        'MenuDetalleTercero
        '
        Me.MenuDetalleTercero.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalleTercero.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarContratoTercero})
        Me.MenuDetalleTercero.Name = "mnu_Transferencias"
        Me.MenuDetalleTercero.Size = New System.Drawing.Size(153, 30)
        '
        'EliminarContratoTercero
        '
        Me.EliminarContratoTercero.Image = CType(resources.GetObject("EliminarContratoTercero.Image"), System.Drawing.Image)
        Me.EliminarContratoTercero.Name = "EliminarContratoTercero"
        Me.EliminarContratoTercero.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.EliminarContratoTercero.Size = New System.Drawing.Size(152, 26)
        Me.EliminarContratoTercero.Text = "Quitar"
        '
        'ogdVehiculoEstadoSituacional
        '
        Me.ogdVehiculoEstadoSituacional.Band.Columns.AddRange(New Object() {UltraDataColumn180, UltraDataColumn181, UltraDataColumn182, UltraDataColumn183, UltraDataColumn184, UltraDataColumn185, UltraDataColumn186, UltraDataColumn187, UltraDataColumn188, UltraDataColumn189, UltraDataColumn190, UltraDataColumn191, UltraDataColumn192, UltraDataColumn193, UltraDataColumn194})
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label39.Location = New System.Drawing.Point(43, 8)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(410, 17)
        Me.Label39.TabIndex = 391
        Me.Label39.Text = "Espere un momento mientras sincroniza la información."
        '
        'Label37
        '
        Me.Label37.Image = CType(resources.GetObject("Label37.Image"), System.Drawing.Image)
        Me.Label37.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label37.Location = New System.Drawing.Point(10, 8)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(24, 18)
        Me.Label37.TabIndex = 392
        '
        'ficDemanda
        '
        Me.ficDemanda.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDemanda.Controls.Add(Me.UltraTabPageControl7)
        Me.ficDemanda.Controls.Add(Me.utpDetalle)
        Me.ficDemanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDemanda.Location = New System.Drawing.Point(0, 0)
        Me.ficDemanda.Name = "ficDemanda"
        Me.ficDemanda.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDemanda.Size = New System.Drawing.Size(1348, 661)
        Me.ficDemanda.TabIndex = 0
        UltraTab3.Key = "Lista"
        UltraTab3.TabPage = Me.UltraTabPageControl7
        UltraTab3.Text = "Lista"
        UltraTab4.Key = "Mantenimiento"
        UltraTab4.TabPage = Me.utpDetalle
        UltraTab4.Text = "Mantenimiento"
        Me.ficDemanda.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.ficDemanda.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1346, 638)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(478, 298)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(393, 65)
        Me.ugb_Espera.TabIndex = 25
        Me.ugb_Espera.Visible = False
        '
        'frm_Demanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 661)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficDemanda)
        Me.Name = "frm_Demanda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido Carga"
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaRegistro.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.ogdDemandaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruFlete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruFlete.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel11.ResumeLayout(False)
        CType(Me.griTarifasProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdTarifasProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.txtGlosaCostoEstibaDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCostoEstivaDescarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivoConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIGVConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCostoEstiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIndFalsoFlete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verValidaFU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verFacturado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalFleteUnitarioIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIncluyeIgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalFleteUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.opPagoCont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verDescarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verPagoContraEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruDetalle.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.txtTelfDescarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelfCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContactoDescarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContactoCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDireccionLlegada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDireccionPartida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreComisonista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoPaternoComisionista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoComisionista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDestinoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrigenDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucComisionista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucCLienteFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucCLiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClienteFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboComisionista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.griDetalleTercero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDetalleTercero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.PerformLayout()
        CType(Me.chkIndPlantilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaternoContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoPaternoContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucEmpresaTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTercero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacionTercero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferenciaTercero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonedaT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griDemandaRapida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDemandaRapida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.PerformLayout()
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox7.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.PerformLayout()
        CType(Me.numDiasAntes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPorVencer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVencidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboZonaPreDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        CType(Me.griDisponibleVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDisponibleVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel8.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel10.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel10.PerformLayout()
        CType(Me.cboZonaDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.ColorParihueleroD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPlataformaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion20M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTolvaVolteoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion65M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorContenedorD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorGraneleroD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFurgonD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFurgonLargoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamionetaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVolqueteD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion30M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCaliceraD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCamion40M3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorMediaBarandaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruDisponibleNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruDisponibleNo.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        CType(Me.ColorAdvertencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAyudante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCopiloto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.tabDemandaCargas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDemandaCargas.ResumeLayout(False)
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.chkExcluirDemandas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTercerizadoFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verViajeRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        Me.UltraGroupBox13.PerformLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.ColorAprobada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCancelada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerAsignada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorParcial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAsignada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorGenerada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.tabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabs.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox9.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel9.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel9.PerformLayout()
        CType(Me.chkTercerizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udtHoraSolicita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udtHoraAtencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udtHoraRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox14.ResumeLayout(False)
        Me.UltraGroupBox14.PerformLayout()
        CType(Me.NroDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNroUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivoEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaAtencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSolicita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruConsultas.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.ficConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficConsultas.ResumeLayout(False)
        CType(Me.ogdListaDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalleTercero.ResumeLayout(False)
        CType(Me.ogdVehiculoEstadoSituacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDemanda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ogdDemandaDetalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuDuplicar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ogdListaDemanda As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ficDemanda As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ficConsultas As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ogdDemandaRapida As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griDemandaRapida As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents ColorAsignada As ISL.Controles.Colores
    Friend WithEvents ColorGenerada As ISL.Controles.Colores
    Friend WithEvents etiDemandaGenerada As ISL.Controles.Etiqueta
    Friend WithEvents ColorParcial As ISL.Controles.Colores
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtTotalComisionLista As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtTotalFlotaLista As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents exgruDetalle As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Shadows WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents Insert As System.Windows.Forms.ToolStripMenuItem
    Shadows WithEvents Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramarViaje As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerAsignada As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboUsuario As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel62 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel8 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents cboZonaDisponibles As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel59 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnConsultarDisponibles As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraExpandableGroupBox3 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents cboZonaPreDemanda As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnConsultaPreDemanda As Infragistics.Win.Misc.UltraButton
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents ogdVehiculoEstadoSituacional As ISL.Controles.OrigenDatos
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents UltraExpandableGroupBox7 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel7 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents numDiasAntes As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents ColorPorVencer As ISL.Controles.Colores
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents ColorVencidas As ISL.Controles.Colores
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents ogdDisponibleVehiculos As ISL.Controles.OrigenDatos
    Friend WithEvents griDisponibleVehiculo As ISL.Controles.Grilla
    Friend WithEvents exgruDisponibleNo As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox4 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel10 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents ColorParihueleroD As ISL.Controles.Colores
    Friend WithEvents ColorPlataformaD As ISL.Controles.Colores
    Friend WithEvents ColorCamion20M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTolvaVolteoD As ISL.Controles.Colores
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion65M3D As ISL.Controles.Colores
    Friend WithEvents ColorContenedorD As ISL.Controles.Colores
    Friend WithEvents Etiqueta222 As ISL.Controles.Etiqueta
    Friend WithEvents ColorGraneleroD As ISL.Controles.Colores
    Friend WithEvents ColorFurgonD As ISL.Controles.Colores
    Friend WithEvents ColorFurgonLargoD As ISL.Controles.Colores
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamionetaD As ISL.Controles.Colores
    Friend WithEvents ColorVolqueteD As ISL.Controles.Colores
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion30M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCaliceraD As ISL.Controles.Colores
    Friend WithEvents ColorCamion40M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents ColorMediaBarandaD As ISL.Controles.Colores
    Friend WithEvents ColorAdvertencia As ISL.Controles.Colores
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents ColorPiloto As ISL.Controles.Colores
    Friend WithEvents ColorAyudante As ISL.Controles.Colores
    Friend WithEvents ColorCarreta As ISL.Controles.Colores
    Friend WithEvents ColorTracto As ISL.Controles.Colores
    Friend WithEvents ColorCopiloto As ISL.Controles.Colores
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents lblListoRegistro As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents colorCambio As ISL.Controles.Colores
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCancelada As ISL.Controles.Colores
    Friend WithEvents EstadoAsignada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents cboMonedaT As ISL.Controles.Combo
    Friend WithEvents btnAgregarTerc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numFleteUnitarioTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel33 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numComisionTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel34 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel35 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numFleteTotalTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents numIgvTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents MenuDetalleTercero As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarContratoTercero As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents verViajeRetorno As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtReferenciaTercero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel43 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numSubTotalTercero As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel67 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtObservacionTercero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents numCantidadTercero As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel66 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdDetalleTercero As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griDetalleTercero As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents exgruConsultas As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents tabs As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox9 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel9 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents cboDestino As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboEscala As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboOrigen As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboTipoVehiculo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents numNroUnidades As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtMotivoEscala As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkEscala As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtFechaAtencion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtSolicita As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNumero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtObservacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtApellidoMaterno As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNombreComisonista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtApellidoPaternoComisionista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTelefonoComisionista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboDestinoDetalle As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboOrigenDetalle As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRucComisionista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtRucCLienteFinal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtRucCLiente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboMaterial As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboTipoCarga As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboClienteFinal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboComisionista As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCantidad As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblClienteFinal As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents exgruFlete As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel11 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtCostoEstiba As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents chkCostoEstiva As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkIGVConsolidado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtMotivoConsolidado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtConsolidado As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents chkConsolidado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CalFleteUnitario As ISL.Controles.NumeroCalculadora
    Friend WithEvents txtFleteTotalDetalle As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents verCargar As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verDescarga As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verPagoContraEntrega As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verIncluyeIgv As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CalFleteUnitarioIGV As ISL.Controles.NumeroCalculadora
    Friend WithEvents UltraGroupBox14 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents txtComisionTotal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtFleteTotal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verFacturado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtComision As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verValidaFU As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel37 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblNumeroDemanda As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents NroDemanda As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtSubtotal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents lblSubtotal As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cboDireccionPartida As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboDireccionLlegada As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents griDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtAdelantoFlete As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CancelarDemanda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCostoEstibaDescarga As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents chkCostoEstivaDescarga As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents ColorAprobada As ISL.Controles.Colores
    Friend WithEvents EnviarCorreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboContacto As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboTercero As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents tabDemandaCargas As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griLista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griFactura As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtRucEmpresaTransportista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtFechaRecepcion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents opPagoCont As ISL.Controles.Opciones
    Friend WithEvents udtHoraSolicita As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udtHoraAtencion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udtHoraRecepcion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtRucContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkTercerizacion As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtGlosaCostoEstibaDesc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTelefonoContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtApellidoMaternoContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNombreContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtApellidoPaternoContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents griTarifasProveedor As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ogdTarifasProveedor As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chkTercerizadoFiltro As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkIndFalsoFlete As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkExcluirDemandas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents RevertirDemandaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarDetalleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoDetalleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraLabel36 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboContactoDescarga As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboContactoCarga As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel38 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel40 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTelfDescarga As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTelfCarga As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkIndPlantilla As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ugb_Espera As Espere
End Class
