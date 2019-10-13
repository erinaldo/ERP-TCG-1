

<DataContract()> _
Public Class e_ControlPersonaES
    Implements Ie_ControlPersonaES

#Region "Propiedad"

    Private _id As String
    Private _ingreso As Date
    Private _salida As Date
    Private _dni As String
    Private _nombre As String
    Private _indtrabajador As Integer
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
    Public Property Ingreso() As Date
        Get
            Return _ingreso
        End Get
        Set(ByVal value As Date)
            _ingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Salida() As Date
        Get
            Return _salida
        End Get
        Set(ByVal value As Date)
            _salida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DNI() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndTrabajador() As Integer
        Get
            Return _indtrabajador
        End Get
        Set(ByVal value As Integer)
            _indtrabajador = value
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
              , ByVal ld_Ingreso As Date _
              , ByVal ld_Salida As Date _
              , ByVal ls_DNI As String _
              , ByVal ls_Nombre As String _
              , ByVal ln_IndTrabajador As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _ingreso = ld_Ingreso
        _salida = ld_Salida
        _dni = ls_DNI
        _nombre = ls_Nombre
        _indtrabajador = ln_IndTrabajador
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal controlPersonaES As e_ControlPersonaES) As e_ControlPersonaES Implements Ie_ControlPersonaES.Obtener
        Return controlPersonaES
    End Function

End Class


