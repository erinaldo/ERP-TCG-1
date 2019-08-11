Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_ReporteCajaDiario
    Implements Il_ReporteCajaDiario
    Dim odReporteCajaDiario As New d_ReporteCajaDiario

    Public Function Listar(ByVal oeReporteCajaDiario As EntidadesWCF.e_ReporteCajaDiario) As System.Collections.Generic.List(Of EntidadesWCF.e_ReporteCajaDiario) Implements Il_ReporteCajaDiario.Listar
        Try
            Return odReporteCajaDiario.Listar(oeReporteCajaDiario)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
