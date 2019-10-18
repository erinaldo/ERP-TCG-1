'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_SubFamiliaMaterial

    Private sqlhelper As New SqlHelper

    Private oeSubFamiliaMaterial As New e_SubFamiliaMaterial

    Public Function Cargar(ByVal fila As DataRow) As e_SubFamiliaMaterial
        Try
            Dim oeSubFamiliaMaterial = New e_SubFamiliaMaterial( _
                                                                fila("Id"), _
                                                                fila("Codigo"), _
                                                                fila("Nombre"), _
                                                                fila("Abreviatura"), _
                                                                fila("Activo"), _
                                                                fila("IdFamilia"), _
                                                                fila("Familia"))
            Return oeSubFamiliaMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As e_SubFamiliaMaterial
        Try
            Dim ds As DataSet
            With oeSubFamiliaMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_SubFamiliaMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeSubFamiliaMaterial = Cargar(ds.Tables(0).Rows(0))
            Else
                oeSubFamiliaMaterial = New e_SubFamiliaMaterial
            End If
            Return oeSubFamiliaMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As List(Of e_SubFamiliaMaterial)
        Try
            Dim ds As DataSet
            Dim lista As New List(Of e_SubFamiliaMaterial)
            With oeSubFamiliaMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_SubFamiliaMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo, _
                                              .IdFamilia)
                If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeSubFamiliaMaterial = Cargar(fila)
                        lista.Add(oeSubFamiliaMaterial)
                    Next
                End If
                Return lista
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As Boolean
        Try
            Dim odCtaCtblSubFam As New d_CtaCtbleSubFamiliaMat
            Dim id As String()
            With oeSubFamiliaMaterial
                id = sqlhelper.ExecuteScalar("ALM.Isp_SubFamiliaMaterial_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                          .Id,
                                          .Codigo,
                                          .Nombre,
                                          .Abreviatura,
                                          .Activo,
                                          .IdFamilia,
                                          .UsuarioCreacion).ToString.Split("_")
                For Each ctacble As e_CtaCtbleSubFamiliaMat In .loCtaCtbleSubFam
                    ctacble.IdSubFamilia = id(0)
                    ctacble.PrefijoID = oeSubFamiliaMaterial.PrefijoID '@0001
                    odCtaCtblSubFam.Guardar(ctacble)
                Next

            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As Boolean
        Try
            With oeSubFamiliaMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_SubFamiliaMaterial_IAE", _
                                          "E", _
                                          "", _
                                          .Id)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
