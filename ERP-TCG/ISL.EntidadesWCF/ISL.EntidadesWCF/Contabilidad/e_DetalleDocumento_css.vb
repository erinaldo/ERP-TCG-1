
'=====================================================================================================
'=== CAPA : ENTIDADES ================================================================================
'=====================================================================================================
Public Class e_DetalleDocumento_css


#Region "Declaración de variables"


    Private _Id As String
    Private _IdMovimientoDocumento As String
    Private _IndServicioMaterial As String
    Private _IdMaterialServicio As String
    Private _Cantidad As Double
    Private _PrecioUnitario As Double
    Private _IndGravado As Boolean
    Private _Valor As Double
    Private _Igv As Double
    Private _IdOperacionDetalle As String
    Private _IdVehiculo As String
    Private _Activo As Boolean
    Private _UsuarioCreacion As String
    Private _FechaCreacion As Date
    Private _IdUnidadMedida As String
    Private _FactorRefUni As Double
    Private _IdViaje As String
    Private _Consolidado As Double
    Private _IndConsolidado As String
    Private _GlosaConsolidado As String
    Private _IdGastoOperacion As String
    Private _Monto_Anticipo As Double
    Public TipoOperacion As String

    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdMovimientoDocumento = ""
        _IndServicioMaterial = ""
        _IdMaterialServicio = ""
        _Cantidad = 0
        _PrecioUnitario = 0
        _IndGravado = True
        _Valor = 0
        _Igv = 0
        _IdOperacionDetalle = ""
        _IdVehiculo = ""
        _Activo = True
        _UsuarioCreacion = ""
        _FechaCreacion = #01/01/1901#
        _IdUnidadMedida = ""
        _FactorRefUni = 0
        _IdViaje = ""
        _Consolidado = 0
        _IndConsolidado = ""
        _GlosaConsolidado = ""
        _IdGastoOperacion = ""
        _Monto_Anticipo = 0
    End Sub

    Public Sub New(
              ByVal ls_Id As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ls_IndServicioMaterial As String _
              , ByVal ls_IdMaterialServicio As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_PrecioUnitario As Double _
              , ByVal lb_IndGravado As Boolean _
              , ByVal ln_Valor As Double _
              , ByVal ln_Igv As Double _
              , ByVal ls_IdOperacionDetalle As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ln_FactorRefUni As Double _
              , ByVal ls_IdViaje As String _
              , ByVal ln_Consolidado As Double _
              , ByVal ls_IndConsolidado As String _
              , ByVal ls_GlosaConsolidado As String _
              , ByVal ls_IdGastoOperacion As String _
              , ByVal ln_Monto_Anticipo As Double
           )
        _Id = ls_Id
        _IdMovimientoDocumento = ls_IdMovimientoDocumento
        _IndServicioMaterial = ls_IndServicioMaterial
        _IdMaterialServicio = ls_IdMaterialServicio
        _Cantidad = ln_Cantidad
        _PrecioUnitario = ln_PrecioUnitario
        _IndGravado = lb_IndGravado
        _Valor = ln_Valor
        _Igv = ln_Igv
        _IdOperacionDetalle = ls_IdOperacionDetalle
        _IdVehiculo = ls_IdVehiculo
        _Activo = lb_Activo
        _UsuarioCreacion = ls_UsuarioCreacion
        _FechaCreacion = ld_FechaCreacion
        _IdUnidadMedida = ls_IdUnidadMedida
        _FactorRefUni = ln_FactorRefUni
        _IdViaje = ls_IdViaje
        _Consolidado = ln_Consolidado
        _IndConsolidado = ls_IndConsolidado
        _GlosaConsolidado = ls_GlosaConsolidado
        _IdGastoOperacion = ls_IdGastoOperacion
        _Monto_Anticipo = ln_Monto_Anticipo
    End Sub

#End Region
#Region "Propiedades"


    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property
    Public Property IdMovimientoDocumento() As String
        Get
            Return _IdMovimientoDocumento
        End Get
        Set(ByVal value As String)
            _IdMovimientoDocumento = value
        End Set
    End Property
    Public Property IndServicioMaterial() As String
        Get
            Return _IndServicioMaterial
        End Get
        Set(ByVal value As String)
            _IndServicioMaterial = value
        End Set
    End Property
    Public Property IdMaterialServicio() As String
        Get
            Return _IdMaterialServicio
        End Get
        Set(ByVal value As String)
            _IdMaterialServicio = value
        End Set
    End Property
    Public Property Cantidad() As Double
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Double)
            _Cantidad = value
        End Set
    End Property
    Public Property PrecioUnitario() As Double
        Get
            Return _PrecioUnitario
        End Get
        Set(ByVal value As Double)
            _PrecioUnitario = value
        End Set
    End Property
    Public Property IndGravado() As Boolean
        Get
            Return _IndGravado
        End Get
        Set(ByVal value As Boolean)
            _IndGravado = value
        End Set
    End Property
    Public Property Valor() As Double
        Get
            Return _Valor
        End Get
        Set(ByVal value As Double)
            _Valor = value
        End Set
    End Property
    Public Property Igv() As Double
        Get
            Return _Igv
        End Get
        Set(ByVal value As Double)
            _Igv = value
        End Set
    End Property
    Public Property IdOperacionDetalle() As String
        Get
            Return _IdOperacionDetalle
        End Get
        Set(ByVal value As String)
            _IdOperacionDetalle = value
        End Set
    End Property
    Public Property IdVehiculo() As String
        Get
            Return _IdVehiculo
        End Get
        Set(ByVal value As String)
            _IdVehiculo = value
        End Set
    End Property
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property
    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
        End Set
    End Property
    Public Property IdUnidadMedida() As String
        Get
            Return _IdUnidadMedida
        End Get
        Set(ByVal value As String)
            _IdUnidadMedida = value
        End Set
    End Property
    Public Property FactorRefUni() As Double
        Get
            Return _FactorRefUni
        End Get
        Set(ByVal value As Double)
            _FactorRefUni = value
        End Set
    End Property
    Public Property IdViaje() As String
        Get
            Return _IdViaje
        End Get
        Set(ByVal value As String)
            _IdViaje = value
        End Set
    End Property
    Public Property Consolidado() As Double
        Get
            Return _Consolidado
        End Get
        Set(ByVal value As Double)
            _Consolidado = value
        End Set
    End Property
    Public Property IndConsolidado() As String
        Get
            Return _IndConsolidado
        End Get
        Set(ByVal value As String)
            _IndConsolidado = value
        End Set
    End Property
    Public Property GlosaConsolidado() As String
        Get
            Return _GlosaConsolidado
        End Get
        Set(ByVal value As String)
            _GlosaConsolidado = value
        End Set
    End Property
    Public Property IdGastoOperacion() As String
        Get
            Return _IdGastoOperacion
        End Get
        Set(ByVal value As String)
            _IdGastoOperacion = value
        End Set
    End Property
    Public Property Monto_Anticipo() As Double
        Get
            Return _Monto_Anticipo
        End Get
        Set(ByVal value As Double)
            _Monto_Anticipo = value
        End Set
    End Property
#End Region
End Class