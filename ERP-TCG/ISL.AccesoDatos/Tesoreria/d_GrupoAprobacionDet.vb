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

Public Class d_GrupoAprobacionDet
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_GrupoAprobacionDet
        Try
            Dim oeGrupoAprobacionDet = New e_GrupoAprobacionDet( _
                             o_fila("Id").ToString _
                             , o_fila("IdGrupoAprobacion").ToString _
                             , o_fila("IdGrupo").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Codigo").ToString)
            Return oeGrupoAprobacionDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As e_GrupoAprobacionDet

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeGrupoAprobacionDet.Id)
            If ds.Tables.Count > 0 Then
                oeGrupoAprobacionDet = Cargar(ds.Tables(0).Rows(0))
                Return oeGrupoAprobacionDet
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As List(Of e_GrupoAprobacionDet)
        Try
            Dim ldGrupoAprobacionDet As New List(Of e_GrupoAprobacionDet)
            Dim ds As DataSet
            With oeGrupoAprobacionDet
                ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoAprobacionDet_Listar", .TipoOperacion _
                        , .Id _
                        , .IdGrupoAprobacion _
                        , .IdGrupo _
                        , .Glosa _
                        , .Importe)
            End With
            oeGrupoAprobacionDet = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGrupoAprobacionDet = Cargar(o_Fila)
                    ldGrupoAprobacionDet.Add(oeGrupoAprobacionDet)
                Next
                Return ldGrupoAprobacionDet
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As Boolean
        Try
            With oeGrupoAprobacionDet
                sqlhelper.ExecuteNonQuery("TES.Isp_GrupoAprobacionDet_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdGrupoAprobacion _
                        , .IdGrupo _
                        , .Glosa _
                        , .Importe _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeGrupoAprobacionDet.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
