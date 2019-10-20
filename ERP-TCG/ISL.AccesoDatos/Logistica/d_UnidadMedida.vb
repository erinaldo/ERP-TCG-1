'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF

Public Class d_UnidadMedida
    Private sqlhelper As New SqlHelper

    Private oeUnidadMedida As New e_UnidadMedida

    Public Function Cargar(ByVal fila As DataRow) As e_UnidadMedida
        Try
            oeUnidadMedida = New e_UnidadMedida( _
                                                fila("Id"), _
                                                fila("Codigo"), _
                                                fila("Nombre"), _
                                                fila("Abreviatura"), _
                                                fila("Activo"), _
                                                fila("IdTipoUnidadMedida"), _
                                                fila("Factor"), _
                                                fila("Base"), _
                                                fila("NombreTipoUnidadMedida"))
            Return oeUnidadMedida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeUnidadMedida As e_UnidadMedida) As e_UnidadMedida
        Try
            Dim ds As DataSet
            With oeUnidadMedida
                'ds = sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_Listar", "", .Id, .Codigo, .Nombre, .Abreviatura)
                ds = sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeUnidadMedida = Cargar(ds.Tables(0).Rows(0))
            Else
                oeUnidadMedida = New e_UnidadMedida
            End If
            Return oeUnidadMedida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeUnidadMedida As e_UnidadMedida) As List(Of e_UnidadMedida)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_UnidadMedida)
            With oeUnidadMedida
                ds = sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_Listar",
                                              .TipoOperacion,
                                              .Id,
                                              .Codigo,
                                              .Nombre,
                                              .Abreviatura,
                                              .Activo,
                                              .IdTipoUnidadMedida,
                                              .Factor,
                                              .Base,
                                              .Asignado)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeUnidadMedida = Cargar(fila)
                    lista.Add(oeUnidadMedida)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarD(ByVal oeUnidadMedida As e_UnidadMedida) As DataSet
        Try
            With oeUnidadMedida
                'Return sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_ListarD", "", .Id, .Codigo, .Nombre, .Abreviatura, _
                '                               True, .Activo, .Asignado)
                Return sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_Listar", _
                                                "L", _
                                                .Id, _
                                                .Codigo, _
                                                .Nombre, _
                                                .Abreviatura, _
                                                .Activo, _
                                                .IdTipoUnidadMedida, _
                                                .Factor, _
                                                .Base, _
                                                .Asignado)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeUnidadMedida As e_UnidadMedida) As Boolean
        Try
            With oeUnidadMedida
                sqlhelper.ExecuteNonQuery("ALM.Isp_UnidadMedida_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                          .Id,
                                          .Codigo,
                                          .Nombre,
                                          .Abreviatura,
                                          .Activo,
                                          .IdTipoUnidadMedida,
                                          .Factor,
                                          .Base,
                                          .Asignado)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeUnidadMedida As e_UnidadMedida) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_UnidadMedida_IAE", _
                                      "E", _
                                      "", _
                                      oeUnidadMedida.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal oeUnidadMedida As e_UnidadMedida)
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_UnidadMedida In ListarUMR(oeUnidadMedida)
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                newRow("Nombre") = item.Nombre
                ds.Rows.Add(newRow)
            Next
            If ds.Rows.Count = 0 Then Throw New Exception("Información no registrada")
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarUMR(ByVal oeUnidadMedida As e_UnidadMedida) As List(Of e_UnidadMedida)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_UnidadMedida)
            With oeUnidadMedida
                ds = sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo, _
                                              .IdTipoUnidadMedida)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeUnidadMedida = Cargar(fila)
                    lista.Add(oeUnidadMedida)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
