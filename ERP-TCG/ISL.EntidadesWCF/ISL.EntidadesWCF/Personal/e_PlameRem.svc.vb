' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_PlameRem" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_PlameRem.svc o e_PlameRem.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_PlameRem
    Implements Ie_PlameRem

    Public Sub DoWork() Implements Ie_PlameRem.DoWork
    End Sub


#Region "Propiedad"
    Private _idperiodo As String
    Private _tipodocumento As String
    Private _dni As String
    Private _codigosunat As String
    Private _devengado As Double
    Private _pagado As Double
    Private _idtrabajador As String

    Public TipoOperacion As String
    Public Modificado As Boolean

    Event DatoCambiado()

    <DataMember()> _
    Public Property IdPeriodo() As String
        Get
            Return _idperiodo
        End Get
        Set(ByVal value As String)
            _idperiodo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocumento() As String
        Get
            Return _tipodocumento
        End Get
        Set(ByVal value As String)
            _tipodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoSunat() As String
        Get
            Return _codigosunat
        End Get
        Set(ByVal value As String)
            _codigosunat = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Devengado() As Double
        Get
            Return _devengado
        End Get
        Set(ByVal value As Double)
            _devengado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Pagado() As Double
        Get
            Return _pagado
        End Get
        Set(ByVal value As Double)
            _pagado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        TipoDocumento = ""
        Dni = ""
        CodigoSunat = ""
        Devengado = 0.0
        Pagado = 0.0
    End Sub

#End Region

End Class
