' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ActivoFijo" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ActivoFijo.svc o l_ActivoFijo.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Transactions
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ActivoFijo
    Implements Il_ActivoFijo

    Private odActivoFijo As New d_ActivosFijo
    Private odActivoFijo_CuentaContable As New d_ActivoFijo_CuentaContable
    Private odMovimientoActivoFijo As New d_MovimientoActivoFijo
    Private odReadecuacionActivoFijo As New d_ReadecuacionActivoFijo
    Private odDepreciacionActivoFijo As New d_DepreciacionActivoFijo
    Private odReadecuacionAFDoc As New d_ReadecuacionAF_Documento
    Private oeAsiento As e_Asiento, odAsiento As New d_Asiento, olAsiento As l_Asiento
    Private oeAsientoMovimiento As e_AsientoMovimiento, odAsientoMovimiento As New d_AsientoMovimiento, olAsientoMovimiento As l_AsientoMovimiento
    Private oeMovimientoAnalisis As e_MovimientoAnalisis, odMovimientoAnalisis As New d_MovimientoAnalisis, olMovimientoAnalisis As l_MovimientoAnalisis
    Private olFuncionesGenerales As l_FuncionesGenerales

    Private Const TipoAsientoDiario = "1CH000020"
    Private Const IdMonedaSoles = "1CH01"
    Private Const IdVehiculoGenerico = "1SI000000059"
    Private Const IdGFCostoVenta = "1CH000087"
    Private Const IdIGMaqEquipoExplotacion = "1CH000165"

