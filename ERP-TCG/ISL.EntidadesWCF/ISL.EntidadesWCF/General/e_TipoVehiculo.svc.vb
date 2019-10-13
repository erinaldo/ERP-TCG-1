''' <summary>
''' Clase Tipo Vehiculo
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_TipoVehiculo
    Implements Ie_TipoVehiculo

#Region "Declaracion de Variables"
    Private _Id As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Abreviatura As String
    Private _Motriz As Integer
    Private _Carga As Integer
    <DataMember()> _
    Public _IndicadorFuncional As Integer
    Private _Descripcion As String
    Private _Activo As Boolean
    Private _IdTipoVehiculoOrigen As String
    Private _IndTipoVehiculo As Integer
    Private _IndSunarp As Integer

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    Private _usuariocreacion As String

#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Id de Tipo Vehiculo
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
    ''' Codigo de Tipo Vehiculo
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
        End Set
    End Property

    ''' <summary>
    ''' Nombre de Tipo Vehiculo
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
        End Set
    End Property

    ''' <summary>
    ''' Abreviatura de Tipo Vehiculo
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
        End Set
    End Property

    <DataMember()> _
    Public Property Motriz() As Integer
        Get
            Return _Motriz
        End Get
        Set(ByVal value As Integer)
            _Motriz = value
        End Set
    End Property

    <DataMember()> _
    Public Property Carga() As Integer
        Get
            Return _Carga
        End Get
        Set(ByVal value As Integer)
            _Carga = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndicadorFuncional() As Integer
        Get
            Return _IndicadorFuncional
        End Get
        Set(ByVal value As Integer)
            _IndicadorFuncional = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    ''' <summary>
    ''' Activo de Tipo Vehiculo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoVehiculoOrigen() As String
        Get
            Return _IdTipoVehiculoOrigen
        End Get
        Set(ByVal value As String)
            _IdTipoVehiculoOrigen = value
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
    Public Property IndTipoVehiculo() As Integer
        Get
            Return _IndTipoVehiculo
        End Get
        Set(ByVal value As Integer)
            _IndTipoVehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndSunarp() As Integer
        Get
            Return _IndSunarp
        End Get
        Set(ByVal value As Integer)
            _IndSunarp = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal tipoVehiculo As e_TipoVehiculo) As e_TipoVehiculo Implements Ie_TipoVehiculo.Obtener
        Return tipoVehiculo
    End Function

#End Region

#Region "Constructor"
    Sub New()
        TipoOperacion = ""
        _Id = ""
        _Codigo = ""
        _Nombre = ""
        _Abreviatura = ""
        _Motriz = -1
        _Carga = -1
        _Activo = 1
        _IdTipoVehiculoOrigen = ""
        _IndicadorFuncional = -1
        _IndTipoVehiculo = -1
        _IndSunarp = -1
    End Sub

    Public Sub New(ByVal ls_Id As String, _
                   ByVal ls_Codigo As String, _
                   ByVal ls_Nombre As String, _
                   ByVal ls_Abreviatura As String, _
                   ByVal li_Motriz As Integer, _
                   ByVal li_Carga As Integer, _
                   ByVal li_IndicadorFuncional As Integer, _
                   ByVal ls_Descripcion As String, _
                   ByVal lb_Activo As Boolean, _
                   ByVal ls_IdTipoVehiculoOrigen As String, _
                   ByVal li_IndTipoVehiculo As Integer, _
                   ByVal li_IndSunarp As Integer)
        _Id = ls_Id
        _Codigo = ls_Codigo
        _Nombre = ls_Nombre
        _Abreviatura = ls_Abreviatura
        _Motriz = li_Motriz
        _Carga = li_Carga
        _IndicadorFuncional = li_IndicadorFuncional
        _Descripcion = ls_Descripcion
        _Activo = lb_Activo
        _IdTipoVehiculoOrigen = ls_IdTipoVehiculoOrigen
        _IndTipoVehiculo = li_IndTipoVehiculo
        _IndSunarp = li_IndSunarp
    End Sub

#End Region
End Class


