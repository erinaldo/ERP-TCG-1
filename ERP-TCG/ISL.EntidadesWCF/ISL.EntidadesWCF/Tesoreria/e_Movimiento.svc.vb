
''' <summary>
''' Entidad para almacenar la información de movimientos de Tesorería
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Movimiento
    Implements Ie_Movimiento
    Implements ICloneable

#Region "Declaración de variables"

    Private _id As String
    Private _fecha As Date
    Private _idcuentacorrienteorigen As String
    Private _idcuentacorrientedestino As String
    Private _IdCaja As String
    Private _IdProveedor As String
    Private _ingreso As Decimal
    Private _egreso As Decimal
    Private _saldo As Decimal
    Private _glosa As String
    Private _voucher As String
    Private _usuariocreacion As String
    Private _descuento As Integer
    Private _tipomovimiento As Integer
    Private _idestado As String
    Private _IdViaje As String
    Private _activo As Boolean
    Private _tipotransa As Integer
    Private _AsignadoGrupo As Integer
    Private _indPrestamoHab As Integer
    Private _depositado As Decimal
    Private _saldopordepositar As Decimal

    <DataMember()> _
    Public oeMovimientoViaje As New e_Movimiento_Viaje
    <DataMember()> _
    Public oeMovimientoFlete As New e_Movimiento_Flete
    <DataMember()> _
    Public loViajesAsociados As New List(Of e_Movimiento_Viaje)
    <DataMember()> _
    Public loMovimiento As New List(Of e_Movimiento)
    <DataMember()> _
    Public IndCerrado As String = 0
    <DataMember()> _
    Public Concepto As String = ""
    <DataMember()> _
    Public FechaCierre As Date
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public TipoProceso As String
    <DataMember()> _
    Public NroCuotas As String
    <DataMember()> _
    Public Modificado As Boolean = False
    Private _NombreCompleto As String
    Private _Viaje As String
    Private _UsuarioAutoriza As String
    Private _Importe As Decimal
    Private _IdMovimientoViaje As String
    Private _ViajeId As String
    Private _IndAdministrativo As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public IndicadorCorrelativo As Boolean = False

    <DataMember()> _
    Public IdCheque As String = ""
    'Public IndPrestamoHab As Integer = 0

    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    Public Sub New()
        _glosa = ""
        _id = ""
        _usuariocreacion = ""
        _activo = True
        _tipomovimiento = 1
        _AsignadoGrupo = 0
        _fecha = #1/1/1901#
        _indPrestamoHab = 0
        _depositado = 0
        _saldopordepositar = 0
        IdCaja = ""
        NroCuotas = 0
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_IdCuentaCorrienteOrigen As String _
              , ByVal ls_IdCuentaCorrienteDestino As String _
              , ByVal ln_Ingreso As Decimal _
              , ByVal ln_Egreso As Decimal _
              , ByVal ln_Saldo As Decimal _
              , ByVal ls_Glosa As String _
              , ByVal ls_Voucher As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ln_Descuento As Integer _
              , ByVal ln_TipoMovimiento As Integer _
              , ByVal ls_IdEstado As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ln_TipoTransa As Integer _
              , ByVal ld_IndPrestamoHab As Integer _
              , ByVal ld_SaldoPorDepositar As Decimal _
           )
        _id = ls_Id
        _fecha = ld_Fecha
        _idcuentacorrienteorigen = ls_IdCuentaCorrienteOrigen
        _idcuentacorrientedestino = ls_IdCuentaCorrienteDestino
        _ingreso = ln_Ingreso
        _egreso = ln_Egreso
        _saldo = ln_Saldo
        _glosa = ls_Glosa
        _voucher = ls_Voucher
        _usuariocreacion = ls_UsuarioCreacion
        _descuento = ln_Descuento
        _tipomovimiento = ln_TipoMovimiento
        _IdProveedor = ls_IdEstado
        _activo = lb_Activo
        _tipotransa = ln_TipoTransa
        _indPrestamoHab = ld_IndPrestamoHab
        _saldopordepositar = ld_SaldoPorDepositar
    End Sub

    Sub New(ByVal ls_IdMovimiento As String _
             , ByVal ls_IdMovimientoViaje As String _
             , ByVal ls_IdViaje As String _
             , ByVal ls_NombreCompleto As String _
             , ByVal ls_IdCuentaCorrienteOrigen As String _
              , ByVal ls_IdCuentaCorrienteDestino As String _
              , ByVal ls_Viaje As String _
              , ByVal ls_Glosa As String _
              , ByVal ls_UsuarioAutoriza As String _
              , ByVal ld_Importe As Decimal _
              , ByVal ls_Fecha As Date _
              , ByVal li_IndAdministrativo As Boolean)
        _id = ls_IdMovimiento
        _IdMovimientoViaje = ls_IdMovimientoViaje
        _ViajeId = ls_IdViaje
        _IndAdministrativo = li_IndAdministrativo
        If li_IndAdministrativo = "1" Then
            _NombreCompleto = ls_UsuarioAutoriza
            _UsuarioAutoriza = ls_NombreCompleto
        Else
            _NombreCompleto = ls_NombreCompleto
            _UsuarioAutoriza = ls_UsuarioAutoriza
        End If
        _idcuentacorrienteorigen = ls_IdCuentaCorrienteOrigen
        _idcuentacorrientedestino = ls_IdCuentaCorrienteDestino
        _Viaje = ls_Viaje
        _glosa = ls_Glosa
        _Importe = ld_Importe
        _fecha = ls_Fecha
    End Sub

