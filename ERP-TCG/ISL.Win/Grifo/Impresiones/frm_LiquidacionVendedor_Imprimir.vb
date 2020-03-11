Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Microsoft.Reporting.WinForms
Imports MessagingToolkit.QRCode.Codec
Imports System.IO
Imports System.Configuration
Imports System.Collections.Specialized

Public Class frm_LiquidacionVendedor_Imprimir

    Private Shared Instancia As frm_LiquidacionVendedor_Imprimir = Nothing
    Private Shared Operacion As String

    Dim wr_Reporte As New l_Reporte, Reporte As New e_ReporteFiltro
    Dim DT1 As New DataTable, DT2 As New DataTable, DT3 As New DataTable
    Dim RDS1 As New Microsoft.Reporting.WinForms.ReportDataSource, RDS2 As New Microsoft.Reporting.WinForms.ReportDataSource, RDS3 As New Microsoft.Reporting.WinForms.ReportDataSource

#Region "Funciones Basicas"

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_LiquidacionVendedor_Imprimir()
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub frm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        gmt_ControlBoton(0, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combos()
    End Sub

    Private Sub frm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Instancia = Nothing
    End Sub

#End Region

#Region "Liquidacion de Vendedor"

    Private Sub btn_Cargar_LiquidacionVendedor_Click(sender As Object, e As EventArgs) Handles btn_Cargar_LiquidacionVendedor.Click
        Cargar_Reporte()
    End Sub

    Private Sub dtp_FechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtp_FechaInicio.ValueChanged
        Cargar_Combos()
    End Sub

    Private Sub Cargar_Combos()
        Try
            Dim lTurno As New l_CierreTurno, Lista As New List(Of e_CierreTurno)
            Lista = lTurno.Listar(New e_CierreTurno With {.TipoOperacion = "CMB", .Fecha = dtp_FechaInicio.Value.Date})
            LlenarComboMaestro(cmb_Turno, Lista, 0)
            cmb_Turno.DisplayMember = "Turno"
            cmb_Turno.ValueMember = "Id"
            With cmb_Turno.DisplayLayout.Bands(0)
                For Each Columna In .Columns
                    Columna.Hidden = True
                Next
                .Columns("Turno").Hidden = False : .Columns("Turno").Width = 150
            End With
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
            Reporte.FechaFinal = dtp_FechaFinal.Value.Date
            Reporte.Id = cmb_Turno.Value
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
            Reporte.FechaFinal = dtp_FechaFinal.Value.Date
            Reporte.Id = cmb_Turno.Value
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
            Reporte.FechaFinal = dtp_FechaFinal.Value.Date
            Reporte.Id = cmb_Turno.Value
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
            If cmb_Turno.Value = "" Then cmb_Turno.Focus() : Throw New Exception("Debe seleccionar un TURNO")

            '' Report DataSource 1
            Cargar_Ventas()
            RDS1.Name = "DTS1" : RDS1.Value = DT1
            '' Report DataSource 2
            Cargar_Resumen()
            RDS2.Name = "DTS2" : RDS2.Value = DT2
            '' Report DataSource 3
            Cargar_Depositos()
            RDS3.Name = "DTS3" : RDS3.Value = DT3

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

#End Region

End Class