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
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ReporteCuentasxCyPxPeriodo
    Inherits frm_MenuPadre
    Private leCliente As New List(Of e_Cliente)
    Private leProveedor As New List(Of e_Proveedor)
    Private lsBandera As String

    Private Shared instancia As frm_ReporteCuentasxCyPxPeriodo = Nothing
    Private Shared Operacion As String

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    'Private Shared instancia As frm_ReporteCuentasxCyPxPeriodo = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_ReporteCuentasxCyPxPeriodo()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_ReporteCuentasxCyPxPeriodo
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_ReporteCuentasxCyPxPeriodo
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            CargarDatos()
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()

    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        'Try
        '    If gridDocumentos.Rows.Count = 0 Then Throw New Exception("No hay ningún Pago para exportar al Excel")
        '    Exportar_Excel(gridDocumentos)

        '    MyBase.Exportar()
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message)
        'End Try
    End Sub

#End Region

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Try
            'Me.Text = "Reporte de Cuentas por Cobrar y Pagar Pendiente"
            CargarReporteRemoto("/Reportes/", "CON - Reporte CuentasCobrarPagarP")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarReporteRemoto(ByVal ubicacionReporte As String, ByVal nombreReporte As String)
        Try
            If IsNothing(cboCliente.Value) Then Throw New Exception("Seleccione Empresa")
            ValidarCombo(cboCuenta, "Cuenta")
            If cboMes.SelectedIndex = -1 Then Throw New Exception("Seleccione Mes")

            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote

            Dim olConfiguracion As New l_Configuracion
            ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://" & olConfiguracion.IPServidorReportes & "/ReportServer_SRVSQLISLPYO")
            'If Not myParams Is Nothing Then
            Dim myParams(5) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("TipoResumen", CStr(IIf(chkResumen.Checked, "SI", "NO")))
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", numAnho.Value.ToString)
            myParams(2) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Value.ToString)
            myParams(3) = New Microsoft.Reporting.WinForms.ReportParameter("IdClienteProveedor", cboCliente.Value.ToString)
            myParams(4) = New Microsoft.Reporting.WinForms.ReportParameter("IndCompraVenta", CStr(IIf(rbtCliProv.CheckedIndex = 0, "1CH000010", "1CH000011")))
            myParams(5) = New Microsoft.Reporting.WinForms.ReportParameter("IdCuentaContable", cboCuenta.Value.ToString)
            'End If
            ReportViewer1.ServerReport.ReportPath = ubicacionReporte + nombreReporte
            ReportViewer1.ServerReport.SetParameters(myParams)
            'ReportViewer1.ProcessingMode = ProcessingMode.Remote;
            'ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            ReportViewer1.ShowParameterPrompts = False
            ReportViewer1.ShowPromptAreaButton = False
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaCliente()
        Try
            Dim oeCliente As New e_Cliente
            Dim olCliente As New l_Cliente
            oeCliente.Id = ""
            oeCliente.Nombre = "TODOS"
            leCliente.Add(oeCliente)
            oeCliente = New e_Cliente
            oeCliente.Activo = True
            leCliente.AddRange(olCliente.Listar(oeCliente))
            With cboCliente
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leCliente
                .SelectedText = ""
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaProveedor()
        Try
            Dim oeProveedor As New e_Proveedor
            Dim olProveedor As New l_Proveedor
            oeProveedor.Id = ""
            oeProveedor.Nombre = "TODOS"
            leProveedor.Add(oeProveedor)
            oeProveedor = New e_Proveedor
            oeProveedor.Activo = True
            leProveedor.AddRange(olProveedor.Listar(oeProveedor))
            With cboCliente
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leProveedor
                .SelectedText = ""
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaCuenta()
        Try
            If rbtCliProv.CheckedIndex >= 0 Then
                Dim oeCta As New e_CuentaContable
                Dim leCta As New List(Of e_CuentaContable)
                Dim olCta As New l_CuentaContable
                oeCta.TipoOperacion = "N"
                oeCta.Activo = True
                oeCta.TipoCuentaCorriente = CStr(IIf(rbtCliProv.CheckedIndex = 0, "1CH000010", "1CH000011"))
                oeCta.Movimiento = 1
                oeCta.Ejercicio = numAnho.Value.ToString
                leCta.AddRange(olCta.Listar(oeCta))
                With cboCuenta
                    .ValueMember = "Id"
                    .DisplayMember = "Cuenta"
                    .DataSource = leCta
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ReporteCuentasxCyPxPeriodo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

    Private Sub cboClienteProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub cboCliente_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboCliente.InitializeLayout
        Me.cboCliente.ValueMember = "Id"
        Me.cboCliente.DisplayMember = "Nombre"
        With cboCliente.DisplayLayout.Bands(0)
            For x As Integer = 0 To cboCliente.DisplayLayout.Bands(0).Columns.Count - 1
                .Columns(x).Hidden = True
            Next
            .Columns("Nombre").Hidden = False
        End With
    End Sub

    Private Sub cboCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCliente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cboCliente.Text.Trim = "" Then
                    cboCliente.DataSource = Nothing
                    If rbtCliProv.CheckedIndex = 0 Then
                        cboCliente.DataSource = leCliente
                    Else
                        cboCliente.DataSource = leProveedor
                    End If
                Else
                    cboCliente.DataSource = Nothing
                    If rbtCliProv.CheckedIndex = 0 Then
                        Dim leClienteList2 As New List(Of e_Cliente)
                        leClienteList2 = leCliente
                        cboCliente.DataSource = leClienteList2.Where(Function(Item) Item.Nombre.Contains(cboCliente.Text.Trim)).ToList
                    Else
                        Dim leProveedorList2 As New List(Of e_Proveedor)
                        leProveedorList2 = leProveedor
                        cboCliente.DataSource = leProveedorList2.Where(Function(Item) Item.Nombre.Contains(cboCliente.Text.Trim)).ToList
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboCliente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub
   
    Private Sub frm_ReporteCuentasxCyPxPeriodo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_ReporteCuentasxCyPxPeriodo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            numAnho.Value = Date.Today.Year
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboCuenta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCuenta.ValueChanged
        If cboCuenta.SelectedIndex <> -1 Then
            Dim oecta As New e_CuentaContable
            oecta = cboCuenta.Items(cboCuenta.SelectedIndex).ListObject
            txtCuenta.Text = oecta.Nombre
        End If
    End Sub

    Private Sub rbtCliProv_Validated(sender As Object, e As EventArgs) Handles rbtCliProv.Validated
        Try
            If rbtCliProv.CheckedIndex = 0 Then
                LlenaCliente()
            Else
                LlenaProveedor()
            End If
            txtCuenta.Text = String.Empty
            CargaCuenta()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub numAnho_ValueChanged(sender As Object, e As EventArgs) Handles numAnho.ValueChanged
        Try
            cboCuenta.SelectedIndex = -1
            txtCuenta.Text = String.Empty
            CargaCuenta()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub rbtCliProv_ValueChanged(sender As Object, e As EventArgs) Handles rbtCliProv.ValueChanged
        cboCuenta.SelectedIndex = -1
        txtCuenta.Text = String.Empty
    End Sub
End Class
