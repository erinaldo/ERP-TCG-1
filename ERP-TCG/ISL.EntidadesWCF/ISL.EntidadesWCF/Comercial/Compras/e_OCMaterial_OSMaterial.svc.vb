' NOTA: si cambia aquí el nombre de clase "e_OCMaterial_OSMaterial", también debe actualizar la referencia a "e_OCMaterial_OSMaterial" tanto en Web.config como en el archivo .svc asociado.
Public Class e_OCMaterial_OSMaterial
    Implements Ie_OCMaterial_OSMaterial

#Region "Propiedad"

    Private _id As String
    Private _idorden As String
    Private _idordenasociada As String
    Private _activo As Boolean
    Private _fechacreacion As Date

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
    Public Property IdOrden() As String
        Get
            Return _idorden
        End Get
        Set(ByVal value As String)
            _idorden = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrdenAsociada() As String
        Get
            Return _idordenasociada
        End Get
        Set(ByVal value As String)
            _idordenasociada = value
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

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
              , ByVal ls_IdOrden As String _
              , ByVal ls_IdOrdenAsociada As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
           )
        _id = ls_Id
        _idorden = ls_IdOrden
        _idordenasociada = ls_IdOrdenAsociada
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal OCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As e_OCMaterial_OSMaterial Implements Ie_OCMaterial_OSMaterial.Obtener
        Return OCMaterial_OSMaterial
    End Function

End Class
