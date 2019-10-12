'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Public Class frm_ReporteProvisionSueldosSalarios
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteProvisionSueldosSalarios = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteProvisionSueldosSalarios()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Cerrar el formulario"

    Private Sub frm_ReporteProvisionSueldosSalarios_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

    Private Sub frm_ReporteProvisionSueldosSalarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte Provisión Sueldos y Salarios"
            CargarReporteRemoto("/Reportes/", "PER - ReporteProvisionSueldosSalarios")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

End Class