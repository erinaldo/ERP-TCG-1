

''' <summary>
''' Clase de tipo entidad para administrar la información de Demanda
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Demanda
    Implements Ie_Demanda

#Region "Declaracion de Variables"

    Private _Seleccion As Boolean
    Private _Id As String
    Private _Codigo As String
    Private _idPreDemanda As String
    Private _PreDemanda As String
    Private _Observacion As String
    Private _idRuta As String
    Private _Ruta As String
    Private _idTipoVehiculo As String
    Private _TipoVehiculo As String
    Private _Centro As String
    Private _idEstado As String
    Private _Estado As String
    Private _TotalFlete As Decimal
    Private _TotalComison As Decimal
    Private _Activo As Boolean
    Private _idUsuario As String
    Private _idCliente As String
    Private _Cliente As String
    Private _Comisionista As String
    Private _Comision As Decimal
    Private _Facturado As Boolean
    Private _PagoContraEntrega As Boolean

    Private _FechaAtendida As Date
    Private _CargaMaterial As String
    Private _Zona As String
    'Tania
    Private _indicador As Integer
    Private _fechaSolicita As Date
    Private _fechaRecepcion As Date
    Private _idOrigen As String
    Private _idDestino As String
    Private _fechaCambioADemanda As Date
    Private _observacionPredemanda As String
    Private _estadoPredemanda As String
    Private _fechaCancelacion As Date
    Private _justificacion As String
    Private _idLugarReferencia As String
    Private _nroUnidades As Integer
    Private _idDireccionLugarPartida As String
    Private _idDireccionLugarLlegada As String
    Private _idEscala As String
    Private _idUsuarioCancelacion As String
    Private _motivoEscala As String
    Private _escala As String
    Private _tipo As String

    Private _indicadorTercero As Boolean
    Private _IndEnvioCorreo As Boolean

    ' Variables Publicas

    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String

    <DataMember()> _
    Public NroDemanda As Integer
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Proceso As String
    <DataMember()> _
    Public oeDetalleDemanda As New List(Of e_DemandaDetalle)
    <DataMember()> _
    Public oeContratoTercero As New List(Of e_ViajesTerceros)

    <DataMember()> _
    Public oeListaBitacora As New List(Of e_Bitacora)

    <DataMember()> _
    Public oeIncidenciaAutentificadas As New e_IncidenciasAutentificadas

    Public Event DatoCambiado()
    Private _Modificado As Boolean = False

#End Region

