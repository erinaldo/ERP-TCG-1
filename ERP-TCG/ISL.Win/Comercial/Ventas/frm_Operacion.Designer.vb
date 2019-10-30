<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Operacion
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
        Dim UltraToolTipInfo24 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Bonificacion Tracto", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance369 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Operacion))
        Dim Appearance370 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1020 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1021 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn1022 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim Appearance371 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance372 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1023 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje")
        Dim Appearance373 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1024 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBonificacion")
        Dim UltraGridColumn1025 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1026 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1373)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-1262)
        Dim Appearance374 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance375 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo25 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Bonificacion Tracto", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraDataColumn355 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn356 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn357 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn358 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Porcentaje")
        Dim UltraDataColumn359 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndBonificacion")
        Dim UltraDataColumn360 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn361 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance376 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1027 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1028 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn1029 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance377 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance378 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1030 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje")
        Dim Appearance379 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1031 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBonificacion")
        Dim UltraGridColumn1032 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1033 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim ColScrollRegion3 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1366)
        Dim ColScrollRegion4 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-1255)
        Dim Appearance380 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance381 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo26 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Bonificacion Carreta", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraDataColumn362 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn363 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn364 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn365 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Porcentaje")
        Dim UltraDataColumn366 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndBonificacion")
        Dim UltraDataColumn367 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn368 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance382 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance383 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo27 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Tara Carreta (Kg)", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance384 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance385 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance386 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance387 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance388 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo28 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Tara Tracto (Kg)", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance389 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1034 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn1035 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden")
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1036 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Orden")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Justificacion de Escala", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1037 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoRuta")
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1038 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("20M3")
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1039 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("30M3")
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1040 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("40M3")
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1041 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("50M3")
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1042 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("65M3")
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoRuta")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("20M3")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("30M3")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("40M3")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("50M3")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("65M3")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn620 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn621 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn622 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn623 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn624 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn625 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn626 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn627 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn628 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn629 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn630 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn631 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn632 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn633 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn634 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn635 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn636 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn637 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn638 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn639 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn640 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn641 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn642 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn643 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn644 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn645 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn646 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn647 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn648 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn649 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn650 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn651 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn652 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn653 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn654 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn655 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn656 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn657 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn658 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn659 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn660 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn661 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn662 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn663 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn664 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn665 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn666 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn667 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn668 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn669 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn670 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn671 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn672 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn673 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn674 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn675 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn676 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn677 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn678 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn679 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn680 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn681 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn682 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn683 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn684 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn685 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn686 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn687 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn688 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn689 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn690 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn691 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn692 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn693 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn694 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn695 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn696 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn697 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn698 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn699 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim RowLayout1 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("Operacion")
        Dim RowLayoutColumnInfo1 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOperacion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo2 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Operacion", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo3 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Id", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo4 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Codigo", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo5 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOrigen", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo6 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Origen", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo7 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdDestino", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo8 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Destino", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo9 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEscala", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo10 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Escala", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo11 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeVacio", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo12 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdPiloto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo13 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Piloto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo14 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCopiloto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo15 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Copiloto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo16 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdAyudante", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo17 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Ayudante", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo18 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTracto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo19 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tracto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo20 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCarreta", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo21 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carreta", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo22 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Subtotal", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo23 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TotalFlete", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo24 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEstado", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo25 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Estado", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo26 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Fecha", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo27 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioCreacion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo28 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo29 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Seleccion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo30 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo31 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo32 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleP", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo33 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleC", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo34 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleA", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo35 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cliente", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo36 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo37 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "GlosaEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo38 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaMaterial", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo39 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioModifica", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo40 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo41 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo42 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo43 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo44 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo45 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Flota", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo46 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaOperaciones", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo47 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo48 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Turno", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo49 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DiaNoche", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo50 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PesoToneladas", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo51 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Zona", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo52 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tesoreria", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo53 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo54 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndFecha", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo55 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PorcentajeFlete", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo56 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo57 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo58 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo59 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo60 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoComplejoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo61 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo62 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoCargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo63 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ImpresionGuiaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo64 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaAproximadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo65 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo66 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo67 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoDescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo68 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cantidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo69 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FleteUnitario", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo70 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncluyeIgv", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo71 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Capacidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo72 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndCarga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo73 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Produccion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo74 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeRetorno", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo75 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaCreacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo76 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaModifica", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo77 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndPlanilla", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo78 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCentro", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo79 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTercero", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo80 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Consolidado", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo81 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Comision", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo82 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Comisionista", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subtotal")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEscala")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioSeguimiento")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaOrigen")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaDestino")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaDestino")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaOperaciones")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaSeguimiento")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaNoche")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecha")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoComplejoOrigen")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaOrigen")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoCargaOrigen")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImpresionGuiaOrigen")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaAproximadaDestino")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoDestino")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescargaDestino")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoDescargaDestino")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCarga")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Produccion")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeRetorno")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPlanilla")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTercero")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn700 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn701 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn702 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn703 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn704 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn705 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn706 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn707 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn708 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn709 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn710 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn711 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn712 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn713 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn714 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn715 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn716 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn717 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn718 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn719 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn720 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn721 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn722 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn723 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn724 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn725 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn726 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn727 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn728 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn729 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn730 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn731 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn732 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn733 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn734 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn735 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn736 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn737 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn738 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn739 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn740 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn741 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn742 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn743 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn744 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn745 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim UltraGridColumn746 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn747 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn748 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn749 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn750 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn751 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn752 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn753 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn754 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn755 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn756 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn757 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn758 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn759 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn760 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn761 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn762 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn763 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn764 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn765 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn766 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn767 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn768 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn769 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn770 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn771 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn772 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn773 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn774 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn775 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn776 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn777 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn778 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn779 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim RowLayout2 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("Operacion")
        Dim RowLayoutColumnInfo83 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOperacion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo84 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Operacion", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo85 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Id", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo86 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Codigo", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo87 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOrigen", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo88 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Origen", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo89 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdDestino", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo90 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Destino", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo91 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEscala", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo92 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Escala", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo93 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeVacio", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo94 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdPiloto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo95 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Piloto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo96 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCopiloto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo97 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Copiloto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo98 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdAyudante", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo99 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Ayudante", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo100 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTracto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo101 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tracto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo102 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCarreta", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo103 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carreta", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo104 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Subtotal", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo105 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TotalFlete", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo106 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEstado", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo107 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Estado", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo108 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Fecha", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo109 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioCreacion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo110 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo111 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Seleccion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo112 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo113 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo114 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleP", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo115 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleC", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo116 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleA", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo117 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cliente", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo118 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo119 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "GlosaEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo120 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaMaterial", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo121 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioModifica", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo122 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo123 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo124 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo125 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo126 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo127 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Flota", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo128 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaOperaciones", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo129 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo130 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Turno", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo131 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DiaNoche", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo132 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PesoToneladas", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo133 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Zona", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo134 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tesoreria", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo135 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo136 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndFecha", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo137 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PorcentajeFlete", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo138 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo139 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo140 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo141 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo142 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoComplejoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo143 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo144 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoCargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo145 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ImpresionGuiaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo146 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaAproximadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo147 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo148 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo149 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoDescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo150 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cantidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo151 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FleteUnitario", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo152 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncluyeIgv", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo153 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Capacidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo154 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndCarga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo155 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Produccion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo156 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeRetorno", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo157 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaCreacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo158 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaModifica", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo159 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndPlanilla", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo160 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCentro", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo161 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTercero", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo162 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Consolidado", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo163 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Comision", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo164 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Comisionista", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn780 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn781 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn782 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn783 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn784 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn785 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn786 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn787 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn788 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn789 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn790 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn791 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn792 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn793 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn794 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn795 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn796 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn797 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn798 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn799 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn800 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn801 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn802 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn803 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn804 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn805 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn806 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn807 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn808 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn809 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn810 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn811 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn812 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn813 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn814 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn815 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn816 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn817 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn818 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn819 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn820 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn821 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn822 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn823 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn824 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn825 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn826 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn827 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn828 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn829 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn830 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn831 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn832 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn833 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn834 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn835 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn836 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn837 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn838 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn839 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn840 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn841 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn842 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn843 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn844 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn845 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn846 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn847 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn848 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn849 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn850 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn851 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn852 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn853 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn854 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn855 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn856 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn857 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn858 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn859 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim RowLayout3 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("Operacion")
        Dim RowLayoutColumnInfo165 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOperacion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo166 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Operacion", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo167 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Id", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo168 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Codigo", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo169 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOrigen", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo170 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Origen", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo171 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdDestino", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo172 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Destino", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo173 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEscala", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo174 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Escala", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo175 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeVacio", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo176 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdPiloto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo177 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Piloto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo178 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCopiloto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo179 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Copiloto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo180 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdAyudante", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo181 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Ayudante", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo182 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTracto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo183 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tracto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo184 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCarreta", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo185 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carreta", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo186 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Subtotal", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo187 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TotalFlete", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo188 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEstado", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo189 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Estado", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo190 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Fecha", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo191 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioCreacion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo192 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo193 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Seleccion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo194 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo195 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo196 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleP", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo197 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleC", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo198 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleA", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo199 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cliente", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo200 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo201 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "GlosaEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo202 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaMaterial", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo203 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioModifica", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo204 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo205 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo206 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo207 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo208 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo209 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Flota", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo210 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaOperaciones", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo211 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo212 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Turno", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo213 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DiaNoche", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo214 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PesoToneladas", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo215 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Zona", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo216 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tesoreria", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo217 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo218 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndFecha", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo219 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PorcentajeFlete", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo220 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo221 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo222 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo223 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo224 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoComplejoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo225 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo226 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoCargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo227 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ImpresionGuiaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo228 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaAproximadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo229 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo230 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo231 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoDescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo232 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cantidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo233 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FleteUnitario", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo234 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncluyeIgv", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo235 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Capacidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo236 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndCarga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo237 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Produccion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo238 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeRetorno", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo239 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaCreacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo240 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaModifica", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo241 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndPlanilla", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo242 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCentro", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo243 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTercero", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo244 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Consolidado", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo245 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Comision", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo246 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Comisionista", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn860 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn861 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn862 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn863 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn864 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn865 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn866 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn867 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn868 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn869 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn870 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn871 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn872 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn873 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn874 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn875 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn876 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn877 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn878 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn879 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn880 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn881 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn882 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn883 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn884 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn885 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn886 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn887 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn888 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn889 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn890 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn891 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn892 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn893 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn894 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn895 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn896 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn897 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn898 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn899 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn900 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn901 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn902 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn903 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn904 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn905 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim UltraGridColumn906 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn907 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn908 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn909 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn910 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn911 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim UltraGridColumn912 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn913 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn914 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn915 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn916 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn917 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn918 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn919 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn920 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn921 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn922 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn923 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn924 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn925 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn926 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn927 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn928 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn929 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn930 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn931 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn932 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim UltraGridColumn933 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn934 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn935 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn936 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn937 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn938 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn939 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn940 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn941 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn942 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn943 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn944 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn945 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn946 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn947 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn948 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn949 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn950 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn951 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn952 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn953 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn954 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn955 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn956 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn957 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn958 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn959 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn960 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn961 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn962 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn963 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn964 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn965 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn966 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn967 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn968 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn969 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn970 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn971 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn972 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn973 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn974 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn975 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn976 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn977 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn978 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn979 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn980 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn981 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn982 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn983 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim UltraGridColumn984 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn985 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn986 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn987 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn988 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn989 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn990 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn991 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn992 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn993 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn994 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim UltraGridColumn995 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn996 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn997 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn998 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn999 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn1000 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn1001 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn1002 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn1003 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn1004 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn1005 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn1006 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn1007 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1008 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn1009 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1010 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn1011 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn1012 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1013 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn1014 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1015 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla")
        Dim UltraGridColumn1016 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn1017 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal")
        Dim UltraGridColumn1018 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn1019 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEscala")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioSeguimiento")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaOrigen")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaDestino")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaDestino")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaOperaciones")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaSeguimiento")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaNoche")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecha")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoComplejoOrigen")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaOrigen")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoCargaOrigen")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImpresionGuiaOrigen")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaAproximadaDestino")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoDestino")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescargaDestino")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoDescargaDestino")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCarga")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeRetorno")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Produccion")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPlanilla")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subtotal")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTercero")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo4 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Escala en Bloque", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo5 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Hora de Inicio del Viaje - Salida de Planta", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo6 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Capacidad Util (Kg)", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo7 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("FleteUnitario del Viaje", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("VerTracto")
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo8 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Ingrese Justificacion de Escala Creada", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo9 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Flete del Viaje", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1043 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1044 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn1045 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn1046 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1047 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn1048 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1049 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1050 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn1051 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn1052 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn1053 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn1054 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1055 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn1056 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1057 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn1058 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteCalcular")
        Dim UltraGridColumn1059 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1060 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemandaDetalle")
        Dim UltraGridColumn1061 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1062 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1063 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn1064 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn1065 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1066 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasCarga")
        Dim UltraGridColumn1067 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasDescarga")
        Dim UltraGridColumn1068 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn1069 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargar")
        Dim UltraGridColumn1070 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descarga")
        Dim UltraGridColumn1071 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPesoTnDescarga")
        Dim UltraGridColumn1072 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1073 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn1074 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoCarga")
        Dim UltraGridColumn1075 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1076 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn1077 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1078 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteFinal")
        Dim UltraGridColumn1079 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 0)
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1080 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstiba", 1)
        Dim Appearance214 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1081 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstibaDescarga", 2)
        Dim Appearance215 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1082 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete", 3, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance216 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance217 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1083 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgvConsolidado", 4)
        Dim UltraGridColumn1084 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoEfectivoDeposito", 5)
        Dim UltraGridColumn1085 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoConsolidado", 6)
        Dim Appearance218 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1086 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FalsoFlete", 7)
        Dim Appearance219 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance220 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance221 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn184 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn185 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn186 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn187 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn188 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn189 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteCalcular")
        Dim UltraDataColumn190 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn191 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemandaDetalle")
        Dim UltraDataColumn192 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn193 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn194 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn195 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn196 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn197 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasCarga")
        Dim UltraDataColumn198 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasDescarga")
        Dim UltraDataColumn199 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn200 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cargar")
        Dim UltraDataColumn201 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descarga")
        Dim UltraDataColumn202 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPesoTnDescarga")
        Dim UltraDataColumn203 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn204 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn205 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoCarga")
        Dim UltraDataColumn206 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn207 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn208 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn209 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClienteFinal")
        Dim Appearance222 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1087 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1088 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1089 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn1090 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPreDemanda")
        Dim UltraGridColumn1091 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn1092 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn1093 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn1094 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn1095 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn1096 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1097 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAtendida")
        Dim UltraGridColumn1098 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1099 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalComision")
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn1103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoPreDemanda")
        Dim UltraGridColumn1104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn1106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn1107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn1108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn1109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn1110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn1112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modificado")
        Dim UltraGridColumn1113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoEscala")
        Dim UltraGridColumn1114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCambioADemanda")
        Dim UltraGridColumn1115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn1116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorTercero")
        Dim UltraGridColumn1117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Justificacion")
        Dim UltraGridColumn1118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugarReferencia")
        Dim UltraGridColumn1119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroUnidades")
        Dim UltraGridColumn1120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionLugarPartida")
        Dim UltraGridColumn1121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionLugarLlegada")
        Dim UltraGridColumn1122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn1124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn1125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ObservacionPredemanda")
        Dim UltraGridColumn1126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoPredemanda")
        Dim UltraGridColumn1127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSolicita")
        Dim UltraGridColumn1129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRecepcion")
        Dim UltraGridColumn1130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCancelacion")
        Dim UltraGridColumn1131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn1132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCancelacion", 0)
        Dim UltraDataColumn210 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn211 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn212 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn213 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPreDemanda")
        Dim UltraDataColumn214 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn215 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn216 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn217 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn218 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn219 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn220 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAtendida")
        Dim UltraDataColumn221 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn222 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalComision")
        Dim UltraDataColumn223 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn224 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn225 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn226 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoPreDemanda")
        Dim UltraDataColumn227 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn228 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn229 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn230 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn231 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega")
        Dim UltraDataColumn232 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn233 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn234 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn235 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modificado")
        Dim UltraDataColumn236 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MotivoEscala")
        Dim UltraDataColumn237 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCambioADemanda")
        Dim UltraDataColumn238 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn239 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorTercero")
        Dim UltraDataColumn240 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Justificacion")
        Dim UltraDataColumn241 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugarReferencia")
        Dim UltraDataColumn242 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroUnidades")
        Dim UltraDataColumn243 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDireccionLugarPartida")
        Dim UltraDataColumn244 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDireccionLugarLlegada")
        Dim UltraDataColumn245 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn246 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn247 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn248 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ObservacionPredemanda")
        Dim UltraDataColumn249 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoPredemanda")
        Dim UltraDataColumn250 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Indicador")
        Dim UltraDataColumn251 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaSolicita")
        Dim UltraDataColumn252 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaRecepcion")
        Dim UltraDataColumn253 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCancelacion")
        Dim UltraDataColumn254 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance230 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance231 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance232 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance233 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance234 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance235 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance236 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance237 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance238 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance239 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo10 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Modificar Flete Unitario", Infragistics.Win.ToolTipImage.[Default], "Validar Flete Unitario", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance240 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance241 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim CalculatorButton2 As Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton = New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton(15)
        Dim EditorButton6 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance242 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance243 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance244 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim CalculatorButton3 As Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton = New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton(15)
        Dim EditorButton7 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance245 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance246 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance247 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton8 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarClienteFinal")
        Dim Appearance248 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance249 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance250 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance251 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance252 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance253 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance254 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance255 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance256 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance257 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance258 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance259 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance260 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance261 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton9 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarComisionista")
        Dim Appearance262 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton10 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoComisionista")
        Dim Appearance263 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton11 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarCliente")
        Dim Appearance264 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton12 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoCliente")
        Dim Appearance265 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance266 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance267 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo11 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Comentario de Consolidado", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance268 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance269 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance270 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance271 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance272 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance273 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance274 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn1135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionDetalle")
        Dim UltraGridColumn1136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn1137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContacto", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn1138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn1139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance275 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim Appearance276 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance277 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoFlete")
        Dim Appearance278 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete")
        Dim UltraGridColumn1144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance279 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoComision")
        Dim UltraGridColumn1146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn1147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndOperacion")
        Dim UltraGridColumn1148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn1150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn1151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn1152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn1153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn1154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn1155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn1157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn1158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance280 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance281 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance282 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn255 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn256 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn257 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacionDetalle")
        Dim UltraDataColumn258 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTercero")
        Dim UltraDataColumn259 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdContacto")
        Dim UltraDataColumn260 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn261 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn262 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Igv")
        Dim UltraDataColumn263 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn264 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoFlete")
        Dim UltraDataColumn265 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AdelantoFlete")
        Dim UltraDataColumn266 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn267 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoComision")
        Dim UltraDataColumn268 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFacturado")
        Dim UltraDataColumn269 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndOperacion")
        Dim UltraDataColumn270 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoDocumento")
        Dim UltraDataColumn271 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn272 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn273 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn274 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn275 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn276 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn277 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn278 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn279 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn280 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn281 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim Appearance283 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo12 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Telefono", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim EditorButton13 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnEditarCliente")
        Dim Appearance284 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton14 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btnNuevoCliente")
        Dim Appearance285 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance286 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance287 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo13 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Refencia del Punto de Llegada ", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo14 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Observaciones del Contrato de Terceros", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance288 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance289 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance290 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance291 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance292 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance293 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance294 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance295 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance296 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance297 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance298 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance299 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance300 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance301 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance302 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Estado de un Viaje", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Tipo Vehiculo (Modelo Funcional)", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim CalculatorButton1 As Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton = New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton(15)
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance303 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn1161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn1162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn1164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn1165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn1166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn1167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn1168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn1169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn1170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn1171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn1172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance304 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance305 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn1174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn1175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn1176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn1177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn1178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn1179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn1180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn1181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim UltraGridColumn1182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn1183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn1184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn1185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn1186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn1188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn1189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn1190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn1191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn1192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn1193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn1194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim Appearance306 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance307 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn1197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn1198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn1199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn1200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn1201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn1202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn1203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn1204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn1205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn1206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn1207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn1208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn1209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim UltraGridColumn1210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn1211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim UltraGridColumn1212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim UltraGridColumn1213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim UltraGridColumn1214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim UltraGridColumn1215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim Appearance308 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn1217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn1218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn1219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn1220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn1221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn1222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn1223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn1224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn1225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn1226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn1227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim UltraGridColumn1228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn1229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTercero")
        Dim UltraGridColumn1230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn1231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 0)
        Dim UltraGridColumn1232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno", 1)
        Dim UltraGridColumn1233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion", 2)
        Dim UltraGridColumn1234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica", 3)
        Dim UltraGridColumn1235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPlanilla", 4)
        Dim UltraGridColumn1236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion", 5)
        Dim UltraGridColumn1237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro", 6)
        Dim UltraGridColumn1238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga", 7)
        Dim UltraDataColumn282 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn283 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn284 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn285 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn286 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn287 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn288 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn289 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn290 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn291 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn292 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn293 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn294 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn295 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn296 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn297 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn298 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn299 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn300 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn301 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn302 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn303 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn304 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn305 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn306 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn307 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn308 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn309 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn310 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn311 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn312 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn313 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn314 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn315 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEscala")
        Dim UltraDataColumn316 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn317 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim UltraDataColumn318 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn319 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn320 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioSeguimiento")
        Dim UltraDataColumn321 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaOrigen")
        Dim UltraDataColumn322 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn323 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaDestino")
        Dim UltraDataColumn324 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaDestino")
        Dim UltraDataColumn325 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn326 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim UltraDataColumn327 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn328 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn329 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn330 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaNoche")
        Dim UltraDataColumn331 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaOperaciones")
        Dim UltraDataColumn332 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaSeguimiento")
        Dim UltraDataColumn333 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn334 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn335 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn336 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn337 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn338 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecha")
        Dim UltraDataColumn339 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn340 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoComplejoOrigen")
        Dim UltraDataColumn341 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaOrigen")
        Dim UltraDataColumn342 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoCargaOrigen")
        Dim UltraDataColumn343 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImpresionGuiaOrigen")
        Dim UltraDataColumn344 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaAproximadaDestino")
        Dim UltraDataColumn345 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoDestino")
        Dim UltraDataColumn346 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescargaDestino")
        Dim UltraDataColumn347 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoDescargaDestino")
        Dim UltraDataColumn348 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn349 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn350 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn351 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTercero")
        Dim UltraDataColumn352 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn353 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn354 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim Appearance309 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance310 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance311 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance312 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance313 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance314 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance315 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo15 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el piloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance316 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo16 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el piloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo17 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el copiloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo18 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Color que especifica si el piloto no se encuentra disponible para el viaje", Infragistics.Win.ToolTipImage.[Default], "Mensaje del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance317 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance318 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance319 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance320 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance321 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance322 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance323 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance324 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance325 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance326 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance327 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance328 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance329 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance330 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance331 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance332 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance333 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance334 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance335 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo19 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccionar Zona para", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance336 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance337 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo20 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Seleccionar Tracto para Filtrar su Disponibilidad", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance338 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance339 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance340 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance341 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo21 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Hora de Inicio del Viaje - Salida de Planta", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance342 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance343 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo22 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Validaciones Activas", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance344 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance345 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance346 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance347 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance348 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance349 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance350 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance351 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance352 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance353 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance354 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton15 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance355 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance356 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance357 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance358 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance359 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance360 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance361 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance362 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance363 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance364 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance365 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance366 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo23 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Descripcion de la Operacion", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance367 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance368 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn369 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Selec")
        Dim UltraDataColumn370 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("COD_VEHICULO")
        Dim UltraDataColumn371 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PLACA_VEH")
        Dim UltraDataColumn372 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IND_MOTRIZ")
        Dim UltraDataColumn373 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TIPO_VEH")
        Dim UltraDataColumn374 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MARCA_VEH")
        Dim UltraDataColumn375 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ULT_FEC_OPER")
        Dim UltraDataColumn376 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ULT_DESTINO")
        Dim UltraDataColumn377 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOperacion")
        Dim UltraDataColumn378 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoMantenimiento")
        Dim UltraDataColumn379 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("REFERENCIA")
        Dim UltraDataColumn380 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FECH_REF")
        Dim UltraDataColumn381 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CAN_HOROMETRO")
        Dim UltraDataColumn382 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn383 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ModeloFuncional")
        Dim Appearance390 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance391 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance392 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance393 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance394 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance395 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance396 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance397 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance398 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance399 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance400 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance401 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance402 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance403 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance404 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance405 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance406 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance407 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance408 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance409 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton16 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance410 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance411 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance412 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance413 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim CalculatorButton4 As Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton = New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton(15)
        Dim EditorButton17 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance414 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance415 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton18 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance416 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance417 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance418 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton19 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance419 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance420 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance421 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton20 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance422 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance423 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance424 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance425 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance426 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance427 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance428 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance429 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance430 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance431 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance432 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance433 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraLabel35 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtBonificacionTracto = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.btnCapacidadUtil = New Infragistics.Win.Misc.UltraButton()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.griBonificacionTracto = New ISL.Controles.Grilla(Me.components)
        Me.Calcular1 = New ISL.Controles.Calcular(Me.components)
        Me.ogdBonificacionTracto = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.griBonificacionCarreta = New ISL.Controles.Grilla(Me.components)
        Me.ogdBonificacionCarreta = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtTaraCarreta = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.cboTractoPeso = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCapacidadUtil = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtTaraTracto = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.cboCarretaPeso = New ISL.Controles.Combo(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox12 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griEscala = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuEscala = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdEscala = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.verEscalaBloque = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboEscalaBloque = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtGlosaEscalaBloque = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnAgregaEscala = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTarifas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdTarifas = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.Programar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cancelada = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdListaOperacion = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaTerceros = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajesProceso = New ISL.Controles.Grilla(Me.components)
        Me.UltraExpandableGroupBox5 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel10 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.opcDesenganches = New ISL.Controles.Opciones(Me.components)
        Me.utpTrazabilidad = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTransabilida = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Flota = New System.Windows.Forms.Label()
        Me.cboFlota = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.btnEnviarCorreo = New Infragistics.Win.Misc.UltraButton()
        Me.opTractoCarreta = New ISL.Controles.Opciones(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViaje = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuViaje = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdViaje = New ISL.Controles.OrigenDatos(Me.components)
        Me.expViaje = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel18 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.exgruEscalaBloque = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.tabAdicional = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGroupBox14 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.hViaje = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecViaje = New System.Windows.Forms.DateTimePicker()
        Me.verViajeRetorno = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verFechaViaje = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel37 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboCarreta = New ISL.Controles.Combo(Me.components)
        Me.txtViajeCapacidadUtil = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel38 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtFleteUnitarioViaje = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboOrigen = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtFletePorcentaje = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel40 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboDestino = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtIdViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTracto = New ISL.Controles.Combo(Me.components)
        Me.verEscala = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtCodigoViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboCopiloto = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtGlosaEscala = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFlete = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel()
        Me.verCarreta = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel34 = New Infragistics.Win.Misc.UltraLabel()
        Me.verViajeVacio = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboAyudante = New ISL.Controles.ComboMaestros(Me.components)
        Me.btnAgregarViaje = New Infragistics.Win.Misc.UltraButton()
        Me.cboEscala = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboPiloto = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajeDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuViajeDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuDuplicar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdOperacionDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.expCargaOperacion = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.expListaDemandas = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel16 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griDemanda = New ISL.Controles.Grilla(Me.components)
        Me.ogdDemanda = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraExpandableGroupBox3 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel9 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.lblCodigoDemandaAProgramar = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDemandaProgramar = New Infragistics.Win.Misc.UltraLabel()
        Me.cboZonaDemanda = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel60 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnConsultarDemanda = New Infragistics.Win.Misc.UltraButton()
        Me.expNuevaCarga = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel7 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtRucCLiente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtRucComisionista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.chkIndFalsoFlete = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel68 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtAdelantoFlete = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.verValidaFU = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verIncluyeIgv = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.CalFleteUnitario = New ISL.Controles.NumeroCalculadora(Me.components)
        Me.UltraLabel69 = New Infragistics.Win.Misc.UltraLabel()
        Me.CalFleteUnitarioIGV = New ISL.Controles.NumeroCalculadora(Me.components)
        Me.txtFleteTotalDetalle = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblSubtotal = New Infragistics.Win.Misc.UltraLabel()
        Me.txtSubtotal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.cboClienteFinal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.opPagoCont = New ISL.Controles.Opciones(Me.components)
        Me.verCargar = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verDescarga = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verPagoContraEntrega = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.verFacturado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCantidad = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboMaterial = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboTipoCarga = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboComisionista = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lblClienteFinal = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox10 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtMotivoConsolidado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCostoEstibaDescarga = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.chkConsolidado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtConsolidado = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.chkCostoEstivaDescarga = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkIGVConsolidado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtComision = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.chkCostoEstiva = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtCostoEstiba = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetalleTercero = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuContratoTercero = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DetalleContratoTercero = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdDetalleTercero = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.expContratoTercero = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtTelefonoContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtApellidoMaternoContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNombreContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtApellidoPaternoContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtRucContacto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtRucEmpresaTransportista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboContacto = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboTercero = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.numSubTotalTercero = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel67 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtReferenciaTercero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtObservacionTercero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.numCantidadTercero = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel66 = New Infragistics.Win.Misc.UltraLabel()
        Me.numFleteTotalTerc = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.numIgvTerc = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.cboMonedaT = New ISL.Controles.Combo(Me.components)
        Me.btnAgregarTerc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel42 = New Infragistics.Win.Misc.UltraLabel()
        Me.numFleteUnitarioTerc = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel43 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel44 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel61 = New Infragistics.Win.Misc.UltraLabel()
        Me.numComisionTerc = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel63 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel64 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.tabViajesLista = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraExpandableGroupBox7 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel15 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.decProduccionSinIGV = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decProduccionIGV = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.lblProduccionSinIGV = New Infragistics.Win.Misc.UltraLabel()
        Me.lblProduccionIGV = New Infragistics.Win.Misc.UltraLabel()
        Me.grupoEstado = New ISL.Controles.Agrupacion(Me.components)
        Me.ColorFin = New ISL.Controles.Colores(Me.components)
        Me.ColorProgramado = New ISL.Controles.Colores(Me.components)
        Me.ColorCarga = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTransito = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorDescarga = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.grupoTipoVehiculo = New ISL.Controles.Agrupacion(Me.components)
        Me.Colores6 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta47 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores7 = New ISL.Controles.Colores(Me.components)
        Me.ColorParihuelero = New ISL.Controles.Colores(Me.components)
        Me.Colores8 = New ISL.Controles.Colores(Me.components)
        Me.ColorPlataforma = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta48 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion20M3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta49 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTolvaVolteo = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta52 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores9 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores10 = New ISL.Controles.Colores(Me.components)
        Me.ColorCamion65M3 = New ISL.Controles.Colores(Me.components)
        Me.ColorContenedor = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta222 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorGranelero = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgon = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgonLargo = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamioneta = New ISL.Controles.Colores(Me.components)
        Me.ColorVolquete = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion30M3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCalicera = New ISL.Controles.Colores(Me.components)
        Me.ColorCamion40M3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorMediaBaranda = New ISL.Controles.Colores(Me.components)
        Me.CalculadoraGrilla = New Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown()
        Me.colorCambio = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta44 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorCargaConsolidada = New ISL.Controles.Colores(Me.components)
        Me.UltraExpandableGroupBox4 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel12 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.verPilotoLista = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboPilotoLista = New ISL.Controles.ComboMaestros(Me.components)
        Me.verCarretaLista = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboCarretaLista = New ISL.Controles.Combo(Me.components)
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.verTracto = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboTractoLista = New ISL.Controles.Combo(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboUsuario = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel62 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboZona = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficViaje = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.expGeneral = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel14 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griDisponibleVehiculo = New ISL.Controles.Grilla(Me.components)
        Me.ogdDisponibleVehiculos = New ISL.Controles.OrigenDatos(Me.components)
        Me.expVehiculo = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel8 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraExpandableGroupBox12 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel13 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorAdvertencia = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorPiloto = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorAyudante = New ISL.Controles.Colores(Me.components)
        Me.ColorCopiloto = New ISL.Controles.Colores(Me.components)
        Me.ColorCarreta = New ISL.Controles.Colores(Me.components)
        Me.ColorTracto = New ISL.Controles.Colores(Me.components)
        Me.UltraExpandableGroupBox9 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel11 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta36 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorParihueleroD = New ISL.Controles.Colores(Me.components)
        Me.ColorMediaBarandaD = New ISL.Controles.Colores(Me.components)
        Me.ColorPlataformaD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta46 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion20M3D = New ISL.Controles.Colores(Me.components)
        Me.ColorCamion40M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCaliceraD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta43 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorTolvaVolteoD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta42 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion30M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta34 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta41 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorCamion65M3D = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta40 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorContenedorD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta39 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorVolqueteD = New ISL.Controles.Colores(Me.components)
        Me.ColorGraneleroD = New ISL.Controles.Colores(Me.components)
        Me.ColorCamionetaD = New ISL.Controles.Colores(Me.components)
        Me.ColorFurgonD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta38 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFurgonLargoD = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta37 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboZonaDisponibles = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel59 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboVehiculoDisponible = New ISL.Controles.Combo(Me.components)
        Me.btnConsultarDisponibles = New Infragistics.Win.Misc.UltraButton()
        Me.exgruOperacion = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.hOperacion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecOperacion = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel33 = New Infragistics.Win.Misc.UltraLabel()
        Me.verValidaciones = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.NroTurno = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.opcNocheDia = New ISL.Controles.Opciones(Me.components)
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.NroVueltas = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.verProgramarViajeBloque = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.lblFlota = New Infragistics.Win.Misc.UltraLabel()
        Me.chkIndTercero = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.txtCantidadOperacion = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtFUnitarioOperacion = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.cboRutaOperacion = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtFTotalOperacion = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCarga = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkMotriz = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel65 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigoOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboActividadNegocio = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtIdEstadoOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboRutaOrigen = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboTipoVehiculo = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtObservacionOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel36 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboRutaDestino = New ISL.Controles.ComboMaestros(Me.components)
        Me.ogdVehiculoEstadoSituacional = New ISL.Controles.OrigenDatos(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Colores1 = New ISL.Controles.Colores(Me.components)
        Me.Colores2 = New ISL.Controles.Colores(Me.components)
        Me.Colores3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores4 = New ISL.Controles.Colores(Me.components)
        Me.Colores5 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel45 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraMaskedEdit6 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraCheckEditor4 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraCheckEditor5 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraCheckEditor6 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraMaskedEdit7 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel46 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraMaskedEdit8 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel47 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraMaskedEdit9 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel48 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel49 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Combo4 = New ISL.Controles.Combo(Me.components)
        Me.UltraMaskedEdit10 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraMaskedEdit11 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel50 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel51 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel52 = New Infragistics.Win.Misc.UltraLabel()
        Me.ComboMaestros5 = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraMaskedEdit12 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel53 = New Infragistics.Win.Misc.UltraLabel()
        Me.NumeroCalculadora1 = New ISL.Controles.NumeroCalculadora(Me.components)
        Me.ComboMaestros6 = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel54 = New Infragistics.Win.Misc.UltraLabel()
        Me.ComboMaestros7 = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel55 = New Infragistics.Win.Misc.UltraLabel()
        Me.ComboMaestros8 = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel56 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel57 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraMaskedEdit13 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel58 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraMaskedEdit14 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraCheckEditor7 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraCheckEditor8 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel19 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraExpandableGroupBoxPanel17 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.cboTractoTransabilidad = New ISL.Controles.Combo(Me.components)
        Me.chkTractoTransabilidad = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboCarretaTransabilidad = New ISL.Controles.Combo(Me.components)
        Me.chkCarretaTransabilidad = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ficOperacion = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl2.SuspendLayout
        CType(Me.griBonificacionTracto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Calcular1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ogdBonificacionTracto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.griBonificacionCarreta, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ogdBonificacionCarreta, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTractoPeso, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboCarretaPeso, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl3.SuspendLayout
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox12.SuspendLayout
        CType(Me.griEscala, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MenuEscala.SuspendLayout
        CType(Me.ogdEscala, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox11.SuspendLayout
        CType(Me.verEscalaBloque, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboEscalaBloque, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGlosaEscalaBloque, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl6.SuspendLayout
        CType(Me.griTarifas, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ogdTarifas, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl9.SuspendLayout
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Menu.SuspendLayout
        CType(Me.ogdListaOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl10.SuspendLayout
        CType(Me.griListaTerceros, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl16.SuspendLayout
        CType(Me.griViajesProceso, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraExpandableGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraExpandableGroupBox5.SuspendLayout
        Me.UltraExpandableGroupBoxPanel10.SuspendLayout
        CType(Me.opcDesenganches, System.ComponentModel.ISupportInitialize).BeginInit
        Me.utpTrazabilidad.SuspendLayout
        CType(Me.griTransabilida, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox8.SuspendLayout
        CType(Me.cboFlota, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.opTractoCarreta, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl4.SuspendLayout
        CType(Me.griViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MenuViaje.SuspendLayout
        CType(Me.ogdViaje, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.expViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.expViaje.SuspendLayout
        Me.UltraExpandableGroupBoxPanel18.SuspendLayout
        CType(Me.exgruEscalaBloque, System.ComponentModel.ISupportInitialize).BeginInit
        Me.exgruEscalaBloque.SuspendLayout
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout
        CType(Me.tabAdicional, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabAdicional.SuspendLayout
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox14.SuspendLayout
        CType(Me.hViaje, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verViajeRetorno, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verFechaViaje, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboCarreta, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboOrigen, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDestino, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtIdViaje, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTracto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verEscala, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCodigoViaje, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboCopiloto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGlosaEscala, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verCarreta, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verViajeVacio, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboAyudante, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboEscala, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboPiloto, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl5.SuspendLayout
        CType(Me.griViajeDetalle, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MenuViajeDetalle.SuspendLayout
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.expCargaOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        Me.expCargaOperacion.SuspendLayout
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout
        CType(Me.expListaDemandas, System.ComponentModel.ISupportInitialize).BeginInit
        Me.expListaDemandas.SuspendLayout
        Me.UltraExpandableGroupBoxPanel16.SuspendLayout
        CType(Me.griDemanda, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ogdDemanda, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraExpandableGroupBox3.SuspendLayout
        Me.UltraExpandableGroupBoxPanel9.SuspendLayout
        CType(Me.cboZonaDemanda, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.expNuevaCarga, System.ComponentModel.ISupportInitialize).BeginInit
        Me.expNuevaCarga.SuspendLayout
        Me.UltraExpandableGroupBoxPanel7.SuspendLayout
        CType(Me.txtRucCLiente, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRucComisionista, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox9.SuspendLayout
        CType(Me.chkIndFalsoFlete, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verValidaFU, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verIncluyeIgv, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CalFleteUnitario, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CalFleteUnitarioIGV, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboClienteFinal, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion6.SuspendLayout
        CType(Me.opPagoCont, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verCargar, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verDescarga, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verPagoContraEntrega, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verFacturado, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboMaterial, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTipoCarga, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboComisionista, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox10.SuspendLayout
        CType(Me.txtMotivoConsolidado, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chkConsolidado, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chkCostoEstivaDescarga, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chkIGVConsolidado, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chkCostoEstiva, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl8.SuspendLayout
        CType(Me.griDetalleTercero, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MenuContratoTercero.SuspendLayout
        CType(Me.ogdDetalleTercero, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.expContratoTercero, System.ComponentModel.ISupportInitialize).BeginInit
        Me.expContratoTercero.SuspendLayout
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout
        CType(Me.txtTelefonoContacto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtApellidoMaternoContacto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNombreContacto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtApellidoPaternoContacto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRucContacto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRucEmpresaTransportista, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboContacto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTercero, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtReferenciaTercero, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtObservacionTercero, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboMonedaT, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl7.SuspendLayout
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrListaRegistro.SuspendLayout
        CType(Me.tabViajesLista, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabViajesLista.SuspendLayout
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrBusqueda.SuspendLayout
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraExpandableGroupBox7.SuspendLayout
        Me.UltraExpandableGroupBoxPanel15.SuspendLayout
        CType(Me.decProduccionSinIGV, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decProduccionIGV, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grupoEstado, System.ComponentModel.ISupportInitialize).BeginInit
        Me.grupoEstado.SuspendLayout
        CType(Me.ColorFin, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorProgramado, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCarga, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorTransito, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorDescarga, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grupoTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.grupoTipoVehiculo.SuspendLayout
        CType(Me.Colores6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Colores7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorParihuelero, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Colores8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorPlataforma, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCamion20M3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorTolvaVolteo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Colores9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Colores10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCamion65M3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorContenedor, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorGranelero, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorFurgon, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorFurgonLargo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCamioneta, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorVolquete, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCamion30M3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCalicera, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCamion40M3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorMediaBaranda, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CalculadoraGrilla, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.colorCargaConsolidada, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraExpandableGroupBox4.SuspendLayout
        Me.UltraExpandableGroupBoxPanel12.SuspendLayout
        CType(Me.verPilotoLista, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboPilotoLista, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verCarretaLista, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboCarretaLista, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox13.SuspendLayout
        CType(Me.verTracto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboUsuario, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboZona, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl1.SuspendLayout
        CType(Me.ficViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ficViaje.SuspendLayout
        CType(Me.expGeneral, System.ComponentModel.ISupportInitialize).BeginInit
        Me.expGeneral.SuspendLayout
        Me.UltraExpandableGroupBoxPanel14.SuspendLayout
        CType(Me.griDisponibleVehiculo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ogdDisponibleVehiculos, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.expVehiculo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.expVehiculo.SuspendLayout
        Me.UltraExpandableGroupBoxPanel8.SuspendLayout
        CType(Me.UltraExpandableGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraExpandableGroupBox12.SuspendLayout
        Me.UltraExpandableGroupBoxPanel13.SuspendLayout
        CType(Me.ColorAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorPiloto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorAyudante, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCopiloto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCarreta, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorTracto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraExpandableGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraExpandableGroupBox9.SuspendLayout
        Me.UltraExpandableGroupBoxPanel11.SuspendLayout
        CType(Me.ColorParihueleroD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorMediaBarandaD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorPlataformaD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCamion20M3D, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCamion40M3D, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCaliceraD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorTolvaVolteoD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCamion30M3D, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCamion65M3D, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorContenedorD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorVolqueteD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorGraneleroD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorCamionetaD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorFurgonD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorFurgonLargoD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox2.SuspendLayout
        CType(Me.cboZonaDisponibles, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboVehiculoDisponible, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.exgruOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        Me.exgruOperacion.SuspendLayout
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox7.SuspendLayout
        CType(Me.hOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verValidaciones, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox5.SuspendLayout
        CType(Me.NroTurno, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.opcNocheDia, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NroVueltas, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verProgramarViajeBloque, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox1.SuspendLayout
        CType(Me.chkIndTercero, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboRutaOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCarga, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chkMotriz, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCodigoOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboActividadNegocio, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtIdEstadoOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtIdOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboRutaOrigen, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtObservacionOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboRutaDestino, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ogdVehiculoEstadoSituacional, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Colores2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Colores3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Colores4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Colores5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion2.SuspendLayout
        CType(Me.UltraCheckEditor4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraCheckEditor5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraCheckEditor6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion5.SuspendLayout
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox4.SuspendLayout
        CType(Me.Combo4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboMaestros5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NumeroCalculadora1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboMaestros6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboMaestros7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboMaestros8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraCheckEditor7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraCheckEditor8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraExpandableGroupBox6.SuspendLayout
        CType(Me.cboTractoTransabilidad, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chkTractoTransabilidad, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboCarretaTransabilidad, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chkCarretaTransabilidad, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ficOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ficOperacion.SuspendLayout
        Me.SuspendLayout
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel35)
        Me.UltraTabPageControl2.Controls.Add(Me.txtBonificacionTracto)
        Me.UltraTabPageControl2.Controls.Add(Me.btnCapacidadUtil)
        Me.UltraTabPageControl2.Controls.Add(Me.griBonificacionTracto)
        Me.UltraTabPageControl2.Controls.Add(Me.griBonificacionCarreta)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel18)
        Me.UltraTabPageControl2.Controls.Add(Me.txtTaraCarreta)
        Me.UltraTabPageControl2.Controls.Add(Me.cboTractoPeso)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel9)
        Me.UltraTabPageControl2.Controls.Add(Me.txtCapacidadUtil)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel6)
        Me.UltraTabPageControl2.Controls.Add(Me.txtTaraTracto)
        Me.UltraTabPageControl2.Controls.Add(Me.cboCarretaPeso)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(498, 98)
        '
        'UltraLabel35
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Appearance1.TextVAlignAsString = "Middle"
        Me.UltraLabel35.Appearance = Appearance1
        Me.UltraLabel35.AutoSize = True
        Me.UltraLabel35.Location = New System.Drawing.Point(192, 2)
        Me.UltraLabel35.Name = "UltraLabel35"
        Me.UltraLabel35.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel35.TabIndex = 2
        Me.UltraLabel35.Text = "Bonificacion"
        '
        'txtBonificacionTracto
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.txtBonificacionTracto.Appearance = Appearance2
        Me.txtBonificacionTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtBonificacionTracto.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtBonificacionTracto.InputMask = "{double:5.2}"
        Me.txtBonificacionTracto.Location = New System.Drawing.Point(195, 18)
        Me.txtBonificacionTracto.Name = "txtBonificacionTracto"
        Me.txtBonificacionTracto.NonAutoSizeHeight = 20
        Me.txtBonificacionTracto.ReadOnly = True
        Me.txtBonificacionTracto.Size = New System.Drawing.Size(60, 20)
        Me.txtBonificacionTracto.TabIndex = 2
        Me.txtBonificacionTracto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtBonificacionTracto.Text = "000"
        UltraToolTipInfo24.ToolTipText = "Bonificacion Tracto"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtBonificacionTracto, UltraToolTipInfo24)
        '
        'btnCapacidadUtil
        '
        Appearance369.Image = "266.png"
        Appearance369.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance369.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnCapacidadUtil.Appearance = Appearance369
        Me.btnCapacidadUtil.ImageList = Me.imagenes
        Me.btnCapacidadUtil.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnCapacidadUtil.Location = New System.Drawing.Point(148, 65)
        Me.btnCapacidadUtil.Name = "btnCapacidadUtil"
        Me.btnCapacidadUtil.Size = New System.Drawing.Size(45, 30)
        Me.btnCapacidadUtil.TabIndex = 6
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
        Me.imagenes.Images.SetKeyName(12, "06_calculator.ico")
        Me.imagenes.Images.SetKeyName(13, "Consultar.ico")
        Me.imagenes.Images.SetKeyName(14, "266.png")
        '
        'griBonificacionTracto
        '
        Me.griBonificacionTracto.CalcManager = Me.Calcular1
        Me.griBonificacionTracto.DataSource = Me.ogdBonificacionTracto
        Appearance370.BackColor = System.Drawing.Color.White
        Me.griBonificacionTracto.DisplayLayout.Appearance = Appearance370
        UltraGridColumn1020.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1020.Header.VisiblePosition = 0
        UltraGridColumn1020.Hidden = True
        UltraGridColumn1021.Header.VisiblePosition = 1
        UltraGridColumn1021.Hidden = True
        Appearance371.TextHAlignAsString = "Right"
        UltraGridColumn1022.CellAppearance = Appearance371
        UltraGridColumn1022.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance372.TextHAlignAsString = "Right"
        UltraGridColumn1022.Header.Appearance = Appearance372
        UltraGridColumn1022.Header.VisiblePosition = 2
        UltraGridColumn1022.MaskInput = "nnnnnnn"
        UltraGridColumn1022.Width = 40
        Appearance373.TextHAlignAsString = "Right"
        UltraGridColumn1023.CellAppearance = Appearance373
        UltraGridColumn1023.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1023.Header.Caption = "%"
        UltraGridColumn1023.Header.VisiblePosition = 3
        UltraGridColumn1023.MaskInput = "nn"
        UltraGridColumn1023.Width = 20
        UltraGridColumn1024.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1024.Header.Caption = "Bof."
        UltraGridColumn1024.Header.VisiblePosition = 4
        UltraGridColumn1024.Hidden = True
        UltraGridColumn1024.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1024.Width = 30
        UltraGridColumn1025.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1025.Header.VisiblePosition = 5
        UltraGridColumn1025.Hidden = True
        UltraGridColumn1025.Width = 250
        UltraGridColumn1026.Header.VisiblePosition = 6
        UltraGridColumn1026.Hidden = True
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn1020, UltraGridColumn1021, UltraGridColumn1022, UltraGridColumn1023, UltraGridColumn1024, UltraGridColumn1025, UltraGridColumn1026})
        Me.griBonificacionTracto.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.griBonificacionTracto.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griBonificacionTracto.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.griBonificacionTracto.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.griBonificacionTracto.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griBonificacionTracto.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griBonificacionTracto.DisplayLayout.GroupByBox.Hidden = True
        Me.griBonificacionTracto.DisplayLayout.MaxColScrollRegions = 1
        Me.griBonificacionTracto.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griBonificacionTracto.DisplayLayout.Override.CellPadding = 0
        Appearance374.TextHAlignAsString = "Left"
        Me.griBonificacionTracto.DisplayLayout.Override.HeaderAppearance = Appearance374
        Me.griBonificacionTracto.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griBonificacionTracto.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance375.TextVAlignAsString = "Middle"
        Me.griBonificacionTracto.DisplayLayout.Override.RowAppearance = Appearance375
        Me.griBonificacionTracto.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griBonificacionTracto.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griBonificacionTracto.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griBonificacionTracto.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griBonificacionTracto.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griBonificacionTracto.Dock = System.Windows.Forms.DockStyle.Left
        Me.griBonificacionTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griBonificacionTracto.Location = New System.Drawing.Point(0, 0)
        Me.griBonificacionTracto.Name = "griBonificacionTracto"
        Me.griBonificacionTracto.Size = New System.Drawing.Size(120, 98)
        Me.griBonificacionTracto.TabIndex = 0
        Me.griBonificacionTracto.TabStop = False
        Me.griBonificacionTracto.Tag = ""
        UltraToolTipInfo25.ToolTipText = "Bonificacion Tracto"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.griBonificacionTracto, UltraToolTipInfo25)
        '
        'Calcular1
        '
        Me.Calcular1.ContainingControl = Me
        '
        'ogdBonificacionTracto
        '
        Me.ogdBonificacionTracto.Band.Columns.AddRange(New Object() {UltraDataColumn355, UltraDataColumn356, UltraDataColumn357, UltraDataColumn358, UltraDataColumn359, UltraDataColumn360, UltraDataColumn361})
        '
        'griBonificacionCarreta
        '
        Me.griBonificacionCarreta.CalcManager = Me.Calcular1
        Me.griBonificacionCarreta.DataSource = Me.ogdBonificacionCarreta
        Appearance376.BackColor = System.Drawing.Color.White
        Me.griBonificacionCarreta.DisplayLayout.Appearance = Appearance376
        UltraGridColumn1027.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1027.Header.VisiblePosition = 0
        UltraGridColumn1027.Hidden = True
        UltraGridColumn1028.Header.VisiblePosition = 1
        UltraGridColumn1028.Hidden = True
        Appearance377.TextHAlignAsString = "Right"
        UltraGridColumn1029.CellAppearance = Appearance377
        UltraGridColumn1029.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance378.TextHAlignAsString = "Right"
        UltraGridColumn1029.Header.Appearance = Appearance378
        UltraGridColumn1029.Header.VisiblePosition = 2
        UltraGridColumn1029.MaskInput = "nnnnnnn"
        UltraGridColumn1029.Width = 40
        Appearance379.TextHAlignAsString = "Right"
        UltraGridColumn1030.CellAppearance = Appearance379
        UltraGridColumn1030.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1030.Header.Caption = "%"
        UltraGridColumn1030.Header.VisiblePosition = 3
        UltraGridColumn1030.MaskInput = "nn"
        UltraGridColumn1030.Width = 20
        UltraGridColumn1031.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1031.Header.Caption = "Bof."
        UltraGridColumn1031.Header.VisiblePosition = 4
        UltraGridColumn1031.Hidden = True
        UltraGridColumn1031.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1031.Width = 30
        UltraGridColumn1032.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1032.Header.VisiblePosition = 5
        UltraGridColumn1032.Hidden = True
        UltraGridColumn1032.Width = 250
        UltraGridColumn1033.Header.VisiblePosition = 6
        UltraGridColumn1033.Hidden = True
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn1027, UltraGridColumn1028, UltraGridColumn1029, UltraGridColumn1030, UltraGridColumn1031, UltraGridColumn1032, UltraGridColumn1033})
        Me.griBonificacionCarreta.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.griBonificacionCarreta.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griBonificacionCarreta.DisplayLayout.ColScrollRegions.Add(ColScrollRegion3)
        Me.griBonificacionCarreta.DisplayLayout.ColScrollRegions.Add(ColScrollRegion4)
        Me.griBonificacionCarreta.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griBonificacionCarreta.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griBonificacionCarreta.DisplayLayout.GroupByBox.Hidden = True
        Me.griBonificacionCarreta.DisplayLayout.MaxColScrollRegions = 1
        Me.griBonificacionCarreta.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griBonificacionCarreta.DisplayLayout.Override.CellPadding = 0
        Appearance380.TextHAlignAsString = "Left"
        Me.griBonificacionCarreta.DisplayLayout.Override.HeaderAppearance = Appearance380
        Me.griBonificacionCarreta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griBonificacionCarreta.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance381.TextVAlignAsString = "Middle"
        Me.griBonificacionCarreta.DisplayLayout.Override.RowAppearance = Appearance381
        Me.griBonificacionCarreta.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griBonificacionCarreta.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griBonificacionCarreta.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griBonificacionCarreta.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griBonificacionCarreta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griBonificacionCarreta.Dock = System.Windows.Forms.DockStyle.Right
        Me.griBonificacionCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griBonificacionCarreta.Location = New System.Drawing.Point(378, 0)
        Me.griBonificacionCarreta.Name = "griBonificacionCarreta"
        Me.griBonificacionCarreta.Size = New System.Drawing.Size(120, 98)
        Me.griBonificacionCarreta.TabIndex = 8
        Me.griBonificacionCarreta.TabStop = False
        Me.griBonificacionCarreta.Tag = ""
        UltraToolTipInfo26.ToolTipText = "Bonificacion Carreta"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.griBonificacionCarreta, UltraToolTipInfo26)
        '
        'ogdBonificacionCarreta
        '
        Me.ogdBonificacionCarreta.Band.Columns.AddRange(New Object() {UltraDataColumn362, UltraDataColumn363, UltraDataColumn364, UltraDataColumn365, UltraDataColumn366, UltraDataColumn367, UltraDataColumn368})
        '
        'UltraLabel18
        '
        Appearance382.BackColor = System.Drawing.Color.Transparent
        Appearance382.ForeColor = System.Drawing.Color.Navy
        Appearance382.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance382
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(277, 2)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel18.TabIndex = 3
        Me.UltraLabel18.Text = "Carreta:"
        '
        'txtTaraCarreta
        '
        Appearance383.TextHAlignAsString = "Right"
        Me.txtTaraCarreta.Appearance = Appearance383
        Me.txtTaraCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTaraCarreta.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtTaraCarreta.InputMask = "{double:5.2}"
        Me.txtTaraCarreta.Location = New System.Drawing.Point(279, 40)
        Me.txtTaraCarreta.Name = "txtTaraCarreta"
        Me.txtTaraCarreta.NonAutoSizeHeight = 20
        Me.txtTaraCarreta.ReadOnly = True
        Me.txtTaraCarreta.Size = New System.Drawing.Size(60, 20)
        Me.txtTaraCarreta.TabIndex = 5
        Me.txtTaraCarreta.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtTaraCarreta.Text = "000"
        UltraToolTipInfo27.ToolTipText = "Tara Carreta (Kg)"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtTaraCarreta, UltraToolTipInfo27)
        '
        'cboTractoPeso
        '
        Appearance384.ForeColor = System.Drawing.Color.Black
        Me.cboTractoPeso.Appearance = Appearance384
        Me.cboTractoPeso.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTractoPeso.DisplayMember = ""
        Me.cboTractoPeso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTractoPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTractoPeso.ForeColor = System.Drawing.Color.Black
        Me.cboTractoPeso.ImageList = Me.imagenes
        Me.cboTractoPeso.Location = New System.Drawing.Point(123, 18)
        Me.cboTractoPeso.Name = "cboTractoPeso"
        Me.cboTractoPeso.Size = New System.Drawing.Size(70, 21)
        Me.cboTractoPeso.TabIndex = 1
        Me.cboTractoPeso.ValueMember = "Id"
        '
        'UltraLabel9
        '
        Appearance385.BackColor = System.Drawing.Color.Transparent
        Appearance385.ForeColor = System.Drawing.Color.Navy
        Appearance385.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance385
        Me.UltraLabel9.Location = New System.Drawing.Point(197, 66)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(79, 35)
        Me.UltraLabel9.TabIndex = 11
        Me.UltraLabel9.Text = "Capacidad Util en Kilogramos:"
        '
        'txtCapacidadUtil
        '
        Appearance386.TextHAlignAsString = "Right"
        Me.txtCapacidadUtil.Appearance = Appearance386
        Me.txtCapacidadUtil.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCapacidadUtil.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCapacidadUtil.InputMask = "{double:5.2}"
        Me.txtCapacidadUtil.Location = New System.Drawing.Point(279, 73)
        Me.txtCapacidadUtil.Name = "txtCapacidadUtil"
        Me.txtCapacidadUtil.NonAutoSizeHeight = 20
        Me.txtCapacidadUtil.ReadOnly = True
        Me.txtCapacidadUtil.Size = New System.Drawing.Size(60, 20)
        Me.txtCapacidadUtil.TabIndex = 7
        Me.txtCapacidadUtil.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtCapacidadUtil.Text = "000"
        '
        'UltraLabel6
        '
        Appearance387.BackColor = System.Drawing.Color.Transparent
        Appearance387.ForeColor = System.Drawing.Color.Navy
        Appearance387.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance387
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(122, 2)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel6.TabIndex = 1
        Me.UltraLabel6.Text = "Tracto:"
        '
        'txtTaraTracto
        '
        Appearance388.TextHAlignAsString = "Right"
        Me.txtTaraTracto.Appearance = Appearance388
        Me.txtTaraTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTaraTracto.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtTaraTracto.InputMask = "{double:5.2}"
        Me.txtTaraTracto.Location = New System.Drawing.Point(123, 40)
        Me.txtTaraTracto.Name = "txtTaraTracto"
        Me.txtTaraTracto.NonAutoSizeHeight = 20
        Me.txtTaraTracto.ReadOnly = True
        Me.txtTaraTracto.Size = New System.Drawing.Size(60, 20)
        Me.txtTaraTracto.TabIndex = 4
        Me.txtTaraTracto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtTaraTracto.Text = "000"
        UltraToolTipInfo28.ToolTipText = "Tara Tracto (Kg)"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtTaraTracto, UltraToolTipInfo28)
        '
        'cboCarretaPeso
        '
        Appearance389.ForeColor = System.Drawing.Color.Black
        Me.cboCarretaPeso.Appearance = Appearance389
        Me.cboCarretaPeso.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCarretaPeso.DisplayMember = ""
        Me.cboCarretaPeso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCarretaPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarretaPeso.ForeColor = System.Drawing.Color.Black
        Me.cboCarretaPeso.ImageList = Me.imagenes
        Me.cboCarretaPeso.Location = New System.Drawing.Point(279, 18)
        Me.cboCarretaPeso.Name = "cboCarretaPeso"
        Me.cboCarretaPeso.Size = New System.Drawing.Size(70, 21)
        Me.cboCarretaPeso.TabIndex = 3
        Me.cboCarretaPeso.ValueMember = "Id"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox12)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox11)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(498, 98)
        '
        'UltraGroupBox12
        '
        Appearance159.BackColor = System.Drawing.Color.White
        Appearance159.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox12.ContentAreaAppearance = Appearance159
        Me.UltraGroupBox12.Controls.Add(Me.griEscala)
        Me.UltraGroupBox12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox12.Location = New System.Drawing.Point(233, 0)
        Me.UltraGroupBox12.Name = "UltraGroupBox12"
        Me.UltraGroupBox12.Size = New System.Drawing.Size(265, 98)
        Me.UltraGroupBox12.TabIndex = 1
        Me.UltraGroupBox12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griEscala
        '
        Me.griEscala.CalcManager = Me.Calcular1
        Me.griEscala.ContextMenuStrip = Me.MenuEscala
        Me.griEscala.DataSource = Me.ogdEscala
        Appearance160.BackColor = System.Drawing.Color.White
        Me.griEscala.DisplayLayout.Appearance = Appearance160
        UltraGridColumn1034.Header.VisiblePosition = 1
        UltraGridColumn1034.Width = 150
        Appearance161.TextHAlignAsString = "Right"
        UltraGridColumn1035.CellAppearance = Appearance161
        UltraGridColumn1035.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn1035.Header.VisiblePosition = 0
        UltraGridColumn1035.MaskInput = "n"
        UltraGridColumn1035.Width = 15
        UltraGridColumn1036.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1036.Header.VisiblePosition = 2
        UltraGridColumn1036.Hidden = True
        UltraGridColumn1036.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn1036.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1036.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(277, 0)
        UltraGridColumn1036.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1036.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn1036.Width = 200
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn1034, UltraGridColumn1035, UltraGridColumn1036})
        UltraGridBand6.SummaryFooterCaption = "Totales:"
        Me.griEscala.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griEscala.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griEscala.DisplayLayout.GroupByBox.Hidden = True
        Me.griEscala.DisplayLayout.MaxColScrollRegions = 1
        Me.griEscala.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griEscala.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griEscala.DisplayLayout.Override.CellPadding = 2
        Me.griEscala.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance162.TextHAlignAsString = "Left"
        Me.griEscala.DisplayLayout.Override.HeaderAppearance = Appearance162
        Me.griEscala.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griEscala.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance163.TextVAlignAsString = "Middle"
        Me.griEscala.DisplayLayout.Override.RowAppearance = Appearance163
        Me.griEscala.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griEscala.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griEscala.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griEscala.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griEscala.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griEscala.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griEscala.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griEscala.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griEscala.Location = New System.Drawing.Point(3, 3)
        Me.griEscala.Name = "griEscala"
        Me.griEscala.Size = New System.Drawing.Size(259, 92)
        Me.griEscala.TabIndex = 4
        Me.griEscala.Tag = ""
        '
        'MenuEscala
        '
        Me.MenuEscala.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuEscala.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuEscala.Name = "mnu_Transferencias"
        Me.MenuEscala.Size = New System.Drawing.Size(149, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem1.Text = "Quitar"
        '
        'ogdEscala
        '
        Me.ogdEscala.Band.Columns.AddRange(New Object() {UltraDataColumn165, UltraDataColumn166, UltraDataColumn167})
        '
        'UltraGroupBox11
        '
        Appearance164.BackColor = System.Drawing.Color.White
        Appearance164.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox11.ContentAreaAppearance = Appearance164
        Me.UltraGroupBox11.Controls.Add(Me.verEscalaBloque)
        Me.UltraGroupBox11.Controls.Add(Me.cboEscalaBloque)
        Me.UltraGroupBox11.Controls.Add(Me.txtGlosaEscalaBloque)
        Me.UltraGroupBox11.Controls.Add(Me.btnAgregaEscala)
        Me.UltraGroupBox11.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraGroupBox11.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(233, 98)
        Me.UltraGroupBox11.TabIndex = 0
        Me.UltraGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verEscalaBloque
        '
        Appearance165.ForeColor = System.Drawing.Color.Navy
        Me.verEscalaBloque.Appearance = Appearance165
        Me.verEscalaBloque.AutoSize = True
        Me.verEscalaBloque.Location = New System.Drawing.Point(6, 5)
        Me.verEscalaBloque.Name = "verEscalaBloque"
        Me.verEscalaBloque.Size = New System.Drawing.Size(55, 17)
        Me.verEscalaBloque.TabIndex = 0
        Me.verEscalaBloque.Text = "Escala"
        '
        'cboEscalaBloque
        '
        Me.cboEscalaBloque.CalcManager = Me.Calcular1
        Me.cboEscalaBloque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEscalaBloque.DisplayMember = "Nombre"
        Me.cboEscalaBloque.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEscalaBloque.Enabled = False
        Me.cboEscalaBloque.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEscalaBloque.Location = New System.Drawing.Point(3, 26)
        Me.cboEscalaBloque.Name = "cboEscalaBloque"
        Me.cboEscalaBloque.Size = New System.Drawing.Size(225, 20)
        Me.cboEscalaBloque.TabIndex = 1
        Me.cboEscalaBloque.ValueMember = "Id"
        '
        'txtGlosaEscalaBloque
        '
        Me.txtGlosaEscalaBloque.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaEscalaBloque.Enabled = False
        Me.txtGlosaEscalaBloque.Location = New System.Drawing.Point(3, 49)
        Me.txtGlosaEscalaBloque.Multiline = True
        Me.txtGlosaEscalaBloque.Name = "txtGlosaEscalaBloque"
        Me.txtGlosaEscalaBloque.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosaEscalaBloque.Size = New System.Drawing.Size(190, 43)
        Me.txtGlosaEscalaBloque.TabIndex = 2
        UltraToolTipInfo3.ToolTipText = "Justificacion de Escala"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtGlosaEscalaBloque, UltraToolTipInfo3)
        '
        'btnAgregaEscala
        '
        Appearance166.Image = "add.ico"
        Me.btnAgregaEscala.Appearance = Appearance166
        Me.btnAgregaEscala.Enabled = False
        Me.btnAgregaEscala.ImageList = Me.imagenes
        Me.btnAgregaEscala.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregaEscala.Location = New System.Drawing.Point(199, 49)
        Me.btnAgregaEscala.Name = "btnAgregaEscala"
        Me.btnAgregaEscala.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregaEscala.TabIndex = 3
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griTarifas)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(115, 73)
        '
        'griTarifas
        '
        Me.griTarifas.CalcManager = Me.Calcular1
        Me.griTarifas.ContextMenuStrip = Me.MenuEscala
        Me.griTarifas.DataSource = Me.ogdTarifas
        Appearance167.BackColor = System.Drawing.Color.White
        Me.griTarifas.DisplayLayout.Appearance = Appearance167
        Appearance168.TextHAlignAsString = "Center"
        UltraGridColumn1037.Header.Appearance = Appearance168
        UltraGridColumn1037.Header.VisiblePosition = 0
        Appearance169.TextHAlignAsString = "Right"
        UltraGridColumn1038.CellAppearance = Appearance169
        UltraGridColumn1038.Header.VisiblePosition = 1
        UltraGridColumn1038.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn1038.Width = 50
        Appearance170.TextHAlignAsString = "Right"
        UltraGridColumn1039.CellAppearance = Appearance170
        UltraGridColumn1039.Header.VisiblePosition = 2
        UltraGridColumn1039.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn1039.Width = 50
        Appearance171.TextHAlignAsString = "Right"
        UltraGridColumn1040.CellAppearance = Appearance171
        UltraGridColumn1040.Header.VisiblePosition = 3
        UltraGridColumn1040.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn1040.Width = 50
        Appearance172.TextHAlignAsString = "Right"
        UltraGridColumn1041.CellAppearance = Appearance172
        UltraGridColumn1041.Header.VisiblePosition = 4
        UltraGridColumn1041.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn1041.Width = 50
        Appearance173.TextHAlignAsString = "Right"
        UltraGridColumn1042.CellAppearance = Appearance173
        UltraGridColumn1042.Header.VisiblePosition = 5
        UltraGridColumn1042.MaskInput = "{LOC}n,nnn.nn"
        UltraGridColumn1042.Width = 50
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn1037, UltraGridColumn1038, UltraGridColumn1039, UltraGridColumn1040, UltraGridColumn1041, UltraGridColumn1042})
        UltraGridBand7.SummaryFooterCaption = "Totales:"
        Me.griTarifas.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griTarifas.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griTarifas.DisplayLayout.GroupByBox.Hidden = True
        Me.griTarifas.DisplayLayout.MaxColScrollRegions = 1
        Me.griTarifas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTarifas.DisplayLayout.Override.CellPadding = 2
        Me.griTarifas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance174.TextHAlignAsString = "Left"
        Me.griTarifas.DisplayLayout.Override.HeaderAppearance = Appearance174
        Me.griTarifas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTarifas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance175.TextVAlignAsString = "Middle"
        Me.griTarifas.DisplayLayout.Override.RowAppearance = Appearance175
        Me.griTarifas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTarifas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTarifas.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griTarifas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTarifas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTarifas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTarifas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTarifas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTarifas.Location = New System.Drawing.Point(0, 0)
        Me.griTarifas.Name = "griTarifas"
        Me.griTarifas.Size = New System.Drawing.Size(115, 73)
        Me.griTarifas.TabIndex = 5
        Me.griTarifas.Tag = ""
        '
        'ogdTarifas
        '
        UltraDataColumn169.DataType = GetType(Double)
        UltraDataColumn170.DataType = GetType(Double)
        UltraDataColumn171.DataType = GetType(Double)
        UltraDataColumn172.DataType = GetType(Double)
        UltraDataColumn173.DataType = GetType(Double)
        Me.ogdTarifas.Band.Columns.AddRange(New Object() {UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172, UltraDataColumn173})
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.griLista)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1242, 522)
        '
        'griLista
        '
        Me.griLista.CalcManager = Me.Calcular1
        Me.griLista.ContextMenuStrip = Me.Menu
        Me.griLista.DataSource = Me.ogdListaOperacion
        UltraGridColumn620.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn620.Header.VisiblePosition = 16
        UltraGridColumn620.Hidden = True
        UltraGridColumn621.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn621.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance4.TextHAlignAsString = "Center"
        Appearance4.TextVAlignAsString = "Middle"
        UltraGridColumn621.CellAppearance = Appearance4
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn621.Header.Appearance = Appearance5
        UltraGridColumn621.Header.Fixed = True
        UltraGridColumn621.Header.VisiblePosition = 0
        UltraGridColumn621.Hidden = True
        UltraGridColumn621.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn621.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn621.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn621.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn621.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn621.Width = 95
        UltraGridColumn622.Header.VisiblePosition = 17
        UltraGridColumn622.Hidden = True
        Appearance6.TextVAlignAsString = "Middle"
        UltraGridColumn623.CellAppearance = Appearance6
        UltraGridColumn623.Header.Caption = "Viaje"
        UltraGridColumn623.Header.Fixed = True
        UltraGridColumn623.Header.VisiblePosition = 1
        UltraGridColumn623.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn623.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn623.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn623.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn623.Width = 95
        UltraGridColumn624.Header.VisiblePosition = 18
        UltraGridColumn624.Hidden = True
        UltraGridColumn625.Header.Fixed = True
        UltraGridColumn625.Header.VisiblePosition = 3
        UltraGridColumn625.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn625.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn625.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn625.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn625.Width = 100
        UltraGridColumn626.Header.VisiblePosition = 19
        UltraGridColumn626.Hidden = True
        UltraGridColumn627.Header.Fixed = True
        UltraGridColumn627.Header.VisiblePosition = 4
        UltraGridColumn627.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn627.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn627.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn627.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn627.Width = 100
        Appearance7.Image = 3
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn628.CellAppearance = Appearance7
        Appearance8.Image = 1
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn628.CellButtonAppearance = Appearance8
        UltraGridColumn628.Header.Caption = "V.Retorno"
        UltraGridColumn628.Header.VisiblePosition = 73
        UltraGridColumn628.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn628.Width = 35
        Appearance9.TextVAlignAsString = "Middle"
        UltraGridColumn629.CellAppearance = Appearance9
        UltraGridColumn629.Header.Caption = "Demanda"
        UltraGridColumn629.Header.VisiblePosition = 20
        UltraGridColumn629.Hidden = True
        UltraGridColumn629.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn629.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn629.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn629.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn629.Width = 124
        Appearance10.TextVAlignAsString = "Middle"
        UltraGridColumn630.CellAppearance = Appearance10
        UltraGridColumn630.Header.Caption = "Vacio"
        UltraGridColumn630.Header.VisiblePosition = 34
        UltraGridColumn630.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn630.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn630.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn630.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn630.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn630.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn630.Width = 40
        UltraGridColumn631.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn631.Header.VisiblePosition = 21
        UltraGridColumn631.Hidden = True
        UltraGridColumn632.Header.VisiblePosition = 7
        UltraGridColumn632.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn632.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn632.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn632.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn632.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn632.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn632.Width = 150
        UltraGridColumn633.Header.VisiblePosition = 22
        UltraGridColumn633.Hidden = True
        Appearance11.Image = 7
        UltraGridColumn634.CellButtonAppearance = Appearance11
        UltraGridColumn634.Header.VisiblePosition = 8
        UltraGridColumn634.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn634.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn634.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn634.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn634.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn634.Width = 150
        UltraGridColumn635.Header.VisiblePosition = 15
        UltraGridColumn635.Hidden = True
        UltraGridColumn636.Header.VisiblePosition = 14
        UltraGridColumn636.Hidden = True
        UltraGridColumn637.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn637.Header.VisiblePosition = 13
        UltraGridColumn637.Hidden = True
        Appearance12.Image = Global.ISL.Win.My.Resources.Resources.consult
        Appearance12.TextHAlignAsString = "Left"
        Appearance12.TextVAlignAsString = "Middle"
        UltraGridColumn638.CellAppearance = Appearance12
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.consult
        UltraGridColumn638.CellButtonAppearance = Appearance13
        UltraGridColumn638.Header.Fixed = True
        UltraGridColumn638.Header.VisiblePosition = 5
        UltraGridColumn638.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn638.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn638.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn638.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn638.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn638.Width = 80
        UltraGridColumn639.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn639.Header.VisiblePosition = 12
        UltraGridColumn639.Hidden = True
        Appearance14.Image = Global.ISL.Win.My.Resources.Resources.consult
        Appearance14.TextHAlignAsString = "Left"
        Appearance14.TextVAlignAsString = "Middle"
        UltraGridColumn640.CellAppearance = Appearance14
        Appearance15.Image = Global.ISL.Win.My.Resources.Resources.consult
        UltraGridColumn640.CellButtonAppearance = Appearance15
        UltraGridColumn640.Header.Fixed = True
        UltraGridColumn640.Header.VisiblePosition = 6
        UltraGridColumn640.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn640.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn640.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn640.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn640.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn640.VertScrollBar = True
        UltraGridColumn640.Width = 80
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn641.CellAppearance = Appearance16
        UltraGridColumn641.Format = "#,###,##0.000"
        UltraGridColumn641.Header.VisiblePosition = 31
        UltraGridColumn641.MaskInput = "{LOC}n,nnn,nnn.nn"
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn642.CellAppearance = Appearance17
        UltraGridColumn642.Format = "#,###,###,##0.000"
        UltraGridColumn642.Header.VisiblePosition = 27
        UltraGridColumn642.MaskInput = "{LOC}n,nnn,nnn.nn"
        UltraGridColumn642.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn642.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn642.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn642.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn642.Width = 100
        UltraGridColumn643.Header.VisiblePosition = 24
        UltraGridColumn643.Hidden = True
        Appearance18.TextVAlignAsString = "Middle"
        UltraGridColumn644.CellAppearance = Appearance18
        UltraGridColumn644.Header.VisiblePosition = 35
        UltraGridColumn644.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn644.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn644.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn644.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn644.Width = 100
        UltraGridColumn645.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn645.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn645.Header.Caption = "Fecha Atencion"
        UltraGridColumn645.Header.Fixed = True
        UltraGridColumn645.Header.VisiblePosition = 2
        UltraGridColumn645.MaskInput = "{date} {time}"
        UltraGridColumn645.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn645.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn645.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn645.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn645.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn645.Width = 100
        UltraGridColumn646.Header.Caption = "UsuarioCrea"
        UltraGridColumn646.Header.VisiblePosition = 52
        UltraGridColumn646.Hidden = True
        UltraGridColumn646.Width = 150
        UltraGridColumn647.Header.VisiblePosition = 28
        UltraGridColumn647.Hidden = True
        UltraGridColumn648.Header.VisiblePosition = 23
        UltraGridColumn648.Hidden = True
        UltraGridColumn649.Header.VisiblePosition = 29
        UltraGridColumn649.Hidden = True
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn650.CellAppearance = Appearance19
        UltraGridColumn650.Header.VisiblePosition = 49
        UltraGridColumn650.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn650.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn650.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn650.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn650.Width = 100
        UltraGridColumn651.Header.VisiblePosition = 36
        UltraGridColumn651.Hidden = True
        UltraGridColumn652.Header.VisiblePosition = 37
        UltraGridColumn652.Hidden = True
        UltraGridColumn653.Header.VisiblePosition = 38
        UltraGridColumn653.Hidden = True
        UltraGridColumn654.Header.VisiblePosition = 9
        UltraGridColumn654.Width = 150
        UltraGridColumn655.Header.VisiblePosition = 39
        UltraGridColumn655.Hidden = True
        UltraGridColumn656.Header.VisiblePosition = 40
        UltraGridColumn656.Hidden = True
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn657.CellAppearance = Appearance20
        UltraGridColumn657.Header.VisiblePosition = 10
        UltraGridColumn657.Width = 100
        UltraGridColumn658.Header.VisiblePosition = 53
        UltraGridColumn658.Width = 150
        UltraGridColumn659.Header.VisiblePosition = 54
        UltraGridColumn659.Hidden = True
        UltraGridColumn659.Width = 150
        UltraGridColumn660.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn660.Header.VisiblePosition = 41
        UltraGridColumn660.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn660.Width = 100
        UltraGridColumn661.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn661.Header.VisiblePosition = 42
        UltraGridColumn661.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn661.Width = 100
        UltraGridColumn662.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn662.Header.VisiblePosition = 43
        UltraGridColumn662.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn662.Width = 100
        UltraGridColumn663.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn663.Header.VisiblePosition = 44
        UltraGridColumn663.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn663.Width = 100
        UltraGridColumn664.Header.VisiblePosition = 50
        UltraGridColumn664.Width = 100
        Appearance21.Image = 3
        Appearance21.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn665.CellAppearance = Appearance21
        Appearance22.Image = 1
        UltraGridColumn665.CellButtonAppearance = Appearance22
        UltraGridColumn665.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn665.Header.VisiblePosition = 55
        UltraGridColumn665.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn665.Width = 250
        UltraGridColumn666.Header.VisiblePosition = 56
        UltraGridColumn666.Width = 250
        UltraGridColumn667.Header.Caption = "Bloque"
        UltraGridColumn667.Header.VisiblePosition = 57
        UltraGridColumn667.Hidden = True
        UltraGridColumn667.Width = 40
        UltraGridColumn668.Header.Caption = "D/N"
        UltraGridColumn668.Header.VisiblePosition = 58
        UltraGridColumn668.Hidden = True
        UltraGridColumn668.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn668.Width = 40
        UltraGridColumn669.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance23.TextHAlignAsString = "Right"
        Appearance23.TextVAlignAsString = "Middle"
        UltraGridColumn669.CellAppearance = Appearance23
        UltraGridColumn669.Format = "#,###,###,##0.00"
        UltraGridColumn669.Header.Caption = "TN"
        UltraGridColumn669.Header.VisiblePosition = 11
        UltraGridColumn669.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn669.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn669.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn669.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn669.Width = 40
        UltraGridColumn670.Header.VisiblePosition = 51
        UltraGridColumn670.Width = 100
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn671.CellAppearance = Appearance24
        UltraGridColumn671.Format = "#,###,###,##0.00"
        UltraGridColumn671.Header.VisiblePosition = 33
        UltraGridColumn671.Hidden = True
        UltraGridColumn671.MaskInput = "{currency:9.2}"
        UltraGridColumn671.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn671.Width = 100
        UltraGridColumn672.Header.VisiblePosition = 59
        UltraGridColumn672.Hidden = True
        UltraGridColumn672.Width = 40
        UltraGridColumn673.Header.Caption = "Ind"
        UltraGridColumn673.Header.VisiblePosition = 60
        UltraGridColumn673.Hidden = True
        UltraGridColumn673.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn673.Width = 40
        UltraGridColumn674.Header.Caption = "%Flete"
        UltraGridColumn674.Header.VisiblePosition = 30
        UltraGridColumn674.Width = 40
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn675.CellAppearance = Appearance25
        UltraGridColumn675.Header.Caption = "KmTracto O"
        UltraGridColumn675.Header.VisiblePosition = 45
        UltraGridColumn675.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn675.Width = 70
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn676.CellAppearance = Appearance26
        UltraGridColumn676.Header.Caption = "KmTracto D"
        UltraGridColumn676.Header.VisiblePosition = 46
        UltraGridColumn676.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn676.Width = 70
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn677.CellAppearance = Appearance27
        UltraGridColumn677.Header.Caption = "KmCarreta O"
        UltraGridColumn677.Header.VisiblePosition = 47
        UltraGridColumn677.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn677.Width = 70
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn678.CellAppearance = Appearance28
        UltraGridColumn678.Header.Caption = "KmCarreta D"
        UltraGridColumn678.Header.VisiblePosition = 48
        UltraGridColumn678.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn678.Width = 70
        UltraGridColumn679.Header.VisiblePosition = 61
        UltraGridColumn679.Hidden = True
        UltraGridColumn680.Header.VisiblePosition = 62
        UltraGridColumn680.Hidden = True
        UltraGridColumn681.Header.VisiblePosition = 63
        UltraGridColumn681.Hidden = True
        UltraGridColumn682.Header.VisiblePosition = 64
        UltraGridColumn682.Hidden = True
        UltraGridColumn683.Header.VisiblePosition = 66
        UltraGridColumn683.Hidden = True
        UltraGridColumn684.Header.VisiblePosition = 65
        UltraGridColumn684.Hidden = True
        UltraGridColumn685.Header.VisiblePosition = 67
        UltraGridColumn685.Hidden = True
        UltraGridColumn686.Header.VisiblePosition = 68
        UltraGridColumn686.Hidden = True
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn687.CellAppearance = Appearance29
        UltraGridColumn687.Format = "#,###,###,##0.00"
        UltraGridColumn687.Header.Caption = "Cant."
        UltraGridColumn687.Header.VisiblePosition = 25
        UltraGridColumn687.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn687.Width = 40
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn688.CellAppearance = Appearance30
        UltraGridColumn688.Format = "#,###,###,##0.0000"
        UltraGridColumn688.Header.VisiblePosition = 26
        UltraGridColumn688.MaskInput = "{LOC}nnn,nnn.nnnn"
        UltraGridColumn688.Width = 60
        UltraGridColumn689.Header.VisiblePosition = 69
        UltraGridColumn689.Hidden = True
        UltraGridColumn689.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn689.Width = 40
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn690.CellAppearance = Appearance31
        UltraGridColumn690.Format = "###,###,##0.00"
        UltraGridColumn690.Header.VisiblePosition = 70
        UltraGridColumn691.Header.VisiblePosition = 71
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn692.CellAppearance = Appearance32
        UltraGridColumn692.Format = "#,###,###,##0.000"
        UltraGridColumn692.Header.VisiblePosition = 32
        UltraGridColumn692.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn692.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn692.Width = 100
        UltraGridColumn693.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn693.Header.Caption = "Retorno"
        UltraGridColumn693.Header.VisiblePosition = 72
        UltraGridColumn693.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn693.Width = 40
        UltraGridColumn694.Header.VisiblePosition = 74
        UltraGridColumn694.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn695.Header.VisiblePosition = 75
        UltraGridColumn695.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn696.Header.VisiblePosition = 76
        UltraGridColumn696.Hidden = True
        UltraGridColumn697.Header.VisiblePosition = 77
        UltraGridColumn697.Hidden = True
        UltraGridColumn698.Header.VisiblePosition = 78
        UltraGridColumn698.Hidden = True
        UltraGridColumn699.Header.VisiblePosition = 79
        UltraGridColumn699.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 80
        UltraGridColumn5.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 81
        UltraGridColumn9.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn620, UltraGridColumn621, UltraGridColumn622, UltraGridColumn623, UltraGridColumn624, UltraGridColumn625, UltraGridColumn626, UltraGridColumn627, UltraGridColumn628, UltraGridColumn629, UltraGridColumn630, UltraGridColumn631, UltraGridColumn632, UltraGridColumn633, UltraGridColumn634, UltraGridColumn635, UltraGridColumn636, UltraGridColumn637, UltraGridColumn638, UltraGridColumn639, UltraGridColumn640, UltraGridColumn641, UltraGridColumn642, UltraGridColumn643, UltraGridColumn644, UltraGridColumn645, UltraGridColumn646, UltraGridColumn647, UltraGridColumn648, UltraGridColumn649, UltraGridColumn650, UltraGridColumn651, UltraGridColumn652, UltraGridColumn653, UltraGridColumn654, UltraGridColumn655, UltraGridColumn656, UltraGridColumn657, UltraGridColumn658, UltraGridColumn659, UltraGridColumn660, UltraGridColumn661, UltraGridColumn662, UltraGridColumn663, UltraGridColumn664, UltraGridColumn665, UltraGridColumn666, UltraGridColumn667, UltraGridColumn668, UltraGridColumn669, UltraGridColumn670, UltraGridColumn671, UltraGridColumn672, UltraGridColumn673, UltraGridColumn674, UltraGridColumn675, UltraGridColumn676, UltraGridColumn677, UltraGridColumn678, UltraGridColumn679, UltraGridColumn680, UltraGridColumn681, UltraGridColumn682, UltraGridColumn683, UltraGridColumn684, UltraGridColumn685, UltraGridColumn686, UltraGridColumn687, UltraGridColumn688, UltraGridColumn689, UltraGridColumn690, UltraGridColumn691, UltraGridColumn692, UltraGridColumn693, UltraGridColumn694, UltraGridColumn695, UltraGridColumn696, UltraGridColumn697, UltraGridColumn698, UltraGridColumn699, UltraGridColumn5, UltraGridColumn9})
        UltraGridBand1.GroupHeadersVisible = False
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        RowLayoutColumnInfo2.OriginX = 0
        RowLayoutColumnInfo2.OriginY = 0
        RowLayoutColumnInfo2.SpanX = 2
        RowLayoutColumnInfo2.SpanY = 4
        RowLayoutColumnInfo4.OriginX = 2
        RowLayoutColumnInfo4.OriginY = 0
        RowLayoutColumnInfo4.SpanX = 2
        RowLayoutColumnInfo4.SpanY = 4
        RowLayoutColumnInfo6.OriginX = 6
        RowLayoutColumnInfo6.OriginY = 0
        RowLayoutColumnInfo6.SpanX = 2
        RowLayoutColumnInfo6.SpanY = 2
        RowLayoutColumnInfo8.OriginX = 6
        RowLayoutColumnInfo8.OriginY = 2
        RowLayoutColumnInfo8.SpanX = 2
        RowLayoutColumnInfo8.SpanY = 2
        RowLayoutColumnInfo10.OriginX = 8
        RowLayoutColumnInfo10.OriginY = 0
        RowLayoutColumnInfo10.SpanX = 2
        RowLayoutColumnInfo10.SpanY = 4
        RowLayoutColumnInfo11.OriginX = 16
        RowLayoutColumnInfo11.OriginY = 0
        RowLayoutColumnInfo11.PreferredCellSize = New System.Drawing.Size(61, 0)
        RowLayoutColumnInfo11.SpanX = 2
        RowLayoutColumnInfo11.SpanY = 2
        RowLayoutColumnInfo13.OriginX = 10
        RowLayoutColumnInfo13.OriginY = 0
        RowLayoutColumnInfo13.PreferredCellSize = New System.Drawing.Size(254, 0)
        RowLayoutColumnInfo13.SpanX = 2
        RowLayoutColumnInfo13.SpanY = 2
        RowLayoutColumnInfo15.OriginX = 10
        RowLayoutColumnInfo15.OriginY = 2
        RowLayoutColumnInfo15.PreferredCellSize = New System.Drawing.Size(254, 0)
        RowLayoutColumnInfo15.SpanX = 2
        RowLayoutColumnInfo15.SpanY = 2
        RowLayoutColumnInfo19.OriginX = 12
        RowLayoutColumnInfo19.OriginY = 0
        RowLayoutColumnInfo19.SpanX = 2
        RowLayoutColumnInfo19.SpanY = 2
        RowLayoutColumnInfo21.OriginX = 12
        RowLayoutColumnInfo21.OriginY = 2
        RowLayoutColumnInfo21.SpanX = 2
        RowLayoutColumnInfo21.SpanY = 2
        RowLayoutColumnInfo23.OriginX = 16
        RowLayoutColumnInfo23.OriginY = 2
        RowLayoutColumnInfo23.SpanX = 2
        RowLayoutColumnInfo23.SpanY = 2
        RowLayoutColumnInfo25.OriginX = 14
        RowLayoutColumnInfo25.OriginY = 0
        RowLayoutColumnInfo25.SpanX = 2
        RowLayoutColumnInfo25.SpanY = 4
        RowLayoutColumnInfo26.OriginX = 4
        RowLayoutColumnInfo26.OriginY = 0
        RowLayoutColumnInfo26.SpanX = 2
        RowLayoutColumnInfo26.SpanY = 2
        RowLayoutColumnInfo31.OriginX = 4
        RowLayoutColumnInfo31.OriginY = 2
        RowLayoutColumnInfo31.SpanX = 2
        RowLayoutColumnInfo31.SpanY = 2
        RowLayout1.ColumnInfos.AddRange(New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo() {RowLayoutColumnInfo1, RowLayoutColumnInfo2, RowLayoutColumnInfo3, RowLayoutColumnInfo4, RowLayoutColumnInfo5, RowLayoutColumnInfo6, RowLayoutColumnInfo7, RowLayoutColumnInfo8, RowLayoutColumnInfo9, RowLayoutColumnInfo10, RowLayoutColumnInfo11, RowLayoutColumnInfo12, RowLayoutColumnInfo13, RowLayoutColumnInfo14, RowLayoutColumnInfo15, RowLayoutColumnInfo16, RowLayoutColumnInfo17, RowLayoutColumnInfo18, RowLayoutColumnInfo19, RowLayoutColumnInfo20, RowLayoutColumnInfo21, RowLayoutColumnInfo22, RowLayoutColumnInfo23, RowLayoutColumnInfo24, RowLayoutColumnInfo25, RowLayoutColumnInfo26, RowLayoutColumnInfo27, RowLayoutColumnInfo28, RowLayoutColumnInfo29, RowLayoutColumnInfo30, RowLayoutColumnInfo31, RowLayoutColumnInfo32, RowLayoutColumnInfo33, RowLayoutColumnInfo34, RowLayoutColumnInfo35, RowLayoutColumnInfo36, RowLayoutColumnInfo37, RowLayoutColumnInfo38, RowLayoutColumnInfo39, RowLayoutColumnInfo40, RowLayoutColumnInfo41, RowLayoutColumnInfo42, RowLayoutColumnInfo43, RowLayoutColumnInfo44, RowLayoutColumnInfo45, RowLayoutColumnInfo46, RowLayoutColumnInfo47, RowLayoutColumnInfo48, RowLayoutColumnInfo49, RowLayoutColumnInfo50, RowLayoutColumnInfo51, RowLayoutColumnInfo52, RowLayoutColumnInfo53, RowLayoutColumnInfo54, RowLayoutColumnInfo55, RowLayoutColumnInfo56, RowLayoutColumnInfo57, RowLayoutColumnInfo58, RowLayoutColumnInfo59, RowLayoutColumnInfo60, RowLayoutColumnInfo61, RowLayoutColumnInfo62, RowLayoutColumnInfo63, RowLayoutColumnInfo64, RowLayoutColumnInfo65, RowLayoutColumnInfo66, RowLayoutColumnInfo67, RowLayoutColumnInfo68, RowLayoutColumnInfo69, RowLayoutColumnInfo70, RowLayoutColumnInfo71, RowLayoutColumnInfo72, RowLayoutColumnInfo73, RowLayoutColumnInfo74, RowLayoutColumnInfo75, RowLayoutColumnInfo76, RowLayoutColumnInfo77, RowLayoutColumnInfo78, RowLayoutColumnInfo79, RowLayoutColumnInfo80, RowLayoutColumnInfo81, RowLayoutColumnInfo82})
        RowLayout1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        UltraGridBand1.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout1})
        UltraGridBand1.SummaryFooterCaption = "Totales:"
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.DisplayLayout.UseFixedHeaders = True
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.ImageList = Me.imagenes
        Me.griLista.Location = New System.Drawing.Point(0, 0)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1242, 522)
        Me.griLista.TabIndex = 0
        Me.griLista.Tag = ""
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Insert, Me.Update, Me.Delete, Me.Programar, Me.Cancelada})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(207, 114)
        '
        'Insert
        '
        Me.Insert.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(206, 22)
        Me.Insert.Text = "Nuevo"
        Me.Insert.ToolTipText = "Insertar una nueva Pre-Demanda"
        '
        'Update
        '
        Me.Update.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(206, 22)
        Me.Update.Text = "Actualizar"
        Me.Update.ToolTipText = "Actualizar o modificar la Pre-Demanda seleccionada"
        '
        'Delete
        '
        Me.Delete.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(206, 22)
        Me.Delete.Text = "Eliminar"
        Me.Delete.ToolTipText = "Eliminar la Pre-Demanda seleccionada"
        '
        'Programar
        '
        Me.Programar.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.Programar.Name = "Programar"
        Me.Programar.Size = New System.Drawing.Size(206, 22)
        Me.Programar.Text = "Programar Viaje Desde Aqui"
        Me.Programar.ToolTipText = "Programar Viaje Basandose de este Programado"
        '
        'Cancelada
        '
        Me.Cancelada.Image = Global.ISL.Win.My.Resources.Resources.SymbolStop
        Me.Cancelada.Name = "Cancelada"
        Me.Cancelada.Size = New System.Drawing.Size(206, 22)
        Me.Cancelada.Text = "Cancelar"
        '
        'ogdListaOperacion
        '
        UltraDataColumn11.DataType = GetType(Boolean)
        UltraDataColumn26.DataType = GetType(Date)
        UltraDataColumn41.DataType = GetType(Date)
        UltraDataColumn42.DataType = GetType(Date)
        UltraDataColumn43.DataType = GetType(Date)
        UltraDataColumn44.DataType = GetType(Date)
        UltraDataColumn46.DefaultValue = ""
        UltraDataColumn50.DataType = GetType(Decimal)
        UltraDataColumn52.DataType = GetType(Decimal)
        UltraDataColumn71.DataType = GetType(Double)
        UltraDataColumn75.DataType = GetType(Date)
        UltraDataColumn76.DataType = GetType(Date)
        Me.ogdListaOperacion.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.griListaTerceros)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1242, 522)
        '
        'griListaTerceros
        '
        Me.griListaTerceros.CalcManager = Me.Calcular1
        Me.griListaTerceros.ContextMenuStrip = Me.Menu
        Me.griListaTerceros.DataSource = Me.ogdListaOperacion
        UltraGridColumn700.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn700.Header.VisiblePosition = 15
        UltraGridColumn700.Hidden = True
        UltraGridColumn701.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn701.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance33.TextHAlignAsString = "Center"
        Appearance33.TextVAlignAsString = "Middle"
        UltraGridColumn701.CellAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Center"
        UltraGridColumn701.Header.Appearance = Appearance34
        UltraGridColumn701.Header.Fixed = True
        UltraGridColumn701.Header.VisiblePosition = 0
        UltraGridColumn701.Hidden = True
        UltraGridColumn701.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn701.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn701.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn701.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn701.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn701.Width = 95
        UltraGridColumn702.Header.VisiblePosition = 16
        UltraGridColumn702.Hidden = True
        Appearance35.TextVAlignAsString = "Middle"
        UltraGridColumn703.CellAppearance = Appearance35
        UltraGridColumn703.Header.Caption = "Viaje"
        UltraGridColumn703.Header.Fixed = True
        UltraGridColumn703.Header.VisiblePosition = 1
        UltraGridColumn703.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn703.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn703.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn703.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn703.Width = 95
        UltraGridColumn704.Header.VisiblePosition = 17
        UltraGridColumn704.Hidden = True
        UltraGridColumn705.Header.Fixed = True
        UltraGridColumn705.Header.VisiblePosition = 3
        UltraGridColumn705.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn705.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn705.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn705.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn705.Width = 100
        UltraGridColumn706.Header.VisiblePosition = 18
        UltraGridColumn706.Hidden = True
        UltraGridColumn707.Header.Fixed = True
        UltraGridColumn707.Header.VisiblePosition = 4
        UltraGridColumn707.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn707.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn707.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn707.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn707.Width = 100
        Appearance36.Image = 3
        Appearance36.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn708.CellAppearance = Appearance36
        Appearance37.Image = 1
        Appearance37.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn708.CellButtonAppearance = Appearance37
        UltraGridColumn708.Header.Caption = "V.Retorno"
        UltraGridColumn708.Header.VisiblePosition = 73
        UltraGridColumn708.Hidden = True
        UltraGridColumn708.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn708.Width = 35
        Appearance38.TextVAlignAsString = "Middle"
        UltraGridColumn709.CellAppearance = Appearance38
        UltraGridColumn709.Header.Caption = "Demanda"
        UltraGridColumn709.Header.VisiblePosition = 19
        UltraGridColumn709.Hidden = True
        UltraGridColumn709.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn709.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn709.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn709.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn709.Width = 124
        Appearance39.TextVAlignAsString = "Middle"
        UltraGridColumn710.CellAppearance = Appearance39
        UltraGridColumn710.Header.Caption = "Vacio"
        UltraGridColumn710.Header.VisiblePosition = 33
        UltraGridColumn710.Hidden = True
        UltraGridColumn710.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn710.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn710.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn710.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn710.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn710.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn710.Width = 40
        UltraGridColumn711.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn711.Header.VisiblePosition = 20
        UltraGridColumn711.Hidden = True
        UltraGridColumn712.Header.VisiblePosition = 7
        UltraGridColumn712.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn712.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn712.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn712.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn712.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn712.Width = 150
        UltraGridColumn713.Header.VisiblePosition = 21
        UltraGridColumn713.Hidden = True
        Appearance40.Image = 7
        UltraGridColumn714.CellButtonAppearance = Appearance40
        UltraGridColumn714.Header.VisiblePosition = 8
        UltraGridColumn714.Hidden = True
        UltraGridColumn714.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn714.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn714.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn714.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn714.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn714.Width = 150
        UltraGridColumn715.Header.VisiblePosition = 14
        UltraGridColumn715.Hidden = True
        UltraGridColumn716.Header.Caption = "Proveedor / Tercero"
        UltraGridColumn716.Header.VisiblePosition = 29
        UltraGridColumn716.Width = 201
        UltraGridColumn717.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn717.Header.VisiblePosition = 13
        UltraGridColumn717.Hidden = True
        Appearance41.TextHAlignAsString = "Left"
        Appearance41.TextVAlignAsString = "Middle"
        UltraGridColumn718.CellAppearance = Appearance41
        UltraGridColumn718.Header.Fixed = True
        UltraGridColumn718.Header.VisiblePosition = 5
        UltraGridColumn718.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn718.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn718.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn718.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn718.Width = 80
        UltraGridColumn719.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn719.Header.VisiblePosition = 12
        UltraGridColumn719.Hidden = True
        Appearance42.TextHAlignAsString = "Left"
        Appearance42.TextVAlignAsString = "Middle"
        UltraGridColumn720.CellAppearance = Appearance42
        UltraGridColumn720.Header.Fixed = True
        UltraGridColumn720.Header.VisiblePosition = 6
        UltraGridColumn720.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn720.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn720.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn720.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn720.VertScrollBar = True
        UltraGridColumn720.Width = 80
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn721.CellAppearance = Appearance43
        UltraGridColumn721.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn721.Header.VisiblePosition = 26
        UltraGridColumn721.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        Appearance44.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance44.TextHAlignAsString = "Right"
        UltraGridColumn722.CellAppearance = Appearance44
        UltraGridColumn722.Format = "#,###,###,##0.000"
        UltraGridColumn722.Header.VisiblePosition = 27
        UltraGridColumn722.MaskInput = "{LOC}n,nnn,nnn.nn"
        UltraGridColumn722.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn722.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn722.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn722.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn722.Width = 100
        UltraGridColumn723.Header.VisiblePosition = 23
        UltraGridColumn723.Hidden = True
        Appearance45.TextVAlignAsString = "Middle"
        UltraGridColumn724.CellAppearance = Appearance45
        UltraGridColumn724.Header.VisiblePosition = 34
        UltraGridColumn724.Hidden = True
        UltraGridColumn724.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn724.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn724.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn724.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn724.Width = 100
        UltraGridColumn725.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn725.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn725.Header.Caption = "Fecha Atencion"
        UltraGridColumn725.Header.Fixed = True
        UltraGridColumn725.Header.VisiblePosition = 2
        UltraGridColumn725.MaskInput = "{date} {time}"
        UltraGridColumn725.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn725.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn725.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn725.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn725.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn725.Width = 100
        UltraGridColumn726.Header.Caption = "UsuarioCrea"
        UltraGridColumn726.Header.VisiblePosition = 52
        UltraGridColumn726.Hidden = True
        UltraGridColumn726.Width = 150
        UltraGridColumn727.Header.VisiblePosition = 30
        UltraGridColumn727.Hidden = True
        UltraGridColumn728.Header.VisiblePosition = 22
        UltraGridColumn728.Hidden = True
        UltraGridColumn729.Header.VisiblePosition = 31
        UltraGridColumn729.Hidden = True
        Appearance46.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn730.CellAppearance = Appearance46
        UltraGridColumn730.Header.VisiblePosition = 50
        UltraGridColumn730.Hidden = True
        UltraGridColumn730.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn730.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn730.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn730.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn730.Width = 100
        UltraGridColumn731.Header.VisiblePosition = 35
        UltraGridColumn731.Hidden = True
        UltraGridColumn732.Header.VisiblePosition = 36
        UltraGridColumn732.Hidden = True
        UltraGridColumn733.Header.VisiblePosition = 37
        UltraGridColumn733.Hidden = True
        UltraGridColumn734.Header.VisiblePosition = 9
        UltraGridColumn734.Width = 150
        UltraGridColumn735.Header.VisiblePosition = 38
        UltraGridColumn735.Hidden = True
        UltraGridColumn736.Header.VisiblePosition = 39
        UltraGridColumn736.Hidden = True
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn737.CellAppearance = Appearance47
        UltraGridColumn737.Header.VisiblePosition = 10
        UltraGridColumn737.Width = 100
        UltraGridColumn738.Header.VisiblePosition = 53
        UltraGridColumn738.Hidden = True
        UltraGridColumn738.Width = 150
        UltraGridColumn739.Header.VisiblePosition = 54
        UltraGridColumn739.Hidden = True
        UltraGridColumn739.Width = 150
        UltraGridColumn740.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn740.Header.VisiblePosition = 40
        UltraGridColumn740.Hidden = True
        UltraGridColumn740.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn740.Width = 100
        UltraGridColumn741.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn741.Header.VisiblePosition = 41
        UltraGridColumn741.Hidden = True
        UltraGridColumn741.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn741.Width = 100
        UltraGridColumn742.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn742.Header.VisiblePosition = 42
        UltraGridColumn742.Hidden = True
        UltraGridColumn742.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn742.Width = 100
        UltraGridColumn743.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn743.Header.VisiblePosition = 43
        UltraGridColumn743.Hidden = True
        UltraGridColumn743.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn743.Width = 100
        UltraGridColumn744.Header.VisiblePosition = 51
        UltraGridColumn744.Hidden = True
        UltraGridColumn744.Width = 100
        UltraGridColumn745.Header.VisiblePosition = 55
        UltraGridColumn745.Hidden = True
        UltraGridColumn745.Width = 250
        UltraGridColumn746.Header.VisiblePosition = 56
        UltraGridColumn746.Hidden = True
        UltraGridColumn746.Width = 250
        UltraGridColumn747.Header.Caption = "Bloque"
        UltraGridColumn747.Header.VisiblePosition = 57
        UltraGridColumn747.Hidden = True
        UltraGridColumn747.Width = 40
        UltraGridColumn748.Header.Caption = "D/N"
        UltraGridColumn748.Header.VisiblePosition = 58
        UltraGridColumn748.Hidden = True
        UltraGridColumn748.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn748.Width = 40
        UltraGridColumn749.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance48.TextHAlignAsString = "Right"
        Appearance48.TextVAlignAsString = "Middle"
        UltraGridColumn749.CellAppearance = Appearance48
        UltraGridColumn749.Format = "#,###,###,##0.00"
        UltraGridColumn749.Header.Caption = "TN"
        UltraGridColumn749.Header.VisiblePosition = 11
        UltraGridColumn749.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn749.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn749.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn749.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn749.Width = 40
        UltraGridColumn750.Header.Caption = "TipoCarga"
        UltraGridColumn750.Header.VisiblePosition = 28
        UltraGridColumn750.Width = 100
        Appearance49.TextHAlignAsString = "Right"
        UltraGridColumn751.CellAppearance = Appearance49
        UltraGridColumn751.Format = "#,###,###,##0.00"
        UltraGridColumn751.Header.VisiblePosition = 32
        UltraGridColumn751.Hidden = True
        UltraGridColumn751.MaskInput = "{currency:9.2}"
        UltraGridColumn751.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn751.Width = 100
        UltraGridColumn752.Header.VisiblePosition = 59
        UltraGridColumn752.Hidden = True
        UltraGridColumn752.Width = 40
        UltraGridColumn753.Header.Caption = "Ind"
        UltraGridColumn753.Header.VisiblePosition = 60
        UltraGridColumn753.Hidden = True
        UltraGridColumn753.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn753.Width = 40
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn754.CellAppearance = Appearance50
        UltraGridColumn754.Header.Caption = "Terc.TotalFlete"
        UltraGridColumn754.Header.VisiblePosition = 48
        UltraGridColumn754.MaskInput = "{LOC}nnnnnnn.nnn"
        UltraGridColumn754.Width = 70
        Appearance51.TextHAlignAsString = "Right"
        UltraGridColumn755.CellAppearance = Appearance51
        UltraGridColumn755.Header.Caption = "Terc. Cant."
        UltraGridColumn755.Header.VisiblePosition = 44
        UltraGridColumn755.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn755.Width = 50
        Appearance52.TextHAlignAsString = "Right"
        UltraGridColumn756.CellAppearance = Appearance52
        UltraGridColumn756.Header.Caption = "Terc.Flete Unit."
        UltraGridColumn756.Header.VisiblePosition = 45
        UltraGridColumn756.MaskInput = "{LOC}nnnnnnnnnn.nnn"
        UltraGridColumn756.Width = 70
        Appearance53.TextHAlignAsString = "Right"
        UltraGridColumn757.CellAppearance = Appearance53
        UltraGridColumn757.Header.Caption = "Terc.SubTotal"
        UltraGridColumn757.Header.VisiblePosition = 46
        UltraGridColumn757.MaskInput = "{LOC}nnnnnnnnnn.nnn"
        UltraGridColumn757.Width = 70
        Appearance54.TextHAlignAsString = "Right"
        UltraGridColumn758.CellAppearance = Appearance54
        UltraGridColumn758.Header.Caption = "Terc.IGV"
        UltraGridColumn758.Header.VisiblePosition = 47
        UltraGridColumn758.MaskInput = "{LOC}nnnn.nnn"
        UltraGridColumn758.Width = 50
        UltraGridColumn759.Header.VisiblePosition = 61
        UltraGridColumn759.Hidden = True
        UltraGridColumn760.Header.VisiblePosition = 62
        UltraGridColumn760.Hidden = True
        UltraGridColumn761.Header.VisiblePosition = 63
        UltraGridColumn761.Hidden = True
        UltraGridColumn762.Header.VisiblePosition = 64
        UltraGridColumn762.Hidden = True
        UltraGridColumn763.Header.VisiblePosition = 66
        UltraGridColumn763.Hidden = True
        UltraGridColumn764.Header.VisiblePosition = 65
        UltraGridColumn764.Hidden = True
        UltraGridColumn765.Header.VisiblePosition = 67
        UltraGridColumn765.Hidden = True
        UltraGridColumn766.Header.VisiblePosition = 68
        UltraGridColumn766.Hidden = True
        Appearance55.TextHAlignAsString = "Right"
        UltraGridColumn767.CellAppearance = Appearance55
        UltraGridColumn767.Format = "#,###,###,##0.00"
        UltraGridColumn767.Header.Caption = "Cant."
        UltraGridColumn767.Header.VisiblePosition = 24
        UltraGridColumn767.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn767.Width = 40
        Appearance56.TextHAlignAsString = "Right"
        UltraGridColumn768.CellAppearance = Appearance56
        UltraGridColumn768.Format = "#,###,###,##0.00"
        UltraGridColumn768.Header.VisiblePosition = 25
        UltraGridColumn768.MaskInput = "{LOC}nnn,nnn.nnnn"
        UltraGridColumn768.Width = 60
        UltraGridColumn769.Header.VisiblePosition = 69
        UltraGridColumn769.Hidden = True
        UltraGridColumn769.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn769.Width = 40
        UltraGridColumn770.Header.VisiblePosition = 70
        UltraGridColumn770.Hidden = True
        UltraGridColumn771.Header.VisiblePosition = 71
        UltraGridColumn771.Hidden = True
        Appearance57.TextHAlignAsString = "Right"
        UltraGridColumn772.CellAppearance = Appearance57
        UltraGridColumn772.Format = ""
        UltraGridColumn772.Header.Caption = "Terc.Comision"
        UltraGridColumn772.Header.VisiblePosition = 49
        UltraGridColumn772.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn772.Width = 70
        UltraGridColumn773.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn773.Header.Caption = "Retorno"
        UltraGridColumn773.Header.VisiblePosition = 72
        UltraGridColumn773.Hidden = True
        UltraGridColumn773.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn773.Width = 40
        UltraGridColumn774.Header.VisiblePosition = 74
        UltraGridColumn774.Hidden = True
        UltraGridColumn774.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn775.Header.VisiblePosition = 75
        UltraGridColumn775.Hidden = True
        UltraGridColumn775.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn776.Header.VisiblePosition = 76
        UltraGridColumn776.Hidden = True
        UltraGridColumn777.Header.VisiblePosition = 77
        UltraGridColumn777.Hidden = True
        UltraGridColumn778.Header.VisiblePosition = 78
        UltraGridColumn778.Hidden = True
        UltraGridColumn779.Header.VisiblePosition = 79
        UltraGridColumn779.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 80
        UltraGridColumn10.Header.VisiblePosition = 81
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn700, UltraGridColumn701, UltraGridColumn702, UltraGridColumn703, UltraGridColumn704, UltraGridColumn705, UltraGridColumn706, UltraGridColumn707, UltraGridColumn708, UltraGridColumn709, UltraGridColumn710, UltraGridColumn711, UltraGridColumn712, UltraGridColumn713, UltraGridColumn714, UltraGridColumn715, UltraGridColumn716, UltraGridColumn717, UltraGridColumn718, UltraGridColumn719, UltraGridColumn720, UltraGridColumn721, UltraGridColumn722, UltraGridColumn723, UltraGridColumn724, UltraGridColumn725, UltraGridColumn726, UltraGridColumn727, UltraGridColumn728, UltraGridColumn729, UltraGridColumn730, UltraGridColumn731, UltraGridColumn732, UltraGridColumn733, UltraGridColumn734, UltraGridColumn735, UltraGridColumn736, UltraGridColumn737, UltraGridColumn738, UltraGridColumn739, UltraGridColumn740, UltraGridColumn741, UltraGridColumn742, UltraGridColumn743, UltraGridColumn744, UltraGridColumn745, UltraGridColumn746, UltraGridColumn747, UltraGridColumn748, UltraGridColumn749, UltraGridColumn750, UltraGridColumn751, UltraGridColumn752, UltraGridColumn753, UltraGridColumn754, UltraGridColumn755, UltraGridColumn756, UltraGridColumn757, UltraGridColumn758, UltraGridColumn759, UltraGridColumn760, UltraGridColumn761, UltraGridColumn762, UltraGridColumn763, UltraGridColumn764, UltraGridColumn765, UltraGridColumn766, UltraGridColumn767, UltraGridColumn768, UltraGridColumn769, UltraGridColumn770, UltraGridColumn771, UltraGridColumn772, UltraGridColumn773, UltraGridColumn774, UltraGridColumn775, UltraGridColumn776, UltraGridColumn777, UltraGridColumn778, UltraGridColumn779, UltraGridColumn6, UltraGridColumn10})
        UltraGridBand2.GroupHeadersVisible = False
        UltraGridBand2.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        RowLayoutColumnInfo84.OriginX = 0
        RowLayoutColumnInfo84.OriginY = 0
        RowLayoutColumnInfo84.SpanX = 2
        RowLayoutColumnInfo84.SpanY = 4
        RowLayoutColumnInfo86.OriginX = 2
        RowLayoutColumnInfo86.OriginY = 0
        RowLayoutColumnInfo86.SpanX = 2
        RowLayoutColumnInfo86.SpanY = 4
        RowLayoutColumnInfo88.OriginX = 6
        RowLayoutColumnInfo88.OriginY = 0
        RowLayoutColumnInfo88.SpanX = 2
        RowLayoutColumnInfo88.SpanY = 2
        RowLayoutColumnInfo90.OriginX = 6
        RowLayoutColumnInfo90.OriginY = 2
        RowLayoutColumnInfo90.SpanX = 2
        RowLayoutColumnInfo90.SpanY = 2
        RowLayoutColumnInfo92.OriginX = 8
        RowLayoutColumnInfo92.OriginY = 0
        RowLayoutColumnInfo92.SpanX = 2
        RowLayoutColumnInfo92.SpanY = 4
        RowLayoutColumnInfo93.OriginX = 16
        RowLayoutColumnInfo93.OriginY = 0
        RowLayoutColumnInfo93.PreferredCellSize = New System.Drawing.Size(61, 0)
        RowLayoutColumnInfo93.SpanX = 2
        RowLayoutColumnInfo93.SpanY = 2
        RowLayoutColumnInfo95.OriginX = 10
        RowLayoutColumnInfo95.OriginY = 0
        RowLayoutColumnInfo95.PreferredCellSize = New System.Drawing.Size(254, 0)
        RowLayoutColumnInfo95.SpanX = 2
        RowLayoutColumnInfo95.SpanY = 2
        RowLayoutColumnInfo97.OriginX = 10
        RowLayoutColumnInfo97.OriginY = 2
        RowLayoutColumnInfo97.PreferredCellSize = New System.Drawing.Size(254, 0)
        RowLayoutColumnInfo97.SpanX = 2
        RowLayoutColumnInfo97.SpanY = 2
        RowLayoutColumnInfo101.OriginX = 12
        RowLayoutColumnInfo101.OriginY = 0
        RowLayoutColumnInfo101.SpanX = 2
        RowLayoutColumnInfo101.SpanY = 2
        RowLayoutColumnInfo103.OriginX = 12
        RowLayoutColumnInfo103.OriginY = 2
        RowLayoutColumnInfo103.SpanX = 2
        RowLayoutColumnInfo103.SpanY = 2
        RowLayoutColumnInfo105.OriginX = 16
        RowLayoutColumnInfo105.OriginY = 2
        RowLayoutColumnInfo105.SpanX = 2
        RowLayoutColumnInfo105.SpanY = 2
        RowLayoutColumnInfo107.OriginX = 14
        RowLayoutColumnInfo107.OriginY = 0
        RowLayoutColumnInfo107.SpanX = 2
        RowLayoutColumnInfo107.SpanY = 4
        RowLayoutColumnInfo108.OriginX = 4
        RowLayoutColumnInfo108.OriginY = 0
        RowLayoutColumnInfo108.SpanX = 2
        RowLayoutColumnInfo108.SpanY = 2
        RowLayoutColumnInfo113.OriginX = 4
        RowLayoutColumnInfo113.OriginY = 2
        RowLayoutColumnInfo113.SpanX = 2
        RowLayoutColumnInfo113.SpanY = 2
        RowLayout2.ColumnInfos.AddRange(New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo() {RowLayoutColumnInfo83, RowLayoutColumnInfo84, RowLayoutColumnInfo85, RowLayoutColumnInfo86, RowLayoutColumnInfo87, RowLayoutColumnInfo88, RowLayoutColumnInfo89, RowLayoutColumnInfo90, RowLayoutColumnInfo91, RowLayoutColumnInfo92, RowLayoutColumnInfo93, RowLayoutColumnInfo94, RowLayoutColumnInfo95, RowLayoutColumnInfo96, RowLayoutColumnInfo97, RowLayoutColumnInfo98, RowLayoutColumnInfo99, RowLayoutColumnInfo100, RowLayoutColumnInfo101, RowLayoutColumnInfo102, RowLayoutColumnInfo103, RowLayoutColumnInfo104, RowLayoutColumnInfo105, RowLayoutColumnInfo106, RowLayoutColumnInfo107, RowLayoutColumnInfo108, RowLayoutColumnInfo109, RowLayoutColumnInfo110, RowLayoutColumnInfo111, RowLayoutColumnInfo112, RowLayoutColumnInfo113, RowLayoutColumnInfo114, RowLayoutColumnInfo115, RowLayoutColumnInfo116, RowLayoutColumnInfo117, RowLayoutColumnInfo118, RowLayoutColumnInfo119, RowLayoutColumnInfo120, RowLayoutColumnInfo121, RowLayoutColumnInfo122, RowLayoutColumnInfo123, RowLayoutColumnInfo124, RowLayoutColumnInfo125, RowLayoutColumnInfo126, RowLayoutColumnInfo127, RowLayoutColumnInfo128, RowLayoutColumnInfo129, RowLayoutColumnInfo130, RowLayoutColumnInfo131, RowLayoutColumnInfo132, RowLayoutColumnInfo133, RowLayoutColumnInfo134, RowLayoutColumnInfo135, RowLayoutColumnInfo136, RowLayoutColumnInfo137, RowLayoutColumnInfo138, RowLayoutColumnInfo139, RowLayoutColumnInfo140, RowLayoutColumnInfo141, RowLayoutColumnInfo142, RowLayoutColumnInfo143, RowLayoutColumnInfo144, RowLayoutColumnInfo145, RowLayoutColumnInfo146, RowLayoutColumnInfo147, RowLayoutColumnInfo148, RowLayoutColumnInfo149, RowLayoutColumnInfo150, RowLayoutColumnInfo151, RowLayoutColumnInfo152, RowLayoutColumnInfo153, RowLayoutColumnInfo154, RowLayoutColumnInfo155, RowLayoutColumnInfo156, RowLayoutColumnInfo157, RowLayoutColumnInfo158, RowLayoutColumnInfo159, RowLayoutColumnInfo160, RowLayoutColumnInfo161, RowLayoutColumnInfo162, RowLayoutColumnInfo163, RowLayoutColumnInfo164})
        RowLayout2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        UltraGridBand2.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout2})
        UltraGridBand2.SummaryFooterCaption = "Totales:"
        Me.griListaTerceros.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaTerceros.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaTerceros.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaTerceros.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaTerceros.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaTerceros.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaTerceros.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaTerceros.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaTerceros.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaTerceros.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaTerceros.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaTerceros.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaTerceros.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaTerceros.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaTerceros.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griListaTerceros.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaTerceros.DisplayLayout.UseFixedHeaders = True
        Me.griListaTerceros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaTerceros.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaTerceros.ImageList = Me.imagenes
        Me.griListaTerceros.Location = New System.Drawing.Point(0, 0)
        Me.griListaTerceros.Name = "griListaTerceros"
        Me.griListaTerceros.Size = New System.Drawing.Size(1242, 522)
        Me.griListaTerceros.TabIndex = 1
        Me.griListaTerceros.Tag = ""
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.griViajesProceso)
        Me.UltraTabPageControl16.Controls.Add(Me.UltraExpandableGroupBox5)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(1242, 522)
        '
        'griViajesProceso
        '
        Me.griViajesProceso.CalcManager = Me.Calcular1
        Me.griViajesProceso.ContextMenuStrip = Me.Menu
        Me.griViajesProceso.DataSource = Me.ogdListaOperacion
        UltraGridColumn780.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn780.Header.VisiblePosition = 19
        UltraGridColumn780.Hidden = True
        UltraGridColumn781.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn781.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance58.TextHAlignAsString = "Center"
        Appearance58.TextVAlignAsString = "Middle"
        UltraGridColumn781.CellAppearance = Appearance58
        Appearance59.TextHAlignAsString = "Center"
        UltraGridColumn781.Header.Appearance = Appearance59
        UltraGridColumn781.Header.Fixed = True
        UltraGridColumn781.Header.VisiblePosition = 0
        UltraGridColumn781.Hidden = True
        UltraGridColumn781.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn781.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn781.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn781.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn781.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn781.Width = 95
        UltraGridColumn782.Header.VisiblePosition = 20
        UltraGridColumn782.Hidden = True
        Appearance60.TextVAlignAsString = "Middle"
        UltraGridColumn783.CellAppearance = Appearance60
        UltraGridColumn783.Header.Caption = "Viaje"
        UltraGridColumn783.Header.Fixed = True
        UltraGridColumn783.Header.VisiblePosition = 1
        UltraGridColumn783.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn783.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn783.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn783.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn783.Width = 95
        UltraGridColumn784.Header.Caption = "Tracto Desengancha"
        UltraGridColumn784.Header.VisiblePosition = 10
        UltraGridColumn784.Width = 75
        UltraGridColumn785.Header.Fixed = True
        UltraGridColumn785.Header.VisiblePosition = 3
        UltraGridColumn785.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn785.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn785.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn785.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn785.Width = 100
        UltraGridColumn786.Header.Caption = "Tracto Ficticio"
        UltraGridColumn786.Header.VisiblePosition = 11
        UltraGridColumn786.Width = 75
        UltraGridColumn787.Header.Fixed = True
        UltraGridColumn787.Header.VisiblePosition = 4
        UltraGridColumn787.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn787.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn787.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn787.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn787.Width = 100
        UltraGridColumn788.Header.Caption = "Tracto Engancha"
        UltraGridColumn788.Header.VisiblePosition = 12
        UltraGridColumn788.Width = 75
        Appearance61.TextVAlignAsString = "Middle"
        UltraGridColumn789.CellAppearance = Appearance61
        UltraGridColumn789.Header.Caption = "Demanda"
        UltraGridColumn789.Header.VisiblePosition = 21
        UltraGridColumn789.Hidden = True
        UltraGridColumn789.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn789.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn789.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn789.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn789.Width = 124
        Appearance62.TextVAlignAsString = "Middle"
        UltraGridColumn790.CellAppearance = Appearance62
        UltraGridColumn790.Header.Caption = "Vacio"
        UltraGridColumn790.Header.VisiblePosition = 35
        UltraGridColumn790.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn790.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn790.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn790.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn790.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn790.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn790.Width = 40
        UltraGridColumn791.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn791.Header.VisiblePosition = 22
        UltraGridColumn791.Hidden = True
        Appearance63.Image = 7
        UltraGridColumn792.CellAppearance = Appearance63
        Appearance64.Image = 3
        UltraGridColumn792.CellButtonAppearance = Appearance64
        UltraGridColumn792.Header.VisiblePosition = 7
        UltraGridColumn792.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn792.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn792.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn792.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn792.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn792.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn792.Width = 150
        UltraGridColumn793.Header.VisiblePosition = 23
        UltraGridColumn793.Hidden = True
        Appearance65.Image = 7
        UltraGridColumn794.CellButtonAppearance = Appearance65
        UltraGridColumn794.Header.VisiblePosition = 8
        UltraGridColumn794.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn794.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn794.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn794.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn794.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn794.Width = 150
        UltraGridColumn795.Header.VisiblePosition = 18
        UltraGridColumn795.Hidden = True
        UltraGridColumn796.Header.VisiblePosition = 17
        UltraGridColumn796.Hidden = True
        UltraGridColumn797.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn797.Header.VisiblePosition = 16
        UltraGridColumn797.Hidden = True
        Appearance66.TextHAlignAsString = "Left"
        Appearance66.TextVAlignAsString = "Middle"
        UltraGridColumn798.CellAppearance = Appearance66
        UltraGridColumn798.Header.Fixed = True
        UltraGridColumn798.Header.VisiblePosition = 5
        UltraGridColumn798.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn798.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn798.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn798.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn798.Width = 80
        UltraGridColumn799.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn799.Header.VisiblePosition = 15
        UltraGridColumn799.Hidden = True
        Appearance67.TextHAlignAsString = "Left"
        Appearance67.TextVAlignAsString = "Middle"
        UltraGridColumn800.CellAppearance = Appearance67
        UltraGridColumn800.Header.Fixed = True
        UltraGridColumn800.Header.VisiblePosition = 6
        UltraGridColumn800.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn800.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn800.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn800.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn800.VertScrollBar = True
        UltraGridColumn800.Width = 80
        Appearance68.TextHAlignAsString = "Right"
        UltraGridColumn801.CellAppearance = Appearance68
        UltraGridColumn801.Format = "###,##0.000"
        UltraGridColumn801.Header.VisiblePosition = 28
        Appearance69.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance69.TextHAlignAsString = "Right"
        UltraGridColumn802.CellAppearance = Appearance69
        UltraGridColumn802.Format = "#,###,###,##0.000"
        UltraGridColumn802.Header.VisiblePosition = 29
        UltraGridColumn802.MaskInput = "{LOC}n,nnn,nnn.nn"
        UltraGridColumn802.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn802.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn802.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn802.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn802.Width = 100
        UltraGridColumn803.Header.VisiblePosition = 25
        UltraGridColumn803.Hidden = True
        Appearance70.TextVAlignAsString = "Middle"
        UltraGridColumn804.CellAppearance = Appearance70
        UltraGridColumn804.Header.VisiblePosition = 36
        UltraGridColumn804.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn804.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn804.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn804.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn804.Width = 100
        UltraGridColumn805.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn805.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn805.Header.Caption = "Fecha Atencion"
        UltraGridColumn805.Header.Fixed = True
        UltraGridColumn805.Header.VisiblePosition = 2
        UltraGridColumn805.MaskInput = "{date} {time}"
        UltraGridColumn805.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn805.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn805.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn805.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn805.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn805.Width = 100
        UltraGridColumn806.Header.Caption = "UsuarioCrea"
        UltraGridColumn806.Header.VisiblePosition = 53
        UltraGridColumn806.Hidden = True
        UltraGridColumn806.Width = 150
        UltraGridColumn807.Header.VisiblePosition = 30
        UltraGridColumn807.Hidden = True
        UltraGridColumn808.Header.VisiblePosition = 24
        UltraGridColumn808.Hidden = True
        UltraGridColumn809.Header.VisiblePosition = 31
        UltraGridColumn809.Hidden = True
        Appearance71.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn810.CellAppearance = Appearance71
        UltraGridColumn810.Header.VisiblePosition = 50
        UltraGridColumn810.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn810.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn810.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn810.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn810.Width = 100
        UltraGridColumn811.Header.VisiblePosition = 37
        UltraGridColumn811.Hidden = True
        UltraGridColumn812.Header.VisiblePosition = 38
        UltraGridColumn812.Hidden = True
        UltraGridColumn813.Header.VisiblePosition = 39
        UltraGridColumn813.Hidden = True
        UltraGridColumn814.Header.VisiblePosition = 9
        UltraGridColumn814.Width = 150
        UltraGridColumn815.Header.VisiblePosition = 40
        UltraGridColumn815.Hidden = True
        UltraGridColumn816.Header.VisiblePosition = 41
        UltraGridColumn816.Hidden = True
        Appearance72.TextHAlignAsString = "Right"
        UltraGridColumn817.CellAppearance = Appearance72
        UltraGridColumn817.Header.VisiblePosition = 13
        UltraGridColumn817.Width = 100
        UltraGridColumn818.Header.VisiblePosition = 54
        UltraGridColumn818.Width = 150
        UltraGridColumn819.Header.VisiblePosition = 55
        UltraGridColumn819.Hidden = True
        UltraGridColumn819.Width = 150
        UltraGridColumn820.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn820.Header.VisiblePosition = 42
        UltraGridColumn820.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn820.Width = 100
        UltraGridColumn821.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn821.Header.VisiblePosition = 43
        UltraGridColumn821.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn821.Width = 100
        UltraGridColumn822.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn822.Header.VisiblePosition = 44
        UltraGridColumn822.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn822.Width = 100
        UltraGridColumn823.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn823.Header.VisiblePosition = 45
        UltraGridColumn823.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn823.Width = 100
        UltraGridColumn824.Header.VisiblePosition = 51
        UltraGridColumn824.Width = 100
        Appearance73.Image = 3
        Appearance73.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn825.CellAppearance = Appearance73
        Appearance74.Image = 1
        UltraGridColumn825.CellButtonAppearance = Appearance74
        UltraGridColumn825.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn825.Header.VisiblePosition = 56
        UltraGridColumn825.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn825.Width = 250
        UltraGridColumn826.Header.VisiblePosition = 57
        UltraGridColumn826.Width = 250
        UltraGridColumn827.Header.Caption = "Bloque"
        UltraGridColumn827.Header.VisiblePosition = 58
        UltraGridColumn827.Hidden = True
        UltraGridColumn827.Width = 40
        UltraGridColumn828.Header.Caption = "D/N"
        UltraGridColumn828.Header.VisiblePosition = 59
        UltraGridColumn828.Hidden = True
        UltraGridColumn828.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn828.Width = 40
        UltraGridColumn829.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance75.TextHAlignAsString = "Right"
        Appearance75.TextVAlignAsString = "Middle"
        UltraGridColumn829.CellAppearance = Appearance75
        UltraGridColumn829.Format = "#,###,###,##0.00"
        UltraGridColumn829.Header.Caption = "TN"
        UltraGridColumn829.Header.VisiblePosition = 14
        UltraGridColumn829.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn829.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn829.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn829.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn829.Width = 40
        UltraGridColumn830.Header.VisiblePosition = 52
        UltraGridColumn830.Width = 100
        Appearance76.TextHAlignAsString = "Right"
        UltraGridColumn831.CellAppearance = Appearance76
        UltraGridColumn831.Format = "#,###,###,##0.00"
        UltraGridColumn831.Header.VisiblePosition = 34
        UltraGridColumn831.Hidden = True
        UltraGridColumn831.MaskInput = "{currency:9.2}"
        UltraGridColumn831.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn831.Width = 100
        UltraGridColumn832.Header.VisiblePosition = 60
        UltraGridColumn832.Hidden = True
        UltraGridColumn832.Width = 40
        UltraGridColumn833.Header.Caption = "Ind"
        UltraGridColumn833.Header.VisiblePosition = 61
        UltraGridColumn833.Hidden = True
        UltraGridColumn833.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn833.Width = 40
        UltraGridColumn834.Header.Caption = "%Flete"
        UltraGridColumn834.Header.VisiblePosition = 32
        UltraGridColumn834.Width = 40
        Appearance77.TextHAlignAsString = "Right"
        UltraGridColumn835.CellAppearance = Appearance77
        UltraGridColumn835.Header.Caption = "KmTracto O"
        UltraGridColumn835.Header.VisiblePosition = 46
        UltraGridColumn835.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn835.Width = 70
        Appearance78.TextHAlignAsString = "Right"
        UltraGridColumn836.CellAppearance = Appearance78
        UltraGridColumn836.Header.Caption = "KmTracto D"
        UltraGridColumn836.Header.VisiblePosition = 47
        UltraGridColumn836.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn836.Width = 70
        Appearance79.TextHAlignAsString = "Right"
        UltraGridColumn837.CellAppearance = Appearance79
        UltraGridColumn837.Header.Caption = "KmCarreta O"
        UltraGridColumn837.Header.VisiblePosition = 48
        UltraGridColumn837.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn837.Width = 70
        Appearance80.TextHAlignAsString = "Right"
        UltraGridColumn838.CellAppearance = Appearance80
        UltraGridColumn838.Header.Caption = "KmCarreta D"
        UltraGridColumn838.Header.VisiblePosition = 49
        UltraGridColumn838.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn838.Width = 70
        UltraGridColumn839.Header.VisiblePosition = 62
        UltraGridColumn839.Hidden = True
        UltraGridColumn840.Header.VisiblePosition = 63
        UltraGridColumn840.Hidden = True
        UltraGridColumn841.Header.VisiblePosition = 64
        UltraGridColumn841.Hidden = True
        UltraGridColumn842.Header.VisiblePosition = 65
        UltraGridColumn842.Hidden = True
        UltraGridColumn843.Header.VisiblePosition = 67
        UltraGridColumn843.Hidden = True
        UltraGridColumn844.Header.VisiblePosition = 66
        UltraGridColumn844.Hidden = True
        UltraGridColumn845.Header.VisiblePosition = 68
        UltraGridColumn845.Hidden = True
        UltraGridColumn846.Header.VisiblePosition = 69
        UltraGridColumn846.Hidden = True
        Appearance81.TextHAlignAsString = "Right"
        UltraGridColumn847.CellAppearance = Appearance81
        UltraGridColumn847.Format = "#,###,###,##0.00"
        UltraGridColumn847.Header.Caption = "Cant."
        UltraGridColumn847.Header.VisiblePosition = 26
        UltraGridColumn847.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn847.Width = 40
        Appearance82.TextHAlignAsString = "Right"
        UltraGridColumn848.CellAppearance = Appearance82
        UltraGridColumn848.Format = "#,###,###,##0.000"
        UltraGridColumn848.Header.VisiblePosition = 27
        UltraGridColumn848.MaskInput = "{LOC}nnn,nnn.nnnn"
        UltraGridColumn848.Width = 60
        UltraGridColumn849.Header.VisiblePosition = 70
        UltraGridColumn849.Hidden = True
        UltraGridColumn849.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn849.Width = 40
        UltraGridColumn850.Header.VisiblePosition = 71
        UltraGridColumn851.Header.VisiblePosition = 72
        Appearance83.TextHAlignAsString = "Right"
        UltraGridColumn852.CellAppearance = Appearance83
        UltraGridColumn852.Format = "#,###,###,##0.000"
        UltraGridColumn852.Header.VisiblePosition = 33
        UltraGridColumn852.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn852.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn852.Width = 100
        UltraGridColumn853.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn853.Header.Caption = "Retorno"
        UltraGridColumn853.Header.VisiblePosition = 73
        UltraGridColumn853.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn853.Width = 40
        UltraGridColumn854.Header.VisiblePosition = 74
        UltraGridColumn854.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn855.Header.VisiblePosition = 75
        UltraGridColumn855.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn856.Header.VisiblePosition = 76
        UltraGridColumn856.Hidden = True
        UltraGridColumn857.Header.VisiblePosition = 77
        UltraGridColumn857.Hidden = True
        UltraGridColumn858.Header.VisiblePosition = 78
        UltraGridColumn858.Hidden = True
        UltraGridColumn859.Header.VisiblePosition = 79
        UltraGridColumn859.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 80
        UltraGridColumn11.Header.VisiblePosition = 81
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn780, UltraGridColumn781, UltraGridColumn782, UltraGridColumn783, UltraGridColumn784, UltraGridColumn785, UltraGridColumn786, UltraGridColumn787, UltraGridColumn788, UltraGridColumn789, UltraGridColumn790, UltraGridColumn791, UltraGridColumn792, UltraGridColumn793, UltraGridColumn794, UltraGridColumn795, UltraGridColumn796, UltraGridColumn797, UltraGridColumn798, UltraGridColumn799, UltraGridColumn800, UltraGridColumn801, UltraGridColumn802, UltraGridColumn803, UltraGridColumn804, UltraGridColumn805, UltraGridColumn806, UltraGridColumn807, UltraGridColumn808, UltraGridColumn809, UltraGridColumn810, UltraGridColumn811, UltraGridColumn812, UltraGridColumn813, UltraGridColumn814, UltraGridColumn815, UltraGridColumn816, UltraGridColumn817, UltraGridColumn818, UltraGridColumn819, UltraGridColumn820, UltraGridColumn821, UltraGridColumn822, UltraGridColumn823, UltraGridColumn824, UltraGridColumn825, UltraGridColumn826, UltraGridColumn827, UltraGridColumn828, UltraGridColumn829, UltraGridColumn830, UltraGridColumn831, UltraGridColumn832, UltraGridColumn833, UltraGridColumn834, UltraGridColumn835, UltraGridColumn836, UltraGridColumn837, UltraGridColumn838, UltraGridColumn839, UltraGridColumn840, UltraGridColumn841, UltraGridColumn842, UltraGridColumn843, UltraGridColumn844, UltraGridColumn845, UltraGridColumn846, UltraGridColumn847, UltraGridColumn848, UltraGridColumn849, UltraGridColumn850, UltraGridColumn851, UltraGridColumn852, UltraGridColumn853, UltraGridColumn854, UltraGridColumn855, UltraGridColumn856, UltraGridColumn857, UltraGridColumn858, UltraGridColumn859, UltraGridColumn7, UltraGridColumn11})
        UltraGridBand3.GroupHeadersVisible = False
        UltraGridBand3.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        RowLayoutColumnInfo166.OriginX = 0
        RowLayoutColumnInfo166.OriginY = 0
        RowLayoutColumnInfo166.SpanX = 2
        RowLayoutColumnInfo166.SpanY = 4
        RowLayoutColumnInfo168.OriginX = 2
        RowLayoutColumnInfo168.OriginY = 0
        RowLayoutColumnInfo168.SpanX = 2
        RowLayoutColumnInfo168.SpanY = 4
        RowLayoutColumnInfo170.OriginX = 6
        RowLayoutColumnInfo170.OriginY = 0
        RowLayoutColumnInfo170.SpanX = 2
        RowLayoutColumnInfo170.SpanY = 2
        RowLayoutColumnInfo172.OriginX = 6
        RowLayoutColumnInfo172.OriginY = 2
        RowLayoutColumnInfo172.SpanX = 2
        RowLayoutColumnInfo172.SpanY = 2
        RowLayoutColumnInfo174.OriginX = 8
        RowLayoutColumnInfo174.OriginY = 0
        RowLayoutColumnInfo174.SpanX = 2
        RowLayoutColumnInfo174.SpanY = 4
        RowLayoutColumnInfo175.OriginX = 16
        RowLayoutColumnInfo175.OriginY = 0
        RowLayoutColumnInfo175.PreferredCellSize = New System.Drawing.Size(61, 0)
        RowLayoutColumnInfo175.SpanX = 2
        RowLayoutColumnInfo175.SpanY = 2
        RowLayoutColumnInfo177.OriginX = 10
        RowLayoutColumnInfo177.OriginY = 0
        RowLayoutColumnInfo177.PreferredCellSize = New System.Drawing.Size(254, 0)
        RowLayoutColumnInfo177.SpanX = 2
        RowLayoutColumnInfo177.SpanY = 2
        RowLayoutColumnInfo179.OriginX = 10
        RowLayoutColumnInfo179.OriginY = 2
        RowLayoutColumnInfo179.PreferredCellSize = New System.Drawing.Size(254, 0)
        RowLayoutColumnInfo179.SpanX = 2
        RowLayoutColumnInfo179.SpanY = 2
        RowLayoutColumnInfo183.OriginX = 12
        RowLayoutColumnInfo183.OriginY = 0
        RowLayoutColumnInfo183.SpanX = 2
        RowLayoutColumnInfo183.SpanY = 2
        RowLayoutColumnInfo185.OriginX = 12
        RowLayoutColumnInfo185.OriginY = 2
        RowLayoutColumnInfo185.SpanX = 2
        RowLayoutColumnInfo185.SpanY = 2
        RowLayoutColumnInfo187.OriginX = 16
        RowLayoutColumnInfo187.OriginY = 2
        RowLayoutColumnInfo187.SpanX = 2
        RowLayoutColumnInfo187.SpanY = 2
        RowLayoutColumnInfo189.OriginX = 14
        RowLayoutColumnInfo189.OriginY = 0
        RowLayoutColumnInfo189.SpanX = 2
        RowLayoutColumnInfo189.SpanY = 4
        RowLayoutColumnInfo190.OriginX = 4
        RowLayoutColumnInfo190.OriginY = 0
        RowLayoutColumnInfo190.SpanX = 2
        RowLayoutColumnInfo190.SpanY = 2
        RowLayoutColumnInfo195.OriginX = 4
        RowLayoutColumnInfo195.OriginY = 2
        RowLayoutColumnInfo195.SpanX = 2
        RowLayoutColumnInfo195.SpanY = 2
        RowLayout3.ColumnInfos.AddRange(New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo() {RowLayoutColumnInfo165, RowLayoutColumnInfo166, RowLayoutColumnInfo167, RowLayoutColumnInfo168, RowLayoutColumnInfo169, RowLayoutColumnInfo170, RowLayoutColumnInfo171, RowLayoutColumnInfo172, RowLayoutColumnInfo173, RowLayoutColumnInfo174, RowLayoutColumnInfo175, RowLayoutColumnInfo176, RowLayoutColumnInfo177, RowLayoutColumnInfo178, RowLayoutColumnInfo179, RowLayoutColumnInfo180, RowLayoutColumnInfo181, RowLayoutColumnInfo182, RowLayoutColumnInfo183, RowLayoutColumnInfo184, RowLayoutColumnInfo185, RowLayoutColumnInfo186, RowLayoutColumnInfo187, RowLayoutColumnInfo188, RowLayoutColumnInfo189, RowLayoutColumnInfo190, RowLayoutColumnInfo191, RowLayoutColumnInfo192, RowLayoutColumnInfo193, RowLayoutColumnInfo194, RowLayoutColumnInfo195, RowLayoutColumnInfo196, RowLayoutColumnInfo197, RowLayoutColumnInfo198, RowLayoutColumnInfo199, RowLayoutColumnInfo200, RowLayoutColumnInfo201, RowLayoutColumnInfo202, RowLayoutColumnInfo203, RowLayoutColumnInfo204, RowLayoutColumnInfo205, RowLayoutColumnInfo206, RowLayoutColumnInfo207, RowLayoutColumnInfo208, RowLayoutColumnInfo209, RowLayoutColumnInfo210, RowLayoutColumnInfo211, RowLayoutColumnInfo212, RowLayoutColumnInfo213, RowLayoutColumnInfo214, RowLayoutColumnInfo215, RowLayoutColumnInfo216, RowLayoutColumnInfo217, RowLayoutColumnInfo218, RowLayoutColumnInfo219, RowLayoutColumnInfo220, RowLayoutColumnInfo221, RowLayoutColumnInfo222, RowLayoutColumnInfo223, RowLayoutColumnInfo224, RowLayoutColumnInfo225, RowLayoutColumnInfo226, RowLayoutColumnInfo227, RowLayoutColumnInfo228, RowLayoutColumnInfo229, RowLayoutColumnInfo230, RowLayoutColumnInfo231, RowLayoutColumnInfo232, RowLayoutColumnInfo233, RowLayoutColumnInfo234, RowLayoutColumnInfo235, RowLayoutColumnInfo236, RowLayoutColumnInfo237, RowLayoutColumnInfo238, RowLayoutColumnInfo239, RowLayoutColumnInfo240, RowLayoutColumnInfo241, RowLayoutColumnInfo242, RowLayoutColumnInfo243, RowLayoutColumnInfo244, RowLayoutColumnInfo245, RowLayoutColumnInfo246})
        RowLayout3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        UltraGridBand3.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout3})
        UltraGridBand3.SummaryFooterCaption = "Totales:"
        Me.griViajesProceso.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griViajesProceso.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesProceso.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesProceso.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesProceso.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesProceso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesProceso.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesProceso.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesProceso.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesProceso.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griViajesProceso.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesProceso.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesProceso.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesProceso.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesProceso.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajesProceso.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajesProceso.DisplayLayout.UseFixedHeaders = True
        Me.griViajesProceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesProceso.ImageList = Me.imagenes
        Me.griViajesProceso.Location = New System.Drawing.Point(0, 58)
        Me.griViajesProceso.Name = "griViajesProceso"
        Me.griViajesProceso.Size = New System.Drawing.Size(1242, 464)
        Me.griViajesProceso.TabIndex = 3
        Me.griViajesProceso.Tag = ""
        '
        'UltraExpandableGroupBox5
        '
        Appearance84.BackColor = System.Drawing.Color.White
        Appearance84.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox5.ContentAreaAppearance = Appearance84
        Me.UltraExpandableGroupBox5.Controls.Add(Me.UltraExpandableGroupBoxPanel10)
        Me.UltraExpandableGroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox5.ExpandedSize = New System.Drawing.Size(1242, 58)
        Me.UltraExpandableGroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox5.Name = "UltraExpandableGroupBox5"
        Me.UltraExpandableGroupBox5.Size = New System.Drawing.Size(1242, 58)
        Me.UltraExpandableGroupBox5.TabIndex = 2
        Me.UltraExpandableGroupBox5.Text = "Filtros"
        Me.UltraExpandableGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel10
        '
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.opcDesenganches)
        Me.UltraExpandableGroupBoxPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel10.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel10.Name = "UltraExpandableGroupBoxPanel10"
        Me.UltraExpandableGroupBoxPanel10.Size = New System.Drawing.Size(1236, 35)
        Me.UltraExpandableGroupBoxPanel10.TabIndex = 0
        '
        'opcDesenganches
        '
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Me.opcDesenganches.Appearance = Appearance85
        Me.opcDesenganches.BackColor = System.Drawing.Color.Transparent
        Me.opcDesenganches.BackColorInternal = System.Drawing.Color.Transparent
        Me.opcDesenganches.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcDesenganches.CheckedIndex = 0
        Me.opcDesenganches.Dock = System.Windows.Forms.DockStyle.Left
        Me.opcDesenganches.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcDesenganches.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "DESENGANCHES ACTUALES"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "HISTORIAL DESENGANCHES"
        Me.opcDesenganches.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.opcDesenganches.Location = New System.Drawing.Point(0, 0)
        Me.opcDesenganches.Name = "opcDesenganches"
        Me.opcDesenganches.Size = New System.Drawing.Size(200, 35)
        Me.opcDesenganches.TabIndex = 11
        Me.opcDesenganches.Text = "DESENGANCHES ACTUALES"
        '
        'utpTrazabilidad
        '
        Me.utpTrazabilidad.Controls.Add(Me.griTransabilida)
        Me.utpTrazabilidad.Controls.Add(Me.UltraGroupBox8)
        Me.utpTrazabilidad.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpTrazabilidad.Name = "utpTrazabilidad"
        Me.utpTrazabilidad.Size = New System.Drawing.Size(1242, 522)
        '
        'griTransabilida
        '
        Me.griTransabilida.CalcManager = Me.Calcular1
        Me.griTransabilida.DataSource = Me.ogdListaOperacion
        UltraGridColumn860.Header.VisiblePosition = 0
        UltraGridColumn860.Hidden = True
        UltraGridColumn861.Header.VisiblePosition = 1
        UltraGridColumn861.Hidden = True
        UltraGridColumn862.Header.VisiblePosition = 2
        UltraGridColumn862.Hidden = True
        UltraGridColumn863.Header.Caption = "Viaje"
        UltraGridColumn863.Header.VisiblePosition = 7
        UltraGridColumn864.Header.VisiblePosition = 8
        UltraGridColumn864.Hidden = True
        UltraGridColumn865.Header.VisiblePosition = 9
        UltraGridColumn866.Header.VisiblePosition = 10
        UltraGridColumn866.Hidden = True
        UltraGridColumn867.Header.VisiblePosition = 11
        UltraGridColumn868.Header.VisiblePosition = 12
        UltraGridColumn868.Hidden = True
        UltraGridColumn869.Header.VisiblePosition = 13
        UltraGridColumn870.Header.VisiblePosition = 14
        UltraGridColumn870.Hidden = True
        UltraGridColumn871.Header.VisiblePosition = 15
        UltraGridColumn871.Hidden = True
        UltraGridColumn872.Header.VisiblePosition = 19
        UltraGridColumn873.Header.VisiblePosition = 20
        UltraGridColumn873.Hidden = True
        UltraGridColumn874.Header.VisiblePosition = 21
        UltraGridColumn875.Header.VisiblePosition = 22
        UltraGridColumn875.Hidden = True
        Appearance86.TextHAlignAsString = "Center"
        UltraGridColumn876.CellAppearance = Appearance86
        UltraGridColumn876.Format = ""
        Appearance87.TextHAlignAsString = "Center"
        UltraGridColumn876.Header.Appearance = Appearance87
        UltraGridColumn876.Header.VisiblePosition = 3
        UltraGridColumn876.Hidden = True
        UltraGridColumn876.Width = 46
        UltraGridColumn877.Header.VisiblePosition = 24
        UltraGridColumn877.Hidden = True
        UltraGridColumn878.Header.VisiblePosition = 16
        UltraGridColumn879.Header.VisiblePosition = 25
        UltraGridColumn879.Hidden = True
        UltraGridColumn880.Header.VisiblePosition = 17
        Appearance88.TextHAlignAsString = "Right"
        UltraGridColumn881.CellAppearance = Appearance88
        UltraGridColumn881.Format = "###,###,##0.000"
        UltraGridColumn881.Header.VisiblePosition = 27
        Appearance89.TextHAlignAsString = "Right"
        UltraGridColumn882.CellAppearance = Appearance89
        UltraGridColumn882.Format = "###,##0.000"
        UltraGridColumn882.Header.VisiblePosition = 28
        UltraGridColumn882.Hidden = True
        UltraGridColumn883.Header.VisiblePosition = 29
        UltraGridColumn883.Hidden = True
        UltraGridColumn884.Header.VisiblePosition = 30
        UltraGridColumn884.Hidden = True
        UltraGridColumn885.Header.VisiblePosition = 6
        UltraGridColumn885.MaskInput = "{date} {time}"
        UltraGridColumn885.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn885.Width = 81
        UltraGridColumn886.Header.VisiblePosition = 33
        UltraGridColumn886.Hidden = True
        UltraGridColumn887.Header.VisiblePosition = 4
        UltraGridColumn887.Hidden = True
        UltraGridColumn888.Header.VisiblePosition = 34
        UltraGridColumn888.Hidden = True
        UltraGridColumn889.Header.VisiblePosition = 35
        UltraGridColumn889.Hidden = True
        UltraGridColumn890.Header.VisiblePosition = 32
        UltraGridColumn891.Header.VisiblePosition = 36
        UltraGridColumn891.Hidden = True
        UltraGridColumn892.Header.VisiblePosition = 37
        UltraGridColumn892.Hidden = True
        UltraGridColumn893.Header.VisiblePosition = 38
        UltraGridColumn893.Hidden = True
        UltraGridColumn894.Header.VisiblePosition = 18
        UltraGridColumn895.Header.VisiblePosition = 39
        UltraGridColumn895.Hidden = True
        UltraGridColumn896.Header.VisiblePosition = 40
        UltraGridColumn896.Hidden = True
        UltraGridColumn896.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn897.Header.VisiblePosition = 41
        UltraGridColumn897.Hidden = True
        UltraGridColumn898.Header.VisiblePosition = 42
        UltraGridColumn898.Hidden = True
        UltraGridColumn899.Header.VisiblePosition = 43
        UltraGridColumn899.Hidden = True
        UltraGridColumn900.Header.VisiblePosition = 44
        UltraGridColumn900.Hidden = True
        UltraGridColumn901.Header.VisiblePosition = 45
        UltraGridColumn901.Hidden = True
        UltraGridColumn902.Header.VisiblePosition = 46
        UltraGridColumn902.Hidden = True
        UltraGridColumn903.Header.VisiblePosition = 47
        UltraGridColumn903.Hidden = True
        UltraGridColumn904.Header.VisiblePosition = 31
        UltraGridColumn905.Header.VisiblePosition = 48
        UltraGridColumn905.Hidden = True
        UltraGridColumn906.Header.VisiblePosition = 49
        UltraGridColumn906.Hidden = True
        UltraGridColumn907.Header.VisiblePosition = 50
        UltraGridColumn907.Hidden = True
        UltraGridColumn908.Header.VisiblePosition = 51
        UltraGridColumn908.Hidden = True
        UltraGridColumn909.Header.VisiblePosition = 52
        UltraGridColumn909.Hidden = True
        UltraGridColumn910.Header.VisiblePosition = 53
        UltraGridColumn910.Hidden = True
        UltraGridColumn911.Header.VisiblePosition = 54
        UltraGridColumn911.Hidden = True
        UltraGridColumn912.Header.VisiblePosition = 55
        UltraGridColumn912.Hidden = True
        Appearance90.TextHAlignAsString = "Center"
        UltraGridColumn913.CellAppearance = Appearance90
        UltraGridColumn913.Header.Caption = "# Error"
        UltraGridColumn913.Header.VisiblePosition = 5
        UltraGridColumn913.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn913.Width = 54
        UltraGridColumn914.Header.VisiblePosition = 56
        UltraGridColumn914.Hidden = True
        UltraGridColumn915.Header.VisiblePosition = 57
        UltraGridColumn915.Hidden = True
        UltraGridColumn916.Header.VisiblePosition = 58
        UltraGridColumn916.Hidden = True
        UltraGridColumn917.Header.VisiblePosition = 59
        UltraGridColumn917.Hidden = True
        UltraGridColumn918.Header.VisiblePosition = 60
        UltraGridColumn918.Hidden = True
        UltraGridColumn919.Header.VisiblePosition = 61
        UltraGridColumn919.Hidden = True
        UltraGridColumn920.Header.VisiblePosition = 62
        UltraGridColumn920.Hidden = True
        UltraGridColumn921.Header.VisiblePosition = 63
        UltraGridColumn921.Hidden = True
        UltraGridColumn922.Header.VisiblePosition = 64
        UltraGridColumn922.Hidden = True
        UltraGridColumn923.Header.VisiblePosition = 65
        UltraGridColumn923.Hidden = True
        UltraGridColumn924.Header.VisiblePosition = 66
        UltraGridColumn924.Hidden = True
        UltraGridColumn925.Header.VisiblePosition = 67
        UltraGridColumn925.Hidden = True
        UltraGridColumn926.Header.VisiblePosition = 68
        UltraGridColumn926.Hidden = True
        Appearance91.TextHAlignAsString = "Right"
        UltraGridColumn927.CellAppearance = Appearance91
        UltraGridColumn927.Format = "###,##0.000"
        UltraGridColumn927.Header.VisiblePosition = 26
        Appearance92.TextHAlignAsString = "Right"
        UltraGridColumn928.CellAppearance = Appearance92
        UltraGridColumn928.Format = "###,##0.000"
        UltraGridColumn928.Header.VisiblePosition = 23
        UltraGridColumn929.Header.VisiblePosition = 69
        UltraGridColumn929.Hidden = True
        UltraGridColumn930.Header.VisiblePosition = 70
        UltraGridColumn930.Hidden = True
        UltraGridColumn931.Header.VisiblePosition = 71
        UltraGridColumn931.Hidden = True
        UltraGridColumn932.Header.VisiblePosition = 72
        UltraGridColumn932.Hidden = True
        UltraGridColumn933.Header.VisiblePosition = 73
        UltraGridColumn933.Hidden = True
        UltraGridColumn934.Header.VisiblePosition = 74
        UltraGridColumn934.Hidden = True
        UltraGridColumn935.Header.VisiblePosition = 75
        UltraGridColumn935.Hidden = True
        UltraGridColumn936.Header.VisiblePosition = 76
        UltraGridColumn936.Hidden = True
        UltraGridColumn937.Header.VisiblePosition = 77
        UltraGridColumn937.Hidden = True
        UltraGridColumn938.Header.VisiblePosition = 78
        UltraGridColumn938.Hidden = True
        UltraGridColumn939.Header.VisiblePosition = 79
        UltraGridColumn939.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 80
        UltraGridColumn12.Header.VisiblePosition = 81
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn860, UltraGridColumn861, UltraGridColumn862, UltraGridColumn863, UltraGridColumn864, UltraGridColumn865, UltraGridColumn866, UltraGridColumn867, UltraGridColumn868, UltraGridColumn869, UltraGridColumn870, UltraGridColumn871, UltraGridColumn872, UltraGridColumn873, UltraGridColumn874, UltraGridColumn875, UltraGridColumn876, UltraGridColumn877, UltraGridColumn878, UltraGridColumn879, UltraGridColumn880, UltraGridColumn881, UltraGridColumn882, UltraGridColumn883, UltraGridColumn884, UltraGridColumn885, UltraGridColumn886, UltraGridColumn887, UltraGridColumn888, UltraGridColumn889, UltraGridColumn890, UltraGridColumn891, UltraGridColumn892, UltraGridColumn893, UltraGridColumn894, UltraGridColumn895, UltraGridColumn896, UltraGridColumn897, UltraGridColumn898, UltraGridColumn899, UltraGridColumn900, UltraGridColumn901, UltraGridColumn902, UltraGridColumn903, UltraGridColumn904, UltraGridColumn905, UltraGridColumn906, UltraGridColumn907, UltraGridColumn908, UltraGridColumn909, UltraGridColumn910, UltraGridColumn911, UltraGridColumn912, UltraGridColumn913, UltraGridColumn914, UltraGridColumn915, UltraGridColumn916, UltraGridColumn917, UltraGridColumn918, UltraGridColumn919, UltraGridColumn920, UltraGridColumn921, UltraGridColumn922, UltraGridColumn923, UltraGridColumn924, UltraGridColumn925, UltraGridColumn926, UltraGridColumn927, UltraGridColumn928, UltraGridColumn929, UltraGridColumn930, UltraGridColumn931, UltraGridColumn932, UltraGridColumn933, UltraGridColumn934, UltraGridColumn935, UltraGridColumn936, UltraGridColumn937, UltraGridColumn938, UltraGridColumn939, UltraGridColumn8, UltraGridColumn12})
        Me.griTransabilida.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griTransabilida.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griTransabilida.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTransabilida.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTransabilida.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTransabilida.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTransabilida.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTransabilida.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTransabilida.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griTransabilida.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTransabilida.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTransabilida.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griTransabilida.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griTransabilida.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griTransabilida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTransabilida.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTransabilida.Location = New System.Drawing.Point(0, 54)
        Me.griTransabilida.Name = "griTransabilida"
        Me.griTransabilida.Size = New System.Drawing.Size(1242, 468)
        Me.griTransabilida.TabIndex = 1
        '
        'UltraGroupBox8
        '
        Appearance93.BackColor = System.Drawing.Color.White
        Appearance93.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox8.ContentAreaAppearance = Appearance93
        Me.UltraGroupBox8.Controls.Add(Me.Flota)
        Me.UltraGroupBox8.Controls.Add(Me.cboFlota)
        Me.UltraGroupBox8.Controls.Add(Me.btnEnviarCorreo)
        Me.UltraGroupBox8.Controls.Add(Me.opTractoCarreta)
        Me.UltraGroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(1242, 54)
        Me.UltraGroupBox8.TabIndex = 0
        Me.UltraGroupBox8.Text = "Filtro"
        Me.UltraGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Flota
        '
        Me.Flota.AutoSize = True
        Me.Flota.Location = New System.Drawing.Point(86, 26)
        Me.Flota.Name = "Flota"
        Me.Flota.Size = New System.Drawing.Size(33, 13)
        Me.Flota.TabIndex = 16
        Me.Flota.Text = "Flota:"
        '
        'cboFlota
        '
        Me.cboFlota.CheckedListSettings.CheckBoxStyle = Infragistics.Win.CheckStyle.CheckBox
        Me.cboFlota.CheckedListSettings.EditorValueSource = Infragistics.Win.EditorWithComboValueSource.CheckedItems
        Me.cboFlota.CheckedListSettings.ListSeparator = ";"
        Me.cboFlota.DisplayMember = "Nombre"
        Me.cboFlota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlota.DropDownListWidth = -1
        Me.cboFlota.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlota.Location = New System.Drawing.Point(120, 22)
        Me.cboFlota.Name = "cboFlota"
        Me.cboFlota.Size = New System.Drawing.Size(144, 21)
        Me.cboFlota.TabIndex = 1
        Me.cboFlota.ValueMember = "Id"
        '
        'btnEnviarCorreo
        '
        Appearance94.Image = Global.ISL.Win.My.Resources.Resources.accounting_mail
        Me.btnEnviarCorreo.Appearance = Appearance94
        Me.btnEnviarCorreo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D
        Me.btnEnviarCorreo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarCorreo.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnEnviarCorreo.Location = New System.Drawing.Point(270, 17)
        Me.btnEnviarCorreo.Name = "btnEnviarCorreo"
        Me.btnEnviarCorreo.Size = New System.Drawing.Size(78, 32)
        Me.btnEnviarCorreo.TabIndex = 2
        Me.btnEnviarCorreo.Text = "Enviar Correo"
        '
        'opTractoCarreta
        '
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Me.opTractoCarreta.Appearance = Appearance95
        Me.opTractoCarreta.BackColor = System.Drawing.Color.Transparent
        Me.opTractoCarreta.BackColorInternal = System.Drawing.Color.Transparent
        Me.opTractoCarreta.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opTractoCarreta.CheckedIndex = 0
        Me.opTractoCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opTractoCarreta.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem7.DataValue = "Default Item"
        ValueListItem7.DisplayText = "Tracto"
        ValueListItem8.DataValue = "ValueListItem1"
        ValueListItem8.DisplayText = "Carreta"
        Me.opTractoCarreta.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem7, ValueListItem8})
        Me.opTractoCarreta.Location = New System.Drawing.Point(16, 20)
        Me.opTractoCarreta.Name = "opTractoCarreta"
        Me.opTractoCarreta.Size = New System.Drawing.Size(68, 32)
        Me.opTractoCarreta.TabIndex = 0
        Me.opTractoCarreta.Text = "Tracto"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griViaje)
        Me.UltraTabPageControl4.Controls.Add(Me.expViaje)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1248, 387)
        '
        'griViaje
        '
        Me.griViaje.CalcManager = Me.Calcular1
        Me.griViaje.ContextMenuStrip = Me.MenuViaje
        Me.griViaje.DataSource = Me.ogdViaje
        Appearance145.BackColor = System.Drawing.Color.White
        Me.griViaje.DisplayLayout.Appearance = Appearance145
        UltraGridColumn940.Header.VisiblePosition = 0
        UltraGridColumn940.Hidden = True
        UltraGridColumn941.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn941.Header.VisiblePosition = 1
        UltraGridColumn941.Hidden = True
        UltraGridColumn942.Header.VisiblePosition = 2
        UltraGridColumn942.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn942.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn942.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(132, 0)
        UltraGridColumn942.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn942.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn942.Width = 101
        UltraGridColumn943.Header.VisiblePosition = 5
        UltraGridColumn943.Hidden = True
        UltraGridColumn943.Width = 179
        UltraGridColumn944.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn944.Header.VisiblePosition = 4
        UltraGridColumn944.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn944.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn944.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(129, 0)
        UltraGridColumn944.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn944.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn944.Width = 125
        UltraGridColumn945.Header.VisiblePosition = 6
        UltraGridColumn945.Hidden = True
        UltraGridColumn945.Width = 176
        UltraGridColumn946.Header.VisiblePosition = 8
        UltraGridColumn946.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn946.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn946.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(129, 0)
        UltraGridColumn946.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn946.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn946.Width = 125
        UltraGridColumn947.Header.VisiblePosition = 7
        UltraGridColumn947.Hidden = True
        Appearance146.TextHAlignAsString = "Left"
        UltraGridColumn948.CellAppearance = Appearance146
        UltraGridColumn948.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance147.TextHAlignAsString = "Left"
        UltraGridColumn948.Header.Appearance = Appearance147
        UltraGridColumn948.Header.Caption = "Vacio"
        UltraGridColumn948.Header.VisiblePosition = 19
        UltraGridColumn948.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn948.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn948.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn948.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn948.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn948.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn948.Width = 25
        UltraGridColumn949.Header.VisiblePosition = 11
        UltraGridColumn949.Hidden = True
        UltraGridColumn949.Width = 169
        UltraGridColumn950.Header.VisiblePosition = 21
        UltraGridColumn950.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn950.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn950.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(260, 0)
        UltraGridColumn950.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn950.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn950.Width = 172
        UltraGridColumn951.Header.VisiblePosition = 12
        UltraGridColumn951.Hidden = True
        UltraGridColumn951.Width = 189
        UltraGridColumn952.Header.VisiblePosition = 23
        UltraGridColumn952.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn952.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn952.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(260, 0)
        UltraGridColumn952.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn952.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn952.Width = 161
        UltraGridColumn953.Header.VisiblePosition = 13
        UltraGridColumn953.Hidden = True
        UltraGridColumn954.Header.VisiblePosition = 14
        UltraGridColumn954.Hidden = True
        UltraGridColumn954.Width = 160
        UltraGridColumn955.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn955.Header.VisiblePosition = 9
        UltraGridColumn955.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn955.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn955.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(88, 0)
        UltraGridColumn955.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn955.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn955.Width = 75
        UltraGridColumn956.Header.VisiblePosition = 15
        UltraGridColumn956.Hidden = True
        UltraGridColumn956.Width = 126
        UltraGridColumn957.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn957.Header.VisiblePosition = 10
        UltraGridColumn957.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn957.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn957.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(88, 0)
        UltraGridColumn957.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn957.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn957.Width = 69
        UltraGridColumn958.Header.VisiblePosition = 17
        UltraGridColumn958.Hidden = True
        UltraGridColumn959.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn959.Header.VisiblePosition = 3
        UltraGridColumn959.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn959.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn959.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(132, 0)
        UltraGridColumn959.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn959.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn959.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn959.Width = 100
        UltraGridColumn960.Header.VisiblePosition = 18
        UltraGridColumn960.Hidden = True
        UltraGridColumn961.Header.VisiblePosition = 27
        UltraGridColumn961.Hidden = True
        UltraGridColumn962.Header.VisiblePosition = 28
        UltraGridColumn962.Hidden = True
        UltraGridColumn963.Header.VisiblePosition = 22
        UltraGridColumn963.Hidden = True
        Appearance148.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn964.CellAppearance = Appearance148
        UltraGridColumn964.Header.VisiblePosition = 29
        UltraGridColumn964.Hidden = True
        UltraGridColumn964.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn964.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn964.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn964.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn965.Header.VisiblePosition = 16
        UltraGridColumn965.Hidden = True
        UltraGridColumn966.Header.VisiblePosition = 26
        UltraGridColumn966.Hidden = True
        UltraGridColumn967.Header.VisiblePosition = 30
        UltraGridColumn967.Hidden = True
        UltraGridColumn968.Header.VisiblePosition = 31
        UltraGridColumn968.Hidden = True
        UltraGridColumn969.Header.VisiblePosition = 32
        UltraGridColumn969.Hidden = True
        UltraGridColumn970.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn970.Header.Caption = "Escala"
        UltraGridColumn970.Header.VisiblePosition = 25
        UltraGridColumn970.Hidden = True
        UltraGridColumn970.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn970.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn970.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn970.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn970.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn970.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn970.Width = 37
        UltraGridColumn971.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn971.Header.VisiblePosition = 33
        UltraGridColumn971.Hidden = True
        UltraGridColumn971.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn971.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn971.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(277, 0)
        UltraGridColumn971.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn971.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn971.Width = 164
        UltraGridColumn972.Header.VisiblePosition = 34
        UltraGridColumn972.Hidden = True
        UltraGridColumn973.Header.VisiblePosition = 35
        UltraGridColumn973.Hidden = True
        UltraGridColumn974.Header.VisiblePosition = 36
        UltraGridColumn974.Hidden = True
        UltraGridColumn975.Header.VisiblePosition = 37
        UltraGridColumn975.Hidden = True
        UltraGridColumn976.Header.VisiblePosition = 38
        UltraGridColumn976.Hidden = True
        UltraGridColumn977.Header.VisiblePosition = 39
        UltraGridColumn977.Hidden = True
        UltraGridColumn978.Header.VisiblePosition = 40
        UltraGridColumn978.Hidden = True
        UltraGridColumn979.Header.VisiblePosition = 41
        UltraGridColumn979.Hidden = True
        UltraGridColumn980.Header.VisiblePosition = 42
        UltraGridColumn980.Hidden = True
        UltraGridColumn981.Header.VisiblePosition = 43
        UltraGridColumn981.Hidden = True
        UltraGridColumn982.Header.VisiblePosition = 44
        UltraGridColumn982.Hidden = True
        UltraGridColumn982.Width = 100
        UltraGridColumn983.Header.VisiblePosition = 45
        UltraGridColumn983.Hidden = True
        UltraGridColumn984.Header.VisiblePosition = 46
        UltraGridColumn984.Hidden = True
        Appearance149.TextHAlignAsString = "Right"
        UltraGridColumn985.CellAppearance = Appearance149
        UltraGridColumn985.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn985.Header.Caption = "Bloque"
        UltraGridColumn985.Header.VisiblePosition = 24
        UltraGridColumn985.MaskInput = "n"
        UltraGridColumn985.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn985.Width = 30
        UltraGridColumn986.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn986.Header.Caption = "D/N"
        UltraGridColumn986.Header.VisiblePosition = 47
        UltraGridColumn986.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn986.Width = 25
        UltraGridColumn987.Header.VisiblePosition = 48
        UltraGridColumn987.Hidden = True
        UltraGridColumn988.Header.VisiblePosition = 49
        UltraGridColumn988.Hidden = True
        UltraGridColumn989.Header.VisiblePosition = 50
        UltraGridColumn989.Hidden = True
        UltraGridColumn990.Header.VisiblePosition = 51
        UltraGridColumn990.Hidden = True
        UltraGridColumn991.Header.VisiblePosition = 52
        UltraGridColumn991.Hidden = True
        UltraGridColumn992.Header.VisiblePosition = 53
        UltraGridColumn992.Hidden = True
        UltraGridColumn993.Header.VisiblePosition = 54
        UltraGridColumn993.Hidden = True
        UltraGridColumn994.Header.Caption = "Ruta"
        UltraGridColumn994.Header.VisiblePosition = 68
        UltraGridColumn994.Width = 30
        UltraGridColumn995.Header.VisiblePosition = 55
        UltraGridColumn995.Hidden = True
        UltraGridColumn996.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn996.Header.Caption = "Fecha"
        UltraGridColumn996.Header.VisiblePosition = 56
        UltraGridColumn996.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn996.Width = 25
        Appearance150.TextHAlignAsString = "Right"
        UltraGridColumn997.CellAppearance = Appearance150
        UltraGridColumn997.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn997.Header.Caption = "% Flete"
        UltraGridColumn997.Header.VisiblePosition = 57
        UltraGridColumn997.MaskInput = "nnn"
        UltraGridColumn997.Width = 30
        UltraGridColumn998.Header.VisiblePosition = 58
        UltraGridColumn998.Hidden = True
        UltraGridColumn999.Header.VisiblePosition = 59
        UltraGridColumn999.Hidden = True
        UltraGridColumn1000.Header.VisiblePosition = 60
        UltraGridColumn1000.Hidden = True
        UltraGridColumn1001.Header.VisiblePosition = 61
        UltraGridColumn1001.Hidden = True
        UltraGridColumn1002.Header.VisiblePosition = 62
        UltraGridColumn1002.Hidden = True
        UltraGridColumn1003.Header.VisiblePosition = 63
        UltraGridColumn1003.Hidden = True
        UltraGridColumn1004.Header.VisiblePosition = 64
        UltraGridColumn1004.Hidden = True
        UltraGridColumn1005.Header.VisiblePosition = 65
        UltraGridColumn1005.Hidden = True
        UltraGridColumn1006.Header.VisiblePosition = 66
        UltraGridColumn1006.Hidden = True
        Appearance151.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance151.TextHAlignAsString = "Right"
        UltraGridColumn1007.CellAppearance = Appearance151
        UltraGridColumn1007.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1007.Format = ""
        UltraGridColumn1007.Header.VisiblePosition = 67
        UltraGridColumn1007.MaskInput = "{LOC}nn,nnn.nnnn"
        UltraGridColumn1007.Width = 62
        UltraGridColumn1008.Header.VisiblePosition = 69
        UltraGridColumn1008.Hidden = True
        Appearance152.TextHAlignAsString = "Right"
        UltraGridColumn1009.CellAppearance = Appearance152
        UltraGridColumn1009.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1009.Header.VisiblePosition = 70
        UltraGridColumn1009.MaskInput = "{LOC}nn,nnn.nn"
        UltraGridColumn1009.Width = 50
        UltraGridColumn1010.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1010.Header.Caption = "Carga"
        UltraGridColumn1010.Header.VisiblePosition = 71
        UltraGridColumn1010.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1010.Width = 25
        UltraGridColumn1011.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn1011.Header.Caption = "Retorno"
        UltraGridColumn1011.Header.VisiblePosition = 20
        UltraGridColumn1011.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1011.Width = 25
        Appearance153.TextHAlignAsString = "Right"
        UltraGridColumn1012.CellAppearance = Appearance153
        UltraGridColumn1012.Header.VisiblePosition = 72
        UltraGridColumn1013.Header.VisiblePosition = 73
        UltraGridColumn1013.Hidden = True
        UltraGridColumn1014.Header.VisiblePosition = 74
        UltraGridColumn1014.Hidden = True
        UltraGridColumn1015.Header.VisiblePosition = 75
        UltraGridColumn1015.Hidden = True
        UltraGridColumn1016.Header.VisiblePosition = 76
        UltraGridColumn1016.Hidden = True
        UltraGridColumn1017.Header.VisiblePosition = 77
        UltraGridColumn1017.Hidden = True
        UltraGridColumn1018.Header.VisiblePosition = 78
        UltraGridColumn1018.Hidden = True
        UltraGridColumn1019.Header.VisiblePosition = 79
        UltraGridColumn1019.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 80
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 81
        UltraGridColumn2.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn940, UltraGridColumn941, UltraGridColumn942, UltraGridColumn943, UltraGridColumn944, UltraGridColumn945, UltraGridColumn946, UltraGridColumn947, UltraGridColumn948, UltraGridColumn949, UltraGridColumn950, UltraGridColumn951, UltraGridColumn952, UltraGridColumn953, UltraGridColumn954, UltraGridColumn955, UltraGridColumn956, UltraGridColumn957, UltraGridColumn958, UltraGridColumn959, UltraGridColumn960, UltraGridColumn961, UltraGridColumn962, UltraGridColumn963, UltraGridColumn964, UltraGridColumn965, UltraGridColumn966, UltraGridColumn967, UltraGridColumn968, UltraGridColumn969, UltraGridColumn970, UltraGridColumn971, UltraGridColumn972, UltraGridColumn973, UltraGridColumn974, UltraGridColumn975, UltraGridColumn976, UltraGridColumn977, UltraGridColumn978, UltraGridColumn979, UltraGridColumn980, UltraGridColumn981, UltraGridColumn982, UltraGridColumn983, UltraGridColumn984, UltraGridColumn985, UltraGridColumn986, UltraGridColumn987, UltraGridColumn988, UltraGridColumn989, UltraGridColumn990, UltraGridColumn991, UltraGridColumn992, UltraGridColumn993, UltraGridColumn994, UltraGridColumn995, UltraGridColumn996, UltraGridColumn997, UltraGridColumn998, UltraGridColumn999, UltraGridColumn1000, UltraGridColumn1001, UltraGridColumn1002, UltraGridColumn1003, UltraGridColumn1004, UltraGridColumn1005, UltraGridColumn1006, UltraGridColumn1007, UltraGridColumn1008, UltraGridColumn1009, UltraGridColumn1010, UltraGridColumn1011, UltraGridColumn1012, UltraGridColumn1013, UltraGridColumn1014, UltraGridColumn1015, UltraGridColumn1016, UltraGridColumn1017, UltraGridColumn1018, UltraGridColumn1019, UltraGridColumn1, UltraGridColumn2})
        UltraGridBand5.SummaryFooterCaption = "Totales:"
        Me.griViaje.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griViaje.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griViaje.DisplayLayout.GroupByBox.Hidden = True
        Me.griViaje.DisplayLayout.MaxColScrollRegions = 1
        Me.griViaje.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griViaje.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViaje.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViaje.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViaje.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance154.TextHAlignAsString = "Left"
        Me.griViaje.DisplayLayout.Override.HeaderAppearance = Appearance154
        Me.griViaje.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViaje.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance155.TextVAlignAsString = "Middle"
        Me.griViaje.DisplayLayout.Override.RowAppearance = Appearance155
        Me.griViaje.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griViaje.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViaje.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViaje.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griViaje.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griViaje.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViaje.Location = New System.Drawing.Point(0, 125)
        Me.griViaje.Name = "griViaje"
        Me.griViaje.Size = New System.Drawing.Size(1248, 262)
        Me.griViaje.TabIndex = 1
        Me.griViaje.Tag = ""
        '
        'MenuViaje
        '
        Me.MenuViaje.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuViaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuViaje.Name = "mnu_Transferencias"
        Me.MenuViaje.Size = New System.Drawing.Size(153, 30)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 26)
        Me.ToolStripMenuItem2.Text = "Quitar"
        '
        'ogdViaje
        '
        UltraDataColumn102.DataType = GetType(Date)
        UltraDataColumn150.DataType = GetType(Double)
        Me.ogdViaje.Band.Columns.AddRange(New Object() {UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164})
        '
        'expViaje
        '
        Me.expViaje.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance156.BackColor = System.Drawing.Color.White
        Appearance156.BackColor2 = System.Drawing.Color.White
        Me.expViaje.ContentAreaAppearance = Appearance156
        Me.expViaje.Controls.Add(Me.UltraExpandableGroupBoxPanel18)
        Me.expViaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.expViaje.ExpandedSize = New System.Drawing.Size(1248, 125)
        Me.expViaje.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.expViaje.Location = New System.Drawing.Point(0, 0)
        Me.expViaje.Name = "expViaje"
        Me.expViaje.Size = New System.Drawing.Size(1248, 125)
        Me.expViaje.TabIndex = 0
        Me.expViaje.TabStop = False
        Me.expViaje.Text = "Ingreso de Datos para Crear / Actualizar un Viaje "
        Me.expViaje.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel18
        '
        Me.UltraExpandableGroupBoxPanel18.Controls.Add(Me.exgruEscalaBloque)
        Me.UltraExpandableGroupBoxPanel18.Controls.Add(Me.UltraGroupBox14)
        Me.UltraExpandableGroupBoxPanel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel18.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel18.Name = "UltraExpandableGroupBoxPanel18"
        Me.UltraExpandableGroupBoxPanel18.Size = New System.Drawing.Size(1242, 102)
        Me.UltraExpandableGroupBoxPanel18.TabIndex = 0
        '
        'exgruEscalaBloque
        '
        Me.exgruEscalaBloque.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance157.BackColor = System.Drawing.Color.White
        Appearance157.BackColor2 = System.Drawing.Color.White
        Me.exgruEscalaBloque.ContentAreaAppearance = Appearance157
        Me.exgruEscalaBloque.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.exgruEscalaBloque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.exgruEscalaBloque.ExpandedSize = New System.Drawing.Size(142, 102)
        Me.exgruEscalaBloque.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruEscalaBloque.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.exgruEscalaBloque.Location = New System.Drawing.Point(1100, 0)
        Me.exgruEscalaBloque.Name = "exgruEscalaBloque"
        Me.exgruEscalaBloque.Size = New System.Drawing.Size(142, 102)
        Me.exgruEscalaBloque.TabIndex = 1
        Me.exgruEscalaBloque.TabStop = False
        Me.exgruEscalaBloque.Text = "Adicionales"
        UltraToolTipInfo4.ToolTipText = "Escala en Bloque"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.exgruEscalaBloque, UltraToolTipInfo4)
        Me.exgruEscalaBloque.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.exgruEscalaBloque.Visible = False
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.tabAdicional)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(119, 96)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'tabAdicional
        '
        Appearance158.BackColor = System.Drawing.Color.White
        Appearance158.BackColor2 = System.Drawing.Color.White
        Me.tabAdicional.ClientAreaAppearance = Appearance158
        Me.tabAdicional.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.tabAdicional.Controls.Add(Me.UltraTabPageControl2)
        Me.tabAdicional.Controls.Add(Me.UltraTabPageControl3)
        Me.tabAdicional.Controls.Add(Me.UltraTabPageControl6)
        Me.tabAdicional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAdicional.Location = New System.Drawing.Point(0, 0)
        Me.tabAdicional.Name = "tabAdicional"
        Me.tabAdicional.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.tabAdicional.Size = New System.Drawing.Size(119, 96)
        Me.tabAdicional.TabIndex = 0
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "Simulador Pesos"
        UltraTab8.TabPage = Me.UltraTabPageControl3
        UltraTab8.Text = "Escalas en bloque"
        UltraTab9.TabPage = Me.UltraTabPageControl6
        UltraTab9.Text = "Tarifario"
        Me.tabAdicional.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab8, UltraTab9})
        Me.tabAdicional.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(115, 73)
        '
        'UltraGroupBox14
        '
        Appearance176.BorderColor = System.Drawing.Color.White
        Me.UltraGroupBox14.Appearance = Appearance176
        Me.UltraGroupBox14.Controls.Add(Me.hViaje)
        Me.UltraGroupBox14.Controls.Add(Me.fecViaje)
        Me.UltraGroupBox14.Controls.Add(Me.verViajeRetorno)
        Me.UltraGroupBox14.Controls.Add(Me.verFechaViaje)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel37)
        Me.UltraGroupBox14.Controls.Add(Me.cboCarreta)
        Me.UltraGroupBox14.Controls.Add(Me.txtViajeCapacidadUtil)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel38)
        Me.UltraGroupBox14.Controls.Add(Me.txtFleteUnitarioViaje)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel28)
        Me.UltraGroupBox14.Controls.Add(Me.cboOrigen)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel31)
        Me.UltraGroupBox14.Controls.Add(Me.txtFletePorcentaje)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel40)
        Me.UltraGroupBox14.Controls.Add(Me.cboDestino)
        Me.UltraGroupBox14.Controls.Add(Me.txtIdViaje)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel25)
        Me.UltraGroupBox14.Controls.Add(Me.cboTracto)
        Me.UltraGroupBox14.Controls.Add(Me.verEscala)
        Me.UltraGroupBox14.Controls.Add(Me.txtCodigoViaje)
        Me.UltraGroupBox14.Controls.Add(Me.cboCopiloto)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel29)
        Me.UltraGroupBox14.Controls.Add(Me.txtGlosaEscala)
        Me.UltraGroupBox14.Controls.Add(Me.txtFlete)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel30)
        Me.UltraGroupBox14.Controls.Add(Me.verCarreta)
        Me.UltraGroupBox14.Controls.Add(Me.UltraLabel34)
        Me.UltraGroupBox14.Controls.Add(Me.verViajeVacio)
        Me.UltraGroupBox14.Controls.Add(Me.cboAyudante)
        Me.UltraGroupBox14.Controls.Add(Me.btnAgregarViaje)
        Me.UltraGroupBox14.Controls.Add(Me.cboEscala)
        Me.UltraGroupBox14.Controls.Add(Me.cboPiloto)
        Me.UltraGroupBox14.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraGroupBox14.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox14.Name = "UltraGroupBox14"
        Me.UltraGroupBox14.Size = New System.Drawing.Size(1100, 102)
        Me.UltraGroupBox14.TabIndex = 0
        '
        'hViaje
        '
        Me.hViaje.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hViaje.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hViaje.Location = New System.Drawing.Point(155, 5)
        Me.hViaje.MaskInput = "{LOC}hh:mm"
        Me.hViaje.Name = "hViaje"
        Me.hViaje.Nullable = False
        Me.hViaje.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hViaje.Size = New System.Drawing.Size(55, 21)
        Me.hViaje.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hViaje.TabIndex = 3
        Me.hViaje.Tag = ""
        UltraToolTipInfo5.ToolTipText = "Hora de Inicio del Viaje - Salida de Planta"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.hViaje, UltraToolTipInfo5)
        Me.hViaje.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecViaje
        '
        Me.fecViaje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecViaje.Location = New System.Drawing.Point(68, 6)
        Me.fecViaje.Name = "fecViaje"
        Me.fecViaje.Size = New System.Drawing.Size(84, 20)
        Me.fecViaje.TabIndex = 2
        '
        'verViajeRetorno
        '
        Appearance177.ForeColor = System.Drawing.Color.Navy
        Me.verViajeRetorno.Appearance = Appearance177
        Me.verViajeRetorno.AutoSize = True
        Me.verViajeRetorno.Location = New System.Drawing.Point(264, 8)
        Me.verViajeRetorno.Name = "verViajeRetorno"
        Me.verViajeRetorno.Size = New System.Drawing.Size(61, 17)
        Me.verViajeRetorno.TabIndex = 5
        Me.verViajeRetorno.Text = "Retorno"
        '
        'verFechaViaje
        '
        Appearance178.ForeColor = System.Drawing.Color.Navy
        Me.verFechaViaje.Appearance = Appearance178
        Me.verFechaViaje.AutoSize = True
        Me.verFechaViaje.Location = New System.Drawing.Point(9, 6)
        Me.verFechaViaje.Name = "verFechaViaje"
        Me.verFechaViaje.Size = New System.Drawing.Size(58, 17)
        Me.verFechaViaje.TabIndex = 1
        Me.verFechaViaje.Text = "F. Ate.:"
        '
        'UltraLabel37
        '
        Appearance179.BackColor = System.Drawing.Color.Transparent
        Appearance179.ForeColor = System.Drawing.Color.Navy
        Appearance179.TextVAlignAsString = "Middle"
        Me.UltraLabel37.Appearance = Appearance179
        Me.UltraLabel37.AutoSize = True
        Me.UltraLabel37.Location = New System.Drawing.Point(966, 77)
        Me.UltraLabel37.Name = "UltraLabel37"
        Me.UltraLabel37.Size = New System.Drawing.Size(23, 14)
        Me.UltraLabel37.TabIndex = 28
        Me.UltraLabel37.Text = "CU: "
        '
        'cboCarreta
        '
        Appearance180.ForeColor = System.Drawing.Color.Black
        Me.cboCarreta.Appearance = Appearance180
        Me.cboCarreta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance181.Image = Global.ISL.Win.My.Resources.Resources.consult
        EditorButton1.Appearance = Appearance181
        Me.cboCarreta.ButtonsRight.Add(EditorButton1)
        Me.cboCarreta.DisplayMember = ""
        Me.cboCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCarreta.Enabled = False
        Me.cboCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarreta.ForeColor = System.Drawing.Color.Black
        Me.cboCarreta.ImageList = Me.imagenes
        Me.cboCarreta.Location = New System.Drawing.Point(768, 74)
        Me.cboCarreta.Name = "cboCarreta"
        Me.cboCarreta.Size = New System.Drawing.Size(92, 21)
        Me.cboCarreta.TabIndex = 16
        Me.cboCarreta.ValueMember = "Id"
        '
        'txtViajeCapacidadUtil
        '
        Appearance182.TextHAlignAsString = "Right"
        Me.txtViajeCapacidadUtil.Appearance = Appearance182
        Me.txtViajeCapacidadUtil.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCapacidadUtil.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtViajeCapacidadUtil.InputMask = "{double:5.2}"
        Me.txtViajeCapacidadUtil.Location = New System.Drawing.Point(991, 74)
        Me.txtViajeCapacidadUtil.Name = "txtViajeCapacidadUtil"
        Me.txtViajeCapacidadUtil.NonAutoSizeHeight = 20
        Me.txtViajeCapacidadUtil.Size = New System.Drawing.Size(55, 20)
        Me.txtViajeCapacidadUtil.TabIndex = 20
        Me.txtViajeCapacidadUtil.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtViajeCapacidadUtil.Text = "000"
        UltraToolTipInfo6.ToolTipText = "Capacidad Util (Kg)"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtViajeCapacidadUtil, UltraToolTipInfo6)
        '
        'UltraLabel38
        '
        Appearance183.BackColor = System.Drawing.Color.Transparent
        Appearance183.ForeColor = System.Drawing.Color.Navy
        Appearance183.TextVAlignAsString = "Middle"
        Me.UltraLabel38.Appearance = Appearance183
        Me.UltraLabel38.AutoSize = True
        Me.UltraLabel38.Location = New System.Drawing.Point(725, 55)
        Me.UltraLabel38.Name = "UltraLabel38"
        Me.UltraLabel38.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel38.TabIndex = 18
        Me.UltraLabel38.Text = "Tracto:"
        '
        'txtFleteUnitarioViaje
        '
        Appearance184.TextHAlignAsString = "Right"
        Me.txtFleteUnitarioViaje.Appearance = Appearance184
        Me.txtFleteUnitarioViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFleteUnitarioViaje.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtFleteUnitarioViaje.InputMask = "{double:5.4}"
        Me.txtFleteUnitarioViaje.Location = New System.Drawing.Point(906, 51)
        Me.txtFleteUnitarioViaje.Name = "txtFleteUnitarioViaje"
        Me.txtFleteUnitarioViaje.NonAutoSizeHeight = 20
        Me.txtFleteUnitarioViaje.ReadOnly = True
        Me.txtFleteUnitarioViaje.Size = New System.Drawing.Size(68, 20)
        Me.txtFleteUnitarioViaje.TabIndex = 17
        Me.txtFleteUnitarioViaje.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtFleteUnitarioViaje.Text = "0.0000"
        UltraToolTipInfo7.ToolTipText = "FleteUnitario del Viaje"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtFleteUnitarioViaje, UltraToolTipInfo7)
        '
        'UltraLabel28
        '
        Appearance185.BackColor = System.Drawing.Color.Transparent
        Appearance185.ForeColor = System.Drawing.Color.Navy
        Appearance185.TextVAlignAsString = "Middle"
        Me.UltraLabel28.Appearance = Appearance185
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Location = New System.Drawing.Point(342, 32)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(35, 14)
        Me.UltraLabel28.TabIndex = 12
        Me.UltraLabel28.Text = "Piloto:"
        '
        'cboOrigen
        '
        Appearance186.ForeColor = System.Drawing.Color.Black
        Me.cboOrigen.Appearance = Appearance186
        Me.cboOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboOrigen.DisplayMember = "Nombre"
        Me.cboOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboOrigen.Location = New System.Drawing.Point(68, 28)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(250, 21)
        Me.cboOrigen.TabIndex = 6
        Me.cboOrigen.ValueMember = "Id"
        '
        'UltraLabel31
        '
        Appearance187.BackColor = System.Drawing.Color.Transparent
        Appearance187.ForeColor = System.Drawing.Color.Navy
        Appearance187.TextVAlignAsString = "Middle"
        Me.UltraLabel31.Appearance = Appearance187
        Me.UltraLabel31.AutoSize = True
        Me.UltraLabel31.Location = New System.Drawing.Point(329, 55)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel31.TabIndex = 14
        Me.UltraLabel31.Text = "Copiloto:"
        '
        'txtFletePorcentaje
        '
        Appearance188.TextHAlignAsString = "Right"
        Me.txtFletePorcentaje.Appearance = Appearance188
        Me.txtFletePorcentaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFletePorcentaje.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.txtFletePorcentaje.InputMask = "nnn"
        Me.txtFletePorcentaje.Location = New System.Drawing.Point(906, 74)
        Me.txtFletePorcentaje.Name = "txtFletePorcentaje"
        Me.txtFletePorcentaje.NonAutoSizeHeight = 20
        Me.txtFletePorcentaje.NullText = "100"
        Me.txtFletePorcentaje.ReadOnly = True
        Me.txtFletePorcentaje.Size = New System.Drawing.Size(30, 20)
        Me.txtFletePorcentaje.TabIndex = 19
        Me.txtFletePorcentaje.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtFletePorcentaje.Text = "100"
        '
        'UltraLabel40
        '
        Appearance189.BackColor = System.Drawing.Color.Transparent
        Appearance189.ForeColor = System.Drawing.Color.Navy
        Appearance189.TextVAlignAsString = "Middle"
        Me.UltraLabel40.Appearance = Appearance189
        Me.UltraLabel40.AutoSize = True
        Me.UltraLabel40.Location = New System.Drawing.Point(866, 55)
        Me.UltraLabel40.Name = "UltraLabel40"
        Me.UltraLabel40.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel40.TabIndex = 20
        Me.UltraLabel40.Text = "Fletes : "
        '
        'cboDestino
        '
        Appearance190.ForeColor = System.Drawing.Color.Black
        Me.cboDestino.Appearance = Appearance190
        Me.cboDestino.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDestino.DisplayMember = "Nombre"
        Me.cboDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestino.ForeColor = System.Drawing.Color.Black
        Me.cboDestino.ImageList = Me.imagenes
        Me.cboDestino.Location = New System.Drawing.Point(68, 51)
        Me.cboDestino.Name = "cboDestino"
        Me.cboDestino.Size = New System.Drawing.Size(250, 21)
        Me.cboDestino.TabIndex = 7
        Me.cboDestino.ValueMember = "Id"
        '
        'txtIdViaje
        '
        Me.txtIdViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdViaje.Location = New System.Drawing.Point(5, 28)
        Me.txtIdViaje.Name = "txtIdViaje"
        Me.txtIdViaje.ReadOnly = True
        Me.txtIdViaje.Size = New System.Drawing.Size(8, 21)
        Me.txtIdViaje.TabIndex = 26
        Me.txtIdViaje.Visible = False
        '
        'UltraLabel25
        '
        Appearance191.BackColor = System.Drawing.Color.Transparent
        Appearance191.ForeColor = System.Drawing.Color.Navy
        Appearance191.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance191
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Location = New System.Drawing.Point(862, 77)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel25.TabIndex = 26
        Me.UltraLabel25.Text = "Flete %: "
        '
        'cboTracto
        '
        Appearance192.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.Appearance = Appearance192
        Me.cboTracto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance193.Image = Global.ISL.Win.My.Resources.Resources.consult
        EditorButton2.Appearance = Appearance193
        EditorButton2.Key = "VerTracto"
        Me.cboTracto.ButtonsRight.Add(EditorButton2)
        Me.cboTracto.DisplayMember = ""
        Me.cboTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTracto.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.ImageList = Me.imagenes
        Me.cboTracto.Location = New System.Drawing.Point(768, 51)
        Me.cboTracto.Name = "cboTracto"
        Me.cboTracto.Size = New System.Drawing.Size(92, 21)
        Me.cboTracto.TabIndex = 14
        Me.cboTracto.ValueMember = "Id"
        '
        'verEscala
        '
        Appearance194.ForeColor = System.Drawing.Color.Navy
        Me.verEscala.Appearance = Appearance194
        Me.verEscala.AutoSize = True
        Me.verEscala.Location = New System.Drawing.Point(7, 75)
        Me.verEscala.Name = "verEscala"
        Me.verEscala.Size = New System.Drawing.Size(58, 17)
        Me.verEscala.TabIndex = 8
        Me.verEscala.Text = "Escala:"
        '
        'txtCodigoViaje
        '
        Me.txtCodigoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoViaje.Enabled = False
        Me.txtCodigoViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoViaje.Location = New System.Drawing.Point(15, 28)
        Me.txtCodigoViaje.Name = "txtCodigoViaje"
        Me.txtCodigoViaje.ReadOnly = True
        Me.txtCodigoViaje.Size = New System.Drawing.Size(8, 21)
        Me.txtCodigoViaje.TabIndex = 12
        Me.txtCodigoViaje.Visible = False
        '
        'cboCopiloto
        '
        Appearance195.ForeColor = System.Drawing.Color.Black
        Me.cboCopiloto.Appearance = Appearance195
        Me.cboCopiloto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCopiloto.ButtonsRight.Add(EditorButton3)
        Me.cboCopiloto.DisplayMember = "Nombre"
        Me.cboCopiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCopiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCopiloto.ForeColor = System.Drawing.Color.Black
        Me.cboCopiloto.ImageList = Me.imagenes
        Me.cboCopiloto.Location = New System.Drawing.Point(381, 51)
        Me.cboCopiloto.Name = "cboCopiloto"
        Me.cboCopiloto.Size = New System.Drawing.Size(316, 21)
        Me.cboCopiloto.TabIndex = 12
        Me.cboCopiloto.ValueMember = "Id"
        '
        'UltraLabel29
        '
        Appearance196.BackColor = System.Drawing.Color.Transparent
        Appearance196.ForeColor = System.Drawing.Color.Navy
        Appearance196.TextVAlignAsString = "Middle"
        Me.UltraLabel29.Appearance = Appearance196
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Location = New System.Drawing.Point(24, 32)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel29.TabIndex = 4
        Me.UltraLabel29.Text = "Origen:"
        '
        'txtGlosaEscala
        '
        Me.txtGlosaEscala.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaEscala.Enabled = False
        Me.txtGlosaEscala.Location = New System.Drawing.Point(381, 5)
        Me.txtGlosaEscala.Multiline = True
        Me.txtGlosaEscala.Name = "txtGlosaEscala"
        Me.txtGlosaEscala.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosaEscala.Size = New System.Drawing.Size(700, 21)
        Me.txtGlosaEscala.TabIndex = 10
        UltraToolTipInfo8.ToolTipText = "Ingrese Justificacion de Escala Creada"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtGlosaEscala, UltraToolTipInfo8)
        '
        'txtFlete
        '
        Appearance197.TextHAlignAsString = "Right"
        Me.txtFlete.Appearance = Appearance197
        Me.txtFlete.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFlete.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtFlete.InputMask = "{double:5.4}"
        Me.txtFlete.Location = New System.Drawing.Point(978, 51)
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.NonAutoSizeHeight = 20
        Me.txtFlete.ReadOnly = True
        Me.txtFlete.Size = New System.Drawing.Size(68, 20)
        Me.txtFlete.TabIndex = 18
        Me.txtFlete.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtFlete.Text = "0.0000"
        UltraToolTipInfo9.ToolTipText = "Flete del Viaje"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtFlete, UltraToolTipInfo9)
        '
        'UltraLabel30
        '
        Appearance198.BackColor = System.Drawing.Color.Transparent
        Appearance198.ForeColor = System.Drawing.Color.Navy
        Appearance198.TextVAlignAsString = "Middle"
        Me.UltraLabel30.Appearance = Appearance198
        Me.UltraLabel30.AutoSize = True
        Me.UltraLabel30.Location = New System.Drawing.Point(20, 55)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel30.TabIndex = 6
        Me.UltraLabel30.Text = "Destino:"
        '
        'verCarreta
        '
        Appearance199.ForeColor = System.Drawing.Color.Navy
        Me.verCarreta.Appearance = Appearance199
        Me.verCarreta.AutoSize = True
        Me.verCarreta.Location = New System.Drawing.Point(703, 76)
        Me.verCarreta.Name = "verCarreta"
        Me.verCarreta.Size = New System.Drawing.Size(62, 17)
        Me.verCarreta.TabIndex = 15
        Me.verCarreta.Text = "Carreta:"
        '
        'UltraLabel34
        '
        Appearance200.BackColor = System.Drawing.Color.Transparent
        Appearance200.ForeColor = System.Drawing.Color.Navy
        Appearance200.TextVAlignAsString = "Middle"
        Me.UltraLabel34.Appearance = Appearance200
        Me.UltraLabel34.AutoSize = True
        Me.UltraLabel34.Location = New System.Drawing.Point(324, 78)
        Me.UltraLabel34.Name = "UltraLabel34"
        Me.UltraLabel34.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel34.TabIndex = 16
        Me.UltraLabel34.Text = "Ayudante:"
        '
        'verViajeVacio
        '
        Appearance201.ForeColor = System.Drawing.Color.Navy
        Me.verViajeVacio.Appearance = Appearance201
        Me.verViajeVacio.AutoSize = True
        Me.verViajeVacio.Location = New System.Drawing.Point(213, 7)
        Me.verViajeVacio.Name = "verViajeVacio"
        Me.verViajeVacio.Size = New System.Drawing.Size(50, 17)
        Me.verViajeVacio.TabIndex = 4
        Me.verViajeVacio.Text = "Vacío"
        '
        'cboAyudante
        '
        Appearance202.ForeColor = System.Drawing.Color.Black
        Me.cboAyudante.Appearance = Appearance202
        Me.cboAyudante.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboAyudante.ButtonsRight.Add(EditorButton4)
        Me.cboAyudante.DisplayMember = "Nombre"
        Me.cboAyudante.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAyudante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAyudante.ForeColor = System.Drawing.Color.Black
        Me.cboAyudante.ImageList = Me.imagenes
        Me.cboAyudante.Location = New System.Drawing.Point(381, 74)
        Me.cboAyudante.Name = "cboAyudante"
        Me.cboAyudante.Size = New System.Drawing.Size(316, 21)
        Me.cboAyudante.TabIndex = 13
        Me.cboAyudante.ValueMember = "Id"
        '
        'btnAgregarViaje
        '
        Appearance203.Image = "add.ico"
        Me.btnAgregarViaje.Appearance = Appearance203
        Me.btnAgregarViaje.ImageList = Me.imagenes
        Me.btnAgregarViaje.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnAgregarViaje.Location = New System.Drawing.Point(1050, 59)
        Me.btnAgregarViaje.Name = "btnAgregarViaje"
        Me.btnAgregarViaje.Size = New System.Drawing.Size(34, 36)
        Me.btnAgregarViaje.TabIndex = 21
        '
        'cboEscala
        '
        Appearance204.ForeColor = System.Drawing.Color.Black
        Me.cboEscala.Appearance = Appearance204
        Me.cboEscala.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEscala.DisplayMember = "Nombre"
        Me.cboEscala.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEscala.Enabled = False
        Me.cboEscala.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEscala.ForeColor = System.Drawing.Color.Black
        Me.cboEscala.ImageList = Me.imagenes
        Me.cboEscala.Location = New System.Drawing.Point(68, 74)
        Me.cboEscala.Name = "cboEscala"
        Me.cboEscala.Size = New System.Drawing.Size(250, 19)
        Me.cboEscala.TabIndex = 9
        Me.cboEscala.ValueMember = "Id"
        '
        'cboPiloto
        '
        Appearance205.ForeColor = System.Drawing.Color.Black
        Me.cboPiloto.Appearance = Appearance205
        Me.cboPiloto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboPiloto.ButtonsRight.Add(EditorButton5)
        Me.cboPiloto.DisplayMember = "Nombre"
        Me.cboPiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPiloto.ForeColor = System.Drawing.Color.Black
        Me.cboPiloto.ImageList = Me.imagenes
        Me.cboPiloto.Location = New System.Drawing.Point(381, 28)
        Me.cboPiloto.Name = "cboPiloto"
        Me.cboPiloto.Size = New System.Drawing.Size(316, 21)
        Me.cboPiloto.TabIndex = 11
        Me.cboPiloto.ValueMember = "Id"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griViajeDetalle)
        Me.UltraTabPageControl5.Controls.Add(Me.expCargaOperacion)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1248, 387)
        '
        'griViajeDetalle
        '
        Me.griViajeDetalle.CalcManager = Me.Calcular1
        Me.griViajeDetalle.ContextMenuStrip = Me.MenuViajeDetalle
        Me.griViajeDetalle.DataSource = Me.ogdOperacionDetalle
        Appearance206.BackColor = System.Drawing.Color.White
        Me.griViajeDetalle.DisplayLayout.Appearance = Appearance206
        UltraGridColumn1043.Header.VisiblePosition = 0
        UltraGridColumn1043.Hidden = True
        UltraGridColumn1044.Header.VisiblePosition = 1
        UltraGridColumn1044.Hidden = True
        UltraGridColumn1045.Header.VisiblePosition = 2
        UltraGridColumn1045.Hidden = True
        UltraGridColumn1046.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1046.Header.VisiblePosition = 4
        UltraGridColumn1046.Width = 123
        UltraGridColumn1047.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1047.Header.VisiblePosition = 5
        Appearance207.TextHAlignAsString = "Right"
        UltraGridColumn1048.CellAppearance = Appearance207
        UltraGridColumn1048.Format = "###,##0.000"
        UltraGridColumn1048.Header.VisiblePosition = 7
        UltraGridColumn1048.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        Appearance208.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance208.TextHAlignAsString = "Right"
        UltraGridColumn1049.CellAppearance = Appearance208
        UltraGridColumn1049.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1049.Header.VisiblePosition = 8
        UltraGridColumn1050.Header.VisiblePosition = 14
        UltraGridColumn1051.Header.Caption = "PagoC.E."
        UltraGridColumn1051.Header.VisiblePosition = 17
        UltraGridColumn1052.Header.VisiblePosition = 6
        UltraGridColumn1053.Header.VisiblePosition = 19
        Appearance209.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance209.TextHAlignAsString = "Right"
        UltraGridColumn1054.CellAppearance = Appearance209
        UltraGridColumn1054.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn1054.Format = "###,##0.000"
        UltraGridColumn1054.Header.VisiblePosition = 10
        UltraGridColumn1055.Header.VisiblePosition = 23
        Appearance210.TextHAlignAsString = "Right"
        UltraGridColumn1056.CellAppearance = Appearance210
        UltraGridColumn1056.Header.VisiblePosition = 22
        UltraGridColumn1057.Header.VisiblePosition = 21
        UltraGridColumn1057.Hidden = True
        UltraGridColumn1058.Header.VisiblePosition = 27
        UltraGridColumn1058.Hidden = True
        UltraGridColumn1059.Header.VisiblePosition = 28
        UltraGridColumn1059.Hidden = True
        UltraGridColumn1060.Header.VisiblePosition = 29
        UltraGridColumn1060.Hidden = True
        UltraGridColumn1061.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1061.Header.VisiblePosition = 30
        UltraGridColumn1062.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1062.Header.VisiblePosition = 31
        UltraGridColumn1063.Header.VisiblePosition = 20
        UltraGridColumn1063.Width = 40
        UltraGridColumn1064.Header.VisiblePosition = 32
        UltraGridColumn1064.Hidden = True
        UltraGridColumn1065.Header.VisiblePosition = 33
        UltraGridColumn1065.Hidden = True
        UltraGridColumn1066.Header.VisiblePosition = 34
        UltraGridColumn1066.Hidden = True
        UltraGridColumn1067.Header.VisiblePosition = 35
        UltraGridColumn1067.Hidden = True
        UltraGridColumn1068.Header.VisiblePosition = 36
        UltraGridColumn1068.Hidden = True
        UltraGridColumn1069.Header.VisiblePosition = 15
        UltraGridColumn1069.Width = 56
        UltraGridColumn1070.Header.VisiblePosition = 16
        UltraGridColumn1070.Width = 46
        UltraGridColumn1071.Header.VisiblePosition = 37
        UltraGridColumn1071.Hidden = True
        UltraGridColumn1072.Header.VisiblePosition = 3
        UltraGridColumn1072.Hidden = True
        UltraGridColumn1073.Header.VisiblePosition = 38
        UltraGridColumn1073.Hidden = True
        UltraGridColumn1074.Header.VisiblePosition = 39
        UltraGridColumn1074.Hidden = True
        UltraGridColumn1075.Header.VisiblePosition = 40
        UltraGridColumn1075.Hidden = True
        UltraGridColumn1076.Header.VisiblePosition = 41
        UltraGridColumn1076.Hidden = True
        Appearance211.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance211.TextHAlignAsString = "Right"
        UltraGridColumn1077.CellAppearance = Appearance211
        UltraGridColumn1077.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn1077.Format = "###,##0.000"
        UltraGridColumn1077.Header.VisiblePosition = 24
        UltraGridColumn1077.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn1078.Header.VisiblePosition = 42
        UltraGridColumn1078.Width = 224
        Appearance212.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance212.TextHAlignAsString = "Right"
        UltraGridColumn1079.CellAppearance = Appearance212
        UltraGridColumn1079.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn1079.Format = "#,###,##0.000"
        Appearance213.TextHAlignAsString = "Center"
        UltraGridColumn1079.Header.Appearance = Appearance213
        UltraGridColumn1079.Header.VisiblePosition = 9
        UltraGridColumn1079.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn1079.Width = 49
        Appearance214.TextHAlignAsString = "Right"
        UltraGridColumn1080.CellAppearance = Appearance214
        UltraGridColumn1080.Format = "#,###,##0.000"
        UltraGridColumn1080.Header.Caption = "C.Estiba"
        UltraGridColumn1080.Header.VisiblePosition = 12
        UltraGridColumn1080.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn1080.Width = 62
        Appearance215.TextHAlignAsString = "Right"
        UltraGridColumn1081.CellAppearance = Appearance215
        UltraGridColumn1081.Format = "#,###,##0.000"
        UltraGridColumn1081.Header.Caption = "C.Estiba Desc"
        UltraGridColumn1081.Header.VisiblePosition = 13
        UltraGridColumn1081.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn1081.Width = 64
        Appearance216.TextHAlignAsString = "Right"
        UltraGridColumn1082.CellAppearance = Appearance216
        UltraGridColumn1082.Format = "#,###,##0.000"
        Appearance217.TextHAlignAsString = "Center"
        UltraGridColumn1082.Header.Appearance = Appearance217
        UltraGridColumn1082.Header.VisiblePosition = 11
        UltraGridColumn1082.MaskInput = "{LOC}nnn,nnn,nnn.nnnn"
        UltraGridColumn1082.Width = 67
        UltraGridColumn1083.Header.Caption = "I.IGV Cons."
        UltraGridColumn1083.Header.VisiblePosition = 25
        UltraGridColumn1083.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1083.Width = 40
        UltraGridColumn1084.Header.Caption = "TipoPC"
        UltraGridColumn1084.Header.VisiblePosition = 18
        Appearance218.TextHAlignAsString = "Center"
        UltraGridColumn1085.Header.Appearance = Appearance218
        UltraGridColumn1085.Header.VisiblePosition = 26
        UltraGridColumn1085.Width = 108
        UltraGridColumn1086.Header.VisiblePosition = 43
        UltraGridColumn1086.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1086.Width = 45
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn1043, UltraGridColumn1044, UltraGridColumn1045, UltraGridColumn1046, UltraGridColumn1047, UltraGridColumn1048, UltraGridColumn1049, UltraGridColumn1050, UltraGridColumn1051, UltraGridColumn1052, UltraGridColumn1053, UltraGridColumn1054, UltraGridColumn1055, UltraGridColumn1056, UltraGridColumn1057, UltraGridColumn1058, UltraGridColumn1059, UltraGridColumn1060, UltraGridColumn1061, UltraGridColumn1062, UltraGridColumn1063, UltraGridColumn1064, UltraGridColumn1065, UltraGridColumn1066, UltraGridColumn1067, UltraGridColumn1068, UltraGridColumn1069, UltraGridColumn1070, UltraGridColumn1071, UltraGridColumn1072, UltraGridColumn1073, UltraGridColumn1074, UltraGridColumn1075, UltraGridColumn1076, UltraGridColumn1077, UltraGridColumn1078, UltraGridColumn1079, UltraGridColumn1080, UltraGridColumn1081, UltraGridColumn1082, UltraGridColumn1083, UltraGridColumn1084, UltraGridColumn1085, UltraGridColumn1086})
        UltraGridBand8.SummaryFooterCaption = "Totales:"
        Me.griViajeDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griViajeDetalle.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griViajeDetalle.DisplayLayout.GroupByBox.Hidden = True
        Me.griViajeDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajeDetalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance219.BackColor = System.Drawing.Color.Transparent
        Me.griViajeDetalle.DisplayLayout.Override.CardAreaAppearance = Appearance219
        Me.griViajeDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griViajeDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance220.TextHAlignAsString = "Left"
        Me.griViajeDetalle.DisplayLayout.Override.HeaderAppearance = Appearance220
        Me.griViajeDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajeDetalle.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance221.TextVAlignAsString = "Middle"
        Me.griViajeDetalle.DisplayLayout.Override.RowAppearance = Appearance221
        Me.griViajeDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griViajeDetalle.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajeDetalle.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajeDetalle.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griViajeDetalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griViajeDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajeDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajeDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajeDetalle.Location = New System.Drawing.Point(0, 200)
        Me.griViajeDetalle.Name = "griViajeDetalle"
        Me.griViajeDetalle.Size = New System.Drawing.Size(1248, 187)
        Me.griViajeDetalle.TabIndex = 4
        Me.griViajeDetalle.TabStop = False
        Me.griViajeDetalle.Tag = ""
        '
        'MenuViajeDetalle
        '
        Me.MenuViajeDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuViajeDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDuplicar, Me.mnuEliminar})
        Me.MenuViajeDetalle.Name = "mnu_Transferencias"
        Me.MenuViajeDetalle.Size = New System.Drawing.Size(165, 56)
        '
        'mnuDuplicar
        '
        Me.mnuDuplicar.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.mnuDuplicar.Name = "mnuDuplicar"
        Me.mnuDuplicar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuDuplicar.Size = New System.Drawing.Size(164, 26)
        Me.mnuDuplicar.Text = "Duplicar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEliminar.Size = New System.Drawing.Size(164, 26)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'ogdOperacionDetalle
        '
        UltraDataColumn179.DataType = GetType(Double)
        UltraDataColumn180.DataType = GetType(Double)
        UltraDataColumn181.DataType = GetType(Boolean)
        UltraDataColumn182.DataType = GetType(Boolean)
        UltraDataColumn185.DataType = GetType(Double)
        UltraDataColumn186.DataType = GetType(Object)
        UltraDataColumn187.DataType = GetType(Double)
        UltraDataColumn194.DataType = GetType(Boolean)
        Me.ogdOperacionDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181, UltraDataColumn182, UltraDataColumn183, UltraDataColumn184, UltraDataColumn185, UltraDataColumn186, UltraDataColumn187, UltraDataColumn188, UltraDataColumn189, UltraDataColumn190, UltraDataColumn191, UltraDataColumn192, UltraDataColumn193, UltraDataColumn194, UltraDataColumn195, UltraDataColumn196, UltraDataColumn197, UltraDataColumn198, UltraDataColumn199, UltraDataColumn200, UltraDataColumn201, UltraDataColumn202, UltraDataColumn203, UltraDataColumn204, UltraDataColumn205, UltraDataColumn206, UltraDataColumn207, UltraDataColumn208, UltraDataColumn209})
        '
        'expCargaOperacion
        '
        Appearance222.BackColor = System.Drawing.Color.White
        Appearance222.BackColor2 = System.Drawing.Color.White
        Me.expCargaOperacion.ContentAreaAppearance = Appearance222
        Me.expCargaOperacion.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.expCargaOperacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.expCargaOperacion.ExpandedSize = New System.Drawing.Size(1248, 200)
        Me.expCargaOperacion.Location = New System.Drawing.Point(0, 0)
        Me.expCargaOperacion.Name = "expCargaOperacion"
        Me.expCargaOperacion.Size = New System.Drawing.Size(1248, 200)
        Me.expCargaOperacion.TabIndex = 1
        Me.expCargaOperacion.TabStop = False
        Me.expCargaOperacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.expListaDemandas)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.expNuevaCarga)
        Me.UltraExpandableGroupBoxPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(3, 18)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(1242, 179)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        '
        'expListaDemandas
        '
        Me.expListaDemandas.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Far
        Appearance223.BackColor = System.Drawing.Color.White
        Appearance223.BackColor2 = System.Drawing.Color.White
        Me.expListaDemandas.ContentAreaAppearance = Appearance223
        Me.expListaDemandas.Controls.Add(Me.UltraExpandableGroupBoxPanel16)
        Me.expListaDemandas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.expListaDemandas.ExpandedSize = New System.Drawing.Size(288, 179)
        Me.expListaDemandas.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.expListaDemandas.Location = New System.Drawing.Point(954, 0)
        Me.expListaDemandas.Name = "expListaDemandas"
        Me.expListaDemandas.Size = New System.Drawing.Size(288, 179)
        Me.expListaDemandas.TabIndex = 1
        Me.expListaDemandas.TabStop = False
        Me.expListaDemandas.Text = "Lista Pedido Carga"
        Me.expListaDemandas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel16
        '
        Me.UltraExpandableGroupBoxPanel16.Controls.Add(Me.griDemanda)
        Me.UltraExpandableGroupBoxPanel16.Controls.Add(Me.UltraExpandableGroupBox3)
        Me.UltraExpandableGroupBoxPanel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel16.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel16.Name = "UltraExpandableGroupBoxPanel16"
        Me.UltraExpandableGroupBoxPanel16.Size = New System.Drawing.Size(265, 173)
        Me.UltraExpandableGroupBoxPanel16.TabIndex = 0
        '
        'griDemanda
        '
        Me.griDemanda.CalcManager = Me.Calcular1
        Me.griDemanda.DataSource = Me.ogdDemanda
        UltraGridColumn1087.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1087.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn1087.Header.Caption = "Select"
        UltraGridColumn1087.Header.VisiblePosition = 1
        UltraGridColumn1087.Width = 32
        UltraGridColumn1088.Header.VisiblePosition = 0
        UltraGridColumn1088.Hidden = True
        UltraGridColumn1088.Width = 85
        UltraGridColumn1089.Header.VisiblePosition = 2
        UltraGridColumn1089.Hidden = True
        UltraGridColumn1089.Width = 91
        UltraGridColumn1090.Header.VisiblePosition = 4
        UltraGridColumn1090.Hidden = True
        UltraGridColumn1091.Header.VisiblePosition = 5
        UltraGridColumn1091.Hidden = True
        UltraGridColumn1092.Header.VisiblePosition = 7
        UltraGridColumn1092.Width = 300
        UltraGridColumn1093.Header.VisiblePosition = 15
        UltraGridColumn1093.Hidden = True
        UltraGridColumn1094.Header.VisiblePosition = 9
        UltraGridColumn1094.Width = 100
        UltraGridColumn1095.Header.VisiblePosition = 17
        UltraGridColumn1095.Hidden = True
        UltraGridColumn1096.Header.VisiblePosition = 11
        UltraGridColumn1096.Width = 80
        UltraGridColumn1097.Header.VisiblePosition = 16
        UltraGridColumn1097.Hidden = True
        Appearance224.BackColor = System.Drawing.Color.LightGreen
        Appearance224.TextHAlignAsString = "Right"
        UltraGridColumn1098.CellAppearance = Appearance224
        UltraGridColumn1098.Format = "#,###,###,##0.0000"
        UltraGridColumn1098.Header.VisiblePosition = 14
        UltraGridColumn1098.MaskInput = "{LOC}nn,nnn,nnn.nnnn"
        UltraGridColumn1098.Width = 80
        Appearance225.TextHAlignAsString = "Right"
        UltraGridColumn1099.CellAppearance = Appearance225
        UltraGridColumn1099.Header.VisiblePosition = 3
        UltraGridColumn1099.Hidden = True
        UltraGridColumn1100.Header.VisiblePosition = 19
        UltraGridColumn1100.Hidden = True
        UltraGridColumn1101.Header.VisiblePosition = 18
        UltraGridColumn1101.Hidden = True
        UltraGridColumn1102.Header.VisiblePosition = 20
        UltraGridColumn1102.Hidden = True
        UltraGridColumn1103.Header.VisiblePosition = 21
        UltraGridColumn1103.Hidden = True
        UltraGridColumn1104.Header.VisiblePosition = 12
        UltraGridColumn1104.Width = 200
        UltraGridColumn1105.Header.VisiblePosition = 10
        UltraGridColumn1105.Width = 150
        UltraGridColumn1106.Header.VisiblePosition = 22
        UltraGridColumn1106.Hidden = True
        UltraGridColumn1107.Header.VisiblePosition = 23
        UltraGridColumn1107.Hidden = True
        UltraGridColumn1108.Header.VisiblePosition = 24
        UltraGridColumn1108.Hidden = True
        UltraGridColumn1109.Header.VisiblePosition = 25
        UltraGridColumn1109.Hidden = True
        UltraGridColumn1110.Header.VisiblePosition = 6
        UltraGridColumn1110.Hidden = True
        UltraGridColumn1110.Width = 100
        UltraGridColumn1111.Header.VisiblePosition = 13
        UltraGridColumn1111.Width = 100
        UltraGridColumn1112.Header.VisiblePosition = 26
        UltraGridColumn1112.Hidden = True
        UltraGridColumn1113.Header.VisiblePosition = 27
        UltraGridColumn1113.Hidden = True
        UltraGridColumn1114.Header.VisiblePosition = 28
        UltraGridColumn1114.Hidden = True
        UltraGridColumn1115.Header.VisiblePosition = 29
        UltraGridColumn1115.Hidden = True
        UltraGridColumn1116.Header.VisiblePosition = 30
        UltraGridColumn1116.Hidden = True
        UltraGridColumn1117.Header.VisiblePosition = 31
        UltraGridColumn1117.Hidden = True
        UltraGridColumn1118.Header.VisiblePosition = 32
        UltraGridColumn1118.Hidden = True
        UltraGridColumn1119.Header.VisiblePosition = 33
        UltraGridColumn1119.Hidden = True
        UltraGridColumn1120.Header.VisiblePosition = 34
        UltraGridColumn1120.Hidden = True
        UltraGridColumn1121.Header.VisiblePosition = 35
        UltraGridColumn1121.Hidden = True
        UltraGridColumn1122.Header.VisiblePosition = 36
        UltraGridColumn1122.Hidden = True
        UltraGridColumn1123.Header.VisiblePosition = 37
        UltraGridColumn1123.Hidden = True
        UltraGridColumn1124.Header.VisiblePosition = 38
        UltraGridColumn1124.Hidden = True
        UltraGridColumn1125.Header.VisiblePosition = 39
        UltraGridColumn1125.Hidden = True
        UltraGridColumn1126.Header.VisiblePosition = 40
        UltraGridColumn1126.Hidden = True
        UltraGridColumn1127.Header.VisiblePosition = 42
        UltraGridColumn1127.Hidden = True
        UltraGridColumn1128.Header.VisiblePosition = 43
        UltraGridColumn1128.Hidden = True
        UltraGridColumn1129.Header.VisiblePosition = 44
        UltraGridColumn1129.Hidden = True
        UltraGridColumn1130.Header.VisiblePosition = 45
        UltraGridColumn1130.Hidden = True
        UltraGridColumn1131.Header.VisiblePosition = 8
        UltraGridColumn1132.Header.VisiblePosition = 41
        UltraGridColumn1132.Hidden = True
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn1087, UltraGridColumn1088, UltraGridColumn1089, UltraGridColumn1090, UltraGridColumn1091, UltraGridColumn1092, UltraGridColumn1093, UltraGridColumn1094, UltraGridColumn1095, UltraGridColumn1096, UltraGridColumn1097, UltraGridColumn1098, UltraGridColumn1099, UltraGridColumn1100, UltraGridColumn1101, UltraGridColumn1102, UltraGridColumn1103, UltraGridColumn1104, UltraGridColumn1105, UltraGridColumn1106, UltraGridColumn1107, UltraGridColumn1108, UltraGridColumn1109, UltraGridColumn1110, UltraGridColumn1111, UltraGridColumn1112, UltraGridColumn1113, UltraGridColumn1114, UltraGridColumn1115, UltraGridColumn1116, UltraGridColumn1117, UltraGridColumn1118, UltraGridColumn1119, UltraGridColumn1120, UltraGridColumn1121, UltraGridColumn1122, UltraGridColumn1123, UltraGridColumn1124, UltraGridColumn1125, UltraGridColumn1126, UltraGridColumn1127, UltraGridColumn1128, UltraGridColumn1129, UltraGridColumn1130, UltraGridColumn1131, UltraGridColumn1132})
        Me.griDemanda.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.griDemanda.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griDemanda.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griDemanda.DisplayLayout.MaxColScrollRegions = 1
        Me.griDemanda.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDemanda.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDemanda.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDemanda.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDemanda.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDemanda.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDemanda.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.None
        Me.griDemanda.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griDemanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDemanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDemanda.Location = New System.Drawing.Point(0, 55)
        Me.griDemanda.Name = "griDemanda"
        Me.griDemanda.Size = New System.Drawing.Size(265, 118)
        Me.griDemanda.TabIndex = 2
        Me.griDemanda.TabStop = False
        Me.griDemanda.Tag = ""
        '
        'ogdDemanda
        '
        UltraDataColumn210.DataType = GetType(Boolean)
        UltraDataColumn210.DefaultValue = False
        UltraDataColumn221.DataType = GetType(Double)
        UltraDataColumn222.DataType = GetType(Double)
        Me.ogdDemanda.Band.Columns.AddRange(New Object() {UltraDataColumn210, UltraDataColumn211, UltraDataColumn212, UltraDataColumn213, UltraDataColumn214, UltraDataColumn215, UltraDataColumn216, UltraDataColumn217, UltraDataColumn218, UltraDataColumn219, UltraDataColumn220, UltraDataColumn221, UltraDataColumn222, UltraDataColumn223, UltraDataColumn224, UltraDataColumn225, UltraDataColumn226, UltraDataColumn227, UltraDataColumn228, UltraDataColumn229, UltraDataColumn230, UltraDataColumn231, UltraDataColumn232, UltraDataColumn233, UltraDataColumn234, UltraDataColumn235, UltraDataColumn236, UltraDataColumn237, UltraDataColumn238, UltraDataColumn239, UltraDataColumn240, UltraDataColumn241, UltraDataColumn242, UltraDataColumn243, UltraDataColumn244, UltraDataColumn245, UltraDataColumn246, UltraDataColumn247, UltraDataColumn248, UltraDataColumn249, UltraDataColumn250, UltraDataColumn251, UltraDataColumn252, UltraDataColumn253, UltraDataColumn254})
        '
        'UltraExpandableGroupBox3
        '
        Appearance226.BackColor = System.Drawing.Color.White
        Appearance226.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox3.ContentAreaAppearance = Appearance226
        Me.UltraExpandableGroupBox3.Controls.Add(Me.UltraExpandableGroupBoxPanel9)
        Me.UltraExpandableGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox3.ExpandedSize = New System.Drawing.Size(265, 55)
        Me.UltraExpandableGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox3.Name = "UltraExpandableGroupBox3"
        Me.UltraExpandableGroupBox3.Size = New System.Drawing.Size(265, 55)
        Me.UltraExpandableGroupBox3.TabIndex = 1
        Me.UltraExpandableGroupBox3.TabStop = False
        Me.UltraExpandableGroupBox3.Text = "Consultas: Pedido Carga para Consumir"
        Me.UltraExpandableGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel9
        '
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.lblCodigoDemandaAProgramar)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.lblDemandaProgramar)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.cboZonaDemanda)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraLabel60)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.btnConsultarDemanda)
        Me.UltraExpandableGroupBoxPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel9.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel9.Name = "UltraExpandableGroupBoxPanel9"
        Me.UltraExpandableGroupBoxPanel9.Size = New System.Drawing.Size(259, 32)
        Me.UltraExpandableGroupBoxPanel9.TabIndex = 0
        '
        'lblCodigoDemandaAProgramar
        '
        Appearance227.BackColor = System.Drawing.Color.Transparent
        Appearance227.ForeColor = System.Drawing.Color.Navy
        Appearance227.TextVAlignAsString = "Middle"
        Me.lblCodigoDemandaAProgramar.Appearance = Appearance227
        Me.lblCodigoDemandaAProgramar.AutoSize = True
        Me.lblCodigoDemandaAProgramar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoDemandaAProgramar.Location = New System.Drawing.Point(405, 9)
        Me.lblCodigoDemandaAProgramar.Name = "lblCodigoDemandaAProgramar"
        Me.lblCodigoDemandaAProgramar.Size = New System.Drawing.Size(23, 14)
        Me.lblCodigoDemandaAProgramar.TabIndex = 8
        Me.lblCodigoDemandaAProgramar.Text = "cod"
        Me.lblCodigoDemandaAProgramar.Visible = False
        '
        'lblDemandaProgramar
        '
        Appearance228.BackColor = System.Drawing.Color.Transparent
        Appearance228.ForeColor = System.Drawing.Color.Navy
        Appearance228.TextVAlignAsString = "Middle"
        Me.lblDemandaProgramar.Appearance = Appearance228
        Me.lblDemandaProgramar.AutoSize = True
        Me.lblDemandaProgramar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDemandaProgramar.Location = New System.Drawing.Point(250, 9)
        Me.lblDemandaProgramar.Name = "lblDemandaProgramar"
        Me.lblDemandaProgramar.Size = New System.Drawing.Size(150, 14)
        Me.lblDemandaProgramar.TabIndex = 7
        Me.lblDemandaProgramar.Text = "Codigo Pedido Carga Selec.:"
        Me.lblDemandaProgramar.Visible = False
        '
        'cboZonaDemanda
        '
        Appearance229.ForeColor = System.Drawing.Color.Black
        Me.cboZonaDemanda.Appearance = Appearance229
        Me.cboZonaDemanda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboZonaDemanda.DisplayMember = "Nombre"
        Me.cboZonaDemanda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboZonaDemanda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboZonaDemanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZonaDemanda.ForeColor = System.Drawing.Color.Black
        Me.cboZonaDemanda.Location = New System.Drawing.Point(41, 5)
        Me.cboZonaDemanda.Name = "cboZonaDemanda"
        Me.cboZonaDemanda.Size = New System.Drawing.Size(150, 21)
        Me.cboZonaDemanda.TabIndex = 1
        Me.cboZonaDemanda.ValueMember = "Id"
        '
        'UltraLabel60
        '
        Appearance230.BackColor = System.Drawing.Color.Transparent
        Appearance230.ForeColor = System.Drawing.Color.Navy
        Appearance230.TextVAlignAsString = "Middle"
        Me.UltraLabel60.Appearance = Appearance230
        Me.UltraLabel60.AutoSize = True
        Me.UltraLabel60.Location = New System.Drawing.Point(3, 9)
        Me.UltraLabel60.Name = "UltraLabel60"
        Me.UltraLabel60.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel60.TabIndex = 0
        Me.UltraLabel60.Text = "Zona:"
        '
        'btnConsultarDemanda
        '
        Appearance231.Image = "Consultar.ico"
        Appearance231.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance231.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnConsultarDemanda.Appearance = Appearance231
        Me.btnConsultarDemanda.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button
        Me.btnConsultarDemanda.ImageList = Me.imagenes
        Me.btnConsultarDemanda.ImageSize = New System.Drawing.Size(28, 23)
        Me.btnConsultarDemanda.Location = New System.Drawing.Point(197, 1)
        Me.btnConsultarDemanda.Name = "btnConsultarDemanda"
        Me.btnConsultarDemanda.Size = New System.Drawing.Size(45, 30)
        Me.btnConsultarDemanda.TabIndex = 2
        '
        'expNuevaCarga
        '
        Me.expNuevaCarga.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Far
        Appearance232.BackColor = System.Drawing.Color.White
        Appearance232.BackColor2 = System.Drawing.Color.White
        Me.expNuevaCarga.ContentAreaAppearance = Appearance232
        Me.expNuevaCarga.Controls.Add(Me.UltraExpandableGroupBoxPanel7)
        Me.expNuevaCarga.Dock = System.Windows.Forms.DockStyle.Left
        Me.expNuevaCarga.ExpandedSize = New System.Drawing.Size(954, 179)
        Me.expNuevaCarga.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.expNuevaCarga.Location = New System.Drawing.Point(0, 0)
        Me.expNuevaCarga.Name = "expNuevaCarga"
        Me.expNuevaCarga.Size = New System.Drawing.Size(954, 179)
        Me.expNuevaCarga.TabIndex = 0
        Me.expNuevaCarga.TabStop = False
        Me.expNuevaCarga.Text = "NuevaCarga"
        Me.expNuevaCarga.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel7
        '
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtRucCLiente)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtRucComisionista)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraGroupBox9)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.cboClienteFinal)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel13)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Agrupacion6)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel14)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtCantidad)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel17)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.btnAgregar)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel12)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel15)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.cboMaterial)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.cboTipoCarga)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.cboComisionista)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.cboCliente)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.lblClienteFinal)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraGroupBox10)
        Me.UltraExpandableGroupBoxPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel7.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel7.Name = "UltraExpandableGroupBoxPanel7"
        Me.UltraExpandableGroupBoxPanel7.Size = New System.Drawing.Size(931, 173)
        Me.UltraExpandableGroupBoxPanel7.TabIndex = 0
        '
        'txtRucCLiente
        '
        Me.txtRucCLiente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucCLiente.Enabled = False
        Me.txtRucCLiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucCLiente.Location = New System.Drawing.Point(79, 25)
        Me.txtRucCLiente.Name = "txtRucCLiente"
        Me.txtRucCLiente.ReadOnly = True
        Me.txtRucCLiente.Size = New System.Drawing.Size(100, 21)
        Me.txtRucCLiente.TabIndex = 2
        '
        'txtRucComisionista
        '
        Me.txtRucComisionista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucComisionista.Enabled = False
        Me.txtRucComisionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucComisionista.Location = New System.Drawing.Point(79, 97)
        Me.txtRucComisionista.Name = "txtRucComisionista"
        Me.txtRucComisionista.Size = New System.Drawing.Size(111, 21)
        Me.txtRucComisionista.TabIndex = 5
        '
        'UltraGroupBox9
        '
        Appearance233.BackColor = System.Drawing.Color.White
        Appearance233.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox9.ContentAreaAppearance = Appearance233
        Me.UltraGroupBox9.Controls.Add(Me.chkIndFalsoFlete)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel68)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel32)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox9.Controls.Add(Me.txtAdelantoFlete)
        Me.UltraGroupBox9.Controls.Add(Me.verValidaFU)
        Me.UltraGroupBox9.Controls.Add(Me.verIncluyeIgv)
        Me.UltraGroupBox9.Controls.Add(Me.CalFleteUnitario)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel69)
        Me.UltraGroupBox9.Controls.Add(Me.CalFleteUnitarioIGV)
        Me.UltraGroupBox9.Controls.Add(Me.txtFleteTotalDetalle)
        Me.UltraGroupBox9.Controls.Add(Me.lblSubtotal)
        Me.UltraGroupBox9.Controls.Add(Me.txtSubtotal)
        Me.UltraGroupBox9.Location = New System.Drawing.Point(369, 0)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(226, 143)
        Me.UltraGroupBox9.TabIndex = 9
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkIndFalsoFlete
        '
        Appearance234.ForeColor = System.Drawing.Color.Navy
        Me.chkIndFalsoFlete.Appearance = Appearance234
        Me.chkIndFalsoFlete.AutoSize = True
        Me.chkIndFalsoFlete.Location = New System.Drawing.Point(30, 122)
        Me.chkIndFalsoFlete.Name = "chkIndFalsoFlete"
        Me.chkIndFalsoFlete.Size = New System.Drawing.Size(77, 17)
        Me.chkIndFalsoFlete.TabIndex = 8
        Me.chkIndFalsoFlete.Text = "Falso Flete"
        Me.chkIndFalsoFlete.Visible = False
        '
        'UltraLabel68
        '
        Appearance235.BackColor = System.Drawing.Color.Transparent
        Appearance235.ForeColor = System.Drawing.Color.Navy
        Appearance235.TextVAlignAsString = "Middle"
        Me.UltraLabel68.Appearance = Appearance235
        Me.UltraLabel68.AutoSize = True
        Me.UltraLabel68.Location = New System.Drawing.Point(64, 74)
        Me.UltraLabel68.Name = "UltraLabel68"
        Me.UltraLabel68.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel68.TabIndex = 61
        Me.UltraLabel68.Text = "F.Total: "
        '
        'UltraLabel32
        '
        Appearance236.BackColor = System.Drawing.Color.Transparent
        Appearance236.ForeColor = System.Drawing.Color.Navy
        Appearance236.TextVAlignAsString = "Middle"
        Me.UltraLabel32.Appearance = Appearance236
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Location = New System.Drawing.Point(33, 98)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(75, 14)
        Me.UltraLabel32.TabIndex = 55
        Me.UltraLabel32.Text = "AdelantoFlete: "
        '
        'UltraLabel11
        '
        Appearance237.BackColor = System.Drawing.Color.Transparent
        Appearance237.ForeColor = System.Drawing.Color.Navy
        Appearance237.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance237
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(7, 8)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(99, 14)
        Me.UltraLabel11.TabIndex = 11
        Me.UltraLabel11.Text = "Flete Uni (Sin IGV): "
        '
        'txtAdelantoFlete
        '
        Appearance238.TextHAlignAsString = "Right"
        Me.txtAdelantoFlete.Appearance = Appearance238
        Me.txtAdelantoFlete.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAdelantoFlete.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtAdelantoFlete.InputMask = "{double:10.4}"
        Me.txtAdelantoFlete.Location = New System.Drawing.Point(109, 94)
        Me.txtAdelantoFlete.Name = "txtAdelantoFlete"
        Me.txtAdelantoFlete.NonAutoSizeHeight = 20
        Me.txtAdelantoFlete.NullText = "0.00"
        Me.txtAdelantoFlete.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtAdelantoFlete.Size = New System.Drawing.Size(95, 20)
        Me.txtAdelantoFlete.TabIndex = 7
        Me.txtAdelantoFlete.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtAdelantoFlete.Text = "0.0000"
        '
        'verValidaFU
        '
        Appearance239.ForeColor = System.Drawing.Color.Navy
        Me.verValidaFU.Appearance = Appearance239
        Me.verValidaFU.AutoSize = True
        Me.verValidaFU.Checked = True
        Me.verValidaFU.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verValidaFU.Location = New System.Drawing.Point(208, 6)
        Me.verValidaFU.Name = "verValidaFU"
        Me.verValidaFU.Size = New System.Drawing.Size(14, 13)
        Me.verValidaFU.TabIndex = 1
        UltraToolTipInfo10.ToolTipText = "Modificar Flete Unitario"
        UltraToolTipInfo10.ToolTipTitle = "Validar Flete Unitario"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.verValidaFU, UltraToolTipInfo10)
        '
        'verIncluyeIgv
        '
        Appearance240.ForeColor = System.Drawing.Color.Navy
        Me.verIncluyeIgv.Appearance = Appearance240
        Me.verIncluyeIgv.AutoSize = True
        Me.verIncluyeIgv.Location = New System.Drawing.Point(7, 71)
        Me.verIncluyeIgv.Name = "verIncluyeIgv"
        Me.verIncluyeIgv.Size = New System.Drawing.Size(47, 17)
        Me.verIncluyeIgv.TabIndex = 5
        Me.verIncluyeIgv.Text = "I.IGV"
        '
        'CalFleteUnitario
        '
        Appearance241.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance241.TextHAlignAsString = "Right"
        Me.CalFleteUnitario.Appearance = Appearance241
        Me.CalFleteUnitario.AutoSize = False
        CalculatorButton2.Key = "."
        CalculatorButton2.KeyCodeAlternateValue = 190
        CalculatorButton2.KeyCodeValue = 110
        CalculatorButton2.Text = ","
        Me.CalFleteUnitario.Buttons.AddRange(New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton() {CalculatorButton2})
        Appearance242.Image = "06_calculator.ico"
        EditorButton6.Appearance = Appearance242
        Me.CalFleteUnitario.ButtonsLeft.Add(EditorButton6)
        Me.CalFleteUnitario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CalFleteUnitario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CalFleteUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalFleteUnitario.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CalFleteUnitario.ImageList = Me.imagenes
        Me.CalFleteUnitario.Location = New System.Drawing.Point(109, 5)
        Me.CalFleteUnitario.Name = "CalFleteUnitario"
        Me.CalFleteUnitario.NullText = "0.00"
        Me.CalFleteUnitario.Size = New System.Drawing.Size(95, 20)
        Me.CalFleteUnitario.TabIndex = 2
        Me.CalFleteUnitario.Text = "0.0000"
        '
        'UltraLabel69
        '
        Appearance243.BackColor = System.Drawing.Color.Transparent
        Appearance243.ForeColor = System.Drawing.Color.Navy
        Appearance243.TextVAlignAsString = "Middle"
        Me.UltraLabel69.Appearance = Appearance243
        Me.UltraLabel69.AutoSize = True
        Me.UltraLabel69.Location = New System.Drawing.Point(2, 31)
        Me.UltraLabel69.Name = "UltraLabel69"
        Me.UltraLabel69.Size = New System.Drawing.Size(103, 14)
        Me.UltraLabel69.TabIndex = 57
        Me.UltraLabel69.Text = "Flete Uni (Con IGV): "
        '
        'CalFleteUnitarioIGV
        '
        Appearance244.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance244.TextHAlignAsString = "Right"
        Me.CalFleteUnitarioIGV.Appearance = Appearance244
        Me.CalFleteUnitarioIGV.AutoSize = False
        CalculatorButton3.Key = "."
        CalculatorButton3.KeyCodeAlternateValue = 190
        CalculatorButton3.KeyCodeValue = 110
        CalculatorButton3.Text = ","
        Me.CalFleteUnitarioIGV.Buttons.AddRange(New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton() {CalculatorButton3})
        Me.CalFleteUnitarioIGV.ButtonsLeft.Add(EditorButton7)
        Me.CalFleteUnitarioIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CalFleteUnitarioIGV.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CalFleteUnitarioIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalFleteUnitarioIGV.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CalFleteUnitarioIGV.ImageList = Me.imagenes
        Me.CalFleteUnitarioIGV.Location = New System.Drawing.Point(109, 27)
        Me.CalFleteUnitarioIGV.Name = "CalFleteUnitarioIGV"
        Me.CalFleteUnitarioIGV.NullText = "0.00"
        Me.CalFleteUnitarioIGV.Size = New System.Drawing.Size(95, 20)
        Me.CalFleteUnitarioIGV.TabIndex = 3
        Me.CalFleteUnitarioIGV.Text = "0.000"
        '
        'txtFleteTotalDetalle
        '
        Appearance245.TextHAlignAsString = "Right"
        Me.txtFleteTotalDetalle.Appearance = Appearance245
        Me.txtFleteTotalDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFleteTotalDetalle.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtFleteTotalDetalle.InputMask = "{LOC}nn,nnn,nnn.nnnn"
        Me.txtFleteTotalDetalle.Location = New System.Drawing.Point(109, 71)
        Me.txtFleteTotalDetalle.Name = "txtFleteTotalDetalle"
        Me.txtFleteTotalDetalle.NonAutoSizeHeight = 20
        Me.txtFleteTotalDetalle.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFleteTotalDetalle.ReadOnly = True
        Me.txtFleteTotalDetalle.Size = New System.Drawing.Size(95, 20)
        Me.txtFleteTotalDetalle.TabIndex = 6
        Me.txtFleteTotalDetalle.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtFleteTotalDetalle.Text = "0.0000"
        '
        'lblSubtotal
        '
        Appearance246.BackColor = System.Drawing.Color.Transparent
        Appearance246.ForeColor = System.Drawing.Color.Navy
        Appearance246.TextVAlignAsString = "Middle"
        Me.lblSubtotal.Appearance = Appearance246
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(59, 52)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(47, 14)
        Me.lblSubtotal.TabIndex = 59
        Me.lblSubtotal.Text = "Subtotal: "
        '
        'txtSubtotal
        '
        Appearance247.TextHAlignAsString = "Right"
        Me.txtSubtotal.Appearance = Appearance247
        Me.txtSubtotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSubtotal.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtSubtotal.InputMask = "{double:10.4}"
        Me.txtSubtotal.Location = New System.Drawing.Point(109, 49)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.NonAutoSizeHeight = 20
        Me.txtSubtotal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(95, 20)
        Me.txtSubtotal.TabIndex = 4
        Me.txtSubtotal.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtSubtotal.Text = "0.0000"
        '
        'cboClienteFinal
        '
        Me.cboClienteFinal.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance248.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton8.Appearance = Appearance248
        EditorButton8.Key = "btnEditarClienteFinal"
        EditorButton8.Visible = False
        Me.cboClienteFinal.ButtonsRight.Add(EditorButton8)
        Me.cboClienteFinal.DisplayMember = "Nombre"
        Me.cboClienteFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteFinal.Location = New System.Drawing.Point(79, 49)
        Me.cboClienteFinal.Name = "cboClienteFinal"
        Me.cboClienteFinal.Size = New System.Drawing.Size(285, 21)
        Me.cboClienteFinal.TabIndex = 3
        Me.cboClienteFinal.ValueMember = "Id"
        '
        'UltraLabel13
        '
        Appearance249.BackColor = System.Drawing.Color.Transparent
        Appearance249.ForeColor = System.Drawing.Color.Navy
        Appearance249.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance249
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(5, 77)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel13.TabIndex = 2
        Me.UltraLabel13.Text = "Comisionista:"
        '
        'Agrupacion6
        '
        Appearance250.BackColor = System.Drawing.Color.White
        Appearance250.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion6.ContentAreaAppearance = Appearance250
        Me.Agrupacion6.Controls.Add(Me.opPagoCont)
        Me.Agrupacion6.Controls.Add(Me.verCargar)
        Me.Agrupacion6.Controls.Add(Me.verDescarga)
        Me.Agrupacion6.Controls.Add(Me.verPagoContraEntrega)
        Me.Agrupacion6.Controls.Add(Me.verFacturado)
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion6.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.Agrupacion6.Location = New System.Drawing.Point(780, 1)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(149, 125)
        Me.Agrupacion6.TabIndex = 11
        Me.Agrupacion6.Text = "Incluye Pagos "
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'opPagoCont
        '
        Appearance251.ForeColor = System.Drawing.Color.Navy
        Me.opPagoCont.Appearance = Appearance251
        Me.opPagoCont.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opPagoCont.CheckedIndex = 0
        Me.opPagoCont.Enabled = False
        Me.opPagoCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opPagoCont.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem3.DataValue = "Default Item"
        ValueListItem3.DisplayText = "Efectivo"
        ValueListItem4.DataValue = "ValueListItem1"
        ValueListItem4.DisplayText = "Deposito"
        Me.opPagoCont.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
        Me.opPagoCont.Location = New System.Drawing.Point(25, 90)
        Me.opPagoCont.Name = "opPagoCont"
        Me.opPagoCont.Size = New System.Drawing.Size(72, 29)
        Me.opPagoCont.TabIndex = 5
        Me.opPagoCont.Text = "Efectivo"
        '
        'verCargar
        '
        Appearance252.ForeColor = System.Drawing.Color.Navy
        Me.verCargar.Appearance = Appearance252
        Me.verCargar.AutoSize = True
        Me.verCargar.Location = New System.Drawing.Point(7, 35)
        Me.verCargar.Name = "verCargar"
        Me.verCargar.Size = New System.Drawing.Size(56, 17)
        Me.verCargar.TabIndex = 2
        Me.verCargar.Text = "Cargar"
        '
        'verDescarga
        '
        Appearance253.ForeColor = System.Drawing.Color.Navy
        Me.verDescarga.Appearance = Appearance253
        Me.verDescarga.AutoSize = True
        Me.verDescarga.Location = New System.Drawing.Point(7, 53)
        Me.verDescarga.Name = "verDescarga"
        Me.verDescarga.Size = New System.Drawing.Size(70, 17)
        Me.verDescarga.TabIndex = 3
        Me.verDescarga.Text = "Descarga"
        '
        'verPagoContraEntrega
        '
        Appearance254.ForeColor = System.Drawing.Color.Navy
        Me.verPagoContraEntrega.Appearance = Appearance254
        Me.verPagoContraEntrega.AutoSize = True
        Me.verPagoContraEntrega.Location = New System.Drawing.Point(7, 71)
        Me.verPagoContraEntrega.Name = "verPagoContraEntrega"
        Me.verPagoContraEntrega.Size = New System.Drawing.Size(105, 17)
        Me.verPagoContraEntrega.TabIndex = 4
        Me.verPagoContraEntrega.Text = "Pago Contra Ent"
        '
        'verFacturado
        '
        Appearance255.ForeColor = System.Drawing.Color.Navy
        Me.verFacturado.Appearance = Appearance255
        Me.verFacturado.AutoSize = True
        Me.verFacturado.Location = New System.Drawing.Point(7, 18)
        Me.verFacturado.Name = "verFacturado"
        Me.verFacturado.Size = New System.Drawing.Size(72, 17)
        Me.verFacturado.TabIndex = 1
        Me.verFacturado.Text = "Facturado"
        '
        'UltraLabel14
        '
        Appearance256.BackColor = System.Drawing.Color.Transparent
        Appearance256.ForeColor = System.Drawing.Color.Navy
        Appearance256.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance256
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(27, 149)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel14.TabIndex = 8
        Me.UltraLabel14.Text = "Material:"
        '
        'txtCantidad
        '
        Appearance257.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance257.TextHAlignAsString = "Right"
        Me.txtCantidad.Appearance = Appearance257
        Me.txtCantidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCantidad.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCantidad.InputMask = "{double:5.3}"
        Me.txtCantidad.Location = New System.Drawing.Point(304, 123)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.NonAutoSizeHeight = 20
        Me.txtCantidad.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCantidad.Size = New System.Drawing.Size(60, 20)
        Me.txtCantidad.TabIndex = 7
        Me.txtCantidad.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtCantidad.Text = "1.000"
        '
        'UltraLabel17
        '
        Appearance258.BackColor = System.Drawing.Color.Transparent
        Appearance258.ForeColor = System.Drawing.Color.Navy
        Appearance258.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance258
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(34, 6)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel17.TabIndex = 0
        Me.UltraLabel17.Text = "Cliente:"
        '
        'btnAgregar
        '
        Appearance259.Image = "add.ico"
        Me.btnAgregar.Appearance = Appearance259
        Me.btnAgregar.ImageList = Me.imagenes
        Me.btnAgregar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAgregar.Location = New System.Drawing.Point(780, 131)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(35, 35)
        Me.btnAgregar.TabIndex = 12
        '
        'UltraLabel12
        '
        Appearance260.BackColor = System.Drawing.Color.Transparent
        Appearance260.ForeColor = System.Drawing.Color.Navy
        Appearance260.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance260
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(251, 128)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel12.TabIndex = 6
        Me.UltraLabel12.Text = "Cantidad:"
        '
        'UltraLabel15
        '
        Appearance261.BackColor = System.Drawing.Color.Transparent
        Appearance261.ForeColor = System.Drawing.Color.Navy
        Appearance261.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance261
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(14, 126)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel15.TabIndex = 4
        Me.UltraLabel15.Text = "Tipo Carga:"
        '
        'cboMaterial
        '
        Me.cboMaterial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMaterial.DisplayMember = "Nombre"
        Me.cboMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMaterial.Location = New System.Drawing.Point(79, 145)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(285, 21)
        Me.cboMaterial.TabIndex = 8
        Me.cboMaterial.ValueMember = "Id"
        '
        'cboTipoCarga
        '
        Me.cboTipoCarga.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoCarga.DisplayMember = "Nombre"
        Me.cboTipoCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoCarga.Location = New System.Drawing.Point(79, 122)
        Me.cboTipoCarga.Name = "cboTipoCarga"
        Me.cboTipoCarga.Size = New System.Drawing.Size(165, 21)
        Me.cboTipoCarga.TabIndex = 6
        Me.cboTipoCarga.ValueMember = "Id"
        '
        'cboComisionista
        '
        Me.cboComisionista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance262.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton9.Appearance = Appearance262
        EditorButton9.Key = "btnEditarComisionista"
        EditorButton9.Text = ""
        Appearance263.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton10.Appearance = Appearance263
        EditorButton10.Key = "btnNuevoComisionista"
        EditorButton10.Visible = False
        Me.cboComisionista.ButtonsRight.Add(EditorButton9)
        Me.cboComisionista.ButtonsRight.Add(EditorButton10)
        Me.cboComisionista.DisplayMember = "Nombre"
        Me.cboComisionista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboComisionista.Location = New System.Drawing.Point(79, 74)
        Me.cboComisionista.Name = "cboComisionista"
        Me.cboComisionista.Size = New System.Drawing.Size(285, 21)
        Me.cboComisionista.TabIndex = 4
        Me.cboComisionista.ValueMember = "Id"
        '
        'cboCliente
        '
        Me.cboCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCliente.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Appearance264.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton11.Appearance = Appearance264
        EditorButton11.Key = "btnEditarCliente"
        Appearance265.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton12.Appearance = Appearance265
        EditorButton12.Key = "btnNuevoCliente"
        EditorButton12.Visible = False
        Me.cboCliente.ButtonsRight.Add(EditorButton11)
        Me.cboCliente.ButtonsRight.Add(EditorButton12)
        Me.cboCliente.DisplayMember = "Nombre"
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.Location = New System.Drawing.Point(79, 2)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(285, 21)
        Me.cboCliente.TabIndex = 1
        Me.cboCliente.ValueMember = "Id"
        '
        'lblClienteFinal
        '
        Appearance266.BackColor = System.Drawing.Color.Transparent
        Appearance266.ForeColor = System.Drawing.Color.Navy
        Appearance266.TextVAlignAsString = "Middle"
        Me.lblClienteFinal.Appearance = Appearance266
        Me.lblClienteFinal.AutoSize = True
        Me.lblClienteFinal.Location = New System.Drawing.Point(7, 51)
        Me.lblClienteFinal.Name = "lblClienteFinal"
        Me.lblClienteFinal.Size = New System.Drawing.Size(68, 14)
        Me.lblClienteFinal.TabIndex = 48
        Me.lblClienteFinal.Text = "Cliente Final:"
        '
        'UltraGroupBox10
        '
        Appearance267.BackColor = System.Drawing.Color.White
        Appearance267.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox10.ContentAreaAppearance = Appearance267
        Me.UltraGroupBox10.Controls.Add(Me.txtMotivoConsolidado)
        Me.UltraGroupBox10.Controls.Add(Me.txtCostoEstibaDescarga)
        Me.UltraGroupBox10.Controls.Add(Me.chkConsolidado)
        Me.UltraGroupBox10.Controls.Add(Me.txtConsolidado)
        Me.UltraGroupBox10.Controls.Add(Me.chkCostoEstivaDescarga)
        Me.UltraGroupBox10.Controls.Add(Me.chkIGVConsolidado)
        Me.UltraGroupBox10.Controls.Add(Me.txtComision)
        Me.UltraGroupBox10.Controls.Add(Me.chkCostoEstiva)
        Me.UltraGroupBox10.Controls.Add(Me.txtCostoEstiba)
        Me.UltraGroupBox10.Controls.Add(Me.UltraLabel19)
        Me.UltraGroupBox10.Location = New System.Drawing.Point(597, 0)
        Me.UltraGroupBox10.Name = "UltraGroupBox10"
        Me.UltraGroupBox10.Size = New System.Drawing.Size(180, 166)
        Me.UltraGroupBox10.TabIndex = 10
        Me.UltraGroupBox10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtMotivoConsolidado
        '
        Me.txtMotivoConsolidado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMotivoConsolidado.Enabled = False
        Me.txtMotivoConsolidado.Location = New System.Drawing.Point(13, 93)
        Me.txtMotivoConsolidado.MaxLength = 500
        Me.txtMotivoConsolidado.Multiline = True
        Me.txtMotivoConsolidado.Name = "txtMotivoConsolidado"
        Me.txtMotivoConsolidado.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoConsolidado.Size = New System.Drawing.Size(162, 47)
        Me.txtMotivoConsolidado.TabIndex = 8
        UltraToolTipInfo11.ToolTipText = "Comentario de Consolidado"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtMotivoConsolidado, UltraToolTipInfo11)
        '
        'txtCostoEstibaDescarga
        '
        Me.txtCostoEstibaDescarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCostoEstibaDescarga.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCostoEstibaDescarga.Enabled = False
        Me.txtCostoEstibaDescarga.InputMask = "{double:15.2}"
        Me.txtCostoEstibaDescarga.Location = New System.Drawing.Point(99, 48)
        Me.txtCostoEstibaDescarga.Name = "txtCostoEstibaDescarga"
        Me.txtCostoEstibaDescarga.NonAutoSizeHeight = 20
        Me.txtCostoEstibaDescarga.Size = New System.Drawing.Size(75, 20)
        Me.txtCostoEstibaDescarga.TabIndex = 5
        Me.txtCostoEstibaDescarga.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtCostoEstibaDescarga.Text = "0.00"
        '
        'chkConsolidado
        '
        Appearance268.ForeColor = System.Drawing.Color.Navy
        Me.chkConsolidado.Appearance = Appearance268
        Me.chkConsolidado.AutoSize = True
        Me.chkConsolidado.Location = New System.Drawing.Point(12, 72)
        Me.chkConsolidado.Name = "chkConsolidado"
        Me.chkConsolidado.Size = New System.Drawing.Size(87, 17)
        Me.chkConsolidado.TabIndex = 6
        Me.chkConsolidado.Text = "Consolidado:"
        '
        'txtConsolidado
        '
        Me.txtConsolidado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtConsolidado.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtConsolidado.InputMask = "{double:15.2}"
        Me.txtConsolidado.Location = New System.Drawing.Point(99, 71)
        Me.txtConsolidado.Name = "txtConsolidado"
        Me.txtConsolidado.NonAutoSizeHeight = 20
        Me.txtConsolidado.Size = New System.Drawing.Size(76, 20)
        Me.txtConsolidado.TabIndex = 7
        Me.txtConsolidado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtConsolidado.Text = "0.00"
        '
        'chkCostoEstivaDescarga
        '
        Appearance269.ForeColor = System.Drawing.Color.Navy
        Me.chkCostoEstivaDescarga.Appearance = Appearance269
        Me.chkCostoEstivaDescarga.AutoSize = True
        Me.chkCostoEstivaDescarga.Location = New System.Drawing.Point(5, 48)
        Me.chkCostoEstivaDescarga.Name = "chkCostoEstivaDescarga"
        Me.chkCostoEstivaDescarga.Size = New System.Drawing.Size(93, 17)
        Me.chkCostoEstivaDescarga.TabIndex = 4
        Me.chkCostoEstivaDescarga.Text = "C.EstibaDesc:"
        '
        'chkIGVConsolidado
        '
        Appearance270.ForeColor = System.Drawing.Color.Navy
        Me.chkIGVConsolidado.Appearance = Appearance270
        Me.chkIGVConsolidado.AutoSize = True
        Me.chkIGVConsolidado.Location = New System.Drawing.Point(14, 142)
        Me.chkIGVConsolidado.Name = "chkIGVConsolidado"
        Me.chkIGVConsolidado.Size = New System.Drawing.Size(146, 17)
        Me.chkIGVConsolidado.TabIndex = 9
        Me.chkIGVConsolidado.Text = "Incluye IGV Consolidado"
        '
        'txtComision
        '
        Appearance271.TextHAlignAsString = "Right"
        Me.txtComision.Appearance = Appearance271
        Me.txtComision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtComision.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtComision.InputMask = "{double:4.2}"
        Me.txtComision.Location = New System.Drawing.Point(100, 4)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.NonAutoSizeHeight = 20
        Me.txtComision.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtComision.Size = New System.Drawing.Size(75, 20)
        Me.txtComision.TabIndex = 1
        Me.txtComision.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtComision.Text = "0.00"
        '
        'chkCostoEstiva
        '
        Appearance272.ForeColor = System.Drawing.Color.Navy
        Me.chkCostoEstiva.Appearance = Appearance272
        Me.chkCostoEstiva.AutoSize = True
        Me.chkCostoEstiva.Location = New System.Drawing.Point(28, 26)
        Me.chkCostoEstiva.Name = "chkCostoEstiva"
        Me.chkCostoEstiva.Size = New System.Drawing.Size(70, 17)
        Me.chkCostoEstiva.TabIndex = 2
        Me.chkCostoEstiva.Text = "C. Estiba:"
        '
        'txtCostoEstiba
        '
        Me.txtCostoEstiba.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCostoEstiba.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCostoEstiba.Enabled = False
        Me.txtCostoEstiba.InputMask = "{double:15.2}"
        Me.txtCostoEstiba.Location = New System.Drawing.Point(100, 26)
        Me.txtCostoEstiba.Name = "txtCostoEstiba"
        Me.txtCostoEstiba.NonAutoSizeHeight = 20
        Me.txtCostoEstiba.Size = New System.Drawing.Size(75, 20)
        Me.txtCostoEstiba.TabIndex = 3
        Me.txtCostoEstiba.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.txtCostoEstiba.Text = "0.00"
        '
        'UltraLabel19
        '
        Appearance273.BackColor = System.Drawing.Color.Transparent
        Appearance273.ForeColor = System.Drawing.Color.Navy
        Appearance273.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance273
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(43, 6)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel19.TabIndex = 15
        Me.UltraLabel19.Text = "Comisión: "
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.griDetalleTercero)
        Me.UltraTabPageControl8.Controls.Add(Me.expContratoTercero)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1248, 387)
        '
        'griDetalleTercero
        '
        Me.griDetalleTercero.CalcManager = Me.Calcular1
        Me.griDetalleTercero.ContextMenuStrip = Me.MenuContratoTercero
        Me.griDetalleTercero.DataSource = Me.ogdDetalleTercero
        Appearance274.BackColor = System.Drawing.Color.White
        Me.griDetalleTercero.DisplayLayout.Appearance = Appearance274
        UltraGridColumn1133.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1133.Header.VisiblePosition = 0
        UltraGridColumn1133.Hidden = True
        UltraGridColumn1134.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1134.Header.VisiblePosition = 1
        UltraGridColumn1134.Hidden = True
        UltraGridColumn1135.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1135.Header.VisiblePosition = 2
        UltraGridColumn1135.Hidden = True
        UltraGridColumn1135.Width = 250
        UltraGridColumn1136.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1136.Header.Caption = "Tercero"
        UltraGridColumn1136.Header.VisiblePosition = 3
        UltraGridColumn1136.Width = 250
        UltraGridColumn1137.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1137.Header.Caption = "Contacto"
        UltraGridColumn1137.Header.VisiblePosition = 4
        UltraGridColumn1137.Width = 200
        UltraGridColumn1138.Header.Caption = "Moneda"
        UltraGridColumn1138.Header.VisiblePosition = 5
        UltraGridColumn1138.Width = 50
        Appearance275.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance275.TextHAlignAsString = "Right"
        UltraGridColumn1139.CellAppearance = Appearance275
        UltraGridColumn1139.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1139.Format = ""
        UltraGridColumn1139.Header.Caption = "F.Unitario"
        UltraGridColumn1139.Header.VisiblePosition = 8
        UltraGridColumn1139.MaskInput = "{double:9.4}"
        UltraGridColumn1139.Width = 75
        Appearance276.TextHAlignAsString = "Right"
        UltraGridColumn1140.CellAppearance = Appearance276
        UltraGridColumn1140.Format = ""
        UltraGridColumn1140.Header.VisiblePosition = 10
        UltraGridColumn1140.MaskInput = "{double:5.4}"
        UltraGridColumn1140.Width = 50
        UltraGridColumn1141.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance277.TextHAlignAsString = "Right"
        UltraGridColumn1141.CellAppearance = Appearance277
        UltraGridColumn1141.Format = ""
        UltraGridColumn1141.Header.VisiblePosition = 11
        UltraGridColumn1141.MaskInput = "{double:9.4}"
        UltraGridColumn1141.Width = 100
        UltraGridColumn1142.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance278.BackColor = System.Drawing.Color.PaleTurquoise
        Appearance278.TextHAlignAsString = "Right"
        UltraGridColumn1142.CellAppearance = Appearance278
        UltraGridColumn1142.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1142.Header.VisiblePosition = 12
        UltraGridColumn1142.Hidden = True
        UltraGridColumn1142.MaskInput = ""
        UltraGridColumn1142.Width = 60
        UltraGridColumn1143.Header.VisiblePosition = 13
        UltraGridColumn1143.Hidden = True
        UltraGridColumn1144.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance279.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance279.TextHAlignAsString = "Right"
        UltraGridColumn1144.CellAppearance = Appearance279
        UltraGridColumn1144.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1144.Format = ""
        UltraGridColumn1144.Header.VisiblePosition = 6
        UltraGridColumn1144.MaskInput = "{double:5.4}"
        UltraGridColumn1144.Width = 50
        UltraGridColumn1145.Header.VisiblePosition = 14
        UltraGridColumn1145.Hidden = True
        UltraGridColumn1146.Header.VisiblePosition = 16
        UltraGridColumn1146.Hidden = True
        UltraGridColumn1146.Width = 100
        UltraGridColumn1147.Header.VisiblePosition = 15
        UltraGridColumn1147.Hidden = True
        UltraGridColumn1147.Width = 28
        UltraGridColumn1148.Header.VisiblePosition = 17
        UltraGridColumn1148.Hidden = True
        UltraGridColumn1149.Header.VisiblePosition = 18
        UltraGridColumn1149.Hidden = True
        UltraGridColumn1150.Header.VisiblePosition = 19
        UltraGridColumn1150.Hidden = True
        UltraGridColumn1151.Header.VisiblePosition = 20
        UltraGridColumn1151.Hidden = True
        UltraGridColumn1152.Header.VisiblePosition = 21
        UltraGridColumn1152.Hidden = True
        UltraGridColumn1153.Header.VisiblePosition = 22
        UltraGridColumn1153.Hidden = True
        UltraGridColumn1154.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1154.Header.VisiblePosition = 26
        UltraGridColumn1154.Width = 300
        UltraGridColumn1155.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1155.Header.Caption = "Referencia Punto de Llegada"
        UltraGridColumn1155.Header.VisiblePosition = 23
        UltraGridColumn1155.Width = 300
        UltraGridColumn1156.Header.VisiblePosition = 24
        UltraGridColumn1156.Hidden = True
        UltraGridColumn1157.Header.VisiblePosition = 25
        UltraGridColumn1157.Hidden = True
        Appearance280.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance280.TextHAlignAsString = "Right"
        UltraGridColumn1158.CellAppearance = Appearance280
        UltraGridColumn1158.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1158.Header.VisiblePosition = 7
        UltraGridColumn1158.MaskInput = "{double:5.2}"
        UltraGridColumn1158.Width = 50
        Appearance281.TextHAlignAsString = "Right"
        UltraGridColumn1159.CellAppearance = Appearance281
        UltraGridColumn1159.Format = ""
        UltraGridColumn1159.Header.VisiblePosition = 9
        UltraGridColumn1159.MaskInput = "{double:9.4}"
        UltraGridColumn1159.Width = 75
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn1133, UltraGridColumn1134, UltraGridColumn1135, UltraGridColumn1136, UltraGridColumn1137, UltraGridColumn1138, UltraGridColumn1139, UltraGridColumn1140, UltraGridColumn1141, UltraGridColumn1142, UltraGridColumn1143, UltraGridColumn1144, UltraGridColumn1145, UltraGridColumn1146, UltraGridColumn1147, UltraGridColumn1148, UltraGridColumn1149, UltraGridColumn1150, UltraGridColumn1151, UltraGridColumn1152, UltraGridColumn1153, UltraGridColumn1154, UltraGridColumn1155, UltraGridColumn1156, UltraGridColumn1157, UltraGridColumn1158, UltraGridColumn1159})
        UltraGridBand10.SummaryFooterCaption = "Totales:"
        Me.griDetalleTercero.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.griDetalleTercero.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griDetalleTercero.DisplayLayout.GroupByBox.Hidden = True
        Me.griDetalleTercero.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleTercero.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalleTercero.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleTercero.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalleTercero.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleTercero.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleTercero.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance282.TextVAlignAsString = "Middle"
        Me.griDetalleTercero.DisplayLayout.Override.RowAppearance = Appearance282
        Me.griDetalleTercero.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griDetalleTercero.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleTercero.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griDetalleTercero.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griDetalleTercero.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalleTercero.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleTercero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleTercero.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleTercero.Location = New System.Drawing.Point(0, 146)
        Me.griDetalleTercero.Name = "griDetalleTercero"
        Me.griDetalleTercero.Size = New System.Drawing.Size(1248, 241)
        Me.griDetalleTercero.TabIndex = 19
        Me.griDetalleTercero.Tag = ""
        '
        'MenuContratoTercero
        '
        Me.MenuContratoTercero.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuContratoTercero.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetalleContratoTercero})
        Me.MenuContratoTercero.Name = "mnu_Transferencias"
        Me.MenuContratoTercero.Size = New System.Drawing.Size(153, 30)
        '
        'DetalleContratoTercero
        '
        Me.DetalleContratoTercero.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.DetalleContratoTercero.Name = "DetalleContratoTercero"
        Me.DetalleContratoTercero.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.DetalleContratoTercero.Size = New System.Drawing.Size(152, 26)
        Me.DetalleContratoTercero.Text = "Quitar"
        '
        'ogdDetalleTercero
        '
        UltraDataColumn259.DataType = GetType(Object)
        UltraDataColumn261.DataType = GetType(Double)
        UltraDataColumn261.DefaultValue = 0R
        UltraDataColumn262.DataType = GetType(Double)
        UltraDataColumn263.DataType = GetType(Double)
        UltraDataColumn263.DefaultValue = 0R
        UltraDataColumn264.DataType = GetType(Double)
        UltraDataColumn264.DefaultValue = 0R
        UltraDataColumn266.DataType = GetType(Double)
        UltraDataColumn266.DefaultValue = 0R
        UltraDataColumn269.DataType = GetType(Boolean)
        Me.ogdDetalleTercero.Band.Columns.AddRange(New Object() {UltraDataColumn255, UltraDataColumn256, UltraDataColumn257, UltraDataColumn258, UltraDataColumn259, UltraDataColumn260, UltraDataColumn261, UltraDataColumn262, UltraDataColumn263, UltraDataColumn264, UltraDataColumn265, UltraDataColumn266, UltraDataColumn267, UltraDataColumn268, UltraDataColumn269, UltraDataColumn270, UltraDataColumn271, UltraDataColumn272, UltraDataColumn273, UltraDataColumn274, UltraDataColumn275, UltraDataColumn276, UltraDataColumn277, UltraDataColumn278, UltraDataColumn279, UltraDataColumn280, UltraDataColumn281})
        '
        'expContratoTercero
        '
        Me.expContratoTercero.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance283.BackColor = System.Drawing.Color.White
        Appearance283.BackColor2 = System.Drawing.Color.White
        Me.expContratoTercero.ContentAreaAppearance = Appearance283
        Me.expContratoTercero.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.expContratoTercero.Dock = System.Windows.Forms.DockStyle.Top
        Me.expContratoTercero.ExpandedSize = New System.Drawing.Size(1248, 146)
        Me.expContratoTercero.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.expContratoTercero.Location = New System.Drawing.Point(0, 0)
        Me.expContratoTercero.Name = "expContratoTercero"
        Me.expContratoTercero.Size = New System.Drawing.Size(1248, 146)
        Me.expContratoTercero.TabIndex = 3
        Me.expContratoTercero.TabStop = False
        Me.expContratoTercero.Text = "Detalle"
        Me.expContratoTercero.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtTelefonoContacto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtApellidoMaternoContacto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtNombreContacto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtApellidoPaternoContacto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtRucContacto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtRucEmpresaTransportista)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboContacto)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboTercero)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.numSubTotalTercero)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel67)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtReferenciaTercero)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.txtObservacionTercero)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.numCantidadTercero)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel66)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.numFleteTotalTerc)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.numIgvTerc)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cboMonedaT)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.btnAgregarTerc)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel23)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel42)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.numFleteUnitarioTerc)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel43)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel44)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel61)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.numComisionTerc)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel63)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel64)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(1242, 123)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'txtTelefonoContacto
        '
        Me.txtTelefonoContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTelefonoContacto.Enabled = False
        Me.txtTelefonoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoContacto.Location = New System.Drawing.Point(433, 50)
        Me.txtTelefonoContacto.Name = "txtTelefonoContacto"
        Me.txtTelefonoContacto.Size = New System.Drawing.Size(106, 21)
        Me.txtTelefonoContacto.TabIndex = 8
        UltraToolTipInfo12.ToolTipText = "Telefono"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtTelefonoContacto, UltraToolTipInfo12)
        '
        'txtApellidoMaternoContacto
        '
        Me.txtApellidoMaternoContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoMaternoContacto.Enabled = False
        Me.txtApellidoMaternoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaternoContacto.Location = New System.Drawing.Point(203, 50)
        Me.txtApellidoMaternoContacto.Name = "txtApellidoMaternoContacto"
        Me.txtApellidoMaternoContacto.Size = New System.Drawing.Size(115, 21)
        Me.txtApellidoMaternoContacto.TabIndex = 6
        '
        'txtNombreContacto
        '
        Me.txtNombreContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombreContacto.Enabled = False
        Me.txtNombreContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreContacto.Location = New System.Drawing.Point(318, 50)
        Me.txtNombreContacto.Name = "txtNombreContacto"
        Me.txtNombreContacto.Size = New System.Drawing.Size(115, 21)
        Me.txtNombreContacto.TabIndex = 7
        '
        'txtApellidoPaternoContacto
        '
        Me.txtApellidoPaternoContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtApellidoPaternoContacto.Enabled = False
        Me.txtApellidoPaternoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaternoContacto.Location = New System.Drawing.Point(88, 50)
        Me.txtApellidoPaternoContacto.Name = "txtApellidoPaternoContacto"
        Me.txtApellidoPaternoContacto.Size = New System.Drawing.Size(115, 21)
        Me.txtApellidoPaternoContacto.TabIndex = 5
        '
        'txtRucContacto
        '
        Me.txtRucContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucContacto.Enabled = False
        Me.txtRucContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucContacto.Location = New System.Drawing.Point(433, 27)
        Me.txtRucContacto.Name = "txtRucContacto"
        Me.txtRucContacto.Size = New System.Drawing.Size(106, 21)
        Me.txtRucContacto.TabIndex = 4
        '
        'txtRucEmpresaTransportista
        '
        Me.txtRucEmpresaTransportista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRucEmpresaTransportista.Enabled = False
        Me.txtRucEmpresaTransportista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucEmpresaTransportista.Location = New System.Drawing.Point(433, 4)
        Me.txtRucEmpresaTransportista.Name = "txtRucEmpresaTransportista"
        Me.txtRucEmpresaTransportista.Size = New System.Drawing.Size(106, 21)
        Me.txtRucEmpresaTransportista.TabIndex = 2
        '
        'cboContacto
        '
        Me.cboContacto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboContacto.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Appearance284.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton13.Appearance = Appearance284
        EditorButton13.Key = "btnEditarCliente"
        Appearance285.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        EditorButton14.Appearance = Appearance285
        EditorButton14.Key = "btnNuevoCliente"
        EditorButton14.Visible = False
        Me.cboContacto.ButtonsRight.Add(EditorButton13)
        Me.cboContacto.ButtonsRight.Add(EditorButton14)
        Me.cboContacto.DisplayMember = "Nombre"
        Me.cboContacto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboContacto.Location = New System.Drawing.Point(88, 27)
        Me.cboContacto.Name = "cboContacto"
        Me.cboContacto.Size = New System.Drawing.Size(342, 21)
        Me.cboContacto.TabIndex = 3
        Me.cboContacto.ValueMember = "Id"
        '
        'cboTercero
        '
        Me.cboTercero.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTercero.DisplayMember = "Nombre"
        Me.cboTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTercero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTercero.Location = New System.Drawing.Point(88, 4)
        Me.cboTercero.Name = "cboTercero"
        Me.cboTercero.Size = New System.Drawing.Size(342, 21)
        Me.cboTercero.TabIndex = 1
        Me.cboTercero.ValueMember = "Id"
        '
        'numSubTotalTercero
        '
        Appearance286.TextHAlignAsString = "Right"
        Me.numSubTotalTercero.Appearance = Appearance286
        Me.numSubTotalTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numSubTotalTercero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numSubTotalTercero.InputMask = "{double:10.4}"
        Me.numSubTotalTercero.Location = New System.Drawing.Point(621, 24)
        Me.numSubTotalTercero.Name = "numSubTotalTercero"
        Me.numSubTotalTercero.NonAutoSizeHeight = 20
        Me.numSubTotalTercero.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numSubTotalTercero.ReadOnly = True
        Me.numSubTotalTercero.Size = New System.Drawing.Size(75, 20)
        Me.numSubTotalTercero.TabIndex = 14
        Me.numSubTotalTercero.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numSubTotalTercero.Text = "0.0000"
        '
        'UltraLabel67
        '
        Appearance287.BackColor = System.Drawing.Color.Transparent
        Appearance287.ForeColor = System.Drawing.Color.Navy
        Appearance287.TextVAlignAsString = "Middle"
        Me.UltraLabel67.Appearance = Appearance287
        Me.UltraLabel67.AutoSize = True
        Me.UltraLabel67.Location = New System.Drawing.Point(564, 27)
        Me.UltraLabel67.Name = "UltraLabel67"
        Me.UltraLabel67.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel67.TabIndex = 19
        Me.UltraLabel67.Text = "Sub Total: "
        '
        'txtReferenciaTercero
        '
        Me.txtReferenciaTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtReferenciaTercero.Location = New System.Drawing.Point(7, 74)
        Me.txtReferenciaTercero.Multiline = True
        Me.txtReferenciaTercero.Name = "txtReferenciaTercero"
        Me.txtReferenciaTercero.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReferenciaTercero.Size = New System.Drawing.Size(532, 22)
        Me.txtReferenciaTercero.TabIndex = 9
        UltraToolTipInfo13.ToolTipText = "Refencia del Punto de Llegada "
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtReferenciaTercero, UltraToolTipInfo13)
        '
        'txtObservacionTercero
        '
        Me.txtObservacionTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionTercero.Location = New System.Drawing.Point(702, 1)
        Me.txtObservacionTercero.Multiline = True
        Me.txtObservacionTercero.Name = "txtObservacionTercero"
        Me.txtObservacionTercero.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionTercero.Size = New System.Drawing.Size(150, 90)
        Me.txtObservacionTercero.TabIndex = 17
        UltraToolTipInfo14.ToolTipText = "Observaciones del Contrato de Terceros"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtObservacionTercero, UltraToolTipInfo14)
        '
        'numCantidadTercero
        '
        Appearance288.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance288.TextHAlignAsString = "Right"
        Me.numCantidadTercero.Appearance = Appearance288
        Me.numCantidadTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCantidadTercero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numCantidadTercero.InputMask = "{double:5.2}"
        Me.numCantidadTercero.Location = New System.Drawing.Point(381, 100)
        Me.numCantidadTercero.Name = "numCantidadTercero"
        Me.numCantidadTercero.NonAutoSizeHeight = 20
        Me.numCantidadTercero.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numCantidadTercero.Size = New System.Drawing.Size(50, 20)
        Me.numCantidadTercero.TabIndex = 12
        Me.numCantidadTercero.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numCantidadTercero.Text = "1.00"
        '
        'UltraLabel66
        '
        Appearance289.BackColor = System.Drawing.Color.Transparent
        Appearance289.ForeColor = System.Drawing.Color.Navy
        Appearance289.TextVAlignAsString = "Middle"
        Me.UltraLabel66.Appearance = Appearance289
        Me.UltraLabel66.AutoSize = True
        Me.UltraLabel66.Location = New System.Drawing.Point(327, 103)
        Me.UltraLabel66.Name = "UltraLabel66"
        Me.UltraLabel66.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel66.TabIndex = 15
        Me.UltraLabel66.Text = "Cantidad:"
        '
        'numFleteTotalTerc
        '
        Appearance290.TextHAlignAsString = "Right"
        Me.numFleteTotalTerc.Appearance = Appearance290
        Me.numFleteTotalTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numFleteTotalTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numFleteTotalTerc.InputMask = "{double:10.4}"
        Me.numFleteTotalTerc.Location = New System.Drawing.Point(621, 70)
        Me.numFleteTotalTerc.Name = "numFleteTotalTerc"
        Me.numFleteTotalTerc.NonAutoSizeHeight = 20
        Me.numFleteTotalTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numFleteTotalTerc.ReadOnly = True
        Me.numFleteTotalTerc.Size = New System.Drawing.Size(75, 20)
        Me.numFleteTotalTerc.TabIndex = 16
        Me.numFleteTotalTerc.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numFleteTotalTerc.Text = "0.0000"
        '
        'numIgvTerc
        '
        Appearance291.TextHAlignAsString = "Right"
        Me.numIgvTerc.Appearance = Appearance291
        Me.numIgvTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numIgvTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numIgvTerc.InputMask = "{double:10.4}"
        Me.numIgvTerc.Location = New System.Drawing.Point(621, 47)
        Me.numIgvTerc.Name = "numIgvTerc"
        Me.numIgvTerc.NonAutoSizeHeight = 20
        Me.numIgvTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numIgvTerc.ReadOnly = True
        Me.numIgvTerc.Size = New System.Drawing.Size(75, 20)
        Me.numIgvTerc.TabIndex = 15
        Me.numIgvTerc.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numIgvTerc.Text = "0.0000"
        '
        'cboMonedaT
        '
        Appearance292.ForeColor = System.Drawing.Color.Black
        Me.cboMonedaT.Appearance = Appearance292
        Me.cboMonedaT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMonedaT.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMonedaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonedaT.ForeColor = System.Drawing.Color.Black
        Me.cboMonedaT.Location = New System.Drawing.Point(81, 100)
        Me.cboMonedaT.Name = "cboMonedaT"
        Me.cboMonedaT.Size = New System.Drawing.Size(40, 21)
        Me.cboMonedaT.TabIndex = 10
        Me.cboMonedaT.ValueMember = "Id"
        '
        'btnAgregarTerc
        '
        Appearance293.Image = "add.ico"
        Me.btnAgregarTerc.Appearance = Appearance293
        Me.btnAgregarTerc.ImageList = Me.imagenes
        Me.btnAgregarTerc.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnAgregarTerc.Location = New System.Drawing.Point(858, 58)
        Me.btnAgregarTerc.Name = "btnAgregarTerc"
        Me.btnAgregarTerc.Size = New System.Drawing.Size(33, 33)
        Me.btnAgregarTerc.TabIndex = 18
        '
        'UltraLabel23
        '
        Appearance294.BackColor = System.Drawing.Color.Transparent
        Appearance294.ForeColor = System.Drawing.Color.Navy
        Appearance294.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance294
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(33, 104)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel23.TabIndex = 4
        Me.UltraLabel23.Text = "Moneda:"
        '
        'UltraLabel42
        '
        Appearance295.BackColor = System.Drawing.Color.Transparent
        Appearance295.ForeColor = System.Drawing.Color.Navy
        Appearance295.TextVAlignAsString = "Middle"
        Me.UltraLabel42.Appearance = Appearance295
        Me.UltraLabel42.AutoSize = True
        Me.UltraLabel42.Location = New System.Drawing.Point(559, 73)
        Me.UltraLabel42.Name = "UltraLabel42"
        Me.UltraLabel42.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel42.TabIndex = 12
        Me.UltraLabel42.Text = "Flete Total: "
        '
        'numFleteUnitarioTerc
        '
        Appearance296.TextHAlignAsString = "Right"
        Me.numFleteUnitarioTerc.Appearance = Appearance296
        Me.numFleteUnitarioTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numFleteUnitarioTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numFleteUnitarioTerc.InputMask = "{double:10.4}"
        Me.numFleteUnitarioTerc.Location = New System.Drawing.Point(621, 1)
        Me.numFleteUnitarioTerc.Name = "numFleteUnitarioTerc"
        Me.numFleteUnitarioTerc.NonAutoSizeHeight = 20
        Me.numFleteUnitarioTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numFleteUnitarioTerc.Size = New System.Drawing.Size(75, 20)
        Me.numFleteUnitarioTerc.TabIndex = 13
        Me.numFleteUnitarioTerc.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numFleteUnitarioTerc.Text = "0.0000"
        '
        'UltraLabel43
        '
        Appearance297.BackColor = System.Drawing.Color.Transparent
        Appearance297.ForeColor = System.Drawing.Color.Navy
        Appearance297.TextVAlignAsString = "Middle"
        Me.UltraLabel43.Appearance = Appearance297
        Me.UltraLabel43.AutoSize = True
        Me.UltraLabel43.Location = New System.Drawing.Point(2, 9)
        Me.UltraLabel43.Name = "UltraLabel43"
        Me.UltraLabel43.Size = New System.Drawing.Size(86, 14)
        Me.UltraLabel43.TabIndex = 0
        Me.UltraLabel43.Text = "Emp.Transporte:"
        '
        'UltraLabel44
        '
        Appearance298.BackColor = System.Drawing.Color.Transparent
        Appearance298.ForeColor = System.Drawing.Color.Navy
        Appearance298.TextVAlignAsString = "Middle"
        Me.UltraLabel44.Appearance = Appearance298
        Me.UltraLabel44.AutoSize = True
        Me.UltraLabel44.Location = New System.Drawing.Point(592, 50)
        Me.UltraLabel44.Name = "UltraLabel44"
        Me.UltraLabel44.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel44.TabIndex = 10
        Me.UltraLabel44.Text = "IGV:"
        '
        'UltraLabel61
        '
        Appearance299.BackColor = System.Drawing.Color.Transparent
        Appearance299.ForeColor = System.Drawing.Color.Navy
        Appearance299.TextVAlignAsString = "Middle"
        Me.UltraLabel61.Appearance = Appearance299
        Me.UltraLabel61.AutoSize = True
        Me.UltraLabel61.Location = New System.Drawing.Point(37, 32)
        Me.UltraLabel61.Name = "UltraLabel61"
        Me.UltraLabel61.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel61.TabIndex = 2
        Me.UltraLabel61.Text = "Contacto:"
        '
        'numComisionTerc
        '
        Appearance300.TextHAlignAsString = "Right"
        Me.numComisionTerc.Appearance = Appearance300
        Me.numComisionTerc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numComisionTerc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.numComisionTerc.InputMask = "{double:4.2}"
        Me.numComisionTerc.Location = New System.Drawing.Point(184, 100)
        Me.numComisionTerc.Name = "numComisionTerc"
        Me.numComisionTerc.NonAutoSizeHeight = 20
        Me.numComisionTerc.NullText = "0.00"
        Me.numComisionTerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numComisionTerc.Size = New System.Drawing.Size(50, 20)
        Me.numComisionTerc.TabIndex = 11
        Me.numComisionTerc.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numComisionTerc.Text = "0.00"
        '
        'UltraLabel63
        '
        Appearance301.BackColor = System.Drawing.Color.Transparent
        Appearance301.ForeColor = System.Drawing.Color.Navy
        Appearance301.TextVAlignAsString = "Middle"
        Me.UltraLabel63.Appearance = Appearance301
        Me.UltraLabel63.AutoSize = True
        Me.UltraLabel63.Location = New System.Drawing.Point(127, 103)
        Me.UltraLabel63.Name = "UltraLabel63"
        Me.UltraLabel63.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel63.TabIndex = 6
        Me.UltraLabel63.Text = "Comisión: "
        '
        'UltraLabel64
        '
        Appearance302.BackColor = System.Drawing.Color.Transparent
        Appearance302.ForeColor = System.Drawing.Color.Navy
        Appearance302.TextVAlignAsString = "Middle"
        Me.UltraLabel64.Appearance = Appearance302
        Me.UltraLabel64.AutoSize = True
        Me.UltraLabel64.Location = New System.Drawing.Point(545, 4)
        Me.UltraLabel64.Name = "UltraLabel64"
        Me.UltraLabel64.Size = New System.Drawing.Size(72, 14)
        Me.UltraLabel64.TabIndex = 8
        Me.UltraLabel64.Text = "Flete Unitario: "
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrListaRegistro)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1252, 710)
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.tabViajesLista)
        Me.agrListaRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaRegistro.Location = New System.Drawing.Point(0, 145)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(1252, 565)
        Me.agrListaRegistro.TabIndex = 1
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.Text = "Lista Registro"
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'tabViajesLista
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.White
        Me.tabViajesLista.ClientAreaAppearance = Appearance3
        Me.tabViajesLista.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.tabViajesLista.Controls.Add(Me.UltraTabPageControl9)
        Me.tabViajesLista.Controls.Add(Me.UltraTabPageControl10)
        Me.tabViajesLista.Controls.Add(Me.UltraTabPageControl16)
        Me.tabViajesLista.Controls.Add(Me.utpTrazabilidad)
        Me.tabViajesLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabViajesLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabViajesLista.Location = New System.Drawing.Point(3, 17)
        Me.tabViajesLista.Name = "tabViajesLista"
        Me.tabViajesLista.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.tabViajesLista.Size = New System.Drawing.Size(1246, 545)
        Me.tabViajesLista.TabIndex = 285
        UltraTab2.TabPage = Me.UltraTabPageControl9
        UltraTab2.Text = "Viajes"
        UltraTab3.TabPage = Me.UltraTabPageControl10
        UltraTab3.Text = "Viajes x Terceros"
        UltraTab3.Visible = False
        UltraTab5.TabPage = Me.UltraTabPageControl16
        UltraTab5.Text = "Desenganches"
        UltraTab1.TabPage = Me.utpTrazabilidad
        UltraTab1.Text = "Trazabilidad"
        Me.tabViajesLista.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab3, UltraTab5, UltraTab1})
        Me.tabViajesLista.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(1242, 522)
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.UltraExpandableGroupBox7)
        Me.agrBusqueda.Controls.Add(Me.UltraExpandableGroupBox4)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1252, 145)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Busqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBox7
        '
        Appearance96.BackColor = System.Drawing.Color.White
        Appearance96.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox7.ContentAreaAppearance = Appearance96
        Me.UltraExpandableGroupBox7.Controls.Add(Me.UltraExpandableGroupBoxPanel15)
        Me.UltraExpandableGroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox7.ExpandedSize = New System.Drawing.Size(896, 125)
        Me.UltraExpandableGroupBox7.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox7.Location = New System.Drawing.Point(353, 17)
        Me.UltraExpandableGroupBox7.Name = "UltraExpandableGroupBox7"
        Me.UltraExpandableGroupBox7.Size = New System.Drawing.Size(896, 125)
        Me.UltraExpandableGroupBox7.TabIndex = 1
        Me.UltraExpandableGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel15
        '
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.decProduccionSinIGV)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.decProduccionIGV)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.lblProduccionSinIGV)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.lblProduccionIGV)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.grupoEstado)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.grupoTipoVehiculo)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.CalculadoraGrilla)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.colorCambio)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.Etiqueta45)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.Etiqueta44)
        Me.UltraExpandableGroupBoxPanel15.Controls.Add(Me.colorCargaConsolidada)
        Me.UltraExpandableGroupBoxPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel15.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel15.Name = "UltraExpandableGroupBoxPanel15"
        Me.UltraExpandableGroupBoxPanel15.Size = New System.Drawing.Size(875, 119)
        Me.UltraExpandableGroupBoxPanel15.TabIndex = 0
        '
        'decProduccionSinIGV
        '
        Appearance97.FontData.BoldAsString = "True"
        Me.decProduccionSinIGV.Appearance = Appearance97
        Me.decProduccionSinIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decProduccionSinIGV.Location = New System.Drawing.Point(726, 79)
        Me.decProduccionSinIGV.MaskInput = "{double:-9.2}"
        Me.decProduccionSinIGV.Name = "decProduccionSinIGV"
        Me.decProduccionSinIGV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decProduccionSinIGV.ReadOnly = True
        Me.decProduccionSinIGV.Size = New System.Drawing.Size(113, 22)
        Me.decProduccionSinIGV.TabIndex = 12
        '
        'decProduccionIGV
        '
        Me.decProduccionIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decProduccionIGV.Location = New System.Drawing.Point(726, 30)
        Me.decProduccionIGV.MaskInput = "{double:-9.2}"
        Me.decProduccionIGV.Name = "decProduccionIGV"
        Me.decProduccionIGV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decProduccionIGV.ReadOnly = True
        Me.decProduccionIGV.Size = New System.Drawing.Size(113, 22)
        Me.decProduccionIGV.TabIndex = 11
        '
        'lblProduccionSinIGV
        '
        Appearance98.BackColor = System.Drawing.Color.Transparent
        Appearance98.ForeColor = System.Drawing.Color.Navy
        Me.lblProduccionSinIGV.Appearance = Appearance98
        Me.lblProduccionSinIGV.AutoSize = True
        Me.lblProduccionSinIGV.Location = New System.Drawing.Point(726, 58)
        Me.lblProduccionSinIGV.Name = "lblProduccionSinIGV"
        Me.lblProduccionSinIGV.Size = New System.Drawing.Size(105, 15)
        Me.lblProduccionSinIGV.TabIndex = 10
        Me.lblProduccionSinIGV.Text = "Produccion (Sin IGV)"
        '
        'lblProduccionIGV
        '
        Appearance99.BackColor = System.Drawing.Color.Transparent
        Appearance99.ForeColor = System.Drawing.Color.Navy
        Me.lblProduccionIGV.Appearance = Appearance99
        Me.lblProduccionIGV.AutoSize = True
        Me.lblProduccionIGV.Location = New System.Drawing.Point(726, 8)
        Me.lblProduccionIGV.Name = "lblProduccionIGV"
        Me.lblProduccionIGV.Size = New System.Drawing.Size(109, 15)
        Me.lblProduccionIGV.TabIndex = 9
        Me.lblProduccionIGV.Text = "Produccion (Con IGV)"
        '
        'grupoEstado
        '
        Appearance100.BackColor = System.Drawing.Color.White
        Appearance100.BackColor2 = System.Drawing.Color.White
        Me.grupoEstado.ContentAreaAppearance = Appearance100
        Me.grupoEstado.Controls.Add(Me.ColorFin)
        Me.grupoEstado.Controls.Add(Me.ColorProgramado)
        Me.grupoEstado.Controls.Add(Me.ColorCarga)
        Me.grupoEstado.Controls.Add(Me.Etiqueta6)
        Me.grupoEstado.Controls.Add(Me.Etiqueta5)
        Me.grupoEstado.Controls.Add(Me.ColorTransito)
        Me.grupoEstado.Controls.Add(Me.Etiqueta7)
        Me.grupoEstado.Controls.Add(Me.ColorDescarga)
        Me.grupoEstado.Controls.Add(Me.Etiqueta4)
        Me.grupoEstado.Controls.Add(Me.Etiqueta3)
        Me.grupoEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoEstado.Location = New System.Drawing.Point(0, 89)
        Me.grupoEstado.Name = "grupoEstado"
        Me.grupoEstado.Size = New System.Drawing.Size(570, 30)
        Me.grupoEstado.TabIndex = 2
        UltraToolTipInfo1.ToolTipText = "Estado de un Viaje"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.grupoEstado, UltraToolTipInfo1)
        Me.grupoEstado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorFin
        '
        Me.ColorFin.Color = System.Drawing.Color.LimeGreen
        Me.ColorFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFin.Location = New System.Drawing.Point(515, 5)
        Me.ColorFin.Name = "ColorFin"
        Me.ColorFin.Size = New System.Drawing.Size(43, 19)
        Me.ColorFin.TabIndex = 9
        Me.ColorFin.Text = "LimeGreen"
        '
        'ColorProgramado
        '
        Me.ColorProgramado.Color = System.Drawing.Color.White
        Me.ColorProgramado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorProgramado.Location = New System.Drawing.Point(87, 5)
        Me.ColorProgramado.Name = "ColorProgramado"
        Me.ColorProgramado.Size = New System.Drawing.Size(44, 19)
        Me.ColorProgramado.TabIndex = 1
        Me.ColorProgramado.Text = "White"
        '
        'ColorCarga
        '
        Me.ColorCarga.Color = System.Drawing.Color.Yellow
        Me.ColorCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCarga.Location = New System.Drawing.Point(201, 5)
        Me.ColorCarga.Name = "ColorCarga"
        Me.ColorCarga.Size = New System.Drawing.Size(44, 19)
        Me.ColorCarga.TabIndex = 3
        Me.ColorCarga.Text = "Yellow"
        '
        'Etiqueta6
        '
        Appearance101.BackColor = System.Drawing.Color.Transparent
        Appearance101.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance101
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(19, 7)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(68, 14)
        Me.Etiqueta6.TabIndex = 0
        Me.Etiqueta6.Text = "Programado:"
        '
        'Etiqueta5
        '
        Appearance102.BackColor = System.Drawing.Color.Transparent
        Appearance102.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance102
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(164, 7)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Carga:"
        '
        'ColorTransito
        '
        Me.ColorTransito.Color = System.Drawing.Color.DarkOrange
        Me.ColorTransito.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTransito.Location = New System.Drawing.Point(319, 5)
        Me.ColorTransito.Name = "ColorTransito"
        Me.ColorTransito.Size = New System.Drawing.Size(43, 19)
        Me.ColorTransito.TabIndex = 5
        Me.ColorTransito.Text = "DarkOrange"
        '
        'Etiqueta7
        '
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance103
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(492, 7)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(22, 14)
        Me.Etiqueta7.TabIndex = 8
        Me.Etiqueta7.Text = "Fin:"
        '
        'ColorDescarga
        '
        Me.ColorDescarga.Color = System.Drawing.Color.Silver
        Me.ColorDescarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorDescarga.Location = New System.Drawing.Point(428, 5)
        Me.ColorDescarga.Name = "ColorDescarga"
        Me.ColorDescarga.Size = New System.Drawing.Size(43, 19)
        Me.ColorDescarga.TabIndex = 7
        Me.ColorDescarga.Text = "Silver"
        '
        'Etiqueta4
        '
        Appearance104.BackColor = System.Drawing.Color.Transparent
        Appearance104.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance104
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(271, 7)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta4.TabIndex = 4
        Me.Etiqueta4.Text = "Transito:"
        '
        'Etiqueta3
        '
        Appearance105.BackColor = System.Drawing.Color.Transparent
        Appearance105.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance105
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(373, 7)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta3.TabIndex = 6
        Me.Etiqueta3.Text = "Descarga:"
        '
        'grupoTipoVehiculo
        '
        Appearance106.BackColor = System.Drawing.Color.White
        Appearance106.BackColor2 = System.Drawing.Color.White
        Me.grupoTipoVehiculo.ContentAreaAppearance = Appearance106
        Me.grupoTipoVehiculo.Controls.Add(Me.Colores6)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta47)
        Me.grupoTipoVehiculo.Controls.Add(Me.Colores7)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorParihuelero)
        Me.grupoTipoVehiculo.Controls.Add(Me.Colores8)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorPlataforma)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta48)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion20M3)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta49)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta29)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta50)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta28)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta51)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorTolvaVolteo)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta52)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta27)
        Me.grupoTipoVehiculo.Controls.Add(Me.Colores9)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta25)
        Me.grupoTipoVehiculo.Controls.Add(Me.Colores10)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion65M3)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorContenedor)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta222)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorGranelero)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorFurgon)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorFurgonLargo)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta24)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta30)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta21)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamioneta)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorVolquete)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta31)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta32)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta23)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion30M3)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta20)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta26)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCalicera)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorCamion40M3)
        Me.grupoTipoVehiculo.Controls.Add(Me.Etiqueta22)
        Me.grupoTipoVehiculo.Controls.Add(Me.ColorMediaBaranda)
        Me.grupoTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoTipoVehiculo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoTipoVehiculo.Location = New System.Drawing.Point(0, -1)
        Me.grupoTipoVehiculo.Name = "grupoTipoVehiculo"
        Me.grupoTipoVehiculo.Size = New System.Drawing.Size(570, 90)
        Me.grupoTipoVehiculo.TabIndex = 0
        UltraToolTipInfo2.ToolTipText = "Tipo Vehiculo (Modelo Funcional)"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.grupoTipoVehiculo, UltraToolTipInfo2)
        Me.grupoTipoVehiculo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Colores6
        '
        Me.Colores6.Color = System.Drawing.Color.RosyBrown
        Me.Colores6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores6.Location = New System.Drawing.Point(319, 67)
        Me.Colores6.Name = "Colores6"
        Me.Colores6.Size = New System.Drawing.Size(44, 19)
        Me.Colores6.TabIndex = 34
        Me.Colores6.Text = "RosyBrown"
        '
        'Etiqueta47
        '
        Appearance107.BackColor = System.Drawing.Color.Transparent
        Appearance107.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta47.Appearance = Appearance107
        Me.Etiqueta47.AutoSize = True
        Me.Etiqueta47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta47.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta47.Location = New System.Drawing.Point(253, 31)
        Me.Etiqueta47.Name = "Etiqueta47"
        Me.Etiqueta47.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta47.TabIndex = 14
        Me.Etiqueta47.Text = "Parihuelero:"
        '
        'Colores7
        '
        Me.Colores7.Color = System.Drawing.Color.MediumSpringGreen
        Me.Colores7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores7.Location = New System.Drawing.Point(427, 67)
        Me.Colores7.Name = "Colores7"
        Me.Colores7.Size = New System.Drawing.Size(44, 19)
        Me.Colores7.TabIndex = 36
        Me.Colores7.Text = "MediumSpringGreen"
        '
        'ColorParihuelero
        '
        Me.ColorParihuelero.Color = System.Drawing.Color.PaleGreen
        Me.ColorParihuelero.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorParihuelero.Location = New System.Drawing.Point(319, 27)
        Me.ColorParihuelero.Name = "ColorParihuelero"
        Me.ColorParihuelero.Size = New System.Drawing.Size(44, 19)
        Me.ColorParihuelero.TabIndex = 15
        Me.ColorParihuelero.Text = "PaleGreen"
        '
        'Colores8
        '
        Me.Colores8.Color = System.Drawing.Color.OliveDrab
        Me.Colores8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores8.Location = New System.Drawing.Point(201, 67)
        Me.Colores8.Name = "Colores8"
        Me.Colores8.Size = New System.Drawing.Size(44, 19)
        Me.Colores8.TabIndex = 32
        Me.Colores8.Text = "OliveDrab"
        '
        'ColorPlataforma
        '
        Me.ColorPlataforma.Color = System.Drawing.Color.Coral
        Me.ColorPlataforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPlataforma.Location = New System.Drawing.Point(88, 7)
        Me.ColorPlataforma.Name = "ColorPlataforma"
        Me.ColorPlataforma.Size = New System.Drawing.Size(44, 19)
        Me.ColorPlataforma.TabIndex = 1
        Me.ColorPlataforma.Text = "Coral"
        '
        'Etiqueta48
        '
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Appearance108.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta48.Appearance = Appearance108
        Me.Etiqueta48.AutoSize = True
        Me.Etiqueta48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta48.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta48.Location = New System.Drawing.Point(269, 70)
        Me.Etiqueta48.Name = "Etiqueta48"
        Me.Etiqueta48.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta48.TabIndex = 33
        Me.Etiqueta48.Text = "Nuevo 3:"
        '
        'ColorCamion20M3
        '
        Me.ColorCamion20M3.Color = System.Drawing.Color.PaleTurquoise
        Me.ColorCamion20M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion20M3.Location = New System.Drawing.Point(515, 7)
        Me.ColorCamion20M3.Name = "ColorCamion20M3"
        Me.ColorCamion20M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion20M3.TabIndex = 9
        Me.ColorCamion20M3.Text = "PaleTurquoise"
        '
        'Etiqueta49
        '
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta49.Appearance = Appearance109
        Me.Etiqueta49.AutoSize = True
        Me.Etiqueta49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta49.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta49.Location = New System.Drawing.Point(377, 71)
        Me.Etiqueta49.Name = "Etiqueta49"
        Me.Etiqueta49.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta49.TabIndex = 35
        Me.Etiqueta49.Text = "Nuevo 4:"
        '
        'Etiqueta29
        '
        Appearance110.BackColor = System.Drawing.Color.Transparent
        Appearance110.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance110
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta29.Location = New System.Drawing.Point(365, 31)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta29.TabIndex = 16
        Me.Etiqueta29.Text = "Camioneta:"
        '
        'Etiqueta50
        '
        Appearance111.BackColor = System.Drawing.Color.Transparent
        Appearance111.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta50.Appearance = Appearance111
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta50.Location = New System.Drawing.Point(37, 70)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta50.TabIndex = 29
        Me.Etiqueta50.Text = "Nuevo 1:"
        '
        'Etiqueta28
        '
        Appearance112.BackColor = System.Drawing.Color.Transparent
        Appearance112.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance112
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(156, 10)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta28.TabIndex = 2
        Me.Etiqueta28.Text = "Furgon:"
        '
        'Etiqueta51
        '
        Appearance113.BackColor = System.Drawing.Color.Transparent
        Appearance113.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta51.Appearance = Appearance113
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta51.Location = New System.Drawing.Point(475, 70)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta51.TabIndex = 37
        Me.Etiqueta51.Text = "50 M3:"
        '
        'ColorTolvaVolteo
        '
        Me.ColorTolvaVolteo.Color = System.Drawing.Color.RosyBrown
        Me.ColorTolvaVolteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTolvaVolteo.Location = New System.Drawing.Point(319, 47)
        Me.ColorTolvaVolteo.Name = "ColorTolvaVolteo"
        Me.ColorTolvaVolteo.Size = New System.Drawing.Size(44, 19)
        Me.ColorTolvaVolteo.TabIndex = 24
        Me.ColorTolvaVolteo.Text = "RosyBrown"
        '
        'Etiqueta52
        '
        Appearance114.BackColor = System.Drawing.Color.Transparent
        Appearance114.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta52.Appearance = Appearance114
        Me.Etiqueta52.AutoSize = True
        Me.Etiqueta52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta52.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta52.Location = New System.Drawing.Point(150, 70)
        Me.Etiqueta52.Name = "Etiqueta52"
        Me.Etiqueta52.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta52.TabIndex = 31
        Me.Etiqueta52.Text = "Nuevo 2:"
        '
        'Etiqueta27
        '
        Appearance115.BackColor = System.Drawing.Color.Transparent
        Appearance115.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance115
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(374, 10)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta27.TabIndex = 6
        Me.Etiqueta27.Text = "Volquete:"
        '
        'Colores9
        '
        Me.Colores9.Color = System.Drawing.Color.Violet
        Me.Colores9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores9.Location = New System.Drawing.Point(515, 67)
        Me.Colores9.Name = "Colores9"
        Me.Colores9.Size = New System.Drawing.Size(44, 19)
        Me.Colores9.TabIndex = 38
        Me.Colores9.Text = "Violet"
        '
        'Etiqueta25
        '
        Appearance116.BackColor = System.Drawing.Color.Transparent
        Appearance116.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta25.Appearance = Appearance116
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(260, 11)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta25.TabIndex = 4
        Me.Etiqueta25.Text = "Granelero:"
        '
        'Colores10
        '
        Me.Colores10.Color = System.Drawing.Color.Orange
        Me.Colores10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores10.Location = New System.Drawing.Point(88, 67)
        Me.Colores10.Name = "Colores10"
        Me.Colores10.Size = New System.Drawing.Size(44, 19)
        Me.Colores10.TabIndex = 30
        Me.Colores10.Text = "Orange"
        '
        'ColorCamion65M3
        '
        Me.ColorCamion65M3.Color = System.Drawing.Color.MediumSpringGreen
        Me.ColorCamion65M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion65M3.Location = New System.Drawing.Point(427, 47)
        Me.ColorCamion65M3.Name = "ColorCamion65M3"
        Me.ColorCamion65M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion65M3.TabIndex = 26
        Me.ColorCamion65M3.Text = "MediumSpringGreen"
        '
        'ColorContenedor
        '
        Me.ColorContenedor.Color = System.Drawing.Color.OliveDrab
        Me.ColorContenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorContenedor.Location = New System.Drawing.Point(201, 47)
        Me.ColorContenedor.Name = "ColorContenedor"
        Me.ColorContenedor.Size = New System.Drawing.Size(44, 19)
        Me.ColorContenedor.TabIndex = 22
        Me.ColorContenedor.Text = "OliveDrab"
        '
        'Etiqueta222
        '
        Appearance117.BackColor = System.Drawing.Color.Transparent
        Appearance117.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta222.Appearance = Appearance117
        Me.Etiqueta222.AutoSize = True
        Me.Etiqueta222.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta222.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta222.Location = New System.Drawing.Point(475, 10)
        Me.Etiqueta222.Name = "Etiqueta222"
        Me.Etiqueta222.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta222.TabIndex = 8
        Me.Etiqueta222.Text = "20 M3:"
        '
        'ColorGranelero
        '
        Me.ColorGranelero.Color = System.Drawing.Color.YellowGreen
        Me.ColorGranelero.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorGranelero.Location = New System.Drawing.Point(319, 7)
        Me.ColorGranelero.Name = "ColorGranelero"
        Me.ColorGranelero.Size = New System.Drawing.Size(44, 19)
        Me.ColorGranelero.TabIndex = 5
        Me.ColorGranelero.Text = "YellowGreen"
        '
        'ColorFurgon
        '
        Me.ColorFurgon.Color = System.Drawing.Color.Gold
        Me.ColorFurgon.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgon.Location = New System.Drawing.Point(201, 7)
        Me.ColorFurgon.Name = "ColorFurgon"
        Me.ColorFurgon.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgon.TabIndex = 3
        Me.ColorFurgon.Text = "Gold"
        '
        'ColorFurgonLargo
        '
        Me.ColorFurgonLargo.Color = System.Drawing.Color.PeachPuff
        Me.ColorFurgonLargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonLargo.Location = New System.Drawing.Point(88, 27)
        Me.ColorFurgonLargo.Name = "ColorFurgonLargo"
        Me.ColorFurgonLargo.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonLargo.TabIndex = 11
        Me.ColorFurgonLargo.Text = "PeachPuff"
        '
        'Etiqueta24
        '
        Appearance118.BackColor = System.Drawing.Color.Transparent
        Appearance118.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance118
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(26, 10)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta24.TabIndex = 0
        Me.Etiqueta24.Text = "Plataforma:"
        '
        'Etiqueta30
        '
        Appearance119.BackColor = System.Drawing.Color.Transparent
        Appearance119.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance119
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta30.Location = New System.Drawing.Point(248, 50)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta30.TabIndex = 23
        Me.Etiqueta30.Text = "Tolva Volteo:"
        '
        'Etiqueta21
        '
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Appearance120.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance120
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(388, 51)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta21.TabIndex = 25
        Me.Etiqueta21.Text = "65 M3:"
        '
        'ColorCamioneta
        '
        Me.ColorCamioneta.Color = System.Drawing.Color.LightSeaGreen
        Me.ColorCamioneta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamioneta.Location = New System.Drawing.Point(427, 27)
        Me.ColorCamioneta.Name = "ColorCamioneta"
        Me.ColorCamioneta.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamioneta.TabIndex = 17
        Me.ColorCamioneta.Text = "LightSeaGreen"
        '
        'ColorVolquete
        '
        Me.ColorVolquete.Color = System.Drawing.Color.Peru
        Me.ColorVolquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorVolquete.Location = New System.Drawing.Point(427, 7)
        Me.ColorVolquete.Name = "ColorVolquete"
        Me.ColorVolquete.Size = New System.Drawing.Size(44, 19)
        Me.ColorVolquete.TabIndex = 7
        Me.ColorVolquete.Text = "Peru"
        '
        'Etiqueta31
        '
        Appearance121.BackColor = System.Drawing.Color.Transparent
        Appearance121.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance121
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta31.Location = New System.Drawing.Point(13, 30)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta31.TabIndex = 10
        Me.Etiqueta31.Text = "Furgon Largo:"
        '
        'Etiqueta32
        '
        Appearance122.BackColor = System.Drawing.Color.Transparent
        Appearance122.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta32.Appearance = Appearance122
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta32.Location = New System.Drawing.Point(4, 50)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(84, 14)
        Me.Etiqueta32.TabIndex = 19
        Me.Etiqueta32.Text = "Media Baranda:"
        '
        'Etiqueta23
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance123
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(475, 50)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta23.TabIndex = 27
        Me.Etiqueta23.Text = "40 M3:"
        '
        'ColorCamion30M3
        '
        Me.ColorCamion30M3.Color = System.Drawing.Color.DeepSkyBlue
        Me.ColorCamion30M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion30M3.Location = New System.Drawing.Point(515, 27)
        Me.ColorCamion30M3.Name = "ColorCamion30M3"
        Me.ColorCamion30M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion30M3.TabIndex = 18
        Me.ColorCamion30M3.Text = "DeepSkyBlue"
        '
        'Etiqueta20
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta20.Appearance = Appearance124
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(134, 50)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta20.TabIndex = 21
        Me.Etiqueta20.Text = "Contenedor:"
        '
        'Etiqueta26
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance125
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(150, 31)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta26.TabIndex = 12
        Me.Etiqueta26.Text = "Calicera:"
        '
        'ColorCalicera
        '
        Me.ColorCalicera.Color = System.Drawing.Color.DarkKhaki
        Me.ColorCalicera.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCalicera.Location = New System.Drawing.Point(201, 27)
        Me.ColorCalicera.Name = "ColorCalicera"
        Me.ColorCalicera.Size = New System.Drawing.Size(44, 19)
        Me.ColorCalicera.TabIndex = 13
        Me.ColorCalicera.Text = "DarkKhaki"
        '
        'ColorCamion40M3
        '
        Me.ColorCamion40M3.Color = System.Drawing.Color.Violet
        Me.ColorCamion40M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion40M3.Location = New System.Drawing.Point(515, 47)
        Me.ColorCamion40M3.Name = "ColorCamion40M3"
        Me.ColorCamion40M3.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion40M3.TabIndex = 28
        Me.ColorCamion40M3.Text = "Violet"
        '
        'Etiqueta22
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta22.Appearance = Appearance126
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(475, 31)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta22.TabIndex = 62
        Me.Etiqueta22.Text = "30 M3:"
        '
        'ColorMediaBaranda
        '
        Me.ColorMediaBaranda.Color = System.Drawing.Color.Orange
        Me.ColorMediaBaranda.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorMediaBaranda.Location = New System.Drawing.Point(88, 47)
        Me.ColorMediaBaranda.Name = "ColorMediaBaranda"
        Me.ColorMediaBaranda.Size = New System.Drawing.Size(44, 19)
        Me.ColorMediaBaranda.TabIndex = 20
        Me.ColorMediaBaranda.Text = "Orange"
        '
        'CalculadoraGrilla
        '
        Appearance127.TextHAlignAsString = "Right"
        Me.CalculadoraGrilla.Appearance = Appearance127
        CalculatorButton1.Key = "."
        CalculatorButton1.KeyCodeAlternateValue = 190
        CalculatorButton1.KeyCodeValue = 110
        CalculatorButton1.Text = ","
        Me.CalculadoraGrilla.Buttons.AddRange(New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton() {CalculatorButton1})
        Me.CalculadoraGrilla.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CalculadoraGrilla.Location = New System.Drawing.Point(593, 4)
        Me.CalculadoraGrilla.MaxLength = 15
        Me.CalculadoraGrilla.Name = "CalculadoraGrilla"
        Me.CalculadoraGrilla.NullText = "0.00"
        Me.CalculadoraGrilla.Size = New System.Drawing.Size(100, 22)
        Me.CalculadoraGrilla.TabIndex = 1
        Me.CalculadoraGrilla.Text = "0.00"
        '
        'colorCambio
        '
        Me.colorCambio.Color = System.Drawing.Color.Cyan
        Me.colorCambio.Location = New System.Drawing.Point(593, 95)
        Me.colorCambio.Name = "colorCambio"
        Me.colorCambio.Size = New System.Drawing.Size(44, 22)
        Me.colorCambio.TabIndex = 8
        Me.colorCambio.Text = "Cyan"
        '
        'Etiqueta45
        '
        Appearance128.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta45.Appearance = Appearance128
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(593, 80)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta45.TabIndex = 7
        Me.Etiqueta45.Text = "Actualizado:"
        '
        'Etiqueta44
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta44.Appearance = Appearance129
        Me.Etiqueta44.AutoSize = True
        Me.Etiqueta44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta44.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta44.Location = New System.Drawing.Point(589, 33)
        Me.Etiqueta44.Name = "Etiqueta44"
        Me.Etiqueta44.Size = New System.Drawing.Size(105, 14)
        Me.Etiqueta44.TabIndex = 3
        Me.Etiqueta44.Text = "Carga Consolidada"
        '
        'colorCargaConsolidada
        '
        Me.colorCargaConsolidada.Color = System.Drawing.Color.SaddleBrown
        Me.colorCargaConsolidada.Location = New System.Drawing.Point(593, 48)
        Me.colorCargaConsolidada.Name = "colorCargaConsolidada"
        Me.colorCargaConsolidada.Size = New System.Drawing.Size(44, 22)
        Me.colorCargaConsolidada.TabIndex = 4
        Me.colorCargaConsolidada.Text = "SaddleBrown"
        '
        'UltraExpandableGroupBox4
        '
        Appearance130.BackColor = System.Drawing.Color.White
        Appearance130.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox4.ContentAreaAppearance = Appearance130
        Me.UltraExpandableGroupBox4.Controls.Add(Me.UltraExpandableGroupBoxPanel12)
        Me.UltraExpandableGroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox4.ExpandedSize = New System.Drawing.Size(350, 125)
        Me.UltraExpandableGroupBox4.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox4.Location = New System.Drawing.Point(3, 17)
        Me.UltraExpandableGroupBox4.Name = "UltraExpandableGroupBox4"
        Me.UltraExpandableGroupBox4.Size = New System.Drawing.Size(350, 125)
        Me.UltraExpandableGroupBox4.TabIndex = 0
        Me.UltraExpandableGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel12
        '
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.verPilotoLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboPilotoLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.verCarretaLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboCarretaLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraGroupBox13)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.verTracto)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboTractoLista)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboCentro)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraLabel20)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboUsuario)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraLabel62)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.cboZona)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraLabel16)
        Me.UltraExpandableGroupBoxPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel12.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel12.Name = "UltraExpandableGroupBoxPanel12"
        Me.UltraExpandableGroupBoxPanel12.Size = New System.Drawing.Size(329, 119)
        Me.UltraExpandableGroupBoxPanel12.TabIndex = 0
        '
        'verPilotoLista
        '
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Me.verPilotoLista.Appearance = Appearance131
        Me.verPilotoLista.AutoSize = True
        Me.verPilotoLista.Location = New System.Drawing.Point(2, 98)
        Me.verPilotoLista.Name = "verPilotoLista"
        Me.verPilotoLista.Size = New System.Drawing.Size(53, 18)
        Me.verPilotoLista.TabIndex = 16
        Me.verPilotoLista.Text = "Piloto:"
        '
        'cboPilotoLista
        '
        Appearance132.ForeColor = System.Drawing.Color.Black
        Me.cboPilotoLista.Appearance = Appearance132
        Me.cboPilotoLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboPilotoLista.DisplayMember = "Nombre"
        Me.cboPilotoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPilotoLista.Enabled = False
        Me.cboPilotoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPilotoLista.ForeColor = System.Drawing.Color.Black
        Me.cboPilotoLista.ImageList = Me.imagenes
        Me.cboPilotoLista.Location = New System.Drawing.Point(58, 97)
        Me.cboPilotoLista.Name = "cboPilotoLista"
        Me.cboPilotoLista.Size = New System.Drawing.Size(270, 21)
        Me.cboPilotoLista.TabIndex = 15
        Me.cboPilotoLista.ValueMember = "Id"
        '
        'verCarretaLista
        '
        Appearance133.ForeColor = System.Drawing.Color.Navy
        Me.verCarretaLista.Appearance = Appearance133
        Me.verCarretaLista.AutoSize = True
        Me.verCarretaLista.Location = New System.Drawing.Point(166, 75)
        Me.verCarretaLista.Name = "verCarretaLista"
        Me.verCarretaLista.Size = New System.Drawing.Size(62, 18)
        Me.verCarretaLista.TabIndex = 11
        Me.verCarretaLista.Text = "Carreta:"
        '
        'cboCarretaLista
        '
        Appearance134.ForeColor = System.Drawing.Color.Black
        Me.cboCarretaLista.Appearance = Appearance134
        Me.cboCarretaLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCarretaLista.DisplayMember = ""
        Me.cboCarretaLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCarretaLista.Enabled = False
        Me.cboCarretaLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarretaLista.ForeColor = System.Drawing.Color.Black
        Me.cboCarretaLista.Location = New System.Drawing.Point(228, 74)
        Me.cboCarretaLista.Name = "cboCarretaLista"
        Me.cboCarretaLista.Size = New System.Drawing.Size(85, 21)
        Me.cboCarretaLista.TabIndex = 12
        Me.cboCarretaLista.ValueMember = "Id"
        '
        'UltraGroupBox13
        '
        Me.UltraGroupBox13.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox13.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel39)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel41)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(3, 6)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(150, 60)
        Me.UltraGroupBox13.TabIndex = 0
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(50, 34)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(90, 20)
        Me.fecHasta.TabIndex = 17
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(50, 9)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(90, 20)
        Me.fecDesde.TabIndex = 0
        '
        'UltraLabel39
        '
        Appearance135.BackColor = System.Drawing.Color.Transparent
        Appearance135.ForeColor = System.Drawing.Color.Navy
        Appearance135.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance135
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel39.Location = New System.Drawing.Point(9, 36)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel39.TabIndex = 2
        Me.UltraLabel39.Text = "Hasta:"
        '
        'UltraLabel41
        '
        Appearance136.BackColor = System.Drawing.Color.Transparent
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Appearance136.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance136
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel41.Location = New System.Drawing.Point(6, 13)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel41.TabIndex = 0
        Me.UltraLabel41.Text = "Desde:"
        '
        'verTracto
        '
        Appearance137.ForeColor = System.Drawing.Color.Navy
        Me.verTracto.Appearance = Appearance137
        Me.verTracto.AutoSize = True
        Me.verTracto.Location = New System.Drawing.Point(2, 75)
        Me.verTracto.Name = "verTracto"
        Me.verTracto.Size = New System.Drawing.Size(56, 18)
        Me.verTracto.TabIndex = 9
        Me.verTracto.Text = "Tracto:"
        '
        'cboTractoLista
        '
        Appearance138.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Appearance = Appearance138
        Me.cboTractoLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTractoLista.DisplayMember = ""
        Me.cboTractoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTractoLista.Enabled = False
        Me.cboTractoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTractoLista.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Location = New System.Drawing.Point(58, 74)
        Me.cboTractoLista.Name = "cboTractoLista"
        Me.cboTractoLista.Size = New System.Drawing.Size(85, 21)
        Me.cboTractoLista.TabIndex = 10
        Me.cboTractoLista.ValueMember = "Id"
        '
        'cboCentro
        '
        Appearance139.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance139
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(228, 26)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(100, 21)
        Me.cboCentro.TabIndex = 4
        Me.cboCentro.ValueMember = "Id"
        '
        'UltraLabel20
        '
        Appearance140.BackColor = System.Drawing.Color.Transparent
        Appearance140.ForeColor = System.Drawing.Color.Navy
        Appearance140.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance140
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(182, 30)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel20.TabIndex = 3
        Me.UltraLabel20.Text = "Centro:"
        '
        'cboUsuario
        '
        Appearance141.ForeColor = System.Drawing.Color.Black
        Me.cboUsuario.Appearance = Appearance141
        Me.cboUsuario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboUsuario.DisplayMember = "Login"
        Me.cboUsuario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboUsuario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsuario.ForeColor = System.Drawing.Color.Black
        Me.cboUsuario.Location = New System.Drawing.Point(228, 3)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(100, 21)
        Me.cboUsuario.TabIndex = 2
        Me.cboUsuario.ValueMember = "Id"
        '
        'UltraLabel62
        '
        Appearance142.BackColor = System.Drawing.Color.Transparent
        Appearance142.ForeColor = System.Drawing.Color.Navy
        Appearance142.TextVAlignAsString = "Middle"
        Me.UltraLabel62.Appearance = Appearance142
        Me.UltraLabel62.AutoSize = True
        Me.UltraLabel62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel62.Location = New System.Drawing.Point(177, 7)
        Me.UltraLabel62.Name = "UltraLabel62"
        Me.UltraLabel62.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel62.TabIndex = 1
        Me.UltraLabel62.Text = "Usuario:"
        '
        'cboZona
        '
        Appearance143.ForeColor = System.Drawing.Color.Black
        Me.cboZona.Appearance = Appearance143
        Me.cboZona.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboZona.DisplayMember = "Nombre"
        Me.cboZona.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboZona.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZona.ForeColor = System.Drawing.Color.Black
        Me.cboZona.Location = New System.Drawing.Point(228, 49)
        Me.cboZona.Name = "cboZona"
        Me.cboZona.Size = New System.Drawing.Size(100, 21)
        Me.cboZona.TabIndex = 6
        Me.cboZona.ValueMember = "Id"
        '
        'UltraLabel16
        '
        Appearance144.BackColor = System.Drawing.Color.Transparent
        Appearance144.ForeColor = System.Drawing.Color.Navy
        Appearance144.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance144
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(191, 54)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel16.TabIndex = 5
        Me.UltraLabel16.Text = "Zona:"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ficViaje)
        Me.UltraTabPageControl1.Controls.Add(Me.expGeneral)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1252, 710)
        '
        'ficViaje
        '
        Me.ficViaje.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.ficViaje.Controls.Add(Me.UltraTabPageControl4)
        Me.ficViaje.Controls.Add(Me.UltraTabPageControl5)
        Me.ficViaje.Controls.Add(Me.UltraTabPageControl8)
        Me.ficViaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficViaje.Location = New System.Drawing.Point(0, 300)
        Me.ficViaje.Name = "ficViaje"
        Me.ficViaje.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.ficViaje.Size = New System.Drawing.Size(1252, 410)
        Me.ficViaje.TabIndex = 0
        UltraTab10.TabPage = Me.UltraTabPageControl4
        UltraTab10.Text = "Viaje"
        UltraTab12.TabPage = Me.UltraTabPageControl5
        UltraTab12.Text = "Carga Operacion"
        UltraTab13.TabPage = Me.UltraTabPageControl8
        UltraTab13.Text = "Contrato Tercero"
        UltraTab13.Visible = False
        Me.ficViaje.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab10, UltraTab12, UltraTab13})
        Me.ficViaje.TabStop = False
        Me.ficViaje.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1248, 387)
        '
        'expGeneral
        '
        Me.expGeneral.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Appearance303.BackColor = System.Drawing.Color.White
        Appearance303.BackColor2 = System.Drawing.Color.White
        Me.expGeneral.ContentAreaAppearance = Appearance303
        Me.expGeneral.Controls.Add(Me.UltraExpandableGroupBoxPanel14)
        Me.expGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.expGeneral.ExpandedSize = New System.Drawing.Size(1252, 300)
        Me.expGeneral.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.expGeneral.Location = New System.Drawing.Point(0, 0)
        Me.expGeneral.Name = "expGeneral"
        Me.expGeneral.Size = New System.Drawing.Size(1252, 300)
        Me.expGeneral.TabIndex = 0
        Me.expGeneral.TabStop = False
        Me.expGeneral.Text = "Datos Generales"
        Me.expGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel14
        '
        Me.UltraExpandableGroupBoxPanel14.Controls.Add(Me.griDisponibleVehiculo)
        Me.UltraExpandableGroupBoxPanel14.Controls.Add(Me.expVehiculo)
        Me.UltraExpandableGroupBoxPanel14.Controls.Add(Me.exgruOperacion)
        Me.UltraExpandableGroupBoxPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel14.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel14.Name = "UltraExpandableGroupBoxPanel14"
        Me.UltraExpandableGroupBoxPanel14.Size = New System.Drawing.Size(1246, 277)
        Me.UltraExpandableGroupBoxPanel14.TabIndex = 0
        '
        'griDisponibleVehiculo
        '
        Me.griDisponibleVehiculo.CalcManager = Me.Calcular1
        Me.griDisponibleVehiculo.DataSource = Me.ogdDisponibleVehiculos
        UltraGridColumn1160.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn1160.GroupByMode = Infragistics.Win.UltraWinGrid.GroupByMode.Value
        UltraGridColumn1160.Header.VisiblePosition = 0
        UltraGridColumn1160.Hidden = True
        UltraGridColumn1161.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn1161.GroupByMode = Infragistics.Win.UltraWinGrid.GroupByMode.Value
        UltraGridColumn1161.Header.VisiblePosition = 2
        UltraGridColumn1161.Hidden = True
        UltraGridColumn1161.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1161.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1161.Width = 109
        UltraGridColumn1162.Header.VisiblePosition = 3
        UltraGridColumn1162.Hidden = True
        UltraGridColumn1163.Header.Caption = "Viaje"
        UltraGridColumn1163.Header.VisiblePosition = 4
        UltraGridColumn1163.Hidden = True
        UltraGridColumn1163.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn1163.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1163.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1163.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1163.Width = 87
        UltraGridColumn1164.Header.VisiblePosition = 5
        UltraGridColumn1164.Hidden = True
        UltraGridColumn1165.Header.Caption = "ORIGEN"
        UltraGridColumn1165.Header.VisiblePosition = 11
        UltraGridColumn1165.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn1165.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1165.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1165.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1165.Width = 100
        UltraGridColumn1166.Header.VisiblePosition = 13
        UltraGridColumn1166.Hidden = True
        UltraGridColumn1167.Header.Caption = "Disponible En"
        UltraGridColumn1167.Header.VisiblePosition = 12
        UltraGridColumn1167.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn1167.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1167.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1167.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1167.Width = 100
        UltraGridColumn1168.Header.VisiblePosition = 14
        UltraGridColumn1168.Hidden = True
        UltraGridColumn1169.Header.VisiblePosition = 15
        UltraGridColumn1169.Hidden = True
        UltraGridColumn1169.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn1169.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1169.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1169.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1169.Width = 124
        UltraGridColumn1170.Header.Caption = "V.VACIO"
        UltraGridColumn1170.Header.VisiblePosition = 28
        UltraGridColumn1170.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn1170.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1170.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1170.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1170.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1170.Width = 50
        UltraGridColumn1171.Header.VisiblePosition = 16
        UltraGridColumn1171.Hidden = True
        Appearance304.Image = 7
        UltraGridColumn1172.CellAppearance = Appearance304
        Appearance305.Image = 3
        UltraGridColumn1172.CellButtonAppearance = Appearance305
        UltraGridColumn1172.Header.Caption = "PILOTO"
        UltraGridColumn1172.Header.VisiblePosition = 7
        UltraGridColumn1172.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn1172.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1172.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1172.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1172.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn1172.Width = 200
        UltraGridColumn1173.Header.VisiblePosition = 23
        UltraGridColumn1173.Hidden = True
        UltraGridColumn1174.Header.VisiblePosition = 8
        UltraGridColumn1174.Hidden = True
        UltraGridColumn1174.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn1174.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1174.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1174.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1174.Width = 212
        UltraGridColumn1175.Header.VisiblePosition = 24
        UltraGridColumn1175.Hidden = True
        UltraGridColumn1176.Header.VisiblePosition = 33
        UltraGridColumn1176.Hidden = True
        UltraGridColumn1176.Width = 223
        UltraGridColumn1177.Header.VisiblePosition = 25
        UltraGridColumn1177.Hidden = True
        UltraGridColumn1178.Header.Caption = "TRACTO"
        UltraGridColumn1178.Header.VisiblePosition = 9
        UltraGridColumn1178.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn1178.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1178.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1178.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1178.Width = 50
        UltraGridColumn1179.Header.VisiblePosition = 26
        UltraGridColumn1179.Hidden = True
        UltraGridColumn1180.Header.Caption = "CARRETA"
        UltraGridColumn1180.Header.VisiblePosition = 10
        UltraGridColumn1180.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn1180.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1180.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1180.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1180.Width = 50
        UltraGridColumn1181.Header.VisiblePosition = 29
        UltraGridColumn1181.Hidden = True
        UltraGridColumn1182.Header.VisiblePosition = 27
        UltraGridColumn1182.Hidden = True
        UltraGridColumn1183.Header.Caption = "ESTADO"
        UltraGridColumn1183.Header.VisiblePosition = 17
        UltraGridColumn1183.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn1183.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1183.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1183.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1183.Width = 80
        UltraGridColumn1184.Header.VisiblePosition = 6
        UltraGridColumn1184.Hidden = True
        UltraGridColumn1184.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn1184.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1184.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1184.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1184.Width = 66
        UltraGridColumn1185.Header.VisiblePosition = 30
        UltraGridColumn1185.Hidden = True
        UltraGridColumn1186.Header.VisiblePosition = 31
        UltraGridColumn1186.Hidden = True
        UltraGridColumn1187.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn1187.Header.Caption = "SELECT"
        UltraGridColumn1187.Header.VisiblePosition = 1
        UltraGridColumn1187.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1187.Width = 35
        UltraGridColumn1188.Header.VisiblePosition = 32
        UltraGridColumn1188.Hidden = True
        UltraGridColumn1189.Header.Caption = "TIPO VEHICULO"
        UltraGridColumn1189.Header.VisiblePosition = 21
        UltraGridColumn1189.Width = 100
        UltraGridColumn1190.Header.VisiblePosition = 34
        UltraGridColumn1190.Hidden = True
        UltraGridColumn1191.Header.VisiblePosition = 35
        UltraGridColumn1191.Hidden = True
        UltraGridColumn1192.Header.VisiblePosition = 36
        UltraGridColumn1192.Hidden = True
        UltraGridColumn1193.Header.VisiblePosition = 37
        UltraGridColumn1193.Hidden = True
        UltraGridColumn1194.Header.Caption = "CLIENTE"
        UltraGridColumn1194.Header.VisiblePosition = 18
        UltraGridColumn1194.Width = 200
        Appearance306.Image = 3
        Appearance306.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn1195.CellAppearance = Appearance306
        Appearance307.Image = 1
        UltraGridColumn1195.CellButtonAppearance = Appearance307
        UltraGridColumn1195.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn1195.Header.Caption = "COMENTARIO / OBSERVACION"
        UltraGridColumn1195.Header.VisiblePosition = 53
        UltraGridColumn1195.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn1195.Width = 300
        UltraGridColumn1196.Header.VisiblePosition = 38
        UltraGridColumn1196.Hidden = True
        UltraGridColumn1197.Header.VisiblePosition = 39
        UltraGridColumn1197.Hidden = True
        UltraGridColumn1198.Header.VisiblePosition = 40
        UltraGridColumn1198.Hidden = True
        UltraGridColumn1199.Header.Caption = "LLEGADAORIGEN"
        UltraGridColumn1199.Header.VisiblePosition = 41
        UltraGridColumn1199.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn1199.Width = 100
        UltraGridColumn1200.Header.Caption = "SALIDAORIGEN"
        UltraGridColumn1200.Header.VisiblePosition = 42
        UltraGridColumn1200.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn1200.Width = 70
        UltraGridColumn1201.Header.Caption = "LLEGADADESTINO"
        UltraGridColumn1201.Header.VisiblePosition = 43
        UltraGridColumn1201.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn1201.Width = 70
        UltraGridColumn1202.Header.Caption = "SALIDADESTINO"
        UltraGridColumn1202.Header.VisiblePosition = 44
        UltraGridColumn1202.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn1202.Width = 70
        UltraGridColumn1203.Header.Caption = "FLOTA"
        UltraGridColumn1203.Header.VisiblePosition = 74
        UltraGridColumn1203.Width = 100
        UltraGridColumn1204.Header.Caption = "Bloque"
        UltraGridColumn1204.Header.VisiblePosition = 22
        UltraGridColumn1204.Hidden = True
        UltraGridColumn1204.Width = 35
        UltraGridColumn1205.Header.Caption = "TN"
        UltraGridColumn1205.Header.VisiblePosition = 20
        UltraGridColumn1205.Width = 35
        UltraGridColumn1206.Header.Caption = "ZONA"
        UltraGridColumn1206.Header.VisiblePosition = 54
        UltraGridColumn1206.Width = 80
        UltraGridColumn1207.Header.Caption = "CARGA MATERIAL"
        UltraGridColumn1207.Header.VisiblePosition = 19
        UltraGridColumn1208.Header.VisiblePosition = 45
        UltraGridColumn1208.Hidden = True
        UltraGridColumn1208.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1208.Width = 50
        UltraGridColumn1209.Header.VisiblePosition = 46
        UltraGridColumn1209.Hidden = True
        UltraGridColumn1210.Header.VisiblePosition = 47
        UltraGridColumn1210.Hidden = True
        UltraGridColumn1211.Header.VisiblePosition = 48
        UltraGridColumn1211.Hidden = True
        UltraGridColumn1212.Header.VisiblePosition = 49
        UltraGridColumn1212.Hidden = True
        UltraGridColumn1213.Header.VisiblePosition = 50
        UltraGridColumn1213.Hidden = True
        UltraGridColumn1214.Header.VisiblePosition = 51
        UltraGridColumn1214.Hidden = True
        Appearance308.TextHAlignAsString = "Right"
        UltraGridColumn1215.CellAppearance = Appearance308
        UltraGridColumn1215.Header.Caption = "CAPACIDAD"
        UltraGridColumn1215.Header.VisiblePosition = 52
        UltraGridColumn1215.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn1215.Width = 51
        UltraGridColumn1216.Header.VisiblePosition = 55
        UltraGridColumn1216.Hidden = True
        UltraGridColumn1217.Header.VisiblePosition = 56
        UltraGridColumn1217.Hidden = True
        UltraGridColumn1218.Header.VisiblePosition = 57
        UltraGridColumn1218.Hidden = True
        UltraGridColumn1219.Header.VisiblePosition = 58
        UltraGridColumn1219.Hidden = True
        UltraGridColumn1220.Header.VisiblePosition = 59
        UltraGridColumn1220.Hidden = True
        UltraGridColumn1221.Header.VisiblePosition = 60
        UltraGridColumn1221.Hidden = True
        UltraGridColumn1222.Header.VisiblePosition = 61
        UltraGridColumn1222.Hidden = True
        UltraGridColumn1223.Header.VisiblePosition = 62
        UltraGridColumn1223.Hidden = True
        UltraGridColumn1224.Header.VisiblePosition = 63
        UltraGridColumn1224.Hidden = True
        UltraGridColumn1225.Header.VisiblePosition = 64
        UltraGridColumn1225.Hidden = True
        UltraGridColumn1226.Header.VisiblePosition = 65
        UltraGridColumn1226.Hidden = True
        UltraGridColumn1227.Header.VisiblePosition = 66
        UltraGridColumn1227.Hidden = True
        UltraGridColumn1228.Header.VisiblePosition = 67
        UltraGridColumn1228.Hidden = True
        UltraGridColumn1229.Header.VisiblePosition = 69
        UltraGridColumn1229.Hidden = True
        UltraGridColumn1230.Header.VisiblePosition = 70
        UltraGridColumn1230.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 71
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 72
        UltraGridColumn4.Hidden = True
        UltraGridColumn1231.Header.VisiblePosition = 68
        UltraGridColumn1231.Hidden = True
        UltraGridColumn1232.Header.VisiblePosition = 73
        UltraGridColumn1232.Hidden = True
        UltraGridColumn1232.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1233.Header.VisiblePosition = 75
        UltraGridColumn1233.Hidden = True
        UltraGridColumn1234.Header.VisiblePosition = 76
        UltraGridColumn1234.Hidden = True
        UltraGridColumn1235.Header.VisiblePosition = 77
        UltraGridColumn1235.Hidden = True
        UltraGridColumn1236.Header.VisiblePosition = 78
        UltraGridColumn1236.Hidden = True
        UltraGridColumn1237.Header.VisiblePosition = 79
        UltraGridColumn1237.Hidden = True
        UltraGridColumn1238.Header.VisiblePosition = 80
        UltraGridColumn1238.Hidden = True
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn1160, UltraGridColumn1161, UltraGridColumn1162, UltraGridColumn1163, UltraGridColumn1164, UltraGridColumn1165, UltraGridColumn1166, UltraGridColumn1167, UltraGridColumn1168, UltraGridColumn1169, UltraGridColumn1170, UltraGridColumn1171, UltraGridColumn1172, UltraGridColumn1173, UltraGridColumn1174, UltraGridColumn1175, UltraGridColumn1176, UltraGridColumn1177, UltraGridColumn1178, UltraGridColumn1179, UltraGridColumn1180, UltraGridColumn1181, UltraGridColumn1182, UltraGridColumn1183, UltraGridColumn1184, UltraGridColumn1185, UltraGridColumn1186, UltraGridColumn1187, UltraGridColumn1188, UltraGridColumn1189, UltraGridColumn1190, UltraGridColumn1191, UltraGridColumn1192, UltraGridColumn1193, UltraGridColumn1194, UltraGridColumn1195, UltraGridColumn1196, UltraGridColumn1197, UltraGridColumn1198, UltraGridColumn1199, UltraGridColumn1200, UltraGridColumn1201, UltraGridColumn1202, UltraGridColumn1203, UltraGridColumn1204, UltraGridColumn1205, UltraGridColumn1206, UltraGridColumn1207, UltraGridColumn1208, UltraGridColumn1209, UltraGridColumn1210, UltraGridColumn1211, UltraGridColumn1212, UltraGridColumn1213, UltraGridColumn1214, UltraGridColumn1215, UltraGridColumn1216, UltraGridColumn1217, UltraGridColumn1218, UltraGridColumn1219, UltraGridColumn1220, UltraGridColumn1221, UltraGridColumn1222, UltraGridColumn1223, UltraGridColumn1224, UltraGridColumn1225, UltraGridColumn1226, UltraGridColumn1227, UltraGridColumn1228, UltraGridColumn1229, UltraGridColumn1230, UltraGridColumn3, UltraGridColumn4, UltraGridColumn1231, UltraGridColumn1232, UltraGridColumn1233, UltraGridColumn1234, UltraGridColumn1235, UltraGridColumn1236, UltraGridColumn1237, UltraGridColumn1238})
        UltraGridBand11.GroupHeadersVisible = False
        UltraGridBand11.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDisponibleVehiculo.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.griDisponibleVehiculo.DisplayLayout.MaxColScrollRegions = 1
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDisponibleVehiculo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDisponibleVehiculo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griDisponibleVehiculo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDisponibleVehiculo.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDisponibleVehiculo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDisponibleVehiculo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDisponibleVehiculo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDisponibleVehiculo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDisponibleVehiculo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDisponibleVehiculo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDisponibleVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDisponibleVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDisponibleVehiculo.ImageList = Me.imagenes
        Me.griDisponibleVehiculo.Location = New System.Drawing.Point(800, 0)
        Me.griDisponibleVehiculo.Name = "griDisponibleVehiculo"
        Me.griDisponibleVehiculo.Size = New System.Drawing.Size(446, 277)
        Me.griDisponibleVehiculo.TabIndex = 76
        Me.griDisponibleVehiculo.TabStop = False
        Me.griDisponibleVehiculo.Tag = ""
        '
        'ogdDisponibleVehiculos
        '
        Me.ogdDisponibleVehiculos.Band.Columns.AddRange(New Object() {UltraDataColumn282, UltraDataColumn283, UltraDataColumn284, UltraDataColumn285, UltraDataColumn286, UltraDataColumn287, UltraDataColumn288, UltraDataColumn289, UltraDataColumn290, UltraDataColumn291, UltraDataColumn292, UltraDataColumn293, UltraDataColumn294, UltraDataColumn295, UltraDataColumn296, UltraDataColumn297, UltraDataColumn298, UltraDataColumn299, UltraDataColumn300, UltraDataColumn301, UltraDataColumn302, UltraDataColumn303, UltraDataColumn304, UltraDataColumn305, UltraDataColumn306, UltraDataColumn307, UltraDataColumn308, UltraDataColumn309, UltraDataColumn310, UltraDataColumn311, UltraDataColumn312, UltraDataColumn313, UltraDataColumn314, UltraDataColumn315, UltraDataColumn316, UltraDataColumn317, UltraDataColumn318, UltraDataColumn319, UltraDataColumn320, UltraDataColumn321, UltraDataColumn322, UltraDataColumn323, UltraDataColumn324, UltraDataColumn325, UltraDataColumn326, UltraDataColumn327, UltraDataColumn328, UltraDataColumn329, UltraDataColumn330, UltraDataColumn331, UltraDataColumn332, UltraDataColumn333, UltraDataColumn334, UltraDataColumn335, UltraDataColumn336, UltraDataColumn337, UltraDataColumn338, UltraDataColumn339, UltraDataColumn340, UltraDataColumn341, UltraDataColumn342, UltraDataColumn343, UltraDataColumn344, UltraDataColumn345, UltraDataColumn346, UltraDataColumn347, UltraDataColumn348, UltraDataColumn349, UltraDataColumn350, UltraDataColumn351, UltraDataColumn352, UltraDataColumn353, UltraDataColumn354})
        '
        'expVehiculo
        '
        Me.expVehiculo.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Far
        Appearance309.BackColor = System.Drawing.Color.White
        Appearance309.BackColor2 = System.Drawing.Color.White
        Me.expVehiculo.ContentAreaAppearance = Appearance309
        Me.expVehiculo.Controls.Add(Me.UltraExpandableGroupBoxPanel8)
        Me.expVehiculo.Dock = System.Windows.Forms.DockStyle.Left
        Me.expVehiculo.ExpandedSize = New System.Drawing.Size(375, 277)
        Me.expVehiculo.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.expVehiculo.Location = New System.Drawing.Point(425, 0)
        Me.expVehiculo.Name = "expVehiculo"
        Me.expVehiculo.Size = New System.Drawing.Size(375, 277)
        Me.expVehiculo.TabIndex = 2
        Me.expVehiculo.TabStop = False
        Me.expVehiculo.Text = "Disponibilidad Vehiculo / Trabajador"
        Me.expVehiculo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel8
        '
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.UltraExpandableGroupBox12)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.UltraExpandableGroupBox9)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.UltraGroupBox2)
        Me.UltraExpandableGroupBoxPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel8.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel8.Name = "UltraExpandableGroupBoxPanel8"
        Me.UltraExpandableGroupBoxPanel8.Size = New System.Drawing.Size(352, 271)
        Me.UltraExpandableGroupBoxPanel8.TabIndex = 0
        '
        'UltraExpandableGroupBox12
        '
        Appearance310.BackColor = System.Drawing.Color.White
        Appearance310.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox12.ContentAreaAppearance = Appearance310
        Me.UltraExpandableGroupBox12.Controls.Add(Me.UltraExpandableGroupBoxPanel13)
        Me.UltraExpandableGroupBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox12.ExpandedSize = New System.Drawing.Size(352, 67)
        Me.UltraExpandableGroupBox12.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox12.Location = New System.Drawing.Point(0, 210)
        Me.UltraExpandableGroupBox12.Name = "UltraExpandableGroupBox12"
        Me.UltraExpandableGroupBox12.Size = New System.Drawing.Size(352, 67)
        Me.UltraExpandableGroupBox12.TabIndex = 2
        Me.UltraExpandableGroupBox12.Text = "Disponibilidad"
        Me.UltraExpandableGroupBox12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel13
        '
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.Etiqueta15)
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.ColorAdvertencia)
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.Etiqueta16)
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.Etiqueta19)
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.Etiqueta17)
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.Etiqueta18)
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.ColorPiloto)
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.Etiqueta14)
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.ColorAyudante)
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.ColorCopiloto)
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.ColorCarreta)
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.ColorTracto)
        Me.UltraExpandableGroupBoxPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel13.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel13.Name = "UltraExpandableGroupBoxPanel13"
        Me.UltraExpandableGroupBoxPanel13.Size = New System.Drawing.Size(346, 44)
        Me.UltraExpandableGroupBoxPanel13.TabIndex = 0
        '
        'Etiqueta15
        '
        Appearance311.BackColor = System.Drawing.Color.White
        Appearance311.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance311
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(8, 3)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta15.TabIndex = 1
        Me.Etiqueta15.Text = "Advertencia:"
        '
        'ColorAdvertencia
        '
        Me.ColorAdvertencia.Color = System.Drawing.Color.Red
        Me.ColorAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAdvertencia.Location = New System.Drawing.Point(75, 1)
        Me.ColorAdvertencia.Name = "ColorAdvertencia"
        Me.ColorAdvertencia.Size = New System.Drawing.Size(44, 19)
        Me.ColorAdvertencia.TabIndex = 2
        Me.ColorAdvertencia.Text = "Red"
        '
        'Etiqueta16
        '
        Appearance312.BackColor = System.Drawing.Color.Transparent
        Appearance312.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance312
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(259, 23)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta16.TabIndex = 9
        Me.Etiqueta16.Text = "Carreta:"
        '
        'Etiqueta19
        '
        Appearance313.BackColor = System.Drawing.Color.Transparent
        Appearance313.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta19.Appearance = Appearance313
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(264, 3)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta19.TabIndex = 8
        Me.Etiqueta19.Text = "Tracto:"
        '
        'Etiqueta17
        '
        Appearance314.BackColor = System.Drawing.Color.Transparent
        Appearance314.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance314
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(146, 4)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta17.TabIndex = 3
        Me.Etiqueta17.Text = "Copiloto:"
        '
        'Etiqueta18
        '
        Appearance315.BackColor = System.Drawing.Color.Transparent
        Appearance315.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance315
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(140, 23)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta18.TabIndex = 8
        Me.Etiqueta18.Text = "Ayudante:"
        '
        'ColorPiloto
        '
        Me.ColorPiloto.Color = System.Drawing.Color.Orange
        Me.ColorPiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPiloto.Location = New System.Drawing.Point(75, 21)
        Me.ColorPiloto.Name = "ColorPiloto"
        Me.ColorPiloto.Size = New System.Drawing.Size(44, 19)
        Me.ColorPiloto.TabIndex = 7
        Me.ColorPiloto.Text = "Orange"
        UltraToolTipInfo15.ToolTipText = "Color que especifica si el piloto no se encuentra disponible para el viaje"
        UltraToolTipInfo15.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorPiloto, UltraToolTipInfo15)
        '
        'Etiqueta14
        '
        Appearance316.BackColor = System.Drawing.Color.Transparent
        Appearance316.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance316
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(39, 23)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta14.TabIndex = 6
        Me.Etiqueta14.Text = "Piloto:"
        '
        'ColorAyudante
        '
        Me.ColorAyudante.Color = System.Drawing.Color.Lime
        Me.ColorAyudante.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorAyudante.Location = New System.Drawing.Point(195, 21)
        Me.ColorAyudante.Name = "ColorAyudante"
        Me.ColorAyudante.Size = New System.Drawing.Size(44, 19)
        Me.ColorAyudante.TabIndex = 5
        Me.ColorAyudante.Text = "Lime"
        UltraToolTipInfo16.ToolTipText = "Color que especifica si el piloto no se encuentra disponible para el viaje"
        UltraToolTipInfo16.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorAyudante, UltraToolTipInfo16)
        '
        'ColorCopiloto
        '
        Me.ColorCopiloto.Color = System.Drawing.Color.Yellow
        Me.ColorCopiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCopiloto.Location = New System.Drawing.Point(195, 1)
        Me.ColorCopiloto.Name = "ColorCopiloto"
        Me.ColorCopiloto.Size = New System.Drawing.Size(44, 19)
        Me.ColorCopiloto.TabIndex = 4
        Me.ColorCopiloto.Text = "Yellow"
        UltraToolTipInfo17.ToolTipText = "Color que especifica si el copiloto no se encuentra disponible para el viaje"
        UltraToolTipInfo17.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorCopiloto, UltraToolTipInfo17)
        '
        'ColorCarreta
        '
        Me.ColorCarreta.Color = System.Drawing.Color.Blue
        Me.ColorCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCarreta.Location = New System.Drawing.Point(304, 21)
        Me.ColorCarreta.Name = "ColorCarreta"
        Me.ColorCarreta.Size = New System.Drawing.Size(44, 19)
        Me.ColorCarreta.TabIndex = 10
        Me.ColorCarreta.Text = "Blue"
        '
        'ColorTracto
        '
        Me.ColorTracto.Color = System.Drawing.Color.DarkCyan
        Me.ColorTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTracto.Location = New System.Drawing.Point(304, 1)
        Me.ColorTracto.Name = "ColorTracto"
        Me.ColorTracto.Size = New System.Drawing.Size(44, 19)
        Me.ColorTracto.TabIndex = 5
        Me.ColorTracto.Text = "DarkCyan"
        UltraToolTipInfo18.ToolTipText = "Color que especifica si el piloto no se encuentra disponible para el viaje"
        UltraToolTipInfo18.ToolTipTitle = "Mensaje del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ColorTracto, UltraToolTipInfo18)
        '
        'UltraExpandableGroupBox9
        '
        Appearance317.BackColor = System.Drawing.Color.White
        Appearance317.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox9.ContentAreaAppearance = Appearance317
        Me.UltraExpandableGroupBox9.Controls.Add(Me.UltraExpandableGroupBoxPanel11)
        Me.UltraExpandableGroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox9.ExpandedSize = New System.Drawing.Size(352, 145)
        Me.UltraExpandableGroupBox9.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox9.Location = New System.Drawing.Point(0, 65)
        Me.UltraExpandableGroupBox9.Name = "UltraExpandableGroupBox9"
        Me.UltraExpandableGroupBox9.Size = New System.Drawing.Size(352, 145)
        Me.UltraExpandableGroupBox9.TabIndex = 1
        Me.UltraExpandableGroupBox9.Text = "Tipo Vehiculo"
        Me.UltraExpandableGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel11
        '
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta1)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta36)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorParihueleroD)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorMediaBarandaD)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorPlataformaD)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta46)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorCamion20M3D)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorCamion40M3D)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta2)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorCaliceraD)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta8)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta43)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorTolvaVolteoD)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta42)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta33)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorCamion30M3D)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta34)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta41)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorCamion65M3D)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta40)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorContenedorD)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta39)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta35)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorVolqueteD)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorGraneleroD)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorCamionetaD)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorFurgonD)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta38)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.ColorFurgonLargoD)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta37)
        Me.UltraExpandableGroupBoxPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel11.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel11.Name = "UltraExpandableGroupBoxPanel11"
        Me.UltraExpandableGroupBoxPanel11.Size = New System.Drawing.Size(346, 122)
        Me.UltraExpandableGroupBoxPanel11.TabIndex = 0
        '
        'Etiqueta1
        '
        Appearance318.BackColor = System.Drawing.Color.Transparent
        Appearance318.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance318
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(140, 65)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta1.TabIndex = 72
        Me.Etiqueta1.Text = "Parihuelero:"
        '
        'Etiqueta36
        '
        Appearance319.BackColor = System.Drawing.Color.Transparent
        Appearance319.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta36.Appearance = Appearance319
        Me.Etiqueta36.AutoSize = True
        Me.Etiqueta36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta36.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta36.Location = New System.Drawing.Point(15, 4)
        Me.Etiqueta36.Name = "Etiqueta36"
        Me.Etiqueta36.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta36.TabIndex = 44
        Me.Etiqueta36.Text = "Plataforma:"
        '
        'ColorParihueleroD
        '
        Me.ColorParihueleroD.Color = System.Drawing.Color.PaleGreen
        Me.ColorParihueleroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorParihueleroD.Location = New System.Drawing.Point(206, 63)
        Me.ColorParihueleroD.Name = "ColorParihueleroD"
        Me.ColorParihueleroD.Size = New System.Drawing.Size(44, 19)
        Me.ColorParihueleroD.TabIndex = 73
        Me.ColorParihueleroD.Text = "PaleGreen"
        '
        'ColorMediaBarandaD
        '
        Me.ColorMediaBarandaD.Color = System.Drawing.Color.Orange
        Me.ColorMediaBarandaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorMediaBarandaD.Location = New System.Drawing.Point(206, 42)
        Me.ColorMediaBarandaD.Name = "ColorMediaBarandaD"
        Me.ColorMediaBarandaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorMediaBarandaD.TabIndex = 71
        Me.ColorMediaBarandaD.Text = "Orange"
        '
        'ColorPlataformaD
        '
        Me.ColorPlataformaD.Color = System.Drawing.Color.Coral
        Me.ColorPlataformaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPlataformaD.Location = New System.Drawing.Point(77, 1)
        Me.ColorPlataformaD.Name = "ColorPlataformaD"
        Me.ColorPlataformaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorPlataformaD.TabIndex = 45
        Me.ColorPlataformaD.Text = "Coral"
        '
        'Etiqueta46
        '
        Appearance320.BackColor = System.Drawing.Color.Transparent
        Appearance320.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta46.Appearance = Appearance320
        Me.Etiqueta46.AutoSize = True
        Me.Etiqueta46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta46.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta46.Location = New System.Drawing.Point(260, 24)
        Me.Etiqueta46.Name = "Etiqueta46"
        Me.Etiqueta46.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta46.TabIndex = 62
        Me.Etiqueta46.Text = "30 M3:"
        '
        'ColorCamion20M3D
        '
        Me.ColorCamion20M3D.Color = System.Drawing.Color.PaleTurquoise
        Me.ColorCamion20M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion20M3D.Location = New System.Drawing.Point(300, 2)
        Me.ColorCamion20M3D.Name = "ColorCamion20M3D"
        Me.ColorCamion20M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion20M3D.TabIndex = 61
        Me.ColorCamion20M3D.Text = "PaleTurquoise"
        '
        'ColorCamion40M3D
        '
        Me.ColorCamion40M3D.Color = System.Drawing.Color.Violet
        Me.ColorCamion40M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion40M3D.Location = New System.Drawing.Point(300, 44)
        Me.ColorCamion40M3D.Name = "ColorCamion40M3D"
        Me.ColorCamion40M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion40M3D.TabIndex = 65
        Me.ColorCamion40M3D.Text = "Violet"
        '
        'Etiqueta2
        '
        Appearance321.BackColor = System.Drawing.Color.Transparent
        Appearance321.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance321
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(15, 45)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta2.TabIndex = 58
        Me.Etiqueta2.Text = "Camioneta:"
        '
        'ColorCaliceraD
        '
        Me.ColorCaliceraD.Color = System.Drawing.Color.DarkKhaki
        Me.ColorCaliceraD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCaliceraD.Location = New System.Drawing.Point(206, 84)
        Me.ColorCaliceraD.Name = "ColorCaliceraD"
        Me.ColorCaliceraD.Size = New System.Drawing.Size(44, 19)
        Me.ColorCaliceraD.TabIndex = 51
        Me.ColorCaliceraD.Text = "DarkKhaki"
        '
        'Etiqueta8
        '
        Appearance322.BackColor = System.Drawing.Color.Transparent
        Appearance322.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance322
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(32, 83)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta8.TabIndex = 48
        Me.Etiqueta8.Text = "Furgon:"
        '
        'Etiqueta43
        '
        Appearance323.BackColor = System.Drawing.Color.Transparent
        Appearance323.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta43.Appearance = Appearance323
        Me.Etiqueta43.AutoSize = True
        Me.Etiqueta43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta43.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta43.Location = New System.Drawing.Point(155, 86)
        Me.Etiqueta43.Name = "Etiqueta43"
        Me.Etiqueta43.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta43.TabIndex = 50
        Me.Etiqueta43.Text = "Calicera:"
        '
        'ColorTolvaVolteoD
        '
        Me.ColorTolvaVolteoD.Color = System.Drawing.Color.RosyBrown
        Me.ColorTolvaVolteoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTolvaVolteoD.Location = New System.Drawing.Point(77, 61)
        Me.ColorTolvaVolteoD.Name = "ColorTolvaVolteoD"
        Me.ColorTolvaVolteoD.Size = New System.Drawing.Size(44, 19)
        Me.ColorTolvaVolteoD.TabIndex = 55
        Me.ColorTolvaVolteoD.Text = "RosyBrown"
        '
        'Etiqueta42
        '
        Appearance324.BackColor = System.Drawing.Color.Transparent
        Appearance324.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta42.Appearance = Appearance324
        Me.Etiqueta42.AutoSize = True
        Me.Etiqueta42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta42.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta42.Location = New System.Drawing.Point(10, 24)
        Me.Etiqueta42.Name = "Etiqueta42"
        Me.Etiqueta42.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta42.TabIndex = 68
        Me.Etiqueta42.Text = "Contenedor:"
        '
        'Etiqueta33
        '
        Appearance325.BackColor = System.Drawing.Color.Transparent
        Appearance325.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta33.Appearance = Appearance325
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta33.Location = New System.Drawing.Point(24, 103)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(52, 14)
        Me.Etiqueta33.TabIndex = 46
        Me.Etiqueta33.Text = "Volquete:"
        '
        'ColorCamion30M3D
        '
        Me.ColorCamion30M3D.Color = System.Drawing.Color.DeepSkyBlue
        Me.ColorCamion30M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion30M3D.Location = New System.Drawing.Point(300, 23)
        Me.ColorCamion30M3D.Name = "ColorCamion30M3D"
        Me.ColorCamion30M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion30M3D.TabIndex = 63
        Me.ColorCamion30M3D.Text = "DeepSkyBlue"
        '
        'Etiqueta34
        '
        Appearance326.BackColor = System.Drawing.Color.Transparent
        Appearance326.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta34.Appearance = Appearance326
        Me.Etiqueta34.AutoSize = True
        Me.Etiqueta34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta34.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta34.Location = New System.Drawing.Point(147, 26)
        Me.Etiqueta34.Name = "Etiqueta34"
        Me.Etiqueta34.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta34.TabIndex = 52
        Me.Etiqueta34.Text = "Granelero:"
        '
        'Etiqueta41
        '
        Appearance327.BackColor = System.Drawing.Color.Transparent
        Appearance327.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta41.Appearance = Appearance327
        Me.Etiqueta41.AutoSize = True
        Me.Etiqueta41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta41.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta41.Location = New System.Drawing.Point(260, 45)
        Me.Etiqueta41.Name = "Etiqueta41"
        Me.Etiqueta41.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta41.TabIndex = 64
        Me.Etiqueta41.Text = "40 M3:"
        '
        'ColorCamion65M3D
        '
        Me.ColorCamion65M3D.Color = System.Drawing.Color.MediumSpringGreen
        Me.ColorCamion65M3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamion65M3D.Location = New System.Drawing.Point(300, 65)
        Me.ColorCamion65M3D.Name = "ColorCamion65M3D"
        Me.ColorCamion65M3D.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamion65M3D.TabIndex = 67
        Me.ColorCamion65M3D.Text = "MediumSpringGreen"
        '
        'Etiqueta40
        '
        Appearance328.BackColor = System.Drawing.Color.Transparent
        Appearance328.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta40.Appearance = Appearance328
        Me.Etiqueta40.AutoSize = True
        Me.Etiqueta40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta40.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta40.Location = New System.Drawing.Point(126, 45)
        Me.Etiqueta40.Name = "Etiqueta40"
        Me.Etiqueta40.Size = New System.Drawing.Size(81, 14)
        Me.Etiqueta40.TabIndex = 70
        Me.Etiqueta40.Text = "MediaBaranda:"
        '
        'ColorContenedorD
        '
        Me.ColorContenedorD.Color = System.Drawing.Color.OliveDrab
        Me.ColorContenedorD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorContenedorD.Location = New System.Drawing.Point(77, 21)
        Me.ColorContenedorD.Name = "ColorContenedorD"
        Me.ColorContenedorD.Size = New System.Drawing.Size(44, 19)
        Me.ColorContenedorD.TabIndex = 57
        Me.ColorContenedorD.Text = "OliveDrab"
        '
        'Etiqueta39
        '
        Appearance329.BackColor = System.Drawing.Color.Transparent
        Appearance329.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta39.Appearance = Appearance329
        Me.Etiqueta39.AutoSize = True
        Me.Etiqueta39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta39.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta39.Location = New System.Drawing.Point(131, 4)
        Me.Etiqueta39.Name = "Etiqueta39"
        Me.Etiqueta39.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta39.TabIndex = 56
        Me.Etiqueta39.Text = "Furgon Largo:"
        '
        'Etiqueta35
        '
        Appearance330.BackColor = System.Drawing.Color.Transparent
        Appearance330.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta35.Appearance = Appearance330
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta35.Location = New System.Drawing.Point(260, 5)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta35.TabIndex = 60
        Me.Etiqueta35.Text = "20 M3:"
        '
        'ColorVolqueteD
        '
        Me.ColorVolqueteD.Color = System.Drawing.Color.Peru
        Me.ColorVolqueteD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorVolqueteD.Location = New System.Drawing.Point(77, 101)
        Me.ColorVolqueteD.Name = "ColorVolqueteD"
        Me.ColorVolqueteD.Size = New System.Drawing.Size(44, 19)
        Me.ColorVolqueteD.TabIndex = 47
        Me.ColorVolqueteD.Text = "Peru"
        '
        'ColorGraneleroD
        '
        Me.ColorGraneleroD.Color = System.Drawing.Color.YellowGreen
        Me.ColorGraneleroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorGraneleroD.Location = New System.Drawing.Point(206, 22)
        Me.ColorGraneleroD.Name = "ColorGraneleroD"
        Me.ColorGraneleroD.Size = New System.Drawing.Size(44, 19)
        Me.ColorGraneleroD.TabIndex = 53
        Me.ColorGraneleroD.Text = "YellowGreen"
        '
        'ColorCamionetaD
        '
        Me.ColorCamionetaD.Color = System.Drawing.Color.LightSeaGreen
        Me.ColorCamionetaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCamionetaD.Location = New System.Drawing.Point(77, 41)
        Me.ColorCamionetaD.Name = "ColorCamionetaD"
        Me.ColorCamionetaD.Size = New System.Drawing.Size(44, 19)
        Me.ColorCamionetaD.TabIndex = 59
        Me.ColorCamionetaD.Text = "LightSeaGreen"
        '
        'ColorFurgonD
        '
        Me.ColorFurgonD.Color = System.Drawing.Color.Gold
        Me.ColorFurgonD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonD.Location = New System.Drawing.Point(77, 81)
        Me.ColorFurgonD.Name = "ColorFurgonD"
        Me.ColorFurgonD.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonD.TabIndex = 49
        Me.ColorFurgonD.Text = "Gold"
        '
        'Etiqueta38
        '
        Appearance331.BackColor = System.Drawing.Color.Transparent
        Appearance331.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta38.Appearance = Appearance331
        Me.Etiqueta38.AutoSize = True
        Me.Etiqueta38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta38.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta38.Location = New System.Drawing.Point(260, 69)
        Me.Etiqueta38.Name = "Etiqueta38"
        Me.Etiqueta38.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta38.TabIndex = 66
        Me.Etiqueta38.Text = "65 M3:"
        '
        'ColorFurgonLargoD
        '
        Me.ColorFurgonLargoD.Color = System.Drawing.Color.PeachPuff
        Me.ColorFurgonLargoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFurgonLargoD.Location = New System.Drawing.Point(206, 1)
        Me.ColorFurgonLargoD.Name = "ColorFurgonLargoD"
        Me.ColorFurgonLargoD.Size = New System.Drawing.Size(44, 19)
        Me.ColorFurgonLargoD.TabIndex = 69
        Me.ColorFurgonLargoD.Text = "PeachPuff"
        '
        'Etiqueta37
        '
        Appearance332.BackColor = System.Drawing.Color.Transparent
        Appearance332.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta37.Appearance = Appearance332
        Me.Etiqueta37.AutoSize = True
        Me.Etiqueta37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta37.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta37.Location = New System.Drawing.Point(7, 63)
        Me.Etiqueta37.Name = "Etiqueta37"
        Me.Etiqueta37.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta37.TabIndex = 54
        Me.Etiqueta37.Text = "Tolva Volteo:"
        '
        'UltraGroupBox2
        '
        Appearance333.BackColor = System.Drawing.Color.White
        Appearance333.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance333
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel26)
        Me.UltraGroupBox2.Controls.Add(Me.cboZonaDisponibles)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel59)
        Me.UltraGroupBox2.Controls.Add(Me.cboVehiculoDisponible)
        Me.UltraGroupBox2.Controls.Add(Me.btnConsultarDisponibles)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(352, 65)
        Me.UltraGroupBox2.TabIndex = 0
        Me.UltraGroupBox2.Text = "Filtro de Consulta"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel26
        '
        Appearance334.BackColor = System.Drawing.Color.Transparent
        Appearance334.ForeColor = System.Drawing.Color.Navy
        Appearance334.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance334
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Location = New System.Drawing.Point(4, 22)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel26.TabIndex = 4
        Me.UltraLabel26.Text = "Tracto:"
        '
        'cboZonaDisponibles
        '
        Appearance335.ForeColor = System.Drawing.Color.Black
        Me.cboZonaDisponibles.Appearance = Appearance335
        Me.cboZonaDisponibles.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboZonaDisponibles.DisplayMember = "Nombre"
        Me.cboZonaDisponibles.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboZonaDisponibles.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboZonaDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZonaDisponibles.ForeColor = System.Drawing.Color.Black
        Me.cboZonaDisponibles.Location = New System.Drawing.Point(45, 38)
        Me.cboZonaDisponibles.Name = "cboZonaDisponibles"
        Me.cboZonaDisponibles.Size = New System.Drawing.Size(150, 21)
        Me.cboZonaDisponibles.TabIndex = 2
        UltraToolTipInfo19.ToolTipText = "Seleccionar Zona para"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboZonaDisponibles, UltraToolTipInfo19)
        Me.cboZonaDisponibles.ValueMember = "Id"
        '
        'UltraLabel59
        '
        Appearance336.BackColor = System.Drawing.Color.Transparent
        Appearance336.ForeColor = System.Drawing.Color.Navy
        Appearance336.TextVAlignAsString = "Middle"
        Me.UltraLabel59.Appearance = Appearance336
        Me.UltraLabel59.AutoSize = True
        Me.UltraLabel59.Location = New System.Drawing.Point(10, 42)
        Me.UltraLabel59.Name = "UltraLabel59"
        Me.UltraLabel59.Size = New System.Drawing.Size(32, 15)
        Me.UltraLabel59.TabIndex = 0
        Me.UltraLabel59.Text = "Zona:"
        '
        'cboVehiculoDisponible
        '
        Appearance337.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculoDisponible.Appearance = Appearance337
        Me.cboVehiculoDisponible.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboVehiculoDisponible.DisplayMember = ""
        Me.cboVehiculoDisponible.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboVehiculoDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculoDisponible.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculoDisponible.Location = New System.Drawing.Point(45, 18)
        Me.cboVehiculoDisponible.Name = "cboVehiculoDisponible"
        Me.cboVehiculoDisponible.Size = New System.Drawing.Size(80, 21)
        Me.cboVehiculoDisponible.TabIndex = 1
        UltraToolTipInfo20.ToolTipText = "Seleccionar Tracto para Filtrar su Disponibilidad"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.cboVehiculoDisponible, UltraToolTipInfo20)
        Me.cboVehiculoDisponible.ValueMember = "Id"
        '
        'btnConsultarDisponibles
        '
        Appearance338.Image = "266.png"
        Appearance338.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance338.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnConsultarDisponibles.Appearance = Appearance338
        Me.btnConsultarDisponibles.ImageList = Me.imagenes
        Me.btnConsultarDisponibles.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnConsultarDisponibles.Location = New System.Drawing.Point(201, 29)
        Me.btnConsultarDisponibles.Name = "btnConsultarDisponibles"
        Me.btnConsultarDisponibles.Size = New System.Drawing.Size(40, 30)
        Me.btnConsultarDisponibles.TabIndex = 3
        '
        'exgruOperacion
        '
        Me.exgruOperacion.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance339.BackColor = System.Drawing.Color.White
        Appearance339.BackColor2 = System.Drawing.Color.White
        Me.exgruOperacion.ContentAreaAppearance = Appearance339
        Me.exgruOperacion.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.exgruOperacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.exgruOperacion.ExpandedSize = New System.Drawing.Size(425, 277)
        Me.exgruOperacion.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruOperacion.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.exgruOperacion.Location = New System.Drawing.Point(0, 0)
        Me.exgruOperacion.Name = "exgruOperacion"
        Me.exgruOperacion.Size = New System.Drawing.Size(425, 277)
        Me.exgruOperacion.TabIndex = 1
        Me.exgruOperacion.TabStop = False
        Me.exgruOperacion.Text = "Datos Generales de la Operacion"
        Me.exgruOperacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraGroupBox7)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.verValidaciones)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraGroupBox5)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraGroupBox1)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.chkMotriz)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel65)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.txtCodigoOperacion)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.cboActividadNegocio)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.txtIdEstadoOperacion)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.txtIdOperacion)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel22)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.cboRutaOrigen)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.cboTipoVehiculo)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel24)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.txtObservacionOperacion)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraLabel36)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.cboRutaDestino)
        Me.UltraExpandableGroupBoxPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(402, 271)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        '
        'UltraLabel2
        '
        Appearance340.BackColor = System.Drawing.Color.Transparent
        Appearance340.ForeColor = System.Drawing.Color.Navy
        Appearance340.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance340
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(187, 11)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "Operacion:"
        '
        'UltraGroupBox7
        '
        Appearance341.BackColor = System.Drawing.Color.White
        Appearance341.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox7.ContentAreaAppearance = Appearance341
        Me.UltraGroupBox7.Controls.Add(Me.hOperacion)
        Me.UltraGroupBox7.Controls.Add(Me.fecOperacion)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel33)
        Me.UltraGroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox7.Location = New System.Drawing.Point(3, 125)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(395, 33)
        Me.UltraGroupBox7.TabIndex = 11
        Me.UltraGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'hOperacion
        '
        Me.hOperacion.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.hOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.hOperacion.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.hOperacion.Location = New System.Drawing.Point(203, 5)
        Me.hOperacion.MaskInput = "{LOC}hh:mm"
        Me.hOperacion.Name = "hOperacion"
        Me.hOperacion.Nullable = False
        Me.hOperacion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.hOperacion.Size = New System.Drawing.Size(55, 21)
        Me.hOperacion.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.hOperacion.TabIndex = 9
        Me.hOperacion.Tag = ""
        UltraToolTipInfo21.ToolTipText = "Hora de Inicio del Viaje - Salida de Planta"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.hOperacion, UltraToolTipInfo21)
        Me.hOperacion.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecOperacion
        '
        Me.fecOperacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecOperacion.Location = New System.Drawing.Point(93, 5)
        Me.fecOperacion.Name = "fecOperacion"
        Me.fecOperacion.Size = New System.Drawing.Size(105, 20)
        Me.fecOperacion.TabIndex = 8
        '
        'UltraLabel33
        '
        Appearance342.BackColor = System.Drawing.Color.Transparent
        Appearance342.ForeColor = System.Drawing.Color.Navy
        Appearance342.TextVAlignAsString = "Middle"
        Me.UltraLabel33.Appearance = Appearance342
        Me.UltraLabel33.AutoSize = True
        Me.UltraLabel33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel33.Location = New System.Drawing.Point(2, 8)
        Me.UltraLabel33.Name = "UltraLabel33"
        Me.UltraLabel33.Size = New System.Drawing.Size(88, 14)
        Me.UltraLabel33.TabIndex = 11
        Me.UltraLabel33.Text = "F. Programacion:"
        '
        'verValidaciones
        '
        Appearance343.FontData.BoldAsString = "True"
        Appearance343.ForeColor = System.Drawing.Color.Navy
        Me.verValidaciones.Appearance = Appearance343
        Me.verValidaciones.AutoSize = True
        Me.verValidaciones.BackColor = System.Drawing.Color.Transparent
        Me.verValidaciones.BackColorInternal = System.Drawing.Color.Transparent
        Me.verValidaciones.Checked = True
        Me.verValidaciones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verValidaciones.Location = New System.Drawing.Point(352, 80)
        Me.verValidaciones.Name = "verValidaciones"
        Me.verValidaciones.Size = New System.Drawing.Size(43, 18)
        Me.verValidaciones.TabIndex = 7
        Me.verValidaciones.Text = "V.A."
        UltraToolTipInfo22.ToolTipText = "Validaciones Activas"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.verValidaciones, UltraToolTipInfo22)
        Me.verValidaciones.Visible = False
        '
        'UltraGroupBox5
        '
        Appearance344.BackColor = System.Drawing.Color.White
        Appearance344.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox5.ContentAreaAppearance = Appearance344
        Me.UltraGroupBox5.Controls.Add(Me.NroTurno)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox5.Controls.Add(Me.opcNocheDia)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel27)
        Me.UltraGroupBox5.Controls.Add(Me.NroVueltas)
        Me.UltraGroupBox5.Controls.Add(Me.verProgramarViajeBloque)
        Me.UltraGroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox5.Location = New System.Drawing.Point(3, 156)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(395, 48)
        Me.UltraGroupBox5.TabIndex = 12
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'NroTurno
        '
        Me.NroTurno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NroTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NroTurno.Location = New System.Drawing.Point(272, 8)
        Me.NroTurno.MaskInput = "nn"
        Me.NroTurno.MaxValue = 99
        Me.NroTurno.MinValue = 0
        Me.NroTurno.Name = "NroTurno"
        Me.NroTurno.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.NroTurno.Size = New System.Drawing.Size(40, 21)
        Me.NroTurno.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NroTurno.TabIndex = 12
        Me.NroTurno.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.NroTurno.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI
        '
        'UltraLabel8
        '
        Appearance345.BackColor = System.Drawing.Color.Transparent
        Appearance345.ForeColor = System.Drawing.Color.Navy
        Appearance345.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance345
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(7, 13)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel8.TabIndex = 6
        Me.UltraLabel8.Text = "Nº Vueltas:"
        '
        'opcNocheDia
        '
        Appearance346.ForeColor = System.Drawing.Color.Navy
        Me.opcNocheDia.Appearance = Appearance346
        Me.opcNocheDia.BackColor = System.Drawing.Color.Transparent
        Me.opcNocheDia.BackColorInternal = System.Drawing.Color.Transparent
        Me.opcNocheDia.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcNocheDia.CheckedIndex = 1
        Me.opcNocheDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcNocheDia.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem5.DataValue = "Default Item"
        ValueListItem5.DisplayText = "Noche (0)"
        ValueListItem6.DataValue = "ValueListItem1"
        ValueListItem6.DisplayText = "Dia (1)"
        Me.opcNocheDia.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
        Me.opcNocheDia.Location = New System.Drawing.Point(324, 5)
        Me.opcNocheDia.Name = "opcNocheDia"
        Me.opcNocheDia.Size = New System.Drawing.Size(70, 30)
        Me.opcNocheDia.TabIndex = 13
        Me.opcNocheDia.Text = "Dia (1)"
        '
        'UltraLabel27
        '
        Appearance347.BackColor = System.Drawing.Color.Transparent
        Appearance347.ForeColor = System.Drawing.Color.Navy
        Appearance347.TextVAlignAsString = "Middle"
        Me.UltraLabel27.Appearance = Appearance347
        Me.UltraLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel27.Location = New System.Drawing.Point(226, 4)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(45, 28)
        Me.UltraLabel27.TabIndex = 9
        Me.UltraLabel27.Text = "Turno Bloque:"
        '
        'NroVueltas
        '
        Me.NroVueltas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NroVueltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NroVueltas.Location = New System.Drawing.Point(68, 9)
        Me.NroVueltas.MaskInput = "n"
        Me.NroVueltas.MaxValue = 5
        Me.NroVueltas.MinValue = 1
        Me.NroVueltas.Name = "NroVueltas"
        Me.NroVueltas.Nullable = True
        Me.NroVueltas.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.NroVueltas.Size = New System.Drawing.Size(40, 21)
        Me.NroVueltas.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NroVueltas.TabIndex = 10
        Me.NroVueltas.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.NroVueltas.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI
        Me.NroVueltas.Value = 1
        '
        'verProgramarViajeBloque
        '
        Appearance348.FontData.BoldAsString = "False"
        Appearance348.FontData.ItalicAsString = "False"
        Appearance348.ForeColor = System.Drawing.Color.Navy
        Me.verProgramarViajeBloque.Appearance = Appearance348
        Me.verProgramarViajeBloque.BackColor = System.Drawing.Color.Transparent
        Me.verProgramarViajeBloque.BackColorInternal = System.Drawing.Color.Transparent
        Me.verProgramarViajeBloque.Location = New System.Drawing.Point(120, 3)
        Me.verProgramarViajeBloque.Name = "verProgramarViajeBloque"
        Me.verProgramarViajeBloque.Size = New System.Drawing.Size(100, 38)
        Me.verProgramarViajeBloque.TabIndex = 11
        Me.verProgramarViajeBloque.Text = "Programo Viajes Por Turno"
        '
        'UltraGroupBox1
        '
        Appearance349.BackColor = System.Drawing.Color.White
        Appearance349.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance349
        Me.UltraGroupBox1.Controls.Add(Me.lblFlota)
        Me.UltraGroupBox1.Controls.Add(Me.chkIndTercero)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox1.Controls.Add(Me.cboMoneda)
        Me.UltraGroupBox1.Controls.Add(Me.txtCantidadOperacion)
        Me.UltraGroupBox1.Controls.Add(Me.txtFUnitarioOperacion)
        Me.UltraGroupBox1.Controls.Add(Me.cboRutaOperacion)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel21)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox1.Controls.Add(Me.txtFTotalOperacion)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.txtCarga)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.Location = New System.Drawing.Point(3, 202)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(395, 70)
        Me.UltraGroupBox1.TabIndex = 13
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'lblFlota
        '
        Appearance350.BackColor = System.Drawing.Color.Transparent
        Appearance350.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance350.TextVAlignAsString = "Middle"
        Me.lblFlota.Appearance = Appearance350
        Me.lblFlota.AutoSize = True
        Me.lblFlota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlota.Location = New System.Drawing.Point(149, 48)
        Me.lblFlota.Name = "lblFlota"
        Me.lblFlota.Size = New System.Drawing.Size(61, 19)
        Me.lblFlota.TabIndex = 15
        Me.lblFlota.Text = "FLOTA:"
        '
        'chkIndTercero
        '
        Appearance351.FontData.BoldAsString = "True"
        Appearance351.FontData.ItalicAsString = "False"
        Appearance351.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkIndTercero.Appearance = Appearance351
        Me.chkIndTercero.AutoSize = True
        Me.chkIndTercero.BackColor = System.Drawing.Color.Transparent
        Me.chkIndTercero.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkIndTercero.Location = New System.Drawing.Point(12, 49)
        Me.chkIndTercero.Name = "chkIndTercero"
        Me.chkIndTercero.Size = New System.Drawing.Size(96, 17)
        Me.chkIndTercero.TabIndex = 20
        Me.chkIndTercero.Text = "TERCERIZAC"
        Me.chkIndTercero.Visible = False
        '
        'UltraLabel7
        '
        Appearance352.BackColor = System.Drawing.Color.Transparent
        Appearance352.ForeColor = System.Drawing.Color.Navy
        Appearance352.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance352
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(103, 27)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel7.TabIndex = 8
        Me.UltraLabel7.Text = "Cant.O: "
        '
        'cboMoneda
        '
        Appearance353.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance353
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(149, 2)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(50, 21)
        Me.cboMoneda.TabIndex = 15
        Me.cboMoneda.ValueMember = "Id"
        '
        'txtCantidadOperacion
        '
        Me.txtCantidadOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCantidadOperacion.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCantidadOperacion.Enabled = False
        Me.txtCantidadOperacion.InputMask = "{LOC}nnnn.nn"
        Me.txtCantidadOperacion.Location = New System.Drawing.Point(149, 25)
        Me.txtCantidadOperacion.Name = "txtCantidadOperacion"
        Me.txtCantidadOperacion.NonAutoSizeHeight = 20
        Me.txtCantidadOperacion.ReadOnly = True
        Me.txtCantidadOperacion.Size = New System.Drawing.Size(50, 20)
        Me.txtCantidadOperacion.TabIndex = 18
        Me.txtCantidadOperacion.Text = "0.00"
        '
        'txtFUnitarioOperacion
        '
        Me.txtFUnitarioOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFUnitarioOperacion.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtFUnitarioOperacion.Enabled = False
        Me.txtFUnitarioOperacion.InputMask = "{LOC}nnn,nnn.nnnn"
        Me.txtFUnitarioOperacion.Location = New System.Drawing.Point(277, 3)
        Me.txtFUnitarioOperacion.Name = "txtFUnitarioOperacion"
        Me.txtFUnitarioOperacion.NonAutoSizeHeight = 20
        Me.txtFUnitarioOperacion.NullText = "0.0000"
        Me.txtFUnitarioOperacion.ReadOnly = True
        Me.txtFUnitarioOperacion.Size = New System.Drawing.Size(80, 20)
        Me.txtFUnitarioOperacion.TabIndex = 16
        Me.txtFUnitarioOperacion.Text = "0.0000"
        '
        'cboRutaOperacion
        '
        Appearance354.ForeColor = System.Drawing.Color.Black
        Me.cboRutaOperacion.Appearance = Appearance354
        Me.cboRutaOperacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboRutaOperacion.ButtonsRight.Add(EditorButton15)
        Me.cboRutaOperacion.DisplayMember = "Nombre"
        Me.cboRutaOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRutaOperacion.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.cboRutaOperacion.DropDownListWidth = 500
        Me.cboRutaOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRutaOperacion.ForeColor = System.Drawing.Color.Black
        Me.cboRutaOperacion.ImageList = Me.imagenes
        Me.cboRutaOperacion.Location = New System.Drawing.Point(68, 3)
        Me.cboRutaOperacion.Name = "cboRutaOperacion"
        Me.cboRutaOperacion.Size = New System.Drawing.Size(23, 21)
        Me.cboRutaOperacion.TabIndex = 14
        Me.cboRutaOperacion.ValueMember = "Id"
        '
        'UltraLabel21
        '
        Appearance355.BackColor = System.Drawing.Color.Transparent
        Appearance355.ForeColor = System.Drawing.Color.Navy
        Appearance355.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance355
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(99, 4)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel21.TabIndex = 4
        Me.UltraLabel21.Text = "Moneda:"
        '
        'UltraLabel10
        '
        Appearance356.BackColor = System.Drawing.Color.Transparent
        Appearance356.ForeColor = System.Drawing.Color.Navy
        Appearance356.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance356
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(208, 5)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel10.TabIndex = 6
        Me.UltraLabel10.Text = "Flete Unit.O: "
        '
        'txtFTotalOperacion
        '
        Me.txtFTotalOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFTotalOperacion.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtFTotalOperacion.Enabled = False
        Me.txtFTotalOperacion.InputMask = "{LOC}nnn,nnn.nnnn"
        Me.txtFTotalOperacion.Location = New System.Drawing.Point(277, 25)
        Me.txtFTotalOperacion.Name = "txtFTotalOperacion"
        Me.txtFTotalOperacion.NonAutoSizeHeight = 20
        Me.txtFTotalOperacion.ReadOnly = True
        Me.txtFTotalOperacion.Size = New System.Drawing.Size(80, 20)
        Me.txtFTotalOperacion.TabIndex = 19
        Me.txtFTotalOperacion.Text = "0.0000"
        '
        'UltraLabel5
        '
        Appearance357.BackColor = System.Drawing.Color.Transparent
        Appearance357.ForeColor = System.Drawing.Color.Navy
        Appearance357.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance357
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(203, 27)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel5.TabIndex = 10
        Me.UltraLabel5.Text = "Flete Total.O: "
        '
        'txtCarga
        '
        Me.txtCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCarga.Enabled = False
        Me.txtCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarga.Location = New System.Drawing.Point(68, 25)
        Me.txtCarga.Name = "txtCarga"
        Me.txtCarga.ReadOnly = True
        Me.txtCarga.Size = New System.Drawing.Size(23, 21)
        Me.txtCarga.TabIndex = 17
        '
        'UltraLabel3
        '
        Appearance358.BackColor = System.Drawing.Color.Transparent
        Appearance358.ForeColor = System.Drawing.Color.Navy
        Appearance358.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance358
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(33, 6)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Ruta:"
        '
        'UltraLabel4
        '
        Appearance359.BackColor = System.Drawing.Color.Transparent
        Appearance359.ForeColor = System.Drawing.Color.Navy
        Appearance359.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance359
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(26, 28)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel4.TabIndex = 2
        Me.UltraLabel4.Text = "Carga: "
        '
        'chkMotriz
        '
        Appearance360.FontData.BoldAsString = "False"
        Appearance360.ForeColor = System.Drawing.Color.Navy
        Me.chkMotriz.Appearance = Appearance360
        Me.chkMotriz.AutoSize = True
        Me.chkMotriz.Enabled = False
        Me.chkMotriz.Location = New System.Drawing.Point(279, 79)
        Me.chkMotriz.Name = "chkMotriz"
        Me.chkMotriz.Size = New System.Drawing.Size(52, 18)
        Me.chkMotriz.TabIndex = 6
        Me.chkMotriz.Text = "Motriz"
        '
        'UltraLabel65
        '
        Appearance361.BackColor = System.Drawing.Color.Transparent
        Appearance361.ForeColor = System.Drawing.Color.Navy
        Appearance361.TextVAlignAsString = "Middle"
        Me.UltraLabel65.Appearance = Appearance361
        Me.UltraLabel65.AutoSize = True
        Me.UltraLabel65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel65.Location = New System.Drawing.Point(11, 79)
        Me.UltraLabel65.Name = "UltraLabel65"
        Me.UltraLabel65.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel65.TabIndex = 15
        Me.UltraLabel65.Text = "M. Func V:"
        '
        'txtCodigoOperacion
        '
        Me.txtCodigoOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoOperacion.Location = New System.Drawing.Point(73, 7)
        Me.txtCodigoOperacion.Name = "txtCodigoOperacion"
        Me.txtCodigoOperacion.ReadOnly = True
        Me.txtCodigoOperacion.Size = New System.Drawing.Size(110, 21)
        Me.txtCodigoOperacion.TabIndex = 1
        '
        'cboActividadNegocio
        '
        Appearance362.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.Appearance = Appearance362
        Me.cboActividadNegocio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboActividadNegocio.DisplayMember = "Nombre"
        Me.cboActividadNegocio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboActividadNegocio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboActividadNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboActividadNegocio.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.ImageList = Me.imagenes
        Me.cboActividadNegocio.Location = New System.Drawing.Point(248, 7)
        Me.cboActividadNegocio.Name = "cboActividadNegocio"
        Me.cboActividadNegocio.Size = New System.Drawing.Size(150, 21)
        Me.cboActividadNegocio.TabIndex = 2
        Me.cboActividadNegocio.ValueMember = "Id"
        '
        'txtIdEstadoOperacion
        '
        Me.txtIdEstadoOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdEstadoOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEstadoOperacion.Location = New System.Drawing.Point(184, 7)
        Me.txtIdEstadoOperacion.Name = "txtIdEstadoOperacion"
        Me.txtIdEstadoOperacion.ReadOnly = True
        Me.txtIdEstadoOperacion.Size = New System.Drawing.Size(21, 21)
        Me.txtIdEstadoOperacion.TabIndex = 2
        Me.txtIdEstadoOperacion.Visible = False
        '
        'txtIdOperacion
        '
        Me.txtIdOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacion.Location = New System.Drawing.Point(207, 7)
        Me.txtIdOperacion.Name = "txtIdOperacion"
        Me.txtIdOperacion.ReadOnly = True
        Me.txtIdOperacion.Size = New System.Drawing.Size(21, 21)
        Me.txtIdOperacion.TabIndex = 5
        Me.txtIdOperacion.Visible = False
        '
        'UltraLabel22
        '
        Appearance363.BackColor = System.Drawing.Color.Transparent
        Appearance363.ForeColor = System.Drawing.Color.Navy
        Appearance363.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance363
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(9, 35)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(57, 15)
        Me.UltraLabel22.TabIndex = 5
        Me.UltraLabel22.Text = "Origen OP:"
        '
        'cboRutaOrigen
        '
        Appearance364.ForeColor = System.Drawing.Color.Black
        Me.cboRutaOrigen.Appearance = Appearance364
        Me.cboRutaOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboRutaOrigen.DisplayMember = "Nombre"
        Me.cboRutaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRutaOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboRutaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRutaOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboRutaOrigen.Location = New System.Drawing.Point(73, 31)
        Me.cboRutaOrigen.Name = "cboRutaOrigen"
        Me.cboRutaOrigen.Size = New System.Drawing.Size(325, 21)
        Me.cboRutaOrigen.TabIndex = 3
        Me.cboRutaOrigen.ValueMember = "Id"
        '
        'cboTipoVehiculo
        '
        Appearance365.ForeColor = System.Drawing.Color.Black
        Me.cboTipoVehiculo.Appearance = Appearance365
        Me.cboTipoVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoVehiculo.DisplayMember = "Nombre"
        Me.cboTipoVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoVehiculo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoVehiculo.ForeColor = System.Drawing.Color.Black
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(73, 77)
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(198, 21)
        Me.cboTipoVehiculo.TabIndex = 5
        Me.cboTipoVehiculo.ValueMember = "Id"
        '
        'UltraLabel24
        '
        Appearance366.BackColor = System.Drawing.Color.Transparent
        Appearance366.ForeColor = System.Drawing.Color.Navy
        Appearance366.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance366
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(5, 58)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(62, 15)
        Me.UltraLabel24.TabIndex = 7
        Me.UltraLabel24.Text = "Destino OP:"
        '
        'txtObservacionOperacion
        '
        Me.txtObservacionOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionOperacion.Location = New System.Drawing.Point(3, 100)
        Me.txtObservacionOperacion.Multiline = True
        Me.txtObservacionOperacion.Name = "txtObservacionOperacion"
        Me.txtObservacionOperacion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionOperacion.Size = New System.Drawing.Size(394, 25)
        Me.txtObservacionOperacion.TabIndex = 10
        UltraToolTipInfo23.ToolTipText = "Descripcion de la Operacion"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtObservacionOperacion, UltraToolTipInfo23)
        '
        'UltraLabel36
        '
        Appearance367.BackColor = System.Drawing.Color.Transparent
        Appearance367.ForeColor = System.Drawing.Color.Navy
        Appearance367.TextVAlignAsString = "Middle"
        Me.UltraLabel36.Appearance = Appearance367
        Me.UltraLabel36.AutoSize = True
        Me.UltraLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel36.Location = New System.Drawing.Point(8, 11)
        Me.UltraLabel36.Name = "UltraLabel36"
        Me.UltraLabel36.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel36.TabIndex = 0
        Me.UltraLabel36.Text = "Código OP:"
        '
        'cboRutaDestino
        '
        Appearance368.ForeColor = System.Drawing.Color.Black
        Me.cboRutaDestino.Appearance = Appearance368
        Me.cboRutaDestino.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboRutaDestino.DisplayMember = "Destino"
        Me.cboRutaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRutaDestino.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboRutaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRutaDestino.ForeColor = System.Drawing.Color.Black
        Me.cboRutaDestino.Location = New System.Drawing.Point(73, 54)
        Me.cboRutaDestino.Name = "cboRutaDestino"
        Me.cboRutaDestino.Size = New System.Drawing.Size(325, 21)
        Me.cboRutaDestino.TabIndex = 4
        Me.cboRutaDestino.ValueMember = "IdDestino"
        '
        'ogdVehiculoEstadoSituacional
        '
        Me.ogdVehiculoEstadoSituacional.Band.Columns.AddRange(New Object() {UltraDataColumn369, UltraDataColumn370, UltraDataColumn371, UltraDataColumn372, UltraDataColumn373, UltraDataColumn374, UltraDataColumn375, UltraDataColumn376, UltraDataColumn377, UltraDataColumn378, UltraDataColumn379, UltraDataColumn380, UltraDataColumn381, UltraDataColumn382, UltraDataColumn383})
        '
        'utpDetalle
        '
        Me.utpDetalle.Location = New System.Drawing.Point(0, 0)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(200, 100)
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(200, 110)
        Me.UltraGroupBox6.TabIndex = 0
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Location = New System.Drawing.Point(3, -91)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(190, 40)
        Me.UltraGroupBox3.TabIndex = 302
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl1.Size = New System.Drawing.Size(200, 100)
        Me.UltraTabControl1.TabIndex = 0
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(196, 77)
        '
        'Colores1
        '
        Me.Colores1.Location = New System.Drawing.Point(389, 5)
        Me.Colores1.Name = "Colores1"
        Me.Colores1.Size = New System.Drawing.Size(44, 21)
        Me.Colores1.TabIndex = 7
        Me.Colores1.Text = "Control"
        '
        'Colores2
        '
        Me.Colores2.Location = New System.Drawing.Point(74, 5)
        Me.Colores2.Name = "Colores2"
        Me.Colores2.Size = New System.Drawing.Size(43, 21)
        Me.Colores2.TabIndex = 1
        Me.Colores2.Text = "Control"
        '
        'Colores3
        '
        Me.Colores3.Location = New System.Drawing.Point(474, 5)
        Me.Colores3.Name = "Colores3"
        Me.Colores3.Size = New System.Drawing.Size(44, 21)
        Me.Colores3.TabIndex = 9
        Me.Colores3.Text = "Control"
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(13, 9)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta9.TabIndex = 0
        Me.Etiqueta9.Text = "Plataforma:"
        '
        'Etiqueta10
        '
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(438, 9)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(34, 14)
        Me.Etiqueta10.TabIndex = 8
        Me.Etiqueta10.Text = "Tolva:"
        '
        'Etiqueta11
        '
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(340, 9)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(48, 14)
        Me.Etiqueta11.TabIndex = 6
        Me.Etiqueta11.Text = "Cisterna:"
        '
        'Colores4
        '
        Me.Colores4.Location = New System.Drawing.Point(164, 4)
        Me.Colores4.Name = "Colores4"
        Me.Colores4.Size = New System.Drawing.Size(43, 21)
        Me.Colores4.TabIndex = 3
        Me.Colores4.Text = "Control"
        '
        'Colores5
        '
        Me.Colores5.Location = New System.Drawing.Point(286, 4)
        Me.Colores5.Name = "Colores5"
        Me.Colores5.Size = New System.Drawing.Size(44, 21)
        Me.Colores5.TabIndex = 5
        Me.Colores5.Text = "Control"
        '
        'Etiqueta12
        '
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(121, 8)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(42, 14)
        Me.Etiqueta12.TabIndex = 2
        Me.Etiqueta12.Text = "Furgon:"
        '
        'Etiqueta13
        '
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(212, 8)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(73, 14)
        Me.Etiqueta13.TabIndex = 4
        Me.Etiqueta13.Text = "Furgon Largo:"
        '
        'UltraButton2
        '
        Appearance390.Image = "add.ico"
        Me.UltraButton2.Appearance = Appearance390
        Me.UltraButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.UltraButton2.Location = New System.Drawing.Point(599, 69)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(30, 30)
        Me.UltraButton2.TabIndex = 21
        '
        'UltraLabel45
        '
        Appearance391.BackColor = System.Drawing.Color.Transparent
        Appearance391.ForeColor = System.Drawing.Color.Navy
        Appearance391.TextVAlignAsString = "Middle"
        Me.UltraLabel45.Appearance = Appearance391
        Me.UltraLabel45.AutoSize = True
        Me.UltraLabel45.Location = New System.Drawing.Point(384, 55)
        Me.UltraLabel45.Name = "UltraLabel45"
        Me.UltraLabel45.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel45.TabIndex = 14
        Me.UltraLabel45.Text = "Flete Total: "
        '
        'UltraMaskedEdit6
        '
        Appearance392.TextHAlignAsString = "Right"
        Me.UltraMaskedEdit6.Appearance = Appearance392
        Me.UltraMaskedEdit6.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit6.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.UltraMaskedEdit6.InputMask = "{double:10.4}"
        Me.UltraMaskedEdit6.Location = New System.Drawing.Point(448, 52)
        Me.UltraMaskedEdit6.Name = "UltraMaskedEdit6"
        Me.UltraMaskedEdit6.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit6.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UltraMaskedEdit6.ReadOnly = True
        Me.UltraMaskedEdit6.Size = New System.Drawing.Size(105, 20)
        Me.UltraMaskedEdit6.TabIndex = 15
        Me.UltraMaskedEdit6.Text = "00.000"
        '
        'Agrupacion2
        '
        Appearance393.BackColor = System.Drawing.Color.White
        Appearance393.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion2.ContentAreaAppearance = Appearance393
        Me.Agrupacion2.Controls.Add(Me.UltraCheckEditor4)
        Me.Agrupacion2.Controls.Add(Me.UltraCheckEditor5)
        Me.Agrupacion2.Controls.Add(Me.UltraCheckEditor6)
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.Agrupacion2.Location = New System.Drawing.Point(637, 3)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(95, 95)
        Me.Agrupacion2.TabIndex = 26
        Me.Agrupacion2.Text = "Incluye Pagos "
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraCheckEditor4
        '
        Appearance394.ForeColor = System.Drawing.Color.Navy
        Me.UltraCheckEditor4.Appearance = Appearance394
        Me.UltraCheckEditor4.Location = New System.Drawing.Point(6, 24)
        Me.UltraCheckEditor4.Name = "UltraCheckEditor4"
        Me.UltraCheckEditor4.Size = New System.Drawing.Size(60, 20)
        Me.UltraCheckEditor4.TabIndex = 24
        Me.UltraCheckEditor4.Text = "Cargar"
        '
        'UltraCheckEditor5
        '
        Appearance395.ForeColor = System.Drawing.Color.Navy
        Me.UltraCheckEditor5.Appearance = Appearance395
        Me.UltraCheckEditor5.Location = New System.Drawing.Point(6, 44)
        Me.UltraCheckEditor5.Name = "UltraCheckEditor5"
        Me.UltraCheckEditor5.Size = New System.Drawing.Size(70, 20)
        Me.UltraCheckEditor5.TabIndex = 25
        Me.UltraCheckEditor5.Text = "Descarga"
        '
        'UltraCheckEditor6
        '
        Appearance396.ForeColor = System.Drawing.Color.Navy
        Me.UltraCheckEditor6.Appearance = Appearance396
        Me.UltraCheckEditor6.Location = New System.Drawing.Point(6, 64)
        Me.UltraCheckEditor6.Name = "UltraCheckEditor6"
        Me.UltraCheckEditor6.Size = New System.Drawing.Size(83, 25)
        Me.UltraCheckEditor6.TabIndex = 9
        Me.UltraCheckEditor6.Text = "Pago Contra Entrega"
        '
        'Agrupacion5
        '
        Appearance397.BackColor = System.Drawing.Color.White
        Appearance397.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion5.ContentAreaAppearance = Appearance397
        Me.Agrupacion5.Controls.Add(Me.UltraMaskedEdit7)
        Me.Agrupacion5.Controls.Add(Me.UltraLabel46)
        Me.Agrupacion5.Controls.Add(Me.UltraMaskedEdit8)
        Me.Agrupacion5.Controls.Add(Me.UltraLabel47)
        Me.Agrupacion5.Controls.Add(Me.UltraMaskedEdit9)
        Me.Agrupacion5.Controls.Add(Me.UltraLabel48)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.Agrupacion5.Location = New System.Drawing.Point(738, 3)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(180, 95)
        Me.Agrupacion5.TabIndex = 23
        Me.Agrupacion5.Text = "Fletes: Para la Demanda "
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraMaskedEdit7
        '
        Appearance398.TextHAlignAsString = "Right"
        Me.UltraMaskedEdit7.Appearance = Appearance398
        Me.UltraMaskedEdit7.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit7.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.UltraMaskedEdit7.Enabled = False
        Me.UltraMaskedEdit7.InputMask = "{double:6.4}"
        Me.UltraMaskedEdit7.Location = New System.Drawing.Point(93, 71)
        Me.UltraMaskedEdit7.Name = "UltraMaskedEdit7"
        Me.UltraMaskedEdit7.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit7.Size = New System.Drawing.Size(70, 20)
        Me.UltraMaskedEdit7.TabIndex = 5
        Me.UltraMaskedEdit7.Text = "00.000"
        '
        'UltraLabel46
        '
        Appearance399.BackColor = System.Drawing.Color.Transparent
        Appearance399.ForeColor = System.Drawing.Color.Navy
        Appearance399.TextVAlignAsString = "Middle"
        Me.UltraLabel46.Appearance = Appearance399
        Me.UltraLabel46.AutoSize = True
        Me.UltraLabel46.Location = New System.Drawing.Point(15, 74)
        Me.UltraLabel46.Name = "UltraLabel46"
        Me.UltraLabel46.Size = New System.Drawing.Size(75, 14)
        Me.UltraLabel46.TabIndex = 4
        Me.UltraLabel46.Text = "F. Tecnico S/.:"
        '
        'UltraMaskedEdit8
        '
        Appearance400.TextHAlignAsString = "Right"
        Me.UltraMaskedEdit8.Appearance = Appearance400
        Me.UltraMaskedEdit8.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit8.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.UltraMaskedEdit8.Enabled = False
        Me.UltraMaskedEdit8.InputMask = "{double:6.4}"
        Me.UltraMaskedEdit8.Location = New System.Drawing.Point(93, 47)
        Me.UltraMaskedEdit8.Name = "UltraMaskedEdit8"
        Me.UltraMaskedEdit8.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit8.Size = New System.Drawing.Size(70, 20)
        Me.UltraMaskedEdit8.TabIndex = 3
        Me.UltraMaskedEdit8.Text = "00.000"
        '
        'UltraLabel47
        '
        Appearance401.BackColor = System.Drawing.Color.Transparent
        Appearance401.ForeColor = System.Drawing.Color.Navy
        Appearance401.TextVAlignAsString = "Middle"
        Me.UltraLabel47.Appearance = Appearance401
        Me.UltraLabel47.AutoSize = True
        Me.UltraLabel47.Location = New System.Drawing.Point(12, 50)
        Me.UltraLabel47.Name = "UltraLabel47"
        Me.UltraLabel47.Size = New System.Drawing.Size(78, 14)
        Me.UltraLabel47.TabIndex = 2
        Me.UltraLabel47.Text = "F. Contrato S/.:"
        '
        'UltraMaskedEdit9
        '
        Appearance402.TextHAlignAsString = "Right"
        Me.UltraMaskedEdit9.Appearance = Appearance402
        Me.UltraMaskedEdit9.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit9.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.UltraMaskedEdit9.Enabled = False
        Me.UltraMaskedEdit9.InputMask = "{double:6.4}"
        Me.UltraMaskedEdit9.Location = New System.Drawing.Point(93, 23)
        Me.UltraMaskedEdit9.Name = "UltraMaskedEdit9"
        Me.UltraMaskedEdit9.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit9.Size = New System.Drawing.Size(70, 20)
        Me.UltraMaskedEdit9.TabIndex = 1
        Me.UltraMaskedEdit9.Text = "00.000"
        '
        'UltraLabel48
        '
        Appearance403.BackColor = System.Drawing.Color.Transparent
        Appearance403.ForeColor = System.Drawing.Color.Navy
        Appearance403.TextVAlignAsString = "Middle"
        Me.UltraLabel48.Appearance = Appearance403
        Me.UltraLabel48.AutoSize = True
        Me.UltraLabel48.Location = New System.Drawing.Point(8, 26)
        Me.UltraLabel48.Name = "UltraLabel48"
        Me.UltraLabel48.Size = New System.Drawing.Size(82, 14)
        Me.UltraLabel48.TabIndex = 0
        Me.UltraLabel48.Text = "F. Estimado S/.:"
        '
        'UltraLabel49
        '
        Appearance404.BackColor = System.Drawing.Color.Transparent
        Appearance404.ForeColor = System.Drawing.Color.Navy
        Appearance404.TextVAlignAsString = "Middle"
        Me.UltraLabel49.Appearance = Appearance404
        Me.UltraLabel49.Location = New System.Drawing.Point(397, 7)
        Me.UltraLabel49.Name = "UltraLabel49"
        Me.UltraLabel49.Size = New System.Drawing.Size(75, 42)
        Me.UltraLabel49.TabIndex = 10
        Me.UltraLabel49.Text = "Flete Unitario (Sin IGV): "
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.Combo4)
        Me.UltraGroupBox4.Controls.Add(Me.UltraMaskedEdit10)
        Me.UltraGroupBox4.Controls.Add(Me.UltraMaskedEdit11)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel50)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel51)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel52)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(972, 2)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(200, 94)
        Me.UltraGroupBox4.TabIndex = 0
        Me.UltraGroupBox4.Visible = False
        '
        'Combo4
        '
        Appearance405.ForeColor = System.Drawing.Color.Black
        Me.Combo4.Appearance = Appearance405
        Me.Combo4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Combo4.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.Combo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo4.ForeColor = System.Drawing.Color.Black
        Me.Combo4.Location = New System.Drawing.Point(8, 23)
        Me.Combo4.Name = "Combo4"
        Me.Combo4.Size = New System.Drawing.Size(50, 21)
        Me.Combo4.TabIndex = 1
        Me.Combo4.ValueMember = "Id"
        '
        'UltraMaskedEdit10
        '
        Me.UltraMaskedEdit10.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit10.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.UltraMaskedEdit10.InputMask = "{double:15.2}"
        Me.UltraMaskedEdit10.Location = New System.Drawing.Point(71, 68)
        Me.UltraMaskedEdit10.Name = "UltraMaskedEdit10"
        Me.UltraMaskedEdit10.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit10.ReadOnly = True
        Me.UltraMaskedEdit10.Size = New System.Drawing.Size(120, 20)
        Me.UltraMaskedEdit10.TabIndex = 5
        Me.UltraMaskedEdit10.Text = "000"
        '
        'UltraMaskedEdit11
        '
        Me.UltraMaskedEdit11.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit11.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.UltraMaskedEdit11.InputMask = "{double:15.2}"
        Me.UltraMaskedEdit11.Location = New System.Drawing.Point(71, 45)
        Me.UltraMaskedEdit11.Name = "UltraMaskedEdit11"
        Me.UltraMaskedEdit11.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit11.ReadOnly = True
        Me.UltraMaskedEdit11.Size = New System.Drawing.Size(120, 20)
        Me.UltraMaskedEdit11.TabIndex = 3
        Me.UltraMaskedEdit11.Text = "000"
        '
        'UltraLabel50
        '
        Appearance406.BackColor = System.Drawing.Color.Transparent
        Appearance406.ForeColor = System.Drawing.Color.Navy
        Appearance406.TextVAlignAsString = "Middle"
        Me.UltraLabel50.Appearance = Appearance406
        Me.UltraLabel50.AutoSize = True
        Me.UltraLabel50.Location = New System.Drawing.Point(3, 71)
        Me.UltraLabel50.Name = "UltraLabel50"
        Me.UltraLabel50.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel50.TabIndex = 4
        Me.UltraLabel50.Text = "Comision T: "
        '
        'UltraLabel51
        '
        Appearance407.BackColor = System.Drawing.Color.Transparent
        Appearance407.ForeColor = System.Drawing.Color.Navy
        Appearance407.TextVAlignAsString = "Middle"
        Me.UltraLabel51.Appearance = Appearance407
        Me.UltraLabel51.AutoSize = True
        Me.UltraLabel51.Location = New System.Drawing.Point(8, 7)
        Me.UltraLabel51.Name = "UltraLabel51"
        Me.UltraLabel51.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel51.TabIndex = 0
        Me.UltraLabel51.Text = "Moneda:"
        '
        'UltraLabel52
        '
        Appearance408.BackColor = System.Drawing.Color.Transparent
        Appearance408.ForeColor = System.Drawing.Color.Navy
        Appearance408.TextVAlignAsString = "Middle"
        Me.UltraLabel52.Appearance = Appearance408
        Me.UltraLabel52.AutoSize = True
        Me.UltraLabel52.Location = New System.Drawing.Point(7, 49)
        Me.UltraLabel52.Name = "UltraLabel52"
        Me.UltraLabel52.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel52.TabIndex = 2
        Me.UltraLabel52.Text = "Flete Total: "
        '
        'ComboMaestros5
        '
        Appearance409.ForeColor = System.Drawing.Color.Black
        Me.ComboMaestros5.Appearance = Appearance409
        Me.ComboMaestros5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance410.Image = 7
        EditorButton16.Appearance = Appearance410
        Me.ComboMaestros5.ButtonsRight.Add(EditorButton16)
        Me.ComboMaestros5.DisplayMember = "Nombre"
        Me.ComboMaestros5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ComboMaestros5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMaestros5.ForeColor = System.Drawing.Color.Black
        Me.ComboMaestros5.Location = New System.Drawing.Point(79, 3)
        Me.ComboMaestros5.Name = "ComboMaestros5"
        Me.ComboMaestros5.Size = New System.Drawing.Size(300, 21)
        Me.ComboMaestros5.TabIndex = 1
        Me.ComboMaestros5.ValueMember = "Id"
        '
        'UltraMaskedEdit12
        '
        Appearance411.TextHAlignAsString = "Right"
        Me.UltraMaskedEdit12.Appearance = Appearance411
        Me.UltraMaskedEdit12.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit12.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.UltraMaskedEdit12.InputMask = "{double:6.4}"
        Me.UltraMaskedEdit12.Location = New System.Drawing.Point(473, 27)
        Me.UltraMaskedEdit12.Name = "UltraMaskedEdit12"
        Me.UltraMaskedEdit12.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit12.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UltraMaskedEdit12.Size = New System.Drawing.Size(80, 20)
        Me.UltraMaskedEdit12.TabIndex = 11
        Me.UltraMaskedEdit12.Text = "00.000"
        '
        'UltraLabel53
        '
        Appearance412.BackColor = System.Drawing.Color.Transparent
        Appearance412.ForeColor = System.Drawing.Color.Navy
        Appearance412.TextVAlignAsString = "Middle"
        Me.UltraLabel53.Appearance = Appearance412
        Me.UltraLabel53.AutoSize = True
        Me.UltraLabel53.Location = New System.Drawing.Point(33, 7)
        Me.UltraLabel53.Name = "UltraLabel53"
        Me.UltraLabel53.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel53.TabIndex = 0
        Me.UltraLabel53.Text = "Cliente:"
        '
        'NumeroCalculadora1
        '
        Appearance413.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance413.TextHAlignAsString = "Right"
        Me.NumeroCalculadora1.Appearance = Appearance413
        CalculatorButton4.Key = "."
        CalculatorButton4.KeyCodeAlternateValue = 190
        CalculatorButton4.KeyCodeValue = 110
        CalculatorButton4.Text = ","
        Me.NumeroCalculadora1.Buttons.AddRange(New Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton() {CalculatorButton4})
        Appearance414.Image = "06_calculator.ico"
        EditorButton17.Appearance = Appearance414
        Me.NumeroCalculadora1.ButtonsLeft.Add(EditorButton17)
        Me.NumeroCalculadora1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroCalculadora1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.NumeroCalculadora1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroCalculadora1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.NumeroCalculadora1.Location = New System.Drawing.Point(473, 3)
        Me.NumeroCalculadora1.Name = "NumeroCalculadora1"
        Me.NumeroCalculadora1.NullText = "0.00"
        Me.NumeroCalculadora1.Size = New System.Drawing.Size(80, 21)
        Me.NumeroCalculadora1.TabIndex = 20
        Me.NumeroCalculadora1.Text = "0.0000"
        '
        'ComboMaestros6
        '
        Appearance415.ForeColor = System.Drawing.Color.Black
        Me.ComboMaestros6.Appearance = Appearance415
        Me.ComboMaestros6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance416.Image = 7
        EditorButton18.Appearance = Appearance416
        Me.ComboMaestros6.ButtonsRight.Add(EditorButton18)
        Me.ComboMaestros6.DisplayMember = "Nombre"
        Me.ComboMaestros6.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ComboMaestros6.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ComboMaestros6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMaestros6.ForeColor = System.Drawing.Color.Black
        Me.ComboMaestros6.Location = New System.Drawing.Point(79, 51)
        Me.ComboMaestros6.Name = "ComboMaestros6"
        Me.ComboMaestros6.Size = New System.Drawing.Size(175, 21)
        Me.ComboMaestros6.TabIndex = 5
        Me.ComboMaestros6.ValueMember = "Id"
        '
        'UltraLabel54
        '
        Appearance417.BackColor = System.Drawing.Color.Transparent
        Appearance417.ForeColor = System.Drawing.Color.Navy
        Appearance417.TextVAlignAsString = "Middle"
        Me.UltraLabel54.Appearance = Appearance417
        Me.UltraLabel54.AutoSize = True
        Me.UltraLabel54.Location = New System.Drawing.Point(13, 55)
        Me.UltraLabel54.Name = "UltraLabel54"
        Me.UltraLabel54.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel54.TabIndex = 4
        Me.UltraLabel54.Text = "Tipo Carga:"
        '
        'ComboMaestros7
        '
        Appearance418.ForeColor = System.Drawing.Color.Black
        Me.ComboMaestros7.Appearance = Appearance418
        Me.ComboMaestros7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance419.Image = 7
        EditorButton19.Appearance = Appearance419
        Me.ComboMaestros7.ButtonsRight.Add(EditorButton19)
        Me.ComboMaestros7.DisplayMember = "Nombre"
        Me.ComboMaestros7.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ComboMaestros7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMaestros7.ForeColor = System.Drawing.Color.Black
        Me.ComboMaestros7.Location = New System.Drawing.Point(79, 75)
        Me.ComboMaestros7.Name = "ComboMaestros7"
        Me.ComboMaestros7.Size = New System.Drawing.Size(300, 21)
        Me.ComboMaestros7.TabIndex = 7
        Me.ComboMaestros7.ValueMember = "Id"
        '
        'UltraLabel55
        '
        Appearance420.BackColor = System.Drawing.Color.Transparent
        Appearance420.ForeColor = System.Drawing.Color.Navy
        Appearance420.TextVAlignAsString = "Middle"
        Me.UltraLabel55.Appearance = Appearance420
        Me.UltraLabel55.AutoSize = True
        Me.UltraLabel55.Location = New System.Drawing.Point(263, 55)
        Me.UltraLabel55.Name = "UltraLabel55"
        Me.UltraLabel55.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel55.TabIndex = 12
        Me.UltraLabel55.Text = "Cantidad:"
        '
        'ComboMaestros8
        '
        Appearance421.ForeColor = System.Drawing.Color.Black
        Me.ComboMaestros8.Appearance = Appearance421
        Me.ComboMaestros8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance422.Image = 7
        EditorButton20.Appearance = Appearance422
        Me.ComboMaestros8.ButtonsRight.Add(EditorButton20)
        Me.ComboMaestros8.DisplayMember = "Nombre"
        Me.ComboMaestros8.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ComboMaestros8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMaestros8.ForeColor = System.Drawing.Color.Black
        Me.ComboMaestros8.Location = New System.Drawing.Point(79, 27)
        Me.ComboMaestros8.Name = "ComboMaestros8"
        Me.ComboMaestros8.Size = New System.Drawing.Size(300, 21)
        Me.ComboMaestros8.TabIndex = 3
        Me.ComboMaestros8.ValueMember = "Id"
        '
        'UltraLabel56
        '
        Appearance423.BackColor = System.Drawing.Color.Transparent
        Appearance423.ForeColor = System.Drawing.Color.Navy
        Appearance423.TextVAlignAsString = "Middle"
        Me.UltraLabel56.Appearance = Appearance423
        Me.UltraLabel56.AutoSize = True
        Me.UltraLabel56.Location = New System.Drawing.Point(28, 79)
        Me.UltraLabel56.Name = "UltraLabel56"
        Me.UltraLabel56.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel56.TabIndex = 6
        Me.UltraLabel56.Text = "Material:"
        '
        'UltraLabel57
        '
        Appearance424.BackColor = System.Drawing.Color.Transparent
        Appearance424.ForeColor = System.Drawing.Color.Navy
        Appearance424.TextVAlignAsString = "Middle"
        Me.UltraLabel57.Appearance = Appearance424
        Me.UltraLabel57.AutoSize = True
        Me.UltraLabel57.Location = New System.Drawing.Point(4, 31)
        Me.UltraLabel57.Name = "UltraLabel57"
        Me.UltraLabel57.Size = New System.Drawing.Size(72, 14)
        Me.UltraLabel57.TabIndex = 2
        Me.UltraLabel57.Text = "Comisionista:"
        '
        'UltraMaskedEdit13
        '
        Appearance425.TextHAlignAsString = "Right"
        Me.UltraMaskedEdit13.Appearance = Appearance425
        Me.UltraMaskedEdit13.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit13.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.UltraMaskedEdit13.InputMask = "{double:6.2}"
        Me.UltraMaskedEdit13.Location = New System.Drawing.Point(473, 76)
        Me.UltraMaskedEdit13.Name = "UltraMaskedEdit13"
        Me.UltraMaskedEdit13.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit13.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UltraMaskedEdit13.Size = New System.Drawing.Size(80, 20)
        Me.UltraMaskedEdit13.TabIndex = 18
        Me.UltraMaskedEdit13.Text = "000"
        '
        'UltraLabel58
        '
        Appearance426.BackColor = System.Drawing.Color.Transparent
        Appearance426.ForeColor = System.Drawing.Color.Navy
        Appearance426.TextVAlignAsString = "Middle"
        Me.UltraLabel58.Appearance = Appearance426
        Me.UltraLabel58.AutoSize = True
        Me.UltraLabel58.Location = New System.Drawing.Point(415, 79)
        Me.UltraLabel58.Name = "UltraLabel58"
        Me.UltraLabel58.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel58.TabIndex = 17
        Me.UltraLabel58.Text = "Comisión: "
        '
        'UltraMaskedEdit14
        '
        Appearance427.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance427.TextHAlignAsString = "Right"
        Me.UltraMaskedEdit14.Appearance = Appearance427
        Me.UltraMaskedEdit14.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit14.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.UltraMaskedEdit14.InputMask = "{double:5.3}"
        Me.UltraMaskedEdit14.Location = New System.Drawing.Point(319, 52)
        Me.UltraMaskedEdit14.Name = "UltraMaskedEdit14"
        Me.UltraMaskedEdit14.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit14.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UltraMaskedEdit14.Size = New System.Drawing.Size(60, 20)
        Me.UltraMaskedEdit14.TabIndex = 13
        Me.UltraMaskedEdit14.Text = "1.000"
        '
        'UltraCheckEditor7
        '
        Appearance428.ForeColor = System.Drawing.Color.Navy
        Me.UltraCheckEditor7.Appearance = Appearance428
        Me.UltraCheckEditor7.Location = New System.Drawing.Point(557, 26)
        Me.UltraCheckEditor7.Name = "UltraCheckEditor7"
        Me.UltraCheckEditor7.Size = New System.Drawing.Size(75, 20)
        Me.UltraCheckEditor7.TabIndex = 8
        Me.UltraCheckEditor7.Text = "Facturado"
        '
        'UltraCheckEditor8
        '
        Appearance429.ForeColor = System.Drawing.Color.Navy
        Me.UltraCheckEditor8.Appearance = Appearance429
        Me.UltraCheckEditor8.Location = New System.Drawing.Point(557, 46)
        Me.UltraCheckEditor8.Name = "UltraCheckEditor8"
        Me.UltraCheckEditor8.Size = New System.Drawing.Size(64, 30)
        Me.UltraCheckEditor8.TabIndex = 16
        Me.UltraCheckEditor8.Text = "Incluye IGV"
        '
        'UltraExpandableGroupBox6
        '
        Me.UltraExpandableGroupBox6.Controls.Add(Me.UltraExpandableGroupBoxPanel19)
        Me.UltraExpandableGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox6.ExpandedSize = New System.Drawing.Size(1179, 65)
        Me.UltraExpandableGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox6.Name = "UltraExpandableGroupBox6"
        Me.UltraExpandableGroupBox6.Size = New System.Drawing.Size(1179, 65)
        Me.UltraExpandableGroupBox6.TabIndex = 4
        Me.UltraExpandableGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel19
        '
        Me.UltraExpandableGroupBoxPanel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel19.Location = New System.Drawing.Point(3, 18)
        Me.UltraExpandableGroupBoxPanel19.Name = "UltraExpandableGroupBoxPanel19"
        Me.UltraExpandableGroupBoxPanel19.Size = New System.Drawing.Size(1173, 44)
        Me.UltraExpandableGroupBoxPanel19.TabIndex = 0
        '
        'UltraExpandableGroupBoxPanel17
        '
        Me.UltraExpandableGroupBoxPanel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel17.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel17.Name = "UltraExpandableGroupBoxPanel17"
        Me.UltraExpandableGroupBoxPanel17.Size = New System.Drawing.Size(1173, 42)
        Me.UltraExpandableGroupBoxPanel17.TabIndex = 0
        '
        'cboTractoTransabilidad
        '
        Appearance430.ForeColor = System.Drawing.Color.Black
        Me.cboTractoTransabilidad.Appearance = Appearance430
        Me.cboTractoTransabilidad.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTractoTransabilidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTractoTransabilidad.DropDownListAlignment = Infragistics.Win.DropDownListAlignment.Right
        Me.cboTractoTransabilidad.DropDownListWidth = -1
        Me.cboTractoTransabilidad.Enabled = False
        Me.cboTractoTransabilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTractoTransabilidad.ForeColor = System.Drawing.Color.Black
        Me.cboTractoTransabilidad.Location = New System.Drawing.Point(66, 3)
        Me.cboTractoTransabilidad.Name = "cboTractoTransabilidad"
        Me.cboTractoTransabilidad.Size = New System.Drawing.Size(85, 21)
        Me.cboTractoTransabilidad.TabIndex = 14
        Me.cboTractoTransabilidad.ValueMember = "Id"
        '
        'chkTractoTransabilidad
        '
        Appearance431.ForeColor = System.Drawing.Color.Navy
        Me.chkTractoTransabilidad.Appearance = Appearance431
        Me.chkTractoTransabilidad.AutoSize = True
        Me.chkTractoTransabilidad.Location = New System.Drawing.Point(10, 4)
        Me.chkTractoTransabilidad.Name = "chkTractoTransabilidad"
        Me.chkTractoTransabilidad.Size = New System.Drawing.Size(14, 13)
        Me.chkTractoTransabilidad.TabIndex = 13
        '
        'cboCarretaTransabilidad
        '
        Appearance432.ForeColor = System.Drawing.Color.Black
        Me.cboCarretaTransabilidad.Appearance = Appearance432
        Me.cboCarretaTransabilidad.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCarretaTransabilidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCarretaTransabilidad.DropDownListAlignment = Infragistics.Win.DropDownListAlignment.Right
        Me.cboCarretaTransabilidad.DropDownListWidth = -1
        Me.cboCarretaTransabilidad.Enabled = False
        Me.cboCarretaTransabilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarretaTransabilidad.ForeColor = System.Drawing.Color.Black
        Me.cboCarretaTransabilidad.Location = New System.Drawing.Point(236, 3)
        Me.cboCarretaTransabilidad.Name = "cboCarretaTransabilidad"
        Me.cboCarretaTransabilidad.Size = New System.Drawing.Size(85, 21)
        Me.cboCarretaTransabilidad.TabIndex = 16
        Me.cboCarretaTransabilidad.ValueMember = "Id"
        '
        'chkCarretaTransabilidad
        '
        Appearance433.ForeColor = System.Drawing.Color.Navy
        Me.chkCarretaTransabilidad.Appearance = Appearance433
        Me.chkCarretaTransabilidad.AutoSize = True
        Me.chkCarretaTransabilidad.Location = New System.Drawing.Point(174, 4)
        Me.chkCarretaTransabilidad.Name = "chkCarretaTransabilidad"
        Me.chkCarretaTransabilidad.Size = New System.Drawing.Size(14, 13)
        Me.chkCarretaTransabilidad.TabIndex = 15
        '
        'ficOperacion
        '
        Me.ficOperacion.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOperacion.Controls.Add(Me.UltraTabPageControl7)
        Me.ficOperacion.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOperacion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficOperacion.Location = New System.Drawing.Point(0, 0)
        Me.ficOperacion.Name = "ficOperacion"
        Me.ficOperacion.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOperacion.Size = New System.Drawing.Size(1254, 733)
        Me.ficOperacion.TabIndex = 0
        UltraTab14.Key = "Lista"
        UltraTab14.TabPage = Me.UltraTabPageControl7
        UltraTab14.Text = "Lista"
        UltraTab15.Key = "Mantenimiento"
        UltraTab15.TabPage = Me.UltraTabPageControl1
        UltraTab15.Text = "Mantenimiento"
        Me.ficOperacion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab14, UltraTab15})
        Me.ficOperacion.TabStop = False
        Me.ficOperacion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1252, 710)
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
        Me.ugb_Espera.Location = New System.Drawing.Point(430, 334)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 13
        Me.ugb_Espera.Visible = False
        '
        'frm_Operacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 733)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficOperacion)
        Me.KeyPreview = true
        Me.Name = "frm_Operacion"
        Me.Text = "Programacion Viaje"
        Me.UltraTabPageControl2.ResumeLayout(false)
        Me.UltraTabPageControl2.PerformLayout
        CType(Me.griBonificacionTracto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Calcular1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ogdBonificacionTracto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.griBonificacionCarreta,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ogdBonificacionCarreta,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTractoPeso,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboCarretaPeso,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl3.ResumeLayout(false)
        CType(Me.UltraGroupBox12,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox12.ResumeLayout(false)
        CType(Me.griEscala,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuEscala.ResumeLayout(false)
        CType(Me.ogdEscala,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraGroupBox11,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox11.ResumeLayout(false)
        Me.UltraGroupBox11.PerformLayout
        CType(Me.verEscalaBloque,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboEscalaBloque,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGlosaEscalaBloque,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl6.ResumeLayout(false)
        CType(Me.griTarifas,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ogdTarifas,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl9.ResumeLayout(false)
        CType(Me.griLista,System.ComponentModel.ISupportInitialize).EndInit
        Me.Menu.ResumeLayout(false)
        CType(Me.ogdListaOperacion,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl10.ResumeLayout(false)
        CType(Me.griListaTerceros,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl16.ResumeLayout(false)
        CType(Me.griViajesProceso,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraExpandableGroupBox5,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraExpandableGroupBox5.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel10.ResumeLayout(false)
        CType(Me.opcDesenganches,System.ComponentModel.ISupportInitialize).EndInit
        Me.utpTrazabilidad.ResumeLayout(false)
        CType(Me.griTransabilida,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraGroupBox8,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox8.ResumeLayout(false)
        Me.UltraGroupBox8.PerformLayout
        CType(Me.cboFlota,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.opTractoCarreta,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl4.ResumeLayout(false)
        CType(Me.griViaje,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuViaje.ResumeLayout(false)
        CType(Me.ogdViaje,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.expViaje,System.ComponentModel.ISupportInitialize).EndInit
        Me.expViaje.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel18.ResumeLayout(false)
        CType(Me.exgruEscalaBloque,System.ComponentModel.ISupportInitialize).EndInit
        Me.exgruEscalaBloque.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(false)
        CType(Me.tabAdicional,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabAdicional.ResumeLayout(false)
        CType(Me.UltraGroupBox14,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox14.ResumeLayout(false)
        Me.UltraGroupBox14.PerformLayout
        CType(Me.hViaje,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verViajeRetorno,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verFechaViaje,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboCarreta,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboOrigen,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDestino,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtIdViaje,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTracto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verEscala,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCodigoViaje,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboCopiloto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGlosaEscala,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verCarreta,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verViajeVacio,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboAyudante,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboEscala,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboPiloto,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl5.ResumeLayout(false)
        CType(Me.griViajeDetalle,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuViajeDetalle.ResumeLayout(false)
        CType(Me.ogdOperacionDetalle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.expCargaOperacion,System.ComponentModel.ISupportInitialize).EndInit
        Me.expCargaOperacion.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(false)
        CType(Me.expListaDemandas,System.ComponentModel.ISupportInitialize).EndInit
        Me.expListaDemandas.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel16.ResumeLayout(false)
        CType(Me.griDemanda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ogdDemanda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraExpandableGroupBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraExpandableGroupBox3.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel9.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel9.PerformLayout
        CType(Me.cboZonaDemanda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.expNuevaCarga,System.ComponentModel.ISupportInitialize).EndInit
        Me.expNuevaCarga.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel7.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel7.PerformLayout
        CType(Me.txtRucCLiente,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRucComisionista,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraGroupBox9,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox9.ResumeLayout(false)
        Me.UltraGroupBox9.PerformLayout
        CType(Me.chkIndFalsoFlete,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verValidaFU,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verIncluyeIgv,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CalFleteUnitario,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CalFleteUnitarioIGV,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboClienteFinal,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Agrupacion6,System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion6.ResumeLayout(false)
        Me.Agrupacion6.PerformLayout
        CType(Me.opPagoCont,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verCargar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verDescarga,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verPagoContraEntrega,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verFacturado,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboMaterial,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTipoCarga,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboComisionista,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboCliente,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraGroupBox10,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox10.ResumeLayout(false)
        Me.UltraGroupBox10.PerformLayout
        CType(Me.txtMotivoConsolidado,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chkConsolidado,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chkCostoEstivaDescarga,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chkIGVConsolidado,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chkCostoEstiva,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl8.ResumeLayout(false)
        CType(Me.griDetalleTercero,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuContratoTercero.ResumeLayout(false)
        CType(Me.ogdDetalleTercero,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.expContratoTercero,System.ComponentModel.ISupportInitialize).EndInit
        Me.expContratoTercero.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout
        CType(Me.txtTelefonoContacto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtApellidoMaternoContacto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNombreContacto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtApellidoPaternoContacto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRucContacto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRucEmpresaTransportista,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboContacto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTercero,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtReferenciaTercero,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtObservacionTercero,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboMonedaT,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl7.ResumeLayout(false)
        CType(Me.agrListaRegistro,System.ComponentModel.ISupportInitialize).EndInit
        Me.agrListaRegistro.ResumeLayout(false)
        CType(Me.tabViajesLista,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabViajesLista.ResumeLayout(false)
        CType(Me.agrBusqueda,System.ComponentModel.ISupportInitialize).EndInit
        Me.agrBusqueda.ResumeLayout(false)
        CType(Me.UltraExpandableGroupBox7,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraExpandableGroupBox7.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel15.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel15.PerformLayout
        CType(Me.decProduccionSinIGV,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decProduccionIGV,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grupoEstado,System.ComponentModel.ISupportInitialize).EndInit
        Me.grupoEstado.ResumeLayout(false)
        Me.grupoEstado.PerformLayout
        CType(Me.ColorFin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorProgramado,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCarga,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorTransito,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorDescarga,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grupoTipoVehiculo,System.ComponentModel.ISupportInitialize).EndInit
        Me.grupoTipoVehiculo.ResumeLayout(false)
        Me.grupoTipoVehiculo.PerformLayout
        CType(Me.Colores6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Colores7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorParihuelero,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Colores8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorPlataforma,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCamion20M3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorTolvaVolteo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Colores9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Colores10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCamion65M3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorContenedor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorGranelero,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorFurgon,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorFurgonLargo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCamioneta,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorVolquete,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCamion30M3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCalicera,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCamion40M3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorMediaBaranda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CalculadoraGrilla,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.colorCambio,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.colorCargaConsolidada,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraExpandableGroupBox4,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraExpandableGroupBox4.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel12.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel12.PerformLayout
        CType(Me.verPilotoLista,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboPilotoLista,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verCarretaLista,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboCarretaLista,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraGroupBox13,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox13.ResumeLayout(false)
        Me.UltraGroupBox13.PerformLayout
        CType(Me.verTracto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTractoLista,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboCentro,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboUsuario,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboZona,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl1.ResumeLayout(false)
        CType(Me.ficViaje,System.ComponentModel.ISupportInitialize).EndInit
        Me.ficViaje.ResumeLayout(false)
        CType(Me.expGeneral,System.ComponentModel.ISupportInitialize).EndInit
        Me.expGeneral.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel14.ResumeLayout(false)
        CType(Me.griDisponibleVehiculo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ogdDisponibleVehiculos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.expVehiculo,System.ComponentModel.ISupportInitialize).EndInit
        Me.expVehiculo.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel8.ResumeLayout(false)
        CType(Me.UltraExpandableGroupBox12,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraExpandableGroupBox12.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel13.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel13.PerformLayout
        CType(Me.ColorAdvertencia,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorPiloto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorAyudante,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCopiloto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCarreta,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorTracto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraExpandableGroupBox9,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraExpandableGroupBox9.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel11.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel11.PerformLayout
        CType(Me.ColorParihueleroD,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorMediaBarandaD,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorPlataformaD,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCamion20M3D,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCamion40M3D,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCaliceraD,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorTolvaVolteoD,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCamion30M3D,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCamion65M3D,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorContenedorD,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorVolqueteD,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorGraneleroD,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorCamionetaD,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorFurgonD,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorFurgonLargoD,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraGroupBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox2.ResumeLayout(false)
        Me.UltraGroupBox2.PerformLayout
        CType(Me.cboZonaDisponibles,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboVehiculoDisponible,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.exgruOperacion,System.ComponentModel.ISupportInitialize).EndInit
        Me.exgruOperacion.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(false)
        Me.UltraExpandableGroupBoxPanel5.PerformLayout
        CType(Me.UltraGroupBox7,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox7.ResumeLayout(false)
        Me.UltraGroupBox7.PerformLayout
        CType(Me.hOperacion,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verValidaciones,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraGroupBox5,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox5.ResumeLayout(false)
        Me.UltraGroupBox5.PerformLayout
        CType(Me.NroTurno,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.opcNocheDia,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NroVueltas,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verProgramarViajeBloque,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraGroupBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox1.ResumeLayout(false)
        Me.UltraGroupBox1.PerformLayout
        CType(Me.chkIndTercero,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboMoneda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboRutaOperacion,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCarga,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chkMotriz,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCodigoOperacion,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboActividadNegocio,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtIdEstadoOperacion,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtIdOperacion,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboRutaOrigen,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTipoVehiculo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtObservacionOperacion,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboRutaDestino,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ogdVehiculoEstadoSituacional,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraGroupBox6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraGroupBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraTabControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Colores1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Colores2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Colores3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Colores4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Colores5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Agrupacion2,System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion2.ResumeLayout(false)
        CType(Me.UltraCheckEditor4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraCheckEditor5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraCheckEditor6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Agrupacion5,System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion5.ResumeLayout(false)
        Me.Agrupacion5.PerformLayout
        CType(Me.UltraGroupBox4,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox4.ResumeLayout(false)
        Me.UltraGroupBox4.PerformLayout
        CType(Me.Combo4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboMaestros5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NumeroCalculadora1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboMaestros6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboMaestros7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboMaestros8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraCheckEditor7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraCheckEditor8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraExpandableGroupBox6,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraExpandableGroupBox6.ResumeLayout(false)
        CType(Me.cboTractoTransabilidad,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chkTractoTransabilidad,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboCarretaTransabilidad,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chkCarretaTransabilidad,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ficOperacion,System.ComponentModel.ISupportInitialize).EndInit
        Me.ficOperacion.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents MenuViajeDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuDuplicar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox

    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents ogdOperacionDetalle As ISL.Controles.OrigenDatos
    Friend WithEvents ficOperacion As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnAgregarViaje As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verEscala As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboEscala As ISL.Controles.ComboMaestros
    Friend WithEvents cboOrigen As ISL.Controles.ComboMaestros
    Friend WithEvents cboDestino As ISL.Controles.ComboMaestros
    Friend WithEvents cboAyudante As ISL.Controles.ComboMaestros
    Friend WithEvents cboPiloto As ISL.Controles.ComboMaestros
    Friend WithEvents cboCopiloto As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTracto As ISL.Controles.Combo
    Friend WithEvents cboCarreta As ISL.Controles.Combo
    Friend WithEvents UltraLabel38 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel34 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtFlete As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel40 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verViajeVacio As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ficViaje As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griViaje As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ogdViaje As ISL.Controles.OrigenDatos
    Friend WithEvents ogdDemanda As ISL.Controles.OrigenDatos
    Friend WithEvents ogdListaOperacion As ISL.Controles.OrigenDatos
    Friend WithEvents ogdDisponibleVehiculos As ISL.Controles.OrigenDatos
    Friend WithEvents Colores1 As ISL.Controles.Colores
    Friend WithEvents Colores2 As ISL.Controles.Colores
    Friend WithEvents Colores3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Colores4 As ISL.Controles.Colores
    Friend WithEvents Colores5 As ISL.Controles.Colores
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents Calcular1 As ISL.Controles.Calcular
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents verCarreta As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtIdViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCodigoViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtGlosaEscala As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents MenuViaje As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents colorCargaConsolidada As ISL.Controles.Colores
    Friend WithEvents ogdVehiculoEstadoSituacional As ISL.Controles.OrigenDatos
    Friend WithEvents exgruEscalaBloque As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnAgregaEscala As Infragistics.Win.Misc.UltraButton
    Friend WithEvents verEscalaBloque As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents griEscala As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtGlosaEscalaBloque As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ogdEscala As ISL.Controles.OrigenDatos
    Friend WithEvents MenuEscala As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTaraTracto As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents cboTractoPeso As ISL.Controles.Combo
    Friend WithEvents cboCarretaPeso As ISL.Controles.Combo
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCapacidadUtil As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtTaraCarreta As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel45 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraMaskedEdit6 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents UltraCheckEditor4 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraCheckEditor5 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraCheckEditor6 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents UltraMaskedEdit7 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel46 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraMaskedEdit8 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel47 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraMaskedEdit9 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel48 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel49 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Combo4 As ISL.Controles.Combo
    Friend WithEvents UltraMaskedEdit10 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraMaskedEdit11 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel50 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel51 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel52 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ComboMaestros5 As ISL.Controles.ComboMaestros
    Friend WithEvents UltraMaskedEdit12 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel53 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents NumeroCalculadora1 As ISL.Controles.NumeroCalculadora
    Friend WithEvents ComboMaestros6 As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel54 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ComboMaestros7 As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel55 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ComboMaestros8 As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel56 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel57 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraMaskedEdit13 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel58 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraMaskedEdit14 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraCheckEditor7 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraCheckEditor8 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    'Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents cboUsuario As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel62 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtFleteTotalDetalle As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents verCargar As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verDescarga As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verPagoContraEntrega As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtComision As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCantidad As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents verFacturado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verIncluyeIgv As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents CalFleteUnitario As ISL.Controles.NumeroCalculadora
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboZona As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Shadows WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents Insert As System.Windows.Forms.ToolStripMenuItem
    Shadows WithEvents Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Programar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents verFechaViaje As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtFletePorcentaje As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraExpandableGroupBox4 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel12 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox7 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel15 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents expViaje As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel18 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents verTracto As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboTractoLista As ISL.Controles.Combo
    Friend WithEvents Etiqueta44 As ISL.Controles.Etiqueta
    Friend WithEvents Cancelada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colorCambio As ISL.Controles.Colores
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents tabAdicional As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griTarifas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ogdTarifas As ISL.Controles.OrigenDatos
    Friend WithEvents txtFleteUnitarioViaje As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents cboEscalaBloque As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdBonificacionTracto As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griBonificacionCarreta As ISL.Controles.Grilla
    Friend WithEvents griBonificacionTracto As ISL.Controles.Grilla
    Friend WithEvents ogdBonificacionCarreta As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraLabel35 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtBonificacionTracto As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents btnCapacidadUtil As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel37 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajeCapacidadUtil As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CalculadoraGrilla As Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown
    Friend WithEvents verValidaFU As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents grupoTipoVehiculo As ISL.Controles.Agrupacion
    Friend WithEvents grupoEstado As ISL.Controles.Agrupacion
    Friend WithEvents ColorFin As ISL.Controles.Colores
    Friend WithEvents ColorProgramado As ISL.Controles.Colores
    Friend WithEvents ColorCarga As ISL.Controles.Colores
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTransito As ISL.Controles.Colores
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents ColorDescarga As ISL.Controles.Colores
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents ColorParihuelero As ISL.Controles.Colores
    Friend WithEvents ColorPlataforma As ISL.Controles.Colores
    Friend WithEvents ColorCamion20M3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTolvaVolteo As ISL.Controles.Colores
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion65M3 As ISL.Controles.Colores
    Friend WithEvents ColorContenedor As ISL.Controles.Colores
    Friend WithEvents Etiqueta222 As ISL.Controles.Etiqueta
    Friend WithEvents ColorGranelero As ISL.Controles.Colores
    Friend WithEvents ColorFurgon As ISL.Controles.Colores
    Friend WithEvents ColorFurgonLargo As ISL.Controles.Colores
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamioneta As ISL.Controles.Colores
    Friend WithEvents ColorVolquete As ISL.Controles.Colores
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion30M3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCalicera As ISL.Controles.Colores
    Friend WithEvents ColorCamion40M3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents ColorMediaBaranda As ISL.Controles.Colores
    Friend WithEvents verViajeRetorno As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ogdDetalleTercero As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griDetalleTercero As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents expContratoTercero As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents numFleteTotalTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents numIgvTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents cboMonedaT As ISL.Controles.Combo
    Friend WithEvents btnAgregarTerc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel42 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numFleteUnitarioTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel43 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel44 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel61 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numComisionTerc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel63 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel64 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents MenuContratoTercero As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DetalleContratoTercero As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Colores6 As ISL.Controles.Colores
    Friend WithEvents Colores7 As ISL.Controles.Colores
    Friend WithEvents Colores8 As ISL.Controles.Colores
    Friend WithEvents Etiqueta48 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta49 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta52 As ISL.Controles.Etiqueta
    Friend WithEvents Colores9 As ISL.Controles.Colores
    Friend WithEvents Colores10 As ISL.Controles.Colores
    Friend WithEvents verPilotoLista As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboPilotoLista As ISL.Controles.ComboMaestros
    Friend WithEvents verCarretaLista As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboCarretaLista As ISL.Controles.Combo
    Friend WithEvents tabViajesLista As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaTerceros As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents numCantidadTercero As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel66 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtObservacionTercero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtReferenciaTercero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents numSubTotalTercero As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel67 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents griViajesProceso As ISL.Controles.Grilla
    Friend WithEvents UltraExpandableGroupBox5 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel10 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents opcDesenganches As ISL.Controles.Opciones
    Friend WithEvents exgruOperacion As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents chkMotriz As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel65 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigoOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboActividadNegocio As ISL.Controles.ComboMaestros
    Friend WithEvents txtIdEstadoOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtIdOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboRutaOrigen As ISL.Controles.ComboMaestros
    Friend WithEvents cboTipoVehiculo As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtObservacionOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel36 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboRutaDestino As ISL.Controles.ComboMaestros
    Friend WithEvents expGeneral As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel14 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents cboCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboClienteFinal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblClienteFinal As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboComisionista As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboTipoCarga As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboMaterial As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtAdelantoFlete As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CalFleteUnitarioIGV As ISL.Controles.NumeroCalculadora
    Friend WithEvents UltraLabel69 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSubtotal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents lblSubtotal As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents griViajeDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtCostoEstibaDescarga As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents chkCostoEstivaDescarga As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtCostoEstiba As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents chkCostoEstiva As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkIGVConsolidado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtConsolidado As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents chkConsolidado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboContacto As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboTercero As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents txtCantidadOperacion As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtFUnitarioOperacion As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents cboRutaOperacion As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtFTotalOperacion As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCarga As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents expCargaOperacion As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents expListaDemandas As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel16 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griDemanda As ISL.Controles.Grilla
    Friend WithEvents UltraExpandableGroupBox3 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel9 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents cboZonaDemanda As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel60 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnConsultarDemanda As Infragistics.Win.Misc.UltraButton
    Friend WithEvents expNuevaCarga As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel7 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents lblFlota As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel33 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verValidaciones As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents NroTurno As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents opcNocheDia As ISL.Controles.Opciones
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents NroVueltas As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents verProgramarViajeBloque As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraGroupBox9 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox10 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox12 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtRucComisionista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtRucCLiente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents opPagoCont As ISL.Controles.Opciones
    Friend WithEvents txtMotivoConsolidado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTelefonoContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtApellidoMaternoContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNombreContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtApellidoPaternoContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtRucContacto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtRucEmpresaTransportista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utpTrazabilidad As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel17 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents cboTractoTransabilidad As ISL.Controles.Combo
    Friend WithEvents chkTractoTransabilidad As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboCarretaTransabilidad As ISL.Controles.Combo
    Friend WithEvents chkCarretaTransabilidad As Infragistics.Win.UltraWinEditors.UltraCheckEditor 
    Friend WithEvents griTransabilida As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents opTractoCarreta As ISL.Controles.Opciones
    Friend WithEvents btnEnviarCorreo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraExpandableGroupBoxPanel19 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents lblDemandaProgramar As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblCodigoDemandaAProgramar As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel68 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkIndFalsoFlete As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkIndTercero As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents expVehiculo As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel8 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox12 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel13 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents ColorAdvertencia As ISL.Controles.Colores
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents ColorPiloto As ISL.Controles.Colores
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents ColorAyudante As ISL.Controles.Colores
    Friend WithEvents ColorCopiloto As ISL.Controles.Colores
    Friend WithEvents ColorCarreta As ISL.Controles.Colores
    Friend WithEvents ColorTracto As ISL.Controles.Colores
    Friend WithEvents UltraExpandableGroupBox9 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel11 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta36 As ISL.Controles.Etiqueta
    Friend WithEvents ColorParihueleroD As ISL.Controles.Colores
    Friend WithEvents ColorMediaBarandaD As ISL.Controles.Colores
    Friend WithEvents ColorPlataformaD As ISL.Controles.Colores
    Friend WithEvents Etiqueta46 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion20M3D As ISL.Controles.Colores
    Friend WithEvents ColorCamion40M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCaliceraD As ISL.Controles.Colores
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta43 As ISL.Controles.Etiqueta
    Friend WithEvents ColorTolvaVolteoD As ISL.Controles.Colores
    Friend WithEvents Etiqueta42 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion30M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta34 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta41 As ISL.Controles.Etiqueta
    Friend WithEvents ColorCamion65M3D As ISL.Controles.Colores
    Friend WithEvents Etiqueta40 As ISL.Controles.Etiqueta
    Friend WithEvents ColorContenedorD As ISL.Controles.Colores
    Friend WithEvents Etiqueta39 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents ColorVolqueteD As ISL.Controles.Colores
    Friend WithEvents ColorGraneleroD As ISL.Controles.Colores
    Friend WithEvents ColorCamionetaD As ISL.Controles.Colores
    Friend WithEvents ColorFurgonD As ISL.Controles.Colores
    Friend WithEvents Etiqueta38 As ISL.Controles.Etiqueta
    Friend WithEvents ColorFurgonLargoD As ISL.Controles.Colores
    Friend WithEvents Etiqueta37 As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboZonaDisponibles As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel59 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboVehiculoDisponible As ISL.Controles.Combo
    Friend WithEvents btnConsultarDisponibles As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griDisponibleVehiculo As ISL.Controles.Grilla
    Friend WithEvents Flota As System.Windows.Forms.Label
    Friend WithEvents cboFlota As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGroupBox14 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecViaje As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecOperacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents hViaje As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents hOperacion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents decProduccionSinIGV As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents decProduccionIGV As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents lblProduccionSinIGV As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblProduccionIGV As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_Espera As Espere
End Class
