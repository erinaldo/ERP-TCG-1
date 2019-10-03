<DataContract()> _
Public Class e_MovCuentaCte
    Implements Ie_MovCuentaCte
    Implements IEquatable(Of e_MovCuentaCte)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idcuentacorriente As String
    Private _idreferencia As String
    Private _tiporeferencia As String
    Private _ingresoegreso As String
    Private _fecha As Date
    Private _referencia As String
    Private _proveedor As String
    Private _numero As String
    Private _importe As Double
    Private _IdMoneda As String
    Private _TipoCambio As Double
    Private _ingreso As Double
    Private _egreso As Double
    Private _glosa As String
    Private _liquidado As Integer
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _activo As Boolean
    Private _fechaliquida As Date
    Private _usuarioliquida As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public Mac As String
    <DataMember()> _
    Public Trabajador As String
    <DataMember()> _
    Public IdFlujoCaja As String
    <DataMember()> _
    Public IdTipoDocumento As String
    <DataMember()> _
    Public oeTransferencia As New e_Transferencia
    <DataMember()> _
    Public oeMovimientoDoc As New e_MovimientoDocumento
    <DataMember()> _
    Public oeAsiento As New e_Asiento
    <DataMember()> _
    Public oeMovCuentaCte_Asiento As New e_MovCuentaCte_Asiento

    <DataMember()>
    Public IdTrabajador As String
    <DataMember()> _
    Public IdCtaTrans As String = String.Empty
    <DataMember()> _
    Public IndNoGrabado As Boolean
    <DataMember()> _
    Public TipoBusca As Integer = 0
    <DataMember()> _
    Public MontoPago As Double = 0

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
    Public Property IdReferencia() As String
        Get
            Return _idreferencia
        End Get
        Set(ByVal value As String)
            _idreferencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoReferencia() As String
        Get
            Return _tiporeferencia
        End Get
        Set(ByVal value As String)
            _tiporeferencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IngresoEgreso() As String
        Get
            Return _ingresoegreso
        End Get
        Set(ByVal value As String)
            _ingresoegreso = value
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
    Public Property Referencia() As String
        Get
            Return _referencia
        End Get
        Set(ByVal value As String)
            _referencia = value
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
    Public Property IdMoneda() As String
        Get
            Return _IdMoneda
        End Get
        Set(ByVal value As String)
            _IdMoneda = value
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
    Public Property TipoCambio() As Double
        Get
            Return _TipoCambio
        End Get
        Set(ByVal value As Double)
            _TipoCambio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ingreso() As Double
        Get
            Return _ingreso
        End Get
        Set(ByVal value As Double)
            _ingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Egreso() As Double
        Get
            Return _egreso
        End Get
        Set(ByVal value As Double)
            _egreso = value
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
    Public Property Liquidado() As Integer
        Get
            Return _liquidado
        End Get
        Set(ByVal value As Integer)
            _liquidado = value
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

    <DataMember()> _
    Public Property FechaLiquida() As Date
        Get
            Return _fechaliquida
        End Get
        Set(ByVal value As Date)
            _fechaliquida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioLiquida() As String
        Get
            Return _usuarioliquida
        End Get
        Set(ByVal value As String)
            _usuarioliquida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

        _id = String.Empty
        _idcuentacorriente = String.Empty
        _idreferencia = String.Empty
        _tiporeferencia = String.Empty
        _ingresoegreso = String.Empty
        _fecha = #1/1/1901#
        _referencia = String.Empty
        _proveedor = String.Empty
        _numero = String.Empty
        _IdMoneda = String.Empty
        _importe = 0
        _ingreso = 0
        _egreso = 0
        _glosa = String.Empty
        _liquidado = 0
        _usuariocreacion = String.Empty
        _fechacreacion = #1/1/1901#
        _activo = 1
        _fechaliquida = #1/1/1901#
        _usuarioliquida = String.Empty
        TipoOperacion = String.Empty
        IdTipoDocumento = String.Empty
        Mac = String.Empty
        Trabajador = String.Empty
        IdFlujoCaja = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ls_IdReferencia As String _
              , ByVal ls_TipoReferencia As String _
              , ByVal ls_IngresoEgreso As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_Referencia As String _
              , ByVal ls_Proveedor As String _
              , ByVal ls_Numero As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_Importe As Double _
              , ByVal ln_TipoCambio As Double _
              , ByVal ls_Glosa As String _
              , ByVal ln_Liquidado As Integer _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaLiquida As Date _
              , ByVal ls_UsuarioLiquida As String _
           )
        _id = ls_Id
        _idcuentacorriente = ls_IdCuentaCorriente
        _idreferencia = ls_IdReferencia
        _tiporeferencia = ls_TipoReferencia
        _ingresoegreso = ls_IngresoEgreso
        _fecha = ld_Fecha
        _referencia = ls_Referencia
        _proveedor = ls_Proveedor
        _numero = ls_Numero
        _IdMoneda = ls_IdMoneda
        _importe = ln_Importe
        _TipoCambio = ln_TipoCambio
        _ingreso = IIf(ls_IngresoEgreso = "0", ln_Importe, 0)
        _egreso = IIf(ls_IngresoEgreso = "1", ln_Importe, 0)
        _glosa = ls_Glosa
        _liquidado = ln_Liquidado
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
        _fechaliquida = ld_FechaLiquida
        _usuarioliquida = ls_UsuarioLiquida
        TipoOperacion = String.Empty
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal movcuentacte As e_MovCuentaCte) As e_MovCuentaCte Implements Ie_MovCuentaCte.Obtener
        Return movcuentacte
    End Function

    Public Overloads Function Equals(ByVal oeMovCuentaCte As e_MovCuentaCte) As Boolean Implements IEquatable(Of e_MovCuentaCte).Equals
        Select Case oeMovCuentaCte.TipoBusca
            Case 0 : If Me.Id = oeMovCuentaCte.Id Then Return True
            Case 1 : If Me.IdTipoDocumento = oeMovCuentaCte.IdTipoDocumento And Me.IdReferencia = oeMovCuentaCte.IdReferencia Then Return True
        End Select
        Return False
    End Function

#End Region

End Class

