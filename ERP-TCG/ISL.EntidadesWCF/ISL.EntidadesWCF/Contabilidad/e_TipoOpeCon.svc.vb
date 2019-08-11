' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_TipoOpeCon" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_TipoOpeCon.svc o e_TipoOpeCon.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_TipoOpeCon
    Implements Ie_TipoOpeCon
    Implements IEquatable(Of e_TipoOpeCon)

#Region "Declaración de variables"

    Private _Id As String
    Private _Codigo As String
    Private _Nombre As String
    Public TipoOperacion As String

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _Codigo = ""
        _Nombre = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
           )
        _Id = ls_Id
        _Codigo = ls_Codigo
        _Nombre = ls_Nombre
    End Sub

#End Region

#Region "Propiedades"

    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal tipoopecon As e_TipoOpeCon) As e_TipoOpeCon Implements Ie_TipoOpeCon.Obtener
        Return tipoopecon
    End Function

    Public Function Equals1(other As e_TipoOpeCon) As Boolean Implements IEquatable(Of e_TipoOpeCon).Equals
        If Me.Id.Trim = other.Id.Trim Then Return True
        Return False
    End Function

#End Region

End Class
