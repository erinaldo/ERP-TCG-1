<DataContract()> _
Public Class e_AjusteTC
    Implements Ie_AjusteTC

#Region "Declaracion de Variables"

    Private _idmovimientodocumento As String
    Private _idperiodo As String
    Private _tipoasiento As String
    Private _periodo As String
    Private _nroasiento As String
    Private _glosa As String
    Private _cuenta As String
    Private _tipodocumento As String
    Private _serie As String
    Private _numero As String
    Private _tipocambio As Double
    Private _debe As Double
    Private _haber As Double

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Ejercicio As Integer
    <DataMember()> _
    Public IdAsientoModelo As String
    <DataMember()>
    Public IdCuentaContable As String
    <DataMember()>
    Public PrefijoID As String = ""

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _idmovimientodocumento
        End Get
        Set(ByVal value As String)
            _idmovimientodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPeriodo() As String
        Get
            Return _idperiodo
        End Get
        Set(ByVal value As String)
            _idperiodo = value
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
    Public Property Periodo() As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
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
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
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

    <DataMember()> _
    Public Property TipoDocumento() As String
        Get
            Return _tipodocumento
        End Get
        Set(ByVal value As String)
            _tipodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
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
    Public Property Debe() As Double
        Get
            Return _debe
        End Get
        Set(ByVal value As Double)
            _debe = value
        End Set
    End Property

    <DataMember()> _
    Public Property Haber() As Double
        Get
            Return _haber
        End Get
        Set(ByVal value As Double)
            _haber = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _idmovimientodocumento = String.Empty
        _idperiodo = String.Empty
        _tipoasiento = String.Empty
        _periodo = String.Empty
        _nroasiento = String.Empty
        _glosa = String.Empty
        _cuenta = String.Empty
        _tipodocumento = String.Empty
        _serie = String.Empty
        _numero = String.Empty
        _tipocambio = 0
        _debe = 0
        _haber = 0
    End Sub

    Public Sub New(ByVal ls_IdMovimientoDocumento As String, _
                   ByVal ls_IdPeriodo As String, _
                   ByVal ls_TipoAsiento As String, _
                   ByVal ls_Periodo As String, _
                   ByVal ls_NroAsiento As String, _
                   ByVal ls_Glosa As String, _
                   ByVal ls_Cuenta As String, _
                   ByVal ls_TipoDocumento As String, _
                   ByVal ls_Serie As String, _
                   ByVal ls_Numero As String, _
                   ByVal ln_TipoCambio As Double, _
                   ByVal ln_Debe As Double, _
                   ByVal ln_Haber As Double)
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _idperiodo = ls_IdPeriodo
        _tipoasiento = ls_TipoAsiento
        _periodo = ls_Periodo
        _nroasiento = ls_NroAsiento
        _cuenta = ls_Cuenta
        _glosa = ls_Glosa
        _tipodocumento = ls_TipoDocumento
        _serie = ls_Serie
        _numero = ls_Numero
        _tipocambio = ln_TipoCambio
        _debe = ln_Debe
        _haber = ln_Haber
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ajustetc As e_AjusteTC) As e_AjusteTC Implements Ie_AjusteTC.Obtener
        Return ajustetc
    End Function

#End Region

End Class
