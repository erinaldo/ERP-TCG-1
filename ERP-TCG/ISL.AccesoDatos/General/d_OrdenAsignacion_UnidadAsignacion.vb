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

Public Class d_OrdenAsignacion_UnidadAsignacion
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenAsignacion_UnidadAsignacion
        Try
            Dim oeOrdenAsignacion_UnidadAsignacion = New e_OrdenAsignacion_UnidadAsignacion( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdOrdenAsignacion").ToString _
                             , o_Fila("IndUnidadAsignacion").ToString _
                             , o_Fila("IdUnidadAsignacion").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
            )
            Return oeOrdenAsignacion_UnidadAsignacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarTodo(ByVal o_fila As DataRow) As e_OrdenAsignacion_UnidadAsignacion
        Try
            Dim oeOrdenAsignacion_UnidadAsignacion = New e_OrdenAsignacion_UnidadAsignacion( _
                             o_fila("Id").ToString _
                             , o_fila("IndUnidadAsignacion").ToString _
                             , o_fila("IdUnidadAsignacion").ToString _
                             , o_fila("Nombre").ToString _
            )
            Return oeOrdenAsignacion_UnidadAsignacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As e_OrdenAsignacion_UnidadAsignacion
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_OrdenAsignacion_UnidadAsignacion_Listar", "" _
                                          , oeOrdenAsignacion_UnidadAsignacion.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeOrdenAsignacion_UnidadAsignacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrdenAsignacion_UnidadAsignacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As List(Of e_OrdenAsignacion_UnidadAsignacion)
        Try
            Dim ldOrdenAsignacion_UnidadAsignacion As New List(Of e_OrdenAsignacion_UnidadAsignacion)
            Dim ds As DataSet
            With oeOrdenAsignacion_UnidadAsignacion
                ds = sqlhelper.ExecuteDataset("STD.Isp_OrdenAsignacion_UnidadAsignacion_Listar" _
                                              , .TipoOperacion _
                                              , .Id _
                                              , .IdOrdenAsignacion _
                                              , .IndUnidadAsignacion _
                                              , .IdUnidadAsignacion _
                                              , .Activo _
                                              , .UsuarioCreacion _
                                              , .FechaCreacion
                                              )
            End With
            oeOrdenAsignacion_UnidadAsignacion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenAsignacion_UnidadAsignacion = Cargar(o_Fila)
                    ldOrdenAsignacion_UnidadAsignacion.Add(oeOrdenAsignacion_UnidadAsignacion)
                Next
            End If
            Return ldOrdenAsignacion_UnidadAsignacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTodo(ByVal oeOrdenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As List(Of e_OrdenAsignacion_UnidadAsignacion)
        Try
            Dim ldOrdenAsignacion_UnidadAsignacion As New List(Of e_OrdenAsignacion_UnidadAsignacion)
            Dim ds As DataSet
            With oeOrdenAsignacion_UnidadAsignacion
                ds = sqlhelper.ExecuteDataset("STD.Isp_OrdenAsignacion_UnidadAsignacion_Listar" _
                                              , .TipoOperacion)
            End With
            oeOrdenAsignacion_UnidadAsignacion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenAsignacion_UnidadAsignacion = CargarTodo(o_Fila)
                    ldOrdenAsignacion_UnidadAsignacion.Add(oeOrdenAsignacion_UnidadAsignacion)
                Next
            End If
            Return ldOrdenAsignacion_UnidadAsignacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As Boolean
        Try
            With oeOrdenAsignacion_UnidadAsignacion
                sqlhelper.ExecuteNonQuery("STD.Isp_OrdenAsignacion_UnidadAsignacion_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdOrdenAsignacion _
                        , .IndUnidadAsignacion _
                        , .IdUnidadAsignacion _
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

    Public Function Eliminar(ByVal oeOrdenAsignacion_UnidadAsignacion As e_OrdenAsignacion_UnidadAsignacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_OrdenAsignacion_UnidadAsignacion_IAE", "E", _
             "", oeOrdenAsignacion_UnidadAsignacion.Id, oeOrdenAsignacion_UnidadAsignacion.IdOrdenAsignacion)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class