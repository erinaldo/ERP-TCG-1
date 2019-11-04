'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.UltraChart.Shared.Styles

Public Class frm_ReporteFondoFijo
    Inherits frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_ReporteFondoFijo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_ReporteFondoFijo()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeReporteFondoFijo As New e_ReporteFondoFijo
    Dim olReporteFondoFijo As New l_ReporteFondoFijo

    Dim oeMovimientoViaje As New e_Movimiento_Viaje
    Dim olMovimientoViaje As New l_Movimiento_Viaje

    Dim oeMovimientoFlete As New e_Movimiento_Flete
    Dim olMovimientoFlete As New l_Movimiento_Flete

    Dim oeGrupo As New e_Grupo
    Dim olGrupo As New l_Grupo

    Dim oeGastoOperacion As New e_GastoOperacion
    Dim olGastoOperacion As New l_GastoOperacion

    Dim loReporteFondoFijo As New List(Of e_ReporteFondoFijo)

    'Dim Columnas() As String
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griMovimientoFondoFijo.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()

        If griMovimientoFondoFijo.ActiveRow.Cells("N").Value.ToString <> "" Then
            Exportar_Excel(griMovimientoFondoFijo)
        End If
        If griDetalle.Rows.Count > 0 Then
            Exportar_Excel(griDetalle)
        End If

    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim oeReporteFondoFijoDatos = New e_ReporteFondoFijo

            oeReporteFondoFijo = olReporteFondoFijo.ListarFondo(oeReporteFondoFijoDatos)

            With griMovimientoFondoFijo
                .ResetDisplayLayout()
                'Obtiene la información de bancos desde la BD

                .DataSource = oeReporteFondoFijo.loFondoFijo

                'Ordena los datos en forma ascendente por el campo Nombre
                .DisplayLayout.Bands(0).Columns("N").SortIndicator = SortOrder.Ascending
                .DisplayLayout.Bands(0).Columns("N").Hidden = True

                .DisplayLayout.Bands(0).Columns("Ingresos").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Egresos").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                .DisplayLayout.Bands(0).Columns("Ingresos").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Egresos").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("Ingresos").Format = "#,###,###,####0.00"
                .DisplayLayout.Bands(0).Columns("Egresos").Format = "#,###,###,####0.00"
                'Especificar el ancho de las columnas que se muestran
                .DisplayLayout.Bands(0).Columns("Referencia").Width = 155
                .DisplayLayout.Bands(0).Columns("Ingresos").Width = 70
                .DisplayLayout.Bands(0).Columns("Egresos").Width = 70
                .DisplayLayout.Bands(0).Columns("N").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Referencia").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Ingresos").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Egresos").Header.VisiblePosition = 4
                'Cofigura la grilla para que se seleccione la fila completa al hacer click en algun lado
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                    'CalcularTotales(griMovimientoFondoFijo, "Ingresos", "Egresos")
                    decEgresos.Value = oeReporteFondoFijo.loFondoFijo.Sum(Function(item) item.Egresos)
                    decIngresos.Value = oeReporteFondoFijo.loFondoFijo.Sum(Function(item) item.Ingresos)
                    decSaldo.Value = decIngresos.Value - decEgresos.Value
                End If
                .Rows(0).Hidden = True
                'CalcularTotales(griMovimientoFondoFijo, "Ingresos", "Egresos")
                GeneraGrafico()
            End With
            Dim oeFondoFijo As New e_FondoFijo
            Dim olFondoFijo As New l_FondoFijo
            oeFondoFijo.Activo = 2
            'Dim fondo As Double = Math.Round(olFondoFijo.Listar(oeFondoFijo).Item(0).FondoFijo, 2)
            'lblMaximo.Text = "IMPORTE MÁXIMO EN CAJA GENERAL: S/. " & CStr(FormatNumber(fondo, 2))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub GeneraGrafico()
        Try
            Dim dtPie As New DataTable
            dtPie.Columns.Add("Monto", System.Type.GetType("System.Double"))
            dtPie.Columns.Add("Nombre", System.Type.GetType("System.String"))

            For Each oe As e_ReporteFondoFijo In oeReporteFondoFijo.loFondoFijo
                If oe.Referencia <> "Fondo Fijo" Then dtPie.Rows.Add(oe.Egresos, oe.Referencia)
            Next

            graFondoFijo.Transform3D.XRotation = 50
            graFondoFijo.Transform3D.YRotation = 50
            graFondoFijo.Transform3D.ZRotation = 0
            graFondoFijo.Transform3D.Scale = 100

            graFondoFijo.Tooltips.Font = New Font("Arial", 10, FontStyle.Regular)
            graFondoFijo.Tooltips.Format = TooltipStyle.LabelPlusDataValue
            graFondoFijo.Tooltips.FormatString = "<ITEM_LABEL>: S/. <DATA_VALUE:#,###,##0.00>"

            graFondoFijo.Legend.Visible = True
            graFondoFijo.Legend.Location = LegendLocation.Right
            graFondoFijo.Legend.Font = New Font("Arial", 8, FontStyle.Regular)

            graFondoFijo.TitleTop.Text = "Distribución de Egresos"
            graFondoFijo.TitleTop.Font = New Font("Arial", 8, FontStyle.Bold)
            graFondoFijo.TitleTop.HorizontalAlign = StringAlignment.Center

            graFondoFijo.ChartType = ChartType.PieChart3D

            graFondoFijo.PieChart3D.Labels.Font = New Font("Arial", 12, FontStyle.Bold)
            graFondoFijo.PieChart3D.OthersCategoryPercent = 0.0001

            graFondoFijo.PieChart3D.Labels.LeaderDrawStyle = LineDrawStyle.Solid
            graFondoFijo.PieChart3D.Labels.LeaderEndStyle = LineCapStyle.ArrowAnchor
            graFondoFijo.PieChart3D.Labels.LeaderLineColor = Color.Black
            graFondoFijo.PieChart3D.Labels.LeaderLineThickness = 4

            graFondoFijo.ColorModel.AlphaLevel = 200
            graFondoFijo.ColorModel.ModelStyle = ColorModels.CustomLinear
            graFondoFijo.ColorModel.Scaling = ColorScaling.Increasing

            graFondoFijo.DataSource = dtPie
            graFondoFijo.DataBind()
            ControlBoton(1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteFondoFijo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_ReporteFondoFijo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_ReporteFondoFijo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Listar(True)
    End Sub

    Private Sub griMovimientoFondoFijo_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griMovimientoFondoFijo.AfterRowActivate
        Try
            Cursor.Current = Cursors.WaitCursor
            If griMovimientoFondoFijo.Rows.Count > 0 Then

                Select Case griMovimientoFondoFijo.ActiveRow.Cells("N").Value.ToString
                    Case "a"
                        griDetalle.ResetDisplayLayout()
                        griDetalle.DataSource = Nothing
                    Case "b"
                        With griDetalle
                            .ResetDisplayLayout()
                            .DataSource = oeReporteFondoFijo.loFlete
                            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdOperacionDetalle").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdMovimiento").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCheque").Hidden = False
                            .DisplayLayout.Bands(0).Columns("IdCheque").Header.Caption = "FechaCobro"
                            .DisplayLayout.Bands(0).Columns("Importe").Hidden = True
                            .DisplayLayout.Bands(0).Columns("TipoCobro").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Cobrado").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCliente").Hidden = True
                            .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
                            .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Nombre").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdGrupo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Hidden = True

                            .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 1
                            .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 2
                            .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 3
                            .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 4
                            .DisplayLayout.Bands(0).Columns("Cargado").Header.VisiblePosition = 5
                            .DisplayLayout.Bands(0).Columns("Origen").Header.VisiblePosition = 6
                            .DisplayLayout.Bands(0).Columns("Destino").Header.VisiblePosition = 7
                            .DisplayLayout.Bands(0).Columns("Cliente").Header.VisiblePosition = 8
                            .DisplayLayout.Bands(0).Columns("Carga").Header.VisiblePosition = 9
                            .DisplayLayout.Bands(0).Columns("Flete").Header.VisiblePosition = 10
                            .DisplayLayout.Bands(0).Columns("Depositado").Header.VisiblePosition = 11
                            .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Header.VisiblePosition = 12

                            .DisplayLayout.Bands(0).Columns("Viaje").Width = 90
                            .DisplayLayout.Bands(0).Columns("Fecha").Width = 60
                            .DisplayLayout.Bands(0).Columns("Trabajador").Width = 180
                            .DisplayLayout.Bands(0).Columns("Origen").Width = 80
                            .DisplayLayout.Bands(0).Columns("Destino").Width = 80
                            .DisplayLayout.Bands(0).Columns("Cliente").Width = 150
                            .DisplayLayout.Bands(0).Columns("Carga").Width = 60
                            .DisplayLayout.Bands(0).Columns("Flete").Width = 60
                            .DisplayLayout.Bands(0).Columns("Cargado").Width = 60
                            .DisplayLayout.Bands(0).Columns("Depositado").Width = 70
                            .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Width = 60
                            .DisplayLayout.Bands(0).Columns("Glosa").Width = 325

                            .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Header.Caption = "Saldo"

                            .DisplayLayout.Bands(0).Columns("Flete").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("Cargado").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("Depositado").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right

                            .DisplayLayout.Bands(0).Columns("Glosa").CellAppearance.BackColor = Color.Red
                            .DisplayLayout.Bands(0).Columns("Glosa").CellAppearance.ForeColor = Color.White

                            .DisplayLayout.Bands(0).Columns("Flete").Style = ColumnStyle.Double
                            .DisplayLayout.Bands(0).Columns("Cargado").Style = ColumnStyle.Double
                            .DisplayLayout.Bands(0).Columns("Depositado").Style = ColumnStyle.Double
                            .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Style = ColumnStyle.Double
                            .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double

                            .DisplayLayout.Bands(0).Columns("Flete").Format = "#,###,###,####0.00"
                            .DisplayLayout.Bands(0).Columns("Cargado").Format = "#,###,###,####0.00"
                            .DisplayLayout.Bands(0).Columns("Depositado").Format = "#,###,###,####0.00"
                            .DisplayLayout.Bands(0).Columns("Flete").Format = "#,###,###,####0.00"
                            .DisplayLayout.Bands(0).Columns("Importe").Format = "#,###,###,####0.00"

                            CalcularTotales(griDetalle, "Cargado")
                        End With
                    Case "c"
                        With griDetalle
                            .ResetDisplayLayout()
                            .DataSource = oeReporteFondoFijo.loPrestamosCuenta
                            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdConceptoIngresos").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IndIngEgr").Hidden = True
                            .DisplayLayout.Bands(0).Columns("UsuarioAutoriza").Hidden = True
                            .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Importe").Hidden = True

                            .DisplayLayout.Bands(0).Columns("Concepto").Header.VisiblePosition = 1
                            .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 2
                            .DisplayLayout.Bands(0).Columns("Ingreso").Header.VisiblePosition = 3
                            .DisplayLayout.Bands(0).Columns("Egreso").Header.VisiblePosition = 4
                            .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 5
                            .DisplayLayout.Bands(0).Columns("Voucher").Header.VisiblePosition = 6

                            .DisplayLayout.Bands(0).Columns("Concepto").Width = 300
                            .DisplayLayout.Bands(0).Columns("Fecha").Width = 70
                            .DisplayLayout.Bands(0).Columns("Ingreso").Width = 80
                            .DisplayLayout.Bands(0).Columns("Egreso").Width = 80
                            .DisplayLayout.Bands(0).Columns("Autoriza").Width = 220
                            .DisplayLayout.Bands(0).Columns("Glosa").Width = 300
                            .DisplayLayout.Bands(0).Columns("Voucher").Width = 80

                            .DisplayLayout.Bands(0).Columns("Ingreso").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("Egreso").CellAppearance.TextHAlign = HAlign.Right

                            .DisplayLayout.Bands(0).Columns("Ingreso").Style = ColumnStyle.Double
                            .DisplayLayout.Bands(0).Columns("Egreso").Style = ColumnStyle.Double
                        End With
                    Case "d"
                        With griDetalle
                            .ResetDisplayLayout()
                            Dim loHabsinCeros As New List(Of e_Movimiento_Viaje)
                            loHabsinCeros = oeReporteFondoFijo.loHabilitacion.Where(Function(item) item.SaldoTotal > 0).ToList
                            .DataSource = loHabsinCeros
                            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdMovimiento").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Carga").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FecSalOrigen").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FecLleDestino").Hidden = True
                            .DisplayLayout.Bands(0).Columns("TipoTransa").Hidden = True
                            .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Usuario").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTipoVehiculo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("TipoVehiculo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Voucher").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Carreta").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Tracto").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Copiloto").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdPiloto").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTrabajadorRecepciona").Hidden = True
                            .DisplayLayout.Bands(0).Columns("RecibeBolsa").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaRecepcion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("EgresoTotal").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IngresoTotal").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                            .DisplayLayout.Bands(0).Columns("TipoTRB").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Empresa").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Hidden = True
                            .DisplayLayout.Bands(0).Columns("TipoDocumento").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTracto").Hidden = True
                            .DisplayLayout.Bands(0).Columns("GastosRendidos").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaLiquidacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaReembolso").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Egreso").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdOperacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Operacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Descuento").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Ingreso").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 1
                            .DisplayLayout.Bands(0).Columns("Piloto").Header.VisiblePosition = 2
                            .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 3
                            .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 4
                            .DisplayLayout.Bands(0).Columns("Ruta").Header.VisiblePosition = 5
                            .DisplayLayout.Bands(0).Columns("SaldoTotal").Header.VisiblePosition = 6

                            .DisplayLayout.Bands(0).Columns("Viaje").Width = 100
                            .DisplayLayout.Bands(0).Columns("Piloto").Width = 250
                            .DisplayLayout.Bands(0).Columns("Estado").Width = 100
                            .DisplayLayout.Bands(0).Columns("Fecha").Width = 70
                            .DisplayLayout.Bands(0).Columns("Ruta").Width = 250
                            .DisplayLayout.Bands(0).Columns("SaldoTotal").Width = 80

                            .DisplayLayout.Bands(0).Columns("SaldoTotal").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("DiasAtrasados").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("SaldoTotal").Style = ColumnStyle.Double
                        End With
                        CalcularTotales(griDetalle, "SaldoTotal")
                    Case "e"
                        griDetalle.ResetDisplayLayout()
                        griDetalle.DataSource = oeReporteFondoFijo.loLiquidacion
                        With griDetalle.DisplayLayout.Bands(0)
                            .Columns("IdCuentaCorriente").Hidden = True : .Columns("TipoMovimiento").Hidden = True
                            .Columns("TipoDocumento").Hidden = True : .Columns("IdFlujoCaja").Hidden = True
                            .Columns("Flujocaja").Hidden = True : .Columns("IdDocumento").Hidden = True
                            .Columns("IdPeriodo").Hidden = True : .Columns("Periodo").Hidden = True
                            .Columns("SerieDoc").Hidden = True : .Columns("NroDoc").Hidden = True
                            .Columns("IdTipoDocumento").Hidden = True : .Columns("IdProveedor").Hidden = True
                            .Columns("Proveedor").Hidden = True : .Columns("Glosa").Hidden = True
                            .Columns("TipoCambio").Hidden = True : .Columns("IdMoneda").Hidden = True
                            .Columns("Moneda").Hidden = True : .Columns("SubTotal").Hidden = True
                            .Columns("IGV").Hidden = True : .Columns("IdEstado").Hidden = True
                            .Columns("FechaCreacion").Hidden = True : .Columns("UsuarioCReacion").Hidden = True
                            .Columns("Activo").Hidden = True : .Columns("FechaVencimiento").Hidden = True
                            .Columns("IdEstado").Hidden = True : .Columns("IdOrigen").Hidden = True
                            .Columns("Origen").Hidden = True : .Columns("IdDestino").Hidden = True
                            .Columns("Destino").Hidden = True : .Columns("Id").Hidden = True
                            .Columns("IdViaje").Hidden = True : .Columns("IdGrupo").Hidden = True
                            .Columns("IdCopiloto").Hidden = True : .Columns("IdTipoVehiculo").Hidden = True
                            .Columns("IdPiloto").Hidden = True : .Columns("NroGrupo").Hidden = True
                            .Columns("Copiloto").Hidden = True : .Columns("Vehiculo").Hidden = True
                            .Columns("IndAlmacen").Hidden = True : .Columns("Estado").Hidden = True
                            .Columns("IdTrabajadorAutoriza").Hidden = True : .Columns("TrabajadorAutoriza").Hidden = True
                            .Columns("FechaEmision").Header.Caption = "FechaViaje"

                            .Columns("Viaje").Header.VisiblePosition = 1 : .Columns("Piloto").Header.VisiblePosition = 2
                            .Columns("Estado").Header.VisiblePosition = 3 : .Columns("FechaEmision").Header.VisiblePosition = 4
                            .Columns("Ruta").Header.VisiblePosition = 5 : .Columns("Total").Header.VisiblePosition = 6

                            .Columns("Total").Style = ColumnStyle.Double

                            .Columns("Viaje").Width = 100 : .Columns("Piloto").Width = 250
                            .Columns("Estado").Width = 100 : .Columns("FechaEmision").Width = 70
                            .Columns("Ruta").Width = 250 : .Columns("Total").Width = 80

                            .Columns("Total").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                        End With
                        CalcularTotales(griDetalle, "Total")
                    Case "f"
                        With griDetalle
                            .ResetDisplayLayout()
                            .DataSource = oeReporteFondoFijo.loGrupoLiquidacion
                            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Tipo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Fecha").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaReembolso").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Centro").Hidden = True
                            .DisplayLayout.Bands(0).Columns("ImportePagar").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCuentaCorriente").Hidden = True
                            .DisplayLayout.Bands(0).Columns("NroCheque").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdPeriodo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Periodo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCaja").Hidden = True

                            .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                            .DisplayLayout.Bands(0).Columns("GlosaEnvio").Header.VisiblePosition = 2
                            .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 3
                            .DisplayLayout.Bands(0).Columns("FechaEnvio").Header.VisiblePosition = 4

                            .DisplayLayout.Bands(0).Columns("Codigo").Width = 95
                            .DisplayLayout.Bands(0).Columns("GlosaEnvio").Width = 450
                            .DisplayLayout.Bands(0).Columns("Estado").Width = 100
                            .DisplayLayout.Bands(0).Columns("FechaEnvio").Width = 80
                            '.DisplayLayout.Bands(0).Columns("ImporteToTal").Width = 80
                            .DisplayLayout.Bands(0).Columns("ImporteTotal").Width = 80
                            .DisplayLayout.Bands(0).Columns("ImporteTotal").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("ImporteTotal").Style = ColumnStyle.Double

                            .DisplayLayout.Bands(0).Columns("ImporteTotal").Format = "#,###,###,####0.00"

                            CalcularTotales(griDetalle, "ImporteTotal")
                        End With
                    Case "g"
                        With griDetalle
                            .ResetDisplayLayout()
                            .DataSource = oeReporteFondoFijo.loDescuento
                            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdMovimiento").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Carga").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FecSalOrigen").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FecLleDestino").Hidden = True
                            .DisplayLayout.Bands(0).Columns("TipoTransa").Hidden = True
                            .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Usuario").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTipoVehiculo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("TipoVehiculo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Voucher").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Carreta").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Tracto").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdPiloto").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTrabajadorRecepciona").Hidden = True
                            .DisplayLayout.Bands(0).Columns("RecibeBolsa").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaRecepcion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("SaldoTotal").Hidden = True
                            .DisplayLayout.Bands(0).Columns("EgresoTotal").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IngresoTotal").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Piloto").Hidden = True
                            .DisplayLayout.Bands(0).Columns("TipoTRB").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Empresa").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Estado").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Hidden = True
                            .DisplayLayout.Bands(0).Columns("TipoDocumento").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTracto").Hidden = True
                            .DisplayLayout.Bands(0).Columns("GastosRendidos").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaLiquidacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaReembolso").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdOperacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Operacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Descuento").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Egreso").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Copiloto").Hidden = True
                            .DisplayLayout.Bands(0).Columns("DiasAtrasados").Hidden = True

                            .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 1
                            .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 2
                            .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 3
                            .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 4
                            .DisplayLayout.Bands(0).Columns("Ruta").Header.VisiblePosition = 5
                            .DisplayLayout.Bands(0).Columns("Ingreso").Header.VisiblePosition = 6
                            .DisplayLayout.Bands(0).Columns("Egreso").Header.VisiblePosition = 7
                            .DisplayLayout.Bands(0).Columns("Viaje").Width = 100
                            .DisplayLayout.Bands(0).Columns("Glosa").Width = 400
                            .DisplayLayout.Bands(0).Columns("Estado").Width = 100
                            .DisplayLayout.Bands(0).Columns("Fecha").Width = 70
                            .DisplayLayout.Bands(0).Columns("Ruta").Width = 250
                            .DisplayLayout.Bands(0).Columns("Ingreso").Width = 80
                            .DisplayLayout.Bands(0).Columns("Egreso").Width = 80
                            .DisplayLayout.Bands(0).Columns("Ingreso").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("Egreso").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("Ingreso").Style = ColumnStyle.Double
                            .DisplayLayout.Bands(0).Columns("Egreso").Style = ColumnStyle.Double

                        End With
                        CalcularTotales(griDetalle, "Ingreso", "Egreso")
                    Case "h"
                        griDetalle.ResetDisplayLayout()
                        griDetalle.DataSource = oeReporteFondoFijo.loGastoCajaChica
                        With griDetalle.DisplayLayout
                            .Bands(0).Columns("TipoMovimiento").Hidden = True
                            .Bands(0).Columns("Descuento").Hidden = True
                            .Bands(0).Columns("FechaCreacion").Hidden = True
                            .Bands(0).Columns("CuentaDestino").Hidden = True
                            .Bands(0).Columns("IdCuentaCorrienteD").Hidden = True
                            .Bands(0).Columns("CuentaOrigen").Hidden = True
                            .Bands(0).Columns("IdCuentaCorrienteO").Hidden = True
                            .Bands(0).Columns("CuentaDestino").Hidden = True
                            .Bands(0).Columns("IdTrabajadorCuentaCorriente").Hidden = True
                            .Bands(0).Columns("Trabajador").Hidden = True
                            .Bands(0).Columns("Id").Hidden = True
                            .Bands(0).Columns("TipoTRansa").Hidden = True
                            .Bands(0).Columns("UsuarioCreacion").Hidden = True
                            .Bands(0).Columns("Saldo").Hidden = True
                            .Bands(0).Columns("IdEstado").Hidden = True
                            .Bands(0).Columns("Ingreso").Hidden = True
                            .Bands(0).Columns("SaldoTotal").Hidden = True
                            .Bands(0).Columns("EgresoTotal").Hidden = True
                            .Bands(0).Columns("IngresoTotal").Hidden = True
                            .Bands(0).Columns("Activo").Hidden = True
                            .Bands(0).Columns("GastosRendidos").Hidden = True
                            .Bands(0).Columns("IndCerrado").Hidden = True

                            .Bands(0).Columns("Fecha").Header.VisiblePosition = 1
                            .Bands(0).Columns("Voucher").Header.VisiblePosition = 2
                            .Bands(0).Columns("Glosa").Header.VisiblePosition = 3
                            .Bands(0).Columns("Egreso").Header.VisiblePosition = 4

                            .Bands(0).Columns("Fecha").Width = 55
                            .Bands(0).Columns("Voucher").Width = 110
                            .Bands(0).Columns("Glosa").Width = 550
                            .Bands(0).Columns("Egreso").Width = 80

                            .Bands(0).Columns("Fecha").Style = ColumnStyle.DateTime
                            .Bands(0).Columns("Egreso").Style = ColumnStyle.Double

                            .Bands(0).Columns("Egreso").CellAppearance.TextHAlign = HAlign.Right

                            CalcularTotales(griDetalle, "Egreso")
                        End With
                    Case "i"
                        griDetalle.ResetDisplayLayout()
                        griDetalle.DataSource = Nothing
                    Case "j"
                        griDetalle.ResetDisplayLayout()
                        griDetalle.DataSource = Nothing
                    Case "k"
                        With griDetalle
                            .ResetDisplayLayout()
                            .DataSource = oeReporteFondoFijo.loGrupoFlete
                            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Tipo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Fecha").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaReembolso").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Centro").Hidden = True
                            .DisplayLayout.Bands(0).Columns("ImportePagar").Hidden = True
                            .DisplayLayout.Bands(0).Columns("ImporteToTal").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCuentaCorriente").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdPeriodo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Periodo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCaja").Hidden = True
                            .DisplayLayout.Bands(0).Columns("NroCheque").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True

                            .DisplayLayout.Bands(0).Columns("FechaEnvio").Header.Caption = "Fecha"

                            .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                            .DisplayLayout.Bands(0).Columns("GlosaEnvio").Header.VisiblePosition = 2
                            .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 3
                            .DisplayLayout.Bands(0).Columns("FechaEnvio").Header.VisiblePosition = 4
                            .DisplayLayout.Bands(0).Columns("ImporteToTal").Header.VisiblePosition = 5

                            .DisplayLayout.Bands(0).Columns("Codigo").Width = 90
                            .DisplayLayout.Bands(0).Columns("GlosaEnvio").Width = 450
                            .DisplayLayout.Bands(0).Columns("Estado").Width = 100
                            .DisplayLayout.Bands(0).Columns("FechaEnvio").Width = 80
                            .DisplayLayout.Bands(0).Columns("Saldo").Width = 80

                            .DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("Saldo").Style = ColumnStyle.Double

                            .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                            .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                            .DisplayLayout.Override.FilterUIProvider = Filtro1
                            .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.RowIndex
                            .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False

                            CalcularTotales(griDetalle, "Saldo")
                        End With
                    Case "l"
                        griDetalle.ResetDisplayLayout()
                        griDetalle.DataSource = Nothing
                    Case "m"
                        With griDetalle
                            .ResetDisplayLayout()
                            .DataSource = oeReporteFondoFijo.loValesRendir

                            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Ingreso").Hidden = True
                            .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTrabajadorAutoriza").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Egreso").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdVale").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Referencia").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IndRendido").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True

                            .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 2
                            .DisplayLayout.Bands(0).Columns("NroVale").Header.VisiblePosition = 3
                            .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 4
                            .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 5
                            .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 1

                            .DisplayLayout.Bands(0).Columns("Trabajador").Width = 200
                            .DisplayLayout.Bands(0).Columns("Autoriza").Width = 200
                            .DisplayLayout.Bands(0).Columns("Glosa").Width = 400

                            .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double

                            CalcularTotales(griDetalle, "Importe")
                        End With
                    Case "n"
                        With griDetalle
                            .ResetDisplayLayout()
                            .DataSource = oeReporteFondoFijo.loOtrosIngresos
                            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdConceptoIngresos").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCuentaCorriente").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCuentaBancaria").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Importe").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IndIngresoEgreso").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IndCerrado").Hidden = True
                            .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Centro").Hidden = True
                            .DisplayLayout.Bands(0).Columns("FechaCierre").Hidden = True
                            .DisplayLayout.Bands(0).Columns("TipoReferencia").Hidden = True
                            .DisplayLayout.Bands(0).Columns("IdReferencia").Hidden = True
                            .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True

                            .DisplayLayout.Bands(0).Columns("Voucher").Header.VisiblePosition = 1
                            .DisplayLayout.Bands(0).Columns("Concepto").Header.VisiblePosition = 2
                            .DisplayLayout.Bands(0).Columns("Ingreso").Header.VisiblePosition = 3
                            .DisplayLayout.Bands(0).Columns("Egreso").Header.VisiblePosition = 4
                            .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 5

                            .DisplayLayout.Bands(0).Columns("Voucher").Width = 80
                            .DisplayLayout.Bands(0).Columns("Concepto").Width = 200
                            .DisplayLayout.Bands(0).Columns("Ingreso").Width = 60
                            .DisplayLayout.Bands(0).Columns("Egreso").Width = 60
                            .DisplayLayout.Bands(0).Columns("Glosa").Width = 200
                            .DisplayLayout.Bands(0).Columns("CuentaBancaria").Width = 180

                            .DisplayLayout.Bands(0).Columns("Ingreso").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("Ingreso").Style = ColumnStyle.Double
                            .DisplayLayout.Bands(0).Columns("Egreso").CellAppearance.TextHAlign = HAlign.Right
                            .DisplayLayout.Bands(0).Columns("Egreso").Style = ColumnStyle.Double

                            CalcularTotales(griDetalle, "Ingreso", "Egreso")
                        End With
                End Select

                With griDetalle
                    .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.RowIndex
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.HeaderClickAction = HeaderClickAction.SortMulti
                End With
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub tsmiCajaDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiCajaDiario.Click
        Dim frm As New frm_ReporteCajaDiario
        frm = frm.getInstancia()
        frm.MdiParent = frm_Menu
        frm.getInstancia()
        frm.Show()
    End Sub

    Private Sub frm_ReporteFondoFijo_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

End Class