'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Microsoft.Reporting.WinForms

Public Class frm_ReporteBasico
    Inherits frm_MenuPadre

#Region "Inicializar formulario"

    'Private listaParametros As New List(Of ReportParameter)

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteBasico = Nothing
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteBasico()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    ''' <summary>
    ''' Carga los datos pasados en el reporte local específico, por defecto el reporte "D:\SGI\ISL.Win\Reportes\Reporte.rdlc",
    ''' </summary>
    ''' <param name="listaDatos">Lista de datos</param>
    ''' <param name="titulo">Título de la pantalla / reporte</param>
    ''' <param name="instanciaOrigenDatos">Instancia del origen de datos asociados al reporte</param>
    ''' <param name="archivoReporte">Ruta y nombre del archivo de reporte</param>
    ''' <remarks></remarks>
    Public Sub CargarReporteLocal(ByVal listaDatos As Object, ByVal titulo As String, _
                                   ByVal instanciaOrigenDatos As String, _
                                   ByVal archivoReporte As String, _
                                   Optional ByVal myParams As Microsoft.Reporting.WinForms.ReportParameter() = Nothing)
        Try

            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Me.ReportViewer1.Visible = True
            Me.ReportViewer1.LocalReport.ReportPath = archivoReporte
            Dim oReport As New ReportDataSource(instanciaOrigenDatos, listaDatos)

            Me.Text = titulo
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            If Not myParams Is Nothing Then
                Me.ReportViewer1.LocalReport.SetParameters(myParams)
            End If


            Me.ReportViewer1.LocalReport.DataSources.Add(oReport)

            Me.ReportViewer1.LocalReport.Refresh()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub CargarReporteRemoto(ByVal ubicacionReporte As String, ByVal nombreReporte As String, Optional ByVal myParams As Object = Nothing)
        Try
            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            Dim olConfiguracion As New l_Configuracion
            '@0001
            If gs_PrefijoIdSucursal = "1PY" Then
                ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://" & olConfiguracion.IPServidorReportes & "/ReportServer")
            Else
                ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://" & olConfiguracion.IPServidorReportes & "/ReportServer")
            End If
            'ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://" & olConfiguracion.IPServidorReportes & "/ReportServer_HEAVEN")
            ReportViewer1.ServerReport.ReportPath = "/Reportes/" + nombreReporte
            If Not myParams Is Nothing Then
                ReportViewer1.ServerReport.SetParameters(myParams)
            End If
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    '''' <summary>
    '''' Asigna parámetros al reporte
    '''' </summary>
    '''' <param name="nombreParametro"></param>
    '''' <param name="valorParametro"></param>
    '''' <remarks></remarks>
    'Public Sub Parametros(ByVal nombreParametro As String, ByVal valorParametro As String)
    '    listaParametros.Add(New ReportParameter(nombreParametro, valorParametro))
    '    ReportViewer1.LocalReport.SetParameters(listaParametros)
    'End Sub

    Public Sub CargarReporteLocalObjeto(ByVal listaDatos As Object, ByVal titulo As String, _
                                   ByVal instanciaOrigenDatos As String, _
                                   ByVal archivoReporte As String, _
                                   Optional ByVal myParams As Microsoft.Reporting.WinForms.ReportParameter() = Nothing)
        Try
            Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Me.ReportViewer1.Visible = True
            Me.ReportViewer1.LocalReport.ReportPath = archivoReporte    
            '"BusinessObjectV.Report1.rdlc"
            ReportDataSource1.Name = instanciaOrigenDatos
            ReportDataSource1.Value = DatosBindingSource
            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
            'Me.ReportViewer1.LocalReport.ReportEmbeddedResource = archivoReporte
            Me.Text = titulo
            DatosBindingSource.DataSource = listaDatos
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


    Private Sub frm_ReporteBasico_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)

    End Sub

    Private Sub frm_ReporteBasico_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

  

End Class