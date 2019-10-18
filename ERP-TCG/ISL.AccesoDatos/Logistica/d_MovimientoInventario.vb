'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_MovimientoInventario
    Private sqlhelper As New SqlHelper

    Public oeMovimientoInventario As New e_MovimientoInventario

    Public Function Cargar(ByVal fila As DataRow) As e_MovimientoInventario
        Try
            Dim oeMovimientoInventario = New e_MovimientoInventario( _
                                        fila("Seleccion"), _
                                        fila("Id"), _
                                        fila("Codigo"), _
                                        fila("Nombre"), _
                                        fila("Abreviatura"), _
                                        fila("Activo"), _
                                        fila("TipoMovimientoInventario"), _
                                        fila("IdTipoMovimientoInventario"), _
                                        fila("IndDevolucion"))
            Return oeMovimientoInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoInventario As e_MovimientoInventario) As e_MovimientoInventario
        Try
            Dim ds As DataSet
            With oeMovimientoInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_MovimientoInventario_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoInventario = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovimientoInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoInventario As e_MovimientoInventario) As List(Of e_MovimientoInventario)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_MovimientoInventario)
            With oeMovimientoInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_MovimientoInventario_Listar",
                                              .TipoOperacion,
                                              .Id,
                                              .Codigo,
                                              .Nombre,
                                              .Abreviatura,
                                              .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeMovimientoInventario = Cargar(fila)
                        lista.Add(oeMovimientoInventario)
                    Next
                End If
                Return lista
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoInventario As e_MovimientoInventario) As Boolean
        Try
            With oeMovimientoInventario
                sqlhelper.ExecuteNonQuery("ALM.Isp_MovimientoInventario_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                          .Id,
                                          .Codigo,
                                          .Nombre,
                                          .Abreviatura,
                                          .Activo,
                                          .IdTipoMovimientoInventario)
                Return True
            End With
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimientoInventario As e_MovimientoInventario) As Boolean
        Try
            With oeMovimientoInventario
                sqlhelper.ExecuteNonQuery("ALM.Isp_MovimientoInventario_IAE", _
                                          "E", _
                                          "", _
                                          .Id)
                Return True
            End With
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
End Class
