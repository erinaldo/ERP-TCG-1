'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF


Public Class d_SituacionAdministrativa
    Private oeSituacionAdministrativa As New e_SituacionAdministrativa
    Private sqlhelper As New SqlHelper


    Private Function Cargar(ByVal o_fila As DataRow) As e_SituacionAdministrativa
        Try
            Dim oeSituacionAdministrativa = New e_SituacionAdministrativa( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Remunerado").ToString _
                             , o_fila("AcumulaVacaciones").ToString _
                             , o_fila("CodigoPlame").ToString _
                             , o_fila("IndTipo") _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeSituacionAdministrativa
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As e_SituacionAdministrativa
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_SituacionAdministrativa_Listar", "", oeSituacionAdministrativa.Id, oeSituacionAdministrativa.Codigo, oeSituacionAdministrativa.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeSituacionAdministrativa = Cargar(ds.Tables(0).Rows(0))
            Else
                oeSituacionAdministrativa = New e_SituacionAdministrativa
            End If
            Return oeSituacionAdministrativa
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal id As String) As e_SituacionAdministrativa
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_SituacionAdministrativa_Listar", "", oeSituacionAdministrativa.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeSituacionAdministrativa = Cargar(ds.Tables(0).Rows(0))
            Else
                oeSituacionAdministrativa = New e_SituacionAdministrativa
            End If
            Return oeSituacionAdministrativa
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Listar(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As List(Of e_SituacionAdministrativa)
        Try
            Dim ldSituacionAdministrativa As New List(Of e_SituacionAdministrativa)
            Dim ds As DataSet
            With oeSituacionAdministrativa
                ds = sqlhelper.ExecuteDataset("PER.Isp_SituacionAdministrativa_Listar", "" _
                                        , .Id _
                                        , .Codigo _
                                        , .Nombre _
                                        , .Abreviatura _
                                         , .Activo)

                If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeSituacionAdministrativa = Cargar(fila)
                        ldSituacionAdministrativa.Add(oeSituacionAdministrativa)
                    Next
                End If
            End With
            Return ldSituacionAdministrativa

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Guardar(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As Boolean
        Try
            With oeSituacionAdministrativa
                sqlhelper.ExecuteNonQuery("PER.Isp_SituacionAdministrativa_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                        .Id _
                                        , .Codigo _
                                        , .Nombre _
                                        , .Abreviatura _
                                        , .Remunerado _
                                        , .AcumulaVacaciones _
                                        , .CodigoPlame _
                                        , .IndTipo _
                                        , .UsuarioCreacion _
                                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_SituacionAdministrativa_IAE", _
                                      "E", _
                                        "", _
                                        oeSituacionAdministrativa.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

