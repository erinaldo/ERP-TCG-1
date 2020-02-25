Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_Reporte_RIC
    Inherits frm_MenuPadre

    Dim wr_Reporte As New l_Reporte, Reporte As New e_ReporteFiltro
    Dim DT As New DataTable

#Region "Inicializacion del Formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Reporte_RIC = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_Reporte_RIC()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    Private Sub frm_Reporte_RIC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar_RIC.Click
        Try
            Reporte.ProcedimientoAlmacenado = "STD.RPT_RIC"
            Reporte.TipoConsulta = "RIC"
            Reporte.FechaInicial = dtpFechaCorte.Value.Date
            DT = wr_Reporte.Consultar(Reporte)
            udg_CuadroRIC.DataSource = DT
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

End Class