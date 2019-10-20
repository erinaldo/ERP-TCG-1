'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF


Public Class d_Estado

    Private sqlhelper As New SqlHelper


    Public Function Listar(ByVal oeEstado As e_Estado) As List(Of e_Estado)
        Try
            Dim ldEstado As New List(Of e_Estado)
            Dim ds As DataSet
            With oeEstado
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Estado_Listar]",
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
