Public Class frm_ReporteIncidenciasMonitoreo
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteIncidenciasMonitoreo = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteIncidenciasMonitoreo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte Incidencias"
            CargarReporteRemoto("/Reportes/", "SPC - ReporteIncidenciasMonitoreo")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ReporteIncidenciasMonitoreo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region
    
    Private Sub frm_ReporteIncidenciasMonitoreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class