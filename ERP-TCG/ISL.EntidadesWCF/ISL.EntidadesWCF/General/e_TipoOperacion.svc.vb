''' <summary>
''' Entidad para almacenar la información de Tipos de Operacion que los usuarios están realizando
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_TipoOperacion
    Implements Ie_TipoOperacion

#Region "Declaración de variables"

    Private _nombre As String
    Private _abreviatura As String
    Private _actual As Boolean

    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    Public Sub New()
        _nombre = ""
        _abreviatura = ""
        _actual = False
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nombre">Nombre del tipo de operación</param>
    ''' <param name="abreviatura">Abreviatura común del tipo de operación</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal nombre As String, ByVal abreviatura As String)
        _nombre = nombre
        _abreviatura = abreviatura
        _actual = False
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Propiedad para almacenar el nombre del tipo de operación
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
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
    ''' Propiedad para almacenar la abreviatura común que se utiliza para identificar el tipo de operación
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
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
    ''' Propiedad para establecer la operación actual que está realizando el usuario
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Actual() As Boolean
        Get
            Return _actual
        End Get
        Set(ByVal value As Boolean)
            _actual = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Permite obtener un objeto de tipo e_TipoOperacion
    ''' </summary>
    ''' <param name="tipoOperacion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal tipoOperacion As e_TipoOperacion) As e_TipoOperacion Implements Ie_TipoOperacion.Obtener
        Return tipoOperacion
    End Function

#End Region

End Class


