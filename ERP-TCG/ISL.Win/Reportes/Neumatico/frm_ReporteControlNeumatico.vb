'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Public Class frm_ReporteControlNeumatico
    Inherits frm_ReporteBasico

#Region "Inicializar Formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteControlNeumatico = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteControlNeumatico()
        End If
        instancia.Activate()
        Return instancia
    End Function


#End Region

#Region "Eventos"

    Private Sub frm_ReporteControlNeumatico_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteControlNeumatico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte de Baja de Neumatico"
            CargarReporteRemoto("/Reportes/", "NEU - Reporte Neumartico Control")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

#End Region



End Class