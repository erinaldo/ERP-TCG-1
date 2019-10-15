
Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_OperacionesProceso

    Private sqlhelper As New SqlHelper
    Private odProcesoDetalle As New d_OperacionesProcesoDetalle
    Private odTarifasProceso As New d_ProcesarTarifasProceso
    Private odOperacionDetalle As New d_Operacion

    Private Function Cargar(ByVal o_fila As DataRow) As e_OperacionesProceso
        Try
            Dim oeOperacionesProceso = New e_OperacionesProceso( _
                             o_Fila("Id").ToString _
                             , o_Fila("Codigo").ToString _
                             , o_Fila("FechaInicio").ToString _
                             , o_Fila("FechaFin").ToString _
                             , o_Fila("IdCliente").ToString _
                             , o_Fila("IdActividadNegocio").ToString _
                             , o_Fila("Semana").ToString _
                             , o_Fila("Total").ToString _
                             , o_Fila("CostoAdicional").ToString _
                             , o_Fila("CostoTotal").ToString _
                             , o_Fila("Observacion").ToString _
                             , o_Fila("IdEstado").ToString _
                             , o_Fila("FechaCrea").ToString _
                             , o_Fila("FechaModifica").ToString _
                             , o_Fila("UsuarioCrea").ToString _
                             , o_Fila("UsuarioModifica").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeOperacionesProceso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOperacionesProceso As e_OperacionesProceso) As e_OperacionesProceso
        Try
            Dim ds As DataSet
            Dim oeTarifasProceso As New e_ProcesarTarifasProceso
            Dim oeProcesoDetalle As New e_OperacionesProcesoDetalle
            Dim Tipo As String = ""
            Tipo = oeOperacionesProceso.TipoOperacion

            ds = sqlhelper.ExecuteDataset("OPE.Isp_OperacionesProceso_Listar", _
                                          Tipo, _
                                          oeOperacionesProceso.Id, _
                                          oeOperacionesProceso.Codigo)
            If ds.Tables(0).Rows.Count > 0 Then
                oeOperacionesProceso = Cargar(ds.Tables(0).Rows(0))
                If Tipo = "1" Then
                    For Each Fila As DataRow In ds.Tables(1).Rows
                        oeTarifasProceso = New e_ProcesarTarifasProceso
                        oeTarifasProceso = odTarifasProceso.Cargar(Fila)
                        oeOperacionesProceso.ListTarifaProceso.Add(oeTarifasProceso)
                    Next
                    For Each Fila As DataRow In ds.Tables(2).Rows
                        oeProcesoDetalle = New e_OperacionesProcesoDetalle
                        oeProcesoDetalle = odProcesoDetalle.Cargar(Fila)
                        oeOperacionesProceso.ListProcesoDetalle.Add(oeProcesoDetalle)
                    Next
                End If
            Else
                oeOperacionesProceso = New e_OperacionesProceso
            End If
            Return oeOperacionesProceso
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOperacionesProceso As e_OperacionesProceso) As List(Of e_OperacionesProceso)
        Try
            Dim ldOperacionesProceso As New List(Of e_OperacionesProceso)
            Dim ds As DataSet
            With oeOperacionesProceso
                ds = sqlhelper.ExecuteDataset("OPE.Isp_OperacionesProceso_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .IdCliente _
                        , .IdActividadNegocio _
                        , .IdEstado)
            End With
            oeOperacionesProceso = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOperacionesProceso = Cargar(o_Fila)
                    ldOperacionesProceso.Add(oeOperacionesProceso)
                Next
            Else
                ldOperacionesProceso = New List(Of e_OperacionesProceso)
            End If

            Return ldOperacionesProceso
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOperacionesProceso As e_OperacionesProceso) As Boolean
        Dim stResultado() As String
        Try
            Using transScope As New TransactionScope()
                With oeOperacionesProceso
                    stResultado = sqlhelper.ExecuteScalar("OPE.Isp_OperacionesProceso_IAE",
                                                          .TipoOperacion,
                                                          .PrefijoID,
                                                        .Id _
                                                        , .Codigo _
                                                        , .FechaInicio _
                                                        , .FechaFin _
                                                        , .IdCliente _
                                                        , .IdActividadNegocio _
                                                        , .Semana _
                                                        , .Total _
                                                        , .CostoAdicional _
                                                        , .CostoTotal _
                                                        , .Observacion _
                                                        , .IdEstado _
                                                        , .UsuarioCrea _
                                                        , .Activo).ToString.Split("_")
                End With
                If oeOperacionesProceso.ListProcesoDetalle.Count > 0 Then
                    For Each ProcesoDetalle In oeOperacionesProceso.ListProcesoDetalle
                        ProcesoDetalle.TipoOperacion = "I"
                        ProcesoDetalle.IdOperacionProceso = stResultado(0)
                        odProcesoDetalle.Guardar(ProcesoDetalle)
                    Next
                End If
                If oeOperacionesProceso.ListTarifaProceso.Count > 0 Then
                    For Each TarifaProceso In oeOperacionesProceso.ListTarifaProceso
                        TarifaProceso.TipoOperacion = "I"
                        TarifaProceso.IdOperacionProceso = stResultado(0)
                        odTarifasProceso.Guardar(TarifaProceso)
                    Next
                End If
                If oeOperacionesProceso.ListOperacionDetalle.Count > 0 Then
                    For Each OperacionDetalle In oeOperacionesProceso.ListOperacionDetalle
                        odOperacionDetalle.GuardarOperacionDetalle(OperacionDetalle)
                    Next
                End If
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOperacionesProceso As e_OperacionesProceso) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_OperacionesProceso_IAE", "E", _
             "", oeOperacionesProceso.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
