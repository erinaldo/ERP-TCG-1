'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_GastoVehiculo
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_GastoVehiculo
        Try
            Dim oeGastoVehiculo = New e_GastoVehiculo( _
                             o_fila("Id").ToString _
                             , o_fila("IdGastoCaja").ToString _
                             , o_fila("IdVehiculo").ToString _
            )
            Return oeGastoVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGastoVehiculo As e_GastoVehiculo) As e_GastoVehiculo

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeGastoVehiculo.Id)
            If ds.Tables.Count > 0 Then
                oeGastoVehiculo = Cargar(ds.Tables(0).Rows(0))
                Return oeGastoVehiculo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGastoVehiculo As e_GastoVehiculo) As List(Of e_GastoVehiculo)
        Try
            Dim ldGastoVehiculo As New List(Of e_GastoVehiculo)
            Dim ds As DataSet
            With oeGastoVehiculo
                ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdGastoCaja _
                        , .IdVehiculo _
                        )
            End With
            oeGastoVehiculo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGastoVehiculo = Cargar(o_Fila)
                    ldGastoVehiculo.Add(oeGastoVehiculo)
                Next
                Return ldGastoVehiculo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGastoVehiculo As e_GastoVehiculo) As Boolean
        Try
            With oeGastoVehiculo
                sqlhelper.ExecuteNonQuery("TES.Isp_GastoVehiculo_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdGastoCaja _
                        , .IdVehiculo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGastoVehiculo As e_GastoVehiculo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeGastoVehiculo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
