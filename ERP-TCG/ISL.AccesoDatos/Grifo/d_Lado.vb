Imports ERP.EntidadesWCF

Public Class d_Lado

    Private sqlhelper As New SqlHelper

    Public Function mt_Cargar(fila As DataRow) As e_Lado
        Try
            Dim oeLado = New e_Lado With {.Id = fila("Id"),
                .IdEmpresaSis = fila("IdEmpresaSis"),
                .IdSucursal = fila("IdSucursal"),
                .IdIsla = fila("IdIsla"),
                .Nombre = fila("Nombre"),
                .Estado = fila("Estado"),
                .Activo = IIf(fila("Activo"), 1, 0)}
            Return oeLado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Obtener(ByVal oeIsla As e_Lado) As e_Lado
        Try
            Dim ds As DataSet
            With oeIsla
                ds = sqlhelper.ExecuteDataset("GRF.Lado_LST",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaSis,
                                              .IdSucursal,
                                              .IdIsla,
                                              .Nombre,
                                              .Estado,
                                              .Usuario,
                                              .Activo)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeIsla = mt_Cargar(ds.Tables(0).Rows(0))
            Else
                oeIsla = New e_Lado
            End If
            Return oeIsla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(ByVal oeLado As e_Lado) As List(Of e_Lado)
        Try
            Dim olLado As New List(Of e_Lado)
            Dim ds As DataSet
            With oeLado
                ds = sqlhelper.ExecuteDataset("GRF.Lado_LST",
                                            .TipoOperacion,
                                            .Id,
                                            .IdEmpresaSis,
                                            .IdSucursal,
                                            .IdIsla,
                                            .Nombre,
                                            .Estado,
                                            .Usuario,
                                            .Activo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeLado = mt_Cargar(o_Fila)
                    olLado.Add(oeLado)
                Next
            End If
            Return olLado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(ByVal oeLado As e_Lado) As Boolean
        Try
            Dim stResultado() As String
            With oeLado
                stResultado = sqlhelper.ExecuteScalar("GRF.Lado_IAE",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaSis,
                                              .IdSucursal,
                                              .IdIsla,
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

    Public Function mt_Eliminar(ByVal oeLado As e_Lado) As Boolean
        Try
            With oeLado
                sqlhelper.ExecuteNonQuery("GRF.Lado_IAE", "E", .Id, .IdEmpresaSis, .IdSucursal, .IdIsla, .Nombre, .Estado, .Usuario)

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
