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

Public Class d_AreaTipoEvento
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AreaTipoEvento
        Try
            Dim oeAreaTipoEvento = New e_AreaTipoEvento()
            oeAreaTipoEvento.Id = o_fila("Id").ToString
            oeAreaTipoEvento.Codigo = o_fila("Codigo").ToString
            oeAreaTipoEvento.IdTipoEvento = o_fila("IdTipoEvento").ToString
            oeAreaTipoEvento.TipoEvento = o_fila("TipoEvento").ToString
            oeAreaTipoEvento.IdTipo = o_fila("IdTipo").ToString
            oeAreaTipoEvento.Tipo = o_fila("Tipo").ToString
            oeAreaTipoEvento.IdArea = o_fila("IdArea").ToString
            oeAreaTipoEvento.Area = o_fila("Area").ToString
            oeAreaTipoEvento.Glosa = o_fila("Glosa").ToString
            oeAreaTipoEvento.FechaCreacion = o_fila("FechaCreacion").ToString
            oeAreaTipoEvento.UsuarioCreacion = o_fila("UsuarioCreacion").ToString
            oeAreaTipoEvento.Activo = o_fila("Activo").ToString
            oeAreaTipoEvento.FechaModifica = o_fila("FechaModifica").ToString
            oeAreaTipoEvento.UsuarioModifica = o_fila("UsuarioModifica").ToString
            Return oeAreaTipoEvento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As e_AreaTipoEvento
        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SPC.Isp_AreaTipoEvento_Listar", "", oeAreaTipoEvento.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeAreaTipoEvento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAreaTipoEvento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As List(Of e_AreaTipoEvento)
        Try
            Dim ldAreaTipoEvento As New List(Of e_AreaTipoEvento)
            Dim ds As DataSet
            With oeAreaTipoEvento
                ds = SqlHelper.ExecuteDataset("SPC.Isp_AreaTipoEvento_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .IdTipoEvento _
                        , .IdTipo _
                        , .IdArea _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .UsuarioModifica _
                        )
            End With
            oeAreaTipoEvento = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAreaTipoEvento = Cargar(o_Fila)
                ldAreaTipoEvento.Add(oeAreaTipoEvento)
            Next
            Return ldAreaTipoEvento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As Boolean
        Try
            Dim stResultado() As String
            With oeAreaTipoEvento
                stResultado = sqlhelper.ExecuteScalar("SPC.Isp_AreaTipoEvento_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .Codigo _
                        , .IdTipoEvento _
                        , .IdTipo _
                        , .IdArea _
                        , .Glosa _
                        , .UsuarioCreacion _
                    ).ToString.Split("_")

            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_AreaTipoEvento_IAE", oeAreaTipoEvento.TipoOperacion, _
             "", oeAreaTipoEvento.Id, "", oeAreaTipoEvento.IdTipoEvento, oeAreaTipoEvento.IdTipo, "", "", oeAreaTipoEvento.UsuarioCreacion)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
