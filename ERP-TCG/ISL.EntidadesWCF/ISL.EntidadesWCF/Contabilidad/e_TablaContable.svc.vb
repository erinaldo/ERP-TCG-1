<ServiceBehavior(InstanceContextMode:=InstanceContextMode.PerSession)> _
<DataContract()> _
Public Class e_TablaContable
    Implements Ie_TablaContable

#Region "Propiedad"

    Private _id As String
    Private _nombre As String
    Private _texto1 As String
    Private _texto2 As String
    Private _texto3 As String
    Private _valor1 As String
    Private _valor2 As String
    Private _valor3 As String
    Private _logico1 As String
    Private _logico2 As String
    Private _logico3 As String
    Private _activo As Boolean

    Public Tipooperacion As String
    Public Modificado As Boolean

    Public Event DatoCambiado()

    <DataMember()> _
    Public lstTablaCtbleDet As New List(Of e_TablaContableDet)

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Texto1() As String
        Get
            Return _texto1
        End Get
        Set(ByVal value As String)
            _texto1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Texto2() As String
        Get
            Return _texto2
        End Get
        Set(ByVal value As String)
            _texto2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Texto3() As String
        Get
            Return _texto3
        End Get
        Set(ByVal value As String)
            _texto3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Valor1() As String
        Get
            Return _valor1
        End Get
        Set(ByVal value As String)
            _valor1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Valor2() As String
        Get
            Return _valor2
        End Get
        Set(ByVal value As String)
            _valor2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Valor3() As String
        Get
            Return _valor3
        End Get
        Set(ByVal value As String)
            _valor3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Logico1() As String
        Get
            Return _logico1
        End Get
        Set(ByVal value As String)
            _logico1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Logico2() As String
        Get
            Return _logico2
        End Get
        Set(ByVal value As String)
            _logico2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Logico3() As String
        Get
            Return _logico3
        End Get
        Set(ByVal value As String)
            _logico3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Texto1 As String _
              , ByVal ls_Texto2 As String _
              , ByVal ls_Texto3 As String _
              , ByVal ls_Valor1 As String _
              , ByVal ls_Valor2 As String _
              , ByVal ls_Valor3 As String _
              , ByVal ls_Logico1 As String _
              , ByVal ls_Logico2 As String _
              , ByVal ls_Logico3 As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _nombre = ls_Nombre
        _texto1 = ls_Texto1
        _texto2 = ls_Texto2
        _texto3 = ls_Texto3
        _valor1 = ls_Valor1
        _valor2 = ls_Valor2
        _valor3 = ls_Valor3
        _logico1 = ls_Logico1
        _logico2 = ls_Logico2
        _logico3 = ls_Logico3
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal tablaContable As e_TablaContable) As e_TablaContable Implements Ie_TablaContable.Obtener
        Return tablaContable
    End Function

End Class
