

<DataContract()> _
Public Class e_OrdenCompra
    Implements Ie_OrdenCompra

#Region "Declaración de variables"

    Private _Id As String
    Private _NroOrden As String
    Private _idmoneda As String
    Private _moneda As String
    Private _idtipoorden As String
    Private _tipoorden As String
    Private _Almacen As String
    Private _idcentrocosto As String
    Private _SubTotal As Double
    Private _NroGuia As String
    Private _FechaOrden As Date = #1/1/1901#
    Private _FechaRecepcion As Date = #1/1/1901#
    Private _FechaEntrega As Date = #1/1/1901#
    Private _FechaPago As Date = #1/1/1901#
    Private _Impuesto As Double
    Private _Total As Double
    Private _IndicadorAprobacion As Boolean
    Private _IndicadorConsignacion As Boolean
    Private _Consignacion As String
    Private _IndCotizacion As Boolean
    Private _TrabajadorAprobacion As String
    Private _indtipocompra As Integer
    Private _tipocompra As String
    Private _idestadoorden As String
    Private _estadoorden As String
    Private _subestadoorden As String
    Private _idtrabajador As String
    Private _TipoReferencia As String
    Private _idtipoOC As String
    Private _Activo As Boolean
    Private _Glosa As String = String.Empty
    Private _Notas As String = String.Empty
    Private _idcentro As String
    Private _idtipopago As String
    Private _materialservicio As String
    Private _idproveedor As String
    Private _proveedor As String
    Private _UsuarioCreacion As String
    Private _MsgDocumento As String

    <DataMember()> _
    Public fechaFin As Date
    <DataMember()> _
    Public fechaInicio As Date
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()> _
    Public lstOrdenMaterial As New List(Of e_OrdenCompraMaterial)
    <DataMember()>
    Public lstOrdenServicio As New List(Of e_OrdenCompraServicio)

#Region "Transporte"

    <DataMember()>
    Public Property IndFactServicio As Boolean = False
    <DataMember()>
    Public Property IdTransportista As String = ""
    <DataMember()>
    Public Property IdOrigen As String = ""
    <DataMember()>
    Public Property IdDestino As String = ""
    <DataMember()>
    Public Property CodigoDT As String = ""
    <DataMember()>
    Public Property IdPiloto As String = ""
    <DataMember()>
    Public Property IdTracto As String = ""
    <DataMember()>
    Public Property IdClienteFinal As String = ""
    <DataMember()>
    Public Property IdVentanaHoraria As String = ""
    <DataMember()>
    Public Property IdViaje As String = ""
#End Region

    <DataMember()> _
    Public oeOrdCmpCot As New e_OrdenCmpCotizacion

    <DataMember()> _
    Public oeOrdenTrabajo As New e_OrdenTrabajo

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public TipoBien As String

    <DataMember()> _
    Public Percepcion As Double = 0 : Public PercepcionPorc As Double = 0
    <DataMember()> _
    Public Detraccion As Double = 0 : Public DetraccionPorc As Double = 0

    <DataMember()> _
    Public OrdenAprobacion As New e_OrdenAprobacion
    <DataMember()> _
    Public IdAprobacion As String = ""
    <DataMember()> _
    Public IdTrabajadorAprobacion As String = ""
    <DataMember()> _
    Public IndBloqueo As Boolean = 0

    <DataMember()> _
    Public _CantMax As Double = 0
    <DataMember()> _
    Public _CantMin As Double = 0

    <DataMember()> _
    Public FechaAprobacion As Date

#End Region

