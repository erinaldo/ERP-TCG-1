
<DataContract()> _
Public Class e_AccidentePersona
    Implements Ie_AccidentePersona

#Region "Declaración de variables"

    Private _id As String
    Private _seleccion As Boolean
    Private _idAccidente As String
    Private _trabajador As String
    Private _nombrecompleto As String
    Private _detalle As String
    Private _observacion As String
    Private _activo As Boolean
    Private _idarea As String
    Private _area As String

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    Public Sub New()

    End Sub

    ''' <summary>
    ''' Crea una nueva entidad de para vincular un trabajador a un accidente
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="idAccidente"></param>
    ''' <param name="idTrabajador"></param>
    ''' <param name="detalle"></param>
    ''' <param name="observacion"></param>
    ''' <param name="activo"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal id As String, ByVal idAccidente As String, ByVal idTrabajador As String, _
                   ByVal detalle As String, ByVal observacion As String, ByVal activo As Boolean, _
                   ByVal ls_NombreCompleto As String, ByVal ls_Area As String)
        _id = id
        _idAccidente = idAccidente
        _trabajador = idTrabajador
        _detalle = detalle
        _observacion = observacion
        _activo = activo
        _nombrecompleto = ls_NombreCompleto
        _area = ls_Area
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
            RaiseEvent DatoCambiado()
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
    Public Property IdArea() As String
        Get
            Return _idarea
        End Get
        Set(ByVal value As String)
            RaiseEvent DatoCambiado()
            _idarea = value
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            RaiseEvent DatoCambiado()
            _area = value
        End Set
    End Property

    Public Property NombreCompleto() As String
        Get
            Return _nombrecompleto
        End Get
        Set(ByVal value As String)
            _nombrecompleto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAccidente() As String
        Get
            Return _idAccidente
        End Get
        Set(ByVal value As String)
            _idAccidente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
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

#Region "Métodos"

    Public Function Obtener(ByVal accidentePersona As e_AccidentePersona) As e_AccidentePersona Implements Ie_AccidentePersona.Obtener
        Return accidentePersona
    End Function

#End Region

End Class


