Imports ERP.EntidadesWCF

Public Class d_Contometro_Mecanico

    Private sqlhelper As New SqlHelper

    Public Function mt_Cargar(fila As DataRow) As e_Contometro_Mecanico
        Try
            Dim oeContometro_Mecanico = New e_Contometro_Mecanico With {.Id = fila("Id"),
                .IdEmpresaSis = fila("IdEmpresaSis"),
                .IdSucursal = fila("IdSucursal"),
                .IdTurno = fila("Turno"),
                .IdDistribuidor = fila("IdDistribuidor"),
                .IdContometro_Electronico = fila("IdContometro_Electronico"),
                .Conteo_inicial = fila("Conteo_inicial"),
                .Conteo_final = fila("Conteo_final"),
                .Movimiento_contometro = fila("Movimiento_contometro"),
                .Movimiento_galon = fila("Movimiento_galon"),
                .Diferencia = fila("Diferencia"),
                .Estado = fila("Estado"),
                .Activo = IIf(fila("Activo"), 1, 0)}
            Return oeContometro_Mecanico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Obtener(ByVal oeContometro_Mecanico As e_Contometro_Mecanico) As e_Contometro_Mecanico
        Try
            Dim ds As DataSet
            With oeContometro_Mecanico
                ds = sqlhelper.ExecuteDataset("GRF.Contometro_Mecanico_LST",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaSis,
                                              .IdSucursal,
                                              .IdTurno,
                                              .IdDistribuidor,
                                              .Estado,
                                              .Usuario,
                                              .Activo)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeContometro_Mecanico = mt_Cargar(ds.Tables(0).Rows(0))
            Else
                oeContometro_Mecanico = New e_Contometro_Mecanico
            End If
            Return oeContometro_Mecanico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(ByVal oeContometro_Mecanico As e_Contometro_Mecanico) As List(Of e_Contometro_Mecanico)
        Try
            Dim olContometro_Mecanico As New List(Of e_Contometro_Mecanico)
            Dim ds As DataSet
            With oeContometro_Mecanico
                ds = sqlhelper.ExecuteDataset("GRF.Contometro_Mecanico_LST",
                                            .TipoOperacion,
                                            .Id,
                                            .IdEmpresaSis,
                                            .IdSucursal,
                                            .IdTurno,
                                            .IdDistribuidor,
                                            .Estado,
                                            .Usuario,
                                            .Activo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeContometro_Mecanico = mt_Cargar(o_Fila)
                    olContometro_Mecanico.Add(oeContometro_Mecanico)
                Next
            End If
            Return olContometro_Mecanico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(ByVal oeContometro_Mecanico As e_Contometro_Mecanico) As Boolean
        Try
            Dim stResultado() As String
            With oeContometro_Mecanico
                stResultado = sqlhelper.ExecuteScalar("GRF.ContoMetroEletronico_IAE",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaSis,
                                              .IdSucursal,
                                              .IdTurno,
                                              .IdDistribuidor,
                                              .IdContometro_Electronico,
                                              .Conteo_inicial,
                                              .Conteo_final,
                                              .Movimiento_contometro,
                                              .Movimiento_galon,
                                              .Diferencia,
                                              .Estado,
                                              .Usuario).ToString.Split("_")
                .Id = stResultado(0)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Eliminar(ByVal oeContometro_Mecanico As e_Contometro_Mecanico) As Boolean
        Try
            With oeContometro_Mecanico
                sqlhelper.ExecuteNonQuery("GRF.ContoMetroEletronico:IAE",
                                          "E",
                                          .Id,
                                          .IdEmpresaSis,
                                          .IdSucursal,
                                          .IdTurno,
                                          .IdDistribuidor,
                                          .IdContometro_Electronico,
                                          .Conteo_inicial,
                                          .Conteo_final,
                                          .Movimiento_contometro,
                                          .Movimiento_galon,
                                          .Diferencia,
                                          .Estado,
                                          .Usuario)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
