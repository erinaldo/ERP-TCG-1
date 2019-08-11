

<DataContract()> _
Public Class e_LicenciaConducir
    Implements Ie_LicenciaConducir

#Region "Declaracion de Variables"

    Private _id As String
    Private _idTrabajador As String
    Private _numero As String
    Private _tipoLicencia As String
    Private _categoria As String
    Private _activo As Boolean
    Private _fechaEmision As Date
    Private _fechaExpiracion As Date
    Private _observaciones As String

    <DataMember()> _
    Public TipoOperacion As String

    <DataMember()> _
    Public Modificado As Boolean

    Public Event DatoCambiado()

#End Region

#Region "Propiedad"


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
            Return _idTrabajador
        End Get
        Set(ByVal value As String)
            _idTrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property TipoLicencia() As String
        Get
            Return _tipoLicencia
        End Get
        Set(ByVal value As String)
            _tipoLicencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property Categoria() As String
        Get
            Return _categoria
        End Get
        Set(ByVal value As String)
            _categoria = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property FechaEmision() As Date
        Get
            Return _fechaEmision
        End Get
        Set(ByVal value As Date)
            _fechaEmision = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property FechaExpiracion() As Date
        Get
            Return _fechaExpiracion
        End Get
        Set(ByVal value As Date)
            _fechaExpiracion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property Observaciones() As String
        Get
            Return _observaciones
        End Get
        Set(ByVal value As String)
            _observaciones = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New( _
              ByVal id As String _
              , ByVal idTrabajador As String _
              , ByVal numero As String _
              , ByVal tipoLicencia As String _
              , ByVal categoria As Boolean _
              , ByVal fechaEmision As Date _
              , ByVal fechaExpiracion As Date _
              , ByVal observaciones As String _
)
        _id = id
        _idTrabajador = idTrabajador
        _numero = numero
        _tipoLicencia = tipoLicencia
        _categoria = categoria
        _fechaEmision = fechaEmision
        _fechaExpiracion = fechaExpiracion
        _observaciones = observaciones
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal licenciaConducir As e_LicenciaConducir) As e_LicenciaConducir Implements Ie_LicenciaConducir.Obtener
        Return licenciaConducir
    End Function

#End Region

End Class


