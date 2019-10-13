'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Microsoft.Reporting.WinForms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ReporteInformeDetrac

    Dim leDetalleInforme As New List(Of e_InformeDetrac_Det)
    Dim oeDetalleInforme As New e_InformeDetrac_Det
    Dim olDetalleInforme As New l_InformeDetrac_Det

    Private Sub frm_ReporteInformeDetrac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Public Function CrearDTDetalleInforme() As Data.DataTable
        Dim DetalleFac As New Data.DataTable
        With DetalleFac
            .Columns.Add(New Data.DataColumn("NroFactura", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("RazonSocial", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Ruc", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TotalFac", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Detraccion", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("DetraccionRound", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("FechaFac", Type.GetType("System.DateTime")))
        End With
        Return DetalleFac
    End Function

    Public Sub CargarDetalleInforme(ByVal IdInforme As String)

        Try
            oeDetalleInforme = New e_InformeDetrac_Det
            oeDetalleInforme.IdInformeDetrac = IdInforme
            leDetalleInforme = olDetalleInforme.Listar(oeDetalleInforme)
            Dim NroInfor As String = ""
            NroInfor = leDetalleInforme(0).NroInforme

            Dim dtDetalle As DataTable = CrearDTDetalleInforme()
            For Each oeDetalle As e_InformeDetrac_Det In leDetalleInforme

                Dim rwDetalle As Data.DataRow
                rwDetalle = dtDetalle.NewRow

                rwDetalle("NroFactura") = oeDetalle.NroFactura
                rwDetalle("RazonSocial") = oeDetalle.RazonSocial
                rwDetalle("Ruc") = oeDetalle.Ruc
                rwDetalle("TotalFac") = oeDetalle.TotalDoc
                rwDetalle("Detraccion") = oeDetalle.Monto
                rwDetalle("DetraccionRound") = Math.Round(oeDetalle.Monto, 0, MidpointRounding.AwayFromZero)
                rwDetalle("FechaFac") = oeDetalle.FechaDoc
                dtDetalle.Rows.Add(rwDetalle)

            Next


            'Procesa los datos de Informe
            Me.rptDetalleInforme.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Me.rptDetalleInforme.Visible = True
            Dim oReport As New ReportDataSource("dsInformeDetracDet_DetalleInforme", dtDetalle)

            'Parámetros de la cabecera de Informe
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("NroInforme", NroInfor, False))

            'Proceso de generación de la factura
            Me.rptDetalleInforme.LocalReport.DataSources.Clear()
            Me.rptDetalleInforme.LocalReport.DataSources.Add(oReport)

            Me.rptDetalleInforme.LocalReport.SetParameters(parametros)

            Me.rptDetalleInforme.LocalReport.Refresh()
            Me.rptDetalleInforme.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub



End Class