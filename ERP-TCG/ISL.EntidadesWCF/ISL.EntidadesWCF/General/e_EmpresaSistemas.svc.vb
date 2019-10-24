' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_EmpresaSistemas" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_EmpresaSistemas.svc o e_EmpresaSistemas.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract>
Public Class e_EmpresaSistemas
    Implements Ie_EmpresaSistemas

    Public Sub DoWork() Implements Ie_EmpresaSistemas.DoWork
    End Sub
#Region "Declaración de variables"

    Private _Id As String
    Private _Codigo As String
    Private _Abreviatura As String
    Private _Nombre As String
    Private _IdEmpresa As String
    Private _TokenRuc As String
    Private _IndPrincipal As Boolean
    Private _UsuarioCrea As String
    Private _FechaCrea As Date
    Private _UsuarioModifica As String
    Private _FechaModifica As Date
    Private _Activo As Boolean
    Private _RutaDocumentos As String
    Private _RutaCDR As String
    Private _RutaFirma As String
    Private _ClaveFirma As String
    Private _Ubigeo As String
    Private _Departamento As String
    Private _Provincia As String
    Private _Distrito As String
    Private _Direccion As String
    Private _UsuarioSol As String
    Private _ClaveSol As String
    Private _EstadoDisponibilidadBD As String
    Private _MensajeInicialBD As String
    Private _MensajeUsuariosConectadosBD As String
    Private _EstadoDisponibilidadReplica As String
    Private _MensajeInicialRP As String
    Private _MensajeUsuariosConectadosRP As String
    Private _Compras As String
    Private _Ventas As String
    Private _Contabilidad As String
    Private _Administracion As String
    Private _Neumaticos As String
    Private _Operaciones As String
    Private _Planeamiento As String
    Private _Finanzas As String
    Private _Logistica As String
    Private _Mantenimiento As String
    Private _Personal As String
    Private _Tesoreria As String
    Private _Comercial As String
    Private _Reportes As String
    Private _Seguridad As String
    Private _Configuracion As String
    Private _Operador As String
    Private _Asistente As String
    Private _Analista As String
    Private _Administrador As String
    Private _Supervisor As String
    Private _Cajero As String
    Private _Coordinador As String
    Private _Jefe As String
    Private _Gerente As String
    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

