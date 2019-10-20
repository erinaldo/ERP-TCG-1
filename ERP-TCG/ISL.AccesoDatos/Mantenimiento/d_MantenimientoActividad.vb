'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MantenimientoActividad

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MantenimientoActividad
        Try
            Dim oeMantenimientoActividad = New e_MantenimientoActividad(o_fila("Seleccion") _
                             , o_fila("Id").ToString _
                              , o_fila("IdMantenimiento").ToString _
                             , o_fila("IdActividad").ToString _
                             , o_fila("Actividad").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("CantidadHoras").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeMantenimientoActividad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As e_MantenimientoActividad
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[MAN].[Isp_Mantenimiento_Actividad_Listar]", "", oeMantenimientoActividad.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMantenimientoActividad = Cargar(ds.Tables(0).Rows(0))
                Return oeMantenimientoActividad
            End If
            Return oeMantenimientoActividad
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As List(Of e_MantenimientoActividad)
        Try
            Dim ldMantenimientoActividad As New List(Of e_MantenimientoActividad)
            Dim ds As DataSet
            With oeMantenimientoActividad
                ds = sqlhelper.ExecuteDataset("[MAN].[Isp_Mantenimiento_Actividad_Listar]", .TipoOperacion _
                        , .Id _
                        , .IdActividad _
                        , .IdMantenimiento _
                        , .CantidadHoras _
                        , .Activo _
                        )
            End With
            oeMantenimientoActividad = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMantenimientoActividad = Cargar(o_Fila)
                    ldMantenimientoActividad.Add(oeMantenimientoActividad)
                Next

            End If
            Return ldMantenimientoActividad
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As Boolean
        Try
            With oeMantenimientoActividad
                sqlhelper.ExecuteNonQuery("[MAN].[Isp_Mantenimiento_Actividad_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdMantenimiento _
                        , .IdActividad _
                        , .CantidadHoras _
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

    Public Function Eliminar(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[MAN].[Isp_Mantenimiento_Actividad_IAE]", "E", _
             "", oeMantenimientoActividad.Id, oeMantenimientoActividad.IdMantenimiento)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
