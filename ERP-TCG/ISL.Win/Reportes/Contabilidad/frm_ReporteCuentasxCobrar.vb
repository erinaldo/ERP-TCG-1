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
Public Class frm_ReporteCuentasxCobrar
    Inherits frm_MenuPadre
    Private leCliente As New List(Of e_Cliente)
    Private Shared instancia As frm_ReporteCuentasxCobrar = Nothing
    Private Shared Operacion As String

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_ReporteCuentasxCobrar()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_ReporteCuentasxCobrar
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_ReporteCuentasxCobrar
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
        'MyBase.Exportar()
        Exportar_Excel(gridDocumentos)
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar()
        Try
            Dim olCtasxCobrar As New l_MovimientoDocumento
            Dim DatatableCtaXcobrar As New DataTable
            DatatableCtaXcobrar = olCtasxCobrar.ListarCtasXCobrar(cboCliente.Value, IIf(rbOpt.Checked, CDate(dtp_Hasta.Value), CDate("01/01/1901")))
            gridDocumentos.DataSource = DatatableCtaXcobrar
            For Each fila As UltraGridRow In gridDocumentos.Rows
                Select Case fila.Cells("Numero").Value
                    Case "SubTotal", "TOTALES"
                        fila.CellAppearance.BackColor = Me.Colores1.Color
                        fila.CellAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                End Select
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenaCliente()
        Try
            Dim oeCliente As New e_Cliente
            Dim olCliente As New l_Cliente
            oeCliente.Activo = True
            '   LlenarCombo(cboCliente, "Nombre", olCliente.Listar(oeCliente), 0)
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

    Private Sub frm_ReporteCuentasxCobrar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_ReporteControlCompra_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
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

    Private Sub cboCliente_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboCliente.InitializeLayout
        Me.cboCliente.ValueMember = "Id"
        Me.cboCliente.DisplayMember = "Nombre"
        With cboCliente.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            '.Columns("Email").Hidden = True
            '.Columns("Seleccion").Hidden = True
            '.Columns("Contacto").Hidden = True
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
            .Columns("Nombre").Width = 300
            .Columns("Dni").Width = 100
            .Columns("Dni").Header.Caption = "RUC/DNI"
        End With
    End Sub

    Private Sub cboCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCliente.KeyDown
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
    End Sub

    Private Sub cboCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboCliente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub frm_ReporteCuentasxCobrar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Colores1.Color = Color.SkyBlue
            LlenaCliente()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub gridDocumentos_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) _
    Handles gridDocumentos.AfterRowUpdate
        'Verificar que el monto a operar no sea mayor al saldo ni sea 0
        Try
            Dim obj As DataRowView
            obj = gridDocumentos.ActiveRow.ListObject
            If obj("Id") <> "" Then
                Dim oeDocumento As New e_MovimientoDocumento
                oeDocumento.Glosa = obj("GlosaCtaxCyP").ToString
                oeDocumento.Id = obj("Id")
                Dim olMovDoc As New l_MovimientoDocumento
                olMovDoc.CambiarGlosa(oeDocumento)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub


    Private Sub rbOpt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rbOpt.Checked = True Then
            gbFiltro.Enabled = True
            dtp_Hasta.Enabled = True
        Else
            gbFiltro.Enabled = False
            dtp_Hasta.Enabled = False
        End If
    End Sub
End Class