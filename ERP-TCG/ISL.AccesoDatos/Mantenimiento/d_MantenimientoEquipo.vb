Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MantenimientoEquipo

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MantenimientoEquipo
        Try
            Dim oeMantenimiento_Equipo = New e_MantenimientoEquipo(o_fila("Seleccion") _
                             , o_fila("Id").ToString _
                             , o_fila("IdMantenimiento").ToString _
                             , o_fila("Mantenimiento").ToString _
                             , o_fila("TipoMantenimiento").ToString _
                             , o_fila("IdEquipo").ToString _
                              , o_fila("Codigo").ToString _
                              , o_fila("Equipo").ToString _
                              , o_fila("IdMarca").ToString _
                              , o_fila("Marca").ToString _
                              , o_fila("IdModelo").ToString _
                              , o_fila("Modelo").ToString _
                               , o_fila("IdVehiculo").ToString _
                               , o_fila("CantidadMedida") _
                             , o_fila("Activo").ToString _
                             , o_fila("TipoVehiculo").ToString _
                                                         )
            Return oeMantenimiento_Equipo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimiento_Equipo As e_MantenimientoEquipo) As e_MantenimientoEquipo

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("MAN.Isp_Mantenimiento_Equipo_Listar", "L", oeMantenimiento_Equipo.Id, oeMantenimiento_Equipo.IdMantenimiento, "", oeMantenimiento_Equipo.IdEquipo)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMantenimiento_Equipo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMantenimiento_Equipo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimiento_Equipo As e_MantenimientoEquipo) As List(Of e_MantenimientoEquipo)
        Try
            Dim ldMantenimiento_Equipo As New List(Of e_MantenimientoEquipo)
            Dim ds As DataSet
            With oeMantenimiento_Equipo
                ds = sqlhelper.ExecuteDataset("MAN.Isp_Mantenimiento_Equipo_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMantenimiento _
                        , .IdTipoMantenimiento _
                        , .IdEquipo _
                        , .IdMarca _
                        , .IdModelo _
                        , .Activo _
                              )
            End With
            oeMantenimiento_Equipo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMantenimiento_Equipo = Cargar(o_Fila)
                    ldMantenimiento_Equipo.Add(oeMantenimiento_Equipo)
                Next
            End If
            Return ldMantenimiento_Equipo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimiento_Equipo As e_MantenimientoEquipo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeMantenimiento_Equipo
                sqlhelper.ExecuteNonQuery("MAN.Isp_Mantenimiento_Equipo_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdMantenimiento _
                        , .IdEquipo _
                        , .CantidadMedida _
                        , .Activo _
                        , .UsuarioCreacion _
                                 )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMantenimiento_Equipo As e_MantenimientoEquipo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("MAN.Isp_Mantenimiento_Equipo_IAE", "E", _
             "", oeMantenimiento_Equipo.Id, oeMantenimiento_Equipo.IdMantenimiento)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
