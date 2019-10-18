'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================


Imports ISL.EntidadesWCF

Public Class d_MovimientoInventarioAlmacen
    Private sqlhelper As New SqlHelper

    Private oeMovimientoInventarioAlmacen As New e_MovimientoInventarioAlmacen


    Public Function Cargar(ByVal fila As DataRow) As e_MovimientoInventarioAlmacen
        Try

            Dim oeMovimientoInventarioAlmacen = New e_MovimientoInventarioAlmacen( _
                                                                              fila("Seleccion"), _
                                                                              fila("Id"), _
                                                                              fila("IdCentro"), _
                                                                              fila("Centro"), _
                                                                              fila("IdAlmacen"), _
                                                                              fila("Almacen"), _
                                                                              fila("IdMovimientoInventario"), _
                                                                              fila("MovimientoInventario"), _
                                                                              fila("Activo"))
            Return oeMovimientoInventarioAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As e_MovimientoInventarioAlmacen
        Try
            Dim ds As New DataSet
            With oeMovimientoInventarioAlmacen
                ds = sqlhelper.ExecuteDataset("ALM.Isp_MovimientoInventarioAlmacen_Listar1", _
                                              .TipoOperacion, _
                                              .Id)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoInventarioAlmacen = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovimientoInventarioAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDetalle(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As Boolean

        Try
            With oeMovimientoInventarioAlmacen
                sqlhelper.ExecuteNonQuery("[ALM].[Isp_MovimientoInventarioAlmacen_IAE]", _
                                          "I", _
                                          .PrefijoID, _
                                          .Id, _
                                          .IdAlmacen, _
                                          .IdMovimientoInventario, _
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As List(Of e_MovimientoInventarioAlmacen)
        Try
            Dim ds As DataSet
            Dim lista As New List(Of e_MovimientoInventarioAlmacen)
            With oeMovimientoInventarioAlmacen
                ds = sqlhelper.ExecuteDataset("ALM.Isp_MovimientoInventarioAlmacen_Listar1", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdAlmacen, _
                                              .IdMovimientoInventario, _
                                              .Activo)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeMovimientoInventarioAlmacen = Cargar(fila)
                    lista.Add(oeMovimientoInventarioAlmacen)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal listaObj As List(Of e_MovimientoInventarioAlmacen)) As Boolean
        Try

            For Each Detalle As e_MovimientoInventarioAlmacen In listaObj
                GuardarDetalle(Detalle)
            Next

            Return True

        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


    Public Function Eliminar(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_MovimientoInventarioAlmacen_IAE", _
                                      "E", _
                                      "", _
                                      oeMovimientoInventarioAlmacen.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As Boolean
        Try

            With oeMovimientoInventarioAlmacen
                sqlhelper.ExecuteNonQuery("ALM.Isp_MovimientoInventarioAlmacen_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                          .Id,
                                          .IdAlmacen,
                                          .IdMovimientoInventario,
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class


