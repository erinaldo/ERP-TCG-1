

''' <summary>
''' Clase implementada para almacenar la información de configuración de reportes en el sistema
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_ReporteConfiguracion
    Implements Ie_ReporteConfiguracion

#Region "Declaración de variables"

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String

    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal idProceso As String, ByVal codigo As String, ByVal nombre As String, ByVal abreviatura As String, ByVal activo As Boolean, ByVal tipoReporte As Int16, ByVal ruta As String)
        _id = id
        _idProceso = idProceso
        _codigo = codigo
        _nombre = nombre
        _abreviatura = abreviatura
        _activo = activo
        _tipoReporte = tipoReporte
        _ruta = ruta
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Especifica el Id del reporte
    ''' </summary>
    ''' <remarks></remarks>
    Private _id As String
    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    ''' <summary>
    ''' Especifica el proceso al que está vinculado el reporte
    ''' </summary>
    ''' <remarks></remarks>
    Private _idProceso As String
    <DataMember()> _
    Public Property IdProceso() As String
        Get
            Return _idProceso
        End Get
        Set(ByVal value As String)
            _idProceso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Private _proceso As String
    <DataMember()> _
    Public Property Proceso() As String
        Get
            Return _proceso
        End Get
        Set(ByVal value As String)
            _proceso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Especifica el código del reporte
    ''' </summary>
    ''' <remarks></remarks>
    Private _codigo As String
    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Especifica el nombre completo del reporte
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
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

    ''' <summary>
    ''' Abreviatura del nombre o nombre con que comunmente se conoce a este reporte
    ''' </summary>
    ''' <remarks></remarks>
    Private _abreviatura As String
    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Especifica si el reporte está activo o disponible para ser utilizado o no
    ''' </summary>
    ''' <remarks></remarks>
    Private _activo As String
    <DataMember()> _
    Public Property Activo() As String
        Get
            Return _activo
        End Get
        Set(ByVal value As String)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Define el tipo de reporte ( 1 - Local / 2 - de Servidor)
    ''' </summary>
    ''' <remarks></remarks>
    Private _tipoReporte As Int16
    <DataMember()> _
    Public Property TipoReporte() As String
        Get
            Return _tipoReporte
        End Get
        Set(ByVal value As String)
            _tipoReporte = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Especifica la ruta o path de ubicación del reporte
    ''' </summary>
    ''' <remarks></remarks>
    Private _ruta As String
    <DataMember()> _
    Public Property Ruta() As String
        Get
            Return _ruta
        End Get
        Set(ByVal value As String)
            _ruta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Especifica la fecha en que se registró el reporte en el sistema
    ''' </summary>
    ''' <remarks></remarks>
    Private _fechaCreacion As Date
    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechaCreacion
        End Get
        Set(ByVal value As Date)
            _fechaCreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Especifica el usuario que relacionó al reporte al sistema
    ''' </summary>
    ''' <remarks></remarks>
    Private _usuarioCreacion As String
    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuarioCreacion
        End Get
        Set(ByVal value As String)
            _usuarioCreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ReporteConfiguracion
    ''' </summary>
    ''' <param name="reporteConfiguracion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal reporteConfiguracion As e_ReporteConfiguracion) As e_ReporteConfiguracion Implements Ie_ReporteConfiguracion.Obtener
        Return reporteConfiguracion
    End Function

#End Region

End Class


