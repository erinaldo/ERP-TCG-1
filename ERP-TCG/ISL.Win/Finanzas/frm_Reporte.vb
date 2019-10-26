'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Public Class frm_Reporte
#Region "Instancia"
    Inherits frm_MenuPadre
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_Reporte = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Reporte
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region
    Private Sub frm_Reporte_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub
    Private Sub frm_Reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaGrilla()
    End Sub

    Sub Column(ByVal dt As DataTable)
        Try
            With dt.Columns
                dt.Columns.Add("Codigo", System.Type.GetType("System.String"))
                dt.Columns.Add("Tipo Obligacion", System.Type.GetType("System.String"))
                dt.Columns.Add("Concepto", System.Type.GetType("System.String"))
                dt.Columns.Add("S/.", System.Type.GetType("System.Double"))
                dt.Columns.Add("$", System.Type.GetType("System.Double"))
                dt.Columns.Add("Estado", System.Type.GetType("System.String"))
                dt.Columns.Add("Fecha Vencimiento", System.Type.GetType("System.DateTime"))
                dt.Columns.Add("Cuota Total", System.Type.GetType("System.Int32"))
                dt.Columns.Add("Cuota Pagadas", System.Type.GetType("System.Int32"))
                dt.Columns.Add("Cuota Restantes", System.Type.GetType("System.Int32"))
                dt.Columns.Add("Periocidad", System.Type.GetType("System.String"))
                dt.Columns.Add("Observación", System.Type.GetType("System.String"))
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
                .Add("28655", "LEASING", "BCP LEASING nº 6 (5 TRACTOS Y 5 SEMIR)", 0, 15589.92, "C", "01/01/2012", 48, 14, 34, "TRACTOS B5X(-804) B5X(-802) B5W(-947) B5W(-901) 5W-900", "CARRETAS A8J(-984) A8J(-985) A8J(-987) A8J(-988)")
                .Add("65314547", "FACTORING IBK", "CEMENTOS PACASMAYO SAA", 202886.73, 0, "C", "01/01/2012", 0, 0, 0, "", "")
                .Add("D00001608463", "FEC", "G & N GRIFOS SA", 54335.47, 0, "C", "10/02/2012", 0, 0, 0, "", "")
                .Add("9600158908", "PRESTAMO", "PRESTAMO BBVA", 150000, 0, "", "14/02/2012", 0, 0, 0, "", "")


            End With
            Me.GrFec.DataSource = Dt
            Me.GrFec.DataBind()
        Catch ex As Exception

        End Try

    End Sub
End Class