Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ValorizacionNeumatico
    Private sqlhelper As New SqlHelper
    Dim odDetalleValorizacion As New d_DetalleValorizacionNeumatico
    Private Function Cargar(ByVal o_fila As DataRow) As e_ValorizacionNeumatico
        Try
            Dim oeValorizacionNeumatico = New e_ValorizacionNeumatico( _
                             o_fila("Id").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("ValorTotalDolares").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeValorizacionNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeValorizacionNeumatico As e_ValorizacionNeumatico) As e_ValorizacionNeumatico

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeValorizacionNeumatico.Id)
            If ds.Tables.Count > 0 Then
                oeValorizacionNeumatico = Cargar(ds.Tables(0).Rows(0))
                Return oeValorizacionNeumatico
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeValorizacionNeumatico As e_ValorizacionNeumatico) As List(Of e_ValorizacionNeumatico)
        Try
            Dim ldValorizacionNeumatico As New List(Of e_ValorizacionNeumatico)
            Dim ds As DataSet
            With oeValorizacionNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_ValorizacionNeumatico_Listar]", "" _
                        , .Id _
                        , .FechaInicio _
                        , .FechaFin _
                        , .ValorTotalDolares _
                        , .Glosa _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeValorizacionNeumatico = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeValorizacionNeumatico = Cargar(o_Fila)
                    ldValorizacionNeumatico.Add(oeValorizacionNeumatico)
                Next
            End If
            Return ldValorizacionNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeValorizacionNeumatico As e_ValorizacionNeumatico) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeValorizacionNeumatico
                    stResultado = sqlhelper.ExecuteScalar("NEU.Isp_ValorizacionNeumatico_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                            .Id _
                            , .Fecha _
                            , .ValorTotalDolares _
                            , .Glosa _
                            , .UsuarioCreacion _
                            , .Activo _
                        ).ToString.Split("_")

                    For Each Detalle As e_DetalleValorizacionNeumatico In .lstDetalleValorizacion
                        Detalle.IdValorizacion = stResultado(0)
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        odDetalleValorizacion.Guardar(Detalle)
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeValorizacionNeumatico As e_ValorizacionNeumatico) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeValorizacionNeumatico.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
