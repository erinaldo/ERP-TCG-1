Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_Prestamo
    Implements Il_Prestamo

    Dim odPrestamo As New d_Prestamo
    Dim IslFuncion As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oePrestamo As EntidadesWCF.e_Prestamo) As Boolean Implements Il_Prestamo.Eliminar
        Try
            Return odPrestamo.Eliminar(oePrestamo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePrestamo As EntidadesWCF.e_Prestamo) As Boolean Implements Il_Prestamo.Guardar
        Try
            If Validar(oePrestamo) Then
                odPrestamo.Guardar(oePrestamo)
                If oePrestamo.TipoOperacion = "I" And oePrestamo.CtaBancaria.Id <> "" _
                And (oePrestamo.Concepto = "PRESTAMOS" Or oePrestamo.Concepto = "ADELANTOS") Then
                    'grabar asiento contable
                    'INGRESA ASIENTO DE INTEGRACION DE GRUPO DE DESCUENTOS QUE VIENE DE FONDO FIJO
                    Dim Glosa As String = ""
                    Dim lePrestamo As New List(Of e_Prestamo)
                    oePrestamo.FechaIntegracion = oePrestamo.Fecha
                    lePrestamo.Add(oePrestamo)
                    Dim oecta As New e_CuentaContable
                    Dim oeCajaBanco As New e_MovimientoCajaBanco
                    oeCajaBanco.TipoOperacion = "I"
                    oeCajaBanco._Operador = -1
                    oeCajaBanco.IdFlujoCaja = "1SI000000047"
                    oeCajaBanco.Fecha = oePrestamo.Fecha
                    'If oePrestamo.CtaBancaria.Id = "" Then
                    '    oeCajaBanco.IdMedioPago = "1CH03" 'efectivo
                    'Else
                    oeCajaBanco.IdMedioPago = "1CH02" 'deposito en cuenta
                    oeCajaBanco.IdCuentaBancaria = oePrestamo.CtaBancaria.Id
                    oeCajaBanco.NroBoucher = "0"
                    oecta.Id = oePrestamo.CtaBancaria.IdCuentaContable
                    oecta = oecta.Obtener(oecta)
                    'End If
                    Glosa = oePrestamo.Trabajador + " " + oePrestamo.Dni
                    oeCajaBanco.TotalMN = lePrestamo.Sum(Function(item As e_Prestamo) item.Monto)
                    ContabilizaPrestamos(lePrestamo, oePrestamo.oePeriodo, oeCajaBanco, _
                    oePrestamo.CtaBancaria.IdCuentaContable, oecta.MonedaExtrangera, Glosa)
                End If
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePrestamo As EntidadesWCF.e_Prestamo) As System.Collections.Generic.List(Of EntidadesWCF.e_Prestamo) Implements Il_Prestamo.Listar
        Try
            Return odPrestamo.Listar(oePrestamo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oePrestamo As EntidadesWCF.e_Prestamo) As EntidadesWCF.e_Prestamo Implements Il_Prestamo.Obtener
        Try
            Return odPrestamo.Obtener(oePrestamo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oePrestamo As EntidadesWCF.e_Prestamo) As Boolean Implements Il_Prestamo.Validar
        Try
            With oePrestamo
                IslFuncion.ValidarCampoNoNulo(.IdTrabajador, "Seleccione Trabajador")
                IslFuncion.ValidarCampoNoNulo(.IdConcepto, "Seleccione Concepto de Prestamo")
                IslFuncion.ValidarCampoNoNulo(.Glosa, "Seleccione Glosa")
                Dim _est = gEstadosSGI.APROBADA.ToString
                If oePrestamo.Estado = _est AndAlso .CantidadCuotas = 0 Then Throw New Exception("Ingrese Cantidad de Cuotas")
                If oePrestamo.Estado = _est AndAlso .CantidadCuotas > 0 Then
                    If .CantidadCuotas <> .leDetalle.Where(Function(it) it.Activo = True).Count Then
                        Throw New Exception("Deben de registrarse " & .CantidadCuotas & " cuotas de pago al prestamo")
                    End If
                End If
                'If oePrestamo.Estado = _est AndAlso .CantidadCuotas > 0 Then
                '    If .CantidadCuotas > .leDetalle.Where(Function(it) it.Activo = True).Count Then
                '        Throw New Exception("Ingrese las cuotas de pago al prestamo")
                '    End If
                'End If
                Dim _montoaux = Math.Round(.leDetalle.Where(Function(it) it.Activo = True).Sum(Function(it) it.Importe), 2)
                'If _montoaux > .Monto Then
                '    Throw New Exception("El total de importe de cuotas (" & _montoaux & ") es mayor al monto prestado (" & .Monto & ")" & _
                '                        Environment.NewLine & "Se recomienda modificar cuotas registradas")
                'End If
                If oePrestamo.Estado = _est Then
                    If _montoaux <> .Monto Then
                        Throw New Exception("El total de importe de cuotas (" & _montoaux & ") debe ser igual al monto prestado (" & .Monto & ")" & _
                                            Environment.NewLine & "Se recomienda modificar cuotas registradas")
                    End If
                End If
                'If .Monto = 0 Then Throw New Exception("Ingreso Monto a Prestamo")
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function GuardarLista(ByVal lePrestamo As System.Collections.Generic.List(Of EntidadesWCF.e_Prestamo), _
                                 ByVal IdGrupo As String, ByVal GrupoDesc As String, ByVal oePeriodo As e_Periodo, ByVal oeAsientoModel As e_AsientoModelo, _
                                 ByVal ls_GrupoSanc As String, ByVal ls_GrupoDesc As String) As Boolean Implements Il_Prestamo.GuardarLista
        Try
            Using TransScope As New TransactionScope()
                Dim oeAsiento As New e_Asiento, olAsiento As New l_Asiento, oeAsientoMov As New e_AsientoMovimiento
                Dim oeMovCajaBanco As New e_MovimientoCajaBanco, oeMovAnalisis As New e_MovimientoAnalisis
                Dim lsGlosa As String = "", _strDesc As String() = Nothing, _strSanc As String() = Nothing
                With oeAsiento
                    .TipoOperacion = "I" : .IdPeriodo = oePeriodo.Id
                    .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                    .NroAsiento = String.Empty : .Fecha = Date.Now.Date
                    If ls_GrupoDesc <> "" Then
                        _strDesc = ls_GrupoDesc.Split(",")
                        For i = 0 To _strDesc.Length - 1
                            lsGlosa = lsGlosa & _strDesc(i).Trim & " - "
                        Next
                    End If
                    If ls_GrupoSanc <> "" Then
                        _strSanc = ls_GrupoSanc.Split(",")
                        For j = 0 To _strSanc.Length - 1
                            lsGlosa = lsGlosa & _strSanc(j).Trim & " - "
                        Next
                    End If
                    .Glosa = oeAsientoModel.Nombre & ": " & lsGlosa.Substring(0, lsGlosa.Length - 3) : .GlosaImprime = String.Empty
                    .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeAsientoModel.TipoCambio
                    .TotalDebe = lePrestamo.Sum(Function(it) it.Monto) : .TotalHaber = lePrestamo.Sum(Function(it) it.Monto)
                    .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeAsientoModel.UsuarioCreacion : oeAsiento.Activo = True
                End With
                For Each oeDetAux In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila.Trim).ToList
                    If oeDetAux.Partida = 1 Then
                        Dim leDebAux = lePrestamo.Where(Function(it) it.IndProv = oeDetAux.Fila).ToList
                        If leDebAux.Count > 0 Then
                            oeAsientoMov = New e_AsientoMovimiento
                            With oeAsientoMov
                                .TipoOperacion = "I" : .IdCuentaContable = oeDetAux.IdCuentaContable.Trim
                                .Glosa = oeDetAux.Titulo & " MES " & oePeriodo.NomMes
                                .DebeMN = leDebAux.Sum(Function(it) it.Monto)
                                .DebeME = leDebAux.Sum(Function(it) it.Monto) / oeAsientoModel.TipoCambio
                                .HaberMN = 0 : .HaberME = 0
                                .IdUsuarioCrea = oeAsientoModel.UsuarioCreacion : .Activo = True : .AsMov_MovDoc = Nothing
                                For Each oeDetDebe In leDebAux
                                    oeMovAnalisis = New e_MovimientoAnalisis
                                    oeMovAnalisis.TipoOperacion = ""
                                    oeMovAnalisis.IdMoneda = oeAsientoModel.IdMoneda
                                    oeMovAnalisis.IdUsuarioCrea = oeAsientoModel.UsuarioCreacion
                                    oeMovAnalisis.Monto = oeDetDebe.Monto
                                    oeMovAnalisis.Saldo = oeDetDebe.Monto
                                    oeMovAnalisis.IdTrabajador = oeDetDebe.IdTrabajador
                                    oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                Next
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            End With
                        End If
                    Else
                        Dim CadFil() As String = oeDetAux.Formula.Split("+")
                        Dim MontoHaberAux As Double = 0
                        For i = 0 To CadFil.Length - 1
                            Dim leHaberAux = lePrestamo.Where(Function(it) it.IndProv = CadFil(i))
                            If leHaberAux.Count > 0 Then MontoHaberAux = MontoHaberAux + leHaberAux.Sum(Function(it) it.Monto)
                        Next
                        If MontoHaberAux > 0 Then
                            oeAsientoMov = New e_AsientoMovimiento
                            With oeAsientoMov
                                .TipoOperacion = "I" : .IdCuentaContable = oeDetAux.IdCuentaContable.Trim
                                .Glosa = oeDetAux.Titulo & " MES " & oePeriodo.NomMes
                                .DebeMN = 0 : .DebeME = 0
                                .HaberMN = MontoHaberAux : .HaberME = MontoHaberAux / oeAsientoModel.TipoCambio
                                .IdUsuarioCrea = oeAsientoModel.UsuarioCreacion : .Activo = True : .AsMov_MovDoc = Nothing
                                'Llenar Movimiento Caja Banco para las Cuentas Configuradas por Flujo de Caja
                                If oeDetAux.IdReferencia.Trim.Length > 0 Then
                                    oeMovCajaBanco = New e_MovimientoCajaBanco
                                    oeMovCajaBanco.TipoOperacion = "I" : oeMovCajaBanco._Operador = -1
                                    oeMovCajaBanco.IdFlujoCaja = oeDetAux.IdReferencia : oeMovCajaBanco.Fecha = Date.Now
                                    oeMovCajaBanco.TotalMN = MontoHaberAux
                                    oeMovCajaBanco.TotalME = MontoHaberAux / oeAsientoModel.TipoCambio
                                    oeMovCajaBanco.IdMedioPago = oeAsientoModel.IdMedioPago
                                    .MovimientoCajaBanco = oeMovCajaBanco
                                End If
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            End With
                        End If
                    End If
                Next
                If odPrestamo.GuardarLista(lePrestamo, IdGrupo, GrupoDesc) Then
                    olAsiento.GuardarAsientoDscto(oeAsiento)
                    TransScope.Complete()
                    Return True
                End If
                'Dim lePrestDesc As New List(Of e_Prestamo), lePrestSanc As New List(Of e_Prestamo)
                'Dim lsGlosa As String = "", _strDesc As String() = Nothing, _strSanc As String() = Nothing
                'If ls_GrupoDesc <> "" Then
                '    lePrestDesc = lePrestamo.Where(Function(it) it.IdConcepto <> "1SI000003").ToList
                '    _strDesc = ls_GrupoDesc.Split(",")
                '    For i = 0 To _strDesc.Length - 1
                '        lsGlosa = lsGlosa + "/" + _strDesc(i).Trim
                '    Next
                '    Dim oeCajaBanco As New e_MovimientoCajaBanco
                '    oeCajaBanco.TipoOperacion = "I" : oeCajaBanco._Operador = -1 : oeCajaBanco.IdFlujoCaja = "1CH000000187"
                '    oeCajaBanco.Fecha = Date.Now : oeCajaBanco.IdMedioPago = "1CH03" 'efectivo
                '    oeCajaBanco.TotalMN = lePrestDesc.Sum(Function(item As e_Prestamo) item.Monto)
                '    Dim oeTCD As New e_TablaContableDet : Dim odTCD As New d_TablaContableDet
                '    oeTCD.TipoOperacion = "N" : oeTCD.Activo = True : oeTCD.Nombre = "CUENTAS GENERALES"
                '    oeTCD.Valor1 = Date.Now.Date.Year : oeTCD.Texto1 = "CTAFONDOFIJOSOLES"
                '    oeTCD = odTCD.Listar(oeTCD)(0)
                '    ContabilizaPrestamos(lePrestDesc, oePeriodo, oeCajaBanco, oeTCD.Texto2, 0, lsGlosa)
                'End If
                'If ls_GrupoSanc <> "" Then
                '    lePrestSanc = lePrestamo.Where(Function(it) it.IdConcepto = "1SI000003").ToList
                '    _strSanc = ls_GrupoSanc.Split(",")
                '    For j = 0 To _strSanc.Length - 1
                '        lsGlosa = lsGlosa + "/" + _strSanc(j).Trim
                '    Next
                'End If
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Function ContabilizaPrestamos(ByVal lePrestamo As System.Collections.Generic.List(Of EntidadesWCF.e_Prestamo), _
      ByVal oePeriodo As e_Periodo, ByVal oeCajaBanco As e_MovimientoCajaBanco, ByVal lsIdCta As String, _
      ByVal IndMonedaExtrangera As Integer, ByVal lsGlosa As String) As Boolean
        Try

            Dim olTipoCambio As New l_TipoCambio, oeTipoCambio As New e_TipoCambio
            oeTipoCambio.TipoOperacion = "U" : oeTipoCambio.FechaCambio = Date.Now.Date
            oeTipoCambio = olTipoCambio.Listar(oeTipoCambio)(0)

            Dim olAsiento As New l_Asiento, oeAsiento As New e_Asiento
            Dim lsCodigoBanco As String
            oeCajaBanco.TotalME = oeCajaBanco.TotalMN / oeTipoCambio.CambioVenta

            lsCodigoBanco = olAsiento.IntegracionPrestamosProvision(lePrestamo, oePeriodo, _
           lePrestamo(0).UsuarioCreacion, oeTipoCambio.CambioVenta, lsIdCta, oeCajaBanco, IndMonedaExtrangera, lsGlosa)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ListarDS(ByVal oePrestamo As EntidadesWCF.e_Prestamo) As System.Data.DataSet Implements Il_Prestamo.ListarDS
        Try
            Return odPrestamo.ListarDS(oePrestamo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarRDT(ByVal oeRDT As EntidadesWCF.e_ReporteDescTrabajador) As System.Collections.Generic.List(Of EntidadesWCF.e_ReporteDescTrabajador) Implements Il_Prestamo.ListarRDT
        Try
            Return odPrestamo.ListarRDT(oeRDT)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Liquidar(ByVal lePrestamo As System.Collections.Generic.List(Of EntidadesWCF.e_Prestamo)) As Boolean Implements Il_Prestamo.Liquidar
        Try
            Return odPrestamo.Liquidar(lePrestamo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CobrarCuota(leCargoPendiente As List(Of e_Prestamo), _
                                leCuotaCargoPend As List(Of e_PrestamoDetalle), _
                                IndLiquidacion As Boolean, _
                                oeAsientoModel As e_AsientoModelo) As Boolean Implements Il_Prestamo.CobrarCuota
        Try
            Return odPrestamo.CobrarCuota(leCargoPendiente, leCuotaCargoPend)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista2(leDscto As List(Of e_Prestamo)) As Boolean Implements Il_Prestamo.GuardarLista2
        Try
            Return odPrestamo.GuardarLista2(leDscto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function TransferirDeuda(oePrestamo As e_Prestamo, oePrestamoTrans As e_Prestamo) As Boolean Implements Il_Prestamo.TransferirDeuda
        Try
            Return odPrestamo.TransferirDeuda(oePrestamo, oePrestamoTrans)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
