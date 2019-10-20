'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_IncidenciasAutentificadas

    Dim sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_IncidenciasAutentificadas
        Try
            Dim oeIncidenciasAutentificadas = New e_IncidenciasAutentificadas( _
                             o_fila("Id").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("IdActividadNegocio").ToString _
                             , o_fila("IdResponsableAutoriza").ToString _
                             , o_fila("IdUsuarioIncidente").ToString _
                             , o_fila("Referencia").ToString _
                             , o_fila("FechaReferencia").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Activo").ToString)
            Return oeIncidenciasAutentificadas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As e_IncidenciasAutentificadas
        Try
            Dim ds As DataSet
            With oeIncidenciasAutentificadas
                ds = sqlhelper.ExecuteDataset("[SGD].[Isp_IncidenciasAutentificadas_Listar]",
                                                "",
                                                .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeIncidenciasAutentificadas = Cargar(ds.Tables(0).Rows(0))
            Else
                oeIncidenciasAutentificadas = New e_IncidenciasAutentificadas
            End If
            Return oeIncidenciasAutentificadas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As List(Of e_IncidenciasAutentificadas)
        Try
            Dim ldIncidenciasAutentificadas As New List(Of e_IncidenciasAutentificadas)
            Dim ds As DataSet
            With oeIncidenciasAutentificadas
                ds = sqlhelper.ExecuteDataset("[SGD].[Isp_IncidenciasAutentificadas_Listar]", "" _
                                                , .Id _
                                                , .IdArea _
                                                , .IdActividadNegocio _
                                                , .IdResponsableAutoriza _
                                                , .IdUsuarioIncidente _
                                                , .Activo)
            End With
            oeIncidenciasAutentificadas = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeIncidenciasAutentificadas = Cargar(o_Fila)
                    ldIncidenciasAutentificadas.Add(oeIncidenciasAutentificadas)
                Next
            Else
                ldIncidenciasAutentificadas = New List(Of e_IncidenciasAutentificadas)
            End If
            Return ldIncidenciasAutentificadas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As Boolean
        Try
            With oeIncidenciasAutentificadas
                sqlhelper.ExecuteNonQuery("[SGD].[Isp_IncidenciasAutentificadas_IAE]",
                                          .TipoOperacion,
                                          .PrefijoID,
                                            .Id _
                                            , .IdArea _
                                            , .IdActividadNegocio _
                                            , .IdResponsableAutoriza _
                                            , .IdUsuarioIncidente _
                                            , .Referencia _
                                            , .FechaReferencia _
                                            , .Glosa _
                                            , .Activo _
                                            , .Indicador)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As Boolean
        Try
            With oeIncidenciasAutentificadas
                sqlhelper.ExecuteNonQuery("[SGD].[Isp_IncidenciasAutentificadas_IAE]",
                                        "E",
                                        "",
                                        .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
