''' <summary>
''' Clase para gestionar la información de la entidad Centro (sede de la empresa)
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Centro
    Implements Ie_Centro
    Implements IPropiedadesBasicas
    Implements IEquatable(Of e_Centro)

#Region "Declaración de variables"
    Private _id As String
    Private _codigo As String
    Private _idempresa As String
    Private _idlugar As String
    Private _nombre As String
    Private _abreviatura As String
    Private _principal As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _IdAlmacen As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer

#End Region

#Region "Propiedades"
    <DataMember()> _
    Public Property IdAlmacen() As String
        Get
            Return _IdAlmacen
        End Get
        Set(ByVal value As String)
            _IdAlmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresa() As String
        Get
            Return _idempresa
        End Get
        Set(ByVal value As String)
            _idempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdLugar() As String
        Get
            Return _idlugar
        End Get
        Set(ByVal value As String)
            _idlugar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
        End Set
    End Property

    <DataMember()> _
    Public Property Principal() As Boolean
        Get
            Return _principal
        End Get
        Set(ByVal value As Boolean)
            _principal = value
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

    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
        IdAlmacen = ""
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdEmpresa As String _
              , ByVal ls_IdLugar As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal lb_Principal As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _idempresa = ls_IdEmpresa
        _idlugar = ls_IdLugar
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _principal = lb_Principal
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub
#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Centro
    ''' </summary>
    ''' <param name="centro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal centro As e_Centro) As e_Centro Implements Ie_Centro.Obtener
        Return centro
    End Function

    Public Overloads Function Equals(ByVal oeCent As e_Centro) As Boolean Implements System.IEquatable(Of e_Centro).Equals
        Select Case oeCent.Equivale
            Case 1 : If Me.Id.Trim = oeCent.Id.Trim Then Return True
            Case 2 : If Me.Nombre.Trim = oeCent.Nombre.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class

