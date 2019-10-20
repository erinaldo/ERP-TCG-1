'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Microsoft.Reporting.WinForms

Public Class frm_ReporteObligacionxPeriodo
    Inherits frm_MenuPadre

#Region "Inicializar"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteObligacionxPeriodo = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteObligacionxPeriodo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeProveedor As e_Proveedor, olProveedor As l_Proveedor, leProveedor As List(Of e_Proveedor)
    Private oePeriodo As e_Periodo, olPeriodo As l_Periodo, leEjercicio As List(Of e_Periodo), lePeriodo As List(Of e_Periodo)
    Private oeCtaContable As e_CuentaContable, olCtaContable As l_CuentaContable, leCtaContable As List(Of e_CuentaContable)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            mt_CargarReporteRemoto("/Reportes/", "FIN - Obligaciones por Periodo")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteObligacionxPeriodo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_ReporteObligacionxPeriodo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteObligacionxPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_InicilizarLogicas()
            mt_CargarPeriodo()
            mt_CargarProveedor()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboEjercicio_ValueChanged(sender As Object, e As EventArgs) Handles cboEjercicio.ValueChanged
        Try
            If cboEjercicio.SelectedIndex > -1 Then
                oePeriodo = cboEjercicio.SelectedItem.ListObject
                LlenarCombo(cboMes, "NomMes", lePeriodo.Where(Function(it) it.Ejercicio = oePeriodo.Ejercicio).OrderByDescending(Function(it) it.Mes).ToList, 0)
                mt_CargarCuenta(oePeriodo.Ejercicio)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCuenta_ValueChanged(sender As Object, e As EventArgs) Handles cboCuenta.ValueChanged
        Try
            txtCuenta.Text = String.Empty
            If cboCuenta.SelectedIndex > -1 Then
                oeCtaContable = cboCuenta.SelectedItem.ListObject
                txtCuenta.Text = oeCtaContable.Nombre
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_InicilizarLogicas()
        olPeriodo = New l_Periodo
        olProveedor = New l_Proveedor
        olCtaContable = New l_CuentaContable
    End Sub

    Private Sub mt_CargarReporteRemoto(ByVal ubicacionReporte As String, ByVal nombreReporte As String)
        Try
            If IsNothing(cboProveedor.Value) Then Throw New Exception("Seleccione Empresa")
            ValidarCombo(cboCuenta, "Cuenta")
            If cboMes.SelectedIndex = -1 Then Throw New Exception("Seleccione Mes")
            oePeriodo = cboMes.SelectedItem.ListObject 
            Me.rvwDatos.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote

            Dim olConfiguracion As New l_Configuracion
            rvwDatos.ServerReport.ReportServerUrl = New Uri("http://" & olConfiguracion.IPServidorReportes & "/ReportServer")
            'If Not myParams Is Nothing Then
            Dim myParams(5) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("TipoResumen", CStr(IIf(chkResumen.Checked, "SI", "NO")))
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", cboEjercicio.Value.ToString)
            myParams(2) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", oePeriodo.Mes.ToString)
            myParams(3) = New Microsoft.Reporting.WinForms.ReportParameter("IdClienteProveedor", cboProveedor.Value.ToString)
            myParams(4) = New Microsoft.Reporting.WinForms.ReportParameter("IndCompraVenta", "1CH000011")
            myParams(5) = New Microsoft.Reporting.WinForms.ReportParameter("IdCuentaContable", cboCuenta.Value.ToString)
            'End If
            rvwDatos.ServerReport.ReportPath = ubicacionReporte + nombreReporte
            rvwDatos.ServerReport.SetParameters(myParams)
            'ReportViewer1.ProcessingMode = ProcessingMode.Remote;
            'ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            rvwDatos.ShowParameterPrompts = False
            rvwDatos.ShowPromptAreaButton = False
            rvwDatos.RefreshReport()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_CargarProveedor()
        Try
            oeProveedor = New e_Proveedor : leProveedor = New List(Of e_Proveedor)
            oeProveedor.Id = " " : oeProveedor.Nombre = " TODOS " : oeProveedor.Activo = True
            leProveedor.Add(oeProveedor)
            oeProveedor = New e_Proveedor
            oeProveedor.Activo = True
            leProveedor.AddRange(olProveedor.Listar(oeProveedor))
            LlenarCombo(cboProveedor, "Nombre", leProveedor, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarPeriodo()
        Try
            oePeriodo = New e_Periodo : lePeriodo = New List(Of e_Periodo)
            oePeriodo.TipoOperacion = "" : oePeriodo.Ejercicio = 0
            lePeriodo = olPeriodo.Listar(oePeriodo)
            oePeriodo = New e_Periodo : leEjercicio = New List(Of e_Periodo)
            oePeriodo.TipoOperacion = "E"
            leEjercicio = olPeriodo.Listar(oePeriodo)
            LlenarCombo(cboEjercicio, "Ejercicio", leEjercicio, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCuenta(Ejercicio As Integer)
        Try
            oeCtaContable = New e_CuentaContable : leCtaContable = New List(Of e_CuentaContable)
            oeCtaContable.TipoOperacion = "O"
            oeCtaContable.Ejercicio = Ejercicio
            leCtaContable = olCtaContable.Listar(oeCtaContable)
            LlenarCombo(cboCuenta, "Cuenta", leCtaContable, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class