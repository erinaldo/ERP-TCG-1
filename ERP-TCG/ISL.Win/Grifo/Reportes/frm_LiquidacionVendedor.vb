Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_LiquidacionVendedor
    Inherits frm_MenuPadre

    Dim wr_Reporte As New l_Reporte, Reporte As New e_ReporteFiltro
    Dim DT1 As New DataTable, DT2 As New DataTable, DT3 As New DataTable
    Dim RDS1 As New Microsoft.Reporting.WinForms.ReportDataSource, RDS2 As New Microsoft.Reporting.WinForms.ReportDataSource, RDS3 As New Microsoft.Reporting.WinForms.ReportDataSource
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
            Cargar_Ventas()
            Cargar_Resumen()
            Cargar_Depositos()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Cargar_Ventas()
        Try
            Reporte = New e_ReporteFiltro
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

    Public Sub Cargar_Resumen()
        Try
            Reporte = New e_ReporteFiltro
            Reporte.ProcedimientoAlmacenado = "STD.RPT_LiquidacionVendedor"
            Reporte.TipoConsulta = "RES"
            Reporte.FechaInicial = dtp_FechaInicio.Value.Date
            Reporte.FechaFinal = dtp_FechaFin.Value.Date
            Reporte.Id = IdTurno
            Reporte.Filtro1 = ""
            Reporte.Filtro2 = ""
            Reporte.Filtro3 = ""
            DT2 = wr_Reporte.Consultar(Reporte)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Cargar_Depositos()
        Try
            Reporte = New e_ReporteFiltro
            Reporte.ProcedimientoAlmacenado = "STD.RPT_LiquidacionVendedor"
            Reporte.TipoConsulta = "DEP"
            Reporte.FechaInicial = dtp_FechaInicio.Value.Date
            Reporte.FechaFinal = dtp_FechaFin.Value.Date
            Reporte.Id = IdTurno
            Reporte.Filtro1 = ""
            Reporte.Filtro2 = ""
            Reporte.Filtro3 = ""
            DT3 = wr_Reporte.Consultar(Reporte)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Cargar_Reporte()
        Try
            '' Report DataSource 1
            RDS1.Name = "DTS1"
            RDS1.Value = DT1
            '' Report DataSource 2
            RDS2.Name = "DTS2"
            RDS2.Value = DT2
            '' Report DataSource 3
            RDS3.Name = "DT3"
            RDS3.Value = DT3

            With VISOR
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(RDS1)
                .LocalReport.DataSources.Add(RDS2)
                .LocalReport.DataSources.Add(RDS3)
                .LocalReport.Refresh()
                .RefreshReport()
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub
End Class