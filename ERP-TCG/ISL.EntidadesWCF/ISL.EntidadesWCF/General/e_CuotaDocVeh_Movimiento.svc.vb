' NOTA: si cambia aquí el nombre de clase "e_CuotaDocVeh_Movimiento", también debe actualizar la referencia a "e_CuotaDocVeh_Movimiento" tanto en Web.config como en el archivo .svc asociado.
Public Class e_CuotaDocVeh_Movimiento
    Implements Ie_CuotaDocVeh_Movimiento

#Region "Propiedad"

    Private _id As String
    Private _tipo As String
    Private _glosa As String
    Private _fecha As Date
    Private _idmovimientodocumento As String
    Private _idmovimientocajabanco As String
    Private _idmoneda As String
    Private _tipocambio As Double
    Private _montomn As Double
    Private _montome As Double
    Private _activo As Boolean
    Private _fechaceacion As Date
    Private _usuariocreacion As String
    Public TipoOperacion As String
    Public Modificado As Boolean
    Public leCuota As New List(Of e_CuotaDocumentoVehiculo)
    Public leDocumento As New List(Of e_DocumentoVehicular_Documento)
    Public leCuotasNuevas As New List(Of e_CuotaDocumentoVehiculo)
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Event DatoCambiado()

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdMovimientoDocumento() As String
        Get
            Return _idmovimientodocumento
        End Get
        Set(ByVal value As String)
            _idmovimientodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdMovimientoCajaBanco() As String
        Get
            Return _idmovimientocajabanco
        End Get
        Set(ByVal value As String)
            _idmovimientocajabanco = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property MontoMN() As Double
        Get
            Return _montomn
        End Get
        Set(ByVal value As Double)
            _montomn = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property MontoME() As Double
        Get
            Return _montome
        End Get
        Set(ByVal value As Double)
            _montome = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property FechaCeacion() As Date
        Get
            Return _fechaceacion
        End Get
        Set(ByVal value As Date)
            _fechaceacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New( _
           ByVal ls_Id As String _
           , ByVal ls_Tipo As String _
           , ByVal ls_Glosa As String _
           , ByVal ld_Fecha As Date _
           , ByVal ls_IdMovimientoDocumento As String _
           , ByVal ls_IdMovimientoCajaBanco As String _
           , ByVal ls_IdMoneda As String _
           , ByVal ln_TipoCambio As Double _
           , ByVal ln_MontoMN As Double _
           , ByVal ln_MontoME As Double _
           , ByVal lb_Activo As Boolean _
           , ByVal ld_FechaCeacion As Date _
           , ByVal ls_UsuarioCreacion As String _
        )
        _id = ls_Id
        _tipo = ls_Tipo
        _glosa = ls_Glosa
        _fecha = ld_Fecha
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _idmovimientocajabanco = ls_IdMovimientoCajaBanco
        _idmoneda = ls_IdMoneda
        _tipocambio = ln_TipoCambio
        _montomn = ln_MontoMN
        _montome = ln_MontoME
        _activo = lb_Activo
        _fechaceacion = ld_FechaCeacion
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal cuotadocveh_movimiento As e_CuotaDocVeh_Movimiento) As e_CuotaDocVeh_Movimiento Implements Ie_CuotaDocVeh_Movimiento.Obtener
        Return cuotadocveh_movimiento
    End Function

#End Region

End Class
