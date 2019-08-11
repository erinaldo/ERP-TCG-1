Public Class frm_ImprimeRegConsumoCombustible

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub frm_ImprimeRegConsumoCombustible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos(DateTime.Parse("01/09/2014"), DateTime.Parse("02/09/2014"))
    End Sub

    Public Sub CargarDatos(ByVal ld_FechaInicio As Date, ByVal ld_FechaFin As Date)
        Try
            Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("FechaInicio", ld_FechaInicio, True)
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("FechaFin", ld_FechaFin, True)
            CargarReporteLocal(Nothing, "Registro de Consumo Combustible", "ds_ValesConsumoCombustible", "Reportes\Contabilidad\rpt_ValesConsumoCombustible.rdlc", myParams)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
End Class
