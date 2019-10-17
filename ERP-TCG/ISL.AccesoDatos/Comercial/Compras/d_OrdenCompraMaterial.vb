'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions


Public Class d_OrdenCompraMaterial

    Private sqlhelper As New SqlHelper
    Private odOCMaterial_OSMaterial As New d_OCMaterial_OSMaterial

    Private Function Cargar(ByVal fila As DataRow) As e_OrdenCompraMaterial

        Try
            Dim oeOrdenMaterial = New e_OrdenCompraMaterial(
                                                      fila("Seleccion"),
                                                      fila("Id"),
                                                      fila("IdOrden"),
                                                      fila("IdMaterial"),
                                                      fila("Material"),
                                                      fila("CantidadMaterial"),
                                                      fila("CostoAdm"),
                                                      fila("CostoUnitario"),
                                                      fila("CambioMoneda"),
                                                      fila("PrecioTotal"),
                                                      fila("IdAlmacen"),
                                                      fila("Almacen"),
                                                      fila("CantidadMaterialPendiente"),
                                                      fila("IndicadorIgv"),
                                                      fila("Activo"),
                                                      fila("IdUnidadMedida"),
                                                      fila("UnidadMedida"),
                                                      fila("IdTipoUnidadMedida"),
                                                      fila("Porcentaje"),
                                                      fila("Glosa"),
                                                      fila("Notas"),
                                                      fila("CodigoRequerimiento"),
                                                      fila("IdArea"),
                                                      fila("Area"),
                                                      fila("CodigoMaterial"),
                                                      fila("IdRequerimientoMaterial"),
                                                      fila("TipoMoneda"),
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
            Dim id As String = ""
            With oeOrdenMaterial
                id = sqlhelper.ExecuteScalar("CMP.Isp_OrdenCompraMaterial_IAE",
                                         .TipoOperacion,
                                         .PrefijoID,
                                         .Id,
                                         .IdOrden,
                                         .IdMaterial,
                                         .CantidadMaterial,
                                         .CostoAdm,
                                         .CostoUnitario,
                                         .PrecioTotal,
                                         .IdSubAlmacen,
                                         .CantidadMaterialPendiente,
                                         .IndicadorIgv,
                                         .Activo,
                                         .IdUnidadMedida,
                                         .IdCentroCosto,
                                         .IdRequerimientoMaterial,
                                         .Glosa,
                                         .Notas,
                                         .IdArea,
                                         .IdOrdenSalidaMaterial)
                .Id = id
                For Each oe As e_OCMaterial_OSMaterial In .ListaOCMaterial_OSMaterial
                    oe.TipoOperacion = "I"
                    oe.IdOrden = id
                    oe.Activo = 1
                    oe.PrefijoID = oeOrdenMaterial.PrefijoID '@0001
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
