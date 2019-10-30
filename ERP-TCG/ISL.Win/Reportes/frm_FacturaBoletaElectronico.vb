'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Stimulsoft.Report
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_FacturaBoletaElectronico

#Region "Declaracion de Variables"

    Private oeDocumento As e_MovimientoDocumento, olDocumento As l_MovimientoDocumento
    Private srReporte As StiReport
    Private dsDatos As DataSet
    Dim MensajeIsl As New c_Alertas

#End Region

#Region "Eventos"

    Private Sub frm_FacturaBoletaElectronico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "REPRESENTACION IMPRESA - " & gs_TxtEmpresaSistema.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub svcReporteF_Close(sender As Object, e As EventArgs) Handles svcReporteF.Close
        Me.Close()
    End Sub

#End Region

#Region "Metodos"

    Public Sub mt_CargarDatos(ls_IdDocumento As String, lb_NotaCredito As Boolean)
        Try
            Dim tipoDocumento As String = ""
            oeDocumento = New e_MovimientoDocumento
            olDocumento = New l_MovimientoDocumento
            oeDocumento.TipoOperacion = "IEF"
            oeDocumento.Id = ls_IdDocumento
            dsDatos = olDocumento.ListaFacturacionElectronica(oeDocumento)
            If dsDatos.Tables.Count > 0 Then
                dsDatos.Tables(0).TableName = "Cabecera_Pie"
                dsDatos.Tables(1).TableName = "Detalle"

                tipoDocumento = dsDatos.Tables(0).Rows(0)("tipcomp")

            End If
            If tipoDocumento.Trim = "01" Then
                mt_CargarReporte("Doc.ElectronicoISL.mrt")
            ElseIf tipoDocumento.Trim = "03" Then
                mt_CargarReporte("Doc.ElectronicoISL.mrt")
            ElseIf tipoDocumento.Trim = "07" Then
                mt_CargarReporte("Doc.ElectronicoISL_NC.mrt")
            ElseIf tipoDocumento.Trim = "08" Then
                mt_CargarReporte("Doc.ElectronicoISL_NC2.mrt")
            End If
            'mt_CargarReporte(IIf(lb_NotaCredito, "Doc.ElectronicoISL_NC.mrt", "Doc.ElectronicoISL.mrt"))
            svcReporteF.Report.Render()
            svcReporteF.Zoom = 1

            mt_CargarAnexos(ls_IdDocumento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub mt_CargarReporte(ls_NombreReporte As String)
        Try
            Dim ls_Moneda As String = "", ls_MontoLetra As String = ""
            srReporte = New StiReport
            srReporte.Load(ISL_RutaImpresion & ls_NombreReporte)
            svcReporteF.Report = srReporte
            srReporte.RegData(dsDatos)
            srReporte.Dictionary.Synchronize()
            ls_Moneda = dsDatos.Tables("Cabecera_Pie").Rows(0).Item("TXT_CATEGORIA_MONEDA").ToString.Trim
            ls_MontoLetra = ConvertirNumeroALetras(Math.Round(dsDatos.Tables("Cabecera_Pie").Rows(0).Item("CAN_TOTAL"), 2).ToString)
            srReporte.Dictionary.Variables.Add("CAN_LETRAS", (ls_MontoLetra & " " & ls_Moneda).ToUpper)
            srReporte.Dictionary.Variables.Add("HASH", dsDatos.Tables("Cabecera_Pie").Rows(0).Item("CodigoBarra").ToString.Trim)
            srReporte.Compile()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarAnexos(ls_IdDocumento As String)
        Dim oeMovDocumento As New e_MovimientoDocumento
        olDocumento = New l_MovimientoDocumento
        'oeMovDocumento = New e_MovimientoDocumento
        oeMovDocumento.CargarCompleto = True
        oeMovDocumento.Id = ls_IdDocumento
        oeMovDocumento = olDocumento.ObtenerVenta(oeMovDocumento)

        CargarAnexo(oeMovDocumento.NombreProveedor, oeMovDocumento.Serie & "-" & oeMovDocumento.Numero, oeMovDocumento.leDetalleDocOperDet)
    End Sub

    Private Sub CargarAnexo(ByVal Nombre_Prov As String, ByVal NroDoc As String, ByVal leDDOD As List(Of e_DetalleDoc_OperacionDet))
        Try
            griComplemento.Text = Nombre_Prov
            For Each oeDDOD As e_DetalleDoc_OperacionDet In leDDOD
                Dim var() As String
                var = Split(oeDDOD.Glosa, ",")
                oeDDOD.Glosa = ""
                If var.Length = 3 Then
                    oeDDOD.Glosa = "FACT: " & NroDoc & ", " & var(1) & ", " & var(2)
                Else
                    If var.Length = 4 Then
                        oeDDOD.Glosa = var(1) & ", " & var(2) & ", " & var(3)
                    Else
                        oeDDOD.Glosa = var(0)
                    End If
                End If
            Next
            griComplemento.DataSource = leDDOD
            With griComplemento
                OcultarColumna(griComplemento, True, "Id", "IndGravado", "IdOperacionDetalle", "IdOperacion", "IdComisionista", "IdMaterialServicio", "IdUnidadMedida", _
                               "IdMaterial", "IdUnidadCarga", "CantOpe", "IncluyeIgv", "FleteUnitario", "Flete", "PesoToneladas", "Saldo", "ValorUnit2", "Igv", "CantGuia", _
                               "NroViaje", "UnidadMedida", "CantOpe", "CV", "FactorRefUni", "FactorRefTotal", "IdOrigen", "IdDestino")
                ExcluirColumna(griComplemento, "Id", "IndGravado", "IdOperacionDetalle", "IdOperacionDetalle", "IdOperacion", "IdComisionista", "IdMaterialServicio", _
                               "IdUnidadMedida", "IdMaterial", "IdUnidadCarga", "IdOrigen", "IdDestino")
                .DisplayLayout.Bands(0).Columns("FechaViaje").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Tracto").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Carreta").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Origen").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Destino").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("MaterialServicio").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Cantidad").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("Valor").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("SubTotal").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("FechaViaje").Header.Caption = "FECHA"
                .DisplayLayout.Bands(0).Columns("Tracto").Header.Caption = "TRACTO"
                .DisplayLayout.Bands(0).Columns("Carreta").Header.Caption = "CARRETA"
                .DisplayLayout.Bands(0).Columns("Origen").Header.Caption = "ORIGEN"
                .DisplayLayout.Bands(0).Columns("Destino").Header.Caption = "DESTINO"
                .DisplayLayout.Bands(0).Columns("MaterialServicio").Header.Caption = "TIPO"
                .DisplayLayout.Bands(0).Columns("Valor").Header.Caption = "VV"
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.Caption = "P/U"
                .DisplayLayout.Bands(0).Columns("SubTotal").Header.Caption = "TOTAL"
                .DisplayLayout.Bands(0).Columns("Cantidad").Header.Caption = "TN"
                .DisplayLayout.Bands(0).Columns("Glosa").Header.Caption = "LISTA"
                .DisplayLayout.Bands(0).Columns("IdOrigen").Width = 100
                .DisplayLayout.Bands(0).Columns("IdDestino").Width = 100
                .DisplayLayout.Bands(0).Columns("Tracto").Width = 55
                .DisplayLayout.Bands(0).Columns("Carreta").Width = 55
                .DisplayLayout.Bands(0).Columns("Valor").Width = 60
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Width = 60
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 200
                .DisplayLayout.Bands(0).Columns("Cantidad").Width = 70
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal").Width = 70
                .DisplayLayout.Bands(0).Columns("Valor").Width = 70
                .DisplayLayout.Bands(0).Columns("FechaViaje").Style = ColumnStyle.Date
                .DisplayLayout.Bands(0).Columns("Glosa").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("Glosa").CellAppearance.TextTrimming = TextTrimming.EllipsisWord
                .DisplayLayout.Bands(0).Columns("Glosa").CellMultiLine = DefaultableBoolean.True
                FormatoColumna(griComplemento, "#,##0.0000", ColumnStyle.Double, HAlign.Right, "Cantidad", "PrecioUnitario", "Valor", "SubTotal")
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                CalcularTotales(griComplemento, "Cantidad", "Valor", "SubTotal")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub tsmiImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiImprimir.Click
        Try
            Me.VistaPreviaPrint.Document = PrintDocument()
            Me.VistaPreviaPrint.ShowDialog(Me)
            Me.VistaPreviaPrint.Document = Nothing
        Catch ex As Exception
            MensajeIsl.Problema(ex.Message, True)
        End Try
    End Sub

    Public Function PrintDocument() As System.Drawing.Printing.PrintDocument
        PrintDocument = Me.GrillaPrint
    End Function

    Private Sub tsmiExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExportar.Click
        If griComplemento.Rows.Count > 0 Then
            Exportar_Excel(griComplemento)
        Else
            MensajeIsl.Problema("No hay registros para exportar")
        End If
    End Sub

#End Region

End Class