
<DataContract()> _
Public Class e_AccidenteCarga
    Implements Ie_AccidenteCarga

#Region "Propiedad"

    Private _id As String
    Private _seleccion As Boolean
    Private _idaccidente As String
    Private _idmaterial As String
    Private _material As String
    Private _detalle As String
    Private _observacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAccidente() As String
        Get
            Return _idaccidente
        End Get
        Set(ByVal value As String)
            _idaccidente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _material
        End Get
        Set(ByVal value As String)
            _material = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Detalle() As String
        Get
            Return _detalle
        End Get
        Set(ByVal value As String)
            _detalle = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
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
              , ByVal ls_IdAccidente As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_Detalle As String _
              , ByVal ls_Observacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Material As String)
        _id = ls_Id
        _idaccidente = ls_IdAccidente
        _idmaterial = ls_IdMaterial
        _detalle = ls_Detalle
        _observacion = ls_Observacion
        _activo = lb_Activo
        _material = ls_Material
    End Sub

#End Region

    Public Function Obtener(ByVal accidentecarga As e_AccidenteCarga) As e_AccidenteCarga Implements Ie_AccidenteCarga.Obtener
        Return accidentecarga
    End Function

End Class



