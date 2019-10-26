Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_ReporteFondoFijo
    Implements Il_ReporteFondoFijo
    Dim odReporteFondoFijo As New d_ReporteFondoFijo

    Public Function Listar(ByVal oeReporteFondoFijo As e_ReporteFondoFijo) As System.Collections.Generic.List(Of e_ReporteFondoFijo) Implements Il_ReporteFondoFijo.Listar
        Try
            Return odReporteFondoFijo.Listar(oeReporteFondoFijo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarFondo(ByVal oeReporteFondoFijo As e_ReporteFondoFijo) As e_ReporteFondoFijo Implements Il_ReporteFondoFijo.ListarFondo
        Try
            Return odReporteFondoFijo.ListarFondo(oeReporteFondoFijo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeReporteFondoFijo As e_ReporteFondoFijo) As e_ReporteFondoFijo Implements Il_ReporteFondoFijo.Obtener
        Try
            Return odReporteFondoFijo.Obtener(oeReporteFondoFijo)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
