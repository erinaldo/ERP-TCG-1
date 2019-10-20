'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Transactions

Public Class l_ContratoFinanciero
    Implements Il_ContratoFinanciero

    Dim odContratoFinanciero As New d_ContratoFinanciero
    Private oeAsiento As New e_Asiento, olAsiento As New l_Asiento, oeAsientoMov As New e_AsientoMovimiento
    Private oeAsiMovObli As New e_AsientoMov_ObligacionFin, oeMovCajaBanco As New e_MovimientoCajaBanco, oeMovAnalisis As e_MovimientoAnalisis
    Private odMovDoc As New d_MovimientoDocumento, odObliFin As New d_ObligacionFinanciera
    Private leObliFinAux As New List(Of e_ObligacionFin), leAsiento As New List(Of e_Asiento)
    Private olFunGen As New l_FuncionesGenerales

    Public Function Obtener(ByVal oeContratoFinanciero As e_ContratoFinanciero) As e_ContratoFinanciero Implements Il_ContratoFinanciero.e_ContratoFinanciero
        Try
            Return odContratoFinanciero.Obtener(oeContratoFinanciero)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeContratoFinanciero As e_ContratoFinanciero) As List(Of e_ContratoFinanciero) Implements Il_ContratoFinanciero.Listar
        Try
            Return odContratoFinanciero.Listar(oeContratoFinanciero)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeContratoFinanciero As e_ContratoFinanciero) As System.Data.DataSet Implements Il_ContratoFinanciero.ListarDS
        Try
            Return odContratoFinanciero.ListarDS(oeContratoFinanciero)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeContratoFinanciero As e_ContratoFinanciero) As Boolean Implements Il_ContratoFinanciero.Validar
        Try
            With oeContratoFinanciero
                olFunGen.ValidarPeriodo(.IdPeriodo, gAreasSGI.Tesoreria, .FechaEmision, "")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeContratoFinanciero As e_ContratoFinanciero) As Boolean Implements Il_ContratoFinanciero.Eliminar
        Try
            Return odContratoFinanciero.Eliminar(oeContratoFinanciero)
        Catch ex As Exception
            Throw
        End Try
    End Function

