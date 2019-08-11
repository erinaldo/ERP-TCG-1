Public Class TrabajadorDisponible

    Private Sub TrabajadorDisponible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstadoTrabajador()
    End Sub

    ''' <summary>
    ''' Actualizar la forma como se muestra la disponibilidad del trabajador 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EstadoTrabajador()
        If Me.Disponible Then
            lblDisponible.Text = "Trabajador Disponible"
            lblDisponible.BackColor = Color.GreenYellow
            lblDisponible.ForeColor = Color.Black
        Else
            lblDisponible.Text = "Trabajador NO Disponible"
            lblDisponible.BackColor = Color.Red
            lblDisponible.ForeColor = Color.Yellow
        End If
    End Sub

    ''' <summary>
    ''' Propiedad para almacenar el estado de disponibilidad del trabajador
    ''' </summary>
    ''' <remarks></remarks>
    Private _disponible As Boolean = True
    Public Property Disponible() As Boolean
        Get
            Return _disponible
        End Get
        Set(ByVal value As Boolean)
            _disponible = value
            EstadoTrabajador()
        End Set
    End Property

End Class
