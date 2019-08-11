Public Class frm_ReporteCuentaBancaria
    Inherits frm_ReporteBasico

    Private Shared instancia As frm_ReporteCuentaBancaria = Nothing
    Private Shared Operacion As String

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    'Private Shared instancia As frm_ReporteCuentaBancaria = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_ReporteCuentaBancaria()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_ReporteCuentaBancaria
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_ReporteCuentaBancaria
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte Cuentas Bancarias"
            CargarReporteRemoto("/Reportes/", "CON - Cuentas Bancarias")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ReporteCuentaBancaria_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class