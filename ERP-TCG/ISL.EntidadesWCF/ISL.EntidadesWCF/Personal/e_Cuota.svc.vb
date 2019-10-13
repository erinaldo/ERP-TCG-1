

<DataContract()> _
Public Class e_Cuota
    Implements Ie_Cuota
    Implements ICloneable

#Region "Declaracion de Variables"
    Private _id As String
    Private _idTrabajador As String
    Private _codigo As String
    Private _NombreCompleto As String
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _cuota As Double

    <DataMember()> _
    Public Shadows TipoOperacion As String = ""
    <DataMember()> _
    Public Shadows Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _codigo = ""
        _idTrabajador = ""
        _NombreCompleto = ""
        _cuota = 0
        _fechainicio = #1/1/1901#
        _fechafin = #1/1/1901#
        _fechacreacion = #1/1/1901#
        _activo = True
        _usuariocreacion = ""
    End Sub

    Public Sub New(ByVal Id As String _
                   , ByVal IdTrabajador As String _
              , ByVal Codigo As String _
              , ByVal NombreCompleto As String _
              , ByVal Cuota As Double _
              , ByVal FechaInicio As Date _
              , ByVal FechaFin As Date _
              , ByVal Activo As Boolean _
              )
        _id = Id
        _idTrabajador = IdTrabajador
        _codigo = Codigo
        _NombreCompleto = NombreCompleto
        _cuota = Cuota
        _fechainicio = FechaInicio
        _fechafin = FechaFin
        _activo = Activo
    End Sub

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
    Public Property Cuota() As Double
        Get
            Return _cuota
        End Get
        Set(ByVal value As Double)
            _cuota = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreCompleto() As String
        Get
            Return _NombreCompleto
        End Get
        Set(ByVal value As String)
            _NombreCompleto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idTrabajador
        End Get
        Set(ByVal value As String)
            _idTrabajador = value
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _fechafin
        End Get
        Set(ByVal value As Date)
            _fechafin = value
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

#Region "Métodos"

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function

    ''' <summary>
    ''' Obtener una entidad de tipo e_Couta
    ''' </summary>
    ''' <param name="_couta"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal _couta As e_Cuota) As e_Cuota Implements Ie_Cuota.Obtener
        Return _couta
    End Function

#End Region

End Class



