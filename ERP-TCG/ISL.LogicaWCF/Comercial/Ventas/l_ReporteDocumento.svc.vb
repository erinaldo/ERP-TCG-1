Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

Public Class l_ReporteDocumento
    Implements Il_ReporteDocumento

    Dim odReporteDoc As New d_ReporteDocumento

    Public Function Listar(ByVal oeReportDoc As EntidadesWCF.e_ReporteDocumento) As System.Collections.Generic.List(Of EntidadesWCF.e_ReporteDocumento) Implements Il_ReporteDocumento.Listar
        Try
            Return odReporteDoc.Listar(oeReportDoc)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarRCM(ByVal oeReportCM As EntidadesWCF.e_ReporteClienteMensual) As System.Collections.Generic.List(Of EntidadesWCF.e_ReporteClienteMensual) Implements Il_ReporteDocumento.ListarRCM
        Try
            Return odReporteDoc.ListarRCM(oeReportCM)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
