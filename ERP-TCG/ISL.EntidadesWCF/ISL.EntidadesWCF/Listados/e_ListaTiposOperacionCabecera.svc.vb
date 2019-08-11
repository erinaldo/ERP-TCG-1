''' <summary>
''' Clase de tipo lista genérica para administrar los Tipos de Operación realizadas por los usuarios 
''' en las cabeceras de los objetos de tipo maestros detalle
''' </summary>
''' <remarks></remarks>
Public Class e_ListaTiposOperacionCabecera
    Inherits e_TiposOperaciones
    Implements Ie_ListaTiposOperacionCabecera

    ''' <summary>
    ''' Inicializar los valores por defecto de la lista de tipos de operación para la cabecera
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Inicializar() Implements Ie_ListaTiposOperacionCabecera.Inicializar
        MyBase.List.Clear()
        Dim insertar As New e_TipoOperacion("Insertar", "I")
        MyBase.List.Add(insertar)
        Dim actualizar As New e_TipoOperacion("Actualizar", "A")
        MyBase.List.Add(actualizar)
        Dim eliminar As New e_TipoOperacion("Eliminar", "E")
        MyBase.List.Add(eliminar)
    End Sub

End Class
