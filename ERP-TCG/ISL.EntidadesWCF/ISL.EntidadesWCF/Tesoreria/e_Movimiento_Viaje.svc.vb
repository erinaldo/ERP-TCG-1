


<DataContract()> _
Public Class e_Movimiento_Viaje
    Implements Ie_Movimiento_Viaje
    Implements ICloneable

#Region "Declaración de variables"

    Private _id As String
    Private _idmovimiento As String
    Private _idviaje As String
    Private _viaje As String
    Private _IdPiloto As String
    Private _Piloto As String
    Private _idTipoVehiculo As String
    Private _TipoVehiculo As String
    Private _idtracto As String
    Private _Tracto As String
    Private _Carreta As String
    Private _Ingreso As Decimal
    Private _Egreso As Decimal
    Private _Saldo As Decimal
    Private _Voucher As String
    Private _IdEstado As String
    Private _Estado As String
    Private _Fecha As Date
    Private _Ruta As String
    Private _UsuarioCreacion As String
    Private _NombreUsuarioMovimiento As String
    Private _Activo As Boolean
    Private _idtrabajadorrecepciona As String
    Private _tipotrabajadorrecepciona As String
    Private _RecepcionBolsa As String
    Private _fecharecepcion As Date
    Private _EgresoTotal As Double
    Private _IngresoTotal As Double
    Private _SaldoTotal As Double
    Private _TipoTransa As String
    Private _Glosa As String
    Private _Empresa As String
    Private _gastosrendidos As Double
    Private _TipoDocumento As String
    Private _idTipoDocumento As String
    Private _fechaliquidacion As Date
    Private _fechareembolso As Date
    Private _Operacion As String
    Private _idOperacion As String
    Private _Descuento As String
    Private _fecSalOrigen As Date
    Private _fecLleDestino As Date
    Private _carga As String
    Private _copiloto As String
    Private _diasatrasados As Integer
    
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    <DataMember()> _
    Public VincularViajePiloto As String = "0"
    <DataMember()> _
    Public IndViajeVacio As Integer = 0
    <DataMember()> _
    Public IdTrabajadorClave As String

    Public Event DatoCambiado()

#End Region

