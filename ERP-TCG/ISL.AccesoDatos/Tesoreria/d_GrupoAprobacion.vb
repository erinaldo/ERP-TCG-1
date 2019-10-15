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

Public Class d_GrupoAprobacion
    Private sqlhelper As New SqlHelper

    Dim odGrupoAprobacionDet As New d_GrupoAprobacionDet
    Dim odChequeEmitido As New d_ChequeEmitido

    Private Function Cargar(ByVal o_fila As DataRow) As e_GrupoAprobacion
        Try
            Dim oeGrupoAprobacion = New e_GrupoAprobacion( _
                             o_fila("Id").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("IdCheque").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("FechaAprobacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdTrabajadorAprobacion").ToString _
                             , o_fila("TrabajadorAprobacion").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("GlosaGrupo").ToString _
                             , o_fila("CodigoGrupo").ToString _
                             , o_fila("CuentaBancaria").ToString _
                             , o_fila("ImporteTotal").ToString _
                             , o_fila("NroCheque").ToString)
            Return oeGrupoAprobacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As e_GrupoAprobacion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoAprobacion_Listar", oeGrupoAprobacion.TipoOperacion, oeGrupoAprobacion.Id)
            If ds.Tables.Count > 0 Then
                oeGrupoAprobacion = Cargar(ds.Tables(0).Rows(0))
                Return oeGrupoAprobacion
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As System.Data.DataSet
        Try
            Dim ldGrupoAprobacion As New List(Of e_GrupoAprobacion)
            Dim ds As DataSet
            With oeGrupoAprobacion
                ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoAprobacion_Listar", .TipoOperacion, "", Date.Parse("01/01/1901"), Date.Parse("01/01/1901"), .IdTrabajadorAprobacion)
            End With
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDetalle(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As List(Of e_GrupoAprobacion)
        Try

            Dim ldGrupoAprobacion As New List(Of e_GrupoAprobacion)
            Dim ds As DataSet
            With oeGrupoAprobacion
                ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoAprobacion_Listar", .TipoOperacion, .Id, .Fecha, .FechaCreacion, .IdTrabajadorAprobacion)
            End With
            oeGrupoAprobacion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGrupoAprobacion = Cargar(o_Fila)
                    ldGrupoAprobacion.Add(oeGrupoAprobacion)
                Next
            End If
            Return ldGrupoAprobacion

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As Boolean
        Try
            Dim id As String = ""
            Using TransScope As New TransactionScope()
                With oeGrupoAprobacion
                    If .oeChequeEmitido IsNot Nothing Then
                        .oeChequeEmitido.PrefijoID = oeGrupoAprobacion.PrefijoID '@0001
                        odChequeEmitido.Guardar(.oeChequeEmitido)
                        id = sqlhelper.ExecuteScalar("TES.Isp_GrupoAprobacion_IAE", .TipoOperacion, .PrefijoID,
                                .Id _
                                , .Glosa _
                                , .oeChequeEmitido.Id _
                                , .Importe _
                                , .Activo _
                                , .Fecha _
                                , .FechaCreacion _
                                , .FechaAprobacion _
                                , .UsuarioCreacion _
                                , .IdTrabajadorAprobacion _
                                , .IdEstado)
                        .Id = id
                        For Each det As e_GrupoAprobacionDet In .loListaGrupoAprobacionDet
                            If det.TipoOperacion <> "I" Then det.TipoOperacion = .TipoOperacion
                            det.IdGrupoAprobacion = id
                            det.PrefijoID = oeGrupoAprobacion.PrefijoID '@0001
                            odGrupoAprobacionDet.Guardar(det)
                        Next
                    End If

                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_GrupoAprobacion_IAE", "E", _
             "", oeGrupoAprobacion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
