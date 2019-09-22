Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Seguimiento
    Private sqlhelper As New SqlHelper

    Private odGuiaTransportista As New d_GuiaTransportista
    Private odFlte As New d_Flete
    Private odIncidenciaAutentificada As New d_IncidenciasAutentificadas
    Private odBitacora As New d_Bitacora

    Private Function CargarViajeRango(ByVal o_fila As DataRow) As e_Seguimiento
        Try
            Dim oeSeguimiento = New e_Seguimiento(o_fila("Id").ToString _
                              , o_fila("Codigo").ToString _
                             , o_fila("LlegadaDestino").ToString _
                             , o_fila("IdPiloto").ToString _
                              , o_fila("NombreCompleto").ToString _
                              , o_fila("KmTractoOrigen").ToString _
                              , o_fila("KmTractoDestino").ToString _
                              )
            Return oeSeguimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar(ByVal o_fila As DataRow) As e_Seguimiento
        Try
            Dim oeSeguimiento = New e_Seguimiento( _
                             o_fila("Id").ToString _
                             , o_fila("IdViaje").ToString _
                              , o_fila("LlegadaOrigen").ToString _
                             , o_fila("IndLlegadaOrigen").ToString _
                             , o_fila("IngresoComplejoOrigen").ToString _
                             , o_fila("IndIngresoComplejoOrigen").ToString _
                             , o_fila("CargaOrigen").ToString _
                             , o_fila("IndCargaOrigen").ToString _
                             , o_fila("TerminoCargaOrigen").ToString _
                             , o_fila("IndTerminoCargaOrigen").ToString _
                             , o_fila("ImpresionGuiaOrigen").ToString _
                             , o_fila("IndImpresionGuiaOrigen").ToString _
                             , o_fila("SalidaOrigen").ToString _
                             , o_fila("IndSalidaOrigen").ToString _
                             , o_fila("LlegadaAproximadaDestino").ToString _
                             , o_fila("IndLlegadaAproximadaDestino").ToString _
                             , o_fila("LlegadaDestino").ToString _
                             , o_fila("IndLlegadaDestino").ToString _
                             , o_fila("IngresoDestino").ToString _
                             , o_fila("IndIngresoDestino").ToString _
                             , o_fila("DescargaDestino").ToString _
                             , o_fila("IndDescargaDestino").ToString _
                             , o_fila("TerminoDescargaDestino").ToString _
                             , o_fila("IndTerminoDescargaDestino").ToString _
                             , o_fila("SalidaDestino").ToString _
                             , o_fila("IndSalidaDestino").ToString _
                             , o_fila("KmTractoOrigen").ToString _
                             , o_fila("KmTractoDestino").ToString _
                             , o_fila("KmCarretaOrigen").ToString _
                             , o_fila("KmCarretaDestino").ToString _
                             , o_fila("HorasRecorreOrigen").ToString _
                             , o_fila("HorasRecorreDestino").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("Incidencia").ToString _
                             , o_fila("PesoToneladas").ToString _
                             , o_fila("ViajeVacio").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("IdClienteLugar").ToString _
                             , o_fila("PilotoConf").ToString _
                             , o_fila("CopilotoConf").ToString _
                             , o_fila("TractoConf").ToString _
                             , o_fila("CarretaConf").ToString _
                             , o_fila("ClienteConf").ToString _
                             , o_fila("IndFallaOP").ToString _
                             , o_fila("FechaFalla").ToString _
                             , o_fila("GlosaFalla").ToString)
            Return oeSeguimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSeguimiento As e_Seguimiento) As e_Seguimiento
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Seguimiento_Listar]", _
                                          "", _
                                          oeSeguimiento.Id, _
                                          oeSeguimiento.IdViaje)
            If ds.Tables(0).Rows.Count > 0 Then
                oeSeguimiento = Cargar(ds.Tables(0).Rows(0))
            Else
                oeSeguimiento = New e_Seguimiento
            End If
            Return oeSeguimiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSeguimiento As e_Seguimiento) As List(Of e_Seguimiento)
        Try
            Dim ldSeguimiento As New List(Of e_Seguimiento)
            Dim ds As DataSet
            With oeSeguimiento
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Seguimiento_Listar]", "" _
                                    , .Id _
                                    , .IdViaje _
                                    , .IndLlegadaOrigen _
                                    , .IndIngresoComplejoOrigen _
                                    , .IndCargaOrigen _
                                    , .IndTerminoCargaOrigen _
                                    , .IndImpresionGuiaOrigen _
                                    , .IndSalidaOrigen _
                                    , .IndLlegadaAproximadaDestino _
                                    , .IndLlegadaDestino _
                                    , .IndIngresoDestino _
                                    , .IndDescargaDestino _
                                    , .IndTerminoDescargaDestino _
                                    , .IndSalidaDestino _
                                    , .IdEstado _
                                    , .IdOperacion)
            End With
            oeSeguimiento = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeSeguimiento = Cargar(o_Fila)
                    ldSeguimiento.Add(oeSeguimiento)
                Next
            Else
                ldSeguimiento = New List(Of e_Seguimiento)
            End If
            Return ldSeguimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar2(ByVal oeSeguimiento As e_Seguimiento) As List(Of e_Seguimiento)
        Try
            Dim ldSeguimiento As New List(Of e_Seguimiento)
            Dim ds As DataSet
            With oeSeguimiento
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Seguimiento_Listar]", .TipoOperacion _
                                    , .Id _
                                    , .IdViaje _
                                    , .IndLlegadaOrigen _
                                    , .IndIngresoComplejoOrigen _
                                    , .IndCargaOrigen _
                                    , .IndTerminoCargaOrigen _
                                    , .IndImpresionGuiaOrigen _
                                    , .IndSalidaOrigen _
                                    , .IndLlegadaAproximadaDestino _
                                    , .IndLlegadaDestino _
                                    , .IndIngresoDestino _
                                    , .IndDescargaDestino _
                                    , .IndTerminoDescargaDestino _
                                    , .IndSalidaDestino _
                                    , .IdEstado _
                                    , .IdOperacion)
            End With
            oeSeguimiento = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeSeguimiento = Cargar(o_Fila)
                    ldSeguimiento.Add(oeSeguimiento)
                Next
            Else
                ldSeguimiento = New List(Of e_Seguimiento)
            End If
            Return ldSeguimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar1(ByVal oeSeguimiento As e_Seguimiento) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeSeguimiento
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_Seguimiento_IAE]",
                                         .TipoOperacion,
                                         .PrefijoID,
                                       .Id _
                                       , .IdViaje _
                                , Date.Parse("01/01/1901") _
                                , .IndLlegadaOrigen _
                                , Date.Parse("01/01/1901") _
                                , .IndIngresoComplejoOrigen _
                                , Date.Parse("01/01/1901") _
                                , .IndCargaOrigen _
                                , Date.Parse("01/01/1901") _
                                , .IndTerminoCargaOrigen _
                                , Date.Parse("01/01/1901") _
                                , .IndImpresionGuiaOrigen _
                                , Date.Parse("01/01/1901") _
                                , .IndSalidaOrigen _
                                , Date.Parse("01/01/1901") _
                                , .IndLlegadaAproximadaDestino _
                                , Date.Parse("01/01/1901") _
                                , .IndLlegadaDestino _
                                , Date.Parse("01/01/1901") _
                                , .IndIngresoDestino _
                                , Date.Parse("01/01/1901") _
                                , .IndDescargaDestino _
                                , Date.Parse("01/01/1901") _
                                , .IndTerminoDescargaDestino _
                                , Date.Parse("01/01/1901") _
                                , .IndSalidaDestino _
                                , .KmTractoOrigen _
                                , .KmTractoDestino _
                                , .KmCarretaOrigen _
                                , .KmCarretaDestino _
                                , .HorasRecorreOrigen _
                                , .HorasRecorreDestino _
                               , .IdEstado _
                                , .UsuarioCreacion _
                                , .Observacion _
                                , .Incidencia _
                                , .PesoToneladas)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function Guardar(ByVal oeSeguimiento As e_Seguimiento) As Boolean
        Try
            'Dim oeViaje As New e_Viaje
            'Dim odViaje As New d_Operacion
            Dim oeVehiculo As New e_Vehiculo
            Dim odVehiculo As New d_Vehiculo
            Dim odGuiaTransportistaInterrumpida As New d_GuiaTransportistaInterrumpida

            Dim odOperacion As New d_Operacion

            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                With oeSeguimiento
                    If .TipoOperacion <> "G" Then
                        sqlhelper.ExecuteNonQuery("[OPE].[Isp_Seguimiento_IAE]",
                                  .TipoOperacion,
                                  .PrefijoID,
                                .Id _
                                , .IdViaje _
                                , .LlegadaOrigen _
                                , .IndLlegadaOrigen _
                                , .IngresoComplejoOrigen _
                                , .IndIngresoComplejoOrigen _
                                , .CargaOrigen _
                                , .IndCargaOrigen _
                                , .TerminoCargaOrigen _
                                , .IndTerminoCargaOrigen _
                                , .ImpresionGuiaOrigen _
                                , .IndImpresionGuiaOrigen _
                                , .SalidaOrigen _
                                , .IndSalidaOrigen _
                                , .LlegadaAproximadaDestino _
                                , .IndLlegadaAproximadaDestino _
                                , .LlegadaDestino _
                                , .IndLlegadaDestino _
                                , .IngresoDestino _
                                , .IndIngresoDestino _
                                , .DescargaDestino _
                                , .IndDescargaDestino _
                                , .TerminoDescargaDestino _
                                , .IndTerminoDescargaDestino _
                                , .SalidaDestino _
                                , .IndSalidaDestino _
                                , .KmTractoOrigen _
                                , .KmTractoDestino _
                                , .KmCarretaOrigen _
                                , .KmCarretaDestino _
                                , .HorasRecorreOrigen _
                                , .HorasRecorreDestino _
                                , .IdEstado _
                                , .UsuarioCreacion _
                                , .Observacion _
                                , .Incidencia _
                                , .PesoToneladas _
                                , .IngresoGRT _
                                , .Cantidad _
                                , .IdClienteLugar _
                                , .PilotoConf _
                                , .CopilotoConf _
                                , .TractoConf _
                                , .CarretaConf _
                                , .ClienteConf _
                                , .IndFallaOP _
                                , .FechaFalla _
                                , .GlosaFalla)
                    End If
                    If .oeListaBitacora.Count > 0 Then
                        odBitacora.Guardar(.oeListaBitacora)
                    End If
                End With

                If oeSeguimiento.TipoOperacion = "A" Then
                    'oeViaje = New e_Viaje
                    'oeViaje.Id = oeSeguimiento.IdViaje
                    'oeViaje.TipoOperacion = "1"
                    'oeViaje = odViaje.ObtenerViaje(oeViaje)

                    'If oeViaje.IndFecha <> 0 Then
                    ''Para El Tracto
                    'oeVehiculo = New e_Vehiculo
                    oeVehiculo.TipoOperacion = "O"
                    oeVehiculo.Id = oeSeguimiento.IdTracto
                    oeVehiculo.Odometro = oeSeguimiento.KmTractoDestino
                    oeVehiculo.Horometro = oeSeguimiento.HorasRecorreDestino
                    oeVehiculo.Activo = True
                    odVehiculo.Guardar(oeVehiculo)

                    ''Para la Carreta
                    oeVehiculo.TipoOperacion = "O"
                    oeVehiculo.Id = oeSeguimiento.IdCarreta
                    oeVehiculo.Odometro = oeSeguimiento.KmCarretaDestino
                    oeVehiculo.Horometro = 0
                    oeVehiculo.Activo = True
                    odVehiculo.Guardar(oeVehiculo)
                    ' End If

                    odGuiaTransportista.Guardar(oeSeguimiento)

                    If oeSeguimiento.GuiaTransportistaInterrumpida.Count > 0 Then
                        For Each GuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida In oeSeguimiento.GuiaTransportistaInterrumpida
                            odGuiaTransportistaInterrumpida.Guardar(GuiaTransportistaInterrumpida)
                        Next
                    End If

                    If oeSeguimiento.OperacionDetalle.Count > 0 Then
                        For Each OperacionDetalle As e_OperacionDetalle In oeSeguimiento.OperacionDetalle
                            OperacionDetalle.TipoOperacion = "I"
                            odOperacion.GuardarOperacionDetalle(OperacionDetalle)
                        Next
                    End If
                End If

                If oeSeguimiento.TipoOperacion = "G" Then
                    odGuiaTransportista.Guardar(oeSeguimiento)

                    If oeSeguimiento.GuiaTransportistaInterrumpida.Count > 0 Then
                        For Each GuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida In oeSeguimiento.GuiaTransportistaInterrumpida
                            odGuiaTransportistaInterrumpida.Guardar(GuiaTransportistaInterrumpida)
                        Next
                    End If
                    If oeSeguimiento.OperacionDetalle.Count > 0 Then
                        For Each OperacionDetalle As e_OperacionDetalle In oeSeguimiento.OperacionDetalle
                            OperacionDetalle.TipoOperacion = "G"
                            odOperacion.GuardarOperacionDetalle(OperacionDetalle)
                        Next
                    End If
                End If
                If oeSeguimiento.IncidenciaAutentificadas.IdResponsableAutoriza <> "" Then
                    With oeSeguimiento.IncidenciaAutentificadas
                        .TipoOperacion = "I"
                        .Referencia = oeSeguimiento.Id
                        .FechaReferencia = oeSeguimiento.LlegadaOrigen
                    End With
                    odIncidenciaAutentificada.Guardar(oeSeguimiento.IncidenciaAutentificadas)
                End If
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerSeguimientoRango(ByVal oeSeguimiento As e_Seguimiento) As e_Seguimiento
        Try
            Dim ds As DataSet
            With oeSeguimiento
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Seguimiento_Listar]", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdViaje, _
                                              .IndLlegadaOrigen, _
                                              .IndIngresoComplejoOrigen, _
                                              .IndCargaOrigen, _
                                              .IndTerminoCargaOrigen, _
                                              .IndImpresionGuiaOrigen, _
                                              .IndSalidaOrigen, _
                                              .IndLlegadaAproximadaDestino, _
                                              .IndLlegadaDestino, _
                                              .IndIngresoDestino, _
                                              .IndDescargaDestino, _
                                              .IndTerminoDescargaDestino, _
                                              .IndSalidaDestino, _
                                              .IdEstado, _
                                              .IdVehiculo, _
                                              .CantKm)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeSeguimiento = CargarViajeRango(ds.Tables(0).Rows(0))
            End If
            Return oeSeguimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Eliminar(ByVal oeSeguimiento As e_Seguimiento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_Seguimiento_IAE]", _
                                      "E", _
                                        "", _
                                        oeSeguimiento.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarImportar(ByVal listaViaje As List(Of e_Viaje)) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                For Each viaje In listaViaje
                    sqlhelper.ExecuteNonQuery("[OPE].[Isp_Seguimiento_IAE]" _
                                , "F" _
                                , viaje.PrefijoID _
                                , "" _
                                , viaje.Id _
                                , viaje.LlegadaOrigen _
                                , 1 _
                                , Date.Parse("01/01/1901") _
                                , 0 _
                                , Date.Parse("01/01/1901") _
                                , 0 _
                                , Date.Parse("01/01/1901") _
                                , 0 _
                                , Date.Parse("01/01/1901") _
                                , 0 _
                                , viaje.SalidaOrigen _
                                , 1 _
                                , Date.Parse("01/01/1901") _
                                , 0 _
                                , viaje.LlegadaDestino _
                                , 1 _
                                , Date.Parse("01/01/1901") _
                                , 0 _
                                , Date.Parse("01/01/1901") _
                                , 0 _
                                , Date.Parse("01/01/1901") _
                                , 0 _
                                , viaje.SalidaDestino _
                                , 1 _
                                , viaje.KmTractoOrigen _
                                , viaje.KmTractoDestino _
                                , 0 _
                                , 0 _
                                , 0 _
                                , 0 _
                                , viaje.IdEstado _
                                , viaje.UsuarioCreacion _
                                , "" _
                                , "" _
                                , viaje.PesoToneladas _
                                , 0 _
                                , viaje.Cantidad _
                                , "" _
                                , 0 _
                                , 0 _
                                , 0 _
                                , 0 _
                                , 0 _
                                , 0 _
                                , Date.Parse("01/01/1901") _
                                , "")
                Next

                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class