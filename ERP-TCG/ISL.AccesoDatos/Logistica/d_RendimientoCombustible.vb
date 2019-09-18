Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RendimientoCombustible
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_RendimientoCombustible
        Try
            Dim oeRendimientoCombustible = New e_RendimientoCombustible( _
                         o_fila("Id").ToString _
                         , o_fila("IdTipoVehiculo").ToString _
                         , o_fila("IdFlota").ToString _
                         , o_fila("IdUnidadMedida").ToString _
                         , o_fila("Peso").ToString _
                         , o_fila("Rendimiento").ToString _
                         , o_fila("Activo").ToString _
                         , o_fila("UsuarioCreacion").ToString _
                         , o_fila("UsuarioModificacion").ToString _
                          )
            Return oeRendimientoCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As e_RendimientoCombustible
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_RendimientoCombustible_Listar", _
                                          oeRendimientoCombustible.TipoOperacion, _
                                          oeRendimientoCombustible.Id, _
                                          oeRendimientoCombustible.IdTipoVehiculo, _
                                          oeRendimientoCombustible.IdFlota, _
                                          oeRendimientoCombustible.Activo _
                                          )
            If ds.Tables(0).Rows.Count > 0 Then
                oeRendimientoCombustible = Cargar(ds.Tables(0).Rows(0))
            Else
                oeRendimientoCombustible = New e_RendimientoCombustible
            End If
            Return oeRendimientoCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As List(Of e_RendimientoCombustible)
        Try
            Dim loRendimientoCombustible As New List(Of e_RendimientoCombustible)
            Dim ds As DataSet
            With oeRendimientoCombustible
                ds = sqlhelper.ExecuteDataset("OPE.Isp_RendimientoCombustible_Listar", _
                                          oeRendimientoCombustible.TipoOperacion, _
                                          oeRendimientoCombustible.Id, _
                                          oeRendimientoCombustible.IdTipoVehiculo, _
                                          oeRendimientoCombustible.IdFlota, _
                                          oeRendimientoCombustible.Activo _
                                          )
            End With
            oeRendimientoCombustible = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRendimientoCombustible = Cargar(o_Fila)
                    loRendimientoCombustible.Add(oeRendimientoCombustible)
                Next
            Else
                loRendimientoCombustible = New List(Of e_RendimientoCombustible)
            End If
            Return loRendimientoCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeRendimientoCombustible
                sqlhelper.ExecuteNonQuery("OPE.Isp_RendimientoCombustible_IAE", _
                                          .TipoOperacion, _
                                           .PrefijoID, _
                                            .Id _
                                            , .IdTipoVehiculo _
                                            , .IdFlota _
                                            , .IdUnidadMedida _
                                            , .Peso _
                                            , .Rendimiento _
                                            , .Activo _
                                            , .UsuarioCreacion _
                                            , .UsuarioModificacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As Boolean
        Try
            With oeRendimientoCombustible
                sqlhelper.ExecuteNonQuery("OPE.Isp_RendimientoCombustible_IAE", _
                                            "E", _
                                            "1SI", _
                                            .Id _
                                            , "" _
                                            , "" _
                                            , "" _
                                            , 0.0 _
                                            , 0.0 _
                                            , False _
                                            , .UsuarioCreacion _
                                            , .UsuarioModificacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
