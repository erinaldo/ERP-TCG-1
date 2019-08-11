' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ModalidadContrato" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ModalidadContrato.svc o e_ModalidadContrato.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_ModalidadContrato
    Implements Ie_ModalidadContrato

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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

    Public Sub New(ByVal ls_Id As String _
                   , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal modalidadcontrato As e_ModalidadContrato) As e_ModalidadContrato Implements Ie_ModalidadContrato.Obtener
        Return modalidadcontrato
    End Function

End Class
