

<DataContract()> _
Public Class e_LetraCambio
    Implements Ie_LetraCambio

#Region "Propiedad"

    Private _id As String
    Private _nroletra As String
    Private _idprovedor As String
    Private _fechaemision As Date
    Private _fechavencimiento As Date
    Private _idmoneda As String
    Private _monto As Double
    Private _tipocambio As Double
    Private _glosa As String
    Private _idestado As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _nroletraorigen As String
    Private _idperiodo As String
    Private _idcuentacontable As String
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
    Public Property NroLetra() As String
        Get
            Return _nroletra
        End Get
        Set(ByVal value As String)
            _nroletra = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdProvedor() As String
        Get
            Return _idprovedor
        End Get
        Set(ByVal value As String)
            _idprovedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEmision() As Date
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Date)
            _fechaemision = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
            RaiseEvent DatoCambiado()
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
    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
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
    Public Property NroLetraOrigen() As String
        Get
            Return _nroletraorigen
        End Get
        Set(ByVal value As String)
            _nroletraorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPeriodo() As String
        Get
            Return _idperiodo
        End Get
        Set(ByVal value As String)
            _idperiodo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContable() As String
        Get
            Return _idcuentacontable
        End Get
        Set(ByVal value As String)
            _idcuentacontable = value
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
              , ByVal ls_NroLetra As String _
              , ByVal ls_IdProvedor As String _
              , ByVal ld_FechaEmision As Date _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_Monto As Double _
              , ByVal ln_TipoCambio As Double _
              , ByVal ls_Glosa As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_NroLetraOrigen As String _
              , ByVal ls_IdPeriodo As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _nroletra = ls_NroLetra
        _idprovedor = ls_IdProvedor
        _fechaemision = ld_FechaEmision
        _fechavencimiento = ld_FechaVencimiento
        _idmoneda = ls_IdMoneda
        _monto = ln_Monto
        _tipocambio = ln_TipoCambio
        _glosa = ls_Glosa
        _idestado = ls_IdEstado
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _nroletraorigen = ls_NroLetraOrigen
        _idperiodo = ls_IdPeriodo
        _idcuentacontable = ls_IdCuentaContable
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal letraCambio As e_LetraCambio) As e_LetraCambio Implements Ie_LetraCambio.Obtener
        Return letraCambio
    End Function

End Class


