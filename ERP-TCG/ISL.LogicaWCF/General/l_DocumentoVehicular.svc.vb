Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_DocumentoVehicular
    Implements Il_DocumentoVehicular

    Dim odDocumentoVehicular As New d_DocumentoVehicular
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeDocumentoVehicular As EntidadesWCF.e_DocumentoVehicular) As Boolean Implements Il_DocumentoVehicular.Eliminar
        Try
            Return odDocumentoVehicular.Eliminar(oeDocumentoVehicular)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoVehicular As EntidadesWCF.e_DocumentoVehicular) As Boolean Implements Il_DocumentoVehicular.Guardar
        Try
            If Validar(oeDocumentoVehicular) Then
                Return odDocumentoVehicular.Guardar(oeDocumentoVehicular)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarSeguro(ByVal oeDocumentoVehicular As EntidadesWCF.e_DocumentoVehicular) As Boolean Implements Il_DocumentoVehicular.GuardarSeguro
        Try
            If ValidarSeguro(oeDocumentoVehicular) Then
                Return odDocumentoVehicular.Guardar(oeDocumentoVehicular)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoVehicular As EntidadesWCF.e_DocumentoVehicular) As System.Collections.Generic.List(Of EntidadesWCF.e_DocumentoVehicular) Implements Il_DocumentoVehicular.Listar
        Try
            Return odDocumentoVehicular.Listar(oeDocumentoVehicular)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDts(ByVal oeDocVeh As EntidadesWCF.e_DocumentoVehicular) As System.Data.DataSet Implements Il_DocumentoVehicular.ListarDts
        Try
            Dim dts As New DataSet
            dts = odDocumentoVehicular.ListarDts(oeDocVeh)
            Return dts
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoVehicular As EntidadesWCF.e_DocumentoVehicular) As EntidadesWCF.e_DocumentoVehicular Implements Il_DocumentoVehicular.Obtener
        Try
            Return odDocumentoVehicular.Obtener(oeDocumentoVehicular)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDocumentoVehicular As EntidadesWCF.e_DocumentoVehicular) As Boolean Implements Il_DocumentoVehicular.Validar
        Try
            With oeDocumentoVehicular

                If .IdTipoDocumento = "1CH000000052" Then ''Certificado de Operatividad
                    If .Numero = "" Then Throw New Exception("Ingrese el número del certificado de operatividad.")
                    If .NroResolucion = "" Then Throw New Exception("Ingrese el N° de la partida registral")
                    If .Resultado = "" Then Throw New Exception("Ingrese el RD. de habilitación")
                    If .ldDetalleDocVeh.Where(Function(i) i.Activo = True And i.IdVehiculo <> "").Count = 0 Then Throw New Exception("Seleccione un vehícúlo para el Certifiado")
                End If

                If .IdTipoDocumento = "1CH000000050" Then ''Revisión Técnica
                    If .ldDetalleDocVeh.Where(Function(i) i.Activo = True And i.IdVehiculo <> "").Count = 0 Then Throw New Exception("Seleccione un vehícúlo para la Revisón")
                    If Trim(.IdEmpresaEmisora) = "" Then Throw New Exception("Especifique una empresa emisora")
                    If .Tipo = "" Then Throw New Exception("Especifique el Tipo de revisión técnica.")
                    If .Numero = "" Then Throw New Exception("Especifique el número del certificado")
                    If .Resultado = "" Then Throw New Exception("Especifique un resultado para la revisión técnica.")
                End If

                If .IdTipoDocumento = "1CH000000051" Then ''Tarjeta de Propiedad
                    If .ldDetalleDocVeh.Where(Function(i) i.Activo = True).Count = 0 Then Throw New Exception("Seleccione un vehícúlo para la Tarjeta de Propiedad")
                    If .ldDetalleDocVeh.Where(Function(i) i.Activo = True And i.IdVehiculo = "").Count > 0 Then Throw New Exception("Seleccione un vehículo para para la Tarjeta de Propiedad")
                    If .NroResolucion = "" Then Throw New Exception("Especifique el número de la partda registral")
                    If .Numero = "" Then Throw New Exception("Especifique elítulo")
                End If

                If .IdTipoDocumento = "1CH000000053" Then ''Bonificaciones Vehiculares
                    If .ldDetalleDocVeh.Where(Function(i) i.Activo = True).Count = 0 Then Throw New Exception("Debe seleccionar un vehículo válido")
                    If .ldDetalleDocVeh.Where(Function(i) i.Activo = True And i.IndTipoVehiculo = 0).Count > 0 Then Throw New Exception("Debe seleccionar un tipo de vehículo válido")
                    If .NroResolucion = "" Then Throw New Exception("Especifique el número de la resolución")
                    If Trim(.IdEmpresaEmisora) = "" Then Throw New Exception("Especifique una empresa emisora")
                    If Len(.IdEmpresaEmisora) <> 12 Then Throw New Exception("Especifique una empresa emisora válida")
                    l_FuncionesGenerales.ValidarNumeroDecimal(.Porcentaje, "Ingrese un porcentaje a la bonificación")
                    l_FuncionesGenerales.ValidarNumeroDecimal(.Peso, "Ingrese el peso bruto a la bonificación")
                    l_FuncionesGenerales.ValidarNumeroDecimal(.Bonificacion, "Ingrese el valor de la bonificación")
                End If

            End With

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarSeguro(ByVal oeDocumentoVehicular As EntidadesWCF.e_DocumentoVehicular) As Boolean Implements Il_DocumentoVehicular.ValidarSeguro
        Try
            With oeDocumentoVehicular
                l_FuncionesGenerales.ValidarCampoNoNulo(.Numero, "Debe ingresar numero de certificado")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoDocumento, "Seleccione un tipo documento")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdEmpresaEmisora, "Seleccione una empresa certificadoa")
                l_FuncionesGenerales.ValidarCampoNoNulo(.FechaEmision, "Ingrese una fecha de emisión valida")
                l_FuncionesGenerales.ValidarCampoNoNulo(.FechaVencimiento, "Ingrese una fecha de vencimiento valida")
                l_FuncionesGenerales.ValidarNumero(.Importe, "El importe debe ser mayor a 0.00")
                l_FuncionesGenerales.ValidarCampoNoNulo(Trim(.IdMoneda).ToString, "Especfique la moneda que se está usando")
                l_FuncionesGenerales.ValidarNumero(.ldDetalleDocVeh.Where(Function(item) item.Activo = True).Count, "Debe agregar vehículos al detalle")
                If (oeDocumentoVehicular.FechaEmision > oeDocumentoVehicular.FechaVencimiento) Then Throw New Exception("Fecha de emisión, no puede ser mayor que la fecha de vencimiento")

            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarProvisionPoliza(oeDocumentoVehicular As e_DocumentoVehicular, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean Implements Il_DocumentoVehicular.GuardarProvisionPoliza
        Try
            Dim leObliFinAux As New List(Of e_ObligacionFin), leAsiento As New List(Of e_Asiento)
            Dim oeAsiento As New e_Asiento, olAsiento As New l_Asiento, oeAsientoMov As New e_AsientoMovimiento
            Dim oeAsiMovObli As New e_AsientoMov_ObligacionFin, oeMovCajaBanco As New e_MovimientoCajaBanco, oeMovAnalisis As e_MovimientoAnalisis
            Dim olFunGen As New l_FuncionesGenerales
            Dim _MontoGen As Double = 0, _MontoNeg As Double = 0, _tc As Double = 0
            olFunGen.ValidarPeriodo(oeDocumentoVehicular.IdVehiculo, gAreasSGI.Contabilidad)

            Dim tiempo As New TimeSpan(0.25, 0, 0)
            Dim options As New TransactionOptions
            options.Timeout = tiempo

            Using TransScope As New TransactionScope(TransactionScopeOption.Required, options)
                _tc = oeDocumentoVehicular.Bonificacion
                For Each oeAsiMod In leAsientoModelo

                    If oeAsiMod.Moneda <> oeDocumentoVehicular.IdMoneda Then Continue For

                    _MontoGen = oeDocumentoVehicular.Importe
                    _MontoNeg = oeDocumentoVehicular.Importe
                    If _MontoNeg < 0 Then _MontoNeg = (_MontoNeg * -1) : _MontoGen = _MontoGen - _MontoNeg
                    oeAsiento = New e_Asiento
                    With oeAsiento
                        .TipoOperacion = "I" : .IdPeriodo = oeDocumentoVehicular.IdVehiculo : .IdTipoAsiento = oeAsiMod.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = oeDocumentoVehicular.FechaAdquisicion
                        .Glosa = oeDocumentoVehicular.EmpresaEmisora & " POLIZA " & oeDocumentoVehicular.Numero
                        .GlosaImprime = String.Empty
                        .IdMoneda = oeAsiMod.IdMoneda : .TipoCambio = oeDocumentoVehicular.Bonificacion
                        .TotalDebe = _MontoGen : .TotalHaber = _MontoGen : .IdentificaAsiento = "POLIZAVEHICULO" & oeAsiMod.Moneda
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeDocumentoVehicular.UsuarioCreacion : oeAsiento.Activo = True
                    End With
                    For Each oeAux In oeAsiMod.leDetalle.OrderBy(Function(it) it.Fila).ToList
                        If oeAux.Repetir = 0 Then
                            oeAsientoMov = New e_AsientoMovimiento
                            oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                            oeAsientoMov.Glosa = oeAsiento.Glosa
                            oeAsientoMov.IdUsuarioCrea = oeDocumentoVehicular.UsuarioCreacion : oeAsientoMov.Activo = True
                            If oeAux.Partida = 1 Then
                                oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                            Else
                                oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen, _MontoGen * _tc)
                                oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", _MontoGen / _tc, _MontoGen)
                            End If
                            oeMovAnalisis = New e_MovimientoAnalisis
                            oeMovAnalisis.TipoOperacion = "I" : oeMovAnalisis.Activo = True
                            oeMovAnalisis.IdGastoFuncion = "1CH000090"
                            oeMovAnalisis.Monto = _MontoGen
                            oeMovAnalisis.Saldo = _MontoGen
                            oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                            oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                        Else
                            If oeDocumentoVehicular.Importe > 0 Then
                                oeAsientoMov = New e_AsientoMovimiento
                                oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                oeAsientoMov.Glosa = oeAsiento.Glosa
                                oeAsientoMov.IdUsuarioCrea = oeDocumentoVehicular.UsuarioCreacion : oeAsientoMov.Activo = True
                                If oeAux.Partida = 1 Then
                                    oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", oeDocumentoVehicular.Importe, oeDocumentoVehicular.Importe * _tc)
                                    oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", oeDocumentoVehicular.Importe / _tc, oeDocumentoVehicular.Importe)
                                Else
                                    oeAsientoMov.HaberMN = IIf(oeAsiMod.Moneda = "SOLES", oeDocumentoVehicular.Importe, oeDocumentoVehicular.Importe * _tc)
                                    oeAsientoMov.HaberME = IIf(oeAsiMod.Moneda = "SOLES", oeDocumentoVehicular.Importe / _tc, oeDocumentoVehicular.Importe)
                                End If
                                '' Generar Asiento Movimiento Obligacion
                                'oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                'oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                'oeAsiMovObli.IdObligacionFinanciera = oeOAAux.Id
                                'oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            End If
                            If oeDocumentoVehicular.Importe < 0 Then
                                Dim _valor As Double = 0
                                _valor = oeDocumentoVehicular.Importe * -1
                                oeAsientoMov = New e_AsientoMovimiento
                                oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdCuentaContable = oeAux.IdCuentaContable
                                oeAsientoMov.Glosa = oeAsiento.Glosa
                                oeAsientoMov.IdUsuarioCrea = oeDocumentoVehicular.UsuarioCreacion : oeAsientoMov.Activo = True
                                oeAsientoMov.DebeMN = IIf(oeAsiMod.Moneda = "SOLES", _valor, _valor * _tc)
                                oeAsientoMov.DebeME = IIf(oeAsiMod.Moneda = "SOLES", _valor / _tc, _valor)
                                '' Generar Asiento Movimiento Obligacion
                                'oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                'oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                'oeAsiMovObli.IdObligacionFinanciera = oeOAAux.Id
                                'oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            End If

                            'For Each oeOAAux In leObliFinAux

                            'Next
                        End If
                    Next
                    leAsiento.Add(oeAsiento)
                Next
                If olAsiento.GuardarLista(leAsiento) Then
                    oeDocumentoVehicular.IdEmpresaPropietaria = leAsiento(0).Id
                    oeDocumentoVehicular.TipoOperacion = "P"
                    odDocumentoVehicular.Guardar2(oeDocumentoVehicular)

                    TransScope.Complete()
                    Return True
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
