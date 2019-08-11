Public Class frm_ReporteProgramacionViaje
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteProgramacionViaje = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteProgramacionViaje()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte de Programación de Viajes"
            CargarReporteRemoto("/Reportes/", "OPE - ProgramacionFechaRuta")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ReporteProgramacionViaje_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class