'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_TipoMaterial
    Private sqlhelper As New SqlHelper

    Private oeTipoMaterial As New e_TipoMaterial

    Public Function Cargar(ByVal fila As DataRow) As e_TipoMaterial
        Try
            Dim oetipomaterial = New e_TipoMaterial(fila("Id"), _
                                                    fila("Codigo"), _
                                                    fila("Nombre"), _
                                                    fila("Abreviatura"), _
                                                    fila("Activo"))
            Return oetipomaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoMaterial As e_TipoMaterial) As e_TipoMaterial
        Try
            Dim ds As New DataSet
            With oeTipoMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTipoMaterial = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTipoMaterial = New e_TipoMaterial
            End If
            Return oeTipoMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoMaterial As e_TipoMaterial) As List(Of e_TipoMaterial)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_TipoMaterial)
            With oeTipoMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeTipoMaterial = Cargar(fila)
                        lista.Add(oeTipoMaterial)
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

    Public Function Guardar(ByVal oeTipoMaterial As e_TipoMaterial) As Boolean
        Try
            With oeTipoMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_TipoMaterial_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                          .Id,
                                          .Codigo,
                                          .Nombre,
                                          .Abreviatura,
                                          .Activo,
                                          .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoMaterial As e_TipoMaterial) As Boolean
        Try
            With oeTipoMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_TipoMaterial_IAE", _
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
