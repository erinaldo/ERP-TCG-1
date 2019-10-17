'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_Demanda

    Dim sqlhelper As New SqlHelper
    Dim odIncidenciaAutentificada As New d_IncidenciasAutentificadas
    Dim odViajeTercero As New d_ViajesTerceros
    Dim odBitacora As New d_Bitacora
    Dim fechaReferencia As Date
    Public Function Cargar(ByVal o_fila As DataRow) As e_Demanda
        Try
            Dim oeDemanda = New e_Demanda(o_fila("Seleccion").ToString, _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                            , o_fila("IdPreDemanda").ToString _
                            , o_fila("CodigoPreDemanda").ToString _
                             , o_fila("IdRuta").ToString _
                             , o_fila("Ruta").ToString _
                             , o_fila("IdTipoVehiculo").ToString _
                             , o_fila("TipoVehiculo").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("FechaAtendida").ToString _
                             , o_fila("TotalFlete").ToString _
                             , o_fila("TotalComision").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("Activo").ToString _
                            , o_fila("IdCliente").ToString _
                            , o_fila("Cliente").ToString _
                            , o_fila("Comisionista").ToString _
                            , o_fila("Comision").ToString _
                            , o_fila("Facturado").ToString _
                            , o_fila("PagoContraEntrega").ToString _
                            , o_fila("Zona").ToString _
                            , o_fila("CargaMaterial").ToString _
                            , o_fila("motivoEscala") _
                            , o_fila("idEscala") _
                            , o_fila("ObservacionPredemanda").ToString)            
            oeDemanda.FechaSolicita = IIf(o_fila("FechaSolicita").ToString = "", Date.Today, o_fila("FechaSolicita"))
            oeDemanda.FechaRecepcion = IIf(o_fila("FechaRecepcion").ToString = "", Date.Today, o_fila("FechaRecepcion"))
            oeDemanda.Indicador = o_fila("Indicador").ToString
            oeDemanda.Escala = o_fila("Escala").ToString
            oeDemanda.IndicadorTercero = o_fila("IndicadorTercero")
            oeDemanda.NroUnidades = o_fila("NroUnidades")
            Return oeDemanda
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDemanda As e_Demanda) As e_Demanda
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Demanda_Listar]",
                                            oeDemanda.TipoOperacion,
                                            oeDemanda.Id,
                                            oeDemanda.Codigo)

            If ds.Tables(0).Rows.Count > 0 Then
                oeDemanda = Cargar(ds.Tables(0).Rows(0))
            Else
                oeDemanda = New e_Demanda
            End If
            Return oeDemanda
        Catch ex As Exception
            Throw ex
        End Try
    End Function



    Public Function Listar(ByVal oeDemanda As e_Demanda) As List(Of e_Demanda)
        Try
            Dim ldDemanda As New List(Of e_Demanda)
            Dim ds As DataSet
            With oeDemanda
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Demanda_Listar]", .TipoOperacion _
                                            , .Id _
                                            , .Codigo _
                                            , .FechaDesde _
                                            , .FechaHasta _
                                            , .Activo _
                                            , .UsuarioCreacion _
                                            , .Zona)
            End With
            oeDemanda = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDemanda = Cargar(o_Fila)
                    ldDemanda.Add(oeDemanda)
                Next
            End If
            Return ldDemanda
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDataSet(ByVal oeDemanda As e_Demanda) As DataSet
        Try
            With oeDemanda
                Return sqlhelper.ExecuteDataset("[OPE].[Isp_Demanda_Listar]",
                                               .TipoOperacion,
                                               "",
                                               .Codigo,
                                               .FechaDesde,
                                               .FechaHasta,
                                               .Activo,
                                               .UsuarioCreacion)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDemandaRapidaDataSet(ByVal oeDemanda As e_Demanda) As DataSet
        Try
            With oeDemanda
                Return sqlhelper.ExecuteDataset("[OPE].[Isp_PreDemandaRapida_Listar]",
                                               .TipoOperacion,
                                               "",
                                               .Codigo,
                                               .FechaDesde,
                                               .FechaHasta,
                                               .Activo,
                                               .UsuarioCreacion,
                                               "",
                                               .Tipo,
                                               .Estado,
                                               .IndicadorTercero,
                                               .Indicador)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConfirmarDemanda(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            Using transScope As New TransactionScope()
                Dim ids = oeDemanda.Id.Split(";")
                For cont As Integer = 0 To ids.Count - 1
                    sqlhelper.ExecuteNonQuery("OPE.Isp_Demanda_IAE", "G",
            "", "", ids(cont), "", "", "", "", "", "", Nothing, 0, 0, "", oeDemanda.UsuarioCreacion)
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RevertirDemanda(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_Demanda_IAE", "R", _
             "", "", oeDemanda.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            Dim stResultado() As String
            odViajeTercero = New d_ViajesTerceros
            odIncidenciaAutentificada = New d_IncidenciasAutentificadas
            Using transScope As New TransactionScope()
                For I As Integer = 1 To oeDemanda.NroDemanda
                    With oeDemanda
                        stResultado = sqlhelper.ExecuteScalar("OPE.Isp_Demanda_IAE", "I",
                       .PrefijoID,
                        "A",
                       .Id,
                       .Codigo,
                       .IdPreDemanda,
                       .IdRuta,
                       .IdTipoVehiculo,
                       .IdEstado,
                       .Proceso,
                       .FechaAtendida,
                       .TotalFlete,
                       .TotalComision,
                       .Observacion,
                       .UsuarioCreacion,
                        .Activo
                        ).ToString.Split("_")


                    End With
                    For Each Detalle As e_DemandaDetalle In oeDemanda.oeDetalleDemanda
                        Detalle.IdDemanda = stResultado(0)
                        Detalle.PrefijoID = oeDemanda.PrefijoID '@0001
                        GuardarDetalle(Detalle)
                    Next
                    For Each ContratoTercero As e_ViajesTerceros In oeDemanda.oeContratoTercero
                        ContratoTercero.TipoOperacion = "I"
                        ContratoTercero.IdDemanda = stResultado(0)
                        ContratoTercero.UsuarioCrea = oeDemanda.UsuarioCreacion
                        ContratoTercero.PrefijoID = oeDemanda.PrefijoID '@0001
                        odViajeTercero.Guardar(ContratoTercero)
                    Next
                    If oeDemanda.oeIncidenciaAutentificadas.IdResponsableAutoriza <> "" Then
                        With oeDemanda.oeIncidenciaAutentificadas
                            .TipoOperacion = "I"
                            .Referencia = stResultado(0)
                            .FechaReferencia = oeDemanda.FechaAtendida
                            .PrefijoID = oeDemanda.PrefijoID '@0001
                        End With

                        odIncidenciaAutentificada.Guardar(oeDemanda.oeIncidenciaAutentificadas)
                    End If
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDetalle(ByVal oeDemandaDetalle As e_DemandaDetalle) As Boolean
        Try
            With oeDemandaDetalle
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_DemandaDetalle_IAE]", "I",
                                          .PrefijoID,
                                          .Id,
                                          .IdDemanda,
                                          .Cliente,
                                          .Comisionista,
                                          .IdTipoCarga,
                                          .Material,
                                          .Moneda,
                                          .Cantidad,
                                          .IncluyeIgv,
                                          .FleteUnitario,
                                          .Flete,
                                          .Comision,
                                          .Facturado,
                                          .PagoContraEntrega,
                                          .Activo,
                                          .IdOrigen,
                                          .IdDestino,
                                          .Cargar,
                                          .Descarga,
                                          .ClienteFinal)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDemandaPredemanda(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            Dim stResultado() As String
            odViajeTercero = New d_ViajesTerceros
            odIncidenciaAutentificada = New d_IncidenciasAutentificadas
            Dim IdsDemandas As String = ""
            Using transScope As New TransactionScope()
                If oeDemanda.Id <> "" And oeDemanda.oeListaBitacora.Count > 0 Then
                    odBitacora.Guardar(oeDemanda.oeListaBitacora, oeDemanda.PrefijoID)
                End If
                For I As Integer = 1 To oeDemanda.NroDemanda
                    With oeDemanda
                        fechaReferencia = oeDemanda.FechaAtendida
                        stResultado = sqlhelper.ExecuteScalar("OPE.Isp_Demanda_Predemanda_IAE", "I",
                       .PrefijoID,
                        "A",
                       .Id,
                       .Codigo,
                       .IdRuta,
                       .IdTipoVehiculo,
                       .Estado,
                       .Proceso,
                       .FechaAtendida,
                       .TotalFlete,
                       .TotalComision,
                       .Observacion,
                       .UsuarioCreacion,
                        .Activo,
                        .Indicador,
                        .FechaSolicita,
                        .IdOrigen,
                        .IdDestino,
                        .ObservacionPredemanda,
                        .EstadoPredemanda,
                        .Justificacion,
                        .NroUnidades,
                        .IdEscala,
                        .IdUsuarioCancelacion,
                        .MotivoEscala,
                        .FechaRecepcion,
                        .IndicadorTercero
                        ).ToString.Split("_")
                    End With

                    For Each Detalle As e_DemandaDetalle In oeDemanda.oeDetalleDemanda
                        Detalle.IdDemanda = stResultado(0)
                        '   oeDemanda.Id = stResultado(0)
                        Detalle.Usuario = oeDemanda.UsuarioCreacion
                        Detalle.PrefijoID = oeDemanda.PrefijoID '@0001
                        GuardarDetalleDemandaPredemanda(Detalle)
                    Next
                    For Each ContratoTercero As e_ViajesTerceros In oeDemanda.oeContratoTercero
                        ContratoTercero.TipoOperacion = "I"
                        ContratoTercero.IdDemanda = stResultado(0)
                        ContratoTercero.UsuarioCrea = oeDemanda.UsuarioCreacion
                        ContratoTercero.PrefijoID = oeDemanda.PrefijoID '@0001
                        odViajeTercero.Guardar(ContratoTercero)
                    Next
                    If oeDemanda.oeIncidenciaAutentificadas IsNot Nothing Then
                        If oeDemanda.oeIncidenciaAutentificadas.IdResponsableAutoriza <> "" Then
                            With oeDemanda.oeIncidenciaAutentificadas
                                .TipoOperacion = "I"
                                .Referencia = stResultado(0)
                                .FechaReferencia = oeDemanda.FechaAtendida
                                .PrefijoID = oeDemanda.PrefijoID '@0001
                            End With
                            odIncidenciaAutentificada.Guardar(oeDemanda.oeIncidenciaAutentificadas)
                        End If
                    End If
                    IdsDemandas = IdsDemandas + stResultado(0) + ";"
                Next                
                transScope.Complete()
            End Using
            oeDemanda.Id = IdsDemandas
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDetalleDemandaPredemanda(ByVal oeDemandaDetalle As e_DemandaDetalle) As Boolean
        Try
            Dim codigo As String
            With oeDemandaDetalle
                codigo = sqlhelper.ExecuteScalar("[OPE].[Isp_DemandaDetalle_DemandaPredemanda_IAE]", "I",
                                          .PrefijoID,
                                          .Id,
                                          .IdDemanda,
                                          .IdCliente,
                                          .Comisionista,
                                          .IdTipoCarga,
                                          .IdMaterial,
                                          .Moneda,
                                          .Cantidad,
                                          .IncluyeIgv,
                                          .FleteUnitario,
                                          .Flete,
                                          .Comision,
                                          .Facturado,
                                          .PagoContraEntrega,
                                          .Activo,
                                          .IdOrigen,
                                          .IdDestino,
                                          .Cargar,
                                          .Descarga,
                                          .IdClienteFinal,
                                          .Indicador,
                                          .IdDireccionLugarPartida,
                                          .IdDireccionLugarLlegada,
                                            .Consolidado,
                                            .MotivoConsolidado,
                                            .DireccionDestino,
                                            .DireccionOrigen,
                                            .CostoEstiba,
                                            .IncluyeIGVConsolidado,
                                            .Subtotal,
                                            .IGV,
                                            .AdelantoFlete,
                                            .CostoEstibaDescarga,
                                            .PagoEfectivoDeposito,
                                            .GlosaCostoEstiba,
                                            .Usuario,
                                            .FalsoFlete,
                                            .IdContactoCarga,
                                            .IdContactoDescarga
                                          )
            End With
            If oeDemandaDetalle.oeIncidenciaAutentificadas IsNot Nothing Then
                If oeDemandaDetalle.oeIncidenciaAutentificadas.IdResponsableAutoriza <> "" Then
                    With oeDemandaDetalle.oeIncidenciaAutentificadas
                        .TipoOperacion = "I"
                        .Referencia = codigo
                        .FechaReferencia = fechaReferencia
                        .PrefijoID = oeDemandaDetalle.PrefijoID '@0001
                    End With
                    odIncidenciaAutentificada.Guardar(oeDemandaDetalle.oeIncidenciaAutentificadas)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_Demanda_IAE]",
                                      "E",
                                      "",
                                      "",
                                      oeDemanda.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Cancelar(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            odIncidenciaAutentificada = New d_IncidenciasAutentificadas
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_Demanda_IAE]",
                                                                 oeDemanda.TipoOperacion _
                                                                 , "", "",
                                                                 oeDemanda.Id, "", "", "", "", "", "",
                                                                 Date.Parse("01/01/1901"), 0, 0,
                                                                 oeDemanda.Observacion,
                                                                 oeDemanda.UsuarioCreacion).ToString.Split("_")

                If oeDemanda.oeIncidenciaAutentificadas.IdResponsableAutoriza <> "" Then
                    With oeDemanda.oeIncidenciaAutentificadas
                        .TipoOperacion = "I"
                        .Referencia = stResultado(0)
                        .FechaReferencia = oeDemanda.FechaAtendida
                    End With
                    odIncidenciaAutentificada.Guardar(oeDemanda.oeIncidenciaAutentificadas)
                End If
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarDetalle(ByVal o_fila As DataRow) As e_DemandaDetalle
        Try
            Dim oeDemandaDetalle = New e_DemandaDetalle(o_fila("Id").ToString, _
                                o_fila("IdDemanda").ToString, _
                                o_fila("IdCliente").ToString, _
                                o_fila("Cliente").ToString, _
                                o_fila("Comisionista").ToString, _
                                o_fila("IdTipoCarga").ToString, _
                                o_fila("IdMaterial").ToString, _
                                o_fila("Moneda").ToString, _
                                o_fila("Cantidad").ToString, _
                                o_fila("IncluyeIgv").ToString, _
                                o_fila("FleteUnitario").ToString, _
                                o_fila("Flete").ToString, _
                                o_fila("Comision").ToString, _
                                o_fila("Facturado").ToString, _
                                o_fila("PagoContraEntrega").ToString, _
                                o_fila("Activo").ToString, _
                                o_fila("idOrigen").ToString, _
                                 o_fila("idDestino").ToString, _
                                o_fila("Cargar").ToString, _
                                o_fila("Descarga").ToString, _
                                o_fila("IdClienteFinal").ToString, _
                                o_fila("ClienteFinal").ToString, _
                                o_fila("consolidado").ToString, _
                                o_fila("motivoConsolidado").ToString, _
                                o_fila("direcciondestino").ToString, _
                                o_fila("direccionOrigen").ToString, _
                                o_fila("idDireccionLugarPartida").ToString, _
                                o_fila("idDireccionLugarLlegada").ToString, _
                                o_fila("Origen").ToString, _
                                o_fila("Destino").ToString, _
                                o_fila("incluyeIGVConsolidado"), _
                                o_fila("costoEstiba"), _
                                o_fila("subtotal")
                            )
            oeDemandaDetalle.TipoCarga = o_fila("Carga").ToString
            oeDemandaDetalle.IdMaterial = o_fila("IdMaterial").ToString
            oeDemandaDetalle.Material = o_fila("Material").ToString
            oeDemandaDetalle.DireccionLugarLlegada = o_fila("DireccionLugarLlegada").ToString
            oeDemandaDetalle.DireccionLugarPartida = o_fila("DireccionLugarPartida").ToString
            oeDemandaDetalle.IGV = o_fila("IGV").ToString
            oeDemandaDetalle.AdelantoFlete = o_fila("adelantoFlete")
            oeDemandaDetalle.Programado = o_fila("Programado")
            oeDemandaDetalle.PorProgramar = o_fila("PorProgramar")
            oeDemandaDetalle.CostoEstibaDescarga = o_fila("CostoEstibaDescarga")
            oeDemandaDetalle.PagoEfectivoDeposito = o_fila("PagoEfectivoDeposito")
            oeDemandaDetalle.GlosaCostoEstiba = o_fila("GlosaCostoEstiba")
            oeDemandaDetalle.FalsoFlete = o_fila("FalsoFlete")
            oeDemandaDetalle.Usuario = CStr(o_fila("FleteUnitario") + (o_fila("IGV")))
            '  oeDemandaDetalle.Usuario = Me.usuario
            oeDemandaDetalle.IdContactoCarga = o_fila("IdContactoCarga")
            oeDemandaDetalle.IdContactoDescarga = o_fila("IdContactoDescarga")
            Return oeDemandaDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDetalle(ByVal oeDemandaDetalle As e_DemandaDetalle) As e_DemandaDetalle
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_DemandaDetalle_Listar", "",
                                          oeDemandaDetalle.Id,
                                          oeDemandaDetalle.IdDemanda)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDemandaDetalle = CargarDetalle(ds.Tables(0).Rows(0))
                Return oeDemandaDetalle
            Else
                oeDemandaDetalle = New e_DemandaDetalle
                Return oeDemandaDetalle
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Dim usuario As String = ""
    Public Function ListarDetalle(ByVal oeDemandaDetalle As e_DemandaDetalle, Optional ByVal Usuario As String = "") As List(Of e_DemandaDetalle)
        Try
            Me.usuario = Usuario
            Dim ldDemandaDetalle As New List(Of e_DemandaDetalle)
            Dim ds As DataSet
            With oeDemandaDetalle
                ds = sqlhelper.ExecuteDataset("OPE.Isp_DemandaDetalle_Listar", _
                                              .TipoOperacion _
                                                , .Id _
                                                , .IdDemanda _
                                                , .Activo)
            End With
            oeDemandaDetalle = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDemandaDetalle = CargarDetalle(o_Fila)
                    ldDemandaDetalle.Add(oeDemandaDetalle)
                Next
                Return ldDemandaDetalle
            Else
                ldDemandaDetalle = New List(Of e_DemandaDetalle)
                Return ldDemandaDetalle
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDemandasEnviadas(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            Using transScope As New TransactionScope()
                Dim ids = oeDemanda.Id.Split(";")
                For cont As Integer = 0 To ids.Count - 1

                    sqlhelper.ExecuteNonQuery("OPE.Isp_Demanda_IAE", "K",
                     "", "", ids(cont), "", "", "", "", "", "", Nothing, 0, 0, "", oeDemanda.UsuarioCreacion)
                Next
                transScope.Complete()
            End Using


            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GuardarObservacion(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            sqlhelper = New SqlHelper
            sqlhelper.ExecuteNonQuery("OPE.Isp_Demanda_Predemanda_IAE", oeDemanda.TipoOperacion, _
             "", "", oeDemanda.Id, "", "", "", "", "", Nothing, 0, 0, oeDemanda.Observacion, oeDemanda.UsuarioCreacion)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
