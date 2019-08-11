Imports System.Drawing

<DataContract()> _
Public Class e_Icono
    Implements Ie_Icono
    Implements IEquatable(Of e_Icono)

#Region "Declaracion de Variables"

    Private _Nombre As String
    Private _Ruta As String
    Private _Icon As Bitmap

    Public TipoBusca As Integer

#End Region

#Region "Propiedades"

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Ruta() As String
        Get
            Return _Ruta
        End Get
        Set(value As String)
            _Ruta = value
        End Set
    End Property

    Public Property Icono() As Bitmap
        Get
            Return _Icon
        End Get
        Set(value As Bitmap)
            _Icon = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeIcon As e_Icono) As Boolean Implements System.IEquatable(Of e_Icono).Equals
        Select Case oeIcon.TipoBusca
            Case 1 : If Me.Nombre = oeIcon.Nombre Then Return True
        End Select
        Return False
    End Function

    Public Function Obtener(icono As e_Icono) As e_Icono Implements Ie_Icono.Obtener
        Return icono
    End Function

#End Region

End Class
