Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_ReporteFlete
    Implements Il_ReporteFlete
    Dim odReporteFlete As New d_ReporteFlete

    Public Function Listar(ByVal oeReporteFlete As e_ReporteFlete) As System.Collections.Generic.List(Of e_ReporteFlete) Implements Il_ReporteFlete.Listar
        Try
            Return odReporteFlete.Listar(oeReporteFlete)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeReporteFlete As e_ReporteFlete) As e_ReporteFlete Implements Il_ReporteFlete.Obtener
        Try
            Return odReporteFlete.Obtener(oeReporteFlete)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
