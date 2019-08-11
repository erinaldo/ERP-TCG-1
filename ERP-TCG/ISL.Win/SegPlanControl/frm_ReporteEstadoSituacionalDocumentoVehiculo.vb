Public Class frm_ReporteEstadoSituacionalDocumentoVehiculo
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteEstadoSituacionalDocumentoVehiculo = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteEstadoSituacionalDocumentoVehiculo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Cerrar el formulario"

    Private Sub frm_ReporteEstadoSituacionalDocumentoVehiculo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

    Private Sub frm_ReporteEstadoSituacionalDocumentoVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte Estado Situacional Documento Vehiculo"
            CargarReporteRemoto("/Reportes/", "SPC - ReporteEstadoSituacionalDocumentoVehiculo")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
End Class