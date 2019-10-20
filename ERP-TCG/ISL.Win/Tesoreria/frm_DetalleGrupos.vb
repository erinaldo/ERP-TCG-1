'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_DetalleGrupos

    Public Sub MostrarDetalle(ByVal Lista As List(Of e_GrupoDetalle), ByVal Tipo As Integer, ByVal Codigo As String)
        With Grilla2
            .ResetDisplayLayout()
            .DataSource = Lista
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdGrupo").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdGastoOperacion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCopiloto").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdOrigen").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdDestino").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdVehiculo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Carga").Hidden = True
            .DisplayLayout.Bands(0).Columns("Cliente").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCliente").Hidden = True
            .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("Trabajador").Width = 180
            .DisplayLayout.Bands(0).Columns("Importe").Width = 60

            Select Case Tipo
                Case 1
                    .DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Usuario").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IndFlete").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Flete").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Depositado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Cargado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Hidden = True
                    .DisplayLayout.Bands(0).Columns("NroGrupo").Hidden = True

                    .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Ruta").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Vehiculo").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("Copiloto").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 8
                    '.DisplayLayout.Bands(0).Columns("NroGrupo").Header.VisiblePosition = 9

                    .DisplayLayout.Bands(0).Columns("Estado").Width = 80
                    .DisplayLayout.Bands(0).Columns("Copiloto").Width = 200
                    .DisplayLayout.Bands(0).Columns("Trabajador").Width = 200
                    .DisplayLayout.Bands(0).Columns("Ruta").Width = 150
                    '.DisplayLayout.Bands(0).Columns("NroGrupo").Width = 80
                    .DisplayLayout.Bands(0).Columns("Vehiculo").Width = 80
                    .DisplayLayout.Bands(0).Columns("Viaje").Width = 110

                    .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right

                    .DisplayLayout.Bands(0).Columns("Trabajador").Header.Caption = "Piloto"
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fecha"

                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    Me.Text = "Detalle de Grupo de Liquidaciones Nro. " & Codigo
                Case 2
                    .DisplayLayout.Bands(0).Columns("Copiloto").Hidden = True
                    .DisplayLayout.Bands(0).Columns("NroGrupo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Vehiculo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Viaje").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Usuario").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Ruta").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IndFlete").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Flete").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Depositado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Cargado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Hidden = True

                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 5

                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fecha"
                    .DisplayLayout.Bands(0).Columns("Estado").Header.Caption = "Serie-Numero"

                    .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 120
                    .DisplayLayout.Bands(0).Columns("Trabajador").Width = 200
                    .DisplayLayout.Bands(0).Columns("Estado").Width = 110
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 500
                    .DisplayLayout.Bands(0).Columns("Importe").Width = 80

                    .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Style = ColumnStyle.DateTime

                    .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right

                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect

                    Me.Text = "Detalle de Grupo de Caja Chica Nro. " & Codigo
                Case 4
                    .DisplayLayout.Bands(0).Columns("Estado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Copiloto").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Ruta").Hidden = True
                    .DisplayLayout.Bands(0).Columns("NroGrupo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Vehiculo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IndFlete").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Flete").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Depositado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Cargado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Hidden = True

                    .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double

                    .DisplayLayout.Bands(0).Columns("Importe").Width = 60
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 400
                    .DisplayLayout.Bands(0).Columns("Usuario").Width = 300
                    .DisplayLayout.Bands(0).Columns("Viaje").Width = 110

                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect

                    Me.Text = "Detalle de Grupo de Descuentos Nro. " & Codigo
            End Select

            .DisplayLayout.Bands(0).Columns("Id").SortIndicator = SortIndicator.Ascending

            .DisplayLayout.Bands(0).Columns("Viaje").MergedCellStyle = MergedCellStyle.Always
            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex

            .DisplayLayout.Bands(0).Override.SelectTypeGroupByRow = SelectType.None
            .DisplayLayout.Bands(0).Override.SelectTypeRow = SelectType.SingleAutoDrag
            .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
            .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
        End With
        CalcularTotales(Grilla2, "Importe")
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("Exportar").Visible = False
        If Grilla2.Rows.Count > 0 Then
            MenuContextual1.Items("Exportar").Visible = True
        End If
    End Sub

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exportar.Click
        Exportar_Excel(Grilla2)
    End Sub

End Class