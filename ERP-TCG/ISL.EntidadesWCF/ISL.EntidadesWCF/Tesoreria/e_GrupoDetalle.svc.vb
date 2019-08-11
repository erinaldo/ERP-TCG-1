


<DataContract()> _
Public Class e_GrupoDetalle
    Implements Ie_GrupoDetalle
    Implements IEquatable(Of e_GrupoDetalle)

#Region "Definición de variables"
    Private _id As String
    Private _idgrupo As String
    Private _idgastooperacion As String
    Private _activo As Boolean
    Private _IndFlete As Integer

    Private _idviaje As String
    Private _viaje As String
    Private _idtrabajador As String
    Private _trabajador As String
    Private _importe As Double
    Private _saldo As Double
    Private _estado As String
    Private _fechaemision As Date
    Private _idorigen As String
    Private _iddestino As String
    Private _ruta As String
    Private _idcopiloto As String
    Private _copiloto As String
    Private _nrogrupo As String
    Private _idvehiculo As String
    Private _vehiculo As String
    Private _glosa As String
    Private _usuario As String
    'flete
    Private _flete As Decimal
    Private _cargado As String
    Private _depositado As Decimal
    Private _SaldoPorDepositar As Decimal
    Private _idCliente As String
    Private _Cliente As String
    Private _Carga As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()> _
    Public IdCaja As String = ""

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
    Public Property IdGrupo() As String
        Get
            Return _idgrupo
        End Get
        Set(ByVal value As String)
            _idgrupo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdGastoOperacion() As String
        Get
            Return _idgastooperacion
        End Get
        Set(ByVal value As String)
            _idgastooperacion = value
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
    Public Property IndFlete() As Integer
        Get
            Return _IndFlete
        End Get
        Set(ByVal value As Integer)
            _IndFlete = value
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
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
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
    Public Property FechaEmision() As Date
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Date)
            _fechaemision = value
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
    Public Property IdDestino() As String
        Get
            Return _iddestino
        End Get
        Set(ByVal value As String)
            _iddestino = value
        End Set
    End Property

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
    Public Property IdCopiloto() As String
        Get
            Return _idcopiloto
        End Get
        Set(ByVal value As String)
            _idcopiloto = value
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
    Public Property NroGrupo() As String
        Get
            Return _nrogrupo
        End Get
        Set(ByVal value As String)
            _nrogrupo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
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
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    <DataMember()> _
    Public Property Flete() As Decimal
        Get
            Return _flete
        End Get
        Set(ByVal value As Decimal)
            _flete = value
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
    Public Property Cargado() As String
        Get
            Return _cargado
        End Get
        Set(ByVal value As String)
            _cargado = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoPorDepositar() As Decimal
        Get
            Return _SaldoPorDepositar
        End Get
        Set(ByVal value As Decimal)
            _SaldoPorDepositar = value
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


#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _activo = True
        _IndFlete = 0
        _importe = 0
        _idcopiloto = ""
        _copiloto = ""
        _idvehiculo = ""
        _vehiculo = ""
        _idtrabajador = ""
        _trabajador = ""
        _idorigen = ""
        _iddestino = ""
        _ruta = ""
        _idviaje = ""
        _viaje = ""
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdGrupo As String _
              , ByVal ls_IdGastoOperacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdViaje As String _
              , ByVal ls_Viaje As String _
              , ByVal ls_IdPiloto As String _
              , ByVal ls_Piloto As String _
              , ByVal ln_Importe As Double _
              , ByVal ls_Estado As String _
              , ByVal ld_FechaEmision As Date _
              , ByVal ls_IdOrigen As String _
              , ByVal ls_IdDestino As String _
              , ByVal ls_Ruta As String _
              , ByVal ls_IdCopiloto As String _
              , ByVal ls_Copiloto As String _
              , ByVal ls_NroGrupo As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ls_Vehiculo As String _
              , ByVal ls_Usuario As String _
              , ByVal ld_Saldo As Double _
              , ByVal ls_Glosa As String _
              , ByVal ld_Flete As Decimal _
              , ByVal ld_Cargado As Decimal _
              , ByVal ld_Depositado As Decimal _
              , ByVal ld_SaldoPorDepositar As Decimal _
                           )
        _id = ls_Id
        _idgrupo = ls_IdGrupo
        _idgastooperacion = ls_IdGastoOperacion
        _activo = lb_Activo

        _idviaje = ls_IdViaje
        _viaje = ls_Viaje
        _idtrabajador = ls_IdPiloto
        _trabajador = ls_Piloto
        _importe = ln_Importe
        _estado = ls_Estado
        _fechaemision = ld_FechaEmision
        _idorigen = ls_IdOrigen
        _iddestino = ls_IdDestino
        _ruta = ls_Ruta
        _idcopiloto = ls_IdCopiloto
        _copiloto = ls_Copiloto
        _nrogrupo = ls_NroGrupo
        _idvehiculo = ls_IdVehiculo
        _vehiculo = ls_Vehiculo
        _usuario = ls_Usuario
        _saldo = ld_Saldo
        _glosa = ls_Glosa
        _flete = ld_Flete
        _cargado = ld_Cargado
        _depositado = ld_Depositado
        _SaldoPorDepositar = ld_SaldoPorDepositar
    End Sub

#End Region

#Region "Metodo"

    Public Overloads Function Equals(ByVal oeGrupoDetalle As e_GrupoDetalle) _
    As Boolean Implements System.IEquatable(Of e_GrupoDetalle).Equals
        If Me.IdGastoOperacion = oeGrupoDetalle.IdGastoOperacion Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal grupoDetalle As e_GrupoDetalle) As e_GrupoDetalle Implements Ie_GrupoDetalle.Obtener
        Return grupoDetalle
    End Function

#End Region

End Class

