Public Class frm_ReporteMontoFleteTracto
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteMontoFleteTracto = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteMontoFleteTracto()
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
            Me.Text = "Reporte de Monto de Flete por Tracto"
            CargarReporteRemoto("/Reportes/Operaciones/", "OPE - Reporte de Monto de Flete x Tracto")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub CargarDatosAlerta(FechaInicio As DateTime)
        Try
            Me.Text = "Reporte de Monto de Flete por Tracto"
            Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("FechaInicio", FechaInicio)
            Dim Flotas() As String = {"1CH001", "1CH002", "1CH003", "1CH005"}
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("IdFlota", Flotas)
            CargarReporteRemoto("/Reportes/", "OPE - Reporte de Monto de Flete x Tracto", myParams)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ReporteMontoFleteTracto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class