Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenAsignacion
    Implements Il_OrdenAsignacion

    Dim odOrdenAsignacion As New d_OrdenAsignacion
    Dim oeRequerimiento As New e_Requerimiento
    Dim olRequerimiento As New l_Requerimiento
    Dim leRequerimiento As New List(Of e_Requerimiento)
    Dim oeReqMaterial As New e_RequerimientoMaterial
    Dim odReqMaterial As New d_RequerimientoMaterial
    Dim oeIgv As New e_Impuesto
    Dim olIgv As New l_Impuesto

    Public Function Eliminar(ByVal oeOrdenAsignacion As EntidadesWCF.e_OrdenAsignacion) As Boolean Implements Il_OrdenAsignacion.Eliminar
        Try
            Return odOrdenAsignacion.Eliminar(oeOrdenAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenAsignacion As EntidadesWCF.e_OrdenAsignacion) As Boolean Implements Il_OrdenAsignacion.Guardar
        Try
            Dim idOT As String = ""
            Dim nigv As Double = 0
            Dim _idequi As String = ""
            Dim _indunidad As String = ""
            Dim _cant As Double = 0
            Dim _cantaux As Double = 0
            Dim _cantmataux As Double = 0
            Dim _cantentaux As Double = 0
            Dim _cantreqaux As Double = 0
            Dim band As Boolean = False
            Dim _idrm As String = ""
            Dim leReqAux As New List(Of e_Requerimiento)
            Dim leReqMatAux As New List(Of e_RequerimientoMaterial)
            If Validar(oeOrdenAsignacion) Then
                With oeOrdenAsignacion
                    If .EstadoOA = "EN PROCESO" AndAlso .TipoOperacion = "A" Then
                        oeIgv = olIgv.IGV(Date.Now.Date)
                        nigv = oeIgv.Porcentaje
                        If .lstUnidadAsignada.Count > 0 Then
                            _idequi = .lstUnidadAsignada(0).IdUnidadAsignacion
                            _indunidad = .lstUnidadAsignada(0).IndUnidadAsignacion
                        End If
                        .lstRequerimiento = New List(Of e_Requerimiento)
                        leRequerimiento = New List(Of e_Requerimiento)
                        leReqAux = New List(Of e_Requerimiento)
                        oeRequerimiento = New e_Requerimiento
                        oeRequerimiento.TipoOperacion = "4"
                        oeRequerimiento.TipoReferencia = "ORDEN ASIGNACION"
                        oeRequerimiento.IdReferencia = .Id
                        Select Case _indunidad
                            Case "V" : oeRequerimiento.IdEquipo = _idequi
                            Case "T" : oeRequerimiento.IdTrabajador = _idequi
                            Case "A" : oeRequerimiento.IdArea = _idequi
                        End Select
                        leRequerimiento = olRequerimiento.Listar(oeRequerimiento)
                        If leRequerimiento.Count > 0 Then
                            oeRequerimiento = New e_Requerimiento
                            oeRequerimiento = leRequerimiento(0)
                            .lstRequerimiento.Add(oeRequerimiento)
                            band = False
                        Else
                            _cantaux = 0
                            _cantmataux = 0
                            _cantentaux = 0
                            ' _cantaux = oeOTMaterial.CantidadMaterial - oeOTMaterial.CantidadMaterialEntregada
                            _cantmataux = .lstUnidadAsignadaMat.Sum(Function(item) item.CantidadMaterial)
                            _cantentaux = .lstUnidadAsignadaMat.Sum(Function(item) item.CantidadMaterialEntregada)
                            _cantaux = _cantmataux - _cantentaux
                            If _cantaux > 0 Then
                                oeRequerimiento = New e_Requerimiento
                                oeRequerimiento.TipoOperacion = "N"
                                oeRequerimiento.TipoReferencia = "ORDEN ASIGNACION"
                                oeRequerimiento.IdReferencia = .Id
                                Select Case _indunidad
                                    Case "V" : oeRequerimiento.IdEquipo = _idequi
                                    Case "T" : oeRequerimiento.IdTrabajador = _idequi
                                    Case "A" : oeRequerimiento.IdArea = _idequi
                                End Select
                                oeRequerimiento.FechaAtencion = Date.Now.Date
                                oeRequerimiento.MaterialServicio = "M"
                                oeRequerimiento.IdEstadoRequerimiento = "1CH000000002"
                                oeRequerimiento.Descripcion = .UnidadAsignada & " / ASIGNACION DE MATERIALES"
                                oeRequerimiento.UsuarioCreacion = .IdUsuario
                                olRequerimiento.Guardar(oeRequerimiento)
                                band = True
                            End If
                        End If
                        For Each oeOAMaterial In .lstUnidadAsignadaMat
                            If String.IsNullOrEmpty(oeOAMaterial.Id) Then
                                'Insertar nuevo material
                                oeReqMaterial = New e_RequerimientoMaterial
                                oeReqMaterial.Tipooperacion = "I"
                                oeReqMaterial.IdRequerimiento = oeRequerimiento.Id
                                oeReqMaterial.IdMantenimiento = ""
                                oeReqMaterial.IdSubAlmacen = oeOAMaterial.IdSubAlmacen
                                oeReqMaterial.IdUnidadMedida = oeOAMaterial.IdUnidadMedida
                                oeReqMaterial.IdMaterial = oeOAMaterial.IdMaterial
                                oeReqMaterial.Cantidad = oeOAMaterial.CantidadMaterial
                                oeReqMaterial.CantidadPorAtender = oeOAMaterial.CantidadMaterial
                                oeReqMaterial.Precio = oeOAMaterial.CostoUnitario * (1 + nigv)
                                oeReqMaterial.UsuarioCreacion = oeOAMaterial.UsuarioCreacion
                                oeReqMaterial.IdCentroCosto = String.Empty
                                oeReqMaterial.Glosa = String.Empty
                                oeReqMaterial.IdCentroCosto = String.Empty
                                oeReqMaterial.Activo = True
                                oeReqMaterial.IdEstadoRequerimientoMaterial = "1CH000000006"
                                oeReqMaterial.IndicadorAprobacion = True
                                oeOAMaterial.oeReqMaterial = New e_RequerimientoMaterial
                                oeOAMaterial.oeReqMaterial = oeReqMaterial
                            Else
                                'Actualizar material
                                _cant = oeOAMaterial.CantidadMaterial - oeOAMaterial.CantidadMaterialEntregada
                                If _cant > 0 Then
                                    oeReqMaterial = New e_RequerimientoMaterial
                                    If band = True Then
                                        'Si no tiene ningun requerimiento por atender
                                        oeReqMaterial.Tipooperacion = "I"
                                        oeReqMaterial.IdRequerimiento = oeRequerimiento.Id
                                        oeReqMaterial.IdMantenimiento = ""
                                        oeReqMaterial.IdSubAlmacen = oeOAMaterial.IdSubAlmacen
                                        oeReqMaterial.IdUnidadMedida = oeOAMaterial.IdUnidadMedida
                                        oeReqMaterial.IdMaterial = oeOAMaterial.IdMaterial
                                        oeReqMaterial.IdCentroCosto = ""
                                        oeReqMaterial.Cantidad = _cant
                                        oeReqMaterial.CantidadPorAtender = _cant
                                        oeReqMaterial.Precio = oeOAMaterial.CostoUnitario * (1 + nigv)
                                        oeReqMaterial.UsuarioCreacion = oeOAMaterial.UsuarioCreacion
                                        oeReqMaterial.Activo = True
                                        oeReqMaterial.IndicadorAprobacion = True
                                        oeReqMaterial.IdEstadoRequerimientoMaterial = "1CH000000006"
                                        oeOAMaterial.oeReqMaterial = New e_RequerimientoMaterial
                                        oeOAMaterial.oeReqMaterial = oeReqMaterial
                                    Else
                                        'Si tiene un requerimiento por atender
                                        _idrm = ""
                                        _cantreqaux = 0
                                        oeReqMaterial.Tipooperacion = "5"
                                        oeReqMaterial.IdMaterial = oeOAMaterial.IdMaterial
                                        oeReqMaterial.IdRequerimiento = oeRequerimiento.Id
                                        oeReqMaterial.IdMantenimiento = ""
                                        leReqMatAux = odReqMaterial.Listar(oeReqMaterial)
                                        '_idrm = oeReqMaterial.Id
                                        If leReqMatAux.Count > 0 Then
                                            'Si tiene un requerimiento material por atender
                                            _idrm = leReqMatAux(0).Id
                                            _cantreqaux = leReqMatAux(0).Cantidad
                                            oeReqMaterial = New e_RequerimientoMaterial
                                            oeReqMaterial.Tipooperacion = "N"
                                            oeReqMaterial.Id = _idrm
                                            oeReqMaterial.Activo = 1
                                            'oeReqMaterial.Cantidad = oeOTMaterial.CantidadMaterial
                                            oeReqMaterial.Cantidad = _cantreqaux + (oeOAMaterial.CantidadMaterial - oeOAMaterial.CantAux)
                                            oeReqMaterial.CantidadPorAtender = _cant
                                            oeReqMaterial.IdMantenimiento = ""
                                            oeOAMaterial.oeReqMaterial = New e_RequerimientoMaterial
                                            oeOAMaterial.oeReqMaterial = oeReqMaterial
                                        Else
                                            'Si no tiene un requerimiento material por atender
                                            oeReqMaterial = New e_RequerimientoMaterial
                                            oeReqMaterial.Tipooperacion = "I"
                                            oeReqMaterial.IdRequerimiento = oeRequerimiento.Id
                                            oeReqMaterial.IdMantenimiento = ""
                                            oeReqMaterial.IdSubAlmacen = oeOAMaterial.IdSubAlmacen
                                            oeReqMaterial.IdUnidadMedida = oeOAMaterial.IdUnidadMedida
                                            oeReqMaterial.IdMaterial = oeOAMaterial.IdMaterial
                                            oeReqMaterial.Cantidad = _cant
                                            oeReqMaterial.CantidadPorAtender = _cant
                                            oeReqMaterial.IdCentroCosto = ""
                                            oeReqMaterial.Precio = oeOAMaterial.CostoUnitario * (1 + nigv)
                                            oeReqMaterial.UsuarioCreacion = oeOAMaterial.UsuarioCreacion
                                            oeReqMaterial.Activo = True
                                            oeReqMaterial.IndicadorAprobacion = True
                                            oeReqMaterial.IdEstadoRequerimientoMaterial = "1CH000000006"
                                            oeOAMaterial.oeReqMaterial = New e_RequerimientoMaterial
                                            oeOAMaterial.oeReqMaterial = oeReqMaterial
                                        End If
                                    End If
                                Else
                                    If oeOAMaterial.CantidadMaterial < oeOAMaterial.CantAux Then
                                        _idrm = ""
                                        _cantreqaux = 0
                                        oeReqMaterial = New e_RequerimientoMaterial
                                        oeReqMaterial.Tipooperacion = "5"
                                        oeReqMaterial.IdMaterial = oeOAMaterial.IdMaterial
                                        oeReqMaterial.IdRequerimiento = oeRequerimiento.Id
                                        oeReqMaterial.IdMantenimiento = ""
                                        leReqMatAux = odReqMaterial.Listar(oeReqMaterial)
                                        '_idrm = oeReqMaterial.Id
                                        If leReqMatAux.Count > 0 Then
                                            _idrm = leReqMatAux(0).Id
                                            _cantreqaux = leReqMatAux(0).Cantidad
                                            oeReqMaterial = New e_RequerimientoMaterial
                                            oeReqMaterial.Tipooperacion = "N"
                                            oeReqMaterial.Id = _idrm
                                            oeReqMaterial.Activo = 1
                                            'oeReqMaterial.Cantidad = oeOTMaterial.CantidadMaterial
                                            oeReqMaterial.Cantidad = _cantreqaux + (oeOAMaterial.CantidadMaterial - oeOAMaterial.CantAux)
                                            oeReqMaterial.CantidadPorAtender = _cant
                                            oeReqMaterial.IdMantenimiento = ""
                                            oeOAMaterial.oeReqMaterial = New e_RequerimientoMaterial
                                            oeOAMaterial.oeReqMaterial = oeReqMaterial
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    End If
                End With
                Return odOrdenAsignacion.Guardar(oeOrdenAsignacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenAsignacion As EntidadesWCF.e_OrdenAsignacion) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenAsignacion) Implements Il_OrdenAsignacion.Listar
        Try
            Return odOrdenAsignacion.Listar(oeOrdenAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenAsignacion As EntidadesWCF.e_OrdenAsignacion) As EntidadesWCF.e_OrdenAsignacion Implements Il_OrdenAsignacion.Obtener
        Try
            Return odOrdenAsignacion.Obtener(oeOrdenAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenAsignacion As EntidadesWCF.e_OrdenAsignacion) As Boolean Implements Il_OrdenAsignacion.Validar
        Try
            With oeOrdenAsignacion

                If oeOrdenAsignacion.lstUnidadAsignada.Count = 0 Then Throw New Exception("Asignar Unidad")
                If oeOrdenAsignacion.lstUnidadAsignadaMat.Count = 0 Then Throw New Exception("Seleccione Materiales")
                For Each item As e_OrdenAsignacion_Material In oeOrdenAsignacion.lstUnidadAsignadaMat
                    If String.IsNullOrEmpty(Trim(item.IdSubAlmacen)) Then Throw New Exception("Revisar Almacén tenga Lote")
                    If String.IsNullOrEmpty(item.CantidadMaterial) Then Throw New Exception("Ingresar Cantidad de Material")
                    If item.CantidadMaterial = 0 Then Throw New Exception("Cantidad de Material tiene que ser mayor a 0")
                Next
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarReporte(ByVal oeReporteOA As EntidadesWCF.e_ReporteOA) As System.Collections.Generic.List(Of EntidadesWCF.e_ReporteOA) Implements Il_OrdenAsignacion.ListarReporte
        Try
            Return odOrdenAsignacion.ListarReporte(oeReporteOA)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
