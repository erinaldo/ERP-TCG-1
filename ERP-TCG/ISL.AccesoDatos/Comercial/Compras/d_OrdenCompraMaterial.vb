Imports ISL.EntidadesWCF
Imports System.Transactions


Public Class d_OrdenCompraMaterial

    Private sqlhelper As New SqlHelper
    Private odOCMaterial_OSMaterial As New d_OCMaterial_OSMaterial

    Private Function Cargar(ByVal fila As DataRow) As e_OrdenCompraMaterial

        Try
            Dim oeOrdenMaterial = New e_OrdenCompraMaterial( _
                                                      fila("Seleccion"), _
                                                      fila("Id"), _
                                                      fila("IdOrden"), _
                                                      fila("IdMaterial"), _
                                                      fila("Material"), _
                                                      fila("CantidadMaterial"), _
                                                      fila("CostoUnitario"), _
                                                      fila("CambioMoneda"), _
                                                      fila("PrecioTotal"), _
                                                      fila("IdAlmacen"), _
                                                      fila("Almacen"), _
                                                      fila("CantidadMaterialPendiente"), _
                                                      fila("IndicadorIgv"), _
                                                      fila("Activo"), _
                                                      fila("IdUnidadMedida"), _
                                                      fila("UnidadMedida"), _
                                                      fila("IdTipoUnidadMedida"), _
                                                      fila("Porcentaje"), _
                                                      fila("Glosa"), _
                                                      fila("Notas"), _
                                                      fila("CodigoRequerimiento"), _
                                                      fila("IdArea"), _
                                                      fila("Area"), _
                                                      fila("CodigoMaterial"), _
                                                      fila("IdRequerimientoMaterial"), _
                                                      fila("TipoMoneda"), _
                                                      fila("IdSubAlmacen"))
            Return oeOrdenMaterial
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Obtener(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As e_OrdenCompraMaterial
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_OrdenCompraMaterial_Listar", _
                                          oeOrdenMaterial.TipoOperacion, _
                                          oeOrdenMaterial.Id)
            oeOrdenMaterial = New e_OrdenCompraMaterial
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeOrdenMaterial = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrdenMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As List(Of e_OrdenCompraMaterial)
        Try
            Dim cont As Integer = 0
            Dim lista As New List(Of e_OrdenCompraMaterial)
            Dim ds As DataSet
            With oeOrdenMaterial
                ds = sqlhelper.ExecuteDataset("CMP.Isp_OrdenCompraMaterial_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdOrden, _
                                              .Activo, _
                                              .IdMaterial, _
                                              .IdAlmacen)
            End With
            If ds.Tables.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeOrdenMaterial = Cargar(fila)
                    cont += 1 : oeOrdenMaterial.Pos = cont
                    lista.Add(oeOrdenMaterial)
                Next
            End If
            Return lista

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ListarHistorial(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As DataSet
        Try
            Dim cont As Integer = 0
            Dim lista As New List(Of e_OrdenCompraMaterial)
            Dim ds As DataSet
            With oeOrdenMaterial
                ds = sqlhelper.ExecuteDataset("CMP.Isp_OrdenCompraMaterial_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdOrden, _
                                              .Activo, _
                                              .IdMaterial)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Guardar(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String = ""
            With oeOrdenMaterial
                id = sqlhelper.ExecuteScalar("CMP.Isp_OrdenCompraMaterial_IAE", _
                                         .TipoOperacion, _
                                         .PrefijoID, _
                                         .Id, _
                                         .IdOrden, _
                                         .IdMaterial, _
                                         .CantidadMaterial, _
                                         .CostoUnitario, _
                                         .PrecioTotal, _
                                         .IdSubAlmacen, _
                                         .CantidadMaterialPendiente, _
                                         .IndicadorIgv, _
                                         .Activo, _
                                         .IdUnidadMedida, _
                                         .IdCentroCosto, _
                                         .IdRequerimientoMaterial, _
                                         .Glosa, _
                                         .Notas, _
                                         .IdArea, _
                                         .IdOrdenSalidaMaterial)
                .Id = id
                For Each oe As e_OCMaterial_OSMaterial In .ListaOCMaterial_OSMaterial
                    oe.TipoOperacion = "I"
                    oe.IdOrden = id
                    oe.Activo = 1
                    odOCMaterial_OSMaterial.Guardar(oe)
                Next
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


    Public Function Eliminar(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.Isp_OrdenCompraMaterial_IAE", _
                                      "E", _
                                      "", _
                                      oeOrdenMaterial.Id, _
                                      oeOrdenMaterial.IdOrden)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function



End Class
