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
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "",
            Left(oeMovimientoDocumentoCuenta.PrefijoID, 1), "", oeMovimientoDocumentoCuenta.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoDocumentoCuenta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovimientoDocumentoCuenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoDocumentoCuenta As e_MovimientoDocumentoCuenta) As List(Of e_MovimientoDocumentoCuenta)
        Try
            Dim ldMovimientoDocumentoCuenta As New List(Of e_MovimientoDocumentoCuenta)
            Dim ds As DataSet
            With oeMovimientoDocumentoCuenta
                ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
        , Left(.PrefijoID, 1), "" _
                        , .Id _
                        , .idMovimientoDocumento _
                        , .idCuentaxCyP
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
            With oeMovimientoDocumentoCuenta
                sqlhelper.ExecuteNonQuery("TES.Isp_MovimientoDocumentoCuenta_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .idMovimientoDocumento _
                        , .idCuentaxCyP
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
