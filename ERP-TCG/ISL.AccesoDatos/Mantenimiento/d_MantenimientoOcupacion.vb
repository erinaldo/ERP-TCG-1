'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MantenimientoOcupacion

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MantenimientoOcupacion
        Try
            Dim oeMantenimientoOcupacion = New e_MantenimientoOcupacion( _
                         o_fila("Seleccion").ToString _
                            , o_fila("Id").ToString _
                             , o_fila("IdMantenimiento").ToString _
                             , o_fila("IdOcupacion").ToString _
                             , o_fila("Ocupacion").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("Activo").ToString _
                                   )
            Return oeMantenimientoOcupacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimientoOcupacion As e_MantenimientoOcupacion) As e_MantenimientoOcupacion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[MAN].[Isp_Mantenimiento_Ocupacion_Listar]", "", oeMantenimientoOcupacion.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMantenimientoOcupacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMantenimientoOcupacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimientoOcupacion As e_MantenimientoOcupacion) As List(Of e_MantenimientoOcupacion)
        Try
            Dim ldMantenimientoOcupacion As New List(Of e_MantenimientoOcupacion)
            Dim ds As DataSet
            With oeMantenimientoOcupacion
                ds = sqlhelper.ExecuteDataset("[MAN].[Isp_Mantenimiento_Ocupacion_Listar]", .TipoOperacion _
                        , .Id _
                        , .IdOcupacion _
                        , .IdMantenimiento _
                        , .Cantidad _
                        , .Activo _
                        , .UsuarioCreacion _
                                              )
            End With
            oeMantenimientoOcupacion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMantenimientoOcupacion = Cargar(o_Fila)
                    ldMantenimientoOcupacion.Add(oeMantenimientoOcupacion)
                Next
            End If
            Return ldMantenimientoOcupacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimientoOcupacion As e_MantenimientoOcupacion) As Boolean
        Try
            With oeMantenimientoOcupacion
                sqlhelper.ExecuteNonQuery("[MAN].[Isp_Mantenimiento_Ocupacion_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdMantenimiento _
                        , .IdOcupacion _
                        , .Cantidad _
                        , .Activo _
                        , .UsuarioCreacion
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMantenimientoOcupacion As e_MantenimientoOcupacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[MAN].[Isp_Mantenimiento_Ocupacion_IAE]", "E", _
             "", oeMantenimientoOcupacion.Id, oeMantenimientoOcupacion.IdMantenimiento)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
