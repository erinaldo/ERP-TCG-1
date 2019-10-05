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
Imports System.Transactions


<DataContract(), Serializable()> _
Public Class l_Orden
    Implements Il_Orden

    Dim odOrden As d_Orden
    Dim odRegistroInventario As d_RegistroInventario
    Dim odOrdAsig As d_OrdenAsignacion
    Dim odOrdAsigMat As d_OrdenAsignacion_Material
    Dim odOrdTra As d_OrdenTrabajo
    Dim odOrdTraMat As d_OrdenTrabajo_Material
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeOrden As EntidadesWCF.e_Orden) As Boolean Implements Il_Orden.Eliminar
        Try
            odOrden = New d_Orden
            Return odOrden.Eliminar(oeOrden)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeOrden As EntidadesWCF.e_Orden, lstRegInventario As List(Of e_RegistroInventario)) As Boolean Implements Il_Orden.Guardar
        Try
            Dim oeAsientoModelo As New e_AsientoModelo
            Dim oeAsiento As New e_Asiento
            Dim loAsiento As New List(Of e_Asiento)
            Dim olAsiento As New l_Asiento
            Dim oeAsientoMovimiento As New e_AsientoMovimiento
            Dim loAsientoMovimiento As New List(Of e_AsientoMovimiento)
            Dim oeAsientoAnalisis As New e_MovimientoAnalisis
            Dim cta42 As String = "", titulo42 As String = "", fila As String = ""
            Using TransScope As New TransactionScope()
                odOrden = New d_Orden
                If Not Validar(oeOrden) Then Return False
                If Not odOrden.Guardar(oeOrden) Then Return False
                If lstRegInventario.Count > 0 Then
                    odRegistroInventario = New d_RegistroInventario
                    For Each oe As e_RegistroInventario In lstRegInventario
                        oe.PrefijoID = oeOrden.PrefijoID '@0001
                        odRegistroInventario.GuardarRegistroInventario(oe)
                    Next
                End If
                If oeOrden.IdTipoOrden = "1CH000000001" Then
                    If oeOrden.lstInventario.Count > 0 Then
                        Select Case oeOrden.IdMovimientoInventario
                            Case "1CH000000013"
                                ModificarCantidadDevolucionOT(oeOrden)
                            Case "1CH000000018"
                                ModificarCantidadDevolucionOA(oeOrden)
                        End Select
                    End If
                    If oeOrden.IndAsiento Then
                        For Each asimod As e_AsientoModelo In oeOrden.loAsientoModelo
                            oeAsiento = New e_Asiento
                            loAsientoMovimiento = New List(Of e_AsientoMovimiento)
                            With oeAsiento
                                .PrefijoID = oeOrden.PrefijoID '@0001
                                .TipoOperacion = "I" : .IdPeriodo = oeOrden.IdPeriodo : .IdTipoAsiento = asimod.IdTipoAsiento
                                .NroAsiento = String.Empty : .Fecha = oeOrden.FechaOrden
                                .Glosa = IIf(oeOrden.IdMovimientoInventario = "1SI000000002", "INGRESO POR AJUSTE", asimod.Nombre) & " " & oeOrden.NroOrden & " " & oeOrden.Glosa & " " & oeOrden.NombreProveedor
                                .GlosaImprime = String.Empty : .IdMoneda = asimod.IdMoneda : .TipoCambio = oeOrden.TipoCambio
                                .TotalDebe = Math.Round(oeOrden.loCtaCtbleSFam.Sum(Function(item) item.TotalCuentas), 2)
                                .TotalHaber = Math.Round(oeOrden.loCtaCtbleSFam.Sum(Function(item) item.TotalCuentas), 2)
                                .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeOrden.IdUsuarioEjecucion : oeAsiento.Activo = True
                                .IndOrigen = 2
                                .AsientoReferencia = New e_AsientoReferencia
                                .AsientoReferencia.PrefijoID = oeOrden.PrefijoID '@0001
                                .AsientoReferencia.TipoOperacion = "I"
                                .AsientoReferencia.IdReferencia = oeOrden.Id
                                .AsientoReferencia.TipoReferencia = 1
                            End With
                            Dim flaganalisis As Boolean = False
                            For Each ctactblesfm As e_CtaCtbleSubFamiliaMat In oeOrden.loCtaCtbleSFam
                                For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle.OrderBy(Function(item) item.Fila).ToList
                                    oeAsientoMovimiento = New e_AsientoMovimiento
                                    flaganalisis = False
                                    With oeAsientoMovimiento
                                        .PrefijoID = oeOrden.PrefijoID '@0001
                                        .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                        .IdUsuarioCrea = oeOrden.IdUsuarioEjecucion : .Activo = True : .Fila = asidet.Fila
                                        If Left(ctactblesfm.NroCtaCtbleExistencias, 2) = asidet.Cuenta.Trim Then
                                            .IdCuentaContable = ctactblesfm.IdCtaCtbleExistencias
                                        End If
                                        If Left(ctactblesfm.NroCtaCtbleCompra, 2) = asidet.Cuenta.Trim Then
                                            .IdCuentaContable = ctactblesfm.IdCtaCtbleCompras
                                        End If
                                        If Left(ctactblesfm.NroCtaCtbleConsumo, 2) = asidet.Cuenta.Trim Then
                                            flaganalisis = True
                                            .IdCuentaContable = ctactblesfm.IdCtaCtbleConsumo
                                        End If
                                        If .IdCuentaContable.Trim <> "" Then
                                            If asidet.Partida = 1 Then
                                                If asimod.IdMoneda = "1CH01" Then
                                                    .DebeMN = ctactblesfm.TotalCuentas
                                                    .DebeME = ctactblesfm.TotalCuentas / oeOrden.TipoCambio
                                                Else
                                                    .DebeME = ctactblesfm.TotalCuentas
                                                    .DebeMN = ctactblesfm.TotalCuentas * oeOrden.TipoCambio
                                                End If
                                                If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                            Else
                                                If asimod.IdMoneda = "1CH01" Then
                                                    .HaberMN = ctactblesfm.TotalCuentas
                                                    .HaberME = ctactblesfm.TotalCuentas / oeOrden.TipoCambio
                                                Else
                                                    .HaberME = ctactblesfm.TotalCuentas
                                                    .HaberMN = ctactblesfm.TotalCuentas * oeOrden.TipoCambio
                                                End If
                                                If flaganalisis = True And asimod.TipoAsiento = "DIARIO" Then
                                                    oeAsientoAnalisis = New e_MovimientoAnalisis
                                                    oeAsientoAnalisis.PrefijoID = oeOrden.PrefijoID '@0001
                                                    oeAsientoAnalisis.TipoOperacion = ""
                                                    oeAsientoAnalisis.IdMoneda = asimod.IdMoneda
                                                    oeAsientoAnalisis.IdUsuarioCrea = oeOrden.IdUsuarioEjecucion
                                                    oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                                                    If asimod.IdMoneda = "1CH01" Then
                                                        oeAsientoAnalisis.Monto = .HaberMN
                                                        oeAsientoAnalisis.Saldo = .HaberMN
                                                    Else
                                                        oeAsientoAnalisis.Monto = .HaberME
                                                        oeAsientoAnalisis.Saldo = .HaberME
                                                    End If
                                                    oeAsientoAnalisis.IdVehiculo = "1SI000000059"
                                                    .MovimientoAnalisis.Add(oeAsientoAnalisis)
                                                End If
                                                If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                            End If
                                        Else
                                            cta42 = asidet.IdCuentaContable.Trim
                                            titulo42 = asidet.Titulo
                                            fila = asidet.Fila
                                        End If
                                    End With
                                Next
                            Next
                            If titulo42 <> "" Then
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                With oeAsientoMovimiento
                                    .PrefijoID = oeOrden.PrefijoID '@0001
                                    .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                    .IdUsuarioCrea = oeOrden.IdUsuarioEjecucion : .Activo = True
                                    If asimod.IdMoneda = "1CH01" Then
                                        .HaberMN = oeOrden.loCtaCtbleSFam.Sum(Function(item) item.TotalCuentas)
                                        .HaberME = .HaberMN / oeOrden.TipoCambio
                                    Else
                                        .HaberME = oeOrden.loCtaCtbleSFam.Sum(Function(item) item.TotalCuentas)
                                        .HaberMN = .HaberME * oeOrden.TipoCambio
                                    End If
                                    .IdCuentaContable = cta42
                                    .Fila = fila
                                End With
                                loAsientoMovimiento.Add(oeAsientoMovimiento)
                                titulo42 = ""
                            End If
                            oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                            loAsiento.Add(oeAsiento)
                        Next
                        If Not olAsiento.GuardarLista(loAsiento) Then Throw New Exception("No Se Completo la Transaccion")
                    End If
                End If
                If oeOrden.IdTipoOrden = "1CH000000002" Then
                    If oeOrden.IdMovimientoInventario = "1CH000000023" Then GuardarITransferencia(oeOrden)
                    GenerarAsientoConsumo(oeOrden)
                End If
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub GuardarITransferencia(oeOrdenSalida As e_Orden)
        Try
            Dim oeOrdenIngreso As New e_Orden
            Dim listaOrdenMaterial As New List(Of e_OrdenMaterial)
            With oeOrdenIngreso
                .TipoOperacion = "I"
                .IdTipoOrden = "1CH000000001" ' ORDEN DE INGRESO
                .TipoReferencia = "ORDEN DE TRANSFERENCIA"
                .Referencia = oeOrdenSalida.Referencia
                .Id = ""
                .NroOrden = ""
                .IdProveedor = oeOrdenSalida.IdProveedor
                .FechaOrden = Date.Now
                oeOrdenIngreso.IdMoneda = "1CH01"
                oeOrdenIngreso.IdMovimientoInventario = "1CH000000022" 'INGRESO POR TRANSFERENCIA ENTRE ALMACENES
                oeOrdenIngreso.IdEstadoOrden = ""
                oeOrdenIngreso.UsuarioCreacion = oeOrdenSalida.IdUsuarioEjecucion
                oeOrdenIngreso.IdSubAlmacenOrigen = ""
                oeOrdenIngreso.IdSubAlmacenDestino = ""

                Dim oeOrdenTransferencia As New e_Orden
                oeOrdenTransferencia.Id = ""
                oeOrdenTransferencia.NroOrden = oeOrdenSalida.Referencia
                oeOrdenTransferencia = odOrden.Obtener(oeOrdenTransferencia)

                For Each item As e_OrdenMaterial In oeOrdenSalida.lstOrdenMaterial
                    item.TipoOperacion = "I"
                    item.UsuarioCreacion = oeOrdenSalida.IdUsuarioEjecucion
                    item.Activo = 1
                    item.IdSubAlmacen = oeOrdenTransferencia.IdSubAlmacenDestino
                    item.IdAlmacen = "" 'oeOrdenTransferencia.IdSubAlmacenOrigen
                    listaOrdenMaterial.Add(item)
                Next
                oeOrdenIngreso.lstOrdenMaterial = New List(Of e_OrdenMaterial)
                oeOrdenIngreso.lstOrdenMaterial = listaOrdenMaterial
            End With
            odOrden.Guardar(oeOrdenIngreso)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Public Function GuardarOrdenSalidaPorRequerimiento(ByVal oeOrden As EntidadesWCF.e_Orden) As String Implements Il_Orden.GuardarOrdenSalidaPorRequerimiento
    '    Try
    '        odOrden = New d_Orden
    '        Validar(oeOrden)
    '        Return odOrden.GuardarOrdenSalidaPorRequerimiento(oeOrden)
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function

    Public Function Listar(ByVal oeOrden As EntidadesWCF.e_Orden) As System.Collections.Generic.List(Of EntidadesWCF.e_Orden) Implements Il_Orden.Listar
        Try
            odOrden = New d_Orden
            Return odOrden.Listar(oeOrden)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrden As EntidadesWCF.e_Orden) As EntidadesWCF.e_Orden Implements Il_Orden.Obtener
        Try
            odOrden = New d_Orden
            If Not oeOrden.TipoOrden Is Nothing Then
                If oeOrden.TipoOrden.Equals("ORDEN DE COMPRA") Then
                    oeOrden.TipoOperacion = "4"
                Else
                    oeOrden.TipoOperacion = ""
                End If
            Else
                If oeOrden.TipoOperacion <> "R" Then
                    oeOrden.TipoOperacion = ""
                End If
            End If
            Return odOrden.Obtener(oeOrden)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrden As EntidadesWCF.e_Orden) As Boolean Implements Il_Orden.Validar
        Try
            With oeOrden
                'Dim odMovInvAlmacen As New d_MovimientoInventarioAlmacen
                'Dim oeMovInvAlmacen As New e_MovimientoInventarioAlmacen
                'Dim loMovInvAlmacen As New List(Of e_MovimientoInventarioAlmacen)
                If .FechaOrden.Date > Date.Now.Date Then Throw New Exception("Verifique la Fecha de la Orden")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdProveedor, "Seleccione un proveedor a la orden")
                If .IdTipoOrden = "1CH000000003" Then
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdCentro, "Debe seleccionar centro de Origen")
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdSubAlmacenOrigen, "Seleccione un almacén de Origen para la transferencia")
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdSubAlmacenDestino, "Seleccione un almacén de Deestino para la transferencia")
                    If .IdSubAlmacenDestino = .IdSubAlmacenOrigen Then Throw New Exception("Verifique los SubAlmacenes, no puede transferir al mismo SubAlmacen")
                Else
                    ValidarProveedor(oeOrden)
                End If
                If .lstOrdenMaterial.Count = 0 Then Throw New Exception("Debe agregar materiales para generar una Orden.")
                If .lstOrdenMaterial.Where(Function(item) item.ValorVenta = 0).Count > 0 Then Throw New Exception("Verifique cantidades o precios de los materiales.")
                If .IdTipoOrden <> "1CH000000003" Then
                    For Each obj As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                        If String.IsNullOrEmpty(obj.IdSubAlmacen.Trim) Then Throw New Exception("Seleccione un almacen determinado para cada detalle")
                    Next
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ValidarProveedor(ByVal oeOrden As EntidadesWCF.e_Orden) Implements Il_Orden.ValidarProveedor
        Try
            Dim oeProveedor As New e_Proveedor, olProveedor As New l_Proveedor
            oeProveedor.TipoOperacion = ""
            oeProveedor.Id = oeOrden.IdProveedor
            oeProveedor.Activo = True
            oeProveedor = olProveedor.Obtener(oeProveedor)
            If oeProveedor.Id = "" Then
                Throw New Exception("No existe el proveedor seleccionado")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function RectificarOrden(oeOrden As e_Orden, loDetalleDocumento As List(Of e_DetalleDocumento), IdMoneda As String, TipoCambio As Double) As Boolean Implements Il_Orden.RectificarOrden
        Try
            odOrden = New d_Orden
            oeOrden.lstOrdenMaterial = New List(Of e_OrdenMaterial)
            'rectificamos detalle orden
            Dim oeOrdenMaterial As New e_OrdenMaterial
            Dim olOrdenMaterial As New l_OrdenMaterial
            oeOrdenMaterial.TipoOperacion = "L"
            oeOrdenMaterial.Activo = True
            oeOrdenMaterial.IdOrden = oeOrden.Id
            oeOrden.lstOrdenMaterial = olOrdenMaterial.Listar(oeOrdenMaterial)
            For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                For Each detdoc As e_DetalleDocumento In loDetalleDocumento
                    If ordmat.IdMaterial = detdoc.IdMaterialServicio Then
                        ordmat.PrecioUnitario = detdoc.Precio
                        ordmat.ValorVenta = ordmat.PrecioUnitario * ordmat.CantidadMaterial
                    End If
                Next
            Next
            'rectificamos registro inventario
            Dim oeRegistroInventario As New e_RegistroInventario
            Dim olRegistroInventario As New l_RegistroInventario
            Dim loRegistroInventario As New List(Of e_RegistroInventario)
            oeRegistroInventario.TipoOperacion = "O"
            oeRegistroInventario.Id = oeOrden.Id
            loRegistroInventario = olRegistroInventario.Listar(oeRegistroInventario)
            If IdMoneda = "1CH02" Then
                For Each detdoc As e_DetalleDocumento In loDetalleDocumento
                    With detdoc
                        .PrecioUnitarioSinImp = .PrecioUnitarioSinImp * TipoCambio
                        .Precio = .Precio * TipoCambio
                    End With
                Next
            End If
            For Each reginv As e_RegistroInventario In loRegistroInventario
                For Each detdoc As e_DetalleDocumento In loDetalleDocumento
                    If reginv.IdMaterial = detdoc.IdMaterialServicio Then
                        reginv.TipoOperacion = "R"
                        reginv.ValorUnitario = detdoc.PrecioUnitarioSinImp
                        reginv.ValorUnitarioReal = detdoc.PrecioUnitarioSinImp
                        reginv.ValorTotal = reginv.ValorUnitario * reginv.Cantidad
                        olRegistroInventario.Rectificar(reginv)
                    End If
                Next
            Next
            'rectificamos orden
            oeOrden.TipoOperacion = "A"
            oeOrden.Total = oeOrden.lstOrdenMaterial.Sum(Function(item) item.ValorVenta)
            If odOrden.Guardar(oeOrden) Then
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub GenerarAsientoConsumo(oeOrdenSalida As e_Orden) Implements Il_Orden.GenerarAsientoConsumo
        Try
            If oeOrdenSalida.TipoOperacion = "" Then Exit Sub
            odOrden = New d_Orden
            Dim oeAsiento As e_Asiento
            Dim loAsiento As New List(Of e_Asiento)
            Dim olAsiento As New l_Asiento
            Dim oeAsientoMovimiento As e_AsientoMovimiento
            Dim loAsientoMovimiento As New List(Of e_AsientoMovimiento)
            Dim oeAsientoAnalisis As e_MovimientoAnalisis
            Dim oe As New e_Orden
            oe.Id = oeOrdenSalida.Id
            oe = odOrden.Obtener(oe)
            If oeOrdenSalida.IndAsiento Then
                For Each asimod As e_AsientoModelo In oeOrdenSalida.loAsientoModelo
                    oeAsiento = New e_Asiento
                    With oeAsiento
                        .PrefijoID = oeOrdenSalida.PrefijoID '@0001
                        .TipoOperacion = "I" : .IdPeriodo = oeOrdenSalida.IdPeriodo : .IdTipoAsiento = asimod.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = oeOrdenSalida.FechaOrden
                        .Glosa = asimod.Nombre & " " & oe.NroOrden & " " & LTrim(oe.Glosa)
                        .GlosaImprime = String.Empty : .IdMoneda = asimod.IdMoneda : .TipoCambio = oeOrdenSalida.TipoCambio
                        .TotalDebe = Math.Round(oeOrdenSalida.loCtaCtbleSFam.Sum(Function(item) item.TotalCuentas), 2)
                        .TotalHaber = Math.Round(oeOrdenSalida.loCtaCtbleSFam.Sum(Function(item) item.TotalCuentas), 2)
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeOrdenSalida.IdUsuarioEjecucion : oeAsiento.Activo = True
                        .IndOrigen = 19
                        .AsientoReferencia = New e_AsientoReferencia
                        .AsientoReferencia.PrefijoID = oeOrdenSalida.PrefijoID '@0001
                        .AsientoReferencia.TipoOperacion = "I"
                        .AsientoReferencia.IdReferencia = oeOrdenSalida.Id
                        .AsientoReferencia.TipoReferencia = 2
                    End With
                    For Each ctactblesfm As e_CtaCtbleSubFamiliaMat In oeOrdenSalida.loCtaCtbleSFam
                        For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle.OrderBy(Function(item) item.Fila).ToList
                            oeAsientoMovimiento = New e_AsientoMovimiento
                            With oeAsientoMovimiento
                                .PrefijoID = oeOrdenSalida.PrefijoID '@0001
                                .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                .IdUsuarioCrea = oeOrdenSalida.IdUsuarioEjecucion : .Activo = True : .Fila = asidet.Fila
                                If Left(ctactblesfm.NroCtaCtbleExistencias, 2) = asidet.Cuenta.Trim Then
                                    .IdCuentaContable = ctactblesfm.IdCtaCtbleExistencias
                                End If
                                If Left(ctactblesfm.NroCtaCtbleCompra, 2) = asidet.Cuenta.Trim Then
                                    .IdCuentaContable = ctactblesfm.IdCtaCtbleCompras
                                End If
                                If Left(ctactblesfm.NroCtaCtbleConsumo, 2) = asidet.Cuenta.Trim Then
                                    .IdCuentaContable = ctactblesfm.IdCtaCtbleConsumo
                                End If
                                If asidet.Partida = 1 Then
                                    .DebeMN = ctactblesfm.TotalCuentas
                                    .DebeME = ctactblesfm.TotalCuentas / oeOrdenSalida.TipoCambio
                                    oeAsientoAnalisis = New e_MovimientoAnalisis
                                    oeAsientoAnalisis.PrefijoID = oeOrdenSalida.PrefijoID '@0001
                                    oeAsientoAnalisis.TipoOperacion = ""
                                    oeAsientoAnalisis.IdMoneda = asimod.IdMoneda
                                    oeAsientoAnalisis.IdUsuarioCrea = oeOrdenSalida.IdUsuarioEjecucion
                                    oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                                    oeAsientoAnalisis.Monto = .DebeMN
                                    oeAsientoAnalisis.Saldo = .DebeMN
                                    oeAsientoAnalisis.IdVehiculo = IIf(oeOrdenSalida.IdOrdenCompra <> "", oeOrdenSalida.IdOrdenCompra, "1SI000000059")
                                    .MovimientoAnalisis.Add(oeAsientoAnalisis)
                                    If .DebeMN > 0 And .IdCuentaContable.Trim <> "" Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                Else
                                    .HaberMN = ctactblesfm.TotalCuentas
                                    .HaberME = ctactblesfm.TotalCuentas / oeOrdenSalida.TipoCambio
                                    If .HaberMN > 0 And .IdCuentaContable.Trim <> "" Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                End If
                            End With
                        Next
                    Next
                    oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                    If oeAsiento.AsientoMovimiento.Count > 0 Then loAsiento.Add(oeAsiento)
                Next
                olAsiento.GuardarLista(loAsiento)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ModificarCantidadDevolucionOT(oeOrden As e_Orden)
        odOrdTra = New d_OrdenTrabajo
        odOrdTraMat = New d_OrdenTrabajo_Material
        Dim oeOrdenTrabajoMat As New e_OrdenTrabajo_Material
        Dim oeOrdenTrabajo As New e_OrdenTrabajo
        For Each filaMat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
            oeOrdenTrabajoMat.TipoOperacion = "D"
            oeOrdenTrabajoMat.Activo = True
            '-------------------------------------
            oeOrdenTrabajo.Activo = True
            oeOrdenTrabajo.NroOT = oeOrden.Referencia
            oeOrdenTrabajo = odOrdTra.Obtener(oeOrdenTrabajo)
            oeOrdenTrabajoMat.IdOrdenTrabajo = oeOrdenTrabajo.Id 'oeOrden.Referencia
            '-------------------------------------
            oeOrdenTrabajoMat.IdMaterial = filaMat.IdMaterial
            oeOrdenTrabajoMat.Id = filaMat.IdReferencia
            oeOrdenTrabajoMat.CantidadMaterialDevuelto = filaMat.CantidadMaterial
            odOrdTraMat.Guardar(oeOrdenTrabajoMat)
        Next
    End Sub

    Private Sub ModificarCantidadDevolucionOA(oeOrden As e_Orden)
        odOrdAsig = New d_OrdenAsignacion
        odOrdAsigMat = New d_OrdenAsignacion_Material
        Dim oeOrdenAsignacionMat As New e_OrdenAsignacion_Material
        Dim oeOrdenAsignacion As New e_OrdenAsignacion
        For Each filaMat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
            oeOrdenAsignacionMat.TipoOperacion = "D"
            oeOrdenAsignacionMat.Activo = True
            '-------------------------------------
            oeOrdenAsignacion.Activo = True
            oeOrdenAsignacion.NroOA = oeOrden.Referencia
            oeOrdenAsignacion = odOrdAsig.Obtener(oeOrdenAsignacion)
            oeOrdenAsignacionMat.IdOrdenAsignacion = oeOrdenAsignacion.Id
            '-------------------------------------
            oeOrdenAsignacionMat.IdMaterial = filaMat.IdMaterial
            oeOrdenAsignacionMat.CantidadMaterialDevuelto = filaMat.CantidadMaterial
            odOrdAsigMat.Guardar(oeOrdenAsignacionMat)
        Next
        GenerarSalidaDevolucion(oeOrden, oeOrdenAsignacion.Id)
    End Sub

    Private Sub GenerarSalidaDevolucion(oeOrden As e_Orden, IdOrdenAsignacion As String)
        Try
            Dim olFunciones As New l_FuncionesGenerales
            Dim FechaActual As Date = olFunciones.l_ObtenerFechaServidor()
            Dim Igv As Double = olFunciones.CargaIGV(FechaActual)
            Dim oeOrdenSalida As New e_Orden
            Dim oeDetalleOrdenSalida As New e_OrdenMaterial
            Dim loDetalleOrdenSalida As New List(Of e_OrdenMaterial)
            Dim oeRegInv As New e_RegistroInventario
            For Each obj As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                oeDetalleOrdenSalida = New e_OrdenMaterial
                With oeDetalleOrdenSalida
                    .Activo = True
                    .IdMaterial = obj.IdMaterial
                    .Material = obj.Material
                    .CantidadMaterial = obj.CantidadMaterial
                    .PrecioUnitario = obj.PrecioUnitario
                    .IdSubAlmacen = BuscarSubAlmacen_Ingreso(IdOrdenAsignacion)
                    .IdTipoUnidadMedida = obj.IdTipoUnidadMedida
                    .IdUnidadMedida = obj.IdUnidadMedida
                    .UnidadMedida = obj.UnidadMedida
                    .ValorVenta = .PrecioUnitario * .CantidadMaterial
                End With
                loDetalleOrdenSalida.Add(oeDetalleOrdenSalida)
            Next
            With oeOrdenSalida
                .lstOrdenMaterial = New List(Of e_OrdenMaterial)
                .lstOrdenMaterial.AddRange(loDetalleOrdenSalida)
                .Activo = True
                .IdMoneda = "1CH01" ' Soles 
                .IdTipoOrden = "1CH000000002" 'ORDEN DE SALIDA
                .IdProveedor = oeOrden.IdProveedor
                .IdMovimientoInventario = "1CH000000030" 'SALIDA POR DEVOLUCION
                .FechaOrden = FechaActual
                .TipoOperacion = "D"
                .IdSubAlmacenDestino = ""
                .IdSubAlmacenOrigen = ""
                .TipoReferencia = "ORDEN INGRESO"
                .Referencia = oeOrden.NroOrden
                .UsuarioCreacion = oeOrden.IdUsuarioEjecucion
                .IdUsuarioEjecucion = oeOrden.IdUsuarioEjecucion
            End With
            Dim oeInventario As e_Inventario
            Dim oeRegistroInventario As e_RegistroInventario
            Dim loInventario As New List(Of e_Inventario)
            For Each oe As e_OrdenMaterial In oeOrdenSalida.lstOrdenMaterial
                oeInventario = New e_Inventario
                With oeInventario
                    .FechaCreacion = FechaActual
                    .IdMaterial = oe.IdMaterial
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .CantidadSalida = oe.CantidadMaterial
                    .ValorUnitario = Math.Round(oe.PrecioUnitario / (1 + Igv), 4)
                    .Usuario = oeOrdenSalida.UsuarioCreacion
                    .IndValidar = True
                End With
                oeRegistroInventario = New e_RegistroInventario
                With oeRegistroInventario
                    .TipoOperacion = "I"
                    .IdMaterial = oe.IdMaterial
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .IdMovimientoInventario = oeOrden.IdMovimientoInventario
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .Cantidad = oe.CantidadMaterial
                    .UsuarioCreacion = oeOrdenSalida.UsuarioCreacion
                End With
                oeInventario.oeRegistroInventario = New e_RegistroInventario
                oeInventario.oeRegistroInventario = oeRegistroInventario
                loInventario.Add(oeInventario)
            Next
            oeOrdenSalida.lstInventario = New List(Of e_Inventario)
            oeOrdenSalida.lstInventario = loInventario
            odOrden.Guardar(oeOrdenSalida)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function BuscarSubAlmacen_Ingreso(IdOrdenAsignacion As String) As String
        Try
            Dim oeSubAlmacenIngreso As New e_SubAlmacen
            Dim odSubAlmacen As New d_SubAlmacen
            oeSubAlmacenIngreso.TipoOperacion = "5"
            oeSubAlmacenIngreso.Activo = True
            oeSubAlmacenIngreso.IdOrdenAsignacion = IdOrdenAsignacion
            oeSubAlmacenIngreso = odSubAlmacen.Obtener(oeSubAlmacenIngreso)
            Return oeSubAlmacenIngreso.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