#Region "Constructor"

    Public Sub New()
        _IdPiloto = ""
        _Empresa = "INDUAMERICA SERVICIOS LOGISTICOS S.A.C."
        _TipoTransa = "1"
        _Activo = True
        _fechaliquidacion = #1/1/1901#
        _fechareembolso = #1/1/1901#
        _RecepcionBolsa = ""
        _fecharecepcion = #1/1/1901#
        _idOperacion = ""
        _Operacion = ""
        _idviaje = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMovimiento As String _
              , ByVal ls_IdViaje As String _
              , ByVal ls_Viaje As String _
              , ByVal ls_IdPiloto As String _
              , ByVal ls_Piloto As String _
              , ByVal ls_IdTipoVehiculo As String _
              , ByVal ls_TipoVehiculo As String _
              , ByVal ls_IdTracto As String _
              , ByVal ls_Tracto As String _
              , ByVal ls_Carreta As String _
              , ByVal ld_Ingreso As Decimal _
              , ByVal ld_Egreso As Decimal _
              , ByVal ld_Saldo As Decimal _
              , ByVal ls_Voucher As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_Ruta As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_NombreUsuarioMovimiento As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdTrabajadorRecepciona As String _
              , ByVal ls_TipoTrabajadorRecepciona As String _
              , ByVal ls_RecepcionBolsa As String _
              , ByVal ld_FechaRecepcion As Date _
              , ByVal ls_TipoTransa As String _
              , ByVal ld_IngresoTotal As Double _
              , ByVal ld_EgresoTotal As Double _
              , ByVal ld_SaldoTotal As Double _
              , ByVal ls_Glosa As String _
              , ByVal ld_GastosRendidos As Double _
              , ByVal ld_FechaLiquidacion As Date _
              , ByVal ld_FechaReembolso As Date _
              , ByVal ls_IdOperacion As String _
              , ByVal ls_Operacion As String _
              , ByVal ls_Descuento As String _
              , ByVal ld_FecSalOrigen As Date _
              , ByVal ld_FecLleDestino As Date _
              , ByVal ls_Carga As String _
              , ByVal ls_Copiloto As String _
              , ByVal li_DiasAtrasados As Integer)
        _id = ls_Id
        _idmovimiento = ls_IdMovimiento
        _idviaje = ls_IdViaje
        _viaje = ls_Viaje
        _IdPiloto = ls_IdPiloto
        _Piloto = ls_Piloto
        _idTipoVehiculo = ls_IdTipoVehiculo
        _TipoVehiculo = ls_TipoVehiculo
        _idtracto = ls_IdTracto
        _Tracto = ls_Tracto
        _Carreta = ls_Carreta
        _Ingreso = ld_Ingreso
        _Egreso = ld_Egreso
        _Voucher = ls_Voucher
        _Saldo = ld_Saldo
        _IdEstado = ls_IdEstado
        _Estado = ls_Estado
        _Fecha = ld_Fecha
        _Ruta = ls_Ruta
        _UsuarioCreacion = ls_UsuarioCreacion
        _NombreUsuarioMovimiento = ls_NombreUsuarioMovimiento
        _Activo = lb_Activo
        _idtrabajadorrecepciona = ls_IdTrabajadorRecepciona
        _RecepcionBolsa = ls_RecepcionBolsa
        _fecharecepcion = ld_FechaRecepcion
        _TipoTransa = ls_TipoTransa
        _IngresoTotal = ld_IngresoTotal
        _EgresoTotal = ld_EgresoTotal
        _SaldoTotal = ld_SaldoTotal
        _Glosa = ls_Glosa
        _tipotrabajadorrecepciona = ls_TipoTrabajadorRecepciona
        _gastosrendidos = ld_GastosRendidos
        _fechaliquidacion = ld_FechaLiquidacion
        _fechareembolso = ld_FechaReembolso
        _idOperacion = ls_IdOperacion
        _Operacion = ls_Operacion
        _Descuento = ls_Descuento
        _fecLleDestino = ld_FecLleDestino
        _fecSalOrigen = ld_FecSalOrigen
        _carga = ls_Carga
        _copiloto = ls_Copiloto
        _diasatrasados = li_DiasAtrasados
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
    Public Property IdMovimiento() As String
        Get
            Return _idmovimiento
        End Get
        Set(ByVal value As String)
            _idmovimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Copiloto() As String
        Get
            Return _copiloto
        End Get
        Set(ByVal value As String)
            _copiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _idviaje
        End Get
        Set(ByVal value As String)
            _idviaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DiasAtrasados() As Integer
        Get
            Return _diasatrasados
        End Get
        Set(ByVal value As Integer)
            _diasatrasados = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Viaje() As String
        Get
            Return _viaje
        End Get
        Set(ByVal value As String)
            _viaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoTransa() As String
        Get
            Return _TipoTransa
        End Get
        Set(ByVal value As String)
            _TipoTransa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _NombreUsuarioMovimiento
        End Get
        Set(ByVal value As String)
            _NombreUsuarioMovimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ruta() As String
        Get
            Return _Ruta
        End Get
        Set(ByVal value As String)
            _Ruta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoVehiculo() As String
        Get
            Return _TipoVehiculo
        End Get
        Set(ByVal value As String)
            _TipoVehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoVehiculo() As String
        Get
            Return _idTipoVehiculo
        End Get
        Set(ByVal value As String)
            _idTipoVehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Decimal
        Get
            Return _Saldo
        End Get
        Set(ByVal value As Decimal)
            _Saldo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Voucher() As String
        Get
            Return _Voucher
        End Get
        Set(ByVal value As String)
            _Voucher = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _IdEstado
        End Get
        Set(ByVal value As String)
            _IdEstado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Egreso() As Decimal
        Get
            Return _Egreso
        End Get
        Set(ByVal value As Decimal)
            _Egreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ingreso() As Decimal
        Get
            Return _Ingreso
        End Get
        Set(ByVal value As Decimal)
            _Ingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Carreta() As String
        Get
            Return _Carreta
        End Get
        Set(ByVal value As String)
            _Carreta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tracto() As String
        Get
            Return _Tracto
        End Get
        Set(ByVal value As String)
            _Tracto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Piloto() As String
        Get
            Return _Piloto
        End Get
        Set(ByVal value As String)
            _Piloto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPiloto() As String
        Get
            Return _IdPiloto
        End Get
        Set(ByVal value As String)
            _IdPiloto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajadorRecepciona() As String
        Get
            Return _idtrabajadorrecepciona
        End Get
        Set(ByVal value As String)
            _idtrabajadorrecepciona = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property RecibeBolsa() As String
        Get
            Return _RecepcionBolsa
        End Get
        Set(ByVal value As String)
            _RecepcionBolsa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaRecepcion() As Date
        Get
            Return _fecharecepcion
        End Get
        Set(ByVal value As Date)
            _fecharecepcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoTotal() As Double
        Get
            Return _SaldoTotal
        End Get
        Set(ByVal value As Double)
            _SaldoTotal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property EgresoTotal() As Double
        Get
            Return _EgresoTotal
        End Get
        Set(ByVal value As Double)
            _EgresoTotal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IngresoTotal() As Double
        Get
            Return _IngresoTotal
        End Get
        Set(ByVal value As Double)
            _IngresoTotal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FecLleDestino() As Date
        Get
            Return _fecLleDestino
        End Get
        Set(ByVal value As Date)
            _fecLleDestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property FecSalOrigen() As Date
        Get
            Return _fecSalOrigen
        End Get
        Set(ByVal value As Date)
            _fecSalOrigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Carga() As String
        Get
            Return _carga
        End Get
        Set(ByVal value As String)
            _carga = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoTRB() As String
        Get
            Return _tipotrabajadorrecepciona
        End Get
        Set(ByVal value As String)
            _tipotrabajadorrecepciona = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Empresa() As String
        Get
            Return _Empresa
        End Get
        Set(ByVal value As String)
            _Empresa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoDocumento() As String
        Get
            Return _idTipoDocumento
        End Get
        Set(ByVal value As String)
            _idTipoDocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocumento() As String
        Get
            Return _TipoDocumento
        End Get
        Set(ByVal value As String)
            _TipoDocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTracto() As String
        Get
            Return _idtracto
        End Get
        Set(ByVal value As String)
            _idtracto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property GastosRendidos() As Double
        Get
            Return _gastosrendidos
        End Get
        Set(ByVal value As Double)
            _gastosrendidos = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaLiquidacion() As Date
        Get
            Return _fechaliquidacion
        End Get
        Set(ByVal value As Date)
            _fechaliquidacion = value
            RaiseEvent DatoCambiado()
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
    Public Property IdOperacion() As String
        Get
            Return _idOperacion
        End Get
        Set(ByVal value As String)
            _idOperacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Operacion() As String
        Get
            Return _Operacion
        End Get
        Set(ByVal value As String)
            _Operacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Descuento() As String
        Get
            Return _Descuento
        End Get
        Set(ByVal value As String)
            _Descuento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal movimiento_Viaje As e_Movimiento_Viaje) As e_Movimiento_Viaje Implements Ie_Movimiento_Viaje.Obtener
        Return movimiento_Viaje
    End Function

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Dim oeMov As New e_Movimiento_Viaje
        With oeMov
            .Activo = Me.Activo
            .Empresa = Me.Empresa
            .IdViaje = Me.IdViaje
            .TipoTransa = Me.TipoTransa
            .TipoOperacion = Me.TipoOperacion
            .Modificado = Me.Modificado
            .VincularViajePiloto = Me.VincularViajePiloto
            .IdMovimiento = Me.IdMovimiento
        End With
        Return oeMov
    End Function

End Class

