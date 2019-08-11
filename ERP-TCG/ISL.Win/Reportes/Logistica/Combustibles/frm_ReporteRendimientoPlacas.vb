Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ReporteRendimientoPlacas
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteRendimientoPlacas = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteRendimientoPlacas()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Metodos"

    Public Sub CargarDatos(ByVal lista As List(Of e_ReporteTanqueoCombustible))
        Try
            CargarReporteLocalObjeto(lista, "Rendimiento Placas", "ReporteTanqueo", "Reportes\Logistica\Combustibles\ReporteDieselPlaca.rdlc")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Cerrar el formulario"

    Private Sub frm_ReporteRendimientoPlacas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class