#Region "Provision"

    Public Function Guardar(ByVal oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean Implements Il_ContratoFinanciero.Guardar
        Try
            Dim SumCapital As Double = 0
            Using TransScope As New TransactionScope()
                If Validar(oeContratoFinanciero) Then
                    If odContratoFinanciero.Guardar(oeContratoFinanciero) Then
                        SumCapital = oeContratoFinanciero.lstObligacionesFin.Sum(Function(it) it.MontoCapital)
                        oeAsiento = New e_Asiento
                        oeAsiento.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                        With oeAsiento
                            .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                            .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                            .Glosa = oeAsientoModel.Nombre & " " & oeContratoFinanciero.Codigo & " " & oeContratoFinanciero.NombreBanco
                            .GlosaImprime = String.Empty
                            .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                            .TotalDebe = SumCapital : .TotalHaber = SumCapital
                            .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                        End With
                        For Each oeAux In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila).ToList
                            If oeAux.Repetir = 0 Then
                                oeAsientoMov = New e_AsientoMovimiento
                                oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                With oeAsientoMov
                                    .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                    .IdCuentaContable = oeAux.IdCuentaContable
                                    If oeAux.Partida = 1 Then
                                        .DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", SumCapital, (SumCapital * oeContratoFinanciero.TipoCambio))
                                        .DebeME = IIf(oeAsientoModel.Moneda = "SOLES", (SumCapital / oeContratoFinanciero.TipoCambio), SumCapital)
                                    Else
                                        .HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", SumCapital, (SumCapital * oeContratoFinanciero.TipoCambio))
                                        .HaberME = IIf(oeAsientoModel.Moneda = "SOLES", (SumCapital / oeContratoFinanciero.TipoCambio), SumCapital)
                                    End If
                                    .IdUsuarioCrea = oeContratoFinanciero.Usuario : .Activo = True
                                End With
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            Else
                                For Each oeDet In oeContratoFinanciero.lstObligacionesFin
                                    If oeDet.MontoCapital > 0 Then
                                        oeAsientoMov = New e_AsientoMovimiento
                                        oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        With oeAsientoMov
                                            .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                            .IdCuentaContable = oeAux.IdCuentaContable
                                            If oeAux.Partida = 1 Then
                                                .DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", oeDet.MontoCapital, (oeDet.MontoCapital * oeContratoFinanciero.TipoCambio))
                                                .DebeME = IIf(oeAsientoModel.Moneda = "SOLES", (oeDet.MontoCapital / oeContratoFinanciero.TipoCambio), oeDet.MontoCapital)
                                            Else
                                                .HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", oeDet.MontoCapital, (oeDet.MontoCapital * oeContratoFinanciero.TipoCambio))
                                                .HaberME = IIf(oeAsientoModel.Moneda = "SOLES", (oeDet.MontoCapital / oeContratoFinanciero.TipoCambio), oeDet.MontoCapital)
                                            End If
                                            .IdUsuarioCrea = oeContratoFinanciero.Usuario : .Activo = True
                                            ' Generar Asiento Movimiento Obligacion
                                            oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                            oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                            oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                            oeAsiMovObli.IdObligacionFinanciera = oeDet.Id
                                            .AsMov_ObligacionFin = oeAsiMovObli
                                        End With
                                        oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                    End If
                                Next
                            End If
                        Next
                        If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                            TransScope.Complete()
                            Return True
                        End If
                    End If
                End If
            End Using

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarPagare(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean Implements Il_ContratoFinanciero.GuardarPagare
        Try
            Dim ComisioBan As Double = 0
            Using TransScope As New TransactionScope()
                If Validar(oeContratoFinanciero) Then
                    If odContratoFinanciero.Guardar(oeContratoFinanciero) Then
                        ComisioBan = oeContratoFinanciero.Comision
                        oeAsiento = New e_Asiento
                        oeAsiento.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                        With oeAsiento
                            .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                            .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                            .Glosa = oeAsientoModel.Nombre & " " & oeContratoFinanciero.Codigo & " " & oeContratoFinanciero.NombreBanco
                            .GlosaImprime = String.Empty
                            .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                            .TotalDebe = (oeContratoFinanciero.Capital + ComisioBan) : .TotalHaber = (oeContratoFinanciero.Capital + ComisioBan)
                            .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                        End With
                        For Each oeAux In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila).ToList
                            If oeAux.Repetir = 0 Then
                                Select Case Left(oeAux.Cuenta, 3)
                                    Case "104"
                                        oeAsientoMov = New e_AsientoMovimiento
                                        oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        With oeAsientoMov
                                            .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa : .IdCuentaContable = oeAux.IdCuentaContable
                                            If oeAux.Partida = 1 Then
                                                .DebeMN = oeContratoFinanciero.MontoMN : .DebeME = oeContratoFinanciero.MontoME
                                            Else
                                                .HaberMN = oeContratoFinanciero.MontoMN : .HaberME = oeContratoFinanciero.MontoME
                                            End If
                                            .IdUsuarioCrea = oeContratoFinanciero.Usuario : .Activo = True
                                            ' Generar Asiento Movimiento Caja y Banco
                                            oeMovCajaBanco = New e_MovimientoCajaBanco
                                            oeMovCajaBanco.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                            oeMovCajaBanco.TipoOperacion = "I" : oeMovCajaBanco.Activo = True
                                            oeMovCajaBanco.IdFlujoCaja = oeContratoFinanciero.oeMovCajaBanco.IdFlujoCaja
                                            oeMovCajaBanco.IdMedioPago = oeContratoFinanciero.oeMovCajaBanco.IdMedioPago
                                            oeMovCajaBanco.NroBoucher = oeContratoFinanciero.Codigo
                                            oeMovCajaBanco.UsuarioCreacion = oeContratoFinanciero.Usuario
                                            oeMovCajaBanco.IdCuentaBancaria = oeContratoFinanciero.oeMovCajaBanco.IdCuentaBancaria
                                            oeMovCajaBanco._Operador = 1 : oeMovCajaBanco.Fecha = oeContratoFinanciero.FechaEmision
                                            oeMovCajaBanco.TotalMN = oeContratoFinanciero.MontoMN
                                            oeMovCajaBanco.TotalME = oeContratoFinanciero.MontoME
                                            .MovimientoCajaBanco = oeMovCajaBanco
                                        End With
                                        oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                    Case "181"
                                        ''Case "639"
                                        If ComisioBan > 0 Then
                                            oeAsientoMov = New e_AsientoMovimiento
                                            oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                            With oeAsientoMov
                                                .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa : .IdCuentaContable = oeAux.IdCuentaContable
                                                If oeAux.Partida = 1 Then
                                                    .DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", ComisioBan, ComisioBan * oeContratoFinanciero.TipoCambio)
                                                    .DebeME = IIf(oeAsientoModel.Moneda = "SOLES", ComisioBan / oeContratoFinanciero.TipoCambio, ComisioBan)
                                                Else
                                                    .HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", ComisioBan, ComisioBan * oeContratoFinanciero.TipoCambio)
                                                    .HaberME = IIf(oeAsientoModel.Moneda = "SOLES", ComisioBan / oeContratoFinanciero.TipoCambio, ComisioBan)
                                                End If
                                                .IdUsuarioCrea = oeContratoFinanciero.Usuario : .Activo = True
                                            End With
                                            'Generar Movimiento Analisis
                                            oeMovAnalisis = New e_MovimientoAnalisis
                                            oeMovAnalisis.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                            oeMovAnalisis.TipoOperacion = "I"
                                            oeMovAnalisis.IdVehiculo = "1SI000000059"
                                            oeMovAnalisis.IdGastoFuncion = "1CH000088"
                                            oeMovAnalisis.IdItemGasto = "1CH000125"
                                            oeMovAnalisis.IdCentroCosto = "1CH000000007"
                                            oeMovAnalisis.Monto = ComisioBan
                                            oeMovAnalisis.Saldo = ComisioBan
                                            oeMovAnalisis.Activo = True
                                            oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                            oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                        End If
                                End Select
                            Else
                                For Each oeDet In oeContratoFinanciero.lstObligacionesFin
                                    Dim MontoObli As Double = 0
                                    MontoObli = oeDet.MontoCapital + oeDet.Comision
                                    If oeDet.MontoCapital > 0 Then
                                        oeAsientoMov = New e_AsientoMovimiento
                                        oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        With oeAsientoMov
                                            .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                            .IdCuentaContable = oeAux.IdCuentaContable
                                            If oeAux.Partida = 1 Then
                                                .DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", MontoObli, (MontoObli * oeContratoFinanciero.TipoCambio))
                                                .DebeME = IIf(oeAsientoModel.Moneda = "SOLES", (MontoObli / oeContratoFinanciero.TipoCambio), MontoObli)
                                            Else
                                                .HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", MontoObli, (MontoObli * oeContratoFinanciero.TipoCambio))
                                                .HaberME = IIf(oeAsientoModel.Moneda = "SOLES", (MontoObli / oeContratoFinanciero.TipoCambio), MontoObli)
                                            End If
                                            .IdUsuarioCrea = oeContratoFinanciero.Usuario : .Activo = True
                                            ' Generar Asiento Movimiento Obligacion
                                            oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                            oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                            oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                            oeAsiMovObli.IdObligacionFinanciera = oeDet.Id
                                            .AsMov_ObligacionFin = oeAsiMovObli
                                        End With
                                        oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                    End If
                                Next
                            End If
                        Next
                        If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                            TransScope.Complete()
                            Return True
                        End If
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLetra(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo, ln_TasaRetencion As Double) As Boolean Implements Il_ContratoFinanciero.GuardarLetra
        Try
            Dim _MontoMN As Double = 0, _MontoME As Double = 0
            Dim _idOblFin As String
            Using TransScope As New TransactionScope()
                If Validar(oeContratoFinanciero) Then
                    If odContratoFinanciero.Guardar(oeContratoFinanciero) Then
                        oeAsiento = New e_Asiento
                        With oeAsiento
                            .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                            .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                            .Glosa = oeAsientoModel.Nombre & " " & oeContratoFinanciero.Codigo & " " & oeContratoFinanciero.NombreBanco
                            .GlosaImprime = String.Empty
                            .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                            .TotalDebe = oeContratoFinanciero.Capital : .TotalHaber = oeContratoFinanciero.Capital
                            .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                        End With
                        For Each oeAux In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila).ToList
                            If oeAux.Repetir = 0 Then
                                For Each oeDoc In oeContratoFinanciero.leDocLetra
                                    _MontoMN = 0 : _MontoME = 0 : _idOblFin = String.Empty
                                    _MontoMN = IIf(oeAsientoModel.Moneda = "SOLES", oeDoc.Total, (oeDoc.Total * oeContratoFinanciero.TipoCambio))
                                    _MontoME = IIf(oeAsientoModel.Moneda = "SOLES", (oeDoc.Total / oeContratoFinanciero.TipoCambio), oeDoc.Total)
                                    _idOblFin = oeContratoFinanciero.lstObligacionesFin.Where(Function(it) it.NroVencimiento = oeDoc.NombreMaterialServicio).ToList(0).Id
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                    oeAsientoMov.Glosa = oeAux.Titulo & " " & oeDoc.UnidadMedida & " LETRA " & oeDoc.NombreMaterialServicio
                                    oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                    If oeAux.Partida = 1 Then
                                        oeAsientoMov.DebeMN = _MontoMN : oeAsientoMov.DebeME = _MontoME
                                    Else
                                        oeAsientoMov.HaberMN = _MontoMN : oeAsientoMov.HaberME = _MontoME
                                    End If
                                    ' Generar Cuenta por Cobrar y Pagar
                                    oeAsientoMov.oeCuentaCP = New e_CuentaxCyP
                                    oeAsientoMov.oeCuentaCP.TipoOperacion = "I"
                                    oeAsientoMov.oeCuentaCP.Fecha = oeContratoFinanciero.FechaEmision
                                    oeAsientoMov.oeCuentaCP.IdMovimientoDocumento = oeDoc.IdMovimientoDocumento
                                    oeAsientoMov.oeCuentaCP.MontoMN = _MontoMN
                                    oeAsientoMov.oeCuentaCP.MontoMe = _MontoME
                                    oeAsientoMov.oeCuentaCP.MacPCLocalCreacion = oeContratoFinanciero.MacLocal
                                    oeAsientoMov.oeCuentaCP.UsuarioCreacion = oeContratoFinanciero.Usuario
                                    oeAsientoMov.oeCuentaCP.Activo = True
                                    ' Generar Obligacion Documento
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento = New e_ObligacionDocumento
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.TipoOperacion = "I"
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.IdMovimientoDocumento = oeDoc.IdMovimientoDocumento
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.MontoMN = _MontoMN
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.MontoME = _MontoME
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.IdObligacionFinanciera = _idOblFin
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.IdCuentaxCyP = String.Empty
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.UsuarioCreacion = oeContratoFinanciero.Usuario
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.Activo = True

                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.RetencionMN = Math.Round(IIf(oeContratoFinanciero.lstObligacionesFin.Item(0).RetencionMN > 0.0, (_MontoMN / (1 - ln_TasaRetencion)) * ln_TasaRetencion, 0.0), 2)
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.RetencionME = Math.Round(IIf(oeContratoFinanciero.lstObligacionesFin.Item(0).RetencionME > 0.0, (_MontoME / (1 - ln_TasaRetencion)) * ln_TasaRetencion, 0.0), 2)
                                    ' Generar Asiento Movimiento Documento
                                    oeAsientoMov.oeCuentaCP.AsMov_MovDoc = New e_AsientoMov_MovDoc
                                    oeAsientoMov.oeCuentaCP.AsMov_MovDoc.TipoOperacion = "I"
                                    oeAsientoMov.oeCuentaCP.AsMov_MovDoc.IdMovimientoDocumento = oeDoc.IdMovimientoDocumento
                                    oeAsientoMov.oeCuentaCP.AsMov_MovDoc.IdCuentaxCyP = String.Empty
                                    oeAsientoMov.oeCuentaCP.AsMov_MovDoc.Activo = True
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Next
                            Else
                                For Each oeObl In oeContratoFinanciero.lstObligacionesFin
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                    oeAsientoMov.Glosa = oeAux.Titulo & " " & oeObl.NroVencimiento
                                    oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                    If oeAux.Partida = 1 Then
                                        oeAsientoMov.DebeMN = oeObl.MontoMN : oeAsientoMov.DebeME = oeObl.MontoME
                                    Else
                                        oeAsientoMov.HaberMN = oeObl.MontoMN : oeAsientoMov.HaberME = oeObl.MontoME
                                    End If
                                    ' Generar Asiento Movimiento Obligacion
                                    oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                    oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                    oeAsiMovObli.IdObligacionFinanciera = oeObl.Id
                                    oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Next
                            End If
                        Next
                        If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                            odMovDoc.ActualizarSaldoDoc(oeContratoFinanciero.leDocumentos)
                            TransScope.Complete()
                            Return True
                        End If
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarFec(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean Implements Il_ContratoFinanciero.GuardarFec
        Try
            Dim _MontoMN As Double = 0, _MontoME As Double = 0
            Using TransScope As New TransactionScope()
                If Validar(oeContratoFinanciero) Then
                    If odContratoFinanciero.Guardar(oeContratoFinanciero) Then
                        oeAsiento = New e_Asiento
                        With oeAsiento
                            .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                            .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                            .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                            .Glosa = oeAsientoModel.Nombre & " " & oeContratoFinanciero.Codigo & " " & oeContratoFinanciero.NombreBanco
                            .GlosaImprime = String.Empty
                            .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                            .TotalDebe = oeContratoFinanciero.Capital : .TotalHaber = oeContratoFinanciero.Capital
                            .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                        End With
                        For Each oeAux In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila).ToList
                            If oeAux.Repetir = 0 Then
                                oeAsientoMov = New e_AsientoMovimiento
                                oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                oeAsientoMov.Glosa = oeAux.Titulo & " " & oeContratoFinanciero.lstObligacionesFin(0).NroVencimiento
                                oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                If oeAux.Partida = 1 Then
                                    oeAsientoMov.DebeMN = oeContratoFinanciero.lstObligacionesFin(0).MontoMN
                                    oeAsientoMov.DebeME = oeContratoFinanciero.lstObligacionesFin(0).MontoME
                                Else
                                    oeAsientoMov.HaberMN = oeContratoFinanciero.lstObligacionesFin(0).MontoMN
                                    oeAsientoMov.HaberME = oeContratoFinanciero.lstObligacionesFin(0).MontoME
                                End If
                                ' Generar Asiento Movimiento Obligacion
                                oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                oeAsiMovObli.IdObligacionFinanciera = oeContratoFinanciero.lstObligacionesFin(0).Id
                                oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            Else
                                For Each oeDoc In oeContratoFinanciero.leDocumentos
                                    _MontoMN = 0 : _MontoME = 0
                                    _MontoMN = IIf(oeAsientoModel.Moneda = "SOLES", oeDoc.MontoOperar, (oeDoc.MontoOperar * oeContratoFinanciero.TipoCambio))
                                    _MontoME = IIf(oeAsientoModel.Moneda = "SOLES", (oeDoc.MontoOperar / oeContratoFinanciero.TipoCambio), oeDoc.MontoOperar)
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                    oeAsientoMov.Glosa = oeAux.Titulo & " " & oeDoc.Serie & "-" & oeDoc.Numero
                                    oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                    If oeAux.Partida = 1 Then
                                        oeAsientoMov.DebeMN = _MontoMN : oeAsientoMov.DebeME = _MontoME
                                    Else
                                        oeAsientoMov.HaberMN = _MontoMN : oeAsientoMov.HaberME = _MontoME
                                    End If
                                    ' Generar Cuenta por Cobrar y Pagar
                                    oeAsientoMov.oeCuentaCP = New e_CuentaxCyP
                                    oeAsientoMov.oeCuentaCP.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeAsientoMov.oeCuentaCP.TipoOperacion = "I"
                                    oeAsientoMov.oeCuentaCP.Fecha = oeContratoFinanciero.FechaEmision
                                    oeAsientoMov.oeCuentaCP.IdMovimientoDocumento = oeDoc.Id
                                    oeAsientoMov.oeCuentaCP.MontoMN = _MontoMN
                                    oeAsientoMov.oeCuentaCP.MontoMe = _MontoME
                                    oeAsientoMov.oeCuentaCP.MacPCLocalCreacion = oeContratoFinanciero.MacLocal
                                    oeAsientoMov.oeCuentaCP.UsuarioCreacion = oeContratoFinanciero.Usuario
                                    oeAsientoMov.oeCuentaCP.Activo = True
                                    ' Generar Obligacion Documento
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento = New e_ObligacionDocumento
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.TipoOperacion = "I"
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.IdMovimientoDocumento = oeDoc.Id
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.MontoMN = _MontoMN
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.MontoME = _MontoME
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.IdObligacionFinanciera = oeContratoFinanciero.lstObligacionesFin(0).Id
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.IdCuentaxCyP = String.Empty
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.UsuarioCreacion = oeContratoFinanciero.Usuario
                                    oeAsientoMov.oeCuentaCP.ObligacionDocumento.Activo = True
                                    ' Generar Asiento Movimiento Documento
                                    oeAsientoMov.oeCuentaCP.AsMov_MovDoc = New e_AsientoMov_MovDoc
                                    oeAsientoMov.oeCuentaCP.AsMov_MovDoc.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeAsientoMov.oeCuentaCP.AsMov_MovDoc.TipoOperacion = "I"
                                    oeAsientoMov.oeCuentaCP.AsMov_MovDoc.IdMovimientoDocumento = oeDoc.Id
                                    oeAsientoMov.oeCuentaCP.AsMov_MovDoc.IdCuentaxCyP = String.Empty
                                    oeAsientoMov.oeCuentaCP.AsMov_MovDoc.Activo = True
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Next
                            End If
                        Next
                        If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                            odMovDoc.ActualizarSaldoDoc(oeContratoFinanciero.leDocumentos)
                            TransScope.Complete()
                            Return True
                        End If
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarFedd(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean Implements Il_ContratoFinanciero.GuardarFedd
        Try
            Dim _MontoGen As Double = 0, _MontoCap As Double = 0, _MontoInteres As Double = 0
            Using TransScope As New TransactionScope()
                If Validar(oeContratoFinanciero) Then
                    If odContratoFinanciero.Guardar(oeContratoFinanciero) Then
                        _MontoInteres = oeContratoFinanciero.lstObligacionesFin(0).MontoInteres
                        _MontoCap = oeContratoFinanciero.Capital
                        _MontoGen = _MontoCap + _MontoInteres
                        oeAsiento = New e_Asiento
                        With oeAsiento
                            .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                            .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                            .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                            .Glosa = oeAsientoModel.Nombre & " " & oeContratoFinanciero.Codigo & " " & oeContratoFinanciero.NombreBanco
                            .GlosaImprime = String.Empty
                            .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                            .TotalDebe = _MontoGen : .TotalHaber = _MontoGen
                            .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                        End With
                        For Each oeAux In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila).ToList
                            oeAsientoMov = New e_AsientoMovimiento
                            With oeAsientoMov
                                .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                .TipoOperacion = "I" : .IdCuentaContable = oeAux.IdCuentaContable
                                .IdUsuarioCrea = oeContratoFinanciero.Usuario : .Activo = True
                                Select Case Left(oeAux.Cuenta, 2)
                                    Case "10"
                                        .Glosa = oeAux.Titulo
                                        If oeAux.Partida = 1 Then
                                            .DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap, _MontoCap * oeContratoFinanciero.TipoCambio)
                                            .DebeME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap / oeContratoFinanciero.TipoCambio, _MontoCap)
                                        Else
                                            .HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap, _MontoCap * oeContratoFinanciero.TipoCambio)
                                            .HaberME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap / oeContratoFinanciero.TipoCambio, _MontoCap)
                                        End If
                                        ' Generar Asiento Movimiento Caja y Banco
                                        oeMovCajaBanco = New e_MovimientoCajaBanco
                                        oeMovCajaBanco.TipoOperacion = "I" : oeMovCajaBanco.Activo = True
                                        oeMovCajaBanco.IdFlujoCaja = oeContratoFinanciero.oeMovCajaBanco.IdFlujoCaja
                                        oeMovCajaBanco.IdMedioPago = oeContratoFinanciero.oeMovCajaBanco.IdMedioPago
                                        oeMovCajaBanco.NroBoucher = oeContratoFinanciero.Codigo
                                        oeMovCajaBanco.UsuarioCreacion = oeContratoFinanciero.Usuario
                                        oeMovCajaBanco.IdCuentaBancaria = oeContratoFinanciero.oeMovCajaBanco.IdCuentaBancaria
                                        oeMovCajaBanco._Operador = 1 : oeMovCajaBanco.Fecha = oeContratoFinanciero.FechaEmision
                                        oeMovCajaBanco.TotalMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap, _MontoCap * oeContratoFinanciero.TipoCambio)
                                        oeMovCajaBanco.TotalME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap / oeContratoFinanciero.TipoCambio, _MontoCap)
                                        oeMovCajaBanco.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        .MovimientoCajaBanco = oeMovCajaBanco
                                    Case "18"
                                        .Glosa = oeAux.Titulo
                                        If oeAux.Partida = 1 Then
                                            .DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoInteres, _MontoInteres * oeContratoFinanciero.TipoCambio)
                                            .DebeME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoInteres / oeContratoFinanciero.TipoCambio, _MontoInteres)
                                        Else
                                            .HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoInteres, _MontoInteres * oeContratoFinanciero.TipoCambio)
                                            .HaberME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoInteres / oeContratoFinanciero.TipoCambio, _MontoInteres)
                                        End If
                                    Case "45"
                                        .Glosa = oeAux.Titulo & " " & oeContratoFinanciero.lstObligacionesFin(0).NroVencimiento
                                        If oeAux.Partida = 1 Then
                                            .DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoGen, _MontoGen * oeContratoFinanciero.TipoCambio)
                                            .DebeME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoGen / oeContratoFinanciero.TipoCambio, _MontoGen)
                                        Else
                                            .HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoGen, _MontoGen * oeContratoFinanciero.TipoCambio)
                                            .HaberME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoGen / oeContratoFinanciero.TipoCambio, _MontoGen)
                                        End If
                                        ' Generar Asiento Movimiento Obligacion
                                        oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                        oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                        oeAsiMovObli.IdObligacionFinanciera = oeContratoFinanciero.lstObligacionesFin(0).Id
                                        oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        .AsMov_ObligacionFin = oeAsiMovObli
                                End Select
                            End With
                            oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                            oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                        Next
                        oeAsiento.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                        If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                            TransScope.Complete()
                            Return True
                        End If
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarFactDesc(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModel As List(Of e_AsientoModelo)) As Boolean Implements Il_ContratoFinanciero.GuardarFactDesc
        Try
            Dim _MontoCap As Double = 0, _MontoInteres As Double = 0
            Dim leAsiento As New List(Of e_Asiento)
            Using TransScope As New TransactionScope()
                If Validar(oeContratoFinanciero) Then
                    If odContratoFinanciero.Guardar(oeContratoFinanciero) Then
                        _MontoCap = oeContratoFinanciero.Capital
                        With oeContratoFinanciero.lstObligacionesFin(0)
                            _MontoInteres = .MontoInteres + .Comision + .Gastos
                        End With
                        For Each oeAsiMod In leAsientoModel
                            oeAsiento = New e_Asiento
                            With oeAsiento
                                .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsiMod.IdTipoAsiento
                                .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                                .Glosa = oeAsiMod.Nombre : .GlosaImprime = String.Empty
                                .IdMoneda = oeAsiMod.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                                .TotalDebe = IIf(oeAsiMod.IdVinculado.Trim.Length > 0, _MontoCap, _MontoInteres)
                                .TotalHaber = IIf(oeAsiMod.IdVinculado.Trim.Length > 0, _MontoCap, _MontoInteres)
                                .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                            End With
                            For Each oeAux In oeAsiMod.leDetalle.OrderBy(Function(it) it.Fila).ToList
                                oeAsientoMov = New e_AsientoMovimiento
                                With oeAsientoMov
                                    .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    .TipoOperacion = "I" : .IdCuentaContable = oeAux.IdCuentaContable
                                    .IdUsuarioCrea = oeContratoFinanciero.Usuario : .Activo = True
                                    Select Case Left(oeAux.Cuenta, 2)
                                        Case "10"
                                            Dim _montoaux = IIf(oeAsiMod.IdVinculado.Trim.Length > 0, _MontoCap, _MontoInteres)
                                            .Glosa = oeAux.Titulo
                                            If oeAux.Partida = 1 Then
                                                .DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _montoaux, _montoaux * oeContratoFinanciero.TipoCambio)
                                                .DebeME = IIf(oeAsiMod.Moneda = "SOLES", _montoaux / oeContratoFinanciero.TipoCambio, _montoaux)
                                            Else
                                                .HaberMN = IIf(oeAsiMod.Moneda = "SOLES", _montoaux, _montoaux * oeContratoFinanciero.TipoCambio)
                                                .HaberME = IIf(oeAsiMod.Moneda = "SOLES", _MontoCap / oeContratoFinanciero.TipoCambio, _montoaux)
                                            End If
                                            ' Generar Asiento Movimiento Caja y Banco
                                            oeMovCajaBanco = New e_MovimientoCajaBanco
                                            oeMovCajaBanco.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                            oeMovCajaBanco.TipoOperacion = "I" : oeMovCajaBanco.Activo = True
                                            oeMovCajaBanco.IdFlujoCaja = oeContratoFinanciero.oeMovCajaBanco.IdFlujoCaja
                                            oeMovCajaBanco.IdMedioPago = oeContratoFinanciero.oeMovCajaBanco.IdMedioPago
                                            oeMovCajaBanco.NroBoucher = oeContratoFinanciero.Codigo
                                            oeMovCajaBanco.UsuarioCreacion = oeContratoFinanciero.Usuario
                                            oeMovCajaBanco.IdCuentaBancaria = oeContratoFinanciero.oeMovCajaBanco.IdCuentaBancaria
                                            oeMovCajaBanco._Operador = IIf(oeAsiMod.IdVinculado.Trim.Length > 0, 1, -1)
                                            oeMovCajaBanco.Fecha = oeContratoFinanciero.FechaEmision
                                            oeMovCajaBanco.TotalMN = IIf(oeAsiMod.Moneda = "SOLES", _montoaux, _montoaux * oeContratoFinanciero.TipoCambio)
                                            oeMovCajaBanco.TotalME = IIf(oeAsiMod.Moneda = "SOLES", _montoaux / oeContratoFinanciero.TipoCambio, _montoaux)
                                            .MovimientoCajaBanco = oeMovCajaBanco
                                        Case "18"
                                            .Glosa = oeAux.Titulo
                                            If oeAux.Partida = 1 Then
                                                .DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoInteres, _MontoInteres * oeContratoFinanciero.TipoCambio)
                                                .DebeME = IIf(oeAsiMod.Moneda = "SOLES", _MontoInteres / oeContratoFinanciero.TipoCambio, _MontoInteres)
                                            Else
                                                .HaberMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoInteres, _MontoInteres * oeContratoFinanciero.TipoCambio)
                                                .HaberME = IIf(oeAsiMod.Moneda = "SOLES", _MontoInteres / oeContratoFinanciero.TipoCambio, _MontoInteres)
                                            End If
                                        Case "45"
                                            .Glosa = oeAux.Titulo & " " & oeContratoFinanciero.lstObligacionesFin(0).NroVencimiento
                                            If oeAux.Partida = 1 Then
                                                .DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoCap, _MontoCap * oeContratoFinanciero.TipoCambio)
                                                .DebeME = IIf(oeAsiMod.Moneda = "SOLES", _MontoCap / oeContratoFinanciero.TipoCambio, _MontoCap)
                                            Else
                                                .HaberMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoCap, _MontoCap * oeContratoFinanciero.TipoCambio)
                                                .HaberME = IIf(oeAsiMod.Moneda = "SOLES", _MontoCap / oeContratoFinanciero.TipoCambio, _MontoCap)
                                            End If
                                            ' Generar Asiento Movimiento Obligacion
                                            oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                            oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                            oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                            oeAsiMovObli.IdObligacionFinanciera = oeContratoFinanciero.lstObligacionesFin(0).Id
                                            .AsMov_ObligacionFin = oeAsiMovObli
                                    End Select
                                End With
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            Next
                            leAsiento.Add(oeAsiento)
                        Next
                        If olAsiento.GuardarLista(leAsiento) Then
                            TransScope.Complete()
                            Return True
                        End If
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarCreditoHipotecario(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean Implements Il_ContratoFinanciero.GuardarCreditoHipotecario
        Try
            Dim _MontoGen As Double = 0, _MontoCap As Double = 0, _MontoInteres As Double = 0
            Using TransScope As New TransactionScope()
                If Validar(oeContratoFinanciero) Then
                    If odContratoFinanciero.Guardar(oeContratoFinanciero) Then
                        '_MontoInteres = oeContratoFinanciero.lstObligacionesFin.Sum(Function(it) it.MontoInteres)
                        _MontoInteres = oeContratoFinanciero.Comision
                        _MontoCap = oeContratoFinanciero.Capital
                        _MontoGen = _MontoCap + _MontoInteres
                        oeAsiento = New e_Asiento
                        With oeAsiento
                            .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                            .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                            .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                            .Glosa = oeAsientoModel.Nombre & " " & oeContratoFinanciero.Codigo & " " & oeContratoFinanciero.NombreBanco
                            .GlosaImprime = String.Empty
                            .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                            .TotalDebe = _MontoGen : .TotalHaber = _MontoGen
                            .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                        End With
                        For Each oeAux In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila).ToList
                            If oeAux.Repetir = 0 Then
                                oeAsientoMov = New e_AsientoMovimiento
                                With oeAsientoMov
                                    .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    .TipoOperacion = "I" : .IdCuentaContable = oeAux.IdCuentaContable
                                    .Glosa = oeAsientoModel.Nombre & " " & oeContratoFinanciero.Codigo & " " & oeContratoFinanciero.NombreBanco
                                    .IdUsuarioCrea = oeContratoFinanciero.Usuario : .Activo = True
                                    Select Case Left(oeAux.Cuenta, 2)
                                        Case "10"
                                            If oeAux.Partida = 1 Then
                                                .DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap, _MontoCap * oeContratoFinanciero.TipoCambio)
                                                .DebeME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap / oeContratoFinanciero.TipoCambio, _MontoCap)
                                            Else
                                                .HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap, _MontoCap * oeContratoFinanciero.TipoCambio)
                                                .HaberME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap / oeContratoFinanciero.TipoCambio, _MontoCap)
                                            End If
                                            ' Generar Asiento Movimiento Caja y Banco
                                            oeMovCajaBanco = New e_MovimientoCajaBanco
                                            oeMovCajaBanco.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                            oeMovCajaBanco.TipoOperacion = "I" : oeMovCajaBanco.Activo = True
                                            oeMovCajaBanco.IdFlujoCaja = oeContratoFinanciero.oeMovCajaBanco.IdFlujoCaja
                                            oeMovCajaBanco.IdMedioPago = oeContratoFinanciero.oeMovCajaBanco.IdMedioPago
                                            oeMovCajaBanco.NroBoucher = oeContratoFinanciero.Codigo
                                            oeMovCajaBanco.UsuarioCreacion = oeContratoFinanciero.Usuario
                                            oeMovCajaBanco.IdCuentaBancaria = oeContratoFinanciero.oeMovCajaBanco.IdCuentaBancaria
                                            oeMovCajaBanco._Operador = 1 : oeMovCajaBanco.Fecha = oeContratoFinanciero.FechaEmision
                                            oeMovCajaBanco.TotalMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap, _MontoCap * oeContratoFinanciero.TipoCambio)
                                            oeMovCajaBanco.TotalME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoCap / oeContratoFinanciero.TipoCambio, _MontoCap)
                                            .MovimientoCajaBanco = oeMovCajaBanco
                                        Case "63"
                                            If oeAux.Partida = 1 Then
                                                .DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoInteres, _MontoInteres * oeContratoFinanciero.TipoCambio)
                                                .DebeME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoInteres / oeContratoFinanciero.TipoCambio, _MontoInteres)
                                            Else
                                                .HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", _MontoInteres, _MontoInteres * oeContratoFinanciero.TipoCambio)
                                                .HaberME = IIf(oeAsientoModel.Moneda = "SOLES", _MontoInteres / oeContratoFinanciero.TipoCambio, _MontoInteres)
                                            End If
                                            'Generar Movimiento Analisis
                                            oeMovAnalisis = New e_MovimientoAnalisis
                                            oeMovAnalisis.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                            oeMovAnalisis.TipoOperacion = "I"
                                            oeMovAnalisis.IdVehiculo = "1SI000000059"
                                            oeMovAnalisis.IdGastoFuncion = "1CH000088"
                                            oeMovAnalisis.IdItemGasto = "1CH000125"
                                            oeMovAnalisis.IdCentroCosto = "1CH000000007"
                                            'oeMovAnalisis.IdBanco = oeContratoFinanciero.IdEmpresaBanco
                                            oeMovAnalisis.Monto = _MontoInteres
                                            oeMovAnalisis.Saldo = _MontoInteres
                                            oeMovAnalisis.Activo = True
                                            .MovimientoAnalisis.Add(oeMovAnalisis)
                                    End Select
                                End With
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            Else
                                For Each oeObliFin In oeContratoFinanciero.lstObligacionesFin
                                    oeAsientoMov = New e_AsientoMovimiento
                                    With oeAsientoMov
                                        .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        .TipoOperacion = "I" : .IdCuentaContable = oeAux.IdCuentaContable
                                        .Glosa = oeAsientoModel.Nombre & " " & oeObliFin.NroVencimiento & " " & oeContratoFinanciero.NombreBanco
                                        .IdUsuarioCrea = oeContratoFinanciero.Usuario : .Activo = True
                                        If oeAux.Partida = 1 Then
                                            .DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", oeObliFin.MontoCapital, oeObliFin.MontoCapital * oeContratoFinanciero.TipoCambio)
                                            .DebeME = IIf(oeAsientoModel.Moneda = "SOLES", oeObliFin.MontoCapital / oeContratoFinanciero.TipoCambio, oeObliFin.MontoCapital)
                                        Else
                                            .HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", oeObliFin.MontoCapital, oeObliFin.MontoCapital * oeContratoFinanciero.TipoCambio)
                                            .HaberME = IIf(oeAsientoModel.Moneda = "SOLES", oeObliFin.MontoCapital / oeContratoFinanciero.TipoCambio, oeObliFin.MontoCapital)
                                        End If
                                        ' Generar Asiento Movimiento Obligacion
                                        oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                        oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                        oeAsiMovObli.IdObligacionFinanciera = oeObliFin.Id
                                        oeAsiMovObli.UsuarioCreacion = oeContratoFinanciero.Usuario
                                        .AsMov_ObligacionFin = oeAsiMovObli
                                    End With
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Next
                            End If
                        Next
                        Dim leAsiento As New List(Of e_Asiento)
                        leAsiento.Add(oeAsiento)
                        'If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                        If olAsiento.GuardarListaMasiva2(leAsiento, oeContratoFinanciero.PrefijoID) Then
                            TransScope.Complete()
                            Return True
                        End If
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarGastoFin(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean Implements Il_ContratoFinanciero.GuardarGastoFin
        Try
            oeAsiento = New e_Asiento
            With oeAsiento
                .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                .Glosa = oeContratoFinanciero.NombreBanco : .GlosaImprime = String.Empty
                .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                .TotalDebe = oeContratoFinanciero.Capital : .TotalHaber = oeContratoFinanciero.Capital
                .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
            End With
            For Each oeAux In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila).ToList
                oeAsientoMov = New e_AsientoMovimiento
                With oeAsientoMov
                    .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                    .TipoOperacion = "I" : .IdUsuarioCrea = oeContratoFinanciero.Usuario
                    .Glosa = oeAux.Titulo : .Activo = True
                    If oeAux.Partida = 1 Then
                        .DebeMN = oeContratoFinanciero.MontoMN : .DebeME = oeContratoFinanciero.MontoME
                    Else
                        .HaberMN = oeContratoFinanciero.MontoMN : .HaberME = oeContratoFinanciero.MontoME
                    End If
                    Select Case Left(oeAux.Cuenta, 1)
                        Case "1"
                            .IdCuentaContable = oeAux.IdCuentaContable
                            ' Generar Asiento Movimiento Caja y Banco
                            oeMovCajaBanco = New e_MovimientoCajaBanco
                            oeMovCajaBanco.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                            oeMovCajaBanco.TipoOperacion = "I" : oeMovCajaBanco.Activo = True
                            oeMovCajaBanco.IdFlujoCaja = oeContratoFinanciero.oeMovCajaBanco.IdFlujoCaja
                            oeMovCajaBanco.IdMedioPago = oeContratoFinanciero.oeMovCajaBanco.IdMedioPago
                            oeMovCajaBanco.NroBoucher = oeContratoFinanciero.oeMovCajaBanco.NroBoucher
                            oeMovCajaBanco.UsuarioCreacion = oeContratoFinanciero.Usuario
                            oeMovCajaBanco.IdCuentaBancaria = oeContratoFinanciero.oeMovCajaBanco.IdCuentaBancaria
                            oeMovCajaBanco._Operador = -1
                            oeMovCajaBanco.Fecha = oeContratoFinanciero.FechaEmision
                            oeMovCajaBanco.TotalMN = oeContratoFinanciero.oeMovCajaBanco.TotalMN
                            oeMovCajaBanco.TotalME = oeContratoFinanciero.oeMovCajaBanco.TotalME
                            .MovimientoCajaBanco = oeMovCajaBanco
                        Case "6"
                            .IdCuentaContable = oeContratoFinanciero.Codigo
                            'Generar Movimiento Analisis
                            oeMovAnalisis = New e_MovimientoAnalisis
                            oeMovAnalisis.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                            oeMovAnalisis.TipoOperacion = "I"
                            oeMovAnalisis.IdVehiculo = String.Empty
                            oeMovAnalisis.IdGastoFuncion = oeContratoFinanciero.IdClienteProveedor ' Cargar Gasto Funcion
                            oeMovAnalisis.IdItemGasto = oeContratoFinanciero.IdTipoDocumento ' Cargar Item Gasto
                            If oeMovAnalisis.IdItemGasto.Trim.Length = 0 Then oeMovAnalisis.IdCentroCosto = "1CH000000007"
                            oeMovAnalisis.Monto = oeContratoFinanciero.Capital
                            oeMovAnalisis.Saldo = oeContratoFinanciero.Capital
                            oeMovAnalisis.Activo = True
                            .MovimientoAnalisis.Add(oeMovAnalisis)
                    End Select
                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                End With
            Next
            Return olAsiento.GuardarAsientoDscto(oeAsiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Intereses"

    Public Function GuardarInteresMensualLeasing(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean Implements Il_ContratoFinanciero.GuardarInteresMensualLeasing
        Try
            Dim _MontoGen As Double = 0, _tc As Double = 0
            olFunGen.ValidarPeriodo(oeContratoFinanciero.IdPeriodo, gAreasSGI.Contabilidad, oeContratoFinanciero.FechaEmision, "")
            leAsiento = New List(Of e_Asiento)
            Using TransScope As New TransactionScope()
                If odObliFin.GuardarLista(oeContratoFinanciero.lstObligacionesFin) Then
                    _tc = oeContratoFinanciero.TipoCambio
                    For Each oeAsiMod In leAsientoModelo
                        leObliFinAux = oeContratoFinanciero.lstObligacionesFin.Where(Function(it) it.IdMoneda = oeAsiMod.Moneda).ToList
                        If leObliFinAux.Count > 0 Then
                            _MontoGen = leObliFinAux.Sum(Function(it) it.MontoInteresContable)
                            oeAsiento = New e_Asiento
                            With oeAsiento
                                .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsiMod.IdTipoAsiento
                                .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                                .Glosa = oeAsiMod.Nombre : .GlosaImprime = String.Empty
                                .IdMoneda = oeAsiMod.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                                .TotalDebe = _MontoGen : .TotalHaber = _MontoGen : .IdentificaAsiento = "LEASING" & oeAsiMod.Moneda
                                .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                            End With
                            For Each oeAux In oeAsiMod.leDetalle.OrderBy(Function(it) it.Fila).ToList
                                If oeAux.Repetir = 0 Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                    oeAsientoMov.Glosa = oeAsiMod.Nombre
                                    oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                    If oeAux.Partida = 1 Then
                                        oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                        oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                                    Else
                                        oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                        oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                                    End If
                                    oeMovAnalisis = New e_MovimientoAnalisis
                                    oeMovAnalisis.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeMovAnalisis.TipoOperacion = "I" : oeMovAnalisis.Activo = True
                                    oeMovAnalisis.IdGastoFuncion = "1CH000090"
                                    oeMovAnalisis.Monto = _MontoGen
                                    oeMovAnalisis.Saldo = _MontoGen
                                    oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Else
                                    For Each oeOAAux In leObliFinAux
                                        If oeOAAux.MontoInteresContable > 0 Then
                                            oeAsientoMov = New e_AsientoMovimiento
                                            oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                            oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                            oeAsientoMov.Glosa = oeAsiMod.Nombre & " " & oeOAAux.NroContrato & "-" & oeOAAux.NroVencimiento & " " & oeOAAux.Banco
                                            oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                            If oeAux.Partida = 1 Then
                                                oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                                oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                            Else
                                                oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                                oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                            End If
                                            ' Generar Asiento Movimiento Obligacion
                                            oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                            oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                            oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                            oeAsiMovObli.IdObligacionFinanciera = oeOAAux.Id
                                            oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                            oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                        End If
                                    Next
                                End If
                            Next
                            leAsiento.Add(oeAsiento)
                        End If
                    Next
                    If olAsiento.GuardarLista(leAsiento) Then
                        TransScope.Complete()
                        Return True
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarInteresMensualFec(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean Implements Il_ContratoFinanciero.GuardarInteresMensualFec
        Try
            Dim _MontoGen As Double = 0, _tc As Double = 0
            olFunGen.ValidarPeriodo(oeContratoFinanciero.IdPeriodo, gAreasSGI.Contabilidad, oeContratoFinanciero.FechaEmision, "")
            leAsiento = New List(Of e_Asiento)
            Using TransScope As New TransactionScope()
                If odObliFin.GuardarLista(oeContratoFinanciero.lstObligacionesFin) Then
                    _tc = oeContratoFinanciero.TipoCambio
                    For Each oeAsiMod In leAsientoModelo
                        leObliFinAux = oeContratoFinanciero.lstObligacionesFin.Where(Function(it) it.IdMoneda = oeAsiMod.Moneda).ToList
                        If leObliFinAux.Count > 0 Then
                            _MontoGen = leObliFinAux.Sum(Function(it) it.MontoInteresContable)
                            oeAsiento = New e_Asiento
                            With oeAsiento
                                .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsiMod.IdTipoAsiento
                                .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                                .Glosa = oeAsiMod.Nombre : .GlosaImprime = String.Empty
                                .IdMoneda = oeAsiMod.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                                .TotalDebe = _MontoGen : .TotalHaber = _MontoGen : .IdentificaAsiento = "FEC" & oeAsiMod.Moneda
                                .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                            End With
                            For Each oeAux In oeAsiMod.leDetalle.OrderBy(Function(it) it.Fila).ToList
                                If oeAux.Repetir = 0 Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                    oeAsientoMov.Glosa = oeAsiMod.Nombre
                                    oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                    If oeAux.Partida = 1 Then
                                        oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                        oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                                    Else
                                        oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                        oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                                    End If
                                    oeMovAnalisis = New e_MovimientoAnalisis
                                    oeMovAnalisis.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeMovAnalisis.TipoOperacion = "I" : oeMovAnalisis.Activo = True
                                    oeMovAnalisis.IdGastoFuncion = "1CH000090"
                                    oeMovAnalisis.Monto = _MontoGen
                                    oeMovAnalisis.Saldo = _MontoGen
                                    oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Else
                                    For Each oeOAAux In leObliFinAux
                                        oeAsientoMov = New e_AsientoMovimiento
                                        oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                        oeAsientoMov.Glosa = oeAsiMod.Nombre & " " & oeOAAux.NroContrato & "-" & oeOAAux.NroVencimiento & " " & oeOAAux.Banco
                                        oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                        If oeAux.Partida = 1 Then
                                            oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                            oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                        Else
                                            oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                            oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                        End If
                                        ' Generar Asiento Movimiento Obligacion
                                        oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                        oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                        oeAsiMovObli.IdObligacionFinanciera = oeOAAux.Id
                                        oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                        oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                    Next
                                End If
                            Next
                            leAsiento.Add(oeAsiento)
                        End If
                    Next
                    If olAsiento.GuardarLista(leAsiento) Then
                        TransScope.Complete()
                        Return True
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarInteresMensualFed(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModelo As e_AsientoModelo) As Boolean Implements Il_ContratoFinanciero.GuardarInteresMensualFed
        Try
            Dim _MontoGen As Double = 0, _tc As Double = 0
            olFunGen.ValidarPeriodo(oeContratoFinanciero.IdPeriodo, gAreasSGI.Contabilidad, oeContratoFinanciero.FechaEmision, "")
            leAsiento = New List(Of e_Asiento)
            Using TransScope As New TransactionScope()
                If odObliFin.GuardarLista(oeContratoFinanciero.lstObligacionesFin) Then
                    _tc = oeContratoFinanciero.TipoCambio
                    For Each oeAuxMon In oeContratoFinanciero.leMoneda
                        leObliFinAux = oeContratoFinanciero.lstObligacionesFin.Where(Function(it) it.IdMoneda = oeAuxMon.Nombre).ToList
                        If leObliFinAux.Count > 0 Then
                            _MontoGen = leObliFinAux.Sum(Function(it) it.MontoInteresContable)
                            oeAsiento = New e_Asiento
                            With oeAsiento
                                .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsientoModelo.IdTipoAsiento
                                .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                                .Glosa = oeAsientoModelo.Nombre : .GlosaImprime = String.Empty
                                .IdMoneda = oeAuxMon.Id : .TipoCambio = oeContratoFinanciero.TipoCambio
                                .TotalDebe = _MontoGen : .TotalHaber = _MontoGen : .IdentificaAsiento = "FED" & oeAuxMon.Nombre
                                .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                            End With
                            For Each oeAux In oeAsientoModelo.leDetalle.OrderBy(Function(it) it.Fila).ToList
                                If oeAux.Repetir = 0 Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                    oeAsientoMov.Glosa = oeAsientoModelo.Nombre
                                    oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                    If oeAux.Partida = 1 Then
                                        oeAsientoMov.DebeMN = IIf(oeAuxMon.Nombre = "SOLES", _MontoGen, _MontoGen * _tc)
                                        oeAsientoMov.DebeME = IIf(oeAuxMon.Nombre = "SOLES", _MontoGen / _tc, _MontoGen)
                                    Else
                                        oeAsientoMov.HaberMN = IIf(oeAuxMon.Nombre = "SOLES", _MontoGen, _MontoGen * _tc)
                                        oeAsientoMov.HaberME = IIf(oeAuxMon.Nombre = "SOLES", _MontoGen / _tc, _MontoGen)
                                    End If
                                    oeMovAnalisis = New e_MovimientoAnalisis
                                    oeMovAnalisis.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeMovAnalisis.TipoOperacion = "I" : oeMovAnalisis.Activo = True
                                    oeMovAnalisis.IdGastoFuncion = "1CH000090"
                                    oeMovAnalisis.Monto = _MontoGen
                                    oeMovAnalisis.Saldo = _MontoGen
                                    oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Else
                                    For Each oeOAAux In leObliFinAux
                                        oeAsientoMov = New e_AsientoMovimiento
                                        oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                        oeAsientoMov.Glosa = oeAsientoModelo.Nombre & " " & oeOAAux.NroContrato & "-" & oeOAAux.NroVencimiento & " " & oeOAAux.Banco
                                        oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                        If oeAux.Partida = 1 Then
                                            oeAsientoMov.DebeMN = IIf(oeAuxMon.Nombre = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                            oeAsientoMov.DebeME = IIf(oeAuxMon.Nombre = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                        Else
                                            oeAsientoMov.HaberMN = IIf(oeAuxMon.Nombre = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                            oeAsientoMov.HaberME = IIf(oeAuxMon.Nombre = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                        End If
                                        ' Generar Asiento Movimiento Obligacion
                                        oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                        oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                        oeAsiMovObli.IdObligacionFinanciera = oeOAAux.Id
                                        oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                        oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                    Next
                                End If
                            Next
                            leAsiento.Add(oeAsiento)
                        End If
                    Next
                    If olAsiento.GuardarLista(leAsiento) Then
                        TransScope.Complete()
                        Return True
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarInteresMensualPagare(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModelo As e_AsientoModelo) As Boolean Implements Il_ContratoFinanciero.GuardarInteresMensualPagare
        Try
            Dim _MontoGen As Double = 0, _tc As Double = 0
            olFunGen.ValidarPeriodo(oeContratoFinanciero.IdPeriodo, gAreasSGI.Contabilidad, oeContratoFinanciero.FechaEmision, "")
            leAsiento = New List(Of e_Asiento)
            Using TransScope As New TransactionScope()
                If odObliFin.GuardarLista(oeContratoFinanciero.lstObligacionesFin) Then
                    _tc = oeContratoFinanciero.TipoCambio
                    For Each oeAuxMon In oeContratoFinanciero.leMoneda
                        leObliFinAux = oeContratoFinanciero.lstObligacionesFin.Where(Function(it) it.IdMoneda = oeAuxMon.Nombre).ToList
                        If leObliFinAux.Count > 0 Then
                            _MontoGen = leObliFinAux.Sum(Function(it) it.MontoInteresContable)
                            oeAsiento = New e_Asiento
                            With oeAsiento
                                .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsientoModelo.IdTipoAsiento
                                .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                                .Glosa = oeAsientoModelo.Nombre : .GlosaImprime = String.Empty
                                .IdMoneda = oeAuxMon.Id : .TipoCambio = oeContratoFinanciero.TipoCambio
                                .TotalDebe = _MontoGen : .TotalHaber = _MontoGen : .IdentificaAsiento = "PAGARE" & oeAuxMon.Nombre
                                .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                            End With
                            For Each oeAux In oeAsientoModelo.leDetalle.OrderBy(Function(it) it.Fila).ToList
                                If oeAux.Repetir = 0 Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                    oeAsientoMov.Glosa = oeAsientoModelo.Nombre
                                    oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                    If oeAux.Partida = 1 Then
                                        oeAsientoMov.DebeMN = IIf(oeAuxMon.Nombre = "SOLES", _MontoGen, _MontoGen * _tc)
                                        oeAsientoMov.DebeME = IIf(oeAuxMon.Nombre = "SOLES", _MontoGen / _tc, _MontoGen)
                                    Else
                                        oeAsientoMov.HaberMN = IIf(oeAuxMon.Nombre = "SOLES", _MontoGen, _MontoGen * _tc)
                                        oeAsientoMov.HaberME = IIf(oeAuxMon.Nombre = "SOLES", _MontoGen / _tc, _MontoGen)
                                    End If
                                    oeMovAnalisis = New e_MovimientoAnalisis
                                    oeMovAnalisis.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeMovAnalisis.TipoOperacion = "I" : oeMovAnalisis.Activo = True
                                    oeMovAnalisis.IdGastoFuncion = "1CH000090"
                                    oeMovAnalisis.Monto = _MontoGen
                                    oeMovAnalisis.Saldo = _MontoGen
                                    oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Else
                                    For Each oeOAAux In leObliFinAux
                                        oeAsientoMov = New e_AsientoMovimiento
                                        oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                        oeAsientoMov.Glosa = oeAsientoModelo.Nombre & " " & oeOAAux.NroContrato & "-" & oeOAAux.NroVencimiento & " " & oeOAAux.Banco
                                        oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                        If oeAux.Partida = 1 Then
                                            oeAsientoMov.DebeMN = IIf(oeAuxMon.Nombre = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                            oeAsientoMov.DebeME = IIf(oeAuxMon.Nombre = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                        Else
                                            oeAsientoMov.HaberMN = IIf(oeAuxMon.Nombre = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                            oeAsientoMov.HaberME = IIf(oeAuxMon.Nombre = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                        End If
                                        ' Generar Asiento Movimiento Obligacion
                                        oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                        oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                        oeAsiMovObli.IdObligacionFinanciera = oeOAAux.Id
                                        oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                        oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                    Next
                                End If
                            Next
                            leAsiento.Add(oeAsiento)
                        End If
                    Next
                    If olAsiento.GuardarLista(leAsiento) Then
                        TransScope.Complete()
                        Return True
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarInteresMensualLeasingReversion(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean Implements Il_ContratoFinanciero.GuardarInteresMensualLeasingReversion
        Try
            Dim _MontoGen As Double = 0, _MontoNeg As Double = 0, _tc As Double = 0
            olFunGen.ValidarPeriodo(oeContratoFinanciero.IdPeriodo, gAreasSGI.Contabilidad, oeContratoFinanciero.FechaEmision, "")
            leAsiento = New List(Of e_Asiento)

            Dim tiempo As New TimeSpan(0.25, 0, 0)
            Dim options As New TransactionOptions
            options.Timeout = tiempo

            Using TransScope As New TransactionScope(TransactionScopeOption.Required, options)
                _tc = oeContratoFinanciero.TipoCambio
                For Each oeAsiMod In leAsientoModelo
                    leObliFinAux = oeContratoFinanciero.lstObligacionesFin.Where(Function(it) it.IdMoneda = oeAsiMod.Moneda And it.IndFec = oeAsiMod.IndVinculado).ToList
                    If leObliFinAux.Count > 0 Then
                        _MontoGen = leObliFinAux.Where(Function(it) it.MontoInteresContable > 0).Sum(Function(it) it.MontoInteresContable)
                        _MontoNeg = leObliFinAux.Where(Function(it) it.MontoInteresContable < 0).Sum(Function(it) it.MontoInteresContable)
                        If _MontoNeg < 0 Then _MontoNeg = (_MontoNeg * -1) : _MontoGen = _MontoGen - _MontoNeg
                        oeAsiento = New e_Asiento
                        With oeAsiento
                            .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                            .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsiMod.IdTipoAsiento
                            .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                            .Glosa = oeAsiMod.Nombre : .GlosaImprime = String.Empty
                            .IdMoneda = oeAsiMod.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                            .TotalDebe = _MontoGen : .TotalHaber = _MontoGen : .IdentificaAsiento = "LEASINGINTERES" & oeAsiMod.Moneda
                            .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                        End With
                        For Each oeAux In oeAsiMod.leDetalle.OrderBy(Function(it) it.Fila).ToList
                            If oeAux.Repetir = 0 Then
                                oeAsientoMov = New e_AsientoMovimiento
                                oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                oeAsientoMov.Glosa = oeAsiMod.Nombre
                                oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                If oeAux.Partida = 1 Then
                                    oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                    oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                                Else
                                    oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                    oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                                End If
                                oeMovAnalisis = New e_MovimientoAnalisis
                                oeMovAnalisis.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                oeMovAnalisis.TipoOperacion = "I" : oeMovAnalisis.Activo = True
                                oeMovAnalisis.IdGastoFuncion = "1CH000090"
                                oeMovAnalisis.Monto = _MontoGen
                                oeMovAnalisis.Saldo = _MontoGen
                                oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            Else
                                For Each oeOAAux In leObliFinAux
                                    If oeOAAux.MontoInteresContable > 0 Then
                                        oeAsientoMov = New e_AsientoMovimiento
                                        oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                        oeAsientoMov.Glosa = oeAsiMod.Nombre & " " & oeOAAux.NroContrato & "-" & oeOAAux.NroVencimiento & " " & oeOAAux.Banco
                                        oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                        If oeAux.Partida = 1 Then
                                            oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                            oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                        Else
                                            oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                            oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                        End If
                                        ' Generar Asiento Movimiento Obligacion
                                        oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                        oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                        oeAsiMovObli.IdObligacionFinanciera = oeOAAux.Id
                                        oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                        oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                    End If
                                    If oeOAAux.MontoInteresContable < 0 Then
                                        Dim _valor As Double = 0
                                        _valor = oeOAAux.MontoInteresContable * -1
                                        oeAsientoMov = New e_AsientoMovimiento
                                        oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                        oeAsientoMov.Glosa = oeAsiMod.Nombre & " " & oeOAAux.NroContrato & "-" & oeOAAux.NroVencimiento & " " & oeOAAux.Banco
                                        oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                        oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _valor, _valor * _tc)
                                        oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", _valor / _tc, _valor)
                                        ' Generar Asiento Movimiento Obligacion
                                        oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                        oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                        oeAsiMovObli.IdObligacionFinanciera = oeOAAux.Id
                                        oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                        oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                    End If
                                Next
                            End If
                        Next
                        leAsiento.Add(oeAsiento)
                    End If
                Next
                If olAsiento.GuardarLista(leAsiento) Then
                    TransScope.Complete()
                    Return True
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarInteresMensualCreditoHipotecario(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean Implements Il_ContratoFinanciero.GuardarInteresMensualCreditoHipotecario
        Try
            Dim _MontoGen As Double = 0, _tc As Double = 0
            olFunGen.ValidarPeriodo(oeContratoFinanciero.IdPeriodo, gAreasSGI.Contabilidad, oeContratoFinanciero.FechaEmision, "")
            leAsiento = New List(Of e_Asiento)
            Using TransScope As New TransactionScope()
                _tc = oeContratoFinanciero.TipoCambio
                For Each oeAsiMod In leAsientoModelo
                    leObliFinAux = oeContratoFinanciero.lstObligacionesFin.Where(Function(it) it.IdMoneda = oeAsiMod.Moneda).ToList
                    If leObliFinAux.Count > 0 Then
                        _MontoGen = leObliFinAux.Sum(Function(it) it.MontoInteresContable)
                        oeAsiento = New e_Asiento
                        With oeAsiento
                            .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                            .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsiMod.IdTipoAsiento
                            .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                            .Glosa = oeAsiMod.Nombre : .GlosaImprime = String.Empty
                            .IdMoneda = oeAsiMod.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                            .TotalDebe = _MontoGen : .TotalHaber = _MontoGen : .IdentificaAsiento = "CHP" & oeAsiMod.Moneda
                            .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                        End With
                        For Each oeAux In oeAsiMod.leDetalle.OrderBy(Function(it) it.Fila).ToList
                            If oeAux.Repetir = 0 Then
                                oeAsientoMov = New e_AsientoMovimiento
                                oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                oeAsientoMov.Glosa = oeAsiMod.Nombre
                                oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                If oeAux.Partida = 1 Then
                                    oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                    oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                                Else
                                    oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                    oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                                End If
                                oeMovAnalisis = New e_MovimientoAnalisis
                                oeMovAnalisis.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                oeMovAnalisis.TipoOperacion = "I" : oeMovAnalisis.Activo = True
                                oeMovAnalisis.IdGastoFuncion = "1CH000090"
                                oeMovAnalisis.Monto = _MontoGen
                                oeMovAnalisis.Saldo = _MontoGen
                                oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            Else
                                For Each oeOAAux In leObliFinAux
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                    oeAsientoMov.Glosa = oeAsiMod.Nombre & " " & oeOAAux.NroContrato & "-" & oeOAAux.NroVencimiento & " " & oeOAAux.Banco
                                    oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                    If oeAux.Partida = 1 Then
                                        oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                        oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                    Else
                                        oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable, oeOAAux.MontoInteresContable * _tc)
                                        oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", oeOAAux.MontoInteresContable / _tc, oeOAAux.MontoInteresContable)
                                    End If
                                    ' Generar Asiento Movimiento Obligacion
                                    oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                    oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                    oeAsiMovObli.IdObligacionFinanciera = oeOAAux.Id
                                    oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Next
                            End If
                        Next
                        leAsiento.Add(oeAsiento)
                    End If
                Next
                If olAsiento.GuardarLista(leAsiento) Then
                    TransScope.Complete()
                    Return True
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarInteresMensualPuenteCreHip(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean Implements Il_ContratoFinanciero.GuardarInteresMensualPuenteCreHip
        Try
            Dim _MontoGen As Double = 0, _tc As Double = 0, _MontoObliAux As Double = 0, _Monto60 As Double = 0
            olFunGen.ValidarPeriodo(oeContratoFinanciero.IdPeriodo, gAreasSGI.Contabilidad, oeContratoFinanciero.FechaEmision, "")
            leAsiento = New List(Of e_Asiento)
            Using TransScope As New TransactionScope()
                If odObliFin.GuardarLista(oeContratoFinanciero.lstObligacionesFin) Then
                    _tc = oeContratoFinanciero.TipoCambio
                    For Each oeAsiMod In leAsientoModelo
                        leObliFinAux = oeContratoFinanciero.lstObligacionesFin.Where(Function(it) it.IdMoneda = oeAsiMod.Moneda).ToList
                        If leObliFinAux.Count > 0 Then
                            _MontoGen = leObliFinAux.Sum(Function(it) it.MontoInteresContable + it.MontoInteresDscto)
                            oeAsiento = New e_Asiento
                            With oeAsiento
                                .PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                .TipoOperacion = "I" : .IdPeriodo = oeContratoFinanciero.IdPeriodo : .IdTipoAsiento = oeAsiMod.IdTipoAsiento
                                .NroAsiento = String.Empty : .Fecha = oeContratoFinanciero.FechaEmision
                                .Glosa = oeAsiMod.Nombre : .GlosaImprime = String.Empty
                                .IdMoneda = oeAsiMod.IdMoneda : .TipoCambio = oeContratoFinanciero.TipoCambio
                                .TotalDebe = _MontoGen : .TotalHaber = _MontoGen : .IdentificaAsiento = "CHC" & oeAsiMod.Moneda
                                .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsiento.Activo = True
                            End With
                            For Each oeAux In oeAsiMod.leDetalle.OrderBy(Function(it) it.Fila).ToList
                                If oeAux.Repetir = 0 Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                    oeAsientoMov.Glosa = oeAsiMod.Nombre
                                    oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                    If oeAux.Partida = 1 Then
                                        _Monto60 = leObliFinAux.Sum(Function(it) it.MontoInteresDscto)
                                        oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _Monto60, _Monto60 * _tc)
                                        oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", _Monto60 / _tc, _Monto60)
                                        ' Generar Movimiento Analisis
                                        oeMovAnalisis = New e_MovimientoAnalisis
                                        oeMovAnalisis.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeMovAnalisis.TipoOperacion = "I" : oeMovAnalisis.Activo = True
                                        oeMovAnalisis.IdGastoFuncion = "1CH000090"
                                        oeMovAnalisis.Monto = _Monto60
                                        oeMovAnalisis.Saldo = _Monto60
                                        oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                        'Else
                                        '    oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                        '    oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                                        '    ' Generar Asiento Movimiento Caja y Banco
                                        '    oeMovCajaBanco = New e_MovimientoCajaBanco
                                        '    oeMovCajaBanco.TipoOperacion = "I" : oeMovCajaBanco.Activo = True
                                        '    oeMovCajaBanco.IdFlujoCaja = "1CH000000212"
                                        '    oeMovCajaBanco.IdMedioPago = "1CH05"
                                        '    oeMovCajaBanco.NroBoucher = "00000000"
                                        '    oeMovCajaBanco.UsuarioCreacion = oeContratoFinanciero.Usuario
                                        '    oeMovCajaBanco.IdCuentaBancaria = "1SI000000017" 'Corregir Cuanto Hay mas Creditos
                                        '    oeMovCajaBanco._Operador = -1 : oeMovCajaBanco.Fecha = oeContratoFinanciero.FechaEmision
                                        '    oeMovCajaBanco.TotalMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                        '    oeMovCajaBanco.TotalME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                                        '    oeAsientoMov.MovimientoCajaBanco = oeMovCajaBanco
                                    End If
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Else
                                    For Each oeOAAux In leObliFinAux
                                        oeAsientoMov = New e_AsientoMovimiento
                                        oeAsientoMov.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                        oeAsientoMov.Glosa = oeAsiMod.Nombre & " " & oeOAAux.NroContrato & "-" & oeOAAux.NroVencimiento & " " & oeOAAux.Banco
                                        oeAsientoMov.IdUsuarioCrea = oeContratoFinanciero.Usuario : oeAsientoMov.Activo = True
                                        _MontoObliAux = 0
                                        If oeAux.Partida = 1 Then
                                            _MontoObliAux = IIf(oeAsiMod.IndVinculado = True, oeOAAux.MontoInteresContable + oeOAAux.MontoInteresDscto, oeOAAux.MontoInteresContable)
                                            oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoObliAux, _MontoObliAux * _tc)
                                            oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", _MontoObliAux / _tc, _MontoObliAux)
                                        Else
                                            _MontoObliAux = oeOAAux.MontoInteresContable + oeOAAux.MontoInteresDscto
                                            oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoObliAux, _MontoObliAux * _tc)
                                            oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", _MontoObliAux / _tc, _MontoObliAux)
                                        End If
                                        ' Generar Asiento Movimiento Obligacion
                                        oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                        oeAsiMovObli.PrefijoID = oeContratoFinanciero.PrefijoID '@0001
                                        oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                        oeAsiMovObli.IdObligacionFinanciera = oeOAAux.Id
                                        oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                        oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                    Next
                                End If
                            Next
                            leAsiento.Add(oeAsiento)
                        End If
                    Next
                    If olAsiento.GuardarLista(leAsiento) Then
                        TransScope.Complete()
                        Return True
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class
