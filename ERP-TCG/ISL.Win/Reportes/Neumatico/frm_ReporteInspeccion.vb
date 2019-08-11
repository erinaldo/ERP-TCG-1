Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Microsoft.Reporting.WinForms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ReporteInspeccion

    Private oeVidaNeu As New e_VidaNeumatico
    Private olVidaNeu As New l_VidaNeumatico

#Region "Eventos"

    Private Sub frm_ReporteInspeccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.ReportViewer1.RefreshReport()
    End Sub

#End Region

#Region "Metodos"

    Private Function CrearDTInspeccion() As Data.DataTable
        Dim Inspeccion As New Data.DataTable
        With Inspeccion
            .Columns.Add(New Data.DataColumn("Neumatico", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Descripcion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Ubi", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Alt", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Psi", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Observaciones", Type.GetType("System.String")))
        End With
        Return Inspeccion
    End Function

    ''' <summary>
    ''' Cargar Inspeccion para Impresion
    ''' </summary>
    ''' <param name="oeVeh">Objeto Vehiculo</param>
    ''' <param name="leOperacionesNeu">Lista de Neumaticos</param>
    ''' <remarks></remarks>
    Public Sub CargarInspeccion(ByVal oeVeh As e_Vehiculo, ByVal leOperacionesNeu As List(Of e_OperacionNeumatico))
        Try
            Dim dtInspeccion As Data.DataTable = CrearDTInspeccion()

            If leOperacionesNeu.Count > 0 Then
                For Each oeOperNeu As e_OperacionNeumatico In leOperacionesNeu
                    Dim rwInspeccion As Data.DataRow
                    rwInspeccion = dtInspeccion.NewRow
                    rwInspeccion("Neumatico") = oeOperNeu.CodigoNeumatico
                    rwInspeccion("Descripcion") = oeOperNeu.Marca & " - " & oeOperNeu.Diseño & " - " & oeOperNeu.Medida
                    If oeOperNeu.Posicion > 0 Then
                        If oeVeh.Motriz = 0 Then
                            rwInspeccion("Ubi") = FormatoDocumento(oeOperNeu.Posicion + 10, 2)
                        Else
                            rwInspeccion("Ubi") = FormatoDocumento(oeOperNeu.Posicion, 2)
                        End If
                    Else
                        Select Case oeOperNeu.Posicion
                            Case -1 : rwInspeccion("Ubi") = "RP1"
                            Case -2 : rwInspeccion("Ubi") = "RP2"
                            Case -3 : rwInspeccion("Ubi") = "RP3"
                        End Select
                    End If
                    

                    rwInspeccion("Alt") = oeOperNeu.Cocada
                    rwInspeccion("Psi") = oeOperNeu.Presion
                    oeVidaNeu = New e_VidaNeumatico
                    oeVidaNeu.TipoOperacion = "U"
                    oeVidaNeu.IdNeumatico = oeOperNeu.IdNeumatico
                    oeVidaNeu.Vigente = 1
                    oeVidaNeu.Activo = True
                    oeVidaNeu = olVidaNeu.Obtener(oeVidaNeu)
                    Select Case oeVidaNeu.NroVida
                        Case 1
                            rwInspeccion("Observaciones") = "NVO"
                        Case 2
                            rwInspeccion("Observaciones") = "R1"
                        Case 3
                            rwInspeccion("Observaciones") = "R2"
                        Case 4
                            rwInspeccion("Observaciones") = "R3"
                        Case 5
                            rwInspeccion("Observaciones") = "R4"
                        Case 6
                            rwInspeccion("Observaciones") = "R5"
                        Case 7
                            rwInspeccion("Observaciones") = "R6"
                    End Select

                    dtInspeccion.Rows.Add(rwInspeccion)
                Next

                If leOperacionesNeu.Count < 10 Then
                    For x As Integer = 1 To 10 - leOperacionesNeu.Count
                        Dim rwInspeccion As Data.DataRow
                        rwInspeccion = dtInspeccion.NewRow
                        rwInspeccion("Neumatico") = ""
                        rwInspeccion("Descripcion") = ""
                        rwInspeccion("Ubi") = ""
                        rwInspeccion("Alt") = ""
                        rwInspeccion("Psi") = ""
                        rwInspeccion("Observaciones") = ""
                        dtInspeccion.Rows.Add(rwInspeccion)
                    Next
                End If
            End If

            Me.rptInspeccion.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Me.rptInspeccion.Visible = True
            Dim oReport As New ReportDataSource("dsInspeccion_NeuInspeccion", dtInspeccion)
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("Fecha", Date.Now, False))
            parametros.Add(New ReportParameter("Cliente", ISL_Nombre, False))
            parametros.Add(New ReportParameter("Placa", oeVeh.Placa, False))
            parametros.Add(New ReportParameter("Descripcion_vehiculo", oeVeh.Marca & " - " & oeVeh.Modelo, False))
            Me.rptInspeccion.LocalReport.DataSources.Clear()
            Me.rptInspeccion.LocalReport.DataSources.Add(oReport)
            Me.rptInspeccion.LocalReport.SetParameters(parametros)
            'Dim printdiag As New PrintDialog
            Me.rptInspeccion.LocalReport.Refresh()
            Me.rptInspeccion.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class