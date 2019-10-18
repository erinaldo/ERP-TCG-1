'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_OrdenVentaMaterial

    Dim sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenVentaMaterial
            Try
                Dim oeOrdenComercial_Material = New e_OrdenVentaMaterial(
                                 o_fila("Id").ToString _
                                 , o_fila("IdOrdenComercial").ToString _
                                 , o_fila("IdSubAlmacen").ToString _
                                 , o_fila("IdAlmacen").ToString _
                                 , o_fila("IdMaterial").ToString _
                                 , o_fila("Codigo").ToString _
                                 , o_fila("Material").ToString _
                                 , o_fila("IdUnidadMedida").ToString _
                                 , o_fila("IdTipoUnidadMedida").ToString _
                                 , o_fila("Glosa").ToString _
                                 , o_fila("Cantidad").ToString _
                                 , o_fila("CantidadPendiente").ToString _
                                 , o_fila("CantidadReal").ToString _
                                 , o_fila("CostoUnitario").ToString _
                                 , o_fila("CostoInventario").ToString _
                                 , o_fila("PDscto").ToString _
                                 , o_fila("Dscto").ToString _
                                 , o_fila("PrecioTotal").ToString _
                                 , o_fila("IndImpuesto").ToString _
                                 , o_fila("UsuarioCrea").ToString _
                                 , o_fila("FechaCrea").ToString _
                                 , o_fila("UsuarioModifica").ToString _
                                 , o_fila("FechaModifica").ToString _
                                 , o_fila("Activo").ToString _
                                 , o_fila("IndOperacion").ToString _
                                 , o_fila("IdOrigen").ToString _
                                 , o_fila("IdDestino").ToString)
                Return oeOrdenComercial_Material
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function ExecuteLST(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As DataSet
            Try
                Dim ds As DataSet
                With oeOrdenComercial_Material
                ds = sqlhelper.ExecuteDataset("[CMP].[Isp_OrdenVenta_Material_Listar]" _
                            , .TipoOperacion _
                            , .Id _
                            , .IdOrdenComercial _
                            , .IdSubAlmacen)
            End With
                Return ds
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Obtener(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As e_OrdenVentaMaterial
            Try
                Dim ds As DataSet = ExecuteLST(oeOrdenComercial_Material)
                If ds.Tables(0).Rows.Count > 0 Then
                    oeOrdenComercial_Material = Cargar(ds.Tables(0).Rows(0))
                End If
                Return oeOrdenComercial_Material
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Listar(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As List(Of e_OrdenVentaMaterial)
            Try
                Dim ldOrdenComercial_Material As New List(Of e_OrdenVentaMaterial)
                Dim ds As DataSet = ExecuteLST(oeOrdenComercial_Material)
                oeOrdenComercial_Material = Nothing
                If ds.Tables.Count > 0 Then
                    For Each o_Fila As DataRow In ds.Tables(0).Rows
                        oeOrdenComercial_Material = Cargar(o_Fila)
                        ldOrdenComercial_Material.Add(oeOrdenComercial_Material)
                    Next
                End If
                Return ldOrdenComercial_Material
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Guardar(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As Boolean
            Try
                Dim stResultado() As String
                With oeOrdenComercial_Material
                stResultado = sqlhelper.ExecuteScalar("[CMP].[Isp_OrdenVenta_Material_IAE]" _
                            , .TipoOperacion _
                            , .PrefijoID _
                            , .Id _
                            , .IdEmpresaSis _
                            , .IdSucursal _
                            , .IdOrdenComercial _
                            , .IdSubAlmacen _
                            , .IdMaterial _
                            , .IdUnidadMedida _
                            , .Glosa _
                            , .Cantidad _
                            , .CantidadPendiente _
                            , .CantidadReal _
                            , .CostoUnitario _
                            , .CostoInventario _
                            , .PDscto _
                            , .Dscto _
                            , .PrecioTotal _
                            , .IndImpuesto _
                            , .UsuarioCrea _
                            , .IndOperacion _
                            , .IdOrigen _
                            , .IdDestino
                            ).ToString.Split("_")
                .Id = stResultado(0)
                End With
                Return True
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Eliminar(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As Boolean
            Try
                With oeOrdenComercial_Material
                sqlhelper.ExecuteNonQuery("[CMP].[Isp_OrdenVenta_Material_IAE]" _
                           , "E" _
                           , "" _
                           , .Id)
            End With
                Return True
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

