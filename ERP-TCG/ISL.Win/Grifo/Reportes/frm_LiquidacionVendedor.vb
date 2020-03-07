Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_LiquidacionVendedor
    Inherits frm_MenuPadre

    Dim wr_Reporte As New l_Reporte, Reporte As New e_ReporteFiltro
    Dim DT1 As New DataTable, DT2 As New DataTable, DT3 As New DataTable
    Dim IdTurno As String

#Region "Inicializacion del Formulario"

    Private Shared instancia As frm_LiquidacionVendedor = Nothing
    Private Shared Operacion As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(pIdTurno As String)
        InitializeComponent()
        IdTurno = pIdTurno
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_LiquidacionVendedor()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

    Private Sub frm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        gmt_ControlBoton(0, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs)
        Try
            Reporte.ProcedimientoAlmacenado = "STD.RPT_LiquidacionVendedor"
            Reporte.TipoConsulta = "VEN"
            Reporte.FechaInicial = dtp_FechaInicio.Value.Date
            Reporte.FechaFinal = dtp_FechaFin.Value.Date
            Reporte.Id = IdTurno
            Reporte.Filtro1 = ""
            Reporte.Filtro2 = ""
            Reporte.Filtro3 = ""
            DT1 = wr_Reporte.Consultar(Reporte)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class