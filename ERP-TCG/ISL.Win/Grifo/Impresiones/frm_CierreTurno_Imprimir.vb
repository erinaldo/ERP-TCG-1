﻿Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports System.IO

Public Class frm_CierreTurno_Imprimir

    Private IdCierreTurno As String, IdReporte As String, IdConsulta As String, FechaCierre As Date
    Private CierreTurno As New e_CierreTurno, CierreTurnoDetalle As New e_CierreTurno_Detalle, wr_CierreTurno As New l_CierreTurno
    Private DT1 As New DataTable, DT2 As New DataTable
    Private RDS1 As New Microsoft.Reporting.WinForms.ReportDataSource, RDS2 As New Microsoft.Reporting.WinForms.ReportDataSource

    Sub New(pId As String, pTipoPapel As String, pModulo As String)
        InitializeComponent()
        IdCierreTurno = pId
        'TipoPapel = pTipoPapel
        'ModuloEmision = pModulo
        'Inicializar()
    End Sub

    Sub New(pId As String, pIdReporte As String)
        InitializeComponent()
        IdCierreTurno = pId
        IdReporte = pIdReporte
        Select Case IdReporte
            Case "1" 'Cierre de Turno Parcial
                IdConsulta = "DTP"
            Case "2"
                IdConsulta = "DTC"
        End Select
        Inicializar()
    End Sub

    Sub New(pFechaCierre As Date, pIdReporte As String)
        InitializeComponent()
        FechaCierre = pFechaCierre
        IdReporte = pIdReporte
        Select Case IdReporte
            Case "1" 'Cierre de Turno Parcial
                CierreTurno.TipoOperacion = "DTP" : CierreTurno.Id = IdCierreTurno
                CierreTurnoDetalle.TipoOperacion = "DTP" : CierreTurnoDetalle.IdCierreTurno = IdCierreTurno
            Case "2"
                CierreTurno.TipoOperacion = "DTC" : CierreTurno.Fecha = FechaCierre
                CierreTurnoDetalle.TipoOperacion = "DTC" : CierreTurnoDetalle.FechaCrea = FechaCierre
        End Select
        Inicializar()
    End Sub

    Private Sub Inicializar()
        Try
            'CierreTurno = wr_CierreTurno.Obtener(New e_CierreTurno With {.TipoOperacion = "", .Id = IdCierreTurno})
            'DT1 = wr_CierreTurno.dt_CierreTurno_Impresion(New e_CierreTurno With {.TipoOperacion = "", .Id = IdCierreTurno})
            'DT2 = wr_CierreTurno.dt_CierreTurnoDetalle_Impresion(New e_CierreTurno_Detalle With {.TipoOperacion = "", .IdCierreTurno = IdCierreTurno})

            'BSO1.DataSource = DT1
            'BSO2.DataSource = DT2

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With RDS1
                .Name = "Cabecera"
                .Value = wr_CierreTurno.dt_CierreTurno_Impresion(CierreTurno)
            End With
            With RDS2
                .Name = "Detalle"
                .Value = wr_CierreTurno.dt_CierreTurnoDetalle_Impresion(CierreTurnoDetalle)
            End With

            With VISOR
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                '.LocalReport.ReportPath = Obtener_RutaReporte(IdReporte)
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(RDS1)
                .LocalReport.DataSources.Add(RDS2)
                ' .LocalReport.DisplayName = DT1.Rows(0).Item("DOI").ToString + "-" + DT1.Rows(0).Item("SerieNumero").ToString
                .LocalReport.Refresh()
            End With

            VISOR.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Function Obtener_RutaReporte() As String
        'Dim Raiz As String = "...\Debug\Grifo\Impresiones\"
        'C:\Users\CESS\Source\Repos\ERP-TCG\ERP-TCG\ISL.Win\Grifo\Impresiones\rpt_DocumentoCtble_A4.rdlc
        Dim Raiz As String = Path.Combine(Application.StartupPath, "Grifo") & "\Impresiones\"
        Select Case IdReporte
            Case "1" 'Factura
                Return Raiz & "rpt_CierreParcial.rdlc"
            Case "2" 'Factura
                Return Raiz & "rpt_CierreCompleto.rdlc"
            Case Else
                Return ""
        End Select
    End Function
End Class