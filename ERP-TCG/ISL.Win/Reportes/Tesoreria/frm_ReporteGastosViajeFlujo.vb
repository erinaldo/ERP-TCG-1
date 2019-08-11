Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ReporteGastosViajeFlujo
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteGastosViajeFlujo = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteGastosViajeFlujo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte Gastos Viajes Flujo"
            CargarReporteRemoto("/Reportes/", "TES - Reporte Gastos Viajes Flujos")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ReporteGastosViajeFlujo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class