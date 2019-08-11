' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ProvisionPoliza" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ProvisionPoliza.svc o e_ProvisionPoliza.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_ProvisionPoliza
    Implements Ie_ProvisionPoliza

#Region "Declaracion de Variables"

    Private _Id As String
    Private _IdDocumentoVeh_Doc As String
    Private _Prima As Double
    Private _Igv As Double
    Private _Total As Double
    Private _IdAsiento As String
    Private _Activo As Boolean
    Private _UsuarioCreacion As String
    Private _FechaCreacion As Date
    Private _UsuarioModificacion As String
    Private _FechaModificacion As Date

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDocumentoVeh_Doc() As String
        Get
            Return _IdDocumentoVeh_Doc
        End Get
        Set(value As String)
            _IdDocumentoVeh_Doc = value
        End Set
    End Property

    <DataMember()> _
    Public Property Prima() As Double
        Get
            Return _Prima
        End Get
        Set(value As Double)
            _Prima = value
        End Set
    End Property

    <DataMember()> _
    Public Property Igv() As Double
        Get
            Return _Igv
        End Get
        Set(value As Double)
            _Igv = value
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _Total
        End Get
        Set(value As Double)
            _Total = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAsiento() As String
        Get
            Return _IdAsiento
        End Get
        Set(value As String)
            _IdAsiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModificacion() As String
        Get
            Return _UsuarioModificacion
        End Get
        Set(ByVal value As String)
            _UsuarioModificacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModificacion() As Date
        Get
            Return _FechaModificacion
        End Get
        Set(ByVal value As Date)
            _FechaModificacion = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _Id = String.Empty
        _IdDocumentoVeh_Doc = String.Empty
        _Prima = 0
        _Igv = 0
        _Total = 0
        _IdAsiento = String.Empty
        _Activo = True
        _UsuarioCreacion = String.Empty
        _FechaCreacion = #1/1/1901#
        _UsuarioModificacion = String.Empty
        _FechaModificacion = #1/1/1901#
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ProvisionPoliza As e_ProvisionPoliza) As e_ProvisionPoliza Implements Ie_ProvisionPoliza.Obtener
        Return ProvisionPoliza
    End Function

#End Region

    Public Sub DoWork() Implements Ie_ProvisionPoliza.DoWork
    End Sub

End Class
