Imports ERP.EntidadesWCF

Public Class d_EstacionServicio

    Private sqlhelper As New SqlHelper

    Public Function mt_Cargar(fila As DataRow) As e_EstacionServicio
        Try
            Dim oeEstacionServicio = New e_EstacionServicio With {.Id = fila("Id"),
                .IdEmpresaSis = fila("IdEmpresaSis"),
                .IdSucursal = fila("IdSucursal"),
                .Nombre = fila("Nombre"),
                .Estado = fila("Estado"),
                .Activo = IIf(fila("Activo"), 1, 0)}
            Return oeEstacionServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Obtener(ByVal oeEstacionServicio As e_EstacionServicio) As e_EstacionServicio
        Try
            Dim ds As DataSet
            With oeEstacionServicio
                ds = sqlhelper.ExecuteDataset("GRF.EstacionServicio_LST",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaSis,
                                              .IdSucursal,
                                              .Nombre,
                                              .Estado,
                                              .Usuario,
                                              .Activo)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeEstacionServicio = mt_Cargar(ds.Tables(0).Rows(0))
            Else
                oeEstacionServicio = New e_EstacionServicio
            End If
            Return oeEstacionServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(ByVal oeEstacionServicio As e_EstacionServicio) As List(Of e_EstacionServicio)
        Try
            Dim olEstacionServicio As New List(Of e_EstacionServicio)
            Dim ds As DataSet
            With oeEstacionServicio
                ds = sqlhelper.ExecuteDataset("GRF.EstacionServicio_LST",
                                            .TipoOperacion,
                                            .Id,
                                            .IdEmpresaSis,
                                            .IdSucursal,
                                            .Nombre,
                                            .Estado,
                                            .Usuario,
                                            .Activo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEstacionServicio = mt_Cargar(o_Fila)
                    olEstacionServicio.Add(oeEstacionServicio)
                Next
            End If
            Return olEstacionServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(ByVal oeEstacionServicio As e_EstacionServicio) As Boolean
        Try
            Dim stResultado() As String
            With oeEstacionServicio
                stResultado = sqlhelper.ExecuteScalar("GRF.EstacionServicio_IAE",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaSis,
                                              .IdSucursal,
                                              .Nombre,
                                              .Estado,
                                              .Usuario).ToString.Split("_")
                .Id = stResultado(0)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Eliminar(ByVal oeEstacionServicio As e_EstacionServicio) As Boolean
        Try
            With oeEstacionServicio
                sqlhelper.ExecuteNonQuery("GRF.EstacionServicio_IAE", "E", .Id, .IdEmpresaSis, .IdSucursal, .Nombre, .Estado, .Usuario)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
