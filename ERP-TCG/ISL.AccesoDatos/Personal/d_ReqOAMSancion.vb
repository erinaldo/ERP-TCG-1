'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions


Public Class d_ReqOAMSancion
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ReqOAMSancion
        Try
            Dim oeReqOAMSancion = New e_ReqOAMSancion( _
                             o_fila("Id").ToString _
                             , o_fila("IdRequerimientoMaterial").ToString _
                             , o_fila("IdOrdenAsignacionMaterial").ToString _
                             , o_fila("IdSancion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeReqOAMSancion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeReqOAMSancion As e_ReqOAMSancion) As e_ReqOAMSancion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeReqOAMSancion.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeReqOAMSancion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeReqOAMSancion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeReqOAMSancion As e_ReqOAMSancion) As List(Of e_ReqOAMSancion)
        Try
            Dim ldReqOAMSancion As New List(Of e_ReqOAMSancion)
            Dim ds As DataSet
            With oeReqOAMSancion
                ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdRequerimientoMaterial _
                        , .IdOrdenAsignacionMaterial _
                        , .IdSancion _
                        , .Activo _
                        )
            End With
            oeReqOAMSancion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeReqOAMSancion = Cargar(o_Fila)
                ldReqOAMSancion.Add(oeReqOAMSancion)
            Next
            Return ldReqOAMSancion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeReqOAMSancion As e_ReqOAMSancion) As Boolean
        Try
            With oeReqOAMSancion
                sqlhelper.ExecuteNonQuery("[PER].[Isp_Req_OAM_Sancion_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdRequerimientoMaterial _
                        , .IdOrdenAsignacionMaterial _
                        , .IdSancion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeReqOAMSancion As e_ReqOAMSancion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[PER].[Isp_Req_OAM_Sancion_IAE]", "E", _
             "", oeReqOAMSancion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
