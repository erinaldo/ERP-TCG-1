


<DataContract()> _
Public Class e_CajaTurno
    Implements Ie_CajaTurno

#Region "Propiedad"

    Private _id As String
    Private _idcajausuario As String
    Private _fechahoraingreso As Date
    Private _montoingreso As Double
    Private _fechahorasalida As Date
    Private _montosalida As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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
    Public Property IdCajaUsuario() As String
        Get
            Return _idcajausuario
        End Get
        Set(ByVal value As String)
            _idcajausuario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaHoraIngreso() As Date
        Get
            Return _fechahoraingreso
        End Get
        Set(ByVal value As Date)
            _fechahoraingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoIngreso() As Double
        Get
            Return _montoingreso
        End Get
        Set(ByVal value As Double)
            _montoingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaHoraSalida() As Date
        Get
            Return _fechahorasalida
        End Get
        Set(ByVal value As Date)
            _fechahorasalida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoSalida() As Double
        Get
            Return _montosalida
        End Get
        Set(ByVal value As Double)
            _montosalida = value
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
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCajaUsuario As String _
              , ByVal ld_FechaHoraIngreso As Date _
              , ByVal ln_MontoIngreso As Double _
              , ByVal ld_FechaHoraSalida As Date _
              , ByVal ln_MontoSalida As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idcajausuario = ls_IdCajaUsuario
        _fechahoraingreso = ld_FechaHoraIngreso
        _montoingreso = ln_MontoIngreso
        _fechahorasalida = ld_FechaHoraSalida
        _montosalida = ln_MontoSalida
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal cajaTurno As e_CajaTurno) As e_CajaTurno Implements Ie_CajaTurno.Obtener
        Return cajaTurno
    End Function

End Class
