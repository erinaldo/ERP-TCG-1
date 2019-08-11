''' <summary>
''' Clase de tipo lista genérica para administrar los Tipos de Operación realizadas por los usuarios 
''' en los detalles de los objetos de tipo maestros detalle
''' </summary>
''' <remarks></remarks>
Public Class e_ListaTiposOperacionDetalle
    Inherits e_TiposOperaciones
    Implements Ie_ListaTiposOperacionDetalle

    ''' <summary>
    ''' Inicializar los valores por defecto de la lista de tipos de operación para detalles
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Inicializar() Implements Ie_ListaTiposOperacionDetalle.Inicializar
        MyBase.List.Clear()
        Dim agregar As New e_TipoOperacion("Agregar", "I")
        MyBase.List.Add(agregar)
        Dim modificar As New e_TipoOperacion("Modificar", "A")
        MyBase.List.Add(modificar)
        Dim quitar As New e_TipoOperacion("Quitar", "E")
        MyBase.List.Add(quitar)
    End Sub

End Class
