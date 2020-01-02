' ===================================================================================================
' Modified | Developer
' 02/01/20 | Cess
' ===================================================================================================
Imports ERP.EntidadesWCF

Public Class d_Contometro_Electronico

    Private sqlhelper As New SqlHelper

    Public Function mt_Cargar(fila As DataRow) As e_Contometro_Electronico
        Try
            Dim oeContometro_Electronico = New e_Contometro_Electronico With {.Id = fila("Id"),
                .IdEmpresaSis = fila("IdEmpresaSis"),
                .IdSucursal = fila("IdSucursal"),
                .IdTurno = fila("Turno"),
                .IdDistribuidor = fila("IdDistribuidor"),
                .Conteo_inicial = fila("Conteo_inicial"),
                .Conteo_final = fila("Conteo_final"),
                .Movimiento_galones = fila("Movimiento_galones"),
                .Conteo_inicial_venta = fila("Conteo_inicial_venta"),
                .Diferencia_galones = fila("Diferencia_galones"),
                .Precio_referencial = fila("Precio_referencial"),
                .Monto_Factor = fila("Monto_Factor"),
                .Estado = fila("Estado"),
                .Activo = IIf(fila("Activo"), 1, 0)}
            Return oeContometro_Electronico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Obtener(ByVal oeContometro_Electronico As e_Contometro_Electronico) As e_Contometro_Electronico
        Try
            Dim ds As DataSet
            With oeContometro_Electronico
                ds = sqlhelper.ExecuteDataset("GRF.Contometro_Electronico_LST",
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
                oeContometro_Electronico = mt_Cargar(ds.Tables(0).Rows(0))
            Else
                oeContometro_Electronico = New e_Contometro_Electronico
            End If
            Return oeContometro_Electronico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(ByVal oeContometro_Electronico As e_Contometro_Electronico) As List(Of e_Contometro_Electronico)
        Try
            Dim olContometro_Electronico As New List(Of e_Contometro_Electronico)
            Dim ds As DataSet
            With oeContometro_Electronico
                ds = sqlhelper.ExecuteDataset("GRF.Contometro_Electronico_LST",
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
                    oeContometro_Electronico = mt_Cargar(o_Fila)
                    olContometro_Electronico.Add(oeContometro_Electronico)
                Next
            End If
            Return olContometro_Electronico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(ByVal oeContometro_Electronico As e_Contometro_Electronico) As Boolean
        Try
            Dim stResultado() As String
            With oeContometro_Electronico
                stResultado = sqlhelper.ExecuteScalar("GRF.ContoMetroEletronico_IAE",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaSis,
                                              .IdSucursal,
                                              .IdTurno,
                                              .IdDistribuidor,
                                              .Conteo_inicial,
                                              .Conteo_final,
                                              .Movimiento_galones,
                                              .Conteo_inicial_venta,
                                              .Diferencia_galones,
                                              .Precio_referencial,
                                              .Monto_Factor,
                                              .Estado,
                                              .Usuario).ToString.Split("_")
                .Id = stResultado(0)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Eliminar(ByVal oeContometro_Electronico As e_Contometro_Electronico) As Boolean
        Try
            With oeContometro_Electronico
                sqlhelper.ExecuteNonQuery("GRF.ContoMetroEletronico_IAE",
                                          "E",
                                          .Id,
                                          .IdEmpresaSis,
                                          .IdSucursal,
                                          .IdTurno,
                                          .IdDistribuidor,
                                          .Conteo_inicial,
                                          .Conteo_final,
                                          .Movimiento_galones,
                                          .Conteo_inicial_venta,
                                          .Diferencia_galones,
                                          .Precio_referencial,
                                          .Monto_Factor,
                                          .Estado,
                                          .Usuario)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
