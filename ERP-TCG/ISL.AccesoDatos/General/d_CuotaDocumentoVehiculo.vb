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

Public Class d_CuotaDocumentoVehiculo
    Private sqlhelper As New SqlHelper
    Dim odCuotaDoVehPago As New d_CuotaDocVehPago

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuotaDocumentoVehiculo
        Try
            Dim oeCuotaDocumentoVehiculo = New e_CuotaDocumentoVehiculo( _
                             o_fila("Id").ToString _
                             , o_fila("IdDocumento").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("SaldoAdministrativo").ToString _
                             , o_fila("SaldoContable").ToString _
                             , o_fila("IdDocVeh_Doc").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("MontoOpera").ToString _
                                     )
            Return oeCuotaDocumentoVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As e_CuotaDocumentoVehiculo

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeCuotaDocumentoVehiculo.Id)
            If ds.Tables.Count > 0 Then
                oeCuotaDocumentoVehiculo = Cargar(ds.Tables(0).Rows(0))
                Return oeCuotaDocumentoVehiculo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As List(Of e_CuotaDocumentoVehiculo)
        Try
            Dim ldCuotaDocumentoVehiculo As New List(Of e_CuotaDocumentoVehiculo)
            Dim ds As DataSet
            With oeCuotaDocumentoVehiculo
                ds = sqlhelper.ExecuteDataset("STD.Isp_CuotaDocumentoVehiculo_Listar" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdDocumento _
                        , .Activo _
                        , .FechaDesde _
                        , .FechaHasta _
                        )
            End With
            oeCuotaDocumentoVehiculo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuotaDocumentoVehiculo = Cargar(o_Fila)
                    ldCuotaDocumentoVehiculo.Add(oeCuotaDocumentoVehiculo)
                Next
            End If
            Return ldCuotaDocumentoVehiculo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As Boolean
        Try

            With oeCuotaDocumentoVehiculo
                sqlhelper.ExecuteNonQuery("STD.Isp_CuotaDocumentoVehiculo_IAE" _
                                              , .TipoOperacion, .PrefijoID _
                                            , .Id _
                                            , .IdDocumento _
                                            , .Monto _
                                            , .Fecha _
                                            , .Glosa _
                                            , .Activo _
                                            , .IdUsuarioCreacion _
                                            , .SaldoAdministrativo _
                                            , .SaldoContable _
                                            , .IdDocVeh_Doc _
                                            , .IdOrigen_CuotaMov _
                                            , .MontoOpera _
                                            , .TipoMovimientoSaldo _
                    )

                If .leCuotaPago.Count > 0 Then
                    For Each obj In .leCuotaPago
                        obj.PrefijoID = oeCuotaDocumentoVehiculo.PrefijoID '@0001
                        odCuotaDoVehPago.Guardar(obj)
                    Next
                End If

            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeCuotaDocumentoVehiculo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarDts(ByVal oeCuotaDocVeh As e_CuotaDocumentoVehiculo) As DataSet
        Try
            With oeCuotaDocVeh
                Return sqlhelper.ExecuteDataset("[STD].[Isp_CuotaDocumentoVehiculo_Listar]", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdDocumento, _
                                              .Activo, _
                                              .FechaDesde, _
                                              .FechaHasta, _
                                              .IndVigencia)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
