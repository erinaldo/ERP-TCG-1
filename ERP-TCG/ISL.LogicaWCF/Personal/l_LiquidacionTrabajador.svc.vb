' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_LiquidacionTrabajador" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_LiquidacionTrabajador.svc o l_LiquidacionTrabajador.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class l_LiquidacionTrabajador
    Implements Il_LiquidacionTrabajador

    Dim odLiquidacionTrabajador As New d_LiquidacionTrabajador

    Public Function Obtener(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As e_LiquidacionTrabajador Implements Il_LiquidacionTrabajador.Obtener
        Try
            Return odLiquidacionTrabajador.Obtener(oeLiquidacionTrabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As List(Of e_LiquidacionTrabajador) Implements Il_LiquidacionTrabajador.Listar
        Try
            Return odLiquidacionTrabajador.Listar(oeLiquidacionTrabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As Boolean Implements Il_LiquidacionTrabajador.Validar
        Try
            Dim oePeriodo As e_Periodo
            Dim olPeriodo As l_Periodo
            With oeLiquidacionTrabajador
                If .IdTrabajador = "" Then Throw New Exception("Seleccione trabajador")
                If .IdMotivoCese = "" Then Throw New Exception("Seleccione el Motivo de Cese")
                If .IdEstado = "1CH00037" And .TipoOperacion = "C" And .IdPeriodo = "" Then Throw New Exception("No se encontro periodo actual para provisionar liquidación.")
                If .IdPeriodo = "" Then Throw New Exception("Seleccione Periodo")
                'If .DTxD - (.DTEssaludVida + .DTDsctoAFP + .AdelantoSueldo) < 0 Then Throw New Exception("El Monto no Puede Ser Negativo")
                oePeriodo = New e_Periodo
                olPeriodo = New l_Periodo
                oePeriodo.Id = oeLiquidacionTrabajador.IdPeriodo
                oePeriodo = olPeriodo.Obtener(oePeriodo)
                If oePeriodo.CierrePlanilla Then Throw New Exception("Periodo Contable se encuentra cerrado.")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador, Optional oeMovCajaBanco As e_MovimientoCajaBanco = Nothing) As Boolean Implements Il_LiquidacionTrabajador.Guardar
        Try
            Dim oeAsientoModelo As New e_AsientoModelo
            Dim oeAsiento As New e_Asiento
            Dim oeTrabajador As e_Trabajador
            Dim loAsiento As New List(Of e_Asiento)
            Dim olAsiento As New l_Asiento
            Dim olTrabajador As New l_Trabajador
            Dim oeAsientoMovimiento As New e_AsientoMovimiento
            Dim loAsientoMovimiento As New List(Of e_AsientoMovimiento)
            Dim oeLiquidacionTrabajador_Asiento As e_LiquidacionTrabajador_Asiento
            Dim olLiquidacionTrabajador_Asiento As l_LiquidacionTrabajador_Asiento
            If Validar(oeLiquidacionTrabajador) Then
                Using TransScope As New TransactionScope()
                    If odLiquidacionTrabajador.Guardar(oeLiquidacionTrabajador) Then
                        If oeLiquidacionTrabajador.TipoOperacion = "C" And oeLiquidacionTrabajador.IdEstado = "1CH00037" Then
                            oeTrabajador = New e_Trabajador
                            oeTrabajador.CargaCompleto = True
                            oeTrabajador.Id = oeLiquidacionTrabajador.IdTrabajador
                            oeTrabajador.TipoOperacion = "N"
                            oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                            oeLiquidacionTrabajador_Asiento = New e_LiquidacionTrabajador_Asiento
                            olLiquidacionTrabajador_Asiento = New l_LiquidacionTrabajador_Asiento
                            oeLiquidacionTrabajador_Asiento.idliquidaciontrabajador = oeLiquidacionTrabajador.Id
                            oeLiquidacionTrabajador_Asiento.Tipo = "1CH00037"
                            oeLiquidacionTrabajador_Asiento.Activo = 1
                            If olLiquidacionTrabajador_Asiento.Listar(oeLiquidacionTrabajador_Asiento).Count > 0 Then Throw New Exception("Ya se generó la provisión de liquidación del Trabajador: " & oeLiquidacionTrabajador.Trabajador)

                            oeAsiento = New e_Asiento
                            loAsientoMovimiento = New List(Of e_AsientoMovimiento)
                            With oeAsiento
                                .TipoOperacion = "I" : .IdPeriodo = oeLiquidacionTrabajador.IdPeriodo : .IdTipoAsiento = oeLiquidacionTrabajador.oeAsientoModelo.IdTipoAsiento
                                .NroAsiento = String.Empty : .Fecha = oeLiquidacionTrabajador.FechaCreacion : .Glosa = oeLiquidacionTrabajador.oeAsientoModelo.Nombre & " " _
                                    & oeLiquidacionTrabajador.Trabajador
                                .GlosaImprime = String.Empty : .IdMoneda = "1CH01" : .TipoCambio = oeLiquidacionTrabajador.TipoCambio
                                .TotalDebe = Math.Round(oeLiquidacionTrabajador.TotalPagar, 2)
                                .TotalHaber = Math.Round(oeLiquidacionTrabajador.TotalPagar, 2)
                                .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeLiquidacionTrabajador.UsuarioCreacion : oeAsiento.Activo = True
                                .IndOrigen = 16
                            End With
                            oeLiquidacionTrabajador_Asiento = New e_LiquidacionTrabajador_Asiento
                            oeLiquidacionTrabajador_Asiento.idliquidaciontrabajador = oeLiquidacionTrabajador.Id
                            oeLiquidacionTrabajador_Asiento.TipoOperacion = "I"
                            oeLiquidacionTrabajador_Asiento.Tipo = oeLiquidacionTrabajador.IdEstado
                            oeLiquidacionTrabajador_Asiento.Activo = 1
                            oeLiquidacionTrabajador_Asiento.usuariocrea = oeLiquidacionTrabajador.UsuarioCreacion
                            oeAsiento.oeLiquidacionTrabajador_Asiento = oeLiquidacionTrabajador_Asiento
                            For Each asidet As e_DetalleAsientoModelo In oeLiquidacionTrabajador.oeAsientoModelo.leDetalle.Where(Function(i) i.Partida = 1).ToList
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                With oeAsientoMovimiento
                                    .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                    .IdUsuarioCrea = oeLiquidacionTrabajador.UsuarioCreacion : .Activo = True : .Fila = asidet.Fila
                                    .IdCuentaContable = asidet.IdCuentaContable
                                    Select Case asidet.Fila
                                        Case "A" 'CTS
                                            If oeLiquidacionTrabajador.CTSxD > 0 Or oeLiquidacionTrabajador.CTSxM > 0 Then
                                                .DebeMN = Math.Round(oeLiquidacionTrabajador.CTSxD + oeLiquidacionTrabajador.CTSxM - oeLiquidacionTrabajador.CTSxF, 2)
                                                .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1))
                                            End If
                                        Case "B" 'VACACIONES TRUNCAS
                                            If oeLiquidacionTrabajador.VTxD > 0 Or oeLiquidacionTrabajador.VTxM > 0 Or oeLiquidacionTrabajador.VTxA > 0 Then
                                                .DebeMN = Math.Round(oeLiquidacionTrabajador.VTxD + oeLiquidacionTrabajador.VTxM + oeLiquidacionTrabajador.VTxA - _
                                                    oeLiquidacionTrabajador.VTGozadas - oeLiquidacionTrabajador.VTxF, 2)
                                                .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1))
                                            End If
                                        Case "C" 'GRATIFICACION TRUNCA
                                            If oeLiquidacionTrabajador.GTxD > 0 Or oeLiquidacionTrabajador.GTxM > 0 Then
                                                .DebeMN = Math.Round(oeLiquidacionTrabajador.GTxD + oeLiquidacionTrabajador.GTxM - oeLiquidacionTrabajador.GTxF, 2)
                                                .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1))
                                            End If
                                        Case "D" 'BONIFICACION EXTRAORDINARIA
                                            If oeLiquidacionTrabajador.BoniExtra > 0 Then
                                                .DebeMN = Math.Round(oeLiquidacionTrabajador.BoniExtra, 2)
                                                .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1))
                                            End If
                                        Case "E" 'CANTIDAD GRACIOSA
                                            If oeLiquidacionTrabajador.CantidadGraciosa > 0 Then
                                                .DebeMN = Math.Round(oeLiquidacionTrabajador.CantidadGraciosa, 2)
                                                .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1))
                                            End If
                                        Case "F" 'DIAS TRABAJADOS
                                            If oeLiquidacionTrabajador.DTxD > 0 Then
                                                '.DebeMN = Math.Round((oeLiquidacionTrabajador.DTxD + oeLiquidacionTrabajador.DTAsigFam) - _
                                                '                     (oeLiquidacionTrabajador.DTDsctoAFP + oeLiquidacionTrabajador.DTEssaludVida _
                                                '                      + oeLiquidacionTrabajador.AdelantoSueldo), 2)
                                                .DebeMN = Math.Round(oeLiquidacionTrabajador.DTxD + oeLiquidacionTrabajador.DTAsigFam - oeLiquidacionTrabajador.DTxF, 2)
                                                .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1))
                                            End If
                                        Case "O" 'ESSALUD
                                            If oeLiquidacionTrabajador.AporteEsalud > 0 Then
                                                .DebeMN = Math.Round(oeLiquidacionTrabajador.AporteEsalud, 2)
                                                .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1))
                                            End If
                                    End Select
                                    If .DebeMN > 0 Then
                                        loAsientoMovimiento.Add(oeAsientoMovimiento)
                                    End If
                                End With
                            Next
                            Dim oeAsientoMovAux As New e_AsientoMovimiento
                            Dim loAsientoMovAux As New List(Of e_AsientoMovimiento)
                            For Each a As e_AsientoMovimiento In loAsientoMovimiento
                                oeAsientoMovAux = New e_AsientoMovimiento
                                oeAsientoMovAux.Fila = a.Fila
                                oeAsientoMovAux.DebeMN = a.DebeMN
                                loAsientoMovAux.Add(oeAsientoMovAux)
                            Next
                            For Each asidet As e_DetalleAsientoModelo In oeLiquidacionTrabajador.oeAsientoModelo.leDetalle.Where(Function(i) i.Partida = 2).ToList
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                With oeAsientoMovimiento
                                    .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                    .IdUsuarioCrea = oeLiquidacionTrabajador.UsuarioCreacion : .Activo = True : .Fila = asidet.Fila
                                    .IdCuentaContable = asidet.IdCuentaContable
                                    Select Case asidet.Formula
                                        Case "A" 'CTS
                                            If loAsientoMovAux.Where(Function(i) i.Fila = "A").ToList.Count > 0 Then
                                                .HaberMN = Math.Round(loAsientoMovAux.Where(Function(i) i.Fila = "A").ToList.Sum(Function(i) i.DebeMN), 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "B" 'VACACIONES TRUNCAS
                                            If loAsientoMovAux.Where(Function(i) i.Fila = "B").ToList.Count > 0 Then
                                                .HaberMN = Math.Round(loAsientoMovAux.Where(Function(i) i.Fila = "B").ToList.Sum(Function(i) i.DebeMN) - oeLiquidacionTrabajador.VTxDescuentoAFP, 2)
                                                '.HaberMN = Math.Round(oeLiquidacionTrabajador.VTxD + oeLiquidacionTrabajador.VTxM + oeLiquidacionTrabajador.VTxA - _
                                                '    oeLiquidacionTrabajador.VTGozadas - oeLiquidacionTrabajador.VTxF - oeLiquidacionTrabajador.VTxDescuentoAFP, 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "C" 'GRATIFICACION TRUNCA
                                            If loAsientoMovAux.Where(Function(i) i.Fila = "C").ToList.Count > 0 Then
                                                .HaberMN = Math.Round(loAsientoMovAux.Where(Function(i) i.Fila = "C").ToList.Sum(Function(i) i.DebeMN), 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "D" 'BONIFICACION EXTRAORDINARIA
                                            If loAsientoMovAux.Where(Function(i) i.Fila = "D").ToList.Count > 0 Then
                                                .HaberMN = Math.Round(loAsientoMovAux.Where(Function(i) i.Fila = "D").ToList.Sum(Function(i) i.DebeMN), 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "E" 'CANTIDAD GRACIOSA
                                            If loAsientoMovAux.Where(Function(i) i.Fila = "E").ToList.Count > 0 Then
                                                .HaberMN = Math.Round(loAsientoMovAux.Where(Function(i) i.Fila = "E").ToList.Sum(Function(i) i.DebeMN), 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "F" 'DIAS TRABAJADOS
                                            If loAsientoMovAux.Where(Function(i) i.Fila = "F").ToList.Count > 0 Then
                                                .HaberMN = Math.Round(loAsientoMovAux.Where(Function(i) i.Fila = "F").ToList.Sum(Function(i) i.DebeMN) - oeLiquidacionTrabajador.DTEssaludVida - oeLiquidacionTrabajador.DTDsctoAFP, 2)
                                                '.HaberMN = Math.Round(oeLiquidacionTrabajador.DTxD + oeLiquidacionTrabajador.DTAsigFam - oeLiquidacionTrabajador.DTxF - oeLiquidacionTrabajador.DTEssaludVida - oeLiquidacionTrabajador.DTDsctoAFP, 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "G" 'ESSALUD - VIDA
                                            If oeLiquidacionTrabajador.DTEssaludVida > 0 Then
                                                .HaberMN = Math.Round(oeLiquidacionTrabajador.DTEssaludVida, 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "H" 'ONP
                                            If ((oeLiquidacionTrabajador.VTxDescuentoAFP + oeLiquidacionTrabajador.DTDsctoAFP) > 0) And oeTrabajador.leFondoPension(0).IdEmpresa = "1CH000010168" Then
                                                .HaberMN = Math.Round(oeLiquidacionTrabajador.VTxDescuentoAFP + oeLiquidacionTrabajador.DTDsctoAFP, 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "I" 'AFP HABITAT
                                            If ((oeLiquidacionTrabajador.VTxDescuentoAFP + oeLiquidacionTrabajador.DTDsctoAFP) > 0) And oeTrabajador.leFondoPension(0).IdEmpresa = "1CH000010169" Then
                                                .HaberMN = Math.Round(oeLiquidacionTrabajador.VTxDescuentoAFP + oeLiquidacionTrabajador.DTDsctoAFP, 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "J" 'AFP INTEGRA
                                            If ((oeLiquidacionTrabajador.VTxDescuentoAFP + oeLiquidacionTrabajador.DTDsctoAFP) > 0) And oeTrabajador.leFondoPension(0).IdEmpresa = "1CH000010170" Then
                                                .HaberMN = Math.Round(oeLiquidacionTrabajador.VTxDescuentoAFP + oeLiquidacionTrabajador.DTDsctoAFP, 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "K" 'AFP PROFUTURO
                                            If ((oeLiquidacionTrabajador.VTxDescuentoAFP + oeLiquidacionTrabajador.DTDsctoAFP) > 0) And oeTrabajador.leFondoPension(0).IdEmpresa = "1CH000010172" Then
                                                .HaberMN = Math.Round(oeLiquidacionTrabajador.VTxDescuentoAFP + oeLiquidacionTrabajador.DTDsctoAFP, 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "L" 'AFP PRIMA
                                            If ((oeLiquidacionTrabajador.VTxDescuentoAFP + oeLiquidacionTrabajador.DTDsctoAFP) > 0) And oeTrabajador.leFondoPension(0).IdEmpresa = "1CH000010171" Then
                                                .HaberMN = Math.Round(oeLiquidacionTrabajador.VTxDescuentoAFP + oeLiquidacionTrabajador.DTDsctoAFP, 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                        Case "M" 'ESSALUD
                                            If loAsientoMovAux.Where(Function(i) i.Fila = "O").ToList.Count > 0 Then
                                                .HaberMN = Math.Round(loAsientoMovAux.Where(Function(i) i.Fila = "O").ToList.Sum(Function(i) i.DebeMN), 2)
                                                .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 0))
                                            End If
                                    End Select
                                    If .HaberMN > 0 Then
                                        loAsientoMovimiento.Add(oeAsientoMovimiento)
                                    End If
                                End With
                            Next
                            oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                            loAsiento.Add(oeAsiento)
                            If olAsiento.GuardarLista(loAsiento) Then
                                TransScope.Complete()
                            Else
                                Throw New Exception("No Se Completo la Transaccion")
                            End If
                        Else
                            If oeLiquidacionTrabajador.TipoOperacion = "C" And oeLiquidacionTrabajador.IdEstado = "1CH00038" Then
                                oeTrabajador = New e_Trabajador
                                oeTrabajador.CargaCompleto = True
                                oeTrabajador.Id = oeLiquidacionTrabajador.IdTrabajador
                                oeTrabajador.TipoOperacion = "N"
                                oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                                oeLiquidacionTrabajador_Asiento = New e_LiquidacionTrabajador_Asiento
                                olLiquidacionTrabajador_Asiento = New l_LiquidacionTrabajador_Asiento
                                oeLiquidacionTrabajador_Asiento.idliquidaciontrabajador = oeLiquidacionTrabajador.Id
                                oeLiquidacionTrabajador_Asiento.Tipo = "1CH00038"
                                oeLiquidacionTrabajador_Asiento.Activo = 1
                                If olLiquidacionTrabajador_Asiento.Listar(oeLiquidacionTrabajador_Asiento).Count > 0 Then Throw New Exception("Ya se generó el pagó de liquidación del Trabajador: " & oeLiquidacionTrabajador.Trabajador)
                                oeAsiento = New e_Asiento
                                loAsientoMovimiento = New List(Of e_AsientoMovimiento)
                                With oeAsiento
                                    .TipoOperacion = "I" : .IdPeriodo = oeLiquidacionTrabajador.IdPeriodo : .IdTipoAsiento = oeLiquidacionTrabajador.oeAsientoModelo.IdTipoAsiento
                                    .NroAsiento = String.Empty : .Fecha = oeLiquidacionTrabajador.Fecha : .Glosa = "PLANILLA - PAGO LBS " & oeLiquidacionTrabajador.Trabajador
                                    .GlosaImprime = String.Empty : .IdMoneda = "1CH01" : .TipoCambio = oeLiquidacionTrabajador.TipoCambio
                                    .TotalDebe = Math.Round(oeLiquidacionTrabajador.TotalPagar, 2) + Math.Round(oeLiquidacionTrabajador.AdelantoSueldo, 2)
                                    .TotalHaber = Math.Round(oeLiquidacionTrabajador.TotalPagar, 2) + Math.Round(oeLiquidacionTrabajador.AdelantoSueldo, 2)
                                    .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeLiquidacionTrabajador.UsuarioCreacion : oeAsiento.Activo = True
                                    .IndOrigen = 0
                                End With
                                oeLiquidacionTrabajador_Asiento = New e_LiquidacionTrabajador_Asiento
                                oeLiquidacionTrabajador_Asiento.TipoOperacion = "I"
                                oeLiquidacionTrabajador_Asiento.idliquidaciontrabajador = oeLiquidacionTrabajador.Id
                                oeLiquidacionTrabajador_Asiento.Tipo = oeLiquidacionTrabajador.IdEstado
                                oeLiquidacionTrabajador_Asiento.Activo = 1
                                oeLiquidacionTrabajador_Asiento.usuariocrea = oeLiquidacionTrabajador.UsuarioCreacion
                                oeAsiento.oeLiquidacionTrabajador_Asiento = oeLiquidacionTrabajador_Asiento
                                For Each asidet As e_DetalleAsientoModelo In oeLiquidacionTrabajador.oeAsientoModelo.leDetalle.Where(Function(i) i.Partida = 1).ToList
                                    oeAsientoMovimiento = New e_AsientoMovimiento
                                    With oeAsientoMovimiento
                                        .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                        .IdUsuarioCrea = oeLiquidacionTrabajador.UsuarioCreacion : .Activo = True : .Fila = asidet.Fila
                                        .IdCuentaContable = asidet.IdCuentaContable
                                        Select Case asidet.Fila
                                            Case "D" 'CTS
                                                If oeLiquidacionTrabajador.CTSxD > 0 Or oeLiquidacionTrabajador.CTSxM > 0 Then
                                                    .DebeMN = Math.Round(oeLiquidacionTrabajador.CTSxD + oeLiquidacionTrabajador.CTSxM - oeLiquidacionTrabajador.CTSxF, 2)
                                                    .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                    .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1, True))
                                                End If
                                            Case "C" 'VACACIONES TRUNCAS
                                                If oeLiquidacionTrabajador.VTxD > 0 Or oeLiquidacionTrabajador.VTxM > 0 Or oeLiquidacionTrabajador.VTxA > 0 Then
                                                    .DebeMN = Math.Round(oeLiquidacionTrabajador.VTxD + oeLiquidacionTrabajador.VTxM + oeLiquidacionTrabajador.VTxA - _
                                                       oeLiquidacionTrabajador.VTGozadas - oeLiquidacionTrabajador.VTxF - oeLiquidacionTrabajador.VTxDescuentoAFP, 2)
                                                    .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                    .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1, True))
                                                End If
                                            Case "B" 'GRATIFICACION TRUNCA
                                                If oeLiquidacionTrabajador.GTxD > 0 Or oeLiquidacionTrabajador.GTxM > 0 Then
                                                    .DebeMN = Math.Round(oeLiquidacionTrabajador.GTxD + oeLiquidacionTrabajador.GTxM - oeLiquidacionTrabajador.GTxF, 2)
                                                    .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                    .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1, True))
                                                End If
                                            Case "E" 'BONIFICACION EXTRAORDINARIA
                                                If oeLiquidacionTrabajador.BoniExtra > 0 Then
                                                    .DebeMN = Math.Round(oeLiquidacionTrabajador.BoniExtra, 2)
                                                    .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                    .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1, True))
                                                End If
                                            Case "F" 'CANTIDAD GRACIOSA
                                                If oeLiquidacionTrabajador.CantidadGraciosa > 0 Then
                                                    .DebeMN = Math.Round(oeLiquidacionTrabajador.CantidadGraciosa, 2)
                                                    .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                    .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1, True))
                                                End If
                                            Case "A" 'DIAS TRABAJADOS
                                                If oeLiquidacionTrabajador.DTxD > 0 Then
                                                    .DebeMN = Math.Round(oeLiquidacionTrabajador.DTxD + oeLiquidacionTrabajador.DTAsigFam - oeLiquidacionTrabajador.DTxF - oeLiquidacionTrabajador.DTEssaludVida - oeLiquidacionTrabajador.DTDsctoAFP, 2)
                                                    .DebeME = Math.Round(.DebeMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                    .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .DebeMN, 1, True))
                                                End If
                                        End Select
                                        If .DebeMN > 0 Then
                                            loAsientoMovimiento.Add(oeAsientoMovimiento)
                                        End If
                                    End With
                                Next

                                For Each asidet As e_DetalleAsientoModelo In oeLiquidacionTrabajador.oeAsientoModelo.leDetalle.Where(Function(i) i.Partida = 2).ToList
                                    oeAsientoMovimiento = New e_AsientoMovimiento
                                    With oeAsientoMovimiento
                                        .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                        .IdUsuarioCrea = oeLiquidacionTrabajador.UsuarioCreacion : .Activo = True : .Fila = asidet.Fila
                                        .IdCuentaContable = asidet.IdCuentaContable
                                        Select Case asidet.Fila
                                            Case "G" 'TOTAL A PAGAR
                                                If oeLiquidacionTrabajador.TotalPagar > 0 Then
                                                    .HaberMN = Math.Round(oeLiquidacionTrabajador.TotalPagar, 2)
                                                    .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                    '.MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 2))
                                                    .MovimientoCajaBanco = oeMovCajaBanco
                                                End If
                                            Case "I" 'ADELANTO DE SUELDO
                                                If oeLiquidacionTrabajador.AdelantoSueldo > 0 Then
                                                    .HaberMN = Math.Round(oeLiquidacionTrabajador.AdelantoSueldo, 2)
                                                    .HaberME = Math.Round(.HaberMN / oeLiquidacionTrabajador.TipoCambio, 2)
                                                    .MovimientoAnalisis.AddRange(ObtenerAnalisis(oeLiquidacionTrabajador, .HaberMN, 2))
                                                End If
                                        End Select
                                        If .HaberMN > 0 Then
                                            loAsientoMovimiento.Add(oeAsientoMovimiento)
                                        End If
                                    End With
                                Next
                                oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                                loAsiento.Add(oeAsiento)
                                If olAsiento.GuardarLista(loAsiento) Then
                                    TransScope.Complete()
                                Else
                                    Throw New Exception("No Se Completo la Transaccion")
                                End If
                            Else
                                TransScope.Complete()
                            End If
                        End If
                    End If
                End Using
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As Boolean Implements Il_LiquidacionTrabajador.Eliminar
        Try
            Return odLiquidacionTrabajador.Eliminar(oeLiquidacionTrabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerAnalisis(oeLiquidacionTrabajador As e_LiquidacionTrabajador, Monto As Double, Partida As Integer, Optional Pago As Boolean = False) As List(Of e_MovimientoAnalisis)
        Try
            Dim oeAsientoAnalisis As New e_MovimientoAnalisis
            Dim loMovimientoAnalisis As New List(Of e_MovimientoAnalisis)
            Dim TotalMovimiento As Double = Monto
            Dim Prorrateo As Double = 0
            Dim Indicador As Boolean = IIf(oeLiquidacionTrabajador.loPlacas.Count > 0, True, False)
            If Indicador Then Prorrateo = Math.Round(Monto / oeLiquidacionTrabajador.loPlacas.Count, 2)
            If Partida = 1 And Indicador Then
                For Each placa As e_Combo In oeLiquidacionTrabajador.loPlacas
                    oeAsientoAnalisis = New e_MovimientoAnalisis
                    oeAsientoAnalisis.TipoOperacion = ""
                    oeAsientoAnalisis.IdMoneda = "1CH01"
                    oeAsientoAnalisis.IdUsuarioCrea = oeLiquidacionTrabajador.UsuarioCreacion
                    If Pago = False Then
                        If Partida = 1 Then
                            oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                        Else
                            oeAsientoAnalisis.IdTrabajador = oeLiquidacionTrabajador.IdTrabajador
                        End If
                    Else
                        oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                        oeAsientoAnalisis.IdTrabajador = oeLiquidacionTrabajador.IdTrabajador
                    End If
                    oeAsientoAnalisis.Monto = Math.Round(Prorrateo, 2)
                    oeAsientoAnalisis.Saldo = Math.Round(Prorrateo, 2)
                    oeAsientoAnalisis.IdVehiculo = placa.Id
                    loMovimientoAnalisis.Add(oeAsientoAnalisis)
                Next
                Dim dif As Double = Monto - loMovimientoAnalisis.Sum(Function(i) i.Monto)
                If dif <> 0 Then
                    loMovimientoAnalisis.Item(0).Monto += Math.Round(dif, 2)
                End If
            Else
                oeAsientoAnalisis = New e_MovimientoAnalisis
                oeAsientoAnalisis.TipoOperacion = ""
                oeAsientoAnalisis.IdMoneda = "1CH01"
                oeAsientoAnalisis.IdUsuarioCrea = oeLiquidacionTrabajador.UsuarioCreacion
                If Pago = False Then
                    If Partida = 1 Then
                        oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                        oeAsientoAnalisis.IdVehiculo = "1SI000000059"
                    Else
                        oeAsientoAnalisis.IdTrabajador = oeLiquidacionTrabajador.IdTrabajador
                    End If
                Else
                    oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                    oeAsientoAnalisis.IdVehiculo = "1SI000000059"
                    oeAsientoAnalisis.IdTrabajador = oeLiquidacionTrabajador.IdTrabajador
                End If
                oeAsientoAnalisis.Monto = TotalMovimiento
                oeAsientoAnalisis.Saldo = TotalMovimiento
                loMovimientoAnalisis.Add(oeAsientoAnalisis)
            End If
            Return loMovimientoAnalisis
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
