'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Reporting.WinForms

Public Class frm_HistorialPagos
    Inherits frm_MenuPadre

    Private Shared instancia As frm_HistorialPagos = Nothing
    Private Shared Operacion As String

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    'Private Shared instancia As frm_HistorialPagos = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_HistorialPagos()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_HistorialPagos
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_HistorialPagos
        End If
        instancia.Activate()
        Return instancia
    End Function


#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ProcesarReporte()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_HistorialPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaComboProveedor()
        ReportViewer1.ShowParameterPrompts = False
        ReportViewer1.ShowPromptAreaButton = False
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frm_HistorialPagos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub cboProveedores_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboProveedores.InitializeLayout
        Try
            InicializarComboProveedor()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedores_Enter(sender As Object, e As EventArgs)
        cboProveedores.SelectAll()
    End Sub

#End Region

#Region "Metodos"

    Private Sub InicializarComboProveedor()
        Try
            Me.cboProveedores.ValueMember = "Id"
            Me.cboProveedores.DisplayMember = "Nombre"
            For Each Col In cboProveedores.DisplayLayout.Bands(0).Columns
                Col.Hidden = "True"
            Next
            cboProveedores.DropDownStyle = UltraComboStyle.DropDown
            cboProveedores.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
            cboProveedores.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
            cboProveedores.DisplayLayout.Bands(0).ColHeadersVisible = False
            cboProveedores.DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
            cboProveedores.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaComboProveedor()
        Dim loProveedor As New List(Of e_Proveedor)
        Dim oeProveedor As New e_Proveedor
        Dim olProveedor As New l_Proveedor
        oeProveedor.TipoOperacion = "5"
        cboProveedores.Value = Nothing
        loProveedor.AddRange(olProveedor.Listar(oeProveedor))
        With cboProveedores
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = loProveedor
        End With
        InicializarComboProveedor()
    End Sub

    Public Sub ProcesarReporte()
        Try
            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            Dim olConfiguracion As New l_Configuracion
            ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://" & olConfiguracion.IPServidorReportes & "/ReportServer_SRVSQLISLPYO")
            'ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://" & olConfiguracion.IPServidorReportes & "/ReportServer_HEAVEN")
            ReportViewer1.ServerReport.ReportPath = "/Reportes/" + "CON - Reporte de Historial de Pagos"
            Dim myParams(2) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("FechaInicio", dtpFecInicio.Value.Date)
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("FechaFin", dtpFechaFin.Value.Date)
            myParams(2) = New Microsoft.Reporting.WinForms.ReportParameter("IdProveedor", cboProveedores.Value.ToString)
            ReportViewer1.ServerReport.SetParameters(myParams)
            ReportViewer1.ShowParameterPrompts = False
            ReportViewer1.ShowPromptAreaButton = False
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class