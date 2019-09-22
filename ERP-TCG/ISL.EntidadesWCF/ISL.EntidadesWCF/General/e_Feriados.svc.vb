' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Feriados" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Feriados.svc o e_Feriados.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_Feriados
    Implements Ie_Feriados

#Region "Propiedad"

    Private _id As String
    Private _tipoferiado As New e_TipoFeriado
    Private _fecha As Date
    Private _descripcion As String
    Private _indlaborable As Boolean
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdTipoFeriado() As String
        Get
            Return _tipoferiado.Id
        End Get
        Set(ByVal value As String)
            _tipoferiado.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoFeriado() As String
        Get
            Return _tipoferiado.Nombre
        End Get
        Set(ByVal value As String)
            _tipoferiado.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndLaborable() As Boolean
        Get
            Return _indlaborable
        End Get
        Set(ByVal value As Boolean)
            _indlaborable = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        Fecha = Date.Parse("01/01/1901")
        FechaCreacion = Date.Parse("01/01/1901")
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTipoFeriado As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_Descripcion As String _
              , ByVal lb_IndLaborable As Boolean _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_TipoFeriado As String)
        _id = ls_Id
        _tipoferiado.Id = ls_IdTipoFeriado
        _fecha = ld_Fecha
        _descripcion = ls_Descripcion
        _indlaborable = lb_IndLaborable
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _tipoferiado.Nombre = ls_TipoFeriado
    End Sub

#End Region

    Public Function Obtener(ByVal feriados As e_Feriados) As e_Feriados Implements Ie_Feriados.Obtener
        Return feriados
    End Function

End Class
