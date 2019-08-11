Public Class frm_ReporteDiaCobro
    Inherits ISL.Win.frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteDiaCobro = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteDiaCobro()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    Private Sub CargarDatos()
        Try
            'Me.Text = ": Tracto Cliente"
            CargarReporteRemoto("/Reportes/", "ADM - Reporte Dia Cobro")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_FacturadoTractoCliente_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub
#End Region

End Class