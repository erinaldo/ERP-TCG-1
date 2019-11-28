' Hola Maurixito

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_EstacionServicio
    Inherits frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#Region "Instancia"

    Private Shared instancia As frm_EstacionServicio = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_EstacionServicio()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private olEstacionServicio As l_EstacionServicio
    Private sw_Documento As String
    Private sw_TipoPago As String
    Private sw_Combustible As String

#End Region

#Region "Eventos"

    Private Sub frm_EstacionServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            olEstacionServicio = New l_EstacionServicio
            Me.UltraGrid1.DataSource = olEstacionServicio.mt_Listar(New e_EstacionServicio With {.TipoOperacion = "N"})
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_EstacionServicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_EstacionServicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub UltraButton10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDocumento_Click(sender As Object, e As EventArgs) Handles btnDocumento.Click

    End Sub

    Private Sub PaintBotones(Grupo As String)
        Select Case Grupo
            Case "TipoDocumento"
                btnDocumento.Appearance.BackColor = Color.White
                btnVale.Appearance.BackColor = Color.White
                btnVarios.Appearance.BackColor = Color.White
            Case "TipoPago"
                btnContado.Appearance.BackColor = Color.White
                btnCredito.Appearance.BackColor = Color.White
        End Select
    End Sub
#End Region

End Class