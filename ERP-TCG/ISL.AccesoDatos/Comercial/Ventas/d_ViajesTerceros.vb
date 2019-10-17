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

Public Class d_ViajesTerceros
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ViajesTerceros
        Try
            Dim oeViajesTerceros = New e_ViajesTerceros( _
                             o_fila("Id").ToString _
                             , o_fila("IdDemanda").ToString _
                             , o_fila("IdOperacion").ToString _
                             , o_fila("IdTercero").ToString _
                             , o_fila("IdContacto").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("FleteUnitario").ToString _
                             , o_fila("Igv").ToString _
                             , o_fila("TotalFlete").ToString _
                             , o_fila("SaldoFlete").ToString _
                             , o_fila("AdelantoFlete").ToString _
                             , o_fila("Comision").ToString _
                             , o_fila("SaldoComision").ToString _
                             , o_fila("IndFacturado").ToString _
                             , o_fila("IndOperacion").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("IdOperacion").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Documento").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("SubTotal").ToString)
            Return oeViajesTerceros
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeViajesTerceros As e_ViajesTerceros) As e_ViajesTerceros

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_Viaje_Terceros_Listar", _
                                          oeViajesTerceros.TipoOperacion _
                                          , oeViajesTerceros.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeViajesTerceros = Cargar(ds.Tables(0).Rows(0))
            Else
                oeViajesTerceros = New e_ViajesTerceros
            End If
            Return oeViajesTerceros
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeViajesTerceros As e_ViajesTerceros) As List(Of e_ViajesTerceros)
        Try
            Dim ldViajesTerceros As New List(Of e_ViajesTerceros)
            Dim ds As DataSet
            With oeViajesTerceros
                ds = sqlhelper.ExecuteDataset("OPE.Isp_Viaje_Terceros_Listar", _
                                              .TipoOperacion _
                                                , .Id _
                                                , .IdDemanda _
                                                , .IdOperacion _
                                                , .IdTercero _
                                                , .IdContacto _
                                                , .IdMovimientoDocumento _
                                                , .Documento)
            End With
            oeViajesTerceros = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeViajesTerceros = Cargar(o_Fila)
                    ldViajesTerceros.Add(oeViajesTerceros)
                Next
            Else
                ldViajesTerceros = New List(Of e_ViajesTerceros)
            End If
            Return ldViajesTerceros
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeViajesTerceros As e_ViajesTerceros) As Boolean
        Try
            With oeViajesTerceros
                sqlhelper.ExecuteNonQuery("OPE.Isp_Viaje_Terceros_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                        .Id _
                                        , .IdDemanda _
                                        , .IdOperacion _
                                        , .IdTercero _
                                        , .IdContacto _
                                        , .IdMoneda _
                                        , .FleteUnitario _
                                        , .Igv _
                                        , .TotalFlete _
                                        , .SaldoFlete _
                                        , .AdelantoFlete _
                                        , .Comision _
                                        , .SaldoComision _
                                        , .IndFacturado _
                                        , .IndOperacion _
                                        , .IdMovimientoDocumento.Trim _
                                        , .FechaCrea _
                                        , .UsuarioCrea _
                                        , .Serie _
                                        , .Numero _
                                        , .Observacion _
                                        , .Glosa _
                                        , .IdEstado _
                                        , .Documento _
                                        , .Cantidad _
                                        , .SubTotal)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeViajesTerceros As e_ViajesTerceros) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_Viaje_Terceros_IAE", _
                                      oeViajesTerceros.TipoOperacion _
                                      , "" _
                                      , oeViajesTerceros.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
