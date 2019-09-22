Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_EstadoOT
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_EstadoOT
        Try
            Dim oeEstadoOT = New e_EstadoOT( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeEstadoOT
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEstadoOT As e_EstadoOT) As e_EstadoOT

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[MAN].[Isp_EstadoOT_Listar]", "", oeEstadoOT.Id, oeEstadoOT.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeEstadoOT = Cargar(ds.Tables(0).Rows(0))
                Return oeEstadoOT
            End If
            Return oeEstadoOT
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEstadoOT As e_EstadoOT) As List(Of e_EstadoOT)
        Try
            Dim ldEstadoOT As New List(Of e_EstadoOT)
            Dim ds As DataSet
            With oeEstadoOT
                ds = sqlhelper.ExecuteDataset("[MAN].[Isp_EstadoOT_Listar]", "" _
                        , .Id _
                        , .Nombre _
                        , .Activo _
                                       )
            End With
            oeEstadoOT = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEstadoOT = Cargar(o_Fila)
                    ldEstadoOT.Add(oeEstadoOT)
                Next
            End If
            Return ldEstadoOT
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEstadoOT As e_EstadoOT) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeEstadoOT
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .Nombre _
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

    Public Function Eliminar(ByVal oeEstadoOT As e_EstadoOT) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeEstadoOT.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
