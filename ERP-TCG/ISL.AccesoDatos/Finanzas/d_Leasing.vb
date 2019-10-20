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
Public Class d_Leasing
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_Leasing
        Try
            Dim oeLeasing = New e_Leasing( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdProveedor").ToString _
                             , o_Fila("FechaInicio").ToString _
                             , o_Fila("IdMoneda").ToString _
                             , o_Fila("Capital").ToString _
                             , o_Fila("CuotaInicia").ToString _
                             , o_Fila("NumeroCuotas").ToString _
                             , o_Fila("FechaVencimiento").ToString _
                             , o_Fila("TasaInteres").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeLeasing
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Obtener(ByVal oeLeasing As e_Leasing) As e_Leasing
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("FIN.ISP_Leaging_Listar", "",
            Left(oeLeasing.PrefijoID, 1), "", oeLeasing.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeLeasing = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeLeasing
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function Listar(ByVal oeLeasing As e_Leasing) As List(Of e_Leasing)
        Try
            Dim ldLeasing As New List(Of e_Leasing)
            Dim ds As DataSet
            With oeLeasing
                ds = sqlhelper.ExecuteDataset("FIN.ISP_Leasing_Listar", "" _
        , Left(.PrefijoID, 1), "" _
                        , .Id _
                        , .IdProveedor _
                        , .FechaInicio _
                        , .IdMoneda _
                        , .Capital _
                        , .CuotaInicia _
                        , .NumeroCuotas _
                        , .FechaVencimiento _
                        , .TasaInteres _
                        , .Activo
                        )
            End With
            oeLeasing = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeLeasing = Cargar(o_Fila)
                    ldLeasing.Add(oeLeasing)
                Next
            End If
            Return ldLeasing
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function Guardar(ByVal oeLeasing As e_Leasing) As Boolean
        Try
            With oeLeasing
                sqlhelper.ExecuteNonQuery("FIN.ISP_Leasing_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdProveedor _
                        , .FechaInicio _
                        , .IdMoneda _
                        , .Capital _
                        , .CuotaInicia _
                        , .NumeroCuotas _
                        , .FechaVencimiento _
                        , .TasaInteres _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    Public Function Eliminar(ByVal oeLeasing As e_Leasing) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("FIN.ISP_Leasing_IAE", "E", _
             "", oeLeasing.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class

