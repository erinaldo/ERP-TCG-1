' NOTA: si cambia aquí el nombre de clase "e_ChequesControl", también debe actualizar la referencia a "e_ChequesControl" tanto en Web.config como en el archivo .svc asociado.
Public Class e_ChequesControl
    Implements Ie_ChequesControl

#Region "Propiedad"

    Private _id As String
    Private _cuentabancaria As New e_CuentaBancaria
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _moneda As String
    Private _banco As String
    Private _stocktalonarios As String
    
    Public listaChequeTalonario As New List(Of e_ChequesTalonarios)

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property Banco() As String
        Get
            Return _banco
        End Get
        Set(ByVal value As String)
            _banco = value
        End Set
    End Property

    <DataMember()> _
    Public Property Moneda() As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaBancaria() As String
        Get
            Return _cuentabancaria.NumeroCuenta
        End Get
        Set(ByVal value As String)
            _cuentabancaria.NumeroCuenta = value
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
    Public Property StockTalonarios() As String
        Get
            Return _stocktalonarios
        End Get
        Set(ByVal value As String)
            _stocktalonarios = value
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

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCuentaBancaria As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_FechaCreacion As Date _
              , ByVal ls_Banco As String _
              , ByVal ls_Moneda As String _
              , ByVal ls_CuentaBancaria As String _
              , ByVal ls_Stock As String)
        _id = ls_Id
        _cuentabancaria.Id = ls_IdCuentaBancaria
        _cuentabancaria.NumeroCuenta = ls_CuentaBancaria
        _moneda = ls_Moneda
        _banco = ls_Banco
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ls_FechaCreacion
        _stocktalonarios = ls_Stock
    End Sub

#End Region

    Public Function Obtener(ByVal chequescontrol As e_ChequesControl) As e_ChequesControl Implements Ie_ChequesControl.Obtener
        Return chequescontrol
    End Function

End Class
