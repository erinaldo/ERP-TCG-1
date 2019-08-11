Public Class frm_ReportPag
#Region "Instancia"
    Inherits ISL.Win.frm_MenuPadre
    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Shared instancia As frm_ReportPag = Nothing
    Private Shared Operacion As String
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReportPag
        End If
        instancia.Activate()
        Return instancia
    End Function
#End Region
    Private Sub frm_ReportPag_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub
    Sub Column(ByVal dt As DataTable)
        Try
            With dt.Columns
                dt.Columns.Add("Codigo", System.Type.GetType("System.String"))
                dt.Columns.Add("Tipo Obligacion", System.Type.GetType("System.String"))
                dt.Columns.Add("DeudaTotal", System.Type.GetType("System.Double"))
                dt.Columns.Add("Saldo", System.Type.GetType("System.Double"))
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
    Sub Column1(ByVal dt As DataTable)
        Try
            With dt.Columns
                dt.Columns.Add("Codigo", System.Type.GetType("System.String"))
                dt.Columns.Add("Tipo Obligacion", System.Type.GetType("System.String"))
                dt.Columns.Add("Saldo", System.Type.GetType("System.Double"))
                dt.Columns.Add("MontoPagar", System.Type.GetType("System.Double"))
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
    Sub CargaGrilla()
        Dim Dt As New DataTable
        Try
            Column(Dt)
            With Dt.Rows
                .Add("28655", "LEASING", 25000.0, 2500)
                .Add("65314547", "FACTORING IBK", 15900.0, 6000)
                .Add("D00001608463", "FEC", 32695.0, 1500)
                .Add("9600158908", "PRESTAMO", 59362.0, 1000)
            End With
            'Me.GrFec.DataSource = Dt
            'Me.GrFec.DataBind()
        Catch ex As Exception

        End Try
    End Sub
End Class