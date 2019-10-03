Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Public Class d_DetalleValorizacionNeumatico
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleValorizacionNeumatico
        Try
            Dim oeDetalleValorizacionNeumatico = New e_DetalleValorizacionNeumatico( _
                             o_fila("Id").ToString _
                             , o_fila("IdValorizacion").ToString _
                             , o_fila("IdVidaNeumatico").ToString _
                             , o_fila("CodigoNeumatico").ToString _
                             , o_fila("Marca").ToString _
                             , o_fila("Medida").ToString _
                             , o_fila("Diseño").ToString _
                             , o_fila("ValorDolares") _
                             , o_fila("Activo").ToString _
            )
            Return oeDetalleValorizacionNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As e_DetalleValorizacionNeumatico

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeDetalleValorizacionNeumatico.Id)
            If ds.Tables.Count > 0 Then
                oeDetalleValorizacionNeumatico = Cargar(ds.Tables(0).Rows(0))
                Return oeDetalleValorizacionNeumatico
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As List(Of e_DetalleValorizacionNeumatico)
        Try
            Dim ldDetalleValorizacionNeumatico As New List(Of e_DetalleValorizacionNeumatico)
            Dim ds As DataSet
            With oeDetalleValorizacionNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_DetalleValorizacionNeumatico_Listar]", "" _
                        , .Id _
                        , .IdValorizacion _
                        , .IdVidaNeumatico _
                        , .Activo _
                        )
            End With
            oeDetalleValorizacionNeumatico = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDetalleValorizacionNeumatico = Cargar(o_Fila)
                    ldDetalleValorizacionNeumatico.Add(oeDetalleValorizacionNeumatico)
                Next
            End If
            Return ldDetalleValorizacionNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetalleValorizacionNeumatico
                sqlhelper.ExecuteNonQuery("[NEU].[Isp_DetalleValorizacionNeumatico_IAE]", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdValorizacion _
                        , .IdVidaNeumatico _
                        , .ValorDolares _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeDetalleValorizacionNeumatico.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
