<DataContract()> _
Public Class e_GastoOperacion
    Implements Ie_GastoOperacion
    Implements IEquatable(Of e_GastoOperacion)

#Region "Declaracion de Varibles"

    Private _id As String
    Private _idcuentacorriente As String
    Private _tipomovimiento As String
    Private _idflujocaja As String
    Private _idtrabajadorautoriza As String
    Private _trabajadorautoriza As String
    Private _flujocaja As String
    Private _iddocumento As String
    Private _serieocumento As String
    Private _nrodocumento As String
    Private _idproveedor As String
    Private _idmoneda As String
    Private _idperiodo As String
    Private _idtipodoc As String
    Private _igvdoc As Double
    Private _subtotaldoc As Double
    Private _tipocambio As Double
    Private _periodo As String
    Private _tipodocumento As String
    Private _idviaje As String
    Private _proveedor As String
    Private _glosa As String
    Private _moneda As String
    Private _total As Double
    Private _idestado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _fechaemision As Date
    Private _fechavencimiento As Date
    Private _idgrupo As String
    Private _nrogrupo As String
    Private _viaje As String
    Private _idPiloto As String
    Private _Piloto As String
    Private _idtipovehiculo As String
    Private _vehiculo As String
    Private _idCopiloto As String
    Private _copiloto As String
    Private _idorigen As String
    Private _origen As String
    Private _iddestino As String
    Private _destino As String
    Private _estado As String
    Private _ruta As String
    Private _indalmacen As Boolean
    Private _IndGasto As Integer

    'Private _indcerrado As Integer

    <DataMember()> _
    Public IdLugar As String
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public IdTracto As String
    <DataMember()> _
    Public oeFlujoCaja As New e_FlujoCaja
    <DataMember()> _
    Public IdCaja As String = ""
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Mac As String
    <DataMember()> _
    Public IdAsiento As String
    <DataMember()> _
    Public Ejercicio As Integer
    <DataMember()> _
    Public FechaCierre As Date
    <DataMember()> _
    Public oeGasto_Caja As New e_Gasto_Caja
    <DataMember()> _
    Public oeMovimientoDocumento As e_MovimientoDocumento
    <DataMember()> _
    Public oeRegistroCombustible As New e_RegistroConsumoCombustible
    <DataMember()> _
    Public oeAsiento As New e_Asiento
    <DataMember()> _
    Public GastoAsiento As e_GastoAsiento
    <DataMember()> _
    Public TipoBus As String = ""
    <DataMember()> _
    Public loAsientoModeloVale As New List(Of e_AsientoModelo)
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

    <DataMember()> _
    Public IdTarjetaMovimiento As String

#End Region

