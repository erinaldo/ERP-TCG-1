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

Public Class d_ProcesoTipoDocumento
    Private oeProcesoTipoDocumento As e_ProcesoTipoDocumento
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ProcesoTipoDocumento
        Try
            Dim oeProcesoTipoDocumento = New e_ProcesoTipoDocumento(o_fila("Id"), _
                                                                    o_fila("IdTipoDocumento"), _
                                                                    o_fila("IdProceso"), _
                                                                    o_fila("Activo"), _
                                                                    o_fila("Proceso"), _
                                                                    o_fila("TipoDocumento"), _
                                                                    o_fila("Codigo"))
            Return oeProcesoTipoDocumento
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Obtener(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As e_ProcesoTipoDocumento
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoTipoDocumento_Listar", "", oeProcesoTipoDocumento.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeProcesoTipoDocumento = Cargar(ds.Tables(0).Rows(0))
                Return oeProcesoTipoDocumento
            Else
                oeProcesoTipoDocumento = New e_ProcesoTipoDocumento
                Return oeProcesoTipoDocumento
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerUnico(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As e_ProcesoTipoDocumento
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoTipoDocumento_Listar", "", "", oeProcesoTipoDocumento.IdTipoDocumento, oeProcesoTipoDocumento.IdProceso)
            If ds.Tables(0).Rows.Count > 0 Then
                oeProcesoTipoDocumento = Cargar(ds.Tables(0).Rows(0))
                Return oeProcesoTipoDocumento
            Else
                oeProcesoTipoDocumento = New e_ProcesoTipoDocumento
                Return oeProcesoTipoDocumento
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As List(Of e_ProcesoTipoDocumento)
        Try
            Dim ldProcesoTipoDocumento As New List(Of e_ProcesoTipoDocumento)
            Dim ds As DataSet
            With oeProcesoTipoDocumento
                ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoTipoDocumento_Listar", .TipoOperacion, .Id, .IdTipoDocumento, .IdProceso, .Activo)
            End With
            oeProcesoTipoDocumento = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeProcesoTipoDocumento = Cargar(o_Fila)
                    ldProcesoTipoDocumento.Add(oeProcesoTipoDocumento)
                Next
                Return ldProcesoTipoDocumento
            Else
                ldProcesoTipoDocumento = New List(Of e_ProcesoTipoDocumento)
                Return ldProcesoTipoDocumento
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Guardar(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As Boolean
        Try
            With oeProcesoTipoDocumento
                sqlhelper.ExecuteNonQuery("STD.ISP_ProcesoTipoDocumento_IAE", .TipoOperacion,
                .PrefijoID, .Id, .IdTipoDocumento, .IdProceso, .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.ISP_ProcesoTipoDocumento_IAE", oeProcesoTipoDocumento.TipoOperacion, "", oeProcesoTipoDocumento.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