#Region "Activo Fijo"

    Public Function Obtener(oeActivoFijo As e_ActivoFijo, lbAFCuentaContable As Boolean, lbReadecuaciones As Boolean) As e_ActivoFijo Implements Il_ActivoFijo.Obtener
        Try
            Dim oeAF As e_ActivoFijo = odActivoFijo.Obtener(oeActivoFijo)
            If lbAFCuentaContable Then
                oeAF.ListAF_CuentaContable.AddRange(odActivoFijo_CuentaContable.Listar(New e_ActivoFijo_CuentaContable With {.IdActivoFijo = oeAF.Id}))
            End If
            If lbReadecuaciones Then
                oeAF.ListReadecuacionAF.AddRange(odReadecuacionActivoFijo.Listar(New e_ReadecuacionActivoFijo With {.IdActivoFijo = oeAF.Id}))
                For Each Readecuacion In oeAF.ListReadecuacionAF
                    Readecuacion.ListReadecuacionAFDoc.AddRange(odReadecuacionAFDoc.Listar(New e_ReadecuacionAF_Documento With {.IdReadecuacionActivoFijo = Readecuacion.Id}))
                Next
            End If
            Return oeAF
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeActivoFijo As e_ActivoFijo) As List(Of e_ActivoFijo) Implements Il_ActivoFijo.Listar
        Try
            Return odActivoFijo.Listar(oeActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDS(oeActivoFijo As e_ActivoFijo) As DataSet Implements Il_ActivoFijo.ListarDS
        Try
            Dim ds = odActivoFijo.ExecuteLST(oeActivoFijo)
            Return If(ds IsNot Nothing, ds, New DataSet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeActivoFijo As e_ActivoFijo) As Boolean Implements Il_ActivoFijo.Guardar
        Try
            Using transScope As New TransactionScope()
                Dim IdPeriodo As String = String.Empty : IdPeriodo = oeActivoFijo.IdPeriodo : oeActivoFijo.IdPeriodo = String.Empty
                'DESACTIVACIÓN
                'Armar Asiento de Desactivación
                If oeActivoFijo.IndBaja = 1 Then
                    'Obtener los datos de la configuracion de reclasificacion segun el tipo de AF
                    Dim oeTipoAFCtaCtble As New e_TipoActivoFijo_CtaCtble, odTipoAFCtaCtble As New d_TipoActivoFijo_CtaCtble
                    If oeActivoFijo.IndDocumento = 0 Then
                        oeTipoAFCtaCtble.Ejercicio = oeActivoFijo.FechaSituacion.Year
                    Else
                        oeTipoAFCtaCtble.Ejercicio = oeActivoFijo.FechaIngreso.Year
                    End If
                    oeTipoAFCtaCtble.IdTipoActivoFijo = oeActivoFijo.IdSubGrupoActivo
                    oeTipoAFCtaCtble = odTipoAFCtaCtble.Obtener(oeTipoAFCtaCtble)
                    If Not String.IsNullOrWhiteSpace(oeTipoAFCtaCtble.IdCtaCtbleCompraD) OrElse Not String.IsNullOrWhiteSpace(oeTipoAFCtaCtble.IdCtaCtbleDeprecH) OrElse Not String.IsNullOrWhiteSpace(oeTipoAFCtaCtble.IdCtaCtbleBajaD) Then
                        oeAsiento = New e_Asiento
                        With oeAsiento
                            .TipoOperacion = "I"
                            .IdPeriodo = IdPeriodo
                            .IdTipoAsiento = TipoAsientoDiario
                            .NroAsiento = String.Empty
                            .Fecha = Date.Now
                            .Glosa = "POR LA DESACTIVACIÓN DEL ACTIVO : " & oeActivoFijo.DescripcionResumida
                            .GlosaImprime = .Glosa
                            .IdMoneda = IdMonedaSoles
                            .TipoCambio = oeActivoFijo.TipoCambio
                            'Obtener Valor de Compra del Activo según IndicadorDocumento
                            Dim oeAFVCDep As New e_ActivoFijo
                            oeAFVCDep.TipoOperacion = "OVD"
                            oeAFVCDep.Id = oeActivoFijo.Id
                            oeAFVCDep.IdPeriodo = IdPeriodo
                            oeAFVCDep.IndBaja = oeActivoFijo.IndBaja
                            oeAFVCDep.FechaBaja = oeActivoFijo.FechaBaja
                            oeAFVCDep.ValorResidual = oeActivoFijo.ValorResidual
                            oeAFVCDep.IndDocumento = oeActivoFijo.IndDocumento
                            Select Case oeActivoFijo.IndDocumento
                                Case 0 'Situacion Contable a una Fecha
                                    oeAFVCDep.ValorCompra = oeActivoFijo.ValorLibro
                                    oeAFVCDep.VidaUtil = oeActivoFijo.VidaUtilRemanente
                                    oeAFVCDep.FechaActivacion = oeActivoFijo.FechaSituacion
                                Case 1, 2, 3 'Documento, Obligación financiera o sin documento
                                    oeAFVCDep.ValorCompra = oeActivoFijo.ValorCompra
                                    oeAFVCDep.VidaUtil = oeActivoFijo.VidaUtil
                                    oeAFVCDep.FechaActivacion = oeActivoFijo.FechaActivacion
                            End Select
                            oeAFVCDep = Obtener(oeAFVCDep, False, False)
                            If oeAFVCDep.ValorCompra <= 0 Then
                                Throw New Exception("Error valor compra 0. Activo Fijo " & oeActivoFijo.DescripcionResumida)
                            End If
                            .TotalDebe = Math.Round(oeAFVCDep.ValorCompra, 2)
                            .TotalHaber = Math.Round(oeAFVCDep.ValorCompra, 2)
                            .IdEstado = "CUADRADO"
                            .FechaCreacion = Date.Now
                            .IdUsuarioCrea = oeActivoFijo.UsuarioCreacion
                            .Activo = True
                            .IndOrigen = 40
                            'Debe 1 (Para el análisis se tomará el cuenta el valor logico 1 de TablaContableDet como IndVehículo)
                            'Cuenta 3
                            oeAsientoMovimiento = New e_AsientoMovimiento
                            With oeAsientoMovimiento
                                .TipoOperacion = "I"
                                .Glosa = oeAsiento.Glosa
                                .IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                .Activo = True
                                .Fila = "1" 'asidet.Fila
                                .IdCuentaContable = oeTipoAFCtaCtble.IdCtaCtbleDeprecH
                                .DebeMN = Math.Round(oeAFVCDep.DepreciacionAcumulada, 2)
                                .DebeME = Math.Round(oeAFVCDep.DepreciacionAcumulada / oeAsiento.TipoCambio, 4)
                                .FechaCreacion = Date.Now
                                'ANALISIS el IndTipoVehiculo es el ValorLogico1 de tabla contable detalle Tipo Activo Fijo
                                If oeTipoAFCtaCtble.IndTipoVehiculo Then
                                    oeMovimientoAnalisis = New e_MovimientoAnalisis
                                    oeMovimientoAnalisis.TipoOperacion = "I"
                                    oeMovimientoAnalisis.IdMoneda = oeAsiento.IdMoneda
                                    oeMovimientoAnalisis.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                    'Obtener el Vehiculo relacionado al centro de costo
                                    Dim oeCC As New e_CentroCosto, olCC As New l_CentroCosto
                                    oeCC.Id = oeActivoFijo.IdCentroCosto
                                    oeCC = olCC.Obtener(oeCC)
                                    If Not String.IsNullOrWhiteSpace(oeCC.IdVehiculo) Then
                                        oeMovimientoAnalisis.IdVehiculo = oeCC.IdVehiculo.Trim()
                                    Else
                                        Throw New Exception("El Centro de Costo " & oeCC.Nombre & Environment.NewLine & _
                                                            "No tiene un vehículo asociado")
                                    End If
                                    oeMovimientoAnalisis.Monto = .DebeMN
                                    .MovimientoAnalisis.Add(oeMovimientoAnalisis)
                                Else
                                    oeMovimientoAnalisis = New e_MovimientoAnalisis
                                    oeMovimientoAnalisis.TipoOperacion = "I"
                                    oeMovimientoAnalisis.IdMoneda = oeAsiento.IdMoneda
                                    oeMovimientoAnalisis.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                    oeMovimientoAnalisis.IdVehiculo = IdVehiculoGenerico
                                    oeMovimientoAnalisis.Monto = .DebeMN
                                    .MovimientoAnalisis.Add(oeMovimientoAnalisis)
                                End If
                                If .DebeMN > 0 Then oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                            End With
                            'Haber
                            'Cuenta 39
                            oeAsientoMovimiento = New e_AsientoMovimiento
                            With oeAsientoMovimiento
                                .TipoOperacion = "I"
                                .Glosa = oeAsiento.Glosa
                                .IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                .Activo = True
                                .Fila = "2" 'asidet.Fila
                                .IdCuentaContable = oeTipoAFCtaCtble.IdCtaCtbleCompraD
                                .HaberMN = Math.Round(oeAFVCDep.ValorCompra, 2)
                                .HaberME = Math.Round(oeAFVCDep.ValorCompra / oeAsiento.TipoCambio, 4)
                                .FechaCreacion = Date.Now
                                'ANALISIS 'El gasto función e item gasto se tomará fijo costo de venta y maq y equip de explotación
                                'Cuenta 655
                                If oeTipoAFCtaCtble.IndTipoVehiculo Then
                                    oeMovimientoAnalisis = New e_MovimientoAnalisis
                                    oeMovimientoAnalisis.TipoOperacion = "I"
                                    oeMovimientoAnalisis.IdMoneda = oeAsiento.IdMoneda
                                    oeMovimientoAnalisis.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                    oeMovimientoAnalisis.IdGastoFuncion = String.Empty
                                    oeMovimientoAnalisis.IdItemGasto = String.Empty
                                    'Obtener el Vehiculo relacionado al centro de costo
                                    Dim oeCC As New e_CentroCosto, olCC As New l_CentroCosto
                                    oeCC.Id = oeActivoFijo.IdCentroCosto
                                    oeCC = olCC.Obtener(oeCC)
                                    If Not String.IsNullOrWhiteSpace(oeCC.IdVehiculo) Then
                                        oeMovimientoAnalisis.IdVehiculo = oeCC.IdVehiculo.Trim()
                                    Else
                                        Throw New Exception("El Centro de Costo " & oeCC.Nombre & Environment.NewLine & _
                                                            "No tiene un vehículo asociado")
                                    End If
                                    oeMovimientoAnalisis.Monto = .HaberMN
                                    .MovimientoAnalisis.Add(oeMovimientoAnalisis)
                                Else
                                    oeMovimientoAnalisis = New e_MovimientoAnalisis
                                    oeMovimientoAnalisis.TipoOperacion = "I"
                                    oeMovimientoAnalisis.IdMoneda = oeAsiento.IdMoneda
                                    oeMovimientoAnalisis.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                    oeMovimientoAnalisis.IdGastoFuncion = String.Empty
                                    oeMovimientoAnalisis.IdItemGasto = String.Empty
                                    oeMovimientoAnalisis.IdVehiculo = IdVehiculoGenerico
                                    oeMovimientoAnalisis.Monto = .HaberMN
                                    .MovimientoAnalisis.Add(oeMovimientoAnalisis)
                                End If
                                If .HaberMN > 0 Then oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                            End With
                            If (Math.Round(oeAFVCDep.ValorCompra, 2) - Math.Round(oeAFVCDep.DepreciacionAcumulada, 2)) <> 0.0 Then
                                'Debe 2
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                With oeAsientoMovimiento
                                    .TipoOperacion = "I"
                                    .Glosa = oeAsiento.Glosa
                                    .IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                    .Activo = True
                                    .Fila = "3" 'asidet.Fila
                                    .IdCuentaContable = oeTipoAFCtaCtble.IdCtaCtbleBajaD
                                    .DebeMN = Math.Round(Math.Round(oeAFVCDep.ValorCompra, 2) - Math.Round(oeAFVCDep.DepreciacionAcumulada, 2), 2)
                                    .DebeME = Math.Round(.DebeMN / oeAsiento.TipoCambio, 4)
                                    .FechaCreacion = Date.Now
                                    'ANALISIS 
                                    If oeTipoAFCtaCtble.IndTipoVehiculo Then
                                        oeMovimientoAnalisis = New e_MovimientoAnalisis
                                        oeMovimientoAnalisis.TipoOperacion = "I"
                                        oeMovimientoAnalisis.IdMoneda = oeAsiento.IdMoneda
                                        oeMovimientoAnalisis.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                        oeMovimientoAnalisis.IdGastoFuncion = IdGFCostoVenta
                                        'oeMovimientoAnalisis.IdItemGasto = IdIGMaqEquipoExplotacion
                                        'Obtener el Vehiculo relacionado al centro de costo
                                        Dim oeCC As New e_CentroCosto, olCC As New l_CentroCosto
                                        oeCC.Id = oeActivoFijo.IdCentroCosto
                                        oeCC = olCC.Obtener(oeCC)
                                        If Not String.IsNullOrWhiteSpace(oeCC.IdVehiculo) Then
                                            oeMovimientoAnalisis.IdVehiculo = oeCC.IdVehiculo.Trim()
                                        Else
                                            Throw New Exception("El Centro de Costo " & oeCC.Nombre & Environment.NewLine & _
                                                                "No tiene un vehículo asociado")
                                        End If
                                        oeMovimientoAnalisis.Monto = .DebeMN
                                        .MovimientoAnalisis.Add(oeMovimientoAnalisis)
                                    Else
                                        oeMovimientoAnalisis = New e_MovimientoAnalisis
                                        oeMovimientoAnalisis.TipoOperacion = "I"
                                        oeMovimientoAnalisis.IdMoneda = oeAsiento.IdMoneda
                                        oeMovimientoAnalisis.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                        oeMovimientoAnalisis.IdGastoFuncion = IdGFCostoVenta
                                        'oeMovimientoAnalisis.IdItemGasto = IdIGMaqEquipoExplotacion
                                        oeMovimientoAnalisis.IdVehiculo = IdVehiculoGenerico
                                        oeMovimientoAnalisis.Monto = .DebeMN
                                        .MovimientoAnalisis.Add(oeMovimientoAnalisis)
                                    End If
                                    If .DebeMN > 0 Then oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                                End With
                            End If
                        End With
                        odAsiento.Guardar(oeAsiento, Nothing)
                        oeActivoFijo.IdAsientoBaja = oeAsiento.Id
                    Else
                        Throw New Exception("El activo fijo " & oeActivoFijo.DescripcionResumida & Environment.NewLine & _
                                            "No tiene configuración contable para el periodo " & oeActivoFijo.FechaBaja.Year.ToString())
                    End If
                End If
                'RECLASIFICACIÓN
                If oeActivoFijo.IndReclasificando Then
                    'Obtener Datos del AF reclasificado
                    Dim oeAFReclasificado As New e_ActivoFijo
                    oeAFReclasificado.Id = oeActivoFijo.IdAFReclasificado
                    oeAFReclasificado = Obtener(oeAFReclasificado, False, False)
                    If Not String.IsNullOrWhiteSpace(oeAFReclasificado.Id) Then
                        'Obtener los datos de la configuracion de reclasificacion segun el tipo de AF
                        Dim oeTipoAFCtaCtble As New e_TipoActivoFijo_CtaCtble, odTipoAFCtaCtble As New d_TipoActivoFijo_CtaCtble
                        oeTipoAFCtaCtble.Ejercicio = oeActivoFijo.FechaIngreso.Year
                        oeTipoAFCtaCtble.IdTipoActivoFijo = oeAFReclasificado.IdSubGrupoActivo
                        oeTipoAFCtaCtble = odTipoAFCtaCtble.Obtener(oeTipoAFCtaCtble)
                        If Not String.IsNullOrWhiteSpace(oeTipoAFCtaCtble.IdCtaCtbleRevalorizacionD) OrElse Not String.IsNullOrWhiteSpace(oeTipoAFCtaCtble.IdCtaCtbleRevalorizacionH) Then
                            oeAsiento = New e_Asiento
                            With oeAsiento
                                .TipoOperacion = "I"
                                .IdPeriodo = IdPeriodo
                                .IdTipoAsiento = TipoAsientoDiario
                                .NroAsiento = String.Empty
                                .Fecha = Date.Now
                                .Glosa = "POR LA RECLASIFICACIÓN DEL ACTIVO FIJO : " & oeAFReclasificado.DescripcionResumida
                                .GlosaImprime = .Glosa
                                .IdMoneda = IdMonedaSoles
                                .TipoCambio = oeActivoFijo.TipoCambio
                                .TotalDebe = Math.Round(oeActivoFijo.ValorCompra, 2)
                                .TotalHaber = Math.Round(oeActivoFijo.ValorCompra, 2)
                                .IdEstado = "CUADRADO"
                                .FechaCreacion = Date.Now
                                .IdUsuarioCrea = oeActivoFijo.UsuarioCreacion
                                .Activo = True
                                .IndOrigen = 40
                                'Debe
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                With oeAsientoMovimiento
                                    .TipoOperacion = "I"
                                    .Glosa = oeAsiento.Glosa
                                    .IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                    .Activo = True
                                    .Fila = "1" 'asidet.Fila
                                    .IdCuentaContable = oeTipoAFCtaCtble.IdCtaCtbleRevalorizacionD
                                    .DebeMN = Math.Round(oeAsiento.TotalDebe, 2)
                                    .DebeME = Math.Round(oeAsiento.TotalDebe / oeAsiento.TipoCambio, 4)
                                    .FechaCreacion = Date.Now
                                    If .DebeMN > 0 Then oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                                End With
                                'Haber
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                With oeAsientoMovimiento
                                    .TipoOperacion = "I"
                                    .Glosa = oeAsiento.Glosa
                                    .IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                    .Activo = True
                                    .Fila = "2"
                                    .IdCuentaContable = oeTipoAFCtaCtble.IdCtaCtbleRevalorizacionH
                                    .HaberMN = Math.Round(oeAsiento.TotalHaber, 2)
                                    .HaberME = Math.Round(oeAsiento.TotalHaber / oeAsiento.TipoCambio, 4)
                                    .FechaCreacion = Date.Now
                                    If .HaberMN > 0 Then oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                                End With
                            End With
                            odAsiento.Guardar(oeAsiento, Nothing)
                            oeActivoFijo.IdAsientoReclasificacion = oeAsiento.Id
                        Else
                            Throw New Exception("El activo fijo " & oeAFReclasificado.DescripcionResumida & Environment.NewLine & _
                                                "No tiene configuración contable para el periodo " & oeActivoFijo.FechaIngreso.Year.ToString())
                        End If
                    Else
                        Throw New Exception("Es posible que se haya eliminado el activo fijo reclasificado " & Environment.NewLine & _
                                            "Id:" & oeAFReclasificado.Id)
                    End If
                End If
                'Guardamos Activo Fijo y si IndReclasificando = True Relacion AF Reclasificado
                odActivoFijo.Guardar(oeActivoFijo)
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeActivoFijo As e_ActivoFijo) As Boolean Implements Il_ActivoFijo.Eliminar
        Try
            Return odActivoFijo.Eliminar(oeActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Activo Fijo -- CuentaContable"

    Public Function ObtenerAF_CuentaContable(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As e_ActivoFijo_CuentaContable Implements Il_ActivoFijo.ObtenerAF_CuentaContable
        Try
            Return odActivoFijo_CuentaContable.Obtener(oeActivoFijo_CuentaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarAF_CuentaContable(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As List(Of e_ActivoFijo_CuentaContable) Implements Il_ActivoFijo.ListarAF_CuentaContable
        Try
            Return odActivoFijo_CuentaContable.Listar(oeActivoFijo_CuentaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarAF_CuentaContable(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As Boolean Implements Il_ActivoFijo.GuardarAF_CuentaContable
        Try
            Return odActivoFijo_CuentaContable.Guardar(oeActivoFijo_CuentaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarAF_CuentaContable(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As Boolean Implements Il_ActivoFijo.EliminarAF_CuentaContable
        Try
            Return odActivoFijo_CuentaContable.Eliminar(oeActivoFijo_CuentaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Activo Fijo -- Readecuaciones"

    Public Function ObtenerReadecuacionAF(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As e_ReadecuacionActivoFijo Implements Il_ActivoFijo.ObtenerReadecuacionAF
        Try
            Return odReadecuacionActivoFijo.Obtener(oeReadecuacionActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarReadecuacionAF(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As List(Of e_ReadecuacionActivoFijo) Implements Il_ActivoFijo.ListarReadecuacionAF
        Try
            Return odReadecuacionActivoFijo.Listar(oeReadecuacionActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarReadecuacionAF(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As Boolean Implements Il_ActivoFijo.GuardarReadecuacionAF
        Try
            Return odReadecuacionActivoFijo.Guardar(oeReadecuacionActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarReadecuacionAF(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As Boolean Implements Il_ActivoFijo.EliminarReadecuacionAF
        Try
            Return odReadecuacionActivoFijo.Eliminar(oeReadecuacionActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Activo Fijo -- Depreciacion"

    Public Function ObtenerDepreciacionAF(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As e_DepreciacionActivoFijo Implements Il_ActivoFijo.ObtenerDepreciacionAF
        Try
            Return odDepreciacionActivoFijo.Obtener(oeDepreciacionActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDepreciacionAF(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As List(Of e_DepreciacionActivoFijo) Implements Il_ActivoFijo.ListarDepreciacionAF
        Try
            Return odDepreciacionActivoFijo.Listar(oeDepreciacionActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDepreciacionAF(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As Boolean Implements Il_ActivoFijo.GuardarDepreciacionAF
        Try
            Return odDepreciacionActivoFijo.Guardar(oeDepreciacionActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarDepreciacionAF(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As Boolean Implements Il_ActivoFijo.EliminarDepreciacionAF
        Try
            Return odDepreciacionActivoFijo.Eliminar(oeDepreciacionActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDepreciacionPeriodo(lstDepreciacion As List(Of e_DepreciacionActivoFijo), ByVal PrefijoId As String) As Boolean Implements Il_ActivoFijo.GuardarDepreciacionPeriodo
        Try
            oeAsiento = New e_Asiento
            Dim lstAsiento As New List(Of e_Asiento)
            oeAsientoMovimiento = New e_AsientoMovimiento
            Using TransScope As New TransactionScope()
                'Agrupar las depreciaciones por IdTipoActivoFijo y por Periodo
                Dim lstDeprecAgrupada = From x In lstDepreciacion
                                        Group x By x.IdTipoActivoFijo, x.TipoActivoFijo, x.IdPeriodo, x.TipoCambio, x.UsuarioCreacion, x.IdCuentaOrigen, x.IdCuentaDestino, x.IndTipoVehiculo
                                        Into TotalValor = Sum(x.Valor)
                                        Select IdTipoActivoFijo, TipoActivoFijo, IdPeriodo, TotalValor, TipoCambio, UsuarioCreacion, IdCuentaOrigen, IdCuentaDestino, IndTipoVehiculo

                For Each TAF In lstDeprecAgrupada.ToList()
                    oeAsiento = New e_Asiento
                    With oeAsiento
                        'Para luego relacionar idasiento con idtipoactivofijo
                        .IdentificaAsiento = TAF.IdTipoActivoFijo
                        .TipoOperacion = "I"
                        .IdPeriodo = TAF.IdPeriodo
                        .IdTipoAsiento = TipoAsientoDiario
                        .NroAsiento = String.Empty
                        .Fecha = Date.Now
                        .Glosa = "POR LA DEPRECIACION DEL TIPO DE ACTIVOS FIJOS : " & TAF.TipoActivoFijo
                        .GlosaImprime = String.Empty
                        .IdMoneda = IdMonedaSoles
                        .TipoCambio = TAF.TipoCambio
                        .TotalDebe = Math.Round(TAF.TotalValor, 2)
                        .TotalHaber = Math.Round(TAF.TotalValor, 2)
                        .IdEstado = "1CH00005"
                        .FechaCreacion = Date.Now
                        .IdUsuarioCrea = TAF.UsuarioCreacion
                        .Activo = True
                        .IndOrigen = 40
                        Dim lstAsientoMovimiento As New List(Of e_AsientoMovimiento)
                        'Debe
                        oeAsientoMovimiento = New e_AsientoMovimiento
                        With oeAsientoMovimiento
                            .TipoOperacion = "I"
                            .Glosa = oeAsiento.Glosa
                            .IdUsuarioCrea = TAF.UsuarioCreacion
                            .Activo = True
                            .Fila = "1" 'asidet.Fila
                            .IdCuentaContable = TAF.IdCuentaOrigen
                            .DebeMN = Math.Round(TAF.TotalValor, 2)
                            .DebeME = Math.Round(TAF.TotalValor / TAF.TipoCambio, 2)
                            .FechaCreacion = Date.Now
                            'Análisis: Gasto Función esta por Tipo de Activo
                            If TAF.IndTipoVehiculo Then
                                'Obtener todos los centros de costos para el analisis
                                Dim oeCC As New e_CentroCosto, lstCC As New List(Of e_CentroCosto), olCC As New l_CentroCosto
                                lstCC = olCC.Listar(oeCC)
                                For Each Dep In lstDepreciacion.Where(Function(x) x.IdTipoActivoFijo = TAF.IdTipoActivoFijo).ToList()
                                    oeMovimientoAnalisis = New e_MovimientoAnalisis
                                    'Inicializar Variables
                                    oeMovimientoAnalisis.TipoOperacion = String.Empty
                                    oeMovimientoAnalisis.IdItemGasto = String.Empty
                                    oeMovimientoAnalisis.IdTrabajador = String.Empty
                                    oeMovimientoAnalisis.IdRuta = String.Empty
                                    oeMovimientoAnalisis.IdBanco = String.Empty
                                    oeMovimientoAnalisis.IdAnalisis1 = String.Empty
                                    oeMovimientoAnalisis.IdAnalisis2 = String.Empty
                                    oeMovimientoAnalisis.Activo = True
                                    oeMovimientoAnalisis.Saldo = True
                                    oeMovimientoAnalisis._IdMovimientoAnalisis = String.Empty
                                    oeMovimientoAnalisis.IdOrigenProrrateo = String.Empty
                                    'Asignar Valores
                                    oeMovimientoAnalisis.IdMoneda = oeAsiento.IdMoneda
                                    oeMovimientoAnalisis.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                    oeMovimientoAnalisis.Monto = Math.Round(Dep.Valor, 2)
                                    oeMovimientoAnalisis.IdGastoFuncion = Dep.IdGastoFuncion
                                    If lstCC.Where(Function(x) x.Id = Dep.IdCentroCosto).Count > 0 Then
                                        oeMovimientoAnalisis.IdVehiculo = lstCC.Where(Function(x) x.Id = Dep.IdCentroCosto)(0).IdVehiculo
                                        oeMovimientoAnalisis.IdCentroCosto = lstCC.Where(Function(x) x.Id = Dep.IdCentroCosto)(0).Id
                                    End If
                                    .MovimientoAnalisis.Add(oeMovimientoAnalisis)
                                Next
                            Else
                                Dim lstAnalisis As New List(Of e_MovimientoAnalisis)
                                'Verificar si de ese tipo de AF tienen varios centros de costos diferentes
                                For Each Dep In lstDepreciacion.Where(Function(x) x.IdTipoActivoFijo = TAF.IdTipoActivoFijo)
                                    oeMovimientoAnalisis = New e_MovimientoAnalisis
                                    'Asignar Valores
                                    oeMovimientoAnalisis.IdMoneda = oeAsiento.IdMoneda
                                    oeMovimientoAnalisis.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                    oeMovimientoAnalisis.IdGastoFuncion = Dep.IdGastoFuncion
                                    oeMovimientoAnalisis.IdCentroCosto = Dep.IdCentroCosto
                                    oeMovimientoAnalisis.IdVehiculo = IdVehiculoGenerico
                                    oeMovimientoAnalisis.Monto = Math.Round(Dep.Valor, 2)
                                    lstAnalisis.Add(oeMovimientoAnalisis)
                                    '.MovimientoAnalisis.Add(oeMovimientoAnalisis)
                                Next
                                .MovimientoAnalisis.AddRange((From x In lstAnalisis
                                                              Group x By x.IdCentroCosto, x.IdMoneda, x.IdGastoFuncion, x.IdVehiculo
                                                         Into Monto = Sum(x.Monto)
                                                              Select New e_MovimientoAnalisis With {.IdCentroCosto = IdCentroCosto,
                                                                                                .IdMoneda = IdMoneda,
                                                                                                .IdGastoFuncion = IdGastoFuncion,
                                                                                                .IdVehiculo = IdVehiculo,
                                                                                                .Monto = Monto,
                                                                                                .TipoOperacion = String.Empty,
                                                                                                .IdItemGasto = String.Empty,
                                                                                                .IdTrabajador = String.Empty,
                                                                                                .IdRuta = String.Empty,
                                                                                                .IdBanco = String.Empty,
                                                                                                .IdAnalisis1 = String.Empty,
                                                                                                .IdAnalisis2 = String.Empty,
                                                                                                .Activo = True,
                                                                                                .Saldo = 0.0,
                                                                                                ._IdMovimientoAnalisis = String.Empty,
                                                                                                .IdOrigenProrrateo = String.Empty
                                                                                               }).ToList())
                            End If
                            If .DebeMN > 0 Then lstAsientoMovimiento.Add(oeAsientoMovimiento)
                        End With
                        'Haber
                        oeAsientoMovimiento = New e_AsientoMovimiento
                        With oeAsientoMovimiento
                            .TipoOperacion = "I"
                            .Glosa = oeAsiento.Glosa
                            .IdUsuarioCrea = TAF.UsuarioCreacion
                            .Activo = True
                            .Fila = "2"
                            .IdCuentaContable = TAF.IdCuentaDestino
                            .HaberMN = Math.Round(TAF.TotalValor, 2)
                            .HaberME = Math.Round(TAF.TotalValor / TAF.TipoCambio, 2)
                            .FechaCreacion = Date.Now
                            'Análisis : vehiculo y monto
                            If TAF.IndTipoVehiculo Then
                                'Obtener todos los centros de costos para el analisis
                                Dim oeCC As New e_CentroCosto, lstCC As New List(Of e_CentroCosto), olCC As New l_CentroCosto
                                lstCC = olCC.Listar(oeCC)
                                For Each Dep In lstDepreciacion.Where(Function(x) x.IdTipoActivoFijo = TAF.IdTipoActivoFijo).ToList()
                                    oeMovimientoAnalisis = New e_MovimientoAnalisis
                                    'Inicializar Variables
                                    oeMovimientoAnalisis.TipoOperacion = String.Empty
                                    oeMovimientoAnalisis.IdItemGasto = String.Empty
                                    oeMovimientoAnalisis.IdTrabajador = String.Empty
                                    oeMovimientoAnalisis.IdRuta = String.Empty
                                    oeMovimientoAnalisis.IdBanco = String.Empty
                                    oeMovimientoAnalisis.IdAnalisis1 = String.Empty
                                    oeMovimientoAnalisis.IdAnalisis2 = String.Empty
                                    oeMovimientoAnalisis.Activo = True
                                    oeMovimientoAnalisis.Saldo = True
                                    oeMovimientoAnalisis._IdMovimientoAnalisis = String.Empty
                                    oeMovimientoAnalisis.IdOrigenProrrateo = String.Empty
                                    oeMovimientoAnalisis.IdGastoFuncion = String.Empty
                                    oeMovimientoAnalisis.IdCentroCosto = String.Empty
                                    oeMovimientoAnalisis.IdMoneda = oeAsiento.IdMoneda
                                    oeMovimientoAnalisis.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                    oeMovimientoAnalisis.Monto = Math.Round(Dep.Valor, 2)
                                    If lstCC.Where(Function(x) x.Id = Dep.IdCentroCosto).Count > 0 Then
                                        oeMovimientoAnalisis.IdVehiculo = lstCC.Where(Function(x) x.Id = Dep.IdCentroCosto)(0).IdVehiculo
                                    End If
                                    .MovimientoAnalisis.Add(oeMovimientoAnalisis)
                                Next
                            Else
                                oeMovimientoAnalisis = New e_MovimientoAnalisis
                                oeMovimientoAnalisis.TipoOperacion = String.Empty
                                oeMovimientoAnalisis.IdItemGasto = String.Empty
                                oeMovimientoAnalisis.IdTrabajador = String.Empty
                                oeMovimientoAnalisis.IdRuta = String.Empty
                                oeMovimientoAnalisis.IdBanco = String.Empty
                                oeMovimientoAnalisis.IdAnalisis1 = String.Empty
                                oeMovimientoAnalisis.IdAnalisis2 = String.Empty
                                oeMovimientoAnalisis.Activo = True
                                oeMovimientoAnalisis.Saldo = True
                                oeMovimientoAnalisis._IdMovimientoAnalisis = String.Empty
                                oeMovimientoAnalisis.IdOrigenProrrateo = String.Empty
                                oeMovimientoAnalisis.IdGastoFuncion = String.Empty
                                oeMovimientoAnalisis.IdCentroCosto = String.Empty
                                oeMovimientoAnalisis.IdMoneda = oeAsiento.IdMoneda
                                oeMovimientoAnalisis.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                                oeMovimientoAnalisis.IdVehiculo = IdVehiculoGenerico
                                oeMovimientoAnalisis.Monto = .HaberMN
                                .MovimientoAnalisis.Add(oeMovimientoAnalisis)
                            End If
                            If .HaberMN > 0 Then lstAsientoMovimiento.Add(oeAsientoMovimiento)
                        End With
                        .AsientoMovimiento.AddRange(lstAsientoMovimiento)
                    End With
                    lstAsiento.Add(oeAsiento)
                Next
                'Armar DataTable para guardar masivo
                Dim lstIdAsientoIdTipoActivo As New List(Of e_DepreciacionActivoFijo)
                Dim oeDeprecionAF As e_DepreciacionActivoFijo 'Para la relacion de depreciacion con asiento
                olAsiento = New l_Asiento : olAsientoMovimiento = New l_AsientoMovimiento : olFuncionesGenerales = New l_FuncionesGenerales : olMovimientoAnalisis = New l_MovimientoAnalisis
                Dim dt_ASI As Data.DataTable = olAsiento.CrearDT()
                Dim dt_ASIMOV As Data.DataTable = olAsientoMovimiento.CrearDT()
                Dim dt_ANALISIS As Data.DataTable = olMovimientoAnalisis.CrearDT()
                'Ultimos Id Asiento
                Dim IdAsiento As String = odAsiento.UltimoIdInserta(PrefijoId)
                Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
                Dim lsNumeroIdAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))
                'Ultimo Id AsientoMovimiento
                Dim IdAsientoMovimiento As String = odAsientoMovimiento.UltimoIdInsertar(PrefijoId)
                Dim lsPrefijoAsientoMovimiento As String = Left(IdAsientoMovimiento, 3)
                Dim lsNumeroIdAsientoMovimiento As Integer = CInt(Right(IdAsientoMovimiento, Len(IdAsientoMovimiento) - 3))
                'Ultimo Nro Asiento Diario
                Dim NroAsientoDiario As String = odAsiento.UltimoNroAsiento(TipoAsientoDiario, If(lstDeprecAgrupada.Count > 0, lstDeprecAgrupada(0).IdPeriodo, String.Empty), "1", PrefijoId)
                Dim lsPrefijoNroAsientoDiario As String = Left(NroAsientoDiario, 2)
                Dim lsNumeroNroAsientoDiario As Integer = CInt(Right(NroAsientoDiario, Len(NroAsientoDiario) - 2))
                'Ultimo Id Movimiento Análisis
                Dim IdMovAnalisis As String = odMovimientoAnalisis.UltimoIdInserta(PrefijoId)
                Dim lsPrefijoMovAnalisis As String = Left(IdMovAnalisis, 3)
                Dim lsNumeroIdMovAnalisis As Integer = CInt(Right(IdMovAnalisis, Len(IdMovAnalisis) - 3))
                For Each Asiento As e_Asiento In lstAsiento
                    oeDeprecionAF = New e_DepreciacionActivoFijo
                    With Asiento
                        Dim rowAsiento As Data.DataRow
                        Dim rowAsientoMovimiento As Data.DataRow
                        Dim rowAnalisis As Data.DataRow
                        rowAsiento = dt_ASI.NewRow
                        rowAsiento("Id") = lsPrefijoAsiento + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsiento.ToString, 12)
                        oeDeprecionAF.IdAsiento = rowAsiento("Id")
                        oeDeprecionAF.IdTipoActivoFijo = .IdentificaAsiento
                        rowAsiento("IdPeriodo") = .IdPeriodo
                        rowAsiento("IdTipoAsiento") = TipoAsientoDiario
                        rowAsiento("NroAsiento") = lsPrefijoNroAsientoDiario + olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsientoDiario, 7)
                        rowAsiento("Fecha") = .FechaCreacion
                        rowAsiento("Glosa") = .Glosa
                        rowAsiento("GlosaImprime") = .GlosaImprime
                        rowAsiento("IdMoneda") = .IdMoneda
                        rowAsiento("TipoCambio") = .TipoCambio
                        rowAsiento("TotalDebe") = .TotalDebe
                        rowAsiento("TotalHaber") = .TotalHaber
                        rowAsiento("IdUsuarioBloquea") = ""
                        rowAsiento("UsuarioCreacion") = .IdUsuarioCrea
                        rowAsiento("IdEstado") = .IdEstado
                        rowAsiento("IdAsientoExtorno") = ""
                        rowAsiento("FechaCreacion") = .FechaCreacion
                        rowAsiento("Activo") = True
                        rowAsiento("NroAsientoImprime") = DBNull.Value
                        rowAsiento("IdentificaAsiento") = DBNull.Value
                        rowAsiento("IndRevision") = DBNull.Value
                        rowAsiento("FechaRevision") = DBNull.Value
                        rowAsiento("UsuarioRevision") = DBNull.Value
                        rowAsiento("IndOrigen") = .IndOrigen
                        rowAsiento("UsuarioModificacion") = ""
                        rowAsiento("FechaModificacion") = Date.Parse("01/01/1901")
                        dt_ASI.Rows.Add(rowAsiento)
                        For Each AsientoMov In .AsientoMovimiento
                            rowAsientoMovimiento = dt_ASIMOV.NewRow()
                            rowAsientoMovimiento("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString(), 13)
                            rowAsientoMovimiento("IdAsiento") = rowAsiento("Id")
                            rowAsientoMovimiento("Glosa") = AsientoMov.Glosa
                            rowAsientoMovimiento("IdUsuarioCrea") = AsientoMov.IdUsuarioCrea
                            rowAsientoMovimiento("Activo") = True
                            rowAsientoMovimiento("IdCuentaContable") = AsientoMov.IdCuentaContable
                            rowAsientoMovimiento("DebeMN") = AsientoMov.DebeMN
                            rowAsientoMovimiento("DebeME") = AsientoMov.DebeME
                            rowAsientoMovimiento("HaberMN") = AsientoMov.HaberMN
                            rowAsientoMovimiento("HaberME") = AsientoMov.HaberME
                            rowAsientoMovimiento("NroLinea") = 1
                            rowAsientoMovimiento("FechaCreacion") = AsientoMov.FechaCreacion
                            dt_ASIMOV.Rows.Add(rowAsientoMovimiento)
                            For Each Analisis In AsientoMov.MovimientoAnalisis
                                rowAnalisis = dt_ANALISIS.NewRow()
                                rowAnalisis("Id") = lsPrefijoMovAnalisis + olFuncionesGenerales.CompletaConCeros(lsNumeroIdMovAnalisis.ToString(), 13)
                                rowAnalisis("IdAsientoMovimiento") = rowAsientoMovimiento("Id")
                                rowAnalisis("IdCentroCosto") = Analisis.IdCentroCosto
                                rowAnalisis("IdItemGasto") = Analisis.IdItemGasto
                                rowAnalisis("IdTrabajador") = Analisis.IdTrabajador
                                rowAnalisis("IdVehiculo") = Analisis.IdVehiculo
                                rowAnalisis("IdRuta") = Analisis.IdRuta
                                rowAnalisis("IdBanco") = Analisis.IdBanco
                                rowAnalisis("IdAnalisis1") = Analisis.IdAnalisis1
                                rowAnalisis("IdAnalisis2") = Analisis.IdAnalisis2
                                rowAnalisis("Activo") = Analisis.Activo
                                rowAnalisis("Monto") = Analisis.Monto
                                rowAnalisis("Saldo") = Analisis.Saldo
                                rowAnalisis("IdMovimientoAnalisis") = Analisis._IdMovimientoAnalisis
                                rowAnalisis("IdGastoFuncion") = Analisis.IdGastoFuncion
                                rowAnalisis("IdOrigenProrrateo") = Analisis.IdOrigenProrrateo
                                dt_ANALISIS.Rows.Add(rowAnalisis)
                                lsNumeroIdMovAnalisis += 1
                            Next
                            lsNumeroIdAsientoMovimiento += 1
                        Next
                        lsNumeroIdAsiento += 1
                        lsNumeroNroAsientoDiario += 1
                    End With
                    lstIdAsientoIdTipoActivo.Add(oeDeprecionAF)
                Next
                'DataTable para Depreciacón
                'Ultimos Id Asiento
                Dim dt_DEP As Data.DataTable = CrearDTDepreciacion()
                Dim IdDepreciacion As String = odDepreciacionActivoFijo.UltimoIdInserta(PrefijoId)
                Dim lsPrefijoDepreciacion As String = Left(IdDepreciacion, 3)
                Dim lsNumeroIdDepreciacion As Integer = CInt(Right(IdDepreciacion, Len(IdDepreciacion) - 3))
                For Each Depreciacion As e_DepreciacionActivoFijo In lstDepreciacion
                    With Depreciacion
                        Dim rowDepreciacion As Data.DataRow
                        rowDepreciacion = dt_DEP.NewRow
                        rowDepreciacion("Id") = lsPrefijoDepreciacion + olFuncionesGenerales.CompletaConCeros(lsNumeroIdDepreciacion.ToString(), 12)
                        rowDepreciacion("IdActivoFijo") = .IdActivoFijo
                        rowDepreciacion("IdPeriodo") = .IdPeriodo
                        rowDepreciacion("IdAFCuentaContable") = .IdAFCuentaContable
                        rowDepreciacion("IdCuentaOrigen") = .IdCuentaOrigen
                        rowDepreciacion("IdCuentaDestino") = .IdCuentaDestino
                        rowDepreciacion("Valor") = .Valor
                        rowDepreciacion("Importe") = .Importe
                        rowDepreciacion("Observacion") = .Observacion
                        rowDepreciacion("Actual") = .Actual
                        rowDepreciacion("FechaCreacion") = Date.Now
                        rowDepreciacion("UsuarioCreacion") = .UsuarioCreacion
                        rowDepreciacion("Activo") = .Activo
                        If lstIdAsientoIdTipoActivo.Where(Function(x) x.IdTipoActivoFijo = Depreciacion.IdTipoActivoFijo).Count > 0 Then
                            rowDepreciacion("IdAsiento") = lstIdAsientoIdTipoActivo.Where(Function(x) x.IdTipoActivoFijo = Depreciacion.IdTipoActivoFijo)(0).IdAsiento
                        End If
                        dt_DEP.Rows.Add(rowDepreciacion)
                    End With
                    lsNumeroIdDepreciacion += 1
                Next
                'XML para Actualizar la depreciacion acumulada
                Dim XML As New StringBuilder
                XML.AppendLine("<DETALLES>")
                For Each Deprec As e_DepreciacionActivoFijo In lstDepreciacion
                    XML.AppendLine("<DETALLE><IdAFCuentaContable>" & Deprec.IdAFCuentaContable & "</IdAFCuentaContable>")
                    XML.AppendLine("<Valor>" & Deprec.Valor & "</Valor></DETALLE>")
                Next
                XML.AppendLine("</DETALLES>")
                'Guardar Masivo
                odDepreciacionActivoFijo.GuardarMasivo(dt_DEP, dt_ASI, dt_ASIMOV, dt_ANALISIS, XML.ToString())
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CrearDTDepreciacion() As DataTable Implements Il_ActivoFijo.CrearDTDepreciacion
        Try
            Dim Depreciacion As New Data.DataTable
            With Depreciacion
                .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("IdActivoFijo", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("IdPeriodo", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("IdAFCuentaContable", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("IdCuentaOrigen", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("IdCuentaDestino", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("Valor", Type.GetType("System.Decimal")))
                .Columns.Add(New Data.DataColumn("Importe", Type.GetType("System.Decimal")))
                .Columns.Add(New Data.DataColumn("Observacion", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("Actual", Type.GetType("System.Int16")))
                .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
                .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
                .Columns.Add(New Data.DataColumn("IdAsiento", Type.GetType("System.String")))
            End With
            Return Depreciacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ExtornarAsientoDepreciacion(oeAsiento As e_Asiento) As Boolean Implements Il_ActivoFijo.ExtornarAsientoDepreciacion
        Try
            Using transScope As New TransactionScope()
                'Eliminamos la depreciacion 
                Dim oeDepreciacion As New e_DepreciacionActivoFijo
                oeDepreciacion.TipoOperacion = "S"
                oeDepreciacion.IdAsiento = oeAsiento.Id
                odDepreciacionActivoFijo.Guardar(oeDepreciacion)
                'Guardamos asiento para que el procedimiento lo extorne
                odAsiento.ExtornarAsiento(oeAsiento)
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Activo Fijo -- Movimientos"

    Public Function ObtenerMovimientoAF(oeMovimientoActivoFijo As e_MovimientoActivoFijo) As e_MovimientoActivoFijo Implements Il_ActivoFijo.ObtenerMovimientoAF
        Try
            Return odMovimientoActivoFijo.Obtener(oeMovimientoActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarMovimientoAF(oeMovimientoActivoFijo As e_MovimientoActivoFijo) As List(Of e_MovimientoActivoFijo) Implements Il_ActivoFijo.ListarMovimientoAF
        Try
            Return odMovimientoActivoFijo.Listar(oeMovimientoActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMovimientoAF(oeMovimientoActivoFijo As e_MovimientoActivoFijo) As Boolean Implements Il_ActivoFijo.GuardarMovimientoAF
        Try
            Return odMovimientoActivoFijo.Guardar(oeMovimientoActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarMovimientoAF(oeMovimientoActivoFijo As e_MovimientoActivoFijo) As Boolean Implements Il_ActivoFijo.EliminarMovimientoAF
        Try
            Return odMovimientoActivoFijo.Eliminar(oeMovimientoActivoFijo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class

