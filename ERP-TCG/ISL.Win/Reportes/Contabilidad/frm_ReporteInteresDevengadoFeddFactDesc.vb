Public Class frm_ReporteInteresDevengadoFeddFactDesc
    Inherits frm_ReporteBasico

    Private Shared instancia As frm_ReporteInteresDevengadoFeddFactDesc = Nothing
    Private Shared Operacion As String

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    'Private Shared instancia As frm_ReporteInteresDevengadoFeddFactDesc = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_ReporteInteresDevengadoFeddFactDesc()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_ReporteInteresDevengadoFeddFactDesc
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_ReporteInteresDevengadoFeddFactDesc
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
            Me.Text = "Interes Devengado Fedd y Facturas al Desc"
            CargarReporteRemoto("/Reportes/", "FIN - ReporteInteresDevengadosFeddFactalDesc")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ReporteControlCompra_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region
End Class
