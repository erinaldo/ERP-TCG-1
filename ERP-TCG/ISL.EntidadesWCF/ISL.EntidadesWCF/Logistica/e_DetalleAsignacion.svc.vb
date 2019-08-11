<DataContract()> _
Public Class e_DetalleAsignacion
    Implements Ie_DetalleAsignacion

#Region "Propiedad"

    Private _id As String
    Private _idmodelo As String
    Private _modelo As String
    Private _idmarca As String
    Private _marca As String
    Private _idestado As New e_Estado
    Private _serie As String
    Private _especificaciones As String
    Private _idregistroinventario As New e_RegistroInventario
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _fechavencimiento As Date

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Public Event DatoCambiado()

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
    Public Property IdModelo() As String
        Get
            Return _idmodelo
        End Get
        Set(ByVal value As String)
            _idmodelo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreModelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMarca() As String
        Get
            Return _idmarca
        End Get
        Set(ByVal value As String)
            _idmarca = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreMarca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado.Id
        End Get
        Set(ByVal value As String)
            _idestado.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreEstado() As String
        Get
            Return _idestado.Nombre
        End Get
        Set(ByVal value As String)
            _idestado.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Especificaciones() As String
        Get
            Return _especificaciones
        End Get
        Set(ByVal value As String)
            _especificaciones = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdRegistroInventario() As String
        Get
            Return _idregistroinventario.Id
        End Get
        Set(ByVal value As String)
            _idregistroinventario.Id = value
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
              , ByVal ls_IdRegistroInventario As String _
              , ByVal ls_IdMarca As String _
              , ByVal ls_NombreMarca As String _
              , ByVal ls_IdModelo As String _
              , ByVal ls_NombreModelo As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_NombreEstado As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Especificaciones As String _
              , ByVal ld_FechaVencimiento As Date)
        _id = ls_Id
        _idregistroinventario.Id = ls_IdRegistroInventario
        _idmarca = ls_IdMarca
        _modelo = ls_NombreMarca
        _idmodelo = ls_IdModelo
        _modelo = ls_NombreModelo
        _idestado.Id = ls_IdEstado
        _idestado.Nombre = ls_NombreEstado
        _serie = ls_Serie
        _especificaciones = ls_Especificaciones
        _fechavencimiento = ld_FechaVencimiento
    End Sub

#End Region

    Public Function Obtener(ByVal detalleAsignacion As e_DetalleAsignacion) As e_DetalleAsignacion Implements Ie_DetalleAsignacion.Obtener
        Return detalleAsignacion
    End Function

End Class
