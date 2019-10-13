'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenTrabajo
    Implements Il_OrdenTrabajo

    Dim odOrdenTrabajo As d_OrdenTrabajo
    Dim oeRequerimiento As New e_Requerimiento
    Dim olRequerimiento As New l_Requerimiento
    Dim leRequerimiento As New List(Of e_Requerimiento)
    Dim oeReqMaterial As New e_RequerimientoMaterial
    Dim odReqMaterial As New d_RequerimientoMaterial
    Dim oeIgv As New e_Impuesto
    Dim olIgv As New l_Impuesto
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function ActualizaEstadoOT(ByVal oeOrdenTrabajo As EntidadesWCF.e_OrdenTrabajo) As Boolean Implements Il_OrdenTrabajo.ActualizaEstadoOT
        Try
            odOrdenTrabajo = New d_OrdenTrabajo
            Return odOrdenTrabajo.ActualizaEstadoOT(oeOrdenTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenTrabajo As EntidadesWCF.e_OrdenTrabajo) As Boolean Implements Il_OrdenTrabajo.Eliminar
        Try
            odOrdenTrabajo = New d_OrdenTrabajo
            Return odOrdenTrabajo.Eliminar(oeOrdenTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenTrabajo As EntidadesWCF.e_OrdenTrabajo) As String Implements Il_OrdenTrabajo.Guardar
        Try
            odOrdenTrabajo = New d_OrdenTrabajo
            Dim idOT As String = ""
            Dim nigv As Double = 0
            Dim _idequi As String = ""
            Dim _cant As Double = 0
            Dim _cantaux As Double = 0
            Dim _cantmataux As Double = 0
            Dim _cantentaux As Double = 0
            Dim _cantreqaux As Double = 0
            Dim band As Boolean = False
            Dim _idrm As String = ""
            Dim olOTMaterial As New List(Of e_OrdenTrabajo_Material)
            Dim leReqAux As New List(Of e_Requerimiento)
            Dim leReqMatAux As New List(Of e_RequerimientoMaterial)
            If Validar(oeOrdenTrabajo) Then
                With oeOrdenTrabajo
                    Dim _Estado As String = ""
                    _Estado = IIf(.EstadoOT = "LIBERADA", "EN PROCESO", .EstadoOT)
                    If _Estado = "EN PROCESO" AndAlso .IndicadorTipo <> "E" AndAlso .TipoOperacion = "A" Then
                        oeIgv = olIgv.IGV(Date.Now.Date)
                        nigv = oeIgv.Porcentaje
                        .lstRequerimiento = New List(Of e_Requerimiento)
                        olOTMaterial = .lstDetalleMaterial.OrderBy(Function(item) item.IdEquipo & item.IdMantenimiento).ToList
                        For Each oeOTMaterial In olOTMaterial
                            If _idequi <> oeOTMaterial.IdEquipo Then
                                _idequi = oeOTMaterial.IdEquipo
                                leRequerimiento = New List(Of e_Requerimiento)
                                leReqAux = New List(Of e_Requerimiento)
                                oeRequerimiento = New e_Requerimiento
                                oeRequerimiento.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                oeRequerimiento.TipoOperacion = "3"
                                oeRequerimiento.TipoReferencia = "ORDEN TRABAJO"
                                oeRequerimiento.IdReferencia = .Id
                                oeRequerimiento.IdEquipo = _idequi
                                leRequerimiento = olRequerimiento.Listar(oeRequerimiento)
                                If leRequerimiento.Count > 0 Then
                                    oeRequerimiento = New e_Requerimiento
                                    oeRequerimiento = leRequerimiento(0)
                                    oeRequerimiento.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                    .lstRequerimiento.Add(oeRequerimiento)
                                    band = False
                                Else
                                    _cantaux = 0
                                    _cantmataux = 0
                                    _cantentaux = 0
                                    ' _cantaux = oeOTMaterial.CantidadMaterial - oeOTMaterial.CantidadMaterialEntregada
                                    _cantmataux = .lstDetalleMaterial.Where(Function(item) item.IdEquipo = _idequi).Sum(Function(item) item.CantidadMaterial)
                                    _cantentaux = .lstDetalleMaterial.Where(Function(item) item.IdEquipo = _idequi).Sum(Function(item) item.CantidadMaterialEntregada)
                                    _cantaux = _cantmataux - _cantentaux
                                    If _cantaux > 0 Then
                                        oeRequerimiento = New e_Requerimiento
                                        oeRequerimiento.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                        oeRequerimiento.TipoOperacion = "N"
                                        oeRequerimiento.TipoReferencia = "ORDEN TRABAJO"
                                        oeRequerimiento.IdReferencia = .Id
                                        oeRequerimiento.IdEquipo = _idequi
                                        oeRequerimiento.FechaAtencion = Date.Now.Date
                                        oeRequerimiento.MaterialServicio = "M"
                                        oeRequerimiento.IdEstadoRequerimiento = "1CH000000002"
                                        Dim _descrip As String = ObtieneGlosa(olOTMaterial, _idequi)
                                        oeRequerimiento.Descripcion = oeOTMaterial.Equipo & " / " & _descrip
                                        oeRequerimiento.UsuarioCreacion = oeOTMaterial.UsuarioCreacion
                                        olRequerimiento.Guardar(oeRequerimiento)
                                        band = True
                                    End If
                                End If
                            End If
                            If String.IsNullOrEmpty(oeOTMaterial.Id) Then
                                'Insertar nuevo material
                                oeReqMaterial = New e_RequerimientoMaterial
                                oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                oeReqMaterial.Tipooperacion = "I"
                                oeReqMaterial.IdRequerimiento = oeRequerimiento.Id
                                oeReqMaterial.IdMantenimiento = oeOTMaterial.IdMantenimiento
                                oeReqMaterial.IdSubAlmacen = oeOTMaterial.IdSubAlmacen
                                oeReqMaterial.IdUnidadMedida = oeOTMaterial.IdUnidadMedida
                                oeReqMaterial.IdMaterial = oeOTMaterial.IdMaterial
                                oeReqMaterial.Cantidad = oeOTMaterial.CantidadMaterial
                                oeReqMaterial.CantidadPorAtender = oeOTMaterial.CantidadMaterial
                                oeReqMaterial.Precio = oeOTMaterial.Costo * (1 + nigv)
                                oeReqMaterial.UsuarioCreacion = oeOTMaterial.UsuarioCreacion
                                oeReqMaterial.Glosa = String.Empty
                                oeReqMaterial.IdCentroCosto = String.Empty
                                oeReqMaterial.IndRegularizado = True
                                oeReqMaterial.CantidadPorRegularizar = 0
                                oeReqMaterial.Activo = True
                                oeReqMaterial.IdEstadoRequerimientoMaterial = "1CH000000006"
                                oeReqMaterial.IndicadorAprobacion = True
                                oeOTMaterial.oeReqMaterial = New e_RequerimientoMaterial
                                oeOTMaterial.oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                oeOTMaterial.oeReqMaterial = oeReqMaterial
                            Else
                                'Actualizar material
                                _cant = oeOTMaterial.CantidadMaterial - oeOTMaterial.CantidadMaterialEntregada
                                If _cant > 0 Then
                                    oeReqMaterial = New e_RequerimientoMaterial
                                    oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                    If band = True Then
                                        'Si no tiene ningun requerimiento por atender
                                        oeReqMaterial.Tipooperacion = "I"
                                        oeReqMaterial.IdRequerimiento = oeRequerimiento.Id
                                        oeReqMaterial.IdMantenimiento = oeOTMaterial.IdMantenimiento
                                        oeReqMaterial.IdSubAlmacen = oeOTMaterial.IdSubAlmacen
                                        oeReqMaterial.IdUnidadMedida = oeOTMaterial.IdUnidadMedida
                                        oeReqMaterial.IdMaterial = oeOTMaterial.IdMaterial
                                        oeReqMaterial.Cantidad = _cant
                                        oeReqMaterial.CantidadPorAtender = _cant
                                        oeReqMaterial.Precio = oeOTMaterial.Costo * (1 + nigv)
                                        oeReqMaterial.UsuarioCreacion = oeOTMaterial.UsuarioCreacion
                                        oeReqMaterial.Activo = True
                                        oeReqMaterial.IndicadorAprobacion = True
                                        oeReqMaterial.IndRegularizado = True
                                        oeReqMaterial.CantidadPorRegularizar = 0
                                        oeReqMaterial.IdEstadoRequerimientoMaterial = "1CH000000006"
                                        oeOTMaterial.oeReqMaterial = New e_RequerimientoMaterial
                                        oeOTMaterial.oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                        oeOTMaterial.oeReqMaterial = oeReqMaterial
                                    Else
                                        'Si tiene un requerimiento por atender
                                        _idrm = ""
                                        _cantreqaux = 0
                                        oeReqMaterial.Tipooperacion = "5"
                                        oeReqMaterial.IdMaterial = oeOTMaterial.IdMaterial
                                        oeReqMaterial.IdRequerimiento = oeRequerimiento.Id
                                        oeReqMaterial.IdMantenimiento = oeOTMaterial.IdMantenimiento
                                        leReqMatAux = odReqMaterial.Listar(oeReqMaterial)
                                        '_idrm = oeReqMaterial.Id
                                        If leReqMatAux.Count > 0 Then
                                            'Si tiene un requerimiento material por atender
                                            _idrm = leReqMatAux(0).Id
                                            _cantreqaux = leReqMatAux(0).Cantidad
                                            oeReqMaterial = New e_RequerimientoMaterial
                                            oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                            oeReqMaterial.Tipooperacion = "N"
                                            oeReqMaterial.Id = _idrm
                                            oeReqMaterial.Activo = 1
                                            'oeReqMaterial.Cantidad = oeOTMaterial.CantidadMaterial
                                            oeReqMaterial.Cantidad = _cantreqaux + (oeOTMaterial.CantidadMaterial - oeOTMaterial.CantAux)
                                            oeReqMaterial.CantidadPorAtender = _cant
                                            oeReqMaterial.IdMantenimiento = oeOTMaterial.IdMantenimiento
                                            oeOTMaterial.oeReqMaterial = New e_RequerimientoMaterial
                                            oeOTMaterial.oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                            oeOTMaterial.oeReqMaterial = oeReqMaterial
                                        Else
                                            'Si no tiene un requerimiento material por atender
                                            oeReqMaterial = New e_RequerimientoMaterial
                                            oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                            oeReqMaterial.Tipooperacion = "I"
                                            oeReqMaterial.IdRequerimiento = oeRequerimiento.Id
                                            oeReqMaterial.IdMantenimiento = oeOTMaterial.IdMantenimiento
                                            oeReqMaterial.IdSubAlmacen = oeOTMaterial.IdSubAlmacen
                                            oeReqMaterial.IdUnidadMedida = oeOTMaterial.IdUnidadMedida
                                            oeReqMaterial.IdMaterial = oeOTMaterial.IdMaterial
                                            oeReqMaterial.Cantidad = _cant
                                            oeReqMaterial.CantidadPorAtender = _cant
                                            oeReqMaterial.Precio = oeOTMaterial.Costo * (1 + nigv)
                                            oeReqMaterial.UsuarioCreacion = oeOTMaterial.UsuarioCreacion
                                            oeReqMaterial.Activo = True
                                            oeReqMaterial.IndicadorAprobacion = True
                                            oeReqMaterial.IndRegularizado = True
                                            oeReqMaterial.CantidadPorRegularizar = 0
                                            oeReqMaterial.IdEstadoRequerimientoMaterial = "1CH000000006"
                                            oeOTMaterial.oeReqMaterial = New e_RequerimientoMaterial
                                            oeOTMaterial.oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                            oeOTMaterial.oeReqMaterial = oeReqMaterial
                                        End If
                                    End If
                                Else
                                    If oeOTMaterial.CantidadMaterial < oeOTMaterial.CantAux Then
                                        _idrm = ""
                                        _cantreqaux = 0
                                        oeReqMaterial = New e_RequerimientoMaterial
                                        oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                        oeReqMaterial.Tipooperacion = "5"
                                        oeReqMaterial.IdMaterial = oeOTMaterial.IdMaterial
                                        oeReqMaterial.IdRequerimiento = oeRequerimiento.Id
                                        oeReqMaterial.IdMantenimiento = oeOTMaterial.IdMantenimiento
                                        leReqMatAux = odReqMaterial.Listar(oeReqMaterial)
                                        '_idrm = oeReqMaterial.Id
                                        If leReqMatAux.Count > 0 Then
                                            _idrm = leReqMatAux(0).Id
                                            _cantreqaux = leReqMatAux(0).Cantidad
                                            Dim _nvocant = _cantreqaux + (oeOTMaterial.CantidadMaterial - oeOTMaterial.CantAux)
                                            If _nvocant > 0 Then
                                                oeReqMaterial = New e_RequerimientoMaterial
                                                oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                                oeReqMaterial.Tipooperacion = "N"
                                                oeReqMaterial.Id = _idrm
                                                oeReqMaterial.Activo = 1
                                                'oeReqMaterial.Cantidad = oeOTMaterial.CantidadMaterial
                                                oeReqMaterial.Cantidad = _nvocant
                                                oeReqMaterial.CantidadPorAtender = _cant
                                                oeReqMaterial.IdMantenimiento = oeOTMaterial.IdMantenimiento
                                                oeOTMaterial.oeReqMaterial = New e_RequerimientoMaterial
                                                oeOTMaterial.oeReqMaterial.PrefijoID = oeOrdenTrabajo.PrefijoID '@0001
                                                oeOTMaterial.oeReqMaterial = oeReqMaterial
                                            End If
                                        End If
                                    End If
                                End If

                            End If
                        Next
                    End If
                End With
                idOT = odOrdenTrabajo.Guardar(oeOrdenTrabajo)
            End If
            Return idOT
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajo As EntidadesWCF.e_OrdenTrabajo) As System.Data.DataSet Implements Il_OrdenTrabajo.Listar
        Try
            odOrdenTrabajo = New d_OrdenTrabajo
            Return odOrdenTrabajo.Listar(oeOrdenTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajo As EntidadesWCF.e_OrdenTrabajo) As EntidadesWCF.e_OrdenTrabajo Implements Il_OrdenTrabajo.Obtener
        Try
            odOrdenTrabajo = New d_OrdenTrabajo
            Return odOrdenTrabajo.Obtener(oeOrdenTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenTrabajo As EntidadesWCF.e_OrdenTrabajo) As Boolean Implements Il_OrdenTrabajo.Validar
        Try
            With oeOrdenTrabajo
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdJefeTaller, "Seleccione un Jefe de Taller")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdSupervisorMant, "Seleccione un Supervisor de Mantenimiento")
                If .IndicadorTipo = "E" AndAlso String.IsNullOrEmpty(.IdEmpresaExterna) Then Throw New Exception("Seleccione una Empresa")
                l_FuncionesGenerales.ValidarNumero(oeOrdenTrabajo.lstDetalleEquipoMantenimiento.Count, "La Orden Trabajo no contiene ni un equipo y matenimiento")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarReporteCE(ByVal oeReporteCE As EntidadesWCF.e_ReporteConsumoEquipo) As System.Collections.Generic.List(Of EntidadesWCF.e_ReporteConsumoEquipo) Implements Il_OrdenTrabajo.ListarReporteCE
        Try
            odOrdenTrabajo = New d_OrdenTrabajo
            Return odOrdenTrabajo.ListarReporteCE(oeReporteCE)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarRMDOT(ByVal oeReporteMDOT As EntidadesWCF.e_MovimientoDiarioOT) As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoDiarioOT) Implements Il_OrdenTrabajo.ListarRMDOT
        Try
            odOrdenTrabajo = New d_OrdenTrabajo
            Return odOrdenTrabajo.ListarRMDOT(oeReporteMDOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtieneGlosa(ByVal leOTMaterial As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenTrabajo_Material), ByVal Equipo As String) As String Implements Il_OrdenTrabajo.ObtieneGlosa
        Try
            Dim leAux = leOTMaterial.Where(Function(item) item.IdEquipo = Equipo And item.CantidadMaterial > item.CantidadMaterialEntregada).ToList
            Dim _cad As String = ""
            Dim _mant As String = ""
            For Each oeAux In leAux
                If _mant <> oeAux.Mantenimiento Then
                    _mant = oeAux.Mantenimiento
                    _cad = _cad & _mant & " / "
                End If
            Next
            _cad = _cad.Substring(0, _cad.Length - 2)
            Return _cad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
