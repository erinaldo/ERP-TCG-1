Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Microsoft.Reporting.WinForms
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ReporteCuadreCaja
    Inherits frm_MenuPadre

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteCuadreCaja = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteCuadreCaja()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarDatos(Id As String)
        Try
            Me.Text = "Reporte de Cuadre de Caja"
            CargarReporteRemoto("/Reportes/", "TES - Reporte Cuadre Caja", Id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarReporteRemoto(ByVal ubicacionReporte As String, ByVal nombreReporte As String, Id As String)
        Try

            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote

            Dim olConfiguracion As New l_Configuracion

            ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://" & olConfiguracion.IPServidorReportes & "/ReportServer_SRVSQLISLPYO")
            'If Not myParams Is Nothing Then
            Dim myParams(0) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Id", Id.ToString)

            'End If
            ReportViewer1.ServerReport.ReportPath = ubicacionReporte + nombreReporte
            ReportViewer1.ServerReport.SetParameters(myParams)
            'ReportViewer1.ProcessingMode = ProcessingMode.Remote;
            'ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            ReportViewer1.ShowParameterPrompts = False
            ReportViewer1.ShowPromptAreaButton = False
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class