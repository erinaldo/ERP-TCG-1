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

Public Class frm_EstadoCuenta
    Inherits frm_MenuPadre

    Private Shared instancia As frm_EstadoCuenta = Nothing
    Private Shared Operacion As String

    Private leClienteProv As New List(Of e_Cliente)

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    'Private Shared instancia As frm_EstadoCuenta = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_EstadoCuenta()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_EstadoCuenta
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_EstadoCuenta
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

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Try
            Dim dt As New DataTable
            Dim olMovimientoDoc As New l_MovimientoDocumento
            dt = olMovimientoDoc.EstadoCuenta(cboCliente.Value, IIf(chkCliente.Checked, 1, 0))

            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

            Dim dtro() As DataRow = dt.Select(Nothing, "Vencido")
            Dim dt2 As DataTable = dtro.CopyToDataTable

            Dim oReport As New ReportDataSource("dsEstadoCuenta_dtEstadoCuenta", dt2)

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(oReport)

            ReportViewer1.LocalReport.Refresh()
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub LlenaCliente()
        Try

            Dim oeClienteProv As New e_Cliente
            Dim olClienteProv As New l_Cliente
            oeClienteProv.TipoOperacion = ""
            oeClienteProv.TipoClienteProveedor = -1
            oeClienteProv.Activo = True
            leClienteProv.AddRange(olClienteProv.Listar(oeClienteProv))

            With cboCliente
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leClienteProv
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_EstadoCuenta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_EstadoCuenta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region


    Private Sub cboCliente_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboCliente.InitializeLayout
        Me.cboCliente.ValueMember = "Id"
        Me.cboCliente.DisplayMember = "Nombre"
        With cboCliente.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("TipoPersonaEmpresa").Hidden = True
            .Columns("IdPersona").Hidden = True
            .Columns("IdEmpresa").Hidden = True
            .Columns("Comisionista").Hidden = True
            .Columns("FechaActividad").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("oeEmpresa").Hidden = True
            .Columns("oepersona").Hidden = True
        End With
    End Sub

    Private Sub cboCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCliente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cboCliente.Text.Trim = "" Then
                    cboCliente.DataSource = Nothing
                    cboCliente.DataSource = leClienteProv
                Else
                    cboCliente.DataSource = Nothing
                    Dim leClienteList2 As New List(Of e_Cliente)
                    leClienteList2 = leClienteProv
                    cboCliente.DataSource = leClienteList2.Where(Function(Item) Item.Nombre.Contains(cboCliente.Text.Trim)).ToList
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboCliente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub txtRuc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuc.ValueChanged
        If Not txtRuc.Value Is Nothing Then
            If txtRuc.Value.ToString.Trim.Length > 7 Then
                Dim leClienteList As New List(Of e_Cliente)
                leClienteList = leClienteProv.ToList
                leClienteList = leClienteProv.Where(Function(item) item.Dni.Contains(txtRuc.Value)).ToList
                cboCliente.DataSource = leClienteList
                If leClienteList.Count > 0 Then
                    cboCliente.Value = leClienteList(0).Id
                End If
            End If
        End If
    End Sub

    Private Sub frm_EstadoCuenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenaCliente()
        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class
