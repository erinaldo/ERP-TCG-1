
<DataContract()> _
Public Class e_ControlUsuario
    Implements Ie_ControlUsuario

#Region "Declaracion de Variables"

    Private _id As String
    Private _idusuario As String
    Private _fechainicio As Date
    Private _fechasalida As Date
    Private _ampliacion As Integer
    Private _fechacreacion As Date
    Private _activo As Boolean
    Private _salida As Integer
    Private _nombrecompleto As String
    Private _area As String
    Private _ipv4 As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdArea As String = ""

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
    Public Property IdUsuario() As String
        Get
            Return _idusuario
        End Get
        Set(ByVal value As String)
            _idusuario = value
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
    Public Property FechaSalida() As Date
        Get
            Return _fechasalida
        End Get
        Set(ByVal value As Date)
            _fechasalida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ampliacion() As Integer
        Get
            Return _ampliacion
        End Get
        Set(ByVal value As Integer)
            _ampliacion = value
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Salida() As Integer
        Get
            Return _salida
        End Get
        Set(ByVal value As Integer)
            _salida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreCompleto() As String
        Get
            Return _nombrecompleto
        End Get
        Set(ByVal value As String)
            _nombrecompleto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
        End Set
    End Property

    <DataMember()> _
Public Property Ipv4() As String
        Get
            Return _ipv4
        End Get
        Set(ByVal value As String)
            _ipv4 = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _ampliacion = 0
        _salida = 0
        _activo = True
        _id = ""
        _fechainicio = #1/1/1901#
        _fechasalida = #1/1/1901#
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdUsuario As String _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaSalida As Date _
              , ByVal ln_Ampliacion As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Salida As Integer _
              , ByVal ls_NombreCompleto As String _
              , ByVal ls_Area As String _
              , ByVal ls_Ipv4 As String _
           )
        _id = ls_Id
        _idusuario = ls_IdUsuario
        _fechainicio = ld_FechaInicio
        _fechasalida = ld_FechaSalida
        _ampliacion = ln_Ampliacion
        _fechacreacion = ld_FechaCreacion
        _salida = lb_Salida
        _nombrecompleto = ls_NombreCompleto
        _area = ls_Area
        _ipv4 = ls_Ipv4
    End Sub

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ControlUsuario
    ''' </summary>
    ''' <param name="controlUsuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal controlUsuario As e_ControlUsuario) As e_ControlUsuario Implements Ie_ControlUsuario.Obtener
        Return controlUsuario
    End Function

#End Region

End Class
