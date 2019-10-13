'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_ZonaCombustible

    Private sqlhelper As New SqlHelper

    Public Function Cargar(ByVal o_fila As DataRow) As e_ZonaCombustible
        Try
            Dim oeZonaCombustible = New e_ZonaCombustible( _
                          o_fila("Id").ToString _
                         , o_fila("IdRuta").ToString _
                         , o_fila("IdOrigenRuta").ToString _
                         , o_fila("IdDestinoRuta").ToString _
                         , o_fila("OrigenRuta").ToString _
                         , o_fila("DestinoRuta").ToString _
                         , o_fila("KilometrosRuta").ToString _
                         , o_fila("IdFlota").ToString _
                         , o_fila("Orden").ToString _
                         , o_fila("IdOrigen").ToString _
                         , o_fila("IdDestino").ToString _
                         , o_fila("Origen").ToString _
                         , o_fila("Destino").ToString _
                         , o_fila("Kilometros").ToString _
                         , o_fila("Activo").ToString _
                         , o_fila("UsuarioCreacion").ToString _
                         , o_fila("UsuarioModifica").ToString _
            )
            Return oeZonaCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeZonaCombustible As e_ZonaCombustible) As e_ZonaCombustible
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[OPE].[Isp_ZonaCombustible_Listar]",
                                        oeZonaCombustible.TipoOperacion,
                                        oeZonaCombustible.Id,
                                        oeZonaCombustible.IdRuta,
                                        oeZonaCombustible.IdFlota
                                        )
            If ds.Tables(0).Rows.Count > 0 Then
                oeZonaCombustible = Cargar(ds.Tables(0).Rows(0))
            Else
                oeZonaCombustible = New e_ZonaCombustible
            End If
            Return oeZonaCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeZonaCombustible As e_ZonaCombustible) As List(Of e_ZonaCombustible)
        Try
            Dim leZonaCombustible As New List(Of e_ZonaCombustible)
            Dim ds As DataSet
            With oeZonaCombustible
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_ZonaCombustible_Listar]", _
                                                       oeZonaCombustible.TipoOperacion, _
                                                       oeZonaCombustible.Id, _
                                                       oeZonaCombustible.IdRuta, _
                                                       oeZonaCombustible.IdFlota _
                                                       )
            End With
            oeZonaCombustible = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeZonaCombustible = Cargar(o_Fila)
                    leZonaCombustible.Add(oeZonaCombustible)
                Next
            Else
                leZonaCombustible = New List(Of e_ZonaCombustible)
            End If
            Return leZonaCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeZonaCombustible As e_ZonaCombustible) As Boolean
        Try
            With oeZonaCombustible
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_ZonaCombustible_IAE]",
                                         .TipoOperacion,
                                          .PrefijoID,
                                        .Id _
                                        , .IdRuta _
                                        , .IdFlota _
                                        , .Orden _
                                        , .IdOrigen _
                                        , .IdDestino _
                                        , .Activo _
                                        , .UsuarioCreacion _
                                        , .UsuarioModifica
                                        )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeZonaCombustible As e_ZonaCombustible) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_ZonaCombustible_IAE]",
                                        "E" _
                                        , oeZonaCombustible.PrefijoID _
                                        , oeZonaCombustible.Id _
                                        , "" _
                                        , "" _
                                        , 0 _
                                        , "" _
                                        , "" _
                                        , 0 _
                                        , oeZonaCombustible.UsuarioCreacion _
                                        , oeZonaCombustible.UsuarioModifica
                                        )
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
