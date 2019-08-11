<DataContract()> _
Public Class e_Gerencia
    Implements Ie_Gerencia
    Implements IEquatable(Of e_Gerencia)

#Region "Declaracion de Variables"
    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _seleccion As Boolean
    Private _Activo As Boolean
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer

    Public Event DatoCambiado()

#End Region

#Region "Propiedad"

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
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
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
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

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _codigo = String.Empty
        _nombre = String.Empty
        _abreviatura = String.Empty
        _activo = True
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _Activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_AreaAO
    ''' </summary>
    ''' <param name="area"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal area As e_Gerencia) As e_Gerencia Implements Ie_Gerencia.Obtener
        Return area
    End Function

    Public Overloads Function Equals(ByVal oeGer As e_Gerencia) As Boolean Implements System.IEquatable(Of e_Gerencia).Equals
        Select Case oeGer.Equivale
            Case 1 : If Me.Id.Trim = oeGer.Id.Trim Then Return True
            Case 2 : If Me.Nombre.Trim = oeGer.Nombre.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class


