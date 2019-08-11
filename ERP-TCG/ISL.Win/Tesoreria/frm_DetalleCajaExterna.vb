Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_DetalleCajaExterna

    Public Sub MostrarDetalle(ByVal Tipo As String, Optional ByVal loOtrIng As List(Of e_OtrosIngresos) = Nothing, _
                              Optional ByVal loGasCaj As List(Of e_GastoOperacion) = Nothing, Optional ByVal loValRen As List(Of e_ValesRendir) = Nothing, _
                              Optional ByVal loDetalleRH As List(Of e_Combo) = Nothing)
        With griDetalle
            .ResetDisplayLayout()
            Select Case Tipo
                Case "0"
                    Me.Text = "Detalle Gastos de Caja"
                    .DataSource = loGasCaj
                    .DisplayLayout.Bands(0).Columns("IdCuentaCorriente").Hidden = True : .DisplayLayout.Bands(0).Columns("TipoMovimiento").Hidden = True
                    .DisplayLayout.Bands(0).Columns("TipoDocumento").Hidden = True : .DisplayLayout.Bands(0).Columns("IdFlujoCaja").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdDocumento").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdPeriodo").Hidden = True : .DisplayLayout.Bands(0).Columns("Periodo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("SerieDoc").Hidden = True : .DisplayLayout.Bands(0).Columns("NroDoc").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Hidden = True : .DisplayLayout.Bands(0).Columns("IdProveedor").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Proveedor").Hidden = True : .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Hidden = True : .DisplayLayout.Bands(0).Columns("IdMoneda").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Moneda").Hidden = True : .DisplayLayout.Bands(0).Columns("SubTotal").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IGV").Hidden = True : .DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True : .DisplayLayout.Bands(0).Columns("UsuarioCReacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True : .DisplayLayout.Bands(0).Columns("FechaVencimiento").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True : .DisplayLayout.Bands(0).Columns("IdOrigen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Origen").Hidden = True : .DisplayLayout.Bands(0).Columns("IdDestino").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Destino").Hidden = True : .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True : .DisplayLayout.Bands(0).Columns("IdGrupo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdCopiloto").Hidden = True : .DisplayLayout.Bands(0).Columns("IdTipoVehiculo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdPiloto").Hidden = True : .DisplayLayout.Bands(0).Columns("IndAlmacen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Ruta").Hidden = True : .DisplayLayout.Bands(0).Columns("Glosa").Hidden = False
                    .DisplayLayout.Bands(0).Columns("Estado").Hidden = True : .DisplayLayout.Bands(0).Columns("Copiloto").Hidden = True
                    .DisplayLayout.Bands(0).Columns("NroGrupo").Hidden = True : .DisplayLayout.Bands(0).Columns("Viaje").Hidden = True
                    .DisplayLayout.Bands(0).Columns("SerieDoc").Hidden = True : .DisplayLayout.Bands(0).Columns("NroDoc").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Hidden = True : .DisplayLayout.Bands(0).Columns("IdProveedor").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Vehiculo").Hidden = True : .DisplayLayout.Bands(0).Columns("Piloto").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdTrabajadorAutoriza").Hidden = True : .DisplayLayout.Bands(0).Columns("TrabajadorAutoriza").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 2 : .DisplayLayout.Bands(0).Columns("IndAlmacen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("FlujoCaja").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Total").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Total").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 450
                    .DisplayLayout.Bands(0).Columns("FlujoCaja").Width = 180
                    FormatoColorGrilla(griDetalle)
                    CalcularTotales(griDetalle, "Total")
                Case "1"
                    Me.Text = "Detalle Vales x Rendir"
                    .DataSource = loValRen
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True : .DisplayLayout.Bands(0).Columns("Ingreso").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True : .DisplayLayout.Bands(0).Columns("IdVale").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Referencia").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Autoriza").Hidden = True : .DisplayLayout.Bands(0).Columns("IdTrabajadorAutoriza").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True : .DisplayLayout.Bands(0).Columns("Egreso").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Ingreso").Hidden = True '.DisplayLayout.Bands(0).Columns("IdProveedor").Hidden = True
                    .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True : .DisplayLayout.Bands(0).Columns("IndRendido").Hidden = True
                    .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True : .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Centro").Hidden = True : .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("NroVale").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 200
                    .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right
                    CalcularTotales(griDetalle, "Importe")
                Case "2"
                    Me.Text = "Detalle Otros Ingresos"
                    Me.Etiqueta1.Text = "Ingreso"
                    Datos.Visible = True
                    Me.Etiqueta2.Visible = True
                    Me.Colores1.Visible = True
                    .DataSource = loOtrIng
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True : .DisplayLayout.Bands(0).Columns("Importe").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True : .DisplayLayout.Bands(0).Columns("IndIngresoEgreso").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdConceptoIngresos").Hidden = True : .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdCuentaCorriente").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdCuentaBancaria").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IndCerrado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("FechaCierre").Hidden = True
                    .DisplayLayout.Bands(0).Columns("TipoReferencia").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdReferencia").Hidden = True
                    .DisplayLayout.Bands(0).Columns("CuentaBancaria").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Concepto").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Voucher").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Ingreso").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Egreso").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 6
                    '.DisplayLayout.Bands(0).Columns("Autoriza").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("CuentaBancaria").Width = 150
                    .DisplayLayout.Bands(0).Columns("Concepto").Width = 150
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 180
                    .DisplayLayout.Bands(0).Columns("Egreso").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Ingreso").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Egreso").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Ingreso").CellAppearance.TextHAlign = HAlign.Right
                    CalcularTotales(griDetalle, "Ingreso", "Egreso")
                    FormatoColorGrillaOtrosIngresos(griDetalle)
                Case 3
                    Me.Text = "Detalle Recibos por Honorarios"
                    .DataSource = loDetalleRH
                    .DisplayLayout.Bands(0).Columns("Id").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Id").Header.Caption = "Viaje / NroOrden"
                    .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "FechaEmision / Numero"
                    .DisplayLayout.Bands(0).Columns("Descripcion").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Descripcion").Header.Caption = "Importe"
                    .DisplayLayout.Bands(0).Columns("Descripcion").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Descripcion").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Id").Width = 150
                    .DisplayLayout.Bands(0).Columns("Nombre").Width = 200
                    .DisplayLayout.Bands(0).Columns("Descripcion").Width = 80
                    CalcularTotales(griDetalle, "Descripcion")
            End Select
            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            .DisplayLayout.Bands(0).Override.SelectTypeGroupByRow = SelectType.None
            .DisplayLayout.Bands(0).Override.SelectTypeRow = SelectType.SingleAutoDrag
            .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
            .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            .DisplayLayout.Override.FilterUIProvider = Filtro1
            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
        End With
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If griDetalle.Rows.Count > 0 Then Exportar_Excel(griDetalle)
    End Sub

    Private Sub FormatoColorGrilla(ByVal grilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grilla.Rows
            Select Case fila.Cells("IdMoneda").Value
                Case "0"
                    fila.CellAppearance.BackColor = Color.White
                Case "1"
                    fila.CellAppearance.BackColor = Me.ColorPreEnviado.Color
            End Select
        Next
    End Sub

    Private Sub FormatoColorGrillaOtrosIngresos(ByVal grilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grilla.Rows
            Select Case fila.Cells("IndIngresoEgreso").Value
                Case "1"
                    fila.CellAppearance.BackColor = Me.ColorPreEnviado.Color
                Case "0"
                    fila.CellAppearance.BackColor = Me.Colores1.Color
            End Select
        Next
    End Sub

End Class