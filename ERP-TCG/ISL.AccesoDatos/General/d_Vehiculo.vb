Imports ISL.EntidadesWCF
Imports System.Transactions
''' <summary>
''' Clase que gestina los vehiculos de la empresa.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Vehiculo,Capa del Sistema: Capa de Acceso a Datos.</remarks>
''' 
Public Class d_Vehiculo
    Private sqlhelper As SqlHelper
    Private oeVehiculo As e_Vehiculo
    Private odDocumentoVehicular As d_DocumentoVehicular
    Private odPlaca As d_Placa
    Private odDispositivo As d_Dispositivo
    Private odBonificacion As d_Bonificacion
    Private odAsignacionFlota As d_AsignacionFlota
    Private odVehiculoEstado As d_VehiculoEstado
    Private odVehiculoTarjeta As d_VehiculoTarjeta

    Public Function Cargar(o_fila As DataRow) As e_Vehiculo
        Try
            Dim oeVehiculo = New e_Vehiculo With { _
                                .Id = o_fila("Id").ToString _
                                , .Codigo = o_fila("Codigo").ToString _
                                , .Motriz = o_fila("Motriz") _
                                , .Placa = o_fila("Placa").ToString _
                                , .IdTipoVehiculo = o_fila("IdTipoVehiculo").ToString _
                                , .TipoVehiculo = o_fila("TipoVehiculo").ToString _
                                , .IdModeloFuncional = o_fila("IdModeloFuncional").ToString _
                                , .ModeloFuncional = o_fila("ModeloFuncional").ToString _
                                , .IdMarca = o_fila("IdMarca").ToString _
                                , .Marca = o_fila("Marca").ToString _
                                , .IdModelo = o_fila("IdModelo").ToString _
                                , .Modelo = o_fila("Modelo").ToString _
                                , .IdEmpresaPropietaria = o_fila("IdEmpresaPropietaria").ToString _
                                , .EmpresaPropietaria = o_fila("EmpresaPropietaria").ToString _
                                , .Activo = o_fila("Activo") _
                                , .Observacion = o_fila("Observacion").ToString _
                                , .IdMaterialCombustible = o_fila("IdMaterialCombustible").ToString _
                                , .CapacidadTanque = o_fila("CapacidadTanque") _
                                , .IdConfiguracionVehicularMTC = o_fila("IdConfiguracionVehicularMTC").ToString _
                                , .AnioFabricacion = o_fila("AnioFabricacion") _
                                , .NroSerieMotor = o_fila("NroSerieMotor").ToString _
                                , .NroSerieChasis = o_fila("NroSerieChasis").ToString _
                                , .Color = o_fila("Color").ToString _
                                , .Ancho = o_fila("Ancho") _
                                , .Largo = o_fila("Largo") _
                                , .Alto = o_fila("Alto") _
                                , .Tara = o_fila("Tara") _
                                , .Capacidad = o_fila("Capacidad") _
                                , .Cubicaje = o_fila("Cubicaje") _
                                , .NroEjes = o_fila("NroEjes") _
                                , .NroNeumaticos = o_fila("NroNeumaticos") _
                                , .NroNeumaticosRepuesto = o_fila("NroNeumaticosRepuesto") _
                                , .IdConfiguracionNeumaticos = o_fila("IdConfiguracionNeumaticos").ToString _
                                , .ConfiguracionNeumaticos = o_fila("ConfiguracionNeumaticos").ToString _
                                , .NroMTC = o_fila("NroMTC").ToString _
                                , .Odometro = o_fila("Odometro") _
                                , .Horometro = o_fila("Horometro") _
                                , .Monto = o_fila("Monto") _
                                , .PlacaAntigua = o_fila("PlacaAntigua").ToString _
                                , .IdFlota = o_fila("IdFlota").ToString _
                                , .IndEstado = o_fila("IndEstado").ToString _
                                , .Fecha = o_fila("Fecha") _
                                , .IndProrrateo = o_fila("IndProrrateo") _
                                , .IndPropiedad = o_fila("IndPropiedad") _
                                , .IndActivoFijo = o_fila("IndActivoFijo") _
                                , .PesoNeto = o_fila("PesoNeto") _
                                , .NroAsientos = o_fila("NroAsientos") _
                                , .NroPasajeros = o_fila("NroPasajeros") _
                                , .NroEquipoMovil = o_fila("NroEquipoMovil").ToString _
                                , .DescripcionDetalle = o_fila("DescripcionDetalle").ToString _
                                , .Foto = o_fila("Foto") _
                                , .AnioModelo = o_fila("AnioModelo").ToString _
                                , .IdModeloSunarp = o_fila("IdModeloSunarp").ToString _
                                , .IdTipoCarroceriaSunarp = o_fila("IdTipoCarroceriaSunarp").ToString _
                                , .TipoNeumatico = o_fila("TipoNeumatico").ToString _
                                , .SuspensionNeumatica = o_fila("SuspensionNeumatica").ToString _
                                , .Bonificacion = o_fila("Bonificacion").ToString _
                                , .TomaFuerza = o_fila("TomaFuerza").ToString _
                                , .Modalidad = o_fila("Modalidad").ToString _
                                , .TarjetaCombustible = o_fila("TarjetaCombustible").ToString _
                                , .IdEmpresaGPS = o_fila("IdEmpresaGPS").ToString _
                                , .RutaAsignada = o_fila("RutaAsignada").ToString _
                                , .ConductorAsignada = o_fila("ConductorAsignada").ToString _
                                , .IdClasificacionISL = o_fila("IdClasificacionISL").ToString _
                                , .ClasificacionISL = o_fila("ClasificacionISL").ToString _
                                , .IdTipoCarroceria = o_fila("IdTipoCarroceria").ToString _
                                , .TipoCarroceria = o_fila("TipoCarroceria").ToString _
                              }
            Return oeVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeVehiculo As e_Vehiculo) As e_Vehiculo
        Try
            sqlhelper = New SqlHelper
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_Vehiculo_Listar]", _
                                          oeVehiculo.TipoOperacion, _
                                          oeVehiculo.Id, _
                                          oeVehiculo.Placa, _
                                          oeVehiculo.Codigo)

            If ds.Tables(0).Rows.Count > 0 Then
                oeVehiculo = Cargar(ds.Tables(0).Rows(0))
            Else
                oeVehiculo = New e_Vehiculo
            End If
            Return oeVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeVehiculo As e_Vehiculo) As List(Of e_Vehiculo)
        Try
            sqlhelper = New SqlHelper
            Dim ldVehiculo As New List(Of e_Vehiculo)
            Dim ds As DataSet
            With oeVehiculo
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Vehiculo_Listar]", _
                                              .TipoOperacion, .Id, .Placa, .Codigo, _
                                              .Motriz, .IdTipoVehiculo, .IdMarca, _
                                              .IdModelo, .IdModeloFuncional, _
                                              .IdEmpresaPropietaria, .IdMaterialCombustible, _
                                              .IdConfiguracionVehicularMTC, .AnioFabricacion, _
                                              .NroSerieMotor, .NroSerieChasis, ._Periodo, ._IndCompraVenta, .IdFlota)
            End With
            oeVehiculo = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeVehiculo = Cargar(o_Fila)
                    ldVehiculo.Add(oeVehiculo)
                Next
            End If
            Return ldVehiculo
        Catch ex As Exception
            Throw
        End Try
    End Function
    
    Public Function Guardar(oeVehiculo As e_Vehiculo) As Boolean
        Try
            Dim stResultado() As String
            sqlhelper = New SqlHelper
            odDocumentoVehicular = New d_DocumentoVehicular
            odPlaca = New d_Placa
            odDispositivo = New d_Dispositivo
            odBonificacion = New d_Bonificacion
            odAsignacionFlota = New d_AsignacionFlota
            odVehiculoEstado = New d_VehiculoEstado
            odVehiculoTarjeta = New d_VehiculoTarjeta

            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                With oeVehiculo
                    stResultado = sqlhelper.ExecuteScalar("[STD].[Isp_Vehiculo_IAE]", _
                                                          .TipoOperacion, _
                                                        .TipoActualizacion, _
                                                        d_DatosConfiguracion.PrefijoID, _
                                                         .Id _
                                                        , .Codigo _
                                                        , .Placa _
                                                        , .Motriz _
                                                        , .IdTipoVehiculo _
                                                        , .IdMarca _
                                                        , .IdModelo _
                                                        , .IdModeloFuncional _
                                                        , .IdEmpresaPropietaria _
                                                        , .IdFlota _
                                                        , .IdMaterialCombustible _
                                                        , .AnioFabricacion _
                                                        , .NroSerieMotor _
                                                        , .NroSerieChasis _
                                                        , .Color _
                                                        , .Ancho _
                                                        , .Largo _
                                                        , .Alto _
                                                        , .Tara _
                                                        , .Capacidad _
                                                        , .Cubicaje _
                                                        , .NroEjes _
                                                        , .NroNeumaticos _
                                                        , .NroNeumaticosRepuesto _
                                                        , .NroMTC _
                                                        , .IdConfiguracionVehicularMTC _
                                                        , .IdConfiguracionNeumaticos _
                                                        , .Observacion _
                                                        , .IndEstado _
                                                        , .Activo _
                                                        , .UsuarioCreacion _
                                                        , .PlacaAntigua _
                                                        , .CapacidadTanque _
                                                        , .Odometro _
                                                        , .Horometro _
                                                        , .Fecha _
                                                        , .IndPropiedad _
                                                        , .IndProrrateo _
                                                        , .IndActivoFijo _
                                                        , .PesoNeto _
                                                        , .NroAsientos _
                                                        , .NroPasajeros _
                                                        , .NroEquipoMovil _
                                                        , .DescripcionDetalle _
                                                        , .Foto _
                                                       , .AnioModelo _
                                                       , .IdModeloSunarp _
                                                       , .IdTipoCarroceriaSunarp _
                                                       , .TipoNeumatico _
                                                       , .SuspensionNeumatica _
                                                       , .Bonificacion _
                                                       , .TomaFuerza _
                                                       , .Modalidad _
                                                       , .TarjetaCombustible _
                                                       , .IdEmpresaGPS _
                                                       , .RutaAsignada _
                                                       , .ConductorAsignada _
                                                       , .IdClasificacionISL _
                                                       , .IdTipoCarroceria).ToString.Split("_")

                    'Placa
                    For Each Placa As e_Placa In .ListHistorialPlaca
                        With Placa
                            If .TipoOperacion = "E" Then
                                odPlaca.Eliminar(Placa)
                            Else
                                .TipoOperacion = "I"
                                .IdVehiculo = stResultado(0)
                                odPlaca.Guardar(Placa)
                            End If
                        End With
                    Next
                    'Estados
                    For Each Estado As e_VehiculoEstado In .ListVehiculoEstados
                        With Estado
                            If .TipoOperacion = "E" Then
                                odVehiculoEstado.Eliminar(Estado)
                            Else
                                .TipoOperacion = "I"
                                .IdVehiculo = stResultado(0)
                                odVehiculoEstado.Guardar(Estado)
                            End If
                        End With
                    Next
                    'Dispositivo
                    For Each Dispositivo As e_Dispositivo In .ListDispositivo
                        With Dispositivo
                            If .TipoOperacion = "E" Then
                                odDispositivo.Eliminar(Dispositivo)
                            Else
                                .TipoOperacion = "I"
                                .IdVehiculo = stResultado(0)
                                odDispositivo.Guardar(Dispositivo)
                            End If
                        End With
                    Next
                    'Bonificacion
                    For Each Bonificacion As e_Bonificacion In .ListBonificacion
                        With Bonificacion
                            If .TipoOperacion = "E" Then
                                odBonificacion.Eliminar(Bonificacion)
                            Else
                                .TipoOperacion = "I"
                                .IdVehiculo = stResultado(0)
                                odBonificacion.Guardar(Bonificacion)
                            End If
                        End With
                    Next
                    'Flota
                    For Each Flota As e_AsignacionFlota In .ListAsignacionFlota
                        With Flota
                            If .TipoOperacion = "E" Then
                                odAsignacionFlota.Eliminar(Flota)
                            Else
                                .TipoOperacion = "I"
                                .IdVehiculo = stResultado(0)
                                odAsignacionFlota.Guardar(Flota)
                            End If
                        End With
                    Next
                    'Tarjetas
                    For Each Tarjeta As e_VehiculoTarjeta In .ListVehiculoTarjeta
                        If Tarjeta.TipoOperacion = "E" Then
                            odVehiculoTarjeta.Eliminar(Tarjeta)
                        Else
                            Tarjeta.TipoOperacion = "I"
                            Tarjeta.IdVehiculo = stResultado(0)
                            odVehiculoTarjeta.Guardar(Tarjeta)
                        End If
                    Next
                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    
    Public Function Eliminar(oeVehiculo As e_Vehiculo) As Boolean
        Try
            sqlhelper = New SqlHelper
            sqlhelper.ExecuteNonQuery("[STD].[Isp_Vehiculo_IAE]", _
                                      oeVehiculo.TipoOperacion, _
                                      "", _
                                      "", _
                                      oeVehiculo.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ListaVehiculo As List(Of e_Vehiculo))
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_Vehiculo In ListaVehiculo
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                newRow("Nombre") = item.Placa
                ds.Rows.Add(newRow)
            Next
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarSituacional(oeVehiculo As e_Vehiculo) As DataSet
        Try
            sqlhelper = New SqlHelper
            Dim ds As DataSet
            With oeVehiculo
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Vehiculo_Listar]", _
                                              .TipoOperacion, .Id, .Placa, .Codigo, _
                                              .Motriz, .IdTipoVehiculo, .IdMarca, _
                                              .IdModelo, .IdModeloFuncional, _
                                              .IdEmpresaPropietaria, .IdMaterialCombustible, _
                                              .IdConfiguracionVehicularMTC, .AnioFabricacion, _
                                              .NroSerieMotor, .NroSerieChasis, ._Periodo, ._IndCompraVenta, .IdFlota)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
