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
Imports ERP.ServicioExterno



<DataContract(), Serializable()> _
Public Class l_MovimientoDocumento
    Implements Il_MovimientoDocumento

    Dim odMovimientoDocumento As New d_MovimientoDocumento
    Dim l_FuncionesGenerales As New l_FuncionesGenerales
    Dim sFacturacionElectronica As New s_Facturacion


    Dim oeCuentaGenerales As New e_TablaContableDet
    Dim leCuentasGenerales As New List(Of e_TablaContableDet)
    Dim olFuncionesGenerales As New l_FuncionesGenerales
    Dim oePeriodo As New e_Periodo
    Dim olPeriodo As New l_Periodo

    Private oeAlmacen As New e_Almacen, olAlmacen As New l_Almacen, leAlmacen As New List(Of e_Almacen)

    ''' <summary>
    ''' Ajusta en moneda soles operacione en dolares
    ''' </summary>
    ''' <param name="TipoOperacion"></param>
    ''' <param name="oePeriodo"></param>
    ''' <param name="leMovimientoDocumento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 

    Public Function AjusteTipoCambio(ByVal TipoOperacion As String, ByVal oePeriodo As e_Periodo, _
    ByVal leMovimientoDocumento As System.Collections.Generic.List(Of e_MovimientoDocumento)) As Boolean Implements Il_MovimientoDocumento.AjusteTipoCambio
        Try
            Dim lsCtaPerdida As String = ""
            Dim lsCtaGanancia As String = ""
            For Each oeMovDoc As e_MovimientoDocumento In leMovimientoDocumento
                Dim oeMovimientoDocumento As New e_MovimientoDocumento
                oeMovimientoDocumento = Me.Obtener(oeMovDoc)
                If oeMovimientoDocumento.IdMoneda <> "1CH01" Then 'Verificar Si es moneda extrajera 
                    If oeMovimientoDocumento.Saldo < 0.01 Or oeMovimientoDocumento.Saldo > -0.01 Then ' Se hace ajuste solo a cuentas sin saldo
                        Dim ds As DataSet
                        ds = odMovimientoDocumento.ObtenerAJusteTipoCambio(TipoOperacion, oeMovimientoDocumento.Id, "", oePeriodo.Ejercicio) 'obtener datos de proc almacenado
                        'Obtener la diferencia entre Debe y Haber en soles y la asigna a una variable
                        If ds.Tables.Count > 0 Then ' Verificar si el DataTable contiene datos
                            If ds.Tables(0).Rows.Count > 0 Then
                                Dim Desajuste As Decimal = ds.Tables(0).Rows(0).Item("MN") 'Obtener valor absoluto

                                If Math.Round(Desajuste, 2) <> 0 Then 'Comparar si existe desajuste

                                    Dim olAsiento As New l_Asiento 'Crear objeto asiento
                                    Dim oeAsiento As New e_Asiento
                                    Dim CLienteProveedor As String = ""
                                    If TipoOperacion = "COB" Then ' Si es tipo Operacion Cobro consulta Cliente
                                        Dim oeCliente As New e_Cliente 'Para obtener nombre de empresa a partir del id Empresa
                                        Dim olCLiente As New l_Cliente 'Para obtener nombre de empresa a partir del id Empresa
                                        oeCliente.Id = oeMovimientoDocumento.IdClienteProveedor ' Asigno Id al objeto empresa
                                        CLienteProveedor = olCLiente.Obtener(oeCliente).Nombre

                                    ElseIf TipoOperacion = "PAG" Then  ' Si es tipo Operacion Cobro consulta Proveedor
                                        Dim oeProveedor As New e_Proveedor 'Para obtener nombre de empresa a partir del id Empresa
                                        Dim olProveedor As New l_Proveedor 'Para obtener nombre de empresa a partir del id Empresa
                                        oeProveedor.Id = oeMovimientoDocumento.IdClienteProveedor ' Asigno Id al objeto empresa
                                        CLienteProveedor = olProveedor.Obtener(oeProveedor).Nombre
                                    End If

                                    Dim oeMovAnalisis As New e_MovimientoAnalisis

                                    Dim oeAsMov1 As New e_AsientoMovimiento 'Linea1
                                    Dim oeAsMov2 As New e_AsientoMovimiento 'Linea2

                                    'Dim oePeriodo As New e_Periodo 'Para obtener ejercicio y mes de Periodo a partir del idPeriodo
                                    'oePeriodo.Id = IdPeriodo
                                    Dim olPeriodo As New l_Periodo 'Para obtener ejercicio y mes de Periodo a partir del idPeriodo
                                    oePeriodo = olPeriodo.Obtener(oePeriodo)  'Obtener Ejercicio del Periodo a partir del idPeriodo
                                    Dim Ejercicio As Integer = oePeriodo.Ejercicio
                                    Dim mes As Integer = oePeriodo.Mes  'Obtener Mes del Periodo a partir del idPeriodo


                                    Dim olTipoCambio As New l_TipoCambio 'Para obtener el ultimo tipo de cambio
                                    Dim oeTipoCambio As New e_TipoCambio 'Para obtener el ultimo tipo de cambio
                                    oeTipoCambio.TipoOperacion = "U" 'Para obtener el ultimo tipo de cambio


                                    oeAsiento.Id = ""
                                    oeAsiento.IdPeriodo = oePeriodo.Id
                                    oeAsiento.IdTipoAsiento = "DIARIO" 'Diario
                                    'oeAsiento.IdTipoAsiento = "1CH000020" 'Diario
                                    oeAsiento.NroAsiento = ""
                                    oeAsiento.Fecha = oePeriodo.FechaFin 'Ultimo dia del mes del periodo
                                    'oeAsiento.Fecha = Convert.ToDateTime(Ejercicio + " - " + mes + " - " + Day(DateSerial(Ejercicio, mes + 1, 0))) 'Ultimo dia del mes del periodo
                                    oeAsiento.IdMoneda = "1CH01" 'Soles
                                    oeAsiento.TipoCambio = olTipoCambio.Obtener(oeTipoCambio).CambioCompra 'Operacion en soles , se le asigna el ultimo tipo de cambio
                                    oeAsiento.TotalDebe = Math.Abs(Desajuste) 'Asignar Total Debe y Total Haber al asiento
                                    oeAsiento.TotalHaber = Math.Abs(Desajuste) 'Asignar Total Debe y Total Haber al asiento
                                    oeAsiento.IdUsuarioBloquea = ""
                                    oeAsiento.IdUsuarioCrea = oePeriodo.IdUsuario     'IdUsuariocrea ' Parametro de funcion
                                    oeAsiento.IdEstado = "CUADRADO" 'cuadrado
                                    oeAsiento.IdAsientoExtorno = ""
                                    oeAsiento.FechaCreacion = Date.Now
                                    oeAsiento.Activo = True
                                    oeAsiento.TipoOperacion = "I" 'Registro nuevo Insertar


                                    Dim lbGanancia As Boolean = False
                                    Dim lbPerdida As Boolean = False

                                    'ds = odMovimientoDocumento.ObtenerAJusteTipoCambio(TipoOperacion, oeMovimientoDocumento.Id) 'Obtener cuenta inicial compra o venta

                                    Dim idcuenta As String = "0"
                                    If ds.Tables(0).Rows.Count > 0 Then
                                        idcuenta = ds.Tables(0).Rows(0).Item("IdCuentaContable")
                                    End If

                                    If TipoOperacion = "COB" Then 'Tipo Cobro
                                        If Desajuste < 0 Then
                                            oeAsiento.Glosa = "ASIENTO DE GANANCIA /" & oeMovimientoDocumento.AbreviaturaMoneda & "-" & oeMovimientoDocumento.Serie & oeMovimientoDocumento.Numero & " " & CLienteProveedor 'Se pago menos en soles
                                            oeAsiento.GlosaImprime = oeAsiento.Glosa
                                            oeAsMov1.Glosa = oeAsiento.Glosa
                                            oeAsMov2.Glosa = oeAsiento.Glosa
                                            'Linea 1
                                            oeAsMov1.IdCuentaContable = idcuenta 'Obtener cuenta contable Inicial
                                            oeAsMov1.DebeMN = Math.Abs(Desajuste)
                                            'Tabla(relacion)
                                            oeAsMov1.AsMov_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                                            oeAsMov1.AsMov_MovDoc.Activo = True 'Estado Activo
                                            oeAsMov1.AsMov_MovDoc.TipoOperacion = "I" 'Insertar
                                            'Linea 2
                                            CtaGananciaPerdida(lsCtaGanancia, True, oePeriodo.Ejercicio)
                                            oeAsMov2.IdCuentaContable = lsCtaGanancia '"1CH002556" 'Id de Cuenta 77611  - Cuenta de Ganancia
                                            oeAsMov2.HaberMN = Math.Abs(Desajuste)

                                            oeAsMov2.AsMov_MovDoc = Nothing ' La cabecera no genera relacion

                                        ElseIf Desajuste > 0 Then

                                            oeAsiento.Glosa = "ASIENTO DE PERDIDA /" & oeMovimientoDocumento.AbreviaturaMoneda & "-" & oeMovimientoDocumento.Serie & oeMovimientoDocumento.Numero & " " & CLienteProveedor
                                            oeAsiento.GlosaImprime = oeAsiento.Glosa
                                            oeAsMov1.Glosa = oeAsiento.Glosa
                                            oeAsMov2.Glosa = oeAsiento.Glosa
                                            'Linea 1
                                            CtaGananciaPerdida(lsCtaPerdida, False, oePeriodo.Ejercicio)
                                            oeAsMov1.IdCuentaContable = lsCtaPerdida '"1CH002069" 'Id de Cuenta 67611  - Cuenta de Perdida
                                            oeAsMov1.DebeMN = Math.Abs(Desajuste)

                                            oeAsMov1.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                                            oeMovAnalisis = New e_MovimientoAnalisis
                                            oeMovAnalisis.TipoOperacion = "I"
                                            oeMovAnalisis.IdGastoFuncion = "1CH000090" '---------gasto financiero
                                            oeMovAnalisis.Monto = Math.Abs(Desajuste)
                                            oeMovAnalisis.Saldo = oeMovAnalisis.Monto
                                            oeAsMov1.MovimientoAnalisis.Add(oeMovAnalisis)
                                            oeAsMov1.AsMov_MovDoc = Nothing ' La cabecera no genera relacion

                                            'Linea 2
                                            oeAsMov2.IdCuentaContable = idcuenta 'Obtener cuenta contable Inicial
                                            oeAsMov2.HaberMN = Math.Abs(Desajuste)
                                            'Tabla(relacion)
                                            oeAsMov2.AsMov_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                                            oeAsMov2.AsMov_MovDoc.Activo = True 'Estado Activo
                                            oeAsMov2.AsMov_MovDoc.TipoOperacion = "I" 'Insertar
                                            lbPerdida = True

                                        End If
                                    End If

                                    If TipoOperacion = "PAG" Then 'Tipo Pago
                                        If Desajuste < 0 Then
                                            oeAsiento.Glosa = "ASIENTO DE GANANCIA /" & oeMovimientoDocumento.AbreviaturaMoneda & "-" & oeMovimientoDocumento.Serie & oeMovimientoDocumento.Numero & " " & CLienteProveedor 'Se PAGO mas en soles
                                            oeAsiento.GlosaImprime = oeAsiento.Glosa
                                            oeAsMov1.Glosa = oeAsiento.Glosa
                                            oeAsMov2.Glosa = oeAsiento.Glosa 'Glosa
                                            'Linea 1
                                            CtaGananciaPerdida(lsCtaGanancia, True, oePeriodo.Ejercicio)
                                            oeAsMov1.IdCuentaContable = lsCtaGanancia '"1CH002556" 'Id de Cuenta 77611  - Cuenta de Ganancia 
                                            oeAsMov1.HaberMN = Math.Abs(Desajuste)
                                            oeAsMov1.AsMov_MovDoc = Nothing ' La cabecera no genera relacion
                                            'Linea 2
                                            oeAsMov2.IdCuentaContable = idcuenta 'Obtener cuenta contable Inicial
                                            oeAsMov2.DebeMN = Math.Abs(Desajuste)
                                            oeAsMov2.AsMov_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                                            oeAsMov2.AsMov_MovDoc.Activo = True 'Estado Activo
                                            oeAsMov2.AsMov_MovDoc.TipoOperacion = "I" 'Insertar
                                            lbGanancia = True
                                        ElseIf Desajuste > 0 Then
                                            oeAsiento.Glosa = "ASIENTO DE PERDIDA /" & oeMovimientoDocumento.AbreviaturaMoneda & "-" & oeMovimientoDocumento.Serie & oeMovimientoDocumento.Numero & " " & CLienteProveedor
                                            oeAsiento.GlosaImprime = oeAsiento.Glosa
                                            oeAsMov1.Glosa = oeAsiento.Glosa
                                            oeAsMov2.Glosa = oeAsiento.Glosa
                                            'Linea 1
                                            oeAsMov1.IdCuentaContable = idcuenta 'Obtener cuenta contable Inicial
                                            oeAsMov1.HaberMN = Math.Abs(Desajuste)
                                            oeAsMov1.AsMov_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                                            oeAsMov1.AsMov_MovDoc.Activo = True 'Estado Activo
                                            oeAsMov1.AsMov_MovDoc.TipoOperacion = "I" 'Insertar
                                            'Linea 2
                                            CtaGananciaPerdida(lsCtaPerdida, False, oePeriodo.Ejercicio)
                                            oeAsMov2.IdCuentaContable = lsCtaPerdida '"1CH002069" 'Id de Cuenta 67611  - Cuenta de Perdida
                                            oeAsMov2.DebeMN = Math.Abs(Desajuste)
                                            oeAsMov2.AsMov_MovDoc = Nothing ' La cabecera no genera relacion

                                            oeAsMov2.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                                            oeMovAnalisis = New e_MovimientoAnalisis
                                            oeMovAnalisis.TipoOperacion = "I"
                                            oeMovAnalisis.IdGastoFuncion = "1CH000090" '---------gasto financiero
                                            oeMovAnalisis.Monto = Math.Abs(Desajuste)
                                            oeMovAnalisis.Saldo = oeMovAnalisis.Monto
                                            oeAsMov2.MovimientoAnalisis.Add(oeMovAnalisis)

                                            lbPerdida = True
                                        End If
                                    End If

                                    'Llenar Objeto Asiento Movimiento(tabla AsientoMovimiento) Linea1 y linea 1
                                    oeAsMov1.IdUsuarioCrea = oePeriodo.IdUsuario   'IdUsuariocrea  'Id del usuario que crea el asiento de ajuste
                                    oeAsMov2.IdUsuarioCrea = oePeriodo.IdUsuario   'IdUsuariocrea
                                    oeAsMov1.FechaCreacion = Date.Now  'Fecha Actual
                                    oeAsMov2.FechaCreacion = Date.Now  'Fecha Actual
                                    oeAsMov1.Activo = True 'Estado Activo
                                    oeAsMov2.Activo = True
                                    oeAsMov1.TipoOperacion = "I" 'Tipo de Operacion
                                    oeAsMov2.TipoOperacion = "I"

                                    'Asignar Linea 12 a Objeto Asiento
                                    oeAsiento.AsientoMovimiento.Add(oeAsMov1)
                                    oeAsiento.AsientoMovimiento.Add(oeAsMov2)

                                    olAsiento.Guardar(oeAsiento) 'GUARDAR DATOS
                                Else
                                    Return False ' Si no es necesario Ajuste de tipo de cambio , no realiza operaciones
                                End If
                            End If
                        End If
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function AjusteTipoCambioObligacion(ByVal TipoOperacion As String, ByVal oePeriodo As e_Periodo, _
    ByVal leMovimientoDocumento As System.Collections.Generic.List(Of e_ObligacionFinanciera), _
    ByVal IdUsuariocrea As String) As Boolean Implements Il_MovimientoDocumento.AjusteTipoCambioObligacion
        Try
            Dim lsCtaPerdida As String = ""
            Dim lsCtaGanancia As String = ""
            For Each oeMovDoc As e_ObligacionFinanciera In leMovimientoDocumento
                Dim oeMovimientoDocumento As New e_ObligacionFinanciera
                Dim odObligacion As New d_ObligacionFinanciera
                oeMovimientoDocumento = odObligacion.Obtener(oeMovDoc)
                If oeMovimientoDocumento.IdMoneda <> "1CH01" Then 'Verificar Si es moneda extrajera 
                    If oeMovimientoDocumento.Saldo = 0 Then ' Se hace ajuste solo a cuentas sin saldo
                        Dim ds As DataSet
                        ds = odMovimientoDocumento.ObtenerAJusteTipoCambio("OBL", oeMovimientoDocumento.Id, "", oePeriodo.Ejercicio) 'obtener datos de proc almacenado
                        'Obtener la diferencia entre Debe y Haber en soles y la asigna a una variable
                        If ds.Tables.Count > 0 Then ' Verificar si el DataTable contiene datos
                            If ds.Tables(0).Rows.Count > 0 Then
                                Dim Desajuste As Decimal = ds.Tables(0).Rows(0).Item("MN") 'Obtener valor absoluto

                                If Math.Round(Desajuste, 2) <> 0 Then 'Comparar si existe desajuste

                                    Dim olAsiento As New l_Asiento 'Crear objeto asiento
                                    Dim oeAsiento As New e_Asiento
                                    Dim CLienteProveedor As String = ""
                                    If TipoOperacion = "COB" Then ' Si es tipo Operacion Cobro consulta Cliente
                                        Dim oeCliente As New e_Cliente 'Para obtener nombre de empresa a partir del id Empresa
                                        Dim olCLiente As New l_Cliente 'Para obtener nombre de empresa a partir del id Empresa
                                        oeCliente.Id = oeMovimientoDocumento.IdClienteProveedor ' Asigno Id al objeto empresa
                                        CLienteProveedor = olCLiente.Obtener(oeCliente).Nombre

                                    ElseIf TipoOperacion = "PAG" Then  ' Si es tipo Operacion Cobro consulta Proveedor
                                        Dim oeProveedor As New e_Proveedor 'Para obtener nombre de empresa a partir del id Empresa
                                        Dim olProveedor As New l_Proveedor 'Para obtener nombre de empresa a partir del id Empresa
                                        oeProveedor.Id = oeMovimientoDocumento.IdClienteProveedor ' Asigno Id al objeto empresa
                                        CLienteProveedor = olProveedor.Obtener(oeProveedor).Nombre
                                    End If

                                    Dim oeMovAnalisis As New e_MovimientoAnalisis

                                    Dim oeAsMov1 As New e_AsientoMovimiento 'Linea1
                                    Dim oeAsMov2 As New e_AsientoMovimiento 'Linea2

                                    'Dim oePeriodo As New e_Periodo 'Para obtener ejercicio y mes de Periodo a partir del idPeriodo
                                    'oePeriodo.Id = IdPeriodo
                                    Dim olPeriodo As New l_Periodo 'Para obtener ejercicio y mes de Periodo a partir del idPeriodo
                                    oePeriodo = olPeriodo.Obtener(oePeriodo)  'Obtener Ejercicio del Periodo a partir del idPeriodo
                                    Dim Ejercicio As Integer = oePeriodo.Ejercicio
                                    Dim mes As Integer = oePeriodo.Mes  'Obtener Mes del Periodo a partir del idPeriodo


                                    Dim olTipoCambio As New l_TipoCambio 'Para obtener el ultimo tipo de cambio
                                    Dim oeTipoCambio As New e_TipoCambio 'Para obtener el ultimo tipo de cambio
                                    oeTipoCambio.TipoOperacion = "U" 'Para obtener el ultimo tipo de cambio


                                    oeAsiento.Id = ""
                                    oeAsiento.IdPeriodo = oePeriodo.Id
                                    oeAsiento.IdTipoAsiento = "DIARIO" 'Diario
                                    'oeAsiento.IdTipoAsiento = "1CH000020" 'Diario
                                    oeAsiento.NroAsiento = ""
                                    oeAsiento.Fecha = oePeriodo.FechaFin 'Ultimo dia del mes del periodo
                                    'oeAsiento.Fecha = Convert.ToDateTime(Ejercicio + " - " + mes + " - " + Day(DateSerial(Ejercicio, mes + 1, 0))) 'Ultimo dia del mes del periodo
                                    oeAsiento.IdMoneda = "1CH01" 'Soles
                                    oeAsiento.TipoCambio = olTipoCambio.Obtener(oeTipoCambio).CambioCompra 'Operacion en soles , se le asigna el ultimo tipo de cambio
                                    oeAsiento.TotalDebe = Math.Abs(Desajuste) 'Asignar Total Debe y Total Haber al asiento
                                    oeAsiento.TotalHaber = Math.Abs(Desajuste) 'Asignar Total Debe y Total Haber al asiento
                                    oeAsiento.IdUsuarioBloquea = ""
                                    oeAsiento.IdUsuarioCrea = IdUsuariocrea ' Parametro de funcion
                                    oeAsiento.IdEstado = "CUADRADO" 'cuadrado
                                    oeAsiento.IdAsientoExtorno = ""
                                    oeAsiento.FechaCreacion = Date.Now
                                    oeAsiento.Activo = True
                                    oeAsiento.TipoOperacion = "I" 'Registro nuevo Insertar

                                    Dim lbGanancia As Boolean = False
                                    Dim lbPerdida As Boolean = False

                                    'ds = odMovimientoDocumento.ObtenerAJusteTipoCambio(TipoOperacion, oeMovimientoDocumento.Id) 'Obtener cuenta inicial compra o venta

                                    Dim idcuenta As String = "0"
                                    If ds.Tables(0).Rows.Count > 0 Then
                                        idcuenta = ds.Tables(0).Rows(0).Item("IdCuentaContable")
                                    End If

                                    If TipoOperacion = "COB" Then 'Tipo Cobro
                                        If Desajuste < 0 Then
                                            oeAsiento.Glosa = "ASIENTO DE GANANCIA /" & oeMovimientoDocumento.Codigo & " " & CLienteProveedor 'Se pago menos en soles
                                            oeAsiento.GlosaImprime = oeAsiento.Glosa
                                            oeAsMov1.Glosa = oeAsiento.Glosa
                                            oeAsMov2.Glosa = oeAsiento.Glosa
                                            'Linea 1
                                            oeAsMov1.IdCuentaContable = idcuenta 'Obtener cuenta contable Inicial
                                            oeAsMov1.DebeMN = Math.Abs(Desajuste)
                                            'Tabla(relacion)
                                            oeAsMov1.AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                                            oeAsMov1.AsMov_ObligacionFin.IdObligacionFinanciera = oeMovimientoDocumento.Id
                                            oeAsMov1.AsMov_ObligacionFin.Activo = True 'Estado Activo
                                            oeAsMov1.AsMov_ObligacionFin.TipoOperacion = "I" 'Insertar
                                            'Linea 2
                                            CtaGananciaPerdida(lsCtaGanancia, True, oePeriodo.Ejercicio)
                                            oeAsMov2.IdCuentaContable = lsCtaGanancia '"1CH002556" 'Id de Cuenta 77611  - Cuenta de Ganancia
                                            oeAsMov2.HaberMN = Math.Abs(Desajuste)
                                            oeAsMov2.AsMov_ObligacionFin = Nothing ' La cabecera no genera relacion

                                        ElseIf Desajuste > 0 Then

                                            oeAsiento.Glosa = "ASIENTO DE PERDIDA " & oeMovimientoDocumento.Codigo & " " & CLienteProveedor
                                            oeAsiento.GlosaImprime = oeAsiento.Glosa
                                            oeAsMov1.Glosa = oeAsiento.Glosa
                                            oeAsMov2.Glosa = oeAsiento.Glosa
                                            'Linea 1
                                            CtaGananciaPerdida(lsCtaPerdida, False, oePeriodo.Ejercicio)
                                            oeAsMov1.IdCuentaContable = lsCtaPerdida '"1CH002069" 'Id de Cuenta 67611  - Cuenta de Perdida
                                            oeAsMov1.DebeMN = Math.Abs(Desajuste)

                                            oeAsMov1.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                                            oeMovAnalisis = New e_MovimientoAnalisis
                                            oeMovAnalisis.TipoOperacion = "I"
                                            oeMovAnalisis.IdGastoFuncion = "1CH000090" '---------gasto financiero
                                            oeMovAnalisis.Monto = Math.Abs(Desajuste)
                                            oeMovAnalisis.Saldo = oeMovAnalisis.Monto
                                            oeAsMov1.MovimientoAnalisis.Add(oeMovAnalisis)
                                            oeAsMov1.AsMov_ObligacionFin = Nothing ' La cabecera no genera relacion
                                            'Linea 2
                                            oeAsMov2.IdCuentaContable = idcuenta 'Obtener cuenta contable Inicial
                                            oeAsMov2.HaberMN = Math.Abs(Desajuste)
                                            'Tabla(relacion)
                                            oeAsMov2.AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                                            oeAsMov2.AsMov_ObligacionFin.IdObligacionFinanciera = oeMovimientoDocumento.Id
                                            oeAsMov2.AsMov_ObligacionFin.Activo = True 'Estado Activo
                                            oeAsMov2.AsMov_ObligacionFin.TipoOperacion = "I" 'Insertar
                                            lbPerdida = True

                                        End If
                                    End If

                                    If TipoOperacion = "PAG" Then 'Tipo Pago
                                        If Desajuste < 0 Then
                                            oeAsiento.Glosa = "ASIENTO DE GANANCIA " & oeMovimientoDocumento.Codigo & " " & CLienteProveedor 'Se Cobro mas en soles
                                            oeAsiento.GlosaImprime = oeAsiento.Glosa
                                            oeAsMov1.Glosa = oeAsiento.Glosa
                                            oeAsMov2.Glosa = oeAsiento.Glosa 'Glosa
                                            'Linea 1
                                            CtaGananciaPerdida(lsCtaGanancia, True, oePeriodo.Ejercicio)
                                            oeAsMov1.IdCuentaContable = lsCtaGanancia '"1CH002556" 'Id de Cuenta 77611  - Cuenta de Ganancia 
                                            oeAsMov1.HaberMN = Math.Abs(Desajuste)
                                            oeAsMov1.AsMov_ObligacionFin = Nothing ' La cabecera no genera relacion
                                            'Linea 2
                                            oeAsMov2.IdCuentaContable = idcuenta 'Obtener cuenta contable Inicial
                                            oeAsMov2.DebeMN = Math.Abs(Desajuste)
                                            oeAsMov2.AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                                            oeAsMov2.AsMov_ObligacionFin.IdObligacionFinanciera = oeMovimientoDocumento.Id
                                            oeAsMov2.AsMov_ObligacionFin.Activo = True 'Estado Activo
                                            oeAsMov2.AsMov_ObligacionFin.TipoOperacion = "I" 'Insertar
                                            lbGanancia = True
                                        ElseIf Desajuste > 0 Then
                                            oeAsiento.Glosa = "ASIENTO DE PERDIDA " & oeMovimientoDocumento.Codigo & " " & CLienteProveedor
                                            oeAsiento.GlosaImprime = oeAsiento.Glosa
                                            oeAsMov1.Glosa = oeAsiento.Glosa
                                            oeAsMov2.Glosa = oeAsiento.Glosa
                                            'Linea 1
                                            oeAsMov1.IdCuentaContable = idcuenta 'Obtener cuenta contable Inicial
                                            oeAsMov1.HaberMN = Math.Abs(Desajuste)
                                            oeAsMov1.AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                                            oeAsMov1.AsMov_ObligacionFin.IdObligacionFinanciera = oeMovimientoDocumento.Id
                                            oeAsMov1.AsMov_ObligacionFin.Activo = True 'Estado Activo
                                            oeAsMov1.AsMov_ObligacionFin.TipoOperacion = "I" 'Insertar
                                            'Linea 2
                                            CtaGananciaPerdida(lsCtaPerdida, False, oePeriodo.Ejercicio)
                                            oeAsMov2.IdCuentaContable = lsCtaPerdida '"1CH002069" 'Id de Cuenta 67611  - Cuenta de Perdida
                                            oeAsMov2.DebeMN = Math.Abs(Desajuste)
                                            oeAsMov2.AsMov_ObligacionFin = Nothing ' La cabecera no genera relacion

                                            oeAsMov2.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                                            oeMovAnalisis = New e_MovimientoAnalisis
                                            oeMovAnalisis.TipoOperacion = "I"
                                            oeMovAnalisis.IdGastoFuncion = "1CH000090" '---------gasto financiero
                                            oeMovAnalisis.Monto = Math.Abs(Desajuste)
                                            oeMovAnalisis.Saldo = oeMovAnalisis.Monto
                                            oeAsMov2.MovimientoAnalisis.Add(oeMovAnalisis)

                                            lbPerdida = True
                                        End If
                                    End If


                                    'Llenar Objeto Asiento Movimiento(tabla AsientoMovimiento) Linea1 y linea 1
                                    oeAsMov1.IdUsuarioCrea = IdUsuariocrea  'Id del usuario que crea el asiento de ajuste
                                    oeAsMov2.IdUsuarioCrea = IdUsuariocrea
                                    oeAsMov1.FechaCreacion = Date.Now  'Fecha Actual
                                    oeAsMov2.FechaCreacion = Date.Now  'Fecha Actual
                                    oeAsMov1.Activo = True 'Estado Activo
                                    oeAsMov2.Activo = True
                                    oeAsMov1.TipoOperacion = "I" 'Tipo de Operacion
                                    oeAsMov2.TipoOperacion = "I"


                                    'Asignar Linea 12 a Objeto Asiento
                                    oeAsiento.AsientoMovimiento.Add(oeAsMov1)
                                    oeAsiento.AsientoMovimiento.Add(oeAsMov2)

                                    olAsiento.Guardar(oeAsiento) 'GUARDAR DATOS
                                Else
                                    Return False ' Si no es necesario Ajuste de tipo de cambio , no realiza operaciones
                                End If
                            End If
                        End If
                    End If
                End If

            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Anular(ByVal oeMovimientoDocumento As e_MovimientoDocumento, ByVal IdUsuario As String) As Boolean Implements Il_MovimientoDocumento.Anular
        Try
            Using transScope As New TransactionScope()
                If oeMovimientoDocumento.TipoOperacion <> "ACT" Then
                    ExtornarDocEmitidoEnviado(oeMovimientoDocumento, IdUsuario)
                    oeMovimientoDocumento.TipoOperacion = "ANU"
                    oeMovimientoDocumento.EstadoDocumento = "ANULADO"
                End If
                odMovimientoDocumento.Anular(oeMovimientoDocumento)
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CambiarGlosa(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.CambiarGlosa
        Try
            Return odMovimientoDocumento.CambiarGlosa(oeMovimientoDocumento)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String Implements Il_MovimientoDocumento.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    ''' <summary>
    ''' Retorna la la cuenta de ganancia o de perdida
    ''' </summary>
    ''' <param name="lsCta">cuenta de ganancia o pérdida</param>
    ''' <param name="G_P">true: ganancia, false: pérdida </param>
    ''' <remarks></remarks>
    Public Sub CtaGananciaPerdida(ByRef lsCta As String, ByVal G_P As Boolean, ByVal Ejercicio As Integer) Implements Il_MovimientoDocumento.CtaGananciaPerdida
        Dim oeTCD As New e_TablaContableDet
        Dim odTCD As New d_TablaContableDet
        If lsCta = "" Then
            If G_P Then 'ganancia
                oeTCD.TipoOperacion = "N"
                oeTCD.Activo = True
                oeTCD.Nombre = "CUENTAS GENERALES"
                oeTCD.Texto1 = "CTA_GANANCIA"
                oeTCD.Valor1 = Ejercicio
                oeTCD = odTCD.Listar(oeTCD)(0)
                lsCta = oeTCD.Texto2
            Else 'pérdida
                oeTCD.TipoOperacion = "N"
                oeTCD.Activo = True
                oeTCD.Nombre = "CUENTAS GENERALES"
                oeTCD.Texto1 = "CTA_PERDIDAS"
                oeTCD.Valor1 = Ejercicio
                oeTCD = odTCD.Listar(oeTCD)(0)
                lsCta = oeTCD.Texto2
            End If
        End If
    End Sub

    Public Function Eliminar(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.Eliminar
        Try
            Return odMovimientoDocumento.Eliminar(oeMovimientoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EliminarAnticipo(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.EliminarAnticipo
        Try
            olFuncionesGenerales.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, gAreasSGI.Tesoreria)
            olFuncionesGenerales.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, gAreasSGI.Contabilidad)
            Return odMovimientoDocumento.EliminarAnticipo(oeMovimientoDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarComprobante(ByVal oeMovimientoDocumento As e_MovimientoDocumento, Optional ByVal OeAsiento As e_Asiento = Nothing) As Boolean Implements Il_MovimientoDocumento.EliminarComprobante
        Try
            If Math.Round(oeMovimientoDocumento.Saldo, 2) <> Math.Round(oeMovimientoDocumento.Total, 2) Then
                Throw New Exception("No se puede Operar por existen Cobros/Pagos Asociados")
            End If
            If oeMovimientoDocumento.IndServicioMaterial <> " " Then
                Throw New Exception("No se puede Eliminar este documento, Extorne documento emitido")
            End If
            Dim OeAs As New e_Asiento
            If OeAsiento Is Nothing Then
                Dim odAsDocumento As New d_Asiento_MovDoc
                Dim oeAsDocumento As New e_Asiento_MovDoc
                Dim leAsDocumento As New List(Of e_Asiento_MovDoc)
                oeAsDocumento.IdMovimientoDocumento = oeMovimientoDocumento.Id
                oeAsDocumento.Activo = True
                leAsDocumento.AddRange(odAsDocumento.Listar(oeAsDocumento))
                OeAs.Id = leAsDocumento(0).IdAsiento
            Else
                OeAs = OeAsiento
            End If
            Return odMovimientoDocumento.EliminarComprobante(oeMovimientoDocumento, OeAs)
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function EliminarDocumentoVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.EliminarDocumentoVenta
        Try
            odMovimientoDocumento.EliminarDocumentoVenta(oeMovimientoDocumento)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Emitir(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.Emitir
        Try
            oeMovimientoDocumento.TipoOperacion = "EMI"
            oeMovimientoDocumento.EstadoDocumento = "EMITIDA"
            Return odMovimientoDocumento.Emitir(oeMovimientoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ExisteCta(ByVal Lista As System.Collections.Generic.List(Of e_AsientoMovimiento), ByVal IdCta As String) As e_AsientoMovimiento Implements Il_MovimientoDocumento.ExisteCta
        For Each obj As e_AsientoMovimiento In Lista
            If obj.IdCuentaContable = IdCta Then
                Return obj
            End If
        Next
        Return Nothing
    End Function

    Public Function ExtornarDocEmitidoEnviado(ByVal oeMovimientoDocumento As e_MovimientoDocumento, ByVal IdUsuario As String) As Boolean Implements Il_MovimientoDocumento.ExtornarDocEmitidoEnviado
        Try
            If Math.Round(oeMovimientoDocumento.Saldo, 1) <> Math.Round(oeMovimientoDocumento.Total, 1) Then
                Throw New Exception("No se puede Operar por existen Cobros/Pagos Asociados")
            End If
            Dim olFunGen As New l_FuncionesGenerales
            If oeMovimientoDocumento.IndCompraVenta = 2 Or oeMovimientoDocumento.IndCompraVenta = 5 Then
                olFunGen.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, gAreasSGI.Ventas, Date.Parse("01/01/1901"), "")
            Else
                olFunGen.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, gAreasSGI.Compras, Date.Parse("01/01/1901"), "")
            End If
            Dim OeAs As New e_Asiento
            Dim odAsiento As New d_Asiento
            Dim odAsDocumento As New d_Asiento_MovDoc
            Dim oeAsDocumento As New e_Asiento_MovDoc
            Dim leAsDocumento As New List(Of e_Asiento_MovDoc)
            oeAsDocumento.IdMovimientoDocumento = oeMovimientoDocumento.Id
            leAsDocumento.AddRange(odAsDocumento.Listar(oeAsDocumento))
            OeAs.Id = leAsDocumento(0).IdAsiento
            OeAs.IdUsuarioCrea = IdUsuario
            OeAs.IndOrigen = oeMovimientoDocumento.IndOrigenContable
            Return odAsiento.ExtornarEmitidoEnviado(OeAs)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoDocumento As e_MovimientoDocumento, Optional oeAnticipo As e_MovimientoDocumento = Nothing) As e_MovimientoDocumento Implements Il_MovimientoDocumento.Guardar
        Try
            If oeMovimientoDocumento.TipoOperacion <> "EPC" Then
                l_FuncionesGenerales.ValidarCampoNoNulo(oeMovimientoDocumento.IdTipoDocumento, "Seleciona Tipo Documento")
                l_FuncionesGenerales.ValidarCampoNoNulo(oeMovimientoDocumento.IdClienteProveedor, IIf(oeMovimientoDocumento.IndCompraVenta = 1, "Seleccione Proveedor", "Seleccione Cliente"))
                l_FuncionesGenerales.ValidarCampoNoNulo(oeMovimientoDocumento.Serie, "Agregue Serie al Documento.")
                l_FuncionesGenerales.ValidarCampoNoNulo(oeMovimientoDocumento.Numero, "Agregue Número al Documento.")
                olFuncionesGenerales.ValidarDocumentoDuplicado(oeMovimientoDocumento)
                If oeMovimientoDocumento.TipoCambio = 0 Then Throw New Exception("No Existe Tipo de Cambio")
            End If

            oeAnticipo = New e_MovimientoDocumento
            oeMovimientoDocumento = odMovimientoDocumento.Guardar(oeMovimientoDocumento, oeAnticipo)
            Return oeMovimientoDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Dim ado_DatosImpresion As New l_MovimientoDocumento_Impresion

    Public Function GuardarCanje(oeMovimientoDocumento As e_MovimientoDocumento, oeNotaDespacho As e_MovimientoDocumento) As e_MovimientoDocumento Implements Il_MovimientoDocumento.GuardarCanje
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(oeMovimientoDocumento.Serie, "Agregue Serie al Documento.")
            l_FuncionesGenerales.ValidarCampoNoNulo(oeMovimientoDocumento.Numero, "Agregue Número al Documento.")
            Using TransScope As New TransactionScope()
                oeMovimientoDocumento = odMovimientoDocumento.Guardar(oeMovimientoDocumento, New e_MovimientoDocumento)
                Dim oeRefAsoc As New e_ReferenciaAsociada
                Dim odRefAsoc As New d_ReferenciaAsociada
                With oeRefAsoc
                    .TipoOperacion = "I"
                    .IdEmpresaSis = oeMovimientoDocumento.IdEmpresaSis
                    .PrefijoID = oeMovimientoDocumento.PrefijoID
                    .IdTablaPrincipal = oeNotaDespacho.Id
                    .IdTablaAsociada = oeMovimientoDocumento.Id
                    .TipoRelacion = 0
                    .Glosa = "CANJE ND X COMPROBANTE DE VENTA"
                    .UsuarioCreacion = oeMovimientoDocumento.IdUsuarioCrea
                End With
                odRefAsoc.Guardar(oeRefAsoc)
                TransScope.Complete()

            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return oeMovimientoDocumento
    End Function

    Public Function AplicarCanje(oeNotaDespacho As e_MovimientoDocumento, oeDocumentoGenera As e_MovimientoDocumento) As Boolean
        Try

        Catch ex As Exception

        End Try
        Return True
    End Function

    Public Function ValidarTipoCambio(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.ValidarTipoCambio
        Try
            If oeMovimientoDocumento.TipoCambio = 0 Then Throw New Exception("Tipo de Cambio no puede Ser 0. Verificar")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CambiarPeriodo(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.CambiarPeriodo
        Try
            l_FuncionesGenerales.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, gAreasSGI.Contabilidad, Date.Parse("01/01/1901"), "")
            Return odMovimientoDocumento.CambiaPeriodoVerifica(oeMovimientoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ExtornarAnticipo(oeAsientoOriginal As e_Asiento, oeAsientoExtorno As e_Asiento, oeMovDoc As e_MovimientoDocumento, loCtaCtble As List(Of e_Combo)) As Boolean
        Try
            Dim Cuenta As String
            Dim odAsiento As New d_Asiento
            Dim olAsiento As New l_Asiento
            Dim odAsientoMovimiento As New d_AsientoMovimiento
            Dim olCtaCxP As New l_CuentaxCyP
            Dim odCtaCxP As New d_CuentaxCyP
            Dim odAsientoMovimientoMovDoc As New d_AsientoMov_MovDoc
            Dim olAsientoMovimientoMovDoc As New l_AsientoMov_MovDoc
            Dim olAsientoMovimiento As New l_AsientoMovimiento
            Dim odMovCajaBanco As New d_MovimientoCajaBanco
            Dim olMovCajaBanco As New l_MovimientoCajaBanco
            Dim olAsientoMovDoc As New l_Asiento_MovDoc
            Dim odAsientoMovDoc As New d_Asiento_MovDoc
            Dim odMovimientoAnalisis As New d_MovimientoAnalisis
            Dim olMovimientoAnalisis As New l_MovimientoAnalisis
            Dim olFuncionesGenerales As New l_FuncionesGenerales
            Dim dt_ASI As Data.DataTable = olAsiento.CrearDT()
            Dim dt_ASIMOV As Data.DataTable = olAsientoMovimiento.CrearDT()
            Dim dt_ASIMOVMOVDOC As Data.DataTable = olAsientoMovimientoMovDoc.CrearDT()
            Dim dt_MOVCJB As Data.DataTable = olMovCajaBanco.CrearDT()
            Dim dt_CTAXCP As Data.DataTable = olCtaCxP.CrearDT()
            Dim dt_ASIMOVDOC As Data.DataTable = olAsientoMovDoc.CrearDT()
            Dim oeCombo As e_Combo
            Dim oeMovCajBanco As e_MovimientoCajaBanco
            Using TransScope As New TransactionScope()
                oeMovDoc.TipoOperacion = "T"
                oeMovDoc = odMovimientoDocumento.Guardar(oeMovDoc)
                If oeMovDoc.Id = "" Then Return False

                Dim IdAsiento As String = odAsiento.UltimoIdInserta(oeMovDoc.PrefijoID)
                Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
                Dim lsNumeroIdAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))
                'nroasiento
                Dim NroAsientoCompra As String = odAsiento.UltimoNroAsiento("1CH000016", oeAsientoExtorno.IdPeriodo, "1", oeMovDoc.PrefijoID)
                Dim lsPrefijoNroAsientoCompra As String = Left(NroAsientoCompra, 2)
                Dim lsNumeroNroAsientoCompra As Integer = CInt(Right(NroAsientoCompra, Len(NroAsientoCompra) - 2))
                'asientomovdoc
                Dim IdAsientoMovDoc As String = odAsientoMovDoc.UltimoIdInserta(oeMovDoc.PrefijoID)
                Dim lsPrefijoAsientoMovDoc As String = Left(IdAsientoMovDoc, 3)
                Dim lsNumeroIdAsientoMovDoc As Integer = CInt(Right(IdAsientoMovDoc, Len(IdAsientoMovDoc) - 3))
                'asientmov
                Dim IdAsientoMovimiento As String = odAsientoMovimiento.UltimoIdInsertar(oeMovDoc.PrefijoID)
                Dim lsPrefijoAsientoMovimiento As String = Left(IdAsientoMovimiento, 3)
                Dim lsNumeroIdAsientoMovimiento As Integer = CInt(Right(IdAsientoMovimiento, Len(IdAsientoMovimiento) - 3))
                'cta x c y p
                Dim IdCtaxCyP As String = odCtaCxP.UltimoIdInserta(oeMovDoc.PrefijoID)
                Dim lsPrefijoIdCtaxCyP As String = Left(IdCtaxCyP, 3)
                Dim lsNumeroIdCtaxCyP As Integer = CInt(Right(IdCtaxCyP, Len(IdCtaxCyP) - 3))
                'asientomovimiento movdoc
                Dim IdAsientoMovimientoMovDoc As String = odAsientoMovimientoMovDoc.UltimoIdInsertar(oeMovDoc.PrefijoID)
                Dim lsPrefijoAsientoMovimientoMovDoc As String = Left(IdAsientoMovimientoMovDoc, 3)
                Dim lsNumeroIdAsientoMovimientoMovDoc As Integer = CInt(Right(IdAsientoMovimientoMovDoc, Len(IdAsientoMovimientoMovDoc) - 3))
                'movcajabanco
                Dim IdMovimientoCajaBanco As String = odMovCajaBanco.UltimoIdInserta(oeMovDoc.PrefijoID)
                Dim lsPrefijoMovCajaBanco As String = Left(IdMovimientoCajaBanco, 3)
                Dim lsNumeroIdMovCajaBanco As Integer = CInt(Right(IdMovimientoCajaBanco, Len(IdMovimientoCajaBanco) - 3))

                Dim rowAsiento As Data.DataRow
                Dim rowAsientoMovDoc As Data.DataRow
                Dim rowAsiMovDebe As Data.DataRow
                Dim rowAsiMovHaber As Data.DataRow
                Dim rowMovCajBan As Data.DataRow
                Dim rowAsientoMovMovDoc As Data.DataRow
                Dim rowCtaxCP As Data.DataRow

                rowAsiento = dt_ASI.NewRow
                rowAsiento("Id") = lsPrefijoAsiento.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsiento.ToString, 12)
                rowAsiento("IdPeriodo") = oeAsientoExtorno.IdPeriodo
                rowAsiento("IdTipoAsiento") = oeAsientoOriginal.IdTipoAsiento
                rowAsiento("NroAsiento") = lsPrefijoNroAsientoCompra + olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsientoCompra, 7).ToString
                rowAsiento("Fecha") = oeAsientoExtorno.Fecha
                rowAsiento("Glosa") = "EXTORNO DE: " & oeAsientoOriginal.Glosa
                rowAsiento("GlosaImprime") = "EXTORNO DE: " & oeAsientoOriginal.Glosa
                rowAsiento("IdMoneda") = oeAsientoOriginal.IdMoneda
                rowAsiento("TipoCambio") = oeMovDoc.TipoCambio
                rowAsiento("TotalDebe") = oeAsientoOriginal.TotalDebe
                rowAsiento("TotalHaber") = oeAsientoOriginal.TotalHaber
                rowAsiento("IdUsuarioBloquea") = ""
                rowAsiento("UsuarioCreacion") = oeAsientoExtorno.IdUsuarioCrea
                rowAsiento("IdEstado") = "1CH00005"
                rowAsiento("IdAsientoExtorno") = ""
                rowAsiento("FechaCreacion") = oeAsientoExtorno.FechaCreacion
                rowAsiento("Activo") = True
                rowAsiento("NroAsientoImprime") = DBNull.Value
                rowAsiento("IdentificaAsiento") = DBNull.Value
                rowAsiento("IndRevision") = DBNull.Value
                rowAsiento("FechaRevision") = DBNull.Value
                rowAsiento("UsuarioRevision") = DBNull.Value
                rowAsiento("IndOrigen") = 18
                rowAsiento("UsuarioModificacion") = ""
                rowAsiento("FechaModificacion") = Date.Parse("01/01/1901")
                dt_ASI.Rows.Add(rowAsiento)

                rowAsientoMovDoc = dt_ASIMOVDOC.NewRow
                rowAsientoMovDoc("Id") = lsPrefijoAsientoMovDoc + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovDoc.ToString, 9)
                rowAsientoMovDoc("IdAsiento") = rowAsiento("Id")
                rowAsientoMovDoc("IdMovimientoDocumento") = oeMovDoc.Id
                rowAsientoMovDoc("Activo") = True
                dt_ASIMOVDOC.Rows.Add(rowAsientoMovDoc)
                'anticipo proveedor
                If oeAsientoOriginal.IndOrigen = 11 Then
                    For Each oeAsiMov As e_AsientoMovimiento In oeAsientoOriginal.AsientoMovimiento
                        Cuenta = ""
                        oeCombo = New e_Combo
                        oeCombo.Id = oeAsiMov.IdCuentaContable
                        oeCombo.Tipo = 0
                        If loCtaCtble.Contains(oeCombo) Then
                            Cuenta = loCtaCtble.Item(loCtaCtble.IndexOf(oeCombo)).Nombre
                            oeCombo = New e_Combo
                            oeCombo.Descripcion = oeMovDoc.Ejercicio.ToString
                            oeCombo.Nombre = Cuenta
                            oeCombo.Tipo = 4
                            If loCtaCtble.Contains(oeCombo) Then
                                oeCombo = loCtaCtble.Item(loCtaCtble.IndexOf(oeCombo))
                            End If
                        End If
                        If oeAsiMov.DebeMN > 0 Then
                            rowAsiMovHaber = dt_ASIMOV.NewRow
                            rowAsiMovHaber("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                            rowAsiMovHaber("IdAsiento") = rowAsiento("Id")
                            rowAsiMovHaber("Glosa") = rowAsiento("Glosa")
                            rowAsiMovHaber("IdCuentaContable") = oeCombo.Id
                            rowAsiMovHaber("DebeMN") = 0
                            rowAsiMovHaber("HaberMN") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total, oeMovDoc.Total * oeMovDoc.TipoCambio)
                            rowAsiMovHaber("DebeME") = 0
                            rowAsiMovHaber("HaberME") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total / oeMovDoc.TipoCambio, oeMovDoc.Total)
                            rowAsiMovHaber("IdUsuarioCrea") = oeAsientoExtorno.IdUsuarioCrea
                            rowAsiMovHaber("FechaCreacion") = oeAsientoExtorno.FechaCreacion
                            rowAsiMovHaber("Activo") = True
                            rowAsiMovHaber("NroLinea") = 1
                            dt_ASIMOV.Rows.Add(rowAsiMovHaber)
                            lsNumeroIdAsientoMovimiento += 1

                            rowAsientoMovMovDoc = dt_ASIMOVMOVDOC.NewRow
                            rowAsientoMovMovDoc("Id") = lsPrefijoAsientoMovimientoMovDoc + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimientoMovDoc.ToString, 9)
                            rowAsientoMovMovDoc("IdMovimientoDocumento") = oeMovDoc.Id
                            rowAsientoMovMovDoc("IdAsientoMovimiento") = rowAsiMovHaber("Id")
                            rowAsientoMovMovDoc("IdCuentaxCyP") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdCtaxCyP.ToString, 12)
                            rowAsientoMovMovDoc("Activo") = True
                            rowAsientoMovMovDoc("UsuarioCreacion") = oeAsientoExtorno.IdUsuarioCrea
                            rowAsientoMovMovDoc("FechaCreacion") = oeAsientoExtorno.FechaCreacion
                            dt_ASIMOVMOVDOC.Rows.Add(rowAsientoMovMovDoc)
                            lsNumeroIdAsientoMovimientoMovDoc += 1
                        End If
                        If oeAsiMov.HaberMN > 0 Then
                            rowAsiMovDebe = dt_ASIMOV.NewRow
                            rowAsiMovDebe("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                            rowAsiMovDebe("IdAsiento") = rowAsiento("Id")
                            rowAsiMovDebe("Glosa") = rowAsiento("Glosa")
                            rowAsiMovDebe("IdCuentaContable") = oeCombo.Id
                            rowAsiMovDebe("DebeMN") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total, oeMovDoc.Total * oeMovDoc.TipoCambio)
                            rowAsiMovDebe("HaberMN") = 0
                            rowAsiMovDebe("DebeME") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total / oeMovDoc.TipoCambio, oeMovDoc.Total)
                            rowAsiMovDebe("HaberME") = 0
                            rowAsiMovDebe("IdUsuarioCrea") = oeAsientoExtorno.IdUsuarioCrea
                            rowAsiMovDebe("FechaCreacion") = oeAsientoExtorno.FechaCreacion
                            rowAsiMovDebe("Activo") = True
                            rowAsiMovDebe("NroLinea") = 2
                            dt_ASIMOV.Rows.Add(rowAsiMovDebe)
                            lsNumeroIdAsientoMovimiento += 1

                            oeMovCajBanco = New e_MovimientoCajaBanco
                            oeMovCajBanco.TipoOperacion = ""
                            oeMovCajBanco.IdAsientoMovimiento = oeAsiMov.Id
                            oeMovCajBanco = odMovCajaBanco.Obtener(oeMovCajBanco)
                            rowMovCajBan = dt_MOVCJB.NewRow
                            rowMovCajBan("Id") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdMovCajaBanco.ToString, 13)
                            rowMovCajBan("IdFlujoCaja") = oeMovCajBanco.IdFlujoCaja
                            rowMovCajBan("NroBoucher") = oeMovDoc.GlosaViajeGrupo
                            rowMovCajBan("IdCuentaBancaria") = oeMovCajBanco.IdCuentaBancaria
                            rowMovCajBan("Fecha") = oeAsientoExtorno.Fecha
                            rowMovCajBan("IdTipoDocumento") = oeMovCajBanco.IdMedioPago
                            rowMovCajBan("IdPeriodoConcilia") = ""
                            rowMovCajBan("Activo") = True
                            rowMovCajBan("IdAsientoMovimiento") = rowAsiMovDebe("Id")
                            rowMovCajBan("TipoCambio") = oeMovDoc.TipoCambio
                            rowMovCajBan("TotalMN") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total, oeMovDoc.Total * oeMovDoc.TipoCambio)
                            rowMovCajBan("TotalME") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total / oeMovDoc.TipoCambio, oeMovDoc.Total)
                            rowMovCajBan("Operador") = 1
                            rowMovCajBan("NroImpresion") = String.Empty
                            rowMovCajBan("IdTipoGasto") = String.Empty
                            dt_MOVCJB.Rows.Add(rowMovCajBan)
                            lsNumeroIdMovCajaBanco += 1

                            rowCtaxCP = dt_CTAXCP.NewRow
                            rowCtaxCP("Id") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdCtaxCyP.ToString, 12)
                            rowCtaxCP("IdMovimientoCajaBanco") = rowMovCajBan("Id")
                            rowCtaxCP("IdMovimientoDocumento") = oeMovDoc.Id
                            rowCtaxCP("Fecha") = oeAsientoExtorno.Fecha
                            rowCtaxCP("MontoMN") = rowMovCajBan("TotalMN")
                            rowCtaxCP("MontoME") = rowMovCajBan("TotalME")
                            rowCtaxCP("Activo") = True
                            rowCtaxCP("UsuarioCreacion") = oeAsientoExtorno.IdUsuarioCrea
                            rowCtaxCP("FechaCreacion") = oeAsientoExtorno.FechaCreacion
                            rowCtaxCP("MacPCLocalCreacion") = String.Empty
                            rowCtaxCP("IdCuentaCorriente") = DBNull.Value
                            rowCtaxCP("IndCargoAbono") = DBNull.Value
                            dt_CTAXCP.Rows.Add(rowCtaxCP)
                            lsNumeroIdCtaxCyP += 1
                        End If
                    Next
                End If
                'anticipo cliente
                If oeAsientoOriginal.IndOrigen = 12 Then
                    For Each oeAsiMov As e_AsientoMovimiento In oeAsientoOriginal.AsientoMovimiento
                        Cuenta = ""
                        oeCombo = New e_Combo
                        oeCombo.Id = oeAsiMov.IdCuentaContable
                        oeCombo.Tipo = 0
                        If loCtaCtble.Contains(oeCombo) Then
                            Cuenta = loCtaCtble.Item(loCtaCtble.IndexOf(oeCombo)).Nombre
                            oeCombo = New e_Combo
                            oeCombo.Descripcion = oeMovDoc.Ejercicio.ToString
                            oeCombo.Nombre = Cuenta
                            oeCombo.Tipo = 4
                            If loCtaCtble.Contains(oeCombo) Then
                                oeCombo = loCtaCtble.Item(loCtaCtble.IndexOf(oeCombo))
                            End If
                        End If
                        If oeAsiMov.HaberMN > 0 Then
                            rowAsiMovDebe = dt_ASIMOV.NewRow
                            rowAsiMovDebe("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                            rowAsiMovDebe("IdAsiento") = rowAsiento("Id")
                            rowAsiMovDebe("Glosa") = rowAsiento("Glosa")
                            rowAsiMovDebe("IdCuentaContable") = oeCombo.Id
                            rowAsiMovDebe("DebeMN") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total, oeMovDoc.Total * oeMovDoc.TipoCambio)
                            rowAsiMovDebe("HaberMN") = 0
                            rowAsiMovDebe("DebeME") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total / oeMovDoc.TipoCambio, oeMovDoc.Total)
                            rowAsiMovDebe("HaberME") = 0
                            rowAsiMovDebe("IdUsuarioCrea") = oeAsientoExtorno.IdUsuarioCrea
                            rowAsiMovDebe("FechaCreacion") = oeAsientoExtorno.FechaCreacion
                            rowAsiMovDebe("Activo") = True
                            rowAsiMovDebe("NroLinea") = 1
                            dt_ASIMOV.Rows.Add(rowAsiMovDebe)
                            lsNumeroIdAsientoMovimiento += 1

                            rowAsientoMovMovDoc = dt_ASIMOVMOVDOC.NewRow
                            rowAsientoMovMovDoc("Id") = lsPrefijoAsientoMovimientoMovDoc + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimientoMovDoc.ToString, 9)
                            rowAsientoMovMovDoc("IdMovimientoDocumento") = oeMovDoc.Id
                            rowAsientoMovMovDoc("IdAsientoMovimiento") = rowAsiMovDebe("Id")
                            rowAsientoMovMovDoc("IdCuentaxCyP") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdCtaxCyP.ToString, 12)
                            rowAsientoMovMovDoc("Activo") = True
                            rowAsientoMovMovDoc("UsuarioCreacion") = oeAsientoExtorno.IdUsuarioCrea
                            rowAsientoMovMovDoc("FechaCreacion") = oeAsientoExtorno.FechaCreacion
                            dt_ASIMOVMOVDOC.Rows.Add(rowAsientoMovMovDoc)
                            lsNumeroIdAsientoMovimientoMovDoc += 1
                        End If
                        If oeAsiMov.DebeMN > 0 Then
                            rowAsiMovHaber = dt_ASIMOV.NewRow
                            rowAsiMovHaber("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                            rowAsiMovHaber("IdAsiento") = rowAsiento("Id")
                            rowAsiMovHaber("Glosa") = rowAsiento("Glosa")
                            rowAsiMovHaber("IdCuentaContable") = oeCombo.Id
                            rowAsiMovHaber("DebeMN") = 0
                            rowAsiMovHaber("HaberMN") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total, oeMovDoc.Total * oeMovDoc.TipoCambio)
                            rowAsiMovHaber("DebeME") = 0
                            rowAsiMovHaber("HaberME") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total / oeMovDoc.TipoCambio, oeMovDoc.Total)
                            rowAsiMovHaber("IdUsuarioCrea") = oeAsientoExtorno.IdUsuarioCrea
                            rowAsiMovHaber("FechaCreacion") = oeAsientoExtorno.FechaCreacion
                            rowAsiMovHaber("Activo") = True
                            rowAsiMovHaber("NroLinea") = 2
                            dt_ASIMOV.Rows.Add(rowAsiMovHaber)
                            lsNumeroIdAsientoMovimiento += 1

                            oeMovCajBanco = New e_MovimientoCajaBanco
                            oeMovCajBanco.TipoOperacion = ""
                            oeMovCajBanco.IdAsientoMovimiento = oeAsiMov.Id
                            oeMovCajBanco = odMovCajaBanco.Obtener(oeMovCajBanco)
                            rowMovCajBan = dt_MOVCJB.NewRow
                            rowMovCajBan("Id") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdMovCajaBanco.ToString, 13)
                            rowMovCajBan("IdFlujoCaja") = oeMovCajBanco.IdFlujoCaja
                            rowMovCajBan("NroBoucher") = oeMovDoc.GlosaViajeGrupo
                            rowMovCajBan("IdCuentaBancaria") = oeMovCajBanco.IdCuentaBancaria
                            rowMovCajBan("Fecha") = oeAsientoExtorno.Fecha
                            rowMovCajBan("IdTipoDocumento") = oeMovCajBanco.IdMedioPago
                            rowMovCajBan("IdPeriodoConcilia") = ""
                            rowMovCajBan("Activo") = True
                            rowMovCajBan("IdAsientoMovimiento") = rowAsiMovHaber("Id")
                            rowMovCajBan("TipoCambio") = oeMovDoc.TipoCambio
                            rowMovCajBan("TotalMN") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total, oeMovDoc.Total * oeMovDoc.TipoCambio)
                            rowMovCajBan("TotalME") = IIf(oeAsientoOriginal.IdMoneda = "1CH01", oeMovDoc.Total / oeMovDoc.TipoCambio, oeMovDoc.Total)
                            rowMovCajBan("Operador") = -1
                            rowMovCajBan("NroImpresion") = String.Empty
                            rowMovCajBan("IdTipoGasto") = String.Empty
                            dt_MOVCJB.Rows.Add(rowMovCajBan)
                            lsNumeroIdMovCajaBanco += 1

                            rowCtaxCP = dt_CTAXCP.NewRow
                            rowCtaxCP("Id") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdCtaxCyP.ToString, 12)
                            rowCtaxCP("IdMovimientoCajaBanco") = rowMovCajBan("Id")
                            rowCtaxCP("IdMovimientoDocumento") = oeMovDoc.Id
                            rowCtaxCP("Fecha") = oeAsientoExtorno.Fecha
                            rowCtaxCP("MontoMN") = rowMovCajBan("TotalMN")
                            rowCtaxCP("MontoME") = rowMovCajBan("TotalME")
                            rowCtaxCP("Activo") = True
                            rowCtaxCP("UsuarioCreacion") = oeAsientoExtorno.IdUsuarioCrea
                            rowCtaxCP("FechaCreacion") = oeAsientoExtorno.FechaCreacion
                            rowCtaxCP("MacPCLocalCreacion") = String.Empty
                            rowCtaxCP("IdCuentaCorriente") = DBNull.Value
                            rowCtaxCP("IndCargoAbono") = DBNull.Value
                            dt_CTAXCP.Rows.Add(rowCtaxCP)
                            lsNumeroIdCtaxCyP += 1
                        End If
                    Next
                End If
                odMovimientoDocumento.GuardaMasivo(oeMovDoc, dt_ASI, dt_ASIMOV, dt_MOVCJB, dt_ASIMOVMOVDOC, dt_CTAXCP)
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarAnticipo(ByVal oeMovimientoDocumento As e_MovimientoDocumento, ByVal oeMovCajaBanco As e_MovimientoCajaBanco, ByVal Tipo As String) As Boolean Implements Il_MovimientoDocumento.GuardarAnticipo
        Try
            If ValidarAnticipo(oeMovimientoDocumento) Then
                ObtenerVariablesGenerales(oeMovCajaBanco.Fecha.Year)
                'If Tipo = "Cliente" Then
                '    oeMovimientoDocumento.IdCuentaContable = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", leCuentasGenerales.Where(Function(i) i.Nombre = "CTACLIENTEANTSOLES")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTACLIENTEANTDOLARES")(0).Texto2)
                'ElseIf Tipo = "Proveedor" Then
                '    oeMovimientoDocumento.IdCuentaContable = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", leCuentasGenerales.Where(Function(i) i.Nombre = "CTAPROVEEDORANTSOLES")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTAPROVEEDORANTDOLARES")(0).Texto2)
                'End If
                Dim oeAsiento As New e_Asiento
                oeAsiento.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                With oeAsiento
                    .TipoOperacion = "I"
                    .IdPeriodo = oeMovimientoDocumento.IdPeriodo
                    .IdTipoAsiento = oeMovCajaBanco._IdTipoAsiento
                    .Fecha = oeMovimientoDocumento.FechaEmision
                    .Glosa = oeMovimientoDocumento.Glosa
                    .GlosaImprime = .Glosa
                    .IdMoneda = oeMovimientoDocumento.IdMoneda
                    .TipoCambio = oeMovimientoDocumento.TipoCambio
                    .TotalDebe = oeMovimientoDocumento.Total
                    .TotalHaber = oeMovimientoDocumento.Total
                    .IdEstado = "CUADRADO"
                    .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea
                    .IndOrigen = IIf(Tipo = "Proveedor", 11, 12)
                    '
                    For Each DetalleAsientoModelo As e_DetalleAsientoModelo In oeMovimientoDocumento.oeAsientoModelo.leDetalle
                        DetalleAsientoModelo.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                        Dim oeAsientoMov As New e_AsientoMovimiento
                        oeAsientoMov.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                        With oeAsientoMov
                            .TipoOperacion = "I"
                            If DetalleAsientoModelo.IndDocumento = True Then
                                oeMovimientoDocumento.IdCuentaContable = DetalleAsientoModelo.IdCuentaContable
                                .IdCuentaContable = oeMovimientoDocumento.IdCuentaContable
                                If Tipo = "Proveedor" Then
                                    .HaberMN = 0
                                    .HaberME = 0
                                    If oeMovimientoDocumento.IdMoneda = "1CH01" Then
                                        .DebeMN = oeMovCajaBanco.TotalMN
                                        .DebeME = oeMovCajaBanco.TotalMN / oeMovimientoDocumento.TipoCambio
                                    Else
                                        .DebeMN = oeMovCajaBanco.TotalME * oeMovCajaBanco.TipoCambio
                                        .DebeME = oeMovCajaBanco.TotalME
                                    End If
                                ElseIf Tipo = "Cliente" Then
                                    .DebeMN = 0
                                    .DebeME = 0
                                    If oeMovimientoDocumento.IdMoneda = "1CH01" Then
                                        .HaberMN = oeMovCajaBanco.TotalMN
                                        .HaberME = oeMovCajaBanco.TotalMN / oeMovimientoDocumento.TipoCambio
                                    Else
                                        .HaberMN = oeMovCajaBanco.TotalME * oeMovCajaBanco.TipoCambio
                                        .HaberME = oeMovCajaBanco.TotalME
                                    End If
                                End If
                                .MovimientoDocumento = oeMovimientoDocumento
                                .MovimientoCajaBanco = Nothing
                            Else
                                .IdCuentaContable = oeMovCajaBanco._IdCuentaContable
                                If Tipo = "Proveedor" Then
                                    .DebeMN = 0
                                    .DebeME = 0
                                    If oeMovimientoDocumento.IdMoneda = "1CH01" Then 'SOLES
                                        .HaberMN = oeMovCajaBanco.TotalMN
                                        .HaberME = oeMovCajaBanco.TotalMN / oeMovCajaBanco.TipoCambio
                                    Else
                                        .HaberMN = oeMovCajaBanco.TotalME * oeMovCajaBanco.TipoCambio
                                        .HaberME = oeMovCajaBanco.TotalME
                                    End If
                                ElseIf Tipo = "Cliente" Then
                                    .HaberMN = 0
                                    .HaberME = 0
                                    If oeMovimientoDocumento.IdMoneda = "1CH01" Then 'SOLES
                                        .DebeMN = oeMovCajaBanco.TotalMN
                                        .DebeME = oeMovCajaBanco.TotalMN / oeMovCajaBanco.TipoCambio
                                    Else
                                        .DebeMN = oeMovCajaBanco.TotalME * oeMovCajaBanco.TipoCambio
                                        .DebeME = oeMovCajaBanco.TotalME
                                    End If
                                End If
                                .MovimientoCajaBanco = oeMovCajaBanco
                                .MovimientoDocumento = Nothing
                            End If
                            .Glosa = oeAsiento.Glosa
                            .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea
                        End With
                        .AsientoMovimiento.Add(oeAsientoMov)
                    Next
                    '
                    'Dim oeAsientoMovDoc As New e_AsientoMovimiento
                    'With oeAsientoMovDoc
                    '    .TipoOperacion = "I"
                    '    .IdCuentaContable = oeMovimientoDocumento.IdCuentaContable
                    '    .Glosa = oeAsiento.Glosa
                    '    .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea
                    '    If Tipo = "Proveedor" Then
                    '        .HaberMN = 0
                    '        .HaberME = 0
                    '        If oeMovimientoDocumento.IdMoneda = "1CH01" Then
                    '            .DebeMN = oeMovCajaBanco.TotalMN
                    '            .DebeME = oeMovCajaBanco.TotalMN / oeMovimientoDocumento.TipoCambio
                    '        Else
                    '            .DebeMN = oeMovCajaBanco.TotalME * oeMovCajaBanco.TipoCambio
                    '            .DebeME = oeMovCajaBanco.TotalME
                    '        End If
                    '    ElseIf Tipo = "Cliente" Then
                    '        .DebeMN = 0
                    '        .DebeME = 0
                    '        If oeMovimientoDocumento.IdMoneda = "1CH01" Then
                    '            .HaberMN = oeMovCajaBanco.TotalMN
                    '            .HaberME = oeMovCajaBanco.TotalMN / oeMovimientoDocumento.TipoCambio
                    '        Else
                    '            .HaberMN = oeMovCajaBanco.TotalME * oeMovCajaBanco.TipoCambio
                    '            .HaberME = oeMovCajaBanco.TotalME
                    '        End If
                    '    End If
                    '    .MovimientoDocumento = oeMovimientoDocumento
                    '    .MovimientoCajaBanco = Nothing
                    'End With
                    '.AsientoMovimiento.Add(oeAsientoMovDoc)

                    'Dim oeAsientoMov10 As New e_AsientoMovimiento
                    'With oeAsientoMov10
                    '    .TipoOperacion = "I"
                    '    .IdCuentaContable = oeMovCajaBanco._IdCuentaContable
                    '    .Glosa = oeAsiento.Glosa
                    '    .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea
                    '    If Tipo = "Proveedor" Then
                    '        .DebeMN = 0
                    '        .DebeME = 0
                    '        If oeMovimientoDocumento.IdMoneda = "1CH01" Then 'SOLES
                    '            .HaberMN = oeMovCajaBanco.TotalMN
                    '            .HaberME = oeMovCajaBanco.TotalMN / oeMovCajaBanco.TipoCambio
                    '        Else
                    '            .HaberMN = oeMovCajaBanco.TotalME * oeMovCajaBanco.TipoCambio
                    '            .HaberME = oeMovCajaBanco.TotalME
                    '        End If
                    '    ElseIf Tipo = "Cliente" Then
                    '        .HaberMN = 0
                    '        .HaberME = 0
                    '        If oeMovimientoDocumento.IdMoneda = "1CH01" Then 'SOLES
                    '            .DebeMN = oeMovCajaBanco.TotalMN
                    '            .DebeME = oeMovCajaBanco.TotalMN / oeMovCajaBanco.TipoCambio
                    '        Else
                    '            .DebeMN = oeMovCajaBanco.TotalME * oeMovCajaBanco.TipoCambio
                    '            .DebeME = oeMovCajaBanco.TotalME
                    '        End If
                    '    End If
                    '    .MovimientoCajaBanco = oeMovCajaBanco
                    '    .MovimientoDocumento = Nothing
                    'End With
                    '.AsientoMovimiento.Add(oeAsientoMov10)

                    .Asiento_MovDoc = Nothing
                End With

                Dim odAsiento As New d_Asiento
                oeAsiento.PrefijoID = oeMovimientoDocumento.PrefijoID '@0001
                odAsiento.GuardarAsientoContable(oeAsiento)
                oeMovCajaBanco.Id = oeAsiento._IdMovimientoCajaBanco
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarCancelacion(ByVal leDocumentosAgregados As  _
    System.Collections.Generic.List(Of e_MovimientoDocumento), ByVal Obj() As Object) As Boolean Implements Il_MovimientoDocumento.GuardarCancelacion
        Try
            If ValidarCancelacionDocumentos(leDocumentosAgregados, Obj(0)) Then
                Dim oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
                oePeriodo.Codigo = Date.Parse(Obj(0)).Year.ToString + "-" + Date.Parse(Obj(0)).Month.ToString
                oePeriodo.Activo = True
                oePeriodo = olPeriodo.Obtener(oePeriodo)
                ObtenerCuentas(oePeriodo.Ejercicio)
                Dim oeAsiento As New e_Asiento, odAsiento As New d_Asiento
                With oeAsiento
                    .TipoOperacion = "I" : .IdPeriodo = oePeriodo.Id : .IdTipoAsiento = "DIARIO" : .Fecha = Date.Parse(Obj(0))
                    .Glosa = "CANC. POR APLIC. DE DCTOS " & leDocumentosAgregados(0)._NombreClienteProveedor & ": " & _
                    leDocumentosAgregados(0).oeTipoDocumento.Abreviatura & "/ " & leDocumentosAgregados(0).Serie + leDocumentosAgregados(0).Numero _
                    & " - " & leDocumentosAgregados(1).oeTipoDocumento.Abreviatura & "/ " & leDocumentosAgregados(1).Serie + leDocumentosAgregados(1).Numero
                    .GlosaImprime = .Glosa : .IdMoneda = Obj(2) : .TipoCambio = Obj(1)
                    .TotalDebe = Math.Abs(leDocumentosAgregados(0).MontoOperar) : .TotalHaber = Math.Abs(leDocumentosAgregados(0).MontoOperar)
                    .IdEstado = "CUADRADO" : .IdUsuarioCrea = Obj(3) : .IndOrigen = 25
                End With
                Dim oeAsientoMovimiento As e_AsientoMovimiento
                For Each oeMD As e_MovimientoDocumento In leDocumentosAgregados
                    oeAsientoMovimiento = New e_AsientoMovimiento
                    With oeAsientoMovimiento
                        .TipoOperacion = "I" : .IdCuentaContable = oeMD.IdCuentaContable
                        .Glosa = "CANC. POR APLIC. DE DCTOS " & oeMD.oeTipoDocumento.Abreviatura & "/" & oeMD.Serie + oeMD.Numero & " " & leDocumentosAgregados(0)._NombreClienteProveedor
                        .IdUsuarioCrea = Obj(3)
                        If oeMD.IdMoneda = "1CH01" Then 'SOLES
                            If oeMD._Operador > 0 Then 'operador POSITIVO: suma a compreso ventas
                                If oeMD.IndCompraVenta = "1" Or oeMD.IndCompraVenta = "4" Then 'COMPRA Y PROVEEDOR
                                    .DebeMN = Math.Abs(oeMD.MontoOperar) : .HaberMN = 0
                                    .DebeME = Math.Abs(oeMD.MontoOperar) / Obj(1) : .HaberME = 0
                                Else 'VENTA Y CLIENTE
                                    .DebeMN = 0 : .HaberMN = Math.Abs(oeMD.MontoOperar)
                                    .DebeME = 0 : .HaberME = Math.Abs(oeMD.MontoOperar) / Obj(1)
                                End If
                            Else 'operador NEGATIVO: resta a compras o ventas
                                If oeMD.IndCompraVenta = "1" Or oeMD.IndCompraVenta = "4" Then 'COMPRA Y PROVEEDOR
                                    .DebeMN = 0 : .HaberMN = Math.Abs(oeMD.MontoOperar)
                                    .DebeME = 0 : .HaberME = Math.Abs(oeMD.MontoOperar) / Obj(1)
                                Else 'VENTA Y CLIENTE
                                    .DebeMN = Math.Abs(oeMD.MontoOperar) : .HaberMN = 0
                                    .DebeME = Math.Abs(oeMD.MontoOperar) / Obj(1) : .HaberME = 0
                                End If
                            End If
                        Else 'DOLARES
                            If oeMD._Operador > 0 Then 'operador POSITIVO: suma a compreso ventas
                                If oeMD.IndCompraVenta = "1" Or oeMD.IndCompraVenta = "4" Then 'COMPRA Y PROVEEDOR
                                    .DebeME = Math.Abs(oeMD.MontoOperar) : .HaberME = 0
                                    .DebeMN = Math.Abs(oeMD.MontoOperar) * Obj(1) : .HaberMN = 0
                                Else 'VENTA Y CLIENTE
                                    .DebeME = 0 : .HaberME = Math.Abs(oeMD.MontoOperar)
                                    .DebeMN = 0 : .HaberMN = Math.Abs(oeMD.MontoOperar) * Obj(1)
                                End If
                            Else 'operador NEGATIVO: resta a compras o ventas
                                If oeMD.IndCompraVenta = "1" Or oeMD.IndCompraVenta = "4" Then 'COMPRA Y PROVEEDOR
                                    .DebeME = 0 : .HaberME = Math.Abs(oeMD.MontoOperar)
                                    .DebeMN = 0 : .HaberMN = Math.Abs(oeMD.MontoOperar) * Obj(1)
                                Else 'VENTA Y CLIENTE
                                    .DebeME = Math.Abs(oeMD.MontoOperar) : .HaberME = 0
                                    .DebeMN = Math.Abs(oeMD.MontoOperar) * Obj(1) : .HaberMN = 0
                                End If
                            End If
                        End If
                    End With
                    oeMD.TipoOperacion = "S" : oeMD.Saldo = Math.Abs(oeMD.Saldo) - Math.Abs(oeMD.MontoOperar)
                    If Math.Abs(Math.Round(oeMD.Saldo, 2)) = 0 Then oeMD.Saldo = 0
                    oeMD._idMovimientoCajaBanco = "" : oeMD.CuentaxCyP = New e_CuentaxCyP
                    With oeMD.CuentaxCyP
                        .TipoOperacion = "I" : .IdMovimientoCajaBanco = "" : .IdMovimientoDocumento = oeMD.Id : .Fecha = Obj(0)
                        .PrefijoID = oeMD.PrefijoID
                        If oeMD.IdMoneda = "1CH01" Then 'SOLES
                            .MontoMN = Math.Abs(oeMD.MontoOperar) : .MontoMe = Math.Abs(oeMD.MontoOperar) / Obj(1)
                        Else
                            .MontoMN = Math.Abs(oeMD.MontoOperar) * Obj(1) : .MontoMe = Math.Abs(oeMD.MontoOperar)
                        End If
                        .Activo = 1 : .UsuarioCreacion = Obj(3) : .MacPCLocalCreacion = Obj(4)
                        For Each oeMD2 As e_MovimientoDocumento In leDocumentosAgregados
                            If oeMD.Id <> oeMD2.Id Then
                                .MovDocCta.TipoOperacion = "I" : .MovDocCta.idMovimientoDocumento = oeMD2.Id
                                Exit For
                            End If
                        Next
                        .AsMov_MovDoc = New e_AsientoMov_MovDoc
                        .AsMov_MovDoc.TipoOperacion = "I" : .AsMov_MovDoc.IdMovimientoDocumento = oeMD.Id
                    End With
                    oeAsientoMovimiento.MovimientoDocumento = oeMD
                    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                Next
                Using transScope As New TransactionScope()
                    odAsiento.Guardar(oeAsiento, Nothing)
                    For Each doc In leDocumentosAgregados.Where(Function(i) i.IdMoneda = "1CH02" And i.Saldo = 0)
                        Dim ds As DataSet
                        ds = odMovimientoDocumento.ObtenerAJusteTipoCambio("DOC", doc.Id, "", Date.Parse(Obj(0)).Year)
                        Dim DebeMN As Decimal = ds.Tables(0).Rows(0).Item("DebeMN")
                        Dim HaberMN As Decimal = ds.Tables(0).Rows(0).Item("HaberMN")
                        If DebeMN <> HaberMN Then
                            Dim glosaajuste As String = IIf(DebeMN > HaberMN, "ASIENTO DE PERDIDA /", "ASIENTO DE GANACIA /") & "" & doc.Serie & doc.Numero & " " & doc._NombreClienteProveedor
                            oeAsiento = New e_Asiento
                            Dim oeAsientoMovDoc As New e_AsientoMovimiento
                            Dim oeAsientoMovDif As New e_AsientoMovimiento
                            With oeAsiento
                                .IdPeriodo = oePeriodo.Id : .IdTipoAsiento = "DIARIO" : .NroAsiento = "" : .Fecha = Date.Parse(Obj(0)) : .Glosa = glosaajuste
                                .GlosaImprime = .Glosa : .IdMoneda = "1CH01" : .TipoCambio = 0.0
                                .TotalDebe = Math.Abs(Math.Round(DebeMN - HaberMN, 2)) : .TotalHaber = Math.Abs(Math.Round(DebeMN - HaberMN, 2))
                                .IdUsuarioCrea = Obj(3) : .IdEstado = "CUADRADO" : .Activo = True : .TipoOperacion = "I"
                                .IdentificaAsiento = "AJUSTETCMD" + doc.Id : .IndOrigen = 26
                                oeAsientoMovDoc = New e_AsientoMovimiento
                                oeAsientoMovDoc.TipoOperacion = "I" : oeAsientoMovDoc.Id = "" : oeAsientoMovDoc.IdCuentaContable = doc.IdCuentaContable
                                oeAsientoMovDoc.Glosa = .Glosa : oeAsientoMovDoc.DebeME = 0 : oeAsientoMovDoc.HaberME = 0
                                oeAsientoMovDoc.DebeMN = IIf(DebeMN > HaberMN, 0, HaberMN - DebeMN) : oeAsientoMovDoc.HaberMN = IIf(HaberMN > DebeMN, 0, DebeMN - HaberMN)
                                oeAsientoMovDoc.IdUsuarioCrea = Obj(3)
                                oeAsientoMovDoc.AsMov_MovDoc = New e_AsientoMov_MovDoc
                                oeAsientoMovDoc.AsMov_MovDoc.TipoOperacion = "I" : oeAsientoMovDoc.AsMov_MovDoc.Activo = True
                                oeAsientoMovDoc.AsMov_MovDoc.IdMovimientoDocumento = doc.Id
                                .AsientoMovimiento.Add(oeAsientoMovDoc)
                                oeAsientoMovDif = New e_AsientoMovimiento
                                oeAsientoMovDif.TipoOperacion = "I" : oeAsientoMovDif.Id = ""
                                oeAsientoMovDif.IdCuentaContable = IIf(HaberMN > DebeMN, leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_GANANCIA")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_PERDIDAS")(0).Texto2)
                                oeAsientoMovDif.Glosa = .Glosa : oeAsientoMovDif.DebeME = 0 : oeAsientoMovDif.HaberME = 0
                                oeAsientoMovDif.DebeMN = IIf(DebeMN > HaberMN, Math.Abs(DebeMN - HaberMN), 0.0)
                                oeAsientoMovDif.HaberMN = IIf(HaberMN > DebeMN, Math.Abs(HaberMN - DebeMN), 0.0)
                                oeAsientoMovDif.IdUsuarioCrea = Obj(3)
                                If DebeMN > HaberMN Then
                                    oeAsientoMovDif.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                                    Dim oeMovAana As New e_MovimientoAnalisis
                                    oeMovAana.TipoOperacion = "I" : oeMovAana.IdGastoFuncion = "1CH000090" : oeMovAana.Activo = True
                                    oeMovAana.Monto = DebeMN - HaberMN : oeMovAana.Saldo = oeMovAana.Monto
                                    oeAsientoMovDif.MovimientoAnalisis.Add(oeMovAana)
                                End If
                                .AsientoMovimiento.Add(oeAsientoMovDif)
                            End With
                            odAsiento.Guardar(oeAsiento, Nothing)
                        End If
                    Next
                    transScope.Complete()
                End Using
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function GuardarCancelacionMovimientoAnalisis(ByVal leMovimientosAgregados As  _
    System.Collections.Generic.List(Of e_MovimientoAnalisis), ByVal Obj() As Object) As Boolean _
    Implements Il_MovimientoDocumento.GuardarCancelacionMovimientoAnalisis
        Try

            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            oePeriodo.Codigo = Date.Parse(Obj(0)).Year.ToString + "-" + Date.Parse(Obj(0)).Month.ToString
            oePeriodo.Activo = True
            oePeriodo = olPeriodo.Obtener(oePeriodo)

            Dim loFuncionesGenerales As New l_FuncionesGenerales
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, Date.Parse(Obj(0)), Date.Parse(Obj(0)).Year.ToString + "-" + Date.Parse(Obj(0)).Month.ToString)
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Date.Parse(Obj(0)), Date.Parse(Obj(0)).Year.ToString + "-" + Date.Parse(Obj(0)).Month.ToString)

            Dim oeAsiento As New e_Asiento
            Dim odAsiento As New d_Asiento

            With oeAsiento
                .TipoOperacion = "I"
                .IdPeriodo = oePeriodo.Id
                .IdTipoAsiento = "DIARIO"
                .Fecha = Date.Parse(Obj(0))
                .Glosa = "CANC. POR APLIC. DE DCTOS: " & leMovimientosAgregados.Item(0).Cuenta & " - " & leMovimientosAgregados.Item(1).Cuenta
                .GlosaImprime = .Glosa
                .IdMoneda = Obj(2)
                .TipoCambio = Obj(1)
                .TotalDebe = Math.Abs(leMovimientosAgregados(0).Monto)
                .TotalHaber = Math.Abs(leMovimientosAgregados(0).Monto)
                .IdEstado = "CUADRADO"
                .IdUsuarioCrea = Obj(3)
                .IndOrigen = 25
            End With

            Dim oeAsientoMovimiento As New e_AsientoMovimiento
            Dim oeMovAnalisi As New e_MovimientoAnalisis
            Dim lsCta As String = ""
            Dim SignoNum As Integer = 0
            leMovimientosAgregados = leMovimientosAgregados.OrderBy(Function(item) item.IdCuentaContable).ToList
            For Each oeMD As e_MovimientoAnalisis In leMovimientosAgregados

                If leMovimientosAgregados.Count < 3 Then
                    oeAsientoMovimiento = New e_AsientoMovimiento
                    With oeAsientoMovimiento
                        .TipoOperacion = "I"
                        .IdCuentaContable = oeMD.IdCuentaContable
                        .Glosa = .Glosa & " /" & oeMD.Glosa
                        .IdUsuarioCrea = Obj(3)

                        If oeMD.IdMoneda = "1CH01" Then 'SOLES
                            If oeMD.Monto < 0 Then 'operador POSITIVO: suma a compreso ventas
                                .DebeMN = Math.Abs(oeMD.Monto)
                                .HaberMN = 0
                                .DebeME = Math.Abs(oeMD.Monto) / Obj(1)
                                .HaberME = 0
                            Else 'operador NEGATIVO: resta a compras o ventas
                                .DebeMN = 0
                                .HaberMN = Math.Abs(oeMD.Monto)
                                .DebeME = 0
                                .HaberME = Math.Abs(oeMD.Monto) / Obj(1)
                            End If
                        Else 'DOLARES
                            If oeMD.Monto < 0 Then 'operador POSITIVO: suma a compreso ventas
                                .DebeME = Math.Abs(oeMD.Monto)
                                .HaberME = 0
                                .DebeMN = Math.Abs(oeMD.Monto) * Obj(1)
                                .HaberMN = 0
                            Else 'operador NEGATIVO: resta a compras o ventas
                                .DebeME = 0
                                .HaberME = Math.Abs(oeMD.Monto)
                                .DebeMN = 0
                                .HaberMN = Math.Abs(oeMD.Monto) * Obj(1)
                            End If
                        End If
                    End With
                    oeMovAnalisi = New e_MovimientoAnalisis
                    oeMovAnalisi = oeMD.Clone
                    oeMovAnalisi.Saldo = 0
                    oeMovAnalisi.Monto = Math.Abs(oeMovAnalisi.Monto)
                    oeMovAnalisi._IdMovimientoAnalisis = oeMD.Id
                    oeAsientoMovimiento.DivideAnalisis = False
                    oeAsientoMovimiento.MovimientoAnalisis.Add(oeMovAnalisi)
                    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                Else
                    If lsCta <> oeMD.IdCuentaContable Or SignoNum <> (oeMD.Monto / Math.Abs(oeMD.Monto)) Then
                        lsCta = oeMD.IdCuentaContable
                        oeAsientoMovimiento = New e_AsientoMovimiento
                        With oeAsientoMovimiento
                            .TipoOperacion = "I"
                            .IdCuentaContable = oeMD.IdCuentaContable
                            .Glosa = .Glosa & " /" & oeMD.Glosa
                            .IdUsuarioCrea = Obj(3)
                            If oeMD.IdMoneda = "1CH01" Then 'SOLES
                                If oeMD.Monto < 0 Then 'operador POSITIVO: suma a compreso ventas
                                    SignoNum = -1
                                    .DebeMN = Math.Abs(oeMD.Monto)
                                    .HaberMN = 0
                                    .DebeME = Math.Abs(oeMD.Monto) / Obj(1)
                                    .HaberME = 0
                                Else 'operador NEGATIVO: resta a compras o ventas
                                    SignoNum = 1
                                    .DebeMN = 0
                                    .HaberMN = Math.Abs(oeMD.Monto)
                                    .DebeME = 0
                                    .HaberME = Math.Abs(oeMD.Monto) / Obj(1)
                                End If
                            Else 'DOLARES
                                If oeMD.Monto < 0 Then 'operador POSITIVO: suma a compreso ventas
                                    SignoNum = -1
                                    .DebeME = Math.Abs(oeMD.Monto)
                                    .HaberME = 0
                                    .DebeMN = Math.Abs(oeMD.Monto) * Obj(1)
                                    .HaberMN = 0
                                Else 'operador NEGATIVO: resta a compras o ventas
                                    SignoNum = 1
                                    .DebeME = 0
                                    .HaberME = Math.Abs(oeMD.Monto)
                                    .DebeMN = 0
                                    .HaberMN = Math.Abs(oeMD.Monto) * Obj(1)
                                End If
                            End If
                        End With
                        oeMovAnalisi = New e_MovimientoAnalisis
                        oeMovAnalisi = oeMD.Clone
                        oeMovAnalisi.Saldo = 0
                        oeMovAnalisi.Monto = Math.Abs(oeMovAnalisi.Monto)
                        oeMovAnalisi._IdMovimientoAnalisis = oeMD.Id
                        oeAsientoMovimiento.DivideAnalisis = False
                        oeAsientoMovimiento.MovimientoAnalisis.Add(oeMovAnalisi)
                        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                    Else
                        With oeAsientoMovimiento
                            If oeMD.IdMoneda = "1CH01" Then 'SOLES
                                If oeMD.Monto < 0 Then 'operador POSITIVO: suma a compreso ventas
                                    .DebeMN = .DebeMN + Math.Abs(oeMD.Monto)
                                    .HaberMN = 0
                                    .DebeME = .DebeME + Math.Abs(oeMD.Monto) / Obj(1)
                                    .HaberME = 0
                                Else 'operador NEGATIVO: resta a compras o ventas
                                    .DebeMN = 0
                                    .HaberMN = .HaberMN + Math.Abs(oeMD.Monto)
                                    .DebeME = 0
                                    .HaberME = .HaberME + Math.Abs(oeMD.Monto) / Obj(1)
                                End If
                            Else 'DOLARES
                                If oeMD.Monto < 0 Then 'operador POSITIVO: suma a compreso ventas
                                    .DebeME = .DebeME + Math.Abs(oeMD.Monto)
                                    .HaberME = 0
                                    .DebeMN = .DebeMN + Math.Abs(oeMD.Monto) * Obj(1)
                                    .HaberMN = 0
                                Else 'operador NEGATIVO: resta a compras o ventas
                                    .DebeME = 0
                                    .HaberME = .HaberME + Math.Abs(oeMD.Monto)
                                    .DebeMN = 0
                                    .HaberMN = .HaberMN + Math.Abs(oeMD.Monto) * Obj(1)
                                End If
                            End If
                        End With
                        oeMovAnalisi = New e_MovimientoAnalisis
                        oeMovAnalisi = oeMD.Clone
                        oeMovAnalisi.Saldo = 0
                        oeMovAnalisi.Monto = Math.Abs(oeMovAnalisi.Monto)
                        oeMovAnalisi._IdMovimientoAnalisis = oeMD.Id
                        oeAsientoMovimiento.DivideAnalisis = False
                        oeAsientoMovimiento.MovimientoAnalisis.Add(oeMovAnalisi)
                    End If
                End If
                oeMD.TipoOperacion = "F"
                oeMD.Saldo = Math.Abs(oeMD.Saldo) - Math.Abs(oeMD.Monto)
                If Math.Abs(Math.Round(oeMD.Saldo, 2)) = 0 Then
                    oeMD.Saldo = 0
                End If
            Next
            odAsiento.GuardarAplicacion(oeAsiento, leMovimientosAgregados)
            Return True
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function GuardarAnalisisYDocumento(ByVal leMovimientosAgregados As  _
    System.Collections.Generic.List(Of e_MovimientoAnalisis), ByVal leDocumentosAgregados As  _
    System.Collections.Generic.List(Of e_MovimientoDocumento), ByVal Obj() As Object) As Boolean _
    Implements Il_MovimientoDocumento.GuardarAnalisisYDocumento
        Try
            Dim loFuncionesGenerales As New l_FuncionesGenerales
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, Date.Parse(Obj(0)), Date.Parse(Obj(0)).Year.ToString + "-" + Date.Parse(Obj(0)).Month.ToString)
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Date.Parse(Obj(0)), Date.Parse(Obj(0)).Year.ToString + "-" + Date.Parse(Obj(0)).Month.ToString)

            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            oePeriodo.Codigo = Date.Parse(Obj(0)).Year.ToString + "-" + Date.Parse(Obj(0)).Month.ToString
            oePeriodo.Activo = True
            oePeriodo = olPeriodo.Obtener(oePeriodo)

            Dim oeAsiento As New e_Asiento
            Dim odAsiento As New d_Asiento

            With oeAsiento
                .TipoOperacion = "I"
                .IdPeriodo = oePeriodo.Id
                .IdTipoAsiento = "DIARIO"
                .Fecha = Date.Parse(Obj(0))
                .Glosa = "CANC. POR APLIC. DE DCTOS: " & leMovimientosAgregados.Item(0).Cuenta & " - " & leDocumentosAgregados.Item(0).oeTipoDocumento.Nombre & "/ " & leDocumentosAgregados.Item(0).Serie & leDocumentosAgregados.Item(0).Numero
                .GlosaImprime = .Glosa
                .IdMoneda = Obj(2)
                .TipoCambio = Obj(1)
                .TotalDebe = Math.Abs(leMovimientosAgregados(0).Monto)
                .TotalHaber = Math.Abs(leMovimientosAgregados(0).Monto)
                .IdEstado = "CUADRADO"
                .IdUsuarioCrea = Obj(3)
                .IndOrigen = 25
            End With

            Dim oeAsientoMovimiento As e_AsientoMovimiento
            For Each oeMD As e_MovimientoAnalisis In leMovimientosAgregados
                oeAsientoMovimiento = New e_AsientoMovimiento
                With oeAsientoMovimiento
                    .TipoOperacion = "I"
                    .IdCuentaContable = oeMD.IdCuentaContable
                    .Glosa = oeAsiento.Glosa & "/ " & oeMD.Glosa
                    .IdUsuarioCrea = Obj(3)

                    If oeMD.IdMoneda = "1CH01" Then 'SOLES
                        If oeMD.Monto < 0 Then 'operador POSITIVO: suma a compreso ventas
                            .DebeMN = Math.Abs(oeMD.Monto)
                            .HaberMN = 0
                            .DebeME = Math.Abs(oeMD.Monto) / Obj(1)
                            .HaberME = 0
                        Else 'operador NEGATIVO: resta a compras o ventas
                            .DebeMN = 0
                            .HaberMN = Math.Abs(oeMD.Monto)
                            .DebeME = 0
                            .HaberME = Math.Abs(oeMD.Monto) / Obj(1)
                        End If
                    Else 'DOLARES
                        If oeMD.Monto < 0 Then 'operador POSITIVO: suma a compreso ventas
                            .DebeME = Math.Abs(oeMD.Monto)
                            .HaberME = 0
                            .DebeMN = Math.Abs(oeMD.Monto) * Obj(1)
                            .HaberMN = 0
                        Else 'operador NEGATIVO: resta a compras o ventas
                            .DebeME = 0
                            .HaberME = Math.Abs(oeMD.Monto)
                            .DebeMN = 0
                            .HaberMN = Math.Abs(oeMD.Monto) * Obj(1)
                        End If
                    End If
                End With
                Dim oeMovAnalisi As New e_MovimientoAnalisis
                oeMovAnalisi = oeMD.Clone
                oeMovAnalisi.Saldo = 0
                oeMovAnalisi.Monto = Math.Abs(oeMovAnalisi.Monto)
                oeMovAnalisi._IdMovimientoAnalisis = oeMD.Id
                oeAsientoMovimiento.DivideAnalisis = False
                oeAsientoMovimiento.MovimientoAnalisis.Add(oeMovAnalisi)

                oeMD.TipoOperacion = "F"
                oeMD.Saldo = Math.Abs(oeMD.Saldo) - Math.Abs(oeMD.Monto)
                If Math.Abs(Math.Round(oeMD.Saldo, 2)) = 0 Then
                    oeMD.Saldo = 0
                End If
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            Next

            oeAsientoMovimiento = New e_AsientoMovimiento
            For Each oeMD As e_MovimientoDocumento In leDocumentosAgregados
                oeAsientoMovimiento = New e_AsientoMovimiento
                With oeAsientoMovimiento
                    .TipoOperacion = "I"
                    .IdCuentaContable = oeMD.IdCuentaContable
                    .Glosa = "CANC. POR APLIC. DE DCTOS " & oeMD.oeTipoDocumento.Abreviatura & "/ " & oeMD.Serie + oeMD.Numero & " " & leDocumentosAgregados(0)._NombreClienteProveedor
                    .IdUsuarioCrea = Obj(3)

                    If oeMD.IdMoneda = "1CH01" Then 'SOLES
                        If oeMD._Operador > 0 Then 'operador POSITIVO: suma a compreso ventas
                            If oeMD.IndCompraVenta = "1" Or oeMD.IndCompraVenta = "4" Then 'COMPRA Y PROVEEDOR
                                .DebeMN = Math.Abs(oeMD.MontoOperar)
                                .HaberMN = 0
                                .DebeME = Math.Abs(oeMD.MontoOperar) / Obj(1)
                                .HaberME = 0
                            Else 'VENTA Y CLIENTE
                                .DebeMN = 0
                                .HaberMN = Math.Abs(oeMD.MontoOperar)
                                .DebeME = 0
                                .HaberME = Math.Abs(oeMD.MontoOperar) / Obj(1)
                            End If
                        Else 'operador NEGATIVO: resta a compras o ventas
                            If oeMD.IndCompraVenta = "1" Or oeMD.IndCompraVenta = "4" Then 'COMPRA Y PROVEEDOR
                                .DebeMN = 0
                                .HaberMN = Math.Abs(oeMD.MontoOperar)
                                .DebeME = 0
                                .HaberME = Math.Abs(oeMD.MontoOperar) / Obj(1)
                            Else 'VENTA Y CLIENTE
                                .DebeMN = Math.Abs(oeMD.MontoOperar)
                                .HaberMN = 0
                                .DebeME = Math.Abs(oeMD.MontoOperar) / Obj(1)
                                .HaberME = 0
                            End If
                        End If
                    Else 'DOLARES
                        If oeMD._Operador > 0 Then 'operador POSITIVO: suma a compreso ventas
                            If oeMD.IndCompraVenta = "1" Or oeMD.IndCompraVenta = "4" Then 'COMPRA Y PROVEEDOR
                                .DebeME = Math.Abs(oeMD.MontoOperar)
                                .HaberME = 0
                                .DebeMN = Math.Abs(oeMD.MontoOperar) * Obj(1)
                                .HaberMN = 0
                            Else 'VENTA Y CLIENTE
                                .DebeME = 0
                                .HaberME = Math.Abs(oeMD.MontoOperar)
                                .DebeMN = 0
                                .HaberMN = Math.Abs(oeMD.MontoOperar) * Obj(1)
                            End If
                        Else 'operador NEGATIVO: resta a compras o ventas
                            If oeMD.IndCompraVenta = "1" Or oeMD.IndCompraVenta = "4" Then 'COMPRA Y PROVEEDOR
                                .DebeME = 0
                                .HaberME = Math.Abs(oeMD.MontoOperar)
                                .DebeMN = 0
                                .HaberMN = Math.Abs(oeMD.MontoOperar) * Obj(1)
                            Else 'VENTA Y CLIENTE
                                .DebeME = Math.Abs(oeMD.MontoOperar)
                                .HaberME = 0
                                .DebeMN = Math.Abs(oeMD.MontoOperar) * Obj(1)
                                .HaberMN = 0
                            End If
                        End If
                    End If
                End With
                oeMD.TipoOperacion = "S"
                oeMD.Saldo = Math.Abs(oeMD.Saldo) - Math.Abs(oeMD.MontoOperar)
                If Math.Abs(Math.Round(oeMD.Saldo, 2)) = 0 Then
                    oeMD.Saldo = 0
                End If
                oeMD._idMovimientoCajaBanco = ""
                oeMD.CuentaxCyP = New e_CuentaxCyP
                With oeMD.CuentaxCyP
                    .TipoOperacion = "I"
                    .IdMovimientoCajaBanco = ""
                    .IdMovimientoDocumento = oeMD.Id
                    .Fecha = Obj(0)
                    If oeMD.IdMoneda = "1CH01" Then 'SOLES
                        .MontoMN = Math.Abs(oeMD.MontoOperar)
                        .MontoMe = Math.Abs(oeMD.MontoOperar) / Obj(1)
                    Else
                        .MontoMN = Math.Abs(oeMD.MontoOperar) * Obj(1)
                        .MontoMe = Math.Abs(oeMD.MontoOperar)
                    End If
                    .Activo = 1
                    .UsuarioCreacion = Obj(3)
                    .MacPCLocalCreacion = Obj(4)
                    For Each oeMD2 As e_MovimientoDocumento In leDocumentosAgregados
                        If oeMD.Id <> oeMD2.Id Then
                            .MovDocCta.TipoOperacion = "I"
                            .MovDocCta.idMovimientoDocumento = oeMD2.Id
                            Exit For
                        End If
                    Next
                    .AsMov_MovDoc = New e_AsientoMov_MovDoc
                    .AsMov_MovDoc.TipoOperacion = "I"
                    .AsMov_MovDoc.IdMovimientoDocumento = oeMD.Id
                End With
                oeAsientoMovimiento.MovimientoDocumento = oeMD
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            Next

            Using transScope As New TransactionScope()

                odAsiento.GuardarAplicacion(oeAsiento, leMovimientosAgregados)

                For Each doc In leDocumentosAgregados.Where(Function(i) i.IdMoneda = "1CH02" And i.Saldo = 0)
                    Dim ds As DataSet
                    ds = odMovimientoDocumento.ObtenerAJusteTipoCambio("DOC", doc.Id, "", Date.Parse(Obj(0)).Year)
                    Dim DebeMN As Decimal = ds.Tables(0).Rows(0).Item("DebeMN")
                    Dim HaberMN As Decimal = ds.Tables(0).Rows(0).Item("HaberMN")

                    If DebeMN <> HaberMN Then

                        Dim glosaajuste As String = IIf(DebeMN > HaberMN, "ASIENTO DE PERDIDA /", "ASIENTO DE GANACIA /") & "" & doc.Serie & doc.Numero & " " & doc._NombreClienteProveedor

                        oeAsiento = New e_Asiento
                        Dim oeAsientoMovDoc As New e_AsientoMovimiento
                        Dim oeAsientoMovDif As New e_AsientoMovimiento

                        With oeAsiento
                            .IdPeriodo = oePeriodo.Id
                            .IdTipoAsiento = "DIARIO"
                            .NroAsiento = ""
                            .Fecha = Date.Parse(Obj(0))
                            .Glosa = glosaajuste
                            .GlosaImprime = .Glosa
                            .IdMoneda = "1CH01"
                            .TipoCambio = 0.0
                            .TotalDebe = Math.Abs(Math.Round(DebeMN - HaberMN, 2))
                            .TotalHaber = Math.Abs(Math.Round(DebeMN - HaberMN, 2))
                            .IdUsuarioCrea = Obj(3)
                            .IdEstado = "CUADRADO"
                            .Activo = True
                            .TipoOperacion = "I"
                            .IdentificaAsiento = "AJUSTETCMD" + doc.Id
                            .IndOrigen = 26

                            oeAsientoMovDoc = New e_AsientoMovimiento
                            oeAsientoMovDoc.TipoOperacion = "I"
                            oeAsientoMovDoc.Id = ""
                            oeAsientoMovDoc.IdCuentaContable = doc.IdCuentaContable
                            oeAsientoMovDoc.Glosa = .Glosa
                            oeAsientoMovDoc.DebeME = 0
                            oeAsientoMovDoc.HaberME = 0
                            oeAsientoMovDoc.DebeMN = IIf(DebeMN > HaberMN, 0, HaberMN - DebeMN)
                            oeAsientoMovDoc.HaberMN = IIf(HaberMN > DebeMN, 0, DebeMN - HaberMN)
                            oeAsientoMovDoc.IdUsuarioCrea = Obj(3)
                            oeAsientoMovDoc.AsMov_MovDoc = New e_AsientoMov_MovDoc
                            oeAsientoMovDoc.AsMov_MovDoc.TipoOperacion = "I"
                            oeAsientoMovDoc.AsMov_MovDoc.Activo = True
                            oeAsientoMovDoc.AsMov_MovDoc.IdMovimientoDocumento = doc.Id
                            .AsientoMovimiento.Add(oeAsientoMovDoc)

                            oeAsientoMovDif = New e_AsientoMovimiento
                            oeAsientoMovDif.TipoOperacion = "I"
                            oeAsientoMovDif.Id = ""
                            oeAsientoMovDif.IdCuentaContable = IIf(HaberMN > DebeMN, leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_GANANCIA")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_PERDIDAS")(0).Texto2)
                            oeAsientoMovDif.Glosa = .Glosa
                            oeAsientoMovDif.DebeME = 0
                            oeAsientoMovDif.HaberME = 0
                            oeAsientoMovDif.DebeMN = IIf(DebeMN > HaberMN, Math.Abs(DebeMN - HaberMN), 0.0)
                            oeAsientoMovDif.HaberMN = IIf(HaberMN > DebeMN, Math.Abs(HaberMN - DebeMN), 0.0)
                            oeAsientoMovDif.IdUsuarioCrea = Obj(3)
                            If DebeMN > HaberMN Then
                                oeAsientoMovDif.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                                Dim oeMovAana As New e_MovimientoAnalisis
                                oeMovAana.TipoOperacion = "I"
                                oeMovAana.IdGastoFuncion = "1CH000090"
                                oeMovAana.Activo = True
                                oeMovAana.Monto = DebeMN - HaberMN
                                oeMovAana.Saldo = oeMovAana.Monto
                                oeAsientoMovDif.MovimientoAnalisis.Add(oeMovAana)
                            End If
                            .AsientoMovimiento.Add(oeAsientoMovDif)
                        End With
                        odAsiento.Guardar(oeAsiento, Nothing)
                    End If
                Next

                transScope.Complete()

            End Using
            Return True
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function GuardarCompra(ByVal oeMovimientoDocumento As e_MovimientoDocumento, _
     ByVal leMovimientoDocumento As System.Collections.Generic.List(Of e_MovimientoDocumento), _
    Optional ByVal IndComprobanteCompra As Boolean = False,
    Optional ByVal oeObligacion As e_ObligacionFin = Nothing) As Boolean _
    Implements Il_MovimientoDocumento.GuardarCompra
        Try

            Dim fecAsiento As Date = olFuncionesGenerales.gfc_ObtenerFechaAsiento(oeMovimientoDocumento.FechaEmision, oeMovimientoDocumento.FechaFinal)

            With oeMovimientoDocumento
                Dim oeAsiento As New e_Asiento
                If IndComprobanteCompra = True Then
                    ValidarCompraVenta(oeMovimientoDocumento, True, gAreasSGI.Compras)
                    If .TipoOperacion = "A" Then
                        Dim oeAsMovDoc As New e_Asiento_MovDoc
                        Dim odAsMovDoc As New d_Asiento_MovDoc
                        oeAsMovDoc.Activo = True
                        oeAsMovDoc.IdMovimientoDocumento = .Id
                        oeAsMovDoc = odAsMovDoc.Listar(oeAsMovDoc)(0)
                        oeAsiento.Id = oeAsMovDoc.IdAsiento
                        oeAsMovDoc = Nothing
                        odAsMovDoc = Nothing
                    Else
                        oeAsiento.Fecha = fecAsiento
                        oeAsiento.IdUsuarioCrea = .IdUsuarioCrea
                        oeAsiento.Activo = True
                    End If
                    oeAsiento.TipoOperacion = .TipoOperacion
                Else
                    oeAsiento.Fecha = fecAsiento
                    oeAsiento.IdUsuarioCrea = .IdUsuarioCrea
                    oeAsiento.Activo = True
                    oeAsiento.TipoOperacion = "I"
                End If
                oeAsiento.IdPeriodo = .IdPeriodo
                oeAsiento.IdTipoAsiento = "COMPRAS" 'Tipo de asiento Compra
                oeAsiento.Glosa = "COMPRA " & .Compra.TipoDoc.Abreviatura & "/" & .Serie & .Numero & " " & .Compra.Proveedor.Nombre
                oeAsiento.GlosaImprime = "COMPRA " & .Compra.TipoDoc.Abreviatura & "/" & .Serie & .Numero & " " & .Compra.Proveedor.Nombre
                oeAsiento.IdMoneda = .IdMoneda
                oeAsiento.TipoCambio = .TipoCambio
                oeAsiento.TotalDebe = .Total
                oeAsiento.TotalHaber = .Total
                oeAsiento.IdUsuarioBloquea = ""
                oeAsiento.IdEstado = "CUADRADO" 'Estado Cuadrado
                oeAsiento.IdAsientoExtorno = ""
                oeAsiento.IndOrigen = oeMovimientoDocumento.IndOrigenContable

                '------------------Cuentas Generales---------------
                Dim oeCuentaGenerales As New e_TablaContableDet
                Dim leCuentasGenerales As New List(Of e_TablaContableDet)
                Dim olFuncionesGenerales As New l_FuncionesGenerales
                ''oeCuentaGenerales.Valor1 = oeMovimientoDocumento.FechaEmision.Year
                oePeriodo = New e_Periodo
                oePeriodo.Id = oeAsiento.IdPeriodo
                oeCuentaGenerales.Valor1 = olPeriodo.Obtener(oePeriodo).Ejercicio
                leCuentasGenerales.AddRange(olFuncionesGenerales.CuentasGenerales(oeCuentaGenerales))
                '-------------------------------------------------------
                Dim ListaFiltro As New List(Of e_TablaContableDet)
                '------------------ linea(42)----------------------------
                ListaFiltro = leCuentasGenerales.ToList
                Dim oeMovimientoAsiento42 As New e_AsientoMovimiento
                oeMovimientoAsiento42 = Linea42(oeMovimientoDocumento, oeAsiento, ListaFiltro)
                '-----------------------------------------------'
                '--------------Lineas Impuestos--------------------
                ListaFiltro = leCuentasGenerales.ToList
                Dim ListaImpuesto As New List(Of e_AsientoMovimiento)
                ListaImpuesto = LineaImpuestosCompras(oeMovimientoDocumento, oeAsiento, ListaFiltro)
                '-----------------------------------------------
                '------------------ linea(60)o(20)----------------------------
                Dim oeMovimientoAsiento60 As New List(Of e_AsientoMovimiento)
                oeMovimientoAsiento60 = Linea60(oeMovimientoDocumento, oeAsiento, True, oeObligacion)
                '-----------------------------------------------------------'
                '------------------LineasDestino(20)-----------------------------
                Dim oeMovimientoAsientoDestino As New List(Of e_AsientoMovimiento)
                If Not leMovimientoDocumento Is Nothing Then
                    For Each objMov As e_MovimientoDocumento In leMovimientoDocumento
                        If objMov.Compra.TipoCompra.Texto2.Trim <> "" Then 'existe destino
                            oeMovimientoAsientoDestino.AddRange(LineasDestinoCompras(objMov, oeAsiento))
                        End If
                    Next
                Else
                    If oeMovimientoDocumento.Compra.TipoCompra.Texto2.Trim <> "" Then 'existe destino
                        oeMovimientoAsientoDestino = LineasDestinoCompras(oeMovimientoDocumento, oeAsiento)
                    End If
                End If

                '---------------------------------------------------------------
                If .Compra.TipoDoc.Codigo <> "07" Then
                    oeAsiento.AsientoMovimiento.AddRange(oeMovimientoAsiento60)
                    If ListaImpuesto.Count > 0 Then
                        oeAsiento.AsientoMovimiento.AddRange(ListaImpuesto)
                    End If
                    oeAsiento.AsientoMovimiento.Add(oeMovimientoAsiento42)
                    oeAsiento.AsientoMovimiento.AddRange(oeMovimientoAsientoDestino)
                Else
                    oeAsiento.AsientoMovimiento.Add(oeMovimientoAsiento42)
                    If ListaImpuesto.Count > 0 Then
                        oeAsiento.AsientoMovimiento.AddRange(ListaImpuesto)
                    End If
                    oeAsiento.AsientoMovimiento.AddRange(oeMovimientoAsiento60)
                    oeAsiento.AsientoMovimiento.AddRange(oeMovimientoAsientoDestino)
                End If
                '---------hasta aqui tengo asiento que reemplaza al existente-----------------
                If .TipoOperacion = "A" And IndComprobanteCompra = True Then
                    Dim oeAs As New e_Asiento
                    Dim odAs As New d_Asiento
                    oeAs.Id = oeAsiento.Id
                    oeAs = odAs.Obtener(oeAs)
                    oeAsiento.Fecha = oeAs.Fecha
                    For Each obj As e_AsientoMovimiento In oeAs.AsientoMovimiento
                        obj.TipoOperacion = "E"
                        oeAsiento.AsientoMovimiento.Add(obj)
                    Next
                    oeAs = Nothing
                    odAs = Nothing
                End If

                Return odMovimientoDocumento.GuardarCompra(oeMovimientoDocumento, oeAsiento)
            End With

        Catch ex As Exception
            Throw
        End Try

    End Function

    ''' <summary>
    ''' PARA VENTAS DE TRANSPORTES -FLETES
    ''' </summary>
    ''' <param name="oeMovimientoDoc"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GuardarMasivo(ByVal oeMovimientoDoc As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.GuardarMasivo
        Try
            Dim olDetalleDoc As New l_DetalleDocumento, odDetalleDoc As New d_DetalleDocumento
            Dim olDetalleDocGuiaTrans As New l_DetalleDoc_GuiaTrans, odDetalleDocGuiaTrans As New d_DetalleDoc_GuiaTrans
            Dim dtDD As Data.DataTable = olDetalleDoc.CrearDT
            Dim dtDDGT As Data.DataTable = olDetalleDocGuiaTrans.CrearDT

            If Validar(oeMovimientoDoc) Then
                If oeMovimientoDoc.Id = "" Then
                    oeMovimientoDoc.TipoOperacion = "I"
                Else
                    oeMovimientoDoc.TipoOperacion = "A"
                End If
                oeMovimientoDoc.IdCuentaContable = ""
                If oeMovimientoDoc.Venta.Id = "" Then
                    oeMovimientoDoc.Venta.TipoOperacion = "I"
                Else
                    oeMovimientoDoc.Venta.TipoOperacion = "A"
                End If
                oeMovimientoDoc.Venta.Exonerado = 0
                oeMovimientoDoc.Venta.Exportacion = 0
                oeMovimientoDoc.Venta.Inafecto = 0
                oeMovimientoDoc.Venta.ISC = 0
                oeMovimientoDoc.Venta.OtrosTributos = 0
                oeMovimientoDoc.Venta.Descuentos = 0
                oeMovimientoDoc.Venta.IdTipoVenta = ""
                Dim Id As String = odDetalleDoc.UltimoIdInserta(oeMovimientoDoc.PrefijoID)
                Dim lsPrefijo As String = Left(Id, 3)
                Dim lsNumero As Integer = CInt(Right(Id, Len(Id) - 3))
                Dim Idx As String = odDetalleDocGuiaTrans.UltimoIdInserta(oeMovimientoDoc.PrefijoID)
                Dim lsPrefijox As String = Left(Idx, 3)
                Dim lsNumerox As Integer = CInt(Right(Idx, Len(Idx) - 3))
                For Each oeDetalleDoc As e_DetalleDocumento In oeMovimientoDoc.lstDetalleDocumento
                    If oeDetalleDoc.Id = "" Or IsDBNull(oeDetalleDoc.Id = "") Then
                        Dim rwDetalleDoc As Data.DataRow
                        rwDetalleDoc = dtDD.NewRow
                        With oeDetalleDoc
                            rwDetalleDoc("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 9)
                            rwDetalleDoc("IdMovimientoDocumento") = ""
                            rwDetalleDoc("IndServicioMaterial") = .IndServicioMaterial
                            rwDetalleDoc("IdMaterialServicio") = .IdMaterialServicio
                            rwDetalleDoc("Cantidad") = .Cantidad
                            rwDetalleDoc("PrecioUnitario") = .Precio
                            rwDetalleDoc("IndGravado") = .IndGravado
                            rwDetalleDoc("Valor") = .Total
                            rwDetalleDoc("Igv") = .Igv
                            rwDetalleDoc("IdOperacionDetalle") = .IdOperacionDetalle
                            rwDetalleDoc("IdVehiculo") = .IdVehiculo
                            rwDetalleDoc("Activo") = .Activo
                            rwDetalleDoc("UsuarioCreacion") = .UsuarioCreacion
                            rwDetalleDoc("FechaCreacion") = .FechaCreacion
                            rwDetalleDoc("IdUnidadMedida") = .IdUnidadMedida
                            rwDetalleDoc("FactorRefUni") = .FactorRefUni
                            rwDetalleDoc("IdViaje") = .IdViaje
                            rwDetalleDoc("Consolidado") = .Consolidado
                            rwDetalleDoc("IndConsolidado") = .IndConsolidado
                            rwDetalleDoc("GlosaConsolidado") = .GlosaConsolidado
                            rwDetalleDoc("Monto_Anticipo") = .Monto_Anticipo

                            dtDD.Rows.Add(rwDetalleDoc)
                            If oeDetalleDoc.leDetalleGuiaTrans.Count > 0 Then
                                For Each oeDetalleDocGuiaTrans As e_DetalleDoc_GuiaTrans In oeDetalleDoc.leDetalleGuiaTrans
                                    Dim rwDetalleDocGT As Data.DataRow
                                    rwDetalleDocGT = dtDDGT.NewRow
                                    rwDetalleDocGT("Id") = lsPrefijox & CompletaConCeros(lsNumerox.ToString, 12)
                                    rwDetalleDocGT("IdDetalleDoc") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 9)
                                    rwDetalleDocGT("IdGuiaTrans") = oeDetalleDocGuiaTrans.IdGuiaTrans
                                    rwDetalleDocGT("IdEstado") = ""
                                    rwDetalleDocGT("FechaCreacion") = Date.Now
                                    rwDetalleDocGT("UsuarioCreacion") = oeDetalleDocGuiaTrans.UsuarioCreacion
                                    rwDetalleDocGT("Activo") = oeDetalleDocGuiaTrans.Activo
                                    dtDDGT.Rows.Add(rwDetalleDocGT)
                                    lsNumerox = lsNumerox + 1
                                Next
                            End If
                            lsNumero = lsNumero + 1
                        End With
                    End If
                Next
                oeMovimientoDoc.dtDetalleDoc = dtDD
                oeMovimientoDoc.dtDetalleDocGT = dtDDGT
                Return odMovimientoDocumento.GuardarFacturaMasiva(oeMovimientoDoc)
            End If
        Catch ex As Exception
            Throw
        End Try

    End Function

    'Public Function GuardarVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento, Optional ByVal leDocumentos As System.Collections.Generic.List(Of e_MovimientoDocumento) = Nothing) As Boolean Implements Il_MovimientoDocumento.GuardarVenta
    '    Try
    '        If ValidarVenta(oeMovimientoDocumento) Then
    '            With oeMovimientoDocumento
    '                Dim oeAsiento As New e_Asiento
    '                If .TipoOperacion = "A" And leDocumentos Is Nothing Then
    '                    Dim oeAsMovDoc As New e_Asiento_MovDoc
    '                    Dim odAsMovDoc As New d_Asiento_MovDoc
    '                    oeAsMovDoc.Activo = True
    '                    oeAsMovDoc.IdMovimientoDocumento = .Id
    '                    oeAsMovDoc = odAsMovDoc.Listar(oeAsMovDoc)(0)
    '                    oeAsiento.Id = oeAsMovDoc.IdAsiento
    '                    oeAsMovDoc = Nothing
    '                    odAsMovDoc = Nothing
    '                    oeAsiento.TipoOperacion = .TipoOperacion
    '                Else
    '                    oeAsiento.Fecha = oeMovimientoDocumento.FechaEmision
    '                    oeAsiento.IdUsuarioCrea = .IdUsuarioCrea
    '                    oeAsiento.Activo = True
    '                    oeAsiento.TipoOperacion = "I"
    '                End If
    '                oeAsiento.IdPeriodo = .IdPeriodo
    '                oeAsiento.IdTipoAsiento = "VENTAS" 'Tipo de asiento Venta
    '                'oeAsiento.IdTipoAsiento = "1CH000024" 'Tipo de asiento Venta
    '                oeAsiento.Glosa = "VENTA " & .Venta.TipoDoc.Abreviatura & "/" & .Serie & .Numero & " " & .Venta.Cliente.Nombre
    '                oeAsiento.GlosaImprime = "VENTA " & .Venta.TipoDoc.Abreviatura & "/" & .Serie & .Numero & " " & .Venta.Cliente.Nombre
    '                oeAsiento.IdMoneda = .IdMoneda
    '                oeAsiento.TipoCambio = .TipoCambio
    '                oeAsiento.TotalDebe = .Total
    '                oeAsiento.TotalHaber = .Total
    '                oeAsiento.IdUsuarioBloquea = ""
    '                oeAsiento.IdEstado = "CUADRADO" 'Estado Cuadrado
    '                oeAsiento.IdAsientoExtorno = ""

    '                '------------------Cuentas Generales---------------
    '                Dim oeCuentaGenerales As New e_TablaContableDet
    '                Dim leCuentasGenerales As New List(Of e_TablaContableDet)
    '                Dim olFuncionesGenerales As New l_FuncionesGenerales
    '                oeCuentaGenerales.Valor1 = oeMovimientoDocumento.FechaEmision.Year
    '                leCuentasGenerales.AddRange(olFuncionesGenerales.CuentasGenerales(oeCuentaGenerales))
    '                '-------------------------------------------------------
    '                If leCuentasGenerales.Count = 0 Then Throw New Exception("No se Encontro Cuentas Contables en el Periodo: " & oeMovimientoDocumento.FechaEmision.Year)
    '                '------------------ linea(12)----------------------------
    '                Dim leListaFiltrada As New List(Of e_TablaContableDet)
    '                leListaFiltrada = leCuentasGenerales.ToList
    '                Dim oeMovimientoAsiento12 As New e_AsientoMovimiento
    '                oeMovimientoAsiento12 = Linea12(oeMovimientoDocumento, oeAsiento, leListaFiltrada)
    '                '-----------------------------------------------'
    '                '--------------Lineas Impuestos--------------------
    '                leListaFiltrada = leCuentasGenerales.ToList
    '                Dim ListaImpuesto As New List(Of e_AsientoMovimiento)
    '                ListaImpuesto = LineaImpuestosVentas(oeMovimientoDocumento, oeAsiento, leListaFiltrada)
    '                '-----------------------------------------------
    '                '------------------ linea(70)----------------------------
    '                Dim oeMovimientoAsiento70 As New List(Of e_AsientoMovimiento)
    '                If leDocumentos Is Nothing Then
    '                    oeMovimientoAsiento70.Add(Linea70(oeMovimientoDocumento, oeAsiento))
    '                Else
    '                    If leDocumentos.Count > 0 Then
    '                        For Each ob As e_MovimientoDocumento In leDocumentos
    '                            oeMovimientoAsiento70.Add(Linea70(ob, oeAsiento))
    '                        Next
    '                    Else
    '                        oeMovimientoAsiento70.Add(Linea70(oeMovimientoDocumento, oeAsiento))
    '                    End If
    '                End If
    '                '-----------------------------------------------'
    '                If .Venta.TipoDoc.Codigo = "07" Then
    '                    oeAsiento.AsientoMovimiento.AddRange(oeMovimientoAsiento70)
    '                    If ListaImpuesto.Count > 0 Then
    '                        oeAsiento.AsientoMovimiento.AddRange(ListaImpuesto)
    '                    End If
    '                    oeAsiento.AsientoMovimiento.Add(oeMovimientoAsiento12)
    '                Else
    '                    oeAsiento.AsientoMovimiento.Add(oeMovimientoAsiento12)
    '                    If ListaImpuesto.Count > 0 Then
    '                        oeAsiento.AsientoMovimiento.AddRange(ListaImpuesto)
    '                    End If
    '                    oeAsiento.AsientoMovimiento.AddRange(oeMovimientoAsiento70)
    '                End If
    '                If .TipoOperacion = "A" And leDocumentos Is Nothing Then
    '                    Dim oeAs As New e_Asiento
    '                    Dim odAs As New d_Asiento
    '                    oeAs.Id = oeAsiento.Id
    '                    oeAs = odAs.Obtener(oeAs)
    '                    oeAsiento.Fecha = oeAs.Fecha
    '                    For Each obj As e_AsientoMovimiento In oeAs.AsientoMovimiento
    '                        obj.TipoOperacion = "E"
    '                        oeAsiento.AsientoMovimiento.Add(obj)
    '                    Next
    '                    oeAs = Nothing
    '                    odAs = Nothing
    '                End If
    '                Return odMovimientoDocumento.GuardarVenta(oeMovimientoDocumento, oeAsiento)
    '            End With
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Public Function GuardarCompraMaterial(oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.GuardarCompraMaterial
        Try
            Dim oeAsientoModelo As New e_AsientoModelo
            Dim oeAsiento As New e_Asiento
            Dim oeAsientoAnalisis As New e_MovimientoAnalisis
            Dim loAsiento As New List(Of e_Asiento)
            Dim olAsiento As New l_Asiento
            Dim oeAsientoMovimiento As New e_AsientoMovimiento
            Dim loAsientoMovimiento As New List(Of e_AsientoMovimiento)
            Dim olRegistroInventarioDoc As New l_RegistroInventarioDocumento
            Using TransScope As New TransactionScope()
                If ValidarCompraVenta(oeMovimientoDocumento, True, gAreasSGI.Compras) Then
                    If ValidarTipoCambio(oeMovimientoDocumento) Then
                        Dim fecAsiento As Date = olFuncionesGenerales.gfc_ObtenerFechaAsiento(oeMovimientoDocumento.FechaEmision, oeMovimientoDocumento.FechaFinal)
                        With oeMovimientoDocumento
                            .interfazContable = True
                            .TipoOperacion = "A"
                            .EstadoDocumento = "ENVIADO"
                            ''Consulta de Compra.
                            Dim oeCompra As New e_Compra
                            Dim loCompra As New l_Compra
                            oeCompra.IdMovimientoDocumento = oeMovimientoDocumento.Id
                            oeCompra = loCompra.Obtener(oeCompra)
                            oeCompra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
                            oeCompra.TotalIGVCompra = .IGV
                            oeCompra.TotalBaseCompra = .SubTotal
                            oeMovimientoDocumento.Compra = oeCompra
                            oeMovimientoDocumento.Compra.TipoOperacion = "A"
                            ''Consulta de Proveedor
                            Dim oeProveedor As New e_Proveedor
                            Dim olProveedor As New l_Proveedor
                            oeProveedor.Id = oeMovimientoDocumento.IdClienteProveedor
                            oeProveedor = olProveedor.Obtener(oeProveedor)
                            .Compra.Proveedor = oeProveedor
                        End With
                        If oeMovimientoDocumento.IndTipoFactura <> "1" Then
                            For Each asimod As e_AsientoModelo In oeMovimientoDocumento.loAsientoModelo
                                oeAsiento = New e_Asiento
                                loAsientoMovimiento = New List(Of e_AsientoMovimiento)
                                With oeAsiento
                                    .TipoOperacion = "I" : .IdPeriodo = oeMovimientoDocumento.IdPeriodo : .IdTipoAsiento = asimod.IdTipoAsiento
                                    .PrefijoID = oeMovimientoDocumento.PrefijoID
                                    .NroAsiento = String.Empty : .Fecha = fecAsiento : .Glosa = asimod.Nombre & " " _
                                        & oeMovimientoDocumento.Compra.TipoDoc.Abreviatura & "/" & oeMovimientoDocumento.Serie & oeMovimientoDocumento.Numero & " " & _
                                        oeMovimientoDocumento.Compra.Proveedor.Nombre
                                    .GlosaImprime = String.Empty : .IdMoneda = asimod.IdMoneda : .TipoCambio = oeMovimientoDocumento.TipoCambio
                                    .TotalDebe = Math.Round(oeMovimientoDocumento.Total, 2)
                                    .TotalHaber = Math.Round(oeMovimientoDocumento.Total, 2)
                                    .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea : oeAsiento.Activo = True
                                    .IndOrigen = oeMovimientoDocumento.IndOrigenContable
                                    .Asiento_MovDoc = New e_Asiento_MovDoc
                                    .Asiento_MovDoc.TipoOperacion = "I"
                                    .Asiento_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                                    .Asiento_MovDoc.Activo = True
                                    .AsientoReferencia = New e_AsientoReferencia
                                    .AsientoReferencia.TipoOperacion = "I"
                                    .AsientoReferencia.IdReferencia = oeMovimientoDocumento.Id
                                    .AsientoReferencia.TipoReferencia = 3
                                End With
                                For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle
                                    oeAsientoMovimiento = New e_AsientoMovimiento
                                    If asidet.Repetir = 0 Then
                                        With oeAsientoMovimiento
                                            .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                            .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                            .IdCuentaContable = asidet.IdCuentaContable
                                            If asidet.IndDocumento Then
                                                .AsMov_MovDoc = New e_AsientoMov_MovDoc
                                                .AsMov_MovDoc.TipoOperacion = "I"
                                                .AsMov_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                                                .AsMov_MovDoc.UsuarioCreacion = oeMovimientoDocumento.IdUsuarioCrea
                                                .AsMov_MovDoc.Fecha = Date.Now
                                                .AsMov_MovDoc.IdCuentaxCyP = String.Empty
                                                .AsMov_MovDoc.Activo = True
                                            End If
                                            If oeMovimientoDocumento.IdTipoDocumento <> "1CH000000030" Then
                                                If asidet.Partida = 1 Then
                                                    If Left(asidet.Cuenta, 2) = CStr(40) Then
                                                        If oeMovimientoDocumento.IGV > 0 Then
                                                            If asimod.IdMoneda = "1CH01" Then
                                                                .DebeMN = Math.Round(oeMovimientoDocumento.IGV, 2)
                                                                .DebeME = Math.Round(oeMovimientoDocumento.IGV / oeMovimientoDocumento.TipoCambio, 2)
                                                            Else
                                                                .DebeME = Math.Round(oeMovimientoDocumento.IGV, 2)
                                                                .DebeMN = Math.Round(oeMovimientoDocumento.IGV * oeMovimientoDocumento.TipoCambio, 2)
                                                            End If
                                                            If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                                        End If
                                                    Else
                                                        If asimod.IdMoneda = "1CH01" Then
                                                            .DebeMN = Math.Round(oeMovimientoDocumento.SubTotal, 2)
                                                            .DebeME = Math.Round(oeMovimientoDocumento.SubTotal / oeMovimientoDocumento.TipoCambio, 2)
                                                        Else
                                                            .DebeME = Math.Round(oeMovimientoDocumento.SubTotal, 2)
                                                            .DebeMN = Math.Round(oeMovimientoDocumento.SubTotal * oeMovimientoDocumento.TipoCambio, 2)
                                                        End If
                                                        If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                                    End If
                                                Else
                                                    If asimod.IdMoneda = "1CH01" Then
                                                        .HaberMN = Math.Round(oeMovimientoDocumento.Total, 2)
                                                        .HaberME = Math.Round(oeMovimientoDocumento.Total / oeMovimientoDocumento.TipoCambio, 2)
                                                    Else
                                                        .HaberME = Math.Round(oeMovimientoDocumento.Total, 2)
                                                        .HaberMN = Math.Round(oeMovimientoDocumento.Total * oeMovimientoDocumento.TipoCambio, 2)
                                                    End If
                                                    If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                                End If
                                            Else
                                                If asidet.Partida = 1 Then
                                                    If asimod.IdMoneda = "1CH01" Then
                                                        .DebeMN = Math.Round(oeMovimientoDocumento.Total, 2)
                                                        .DebeME = Math.Round(oeMovimientoDocumento.Total / oeMovimientoDocumento.TipoCambio, 2)
                                                    Else
                                                        .DebeME = Math.Round(oeMovimientoDocumento.Total, 2)
                                                        .DebeMN = Math.Round(oeMovimientoDocumento.Total * oeMovimientoDocumento.TipoCambio, 2)
                                                    End If
                                                    If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                                Else
                                                    If Left(asidet.Cuenta, 2) = CStr(40) Then
                                                        If oeMovimientoDocumento.IGV > 0 Then
                                                            If asimod.IdMoneda = "1CH01" Then
                                                                .HaberMN = Math.Round(oeMovimientoDocumento.IGV, 2)
                                                                .HaberME = Math.Round(oeMovimientoDocumento.IGV / oeMovimientoDocumento.TipoCambio, 2)
                                                            Else
                                                                .HaberME = Math.Round(oeMovimientoDocumento.IGV, 2)
                                                                .HaberMN = Math.Round(oeMovimientoDocumento.IGV * oeMovimientoDocumento.TipoCambio, 2)
                                                            End If
                                                            If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                                        End If
                                                    Else
                                                        If asimod.IdMoneda = "1CH01" Then
                                                            .HaberMN = Math.Round(oeMovimientoDocumento.SubTotal, 2)
                                                            .HaberME = Math.Round(oeMovimientoDocumento.SubTotal / oeMovimientoDocumento.TipoCambio, 2)
                                                        Else
                                                            .HaberME = Math.Round(oeMovimientoDocumento.SubTotal, 2)
                                                            .HaberMN = Math.Round(oeMovimientoDocumento.SubTotal * oeMovimientoDocumento.TipoCambio, 2)
                                                        End If
                                                        If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                                    End If
                                                End If
                                            End If
                                        End With
                                    End If
                                Next
                                Dim flaganalisis As Boolean = False
                                For Each ctactblesfm As e_CtaCtbleSubFamiliaMat In oeMovimientoDocumento.loCtaCtbleSFam
                                    For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle.OrderBy(Function(item) item.Fila).ToList
                                        If asidet.Repetir = 1 Then
                                            oeAsientoMovimiento = New e_AsientoMovimiento
                                            flaganalisis = False
                                            With oeAsientoMovimiento
                                                .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                                .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                                If Left(ctactblesfm.NroCtaCtbleExistencias, 2) = asidet.Cuenta.Trim Then
                                                    .IdCuentaContable = ctactblesfm.IdCtaCtbleExistencias
                                                ElseIf Left(ctactblesfm.NroCtaCtbleCompra, 2) = asidet.Cuenta.Trim Then
                                                    .IdCuentaContable = ctactblesfm.IdCtaCtbleCompras
                                                ElseIf Left(ctactblesfm.NroCtaCtbleConsumo, 2) = asidet.Cuenta.Trim Then
                                                    flaganalisis = True
                                                    .IdCuentaContable = ctactblesfm.IdCtaCtbleConsumo
                                                End If
                                                If .IdCuentaContable <> "" Then
                                                    If asidet.Partida = 1 Then
                                                        If asimod.IdMoneda = "1CH01" Then
                                                            .DebeMN = Math.Round(ctactblesfm.TotalCuentas, 2)
                                                            .DebeME = Math.Round(ctactblesfm.TotalCuentas / oeMovimientoDocumento.TipoCambio, 2)
                                                        Else
                                                            .DebeME = Math.Round(ctactblesfm.TotalCuentas, 2)
                                                            .DebeMN = Math.Round(ctactblesfm.TotalCuentas * oeMovimientoDocumento.TipoCambio, 2)
                                                        End If
                                                        If flaganalisis = True And oeMovimientoDocumento.IdTipoDocumento <> "1CH000000030" Then
                                                            oeAsientoAnalisis = New e_MovimientoAnalisis
                                                            oeAsientoAnalisis.TipoOperacion = ""
                                                            oeAsientoAnalisis.IdMoneda = asimod.IdMoneda
                                                            oeAsientoAnalisis.IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea
                                                            oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                                                            If asimod.IdMoneda = "1CH01" Then
                                                                oeAsientoAnalisis.Monto = .DebeMN
                                                                oeAsientoAnalisis.Saldo = .DebeMN
                                                            Else
                                                                oeAsientoAnalisis.Monto = .DebeME
                                                                oeAsientoAnalisis.Saldo = .DebeME
                                                            End If
                                                            oeAsientoAnalisis.IdVehiculo = "1SI000000059"
                                                            .MovimientoAnalisis.Add(oeAsientoAnalisis)
                                                        End If
                                                        If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                                    Else
                                                        If asimod.IdMoneda = "1CH01" Then
                                                            .HaberMN = Math.Round(ctactblesfm.TotalCuentas, 2)
                                                            .HaberME = Math.Round(ctactblesfm.TotalCuentas / oeMovimientoDocumento.TipoCambio, 2)
                                                        Else
                                                            .HaberME = Math.Round(ctactblesfm.TotalCuentas, 2)
                                                            .HaberMN = Math.Round(ctactblesfm.TotalCuentas * oeMovimientoDocumento.TipoCambio, 2)
                                                        End If
                                                        If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                                    End If
                                                End If
                                            End With
                                        End If
                                    Next
                                Next
                                oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                                loAsiento.Add(oeAsiento)
                            Next
                        Else
                            For Each asimod As e_AsientoModelo In oeMovimientoDocumento.loAsientoModelo
                                oeAsiento = New e_Asiento
                                loAsientoMovimiento = New List(Of e_AsientoMovimiento)
                                With oeAsiento
                                    .TipoOperacion = "I" : .IdPeriodo = oeMovimientoDocumento.IdPeriodo : .IdTipoAsiento = asimod.IdTipoAsiento
                                    .NroAsiento = String.Empty : .Fecha = oeMovimientoDocumento.FechaCreacion : .Glosa = asimod.Nombre & " " _
                                        & oeMovimientoDocumento.Compra.TipoDoc.Abreviatura & "/" & oeMovimientoDocumento.Serie & oeMovimientoDocumento.Numero & " " & _
                                        oeMovimientoDocumento.Compra.Proveedor.Nombre
                                    .GlosaImprime = String.Empty : .IdMoneda = asimod.IdMoneda : .TipoCambio = oeMovimientoDocumento.TipoCambio
                                    .TotalDebe = Math.Round(oeMovimientoDocumento.Total, 2)
                                    .TotalHaber = Math.Round(oeMovimientoDocumento.Total, 2)
                                    .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea : oeAsiento.Activo = True
                                    .IndOrigen = oeMovimientoDocumento.IndOrigenContable
                                    .Asiento_MovDoc = New e_Asiento_MovDoc
                                    .Asiento_MovDoc.TipoOperacion = "I"
                                    .Asiento_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                                    .Asiento_MovDoc.Activo = True
                                End With
                                For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle
                                    oeAsientoMovimiento = New e_AsientoMovimiento
                                    With oeAsientoMovimiento
                                        .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                        .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                        .IdCuentaContable = asidet.IdCuentaContable
                                        If asidet.IndDocumento Then
                                            .AsMov_MovDoc = New e_AsientoMov_MovDoc
                                            .AsMov_MovDoc.TipoOperacion = "I"
                                            .AsMov_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                                            .AsMov_MovDoc.IdCuentaxCyP = String.Empty
                                            .AsMov_MovDoc.Activo = True
                                        End If
                                        If asidet.Partida = 1 Then
                                            If asidet.Repetir Then
                                                If asimod.IdMoneda = "1CH01" Then
                                                    .DebeMN = Math.Round((oeMovimientoDocumento.Total - oeMovimientoDocumento.IGV), 2)
                                                    .DebeME = Math.Round((oeMovimientoDocumento.Total - oeMovimientoDocumento.IGV) / oeMovimientoDocumento.TipoCambio, 2)
                                                Else
                                                    .DebeME = Math.Round((oeMovimientoDocumento.Total - oeMovimientoDocumento.IGV), 2)
                                                    .DebeMN = Math.Round((oeMovimientoDocumento.Total - oeMovimientoDocumento.IGV) * oeMovimientoDocumento.TipoCambio, 2)
                                                End If
                                                For Each detdoc As e_DetalleDocumento In oeMovimientoDocumento.lstDetalleDocumento
                                                    oeAsientoAnalisis = New e_MovimientoAnalisis
                                                    oeAsientoAnalisis.TipoOperacion = ""
                                                    oeAsientoAnalisis.IdMoneda = asimod.IdMoneda
                                                    oeAsientoAnalisis.IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea
                                                    If detdoc.IndGravado Then
                                                        oeAsientoAnalisis.Monto = Math.Round(detdoc.Subtotal, 2)
                                                        oeAsientoAnalisis.Saldo = Math.Round(detdoc.Subtotal, 2)
                                                    Else
                                                        oeAsientoAnalisis.Monto = Math.Round(detdoc.Subtotal, 2)
                                                        oeAsientoAnalisis.Saldo = Math.Round(detdoc.Subtotal, 2)
                                                    End If
                                                    oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                                                    oeAsientoAnalisis.IdVehiculo = detdoc.IdVehiculo
                                                    oeAsientoAnalisis.IdItemGasto = "1CH000114"
                                                    .MovimientoAnalisis.Add(oeAsientoAnalisis)
                                                Next
                                                If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                            Else
                                                If oeMovimientoDocumento.IGV > 0 Then
                                                    If asimod.IdMoneda = "1CH01" Then
                                                        .DebeMN = Math.Round(oeMovimientoDocumento.IGV, 2)
                                                        .DebeME = Math.Round(oeMovimientoDocumento.IGV / oeMovimientoDocumento.TipoCambio, 2)
                                                    Else
                                                        .DebeME = Math.Round(oeMovimientoDocumento.IGV, 2)
                                                        .DebeMN = Math.Round(oeMovimientoDocumento.IGV * oeMovimientoDocumento.TipoCambio, 2)
                                                    End If
                                                    If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                                End If
                                            End If
                                        Else
                                            If asimod.IdMoneda = "1CH01" Then
                                                .HaberMN = Math.Round(oeMovimientoDocumento.Total, 2)
                                                .HaberME = Math.Round(oeMovimientoDocumento.Total / oeMovimientoDocumento.TipoCambio, 2)
                                            Else
                                                .HaberME = Math.Round(oeMovimientoDocumento.Total, 2)
                                                .HaberMN = Math.Round(oeMovimientoDocumento.Total * oeMovimientoDocumento.TipoCambio, 2)
                                            End If
                                            If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                        End If
                                    End With
                                Next
                                oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                                loAsiento.Add(oeAsiento)
                            Next
                        End If
                        oeAsiento = Nothing
                        If odMovimientoDocumento.GuardarCompra(oeMovimientoDocumento, oeAsiento, False) Then
                            'If oeMovimientoDocumento.IdTipoDocumento = "1CH000000030" And oeMovimientoDocumento.Compra.IdMotivoDocumento = "1SI000000003" Then
                            '    olRegistroInventarioDoc.RegenerarRegistroInv(oeMovimientoDocumento)
                            'End If
                            If olAsiento.GuardarLista(loAsiento) Then
                                TransScope.Complete()
                            End If
                        End If
                    End If
                End If
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarCmpServicio(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.GuardarCompraServicio
        Try
            Dim oeAsientoModelo As New e_AsientoModelo
            Dim oeAsiento As New e_Asiento
            Dim oeAsientoAnalisis As New e_MovimientoAnalisis
            Dim loAsiento As New List(Of e_Asiento)
            Dim olAsiento As New l_Asiento
            Dim oeAsientoMovimiento As New e_AsientoMovimiento
            Dim loAsientoMovimiento As New List(Of e_AsientoMovimiento)
            Dim olRegistroInventarioDoc As New l_RegistroInventarioDocumento
            Using TransScope As New TransactionScope()
                If ValidarCompraVenta(oeMovimientoDocumento, True, gAreasSGI.Compras) Then
                    Dim fecAsiento As Date = olFuncionesGenerales.gfc_ObtenerFechaAsiento(oeMovimientoDocumento.FechaEmision, oeMovimientoDocumento.FechaFinal)
                    With oeMovimientoDocumento
                        .interfazContable = True
                        .TipoOperacion = "A"
                        .EstadoDocumento = "ENVIADO"
                        ''Consulta de Compra.
                        Dim oeCompra As New e_Compra
                        Dim loCompra As New l_Compra
                        oeCompra.IdMovimientoDocumento = oeMovimientoDocumento.Id
                        oeCompra = loCompra.Obtener(oeCompra)
                        oeCompra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
                        If oeMovimientoDocumento.IGV > 0 Then
                            oeCompra.TotalIGVCompra = .IGV
                            oeCompra.TotalBaseCompra = .SubTotal
                        Else
                            oeCompra.TotalIGVCompra = 0
                            oeCompra.TotalBaseCompra = 0
                            oeCompra.NoGravadas = .Total
                        End If
                        oeMovimientoDocumento.Compra = oeCompra
                        oeMovimientoDocumento.Compra.TipoOperacion = "A"
                        ''Consulta de Proveedor
                        Dim oeProveedor As New e_Proveedor
                        Dim olProveedor As New l_Proveedor
                        oeProveedor.Id = oeMovimientoDocumento.IdClienteProveedor
                        oeProveedor = olProveedor.Obtener(oeProveedor)
                        .Compra.Proveedor = oeProveedor
                    End With
                    For Each asimod As e_AsientoModelo In oeMovimientoDocumento.loAsientoModelo
                        oeAsiento = New e_Asiento
                        loAsientoMovimiento = New List(Of e_AsientoMovimiento)
                        With oeAsiento
                            .TipoOperacion = "I" : .IdPeriodo = oeMovimientoDocumento.IdPeriodo : .IdTipoAsiento = asimod.IdTipoAsiento
                            .NroAsiento = String.Empty : .Fecha = fecAsiento : .Glosa = asimod.Nombre & " " _
                                & oeMovimientoDocumento.Compra.TipoDoc.Abreviatura & "/" & oeMovimientoDocumento.Serie & oeMovimientoDocumento.Numero & " " & _
                                oeMovimientoDocumento.Compra.Proveedor.Nombre
                            .GlosaImprime = String.Empty : .IdMoneda = asimod.IdMoneda : .TipoCambio = oeMovimientoDocumento.TipoCambio
                            .TotalDebe = Math.Round(oeMovimientoDocumento.Total, 2)
                            .TotalHaber = Math.Round(oeMovimientoDocumento.Total, 2)
                            .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea : oeAsiento.Activo = True
                            .IndOrigen = oeMovimientoDocumento.IndOrigenContable
                            .Asiento_MovDoc = New e_Asiento_MovDoc
                            .Asiento_MovDoc.TipoOperacion = "I"
                            .Asiento_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                            .Asiento_MovDoc.Activo = True
                            .AsientoReferencia = New e_AsientoReferencia
                            .AsientoReferencia.TipoOperacion = "I"
                            .AsientoReferencia.IdReferencia = oeMovimientoDocumento.Id
                            .AsientoReferencia.TipoReferencia = 4
                        End With
                        For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle
                            oeAsientoMovimiento = New e_AsientoMovimiento
                            If asidet.Repetir = 0 Then
                                With oeAsientoMovimiento
                                    .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                    .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                    .IdCuentaContable = asidet.IdCuentaContable
                                    If asidet.IndDocumento Then
                                        .AsMov_MovDoc = New e_AsientoMov_MovDoc
                                        .AsMov_MovDoc.TipoOperacion = "I"
                                        .AsMov_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                                        .AsMov_MovDoc.IdCuentaxCyP = String.Empty
                                        .AsMov_MovDoc.Activo = True
                                    End If
                                    If asidet.Partida = 1 Then
                                        If Left(asidet.Cuenta, 2) = CStr(40) Then
                                            If oeMovimientoDocumento.IGV > 0 Then
                                                If asimod.IdMoneda = "1CH01" Then
                                                    .DebeMN = Math.Round(oeMovimientoDocumento.IGV, 2)
                                                    .DebeME = Math.Round(oeMovimientoDocumento.IGV / oeMovimientoDocumento.TipoCambio, 2)
                                                Else
                                                    .DebeME = Math.Round(oeMovimientoDocumento.IGV, 2)
                                                    .DebeMN = Math.Round(oeMovimientoDocumento.IGV * oeMovimientoDocumento.TipoCambio, 2)
                                                End If
                                                If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                            End If
                                        Else
                                            If Left(asidet.Cuenta, 1) = CStr(4) Then
                                                If asimod.IdMoneda = "1CH01" Then
                                                    .DebeMN = Math.Round(oeMovimientoDocumento.Total, 2)
                                                    .DebeME = Math.Round(oeMovimientoDocumento.Total / oeMovimientoDocumento.TipoCambio, 2)
                                                Else
                                                    .DebeME = Math.Round(oeMovimientoDocumento.Total, 2)
                                                    .DebeMN = Math.Round(oeMovimientoDocumento.Total * oeMovimientoDocumento.TipoCambio, 2)
                                                End If
                                            Else
                                                If asimod.IdMoneda = "1CH01" Then
                                                    .DebeMN = Math.Round(oeMovimientoDocumento.SubTotal, 2)
                                                    .DebeME = Math.Round(oeMovimientoDocumento.SubTotal / oeMovimientoDocumento.TipoCambio, 2)
                                                Else
                                                    .DebeME = Math.Round(oeMovimientoDocumento.SubTotal, 2)
                                                    .DebeMN = Math.Round(oeMovimientoDocumento.SubTotal * oeMovimientoDocumento.TipoCambio, 2)
                                                End If
                                            End If
                                            If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                        End If
                                    Else
                                        If Left(asidet.Cuenta, 2) = CStr(40) Then
                                            If oeMovimientoDocumento.IGV > 0 Then
                                                If asimod.IdMoneda = "1CH01" Then
                                                    .HaberMN = Math.Round(oeMovimientoDocumento.IGV, 2)
                                                    .HaberME = Math.Round(oeMovimientoDocumento.IGV / oeMovimientoDocumento.TipoCambio, 2)
                                                Else
                                                    .HaberME = Math.Round(oeMovimientoDocumento.IGV, 2)
                                                    .HaberMN = Math.Round(oeMovimientoDocumento.IGV * oeMovimientoDocumento.TipoCambio, 2)
                                                End If
                                                If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                            End If
                                        Else
                                            If Left(asidet.Cuenta, 1) = CStr(4) Then
                                                If asimod.IdMoneda = "1CH01" Then
                                                    .HaberMN = Math.Round(oeMovimientoDocumento.Total, 2)
                                                    .HaberME = Math.Round(oeMovimientoDocumento.Total / oeMovimientoDocumento.TipoCambio, 2)
                                                Else
                                                    .HaberME = Math.Round(oeMovimientoDocumento.Total, 2)
                                                    .HaberMN = Math.Round(oeMovimientoDocumento.Total * oeMovimientoDocumento.TipoCambio, 2)
                                                End If
                                            Else
                                                If asimod.IdMoneda = "1CH01" Then
                                                    .HaberMN = Math.Round(oeMovimientoDocumento.SubTotal, 2)
                                                    .HaberME = Math.Round(oeMovimientoDocumento.SubTotal / oeMovimientoDocumento.TipoCambio, 2)
                                                Else
                                                    .HaberME = Math.Round(oeMovimientoDocumento.SubTotal, 2)
                                                    .HaberMN = Math.Round(oeMovimientoDocumento.SubTotal * oeMovimientoDocumento.TipoCambio, 2)
                                                End If
                                            End If
                                            If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                        End If
                                    End If
                                End With
                            End If
                        Next
                        For Each ctactblecs As e_CtaCtbleCatServicio In oeMovimientoDocumento.loCtaCtbleCSer
                            For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle.OrderBy(Function(item) item.Fila).ToList
                                If asidet.Repetir = 1 Then
                                    oeAsientoMovimiento = New e_AsientoMovimiento
                                    With oeAsientoMovimiento
                                        .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                        .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                        .IdCuentaContable = ctactblecs.IdCuentaContable
                                        If .IdCuentaContable <> "" Then
                                            If asidet.Partida = 1 Then
                                                If asimod.IdMoneda = "1CH01" Then
                                                    .DebeMN = Math.Round(ctactblecs.TotalCuenta, 2)
                                                    .DebeME = Math.Round(ctactblecs.TotalCuenta / oeMovimientoDocumento.TipoCambio, 2)
                                                Else
                                                    .DebeME = Math.Round(ctactblecs.TotalCuenta, 2)
                                                    .DebeMN = Math.Round(ctactblecs.TotalCuenta * oeMovimientoDocumento.TipoCambio, 2)
                                                End If
                                                If oeMovimientoDocumento.lstDetalleDocumento.Count = 0 Then
                                                    oeAsientoAnalisis = New e_MovimientoAnalisis
                                                    oeAsientoAnalisis.TipoOperacion = ""
                                                    oeAsientoAnalisis.IdMoneda = asimod.IdMoneda
                                                    oeAsientoAnalisis.IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea
                                                    oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                                                    If asimod.IdMoneda = "1CH01" Then
                                                        oeAsientoAnalisis.Monto = Math.Round(oeMovimientoDocumento.Total, 2)
                                                        oeAsientoAnalisis.Saldo = Math.Round(oeMovimientoDocumento.Total, 2)
                                                    Else
                                                        oeAsientoAnalisis.Monto = Math.Round(oeMovimientoDocumento.Total, 2)
                                                        oeAsientoAnalisis.Saldo = Math.Round(oeMovimientoDocumento.Total, 2)
                                                    End If
                                                    oeAsientoAnalisis.IdVehiculo = ""
                                                    oeAsientoAnalisis.IdItemGasto = ctactblecs.IdItemGasto
                                                    .MovimientoAnalisis.Add(oeAsientoAnalisis)
                                                Else
                                                    For Each oe As e_DetalleDocumento In oeMovimientoDocumento.lstDetalleDocumento
                                                        If oe.IdCategoriaServicio = ctactblecs.IdCategoriaServicio Then
                                                            oeAsientoAnalisis = New e_MovimientoAnalisis
                                                            oeAsientoAnalisis.TipoOperacion = ""
                                                            oeAsientoAnalisis.IdMoneda = asimod.IdMoneda
                                                            oeAsientoAnalisis.IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea
                                                            oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                                                            If asimod.IdMoneda = "1CH01" Then
                                                                oeAsientoAnalisis.Monto = Math.Round(oe.PrecioUnitarioSinImp * oe.Cantidad, 2)
                                                                oeAsientoAnalisis.Saldo = Math.Round(oe.PrecioUnitarioSinImp * oe.Cantidad, 2)
                                                            Else
                                                                oeAsientoAnalisis.Monto = Math.Round(oe.PrecioUnitarioSinImp * oe.Cantidad, 2)
                                                                oeAsientoAnalisis.Saldo = Math.Round(oe.PrecioUnitarioSinImp * oe.Cantidad, 2)
                                                            End If
                                                            oeAsientoAnalisis.IdVehiculo = oe.IdVehiculo
                                                            oeAsientoAnalisis.IdItemGasto = ctactblecs.IdItemGasto
                                                            .MovimientoAnalisis.Add(oeAsientoAnalisis)
                                                        End If
                                                    Next
                                                End If

                                                If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                            Else
                                                If asimod.IdMoneda = "1CH01" Then
                                                    .HaberMN = Math.Round(ctactblecs.TotalCuenta, 2)
                                                    .HaberME = Math.Round(ctactblecs.TotalCuenta / oeMovimientoDocumento.TipoCambio, 2)
                                                Else
                                                    .HaberME = Math.Round(ctactblecs.TotalCuenta, 2)
                                                    .HaberMN = Math.Round(ctactblecs.TotalCuenta * oeMovimientoDocumento.TipoCambio, 2)
                                                End If
                                                If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                            End If
                                        End If
                                    End With
                                End If
                            Next
                        Next
                        oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                        loAsiento.Add(oeAsiento)
                    Next
                    oeAsiento = New e_Asiento
                    If odMovimientoDocumento.GuardarCompra(oeMovimientoDocumento, oeAsiento, False) Then
                        If olAsiento.GuardarLista(loAsiento) Then
                            TransScope.Complete()
                        End If
                    End If
                End If
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function InterfazCompra(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.InterfazCompra
    '    Try
    '        If ValidarCompraVenta(oeMovimientoDocumento, True, gAreasSGI.Compras) Then
    '            If ValidarTipoCambio(oeMovimientoDocumento) Then
    '                With oeMovimientoDocumento
    '                    .interfazContable = True
    '                    .TipoOperacion = "A"
    '                    .EstadoDocumento = "ENVIADO"
    '                    ''Consulta de Compra.
    '                    Dim oeCompra As New e_Compra
    '                    Dim loCompra As New l_Compra
    '                    oeCompra.IdMovimientoDocumento = oeMovimientoDocumento.Id
    '                    oeCompra = loCompra.Obtener(oeCompra)
    '                    oeCompra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
    '                    oeCompra.TotalIGVCompra = .IGV
    '                    oeCompra.TotalBaseCompra = .SubTotal
    '                    oeMovimientoDocumento.Compra = oeCompra
    '                    oeMovimientoDocumento.Compra.TipoOperacion = "A"
    '                    ''Consulta de Proveedor
    '                    Dim oeProveedor As New e_Proveedor
    '                    Dim olProveedor As New l_Proveedor
    '                    oeProveedor.Id = oeMovimientoDocumento.IdClienteProveedor
    '                    oeProveedor = olProveedor.Obtener(oeProveedor)
    '                    .Compra.Proveedor = oeProveedor
    '                    ''Consulto la Moneda
    '                    Dim oeMoneda As New e_Moneda
    '                    Dim olMoneda As New l_Moneda
    '                    oeMoneda.Id = oeMovimientoDocumento.IdMoneda
    '                    oeMoneda = olMoneda.Obtener(oeMoneda)
    '                    .Compra.Moneda = oeMoneda
    '                    oeAlmacen = New e_Almacen
    '                    oeAlmacen.TipoOperacion = "N"
    '                    leAlmacen = olAlmacen.Listar(oeAlmacen)
    '                    Dim oeTablaContableDet As New e_TablaContableDet
    '                    Dim olTablaContableDet As New l_TablaContableDet
    '                    Dim leTablaContableDet As New List(Of e_TablaContableDet)
    '                    Dim leTCD As New List(Of e_TablaContableDet)
    '                    oeTablaContableDet.TipoOperacion = "N"
    '                    oeTablaContableDet.Nombre = "TIPO DE COMPRA"
    '                    oeTablaContableDet.Valor1 = oeMovimientoDocumento.Ejercicio
    '                    oeTablaContableDet.Activo = True
    '                    leTablaContableDet.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
    '                    ''Consulto los detalles del Documento
    '                    Dim olDetalleDoc As New l_DetalleDocumento
    '                    Dim oeDetalleDoc As New e_DetalleDocumento
    '                    Dim leDetalleDoc As New List(Of e_DetalleDocumento)
    '                    Dim leDetalleDoc2 As New List(Of e_DetalleDocumento)
    '                    oeDetalleDoc.Activo = True
    '                    oeDetalleDoc.TipoOperacion = "COM"
    '                    If oeMovimientoDocumento.Compra.IndTipoOperacion = "C" Then
    '                        oeDetalleDoc.IndServicioMaterial = "C" 'D2
    '                        .IndServicioMaterial = "S"
    '                    Else
    '                        oeDetalleDoc.IndServicioMaterial = .IndServicioMaterial
    '                    End If
    '                    oeDetalleDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
    '                    leDetalleDoc.AddRange(olDetalleDoc.Listar(oeDetalleDoc))
    '                    leDetalleDoc = leDetalleDoc.OrderBy(Function(item) item.IdCuentaContableCompra).ToList
    '                    If leDetalleDoc.Count = 0 Then
    '                        Throw New Exception("No existen detalles en este documento")
    '                    End If
    '                    ''Iniciamos el análisis
    '                    If oeMovimientoDocumento.Compra.IndTipoOperacion <> "C" And oeMovimientoDocumento.IndServicioMaterial <> "S" Then
    '                        Dim lbGuia As Boolean = False
    '                        For Each oo As e_DetalleDocumento In leDetalleDoc
    '                            If oo.IdAlmacen.Trim = "X" Then
    '                                oeDetalleDoc.Activo = True
    '                                oeDetalleDoc.TipoOperacion = "GUI"
    '                                If oeMovimientoDocumento.Compra.IndTipoOperacion = "C" Then
    '                                    oeDetalleDoc.IndServicioMaterial = "C" 'para el caso de combustible
    '                                    .IndServicioMaterial = "S"
    '                                Else
    '                                    oeDetalleDoc.IndServicioMaterial = .IndServicioMaterial
    '                                End If
    '                                oeDetalleDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
    '                                leDetalleDoc2.AddRange(olDetalleDoc.Listar(oeDetalleDoc))
    '                                lbGuia = True
    '                                Exit For
    '                            End If
    '                            If oo.IdAlmacen = "1CH000000031" Then ''Restricción para el almacén de Activo Fijo
    '                                leDetalleDoc2 = leDetalleDoc
    '                                Exit For
    '                            End If
    '                        Next
    '                        If lbGuia Then
    '                            If leDetalleDoc2.Count > 0 Then
    '                                leDetalleDoc = leDetalleDoc2
    '                            End If
    '                        End If
    '                        Dim lbConsignacion As Boolean = False
    '                        For Each o2 As e_DetalleDocumento In leDetalleDoc
    '                            oeAlmacen = New e_Almacen
    '                            oeAlmacen.Id = o2.IdAlmacen
    '                            oeAlmacen.Equivale = 1
    '                            If Not leAlmacen.Contains(oeAlmacen) Then
    '                                leDetalleDoc2 = New List(Of e_DetalleDocumento)
    '                                oeDetalleDoc.Activo = True
    '                                oeDetalleDoc.TipoOperacion = "SIG"
    '                                If oeMovimientoDocumento.Compra.IndTipoOperacion = "C" Then
    '                                    oeDetalleDoc.IndServicioMaterial = "C" 'para el caso de combustible
    '                                    .IndServicioMaterial = "S"
    '                                Else
    '                                    oeDetalleDoc.IndServicioMaterial = .IndServicioMaterial
    '                                End If
    '                                oeDetalleDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
    '                                leDetalleDoc2.AddRange(olDetalleDoc.Listar(oeDetalleDoc))
    '                                lbConsignacion = True
    '                                Exit For
    '                            End If
    '                        Next
    '                        If lbConsignacion Then
    '                            If leDetalleDoc2.Count > 0 Then
    '                                leDetalleDoc = leDetalleDoc2
    '                            End If
    '                        End If
    '                    End If

    '                    Dim lbGastoDirecto As Boolean = False
    '                    Dim lbActivoFijo As Boolean = False
    '                    For Each o_o As e_DetalleDocumento In leDetalleDoc
    '                        If o_o.SubAlm = "GASTO DIRECTO" Then
    '                            lbGastoDirecto = True
    '                            .IndServicioMaterial = "S"
    '                        ElseIf o_o.SubAlm = "ACTIVO FIJO" Then
    '                            lbActivoFijo = True
    '                            o_o.IdCuentaContableCompra = o_o.IdCuentaContableActivo
    '                            o_o.IdTipoCompra = "1CH000057" 'TIPO DE COMPRA: ACTIVO FIJO
    '                        ElseIf o_o.IdAlmacen = "1CH000000031" Then
    '                            lbActivoFijo = True
    '                            o_o.IdCuentaContableCompra = "1CH003567"
    '                            o_o.IdTipoCompra = "1CH000057"
    '                        End If
    '                        If oeMovimientoDocumento.Compra.IndTipoOperacion <> "C" And oeMovimientoDocumento.IndServicioMaterial <> "S" Then
    '                            oeAlmacen = New e_Almacen
    '                            oeAlmacen.Id = o_o.IdAlmacen
    '                            oeAlmacen.Equivale = 1
    '                            If Not leAlmacen.Contains(oeAlmacen) Then
    '                                .IndServicioMaterial = "S"
    '                                o_o.IdItemGasto = "1CH000111" 'repuestos
    '                                '------------------Cuentas Generales---------------
    '                                Dim oeCuentaGenerales As New e_TablaContableDet
    '                                Dim leCuentasGenerales As New List(Of e_TablaContableDet)
    '                                Dim olFuncionesGenerales As New l_FuncionesGenerales
    '                                oeCuentaGenerales.Valor1 = oeMovimientoDocumento.FechaEmision.Year
    '                                oeCuentaGenerales.Texto1 = "CTACONSIGNA"
    '                                leCuentasGenerales.AddRange(olFuncionesGenerales.CuentasGenerales(oeCuentaGenerales))
    '                                o_o.IdCuentaContableCompra = leCuentasGenerales(0).Texto2
    '                                o_o.IdTipoCompra = "1CH000051"
    '                                '-------------------------------------------------------
    '                            End If
    '                            'End If
    '                            '    End If
    '                        End If
    '                    Next

    '                    Dim oeMovAnalisis As New e_MovimientoAnalisis
    '                    Dim obj As New e_DetalleDocumento

    '                    If .IndServicioMaterial = "M" Then '----MATERIAL siempre mueven almacen

    '                        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
    '                        Dim oeMovDoc As New e_MovimientoDocumento
    '                        Dim leMovDoc As New List(Of e_MovimientoDocumento)

    '                        For i As Integer = 0 To leDetalleDoc.Count - 1
    '                            'ingresamo en el analisis la cta y idvehiculo(si existiera) sin repetir
    '                            obj = New e_DetalleDocumento
    '                            oeMovAnalisis = New e_MovimientoAnalisis
    '                            obj = leDetalleDoc(i)
    '                            If obj.IdCuentaContableCompra.Trim = "" Then
    '                                If lbActivoFijo Then
    '                                    Throw New Exception("Este material no tiene Cuenta de ACTIVO: " & obj.NombreMaterialServicio)
    '                                Else
    '                                    Throw New Exception("Este material no tiene Cuenta: " & obj.NombreMaterialServicio)
    '                                End If
    '                            End If

    '                            If oeMovimientoDocumento.Compra.IndTipoOperacion = "C" Then
    '                                oeMovAnalisis.IdGastoFuncion = "1CH000087" '---costo de venta
    '                            End If
    '                            If i = 0 Then
    '                                oeMovAnalisis.IdCuentaContable = obj.IdCuentaContableCompra
    '                                oeMovAnalisis.IdVehiculo = obj.IdVehiculo.Trim
    '                                oeMovAnalisis.Monto = obj.Subtotal - obj.Igv
    '                                oeMovAnalisis.Saldo = obj.Subtotal - obj.Igv
    '                                .MovimientoAnalisis.Add(oeMovAnalisis)
    '                            ElseIf obj.IdCuentaContableCompra = leDetalleDoc(i - 1).IdCuentaContableCompra Then
    '                                If obj.IdVehiculo = leDetalleDoc(i - 1).IdVehiculo Then
    '                                    .MovimientoAnalisis(.MovimientoAnalisis.Count - 1).Monto = .MovimientoAnalisis(.MovimientoAnalisis.Count - 1).Monto + obj.Subtotal - obj.Igv
    '                                    .MovimientoAnalisis(.MovimientoAnalisis.Count - 1).Saldo = .MovimientoAnalisis(.MovimientoAnalisis.Count - 1).Monto
    '                                Else
    '                                    oeMovAnalisis.IdCuentaContable = obj.IdCuentaContableCompra
    '                                    oeMovAnalisis.IdVehiculo = obj.IdVehiculo
    '                                    oeMovAnalisis.Monto = obj.Subtotal - obj.Igv
    '                                    oeMovAnalisis.Saldo = obj.Subtotal - obj.Igv
    '                                    .MovimientoAnalisis.Add(oeMovAnalisis)
    '                                End If
    '                            Else
    '                                oeMovAnalisis.IdCuentaContable = obj.IdCuentaContableCompra
    '                                oeMovAnalisis.IdVehiculo = obj.IdVehiculo
    '                                oeMovAnalisis.Monto = obj.Subtotal - obj.Igv
    '                                oeMovAnalisis.Saldo = obj.Subtotal - obj.Igv
    '                                .MovimientoAnalisis.Add(oeMovAnalisis)
    '                            End If
    '                        Next
    '                        leDetalleDoc = leDetalleDoc.OrderBy(Function(item) item.IdTipoCompra).ToList
    '                        For i As Integer = 0 To leDetalleDoc.Count - 1
    '                            'filtramos tipo de compra para generar destino
    '                            obj = New e_DetalleDocumento
    '                            obj = leDetalleDoc(i)
    '                            oeMovDoc = New e_MovimientoDocumento
    '                            If obj.IdTipoCompra.Trim = "" Then
    '                                Throw New Exception("Este material tiene una cuenta que no tiene Tipo de Compra: " & obj.IdCuentaContableCompra)
    '                            End If
    '                            If i = 0 Then
    '                                oeMovimientoDocumento.Compra.IdTipoCompra = obj.IdTipoCompra
    '                                oeMovDoc = oeMovimientoDocumento.Clonar
    '                                oeMovDoc.Compra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
    '                                oeMovDoc.Compra.Proveedor = oeMovimientoDocumento.Compra.Proveedor
    '                                oeMovDoc.Compra.Moneda = oeMovimientoDocumento.Compra.Moneda
    '                                oeMovDoc.Compra.Base1 = obj.Subtotal - obj.Igv
    '                                leTCD = leTablaContableDet.Where(Function(item) item.Id = obj.IdTipoCompra).ToList
    '                                oeMovDoc.Compra.TipoCompra = leTCD.Item(0)
    '                                oeMovimientoDocumento.Compra.IdTipoCompra = leTCD.Item(0).Id
    '                                leMovDoc.Add(oeMovDoc)
    '                            ElseIf obj.IdTipoCompra = leDetalleDoc(i - 1).IdTipoCompra Then
    '                                leMovDoc.Item(leMovDoc.Count - 1).Compra.Base1 = leMovDoc.Item(leMovDoc.Count - 1).Compra.Base1 + obj.Subtotal - obj.Igv
    '                            Else
    '                                oeMovDoc = oeMovimientoDocumento.Clonar
    '                                oeMovDoc.Compra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
    '                                oeMovDoc.Compra.Proveedor = oeMovimientoDocumento.Compra.Proveedor
    '                                oeMovDoc.Compra.Moneda = oeMovimientoDocumento.Compra.Moneda
    '                                oeMovDoc.Compra.Base1 = obj.Subtotal - obj.Igv
    '                                leTCD = leTablaContableDet.Where(Function(item) item.Id = obj.IdTipoCompra).ToList
    '                                oeMovDoc.Compra.TipoCompra = leTCD.Item(0)
    '                                leMovDoc.Add(oeMovDoc)
    '                            End If
    '                        Next
    '                        GuardarCompra(oeMovimientoDocumento, leMovDoc)

    '                    ElseIf .IndServicioMaterial = "S" Then
    '                        '----------------------
    '                        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
    '                        '' aki empieza el detalle del asiento para los servicios!!
    '                        For i As Integer = 0 To leDetalleDoc.Count - 1
    '                            'ingresamo en el analisis la cta y idvehiculo(si existiera) sin repetir
    '                            obj = New e_DetalleDocumento
    '                            oeMovAnalisis = New e_MovimientoAnalisis
    '                            oeMovAnalisis.TipoOperacion = "I"
    '                            If oeMovimientoDocumento.Compra.IndTipoOperacion = "C" Then
    '                                oeMovAnalisis.IdGastoFuncion = "1CH000087" '---costo de venta
    '                            End If
    '                            obj = leDetalleDoc(i)
    '                            If oeDetalleDoc.IndServicioMaterial <> "C" Then
    '                                If oeDetalleDoc.IdAlmacen = "1CH000000012" Or oeDetalleDoc.IdAlmacen = "1SI000000002" Then
    '                                    If lbGastoDirecto Then
    '                                        leTCD = leTablaContableDet.Where(Function(item) item.Id = obj.IdTipoCompra).ToList
    '                                        If leTCD.Count = 0 Then
    '                                            Throw New Exception("No existe tipo de compra para el servicio: " & obj.NombreMaterialServicio)
    '                                        End If
    '                                        'If leTCD.Item(0).Texto2 <> "" Then
    '                                        obj.IdCuentaContableCompra = leTCD.Item(0).Texto2
    '                                        'obj.IdTipoCompra = "1CH000051" 'otros gastos de gestion
    '                                        'End If
    '                                        If obj.IndPropiedad = 0 Then
    '                                            obj.IdItemGasto = "1CH000042" 'MANTENIMIENTO Y REPARACION UNIDADES DE TRANSPORTE ARRENDAMIENTO
    '                                        Else
    '                                            obj.IdItemGasto = "1CH000043" 'MANTENIMIENTO Y REPARACION UNIDADES DE TRANSPORTE ARRENDAMIENTO
    '                                        End If
    '                                        If obj.IdVehiculo <> "" Then
    '                                            oeMovAnalisis.IdGastoFuncion = "1CH000087" '---costo de venta
    '                                        Else
    '                                            oeMovAnalisis.IdGastoFuncion = "1CH000088" '---gasto de adminstracion
    '                                        End If
    '                                    Else
    '                                        If obj.IdVehiculo <> "" Then
    '                                            oeMovAnalisis.IdGastoFuncion = "1CH000087" '---costo de venta
    '                                            If obj.IndPropiedad = 0 Then
    '                                                obj.IdCuentaContableCompra = "1CH001879" 'MANT. Y REP. UNIDADES DE TRANSPORTE ADQUIRIDOS EN ARRENDAMIENTO FINANCIERO
    '                                                obj.IdItemGasto = "1CH000042" 'MANTENIMIENTO Y REPARACION UNIDADES DE TRANSPORTE ARRENDAMIENTO
    '                                            Else
    '                                                obj.IdCuentaContableCompra = "1CH001882" 'MANTENIM. Y REPAR. UNIDADES DE TRANSPORTE
    '                                                obj.IdItemGasto = "1CH000043" 'MANTENIMIENTO Y REPARACION UNIDADES DE TRANSPORTE ARRENDAMIENTO
    '                                            End If
    '                                        Else
    '                                            oeMovAnalisis.IdGastoFuncion = "1CH000088" '---gasto de adminstracion
    '                                        End If
    '                                    End If
    '                                Else
    '                                    oeMovAnalisis.IdGastoFuncion = "1CH000087" '---costo de venta
    '                                End If
    '                            End If
    '                            If obj.IdCuentaContableCompra.Trim = "" Then
    '                                Throw New Exception("Este Servicio no tiene Cuenta: " & obj.NombreMaterialServicio)
    '                            End If
    '                            If i = 0 Then
    '                                oeMovAnalisis.IdCuentaContable = obj.IdCuentaContableCompra
    '                                oeMovAnalisis.IdItemGasto = obj.IdItemGasto
    '                                oeMovAnalisis.IdVehiculo = obj.IdVehiculo.Trim
    '                                oeMovAnalisis.Monto = obj.Subtotal - obj.Igv
    '                                oeMovAnalisis.Saldo = obj.Subtotal - obj.Igv
    '                                .MovimientoAnalisis.Add(oeMovAnalisis)
    '                                leTCD = leTablaContableDet.Where(Function(item) item.Id = obj.IdTipoCompra).ToList
    '                                .Compra.TipoCompra = leTCD.Item(0) '' OJOOOO
    '                                .Compra.IdTipoCompra = .Compra.TipoCompra.Id '' OJOOOO
    '                            ElseIf obj.IdItemGasto = leDetalleDoc(i - 1).IdItemGasto Then
    '                                If obj.IdVehiculo = leDetalleDoc(i - 1).IdVehiculo Then
    '                                    .MovimientoAnalisis(.MovimientoAnalisis.Count - 1).Monto = .MovimientoAnalisis(.MovimientoAnalisis.Count - 1).Monto + obj.Subtotal - obj.Igv
    '                                    .MovimientoAnalisis(.MovimientoAnalisis.Count - 1).Saldo = .MovimientoAnalisis(.MovimientoAnalisis.Count - 1).Monto
    '                                Else
    '                                    oeMovAnalisis.IdCuentaContable = obj.IdCuentaContableCompra
    '                                    oeMovAnalisis.IdItemGasto = obj.IdItemGasto
    '                                    oeMovAnalisis.IdVehiculo = obj.IdVehiculo
    '                                    oeMovAnalisis.Monto = obj.Subtotal - obj.Igv
    '                                    oeMovAnalisis.Saldo = obj.Subtotal - obj.Igv
    '                                    .MovimientoAnalisis.Add(oeMovAnalisis)
    '                                End If
    '                            Else
    '                                oeMovAnalisis.IdCuentaContable = obj.IdCuentaContableCompra
    '                                oeMovAnalisis.IdItemGasto = obj.IdItemGasto
    '                                oeMovAnalisis.IdVehiculo = obj.IdVehiculo
    '                                oeMovAnalisis.Monto = obj.Subtotal - obj.Igv
    '                                oeMovAnalisis.Saldo = obj.Subtotal - obj.Igv
    '                                .MovimientoAnalisis.Add(oeMovAnalisis)
    '                            End If
    '                        Next
    '                        Dim le As New List(Of e_MovimientoDocumento)
    '                        GuardarCompra(oeMovimientoDocumento, le)
    '                    End If
    '                End With
    '            End If
    '        End If
    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Function

    'Public Function InterfazVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.InterfazVenta
    '    Try
    '        If ValidarCompraVenta(oeMovimientoDocumento, False, gAreasSGI.Ventas) Then
    '            With oeMovimientoDocumento
    '                .interfazContable = True
    '                .TipoOperacion = "A"
    '                .EstadoDocumento = "EMITIDA"
    '                .Venta.TipoOperacion = "A"
    '                .interfazContable = True
    '                .Venta.TotalVenta = .SubTotal
    '                Dim olDetalleDoc As New l_DetalleDocumento
    '                Dim oeDetalleDoc As New e_DetalleDocumento
    '                Dim leDetalleDoc As New List(Of e_DetalleDocumento)
    '                oeDetalleDoc.Activo = True
    '                oeDetalleDoc.TipoOperacion = "VEN"
    '                If .IndServicioMaterial = "M" Then
    '                    oeDetalleDoc.IndServicioMaterial = "I"
    '                Else
    '                    oeDetalleDoc.IndServicioMaterial = .IndServicioMaterial
    '                End If
    '                oeDetalleDoc.IdMovimientoDocumento = .Id
    '                leDetalleDoc.AddRange(olDetalleDoc.Listar(oeDetalleDoc))
    '                If leDetalleDoc.Count > 0 Then
    '                    Dim oeMovAnalisis As New e_MovimientoAnalisis
    '                    Dim obj As New e_DetalleDocumento
    '                    If .IndServicioMaterial = "M" Then '----MATERIAL siempre mueven almacen
    '                        Dim oeTablaContableDet As New e_TablaContableDet
    '                        Dim oeTipoVenta As New e_TablaContableDet
    '                        Dim olTablaContableDet As New l_TablaContableDet
    '                        Dim odTCD As New d_TablaContableDet
    '                        oeTablaContableDet.TipoOperacion = "N"
    '                        oeTablaContableDet.Activo = True
    '                        oeTablaContableDet.Nombre = "CUENTAS GENERALES"
    '                        oeTablaContableDet.Valor1 = .Ejercicio
    '                        oeTablaContableDet.Texto1 = "CTAVENTAFLETE"
    '                        oeTablaContableDet = odTCD.Listar(oeTablaContableDet)(0) ' Obtiene Cta 70
    '                        Dim leTablaContableDet As New List(Of e_TablaContableDet)
    '                        oeTipoVenta.TipoOperacion = "N"
    '                        oeTipoVenta.Nombre = "TIPO DE VENTA" 'Tipo de VENTA
    '                        oeTipoVenta.Valor1 = .Ejercicio
    '                        oeTipoVenta.Texto2 = oeTablaContableDet.Texto2
    '                        oeTipoVenta.Activo = True
    '                        leTablaContableDet.AddRange(olTablaContableDet.Listar(oeTipoVenta))
    '                        .Venta.TipoVenta = leTablaContableDet.Item(0)
    '                        .Venta.IdTipoVenta = .Venta.TipoVenta.Id
    '                        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
    '                        Dim montoDivide As Integer = 0
    '                        For i As Integer = 0 To leDetalleDoc.Count - 1
    '                            'ingresamo en el analisis la cta y idvehiculo(si existiera) sin repetir
    '                            obj = New e_DetalleDocumento
    '                            oeMovAnalisis = New e_MovimientoAnalisis
    '                            obj = leDetalleDoc(i)
    '                            oeMovAnalisis.TipoOperacion = "I"
    '                            Dim leDetDoc As New List(Of e_DetalleDocumento)
    '                            leDetDoc = leDetDoc.Where(Function(item) item.Id = obj.Id).ToList
    '                            If leDetDoc.Count > 0 Then
    '                                montoDivide = leDetDoc.Count
    '                            Else
    '                                montoDivide = 1
    '                            End If
    '                            oeMovAnalisis.IdVehiculo = obj.IdVehiculo.Trim
    '                            oeMovAnalisis.Monto = obj.Subtotal / montoDivide
    '                            oeMovAnalisis.Saldo = obj.Subtotal / montoDivide
    '                            .MovimientoAnalisis.Add(oeMovAnalisis)
    '                        Next
    '                        Dim leMd As New List(Of e_MovimientoDocumento)
    '                        GuardarVenta(oeMovimientoDocumento, leMd)
    '                    ElseIf .IndServicioMaterial = "S" Then
    '                        Dim leMD As New List(Of e_MovimientoDocumento)
    '                        Dim oeMD As New e_MovimientoDocumento
    '                        leDetalleDoc = leDetalleDoc.OrderBy(Function(item) item.IdCuentaContableHaber).ToList
    '                        '------------------------------------------------------------------
    '                        Dim leTablaContableDet As New List(Of e_TablaContableDet)
    '                        Dim oeTipoVenta As New e_TablaContableDet
    '                        Dim olTablaContableDet As New l_TablaContableDet
    '                        oeTipoVenta.TipoOperacion = "N"
    '                        oeTipoVenta.Nombre = "TIPO DE VENTA" 'Tipo de VENTA
    '                        oeTipoVenta.Valor1 = oeMovimientoDocumento.Ejercicio
    '                        oeTipoVenta.Activo = True
    '                        leTablaContableDet.AddRange(olTablaContableDet.Listar(oeTipoVenta))
    '                        '-------------------------------------------------------------------
    '                        Dim lbValidarCuenta As Boolean = False
    '                        Dim leTCD As New List(Of e_TablaContableDet)
    '                        For i As Integer = 0 To leDetalleDoc.Count - 1
    '                            oeMD = New e_MovimientoDocumento
    '                            obj = New e_DetalleDocumento
    '                            obj = leDetalleDoc(i)
    '                            If obj.IdCuentaContableHaber.Trim = "" Then
    '                                Throw New Exception("Este Servicio no tiene Cuenta: " & obj.NombreMaterialServicio)
    '                            End If
    '                            If obj.IdCuentaContableDebe.Trim <> "" Then
    '                                oeMovimientoDocumento.CuentaVentaxServicio = obj.IdCuentaContableDebe.Trim
    '                                lbValidarCuenta = True
    '                            End If
    '                            If lbValidarCuenta Then
    '                                If obj.IdCuentaContableDebe.Trim <> oeMovimientoDocumento.CuentaVentaxServicio Then
    '                                    Throw New Exception("Estos Servicios no coinciden el a cuenta contable Debe: " & obj.NombreMaterialServicio)
    '                                End If
    '                            End If
    '                            oeMD.TipoCambio = oeMovimientoDocumento.TipoCambio
    '                            If i = 0 Then
    '                                leTCD = New List(Of e_TablaContableDet)
    '                                leTCD = leTablaContableDet.Where(Function(item) item.Texto2 = obj.IdCuentaContableHaber).ToList
    '                                If leTCD.Count > 0 Then
    '                                    oeMovimientoDocumento.Venta.TipoVenta = leTCD(0)
    '                                    oeMovimientoDocumento.Venta.IdTipoVenta = leTCD(0).Id
    '                                    oeMD.Venta.TipoVenta = leTCD(0)
    '                                    oeMD.Venta.TipoVenta.Id = leTCD(0).Id
    '                                Else
    '                                    Throw New Exception("No existe Tipo de Venta para este Servicio: " & obj.NombreMaterialServicio)
    '                                End If
    '                                oeMD.Venta.TotalVenta = obj.Subtotal

    '                            ElseIf obj.IdCuentaContableHaber = leDetalleDoc(i - 1).IdCuentaContableHaber Then
    '                                oeMD.Venta.TotalVenta = oeMD.Venta.TotalVenta + obj.Subtotal
    '                            Else
    '                                leTCD = New List(Of e_TablaContableDet)
    '                                leTCD = leTablaContableDet.Where(Function(item) item.Texto2 = obj.IdCuentaContableHaber).ToList
    '                                If leTCD.Count > 0 Then
    '                                    oeMD.Venta.TipoVenta = leTCD(0)
    '                                    oeMD.Venta.IdTipoVenta = leTCD(0).Id
    '                                Else
    '                                    Throw New Exception("No existe Tipo de Venta para este Servicio: " & obj.NombreMaterialServicio)
    '                                End If
    '                                oeMD.Venta.TotalVenta = obj.Subtotal
    '                            End If
    '                            oeMD.Venta.TipoDoc = oeMovimientoDocumento.Venta.TipoDoc
    '                            oeMD.Venta.Moneda = oeMovimientoDocumento.Venta.Moneda
    '                            oeMD.Venta.Cliente = oeMovimientoDocumento.Venta.Cliente
    '                            leMD.Add(oeMD)
    '                        Next
    '                        GuardarVenta(oeMovimientoDocumento, leMD)
    '                    End If
    '                Else
    '                    Throw New Exception("No se Puede Emitir el Doc: " & .Serie & " - " & .Numero & " por que no tiene detalles")
    '                End If
    '            End With
    '        End If
    '    Catch ex As Exception
    '        Throw
    '    End Try

    'End Function

    'Public Function Linea12(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento, ByVal leCuentaGeneral As System.Collections.Generic.List(Of e_TablaContableDet)) As e_AsientoMovimiento Implements Il_MovimientoDocumento.Linea12
    '    Dim oeMovimientoAsiento As New e_AsientoMovimiento
    '    With oeMovDoc
    '        '------------tablaa AsientoMov_MovDoc---------------
    '        oeMovimientoAsiento.AsMov_MovDoc = New e_AsientoMov_MovDoc
    '        oeMovimientoAsiento.AsMov_MovDoc.TipoOperacion = "I"
    '        oeMovimientoAsiento.AsMov_MovDoc.Activo = True
    '        '---------------------------------------------------
    '        oeMovimientoAsiento.IdUsuarioCrea = .IdUsuarioCrea
    '        oeMovimientoAsiento.Activo = True
    '        oeMovimientoAsiento.TipoOperacion = "I"
    '        oeMovimientoAsiento.IdAsiento = oeAs.Id
    '        If .CuentaVentaxServicio = "" Then
    '            ''cuenta 12
    '            'Dim oeEmpresaCuenta As New e_EmpresaCuenta
    '            'Dim leEC As New List(Of e_EmpresaCuenta)
    '            'Dim odEmpresaCuenta As New d_EmpresaCuenta
    '            Dim oeTCD As New e_TablaContableDet
    '            ''obtengo Cta 12 asociado a empresa
    '            ''oeEmpresaCuenta.IdProveedorCliente = .Venta.Cliente.Id
    '            ''oeEmpresaCuenta.Ejercicio = oeAs.Fecha.Year
    '            ''oeEmpresaCuenta.Activo = True
    '            ''oeEmpresaCuenta.IndCompraVenta = 2
    '            ''oeEmpresaCuenta = odEmpresaCuenta.Obtener(oeEmpresaCuenta)
    '            'If leEC.Count > 0 Then
    '            '    oeMovimientoAsiento.IdCuentaContable = leEC(0).IdCuentaContable
    '            '    oeMovDoc.IdCuentaContable = oeMovimientoAsiento.IdCuentaContable
    '            'Else
    '            If .Venta.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
    '                oeTCD = leCuentaGeneral.Where(Function(it) it.Nombre = "CTAVENTASOLES").ToList(0)
    '            Else
    '                oeTCD = leCuentaGeneral.Where(Function(it) it.Nombre = "CTAVENTADOLARES").ToList(0)
    '            End If
    '            oeMovimientoAsiento.IdCuentaContable = oeTCD.Texto2
    '            oeMovDoc.IdCuentaContable = oeMovimientoAsiento.IdCuentaContable
    '            'End If
    '        Else ' para caso de 16
    '            oeMovimientoAsiento.IdCuentaContable = .CuentaVentaxServicio
    '            oeMovDoc.IdCuentaContable = .CuentaVentaxServicio
    '        End If

    '        oeMovimientoAsiento.Glosa = oeAs.Glosa
    '        If .Venta.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
    '            If .Venta.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
    '                oeMovimientoAsiento.DebeMN = 0
    '                oeMovimientoAsiento.HaberMN = .Total
    '                oeMovimientoAsiento.DebeME = 0
    '                oeMovimientoAsiento.HaberME = .Total / .TipoCambio
    '            Else
    '                oeMovimientoAsiento.DebeMN = .Total
    '                oeMovimientoAsiento.HaberMN = 0
    '                oeMovimientoAsiento.DebeME = .Total / .TipoCambio
    '                oeMovimientoAsiento.HaberME = 0
    '            End If
    '        Else 'dolares(codigo de sunat)
    '            If .Venta.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
    '                oeMovimientoAsiento.DebeMN = 0
    '                oeMovimientoAsiento.HaberMN = .Total * .TipoCambio
    '                oeMovimientoAsiento.DebeME = 0
    '                oeMovimientoAsiento.HaberME = .Total
    '            Else
    '                oeMovimientoAsiento.DebeMN = .Total * .TipoCambio
    '                oeMovimientoAsiento.HaberMN = 0
    '                oeMovimientoAsiento.DebeME = .Total
    '                oeMovimientoAsiento.HaberME = 0
    '            End If
    '        End If
    '    End With
    '    Return oeMovimientoAsiento

    'End Function

    Public Function Linea42(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento, ByVal leCuentasGenerales As System.Collections.Generic.List(Of e_TablaContableDet)) As e_AsientoMovimiento Implements Il_MovimientoDocumento.Linea42
        Dim oeMovimientoAsiento As New e_AsientoMovimiento
        With oeMovDoc
            oeMovimientoAsiento.AsMov_MovDoc = New e_AsientoMov_MovDoc
            oeMovimientoAsiento.IdUsuarioCrea = .IdUsuarioCrea
            oeMovimientoAsiento.Activo = True
            oeMovimientoAsiento.TipoOperacion = "I"
            oeMovimientoAsiento.AsMov_MovDoc.TipoOperacion = "I"
            oeMovimientoAsiento.IdAsiento = oeAs.Id
            'cuenta 42
            Dim oeEmpresaCuenta As New e_EmpresaCuenta
            Dim leEC As New List(Of e_EmpresaCuenta)
            Dim odEmpresaCuenta As New d_EmpresaCuenta
            Dim oeTCD As New e_TablaContableDet
            Dim odTCD As New d_TablaContableDet

            'obtengo Cta 43 asociado a empresa
            oeEmpresaCuenta.IdProveedorCliente = .Compra.Proveedor.Id
            oeEmpresaCuenta.Ejercicio = oeAs.Fecha.Year
            oeEmpresaCuenta.Activo = True
            oeEmpresaCuenta.IdMoneda = .IdMoneda
            oeEmpresaCuenta.IndCompraVenta = 1
            leEC.AddRange(odEmpresaCuenta.Listar(oeEmpresaCuenta))

            If leEC.Count > 0 Then
                oeMovimientoAsiento.IdCuentaContable = leEC(0).IdCuentaContable
                oeMovDoc.IdCuentaContable = oeMovimientoAsiento.IdCuentaContable
            Else
                If .Compra.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
                    oeTCD = leCuentasGenerales.Where(Function(it) it.Nombre = "CTACOMPRASOLES").ToList(0)
                Else
                    oeTCD = leCuentasGenerales.Where(Function(it) it.Nombre = "CTACOMPRADOLARES").ToList(0)
                End If
                oeMovimientoAsiento.IdCuentaContable = oeTCD.Texto2
                oeMovDoc.IdCuentaContable = oeMovimientoAsiento.IdCuentaContable
            End If
            If Not .PagoAutomatico Is Nothing Then
                .PagoAutomatico.Cuenta42 = oeMovDoc.IdCuentaContable
            End If
            oeMovimientoAsiento.Glosa = oeAs.GlosaImprime
            If .Compra.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
                If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                    oeMovimientoAsiento.DebeMN = 0
                    oeMovimientoAsiento.HaberMN = .Total
                    oeMovimientoAsiento.DebeME = 0
                    oeMovimientoAsiento.HaberME = .Total / .TipoCambio
                Else
                    oeMovimientoAsiento.DebeMN = .Total
                    oeMovimientoAsiento.HaberMN = 0
                    oeMovimientoAsiento.DebeME = .Total / .TipoCambio
                    oeMovimientoAsiento.HaberME = 0
                End If
            Else 'dolares(codigo de sunat)
                If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                    oeMovimientoAsiento.DebeMN = 0
                    oeMovimientoAsiento.HaberMN = .Total * .TipoCambio
                    oeMovimientoAsiento.DebeME = 0
                    oeMovimientoAsiento.HaberME = .Total
                Else
                    oeMovimientoAsiento.DebeMN = .Total * .TipoCambio
                    oeMovimientoAsiento.HaberMN = 0
                    oeMovimientoAsiento.DebeME = .Total
                    oeMovimientoAsiento.HaberME = 0
                End If
            End If
        End With
        Return oeMovimientoAsiento

    End Function

    Public Function Linea60(ByVal oeMovDoc As e_MovimientoDocumento, _
    ByVal oeAs As e_Asiento, Optional ByVal Masivo As Boolean = True, _
    Optional ByVal oeObligacion As e_ObligacionFin = Nothing) As System.Collections.Generic.List(Of e_AsientoMovimiento) Implements Il_MovimientoDocumento.Linea60
        Dim oeAsientoMovimiento As New e_AsientoMovimiento
        Dim olMovimientoAnalisis As New l_MovimientoAnalisis
        Dim leMovAs As New List(Of e_AsientoMovimiento)
        With oeMovDoc
            For Each obj As e_MovimientoAnalisis In .MovimientoAnalisis

                'obj.Saldo = obj.Monto  ' saldo que viene de compras siempre con cero
                If obj.TipoOperacion <> "E" Then
                    ' si ya existe la cuenta solo agrego los analisis o sumo totales en asiento movimiento
                    oeAsientoMovimiento = ExisteCta(leMovAs, obj.IdCuentaContable)

                    If oeAsientoMovimiento Is Nothing Then ' no existen agrego nueva linea
                        oeAsientoMovimiento = New e_AsientoMovimiento
                        '---------obligacion financiera-------------------
                        '----------------relacion de obligacion con asiento_movimiento--------------
                        If Not oeObligacion Is Nothing Then
                            If oeObligacion.IdCuentaContable = obj.IdCuentaContable Then
                                oeObligacion.TipoOperacion = "S"
                                'Asignar datos a tabla CuentaxCyP
                                oeObligacion.oeObligacionPago = New e_ObligacionPago
                                oeObligacion._IdMovimientoCajaBanco = "1CH0000000000003"
                                oeObligacion.oeObligacionPago.IdMovimientoCajaBanco = "1CH0000000000003" 'momentaneo no existe mov de caja y banco, modif bd para ceptar null
                                oeObligacion.oeObligacionPago.IdObligacionFinanciera = oeObligacion.Id
                                oeObligacion.oeObligacionPago.TipoOperacion = "I" 'Tipo Insertar
                                oeObligacion.oeObligacionPago.NroCuota = oeObligacion.NroVencimiento
                                oeObligacion.oeObligacionPago.FechaFinal = oeMovDoc.FechaEmision
                                oeObligacion.oeObligacionPago.FechaInicial = oeObligacion.FechaVencimiento
                                oeObligacion.oeObligacionPago.Activo = True
                                oeObligacion.oeObligacionPago.IndCancelado = True
                                oeObligacion.oeObligacionPago.UsuarioCreacion = oeMovDoc.IdUsuarioCrea
                                oeObligacion.oeObligacionPago.MacPCLocalCreacion = oeMovDoc.Mac_PC_Local
                                Dim DecTC As Double = oeMovDoc.TipoCambio  'Asigno el tipo de cmabio a una variable

                                'Asigno el monto pagado dependiendo si es soles o dolares
                                If oeObligacion.IdMoneda = "1CH01" Then 'Si es soles la moneda
                                    oeObligacion.oeObligacionPago.MontoFinalMN = oeObligacion.Saldo
                                    oeObligacion.oeObligacionPago.MontoInicialMN = oeObligacion.oeObligacionPago.MontoFinalMN
                                    oeObligacion.oeObligacionPago.MontoFinalME = oeObligacion.Saldo / DecTC
                                    oeObligacion.oeObligacionPago.MontoInicialME = oeObligacion.oeObligacionPago.MontoFinalME
                                Else 'Moneda extranjera
                                    oeObligacion.oeObligacionPago.MontoFinalMN = oeObligacion.Saldo * DecTC
                                    oeObligacion.oeObligacionPago.MontoInicialMN = oeObligacion.oeObligacionPago.MontoFinalMN
                                    oeObligacion.oeObligacionPago.MontoFinalME = oeObligacion.Saldo
                                    oeObligacion.oeObligacionPago.MontoInicialME = oeObligacion.oeObligacionPago.MontoFinalME
                                End If
                                ''Relacion AsientoMov_MovDoc
                                oeObligacion.oeObligacionPago.OeAsientoMov_ObligFin = New e_AsientoMov_ObligacionFin
                                With oeObligacion.oeObligacionPago.OeAsientoMov_ObligFin
                                    .IdObligacionFinanciera = oeObligacion.Id
                                    .TipoOperacion = "I"
                                    .Activo = True
                                End With

                                Dim oeObligacioDoc As New e_ObligacionDocumento
                                With oeObligacioDoc
                                    .TipoOperacion = "I"
                                    .IdMovimientoDocumento = obj.Id
                                    .IdObligacionFinanciera = oeObligacion.Id
                                    If oeObligacion.IdMoneda = "1CH01" Then
                                        .MontoMN = oeObligacion.Saldo
                                        .MontoME = oeObligacion.Saldo / oeObligacion.TipoCambio
                                    Else
                                        .MontoMN = oeObligacion.Saldo * oeObligacion.TipoCambio
                                        .MontoME = oeObligacion.Saldo
                                    End If
                                    .Activo = True
                                    .IdCuentaxCyP = ""
                                End With
                                oeObligacion.leOblFinDoc = New List(Of e_ObligacionDocumento)
                                oeObligacion.leOblFinDoc.Add(oeObligacioDoc)
                                oeObligacion.Saldo = 0
                                oeAsientoMovimiento.ObligacionFin = New e_ObligacionFin
                                oeAsientoMovimiento.ObligacionFin = oeObligacion
                            End If
                        End If
                        '---------------------------------------------------------------------------
                        '--------------------------------------------------

                        oeAsientoMovimiento.IdAsiento = oeAs.Id
                        oeAsientoMovimiento.IdUsuarioCrea = .IdUsuarioCrea
                        oeAsientoMovimiento.Glosa = oeAs.GlosaImprime
                        oeAsientoMovimiento.Activo = True
                        oeAsientoMovimiento.TipoOperacion = "I"
                        oeAsientoMovimiento.IdCuentaContable = obj.IdCuentaContable
                        If .Compra.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
                            If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                                oeAsientoMovimiento.DebeMN = obj.Monto
                                oeAsientoMovimiento.HaberMN = 0
                                oeAsientoMovimiento.DebeME = obj.Monto / .TipoCambio
                                oeAsientoMovimiento.HaberME = 0
                            Else
                                oeAsientoMovimiento.DebeMN = 0
                                oeAsientoMovimiento.HaberMN = obj.Monto
                                oeAsientoMovimiento.DebeME = 0
                                oeAsientoMovimiento.HaberME = obj.Monto / .TipoCambio
                            End If
                        Else 'dolares(codigo de sunat)
                            If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                                oeAsientoMovimiento.DebeMN = obj.Monto * .TipoCambio
                                oeAsientoMovimiento.HaberMN = 0
                                oeAsientoMovimiento.DebeME = obj.Monto
                                oeAsientoMovimiento.HaberME = 0
                            Else
                                oeAsientoMovimiento.DebeMN = 0
                                oeAsientoMovimiento.HaberMN = obj.Monto * .TipoCambio
                                oeAsientoMovimiento.DebeME = 0
                                oeAsientoMovimiento.HaberME = obj.Monto
                            End If
                        End If
                        If obj.IdCentroCosto <> "" Or obj.IdBanco <> "" Or obj.IdAnalisis2 <> "" _
                        Or obj.IdItemGasto <> "" Or obj.IdRuta <> "" Or obj.IdTrabajador <> "" _
                        Or obj.IdVehiculo <> "" Or obj.IdGastoFuncion <> "" Then
                            oeAsientoMovimiento.MovimientoAnalisis.Add(obj)
                        End If
                        leMovAs.Add(oeAsientoMovimiento)
                    Else ' ya existe agrego los analisis y sumo en compras
                        If .Compra.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
                            If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                                oeAsientoMovimiento.DebeMN = oeAsientoMovimiento.DebeMN + obj.Monto
                                oeAsientoMovimiento.HaberMN = 0
                                oeAsientoMovimiento.DebeME = oeAsientoMovimiento.DebeME + obj.Monto / .TipoCambio
                                oeAsientoMovimiento.HaberME = 0
                            Else
                                oeAsientoMovimiento.DebeMN = 0
                                oeAsientoMovimiento.HaberMN = oeAsientoMovimiento.HaberMN + obj.Monto
                                oeAsientoMovimiento.DebeME = 0
                                oeAsientoMovimiento.HaberME = oeAsientoMovimiento.HaberME + obj.Monto / .TipoCambio
                            End If
                        Else 'dolares(codigo de sunat)
                            If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                                oeAsientoMovimiento.DebeMN = oeAsientoMovimiento.DebeMN + obj.Monto * .TipoCambio
                                oeAsientoMovimiento.HaberMN = 0
                                oeAsientoMovimiento.DebeME = oeAsientoMovimiento.DebeME + obj.Monto
                                oeAsientoMovimiento.HaberME = 0
                            Else
                                oeAsientoMovimiento.DebeMN = 0
                                oeAsientoMovimiento.HaberMN = oeAsientoMovimiento.HaberMN + obj.Monto * .TipoCambio
                                oeAsientoMovimiento.DebeME = 0
                                oeAsientoMovimiento.HaberME = oeAsientoMovimiento.HaberME + obj.Monto
                            End If
                        End If
                        If obj.IdCentroCosto <> "" Or obj.IdBanco <> "" Or obj.IdAnalisis2 <> "" _
                        Or obj.IdItemGasto <> "" Or obj.IdRuta <> "" Or obj.IdTrabajador <> "" Or obj.IdVehiculo <> "" Then
                            oeAsientoMovimiento.MovimientoAnalisis.Add(obj)
                        End If
                    End If
                End If
            Next
        End With
        'If leMovAs.Count < 3 Then
        '    Masivo = False
        'End If
        If Masivo Then
            Dim bandera As Boolean = True
            Dim Id As String = ""
            Dim lsPrefijo As String = ""
            Dim lsNumero As Integer = 0
            Dim lsNumeroSuma As Integer = 0
            Dim odMovimientoAnalisis As New d_MovimientoAnalisis
            'revisa si hay mas de 3 detalles en compras para inserta en masivo
            For Each o_o As e_AsientoMovimiento In leMovAs
                If Not o_o.MovimientoAnalisis Is Nothing Then
                    If o_o.MovimientoAnalisis.Count > 3 Then
                        If bandera Then
                            Id = odMovimientoAnalisis.UltimoIdInserta(oeMovDoc.PrefijoID)
                            lsPrefijo = Left(Id, 3)
                            lsNumero = CInt(Right(Id, Len(Id) - 3))
                            lsNumero = lsNumeroSuma + lsNumero
                            bandera = False 'me indica si ya hizo un masivo
                        Else
                            lsNumero = lsNumeroSuma + lsNumero
                        End If
                        o_o.BandGuardMasivo = True
                        Dim dt_MA1 As Data.DataTable = olMovimientoAnalisis.CrearDT
                        For Each ob As e_MovimientoAnalisis In o_o.MovimientoAnalisis
                            Dim rowDetalle As Data.DataRow
                            rowDetalle = dt_MA1.NewRow
                            rowDetalle("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 13)
                            rowDetalle("IdCentroCosto") = ob.IdCentroCosto
                            rowDetalle("IdItemGasto") = ob.IdItemGasto
                            rowDetalle("IdTrabajador") = ob.IdTrabajador
                            rowDetalle("IdVehiculo") = ob.IdVehiculo
                            rowDetalle("IdRuta") = ob.IdRuta
                            rowDetalle("IdBanco") = ob.IdBanco
                            rowDetalle("IdAnalisis1") = ob.IdAnalisis1
                            rowDetalle("IdAnalisis2") = ob.IdAnalisis2
                            rowDetalle("Activo") = 1
                            rowDetalle("IdAsientoMovimiento") = ""
                            rowDetalle("Monto") = ob.Monto
                            rowDetalle("Saldo") = ob.Saldo
                            rowDetalle("IdMovimientoAnalisis") = ""
                            rowDetalle("IdGastoFuncion") = ob.IdGastoFuncion
                            rowDetalle("IdOrigenProrrateo") = ""
                            dt_MA1.Rows.Add(rowDetalle)
                            lsNumero = lsNumero + 1
                        Next
                        o_o.DataTableAnalisis = dt_MA1
                        lsNumeroSuma = 0
                    Else
                        lsNumeroSuma = lsNumeroSuma + o_o.MovimientoAnalisis.Count
                    End If
                End If
            Next
        End If
        Return leMovAs

    End Function

    'Public Function Linea70(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento) As e_AsientoMovimiento Implements Il_MovimientoDocumento.Linea70
    '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
    '    With oeMovDoc
    '        oeAsientoMovimiento = New e_AsientoMovimiento
    '        oeAsientoMovimiento.IdAsiento = oeAs.Id
    '        oeAsientoMovimiento.IdUsuarioCrea = IIf(oeMovDoc.IdUsuarioCrea Is Nothing, oeAs.IdUsuarioCrea, oeMovDoc.IdUsuarioCrea)
    '        oeAsientoMovimiento.Glosa = oeAs.Glosa
    '        oeAsientoMovimiento.Activo = True
    '        oeAsientoMovimiento.TipoOperacion = "I"
    '        oeAsientoMovimiento.IdCuentaContable = .Venta.TipoVenta.Texto2
    '        If .Venta.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
    '            If .Venta.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
    '                oeAsientoMovimiento.DebeMN = .Venta.TotalVenta
    '                oeAsientoMovimiento.HaberMN = 0
    '                oeAsientoMovimiento.DebeME = .Venta.TotalVenta / .TipoCambio
    '                oeAsientoMovimiento.HaberME = 0
    '            Else
    '                oeAsientoMovimiento.DebeMN = 0
    '                oeAsientoMovimiento.HaberMN = .Venta.TotalVenta
    '                oeAsientoMovimiento.DebeME = 0
    '                oeAsientoMovimiento.HaberME = .Venta.TotalVenta / .TipoCambio
    '            End If
    '        Else 'dolares(codigo de sunat)
    '            If .Venta.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
    '                oeAsientoMovimiento.DebeMN = .Venta.TotalVenta * .TipoCambio
    '                oeAsientoMovimiento.HaberMN = 0
    '                oeAsientoMovimiento.DebeME = .Venta.TotalVenta
    '                oeAsientoMovimiento.HaberME = 0
    '            Else
    '                oeAsientoMovimiento.DebeMN = 0
    '                oeAsientoMovimiento.HaberMN = .Venta.TotalVenta * .TipoCambio
    '                oeAsientoMovimiento.DebeME = 0
    '                oeAsientoMovimiento.HaberME = .Venta.TotalVenta
    '            End If
    '        End If
    '        If Not .MovimientoAnalisis Is Nothing Then
    '            If .MovimientoAnalisis.Count > 3 Then
    '                Dim bandera As Boolean = True
    '                Dim Id As String = ""
    '                Dim lsPrefijo As String = ""
    '                Dim lsNumero As Integer = 0
    '                Dim odMovimientoAnalisis As New d_MovimientoAnalisis
    '                Dim olMovimientoAnalisis As New l_MovimientoAnalisis

    '                If bandera Then
    '                    Id = odMovimientoAnalisis.UltimoIdInserta()
    '                    lsPrefijo = Left(Id, 3)
    '                    lsNumero = CInt(Right(Id, Len(Id) - 3))
    '                    bandera = False 'me indica si ya hizo un masivo
    '                End If
    '                oeAsientoMovimiento.BandGuardMasivo = True
    '                oeAsientoMovimiento.DivideAnalisis = False ''agrega para que no se dividan los analisis
    '                Dim dt_MA1 As Data.DataTable = olMovimientoAnalisis.CrearDT
    '                For Each ob As e_MovimientoAnalisis In .MovimientoAnalisis
    '                    Dim rowDetalle As Data.DataRow
    '                    rowDetalle = dt_MA1.NewRow
    '                    rowDetalle("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 13)
    '                    rowDetalle("IdCentroCosto") = ob.IdCentroCosto
    '                    rowDetalle("IdItemGasto") = ob.IdItemGasto
    '                    rowDetalle("IdTrabajador") = ob.IdTrabajador
    '                    rowDetalle("IdVehiculo") = ob.IdVehiculo
    '                    rowDetalle("IdRuta") = ob.IdRuta
    '                    rowDetalle("IdBanco") = ob.IdBanco
    '                    rowDetalle("IdAnalisis1") = ob.IdAnalisis1
    '                    rowDetalle("IdAnalisis2") = ob.IdAnalisis2
    '                    rowDetalle("Activo") = 1
    '                    rowDetalle("IdAsientoMovimiento") = ""
    '                    rowDetalle("Monto") = ob.Monto
    '                    rowDetalle("Saldo") = ob.Saldo
    '                    rowDetalle("IdMovimientoAnalisis") = ""
    '                    rowDetalle("IdGastoFuncion") = ob.IdGastoFuncion
    '                    rowDetalle("IdOrigenProrrateo") = ""
    '                    dt_MA1.Rows.Add(rowDetalle)
    '                    lsNumero = lsNumero + 1
    '                Next
    '                oeAsientoMovimiento.DataTableAnalisis = dt_MA1
    '            Else
    '                For Each ob As e_MovimientoAnalisis In .MovimientoAnalisis
    '                    oeAsientoMovimiento.MovimientoAnalisis.Add(ob)
    '                Next
    '            End If

    '        End If
    '    End With

    '    Return oeAsientoMovimiento

    'End Function

    Public Function LineaImpuestosCompras(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento, ByVal leCuentasGenerales As System.Collections.Generic.List(Of e_TablaContableDet)) As System.Collections.Generic.List(Of e_AsientoMovimiento) Implements Il_MovimientoDocumento.LineaImpuestosCompras
        Dim leMovLista As New List(Of e_AsientoMovimiento)
        Dim oeMovimientoAsiento As e_AsientoMovimiento
        With oeMovDoc
            Dim oeTCD As e_TablaContableDet
            Dim odTCD As New d_TablaContableDet
            Dim leListaFiltro As New List(Of e_TablaContableDet)
            'cuenta IGV
            If .Compra.TotalIGVCompra > 0 Then
                oeMovimientoAsiento = New e_AsientoMovimiento
                oeMovimientoAsiento.IdAsiento = oeAs.Id
                oeMovimientoAsiento.IdUsuarioCrea = .IdUsuarioCrea
                oeMovimientoAsiento.Glosa = oeAs.GlosaImprime
                oeMovimientoAsiento.Activo = True
                oeMovimientoAsiento.TipoOperacion = "I"
                oeTCD = New e_TablaContableDet
                leListaFiltro = leCuentasGenerales.ToList
                oeTCD = leListaFiltro.Where(Function(it) it.Nombre = "CTAIGV").ToList(0)
                oeMovimientoAsiento.IdCuentaContable = oeTCD.Texto2

                If .Compra.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
                    If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                        oeMovimientoAsiento.DebeMN = .Compra.TotalIGVCompra
                        oeMovimientoAsiento.HaberMN = 0
                        oeMovimientoAsiento.DebeME = .Compra.TotalIGVCompra / .TipoCambio
                        oeMovimientoAsiento.HaberME = 0
                    Else
                        oeMovimientoAsiento.DebeMN = 0
                        oeMovimientoAsiento.HaberMN = .Compra.TotalIGVCompra
                        oeMovimientoAsiento.DebeME = 0
                        oeMovimientoAsiento.HaberME = .Compra.TotalIGVCompra / .TipoCambio
                    End If
                Else 'dolares(codigo de sunat)
                    If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                        oeMovimientoAsiento.DebeMN = .Compra.TotalIGVCompra * .TipoCambio
                        oeMovimientoAsiento.HaberMN = 0
                        oeMovimientoAsiento.DebeME = .Compra.TotalIGVCompra
                        oeMovimientoAsiento.HaberME = 0
                    Else
                        oeMovimientoAsiento.DebeMN = 0
                        oeMovimientoAsiento.HaberMN = .Compra.TotalIGVCompra * .TipoCambio
                        oeMovimientoAsiento.DebeME = 0
                        oeMovimientoAsiento.HaberME = .Compra.TotalIGVCompra
                    End If
                End If
                leMovLista.Add(oeMovimientoAsiento)
            End If

            '-----cuenta del ISC
            If .Compra.Isc > 0 Then
                oeMovimientoAsiento = New e_AsientoMovimiento
                oeMovimientoAsiento.IdAsiento = oeAs.Id
                oeMovimientoAsiento.IdUsuarioCrea = .IdUsuarioCrea
                oeMovimientoAsiento.Glosa = oeAs.GlosaImprime
                oeMovimientoAsiento.Activo = True
                oeMovimientoAsiento.TipoOperacion = "I"
                oeTCD = New e_TablaContableDet
                leListaFiltro = leCuentasGenerales.ToList
                oeTCD = leListaFiltro.Where(Function(it) it.Nombre = "CTAISC").ToList(0)
                oeMovimientoAsiento.IdCuentaContable = oeTCD.Texto2
                If .Compra.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
                    If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                        oeMovimientoAsiento.DebeMN = .Compra.Isc
                        oeMovimientoAsiento.HaberMN = 0
                        oeMovimientoAsiento.DebeME = .Compra.Isc / .TipoCambio
                        oeMovimientoAsiento.HaberME = 0
                    Else
                        oeMovimientoAsiento.DebeMN = 0
                        oeMovimientoAsiento.HaberMN = .Compra.Isc
                        oeMovimientoAsiento.DebeME = 0
                        oeMovimientoAsiento.HaberME = .Compra.Isc / .TipoCambio
                    End If
                Else 'dolares(codigo de sunat)
                    If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                        oeMovimientoAsiento.DebeMN = .Compra.Isc
                        oeMovimientoAsiento.HaberMN = 0
                        oeMovimientoAsiento.DebeME = .Compra.Isc / .TipoCambio
                        oeMovimientoAsiento.HaberME = 0
                    Else
                        oeMovimientoAsiento.DebeMN = 0
                        oeMovimientoAsiento.HaberMN = .Compra.Isc
                        oeMovimientoAsiento.DebeME = 0
                        oeMovimientoAsiento.HaberME = .Compra.Isc / .TipoCambio
                    End If
                End If
                leMovLista.Add(oeMovimientoAsiento)
            End If

            '-----cuenta del Otros Tributos
            If .Compra.OtrosTributos > 0 Then
                oeMovimientoAsiento = New e_AsientoMovimiento
                oeMovimientoAsiento.IdAsiento = oeAs.Id
                oeMovimientoAsiento.IdUsuarioCrea = .IdUsuarioCrea
                oeMovimientoAsiento.Glosa = oeAs.GlosaImprime
                oeMovimientoAsiento.Activo = True
                oeMovimientoAsiento.TipoOperacion = "I"
                oeTCD = New e_TablaContableDet
                leListaFiltro = leCuentasGenerales.ToList
                oeTCD = leListaFiltro.Where(Function(it) it.Nombre = "CTAOTROSTRIBUTOS").ToList(0)
                oeMovimientoAsiento.IdCuentaContable = oeTCD.Texto2
                If .Compra.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
                    If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                        oeMovimientoAsiento.DebeMN = .Compra.OtrosTributos
                        oeMovimientoAsiento.HaberMN = 0
                        oeMovimientoAsiento.DebeME = .Compra.OtrosTributos / .TipoCambio
                        oeMovimientoAsiento.HaberME = 0
                    Else
                        oeMovimientoAsiento.DebeMN = 0
                        oeMovimientoAsiento.HaberMN = .Compra.OtrosTributos
                        oeMovimientoAsiento.DebeME = 0
                        oeMovimientoAsiento.HaberME = .Compra.OtrosTributos / .TipoCambio
                    End If
                Else 'dolares(codigo de sunat)
                    If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                        oeMovimientoAsiento.DebeMN = .Compra.OtrosTributos
                        oeMovimientoAsiento.HaberMN = 0
                        oeMovimientoAsiento.DebeME = .Compra.OtrosTributos / .TipoCambio
                        oeMovimientoAsiento.HaberME = 0
                    Else
                        oeMovimientoAsiento.DebeMN = 0
                        oeMovimientoAsiento.HaberMN = .Compra.OtrosTributos
                        oeMovimientoAsiento.DebeME = 0
                        oeMovimientoAsiento.HaberME = .Compra.OtrosTributos / .TipoCambio
                    End If
                End If
                leMovLista.Add(oeMovimientoAsiento)
            End If
        End With
        Return leMovLista

    End Function

    'Public Function LineaImpuestosVentas(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento, ByVal leCuentaGeneral As System.Collections.Generic.List(Of e_TablaContableDet)) As System.Collections.Generic.List(Of e_AsientoMovimiento) Implements Il_MovimientoDocumento.LineaImpuestosVentas
    '    Dim leMovLista As New List(Of e_AsientoMovimiento)
    '    Dim oeMovimientoAsiento As e_AsientoMovimiento
    '    With oeMovDoc
    '        Dim oeTCD As e_TablaContableDet
    '        Dim odTCD As New d_TablaContableDet
    '        Dim leListaFiltro As New List(Of e_TablaContableDet)
    '        'cuenta IGV
    '        If .Venta.IGV > 0 Then
    '            oeMovimientoAsiento = New e_AsientoMovimiento
    '            oeMovimientoAsiento.IdAsiento = oeAs.Id
    '            oeMovimientoAsiento.IdUsuarioCrea = .IdUsuarioCrea
    '            oeMovimientoAsiento.Glosa = oeAs.Glosa
    '            oeMovimientoAsiento.Activo = True
    '            oeMovimientoAsiento.TipoOperacion = "I"
    '            oeTCD = New e_TablaContableDet
    '            leListaFiltro = leCuentaGeneral.ToList
    '            oeTCD = leListaFiltro.Where(Function(it) it.Nombre = "CTAIGV").ToList(0)
    '            oeMovimientoAsiento.IdCuentaContable = oeTCD.Texto2

    '            If .Venta.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
    '                If .Venta.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
    '                    oeMovimientoAsiento.DebeMN = .Venta.IGV
    '                    oeMovimientoAsiento.HaberMN = 0
    '                    oeMovimientoAsiento.DebeME = .Venta.IGV / .TipoCambio
    '                    oeMovimientoAsiento.HaberME = 0
    '                Else
    '                    oeMovimientoAsiento.DebeMN = 0
    '                    oeMovimientoAsiento.HaberMN = .Venta.IGV
    '                    oeMovimientoAsiento.DebeME = 0
    '                    oeMovimientoAsiento.HaberME = .Venta.IGV / .TipoCambio
    '                End If
    '            Else 'dolares(codigo de sunat)
    '                If .Venta.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
    '                    oeMovimientoAsiento.DebeMN = .Venta.IGV
    '                    oeMovimientoAsiento.HaberMN = 0
    '                    oeMovimientoAsiento.DebeME = .Venta.IGV / .TipoCambio
    '                    oeMovimientoAsiento.HaberME = 0
    '                Else
    '                    oeMovimientoAsiento.DebeMN = 0
    '                    oeMovimientoAsiento.HaberMN = .Venta.IGV
    '                    oeMovimientoAsiento.DebeME = 0
    '                    oeMovimientoAsiento.HaberME = .Venta.IGV / .TipoCambio
    '                End If
    '            End If
    '            leMovLista.Add(oeMovimientoAsiento)
    '        End If

    '        '-----cuenta del ISC
    '        If .Venta.ISC > 0 Then
    '            oeMovimientoAsiento = New e_AsientoMovimiento
    '            oeMovimientoAsiento.IdAsiento = oeAs.Id
    '            oeMovimientoAsiento.IdUsuarioCrea = .IdUsuarioCrea
    '            oeMovimientoAsiento.Glosa = oeAs.Glosa
    '            oeMovimientoAsiento.Activo = True
    '            oeMovimientoAsiento.TipoOperacion = "I"
    '            oeTCD = New e_TablaContableDet
    '            leListaFiltro = leCuentaGeneral.ToList
    '            oeTCD = leListaFiltro.Where(Function(it) it.Nombre = "CTAISC").ToList(0)
    '            oeMovimientoAsiento.IdCuentaContable = oeTCD.Texto2
    '            If .Venta.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
    '                If .Venta.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
    '                    oeMovimientoAsiento.DebeMN = .Venta.ISC
    '                    oeMovimientoAsiento.HaberMN = 0
    '                    oeMovimientoAsiento.DebeME = .Venta.ISC / .TipoCambio
    '                    oeMovimientoAsiento.HaberME = 0
    '                Else
    '                    oeMovimientoAsiento.DebeMN = 0
    '                    oeMovimientoAsiento.HaberMN = .Venta.ISC
    '                    oeMovimientoAsiento.DebeME = 0
    '                    oeMovimientoAsiento.HaberME = .Venta.ISC / .TipoCambio
    '                End If
    '            Else 'dolares(codigo de sunat)
    '                If .Venta.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
    '                    oeMovimientoAsiento.DebeMN = .Venta.ISC
    '                    oeMovimientoAsiento.HaberMN = 0
    '                    oeMovimientoAsiento.DebeME = .Venta.ISC / .TipoCambio
    '                    oeMovimientoAsiento.HaberME = 0
    '                Else
    '                    oeMovimientoAsiento.DebeMN = 0
    '                    oeMovimientoAsiento.HaberMN = .Venta.ISC
    '                    oeMovimientoAsiento.DebeME = 0
    '                    oeMovimientoAsiento.HaberME = .Venta.ISC / .TipoCambio
    '                End If
    '            End If
    '            leMovLista.Add(oeMovimientoAsiento)
    '        End If

    '        '-----cuenta del Otros Tributos
    '        If .Venta.OtrosTributos > 0 Then
    '            oeMovimientoAsiento = New e_AsientoMovimiento
    '            oeMovimientoAsiento.IdAsiento = oeAs.Id
    '            oeMovimientoAsiento.IdUsuarioCrea = .IdUsuarioCrea
    '            oeMovimientoAsiento.Glosa = oeAs.Glosa
    '            oeMovimientoAsiento.Activo = True
    '            oeMovimientoAsiento.TipoOperacion = "I"
    '            oeTCD = New e_TablaContableDet
    '            leListaFiltro = leCuentaGeneral.ToList
    '            oeTCD = leListaFiltro.Where(Function(it) it.Nombre = "CTAOTROSTRIBUTOS").ToList(0)
    '            oeMovimientoAsiento.IdCuentaContable = oeTCD.Texto2
    '            If .Venta.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
    '                If .Venta.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
    '                    oeMovimientoAsiento.DebeMN = .Venta.OtrosTributos
    '                    oeMovimientoAsiento.HaberMN = 0
    '                    oeMovimientoAsiento.DebeME = .Venta.OtrosTributos / .TipoCambio
    '                    oeMovimientoAsiento.HaberME = 0
    '                Else
    '                    oeMovimientoAsiento.DebeMN = 0
    '                    oeMovimientoAsiento.HaberMN = .Venta.OtrosTributos
    '                    oeMovimientoAsiento.DebeME = 0
    '                    oeMovimientoAsiento.HaberME = .Venta.OtrosTributos / .TipoCambio
    '                End If
    '            Else 'dolares(codigo de sunat)
    '                If .Venta.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
    '                    oeMovimientoAsiento.DebeMN = .Venta.OtrosTributos
    '                    oeMovimientoAsiento.HaberMN = 0
    '                    oeMovimientoAsiento.DebeME = .Venta.OtrosTributos / .TipoCambio
    '                    oeMovimientoAsiento.HaberME = 0
    '                Else
    '                    oeMovimientoAsiento.DebeMN = 0
    '                    oeMovimientoAsiento.HaberMN = .Venta.OtrosTributos
    '                    oeMovimientoAsiento.DebeME = 0
    '                    oeMovimientoAsiento.HaberME = .Venta.OtrosTributos / .TipoCambio
    '                End If
    '            End If
    '            leMovLista.Add(oeMovimientoAsiento)
    '        End If
    '    End With
    '    Return leMovLista

    'End Function

    Public Function LineasDestinoCompras(ByVal oeMovDoc As e_MovimientoDocumento, ByVal oeAs As e_Asiento) As System.Collections.Generic.List(Of e_AsientoMovimiento) Implements Il_MovimientoDocumento.LineasDestinoCompras
        Dim leMovLista As New List(Of e_AsientoMovimiento)
        Dim oeMovimientoAsiento As e_AsientoMovimiento
        With oeMovDoc
            '---------------------cuenta 60 --DEBE------------------------------------------
            oeMovimientoAsiento = New e_AsientoMovimiento
            oeMovimientoAsiento.IdAsiento = oeAs.Id
            oeMovimientoAsiento.IdUsuarioCrea = .IdUsuarioCrea
            oeMovimientoAsiento.Glosa = oeAs.Glosa
            oeMovimientoAsiento.Activo = True
            oeMovimientoAsiento.TipoOperacion = "I"
            oeMovimientoAsiento.IdCuentaContable = oeMovDoc.Compra.TipoCompra.Texto2

            If .Compra.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
                If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                    oeMovimientoAsiento.DebeMN = .Compra.Base1 + .Compra.Base2 + .Compra.Base3
                    oeMovimientoAsiento.HaberMN = 0
                    oeMovimientoAsiento.DebeME = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3) / .TipoCambio
                    oeMovimientoAsiento.HaberME = 0
                Else
                    oeMovimientoAsiento.DebeMN = 0
                    oeMovimientoAsiento.HaberMN = .Compra.Base1 + .Compra.Base2 + .Compra.Base3
                    oeMovimientoAsiento.DebeME = 0
                    oeMovimientoAsiento.HaberME = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3) / .TipoCambio
                End If
            Else 'dolares(codigo de sunat)
                If .Compra.TipoDoc.Codigo <> "07" Then 'nota de credito (codigo sunat)
                    oeMovimientoAsiento.DebeMN = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3) * .TipoCambio
                    oeMovimientoAsiento.HaberMN = 0
                    oeMovimientoAsiento.DebeME = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3)
                    oeMovimientoAsiento.HaberME = 0
                Else
                    oeMovimientoAsiento.DebeMN = 0
                    oeMovimientoAsiento.HaberMN = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3) * .TipoCambio
                    oeMovimientoAsiento.DebeME = 0
                    oeMovimientoAsiento.HaberME = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3)
                End If
            End If
            leMovLista.Add(oeMovimientoAsiento)
            '-------------------------------------------------------------------------------

            '--------------------cuenta 61 - HABER-------------------------------------------
            oeMovimientoAsiento = New e_AsientoMovimiento
            oeMovimientoAsiento.IdAsiento = oeAs.Id
            oeMovimientoAsiento.IdUsuarioCrea = .IdUsuarioCrea
            oeMovimientoAsiento.Glosa = oeAs.Glosa
            oeMovimientoAsiento.Activo = True
            oeMovimientoAsiento.TipoOperacion = "I"
            oeMovimientoAsiento.IdCuentaContable = oeMovDoc.Compra.TipoCompra.Texto3
            If .Compra.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
                If .Compra.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
                    oeMovimientoAsiento.DebeMN = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3)
                    oeMovimientoAsiento.HaberMN = 0
                    oeMovimientoAsiento.DebeME = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3) / .TipoCambio
                    oeMovimientoAsiento.HaberME = 0
                Else
                    oeMovimientoAsiento.DebeMN = 0
                    oeMovimientoAsiento.HaberMN = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3)
                    oeMovimientoAsiento.DebeME = 0
                    oeMovimientoAsiento.HaberME = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3) / .TipoCambio
                End If
            Else 'dolares(codigo de sunat)
                If .Compra.TipoDoc.Codigo = "07" Then 'nota de credito (codigo sunat)
                    oeMovimientoAsiento.DebeMN = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3) * .TipoCambio
                    oeMovimientoAsiento.HaberMN = 0
                    oeMovimientoAsiento.DebeME = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3)
                    oeMovimientoAsiento.HaberME = 0
                Else
                    oeMovimientoAsiento.DebeMN = 0
                    oeMovimientoAsiento.HaberMN = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3) * .TipoCambio
                    oeMovimientoAsiento.DebeME = 0
                    oeMovimientoAsiento.HaberME = (.Compra.Base1 + .Compra.Base2 + .Compra.Base3)
                End If
            End If
            leMovLista.Add(oeMovimientoAsiento)
            '---------------------------------------------------------------------------------------
        End With
        Return leMovLista
    End Function

    Public Function Listar(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As System.Collections.Generic.List(Of e_MovimientoDocumento) Implements Il_MovimientoDocumento.Listar
        Try
            Return odMovimientoDocumento.Listar(oeMovimientoDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDetallesPorDocumentos(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As System.Collections.Generic.List(Of e_Material) Implements Il_MovimientoDocumento.ListarDetallesPorDocumentos
        Try
            Return odMovimientoDocumento.ListarDetallesPorDocumentos(oeMovimientoDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDocumentosPorCompras(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As System.Collections.Generic.List(Of e_MovimientoDocumento) Implements Il_MovimientoDocumento.ListarDocumentosPorCompras
        Try
            Return odMovimientoDocumento.ListarDocumentosPorCompras(oeMovimientoDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarFlujoCajaIsl(ByVal FechaInic As Date, ByVal FechaFin As Date) As DataTable Implements Il_MovimientoDocumento.ListarFlujoCajaIsl
        Try
            Return odMovimientoDocumento.ListarFlujoCajaIsl(FechaInic, FechaFin)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento Implements Il_MovimientoDocumento.Obtener
        Try
            Return odMovimientoDocumento.Obtener(oeMovimientoDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener2(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento Implements Il_MovimientoDocumento.Obtener2
        Try
            Return odMovimientoDocumento.Obtener2(oeMovimientoDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerCompra(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento Implements Il_MovimientoDocumento.ObtenerCompra
        Try
            Return odMovimientoDocumento.ObtenerCompra(oeMovimientoDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDocumentosPorCompras(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento Implements Il_MovimientoDocumento.ObtenerDocumentosPorCompras
        Try
            Return odMovimientoDocumento.ObtenerDocumentosPorCompras(oeMovimientoDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerNumDoc(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento Implements Il_MovimientoDocumento.ObtenerNumDoc
        Try
            Return odMovimientoDocumento.ObtienerNumDoc(oeMovimientoDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento Implements Il_MovimientoDocumento.ObtenerVenta
        Try
            Return odMovimientoDocumento.ObtenerVenta(oeMovimientoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.Validar
        Try
            With oeMovimientoDocumento
                Dim olFuncionesGenerales As New l_FuncionesGenerales
                'Validar el periodo de ventas       
                If oeMovimientoDocumento.IndCompraVenta = 1 Then
                    olFuncionesGenerales.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, gAreasSGI.Compras)
                Else
                    olFuncionesGenerales.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, gAreasSGI.Ventas)
                End If

                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoDocumento, "Seleciona Tipo Documento")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdClienteProveedor, IIf(.IndCompraVenta = 1, "Seleccione Proveedor", "Seleccione Cliente"))
                l_FuncionesGenerales.ValidarCampoNoNulo(.Serie, "Agregue Serie al Documento.")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Numero, "Agregue Número al Documento.")
                If .TipoCambio = 0 Then Throw New Exception("No Existe Tipo de Cambio")
                If oeMovimientoDocumento.IndCompraVenta = 1 Or oeMovimientoDocumento.IndCompraVenta = 2 Then ' ES COMPRA O VENTA
                    olFuncionesGenerales.ValidarDocumentoDuplicado(oeMovimientoDocumento, IIf(oeMovimientoDocumento.IndCompraVenta = 1, False, True))
                End If
                If oeMovimientoDocumento.TipoOperacion = "A" Then
                    Dim MovDoc As New List(Of e_MovimientoDocumento)
                    MovDoc.Add(oeMovimientoDocumento)
                    olFuncionesGenerales.ValidarDatosDeDctoExistente(MovDoc, True)
                End If
                If .lstDetalleDocumento.Count > 0 Then
                    If .Total = 0 Then Throw New Exception("Actualize precios de Detalle. Total del Documento no puede ser cero")
                End If
                'ValidarProveedor(oeMovimientoDocumento)''--------------por aqui entra tanto ventas como compras
                'If .TipoOperacion = "I" And .IndCompraVenta = "1" Then ValidarSerieNumero(oeMovimientoDocumento)
                'If (Not .lstDetalleDocumento Is Nothing) AndAlso _
                '.lstDetalleDocumento.Where(Function(item) item.TipoOperacion <> "E").ToList.Count _
                '= 0 Then Throw New Exception("Debe agregar items para generar una factura.")'--NO VA AQUI conta no graba detalles
                'For Each fila As e_DetalleDocumento In oeMovimientoDocumento.lstDetalleDocumento
                '    If fila.Precio = 0.0 Then Throw New Exception("Al menos uno de sus detalles es igual a 0. Por Favor Ingrese el PU C/Imp")
                'Next'----NO VA AQUI ,conta no graba detalles
            End With
            Return True
        Catch ex As Exception
            Throw ex

        End Try

    End Function

    Public Function ValidarNC_ND(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.ValidarNC_ND
        Try

            'obtener lista de documentos
            'si NC o ND es electronico no tenga registrado uno antes
            'si NC no supere el importe de la suma de todos.
            'Throw New Exception("No Existe Tipo de Cambio")
            Return True
            'With oeMovimientoDocumento
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    'Validar el periodo de ventas          
            '    olFuncionesGenerales.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, gAreasSGI.Ventas)

            '    l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoDocumento, "Seleciona Tipo Documento")
            '    l_FuncionesGenerales.ValidarCampoNoNulo(.IdClienteProveedor, IIf(.IndCompraVenta = 1, "Seleccione Proveedor", "Seleccione Cliente"))
            '    l_FuncionesGenerales.ValidarCampoNoNulo(.Serie, "Agregue Serie al Documento.")
            '    l_FuncionesGenerales.ValidarCampoNoNulo(.Numero, "Agregue Número al Documento.")
            '    If .TipoCambio = 0 Then Throw New Exception("No Existe Tipo de Cambio")
            '    If oeMovimientoDocumento.IndCompraVenta = 1 Or oeMovimientoDocumento.IndCompraVenta = 2 Then ' ES COMPRA O VENTA
            '        olFuncionesGenerales.ValidarDocumentoDuplicado(oeMovimientoDocumento, IIf(oeMovimientoDocumento.IndCompraVenta = 1, False, True))
            '    End If
            '    If oeMovimientoDocumento.TipoOperacion = "A" Then
            '        Dim MovDoc As New List(Of e_MovimientoDocumento)
            '        MovDoc.Add(oeMovimientoDocumento)
            '        olFuncionesGenerales.ValidarDatosDeDctoExistente(MovDoc, True)
            '    End If
            '    If .lstDetalleDocumento.Count > 0 Then
            '        If .Total = 0 Then Throw New Exception("Actualize precios de Detalle. Total del Documento no puede ser cero")
            '    End If
            '    'ValidarProveedor(oeMovimientoDocumento)''--------------por aqui entra tanto ventas como compras
            '    'If .TipoOperacion = "I" And .IndCompraVenta = "1" Then ValidarSerieNumero(oeMovimientoDocumento)
            '    'If (Not .lstDetalleDocumento Is Nothing) AndAlso _
            '    '.lstDetalleDocumento.Where(Function(item) item.TipoOperacion <> "E").ToList.Count _
            '    '= 0 Then Throw New Exception("Debe agregar items para generar una factura.")'--NO VA AQUI conta no graba detalles
            '    'For Each fila As e_DetalleDocumento In oeMovimientoDocumento.lstDetalleDocumento
            '    '    If fila.Precio = 0.0 Then Throw New Exception("Al menos uno de sus detalles es igual a 0. Por Favor Ingrese el PU C/Imp")
            '    'Next'----NO VA AQUI ,conta no graba detalles
            'End With
            'Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidarAnticipo(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.ValidarAnticipo
        Try
            Dim loFuncionesGenerales As New l_FuncionesGenerales
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, oeMovimientoDocumento.FechaEmision, oeMovimientoDocumento.FechaEmision.Year.ToString + "-" + oeMovimientoDocumento.FechaEmision.Month.ToString)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCancelacionDocumentos(ByVal leDocumentosAgregados As System.Collections.Generic.List(Of e_MovimientoDocumento), ByVal fecha As Date) As Boolean Implements Il_MovimientoDocumento.ValidarCancelacionDocumentos
        Try
            Dim loFuncionesGenerales As New l_FuncionesGenerales
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, fecha, fecha.Year.ToString + "-" + fecha.Month.ToString)
            For Each obj As e_MovimientoDocumento In leDocumentosAgregados
                If obj.FechaEmision.Date > fecha Then
                    Throw New Exception("La fecha de un documento es mayor a la fecha de la operacion de cancelacion")
                End If
            Next
            loFuncionesGenerales.ValidarDatosDeDctoExistente(leDocumentosAgregados)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.ValidarVenta
        Try
            'validar saldo
            '
            Dim olFuncionesGenerales As New l_FuncionesGenerales
            olFuncionesGenerales.ValidarDocumentoDuplicado(oeMovimientoDocumento, True)
            olFuncionesGenerales.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, gAreasSGI.Contabilidad, oeMovimientoDocumento.FechaEmision, "")

            If oeMovimientoDocumento.TipoOperacion = "A" Then
                Dim leMovDoc As New List(Of e_MovimientoDocumento)
                leMovDoc.Add(oeMovimientoDocumento)
                olFuncionesGenerales.ValidarDatosDeDctoExistente(leMovDoc, True)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarMonto(ByVal movimientosDocumento As System.Collections.Generic.List(Of e_MovimientoDocumento), _
                                 ByVal tipoMovimiento As String) As Boolean Implements Il_MovimientoDocumento.ValidarMonto
        Try
            For Each oeMovimientoDocumento As e_MovimientoDocumento In movimientosDocumento
                With oeMovimientoDocumento

                    If Math.Round(.MontoOperar, 2) > Math.Round(.Saldo, 2) Then
                        Throw New Exception("El Monto a " & tipoMovimiento & " es mayor al Saldo")
                    End If
                    If .MontoOperar <= 0 Then
                        Throw New Exception("El Monto a  " & tipoMovimiento & "  es igual a cero")
                    End If
                End With
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarCtasXCobrar(ByVal IdClienteProveedor As String, ByVal FechaHasta As Date) As DataTable Implements Il_MovimientoDocumento.ListarCtasXCobrar
        Try
            Dim DatTableC As DataTable = odMovimientoDocumento.ListarCtasXCobrar(IdClienteProveedor, FechaHasta)

            If DatTableC.Rows.Count = 0 Then Throw New Exception("Información no registrada")

            Dim ctacte As String = ""
            ctacte = DatTableC.Rows(0).Item("CtaCte")
            Dim SumaSaldoSoles As Double = 0
            Dim SumaSaldoDolares As Double = 0
            Dim SumaDetraccion As Double = 0
            Dim SumaNeto As Double = 0
            Dim SumaAlTCV As Double = 0

            Dim SumaSaldoSolesTo As Double = 0
            Dim SumaSaldoDolaresTo As Double = 0
            Dim SumaDetraccionTo As Double = 0
            Dim SumaNetoTo As Double = 0
            Dim SumaAlTCVTo As Double = 0


            Dim DtTPasPat As DataTable
            DtTPasPat = DatTableC.Copy
            For Each obj As DataRow In DtTPasPat.Rows
                If ctacte = obj.Item("CtaCte") Then
                    SumaSaldoSoles = SumaSaldoSoles + obj.Item("SALDO_S")
                    SumaSaldoDolares = SumaSaldoDolares + obj.Item("SALDO_D")
                    SumaDetraccion = SumaDetraccion + obj.Item("Detraccion")
                    SumaNeto = SumaNeto + obj.Item("Neto")
                    SumaAlTCV = SumaAlTCV + obj.Item("SALDO_AL_TCV")
                Else
                    Dim fila As DataRow = DatTableC.NewRow
                    fila.Item("CtaCte") = ctacte
                    fila.Item("Dni") = ""
                    fila.Item("tipoDoc") = ""
                    fila.Item("Serie") = ""
                    fila.Item("Numero") = "SubTotal"
                    fila.Item("FechaEmision") = ""
                    fila.Item("FechaVencimiento") = ""
                    'fila.Item("Vencido") = 0
                    fila.Item("FACT_S") = 0
                    fila.Item("FACT_D") = 0
                    fila.Item("Detraccion") = SumaDetraccion
                    fila.Item("Neto") = SumaNeto
                    fila.Item("SALDO_S") = SumaSaldoSoles
                    fila.Item("SALDO_D") = SumaSaldoDolares
                    fila.Item("SALDO_AL_TCV") = SumaAlTCV
                    fila.Item("GlosaCtaxCyP") = ""
                    fila.Item("Fecha") = "31/12/2099"
                    DatTableC.Rows.Add(fila)
                    SumaSaldoSolesTo = SumaSaldoSolesTo + SumaSaldoSoles
                    SumaSaldoDolaresTo = SumaSaldoDolaresTo + SumaSaldoDolares
                    SumaDetraccionTo = SumaDetraccionTo + SumaDetraccion
                    SumaNetoTo = SumaNetoTo + SumaNeto
                    SumaAlTCVTo = SumaAlTCVTo + SumaAlTCV
                    SumaSaldoSoles = obj.Item("SALDO_S")
                    SumaSaldoDolares = obj.Item("SALDO_D")
                    SumaDetraccion = obj.Item("Detraccion")
                    SumaNeto = obj.Item("Neto")
                    SumaAlTCV = obj.Item("SALDO_AL_TCV")
                    ctacte = obj.Item("CtaCte")
                End If
            Next
            Dim fila2 As DataRow = DatTableC.NewRow
            fila2.Item("CtaCte") = ctacte
            fila2.Item("Dni") = ""
            fila2.Item("tipoDoc") = ""
            fila2.Item("Serie") = ""
            fila2.Item("Numero") = "SubTotal"
            fila2.Item("FechaEmision") = ""
            fila2.Item("FechaVencimiento") = ""
            'fila2.Item("Vencido") = 0
            fila2.Item("FACT_S") = 0
            fila2.Item("FACT_D") = 0
            fila2.Item("Detraccion") = SumaDetraccion
            fila2.Item("Neto") = SumaNeto
            fila2.Item("SALDO_S") = SumaSaldoSoles
            fila2.Item("SALDO_D") = SumaSaldoDolares
            fila2.Item("SALDO_AL_TCV") = SumaAlTCV
            fila2.Item("GlosaCtaxCyP") = ""
            fila2.Item("Fecha") = "31/12/2099"
            DatTableC.Rows.Add(fila2)
            SumaSaldoSolesTo = SumaSaldoSolesTo + SumaSaldoSoles
            SumaSaldoDolaresTo = SumaSaldoDolaresTo + SumaSaldoDolares
            SumaDetraccionTo = SumaDetraccionTo + SumaDetraccion
            SumaNetoTo = SumaNetoTo + SumaNeto
            SumaAlTCVTo = SumaAlTCVTo + SumaAlTCV
            Dim Dt As DataRow() = DatTableC.Select(Nothing, "CtaCte,Fecha")
            Dim dat As DataTable = Dt.CopyToDataTable
            Dim fila3 As DataRow = dat.NewRow
            fila3.Item("CtaCte") = ""
            fila3.Item("Dni") = ""
            fila3.Item("tipoDoc") = ""
            fila3.Item("Serie") = ""
            fila3.Item("Numero") = "TOTALES"
            fila3.Item("FechaEmision") = ""
            fila3.Item("FechaVencimiento") = ""
            'fila2.Item("Vencido") = 0
            fila3.Item("FACT_S") = 0
            fila3.Item("FACT_D") = 0
            fila3.Item("Detraccion") = SumaDetraccionTo
            fila3.Item("Neto") = SumaNetoTo
            fila3.Item("SALDO_S") = SumaSaldoSolesTo
            fila3.Item("SALDO_D") = SumaSaldoDolaresTo
            fila3.Item("SALDO_AL_TCV") = SumaAlTCVTo
            fila3.Item("GlosaCtaxCyP") = ""
            fila2.Item("Fecha") = "31/12/2199"
            dat.Rows.Add(fila3)

            Return dat
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EstadoCuenta(ByVal IdClienteProveedor As String, ByVal Cliente As Integer) As DataTable _
    Implements Il_MovimientoDocumento.EstadoCuenta
        Try
            Dim DatTableC As DataTable = odMovimientoDocumento.EstadoCuenta(IdClienteProveedor, Cliente)
            Return DatTableC
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistroVentas(ByVal IdPeriodo As String) As DataTable _
   Implements Il_MovimientoDocumento.RegistroVentas
        Try
            Dim DatTableC As DataTable = odMovimientoDocumento.RegistroVenta(IdPeriodo)
            Return DatTableC
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistroCompras(ByVal IdPeriodo As String) As DataTable _
   Implements Il_MovimientoDocumento.RegistroCompras
        Try
            Dim DatTableC As DataTable = odMovimientoDocumento.RegistroCompra(IdPeriodo)
            Return DatTableC
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarCtasXPagar(ByVal IdClienteProveedor As String, ByVal IndBancos As Boolean, IdEstado As String, IndDeuda As Boolean, IdMoneda As String) As DataTable Implements Il_MovimientoDocumento.ListarCtasXPagar
        Try
            Dim DatTableC As DataTable = odMovimientoDocumento.ListarCtasXPagar(IdClienteProveedor, IndBancos, IdEstado, IndDeuda, IdMoneda)


            Dim ctacte As String = ""
            If DatTableC.Rows.Count > 0 Then ctacte = DatTableC.Rows(0).Item("CtaCte")
            Dim SumaSaldoSoles As Double = 0
            Dim SumaSaldoDolares As Double = 0
            Dim SumaAlTCV As Double = 0

            Dim SumaSaldoSolesTo As Double = 0
            Dim SumaSaldoDolaresTo As Double = 0
            Dim SumaAlTCVTo As Double = 0


            Dim DtTPasPat As DataTable
            Dim dat As DataTable = Nothing
            DtTPasPat = DatTableC.Copy
            If DtTPasPat.Rows.Count > 0 Then
                For Each obj As DataRow In DtTPasPat.Rows
                    If ctacte = obj.Item("CtaCte") Then
                        SumaSaldoSoles = SumaSaldoSoles + obj.Item("SALDO_S")
                        SumaSaldoDolares = SumaSaldoDolares + obj.Item("SALDO_D")
                        SumaAlTCV = SumaAlTCV + obj.Item("SALDO_AL_TCV")
                    Else
                        Dim fila As DataRow = DatTableC.NewRow
                        fila.Item("CtaCte") = ctacte
                        fila.Item("Dni") = ""
                        fila.Item("TipoOrden") = ""
                        'fila.Item("Seleccion") = False
                        fila.Item("tipoDoc") = ""
                        fila.Item("Serie") = ""
                        fila.Item("Numero") = "SubTotal"
                        fila.Item("FechaEmision") = ""
                        fila.Item("FechaVencimiento") = ""
                        fila.Item("FACT_S") = 0
                        fila.Item("FACT_D") = 0
                        fila.Item("SALDO_S") = SumaSaldoSoles
                        fila.Item("SALDO_D") = SumaSaldoDolares
                        fila.Item("SALDO_AL_TCV") = SumaAlTCV
                        'fila.Item("MontoPago") = 0
                        fila.Item("Fecha") = "31/12/2099"
                        fila.Item("IdEstadoPago") = ""
                        fila.Item("EstadoPago") = ""
                        DatTableC.Rows.Add(fila)
                        SumaSaldoSolesTo = SumaSaldoSolesTo + SumaSaldoSoles
                        SumaSaldoDolaresTo = SumaSaldoDolaresTo + SumaSaldoDolares
                        SumaAlTCVTo = SumaAlTCVTo + SumaAlTCV
                        SumaSaldoSoles = obj.Item("SALDO_S")
                        SumaSaldoDolares = obj.Item("SALDO_D")
                        SumaAlTCV = obj.Item("SALDO_AL_TCV")
                        ctacte = obj.Item("CtaCte")
                    End If
                Next
                Dim fila2 As DataRow = DatTableC.NewRow
                fila2.Item("CtaCte") = ctacte
                fila2.Item("Dni") = ""
                'fila2.Item("Seleccion") = False
                fila2.Item("TipoOrden") = ""
                fila2.Item("tipoDoc") = ""
                fila2.Item("Serie") = ""
                fila2.Item("Numero") = "SubTotal"
                fila2.Item("FechaEmision") = ""
                fila2.Item("FechaVencimiento") = ""
                fila2.Item("FACT_S") = 0
                fila2.Item("FACT_D") = 0
                fila2.Item("SALDO_S") = SumaSaldoSoles
                fila2.Item("SALDO_D") = SumaSaldoDolares
                fila2.Item("SALDO_AL_TCV") = SumaAlTCV
                'fila2.Item("MontoPago") = 0
                fila2.Item("Fecha") = "31/12/2099"
                fila2.Item("IdEstadoPago") = ""
                fila2.Item("EstadoPago") = ""
                DatTableC.Rows.Add(fila2)
                SumaSaldoSolesTo = SumaSaldoSolesTo + SumaSaldoSoles
                SumaSaldoDolaresTo = SumaSaldoDolaresTo + SumaSaldoDolares
                SumaAlTCVTo = SumaAlTCVTo + SumaAlTCV
                Dim Dt As DataRow() = DatTableC.Select(Nothing, "CtaCte,Fecha")
                dat = Dt.CopyToDataTable
                Dim fila3 As DataRow = dat.NewRow
                fila3.Item("CtaCte") = ""
                fila3.Item("Dni") = ""
                fila3.Item("TipoOrden") = ""
                'fila3.Item("Seleccion") = False
                fila3.Item("tipoDoc") = ""
                fila3.Item("Serie") = ""
                fila3.Item("Numero") = "TOTALES"
                fila3.Item("FechaEmision") = ""
                fila3.Item("FechaVencimiento") = ""
                fila3.Item("FACT_S") = 0
                fila3.Item("FACT_D") = 0
                fila3.Item("SALDO_S") = SumaSaldoSolesTo
                fila3.Item("SALDO_D") = SumaSaldoDolaresTo
                fila3.Item("SALDO_AL_TCV") = SumaAlTCVTo
                'fila3.Item("MontoPago") = 0
                fila3.Item("Fecha") = "31/12/2199"
                fila3.Item("IdEstadoPago") = ""
                fila3.Item("EstadoPago") = ""
                dat.Rows.Add(fila3)
            Else
                dat = DatTableC.Copy
            End If
            Return dat
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerCantDoc(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento Implements Il_MovimientoDocumento.ObtenerCantDoc
        Try
            Return odMovimientoDocumento.ObtenerCantDoc(oeMovimientoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarAjusteTipoCambio(ByVal TipoOperacion As String, ByVal IdMovimientoDocumento As String, _
    ByVal IdPeriodo As String, ByVal Ejercicio As Integer) As DataTable Implements Il_MovimientoDocumento.ListarAjusteTipoCambio
        Try
            Return odMovimientoDocumento.ObtenerAJusteTipoCambio(TipoOperacion, IdMovimientoDocumento, IdPeriodo, Ejercicio).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarVerificacionAsiento(ByVal oeMovDoc As e_MovimientoDocumento) As DataTable Implements Il_MovimientoDocumento.ListarVerificacionAsiento
        Try
            Return odMovimientoDocumento.ListarVerificacionAsiento(oeMovDoc).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CuentasxPagarxPeriodo(ByVal Ejercicio As Integer, ByVal Mes As Integer, ByVal IndRegCompras As String, ByVal Idmoneda As String) As DataTable _
   Implements Il_MovimientoDocumento.CuentasxPagarxPeriodo
        Try
            Return odMovimientoDocumento.CuentasxPagarxPeriodo(Ejercicio, Mes, IndRegCompras, Idmoneda)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CuentasxCobrarxPeriodo(ByVal Ejercicio As Integer, ByVal Mes As Integer, _
    ByVal IndRegVentas As String, ByVal Idmoneda As String) As DataTable Implements Il_MovimientoDocumento.CuentasxCobrarxPeriodo
        Try
            Dim DatTableC As DataTable = odMovimientoDocumento.CuentasxCobrarxPeriodo(Ejercicio, Mes, IndRegVentas, Idmoneda)
            Return DatTableC
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function AsientoAperturaDocumentos(ByVal lsDocumentos() As Object, ByVal lsTipo As String,
    ByVal lsMoneda As String, ByVal Ejercicio As Integer, ByVal lnTipoCambio As Double, ByVal IdUsuarioCreacion As String,
                                              ByVal PrefijoID As String) As Boolean _
    Implements Il_MovimientoDocumento.AsientoAperturaDocumentos
        'objeto(0) = obj.Item("Id").ToString
        'objeto(1) = obj.Item("IdCuentaContable").ToString
        'objeto(2) = obj.Item("IdMoneda").ToString
        'objeto(3) = obj.Item("TipoCambio").ToString
        'objeto(4) = obj.Item("SaldoMN").ToString
        'objeto(5) = obj.Item("SaldoME").ToString
        'objeto(6) = obj.Item("TipoDocAbrev").ToString
        'objeto(7) = obj.Item("Serie").ToString
        'objeto(8) = obj.Item("Numero").ToString
        'objeto(9) = obj.Item("Nombre").ToString
        Try
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            oePeriodo.Ejercicio = Ejercicio + 1
            oePeriodo.Mes = 1
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If oePeriodo Is Nothing Then
                Throw New Exception("No Existe el Periodo: 01/" & Ejercicio.ToString)
            End If

            Dim MonedaGlosa As String = ""
            If lsDocumentos(0)(2).ToString = "1CH01" Then
                MonedaGlosa = "SOLES"
            Else
                MonedaGlosa = "DOLARES"
            End If

            Dim oeAsiento2 As New e_Asiento
            Dim olAsiento2 As New l_Asiento
            Dim leAsiento2 As New List(Of e_Asiento)

            oeAsiento2.IdPeriodo = oePeriodo.Id
            oeAsiento2.IdentificaAsiento = "APE" & lsTipo & MonedaGlosa
            oeAsiento2.IdMoneda = lsDocumentos(0)(2).ToString
            leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            If leAsiento2.Count > 0 Then
                Throw New Exception("Ya existe el asiento para la Apertura de " & lsTipo & " " & MonedaGlosa)
            End If
            '------------Hasta acáse valida que no exista el asiento.

            Dim olCtaCtble As New l_CuentaContable
            Dim oeCtaCtble As New e_CuentaContable
            Dim leCtaCtble As New List(Of e_CuentaContable)
            Dim leListaFiltrada As New List(Of e_CuentaContable)
            oeCtaCtble.Ejercicio = Ejercicio + 1
            leCtaCtble.AddRange(olCtaCtble.Listar(oeCtaCtble))
            '-----------Hasta acá obtengo todas las cuentas para los asientos.

            '----------Obtener de nuevo la cuenta, en 2012----------
            Dim oeCuentaAp As New e_CuentaContable
            Dim olCuentaAp As New l_CuentaContable
            Dim ListaAp As New List(Of e_CuentaContable)
            Dim ListaAjusteAp As New List(Of e_CuentaContable)
            oeCuentaAp.Ejercicio = Ejercicio
            ListaAp.AddRange(olCuentaAp.Listar(oeCuentaAp))


            '-----------Comienzo la cabecera.
            Dim oeAsiento3 As New e_Asiento
            Dim oeAsiento As New e_Asiento
            oeAsiento.TipoOperacion = "I"
            oeAsiento.Fecha = Date.Parse("01/01/" & (Ejercicio + 1).ToString)
            oeAsiento.IdPeriodo = oePeriodo.Id
            oeAsiento.IdTipoAsiento = "APERTURA" 'Apertura
            oeAsiento.Glosa = "ASIENTO DE APERTURA DE " & UCase(lsTipo) & " EN MONEDA: " & MonedaGlosa
            oeAsiento.GlosaImprime = oeAsiento.Glosa
            oeAsiento.IdMoneda = lsDocumentos(0)(2).ToString
            oeAsiento.TipoCambio = lnTipoCambio
            oeAsiento.TotalDebe = 0
            oeAsiento.TotalHaber = 0
            oeAsiento.IdUsuarioBloquea = ""
            oeAsiento.IdEstado = "CUADRADO" 'Estado Cuadrado
            oeAsiento.IdAsientoExtorno = ""
            oeAsiento.IdUsuarioCrea = IdUsuarioCreacion
            oeAsiento.IdentificaAsiento = "APE" & lsTipo & MonedaGlosa
            ''Termino la cabecera

            ''Inicializo asientomovimiento, asientomov_movdoc , y asientomov_obligacion

            Dim olAsientoMovimiento As New l_AsientoMovimiento
            Dim odAsientoMovimiento As New d_AsientoMovimiento

            Dim olAsientoMov_MovDoc As New l_AsientoMov_MovDoc
            Dim odAsientoMov_MovDoc As New d_AsientoMov_MovDoc

            Dim olAsientoMov_Obligacion As New l_AsientoMov_ObligacionFin
            Dim odAsientoMov_Obligacion As New d_AsientoMov_ObligacionFin

            Dim oeMovAnalisis As New e_MovimientoAnalisis

            ''Creo las tablas AM / AM_MD/ AM_OFIN 2 veces
            Dim dt_AM As Data.DataTable = olAsientoMovimiento.CrearDT
            Dim dt_AM_MD As Data.DataTable = olAsientoMov_MovDoc.CrearDT
            Dim dt_AM_Ofin As Data.DataTable = olAsientoMov_Obligacion.CrearDT

            Dim dt_AM2 As Data.DataTable = olAsientoMovimiento.CrearDT
            Dim dt_AM_MD2 As Data.DataTable = olAsientoMov_MovDoc.CrearDT
            Dim dt_AM_Ofin2 As Data.DataTable = olAsientoMov_Obligacion.CrearDT

            'Obtengo el último Id de AsientoMovimiento
            Dim Id As String = odAsientoMovimiento.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(Id, 1) & "SI"
            Dim lsNumero As Integer = CInt(Right(Id, Len(Id) - 3))

            'Otengo el último Id de AsientoMov_MovDoc
            Dim Id2 As String = odAsientoMov_MovDoc.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo2 As String = Left(Id2, 1) & "SI"
            Dim lsNumero2 As Integer = CInt(Right(Id2, Len(Id2) - 3))

            'Obtengo el último Id de asientomov_obligacion
            Dim Id3 As String = odAsientoMov_Obligacion.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo3 As String = Left(Id3, 1) & "SI"
            Dim lsNumero3 As Integer = CInt(Right(Id3, Len(Id3) - 3))


            '---------------------------asientos de apertura----------------
            Dim i As Integer = 0
            For i = 0 To lsDocumentos.Length - 1
                '----linea 12 o 42-------------
                Dim rowDetalle As Data.DataRow
                rowDetalle = dt_AM.NewRow
                rowDetalle("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 13)
                rowDetalle("IdAsiento") = ""
                leListaFiltrada = leCtaCtble.ToList
                leListaFiltrada = leListaFiltrada.Where(Function(item) item.Cuenta = lsDocumentos(i)(1).ToString).ToList
                If leListaFiltrada Is Nothing Then
                    Throw New Exception("No existe esta id de cuenta : " & lsDocumentos(i)(1))
                ElseIf leListaFiltrada.Count = 0 Then
                    Throw New Exception("No existe esta id de cuenta : " & lsDocumentos(i)(1))
                End If
                rowDetalle("IdCuentaContable") = leListaFiltrada(0).Id
                rowDetalle("Glosa") = "APERTURA " & lsDocumentos(i)(6).ToString & "/" & lsDocumentos(i)(7).ToString &
                lsDocumentos(i)(8).ToString & " " & lsDocumentos(i)(9).ToString
                Dim lnMontoMN As Double = lsDocumentos(i)(4)
                Dim lnMontoME As Double = lsDocumentos(i)(5)
                Dim lnDHMN As Double = lsDocumentos(i)(4)
                Dim lnDHME As Double = lsDocumentos(i)(5)
                If lsDocumentos(i)(2) = "1CH01" Then
                    lnDHME = lnDHMN / lnTipoCambio
                Else
                    lnDHMN = lnDHME * lnTipoCambio
                End If
                If (lsTipo = "Clientes" And lnMontoME + lnMontoMN > 0) _
                Or ((lsTipo = "Proveedores" Or lsTipo = "Obligacion") And lnMontoME + lnMontoMN < 0) Then
                    rowDetalle("DebeMN") = Math.Abs(lnDHMN)
                    rowDetalle("HaberMN") = 0
                    rowDetalle("DebeME") = Math.Abs(lnDHME)
                    rowDetalle("HaberME") = 0
                Else
                    rowDetalle("DebeMN") = 0
                    rowDetalle("HaberMN") = Math.Abs(lnDHMN)
                    rowDetalle("DebeME") = 0
                    rowDetalle("HaberME") = Math.Abs(lnDHME)
                End If
                rowDetalle("IdUsuarioCrea") = IdUsuarioCreacion
                rowDetalle("FechaCreacion") = Date.Now
                rowDetalle("Activo") = True
                rowDetalle("NroLinea") = i + 1
                dt_AM.Rows.Add(rowDetalle)

                If lsTipo = "Obligacion" Then
                    Dim rowDetalle3 As Data.DataRow
                    rowDetalle3 = dt_AM_Ofin.NewRow
                    rowDetalle3("Id") = lsPrefijo3 & CompletaConCeros(lsNumero3.ToString, 12)
                    rowDetalle3("IdAsientoMovimiento") = lsDocumentos(i)(0).ToString
                    rowDetalle3("IdObligacionFinanciera") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 12)
                    rowDetalle3("Activo") = True
                    rowDetalle3("IdObligacionPago") = Nothing
                    dt_AM_Ofin.Rows.Add(rowDetalle3)
                    lsNumero3 = lsNumero3 + 1
                Else
                    Dim rowDetalle2 As Data.DataRow
                    rowDetalle2 = dt_AM_MD.NewRow
                    rowDetalle2("Id") = lsPrefijo2 & CompletaConCeros(lsNumero2.ToString, 9)
                    rowDetalle2("IdMovimientoDocumento") = lsDocumentos(i)(0).ToString
                    rowDetalle2("IdAsientoMovimiento") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 13)
                    rowDetalle2("Activo") = True
                    rowDetalle2("IdCuentaxCyP") = Nothing
                    dt_AM_MD.Rows.Add(rowDetalle2)
                    lsNumero2 = lsNumero2 + 1
                End If

                lsNumero = lsNumero + 1
            Next
            '-------------------------------------------------------------------
            '----------------asiento x Dif de Tc cuando es dolares-------------
            If lsDocumentos(0)(2).ToString = "1CH02" Then
                oePeriodo = New e_Periodo
                oePeriodo.Ejercicio = Ejercicio
                oePeriodo.Mes = 12
                oePeriodo = olPeriodo.Obtener(oePeriodo)
                If oePeriodo.Id Is Nothing Then
                    Throw New Exception("No Existe el Periodo : 12/" & Ejercicio.ToString)
                End If
                lsNumero = lsNumero
                lsNumero2 = lsNumero2
                lsNumero3 = lsNumero3

                oeAsiento3.TipoOperacion = "I"
                oeAsiento3.Fecha = Date.Parse("31/12/" & Ejercicio.ToString)
                oeAsiento3.IdPeriodo = oePeriodo.Id
                oeAsiento3.IdTipoAsiento = "DIARIO" 'Apertura
                oeAsiento3.Glosa = "ASIENTO POR DIF. DE T.C. DE APERTURA " & UCase(lsTipo)
                oeAsiento3.GlosaImprime = oeAsiento.Glosa
                oeAsiento3.IdMoneda = "1CH01"
                oeAsiento3.TipoCambio = 0
                oeAsiento3.TotalDebe = 0
                oeAsiento3.TotalHaber = 0
                oeAsiento3.IdUsuarioBloquea = ""
                oeAsiento3.IdEstado = "CUADRADO" 'Estado Cuadrado
                oeAsiento3.IdAsientoExtorno = ""
                oeAsiento3.IdUsuarioCrea = IdUsuarioCreacion
                oeAsiento3.IdentificaAsiento = "DTC" & lsTipo & MonedaGlosa
                Dim rowDetalle4 As Data.DataRow
                Dim lnPerdida As Double = 0
                Dim lnGanancia As Double = 0
                For i = 0 To lsDocumentos.Length - 1
                    '----------Cálculo----------------
                    rowDetalle4 = dt_AM2.NewRow
                    rowDetalle4("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 13)
                    rowDetalle4("IdAsiento") = ""
                    '----------Designo la cuenta------
                    ListaAjusteAp.Clear()
                    ListaAjusteAp = ListaAp.Where(Function(iTEM) iTEM.Cuenta = lsDocumentos(i)(1).ToString).ToList
                    '-------------------------------------------------------
                    rowDetalle4("IdCuentaContable") = ListaAjusteAp(0).Id
                    rowDetalle4("Glosa") = "ASIENTO POR DIF. T.C. DE " & lsDocumentos(i)(6).ToString & "/" & lsDocumentos(i)(7).ToString &
                    lsDocumentos(i)(8).ToString & " " & lsDocumentos(i)(9).ToString

                    Dim ln1 As Double = lsDocumentos(i)(5) * lsDocumentos(i)(3) 'TC Origen
                    Dim ln2 As Double = lsDocumentos(i)(5) * lnTipoCambio 'TIC Ajuste
                    If ln1 - ln2 > 0 And lsTipo = "Clientes" Then 'perdida
                        lnPerdida = lnPerdida + Math.Abs(ln1 - ln2)
                        rowDetalle4("DebeMN") = 0
                        rowDetalle4("HaberMN") = Math.Abs(ln1 - ln2)
                        rowDetalle4("DebeME") = 0
                        rowDetalle4("HaberME") = 0
                    ElseIf ln1 - ln2 < 0 And lsTipo = "Clientes" Then 'ganancia
                        lnGanancia = lnGanancia + Math.Abs(ln1 - ln2)
                        rowDetalle4("DebeMN") = Math.Abs(ln1 - ln2)
                        rowDetalle4("HaberMN") = 0
                        rowDetalle4("DebeME") = 0
                        rowDetalle4("HaberME") = 0
                    ElseIf ln1 - ln2 > 0 And (lsTipo = "Proveedores" Or lsTipo = "Obligacion") Then 'ganancia
                        lnGanancia = lnGanancia + Math.Abs(ln1 - ln2)
                        rowDetalle4("DebeMN") = Math.Abs(ln1 - ln2)
                        rowDetalle4("HaberMN") = 0
                        rowDetalle4("DebeME") = 0
                        rowDetalle4("HaberME") = 0
                    ElseIf ln1 - ln2 < 0 And (lsTipo = "Proveedores" Or lsTipo = "Obligacion") Then 'perdida
                        lnPerdida = lnPerdida + Math.Abs(ln1 - ln2)
                        rowDetalle4("DebeMN") = 0
                        rowDetalle4("HaberMN") = Math.Abs(ln1 - ln2)
                        rowDetalle4("DebeME") = 0
                        rowDetalle4("HaberME") = 0
                    End If
                    rowDetalle4("IdUsuarioCrea") = IdUsuarioCreacion
                    rowDetalle4("FechaCreacion") = Date.Now
                    rowDetalle4("Activo") = True
                    rowDetalle4("NroLinea") = i + 1
                    dt_AM2.Rows.Add(rowDetalle4)


                    If lsTipo = "Obligacion" Then
                        Dim rowDetalle5 As Data.DataRow
                        rowDetalle5 = dt_AM_Ofin2.NewRow
                        rowDetalle5("Id") = lsPrefijo3 & CompletaConCeros(lsNumero3.ToString, 12)
                        rowDetalle5("IdAsientoMovimiento") = lsDocumentos(i)(0).ToString
                        rowDetalle5("IdObligacionFinanciera") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 12)
                        rowDetalle5("Activo") = True
                        rowDetalle5("IdObligacionPago") = Nothing
                        dt_AM_Ofin2.Rows.Add(rowDetalle5)
                        lsNumero3 = lsNumero3 + 1
                    Else
                        Dim rowDetalle6 As Data.DataRow
                        rowDetalle6 = dt_AM_MD2.NewRow
                        rowDetalle6("Id") = lsPrefijo2 & CompletaConCeros(lsNumero2.ToString, 9)
                        rowDetalle6("IdMovimientoDocumento") = lsDocumentos(i)(0).ToString
                        rowDetalle6("IdAsientoMovimiento") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 13)
                        rowDetalle6("Activo") = True
                        rowDetalle6("IdCuentaxCyP") = Nothing
                        dt_AM_MD2.Rows.Add(rowDetalle6)
                        lsNumero2 = lsNumero2 + 1
                    End If
                    lsNumero = lsNumero + 1
                Next
                If lnPerdida > 0 Then
                    rowDetalle4 = dt_AM2.NewRow
                    rowDetalle4("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 13)
                    rowDetalle4("IdAsiento") = ""
                    'leListaFiltrada = leCtaCtble.Where(Function(item) item.Cuenta = "67611").ToList
                    'If leListaFiltrada Is Nothing Then
                    '    Throw New Exception("No existe esta cuenta : 67611 ")
                    'ElseIf leListaFiltrada.Count = 0 Then
                    '    Throw New Exception("No existe esta cuenta : 67611 ")
                    'End If
                    Dim lsCtaPerdida As String = ""
                    CtaGananciaPerdida(lsCtaPerdida, False, Ejercicio)
                    rowDetalle4("IdCuentaContable") = lsCtaPerdida
                    rowDetalle4("Glosa") = "ASIENTO DE PERDIDA POR APERTURA DE " & UCase(lsTipo) & " EN MONEDA: " & MonedaGlosa
                    rowDetalle4("DebeMN") = lnPerdida
                    rowDetalle4("HaberMN") = 0
                    rowDetalle4("DebeME") = 0
                    rowDetalle4("HaberME") = 0
                    rowDetalle4("IdUsuarioCrea") = IdUsuarioCreacion
                    rowDetalle4("FechaCreacion") = Date.Now
                    rowDetalle4("Activo") = True
                    rowDetalle4("NroLinea") = i + 1
                    dt_AM2.Rows.Add(rowDetalle4)

                    oeMovAnalisis = New e_MovimientoAnalisis
                    oeMovAnalisis.TipoOperacion = "I"
                    oeMovAnalisis.IdGastoFuncion = "1CH000090" '---------gasto financiero
                    oeMovAnalisis.Monto = lnPerdida
                    oeMovAnalisis.Saldo = oeMovAnalisis.Monto
                    oeMovAnalisis.IdAsientoMovimiento = lsPrefijo & CompletaConCeros(lsNumero.ToString, 13)
                    lsNumero = lsNumero + 1

                End If
                If lnGanancia > 0 Then
                    rowDetalle4 = dt_AM2.NewRow
                    rowDetalle4("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 13)
                    rowDetalle4("IdAsiento") = ""
                    'leListaFiltrada = leCtaCtble.Where(Function(item) item.Cuenta = "77611").ToList
                    'If leListaFiltrada Is Nothing Then
                    '    Throw New Exception("No existe esta cuenta : 77611 ")
                    'ElseIf leListaFiltrada.Count = 0 Then
                    '    Throw New Exception("No existe esta cuenta : 77611 ")
                    'End If
                    Dim lsCtaGanancia As String = ""
                    CtaGananciaPerdida(lsCtaGanancia, True, Ejercicio)
                    rowDetalle4("IdCuentaContable") = lsCtaGanancia
                    rowDetalle4("Glosa") = "ASIENTO DE GANANCIA POR APERTURA DE " & UCase(lsTipo) & " EN MONEDA: " & MonedaGlosa
                    rowDetalle4("DebeMN") = 0
                    rowDetalle4("HaberMN") = lnGanancia
                    rowDetalle4("DebeME") = 0
                    rowDetalle4("HaberME") = 0
                    rowDetalle4("IdUsuarioCrea") = IdUsuarioCreacion
                    rowDetalle4("FechaCreacion") = Date.Now
                    rowDetalle4("Activo") = True
                    rowDetalle4("NroLinea") = i + 1
                    dt_AM2.Rows.Add(rowDetalle4)
                    lsNumero = lsNumero + 1
                End If
            End If
            '------------------------------------------------------------------
            Dim odAsiento As New d_Asiento
            Return odAsiento.GuardarMasivo2(oeAsiento, dt_AM, dt_AM_MD, dt_AM_Ofin,
            oeAsiento3, dt_AM2, dt_AM_MD2, dt_AM_Ofin2, oeMovAnalisis)


        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ActualizarSaldoDoc(leMovDoc As List(Of e_MovimientoDocumento)) As Boolean Implements Il_MovimientoDocumento.ActualizarSaldoDoc
        Try
            Return odMovimientoDocumento.ActualizarSaldoDoc(leMovDoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarEstadoPago(oeMovDoc As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.ActualizarEstadopago
        Try
            Return odMovimientoDocumento.ActualizarEstadoPago(oeMovDoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function



    Public Function CrearDT() As Data.DataTable Implements Il_MovimientoDocumento.CrearDT
        Dim Documento As New Data.DataTable
        With Documento
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTipoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Serie", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Numero", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaEmision", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("FechaVencimiento", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("NoGravadas", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IGV", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("SubTotal", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Total", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Saldo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdClienteProveedor", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IndCompraVenta", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("IdPeriodo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMoneda", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoCambio", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("IdCuentaContable", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdEstadoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Operador", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("MacPCLocalCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndServicioMaterial", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("GlosaCtaxCyP", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("CuoMomentaneo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModificacion", Type.GetType("System.DateTime")))
        End With
        Return Documento
    End Function

    ''-----Modificanco código-------''

#Region "Cuentas y Variables globales"

    Private Function ObtenerVariablesGenerales(ByVal año As Integer)
        Try
            ObtenerCuentas(año)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ObtenerCuentas(ByVal año As Integer) As Boolean
        Try
            oeCuentaGenerales.Valor1 = año
            oeCuentaGenerales.Activo = True
            leCuentasGenerales.Clear()
            leCuentasGenerales.AddRange(olFuncionesGenerales.CuentasGenerales(oeCuentaGenerales))
            If leCuentasGenerales.Count = 0 Then Throw New Exception("No existen cuentas contables para el periodo")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Compras"

    Public Function EnviarCompra(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.EnviarCompra
        Try
            If oeMovimientoDocumento.IndServicioMaterial = "S" Then
                GuardarCmpServicio(oeMovimientoDocumento)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function EnviarCompraxServicio(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean
    '    Try
    '        If ValidarCompraVenta(oeMovimientoDocumento, True, gAreasSGI.Compras) Then

    '            ObtenerVariablesGenerales(oeMovimientoDocumento.Ejercicio)

    '            'Actualizo e Movimiento Documento
    '            oeMovimientoDocumento.interfazContable = True
    '            oeMovimientoDocumento.TipoOperacion = "A"
    '            oeMovimientoDocumento.EstadoDocumento = "ENVIADO"
    '            oeMovimientoDocumento.IdCuentaContable = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", leCuentasGenerales.Where(Function(i) i.Nombre = "CTACOMPRASOLES")(0).Texto2, _
    '                                                         leCuentasGenerales.Where(Function(i) i.Nombre = "CTACOMPRADOLARES")(0).Texto2)

    '            Dim oeCompra As New e_Compra
    '            Dim loCompra As New l_Compra
    '            oeCompra.IdMovimientoDocumento = oeMovimientoDocumento.Id
    '            oeCompra = loCompra.Obtener(oeCompra)
    '            oeCompra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
    '            oeCompra.TotalIGVCompra = oeMovimientoDocumento.IGV
    '            oeCompra.TotalBaseCompra = oeMovimientoDocumento.SubTotal
    '            oeMovimientoDocumento.Compra = oeCompra
    '            oeMovimientoDocumento.Compra.TipoOperacion = "A"

    '            Dim olDetalleDoc As New l_DetalleDocumento
    '            Dim oeDetalleDoc As New e_DetalleDocumento
    '            Dim leDetalleDoc As New List(Of e_DetalleDocumento)
    '            oeDetalleDoc.Activo = True
    '            oeDetalleDoc.TipoOperacion = "COM"
    '            oeDetalleDoc.IndServicioMaterial = "S"
    '            oeDetalleDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
    '            leDetalleDoc.AddRange(olDetalleDoc.Listar(oeDetalleDoc))
    '            leDetalleDoc = leDetalleDoc.OrderBy(Function(item) item.IdCuentaContableCompra).ToList
    '            If leDetalleDoc.Count = 0 Then Throw New Exception("No existen detalles en este documento")

    '            Dim odAsiento As New d_Asiento
    '            Dim NroAsientoC As String = odAsiento.UltimoNroAsiento("1CH000019", oeMovimientoDocumento.IdPeriodo, "1")
    '            Dim lsPrefijoNroAsientoC As String = Left(NroAsientoC, 2)
    '            Dim lsNumeroNroAsientoC As Integer = CInt(Right(NroAsientoC, Len(NroAsientoC) - 2))

    '            Dim oeAsiento As New e_Asiento
    '            oeAsiento.TipoOperacion = "I"
    '            oeAsiento.IdPeriodo = oeMovimientoDocumento.IdPeriodo
    '            oeAsiento.IdTipoAsiento = "COMPRAS"
    '            oeAsiento.NroAsiento = lsPrefijoNroAsientoC + CompletaConCeros(lsNumeroNroAsientoC, 7).ToString
    '            oeAsiento.Fecha = oeMovimientoDocumento.FechaEmision
    '            oeAsiento.Glosa = "COMPRA " & oeMovimientoDocumento._AbrevTipoDoc & "/" & oeMovimientoDocumento.Serie & oeMovimientoDocumento.Numero & " " & oeMovimientoDocumento._NombreClienteProveedor
    '            oeAsiento.GlosaImprime = oeAsiento.Glosa
    '            oeAsiento.IdMoneda = oeMovimientoDocumento.IdMoneda
    '            oeAsiento.TipoCambio = oeMovimientoDocumento.TipoCambio
    '            oeAsiento.TotalDebe = oeMovimientoDocumento.Total
    '            oeAsiento.TotalHaber = oeMovimientoDocumento.Total
    '            oeAsiento.IdUsuarioBloquea = ""
    '            oeAsiento.IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea
    '            oeAsiento.IdEstado = "CUADRADO"
    '            oeAsiento.IdAsientoExtorno = ""
    '            oeAsiento.FechaCreacion = Date.Now()
    '            oeAsiento.Activo = True
    '            oeAsiento.IndOrigen = oeMovimientoDocumento.IndOrigenContable
    '            oeAsiento.IdentificaAsiento = ""

    '            Dim oeAsiento_MovDoc As New e_Asiento_MovDoc
    '            oeAsiento_MovDoc.TipoOperacion = "I"
    '            oeAsiento_MovDoc.IdAsiento = ""
    '            oeAsiento_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
    '            oeAsiento_MovDoc.Activo = True
    '            oeAsiento.Asiento_MovDoc = oeAsiento_MovDoc



    '            If oeMovimientoDocumento.Tipo = "ACTIVO" Then

    '                Dim oeAsientoMovimientoAct As New e_AsientoMovimiento
    '                oeAsientoMovimientoAct.TipoOperacion = "I"
    '                oeAsientoMovimientoAct.IdAsiento = ""
    '                oeAsientoMovimientoAct.Id = ""
    '                oeAsientoMovimientoAct.IdCuentaContable = leCuentasGenerales.Where(Function(i) i.Nombre = "CTAMANTENIMIENTOACTIVO")(0).Texto2
    '                oeAsientoMovimientoAct.Glosa = oeAsiento.Glosa
    '                oeAsientoMovimientoAct.DebeMN = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", oeMovimientoDocumento.SubTotal, oeMovimientoDocumento.SubTotal * oeMovimientoDocumento.TipoCambio)
    '                oeAsientoMovimientoAct.HaberMN = 0.0
    '                oeAsientoMovimientoAct.DebeME = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", oeMovimientoDocumento.SubTotal / oeMovimientoDocumento.TipoCambio, oeMovimientoDocumento.SubTotal)
    '                oeAsientoMovimientoAct.HaberME = 0.0
    '                oeAsientoMovimientoAct.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
    '                oeAsientoMovimientoAct.FechaCreacion = Date.Now
    '                oeAsientoMovimientoAct.Activo = True

    '                Dim oeAnalisisAct As New e_MovimientoAnalisis
    '                oeAnalisisAct.TipoOperacion = "I"
    '                oeAnalisisAct.Activo = True
    '                oeAnalisisAct.IdVehiculo = Trim(leDetalleDoc(0).IdVehiculo)
    '                oeAsientoMovimientoAct.MovimientoAnalisis.Add(oeAnalisisAct)

    '                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimientoAct)

    '                oeMovimientoDocumento.Compra.IdTipoCompra = "1CH000057"

    '            Else

    '                Dim Cuenta As String = ""
    '                For Each obj In leDetalleDoc
    '                    If Trim(obj.IdCuentaContableCompra) = "" Then Throw New Exception("El servicio " + obj.NombreMaterialServicio + " no tiene cuenta asiganda.")
    '                    If Cuenta <> obj.IdCuentaContableCompra Then
    '                        Dim oeAsientoMovimientoGasto As New e_AsientoMovimiento
    '                        oeAsientoMovimientoGasto.TipoOperacion = "I"
    '                        oeAsientoMovimientoGasto.IdAsiento = ""
    '                        oeAsientoMovimientoGasto.Id = ""
    '                        oeAsientoMovimientoGasto.IdCuentaContable = obj.IdCuentaContableCompra
    '                        oeAsientoMovimientoGasto.Glosa = oeAsiento.Glosa
    '                        oeAsientoMovimientoGasto.DebeMN = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", obj.Subtotal - obj.Igv, (obj.Subtotal - obj.Igv) * oeMovimientoDocumento.TipoCambio)
    '                        oeAsientoMovimientoGasto.HaberMN = 0.0
    '                        oeAsientoMovimientoGasto.DebeME = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", (obj.Subtotal - obj.Igv) / oeMovimientoDocumento.TipoCambio, (obj.Subtotal - obj.Igv))
    '                        oeAsientoMovimientoGasto.HaberME = 0.0
    '                        oeAsientoMovimientoGasto.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
    '                        oeAsientoMovimientoGasto.FechaCreacion = Date.Now
    '                        oeAsientoMovimientoGasto.Activo = True

    '                        ''Detalle del análisis:
    '                        Dim AnalisisGasto As New e_MovimientoAnalisis
    '                        AnalisisGasto.TipoOperacion = "I"
    '                        AnalisisGasto.Id = ""
    '                        AnalisisGasto.IdAsientoMovimiento = ""
    '                        AnalisisGasto.IdGastoFuncion = "1CH000087"
    '                        AnalisisGasto.IdVehiculo = obj.IdVehiculo
    '                        AnalisisGasto.IdItemGasto = obj.IdItemGasto
    '                        AnalisisGasto.Monto = obj.Subtotal - obj.Igv
    '                        AnalisisGasto.Saldo = AnalisisGasto.Monto
    '                        oeAsientoMovimientoGasto.MovimientoAnalisis.Add(AnalisisGasto)
    '                        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimientoGasto)
    '                        Cuenta = obj.IdCuentaContableCompra
    '                        If Trim(obj.IdTipoCompra) = "" Then Throw New Exception("No existe tipo de compra para el servicio")
    '                        oeMovimientoDocumento.Compra.IdTipoCompra = obj.IdTipoCompra
    '                    End If
    '                Next

    '            End If

    '            If oeMovimientoDocumento.IGV > 0 Then
    '                Dim oeAsientoMovimientoIGV As New e_AsientoMovimiento
    '                oeAsientoMovimientoIGV.TipoOperacion = "I"
    '                oeAsientoMovimientoIGV.IdAsiento = ""
    '                oeAsientoMovimientoIGV.Id = ""
    '                oeAsientoMovimientoIGV.IdCuentaContable = leCuentasGenerales.Where(Function(i) i.Nombre = "CTAIGV")(0).Texto2
    '                oeAsientoMovimientoIGV.Glosa = oeAsiento.Glosa
    '                oeAsientoMovimientoIGV.DebeMN = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", oeMovimientoDocumento.IGV, oeMovimientoDocumento.IGV * oeMovimientoDocumento.TipoCambio)
    '                oeAsientoMovimientoIGV.HaberMN = 0.0
    '                oeAsientoMovimientoIGV.DebeME = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", oeMovimientoDocumento.IGV / oeMovimientoDocumento.TipoCambio, oeMovimientoDocumento.IGV)
    '                oeAsientoMovimientoIGV.HaberME = 0.0
    '                oeAsientoMovimientoIGV.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
    '                oeAsientoMovimientoIGV.FechaCreacion = Date.Now
    '                oeAsientoMovimientoIGV.Activo = True
    '                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimientoIGV)
    '            End If

    '            Dim oeAsientoMovimiento42 As New e_AsientoMovimiento
    '            oeAsientoMovimiento42.TipoOperacion = "I"
    '            oeAsientoMovimiento42.IdAsiento = ""
    '            oeAsientoMovimiento42.Id = ""
    '            oeAsientoMovimiento42.IdCuentaContable = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", leCuentasGenerales.Where(Function(i) i.Nombre = "CTACOMPRASOLES")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTACOMPRADOLARES")(0).Texto2)
    '            oeAsientoMovimiento42.Glosa = oeAsiento.Glosa
    '            oeAsientoMovimiento42.DebeMN = 0.0
    '            oeAsientoMovimiento42.HaberMN = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", oeMovimientoDocumento.Total, oeMovimientoDocumento.Total * oeMovimientoDocumento.TipoCambio)
    '            oeAsientoMovimiento42.DebeME = 0.0
    '            oeAsientoMovimiento42.HaberME = IIf(oeMovimientoDocumento.IdMoneda = "1CH01", oeMovimientoDocumento.Total / oeMovimientoDocumento.TipoCambio, oeMovimientoDocumento.Total)
    '            oeAsientoMovimiento42.IdUsuarioCrea = oeAsiento.IdUsuarioCrea
    '            oeAsientoMovimiento42.FechaCreacion = Date.Now
    '            oeAsientoMovimiento42.Activo = True

    '            oeAsientoMovimiento42.AsMov_MovDoc.TipoOperacion = "I"
    '            oeAsientoMovimiento42.AsMov_MovDoc.IdAsientoMovimiento = ""
    '            oeAsientoMovimiento42.AsMov_MovDoc.Id = ""
    '            oeAsientoMovimiento42.AsMov_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
    '            oeAsientoMovimiento42.AsMov_MovDoc.Activo = True

    '            oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento42)
    '            odMovimientoDocumento.EnviarCompra(oeMovimientoDocumento, oeAsiento)

    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

#End Region

#Region "Ventas"

    Public Function GuardarVentaAsiento(MovimientoDocumento As e_MovimientoDocumento,
                                  AsientoModelo As e_AsientoModelo,
                                  ServicioCuentaContable As e_ServicioCuentaContable,
                                  IndOtros As Boolean,
                                  IdCtaCtble16321 As String, Optional b_anticipo As Boolean = False) As Boolean Implements Il_MovimientoDocumento.GuardarVentaAsiento
        Try
            Dim Asiento As New e_Asiento, olAsiento As New l_Asiento, oeAsientoMov As New e_AsientoMovimiento, oeMovAnalisis As New e_MovimientoAnalisis
            Dim Asiento_MovDoc As New e_Asiento_MovDoc, olAsientoMov As New l_Asiento_MovDoc
            Dim oeAsientoMov_Anticipo As New e_AsientoMovimiento, lstAsientoMov_Anticipo As New List(Of e_AsientoMovimiento)
            Dim oeAsiento_Anticipo As e_Asiento = Nothing
            Using TransScope As New TransactionScope()
                If ValidarCompraVenta(MovimientoDocumento, False, gAreasSGI.Ventas) Then
                    With MovimientoDocumento
                        .TipoOperacion = IIf(.IndConta = True, "I", "A")
                        .EstadoDocumento = "EMITIDA"
                        If IdCtaCtble16321.Trim <> "" Then
                            MovimientoDocumento.IdCuentaContable = IdCtaCtble16321
                        Else
                            Dim _leAuxCta As New List(Of e_DetalleAsientoModelo)
                            If AsientoModelo.Nombre.Contains("NOTA CREDITO") Then
                                _leAuxCta = AsientoModelo.leDetalle.Where(Function(it) it.Partida = 2).ToList
                            Else
                                _leAuxCta = AsientoModelo.leDetalle.Where(Function(it) it.Partida = 1).ToList
                            End If
                            If _leAuxCta.Count > 0 Then MovimientoDocumento.IdCuentaContable = _leAuxCta(0).IdCuentaContable
                        End If
                        .Venta.TipoOperacion = IIf(.IndConta = True, "I", "A")
                        .Venta.TotalVenta = .SubTotal
                        .Venta.IdTipoVenta = ServicioCuentaContable.CuentaHaber ' Cuenta Haber se Carga IdTablaContableDet
                    End With
                    MovimientoDocumento = GuardarVenta2(MovimientoDocumento)
                    If MovimientoDocumento.Id <> "" Then
                        'If b_anticipo Then
                        '    Dim olIgv As New l_Impuesto
                        '    Dim oeIgv As New e_Impuesto
                        '    oeIgv = olIgv.IGV(oeMovDocumento.FechaEmision)
                        '    oeMovDocumento.SubTotal = oeMovDocumento.SubTotal + oeMovDocumento.Monto_Anticipo
                        '    oeMovDocumento.Total = oeMovDocumento.SubTotal * (1 + oeIgv.Porcentaje)
                        '    oeMovDocumento.IGV = oeMovDocumento.SubTotal * (oeIgv.Porcentaje)
                        'End If
                        Asiento_MovDoc = New e_Asiento_MovDoc
                        Asiento_MovDoc.IdMovimientoDocumento = MovimientoDocumento.Id
                        Asiento_MovDoc.Activo = 1
                        olAsientoMov = New l_Asiento_MovDoc
                        If olAsientoMov.Listar(Asiento_MovDoc).Count = 0 Then
                            With Asiento
                                .TipoOperacion = "I" : .IdPeriodo = MovimientoDocumento.IdPeriodo : .IdTipoAsiento = AsientoModelo.IdTipoAsiento
                                .PrefijoID = MovimientoDocumento.PrefijoID
                                .NroAsiento = String.Empty : .Fecha = MovimientoDocumento.FechaEmision
                                .Glosa = "VENTA " & MovimientoDocumento.Venta.TipoDoc.Abreviatura & "/" & MovimientoDocumento.Serie & MovimientoDocumento.Numero & " " & MovimientoDocumento.Venta.Cliente.Nombre
                                .GlosaImprime = "VENTA " & MovimientoDocumento.Venta.TipoDoc.Abreviatura & "/" & MovimientoDocumento.Serie & MovimientoDocumento.Numero & " " & MovimientoDocumento.Venta.Cliente.Nombre
                                .IdMoneda = AsientoModelo.IdMoneda : .TipoCambio = MovimientoDocumento.TipoCambio
                                .TotalDebe = MovimientoDocumento.Total : .TotalHaber = MovimientoDocumento.Total
                                .IdEstado = "CUADRADO" : .IdUsuarioCrea = MovimientoDocumento.IdUsuarioCrea : Asiento.Activo = True
                                ' Genera Asiento Movimiento Documento
                                .Asiento_MovDoc = New e_Asiento_MovDoc
                                .Asiento_MovDoc.TipoOperacion = "I"
                                .Asiento_MovDoc.IdMovimientoDocumento = MovimientoDocumento.Id
                                .Asiento_MovDoc.Activo = True
                                .PrefijoID = MovimientoDocumento.PrefijoID
                            End With
                            For Each oeAux In AsientoModelo.leDetalle.OrderBy(Function(it) it.Fila).ToList
                                oeAsientoMov = New e_AsientoMovimiento
                                With oeAsientoMov
                                    .TipoOperacion = "I" : .Glosa = Asiento.Glosa
                                    .PrefijoID = MovimientoDocumento.PrefijoID
                                    .IdCuentaContable = oeAux.IdCuentaContable ' 26/12 add by Cess
                                    Select Case Left(oeAux.Cuenta.Trim, 1)
                                        Case "1"
                                            .IdCuentaContable = IIf(IdCtaCtble16321 <> "", IdCtaCtble16321, oeAux.IdCuentaContable.Trim)
                                            If oeAux.Partida = 1 Then
                                                .DebeMN = IIf(AsientoModelo.Moneda = "SOLES", MovimientoDocumento.Total, (MovimientoDocumento.Total * MovimientoDocumento.TipoCambio))
                                                .DebeME = IIf(AsientoModelo.Moneda = "SOLES", (MovimientoDocumento.Total / MovimientoDocumento.TipoCambio), MovimientoDocumento.Total)
                                            Else
                                                .HaberMN = IIf(AsientoModelo.Moneda = "SOLES", MovimientoDocumento.Total, (MovimientoDocumento.Total * MovimientoDocumento.TipoCambio))
                                                .HaberME = IIf(AsientoModelo.Moneda = "SOLES", (MovimientoDocumento.Total / MovimientoDocumento.TipoCambio), MovimientoDocumento.Total)
                                            End If


                                            'Genera AsientoMoviento - Movimiento Documento
                                            oeAsientoMov.AsMov_MovDoc = New e_AsientoMov_MovDoc
                                            oeAsientoMov.AsMov_MovDoc.PrefijoID = MovimientoDocumento.PrefijoID
                                            oeAsientoMov.AsMov_MovDoc.TipoOperacion = "I"
                                            oeAsientoMov.AsMov_MovDoc.IdMovimientoDocumento = MovimientoDocumento.Id
                                            oeAsientoMov.AsMov_MovDoc.IdCuentaxCyP = String.Empty
                                            oeAsientoMov.AsMov_MovDoc.Activo = True

                                        Case "4"
                                            .IdCuentaContable = oeAux.IdCuentaContable.Trim
                                            If oeAux.Partida = 1 Then
                                                .DebeMN = IIf(AsientoModelo.Moneda = "SOLES", MovimientoDocumento.IGV, (MovimientoDocumento.IGV * MovimientoDocumento.TipoCambio))
                                                .DebeME = IIf(AsientoModelo.Moneda = "SOLES", (MovimientoDocumento.IGV / MovimientoDocumento.TipoCambio), MovimientoDocumento.IGV)
                                            Else
                                                .HaberMN = IIf(AsientoModelo.Moneda = "SOLES", MovimientoDocumento.IGV, (MovimientoDocumento.IGV * MovimientoDocumento.TipoCambio))
                                                .HaberME = IIf(AsientoModelo.Moneda = "SOLES", (MovimientoDocumento.IGV / MovimientoDocumento.TipoCambio), MovimientoDocumento.IGV)
                                            End If
                                        Case "7"
                                            ' oeServCtaCtble.IdCuentaContableHaber se carga la cuenta de clase 7
                                            .IdCuentaContable = IIf(IndOtros, ServicioCuentaContable.IdCuentaContableHaber, oeAux.IdCuentaContable)
                                            If MovimientoDocumento.IndAnticipo Then
                                                Dim oe_docas As New e_DocumentoAsociado
                                                Dim ol_docas As New l_DocumentoAsociado
                                                oe_docas.TipoOperacion = ""
                                                oe_docas.IdMovimientoDocumentoAsoc = MovimientoDocumento.Id
                                                oe_docas.Activo = 1
                                                oe_docas = ol_docas.Listar(oe_docas)(0)
                                                oeAsientoMov.AsMov_MovDoc = New e_AsientoMov_MovDoc
                                                oeAsientoMov.AsMov_MovDoc.PrefijoID = MovimientoDocumento.PrefijoID
                                                oeAsientoMov.AsMov_MovDoc.TipoOperacion = "I"
                                                oeAsientoMov.AsMov_MovDoc.IdCuentaxCyP = String.Empty
                                                oeAsientoMov.AsMov_MovDoc.Activo = True
                                                oeAsientoMov.AsMov_MovDoc.IdMovimientoDocumento = oe_docas.IdMovimientoDocumento
                                            End If
                                            If oeAux.Partida = 1 Then
                                                .DebeMN = IIf(AsientoModelo.Moneda = "SOLES", MovimientoDocumento.SubTotal, (MovimientoDocumento.SubTotal * MovimientoDocumento.TipoCambio))
                                                .DebeME = IIf(AsientoModelo.Moneda = "SOLES", (MovimientoDocumento.SubTotal / MovimientoDocumento.TipoCambio), MovimientoDocumento.SubTotal)
                                            Else
                                                .HaberMN = IIf(AsientoModelo.Moneda = "SOLES", MovimientoDocumento.SubTotal, (MovimientoDocumento.SubTotal * MovimientoDocumento.TipoCambio))
                                                .HaberME = IIf(AsientoModelo.Moneda = "SOLES", (MovimientoDocumento.SubTotal / MovimientoDocumento.TipoCambio), MovimientoDocumento.SubTotal)
                                            End If
                                            If Not IndOtros Then
                                                'Genera Movimiento Analisis por Vehiculo sin Repetir
                                                Dim idVeh As String = "", Div As Integer = 0, MontVeh As Double = 0
                                                For Each oeDetDoc In MovimientoDocumento.leDetalleDocOperDet.OrderBy(Function(it) it._IdVehiculo).ToList
                                                    If idVeh <> oeDetDoc._IdVehiculo Then
                                                        idVeh = oeDetDoc._IdVehiculo
                                                        Dim _leDetAux = MovimientoDocumento.leDetalleDocOperDet.Where(Function(it) it._IdVehiculo = idVeh).ToList
                                                        If _leDetAux.Count > 0 Then
                                                            MontVeh = _leDetAux.Sum(Function(it) it.Valor)
                                                            oeMovAnalisis = New e_MovimientoAnalisis
                                                            oeMovAnalisis.TipoOperacion = "I"
                                                            oeMovAnalisis.IdVehiculo = idVeh
                                                            oeMovAnalisis.Monto = MontVeh
                                                            oeMovAnalisis.Saldo = MontVeh
                                                            oeMovAnalisis.Activo = True
                                                            .MovimientoAnalisis.Add(oeMovAnalisis)
                                                        End If
                                                    End If
                                                Next
                                            End If

                                            If b_anticipo Then
                                                oeAsientoMov_Anticipo = New e_AsientoMovimiento
                                                With oeAsientoMov_Anticipo
                                                    .TipoOperacion = "I" : .Glosa = "APLICACIÓN DE ANTICIPO " & MovimientoDocumento.Venta.TipoDoc.Abreviatura & "/" & MovimientoDocumento.Serie & MovimientoDocumento.Numero &
                                                    " " & MovimientoDocumento.Venta.Cliente.Nombre
                                                    If oeAux.Partida = 1 Then
                                                        .DebeMN = IIf(AsientoModelo.Moneda = "SOLES", MovimientoDocumento.Monto_Anticipo, (MovimientoDocumento.Monto_Anticipo * MovimientoDocumento.TipoCambio))
                                                        .DebeME = IIf(AsientoModelo.Moneda = "SOLES", (MovimientoDocumento.Monto_Anticipo / MovimientoDocumento.TipoCambio), MovimientoDocumento.Monto_Anticipo)
                                                    Else
                                                        .HaberMN = IIf(AsientoModelo.Moneda = "SOLES", MovimientoDocumento.Monto_Anticipo, (MovimientoDocumento.Monto_Anticipo * MovimientoDocumento.TipoCambio))
                                                        .HaberME = IIf(AsientoModelo.Moneda = "SOLES", (MovimientoDocumento.Monto_Anticipo / MovimientoDocumento.TipoCambio), MovimientoDocumento.Monto_Anticipo)
                                                    End If
                                                    .IdCuentaContable = oeAsientoMov.IdCuentaContable
                                                    .IdUsuarioCrea = MovimientoDocumento.IdUsuarioCrea
                                                    .Activo = True
                                                End With
                                                lstAsientoMov_Anticipo.Add(oeAsientoMov_Anticipo)
                                            End If
                                    End Select
                                    .IdUsuarioCrea = MovimientoDocumento.IdUsuarioCrea : .Activo = True
                                    Asiento.AsientoMovimiento.Add(oeAsientoMov)
                                End With
                            Next
                            '>>GENERAR ASIENTO SI EL COMPROBANTE SERÁ AFECTADO POR UNA ANTICIPO
                            If b_anticipo Then
                                Dim monto_total As Double = (lstAsientoMov_Anticipo.Sum(Function(x) IIf(AsientoModelo.IdMoneda = "1CH01", x.HaberMN, x.HaberME)))
                                oeAsiento_Anticipo = New e_Asiento
                                With oeAsiento_Anticipo
                                    .TipoOperacion = "I" : .IdPeriodo = MovimientoDocumento.IdPeriodo : .IdTipoAsiento = "1CH000020"
                                    .NroAsiento = String.Empty : .Fecha = MovimientoDocumento.FechaEmision
                                    .Glosa = "APLICACIÓN DE ANTICIPO " & MovimientoDocumento.Venta.TipoDoc.Abreviatura & "/" & MovimientoDocumento.Serie & MovimientoDocumento.Numero &
                                        " " & MovimientoDocumento.Venta.Cliente.Nombre
                                    .GlosaImprime = "APLICACIÓN DE ANTICIPO " & MovimientoDocumento.Venta.TipoDoc.Abreviatura & "/" & MovimientoDocumento.Serie & MovimientoDocumento.Numero &
                                        " " & MovimientoDocumento.Venta.Cliente.Nombre
                                    .IdMoneda = AsientoModelo.IdMoneda : .TipoCambio = MovimientoDocumento.TipoCambio
                                    .TotalDebe = monto_total : .TotalHaber = monto_total
                                    .IdEstado = "CUADRADO" : .IdUsuarioCrea = MovimientoDocumento.IdUsuarioCrea : Asiento.Activo = True
                                End With
                                Dim oe_CtaCtble As e_CuentaContable, ol_CtaCtble As l_CuentaContable, lstCtaCtble As List(Of e_CuentaContable)
                                Dim oe_MovDocAnt As e_MovimientoDocumento, ol_MovDocAnt As l_MovimientoDocumento

                                For Each docasoc In MovimientoDocumento.DocAsoc
                                    oeAsientoMov_Anticipo = New e_AsientoMovimiento
                                    oe_MovDocAnt = New e_MovimientoDocumento
                                    oe_MovDocAnt.Id = docasoc.IdMovimientoDocumentoAsoc
                                    ol_MovDocAnt = New l_MovimientoDocumento
                                    oe_MovDocAnt = ol_MovDocAnt.Obtener(oe_MovDocAnt)
                                    oe_CtaCtble = New e_CuentaContable
                                    ol_CtaCtble = New l_CuentaContable
                                    lstCtaCtble = New List(Of e_CuentaContable)
                                    oe_CtaCtble.Cuenta = IIf(oe_MovDocAnt.Moneda = "SOLES", "12211", "12212")
                                    oe_CtaCtble.Ejercicio = Year(MovimientoDocumento.FechaEmision)
                                    oe_CtaCtble.Activo = True
                                    lstCtaCtble = ol_CtaCtble.Listar(oe_CtaCtble)
                                    If lstCtaCtble.Count = 0 Then Throw New Exception("No existe cuenta asignada para anticipos.")
                                    With oeAsientoMov_Anticipo
                                        .TipoOperacion = "I" : .Glosa = "APLICACIÓN DE ANTICIPO " & MovimientoDocumento.Venta.TipoDoc.Abreviatura & "/" & MovimientoDocumento.Serie & MovimientoDocumento.Numero &
                                        " " & MovimientoDocumento.Venta.Cliente.Nombre
                                        .DebeMN = IIf(AsientoModelo.Moneda = "SOLES", docasoc.Monto_Desc, (docasoc.Monto_Desc * MovimientoDocumento.TipoCambio))
                                        .DebeME = IIf(AsientoModelo.Moneda = "SOLES", (docasoc.Monto_Desc / MovimientoDocumento.TipoCambio), docasoc.Monto_Desc)
                                        .HaberME = 0.0
                                        .HaberMN = 0.0
                                        .IdCuentaContable = lstCtaCtble(0).Id
                                        .IdUsuarioCrea = MovimientoDocumento.IdUsuarioCrea
                                        .Activo = True
                                        .AsMov_MovDoc = New e_AsientoMov_MovDoc
                                        .AsMov_MovDoc.Activo = True
                                        .AsMov_MovDoc.IdMovimientoDocumento = docasoc.IdMovimientoDocumentoAsoc
                                        .AsMov_MovDoc.TipoOperacion = "I"
                                    End With
                                    lstAsientoMov_Anticipo.Add(oeAsientoMov_Anticipo)
                                Next
                                oeAsiento_Anticipo.AsientoMovimiento = lstAsientoMov_Anticipo
                            End If
                            '>> FIN - GENERAR ASIENTO SI EL COMPROBANTE SERÁ AFECTADO POR UNA ANTICIPO
                            If olAsiento.GuardarAsientoDscto(Asiento, oeAsiento_Anticipo) Then
                                TransScope.Complete()
                                Return True
                            End If
                        Else
                            MsgBox("El Documento Nº " & MovimientoDocumento.Serie & " - " & MovimientoDocumento.Numero & " tiene un asiento registrado." & vbCrLf &
                                   "Comunicar a Sistemas el mensaje de alerta.", MsgBoxStyle.Information, "EMISIÓN DE VENTAS")
                            Return False
                        End If
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarVenta2(oeMovDocumento As e_MovimientoDocumento) As e_MovimientoDocumento Implements Il_MovimientoDocumento.GuardarVenta2
        Try
            oeMovDocumento = odMovimientoDocumento.GuardarVenta2(oeMovDocumento)
            Return oeMovDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Glosas,Verificacions y Cambios de Periodo"

    Public Function VerificarDocumento(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As Boolean Implements Il_MovimientoDocumento.VerificarDocumento
        Try
            Return odMovimientoDocumento.CambiaPeriodoVerifica(oeMovimientoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

#Region "Validaciones"

    Public Function ValidarCompraVenta(ByVal oeMovimientoDocumento As e_MovimientoDocumento, _
    Optional ByVal indCompra As Boolean = False, Optional ByVal Modulo As gAreasSGI = gAreasSGI.Contabilidad) As Boolean Implements Il_MovimientoDocumento.ValidarCompraVenta
        Try
            With oeMovimientoDocumento
                Dim olFuncionesGenerales As New l_FuncionesGenerales
                olFuncionesGenerales.ValidarDocumentoDuplicado(oeMovimientoDocumento)
                olFuncionesGenerales.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, Modulo, IIf(indCompra, Date.Parse("01/01/1901"), oeMovimientoDocumento.FechaEmision), "")
                If oeMovimientoDocumento.TipoOperacion = "A" Then
                    Dim MovDoc As New List(Of e_MovimientoDocumento)
                    MovDoc.Add(oeMovimientoDocumento)
                    olFuncionesGenerales.ValidarDatosDeDctoExistente(MovDoc, True)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

    Public Function AperturaDetalle(oeMovimientoDocumento As e_MovimientoDocumento) As DataTable Implements Il_MovimientoDocumento.AperturaDetalle
        Try
            Return odMovimientoDocumento.AperturaDetalle(oeMovimientoDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function DatosImpresionElectronico(oeMovimientoDocumento As e_MovimientoDocumento) As DataSet
        Return odMovimientoDocumento.DatosImpresionElectronico(oeMovimientoDocumento)
    End Function

    Function FacturacionPendiente() As DataTable
        Return odMovimientoDocumento.FacturacionPendiente()
    End Function

    Function SincronizarFacturado() As Boolean
        Return odMovimientoDocumento.SincronizarFacturado()
    End Function

    Function ListaFacturacionElectronica(oeMovDocumento As e_MovimientoDocumento) As DataSet
        Return odMovimientoDocumento.ListarFacturacionElectronica(oeMovDocumento)
    End Function

    Function GenerarXmlFacturaElectronica(dataTable As DataTable, dataTable1 As DataTable, p3 As String, p4 As Object) As Boolean
        'Return sFacturacionElectronica.GenerarXmlFacturaElectronica(dataTable, dataTable1, p3, p4)
        Return sFacturacionElectronica.GenerarXmlFacturaElectronica(dataTable, Nothing, dataTable1, p3, p4)
    End Function

    Function GenerarXmlComprobantesBaja(dataTable As DataTable, ByVal fechaGeneracion As DateTime, ByVal rutaFE As String, ByVal usuario As String, ByVal PrefijoID As String) As String
        Return sFacturacionElectronica.GenerarXmlComprobantesBaja(dataTable, fechaGeneracion, rutaFE, usuario, PrefijoID)
    End Function

    Function EnviarXMLGetStatus(ByVal rutaFE As String, ByVal ticket As String, ByVal PrefijoID As String) As String
        Return sFacturacionElectronica.EnviarXMLGetStatus(rutaFE, ticket, PrefijoID)
    End Function

    Function ObtenerEnviarData(oeDocumento As e_MovimientoDocumento) As DataSet '*** Implements Il_Documento.ListaFacturacionElectronica
        Return odMovimientoDocumento.ListarFacturacionElectronica(oeDocumento)
    End Function

    Function EnviarPortalSunat(oeDocumento As e_MovimientoDocumento) As String '*** Implements Il_Documento.GenerarXmlFacturaElectronica
        Dim clienteRemotoObj As New com.grupoinduamerica.ReferenciaServicioFactura
        Dim dsRecibido As New DataSet
        Dim dsEnvio As New DataSet
        Dim dtCab As New DataTable
        Dim dtDet As New DataTable
        Dim dtFac As New DataTable
        Dim resultado As String
        dsEnvio.DataSetName = "DATASETX"
        Dim key As String = "@s)##689***45%$%||"
        dsRecibido = odMovimientoDocumento.ListarFacturacionElectronica(oeDocumento)

        dtCab = dsRecibido.Tables(0)
        dtCab.TableName = "documento"
        'dsRecibido.Tables(1).Rows(0).Item("producto")  = Replace(dsRecibido.Tables(1).Rows(0).Item("producto"), Char(10), "\n")
        dtDet = dsRecibido.Tables(1)
        dtDet.TableName = "detalle_documento"
        dtFac = dsRecibido.Tables(2)
        dtFac.TableName = "vefacturaelectronica"

        dsEnvio.Tables.Add(dtCab.Copy)
        dsEnvio.Tables.Add(dtDet.Copy)
        dsEnvio.Tables.Add(dtFac.Copy)
        System.Net.ServicePointManager.Expect100Continue = False
        System.Net.ServicePointManager.MaxServicePointIdleTime = 0
        Dim jss As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim jsonEnvio As String = jss.Serialize(dsEnvio.GetXml())
        resultado = clienteRemotoObj.enviardata("I", jsonEnvio, "", "", key)
        Return resultado
    End Function

    'RESUMEN DIARIO BOLETAS 2018
    Function GenerarXmlFacturaElectronicaBath_2018(dataTable As DataTable, DT As DataTable, ByVal fechaGeneracion As DateTime, ByVal rutaFE As String, ByVal usuario As String, b_Baja As Boolean, ByVal PrefijoID As String) As String
        Return sFacturacionElectronica.GenerarXmlComprobantesBath_2018(dataTable, DT, fechaGeneracion, rutaFE, usuario, b_Baja, PrefijoID)
    End Function

    Function GenerarXmlFacturaElectronica_Resumen(dataTable As DataTable, dataTable1 As DataTable, dataTable2 As DataTable, p3 As String, p4 As String) As Boolean
        Return sFacturacionElectronica.GenerarXmlFacturaElectronica_Resumen(dataTable, dataTable1, dataTable2, p3, p4)
    End Function
    'FACTURAS POR ANTICIPOS
    Public Function Listar_Anticipos(ByVal oeMovimientoDocumento As e_MovimientoDocumento) As DataTable Implements Il_MovimientoDocumento.Listar_Anticipos
        Try
            Return odMovimientoDocumento.Listar_Anticipos(oeMovimientoDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    'CONSULTAR DOCUMENTO
    Function ConsultarDocumento(dsComprobante As DataSet, ByVal rutaFE As String, ByVal usuario As String) As String
        Return sFacturacionElectronica.ConsultarDocumento(dsComprobante, rutaFE, usuario)
    End Function
End Class