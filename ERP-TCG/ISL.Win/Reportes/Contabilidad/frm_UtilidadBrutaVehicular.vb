
Public Class frm_UtilidadBrutaVehicular
    Inherits frm_ReporteBasico

    Private Shared instancia As frm_UtilidadBrutaVehicular = Nothing
    Private Shared Operacion As String

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    'Private Shared instancia As frm_UtilidadBrutaVehicular = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_UtilidadBrutaVehicular()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_UtilidadBrutaVehicular
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_UtilidadBrutaVehicular
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
            Me.Text = "Utilidad Bruta Vehicular"
            CargarReporteRemoto("/Reportes/", "CON - Utilidad Bruta Vehicular")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_UtilidadBrutaVehicular_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

    Private Sub frm_UtilidadBrutaVehicular_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
