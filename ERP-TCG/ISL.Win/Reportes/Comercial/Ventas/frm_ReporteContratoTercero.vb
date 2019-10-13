'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports Microsoft.Reporting.WinForms

Public Class frm_ReporteContratoTercero
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteContratoTercero = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteContratoTercero()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarDatos(Id As String)
        Try
            Dim Parametros(0) As ReportParameter
            Parametros(0) = New ReportParameter("Id", Id)

            Me.Text = "Contrato Tercero"
            CargarReporteRemoto("/Reportes/", "OPE - Reporte Contrato Tercero", Parametros)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub


#Region "Cerrar el formulario"

    Private Sub frm_ReporteContratoTercero_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class