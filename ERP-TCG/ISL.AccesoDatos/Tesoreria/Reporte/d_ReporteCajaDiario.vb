'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_ReporteCajaDiario

    Private sqlhelper As New SqlHelper
    Private oeReporteCajaDiario As New e_ReporteCajaDiario

    Private Function Cargar(ByVal o_fila As DataRow) As e_ReporteCajaDiario
        Try
            Dim oeReporteCajaDiario = New e_ReporteCajaDiario( _
             o_fila("ID").ToString, _
             o_fila("Piloto").ToString, _
             o_fila("FechaCreacion"), _
             o_fila("Voucher"), _
             o_fila("FechaCreacion"), _
             o_fila("Glosa"), _
             o_fila("Ingreso"), _
             o_fila("Egreso"))
            Return oeReporteCajaDiario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeReporteCajaDiario As e_ReporteCajaDiario) As List(Of e_ReporteCajaDiario)
        Try
            Dim ldReporteCajaDiario As New List(Of e_ReporteCajaDiario)
            Dim ds As DataSet
            With oeReporteCajaDiario
                ds = sqlhelper.ExecuteDataset("TES.Isp_ReporteCajaDiario_Listar", .FechaInicio, .FechaFin, .IdCaja)
            End With
            oeReporteCajaDiario = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    ldReporteCajaDiario.Add(Cargar(o_Fila))
                Next
                Return ldReporteCajaDiario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
