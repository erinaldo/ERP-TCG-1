Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_Reporte_RIC
    Dim wr_Reporte As New l_Reporte, Reporte As New e_ReporteFiltro
    Dim DT As New DataTable

    Private Sub frm_Reporte_RIC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar_RIC.Click
        Try
            DT = wr_Reporte.Consultar(Reporte)
            udg_CuadroRIC.DataSource = DT
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class