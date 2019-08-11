Imports ISL.EntidadesWCF
Public Class d_ReporteFlete
    Private sqlhelper As New SqlHelper

    Private oeReporteFlete As New e_ReporteFlete

    Private Function Cargar(ByVal o_fila As DataRow) As e_ReporteFlete
        Try
            Dim oeReporteFlete = New e_ReporteFlete( _
             o_fila("Viaje"), _
             o_fila("Piloto"), _
             o_fila("Flete"), _
             o_fila("FechaCarga"), _
             o_fila("Cargado"), _
             o_fila("Depositado"), _
             o_fila("SaldoPOrDepositar"), _
             o_fila("FechaDeposito"), _
             o_fila("DiasFCargaFDeposito"), _
             o_fila("IdComisionista"), _
             o_fila("Comisionista"), _
             o_fila("IdCheque"), _
             o_fila("FechaCargaCheque"), _
             o_fila("NumeroCheque"), _
             o_fila("IdBanco"), _
             o_fila("Banco"), _
             o_fila("FechaCobro"), _
             o_fila("Importe"), _
             o_fila("IdCliente"), _
             o_fila("Cliente"), _
             o_fila("DiasFHoyFCobro"), _
             o_fila("DiasFCargaFCobro"), _
             o_fila("IdProgramador"), _
             o_fila("Programador"), _
             o_fila("NroDeposito"), _
             o_fila("Cobrado"))
            Return oeReporteFlete
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeReporteFlete As e_ReporteFlete) As e_ReporteFlete
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Reporte_Flete", oeReporteFlete.TipoOperacion)
            oeReporteFlete = New e_ReporteFlete
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeReporteFlete = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeReporteFlete
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeReporteFlete As e_ReporteFlete) As List(Of e_ReporteFlete)
        Try
            Dim ldReporteFlete As New List(Of e_ReporteFlete)
            Dim ds As DataSet
            With oeReporteFlete
                ds = sqlhelper.ExecuteDataset("TES.Isp_Reporte_Flete", oeReporteFlete.TipoOperacion)
            End With
            oeReporteFlete = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    ldReporteFlete.Add(Cargar(o_Fila))
                Next
                Return ldReporteFlete
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
