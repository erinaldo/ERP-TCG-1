Imports System.Data.OleDb
Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_FuncionesGenerales
    Implements Il_FuncionesGenerales

    Public Function CuentasGenerales(ByVal oeTablaCtbleDet As EntidadesWCF.e_TablaContableDet) As System.Collections.Generic.List(Of EntidadesWCF.e_TablaContableDet) Implements Il_FuncionesGenerales.CuentasGenerales
        Try
            Dim leTablaCtbleDet As New List(Of e_TablaContableDet)
            Dim odTablaCtbleDet As New d_TablaContableDet
            oeTablaCtbleDet.TipoOperacion = "N"
            oeTablaCtbleDet.Activo = True
            oeTablaCtbleDet.Nombre = "CUENTAS GENERALES"
            leTablaCtbleDet.AddRange(odTablaCtbleDet.Listar(oeTablaCtbleDet))
            Return leTablaCtbleDet
        Catch ex As Exception
            Throw New Exception(ex.Message + ": Cuentas Generales")
        End Try
    End Function

    Public Function l_GeneraID(ByVal C_Base As EntidadesWCF.e_Base) As String Implements Il_FuncionesGenerales.l_GeneraID
        Dim ObjId As New d_Datos
        Return ObjId.d_GeneraId(C_Base)
    End Function

    Public Function ValidarCampoNoNulo(ByVal campo As String, ByVal mensaje As String) As Boolean Implements Il_FuncionesGenerales.ValidarCampoNoNulo
        Try
            If String.IsNullOrEmpty(Trim(campo)) Then Throw New Exception(mensaje)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarSerieNumCeros(ByVal campo As String, ByVal mensaje As String) As Boolean Implements Il_FuncionesGenerales.ValidarSerieNumCeros
        Try
            If CInt(campo) = 0 Then Throw New Exception(mensaje)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDatosDeDctoExistente(ByVal ListaValida As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoDocumento), _
    Optional ByVal IndValSaldo As Boolean = False) As Boolean Implements Il_FuncionesGenerales.ValidarDatosDeDctoExistente
        Try
            For Each obj As e_MovimientoDocumento In ListaValida
                Dim oeMD As New e_MovimientoDocumento
                oeMD.Activo = True
                oeMD.Id = obj.Id
                Dim olMD As New l_MovimientoDocumento
                oeMD = olMD.Obtener(oeMD)

                Dim oe_DocRetDet As New e_DocumentoRetencionDetalle
                Dim aux As New e_DocumentoRetencionDetalle
                Dim ol_DocRetDet As New l_DocumentoRetencionDetalle
                Dim lst_DocRetDet As New List(Of e_DocumentoRetencionDetalle)
                oe_DocRetDet.RetencionOrigen = obj.MontoOperar
                oe_DocRetDet.IdMovimientoDocumento = oeMD.Id
                oe_DocRetDet.IdDocumentoRetencion = ""
                oe_DocRetDet.TipoOperacion = ""
                oe_DocRetDet.Activo = 1
                lst_DocRetDet = ol_DocRetDet.Listar(oe_DocRetDet)
                If lst_DocRetDet.Count > 0 Then
                    aux = lst_DocRetDet.Item(0)
                    If aux.IdDocumentoRetencion.Trim Is String.Empty Then
                        If (Math.Round(Math.Abs(aux.RetencionOrigen), 2) <> Math.Round(Math.Abs(oe_DocRetDet.RetencionOrigen), 2)) Then
                            Throw New Exception("El saldo es diferente al importe, no se puede operar")
                        End If
                    Else
                        If IndValSaldo Then
                            If (Math.Round(Math.Abs(obj.Saldo), 2) <> Math.Round(Math.Abs(obj.Total), 2)) Then
                                Throw New Exception("El saldo es diferente al importe, no se puede operar")
                            End If
                        Else
                            'If Math.Round(Math.Abs(oeMD.Saldo), 2) <> Math.Round(Math.Abs(obj.Saldo), 2) Then
                            '    Throw New Exception("Los saldos ya cambiaron el saldo del Documento" & oeMD.Serie & oeMD.Numero & " debe ser: " & oeMD.Saldo.ToString)
                            'End If
                        End If
                        If Math.Round(Math.Abs(oeMD.Saldo), 2) < Math.Round(Math.Abs(obj.MontoOperar), 2) Then
                            Throw New Exception("El monto a operar es mayor al saldo")
                        End If
                    End If
                Else
                    If IndValSaldo Then
                        If (Math.Round(Math.Abs(obj.Saldo), 2) <> Math.Round(Math.Abs(obj.Total), 2)) Then
                            Throw New Exception("El saldo es diferente al importe, no se puede operar")
                        End If
                    Else
                        If Math.Round(Math.Abs(oeMD.Saldo), 2) <> Math.Round(Math.Abs(obj.Saldo), 2) Then
                            Throw New Exception("Los saldos ya cambiaron el saldo del Documento" & oeMD.Serie & oeMD.Numero & " debe ser: " & oeMD.Saldo.ToString)
                        End If
                    End If
                    If Math.Round(Math.Abs(oeMD.Saldo), 2) < Math.Round(Math.Abs(obj.MontoOperar), 2) Then
                        Throw New Exception("El monto a operar es mayor al saldo")
                    End If
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDatosDeObligacionExistente(ByVal ListaValida As System.Collections.Generic.List(Of EntidadesWCF.e_ObligacionFinanciera), Optional ByVal IndValSaldo As Boolean = False) As Boolean Implements Il_FuncionesGenerales.ValidarDatosDeObligacionExistente
        Try
            For Each obj As e_ObligacionFinanciera In ListaValida
                Dim oeMD As New e_ObligacionFinanciera
                oeMD.Activo = True
                oeMD.Id = obj.Id
                Dim olMD As New l_ObligacionFinanciera
                oeMD = olMD.Obtener(oeMD)

                If IndValSaldo Then
                    If (Math.Abs(obj.Saldo) <> Math.Abs(IIf(obj.IdMoneda = "1CH01", obj.MontoMN, obj.MontoME))) Then
                        Throw New Exception("El saldo es diferente al importe, no se puede operar")
                    End If
                End If
                If (Math.Abs(oeMD.Saldo) < Math.Abs(obj.MontoOperar)) Then
                    Throw New Exception("El monto a operar es mayor al saldo")
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidarDocumentoDuplicado(ByVal oeMovimientoDocumento As EntidadesWCF.e_MovimientoDocumento, Optional ByVal Venta As Boolean = False) As Boolean Implements Il_FuncionesGenerales.ValidarDocumentoDuplicado
        Dim odMovDoc As New d_MovimientoDocumento
        Dim oeMovDoc As New e_MovimientoDocumento
        Dim indicador As Integer = 0
        oeMovDoc.TipoOperacion = "VAL"
        oeMovDoc.Serie = oeMovimientoDocumento.Serie
        oeMovDoc.Numero = oeMovimientoDocumento.Numero
        oeMovDoc.IdTipoDocumento = oeMovimientoDocumento.IdTipoDocumento
        oeMovDoc.IndCompraVenta = oeMovimientoDocumento.IndCompraVenta
        If Integer.TryParse(oeMovDoc.Serie, indicador) Then
            If Integer.Parse(oeMovDoc.Serie) = 0 Then
                Throw New Exception("Serie documento incorrecta.")
            End If
        End If
        If Integer.TryParse(oeMovDoc.Numero, indicador) Then
            If Integer.Parse(oeMovDoc.Numero) = 0 Then
                Throw New Exception("Numero documento incorrecta.")
            End If
        End If
        If oeMovDoc.IdTipoDocumento = "1CH000000073" Then
            oeMovDoc.IndCompraVenta = 0
            oeMovDoc._Operador = 1
        End If
        If Not Venta Then
            oeMovDoc.IdClienteProveedor = oeMovimientoDocumento.IdClienteProveedor
        End If
        Try
            Dim leMovDoc As New List(Of e_MovimientoDocumento)
            leMovDoc.AddRange(odMovDoc.Listar(oeMovDoc))

            If oeMovimientoDocumento.Id = "" Then 'inserta
                If leMovDoc.Count > 0 Then '  existe con el mismo nombre, no puede insertar,  error
                    Throw New Exception("Este Documento ya existe: " & leMovDoc(0)._AbrevTipoDoc & "/" & leMovDoc(0).Serie & leMovDoc(0).Numero & "/ " & leMovDoc(0)._NombreClienteProveedor _
                                        & "/ " & leMovDoc(0).IdUsuarioCrea)
                End If
            Else 'aqctualiza
                If leMovDoc.Count > 0 AndAlso leMovDoc(0).Id <> oeMovimientoDocumento.Id Then ' existe con el mismo nombre y diferente id,  error
                    Throw New Exception("Este Documento ya existe: " & leMovDoc(0)._AbrevTipoDoc & "/" & leMovDoc(0).Serie & leMovDoc(0).Numero & "/ " & leMovDoc(0)._NombreClienteProveedor)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarNumero(ByVal numero As Integer, ByVal mensaje As String) As Boolean Implements Il_FuncionesGenerales.ValidarNumero
        Try
            If numero = 0 Then Throw New Exception(mensaje)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarNumeroDecimal(ByVal numero As Decimal, ByVal mensaje As String) As Boolean Implements Il_FuncionesGenerales.ValidarNumeroDecimal
        Try
            If numero = 0 Then Throw New Exception(mensaje)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarPeriodo(ByVal IdPeriodo As String, ByVal _Modulo As gAreasSGI) As Boolean Implements Il_FuncionesGenerales.ValidarPeriodo
        Try
            If IdPeriodo Is Nothing Then Throw New Exception("No existe el Periodo")
            Dim oePeriodo As New e_Periodo
            Dim lePeriodo As New List(Of e_Periodo)
            Dim olPeriodo As New l_Periodo
            oePeriodo.Activo = True
            oePeriodo.Id = IdPeriodo
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            If lePeriodo.Count > 0 Then

                If _Modulo = gAreasSGI.Tesoreria And lePeriodo(0).CierreTesoreria = True Then
                    Throw New Exception("Tesorería esta cerrado")
                    Return False
                ElseIf _Modulo = gAreasSGI.Compras And lePeriodo(0).CierreCompras = True Then
                    Throw New Exception("Compras esta cerrado")
                    Return False
                ElseIf _Modulo = gAreasSGI.Ventas And lePeriodo(0).CierraVentas = True Then
                    Throw New Exception("Ventas esta cerrado")
                    Return False
                ElseIf _Modulo = gAreasSGI.Almacen And lePeriodo(0).CierreAlmacen = True Then
                    Throw New Exception("Almacén esta cerrado")
                    Return False
                ElseIf _Modulo = gAreasSGI.Contabilidad And lePeriodo(0).CierreContabilidad = True Then
                    Throw New Exception("Contabilidad esta cerrado")
                    Return False
                End If
            Else
                Throw New Exception("No existe Periodo")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarPeriodo(ByVal IdPeriodo As String, ByVal Modulo As gAreasSGI, ByVal _Fecha As Date, ByVal Codigo As String, _
    Optional ByVal MesPosterior As Integer = 0, Optional ByVal OemovDoc As EntidadesWCF.e_MovimientoDocumento = Nothing) As Boolean Implements Il_FuncionesGenerales.ValidarPeriodo
        Try
            Dim oePeriodo As New e_Periodo
            Dim lePeriodo As New List(Of e_Periodo)
            Dim olPeriodo As New l_Periodo
            Dim lsMensaje As String = ""
            oePeriodo.Activo = True
            oePeriodo.Id = IdPeriodo
            oePeriodo.Codigo = Codigo
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            If Not OemovDoc Is Nothing Then
                lsMensaje = OemovDoc.Serie + OemovDoc.Numero
            End If

            'Texto para convertir el enumerado en string
            'Modulo.ToString()
            'Dim enumerado As String = CType(Modulo, gAreasSGI).ToString("G")

            If lePeriodo.Count > 0 Then
                If Modulo = gAreasSGI.Tesoreria And lePeriodo(0).CierreTesoreria Then
                    Throw New Exception("El Periodo Contable " & _Fecha.Month & "/" & _Fecha.Year & " de Tesoreria se encuentra cerrado." & _
                                        Environment.NewLine & "Para guardar la información en proceso consulte con el Jefe de Contabilidad.")
                    Return False
                ElseIf Modulo = gAreasSGI.Compras And lePeriodo(0).CierreCompras Then
                    Throw New Exception("El Periodo Contable " & lePeriodo(0).Mes & "/" & lePeriodo(0).Ejercicio & " de Compras se encuentra cerrado." & _
                                         Environment.NewLine & "Para guardar la información en proceso consulte con el Jefe de Contabilidad.")
                    Return False
                ElseIf Modulo = gAreasSGI.Ventas And lePeriodo(0).CierraVentas Then
                    Throw New Exception("El Periodo Contable " & lePeriodo(0).Mes & "/" & lePeriodo(0).Ejercicio & " de Ventas se encuentra cerrado." & _
                                        Environment.NewLine & "Para guardar la información en proceso consulte con el Jefe de Contabilidad.")
                    Return False
                ElseIf Modulo = gAreasSGI.Almacen And lePeriodo(0).CierreAlmacen Then
                    Throw New Exception("Almacen esta cerrado")
                    Return False
                ElseIf Modulo = gAreasSGI.Contabilidad And lePeriodo(0).CierreContabilidad Then
                    Throw New Exception("El Periodo Contable " & _Fecha.Month & "/" & _Fecha.Year & " de Contabilidad se encuentra cerrado." & _
                                        Environment.NewLine & "Para guardar la información en proceso consulte con el Jefe de Contabilidad.")
                    Return False
                ElseIf Modulo = gAreasSGI.Planilla And lePeriodo(0).CierrePlanilla Then
                    Throw New Exception("El Periodo Contable " & _Fecha.Month & "/" & _Fecha.Year & " de Planilla se encuentra cerrado." & _
                                        Environment.NewLine & "Para guardar la información en proceso consulte con el Jefe de Contabilidad.")
                    Return False
                End If
                If _Fecha <> Date.Parse("01/01/1901") Then
                    If Not (_Fecha.Date >= lePeriodo(0).FechaInicio.Date And _Fecha.Date <= lePeriodo(0).FechaFin.Date) Then
                        Throw New Exception("La fecha no pertenece al periodo: " & lsMensaje)
                    End If
                End If
                If MesPosterior > 0 Then
                    If MesPosterior > lePeriodo(0).FechaFin.Date.Month Then
                        Throw New Exception("La fecha es posterior al Periodo: " & lsMensaje)
                    End If
                End If
            Else
                Throw New Exception("No existe Periodo:" & Codigo)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function UltimoDiaMes(ByVal Fecha As Date) As Date Implements Il_FuncionesGenerales.UltimoDiaMes
        Return DateAdd("d", -1, DateAdd("m", 1, DateSerial(Year(Fecha), Month(Fecha), 1)))
    End Function

    Public Function UltimaFechaVentas() As Date Implements Il_FuncionesGenerales.UltimaFechaVentas
        Try
            Dim fechalimite As New l_Disponibilidad
            Return fechalimite.FechaLimite(gAreasSGI.Ventas)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimaFechaCompras() As Date Implements Il_FuncionesGenerales.UltimaFechaCompras
        Try
            Dim fechalimite As New l_Disponibilidad
            Return fechalimite.FechaLimite(gAreasSGI.Compras)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimaFechaAdministracion() As Date Implements Il_FuncionesGenerales.UltimaFechaAdministracion
        Try
            Dim fechalimite As New l_Disponibilidad
            Return fechalimite.FechaLimite(gAreasSGI.Administracion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimaFechaNeu() As Date Implements Il_FuncionesGenerales.UltimaFechaNeu
        Try
            Dim fechalimite As New l_Disponibilidad
            Return fechalimite.FechaLimite(gAreasSGI.Neumaticos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFechaNeu(Tipo As String, Fecha As Date, FechaServidor As Date) As Boolean Implements Il_FuncionesGenerales.ValidarFechaNeu
        Try
            Dim FecCierre As Date, Mensaje As String = ""
            Select Case Tipo
                Case "Mov_Baja_Neu"
                    FecCierre = UltimaFechaNeu()
                    If FecCierre < FechaServidor Then
                        If FecCierre >= Fecha.Date Then
                            Mensaje = "No puede dar de Baja al Neumatico." & Environment.NewLine _
                                & "El Area de Neumaticos tiene como limite los " & FecCierre.Day & " dias de cada mes." & Environment.NewLine _
                                & "Infome a su Jefe Inmediato para realizar esta Operación."
                        End If
                    End If
            End Select
            If Mensaje <> "" Then Throw New Exception(Mensaje)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimaFechaContabilidad() As Date Implements Il_FuncionesGenerales.UltimaFechaContabilidad
        Try
            Dim fechalimite As New l_Disponibilidad
            Return fechalimite.FechaLimite(gAreasSGI.Contabilidad)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFechaCierre(Tipo As String, Fecha As Date, FechaServidor As Date) As Boolean Implements Il_FuncionesGenerales.ValidarFechaCierreOperaciones
        Try
            Dim FechaCierre As Date
            Dim Permisos As String = ""

            If Tipo <> "Editar Carga" Then
                FechaCierre = UltimaFechaVentas()
                If FechaCierre < FechaServidor Then
                    If FechaServidor.AddDays(-FechaCierre.Day) > Fecha Then
                        Permisos = "Error"
                    End If
                Else
                    If FechaServidor.AddDays(-FechaCierre.Day) > Fecha Then
                        Permisos = "Error"
                    End If
                End If
            Else
                FechaCierre = UltimaFechaAdministracion()
                If FechaCierre < FechaServidor Then
                    If FechaCierre.AddDays(-FechaCierre.Day) >= Fecha Then
                        Permisos = "Error"
                    End If
                Else
                    If FechaCierre.AddDays(-FechaCierre.Day) >= Fecha Then
                        Permisos = "Error"
                    End If
                End If
                FechaCierre = UltimaFechaVentas()
            End If

            If Permisos <> "" Then
                Throw New Exception("No tiene permisos para realizar la operacion de " & Tipo & "." & Environment.NewLine & _
                                    "Operaciones cierra todos los meses sus transacciones." & Environment.NewLine & _
                                    "Con dia limite: " & FechaCierre.Day & " de cada mes. Registro cerrado." & Environment.NewLine & _
                                    "Informe a su Jefe de Area para realizar su operacion")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimaFechaPerfil(Perfil As String) As Integer Implements Il_FuncionesGenerales.UltimaFechaPerfil
        Try
            Dim fechalimite As New l_Disponibilidad
            Return fechalimite.FechaLimitePerfil(Perfil)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFechaPerfil(Tipo As String, Fecha As Date, FechaServidor As Date) As Boolean Implements Il_FuncionesGenerales.ValidarFechaPerfil
        Try
            Dim NroDias As Integer = 0
            Dim Permisos As String = ""

            NroDias = UltimaFechaPerfil(Tipo)
            If Fecha < FechaServidor.AddDays(-NroDias) Then
                Permisos = "Error"
            End If
            If Permisos <> "" Then
                Throw New Exception("La Autorizacion seleccionada no cumple con los dias." & Environment.NewLine & _
                                    "Para permitir actualizar fecha, seleccione otro Jefe de Area" & Environment.NewLine & _
                                    "Solo se puede retroceder: " & NroDias & " dias de la fecha actual." & Environment.NewLine & _
                                    "Informe a su Jefe de Area para realizar su operacion")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String Implements Il_FuncionesGenerales.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function l_ObtenerFechaServidor() As Date Implements Il_FuncionesGenerales.l_ObtenerFechaServidor
        Try
            Dim olUsuario As New l_Usuario
            Dim oeUsuario As New e_Usuario
            oeUsuario.TipoOperacion = "W"
            oeUsuario = olUsuario.ObtieneFechaServidor(oeUsuario)
            Return oeUsuario.oePersona.FechaNacimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargaIGV(FechaActual As Date) As Double Implements Il_FuncionesGenerales.CargaIGV
        Try
            Dim oeIGVGlobal As New e_Impuesto
            Dim olIGV As New l_Impuesto
            oeIGVGlobal = olIGV.IGV(FechaActual)
            Return oeIGVGlobal.Porcentaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerCUOAsiento(NroAsiento As String, IdTipoAsiento As String) As String Implements Il_FuncionesGenerales.ObtenerCUOAsiento
        Dim CuoAsiento As String = ""
        Try
            Dim TipoAsiento As String = ""
            Select Case IdTipoAsiento
                Case "1CH000015" : TipoAsiento = "AP"
                Case "1CH000016" : TipoAsiento = "BC"
                Case "1CH000017" : TipoAsiento = "CJ"
                Case "1CH000018" : TipoAsiento = "CI"
                Case "1CH000019" : TipoAsiento = "CO"
                Case "1CH000020" : TipoAsiento = "DI"
                Case "1CH000021" : TipoAsiento = "FF"
                Case "1CH000022" : TipoAsiento = "HO"
                Case "1CH000023" : TipoAsiento = "PL"
                Case "1CH000024" : TipoAsiento = "VE"
                Case "1CH000025" : TipoAsiento = "RI"
            End Select
            CuoAsiento = NroAsiento.Substring(0, 2) + TipoAsiento + CompletaConCeros(CInt(NroAsiento.Substring(2, 7)), 8)
        Catch ex As Exception
            Throw ex
        End Try
        Return CuoAsiento
    End Function

    Public Function gfc_ObtenerFechaAsiento(ByVal ld_FechaDocumento As Date, ByVal ld_FechaFinPeriodo As Date) As Date
        Dim ld_FechaAsiento As Date = #1/1/1901#
        Dim fecServidor As Date = l_ObtenerFechaServidor().Date
        Dim fecDoc As Date = ld_FechaDocumento.Date
        Dim fecPeriodo As Date = ld_FechaFinPeriodo.Date
        ld_FechaAsiento = ld_FechaDocumento.Date
        If fecPeriodo <> "01/01/1901" Then
            If fecServidor > fecPeriodo Then
                If fecDoc > fecPeriodo Then
                    Throw New Exception("El Fecha del Comprobante de Pago esta fuera del Periodo")
                Else
                    ld_FechaAsiento = fecDoc
                End If
            Else
                ld_FechaAsiento = fecServidor
            End If
        End If
        Return ld_FechaAsiento
    End Function

End Class
