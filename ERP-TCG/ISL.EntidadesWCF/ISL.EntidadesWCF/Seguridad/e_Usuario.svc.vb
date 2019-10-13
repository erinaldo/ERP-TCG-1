Imports System.Net
Imports System.Security.Principal
Imports System.Threading
Imports System.ServiceModel.Activation

''' <summary>
''' Entidad para almacenar información del Usuario del sistema
''' </summary>
''' <remarks></remarks>
''' 
<DataContract(), SerializableAttribute(), _
ServiceBehavior(IncludeExceptionDetailInFaults:=True), _
    AspNetCompatibilityRequirements(RequirementsMode:= _
    AspNetCompatibilityRequirementsMode.Allowed)> _
Public Class e_Usuario
    Implements Ie_Usuario

#Region "Definicion de Variables"

    Private _Id As String
    Private _Codigo As String
    Private _Login As String
    Private _Clave As String
    Private _activo As Boolean = False
    Private _autenticado As Boolean = False
    Private _FechaUltimoIngreso As Date
    Private _IndFechaUltimoIngreso As Boolean = False
    Private _Restringido As Boolean = False
    Private _controlado As Integer

    <DataMember()> _
    Public oePersona As New e_Persona
    <DataMember()> _
    Public oeArea As New e_Area
    <DataMember()> _
    Public leUsuarioPerfil As New List(Of e_UsuarioPerfil)
    <DataMember()> _
    Public leDetalleEntorno As New List(Of e_DetalleEntornoTrabajo)
    <DataMember()> _
    Public leTurnoUsuario As New List(Of e_TurnoUsuario)
    <DataMember()> _
    Public oeControlTurnoUsuario As New e_ControlTurnoUsuario
    <DataMember()> _
    Public leARUsuario As New List(Of e_ActividadRestringida_Usuario)

    'Public leMenu As New List(Of e_MenuProceso)
    <DataMember()> _
    Public Shadows TipoOperacion As String
    <DataMember()> _
    Public Shadows Modificado As Boolean = False
    <DataMember()> _
    Public IdTrabajador As String
    <DataMember()> _
    Public Ingresado As Integer = 0
    <DataMember()> _
    Public NoIngresado As Integer = 0
    <DataMember()> _
    Public FechaFinal As Date = #1/1/1901#
    <DataMember()> _
    Public IndCompleto As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

#End Region

#Region "Constructor"

    Sub New()
        _Id = ""
        _Codigo = ""
        _Login = ""
        _Clave = ""
        _activo = True
        _FechaUltimoIngreso = #1/1/1901#
        TipoOperacion = ""
        _controlado = 0
    End Sub

    ''' <summary>
    ''' Crea un usuario a partir de su login y clave
    ''' </summary>
    ''' <param name="login">Nombre del usuario</param>
    ''' <param name="clave">Clave de acceso al sistema o password</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal login As String, ByVal clave As String)
        _Login = login
        _Clave = clave
        _Id = ""
        _activo = True
    End Sub

    ''' <summary>
    ''' Crea un Usuario
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <param name="Codigo"></param>
    ''' <param name="Login"></param>
    ''' <param name="Clave"></param>
    ''' <param name="lb_Activo"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Id As String, ByVal Codigo As String, ByVal Login As String, ByVal Clave As String, ByVal lb_Activo As Boolean _
                   , ByVal ApellidoPaterno As String, ByVal ApellidoMaterno As String, ByVal Nombre As String, ByVal Dni As String _
                   , ByVal Sexo As e_Sexo, ByVal FechaNacimiento As Date, ByVal IdPersona As String, ByVal ls_Trabajador As String _
                   , ByVal ls_Area As String, ByVal ls_IdArea As String, ByVal ln_Controlado As Integer, ByVal ld_FechaUltimoIngreso As Date)

        _Id = Id
        _Codigo = Codigo
        _Login = Login
        _Clave = Clave
        _activo = lb_Activo
        IdTrabajador = ls_Trabajador
        _controlado = ln_Controlado
        _FechaUltimoIngreso = ld_FechaUltimoIngreso

        oePersona.Id = IdPersona
        oePersona.ApellidoPaterno = ApellidoPaterno
        oePersona.ApellidoMaterno = ApellidoMaterno
        oePersona.Nombre = Nombre
        oePersona.Dni = Dni
        oePersona.oeSexo.Nombre = Sexo.Nombre
        oePersona.oeSexo.Id = Sexo.Id
        oePersona.FechaNacimiento = FechaNacimiento

        oeArea.Nombre = ls_Area
        oeArea.Id = ls_IdArea

    End Sub

    Public Sub New(ByVal _oePersona As e_Persona)
        With _oePersona
            oePersona.Id = .Id
            oePersona.Codigo = .Codigo
            oePersona.Activo = .Activo
        End With
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id de Usuario
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    ''' <summary>
    ''' Codigo Usuario
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    ''' <summary>
    ''' Login de Usuario
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Login() As String
        Get
            Return _Login
        End Get
        Set(ByVal value As String)
            _Login = value
        End Set
    End Property

    ''' <summary>
    ''' Clave de Usuario
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Clave() As String
        Get
            Return _Clave
        End Get
        Set(ByVal value As String)
            _Clave = value
        End Set
    End Property

    ''' <summary>
    ''' Identificar si el usuario està autenticado o no
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Autenticado() As Boolean
        Get
            Return _autenticado
        End Get
        Set(ByVal value As Boolean)
            _autenticado = value
        End Set
    End Property

    ''' <summary>
    ''' Fecha de Ultimo Ingreso al Sistema del Usuario
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property FechaUltimoIngreso() As Date
        Get
            Return _FechaUltimoIngreso
        End Get
        Set(ByVal value As Date)
            _FechaUltimoIngreso = value
        End Set
    End Property

    ''' <summary>
    ''' Indicador para actulizar la fecha de ultimo ingreso al sistema
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property IndFechaUltimoIngreso() As Boolean
        Get
            Return _IndFechaUltimoIngreso
        End Get
        Set(ByVal value As Boolean)
            _IndFechaUltimoIngreso = value
        End Set
    End Property

    ''' <summary>
    ''' Activo Usuario
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    ''' <summary>
    ''' Usuario con restrincciones
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Restringido() As Boolean
        Get
            Return _Restringido
        End Get
        Set(ByVal value As Boolean)
            _Restringido = value
        End Set
    End Property

    <DataMember()> _
    Public Property Controlado() As Integer
        Get
            Return _controlado
        End Get
        Set(ByVal value As Integer)
            _controlado = value
        End Set
    End Property

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Retorna la Dirección IP
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerIP() As String Implements Ie_Usuario.ObtenerIP
        Dim privateIP As String = String.Empty
        Try
            'Return Dns.Resolve(My.Computer.Name).AddressList(0).ToString
            Dim ip() As System.Net.IPAddress = System.Net.Dns.GetHostEntry(My.Computer.Name).AddressList
            For Each k In ip
                If k.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                    privateIP = k.ToString()
                    Exit For
                End If
            Next
            Return privateIP
        Catch ex As Exception
            Throw ex
        End Try
        'Return privateIP
    End Function

    ''' <summary>
    ''' Retorna Nombre de la PC
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerNombrePC() As String Implements Ie_Usuario.ObtenerNombrePC
        Dim nombrePC As String = String.Empty
        Try
            nombrePC = My.Computer.Name
        Catch ex As Exception
            nombrePC = "(No Disponible)"
        End Try
        Return nombrePC
    End Function

    ''' <summary>
    ''' Retorna Nombre de Usuario de Windows
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerLoginWindows() As String Implements Ie_Usuario.ObtenerLoginWindows
        Return Thread.CurrentPrincipal.Identity.Name()
    End Function

    ''' <summary>
    ''' Obtener una entidad de tipo e_Usuario
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal usuario As e_Usuario) As e_Usuario Implements Ie_Usuario.Obtener
        Return usuario
    End Function

    ''' <summary>
    ''' Función que retorna el número de días que el usuario no ha ingresado al sistema
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DiasSinIngreso() As Integer
        Dim nroDiasSinIngreso As TimeSpan = Date.Now - FechaUltimoIngreso.Date
        If nroDiasSinIngreso.Days > 0 Then
            Return nroDiasSinIngreso.Days
        Else
            Return 0
        End If
    End Function

    ''' <summary>
    ''' Método para inicializar la entidad e_Usuario con sus entidades derivadas
    ''' </summary>
    ''' <remarks></remarks>
    Public Function Inicializar() As e_Usuario Implements Ie_Usuario.Inicializar
        Dim oeUsuario As New e_Usuario
        Dim area As New e_Area
        area.Activo = True
        Dim persona As New e_Persona
        persona.Activo = True
        Dim controlturnousuario As New e_ControlTurnoUsuario
        controlturnousuario.Activo = True
        oeUsuario.oeArea = area
        oeUsuario.oePersona = persona
        oeUsuario.oeControlTurnoUsuario = controlturnousuario
        Return oeUsuario
    End Function

#End Region

End Class


''' <summary>
''' Clase para almacenar información de los usuarios del SGI actualmente conectados
''' </summary>
''' <remarks></remarks>
Public Class e_UsuarioConectado

#Region "Constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal nombreTrabajador As String, ByVal usuario As String, ByVal conectadoDesdePc As String, ByVal area As String, ByVal ocupacion As String, ByVal fechaInicio As Date, ByVal tiempoTranscurrido As String)
        _id = id
        _nombreTrabajador = nombreTrabajador
        _usuario = usuario
        _conectadoDesdePc = conectadoDesdePc
        _area = area
        _ocupacion = ocupacion
        _fechaInicio = fechaInicio
        _tiempoTranscurrido = tiempoTranscurrido
    End Sub

#End Region

#Region "Propiedades"

    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property


    Private _nombreTrabajador As String
    Public Property NombreTrabajador() As String
        Get
            Return _nombreTrabajador
        End Get
        Set(ByVal value As String)
            _nombreTrabajador = value
        End Set
    End Property

    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property


    Private _area As String
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
        End Set
    End Property


    Private _ocupacion As String
    Public Property Ocupacion() As String
        Get
            Return _ocupacion
        End Get
        Set(ByVal value As String)
            _ocupacion = value
        End Set
    End Property

    Private _conectadoDesdePc As String
    Public Property ConectadoDesdePC() As String
        Get
            Return _conectadoDesdePc
        End Get
        Set(ByVal value As String)
            _conectadoDesdePc = value
        End Set
    End Property


    Private _fechaInicio As Date
    Public Property FechaInicio() As Date
        Get
            Return _fechaInicio
        End Get
        Set(ByVal value As Date)
            _fechaInicio = value
        End Set
    End Property


    Private _tiempoTranscurrido As String
    Public Property TiempoTranscurrido() As String
        Get
            Return _tiempoTranscurrido
        End Get
        Set(ByVal value As String)
            _tiempoTranscurrido = value
        End Set
    End Property


#End Region


End Class

''' <summary>
''' Clase para almacenar información de usuarios desconectados del SGI
''' </summary>
''' <remarks></remarks>
Public Class e_UsuarioDesconectado


#Region "Constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal nombreTrabajador As String, ByVal usuario As String, ByVal conectadoDesdePc As String, ByVal area As String, ByVal ocupacion As String, ByVal fechaSalida As Date, ByVal tiempoTranscurrido As String)
        _id = id
        _nombreTrabajador = nombreTrabajador
        _usuario = usuario
        _conectadoDesdePc = conectadoDesdePc
        _area = area
        _ocupacion = ocupacion
        _fechaSalida = fechaSalida
        _tiempoTranscurrido = tiempoTranscurrido
    End Sub

#End Region

#Region "Propiedades"

    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _nombreTrabajador As String
    Public Property NombreTrabajador() As String
        Get
            Return _nombreTrabajador
        End Get
        Set(ByVal value As String)
            _nombreTrabajador = value
        End Set
    End Property

    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _area As String
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
        End Set
    End Property

    Private _ocupacion As String
    Public Property Ocupacion() As String
        Get
            Return _ocupacion
        End Get
        Set(ByVal value As String)
            _ocupacion = value
        End Set
    End Property

    Private _conectadoDesdePc As String
    Public Property ConectadoDesdePC() As String
        Get
            Return _conectadoDesdePc
        End Get
        Set(ByVal value As String)
            _conectadoDesdePc = value
        End Set
    End Property

    Private _fechaSalida As Date
    Public Property FechaSalida() As Date
        Get
            Return _fechaSalida
        End Get
        Set(ByVal value As Date)
            _fechaSalida = value
        End Set
    End Property

    Private _tiempoTranscurrido As String
    Public Property TiempoTranscurrido() As String
        Get
            Return _tiempoTranscurrido
        End Get
        Set(ByVal value As String)
            _tiempoTranscurrido = value
        End Set
    End Property


#End Region


End Class


''' <summary>
''' Clase para almacenar información de usuarios desconectados del SGI
''' </summary>
''' <remarks></remarks>
Public Class e_UsuarioSinAcceso

#Region "Constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal nombreTrabajador As String, ByVal usuario As String, ByVal area As String, ByVal ocupacion As String, ByVal fechaUltimoIngreso As Date, ByVal tiempoTranscurrido As String)
        _id = id
        _nombreTrabajador = nombreTrabajador
        _usuario = usuario
        _area = area
        _ocupacion = ocupacion
        _fechaUltimoIngreso = fechaUltimoIngreso
        _tiempoTranscurrido = tiempoTranscurrido
    End Sub

#End Region

#Region "Propiedades"

    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _nombreTrabajador As String
    Public Property NombreTrabajador() As String
        Get
            Return _nombreTrabajador
        End Get
        Set(ByVal value As String)
            _nombreTrabajador = value
        End Set
    End Property

    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _area As String
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
        End Set
    End Property

    Private _ocupacion As String
    Public Property Ocupacion() As String
        Get
            Return _ocupacion
        End Get
        Set(ByVal value As String)
            _ocupacion = value
        End Set
    End Property

    Private _fechaUltimoIngreso As Date
    Public Property FechaUltimoIngreso() As Date
        Get
            Return _fechaUltimoIngreso
        End Get
        Set(ByVal value As Date)
            _fechaUltimoIngreso = value
        End Set
    End Property

    Private _tiempoTranscurrido As String
    Public Property TiempoTranscurrido() As String
        Get
            Return _tiempoTranscurrido
        End Get
        Set(ByVal value As String)
            _tiempoTranscurrido = value
        End Set
    End Property

#End Region

End Class