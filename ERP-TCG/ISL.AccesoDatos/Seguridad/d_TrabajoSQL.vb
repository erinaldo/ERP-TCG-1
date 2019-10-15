'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_TrabajoSQL
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TrabajoSQL
        Try
            Dim oeTrabajoSQL = New e_TrabajoSQL( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Paso") _
                             , o_fila("Comando").ToString _
                             , o_fila("Habilitado") _
            )
            Return oeTrabajoSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTrabajoSQL As e_TrabajoSQL) As e_TrabajoSQL
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_Trabajo_Listar", oeTrabajoSQL.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTrabajoSQL = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTrabajoSQL
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTrabajoSQL As e_TrabajoSQL) As List(Of e_TrabajoSQL)
        Try
            Dim ldTrabajoSQL As New List(Of e_TrabajoSQL)
            Dim ds As DataSet
            With oeTrabajoSQL
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Trabajo_Listar", .Id, .Nombre)
            End With
            oeTrabajoSQL = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTrabajoSQL = Cargar(o_Fila)
                ldTrabajoSQL.Add(oeTrabajoSQL)
            Next
            Return ldTrabajoSQL
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTrabajoSQL As e_TrabajoSQL) As Boolean
        Try
            With oeTrabajoSQL
                sqlhelper.ExecuteNonQuery("SGD.Isp_Trabajo_IAE", .Id _
                        , .Comando, .Habilitado
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ListarProcedimiento(ByVal NombreProcedimiento As String) As DataTable
        Try
            Dim dt As DataTable = Nothing
            Dim ds As Data.DataSet = sqlhelper.ExecuteDataset("STD.Isp_Procedimiento_Listar", NombreProcedimiento)
            If ds.Tables.Count = 0 Then Throw New Exception("Información no regitrada")
            dt = ds.Tables(0)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
