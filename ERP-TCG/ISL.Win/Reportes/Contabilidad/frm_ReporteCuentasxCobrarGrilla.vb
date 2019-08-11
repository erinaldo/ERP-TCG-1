Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ReporteCuentasxCobrarGrilla
    Inherits ISL.Win.frm_MenuPadre
    Private leCliente As New List(Of e_Cliente)
    Private olCuentaXC As New l_CuentaxCyP
    Private oeDocumento As New e_MovimientoDocumento
    Private Shared instancia As frm_ReporteCuentasxCobrarGrilla = Nothing
    Private Shared Operacion As String

#Region "Inicialización del formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReporteCuentasxCobrarGrilla()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            Exportar_Excel(grid2BalanceComprobacion)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Listar()
        Try
            Dim ds As DataSet = olCuentaXC.ReporteCuentasXC(cboCliente.Value)
            grid2BalanceComprobacion.DataSource = ds
            With grid2BalanceComprobacion.DisplayLayout
                .Bands(1).ColHeadersVisible = False
                .Bands(1).Columns("Ejercicio").Hidden = True
                .Bands(1).Columns("Id").Hidden = True
                .Bands(1).Columns("CtaCte").Hidden = True
                .Bands(1).Columns("Dni").Width = 288
                .Bands(1).Columns("FechaEmision").Width = 70
                .Bands(1).Columns("FechaVencimiento").Width = 70
                .Bands(1).Columns("Vencido").Width = 34
                .Bands(1).Columns("tipoDoc").Width = 29
                .Bands(1).Columns("Serie").Width = 35
                .Bands(1).Columns("Numero").Width = 71
                .Bands(1).Columns("GlosaCtaxCyP").Width = 161
                .Bands(1).Columns("FACT_S").Width = 80
                .Bands(1).Columns("FACT_D").Width = 80
                .Bands(1).Columns("Detraccion").Width = 60
                .Bands(1).Columns("Neto").Width = 80
                .Bands(1).Columns("SALDO_S").Width = 80
                .Bands(1).Columns("SALDO_D").Width = 80
                .Bands(1).Columns("SALDO_AL_TCV").Width = 80

                .Bands(1).Columns("FACT_S").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("FACT_S").Format = "#,##0.00"
                .Bands(1).Columns("FACT_S").Style = ColumnStyle.Double
                .Bands(1).Columns("FACT_D").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("FACT_D").Format = "#,##0.00"
                .Bands(1).Columns("FACT_D").Style = ColumnStyle.Double
                .Bands(1).Columns("Detraccion").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("Detraccion").Format = "#,##0.00"
                .Bands(1).Columns("Detraccion").Style = ColumnStyle.Double
                .Bands(1).Columns("Neto").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("Neto").Format = "#,##0.00"
                .Bands(1).Columns("Neto").Style = ColumnStyle.Double
                .Bands(1).Columns("SALDO_S").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("SALDO_S").Format = "#,##0.00"
                .Bands(1).Columns("SALDO_S").Style = ColumnStyle.Double
                .Bands(1).Columns("SALDO_D").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("SALDO_D").Format = "#,##0.00"
                .Bands(1).Columns("SALDO_D").Style = ColumnStyle.Double
                .Bands(1).Columns("SALDO_AL_TCV").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("SALDO_AL_TCV").Format = "#,##0.00"
                .Bands(1).Columns("SALDO_AL_TCV").Style = ColumnStyle.Double
           
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenaCliente()
        Try
            Dim oeCliente As New e_Cliente
            Dim olCliente As New l_Cliente
            oeCliente.Activo = True
            leCliente.AddRange(olCliente.Listar(oeCliente))
            With cboCliente
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leCliente
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteCuentasxCobrarGrilla_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_ReporteCuentasxCobrarGrilla_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteCuentasxCobrarGrilla_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ReporteCuentasxCobrarGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LlenaCliente()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboCliente_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboCliente.InitializeLayout
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
                    cboCliente.DataSource = leCliente
                Else
                    cboCliente.DataSource = Nothing
                    Dim leClienteList2 As New List(Of e_Cliente)
                    leClienteList2 = leCliente
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
                leClienteList = leCliente.ToList
                leClienteList = leCliente.Where(Function(item) item.Dni.Contains(txtRuc.Value)).ToList
                cboCliente.DataSource = leClienteList
                If leClienteList.Count > 0 Then
                    cboCliente.Value = leClienteList(0).Id
                End If
            End If
        End If
    End Sub

    Private Sub gridComprobanteVenta_AfterRowUpdate(ByVal sender As Object, _
    ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles grid2BalanceComprobacion.AfterRowUpdate
        'Verificar que el monto a operar no sea mayor al saldo ni sea 0
        Try
            Dim obj As DataRowView
            obj = grid2BalanceComprobacion.ActiveRow.ListObject
            If obj("Id") <> "" Then
                oeDocumento = New e_MovimientoDocumento
                oeDocumento.Glosa = obj("GlosaCtaxCyP")
                oeDocumento.Id = obj("Id")
                Dim olMovDoc As New l_MovimientoDocumento
                olMovDoc.CambiarGlosa(oeDocumento)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

End Class
