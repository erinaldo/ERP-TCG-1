''' <summary>
''' Clase para definir la entidad Impuesto
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Impuesto
    Implements Ie_Impuesto
    Implements IPropiedadesBasicas

#Region "Constructores"

    Public Sub New()
        _activo = True
        _id = ""
        _codigo = ""
        _nombre = ""
        _abreviatura = ""
        _porcentaje = 0
        _fechaFin = #1/1/1901#
        _fechaInicio = #1/1/1901#
    End Sub

    Public Sub New(ByVal codigo As String, ByVal nombre As String, ByVal abreviatura As String, ByVal porcentaje As Double)
        _codigo = codigo
        _nombre = nombre
        _abreviatura = abreviatura
        _porcentaje = porcentaje
    End Sub

    Public Sub New(ByVal id As String, ByVal codigo As String, ByVal nombre As String, ByVal abreviatura As String, ByVal porcentaje As Double, ByVal fechaInicio As Date, ByVal fechaFin As Date, ByVal activo As Boolean)
        _id = id
        _codigo = codigo
        _nombre = nombre
        _abreviatura = abreviatura
        _porcentaje = porcentaje
        _fechaInicio = fechaInicio
        _fechaFin = fechaFin
        _activo = activo
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public TipoOperacion As String

    Private _id As String
    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    ''' <summary>
    ''' Código del impuesto
    ''' </summary>
    ''' <remarks></remarks>
    Private _codigo As String
    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre completo del Impuesto
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    ''' <summary>
    ''' Abreviatura del impuesto
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
        End Set
    End Property

    ''' <summary>
    ''' Monto del porcentaje del impuesto
    ''' </summary>
    ''' <remarks></remarks>
    Private _porcentaje As Double
    <DataMember()> _
    Public Property Porcentaje() As Double
        Get
            Return _porcentaje
        End Get
        Set(ByVal value As Double)
            _porcentaje = value
        End Set
    End Property

    ''' <summary>
    ''' Fecha de inicio de vigencia del impuesto
    ''' </summary>
    ''' <remarks></remarks>
    Private _fechaInicio As Date
    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechaInicio
        End Get
        Set(ByVal value As Date)
            _fechaInicio = value
        End Set
    End Property

    ''' <summary>
    ''' Fecha de caducidad o límite de vigencia del impuesto
    ''' </summary>
    ''' <remarks></remarks>
    Private _fechaFin As Date
    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _fechaFin
        End Get
        Set(ByVal value As Date)
            _fechaFin = value
        End Set
    End Property

    ''' <summary>
    ''' Determina si el impuesto se encuentra vigente o no 
    ''' </summary>
    ''' <remarks></remarks>
    Private _activo As Boolean
    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal impuesto As e_Impuesto) As e_Impuesto Implements Ie_Impuesto.Obtener
        Return impuesto
    End Function

#End Region

End Class


