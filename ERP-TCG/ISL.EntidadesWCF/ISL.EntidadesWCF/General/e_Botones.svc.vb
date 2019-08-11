


''' <summary>
''' Clase para almacenar la información de los Botones secundario del sistema
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Botones
    Implements Ie_Botones

#Region "Declaracion de Variables"
    Private _Agregar As Boolean
    Private _Editar As Boolean
    Private _Guardar As Boolean
    Private _Cancelar As Boolean
    Private _Eliminar As Boolean
    Private _Imprimir As Boolean
    Private _Salir As Boolean
#End Region

#Region "Constructor"

    Sub New()

    End Sub

    Sub New(ByVal Agregar As Boolean, ByVal Editar As Boolean, ByVal Guardar As Boolean, ByVal Cancelar As Boolean _
            , ByVal Eliminar As Boolean, ByVal Imprimir As Boolean, ByVal Salir As Boolean)
        _Agregar = Agregar
        _Editar = Editar
        _Guardar = Guadar
        _Cancelar = Cancelar
        _Eliminar = Eliminar
        _Imprimir = Imprimir
        _Salir = Salir
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Agregar() As Boolean
        Get
            Return _Agregar
        End Get
        Set(ByVal value As Boolean)
            _Agregar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Editar() As Boolean
        Get
            Return _Editar
        End Get
        Set(ByVal value As Boolean)
            _Editar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Guadar() As Boolean
        Get
            Return _Guardar
        End Get
        Set(ByVal value As Boolean)
            _Guardar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cancelar() As Boolean
        Get
            Return _Cancelar
        End Get
        Set(ByVal value As Boolean)
            _Cancelar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Eliminar() As Boolean
        Get
            Return _Eliminar
        End Get
        Set(ByVal value As Boolean)
            _Eliminar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Imprimir() As Boolean
        Get
            Return _Imprimir
        End Get
        Set(ByVal value As Boolean)
            _Imprimir = value
        End Set
    End Property

    <DataMember()> _
    Public Property Salir() As Boolean
        Get
            Return _Salir
        End Get
        Set(ByVal value As Boolean)
            _Salir = value
        End Set
    End Property

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Botones
    ''' </summary>
    ''' <param name="botones"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal botones As e_Botones) As e_Botones Implements Ie_Botones.Obtener
        Return botones
    End Function

#End Region

End Class


