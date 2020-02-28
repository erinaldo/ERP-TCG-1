Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_Reporte_RIC
    Inherits frm_MenuPadre

    Dim wr_Reporte As New l_Reporte, Reporte As New e_ReporteFiltro
    Dim DT As New DataTable

#Region "Inicializacion del Formulario"

    Public Overrides Sub Exportar()
        Try
            Exportar_Excel(udg_CuadroRIC)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        MyBase.Exportar()

    End Sub

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Reporte_RIC = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_Reporte_RIC()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    Private Sub frm_Reporte_RIC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mt_CargarCombo_Combustible()

    End Sub

    Private Sub mt_CargarCombo_Combustible()
        Dim ListaCombustible As New List(Of e_Material)
        Dim olMaterial As New l_Material, loMaterial = olMaterial.Listar(New e_Material With {.TipoOperacion = "S", .Activo = True})

        For Each Combustible In loMaterial
                    Select Case Combustible.Id
                Case "1CH000001990" : ListaCombustible.Add(Combustible)
                Case "1CH000000147" : ListaCombustible.Add(Combustible)
                Case "1CH000000148" : ListaCombustible.Add(Combustible)
                Case "1CH000000149" : ListaCombustible.Add(Combustible)
            End Select
                Next

        gmt_ComboEspecifico(cboProducto, ListaCombustible, 0, "Nombre")
    End Sub

    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar_RIC.Click
        Try
            Reporte.ProcedimientoAlmacenado = "STD.RPT_RIC"
            Reporte.TipoConsulta = "RIC"
            Reporte.FechaInicial = dtp_FechaInicial_RIC.Value.Date
            Reporte.FechaFinal = dtp_FechaFin_RIC.Value.Date
            Reporte.Filtro1 = cboProducto.Value
            DT = wr_Reporte.Consultar(Reporte)
            udg_CuadroRIC.DataSource = DT
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs)
        Exportar_Excel(udg_CuadroRIC)
    End Sub

    Private Sub frm_Reporte_RIC_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        gmt_ControlBoton(0, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub
End Class