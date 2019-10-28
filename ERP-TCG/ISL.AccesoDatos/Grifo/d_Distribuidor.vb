Imports ERP.EntidadesWCF

Public Class d_Distribuidor

    Private sqlhelper As New SqlHelper

    Public Function mt_Cargar(fila As DataRow) As e_Distribuidor
        Try
            Dim oeDistribuidor = New e_Distribuidor With {.Id = fila("Id"),
                .IdEmpresaSis = fila("IdEmpresaSis"),
                .IdSucursal = fila("IdSucursal"),
                .IdLado = fila("IdLado"),
                .Nombre = fila("Nombre"),
                .Estado = fila("Estado"),
                .Activo = IIf(fila("Activo"), 1, 0)}
            Return oeDistribuidor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Obtener(ByVal oeDistribuidor As e_Distribuidor) As e_Distribuidor
        Try
            Dim ds As DataSet
            With oeDistribuidor
                ds = sqlhelper.ExecuteDataset("GRF.Distribuidor_LST",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaSis,
                                              .IdSucursal,
                                              .IdLado,
                                              .Nombre,
                                              .Estado,
                                              .Usuario,
                                              .Activo)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeDistribuidor = mt_Cargar(ds.Tables(0).Rows(0))
            Else
                oeDistribuidor = New e_Distribuidor
            End If
            Return oeDistribuidor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(ByVal oeDistribuidor As e_Distribuidor) As List(Of e_Distribuidor)
        Try
            Dim olDistribuidor As New List(Of e_Distribuidor)
            Dim ds As DataSet
            With oeDistribuidor
                ds = sqlhelper.ExecuteDataset("GRF.Distribuidor_LST",
                                            .TipoOperacion,
                                            .Id,
                                            .IdEmpresaSis,
                                            .IdSucursal,
                                            .IdLado,
                                            .Nombre,
                                            .Estado,
                                            .Usuario,
                                            .Activo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDistribuidor = mt_Cargar(o_Fila)
                    olDistribuidor.Add(oeDistribuidor)
                Next
            End If
            Return olDistribuidor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(ByVal oeDistribuidor As e_Distribuidor) As Boolean
        Try
            Dim stResultado() As String
            With oeDistribuidor
                stResultado = sqlhelper.ExecuteScalar("GRF.Distribuidor_IAE",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaSis,
                                              .IdSucursal,
                                              .IdLado,
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

    Public Function mt_Eliminar(ByVal oeDistribuidor As e_Distribuidor) As Boolean
        Try
            With oeDistribuidor
                sqlhelper.ExecuteNonQuery("GRF.Distribuidor_IAE", "E", .Id, .IdEmpresaSis, .IdSucursal, .IdLado, .Nombre, .Estado, .Usuario)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
