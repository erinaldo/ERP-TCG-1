'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2020-02-23  |  CESS     |   Generar Interfaces para Reportes
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class l_Reporte
    Implements Il_Reporte

    Public Function Consultar(Reporte As e_ReporteFiltro) As DataTable Implements Il_Reporte.Consultar
        Try
            Dim odReporte As New d_Reporte
            Return odReporte.Consultar(Reporte)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
