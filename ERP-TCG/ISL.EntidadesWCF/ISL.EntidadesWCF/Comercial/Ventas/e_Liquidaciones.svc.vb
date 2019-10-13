


' NOTA: si cambia aquí el nombre de clase "e_Liquidaciones", también debe actualizar la referencia a "e_Liquidaciones" tanto en Web.config como en el archivo .svc asociado.

<DataContract()> _
Public Class e_Liquidaciones
    Implements Ie_Liquidaciones

    'Public Sub DoWork() Implements Ie_Liquidaciones.DoWork
    'End Sub
#Region "Propiedades"
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public IdMoneda As String
    <DataMember()> _
    Public TipoCambio As Decimal
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()> _
    Public ListaLiquidacionDetalle As New List(Of e_LiquidacionDetalle)

    Private _Id As String
    Private _Codigo As String
    Private _IdCliente As String
    Private _Fecha As Date
    Private _SubTotal As Decimal
    Private _Igv As Decimal
    Private _Total As Decimal
    Private _Observacion As String
    Private _IdEstado As String
    Private _IdFactura As String
    Private _IndFormato As Integer
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _UsuarioModifica As String

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
        End Set
    End Property
    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As String)
            _IdCliente = value
        End Set
    End Property
    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property
    <DataMember()> _
    Public Property SubTotal() As Decimal
        Get
            Return _SubTotal
        End Get
        Set(ByVal value As Decimal)
            _SubTotal = value
        End Set
    End Property
    <DataMember()> _
    Public Property Igv() As Decimal
        Get
            Return _Igv
        End Get
        Set(ByVal value As Decimal)
            _Igv = value
        End Set
    End Property
    <DataMember()> _
    Public Property Total() As Decimal
        Get
            Return _Total
        End Get
        Set(ByVal value As Decimal)
            _Total = value
        End Set
    End Property
    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _IdEstado
        End Get
        Set(ByVal value As String)
            _IdEstado = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdFactura() As String
        Get
            Return _IdFactura
        End Get
        Set(ByVal value As String)
            _IdFactura = value
        End Set
    End Property
    <DataMember()> _
   Public Property IndFormato() As Integer
        Get
            Return _IndFormato
        End Get
        Set(ByVal value As Integer)
            _IndFormato = value
        End Set
    End Property
    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property
    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Id = ""
        FechaDesde = ""
        FechaHasta = ""
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
                  , ByVal ls_Codigo As String _
                  , ByVal ls_IdCliente As String _
                  , ByVal ld_Fecha As Date _
                  , ByVal ld_SubTotal As Decimal _
                  , ByVal ld_Igv As Decimal _
                  , ByVal ld_Total As Decimal _
                  , ByVal ls_Observacion As String _
                  , ByVal ls_IdEstado As String _
                  , ByVal ls_IdFactura As String _
                  , ByVal ls_IndFormato As Integer _
                  , ByVal ls_UsuarioCreacion As String _
                  , ByVal ls_UsuarioModifica As String _
                  , ByVal lb_Activo As Boolean)
        _Id = ls_Id
        _Codigo = ls_Codigo
        _IdCliente = ls_IdCliente
        _Fecha = ld_Fecha
        _SubTotal = ld_SubTotal
        _Igv = ld_Igv
        _Total = ld_Total
        _Observacion = ls_Observacion
        _IdEstado = ls_IdEstado
        _IdFactura = ls_IdFactura
        _IndFormato = ls_IndFormato
        _usuariocreacion = ls_UsuarioCreacion
        _UsuarioModifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

End Class


