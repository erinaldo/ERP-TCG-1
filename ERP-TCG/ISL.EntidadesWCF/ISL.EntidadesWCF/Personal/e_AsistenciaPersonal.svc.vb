' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_AsistenciaPersonal" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_AsistenciaPersonal.svc o e_AsistenciaPersonal.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_AsistenciaPersonal
    Implements Ie_AsistenciaPersonal

#Region "Propiedad"

    Private _id As String
    Private _idtrabajador As String
    Private _fecha As Date
    Private _retraso As Integer
    Private _indingresosalida As Boolean

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
    Public Property Retraso() As Integer
        Get
            Return _retraso
        End Get
        Set(ByVal value As Integer)
            _retraso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndIngresoSalida() As Boolean
        Get
            Return _indingresosalida
        End Get
        Set(ByVal value As Boolean)
            _indingresosalida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region
#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_Retraso As Integer _
              , ByVal lb_IndIngresoSalida As Boolean _
           )
        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _fecha = ld_Fecha
        _retraso = ln_Retraso
        _indingresosalida = lb_IndIngresoSalida
    End Sub

#End Region

    Public Function Obtener(ByVal asistencia As e_AsistenciaPersonal) As e_AsistenciaPersonal Implements Ie_AsistenciaPersonal.Obtener
        Return asistencia
    End Function

End Class
