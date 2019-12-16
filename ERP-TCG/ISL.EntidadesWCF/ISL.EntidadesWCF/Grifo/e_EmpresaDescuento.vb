Imports ERP.EntidadesWCF

Public Class e_EmpresaDescuento


    Implements Ie_CierreTurno
    Implements IEquatable(Of e_CierreTurno)

    <DataMember()>
    Public lstZona As List(Of e_Zona)
    <DataMember()>
    Public leSubAlmacen As List(Of e_SubAlmacen)
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean = False
    <DataMember()>
    Public Equivale As Integer
    <DataMember()>
    Public IndPrincipal As Integer
    <DataMember()>
    Public CargaCompleta As Boolean

    Public Event DatoCambiado()

#Region "Declaración de variables"
    Private _Id As String
    Private _IdEmpresaSis As String
    Private _IdSucursal As String
    Private _IdEmpresa As String
    Private _Empresa As String
    Private _IdProducto As String
    Private _Producto As String
    Private _IdMoneda As String
    Private _Moneda As String
    Private _DescuentoContado As Double
    Private _DescuentoCredito As Double
    Private _FechaInicio As Date
    Private _FechaFin As Date
    Private _IdVendedorTrabajador As String
    Private _VendedorTrabajador As String
    Private _UsuarioCrea As String
    Private _FechaCrea As Date
    Private _UsuarioModifica As String
    Private _FechaModifica As Date
    Private _Activo As Boolean


#End Region
#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdEmpresaSis = ""
        _IdSucursal = ""
        _IdEmpresa = ""
        _Empresa = ""
        _IdProducto = ""
        _Producto = ""
        _IdMoneda = ""
        _Moneda = ""
        _DescuentoContado = 0
        _DescuentoCredito = 0
        _FechaInicio = #01/01/1901#
        _FechaFin = #01/01/1901#
        _IdVendedorTrabajador = ""
        _VendedorTrabajador = ""
        _UsuarioCrea = ""
        _FechaCrea = #01/01/1901#
        _UsuarioModifica = ""
        _FechaModifica = #01/01/1901#
        _Activo = True
    End Sub

    Public Sub New(
              ByVal ls_Id As String _
              , ByVal ls_IdEmpresaSis As String _
              , ByVal ls_IdSucursal As String _
              , ByVal ls_IdEmpresa As String _
              , ByVal ls_Empresa As String _
              , ByVal ls_IdProducto As String _
              , ByVal ls_Producto As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_Moneda As String _
              , ByVal ln_DescuentoContado As Double _
              , ByVal ln_DescuentoCredito As Double _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ls_IdVendedorTrabajador As String _
              , ByVal ls_VendedorTrabajador As String _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ld_FechaCrea As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal lb_Activo As Boolean
           )
        _Id = ls_Id
        _IdEmpresaSis = ls_IdEmpresaSis
        _IdSucursal = ls_IdSucursal
        _IdEmpresa = ls_IdEmpresa
        _Empresa = ls_Empresa
        _IdProducto = ls_IdProducto
        _Producto = ls_Producto
        _IdMoneda = ls_IdMoneda
        _Moneda = ls_Moneda
        _DescuentoContado = ln_DescuentoContado
        _DescuentoCredito = ln_DescuentoCredito
        _FechaInicio = ld_FechaInicio
        _FechaFin = ld_FechaFin
        _IdVendedorTrabajador = ls_IdVendedorTrabajador
        _VendedorTrabajador = ls_VendedorTrabajador
        _UsuarioCrea = ls_UsuarioCrea
        _FechaCrea = ld_FechaCrea
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModifica = ld_FechaModifica
        _Activo = lb_Activo
    End Sub

    Public Function Obtener(Item As e_CierreTurno) As e_CierreTurno Implements Ie_CierreTurno.Obtener
        Throw New NotImplementedException()
    End Function

    Public Function Equals(other As e_CierreTurno) As Boolean Implements IEquatable(Of e_CierreTurno).Equals
        Throw New NotImplementedException()
    End Function

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

    Public Property IdEmpresaSis() As String
        Get
            Return _IdEmpresaSis
        End Get
        Set(ByVal value As String)
            _IdEmpresaSis = value
        End Set
    End Property

    Public Property IdSucursal() As String
        Get
            Return _IdSucursal
        End Get
        Set(ByVal value As String)
            _IdSucursal = value
        End Set
    End Property

    Public Property IdEmpresa() As String
        Get
            Return _IdEmpresa
        End Get
        Set(ByVal value As String)
            _IdEmpresa = value
        End Set
    End Property

    Public Property Empresa() As String
        Get
            Return _Empresa
        End Get
        Set(ByVal value As String)
            _Empresa = value
        End Set
    End Property

    Public Property IdProducto() As String
        Get
            Return _IdProducto
        End Get
        Set(ByVal value As String)
            _IdProducto = value
        End Set
    End Property

    Public Property Producto() As String
        Get
            Return _Producto
        End Get
        Set(ByVal value As String)
            _Producto = value
        End Set
    End Property

    Public Property IdMoneda() As String
        Get
            Return _IdMoneda
        End Get
        Set(ByVal value As String)
            _IdMoneda = value
        End Set
    End Property

    Public Property Moneda() As String
        Get
            Return _Moneda
        End Get
        Set(ByVal value As String)
            _Moneda = value
        End Set
    End Property

    Public Property DescuentoContado() As Double
        Get
            Return _DescuentoContado
        End Get
        Set(ByVal value As Double)
            _DescuentoContado = value
        End Set
    End Property

    Public Property DescuentoCredito() As Double
        Get
            Return _DescuentoCredito
        End Get
        Set(ByVal value As Double)
            _DescuentoCredito = value
        End Set
    End Property

    Public Property FechaInicio() As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            _FechaInicio = value
        End Set
    End Property

    Public Property FechaFin() As Date
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As Date)
            _FechaFin = value
        End Set
    End Property

    Public Property IdVendedorTrabajador() As String
        Get
            Return _IdVendedorTrabajador
        End Get
        Set(ByVal value As String)
            _IdVendedorTrabajador = value
        End Set
    End Property

    Public Property VendedorTrabajador() As String
        Get
            Return _VendedorTrabajador
        End Get
        Set(ByVal value As String)
            _VendedorTrabajador = value
        End Set
    End Property

    Public Property UsuarioCrea() As String
        Get
            Return _UsuarioCrea
        End Get
        Set(ByVal value As String)
            _UsuarioCrea = value
        End Set
    End Property

    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
        End Set
    End Property

    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property

    Public Property FechaModifica() As Date
        Get
            Return _FechaModifica
        End Get
        Set(ByVal value As Date)
            _FechaModifica = value
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

#End Region

End Class