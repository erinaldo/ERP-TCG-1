

<DataContract()> _
Public Class e_DetalleMaterialAsignacion
    Implements Ie_DetalleMaterialAsignacion

#Region "Propiedad"

    Private _id As String
    Private _idRequerimientomaterial As String
    Private _idRequerimiento As String
    Private _idmarca As New e_Marca
    Private _idmodelo As New e_Modelo
    Private _serie As String
    Private _idestado As New e_Estado
    Private _especificaciones As String
    Private _activo As Boolean
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
    Public Property IdRequerimientoMaterial() As String
        Get
            Return _idRequerimientomaterial
        End Get
        Set(ByVal value As String)
            _idRequerimientomaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property
    <DataMember()> _
    Public Property IdRequerimiento() As String
        Get
            Return _idRequerimiento
        End Get
        Set(ByVal value As String)
            _idRequerimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMarca() As String
        Get
            Return _idmarca.Id
        End Get
        Set(ByVal value As String)
            _idmarca.Id = value
            RaiseEvent DatoCambiado()
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
    Public Property IdModelo() As String
        Get
            Return _idmodelo.Id
        End Get
        Set(ByVal value As String)
            _idmodelo.Id = value
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

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdRequerimientoMaterial As String _
              , ByVal ls_IdMarca As String _
              , ByVal ls_IdModelo As String _
              , ByVal ls_Serie As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Especificaciones As String _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idRequerimientomaterial = ls_IdRequerimientoMaterial
        _idmarca.Id = ls_IdMarca
        _idmodelo.Id = ls_IdModelo
        _serie = ls_Serie
        _idestado.Id = ls_IdEstado
        _especificaciones = ls_Especificaciones
        _fechavencimiento = ld_FechaVencimiento
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal detalleMaterialAsignacion As e_DetalleMaterialAsignacion) As e_DetalleMaterialAsignacion Implements Ie_DetalleMaterialAsignacion.Obtener
        Return detalleMaterialAsignacion
    End Function

End Class


