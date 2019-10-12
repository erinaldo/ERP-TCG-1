'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ReporteMaterialPendienteRequerimiento
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteMaterialPendienteRequerimiento = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteMaterialPendienteRequerimiento()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    Private Sub CargarDatos()
        Try
            Me.Text = "Materiales Pendientes"
            CargarReporteRemoto("/Reportes/", "ALM - Materiales x Atender en Requerimientos")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ReporteMaterialPendienteRequerimiento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class