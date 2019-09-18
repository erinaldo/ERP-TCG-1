' NOTA: si cambia aquí el nombre de clase "e_MovimientoMermas", también debe actualizar la referencia a "e_MovimientoMermas" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_MovimientoMermas
    Implements Ie_MovimientoMermas

#Region "Propiedad"

    Private _id As String
    Private _indingresosalida As Integer
    Private _idpersona As String
    Private _trabajador As String
    Private _idsancion As String
    Private _fecha As Date
    Private _porcentajedescuento As Integer
    Private _subtotal As Double
    Private _centro As New e_Centro
    Private _saldo As Double
    Private _descuento As Double
    Private _total As Double
    Private _glosa As String
    Private _idestado As String
    Private _serie As String
    Private _numero As String
    Private _indcobro As Integer
    Private _tipopago As Integer
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _seleccion As Boolean

    <DataMember()> _
    Public IdCuentaCorriente As String
    <DataMember()>
    Public IdCaja As String = ""
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public ListaControlMermas As New List(Of e_ControlMerma)
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    <DataMember()>
    Public PrefijoID As String = ""


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
    Public Property IndIngresoSalida() As Integer
        Get
            Return _indingresosalida
        End Get
        Set(ByVal value As Integer)
            _indingresosalida = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPersona() As String
        Get
            Return _idpersona
        End Get
        Set(ByVal value As String)
            _idpersona = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSancion() As String
        Get
            Return _idsancion
        End Get
        Set(ByVal value As String)
            _idsancion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeDescuento() As Integer
        Get
            Return _porcentajedescuento
        End Get
        Set(ByVal value As Integer)
            _porcentajedescuento = value
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

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value

        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _centro.Id
        End Get
        Set(ByVal value As String)
            _centro.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descuento() As Double
        Get
            Return _descuento
        End Get
        Set(ByVal value As Double)
            _descuento = value

        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value

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
    Public Property IndCobro() As Integer
        Get
            Return _indcobro
        End Get
        Set(ByVal value As Integer)
            _indcobro = value

        End Set
    End Property

    <DataMember()> _
    Public Property TipoPago() As Integer
        Get
            Return _tipopago
        End Get
        Set(ByVal value As Integer)
            _tipopago = value

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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        Id = ""
        TipoOperacion = ""
        Fecha = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean, ByVal ls_Id As String _
              , ByVal ln_IndIngresoSalida As Integer _
              , ByVal ls_IdPersona As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_IdSancion As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_PorcentajeDescuento As Integer _
              , ByVal ln_SubTotal As Double _
              , ByVal ln_Saldo As Double _
              , ByVal ln_Descuento As Double _
              , ByVal ln_Total As Double _
              , ByVal ls_Glosa As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ln_IndCobro As Integer _
              , ByVal ln_TipoPago As Integer _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean)
        _seleccion = lb_Seleccion
        _id = ls_Id
        _indingresosalida = ln_IndIngresoSalida
        _idpersona = ls_IdPersona
        _trabajador = ls_Trabajador
        _idsancion = ls_IdSancion
        _fecha = ld_Fecha
        _porcentajedescuento = ln_PorcentajeDescuento
        _subtotal = ln_SubTotal
        _saldo = ln_Saldo
        _descuento = ln_Descuento
        _total = ln_Total
        _glosa = ls_Glosa
        _idestado = ls_IdEstado
        _serie = ls_Serie
        _numero = ls_Numero
        _indcobro = ln_IndCobro
        _tipopago = ln_TipoPago
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

End Class
