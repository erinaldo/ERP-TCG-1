Public Class Mes

    ''' <summary>
    ''' Evento que controla el cambio de datos del mes
    ''' </summary>
    ''' <remarks></remarks>
    Public Event DatoCambiado()

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        numMes.Value = Date.Now.Month
        numMes.Refresh()

    End Sub

    ''' <summary>
    ''' Precisa el número de mes
    ''' </summary>
    ''' <remarks></remarks>
    Private _mes As Integer
    Public Property Mes() As Integer
        Get
            Return _mes
        End Get
        Set(ByVal value As Integer)
            _mes = value
            numMes.Value = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Sub numMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numMes.ValueChanged
        Mes = numMes.Value
    End Sub

    Private Sub Mes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Mes = Date.Now.Month
    End Sub

End Class
