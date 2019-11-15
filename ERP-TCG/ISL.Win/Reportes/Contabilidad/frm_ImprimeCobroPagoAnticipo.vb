'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports Microsoft.Reporting.WinForms
Public Class frm_ImprimeCobroPagoAnticipo
    Private Id As String
    Private Ingreso As Integer
    Private msTipoOperacion As String

    Sub New(ByVal ls_id As String, ByVal ls_Ingreso As Integer, ByVal lsTipoOperacion As String)
        InitializeComponent()
        Id = ls_id
        Ingreso = ls_Ingreso
        msTipoOperacion = lsTipoOperacion
    End Sub

    Private Sub frm_ImprimeCobroPagoAnticipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            Dim olAsiento As New l_Asiento
            dt = olAsiento.ImprimeCobroPagoAnticipoObligacion(Id, msTipoOperacion)
            If dt.Rows.Count = 0 And msTipoOperacion <> "Obligacion" Then
                dt = olAsiento.ImprimeCobroPagoAnticipoObligacion(Id, "Obligacion")
            End If
            '@0001 Ini
            Dim dc As DataColumn
            dc = New DataColumn("EmpresaSis", Type.GetType("System.String"))
            dt.Columns.Add(dc)
            dc = New DataColumn("CantidadLetras", Type.GetType("System.String"))
            dt.Columns.Add(dc)
            dc = New DataColumn("IndIngreso", Type.GetType("System.String"))
            dt.Columns.Add(dc)
            dt.Rows(0).Item("EmpresaSis") = gs_TxtEmpresaSistema.Trim
            dt.Rows(0).Item("CantidadLetras") = Conversiones.NumerosALetras.Ejecutar(Math.Round(dt.Rows(0).Item("Importe"), 2), True)
            dt.Rows(0).Item("IndIngreso") = Ingreso
            '@0001 Fin
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

            Dim oReport As New ReportDataSource("dsAnticipoCobroPago_CobroPagoAnticipo", dt)
            '@0001 Ini
            'Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
            'myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("CantidadLetras", _
            'Conversiones.NumerosALetras.Ejecutar(Math.Round(dt.Rows(0).Item("Importe"), 2), True))
            'myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("IndIngreso", Ingreso, True)
            '@0001 Fin
            ReportViewer1.LocalReport.DataSources.Clear()
            'ReportViewer1.LocalReport.SetParameters(myParams) '@0001
            ReportViewer1.LocalReport.DataSources.Add(oReport)

            ReportViewer1.LocalReport.Refresh()
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
        End Try
    End Sub

End Class