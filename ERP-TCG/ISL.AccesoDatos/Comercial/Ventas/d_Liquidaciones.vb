Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Liquidaciones

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Liquidaciones
        Try
            Dim oeLiquidaciones = New e_Liquidaciones( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("SubTotal").ToString _
                             , o_fila("Igv").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("IdEstado").ToString _
                              , o_fila("IdFactura").ToString _
                              , o_fila("IndFormato").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo").ToString)
            Return oeLiquidaciones
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeLiquidaciones As e_Liquidaciones) As e_Liquidaciones

        Try
            Dim ds As DataSet
            With oeLiquidaciones
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Liquidacion_Listar]", _
                                                          .TipoOperacion, _
                                                          .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeLiquidaciones = Cargar(ds.Tables(0).Rows(0))
            Else
                oeLiquidaciones = New e_Liquidaciones
            End If
            Return oeLiquidaciones
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeLiquidaciones As e_Liquidaciones) As List(Of e_Liquidaciones)
        Try
            Dim ldLiquidaciones As New List(Of e_Liquidaciones)
            Dim ds As DataSet
            With oeLiquidaciones
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Liquidacion_Listar]", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdCliente, _
                                              .FechaDesde, _
                                              .FechaHasta)
            End With
            oeLiquidaciones = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeLiquidaciones = Cargar(o_Fila)
                    ldLiquidaciones.Add(oeLiquidaciones)
                Next
            Else
                ldLiquidaciones = New List(Of e_Liquidaciones)
            End If
            Return ldLiquidaciones
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeLiquidaciones As e_Liquidaciones) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                '' Para tottus liquidaciones
                If oeLiquidaciones.IndFormato = 100 Then
                    Dim LiquidacionTottus As New e_Liquidaciones
                    Dim ClaseServicio As String

                    Dim SubClaseServicio = (From Detalle In oeLiquidaciones.ListaLiquidacionDetalle
                                            Select Detalle.Consolidado3).Distinct()

                    For Each SubClase In SubClaseServicio
                        LiquidacionTottus = New e_Liquidaciones
                        ClaseServicio = SubClase
                        For Each DetalleTottus As e_LiquidacionDetalle In oeLiquidaciones.ListaLiquidacionDetalle.Where(Function(Item) Item.Consolidado3 = ClaseServicio)
                            DetalleTottus.Id = ""
                            DetalleTottus.IdLiquidacion = ""
                            LiquidacionTottus.ListaLiquidacionDetalle.Add(DetalleTottus)
                        Next
                        LiquidacionTottus.TipoOperacion = "I"
                        LiquidacionTottus.IdCliente = oeLiquidaciones.IdCliente
                        LiquidacionTottus.Fecha = oeLiquidaciones.Fecha
                        LiquidacionTottus.SubTotal = LiquidacionTottus.ListaLiquidacionDetalle.Sum(Function(Item) Item.FleteUnitario)
                        LiquidacionTottus.Igv = LiquidacionTottus.SubTotal * oeLiquidaciones.Igv
                        LiquidacionTottus.Total = LiquidacionTottus.SubTotal + LiquidacionTottus.Igv
                        LiquidacionTottus.Observacion = "Liquidacion:" & oeLiquidaciones.Codigo & " " & oeLiquidaciones.Observacion & " - " & SubClase
                        LiquidacionTottus.IndFormato = 4
                        LiquidacionTottus.UsuarioCreacion = oeLiquidaciones.UsuarioCreacion
                        With LiquidacionTottus
                            stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_Liquidacion_IAE]",
                                        .TipoOperacion, .PrefijoID,
                                        .Id _
                                        , .Codigo _
                                        , .IdCliente _
                                        , .Fecha _
                                        , .IdMoneda _
                                        , .SubTotal _
                                        , .Igv _
                                        , .Total _
                                        , .TipoCambio _
                                        , .Observacion _
                                        , .IndFormato _
                                        , .IdEstado _
                                        , .UsuarioCreacion).ToString.Split("_")
                        End With
                        For Each LiquidacionDetalle As e_LiquidacionDetalle In LiquidacionTottus.ListaLiquidacionDetalle
                            LiquidacionDetalle.TipoOperacion = "I"
                            LiquidacionDetalle.IndFormato = LiquidacionTottus.IndFormato
                            LiquidacionDetalle.IdLiquidacion = stResultado(0)
                            GuardarLiquidacionDetalle(LiquidacionDetalle)
                        Next
                    Next
                    With oeLiquidaciones
                        stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_Liquidacion_IAE]",
                                    .TipoOperacion, .PrefijoID,
                                    .Id _
                                    , .Codigo _
                                    , .IdCliente _
                                    , .Fecha _
                                    , .IdMoneda _
                                    , .SubTotal _
                                    , .Igv _
                                    , .Total _
                                    , .TipoCambio _
                                    , .Observacion _
                                    , .IndFormato _
                                    , .IdEstado _
                                    , .UsuarioCreacion).ToString.Split("_")
                    End With
                Else
                    With oeLiquidaciones
                        stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_Liquidacion_IAE]",
                                    .TipoOperacion, .PrefijoID,
                                    .Id _
                                    , .Codigo _
                                    , .IdCliente _
                                    , .Fecha _
                                    , .IdMoneda _
                                    , .SubTotal _
                                    , .Igv _
                                    , .Total _
                                    , .TipoCambio _
                                    , .Observacion _
                                    , .IndFormato _
                                    , .IdEstado _
                                    , .UsuarioCreacion).ToString.Split("_")
                    End With
                    For Each LiquidacionDetalle As e_LiquidacionDetalle In oeLiquidaciones.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                        LiquidacionDetalle.TipoOperacion = "I"
                        LiquidacionDetalle.IndFormato = oeLiquidaciones.IndFormato
                        LiquidacionDetalle.IdLiquidacion = stResultado(0)
                        GuardarLiquidacionDetalle(LiquidacionDetalle)
                    Next
                End If
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeLiquidaciones As e_Liquidaciones) As Boolean
        Try
            With oeLiquidaciones
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_Liquidacion_IAE]", _
                                          .TipoOperacion, _
                                          "", _
                                          .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarLiquidacionDetalle(ByVal o_fila As DataRow) As e_LiquidacionDetalle
        Try
            Dim oeLiquidacionDetalle = New e_LiquidacionDetalle( _
                             o_fila("Seleccion").ToString _
                             , o_fila("Id").ToString _
                             , o_fila("IdLiquidacion").ToString _
                             , o_fila("Operacion").ToString _
                             , o_fila("IdOperacion").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("CodigoOrigen").ToString _
                             , o_fila("Origen").ToString _
                             , o_fila("CodigoDestino").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("Tracto").ToString _
                             , o_fila("Carreta").ToString _
                             , o_fila("Capacidad").ToString _
                             , o_fila("Volumen").ToString _
                             , o_fila("FleteUnitario").ToString _
                             , o_fila("TotalFlete").ToString _
                             , o_fila("Ruta").ToString _
                             , o_fila("NroCarga").ToString _
                             , o_fila("GuiaRemitente").ToString _
                             , o_fila("GuiaTransportista").ToString _
                             , o_fila("IndFacturado").ToString _
                             , o_fila("IndGrtConfirmada").ToString _
                             , o_fila("IndDocumentos").ToString _
                             , o_fila("IndGrtPerdido").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("TipoVehiculo").ToString _
                             , o_fila("Consolidado1").ToString _
                             , o_fila("Consolidado2").ToString _
                             , o_fila("Consolidado3").ToString _
                             , o_fila("Consolidado").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("FechaLlegada").ToString _
                             , o_fila("FechaSalida").ToString _
                             , o_fila("CentroCosto1").ToString _
                             , o_fila("CentroCosto2").ToString _
                             , o_fila("CentroCosto3").ToString)
            Return oeLiquidacionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerLiquidacionDetalle(ByVal oeLiquidacionDetalle As e_LiquidacionDetalle) As e_LiquidacionDetalle
        Try
            Dim ds As DataSet
            With oeLiquidacionDetalle
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_LiquidacionDetalle_Listar]", _
                                              .TipoOperacion, _
                                              .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeLiquidacionDetalle = CargarLiquidacionDetalle(ds.Tables(0).Rows(0))
            Else
                oeLiquidacionDetalle = New e_LiquidacionDetalle
            End If
            Return oeLiquidacionDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarLiquidacionDetalle(ByVal oeLiquidacioneDetalle As e_LiquidacionDetalle) As List(Of e_LiquidacionDetalle)
        Try
            Dim ldLiquidacioneDetalle As New List(Of e_LiquidacionDetalle)
            Dim ds As DataSet
            With oeLiquidacioneDetalle
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_LiquidacionDetalle_Listar]", _
                                                .TipoOperacion _
                                                , .Id _
                                                , .IdLiquidacion _
                                                , .FechaDesde _
                                                , .FechaHasta _
                                                , .IdCliente)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeLiquidacioneDetalle = CargarLiquidacionDetalle(o_Fila)
                    ldLiquidacioneDetalle.Add(oeLiquidacioneDetalle)
                Next
            Else
                ldLiquidacioneDetalle = New List(Of e_LiquidacionDetalle)
            End If
            Return ldLiquidacioneDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLiquidacionDetalle(ByVal oeLiquidacioneDetalle As e_LiquidacionDetalle) As Boolean
        Try
            With oeLiquidacioneDetalle
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_LiquidacionDetalle_IAE]",
                                          .TipoOperacion,
                                          .PrefijoID,
                                            .Id _
                                            , .IdLiquidacion _
                                            , .IdViaje _
                                            , .FleteUnitario _
                                            , .TotalFlete _
                                            , .Observacion _
                                            , .IdOperacion _
                                            , .Ruta _
                                            , .Consolidado2 _
                                            , .Consolidado3 _
                                            , .Consolidado _
                                            , .IdVehiculo _
                                            , .Capacidad _
                                            , .IndFormato _
                                            , .Consolidado1 _
                                            , .CentroCosto1 _
                                            , .CentroCosto2 _
                                            , .CentroCosto3 _
                                            , .Volumen)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarLiquidacionDetalle(ByVal oeLiquidacionDetalle As e_LiquidacionDetalle) As Boolean
        Try
            With oeLiquidacionDetalle

                sqlhelper.ExecuteNonQuery("[OPE].[Isp_LiquidacionDetalle_IAE]", _
                                            .TipoOperacion, _
                                            "", _
                                            .Id, _
                                            .IdLiquidacion, _
                                            .IdViaje)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
