' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_AsientoReferencia" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_AsientoReferencia.svc o e_AsientoReferencia.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_AsientoReferencia
    Implements Ie_AsientoReferencia


#Region "Declaración de variables"

    Private _Id As String
    Private _IdAsiento As String
    Private _IdReferencia As String
    Private _TipoReferencia As Integer
    Private _FechaCreacion As Date
    Private _Activo As Boolean
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdAsiento = ""
        _IdReferencia = ""
        _TipoReferencia = 0
        _FechaCreacion = #1/1/1901#
        _Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAsiento As String _
              , ByVal ls_IdReferencia As String _
              , ByVal ln_TipoReferencia As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
           )
        _Id = ls_Id
        _IdAsiento = ls_IdAsiento
        _IdReferencia = ls_IdReferencia
        _TipoReferencia = ln_TipoReferencia
        _FechaCreacion = ld_FechaCreacion
        _Activo = lb_Activo
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

    Public Property IdAsiento() As String
        Get
            Return _IdAsiento
        End Get
        Set(ByVal value As String)
            _IdAsiento = value
        End Set
    End Property

    Public Property IdReferencia() As String
        Get
            Return _IdReferencia
        End Get
        Set(ByVal value As String)
            _IdReferencia = value
        End Set
    End Property

    Public Property TipoReferencia() As Integer
        Get
            Return _TipoReferencia
        End Get
        Set(ByVal value As Integer)
            _TipoReferencia = value
        End Set
    End Property

    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
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

#End Region

#Region "Metodos"

    Public Function Obtener(asientoReferencia As e_AsientoReferencia) As e_AsientoReferencia Implements Ie_AsientoReferencia.Obtener
        Return asientoReferencia
    End Function

#End Region

End Class
