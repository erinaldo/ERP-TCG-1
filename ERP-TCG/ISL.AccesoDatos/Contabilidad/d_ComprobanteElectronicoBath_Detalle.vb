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

Public Class d_ComprobanteElectronicoBath_Detalle

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ComprobanteElectronicoBath_Detalle
        Try
            Dim oeComprobanteElectronicoBath_Detalle = New e_ComprobanteElectronicoBath_Detalle( _
                             o_fila("Id").ToString _
                             , o_fila("IdBath").ToString _
                             , o_fila("Item").ToString _
                             , o_fila("TipoReferencia").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("IndBaja").ToString _
            )
            Return oeComprobanteElectronicoBath_Detalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As e_ComprobanteElectronicoBath_Detalle

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("CON.Isp_ComprobanteElectronicoBath_Detalle_Listar", "", oeComprobanteElectronicoBath_Detalle.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeComprobanteElectronicoBath_Detalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeComprobanteElectronicoBath_Detalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As List(Of e_ComprobanteElectronicoBath_Detalle)
        Try
            Dim ldComprobanteElectronicoBath_Detalle As New List(Of e_ComprobanteElectronicoBath_Detalle)
            Dim ds As DataSet
            With oeComprobanteElectronicoBath_Detalle
                ds = sqlhelper.ExecuteDataset("CON.Isp_ComprobanteElectronicoBath_Detalle_Listar", "" _
                        , .Id _
                        , .IdBath _
                        , .Item _
                        , .TipoReferencia _
                        , .IdReferencia _
                        )
            End With
            oeComprobanteElectronicoBath_Detalle = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeComprobanteElectronicoBath_Detalle = Cargar(o_Fila)
                ldComprobanteElectronicoBath_Detalle.Add(oeComprobanteElectronicoBath_Detalle)
            Next
            Return ldComprobanteElectronicoBath_Detalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As Boolean
        Try
            With oeComprobanteElectronicoBath_Detalle
                sqlhelper.ExecuteNonQuery("CON.Isp_ComprobanteElectronicoBath_Detalle_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdBath _
                        , .Item _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .UsuarioCrea _
                        , .UsuarioModifica _
                        , .IndBaja
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("CON.Isp_ComprobanteElectronicoBath_Detalle_IAE", "E", _
             "", oeComprobanteElectronicoBath_Detalle.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
