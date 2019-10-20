'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF


Public Class d_TipoOrden
    Private sqlhelper As New SqlHelper

    Private oeTipoOrden As New e_TipoOrden


    Public Function Cargar(ByVal fila As DataRow) As e_TipoOrden
        Try
            Dim oeTipoOrden = New e_TipoOrden(fila("Id"), _
                                                    fila("Codigo"), _
                                                    fila("Nombre"), _
                                                    fila("Abreviatura"), _
                                                    fila("Activo"))
            Return oeTipoOrden
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oeTipoOrden As e_TipoOrden) As e_TipoOrden
        Try
            Dim ds As New DataSet
            With oeTipoOrden
                ds = sqlhelper.ExecuteDataset("STD.Isp_TipoOrden_Listar", "", .Id, .Codigo, .Nombre, .Abreviatura)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTipoOrden = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoOrden
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Listar(ByVal oeTipoOrden As e_TipoOrden) As List(Of e_TipoOrden)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_TipoOrden)
            With oeTipoOrden
                ds = sqlhelper.ExecuteDataset("STD.Isp_TipoOrden_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeTipoOrden = Cargar(fila)
                        lista.Add(oeTipoOrden)
                    Next
                End If
                Return lista
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Guardar(ByVal oeTipoOrden As e_TipoOrden) As Boolean
        Try
            With oeTipoOrden
                sqlhelper.ExecuteNonQuery("STD.Isp_TipoOrden_IAE",
                                          .TipOoperacion,
                                          .PrefijoID,
                                          .Id,
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


    Public Function Eliminar(ByVal oeTipoOrden As e_TipoOrden) As Boolean
        Try
            With oeTipoOrden
                sqlhelper.ExecuteNonQuery("STD.Isp_TipoOrden_IAE", _
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
