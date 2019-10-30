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

Public Class d_UsuarioSucursal

    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_UsuarioSucursal
        Try
            Dim oeUsuarioSucursal = New e_UsuarioSucursal(
                             o_fila("Id").ToString _
                             , o_fila("IdUsuario").ToString _
                             , o_fila("IdCentro").ToString _
                             , o_fila("Sucursal") _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Principal") _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString
            )
            Return oeUsuarioSucursal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As e_UsuarioSucursal
        Try
            Dim ds As DataSet
            With oeUsuarioSucursal
                ds = SqlHelper.ExecuteDataset("SGD.Isp_UsuarioSucursal_Listar", .TipoOperacion _
                                                , .Id _
                                                , .oeUsuario.Id _
                                                , .oeCentro.Id _
                                                , .Descripcion _
                                                , .Principal)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeUsuarioSucursal = Cargar(ds.Tables(0).Rows(0))
            Else
                oeUsuarioSucursal = New e_UsuarioSucursal
            End If
            Return oeUsuarioSucursal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As List(Of e_UsuarioSucursal)
        Try
            Dim ldUsuarioSucursal As New List(Of e_UsuarioSucursal)
            Dim ds As DataSet
            With oeUsuarioSucursal
                ds = SqlHelper.ExecuteDataset("SGD.Isp_UsuarioSucursal_Listar", "" _
                        , .Id _
                        , .oeUsuario.Id _
                        , .oeCentro.Id _
                        , .Descripcion _
                        , .Principal _
                        , .Activo _
                        , .UsuarioCreacion
                        )
            End With
            oeUsuarioSucursal = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeUsuarioSucursal = Cargar(o_Fila)
                    ldUsuarioSucursal.Add(oeUsuarioSucursal)
                Next
                Return ldUsuarioSucursal
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTodo(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As List(Of e_UsuarioSucursal)
        Try
            Dim ldUsuarioSucursal As New List(Of e_UsuarioSucursal)
            Dim ds As DataSet
            With oeUsuarioSucursal
                ds = SqlHelper.ExecuteDataset("SGD.Isp_UsuarioSucursal_Listar", "" _
                        , .Id _
                        , .oeUsuario.Id _
                        , .oeCentro.Id _
                        , .Descripcion
                        )
            End With
            oeUsuarioSucursal = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeUsuarioSucursal = Cargar(o_Fila)
                    ldUsuarioSucursal.Add(oeUsuarioSucursal)
                Next
            End If
            Return ldUsuarioSucursal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As Boolean
        Try
            With oeUsuarioSucursal
                SqlHelper.ExecuteNonQuery("SGD.Isp_UsuarioSucursal_IAE", .TipoOperacion _
                        , .Id _
                        , .oeUsuario.Id _
                        , .oeCentro.Id _
                        , .Descripcion _
                        , .Principal _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("SGD.Isp_UsuarioSucursal_IAE", "E", oeUsuarioSucursal.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

