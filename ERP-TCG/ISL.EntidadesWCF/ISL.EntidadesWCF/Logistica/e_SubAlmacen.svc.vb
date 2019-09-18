<DataContract()> _
Public Class e_SubAlmacen
    Implements Ie_SubAlmacen
    Implements IEquatable(Of e_SubAlmacen)


#Region "Declaración de Variables"

    Private _seleccion As Boolean
    Private _id As String
    Private _codigo As String
    Private _idalmacen As String
    Private _almacen As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _idequipo As String
    Private _idGrifo As String
    Private _IdDireccionGrifo As String
    Private _indprincipal As Boolean

    <DataMember()> _
    Public IdArea As String
    <DataMember()> _
    Public IdTrabajador As String
    <DataMember()> _
    Public TipoReferencia As String
    <DataMember()> _
    Public IdOrdenAsignacion As String
    <DataMember()> _
    Public Equivale As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Private _descripcion As String
    Private _referencia As String
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Propiedades"

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
    Public Property IdAlmacen() As String
        Get
            Return _idalmacen
        End Get
        Set(ByVal value As String)
            _idalmacen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Almacen() As String
        Get
            Return _almacen
        End Get
        Set(ByVal value As String)
            _almacen = value
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

    <DataMember()> _
    Public Property IdEquipo() As String
        Get
            Return _idequipo
        End Get
        Set(ByVal value As String)
            _idequipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndPrincipal() As Boolean
        Get
            Return _indprincipal
        End Get
        Set(ByVal value As Boolean)
            _indprincipal = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Referencia() As String
        Get
            Return _referencia
        End Get
        Set(ByVal value As String)
            _referencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdGrifo() As String
        Get
            Return _idGrifo
        End Get
        Set(ByVal value As String)
            _idGrifo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDireccion() As String
        Get
            Return _IdDireccionGrifo
        End Get
        Set(ByVal value As String)
            _IdDireccionGrifo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        IdAlmacen = ""
        Activo = True
        IndPrincipal = False
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdAlmacen As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_IdEquipo As String _
              , ByVal ls_IdGrifo As String _
              , ByVal ls_IdDireccion As String _
              , ByVal lb_IndPrincipal As Boolean _
              , ByVal ls_Referencia As String _
              , ByVal ls_Descripcion As String)
        _id = ls_Id
        _codigo = ls_Codigo
        _idalmacen = ls_IdAlmacen
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _idequipo = ls_IdEquipo
        _idGrifo = ls_IdGrifo
        _IdDireccionGrifo = ls_IdDireccion
        _indprincipal = lb_IndPrincipal
        _referencia = ls_Referencia
        _descripcion = ls_Descripcion
        '_idempresapropietaria.Id = ls_IdEmpresaPropietaria
        TipoOperacion = ""
    End Sub

    Public Sub New( _
                 ByVal ls_Id As String _
              , ByVal Seleccion As Boolean _
              , ByVal ls_Codigo As String _
              , ByVal ls_Descripcion As String _
              , ByVal ls_Referencia As String _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _descripcion = ls_Descripcion
        _seleccion = Seleccion
        _referencia = ls_Referencia
        TipoOperacion = ""
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal subAlmacen As e_SubAlmacen) As e_SubAlmacen Implements Ie_SubAlmacen.Obtener
        Return subAlmacen
    End Function

    Public Overloads Function Equals(ByVal oeSubAlm As e_SubAlmacen) As Boolean Implements System.IEquatable(Of e_SubAlmacen).Equals
        Select Case oeSubAlm.Equivale
            Case 1 : If Me.Id = oeSubAlm.Id Then Return True
            Case 2 : If Me.IdGrifo = oeSubAlm.IdGrifo And Me.IdDireccion = oeSubAlm.IdDireccion Then Return True
        End Select
        Return False
    End Function

#End Region


End Class
