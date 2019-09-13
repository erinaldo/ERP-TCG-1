Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MantenimientoServicio
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MantenimientoServicio
        Try
            Dim oeMantenimientoServicio = New e_MantenimientoServicio( _
            o_fila("Seleccion").ToString _
            , o_fila("Id").ToString _
                             , o_fila("IdMantenimiento").ToString _
                             , o_fila("IdServicio").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Servicio").ToString _
                             , o_fila("IdEquipo").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("Costo").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeMantenimientoServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimientoServicio As e_MantenimientoServicio) As e_MantenimientoServicio

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[MAN].[Isp_Mantenimiento_Servicio_Listar]", "", oeMantenimientoServicio.Id)
            If ds.Tables.Count > 0 Then
                oeMantenimientoServicio = Cargar(ds.Tables(0).Rows(0))
                Return oeMantenimientoServicio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimientoServicio As e_MantenimientoServicio) As List(Of e_MantenimientoServicio)
        Try
            Dim ldMantenimientoServicio As New List(Of e_MantenimientoServicio)
            Dim ds As DataSet
            With oeMantenimientoServicio
                ds = sqlhelper.ExecuteDataset("[MAN].[Isp_Mantenimiento_Servicio_Listar]", .TipoOperacion _
                        , .Id _
                        , .IdMantenimiento _
                        , .IdServicio _
                        , .IdCategoriaServicio _
                        , .IdEquipo _
                        , .Cantidad _
                        , .Costo _
                        , .Descripcion _
                        , .Activo _
                        , .UsuarioCreacion _
                                            )
            End With
            oeMantenimientoServicio = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMantenimientoServicio = Cargar(o_Fila)
                    ldMantenimientoServicio.Add(oeMantenimientoServicio)
                Next
                Return ldMantenimientoServicio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimientoServicio As e_MantenimientoServicio) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeMantenimientoServicio
                sqlhelper.ExecuteNonQuery("[MAN].[Isp_Mantenimiento_Servicio_IAE]", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdMantenimiento _
                        , .IdServicio _
                        , .IdEquipo _
                        , .Cantidad _
                        , .Costo _
                        , .Descripcion _
                        , .Activo _
                        , .UsuarioCreacion _
                           )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMantenimientoServicio As e_MantenimientoServicio) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[MAN].[Isp_Mantenimiento_Servicio_IAE]", "E", _
             "", oeMantenimientoServicio.Id, oeMantenimientoServicio.IdMantenimiento)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
