'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports Microsoft.Reporting.WinForms
Public Class frm_DocumentoRentencion
    Inherits ISL.Win.frm_MenuPadre
    Private Id As String


    Sub New(ByVal ls_id As String)
        InitializeComponent()
        Id = ls_id
    End Sub

    Private Sub frm_ImprimeCobroPagoAnticipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            Dim olDocumentoRetencio As New l_DocumentoRetencion
            dt = olDocumentoRetencio.ImprimirDocumentoRetencion(Id)
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Dim Monto As Double = 0
            For Each obj As DataRow In dt.Rows
                Monto = Monto + obj.Item("Retencion")
            Next

            Dim oReport As New ReportDataSource("dsImprimirRetencion_dtImprimirRetencion", dt)

            Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("CantidadLetras",
            UCase(ConvertirNumeroALetras(Math.Round(Monto, 2).ToString)) & " NUEVOS SOLES")
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Destino", "PROVEEDOR", True)

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(myParams)
            ReportViewer1.LocalReport.DataSources.Add(oReport)
            ReportViewer1.LocalReport.Refresh()
            ReportViewer1.RefreshReport()

            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Destino", "SUNAT", True)
            ReportViewer2.LocalReport.DataSources.Clear()
            ReportViewer2.LocalReport.SetParameters(myParams)
            ReportViewer2.LocalReport.DataSources.Add(oReport)
            ReportViewer2.LocalReport.Refresh()
            ReportViewer2.RefreshReport()

            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Destino", "EMISOR- AGENTE DE RETENCION", True)
            ReportViewer3.LocalReport.DataSources.Clear()
            ReportViewer3.LocalReport.SetParameters(myParams)
            ReportViewer3.LocalReport.DataSources.Add(oReport)
            ReportViewer3.LocalReport.Refresh()
            ReportViewer3.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
        End Try
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer3.RefreshReport()
    End Sub


End Class
