Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient


Public Class d_ProcesarTarifasProceso
    Private sqlhelper As New SqlHelper

    Public Function Cargar(ByVal o_fila As DataRow) As e_ProcesarTarifasProceso
        Try
            Dim oeProcesarTarifasProceso = New e_ProcesarTarifasProceso( _
                             o_fila("Id").ToString _
                             , o_fila("IdOperacionProceso").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdTracto").ToString _
                             , o_fila("Tracto").ToString _
                             , o_fila("CuentaNorte").ToString _
                             , o_fila("CuentaSur").ToString _
                             , o_fila("CostoFijo").ToString _
                             , o_fila("Valor").ToString _
                             , o_fila("Semana").ToString _
                             , o_fila("NViaje").ToString _
                             , o_fila("CFxViaje").ToString _
                             , o_fila("Norte").ToString _
                             , o_fila("Sur").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("VariableXViaje").ToString _
                             , o_fila("CostoViaje").ToString _
                             , o_fila("CostoAdicional").ToString _
                             , o_fila("CostoTotal").ToString _
                              , o_fila("Adicional01").ToString _
                               , o_fila("Adicional02").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaFin").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Guardar").ToString)
            Return oeProcesarTarifasProceso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As e_ProcesarTarifasProceso
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_ProcesarTarifasProceso_Listar", _
                                          "", _
                                          oeProcesarTarifasProceso.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeProcesarTarifasProceso = Cargar(ds.Tables(0).Rows(0))
            Else
                oeProcesarTarifasProceso = New e_ProcesarTarifasProceso
            End If
            Return oeProcesarTarifasProceso
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As List(Of e_ProcesarTarifasProceso)
        Try
            Dim ldProcesarTarifasProceso As New List(Of e_ProcesarTarifasProceso)
            Dim ds As DataSet
            With oeProcesarTarifasProceso
                ds = sqlhelper.ExecuteDataset("OPE.Isp_ProcesarTarifasProceso_Listar", "" _
                        , .Id _
                        , .IdOperacionProceso)
            End With
            oeProcesarTarifasProceso = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeProcesarTarifasProceso = Cargar(o_Fila)
                    ldProcesarTarifasProceso.Add(oeProcesarTarifasProceso)
                Next
            Else
                ldProcesarTarifasProceso = New List(Of e_ProcesarTarifasProceso)
            End If
            Return ldProcesarTarifasProceso
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeProcesarTarifasProceso
                sqlhelper.ExecuteNonQuery("OPE.Isp_ProcesarTarifasProceso_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                            .Id _
                                            , .IdOperacionProceso _
                                            , .Codigo _
                                            , .IdTracto _
                                            , .Tracto _
                                            , .CuentaNorte _
                                            , .CuentaSur _
                                            , .CostoFijo _
                                            , .Valor _
                                            , .Semana _
                                            , .NViaje _
                                            , .CFxViaje _
                                            , .Norte _
                                            , .Sur _
                                            , .Total _
                                            , .VariableXViaje _
                                            , .CostoViaje _
                                            , .CostoAdicional _
                                            , .CostoTotal _
                                            , .Adicional01 _
                                            , .Adicional02 _
                                            , .FechaInicio _
                                            , .FechaFin _
                                            , .Observacion _
                                            , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_ProcesarTarifasProceso_IAE", "E", _
             "", oeProcesarTarifasProceso.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