#Region "Propiedades"

    Sub New()
        Activo = True
        fechaInicio = Date.Parse("01/01/1901")
        fechaFin = Date.Parse("01/01/1901")
        IndCotizacion = False
    End Sub

    <DataMember()> _
    Public Property EstadoDocumento() As String
        Get
            Return _MsgDocumento
        End Get
        Set(ByVal value As String)
            _MsgDocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreSubEstado() As String
        Get
            Return _subestadoorden
        End Get
        Set(ByVal value As String)
            _subestadoorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCotizacion() As Boolean
        Get
            Return _IndCotizacion
        End Get
        Set(ByVal value As Boolean)
            _IndCotizacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipoCompra() As Integer
        Get
            Return _indtipocompra
        End Get
        Set(ByVal value As Integer)
            _indtipocompra = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCompra() As String
        Get
            Return _tipocompra
        End Get
        Set(ByVal value As String)
            _tipocompra = value
        End Set
    End Property

    <DataMember()> _
    Public Property TrabajadorAprobacion() As String
        Get
            Return _TrabajadorAprobacion
        End Get
        Set(ByVal value As String)
            _TrabajadorAprobacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property MaterialServicio() As String
        Get
            Return _materialservicio
        End Get
        Set(ByVal value As String)
            _materialservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoPago() As String
        Get
            Return _idtipopago
        End Get
        Set(ByVal value As String)
            _idtipopago = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _idcentro
        End Get
        Set(ByVal value As String)
            _idcentro = value
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
    Public Property NroOrden() As String
        Get
            Return _NroOrden
        End Get
        Set(ByVal value As String)
            _NroOrden = value
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
    Public Property IdTipoOrden() As String
        Get
            Return _idtipoorden
        End Get
        Set(ByVal value As String)
            _idtipoorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoOrden() As String
        Get
            Return _tipoorden
        End Get
        Set(ByVal value As String)
            _tipoorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentroCosto() As String
        Get
            Return _idcentrocosto
        End Get
        Set(ByVal value As String)
            _idcentrocosto = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubTotal() As Double
        Get
            Return _SubTotal
        End Get
        Set(ByVal value As Double)
            _SubTotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroGuia() As String
        Get
            Return _NroGuia
        End Get
        Set(ByVal value As String)
            _NroGuia = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaOrden() As Date
        Get
            Return _FechaOrden
        End Get
        Set(ByVal value As Date)
            _FechaOrden = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaRecepcion() As Date
        Get
            Return _FechaRecepcion
        End Get
        Set(ByVal value As Date)
            _FechaRecepcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEntrega() As Date
        Get
            Return _FechaEntrega
        End Get
        Set(ByVal value As Date)
            _FechaEntrega = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaPago() As Date
        Get
            Return _FechaPago
        End Get
        Set(ByVal value As Date)
            _FechaPago = value
        End Set
    End Property

    <DataMember()> _
    Public Property Impuesto() As Double
        Get
            Return _Impuesto
        End Get
        Set(ByVal value As Double)
            _Impuesto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _Total
        End Get
        Set(ByVal value As Double)
            _Total = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndicadorAprobacion() As Boolean
        Get
            Return _IndicadorAprobacion
        End Get
        Set(ByVal value As Boolean)
            _IndicadorAprobacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndicadorConsignacion() As Boolean
        Get
            Return _IndicadorConsignacion
        End Get
        Set(ByVal value As Boolean)
            _IndicadorConsignacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Consignacion() As String
        Get
            Return _Consignacion
        End Get
        Set(ByVal value As String)
            _Consignacion = value
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
    Public Property TipoReferencia() As String
        Get
            Return _TipoReferencia
        End Get
        Set(ByVal value As String)
            _TipoReferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoOrdenCompra() As String
        Get
            Return _idtipoOC
        End Get
        Set(ByVal value As String)
            _idtipoOC = value
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
    Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Notas() As String
        Get
            Return _Notas
        End Get
        Set(ByVal value As String)
            _Notas = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstadoOrden() As String
        Get
            Return _idestadoorden
        End Get
        Set(ByVal value As String)
            _idestadoorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoOrden() As String
        Get
            Return _estadoorden
        End Get
        Set(ByVal value As String)
            _estadoorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreProveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
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

#End Region

