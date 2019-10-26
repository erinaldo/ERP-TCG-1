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

Public Class d_LiquidacionTrabajador_Asiento
    Private sqlhelper As New SqlHelper

    Public Function Guardar(ByVal oeLiquidacionTrabajador_Asiento As e_LiquidacionTrabajador_Asiento) As Boolean
        Try
            Dim id() As String
            Using transScope As New TransactionScope()
                With oeLiquidacionTrabajador_Asiento
                    id = sqlhelper.ExecuteScalar("CON.Isp_LiquidacionTrabajador_Asiento_IAE",
                             .TipoOperacion,
                             .PrefijoID,
                            .Id _
                            , .idliquidaciontrabajador _
                            , .idasiento _
                            , .Activo _
                            , .Tipo _
                            , .usuariocrea
                        ).ToString.Split("-")
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar(ByVal o_fila As DataRow) As e_LiquidacionTrabajador_Asiento
        Try
            Dim oeLiquidacionTrabajador_Asiento As New e_LiquidacionTrabajador_Asiento(o_fila("Id"), _
                                          o_fila("idliquidaciontrabajador"), _
                                          o_fila("idasiento"), _
                                          o_fila("Tipo"), _
                                        o_fila("Activo"))
            Return oeLiquidacionTrabajador_Asiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeLiquidacionTrabajador_Asiento As e_LiquidacionTrabajador_Asiento) As List(Of e_LiquidacionTrabajador_Asiento)
        Try
            Dim lst_LiquidacionTrabajador_Asiento As New List(Of e_LiquidacionTrabajador_Asiento)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_LiquidacionTrabajador_Asiento_LST", _
                                          oeLiquidacionTrabajador_Asiento.TipoOperacion, _
                                          oeLiquidacionTrabajador_Asiento.Id, _
                                          oeLiquidacionTrabajador_Asiento.idliquidaciontrabajador, _
                                          oeLiquidacionTrabajador_Asiento.idasiento, _
                                          oeLiquidacionTrabajador_Asiento.Activo, _
                                          oeLiquidacionTrabajador_Asiento.Tipo)
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeLiquidacionTrabajador_Asiento = Cargar(o_Fila)
                    lst_LiquidacionTrabajador_Asiento.Add(oeLiquidacionTrabajador_Asiento)
                Next
                Return lst_LiquidacionTrabajador_Asiento
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
