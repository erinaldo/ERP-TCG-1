'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_VehiculoTarjeta
    Private sqlhelper As New SqlHelper

    Private Function Cargar(o_fila As DataRow) As e_VehiculoTarjeta
        Try
            Dim oeVehiculoTarjeta = New e_VehiculoTarjeta With {
                                    .Id = o_fila("Id").ToString _
                                    , .IdVehiculo = o_fila("IdVehiculo").ToString _
                                    , .Placa = o_fila("Placa").ToString _
                                    , .IdEmpresaPropietaria = o_fila("IdEmpresaPropietaria").ToString _
                                    , .EmpresaPropietaria = o_fila("EmpresaPropietaria").ToString _
                                    , .NroTarjeta = o_fila("NroTarjeta").ToString _
                                    , .FechaInicial = o_fila("FechaInicial").ToString _
                                    , .FechaFinal = o_fila("FechaFinal").ToString _
                                    , .Glosa = o_fila("Glosa").ToString _
                                    , .Actual = o_fila("Actual").ToString _
                                    , .UsuarioCreacion = o_fila("UsuarioCreacion").ToString _
                                    , .FechaCreacion = o_fila("FechaCreacion").ToString _
                                    , .UsuarioModificacion = o_fila("UsuarioModificacion").ToString _
                                    , .FechaModificacion = o_fila("FechaModificacion").ToString _
                                    , .Activo = o_fila("Activo").ToString _
                                  }
            Return oeVehiculoTarjeta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeVehiculoTarjeta As e_VehiculoTarjeta) As e_VehiculoTarjeta
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_VehiculoTarjeta_Listar",
                                          "GEN",
                                            oeVehiculoTarjeta.Id,
                                            oeVehiculoTarjeta.IdVehiculo,
                                            oeVehiculoTarjeta.IdEmpresaPropietaria,
                                            oeVehiculoTarjeta.NroTarjeta,
                                            oeVehiculoTarjeta.FechaInicial,
                                            oeVehiculoTarjeta.FechaFinal,
                                            oeVehiculoTarjeta.Glosa,
                                            oeVehiculoTarjeta.Actual,
                                            oeVehiculoTarjeta.Activo)
            If ds.Tables(0).Rows.Count > 0 Then
                oeVehiculoTarjeta = Cargar(ds.Tables(0).Rows(0))
            Else
                oeVehiculoTarjeta = New e_VehiculoTarjeta
            End If
            Return oeVehiculoTarjeta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeVehiculoTarjeta As e_VehiculoTarjeta) As List(Of e_VehiculoTarjeta)
        Try
            Dim ldVehiculoTarjeta As New List(Of e_VehiculoTarjeta)
            Dim ds As DataSet
            With oeVehiculoTarjeta
                ds = sqlhelper.ExecuteDataset("STD.Isp_VehiculoTarjeta_Listar",
                                              .TipoOperacion _
                                            , .Id _
                                            , .IdVehiculo _
                                            , .IdEmpresaPropietaria _
                                            , .NroTarjeta _
                                            , .FechaInicial _
                                            , .FechaFinal _
                                            , .Glosa _
                                            , .Actual _
                                            , .Activo)
            End With
            oeVehiculoTarjeta = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeVehiculoTarjeta = Cargar(o_Fila)
                ldVehiculoTarjeta.Add(oeVehiculoTarjeta)
            Next
            Return ldVehiculoTarjeta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeVehiculoTarjeta As e_VehiculoTarjeta) As Boolean
        Try
            With oeVehiculoTarjeta
                sqlhelper.ExecuteScalar("STD.Isp_VehiculoTarjeta_IAE",
                                          .TipoOperacion _
                                            , .PrefijoID _
                                            , .Id _
                                            , .IdVehiculo _
                                            , .IdEmpresaPropietaria _
                                            , .NroTarjeta _
                                            , .FechaInicial _
                                            , .FechaFinal _
                                            , .Glosa _
                                            , .Actual _
                                            , .Activo _
                                            , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeVehiculoTarjeta As e_VehiculoTarjeta) As Boolean
        Try
            With oeVehiculoTarjeta
                sqlhelper.ExecuteScalar("STD.Isp_VehiculoTarjeta_IAE",
                                          "E" _
                                            , "" _
                                            , .Id _
                                            , .IdVehiculo _
                                            , .IdEmpresaPropietaria _
                                            , .NroTarjeta _
                                            , .FechaInicial _
                                            , .FechaFinal _
                                            , .Glosa _
                                            , .Actual _
                                            , .Activo _
                                            , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
