<DataContract()> _
Public Class e_Accidente
    Implements Ie_Accidente

#Region "Declaración de variables"

    Private _id As String
    Private _fecha As Date
    Private _hora As Date
    Private _idTipoAccidente As String
    Private _lugar As String
    Private _detalle As String
    Private _Activo As Boolean
    Private _nombreLugar As String
    Private _tipoAccidente As String

    <DataMember()> _
    Public loTrabajadoresAccidentados As New List(Of e_AccidentePersona)
    <DataMember()> _
    Public loEquiposAccidentados As New List(Of e_AccidenteVehiculo)
    <DataMember()> _
    Public loMaterialesAccidentados As New List(Of e_AccidenteMaterial)
    <DataMember()> _
    Public loCargaAccidentados As New List(Of e_AccidenteCarga)
    <DataMember()> _
    Public loFotosAccidentados As New List(Of e_AccidenteFoto)

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    ''' <summary>
    ''' Crear un objeto de tipo Accidente
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        _id = String.Empty
        _Activo = True
    End Sub

    ''' <summary>
    ''' Crear un objeto de tipo Accidente a partir de sus datos básicos
    ''' </summary>
    ''' <param name="Id">Id del Accidente</param>
    ''' <remarks></remarks>
    Sub New(ByVal Id As String, ByVal fecha As Date, ByVal hora As Date, ByVal idTipoAccidente As String, ByVal lugar As String, ByVal detalle As String, ByVal tipoAccidente As String, ByVal nombreLugar As String, ByVal Activo As Integer)
        _id = Id
        _fecha = fecha
        _hora = hora
        _idTipoAccidente = idTipoAccidente
        _tipoAccidente = tipoAccidente
        _lugar = lugar
        _nombreLugar = nombreLugar
        _detalle = detalle
        _Activo = Activo
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Propiedad para almacenar el Id del Accidente
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
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
    Public Property Hora() As Date
        Get
            Return _hora
        End Get
        Set(ByVal value As Date)
            _hora = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoAccidente() As String
        Get
            Return _idTipoAccidente
        End Get
        Set(ByVal value As String)
            _idTipoAccidente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoAccidente() As String
        Get
            Return _tipoAccidente
        End Get
        Set(ByVal value As String)
            _tipoAccidente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Lugar() As String
        Get
            Return _lugar
        End Get
        Set(ByVal value As String)
            _lugar = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreLugar() As String
        Get
            Return _nombreLugar
        End Get
        Set(ByVal value As String)
            _nombreLugar = value
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

    ''' <summary>
    ''' Indicador que precisa si el Accidente se utiliza o no en el sistema
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Accidente
    ''' </summary>
    ''' <param name="accidente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal accidente As e_Accidente) As e_Accidente Implements Ie_Accidente.Obtener
        Return accidente
    End Function

#End Region

End Class


