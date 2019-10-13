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

Public Class d_GastoAsiento
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_GastoAsiento
        Try
            Dim oeGastoAsiento = New e_GastoAsiento( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdGastoOperacion").ToString _
                             , o_Fila("IdAsiento").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeGastoAsiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGastoAsiento As e_GastoAsiento) As e_GastoAsiento

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_GastoAsiento_Listar", "",
            Left(oeGastoAsiento.PrefijoID, 1), "", oeGastoAsiento.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeGastoAsiento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeGastoAsiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGastoAsiento As e_GastoAsiento) As List(Of e_GastoAsiento)
        Try
            Dim ldGastoAsiento As New List(Of e_GastoAsiento)
            Dim ds As DataSet
            With oeGastoAsiento
                ds = sqlhelper.ExecuteDataset("TES.Isp_GastoAsiento_Listar", "" _
        , Left(.PrefijoID, 1), "" _
                        , .Id _
                        , .IdGastoOperacion _
                        , .IdAsiento _
                        , .Activo
                        )
            End With
            oeGastoAsiento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGastoAsiento = Cargar(o_Fila)
                    ldGastoAsiento.Add(oeGastoAsiento)
                Next
            End If
            Return ldGastoAsiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGastoAsiento As e_GastoAsiento, ByVal OeAsiento As e_Asiento) As Boolean
        Try
            If OeAsiento.TipoOperacion = "I" Then
                Dim odAsiento As New d_Asiento
                odAsiento.Guardar(OeAsiento, Nothing, False)
                With oeGastoAsiento
                    .IdAsiento = OeAsiento.Id
                    sqlhelper.ExecuteNonQuery("TES.Isp_GastoAsiento_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .IdGastoOperacion _
                            , .IdAsiento _
                            , .Activo
                        )
                End With
            Else
                With oeGastoAsiento
                    sqlhelper.ExecuteNonQuery("TES.Isp_GastoAsiento_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .IdGastoOperacion _
                            , .IdAsiento _
                            , .Activo
                        )
                End With
            End If

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGastoAsiento As e_GastoAsiento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_GastoAsiento_IAE", "E", _
             "", oeGastoAsiento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarGFAnalisis(ByVal oeGastoAsiento As e_GastoAsiento) As DataTable
        Try
            Dim connectionString As String = d_Conexion.CadenaConexionSGI()
            Dim ds As SqlDataReader
            Dim Tabla As New DataTable
            With oeGastoAsiento
                ds = sqlhelper.ExecuteReader(connectionString, "[CON].[Isp_ReporteGastoFuncionAnalisis]", _
                                              .IdPeriodo _
                                                , 0 _
                                                , .NroMes _
                                                , .IdGastoOperacion _
                                                , 0 _
                                                , .TipoOperacion _
                                                , .IdCuentaContable _
                                                , .IdItemGasto)
            End With
            Tabla.Load(ds, LoadOption.OverwriteChanges)
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
