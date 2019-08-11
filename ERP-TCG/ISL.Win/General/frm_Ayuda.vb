Imports ISL.LogicaWCF
Public Class frm_Ayuda
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_Ayuda = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_Ayuda()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

    ''' <summary>
    ''' Método para salir o cerrar el formulario Banco
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Private Sub frm_Ayuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        SiteInicio()
    End Sub

    ''' <summary>
    ''' Carga el navegador con la página inicial del Site de Ayuda
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SiteInicio()
        Dim DireccionAyudaSGI As New Uri(SiteAyudaSGI)
        WebBrowser1.Url = DireccionAyudaSGI
    End Sub

    Private Sub frm_Ayuda_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta al cerrar el formulario 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_Ayuda_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

#End Region

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        SiteInicio()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        WebBrowser1.GoBack()
    End Sub

End Class
