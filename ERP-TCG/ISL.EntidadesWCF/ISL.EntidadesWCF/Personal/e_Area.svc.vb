<DataContract()> _
Public Class e_Area
    Implements Ie_Area
    Implements IEquatable(Of e_Area)

#Region "Declaracion de Variables"
    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _indsector As Integer
    Private _idsector As String
    Private _sector As String
    Private _isgerencia As Integer
    Private _idgerencia As String
    Private _gerencia As String
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _seleccion As Boolean
    Private _idareaog As String
    Private _areaog As String
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
    Public Property IndSector() As Integer
        Get
            Return _indsector
        End Get
        Set(ByVal value As Integer)
            _indsector = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSector() As String
        Get
            Return _idsector
        End Get
        Set(ByVal value As String)
            _idsector = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Sector() As String
        Get
            Return _sector
        End Get
        Set(ByVal value As String)
            _sector = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IsGerencia() As Integer
        Get
            Return _isgerencia
        End Get
        Set(ByVal value As Integer)
            _isgerencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdGerencia() As String
        Get
            Return _idgerencia
        End Get
        Set(ByVal value As String)
            _idgerencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Gerencia() As String
        Get
            Return _gerencia
        End Get
        Set(ByVal value As String)
            _gerencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdAreaOG() As String
        Get
            Return _idareaog
        End Get
        Set(ByVal value As String)
            _idareaog = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property AreaOG() As String
        Get
            Return _areaog
        End Get
        Set(ByVal value As String)
            _areaog = value
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
        _indsector = -1
        _idsector = String.Empty
        _sector = String.Empty
        _activo = True
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal ln_IndSector As Integer _
              , ByVal ls_IdSector As String _
              , ByVal ls_Sector As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _indsector = ln_IndSector
        _idsector = ls_IdSector
        _sector = ls_Sector
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Area
    ''' </summary>
    ''' <param name="area"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal area As e_Area) As e_Area Implements Ie_Area.Obtener
        Return area
    End Function

    Public Overloads Function Equals(ByVal oeAre As e_Area) As Boolean Implements System.IEquatable(Of e_Area).Equals
        Select Case oeAre.Equivale
            Case 1 : If Me.Id.Trim = oeAre.Id.Trim Then Return True
            Case 2 : If Me.Nombre.Trim = oeAre.Nombre.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class


