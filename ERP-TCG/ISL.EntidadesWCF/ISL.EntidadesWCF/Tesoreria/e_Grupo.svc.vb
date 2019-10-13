


<DataContract()> _
Public Class e_Grupo
    Implements Ie_Grupo

#Region "Declaración de variables"

    Private _id As String
    Private _codigo As String
    Private _tipo As String
    Private _fecha As Date
    Private _fechaenvio As Date
    Private _glosaenvio As String
    Private _importetotal As Double
    Private _caja As New e_Caja
    Private _saldo As Double
    Private _importepagar As Double
    Private _fechareembolso As Date
    Private _idestado As String
    Private _estado As String
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _idcentro As String
    Private _centro As String
    Private _usuariocreacion As String
    Private _idcuentacorrienteadm As String
    Private _nrocheque As String
    Private _seleccion As Boolean
    Private _periodo As New e_Periodo
    
    <DataMember()> _
    Public loDetalleGrupo As New List(Of e_GrupoDetalle)
    <DataMember()> _
    Public loMovimiento As New List(Of e_Movimiento)

    <DataMember()> _
    Public IdChequexCobrar As String
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    '<DataMember()> _
    'Public idCtaCte As String
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

    Public lsGruposDescuentos As String

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
    Public Property NroCheque() As String
        Get
            Return _nrocheque
        End Get
        Set(ByVal value As String)
            _nrocheque = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCaja() As String
        Get
            Return _caja.Id
        End Get
        Set(ByVal value As String)
            _caja.Id = value
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
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEnvio() As Date
        Get
            Return _fechaenvio
        End Get
        Set(ByVal value As Date)
            _fechaenvio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property GlosaEnvio() As String
        Get
            Return _glosaenvio
        End Get
        Set(ByVal value As String)
            _glosaenvio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaCorriente() As String
        Get
            Return _idcuentacorrienteadm
        End Get
        Set(ByVal value As String)
            _idcuentacorrienteadm = value
        End Set
    End Property

    <DataMember()> _
    Public Property ImporteTotal() As Double
        Get
            Return _importetotal
        End Get
        Set(ByVal value As Double)
            _importetotal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo()
        Get
            Return _saldo
        End Get
        Set(ByVal value)
            _saldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property ImportePagar() As Double
        Get
            Return _importepagar
        End Get
        Set(ByVal value As Double)
            _importepagar = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaReembolso() As Date
        Get
            Return _fechareembolso
        End Get
        Set(ByVal value As Date)
            _fechareembolso = value
            RaiseEvent DatoCambiado()
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
    Public Property Centro() As String
        Get
            Return _centro
        End Get
        Set(ByVal value As String)
            _centro = value
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
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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
    Public Property IdPeriodo() As String
        Get
            Return _periodo.Id
        End Get
        Set(ByVal value As String)
            _periodo.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Periodo() As String
        Get
            Return _periodo.Codigo
        End Get
        Set(ByVal value As String)
            _periodo.Codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        _saldo = 0
        _id = ""
        _codigo = ""
        _importetotal = 0
        IdEstado = ""
        _fecha = Date.Now
        _fechaenvio = Date.Now
        _fechareembolso = Date.Now
        _activo = True
        _caja.Id = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Tipo As String _
              , ByVal ld_Fecha As Date _
              , ByVal ld_FechaEnvio As Date _
              , ByVal ls_GlosaEnvio As String _
              , ByVal ln_ImporteTotal As Double _
              , ByVal ln_Saldo As Double _
              , ByVal ld_FechaReembolso As Date _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_IdCentro As String _
              , ByVal ls_Centro As String _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ls_NroCheque As String _
              , ByVal lb_Seleccion As Boolean _
              , ByVal ls_IdPeriodo As String _
              , ByVal ls_Periodo As String _
              , ByVal ls_IdCaja As String)
        _id = ls_Id
        _codigo = ls_Codigo
        _tipo = ls_Tipo
        _fecha = ld_Fecha
        _fechaenvio = ld_FechaEnvio
        _glosaenvio = ls_GlosaEnvio
        _importetotal = ln_ImporteTotal
        _saldo = ln_Saldo
        _importepagar = ln_Saldo
        _fechareembolso = ld_FechaReembolso
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _idcentro = ls_IdCentro
        _centro = ls_Centro
        _idcuentacorrienteadm = ls_IdCuentaCorriente
        _nrocheque = ls_NroCheque
        _seleccion = lb_Seleccion
        _periodo.Id = ls_IdPeriodo
        _periodo.Codigo = ls_Periodo
        _caja.Id = ls_IdCaja
    End Sub

#End Region

    Public Function Obtener(ByVal grupo As e_Grupo) As e_Grupo Implements Ie_Grupo.Obtener
        Return grupo
    End Function

End Class

