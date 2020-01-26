Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_GRR_Venta_Print

#Region "Variables"

    Private ms_IdGRR As String
    Private olGrr As l_GRR_Venta
    Private olGrr_Detalle As l_GuiaRemisionRemitente_Detalle
    Private DT1 As DataTable, DT2 As DataTable
    Private RDS1 As New Microsoft.Reporting.WinForms.ReportDataSource, RDS2 As New Microsoft.Reporting.WinForms.ReportDataSource

#End Region

    Sub New(IdGrr As String)
        InitializeComponent()
        ms_IdGRR = IdGrr
    End Sub

    Private Sub frm_GRR_Venta_Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            olGrr = New l_GRR_Venta
            olGrr_Detalle = New l_GuiaRemisionRemitente_Detalle
            lr_CargarDatos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub lr_CargarDatos()
        Try
            'DT1 = New DataTable
            'DT2 = New DataTable
            'olGrr = New l_GRR_Venta
            'olGrr_Detalle = New l_GuiaRemisionRemitente_Detalle
            DT1 = olGrr.ListarDT(New e_GRR_Venta With {.TipoOperacion = "PRI", .Id = ms_IdGRR})
            DT2 = olGrr_Detalle.ListarDT(New e_GuiaRemisionRemitente_Detalle With {.TipoOperacion = "PRI", .IdGRR_Venta = ms_IdGRR})
            BindingSource1.DataSource = DT1
            BindingSource2.DataSource = DT2
            With RDS1
                .Name = "Cabecera"
                .Value = BindingSource1
            End With
            With RDS2
                .Name = "Detalle"
                .Value = BindingSource2
            End With
            With rv_Grr_Venta
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.ReportPath = "Reportes\Comercial\Ventas\rpt_GRR_Print.rdlc"
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(RDS1)
                .LocalReport.DataSources.Add(RDS2)
                .LocalReport.Refresh()
                .RefreshReport()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class