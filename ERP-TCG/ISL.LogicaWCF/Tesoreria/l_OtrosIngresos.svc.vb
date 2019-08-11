Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_OtrosIngresos
    Implements Il_OtrosIngresos

    Dim odOtrosIngresos As New d_OtrosIngresos

    Public Function Obtener(ByVal oeOtrosIngresos As e_OtrosIngresos) As e_OtrosIngresos Implements Il_OtrosIngresos.Obtener
        Try
            Return odOtrosIngresos.Obtener(oeOtrosIngresos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOtrosIngresos As e_OtrosIngresos) As List(Of e_OtrosIngresos) Implements Il_OtrosIngresos.Listar
        Try
            Return odOtrosIngresos.Listar(oeOtrosIngresos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOtrosIngresos As e_OtrosIngresos) As Boolean Implements Il_OtrosIngresos.Validar
        Try
            With oeOtrosIngresos
                If .TipoOperacion <> "C" Then
                    If .Importe = 0 Then Throw New Exception("Ingrese Importe")
                    If .Glosa = "" Then Throw New Exception("Ingrese Glosa")
                    If .IdConceptoIngresos = "" Then Throw New Exception("Ingrese Concepto")
                    If .IndIngresoEgreso = True Then
                        If .IdTrabajador = "" Then Throw New Exception("Ingrese Trabajador para Ingreso")
                    Else
                        If .IdCuentaBancaria = "" Then Throw New Exception("Ingrese Cuenta Bancaria para Egreso")
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOtrosIngresos As e_OtrosIngresos) As Boolean Implements Il_OtrosIngresos.Guardar
        Try
            If Validar(oeOtrosIngresos) Then
                Dim id As String = ""
                Dim oeAsiento As New e_Asiento
                Dim loAsiento As New List(Of e_Asiento)
                Dim olAsiento As New l_Asiento
                Dim oeAsientoMovimiento As New e_AsientoMovimiento
                Dim loAsientoMovimiento As New List(Of e_AsientoMovimiento)
                Using TransScope As New TransactionScope()
                    If odOtrosIngresos.Guardar(oeOtrosIngresos) Then
                        If oeOtrosIngresos.loAsientoModelo.Count > 0 Then
                            For Each asimod As e_AsientoModelo In oeOtrosIngresos.loAsientoModelo
                                oeAsiento = New e_Asiento
                                With oeAsiento
                                    .TipoOperacion = "I" : .IdTipoAsiento = asimod.IdTipoAsiento : .NroAsiento = String.Empty : .GlosaImprime = String.Empty
                                    .Glosa = asimod.Nombre & " " & oeOtrosIngresos.Glosa
                                    .IdMoneda = asimod.IdMoneda : .IdEstado = "CUADRADO" : oeAsiento.Activo = True : .TipoCambio = oeOtrosIngresos.TipoCambio
                                    .TotalDebe = oeOtrosIngresos.Importe : .TotalHaber = oeOtrosIngresos.Importe : .Fecha = oeOtrosIngresos.FechaCreacion
                                    .IdUsuarioCrea = oeOtrosIngresos.UsuarioCreacion : .IdPeriodo = oeOtrosIngresos.IdPeriodo
                                End With
                                For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle
                                    If asidet.Partida = "1" Then
                                        oeAsientoMovimiento = New e_AsientoMovimiento
                                        With oeAsientoMovimiento
                                            .TipoOperacion = "I"
                                            .IdUsuarioCrea = oeAsiento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                            .IdCuentaContable = asidet.IdCuentaContable
                                            .Glosa = oeAsiento.Glosa
                                            .DebeMN = Math.Round(oeOtrosIngresos.Importe, 2)
                                            .DebeME = Math.Round(oeOtrosIngresos.Importe / oeAsiento.TipoCambio, 2)
                                            If Not oeOtrosIngresos.IndIngresoEgreso Then
                                                With .MovimientoCajaBanco
                                                    .TipoOperacion = "I"
                                                    .IdFlujoCaja = "1CH000000212"
                                                    .NroBoucher = oeOtrosIngresos.Voucher
                                                    .IdCuentaBancaria = oeOtrosIngresos.IdCuentaBancaria
                                                    .Fecha = oeAsiento.Fecha
                                                    .IdMedioPago = "1CH02"
                                                    .Activo = True
                                                    .TipoCambio = oeAsiento.TipoCambio
                                                    .TotalMN = oeOtrosIngresos.Importe
                                                    .TotalME = Math.Round(oeOtrosIngresos.Importe / oeAsiento.TipoCambio, 2)
                                                    ._Operador = 1
                                                End With
                                            End If
                                            If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                        End With                             
                                    Else
                                        oeAsientoMovimiento = New e_AsientoMovimiento
                                        With oeAsientoMovimiento
                                            .TipoOperacion = "I"
                                            .IdUsuarioCrea = oeAsiento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                            .IdCuentaContable = asidet.IdCuentaContable
                                            .HaberMN = oeOtrosIngresos.Importe
                                            .HaberME = Math.Round(oeOtrosIngresos.Importe / oeAsiento.TipoCambio, 2)
                                            .Glosa = oeAsiento.Glosa
                                            'If Not oeOtrosIngresos.IndIngresoEgreso Then
                                            '    With .MovimientoCajaBanco
                                            '        .TipoOperacion = "I"
                                            '        .IdFlujoCaja = "1CH000000212"
                                            '        .NroBoucher = oeOtrosIngresos.Voucher
                                            '        .IdCuentaBancaria = oeOtrosIngresos.IdCuentaBancaria
                                            '        .Fecha = oeAsiento.Fecha
                                            '        .IdMedioPago = "1CH02"
                                            '        .Activo = True
                                            '        .TipoCambio = oeAsiento.TipoCambio
                                            '        .TotalMN = oeOtrosIngresos.Importe
                                            '        .TotalME = Math.Round(oeOtrosIngresos.Importe / oeAsiento.TipoCambio, 2)
                                            '        ._Operador = -1
                                            '    End With
                                            'End If
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
                'Dim oeCtaBancaria As New e_CuentaBancaria
                'Dim olCtaBancaria As New l_CuentaBancaria
                'Dim LstCuentaBancaria As New List(Of e_CuentaBancaria)
                'oeCtaBancaria.Activo = True
                'oeCtaBancaria.IdMoneda = "1CH01"
                'oeCtaBancaria.Ejercicio = Year(oeOtrosIngresos.Fecha)
                'LstCuentaBancaria = olCtaBancaria.Listar(oeCtaBancaria)

                'If oeOtrosIngresos.IdConceptoIngresos = "1SI000000002" Or oeOtrosIngresos.IdConceptoIngresos = "1SI000000005" Then ' PRESTAMOS DE CUENTA ISL
                '    Dim TipoTransf As String = ""
                '    Dim oeAsiento As New e_Asiento
                '    oeAsiento.TipoOperacion = "I"
                '    oeAsiento.IdTipoAsiento = "BANCO"
                '    oeAsiento.IdUsuarioCrea = oeOtrosIngresos.UsuarioCreacion
                '    oeAsiento.TipoCambio = oeOtrosIngresos.TipoCambio
                '    oeAsiento.IdMoneda = "1CH01"
                '    oeAsiento.Glosa = oeOtrosIngresos.Glosa
                '    oeAsiento.IdUsuarioBloquea = ""
                '    Dim olMovimientosBancarios As New l_MovimientoCajaBanco
                '    Dim oeMovimientosBancariosOrigen As New e_MovimientoCajaBanco
                '    Dim oeMovimientosBancariosDestino As New e_MovimientoCajaBanco
                '    Dim oeTCD As New e_TablaContableDet
                '    Dim odTCD As New d_TablaContableDet
                '    oeTCD.TipoOperacion = "N"
                '    oeTCD.Activo = True
                '    oeTCD.Nombre = "CUENTAS GENERALES"
                '    oeTCD.Valor1 = oeOtrosIngresos.Fecha.Year
                '    oeTCD.Texto1 = "CTA_OTROSINGRESOS"
                '    oeTCD = odTCD.Listar(oeTCD)(0)

                '    If oeOtrosIngresos.IndIngresoEgreso = True Then 'ingreso al fondo fijo
                '        TipoTransf = " CON CHEQUE "
                '        'cta 10212 
                '        With oeMovimientosBancariosDestino
                '            .TotalMN = oeOtrosIngresos.Importe + oeOtrosIngresos.DifDepositada
                '            .TotalME = (oeOtrosIngresos.Importe + oeOtrosIngresos.DifDepositada) / oeOtrosIngresos.TipoCambio
                '            .TipoCambio = oeOtrosIngresos.TipoCambio
                '            .IdMedioPago = "1CH01"
                '            ._IdCuentaContable = oeTCD.Texto2
                '            .Fecha = oeOtrosIngresos.Fecha
                '            .NroBoucher = oeOtrosIngresos.Voucher
                '            ._Operador = 1
                '        End With
                '        'cta 104
                '        With oeMovimientosBancariosOrigen
                '            .TotalMN = (oeOtrosIngresos.Importe + oeOtrosIngresos.DifDepositada)
                '            .TotalME = (oeOtrosIngresos.Importe + oeOtrosIngresos.DifDepositada) / oeOtrosIngresos.TipoCambio
                '            .TipoCambio = oeOtrosIngresos.TipoCambio
                '            .IdMedioPago = "1CH01"
                '            ._IdCuentaContable = LstCuentaBancaria.Where(Function(i) i.Id = oeOtrosIngresos.IdCuentaBancaria)(0).IdCuentaContable ''**
                '            .IdCuentaBancaria = oeOtrosIngresos.IdCuentaBancaria ''**
                '            .Fecha = oeOtrosIngresos.Fecha
                '            .NroBoucher = oeOtrosIngresos.Voucher
                '            ._Operador = -1
                '        End With
                '    Else 'egresa del fondo fijo
                '        'cta 104 
                '        TipoTransf = " CON DEPOSITO EN CUENTA "
                '        With oeMovimientosBancariosDestino
                '            .TotalMN = oeOtrosIngresos.Importe
                '            .TotalME = oeOtrosIngresos.Importe / oeOtrosIngresos.TipoCambio
                '            .TipoCambio = oeOtrosIngresos.TipoCambio
                '            .IdMedioPago = "1CH02"
                '            ._IdCuentaContable = LstCuentaBancaria.Where(Function(i) i.Id = oeOtrosIngresos.IdCuentaBancaria)(0).IdCuentaContable ''**
                '            .IdCuentaBancaria = oeOtrosIngresos.IdCuentaBancaria ''**
                '            .Fecha = oeOtrosIngresos.Fecha
                '            .NroBoucher = oeOtrosIngresos.Voucher
                '            ._Operador = 1
                '        End With
                '        'cta 10212
                '        With oeMovimientosBancariosOrigen
                '            .TotalMN = oeOtrosIngresos.Importe
                '            .TotalME = oeOtrosIngresos.Importe / oeOtrosIngresos.TipoCambio
                '            .TipoCambio = oeOtrosIngresos.TipoCambio
                '            .IdMedioPago = "1CH02"
                '            ._IdCuentaContable = oeTCD.Texto2
                '            .Fecha = oeOtrosIngresos.Fecha
                '            .NroBoucher = oeOtrosIngresos.Voucher
                '            ._Operador = -1
                '        End With
                '    End If

                '    olMovimientosBancarios.GuardarTranferencia(oeMovimientosBancariosOrigen, _
                '    oeMovimientosBancariosDestino, oeAsiento, False, TipoTransf)

                '    If oeOtrosIngresos.DifDepositada > 0 Then
                '        oeAsiento = New e_Asiento
                '        oeAsiento.TipoOperacion = "I"
                '        oeAsiento.IdTipoAsiento = "BANCO"
                '        oeAsiento.IdUsuarioCrea = oeOtrosIngresos.UsuarioCreacion
                '        oeAsiento.TipoCambio = oeOtrosIngresos.TipoCambio
                '        oeAsiento.IdMoneda = "1CH01"
                '        oeAsiento.Glosa = oeOtrosIngresos.Glosa
                '        'egresa del fondo fijo
                '        'cta 104 
                '        TipoTransf = " CON DEPOSITO EN CUENTA "
                '        oeMovimientosBancariosDestino = New e_MovimientoCajaBanco
                '        With oeMovimientosBancariosDestino
                '            .TotalMN = oeOtrosIngresos.DifDepositada
                '            .TotalME = oeOtrosIngresos.DifDepositada / oeOtrosIngresos.TipoCambio
                '            .TipoCambio = oeOtrosIngresos.TipoCambio
                '            .IdMedioPago = "1CH02"
                '            ._IdCuentaContable = LstCuentaBancaria.Where(Function(i) i.Id = oeOtrosIngresos.IdCuentaBancaria)(0).IdCuentaContable ''**
                '            .IdCuentaBancaria = oeOtrosIngresos.IdCuentaBancaria
                '            .Fecha = oeOtrosIngresos.Fecha
                '            .NroBoucher = oeOtrosIngresos.Voucher
                '            ._Operador = 1
                '        End With
                '        'cta 10212
                '        oeMovimientosBancariosOrigen = New e_MovimientoCajaBanco
                '        With oeMovimientosBancariosOrigen
                '            .TotalMN = oeOtrosIngresos.DifDepositada
                '            .TotalME = oeOtrosIngresos.DifDepositada / oeOtrosIngresos.TipoCambio
                '            .TipoCambio = oeOtrosIngresos.TipoCambio
                '            .IdMedioPago = "1CH02"
                '            ._IdCuentaContable = oeTCD.Texto2
                '            .Fecha = oeOtrosIngresos.Fecha
                '            .NroBoucher = oeOtrosIngresos.Voucher
                '            ._Operador = -1
                '        End With
                '        olMovimientosBancarios.GuardarTranferencia(oeMovimientosBancariosOrigen, _
                '        oeMovimientosBancariosDestino, oeAsiento, False, TipoTransf)

                '    End If

                'ElseIf oeOtrosIngresos.IdConceptoIngresos = "1SI000000019" And oeOtrosIngresos.IndIngresoEgreso = 0 Then

                '    Dim TipoTransf As String = ""
                '    Dim oeAsiento As New e_Asiento
                '    oeAsiento.TipoOperacion = "I"
                '    oeAsiento.IdTipoAsiento = "BANCO"
                '    oeAsiento.IdUsuarioCrea = oeOtrosIngresos.UsuarioCreacion
                '    oeAsiento.TipoCambio = oeOtrosIngresos.TipoCambio
                '    oeAsiento.IdMoneda = "1CH01"
                '    oeAsiento.Glosa = oeOtrosIngresos.Glosa
                '    oeAsiento.IdUsuarioBloquea = ""
                '    Dim olMovimientosBancarios As New l_MovimientoCajaBanco
                '    Dim oeMovimientosBancariosOrigen As New e_MovimientoCajaBanco
                '    Dim oeMovimientosBancariosDestino As New e_MovimientoCajaBanco
                '    'Dim oeTCD As New e_TablaContableDet
                '    'Dim odTCD As New d_TablaContableDet
                '    'oeTCD.TipoOperacion = "N"
                '    'oeTCD.Activo = True
                '    'oeTCD.Nombre = "CUENTAS GENERALES"
                '    'oeTCD.Valor1 = oePrestamosCuenta.Fecha.Year
                '    'oeTCD.Texto1 = "CTA_OTROSINGRESOS"
                '    'oeTCD = odTCD.Listar(oeTCD)(0)
                '    Dim oeCuentas As New e_CuentaContable
                '    Dim olCuentas As New l_CuentaContable
                '    Dim LstCuentas As New List(Of e_CuentaContable)
                '    oeCuentas.Ejercicio = Year(oeOtrosIngresos.Fecha)
                '    oeCuentas.Activo = 1
                '    LstCuentas = olCuentas.Listar(oeCuentas)

                '    TipoTransf = "" '' " CON CHEQUE "
                '    'CÓDIGO PARA EL TIPO "E"
                '    'egresa del fondo fijo
                '    'cta 104-11
                '    TipoTransf = " CON DEPOSITO EN CUENTA "
                '    With oeMovimientosBancariosDestino
                '        .TotalMN = oeOtrosIngresos.Importe
                '        .TotalME = oeOtrosIngresos.Importe / oeOtrosIngresos.TipoCambio
                '        .TipoCambio = oeOtrosIngresos.TipoCambio
                '        .IdMedioPago = "1CH02"
                '        ._IdCuentaContable = LstCuentas.Where(Function(i) i.Cuenta = "10411")(0).Id
                '        .IdCuentaBancaria = oeOtrosIngresos.IdCuentaBancaria
                '        .Fecha = oeOtrosIngresos.Fecha
                '        .NroBoucher = oeOtrosIngresos.Voucher
                '        ._Operador = 1
                '    End With
                '    'cta 10111-10212
                '    With oeMovimientosBancariosOrigen
                '        .TotalMN = oeOtrosIngresos.Importe
                '        .TotalME = oeOtrosIngresos.Importe / oeOtrosIngresos.TipoCambio
                '        .TipoCambio = oeOtrosIngresos.TipoCambio
                '        .IdMedioPago = "1CH02"
                '        ._IdCuentaContable = LstCuentas.Where(Function(i) i.Cuenta = "10111")(0).Id
                '        .Fecha = oeOtrosIngresos.Fecha
                '        .NroBoucher = oeOtrosIngresos.Voucher
                '        ._Operador = -1
                '    End With

                '    olMovimientosBancarios.GuardarTranferencia(oeMovimientosBancariosOrigen, _
                '    oeMovimientosBancariosDestino, oeAsiento, False, TipoTransf)

                '    If oeOtrosIngresos.DifDepositada > 0 Then
                '        oeAsiento = New e_Asiento
                '        oeAsiento.TipoOperacion = "I"
                '        oeAsiento.IdTipoAsiento = "BANCO"
                '        oeAsiento.IdUsuarioCrea = oeOtrosIngresos.UsuarioCreacion
                '        oeAsiento.TipoCambio = oeOtrosIngresos.TipoCambio
                '        oeAsiento.IdMoneda = "1CH01"
                '        oeAsiento.Glosa = oeOtrosIngresos.Glosa
                '        'egresa del fondo fijo
                '        'cta 104 
                '        TipoTransf = " CON DEPOSITO EN CUENTA "
                '        oeMovimientosBancariosDestino = New e_MovimientoCajaBanco
                '        With oeMovimientosBancariosDestino
                '            .TotalMN = oeOtrosIngresos.DifDepositada
                '            .TotalME = oeOtrosIngresos.DifDepositada / oeOtrosIngresos.TipoCambio
                '            .TipoCambio = oeOtrosIngresos.TipoCambio
                '            .IdMedioPago = "1CH02"
                '            ._IdCuentaContable = LstCuentas.Where(Function(i) i.Cuenta = "10411")(0).Id.ToString
                '            .IdCuentaBancaria = oeOtrosIngresos.IdCuentaBancaria ''**
                '            .Fecha = oeOtrosIngresos.Fecha
                '            .NroBoucher = oeOtrosIngresos.Voucher
                '            ._Operador = 1
                '        End With
                '        'cta 10212
                '        oeMovimientosBancariosOrigen = New e_MovimientoCajaBanco
                '        With oeMovimientosBancariosOrigen
                '            .TotalMN = oeOtrosIngresos.DifDepositada
                '            .TotalME = oeOtrosIngresos.DifDepositada / oeOtrosIngresos.TipoCambio
                '            .TipoCambio = oeOtrosIngresos.TipoCambio
                '            .IdMedioPago = "1CH02"
                '            ._IdCuentaContable = LstCuentas.Where(Function(i) i.Cuenta = "10111")(0).Id.ToString
                '            .Fecha = oeOtrosIngresos.Fecha
                '            .NroBoucher = oeOtrosIngresos.Voucher
                '            ._Operador = -1
                '        End With
                '        olMovimientosBancarios.GuardarTranferencia(oeMovimientosBancariosOrigen, _
                '        oeMovimientosBancariosDestino, oeAsiento, False, TipoTransf)
                '        ''
                '    End If

                'End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeOtrosIngresos As e_OtrosIngresos) As Boolean Implements Il_OtrosIngresos.Eliminar
        Try
            Return odOtrosIngresos.Eliminar(oeOtrosIngresos)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
