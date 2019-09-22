<DataContract()> _
Public Class e_CentroCosto
    Implements Ie_CentroCosto
    Implements ICloneable

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _activo As Boolean
    Private _idarea As String
    Private _idvehiculo As String
    Private _idcentro As String
    Private _indactivofijo As Integer
    Private _inddiario As Integer
    Private _indcompra As Integer
    Private _indventa As Integer
    Private _vehiculo As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public ListUbicaciones As New List(Of e_CentroCostoUbicaciones)

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
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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
    Public Property IdArea() As String
        Get
            Return _idarea
        End Get
        Set(ByVal value As String)
            _idarea = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _idcentro
        End Get
        Set(ByVal value As String)
            _idcentro = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndActivoFijo() As Integer
        Get
            Return _indactivofijo
        End Get
        Set(ByVal value As Integer)
            _indactivofijo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndDiario() As Integer
        Get
            Return _inddiario
        End Get
        Set(ByVal value As Integer)
            _inddiario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCompra() As Integer
        Get
            Return _indcompra
        End Get
        Set(ByVal value As Integer)
            _indcompra = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndVenta() As Integer
        Get
            Return _indventa
        End Get
        Set(ByVal value As Integer)
            _indventa = value
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
    Public Property Vehiculo() As String
        Get
            Return _vehiculo
        End Get
        Set(ByVal value As String)
            _vehiculo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Id = ""
        IdArea = ""
        IdVehiculo = ""
        IdCentro = ""
        IndActivoFijo = 0
        IndDiario = 0
        IndCompra = 0
        IndVenta = 0
        Activo = 1
        Vehiculo = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_IdArea As String _
               , ByVal ls_IdVehiculo As String _
              , ByVal ls_IdCentro As String _
              , ByVal li_IndActivoFijo As Integer _
              , ByVal li_IndDiario As Integer _
              , ByVal li_IndCompra As Integer _
              , ByVal li_IndVenta As Integer _
              , ByVal ls_Vehiculo As String)
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _idarea = ls_IdArea
        _idvehiculo = ls_IdVehiculo
        _idcentro = ls_IdCentro
        _indactivofijo = li_IndActivoFijo
        _inddiario = li_IndDiario
        _indcompra = li_IndCompra
        _indventa = li_IndVenta
        _vehiculo = ls_Vehiculo
    End Sub

#End Region

#Region "Métodos"

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function

    Public Function Obtener(ByVal centroCosto As e_CentroCosto) As e_CentroCosto Implements Ie_CentroCosto.Obtener
        Return centroCosto
    End Function

#End Region

End Class
