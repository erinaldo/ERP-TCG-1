'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions

Public Class d_Requerimiento

    Private sqlhelper As New SqlHelper 'Instanciación de SqlHelper.

    Dim odRequerimientoMaterial As New d_RequerimientoMaterial
    Dim odRequerimientoServicio As New d_RequerimientoServicio

    '--------PARA LAS ORDENES DE SALIDA POR ATENCION DE REQUERIMIENTOS----------
    Dim odOrden As New d_Orden
    Dim oeOrdenTrabajoMat As New e_OrdenTrabajo_Material
    Dim odOrdenTrabajoMat As New d_OrdenTrabajo_Material
    Dim odRegistroInventario As New d_RegistroInventario
    '---------------------------------------------------------------------------
    '--------PARA LAS ORDENES DE SALIDA POR ATENCION DE REQUERIMIENTOS----------
    Dim oeOAMat As New e_OrdenAsignacion_Material
    Dim odOAMat As New d_OrdenAsignacion_Material
    '---------------------------------------------------------------------------
    Private Function Cargar(ByVal o_fila As DataRow) As e_Requerimiento
        Try
            Dim oeRequerimiento = New e_Requerimiento( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("FechaAtencion").ToString _
                             , o_fila("MaterialServicio").ToString _
                             , o_fila("IdEstadoRequerimiento").ToString _
                             , o_fila("EstadoRequerimiento").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("Area").ToString _
                             , o_fila("TipoReferencia").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("Referencia").ToString _
                             , o_fila("GlosaAtencion").ToString _
                             , o_fila("IdUsuarioAtencion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IdEquipo").ToString)
            Return oeRequerimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRequerimiento As e_Requerimiento) As e_Requerimiento
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_Requerimiento_Listar", _
                                          oeRequerimiento.TipoOperacion, _
                                          "01/01/1901", _
                                          "01/01/1901", _
                                          "", _
                                          "", _
                                          "", _
                                          oeRequerimiento.Activo, _
                                          oeRequerimiento.Id)

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeRequerimiento = Cargar(ds.Tables(0).Rows(0))                
            End If
            Return oeRequerimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRequerimiento As e_Requerimiento) As List(Of e_Requerimiento)
        Try
            Dim ldRequerimiento As New List(Of e_Requerimiento)
            Dim ds As DataSet
            With oeRequerimiento
                ds = sqlhelper.ExecuteDataset("CMP.Isp_Requerimiento_Listar", _
                                                    .TipoOperacion, _
                                                    .FechaInicio, _
                                                    .FechaFinal, _
                                                    .MaterialServicio, _
                                                    .OpcionFecha, _
                                                    .IdArea, _
                                                    .Activo, _
                                                    "", _
                                                    .UsuarioCreacion, _
                                                    .TipoReferencia, _
                                                    .IdReferencia, _
                                                    .IdEquipo, _
                                                    .IdTrabajador, _
                                                    .PrefijoCentro)

            End With
            oeRequerimiento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRequerimiento = Cargar(o_Fila)
                    ldRequerimiento.Add(oeRequerimiento)
                Next
            End If
            Return ldRequerimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(ByVal lstRequerimientos) As Boolean
        Try
            For Each item As e_Requerimiento In lstRequerimientos
                Guardar(item)
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRequerimiento As e_Requerimiento) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeRequerimiento
                    stResultado = sqlhelper.ExecuteScalar("CMP.Isp_Requerimiento_IAE" _
                            , .TipoOperacion _
                            , .PrefijoID _
                            , .Id _
                            , .FechaAtencion _
                            , .MaterialServicio _
                            , .IdEstadoRequerimiento _
                            , .Descripcion _
                            , .TipoReferencia _
                            , .IdReferencia _
                            , .IdEquipo _
                            , .IdTrabajador _
                            , .IdArea _
                            , .GlosaAtencion _
                            , .IdUsuarioAtencion _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .IdTrabajadorAprobacion).ToString.Split()

                    .Id = stResultado(0)
                    'El campo IdReferencia no se manejara en requerimientos, siempre sera null=nothing
                    '--------------GENERANDO Y EJECUTANDO ORDENES DE SALIDA POR ATENCIÓN DE REQUERIMIENTOS--------------
                    If .TipoOperacion = "D" Or .TipoOperacion = "R" Then 'Si es por atención de requerimiento
                        .oeOrdenSalida.PrefijoID = oeRequerimiento.PrefijoID '@0001
                        If .oeOrdenSalida.TipoOperacion <> String.Empty Then
                            odOrden.Guardar(.oeOrdenSalida) 'Generacion y ejecución de la orden de salida.
                            If Not String.IsNullOrEmpty(.IdReferencia.Trim) Then
                                For Each filaMat As e_OrdenMaterial In .oeOrdenSalida.lstOrdenMaterial
                                    filaMat.PrefijoID = oeRequerimiento.PrefijoID '@0001
                                    If .TipoReferencia.Equals("ORDEN ASIGNACION") Then
                                        oeOAMat.TipoOperacion = "U"
                                        oeOAMat.Activo = True
                                        oeOAMat.IdOrdenAsignacion = oeRequerimiento.IdReferencia
                                        oeOAMat.IdMaterial = filaMat.IdMaterial
                                        oeOAMat.CantidadMaterialEntregada = filaMat.CantidadMaterial
                                        oeOAMat.IdSubAlmacen = filaMat.IdSubAlmacen
                                        oeOAMat.PrefijoID = oeRequerimiento.PrefijoID '@0001
                                        odOAMat.Guardar(oeOAMat)
                                    End If
                                Next
                            End If
                        End If
                        If Not .oeOrdenIngreso Is Nothing Then
                            .oeOrdenIngreso.PrefijoID = oeRequerimiento.PrefijoID '@0001
                            If Not .oeOrdenIngreso.IdMovimientoInventario Is Nothing Then odOrden.Guardar(.oeOrdenIngreso)
                        End If

                        '' ''If Not .oeOrdenIngresoAlmPrincipal Is Nothing Then odOrden.Guardar(.oeOrdenIngresoAlmPrincipal)
                        '' ''If Not .oeOrdenSalidaAlmPrincipal Is Nothing Then odOrden.Guardar(.oeOrdenSalidaAlmPrincipal)

                        'Guarda el ingreso por Asignacion
                    End If
                    '-----------------------------------------------------------------------------------------------------
                    For Each Detalle As e_RequerimientoMaterial In .lstRequerimientoMaterial
                        Detalle.IdRequerimiento = stResultado(0) : Detalle.Tipooperacion = .TipoOperacion
                        If Detalle.CantidadAAtender > 0 Then : Detalle.CantidadPorAtender = Detalle.CantidadPorAtender - Detalle.CantidadAAtender : End If
                        If Detalle.Tipooperacion = "D" Then
                            If Detalle.IndRegularizado = False Then : Detalle.CantidadPorRegularizar = Detalle.CantidadAAtender + Detalle.CantidadPorRegularizar : End If
                        End If
                        If Detalle.Tipooperacion = "R" Then
                            If Detalle.CantidadARegularizar > 0 Then : Detalle.CantidadPorRegularizar = Detalle.CantidadPorRegularizar - Detalle.CantidadARegularizar : End If
                        End If
                        Detalle.PrefijoID = oeRequerimiento.PrefijoID '@0001
                        odRequerimientoMaterial.Guardar(Detalle)
                        If .TipoOperacion = "D" Then
                            oeOrdenTrabajoMat.TipoOperacion = "U"
                            oeOrdenTrabajoMat.Activo = True
                            oeOrdenTrabajoMat.IdOrdenTrabajo = oeRequerimiento.IdReferencia
                            oeOrdenTrabajoMat.IdMaterial = Detalle.IdMaterial
                            oeOrdenTrabajoMat.CantidadMaterialEntregada = Detalle.CantidadAAtender
                            oeOrdenTrabajoMat.IdSubAlmacen = Detalle.IdSubAlmacen
                            oeOrdenTrabajoMat.IdMantenimientoEquipo = Detalle.IdMantenimientoEquipo
                            oeOrdenTrabajoMat.PrefijoID = oeRequerimiento.PrefijoID '@0001
                            odOrdenTrabajoMat.Guardar(oeOrdenTrabajoMat) 'Modificamos la orden de trabajo
                        End If
                    Next
                    For Each Detalle As e_RequerimientoServicio In .lstRequerimientoServicio
                        Detalle.IdRequerimiento = stResultado(0) : Detalle.Tipooperacion = .TipoOperacion
                        Detalle.PrefijoID = oeRequerimiento.PrefijoID '@0001
                        odRequerimientoServicio.Guardar(Detalle)
                    Next
                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRequerimiento As e_Requerimiento) As Boolean
        Try
            With oeRequerimiento
                Dim stResultado() As String
                stResultado = sqlhelper.ExecuteScalar("CMP.Isp_Requerimiento_IAE" _
                                                        , .TipoOperacion _
                                                        , "" _
                                                        , .Id _
                                                       ).ToString.Split()
                'For Each Detalle As e_RequerimientoMaterial In .olRequerimientoMaterial                
                If (.MaterialServicio = "M") Then
                    Dim Detalle As New e_RequerimientoMaterial
                    Detalle.IdRequerimiento = stResultado(0)
                    Detalle.Tipooperacion = .TipoOperacion
                    odRequerimientoMaterial.Eliminar(Detalle)
                Else
                    Dim Detalle As New e_RequerimientoServicio
                    Detalle.IdRequerimiento = stResultado(0)
                    Detalle.Tipooperacion = .TipoOperacion
                    odRequerimientoServicio.Eliminar(Detalle)
                End If
                'Next
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarOT(ByVal oeRequerimiento As e_Requerimiento) As Boolean
        Try
            Dim stResultado() As String
            With oeRequerimiento
                stResultado = sqlhelper.ExecuteScalar("CMP.Isp_Requerimiento_IAE" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id).ToString.Split()
                .Id = stResultado(0)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
