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

Public Class d_Placa
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Placa
        Try
            Dim oePlaca = New e_Placa(
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("IdVehiculo").ToString _
                                , o_fila("Actual").ToString)
            Return oePlaca
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePlaca As e_Placa) As e_Placa
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Placa_Listar",
                                          "",
                                          oePlaca.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oePlaca = Cargar(ds.Tables(0).Rows(0))
            Else
                oePlaca = New e_Placa
            End If
            Return oePlaca
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oePlaca As e_Placa) As List(Of e_Placa)
        Try
            Dim ldPlaca As New List(Of e_Placa)
            Dim ds As DataSet
            With oePlaca
                ds = sqlhelper.ExecuteDataset("STD.Isp_Placa_Listar",
                                              .TipoOperacion _
                                            , .Id _
                                            , .Activo _
                                            , .IdVehiculo)
            End With
            oePlaca = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oePlaca = Cargar(o_Fila)
                    ldPlaca.Add(oePlaca)
                Next
            Else
                ldPlaca = New List(Of e_Placa)
            End If
            Return ldPlaca
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePlaca As e_Placa) As Boolean
        Try
            With oePlaca
                sqlhelper.ExecuteNonQuery("STD.Isp_Placa_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                        .Id _
                                        , .Nombre _
                                        , .Activo _
                                        , .FechaInicio _
                                        , .IdVehiculo _
                                        , .Actual)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oePlaca As e_Placa) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Placa_IAE", "E",
             "", oePlaca.Id, "", 0, "01/01/1901", oePlaca.IdVehiculo)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

