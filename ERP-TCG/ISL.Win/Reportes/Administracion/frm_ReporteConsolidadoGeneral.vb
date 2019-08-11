Public Class frm_ReporteConsolidadoGeneral
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        InitializeComponent()
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteConsolidadoGeneral = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteConsolidadoGeneral()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Metodos"

    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte Consolidado General"
            CargarReporteRemoto("/Reportes/", "ADM - Reporte Consolidado General")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Cerrar el formulario"

    Private Sub frm_ReporteConsolidadoGeneral_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class