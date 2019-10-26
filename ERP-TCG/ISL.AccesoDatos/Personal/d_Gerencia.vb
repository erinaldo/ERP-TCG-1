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

Public Class d_Gerencia

    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Gerencia
        Try
            Dim oeGerencia = New e_Gerencia( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Activo") _
                             , o_fila("UsuarioCreacion").ToString _
            )
         
            Return oeGerencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGerencia As e_Gerencia) As e_Gerencia

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("PER.Isp_Gerencia_Listar", "", oeGerencia.Id)
            If ds.Tables.Count > 0 Then
                oeGerencia = Cargar(ds.Tables(0).Rows(0))
                Return oeGerencia
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGerencia As e_Gerencia) As List(Of e_Gerencia)
        Try
            Dim ldGerencia As New List(Of e_Gerencia)
            Dim ds As DataSet
            With oeGerencia
                ds = SqlHelper.ExecuteDataset("PER.Isp_Gerencia_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeGerencia = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGerencia = Cargar(o_Fila)
                    ldGerencia.Add(oeGerencia)
                Next
                Return ldGerencia
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGerencia As e_Gerencia) As Boolean
        Try
            With oeGerencia
                SqlHelper.ExecuteNonQuery("PER.Isp_Gerencia_IAE", .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGerencia As e_Gerencia) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("PER.Isp_Gerencia_IAE", "E", oeGerencia.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
