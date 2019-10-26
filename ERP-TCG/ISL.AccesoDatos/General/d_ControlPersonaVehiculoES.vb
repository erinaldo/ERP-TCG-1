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

Public Class d_ControlPersonaVehiculoES
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ControlPersonaVehiculoES
        Try
            Dim oeControlPersonaVehiculoES = New e_ControlPersonaVehiculoES( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdPersonaES").ToString _
                             , o_Fila("IdVehiculoES").ToString _
                             , o_Fila("Condicion").ToString _
                             , o_Fila("IndES").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeControlPersonaVehiculoES
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As e_ControlPersonaVehiculoES

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeControlPersonaVehiculoES.Id)
            If ds.Tables.Count > 0 Then
                oeControlPersonaVehiculoES = Cargar(ds.Tables(0).Rows(0))
                Return oeControlPersonaVehiculoES
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As List(Of e_ControlPersonaVehiculoES)
        Try
            Dim ldControlPersonaVehiculoES As New List(Of e_ControlPersonaVehiculoES)
            Dim ds As DataSet
            With oeControlPersonaVehiculoES
                ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdPersonaES _
                        , .IdVehiculoES _
                        , .Condicion _
                        , .IndES _
                        , .Activo _
                        )
            End With
            oeControlPersonaVehiculoES = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeControlPersonaVehiculoES = Cargar(o_Fila)
                    ldControlPersonaVehiculoES.Add(oeControlPersonaVehiculoES)
                Next
                Return ldControlPersonaVehiculoES
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar_Tablas(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As DataSet
        Try
            Dim ds As DataSet
            With oeControlPersonaVehiculoES
                ds = sqlhelper.ExecuteDataset("STD.Isp_ControlPersonaVehiculoES_Listar", _
                                                .TipoOperacion, _
                                                .Id, _
                                                .IdPersonaES, _
                                                .IdVehiculoES)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Guardar(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As Boolean
        Try
            With oeControlPersonaVehiculoES
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdPersonaES _
                        , .IdVehiculoES _
                        , .Condicion _
                        , .IndES _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeControlPersonaVehiculoES.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

