'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_TipoUnidadMedida
    Private sqlhelper As New SqlHelper

    Private oeTipoUnidadMedida As New e_TipoUnidadMedida


    Public Function Cargar(ByVal fila As DataRow) As e_TipoUnidadMedida
        Try
            oeTipoUnidadMedida = New e_TipoUnidadMedida( _
                                                        fila("Id"), _
                                                        fila("Codigo"), _
                                                        fila("Nombre"), _
                                                        fila("Abreviatura"), _
                                                        fila("Activo"))
            Return oeTipoUnidadMedida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As e_TipoUnidadMedida
        Try
            Dim ds As New DataSet
            With oeTipoUnidadMedida
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoUnidadMedida_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTipoUnidadMedida = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTipoUnidadMedida = New e_TipoUnidadMedida
            End If
            Return oeTipoUnidadMedida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As List(Of e_TipoUnidadMedida)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_TipoUnidadMedida)
            With oeTipoUnidadMedida
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoUnidadMedida_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo)
            End With
            If ds.Tables.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeTipoUnidadMedida = Cargar(fila)
                    lista.Add(oeTipoUnidadMedida)
                Next
                '    Return lista
                'Else
                '    Return Nothing
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As Boolean
        Try
            With oeTipoUnidadMedida
                sqlhelper.ExecuteNonQuery("ALM.Isp_TipoUnidadMedida_IAE",
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


    Public Function Eliminar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_TipoUnidadMedida_IAE", _
                                      "E", _
                                      "", _
                                      oeTipoUnidadMedida.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
End Class
