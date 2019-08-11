


<DataContract()> _
Public Class e_ChequeEmitido
    Implements Ie_ChequeEmitido

#Region "Propiedad"

    Private _id As String
    Private _fecha As Date
    Private _idproveedor As String
    Private _proveedor As String
    Private _cuentabancaria As New e_CuentaBancaria
    Private _idcuentacorriente As String
    Private _idcentro As String
    Private _centro As String
    Private _nrocheque As String
    Private _detalle As String
    Private _fechacobro As Date
    Private _importe As Double
    Private _saldo As Double
    Private _idconcepto As String
    Private _concepto As String
    Private _idestado As String
    Private _estado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _codigo As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public oePeriodo As New e_Periodo
    <DataMember()> _
    Public IdMoneda As String
    <DataMember()> _
    Public IdTrabajador As String
    <DataMember()> _
    Public loChequeDocumento As New List(Of e_ChequeDocumento)
    <DataMember()> _
    Public TipoCambio As Double
    <DataMember()> _
    Public loAsientoModelo As New List(Of e_AsientoModelo)

    Event DatoCambiado()

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
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdProveedor() As String
        Get
            Return _idproveedor
        End Get
        Set(ByVal value As String)
            _idproveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Proveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Banco() As String
        Get
            Return _cuentabancaria.NombreBanco
        End Get
        Set(ByVal value As String)
            _cuentabancaria.NombreBanco = value
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
        End Set
    End Property

    <DataMember()> _
    Public Property Centro() As String
        Get
            Return _centro
        End Get
        Set(ByVal value As String)
            _centro = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Moneda() As String
        Get
            Return _cuentabancaria.NombreMoneda
        End Get
        Set(ByVal value As String)
            _cuentabancaria.NombreMoneda = value
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
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaBancaria() As String
        Get
            Return _cuentabancaria.Id
        End Get
        Set(ByVal value As String)
            _cuentabancaria.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaBancaria() As String
        Get
            Return _cuentabancaria.NumeroCuenta
        End Get
        Set(ByVal value As String)
            _cuentabancaria.NumeroCuenta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaCorriente() As String
        Get
            Return _idcuentacorriente
        End Get
        Set(ByVal value As String)
            _idcuentacorriente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroCheque() As String
        Get
            Return _nrocheque
        End Get
        Set(ByVal value As String)
            _nrocheque = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Detalle() As String
        Get
            Return _detalle
        End Get
        Set(ByVal value As String)
            _detalle = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCobro() As Date
        Get
            Return _fechacobro
        End Get
        Set(ByVal value As Date)
            _fechacobro = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
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
    Public Property IdConcepto() As String
        Get
            Return _idconcepto
        End Get
        Set(ByVal value As String)
            _idconcepto = value
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
              , ByVal ld_Fecha As Date _
              , ByVal ls_IdProveedor As String _
              , ByVal ls_IdCuentaBancaria As String _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ls_NroCheque As String _
              , ByVal ls_Detalle As String _
              , ByVal ld_FechaCobro As Date _
              , ByVal ln_Importe As Double _
              , ByVal ln_Saldo As Double _
              , ByVal ls_IdConcepto As String _
              , ByVal ls_Concepto As String _
              , ByVal ls_IdEstado As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Moneda As String _
              , ByVal ls_Banco As String _
              , ByVal ls_CuentaBancaria As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Proveedor As String _
              , ByVal ls_Estado As String _
              , ByVal ls_Centro As String)
        _id = ls_Id
        _fecha = ld_Fecha
        _idproveedor = ls_IdProveedor
        _cuentabancaria.Id = ls_IdCuentaBancaria
        _idcuentacorriente = ls_IdCuentaCorriente
        _nrocheque = ls_NroCheque
        _detalle = ls_Detalle
        _fechacobro = ld_FechaCobro
        _importe = ln_Importe
        _saldo = ln_Saldo
        _idconcepto = ls_IdConcepto
        _concepto = ls_Concepto
        _idestado = ls_IdEstado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _cuentabancaria.NombreMoneda = ls_Moneda
        _cuentabancaria.NombreBanco = ls_Banco
        _cuentabancaria.NumeroCuenta = ls_CuentaBancaria
        _codigo = ls_Codigo
        _proveedor = ls_Proveedor
        _estado = ls_Estado
        _centro = ls_Centro
    End Sub

#End Region

    Public Function Obtener(ByVal chequeemitido As e_ChequeEmitido) As e_ChequeEmitido Implements Ie_ChequeEmitido.Obtener
        Return chequeemitido
    End Function

End Class

