Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_AsistenciaPersonal
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_AsistenciaPersonal = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_AsistenciaPersonal()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeAsistenciaPersonal As New e_AsistenciaPersonal
    Private olAsistenciaPersonal As New l_AsistenciaPersonal
    Private loAsistenciaPersonal As New List(Of e_AsistenciaPersonal)

    Private oeTrabajador As New e_Trabajador
    Private olTrabajador As New l_Trabajador

    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, ficAsistenciaPersonal, 1)
            oeAsistenciaPersonal.Modificado = False
            Inicializar()
            Operacion = "Nuevo"
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            CargarDatos()
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeAsistenciaPersonal.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        'If GuardarContrato() Then
                        '    MostrarTabs(0, ficContratos, 2)
                        '    _ingresando_datos = False
                        '    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        'Else
                        _ingresando_datos = True
                        MostrarTabs(1, ficAsistenciaPersonal, 1)
                        'End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficAsistenciaPersonal, 2)
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficAsistenciaPersonal)
                _ingresando_datos = False
            End If
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

    Public Sub Inicializar()
        Try
            Marcar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub Marcar()
        Try
            Dim formulario As frm_AutenticarTrabajador
            formulario = New frm_AutenticarTrabajador
            Dim idTrabEntr As String = ""
            If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                Exit Sub
            Else
                GuardarAsistencia(formulario.idTrabajador)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar()

    End Sub

    Private Sub frm_AsistenciaPersonal_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficAsistenciaPersonal.SelectedTab.Index
            Case 0
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Case 1
                ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_AsistenciaPersonal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_AsistenciaPersonal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Function GuardarAsistencia(ByVal IdTrabajador As String) As Boolean
        Try
            oeAsistenciaPersonal = New e_AsistenciaPersonal
            oeAsistenciaPersonal.IdTrabajador = IdTrabajador
            oeAsistenciaPersonal.Fecha = ObtenerFechaServidor()
            oeAsistenciaPersonal.TipoOperacion = "I"
            If olAsistenciaPersonal.Guardar(oeAsistenciaPersonal) Then
                mensajeEmergente.Confirmacion("Informacion Guardada Correctamente")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarDatos()
        Try
            CargarReporteRemoto("/Reportes/", "PER - Asistencia de Personal")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CargarReporteRemoto(ByVal ubicacionReporte As String, ByVal nombreReporte As String)
        Try
            'ValidarCombo(cboClienteProveedor, "ClienteProveedor")
            'ValidarCombo(cboCliente, "Empresa")
            'ValidarCombo(cboCuenta, "Cuenta")

            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote

            Dim olConfiguracion As New l_Configuracion
            ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://" & olConfiguracion.IPServidorReportes & "/ReportServer_SRVSQLISLPYO")
            ReportViewer1.ServerReport.ReportPath = ubicacionReporte + nombreReporte
            'If Not myParams Is Nothing Then
            Dim myParams(3) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("FechaInicio", fecFechaInicio.Value)
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("FechaFin", fecFechaFin.Value)
            myParams(2) = New Microsoft.Reporting.WinForms.ReportParameter("IdTrabajador", cboTrabajador.Value.ToString)
            myParams(3) = New Microsoft.Reporting.WinForms.ReportParameter("IdArea", cboArea.Value.ToString)

            'End If

            ReportViewer1.ServerReport.SetParameters(myParams)
            'ReportViewer1.ProcessingMode = ProcessingMode.Remote;
            'ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            ReportViewer1.ShowParameterPrompts = False
            ReportViewer1.ShowPromptAreaButton = False
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub frm_AsistenciaPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBs()
        Fechas()
    End Sub

    Private Sub CargarCBs()
        Dim oeC As New e_Combo
        Dim listatrabajador As New List(Of e_Combo)
        oeC.Id = ""
        oeC.Nombre = "TODOS"
        listatrabajador.Add(oeC)
        listatrabajador.AddRange(TrabajadorPublic)
        LlenarCombo(cboTrabajador, "Nombre", listatrabajador, 0)
        Dim oeArea As New e_Area
        Dim oeA As New e_Area
        Dim olArea As New l_Area
        Dim loArea As New List(Of e_Area)
        oeA.Id = ""
        oeA.Nombre = "TODOS"
        loArea.Add(oeA)
        loArea.AddRange(olArea.Listar(oeArea))
        LlenarCombo(cboArea, "Nombre", loArea, 0)
    End Sub

    Private Sub Fechas()
        Dim fechaservidor As Date = ObtenerFechaServidor()
        fecFechaInicio.Value = fechaservidor.AddDays(-fechaservidor.Day + 1)
        fecFechaFin.Value = fechaservidor
    End Sub

End Class