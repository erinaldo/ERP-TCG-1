<DataContract()> _
Public Class e_PreliminarInspeccion
    Implements Ie_PreliminarInspeccion

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _periodo As String
    Private _idestado As String
    Private _estado As String
    Private _fechacreacion As Date
    Private _fechaenvio As Date
    Private _fechatermino As Date
    Private _usuariocreacion As String
    Private _usuario As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String

    <DataMember()> _
    Public Anio As String
    <DataMember()> _
    Public Mes As String
    <DataMember()> _
    Public leDetallePre As New List(Of e_DetallePreliminar)
    <DataMember()> _
    Public oeRequerimiento As New e_Requerimiento
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Propiedades"

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
        End Set
    End Property

    <DataMember()> _
    Public Property Periodo() As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
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
   Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
Public Property FechaEnvio() As Date
        Get
            Return _fechaenvio
        End Get
        Set(ByVal value As Date)
            _fechaenvio = value
        End Set
    End Property

    <DataMember()> _
Public Property FechaTermino() As Date
        Get
            Return _fechatermino
        End Get
        Set(ByVal value As Date)
            _fechatermino = value
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
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
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

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _codigo = String.Empty
        _periodo = String.Empty
        _idestado = String.Empty
        _estado = String.Empty
        _fechacreacion = #1/1/1901#
        _fechaenvio = #1/1/1901#
        _fechatermino = #1/1/1901#
        _usuariocreacion = String.Empty
        _usuario = String.Empty
        _activo = True
        TipoOperacion = String.Empty
    End Sub

    Public Sub New(ByVal ls_Id As String, _
                    ByVal ls_Codigo As String, _
                    ByVal ls_Periodo As String, _
                    ByVal ls_IdEstado As String, _
                    ByVal ls_Estado As String, _
                    ByVal ld_FechaCreacion As Date, _
                    ByVal ld_FechaEnvio As Date, _
                    ByVal ld_FechaTermino As Date, _
                    ByVal ls_UsuarioCreacion As String, _
                    ByVal ls_Usuario As String, _
                    ByVal lb_Activo As Boolean)

        _id = ls_Id
        _codigo = ls_Codigo
        _periodo = ls_Periodo
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _fechacreacion = ld_FechaCreacion
        _fechaenvio = ld_FechaEnvio
        _fechatermino = ld_FechaTermino
        _usuariocreacion = ls_UsuarioCreacion
        _usuario = ls_Usuario
        _activo = lb_Activo

    End Sub

#End Region

    Public Function Obtener(ByVal preliminarinspeccion As e_PreliminarInspeccion) As e_PreliminarInspeccion Implements Ie_PreliminarInspeccion.Obtener
        Return preliminarinspeccion
    End Function

End Class
