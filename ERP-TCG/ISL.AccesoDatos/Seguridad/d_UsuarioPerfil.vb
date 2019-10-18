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

Public Class d_UsuarioPerfil

    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_UsuarioPerfil
        Try
            Dim oeUsuarioPerfil = New e_UsuarioPerfil( _
                             o_fila("Id").ToString _
                             , o_fila("IdUsuario").ToString _
                             , o_fila("IdPerfil").ToString _
                             , o_fila("Perfil") _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Principal") _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeUsuarioPerfil
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As e_UsuarioPerfil
        Try
            Dim ds As DataSet
            With oeUsuarioPerfil
                ds = SqlHelper.ExecuteDataset("SGD.Isp_UsuarioPerfil_Listar", .TipoOperacion _
                                                , .Id _
                                                , .oeUsuario.Id _
                                                , .oePerfil.Id _
                                                , .Descripcion _
                                                , .Principal)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeUsuarioPerfil = Cargar(ds.Tables(0).Rows(0))
            Else
                oeUsuarioPerfil = New e_UsuarioPerfil
            End If
            Return oeUsuarioPerfil
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As List(Of e_UsuarioPerfil)
        Try
            Dim ldUsuarioPerfil As New List(Of e_UsuarioPerfil)
            Dim ds As DataSet
            With oeUsuarioPerfil
                ds = SqlHelper.ExecuteDataset("SGD.Isp_UsuarioPerfil_Listar", "" _
                        , .Id _
                        , .oeUsuario.Id _
                        , .oePerfil.Id _
                        , .Descripcion _
                        , .Principal _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeUsuarioPerfil = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeUsuarioPerfil = Cargar(o_Fila)
                    ldUsuarioPerfil.Add(oeUsuarioPerfil)
                Next
                Return ldUsuarioPerfil
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTodo(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As List(Of e_UsuarioPerfil)
        Try
            Dim ldUsuarioPerfil As New List(Of e_UsuarioPerfil)
            Dim ds As DataSet
            With oeUsuarioPerfil
                ds = SqlHelper.ExecuteDataset("SGD.Isp_UsuarioPerfil_Listar", "" _
                        , .Id _
                        , .oeUsuario.Id _
                        , .oePerfil.Id _
                        , .Descripcion _
                        )
            End With
            oeUsuarioPerfil = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeUsuarioPerfil = Cargar(o_Fila)
                    ldUsuarioPerfil.Add(oeUsuarioPerfil)
                Next
            End If
            Return ldUsuarioPerfil
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As Boolean
        Try
            With oeUsuarioPerfil
                SqlHelper.ExecuteNonQuery("SGD.Isp_UsuarioPerfil_IAE", .TipoOperacion _
                        , .Id _
                        , .oeUsuario.Id _
                        , .oePerfil.Id _
                        , .Descripcion _
                        , .Principal _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .PrefijoID _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeUsuarioPerfil As e_UsuarioPerfil) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("SGD.Isp_UsuarioPerfil_IAE", "E", oeUsuarioPerfil.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
