'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Public Class frm_ReporteHistorialCobros
    Inherits frm_ReporteBasico

    Private Shared instancia As frm_ReporteHistorialCobros = Nothing
    Private Shared Operacion As String

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    'Private Shared instancia As frm_ReporteHistorialCobros = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_ReporteHistorialCobros()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_ReporteHistorialCobros
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_ReporteHistorialCobros
        End If
        instancia.Activate()
        Return instancia
    End Function


#End Region

#Region "Eventos"

    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte de Historial de Cobros"
            CargarReporteRemoto("/Reportes/", "CON - Reporte de Historial de Cobros")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Cerrar el formulario"

    Private Sub frm_ReporteHistorialCobros_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class