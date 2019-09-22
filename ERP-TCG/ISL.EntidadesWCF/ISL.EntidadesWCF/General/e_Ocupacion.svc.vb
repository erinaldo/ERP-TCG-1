''' <summary>
''' Clase para definir la entidad: Ocupacion
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Ocupacion
    Implements Ie_Ocupacion
    Implements IPropiedadesBasicas
    Implements IEquatable(Of e_Ocupacion)

#Region "Definicion de Variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _ocupacionsunat As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _idarea As String
    Private _area As String
    Private _idunidad As String
    Private _unidad As String
    Private _idgerencia As String
    Private _gerencia As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Propiedades"

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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property OcupacionSunat() As String
        Get
            Return _ocupacionsunat
        End Get
        Set(ByVal value As String)
            _ocupacionsunat = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
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
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idarea
        End Get
        Set(ByVal value As String)
            _idarea = value
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            '_area.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidad() As String
        Get
            Return _idunidad
        End Get
        Set(ByVal value As String)
            _idunidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Unidad() As String
        Get
            Return _unidad
        End Get
        Set(ByVal value As String)
            '_area.Nombre = value
        End Set
    End Property


    <DataMember()> _
    Public Property IdGerencia() As String
        Get
            Return _idgerencia
        End Get
        Set(ByVal value As String)
            _idgerencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Gerencia() As String
        Get
            Return _gerencia
        End Get
        Set(ByVal value As String)
            '_area.Nombre = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()

        _id = String.Empty
        _codigo = String.Empty
        _nombre = String.Empty
        _ocupacionsunat = String.Empty
        _activo = True
        _usuariocreacion = String.Empty

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_OcupacionSunat As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal IdArea As String _
              , ByVal Area As String _
           )

        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _ocupacionsunat = ls_OcupacionSunat
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _idarea = IdArea
        _area = Area

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Nombre As String _
              , ByVal IdArea As String _
              , ByVal Area As String _
              , ByVal IdUnidad As String _
              , ByVal Unidad As String _
              , ByVal IdGerencia As String _
              , ByVal Gerencia As String _
              , ByVal ls_OcupacionSunat As String _
              , ByVal ls_Codigo As String _
           )

        _id = ls_Id
        _nombre = ls_Nombre
        _ocupacionsunat = ls_OcupacionSunat
        _idarea = IdArea
        _area = Area
        _idunidad = IdUnidad
        _unidad = Unidad
        _idgerencia = IdGerencia
        _gerencia = Gerencia
        _codigo = ls_Codigo
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal ocupacion As e_Ocupacion) As e_Ocupacion Implements Ie_Ocupacion.Obtener
        Return ocupacion
    End Function

    Public Overloads Function Equals(ByVal oeOcu As e_Ocupacion) As Boolean Implements System.IEquatable(Of e_Ocupacion).Equals
        Select Case oeOcu.Equivale
            Case 1 : If Me.Id.Trim = oeOcu.Id.Trim Then Return True
            Case 2 : If Me.Nombre.Trim = oeOcu.Nombre.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class


