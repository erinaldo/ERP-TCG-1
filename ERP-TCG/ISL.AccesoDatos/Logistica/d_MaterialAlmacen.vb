'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_MaterialAlmacen


    Private sqlhelper As New SqlHelper


    Private Function Cargar(ByVal fila As DataRow) As e_MaterialAlmacen
        Try

            Dim oeMaterialAlmacen = New e_MaterialAlmacen(fila("Id") _
                                                          , fila("idMaterial") _
                                                          , fila("idAlmacen") _
                                                          , fila("UsuarioCreacion") _
                                                          , fila("FechaCreacion") _
                                                          , fila("Activo"))
            
            Return oeMaterialAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarMaterial(ByVal fila As DataRow) As e_Material
        Try

            Dim oeMaterial = New e_Material(fila("Seleccion"), _
                                            fila("Id"), _
                                            fila("Codigo"), _
                                            fila("Nombre"), _
                                            fila("NombreUnidadMedida"), _
                                            fila("NombreSubFamilia"), _
                                            fila("Activo"))

            Return oeMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar_(ByVal fila As DataRow) As e_MaterialAlmacen
        Try

            Dim oeMaterialAlmacen = New e_MaterialAlmacen(fila("Seleccion") _
                                                          , fila("Id") _
                                                          , fila("IdMaterial") _
                                                          , fila("CodigoMaterial") _
                                                          , fila("Material") _
                                                          , fila("NombreUnidadMedida") _
                                                          , fila("IdZona") _
                                                          , fila("Zona") _
                                                          , fila("StockActual") _
                                                          , fila("CostoUnitario") _
                                                          , fila("StockMinimo") _
                                                          , fila("StockMaximo") _
                                                          , fila("IdAlmacen") _
                                                          , fila("Almacen") _
                                                          , fila("Activo"))
            Return oeMaterialAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As e_MaterialAlmacen
        Try
            Dim oeMaterial As New e_Material
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[ALM].[Isp_Material_Almacen_Listar]", _
                                     "1", _
                                     "", _
                                     oeMaterialAlmacen.Id, _
                                     oeMaterialAlmacen.IdMaterial, _
                                     oeMaterialAlmacen.IdAlmacen, _
                                     oeMaterialAlmacen.Activo)

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMaterialAlmacen = Cargar(ds.Tables(0).Rows(0))
            Else
                oeMaterialAlmacen = New e_MaterialAlmacen
            End If
            Return oeMaterialAlmacen

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarDetalle(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As Boolean
        Try
            With oeMaterialAlmacen
                sqlhelper.ExecuteNonQuery("[ALM].[Isp_Material_Almacen_IAE]", .TipoOperacion,
                                          .PrefijoID,
                                          .Id,
                                          .IdMaterial,
                                          .IdAlmacen,
                                          .UsuarioCreacion,
                                          .Activo,
                                          .StockMinimo,
                                          .StockMaximo,
                                          .IdZona,
                                          .IdUnidad,
                                          .TipoReferencia)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Guardar(ByVal listaObj As List(Of e_MaterialAlmacen)) As Boolean
        Try
            For Each Detalle As e_MaterialAlmacen In listaObj
                GuardarDetalle(Detalle)
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As List(Of e_Material)
        Try
            Dim olMaterial As New List(Of e_Material)
            Dim oeMaterial As New e_Material
            Dim ds As DataSet

            ds = sqlhelper.ExecuteDataset("[ALM].[Isp_Material_Almacen_Listar]", _
                                            "2", _
                                            "", _
                                            oeMaterialAlmacen.Id, _
                                            oeMaterialAlmacen.IdMaterial, _
                                            oeMaterialAlmacen.IdAlmacen, _
                                            oeMaterialAlmacen.Activo)
            If ds.Tables.Count > 0 Then

                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMaterial = CargarMaterial(o_Fila)
                    olMaterial.Add(oeMaterial)
                Next

            End If
            Return olMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar_(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As List(Of e_MaterialAlmacen)
        'Listado Principal Material_Almacen
        Try
            Dim olMaterialAlmacen As New List(Of e_MaterialAlmacen)
            Dim ds As DataSet
            With oeMaterialAlmacen
                ds = sqlhelper.ExecuteDataset("[ALM].[Isp_Material_Almacen_Listar]", _
                                                .TipoOperacion, _
                                                "", _
                                                .Id, _
                                                .IdMaterial, _
                                                .IdAlmacen, _
                                                .Activo)
            End With
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMaterialAlmacen = Cargar_(o_Fila)
                    olMaterialAlmacen.Add(oeMaterialAlmacen)
                Next

            End If
            Return olMaterialAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal llMaterialAlmacen As List(Of e_MaterialAlmacen)) As Boolean
        Try

            For Each oeMaterialAlmacen As e_MaterialAlmacen In llMaterialAlmacen

                With oeMaterialAlmacen
                    sqlhelper.ExecuteNonQuery("[ALM].[Isp_Material_Almacen_IAE]", "E",
                                              .PrefijoID,
                                              .Id,
                                              .IdMaterial,
                                              .IdAlmacen,
                                              .UsuarioCreacion,
                                              .Activo)
                End With

            Next

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal oeMaterialAlmacen As e_MaterialAlmacen)
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_MaterialAlmacen In ListarAL(oeMaterialAlmacen)
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.IdAlmacen
                newRow("Nombre") = item.Almacen
                ds.Rows.Add(newRow)
            Next
            'If ds.Rows.Count = 0 Then Throw New Exception("Información no registrada")
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarAL(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As List(Of e_MaterialAlmacen)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_MaterialAlmacen)
            With oeMaterialAlmacen
                ds = sqlhelper.ExecuteDataset("[ALM].[Isp_Material_Almacen_Listar]",
                                         oeMaterialAlmacen.TipoOperacion,
                                         oeMaterialAlmacen.IdCentro,
                                         oeMaterialAlmacen.Id,
                                         oeMaterialAlmacen.IdMaterial,
                                         oeMaterialAlmacen.IdAlmacen,
                                         oeMaterialAlmacen.Activo)
            End With
            If ds.Tables.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeMaterialAlmacen = CargarMaterial1(fila)
                    lista.Add(oeMaterialAlmacen)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarMaterial1(ByVal fila As DataRow) As e_MaterialAlmacen
        Try
            Dim oeMaterialAlmacen = New e_MaterialAlmacen(fila("Id"), _
                                                          fila("IdAlmacen"), _
                                                          fila("Almacen"), _
                                                          fila("IdMaterial"), _
                                                          fila("Activo"))
            Return oeMaterialAlmacen

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarMaterialAlmacen(ByVal fila As DataRow) As e_Material
        Try

            Dim oeMaterial = New e_Material(fila("Seleccion"), _
                                          fila("IdMaterial"), _
                                          fila("Codigo"), _
                                          fila("Material"), _
                                          fila("IdUnidadMedida"), _
                                          fila("UnidadMedida"), _
                                          fila("IdSubAlmacen"), _
                                          fila("SubAlmacen"), _
                                          fila("IdAlmacen"), _
                                          fila("Almacen"), _
                                          fila("Precio"), _
                                          fila("Stock"), _
                                          fila("IdTipoUnidadMedida"), _
                                          fila("TipoUnidadMedida"))

            Return oeMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarMateriales(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As List(Of e_Material)
        Try
            Dim olMaterial As New List(Of e_Material)
            Dim oeMaterial As New e_Material
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[ALM].[Isp_Material_Almacen_Listar]", _
                                            oeMaterialAlmacen.TipoOperacion, _
                                            "", _
                                            oeMaterialAlmacen.Id, _
                                            oeMaterialAlmacen.IdMaterial, _
                                            oeMaterialAlmacen.IdAlmacen, _
                                            oeMaterialAlmacen.Activo, _
                                            "", "", oeMaterialAlmacen.IdSubAlmacen)
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMaterial = CargarMaterialAlmacen(o_Fila)
                    olMaterial.Add(oeMaterial)
                Next
            End If
            Return olMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarAlmMat(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As DataSet
        Try
            'Dim olMaterial As New List(Of e_Material)
            'Dim oeMaterial As New e_Material
            Dim ds As DataSet
            With oeMaterialAlmacen
                ds = sqlhelper.ExecuteDataset("[ALM].[Isp_Material_Almacen_Listar]", _
                                                .TipoOperacion, _
                                                "", "", "", "", 1, .IdsMateriales, .IdsAlmacenes)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
