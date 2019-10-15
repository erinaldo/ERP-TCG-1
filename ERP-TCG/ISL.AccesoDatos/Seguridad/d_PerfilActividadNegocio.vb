'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient


Public Class d_PerfilActividadNegocio

    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_PerfilActividadNegocio
        Try
            Dim oePerfilActividadNegocio = New e_PerfilActividadNegocio( _
                             o_fila("Id").ToString _
                             , o_fila("IdPerfil").ToString _
                             , o_fila("Perfil").ToString _
                             , o_fila("IdProcesoNegocio").ToString _
                             , o_fila("ProcesoNegocio").ToString _
                             , o_fila("IdActividadNegocio").ToString _
                             , o_fila("ActividadNegocio").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oePerfilActividadNegocio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePerfilActividadNegocio As e_PerfilActividadNegocio) As e_PerfilActividadNegocio
        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SGD.Isp_PerfilActividadNegocio_Listar", "", oePerfilActividadNegocio.Id)
            If ds.Tables.Count > 0 Then
                oePerfilActividadNegocio = Cargar(ds.Tables(0).Rows(0))
                Return oePerfilActividadNegocio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePerfilActividadNegocio As e_PerfilActividadNegocio) As List(Of e_PerfilActividadNegocio)
        Try
            Dim ldPerfilActividadNegocio As New List(Of e_PerfilActividadNegocio)
            Dim ds As DataSet
            With oePerfilActividadNegocio
                ds = SqlHelper.ExecuteDataset("SGD.Isp_PerfilActividadNegocio_Listar", "" _
                        , .Id _
                        , .IdPerfil _
                        , .IdActividadNegocio _
                        , .Descripcion _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oePerfilActividadNegocio = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oePerfilActividadNegocio = Cargar(o_Fila)
                    ldPerfilActividadNegocio.Add(oePerfilActividadNegocio)
                Next
                Return ldPerfilActividadNegocio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTodos(ByVal oePerfilActividadNegocio As e_PerfilActividadNegocio) As List(Of e_PerfilActividadNegocio)
        Try
            Dim ldPerfilActividadNegocio As New List(Of e_PerfilActividadNegocio)
            Dim ds As DataSet
            With oePerfilActividadNegocio
                ds = SqlHelper.ExecuteDataset("SGD.Isp_PerfilActividadNegocio_Listar", "" _
                        , .Id _
                        , .IdPerfil _
                        , .IdActividadNegocio _
                        )
            End With
            oePerfilActividadNegocio = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oePerfilActividadNegocio = Cargar(o_Fila)
                    ldPerfilActividadNegocio.Add(oePerfilActividadNegocio)
                Next
            End If
            Return ldPerfilActividadNegocio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oePerfilActividadNegocio As e_PerfilActividadNegocio) As Boolean
        Try
            With oePerfilActividadNegocio
                SqlHelper.ExecuteNonQuery("SGD.ISP_PerfilActividadNegocio_IAE", .TipoOperacion _
                        , .Id _
                        , .IdPerfil _
                        , .IdActividadNegocio _
                        , .Descripcion _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .UsuarioModifica _
                        , .PrefijoID _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oePerfilActividadNegocio As e_PerfilActividadNegocio) As Boolean
        Try
            With oePerfilActividadNegocio
                SqlHelper.ExecuteNonQuery("SGD.Isp_PerfilActividadNegocio_IAE", "E", _
            .Id, "", "", "", False, .UsuarioCreacion, .UsuarioModifica)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
