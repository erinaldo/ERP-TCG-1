''' <summary>
''' Clase de la librería neumáticos para definir el motivo de la operación que se realiza con la llanta
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Motivo
    Implements Ie_Motivo

#Region "Propiedad"

    Private _id As String
    Private _nombre As String
    Private _codigo As String
    Private _indalmacen As Boolean
    Private _indreencauche As Boolean
    Private _indreparar As Boolean
    Private _indbaja As Boolean
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndAlmacen() As Boolean
        Get
            Return _indalmacen
        End Get
        Set(ByVal value As Boolean)
            _indalmacen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndReencauche() As Boolean
        Get
            Return _indreencauche
        End Get
        Set(ByVal value As Boolean)
            _indreencauche = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndReparacion() As Boolean
        Get
            Return _indreparar
        End Get
        Set(ByVal value As Boolean)
            _indreparar = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndBaja() As Boolean
        Get
            Return _indbaja
        End Get
        Set(ByVal value As Boolean)
            _indbaja = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Codigo As String _
              , ByVal lb_IndAlmacen As Boolean _
              , ByVal lb_IndReencauche As Boolean _
              , ByVal lb_IndReparar As Boolean _
              , ByVal lb_IndBaja As Boolean _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _nombre = ls_Nombre
        _indalmacen = lb_IndAlmacen
        _indreencauche = lb_IndReencauche
        _indreparar = lb_IndReparar
        _indbaja = lb_IndBaja
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _codigo = ls_Codigo
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Motivo
    ''' </summary>
    ''' <param name="motivo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal motivo As e_Motivo) As e_Motivo Implements Ie_Motivo.Obtener
        Return motivo
    End Function

#End Region

End Class
