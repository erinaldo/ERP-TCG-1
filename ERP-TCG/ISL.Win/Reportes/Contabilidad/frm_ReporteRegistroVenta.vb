'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Reporting.WinForms

Public Class frm_ReporteRegistroVenta
    Inherits frm_MenuPadre

    Private Shared instancia As frm_ReporteRegistroVenta = Nothing
    Private Shared Operacion As String

#Region "Inicializar formulario"

    Public Sub New()
        InitializeComponent()
    End Sub

    'Private Shared instancia As frm_ReporteRegistroVenta = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_ReporteRegistroVenta()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_ReporteRegistroVenta
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_ReporteRegistroVenta
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            CargarDatos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub ComboPerido()
        Try

            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            Dim lePeriodo As New List(Of e_Periodo)
            oePeriodo.Ejercicio = Año1.Año
            oePeriodo.Activo = True
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            With cboMes
                .DisplayMember = "Mes"
                .ValueMember = "Id"
                .DataSource = lePeriodo
                If .Items.Count > 0 Then
                    .Text = Date.Now.Month
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDatos()
        Try
            Dim dt As New DataTable
            Dim olMovimientoDoc As New l_MovimientoDocumento
            dt = olMovimientoDoc.RegistroVentas(cboMes.Value)

            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            '@0001 Ini
            'Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
            'myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
            'myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)

            Dim dc As DataColumn
            dc = New DataColumn("EmpresaSis", Type.GetType("System.String"))
            dt.Columns.Add(dc)
            dc = New DataColumn("RucSis", Type.GetType("System.String"))
            dt.Columns.Add(dc)
            dt.Rows(0).Item("EmpresaSis") = gs_TxtEmpresaSistema.Trim
            dt.Rows(0).Item("RucSis") = gs_RucEmpresaSistema.Trim
            '@0001 Fin
            Dim oReport As New ReportDataSource("dsRegistroVentas_Ventas", dt)

            ReportViewer1.LocalReport.DataSources.Clear()
            'ReportViewer1.LocalReport.SetParameters(myParams) '@0001
            ReportViewer1.LocalReport.DataSources.Add(oReport)

            ReportViewer1.LocalReport.Refresh()
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteRegistroVenta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_ReporteRegistroVenta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteRegistroVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Año1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Año1.Validated
        ComboPerido()
    End Sub

#End Region

End Class