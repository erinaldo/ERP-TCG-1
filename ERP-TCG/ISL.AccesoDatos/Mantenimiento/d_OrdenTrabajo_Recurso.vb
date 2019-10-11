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

Public Class d_OrdenTrabajo_Recurso
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenTrabajo_Recurso
        Try
            Dim oeOrdenTrabajo_Recurso = New e_OrdenTrabajo_Recurso( _
                             o_fila("Id").ToString _
                             , o_fila("IdOcupacionTrabajador").ToString _
                             , o_fila("IdOrdenTrabajo").ToString _
                             , o_fila("IdMantenimientoEquipo").ToString _
                             , o_fila("CantidadHoras").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeOrdenTrabajo_Recurso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajo_Recurso As e_OrdenTrabajo_Recurso) As e_OrdenTrabajo_Recurso

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeOrdenTrabajo_Recurso.Id)
            If ds.Tables.Count > 0 Then
                oeOrdenTrabajo_Recurso = Cargar(ds.Tables(0).Rows(0))
                Return oeOrdenTrabajo_Recurso
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajo_Recurso As e_OrdenTrabajo_Recurso) As List(Of e_OrdenTrabajo_Recurso)
        Try
            Dim ldOrdenTrabajo_Recurso As New List(Of e_OrdenTrabajo_Recurso)
            Dim ds As DataSet
            With oeOrdenTrabajo_Recurso
                ds = sqlhelper.ExecuteDataset("[MAN].[Isp_OrdenTrabajo_Recurso_Listar]", "" _
                        , .Id _
                        , .IdOcupacionTrabajador _
                        , .IdOrdenTrabajo _
                        , .IdMantenimientoEquipo _
                        , .CantidadHoras _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeOrdenTrabajo_Recurso = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenTrabajo_Recurso = Cargar(o_Fila)
                    ldOrdenTrabajo_Recurso.Add(oeOrdenTrabajo_Recurso)
                Next
                Return ldOrdenTrabajo_Recurso
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal ls_IdOrdenTrabajo As String) As Data.DataSet
        Try
            Return sqlhelper.ExecuteDataset("[MAN].[Isp_OrdenTrabajo_Recurso_Listar]", "L", "", "", ls_IdOrdenTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Guardar(ByVal oeOrdenTrabajo_Recurso As e_OrdenTrabajo_Recurso) As Boolean
        Try
            With oeOrdenTrabajo_Recurso
                sqlhelper.ExecuteNonQuery("[MAN].[Isp_OrdenTrabajo_Recurso_IAE]", .TipoOperacion, .PrefijoID _
                        , .Id _
                         , .IdOrdenTrabajo _
                        , .IdOcupacionTrabajador _
                        , .IdMantenimientoEquipo _
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

    Public Function Eliminar(ByVal oeOrdenTrabajo_Recurso As e_OrdenTrabajo_Recurso) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[MAN].[Isp_OrdenTrabajo_Recurso_IAE]", "E", "", oeOrdenTrabajo_Recurso.Id _
                                      , oeOrdenTrabajo_Recurso.IdOrdenTrabajo)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
