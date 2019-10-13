<DataContract()> _
Public Class e_AsientoMov_ObligacionFin
    Implements Ie_AsientoMov_ObligacionFin

#Region "Declaracion de Variables"

    Private _id As String
    Private _idasientomovimiento As String
    Private _idobligacionfinanciera As String
    Private _activo As Boolean
    Private _idobligacionpago As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _nroboucher As String
    Private _fechapago As Date
    Private _tipocambio As Double
    Private _totalmn As Double
    Private _totalme As Double
    Private _flujocaja As String
    Private _mediopago As String
    Private _nrocuenta As String
    Private _banco As String
    Private _periodo As String
    Private _tipoasiento As String
    Private _nroasiento As String
    Private _glosa As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    '<DataMember()> _
    'Public ObligacionFin As New e_ObligacionFinanciera
    '<DataMember()> _
    'Public ObligacionPago As New e_ObligacionPago
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
    Public Property IdAsientoMovimiento() As String
        Get
            Return _idasientomovimiento
        End Get
        Set(ByVal value As String)
            _idasientomovimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdObligacionFinanciera() As String
        Get
            Return _idobligacionfinanciera
        End Get
        Set(ByVal value As String)
            _idobligacionfinanciera = value
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
    Public Property IdObligacionPago() As String
        Get
            Return _idobligacionpago
        End Get
        Set(ByVal value As String)
            _idobligacionpago = value
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
    Public Property NroBoucher() As String
        Get
            Return _nroboucher
        End Get
        Set(ByVal value As String)
            _nroboucher = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaPago() As Date
        Get
            Return _fechapago
        End Get
        Set(ByVal value As Date)
            _fechapago = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalMN() As Double
        Get
            Return _totalmn
        End Get
        Set(ByVal value As Double)
            _totalmn = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalME() As Double
        Get
            Return _totalme
        End Get
        Set(ByVal value As Double)
            _totalme = value
        End Set
    End Property

    <DataMember()> _
    Public Property FlujoCaja() As String
        Get
            Return _flujocaja
        End Get
        Set(ByVal value As String)
            _flujocaja = value
        End Set
    End Property

    <DataMember()> _
    Public Property MedioPago() As String
        Get
            Return _mediopago
        End Get
        Set(ByVal value As String)
            _mediopago = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroCuenta() As String
        Get
            Return _nrocuenta
        End Get
        Set(ByVal value As String)
            _nrocuenta = value
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
    Public Property Periodo() As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoAsiento() As String
        Get
            Return _tipoasiento
        End Get
        Set(ByVal value As String)
            _tipoasiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroAsiento() As String
        Get
            Return _nroasiento
        End Get
        Set(ByVal value As String)
            _nroasiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idasientomovimiento = String.Empty
        _idobligacionfinanciera = String.Empty
        _idobligacionpago = String.Empty
        _activo = True
        _usuariocreacion = String.Empty
        _fechacreacion = #1/1/1901#
        _nroboucher = String.Empty
        _fechapago = #1/1/1901#
        _tipocambio = 0
        _totalmn = 0
        _totalme = 0
        _flujocaja = String.Empty
        _mediopago = String.Empty
        _nrocuenta = String.Empty
        _banco = String.Empty
        _periodo = String.Empty
        _tipoasiento = String.Empty
        _nroasiento = String.Empty
        _glosa = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAsientoMovimiento As String _
              , ByVal ls_IdObligacionFinanciera As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdObligacionPago As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_NroBoucher As String _
              , ByVal ld_FechaPago As Date _
              , ByVal ln_TipoCambio As Double _
              , ByVal ln_TotalMN As Double _
              , ByVal ln_TotalME As Double _
              , ByVal ls_FlujoCaja As String _
              , ByVal ls_MedioPago As String _
              , ByVal ls_NroCuenta As String _
              , ByVal ls_Banco As String _
              , ByVal ls_Periodo As String _
              , ByVal ls_TipoAsiento As String _
              , ByVal ls_NroAsiento As String _
              , ByVal ls_Glosa As String _
           )
        _id = ls_Id
        _idasientomovimiento = ls_IdAsientoMovimiento
        _idobligacionfinanciera = ls_IdObligacionFinanciera
        _activo = lb_Activo
        _idobligacionpago = ls_IdObligacionPago
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _nroboucher = ls_NroBoucher
        _fechapago = ld_FechaPago
        _tipocambio = ln_TipoCambio
        _totalmn = ln_TotalMN
        _totalme = ln_TotalME
        _flujocaja = ls_FlujoCaja
        _mediopago = ls_MedioPago
        _nrocuenta = ls_NroCuenta
        _banco = ls_Banco
        _periodo = ls_Periodo
        _tipoasiento = ls_TipoAsiento
        _nroasiento = ls_NroAsiento
        _glosa = ls_Glosa
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_AsientoMov_ObligacionFin
    ''' </summary>
    ''' <param name="asientoMov_ObligacionFin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal asientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As e_AsientoMov_ObligacionFin Implements Ie_AsientoMov_ObligacionFin.Obtener
        Return asientoMov_ObligacionFin
    End Function

#End Region

End Class