#End Region
#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _Codigo = ""
        _Abreviatura = ""
        _Nombre = ""
        _IdEmpresa = ""
        _TokenRuc = ""
        _IndPrincipal = True
        _UsuarioCrea = ""
        _FechaCrea = #01/01/1901#
        _UsuarioModifica = ""
        _FechaModifica = #01/01/1901#
        _Activo = True
        _RutaDocumentos = ""
        _RutaCDR = ""
        _RutaFirma = ""
        _ClaveFirma = ""
        _Ubigeo = ""
        _Departamento = ""
        _Provincia = ""
        _Distrito = ""
        _Direccion = ""
        _UsuarioSol = ""
        _ClaveSol = ""
        _EstadoDisponibilidadBD = ""
        _MensajeInicialBD = ""
        _MensajeUsuariosConectadosBD = ""
        _EstadoDisponibilidadReplica = ""
        _MensajeInicialRP = ""
        _MensajeUsuariosConectadosRP = ""
        _Compras = ""
        _Ventas = ""
        _Contabilidad = ""
        _Administracion = ""
        _Neumaticos = ""
        _Operaciones = ""
        _Planeamiento = ""
        _Finanzas = ""
        _Logistica = ""
        _Mantenimiento = ""
        _Personal = ""
        _Tesoreria = ""
        _Comercial = ""
        _Reportes = ""
        _Seguridad = ""
        _Configuracion = ""
        _Operador = ""
        _Asistente = ""
        _Analista = ""
        _Administrador = ""
        _Supervisor = ""
        _Cajero = ""
        _Coordinador = ""
        _Jefe = ""
        _Gerente = ""
    End Sub

    Public Sub New(
          ByVal ls_Id As String _
          , ByVal ls_Codigo As String _
          , ByVal ls_Abreviatura As String _
          , ByVal ls_Nombre As String _
          , ByVal ls_IdEmpresa As String _
          , ByVal ls_TokenRuc As String _
          , ByVal lb_IndPrincipal As Boolean _
          , ByVal ls_UsuarioCrea As String _
          , ByVal ld_FechaCrea As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal lb_Activo As Boolean _
          , ByVal ls_RutaDocumentos As String _
          , ByVal ls_RutaCDR As String _
          , ByVal ls_RutaFirma As String _
          , ByVal ls_ClaveFirma As String _
          , ByVal ls_Ubigeo As String _
          , ByVal ls_Departamento As String _
          , ByVal ls_Provincia As String _
          , ByVal ls_Distrito As String _
          , ByVal ls_Direccion As String _
          , ByVal ls_UsuarioSol As String _
          , ByVal ls_ClaveSol As String _
          , ByVal ls_EstadoDisponibilidadBD As String _
          , ByVal ls_MensajeInicialBD As String _
          , ByVal ls_MensajeUsuariosConectadosBD As String _
          , ByVal ls_EstadoDisponibilidadReplica As String _
          , ByVal ls_MensajeInicialRP As String _
          , ByVal ls_MensajeUsuariosConectadosRP As String _
          , ByVal ls_Compras As String _
          , ByVal ls_Ventas As String _
          , ByVal ls_Contabilidad As String _
          , ByVal ls_Administracion As String _
          , ByVal ls_Neumaticos As String _
          , ByVal ls_Operaciones As String _
          , ByVal ls_Planeamiento As String _
          , ByVal ls_Finanzas As String _
          , ByVal ls_Logistica As String _
          , ByVal ls_Mantenimiento As String _
          , ByVal ls_Personal As String _
          , ByVal ls_Tesoreria As String _
          , ByVal ls_Comercial As String _
          , ByVal ls_Reportes As String _
          , ByVal ls_Seguridad As String _
          , ByVal ls_Configuracion As String _
          , ByVal ls_Operador As String _
          , ByVal ls_Asistente As String _
          , ByVal ls_Analista As String _
          , ByVal ls_Administrador As String _
          , ByVal ls_Supervisor As String _
          , ByVal ls_Cajero As String _
          , ByVal ls_Coordinador As String _
          , ByVal ls_Jefe As String _
          , ByVal ls_Gerente As String
       )
        _Id = ls_Id
        _Codigo = ls_Codigo
        _Abreviatura = ls_Abreviatura
        _Nombre = ls_Nombre
        _IdEmpresa = ls_IdEmpresa
        _TokenRuc = ls_TokenRuc
        _IndPrincipal = lb_IndPrincipal
        _UsuarioCrea = ls_UsuarioCrea
        _FechaCrea = ld_FechaCrea
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModifica = ld_FechaModifica
        _Activo = lb_Activo
        _RutaDocumentos = ls_RutaDocumentos
        _RutaCDR = ls_RutaCDR
        _RutaFirma = ls_RutaFirma
        _ClaveFirma = ls_ClaveFirma
        _Ubigeo = ls_Ubigeo
        _Departamento = ls_Departamento
        _Provincia = ls_Provincia
        _Distrito = ls_Distrito
        _Direccion = ls_Direccion
        _UsuarioSol = ls_UsuarioSol
        _ClaveSol = ls_ClaveSol
        _EstadoDisponibilidadBD = ls_EstadoDisponibilidadBD
        _MensajeInicialBD = ls_MensajeInicialBD
        _MensajeUsuariosConectadosBD = ls_MensajeUsuariosConectadosBD
        _EstadoDisponibilidadReplica = ls_EstadoDisponibilidadReplica
        _MensajeInicialRP = ls_MensajeInicialRP
        _MensajeUsuariosConectadosRP = ls_MensajeUsuariosConectadosRP
        _Compras = ls_Compras
        _Ventas = ls_Ventas
        _Contabilidad = ls_Contabilidad
        _Administracion = ls_Administracion
        _Neumaticos = ls_Neumaticos
        _Operaciones = ls_Operaciones
        _Planeamiento = ls_Planeamiento
        _Finanzas = ls_Finanzas
        _Logistica = ls_Logistica
        _Mantenimiento = ls_Mantenimiento
        _Personal = ls_Personal
        _Tesoreria = ls_Tesoreria
        _Comercial = ls_Comercial
        _Reportes = ls_Reportes
        _Seguridad = ls_Seguridad
        _Configuracion = ls_Configuracion
        _Operador = ls_Operador
        _Asistente = ls_Asistente
        _Analista = ls_Analista
        _Administrador = ls_Administrador
        _Supervisor = ls_Supervisor
        _Cajero = ls_Cajero
        _Coordinador = ls_Coordinador
        _Jefe = ls_Jefe
        _Gerente = ls_Gerente
    End Sub

