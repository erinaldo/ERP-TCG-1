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

Public Class d_OrdenTrabajo_Actividad
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenTrabajo_Actividad
        Try
            Dim oeOrdenTrabajo_Actividad = New e_OrdenTrabajo_Actividad( _
                             o_fila("Id").ToString _
                             , o_fila("IdActividad").ToString _
                             , o_fila("IdOrdenTrabajo").ToString _
                             , o_fila("IdMantenimientoEquipo").ToString _
                             , o_fila("CantidadHoras").ToString _
                             , o_fila("Activo").ToString _
                        )
            Return oeOrdenTrabajo_Actividad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As e_OrdenTrabajo_Actividad

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeOrdenTrabajo_Actividad.Id)
            If ds.Tables.Count > 0 Then
                oeOrdenTrabajo_Actividad = Cargar(ds.Tables(0).Rows(0))
                Return oeOrdenTrabajo_Actividad
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As List(Of e_OrdenTrabajo_Actividad)
        Try
            Dim ldOrdenTrabajo_Actividad As New List(Of e_OrdenTrabajo_Actividad)
            Dim ds As DataSet
            With oeOrdenTrabajo_Actividad
                ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdActividad _
                        , .IdOrdenTrabajo _
                        , .IdMantenimientoEquipo _
                        , .CantidadHoras _
                        , .Activo _
                        )
            End With
            oeOrdenTrabajo_Actividad = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenTrabajo_Actividad = Cargar(o_Fila)
                    ldOrdenTrabajo_Actividad.Add(oeOrdenTrabajo_Actividad)
                Next
                Return ldOrdenTrabajo_Actividad
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal ls_IdOrdenTrabajo As String) As Data.DataSet
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[MAN].[Isp_OrdenTrabajo_Actividad_Listar]", "L", _
                                           "", "", ls_IdOrdenTrabajo)
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Guardar(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As Boolean
        Try
            With oeOrdenTrabajo_Actividad
                sqlhelper.ExecuteNonQuery("[MAN].[Isp_OrdenTrabajo_Actividad_IAE]", .TipoOperacion, .PrefijoID _
                        , .Id _
                        , .IdOrdenTrabajo _
                        , .IdActividad _
                        , .IdMantenimientoEquipo _
                        , .CantidadDias _
                        , .CantidadHoras _
                        , .CantidadMinutos _
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

    Public Function Eliminar(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[MAN].[Isp_OrdenTrabajo_Actividad_IAE]", "E", "", oeOrdenTrabajo_Actividad.Id _
                                      , oeOrdenTrabajo_Actividad.IdOrdenTrabajo)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
