Imports ERP.EntidadesWCF

Public Class d_Isla
    Private sqlhelper As New SqlHelper

    Public Function mt_Cargar(fila As DataRow) As e_isla
        Try
            Dim oeIsla = New e_Isla With {.Id = fila("Id"),
                .IdEmpresaSis = fila("IdEmpresaSis"),
                .IdSucursal = fila("IdSucursal"),
                .IdEstacionServicio = fila("IdEstacionServicio"),
                .Nombre = fila("Nombre"),
                .Estado = fila("Estado"),
                .Activo = IIf(fila("Activo"), 1, 0)}
            Return oeIsla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Obtener(ByVal oeIsla As e_Isla) As e_Isla
        Try
            Dim ds As DataSet
            With oeIsla
                ds = sqlhelper.ExecuteDataset("GRF.Isla_LST",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaSis,
                                              .IdSucursal,
                                              .IdEstacionServicio,
                                              .Nombre,
                                              .Estado,
                                              .Usuario,
                                              .Activo)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeIsla = mt_Cargar(ds.Tables(0).Rows(0))
            Else
                oeIsla = New e_Isla
            End If
            Return oeIsla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(ByVal oeIsla As e_Isla) As List(Of e_Isla)
        Try
            Dim olIsla As New List(Of e_Isla)
            Dim ds As DataSet
            With oeIsla
                ds = sqlhelper.ExecuteDataset("GRF.Isla_LST",
                                            .TipoOperacion,
                                            .Id,
                                            .IdEmpresaSis,
                                            .IdSucursal,
                                            .IdEstacionServicio,
                                            .Nombre,
                                            .Estado,
                                            .Usuario,
                                            .Activo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeIsla = mt_Cargar(o_Fila)
                    olIsla.Add(oeIsla)
                Next
            End If
            Return olIsla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(ByVal oeIsla As e_Isla) As Boolean
        Try
            Dim stResultado() As String
            With oeIsla
                stResultado = sqlhelper.ExecuteScalar("GRF.Isla_IAE",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaSis,
                                              .IdSucursal,
                                              .IdEstacionServicio,
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

    Public Function mt_Eliminar(ByVal oeIsla As e_Isla) As Boolean
        Try
            With oeIsla
                sqlhelper.ExecuteNonQuery("GRF.Isla_IAE", "E", .Id, .IdEmpresaSis, .IdSucursal, .IdEstacionServicio, .Nombre, .Estado, .Usuario)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
