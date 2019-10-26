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

Public Class d_OrdenTrabajo
    Private sqlhelper As New SqlHelper
    Dim odOTMantenimientoEquipo As New d_OrdenTrabajo_MantenimientoEquipo
    Dim odOTMaterial As New d_OrdenTrabajo_Material
    Dim odOTServicio As New d_OrdenTrabajo_Servicio
    Dim odOTRecurso As New d_OrdenTrabajo_Recurso
    Dim odOTActividad As New d_OrdenTrabajo_Actividad
    Dim odOCOT As New d_OrdenCmp_OrdenTrb

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenTrabajo
        Try
            Dim oeOrdenTrabajo = New e_OrdenTrabajo( _
                             o_fila("Id").ToString _
                             , o_fila("NroOT").ToString _
                             , o_fila("IdEstadoOT").ToString _
                             , o_fila("EstadoOT").ToString _
                             , o_fila("IndicadorTipo") _
                             , o_fila("FechaProgramacion") _
                             , o_fila("FechaIngresoTaller") _
                             , o_fila("FechaInicioTrabajo") _
                             , o_fila("FechaFinTrabajo") _
                             , o_fila("FechaTentativaSalida") _
                             , o_fila("IdJefeTaller") _
                             , o_fila("IdSupervisorMant") _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Auxilio").ToString _
                             , o_fila("Calibracion").ToString _
                             , o_fila("IdEmpresaExterna").ToString _
                             , o_fila("Activo") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("Siniestro") _
                             , o_fila("TipoOrden") _
                         )
            Return oeOrdenTrabajo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarReporteCE(ByVal o_fila As DataRow) As e_ReporteConsumoEquipo
        Try
            Dim oeReporteCE = New e_ReporteConsumoEquipo( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("CostoMaterial") _
                             , o_fila("CostoServicio") _
                             , o_fila("CostoAsignacion") _
                         )
            Return oeReporteCE
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarRMDOT(ByVal o_fila As DataRow) As e_MovimientoDiarioOT
        Try
            Dim oeRMDOT = New e_MovimientoDiarioOT( _
                                o_fila("NroOT").ToString _
                             , o_fila("IndicadorTipo").ToString _
                             , o_fila("TipoOrden").ToString _
                             , o_fila("Equipo").ToString _
                             , o_fila("TipoVehiculo").ToString _
                             , o_fila("Marca").ToString _
                             , o_fila("Modelo").ToString _
                             , o_fila("FechaIngresoTaller") _
                             , o_fila("FechaInicioTrabajo") _
                             , o_fila("FechaFinTrabajo") _
                             , o_fila("Kilometraje") _
                             , o_fila("Descripcion") _
                             , o_fila("Flota") _
                             )
            Return oeRMDOT
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajo As e_OrdenTrabajo) As e_OrdenTrabajo
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[MAN].[Isp_OrdenTrabajo_Listar]", "", oeOrdenTrabajo.Id, oeOrdenTrabajo.NroOT)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeOrdenTrabajo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrdenTrabajo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajo As e_OrdenTrabajo) As Data.DataSet
        Try
            Dim ds As DataSet
            With oeOrdenTrabajo
                ds = sqlhelper.ExecuteDataset("[MAN].[Isp_OrdenTrabajo_Listar]", .TipoOperacion _
                        , .Id _
                        , .NroOT _
                        , .IdEstadoOT _
                        , .FechaProgramacionIni _
                        , .FechaProgramacionFin _
                        , .IdEquipo _
                        , .IdTipoMantenimiento _
                        , .IdMantenimiento _
                        , .FechaIngresoTaller _
                        , .FechaInicioTrabajo _
                        , .FechaFinTrabajo _
                        , .IndicadorTipo _
                        , .Auxilio _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .IdSupervisorMant _
                        , .PrefijoCentro _
                                            )
            End With
            Return ds
            oeOrdenTrabajo = Nothing
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarReporteCE(ByVal oeReporteCE As e_ReporteConsumoEquipo) As List(Of e_ReporteConsumoEquipo)
        Try
            Dim leReporteCE As New List(Of e_ReporteConsumoEquipo)
            Dim ds As DataSet
            With oeReporteCE
                ds = sqlhelper.ExecuteDataset("MAN.Isp_ReporteConsumoEquipo_Listar", .TipoOperacion _
                        , .IdAlmacen _
                        , .Anio _
                        , .Mes _
                        , .Indicador _
                        , .Id _
                        , .IdMaterial)
            End With
            oeReporteCE = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReporteCE = CargarReporteCE(o_Fila)
                    leReporteCE.Add(oeReporteCE)
                Next
            End If
            Return leReporteCE
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarRMDOT(ByVal oeReporteMDOT As e_MovimientoDiarioOT) As List(Of e_MovimientoDiarioOT)
        Try
            Dim leReporteMDOT As New List(Of e_MovimientoDiarioOT)
            Dim ds As DataSet
            With oeReporteMDOT
                ds = sqlhelper.ExecuteDataset("[MAN].[Isp_MovimientoDiarioOT]", "" _
                                 , .Anio _
                        , .Mes _
                        , .IdMarca _
                        , .IdModelo _
                        , .IdTipoVehiculo _
                                )
            End With
            oeReporteMDOT = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReporteMDOT = CargarRMDOT(o_Fila)
                    leReporteMDOT.Add(oeReporteMDOT)
                Next
            End If
            Return leReporteMDOT
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ActualizaEstadoOT(ByVal oeOrdenTrabajo As e_OrdenTrabajo) As Boolean
        Try
            With oeOrdenTrabajo
                sqlhelper.ExecuteNonQuery("[MAN].[Isp_OrdenTrabajo_IAE]", .TipoOperacion, .PrefijoID,
                 .Id, .NroOT, .IdEstadoOT, .IndicadorTipo, .FechaProgramacionIni, .FechaIngresoTaller, .FechaInicioTrabajo _
                 , .FechaFinTrabajo, .FechaTentativaSalida, .IdJefeTaller, .IdSupervisorMant, .Glosa, .Auxilio, .IdEmpresaExterna _
                 , .Activo, .Calibracion, .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
       
    Public Function Guardar(ByVal oeOrdenTrabajo As e_OrdenTrabajo) As String
        Try
            Dim odReqMat As New d_RequerimientoMaterial
            Dim odReq As New d_Requerimiento
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeOrdenTrabajo
                    stResultado = sqlhelper.ExecuteScalar("[MAN].[Isp_OrdenTrabajo_IAE]", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .NroOT _
                            , .IdEstadoOT _
                            , .IndicadorTipo _
                            , .FechaProgramacionIni _
                            , .FechaIngresoTaller _
                            , .FechaInicioTrabajo _
                            , .FechaFinTrabajo _
                            , .FechaTentativaSalida _
                            , .IdJefeTaller _
                            , .IdSupervisorMant _
                            , .Glosa _
                            , .Auxilio _
                            , .IdEmpresaExterna _
                            , .Activo _
                            , .Calibracion _
                            , .UsuarioCreacion _
                            , .Siniestro _
                            , .UsuarioTermina _
                            , .TipoOrden).ToString.Split("_")
                    Dim oeOT_ME As New e_OrdenTrabajo_MantenimientoEquipo
                    oeOT_ME.Id = "" : oeOT_ME.IdOrdenTrabajo = stResultado(0)
                    odOTMantenimientoEquipo.Eliminar(oeOT_ME)
                    For Each Detalle As e_OrdenTrabajo_MantenimientoEquipo In .lstDetalleEquipoMantenimiento
                        Detalle.IdOrdenTrabajo = stResultado(0)
                        Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        Detalle.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                        odOTMantenimientoEquipo.Guardar(Detalle)
                    Next
                    Dim oeOTMat As New e_OrdenTrabajo_Material
                    oeOTMat.Id = "" : oeOTMat.IdOrdenTrabajo = stResultado(0)
                    odOTMaterial.Eliminar(oeOTMat)
                    For Each Detalle As e_OrdenTrabajo_Material In .lstDetalleMaterial
                        Detalle.IdOrdenTrabajo = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        Detalle.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                        odOTMaterial.Guardar(Detalle)
                        If Not Detalle.oeReqMaterial Is Nothing Then
                            Detalle.oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                            If Not String.IsNullOrEmpty(Detalle.oeReqMaterial.Tipooperacion) Then odReqMat.Guardar(Detalle.oeReqMaterial)
                        End If
                    Next
                    If .oeOCOT.IdOrdenCompra <> "" Then
                        .oeOCOT.TipoOperacion = .TipoOperacion
                        .oeOCOT.IdOrdenTrabajo = stResultado(0)
                        .oeOCOT.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                        odOCOT.Guardar(.oeOCOT)
                    End If
                    For Each oerq In .lstRequerimiento
                        oerq.TipoOperacion = "B"
                        oerq.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                        odReq.Guardar(oerq)
                    Next
                    Dim oeOTServ As New e_OrdenTrabajo_Servicio
                    oeOTServ.Id = "" : oeOTServ.IdOrdenTrabajo = stResultado(0)
                    odOTServicio.Eliminar(oeOTServ)
                    For Each Detalle As e_OrdenTrabajo_Servicio In .lstDetalleServicio
                        Detalle.IdOrdenTrabajo = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        Detalle.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                        odOTServicio.Guardar(Detalle)
                    Next
                    Dim oeOTRec As New e_OrdenTrabajo_Recurso
                    oeOTRec.Id = "" : oeOTRec.IdOrdenTrabajo = stResultado(0)
                    odOTRecurso.Eliminar(oeOTRec)
                    For Each Detalle As e_OrdenTrabajo_Recurso In .lstDetalleRecurso
                        Detalle.IdOrdenTrabajo = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        Detalle.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                        odOTRecurso.Guardar(Detalle)
                    Next
                    Dim oeOTAct As New e_OrdenTrabajo_Actividad
                    oeOTAct.Id = "" : oeOTAct.IdOrdenTrabajo = stResultado(0)
                    odOTActividad.Eliminar(oeOTAct)
                    For Each Detalle As e_OrdenTrabajo_Actividad In .lstDetalleActividad
                        Detalle.IdOrdenTrabajo = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                        Detalle.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                        odOTActividad.Guardar(Detalle)
                    Next
                    transScope.Complete()
                End With
            End Using
            Return stResultado(0).ToString
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenTrabajo As e_OrdenTrabajo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[MAN].[Isp_OrdenTrabajo_IAE]", "E", "", oeOrdenTrabajo.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
