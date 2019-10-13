


<DataContract()> _
Public Class e_CuentaPorCobrar
    Implements Ie_CuentaPorCobrar

#Region "Propiedades"

    Private _id As String
    Private _numero As String
    Private _concepto As String
    Private _tipo As String
    Private _iddocumentoventa As String
    Private _seriedocumentoventa As String
    Private _numdocumentoventa As String
    Private _idAcreedor As String
    Private _importetotal As Double
    Private _importeabonado As Double
    Private _saldo As Double
    Private _cuotas As Integer
    Private _idestado As String
    Private _estado As String
    Private _fechaemision As Date
    Private _fechavencimiento As Date
    Private _idusuario As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _seleccionar As Boolean
    Private _idcliente As String
    Private _cliente As String
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String

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
    Public Property IdCliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreCliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Concepto() As String
        Get
            Return _concepto
        End Get
        Set(ByVal value As String)
            _concepto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDocumentoVenta() As String
        Get
            Return _iddocumentoventa
        End Get
        Set(ByVal value As String)
            _iddocumentoventa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property SerieDocumentoVenta() As String
        Get
            Return _seriedocumentoventa
        End Get
        Set(ByVal value As String)
            _seriedocumentoventa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroDocumentoVenta() As String
        Get
            Return _numdocumentoventa
        End Get
        Set(ByVal value As String)
            _numdocumentoventa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property
    <DataMember()> _
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAcreedor() As String
        Get
            Return _idAcreedor
        End Get
        Set(ByVal value As String)
            _idAcreedor = value
            RaiseEvent DatoCambiado()
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
    Public Property ImporteAbonado() As Double
        Get
            Return _importeabonado
        End Get
        Set(ByVal value As Double)
            _importeabonado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cuotas() As Integer
        Get
            Return _cuotas
        End Get
        Set(ByVal value As Integer)
            _cuotas = value
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
    Public Property Liquidar() As Boolean
        Get
            Return _seleccionar
        End Get
        Set(ByVal value As Boolean)
            _seleccionar = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Overridable Property DocumentoVenta() As String
        Get
            Return _seriedocumentoventa + "-" + _numdocumentoventa
        End Get
        Set(ByVal value As String)
        End Set
    End Property

#End Region

#Region "Constructores"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
               ByVal ls_Seleccionar As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_Numero As String _
              , ByVal ls_Concepto As String _
              , ByVal ls_Tipo As String _
              , ByVal ls_IdAcreedor As String _
              , ByVal ls_IdDocumentoVenta As String _
              , ByVal ls_SerieDocumentoVenta As String _
              , ByVal ls_NumeroDocumentoVenta As String _
              , ByVal ln_ImporteTotal As Double _
              , ByVal ln_ImporteAbonado As Double _
              , ByVal ln_Saldo As Double _
              , ByVal ln_Cuotas As Integer _
              , ByVal ls_IdEstado As String _
              , ByVal ld_FechaEmision As Date _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_Estado As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdCliente As String _
              , ByVal ls_NombreCliente As String _
           )
        _seleccionar = ls_Seleccionar
        _id = ls_Id
        _numero = ls_Numero
        _concepto = ls_Concepto
        _iddocumentoventa = ls_IdDocumentoVenta
        _seriedocumentoventa = ls_SerieDocumentoVenta
        _numdocumentoventa = ls_NumeroDocumentoVenta
        _tipo = ls_Tipo
        _idAcreedor = ls_IdAcreedor
        _importetotal = ln_ImporteTotal
        _importeabonado = ln_ImporteAbonado
        _saldo = ln_Saldo
        _cuotas = ln_Cuotas
        _idestado = ls_IdEstado
        _fechaemision = ld_FechaEmision
        _fechavencimiento = ld_FechaVencimiento
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _estado = ls_Estado
        _activo = lb_Activo
        _idcliente = ls_IdCliente
        _cliente = ls_NombreCliente
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal cuentaPorCobrar As e_CuentaPorCobrar) As e_CuentaPorCobrar Implements Ie_CuentaPorCobrar.Obtener
        Return cuentaPorCobrar
    End Function

#End Region

End Class
