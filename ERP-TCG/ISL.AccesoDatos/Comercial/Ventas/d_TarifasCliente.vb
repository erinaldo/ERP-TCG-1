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

Public Class d_TarifasCliente
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_TarifasCliente
        Try
            Dim oeTarifasCliente = New e_TarifasCliente( _
                             o_fila("Id").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("IdTipoRuta").ToString _
                             , o_fila("IdTipoVehiculo").ToString _
                             , o_fila("Tarifa").ToString _
                             , o_fila("IndConsolidado").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdOrigen").ToString _
                             , o_fila("IdDestino").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaFin").ToString _
                             , o_fila("IndHistorial").ToString _
                             , o_fila("IndActual").ToString _
                             , o_fila("Porcentaje").ToString _
                             , o_fila("IdTipoCarga").ToString _
                             , o_fila("IndCarga").ToString _
                             , o_fila("IndDescarga").ToString _
                             , o_fila("IndContraEntrega").ToString _
                             , o_fila("IndVariable").ToString _
                             , o_fila("IndOtros").ToString _
                             , o_fila("FInicioCampaña").ToString _
                             , o_fila("FFinCampaña").ToString)
            oeTarifasCliente.IdMaterial = o_fila("IdMaterial").ToString
            oeTarifasCliente.IndMaterial = o_fila("IndMaterial").ToString
            oeTarifasCliente.AceptaComision = o_fila("AceptaComision").ToString
            Return oeTarifasCliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTarifasCliente As e_TarifasCliente) As e_TarifasCliente
        Try
            Dim ds As DataSet
            With oeTarifasCliente
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_TarifaRuta_Listar]", _
                                                .TipoOperacion, _
                                                .Id, _
                                                .IdCliente, _
                                                .Porcentaje, _
                                                .IndHistorial, _
                                                .IndActual, _
                                                .IdOrigen, _
                                                .IdDestino, _
                                                .IdTipoVehiculo, _
                                                .IdTipoCarga, _
                                                .IndConsolidado, _
                                                .IdMaterial)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeTarifasCliente = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTarifasCliente = New e_TarifasCliente
            End If
            Return oeTarifasCliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTarifasCliente As e_TarifasCliente) As List(Of e_TarifasCliente)
        Try
            Dim ldTarifasCliente As New List(Of e_TarifasCliente)
            Dim ds As DataSet
            With oeTarifasCliente
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_TarifaRuta_Listar]", _
                                .TipoOperacion _
                                , .Id _
                                , .IdCliente _
                                , .Porcentaje _
                                , .IndHistorial _
                                , .IndActual)
            End With
            oeTarifasCliente = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTarifasCliente = Cargar(o_Fila)
                    ldTarifasCliente.Add(oeTarifasCliente)
                Next
            Else
                ldTarifasCliente = New List(Of e_TarifasCliente)
            End If
            Return ldTarifasCliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarTarifas(ByVal oeTarifasCliente As e_TarifasCliente) As DataTable
        Try
            Dim tabla As DataTable
            With oeTarifasCliente
                tabla = sqlhelper.ExecuteDataset("[OPE].[Isp_TarifaRuta_Listar]", _
                                                  .TipoOperacion, _
                                                  .Id, _
                                                  .IdCliente, _
                                                  .Porcentaje, _
                                                  .IndHistorial, _
                                                  .IndActual).Tables(0)
            End With
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTarifasCliente As e_TarifasCliente) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                With oeTarifasCliente
                    sqlhelper.ExecuteNonQuery("[OPE].[Isp_TarifaRuta_IAE]",
                                              .TipoOperacion,
                                              .PrefijoID,
                                                .Id _
                                                , .IdCliente _
                                                , .IdTipoRuta _
                                                , .IdTipoVehiculo _
                                                , .Tarifa _
                                                , .IndConsolidado _
                                                , .Observacion _
                                                , .UsuarioCreacion _
                                                , .IdOrigen _
                                                , .IdDestino _
                                                , .FechaInicio _
                                                , .FechaFin _
                                                , .IndHistorial _
                                                , .IndActual _
                                                , .Porcentaje _
                                                , .IdTipoCarga _
                                                , .IndCarga _
                                                , .IndDescarga _
                                                , .IndContraEntrega _
                                                , .IndVariable _
                                                , .IndOtros _
                                                , .FInicioCampaña _
                                                , .FFinCampaña _
                                                , .IdMaterial _
                                                , .IndMaterial _
                                                , .AceptaComision)
                End With
                If oeTarifasCliente.e_ListaTarifasCliente.Count > 0 Then
                    For Each TarifasCliente As e_TarifasCliente In oeTarifasCliente.e_ListaTarifasCliente
                        TarifasCliente.TipoOperacion = "I"
                        TarifasCliente.PrefijoID = oeTarifasCliente.PrefijoID '@0001
                        With TarifasCliente
                            sqlhelper.ExecuteNonQuery("[OPE].[Isp_TarifaRuta_IAE]",
                                                      .TipoOperacion,
                                                      .PrefijoID,
                                                        .Id _
                                                        , .IdCliente _
                                                        , .IdTipoRuta _
                                                        , .IdTipoVehiculo _
                                                        , .Tarifa _
                                                        , .IndConsolidado _
                                                        , .Observacion _
                                                        , .UsuarioCreacion _
                                                        , .IdOrigen _
                                                        , .IdDestino _
                                                        , .FechaInicio _
                                                        , .FechaFin _
                                                        , .IndHistorial _
                                                        , .IndActual _
                                                        , .Porcentaje _
                                                        , .IdTipoCarga _
                                                        , .IndCarga _
                                                        , .IndDescarga _
                                                        , .IndContraEntrega _
                                                        , .IndVariable _
                                                        , .IndOtros _
                                                        , .FInicioCampaña _
                                                        , .FFinCampaña _
                                                        , .IdMaterial _
                                                        , .IndMaterial _
                                                        , .AceptaComision)
                        End With
                    Next
                End If
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeTarifasCliente As e_TarifasCliente) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_TarifaRuta_IAE]", "E", _
                                            "", _
                                            oeTarifasCliente.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

