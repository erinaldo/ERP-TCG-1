<DataContract()> _
Public Class e_DetalleDocumento
    Implements Ie_DetalleDocumento

#Region "Declaración de variables"

    Private _id As String
    Private _idmovimientodocumento As String
    Private _indserviciomaterial As String
    Private _idmaterialservicio As String
    Private _codigomaterialservicio As String
    Private _nombrematerialservicio As String
    Private _unidadmedida As String
    Private _idunidadmedida As String
    Private _tipounidadmedida As String
    Private _cantidad As Double
    Private _precio As Double
    Private _precioUnitarioSinImp As Double
    Private _total As Double 'Monto total incluido IGV
    Private _indgravado As Boolean
    Private _igv As Double
    Private _subtotal As Double 'Monto total sin IGV
    Private _idoperaciondetalle As String
    Private _idvehiculo As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _factorrefuni As Double
    Private _idviaje As String
    Private _IdCuentaContableCompra As String
    Private _IndConsolidado As String
    Private _GlosaConsolidado As String
    Private _Consolidado As Decimal
    Private _Monto_Anticipo As Decimal
    Private _Porc_Anticipo As Decimal

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Private _Seleccion As Boolean
    Private _Pos As Integer


    '' Uso esclusivo de combustible
    <DataMember()> _
    Public IdRegistroConsCombustible As String = ""
    ''

    <DataMember()> _
    Public leDetalleGuiaTrans As New List(Of e_DetalleDoc_GuiaTrans)
    <DataMember()> _
    Public IdTipoCompra As String
    <DataMember()> _
    Public IdCuentaContableDebe As String '-------para venta
    <DataMember()> _
    Public IdCuentaContableHaber As String '-------para venta
    <DataMember()> _
    Public IdItemGasto As String  '--para compras por servicios y combustible
    <DataMember()> _
    Public SubAlm As String  '--para compras de activo fijo y gasto
    <DataMember()> _
    Public IndPropiedad As Integer  '--para compras por servicio y tracto es x leasing
    <DataMember()> _
    Public IdCuentaContableActivo As String  '--para compras de material como activo
    <DataMember()> _
    Public IdSubFamiliaMaterial As String '--para asiento modelo
    <DataMember()> _
    Public IdCategoriaServicio As String '--para asiento modelo
    <DataMember()> _
    Public IdGastoOperacion As String '--para Peaje Post Pago
    <DataMember()> _
    Public IdAlmacen As String  '--para compras de material como consignacion

    Public Property IdEmpresaSis() As String
    Public Property IdSucursal() As String

    Public Event DatoCambiado()

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
    Public Property IdMovimientoDocumento() As String
        Get
            Return _idmovimientodocumento
        End Get
        Set(ByVal value As String)
            _idmovimientodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndServicioMaterial() As String
        Get
            Return _indserviciomaterial
        End Get
        Set(ByVal value As String)
            _indserviciomaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterialServicio() As String
        Get
            Return _idmaterialservicio
        End Get
        Set(ByVal value As String)
            _idmaterialservicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoMaterialServicio() As String
        Get
            Return _codigomaterialservicio
        End Get
        Set(ByVal value As String)
            _codigomaterialservicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitarioSinImp() As Double
        Get
            Return _precioUnitarioSinImp
        End Get
        Set(ByVal value As Double)
            _precioUnitarioSinImp = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndGravado() As Boolean
        Get
            Return _indgravado
        End Get
        Set(ByVal value As Boolean)
            _indgravado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Igv() As Double
        Get
            Return _igv
        End Get
        Set(ByVal value As Double)
            _igv = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Subtotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
            RaiseEvent DatoCambiado()
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
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
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
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _idunidadmedida
        End Get
        Set(ByVal value As String)
            _idunidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadMedida() As String
        Get
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoUnidadMedida() As String
        Get
            Return _tipounidadmedida
        End Get
        Set(ByVal value As String)
            _tipounidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreMaterialServicio() As String
        Get
            Return _nombrematerialservicio
        End Get
        Set(ByVal value As String)
            _nombrematerialservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Pos() As Integer
        Get
            Return _Pos
        End Get
        Set(ByVal value As Integer)
            _Pos = value
        End Set
    End Property

    <DataMember()> _
    Public Property FactorRefUni() As Double
        Get
            Return _factorrefuni
        End Get
        Set(ByVal value As Double)
            _factorrefuni = value
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
    Public Property IdCuentaContableCompra() As String
        Get
            Return _IdCuentaContableCompra
        End Get
        Set(ByVal value As String)
            _IdCuentaContableCompra = value
        End Set
    End Property


    <DataMember()> _
    Public Property IndConsolidado() As String
        Get
            Return _IndConsolidado
        End Get
        Set(ByVal value As String)
            _IndConsolidado = value
        End Set
    End Property
    <DataMember()> _
    Public Property GlosaConsolidado() As String
        Get
            Return _GlosaConsolidado
        End Get
        Set(ByVal value As String)
            _GlosaConsolidado = value
        End Set
    End Property
    <DataMember()> _
    Public Property Consolidado() As Decimal
        Get
            Return _Consolidado
        End Get
        Set(ByVal value As Decimal)
            _Consolidado = value
        End Set
    End Property
    <DataMember()> _
    Public Property Monto_Anticipo() As Decimal
        Get
            Return _Monto_Anticipo
        End Get
        Set(ByVal value As Decimal)
            _Monto_Anticipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Porc_Anticipo() As Decimal
        Get
            Return _Porc_Anticipo
        End Get
        Set(ByVal value As Decimal)
            _Porc_Anticipo = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        IdGastoOperacion = ""
        _activo = True
        _fechacreacion = "01/01/1901"
        _Monto_Anticipo = 0.0
        _Porc_Anticipo = 0.0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ls_IndServicioMaterial As String _
              , ByVal ls_IdMaterialServicio As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_Precio As Double _
              , ByVal ln_Total As Double _
              , ByVal lb_IndGravado As Boolean _
              , ByVal ln_Igv As Double _
              , ByVal ln_Subtotal As Double _
              , ByVal ls_IdOperacionDetalle As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ld_IdUnidadMedida As String _
              , ByVal ld_UnidadMedida As String _
              , ByVal ld_IdTipoUnidadMedida As String _
              , ByVal ld_IdMaterialServicio As String _
              , ByVal ld_MaterialServicio As String _
              , ByVal ld_CodigoMaterialServicio As String _
              , ByVal ld_Porcentaje As Double _
              , ByVal lsIdCuentaContableCompra As String, _
              ByVal lsIdTipoCompra As String, _
              ByVal lsIdCuentaContableDebe As String, _
              ByVal lsIdCuentaContableHaber As String _
              , ByVal lsIdItemGasto As String _
              , ByVal ln_FactorRefUni As Double _
              , ByVal lsSubAlm As String _
        , ByVal lnIndPropiedad As Integer _
        , ByVal lsIdCuentaContableActivo As String _
         , ByVal lsIdAlmacen As String _
                   )
        IdCuentaContableActivo = lsIdCuentaContableActivo
        SubAlm = lsSubAlm
        IdAlmacen = lsIdAlmacen
        IndPropiedad = lnIndPropiedad
        _id = ls_Id
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _indserviciomaterial = ls_IndServicioMaterial
        _idmaterialservicio = ls_IdMaterialServicio
        _cantidad = ln_Cantidad
        _precio = ln_Precio
        _igv = ln_Igv

        _precioUnitarioSinImp = IIf(lb_IndGravado, Math.Round(_precio / (ld_Porcentaje + 1), 4), Math.Round(_precio, 4))

        _subtotal = ln_Subtotal
        _total = Math.Round(_subtotal + _igv, 4)
        _indgravado = lb_IndGravado
        _idoperaciondetalle = ls_IdOperacionDetalle
        _idvehiculo = ls_IdVehiculo
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _idmaterialservicio = ld_IdMaterialServicio
        _nombrematerialservicio = ld_MaterialServicio
        _codigomaterialservicio = ld_CodigoMaterialServicio

        _tipounidadmedida = ld_IdTipoUnidadMedida
        _idunidadmedida = ld_IdUnidadMedida
        _unidadmedida = ld_UnidadMedida
        _IdCuentaContableCompra = lsIdCuentaContableCompra
        IdTipoCompra = lsIdTipoCompra
        IdCuentaContableDebe = lsIdCuentaContableDebe
        IdCuentaContableHaber = lsIdCuentaContableHaber
        IdItemGasto = lsIdItemGasto
        _factorrefuni = ln_FactorRefUni
    End Sub

#End Region

#Region "Métodos"

    Public Function ImporteSubTotal() As Double
        Return Math.Round(Cantidad * Precio, 4)
    End Function

    Public Function ImporteIGV() As Double
        Return Total - Math.Round(Cantidad * PrecioUnitarioSinImp, 4)
    End Function

    Public Function Obtener(ByVal detalleDocumento As e_DetalleDocumento) As e_DetalleDocumento Implements Ie_DetalleDocumento.Obtener
        Return detalleDocumento
    End Function

#End Region

End Class
