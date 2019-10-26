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

Public Class d_Dispositivo
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_Dispositivo
        Try
            Dim oeDispositivo = New e_Dispositivo( _
                             o_fila("Id").ToString _
                             , o_fila("IdTipoDispositivo").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("NroSerie").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaUltimaAct").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Actual").ToString)
            Return oeDispositivo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDispositivo As e_Dispositivo) As e_Dispositivo
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_Dispositivo_Listar]", _
                                          "", _
                                          oeDispositivo.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDispositivo = Cargar(ds.Tables(0).Rows(0))
            Else
                oeDispositivo = New e_Dispositivo
            End If
            Return oeDispositivo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDispositivo As e_Dispositivo) As List(Of e_Dispositivo)
        Try
            Dim ldDispositivo As New List(Of e_Dispositivo)
            Dim ds As DataSet
            With oeDispositivo
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Dispositivo_Listar]", _
                                                "" _
                                                , .Id _
                                                , .IdTipoDispositivo _
                                                , .IdVehiculo _
                                                , .Activo)
            End With
            oeDispositivo = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDispositivo = Cargar(o_Fila)
                    ldDispositivo.Add(oeDispositivo)
                Next
            Else
                ldDispositivo = New List(Of e_Dispositivo)
            End If
            Return ldDispositivo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDispositivo As e_Dispositivo) As Boolean
        Try
            With oeDispositivo
                sqlhelper.ExecuteNonQuery("[STD].[Isp_Dispositivo_IAE]",
                                          .TipoOperacion,
                                          .PrefijoID,
                                            .Id _
                                            , .IdTipoDispositivo _
                                            , .IdVehiculo _
                                            , .NroSerie _
                                            , .Cantidad _
                                            , .FechaInicio _
                                            , .FechaUltimaAct _
                                            , .Activo _
                                            , .Actual)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDispositivo As e_Dispositivo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeDispositivo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
