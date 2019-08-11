' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ViajesTerceros" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ViajesTerceros.svc o e_ViajesTerceros.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_ViajesTerceros
    Implements Ie_ViajesTerceros

    Public Sub DoWork() Implements Ie_ViajesTerceros.DoWork
    End Sub
#Region "Propiedad"

    Private _id As String
    Private _iddemanda As String
    Private _idoperacion As String
    Private _idoperaciondetalle As String
    Private _idtercero As String
    Private _idcontacto As String
    Private _idmoneda As String
    Private _fleteunitario As Double
    Private _igv As Double
    Private _totalflete As Double
    Private _saldoflete As Double
    Private _adelantoflete As Double
    Private _comision As Double
    Private _saldocomision As Double
    Private _indfacturado As Integer
    Private _indoperacion As Integer
    Private _serie As String
    Private _numero As String
    Private _idmovimientodocumento As String
    Private _glosa As String
    Private _Observacion As String
    Private _idestado As String
    Private _fechacrea As Date
    Private _usuariocrea As String
    Private _documento As String
    Private _cantidad As Double
    Private _subtotal As Double
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property IdOperacion() As String
        Get
            Return _idoperacion
        End Get
        Set(ByVal value As String)
            _idoperacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property
    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
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
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
        End Set
    End Property
    <DataMember()> _
        Public Property IdDemanda() As String
        Get
            Return _iddemanda
        End Get
        Set(ByVal value As String)
            _iddemanda = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdOperacionDetalle() As String
        Get
            Return _idoperaciondetalle
        End Get
        Set(ByVal value As String)
            _idoperaciondetalle = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdTercero() As String
        Get
            Return _idtercero
        End Get
        Set(ByVal value As String)
            _idtercero = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdContacto() As String
        Get
            Return _idcontacto
        End Get
        Set(ByVal value As String)
            _idcontacto = value
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
    Public Property FleteUnitario() As Double
        Get
            Return _fleteunitario
        End Get
        Set(ByVal value As Double)
            _fleteunitario = value
        End Set
    End Property
    <DataMember()> _
    Public Property Igv() As Double
        Get
            Return _igv
        End Get
        Set(ByVal value As Double)
            _igv = value
        End Set
    End Property
    <DataMember()> _
    Public Property TotalFlete() As Double
        Get
            Return _totalflete
        End Get
        Set(ByVal value As Double)
            _totalflete = value
        End Set
    End Property
    <DataMember()> _
    Public Property SaldoFlete() As Double
        Get
            Return _saldoflete
        End Get
        Set(ByVal value As Double)
            _saldoflete = value
        End Set
    End Property
    <DataMember()> _
    Public Property AdelantoFlete() As Double
        Get
            Return _adelantoflete
        End Get
        Set(ByVal value As Double)
            _adelantoflete = value
        End Set
    End Property
    <DataMember()> _
    Public Property Comision() As Double
        Get
            Return _comision
        End Get
        Set(ByVal value As Double)
            _comision = value
        End Set
    End Property
    <DataMember()> _
    Public Property SaldoComision() As Double
        Get
            Return _saldocomision
        End Get
        Set(ByVal value As Double)
            _saldocomision = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndFacturado() As Integer
        Get
            Return _indfacturado
        End Get
        Set(ByVal value As Integer)
            _indfacturado = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndOperacion() As Integer
        Get
            Return _indoperacion
        End Get
        Set(ByVal value As Integer)
            _indoperacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _idmovimientodocumento
        End Get
        Set(ByVal value As String)
            _idmovimientodocumento = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaCrea() As Date
        Get
            Return _fechacrea
        End Get
        Set(ByVal value As Date)
            _fechacrea = value
        End Set
    End Property
    <DataMember()> _
    Public Property UsuarioCrea() As String
        Get
            Return _usuariocrea
        End Get
        Set(ByVal value As String)
            _usuariocrea = value
        End Set
    End Property

    Public Function FleteCalcula() As Decimal
        Return (_subtotal + _igv).ToString("###,##0.0000")
    End Function

    <DataMember()> _
    Public Property Documento() As String
        Get
            Return _documento
        End Get
        Set(ByVal value As String)
            _documento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    <DataMember()> _
   Public Property SubTotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
        End Set
    End Property
#End Region
#Region "Constructor"

    Public Sub New()
        Id = ""
        TipoOperacion = ""
        IdDemanda = ""
        IdOperacionDetalle = ""
        IdTercero = ""
        IdContacto = ""
        IdMovimientoDocumento = ""
        FechaCrea = Date.Now
        Serie = ""
        IdOperacion = ""
        Numero = ""
        Observacion = ""
        Glosa = ""
        IdEstado = ""
        Documento = ""
        FleteUnitario = 0
        SubTotal = 0
        Igv = 0
        TotalFlete = 0
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdDemanda As String _
              , ByVal ls_IdOperacionDetalle As String _
              , ByVal ls_IdTercero As String _
              , ByVal ls_IdContacto As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_FleteUnitario As Double _
              , ByVal ln_Igv As Double _
              , ByVal ln_TotalFlete As Double _
              , ByVal ln_SaldoFlete As Double _
              , ByVal ln_AdelantoFlete As Double _
              , ByVal ln_Comision As Double _
              , ByVal ln_SaldoComision As Double _
              , ByVal ln_IndFacturado As Integer _
              , ByVal ln_IndOperacion As Integer _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ld_FechaCrea As Date _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ls_IdOperacion As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ls_Observacion As String _
              , ByVal ls_Glosa As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_documento As String _
              , ByVal ld_cantidad As Double _
              , ByVal ld_subtotal As Double)
        _id = ls_Id
        _iddemanda = ls_IdDemanda
        _idoperaciondetalle = ls_IdOperacionDetalle
        _idtercero = ls_IdTercero
        _idcontacto = ls_IdContacto
        _idmoneda = ls_IdMoneda
        _fleteunitario = ln_FleteUnitario
        _igv = ln_Igv
        _totalflete = ln_TotalFlete
        _saldoflete = ln_SaldoFlete
        _adelantoflete = ln_AdelantoFlete
        _comision = ln_Comision
        _saldocomision = ln_SaldoComision
        _indfacturado = ln_IndFacturado
        _indoperacion = ln_IndOperacion
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _fechacrea = ld_FechaCrea
        _usuariocrea = ls_UsuarioCrea
        _idoperacion = ls_IdOperacion
        _serie = ls_Serie
        _numero = ls_Numero
        _Observacion = ls_Observacion
        _glosa = ls_Glosa
        _idestado = ls_IdEstado
        _documento = ls_documento
        _cantidad = ld_cantidad
        _subtotal = ld_subtotal
    End Sub

#End Region
End Class
