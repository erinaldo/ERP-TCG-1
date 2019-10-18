'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_TipoMovimientoInventario
    Private sqlhelper As New SqlHelper

    Private oeTipoMovimientoInventario As New e_TipoMovimientoInventario

    Public Function Cargar(ByVal fila As DataRow) As e_TipoMovimientoInventario
        Try
            oeTipoMovimientoInventario = New e_TipoMovimientoInventario( _
                                                                        fila("Id"), _
                                                                        fila("Codigo"), _
                                                                        fila("Nombre"), _
                                                                        fila("Abreviatura"), _
                                                                        fila("Activo"))
            Return oeTipoMovimientoInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As e_TipoMovimientoInventario
        Try
            Dim ds As New DataSet
            With oeTipoMovimientoInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoMovimientoInventario_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTipoMovimientoInventario = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTipoMovimientoInventario = New e_TipoMovimientoInventario
            End If
            Return oeTipoMovimientoInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As List(Of e_TipoMovimientoInventario)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_TipoMovimientoInventario)
            With oeTipoMovimientoInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoMovimientoInventario_Listar",
                                              "",
                                              .Id,
                                              .Codigo,
                                              .Nombre,
                                              .Abreviatura,
                                              .Activo)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeTipoMovimientoInventario = Cargar(fila)
                    lista.Add(oeTipoMovimientoInventario)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Guardar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As Boolean
        Try
            With oeTipoMovimientoInventario
                sqlhelper.ExecuteNonQuery("ALM.Isp_TipoMovimientoInventario_IAE",
                                          .TipoOperacion,
                                          .PrefijoID _
                                          , .Id,
                                          .Codigo,
                                          .Nombre,
                                          .Abreviatura,
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


    Public Function Eliminar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_TipoMovimientoInventario_IAE", _
                                      "E", _
                                      "", _
                                      oeTipoMovimientoInventario.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
End Class
