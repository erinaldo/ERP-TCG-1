<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ComprobanteVentas
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
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exportar")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Modificar")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnulado")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abrev_Empresa")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Item")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnticipo")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAfectaAnticipo")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto_Anticipo")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnulado")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abrev_Empresa")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndElectronico")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Item")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnticipo")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAfectaAnticipo")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto_Anticipo")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ComprobanteVentas))
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GriComprobanteAsociado = New ISL.Controles.Grilla(Me.components)
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.GriSeleccionaComprobante = New ISL.Controles.Grilla(Me.components)
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion10 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnuDetalleAsiento = New ISL.Controles.Menu(Me.components)
        Me.UltraToolbarsDockArea2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea3 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea4 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridComprobanteVenta = New ISL.Controles.Grilla(Me.components)
        Me.MenuCabecera = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarCabecera = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarCabecera = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminaCabecera = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.btn_Extornar = New ISL.Controles.Boton(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.Año1 = New ISL.Win.Año()
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.tcComprobanteDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrCabeceraAsiento = New ISL.Controles.Agrupacion(Me.components)
        Me.cboTipo = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboServicio = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiPeriodo = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.DecGravado = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecExonerado = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTotalVenta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecInafecta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTotalDoc = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecIsc = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecOtrosTributos = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecIgv = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoVenta = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCtaCte = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecVencimiento = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecEmision = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroDocumento = New ISL.Controles.Texto(Me.components)
        Me.decTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroSerie = New ISL.Controles.Texto(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.Combo(Me.components)
        Me.tcComprobanteVenta = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrDetraccion = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.DecDetraer = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.DecMontoDetraccion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNetoPagar = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.GriComprobanteAsociado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.GriSeleccionaComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion10.SuspendLayout()
        CType(Me.mnuDetalleAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.gridComprobanteVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuCabecera.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Año1.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.tcComprobanteDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcComprobanteDetalle.SuspendLayout()
        CType(Me.agrCabeceraAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrCabeceraAsiento.SuspendLayout()
        CType(Me.cboTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.DecGravado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecExonerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTotalVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecInafecta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTotalDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecIsc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecOtrosTributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecIgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecEmision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcComprobanteVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcComprobanteVenta.SuspendLayout()
        CType(Me.agrDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetraccion.SuspendLayout()
        CType(Me.DecDetraer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecMontoDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetoPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.GriComprobanteAsociado)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1222, 227)
        '
        'GriComprobanteAsociado
        '
        Me.GriComprobanteAsociado.ContextMenuStrip = Me.MenuDetalle
        Me.GriComprobanteAsociado.DataSource = Me.UltraDataSource2
        UltraGridColumn220.Header.VisiblePosition = 0
        UltraGridColumn220.Hidden = True
        UltraGridColumn221.Header.Caption = "Periodo"
        UltraGridColumn221.Header.VisiblePosition = 1
        UltraGridColumn221.Width = 61
        UltraGridColumn222.Header.Caption = "Tipo Doc"
        UltraGridColumn222.Header.VisiblePosition = 2
        UltraGridColumn222.Width = 97
        UltraGridColumn223.Header.VisiblePosition = 3
        UltraGridColumn223.Width = 47
        UltraGridColumn224.Header.VisiblePosition = 4
        UltraGridColumn224.Width = 82
        UltraGridColumn225.Header.Caption = "Fec Emision"
        UltraGridColumn225.Header.VisiblePosition = 5
        UltraGridColumn225.Width = 86
        UltraGridColumn226.Header.Caption = "Fec Venc."
        UltraGridColumn226.Header.VisiblePosition = 6
        UltraGridColumn226.Width = 80
        UltraGridColumn227.Header.VisiblePosition = 14
        UltraGridColumn228.Header.VisiblePosition = 8
        UltraGridColumn228.Hidden = True
        UltraGridColumn229.Header.Caption = "Cliente"
        UltraGridColumn229.Header.VisiblePosition = 7
        UltraGridColumn229.Width = 309
        UltraGridColumn230.Header.VisiblePosition = 10
        UltraGridColumn230.Hidden = True
        UltraGridColumn231.Header.VisiblePosition = 9
        UltraGridColumn231.Hidden = True
        UltraGridColumn232.Header.VisiblePosition = 11
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.Header.Caption = "Moneda"
        UltraGridColumn233.Header.VisiblePosition = 12
        UltraGridColumn233.Width = 58
        UltraGridColumn234.Header.Caption = "T.C"
        UltraGridColumn234.Header.VisiblePosition = 13
        UltraGridColumn234.Width = 66
        UltraGridColumn235.Header.VisiblePosition = 15
        UltraGridColumn236.Header.VisiblePosition = 16
        UltraGridColumn236.Hidden = True
        UltraGridColumn237.Header.VisiblePosition = 17
        UltraGridColumn237.Hidden = True
        UltraGridColumn238.Header.VisiblePosition = 18
        UltraGridColumn238.Hidden = True
        UltraGridColumn239.Header.VisiblePosition = 19
        UltraGridColumn239.Hidden = True
        UltraGridColumn240.Header.VisiblePosition = 20
        UltraGridColumn240.Hidden = True
        UltraGridColumn241.Header.VisiblePosition = 21
        UltraGridColumn241.Hidden = True
        UltraGridColumn242.Header.VisiblePosition = 22
        UltraGridColumn242.Hidden = True
        UltraGridColumn243.Header.VisiblePosition = 23
        UltraGridColumn243.Hidden = True
        UltraGridColumn244.Header.VisiblePosition = 24
        UltraGridColumn244.Hidden = True
        UltraGridColumn245.Header.VisiblePosition = 25
        UltraGridColumn245.Hidden = True
        UltraGridColumn246.Header.VisiblePosition = 26
        UltraGridColumn246.Hidden = True
        UltraGridColumn247.Header.VisiblePosition = 27
        UltraGridColumn247.Hidden = True
        UltraGridColumn248.Header.VisiblePosition = 28
        UltraGridColumn248.Hidden = True
        UltraGridColumn249.Header.VisiblePosition = 29
        UltraGridColumn249.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn247, UltraGridColumn248, UltraGridColumn249})
        Me.GriComprobanteAsociado.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.GriComprobanteAsociado.DisplayLayout.MaxColScrollRegions = 1
        Me.GriComprobanteAsociado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GriComprobanteAsociado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GriComprobanteAsociado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GriComprobanteAsociado.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.GriComprobanteAsociado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GriComprobanteAsociado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GriComprobanteAsociado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GriComprobanteAsociado.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GriComprobanteAsociado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GriComprobanteAsociado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GriComprobanteAsociado.Location = New System.Drawing.Point(0, 0)
        Me.GriComprobanteAsociado.Name = "GriComprobanteAsociado"
        Me.GriComprobanteAsociado.Size = New System.Drawing.Size(1222, 227)
        Me.GriComprobanteAsociado.TabIndex = 0
        Me.GriComprobanteAsociado.Text = "Documentos Asociados"
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarDetalle, Me.EliminarDetalle})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(122, 56)
        '
        'AgregarDetalle
        '
        Me.AgregarDetalle.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarDetalle.Name = "AgregarDetalle"
        Me.AgregarDetalle.Size = New System.Drawing.Size(121, 26)
        Me.AgregarDetalle.Text = "Agregar"
        '
        'EliminarDetalle
        '
        Me.EliminarDetalle.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarDetalle.Name = "EliminarDetalle"
        Me.EliminarDetalle.Size = New System.Drawing.Size(121, 26)
        Me.EliminarDetalle.Text = "Eliminar"
        '
        'UltraDataSource2
        '
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion8)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1222, 227)
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.Agrupacion9)
        Me.Agrupacion8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion8.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(1222, 227)
        Me.Agrupacion8.TabIndex = 0
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.GriSeleccionaComprobante)
        Me.Agrupacion9.Controls.Add(Me.Agrupacion10)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion9.Location = New System.Drawing.Point(2, 2)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(1218, 223)
        Me.Agrupacion9.TabIndex = 0
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'GriSeleccionaComprobante
        '
        Me.GriSeleccionaComprobante.DataSource = Me.UltraDataSource3
        UltraGridColumn250.Header.VisiblePosition = 0
        UltraGridColumn250.Hidden = True
        UltraGridColumn251.Header.Caption = "Periodo"
        UltraGridColumn251.Header.VisiblePosition = 1
        UltraGridColumn251.Width = 61
        UltraGridColumn252.Header.Caption = "Tipo Doc"
        UltraGridColumn252.Header.VisiblePosition = 2
        UltraGridColumn252.Width = 97
        UltraGridColumn253.Header.VisiblePosition = 3
        UltraGridColumn253.Width = 47
        UltraGridColumn254.Header.VisiblePosition = 4
        UltraGridColumn254.Width = 82
        UltraGridColumn255.Header.Caption = "Fec Emision"
        UltraGridColumn255.Header.VisiblePosition = 5
        UltraGridColumn255.Width = 86
        UltraGridColumn256.Header.Caption = "Fec Venc."
        UltraGridColumn256.Header.VisiblePosition = 6
        UltraGridColumn256.Width = 80
        UltraGridColumn257.Header.VisiblePosition = 14
        UltraGridColumn258.Header.VisiblePosition = 8
        UltraGridColumn258.Hidden = True
        UltraGridColumn259.Header.Caption = "Cliente"
        UltraGridColumn259.Header.VisiblePosition = 7
        UltraGridColumn259.Width = 309
        UltraGridColumn260.Header.VisiblePosition = 10
        UltraGridColumn260.Hidden = True
        UltraGridColumn261.Header.VisiblePosition = 9
        UltraGridColumn261.Hidden = True
        UltraGridColumn262.Header.VisiblePosition = 11
        UltraGridColumn262.Hidden = True
        UltraGridColumn263.Header.Caption = "Moneda"
        UltraGridColumn263.Header.VisiblePosition = 12
        UltraGridColumn263.Width = 66
        UltraGridColumn264.Header.Caption = "T.C"
        UltraGridColumn264.Header.VisiblePosition = 13
        UltraGridColumn264.Width = 60
        UltraGridColumn265.Header.VisiblePosition = 15
        UltraGridColumn266.Header.VisiblePosition = 16
        UltraGridColumn266.Hidden = True
        UltraGridColumn267.Header.VisiblePosition = 17
        UltraGridColumn267.Hidden = True
        UltraGridColumn268.Header.VisiblePosition = 18
        UltraGridColumn268.Hidden = True
        UltraGridColumn269.Header.VisiblePosition = 19
        UltraGridColumn269.Hidden = True
        UltraGridColumn270.Header.VisiblePosition = 20
        UltraGridColumn270.Hidden = True
        UltraGridColumn271.Header.VisiblePosition = 21
        UltraGridColumn271.Hidden = True
        UltraGridColumn272.Header.VisiblePosition = 22
        UltraGridColumn272.Hidden = True
        UltraGridColumn273.Header.VisiblePosition = 23
        UltraGridColumn273.Hidden = True
        UltraGridColumn274.Header.VisiblePosition = 24
        UltraGridColumn274.Hidden = True
        UltraGridColumn275.Header.VisiblePosition = 25
        UltraGridColumn275.Hidden = True
        UltraGridColumn276.Header.VisiblePosition = 26
        UltraGridColumn276.Hidden = True
        UltraGridColumn277.Header.VisiblePosition = 27
        UltraGridColumn277.Hidden = True
        UltraGridColumn278.Header.VisiblePosition = 28
        UltraGridColumn278.Hidden = True
        UltraGridColumn279.Header.VisiblePosition = 29
        UltraGridColumn279.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 30
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271, UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn1})
        Me.GriSeleccionaComprobante.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.GriSeleccionaComprobante.DisplayLayout.MaxColScrollRegions = 1
        Me.GriSeleccionaComprobante.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GriSeleccionaComprobante.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GriSeleccionaComprobante.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GriSeleccionaComprobante.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.GriSeleccionaComprobante.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GriSeleccionaComprobante.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GriSeleccionaComprobante.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GriSeleccionaComprobante.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GriSeleccionaComprobante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GriSeleccionaComprobante.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GriSeleccionaComprobante.Location = New System.Drawing.Point(2, 27)
        Me.GriSeleccionaComprobante.Name = "GriSeleccionaComprobante"
        Me.GriSeleccionaComprobante.Size = New System.Drawing.Size(1214, 194)
        Me.GriSeleccionaComprobante.TabIndex = 1
        Me.GriSeleccionaComprobante.Text = "Agregar Documentos"
        '
        'UltraDataSource3
        '
        UltraDataColumn61.DataType = GetType(Boolean)
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61})
        '
        'Agrupacion10
        '
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea1)
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea2)
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea3)
        Me.Agrupacion10.Controls.Add(Me.UltraToolbarsDockArea4)
        Me.Agrupacion10.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Top)
        Me.Agrupacion10.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom)
        Me.Agrupacion10.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Left)
        Me.Agrupacion10.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Right)
        Me.Agrupacion10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion10.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion10.Location = New System.Drawing.Point(2, 2)
        Me.Agrupacion10.Name = "Agrupacion10"
        Me.Agrupacion10.Size = New System.Drawing.Size(1214, 25)
        Me.Agrupacion10.TabIndex = 1
        Me.Agrupacion10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1210, 26)
        Me.UltraToolbarsDockArea1.ToolbarsManager = Me.mnuDetalleAsiento
        '
        'mnuDetalleAsiento
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mnuDetalleAsiento.Appearance = Appearance1
        Me.mnuDetalleAsiento.DesignerFlags = 1
        Me.mnuDetalleAsiento.DockWithinContainer = Me
        Me.mnuDetalleAsiento.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.mnuDetalleAsiento.MdiMergeable = False
        Me.mnuDetalleAsiento.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        Me.mnuDetalleAsiento.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(252, 298)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(447, 48)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4})
        UltraToolbar1.Text = "utMenuDetalle"
        Me.mnuDetalleAsiento.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance64.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance64
        ButtonTool6.SharedPropsInternal.Caption = "Agregar"
        ButtonTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance65.Image = Global.ISL.Win.My.Resources.Resources.Editar
        ButtonTool7.SharedPropsInternal.AppearancesSmall.Appearance = Appearance65
        ButtonTool7.SharedPropsInternal.Caption = "Editar"
        ButtonTool7.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance66.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        ButtonTool8.SharedPropsInternal.AppearancesSmall.Appearance = Appearance66
        ButtonTool8.SharedPropsInternal.Caption = "Eliminar"
        ButtonTool8.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance67.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        ButtonTool9.SharedPropsInternal.AppearancesSmall.Appearance = Appearance67
        ButtonTool9.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance68.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool10.SharedPropsInternal.AppearancesSmall.Appearance = Appearance68
        ButtonTool10.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool11.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool12.SharedPropsInternal.Caption = "ButtonTool2"
        ButtonTool13.SharedPropsInternal.Caption = "ButtonTool3"
        Appearance69.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool14.SharedPropsInternal.AppearancesSmall.Appearance = Appearance69
        ButtonTool14.SharedPropsInternal.Caption = "Consultar"
        ButtonTool14.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance70.Image = CType(resources.GetObject("Appearance70.Image"), Object)
        ButtonTool15.SharedPropsInternal.AppearancesSmall.Appearance = Appearance70
        ButtonTool15.SharedPropsInternal.Caption = "Exportar"
        ButtonTool15.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance71.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        ButtonTool17.SharedPropsInternal.AppearancesSmall.Appearance = Appearance71
        ButtonTool17.SharedPropsInternal.Caption = "Modificar"
        ButtonTool17.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnuDetalleAsiento.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool11, ButtonTool12, ButtonTool13, ButtonTool14, ButtonTool15, ButtonTool17})
        '
        'UltraToolbarsDockArea2
        '
        Me.UltraToolbarsDockArea2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea2.Location = New System.Drawing.Point(2, 23)
        Me.UltraToolbarsDockArea2.Name = "UltraToolbarsDockArea2"
        Me.UltraToolbarsDockArea2.Size = New System.Drawing.Size(1210, 0)
        Me.UltraToolbarsDockArea2.ToolbarsManager = Me.mnuDetalleAsiento
        '
        'UltraToolbarsDockArea3
        '
        Me.UltraToolbarsDockArea3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea3.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea3.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea3.Name = "UltraToolbarsDockArea3"
        Me.UltraToolbarsDockArea3.Size = New System.Drawing.Size(0, 21)
        Me.UltraToolbarsDockArea3.ToolbarsManager = Me.mnuDetalleAsiento
        '
        'UltraToolbarsDockArea4
        '
        Me.UltraToolbarsDockArea4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea4.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea4.Location = New System.Drawing.Point(1212, 2)
        Me.UltraToolbarsDockArea4.Name = "UltraToolbarsDockArea4"
        Me.UltraToolbarsDockArea4.Size = New System.Drawing.Size(0, 21)
        Me.UltraToolbarsDockArea4.ToolbarsManager = Me.mnuDetalleAsiento
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Top
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(2, 2)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Top"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1210, 0)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Bottom
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(2, 23)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Bottom"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1210, 0)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Left
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(2, 2)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Left"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 21)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Right
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1212, 2)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Right"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 21)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.gridComprobanteVenta)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1228, 429)
        '
        'gridComprobanteVenta
        '
        Me.gridComprobanteVenta.ContextMenuStrip = Me.MenuCabecera
        Me.gridComprobanteVenta.DataSource = Me.UltraDataSource1
        UltraGridColumn187.Header.VisiblePosition = 0
        UltraGridColumn187.Hidden = True
        UltraGridColumn188.Header.Caption = "Periodo"
        UltraGridColumn188.Header.VisiblePosition = 1
        UltraGridColumn188.Width = 61
        UltraGridColumn189.Header.Caption = "Tipo Doc"
        UltraGridColumn189.Header.VisiblePosition = 2
        UltraGridColumn189.Width = 97
        UltraGridColumn190.Header.VisiblePosition = 3
        UltraGridColumn190.Width = 47
        UltraGridColumn191.Header.VisiblePosition = 4
        UltraGridColumn191.Width = 82
        UltraGridColumn192.Header.Caption = "Fec Emision"
        UltraGridColumn192.Header.VisiblePosition = 5
        UltraGridColumn192.Width = 86
        UltraGridColumn193.Header.Caption = "Fec Venc."
        UltraGridColumn193.Header.VisiblePosition = 6
        UltraGridColumn193.Width = 80
        UltraGridColumn194.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn194.CellAppearance = Appearance2
        UltraGridColumn194.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn194.Format = "#,##0.00"
        UltraGridColumn194.Header.VisiblePosition = 15
        UltraGridColumn194.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn194.Width = 67
        UltraGridColumn195.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn195.CellAppearance = Appearance3
        UltraGridColumn195.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn195.Format = "#,##0.00"
        UltraGridColumn195.Header.VisiblePosition = 14
        UltraGridColumn195.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn196.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn196.CellAppearance = Appearance4
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn196.CellButtonAppearance = Appearance5
        UltraGridColumn196.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn196.Format = "#,##0.00"
        UltraGridColumn196.Header.VisiblePosition = 16
        UltraGridColumn196.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn197.Header.VisiblePosition = 8
        UltraGridColumn197.Hidden = True
        UltraGridColumn198.Header.Caption = "Cliente"
        UltraGridColumn198.Header.VisiblePosition = 7
        UltraGridColumn198.Width = 268
        UltraGridColumn199.Header.VisiblePosition = 10
        UltraGridColumn199.Hidden = True
        UltraGridColumn200.Header.VisiblePosition = 9
        UltraGridColumn200.Hidden = True
        UltraGridColumn201.Header.VisiblePosition = 11
        UltraGridColumn201.Hidden = True
        UltraGridColumn202.Header.Caption = "Mon."
        UltraGridColumn202.Header.VisiblePosition = 12
        UltraGridColumn202.Width = 43
        UltraGridColumn203.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn203.CellAppearance = Appearance6
        UltraGridColumn203.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn203.Format = "#,##0.0000"
        UltraGridColumn203.Header.Caption = "T.C"
        UltraGridColumn203.Header.VisiblePosition = 13
        UltraGridColumn203.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn203.Width = 55
        UltraGridColumn204.Header.VisiblePosition = 17
        UltraGridColumn205.Header.VisiblePosition = 18
        UltraGridColumn205.Hidden = True
        UltraGridColumn206.Header.VisiblePosition = 19
        UltraGridColumn206.Hidden = True
        UltraGridColumn207.Header.VisiblePosition = 20
        UltraGridColumn207.Hidden = True
        UltraGridColumn208.Header.VisiblePosition = 21
        UltraGridColumn208.Hidden = True
        UltraGridColumn209.Header.VisiblePosition = 22
        UltraGridColumn209.Hidden = True
        UltraGridColumn210.Header.VisiblePosition = 23
        UltraGridColumn210.Hidden = True
        UltraGridColumn211.Header.VisiblePosition = 24
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.VisiblePosition = 25
        UltraGridColumn212.Hidden = True
        UltraGridColumn213.Header.VisiblePosition = 26
        UltraGridColumn213.Hidden = True
        UltraGridColumn214.Header.VisiblePosition = 27
        UltraGridColumn214.Hidden = True
        UltraGridColumn215.Header.VisiblePosition = 28
        UltraGridColumn215.Hidden = True
        UltraGridColumn216.Header.VisiblePosition = 29
        UltraGridColumn216.Hidden = True
        UltraGridColumn217.Header.VisiblePosition = 30
        UltraGridColumn217.Hidden = True
        UltraGridColumn218.Header.VisiblePosition = 31
        UltraGridColumn218.Hidden = True
        UltraGridColumn219.Header.VisiblePosition = 32
        UltraGridColumn219.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 33
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 34
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 35
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 36
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 37
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 38
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 39
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 40
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 41
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 42
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 43
        UltraGridColumn12.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Me.gridComprobanteVenta.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.gridComprobanteVenta.DisplayLayout.MaxColScrollRegions = 1
        Me.gridComprobanteVenta.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridComprobanteVenta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridComprobanteVenta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridComprobanteVenta.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridComprobanteVenta.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridComprobanteVenta.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridComprobanteVenta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridComprobanteVenta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridComprobanteVenta.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridComprobanteVenta.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridComprobanteVenta.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridComprobanteVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridComprobanteVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridComprobanteVenta.Location = New System.Drawing.Point(0, 55)
        Me.gridComprobanteVenta.Name = "gridComprobanteVenta"
        Me.gridComprobanteVenta.Size = New System.Drawing.Size(1228, 374)
        Me.gridComprobanteVenta.TabIndex = 1
        Me.gridComprobanteVenta.Text = "Comprobante Venta"
        '
        'MenuCabecera
        '
        Me.MenuCabecera.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarCabecera, Me.EditarCabecera, Me.EliminaCabecera})
        Me.MenuCabecera.Name = "mnu_Transferencias"
        Me.MenuCabecera.Size = New System.Drawing.Size(122, 82)
        '
        'AgregarCabecera
        '
        Me.AgregarCabecera.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarCabecera.Name = "AgregarCabecera"
        Me.AgregarCabecera.Size = New System.Drawing.Size(121, 26)
        Me.AgregarCabecera.Text = "Agregar"
        '
        'EditarCabecera
        '
        Me.EditarCabecera.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarCabecera.Name = "EditarCabecera"
        Me.EditarCabecera.Size = New System.Drawing.Size(121, 26)
        Me.EditarCabecera.Text = "Editar"
        '
        'EliminaCabecera
        '
        Me.EliminaCabecera.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminaCabecera.Name = "EliminaCabecera"
        Me.EliminaCabecera.Size = New System.Drawing.Size(121, 26)
        Me.EliminaCabecera.Text = "Eliminar"
        '
        'UltraDataSource1
        '
        UltraDataColumn96.DataType = GetType(Boolean)
        UltraDataColumn99.DataType = GetType(Boolean)
        UltraDataColumn101.DataType = GetType(Boolean)
        UltraDataColumn103.DataType = GetType(Boolean)
        UltraDataColumn104.DataType = GetType(Boolean)
        UltraDataColumn105.DataType = GetType(Double)
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.btn_Extornar)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion1.Controls.Add(Me.cboMes)
        Me.Agrupacion1.Controls.Add(Me.Año1)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1228, 55)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Busca"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btn_Extornar
        '
        Appearance7.Image = 5
        Me.btn_Extornar.Appearance = Appearance7
        Me.btn_Extornar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btn_Extornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Extornar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Extornar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Extornar.ForeColor = System.Drawing.Color.Black
        Me.btn_Extornar.ImageList = Me.imagenes
        Me.btn_Extornar.Location = New System.Drawing.Point(1110, 17)
        Me.btn_Extornar.Name = "btn_Extornar"
        Me.btn_Extornar.Size = New System.Drawing.Size(115, 35)
        Me.btn_Extornar.TabIndex = 3
        Me.btn_Extornar.Text = "Extornar Emision"
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
        'Etiqueta7
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance8
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(137, 28)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(30, 14)
        Me.Etiqueta7.TabIndex = 1
        Me.Etiqueta7.Text = "Mes:"
        '
        'cboMes
        '
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Appearance = Appearance9
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Location = New System.Drawing.Point(173, 24)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(125, 21)
        Me.cboMes.TabIndex = 2
        Me.cboMes.ValueMember = "Id"
        '
        'Año1
        '
        Me.Año1.Año = 2020
        Me.Año1.Controls.Add(Me.numAño)
        Me.Año1.Location = New System.Drawing.Point(77, 24)
        Me.Año1.Name = "Año1"
        Me.Año1.Size = New System.Drawing.Size(54, 23)
        Me.Año1.TabIndex = 4
        '
        'numAño
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance10
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
        'Etiqueta2
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance11
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(19, 28)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta2.TabIndex = 0
        Me.Etiqueta2.Text = "Ejercicio:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl2.Controls.Add(Me.agrCabeceraAsiento)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1228, 429)
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.tcComprobanteDetalle)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 175)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1228, 254)
        Me.Agrupacion3.TabIndex = 1
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'tcComprobanteDetalle
        '
        Me.tcComprobanteDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tcComprobanteDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.tcComprobanteDetalle.Controls.Add(Me.UltraTabPageControl4)
        Me.tcComprobanteDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcComprobanteDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcComprobanteDetalle.Location = New System.Drawing.Point(2, 2)
        Me.tcComprobanteDetalle.Name = "tcComprobanteDetalle"
        Me.tcComprobanteDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tcComprobanteDetalle.Size = New System.Drawing.Size(1224, 250)
        Me.tcComprobanteDetalle.TabIndex = 0
        UltraTab3.Key = "Tab1"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Lista"
        UltraTab4.Key = "Tab2"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Matenimiento"
        Me.tcComprobanteDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.tcComprobanteDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1222, 227)
        '
        'agrCabeceraAsiento
        '
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.BackColor2 = System.Drawing.Color.White
        Me.agrCabeceraAsiento.ContentAreaAppearance = Appearance12
        Me.agrCabeceraAsiento.Controls.Add(Me.cboTipo)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta11)
        Me.agrCabeceraAsiento.Controls.Add(Me.cboServicio)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta6)
        Me.agrCabeceraAsiento.Controls.Add(Me.EtiPeriodo)
        Me.agrCabeceraAsiento.Controls.Add(Me.Agrupacion2)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta1)
        Me.agrCabeceraAsiento.Controls.Add(Me.cboTipoVenta)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta31)
        Me.agrCabeceraAsiento.Controls.Add(Me.cboCtaCte)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta30)
        Me.agrCabeceraAsiento.Controls.Add(Me.FecVencimiento)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta29)
        Me.agrCabeceraAsiento.Controls.Add(Me.FecEmision)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta28)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta4)
        Me.agrCabeceraAsiento.Controls.Add(Me.txtNroDocumento)
        Me.agrCabeceraAsiento.Controls.Add(Me.decTC)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta27)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta3)
        Me.agrCabeceraAsiento.Controls.Add(Me.txtNroSerie)
        Me.agrCabeceraAsiento.Controls.Add(Me.cboMoneda)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta26)
        Me.agrCabeceraAsiento.Controls.Add(Me.cboTipoDocumento)
        Me.agrCabeceraAsiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrCabeceraAsiento.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCabeceraAsiento.ForeColor = System.Drawing.Color.Black
        Me.agrCabeceraAsiento.Location = New System.Drawing.Point(0, 0)
        Me.agrCabeceraAsiento.Name = "agrCabeceraAsiento"
        Me.agrCabeceraAsiento.Size = New System.Drawing.Size(1228, 175)
        Me.agrCabeceraAsiento.TabIndex = 0
        Me.agrCabeceraAsiento.Text = "Datos:"
        Me.agrCabeceraAsiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboTipo
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipo.Appearance = Appearance13
        Me.cboTipo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance14.Image = 7
        EditorButton1.Appearance = Appearance14
        Me.cboTipo.ButtonsRight.Add(EditorButton1)
        Me.cboTipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipo.DropDownListWidth = 400
        Me.cboTipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipo.ImageList = Me.imagenes
        Me.cboTipo.Location = New System.Drawing.Point(414, 73)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(250, 21)
        Me.cboTipo.TabIndex = 17
        Me.cboTipo.ValueMember = "Id"
        '
        'Etiqueta11
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.FontData.BoldAsString = "True"
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance15
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(381, 75)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(30, 14)
        Me.Etiqueta11.TabIndex = 16
        Me.Etiqueta11.Text = "Tipo:"
        '
        'cboServicio
        '
        Appearance16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboServicio.Appearance = Appearance16
        Me.cboServicio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance17.Image = 7
        EditorButton2.Appearance = Appearance17
        Me.cboServicio.ButtonsRight.Add(EditorButton2)
        Me.cboServicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboServicio.DropDownListWidth = 400
        Me.cboServicio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServicio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboServicio.ImageList = Me.imagenes
        Me.cboServicio.Location = New System.Drawing.Point(737, 49)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Size = New System.Drawing.Size(250, 21)
        Me.cboServicio.TabIndex = 20
        Me.cboServicio.ValueMember = "Id"
        '
        'Etiqueta6
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.FontData.BoldAsString = "True"
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance18
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(686, 54)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(48, 14)
        Me.Etiqueta6.TabIndex = 19
        Me.Etiqueta6.Text = "Servicio:"
        '
        'EtiPeriodo
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.EtiPeriodo.Appearance = Appearance19
        Me.EtiPeriodo.AutoSize = True
        Me.EtiPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiPeriodo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.EtiPeriodo.Location = New System.Drawing.Point(670, 23)
        Me.EtiPeriodo.Name = "EtiPeriodo"
        Me.EtiPeriodo.Size = New System.Drawing.Size(67, 21)
        Me.EtiPeriodo.TabIndex = 18
        Me.EtiPeriodo.Text = "Periodo:"
        '
        'Agrupacion2
        '
        Appearance20.BackColor = System.Drawing.Color.White
        Appearance20.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion2.ContentAreaAppearance = Appearance20
        Me.Agrupacion2.Controls.Add(Me.agrDetraccion)
        Me.Agrupacion2.Controls.Add(Me.DecGravado)
        Me.Agrupacion2.Controls.Add(Me.DecExonerado)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion2.Controls.Add(Me.DecTotalVenta)
        Me.Agrupacion2.Controls.Add(Me.DecInafecta)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion2.Controls.Add(Me.DecTotalDoc)
        Me.Agrupacion2.Controls.Add(Me.DecIsc)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion2.Controls.Add(Me.DecOtrosTributos)
        Me.Agrupacion2.Controls.Add(Me.DecIgv)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(3, 97)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1222, 75)
        Me.Agrupacion2.TabIndex = 23
        Me.Agrupacion2.Text = "Totales"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'DecGravado
        '
        Appearance27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecGravado.Appearance = Appearance27
        Me.DecGravado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecGravado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecGravado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecGravado.Location = New System.Drawing.Point(69, 22)
        Me.DecGravado.Name = "DecGravado"
        Me.DecGravado.NullText = "0.00"
        Me.DecGravado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecGravado.Size = New System.Drawing.Size(100, 21)
        Me.DecGravado.TabIndex = 1
        '
        'DecExonerado
        '
        Appearance28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecExonerado.Appearance = Appearance28
        Me.DecExonerado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecExonerado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecExonerado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecExonerado.Location = New System.Drawing.Point(69, 46)
        Me.DecExonerado.Name = "DecExonerado"
        Me.DecExonerado.NullText = "0.00"
        Me.DecExonerado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecExonerado.Size = New System.Drawing.Size(100, 21)
        Me.DecExonerado.TabIndex = 3
        '
        'Etiqueta13
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance29
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(18, 26)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta13.TabIndex = 0
        Me.Etiqueta13.Text = "Gravado:"
        '
        'Etiqueta14
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta14.Appearance = Appearance30
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Location = New System.Drawing.Point(505, 50)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta14.TabIndex = 14
        Me.Etiqueta14.Text = "Total Doc:"
        '
        'Etiqueta12
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance31
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(7, 50)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta12.TabIndex = 2
        Me.Etiqueta12.Text = "Exonerado:"
        '
        'DecTotalVenta
        '
        Appearance32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalVenta.Appearance = Appearance32
        Me.DecTotalVenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotalVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotalVenta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalVenta.Location = New System.Drawing.Point(562, 22)
        Me.DecTotalVenta.Name = "DecTotalVenta"
        Me.DecTotalVenta.NullText = "0.00"
        Me.DecTotalVenta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotalVenta.Size = New System.Drawing.Size(100, 21)
        Me.DecTotalVenta.TabIndex = 13
        '
        'DecInafecta
        '
        Appearance33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecInafecta.Appearance = Appearance33
        Me.DecInafecta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecInafecta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecInafecta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecInafecta.Location = New System.Drawing.Point(255, 22)
        Me.DecInafecta.Name = "DecInafecta"
        Me.DecInafecta.NullText = "0.00"
        Me.DecInafecta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecInafecta.Size = New System.Drawing.Size(100, 21)
        Me.DecInafecta.TabIndex = 5
        '
        'Etiqueta15
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta15.Appearance = Appearance34
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(496, 26)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(63, 14)
        Me.Etiqueta15.TabIndex = 12
        Me.Etiqueta15.Text = "Total Venta:"
        '
        'Etiqueta5
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance35
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(207, 26)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta5.TabIndex = 4
        Me.Etiqueta5.Text = "Inafecta:"
        '
        'DecTotalDoc
        '
        Appearance36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalDoc.Appearance = Appearance36
        Me.DecTotalDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotalDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotalDoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecTotalDoc.Location = New System.Drawing.Point(562, 46)
        Me.DecTotalDoc.Name = "DecTotalDoc"
        Me.DecTotalDoc.NullText = "0.00"
        Me.DecTotalDoc.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotalDoc.Size = New System.Drawing.Size(100, 21)
        Me.DecTotalDoc.TabIndex = 15
        '
        'DecIsc
        '
        Appearance37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIsc.Appearance = Appearance37
        Me.DecIsc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecIsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecIsc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIsc.Location = New System.Drawing.Point(390, 46)
        Me.DecIsc.Name = "DecIsc"
        Me.DecIsc.NullText = "0.00"
        Me.DecIsc.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecIsc.Size = New System.Drawing.Size(100, 21)
        Me.DecIsc.TabIndex = 11
        '
        'Etiqueta8
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance38
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(176, 50)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(77, 14)
        Me.Etiqueta8.TabIndex = 6
        Me.Etiqueta8.Text = "Otros Tributos:"
        '
        'Etiqueta10
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance39
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(362, 26)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(26, 14)
        Me.Etiqueta10.TabIndex = 8
        Me.Etiqueta10.Text = "IGV:"
        '
        'DecOtrosTributos
        '
        Appearance40.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecOtrosTributos.Appearance = Appearance40
        Me.DecOtrosTributos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecOtrosTributos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecOtrosTributos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecOtrosTributos.Location = New System.Drawing.Point(255, 46)
        Me.DecOtrosTributos.Name = "DecOtrosTributos"
        Me.DecOtrosTributos.NullText = "0.00"
        Me.DecOtrosTributos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecOtrosTributos.Size = New System.Drawing.Size(100, 21)
        Me.DecOtrosTributos.TabIndex = 7
        '
        'DecIgv
        '
        Appearance41.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIgv.Appearance = Appearance41
        Me.DecIgv.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecIgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecIgv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecIgv.Location = New System.Drawing.Point(390, 22)
        Me.DecIgv.Name = "DecIgv"
        Me.DecIgv.NullText = "0.00"
        Me.DecIgv.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecIgv.Size = New System.Drawing.Size(100, 21)
        Me.DecIgv.TabIndex = 9
        '
        'Etiqueta9
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance42
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(363, 50)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(25, 14)
        Me.Etiqueta9.TabIndex = 10
        Me.Etiqueta9.Text = "ISC:"
        '
        'Etiqueta1
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.FontData.BoldAsString = "True"
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance43
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(672, 77)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta1.TabIndex = 21
        Me.Etiqueta1.Text = "Tipo Venta:"
        '
        'cboTipoVenta
        '
        Appearance44.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoVenta.Appearance = Appearance44
        Me.cboTipoVenta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance45.Image = 7
        EditorButton3.Appearance = Appearance45
        Me.cboTipoVenta.ButtonsRight.Add(EditorButton3)
        Me.cboTipoVenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoVenta.DropDownListWidth = 400
        Me.cboTipoVenta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoVenta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoVenta.ImageList = Me.imagenes
        Me.cboTipoVenta.Location = New System.Drawing.Point(737, 73)
        Me.cboTipoVenta.Name = "cboTipoVenta"
        Me.cboTipoVenta.Size = New System.Drawing.Size(250, 21)
        Me.cboTipoVenta.TabIndex = 22
        Me.cboTipoVenta.ValueMember = "Id"
        '
        'Etiqueta31
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.FontData.BoldAsString = "True"
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance46
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(365, 52)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta31.TabIndex = 14
        Me.Etiqueta31.Text = "Cta Cte:"
        '
        'cboCtaCte
        '
        Appearance47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaCte.Appearance = Appearance47
        Me.cboCtaCte.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance48.Image = 7
        EditorButton4.Appearance = Appearance48
        Me.cboCtaCte.ButtonsRight.Add(EditorButton4)
        Me.cboCtaCte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaCte.DropDownListWidth = 400
        Me.cboCtaCte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaCte.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaCte.ImageList = Me.imagenes
        Me.cboCtaCte.Location = New System.Drawing.Point(414, 49)
        Me.cboCtaCte.Name = "cboCtaCte"
        Me.cboCtaCte.Size = New System.Drawing.Size(250, 21)
        Me.cboCtaCte.TabIndex = 15
        Me.cboCtaCte.ValueMember = "Id"
        '
        'Etiqueta30
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.FontData.BoldAsString = "True"
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance49
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta30.Location = New System.Drawing.Point(172, 51)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta30.TabIndex = 6
        Me.Etiqueta30.Text = "Vencimiento:"
        '
        'FecVencimiento
        '
        Appearance50.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecVencimiento.Appearance = Appearance50
        Me.FecVencimiento.DateTime = New Date(2011, 11, 29, 0, 0, 0, 0)
        Me.FecVencimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecVencimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecVencimiento.Location = New System.Drawing.Point(245, 48)
        Me.FecVencimiento.Name = "FecVencimiento"
        Me.FecVencimiento.Size = New System.Drawing.Size(100, 21)
        Me.FecVencimiento.TabIndex = 7
        Me.FecVencimiento.Value = New Date(2011, 11, 29, 0, 0, 0, 0)
        '
        'Etiqueta29
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.FontData.BoldAsString = "True"
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance51
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta29.Location = New System.Drawing.Point(9, 51)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(48, 14)
        Me.Etiqueta29.TabIndex = 2
        Me.Etiqueta29.Text = "Emision:"
        '
        'FecEmision
        '
        Appearance52.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecEmision.Appearance = Appearance52
        Me.FecEmision.DateTime = New Date(2011, 11, 29, 0, 0, 0, 0)
        Me.FecEmision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecEmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecEmision.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecEmision.Location = New System.Drawing.Point(60, 48)
        Me.FecEmision.Name = "FecEmision"
        Me.FecEmision.Size = New System.Drawing.Size(100, 21)
        Me.FecEmision.TabIndex = 3
        Me.FecEmision.Value = New Date(2011, 11, 29, 0, 0, 0, 0)
        '
        'Etiqueta28
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.FontData.BoldAsString = "True"
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance53
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta28.Location = New System.Drawing.Point(498, 29)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(48, 14)
        Me.Etiqueta28.TabIndex = 12
        Me.Etiqueta28.Text = "Numero:"
        '
        'Etiqueta4
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.FontData.BoldAsString = "True"
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance54
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(170, 74)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(72, 14)
        Me.Etiqueta4.TabIndex = 8
        Me.Etiqueta4.Text = "Tipo Cambio:"
        '
        'txtNroDocumento
        '
        Appearance55.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroDocumento.Appearance = Appearance55
        Me.txtNroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroDocumento.Location = New System.Drawing.Point(549, 25)
        Me.txtNroDocumento.MaxLength = 10
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(114, 21)
        Me.txtNroDocumento.TabIndex = 13
        '
        'decTC
        '
        Appearance56.ForeColor = System.Drawing.Color.Black
        Me.decTC.Appearance = Appearance56
        Me.decTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTC.ForeColor = System.Drawing.Color.Black
        Me.decTC.FormatString = ""
        Me.decTC.Location = New System.Drawing.Point(245, 71)
        Me.decTC.MaskInput = "{double:6.4}"
        Me.decTC.Name = "decTC"
        Me.decTC.NullText = "0.00"
        Me.decTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTC.Size = New System.Drawing.Size(100, 21)
        Me.decTC.TabIndex = 9
        '
        'Etiqueta27
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.FontData.BoldAsString = "True"
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance57
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta27.Location = New System.Drawing.Point(377, 28)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(34, 14)
        Me.Etiqueta27.TabIndex = 10
        Me.Etiqueta27.Text = "Serie:"
        '
        'Etiqueta3
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.FontData.BoldAsString = "True"
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance58
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(9, 74)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(48, 14)
        Me.Etiqueta3.TabIndex = 4
        Me.Etiqueta3.Text = "Moneda:"
        '
        'txtNroSerie
        '
        Appearance59.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroSerie.Appearance = Appearance59
        Me.txtNroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroSerie.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroSerie.Location = New System.Drawing.Point(414, 25)
        Me.txtNroSerie.MaxLength = 4
        Me.txtNroSerie.Name = "txtNroSerie"
        Me.txtNroSerie.Size = New System.Drawing.Size(68, 21)
        Me.txtNroSerie.TabIndex = 11
        '
        'cboMoneda
        '
        Appearance60.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance60
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(60, 71)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(100, 21)
        Me.cboMoneda.TabIndex = 5
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta26
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.FontData.BoldAsString = "True"
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance61
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Etiqueta26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta26.Location = New System.Drawing.Point(4, 28)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta26.TabIndex = 0
        Me.Etiqueta26.Text = "Tipo Doc:"
        '
        'cboTipoDocumento
        '
        Appearance62.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDocumento.Appearance = Appearance62
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance63.Image = 7
        EditorButton5.Appearance = Appearance63
        Me.cboTipoDocumento.ButtonsRight.Add(EditorButton5)
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.DropDownListWidth = 400
        Me.cboTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDocumento.ImageList = Me.imagenes
        Me.cboTipoDocumento.Location = New System.Drawing.Point(60, 25)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(285, 21)
        Me.cboTipoDocumento.TabIndex = 1
        Me.cboTipoDocumento.ValueMember = "Id"
        '
        'tcComprobanteVenta
        '
        Me.tcComprobanteVenta.Controls.Add(Me.UltraTabPageControl1)
        Me.tcComprobanteVenta.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcComprobanteVenta.Controls.Add(Me.UltraTabPageControl2)
        Me.tcComprobanteVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcComprobanteVenta.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcComprobanteVenta.Location = New System.Drawing.Point(0, 0)
        Me.tcComprobanteVenta.Name = "tcComprobanteVenta"
        Me.tcComprobanteVenta.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcComprobanteVenta.Size = New System.Drawing.Size(1230, 452)
        Me.tcComprobanteVenta.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcComprobanteVenta.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcComprobanteVenta.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1228, 429)
        '
        'agrDetraccion
        '
        Appearance21.BackColor = System.Drawing.Color.White
        Appearance21.BackColor2 = System.Drawing.Color.White
        Me.agrDetraccion.ContentAreaAppearance = Appearance21
        Me.agrDetraccion.Controls.Add(Me.UltraLabel5)
        Me.agrDetraccion.Controls.Add(Me.DecDetraer)
        Me.agrDetraccion.Controls.Add(Me.UltraLabel9)
        Me.agrDetraccion.Controls.Add(Me.DecMontoDetraccion)
        Me.agrDetraccion.Controls.Add(Me.UltraLabel8)
        Me.agrDetraccion.Controls.Add(Me.txtNetoPagar)
        Me.agrDetraccion.Dock = System.Windows.Forms.DockStyle.Right
        Me.agrDetraccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetraccion.ForeColor = System.Drawing.Color.Black
        Me.agrDetraccion.Location = New System.Drawing.Point(944, 17)
        Me.agrDetraccion.Name = "agrDetraccion"
        Me.agrDetraccion.Size = New System.Drawing.Size(275, 55)
        Me.agrDetraccion.TabIndex = 16
        Me.agrDetraccion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel5
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Appearance22.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance22
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(4, 8)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(76, 15)
        Me.UltraLabel5.TabIndex = 0
        Me.UltraLabel5.Text = "Detracción %:"
        '
        'DecDetraer
        '
        Me.DecDetraer.Location = New System.Drawing.Point(83, 4)
        Me.DecDetraer.MaskInput = "nnn.nn"
        Me.DecDetraer.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DecDetraer.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DecDetraer.Name = "DecDetraer"
        Me.DecDetraer.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.DecDetraer.Size = New System.Drawing.Size(63, 22)
        Me.DecDetraer.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.DecDetraer.TabIndex = 1
        '
        'UltraLabel9
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Appearance23.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance23
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(9, 32)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel9.TabIndex = 2
        Me.UltraLabel9.Text = "Monto:"
        '
        'DecMontoDetraccion
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.DecMontoDetraccion.Appearance = Appearance24
        Me.DecMontoDetraccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecMontoDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecMontoDetraccion.ForeColor = System.Drawing.Color.Black
        Me.DecMontoDetraccion.Location = New System.Drawing.Point(51, 29)
        Me.DecMontoDetraccion.MaskInput = "nnnnnnnnn.nn"
        Me.DecMontoDetraccion.Name = "DecMontoDetraccion"
        Me.DecMontoDetraccion.NullText = "0.00"
        Me.DecMontoDetraccion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecMontoDetraccion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DecMontoDetraccion.ReadOnly = True
        Me.DecMontoDetraccion.Size = New System.Drawing.Size(95, 21)
        Me.DecMontoDetraccion.TabIndex = 4
        '
        'UltraLabel8
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance25
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(196, 9)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(73, 15)
        Me.UltraLabel8.TabIndex = 5
        Me.UltraLabel8.Text = "Neto a Pagar:"
        '
        'txtNetoPagar
        '
        Appearance26.ForeColor = System.Drawing.Color.Black
        Me.txtNetoPagar.Appearance = Appearance26
        Me.txtNetoPagar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNetoPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetoPagar.ForeColor = System.Drawing.Color.Black
        Me.txtNetoPagar.Location = New System.Drawing.Point(174, 29)
        Me.txtNetoPagar.MaskInput = "nnnnnnnnn.nn"
        Me.txtNetoPagar.Name = "txtNetoPagar"
        Me.txtNetoPagar.NullText = "0.00"
        Me.txtNetoPagar.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtNetoPagar.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNetoPagar.ReadOnly = True
        Me.txtNetoPagar.Size = New System.Drawing.Size(95, 21)
        Me.txtNetoPagar.TabIndex = 6
        '
        'frm_ComprobanteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1230, 452)
        Me.Controls.Add(Me.tcComprobanteVenta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ComprobanteVentas"
        Me.Text = "Comprobante Ventas"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.GriComprobanteAsociado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        CType(Me.GriSeleccionaComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion10.ResumeLayout(False)
        CType(Me.mnuDetalleAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.gridComprobanteVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuCabecera.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Año1.ResumeLayout(False)
        Me.Año1.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.tcComprobanteDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcComprobanteDetalle.ResumeLayout(False)
        CType(Me.agrCabeceraAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrCabeceraAsiento.ResumeLayout(False)
        Me.agrCabeceraAsiento.PerformLayout()
        CType(Me.cboTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.DecGravado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecExonerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTotalVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecInafecta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTotalDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecIsc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecOtrosTributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecIgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecEmision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcComprobanteVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcComprobanteVenta.ResumeLayout(False)
        CType(Me.agrDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetraccion.ResumeLayout(False)
        Me.agrDetraccion.PerformLayout()
        CType(Me.DecDetraer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecMontoDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetoPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcComprobanteVenta As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents tcComprobanteDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents cboCtaCte As ISL.Controles.Combo
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents FecVencimiento As ISL.Controles.Fecha
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents FecEmision As ISL.Controles.Fecha
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroDocumento As ISL.Controles.Texto
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroSerie As ISL.Controles.Texto
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoDocumento As ISL.Controles.Combo
    Friend WithEvents Agrupacion10 As ISL.Controles.Agrupacion
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents agrCabeceraAsiento As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents decTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents MenuCabecera As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarCabecera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarCabecera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminaCabecera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoVenta As ISL.Controles.Combo
    Friend WithEvents gridComprobanteVenta As ISL.Controles.Grilla
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents DecGravado As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents DecExonerado As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents DecInafecta As ISL.Controles.NumeroDecimal
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents DecTotalVenta As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents DecTotalDoc As ISL.Controles.NumeroDecimal
    Friend WithEvents DecIsc As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents DecOtrosTributos As ISL.Controles.NumeroDecimal
    Friend WithEvents DecIgv As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents mnuDetalleAsiento As ISL.Controles.Menu
    Friend WithEvents UltraToolbarsDockArea2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea3 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea4 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents GriComprobanteAsociado As ISL.Controles.Grilla
    Friend WithEvents GriSeleccionaComprobante As ISL.Controles.Grilla
    Friend WithEvents EtiPeriodo As ISL.Controles.Etiqueta
    Friend WithEvents btn_Extornar As ISL.Controles.Boton
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents cboTipo As ISL.Controles.Combo
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents cboServicio As ISL.Controles.Combo
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents agrDetraccion As Controles.Agrupacion
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DecDetraer As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DecMontoDetraccion As Controles.NumeroDecimal
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNetoPagar As Controles.NumeroDecimal
End Class
