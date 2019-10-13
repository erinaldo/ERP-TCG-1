


<DataContract()> _
Public Class e_MontoCaja
    Implements Ie_MontoCaja

#Region "Declaracion de Variables"

    Private _id As String
    Private _idcaja As String
    Private _monto As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _caja As String
    Private _nombrecompleto As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property IdCaja() As String
        Get
            Return _idcaja
        End Get
        Set(ByVal value As String)
            _idcaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Caja() As String
        Get
            Return _caja
        End Get
        Set(ByVal value As String)
            _caja = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
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
    Public Property NombreCompleto() As String
        Get
            Return _nombrecompleto
        End Get
        Set(ByVal value As String)
            _nombrecompleto = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _idcaja = ""
        _monto = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _activo = True
        _caja = ""
        _nombrecompleto = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCaja As String _
              , ByVal ls_Caja As String _
              , ByVal ln_Monto As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_NombreCompleto As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idcaja = ls_IdCaja
        _caja = ls_Caja
        _monto = ln_Monto
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _nombrecompleto = ls_NombreCompleto
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal montoCaja As e_MontoCaja) As e_MontoCaja Implements Ie_MontoCaja.Obtener
        Return montoCaja
    End Function

End Class

