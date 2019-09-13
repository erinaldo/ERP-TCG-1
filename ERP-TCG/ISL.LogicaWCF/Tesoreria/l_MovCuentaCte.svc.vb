Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_MovCuentaCte
    Implements Il_MovCuentaCte

    Dim odMovCuentaCte As New d_MovCuentaCte
    Dim l_FuncionesGenerales As New l_FuncionesGenerales
    Private odMovCtaAsiento As New d_MovCuentaCte_Asiento, olMovCtaAsiento As New l_MovCuentaCte_Asiento
    Private odMovimientoDoc As New d_MovimientoDocumento, olMovimientoDoc As New l_MovimientoDocumento
    Private odCompra As New d_Compra, olCompra As New l_Compra
    Private odAsiento As New d_Asiento, olAsiento As New l_Asiento
    Private odAsientoMovDoc As New d_Asiento_MovDoc, olAsientoMovDoc As New l_Asiento_MovDoc
    Private odAsiMovMovDoc As New d_AsientoMov_MovDoc, olAsiMovMovDoc As New l_AsientoMov_MovDoc
    Private odMovAnalisis As New d_MovimientoAnalisis, olMovAnalisis As New l_MovimientoAnalisis
    Private odAsientoMov As New d_AsientoMovimiento, olAsientoMov As New l_AsientoMovimiento
    Private odSaldoCtaCte As New d_SaldoCtaCorriente

    Public Function Eliminar(ByVal oeMovCuentaCte As EntidadesWCF.e_MovCuentaCte) As Boolean Implements Il_MovCuentaCte.Eliminar
        Try
            Return odMovCuentaCte.Eliminar(oeMovCuentaCte)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovCuentaCte As EntidadesWCF.e_MovCuentaCte) As Boolean Implements Il_MovCuentaCte.Guardar
        Try
            If Validar(oeMovCuentaCte) Then
                Return odMovCuentaCte.Guardar(oeMovCuentaCte)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovCuentaCte As EntidadesWCF.e_MovCuentaCte) As System.Collections.Generic.List(Of EntidadesWCF.e_MovCuentaCte) Implements Il_MovCuentaCte.Listar
        Try
            Return odMovCuentaCte.Listar(oeMovCuentaCte)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMovCuentaCte As EntidadesWCF.e_MovCuentaCte) As EntidadesWCF.e_MovCuentaCte Implements Il_MovCuentaCte.Obtener
        Try
            Return odMovCuentaCte.Obtener(oeMovCuentaCte)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMovCuentaCte As EntidadesWCF.e_MovCuentaCte) As Boolean Implements Il_MovCuentaCte.Validar
        Try
            With oeMovCuentaCte
                If .TipoReferencia = "0" Then
                    l_FuncionesGenerales.ValidarCampoNoNulo(.oeTransferencia.IdBanco, "¡Ingrese Cuenta Bancaria!")
                    l_FuncionesGenerales.ValidarCampoNoNulo(.oeTransferencia.Numero, "¡Ingrese Número Operación!")
                Else
                    l_FuncionesGenerales.ValidarCampoNoNulo(.oeMovimientoDoc.IdTipoDocumento, "¡Ingrese Tipo Documento!")
                    If .Referencia <> "VALE" And .Referencia <> "SUSTENTO CONTABLE" Then
                        l_FuncionesGenerales.ValidarCampoNoNulo(.oeMovimientoDoc.Serie, "¡Ingrese Serie!")
                        If CInt(.oeMovimientoDoc.Numero) < 1 Then Throw New Exception("¡Ingrese Numero!")
                        l_FuncionesGenerales.ValidarCampoNoNulo(.oeMovimientoDoc.Numero, "¡Ingrese Numero!")
                        l_FuncionesGenerales.ValidarCampoNoNulo(.oeMovimientoDoc.IdClienteProveedor, "¡Ingrese Proveedor!")
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLista(ByVal leMovCuentaCte As System.Collections.Generic.List(Of EntidadesWCF.e_MovCuentaCte)) As Boolean Implements Il_MovCuentaCte.GuardarLista
        Try
            Dim oeTCD As e_TablaContableDet
            Dim oeTCD16 As e_TablaContableDet
            Dim oeTipoCompra As New e_TablaContableDet, olTipoCompra As New l_TablaContableDet
            Dim leTipoCompra As New List(Of e_TablaContableDet)
            Dim oeCuentaGenerales As New e_TablaContableDet
            Dim leCuentasGenerales As New List(Of e_TablaContableDet)
            Dim ListaFiltro As New List(Of e_TablaContableDet)
            Dim olFuncionesGenerales As New l_FuncionesGenerales
            Dim odMovimientoDocumento As New d_MovimientoDocumento

            For Each oeMovCtaCte As e_MovCuentaCte In leMovCuentaCte
                With oeMovCtaCte
                    If .TipoOperacion = "I" Then
                        'If .TipoOperacion <> "G" AndAlso .TipoOperacion <> "L" Then
                        '------------------Cuentas Generales---------------
                        If leCuentasGenerales.Count = 0 Then
                            oeCuentaGenerales.Valor1 = IIf(.oeMovimientoDoc.Ejercicio = 0, Year(.Fecha), .oeMovimientoDoc.Ejercicio)
                            leCuentasGenerales.AddRange(olFuncionesGenerales.CuentasGenerales(oeCuentaGenerales))
                        End If
                        '-------------------------------------------------------

                        If .TipoReferencia = "1" Then ' Solo Documentos

                            If .oeMovimientoDoc.IdTipoDocumento = "1CH000000073" Then 'Sustento contable
                                .oeAsiento = New e_Asiento
                                If Date.Now.Year > .oeMovimientoDoc.Ejercicio Then
                                    .oeAsiento.Fecha = Date.Parse("31/12/" & .oeMovimientoDoc.Ejercicio)
                                Else
                                    .oeAsiento.Fecha = Date.Now
                                End If
                                .oeAsiento.IdUsuarioCrea = .UsuarioCreacion
                                .oeAsiento.Activo = True
                                .oeAsiento.TipoOperacion = "I"
                                .oeAsiento.IdPeriodo = .oeMovimientoDoc.IdPeriodo
                                .oeAsiento.IdTipoAsiento = "DIARIO" 'Tipo de asiento Compra
                                .oeAsiento.Glosa = "DOC. SUSTENTO " & .oeMovimientoDoc.Compra.TipoDoc.Abreviatura & "/" & _
                                .oeMovimientoDoc.Serie & "-" & .oeMovimientoDoc.Numero & " " & .oeMovimientoDoc.Compra.Proveedor.Nombre + " " _
                                + .oeMovimientoDoc.FechaEmision.Date.Day.ToString + "/" + _
                                .oeMovimientoDoc.FechaEmision.Date.Month.ToString + "/" + .oeMovimientoDoc.FechaEmision.Date.Year.ToString + _
                                " " + .Glosa + " V,G:" + .oeMovimientoDoc.GlosaViajeGrupo
                                .oeAsiento.GlosaImprime = "DOC. SUSTENTO " & .oeMovimientoDoc.Compra.TipoDoc.Abreviatura & "/" & _
                                .oeMovimientoDoc.Serie & "-" & .oeMovimientoDoc.Numero & " " & .oeMovimientoDoc.Compra.Proveedor.Nombre + " " _
                                + .oeMovimientoDoc.FechaEmision.Date.Day.ToString + "/" + _
                                .oeMovimientoDoc.FechaEmision.Date.Month.ToString + "/" + .oeMovimientoDoc.FechaEmision.Date.Year.ToString
                                .oeAsiento.IdMoneda = .oeMovimientoDoc.IdMoneda
                                .oeAsiento.TipoCambio = .oeMovimientoDoc.TipoCambio
                                .oeAsiento.TotalDebe = .oeMovimientoDoc.Total
                                .oeAsiento.TotalHaber = .oeMovimientoDoc.Total
                                .oeAsiento.IdUsuarioBloquea = ""
                                .oeAsiento.IdEstado = "CUADRADO" 'Estado Cuadrado
                                .oeAsiento.IdAsientoExtorno = ""

                                Dim oeAsientoMovimientoSustCont As New e_AsientoMovimiento
                                Dim oeMovimientoAnalisis As New e_MovimientoAnalisis
                                oeAsientoMovimientoSustCont.TipoOperacion = "I"
                                oeAsientoMovimientoSustCont.IdAsiento = ""
                                oeAsientoMovimientoSustCont.IdUsuarioCrea = .UsuarioCreacion
                                oeAsientoMovimientoSustCont.Glosa = .oeAsiento.Glosa
                                oeAsientoMovimientoSustCont.Activo = True
                                oeAsientoMovimientoSustCont.TipoOperacion = "I"
                                oeAsientoMovimientoSustCont.IdCuentaContable = .oeMovimientoDoc.MovimientoAnalisis(0).IdCuentaContable
                                oeAsientoMovimientoSustCont.DebeMN = .oeMovimientoDoc.Total
                                oeAsientoMovimientoSustCont.HaberMN = 0
                                oeAsientoMovimientoSustCont.DebeME = .oeMovimientoDoc.Total / .oeMovimientoDoc.TipoCambio
                                oeAsientoMovimientoSustCont.HaberME = 0
                                oeAsientoMovimientoSustCont.MovimientoAnalisis = .oeMovimientoDoc.MovimientoAnalisis
                                .oeAsiento.AsientoMovimiento.Add(oeAsientoMovimientoSustCont)
                                ''------------------------------------------------------------------------
                                ''-----------------------cuenta 10----------------------------------------
                                oeAsientoMovimientoSustCont = New e_AsientoMovimiento
                                ListaFiltro = leCuentasGenerales.ToList
                                oeTCD = ListaFiltro.Where(Function(it) it.Nombre = "CTA14").ToList(0)
                                oeAsientoMovimientoSustCont.TipoOperacion = "I"
                                oeAsientoMovimientoSustCont.IdAsiento = ""
                                oeAsientoMovimientoSustCont.IdUsuarioCrea = .UsuarioCreacion
                                oeAsientoMovimientoSustCont.Glosa = .oeAsiento.Glosa
                                oeAsientoMovimientoSustCont.Activo = True
                                oeAsientoMovimientoSustCont.TipoOperacion = "I"
                                oeAsientoMovimientoSustCont.IdCuentaContable = oeTCD.Texto2
                                oeAsientoMovimientoSustCont.DebeMN = 0
                                oeAsientoMovimientoSustCont.HaberMN = .oeMovimientoDoc.Total
                                oeAsientoMovimientoSustCont.DebeME = 0
                                oeAsientoMovimientoSustCont.HaberME = .oeMovimientoDoc.Total / .oeMovimientoDoc.TipoCambio
                                .oeAsiento.AsientoMovimiento.Add(oeAsientoMovimientoSustCont)
                                ''------------------------------------------------------------------------

                            ElseIf .oeMovimientoDoc.IdTipoDocumento <> "1CH000000062" Then 'diferente a Vale de Caja
                                If .oeMovimientoDoc.TipoOperacion = "A" Then
                                    .oeMovimientoDoc.TipoOperacion = "CAM"
                                    '.oeMovimientoDoc.Total = .Total
                                    .oeMovimientoDoc.PagoAutomatico = New e_PagoAutomatico
                                    With .oeMovimientoDoc
                                        .PagoAutomatico.IdPeriodo = .IdPeriodo
                                        .PagoAutomatico.Glosa = "PAGO " & .Compra.TipoDoc.Abreviatura & "/" & .Serie & .Numero & " " & .Compra.Proveedor.Nombre
                                        .PagoAutomatico.GlosaGrupo = .GlosaViajeGrupo
                                        .PagoAutomatico.IdMoneda = .IdMoneda
                                        .PagoAutomatico.TipoCambio = .TipoCambio
                                        .PagoAutomatico.Total = .Total
                                        .PagoAutomatico.UsuarioCreacion = .IdUsuarioCrea
                                        .PagoAutomatico.IdFLujo = oeMovCtaCte.IdFlujoCaja
                                        .PagoAutomatico.MacPCLocalCreacion = .Mac_PC_Local
                                        .PagoAutomatico.Fecha = .FechaEmision

                                        ListaFiltro = leCuentasGenerales.ToList
                                        oeTCD = ListaFiltro.Where(Function(it) it.Nombre = "CTA14").ToList(0)
                                        .PagoAutomatico.Cuenta10 = oeTCD.Texto2
                                        .PagoAutomatico.Cuenta42 = .IdCuentaContable
                                    End With

                                Else
                                    .oeMovimientoDoc.IdAsientoMovimiento = ""
                                    .oeMovimientoDoc.TipoOperacion = "I"
                                    '.oeMovimientoDoc.FechaEmision = .FechaEmision
                                    '.oeMovimientoDoc.FechaVencimiento = .FechaVencimiento
                                    '.oeMovimientoDoc.IdClienteProveedor = .IdProveedor
                                    '.oeMovimientoDoc.IdPeriodo = .IdPeriodo
                                    '.oeMovimientoDoc.IdTipoDocumento = .IdTipoDocumento
                                    '.oeMovimientoDoc.Serie = .SerieDoc
                                    '.oeMovimientoDoc.Numero = .NroDoc
                                    '.oeMovimientoDoc.IdMoneda = .IdMoneda
                                    '.oeMovimientoDoc.TipoCambio = .TipoCambio
                                    .oeMovimientoDoc.IndCompraVenta = "1"
                                    .oeMovimientoDoc.EstadoDocumento = "ENVIADO"
                                    .oeMovimientoDoc.IdUsuarioCrea = .UsuarioCreacion
                                    .oeMovimientoDoc.Mac_PC_Local = .Mac
                                    .oeMovimientoDoc._Operador = 1

                                    .oeMovimientoDoc.Compra.TipoOperacion = "I"
                                    ''-----------valida una ves asignado datos de oeMovmiento---------
                                    olFuncionesGenerales.ValidarDocumentoDuplicado(.oeMovimientoDoc)
                                    olFuncionesGenerales.ValidarPeriodo(.oeMovimientoDoc.IdPeriodo, gAreasSGI.Tesoreria, Date.Parse("01/01/1901"), "", _
                                    .oeMovimientoDoc.FechaEmision.Month, .oeMovimientoDoc)
                                    If .oeMovimientoDoc.Compra.TipoCompra.Id.ToString.Trim = "" Then Throw New Exception("Flujo de Caja sin Tipo de Compra Asociado")
                                    '-----------------------------------------------------------------
                                    Dim leTD As New List(Of e_TablaContableDet)
                                    If leTipoCompra.Count = 0 Then
                                        '-----------traigo todos los tipo de compra---------------------
                                        leTipoCompra = New List(Of e_TablaContableDet)
                                        oeTipoCompra.TipoOperacion = "N"
                                        oeTipoCompra.Nombre = "TIPO DE COMPRA" 'Tipo de COMPRA
                                        oeTipoCompra.Valor1 = .oeMovimientoDoc.Ejercicio
                                        oeTipoCompra.Activo = True
                                        leTipoCompra = olTipoCompra.Listar(oeTipoCompra)
                                        '----------------------------------------------------------------
                                    End If
                                    leTD = leTipoCompra.ToList
                                    leTD = leTD.Where(Function(it) it.Id = .oeMovimientoDoc.Compra.TipoCompra.Id).ToList
                                    .oeMovimientoDoc.Compra.IdTipoCompra = .oeMovimientoDoc.Compra.TipoCompra.Id
                                    .oeMovimientoDoc.Compra.TipoCompra = leTD(0)
                                    .oeMovimientoDoc.Compra.IdTipoPago = "1CH000000004" '---CONTADO
                                    .oeAsiento = New e_Asiento
                                    If Date.Now.Year > .oeMovimientoDoc.Ejercicio Then
                                        .oeAsiento.Fecha = Date.Parse("31/12/" & .oeMovimientoDoc.Ejercicio)
                                    Else
                                        .oeAsiento.Fecha = Date.Now
                                    End If

                                    .oeAsiento.IdUsuarioCrea = .UsuarioCreacion
                                    .oeAsiento.Activo = True
                                    .oeAsiento.TipoOperacion = "I"
                                    .oeAsiento.IdPeriodo = .oeMovimientoDoc.IdPeriodo
                                    .oeAsiento.IdTipoAsiento = "COMPRAS" 'Tipo de asiento Compra
                                    .oeAsiento.Glosa = "COMPRA " & .oeMovimientoDoc.Compra.TipoDoc.Abreviatura & "/" & .oeMovimientoDoc.Serie & .oeMovimientoDoc.Numero & " " & .oeMovimientoDoc.Compra.Proveedor.Nombre + " V,G:" + .oeMovimientoDoc.GlosaViajeGrupo
                                    .oeAsiento.GlosaImprime = "COMPRA " & .oeMovimientoDoc.Compra.TipoDoc.Abreviatura & "/" & .oeMovimientoDoc.Serie & .oeMovimientoDoc.Numero & " " & .oeMovimientoDoc.Compra.Proveedor.Nombre
                                    .oeAsiento.IdMoneda = .oeMovimientoDoc.IdMoneda
                                    .oeAsiento.TipoCambio = .oeMovimientoDoc.TipoCambio
                                    .oeAsiento.TotalDebe = .oeMovimientoDoc.Total
                                    .oeAsiento.TotalHaber = .oeMovimientoDoc.Total
                                    .oeAsiento.IdUsuarioBloquea = ""
                                    .oeAsiento.IdEstado = "CUADRADO" 'Estado Cuadrado
                                    .oeAsiento.IdAsientoExtorno = ""
                                    .oeMovimientoDoc.PagoAutomatico = New e_PagoAutomatico
                                    With .oeMovimientoDoc
                                        .PagoAutomatico.IdPeriodo = .IdPeriodo
                                        .PagoAutomatico.Glosa = "PAGO " & .Compra.TipoDoc.Abreviatura & "/" & .Serie & .Numero & " " & .Compra.Proveedor.Nombre
                                        .PagoAutomatico.GlosaGrupo = .GlosaViajeGrupo
                                        .PagoAutomatico.IdMoneda = .IdMoneda
                                        .PagoAutomatico.TipoCambio = .TipoCambio
                                        .PagoAutomatico.Total = .Total
                                        .PagoAutomatico.UsuarioCreacion = .IdUsuarioCrea
                                        .PagoAutomatico.IdFLujo = oeMovCtaCte.IdFlujoCaja
                                        .PagoAutomatico.MacPCLocalCreacion = .Mac_PC_Local
                                        .PagoAutomatico.Fecha = .FechaEmision

                                        ListaFiltro = leCuentasGenerales.ToList
                                        oeTCD = ListaFiltro.Where(Function(it) it.Nombre = "CTA14").ToList(0)
                                        .PagoAutomatico.Cuenta10 = oeTCD.Texto2
                                    End With

                                    Dim olMovDoc As New l_MovimientoDocumento
                                    '------------------ linea(42)----------------------------
                                    Dim oeMovimientoAsiento42 As New e_AsientoMovimiento
                                    ListaFiltro = leCuentasGenerales.ToList
                                    oeMovimientoAsiento42 = olMovDoc.Linea42(.oeMovimientoDoc, .oeAsiento, ListaFiltro)
                                    '-----------------------------------------------'
                                    '--------------Lineas Impuestos--------------------
                                    Dim ListaImpuesto As New List(Of e_AsientoMovimiento)
                                    ListaFiltro = leCuentasGenerales.ToList
                                    ListaImpuesto = olMovDoc.LineaImpuestosCompras(.oeMovimientoDoc, .oeAsiento, ListaFiltro)
                                    '-----------------------------------------------
                                    '------------------ linea(60)----------------------------
                                    Dim oeMovimientoAsiento60 As New List(Of e_AsientoMovimiento)
                                    oeMovimientoAsiento60 = olMovDoc.Linea60(.oeMovimientoDoc, .oeAsiento, False)
                                    '-----------------------------------------------'
                                    '------------------LineasDestino(20)-----------------------------
                                    Dim oeMovimientoAsientoDestino As New List(Of e_AsientoMovimiento)
                                    If .oeMovimientoDoc.Compra.TipoCompra.Texto2 <> "" Then 'existe destino
                                        oeMovimientoAsientoDestino = olMovDoc.LineasDestinoCompras(.oeMovimientoDoc, .oeAsiento)
                                    End If
                                    '---------------------------------------------------------------
                                    If .oeMovimientoDoc.Compra.TipoDoc.Codigo <> "07" Then
                                        .oeAsiento.AsientoMovimiento.AddRange(oeMovimientoAsiento60)
                                        If ListaImpuesto.Count > 0 Then
                                            .oeAsiento.AsientoMovimiento.AddRange(ListaImpuesto)
                                        End If
                                        .oeAsiento.AsientoMovimiento.Add(oeMovimientoAsiento42)
                                    Else
                                        .oeAsiento.AsientoMovimiento.Add(oeMovimientoAsiento42)
                                        If ListaImpuesto.Count > 0 Then
                                            .oeAsiento.AsientoMovimiento.AddRange(ListaImpuesto)
                                        End If
                                        .oeAsiento.AsientoMovimiento.AddRange(oeMovimientoAsiento60)
                                    End If
                                End If
                            End If

                            If .oeMovimientoDoc.IdTipoDocumento = "1CH000000062" Then 'Vale de caja
                                .oeAsiento = New e_Asiento
                                If Date.Now.Year > .oeMovimientoDoc.Ejercicio Then
                                    .oeAsiento.Fecha = Date.Parse("31/12/" & .oeMovimientoDoc.Ejercicio)
                                Else
                                    .oeAsiento.Fecha = Date.Now
                                End If
                                .oeAsiento.IdUsuarioCrea = .UsuarioCreacion
                                .oeAsiento.Activo = True
                                .oeAsiento.TipoOperacion = "I"
                                .oeAsiento.IdPeriodo = .oeMovimientoDoc.IdPeriodo
                                .oeAsiento.IdTipoAsiento = "DIARIO" 'Tipo de asiento Compra
                                .oeAsiento.Glosa = "ASIENTO DE DOCS A RENDIR DE " & .Trabajador
                                .oeAsiento.GlosaImprime = "ASIENTO DE DOCS A RENDIR DE " & .Trabajador
                                .oeAsiento.IdMoneda = .oeMovimientoDoc.IdMoneda
                                .oeAsiento.TipoCambio = .oeMovimientoDoc.TipoCambio
                                .oeAsiento.TotalDebe = .oeMovimientoDoc.Total
                                .oeAsiento.TotalHaber = .oeMovimientoDoc.Total
                                .oeAsiento.IdUsuarioBloquea = ""
                                .oeAsiento.IdEstado = "CUADRADO" 'Estado Cuadrado
                                .oeAsiento.IdAsientoExtorno = ""
                                ''----------------------cuenta 10----------------------------------------
                                Dim oeAsientoMovimiento As New e_AsientoMovimiento
                                Dim oeMovimientoAnalisis As New e_MovimientoAnalisis
                                ListaFiltro = leCuentasGenerales.ToList
                                oeTCD16 = ListaFiltro.Where(Function(it) it.Nombre = "CTA10").ToList(0)
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdAsiento = ""
                                oeAsientoMovimiento.IdUsuarioCrea = .UsuarioCreacion
                                oeAsientoMovimiento.Glosa = .oeAsiento.GlosaImprime
                                oeAsientoMovimiento.Activo = True
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdCuentaContable = oeTCD16.Texto2
                                oeAsientoMovimiento.DebeMN = .oeMovimientoDoc.Total
                                oeAsientoMovimiento.HaberMN = 0
                                oeAsientoMovimiento.DebeME = .oeMovimientoDoc.Total / .oeMovimientoDoc.TipoCambio
                                oeAsientoMovimiento.HaberME = 0
                                With oeAsientoMovimiento.MovimientoCajaBanco
                                    .TipoOperacion = "I"
                                    ._Operador = -1
                                    .IdFlujoCaja = oeMovCtaCte.IdFlujoCaja
                                    .TotalMN = oeMovCtaCte.Importe
                                    .TotalME = oeMovCtaCte.Importe / oeMovCtaCte.oeMovimientoDoc.TipoCambio
                                    .TipoCambio = oeMovCtaCte.oeMovimientoDoc.TipoCambio
                                    .Fecha = oeMovCtaCte.Fecha
                                    .IdMedioPago = "1CH03" 'efectivo
                                End With
                                'oeAsientoMovimiento.MovimientoAnalisis = .oeMovimientoDoc.MovimientoAnalisis
                                .oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                                ''------------------------------------------------------------------------
                                ''-----------------------cuenta 14----------------------------------------
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                ListaFiltro = leCuentasGenerales.ToList
                                oeTCD = ListaFiltro.Where(Function(it) it.Nombre = "CTA14").ToList(0)
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdAsiento = ""
                                oeAsientoMovimiento.IdUsuarioCrea = .UsuarioCreacion
                                oeAsientoMovimiento.Glosa = .oeAsiento.GlosaImprime
                                oeAsientoMovimiento.Activo = True
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdCuentaContable = oeTCD.Texto2
                                oeAsientoMovimiento.DebeMN = 0
                                oeAsientoMovimiento.HaberMN = .oeMovimientoDoc.Total
                                oeAsientoMovimiento.DebeME = 0
                                oeAsientoMovimiento.HaberME = .oeMovimientoDoc.Total / .oeMovimientoDoc.TipoCambio
                                Dim oeMovAnalis As New e_MovimientoAnalisis
                                oeMovAnalis.TipoOperacion = "I"
                                oeMovAnalis.IdTrabajador = .IdTrabajador
                                oeMovAnalis.Monto = .oeMovimientoDoc.Total
                                oeMovAnalis.Saldo = 0
                                oeAsientoMovimiento.DivideAnalisis = False
                                oeAsientoMovimiento.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                                oeAsientoMovimiento.MovimientoAnalisis.Add(oeMovAnalis)
                                .oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                                .oeMovCuentaCte_Asiento = New e_MovCuentaCte_Asiento
                                With .oeMovCuentaCte_Asiento
                                    .TipoOperacion = "I"
                                End With
                                ''------------------------------------------------------------------------
                            End If
                        Else 'transferencias
                            If .IngresoEgreso = 0 Then 'ingreso a la cta a rendir
                                .oeAsiento = New e_Asiento
                                If Date.Now.Year > .oeTransferencia.oePeriodo.Ejercicio Then
                                    .oeAsiento.Fecha = Date.Parse("31/12/" & .oeMovimientoDoc.Ejercicio)
                                Else
                                    .oeAsiento.Fecha = Date.Now
                                End If
                                .oeAsiento.IdUsuarioCrea = .UsuarioCreacion
                                .oeAsiento.Activo = True
                                .oeAsiento.TipoOperacion = "I"
                                .oeAsiento.Fecha = oeMovCtaCte.oeTransferencia.Fecha
                                .oeAsiento.IdPeriodo = .oeTransferencia.oePeriodo.Id
                                .oeAsiento.IdTipoAsiento = "BANCO" 'Tipo de asiento Compra
                                .oeAsiento.Glosa = "TRANSFERENCIA A RENDIR DE " & .Trabajador
                                .oeAsiento.GlosaImprime = "TRANSFERENCIA A RENDIR DE " & .Trabajador
                                .oeAsiento.IdMoneda = .oeTransferencia.IdMoneda
                                .oeAsiento.TipoCambio = .oeTransferencia.TipoCambio
                                .oeAsiento.TotalDebe = .oeTransferencia.Monto
                                .oeAsiento.TotalHaber = .oeTransferencia.Monto
                                .oeAsiento.IdUsuarioBloquea = ""
                                .oeAsiento.IdEstado = "CUADRADO" 'Estado Cuadrado
                                .oeAsiento.IdAsientoExtorno = ""
                                ''----------------------cuenta 14----------------------------------------
                                Dim oeAsientoMovimiento As New e_AsientoMovimiento
                                Dim oeMovimientoAnalisis As New e_MovimientoAnalisis
                                ListaFiltro = leCuentasGenerales.ToList
                                oeTCD16 = ListaFiltro.Where(Function(it) it.Nombre = "CTA14").ToList(0)
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdAsiento = ""
                                oeAsientoMovimiento.IdUsuarioCrea = .UsuarioCreacion
                                oeAsientoMovimiento.Glosa = .oeAsiento.GlosaImprime
                                oeAsientoMovimiento.Activo = True
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdCuentaContable = oeTCD16.Texto2
                                oeAsientoMovimiento.DebeMN = IIf(.oeTransferencia.IdMoneda = "1CH01", _
                                .oeTransferencia.Monto, .oeTransferencia.Monto * .oeTransferencia.TipoCambio)
                                oeAsientoMovimiento.HaberMN = 0
                                oeAsientoMovimiento.DebeME = IIf(.oeTransferencia.IdMoneda = "1CH01", _
                                .oeTransferencia.Monto / .oeTransferencia.TipoCambio, .oeTransferencia.Monto)
                                oeAsientoMovimiento.HaberME = 0
                                Dim oeMovAnalis As New e_MovimientoAnalisis
                                oeMovAnalis.TipoOperacion = "I"
                                oeMovAnalis.IdTrabajador = .IdTrabajador
                                oeMovAnalis.Monto = .oeTransferencia.Monto
                                oeMovAnalis.Saldo = 0
                                oeAsientoMovimiento.DivideAnalisis = False
                                oeAsientoMovimiento.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                                oeAsientoMovimiento.MovimientoAnalisis.Add(oeMovAnalis)
                                .oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                                ''------------------------------------------------------------------------
                                ''-----------------------cuenta 10----------------------------------------
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                'ListaFiltro = leCuentasGenerales.ToList
                                'oeTCD = ListaFiltro.Where(Function(it) it.Nombre = "CTAFONDOFIJOSOLES").ToList(0)
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdAsiento = .oeTransferencia.oeCtaBancaria.IdCuentaContable
                                oeAsientoMovimiento.IdUsuarioCrea = .UsuarioCreacion
                                oeAsientoMovimiento.Glosa = .oeAsiento.GlosaImprime
                                oeAsientoMovimiento.Activo = True
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdCuentaContable = .oeTransferencia.oeCtaBancaria.IdCuentaContable
                                oeAsientoMovimiento.DebeMN = 0
                                oeAsientoMovimiento.HaberMN = IIf(.oeTransferencia.IdMoneda = "1CH01", _
                                .oeTransferencia.Monto, .oeTransferencia.Monto * .oeTransferencia.TipoCambio)
                                oeAsientoMovimiento.DebeME = 0
                                oeAsientoMovimiento.HaberME = IIf(.oeTransferencia.IdMoneda = "1CH01", _
                                .oeTransferencia.Monto / .oeTransferencia.TipoCambio, .oeTransferencia.Monto)
                                oeAsientoMovimiento.MovimientoCajaBanco = New e_MovimientoCajaBanco
                                With oeAsientoMovimiento.MovimientoCajaBanco
                                    .TipoOperacion = "I"
                                    ._Operador = -1
                                    .NroBoucher = oeMovCtaCte.oeTransferencia.Numero
                                    .Fecha = oeMovCtaCte.oeTransferencia.Fecha
                                    .IdCuentaBancaria = oeMovCtaCte.oeTransferencia.oeCtaBancaria.Id
                                    .IdMedioPago = "1CH02" 'DEPOSITO EN CUENTA
                                    .IdFlujoCaja = "1CH000000208" 'otros
                                    .TipoCambio = oeMovCtaCte.oeTransferencia.TipoCambio
                                    .TotalMN = IIf(oeMovCtaCte.oeTransferencia.IdMoneda = "1CH01", _
                                    oeMovCtaCte.oeTransferencia.Monto, oeMovCtaCte.oeTransferencia.Monto * oeMovCtaCte.oeTransferencia.TipoCambio)
                                    .TotalME = IIf(oeMovCtaCte.oeTransferencia.IdMoneda = "1CH01", _
                                    oeMovCtaCte.oeTransferencia.Monto / oeMovCtaCte.oeTransferencia.TipoCambio, oeMovCtaCte.oeTransferencia.Monto)
                                End With
                                .oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                                .oeMovCuentaCte_Asiento = New e_MovCuentaCte_Asiento
                                With .oeMovCuentaCte_Asiento
                                    .TipoOperacion = "I"
                                End With
                                ''------------------------------------------------------------------------
                            ElseIf .IngresoEgreso = 1 Then 'Egreso de la cta a rendir
                                .oeAsiento = New e_Asiento
                                If Date.Now.Year > .oeTransferencia.oePeriodo.Ejercicio Then
                                    .oeAsiento.Fecha = Date.Parse("31/12/" & .oeMovimientoDoc.Ejercicio)
                                Else
                                    .oeAsiento.Fecha = Date.Now
                                End If
                                .oeAsiento.IdUsuarioCrea = .UsuarioCreacion
                                .oeAsiento.Activo = True
                                .oeAsiento.TipoOperacion = "I"
                                .oeAsiento.IdPeriodo = .oeTransferencia.oePeriodo.Id
                                .oeAsiento.IdTipoAsiento = "BANCO" 'Tipo de asiento Compra
                                .oeAsiento.Glosa = "TRANSFERENCIA DEVOLUCION DE CTA POR RENDIR DE " & .Trabajador
                                .oeAsiento.GlosaImprime = "TRANSFERENCIA DEVOLUCION DE CTA POR RENDIR DE " & .Trabajador
                                .oeAsiento.IdMoneda = .oeTransferencia.IdMoneda
                                .oeAsiento.TipoCambio = .oeTransferencia.TipoCambio
                                .oeAsiento.TotalDebe = .oeTransferencia.Monto
                                .oeAsiento.TotalHaber = .oeTransferencia.Monto
                                .oeAsiento.IdUsuarioBloquea = ""
                                .oeAsiento.IdEstado = "CUADRADO" 'Estado Cuadrado
                                .oeAsiento.IdAsientoExtorno = ""
                                Dim oeAsientoMovimiento As New e_AsientoMovimiento
                                Dim oeMovimientoAnalisis As New e_MovimientoAnalisis
                                ''-----------------------cuenta 10----------------------------------------
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                'ListaFiltro = leCuentasGenerales.ToList
                                'oeTCD = ListaFiltro.Where(Function(it) it.Nombre = "CTAFONDOFIJOSOLES").ToList(0)
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdAsiento = .oeTransferencia.oeCtaBancaria.IdCuentaContable
                                oeAsientoMovimiento.IdUsuarioCrea = .UsuarioCreacion
                                oeAsientoMovimiento.Glosa = .oeAsiento.GlosaImprime
                                oeAsientoMovimiento.Activo = True
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdCuentaContable = .oeTransferencia.oeCtaBancaria.IdCuentaContable
                                oeAsientoMovimiento.HaberMN = 0
                                oeAsientoMovimiento.DebeMN = IIf(.oeTransferencia.IdMoneda = "1CH01", _
                                .oeTransferencia.Monto, .oeTransferencia.Monto * .oeTransferencia.TipoCambio)
                                oeAsientoMovimiento.HaberME = 0
                                oeAsientoMovimiento.DebeME = IIf(.oeTransferencia.IdMoneda = "1CH01", _
                                .oeTransferencia.Monto / .oeTransferencia.TipoCambio, .oeTransferencia.Monto)
                                oeAsientoMovimiento.MovimientoCajaBanco = New e_MovimientoCajaBanco
                                With oeAsientoMovimiento.MovimientoCajaBanco
                                    .TipoOperacion = "I"
                                    ._Operador = 1
                                    .NroBoucher = oeMovCtaCte.oeTransferencia.Numero
                                    .Fecha = oeMovCtaCte.oeTransferencia.Fecha
                                    .IdCuentaBancaria = oeMovCtaCte.oeTransferencia.oeCtaBancaria.Id
                                    .IdMedioPago = "1CH02" 'DEPOSITO EN CUENTA
                                    .IdFlujoCaja = "1CH000000208" 'otros
                                    .TipoCambio = oeMovCtaCte.oeTransferencia.TipoCambio
                                    .TotalMN = IIf(oeMovCtaCte.oeTransferencia.IdMoneda = "1CH01", _
                                    oeMovCtaCte.oeTransferencia.Monto, oeMovCtaCte.oeTransferencia.Monto * oeMovCtaCte.oeTransferencia.TipoCambio)
                                    .TotalME = IIf(oeMovCtaCte.oeTransferencia.IdMoneda = "1CH01", _
                                    oeMovCtaCte.oeTransferencia.Monto / oeMovCtaCte.oeTransferencia.TipoCambio, oeMovCtaCte.oeTransferencia.Monto)
                                End With
                                .oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                                ''----------------------cuenta 14----------------------------------------
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                ListaFiltro = leCuentasGenerales.ToList
                                oeTCD16 = ListaFiltro.Where(Function(it) it.Nombre = "CTA14").ToList(0)
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdAsiento = ""
                                oeAsientoMovimiento.IdUsuarioCrea = .UsuarioCreacion
                                oeAsientoMovimiento.Glosa = .oeAsiento.GlosaImprime
                                oeAsientoMovimiento.Activo = True
                                oeAsientoMovimiento.TipoOperacion = "I"
                                oeAsientoMovimiento.IdCuentaContable = oeTCD16.Texto2
                                oeAsientoMovimiento.HaberMN = IIf(.oeTransferencia.IdMoneda = "1CH01", _
                                .oeTransferencia.Monto, .oeTransferencia.Monto * .oeTransferencia.TipoCambio)
                                oeAsientoMovimiento.DebeMN = 0
                                oeAsientoMovimiento.HaberME = IIf(.oeTransferencia.IdMoneda = "1CH01", _
                                .oeTransferencia.Monto / .oeTransferencia.TipoCambio, .oeTransferencia.Monto)
                                oeAsientoMovimiento.DebeME = 0
                                Dim oeMovAnalis As New e_MovimientoAnalisis
                                oeMovAnalis.TipoOperacion = "I"
                                oeMovAnalis.IdTrabajador = .IdTrabajador
                                oeMovAnalis.Monto = .oeTransferencia.Monto
                                oeMovAnalis.Saldo = 0
                                oeAsientoMovimiento.DivideAnalisis = False
                                oeAsientoMovimiento.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                                oeAsientoMovimiento.MovimientoAnalisis.Add(oeMovAnalis)
                                .oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                                ''------------------------------------------------------------------------
                                .oeMovCuentaCte_Asiento = New e_MovCuentaCte_Asiento
                                With .oeMovCuentaCte_Asiento
                                    .TipoOperacion = "I"
                                End With
                            End If


                        End If
                        'End If
                    ElseIf .TipoOperacion = "E" Then
                        If .IngresoEgreso = 0 Or .IngresoEgreso = 1 Then
                            Dim olMovCtaCteAsiento As New l_MovCuentaCte_Asiento
                            Dim oeMovCtaCteAsiento As New e_MovCuentaCte_Asiento
                            oeMovCtaCteAsiento.IdMovCuentaCte = .Id
                            oeMovCtaCteAsiento = olMovCtaCteAsiento.Obtener(oeMovCtaCteAsiento)
                            .oeAsiento.Id = oeMovCtaCteAsiento.IdAsiento
                        End If
                    End If
                End With
            Next
            odMovCuentaCte.GuardarLista(leMovCuentaCte)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLista2(leMovCuentaCte As List(Of e_MovCuentaCte), leAsientoModel As List(Of e_AsientoModelo), ByVal PrefijoID As String) As Boolean Implements Il_MovCuentaCte.GuardarLista2
        Try
            Using TransScope As New TransactionScope()
                Dim oeAsiento As New e_Asiento, olAsiento As New l_Asiento, oeAsientoMov As New e_AsientoMovimiento, oeMovAnalisis As New e_MovimientoAnalisis
                Dim _leAMAux = leAsientoModel.Where(Function(it) it.IndVinculado).ToList
                Dim _BandMasivo As Boolean = False
                If _leAMAux.Count > 0 Then
                    If l_FuncionesGenerales.ValidarPeriodo(_leAMAux(0).IdPeriodo, gAreasSGI.Compras) Then
                        For Each oeMovCtaCte In leMovCuentaCte
                            If oeMovCtaCte.TipoReferencia = 1 And oeMovCtaCte.TipoOperacion = "I" Then
                                _BandMasivo = True
                                oeAsiento = New e_Asiento
                                With oeAsiento
                                    .TipoOperacion = "I" : .IdPeriodo = _leAMAux(0).IdPeriodo : .IdTipoAsiento = _leAMAux(0).IdTipoAsiento
                                    .NroAsiento = String.Empty : .Fecha = _leAMAux(0).FechaMov
                                    .Glosa = "COMPRA " & oeMovCtaCte.oeMovimientoDoc.Compra.TipoDoc.Abreviatura & "/" & oeMovCtaCte.oeMovimientoDoc.Serie &
                                        oeMovCtaCte.oeMovimientoDoc.Numero & " " & oeMovCtaCte.oeMovimientoDoc.Compra.Proveedor.Nombre
                                    .IdMoneda = oeMovCtaCte.oeMovimientoDoc.IdMoneda : .TipoCambio = _leAMAux(0).TipoCambio
                                    .TotalDebe = oeMovCtaCte.oeMovimientoDoc.Total : .TotalHaber = oeMovCtaCte.oeMovimientoDoc.Total
                                    .IdEstado = "CUADRADO" : .IdUsuarioCrea = _leAMAux(0).UsuarioCreacion : oeAsiento.Activo = True
                                    ' Genera Asiento Movimiento Documento
                                    .Asiento_MovDoc = New e_Asiento_MovDoc
                                    .Asiento_MovDoc.TipoOperacion = "I"
                                    .Asiento_MovDoc.IdMovimientoDocumento = oeMovCtaCte.oeMovimientoDoc.Id
                                    .Asiento_MovDoc.Activo = True
                                End With
                                For Each oeAux In _leAMAux(0).leDetalle.OrderBy(Function(it) it.Fila).ToList
                                    oeAsientoMov = New e_AsientoMovimiento
                                    With oeAsientoMov
                                        .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                        .IdUsuarioCrea = _leAMAux(0).UsuarioCreacion : .Activo = True
                                        Dim _Moneda = oeMovCtaCte.oeMovimientoDoc.Compra.Moneda.Nombre
                                        Select Case Left(oeAux.Cuenta.Trim, 2)
                                            Case "65"
                                                .IdCuentaContable = IIf(oeMovCtaCte.IdCtaTrans.Trim <> "", oeMovCtaCte.IdCtaTrans, oeAux.IdCuentaContable)
                                                If oeAux.Partida = 1 Then
                                                    .DebeMN = IIf(_Moneda = "SOLES", oeMovCtaCte.oeMovimientoDoc.SubTotal, (oeMovCtaCte.oeMovimientoDoc.SubTotal * _leAMAux(0).TipoCambio))
                                                    .DebeME = IIf(_Moneda = "SOLES", (oeMovCtaCte.oeMovimientoDoc.SubTotal / _leAMAux(0).TipoCambio), oeMovCtaCte.oeMovimientoDoc.SubTotal)
                                                Else
                                                    .HaberMN = IIf(_Moneda = "SOLES", oeMovCtaCte.oeMovimientoDoc.SubTotal, (oeMovCtaCte.oeMovimientoDoc.SubTotal * _leAMAux(0).TipoCambio))
                                                    .HaberME = IIf(_Moneda = "SOLES", (oeMovCtaCte.oeMovimientoDoc.SubTotal / _leAMAux(0).TipoCambio), oeMovCtaCte.oeMovimientoDoc.SubTotal)
                                                End If
                                                ' Genera Movimiento Analisis por Vehiculo sin Repetir
                                                oeMovAnalisis = New e_MovimientoAnalisis
                                                oeMovAnalisis.TipoOperacion = "I"
                                                oeMovAnalisis.IdGastoFuncion = "1CH000088" ' GASTO ADMINISTRATIVO
                                                oeMovAnalisis.IdCentroCosto = "1CH000000005" ' ADMINISTRACION
                                                oeMovAnalisis.IdVehiculo = "1SI000000059" ' GENERIC
                                                If oeMovCtaCte.oeMovimientoDoc.MovimientoAnalisis.Count > 0 Then
                                                    oeMovAnalisis.IdItemGasto = oeMovCtaCte.oeMovimientoDoc.MovimientoAnalisis(0).IdItemGasto
                                                Else
                                                    oeMovAnalisis.IdItemGasto = "1CH000112" ' OTRAS CARGAS DIVERSAS
                                                End If
                                                oeMovAnalisis.Monto = oeMovCtaCte.oeMovimientoDoc.SubTotal
                                                oeMovAnalisis.Saldo = oeMovCtaCte.oeMovimientoDoc.SubTotal
                                                oeMovAnalisis.Activo = True
                                                .MovimientoAnalisis.Add(oeMovAnalisis)
                                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                            Case "40"
                                                If oeMovCtaCte.oeMovimientoDoc.IGV > 0 Then
                                                    .IdCuentaContable = oeAux.IdCuentaContable.Trim
                                                    If oeAux.Partida = 1 Then
                                                        .DebeMN = IIf(_Moneda = "SOLES", oeMovCtaCte.oeMovimientoDoc.IGV, (oeMovCtaCte.oeMovimientoDoc.IGV * _leAMAux(0).TipoCambio))
                                                        .DebeME = IIf(_Moneda = "SOLES", (oeMovCtaCte.oeMovimientoDoc.IGV / _leAMAux(0).TipoCambio), oeMovCtaCte.oeMovimientoDoc.IGV)
                                                    Else
                                                        .HaberMN = IIf(_Moneda = "SOLES", oeMovCtaCte.oeMovimientoDoc.IGV, (oeMovCtaCte.oeMovimientoDoc.IGV * _leAMAux(0).TipoCambio))
                                                        .HaberME = IIf(_Moneda = "SOLES", (oeMovCtaCte.oeMovimientoDoc.IGV / _leAMAux(0).TipoCambio), oeMovCtaCte.oeMovimientoDoc.IGV)
                                                    End If
                                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                                End If
                                            Case "42"
                                                .IdCuentaContable = oeMovCtaCte.oeMovimientoDoc.IdCuentaContable
                                                If oeAux.Partida = 1 Then
                                                    .DebeMN = IIf(_Moneda = "SOLES", oeMovCtaCte.oeMovimientoDoc.Total, (oeMovCtaCte.oeMovimientoDoc.Total * _leAMAux(0).TipoCambio))
                                                    .DebeME = IIf(_Moneda = "SOLES", (oeMovCtaCte.oeMovimientoDoc.Total / _leAMAux(0).TipoCambio), oeMovCtaCte.oeMovimientoDoc.Total)
                                                Else
                                                    .HaberMN = IIf(_Moneda = "SOLES", oeMovCtaCte.oeMovimientoDoc.Total, (oeMovCtaCte.oeMovimientoDoc.Total * _leAMAux(0).TipoCambio))
                                                    .HaberME = IIf(_Moneda = "SOLES", (oeMovCtaCte.oeMovimientoDoc.Total / _leAMAux(0).TipoCambio), oeMovCtaCte.oeMovimientoDoc.Total)
                                                End If
                                                'Genera AsientoMoviento - Movimiento Documento
                                                oeAsientoMov.AsMov_MovDoc = New e_AsientoMov_MovDoc
                                                oeAsientoMov.AsMov_MovDoc.TipoOperacion = "I"
                                                oeAsientoMov.AsMov_MovDoc.IdMovimientoDocumento = oeMovCtaCte.oeMovimientoDoc.Id
                                                oeAsientoMov.AsMov_MovDoc.IdCuentaxCyP = String.Empty
                                                oeAsientoMov.AsMov_MovDoc.Activo = True
                                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                        End Select
                                        '.IdUsuarioCrea = _leAMAux(0).UsuarioCreacion : .Activo = True
                                        'If Not oeMovCtaCte.IndNoGrabado Then oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                        'oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                    End With
                                Next
                                oeMovCtaCte.oeAsiento = oeAsiento
                            End If
                        Next
                        ' Guardar Masivo
                        If _BandMasivo Then
                            GuardarMasivo(leMovCuentaCte.Where(Function(it) it.TipoReferencia = 1 And it.TipoOperacion = "I").ToList, PrefijoID)
                        End If
                        ' Eliminar
                        Dim _leAuxElim = leMovCuentaCte.Where(Function(it) it.TipoOperacion = "E").ToList
                        If _leAuxElim.Count > 0 Then
                            odMovCuentaCte.EliminarLista(_leAuxElim)
                        End If
                        ' Actualizar Saldo
                        Dim oeSaldoCtaCte As New e_SaldoCtaCorriente
                        oeSaldoCtaCte.TipoOperacion = "M"
                        oeSaldoCtaCte.IdCuentaCorriente = leMovCuentaCte(0).IdCuentaCorriente
                        If odSaldoCtaCte.Guardar(oeSaldoCtaCte) Then
                            TransScope.Complete()
                            Return True
                        End If
                    End If
                Else
                    Throw New Exception("No Hay Datos para Guardar")
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(leMovCuentaCte As List(Of e_MovCuentaCte), ByVal PrefijoID As String) As Boolean Implements Il_MovCuentaCte.GuardarMasivo
        Try
            Dim _Id As String = odMovCuentaCte.UltimoIdInserta(PrefijoID), _Prefijo As String = Left(_Id, 3), _Nro As Integer = CInt(Right(_Id, Len(_Id) - 3))
            Dim _IdMCCA As String = odMovCtaAsiento.UltimoIdInserta(PrefijoID), _PrefijoMCCA As String = Left(_IdMCCA, 3), _NroMCCA As Integer = CInt(Right(_IdMCCA, Len(_IdMCCA) - 3))
            Dim _IdMD As String = odMovimientoDoc.UltimoIdInserta(PrefijoID), _PrefijoMD As String = Left(_IdMD, 3), _NroMD As Integer = CInt(Right(_IdMD, Len(_IdMD) - 3))
            Dim _IdCOM As String = odCompra.UltimoIdInserta(PrefijoID), _PrefijoCOM As String = Left(_IdCOM, 3), _NroCOM As Integer = CInt(Right(_IdCOM, Len(_IdCOM) - 3))
            Dim _IdAC As String = odAsiento.UltimoIdInserta(PrefijoID), _PrefijoAC As String = Left(_IdAC, 3), _NroAC As Integer = CInt(Right(_IdAC, Len(_IdAC) - 3))
            Dim _IdAM As String = odAsientoMov.UltimoIdInserta(PrefijoID), _PrefijoAM As String = Left(_IdAM, 3), _NroAM As Integer = CInt(Right(_IdAM, Len(_IdAM) - 3))
            Dim _IdAMD As String = odAsientoMovDoc.UltimoIdInserta(PrefijoID), _PrefijoAMD As String = Left(_IdAMD, 3), _NroAMD As Integer = CInt(Right(_IdAMD, Len(_IdAMD) - 3))
            Dim _IdAMMD As String = odAsiMovMovDoc.UltimoIdInserta(PrefijoID), _PrefijoAMMD As String = Left(_IdAMMD, 3), _NroAMMD As Integer = CInt(Right(_IdAMMD, Len(_IdAMMD) - 3))
            Dim _IdMA As String = odMovAnalisis.UltimoIdInserta(PrefijoID), _PrefijoMA As String = Left(_IdMA, 3), _NroMA As Integer = CInt(Right(_IdMA, Len(_IdMA) - 3))
            Dim _NroAsi As String = odAsiento.UltimoNroAsiento(leMovCuentaCte(0).oeAsiento.IdTipoAsiento, leMovCuentaCte(0).oeAsiento.IdPeriodo, "1", PrefijoID)
            Dim _PrefijoAsi As String = Left(_NroAsi, 2), _NroNroAsi As Integer = CInt(Right(_NroAsi, Len(_NroAsi) - 2))

            Dim _Dt As Data.DataTable = CrearDT(), _DtMCCA As Data.DataTable = olMovCtaAsiento.CrearDT(), _DtMD As Data.DataTable = olMovimientoDoc.CrearDT()
            Dim _DtCOM As Data.DataTable = olCompra.CrearDT(), _DtAC As Data.DataTable = olAsiento.CrearDT(), _DtAMD As Data.DataTable = olAsientoMovDoc.CrearDT()
            Dim _DtAMMD As Data.DataTable = olAsiMovMovDoc.CrearDT(), _DtMA As Data.DataTable = olMovAnalisis.CrearDT(), _DtAM As Data.DataTable = olAsientoMov.CrearDT()

            Dim _Fil As Integer = 0

            For Each oeMovCtaCte In leMovCuentaCte
                With oeMovCtaCte
                    ' Llenar Movimiento Documento
                    Dim _rwMD As Data.DataRow
                    _rwMD = _DtMD.NewRow
                    _rwMD("Id") = _PrefijoMD.ToString & l_FuncionesGenerales.CompletaConCeros(_NroMD.ToString, 12)
                    _rwMD("IdTipoDocumento") = .oeMovimientoDoc.IdTipoDocumento
                    _rwMD("Serie") = .oeMovimientoDoc.Serie
                    _rwMD("Numero") = .oeMovimientoDoc.Numero
                    _rwMD("FechaEmision") = .oeMovimientoDoc.FechaEmision
                    _rwMD("FechaVencimiento") = .oeMovimientoDoc.FechaEmision
                    _rwMD("NoGravadas") = .oeMovimientoDoc.NoGravado
                    _rwMD("IGV") = .oeMovimientoDoc.IGV
                    _rwMD("SubTotal") = .oeMovimientoDoc.SubTotal
                    _rwMD("Total") = .oeMovimientoDoc.Total
                    _rwMD("Saldo") = .oeMovimientoDoc.Saldo
                    _rwMD("IdClienteProveedor") = .oeMovimientoDoc.IdClienteProveedor
                    _rwMD("Activo") = True
                    _rwMD("IndCompraVenta") = .oeMovimientoDoc.IndCompraVenta
                    _rwMD("IdPeriodo") = .oeMovimientoDoc.IdPeriodo
                    _rwMD("IdMoneda") = .oeMovimientoDoc.IdMoneda
                    _rwMD("TipoCambio") = .oeMovimientoDoc.TipoCambio
                    _rwMD("UsuarioCreacion") = .oeMovimientoDoc.IdUsuarioCrea
                    _rwMD("FechaCreacion") = Date.Now.Date
                    _rwMD("IdCuentaContable") = .oeMovimientoDoc.IdCuentaContable
                    _rwMD("IdEstadoDocumento") = .oeMovimientoDoc.IdEstadoDocumento
                    _rwMD("Operador") = 1
                    _rwMD("MacPCLocalCreacion") = .oeMovimientoDoc.Mac_PC_Local
                    _rwMD("IndServicioMaterial") = .oeMovimientoDoc.IndServicioMaterial
                    _rwMD("GlosaCtaxCyP") = String.Empty
                    _rwMD("CuoMomentaneo") = String.Empty
                    _rwMD("UsuarioModifica") = .oeMovimientoDoc.IdUsuarioCrea
                    _rwMD("FechaModificacion") = #1/1/1901#
                    _DtMD.Rows.Add(_rwMD)
                    ' Llenar Compra
                    Dim _rwCOM As Data.DataRow
                    _rwCOM = _DtCOM.NewRow
                    _rwCOM("Id") = _PrefijoCOM.ToString & l_FuncionesGenerales.CompletaConCeros(_NroCOM.ToString, 12)
                    _rwCOM("AnoEmisionAduana") = .oeMovimientoDoc.Compra.AnoEmisionAduana
                    _rwCOM("Base1") = .oeMovimientoDoc.Compra.Base1
                    _rwCOM("Igv1") = .oeMovimientoDoc.Compra.Igv1
                    _rwCOM("Base2") = .oeMovimientoDoc.Compra.Base2
                    _rwCOM("Igv2") = .oeMovimientoDoc.Compra.Igv2
                    _rwCOM("Base3") = .oeMovimientoDoc.Compra.Base3
                    _rwCOM("Igv3") = .oeMovimientoDoc.Compra.Igv3
                    _rwCOM("Isc") = .oeMovimientoDoc.Compra.Isc
                    _rwCOM("OtrosTributos") = .oeMovimientoDoc.Compra.OtrosTributos
                    _rwCOM("NoGravadas") = .oeMovimientoDoc.Compra.NoGravadas
                    _rwCOM("IdMovimientoDocumento") = _PrefijoMD.ToString & l_FuncionesGenerales.CompletaConCeros(_NroMD.ToString, 12)
                    _rwCOM("Activo") = True
                    _rwCOM("IdTipoCompra") = String.Empty
                    _rwCOM("IdTipoPago") = "1SI000000005"
                    _rwCOM("Percepcion") = .oeMovimientoDoc.Compra.Percepcion
                    _rwCOM("Detraccion") = .oeMovimientoDoc.Compra.Detraccion
                    _rwCOM("Retencion") = .oeMovimientoDoc.Compra.Retencion
                    _rwCOM("PercepcionPorc") = .oeMovimientoDoc.Compra.PercepcionPorc
                    _rwCOM("DetraccionPorc") = .oeMovimientoDoc.Compra.DetraccionPorc
                    _rwCOM("RetencionPorc") = .oeMovimientoDoc.Compra.RetencionPorc
                    _rwCOM("IndTipoOperacion") = .oeMovimientoDoc.Compra.IndTipoOperacion
                    _rwCOM("Glosa") = .oeMovimientoDoc.Compra.Glosa
                    _rwCOM("ImpRenta") = .oeMovimientoDoc.Compra.ImpuestoRenta
                    _rwCOM("CobraCajaChica") = .oeMovimientoDoc.Compra.CobraCajaChica
                    _rwCOM("IdMotivoDocumento") = .oeMovimientoDoc.Compra.IdMotivoDocumento
                    _rwCOM("NroRegImprime") = String.Empty
                    _DtCOM.Rows.Add(_rwCOM)
                    ' Llenar Movimiento Cuenta Corriente
                    Dim _rw As Data.DataRow
                    _rw = _Dt.NewRow
                    _rw("Id") = _Prefijo.ToString & l_FuncionesGenerales.CompletaConCeros(_Nro.ToString, 12)
                    _rw("IdCuentaCorriente") = .IdCuentaCorriente
                    _rw("Fecha") = .Fecha
                    _rw("Importe") = .Importe
                    _rw("IdTipoDocumento") = .IdTipoDocumento
                    _rw("Glosa") = .Glosa
                    _rw("IdReferencia") = _PrefijoMD.ToString & l_FuncionesGenerales.CompletaConCeros(_NroMD.ToString, 12)
                    _rw("TipoReferencia") = .TipoReferencia
                    _rw("IngresoEgreso") = .IngresoEgreso
                    _rw("Liquidado") = .Liquidado
                    _rw("UsuarioCreacion") = .UsuarioCreacion
                    _rw("FechaCreacion") = Date.Now
                    _rw("Activo") = True
                    _rw("FechaLiquida") = .FechaLiquida
                    _rw("UsuarioLiquida") = .UsuarioLiquida
                    _rw("IdMoneda") = .IdMoneda
                    _rw("TipoCambio") = .TipoCambio
                    _Dt.Rows.Add(_rw)
                    ' Llenar Asiento
                    Dim _rwAC As Data.DataRow
                    _rwAC = _DtAC.NewRow
                    _rwAC("Id") = _PrefijoAC.ToString & l_FuncionesGenerales.CompletaConCeros(_NroAC.ToString, 12)
                    _rwAC("IdPeriodo") = .oeAsiento.IdPeriodo
                    _rwAC("IdTipoAsiento") = .oeAsiento.IdTipoAsiento
                    _rwAC("NroAsiento") = _PrefijoAsi & l_FuncionesGenerales.CompletaConCeros(_NroNroAsi.ToString, 7)
                    _rwAC("Fecha") = .oeAsiento.Fecha
                    _rwAC("Glosa") = .oeAsiento.Glosa
                    _rwAC("GlosaImprime") = .oeAsiento.Glosa
                    _rwAC("IdMoneda") = .oeAsiento.IdMoneda
                    _rwAC("TipoCambio") = .oeAsiento.TipoCambio
                    _rwAC("TotalDebe") = .oeAsiento.TotalDebe
                    _rwAC("TotalHaber") = .oeAsiento.TotalHaber
                    _rwAC("IdUsuarioBloquea") = ""
                    _rwAC("UsuarioCreacion") = .oeAsiento.IdUsuarioCrea
                    _rwAC("IdEstado") = "1CH00005"
                    _rwAC("IdAsientoExtorno") = ""
                    _rwAC("FechaCreacion") = Date.Now()
                    _rwAC("Activo") = True
                    _rwAC("NroAsientoImprime") = DBNull.Value
                    _rwAC("IdentificaAsiento") = ""
                    _rwAC("IndRevision") = DBNull.Value
                    _rwAC("FechaRevision") = #1/1/1901#
                    _rwAC("UsuarioRevision") = DBNull.Value
                    _rwAC("IndOrigen") = 0
                    _rwAC("UsuarioModificacion") = DBNull.Value
                    _rwAC("FechaModificacion") = #1/1/1901#
                    _DtAC.Rows.Add(_rwAC)
                    _Fil = 0
                    ' Llenar Asiento Movimiento Documento
                    Dim _rwAMD As Data.DataRow
                    _rwAMD = _DtAMD.NewRow
                    _rwAMD("Id") = _PrefijoAMD.ToString & l_FuncionesGenerales.CompletaConCeros(_NroAMD.ToString, 9)
                    _rwAMD("IdAsiento") = _PrefijoAC.ToString & l_FuncionesGenerales.CompletaConCeros(_NroAC.ToString, 12)
                    _rwAMD("IdMovimientoDocumento") = _PrefijoMD.ToString & l_FuncionesGenerales.CompletaConCeros(_NroMD.ToString, 12)
                    _rwAMD("Activo") = True
                    _DtAMD.Rows.Add(_rwAMD)
                    For Each _oeAsiMov In .oeAsiento.AsientoMovimiento
                        ' Llenar Asiento Movimiento
                        _Fil = _Fil + 1
                        Dim _rwAM As Data.DataRow
                        _rwAM = _DtAM.NewRow
                        _rwAM("Id") = _PrefijoAM & l_FuncionesGenerales.CompletaConCeros(_NroAM.ToString, Len(_IdAM) - 3)
                        _rwAM("IdAsiento") = _PrefijoAC.ToString & l_FuncionesGenerales.CompletaConCeros(_NroAC.ToString, 12)
                        _rwAM("IdCuentaContable") = _oeAsiMov.IdCuentaContable
                        _rwAM("Glosa") = _oeAsiMov.Glosa.Trim
                        _rwAM("DebeMN") = _oeAsiMov.DebeMN
                        _rwAM("HaberMN") = _oeAsiMov.HaberMN
                        _rwAM("DebeME") = _oeAsiMov.DebeME
                        _rwAM("HaberME") = _oeAsiMov.HaberME
                        _rwAM("IdUsuarioCrea") = .oeAsiento.IdUsuarioCrea
                        _rwAM("FechaCreacion") = Date.Now()
                        _rwAM("Activo") = True
                        _rwAM("NroLinea") = _Fil
                        _DtAM.Rows.Add(_rwAM)
                        ' Llenar Asiento Movimiento Movimiento Documento
                        If _oeAsiMov.AsMov_MovDoc.TipoOperacion = "I" Then
                            Dim _rwAMMD As Data.DataRow
                            _rwAMMD = _DtAMMD.NewRow
                            _rwAMMD("Id") = _PrefijoAMMD & l_FuncionesGenerales.CompletaConCeros(_NroAMMD.ToString, Len(_IdAMMD) - 3)
                            _rwAMMD("IdMovimientoDocumento") = _PrefijoMD.ToString & l_FuncionesGenerales.CompletaConCeros(_NroMD.ToString, 12)
                            _rwAMMD("IdAsientoMovimiento") = _PrefijoAM & l_FuncionesGenerales.CompletaConCeros(_NroAM.ToString, Len(_IdAM) - 3)
                            _rwAMMD("Activo") = True
                            _rwAMMD("IdCuentaxCyP") = DBNull.Value
                            _rwAMMD("UsuarioCreacion") = .oeAsiento.IdUsuarioCrea
                            _rwAMMD("FechaCreacion") = Date.Now()
                            _DtAMMD.Rows.Add(_rwAMMD)
                        End If
                        If _oeAsiMov.MovimientoAnalisis.Count > 0 Then
                            ' Llenar Asiento Movimiento Analisis
                            Dim _rwMA As Data.DataRow
                            _rwMA = _DtMA.NewRow
                            _rwMA("Id") = _PrefijoMA & l_FuncionesGenerales.CompletaConCeros(_NroMA.ToString, 13)
                            _rwMA("IdCentroCosto") = _oeAsiMov.MovimientoAnalisis(0).IdCentroCosto
                            _rwMA("IdItemGasto") = _oeAsiMov.MovimientoAnalisis(0).IdItemGasto
                            _rwMA("IdTrabajador") = _oeAsiMov.MovimientoAnalisis(0).IdTrabajador
                            _rwMA("IdVehiculo") = _oeAsiMov.MovimientoAnalisis(0).IdVehiculo
                            _rwMA("IdRuta") = _oeAsiMov.MovimientoAnalisis(0).IdRuta
                            _rwMA("IdBanco") = _oeAsiMov.MovimientoAnalisis(0).IdBanco
                            _rwMA("IdAnalisis1") = _oeAsiMov.MovimientoAnalisis(0).IdAnalisis1
                            _rwMA("IdAnalisis2") = _oeAsiMov.MovimientoAnalisis(0).IdAnalisis2
                            _rwMA("Activo") = 1
                            _rwMA("IdAsientoMovimiento") = _PrefijoAM & l_FuncionesGenerales.CompletaConCeros(_NroAM.ToString, Len(_IdAM) - 3)
                            _rwMA("Monto") = _oeAsiMov.MovimientoAnalisis(0).Monto
                            _rwMA("Saldo") = _oeAsiMov.MovimientoAnalisis(0).Saldo
                            _rwMA("IdMovimientoAnalisis") = ""
                            _rwMA("IdGastoFuncion") = _oeAsiMov.MovimientoAnalisis(0).IdGastoFuncion
                            _rwMA("IdOrigenProrrateo") = ""
                            _DtMA.Rows.Add(_rwMA)
                        End If
                        _NroAM = _NroAM + 1
                    Next
                    ' Llenar Movimiento Cuenta Corriente Asiento
                    Dim _rwMCCA As Data.DataRow
                    _rwMCCA = _DtMCCA.NewRow
                    _rwMCCA("Id") = _PrefijoMCCA.ToCharArray & l_FuncionesGenerales.CompletaConCeros(_NroMCCA.ToString, 12)
                    _rwMCCA("IdMovCuentaCte") = _Prefijo.ToString & l_FuncionesGenerales.CompletaConCeros(_Nro.ToString, 12)
                    _rwMCCA("IdAsiento") = _PrefijoAC.ToString & l_FuncionesGenerales.CompletaConCeros(_NroAC.ToString, 12)
                    _rwMCCA("Activo") = True
                    _DtMCCA.Rows.Add(_rwMCCA)
                End With
                _Nro = _Nro + 1
                _NroMD = _NroMD + 1
                _NroCOM = _NroCOM + 1
                _NroAC = _NroAC + 1
                _NroAMD = _NroAMD + 1
                _NroMCCA = _NroMCCA + 1
                _NroAMMD = _NroAMMD + 1
                _NroMA = _NroMA + 1
            Next
            Return odMovCuentaCte.GuardarMasivo(_DtMD, _DtCOM, _Dt, _DtAC, _DtAMD, _DtAM, _DtAMMD, _DtMA, _DtMCCA)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CrearDT() As DataTable Implements Il_MovCuentaCte.CrearDT
        Dim MovCuentaCte As New Data.DataTable
        With MovCuentaCte
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCuentaCorriente", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Fecha", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Importe", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdTipoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Glosa", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdReferencia", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoReferencia", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IngresoEgreso", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Liquidado", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("FechaLiquida", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioLiquida", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMoneda", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoCambio", Type.GetType("System.Decimal")))
        End With
        Return MovCuentaCte
    End Function

    Public Function ListarDocumentos(oeMovCuentaCte As e_MovCuentaCte) As List(Of e_MovimientoDocumento) Implements Il_MovCuentaCte.ListarDocumentos
        Try
            Return odMovCuentaCte.ListarDocumentos(oeMovCuentaCte)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
