<DataContract()> _
Public Class e_OrdenAsignacion_Material
    Implements Ie_OrdenAsignacion_Material
    Implements IEquatable(Of e_OrdenAsignacion_Material)

#Region "Propiedad"

    Private _id As String
    Private _idmaterial As String
    Private _idordenasignacion As String
    Private _indunidadasignacion As String
    Private _idunidadasignacion As String
    Private _idunidadmedida As String
    Private _cantidadmaterial As Double
    Private _cantidadmaterialentregada As Double
    Private _cantidadmaterialdevuelto As Double
    Private _costounitario As Double
    Private _idsubalmacen As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _montodescuento As Double
    Private _inddescuento As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public CantAux As Double
    <DataMember()> _
    Public oeReqMaterial As New e_RequerimientoMaterial
    <DataMember()> _
    Public Material As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrdenAsignacion() As String
        Get
            Return _idordenasignacion
        End Get
        Set(ByVal value As String)
            _idordenasignacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoDescuento() As Double
        Get
            Return _montodescuento
        End Get
        Set(ByVal value As Double)
            _montodescuento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndDescuento() As Boolean
        Get
            Return _inddescuento
        End Get
        Set(ByVal value As Boolean)
            _inddescuento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndUnidadAsignacion() As String
        Get
            Return _indunidadasignacion
        End Get
        Set(ByVal value As String)
            _indunidadasignacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadAsignacion() As String
        Get
            Return _idunidadasignacion
        End Get
        Set(ByVal value As String)
            _idunidadasignacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _idunidadmedida
        End Get
        Set(ByVal value As String)
            _idunidadmedida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMaterial() As Double
        Get
            Return _cantidadmaterial
        End Get
        Set(ByVal value As Double)
            _cantidadmaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMaterialEntregada() As Double
        Get
            Return _cantidadmaterialentregada
        End Get
        Set(ByVal value As Double)
            _cantidadmaterialentregada = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMaterialDevuelto() As Double
        Get
            Return _cantidadmaterialdevuelto
        End Get
        Set(ByVal value As Double)
            _cantidadmaterialdevuelto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CostoUnitario() As Double
        Get
            Return _costounitario
        End Get
        Set(ByVal value As Double)
            _costounitario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property
    <DataMember()> _
    Public Property IdSubAlmacen() As String
        Get
            Return _idsubalmacen
        End Get
        Set(ByVal value As String)
            _idsubalmacen = value
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

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_IdOrdenAsignacion As String _
              , ByVal ls_IndUnidadAsignacion As String _
              , ByVal ls_IdUnidadAsignacion As String _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ln_CantidadMaterial As Double _
              , ByVal ln_CantidadMaterialEntregada As Double _
              , ByVal ln_CantidadMaterialDevuelto As Double _
              , ByVal ln_CostoUnit As Double _
              , ByVal ls_IdSubAlmacen As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
           )
        _id = ls_Id
        _idmaterial = ls_IdMaterial
        _idordenasignacion = ls_IdOrdenAsignacion
        _indunidadasignacion = ls_IndUnidadAsignacion
        _idunidadasignacion = ls_IdUnidadAsignacion
        _idunidadmedida = ls_IdUnidadMedida
        _cantidadmaterial = ln_CantidadMaterial
        _cantidadmaterialentregada = ln_CantidadMaterialEntregada
        _cantidadmaterialdevuelto = ln_CantidadMaterialDevuelto
        _idsubalmacen = ls_IdSubAlmacen
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _costounitario = ln_CostoUnit
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal ordenAsignacion_Material As e_OrdenAsignacion_Material) As e_OrdenAsignacion_Material Implements Ie_OrdenAsignacion_Material.Obtener
        Return ordenAsignacion_Material
    End Function

    Public Overloads Function Equals(ByVal ordenasigmaterial As e_OrdenAsignacion_Material) As Boolean Implements IEquatable(Of e_OrdenAsignacion_Material).Equals
        If Me.Id = ordenasigmaterial.Id Then Return True
        Return False
    End Function

#End Region

End Class
