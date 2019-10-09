' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_DocVehDocPago
    Implements Ie_DocVehDocPago

#Region "Propiedad"

    Private _id As String
    Private _iddocveh_doc As String
    Private _idcuotadocveh_mov As String
    Private _glosa As String
    Private _monto As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    Public TipoOperacion As String
    Public Modificado As Boolean
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

    Public Property IdDocVeh_Doc() As String
        Get
            Return _iddocveh_doc
        End Get
        Set(ByVal value As String)
            _iddocveh_doc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdCuotaDocVeh_Mov() As String
        Get
            Return _idcuotadocveh_mov
        End Get
        Set(ByVal value As String)
            _idcuotadocveh_mov = value
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

    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
              , ByVal ls_IdDocVeh_Doc As String _
              , ByVal ls_IdCuotaDocVeh_Mov As String _
              , ByVal ls_Glosa As String _
              , ByVal ln_Monto As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _iddocveh_doc = ls_IdDocVeh_Doc
        _idcuotadocveh_mov = ls_IdCuotaDocVeh_Mov
        _glosa = ls_Glosa
        _monto = ln_Monto
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal docvehdocpago As e_DocVehDocPago) As e_DocVehDocPago Implements Ie_DocVehDocPago.Obtener
        Return docvehdocpago
    End Function

#End Region

End Class
