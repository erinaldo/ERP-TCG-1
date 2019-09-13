Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetallePreliminar

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetallePreliminar
        Try
            Dim oeDetallePreliminar = New e_DetallePreliminar( _
                             o_fila("Id").ToString _
                             , o_fila("IdPreliminarInspeccion").ToString _
                             , o_fila("IdOperacionNeu").ToString _
                             , o_fila("CodOpe").ToString _
                             , o_fila("Placa").ToString _
                             , o_fila("Motriz") _
                             , o_fila("CodNeu").ToString _
                             , o_fila("Marca").ToString _
                             , o_fila("Modelo").ToString _
                             , o_fila("Medida").ToString _
                             , o_fila("TipoBanda").ToString _
                             , o_fila("Posicion").ToString _
                             , o_fila("Cocada") _
                             , o_fila("Kilometraje") _
                             , o_fila("FechaOperacion").ToString _
                             , o_fila("CocadaMinima") _
                             , o_fila("IdMarcaR").ToString _
                             , o_fila("IdMedidaR").ToString _
                             , o_fila("IdDisenioPedido").ToString _
                             , o_fila("TipoBandaPedido").ToString _
                             , o_fila("Confirmado").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
                             , o_fila("IdVidaNeumatico").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("DOT").ToString _
                             , o_fila("Flota").ToString _
            )
            oeDetallePreliminar.TipoMedida = o_fila("TipoMedida").ToString
            Return oeDetallePreliminar
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetallePreliminar As e_DetallePreliminar) As e_DetallePreliminar

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("NEU.Isp_DetallePreliminar_Listar", oeDetallePreliminar.TipoOperacion, oeDetallePreliminar.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDetallePreliminar = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetallePreliminar
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetallePreliminar As e_DetallePreliminar) As List(Of e_DetallePreliminar)
        Try
            Dim ldDetallePreliminar As New List(Of e_DetallePreliminar)
            Dim ds As DataSet
            With oeDetallePreliminar
                ds = sqlhelper.ExecuteDataset("NEU.Isp_DetallePreliminar_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPreliminarInspeccion _
                        , .IdOperacionNeu _
                        , .IdDisenioPedido _
                        , .Confirmado _
                        , .Observacion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .Periodo _
                        )
            End With
            oeDetallePreliminar = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetallePreliminar = Cargar(o_Fila)
                ldDetallePreliminar.Add(oeDetallePreliminar)
            Next
            Return ldDetallePreliminar
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetallePreliminar As e_DetallePreliminar) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetallePreliminar
                sqlhelper.ExecuteNonQuery("NEU.Isp_DetallePreliminar_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdPreliminarInspeccion _
                        , .IdOperacionNeu _
                        , .IdDisenioPedido _
                        , .TipoBandaPedido _
                        , .Confirmado _
                        , .Observacion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetallePreliminar As e_DetallePreliminar) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("NEU.Isp_DetallePreliminar_IAE", "E", _
             "", oeDetallePreliminar.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
