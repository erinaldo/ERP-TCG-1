


<DataContract()> _
Public Class e_DocumentoVentaDetalle
    Implements Ie_DocumentoVentaDetalle

#Region "Propiedad"

    Private _id As String
    Private _iddocumentoventa As String
    Private _tiporeferencia As String
    Private _idreferencia As String
    Private _descripcion As String
    Private _cantidad As Integer
    Private _precio As Double
    Private _subtotal As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

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
    Public Property IdDocumentoVenta() As String
        Get
            Return _iddocumentoventa
        End Get
        Set(ByVal value As String)
            _iddocumentoventa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoReferencia() As String
        Get
            Return _tiporeferencia
        End Get
        Set(ByVal value As String)
            _tiporeferencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdReferencia() As String
        Get
            Return _idreferencia
        End Get
        Set(ByVal value As String)
            _idreferencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
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
    Public Property SubTotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
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
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
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
              , ByVal ls_IdDocumentoVenta As String _
              , ByVal ls_TipoReferencia As String _
              , ByVal ls_IdReferencia As String _
              , ByVal ls_Descripcion As String _
              , ByVal ln_Cantidad As Integer _
              , ByVal ln_Precio As Double _
              , ByVal ln_SubTotal As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _iddocumentoventa = ls_IdDocumentoVenta
        _tiporeferencia = ls_TipoReferencia
        _idreferencia = ls_IdReferencia
        _descripcion = ls_Descripcion
        _cantidad = ln_Cantidad
        _precio = ln_Precio
        _subtotal = ln_SubTotal
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal documentoVentaDetalle As e_DocumentoVentaDetalle) As e_DocumentoVentaDetalle Implements Ie_DocumentoVentaDetalle.Obtener
        Return documentoVentaDetalle
    End Function

#End Region

End Class

