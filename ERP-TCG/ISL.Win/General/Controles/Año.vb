Public Class Año

    ''' <summary>
    ''' Evento que controla el cambio de información del año
    ''' </summary>
    ''' <remarks></remarks>
    Public Event DatoCambiado()

    Private _año As Integer
    Public Property Año() As Integer
        Get
            Return _año
        End Get
        Set(ByVal value As Integer)
            _año = value
            numAño.Value = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        numAño.Value = Year(Date.Now)
        numAño.Refresh()

    End Sub

    Public Sub numAño_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numAño.ValueChanged
        Año = numAño.Value
    End Sub

    Private Sub Año_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Año = Date.Now.Year
    End Sub
End Class
