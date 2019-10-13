


<DataContract()> _
Public Class e_Movimiento_Flete
    Implements Ie_Movimiento_Flete

#Region "Propiedad"

    Private _id As String
    Private _idoperaciondetalle As String
    Private _operaciondetalle As String
    Private _idmovimiento As String
    Private _depositado As Decimal
    Private _egresado As Decimal
    Private _ingreso As Decimal
    Private _fecmov As Date
    Private _glosamov As String
    Private _idcheque As String
    Private _nrocheque As String
    Private _tipocobro As Boolean
    Private _idviaje As String
    Private _viaje As String
    Private _fecha As Date
    Private _origen As String
    Private _destino As String
    Private _idTrabajador As String
    Private _Trabajador As String
    Private _apepatTrabajador As String
    Private _apematTrabajador As String
    Private _nomTrabajador As String
    Private _Glosa As String
    Private _saldopordepositar As Decimal

    Private _Importe As Decimal
    Private _idCliente As String
    Private _Cliente As String
    Private _Carga As String
    Private _IdGrupo As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    <DataMember()>
    Public oeChequeCobrar As New e_ChequexCobrar

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
    Public Property IdOperacionDetalle() As String
        Get
            Return _idoperaciondetalle
        End Get
        Set(ByVal value As String)
            _idoperaciondetalle = value
            RaiseEvent DatoCambiado()
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
    Public Property IdCheque() As String
        Get
            Return _idcheque
        End Get
        Set(ByVal value As String)
            _idcheque = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroCheque() As String
        Get
            Return _nrocheque
        End Get
        Set(ByVal value As String)
            _nrocheque = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCobro() As Boolean
        Get
            Return _tipocobro
        End Get
        Set(ByVal value As Boolean)
            _tipocobro = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosamov
        End Get
        Set(ByVal value As String)
            _glosamov = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idTrabajador
        End Get
        Set(ByVal value As String)
            _idTrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property ApellidoPaterno() As String
        Get
            Return _apepatTrabajador
        End Get
        Set(ByVal value As String)
            _apepatTrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property ApellidoMaterno() As String
        Get
            Return _apematTrabajador
        End Get
        Set(ByVal value As String)
            _apematTrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nomTrabajador
        End Get
        Set(ByVal value As String)
            _nomTrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _Trabajador
        End Get
        Set(ByVal value As String)
            _Trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _idviaje
        End Get
        Set(ByVal value As String)
            _idviaje = value
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
    Public Property Cobrado() As Decimal
        Get
            Return _ingreso
        End Get
        Set(ByVal value As Decimal)
            _ingreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cargado() As Decimal
        Get
            Return _egresado
        End Get
        Set(ByVal value As Decimal)
            _egresado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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
    Public Property Origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Depositado() As Decimal
        Get
            Return _depositado
        End Get
        Set(ByVal value As Decimal)
            _depositado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Flete() As String
        Get
            Return _operaciondetalle
        End Get
        Set(ByVal value As String)
            _operaciondetalle = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoPorDepositar() As Decimal
        Get
            Return _saldopordepositar
        End Get
        Set(ByVal value As Decimal)
            _saldopordepositar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Carga() As String
        Get
            Return _Carga
        End Get
        Set(ByVal value As String)
            _Carga = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idCliente
        End Get
        Set(ByVal value As String)
            _idCliente = value
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
    Public Property IdGrupo() As String
        Get
            Return _IdGrupo
        End Get
        Set(ByVal value As String)
            _IdGrupo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idoperaciondetalle = String.Empty
        _idmovimiento = String.Empty
        _idcheque = String.Empty
        _idviaje = ""
        _fecmov = #1/1/1990#
        _tipocobro = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdOperacionDetalle As String _
              , ByVal ls_IdMovimiento As String _
              , ByVal ls_IdCheque As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_Cargado As Decimal _
              , ByVal ls_Cobrado As Decimal _
              , ByVal ls_IdViaje As String _
              , ByVal ls_Viaje As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_ApellidoPaterno As String _
              , ByVal ls_ApellidoMaterno As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_Glosa As String _
              , ByVal ls_NumeroCheque As String _
              , ByVal lb_TipoCobro As Boolean _
              , ByVal ls_Origen As String _
              , ByVal ls_Destino As String _
              , ByVal ls_Flete As Decimal _
              , ByVal ls_Depositado As Decimal _
              , ByVal ls_SaldoPorDepositar As Decimal _
              , ByVal ls_IdCliente As String _
              , ByVal ls_Cliente As String _
              , ByVal ls_Carga As String _
              , ByVal ls_Importe As Decimal _
              , ByVal ls_IdGrupo As String _
           )

        _id = ls_Id
        _idoperaciondetalle = ls_IdOperacionDetalle
        _idmovimiento = ls_IdMovimiento
        _idcheque = ls_IdCheque
        _fecha = ld_Fecha
        _egresado = ls_Cargado
        _ingreso = ls_Cobrado
        _idviaje = ls_IdViaje
        _viaje = ls_Viaje
        _idTrabajador = ls_IdTrabajador
        _apepatTrabajador = ls_ApellidoPaterno
        _apematTrabajador = ls_ApellidoMaterno
        _nomTrabajador = ls_Nombre
        _Trabajador = ls_Trabajador
        _glosamov = ls_Glosa
        _nrocheque = ls_NumeroCheque
        _tipocobro = lb_TipoCobro
        _origen = ls_Origen
        _destino = ls_Destino
        _operaciondetalle = ls_Flete
        _depositado = ls_Depositado
        _saldopordepositar = ls_SaldoPorDepositar
        _idCliente = ls_Cliente
        _Cliente = ls_Cliente
        _Carga = ls_Carga
        _Importe = ls_Importe
        _IdGrupo = ls_IdGrupo

    End Sub

#End Region

    Public Function Obtener(ByVal movimiento_Flete As e_Movimiento_Flete) As e_Movimiento_Flete Implements Ie_Movimiento_Flete.Obtener
        Return movimiento_Flete
    End Function

End Class

