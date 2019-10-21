'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_ReporteCuentasxPagarADM
    Inherits frm_ReporteBasico

    Private Shared instancia As frm_ReporteCuentasxPagarADM = Nothing
    Private Shared Operacion As String

#Region "Inicializar formulario"

    Public Sub New()
        InitializeComponent()
        CargarDatos()
    End Sub

    'Private Shared instancia As frm_ReporteCuentasxPagarADM = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_ReporteCuentasxPagarADM()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_ReporteCuentasxPagarADM
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_ReporteCuentasxPagarADM
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Metodos"

    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte de Cuentas por Pagar"
            CargarReporteRemoto("/Reportes/", "ADM - Reporte Cuentas x Pagar")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Cerrar el formulario"

    Private Sub frm_ReporteCuentasxPagarADM_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class