'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Microsoft.Reporting.WinForms

Public Class frm_ReporteSaldoTrabajador
    Inherits frm_MenuPadre

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteSaldoTrabajador = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteSaldoTrabajador()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ProcesarReporte()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteSaldoTrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gf_AsignarEventoSeleccionarTexto(Me)
        LlenaComboTrabajador()
        ReportViewer1.ShowParameterPrompts = False
        ReportViewer1.ShowPromptAreaButton = False
    End Sub

    Private Sub frm_ReportePrestamoTrabajador_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

#End Region

#Region "Metodos"


    Private Sub LlenaComboTrabajador()
        LlenarCombo(cboTrabajador, "Nombre", TrabajadorPublic, -1)
    End Sub

    Public Sub ProcesarReporte()
        Try
            If cboTrabajador.SelectedIndex <> -1 Then
                Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
                Dim olConfiguracion As New l_Configuracion
                ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://" & olConfiguracion.IPServidorReportes & "/ReportServer_SRVSQLISLPYO")
                ReportViewer1.ServerReport.ReportPath = "/Reportes/PER - Saldo Descuento Trabajador"
                Dim myParams(0) As Microsoft.Reporting.WinForms.ReportParameter
                myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Trabajador", cboTrabajador.Value.ToString)
                ReportViewer1.ServerReport.SetParameters(myParams)
                ReportViewer1.RefreshReport()
            End If          
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class