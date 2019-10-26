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

Public Class d_Incidencia
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_Incidencia
        Try
            Dim oed_Incidencia = New e_Incidencia( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Codigo2").ToString _
                             , o_fila("NroIncidencia").ToString _
                             , o_fila("IdTipoIncidencia").ToString _
                             , o_fila("IdGradoIncidencia").ToString _
                             , o_fila("IdOperacion").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("IdPiloto").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("IdUbicacion").ToString _
                             , o_fila("Prioridad").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("EstadoIncidencia").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("UsuarioModifica").ToString _
            )
            Return oed_Incidencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oed_Incidencia As e_Incidencia) As e_Incidencia

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SPC.Isp_Incidencia_Listar", "", oed_Incidencia.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oed_Incidencia = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oed_Incidencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oed_Incidencia As e_Incidencia) As List(Of e_Incidencia)
        Try
            Dim ldd_Incidencia As New List(Of e_Incidencia)
            Dim ds As DataSet
            With oed_Incidencia
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Incidencia_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Codigo2 _
                        , .NroIncidencia _
                        , .IdTipoIncidencia _
                        , .IdGradoIncidencia _
                        , .IdOperacion _
                        , .IdViaje _
                        , .IdPiloto _
                        , .Fecha _
                        , .Descripcion _
                        , .IdUbicacion _
                        , .IdPrioridad _
                        , .IdCliente _
                        , .EstadoIncidencia _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        )
            End With
            oed_Incidencia = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oed_Incidencia = Cargar(o_Fila)
                ldd_Incidencia.Add(oed_Incidencia)
            Next
            Return ldd_Incidencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oed_Incidencia As e_Incidencia) As Boolean
        Try
            With oed_Incidencia
                sqlhelper.ExecuteNonQuery("SPC.Isp_Incidencia_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .Codigo2 _
                        , .NroIncidencia _
                        , .IdTipoIncidencia _
                        , .IdGradoIncidencia _
                        , .IdOperacion _
                        , .IdViaje _
                        , .IdPiloto _
                        , .Fecha _
                        , .Descripcion _
                        , .IdUbicacion _
                        , .IdPrioridad _
                        , .IdCliente _
                        , .EstadoIncidencia _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .FechaModifica _
                        , .UsuarioModifica
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oed_Incidencia As e_Incidencia) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("SPC.Isp_Incidencia_IAE", "E", _
             "", oed_Incidencia.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
