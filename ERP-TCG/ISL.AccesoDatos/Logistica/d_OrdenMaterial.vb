'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Data.SqlClient
Imports System.Transactions

Public Class d_OrdenMaterial
    Private sqlhelper As New SqlHelper
    Dim odCtrlEntrMat As New d_ControlEntregaMaterial

    Private Function Cargar(ByVal fila As DataRow) As e_OrdenMaterial
        Try
            Dim oeOrdenMaterial = New e_OrdenMaterial(
                                                      fila("Seleccion"),
                                                      fila("Id"),
                                                      fila("IdOrden"),
                                                      fila("NroOrden"),
                                                      fila("IdMaterial"),
                                                      fila("Material"),
                                                      fila("CantidadMaterial"),
                                                      fila("CostoAdm"),
                                                      fila("PrecioUnitario"),
                                                      fila("ValorVenta"),
                                                      fila("IdSubAlmacen"),
                                                      fila("IdAlmacen"),
                                                      fila("Almacen"),
                                                      fila("IndicadorIgv"),
                                                      fila("Activo"),
                                                      fila("IdUnidadMedida"),
                                                      fila("UnidadMedida"),
                                                      fila("IdTipoUnidadMedida"),
                                                      fila("CodigoMaterial"),
                                                      fila("Ubicacion"))

            Return oeOrdenMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar2(ByVal fila As DataRow) As e_OrdenMaterial
        Try
            Dim oeOrdenMaterial = New e_OrdenMaterial(
                                                      fila("Seleccion"),
                                                      fila("Id"),
                                                      fila("IdOrden"),
                                                      fila("NroOrden"),
                                                      fila("IdMaterial"),
                                                      fila("Material"),
                                                      fila("CantidadMaterial"),
                                                      fila("CostoAdm"),
                                                      fila("PrecioUnitario"),
                                                      fila("ValorVenta"),
                                                      fila("IdSubAlmacen"),
                                                      fila("IdAlmacen"),
                                                      fila("Almacen"),
                                                      fila("IndicadorIgv"),
                                                      fila("Activo"),
                                                      fila("IdUnidadMedida"),
                                                      fila("UnidadMedida"),
                                                      fila("IdTipoUnidadMedida"),
                                                      fila("CodigoMaterial"),
                                                      fila("Ubicacion"))

            oeOrdenMaterial.IdReferencia = fila("IdReferencia")
            oeOrdenMaterial.TipoReferencia = fila("TipoReferencia")

            Return oeOrdenMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarOSNeumaticos(ByVal fila As DataRow) As e_OrdenMaterial
        Try
            Dim oeOrdenMaterial = New e_OrdenMaterial(fila("IdOrden"), _
                                                      fila("NroOrden"), _
                                                      fila("FechaOrden"), _
                                                      fila("EstadoOrden"), _
                                                        fila("IdMaterial"), _
                                                       fila("Material"), _
                                                      fila("CantidadMaterial"), _
                                                      fila("IdUnidadMedida"), _
                                                      fila("UnidadMedida"), _
                                                      fila("PrecioUnitario") _
                                                      )
            Return oeOrdenMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenMaterial As e_OrdenMaterial) As e_OrdenMaterial
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_OrdenMaterial_Listar", oeOrdenMaterial.TipoOperacion, _
                                          oeOrdenMaterial.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeOrdenMaterial = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrdenMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenMaterial As e_OrdenMaterial) As List(Of e_OrdenMaterial)
        Try
            Dim lista As New List(Of e_OrdenMaterial)
            Dim ds As DataSet
            With oeOrdenMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_OrdenMaterial_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdOrden, _
                                              .IdMaterial, _
                                              .CantidadMaterial, _
                                              .PrecioUnitario, _
                                              .ValorVenta, _
                                              .IdAlmacen, _
                                              .IndicadorIgv, _
                                              .IdReferencia, _
                                              .TipoReferencia)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    If oeOrdenMaterial.TipoOperacion = "L" Then
                        oeOrdenMaterial = Cargar2(fila)
                    Else
                        oeOrdenMaterial = Cargar(fila)
                    End If
                    lista.Add(oeOrdenMaterial)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDS(ByVal oeOrdenMaterial As e_OrdenMaterial) As Data.DataSet
        Try
            Dim ds As DataSet
            With oeOrdenMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_OrdenMaterial_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdOrden, _
                                              .IdMaterial, _
                                              .CantidadMaterial, _
                                              .PrecioUnitario, _
                                              .ValorVenta, _
                                              .IdAlmacen, _
                                              .IndicadorIgv, _
                                              .IdReferencia, _
                                              .TipoReferencia, _
                                              "", _
                                              .Activo, _
                                              .FechaInicio, _
                                              .FechaFin, _
                                              .IdTipoOrden, _
                                              .IdEstadoOrden)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarOSNeumaticos(ByVal oeOrdenMaterial As e_OrdenMaterial) As List(Of e_OrdenMaterial)
        Try
            Dim lista As New List(Of e_OrdenMaterial)
            Dim ds As DataSet
            With oeOrdenMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_OrdenMaterial_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdOrden, _
                                              .IdMaterial, _
                                              .CantidadMaterial, _
                                              .PrecioUnitario, _
                                              .ValorVenta, _
                                              .IdAlmacen, _
                                              .IndicadorIgv, _
                                              .IdReferencia, _
                                              .TipoReferencia, _
                                              "", _
                                              True, _
                                              .FechaInicio, _
                                              .FechaFin _
                                              )

   
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeOrdenMaterial = CargarOSNeumaticos(fila)
                    lista.Add(oeOrdenMaterial)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Listado de ordenes de salida para generar ordenes de compra por consignación
    Public Function ListarParaOCC(ByVal oeOrdenMaterial As e_OrdenMaterial) As DataSet
        Try
            Dim ds As DataSet
            With oeOrdenMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_OrdenMaterial_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdOrden, _
                                              .IdMaterial, _
                                              .CantidadMaterial, _
                                              .PrecioUnitario, _
                                              .ValorVenta, _
                                              .IdAlmacen, _
                                              .IndicadorIgv, _
                                              .IdReferencia, _
                                              .TipoReferencia, _
                                              "", _
                                              .Activo, _
                                              .FechaInicio, _
                                              .FechaFin, _
                                              .IdTipoOrden, _
                                              .IdEstadoOrden)
            End With
            Return ActualizaDS(ds)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDetalle(ByVal oeOrdenMaterial As e_OrdenMaterial) As List(Of e_OrdenMaterial)
        Try
            Dim loOrdenMaterial As New List(Of e_OrdenMaterial)
            Dim ds As DataSet
            With oeOrdenMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_OrdenMaterial_Listar", _
                                                    .TipoOperacion, _
                                                    .Id)

            End With
            oeOrdenMaterial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenMaterial = Cargar(o_Fila)
                    loOrdenMaterial.Add(oeOrdenMaterial)
                Next
            End If
            Return loOrdenMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizaDS(ByVal ds As DataSet) As DataSet
        Try
            For Each Row As DataRow In ds.Tables(1).Rows
                Row("ValorVenta") = Row("CantidadMaterial") * Row("PrecioUnitario")
            Next
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenMaterial As e_OrdenMaterial) As Boolean
        Try
            Dim stResultado() As String
            With oeOrdenMaterial
                stResultado = sqlhelper.ExecuteScalar("ALM.Isp_OrdenMaterial_IAE",
                                         .TipoOperacion,
                                         .PrefijoID,
                                         .Id,
                                         .IdOrden,
                                         .IdMaterial,
                                         .CantidadMaterial,
                                         .IdUnidadMedida,
                                         .CostoAdm,
                                         .PrecioUnitario,
                                         .ValorVenta,
                                         .IndicadorIgv,
                                         .IdSubAlmacen,
                                         .IdReferencia,
                                         .Activo,
                                         .UsuarioCreacion,
                                         .IdRequerimientoMaterial,
                                         .IdAlmacen,
                                         .TipoReferencia).ToString.Split("_")
                .Id = stResultado(0).ToString

                If .oeControlEntregaMat.CantidadEntregada > 0 Then
                    .oeControlEntregaMat.IdOrdenMaterialIngreso = .Id
                    .oeControlEntregaMat.PrefijoID = oeOrdenMaterial.PrefijoID '@0001
                    odCtrlEntrMat.Guardar(.oeControlEntregaMat)
                End If

                If .loControlEntregaMaterial.Count > 0 AndAlso .TipoOperacion = "D" Then
                    For Each control As e_ControlEntregaMaterial In .loControlEntregaMaterial
                        control.TipoOperacion = "I"
                        control.IdOrdenMaterialSalida = stResultado(0)
                        control.PrefijoID = oeOrdenMaterial.PrefijoID '@0001
                        odCtrlEntrMat.Guardar(control)
                    Next
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenMaterial As e_OrdenMaterial) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_OrdenMaterial_IAE", _
                                      "E", _
                                      "", _
                                      oeOrdenMaterial.IdOrden)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
