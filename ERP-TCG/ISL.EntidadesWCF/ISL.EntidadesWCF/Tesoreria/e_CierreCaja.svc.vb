' NOTA: si cambia aquí el nombre de clase "e_CierreCaja", también debe actualizar la referencia a "e_CierreCaja" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_CierreCaja
    Implements Ie_CierreCaja

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _idcaja As New e_Caja
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _glosa As String
    Private _monto As Double
    Private _idcentro As New e_Centro
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public loCierreCajaDet As New List(Of e_CierreCajaDet)

    <DataMember()> _
    Public oeMovimiento As New e_Movimiento
    <DataMember()> _
    Public oeGastoOperacion As New e_GastoOperacion
    <DataMember()> _
    Public oeValesRendir As New e_ValesRendir
    <DataMember()> _
    Public oeOtrosIngresos As New e_OtrosIngresos

    Event DatoCambiado()

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
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
    Public Property IdCaja() As String
        Get
            Return _idcaja.Id
        End Get
        Set(ByVal value As String)
            _idcaja.Id = value
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
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _idcentro.Id
        End Get
        Set(ByVal value As String)
            _idcentro.Id = value
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
              , ByVal ls_Codigo As String _
              , ByVal ls_IdCaja As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ln_Monto As Double _
              , ByVal ls_IdCentro As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _idcaja.Id = ls_IdCaja
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _monto = ln_Monto
        _idcentro.Id = ls_IdCentro
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal cierrecaja As e_CierreCaja) As e_CierreCaja Implements Ie_CierreCaja.Obtener
        Return cierrecaja
    End Function

End Class