#End Region
#Region "Propiedades"

    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Public Property Abreviatura() As String
        Get
            Return _Abreviatura
        End Get
        Set(ByVal value As String)
            _Abreviatura = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property IdEmpresa() As String
        Get
            Return _IdEmpresa
        End Get
        Set(ByVal value As String)
            _IdEmpresa = value
        End Set
    End Property

    Public Property TokenRuc() As String
        Get
            Return _TokenRuc
        End Get
        Set(ByVal value As String)
            _TokenRuc = value
        End Set
    End Property

    Public Property IndPrincipal() As Boolean
        Get
            Return _IndPrincipal
        End Get
        Set(ByVal value As Boolean)
            _IndPrincipal = value
        End Set
    End Property

    Public Property UsuarioCrea() As String
        Get
            Return _UsuarioCrea
        End Get
        Set(ByVal value As String)
            _UsuarioCrea = value
        End Set
    End Property

    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
        End Set
    End Property

    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property

    Public Property FechaModifica() As Date
        Get
            Return _FechaModifica
        End Get
        Set(ByVal value As Date)
            _FechaModifica = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    Public Property RutaDocumentos() As String
        Get
            Return _RutaDocumentos
        End Get
        Set(ByVal value As String)
            _RutaDocumentos = value
        End Set
    End Property

    Public Property RutaCDR() As String
        Get
            Return _RutaCDR
        End Get
        Set(ByVal value As String)
            _RutaCDR = value
        End Set
    End Property

    Public Property RutaFirma() As String
        Get
            Return _RutaFirma
        End Get
        Set(ByVal value As String)
            _RutaFirma = value
        End Set
    End Property

    Public Property ClaveFirma() As String
        Get
            Return _ClaveFirma
        End Get
        Set(ByVal value As String)
            _ClaveFirma = value
        End Set
    End Property

    Public Property Ubigeo() As String
        Get
            Return _Ubigeo
        End Get
        Set(ByVal value As String)
            _Ubigeo = value
        End Set
    End Property

    Public Property Departamento() As String
        Get
            Return _Departamento
        End Get
        Set(ByVal value As String)
            _Departamento = value
        End Set
    End Property

    Public Property Provincia() As String
        Get
            Return _Provincia
        End Get
        Set(ByVal value As String)
            _Provincia = value
        End Set
    End Property

    Public Property Distrito() As String
        Get
            Return _Distrito
        End Get
        Set(ByVal value As String)
            _Distrito = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property

    Public Property UsuarioSol() As String
        Get
            Return _UsuarioSol
        End Get
        Set(ByVal value As String)
            _UsuarioSol = value
        End Set
    End Property

    Public Property ClaveSol() As String
        Get
            Return _ClaveSol
        End Get
        Set(ByVal value As String)
            _ClaveSol = value
        End Set
    End Property

    Public Property EstadoDisponibilidadBD() As String
        Get
            Return _EstadoDisponibilidadBD
        End Get
        Set(ByVal value As String)
            _EstadoDisponibilidadBD = value
        End Set
    End Property

    Public Property MensajeInicialBD() As String
        Get
            Return _MensajeInicialBD
        End Get
        Set(ByVal value As String)
            _MensajeInicialBD = value
        End Set
    End Property

    Public Property MensajeUsuariosConectadosBD() As String
        Get
            Return _MensajeUsuariosConectadosBD
        End Get
        Set(ByVal value As String)
            _MensajeUsuariosConectadosBD = value
        End Set
    End Property

    Public Property EstadoDisponibilidadReplica() As String
        Get
            Return _EstadoDisponibilidadReplica
        End Get
        Set(ByVal value As String)
            _EstadoDisponibilidadReplica = value
        End Set
    End Property

    Public Property MensajeInicialRP() As String
        Get
            Return _MensajeInicialRP
        End Get
        Set(ByVal value As String)
            _MensajeInicialRP = value
        End Set
    End Property

    Public Property MensajeUsuariosConectadosRP() As String
        Get
            Return _MensajeUsuariosConectadosRP
        End Get
        Set(ByVal value As String)
            _MensajeUsuariosConectadosRP = value
        End Set
    End Property

    Public Property Compras() As String
        Get
            Return _Compras
        End Get
        Set(ByVal value As String)
            _Compras = value
        End Set
    End Property

    Public Property Ventas() As String
        Get
            Return _Ventas
        End Get
        Set(ByVal value As String)
            _Ventas = value
        End Set
    End Property

    Public Property Contabilidad() As String
        Get
            Return _Contabilidad
        End Get
        Set(ByVal value As String)
            _Contabilidad = value
        End Set
    End Property

    Public Property Administracion() As String
        Get
            Return _Administracion
        End Get
        Set(ByVal value As String)
            _Administracion = value
        End Set
    End Property

    Public Property Neumaticos() As String
        Get
            Return _Neumaticos
        End Get
        Set(ByVal value As String)
            _Neumaticos = value
        End Set
    End Property

    Public Property Operaciones() As String
        Get
            Return _Operaciones
        End Get
        Set(ByVal value As String)
            _Operaciones = value
        End Set
    End Property

    Public Property Planeamiento() As String
        Get
            Return _Planeamiento
        End Get
        Set(ByVal value As String)
            _Planeamiento = value
        End Set
    End Property

    Public Property Finanzas() As String
        Get
            Return _Finanzas
        End Get
        Set(ByVal value As String)
            _Finanzas = value
        End Set
    End Property

    Public Property Logistica() As String
        Get
            Return _Logistica
        End Get
        Set(ByVal value As String)
            _Logistica = value
        End Set
    End Property

    Public Property Mantenimiento() As String
        Get
            Return _Mantenimiento
        End Get
        Set(ByVal value As String)
            _Mantenimiento = value
        End Set
    End Property

    Public Property Personal() As String
        Get
            Return _Personal
        End Get
        Set(ByVal value As String)
            _Personal = value
        End Set
    End Property

    Public Property Tesoreria() As String
        Get
            Return _Tesoreria
        End Get
        Set(ByVal value As String)
            _Tesoreria = value
        End Set
    End Property

    Public Property Comercial() As String
        Get
            Return _Comercial
        End Get
        Set(ByVal value As String)
            _Comercial = value
        End Set
    End Property

    Public Property Reportes() As String
        Get
            Return _Reportes
        End Get
        Set(ByVal value As String)
            _Reportes = value
        End Set
    End Property

    Public Property Seguridad() As String
        Get
            Return _Seguridad
        End Get
        Set(ByVal value As String)
            _Seguridad = value
        End Set
    End Property

    Public Property Configuracion() As String
        Get
            Return _Configuracion
        End Get
        Set(ByVal value As String)
            _Configuracion = value
        End Set
    End Property

    Public Property Operador() As String
        Get
            Return _Operador
        End Get
        Set(ByVal value As String)
            _Operador = value
        End Set
    End Property

    Public Property Asistente() As String
        Get
            Return _Asistente
        End Get
        Set(ByVal value As String)
            _Asistente = value
        End Set
    End Property

    Public Property Analista() As String
        Get
            Return _Analista
        End Get
        Set(ByVal value As String)
            _Analista = value
        End Set
    End Property

    Public Property Administrador() As String
        Get
            Return _Administrador
        End Get
        Set(ByVal value As String)
            _Administrador = value
        End Set
    End Property

    Public Property Supervisor() As String
        Get
            Return _Supervisor
        End Get
        Set(ByVal value As String)
            _Supervisor = value
        End Set
    End Property

    Public Property Cajero() As String
        Get
            Return _Cajero
        End Get
        Set(ByVal value As String)
            _Cajero = value
        End Set
    End Property

    Public Property Coordinador() As String
        Get
            Return _Coordinador
        End Get
        Set(ByVal value As String)
            _Coordinador = value
        End Set
    End Property

    Public Property Jefe() As String
        Get
            Return _Jefe
        End Get
        Set(ByVal value As String)
            _Jefe = value
        End Set
    End Property

    Public Property Gerente() As String
        Get
            Return _Gerente
        End Get
        Set(ByVal value As String)
            _Gerente = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal empresaSistemas As e_EmpresaSistemas) As e_EmpresaSistemas Implements Ie_EmpresaSistemas.Obtener
        Return empresaSistemas
    End Function

#End Region
End Class
