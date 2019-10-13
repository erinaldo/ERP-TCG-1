' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_EmpresaAportacion" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_EmpresaAportacion.svc o e_EmpresaAportacion.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_EmpresaAportacion
    Implements Ie_EmpresaAportacion

#Region "Propiedad"

    Private _id As String
    Private _empresa, _empresapensiones As New e_Empresa
    Private _indsistemapension As Integer
    Private _indcomisionafp As Integer
    Private _fechanacimiento As Date
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public TotalPorcentaje As Double
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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
    Public Property IdEmpresa() As String
        Get
            Return _empresa.Id
        End Get
        Set(ByVal value As String)
            _empresa.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresaPensiones() As String
        Get
            Return _empresapensiones.Id
        End Get
        Set(ByVal value As String)
            _empresapensiones.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndSistemaPension() As Integer
        Get
            Return _indsistemapension
        End Get
        Set(ByVal value As Integer)
            _indsistemapension = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndComisionAFP() As Integer
        Get
            Return _indcomisionafp
        End Get
        Set(ByVal value As Integer)
            _indcomisionafp = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaNacimiento() As Date
        Get
            Return _fechanacimiento
        End Get
        Set(ByVal value As Date)
            _fechanacimiento = value
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
        Id = ""
        IdEmpresaPensiones = ""
        TotalPorcentaje = 0
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
                   , ByVal ls_IdEmpresa As String _
                   , ByVal ls_IdEmpresaPensiones As String _
                   , ByVal ln_IndSistemaPension As Integer _
                   , ByVal ln_IndComisionAFP As Integer _
                   , ByVal ld_FechaNacimiento As Date _
                   , ByVal ls_UsuarioCreacion As String)
        _id = ls_Id
        _empresa.Id = ls_IdEmpresa
        _empresapensiones.Id = ls_IdEmpresaPensiones
        _indsistemapension = ln_IndSistemaPension
        _indcomisionafp = ln_IndComisionAFP
        _fechanacimiento = ld_FechaNacimiento
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal empresa As e_EmpresaAportacion) As e_EmpresaAportacion Implements Ie_EmpresaAportacion.Obtener
        Return empresa
    End Function

#End Region

End Class
