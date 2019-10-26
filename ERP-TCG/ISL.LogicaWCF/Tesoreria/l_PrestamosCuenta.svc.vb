'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

Public Class l_PrestamosCuenta
    Implements Il_PrestamosCuenta
    Dim odPrestamosCuenta As New d_PrestamosCuenta

    Public Function Eliminar(ByVal oePrestamosCuenta As e_PrestamosCuenta) As Boolean Implements Il_PrestamosCuenta.Eliminar
        Try
            Return odPrestamosCuenta.Eliminar(oePrestamosCuenta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oePrestamosCuenta As e_PrestamosCuenta) As Boolean Implements Il_PrestamosCuenta.Guardar
        Try
            Dim oeAsiento As New e_Asiento
            Dim loAsiento As New List(Of e_Asiento)
            Dim olAsiento As New l_Asiento
            Dim oeAsientoMovimiento As New e_AsientoMovimiento
            Dim loAsientoMovimiento As New List(Of e_AsientoMovimiento)
            Using TransScope As New TransactionScope()
                If odPrestamosCuenta.Guardar(oePrestamosCuenta) Then
                    If oePrestamosCuenta.loAsientoModelo.Count > 0 Then
                        For Each asimod As e_AsientoModelo In oePrestamosCuenta.loAsientoModelo
                            asimod.PrefijoID = oePrestamosCuenta.PrefijoID '@0001
                            oeAsiento = New e_Asiento
                            oeAsiento.PrefijoID = oePrestamosCuenta.PrefijoID '@0001
                            With oeAsiento
                                .TipoOperacion = "I" : .IdTipoAsiento = asimod.IdTipoAsiento : .NroAsiento = String.Empty : .GlosaImprime = String.Empty
                                If oePrestamosCuenta.IndIngEgr = "I" Then
                                    .Glosa = asimod.Nombre & " CON CHEQUE NRO: " & oePrestamosCuenta.NroDocumento
                                Else
                                    .Glosa = asimod.Nombre & " CON VOUCHER NRO: " & oePrestamosCuenta.NroDocumento
                                End If
                                .IdMoneda = asimod.IdMoneda : .IdEstado = "CUADRADO" : oeAsiento.Activo = True : .TipoCambio = oePrestamosCuenta.TipoCambio
                                .TotalDebe = oePrestamosCuenta.Importe : .TotalHaber = oePrestamosCuenta.Importe : .Fecha = oePrestamosCuenta.FechaCreacion
                                .IdUsuarioCrea = oePrestamosCuenta.UsuarioCreacion : .IdPeriodo = oePrestamosCuenta.oePeriodo.Id
                            End With
                            For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle
                                asidet.PrefijoID = oePrestamosCuenta.PrefijoID '@0001
                                If asidet.Partida = "1" Then
                                    oeAsientoMovimiento = New e_AsientoMovimiento
                                    oeAsientoMovimiento.PrefijoID = oePrestamosCuenta.PrefijoID '@0001
                                    With oeAsientoMovimiento
                                        .TipoOperacion = "I"
                                        .IdUsuarioCrea = oeAsiento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                        .IdCuentaContable = asidet.IdCuentaContable
                                        .Glosa = oeAsiento.Glosa
                                        If asimod.IdMoneda = "1CH01" Then
                                            .DebeMN = Math.Round(oePrestamosCuenta.Importe, 2)
                                            .DebeME = Math.Round(oePrestamosCuenta.Importe / oeAsiento.TipoCambio, 2)
                                        Else
                                            .DebeME = Math.Round(oePrestamosCuenta.Importe, 2)
                                            .DebeMN = Math.Round(oePrestamosCuenta.Importe * oeAsiento.TipoCambio, 2)
                                        End If
                                        If asidet.Cuenta = "10411" Then
                                            With .MovimientoCajaBanco
                                                .TipoOperacion = "I"
                                                .IdFlujoCaja = "1CH000000211"
                                                .NroBoucher = oePrestamosCuenta.NroDocumento
                                                .IdCuentaBancaria = oePrestamosCuenta.oeCtaBancaria.Id
                                                .Fecha = oeAsiento.Fecha
                                                .IdMedioPago = IIf(oePrestamosCuenta.IndIngEgr = "I", "1CH01", "1CH02")
                                                .Activo = True
                                                .TipoCambio = oeAsiento.TipoCambio
                                                .TotalMN = oePrestamosCuenta.Importe
                                                .TotalME = Math.Round(oePrestamosCuenta.Importe / oeAsiento.TipoCambio, 2)
                                                ._Operador = 1
                                                .PrefijoID = oePrestamosCuenta.PrefijoID '@0001
                                            End With
                                        End If

                                        If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                    End With
                                Else
                                    oeAsientoMovimiento = New e_AsientoMovimiento
                                    oeAsientoMovimiento.PrefijoID = oePrestamosCuenta.PrefijoID '@0001
                                    With oeAsientoMovimiento
                                        .TipoOperacion = "I"
                                        .IdUsuarioCrea = oeAsiento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                        .IdCuentaContable = asidet.IdCuentaContable
                                        .Glosa = asidet.Titulo
                                        If asimod.IdMoneda = "1CH01" Then
                                            .HaberMN = oePrestamosCuenta.Importe
                                            .HaberME = Math.Round(oePrestamosCuenta.Importe / oeAsiento.TipoCambio, 2)
                                        Else
                                            .HaberME = oePrestamosCuenta.Importe
                                            .HaberMN = Math.Round(oePrestamosCuenta.Importe * oeAsiento.TipoCambio, 2)
                                        End If
                                        .Glosa = oeAsiento.Glosa
                                        If asidet.Cuenta = "10411" Then
                                            With .MovimientoCajaBanco
                                                .TipoOperacion = "I"
                                                .IdFlujoCaja = "1CH000000212"
                                                .NroBoucher = oePrestamosCuenta.NroDocumento
                                                .IdCuentaBancaria = oePrestamosCuenta.oeCtaBancaria.Id
                                                .Fecha = oeAsiento.Fecha
                                                .IdMedioPago = IIf(oePrestamosCuenta.IndIngEgr = "I", "1CH01", "1CH02")
                                                .Activo = True
                                                .TipoCambio = oeAsiento.TipoCambio
                                                .TotalMN = oePrestamosCuenta.Importe
                                                .TotalME = Math.Round(oePrestamosCuenta.Importe / oeAsiento.TipoCambio, 2)
                                                ._Operador = -1
                                                .PrefijoID = oePrestamosCuenta.PrefijoID '@0001
                                            End With
                                        End If
                                        If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                    End With
                                End If
                            Next
                        Next
                        oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                        loAsiento.Add(oeAsiento)
                        If olAsiento.GuardarLista(loAsiento) Then
                            TransScope.Complete()
                        End If
                    Else
                        TransScope.Complete()
                    End If
                End If
            End Using
            Return True

            '    If .IdConceptoIngresos = "1SI000000002" Or .IdConceptoIngresos = "1SI000000005" Then ' PRESTAMOS DE CUENTA ISL
            '        Dim TipoTransf As String = ""
            '        .oeAsientoPrestamo = New e_Asiento
            '        .oeAsientoPrestamo.TipoOperacion = "I"
            '        .oeAsientoPrestamo.IdTipoAsiento = "BANCO"
            '        .oeAsientoPrestamo.IdUsuarioCrea = oePrestamosCuenta.UsuarioCreacion
            '        .oeAsientoPrestamo.TipoCambio = oePrestamosCuenta.TipoCambio
            '        .oeAsientoPrestamo.IdMoneda = "1CH01"
            '        .oeAsientoPrestamo.Glosa = oePrestamosCuenta.Glosa
            '        .oeAsientoPrestamo.IdUsuarioBloquea = ""
            '        ''''Dim olMovimientosBancarios As New l_MovimientoCajaBanco
            '        .oeMovimientosBancariosOrigen = New e_MovimientoCajaBanco
            '        .oeMovimientosBancariosDestino = New e_MovimientoCajaBanco
            '        Dim oeTCD As New e_TablaContableDet
            '        Dim odTCD As New d_TablaContableDet
            '        oeTCD.TipoOperacion = "N"
            '        oeTCD.Activo = True
            '        oeTCD.Nombre = "CUENTAS GENERALES"
            '        oeTCD.Valor1 = .Fecha.Year
            '        oeTCD.Texto1 = "CTA_OTROSINGRESOS"
            '        oeTCD = odTCD.Listar(oeTCD)(0)

            '        If oePrestamosCuenta.IndIngEgr = "I" Then 'ingreso al fondo fijo
            '            TipoTransf = " CON CHEQUE "
            '            'cta 10212 
            '            With .oeMovimientosBancariosDestino
            '                .TotalMN = oePrestamosCuenta.Importe + oePrestamosCuenta.DifDepositada
            '                .TotalME = (oePrestamosCuenta.Importe + oePrestamosCuenta.DifDepositada) / oePrestamosCuenta.TipoCambio
            '                .TipoCambio = oePrestamosCuenta.TipoCambio
            '                .IdMedioPago = "1CH01"
            '                ._IdCuentaContable = oeTCD.Texto2
            '                .Fecha = oePrestamosCuenta.Fecha
            '                .NroBoucher = _voucher
            '                ._Operador = 1
            '            End With
            '            'cta 104
            '            With .oeMovimientosBancariosOrigen
            '                .TotalMN = (oePrestamosCuenta.Importe + oePrestamosCuenta.DifDepositada)
            '                .TotalME = (oePrestamosCuenta.Importe + oePrestamosCuenta.DifDepositada) / oePrestamosCuenta.TipoCambio
            '                .TipoCambio = oePrestamosCuenta.TipoCambio
            '                .IdMedioPago = "1CH01"
            '                ._IdCuentaContable = oePrestamosCuenta.oeCtaBancaria.IdCuentaContable
            '                .IdCuentaBancaria = oePrestamosCuenta.oeCtaBancaria.Id
            '                .Fecha = oePrestamosCuenta.Fecha
            '                .NroBoucher = _voucher
            '                ._Operador = -1
            '            End With
            '        Else 'egresa del fondo fijo
            '            'cta 104 
            '            TipoTransf = " CON DEPOSITO EN CUENTA "
            '            With .oeMovimientosBancariosDestino
            '                .TotalMN = oePrestamosCuenta.Importe
            '                .TotalME = oePrestamosCuenta.Importe / oePrestamosCuenta.TipoCambio
            '                .TipoCambio = oePrestamosCuenta.TipoCambio
            '                .IdMedioPago = "1CH02"
            '                ._IdCuentaContable = oePrestamosCuenta.oeCtaBancaria.IdCuentaContable
            '                .IdCuentaBancaria = oePrestamosCuenta.oeCtaBancaria.Id
            '                .Fecha = oePrestamosCuenta.Fecha
            '                .NroBoucher = _voucher
            '                ._Operador = 1
            '            End With
            '            'cta 10212
            '            With .oeMovimientosBancariosOrigen
            '                .TotalMN = oePrestamosCuenta.Importe
            '                .TotalME = oePrestamosCuenta.Importe / oePrestamosCuenta.TipoCambio
            '                .TipoCambio = oePrestamosCuenta.TipoCambio
            '                .IdMedioPago = "1CH02"
            '                ._IdCuentaContable = oeTCD.Texto2
            '                .Fecha = oePrestamosCuenta.Fecha
            '                .NroBoucher = _voucher
            '                ._Operador = -1
            '            End With
            '        End If
            '    ElseIf .IdConceptoIngresos = "1SI000000019" And .IndIngEgr = "E" Then

            '        Dim TipoTransf As String = ""
            '        .oeAsientoPrestamo = New e_Asiento
            '        .oeAsientoPrestamo.TipoOperacion = "I"
            '        .oeAsientoPrestamo.IdTipoAsiento = "BANCO"
            '        .oeAsientoPrestamo.IdUsuarioCrea = oePrestamosCuenta.UsuarioCreacion
            '        .oeAsientoPrestamo.TipoCambio = oePrestamosCuenta.TipoCambio
            '        .oeAsientoPrestamo.IdMoneda = "1CH01"
            '        .oeAsientoPrestamo.Glosa = oePrestamosCuenta.Glosa
            '        .oeAsientoPrestamo.IdUsuarioBloquea = ""
            '        .oeMovimientosBancariosOrigen = New e_MovimientoCajaBanco
            '        .oeMovimientosBancariosDestino = New e_MovimientoCajaBanco

            '        Dim oeCuentas As New e_CuentaContable
            '        Dim olCuentas As New l_CuentaContable
            '        Dim LstCuentas As New List(Of e_CuentaContable)
            '        oeCuentas.Ejercicio = Year(.Fecha)
            '        oeCuentas.Activo = 1
            '        LstCuentas = olCuentas.Listar(oeCuentas)

            '        TipoTransf = "" '' " CON CHEQUE "
            '        'CÓDIGO PARA EL TIPO "E"
            '        'egresa del fondo fijo
            '        'cta 104-11
            '        TipoTransf = " CON DEPOSITO EN CUENTA "
            '        With .oeMovimientosBancariosDestino
            '            .TotalMN = oePrestamosCuenta.Importe
            '            .TotalME = oePrestamosCuenta.Importe / oePrestamosCuenta.TipoCambio
            '            .TipoCambio = oePrestamosCuenta.TipoCambio
            '            .IdMedioPago = "1CH02"
            '            ._IdCuentaContable = LstCuentas.Where(Function(i) i.Cuenta = "10411")(0).Id
            '            .IdCuentaBancaria = oePrestamosCuenta.oeCtaBancaria.Id
            '            .Fecha = oePrestamosCuenta.Fecha
            '            .NroBoucher = _voucher
            '            ._Operador = 1
            '        End With
            '        'cta 10111-10212
            '        With .oeMovimientosBancariosOrigen
            '            .TotalMN = oePrestamosCuenta.Importe
            '            .TotalME = oePrestamosCuenta.Importe / oePrestamosCuenta.TipoCambio
            '            .TipoCambio = oePrestamosCuenta.TipoCambio
            '            .IdMedioPago = "1CH02"
            '            ._IdCuentaContable = LstCuentas.Where(Function(i) i.Cuenta = "10111")(0).Id
            '            .Fecha = oePrestamosCuenta.Fecha
            '            .NroBoucher = _voucher
            '            ._Operador = -1
            '        End With
            '    End If

            '    If olMovimientosBancarios.ValidarTransferencia(.oeMovimientosBancariosDestino) Then
            '        Dim GlosaReposicion As String = ""
            '        Dim odAsiento As New d_Asiento
            '        .oeMovimientosBancariosOrigen.TipoOperacion = "I"
            '        .oeMovimientosBancariosDestino.TipoOperacion = "I"
            '        Dim oePeriodo As New e_Periodo
            '        Dim lePeriodo As New List(Of e_Periodo)
            '        Dim olPeriodo As New l_Periodo
            '        oePeriodo.Activo = True
            '        oePeriodo.Id = ""
            '        oePeriodo.Codigo = .oeMovimientosBancariosOrigen.Fecha.Year.ToString + "-" + .oeMovimientosBancariosOrigen.Fecha.Month.ToString
            '        lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            '        .oeMovimientosBancariosOrigen.IdFlujoCaja = "1CH000000212"
            '        .oeMovimientosBancariosDestino.IdFlujoCaja = "1CH000000211"
            '        ''End If
            '        With .oeAsientoPrestamo
            '            .TipoOperacion = "I"
            '            .IdPeriodo = lePeriodo(0).Id
            '            '.IdTipoAsiento = iene de aplicacion
            '            .Fecha = oePrestamosCuenta.oeMovimientosBancariosOrigen.Fecha
            '            .Glosa = "TRANSF. DE FONDOS " & .Glosa
            '            .GlosaImprime = .Glosa
            '            If .IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
            '                .TotalDebe = oePrestamosCuenta.oeMovimientosBancariosOrigen.TotalMN
            '                .TotalHaber = oePrestamosCuenta.oeMovimientosBancariosOrigen.TotalMN
            '            Else
            '                .TotalDebe = oePrestamosCuenta.oeMovimientosBancariosOrigen.TotalME
            '                .TotalHaber = oePrestamosCuenta.oeMovimientosBancariosOrigen.TotalME
            '            End If
            '            '.IdUsuarioCrea =VIENE DE APLICACION
            '            .IdEstado = "CUADRADO"
            '        End With
            '        Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oePrestamosCuenta.oeMovimientosBancariosDestino._IdCuentaContable
            '            .Glosa = oePrestamosCuenta.oeAsientoPrestamo.Glosa
            '            .HaberMN = 0
            '            .HaberME = 0
            '            .DebeMN = oePrestamosCuenta.oeMovimientosBancariosDestino.TotalMN
            '            .DebeME = oePrestamosCuenta.oeMovimientosBancariosDestino.TotalME
            '            .IdUsuarioCrea = oePrestamosCuenta.oeAsientoPrestamo.IdUsuarioCrea
            '            .Activo = True
            '            .MovimientoCajaBanco = oePrestamosCuenta.oeMovimientosBancariosDestino
            '        End With
            '        oePrestamosCuenta.oeAsientoPrestamo.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oePrestamosCuenta.oeMovimientosBancariosOrigen._IdCuentaContable
            '            .Glosa = oePrestamosCuenta.oeAsientoPrestamo.Glosa
            '            .HaberMN = oePrestamosCuenta.oeMovimientosBancariosOrigen.TotalMN
            '            .HaberME = oePrestamosCuenta.oeMovimientosBancariosOrigen.TotalME
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = oePrestamosCuenta.oeAsientoPrestamo.IdUsuarioCrea
            '            .Activo = True
            '            .MovimientoCajaBanco = oePrestamosCuenta.oeMovimientosBancariosOrigen
            '        End With
            '        oePrestamosCuenta.oeAsientoPrestamo.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    End If
            'End With
            'oePrestamosCuenta.oeAsientoPrestamo.IndOrigen = 1
            'odPrestamosCuenta.Guardar(oePrestamosCuenta)
            'Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oePrestamosCuenta As e_PrestamosCuenta) As System.Collections.Generic.List(Of e_PrestamosCuenta) Implements Il_PrestamosCuenta.Listar
        Try
            Return odPrestamosCuenta.Listar(oePrestamosCuenta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePrestamosCuenta As e_PrestamosCuenta) As e_PrestamosCuenta Implements Il_PrestamosCuenta.Obtener
        Try
            Return odPrestamosCuenta.Obtener(oePrestamosCuenta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CerrarCuenta(oePrestamosCuenta As e_PrestamosCuenta) As Boolean Implements Il_PrestamosCuenta.CerrarCuenta
        Try
            Return odPrestamosCuenta.CierreCta(oePrestamosCuenta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
