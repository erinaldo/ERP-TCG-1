


<DataContract()> _
Public Class e_Transferencia
    Implements Ie_Transferencia

#Region "Declaracion de Variables"

    Private _id As String
    Private _idbanco As String
    Private _fecha As Date
    Private _numero As String
    Private _concepto As String
    Private _monto As Double
    Private _idmoneda As String
    Private _tipocambio As Double
    Private _idcuentacorrienteorigen As String
    Private _idcuentacorrientedestino As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public oeCtaBancaria As e_CuentaBancaria

    <DataMember()> _
  Public oePeriodo As New e_Periodo

    Event DatoCambiado()

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
    Public Property IdBanco() As String
        Get
            Return _idbanco
        End Get
        Set(ByVal value As String)
            _idbanco = value
            RaiseEvent DatoCambiado()
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
    Public Property Numero() As String
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
    Public Property IdCuentaCorrienteOrigen() As String
        Get
            Return _idcuentacorrienteorigen
        End Get
        Set(ByVal value As String)
            _idcuentacorrienteorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaCorrienteDestino() As String
        Get
            Return _idcuentacorrientedestino
        End Get
        Set(ByVal value As String)
            _idcuentacorrientedestino = value
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
        _id = String.Empty
        _idbanco = String.Empty
        _fecha = #1/1/1901#
        _numero = String.Empty
        _concepto = String.Empty
        _monto = 0
        _idmoneda = String.Empty
        _tipocambio = 0
        _idcuentacorrienteorigen = String.Empty
        _idcuentacorrientedestino = String.Empty
        _usuariocreacion = String.Empty
        _fechacreacion = #1/1/1901#
        _activo = 1
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdBanco As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_Numero As String _
              , ByVal ls_Concepto As String _
              , ByVal ln_Monto As Double _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_TipoCambio As Double _
              , ByVal ls_IdCuentaCorrienteOrigen As String _
              , ByVal ls_IdCuentaCorrienteDestino As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idbanco = ls_IdBanco
        _fecha = ld_Fecha
        _numero = ls_Numero
        _concepto = ls_Concepto
        _monto = ln_Monto
        _idmoneda = ls_IdMoneda
        _tipocambio = ln_TipoCambio
        _idcuentacorrienteorigen = ls_IdCuentaCorrienteOrigen
        _idcuentacorrientedestino = ls_IdCuentaCorrienteDestino
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal transferencia As e_Transferencia) As e_Transferencia Implements Ie_Transferencia.Obtener
        Return transferencia
    End Function

End Class


