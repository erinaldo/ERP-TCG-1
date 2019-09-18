''' <summary>
''' Entidad para el almacenar información del objeto para el Registro de Consumo de combustibles
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_RegistroConsumoCombustible
    Implements Ie_RegistroConsumoCombustible

#Region "Declaración de variables"

    Private _Seleccion As Boolean
    Private _id As String
    Private _idViaje As String
    Private _Viaje As String
    Private _fecViaje As Date
    Private _idpiloto As String
    Private _piloto As String
    Private _idVehiculo As String
    Private _Vehiculo As String
    Private _fechatanqueo As Date = #1/1/1901#
    Private _cantidadgalon As Double
    Private _kilometrostanqueo As Double
    Private _nrovale As String
    Private _indcredito As Boolean
    Private _indtanqueo As Boolean
    Private _preciounitario As Double
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _idGrifo As String
    Private _Activo As Boolean
    Private _IdDireccion As String
    Private _idMaterial As String
    Private _Material As String
    Private _codMaterial As String
    Private _SaldoGls As Double
    Private _Estado As String
    Private _idLugar As String
    Private _indTanqueoNoAsoc As Boolean
    Private _indisl As Boolean
    Private _glosavaletanqueo As String


    <DataMember()> _
    Public lstInventario As List(Of e_Inventario)
    <DataMember()> _
    Public IdAlmacen As String
    <DataMember()> _
    Public IdSubAlmacen As String
    <DataMember()> _
    Public CodigoSurtidor As String
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    'Fechas de Control de Registros para intervalo.
    <DataMember()> _
    Public fechaFin As Date
    <DataMember()> _
    Public fechaInicio As Date
    <DataMember()> _
    Public Ind_GastoViaje As Integer
    <DataMember()> _
    Public Ind_Masivo As Boolean
    <DataMember()> _
    Public ListaRegistrosConsumoD2 As List(Of e_RegistroConsumoCombustible)
    <DataMember()> _
    Public leRendimiento As List(Of e_RendimientoCombustible)
    <DataMember()> _
    Public leRutas As List(Of e_Ruta)
    <DataMember()> _
    Public leZonaD2 As List(Of e_ZonaCombustible)
    <DataMember()> _
    Public GalonajeAntiguo As Double

    <DataMember()> _
    Public LOrigen As String
    <DataMember()> _
    Public LDestino As String
    <DataMember()> _
    Public Pilotos As String
    <DataMember()> _
    Public TipoVehiculos As String
    <DataMember()> _
    Public Flotas As String
    <DataMember()> _
    Public _nomGrifo As String
    <DataMember()> _
    Public _nomDireccion As String
    <DataMember()> _
    Public _nomLugar As String
    <DataMember()> _
    Public Glosa As String
    <DataMember()> _
    Public Perfil As String

    <DataMember()> _
    Public IdFlota As String = ""

    <DataMember()> _
    Public IdZona As String = ""

    <DataMember()> _
    Public IdMarca As String = ""

    '<DataMember()> _
    'Public oeOrden As e_Orden

    <DataMember()> _
    Public IdModelo As String = ""

    Private oeRegistroInventario As String

    Public Event DatoCambiado()
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        IndTanqueo = True
        CodigoSurtidor = ""
        IndIsl = False
        FechaCreacion = Date.Parse("01/01/1901")
        GlosaValeTanqueo = ""
    End Sub

    ''' <summary>
    ''' Crear un objeto para el Registro de Consumo de combustibles
    ''' </summary>
    ''' <param name="ls_Id"></param>
    ''' <param name="ls_IdViaje"></param>
    ''' <param name="ls_CodViaje"></param>
    ''' <param name="ls_IdVehiculo"></param>
    ''' <param name="ld_FechaTanqueo"></param>
    ''' <param name="ln_CantidadGalon"></param>
    ''' <param name="ln_KilometrosTanqueo"></param>
    ''' <param name="ls_NroVale"></param>
    ''' <param name="lb_IndCredito"></param>
    ''' <param name="lb_IndTanqueo"></param>
    ''' <param name="ls_idGrifo"></param>
    ''' <param name="ls_idLugar"></param>
    ''' <param name="ls_idDireccion"></param>
    ''' <param name="ls_idMaterial"></param>
    ''' <param name="ln_SaldoGls"></param>
    ''' <param name="ls_Estado"></param>
    ''' <param name="ln_Activo"></param>
    ''' <param name="ls_UsuarioCreacion"></param>
    ''' <param name="ls_PlacaVeh"></param>
    ''' <param name="ls_IdRegistroInventario"></param>
    ''' <param name="ls_IdPiloto"></param>
    ''' <param name="ls_NomPiloto"></param>
    ''' <remarks></remarks>

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdViaje As String _
              , ByVal ls_CodViaje As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ld_FechaTanqueo As Date _
              , ByVal ln_CantidadGalon As Double _
              , ByVal ln_KilometrosTanqueo As Double _
              , ByVal ls_NroVale As String _
              , ByVal lb_IndCredito As Boolean _
              , ByVal lb_IndTanqueo As Boolean _
              , ByVal ls_idGrifo As String _
              , ByVal ls_NomGrifo As String _
              , ByVal ls_idLugar As String _
              , ByVal ls_NomLugar As String _
              , ByVal ls_idDireccion As String _
              , ByVal ls_NomDireccion As String _
              , ByVal ls_idMaterial As String _
              , ByVal ln_SaldoGls As Double _
              , ByVal ls_Estado As String _
              , ByVal ln_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_IndIsl As Boolean _
              , ByVal ls_PlacaVeh As String _
              , ByVal ls_IdRegistroInventario As String _
              , ByVal ls_IdPiloto As String _
              , ByVal ls_NomPiloto As String _
              , ByVal ld_PrecioUnitario As Double _
              , ByVal ls_GlosaValeTanqueo As String _
    )
        _id = ls_Id
        _idViaje = ls_IdViaje
        _Viaje = ls_CodViaje
        _idVehiculo = ls_IdVehiculo
        _fechatanqueo = ld_FechaTanqueo
        _cantidadgalon = ln_CantidadGalon
        _kilometrostanqueo = ln_KilometrosTanqueo
        _nrovale = ls_NroVale
        _indcredito = lb_IndCredito
        _indtanqueo = lb_IndTanqueo
        _idGrifo = ls_idGrifo
        _idLugar = ls_idLugar
        _IdDireccion = ls_idDireccion
        _idMaterial = ls_idMaterial
        _SaldoGls = ln_SaldoGls
        _Estado = ls_Estado
        _Activo = ln_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _nomGrifo = ls_NomGrifo
        _nomLugar = ls_NomLugar
        _nomDireccion = ls_NomDireccion
        _Vehiculo = ls_PlacaVeh
        oeRegistroInventario = ls_IdRegistroInventario
        _idpiloto = ls_IdPiloto
        _indisl = lb_IndIsl
        _piloto = ls_NomPiloto
        _preciounitario = ld_PrecioUnitario
        _glosavaletanqueo = ls_GlosaValeTanqueo
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
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
    Public Property NomGrifo() As String
        Get
            Return _nomGrifo
        End Get
        Set(ByVal value As String)
            _nomGrifo = value
        End Set
    End Property

    <DataMember()> _
    Public Property NomDireccion() As String
        Get
            Return _nomDireccion
        End Get
        Set(ByVal value As String)
            _nomDireccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property NomLugar() As String
        Get
            Return _nomLugar
        End Get
        Set(ByVal value As String)
            _nomLugar = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRegistroInventario() As String
        Get
            Return oeRegistroInventario
        End Get
        Set(ByVal value As String)
            oeRegistroInventario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idVehiculo
        End Get
        Set(ByVal value As String)
            _idVehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndIsl() As Boolean
        Get
            Return _indisl
        End Get
        Set(ByVal value As Boolean)
            _indisl = value
        End Set
    End Property

    <DataMember()> _
    Public Property Piloto() As String
        Get
            Return _piloto
        End Get
        Set(ByVal value As String)
            _piloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaTanqueo() As Date
        Get
            Return _fechatanqueo
        End Get
        Set(ByVal value As Date)
            _fechatanqueo = value
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
        End Set
    End Property

    <DataMember()> _
    Public Property FechaViaje() As Date
        Get
            Return _fecViaje
        End Get
        Set(ByVal value As Date)
            _fecViaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadGalon() As Double
        Get
            Return _cantidadgalon
        End Get
        Set(ByVal value As Double)
            _cantidadgalon = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property KilometrosTanqueo() As Double
        Get
            Return _kilometrostanqueo
        End Get
        Set(ByVal value As Double)
            _kilometrostanqueo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroVale() As String
        Get
            Return _nrovale
        End Get
        Set(ByVal value As String)
            _nrovale = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndCredito() As Boolean
        Get
            Return _indcredito
        End Get
        Set(ByVal value As Boolean)
            _indcredito = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndTanqueo() As Boolean
        Get
            Return _indtanqueo
        End Get
        Set(ByVal value As Boolean)
            _indtanqueo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitario() As Double
        Get
            Return _preciounitario
        End Get
        Set(ByVal value As Double)
            _preciounitario = value
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
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _idViaje
        End Get
        Set(ByVal value As String)
            _idViaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodViaje() As String
        Get
            Return _Viaje
        End Get
        Set(ByVal value As String)
            _Viaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPiloto() As String
        Get
            Return _idpiloto
        End Get
        Set(ByVal value As String)
            _idpiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdGrifo() As String
        Get
            Return _idGrifo
        End Get
        Set(ByVal value As String)
            _idGrifo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDireccion() As String
        Get
            Return _IdDireccion
        End Get
        Set(ByVal value As String)
            _IdDireccion = value
        End Set
    End Property


    <DataMember()> _
    Public Property IdLugar() As String
        Get
            Return _idLugar
        End Get
        Set(ByVal value As String)
            _idLugar = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idMaterial
        End Get
        Set(ByVal value As String)
            _idMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodMaterial() As String
        Get
            Return _codMaterial
        End Get
        Set(ByVal value As String)
            _codMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _Material
        End Get
        Set(ByVal value As String)
            _Material = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoGls() As Double
        Get
            Return _SaldoGls
        End Get
        Set(ByVal value As Double)
            _SaldoGls = value
        End Set
    End Property

    <DataMember()> _
    Public Property PlacaVeh() As String
        Get
            Return _Vehiculo
        End Get
        Set(ByVal value As String)
            _Vehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTanqueoNoAsoc() As Boolean
        Get
            Return _indTanqueoNoAsoc
        End Get
        Set(ByVal value As Boolean)
            _indTanqueoNoAsoc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property GlosaValeTanqueo() As String
        Get
            Return _glosavaletanqueo
        End Get
        Set(ByVal value As String)
            _glosavaletanqueo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal registroConsumoCombustible As e_RegistroConsumoCombustible) As e_RegistroConsumoCombustible Implements Ie_RegistroConsumoCombustible.Obtener
        Return registroConsumoCombustible
    End Function

End Class