#Region "Constructor"

    Sub New(ByVal ls_Id As String,
           ByVal ls_NroOrden As String,
           ByVal ls_IdMoneda As String,
           ByVal ls_Moneda As String,
           ByVal ls_SubTotal As Double,
           ByVal ls_FechaOrden As Date,
           ByVal ls_FechaEntrega As Date,
           ByVal ls_FechaPago As Date,
           ByVal ls_Impuesto As Double,
           ByVal ls_Total As Double,
           ByVal ls_IndicadorAprobacion As Boolean,
           ByVal ls_IndicadorConsignacion As Boolean,
           ByVal ls_IdTrabajador As String,
           ByVal ls_IdTipoOrdenCompra As String,
           ByVal ls_Glosa As String,
           ByVal ls_Notas As String,
           ByVal ls_Activo As Boolean,
           ByVal ls_IdEstadoOrden As String,
           ByVal ls_IdCentro As String,
           ByVal ls_NombreEstadoOrden As String,
           ByVal ls_IdTipoPago As String,
           ByVal ls_NombreProveedor As String,
           ByVal ls_IdProveedor As String,
           ByVal ls_NombreSubEstado As String,
           ByVal ln_Percepcion As Double,
           ByVal ln_PercepcionPorc As Double,
           ByVal ln_Detraccion As Double,
           ByVal ln_DetraccionPorc As Double,
           ByVal ls_MsgDoc As String,
           ByVal ls_IdAprobacion As String,
           ByVal ls_IdTrabajadorAprobacion As String,
           ByVal ln_IndBloqueo As Boolean,
           ByVal ld_FechaAprobacion As Date,
           ByVal ls_TrabajadorAprobacion As String,
           ByVal li_IndTipoCompra As Integer,
           ByVal ls_TipoCompra As String,
           ByVal lb_IndCotizacion As Boolean,
           ByVal ls_CodDT As String,
           ByVal lb_IndFactServ As Boolean,
           ByVal ls_IdTrans As String,
           ByVal ls_IdOrigen As String,
           ByVal ls_IdDestino As String,
           ByVal ls_UsuarioCracion As String,
           ByVal ls_IdPiloto As String,
           ByVal ls_IdTracto As String,
           ByVal ls_IdClienteFinal As String,
           ByVal ls_IdVentanaHoraria As String,
            ByVal ls_IdViaje As String) '25 parametros


        _Id = ls_Id
        _NroOrden = ls_NroOrden
        _idmoneda = ls_IdMoneda
        _moneda = ls_Moneda
        _SubTotal = ls_SubTotal
        _FechaOrden = ls_FechaOrden
        _FechaEntrega = ls_FechaEntrega
        _FechaPago = ls_FechaPago
        _Impuesto = ls_Impuesto
        _Total = ls_Total
        _IndicadorAprobacion = ls_IndicadorAprobacion
        _Consignacion = IIf(ls_IndicadorConsignacion = True, "CONSIGNA", "")
        _IndicadorConsignacion = ls_IndicadorConsignacion
        _idtrabajador = ls_IdTrabajador
        _idtipoOC = ls_IdTipoOrdenCompra
        _Glosa = ls_Glosa
        _Notas = ls_Notas
        _Activo = ls_Activo
        _idestadoorden = ls_IdEstadoOrden
        _idcentro = ls_IdCentro
        _estadoorden = ls_NombreEstadoOrden
        _idtipopago = ls_IdTipoPago
        _proveedor = ls_NombreProveedor
        _idproveedor = ls_IdProveedor
        _subestadoorden = ls_NombreSubEstado
        Percepcion = ln_Percepcion
        PercepcionPorc = ln_PercepcionPorc
        Detraccion = ln_Detraccion
        DetraccionPorc = ln_DetraccionPorc
        _MsgDocumento = ls_MsgDoc
        IdAprobacion = ls_IdAprobacion
        IdTrabajadorAprobacion = ls_IdTrabajadorAprobacion
        IndBloqueo = ln_IndBloqueo
        FechaAprobacion = ld_FechaAprobacion
        _TrabajadorAprobacion = ls_TrabajadorAprobacion
        _indtipocompra = li_IndTipoCompra
        _tipocompra = ls_TipoCompra
        _IndCotizacion = lb_IndCotizacion
        _UsuarioCreacion = ls_UsuarioCracion
        CodigoDT = ls_CodDT
        IndFactServicio = lb_IndFactServ
        IdTransportista = ls_IdTrans
        IdOrigen = ls_IdOrigen
        IdDestino = ls_IdDestino
        IdPiloto = ls_IdPiloto
        IdTracto = ls_IdTracto
        IdClienteFinal = ls_IdClienteFinal
        IdVentanaHoraria = ls_IdVentanaHoraria
        IdViaje = ls_IdViaje
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal ordenCompra As e_OrdenCompra) As e_OrdenCompra Implements Ie_OrdenCompra.Obtener
        Return ordenCompra
    End Function

    ''' <summary>
    ''' Permite verificar que exista al menos una orden de compra seleccionada
    ''' </summary>
    ''' <param name="ordenes"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VerificarOrdenCompra(ByVal ordenes As System.Collections.Generic.List(Of e_OrdenCompra)) As Integer Implements Ie_OrdenCompra.VerificarOrdenCompra
        Dim sw As Integer = 0
        For Each obj As e_OrdenCompra In ordenes
            If obj.IndicadorAprobacion Then
                sw = 1
            End If
        Next
        Return sw
    End Function

#End Region

End Class


