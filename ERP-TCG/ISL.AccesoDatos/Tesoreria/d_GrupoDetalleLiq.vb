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

Public Class d_GrupoDetalleLiq

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_GrupoDetalleLiq
        Try
            Dim oeGrupoDetalleLiq = New e_GrupoDetalleLiq( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdGrupo").ToString _
                             , o_Fila("IdViaje").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeGrupoDetalleLiq
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGrupoDetalleLiq As e_GrupoDetalleLiq) As e_GrupoDetalleLiq

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoDetalleLiq_Listar", oeGrupoDetalleLiq.TipoOperacion, oeGrupoDetalleLiq.Id, oeGrupoDetalleLiq.IdGrupo, oeGrupoDetalleLiq.IdViaje)
            oeGrupoDetalleLiq = New e_GrupoDetalleLiq
            If ds.Tables(0).rows.Count > 0 Then
                oeGrupoDetalleLiq = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeGrupoDetalleLiq
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGrupoDetalleLiq As e_GrupoDetalleLiq) As List(Of e_GrupoDetalleLiq)
        Try
            Dim ldGrupoDetalleLiq As New List(Of e_GrupoDetalleLiq)
            Dim ds As DataSet
            With oeGrupoDetalleLiq
                ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoDetalleLiq_Listar", "" _
                        , .Id _
                        , .IdGrupo _
                        , .IdViaje _
                        , .Activo _
                        )
            End With
            oeGrupoDetalleLiq = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeGrupoDetalleLiq = Cargar(o_Fila)
                ldGrupoDetalleLiq.Add(oeGrupoDetalleLiq)
            Next
            Return ldGrupoDetalleLiq
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGrupoDetalleLiq As e_GrupoDetalleLiq) As Boolean
        Try
            With oeGrupoDetalleLiq
                sqlhelper.ExecuteNonQuery("TES.Isp_GrupoDetalleLiq_IAE", .TipoOperacion,
                        .Id _
                        , .IdGrupo _
                        , .IdViaje _
                        , .Activo _
                        , .PrefijoID _
                        , .Monto)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGrupoDetalleLiq As e_GrupoDetalleLiq) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_GrupoDetalleLiq_IAE", "E", oeGrupoDetalleLiq.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
