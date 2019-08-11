<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConfirmarCargaOperacionGRT
    Inherits System.Windows.Forms.Form

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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteCalcular")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemandaDetalle")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasCarga")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasDescarga")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cargar")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descarga")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPesoTnDescarga")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoCarga")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subtotal")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoEstiba")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoEstibaDescarga")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AdelantoFlete")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgvConsolidado")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoEfectivoDeposito")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MotivoConsolidado")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FalsoFlete")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConfirmarCargaOperacionGRT))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcular")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemandaDetalle")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasCarga")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasDescarga")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargar")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descarga")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPesoTnDescarga")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoCarga")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstiba")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstibaDescarga")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgvConsolidado")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoEfectivoDeposito")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoConsolidado")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FalsoFlete")
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcular")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemandaDetalle")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasCarga")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasDescarga")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargar")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descarga")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPesoTnDescarga")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoCarga")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstiba")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstibaDescarga")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgvConsolidado")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoEfectivoDeposito")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoConsolidado")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FalsoFlete")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ogdOperacionDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.exgruOperacion = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.btnAceptar = New ISL.Controles.Boton(Me.components)
        Me.exgruViaje = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.griViajeDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.fecViaje = New ISL.Controles.Fecha(Me.components)
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtViajeEscala = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdOperacionDetalle = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdSeguimiento = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeCopiloto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigoViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeCarreta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel36 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigoOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeTracto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajePiloto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griCargasConfirmadas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruOperacion.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruViaje.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.griViajeDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeCopiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajePiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.griCargasConfirmadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ogdOperacionDetalle
        '
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Boolean)
        UltraDataColumn9.DataType = GetType(Boolean)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Object)
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Boolean)
        Me.ogdOperacionDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43})
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Empty
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
        Me.imagenes.Images.SetKeyName(12, "empView.ico")
        '
        'exgruOperacion
        '
        Me.exgruOperacion.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.exgruOperacion.ContentAreaAppearance = Appearance1
        Me.exgruOperacion.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.exgruOperacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruOperacion.ExpandedSize = New System.Drawing.Size(984, 200)
        Me.exgruOperacion.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruOperacion.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.exgruOperacion.Location = New System.Drawing.Point(0, 0)
        Me.exgruOperacion.Name = "exgruOperacion"
        Me.exgruOperacion.Size = New System.Drawing.Size(984, 200)
        Me.exgruOperacion.TabIndex = 5
        Me.exgruOperacion.Text = "DATOS CARGA A CONFIRMAR"
        Me.exgruOperacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ugb_Espera)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnCancelar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnAceptar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.exgruViaje)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(978, 177)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(67, 109)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 14
        Me.ugb_Espera.Visible = False
        '
        'btnCancelar
        '
        Appearance2.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        Me.btnCancelar.Appearance = Appearance2
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCancelar.Location = New System.Drawing.Point(484, 136)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Appearance3.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnAceptar.Appearance = Appearance3
        Me.btnAceptar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAceptar.Location = New System.Drawing.Point(368, 136)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "&Aceptar"
        '
        'exgruViaje
        '
        Me.exgruViaje.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.BackColor2 = System.Drawing.Color.White
        Me.exgruViaje.ContentAreaAppearance = Appearance4
        Me.exgruViaje.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.exgruViaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruViaje.ExpandedSize = New System.Drawing.Size(978, 135)
        Me.exgruViaje.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.exgruViaje.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.exgruViaje.Location = New System.Drawing.Point(0, 0)
        Me.exgruViaje.Name = "exgruViaje"
        Me.exgruViaje.Size = New System.Drawing.Size(978, 135)
        Me.exgruViaje.TabIndex = 4
        Me.exgruViaje.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel21)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.griViajeDetalle)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.fecViaje)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel20)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeEscala)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdOperacionDetalle)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdSeguimiento)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdOperacion)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtIdViaje)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeCopiloto)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel17)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel9)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtCodigoViaje)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeCarreta)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel36)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel10)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtCodigoOperacion)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajeTracto)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtViajePiloto)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel6)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(972, 129)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'UltraLabel21
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Appearance5.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance5
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(301, 7)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel21.TabIndex = 5
        Me.UltraLabel21.Text = "Fecha:"
        '
        'griViajeDetalle
        '
        Me.griViajeDetalle.DataSource = Me.ogdOperacionDetalle
        Appearance6.BackColor = System.Drawing.Color.White
        Me.griViajeDetalle.DisplayLayout.Appearance = Appearance6
        UltraGridColumn141.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn141.Header.VisiblePosition = 1
        UltraGridColumn141.Hidden = True
        UltraGridColumn142.Header.VisiblePosition = 21
        UltraGridColumn142.Hidden = True
        UltraGridColumn142.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn142.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn142.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn142.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn143.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn143.Header.VisiblePosition = 0
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn144.Header.VisiblePosition = 4
        UltraGridColumn144.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn144.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn144.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(238, 0)
        UltraGridColumn144.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn144.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn144.Width = 200
        UltraGridColumn145.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn145.Header.VisiblePosition = 5
        UltraGridColumn145.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn145.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn145.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn145.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn145.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn145.Width = 100
        UltraGridColumn146.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn146.CellAppearance = Appearance7
        UltraGridColumn146.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn146.Header.VisiblePosition = 7
        UltraGridColumn146.MaskInput = "{double:4.3}"
        UltraGridColumn146.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn146.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn146.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(93, 0)
        UltraGridColumn146.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn146.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn146.Width = 45
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn147.CellAppearance = Appearance8
        UltraGridColumn147.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn147.Header.VisiblePosition = 10
        UltraGridColumn147.MaskInput = "{LOC}nnn,nnn.nnnn"
        UltraGridColumn147.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn147.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn147.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(93, 0)
        UltraGridColumn147.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn147.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn147.Width = 71
        UltraGridColumn148.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn148.Header.VisiblePosition = 12
        UltraGridColumn148.Hidden = True
        UltraGridColumn148.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn148.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn148.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(60, 0)
        UltraGridColumn148.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn148.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn148.Width = 48
        UltraGridColumn149.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn149.Header.Caption = "Cont.Ent."
        UltraGridColumn149.Header.VisiblePosition = 15
        UltraGridColumn149.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn149.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn149.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(60, 0)
        UltraGridColumn149.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn149.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn149.Width = 45
        UltraGridColumn150.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn150.Header.VisiblePosition = 6
        UltraGridColumn150.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn150.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn150.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn150.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn150.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn150.Width = 150
        UltraGridColumn151.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn151.CellAppearance = Appearance9
        UltraGridColumn151.Header.VisiblePosition = 9
        UltraGridColumn151.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn151.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn151.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn151.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn151.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn151.Width = 40
        UltraGridColumn152.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance10.BackColor = System.Drawing.Color.LemonChiffon
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn152.CellAppearance = Appearance10
        UltraGridColumn152.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn152.Format = "#,###,##0.00"
        UltraGridColumn152.Header.VisiblePosition = 14
        UltraGridColumn152.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn152.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn152.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn152.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn152.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn152.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn152.Width = 88
        UltraGridColumn153.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn153.Header.VisiblePosition = 16
        UltraGridColumn153.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn153.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn153.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(210, 0)
        UltraGridColumn153.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn153.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn153.Width = 200
        UltraGridColumn154.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance11.BackColor = System.Drawing.Color.LemonChiffon
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn154.CellAppearance = Appearance11
        UltraGridColumn154.Format = "#,##0.00"
        UltraGridColumn154.Header.VisiblePosition = 17
        UltraGridColumn154.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn154.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn154.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn154.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn154.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn154.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn154.Width = 66
        UltraGridColumn155.Header.VisiblePosition = 18
        UltraGridColumn155.Hidden = True
        UltraGridColumn156.Header.VisiblePosition = 19
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.Header.VisiblePosition = 20
        UltraGridColumn157.Hidden = True
        UltraGridColumn158.Header.VisiblePosition = 22
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 24
        UltraGridColumn159.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn159.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn159.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(126, 0)
        UltraGridColumn159.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn159.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn159.Width = 150
        UltraGridColumn160.Header.VisiblePosition = 25
        UltraGridColumn160.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn160.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn160.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(126, 0)
        UltraGridColumn160.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn160.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn160.Width = 150
        UltraGridColumn161.Header.Caption = "I.Igv"
        UltraGridColumn161.Header.VisiblePosition = 13
        UltraGridColumn161.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn161.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn161.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn161.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn161.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn161.Width = 25
        UltraGridColumn162.Header.VisiblePosition = 26
        UltraGridColumn162.Hidden = True
        UltraGridColumn162.MaskInput = "{double:2.4}"
        UltraGridColumn163.Header.VisiblePosition = 3
        UltraGridColumn163.Width = 200
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn164.CellAppearance = Appearance12
        UltraGridColumn164.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn164.Header.Caption = "Peso TM Carga"
        UltraGridColumn164.Header.VisiblePosition = 27
        UltraGridColumn164.Hidden = True
        UltraGridColumn164.MaskInput = "{double:2.4}"
        UltraGridColumn164.Width = 72
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn165.CellAppearance = Appearance13
        UltraGridColumn165.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn165.Format = ""
        UltraGridColumn165.Header.Caption = "Peso TM"
        UltraGridColumn165.Header.VisiblePosition = 8
        UltraGridColumn165.MaskInput = "{double:4.3}"
        UltraGridColumn165.Width = 50
        UltraGridColumn166.Header.VisiblePosition = 28
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn167.Header.VisiblePosition = 29
        UltraGridColumn167.Hidden = True
        UltraGridColumn167.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn167.Width = 50
        UltraGridColumn168.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn168.Header.VisiblePosition = 30
        UltraGridColumn168.Hidden = True
        UltraGridColumn168.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn168.Width = 50
        UltraGridColumn169.Header.VisiblePosition = 31
        UltraGridColumn169.Hidden = True
        UltraGridColumn169.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn170.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn170.Header.VisiblePosition = 2
        UltraGridColumn170.Hidden = True
        UltraGridColumn170.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn170.Width = 20
        UltraGridColumn171.Header.VisiblePosition = 32
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.Header.VisiblePosition = 33
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 34
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.Header.VisiblePosition = 35
        UltraGridColumn174.Hidden = True
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn175.CellAppearance = Appearance14
        UltraGridColumn175.Format = "###,###,##0"
        UltraGridColumn175.Header.VisiblePosition = 36
        UltraGridColumn175.Hidden = True
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn1.CellAppearance = Appearance15
        UltraGridColumn1.Format = "###,##0.0000"
        UltraGridColumn1.Header.VisiblePosition = 11
        UltraGridColumn3.Header.VisiblePosition = 37
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 38
        UltraGridColumn4.Hidden = True
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance16
        UltraGridColumn5.Format = "###,###.##0"
        UltraGridColumn5.Header.VisiblePosition = 23
        UltraGridColumn6.Header.VisiblePosition = 39
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 40
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 41
        UltraGridColumn8.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 42
        UltraGridColumn15.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn1, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn15})
        UltraGridBand1.SummaryFooterCaption = "Totales:"
        Me.griViajeDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griViajeDetalle.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griViajeDetalle.DisplayLayout.GroupByBox.Hidden = True
        Me.griViajeDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajeDetalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.griViajeDetalle.DisplayLayout.Override.CardAreaAppearance = Appearance17
        Me.griViajeDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griViajeDetalle.DisplayLayout.Override.CellPadding = 2
        Me.griViajeDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance18.TextHAlignAsString = "Left"
        Me.griViajeDetalle.DisplayLayout.Override.HeaderAppearance = Appearance18
        Me.griViajeDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajeDetalle.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance19.TextVAlignAsString = "Middle"
        Me.griViajeDetalle.DisplayLayout.Override.RowAppearance = Appearance19
        Me.griViajeDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griViajeDetalle.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajeDetalle.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajeDetalle.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griViajeDetalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griViajeDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajeDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.griViajeDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajeDetalle.Location = New System.Drawing.Point(0, 54)
        Me.griViajeDetalle.Name = "griViajeDetalle"
        Me.griViajeDetalle.Size = New System.Drawing.Size(972, 75)
        Me.griViajeDetalle.TabIndex = 1
        Me.griViajeDetalle.Tag = ""
        '
        'fecViaje
        '
        Appearance20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecViaje.Appearance = Appearance20
        Me.fecViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecViaje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecViaje.Location = New System.Drawing.Point(343, 3)
        Me.fecViaje.Name = "fecViaje"
        Me.fecViaje.Size = New System.Drawing.Size(80, 21)
        Me.fecViaje.TabIndex = 6
        '
        'UltraLabel20
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Appearance21.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance21
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(299, 30)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel20.TabIndex = 20
        Me.UltraLabel20.Text = "Escala:"
        '
        'txtViajeEscala
        '
        Me.txtViajeEscala.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeEscala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeEscala.Location = New System.Drawing.Point(343, 26)
        Me.txtViajeEscala.Name = "txtViajeEscala"
        Me.txtViajeEscala.ReadOnly = True
        Me.txtViajeEscala.Size = New System.Drawing.Size(200, 21)
        Me.txtViajeEscala.TabIndex = 21
        '
        'txtIdOperacionDetalle
        '
        Me.txtIdOperacionDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacionDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacionDetalle.Location = New System.Drawing.Point(854, 26)
        Me.txtIdOperacionDetalle.Name = "txtIdOperacionDetalle"
        Me.txtIdOperacionDetalle.ReadOnly = True
        Me.txtIdOperacionDetalle.Size = New System.Drawing.Size(22, 21)
        Me.txtIdOperacionDetalle.TabIndex = 15
        Me.txtIdOperacionDetalle.Visible = False
        '
        'txtIdSeguimiento
        '
        Me.txtIdSeguimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSeguimiento.Location = New System.Drawing.Point(904, 26)
        Me.txtIdSeguimiento.Name = "txtIdSeguimiento"
        Me.txtIdSeguimiento.ReadOnly = True
        Me.txtIdSeguimiento.Size = New System.Drawing.Size(21, 21)
        Me.txtIdSeguimiento.TabIndex = 14
        Me.txtIdSeguimiento.Visible = False
        '
        'txtIdOperacion
        '
        Me.txtIdOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacion.Location = New System.Drawing.Point(881, 26)
        Me.txtIdOperacion.Name = "txtIdOperacion"
        Me.txtIdOperacion.ReadOnly = True
        Me.txtIdOperacion.Size = New System.Drawing.Size(21, 21)
        Me.txtIdOperacion.TabIndex = 13
        Me.txtIdOperacion.Visible = False
        '
        'txtIdViaje
        '
        Me.txtIdViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdViaje.Location = New System.Drawing.Point(6, 26)
        Me.txtIdViaje.Name = "txtIdViaje"
        Me.txtIdViaje.ReadOnly = True
        Me.txtIdViaje.Size = New System.Drawing.Size(21, 21)
        Me.txtIdViaje.TabIndex = 2
        Me.txtIdViaje.Visible = False
        '
        'txtViajeCopiloto
        '
        Me.txtViajeCopiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCopiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeCopiloto.Location = New System.Drawing.Point(601, 26)
        Me.txtViajeCopiloto.Name = "txtViajeCopiloto"
        Me.txtViajeCopiloto.ReadOnly = True
        Me.txtViajeCopiloto.Size = New System.Drawing.Size(250, 21)
        Me.txtViajeCopiloto.TabIndex = 1
        '
        'UltraLabel17
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Appearance22.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance22
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(548, 30)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel17.TabIndex = 0
        Me.UltraLabel17.Text = "CoPiloto:"
        '
        'UltraLabel3
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Appearance23.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance23
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(28, 30)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel3.TabIndex = 3
        Me.UltraLabel3.Text = "Viaje:"
        '
        'UltraLabel9
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Appearance24.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance24
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(177, 30)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel9.TabIndex = 11
        Me.UltraLabel9.Text = "Carreta:"
        '
        'txtCodigoViaje
        '
        Me.txtCodigoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoViaje.Location = New System.Drawing.Point(64, 26)
        Me.txtCodigoViaje.Name = "txtCodigoViaje"
        Me.txtCodigoViaje.ReadOnly = True
        Me.txtCodigoViaje.Size = New System.Drawing.Size(110, 21)
        Me.txtCodigoViaje.TabIndex = 7
        '
        'txtViajeCarreta
        '
        Me.txtViajeCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeCarreta.Location = New System.Drawing.Point(225, 26)
        Me.txtViajeCarreta.Name = "txtViajeCarreta"
        Me.txtViajeCarreta.ReadOnly = True
        Me.txtViajeCarreta.Size = New System.Drawing.Size(70, 21)
        Me.txtViajeCarreta.TabIndex = 12
        '
        'UltraLabel36
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextVAlignAsString = "Middle"
        Me.UltraLabel36.Appearance = Appearance25
        Me.UltraLabel36.AutoSize = True
        Me.UltraLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel36.Location = New System.Drawing.Point(1, 7)
        Me.UltraLabel36.Name = "UltraLabel36"
        Me.UltraLabel36.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel36.TabIndex = 0
        Me.UltraLabel36.Text = "Operacion:"
        '
        'UltraLabel10
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Appearance26.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance26
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(183, 7)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel10.TabIndex = 9
        Me.UltraLabel10.Text = "Tracto:"
        '
        'txtCodigoOperacion
        '
        Me.txtCodigoOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoOperacion.Location = New System.Drawing.Point(64, 3)
        Me.txtCodigoOperacion.Name = "txtCodigoOperacion"
        Me.txtCodigoOperacion.ReadOnly = True
        Me.txtCodigoOperacion.Size = New System.Drawing.Size(110, 21)
        Me.txtCodigoOperacion.TabIndex = 8
        '
        'txtViajeTracto
        '
        Me.txtViajeTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeTracto.Location = New System.Drawing.Point(225, 3)
        Me.txtViajeTracto.Name = "txtViajeTracto"
        Me.txtViajeTracto.ReadOnly = True
        Me.txtViajeTracto.Size = New System.Drawing.Size(70, 21)
        Me.txtViajeTracto.TabIndex = 10
        '
        'txtViajePiloto
        '
        Me.txtViajePiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajePiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajePiloto.Location = New System.Drawing.Point(601, 3)
        Me.txtViajePiloto.Name = "txtViajePiloto"
        Me.txtViajePiloto.ReadOnly = True
        Me.txtViajePiloto.Size = New System.Drawing.Size(250, 21)
        Me.txtViajePiloto.TabIndex = 23
        '
        'UltraLabel6
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Appearance27.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance27
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(561, 7)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel6.TabIndex = 22
        Me.UltraLabel6.Text = "Piloto:"
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance28.BackColor = System.Drawing.Color.White
        Appearance28.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance28
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(984, 161)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 200)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(984, 161)
        Me.UltraExpandableGroupBox1.TabIndex = 6
        Me.UltraExpandableGroupBox1.Text = "CARGAS DE LA OPERACION CONFIRMADAS"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.griCargasConfirmadas)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(978, 138)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'griCargasConfirmadas
        '
        Me.griCargasConfirmadas.DataSource = Me.ogdOperacionDetalle
        Appearance29.BackColor = System.Drawing.Color.White
        Me.griCargasConfirmadas.DisplayLayout.Appearance = Appearance29
        UltraGridColumn176.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn176.Header.VisiblePosition = 1
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 21
        UltraGridColumn177.Hidden = True
        UltraGridColumn177.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn177.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn177.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn177.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn178.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn178.Header.VisiblePosition = 0
        UltraGridColumn178.Hidden = True
        UltraGridColumn179.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn179.Header.VisiblePosition = 4
        UltraGridColumn179.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn179.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn179.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(238, 0)
        UltraGridColumn179.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn179.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn179.Width = 200
        UltraGridColumn180.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn180.Header.VisiblePosition = 5
        UltraGridColumn180.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn180.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn180.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn180.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn180.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn180.Width = 100
        UltraGridColumn181.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn181.CellAppearance = Appearance30
        UltraGridColumn181.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn181.Header.VisiblePosition = 7
        UltraGridColumn181.MaskInput = "{double:4.3}"
        UltraGridColumn181.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn181.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn181.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(93, 0)
        UltraGridColumn181.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn181.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn181.Width = 45
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn182.CellAppearance = Appearance31
        UltraGridColumn182.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn182.Header.VisiblePosition = 10
        UltraGridColumn182.MaskInput = "{LOC}nnn,nnn.nnnn"
        UltraGridColumn182.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn182.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn182.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(93, 0)
        UltraGridColumn182.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn182.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn182.Width = 71
        UltraGridColumn183.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn183.Header.VisiblePosition = 12
        UltraGridColumn183.Hidden = True
        UltraGridColumn183.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn183.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn183.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(60, 0)
        UltraGridColumn183.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn183.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn183.Width = 48
        UltraGridColumn184.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn184.Header.Caption = "Cont.Ent."
        UltraGridColumn184.Header.VisiblePosition = 15
        UltraGridColumn184.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn184.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn184.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(60, 0)
        UltraGridColumn184.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn184.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn184.Width = 45
        UltraGridColumn185.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn185.Header.VisiblePosition = 6
        UltraGridColumn185.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn185.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn185.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn185.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn185.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn185.Width = 150
        UltraGridColumn186.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance32.TextHAlignAsString = "Center"
        UltraGridColumn186.CellAppearance = Appearance32
        UltraGridColumn186.Header.VisiblePosition = 9
        UltraGridColumn186.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn186.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn186.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn186.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn186.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn186.Width = 40
        UltraGridColumn187.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance33.BackColor = System.Drawing.Color.LemonChiffon
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn187.CellAppearance = Appearance33
        UltraGridColumn187.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn187.Format = "#,###,##0.00"
        UltraGridColumn187.Header.VisiblePosition = 14
        UltraGridColumn187.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn187.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn187.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn187.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn187.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn187.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn187.Width = 88
        UltraGridColumn188.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn188.Header.VisiblePosition = 16
        UltraGridColumn188.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn188.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn188.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(210, 0)
        UltraGridColumn188.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn188.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn188.Width = 200
        UltraGridColumn189.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance34.BackColor = System.Drawing.Color.LemonChiffon
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn189.CellAppearance = Appearance34
        UltraGridColumn189.Format = "#,##0.00"
        UltraGridColumn189.Header.VisiblePosition = 17
        UltraGridColumn189.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn189.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn189.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn189.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn189.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn189.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn189.Width = 66
        UltraGridColumn190.Header.VisiblePosition = 18
        UltraGridColumn190.Hidden = True
        UltraGridColumn191.Header.VisiblePosition = 19
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.VisiblePosition = 20
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.VisiblePosition = 22
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 24
        UltraGridColumn194.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn194.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn194.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(126, 0)
        UltraGridColumn194.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn194.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn194.Width = 150
        UltraGridColumn195.Header.VisiblePosition = 25
        UltraGridColumn195.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn195.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn195.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(126, 0)
        UltraGridColumn195.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn195.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn195.Width = 150
        UltraGridColumn196.Header.Caption = "I.Igv"
        UltraGridColumn196.Header.VisiblePosition = 13
        UltraGridColumn196.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn196.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn196.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn196.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn196.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn196.Width = 25
        UltraGridColumn197.Header.VisiblePosition = 26
        UltraGridColumn197.Hidden = True
        UltraGridColumn197.MaskInput = "{double:2.4}"
        UltraGridColumn198.Header.VisiblePosition = 3
        UltraGridColumn198.Width = 200
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn199.CellAppearance = Appearance35
        UltraGridColumn199.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn199.Header.Caption = "Peso TM Carga"
        UltraGridColumn199.Header.VisiblePosition = 27
        UltraGridColumn199.Hidden = True
        UltraGridColumn199.MaskInput = "{double:2.4}"
        UltraGridColumn199.Width = 72
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn200.CellAppearance = Appearance36
        UltraGridColumn200.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn200.Format = ""
        UltraGridColumn200.Header.Caption = "Peso TM"
        UltraGridColumn200.Header.VisiblePosition = 8
        UltraGridColumn200.MaskInput = "{double:4.3}"
        UltraGridColumn200.Width = 50
        UltraGridColumn201.Header.VisiblePosition = 28
        UltraGridColumn201.Hidden = True
        UltraGridColumn202.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn202.Header.VisiblePosition = 29
        UltraGridColumn202.Hidden = True
        UltraGridColumn202.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn202.Width = 50
        UltraGridColumn203.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn203.Header.VisiblePosition = 30
        UltraGridColumn203.Hidden = True
        UltraGridColumn203.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn203.Width = 50
        UltraGridColumn204.Header.VisiblePosition = 31
        UltraGridColumn204.Hidden = True
        UltraGridColumn204.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn205.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn205.Header.VisiblePosition = 2
        UltraGridColumn205.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn205.Width = 20
        UltraGridColumn206.Header.VisiblePosition = 32
        UltraGridColumn206.Hidden = True
        UltraGridColumn207.Header.VisiblePosition = 33
        UltraGridColumn207.Hidden = True
        UltraGridColumn208.Header.VisiblePosition = 34
        UltraGridColumn208.Hidden = True
        UltraGridColumn209.Header.VisiblePosition = 35
        UltraGridColumn209.Hidden = True
        UltraGridColumn210.Header.VisiblePosition = 36
        UltraGridColumn210.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 11
        UltraGridColumn9.Header.VisiblePosition = 37
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 38
        UltraGridColumn10.Hidden = True
        Appearance37.TextHAlignAsString = "Right"
        UltraGridColumn11.CellButtonAppearance = Appearance37
        UltraGridColumn11.Header.VisiblePosition = 23
        UltraGridColumn12.Header.VisiblePosition = 39
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 40
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 41
        UltraGridColumn14.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 42
        UltraGridColumn16.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn2, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn16})
        UltraGridBand2.SummaryFooterCaption = "Totales:"
        Me.griCargasConfirmadas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griCargasConfirmadas.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griCargasConfirmadas.DisplayLayout.GroupByBox.Hidden = True
        Me.griCargasConfirmadas.DisplayLayout.MaxColScrollRegions = 1
        Me.griCargasConfirmadas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Me.griCargasConfirmadas.DisplayLayout.Override.CardAreaAppearance = Appearance38
        Me.griCargasConfirmadas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griCargasConfirmadas.DisplayLayout.Override.CellPadding = 2
        Me.griCargasConfirmadas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance39.TextHAlignAsString = "Left"
        Me.griCargasConfirmadas.DisplayLayout.Override.HeaderAppearance = Appearance39
        Me.griCargasConfirmadas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griCargasConfirmadas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance40.TextVAlignAsString = "Middle"
        Me.griCargasConfirmadas.DisplayLayout.Override.RowAppearance = Appearance40
        Me.griCargasConfirmadas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griCargasConfirmadas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCargasConfirmadas.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griCargasConfirmadas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griCargasConfirmadas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griCargasConfirmadas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griCargasConfirmadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCargasConfirmadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCargasConfirmadas.Location = New System.Drawing.Point(0, 0)
        Me.griCargasConfirmadas.Name = "griCargasConfirmadas"
        Me.griCargasConfirmadas.Size = New System.Drawing.Size(978, 138)
        Me.griCargasConfirmadas.TabIndex = 1
        Me.griCargasConfirmadas.Tag = ""
        '
        'frm_ConfirmarCargaOperacionGRT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 361)
        Me.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Controls.Add(Me.exgruOperacion)
        Me.Name = "frm_ConfirmarCargaOperacionGRT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfirmarCargaOperacionGRT"
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruOperacion.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruViaje.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.griViajeDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdOperacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeCopiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajePiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.griCargasConfirmadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ogdOperacionDetalle As ISL.Controles.OrigenDatos
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents exgruOperacion As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griCargasConfirmadas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griViajeDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents exgruViaje As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecViaje As ISL.Controles.Fecha
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajeEscala As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdOperacionDetalle As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdSeguimiento As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeCopiloto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigoViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeCarreta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel36 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigoOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeTracto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajePiloto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents btnAceptar As ISL.Controles.Boton
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
