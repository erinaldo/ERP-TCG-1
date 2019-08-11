Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ReportePLE
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReportePLE = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReportePLE()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Eventos"

    Private Sub frm_ReportePLE_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReportePLE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

#End Region

#Region "Procedimientos"

    Private Sub Inicializar()

    End Sub

#End Region

End Class