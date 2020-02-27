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

<DataContract(), Serializable()> _
Public Class l_MovimientoCajaBanco
    Implements Il_MovimientoCajaBanco

    Dim odMovimientoCajaBanco As New d_MovimientoCajaBanco

    Public Function CrearDT() As System.Data.DataTable Implements Il_MovimientoCajaBanco.CrearDT
        Dim MovCajaBanco As New Data.DataTable
        With MovCajaBanco
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdFlujoCaja", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NroBoucher", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCuentaBancaria", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Fecha", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("IdTipoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPeriodoConcilia", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IdAsientoMovimiento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoCambio", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TotalMN", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TotalME", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Operador", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("NroImpresion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTipoGasto", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCaja", Type.GetType("System.String")))
        End With
        Return MovCajaBanco
    End Function

    Public Function Eliminar(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean Implements Il_MovimientoCajaBanco.Eliminar
        Try
            Return odMovimientoCajaBanco.Eliminar(oeMovimientoCajaBanco)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean Implements Il_MovimientoCajaBanco.Guardar
        Try
            If Validar(oeMovimientoCajaBanco) Then
                Return odMovimientoCajaBanco.Guardar(oeMovimientoCajaBanco)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarConciliacion(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean Implements Il_MovimientoCajaBanco.GuardarConciliacion
        Try
            Dim loFuncionesGenerales As New l_FuncionesGenerales
            loFuncionesGenerales.ValidarPeriodo(oeMovimientoCajaBanco.IdPeriodoConcilia, gAreasSGI.Contabilidad)
            odMovimientoCajaBanco.Guardar(oeMovimientoCajaBanco)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarTranferencia(ByRef oeMovimientoCajaBancoOrigen As e_MovimientoCajaBanco, _
            ByVal oeMovimientoCajaBancoDestino As e_MovimientoCajaBanco, _
            ByVal oeAsiento As e_Asiento, ByVal IndicaReposicion As Boolean, _
            Optional ByVal TipoTransf As String = "") As Boolean Implements Il_MovimientoCajaBanco.GuardarTranferencia
        Try
            If ValidarTransferencia(oeMovimientoCajaBancoOrigen) Then
                Dim GlosaReposicion As String = ""
                Dim odAsiento As New d_Asiento
                oeMovimientoCajaBancoOrigen.TipoOperacion = "I"
                oeMovimientoCajaBancoDestino.TipoOperacion = "I"
                Dim oePeriodo As New e_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                Dim olPeriodo As New l_Periodo
                oePeriodo.Activo = True
                oePeriodo.Id = ""
                oePeriodo.Codigo = oeMovimientoCajaBancoOrigen.Fecha.Year.ToString + "-" + oeMovimientoCajaBancoOrigen.Fecha.Month.ToString
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
                oeMovimientoCajaBancoOrigen.IdFlujoCaja = "1CH000000212"
                oeMovimientoCajaBancoDestino.IdFlujoCaja = "1CH000000211"
                oeAsiento.PrefijoID = oeMovimientoCajaBancoOrigen.PrefijoID '@0001
                With oeAsiento
                    .TipoOperacion = "I"
                    .IdPeriodo = lePeriodo(0).Id
                    .Fecha = oeMovimientoCajaBancoOrigen.Fecha
                    If IndicaReposicion Then
                        GlosaReposicion = .Glosa
                        .Glosa = "REPOSICION DE CAJA CHICA"
                        .GlosaImprime = .Glosa
                    Else
                        .Glosa = "TRANSF. DE FONDOS " & TipoTransf & .Glosa
                        .GlosaImprime = .Glosa
                    End If
                    If .IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
                        .TotalDebe = oeMovimientoCajaBancoOrigen.TotalMN
                        .TotalHaber = oeMovimientoCajaBancoOrigen.TotalMN
                    Else
                        .TotalDebe = oeMovimientoCajaBancoOrigen.TotalME
                        .TotalHaber = oeMovimientoCajaBancoOrigen.TotalME
                    End If
                    .IdEstado = "CUADRADO"
                End With
                Dim oeAsientoMovimiento As New e_AsientoMovimiento
                oeAsientoMovimiento.PrefijoID = oeMovimientoCajaBancoOrigen.PrefijoID '@0001
                With oeAsientoMovimiento
                    .TipoOperacion = "I"
                    .IdCuentaContable = oeMovimientoCajaBancoDestino._IdCuentaContable
                    .Glosa = oeAsiento.Glosa
                    .HaberMN = 0
                    .HaberME = 0
                    .DebeMN = oeMovimientoCajaBancoDestino.TotalMN
                    .DebeME = oeMovimientoCajaBancoDestino.TotalME
                    .IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                    .Activo = True
                    .MovimientoCajaBanco = oeMovimientoCajaBancoDestino
                    If IndicaReposicion Then
                        .MovimientoCajaBanco.NroBoucher = Strings.Left(GlosaReposicion, 20)
                    End If
                End With
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                oeAsientoMovimiento = New e_AsientoMovimiento
                oeAsientoMovimiento.PrefijoID = oeMovimientoCajaBancoOrigen.PrefijoID '@0001
                With oeAsientoMovimiento
                    .TipoOperacion = "I"
                    .IdCuentaContable = oeMovimientoCajaBancoOrigen._IdCuentaContable
                    .Glosa = oeAsiento.Glosa
                    .HaberMN = oeMovimientoCajaBancoOrigen.TotalMN
                    .HaberME = oeMovimientoCajaBancoOrigen.TotalME
                    .DebeMN = 0
                    .DebeME = 0
                    .IdUsuarioCrea = oeAsiento.IdUsuarioCrea
                    .Activo = True
                    .MovimientoCajaBanco = oeMovimientoCajaBancoOrigen
                End With
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                odAsiento.Guardar(oeAsiento, Nothing)
                oeMovimientoCajaBancoOrigen.Id = oeAsiento._IdMovimientoCajaBanco
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As System.Collections.Generic.List(Of e_MovimientoCajaBanco) Implements Il_MovimientoCajaBanco.Listar
        Try
            Return odMovimientoCajaBanco.Listar(oeMovimientoCajaBanco)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As e_MovimientoCajaBanco Implements Il_MovimientoCajaBanco.Obtener
        Try
            Return odMovimientoCajaBanco.Obtener(oeMovimientoCajaBanco)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean Implements Il_MovimientoCajaBanco.Validar
        Try
            With oeMovimientoCajaBanco
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarTransferencia(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean Implements Il_MovimientoCajaBanco.ValidarTransferencia
        Try
            With oeMovimientoCajaBanco
                '---------VALIDARRRRRRRRRR-------------
                Dim loFuncionesGenerales As New l_FuncionesGenerales
                loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, oeMovimientoCajaBanco.Fecha, _
                oeMovimientoCajaBanco.Fecha.Year.ToString & "-" & oeMovimientoCajaBanco.Fecha.Month.ToString)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarTransBancaria(ByVal oeMovCajaBanco As e_MovimientoCajaBanco, _
                                         ByVal oeAsientoModel As e_AsientoModelo, _
                                         ByVal lePrestamo As List(Of e_Prestamo), _
                                         ByVal IndDscto As Boolean) As Boolean Implements Il_MovimientoCajaBanco.GuardarTransBancaria
        Try
            Dim oeAsiento As New e_Asiento, olAsiento As New l_Asiento, oeAsientoMov As New e_AsientoMovimiento, oeMovAnalisis As New e_MovimientoAnalisis
            Dim oePrestamo As New e_Prestamo, odPrestamo As New d_Prestamo, lePrestInserta As New List(Of e_Prestamo)
            Using TransScope As New TransactionScope()
                oeAsiento.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                With oeAsiento
                    .TipoOperacion = "I" : .IdPeriodo = oeMovCajaBanco.IdPeriodoCtble : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                    .NroAsiento = String.Empty : .Fecha = oeMovCajaBanco.Fecha : .Glosa = oeAsientoModel.Nombre
                    If lePrestamo.Count > 0 Then .Glosa = .Glosa & " A TRABAJADOR: " & lePrestamo(0).Trabajador
                    .GlosaImprime = String.Empty : .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeMovCajaBanco.TipoCambio
                    .TotalDebe = IIf(oeAsientoModel.Moneda = "SOLES", oeMovCajaBanco.TotalMN, oeMovCajaBanco.TotalME)
                    .TotalHaber = IIf(oeAsientoModel.Moneda = "SOLES", oeMovCajaBanco.TotalMN, oeMovCajaBanco.TotalME)
                    .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeMovCajaBanco.UsuarioCreacion : oeAsiento.Activo = True
                End With
                For Each oeAux In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila).ToList
                    oeAux.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                    oeAsientoMov = New e_AsientoMovimiento
                    oeAsientoMov.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                    With oeAsientoMov
                        .TipoOperacion = "I" : .IdCuentaContable = oeAux.IdCuentaContable.Trim : .Glosa = oeAsiento.Glosa
                        If oeAux.Partida = 1 Then
                            .DebeMN = oeMovCajaBanco.TotalMN : .DebeME = oeMovCajaBanco.TotalME
                            If lePrestamo.Count > 0 Then
                                For Each oePresAux In lePrestamo
                                    oePresAux.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                                    oeMovAnalisis = New e_MovimientoAnalisis
                                    oeMovAnalisis.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                                    oeMovAnalisis.TipoOperacion = ""
                                    oeMovAnalisis.IdMoneda = oeAsientoModel.IdMoneda
                                    oeMovAnalisis.IdUsuarioCrea = oeMovCajaBanco.UsuarioCreacion
                                    oeMovAnalisis.Monto = oePresAux._MontoAux
                                    oeMovAnalisis.Saldo = oePresAux._MontoAux
                                    oeMovAnalisis.IdTrabajador = oePresAux.IdTrabajador
                                    oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                    'oePresAux.IdTrabajador = String.Empty 'Truncar la Transaccion por FK
                                    If IndDscto Then lePrestInserta.Add(oePresAux)
                                Next
                            End If
                        Else
                            .HaberMN = oeMovCajaBanco.TotalMN : .HaberME = oeMovCajaBanco.TotalME
                        End If
                        .IdUsuarioCrea = oeMovCajaBanco.UsuarioCreacion : .Activo = True
                        If oeAux.IdCuentaContable.Trim = oeMovCajaBanco._IdCuentaContable.Trim Then .MovimientoCajaBanco = oeMovCajaBanco
                        oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                    End With
                Next
                If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                    If IndDscto Then
                        If lePrestInserta.Count > 0 Then odPrestamo.GuardarLista2(lePrestInserta)
                    Else
                        Dim odDetPlanilla As New d_DetallePlanilla
                        If lePrestamo.Count > 0 Then odDetPlanilla.Guardar(New e_DetallePlanilla With {.TipoOperacion = "P", .Id = lePrestamo(0).Id, .IsPagado = True})
                    End If
                    TransScope.Complete()
                    Return True
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarTransBancaria2(oeMovCajaBanco As e_MovimientoCajaBanco, _
                                          oeAsientoModel As e_AsientoModelo, _
                                          leAnalisis As List(Of e_Prestamo), _
                                          leDscto As List(Of e_Prestamo), _
                                          leCuota As List(Of e_PrestamoDetalle)) As Boolean Implements Il_MovimientoCajaBanco.GuardarTransBancaria2
        Try
            Dim oeAsiento As New e_Asiento, olAsiento As New l_Asiento, oeAsientoMov As New e_AsientoMovimiento, oeMovAnalisis As New e_MovimientoAnalisis
            Dim odDscto As New d_Prestamo
            Using TransScope As New TransactionScope()
                oeAsiento.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                With oeAsiento
                    .TipoOperacion = "I" : .IdPeriodo = oeMovCajaBanco.IdPeriodoCtble : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                    .NroAsiento = String.Empty : .Fecha = oeMovCajaBanco.Fecha : .Glosa = oeAsientoModel.Nombre & ": " & leAnalisis(0).Trabajador
                    .GlosaImprime = String.Empty : .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeMovCajaBanco.TipoCambio
                    .TotalDebe = IIf(oeAsientoModel.Moneda = "SOLES", oeMovCajaBanco.TotalMN, oeMovCajaBanco.TotalME)
                    .TotalHaber = IIf(oeAsientoModel.Moneda = "SOLES", oeMovCajaBanco.TotalMN, oeMovCajaBanco.TotalME)
                    .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeMovCajaBanco.UsuarioCreacion : oeAsiento.Activo = True
                End With
                For Each oeAux In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila).ToList
                    oeAux.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                    oeAsientoMov = New e_AsientoMovimiento
                    oeAsientoMov.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                    With oeAsientoMov
                        .TipoOperacion = "I" : .IdCuentaContable = oeAux.IdCuentaContable.Trim : .Glosa = oeAsiento.Glosa
                        If oeAux.Partida = 1 Then
                            .DebeMN = oeMovCajaBanco.TotalMN : .DebeME = oeMovCajaBanco.TotalME
                        Else
                            Dim _montoaux = leAnalisis.Where(Function(it) it.IndProv = oeAux.Fila).Sum(Function(it) it.Monto)
                            If _montoaux > 0 Then
                                .HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", _montoaux, (_montoaux / oeAsiento.TipoCambio))
                                .HaberME = IIf(oeAsientoModel.Moneda = "SOLES", (_montoaux / oeAsiento.TipoCambio), _montoaux)
                                If leAnalisis.Count > 0 Then
                                    For Each oePresAux In leAnalisis.Where(Function(it) it.IndProv = oeAux.Fila).ToList
                                        oePresAux.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                                        oeMovAnalisis = New e_MovimientoAnalisis
                                        oeMovAnalisis.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                                        oeMovAnalisis.TipoOperacion = ""
                                        oeMovAnalisis.IdMoneda = oeAsientoModel.IdMoneda
                                        oeMovAnalisis.IdUsuarioCrea = oeAsientoModel.UsuarioCreacion
                                        oeMovAnalisis.Monto = oePresAux.Monto
                                        oeMovAnalisis.Saldo = oePresAux.Saldo
                                        oeMovAnalisis.IdTrabajador = oePresAux.IdTrabajador
                                        oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                    Next
                                End If
                            End If
                        End If
                        .IdUsuarioCrea = oeMovCajaBanco.UsuarioCreacion : .Activo = True
                        If oeAux.IdCuentaContable.Trim = oeMovCajaBanco._IdCuentaContable.Trim Then .MovimientoCajaBanco = oeMovCajaBanco
                        If oeAux.Partida = 1 AndAlso .DebeMN > 0 Then oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                        If oeAux.Partida = 2 AndAlso .HaberMN > 0 Then oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                    End With
                Next
                If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                    odDscto.CobrarCuota(leDscto, leCuota)
                    TransScope.Complete()
                    Return True
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
