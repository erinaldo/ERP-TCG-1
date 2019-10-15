Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Public Class d_MotivoTraslado

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_MotivoTraslado
        Try
            Dim oeMotivoTraslado = New e_MotivoTraslado( _
                             o_Fila("Id").ToString _
                             , o_Fila("Codigo").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
            )
            Return oeMotivoTraslado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMotivoTraslado As e_MotivoTraslado) As e_MotivoTraslado

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[CMP].[Isp_MotivoTraslado_Listar]", "",
            Left(oeMotivoTraslado.PrefijoID, 1), "", oeMotivoTraslado.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeMotivoTraslado = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMotivoTraslado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMotivoTraslado As e_MotivoTraslado) As List(Of e_MotivoTraslado)
        Try
            Dim ldMotivoTraslado As New List(Of e_MotivoTraslado)
            Dim ds As DataSet
            With oeMotivoTraslado
                ds = sqlhelper.ExecuteDataset("[CMP].[Isp_MotivoTraslado_Listar]",
                         .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion
                        )
            End With
            oeMotivoTraslado = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMotivoTraslado = Cargar(o_Fila)
                    ldMotivoTraslado.Add(oeMotivoTraslado)
                Next
            End If
            Return ldMotivoTraslado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMotivoTraslado As e_MotivoTraslado) As Boolean
        Try
            With oeMotivoTraslado
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMotivoTraslado As e_MotivoTraslado) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeMotivoTraslado.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
