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

Public Class d_EstadoRequerimiento
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_EstadoRequerimiento
        Try
            Dim oeEstadoRequerimiento = New e_EstadoRequerimiento( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                 )
            Return oeEstadoRequerimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEstadoRequerimiento As e_EstadoRequerimiento) As e_EstadoRequerimiento

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[CMP].[Isp_Estado_Requerimiento_Listar]", "", oeEstadoRequerimiento.Id, oeEstadoRequerimiento.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeEstadoRequerimiento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeEstadoRequerimiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEstadoRequerimiento As e_EstadoRequerimiento) As List(Of e_EstadoRequerimiento)
        Try
            Dim ldEstadoRequerimiento As New List(Of e_EstadoRequerimiento)
            Dim ds As DataSet
            With oeEstadoRequerimiento
                ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeEstadoRequerimiento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEstadoRequerimiento = Cargar(o_Fila)
                    ldEstadoRequerimiento.Add(oeEstadoRequerimiento)
                Next
            End If
            Return ldEstadoRequerimiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEstadoRequerimiento As e_EstadoRequerimiento) As Boolean
        Try
            With oeEstadoRequerimiento
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .UsuarioCreacion _
                         , .Activo
                     )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeEstadoRequerimiento As e_EstadoRequerimiento) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeEstadoRequerimiento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
