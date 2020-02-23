'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2020-02-23  |  CESS     |   Generar Interfaces para Reportes
'=================================================================================================================
Imports ERP.EntidadesWCF

Public Class d_Reporte
    Private SQL As New SqlHelper

    Public Function Consultar(ByVal Item As e_ReporteFiltro) As DataTable
        Try
            Dim DT As New DataTable, DS As New DataSet
            With Item
                DS = SQL.ExecuteDataset(.ProcedimientoAlmacenado _
                        , .TipoConsulta _
                        , .IdEmpresa _
                        , .IdSucursal _
                        , .Id _
                        , .FechaInicial _
                        , .FechaFinal _
                        , .Filtro1 _
                        , .Filtro2 _
                        , .Filtro3 _
                        , .Filtro4 _
                        , .Filtro5
                        )
                If DS.Tables(0).Rows.Count > 0 Then
                    DT = DS.Tables(0)
                End If
            End With
            Return DT
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
