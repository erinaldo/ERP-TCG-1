Imports ISL.EntidadesWCF

Public Class d_CotizacionDetalleMat
    Private sqlhelper As New SqlHelper

    Private oeCotizacionDetalle As e_CotizacionDetalleMat

    Private Function Cargar(ByVal o_fila As DataRow) As e_CotizacionDetalleMat
        Try
            Dim oeCotizacionDetalle = New e_CotizacionDetalleMat( _
                                 o_fila("Id"), _
                                 o_fila("Seleccion"), _
                                 o_fila("IdMaterial"), _
                                 o_fila("CodigoMaterial"), _
                                 o_fila("Material"), _
                                 o_fila("IdAlmacen"), _
                                 o_fila("Almacen"), _
                                 o_fila("IdUnidadMedida"), _
                                 o_fila("UnidadMedida"), _
                                 o_fila("Cantidad"), _
                                 o_fila("Activo"), _
                                 o_fila("UsuarioCreacion"), _
                                 o_fila("FechaCreacion"), _
                                 o_fila("IdTipoUnidadMedida"), _
                                 o_fila("Precio"), _
                                 o_fila("IdSubAlmacen"), _
                                 o_fila("IdCotizacionProveedor"), _
                                 o_fila("Glosa"))
            Return oeCotizacionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCotizacionDetalle As e_CotizacionDetalleMat) As e_CotizacionDetalleMat
        Try
            Dim ds As DataSet
            With oeCotizacionDetalle
                ds = sqlhelper.ExecuteDataset("CMP.Isp_CotizacionDetalleMat_Listar" _
                                             , .TipoOperacion _
                                             , .Id _
                                             , .IdCotizacionProveedor _
                                             , .Activo _
                                             , .UsuarioCreacion _
                                         )
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCotizacionDetalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCotizacionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCotizacionDetalle As e_CotizacionDetalleMat) As List(Of e_CotizacionDetalleMat)
        Try

            Dim ldTipoMantenimiento As New List(Of e_CotizacionDetalleMat)
            Dim ds As DataSet
            With oeCotizacionDetalle
                ds = sqlhelper.ExecuteDataset("CMP.Isp_CotizacionDetalleMat_Listar" _
                                          , .TipoOperacion _
                                          , .Id _
                                          , .IdCotizacionProveedor _
                                          , .Activo _
                                          , .UsuarioCreacion _
                                          , .FechaInicio _
                                          , .FechaFinal)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCotizacionDetalle = Cargar(o_Fila)
                    ldTipoMantenimiento.Add(oeCotizacionDetalle)
                Next
            End If
            Return ldTipoMantenimiento


        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCotizacionDetalle As e_CotizacionDetalleMat) As Boolean
        Dim d_DatosConfiguracion As New d_DatosConfiguracion
        Try
            With oeCotizacionDetalle
                sqlhelper.ExecuteNonQuery("CMP.Isp_CotizacionDetalleMat_IAE", .TipoOperacion, _
                                                                           d_DatosConfiguracion.PrefijoID, _
                                                                           .Id, _
                                                                           .IdCotizacionProveedor, _
                                                                           .IdRequerimientoMaterial, _
                                                                           .IdMaterial, _
                                                                           .IdSubAlmacen, _
                                                                           .IdUnidadMedida, _
                                                                           .Cantidad, _
                                                                           .Activo, _
                                                                           .UsuarioCreacion, _
                                                                           .Precio)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCotizacionDetalle As e_CotizacionDetalleMat) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.Isp_CotizacionDetalleMat_IAE", "E", "", oeCotizacionDetalle.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
