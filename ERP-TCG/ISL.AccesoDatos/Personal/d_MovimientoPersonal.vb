'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_MovimientoPersonal

    Private oeMovimientoPersonal As New e_MovimientoPersonal
    Private sqlhelper As New SqlHelper


    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoPersonal
        Try
            Dim oeMovimientoPersonal = New e_MovimientoPersonal( _
                 o_fila("Id").ToString _
                 , o_fila("IdTrabajador").ToString _
                 , o_fila("ApellidoPaterno").ToString _
                 , o_fila("ApellidoMaterno").ToString _
                 , o_fila("Nombre").ToString _
                 , o_fila("FechaInicio").ToString _
                 , o_fila("Dias").ToString _
                 , o_fila("FechaFin").ToString _
                 , o_fila("Retorno").ToString _
                 , o_fila("FechaRetorno").ToString _
                 , o_fila("IdSituacionAdministrativa").ToString _
                 , o_fila("Situacion").ToString _
                 , o_fila("Observacion").ToString _
                 , o_fila("Activo").ToString _
                 , o_fila("FechaCreacion").ToString _
                 , o_fila("UsuarioCreacion").ToString _
)
            If Not IsDate(o_fila("FechaRetorno")) Then
                oeMovimientoPersonal.FechaRetorno = Date.Now
            End If
            Return oeMovimientoPersonal
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As e_MovimientoPersonal
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_MovimientoPersonal_Listar", "", oeMovimientoPersonal.Id, oeMovimientoPersonal.IdTrabajador, oeMovimientoPersonal.IdSituacionAdministrativa, oeMovimientoPersonal.Activo)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoPersonal = Cargar(ds.Tables(0).Rows(0))
            Else
                oeMovimientoPersonal = New e_MovimientoPersonal
            End If
            Return oeMovimientoPersonal
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Listar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As List(Of e_MovimientoPersonal)
        Try
            Dim ldMovimientoPersonal As New List(Of e_MovimientoPersonal)
            Dim ds As DataSet
            With oeMovimientoPersonal
                ds = sqlhelper.ExecuteDataset("PER.Isp_MovimientoPersonal_Listar", "" _
                                        , .Id _
                                        , .IdTrabajador _
                                        , .IdSituacionAdministrativa _
                                        , .Activo _
                                        , .Retorno _
                                       , .FechaDesde, _
                                        .FechaHasta)

                If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeMovimientoPersonal = Cargar(fila)
                        ldMovimientoPersonal.Add(oeMovimientoPersonal)
                    Next
                End If
            End With
            Return ldMovimientoPersonal

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As Boolean
        Try

            With oeMovimientoPersonal
                sqlhelper.ExecuteNonQuery("PER.Isp_MovimientoPersonal_IAE", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                        .Id _
                                        , .IdTrabajador _
                                        , .IdSituacionAdministrativa _
                                        , .FechaInicio _
                                        , .NroDias _
                                        , .FechaFin _
                                        , .Retorno _
                                        , .FechaRetorno _
                                        , .Observacion _
                                        , .UsuarioCreacion _
                                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


    Public Function Eliminar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_MovimientoPersonal_IAE", _
                                      "E", _
                                        "", _
                                        oeMovimientoPersonal.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

