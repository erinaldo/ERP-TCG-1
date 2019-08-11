Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MovimientoDocumentoCuenta
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoDocumentoCuenta
        Try
            Dim oeMovimientoDocumentoCuenta = New e_MovimientoDocumentoCuenta( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdMovimientoDocumento").ToString _
                             , o_Fila("IdCuentaxCyP").ToString _
            )
            Return oeMovimientoDocumentoCuenta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoDocumentoCuenta As e_MovimientoDocumentoCuenta) As e_MovimientoDocumentoCuenta

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", _
            Left(d_DatosConfiguracion.PrefijoID, 1), "", oeMovimientoDocumentoCuenta.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeMovimientoDocumentoCuenta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovimientoDocumentoCuenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoDocumentoCuenta As e_MovimientoDocumentoCuenta) As List(Of e_MovimientoDocumentoCuenta)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldMovimientoDocumentoCuenta As New List(Of e_MovimientoDocumentoCuenta)
            Dim ds As DataSet
            With oeMovimientoDocumentoCuenta
                ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
        , Left(d_DatosConfiguracion.PrefijoID, 1), "" _
                        , .Id _
                        , .IdMovimientoDocumento _
                        , .IdCuentaxCyP _
                        )
            End With
            oeMovimientoDocumentoCuenta = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovimientoDocumentoCuenta = Cargar(o_Fila)
                    ldMovimientoDocumentoCuenta.Add(oeMovimientoDocumentoCuenta)
                Next
            End If
            Return ldMovimientoDocumentoCuenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoDocumentoCuenta As e_MovimientoDocumentoCuenta) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMovimientoDocumentoCuenta
                sqlhelper.ExecuteNonQuery("TES.Isp_MovimientoDocumentoCuenta_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .idMovimientoDocumento _
                        , .idCuentaxCyP _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimientoDocumentoCuenta As e_MovimientoDocumentoCuenta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_MovimientoDocumentoCuenta_IAE", "E", _
             "", oeMovimientoDocumentoCuenta.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
