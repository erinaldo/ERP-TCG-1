﻿'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions

Public Class d_OrdenCompraServicio

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal fila As DataRow) As e_OrdenCompraServicio


        Try
            Dim oeOrdenServicio = New e_OrdenCompraServicio( _
                                                      fila("Seleccion"), _
                                                      fila("Id"), _
                                                      fila("IdOrden"), _
                                                      fila("IdServicio"), _
                                                      fila("Servicio"), _
                                                      fila("Cantidad"), _
                                                      fila("PrecioUnitario"), _
                                                      fila("CambioMoneda"), _
                                                      fila("ValorVenta"), _
                                                      fila("IndicadorIgv"), _
                                                      fila("Activo"), _
                                                      fila("Porcentaje"), _
                                                      fila("Glosa"), _
                                                       fila("Notas"), _
                                                      fila("CodigoRequerimiento"), _
                                                      fila("IdArea"), _
                                                      fila("Area"), _
                                                      fila("CodigoServicio"), _
                                                      fila("IdRequerimientoServicio"), _
                                                      fila("TipoMoneda"), _
                                                      fila("IdEquipo"))
            Return oeOrdenServicio
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Obtener(ByVal oeOrdenServicio As e_OrdenCompraServicio) As e_OrdenCompraServicio
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.ISP_OrdenCompraServicio_Listar", _
                                          oeOrdenServicio.TipoOperacion, _
                                          oeOrdenServicio.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeOrdenServicio = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrdenServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenServicio As e_OrdenCompraServicio) As List(Of e_OrdenCompraServicio)
        Try
            Dim cont As Integer = 0
            Dim lista As New List(Of e_OrdenCompraServicio)
            Dim ds As DataSet
            With oeOrdenServicio
                ds = sqlhelper.ExecuteDataset("CMP.ISP_OrdenCompraServicio_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdOrden, _
                                              .IdServicio, _
                                              .Activo _
                                              )
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeOrdenServicio = Cargar(fila)
                    cont += 1 : oeOrdenServicio.Pos = cont
                    lista.Add(oeOrdenServicio)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenServicio As e_OrdenCompraServicio) As Boolean
        Try
            With oeOrdenServicio
                sqlhelper.ExecuteNonQuery("CMP.ISP_OrdenCompraServicio_IAE",
                                         .TipoOperacion,
                                         .PrefijoID,
                                         .Id,
                                         .IdOrden,
                                         .IdServicio,
                                         .Cantidad,
                                         .PrecioUnitarioConImp,
                                         .ValorVenta,
                                         .IndicadorIgv,
                                         .Activo,
                                         .IdCentroCosto,
                                         .Glosa,
                                         .Notas,
                                         .IdArea,
                                         .IdRequerimientoServicio,
                                         .IdEquipo
                                         )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Eliminar(ByVal oeOrdenServicio As e_OrdenCompraServicio) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.ISP_OrdenCompraServicio_IAE", _
                                      "E", _
                                      "", _
                                      oeOrdenServicio.Id, _
                                      oeOrdenServicio.IdOrden)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function



End Class
