Public Class frm_ReporteNecesidadConductores
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteNecesidadConductores = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteNecesidadConductores()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Eventos"

    Private Sub frm_ReporteNecesidadConductores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarDatos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ReporteNecesidadConductores_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte Necesidad Conductores"
            CargarReporteRemoto("/Reportes/", "OPE - Reporte Necesidad de Conductores")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class