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
Public Class d_ParametroGeneral
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ParametroGeneral
        Try
            Dim oeParametroGeneral = New e_ParametroGeneral( _
                             o_Fila("Id").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Texto").ToString _
                             , o_Fila("Numero").ToString _
            )
            Return oeParametroGeneral
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeParametroGeneral As e_ParametroGeneral) As e_ParametroGeneral

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ParametroGeneral_Listar", "", oeParametroGeneral.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeParametroGeneral = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeParametroGeneral
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeParametroGeneral As e_ParametroGeneral) As List(Of e_ParametroGeneral)
        Try
            Dim ldParametroGeneral As New List(Of e_ParametroGeneral)
            Dim ds As DataSet
            With oeParametroGeneral
                ds = sqlhelper.ExecuteDataset("STD.Isp_ParametroGeneral_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Texto _
                        , .Numero _
                        )
            End With
            oeParametroGeneral = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeParametroGeneral = Cargar(o_Fila)
                    ldParametroGeneral.Add(oeParametroGeneral)
                Next
            End If
            Return ldParametroGeneral
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeParametroGeneral As e_ParametroGeneral) As Boolean
        Try
            With oeParametroGeneral
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Nombre _
                        , .Texto _
                        , .Numero
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeParametroGeneral As e_ParametroGeneral) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeParametroGeneral.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
