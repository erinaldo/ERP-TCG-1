' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_DistanciaZona" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_DistanciaZona.svc o e_DistanciaZona.svc.vb en el Explorador de soluciones e inicie la depuración.

<DataContract()> _
Public Class e_DistanciaZona
    Implements Ie_DistanciaZona

    'Public Sub DoWork() Implements Ie_DistanciaZona.DoWork
    'End Sub

#Region "Propiedades"
    
    <DataMember()>
    Public TipoOperacion As String
    Private _Id As String
    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property
    Private _IdRuta As String
    <DataMember()> _
Public Property IdRuta() As String
        Get
            Return _IdRuta
        End Get
        Set(ByVal value As String)
            _IdRuta = value
        End Set
    End Property


    Private _IdActividadNegocio As String
    <DataMember()> _
Public Property IdActividadNegocio() As String
        Get
            Return _IdActividadNegocio
        End Get
        Set(ByVal value As String)
            _IdActividadNegocio = value
        End Set
    End Property

    Private _IdCliente As String
    <DataMember()> _
Public Property IdCliente() As String
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As String)
            _IdCliente = value
        End Set
    End Property

    Private _IdZona As String
    <DataMember()> _
Public Property IdZona() As String
        Get
            Return _IdZona
        End Get
        Set(ByVal value As String)
            _IdZona = value
        End Set
    End Property

    Private _Distancia As Double
    <DataMember()> _
    Public Property Distancia() As Double
        Get
            Return _Distancia
        End Get
        Set(ByVal value As Double)
            _Distancia = value
        End Set
    End Property

    Private _Observacion As String
    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property

    Private _FechaInicio As Date
    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            _FechaInicio = value
        End Set
    End Property

    Private _FechaFin As Date
    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As Date)
            _FechaFin = value
        End Set
    End Property

    Private _Actual As Boolean
    <DataMember()> _
    Public Property Actual() As Boolean
        Get
            Return _Actual
        End Get
        Set(ByVal value As Boolean)
            _Actual = value
        End Set
    End Property

   

#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        Id = ""
        IdRuta = ""
        Actual = True
        FechaInicio = Date.Now
        FechaFin = Date.Now
    End Sub

    Public Sub New(ls_Id As String, ls_IdRuta As String, ls_IdActividadNegocio As String, ls_IdCliente As String, ls_IdZona As String, _
                   ld_Distancia As Double, ls_Observacion As String, ld_FechaInicio As Date, ld_FechaFin As Date, lb_Actual As Boolean)
        Id = ls_Id
        IdRuta = ls_IdRuta
        IdActividadNegocio = ls_IdActividadNegocio
        IdCliente = ls_IdCliente
        IdZona = ls_IdZona
        Distancia = ld_Distancia
        Observacion = ls_Observacion
        FechaInicio = ld_FechaInicio
        FechaFin = ld_FechaFin
        Actual = lb_Actual
    End Sub
#End Region

End Class
