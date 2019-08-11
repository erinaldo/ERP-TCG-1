<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DemandaRapida
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
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAtendida")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdComisionista")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuario")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Justificacion")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoPredemanda")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitIGV")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSolicita")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRecepcion")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalComision")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoEscala")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCancelacion")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEnvioCorreo")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorTercero")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 2")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala", 0)
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 0")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 1")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 2")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 3")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 2", 0)
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 0")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 1")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 2")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 3")
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 0")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 1")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 2")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 3")
        Dim UltraDataBand2 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 0")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 1")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 2")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 3")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAtendida")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdComisionista")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuario")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Justificacion")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoPredemanda")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitIGV")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaSolicita")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaRecepcion")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subtotal")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalComision")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MotivoEscala")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCancelacion")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Indicador")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEnvioCorreo")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorTercero")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DemandaRapida))
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcularIgv")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcularSinIgv")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteFinal")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion", 0)
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCarga")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcularIgv")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcularSinIgv")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteFinal")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionLugarLlegada", 0)
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionLugarPartida", 1)
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador", 2)
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIGVConsolidado", 3)
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado", 4)
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoConsolidado", 5)
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstiba", 6)
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionOrigen", 7)
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionDestino", 8)
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 9)
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionLugarPartida", 10)
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionLugarLlegada", 11)
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoCarga", 12)
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteFinal", 13)
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material", 14)
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente", 15)
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargar", 16)
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descarga", 17)
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete", 18)
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstibaDescarga", 19)
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoEfectivoDeposito", 20)
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario", 21)
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Programado", 22)
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorProgramar", 23)
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FalsoFlete", 24)
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContactoCarga", 25)
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContactoDescarga", 26)
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBonificacion")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe", 0)
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material", 1)
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente", 2)
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor", 3)
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lugar", 4)
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FlujoCaja", 5)
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor", 6)
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar", 7)
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja", 8)
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial", 9)
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo", 10)
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigencia", 11)
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion", 12)
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente", 13)
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(335)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1038)
        Dim ColScrollRegion3 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-1045)
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo6 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Tarifas Proveedor", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo7 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Comentario de Consolidado", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo8 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Comentario de Consolidado", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo9 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Modificar Flete Unitario", Infragistics.Win.ToolTipImage.[Default], "Valida Flete Unitario", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim CalculatorButton1 As Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton = New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton(15)
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim CalculatorButton2 As Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton = New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton(15)
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton6 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarCliente")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton7 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoCliente")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton8 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarCliente")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton9 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoCliente")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo10 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Telefono", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo11 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("RUC Cliente", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim EditorButton10 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarClienteFinal")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton11 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarComisionista")
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton12 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoComisionista")
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton13 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarCliente")
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton14 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoCliente")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo12 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccione Cliente", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionDetalle")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContacto")
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoFlete")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoComision")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndOperacion")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditar")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Telefono", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarCliente")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoCliente")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Observaciones del Contrato de Terceros", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Refencia del Punto de Llegada ", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
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
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo4 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Comentario de Escala", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo5 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Ingrese observacion", Infragistics.Win.ToolTipImage.[Default], "", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griLista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarDemanda = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevertirDemandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramarViajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdLista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griFactura = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarDetalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoDetalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exgruFlete = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griTarifasProveedor = New ISL.Controles.Grilla(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtGlosaCostoEstibaDesc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chkConsolidado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtCostoEstibaDescarga = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtConsolidado = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.chkCostoEstivaDescarga = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtMotivoConsolidado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCostoEstiba = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.chkCostoEstiva = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkIGVConsolidado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.chkIndFalsoFlete = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel37 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtAdelantoFlete = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.verValidaFU = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtSubtotal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtComision = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblSubtotal = New Infragistics.Win.Misc.UltraLabel()
        Me.verFacturado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.CalFleteUnitarioIGV = New ISL.Controles.NumeroCalculadora(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.verIncluyeIgv = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtFleteTotalDetalle = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.CalFleteUnitario = New ISL.Controles.NumeroCalculadora(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.opPagoCont = New ISL.Controles.Opciones(Me.components)
        Me.verCargar = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verDescarga = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verPagoContraEntrega = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.exgruDetalle = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel40 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtTelfDescarga = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtTelfCarga = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboContactoDescarga = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboContactoCarga = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel38 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboDireccionLLegada = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboDireccionPartida = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtApellidoMaterno = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGroupBox14 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtComisionTotal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtFleteTotal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNombreComisonista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtApellidoPaternoComisionista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtTelefonoComisionista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboDestinoDetalle = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboOrigenDetalle = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
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
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetalleTercero = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.chkIndPlantilla = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboTercero = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txtTelefonoContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtApellidoMaternoContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNombreContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtApellidoPaternoContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtRucContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtRucEmpresaTransportista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboContacto = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.btnAgregarTecero = New Infragistics.Win.Misc.UltraButton()
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
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.numFleteUnitarioTerc = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel33 = New Infragistics.Win.Misc.UltraLabel()
        Me.numComisionTerc = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel34 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel35 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabDemandaCargas = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.chkExcluirDemandas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkTercerizadoFiltro = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verViajeRetorno = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboUsuario = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel62 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.numDiasAntes = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorPorVencer = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorVencidas = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.VerAsignada = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.colorCambio = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorCancelada = New ISL.Controles.Colores(Me.components)
        Me.etiCancelada = New ISL.Controles.Etiqueta(Me.components)
        Me.colorAsignada = New ISL.Controles.Colores(Me.components)
        Me.colorGenerada = New ISL.Controles.Colores(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabs = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExpandableGroupBox9 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel9 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.chkTercerizacion = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.udtHoraSolicita = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udtHoraAtencion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udtHoraRecepcion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtFechaRecepcion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.cboDestino = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboEscala = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboOrigen = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboTipoVehiculo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.numNroUnidades = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.lblNumeroDemanda = New Infragistics.Win.Misc.UltraLabel()
        Me.NroDemanda = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtMotivoEscala = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chkEscala = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtFechaAtencion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtSolicita = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNumero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtObservacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.ficDemanda = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaRegistro.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.ogdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        CType(Me.exgruFlete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruFlete.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.griTarifasProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.txtGlosaCostoEstibaDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCostoEstivaDescarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivoConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCostoEstiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIGVConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.txtTelfDescarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelfCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContactoDescarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContactoCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDireccionLLegada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDireccionPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox14.SuspendLayout()
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
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox6.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout()
        CType(Me.chkIndPlantilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTercero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaternoContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoPaternoContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucEmpresaTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacionTercero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferenciaTercero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonedaT, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.cboUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.numDiasAntes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorPorVencer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorVencidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.VerAsignada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCancelada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAsignada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorGenerada, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.cboDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNroUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NroDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivoEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaAtencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSolicita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDemanda.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.agrListaRegistro)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1344, 486)
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.ugb_Espera)
        Me.agrListaRegistro.Controls.Add(Me.griLista)
        Me.agrListaRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaRegistro.Location = New System.Drawing.Point(0, 0)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(1344, 486)
        Me.agrListaRegistro.TabIndex = 1
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.Text = "Lista Registro"
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(432, 102)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 68)
        Me.ugb_Espera.TabIndex = 23
        Me.ugb_Espera.Visible = False
        '
        'griLista
        '
        Me.griLista.AllowDrop = True
        Me.griLista.ContextMenuStrip = Me.Menu
        Me.griLista.DataSource = Me.ogdLista
        UltraGridColumn1.Header.Caption = "Select"
        UltraGridColumn1.Header.VisiblePosition = 33
        UltraGridColumn1.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.Width = 90
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 210
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 20
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn12.Width = 228
        UltraGridColumn13.Header.VisiblePosition = 29
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn14.Width = 111
        UltraGridColumn15.Header.VisiblePosition = 32
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 30
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 31
        UltraGridColumn17.Hidden = True
        Appearance1.Image = "edit.png"
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn18.CellAppearance = Appearance1
        Appearance2.Image = "Grabar.ico"
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn18.CellButtonAppearance = Appearance2
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn18.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn18.Header.VisiblePosition = 22
        UltraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn18.Width = 239
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Width = 85
        UltraGridColumn20.Header.VisiblePosition = 34
        UltraGridColumn20.Hidden = True
        UltraGridColumn20.Width = 150
        UltraGridColumn21.Header.VisiblePosition = 25
        UltraGridColumn22.Header.VisiblePosition = 8
        UltraGridColumn23.Header.VisiblePosition = 13
        UltraGridColumn24.Header.VisiblePosition = 14
        UltraGridColumn25.Header.VisiblePosition = 16
        UltraGridColumn26.Header.Caption = "Fecha Solicitada"
        UltraGridColumn26.Header.VisiblePosition = 3
        UltraGridColumn46.Header.VisiblePosition = 6
        UltraGridColumn48.Header.VisiblePosition = 18
        UltraGridColumn49.Header.VisiblePosition = 17
        UltraGridColumn51.Header.VisiblePosition = 19
        UltraGridColumn52.Header.VisiblePosition = 21
        UltraGridColumn53.Header.VisiblePosition = 23
        UltraGridColumn54.Header.VisiblePosition = 24
        UltraGridColumn55.Header.VisiblePosition = 26
        UltraGridColumn56.Header.Caption = "EnvioCorreo"
        UltraGridColumn56.Header.VisiblePosition = 28
        UltraGridColumn57.Header.VisiblePosition = 11
        UltraGridColumn58.Header.VisiblePosition = 27
        UltraGridColumn60.Header.VisiblePosition = 37
        UltraGridColumn61.Header.VisiblePosition = 36
        UltraGridColumn80.Header.VisiblePosition = 35
        UltraGridColumn80.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn46, UltraGridColumn48, UltraGridColumn49, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn60, UltraGridColumn61, UltraGridColumn80})
        UltraGridBand1.SummaryFooterCaption = "Totales:"
        UltraGridColumn62.Header.VisiblePosition = 0
        UltraGridColumn65.Header.VisiblePosition = 1
        UltraGridColumn72.Header.VisiblePosition = 2
        UltraGridColumn75.Header.VisiblePosition = 3
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn62, UltraGridColumn65, UltraGridColumn72, UltraGridColumn75})
        UltraGridColumn76.Header.VisiblePosition = 0
        UltraGridColumn77.Header.VisiblePosition = 1
        UltraGridColumn78.Header.VisiblePosition = 2
        UltraGridColumn79.Header.VisiblePosition = 3
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79})
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
        Me.griLista.Size = New System.Drawing.Size(1340, 466)
        Me.griLista.TabIndex = 0
        Me.griLista.Tag = ""
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Insert, Me.Update, Me.Delete, Me.GenerarDemanda, Me.CancelarToolStripMenuItem, Me.EnviarCorreoToolStripMenuItem, Me.RevertirDemandaToolStripMenuItem, Me.ProgramarViajeToolStripMenuItem})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(162, 180)
        '
        'Insert
        '
        Me.Insert.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(161, 22)
        Me.Insert.Text = "Nuevo"
        Me.Insert.ToolTipText = "Insertar una nueva Pre-Demanda"
        '
        'Update
        '
        Me.Update.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(161, 22)
        Me.Update.Text = "Actualizar"
        Me.Update.ToolTipText = "Actualizar o modificar la Pre-Demanda seleccionada"
        '
        'Delete
        '
        Me.Delete.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(161, 22)
        Me.Delete.Text = "Eliminar"
        Me.Delete.ToolTipText = "Eliminar la Pre-Demanda seleccionada"
        '
        'GenerarDemanda
        '
        Me.GenerarDemanda.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.GenerarDemanda.Name = "GenerarDemanda"
        Me.GenerarDemanda.Size = New System.Drawing.Size(161, 22)
        Me.GenerarDemanda.Text = "Generar Demanda"
        Me.GenerarDemanda.ToolTipText = "GenerarDemanda de la Pre-Demanda seleccionada"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'EnviarCorreoToolStripMenuItem
        '
        Me.EnviarCorreoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.send_email
        Me.EnviarCorreoToolStripMenuItem.Name = "EnviarCorreoToolStripMenuItem"
        Me.EnviarCorreoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.EnviarCorreoToolStripMenuItem.Text = "Enviar Correo"
        '
        'RevertirDemandaToolStripMenuItem
        '
        Me.RevertirDemandaToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.back
        Me.RevertirDemandaToolStripMenuItem.Name = "RevertirDemandaToolStripMenuItem"
        Me.RevertirDemandaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.RevertirDemandaToolStripMenuItem.Text = "Revertir Demanda"
        '
        'ProgramarViajeToolStripMenuItem
        '
        Me.ProgramarViajeToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.ProgramarViajeToolStripMenuItem.Name = "ProgramarViajeToolStripMenuItem"
        Me.ProgramarViajeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ProgramarViajeToolStripMenuItem.Text = "Programar Viaje"
        '
        'ogdLista
        '
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        UltraDataBand2.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        Me.ogdLista.Band.ChildBands.AddRange(New Object() {UltraDataBand1, UltraDataBand2})
        UltraDataColumn12.DataType = GetType(Date)
        UltraDataColumn21.DataType = GetType(Boolean)
        Me.ogdLista.Band.Columns.AddRange(New Object() {UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43})
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
        Me.imagenes.Images.SetKeyName(12, "save.jpg")
        Me.imagenes.Images.SetKeyName(13, "Grabar.ico")
        Me.imagenes.Images.SetKeyName(14, "Editar.ico")
        Me.imagenes.Images.SetKeyName(15, "edit.png")
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griFactura)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1344, 486)
        '
        'griFactura
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Me.griFactura.DisplayLayout.Appearance = Appearance3
        UltraGridColumn99.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn99.Header.VisiblePosition = 1
        UltraGridColumn99.Hidden = True
        UltraGridColumn175.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn175.Header.VisiblePosition = 0
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn176.Header.VisiblePosition = 2
        UltraGridColumn176.Width = 250
        UltraGridColumn177.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn177.Header.Enabled = False
        UltraGridColumn177.Header.VisiblePosition = 3
        UltraGridColumn177.Width = 100
        UltraGridColumn178.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance4.BackColor = System.Drawing.Color.PaleTurquoise
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn178.CellAppearance = Appearance4
        UltraGridColumn178.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn178.Header.Caption = "Cant."
        UltraGridColumn178.Header.VisiblePosition = 4
        UltraGridColumn178.MaskInput = "{double:5.3}"
        UltraGridColumn178.Width = 60
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn179.CellAppearance = Appearance5
        UltraGridColumn179.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn179.Format = "#,##0.0000"
        UltraGridColumn179.Header.Caption = "F.Unitario"
        UltraGridColumn179.Header.Enabled = False
        UltraGridColumn179.Header.VisiblePosition = 5
        UltraGridColumn179.MaskInput = "{LOC}nn,nnn.nnnn"
        UltraGridColumn179.Width = 78
        UltraGridColumn180.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn180.Header.Caption = "Fact."
        UltraGridColumn180.Header.VisiblePosition = 6
        UltraGridColumn180.Width = 27
        UltraGridColumn181.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn181.Header.Caption = "Cont.Ent."
        UltraGridColumn181.Header.VisiblePosition = 7
        UltraGridColumn181.Width = 48
        UltraGridColumn182.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn182.Header.VisiblePosition = 8
        UltraGridColumn182.Width = 100
        UltraGridColumn183.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn183.CellAppearance = Appearance6
        UltraGridColumn183.Header.VisiblePosition = 9
        UltraGridColumn183.Width = 50
        UltraGridColumn184.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance7.BackColor = System.Drawing.Color.LemonChiffon
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn184.CellAppearance = Appearance7
        UltraGridColumn184.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn184.Format = "#,###,##0.000"
        UltraGridColumn184.Header.VisiblePosition = 11
        UltraGridColumn184.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn184.Width = 80
        UltraGridColumn185.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn185.Header.VisiblePosition = 12
        UltraGridColumn185.Width = 200
        UltraGridColumn186.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.BackColor = System.Drawing.Color.LemonChiffon
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn186.CellAppearance = Appearance8
        UltraGridColumn186.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn186.Format = "#,##0.00"
        UltraGridColumn186.Header.VisiblePosition = 13
        UltraGridColumn186.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn186.Width = 60
        UltraGridColumn187.Header.VisiblePosition = 14
        UltraGridColumn187.Hidden = True
        UltraGridColumn188.Header.VisiblePosition = 15
        UltraGridColumn188.Hidden = True
        UltraGridColumn189.Header.VisiblePosition = 16
        UltraGridColumn189.Hidden = True
        UltraGridColumn190.Header.VisiblePosition = 17
        UltraGridColumn190.Hidden = True
        UltraGridColumn191.Header.VisiblePosition = 18
        UltraGridColumn191.Width = 100
        UltraGridColumn192.Header.VisiblePosition = 19
        UltraGridColumn192.Width = 100
        UltraGridColumn193.Header.VisiblePosition = 20
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.Caption = "I. Igv"
        UltraGridColumn194.Header.VisiblePosition = 10
        UltraGridColumn194.Width = 28
        UltraGridColumn195.Header.VisiblePosition = 21
        UltraGridColumn195.Width = 200
        UltraGridColumn196.Header.VisiblePosition = 22
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn99, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196})
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
        Appearance9.TextVAlignAsString = "Middle"
        Me.griFactura.DisplayLayout.Override.RowAppearance = Appearance9
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
        Me.griFactura.Size = New System.Drawing.Size(1344, 486)
        Me.griFactura.TabIndex = 2
        Me.griFactura.Tag = ""
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.griDetalle)
        Me.UltraTabPageControl8.Controls.Add(Me.exgruFlete)
        Me.UltraTabPageControl8.Controls.Add(Me.exgruDetalle)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1342, 405)
        '
        'griDetalle
        '
        Me.griDetalle.ContextMenuStrip = Me.MenuDetalle
        Appearance10.BackColor = System.Drawing.Color.White
        Me.griDetalle.DisplayLayout.Appearance = Appearance10
        UltraGridColumn197.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn197.Header.VisiblePosition = 1
        UltraGridColumn197.Hidden = True
        UltraGridColumn198.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn198.Header.VisiblePosition = 0
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn199.Header.Enabled = False
        UltraGridColumn199.Header.VisiblePosition = 2
        UltraGridColumn199.Width = 250
        UltraGridColumn200.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn200.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn200.Header.VisiblePosition = 3
        UltraGridColumn200.Width = 100
        UltraGridColumn201.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance11.BackColor = System.Drawing.Color.PaleTurquoise
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn201.CellAppearance = Appearance11
        UltraGridColumn201.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn201.Header.Caption = "Cant."
        UltraGridColumn201.Header.VisiblePosition = 5
        UltraGridColumn201.MaskInput = "{double:5.3}"
        UltraGridColumn201.Width = 44
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn202.CellAppearance = Appearance12
        UltraGridColumn202.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn202.Format = "#,##0.000"
        UltraGridColumn202.Header.Caption = "F.Unitario"
        UltraGridColumn202.Header.Enabled = False
        UltraGridColumn202.Header.VisiblePosition = 6
        UltraGridColumn202.MaskInput = "{LOC}nn,nnn.nnnn"
        UltraGridColumn202.Width = 78
        UltraGridColumn203.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn203.Header.Caption = "Fact."
        UltraGridColumn203.Header.VisiblePosition = 13
        UltraGridColumn203.Width = 40
        UltraGridColumn204.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn204.Header.Caption = "Cont.Ent."
        UltraGridColumn204.Header.VisiblePosition = 16
        UltraGridColumn204.Width = 40
        UltraGridColumn205.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn205.Header.Caption = "Material"
        UltraGridColumn205.Header.VisiblePosition = 4
        UltraGridColumn205.Width = 84
        UltraGridColumn206.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn206.CellAppearance = Appearance13
        UltraGridColumn206.Header.VisiblePosition = 18
        UltraGridColumn206.Width = 38
        UltraGridColumn207.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance14.BackColor = System.Drawing.Color.Gold
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn207.CellAppearance = Appearance14
        UltraGridColumn207.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn207.Format = "#,###,##0.000"
        UltraGridColumn207.Header.VisiblePosition = 9
        UltraGridColumn207.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn207.Width = 54
        UltraGridColumn208.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn208.Header.VisiblePosition = 21
        UltraGridColumn208.Width = 200
        UltraGridColumn209.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance15.BackColor = System.Drawing.Color.Goldenrod
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn209.CellAppearance = Appearance15
        UltraGridColumn209.Format = "#,##0.00"
        UltraGridColumn209.Header.VisiblePosition = 20
        UltraGridColumn209.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn209.Width = 48
        UltraGridColumn210.Header.VisiblePosition = 23
        UltraGridColumn210.Hidden = True
        UltraGridColumn211.Header.VisiblePosition = 24
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.VisiblePosition = 25
        UltraGridColumn212.Hidden = True
        UltraGridColumn213.Header.VisiblePosition = 26
        UltraGridColumn213.Hidden = True
        UltraGridColumn214.Header.Enabled = False
        UltraGridColumn214.Header.VisiblePosition = 27
        UltraGridColumn214.Hidden = True
        UltraGridColumn214.Width = 100
        UltraGridColumn215.Header.VisiblePosition = 28
        UltraGridColumn215.Hidden = True
        UltraGridColumn215.Width = 100
        UltraGridColumn216.Header.VisiblePosition = 29
        UltraGridColumn216.Hidden = True
        UltraGridColumn217.Header.Caption = "I. Igv"
        UltraGridColumn217.Header.VisiblePosition = 19
        UltraGridColumn217.Width = 40
        UltraGridColumn218.Header.Caption = "Cliente Final"
        UltraGridColumn218.Header.VisiblePosition = 30
        UltraGridColumn218.Hidden = True
        UltraGridColumn218.Width = 200
        UltraGridColumn219.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn219.Header.Caption = "Dir.Llegada"
        UltraGridColumn219.Header.Enabled = False
        UltraGridColumn219.Header.VisiblePosition = 36
        UltraGridColumn219.Hidden = True
        UltraGridColumn219.Width = 234
        UltraGridColumn220.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn220.Header.Caption = "Dir.Partida"
        UltraGridColumn220.Header.Enabled = False
        UltraGridColumn220.Header.VisiblePosition = 35
        UltraGridColumn220.Hidden = True
        UltraGridColumn220.Width = 229
        UltraGridColumn221.Header.VisiblePosition = 37
        UltraGridColumn221.Hidden = True
        UltraGridColumn222.Header.Caption = "I.C.IGV"
        UltraGridColumn222.Header.VisiblePosition = 31
        UltraGridColumn222.Width = 40
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn223.CellAppearance = Appearance16
        UltraGridColumn223.Format = "#,##0.000"
        UltraGridColumn223.Header.VisiblePosition = 22
        UltraGridColumn223.Width = 70
        UltraGridColumn224.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn224.Header.Caption = "Motivo Consolidado"
        UltraGridColumn224.Header.VisiblePosition = 32
        UltraGridColumn224.Width = 110
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn225.CellAppearance = Appearance17
        UltraGridColumn225.Format = "#,##0.000"
        UltraGridColumn225.Header.Caption = "C.Estiba"
        UltraGridColumn225.Header.VisiblePosition = 11
        UltraGridColumn225.MaskInput = "{LOC}nn,nnn.nnnn"
        UltraGridColumn225.Width = 67
        UltraGridColumn226.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn226.Header.Caption = "Origen"
        UltraGridColumn226.Header.Enabled = False
        UltraGridColumn226.Header.VisiblePosition = 33
        UltraGridColumn226.Width = 184
        UltraGridColumn227.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn227.Header.Caption = "Destino"
        UltraGridColumn227.Header.Enabled = False
        UltraGridColumn227.Header.VisiblePosition = 34
        UltraGridColumn227.Width = 177
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn228.CellAppearance = Appearance18
        UltraGridColumn228.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn228.Format = "#,###,##0.000"
        UltraGridColumn228.Header.VisiblePosition = 8
        UltraGridColumn228.Width = 59
        UltraGridColumn229.Header.VisiblePosition = 38
        UltraGridColumn230.Header.VisiblePosition = 39
        UltraGridColumn231.Header.VisiblePosition = 40
        UltraGridColumn231.Hidden = True
        UltraGridColumn232.Header.Caption = "Cliente Final"
        UltraGridColumn232.Header.VisiblePosition = 41
        UltraGridColumn233.Header.VisiblePosition = 42
        UltraGridColumn233.Hidden = True
        UltraGridColumn234.Header.VisiblePosition = 43
        UltraGridColumn234.Hidden = True
        UltraGridColumn235.Header.VisiblePosition = 14
        UltraGridColumn235.Width = 40
        UltraGridColumn236.Header.VisiblePosition = 15
        UltraGridColumn236.Width = 40
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn237.CellAppearance = Appearance19
        UltraGridColumn237.Format = "#,###,##0.000"
        UltraGridColumn237.Header.Caption = "Adelanto Flete"
        UltraGridColumn237.Header.VisiblePosition = 10
        UltraGridColumn237.MaskInput = "{LOC}nn,nnn.nnnn"
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn238.CellAppearance = Appearance20
        UltraGridColumn238.Format = "#,###,##0.000"
        UltraGridColumn238.Header.Caption = "C.Estiba Desc"
        UltraGridColumn238.Header.VisiblePosition = 12
        UltraGridColumn238.MaskInput = "{LOC}nn,nnn.nnnn"
        UltraGridColumn238.Width = 69
        UltraGridColumn239.Header.Caption = "Tipo PC."
        UltraGridColumn239.Header.VisiblePosition = 17
        UltraGridColumn239.Width = 51
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn240.CellAppearance = Appearance21
        UltraGridColumn240.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn240.Format = "#,##0.0000"
        UltraGridColumn240.Header.Caption = "F.Unit IGV"
        UltraGridColumn240.Header.VisiblePosition = 7
        UltraGridColumn241.Header.VisiblePosition = 44
        UltraGridColumn241.Hidden = True
        UltraGridColumn242.Header.VisiblePosition = 45
        UltraGridColumn242.Hidden = True
        UltraGridColumn243.Header.VisiblePosition = 46
        UltraGridColumn243.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn244.Header.Caption = "Contacto Carga"
        UltraGridColumn244.Header.VisiblePosition = 47
        UltraGridColumn245.Header.Caption = "Contacto Descarga"
        UltraGridColumn245.Header.VisiblePosition = 48
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245})
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
        Me.griDetalle.Location = New System.Drawing.Point(0, 292)
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(1342, 113)
        Me.griDetalle.TabIndex = 2
        Me.griDetalle.Tag = ""
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEliminar, Me.EditarDetalleToolStripMenuItem, Me.NuevoDetalleToolStripMenuItem})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(153, 82)
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Image = CType(resources.GetObject("mnuEliminar.Image"), System.Drawing.Image)
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEliminar.Size = New System.Drawing.Size(152, 26)
        Me.mnuEliminar.Text = "Quitar"
        '
        'EditarDetalleToolStripMenuItem
        '
        Me.EditarDetalleToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarDetalleToolStripMenuItem.Name = "EditarDetalleToolStripMenuItem"
        Me.EditarDetalleToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.EditarDetalleToolStripMenuItem.Text = "Editar Detalle"
        '
        'NuevoDetalleToolStripMenuItem
        '
        Me.NuevoDetalleToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.NuevoDetalleToolStripMenuItem.Name = "NuevoDetalleToolStripMenuItem"
        Me.NuevoDetalleToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.NuevoDetalleToolStripMenuItem.Text = "Nuevo Detalle"
        '
        'exgruFlete
        '
        Me.exgruFlete.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Appearance23.BackColor = System.Drawing.Color.White
        Appearance23.BackColor2 = System.Drawing.Color.White
        Me.exgruFlete.ContentAreaAppearance = Appearance23
        Me.exgruFlete.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.exgruFlete.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruFlete.ExpandedSize = New System.Drawing.Size(1342, 128)
        Me.exgruFlete.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.exgruFlete.Location = New System.Drawing.Point(0, 164)
        Me.exgruFlete.Name = "exgruFlete"
        Me.exgruFlete.Size = New System.Drawing.Size(1342, 128)
        Me.exgruFlete.TabIndex = 1
        Me.exgruFlete.Text = "Flete"
        Me.exgruFlete.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.griTarifasProveedor)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraGroupBox2)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraGroupBox1)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Agrupacion6)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(1336, 105)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'griTarifasProveedor
        '
        Appearance24.BackColor = System.Drawing.Color.White
        Me.griTarifasProveedor.DisplayLayout.Appearance = Appearance24
        UltraGridColumn246.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn246.Header.VisiblePosition = 0
        UltraGridColumn246.Hidden = True
        UltraGridColumn247.Header.VisiblePosition = 1
        UltraGridColumn247.Hidden = True
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn248.CellAppearance = Appearance25
        UltraGridColumn248.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn248.Header.Appearance = Appearance26
        UltraGridColumn248.Header.VisiblePosition = 2
        UltraGridColumn248.Hidden = True
        UltraGridColumn248.MaskInput = "nnnnnnn"
        UltraGridColumn248.Width = 40
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn249.CellAppearance = Appearance27
        UltraGridColumn249.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn249.Header.Caption = "%"
        UltraGridColumn249.Header.VisiblePosition = 3
        UltraGridColumn249.Hidden = True
        UltraGridColumn249.MaskInput = "nn"
        UltraGridColumn249.Width = 20
        UltraGridColumn250.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn250.Header.Caption = "Bof."
        UltraGridColumn250.Header.VisiblePosition = 4
        UltraGridColumn250.Hidden = True
        UltraGridColumn250.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn250.Width = 30
        UltraGridColumn251.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn251.Header.VisiblePosition = 5
        UltraGridColumn251.Hidden = True
        UltraGridColumn251.Width = 250
        UltraGridColumn252.Header.VisiblePosition = 6
        UltraGridColumn252.Hidden = True
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn253.CellAppearance = Appearance28
        UltraGridColumn253.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn253.Format = "###,##0.000"
        UltraGridColumn253.Header.VisiblePosition = 7
        UltraGridColumn253.Width = 40
        UltraGridColumn254.Format = ""
        UltraGridColumn254.Header.VisiblePosition = 8
        UltraGridColumn254.Width = 93
        UltraGridColumn255.Header.VisiblePosition = 9
        UltraGridColumn256.Header.VisiblePosition = 10
        UltraGridColumn257.Header.VisiblePosition = 11
        UltraGridColumn258.Header.VisiblePosition = 12
        UltraGridColumn258.Hidden = True
        UltraGridColumn259.Header.VisiblePosition = 13
        UltraGridColumn259.Hidden = True
        UltraGridColumn260.Header.VisiblePosition = 14
        UltraGridColumn260.Hidden = True
        UltraGridColumn261.Header.VisiblePosition = 15
        UltraGridColumn261.Hidden = True
        UltraGridColumn262.Header.VisiblePosition = 16
        UltraGridColumn262.Hidden = True
        UltraGridColumn263.Header.VisiblePosition = 17
        UltraGridColumn263.Hidden = True
        UltraGridColumn264.Header.VisiblePosition = 18
        UltraGridColumn264.Hidden = True
        UltraGridColumn265.Header.VisiblePosition = 19
        UltraGridColumn265.Hidden = True
        UltraGridColumn266.Header.VisiblePosition = 20
        UltraGridColumn266.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn246, UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266})
        Me.griTarifasProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griTarifasProveedor.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.griTarifasProveedor.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.griTarifasProveedor.DisplayLayout.ColScrollRegions.Add(ColScrollRegion3)
        Me.griTarifasProveedor.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griTarifasProveedor.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griTarifasProveedor.DisplayLayout.GroupByBox.Hidden = True
        Me.griTarifasProveedor.DisplayLayout.MaxColScrollRegions = 1
        Me.griTarifasProveedor.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifasProveedor.DisplayLayout.Override.CellPadding = 0
        Appearance29.TextHAlignAsString = "Left"
        Me.griTarifasProveedor.DisplayLayout.Override.HeaderAppearance = Appearance29
        Me.griTarifasProveedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTarifasProveedor.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance30.TextVAlignAsString = "Middle"
        Me.griTarifasProveedor.DisplayLayout.Override.RowAppearance = Appearance30
        Me.griTarifasProveedor.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTarifasProveedor.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTarifasProveedor.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTarifasProveedor.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.Horizontal
        Me.griTarifasProveedor.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTarifasProveedor.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTarifasProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTarifasProveedor.Location = New System.Drawing.Point(893, 1)
        Me.griTarifasProveedor.Name = "griTarifasProveedor"
        Me.griTarifasProveedor.Size = New System.Drawing.Size(344, 102)
        Me.griTarifasProveedor.TabIndex = 3
        Me.griTarifasProveedor.Tag = ""
        UltraToolTipInfo6.ToolTipText = "Tarifas Proveedor"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.griTarifasProveedor, UltraToolTipInfo6)
        Me.griTarifasProveedor.Visible = False
        '
        'UltraGroupBox2
        '
        Appearance92.BackColor = System.Drawing.Color.White
        Appearance92.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance92
        Me.UltraGroupBox2.Controls.Add(Me.txtGlosaCostoEstibaDesc)
        Me.UltraGroupBox2.Controls.Add(Me.chkConsolidado)
        Me.UltraGroupBox2.Controls.Add(Me.txtCostoEstibaDescarga)
        Me.UltraGroupBox2.Controls.Add(Me.txtConsolidado)
        Me.UltraGroupBox2.Controls.Add(Me.chkCostoEstivaDescarga)
        Me.UltraGroupBox2.Controls.Add(Me.txtMotivoConsolidado)
        Me.UltraGroupBox2.Controls.Add(Me.txtCostoEstiba)
        Me.UltraGroupBox2.Controls.Add(Me.chkCostoEstiva)
        Me.UltraGroupBox2.Controls.Add(Me.chkIGVConsolidado)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(583, 1)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(304, 102)
        Me.UltraGroupBox2.TabIndex = 2
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtGlosaCostoEstibaDesc
        '
        Me.txtGlosaCostoEstibaDesc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaCostoEstibaDesc.Location = New System.Drawing.Point(6, 75)
        Me.txtGlosaCostoEstibaDesc.MaxLength = 500
        Me.txtGlosaCostoEstibaDesc.Multiline = True
        Me.txtGlosaCostoEstibaDesc.Name = "txtGlosaCostoEstibaDesc"
        Me.txtGlosaCostoEstibaDesc.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosaCostoEstibaDesc.Size = New System.Drawing.Size(292, 23)
        Me.txtGlosaCostoEstibaDesc.TabIndex = 8
        UltraToolTipInfo7.ToolTipText = "Comentario de Consolidado"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtGlosaCostoEstibaDesc, UltraToolTipInfo7)
        Me.txtGlosaCostoEstibaDesc.Visible = False
        '
        'chkConsolidado
        '
        Appearance93.ForeColor = System.Drawing.Color.Navy
        Me.chkConsolidado.Appearance = Appearance93
        Me.chkConsolidado.AutoSize = True
        Me.chkConsolidado.Location = New System.Drawing.Point(6, 6)
        Me.chkConsolidado.Name = "chkConsolidado"
        Me.chkConsolidado.Size = New System.Drawing.Size(84, 18)
        Me.chkConsolidado.TabIndex = 0
        Me.chkConsolidado.Text = "Consolidado"
        '
        'txtCostoEstibaDescarga
        '
        Me.txtCostoEstibaDescarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCostoEstibaDescarga.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCostoEstibaDescarga.Enabled = False
        Me.txtCostoEstibaDescarga.InputMask = "{double:15.2}"
        Me.txtCostoEstibaDescarga.Location = New System.Drawing.Point(233, 51)
        Me.txtCostoEstibaDescarga.Name = "txtCostoEstibaDescarga"
        Me.txtCostoEstibaDescarga.NonAutoSizeHeight = 20
        Me.txtCostoEstibaDescarga.Size = New System.Drawing.Size(65, 21)
        Me.txtCostoEstibaDescarga.TabIndex = 7
        Me.txtCostoEstibaDescarga.Text = "0.00"
        '
        'txtConsolidado
        '
        Me.txtConsolidado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtConsolidado.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtConsolidado.InputMask = "{double:15.2}"
        Me.txtConsolidado.Location = New System.Drawing.Point(90, 5)
        Me.txtConsolidado.Name = "txtConsolidado"
        Me.txtConsolidado.NonAutoSizeHeight = 20
        Me.txtConsolidado.Size = New System.Drawing.Size(112, 21)
        Me.txtConsolidado.TabIndex = 1
        Me.txtConsolidado.Text = "0.00"
        '
        'chkCostoEstivaDescarga
        '
        Appearance94.ForeColor = System.Drawing.Color.Navy
        Me.chkCostoEstivaDescarga.Appearance = Appearance94
        Me.chkCostoEstivaDescarga.AutoSize = True
        Me.chkCostoEstivaDescarga.Location = New System.Drawing.Point(142, 53)
        Me.chkCostoEstivaDescarga.Name = "chkCostoEstivaDescarga"
        Me.chkCostoEstivaDescarga.Size = New System.Drawing.Size(90, 18)
        Me.chkCostoEstivaDescarga.TabIndex = 6
        Me.chkCostoEstivaDescarga.Text = "C.EstibaDesc"
        '
        'txtMotivoConsolidado
        '
        Me.txtMotivoConsolidado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMotivoConsolidado.Location = New System.Drawing.Point(6, 30)
        Me.txtMotivoConsolidado.MaxLength = 500
        Me.txtMotivoConsolidado.Multiline = True
        Me.txtMotivoConsolidado.Name = "txtMotivoConsolidado"
        Me.txtMotivoConsolidado.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoConsolidado.Size = New System.Drawing.Size(292, 17)
        Me.txtMotivoConsolidado.TabIndex = 3
        UltraToolTipInfo8.ToolTipText = "Comentario de Consolidado"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtMotivoConsolidado, UltraToolTipInfo8)
        Me.txtMotivoConsolidado.Visible = False
        '
        'txtCostoEstiba
        '
        Me.txtCostoEstiba.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCostoEstiba.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCostoEstiba.Enabled = False
        Me.txtCostoEstiba.InputMask = "{double:15.2}"
        Me.txtCostoEstiba.Location = New System.Drawing.Point(71, 52)
        Me.txtCostoEstiba.Name = "txtCostoEstiba"
        Me.txtCostoEstiba.NonAutoSizeHeight = 20
        Me.txtCostoEstiba.Size = New System.Drawing.Size(65, 21)
        Me.txtCostoEstiba.TabIndex = 5
        Me.txtCostoEstiba.Text = "0.00"
        '
        'chkCostoEstiva
        '
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Me.chkCostoEstiva.Appearance = Appearance95
        Me.chkCostoEstiva.AutoSize = True
        Me.chkCostoEstiva.Location = New System.Drawing.Point(5, 54)
        Me.chkCostoEstiva.Name = "chkCostoEstiva"
        Me.chkCostoEstiva.Size = New System.Drawing.Size(64, 18)
        Me.chkCostoEstiva.TabIndex = 4
        Me.chkCostoEstiva.Text = "C.Estiba"
        '
        'chkIGVConsolidado
        '
        Appearance96.ForeColor = System.Drawing.Color.Navy
        Me.chkIGVConsolidado.Appearance = Appearance96
        Me.chkIGVConsolidado.AutoSize = True
        Me.chkIGVConsolidado.Enabled = False
        Me.chkIGVConsolidado.Location = New System.Drawing.Point(206, 6)
        Me.chkIGVConsolidado.Name = "chkIGVConsolidado"
        Me.chkIGVConsolidado.Size = New System.Drawing.Size(80, 18)
        Me.chkIGVConsolidado.TabIndex = 2
        Me.chkIGVConsolidado.Text = "Incluye IGV"
        '
        'UltraGroupBox1
        '
        Appearance97.BackColor = System.Drawing.Color.White
        Appearance97.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance97
        Me.UltraGroupBox1.Controls.Add(Me.cboMoneda)
        Me.UltraGroupBox1.Controls.Add(Me.chkIndFalsoFlete)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel26)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel37)
        Me.UltraGroupBox1.Controls.Add(Me.txtAdelantoFlete)
        Me.UltraGroupBox1.Controls.Add(Me.verValidaFU)
        Me.UltraGroupBox1.Controls.Add(Me.btnAgregar)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel21)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel18)
        Me.UltraGroupBox1.Controls.Add(Me.txtSubtotal)
        Me.UltraGroupBox1.Controls.Add(Me.txtComision)
        Me.UltraGroupBox1.Controls.Add(Me.lblSubtotal)
        Me.UltraGroupBox1.Controls.Add(Me.verFacturado)
        Me.UltraGroupBox1.Controls.Add(Me.CalFleteUnitarioIGV)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox1.Controls.Add(Me.verIncluyeIgv)
        Me.UltraGroupBox1.Controls.Add(Me.txtFleteTotalDetalle)
        Me.UltraGroupBox1.Controls.Add(Me.CalFleteUnitario)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(447, 102)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboMoneda
        '
        Appearance98.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance98
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(13, 55)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(35, 21)
        Me.cboMoneda.TabIndex = 4
        Me.cboMoneda.ValueMember = "Id"
        '
        'chkIndFalsoFlete
        '
        Appearance99.ForeColor = System.Drawing.Color.Navy
        Me.chkIndFalsoFlete.Appearance = Appearance99
        Me.chkIndFalsoFlete.AutoSize = True
        Me.chkIndFalsoFlete.Location = New System.Drawing.Point(294, 78)
        Me.chkIndFalsoFlete.Name = "chkIndFalsoFlete"
        Me.chkIndFalsoFlete.Size = New System.Drawing.Size(77, 18)
        Me.chkIndFalsoFlete.TabIndex = 16
        Me.chkIndFalsoFlete.Text = "Falso Flete"
        '
        'UltraLabel26
        '
        Appearance100.BackColor = System.Drawing.Color.Transparent
        Appearance100.ForeColor = System.Drawing.Color.Navy
        Appearance100.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance100
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Location = New System.Drawing.Point(12, 11)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(102, 15)
        Me.UltraLabel26.TabIndex = 0
        Me.UltraLabel26.Text = "Flete Uni (Sin IGV): "
        '
        'UltraLabel37
        '
        Appearance101.BackColor = System.Drawing.Color.Transparent
        Appearance101.ForeColor = System.Drawing.Color.Navy
        Appearance101.TextVAlignAsString = "Middle"
        Me.UltraLabel37.Appearance = Appearance101
        Me.UltraLabel37.AutoSize = True
        Me.UltraLabel37.Location = New System.Drawing.Point(308, 35)
        Me.UltraLabel37.Name = "UltraLabel37"
        Me.UltraLabel37.Size = New System.Drawing.Size(53, 15)
        Me.UltraLabel37.TabIndex = 12
        Me.UltraLabel37.Text = "Comisión: "
        '
        'txtAdelantoFlete
        '
        Appearance102.TextHAlignAsString = "Right"
        Me.txtAdelantoFlete.Appearance = Appearance102
        Me.txtAdelantoFlete.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAdelantoFlete.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtAdelantoFlete.InputMask = "{double:10.4}"
        Me.txtAdelantoFlete.Location = New System.Drawing.Point(366, 8)
        Me.txtAdelantoFlete.Name = "txtAdelantoFlete"
        Me.txtAdelantoFlete.NonAutoSizeHeight = 20
        Me.txtAdelantoFlete.NullText = "0.00"
        Me.txtAdelantoFlete.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtAdelantoFlete.Size = New System.Drawing.Size(78, 21)
        Me.txtAdelantoFlete.TabIndex = 11
        Me.txtAdelantoFlete.Text = "0.0000"
        '
        'verValidaFU
        '
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Me.verValidaFU.Appearance = Appearance103
        Me.verValidaFU.AutoSize = True
        Me.verValidaFU.Checked = True
        Me.verValidaFU.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verValidaFU.Location = New System.Drawing.Point(230, 9)
        Me.verValidaFU.Name = "verValidaFU"
        Me.verValidaFU.Size = New System.Drawing.Size(14, 13)
        Me.verValidaFU.TabIndex = 9
        UltraToolTipInfo9.ToolTipText = "Modificar Flete Unitario"
        UltraToolTipInfo9.ToolTipTitle = "Valida Flete Unitario"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.verValidaFU, UltraToolTipInfo9)
        '
        'btnAgregar
        '
        Appearance104.BorderColor = System.Drawing.Color.White
        Appearance104.Image = CType(resources.GetObject("Appearance104.Image"), Object)
        Me.btnAgregar.Appearance = Appearance104
        Me.btnAgregar.ImageList = Me.imagenes
        Me.btnAgregar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(402, 63)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(38, 36)
        Me.btnAgregar.TabIndex = 17
        '
        'UltraLabel21
        '
        Appearance105.BackColor = System.Drawing.Color.Transparent
        Appearance105.ForeColor = System.Drawing.Color.Navy
        Appearance105.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance105
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(289, 12)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(76, 15)
        Me.UltraLabel21.TabIndex = 10
        Me.UltraLabel21.Text = "AdelantoFlete: "
        '
        'UltraLabel18
        '
        Appearance106.BackColor = System.Drawing.Color.Transparent
        Appearance106.ForeColor = System.Drawing.Color.Navy
        Appearance106.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance106
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(8, 34)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(106, 15)
        Me.UltraLabel18.TabIndex = 2
        Me.UltraLabel18.Text = "Flete Uni (Con IGV): "
        '
        'txtSubtotal
        '
        Appearance107.TextHAlignAsString = "Right"
        Me.txtSubtotal.Appearance = Appearance107
        Me.txtSubtotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSubtotal.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtSubtotal.InputMask = "{double:10.4}"
        Me.txtSubtotal.Location = New System.Drawing.Point(112, 54)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.NonAutoSizeHeight = 20
        Me.txtSubtotal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(110, 21)
        Me.txtSubtotal.TabIndex = 6
        Me.txtSubtotal.Text = "0.0000"
        '
        'txtComision
        '
        Appearance108.TextHAlignAsString = "Right"
        Me.txtComision.Appearance = Appearance108
        Me.txtComision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtComision.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtComision.Enabled = False
        Me.txtComision.InputMask = "{double:10.4}"
        Me.txtComision.Location = New System.Drawing.Point(366, 31)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.NonAutoSizeHeight = 20
        Me.txtComision.NullText = "0.00"
        Me.txtComision.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtComision.Size = New System.Drawing.Size(78, 21)
        Me.txtComision.TabIndex = 13
        Me.txtComision.Text = "0.0000"
        '
        'lblSubtotal
        '
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Appearance109.TextVAlignAsString = "Middle"
        Me.lblSubtotal.Appearance = Appearance109
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(65, 57)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 15)
        Me.lblSubtotal.TabIndex = 5
        Me.lblSubtotal.Text = "Subtotal: "
        '
        'verFacturado
        '
        Appearance110.ForeColor = System.Drawing.Color.Navy
        Me.verFacturado.Appearance = Appearance110
        Me.verFacturado.Checked = True
        Me.verFacturado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verFacturado.Location = New System.Drawing.Point(294, 57)
        Me.verFacturado.Name = "verFacturado"
        Me.verFacturado.Size = New System.Drawing.Size(75, 20)
        Me.verFacturado.TabIndex = 14
        Me.verFacturado.Text = "Facturado"
        '
        'CalFleteUnitarioIGV
        '
        Appearance111.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance111.TextHAlignAsString = "Right"
        Me.CalFleteUnitarioIGV.Appearance = Appearance111
        Me.CalFleteUnitarioIGV.AutoSize = False
        CalculatorButton1.Key = "."
        CalculatorButton1.KeyCodeAlternateValue = 190
        CalculatorButton1.KeyCodeValue = 110
        CalculatorButton1.Text = ","
        Me.CalFleteUnitarioIGV.Buttons.AddRange(New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton() {CalculatorButton1})
        Appearance112.Image = CType(resources.GetObject("Appearance112.Image"), Object)
        EditorButton4.Appearance = Appearance112
        Me.CalFleteUnitarioIGV.ButtonsLeft.Add(EditorButton4)
        Me.CalFleteUnitarioIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CalFleteUnitarioIGV.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CalFleteUnitarioIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalFleteUnitarioIGV.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CalFleteUnitarioIGV.ImageList = Me.imagenes
        Me.CalFleteUnitarioIGV.Location = New System.Drawing.Point(112, 29)
        Me.CalFleteUnitarioIGV.Name = "CalFleteUnitarioIGV"
        Me.CalFleteUnitarioIGV.NullText = "0.00"
        Me.CalFleteUnitarioIGV.Size = New System.Drawing.Size(110, 20)
        Me.CalFleteUnitarioIGV.TabIndex = 3
        Me.CalFleteUnitarioIGV.Text = "0.000"
        '
        'UltraLabel7
        '
        Appearance113.BackColor = System.Drawing.Color.Transparent
        Appearance113.ForeColor = System.Drawing.Color.Navy
        Appearance113.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance113
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(51, 81)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel7.TabIndex = 7
        Me.UltraLabel7.Text = "Flete Total: "
        '
        'verIncluyeIgv
        '
        Appearance114.ForeColor = System.Drawing.Color.Navy
        Me.verIncluyeIgv.Appearance = Appearance114
        Me.verIncluyeIgv.AutoSize = True
        Me.verIncluyeIgv.Location = New System.Drawing.Point(226, 78)
        Me.verIncluyeIgv.Name = "verIncluyeIgv"
        Me.verIncluyeIgv.Size = New System.Drawing.Size(47, 18)
        Me.verIncluyeIgv.TabIndex = 15
        Me.verIncluyeIgv.Text = "I.IGV"
        '
        'txtFleteTotalDetalle
        '
        Appearance115.TextHAlignAsString = "Right"
        Me.txtFleteTotalDetalle.Appearance = Appearance115
        Me.txtFleteTotalDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFleteTotalDetalle.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtFleteTotalDetalle.InputMask = "{double:10.4}"
        Me.txtFleteTotalDetalle.Location = New System.Drawing.Point(112, 78)
        Me.txtFleteTotalDetalle.Name = "txtFleteTotalDetalle"
        Me.txtFleteTotalDetalle.NonAutoSizeHeight = 20
        Me.txtFleteTotalDetalle.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFleteTotalDetalle.ReadOnly = True
        Me.txtFleteTotalDetalle.Size = New System.Drawing.Size(110, 21)
        Me.txtFleteTotalDetalle.TabIndex = 8
        Me.txtFleteTotalDetalle.Text = "0.0000"
        '
        'CalFleteUnitario
        '
        Appearance116.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance116.TextHAlignAsString = "Right"
        Me.CalFleteUnitario.Appearance = Appearance116
        Me.CalFleteUnitario.AutoSize = False
        CalculatorButton2.Key = "."
        CalculatorButton2.KeyCodeAlternateValue = 190
        CalculatorButton2.KeyCodeValue = 110
        CalculatorButton2.Text = ","
        Me.CalFleteUnitario.Buttons.AddRange(New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton() {CalculatorButton2})
        Appearance117.Image = CType(resources.GetObject("Appearance117.Image"), Object)
        EditorButton5.Appearance = Appearance117
        Me.CalFleteUnitario.ButtonsLeft.Add(EditorButton5)
        Me.CalFleteUnitario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CalFleteUnitario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CalFleteUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalFleteUnitario.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CalFleteUnitario.ImageList = Me.imagenes
        Me.CalFleteUnitario.Location = New System.Drawing.Point(112, 7)
        Me.CalFleteUnitario.Name = "CalFleteUnitario"
        Me.CalFleteUnitario.NullText = "0.00"
        Me.CalFleteUnitario.Size = New System.Drawing.Size(110, 20)
        Me.CalFleteUnitario.TabIndex = 1
        Me.CalFleteUnitario.Text = "0.000"
        '
        'Agrupacion6
        '
        Appearance118.BackColor = System.Drawing.Color.White
        Appearance118.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion6.ContentAreaAppearance = Appearance118
        Me.Agrupacion6.Controls.Add(Me.opPagoCont)
        Me.Agrupacion6.Controls.Add(Me.verCargar)
        Me.Agrupacion6.Controls.Add(Me.verDescarga)
        Me.Agrupacion6.Controls.Add(Me.verPagoContraEntrega)
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion6.Location = New System.Drawing.Point(450, 2)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(132, 101)
        Me.Agrupacion6.TabIndex = 1
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'opPagoCont
        '
        Appearance119.ForeColor = System.Drawing.Color.Navy
        Me.opPagoCont.Appearance = Appearance119
        Me.opPagoCont.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opPagoCont.CheckedIndex = 0
        Me.opPagoCont.Enabled = False
        Me.opPagoCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opPagoCont.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "Efectivo"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "Deposito"
        ValueListItem3.DataValue = "ValueListItem2"
        ValueListItem3.DisplayText = "Otros"
        Me.opPagoCont.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.opPagoCont.Location = New System.Drawing.Point(24, 56)
        Me.opPagoCont.Name = "opPagoCont"
        Me.opPagoCont.Size = New System.Drawing.Size(72, 42)
        Me.opPagoCont.TabIndex = 0
        Me.opPagoCont.Text = "Efectivo"
        '
        'verCargar
        '
        Appearance120.ForeColor = System.Drawing.Color.Navy
        Me.verCargar.Appearance = Appearance120
        Me.verCargar.AutoSize = True
        Me.verCargar.Location = New System.Drawing.Point(6, 5)
        Me.verCargar.Name = "verCargar"
        Me.verCargar.Size = New System.Drawing.Size(56, 17)
        Me.verCargar.TabIndex = 1
        Me.verCargar.Text = "Cargar"
        '
        'verDescarga
        '
        Appearance121.ForeColor = System.Drawing.Color.Navy
        Me.verDescarga.Appearance = Appearance121
        Me.verDescarga.AutoSize = True
        Me.verDescarga.Location = New System.Drawing.Point(6, 22)
        Me.verDescarga.Name = "verDescarga"
        Me.verDescarga.Size = New System.Drawing.Size(70, 17)
        Me.verDescarga.TabIndex = 2
        Me.verDescarga.Text = "Descarga"
        '
        'verPagoContraEntrega
        '
        Appearance122.ForeColor = System.Drawing.Color.Navy
        Me.verPagoContraEntrega.Appearance = Appearance122
        Me.verPagoContraEntrega.AutoSize = True
        Me.verPagoContraEntrega.Location = New System.Drawing.Point(6, 40)
        Me.verPagoContraEntrega.Name = "verPagoContraEntrega"
        Me.verPagoContraEntrega.Size = New System.Drawing.Size(124, 17)
        Me.verPagoContraEntrega.TabIndex = 3
        Me.verPagoContraEntrega.Text = "Pago ContraEntrega"
        '
        'exgruDetalle
        '
        Me.exgruDetalle.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Appearance123.BackColor = System.Drawing.Color.White
        Appearance123.BackColor2 = System.Drawing.Color.White
        Me.exgruDetalle.ContentAreaAppearance = Appearance123
        Me.exgruDetalle.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.exgruDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruDetalle.ExpandedSize = New System.Drawing.Size(1342, 164)
        Me.exgruDetalle.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.exgruDetalle.Location = New System.Drawing.Point(0, 0)
        Me.exgruDetalle.Name = "exgruDetalle"
        Me.exgruDetalle.Size = New System.Drawing.Size(1342, 164)
        Me.exgruDetalle.TabIndex = 0
        Me.exgruDetalle.Text = "Datos"
        Me.exgruDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel41)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel40)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtTelfDescarga)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtTelfCarga)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboContactoDescarga)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboContactoCarga)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel38)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel39)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboDireccionLLegada)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboDireccionPartida)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtApellidoMaterno)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraGroupBox14)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtNombreComisonista)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtApellidoPaternoComisionista)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtTelefonoComisionista)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboDestinoDetalle)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboOrigenDetalle)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel5)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel13)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtRucComisionista)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtRucCLienteFinal)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtRucCLiente)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboMaterial)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboTipoCarga)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboClienteFinal)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboComisionista)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboCliente)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel19)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel17)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel12)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtCantidad)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel15)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.lblClienteFinal)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel25)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel20)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel24)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(1336, 141)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'UltraLabel41
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Appearance124.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance124
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Location = New System.Drawing.Point(245, 122)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(77, 15)
        Me.UltraLabel41.TabIndex = 13
        Me.UltraLabel41.Text = "Telf Descarga:"
        '
        'UltraLabel40
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Appearance125.TextVAlignAsString = "Middle"
        Me.UltraLabel40.Appearance = Appearance125
        Me.UltraLabel40.AutoSize = True
        Me.UltraLabel40.Location = New System.Drawing.Point(39, 121)
        Me.UltraLabel40.Name = "UltraLabel40"
        Me.UltraLabel40.Size = New System.Drawing.Size(60, 15)
        Me.UltraLabel40.TabIndex = 11
        Me.UltraLabel40.Text = "Telf Carga:"
        '
        'txtTelfDescarga
        '
        Me.txtTelfDescarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTelfDescarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelfDescarga.Location = New System.Drawing.Point(323, 117)
        Me.txtTelfDescarga.Name = "txtTelfDescarga"
        Me.txtTelfDescarga.ReadOnly = True
        Me.txtTelfDescarga.Size = New System.Drawing.Size(135, 21)
        Me.txtTelfDescarga.TabIndex = 14
        '
        'txtTelfCarga
        '
        Me.txtTelfCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTelfCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelfCarga.Location = New System.Drawing.Point(105, 117)
        Me.txtTelfCarga.Name = "txtTelfCarga"
        Me.txtTelfCarga.ReadOnly = True
        Me.txtTelfCarga.Size = New System.Drawing.Size(135, 21)
        Me.txtTelfCarga.TabIndex = 12
        '
        'cboContactoDescarga
        '
        Me.cboContactoDescarga.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboContactoDescarga.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Appearance126.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton6.Appearance = Appearance126
        EditorButton6.Key = "btnEditarCliente"
        Appearance127.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton7.Appearance = Appearance127
        EditorButton7.Key = "btnNuevoCliente"
        EditorButton7.Visible = False
        Me.cboContactoDescarga.ButtonsRight.Add(EditorButton6)
        Me.cboContactoDescarga.ButtonsRight.Add(EditorButton7)
        Me.cboContactoDescarga.DisplayMember = "Nombre"
        Me.cboContactoDescarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboContactoDescarga.Location = New System.Drawing.Point(105, 94)
        Me.cboContactoDescarga.Name = "cboContactoDescarga"
        Me.cboContactoDescarga.Size = New System.Drawing.Size(353, 22)
        Me.cboContactoDescarga.TabIndex = 10
        Me.cboContactoDescarga.ValueMember = "Id"
        '
        'cboContactoCarga
        '
        Me.cboContactoCarga.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboContactoCarga.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Appearance128.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton8.Appearance = Appearance128
        EditorButton8.Key = "btnEditarCliente"
        Appearance129.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton9.Appearance = Appearance129
        EditorButton9.Key = "btnNuevoCliente"
        EditorButton9.Visible = False
        Me.cboContactoCarga.ButtonsRight.Add(EditorButton8)
        Me.cboContactoCarga.ButtonsRight.Add(EditorButton9)
        Me.cboContactoCarga.DisplayMember = "Nombre"
        Me.cboContactoCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboContactoCarga.Location = New System.Drawing.Point(105, 71)
        Me.cboContactoCarga.Name = "cboContactoCarga"
        Me.cboContactoCarga.Size = New System.Drawing.Size(353, 22)
        Me.cboContactoCarga.TabIndex = 8
        Me.cboContactoCarga.ValueMember = "Id"
        '
        'UltraLabel38
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Appearance130.ForeColor = System.Drawing.Color.Navy
        Appearance130.TextVAlignAsString = "Middle"
        Me.UltraLabel38.Appearance = Appearance130
        Me.UltraLabel38.AutoSize = True
        Me.UltraLabel38.Location = New System.Drawing.Point(-2, 98)
        Me.UltraLabel38.Name = "UltraLabel38"
        Me.UltraLabel38.Size = New System.Drawing.Size(102, 15)
        Me.UltraLabel38.TabIndex = 9
        Me.UltraLabel38.Text = "Contacto Descarga:"
        '
        'UltraLabel39
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Appearance131.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance131
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Location = New System.Drawing.Point(17, 76)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(85, 15)
        Me.UltraLabel39.TabIndex = 7
        Me.UltraLabel39.Text = "Contacto Carga:"
        '
        'cboDireccionLLegada
        '
        Me.cboDireccionLLegada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDireccionLLegada.DisplayMember = "Nombre"
        Me.cboDireccionLLegada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDireccionLLegada.Location = New System.Drawing.Point(567, 24)
        Me.cboDireccionLLegada.Name = "cboDireccionLLegada"
        Me.cboDireccionLLegada.Size = New System.Drawing.Size(345, 23)
        Me.cboDireccionLLegada.TabIndex = 18
        Me.cboDireccionLLegada.ValueMember = "Id"
        '
        'cboDireccionPartida
        '
        Me.cboDireccionPartida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDireccionPartida.DisplayMember = "Nombre"
        Me.cboDireccionPartida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDireccionPartida.Location = New System.Drawing.Point(567, 1)
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
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(682, 95)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(115, 21)
        Me.txtApellidoMaterno.TabIndex = 26
        '
        'UltraGroupBox14
        '
        Me.UltraGroupBox14.Controls.Add(Me.txtComisionTotal)
        Me.UltraGroupBox14.Controls.Add(Me.txtFleteTotal)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel32)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox14.Location = New System.Drawing.Point(1016, 6)
        Me.UltraGroupBox14.Name = "UltraGroupBox14"
        Me.UltraGroupBox14.Size = New System.Drawing.Size(110, 94)
        Me.UltraGroupBox14.TabIndex = 35
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
        Me.txtComisionTotal.Size = New System.Drawing.Size(98, 21)
        Me.txtComisionTotal.TabIndex = 4
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
        Me.txtFleteTotal.Size = New System.Drawing.Size(98, 21)
        Me.txtFleteTotal.TabIndex = 2
        Me.txtFleteTotal.Text = "0.00"
        '
        'UltraLabel8
        '
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Appearance132.ForeColor = System.Drawing.Color.Navy
        Appearance132.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance132
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(7, 55)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(64, 15)
        Me.UltraLabel8.TabIndex = 3
        Me.UltraLabel8.Text = "Comision T: "
        '
        'UltraLabel32
        '
        Appearance133.BackColor = System.Drawing.Color.Transparent
        Appearance133.ForeColor = System.Drawing.Color.Navy
        Appearance133.TextVAlignAsString = "Middle"
        Me.UltraLabel32.Appearance = Appearance133
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Location = New System.Drawing.Point(21, 4)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel32.TabIndex = 0
        Me.UltraLabel32.Text = "Moneda:"
        '
        'UltraLabel14
        '
        Appearance134.BackColor = System.Drawing.Color.Transparent
        Appearance134.ForeColor = System.Drawing.Color.Navy
        Appearance134.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance134
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(9, 22)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel14.TabIndex = 1
        Me.UltraLabel14.Text = "Flete Total: "
        '
        'txtNombreComisonista
        '
        Me.txtNombreComisonista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombreComisonista.Enabled = False
        Me.txtNombreComisonista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreComisonista.Location = New System.Drawing.Point(797, 95)
        Me.txtNombreComisonista.Name = "txtNombreComisonista"
        Me.txtNombreComisonista.Size = New System.Drawing.Size(115, 21)
        Me.txtNombreComisonista.TabIndex = 27
        '
        'txtApellidoPaternoComisionista
        '
        Me.txtApellidoPaternoComisionista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoPaternoComisionista.Enabled = False
        Me.txtApellidoPaternoComisionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaternoComisionista.Location = New System.Drawing.Point(567, 95)
        Me.txtApellidoPaternoComisionista.Name = "txtApellidoPaternoComisionista"
        Me.txtApellidoPaternoComisionista.Size = New System.Drawing.Size(115, 21)
        Me.txtApellidoPaternoComisionista.TabIndex = 25
        '
        'txtTelefonoComisionista
        '
        Me.txtTelefonoComisionista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTelefonoComisionista.Enabled = False
        Me.txtTelefonoComisionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoComisionista.Location = New System.Drawing.Point(915, 95)
        Me.txtTelefonoComisionista.Name = "txtTelefonoComisionista"
        Me.txtTelefonoComisionista.Size = New System.Drawing.Size(106, 21)
        Me.txtTelefonoComisionista.TabIndex = 28
        UltraToolTipInfo10.ToolTipText = "Telefono"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtTelefonoComisionista, UltraToolTipInfo10)
        '
        'cboDestinoDetalle
        '
        Me.cboDestinoDetalle.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboDestinoDetalle.DisplayMember = "Nombre"
        Me.cboDestinoDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDestinoDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestinoDetalle.Location = New System.Drawing.Point(105, 25)
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
        Me.cboOrigenDetalle.Location = New System.Drawing.Point(105, 2)
        Me.cboOrigenDetalle.Name = "cboOrigenDetalle"
        Me.cboOrigenDetalle.Size = New System.Drawing.Size(353, 21)
        Me.cboOrigenDetalle.TabIndex = 1
        Me.cboOrigenDetalle.ValueMember = "Id"
        '
        'UltraLabel5
        '
        Appearance135.BackColor = System.Drawing.Color.Transparent
        Appearance135.ForeColor = System.Drawing.Color.Navy
        Appearance135.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance135
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(58, 30)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel5.TabIndex = 3
        Me.UltraLabel5.Text = "Destino:"
        '
        'UltraLabel13
        '
        Appearance136.BackColor = System.Drawing.Color.Transparent
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Appearance136.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance136
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(63, 6)
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
        Me.txtRucComisionista.Location = New System.Drawing.Point(915, 71)
        Me.txtRucComisionista.Name = "txtRucComisionista"
        Me.txtRucComisionista.Size = New System.Drawing.Size(106, 21)
        Me.txtRucComisionista.TabIndex = 24
        '
        'txtRucCLienteFinal
        '
        Me.txtRucCLienteFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucCLienteFinal.Enabled = False
        Me.txtRucCLienteFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucCLienteFinal.Location = New System.Drawing.Point(915, 48)
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
        Me.txtRucCLiente.Location = New System.Drawing.Point(2, 48)
        Me.txtRucCLiente.Name = "txtRucCLiente"
        Me.txtRucCLiente.ReadOnly = True
        Me.txtRucCLiente.Size = New System.Drawing.Size(100, 21)
        Me.txtRucCLiente.TabIndex = 5
        UltraToolTipInfo11.ToolTipText = "RUC Cliente"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtRucCLiente, UltraToolTipInfo11)
        '
        'cboMaterial
        '
        Me.cboMaterial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMaterial.DisplayMember = "Nombre"
        Me.cboMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMaterial.Location = New System.Drawing.Point(758, 118)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(154, 22)
        Me.cboMaterial.TabIndex = 32
        Me.cboMaterial.ValueMember = "Id"
        '
        'cboTipoCarga
        '
        Me.cboTipoCarga.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoCarga.DisplayMember = "Nombre"
        Me.cboTipoCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoCarga.Location = New System.Drawing.Point(567, 118)
        Me.cboTipoCarga.Name = "cboTipoCarga"
        Me.cboTipoCarga.Size = New System.Drawing.Size(139, 22)
        Me.cboTipoCarga.TabIndex = 30
        Me.cboTipoCarga.ValueMember = "Id"
        '
        'cboClienteFinal
        '
        Me.cboClienteFinal.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance137.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton10.Appearance = Appearance137
        EditorButton10.Key = "btnEditarClienteFinal"
        EditorButton10.Visible = False
        Me.cboClienteFinal.ButtonsRight.Add(EditorButton10)
        Me.cboClienteFinal.DisplayMember = "Nombre"
        Me.cboClienteFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteFinal.Location = New System.Drawing.Point(567, 48)
        Me.cboClienteFinal.Name = "cboClienteFinal"
        Me.cboClienteFinal.Size = New System.Drawing.Size(345, 22)
        Me.cboClienteFinal.TabIndex = 20
        Me.cboClienteFinal.ValueMember = "Id"
        '
        'cboComisionista
        '
        Me.cboComisionista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance138.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton11.Appearance = Appearance138
        EditorButton11.Key = "btnEditarComisionista"
        EditorButton11.Text = ""
        Appearance139.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton12.Appearance = Appearance139
        EditorButton12.Key = "btnNuevoComisionista"
        EditorButton12.Visible = False
        Me.cboComisionista.ButtonsRight.Add(EditorButton11)
        Me.cboComisionista.ButtonsRight.Add(EditorButton12)
        Me.cboComisionista.DisplayMember = "Nombre"
        Me.cboComisionista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboComisionista.Location = New System.Drawing.Point(567, 71)
        Me.cboComisionista.Name = "cboComisionista"
        Me.cboComisionista.Size = New System.Drawing.Size(345, 22)
        Me.cboComisionista.TabIndex = 23
        Me.cboComisionista.ValueMember = "Id"
        '
        'cboCliente
        '
        Me.cboCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCliente.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Appearance140.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton13.Appearance = Appearance140
        EditorButton13.Key = "btnEditarCliente"
        Appearance141.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton14.Appearance = Appearance141
        EditorButton14.Key = "btnNuevoCliente"
        EditorButton14.Visible = False
        Me.cboCliente.ButtonsRight.Add(EditorButton13)
        Me.cboCliente.ButtonsRight.Add(EditorButton14)
        Me.cboCliente.DisplayMember = "Nombre"
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.Location = New System.Drawing.Point(105, 48)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(353, 22)
        Me.cboCliente.TabIndex = 6
        UltraToolTipInfo12.ToolTipText = "Seleccione Cliente"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboCliente, UltraToolTipInfo12)
        Me.cboCliente.ValueMember = "Id"
        '
        'UltraLabel19
        '
        Appearance142.BackColor = System.Drawing.Color.Transparent
        Appearance142.ForeColor = System.Drawing.Color.Navy
        Appearance142.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance142
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(503, 122)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(62, 15)
        Me.UltraLabel19.TabIndex = 29
        Me.UltraLabel19.Text = "Tipo Carga:"
        '
        'UltraLabel17
        '
        Appearance143.BackColor = System.Drawing.Color.Transparent
        Appearance143.ForeColor = System.Drawing.Color.Navy
        Appearance143.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance143
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(468, 29)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(96, 15)
        Me.UltraLabel17.TabIndex = 17
        Me.UltraLabel17.Text = "Direccion Llegada:"
        '
        'UltraLabel12
        '
        Appearance144.BackColor = System.Drawing.Color.Transparent
        Appearance144.ForeColor = System.Drawing.Color.Navy
        Appearance144.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance144
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(472, 5)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(92, 15)
        Me.UltraLabel12.TabIndex = 15
        Me.UltraLabel12.Text = "Direccion Partida:"
        '
        'txtCantidad
        '
        Appearance145.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance145.TextHAlignAsString = "Right"
        Me.txtCantidad.Appearance = Appearance145
        Me.txtCantidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCantidad.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCantidad.InputMask = "{double:5.3}"
        Me.txtCantidad.Location = New System.Drawing.Point(961, 119)
        Me.txtCantidad.MinValue = CType(0, Long)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.NonAutoSizeHeight = 20
        Me.txtCantidad.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCantidad.Size = New System.Drawing.Size(60, 21)
        Me.txtCantidad.TabIndex = 34
        Me.txtCantidad.Text = "1.000"
        '
        'UltraLabel15
        '
        Appearance146.BackColor = System.Drawing.Color.Transparent
        Appearance146.ForeColor = System.Drawing.Color.Navy
        Appearance146.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance146
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(0, 32)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel15.TabIndex = 2
        Me.UltraLabel15.Text = "Cliente"
        '
        'lblClienteFinal
        '
        Appearance147.BackColor = System.Drawing.Color.Transparent
        Appearance147.ForeColor = System.Drawing.Color.Navy
        Appearance147.TextVAlignAsString = "Middle"
        Me.lblClienteFinal.Appearance = Appearance147
        Me.lblClienteFinal.AutoSize = True
        Me.lblClienteFinal.Location = New System.Drawing.Point(496, 52)
        Me.lblClienteFinal.Name = "lblClienteFinal"
        Me.lblClienteFinal.Size = New System.Drawing.Size(69, 15)
        Me.lblClienteFinal.TabIndex = 19
        Me.lblClienteFinal.Text = "Cliente Final:"
        '
        'UltraLabel25
        '
        Appearance148.BackColor = System.Drawing.Color.Transparent
        Appearance148.ForeColor = System.Drawing.Color.Navy
        Appearance148.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance148
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Location = New System.Drawing.Point(494, 75)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(71, 15)
        Me.UltraLabel25.TabIndex = 22
        Me.UltraLabel25.Text = "Comisionista:"
        '
        'UltraLabel20
        '
        Appearance149.BackColor = System.Drawing.Color.Transparent
        Appearance149.ForeColor = System.Drawing.Color.Navy
        Appearance149.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance149
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(912, 121)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel20.TabIndex = 33
        Me.UltraLabel20.Text = "Cantidad:"
        '
        'UltraLabel24
        '
        Appearance150.BackColor = System.Drawing.Color.Transparent
        Appearance150.ForeColor = System.Drawing.Color.Navy
        Appearance150.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance150
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(709, 122)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel24.TabIndex = 31
        Me.UltraLabel24.Text = "Material:"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.griDetalleTercero)
        Me.UltraTabPageControl9.Controls.Add(Me.UltraExpandableGroupBox6)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1342, 405)
        '
        'griDetalleTercero
        '
        Appearance44.BackColor = System.Drawing.Color.White
        Me.griDetalleTercero.DisplayLayout.Appearance = Appearance44
        UltraGridColumn267.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn267.Header.VisiblePosition = 0
        UltraGridColumn267.Hidden = True
        UltraGridColumn268.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn268.Header.VisiblePosition = 1
        UltraGridColumn268.Hidden = True
        UltraGridColumn269.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn269.Header.VisiblePosition = 2
        UltraGridColumn269.Hidden = True
        UltraGridColumn269.Width = 250
        UltraGridColumn270.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn270.Header.Caption = "Tercero"
        UltraGridColumn270.Header.VisiblePosition = 3
        UltraGridColumn270.Width = 250
        UltraGridColumn271.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn271.Header.Caption = "Contacto"
        UltraGridColumn271.Header.VisiblePosition = 4
        UltraGridColumn271.Width = 200
        UltraGridColumn272.Header.Caption = "Moneda"
        UltraGridColumn272.Header.VisiblePosition = 5
        UltraGridColumn272.Width = 50
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance45.TextHAlignAsString = "Right"
        UltraGridColumn273.CellAppearance = Appearance45
        UltraGridColumn273.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn273.Format = ""
        UltraGridColumn273.Header.Caption = "F.Unitario"
        UltraGridColumn273.Header.VisiblePosition = 8
        UltraGridColumn273.MaskInput = "{double:9.4}"
        UltraGridColumn273.Width = 75
        Appearance46.TextHAlignAsString = "Right"
        UltraGridColumn274.CellAppearance = Appearance46
        UltraGridColumn274.Format = ""
        UltraGridColumn274.Header.VisiblePosition = 10
        UltraGridColumn274.MaskInput = "{double:5.4}"
        UltraGridColumn274.Width = 50
        UltraGridColumn275.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn275.CellAppearance = Appearance47
        UltraGridColumn275.Format = ""
        UltraGridColumn275.Header.VisiblePosition = 11
        UltraGridColumn275.MaskInput = "{double:9.4}"
        UltraGridColumn275.Width = 100
        UltraGridColumn276.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance48.BackColor = System.Drawing.Color.PaleTurquoise
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn276.CellAppearance = Appearance48
        UltraGridColumn276.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn276.Header.VisiblePosition = 12
        UltraGridColumn276.Hidden = True
        UltraGridColumn276.MaskInput = ""
        UltraGridColumn276.Width = 60
        UltraGridColumn277.Header.VisiblePosition = 13
        UltraGridColumn277.Hidden = True
        UltraGridColumn278.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance49.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance49.TextHAlignAsString = "Right"
        UltraGridColumn278.CellAppearance = Appearance49
        UltraGridColumn278.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn278.Format = ""
        UltraGridColumn278.Header.VisiblePosition = 6
        UltraGridColumn278.MaskInput = "{double:5.4}"
        UltraGridColumn278.Width = 50
        UltraGridColumn279.Header.VisiblePosition = 14
        UltraGridColumn279.Hidden = True
        UltraGridColumn280.Header.VisiblePosition = 16
        UltraGridColumn280.Hidden = True
        UltraGridColumn280.Width = 100
        UltraGridColumn281.Header.Caption = "Plantilla"
        UltraGridColumn281.Header.VisiblePosition = 15
        UltraGridColumn281.Width = 34
        UltraGridColumn282.Header.VisiblePosition = 17
        UltraGridColumn282.Hidden = True
        UltraGridColumn283.Header.VisiblePosition = 18
        UltraGridColumn283.Hidden = True
        UltraGridColumn284.Header.VisiblePosition = 19
        UltraGridColumn284.Hidden = True
        UltraGridColumn285.Header.VisiblePosition = 20
        UltraGridColumn285.Hidden = True
        UltraGridColumn286.Header.VisiblePosition = 21
        UltraGridColumn286.Hidden = True
        UltraGridColumn287.Header.VisiblePosition = 22
        UltraGridColumn287.Hidden = True
        UltraGridColumn288.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn288.Header.VisiblePosition = 26
        UltraGridColumn288.Width = 300
        UltraGridColumn289.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn289.Header.Caption = "Referencia Punto de Llegada"
        UltraGridColumn289.Header.VisiblePosition = 23
        UltraGridColumn289.Width = 300
        UltraGridColumn290.Header.VisiblePosition = 24
        UltraGridColumn290.Hidden = True
        UltraGridColumn291.Header.VisiblePosition = 25
        UltraGridColumn291.Hidden = True
        Appearance50.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn292.CellAppearance = Appearance50
        UltraGridColumn292.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn292.Header.VisiblePosition = 7
        UltraGridColumn292.MaskInput = "{double:5.2}"
        UltraGridColumn292.Width = 50
        Appearance51.TextHAlignAsString = "Right"
        UltraGridColumn293.CellAppearance = Appearance51
        UltraGridColumn293.Format = ""
        UltraGridColumn293.Header.VisiblePosition = 9
        UltraGridColumn293.MaskInput = "{double:9.4}"
        UltraGridColumn293.Width = 75
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271, UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293})
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
        Appearance52.TextVAlignAsString = "Middle"
        Me.griDetalleTercero.DisplayLayout.Override.RowAppearance = Appearance52
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
        Me.griDetalleTercero.Size = New System.Drawing.Size(1342, 256)
        Me.griDetalleTercero.TabIndex = 1
        Me.griDetalleTercero.Tag = ""
        '
        'UltraExpandableGroupBox6
        '
        Me.UltraExpandableGroupBox6.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Appearance53.BackColor = System.Drawing.Color.White
        Appearance53.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox6.ContentAreaAppearance = Appearance53
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
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboTercero)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtTelefonoContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtApellidoMaternoContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtNombreContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtApellidoPaternoContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtRucContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtRucEmpresaTransportista)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboContacto)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.btnAgregarTecero)
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
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraLabel28)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraLabel29)
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
        Appearance54.FontData.BoldAsString = "True"
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Me.chkIndPlantilla.Appearance = Appearance54
        Me.chkIndPlantilla.AutoSize = True
        Me.chkIndPlantilla.Location = New System.Drawing.Point(571, 100)
        Me.chkIndPlantilla.Name = "chkIndPlantilla"
        Me.chkIndPlantilla.Size = New System.Drawing.Size(158, 18)
        Me.chkIndPlantilla.TabIndex = 38
        Me.chkIndPlantilla.Text = "USAR COMO PLANTILLA"
        '
        'cboTercero
        '
        Me.cboTercero.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance55.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton1.Appearance = Appearance55
        EditorButton1.Key = "btnEditar"
        Me.cboTercero.ButtonsRight.Add(EditorButton1)
        Me.cboTercero.DisplayMember = "Nombre"
        Me.cboTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTercero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTercero.Location = New System.Drawing.Point(94, 2)
        Me.cboTercero.Name = "cboTercero"
        Me.cboTercero.Size = New System.Drawing.Size(339, 21)
        Me.cboTercero.TabIndex = 37
        Me.cboTercero.ValueMember = "Id"
        '
        'txtTelefonoContacto
        '
        Me.txtTelefonoContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTelefonoContacto.Enabled = False
        Me.txtTelefonoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoContacto.Location = New System.Drawing.Point(439, 49)
        Me.txtTelefonoContacto.Name = "txtTelefonoContacto"
        Me.txtTelefonoContacto.Size = New System.Drawing.Size(106, 21)
        Me.txtTelefonoContacto.TabIndex = 36
        UltraToolTipInfo1.ToolTipText = "Telefono"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtTelefonoContacto, UltraToolTipInfo1)
        '
        'txtApellidoMaternoContacto
        '
        Me.txtApellidoMaternoContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoMaternoContacto.Enabled = False
        Me.txtApellidoMaternoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaternoContacto.Location = New System.Drawing.Point(209, 49)
        Me.txtApellidoMaternoContacto.Name = "txtApellidoMaternoContacto"
        Me.txtApellidoMaternoContacto.Size = New System.Drawing.Size(115, 21)
        Me.txtApellidoMaternoContacto.TabIndex = 34
        '
        'txtNombreContacto
        '
        Me.txtNombreContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombreContacto.Enabled = False
        Me.txtNombreContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreContacto.Location = New System.Drawing.Point(324, 49)
        Me.txtNombreContacto.Name = "txtNombreContacto"
        Me.txtNombreContacto.Size = New System.Drawing.Size(115, 21)
        Me.txtNombreContacto.TabIndex = 35
        '
        'txtApellidoPaternoContacto
        '
        Me.txtApellidoPaternoContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoPaternoContacto.Enabled = False
        Me.txtApellidoPaternoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaternoContacto.Location = New System.Drawing.Point(94, 49)
        Me.txtApellidoPaternoContacto.Name = "txtApellidoPaternoContacto"
        Me.txtApellidoPaternoContacto.Size = New System.Drawing.Size(115, 21)
        Me.txtApellidoPaternoContacto.TabIndex = 33
        '
        'txtRucContacto
        '
        Me.txtRucContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucContacto.Enabled = False
        Me.txtRucContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucContacto.Location = New System.Drawing.Point(439, 25)
        Me.txtRucContacto.Name = "txtRucContacto"
        Me.txtRucContacto.Size = New System.Drawing.Size(106, 21)
        Me.txtRucContacto.TabIndex = 32
        '
        'txtRucEmpresaTransportista
        '
        Me.txtRucEmpresaTransportista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucEmpresaTransportista.Enabled = False
        Me.txtRucEmpresaTransportista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucEmpresaTransportista.Location = New System.Drawing.Point(439, 2)
        Me.txtRucEmpresaTransportista.Name = "txtRucEmpresaTransportista"
        Me.txtRucEmpresaTransportista.Size = New System.Drawing.Size(106, 21)
        Me.txtRucEmpresaTransportista.TabIndex = 31
        '
        'cboContacto
        '
        Me.cboContacto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboContacto.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Appearance56.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton2.Appearance = Appearance56
        EditorButton2.Key = "btnEditarCliente"
        Appearance57.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton3.Appearance = Appearance57
        EditorButton3.Key = "btnNuevoCliente"
        EditorButton3.Visible = False
        Me.cboContacto.ButtonsRight.Add(EditorButton2)
        Me.cboContacto.ButtonsRight.Add(EditorButton3)
        Me.cboContacto.DisplayMember = "Nombre"
        Me.cboContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboContacto.Location = New System.Drawing.Point(94, 25)
        Me.cboContacto.Name = "cboContacto"
        Me.cboContacto.Size = New System.Drawing.Size(339, 22)
        Me.cboContacto.TabIndex = 23
        Me.cboContacto.ValueMember = "Id"
        '
        'btnAgregarTecero
        '
        Appearance58.BorderColor = System.Drawing.Color.White
        Appearance58.Image = CType(resources.GetObject("Appearance58.Image"), Object)
        Me.btnAgregarTecero.Appearance = Appearance58
        Me.btnAgregarTecero.ImageList = Me.imagenes
        Me.btnAgregarTecero.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnAgregarTecero.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregarTecero.Location = New System.Drawing.Point(872, 62)
        Me.btnAgregarTecero.Name = "btnAgregarTecero"
        Me.btnAgregarTecero.Size = New System.Drawing.Size(33, 28)
        Me.btnAgregarTecero.TabIndex = 21
        '
        'numCantidadTercero
        '
        Appearance59.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance59.TextHAlignAsString = "Right"
        Me.numCantidadTercero.Appearance = Appearance59
        Me.numCantidadTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCantidadTercero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numCantidadTercero.InputMask = "{double:5.2}"
        Me.numCantidadTercero.Location = New System.Drawing.Point(392, 100)
        Me.numCantidadTercero.Name = "numCantidadTercero"
        Me.numCantidadTercero.NonAutoSizeHeight = 20
        Me.numCantidadTercero.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numCantidadTercero.Size = New System.Drawing.Size(50, 21)
        Me.numCantidadTercero.TabIndex = 10
        Me.numCantidadTercero.Text = "1.00"
        '
        'UltraLabel66
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Appearance60.TextVAlignAsString = "Middle"
        Me.UltraLabel66.Appearance = Appearance60
        Me.UltraLabel66.AutoSize = True
        Me.UltraLabel66.Location = New System.Drawing.Point(338, 103)
        Me.UltraLabel66.Name = "UltraLabel66"
        Me.UltraLabel66.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel66.TabIndex = 9
        Me.UltraLabel66.Text = "Cantidad:"
        '
        'numSubTotalTercero
        '
        Appearance61.TextHAlignAsString = "Right"
        Me.numSubTotalTercero.Appearance = Appearance61
        Me.numSubTotalTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numSubTotalTercero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numSubTotalTercero.InputMask = "{double:10.4}"
        Me.numSubTotalTercero.Location = New System.Drawing.Point(635, 23)
        Me.numSubTotalTercero.Name = "numSubTotalTercero"
        Me.numSubTotalTercero.NonAutoSizeHeight = 20
        Me.numSubTotalTercero.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numSubTotalTercero.ReadOnly = True
        Me.numSubTotalTercero.Size = New System.Drawing.Size(75, 21)
        Me.numSubTotalTercero.TabIndex = 16
        Me.numSubTotalTercero.Text = "0.0000"
        '
        'UltraLabel67
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Appearance62.TextVAlignAsString = "Middle"
        Me.UltraLabel67.Appearance = Appearance62
        Me.UltraLabel67.AutoSize = True
        Me.UltraLabel67.Location = New System.Drawing.Point(577, 27)
        Me.UltraLabel67.Name = "UltraLabel67"
        Me.UltraLabel67.Size = New System.Drawing.Size(56, 15)
        Me.UltraLabel67.TabIndex = 12
        Me.UltraLabel67.Text = "Sub Total: "
        '
        'txtObservacionTercero
        '
        Me.txtObservacionTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionTercero.Location = New System.Drawing.Point(716, 0)
        Me.txtObservacionTercero.Multiline = True
        Me.txtObservacionTercero.Name = "txtObservacionTercero"
        Me.txtObservacionTercero.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionTercero.Size = New System.Drawing.Size(150, 90)
        Me.txtObservacionTercero.TabIndex = 19
        UltraToolTipInfo2.ToolTipText = "Observaciones del Contrato de Terceros"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtObservacionTercero, UltraToolTipInfo2)
        '
        'UltraLabel43
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Appearance63.TextVAlignAsString = "Middle"
        Me.UltraLabel43.Appearance = Appearance63
        Me.UltraLabel43.AutoSize = True
        Me.UltraLabel43.Location = New System.Drawing.Point(3, 8)
        Me.UltraLabel43.Name = "UltraLabel43"
        Me.UltraLabel43.Size = New System.Drawing.Size(88, 15)
        Me.UltraLabel43.TabIndex = 0
        Me.UltraLabel43.Text = "Emp.Transporte:"
        '
        'txtReferenciaTercero
        '
        Me.txtReferenciaTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtReferenciaTercero.Location = New System.Drawing.Point(3, 73)
        Me.txtReferenciaTercero.Multiline = True
        Me.txtReferenciaTercero.Name = "txtReferenciaTercero"
        Me.txtReferenciaTercero.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReferenciaTercero.Size = New System.Drawing.Size(441, 22)
        Me.txtReferenciaTercero.TabIndex = 4
        UltraToolTipInfo3.ToolTipText = "Refencia del Punto de Llegada "
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtReferenciaTercero, UltraToolTipInfo3)
        '
        'numFleteTotalTerc
        '
        Appearance64.TextHAlignAsString = "Right"
        Me.numFleteTotalTerc.Appearance = Appearance64
        Me.numFleteTotalTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numFleteTotalTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numFleteTotalTerc.InputMask = "{double:10.4}"
        Me.numFleteTotalTerc.Location = New System.Drawing.Point(635, 68)
        Me.numFleteTotalTerc.Name = "numFleteTotalTerc"
        Me.numFleteTotalTerc.NonAutoSizeHeight = 20
        Me.numFleteTotalTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numFleteTotalTerc.ReadOnly = True
        Me.numFleteTotalTerc.Size = New System.Drawing.Size(75, 21)
        Me.numFleteTotalTerc.TabIndex = 18
        Me.numFleteTotalTerc.Text = "0.0000"
        '
        'numIgvTerc
        '
        Appearance65.TextHAlignAsString = "Right"
        Me.numIgvTerc.Appearance = Appearance65
        Me.numIgvTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numIgvTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numIgvTerc.InputMask = "{double:10.4}"
        Me.numIgvTerc.Location = New System.Drawing.Point(635, 46)
        Me.numIgvTerc.Name = "numIgvTerc"
        Me.numIgvTerc.NonAutoSizeHeight = 20
        Me.numIgvTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numIgvTerc.ReadOnly = True
        Me.numIgvTerc.Size = New System.Drawing.Size(75, 21)
        Me.numIgvTerc.TabIndex = 17
        Me.numIgvTerc.Text = "0.0000"
        '
        'cboMonedaT
        '
        Appearance66.ForeColor = System.Drawing.Color.Black
        Me.cboMonedaT.Appearance = Appearance66
        Me.cboMonedaT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMonedaT.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMonedaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonedaT.ForeColor = System.Drawing.Color.Black
        Me.cboMonedaT.Location = New System.Drawing.Point(92, 100)
        Me.cboMonedaT.Name = "cboMonedaT"
        Me.cboMonedaT.Size = New System.Drawing.Size(40, 21)
        Me.cboMonedaT.TabIndex = 6
        Me.cboMonedaT.ValueMember = "Id"
        '
        'UltraLabel28
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Appearance67.TextVAlignAsString = "Middle"
        Me.UltraLabel28.Appearance = Appearance67
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Location = New System.Drawing.Point(42, 104)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel28.TabIndex = 5
        Me.UltraLabel28.Text = "Moneda:"
        '
        'UltraLabel29
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Appearance68.TextVAlignAsString = "Middle"
        Me.UltraLabel29.Appearance = Appearance68
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Location = New System.Drawing.Point(571, 71)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel29.TabIndex = 14
        Me.UltraLabel29.Text = "Flete Total: "
        '
        'numFleteUnitarioTerc
        '
        Appearance69.TextHAlignAsString = "Right"
        Me.numFleteUnitarioTerc.Appearance = Appearance69
        Me.numFleteUnitarioTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numFleteUnitarioTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numFleteUnitarioTerc.InputMask = "{double:10.4}"
        Me.numFleteUnitarioTerc.Location = New System.Drawing.Point(635, 1)
        Me.numFleteUnitarioTerc.Name = "numFleteUnitarioTerc"
        Me.numFleteUnitarioTerc.NonAutoSizeHeight = 20
        Me.numFleteUnitarioTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numFleteUnitarioTerc.Size = New System.Drawing.Size(75, 21)
        Me.numFleteUnitarioTerc.TabIndex = 15
        Me.numFleteUnitarioTerc.Text = "0.0000"
        '
        'UltraLabel31
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Appearance70.TextVAlignAsString = "Middle"
        Me.UltraLabel31.Appearance = Appearance70
        Me.UltraLabel31.AutoSize = True
        Me.UltraLabel31.Location = New System.Drawing.Point(604, 49)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(27, 15)
        Me.UltraLabel31.TabIndex = 13
        Me.UltraLabel31.Text = "IGV:"
        '
        'UltraLabel33
        '
        Appearance71.BackColor = System.Drawing.Color.Transparent
        Appearance71.ForeColor = System.Drawing.Color.Navy
        Appearance71.TextVAlignAsString = "Middle"
        Me.UltraLabel33.Appearance = Appearance71
        Me.UltraLabel33.AutoSize = True
        Me.UltraLabel33.Location = New System.Drawing.Point(39, 30)
        Me.UltraLabel33.Name = "UltraLabel33"
        Me.UltraLabel33.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel33.TabIndex = 2
        Me.UltraLabel33.Text = "Contacto:"
        '
        'numComisionTerc
        '
        Appearance72.TextHAlignAsString = "Right"
        Me.numComisionTerc.Appearance = Appearance72
        Me.numComisionTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numComisionTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numComisionTerc.InputMask = "{double:4.2}"
        Me.numComisionTerc.Location = New System.Drawing.Point(197, 100)
        Me.numComisionTerc.Name = "numComisionTerc"
        Me.numComisionTerc.NonAutoSizeHeight = 20
        Me.numComisionTerc.NullText = "0.00"
        Me.numComisionTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numComisionTerc.Size = New System.Drawing.Size(50, 21)
        Me.numComisionTerc.TabIndex = 8
        Me.numComisionTerc.Text = "100.00"
        '
        'UltraLabel34
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Appearance73.TextVAlignAsString = "Middle"
        Me.UltraLabel34.Appearance = Appearance73
        Me.UltraLabel34.AutoSize = True
        Me.UltraLabel34.Location = New System.Drawing.Point(139, 103)
        Me.UltraLabel34.Name = "UltraLabel34"
        Me.UltraLabel34.Size = New System.Drawing.Size(53, 15)
        Me.UltraLabel34.TabIndex = 7
        Me.UltraLabel34.Text = "Comisión: "
        '
        'UltraLabel35
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Appearance74.TextVAlignAsString = "Middle"
        Me.UltraLabel35.Appearance = Appearance74
        Me.UltraLabel35.AutoSize = True
        Me.UltraLabel35.Location = New System.Drawing.Point(557, 5)
        Me.UltraLabel35.Name = "UltraLabel35"
        Me.UltraLabel35.Size = New System.Drawing.Size(75, 15)
        Me.UltraLabel35.TabIndex = 11
        Me.UltraLabel35.Text = "Flete Unitario: "
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.tabDemandaCargas)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1346, 602)
        '
        'tabDemandaCargas
        '
        Appearance31.BackColor = System.Drawing.Color.White
        Appearance31.BackColor2 = System.Drawing.Color.White
        Me.tabDemandaCargas.ClientAreaAppearance = Appearance31
        Me.tabDemandaCargas.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.tabDemandaCargas.Controls.Add(Me.UltraTabPageControl5)
        Me.tabDemandaCargas.Controls.Add(Me.UltraTabPageControl6)
        Me.tabDemandaCargas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDemandaCargas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDemandaCargas.Location = New System.Drawing.Point(0, 93)
        Me.tabDemandaCargas.Name = "tabDemandaCargas"
        Me.tabDemandaCargas.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.tabDemandaCargas.Size = New System.Drawing.Size(1346, 509)
        Me.tabDemandaCargas.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.tabDemandaCargas.TabIndex = 19
        UltraTab1.TabPage = Me.UltraTabPageControl5
        UltraTab1.Text = "Predemanda"
        UltraTab2.TabPage = Me.UltraTabPageControl6
        UltraTab2.Text = "Cargas Operaciones"
        Me.tabDemandaCargas.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tabDemandaCargas.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1344, 486)
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.UltraGroupBox3)
        Me.agrBusqueda.Controls.Add(Me.verViajeRetorno)
        Me.agrBusqueda.Controls.Add(Me.cboUsuario)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel62)
        Me.agrBusqueda.Controls.Add(Me.UltraGroupBox13)
        Me.agrBusqueda.Controls.Add(Me.Agrupacion1)
        Me.agrBusqueda.Controls.Add(Me.Agrupacion2)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1346, 93)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Búsqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraGroupBox3
        '
        Appearance32.BackColor = System.Drawing.Color.White
        Appearance32.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance32
        Me.UltraGroupBox3.Controls.Add(Me.chkExcluirDemandas)
        Me.UltraGroupBox3.Controls.Add(Me.chkTercerizadoFiltro)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(807, 21)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(146, 67)
        Me.UltraGroupBox3.TabIndex = 59
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkExcluirDemandas
        '
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.chkExcluirDemandas.Appearance = Appearance33
        Me.chkExcluirDemandas.AutoSize = True
        Me.chkExcluirDemandas.Checked = True
        Me.chkExcluirDemandas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExcluirDemandas.Location = New System.Drawing.Point(6, 30)
        Me.chkExcluirDemandas.Name = "chkExcluirDemandas"
        Me.chkExcluirDemandas.Size = New System.Drawing.Size(138, 18)
        Me.chkExcluirDemandas.TabIndex = 59
        Me.chkExcluirDemandas.Text = "Excluir Dem.Asignadas"
        '
        'chkTercerizadoFiltro
        '
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.chkTercerizadoFiltro.Appearance = Appearance34
        Me.chkTercerizadoFiltro.AutoSize = True
        Me.chkTercerizadoFiltro.Location = New System.Drawing.Point(6, 7)
        Me.chkTercerizadoFiltro.Name = "chkTercerizadoFiltro"
        Me.chkTercerizadoFiltro.Size = New System.Drawing.Size(87, 18)
        Me.chkTercerizadoFiltro.TabIndex = 58
        Me.chkTercerizadoFiltro.Text = "Tercerizados"
        '
        'verViajeRetorno
        '
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.verViajeRetorno.Appearance = Appearance35
        Me.verViajeRetorno.AutoSize = True
        Me.verViajeRetorno.BackColor = System.Drawing.Color.Transparent
        Me.verViajeRetorno.BackColorInternal = System.Drawing.Color.Transparent
        Me.verViajeRetorno.Location = New System.Drawing.Point(162, 65)
        Me.verViajeRetorno.Name = "verViajeRetorno"
        Me.verViajeRetorno.Size = New System.Drawing.Size(109, 18)
        Me.verViajeRetorno.TabIndex = 58
        Me.verViajeRetorno.Text = "Incluir V. Retorno"
        '
        'cboUsuario
        '
        Me.cboUsuario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboUsuario.DisplayMember = "Login"
        Me.cboUsuario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsuario.Location = New System.Drawing.Point(162, 39)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(166, 21)
        Me.cboUsuario.TabIndex = 52
        Me.cboUsuario.ValueMember = "Id"
        '
        'UltraLabel62
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Appearance36.TextVAlignAsString = "Middle"
        Me.UltraLabel62.Appearance = Appearance36
        Me.UltraLabel62.AutoSize = True
        Me.UltraLabel62.Location = New System.Drawing.Point(162, 23)
        Me.UltraLabel62.Name = "UltraLabel62"
        Me.UltraLabel62.Size = New System.Drawing.Size(46, 15)
        Me.UltraLabel62.TabIndex = 51
        Me.UltraLabel62.Text = "Usuario:"
        '
        'UltraGroupBox13
        '
        Appearance37.BackColor = System.Drawing.Color.White
        Appearance37.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox13.ContentAreaAppearance = Appearance37
        Me.UltraGroupBox13.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox13.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(6, 20)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(150, 68)
        Me.UltraGroupBox13.TabIndex = 50
        Me.UltraGroupBox13.Text = "F.Atención"
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecHasta
        '
        Me.fecHasta.DateTime = New Date(2015, 3, 17, 0, 0, 0, 0)
        Me.fecHasta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecHasta.Location = New System.Drawing.Point(50, 42)
        Me.fecHasta.MaskInput = ""
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(90, 22)
        Me.fecHasta.TabIndex = 50
        Me.fecHasta.Value = New Date(2015, 3, 17, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Appearance38.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance38
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(11, 44)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel3.TabIndex = 49
        Me.UltraLabel3.Text = "Hasta:"
        '
        'fecDesde
        '
        Me.fecDesde.DateTime = New Date(2015, 3, 17, 0, 0, 0, 0)
        Me.fecDesde.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDesde.Location = New System.Drawing.Point(50, 19)
        Me.fecDesde.MaskInput = ""
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(90, 22)
        Me.fecDesde.TabIndex = 48
        Me.fecDesde.Value = New Date(2015, 3, 17, 0, 0, 0, 0)
        '
        'UltraLabel2
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Appearance39.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance39
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(8, 23)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel2.TabIndex = 47
        Me.UltraLabel2.Text = "Desde:"
        '
        'Agrupacion1
        '
        Appearance40.BackColor = System.Drawing.Color.White
        Appearance40.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance40
        Me.Agrupacion1.Controls.Add(Me.numDiasAntes)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion1.Controls.Add(Me.colorPorVencer)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion1.Controls.Add(Me.colorVencidas)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(593, 21)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(208, 68)
        Me.Agrupacion1.TabIndex = 2
        Me.Agrupacion1.Text = "Pre Demandas no Asignadas"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'numDiasAntes
        '
        Appearance41.ForeColor = System.Drawing.Color.Black
        Me.numDiasAntes.Appearance = Appearance41
        Me.numDiasAntes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numDiasAntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDiasAntes.ForeColor = System.Drawing.Color.Black
        Me.numDiasAntes.FormatString = ""
        Me.numDiasAntes.Location = New System.Drawing.Point(66, 41)
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
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(109, 44)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(26, 14)
        Me.Etiqueta4.TabIndex = 4
        Me.Etiqueta4.Text = "Días"
        '
        'colorPorVencer
        '
        Me.colorPorVencer.Color = System.Drawing.Color.GreenYellow
        Me.colorPorVencer.Location = New System.Drawing.Point(137, 40)
        Me.colorPorVencer.Name = "colorPorVencer"
        Me.colorPorVencer.Size = New System.Drawing.Size(43, 21)
        Me.colorPorVencer.TabIndex = 5
        Me.colorPorVencer.Text = "GreenYellow"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(5, 44)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Por Vencer:"
        '
        'colorVencidas
        '
        Me.colorVencidas.Color = System.Drawing.Color.Red
        Me.colorVencidas.Location = New System.Drawing.Point(66, 18)
        Me.colorVencidas.Name = "colorVencidas"
        Me.colorVencidas.Size = New System.Drawing.Size(43, 21)
        Me.colorVencidas.TabIndex = 1
        Me.colorVencidas.Text = "Red"
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(11, 22)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta5.TabIndex = 0
        Me.Etiqueta5.Text = "Vencidas:"
        '
        'Agrupacion2
        '
        Appearance42.BackColor = System.Drawing.Color.White
        Appearance42.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion2.ContentAreaAppearance = Appearance42
        Me.Agrupacion2.Controls.Add(Me.VerAsignada)
        Me.Agrupacion2.Controls.Add(Me.colorCambio)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta45)
        Me.Agrupacion2.Controls.Add(Me.colorCancelada)
        Me.Agrupacion2.Controls.Add(Me.etiCancelada)
        Me.Agrupacion2.Controls.Add(Me.colorAsignada)
        Me.Agrupacion2.Controls.Add(Me.colorGenerada)
        Me.Agrupacion2.Controls.Add(Me.etiGenerada)
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(334, 21)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(253, 68)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.Text = "Estados de Predemanda"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'VerAsignada
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.VerAsignada.Appearance = Appearance43
        Me.VerAsignada.Location = New System.Drawing.Point(6, 42)
        Me.VerAsignada.Name = "VerAsignada"
        Me.VerAsignada.Size = New System.Drawing.Size(70, 20)
        Me.VerAsignada.TabIndex = 56
        Me.VerAsignada.Text = "Asignada:"
        '
        'colorCambio
        '
        Me.colorCambio.Color = System.Drawing.Color.Cyan
        Me.colorCambio.Location = New System.Drawing.Point(192, 41)
        Me.colorCambio.Name = "colorCambio"
        Me.colorCambio.Size = New System.Drawing.Size(44, 21)
        Me.colorCambio.TabIndex = 55
        Me.colorCambio.Text = "Cyan"
        '
        'Etiqueta45
        '
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(126, 45)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(64, 14)
        Me.Etiqueta45.TabIndex = 54
        Me.Etiqueta45.Text = "Actualizado:"
        '
        'colorCancelada
        '
        Me.colorCancelada.Color = System.Drawing.Color.Orange
        Me.colorCancelada.Location = New System.Drawing.Point(192, 18)
        Me.colorCancelada.Name = "colorCancelada"
        Me.colorCancelada.Size = New System.Drawing.Size(43, 21)
        Me.colorCancelada.TabIndex = 5
        Me.colorCancelada.Text = "Orange"
        '
        'etiCancelada
        '
        Me.etiCancelada.AutoSize = True
        Me.etiCancelada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCancelada.ForeColor = System.Drawing.Color.Black
        Me.etiCancelada.Location = New System.Drawing.Point(130, 22)
        Me.etiCancelada.Name = "etiCancelada"
        Me.etiCancelada.Size = New System.Drawing.Size(60, 14)
        Me.etiCancelada.TabIndex = 4
        Me.etiCancelada.Text = "Cancelada:"
        '
        'colorAsignada
        '
        Me.colorAsignada.Color = System.Drawing.Color.LimeGreen
        Me.colorAsignada.Location = New System.Drawing.Point(77, 41)
        Me.colorAsignada.Name = "colorAsignada"
        Me.colorAsignada.Size = New System.Drawing.Size(43, 21)
        Me.colorAsignada.TabIndex = 3
        Me.colorAsignada.Text = "LimeGreen"
        '
        'colorGenerada
        '
        Me.colorGenerada.Color = System.Drawing.Color.White
        Me.colorGenerada.Location = New System.Drawing.Point(77, 18)
        Me.colorGenerada.Name = "colorGenerada"
        Me.colorGenerada.Size = New System.Drawing.Size(43, 21)
        Me.colorGenerada.TabIndex = 1
        Me.colorGenerada.Text = "White"
        '
        'etiGenerada
        '
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(19, 22)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(56, 14)
        Me.etiGenerada.TabIndex = 0
        Me.etiGenerada.Text = "Generada:"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.tabs)
        Me.utpDetalle.Controls.Add(Me.UltraExpandableGroupBox9)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1346, 602)
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.tabs.Controls.Add(Me.UltraTabPageControl8)
        Me.tabs.Controls.Add(Me.UltraTabPageControl9)
        Me.tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabs.ImageList = Me.imagenes
        Me.tabs.ImageTransparentColor = System.Drawing.Color.White
        Me.tabs.Location = New System.Drawing.Point(0, 174)
        Me.tabs.Name = "tabs"
        Me.tabs.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.tabs.Size = New System.Drawing.Size(1346, 428)
        Me.tabs.TabIndex = 1
        Appearance75.Image = 10
        UltraTab3.SelectedAppearance = Appearance75
        UltraTab3.TabPage = Me.UltraTabPageControl8
        UltraTab3.Text = "Detalle Demanda"
        Appearance76.Image = 9
        UltraTab4.SelectedAppearance = Appearance76
        UltraTab4.TabPage = Me.UltraTabPageControl9
        UltraTab4.Text = "Contrato Tercero"
        Me.tabs.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.tabs.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(1342, 405)
        '
        'UltraExpandableGroupBox9
        '
        Me.UltraExpandableGroupBox9.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Appearance77.BackColor = System.Drawing.Color.White
        Appearance77.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox9.ContentAreaAppearance = Appearance77
        Me.UltraExpandableGroupBox9.Controls.Add(Me.UltraExpandableGroupBoxPanel9)
        Me.UltraExpandableGroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox9.ExpandedSize = New System.Drawing.Size(1346, 174)
        Me.UltraExpandableGroupBox9.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox9.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox9.Name = "UltraExpandableGroupBox9"
        Me.UltraExpandableGroupBox9.Size = New System.Drawing.Size(1346, 174)
        Me.UltraExpandableGroupBox9.TabIndex = 0
        Me.UltraExpandableGroupBox9.Text = "Datos Generales"
        Me.UltraExpandableGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel9
        '
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.chkTercerizacion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.udtHoraSolicita)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.udtHoraAtencion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.udtHoraRecepcion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel22)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.dtFechaRecepcion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.cboDestino)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.cboEscala)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.cboOrigen)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.cboTipoVehiculo)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.numNroUnidades)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.lblNumeroDemanda)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.NroDemanda)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.txtMotivoEscala)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.chkEscala)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel6)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel16)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.dtFechaAtencion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel11)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel9)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.dtSolicita)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.txtNumero)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.txtObservacion)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel10)
        Me.UltraExpandableGroupBoxPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel9.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel9.Name = "UltraExpandableGroupBoxPanel9"
        Me.UltraExpandableGroupBoxPanel9.Size = New System.Drawing.Size(1340, 151)
        Me.UltraExpandableGroupBoxPanel9.TabIndex = 0
        '
        'chkTercerizacion
        '
        Appearance78.FontData.BoldAsString = "True"
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Me.chkTercerizacion.Appearance = Appearance78
        Me.chkTercerizacion.AutoSize = True
        Me.chkTercerizacion.Location = New System.Drawing.Point(466, 104)
        Me.chkTercerizacion.Name = "chkTercerizacion"
        Me.chkTercerizacion.Size = New System.Drawing.Size(117, 17)
        Me.chkTercerizacion.TabIndex = 24
        Me.chkTercerizacion.Text = "TERCERIZACION"
        '
        'udtHoraSolicita
        '
        Appearance79.FontData.BoldAsString = "False"
        Me.udtHoraSolicita.Appearance = Appearance79
        Me.udtHoraSolicita.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.udtHoraSolicita.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.udtHoraSolicita.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.udtHoraSolicita.Location = New System.Drawing.Point(150, 28)
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
        Appearance80.FontData.BoldAsString = "False"
        Me.udtHoraAtencion.Appearance = Appearance80
        Me.udtHoraAtencion.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.udtHoraAtencion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.udtHoraAtencion.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.udtHoraAtencion.Location = New System.Drawing.Point(150, 54)
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
        Appearance81.FontData.BoldAsString = "False"
        Me.udtHoraRecepcion.Appearance = Appearance81
        Me.udtHoraRecepcion.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.udtHoraRecepcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.udtHoraRecepcion.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.udtHoraRecepcion.Location = New System.Drawing.Point(376, 55)
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
        'UltraLabel22
        '
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Appearance82.ForeColor = System.Drawing.Color.Navy
        Appearance82.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance82
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(218, 58)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel22.TabIndex = 10
        Me.UltraLabel22.Text = "F.Recepcion:"
        '
        'dtFechaRecepcion
        '
        Me.dtFechaRecepcion.DateTime = New Date(2015, 3, 17, 0, 0, 0, 0)
        Me.dtFechaRecepcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.dtFechaRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaRecepcion.Location = New System.Drawing.Point(292, 55)
        Me.dtFechaRecepcion.MaskInput = ""
        Me.dtFechaRecepcion.Name = "dtFechaRecepcion"
        Me.dtFechaRecepcion.Size = New System.Drawing.Size(80, 21)
        Me.dtFechaRecepcion.TabIndex = 11
        Me.dtFechaRecepcion.Value = New Date(2015, 3, 17, 0, 0, 0, 0)
        '
        'cboDestino
        '
        Me.cboDestino.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboDestino.DisplayMember = "Destino"
        Me.cboDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestino.Location = New System.Drawing.Point(66, 103)
        Me.cboDestino.Name = "cboDestino"
        Me.cboDestino.Size = New System.Drawing.Size(364, 21)
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
        Me.cboEscala.Location = New System.Drawing.Point(525, 54)
        Me.cboEscala.Name = "cboEscala"
        Me.cboEscala.Size = New System.Drawing.Size(300, 21)
        Me.cboEscala.TabIndex = 22
        Me.cboEscala.ValueMember = "Id"
        '
        'cboOrigen
        '
        Me.cboOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboOrigen.DisplayMember = "Nombre"
        Me.cboOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigen.Location = New System.Drawing.Point(66, 79)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(364, 21)
        Me.cboOrigen.TabIndex = 14
        Me.cboOrigen.ValueMember = "Id"
        '
        'cboTipoVehiculo
        '
        Me.cboTipoVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoVehiculo.DisplayMember = "Nombre"
        Me.cboTipoVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(525, 30)
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(200, 21)
        Me.cboTipoVehiculo.TabIndex = 20
        Me.cboTipoVehiculo.ValueMember = "Id"
        '
        'numNroUnidades
        '
        Me.numNroUnidades.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numNroUnidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numNroUnidades.Location = New System.Drawing.Point(525, 4)
        Me.numNroUnidades.MaskInput = "nnnnn"
        Me.numNroUnidades.MaxValue = 10000
        Me.numNroUnidades.MinValue = 1
        Me.numNroUnidades.Name = "numNroUnidades"
        Me.numNroUnidades.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numNroUnidades.Size = New System.Drawing.Size(60, 21)
        Me.numNroUnidades.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numNroUnidades.TabIndex = 18
        Me.numNroUnidades.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI
        Me.numNroUnidades.Value = 1
        '
        'lblNumeroDemanda
        '
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Appearance83.ForeColor = System.Drawing.Color.Navy
        Appearance83.TextVAlignAsString = "Middle"
        Me.lblNumeroDemanda.Appearance = Appearance83
        Me.lblNumeroDemanda.AutoSize = True
        Me.lblNumeroDemanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroDemanda.Location = New System.Drawing.Point(296, 7)
        Me.lblNumeroDemanda.Name = "lblNumeroDemanda"
        Me.lblNumeroDemanda.Size = New System.Drawing.Size(72, 14)
        Me.lblNumeroDemanda.TabIndex = 2
        Me.lblNumeroDemanda.Text = "Nº Demanda:"
        '
        'NroDemanda
        '
        Me.NroDemanda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NroDemanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NroDemanda.Location = New System.Drawing.Point(370, 3)
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
        'txtMotivoEscala
        '
        Me.txtMotivoEscala.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMotivoEscala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoEscala.Location = New System.Drawing.Point(454, 78)
        Me.txtMotivoEscala.MaxLength = 500
        Me.txtMotivoEscala.Multiline = True
        Me.txtMotivoEscala.Name = "txtMotivoEscala"
        Me.txtMotivoEscala.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoEscala.Size = New System.Drawing.Size(371, 21)
        Me.txtMotivoEscala.TabIndex = 23
        UltraToolTipInfo4.ToolTipText = "Comentario de Escala"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtMotivoEscala, UltraToolTipInfo4)
        Me.txtMotivoEscala.Visible = False
        '
        'chkEscala
        '
        Appearance84.FontData.BoldAsString = "False"
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Me.chkEscala.Appearance = Appearance84
        Me.chkEscala.AutoSize = True
        Me.chkEscala.Location = New System.Drawing.Point(466, 56)
        Me.chkEscala.Name = "chkEscala"
        Me.chkEscala.Size = New System.Drawing.Size(58, 17)
        Me.chkEscala.TabIndex = 21
        Me.chkEscala.Text = "Escala:"
        '
        'UltraLabel6
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Appearance85.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance85
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(450, 8)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(77, 14)
        Me.UltraLabel6.TabIndex = 17
        Me.UltraLabel6.Text = "Nro Unidades:"
        '
        'UltraLabel1
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Appearance86.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance86
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(20, 57)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel1.TabIndex = 7
        Me.UltraLabel1.Text = "F.Atenc:"
        '
        'UltraLabel16
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Appearance87.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance87
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(17, 107)
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
        Me.dtFechaAtencion.Location = New System.Drawing.Point(66, 54)
        Me.dtFechaAtencion.MaskInput = ""
        Me.dtFechaAtencion.Name = "dtFechaAtencion"
        Me.dtFechaAtencion.Size = New System.Drawing.Size(80, 21)
        Me.dtFechaAtencion.TabIndex = 8
        Me.dtFechaAtencion.Value = New Date(2015, 3, 17, 0, 0, 0, 0)
        '
        'UltraLabel11
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Appearance88.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance88
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(22, 83)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel11.TabIndex = 13
        Me.UltraLabel11.Text = "Origen:"
        '
        'UltraLabel9
        '
        Appearance89.BackColor = System.Drawing.Color.Transparent
        Appearance89.ForeColor = System.Drawing.Color.Navy
        Appearance89.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance89
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(6, 31)
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
        Me.dtSolicita.Location = New System.Drawing.Point(66, 28)
        Me.dtSolicita.MaskInput = ""
        Me.dtSolicita.Name = "dtSolicita"
        Me.dtSolicita.Size = New System.Drawing.Size(80, 21)
        Me.dtSolicita.TabIndex = 5
        Me.dtSolicita.Value = New Date(2015, 3, 17, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Appearance90.BackColor = System.Drawing.Color.Transparent
        Appearance90.ForeColor = System.Drawing.Color.Navy
        Appearance90.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance90
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(21, 7)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Codigo:"
        '
        'txtNumero
        '
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(66, 3)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(120, 21)
        Me.txtNumero.TabIndex = 1
        '
        'txtObservacion
        '
        Me.txtObservacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(6, 127)
        Me.txtObservacion.MaxLength = 500
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(819, 21)
        Me.txtObservacion.TabIndex = 25
        UltraToolTipInfo5.ToolTipText = "Ingrese observacion"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtObservacion, UltraToolTipInfo5)
        '
        'UltraLabel10
        '
        Appearance91.BackColor = System.Drawing.Color.Transparent
        Appearance91.ForeColor = System.Drawing.Color.Navy
        Appearance91.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance91
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(449, 34)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel10.TabIndex = 19
        Me.UltraLabel10.Text = "Tipo Vehículo:"
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
        Me.ficDemanda.Size = New System.Drawing.Size(1348, 625)
        Me.ficDemanda.TabIndex = 0
        UltraTab5.Key = "Lista"
        UltraTab5.TabPage = Me.UltraTabPageControl7
        UltraTab5.Text = "Lista"
        UltraTab6.Key = "Mantenimiento"
        UltraTab6.TabPage = Me.utpDetalle
        UltraTab6.Text = "Mantenimiento"
        Me.ficDemanda.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        Me.ficDemanda.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1346, 602)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'frm_DemandaRapida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 625)
        Me.Controls.Add(Me.ficDemanda)
        Me.Name = "frm_DemandaRapida"
        Me.Text = "Pre Demanda"
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaRegistro.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.ogdLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.exgruFlete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruFlete.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        CType(Me.griTarifasProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.txtGlosaCostoEstibaDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCostoEstivaDescarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivoConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCostoEstiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIGVConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        CType(Me.txtTelfDescarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelfCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContactoDescarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContactoCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDireccionLLegada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDireccionPartida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox14.ResumeLayout(False)
        Me.UltraGroupBox14.PerformLayout()
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
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.PerformLayout()
        CType(Me.chkIndPlantilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTercero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaternoContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoPaternoContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucEmpresaTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacionTercero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferenciaTercero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonedaT, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.cboUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        Me.UltraGroupBox13.PerformLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.numDiasAntes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorPorVencer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorVencidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.VerAsignada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCancelada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAsignada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorGenerada, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.cboDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNroUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NroDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivoEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaAtencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSolicita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDemanda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ogdLista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents imagenes As System.Windows.Forms.ImageList

    Friend WithEvents ficDemanda As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents colorAsignada As ISL.Controles.Colores
    Friend WithEvents colorGenerada As ISL.Controles.Colores
    Shadows WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents Insert As System.Windows.Forms.ToolStripMenuItem
    Shadows WithEvents Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents GenerarDemanda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents colorCancelada As ISL.Controles.Colores
    Friend WithEvents etiCancelada As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents colorVencidas As ISL.Controles.Colores
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents colorPorVencer As ISL.Controles.Colores
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtSolicita As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNumero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents numDiasAntes As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents colorCambio As ISL.Controles.Colores
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents UltraExpandableGroupBox9 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel9 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtObservacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tabs As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griDetalleTercero As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents numCantidadTercero As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel66 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numSubTotalTercero As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel67 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtObservacionTercero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel43 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtReferenciaTercero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents numFleteTotalTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents numIgvTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents cboMonedaT As ISL.Controles.Combo
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numFleteUnitarioTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel33 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numComisionTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel34 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel35 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtFechaAtencion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkEscala As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents tabDemandaCargas As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griLista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griFactura As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtMotivoEscala As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents exgruFlete As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CalFleteUnitario As ISL.Controles.NumeroCalculadora
    Friend WithEvents txtFleteTotalDetalle As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents verCargar As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verDescarga As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verPagoContraEntrega As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verIncluyeIgv As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CalFleteUnitarioIGV As ISL.Controles.NumeroCalculadora
    Friend WithEvents UltraGroupBox14 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents txtComisionTotal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtFleteTotal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verFacturado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtComision As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verValidaFU As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel37 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents exgruDetalle As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCantidad As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblClienteFinal As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtMotivoConsolidado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtConsolidado As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents chkConsolidado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents numNroUnidades As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents lblNumeroDemanda As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents NroDemanda As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents cboTipoVehiculo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboOrigen As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboDestino As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboEscala As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboMaterial As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboTipoCarga As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboClienteFinal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboComisionista As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtRucComisionista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtRucCLienteFinal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtRucCLiente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCostoEstiba As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents chkCostoEstiva As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkIGVConsolidado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtTelefonoComisionista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboDestinoDetalle As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboOrigenDetalle As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNombreComisonista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtApellidoPaternoComisionista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtApellidoMaterno As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtSubtotal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents lblSubtotal As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboDireccionLLegada As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboDireccionPartida As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboUsuario As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel62 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAgregarTecero As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtAdelantoFlete As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboContacto As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents EnviarCorreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCostoEstibaDescarga As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents chkCostoEstivaDescarga As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents VerAsignada As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verViajeRetorno As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtRucEmpresaTransportista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtFechaRecepcion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents opPagoCont As ISL.Controles.Opciones
    Friend WithEvents udtHoraSolicita As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udtHoraAtencion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udtHoraRecepcion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtGlosaCostoEstibaDesc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkTercerizacion As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtRucContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtApellidoMaternoContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNombreContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtApellidoPaternoContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTelefonoContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboTercero As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents griTarifasProveedor As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chkTercerizadoFiltro As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkIndFalsoFlete As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkExcluirDemandas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents EditarDetalleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoDetalleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel40 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTelfDescarga As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTelfCarga As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboContactoDescarga As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboContactoCarga As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel38 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents RevertirDemandaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents chkIndPlantilla As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ProgramarViajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
