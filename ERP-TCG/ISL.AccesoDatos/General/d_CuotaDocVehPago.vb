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

Public Class d_CuotaDocVehPago
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuotaDocVehPago
        Try
            Dim oe = New e_CuotaDocVehPago( _
                             o_fila("Id").ToString _
                             , o_fila("IdCuota").ToString _
                             , o_fila("IdCuotaDocVeh_Mov").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oe
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oe As e_CuotaDocVehPago) As e_CuotaDocVehPago

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oe.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oe = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oe
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oe As e_CuotaDocVehPago) As List(Of e_CuotaDocVehPago)
        Try
            Dim leCuotaDocVehPago As New List(Of e_CuotaDocVehPago)
            Dim ds As DataSet
            With oe
                ds = sqlhelper.ExecuteDataset("STD.CuotaDocumentoVehiculoPago_Listar", .TipoOperacion _
                        , .Id _
                        , .IdCuota _
                        , .IdCuotaDocVeh_Mov _
                         )
            End With
            oe = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oe = Cargar(o_Fila)
                leCuotaDocVehPago.Add(oe)
            Next
            Return leCuotaDocVehPago
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oe As e_CuotaDocVehPago) As Boolean
        Try

            With oe
                sqlhelper.ExecuteNonQuery("STD.Isp_CuotaDocumentoVehiculoPago_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdCuota _
                        , .IdCuotaDocVeh_Mov _
                        , .Glosa _
                        , .Monto _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oe As e_CuotaDocVehPago) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oe.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
