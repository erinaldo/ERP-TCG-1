

<DataContract()> _
Public Class e_TipoPago
    Implements Ie_TipoPago

#Region "Declaracion de Variables"

    Private _Id As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Abreviatura As String
    Private _Activo As Boolean
    Private _dias As Integer

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public IdClienteProveedor As String
    <DataMember()> _
    Public TipoClienteProveedor As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id de Tipo Pago
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    ''' <summary>
    ''' Codigo de Tipo Pago
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Nombre de Tipo Pago
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Abreviatura de Tipo Pago
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _Abreviatura
        End Get
        Set(ByVal value As String)
            _Abreviatura = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Dias() As Integer
        Get
            Return _dias
        End Get
        Set(ByVal value As Integer)
            _dias = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Activo de Tipo Pago
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _Id = ""
        _Codigo = ""
        _Nombre = ""
        _Abreviatura = ""
        _Activo = True
        _dias = 0
    End Sub

    Public Sub New(ByVal Id As String, ByVal Codigo As String, ByVal Nombre As String, _
                     ByVal Abreviatura As String, ByVal Activo As Boolean, ByVal Dias As Integer)
        _Id = Id
        _Codigo = Codigo
        _Abreviatura = Abreviatura
        _dias = Dias
        _Nombre = Nombre
        _Activo = Activo

    End Sub

#End Region

    Public Function Obtener(ByVal tipoPago As e_TipoPago) As e_TipoPago Implements Ie_TipoPago.Obtener
        Return tipoPago
    End Function

End Class


