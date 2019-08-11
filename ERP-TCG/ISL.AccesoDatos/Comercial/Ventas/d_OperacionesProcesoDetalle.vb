
Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_OperacionesProcesoDetalle
    Private sqlhelper As New SqlHelper
    Public Function Cargar(ByVal o_fila As DataRow) As e_OperacionesProcesoDetalle
        Try
            Dim oeOperacionesProcesoDetalle = New e_OperacionesProcesoDetalle( _
                             o_fila("Id").ToString _
                             , o_fila("IdOperacionProceso").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("IdOperacionDetalle").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("Semana").ToString _
                             , o_fila("Tracto").ToString _
                             , o_fila("Carreta").ToString _
                             , o_fila("Dia").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Origen").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("Zona").ToString _
                             , o_fila("NTransporte").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("TipoCarga").ToString _
                             , o_fila("KM").ToString _
                             , o_fila("Factor").ToString _
                             , o_fila("CostoViaje").ToString _
                             , o_fila("FleteUnitario").ToString _
                             , o_fila("Flete").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeOperacionesProcesoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As e_OperacionesProcesoDetalle

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_OperacionesProcesoDetalle_Listar", _
                                          "", _
                                          oeOperacionesProcesoDetalle.Id, _
                                          oeOperacionesProcesoDetalle.IdOperacionProceso)
            If ds.Tables(0).rows.Count > 0 Then
                oeOperacionesProcesoDetalle = Cargar(ds.Tables(0).Rows(0))
            Else
                oeOperacionesProcesoDetalle = New e_OperacionesProcesoDetalle
            End If
            Return oeOperacionesProcesoDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As List(Of e_OperacionesProcesoDetalle)
        Try
            Dim ldOperacionesProcesoDetalle As New List(Of e_OperacionesProcesoDetalle)
            Dim ds As DataSet
            With oeOperacionesProcesoDetalle
                ds = sqlhelper.ExecuteDataset("OPE.Isp_OperacionesProcesoDetalle_Listar", "" _
                        , .Id _
                        , .IdOperacionProceso _
                        , .IdViaje _
                        , .IdOperacionDetalle _
                        , .Viaje _
                        , .Semana _
                        , .Tracto _
                        , .Carreta _
                        , .Dia)
            End With
            oeOperacionesProcesoDetalle = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOperacionesProcesoDetalle = Cargar(o_Fila)
                    ldOperacionesProcesoDetalle.Add(oeOperacionesProcesoDetalle)
                Next
            Else
                ldOperacionesProcesoDetalle = New List(Of e_OperacionesProcesoDetalle)
            End If

            Return ldOperacionesProcesoDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeOperacionesProcesoDetalle
                sqlhelper.ExecuteNonQuery("OPE.Isp_OperacionesProcesoDetalle_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdOperacionProceso _
                        , .IdViaje _
                        , .IdOperacionDetalle _
                        , .Viaje _
                        , .Semana _
                        , .Tracto _
                        , .Carreta _
                        , .Dia _
                        , .Fecha _
                        , .Origen _
                        , .Destino _
                        , .Zona _
                        , .NTransporte _
                        , .Glosa _
                        , .TipoCarga _
                        , .KM _
                        , .Factor _
                        , .CostoViaje _
                        , .FleteUnitario _
                        , .Flete _
                        , .Observacion _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_OperacionesProcesoDetalle_IAE", "E", _
             "", oeOperacionesProcesoDetalle.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
