'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Public Class d_EstadoOrden
    Private sqlhelper As New SqlHelper

    Private oeEstadoOrden As New e_EstadoOrden

    Public Function Cargar(ByVal fila As DataRow) As e_EstadoOrden
        Try
            Dim oeEstadoOrden = New e_EstadoOrden(fila("Id"),
                                                  fila("Nombre"),
                                                  fila("Activo"))
            Return oeEstadoOrden
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEstadoOrden As e_EstadoOrden) As e_EstadoOrden
        Try
            Dim ds As New DataSet
            With oeEstadoOrden
                ds = sqlhelper.ExecuteDataset("ALM.Isp_EstadoOrden_Listar", _
                                              "", _
                                              .Id, _
                                              .Nombre)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeEstadoOrden = Cargar(ds.Tables(0).Rows(0))
            Else
                oeEstadoOrden = New e_EstadoOrden
            End If
            Return oeEstadoOrden
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeEstadoOrden As e_EstadoOrden) As List(Of e_EstadoOrden)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_EstadoOrden)
            With oeEstadoOrden
                ds = sqlhelper.ExecuteDataset("ALM.Isp_EstadoOrden_Listar",
                                              .TipoOperacion,
                                              .Id,
                                              .Nombre,
                                              .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeEstadoOrden = Cargar(fila)
                        lista.Add(oeEstadoOrden)
                    Next
                    '    Return lista
                    'Else
                    '    Return Nothing
                End If
                Return lista
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeEstadoOrden As e_EstadoOrden) As Boolean
        Try
            With oeEstadoOrden
                sqlhelper.ExecuteNonQuery("ALM.Isp_EstadoOrden_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                          .Id,
                                          .Nombre,
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeEstadoOrden As e_EstadoOrden) As Boolean
        Try
            With oeEstadoOrden
                sqlhelper.ExecuteNonQuery("ALM.Isp_EstadoOrden_IAE", _
                                          "E", _
                                          "", _
                                          .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
