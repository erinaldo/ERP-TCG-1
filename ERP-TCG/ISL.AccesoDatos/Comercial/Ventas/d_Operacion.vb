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

Public Class d_Operacion

    Public connectionString As String = d_Conexion.CadenaConexionSGI()

    Private sqlhelper As New SqlHelper
    Dim odSeguimiento As New d_Seguimiento
    Dim oeSeguimiento As New e_Seguimiento
    Dim odMovimiento As New d_Movimiento
    Dim oeMovimiento As New e_Movimiento
    Dim odMovimiento_Viaje As New d_Movimiento_Viaje
    Dim oeMovimiento_Viaje As New e_Movimiento_Viaje
    Dim odIncidenciaAutentificada As New d_IncidenciasAutentificadas
    Dim odProcesarTarifasProceso As New d_ProcesarTarifasProceso
    Dim odViajeTercero As New d_ViajesTerceros
    Dim odBitacora As New d_Bitacora

    Private Function Cargar(ByVal o_fila As DataRow) As e_Operacion
        Try
            Dim oeOperacion = New e_Operacion( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdRuta").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("TotalFlete").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IndFormato").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("FleteUnitario").ToString _
                             , o_fila("IdActividadNegocio").ToString)
            oeOperacion.IdTipoVehiculo = o_fila("IdTipoVehiculo").ToString
            oeOperacion.IndGuiaTercero = o_fila("IndGuiaTercero").ToString
            Return oeOperacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOperacion As e_Operacion) As e_Operacion
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Operacion_Listar]",
                                            "",
                                            oeOperacion.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeOperacion = Cargar(ds.Tables(0).Rows(0))
            Else
                oeOperacion = New e_Operacion
            End If

            Return oeOperacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeOperacion As e_Operacion) As List(Of e_Operacion)
        Try
            Dim ldOperacion As New List(Of e_Operacion)
            Dim ds As DataSet
            With oeOperacion
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Operacion_Listar]", "" _
                        , .Id _
                        , .Codigo _
                        , .IdRuta _
                        , .IdEstado _
                        , .Fecha _
                        , .UsuarioCreacion)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOperacion = Cargar(o_Fila)
                    ldOperacion.Add(oeOperacion)
                Next
            Else
                ldOperacion = New List(Of e_Operacion)
            End If
            Return ldOperacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Dim fechaReferencia As Date

    Public Function Guardar(ByVal oeOperacion As e_Operacion) As Boolean
        Try
            odViajeTercero = New d_ViajesTerceros
            odSeguimiento = New d_Seguimiento
            oeSeguimiento = New e_Seguimiento
            odMovimiento = New d_Movimiento
            odMovimiento_Viaje = New d_Movimiento_Viaje
            odIncidenciaAutentificada = New d_IncidenciasAutentificadas

            Dim stResultado() As String
            Dim stResultado1 As String = String.Empty
            Dim Tracto As String = ""
            Dim TractoEscala As String = "T"
            Dim Escala As Integer = 0
            Dim Operacion As String = ""
            Dim fecViaje As Date

            Using transScope As New TransactionScope()
                If Not oeOperacion.ProgramarBloque Then
                    For I As Integer = 1 To oeOperacion.NroOperacionVueltas
                        With oeOperacion
                            fechaReferencia = .Fecha
                            stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_Operacion_IAE]",
                                    .Tipooperacion,
                                    .PrefijoID,
                                    "A",
                                    .Id _
                                    , .Codigo _
                                    , .IdRuta _
                                    , .IdEstado _
                                    , .TotalFlete _
                                    , .Observacion _
                                    , .Fecha _
                                    , .UsuarioCreacion _
                                    , .IndFormato _
                                    , .ActidadNegocio _
                                    , .Cantidad _
                                    , .FleteUnitario _
                                    , .IdTipoVehiculo _
                                    , .IndGuiaTercero).ToString.Split("_")
                        End With
                        For Each OperacionDetalle As e_OperacionDetalle In oeOperacion.oeOperacionDetalle
                            OperacionDetalle.IdOperacion = stResultado(0)
                            OperacionDetalle.TipoOperacion = "I"
                            OperacionDetalle.UsuarioCreacion = oeOperacion.UsuarioCreacion
                            OperacionDetalle.PrefijoID = oeOperacion.PrefijoID '@0001
                            GuardarOperacionDetalle(OperacionDetalle)
                        Next

                        For Each ContratoTercero As e_ViajesTerceros In oeOperacion.oeContratoTercero
                            ContratoTercero.TipoOperacion = "I"
                            ContratoTercero.IdOperacion = stResultado(0)
                            ContratoTercero.UsuarioCrea = oeOperacion.UsuarioCreacion
                            ContratoTercero.PrefijoID = oeOperacion.PrefijoID '@0001
                            odViajeTercero.Guardar(ContratoTercero)
                        Next
                        Dim c As Integer = 1
                        For Each Viaje As e_Viaje In oeOperacion.oeViaje
                            'MOVIMIENTO ACTUALIZA CUENTA DE BOLSA                           '
                            Viaje.PrefijoID = oeOperacion.PrefijoID '@0001
                            Viaje.IndFormato = oeOperacion.IndFormato
                            Viaje.IdOperacion = stResultado(0)
                            Viaje.Carga = oeOperacion.oeOperacionDetalle.Count
                            Viaje.UsuarioCreacion = oeOperacion.UsuarioCreacion
                            fecViaje = Viaje.Fecha
                            If I > 1 Then
                                'Dim fecViaje As Date
                                fecViaje = DateAdd(DateInterval.Hour, 4, Date.Parse(Viaje.Fecha.ToShortDateString & " " & Viaje.Fecha.ToShortTimeString))
                                Viaje.Fecha = fecViaje
                            End If
                            Viaje.TipoOperacion = oeOperacion.Tipooperacion
                            stResultado1 = GuardarViaje(Viaje)

                            ' INSERTAR SEGUIMIENTO PARA CALL CENTER
                            If Viaje.Id.Trim = "" Then
                                With oeSeguimiento
                                    .IdViaje = stResultado1
                                    .TipoOperacion = "I"
                                    .LlegadaOrigen = Viaje.Fecha
                                    .IngresoComplejoOrigen = Viaje.Fecha
                                    .CargaOrigen = Viaje.Fecha
                                    .TerminoCargaOrigen = Viaje.Fecha
                                    .ImpresionGuiaOrigen = Viaje.Fecha
                                    .SalidaOrigen = Viaje.Fecha
                                    .LlegadaAproximadaDestino = Viaje.Fecha
                                    .LlegadaDestino = Viaje.Fecha
                                    .IngresoDestino = Viaje.Fecha
                                    .DescargaDestino = Viaje.Fecha
                                    .TerminoDescargaDestino = Viaje.Fecha
                                    .SalidaDestino = Viaje.Fecha
                                    .UsuarioCreacion = Viaje.UsuarioCreacion
                                    .FechaFalla = Viaje.Fecha
                                End With
                                oeSeguimiento.PrefijoID = oeOperacion.PrefijoID '@0001
                                odSeguimiento.Guardar(oeSeguimiento)
                            End If
                            ' INSERTAR PARA HABILITAR BOLSA DE VIAJE
                            If Viaje.Id.Trim = "" Then
                                oeMovimiento = New e_Movimiento
                                With oeMovimiento
                                    .TipoProceso = "PENDIENTE"
                                    .TipoOperacion = "I"
                                    .Id = ""
                                    .Fecha = Viaje.Fecha
                                    .IdCuentaCorrienteOrigen = ""
                                    .IdCuentaCorrienteDestino = ""
                                    .Ingreso = 0
                                    .Egreso = 0
                                    .Saldo = 0
                                    .Glosa = ""
                                    .Voucher = ""
                                    .Descuento = 0
                                    .TipoMovimiento = 1
                                    .IdEstado = "PENDIENTE"
                                    .Activo = True
                                    .TipoTransa = 1
                                    .UsuarioCreacion = Viaje.UsuarioCreacion
                                    .oeMovimientoViaje = New e_Movimiento_Viaje
                                    .oeMovimientoViaje.IdViaje = stResultado1
                                End With
                                oeMovimiento.PrefijoID = oeOperacion.PrefijoID '@0001
                                oeMovimiento.oeMovimientoViaje.PrefijoID = oeOperacion.PrefijoID '@0001
                                odMovimiento.GuardarMovimiento(oeMovimiento, New e_Movimiento)
                            End If
                            Dim odDespachoOperaciones As New d_DespachoOperaciones
                            Dim oeDespachoOperaciones As e_DespachoOperaciones = Nothing
                            'Actualizar IdViaje en Tabla DespachoOperaciones
                            If c = 1 AndAlso String.IsNullOrWhiteSpace(Viaje.Id) AndAlso Not String.IsNullOrWhiteSpace(Viaje.IdDespachoOperaciones) Then
                                oeDespachoOperaciones = New e_DespachoOperaciones
                                oeDespachoOperaciones.PrefijoID = oeOperacion.PrefijoID '@0001
                                oeDespachoOperaciones.Id = Viaje.IdDespachoOperaciones
                                oeDespachoOperaciones = odDespachoOperaciones.Obtener(oeDespachoOperaciones)
                                If Not String.IsNullOrWhiteSpace(oeDespachoOperaciones.Id) Then
                                    oeDespachoOperaciones.TipoOperacion = "I"
                                    oeDespachoOperaciones.IdViaje = stResultado1
                                    oeDespachoOperaciones.UsuarioCrea = Viaje.UsuarioCreacion
                                    oeDespachoOperaciones.PrefijoID = oeOperacion.PrefijoID '@0001
                                    odDespachoOperaciones.Guardar(oeDespachoOperaciones)
                                End If
                            End If
                            'If c > 1 AndAlso String.IsNullOrWhiteSpace(Viaje.Id) AndAlso Not String.IsNullOrWhiteSpace(Viaje.IdDespachoOperaciones) Then
                            '    oeDespachoOperaciones = New e_DespachoOperaciones
                            '    oeDespachoOperaciones.Id = Viaje.IdDespachoOperaciones
                            '    oeDespachoOperaciones = odDespachoOperaciones.Obtener(oeDespachoOperaciones)
                            '    If Not String.IsNullOrWhiteSpace(oeDespachoOperaciones.Id) Then
                            '        'Genera un registro de Despacho Operaciones con los mismos datos colocando la Escala como Origen  
                            '        Dim oeDespGenerado As New e_DespachoOperaciones
                            '        With oeDespGenerado
                            '            .TipoOperacion = "I"
                            '            .IdDespacho = oeDespachoOperaciones.IdDespacho
                            '            .Piloto = oeDespachoOperaciones.Piloto
                            '            .Copiloto = oeDespachoOperaciones.Copiloto
                            '            .IdTracto = oeDespachoOperaciones.IdTracto
                            '            .Carreta = oeDespachoOperaciones.Carreta
                            '            .Zona = oeDespachoOperaciones.Zona
                            '            .Origen = oeDespachoOperaciones.IdEscala
                            '            .Destino = oeDespachoOperaciones.Destino
                            '            .Estado = oeDespachoOperaciones.Estado
                            '            .Cliente = oeDespachoOperaciones.Cliente
                            '            .Tonelada = oeDespachoOperaciones.Tonelada
                            '            .Monto = oeDespachoOperaciones.Monto
                            '            .Hora = oeDespachoOperaciones.Hora.AddHours(4)
                            '            .NroCelular = oeDespachoOperaciones.NroCelular
                            '            .IdMarcaVehiculo = oeDespachoOperaciones.IdMarcaVehiculo
                            '            .UsuarioCrea = Viaje.UsuarioCreacion
                            '            .IdViaje = stResultado1
                            '        End With
                            '        odDespachoOperaciones.Guardar(oeDespGenerado)
                            '    End If
                            'End If
                            c += 1
                        Next
                    Next
                Else
                    For I As Integer = 1 To oeOperacion.NroOperacionVueltas
                        For Each Viaje As e_Viaje In oeOperacion.oeViaje
                            Viaje.PrefijoID = oeOperacion.PrefijoID '@0001
                            Tracto = Viaje.Tracto
                            Escala = Viaje.IndEscala
                            If Escala = 0 Then
                                With oeOperacion
                                    stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_Operacion_IAE]",
                                            .Tipooperacion,
                                            .PrefijoID,
                                            "A",
                                            .Id _
                                            , .Codigo _
                                            , .IdRuta _
                                            , .IdEstado _
                                            , .TotalFlete _
                                            , .Observacion _
                                            , .Fecha _
                                            , .UsuarioCreacion _
                                            , .IndFormato _
                                            , .ActidadNegocio).ToString.Split("_")
                                End With
                                For Each OperacionDetalle As e_OperacionDetalle In oeOperacion.oeOperacionDetalle
                                    OperacionDetalle.IdOperacion = stResultado(0)
                                    OperacionDetalle.TipoOperacion = oeOperacion.Tipooperacion
                                    OperacionDetalle.UsuarioCreacion = oeOperacion.UsuarioCreacion
                                    OperacionDetalle.PrefijoID = oeOperacion.PrefijoID '@0001
                                    GuardarOperacionDetalle(OperacionDetalle)
                                Next
                                For Each ContratoTercero As e_ViajesTerceros In oeOperacion.oeContratoTercero
                                    ContratoTercero.TipoOperacion = "I"
                                    ContratoTercero.IdOperacion = stResultado(0)
                                    ContratoTercero.UsuarioCrea = oeOperacion.UsuarioCreacion
                                    ContratoTercero.PrefijoID = oeOperacion.PrefijoID '@0001
                                    odViajeTercero.Guardar(ContratoTercero)
                                Next
                                Viaje.IdOperacion = stResultado(0)
                                Operacion = Viaje.IdOperacion
                            Else
                                If TractoEscala <> Viaje.Tracto Then
                                    With oeOperacion
                                        stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_Operacion_IAE]",
                                                .Tipooperacion,
                                                .PrefijoID,
                                                "A",
                                                .Id _
                                                , .Codigo _
                                                , .IdRuta _
                                                , .IdEstado _
                                                , .TotalFlete _
                                                , .Observacion _
                                                , .Fecha _
                                                , .UsuarioCreacion _
                                                , .IndFormato _
                                                , .ActidadNegocio _
                                                , .Cantidad _
                                                , .FleteUnitario).ToString.Split("_")
                                    End With

                                    For Each OperacionDetalle As e_OperacionDetalle In oeOperacion.oeOperacionDetalle
                                        OperacionDetalle.IdOperacion = stResultado(0)
                                        OperacionDetalle.TipoOperacion = oeOperacion.Tipooperacion
                                        OperacionDetalle.UsuarioCreacion = oeOperacion.UsuarioCreacion
                                        OperacionDetalle.PrefijoID = oeOperacion.PrefijoID '@0001
                                        GuardarOperacionDetalle(OperacionDetalle)
                                    Next
                                    For Each ContratoTercero As e_ViajesTerceros In oeOperacion.oeContratoTercero
                                        ContratoTercero.TipoOperacion = "I"
                                        ContratoTercero.IdOperacion = stResultado(0)
                                        ContratoTercero.UsuarioCrea = oeOperacion.UsuarioCreacion
                                        ContratoTercero.PrefijoID = oeOperacion.PrefijoID '@0001
                                        odViajeTercero.Guardar(ContratoTercero)
                                    Next
                                    Viaje.IdOperacion = stResultado(0)
                                    Operacion = Viaje.IdOperacion
                                End If

                            End If
                            Viaje.IndFormato = oeOperacion.IndFormato
                            Viaje.IdOperacion = Operacion
                            Viaje.Carga = oeOperacion.oeOperacionDetalle.Count
                            Viaje.UsuarioCreacion = oeOperacion.UsuarioCreacion
                            fecViaje = Viaje.Fecha
                            If I > 1 Then
                                'Dim fecViaje As Date
                                'For Each ViajeBloque As e_Viaje In oeOperacion.oeViaje.Where(Function(item) item.Tracto = Tracto)
                                'horaViaje = ViajeBloque.Fecha.AddHours(5).ToShortTimeString
                                fecViaje = DateAdd(DateInterval.Hour, 4, Date.Parse(Viaje.Fecha.ToShortDateString & " " & Viaje.Fecha.ToShortTimeString))
                                'Next
                                Viaje.Fecha = fecViaje
                            End If
                            Viaje.TipoOperacion = oeOperacion.Tipooperacion
                            Viaje.PrefijoID = oeOperacion.PrefijoID '@0001
                            stResultado1 = GuardarViaje(Viaje)

                            ' INSERTAR SEGUIMIENTO PARA CALL CENTER
                            If Viaje.Id.Trim = "" Then
                                With oeSeguimiento
                                    .IdViaje = stResultado1
                                    .TipoOperacion = "I"
                                    .LlegadaOrigen = Viaje.Fecha
                                    .IngresoComplejoOrigen = Viaje.Fecha
                                    .CargaOrigen = Viaje.Fecha
                                    .TerminoCargaOrigen = Viaje.Fecha
                                    .ImpresionGuiaOrigen = Viaje.Fecha
                                    .SalidaOrigen = Viaje.Fecha
                                    .LlegadaAproximadaDestino = Viaje.Fecha
                                    .LlegadaDestino = Viaje.Fecha
                                    .IngresoDestino = Viaje.Fecha
                                    .DescargaDestino = Viaje.Fecha
                                    .TerminoDescargaDestino = Viaje.Fecha
                                    .SalidaDestino = Viaje.Fecha
                                    .UsuarioCreacion = Viaje.UsuarioCreacion
                                    .FechaFalla = Viaje.Fecha
                                End With
                                oeSeguimiento.PrefijoID = oeOperacion.PrefijoID '@0001
                                odSeguimiento.Guardar(oeSeguimiento)
                            End If
                            ' INSERTAR PARA HABILITAR BOLSA DE VIAJE
                            If Viaje.Id.Trim = "" Then
                                oeMovimiento = New e_Movimiento
                                With oeMovimiento
                                    .TipoProceso = "PENDIENTE"
                                    .TipoOperacion = "I"
                                    .Id = ""
                                    .Fecha = Date.Now
                                    .IdCuentaCorrienteOrigen = ""
                                    .IdCuentaCorrienteDestino = ""
                                    .Ingreso = 0
                                    .Egreso = 0
                                    .Saldo = 0
                                    .Glosa = ""
                                    .Voucher = ""
                                    .Descuento = 0
                                    .TipoMovimiento = 1
                                    .IdEstado = "PENDIENTE"
                                    .Activo = True
                                    .TipoTransa = 1
                                    .UsuarioCreacion = Viaje.UsuarioCreacion
                                    .oeMovimientoViaje = New e_Movimiento_Viaje
                                    .oeMovimientoViaje.IdViaje = stResultado1
                                End With
                                oeMovimiento.PrefijoID = oeOperacion.PrefijoID '@0001
                                oeMovimiento.oeMovimientoViaje.PrefijoID = oeOperacion.PrefijoID '@0001
                                odMovimiento.GuardarMovimiento(oeMovimiento, New e_Movimiento)
                            End If
                            TractoEscala = Viaje.Tracto
                        Next
                        TractoEscala = "T"
                    Next
                End If
                If oeOperacion.oeIncidenciaAutentificadas.IdResponsableAutoriza <> "" Then
                    With oeOperacion.oeIncidenciaAutentificadas
                        .TipoOperacion = "I"
                        .Referencia = stResultado1
                        .FechaReferencia = fecViaje
                    End With
                    oeOperacion.oeIncidenciaAutentificadas.PrefijoID = oeOperacion.PrefijoID '@0001
                    odIncidenciaAutentificada.Guardar(oeOperacion.oeIncidenciaAutentificadas)
                End If
                If oeOperacion.Id <> "" Then
                    odBitacora.Guardar(oeOperacion.oeListaBitacora, oeOperacion.PrefijoID)
                End If
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOperacion As e_Operacion) As Boolean
        Try
            Dim resultado As Boolean = False
            If sqlhelper.ExecuteNonQuery("[OPE].[Isp_Operacion_IAE]",
                                         "E",
                                         "",
                                         oeOperacion.Id) > 0 Then
                resultado = True
            End If
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizaLista(ByVal oeViaje As e_Viaje) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_Viaje_IAE]",
                                      "P",
                                      "",
                                      "", oeViaje.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarViaje(ByVal o_fila As DataRow) As e_Viaje
        Try
            Dim oeViaje = New e_Viaje(o_fila("Seleccion").ToString, _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdOperacion").ToString _
                             , o_fila("Operacion").ToString _
                             , o_fila("IdOrigen").ToString _
                             , o_fila("Origen").ToString _
                             , o_fila("IdDestino").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("IdEscala").ToString _
                             , o_fila("Escala").ToString _
                             , o_fila("IndEscala").ToString _
                             , o_fila("ViajeVacio").ToString _
                             , o_fila("ViajeRetorno").ToString _
                             , o_fila("IdPiloto").ToString _
                             , o_fila("Piloto").ToString _
                             , o_fila("DisponibleP").ToString _
                             , o_fila("IdCopiloto").ToString _
                             , o_fila("Copiloto").ToString _
                             , o_fila("DisponibleC").ToString _
                             , o_fila("IdAyudante").ToString _
                             , o_fila("Ayudante").ToString _
                             , o_fila("DisponibleA").ToString _
                             , o_fila("IdTracto").ToString _
                             , o_fila("Tracto").ToString _
                             , o_fila("IdTipoVehiculo").ToString _
                             , o_fila("TipoVehiculo").ToString _
                             , o_fila("IdCarreta").ToString _
                             , o_fila("Carreta").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Cliente").ToString _
                             , o_fila("CargaMaterial").ToString _
                             , o_fila("GlosaEscala").ToString _
                             , o_fila("Carga").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("UsuarioSeguimiento").ToString _
                             , o_fila("LlegadaOrigen").ToString _
                             , o_fila("IngresoComplejoOrigen").ToString _
                             , o_fila("CargaOrigen").ToString _
                             , o_fila("TerminoCargaOrigen").ToString _
                             , o_fila("ImpresionGuiaOrigen").ToString _
                             , o_fila("SalidaOrigen").ToString _
                             , o_fila("LlegadaAproximadaDestino").ToString _
                             , o_fila("LlegadaDestino").ToString _
                             , o_fila("IngresoDestino").ToString _
                             , o_fila("DescargaDestino").ToString _
                             , o_fila("TerminoDescargaDestino").ToString _
                             , IIf(o_fila("SalidaDestino").ToString = "", Nothing, o_fila("SalidaDestino")) _
                             , o_fila("Flota").ToString _
                             , o_fila("IncidenciaOperaciones").ToString _
                             , o_fila("IncidenciaSeguimiento").ToString _
                             , o_fila("Turno").ToString _
                             , o_fila("DiaNoche").ToString _
                             , o_fila("PesoToneladas").ToString _
                             , o_fila("TotalFlete").ToString _
                             , o_fila("Zona").ToString _
                             , o_fila("KmTractoOrigen").ToString _
                             , o_fila("KmTractoDestino").ToString _
                             , o_fila("KmCarretaOrigen").ToString _
                             , o_fila("KmCarretaDestino").ToString _
                             , o_fila("Tesoreria").ToString _
                             , o_fila("IndFecha").ToString _
                             , o_fila("PorcentajeFlete").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("FleteUnitario").ToString _
                             , o_fila("IncluyeIgv").ToString _
                             , o_fila("Capacidad").ToString _
                             , o_fila("IndCarga").ToString _
                             , o_fila("Produccion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("IndPlanilla").ToString _
                             , o_fila("IdCentro").ToString)
            Return oeViaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarViajeRango(ByVal o_fila As DataRow) As e_Viaje
        Try
            Dim oeViaje = New e_Viaje(o_fila("Id").ToString _
                              , o_fila("Codigo").ToString _
                             , o_fila("LlegadaDestino").ToString _
                             , o_fila("IdPiloto").ToString _
                              , o_fila("NombreCompleto").ToString _
                              , o_fila("KmTractoOrigen").ToString _
                              , o_fila("KmTractoDestino").ToString _
                              )
            Return oeViaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerViajeRango(ByVal oeViaje As e_Viaje) As e_Viaje
        Try
            Dim ds As DataSet
            With oeViaje
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Viaje_Listar]",
                                                .TipoOperacion,
                                                .Id,
                                                .IdEstado,
                                                .ViajeVacio,
                                                .Activo,
                                                .FechaDesde,
                                                .FechaHasta)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeViaje = CargarViajeRango(ds.Tables(0).Rows(0))
            End If
            Return oeViaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerViaje(ByVal oeViaje As e_Viaje) As e_Viaje
        Try
            Dim ds As DataSet
            With oeViaje
                If oeViaje.TipoOperacion <> "K" And oeViaje.TipoOperacion <> "L" Then
                    ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Viaje_Listar]",
                                           .TipoOperacion,
                                           .Id,
                                           .IdEstado,
                                           .ViajeVacio,
                                                         True, .FechaDesde, "", "", "", "", .Serie, "", "",
                                           .IdTracto,
                                           .IndMotriz,
                                           "",
                                           "", "", .IndCarga)
                Else
                    ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Viaje_Listar]",
                                           .TipoOperacion,
                                           .Id,
                                           .IdEstado,
                                           .ViajeVacio,
                                                         True, .FechaDesde, "", "", "", "", "", "", "",
                                           .IdTracto,
                                           .IndMotriz,
                                           .IdTracto,
                                           .IdCarreta, "", .IndCarga)
                End If

            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeViaje = CargarViaje(ds.Tables(0).Rows(0))
            Else
                oeViaje = New e_Viaje
            End If
            Return oeViaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Lista Con DataSet - ExecuteDataset
    'Public Function ListarViaje(ByVal oeViaje As e_Viaje) As List(Of e_Viaje)
    '    Try
    '        Dim ldViaje As New List(Of e_Viaje)
    '        Dim ds As DataSet
    '        With oeViaje
    '            ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Viaje_Listar]", _
    '                                          .TipoOperacion _
    '                                            , .Id _
    '                                            , .IdEstado _
    '                                            , .ViajeVacio _
    '                                            , .Activo _
    '                                            , .FechaDesde _
    '                                            , .FechaHasta _
    '                                            , .UsuarioCreacion _
    '                                            , .Zona _
    '                                            , .Centro _
    '                                            , .Serie _
    '                                            , .Numero _
    '                                            , .Remitente _
    '                                            , .IdTracto _
    '                                            , .IndMotriz)
    '        End With
    '        oeViaje = Nothing
    '        If ds.Tables(0).Rows.Count > 0 Then
    '            For Each o_Fila As DataRow In ds.Tables(0).Rows
    '                oeViaje = CargarViaje(o_Fila)
    '                ldViaje.Add(oeViaje)
    '            Next
    '        Else
    '            ldViaje = New List(Of e_Viaje)
    '        End If
    '        Return ldViaje
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Public Function ListarViajeDT(ByVal oeViaje As e_Viaje) As DataTable
        Try
            Dim ldViaje As New List(Of e_Viaje)
            Dim ds As SqlDataReader
            Dim Tabla As New DataTable
            With oeViaje
                ds = SqlHelper.ExecuteReader(connectionString, "[OPE].[Isp_Viaje_Listar]",
                                              .TipoOperacion _
                                                , .Id _
                                                , .IdEstado _
                                                , .ViajeVacio _
                                                , .Activo _
                                                , .FechaDesde _
                                                , .FechaHasta _
                                                , .UsuarioCreacion _
                                                , .Zona _
                                                , .Centro _
                                                , .Serie _
                                                , .Numero _
                                                , .Remitente _
                                                , .IdTracto _
                                                , .IndMotriz)
            End With

            Tabla.Load(ds, LoadOption.OverwriteChanges)

            'While ds.Read()
            '    ldViaje.Add(New e_Viaje(ds.Item("Seleccion"), ds.Item("Id"), ds.Item("Codigo"), ds.Item("IdOperacion"), ds.Item("Operacion"), _
            '                            ds.Item("IdOrigen"), ds.Item("Origen"), ds.Item("IdDestino"), ds.Item("Destino"), ds.Item("IdEscala"), _
            '                            ds.Item("Escala"), ds.Item("IndEscala"), ds.Item("ViajeVacio"), ds.Item("IdPiloto"), ds.Item("Piloto"), _
            '                            ds.Item("DisponibleP"), ds.Item("IdCopiloto"), ds.Item("Copiloto"), ds.Item("DisponibleC"), ds.Item("IdAyudante"), _
            '                            ds.Item("Ayudante"), ds.Item("DisponibleA"), ds.Item("IdTracto"), ds.Item("Tracto"), ds.Item("IdTipoVehiculo"), _
            '                            ds.Item("TipoVehiculo"), ds.Item("IdCarreta"), ds.Item("Carreta"), ds.Item("IdEstado"), ds.Item("Estado"), _
            '                            ds.Item("Fecha"), ds.Item("UsuarioCreacion"), ds.Item("Activo"), ds.Item("Cliente"), ds.Item("CargaMaterial"), _
            '                            ds.Item("GlosaEscala"), ds.Item("Carga"), ds.Item("UsuarioModifica"), ds.Item("UsuarioSeguimiento"), ds.Item("LlegadaOrigen"), _
            '                            ds.Item("IngresoComplejoOrigen"), ds.Item("CargaOrigen"), ds.Item("TerminoCargaOrigen"), ds.Item("ImpresionGuiaOrigen"), ds.Item("SalidaOrigen"), _
            '                            ds.Item("LlegadaAproximadaDestino"), ds.Item("LlegadaDestino"), ds.Item("IngresoDestino"), ds.Item("DescargaDestino"), ds.Item("TerminoDescargaDestino"), _
            '                            ds.Item("SalidaDestino"), ds.Item("Flota"), ds.Item("IncidenciaOperaciones"), ds.Item("IncidenciaSeguimiento"), ds.Item("Turno"), _
            '                            ds.Item("DiaNoche"), ds.Item("PesoToneladas"), ds.Item("TotalFlete"), ds.Item("Zona"), ds.Item("KmTractoOrigen"), _
            '                            ds.Item("KmTractoDestino"), ds.Item("KmCarretaOrigen"), ds.Item("KmCarretaDestino"), ds.Item("Tesoreria"), ds.Item("IndFecha"), _
            '                            ds.Item("PorcentajeFlete"), ds.Item("Cantidad"), ds.Item("FleteUnitario"), ds.Item("IncluyeIgv")))
            'End While
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Lista Con SqlDataReader - ExecuteReader
    Public Function ListarViaje(ByVal oeViaje As e_Viaje) As List(Of e_Viaje)
        Try
            Dim ldViaje As New List(Of e_Viaje)
            Dim ds As SqlDataReader
            With oeViaje
                ds = SqlHelper.ExecuteReader(connectionString, "[OPE].[Isp_Viaje_Listar]",
                                              .TipoOperacion _
                                                , .Id _
                                                , .IdEstado _
                                                , .ViajeVacio _
                                                , .Activo _
                                                , .FechaDesde _
                                                , .FechaHasta _
                                                , .UsuarioCreacion _
                                                , .Zona _
                                                , .Centro _
                                                , .Serie _
                                                , .Numero _
                                                , .Remitente _
                                                , .IdTracto _
                                                , .IndMotriz _
                                                , .IdOrigen _
                                                , .IdDestino _
                                                , .IdOperacion _
                                                , .Turno _
                                                , .IdPiloto)
            End With
            Dim objViaje As e_Viaje
            While ds.Read()

                objViaje = New e_Viaje(ds.Item("Seleccion"), ds.Item("Id"), ds.Item("Codigo"), ds.Item("IdOperacion"),
                    ds.Item("Operacion"), ds.Item("IdOrigen"), ds.Item("Origen"), ds.Item("IdDestino"), ds.Item("Destino"),
                    ds.Item("IdEscala"), ds.Item("Escala"), ds.Item("IndEscala"), ds.Item("ViajeVacio"), ds.Item("ViajeRetorno"),
                    ds.Item("IdPiloto"), ds.Item("Piloto"), ds.Item("DisponibleP"), ds.Item("IdCopiloto"), ds.Item("Copiloto"),
                    ds.Item("DisponibleC"), ds.Item("IdAyudante"), ds.Item("Ayudante"), ds.Item("DisponibleA"), ds.Item("IdTracto"),
                    ds.Item("Tracto"), ds.Item("IdTipoVehiculo"), ds.Item("TipoVehiculo"), ds.Item("IdCarreta"), ds.Item("Carreta"),
                    ds.Item("IdEstado"), ds.Item("Estado"), ds.Item("Fecha"), ds.Item("UsuarioCreacion"), ds.Item("Activo"),
                    ds.Item("Cliente"), ds.Item("CargaMaterial"), ds.Item("GlosaEscala"), ds.Item("Carga"), ds.Item("UsuarioModifica"),
                    ds.Item("UsuarioSeguimiento"), ds.Item("LlegadaOrigen"), ds.Item("IngresoComplejoOrigen"), ds.Item("CargaOrigen"),
                    ds.Item("TerminoCargaOrigen"), ds.Item("ImpresionGuiaOrigen"), ds.Item("SalidaOrigen"), ds.Item("LlegadaAproximadaDestino"),
                    ds.Item("LlegadaDestino"), ds.Item("IngresoDestino"), ds.Item("DescargaDestino"), ds.Item("TerminoDescargaDestino"),
                    ds.Item("SalidaDestino"), ds.Item("Flota"), ds.Item("IncidenciaOperaciones"), ds.Item("IncidenciaSeguimiento"),
                    ds.Item("Turno"), ds.Item("DiaNoche"), ds.Item("PesoToneladas"), ds.Item("TotalFlete"), ds.Item("Zona"),
                    ds.Item("KmTractoOrigen"), ds.Item("KmTractoDestino"), ds.Item("KmCarretaOrigen"), ds.Item("KmCarretaDestino"),
                    ds.Item("Tesoreria"), ds.Item("IndFecha"), ds.Item("PorcentajeFlete"), ds.Item("Cantidad"), ds.Item("FleteUnitario"),
                    ds.Item("IncluyeIgv"), ds.Item("Capacidad"), ds.Item("IndCarga"), ds.Item("Produccion"), ds.Item("FechaCreacion"),
                    ds.Item("FechaModifica"), ds.Item("IndPlanilla"), ds.Item("IdCentro"))
                objViaje.Subtotal = ds.Item("Subtotal")
                objViaje.Consolidado = ds.Item("Consolidado")
                objViaje.DisponibleA = ds.Item("IndGuiaTercero")

                If oeViaje.TipoOperacion = "7" Then
                    objViaje.Comisionista = ds.Item("Comisionista")
                    objViaje.Comision = ds.Item("Comision")
                End If

                If oeViaje.TipoOperacion = "7" Then
                    objViaje.TotalFleteConv = IIf(ds.Item("idTercero") = "DOLARES", objViaje.TotalFlete * ds.Item("TipoCambio"), objViaje.TotalFlete)
                    objViaje.MonedaOp = IIf(ds.Item("idTercero") = "DOLARES", "$", "S/.")
                End If

                If ds.Item("idTercero") IsNot Nothing Then
                    objViaje.IdTercero = ds.Item("idTercero")
                End If
                ldViaje.Add(objViaje)
            End While
            Return ldViaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarViajesLurin(ByVal oeViaje As e_Viaje) As DataTable
        Try
            Dim tabla As DataTable
            With oeViaje
                tabla = sqlhelper.ExecuteDataset("[OPE].[Isp_Viaje_LimaLurin]",
                                                  .TipoOperacion,
                                                  .FechaDesde,
                                                  .FechaHasta).Tables(0)
            End With
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarViajesProceso(ByVal oeViaje As e_Viaje) As DataSet
        Try
            Dim Tablas As DataSet
            With oeViaje
                Tablas = sqlhelper.ExecuteDataset("OPE.Isp_Viaje_Proceso",
                                                  .TipoOperacion,
                                                  .FechaDesde,
                                                  .FechaHasta,
                                                  .Cliente,
                                                  .TipoVehiculo,
                                                  .Tracto,
                                                  .IdOperacion,
                                                  .Codigo)
            End With
            Return ProcesarViajeProceso(Tablas, oeViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ProcesarViajeProceso(Tablas As DataSet, oeViaje As e_Viaje) As DataSet

        Dim Tracto As String = ""
        Dim TractoAnterior As String = ""
        Dim IdTracto As String = ""
        Dim NombreZona As String = ""
        Dim Norte As String = "NORTE"
        Dim Sur As String = "SUR"
        Dim IndTracto As Integer = 0
        Dim CuentaNorte As Double = 0
        Dim CuentaSur As Double = 0
        Dim CuentaZ As Double = 0
        Dim NViaje As Integer = 0
        Dim Insertado As Boolean = False
        Dim CostoFijoZ As Double = 0
        Dim Semana As Double = 0
        Dim CFxViaje As Double = 0
        Dim NorteT As Double = 0
        Dim SurT As Double = 0
        Dim Total As Double = 0.0
        Dim VariableXViaje As Double = 0
        Dim CostoViaje As Double = 0
        Dim CostoTotal As Double = 0
        Dim SemanaZ As Double = 0
        Dim SemanaCal As Double = 0
        Dim MontoZN As Double = 0
        Dim MontoZS As Double = 0
        Dim MontoZ As Double = 0
        Dim FecInicio As Date = "01/01/2000"
        Dim FecFin As Date = "01/01/2000"
        Dim Codigo As String = ""
        If Tablas.Tables(0).Rows.Count > 0 Then
            For Each ZonaCalcula As DataRow In Tablas.Tables(2).Rows
                ZonaCalcula("CuentaZona") = 0.0
                ZonaCalcula("MontoZona") = 0.0
            Next
            For Each Zona As DataRow In Tablas.Tables(2).Rows
                CostoFijoZ = Zona("CostoFijo")
                SemanaZ = Zona("Semana")
                Codigo = Zona("Codigo")
                Tablas.Tables(1).Columns.Add(Zona("Zona") & "Cuenta")
                Tablas.Tables(1).Columns.Add(Zona("Zona") & "Monto")
            Next
            For Each Tabla As DataRow In Tablas.Tables(0).Rows
                If Tracto <> Tabla("Tracto") Then
                    If IndTracto = 1 Then
                        If NViaje = 0 Then NViaje = 1
                        'Capturo Fechas de Vehiculo Operacion
                        For Each Datos In From T In Tablas.Tables(3).Rows Where T("Placa") = TractoAnterior Select T
                            FecInicio = Datos("FechaInicio")
                            FecFin = Datos("FechaFin")
                        Next

                        Dim FecViajeDesde As Date = CDate(oeViaje.FechaDesde)
                        Dim FecViajeHasta As Date = CDate(oeViaje.FechaHasta)
                        SemanaCal = SemanaZ
                        If FecInicio.Date <= FecViajeDesde.Date Then
                            If FecFin.Date < FecViajeHasta.Date Then
                                SemanaCal = DateDiff(DateInterval.Day, FecViajeDesde.Date, FecFin.Date)
                                SemanaCal = SemanaCal + 1
                            End If
                        Else
                            If FecFin.Date >= FecViajeHasta.Date Then
                                SemanaCal = DateDiff(DateInterval.Day, FecInicio.Date, FecViajeHasta.Date)
                                SemanaCal = SemanaCal + 1
                            Else
                                SemanaCal = DateDiff(DateInterval.Day, FecInicio.Date, FecFin.Date)
                                SemanaCal = SemanaCal + 1
                            End If
                        End If
                        Semana = CostoFijoZ * SemanaCal
                        CFxViaje = Semana / NViaje
                        For Each Zona As DataRow In Tablas.Tables(2).Rows
                            If Zona("CuentaZona") > 0 Then
                                Zona("MontoZona") = Zona("Monto") * Zona("CuentaZona")
                            Else
                                Zona("MontoZona") = 0
                            End If
                        Next
                        For Each Zona As DataRow In Tablas.Tables(2).Rows
                            CuentaZ += Zona("CuentaZona")
                            Total += Zona("MontoZona")
                        Next
                        VariableXViaje = Total / NViaje
                        CostoViaje = VariableXViaje + CFxViaje
                        CostoTotal = Semana + Total

                        Dim newRow As DataRow = Tablas.Tables(1).NewRow()
                        newRow("Id") = ""
                        newRow("Codigo") = Codigo
                        newRow("IdTracto") = IdTracto
                        newRow("Tracto") = TractoAnterior
                        newRow("CuentaNorte") = CuentaZ
                        newRow("CuentaSur") = CuentaZ
                        newRow("Valor") = SemanaCal
                        newRow("CostoFijo") = CostoFijoZ
                        newRow("Semana") = Semana
                        newRow("NViaje") = NViaje
                        newRow("CFxViaje") = CFxViaje
                        newRow("Norte") = 0
                        newRow("Sur") = CostoViaje
                        newRow("Total") = Total
                        newRow("VariableXViaje") = VariableXViaje
                        newRow("CostoViaje") = CostoViaje
                        newRow("CostoAdicional") = 0
                        newRow("CostoTotal") = CostoTotal
                        newRow("Adicional01") = 0
                        newRow("Adicional02") = 0
                        newRow("FechaInicio") = oeViaje.FechaDesde
                        newRow("FechaFin") = oeViaje.FechaHasta
                        newRow("Observacion") = ""

                        For Each Zona As DataRow In Tablas.Tables(2).Rows
                            newRow(Zona("Zona") & "Cuenta") = Zona("CuentaZona")
                            newRow(Zona("Zona") & "Monto") = Zona("MontoZona")
                        Next

                        Tablas.Tables(1).Rows.Add(newRow)
                        For Each ZonaCalcula As DataRow In Tablas.Tables(2).Rows
                            ZonaCalcula("CuentaZona") = 0.0
                            ZonaCalcula("MontoZona") = 0.0
                        Next
                        CuentaZ = 0
                        Total = 0
                        NViaje = 0
                        Insertado = True
                    End If
                    For Each ZonaCalcula As DataRow In Tablas.Tables(2).Rows
                        If Tabla("Zona") = ZonaCalcula("Zona") Then
                            ZonaCalcula("CuentaZona") += Tabla("KM")
                            Exit For
                        End If
                    Next
                    Tracto = Tabla("Tracto")
                    IndTracto = 1
                    If Tabla("ViajeRetorno") = False Then NViaje += 1
                Else
                    If Tracto = Tabla("Tracto") Then
                        For Each ZonaCalcula As DataRow In Tablas.Tables(2).Rows
                            If Tabla("Zona") = ZonaCalcula("Zona") Then
                                ZonaCalcula("CuentaZona") += Tabla("KM")
                                Exit For
                            End If
                        Next
                        If Tabla("ViajeRetorno") = False Then NViaje += 1
                    End If
                    Insertado = False
                End If
                IdTracto = Tabla("IdTracto")
                TractoAnterior = Tracto
            Next

            If Insertado = False Then
                If NViaje = 0 Then NViaje = 1
                'Capturo Fechas de Vehiculo Operacion
                For Each Datos In From T In Tablas.Tables(3).Rows Where T("Placa") = TractoAnterior Select T
                    FecInicio = Datos("FechaInicio")
                    FecFin = Datos("FechaFin")
                Next
                Dim FecViajeDesde As Date = CDate(oeViaje.FechaDesde)
                Dim FecViajeHasta As Date = CDate(oeViaje.FechaHasta)
                SemanaCal = SemanaZ
                If FecInicio.Date <= FecViajeDesde.Date Then
                    If FecFin.Date < FecViajeHasta.Date Then
                        SemanaCal = DateDiff(DateInterval.Day, FecViajeDesde.Date, FecFin.Date)
                        SemanaCal = SemanaCal + 1
                    End If
                Else
                    If FecFin.Date >= FecViajeHasta.Date Then
                        SemanaCal = DateDiff(DateInterval.Day, FecInicio.Date, FecViajeHasta.Date)
                        SemanaCal = SemanaCal + 1
                    Else
                        SemanaCal = DateDiff(DateInterval.Day, FecInicio.Date, FecFin.Date)
                        SemanaCal = SemanaCal + 1
                    End If
                End If
                Semana = CostoFijoZ * SemanaCal
                CFxViaje = Semana / NViaje
                For Each Zona As DataRow In Tablas.Tables(2).Rows
                    If Zona("CuentaZona") > 0 Then
                        Zona("MontoZona") = Zona("Monto") * Zona("CuentaZona")
                    Else
                        Zona("MontoZona") = 0
                    End If
                Next
                For Each Zona As DataRow In Tablas.Tables(2).Rows
                    CuentaZ += Zona("CuentaZona")
                    Total += Zona("MontoZona")
                Next
                VariableXViaje = Total / NViaje
                CostoViaje = VariableXViaje + CFxViaje
                CostoTotal = Semana + Total

                Dim newRow As DataRow = Tablas.Tables(1).NewRow()
                newRow("Id") = ""
                newRow("Codigo") = Codigo
                newRow("IdTracto") = IdTracto
                newRow("Tracto") = TractoAnterior
                newRow("CuentaNorte") = CuentaZ
                newRow("CuentaSur") = CuentaZ
                newRow("Valor") = SemanaCal
                newRow("CostoFijo") = CostoFijoZ
                newRow("Semana") = Semana
                newRow("NViaje") = NViaje
                newRow("CFxViaje") = CFxViaje
                newRow("Norte") = 0
                newRow("Sur") = CostoViaje
                newRow("Total") = Total
                newRow("VariableXViaje") = VariableXViaje
                newRow("CostoViaje") = CostoViaje
                newRow("CostoAdicional") = 0
                newRow("CostoTotal") = CostoTotal
                newRow("Adicional01") = 0
                newRow("Adicional02") = 0
                newRow("FechaInicio") = oeViaje.FechaDesde
                newRow("FechaFin") = oeViaje.FechaHasta
                newRow("Observacion") = ""
                For Each Zona As DataRow In Tablas.Tables(2).Rows
                    newRow(Zona("Zona") & "Cuenta") = Zona("CuentaZona")
                    newRow(Zona("Zona") & "Monto") = Zona("MontoZona")
                Next
                Tablas.Tables(1).Rows.Add(newRow)
                For Each ZonaCalcula As DataRow In Tablas.Tables(2).Rows
                    ZonaCalcula("CuentaZona") = 0.0
                    ZonaCalcula("MontoZona") = 0.0
                Next
                CuentaZ = 0
                Total = 0
            End If

            CostoViaje = 0
            For Each FilaTarifa As DataRow In Tablas.Tables(1).Rows
                CostoViaje = FilaTarifa("CostoViaje")
                For Each Fila As DataRow In Tablas.Tables(0).Rows
                    MontoZ = 0
                    For Each FilaZona As DataRow In Tablas.Tables(2).Rows
                        If Fila("Zona") = FilaZona("Zona") Then
                            MontoZ = FilaZona("Monto")
                            Exit For
                        End If
                    Next
                    If Fila("KM") = 0 Then Fila("KM") = 1
                    Fila("Factor") = Fila("KM") * MontoZ
                    If Fila("Tracto") = FilaTarifa("Tracto") And Fila("ViajeRetorno") = False Then
                        Fila("CostoViaje") = CostoViaje
                        Fila("FleteUnitario") = CostoViaje / Fila("KM")
                        Fila("Flete") = (CostoViaje * oeViaje.FleteUnitario) + CostoViaje
                    End If
                Next
            Next

        End If
        Return Tablas
    End Function

    Public Function ListarFletes(ByVal oeViaje As e_Viaje) As List(Of e_Viaje)
        Try
            Dim ldViaje As New List(Of e_Viaje)
            Dim ds As DataSet
            With oeViaje
                ds = sqlhelper.ExecuteDataset("[TES].[Isp_ProcesoFlete_Listar]",
                                              .TipoOperacion _
                                                , .Operacion _
                                                , .Codigo _
                                                , .FechaDesde _
                                                , .FechaHasta _
                                                , .IdPiloto _
                                                , .Cliente _
                                                , .CargaMaterial _
                                                , .IdTracto _
                                                , .Centro _
                                                , .Activo)
            End With
            oeViaje = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeViaje = CargarViaje(o_Fila)
                    ldViaje.Add(oeViaje)
                Next
            Else
                ldViaje = New List(Of e_Viaje)
            End If
            Return ldViaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarVehiculoEstadoSituacional() As DataTable
        Try
            Dim tabla As DataTable
            tabla = sqlhelper.ExecuteDataset("[OPE].[Isp_VehiculoEstadoSituacional]").Tables(0)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDocumentosViaje(ByVal oeViaje As e_Viaje) As DataTable
        Try
            Dim tabla As DataTable
            With oeViaje
                tabla = sqlhelper.ExecuteDataset("[OPE].[Isp_DocumentosViaje_Listar]",
                                                 "",
                                                 .Id).Tables(0)
            End With
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarViaje(ByVal oeViaje As e_Viaje) As String
        Try
            Dim stResultado() As String
            With oeViaje
                stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_Viaje_IAE]",
                          .TipoOperacion,
                          .PrefijoID,
                        "A",
                          .Id _
                          , .Codigo _
                          , .IdOperacion _
                          , .Origen _
                          , .Destino _
                          , .IdEscala _
                          , .IndEscala _
                          , .ViajeVacio _
                          , .Piloto _
                          , .Copiloto _
                          , .IdAyudante _
                          , .Tracto _
                          , .Carreta _
                          , .IdEstado _
                          , .Fecha _
                          , .UsuarioCreacion _
                          , .Activo,
                           .GlosaEscala,
                           .Carga,
                           .IncidenciaOperaciones,
                           .Turno,
                           .DiaNoche,
                           .IndFecha,
                           .PorcentajeFlete,
                           .IndGrtConfirmada,
                           .IndDocumentos,
                           .IndGrtPerdido,
                           .IndFacturado,
                           .FleteUnitario,
                           .TotalFlete,
                           .Capacidad,
                           .IndCarga,
                           .IndFormato,
                           .ViajeRetorno).ToString.Split("_")
            End With
            Return stResultado(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarViaje(ByVal oeViaje As e_Viaje) As String
        Try
            With oeViaje
                sqlhelper.ExecuteScalar("[OPE].[Isp_Viaje_IAE]", .TipoOperacion _
                                                      , "" _
                                                      , "" _
                                                      , .Id _
                                                      , .Codigo _
                                                      , .IdOperacion _
                                                      , .Origen _
                                                      , .Destino _
                                                      , .IdEscala _
                                                      , .IndEscala _
                                                      , .ViajeVacio _
                                                      , .Piloto _
                                                      , .Copiloto _
                                                      , .IdAyudante _
                                                      , .Tracto _
                                                      , .Carreta _
                                                      , .IdEstado _
                                                      , .Fecha _
                                                      , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarViajeDemanda(ByVal oeViaje As e_Viaje) As String
        Dim res = ""
        Try
            Using transScope As New TransactionScope()
                'actualizar campo en DespachoOperaciones
                Dim oeDespachoOpeaciones As New e_DespachoOperaciones, odDespachoOperaciones As New d_DespachoOperaciones, loDespachoOperaciones As New List(Of e_DespachoOperaciones)
                oeDespachoOpeaciones.IdViaje = oeViaje.Id
                loDespachoOperaciones.AddRange(odDespachoOperaciones.Listar(oeDespachoOpeaciones))
                If loDespachoOperaciones.Count > 0 Then
                    loDespachoOperaciones(0).TipoOperacion = "I"
                    loDespachoOperaciones(0).IdViaje = String.Empty
                    loDespachoOperaciones(0).UsuarioCrea = oeViaje.UsuarioCreacion
                    loDespachoOperaciones(0).PrefijoID = oeViaje.PrefijoID '@0001
                    odDespachoOperaciones.Guardar(loDespachoOperaciones(0))
                End If
                With oeViaje
                    res = sqlhelper.ExecuteScalar("[OPE].[Isp_Viaje_IAE]", .TipoOperacion _
                                                          , "" _
                                                          , "" _
                                                          , .Id _
                                                          , .Codigo _
                                                          , .IdOperacion _
                                                          , .Origen _
                                                          , .Destino _
                                                          , .IdEscala _
                                                          , .IndEscala _
                                                          , .ViajeVacio _
                                                          , .Piloto _
                                                          , .Copiloto _
                                                          , .IdAyudante _
                                                          , .Tracto _
                                                          , .Carreta _
                                                          , .IdEstado _
                                                          , .Fecha _
                                                          , .UsuarioCreacion _
                                                          , 1 _
                                                          , .GlosaEscala _
                                                          , 0 _
                                                          , .Flota) 'justificacion, idconceptocancelacioneliminacion       
                End With
                transScope.Complete()
            End Using
            Return res
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarOperacionDetalle(ByVal o_fila As DataRow) As e_OperacionDetalle
        Try
            Dim oeOperacionDetalle = New e_OperacionDetalle( _
                             o_fila("Id").ToString _
                             , o_fila("IdOperacion").ToString _
                             , o_fila("IdDemanda").ToString _
                             , o_fila("IdDemandaDetalle").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("IdComisionista").ToString _
                             , o_fila("IdUnidadCarga").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("IncluyeIgv").ToString _
                             , o_fila("FleteUnitario").ToString _
                             , o_fila("Flete").ToString _
                             , o_fila("Comision").ToString _
                             , o_fila("Consolidado").ToString _
                             , o_fila("Facturado").ToString _
                             , o_fila("PagoContraEntrega").ToString _
                             , o_fila("Activo").ToString, _
                             o_fila("Origen").ToString, _
                             o_fila("Destino").ToString, _
                             o_fila("PesoToneladas").ToString, _
                             o_fila("Glosa").ToString, _
                             o_fila("PesoToneladasCarga").ToString, _
                             o_fila("PesoToneladasDescarga").ToString, _
                             o_fila("Cargar").ToString, _
                             o_fila("Descarga").ToString, _
                             o_fila("IndPesoTnDescarga").ToString, _
                             o_fila("Saldo").ToString, _
                             o_fila("FechaCrea").ToString, _
                             o_fila("FechaModifica").ToString, _
                             o_fila("IdClienteFinal").ToString)
            oeOperacionDetalle.Subtotal = o_fila("Subtotal")
            oeOperacionDetalle.CostoEstiba = o_fila("CostoEstiba")
            oeOperacionDetalle.CostoEstibaDescarga = o_fila("CostoEstibaDescarga")
            oeOperacionDetalle.AdelantoFlete = o_fila("AdelantoFlete")
            oeOperacionDetalle.IncluyeIgvConsolidado = o_fila("IncluyeIGVConsolidado")
            oeOperacionDetalle.Consolidado = o_fila("Consolidado")
            oeOperacionDetalle.PagoEfectivoDeposito = o_fila("PagoEfectivoDeposito")
            oeOperacionDetalle.MotivoConsolidado = o_fila("MotivoConsolidado")
            oeOperacionDetalle.FalsoFlete = o_fila("FalsoFlete")
            oeOperacionDetalle.NroOperacion = o_fila("NroOperacion")
            oeOperacionDetalle.IdActividadNegocio = o_fila("IdActividadNegocio")
            Return oeOperacionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarOperacionDetalle2(ByVal o_fila As DataRow) As e_OperacionDetalle
        Try
            Dim oeOperacionDetalle = New e_OperacionDetalle
            oeOperacionDetalle.Id = o_fila("Id").ToString
            oeOperacionDetalle.IdOperacion = o_fila("IdOperacion").ToString
            oeOperacionDetalle.IdDemanda = o_fila("IdDemanda").ToString
            oeOperacionDetalle.IdDemandaDetalle = o_fila("IdDemandaDetalle").ToString
            oeOperacionDetalle.Cliente = o_fila("IdCliente").ToString
            oeOperacionDetalle.Comisionista = o_fila("IdComisionista").ToString
            oeOperacionDetalle.Carga = o_fila("IdUnidadCarga").ToString
            oeOperacionDetalle.Material = o_fila("IdMaterial").ToString
            oeOperacionDetalle.Moneda = o_fila("IdMoneda").ToString
            oeOperacionDetalle.Cantidad = o_fila("Cantidad").ToString
            oeOperacionDetalle.IncluyeIgv = o_fila("IncluyeIgv").ToString
            oeOperacionDetalle.FleteUnitario = o_fila("FleteUnitario").ToString
            oeOperacionDetalle.Flete = o_fila("Flete").ToString
            oeOperacionDetalle.Comision = o_fila("Comision").ToString
            oeOperacionDetalle.Consolidado = o_fila("Consolidado").ToString
            oeOperacionDetalle.Facturado = o_fila("Facturado").ToString
            oeOperacionDetalle.PagoContraEntrega = o_fila("PagoContraEntrega").ToString
            oeOperacionDetalle.Activo = o_fila("Activo").ToString
            oeOperacionDetalle.CostoEstiba = o_fila("CostoEstiba")
            oeOperacionDetalle.CostoEstibaDescarga = o_fila("CostoEstibaDescarga")
            oeOperacionDetalle.AdelantoFlete = o_fila("AdelantoFlete")
            oeOperacionDetalle.IncluyeIgvConsolidado = o_fila("IncluyeIGVConsolidado")
            oeOperacionDetalle.Consolidado = o_fila("Consolidado")
            oeOperacionDetalle.PagoEfectivoDeposito = o_fila("PagoEfectivoDeposito")
            oeOperacionDetalle.MotivoConsolidado = o_fila("MotivoConsolidado")
            Return oeOperacionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As e_OperacionDetalle
        Try
            Dim ds As DataSet
            With oeOperacionDetalle
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_OperacionDetalle_Listar]",
                                                .TipoOperacion,
                                                .Id,
                                                .IdOperacion)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeOperacionDetalle = CargarOperacionDetalle(ds.Tables(0).Rows(0))
            Else
                oeOperacionDetalle = New e_OperacionDetalle
            End If
            Return oeOperacionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function FacturaOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As Boolean
        Try
            With oeOperacionDetalle
                sqlhelper.ExecuteNonQuery("OPE.Isp_OperacionDet_ListarDS",
                                            .TipoOperacion _
                                            , .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ListarOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As List(Of e_OperacionDetalle)
        Try
            Dim ldOperacionDetalle As New List(Of e_OperacionDetalle)
            Dim ds As DataSet
            With oeOperacionDetalle
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_OperacionDetalle_Listar]",
                                                .TipoOperacion _
                                                , .Id _
                                                , .IdOperacion _
                                                , .IdDemanda _
                                                , .Cliente _
                                                , .Proveedor _
                                                , .FechaDesde _
                                                , .FechaHasta)
            End With
            oeOperacionDetalle = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOperacionDetalle = CargarOperacionDetalle(o_Fila)
                    ldOperacionDetalle.Add(oeOperacionDetalle)
                Next
            Else
                ldOperacionDetalle = New List(Of e_OperacionDetalle)
            End If
            Return ldOperacionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarDetalleDocOpe(ByVal o_fila As DataRow) As e_DetalleDoc_OperacionDet
        Try
            Dim oeDetalleDocOpeDet = New e_DetalleDoc_OperacionDet(
                             o_fila("Id").ToString _
                             , o_fila("IdMaterialServicio").ToString _
                             , o_fila("MaterialServicio").ToString _
                             , o_fila("Cantidad") _
                             , o_fila("PrecioUnitario") _
                             , o_fila("IndGravado") _
                             , o_fila("Igv") _
                             , o_fila("Valor") _
                             , o_fila("IdOperacionDetalle").ToString _
                             , o_fila("IdUnidadMedida").ToString _
                             , o_fila("UnidadMedida").ToString _
                             , o_fila("FactorRefUni") _
                             , o_fila("IdOperacion").ToString _
                             , o_fila("IdComisionista").ToString _
                             , o_fila("IdUnidadCarga").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("CantOpe") _
                             , o_fila("IncluyeIgv") _
                             , o_fila("FleteUnitario") _
                             , o_fila("Flete") _
                             , o_fila("IdOrigen").ToString _
                             , o_fila("IdDestino").ToString _
                             , o_fila("Origen").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("PesoToneladas") _
                             , o_fila("Glosa").ToString _
                             , o_fila("CantGuia") _
                             , o_fila("Saldo") _
                             , o_fila("Tracto").ToString _
                             , o_fila("Carreta").ToString _
                             , o_fila("FechaViaje") _
                             , o_fila("NroViaje").ToString _
                             , o_fila("ConfVeh").ToString _
                             , o_fila("NroOperacion").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("Consolidado").ToString)
            oeDetalleDocOpeDet.NroOperacionOrden = o_fila("NroOperacionOrden")
            Return oeDetalleDocOpeDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarOperacionDetalleDS(ByVal oeDetalleDocOpeDet As e_DetalleDoc_OperacionDet) As List(Of e_DetalleDoc_OperacionDet)
        Try
            Dim leDetalleDetOpeDet As New List(Of e_DetalleDoc_OperacionDet)
            Dim ds As DataSet
            With oeDetalleDocOpeDet
                ds = sqlhelper.ExecuteDataset("CON.Isp_DetalleDoc_OperacionDet_Listar",
                                                .TipoOperacion _
                                                , .IdMovimientoDocumento _
                                                , .IdOperacionDet _
                                                , .Glosa)
            End With
            oeDetalleDocOpeDet = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDetalleDocOpeDet = CargarDetalleDocOpe(o_Fila)
                    leDetalleDetOpeDet.Add(oeDetalleDocOpeDet)
                Next
            Else
                leDetalleDetOpeDet = New List(Of e_DetalleDoc_OperacionDet)
            End If
            Return leDetalleDetOpeDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarODBloque(ListaPTP As List(Of e_ProcesarTarifasProceso), ListaOD As List(Of e_OperacionDetalle)) As Boolean
        Try
            odProcesarTarifasProceso = New d_ProcesarTarifasProceso
            Using transScope As New TransactionScope()
                If ListaPTP.Count > 0 Then

                    For Each ProcesarTarifasProceso As e_ProcesarTarifasProceso In ListaPTP
                        odProcesarTarifasProceso.Guardar(ProcesarTarifasProceso)
                    Next

                    For Each OperacionDetalle As e_OperacionDetalle In ListaOD
                        GuardarOperacionDetalle(OperacionDetalle)
                    Next
                End If
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeOperacionDetalle
                Dim codigo = sqlhelper.ExecuteScalar("[OPE].[Isp_OperacionDetalle_IAE]",
                                          .TipoOperacion,
                                          .PrefijoID,
                                            .Id _
                                            , .IdOperacion _
                                            , IIf(.IdDemanda.Trim = "", Nothing, .IdDemanda) _
                                            , IIf(.IdDemandaDetalle.Trim = "", Nothing, .IdDemandaDetalle) _
                                            , .Cliente _
                                            , .Comisionista _
                                            , .Carga _
                                            , .Material _
                                            , .Moneda _
                                            , .Cantidad _
                                            , .IncluyeIgv _
                                            , .FleteUnitario _
                                            , .Flete _
                                            , .Comision _
                                            , .Facturado _
                                            , .PagoContraEntrega _
                                            , .Activo,
                                            .Origen,
                                            .Destino,
                                            .PesoToneladas,
                                            .Glosa,
                                            .PesoToneladasCarga,
                                            .PesoToneladasDescarga,
                                            .Cargar,
                                            .Descarga,
                                            .IndPesoTnDescarga,
                                            .Saldo,
                                            .SaldoCarga,
                                            .UsuarioCreacion,
                                            .Consolidado,
                                            .ClienteFinal,
                                            .CostoEstiba,
                                            .CostoEstibaDescarga,
                                            .AdelantoFlete,
                                            .IncluyeIgvConsolidado,
                                            .PagoEfectivoDeposito,
                                            .MotivoConsolidado,
                                            .Subtotal,
                                            .NroOperacion,
                                            .IdActividadNegocio)
                resultado = True

                If oeOperacionDetalle.oeIncidenciaAutentificadas IsNot Nothing Then
                    If oeOperacionDetalle.oeIncidenciaAutentificadas.IdResponsableAutoriza <> "" Then
                        With oeOperacionDetalle.oeIncidenciaAutentificadas
                            .TipoOperacion = "I"
                            .Referencia = codigo
                            .FechaReferencia = fechaReferencia
                        End With
                        oeOperacionDetalle.oeIncidenciaAutentificadas.PrefijoID = oeOperacionDetalle.PrefijoID '@0001
                        odIncidenciaAutentificada.Guardar(oeOperacionDetalle.oeIncidenciaAutentificadas)
                    End If
                End If
            End With
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarOperacionDetalleLista(ByVal OperacionDetalleLista As List(Of e_OperacionDetalle)) As Boolean
        Try
            For Each Detalle As e_OperacionDetalle In OperacionDetalleLista
                GuardarOperacionDetalle(Detalle)
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RefacturarOperacionDet(ByVal OperacionDetalle As e_OperacionDetalle) As Boolean
        Try
            Dim result As Boolean = False
            With OperacionDetalle

                If sqlhelper.ExecuteNonQuery("[OPE].[Isp_OperacionDetalle_IAE]",
                                      .TipoOperacion,
                                      .PrefijoID,
                                        .Id
                                      ) > 0 Then
                    result = True
                End If
            End With
            Return result
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As Boolean
        Try
            Dim resultado As Boolean = False
            If sqlhelper.ExecuteNonQuery("[OPE].[Isp_OperacionDetalle_IAE]",
                                         "E",
                                         "", oeOperacionDetalle.Id) > 0 Then
                resultado = True
            End If
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDataSet(ByVal oeViaje As e_Viaje) As DataSet
        Try
            With oeViaje
                Return sqlhelper.ExecuteDataset("[OPE].[Isp_Liquidaciones_Listar_]",
                                                .Id,
                                                .FechaDesde,
                                                .FechaHasta)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDataSetViajesAntiguos(ByVal oeViaje As e_Viaje) As DataSet
        Try
            With oeViaje
                Return sqlhelper.ExecuteDataset("[OPE].[Isp_Liquidaciones_Listar_ViajesAntiguos]",
                                                    .Id,
                                                    .FechaDesde,
                                                    .FechaHasta)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerOperacionDetalleViaje(ByVal oeOperacionDetalle As e_OperacionDetalle) As e_OperacionDetalle
        Try
            Dim ds As DataSet
            With oeOperacionDetalle
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_OperacionDetalleViaje_Listar]",
                                                .TipoOperacion,
                                                .IdOperacion,
                                                .Id,
                                                .Cliente,
                                                .Origen,
                                                .Destino,
                                                .Material,
                                                .Moneda,
                                                .Carga)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeOperacionDetalle = CargarOperacionDetalle2(ds.Tables(0).Rows(0))
            Else
                oeOperacionDetalle = New e_OperacionDetalle
            End If
            Return oeOperacionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class