#Region "Constructor"

    ''' <summary>
    ''' Crea una nueva demanda vacía
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        Id = ""
        Activo = True
        UsuarioCreacion = ""
        Zona = ""
    End Sub

    ''' <summary>
    ''' Crea una nueva demanda a partir de datos básicos
    ''' </summary>
    ''' <param name="lb_Seleccion"></param>
    ''' <param name="ls_Id"></param>
    ''' <param name="ls_Codigo"></param>
    ''' <param name="ls_IdPreDemanda"></param>
    ''' <param name="ls_CodigoPreDemanda"></param>
    ''' <param name="ls_IdRuta"></param>
    ''' <param name="ls_Ruta"></param>
    ''' <param name="ls_IdTipoVehiculo"></param>
    ''' <param name="ls_TipoVehiculo"></param>
    ''' <param name="ls_IdEstado"></param>
    ''' <param name="ls_Estado"></param>
    ''' <param name="ld_FechaAtendida"></param>
    ''' <param name="ln_TotalFlete"></param>
    ''' <param name="ln_TotalComision"></param>
    ''' <param name="ls_Observacion"></param>
    ''' <param name="lb_Activo"></param>
    ''' <param name="ls_IdCliente"></param>
    ''' <param name="ls_Cliente"></param>
    ''' <param name="ls_Comisionista"></param>
    ''' <param name="ln_Comision"></param>
    ''' <param name="lb_Facturado"></param>
    ''' <param name="lb_PagoContraEntrega"></param>
    ''' <param name="ls_Zona"></param>
    ''' <param name="ls_CargaMaterial"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal lb_Seleccion As Boolean, _
                   ByVal ls_Id As String, _
                   ByVal ls_Codigo As String, _
                   ByVal ls_IdPreDemanda As String, _
                   ByVal ls_CodigoPreDemanda As String, _
                   ByVal ls_IdRuta As String, _
                   ByVal ls_Ruta As String, _
                   ByVal ls_IdTipoVehiculo As String, _
                   ByVal ls_TipoVehiculo As String, _
                   ByVal ls_IdEstado As String, _
                   ByVal ls_Estado As String, _
                   ByVal ld_FechaAtendida As Date, _
                   ByVal ln_TotalFlete As Decimal, _
                   ByVal ln_TotalComision As Decimal, _
                   ByVal ls_Observacion As String, _
                   ByVal lb_Activo As Boolean, _
                   ByVal ls_IdCliente As String, _
                   ByVal ls_Cliente As String, _
                   ByVal ls_Comisionista As String, _
                   ByVal ln_Comision As Double, _
                   ByVal lb_Facturado As Boolean, _
                   ByVal lb_PagoContraEntrega As Boolean, _
                   ByVal ls_Zona As String, _
                   ByVal ls_CargaMaterial As String)
        _Seleccion = lb_Seleccion
        _Id = ls_Id
        _Codigo = ls_Codigo
        _idPreDemanda = ls_IdPreDemanda
        _PreDemanda = ls_CodigoPreDemanda
        _idRuta = ls_IdRuta
        _Ruta = ls_Ruta
        _idTipoVehiculo = ls_IdTipoVehiculo
        _TipoVehiculo = ls_TipoVehiculo
        _idEstado = ls_IdEstado
        _Estado = ls_Estado
        _FechaAtendida = ld_FechaAtendida
        _TotalFlete = ln_TotalFlete
        _TotalComison = ln_TotalComision
        _Observacion = ls_Observacion
        _Activo = lb_Activo
        _idCliente = ls_IdCliente
        _Cliente = ls_Cliente
        _Comisionista = ls_Comisionista
        _Comision = ln_Comision
        _Facturado = lb_Facturado
        _PagoContraEntrega = lb_PagoContraEntrega
        _Zona = ls_Zona
        _CargaMaterial = ls_CargaMaterial
    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean, _
                   ByVal ls_Id As String, _
                   ByVal ls_Codigo As String, _
                   ByVal ls_IdPreDemanda As String, _
                   ByVal ls_CodigoPreDemanda As String, _
                   ByVal ls_IdRuta As String, _
                   ByVal ls_Ruta As String, _
                   ByVal ls_IdTipoVehiculo As String, _
                   ByVal ls_TipoVehiculo As String, _
                   ByVal ls_IdEstado As String, _
                   ByVal ls_Estado As String, _
                   ByVal ld_FechaAtendida As Date, _
                   ByVal ln_TotalFlete As Decimal, _
                   ByVal ln_TotalComision As Decimal, _
                   ByVal ls_Observacion As String, _
                   ByVal lb_Activo As Boolean, _
                   ByVal ls_IdCliente As String, _
                   ByVal ls_Cliente As String, _
                   ByVal ls_Comisionista As String, _
                   ByVal ln_Comision As Double, _
                   ByVal lb_Facturado As Boolean, _
                   ByVal lb_PagoContraEntrega As Boolean, _
                   ByVal ls_Zona As String, _
                   ByVal ls_CargaMaterial As String, _
                   ByVal ls_motivoEscala As String, _
                   ByVal ls_idEscala As String, _
                   ByVal ls_observacionpredemanda As String)
        _Seleccion = lb_Seleccion
        _Id = ls_Id
        _Codigo = ls_Codigo
        _idPreDemanda = ls_IdPreDemanda
        _PreDemanda = ls_CodigoPreDemanda
        _idRuta = ls_IdRuta
        _Ruta = ls_Ruta
        _idTipoVehiculo = ls_IdTipoVehiculo
        _TipoVehiculo = ls_TipoVehiculo
        _idEstado = ls_IdEstado
        _Estado = ls_Estado
        _FechaAtendida = ld_FechaAtendida
        _TotalFlete = ln_TotalFlete
        _TotalComison = ln_TotalComision
        _Observacion = ls_Observacion
        _Activo = lb_Activo
        _idCliente = ls_IdCliente
        _Cliente = ls_Cliente
        _Comisionista = ls_Comisionista
        _Comision = ln_Comision
        _Facturado = lb_Facturado
        _PagoContraEntrega = lb_PagoContraEntrega
        _Zona = ls_Zona
        _CargaMaterial = ls_CargaMaterial
        _motivoEscala = ls_motivoEscala
        _idEscala = ls_idEscala
        _observacionPredemanda = ls_observacionpredemanda
    End Sub

#End Region

#Region "Propiedades" 

    <DataMember()> _
    Public Property FechaCambioADemanda() As Date
        Get
            Return _fechaCambioADemanda
        End Get
        Set(ByVal value As Date)
            _fechaCambioADemanda = value
        End Set
    End Property
    <DataMember()> _
    Public Property ObservacionPredemanda() As String
        Get
            Return _observacionPredemanda
        End Get
        Set(ByVal value As String)
            _observacionPredemanda = value
        End Set
    End Property
    <DataMember()> _
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property
    <DataMember()> _
    Public Property EstadoPredemanda() As String
        Get
            Return _estadoPredemanda
        End Get
        Set(ByVal value As String)
            _estadoPredemanda = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaCancelacion() As Date
        Get
            Return _fechaCancelacion
        End Get
        Set(ByVal value As Date)
            _fechaCancelacion = value
        End Set
    End Property



    <DataMember()> _
    Public Property Justificacion() As String
        Get
            Return _justificacion
        End Get
        Set(ByVal value As String)
            _justificacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdLugarReferencia() As String
        Get
            Return _idLugarReferencia
        End Get
        Set(ByVal value As String)
            _idLugarReferencia = value
        End Set
    End Property
    <DataMember()> _
    Public Property NroUnidades() As Integer
        Get
            Return _nroUnidades
        End Get
        Set(ByVal value As Integer)
            _nroUnidades = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdDireccionLugarPartida() As String
        Get
            Return _idDireccionLugarPartida
        End Get
        Set(ByVal value As String)
            _idDireccionLugarPartida = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDireccionLugarLlegada() As String
        Get
            Return _idDireccionLugarLlegada
        End Get
        Set(ByVal value As String)
            _idDireccionLugarLlegada = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEscala() As String
        Get
            Return _idEscala
        End Get
        Set(ByVal value As String)
            _idEscala = value
        End Set
    End Property
    <DataMember()> _
    Public Property Escala() As String
        Get
            Return _escala
        End Get
        Set(ByVal value As String)
            _escala = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdUsuarioCancelacion() As String
        Get
            Return _idUsuarioCancelacion
        End Get
        Set(ByVal value As String)
            _idUsuarioCancelacion = value
        End Set
    End Property

    'Tania
    <DataMember()> _
    Public Property Indicador() As Integer
        Get
            Return _indicador
        End Get
        Set(ByVal value As Integer)
            _indicador = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaSolicita() As Date
        Get
            Return _fechaSolicita
        End Get
        Set(ByVal value As Date)
            _fechaSolicita = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaRecepcion() As Date
        Get
            Return _fechaRecepcion
        End Get
        Set(ByVal value As Date)
            _fechaRecepcion = value
        End Set
    End Property
    <DataMember()> _
Public Property IdOrigen() As String
        Get
            Return _idOrigen
        End Get
        Set(ByVal value As String)
            _idOrigen = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdDestino() As String
        Get
            Return _idDestino
        End Get
        Set(ByVal value As String)
            _idDestino = value
        End Set
    End Property
    <DataMember()> _
    Public Property MotivoEscala() As String
        Get
            Return _motivoEscala
        End Get
        Set(ByVal value As String)
            _motivoEscala = value
        End Set
    End Property



    '''
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
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPreDemanda() As String
        Get
            Return _idPreDemanda
        End Get
        Set(ByVal value As String)
            _idPreDemanda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoPreDemanda() As String
        Get
            Return _PreDemanda
        End Get
        Set(ByVal value As String)
            _PreDemanda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdRuta() As String
        Get
            Return _idRuta
        End Get
        Set(ByVal value As String)
            _idRuta = value
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
    Public Property IdEstado() As String
        Get
            Return _idEstado
        End Get
        Set(ByVal value As String)
            _idEstado = value
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
    Public Property TotalFlete() As Decimal
        Get
            Return _TotalFlete
        End Get
        Set(ByVal value As Decimal)
            _TotalFlete = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TotalComision() As Decimal
        Get
            Return _TotalComison
        End Get
        Set(ByVal value As Decimal)
            _TotalComison = value
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
    Public Property Comision() As Decimal
        Get
            Return _Comision
        End Get
        Set(ByVal value As Decimal)
            _Comision = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Facturado() As Boolean
        Get
            Return _Facturado
        End Get
        Set(ByVal value As Boolean)
            _Facturado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PagoContraEntrega() As Boolean
        Get
            Return _PagoContraEntrega
        End Get
        Set(ByVal value As Boolean)
            _PagoContraEntrega = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As String)
            _idUsuario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaAtendida() As Date
        Get
            Return _FechaAtendida
        End Get
        Set(ByVal value As Date)
            _FechaAtendida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idCliente
        End Get
        Set(ByVal value As String)
            _idCliente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Comisionista() As String
        Get
            Return _Comisionista
        End Get
        Set(ByVal value As String)
            _Comisionista = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Zona() As String
        Get
            Return _Zona
        End Get
        Set(ByVal value As String)
            _Zona = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CargaMaterial() As String
        Get
            Return _CargaMaterial
        End Get
        Set(ByVal value As String)
            _CargaMaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property
    <DataMember()> _
    Public Property IndicadorTercero() As Boolean
        Get
            Return _indicadorTercero
        End Get
        Set(ByVal value As Boolean)
            _indicadorTercero = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad que almacena el estado de cambios del objeto durante la edición del mismo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Modificado() As Boolean
        Get
            Return _Modificado
        End Get
        Set(ByVal value As Boolean)
            _Modificado = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndEnvioCorreo() As Boolean
        Get
            Return _IndEnvioCorreo
        End Get
        Set(ByVal value As Boolean)
            _IndEnvioCorreo = value
        End Set
    End Property
   

#End Region

    Public Function Obtener(ByVal demanda As e_Demanda) As e_Demanda Implements Ie_Demanda.Obtener
        Return demanda
    End Function

End Class


