' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_TipoBien" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_TipoBien.svc o e_TipoBien.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_TipoBien
    Implements Ie_TipoBien
    Implements IEquatable(Of e_TipoBien)



#Region "Declaración de variables"

    Private _Id As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Porcentaje As Double
    Private _Activo As Boolean
    Public TipoOperacion As String

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _Codigo = ""
        _Nombre = ""
        _Porcentaje = 0
        _Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ln_Porcentaje As Double _
              , ByVal lb_Activo As Boolean _
           )
        _Id = ls_Id
        _Codigo = ls_Codigo
        _Nombre = ls_Nombre
        _Porcentaje = ln_Porcentaje
        _Activo = lb_Activo
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

    Public Property Porcentaje() As Double
        Get
            Return _Porcentaje
        End Get
        Set(ByVal value As Double)
            _Porcentaje = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal tipobien As e_TipoBien) As e_TipoBien Implements Ie_TipoBien.Obtener
        Return tipobien
    End Function

    Public Function Equals1(other As e_TipoBien) As Boolean Implements IEquatable(Of e_TipoBien).Equals
        If Me.Id.Trim = other.Id.Trim Then Return True
        Return False
    End Function

#End Region

End Class
