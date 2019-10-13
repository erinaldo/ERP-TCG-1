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

Public Class d_Actividad
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Actividad
        Try
            Dim oeActividad = New e_Actividad(o_fila("Seleccion") _
                             , o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Descripcion").ToString _
                     )
            Return oeActividad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeActividad As e_Actividad) As e_Actividad

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[MAN].[Isp_Actividad_Listar]", "", _
                                          oeActividad.Id, oeActividad.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeActividad = Cargar(ds.Tables(0).Rows(0))
                Return oeActividad
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return Nothing
    End Function

    Public Function Listar(ByVal oeActividad As e_Actividad) As List(Of e_Actividad)
        Try
            Dim ldActividad As New List(Of e_Actividad)
            Dim ds As DataSet
            With oeActividad
                ds = sqlhelper.ExecuteDataset("[MAN].[Isp_Actividad_Listar]", "" _
                        , .Id _
                        , .Nombre _
                        , .Codigo _
                        , .Activo _
                        , .UsuarioCreacion _
                           )
            End With
            oeActividad = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeActividad = Cargar(o_Fila)
                    ldActividad.Add(oeActividad)
                Next
                Return ldActividad
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeActividad As e_Actividad) As Boolean
        Try
            With oeActividad
                sqlhelper.ExecuteNonQuery("[MAN].[Isp_Actividad_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
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

    Public Function Eliminar(ByVal oeActividad As e_Actividad) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[MAN].[Isp_Actividad_IAE]", "E", _
             "", oeActividad.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
