Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_OrdenTrabajo_MantenimientoEquipo

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenTrabajo_MantenimientoEquipo
        Try
            Dim oeOrdenTrabajo_MantenimientoEquipo = New e_OrdenTrabajo_MantenimientoEquipo( _
            o_fila("Seleccion").ToString _
            , o_fila("Id").ToString _
            , o_fila("IdOrdenTrabajo").ToString _
            , o_fila("IdMantenimientoEquipo").ToString _
            , o_fila("IdMantenimiento").ToString _
            , o_fila("Mantenimiento").ToString _
            , o_fila("TipoMantenimiento").ToString _
            , o_fila("IdEquipo").ToString _
            , o_fila("Equipo").ToString _
            , o_fila("Odometro").ToString _
            , o_fila("Horometro").ToString _
            , o_fila("Activo").ToString _
                   )
            Return oeOrdenTrabajo_MantenimientoEquipo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajo_MantenimientoEquipo As e_OrdenTrabajo_MantenimientoEquipo) As e_OrdenTrabajo_MantenimientoEquipo

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("MAN.Isp_OT_ME_Listar", oeOrdenTrabajo_MantenimientoEquipo.TipoOperacion, _
                                          oeOrdenTrabajo_MantenimientoEquipo.Id, _
                                          oeOrdenTrabajo_MantenimientoEquipo.IdOrdenTrabajo, _
                                          oeOrdenTrabajo_MantenimientoEquipo.IdMantenimientoEquipo, _
                                          oeOrdenTrabajo_MantenimientoEquipo.IdEquipo, _
                                          oeOrdenTrabajo_MantenimientoEquipo.IdMantenimiento _
                                          )
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeOrdenTrabajo_MantenimientoEquipo = Cargar(ds.Tables(0).Rows(0))
                Return oeOrdenTrabajo_MantenimientoEquipo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajo_MantenimientoEquipo As e_OrdenTrabajo_MantenimientoEquipo) As List(Of e_OrdenTrabajo_MantenimientoEquipo)
        Try
            Dim ldOrdenTrabajo_MantenimientoEquipo As New List(Of e_OrdenTrabajo_MantenimientoEquipo)
            Dim ds As DataSet
            With oeOrdenTrabajo_MantenimientoEquipo
                ds = sqlhelper.ExecuteDataset("MAN.Isp_OT_ME_Listar", .TipoOperacion _
                        , .Id _
                        , .IdOrdenTrabajo _
                        , .IdMantenimientoEquipo _
                        , "" _
                        , "" _
                        , .Activo _
                                               )
            End With
            oeOrdenTrabajo_MantenimientoEquipo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenTrabajo_MantenimientoEquipo = Cargar(o_Fila)
                    ldOrdenTrabajo_MantenimientoEquipo.Add(oeOrdenTrabajo_MantenimientoEquipo)
                Next
            End If
            Return ldOrdenTrabajo_MantenimientoEquipo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal ls_IdOrdenTrabajo As String) As Data.DataSet
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("MAN.Isp_OT_ME_Listar", "", "", ls_IdOrdenTrabajo)
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenTrabajo_MantenimientoEquipo As e_OrdenTrabajo_MantenimientoEquipo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeOrdenTrabajo_MantenimientoEquipo
                sqlhelper.ExecuteNonQuery("[MAN].[Isp_OT_ME_IAE]", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdOrdenTrabajo _
                        , .IdMantenimientoEquipo _
                        , .Odometro _
                        , .Horometro _
                        , .IdTrabajadorResponsable _
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

    Public Function Eliminar(ByVal oeOrdenTrabajo_MantenimientoEquipo As e_OrdenTrabajo_MantenimientoEquipo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[MAN].[Isp_OT_ME_IAE]", "E", "", oeOrdenTrabajo_MantenimientoEquipo.Id, _
                                      oeOrdenTrabajo_MantenimientoEquipo.IdOrdenTrabajo)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