#Region "Propiedad"

    <DataMember()> _
    Public Property Ruta() As String
        Get
            Return _ruta
        End Get
        Set(ByVal value As String)
            _ruta = value
        End Set
    End Property

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
    Public Property IdTrabajadorAutoriza() As String
        Get
            Return _idtrabajadorautoriza
        End Get
        Set(ByVal value As String)
            _idtrabajadorautoriza = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TrabajadorAutoriza() As String
        Get
            Return _trabajadorautoriza
        End Get
        Set(ByVal value As String)
            _trabajadorautoriza = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndAlmacen() As Boolean
        Get
            Return _indalmacen
        End Get
        Set(ByVal value As Boolean)
            _indalmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMovimiento() As String
        Get
            Return _tipomovimiento
        End Get
        Set(ByVal value As String)
            _tipomovimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdFlujoCaja() As String
        Get
            Return _idflujocaja
        End Get
        Set(ByVal value As String)
            _idflujocaja = value
            RaiseEvent DatoCambiado()
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
    Public Property IdDocumento() As String
        Get
            Return _iddocumento
        End Get
        Set(ByVal value As String)
            _iddocumento = value
            RaiseEvent DatoCambiado()
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
    Public Property Periodo() As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
        End Set
    End Property

    <DataMember()> _
    Public Property SerieDoc() As String
        Get
            Return _serieocumento
        End Get
        Set(ByVal value As String)
            _serieocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroDoc() As String
        Get
            Return _nrodocumento
        End Get
        Set(ByVal value As String)
            _nrodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoDocumento() As String
        Get
            Return _idtipodoc
        End Get
        Set(ByVal value As String)
            _idtipodoc = value
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
    Public Property IdProveedor() As String
        Get
            Return _idproveedor
        End Get
        Set(ByVal value As String)
            _idproveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property Proveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
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
    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
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
    Public Property SubTotal() As Double
        Get
            Return _subtotaldoc
        End Get
        Set(ByVal value As Double)
            _subtotaldoc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IGV() As Double
        Get
            Return _igvdoc
        End Get
        Set(ByVal value As Double)
            _igvdoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
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
    Public Property IdGrupo() As String
        Get
            Return _idgrupo
        End Get
        Set(ByVal value As String)
            _idgrupo = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroGrupo() As String
        Get
            Return _nrogrupo
        End Get
        Set(ByVal value As String)
            _nrogrupo = value
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
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Destino() As String
        Get
            Return _destino
        End Get
        Set(ByVal value As String)
            _destino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDestino() As String
        Get
            Return _iddestino
        End Get
        Set(ByVal value As String)
            _iddestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property Origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrigen() As String
        Get
            Return _idorigen
        End Get
        Set(ByVal value As String)
            _idorigen = value
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
    Public Property IdCopiloto() As String
        Get
            Return _idCopiloto
        End Get
        Set(ByVal value As String)
            _idCopiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Vehiculo() As String
        Get
            Return _vehiculo
        End Get
        Set(ByVal value As String)
            _vehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoVehiculo() As String
        Get
            Return _idtipovehiculo
        End Get
        Set(ByVal value As String)
            _idtipovehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Piloto() As String
        Get
            Return _Piloto
        End Get
        Set(ByVal value As String)
            _Piloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPiloto() As String
        Get
            Return _idPiloto
        End Get
        Set(ByVal value As String)
            _idPiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Viaje() As String
        Get
            Return _viaje
        End Get
        Set(ByVal value As String)
            _viaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndGasto As Integer
        Get
            Return _IndGasto
        End Get
        Set(ByVal value As Integer)
            _IndGasto = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idestado = String.Empty
        _idviaje = String.Empty
        _tipodocumento = String.Empty
        _proveedor = String.Empty
        _glosa = String.Empty
        _total = 0
        _fechaemision = #1/1/1901#
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
        TipoOperacion = String.Empty
        TipoMovimiento = 1
        _moneda = ""
        _periodo = Date.Now.Month & "/" & Date.Now.Year
        _idgrupo = String.Empty
        _nrogrupo = String.Empty
        _indalmacen = False
        _idtrabajadorautoriza = ""
        _IndGasto = 0
        IdTarjetaMovimiento = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ls_TipoMovimiento As String _
              , ByVal ls_IdFlujoCaja As String _
              , ByVal ls_FlujoCaja As String _
              , ByVal ls_IdDocumento As String _
              , ByVal ls_IdPeriodo As String _
              , ByVal ls_Periodo As String _
              , ByVal ls_SerieDoc As String _
              , ByVal ls_NroDoc As String _
              , ByVal ls_IdTipoDoc As String _
              , ByVal ls_TipoDoc As String _
              , ByVal ls_IdViaje As String _
              , ByVal ls_IdProveedor As String _
              , ByVal ls_Proveedor As String _
              , ByVal ls_Glosa As String _
              , ByVal ln_TipoCambio As Double _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_Moneda As String _
              , ByVal ln_SubTotal As Double _
              , ByVal ln_Igv As Double _
              , ByVal ln_Total As Double _
              , ByVal ls_IdEstado As String _
              , ByVal ls_IdGrupo As String _
              , ByVal ls_NroGrupo As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_Activo As Boolean _
              , ByVal ld_Fecha As Date _
              , ByVal ls_Viaje As String _
              , ByVal ls_IdPiloto As String _
              , ByVal ls_Piloto As String _
              , ByVal ls_IdTipoVehiculo As String _
              , ByVal ls_Vehiculo As String _
              , ByVal ls_IdCopiloto As String _
              , ByVal ls_Copiloto As String _
              , ByVal ls_IdOrigen As String _
              , ByVal ls_Origen As String _
              , ByVal ls_IdDestino As String _
              , ByVal ls_Destino As String _
              , ByVal ls_Estado As String _
              , ByVal ls_Ruta As String _
              , ByVal lsIdAsiento As String _
              , ByVal lb_IndAlmacen As Boolean _
              , ByVal ls_IdTrabajadorAutoriza As String _
              , ByVal ls_TrabajadorAutoriza As String _
              , ByVal ln_IndGasto As Integer _
              , ByVal ls_IdTarjetaMovimiento As String)
        _id = ls_Id
        _idcuentacorriente = ls_IdCuentaCorriente
        _tipomovimiento = ls_TipoMovimiento
        _idflujocaja = ls_IdFlujoCaja
        _flujocaja = ls_FlujoCaja
        _idperiodo = ls_IdPeriodo
        _periodo = ls_Periodo
        _iddocumento = ls_IdDocumento
        _serieocumento = ls_SerieDoc
        _nrodocumento = ls_NroDoc
        _idtipodoc = ls_IdTipoDoc
        _tipodocumento = ls_TipoDoc
        _idviaje = ls_IdViaje
        _idproveedor = ls_IdProveedor
        _proveedor = ls_Proveedor
        _glosa = ls_Glosa
        _tipocambio = ln_TipoCambio
        _idmoneda = ls_IdMoneda
        _moneda = ls_Moneda
        _subtotaldoc = ln_SubTotal
        _igvdoc = ln_Igv
        _total = ln_Total
        _idestado = ls_IdEstado
        _idgrupo = ls_IdGrupo
        _nrogrupo = ls_NroGrupo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = ls_Activo
        _fechaemision = ld_Fecha
        _viaje = ls_Viaje
        _idPiloto = ls_IdPiloto
        _Piloto = ls_Piloto
        _idtipovehiculo = ls_IdTipoVehiculo
        _vehiculo = ls_Vehiculo
        _idCopiloto = ls_Copiloto
        _idorigen = ls_Origen
        _origen = ls_Origen
        _iddestino = ls_Destino
        _estado = ls_Estado
        _ruta = ls_Ruta
        IdAsiento = lsIdAsiento
        _indalmacen = lb_IndAlmacen
        _idtrabajadorautoriza = ls_IdTrabajadorAutoriza
        _trabajadorautoriza = ls_TrabajadorAutoriza
        _IndGasto = ln_IndGasto
        IdTarjetaMovimiento = ls_IdTarjetaMovimiento
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeGastoOperacion As e_GastoOperacion) _
    As Boolean Implements IEquatable(Of e_GastoOperacion).Equals
        If Me.Id = oeGastoOperacion.Id Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal gastoOperacion As e_GastoOperacion) As e_GastoOperacion Implements Ie_GastoOperacion.Obtener
        Return gastoOperacion
    End Function

#End Region

End Class

