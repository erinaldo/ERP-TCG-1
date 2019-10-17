'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_CotizacionDetalleSer
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CotizacionDetalleSer
        Try
            Dim oeCotizacionDetalleSer = New e_CotizacionDetalleSer(o_fila("Id").ToString _
                             , o_fila("IdRequerimientoServicio").ToString _
                             , o_fila("IdServicio").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("Precio").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Servicio").ToString _
                             , o_fila("CodigoServicio").ToString _
                             , o_fila("IdCotizacionProveedor").ToString _
                             , o_fila("Glosa").ToString)
            Return oeCotizacionDetalleSer
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCotizacionDetalleSer As e_CotizacionDetalleSer) As e_CotizacionDetalleSer
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_CotizacionDetalleSer_Listar", oeCotizacionDetalleSer.TipoOperacion, oeCotizacionDetalleSer.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeCotizacionDetalleSer = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCotizacionDetalleSer
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCotizacionDetalleSer As e_CotizacionDetalleSer) As List(Of e_CotizacionDetalleSer)
        Try
            Dim ldCotizacionDetalleSer As New List(Of e_CotizacionDetalleSer)
            Dim ds As DataSet
            With oeCotizacionDetalleSer
                ds = sqlhelper.ExecuteDataset("CMP.Isp_CotizacionDetalleSer_Listar", .TipoOperacion _
                        , .Id _
                        , .IdCotizacionProveedor _
                        , .IdRequerimientoServicio _
                        , .IdServicio)
            End With
            oeCotizacionDetalleSer = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCotizacionDetalleSer = Cargar(o_Fila)
                ldCotizacionDetalleSer.Add(oeCotizacionDetalleSer)
            Next
            Return ldCotizacionDetalleSer
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCotizacionDetalleSer As e_CotizacionDetalleSer) As Boolean
        Try
            With oeCotizacionDetalleSer
                sqlhelper.ExecuteNonQuery("CMP.Isp_CotizacionDetalleSer_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdCotizacionProveedor _
                        , .IdRequerimientoServicio _
                        , .IdServicio _
                        , .Cantidad _
                        , .Precio _
                        , .Glosa _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeCotizacionDetalleSer As e_CotizacionDetalleSer) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.Isp_CotizacionDetalleSer_IAE", "E", "", oeCotizacionDetalleSer.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