#End Region

#Region "Propiedades"

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
    Public Property IndAdministrativo() As Boolean
        Get
            Return _IndAdministrativo
        End Get
        Set(ByVal value As Boolean)
            _IndAdministrativo = value
        End Set
    End Property

    <DataMember()> _
    Public Property ViajeId() As String
        Get
            Return _ViajeId
        End Get
        Set(ByVal value As String)
            _ViajeId = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoViaje() As String
        Get
            Return _IdMovimientoViaje
        End Get
        Set(ByVal value As String)
            _IdMovimientoViaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Decimal
        Get
            Return _Importe
        End Get
        Set(ByVal value As Decimal)
            _Importe = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioAutoriza() As String
        Get
            Return _UsuarioAutoriza
        End Get
        Set(ByVal value As String)
            _UsuarioAutoriza = value
        End Set
    End Property

    <DataMember()> _
    Public Property Viaje() As String
        Get
            Return _Viaje
        End Get
        Set(ByVal value As String)
            _Viaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreCompleto() As String
        Get
            Return _NombreCompleto
        End Get
        Set(ByVal value As String)
            _NombreCompleto = value
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
    Public Property IdViaje() As String
        Get
            Return _IdViaje
        End Get
        Set(ByVal value As String)
            _IdViaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCaja() As String
        Get
            Return _IdCaja
        End Get
        Set(ByVal value As String)
            _IdCaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdProveedor() As String
        Get
            Return _IdProveedor
        End Get
        Set(ByVal value As String)
            _IdProveedor = value
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
    Public Property Ingreso() As Decimal
        Get
            Return _ingreso
        End Get
        Set(ByVal value As Decimal)
            _ingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Egreso() As Decimal
        Get
            Return _egreso
        End Get
        Set(ByVal value As Decimal)
            _egreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Decimal
        Get
            Return _saldo
        End Get
        Set(ByVal value As Decimal)
            _saldo = value
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
    Public Property Voucher() As String
        Get
            Return _voucher
        End Get
        Set(ByVal value As String)
            _voucher = value
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
    Public Property Descuento() As Integer
        Get
            Return _descuento
        End Get
        Set(ByVal value As Integer)
            _descuento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMovimiento() As Integer
        Get
            Return _tipomovimiento
        End Get
        Set(ByVal value As Integer)
            _tipomovimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _IdProveedor
        End Get
        Set(ByVal value As String)
            _IdProveedor = value
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
    Public Property TipoTransa() As Integer
        Get
            Return _tipotransa
        End Get
        Set(ByVal value As Integer)
            _tipotransa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property AsignadoGrupo() As Integer
        Get
            Return _AsignadoGrupo
        End Get
        Set(ByVal value As Integer)
            _AsignadoGrupo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndPrestamoHab() As Integer
        Get
            Return _indPrestamoHab
        End Get
        Set(ByVal value As Integer)
            _indPrestamoHab = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Depositado() As Decimal
        Get
            Return _depositado
        End Get
        Set(ByVal value As Decimal)
            _depositado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoPorDepositar() As Decimal
        Get
            Return _saldopordepositar
        End Get
        Set(ByVal value As Decimal)
            _saldopordepositar = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal movimiento As e_Movimiento) As e_Movimiento Implements Ie_Movimiento.Obtener
        Return movimiento
    End Function

    Public Function Clonar() As Object Implements System.ICloneable.Clone
        Dim oeMov As New e_Movimiento
        With oeMov
            .IdMovimientoViaje = Me.IdMovimientoViaje
            .ViajeId = Me.ViajeId
            .IdViaje = Me.IdViaje
            .NombreCompleto = Me.NombreCompleto
            .UsuarioAutoriza = Me.UsuarioAutoriza
            .IndicadorCorrelativo = Me.IndicadorCorrelativo
            .IdCuentaCorrienteOrigen = Me.IdCuentaCorrienteOrigen
            .IdCuentaCorrienteDestino = Me.IdCuentaCorrienteDestino
            .Viaje = Me.Viaje
            .Glosa = Me.Glosa
            .Importe = Me.Importe
            .Fecha = Me.Fecha
            .UsuarioCreacion = Me.UsuarioCreacion
            .Descuento = Me.Descuento
            .Activo = Me.Activo
            .TipoProceso = Me.TipoProceso
            .TipoTransa = Me.TipoTransa
        End With
        Return oeMov
    End Function

#End Region

End Class


