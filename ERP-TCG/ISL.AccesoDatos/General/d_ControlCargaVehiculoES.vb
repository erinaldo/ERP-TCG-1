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

Public Class d_ControlCargaVehiculoES
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ControlCargaVehiculoES
        Try
            Dim oeControlCargaVehiculoES = New e_ControlCargaVehiculoES( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdVehiculoES").ToString _
                             , o_Fila("Placa").ToString _
                             , o_Fila("IndIsl").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeControlCargaVehiculoES
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlCargaVehiculoES As e_ControlCargaVehiculoES) As e_ControlCargaVehiculoES

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeControlCargaVehiculoES.Id)
            If ds.Tables.Count > 0 Then
                oeControlCargaVehiculoES = Cargar(ds.Tables(0).Rows(0))
                Return oeControlCargaVehiculoES
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlCargaVehiculoES As e_ControlCargaVehiculoES) As List(Of e_ControlCargaVehiculoES)
        Try
            Dim ldControlCargaVehiculoES As New List(Of e_ControlCargaVehiculoES)
            Dim ds As DataSet
            With oeControlCargaVehiculoES
                ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdVehiculoES _
                        , .Placa _
                        , .IndIsl _
                        , .Activo _
                        )
            End With
            oeControlCargaVehiculoES = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeControlCargaVehiculoES = Cargar(o_Fila)
                    ldControlCargaVehiculoES.Add(oeControlCargaVehiculoES)
                Next
                Return ldControlCargaVehiculoES
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlCargaVehiculoES As e_ControlCargaVehiculoES) As Boolean
        Try
            With oeControlCargaVehiculoES
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdVehiculoES _
                        , .Placa _
                        , .IndIsl _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlCargaVehiculoES As e_ControlCargaVehiculoES) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeControlCargaVehiculoES.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
