'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Reporting.WinForms

Public Class frm_ReporteRegistroCompra
    Inherits frm_MenuPadre

    'Private leClienteProv As New List(Of e_Cliente)

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteRegistroCompra = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteRegistroCompra()
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
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub ComboPeriodo()
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


    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Try
            Dim dt As New DataTable
            Dim olMovimientoDoc As New l_MovimientoDocumento
            dt = olMovimientoDoc.RegistroCompras(cboMes.Value)

            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

            Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)
            'ReportViewer1.LocalReport.DataSources.Clear()


            Dim oReport As New ReportDataSource("dsRegistroCompras_Compras", dt)

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(myParams)
            ReportViewer1.LocalReport.DataSources.Add(oReport)

            ReportViewer1.LocalReport.Refresh()
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
        End Try
    End Sub

#Region "Cerrar el formulario"

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
        ComboPeriodo()
    End Sub

#End Region

End Class