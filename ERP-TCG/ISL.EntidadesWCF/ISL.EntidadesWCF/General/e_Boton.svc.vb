

''' <summary>
''' Clase para almacenar los valores de los Botones Principales del SGI
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Boton
    Implements Ie_Boton

#Region "Definicion de Variables"
    Private _Consultar As Boolean
    Private _Nuevo As Boolean
    Private _Editar As Boolean
    Private _Guardar As Boolean
    Private _Cancelar As Boolean
    Private _Eliminar As Boolean
    Private _Imprimir As Boolean
    Private _Exportar As Boolean
    Private _Salir As Boolean

    '----Campos para la orden de ingreso-----
    Private _Listar As Boolean
    Private _Generar As Boolean
    Private _Ejecutar As Boolean
    Private _GenerarDoc As Boolean
    '----------------------------------------

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Listar() As Boolean
        Get
            Return _Listar
        End Get
        Set(ByVal value As Boolean)
            _Listar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Generar() As Boolean
        Get
            Return _Generar
        End Get
        Set(ByVal value As Boolean)
            _Generar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ejecutar() As Boolean
        Get
            Return _Ejecutar
        End Get
        Set(ByVal value As Boolean)
            _Ejecutar = value
        End Set
    End Property

    <DataMember()> _
    Public Property GenerarDoc() As Boolean
        Get
            Return _GenerarDoc
        End Get
        Set(ByVal value As Boolean)
            _GenerarDoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nuevo() As Boolean
        Get
            Return _Nuevo
        End Get
        Set(ByVal value As Boolean)
            _Nuevo = value
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
    Public Property Guardar() As Boolean
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
    Public Property Exportar() As Boolean
        Get
            Return _Exportar
        End Get
        Set(ByVal value As Boolean)
            _Exportar = value
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

    <DataMember()> _
    Public Property Consultar() As Boolean
        Get
            Return _Consultar
        End Get
        Set(ByVal value As Boolean)
            _Consultar = value
        End Set
    End Property
#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Boton
    ''' </summary>
    ''' <param name="boton"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal boton As e_Boton) As e_Boton Implements Ie_Boton.Obtener
        Return boton
    End Function

#End Region

End Class


