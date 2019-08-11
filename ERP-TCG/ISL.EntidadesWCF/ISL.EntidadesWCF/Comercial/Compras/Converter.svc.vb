Imports System.Reflection


<DataContract()> _
Public Class Converter
    Implements IConverter

    Public Function Convert(ByVal items As System.Collections.Generic.List(Of Object)) As System.Data.DataTable Implements IConverter.Convert
        ' Instancia del objeto a devolver
        Dim returnValue As New DataTable()
        ' Información del tipo de datos de los elementos del List
        Dim itemsType As Type = GetType(Object)
        ' Recorremos las propiedades para crear las columnas del datatable
        For Each prop As PropertyInfo In itemsType.GetProperties()
            ' Crearmos y agregamos una columna por cada propiedad de la entidad
            Dim column As New DataColumn(prop.Name)
            column.DataType = prop.PropertyType
            returnValue.Columns.Add(column)
        Next

        Dim j As Integer
        ' ahora recorremos la colección para guardar los datos
        ' en el DataTable
        For Each item As Object In items
            j = 0
            Dim newRow(0 To returnValue.Columns.Count - 1) As Object
            ' Volvemos a recorrer las propiedades de cada item para
            ' obtener su valor guardarlo en la fila de la tabla
            For Each prop As PropertyInfo In itemsType.GetProperties()
                newRow(j) = prop.GetValue(item, Nothing)
                j += 1
            Next
            returnValue.Rows.Add(newRow)
        Next
        ' Devolver el objeto creado
        Return returnValue
    End Function
End Class

