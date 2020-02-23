﻿'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports Microsoft.Reporting.WinForms

Public Class frm_ImprimeTransferencia
    Private Id As String


    Sub New(ByVal ls_id As String)
        InitializeComponent()
        Id = ls_id
    End Sub

    Private Sub frm_ImprimeTranferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            Dim olAsiento As New l_Asiento
            dt = olAsiento.ImprimeTranferencia(Id)
            '@0001 Ini
            Dim dc As DataColumn
            dc = New DataColumn("CantidadLetras", Type.GetType("System.String"))
            dt.Columns.Add(dc)
            dt.Rows(0).Item("CantidadLetras") = Conversiones.NumerosALetras.Ejecutar(Math.Round(dt.Rows(0).Item("Importe"), 2), True)
            '@0001 Fin
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Dim oReport As New ReportDataSource("dsTransferenciaBancaria_Transferencia", dt)

            'Dim myParams(0) As Microsoft.Reporting.WinForms.ReportParameter
            'myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("CantidadLetras", _
            'Conversiones.NumerosALetras.Ejecutar(dt.Rows(0).Item("Importe"), True))

            ReportViewer1.LocalReport.DataSources.Clear()
            'ReportViewer1.LocalReport.SetParameters(myParams)
            ReportViewer1.LocalReport.DataSources.Add(oReport)

            ReportViewer1.LocalReport.Refresh()
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
        End Try
    End Sub
End Class