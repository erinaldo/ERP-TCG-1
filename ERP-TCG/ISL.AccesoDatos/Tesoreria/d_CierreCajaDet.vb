Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_CierreCajaDet
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CierreCajaDet
        Try
            Dim oeCierreCajaDet = New e_CierreCajaDet( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdCierreCaja").ToString _
                             , o_Fila("Glosa").ToString _
                             , o_Fila("Ingreso").ToString _
                             , o_Fila("Egreso").ToString _
                             , o_Fila("Voucher").ToString _
                             , o_Fila("Fecha").ToString _
            )
            Return oeCierreCajaDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCierreCajaDet As e_CierreCajaDet) As e_CierreCajaDet

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeCierreCajaDet.Id)
            If ds.Tables.Count > 0 Then
                oeCierreCajaDet = Cargar(ds.Tables(0).Rows(0))
                Return oeCierreCajaDet
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCierreCajaDet As e_CierreCajaDet) As List(Of e_CierreCajaDet)
        Try
            Dim ldCierreCajaDet As New List(Of e_CierreCajaDet)
            Dim ds As DataSet
            With oeCierreCajaDet
                ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdCierreCaja _
                        , .Glosa _
                        , .Ingreso _
                        , .Egreso _
                        , .Voucher _
                        , .Fecha _
                        )
            End With
            oeCierreCajaDet = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCierreCajaDet = Cargar(o_Fila)
                    ldCierreCajaDet.Add(oeCierreCajaDet)
                Next
                Return ldCierreCajaDet
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCierreCajaDet As e_CierreCajaDet) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCierreCajaDet
                sqlhelper.ExecuteNonQuery("TES.Isp_CierreCajaDet_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdCierreCaja _
                        , .Glosa _
                        , .Ingreso _
                        , .Egreso _
                        , .Voucher _
                        , .Fecha _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCierreCajaDet As e_CierreCajaDet) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeCierreCajaDet.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
