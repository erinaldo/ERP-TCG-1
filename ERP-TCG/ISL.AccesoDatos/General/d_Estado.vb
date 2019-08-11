Imports ISL.EntidadesWCF
''' <summary>
''' Clase que gestiona los estados de los documentos en la empresa
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Estado,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Estado

    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Estado, el cual es consultado por el procedimiento almacenado
    ''' [STD].[Isp_Estado_Listar],enviando sus atributos del estado.Una vez obtenido los registros son cargados y 
    ''' devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeEstado">Recibe una Variable oeEstado de tipo e_Estado </param>
    ''' <returns>Devuelve una lista generica(ldEstado) de objetos de tipo e_Estado</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeEstado As e_Estado) As List(Of e_Estado)
        Try
            Dim ldEstado As New List(Of e_Estado)
            Dim ds As DataSet
            With oeEstado
                ds = SqlHelper.ExecuteDataset("[STD].[Isp_Estado_Listar]", _
            .Nombre)
            End With
            oeEstado = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEstado = Cargar(o_Fila)
                    ldEstado.Add(oeEstado)
                Next
            Else
                ldEstado = New List(Of e_Estado)
            End If
            Return ldEstado
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Estado y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeEstado) de tipo e_Estado </returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Estado
        Try
            Dim oeEstado = New e_Estado( _
            o_fila("Id"), o_fila("IdProcesoNegocio"), o_fila("Nombre"), o_fila("Activo"))
            Return oeEstado
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    'Public Function ComboGrilla(ByVal oeEstado As e_Estado)
    '    Dim ds = New DataTable
    '    ds.Columns.Add("Id")
    '    ds.Columns.Add("Nombre")
    '    For Each item As e_Estado In Listar(oeEstado)
    '        Dim newRow As DataRow = ds.NewRow()
    '        newRow("Id") = item.Id
    '        newRow("Nombre") = item.Nombre
    '        ds.Rows.Add(newRow)
    '    Next
    '    Return ds
    'End Function

    Public Function ComboGrilla(ByVal Lista As List(Of e_Estado))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Estado In Lista
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function
End Class
