Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_ObligacionFinanciera
    Implements Il_ObligacionFinanciera

    Dim odObligacionFinanciera As New d_ObligacionFinanciera
    Dim odAsiento As New d_Asiento, olAsiento As New l_Asiento
    Dim odAsientoMovimiento As New d_AsientoMovimiento, olAsientoMovimiento As New l_AsientoMovimiento
    Dim oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Dim odCuentaxCyP As New d_CuentaxCyP, olCuentaxCyP As New l_CuentaxCyP
    Dim odAsMovMovDoc As New d_AsientoMov_MovDoc, olAsMovMovDoc As New l_AsientoMov_MovDoc
    Dim odAsMovObliFin As New d_AsientoMov_ObligacionFin, olAsMovObliFin As New l_AsientoMov_ObligacionFin
    Dim odFecLetras As New d_FecLetras, olFecLetras As New l_FecLetras
    Dim odObligacionDocumento As New d_ObligacionDocumento, olObligacionDocuemto As New l_ObligacionDocumento
    Dim olFuncionesGenerales As New l_FuncionesGenerales
    Dim odMovimientoAnalisis As New d_MovimientoAnalisis, olMovimientoAnalisis As New l_MovimientoAnalisis
    Dim odMovCajaBanco As New d_MovimientoCajaBanco, olMovCajaBanco As New l_MovimientoCajaBanco
    Dim oeCuentaGenerales As New e_TablaContableDet
    Dim leCuentasGenerales As New List(Of e_TablaContableDet)


#Region "Variables y valores Generales"

    Public Function CrearDT() As System.Data.DataTable Implements Il_ObligacionFinanciera.CrearDT
        Dim ObligacionFinanciera As New Data.DataTable
        With ObligacionFinanciera
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdContratoFinanciero", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Codigo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdEmpresaBanco", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Glosa", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaEmision", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("FechaVencimiento", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("IdTipoObligacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMoneda", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoCambio", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoMN", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoME", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Saldo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TasaInteres", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoInteresTes", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoInteresCon", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoInteresMoratorio", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Comision", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IdCuentaContable", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("MacPCLocalCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCuentaContableInteres", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCuentaBancaria", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Gastos", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("CodigoUnico", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Voucher", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("GlosaCtaxCyP", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("MontoInteresDscto", Type.GetType("System.Decimal")))
        End With
        Return ObligacionFinanciera
    End Function

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String Implements Il_ObligacionFinanciera.CompletaConCeros
        Try
            Dim Retorna As String = ""
            For i As Integer = 1 To lnCantidad - Len(ls_Tex)
                Retorna = Retorna & "0"
            Next
            Return Retorna + ls_Tex
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

    Public Function Obtener(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera) As EntidadesWCF.e_ObligacionFinanciera Implements Il_ObligacionFinanciera.Obtener
        Try
            Return odObligacionFinanciera.Obtener(oeObligacionFinanciera)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera) As System.Collections.Generic.List(Of EntidadesWCF.e_ObligacionFinanciera) Implements Il_ObligacionFinanciera.Listar
        Try
            Return odObligacionFinanciera.Listar(oeObligacionFinanciera)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera, _
                            ByVal lsNombreObligacion As String) As Boolean Implements Il_ObligacionFinanciera.Validar
        Try
            With oeObligacionFinanciera

                olFuncionesGenerales.ValidarPeriodo(.oePeriodo.Id, gAreasSGI.Contabilidad)

                If lsNombreObligacion = "FEC" Or lsNombreObligacion = "FEDD" Or lsNombreObligacion = "LETRA" Then
                    olFuncionesGenerales.ValidarCampoNoNulo(oeObligacionFinanciera.Codigo, "Ingrese el código único de la obligación financiera")
                End If
                If lsNombreObligacion = "FEDD" Or lsNombreObligacion = "FACTORING" Then
                    If oeObligacionFinanciera.leDocumentoAgregados.Count = 0 Then Throw New Exception("Ingrese al Menos una Venta")
                End If

                If oeObligacionFinanciera.Codigo = "FEDDFACTORING" Or oeObligacionFinanciera.Codigo = "LETRA" Then
                    If odObligacionFinanciera.ListarValidar(oeObligacionFinanciera) > 0 Then
                        Throw New Exception("No se puede Eliminar, el saldo de una Obligacion Asociada es diferente de Cero")
                    End If
                Else
                    If oeObligacionFinanciera.TipoOperacion <> "I" Then
                        Dim oeOFin As New e_ObligacionFinanciera
                        oeOFin = Obtener(oeObligacionFinanciera)
                        If oeOFin.Saldo <> IIf(oeOFin.IdMoneda = "1CH01", oeOFin.MontoMN, oeOFin.MontoME) Then
                            Throw New Exception("No se puede Operar, el saldo no coincide con el importe total")
                        End If
                    End If
                End If

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera) As Boolean Implements Il_ObligacionFinanciera.Eliminar
        Try
            If Validar(oeObligacionFinanciera, "") Then
                Return odObligacionFinanciera.Eliminar(oeObligacionFinanciera)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarObli(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera) As Boolean Implements Il_ObligacionFinanciera.GuardarObli
        Try
            Return odObligacionFinanciera.GuardarObli(oeObligacionFinanciera)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CambiarGlosa(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera) As Boolean Implements Il_ObligacionFinanciera.CambiarGlosa
        Try
            Return odObligacionFinanciera.CambiarGlosa(oeObligacionFinanciera)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarFEC(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera) As Boolean Implements Il_ObligacionFinanciera.GuardarFEC
        Try
            If Validar(oeObligacionFinanciera, "FEC") Then
                '--------------recupera id de FEC------------------
                Dim oeTipoDoc As New e_TipoDocumento
                Dim odTipoDoc As New d_TipoDocumento
                oeTipoDoc.Nombre = "FEC"
                oeTipoDoc.TipoOperacion = "L"
                oeTipoDoc = odTipoDoc.Obtener(oeTipoDoc)
                oeObligacionFinanciera.IdTipoObligacion = oeTipoDoc.Id
                Dim oeTCD As New e_TablaContableDet
                Dim odTCD As New d_TablaContableDet
                oeTCD.TipoOperacion = "N"
                oeTCD.Activo = True
                oeTCD.Nombre = "CUENTAS GENERALES"
                oeTCD.Valor1 = oeObligacionFinanciera.FechaEmision.Year
                If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'soles(codigo de sunat)
                    oeTCD.Texto1 = "CTAFECSOLES"
                Else
                    oeTCD.Texto1 = "CTAFECDOLARES"
                End If
                oeTCD = odTCD.Listar(oeTCD)(0)
                oeObligacionFinanciera.IdCuentaContable = oeTCD.Texto2

                '----------------------ASIENTO--------------------------
                Dim oePeriodo As New e_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                Dim olPeriodo As New l_Periodo
                oePeriodo.Activo = True
                oePeriodo.Id = ""
                oePeriodo.Codigo = oeObligacionFinanciera.FechaEmision.Year.ToString + "-" + oeObligacionFinanciera.FechaEmision.Month.ToString
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
                Dim oeAsiento As New e_Asiento
                With oeAsiento
                    .TipoOperacion = "I"
                    .IdPeriodo = lePeriodo(0).Id
                    .IdTipoAsiento = "DIARIO"
                    .Fecha = oeObligacionFinanciera.FechaEmision
                    .Glosa = "OBLIGACION FIN. FEC NRO: " & oeObligacionFinanciera.Codigo & "/ " & oeObligacionFinanciera._NombreBanco
                    .GlosaImprime = .Glosa
                    .IdMoneda = oeObligacionFinanciera.IdMoneda
                    .TipoCambio = oeObligacionFinanciera.TipoCambio
                    If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
                        .TotalDebe = oeObligacionFinanciera._MontoMNSinInteres
                        .TotalHaber = oeObligacionFinanciera._MontoMNSinInteres
                    Else
                        .TotalDebe = oeObligacionFinanciera._MontoMESinInteres
                        .TotalHaber = oeObligacionFinanciera._MontoMESinInteres
                    End If
                    .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
                    .IdEstado = "CUADRADO"
                End With

                '------------------------------------------------

                Dim oeAsientoMovimiento As New e_AsientoMovimiento
                For Each obj As e_MovimientoDocumento In oeObligacionFinanciera.leDocumentoAgregados
                    '---------resto saldo a documento - operacion tipo S
                    obj.Saldo = Math.Abs(obj.Saldo) - Math.Abs(obj.MontoOperar)
                    obj.TipoOperacion = "S"
                    '---------------------------------
                    '----------pago de documento-----------------
                    obj.CuentaxCyP = New e_CuentaxCyP
                    With obj.CuentaxCyP
                        .TipoOperacion = "I"
                        .IdMovimientoCajaBanco = ""
                        .IdMovimientoDocumento = obj.Id
                        If obj.IdMoneda = "1CH01" Then 'MONTO OPERAR DEPENDE DEL DOCUMENTO
                            .MontoMN = Math.Abs(obj.MontoOperar)
                            .MontoMe = Math.Abs(obj.MontoOperar) / oeObligacionFinanciera.TipoCambio
                        Else
                            .MontoMN = Math.Abs(obj.MontoOperar) * oeObligacionFinanciera.TipoCambio
                            .MontoMe = Math.Abs(obj.MontoOperar)
                        End If
                        .Activo = True
                        .Fecha = oeObligacionFinanciera.FechaEmision
                        .UsuarioCreacion = oeObligacionFinanciera.UsuarioCreacion
                        .MacPCLocalCreacion = oeObligacionFinanciera.MacPcLocalCreacion
                    End With
                    '--------------------------------------------
                    '--------tabla Obligacion Documento con Id del pago del documento
                    obj.CuentaxCyP.ObligacionDocumento = New e_ObligacionDocumento
                    With obj.CuentaxCyP.ObligacionDocumento
                        .TipoOperacion = "I"
                        .IdMovimientoDocumento = obj.Id
                        .IdObligacionFinanciera = oeObligacionFinanciera.Id
                        .MontoMN = obj.CuentaxCyP.MontoMN
                        .MontoME = obj.CuentaxCyP.MontoMe
                        .Activo = True
                    End With
                    '-------------------------------------------------------------------
                    '------------------relacion de Documento con asiento_movimiento---------------
                    obj.CuentaxCyP.AsMov_MovDoc = New e_AsientoMov_MovDoc
                    With obj.CuentaxCyP.AsMov_MovDoc
                        .TipoOperacion = "I"
                        .IdMovimientoDocumento = obj.Id
                        .Activo = True
                    End With
                    '-------------------------------------------------------------------------------
                    '---------------detalle de asiento------------------
                    oeAsientoMovimiento = New e_AsientoMovimiento
                    oeAsientoMovimiento.MovimientoDocumento = obj
                    With oeAsientoMovimiento
                        .TipoOperacion = "I"
                        .IdCuentaContable = obj.IdCuentaContable
                        .Glosa = "OBLIGACION FIN. FEC " & obj._AbrevTipoDoc & "/" & obj.Serie & obj.Numero & " " & obj._NombreClienteProveedor
                        If obj.IdMoneda = "1CH01" Then 'soles
                            .DebeMN = obj.MontoOperar
                            .DebeME = obj.MontoOperar / oeObligacionFinanciera.TipoCambio
                        Else
                            .DebeMN = obj.MontoOperar * oeObligacionFinanciera.TipoCambio
                            .DebeME = obj.MontoOperar
                        End If
                        .HaberMN = 0
                        .HaberME = 0
                        .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
                        .Activo = True

                    End With
                    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                    '----------------------------------------------------
                Next
                '---------------solo se provisiona la suma del monto de las facturas, el interes se provisiona mes a mes 
                oeAsientoMovimiento = New e_AsientoMovimiento
                With oeAsientoMovimiento
                    .TipoOperacion = "I"
                    .IdCuentaContable = oeObligacionFinanciera.IdCuentaContable
                    .Glosa = "OBLIGACION FIN. FEC " & oeObligacionFinanciera.Codigo & "/" & oeObligacionFinanciera._NombreBanco
                    .HaberMN = oeObligacionFinanciera._MontoMNSinInteres
                    .HaberME = oeObligacionFinanciera._MontoMESinInteres
                    .DebeMN = 0
                    .DebeME = 0
                    .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
                    .Activo = True
                    '----------------relacion de obligacion con asiento_movimiento---------------
                    .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                    With .AsMov_ObligacionFin
                        .TipoOperacion = "I"
                        .IdAsientoMovimiento = ""
                        .IdObligacionFinanciera = oeObligacionFinanciera.Id
                        .Activo = True
                    End With
                    '----------------------------------------------------------------------------
                End With
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                '-----------------------------------------------------------------------------------------------

                '------------cta de interes----------
                oeTCD.TipoOperacion = "N"
                oeTCD.Activo = True
                oeTCD.Nombre = "CUENTAS GENERALES"
                If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
                    oeTCD.Texto1 = "CTAFECINTERESSOLES"
                Else
                    oeTCD.Texto1 = "CTAFECINTERESDOLARES"
                End If
                oeTCD.Valor1 = oeObligacionFinanciera.FechaEmision.Year
                oeTCD = odTCD.Listar(oeTCD)(0)
                oeObligacionFinanciera._IdCuentaContableInteres = oeTCD.Texto2
                '-----------------------------------
                Return odObligacionFinanciera.Guardar(oeObligacionFinanciera, oeAsiento)

            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarFedd(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera, ByVal oeCuentaBancaria As EntidadesWCF.e_CuentaBancaria) As Boolean Implements Il_ObligacionFinanciera.GuardarFedd
        Try
            Dim oeObligacioDoc As New e_ObligacionDocumento
            If Validar(oeObligacionFinanciera, "FEDD") Then
                '--------------recupera id de FEdd------------------
                Dim oeTipoDoc As New e_TipoDocumento
                Dim odTipoDoc As New d_TipoDocumento
                oeTipoDoc.Nombre = "FEDD"
                oeTipoDoc.TipoOperacion = "L"
                oeTipoDoc = odTipoDoc.Obtener(oeTipoDoc)
                oeObligacionFinanciera.IdTipoObligacion = oeTipoDoc.Id
                Dim oeTCD As New e_TablaContableDet
                Dim odTCD As New d_TablaContableDet
                oeTCD.TipoOperacion = "N"
                oeTCD.Activo = True
                oeTCD.Nombre = "CUENTAS GENERALES"
                oeTCD.Valor1 = oeObligacionFinanciera.FechaEmision.Year
                If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'soles(codigo de sunat)
                    oeTCD.Texto1 = "CTAFEDDSOLES"
                Else
                    oeTCD.Texto1 = "CTAFEDDDOLARES"
                End If
                oeTCD = odTCD.Listar(oeTCD)(0)
                oeObligacionFinanciera.IdCuentaContable = oeTCD.Texto2

                '----------------------ASIENTO--------------------------
                Dim oePeriodo As New e_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                Dim olPeriodo As New l_Periodo
                oePeriodo.Activo = True
                oePeriodo.Id = ""
                oePeriodo.Codigo = oeObligacionFinanciera.FechaEmision.Year.ToString + "-" + oeObligacionFinanciera.FechaEmision.Month.ToString
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
                Dim oeAsiento As New e_Asiento
                With oeAsiento
                    .TipoOperacion = "I"
                    .IdPeriodo = lePeriodo(0).Id
                    .IdTipoAsiento = "BANCO"
                    .Fecha = oeObligacionFinanciera.FechaEmision
                    .Glosa = "OBLIGACION FIN. FEDD NRO: " & oeObligacionFinanciera.Codigo & "/ " & oeObligacionFinanciera._NombreBanco
                    .GlosaImprime = .Glosa
                    .IdMoneda = oeObligacionFinanciera.IdMoneda
                    .TipoCambio = oeObligacionFinanciera.TipoCambio
                    If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
                        .TotalDebe = oeObligacionFinanciera.MontoMN
                        .TotalHaber = oeObligacionFinanciera.MontoMN
                    Else
                        .TotalDebe = oeObligacionFinanciera.MontoME
                        .TotalHaber = oeObligacionFinanciera.MontoME
                    End If
                    .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
                    .IdEstado = "CUADRADO"
                End With

                Dim oeAsientoMovimiento As New e_AsientoMovimiento
                '--------------- se provisiona 104-cuenta bancaria------------------------------
                With oeAsientoMovimiento
                    .TipoOperacion = "I"
                    .IdCuentaContable = oeCuentaBancaria.IdCuentaContable
                    .Glosa = "OBLIGACION FIN. FEDD " & oeObligacionFinanciera.Codigo & "/" & oeObligacionFinanciera._NombreBanco
                    .HaberMN = 0
                    .HaberME = 0
                    .DebeMN = oeObligacionFinanciera._MontoMNSinInteres
                    .DebeME = oeObligacionFinanciera._MontoMESinInteres
                    .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
                    .Activo = True
                    With .MovimientoCajaBanco
                        .TipoOperacion = "I"
                        .IdFlujoCaja = "1CH000000193" 'PRESTAMO DE INSTITUCIONES FINANCIERAS
                        .NroBoucher = ""
                        .IdCuentaBancaria = oeCuentaBancaria.Id
                        .Fecha = oeObligacionFinanciera.FechaEmision
                        .IdMedioPago = "1CH02" 'DEPOSITO EN CUENTA
                        .IdPeriodoConcilia = ""
                        .Activo = True
                        .TipoCambio = oeObligacionFinanciera.TipoCambio
                        .TotalMN = oeObligacionFinanciera._MontoMNSinInteres
                        .TotalME = oeObligacionFinanciera._MontoMESinInteres
                        ._Operador = 1
                    End With
                End With
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                '-----------------------------------------------------------------------------------------------

                '------------cta de interes----------
                oeTCD.TipoOperacion = "N"
                oeTCD.Activo = True
                oeTCD.Nombre = "CUENTAS GENERALES"
                oeTCD.Texto1 = "CTAFEDDINTERES"
                oeTCD.Valor1 = oeObligacionFinanciera.FechaEmision.Year
                oeTCD = odTCD.Listar(oeTCD)(0)
                oeObligacionFinanciera._IdCuentaContableInteres = oeTCD.Texto2
                '-----------------------------------

                '--------------- se provisiona interes------------------------------
                oeAsientoMovimiento = New e_AsientoMovimiento
                With oeAsientoMovimiento
                    .TipoOperacion = "I"
                    .IdCuentaContable = oeObligacionFinanciera._IdCuentaContableInteres
                    .Glosa = "OBLIGACION FIN. FEDD " & oeObligacionFinanciera.Codigo & "/" & oeObligacionFinanciera._NombreBanco
                    .HaberMN = 0
                    .HaberME = 0
                    If oeObligacionFinanciera.IdMoneda = "1CH01" Then
                        .DebeMN = oeObligacionFinanciera.MontoInteresTes
                        .DebeME = oeObligacionFinanciera.MontoInteresTes / oeObligacionFinanciera.TipoCambio
                    Else
                        .DebeMN = oeObligacionFinanciera.MontoInteresTes * oeObligacionFinanciera.TipoCambio
                        .DebeME = oeObligacionFinanciera.MontoInteresTes
                    End If
                    .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
                    .Activo = True
                End With
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                '-----------------------------------------------------------------------------------------------
                '------------------------------------------------------------------------------
                For Each obj As e_MovimientoDocumento In oeObligacionFinanciera.leDocumentoAgregados
                    '--------tabla Obligacion Documento con Id del pago del documento
                    oeObligacioDoc = New e_ObligacionDocumento
                    With oeObligacioDoc
                        .TipoOperacion = "I"
                        .IdMovimientoDocumento = obj.Id
                        .IdObligacionFinanciera = oeObligacionFinanciera.Id
                        If obj.IdMoneda = "1CH01" Then
                            .MontoMN = obj.Total
                            .MontoME = obj.Total / oeObligacionFinanciera.TipoCambio
                        Else
                            .MontoMN = obj.Total * oeObligacionFinanciera.TipoCambio
                            .MontoME = obj.Total
                        End If
                        .Activo = True
                        .IdCuentaxCyP = ""
                    End With
                    oeObligacionFinanciera.leObligacionDocumento.Add(oeObligacioDoc)
                Next
                '--------------- se provisiona todo la obligacion------------------------------
                oeAsientoMovimiento = New e_AsientoMovimiento
                With oeAsientoMovimiento
                    .TipoOperacion = "I"
                    .IdCuentaContable = oeObligacionFinanciera.IdCuentaContable
                    .Glosa = "OBLIGACION FIN. FEDD " & oeObligacionFinanciera.Codigo & "/" & oeObligacionFinanciera._NombreBanco
                    .HaberMN = oeObligacionFinanciera.MontoMN
                    .HaberME = oeObligacionFinanciera.MontoME
                    .DebeMN = 0
                    .DebeME = 0
                    .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
                    .Activo = True
                    '----------------relacion de obligacion con asiento_movimiento--------------
                    .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                    With .AsMov_ObligacionFin
                        .TipoOperacion = "I"
                        .IdAsientoMovimiento = ""
                        .IdObligacionFinanciera = oeObligacionFinanciera.Id
                        .Activo = True
                    End With
                    '---------------------------------------------------------------------------
                End With
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                '-----------------------------------------------------------------------------------------------
                Return odObligacionFinanciera.Guardar(oeObligacionFinanciera, oeAsiento)

            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Function GuardarFactoringReal(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera) As Boolean
        Try
            If Validar(oeObligacionFinanciera, "FACTORING") Then
                '--------------recupera id de factory------------------
                Dim oeTipoDoc As New e_TipoDocumento
                Dim odTipoDoc As New d_TipoDocumento
                oeTipoDoc.Nombre = "FACTORING"
                oeTipoDoc.TipoOperacion = "L"
                oeTipoDoc = odTipoDoc.Obtener(oeTipoDoc)
                oeObligacionFinanciera.IdTipoObligacion = oeTipoDoc.Id
                Dim oeTCD As New e_TablaContableDet
                Dim odTCD As New d_TablaContableDet
                oeTCD.TipoOperacion = "N"
                oeTCD.Activo = True
                oeTCD.Nombre = "CUENTAS GENERALES"
                oeTCD.Valor1 = oeObligacionFinanciera.FechaEmision.Year
                If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'soles(codigo de sunat)
                    oeTCD.Texto1 = "CTAFACTORYSOLES"
                Else
                    oeTCD.Texto1 = "CTAFACTORYDOLARES"
                End If
                oeTCD = odTCD.Listar(oeTCD)(0)
                oeObligacionFinanciera.IdCuentaContable = oeTCD.Texto2

                '----------------------ASIENTO--------------------------
                Dim oePeriodo As New e_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                Dim olPeriodo As New l_Periodo
                oePeriodo.Activo = True
                oePeriodo.Id = ""
                oePeriodo.Codigo = oeObligacionFinanciera.FechaEmision.Year.ToString + "-" + oeObligacionFinanciera.FechaEmision.Month.ToString
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
                Dim oeAsiento As New e_Asiento
                With oeAsiento
                    .TipoOperacion = "I"
                    .IdPeriodo = lePeriodo(0).Id
                    .IdTipoAsiento = "DIARIO"
                    .Fecha = oeObligacionFinanciera.FechaEmision
                    .Glosa = "OBLIGACION FIN. FACTORING NRO: " & oeObligacionFinanciera.Codigo & "/ " & oeObligacionFinanciera._NombreBanco
                    .GlosaImprime = .Glosa
                    .IdMoneda = oeObligacionFinanciera.IdMoneda
                    .TipoCambio = oeObligacionFinanciera.TipoCambio
                    If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
                        .TotalDebe = oeObligacionFinanciera._MontoMNSinInteres
                        .TotalHaber = oeObligacionFinanciera._MontoMNSinInteres
                    Else
                        .TotalDebe = oeObligacionFinanciera._MontoMESinInteres
                        .TotalHaber = oeObligacionFinanciera._MontoMESinInteres
                    End If
                    .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
                    .IdEstado = "CUADRADO"
                End With
                '-----------------------------------------------------------
                Dim oeAsientoMovimiento As New e_AsientoMovimiento
                For Each obj As e_MovimientoDocumento In oeObligacionFinanciera.leDocumentoAgregados
                    '---------resto saldo a documento - operacion tipo S
                    obj.Saldo = Math.Abs(obj.Saldo) - Math.Abs(obj.MontoOperar)
                    obj.TipoOperacion = "S"
                    '---------------------------------
                    '----------pago de documento-----------------
                    obj.CuentaxCyP = New e_CuentaxCyP
                    With obj.CuentaxCyP
                        .TipoOperacion = "I"
                        .IdMovimientoCajaBanco = ""
                        .IdMovimientoDocumento = obj.Id
                        If obj.IdMoneda = "1CH01" Then 'MONTO OPERAR DEPENDE DEL DOCUMENTO
                            .MontoMN = Math.Abs(obj.MontoOperar)
                            .MontoMe = Math.Abs(obj.MontoOperar) / oeObligacionFinanciera.TipoCambio
                        Else
                            .MontoMN = Math.Abs(obj.MontoOperar) * oeObligacionFinanciera.TipoCambio
                            .MontoMe = Math.Abs(obj.MontoOperar)
                        End If
                        .Activo = True
                        .Fecha = oeObligacionFinanciera.FechaEmision
                        .UsuarioCreacion = oeObligacionFinanciera.UsuarioCreacion
                        .MacPCLocalCreacion = oeObligacionFinanciera.MacPcLocalCreacion
                    End With
                    '--------------------------------------------
                    '--------tabla Obligacion Documento con Id del pago del documento
                    obj.CuentaxCyP.ObligacionDocumento = New e_ObligacionDocumento
                    With obj.CuentaxCyP.ObligacionDocumento
                        .TipoOperacion = "I"
                        .IdMovimientoDocumento = obj.Id
                        .IdObligacionFinanciera = oeObligacionFinanciera.Id
                        .MontoMN = obj.CuentaxCyP.MontoMN
                        .MontoME = obj.CuentaxCyP.MontoMe
                        .Activo = True
                    End With
                    '-------------------------------------------------------------------
                    '------------------relacion de Documento con asiento_movimiento---------------
                    obj.CuentaxCyP.AsMov_MovDoc = New e_AsientoMov_MovDoc
                    With obj.CuentaxCyP.AsMov_MovDoc
                        .TipoOperacion = "I"
                        .IdMovimientoDocumento = obj.Id
                        .Activo = True
                    End With
                    '-------------------------------------------------------------------------------
                    '---------------detalle de asiento------------------
                    oeAsientoMovimiento = New e_AsientoMovimiento
                    oeAsientoMovimiento.MovimientoDocumento = obj
                    With oeAsientoMovimiento
                        .TipoOperacion = "I"
                        .IdCuentaContable = obj.IdCuentaContable
                        .Glosa = "OBLIGACION FIN. FACTORING " & obj._AbrevTipoDoc & "/" & obj.Serie & obj.Numero & " " & obj._NombreClienteProveedor
                        If obj.IdMoneda = "1CH01" Then 'soles
                            .DebeMN = obj.MontoOperar
                            .DebeME = obj.MontoOperar / oeObligacionFinanciera.TipoCambio
                        Else
                            .DebeMN = obj.MontoOperar * oeObligacionFinanciera.TipoCambio
                            .DebeME = obj.MontoOperar
                        End If
                        .HaberMN = 0
                        .HaberME = 0
                        .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
                        .Activo = True

                    End With
                    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                    '----------------------------------------------------
                Next
                '---------------solo se provisiona la suma del monto de las facturas, el interes se provisiona mes a mes 
                oeAsientoMovimiento = New e_AsientoMovimiento
                With oeAsientoMovimiento
                    .TipoOperacion = "I"
                    .IdCuentaContable = oeObligacionFinanciera.IdCuentaContable
                    .Glosa = "OBLIGACION FIN. FACTORING " & oeObligacionFinanciera.Codigo & "/" & oeObligacionFinanciera._NombreBanco
                    .HaberMN = oeObligacionFinanciera._MontoMNSinInteres
                    .HaberME = oeObligacionFinanciera._MontoMESinInteres
                    .DebeMN = 0
                    .DebeME = 0
                    .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
                    .Activo = True
                    '----------------relacion de obligacion con asiento_movimiento---------------
                    .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                    With .AsMov_ObligacionFin
                        .TipoOperacion = "I"
                        .IdAsientoMovimiento = ""
                        .IdObligacionFinanciera = oeObligacionFinanciera.Id
                        .Activo = True
                    End With
                    '----------------------------------------------------------------------------
                End With
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                '-----------------------------------------------------------------------------------------------
                ''------------cta de interes----------
                'oeTCD.TipoOperacion = "N"
                'oeTCD.Activo = True
                'oeTCD.Nombre = "CUENTAS GENERALES"
                'oeTCD.Texto1 = "CTAFACTORYINTERES"
                'oeTCD.Valor1 = oeObligacionFinanciera.FechaEmision.Year
                'oeTCD = odTCD.Listar(oeTCD)(0)
                'oeObligacionFinanciera._IdCuentaContableInteres = oeTCD.Texto2
                ''-----------------------------------

                '------------cta de interes----------
                oeTCD.TipoOperacion = "N"
                oeTCD.Activo = True
                oeTCD.Nombre = "CUENTAS GENERALES"
                oeTCD.Texto1 = "CTAFACTORYINTERES"
                oeTCD.Valor1 = oeObligacionFinanciera.FechaEmision.Year
                oeTCD = odTCD.Listar(oeTCD)(0)
                oeObligacionFinanciera._IdCuentaContableInteres = oeTCD.Texto2
                '-----------------------------------
                Return odObligacionFinanciera.Guardar(oeObligacionFinanciera, oeAsiento)

            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Function GuardarFactoringCanje(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera, _
    ByVal oeCuentaBancaria As EntidadesWCF.e_CuentaBancaria, ByVal o_Oblig() As Object) As Boolean
        Try
            'Dim CodigoUnico As String = Date.Now.Year.ToString + Strings.Right("0" + Date.Now.Month.ToString, 2) + Strings.Right("0" + Date.Now.Day.ToString, 2) + Strings.Right("0" + Date.Now.Hour.ToString, 2) _
            '+ Strings.Right("0" + Date.Now.Minute.ToString, 2) + Strings.Right("0" + Date.Now.Second.ToString, 2) + Strings.Right("0" + Date.Now.Millisecond.ToString, 2)

            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'If Validar(oeObligacionFinanciera, "FACTORING") Then
            '    '--------------recupera id de factory------------------
            '    Dim oeTipoDoc As New e_TipoDocumento
            '    Dim odTipoDoc As New d_TipoDocumento
            '    oeTipoDoc.Nombre = "FACT_DESC"
            '    oeTipoDoc.TipoOperacion = "L"
            '    oeTipoDoc = odTipoDoc.Obtener(oeTipoDoc)
            '    oeObligacionFinanciera.IdTipoObligacion = oeTipoDoc.Id
            '    Dim oeTCD As New e_TablaContableDet
            '    Dim odTCD As New d_TablaContableDet
            '    oeTCD.TipoOperacion = "N"
            '    oeTCD.Activo = True
            '    oeTCD.Nombre = "CUENTAS GENERALES"
            '    oeTCD.Valor1 = oeObligacionFinanciera.FechaEmision.Year
            '    If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'soles(codigo de sunat)
            '        oeTCD.Texto1 = "CTAFACTORYSOLES"
            '    Else
            '        oeTCD.Texto1 = "CTAFACTORYDOLARES"
            '    End If
            '    oeTCD = odTCD.Listar(oeTCD)(0)
            '    oeObligacionFinanciera.IdCuentaContable = oeTCD.Texto2

            '    '----------------------ASIENTO--------------------------
            '    Dim oePeriodo As New e_Periodo
            '    Dim lePeriodo As New List(Of e_Periodo)
            '    Dim olPeriodo As New l_Periodo
            '    oePeriodo.Activo = True
            '    oePeriodo.Id = ""
            '    oePeriodo.Codigo = oeObligacionFinanciera.FechaEmision.Year.ToString + "-" + oeObligacionFinanciera.FechaEmision.Month.ToString
            '    lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "BANCO"
            '        .Fecha = oeObligacionFinanciera.FechaEmision
            '        .Glosa = "OBLIGACION FIN. FACTURAS AL DESCUENTO " & oeObligacionFinanciera._NombreBanco
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = oeObligacionFinanciera.IdMoneda
            '        .TipoCambio = oeObligacionFinanciera.TipoCambio
            '        If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
            '            .TotalDebe = oeObligacionFinanciera._MontoMNSinInteres
            '            .TotalHaber = oeObligacionFinanciera._MontoMNSinInteres
            '        Else
            '            .TotalDebe = oeObligacionFinanciera._MontoMESinInteres
            '            .TotalHaber = oeObligacionFinanciera._MontoMESinInteres
            '        End If
            '        .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '    End With
            '    '------------cta de interes----------
            '    oeTCD.TipoOperacion = "N"
            '    oeTCD.Activo = True
            '    oeTCD.Nombre = "CUENTAS GENERALES"
            '    oeTCD.Texto1 = "CTAFACTORYINTERES"
            '    oeTCD.Valor1 = oeObligacionFinanciera.FechaEmision.Year
            '    oeTCD = odTCD.Listar(oeTCD)(0)
            '    oeObligacionFinanciera._IdCuentaContableInteres = oeTCD.Texto2
            '    '-----------------------------------

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona 104-cuenta bancaria------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeCuentaBancaria.IdCuentaContable
            '        .Glosa = "OBLIGACION FIN. FACTURAS AL DESCUENTO " & oeObligacionFinanciera._NombreBanco
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = oeObligacionFinanciera._MontoMNSinInteres
            '        .DebeME = oeObligacionFinanciera._MontoMESinInteres
            '        .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
            '        .Activo = True
            '        With .MovimientoCajaBanco
            '            .TipoOperacion = "I"
            '            .IdFlujoCaja = "1CH000000193" 'PRESTAMO DE INSTITUCIONES FINANCIERAS
            '            .NroBoucher = ""
            '            .IdCuentaBancaria = oeCuentaBancaria.Id
            '            .Fecha = oeObligacionFinanciera.FechaEmision
            '            .IdMedioPago = "1CH02" 'DEPOSITO EN CUENTA
            '            .IdPeriodoConcilia = ""
            '            .Activo = True
            '            .TipoCambio = oeObligacionFinanciera.TipoCambio
            '            .TotalMN = oeObligacionFinanciera._MontoMNSinInteres
            '            .TotalME = oeObligacionFinanciera._MontoMESinInteres
            '            ._Operador = 1
            '        End With
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '----------------------ASIENTO-provision del interes--------------------------
            '    Dim oeAsientoInteres As New e_Asiento
            '    With oeAsientoInteres
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "BANCO"
            '        .Fecha = oeObligacionFinanciera.FechaEmision
            '        .Glosa = "INTERES DE OBLIGACION FIN. FACTURAS AL DESCUENTO " & oeObligacionFinanciera._NombreBanco
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = oeObligacionFinanciera.IdMoneda
            '        .TipoCambio = oeObligacionFinanciera.TipoCambio

            '        .TotalDebe = oeObligacionFinanciera.MontoInteresTes
            '        .TotalHaber = oeObligacionFinanciera.MontoInteresTes

            '        .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '    End With

            '    ''--------------- se provisiona interes------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For i As Integer = 0 To o_Oblig.Length - 1
            '        'obj(0) = o_o.CodigoBanco
            '        'obj(1) = o_o.Monto
            '        'obj(2) = o_o.FechaVencimiento
            '        'obj(3) = o_o.TasaInteres
            '        'obj(4) = o_o.MontoInteres
            '        'obj(5) = o_o.Comision
            '        'obj(6) = o_o.Gastos
            '        oeObli = New e_ObligacionFinanciera
            '        oeObli = oeObligacionFinanciera.Clone
            '        oeObli.CodigoUnico = CodigoUnico
            '        oeObli.Codigo = o_Oblig(i)(0)
            '        oeObli.Saldo = o_Oblig(i)(1)
            '        If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
            '            oeObli.MontoMN = o_Oblig(i)(1)
            '            oeObli.MontoME = o_Oblig(i)(1) / oeObligacionFinanciera.TipoCambio
            '        Else
            '            oeObli.MontoMN = o_Oblig(i)(1) * oeObligacionFinanciera.TipoCambio
            '            oeObli.MontoME = o_Oblig(i)(1)
            '        End If
            '        oeObli.FechaVencimiento = o_Oblig(i)(2)
            '        oeObli.TasaInteres = o_Oblig(i)(3)
            '        oeObli.MontoInteresTes = o_Oblig(i)(4)
            '        oeObli.Comision = o_Oblig(i)(5)
            '        oeObli.Gastos = o_Oblig(i)(6)
            '        '------------------------------------------------------------------------------
            '        For Each obj As e_MovimientoDocumento In oeObligacionFinanciera.leDocumentoAgregados
            '            '------------tabla Obligacion Documento con Id del pago del documento
            '            oeObligacioDoc = New e_ObligacionDocumento
            '            With oeObligacioDoc
            '                .TipoOperacion = "I"
            '                .IdMovimientoDocumento = obj.Id
            '                .IdObligacionFinanciera = oeObligacionFinanciera.Id
            '                If obj.IdMoneda = "1CH01" Then
            '                    .MontoMN = obj.Total
            '                    .MontoME = obj.Total / oeObligacionFinanciera.TipoCambio
            '                Else
            '                    .MontoMN = obj.Total * oeObligacionFinanciera.TipoCambio
            '                    .MontoME = obj.Total
            '                End If
            '                .Activo = True
            '                .IdCuentaxCyP = ""
            '            End With
            '            oeObli.leObligacionDocumento.Add(oeObligacioDoc)
            '        Next
            '        '--------------- se provisiona todo la obligacion------------------------------
            '        leObligacion.Add(oeObli)
            '        '------------------------------------------------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeObli.IdCuentaContable
            '            .Glosa = "OBLIGACION FIN. FACTURAS AL DESCUENTO " & oeObli.Codigo & "/" & oeObligacionFinanciera._NombreBanco
            '            .HaberMN = oeObli.MontoMN
            '            .HaberME = oeObli.MontoME
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = oeObli.UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = oeObli.Id
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '        oeAsientoMovimientoInteres = New e_AsientoMovimiento
            '        With oeAsientoMovimientoInteres
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeObligacionFinanciera._IdCuentaContableInteres
            '            .Glosa = "INTERES OBLIGACION FIN. FACTURAS AL DESCUENTO " & o_Oblig(i)(0) & "/" & oeObligacionFinanciera._NombreBanco
            '            .HaberMN = 0
            '            .HaberME = 0
            '            If oeObligacionFinanciera.IdMoneda = "1CH01" Then
            '                .DebeMN = o_Oblig(i)(4) + o_Oblig(i)(5) + o_Oblig(i)(6)
            '                .DebeME = (o_Oblig(i)(4) + o_Oblig(i)(5) + o_Oblig(i)(6)) / oeObligacionFinanciera.TipoCambio
            '            Else
            '                .DebeMN = (o_Oblig(i)(4) + o_Oblig(i)(5) + o_Oblig(i)(6)) * oeObligacionFinanciera.TipoCambio
            '                .DebeME = o_Oblig(i)(4) + o_Oblig(i)(5) + o_Oblig(i)(6)
            '            End If
            '            .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
            '            .Activo = True
            '            InteresMN = InteresMN + .DebeMN
            '            InteresME = InteresME + .DebeME
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = oeObli.Id
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsientoInteres.AsientoMovimiento.Add(oeAsientoMovimientoInteres)
            '        ''-----------------------------------------------------------------------------------------------
            '    Next

            '    oeAsientoMovimientoInteres = New e_AsientoMovimiento
            '    '--------------- se provisiona 104-cuenta bancaria------------------------------
            '    With oeAsientoMovimientoInteres
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeCuentaBancaria.IdCuentaContable
            '        .Glosa = "INTERES OBLIGACION FIN. FACTURAS AL DESCUENTO " & oeObligacionFinanciera._NombreBanco
            '        .HaberMN = InteresMN
            '        .HaberME = InteresME
            '        .DebeMN = 0
            '        .DebeME = 0
            '        .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
            '        .Activo = True
            '        With .MovimientoCajaBanco
            '            .TipoOperacion = "I"
            '            .IdFlujoCaja = "1CH000000193" 'PRESTAMO DE INSTITUCIONES FINANCIERAS
            '            .NroBoucher = ""
            '            .IdCuentaBancaria = oeCuentaBancaria.Id
            '            .Fecha = oeObligacionFinanciera.FechaEmision
            '            .IdMedioPago = "1CH02" 'DEPOSITO EN CUENTA
            '            .IdPeriodoConcilia = ""
            '            .Activo = True
            '            .TipoCambio = oeObligacionFinanciera.TipoCambio
            '            .TotalMN = InteresMN
            '            .TotalME = InteresME
            '            ._Operador = -1
            '        End With
            '    End With
            '    oeAsientoInteres.AsientoMovimiento.Add(oeAsientoMovimientoInteres)
            '    '-----------------------------------------------------------------------------------------------
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, oeAsientoInteres)

            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarFactoring(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera, _
    ByVal oeCuentaBancaria As EntidadesWCF.e_CuentaBancaria, ByVal o_Oblig() As Object, _
    ByVal FactoringReal As Boolean) As Boolean Implements Il_ObligacionFinanciera.GuardarFactoring
        Try
            'If FactoringReal Then
            '    GuardarFactoringReal(oeObligacionFinanciera)
            'Else
            '    GuardarFactoringCanje(oeObligacionFinanciera, oeCuentaBancaria, o_Oblig)
            'End If
            'Return True
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLeasing(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera, _
                                   ByVal o_Oblig() As Object) As Boolean Implements Il_ObligacionFinanciera.GuardarLeasing
        Try
            'Dim CodigoUnico As String = Date.Now.Year.ToString + Strings.Right("0" + Date.Now.Month.ToString, 2) + Strings.Right("0" + Date.Now.Day.ToString, 2) + Strings.Right("0" + Date.Now.Hour.ToString, 2) _
            '+ Strings.Right("0" + Date.Now.Minute.ToString, 2) + Strings.Right("0" + Date.Now.Second.ToString, 2) + Strings.Right("0" + Date.Now.Millisecond.ToString, 2)

            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'If Validar(oeObligacionFinanciera, "LEASING") Then
            '    '--------------recupera id de Leasing------------------
            '    Dim oeTipoDoc As New e_TipoDocumento
            '    Dim odTipoDoc As New d_TipoDocumento
            '    oeTipoDoc.Nombre = "LEASING"
            '    oeTipoDoc.TipoOperacion = "L"
            '    oeTipoDoc = odTipoDoc.Obtener(oeTipoDoc)
            '    oeObligacionFinanciera.IdTipoObligacion = oeTipoDoc.Id
            '    '-----------ctaleasing------------------------
            '    Dim oeTCD As New e_TablaContableDet
            '    Dim odTCD As New d_TablaContableDet
            '    oeTCD.TipoOperacion = "N"
            '    oeTCD.Activo = True
            '    oeTCD.Nombre = "CUENTAS GENERALES"
            '    oeTCD.Valor1 = oeObligacionFinanciera.FechaEmision.Year
            '    If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'soles(codigo de sunat)
            '        oeTCD.Texto1 = "CTALEASINGSOLES"
            '    Else
            '        oeTCD.Texto1 = "CTALEASINGDOLARES"
            '    End If
            '    oeTCD = odTCD.Listar(oeTCD)(0)
            '    oeObligacionFinanciera.IdCuentaContable = oeTCD.Texto2
            '    '---------------------------------------
            '    '-----------ctaActivoFijo------------------------
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = oeObligacionFinanciera.FechaEmision.Year
            '    oeTCD2.Texto1 = "CTALEASINGACTIVO"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres------------------------
            '    Dim oeTCD3 As New e_TablaContableDet
            '    oeTCD3.TipoOperacion = "N"
            '    oeTCD3.Activo = True
            '    oeTCD3.Nombre = "CUENTAS GENERALES"
            '    oeTCD3.Valor1 = oeObligacionFinanciera.FechaEmision.Year
            '    oeTCD3.Texto1 = "CTALEASINGINTERES"
            '    oeTCD3 = odTCD.Listar(oeTCD3)(0)
            '    oeObligacionFinanciera._IdCuentaContableInteres = oeTCD3.Texto2
            '    '---------------------------------------
            '    '----------------------ASIENTO DE CAPITAL--------------------------
            '    Dim oePeriodo As New e_Periodo
            '    Dim lePeriodo As New List(Of e_Periodo)
            '    Dim olPeriodo As New l_Periodo
            '    oePeriodo.Activo = True
            '    oePeriodo.Id = ""
            '    oePeriodo.Codigo = oeObligacionFinanciera.FechaEmision.Year.ToString + "-" + oeObligacionFinanciera.FechaEmision.Month.ToString
            '    lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "BANCO"
            '        .Fecha = oeObligacionFinanciera.FechaEmision
            '        .Glosa = "OBLIGACION FIN. LEASING " & oeObligacionFinanciera._NombreBanco
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = oeObligacionFinanciera.IdMoneda
            '        .TipoCambio = oeObligacionFinanciera.TipoCambio
            '        If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
            '            .TotalDebe = oeObligacionFinanciera._MontoMNSinInteres
            '            .TotalHaber = oeObligacionFinanciera._MontoMNSinInteres
            '        Else
            '            .TotalDebe = oeObligacionFinanciera._MontoMESinInteres
            '            .TotalHaber = oeObligacionFinanciera._MontoMESinInteres
            '        End If
            '        .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona 33-cuenta ACTIVO FIJO------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "OBLIGACION FIN. LEASING " & oeObligacionFinanciera._NombreBanco
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = oeObligacionFinanciera._MontoMNSinInteres
            '        .DebeME = oeObligacionFinanciera._MontoMESinInteres
            '        .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
            '        .Activo = True
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For i As Integer = 0 To o_Oblig.Length - 1
            '        'obj(0) = o_o.CodigoBanco
            '        'obj(1) = o_o.Monto
            '        'obj(2) = o_o.FechaVencimiento
            '        'obj(3) = o_o.TasaInteres
            '        'obj(4) = o_o.MontoInteres
            '        'obj(5) = o_o.Comision
            '        'obj(6) = o_o.Gastos
            '        'obj(7) = FechaAnterior
            '        'obj(8) = cuota
            '        'obj(9) = nrocuotas
            '        oeObli = New e_ObligacionFinanciera
            '        oeObli = oeObligacionFinanciera.Clone
            '        oeObli.CodigoUnico = CodigoUnico
            '        oeObli.Codigo = o_Oblig(i)(0)
            '        oeObli.Saldo = o_Oblig(i)(1)
            '        If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
            '            oeObli.MontoMN = o_Oblig(i)(1)
            '            oeObli.MontoME = o_Oblig(i)(1) / oeObligacionFinanciera.TipoCambio
            '        Else
            '            oeObli.MontoMN = o_Oblig(i)(1) * oeObligacionFinanciera.TipoCambio
            '            oeObli.MontoME = o_Oblig(i)(1)
            '        End If
            '        oeObli.FechaVencimiento = o_Oblig(i)(2)
            '        oeObli.TasaInteres = o_Oblig(i)(3)
            '        oeObli.MontoInteresTes = o_Oblig(i)(4)
            '        oeObli.Comision = o_Oblig(i)(5)
            '        oeObli.Gastos = o_Oblig(i)(6)
            '        oeObli.FechaInicial = IIf(o_Oblig(i)(7) = Date.Parse("01/01/1901"), oeObligacionFinanciera.FechaEmision, o_Oblig(i)(7))
            '        oeObli.Cuota = o_Oblig(i)(8)
            '        oeObli.NroCuotas = o_Oblig(i)(9)
            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 4521-cuenta LEASING------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeObli.IdCuentaContable
            '            .Glosa = "OBLIGACION FIN. LEASING " & oeObli.Codigo & "/" & oeObligacionFinanciera._NombreBanco
            '            .HaberMN = oeObli.MontoMN
            '            .HaberME = oeObli.MontoME
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = oeObli.UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = oeObli.Id
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------

            '    Next

            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing)

            ' End If

            Return False

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresReversionMensualLeasingSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                  ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresReversionMensualLeasingSoles
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "LEASINGINTERES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH01"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para LEASING-INTERES")
            'End If
            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "IN2"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH01"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)

            'If DtTodos.Rows.Count > 0 Then
            '    '--------------------------------------ASIENTO DE INTERES-----------------------------------------
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------cta puente leasing soles------------------------
            '    Dim oeTCD As New e_TablaContableDet
            '    Dim odTCD As New d_TablaContableDet
            '    oeTCD.TipoOperacion = "N"
            '    oeTCD.Activo = True
            '    oeTCD.Nombre = "CUENTAS GENERALES"
            '    oeTCD.Valor1 = Fecha.Year
            '    oeTCD.Texto1 = "CTALEASINGCTAPUENTESOLES"
            '    oeTCD = odTCD.Listar(oeTCD)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres------------------------
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTALEASINGINTERES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------

            '    '------------
            '    Dim TotalSoles As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalSoles = TotalSoles + rows("ProvMontoInteres")
            '    Next

            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------
            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH01"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "LEASINGINTERES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalSoles
            '        .DebeME = TotalSoles / TipoCambio
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalSoles
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    'Dim InteresMN As Double = 0
            '    'Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") '+ rows("ProvMontoInteres")
            '        'lsIdObligacion = lsIdObligacion & "'" & oeObli.Id & "',"
            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 4552-cuenta puente LEASING------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaContable")
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres")
            '            .HaberME = rows("ProvMontoInteres") / TipoCambio
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    If DtTodos.Rows.Count > 0 Then
            '        odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            '    End If
            '    '----------------------------------------------------------------------------------
            '    '--------------------ASIENTO DE REVERSION------------------------------------------
            '    'lsIdObligacion = Strings.Left(lsIdObligacion, lsIdObligacion.Length - 1)
            '    oeObligFinan = New e_ObligacionFinanciera
            '    oeObligFinan.TipoOperacion = "INL"
            '    oeObligFinan.FechaEmision = DateAdd(DateInterval.Day, -1, Date.Parse("01/" & Month(Fecha) & "/" & Year(Fecha)))
            '    oeObligFinan.IdMoneda = "1CH01"
            '    'oeObligFinan.Id = lsIdObligacion
            '    TotalSoles = 0
            '    DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalSoles = TotalSoles + rows("ProvMontoInteres")
            '    Next

            '    leObligacion = New List(Of e_ObligacionFinanciera)
            '    Dim oeAsiento3 As New e_Asiento
            '    With oeAsiento3
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "REVERSION INTERES OBLIGACION FIN. LEASING "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH01"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "LEASINGINTERES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento2 As New e_AsientoMovimiento
            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli2 As New e_ObligacionFinanciera

            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli2 = New e_ObligacionFinanciera
            '        oeObli2.TipoOperacion = "T"
            '        oeObli2.Id = rows("Id")
            '        oeObli2.MontoInteresCon = rows("MontoInteresCon") + rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli2)
            '        '--------------- se provisiona 4552-cuenta puente LEASING------------------------------
            '        oeAsientoMovimiento2 = New e_AsientoMovimiento
            '        With oeAsientoMovimiento2
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD.Texto2
            '            .Glosa = "REVERSION INTERES OBLIGACION FIN. LEASING " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = 0
            '            .HaberME = 0
            '            .DebeMN = rows("ProvMontoInteres")
            '            .DebeME = rows("ProvMontoInteres") / TipoCambio
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento3.AsientoMovimiento.Add(oeAsientoMovimiento2)
            '        '-----------------------------------------------------------------------------------------------
            '        '--------------- se provisiona interes------------------------------
            '        oeAsientoMovimiento2 = New e_AsientoMovimiento
            '        With oeAsientoMovimiento2
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaContable")
            '            .Glosa = "REVERSION INTERES OBLIGACION FIN. LEASING " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres")
            '            .HaberME = rows("ProvMontoInteres") / TipoCambio
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '        End With
            '        oeAsiento3.AsientoMovimiento.Add(oeAsientoMovimiento2)
            '        '-----------------------------------------------------------------------------------------------
            '    Next

            '    If DtTodos.Rows.Count > 0 Then
            '        Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento3, Nothing, True)
            '    Else
            '        Return True
            '    End If

            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresReversionMensualLeasingDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                 ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresReversionMensualLeasingDolares
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "LEASINGINTERES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH02"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para LEASING-INTERES")
            'End If
            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "IN2"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH02"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)

            'If DtTodos.Rows.Count > 0 Then
            '    '--------------------------------------ASIENTO DE INTERES-----------------------------------------
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    ''-----------cta puente leasing soles------------------------
            '    Dim oeTCD As New e_TablaContableDet
            '    Dim odTCD As New d_TablaContableDet
            '    oeTCD.TipoOperacion = "N"
            '    oeTCD.Activo = True
            '    oeTCD.Nombre = "CUENTAS GENERALES"
            '    oeTCD.Valor1 = Fecha.Year
            '    oeTCD.Texto1 = "CTALEASINGCTAPUENTEDOLARES"
            '    oeTCD = odTCD.Listar(oeTCD)(0)
            '    ''---------------------------------------
            '    '-----------ctaInteres------------------------
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTALEASINGINTERES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------

            '    '------------
            '    Dim TotalSoles As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalSoles = TotalSoles + rows("ProvMontoInteres")
            '    Next

            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------
            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH02"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "LEASINGINTERES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalSoles * TipoCambio
            '        .DebeME = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalSoles
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    'Dim InteresMN As Double = 0
            '    'Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") '+ rows("ProvMontoInteres")
            '        'lsIdObligacion = "'" & oeObli.Id & "',"

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 45212;45211-cuenta LEASING(solo para reversion)------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaContable")
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres") * TipoCambio
            '            .HaberME = rows("ProvMontoInteres")
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    If DtTodos.Rows.Count > 0 Then
            '        odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            '    End If
            '    '----------------------------------------------------------------------------------
            '    '--------------------ASIENTO DE REVERSION------------------------------------------
            '    'lsIdObligacion = Strings.Left(lsIdObligacion, lsIdObligacion.Length - 1)
            '    oeObligFinan = New e_ObligacionFinanciera
            '    oeObligFinan.TipoOperacion = "INL"
            '    oeObligFinan.FechaEmision = DateAdd(DateInterval.Day, -1, Date.Parse("01/" & Month(Fecha) & "/" & Year(Fecha))) 'INTERES DEL MES ANTERIOR
            '    oeObligFinan.IdMoneda = "1CH02"
            '    'oeObligFinan.Id = lsIdObligacion
            '    TotalSoles = 0
            '    DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalSoles = TotalSoles + rows("ProvMontoInteres")
            '    Next

            '    leObligacion = New List(Of e_ObligacionFinanciera)
            '    Dim oeAsiento3 As New e_Asiento
            '    With oeAsiento3
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "REVERSION INTERES OBLIGACION FIN. LEASING "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH02"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "LEASINGINTERES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento2 As New e_AsientoMovimiento
            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli2 As New e_ObligacionFinanciera
            '    'Dim InteresMN2 As Double = 0
            '    'Dim InteresME2 As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento

            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli2 = New e_ObligacionFinanciera
            '        oeObli2.TipoOperacion = "T"
            '        oeObli2.Id = rows("Id")
            '        oeObli2.MontoInteresCon = rows("MontoInteresCon") '+ rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli2)
            '        '--------------- se provisiona 4552-cuenta puente LEASING------------------------------
            '        oeAsientoMovimiento2 = New e_AsientoMovimiento
            '        With oeAsientoMovimiento2
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD.Texto2
            '            .Glosa = "REVERSION INTERES OBLIGACION FIN. LEASING " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = 0
            '            .HaberME = 0
            '            .DebeMN = rows("ProvMontoInteres") * TipoCambio
            '            .DebeME = rows("ProvMontoInteres")
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With

            '        oeAsiento3.AsientoMovimiento.Add(oeAsientoMovimiento2)
            '        '-----------------------------------------------------------------------------------------------
            '        '--------------- se provisiona interes------------------------------
            '        oeAsientoMovimiento2 = New e_AsientoMovimiento
            '        With oeAsientoMovimiento2
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaContable")
            '            .Glosa = "REVERSION INTERES OBLIGACION FIN. LEASING " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres") * TipoCambio
            '            .HaberME = rows("ProvMontoInteres")
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '        End With
            '        oeAsiento3.AsientoMovimiento.Add(oeAsientoMovimiento2)
            '        '-----------------------------------------------------------------------------------------------
            '    Next

            '    If DtTodos.Rows.Count > 0 Then
            '        Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento3, Nothing, True)
            '    Else
            '        Return True
            '    End If

            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualLeasingSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsTipoOperacion As String, _
    ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualLeasingSoles
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera

            'Dim lePeriodo As New List(Of e_Periodo)
            'oePeriodo = New e_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)
            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "LEASINGSOLES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH01"
            'leAsiento2.AddRange(olAsiento.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para LEASING-SOLES")
            'End If
            ''------------
            'Dim dtTodos As DataTable
            'oeObligFinan.TipoOperacion = lsTipoOperacion
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH01"
            'oeObligFinan.Id = lsIdObligacion
            'dtTodos = odObligacionFinanciera.ListarDatable(oeObligFinan)

            'If dtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------cta puente leasing soles------------------------
            '    Dim oeTCD As New e_TablaContableDet
            '    Dim odTCD As New d_TablaContableDet
            '    oeTCD.TipoOperacion = "N"
            '    oeTCD.Activo = True
            '    oeTCD.Nombre = "CUENTAS GENERALES"
            '    oeTCD.Valor1 = Fecha.Year
            '    oeTCD.Texto1 = "CTALEASINGCTAPUENTESOLES"
            '    oeTCD = odTCD.Listar(oeTCD)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres------------------------
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTALEASINGINTERES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------

            '    '------------
            '    Dim TotalSoles As Double = 0
            '    For Each rows As DataRow In dtTodos.Rows
            '        TotalSoles = TotalSoles + rows("ProvMontoInteres")
            '    Next

            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------
            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH01"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "LEASINGSOLES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING " & dtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalSoles
            '        .DebeME = TotalSoles / TipoCambio
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalSoles
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    'Dim InteresMN As Double = 0
            '    'Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In dtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 4552-cuenta puente LEASING------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD.Texto2
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres")
            '            .HaberME = rows("ProvMontoInteres") / TipoCambio
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualLeasingDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsTipoOperacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualLeasingDolares
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera

            'Dim lePeriodo As New List(Of e_Periodo)
            'oePeriodo = New e_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)
            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "LEASINGDOLARES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH02"
            'leAsiento2.AddRange(olAsiento.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para LEASING-DOLARES")
            'End If

            ''------------
            'Dim dtTodos As DataTable
            'oeObligFinan.TipoOperacion = lsTipoOperacion
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH02" 'dOLARES
            'oeObligFinan.Id = lsIdObligacion
            'dtTodos = odObligacionFinanciera.ListarDatable(oeObligFinan)

            'If dtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)
            '    Dim odTCD As New d_TablaContableDet
            '    '-----------cta puente leasing Dolares------------------------
            '    Dim oeTCD1 As New e_TablaContableDet
            '    oeTCD1.TipoOperacion = "N"
            '    oeTCD1.Activo = True
            '    oeTCD1.Nombre = "CUENTAS GENERALES"
            '    oeTCD1.Valor1 = Fecha.Year
            '    oeTCD1.Texto1 = "CTALEASINGCTAPUENTEDOLARES"
            '    oeTCD1 = odTCD.Listar(oeTCD1)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres------------------------
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTALEASINGINTERES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------

            '    Dim TotalDolares As Double = 0
            '    For Each rows As DataRow In dtTodos.Rows
            '        TotalDolares = TotalDolares + rows("ProvMontoInteres")
            '    Next
            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH02"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalDolares / TipoCambio
            '        .TotalHaber = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "LEASINGDOLARES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING " & dtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalDolares * TipoCambio
            '        .DebeME = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalDolares
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With

            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    'Dim InteresMN As Double = 0
            '    'Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In dtTodos.Rows
            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 45522-cuenta puente LEASING------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD1.Texto2
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. LEASING " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres") * TipoCambio
            '            .HaberME = rows("ProvMontoInteres")
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarInteresMensualPagareSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualPagareSoles
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "PAGARESOLES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH01"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para PAGARE-SOLES")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "INP"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH01"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------cta puente leasing soles------------------------
            '    Dim oeTCD As New e_TablaContableDet
            '    Dim odTCD As New d_TablaContableDet
            '    oeTCD.TipoOperacion = "N"
            '    oeTCD.Activo = True
            '    oeTCD.Nombre = "CUENTAS GENERALES"
            '    oeTCD.Valor1 = Fecha.Year
            '    oeTCD.Texto1 = "CTAPAGARECTAPUENTESOLES"
            '    oeTCD = odTCD.Listar(oeTCD)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres------------------------
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTAPAGAREINTERES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalSoles As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalSoles = TotalSoles + rows("ProvMontoInteres")
            '    Next

            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. PAGARE "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH01"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "PAGARESOLES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. PAGARE " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalSoles
            '        .DebeME = TotalSoles / TipoCambio
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalSoles
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 4552-cuenta puente LEASING------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD.Texto2
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. PAGARE " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres")
            '            .HaberME = rows("ProvMontoInteres") / TipoCambio
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualPagareDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualPagareDolares
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "PAGAREDOLARES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH02"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para PAGARE-DOLARES")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "INP"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH02" 'Soles
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)

            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)
            '    Dim odTCD As New d_TablaContableDet
            '    '-----------cta puente leasing Dolares------------------------
            '    Dim oeTCD1 As New e_TablaContableDet
            '    oeTCD1.TipoOperacion = "N"
            '    oeTCD1.Activo = True
            '    oeTCD1.Nombre = "CUENTAS GENERALES"
            '    oeTCD1.Valor1 = Fecha.Year
            '    oeTCD1.Texto1 = "CTAPAGARECTAPUENTEDOLARES"
            '    oeTCD1 = odTCD.Listar(oeTCD1)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres------------------------
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTAPAGAREINTERES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------

            '    Dim TotalDolares As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalDolares = TotalDolares + rows("ProvMontoInteres")
            '    Next
            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. PAGARE "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH02"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalDolares / TipoCambio
            '        .TotalHaber = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "PAGAREDOLARES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. PAGARE " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalDolares * TipoCambio
            '        .DebeME = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalDolares
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows
            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 45522-cuenta puente LEASING------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD1.Texto2
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. PAGARE " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres") * TipoCambio
            '            .HaberME = rows("ProvMontoInteres")
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualFedSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualFedSoles
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "FEDSOLES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH01"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para FED-SOLES")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "FED"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH01"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTAGASTOSFINANCIEROS"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalSoles As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalSoles = TotalSoles + rows("ProvMontoInteres")
            '    Next

            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FED "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH01"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "FEDSOLES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FED " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalSoles
            '        .DebeME = TotalSoles / TipoCambio
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalSoles
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 181-cuenta puente FEDD------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaContableInteres")
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. FED " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres")
            '            .HaberME = rows("ProvMontoInteres") / TipoCambio
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualFedDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualFedDolares
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "FEDDOLARES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH02"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para FED-DOLARES")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "FED"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH02"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTAGASTOSFINANCIEROS"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalsDolares As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalsDolares = TotalsDolares + rows("ProvMontoInteres")
            '    Next

            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FED "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH02"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalsDolares
            '        .TotalHaber = TotalsDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "FEDDOLARES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FED " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalsDolares * TipoCambio
            '        .DebeME = TotalsDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalsDolares
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 181-cuenta puente FEDD------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaContableInteres")
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. FED " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres") * TipoCambio
            '            .HaberME = rows("ProvMontoInteres")
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualFactoringSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
   ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualFactorySoles
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "FACTORINGSOLES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH01"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para FACTORING-SOLES")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "FAC"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH01"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTAGASTOSFINANCIEROS"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalSoles As Double = 0
            '    Dim TotalSolesComisionesPortes As Double = 0
            '    Dim TotalSolesinteres As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalSolesinteres = TotalSolesinteres + rows("ProvMontoInteres")
            '        TotalSolesComisionesPortes = TotalSolesComisionesPortes + rows("ComisionPortes")
            '        TotalSoles = TotalSoles + rows("ProvMontoInteres") + rows("ComisionPortes")
            '    Next

            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FACTORING "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH01"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "FACTORINGSOLES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FACTORING " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalSolesinteres
            '        .DebeME = TotalSolesinteres / TipoCambio
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalSolesinteres
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------
            '    '--------------- se provisiona comosiones y portes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. COMISIONES Y PORTES OBLIGACION FIN. FACTORING " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalSolesComisionesPortes
            '        .DebeME = TotalSolesComisionesPortes / TipoCambio
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 181-cuenta puente FEDD------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaContableInteres")
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. FACTORING " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = (rows("ProvMontoInteres") + rows("ComisionPortes"))
            '            .HaberME = (rows("ProvMontoInteres") + rows("ComisionPortes")) / TipoCambio
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualFactoringDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualFactoryDolares
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "FACTORINGDOLARES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH02"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para FACTORING-DOLARES")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "FAC"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH02"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTAGASTOSFINANCIEROS"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalDolares As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalDolares = TotalDolares + rows("ProvMontoInteres")
            '    Next

            '    '----------------------ASIENTO PROVISION EN DOLARES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FACTORING "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH02"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalDolares
            '        .TotalHaber = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "FACTORINGDOLARES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FACTORING " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalDolares * TipoCambio
            '        .DebeME = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalDolares
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 181-cuenta puente FEDD------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaContableInteres")
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. FACTORING " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres") * TipoCambio
            '            .HaberME = rows("ProvMontoInteres")
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualFecSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualFecSoles
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "FECSOLES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH01"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para FEC-SOLES")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "FEC"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH01"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTAGASTOSFINANCIEROS"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalSoles As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalSoles = TotalSoles + rows("ProvMontoInteres")
            '    Next

            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FEC "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH01"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "FECSOLES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FEC " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalSoles
            '        .DebeME = TotalSoles / TipoCambio
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalSoles
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 181-cuenta puente FEDD------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaContableInteres")
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. FEC " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres")
            '            .HaberME = rows("ProvMontoInteres") / TipoCambio
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualFecDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualFecDolares
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "FECDOLARES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH02"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para FEC-DOLARES")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "FEC"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH02"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTAGASTOSFINANCIEROS"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalDolares As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalDolares = TotalDolares + rows("ProvMontoInteres")
            '    Next

            '    '----------------------ASIENTO PROVISION EN DOLARES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FEC "
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH02"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalDolares
            '        .TotalHaber = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "FECDOLARES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. FEC " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalDolares * TipoCambio
            '        .DebeME = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalDolares
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("ProvMontoInteres")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 181-cuenta puente FEDD------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaContableInteres")
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. FEC " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("ProvMontoInteres") * TipoCambio
            '            .HaberME = rows("ProvMontoInteres")
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualProvisionCrediHipoSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
   ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualProvisionCrediHipoSoles
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "CHPSOLES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH01"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento de provisión de interes para Credito-Hipo")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "CHP"
            'oeObligFinan.FechaEmision = Fecha.AddMonths(1)
            'oeObligFinan.IdMoneda = "1CH01"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres 67------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTACREDITOHIPOINTERESSOLES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres 45------------------------
            '    Dim oeTCD45 As New e_TablaContableDet
            '    oeTCD45.TipoOperacion = "N"
            '    oeTCD45.Activo = True
            '    oeTCD45.Nombre = "CUENTAS GENERALES"
            '    oeTCD45.Valor1 = Fecha.Year
            '    oeTCD45.Texto1 = "CTAPUENTECREDITOHIPOSOLES"
            '    oeTCD45 = odTCD.Listar(oeTCD45)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalSoles As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalSoles = TotalSoles + rows("Devengado")
            '    Next

            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. CREDITO HIPOTECARIO"
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH01"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "CHPSOLES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes total del asiento tipo 6------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalSoles
            '        .DebeME = TotalSoles / TipoCambio
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalSoles
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("Devengado")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 45------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD45.Texto2
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("Devengado")
            '            .HaberME = rows("Devengado") / TipoCambio
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualProvisionCrediHipoDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualProvisionCrediHipoDolares
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "CHPDOLARES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH02"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento de provisión de interes para Credito-Hipo")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "CHP"
            'oeObligFinan.FechaEmision = Fecha.AddMonths(1)
            'oeObligFinan.IdMoneda = "1CH02"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres 67------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTACREDITOHIPOINTERESDOLARES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres 45------------------------
            '    Dim oeTCD45 As New e_TablaContableDet
            '    oeTCD45.TipoOperacion = "N"
            '    oeTCD45.Activo = True
            '    oeTCD45.Nombre = "CUENTAS GENERALES"
            '    oeTCD45.Valor1 = Fecha.Year
            '    oeTCD45.Texto1 = "CTAPUENTECREDITOHIPODOLARES"
            '    oeTCD45 = odTCD.Listar(oeTCD45)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalDolares As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalDolares = TotalDolares + rows("Devengado")
            '    Next

            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. CREDITO HIPOTECARIO"
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH02"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalDolares
            '        .TotalHaber = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "CHPDOLARES" & lsIdObligacion
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona interes total del asiento tipo 6------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeTCD2.Texto2
            '        .Glosa = "PROV. INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & DtTodos.Rows(0).Item("Banco")
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = TotalDolares * TipoCambio
            '        .DebeME = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .Activo = True
            '        .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '        Dim oeMovAnalisis As New e_MovimientoAnalisis
            '        oeMovAnalisis.TipoOperacion = "I"
            '        oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '        oeMovAnalisis.Monto = TotalDolares
            '        oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '        .MovimientoAnalisis.Add(oeMovAnalisis)
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For Each rows As DataRow In DtTodos.Rows

            '        oeObli = New e_ObligacionFinanciera
            '        oeObli.TipoOperacion = "T"
            '        oeObli.Id = rows("Id")
            '        oeObli.MontoInteresCon = rows("MontoInteresCon") + rows("Devengado")

            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 45------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD45.Texto2
            '            .Glosa = "PROV. INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("Devengado") * TipoCambio
            '            .HaberME = rows("Devengado")
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualPuenteCrediHipoSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
   ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualPuenteCrediHipoSoles
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "CH-SOLES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH01"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para para Credito-Hipo")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "CHP"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH01"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres 67------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTACREDITOHIPOINTERESSOLES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres 45------------------------
            '    Dim oeTCD45 As New e_TablaContableDet
            '    oeTCD45.TipoOperacion = "N"
            '    oeTCD45.Activo = True
            '    oeTCD45.Nombre = "CUENTAS GENERALES"
            '    oeTCD45.Valor1 = Fecha.Year
            '    oeTCD45.Texto1 = "CTAPUENTECREDITOHIPOSOLES"
            '    oeTCD45 = odTCD.Listar(oeTCD45)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalSoles As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalSoles = TotalSoles + rows("Devengado") + rows("DiferenciaDevengado")
            '    Next
            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "DIARIO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO"
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH01"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "CH-SOLES" & lsIdObligacion
            '    End With

            '    'Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    Dim oeAsientoMovimiento45A As New e_AsientoMovimiento
            '    Dim oeAsientoMovimiento67 As New e_AsientoMovimiento
            '    Dim oeAsientoMovimiento45B As New e_AsientoMovimiento
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows

            '        '--------------- 45A------------------------------
            '        oeAsientoMovimiento45A = New e_AsientoMovimiento
            '        With oeAsientoMovimiento45A
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD45.Texto2
            '            .Glosa = "DIARIO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = 0
            '            .HaberME = 0
            '            .DebeMN = rows("Devengado")
            '            .DebeME = rows("Devengado") / TipoCambio
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento45A)

            '        '--------------- 67-------------------------------------------------------------
            '        oeAsientoMovimiento67 = New e_AsientoMovimiento
            '        With oeAsientoMovimiento67
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaInteres")
            '            .Glosa = "DIARIO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = 0
            '            .HaberME = 0
            '            .DebeMN = rows("DiferenciaDevengado")
            '            .DebeME = rows("DiferenciaDevengado") / TipoCambio
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True

            '            .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '            Dim oeMovAnalisis As New e_MovimientoAnalisis
            '            oeMovAnalisis.TipoOperacion = "I"
            '            oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '            oeMovAnalisis.Monto = rows("Devengado")
            '            oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '            .MovimientoAnalisis.Add(oeMovAnalisis)

            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento67)
            '        '--------------- 45B-----------------------------------------------------------
            '        oeAsientoMovimiento45B = New e_AsientoMovimiento
            '        With oeAsientoMovimiento45B
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD45.Texto2
            '            .Glosa = "DIARIO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("Devengado") + rows("DiferenciaDevengado")
            '            .HaberME = (rows("Devengado") + rows("DiferenciaDevengado")) / TipoCambio
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento45B)

            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualPuenteCrediHipoDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
   ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualPuenteCrediHipoDolares
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "CH-DOLARES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH02"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para para Credito-Hipo")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "CHP"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH02"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres 67------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTACREDITOHIPOINTERESDOLARES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres 45------------------------
            '    Dim oeTCD45 As New e_TablaContableDet
            '    oeTCD45.TipoOperacion = "N"
            '    oeTCD45.Activo = True
            '    oeTCD45.Nombre = "CUENTAS GENERALES"
            '    oeTCD45.Valor1 = Fecha.Year
            '    oeTCD45.Texto1 = "CTAPUENTECREDITOHIPODOLARES"
            '    oeTCD45 = odTCD.Listar(oeTCD45)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalDolares As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalDolares = TotalDolares + rows("Devengado") + rows("DiferenciaDevengado")
            '    Next
            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "DIARIO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO"
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH02"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalDolares
            '        .TotalHaber = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "CH-SOLES" & lsIdObligacion
            '    End With

            '    'Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    Dim oeAsientoMovimiento45A As New e_AsientoMovimiento
            '    Dim oeAsientoMovimiento67 As New e_AsientoMovimiento
            '    Dim oeAsientoMovimiento45B As New e_AsientoMovimiento
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows

            '        '--------------- 45A------------------------------
            '        oeAsientoMovimiento45A = New e_AsientoMovimiento
            '        With oeAsientoMovimiento45A
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD45.Texto2
            '            .Glosa = "DIARIO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = 0
            '            .HaberME = 0
            '            .DebeMN = rows("Devengado") * TipoCambio
            '            .DebeME = rows("Devengado")
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento45A)

            '        '--------------- 67-------------------------------------------------------------
            '        oeAsientoMovimiento67 = New e_AsientoMovimiento
            '        With oeAsientoMovimiento67
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = rows("IdCuentaInteres")
            '            .Glosa = "DIARIO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = 0
            '            .HaberME = 0
            '            .DebeMN = rows("DiferenciaDevengado") * TipoCambio
            '            .DebeME = rows("DiferenciaDevengado")
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True

            '            .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
            '            Dim oeMovAnalisis As New e_MovimientoAnalisis
            '            oeMovAnalisis.TipoOperacion = "I"
            '            oeMovAnalisis.IdGastoFuncion = "1CH000090"
            '            oeMovAnalisis.Monto = rows("DiferenciaDevengado")
            '            oeMovAnalisis.Saldo = oeMovAnalisis.Monto
            '            .MovimientoAnalisis.Add(oeMovAnalisis)

            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento67)
            '        '--------------- 45B-----------------------------------------------------------
            '        oeAsientoMovimiento45B = New e_AsientoMovimiento
            '        With oeAsientoMovimiento45B
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD45.Texto2
            '            .Glosa = "DIARIO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = (rows("Devengado") + rows("DiferenciaDevengado")) * TipoCambio
            '            .HaberME = rows("Devengado") + rows("DiferenciaDevengado")
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento45B)

            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarPagarePrestamo(ByVal oeObligacionFinanciera As EntidadesWCF.e_ObligacionFinanciera, _
                                   ByVal oeCuentaBancaria As EntidadesWCF.e_CuentaBancaria, _
                                   ByVal o_Oblig() As Object, ByVal lsTipo As String) As Boolean Implements Il_ObligacionFinanciera.GuardarPagarePrestamo
        Try
            'Dim CodigoUnico As String = Date.Now.Year.ToString + Strings.Right("0" + Date.Now.Month.ToString, 2) + Strings.Right("0" + Date.Now.Day.ToString, 2) + Strings.Right("0" + Date.Now.Hour.ToString, 2) _
            '+ Strings.Right("0" + Date.Now.Minute.ToString, 2) + Strings.Right("0" + Date.Now.Second.ToString, 2) + Strings.Right("0" + Date.Now.Millisecond.ToString, 2)
            ''lsTipo = PAGARE
            ''lsTipo = PRESTAMO
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'If Validar(oeObligacionFinanciera, lsTipo) Then
            '    '--------------recupera id de PAGARE------------------
            '    Dim oeTipoDoc As New e_TipoDocumento
            '    Dim odTipoDoc As New d_TipoDocumento
            '    oeTipoDoc.Nombre = lsTipo
            '    oeTipoDoc.TipoOperacion = "L"
            '    oeTipoDoc = odTipoDoc.Obtener(oeTipoDoc)
            '    oeObligacionFinanciera.IdTipoObligacion = oeTipoDoc.Id
            '    '-----------ctaPAGARE------------------------
            '    Dim oeTCD As New e_TablaContableDet
            '    Dim odTCD As New d_TablaContableDet
            '    oeTCD.TipoOperacion = "N"
            '    oeTCD.Activo = True
            '    oeTCD.Nombre = "CUENTAS GENERALES"
            '    oeTCD.Valor1 = oeObligacionFinanciera.FechaEmision.Year
            '    If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'soles(codigo de sunat)
            '        oeTCD.Texto1 = "CTA" & lsTipo & "SOLES"
            '    Else
            '        oeTCD.Texto1 = "CTA" & lsTipo & "DOLARES"
            '    End If
            '    oeTCD = odTCD.Listar(oeTCD)(0)
            '    oeObligacionFinanciera.IdCuentaContable = oeTCD.Texto2
            '    '---------------------------------------
            '    '-----------ctaINTERES------------------------
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = oeObligacionFinanciera.FechaEmision.Year
            '    If lsTipo = "PAGARE" Then
            '        oeTCD2.Texto1 = "CTAPAGAREINTERES"
            '    ElseIf lsTipo = "PRESTAMO" Then
            '        oeTCD2.Texto1 = "CTAGASTOSFINANCIEROS"
            '    End If
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    oeObligacionFinanciera._IdCuentaContableInteres = oeTCD2.Texto2
            '    '---------------------------------------

            '    '----------------------ASIENTO DE CAPITAL--------------------------
            '    Dim oePeriodo As New e_Periodo
            '    Dim lePeriodo As New List(Of e_Periodo)
            '    Dim olPeriodo As New l_Periodo
            '    oePeriodo.Activo = True
            '    oePeriodo.Id = ""
            '    oePeriodo.Codigo = oeObligacionFinanciera.FechaEmision.Year.ToString + "-" + oeObligacionFinanciera.FechaEmision.Month.ToString
            '    lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "BANCO"
            '        .Fecha = oeObligacionFinanciera.FechaEmision
            '        .Glosa = "OBLIGACION FIN. " & lsTipo & " " & oeObligacionFinanciera._NombreBanco
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = oeObligacionFinanciera.IdMoneda
            '        .TipoCambio = oeObligacionFinanciera.TipoCambio
            '        If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
            '            .TotalDebe = oeObligacionFinanciera._MontoMNSinInteres
            '            .TotalHaber = oeObligacionFinanciera._MontoMNSinInteres
            '        Else
            '            .TotalDebe = oeObligacionFinanciera._MontoMESinInteres
            '            .TotalHaber = oeObligacionFinanciera._MontoMESinInteres
            '        End If
            '        .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '    End With

            '    Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    '--------------- se provisiona 104-cuenta bancaria------------------------------
            '    With oeAsientoMovimiento
            '        .TipoOperacion = "I"
            '        .IdCuentaContable = oeCuentaBancaria.IdCuentaContable
            '        .Glosa = "OBLIGACION FIN. " & lsTipo & " " & oeObligacionFinanciera._NombreBanco
            '        .HaberMN = 0
            '        .HaberME = 0
            '        .DebeMN = oeObligacionFinanciera._MontoMNSinInteres
            '        .DebeME = oeObligacionFinanciera._MontoMESinInteres
            '        .IdUsuarioCrea = oeObligacionFinanciera.UsuarioCreacion
            '        .Activo = True
            '        With .MovimientoCajaBanco
            '            .TipoOperacion = "I"
            '            .IdFlujoCaja = "1CH000000193" 'PRESTAMO DE INSTITUCIONES FINANCIERAS
            '            .NroBoucher = ""
            '            .IdCuentaBancaria = oeCuentaBancaria.Id
            '            .Fecha = oeObligacionFinanciera.FechaEmision
            '            .IdMedioPago = "1CH02" 'DEPOSITO EN CUENTA
            '            .IdPeriodoConcilia = ""
            '            .Activo = True
            '            .TipoCambio = oeObligacionFinanciera.TipoCambio
            '            .TotalMN = oeObligacionFinanciera._MontoMNSinInteres
            '            .TotalME = oeObligacionFinanciera._MontoMESinInteres
            '            ._Operador = 1
            '        End With
            '    End With
            '    oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '    '-----------------------------------------------------------------------------------------------

            '    '------recorremos obj que trae obligacion--------
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    'Dim oeAsientoMovimientoInteres As New e_AsientoMovimiento
            '    For i As Integer = 0 To o_Oblig.Length - 1
            '        'obj(0) = o_o.CodigoBanco
            '        'obj(1) = o_o.Monto
            '        'obj(2) = o_o.FechaVencimiento
            '        'obj(3) = o_o.TasaInteres
            '        'obj(4) = o_o.MontoInteres
            '        'obj(5) = o_o.Comision
            '        'obj(6) = o_o.Gastos
            '        'obj(7) = FechaAnterior
            '        'obj(8) = cuota
            '        'obj(9) = nrocuotas
            '        oeObli = New e_ObligacionFinanciera
            '        oeObli = oeObligacionFinanciera.Clone
            '        oeObli.CodigoUnico = CodigoUnico
            '        oeObli.Codigo = o_Oblig(i)(0)
            '        oeObli.Saldo = o_Oblig(i)(1)
            '        If oeObligacionFinanciera.IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
            '            oeObli.MontoMN = o_Oblig(i)(1)
            '            oeObli.MontoME = o_Oblig(i)(1) / oeObligacionFinanciera.TipoCambio
            '        Else
            '            oeObli.MontoMN = o_Oblig(i)(1) * oeObligacionFinanciera.TipoCambio
            '            oeObli.MontoME = o_Oblig(i)(1)
            '        End If
            '        oeObli.FechaVencimiento = o_Oblig(i)(2)
            '        oeObli.TasaInteres = o_Oblig(i)(3)
            '        oeObli.MontoInteresTes = o_Oblig(i)(4)
            '        oeObli.Comision = o_Oblig(i)(5)
            '        oeObli.Gastos = o_Oblig(i)(6)
            '        oeObli.FechaInicial = IIf(o_Oblig(i)(7) = Date.Parse("01/01/1901"), oeObligacionFinanciera.FechaEmision, o_Oblig(i)(7))
            '        oeObli.Cuota = o_Oblig(i)(8)
            '        oeObli.NroCuotas = o_Oblig(i)(9)
            '        leObligacion.Add(oeObli)
            '        '--------------- se provisiona 4544-cuenta PAGARE------------------------------
            '        oeAsientoMovimiento = New e_AsientoMovimiento
            '        With oeAsientoMovimiento
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeObli.IdCuentaContable
            '            .Glosa = "OBLIGACION FIN. " & lsTipo & " " & oeObli.Codigo & "/" & oeObligacionFinanciera._NombreBanco
            '            .HaberMN = oeObli.MontoMN
            '            .HaberME = oeObli.MontoME
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = oeObli.UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = oeObli.Id
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '            '---------------------------------------------------------------------------
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '        '-----------------------------------------------------------------------------------------------
            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing)

            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarPagoObligacion(ByVal leDocumentosAgregados As System.Collections.Generic.List(Of EntidadesWCF.e_ObligacionFinanciera), ByVal fecha As Date) As Object Implements Il_ObligacionFinanciera.ValidarPagoObligacion
        Try
            Dim loFuncionesGenerales As New l_FuncionesGenerales

            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, fecha, fecha.Year.ToString + "-" + fecha.Month.ToString)
            loFuncionesGenerales.ValidarDatosDeObligacionExistente(leDocumentosAgregados)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarPago(ByVal leMovDocAgregado As System.Collections.Generic.List(Of EntidadesWCF.e_ObligacionFinanciera), _
                                ByRef oeMovCajaBanco As EntidadesWCF.e_MovimientoCajaBanco, _
                                ByVal oeMedioPago As EntidadesWCF.e_MedioPago, ByVal idUsuario As String, _
                                ByVal MacLocal As String, ByVal oeCtaCble As EntidadesWCF.e_CuentaContable) As Boolean Implements Il_ObligacionFinanciera.GuardarPago
        Try
            Dim oeAsMov As e_AsientoMovimiento
            Dim oeAsMovInteres As e_AsientoMovimiento
            Dim oeAsMovInteresMoratorio As e_AsientoMovimiento
            Dim oeAsiento As New e_Asiento
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            Dim odAsiento As New d_Asiento

            If ValidarPagoObligacion(leMovDocAgregado, oeMovCajaBanco.Fecha) Then
                oeAsiento = New e_Asiento 'Asigno los datos al asiento
                With oeAsiento
                    'Obtener el periodo deacuerdo a la fecha ingresada en el Formulario Cobranza
                    oePeriodo.Ejercicio = oeMovCajaBanco.Fecha.Year
                    oePeriodo.Mes = oeMovCajaBanco.Fecha.Month
                    .IdPeriodo = olPeriodo.Obtener(oePeriodo).Id 'Prueba no admite campo nulos
                    .IdTipoAsiento = oeMedioPago.IdTipoAsiento 'Asigno el tipo de asiento guardado en la TablaContableDetalle, 
                    .NroAsiento = "" 'Se genera
                    .Fecha = oeMovCajaBanco.Fecha
                    If leMovDocAgregado.Count > 1 Then 'Depeden de la cantidad de documentos a cobrar
                        .Glosa = "PAGO DCMTOS. VARIOS " & oeMedioPago.Abreviatura & "/" & leMovDocAgregado.Item(0)._NombreBanco
                        .GlosaImprime = .Glosa
                    ElseIf leMovDocAgregado.Count = 1 Then
                        .Glosa = "PAGO " & leMovDocAgregado.Item(0)._NombreObligacion & "/" & leMovDocAgregado.Item(0).Codigo & " " & leMovDocAgregado.Item(0)._NombreBanco
                        .GlosaImprime = .Glosa
                    End If

                    'Se obtiene el IdMoneda dependiendo de la Cuenta COntable
                    If oeCtaCble.MonedaExtrangera = 0 Then
                        .IdMoneda = "1CH01"
                    Else
                        .IdMoneda = "1CH02"
                    End If
                    .TipoCambio = oeMovCajaBanco.TipoCambio 'Obtener Tipo de Cambio del Objeto MovCajaBanco DecTC.Value
                    'Total Debe y Total Haber depende de la Moneda
                    .TotalDebe = IIf(.IdMoneda = "1CH01", oeMovCajaBanco.TotalMN, oeMovCajaBanco.TotalME) 'Soles
                    .TotalHaber = .TotalDebe 'Debe = Haber
                    .IdUsuarioCrea = idUsuario 'Pedir parametro
                    .IdEstado = "CUADRADO"
                    .Activo = True
                    .TipoOperacion = "I"

                End With

                Dim leLista As New List(Of e_AsientoMovimiento)
                ''Detalle
                For Each oeObligacion As e_ObligacionFinanciera In leMovDocAgregado
                    If oeObligacion.IdTipoObligacion = "1CH000000074" Then 'PRESTAMO
                        'If oeObligacion.IdMoneda = "1CH01" Then
                        '    GuardarInteresMensualPagareSoles(Date.Parse("01/" + oeMovCajaBanco.Fecha.Month.ToString + _
                        '    "/" + oeMovCajaBanco.Fecha.Year.ToString), oeMovCajaBanco.TipoCambio, idUsuario, oeObligacion.Id)
                        'ElseIf oeObligacion.IdMoneda = "1CH02" Then
                        '    GuardarInteresMensualPagareDolares(Date.Parse("01/" + oeMovCajaBanco.Fecha.Month.ToString + _
                        '    "/" + oeMovCajaBanco.Fecha.Year.ToString), oeMovCajaBanco.TipoCambio, idUsuario, oeObligacion.Id)
                        'End If
                    End If
                    If oeObligacion.IdTipoObligacion = "1CH000000069" And oeObligacion._ExcluyeInteres = False Then 'PAGARES
                        If oeObligacion.IdMoneda = "1CH01" Then
                            GuardarInteresMensualPagareSoles(Date.Parse("01/" + oeMovCajaBanco.Fecha.Month.ToString + _
                            "/" + oeMovCajaBanco.Fecha.Year.ToString), oeMovCajaBanco.TipoCambio, idUsuario, oeObligacion.Id, oeMovCajaBanco.Fecha)
                        ElseIf oeObligacion.IdMoneda = "1CH02" Then
                            GuardarInteresMensualPagareDolares(Date.Parse("01/" + oeMovCajaBanco.Fecha.Month.ToString + _
                            "/" + oeMovCajaBanco.Fecha.Year.ToString), oeMovCajaBanco.TipoCambio, idUsuario, oeObligacion.Id, oeMovCajaBanco.Fecha)
                        End If
                    End If
                    If oeObligacion.IdTipoObligacion = "1CH000000066" Then 'FACT AL DESC
                        If oeObligacion.IdMoneda = "1CH01" Then
                            GuardarInteresMensualFactoringSoles(Date.Parse("01/" + oeMovCajaBanco.Fecha.Month.ToString + _
                            "/" + oeMovCajaBanco.Fecha.Year.ToString), oeMovCajaBanco.TipoCambio, idUsuario, oeObligacion.Id, oeMovCajaBanco.Fecha)
                        ElseIf oeObligacion.IdMoneda = "1CH02" Then
                            GuardarInteresMensualFactoringDolares(Date.Parse("01/" + oeMovCajaBanco.Fecha.Month.ToString + _
                            "/" + oeMovCajaBanco.Fecha.Year.ToString), oeMovCajaBanco.TipoCambio, idUsuario, oeObligacion.Id, oeMovCajaBanco.Fecha)
                        End If
                    End If
                    If oeObligacion.IdTipoObligacion = "1CH000000068" Then 'FEDD
                        If oeObligacion.IdMoneda = "1CH01" Then
                            GuardarInteresMensualFedSoles(Date.Parse("01/" + oeMovCajaBanco.Fecha.Month.ToString + _
                            "/" + oeMovCajaBanco.Fecha.Year.ToString), oeMovCajaBanco.TipoCambio, idUsuario, oeObligacion.Id, oeMovCajaBanco.Fecha)
                        ElseIf oeObligacion.IdMoneda = "1CH02" Then
                            GuardarInteresMensualFedDolares(Date.Parse("01/" + oeMovCajaBanco.Fecha.Month.ToString + _
                            "/" + oeMovCajaBanco.Fecha.Year.ToString), oeMovCajaBanco.TipoCambio, idUsuario, oeObligacion.Id, oeMovCajaBanco.Fecha)
                        End If
                    End If
                    If oeObligacion.IdTipoObligacion = "1CH000000065" Then 'FEC
                        If oeObligacion.IdMoneda = "1CH01" Then
                            GuardarInteresMensualFecSoles(Date.Parse("01/" + oeMovCajaBanco.Fecha.Month.ToString + _
                            "/" + oeMovCajaBanco.Fecha.Year.ToString), oeMovCajaBanco.TipoCambio, idUsuario, oeObligacion.Id, oeMovCajaBanco.Fecha)
                        ElseIf oeObligacion.IdMoneda = "1CH02" Then
                            GuardarInteresMensualFecDolares(Date.Parse("01/" + oeMovCajaBanco.Fecha.Month.ToString + _
                            "/" + oeMovCajaBanco.Fecha.Year.ToString), oeMovCajaBanco.TipoCambio, idUsuario, oeObligacion.Id, oeMovCajaBanco.Fecha)
                        End If
                    End If
                    oeAsMov = New e_AsientoMovimiento 'Detalles AsientoMovimiento
                    oeAsMovInteres = New e_AsientoMovimiento 'Detalles AsientoMovimiento
                    With oeObligacion
                        'Asignar datos a tabla CuentaxCyP
                        .oeObligacionPago = New e_ObligacionPago
                        .oeObligacionPago.IdObligacionFinanciera = .Id
                        .oeObligacionPago.TipoOperacion = "I" 'Tipo Insertar
                        .oeObligacionPago.NroCuota = .NroCuotas
                        .oeObligacionPago.FechaFinal = oeMovCajaBanco.Fecha
                        .oeObligacionPago.FechaInicial = oeObligacion.FechaVencimiento
                        .oeObligacionPago.Activo = True
                        .oeObligacionPago.IndCancelado = True
                        .oeObligacionPago.UsuarioCreacion = idUsuario
                        .oeObligacionPago.MacPCLocalCreacion = MacLocal
                        Dim DecTC As Double = oeMovCajaBanco.TipoCambio 'Asigno el tipo de cmabio a una variable

                        'Asigno el monto pagado dependiendo si es soles o dolares
                        If oeObligacion.IdMoneda = "1CH01" Then 'Si es soles la moneda
                            .oeObligacionPago.MontoFinalMN = .MontoOperar
                            .oeObligacionPago.MontoInicialMN = .oeObligacionPago.MontoFinalMN
                            oeAsMov.DebeMN = .MontoOperar
                            .oeObligacionPago.MontoFinalME = .MontoOperar / DecTC
                            .oeObligacionPago.MontoInicialME = .oeObligacionPago.MontoFinalME
                            oeAsMov.DebeME = .MontoOperar / DecTC
                            If oeObligacion.IdTipoObligacion = "1CH000000065" Then 'FEc  en total viene icliudo interes
                                oeAsMov.DebeMN = .MontoOperar - .MontoInteresTes
                                oeAsMov.DebeME = (.MontoOperar - .MontoInteresTes) / DecTC
                            End If
                        Else 'Moneda extranjera
                            .oeObligacionPago.MontoFinalMN = .MontoOperar * DecTC
                            .oeObligacionPago.MontoInicialMN = .oeObligacionPago.MontoFinalMN
                            oeAsMov.DebeMN = .MontoOperar * DecTC
                            .oeObligacionPago.MontoFinalME = .MontoOperar
                            .oeObligacionPago.MontoInicialME = .oeObligacionPago.MontoFinalME
                            oeAsMov.DebeME = .MontoOperar
                            If oeObligacion.IdTipoObligacion = "1CH000000065" Then 'FEc en total viene icliudo interes
                                oeAsMov.DebeMN = (.MontoOperar - .MontoInteresTes) * DecTC
                                oeAsMov.DebeME = .MontoOperar - .MontoInteresTes
                            End If
                        End If
                        oeObligacion.Saldo = oeObligacion.Saldo - oeObligacion.MontoOperar  'Asigno la resta del monto cobrado con el saldo
                        .TipoOperacion = "S" 'Se actualiza el saldo del documento
                        oeAsMov.ObligacionFinanciera = oeObligacion

                        ''Relacion AsientoMov_MovDoc
                        .oeObligacionPago.OeAsientoMov_ObligFin = New e_AsientoMov_ObligacionFin
                        With .oeObligacionPago.OeAsientoMov_ObligFin
                            .IdObligacionFinanciera = oeObligacion.Id
                            .TipoOperacion = "I"
                            .Activo = True
                        End With
                        'Asignar datos a Detalles
                        oeAsMov.IdCuentaContable = .IdCuentaContable 'Sele asigna el id de la cuena Contable
                        'Se le asigna glosa con el mismo formato
                        oeAsMov.Glosa = "PAGO " & ._NombreObligacion & "/" & .Codigo & " " & ._NombreBanco
                        oeAsMov.IdUsuarioCrea = idUsuario 'gUsuarioSGI.Id
                        oeAsMov.Activo = True
                        oeAsMov.TipoOperacion = "I"
                        oeAsMov.IdCuentaContable = oeObligacion.IdCuentaContable 'Asigno la cuenta contable del Movimiento
                        oeAsMov.MovimientoCajaBanco = Nothing 'MovCajaBanco se genera junto con la cabecera
                        'agrego a la lista los detalles
                        leLista.Add(oeAsMov)
                        If oeObligacion.IdTipoObligacion = "1CH000000069" _
                        Or oeObligacion.IdTipoObligacion = "1CH000000074" Then ' pagares o prestamos
                            Dim lban As Boolean = True
                            If oeObligacion.IdTipoObligacion = "1CH000000069" Then
                                If oeObligacion._ExcluyeInteres Then
                                    lban = False
                                End If
                            End If
                            If lban Then
                                If oeObligacion.IdMoneda = "1CH01" Then 'Si es soles la moneda
                                    oeMovCajaBanco.TotalMN = oeMovCajaBanco.TotalMN + .MontoInteresTes
                                    oeMovCajaBanco.TotalME = oeMovCajaBanco.TotalME + .MontoInteresTes / DecTC
                                Else
                                    oeMovCajaBanco.TotalMN = oeMovCajaBanco.TotalMN + .MontoInteresTes * DecTC
                                    oeMovCajaBanco.TotalME = oeMovCajaBanco.TotalME + .MontoInteresTes
                                End If
                            End If

                        End If
                        If oeObligacion.IdTipoObligacion = "1CH000000069" _
                        Or oeObligacion.IdTipoObligacion = "1CH000000074" Or _
                        oeObligacion.IdTipoObligacion = "1CH000000065" Then ' pagares o prestamos o fec 
                            Dim lban2 As Boolean = True
                            If oeObligacion.IdTipoObligacion = "1CH000000069" Then
                                If oeObligacion._ExcluyeInteres Then
                                    lban2 = False
                                End If
                            End If
                            If lban2 Then
                                If oeObligacion.IdMoneda = "1CH01" Then 'Si es soles la moneda
                                    oeAsMovInteres.DebeMN = .MontoInteresTes
                                    oeAsMovInteres.DebeME = .MontoInteresTes / DecTC
                                Else
                                    oeAsMovInteres.DebeMN = .MontoInteresTes * DecTC
                                    oeAsMovInteres.DebeME = .MontoInteresTes
                                End If
                                'Se le asigna glosa con el mismo formato
                                oeAsMovInteres.Glosa = "PAGO " & ._NombreObligacion & "/" & .Codigo & " " & ._NombreBanco
                                oeAsMovInteres.IdUsuarioCrea = idUsuario 'gUsuarioSGI.Id
                                oeAsMovInteres.Activo = True
                                oeAsMovInteres.TipoOperacion = "I"
                                If oeObligacion.IdTipoObligacion = "1CH000000069" _
                                Or oeObligacion.IdTipoObligacion = "1CH000000074" Then 'pagares o prestamos
                                    oeAsiento.TotalDebe = oeAsiento.TotalDebe + IIf(oeAsiento.IdMoneda = "1CH01", oeAsMovInteres.DebeMN, oeAsMovInteres.DebeME)
                                    oeAsiento.TotalHaber = oeAsiento.TotalDebe
                                    If oeObligacion.IdTipoObligacion = "1CH000000069" Then 'PAGARE
                                        '-----------cta puente leasing soles------------------------
                                        Dim oeTCD As New e_TablaContableDet
                                        Dim odTCD As New d_TablaContableDet
                                        oeTCD.TipoOperacion = "N"
                                        oeTCD.Activo = True
                                        oeTCD.Nombre = "CUENTAS GENERALES"
                                        oeTCD.Valor1 = oeMovCajaBanco.Fecha.Year
                                        If oeObligacion.IdMoneda = "1CH01" Then
                                            oeTCD.Texto1 = "CTAPAGARECTAPUENTESOLES"
                                        Else
                                            oeTCD.Texto1 = "CTAPAGARECTAPUENTEDOLARES"
                                        End If
                                        oeTCD = odTCD.Listar(oeTCD)(0)
                                        '---------------------------------------
                                        oeAsMovInteres.IdCuentaContable = oeTCD.Texto2  'Asigno la cuenta contable del Movimiento
                                    Else
                                        ''CTA PUENTE PRESTAMO----
                                        oeAsMovInteres.IdCuentaContable = oeObligacion._IdCuentaContableInteres  'Asigno la cuenta contable del Movimiento
                                    End If

                                Else
                                    oeAsMovInteres.IdCuentaContable = oeObligacion._IdCuentaContableInteres  'Asigno la cuenta contable del Movimiento
                                End If
                                oeAsMovInteres.MovimientoCajaBanco = Nothing 'MovCajaBanco se genera junto con la cabecera
                                oeAsMovInteres.AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                                With oeAsMovInteres.AsMov_ObligacionFin
                                    .TipoOperacion = "I"
                                    .IdAsientoMovimiento = ""
                                    .IdObligacionFinanciera = oeObligacion.Id
                                    .Activo = True
                                End With
                                leLista.Add(oeAsMovInteres)
                            End If

                            '------------------------------interes moratorio------------
                            If oeObligacion.MontoInteresMoratorio > 0 Then ' Fec, Facturas al desc , pagare
                                oeAsMovInteresMoratorio = New e_AsientoMovimiento
                                If oeObligacion.IdMoneda = "1CH01" Then 'Si es soles la moneda
                                    oeAsMovInteresMoratorio.DebeMN = .MontoInteresMoratorio
                                    oeAsMovInteresMoratorio.DebeME = .MontoInteresMoratorio / DecTC
                                Else
                                    oeAsMovInteresMoratorio.DebeMN = .MontoInteresMoratorio * DecTC
                                    oeAsMovInteresMoratorio.DebeME = .MontoInteresMoratorio
                                End If
                                'Se le asigna glosa con el mismo formato
                                oeAsMovInteresMoratorio.Glosa = "INTERES MORATORIO " & ._NombreObligacion & "/" & .Codigo & " " & ._NombreBanco
                                oeAsMovInteresMoratorio.IdUsuarioCrea = idUsuario 'gUsuarioSGI.Id
                                oeAsMovInteresMoratorio.Activo = True
                                oeAsMovInteresMoratorio.TipoOperacion = "I"
                                '-----------cta puente Ineteres------------------------
                                Dim oeTCDIMo As New e_TablaContableDet
                                Dim odTCDIMo As New d_TablaContableDet
                                oeTCDIMo.TipoOperacion = "N"
                                oeTCDIMo.Activo = True
                                oeTCDIMo.Nombre = "CUENTAS GENERALES"
                                oeTCDIMo.Valor1 = oeMovCajaBanco.Fecha.Year
                                If oeObligacion.IdTipoObligacion = "1CH000000069" Then 'PAGARE
                                    oeTCDIMo.Texto1 = "CTA_INTMORATORIOPAGARE"
                                Else
                                    oeTCDIMo.Texto1 = "CTAGASTOSFINANCIEROS"
                                End If

                                oeTCDIMo = odTCDIMo.Listar(oeTCDIMo)(0)
                                '---------------------------------------
                                oeAsMovInteresMoratorio.IdCuentaContable = oeTCDIMo.Texto2  'Asigno la cuenta contable del Movimiento
                                oeAsMovInteresMoratorio.MovimientoCajaBanco = Nothing 'MovCajaBanco se genera junto con la cabecera
                                oeAsMovInteresMoratorio.AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                                With oeAsMovInteresMoratorio.AsMov_ObligacionFin
                                    .TipoOperacion = "I"
                                    .IdAsientoMovimiento = ""
                                    .IdObligacionFinanciera = oeObligacion.Id
                                    .Activo = True
                                End With
                                leLista.Add(oeAsMovInteresMoratorio)
                            End If
                            '-----------------------------------------------------------

                        End If
                    End With
                Next
                ' asiento detalle de cuenta 10
                oeAsMov = New e_AsientoMovimiento
                With oeAsMov
                    'Asiento Movimiento Cabecera
                    .Id = ""
                    .IdCuentaContable = oeCtaCble.Id  'Asigno el tipo de asiento guardado en la TablaContableDetalle segun combo Medio de Pago
                    .Glosa = oeAsiento.Glosa
                    .HaberMN = oeMovCajaBanco.TotalMN
                    .HaberME = oeMovCajaBanco.TotalME
                    .DebeMN = 0
                    .DebeME = 0
                    .IdUsuarioCrea = idUsuario
                    .Activo = True
                    .TipoOperacion = "I"
                    'Asigna datos al objeto MovCaja Banco
                    'oeMovCajaBanco.MovDoc = leMovDocAgregado 'Se le asigna la lista de los Movimientos dcumentos a cambiar el saldo
                    oeAsMov.MovimientoCajaBanco = oeMovCajaBanco
                    .AsMov_MovDoc = Nothing ' No se Genera relacion
                End With
                oeAsiento.AsientoMovimiento.Add(oeAsMov) 'Agregar cabecera al Asiento
                oeAsiento.AsientoMovimiento.AddRange(leLista)
                Dim Band As Boolean = odAsiento.Guardar(oeAsiento, Nothing) 'Se guarda toda la transaccion
                oeMovCajaBanco.Id = oeAsiento._IdMovimientoCajaBanco
                Return Band
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GastoFinanciero(ByVal oeCtaBancaria As e_CuentaBancaria, ByVal oeFlujoCaja As e_FlujoCaja, _
    ByVal oeGastoFuncion As e_TablaContableDet, ByVal oeCuentaGasto As e_CuentaContable, _
    ByVal oeItemGasto As e_ItemGasto, ByVal obj As Object) As Boolean
        Try
            Dim Fecha As Date = obj(0)
            Dim TipoCambio As Double = obj(1)
            Dim MontoGasto As Double = obj(2)
            Dim Glosa As String = obj(3)
            Dim UsuarioCreacion As String = obj(4)
            Dim NroBoucher As String = obj(5)
            Dim oeAsientoMovimiento As New e_AsientoMovimiento

            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            oePeriodo.Activo = True
            oePeriodo = olPeriodo.Obtener(oePeriodo)

            Dim oeAsiento As New e_Asiento
            Dim olAsiento As New l_Asiento
            Dim leAsiento As New List(Of e_Asiento)
            Dim odAsiento As New d_Asiento
            oeAsiento.IdPeriodo = oePeriodo.Id
            oeAsiento.Fecha = Fecha
            oeAsiento.IdentificaAsiento = "GF" + oeCuentaGasto.Cuenta + oeCtaBancaria.Id
            oeAsiento.IdMoneda = oeCtaBancaria.IdMoneda
            leAsiento.AddRange(olAsiento.Listar(oeAsiento))

            If leAsiento.Count > 0 Then
                oeAsiento = leAsiento(0)
                oeAsiento.TipoOperacion = "A"
                oeAsiento.TotalDebe = oeAsiento.TotalDebe + MontoGasto
                oeAsiento.TotalHaber = oeAsiento.TotalHaber + MontoGasto

                Dim olAsientoMovimiento As New l_AsientoMovimiento
                Dim leAsientoMovimiento As New List(Of e_AsientoMovimiento)
                oeAsientoMovimiento.IdAsiento = oeAsiento.Id
                oeAsientoMovimiento.Activo = 1
                leAsientoMovimiento.AddRange(olAsientoMovimiento.Listar(oeAsientoMovimiento))
                oeAsientoMovimiento = leAsientoMovimiento(0)

                Dim oeMovAnalisis As New e_MovimientoAnalisis
                Dim leMovAnalisis As New List(Of e_MovimientoAnalisis)
                Dim olMovAnalisis As New l_MovimientoAnalisis
                oeMovAnalisis.IdAsientoMovimiento = oeAsientoMovimiento.Id
                oeMovAnalisis.Activo = 1
                leMovAnalisis.AddRange(olMovAnalisis.Listar(oeMovAnalisis))
                oeMovAnalisis = leMovAnalisis(0)

                With oeAsientoMovimiento
                    .TipoOperacion = "A"
                    If oeCtaBancaria.IdMoneda = "1CH01" Then
                        .DebeMN = .DebeMN + MontoGasto
                        .HaberMN = 0
                        .DebeME = .DebeME + MontoGasto / TipoCambio
                        .HaberME = 0
                        oeMovAnalisis.Monto = .DebeMN
                    Else
                        .DebeMN = .DebeMN + MontoGasto * TipoCambio
                        .HaberMN = 0
                        .DebeME = .DebeME + MontoGasto
                        .HaberME = 0
                        oeMovAnalisis.Monto = .DebeME
                    End If
                    oeMovAnalisis.TipoOperacion = "G"
                    oeMovAnalisis.Saldo = 0
                    .MovimientoAnalisis.Add(oeMovAnalisis)
                End With
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            Else
                With oeAsiento
                    .TipoOperacion = "I"
                    .IdPeriodo = oePeriodo.Id
                    .IdTipoAsiento = "BANCO"
                    .Fecha = Fecha
                    .Glosa = "GASTOS FINANCIEROS " & oeCtaBancaria.NombreBanco & " - " & UCase(Glosa)
                    .GlosaImprime = .Glosa
                    .IdMoneda = oeCtaBancaria.IdMoneda
                    .TipoCambio = TipoCambio
                    .TotalDebe = MontoGasto
                    .TotalHaber = MontoGasto
                    .IdUsuarioCrea = UsuarioCreacion
                    .IdEstado = "CUADRADO"
                    .IdentificaAsiento = "GF" + oeCuentaGasto.Cuenta + oeCtaBancaria.Id
                End With
                '-----------PRIMERA LINEA - GASTO -------------
                With oeAsientoMovimiento
                    .TipoOperacion = "I"
                    .IdCuentaContable = oeCuentaGasto.Id
                    .Glosa = oeAsiento.Glosa
                    If oeCtaBancaria.IdMoneda = "1CH01" Then
                        .DebeMN = MontoGasto
                        .HaberMN = 0
                        .DebeME = MontoGasto / TipoCambio
                        .HaberME = 0
                    Else
                        .DebeMN = MontoGasto * TipoCambio
                        .HaberMN = 0
                        .DebeME = MontoGasto
                        .HaberME = 0
                    End If
                    .IdUsuarioCrea = UsuarioCreacion

                    Dim oeMovAnalisis As New e_MovimientoAnalisis
                    With oeMovAnalisis
                        .TipoOperacion = "I"
                        .IdItemGasto = oeItemGasto.Id
                        .IdGastoFuncion = oeGastoFuncion.Id
                        .Monto = MontoGasto
                        .Saldo = 0
                    End With
                    .MovimientoAnalisis.Add(oeMovAnalisis)
                End With
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            End If
            '----------SEGUNDA LINEA 104 - BANCO siempre inserta----------------
            oeAsientoMovimiento = New e_AsientoMovimiento
            Dim oeMovBanco As New e_MovimientoCajaBanco
            With oeAsientoMovimiento
                .TipoOperacion = "I"
                .IdCuentaContable = oeCtaBancaria.IdCuentaContable
                .Glosa = oeAsiento.Glosa
                If oeCtaBancaria.IdMoneda = "1CH01" Then
                    .DebeMN = 0
                    .HaberMN = MontoGasto
                    .DebeME = 0
                    .HaberME = MontoGasto / TipoCambio
                Else
                    .DebeMN = 0
                    .HaberMN = MontoGasto * TipoCambio
                    .DebeME = 0
                    .HaberME = MontoGasto
                End If
                .IdUsuarioCrea = UsuarioCreacion
                oeMovBanco.TotalMN = .HaberMN
                oeMovBanco.TotalME = .HaberME
                With oeMovBanco
                    .TipoOperacion = "I"
                    .IdFlujoCaja = oeFlujoCaja.Id
                    .NroBoucher = NroBoucher
                    .IdCuentaBancaria = oeCtaBancaria.Id
                    .Fecha = Fecha
                    .IdMedioPago = "1CH05" 'transferencias de fondos
                    .TipoCambio = TipoCambio
                    ._Operador = -1
                End With
                .MovimientoCajaBanco = oeMovBanco
            End With
            oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            '----------------------------------------------------
            odAsiento.Guardar(oeAsiento, Nothing)
        Catch ex As Exception
            Throw
        End Try
    End Function

#Region "Nuevo"

    Public Function Listar2(oeObligacionFin As e_ObligacionFin) As List(Of e_ObligacionFin) Implements Il_ObligacionFinanciera.Listar2
        Try
            Return odObligacionFinanciera.Listar2(oeObligacionFin)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(leObligacionFin As List(Of e_ObligacionFin)) As Boolean Implements Il_ObligacionFinanciera.GuardarLista
        Try
            Return odObligacionFinanciera.GuardarLista(leObligacionFin)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarPago2(oeObliFin As e_ObligacionFin, oeAsientoModel As e_AsientoModelo, lst_DocRetDet As List(Of e_DocumentoRetencionDetalle)) As Boolean Implements Il_ObligacionFinanciera.GuardarPago2
        Try
            Dim oeAsiento As New e_Asiento, oeAsientoMov As New e_AsientoMovimiento, oeMovAnalisis As New e_MovimientoAnalisis
            Dim oeMovCajaBanco As New e_MovimientoCajaBanco, oeAsiMovObli As New e_AsientoMov_ObligacionFin, oeObligacionPago As New e_ObligacionPago
            Using TransScope As New TransactionScope()
                If olFuncionesGenerales.ValidarPeriodo(oeAsientoModel.IdPeriodo, gAreasSGI.Tesoreria, oeObliFin.oeMovCajaBanco.Fecha, "") Then
                    With oeAsiento
                        .TipoOperacion = "I" : .IdPeriodo = oeAsientoModel.IdPeriodo : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = oeAsientoModel.FechaMov
                        .Glosa = oeAsientoModel.Nombre & " " & oeObliFin.IdTipoObligacion & " " & oeObliFin.NroVencimiento & " " & oeObliFin.Banco
                        .GlosaImprime = String.Empty
                        .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeAsientoModel.TipoCambio
                        .TotalDebe = IIf(oeAsientoModel.Moneda = "SOLES", oeObliFin.oeMovCajaBanco.TotalMN, oeObliFin.oeMovCajaBanco.TotalME)
                        .TotalHaber = IIf(oeAsientoModel.Moneda = "SOLES", oeObliFin.oeMovCajaBanco.TotalMN, oeObliFin.oeMovCajaBanco.TotalME)
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeObliFin.UsuarioModifica : oeAsiento.Activo = True
                    End With
                    For Each oeAuxDet In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila).ToList
                        Select Case Left(oeAuxDet.Cuenta, 1)
                            Case "1"
                                If Left(oeAuxDet.Cuenta, 2) = "10" Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdUsuarioCrea = oeObliFin.UsuarioModifica
                                    oeAsientoMov.IdCuentaContable = oeObliFin.oeMovCajaBanco.IdCta10 : oeAsientoMov.Glosa = oeAsiento.Glosa
                                    If oeAuxDet.Partida = 1 Then
                                        oeAsientoMov.DebeMN = oeObliFin.oeMovCajaBanco.TotalMN : oeAsientoMov.DebeME = oeObliFin.oeMovCajaBanco.TotalME
                                    Else
                                        oeAsientoMov.HaberMN = oeObliFin.oeMovCajaBanco.TotalMN : oeAsientoMov.HaberME = oeObliFin.oeMovCajaBanco.TotalME
                                    End If
                                    ' Generar Asiento Movimiento Caja y Banco
                                    oeMovCajaBanco = New e_MovimientoCajaBanco
                                    oeMovCajaBanco.TipoOperacion = "I" : oeMovCajaBanco.Activo = True
                                    oeMovCajaBanco.IdFlujoCaja = oeObliFin.oeMovCajaBanco.IdFlujoCaja
                                    oeMovCajaBanco.IdMedioPago = oeObliFin.oeMovCajaBanco.IdMedioPago
                                    oeMovCajaBanco.NroBoucher = oeObliFin.oeMovCajaBanco.NroBoucher
                                    oeMovCajaBanco.UsuarioCreacion = oeObliFin.UsuarioModifica
                                    oeMovCajaBanco.IdCuentaBancaria = oeObliFin.oeMovCajaBanco.IdCuentaBancaria
                                    oeMovCajaBanco._Operador = -1
                                    oeMovCajaBanco.Fecha = oeObliFin.oeMovCajaBanco.Fecha
                                    oeMovCajaBanco.TotalMN = oeObliFin.oeMovCajaBanco.TotalMN
                                    oeMovCajaBanco.TotalME = oeObliFin.oeMovCajaBanco.TotalME
                                    oeMovCajaBanco.TipoCambio = oeAsientoModel.TipoCambio
                                    oeAsientoMov.MovimientoCajaBanco = oeMovCajaBanco
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Else
                                    Dim _leGasto = oeAsientoModel.leDetalle.Where(Function(it) it.Fila = oeAuxDet.Formula.Trim And it.MontoAux > 0).ToList
                                    Dim ln_MontoGasto As Double = 0
                                    If _leGasto.Count > 0 Then
                                        oeAsientoMov = New e_AsientoMovimiento
                                        oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdUsuarioCrea = oeObliFin.UsuarioModifica
                                        oeAsientoMov.IdCuentaContable = oeAuxDet.IdCuentaContable : oeAsientoMov.Glosa = oeAsiento.Glosa
                                        If oeAsientoModel.Moneda.Trim = oeObliFin.IdMoneda.Trim Then
                                            ln_MontoGasto = _leGasto(0).MontoAux
                                        Else
                                            ln_MontoGasto = IIf(oeAsientoModel.Moneda = "SOLES", _leGasto(0).MontoAux * oeAsientoModel.TipoCambio, _leGasto(0).MontoAux / oeAsientoModel.TipoCambio)
                                        End If
                                        If oeAuxDet.Partida = 1 Then
                                            oeAsientoMov.DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", ln_MontoGasto, ln_MontoGasto * oeAsientoModel.TipoCambio)
                                            oeAsientoMov.DebeME = IIf(oeAsientoModel.Moneda = "SOLES", ln_MontoGasto / oeAsientoModel.TipoCambio, ln_MontoGasto)
                                        Else
                                            oeAsientoMov.HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", ln_MontoGasto, ln_MontoGasto * oeAsientoModel.TipoCambio)
                                            oeAsientoMov.HaberME = IIf(oeAsientoModel.Moneda = "SOLES", ln_MontoGasto / oeAsientoModel.TipoCambio, ln_MontoGasto)
                                        End If
                                        oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                    End If
                                End If
                            Case "4"
                                If oeAuxDet.Cuenta = oeObliFin.CtaFec Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    Dim Comision As Double = 0
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdUsuarioCrea = oeObliFin.UsuarioModifica
                                    oeAsientoMov.IdCuentaContable = oeAuxDet.IdCuentaContable : oeAsientoMov.Glosa = oeAsiento.Glosa

                                    If oeAuxDet.Partida = 1 Then
                                        oeAsientoMov.DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", oeAuxDet.MontoAux, oeAuxDet.MontoAux * oeAsientoModel.TipoCambio)
                                        oeAsientoMov.DebeME = IIf(oeAsientoModel.Moneda = "SOLES", oeAuxDet.MontoAux / oeAsientoModel.TipoCambio, oeAuxDet.MontoAux)
                                    Else
                                        oeAsientoMov.HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", oeAuxDet.MontoAux, oeAuxDet.MontoAux * oeAsientoModel.TipoCambio)
                                        oeAsientoMov.HaberME = IIf(oeAsientoModel.Moneda = "SOLES", oeAuxDet.MontoAux / oeAsientoModel.TipoCambio, oeAuxDet.MontoAux)
                                    End If
                                    ' Generar Asiento Movimiento Obligacion
                                    oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                    oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                    oeAsiMovObli.IdObligacionFinanciera = oeObliFin.Id
                                    oeAsiMovObli.UsuarioCreacion = oeObliFin.UsuarioModifica
                                    oeAsiMovObli.TotalMN = IIf(oeAsientoModel.Moneda = "SOLES", oeAuxDet.MontoAux, oeAuxDet.MontoAux * oeAsientoModel.TipoCambio)
                                    oeAsiMovObli.TotalME = IIf(oeAsientoModel.Moneda = "SOLES", oeAuxDet.MontoAux / oeAsientoModel.TipoCambio, oeAuxDet.MontoAux)

                                    'If oeAuxDet.Partida = 1 Then
                                    '    oeAsientoMov.DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", oeAuxDet.MontoAux, oeAuxDet.MontoAux * oeAsientoModel.TipoCambio)
                                    '    oeAsientoMov.DebeME = IIf(oeAsientoModel.Moneda = "SOLES", oeAuxDet.MontoAux / oeAsientoModel.TipoCambio, oeAuxDet.MontoAux)
                                    'Else
                                    '    oeAsientoMov.HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", oeAuxDet.MontoAux, oeAuxDet.MontoAux * oeAsientoModel.TipoCambio)
                                    '    oeAsientoMov.HaberME = IIf(oeAsientoModel.Moneda = "SOLES", oeAuxDet.MontoAux / oeAsientoModel.TipoCambio, oeAuxDet.MontoAux)
                                    'End If
                                    oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                Else
                                    Dim _MontoClase4 As Double = 0, _MontoInteres As Double = 0
                                    If oeObliFin.IndFec Then
                                        If oeAsientoModel.Moneda.Trim = oeObliFin.IdMoneda.Trim Then
                                            _MontoClase4 = oeObliFin.MontoCapital
                                        Else
                                            _MontoClase4 = IIf(oeAsientoModel.Moneda = "SOLES", oeObliFin.MontoCapital * oeAsientoModel.TipoCambio, oeObliFin.MontoCapital / oeAsientoModel.TipoCambio)
                                        End If
                                    Else
                                        If oeObliFin.IndExcluirInteres = False Then
                                            _MontoInteres = oeObliFin.MontoInteres
                                        End If
                                        If oeAsientoModel.Moneda.Trim = oeObliFin.IdMoneda.Trim Then
                                            _MontoClase4 = oeObliFin.MontoCapital + _MontoInteres
                                        Else
                                            _MontoClase4 = IIf(oeAsientoModel.Moneda = "SOLES", (oeObliFin.MontoCapital + _MontoInteres) * oeAsientoModel.TipoCambio, (oeObliFin.MontoCapital + _MontoInteres) / oeAsientoModel.TipoCambio)
                                        End If
                                    End If
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdUsuarioCrea = oeObliFin.UsuarioModifica
                                    oeAsientoMov.IdCuentaContable = oeObliFin.IdCuentaContable : oeAsientoMov.Glosa = oeAsiento.Glosa
                                    ' Generar Obligacion Pago
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago = New e_ObligacionPago
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.IdObligacionFinanciera = oeObliFin.Id
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.TipoOperacion = "I"
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.NroCuota = 1
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.FechaFinal = oeMovCajaBanco.Fecha
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.FechaInicial = oeObliFin.FechaVencimiento
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.Activo = True
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.IndCancelado = True
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.UsuarioCreacion = oeObliFin.UsuarioModifica
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.MacPCLocalCreacion = oeObliFin.oeMovCajaBanco.MacLocal
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.MontoFinalMN = oeObliFin.oeMovCajaBanco.TotalMN
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.MontoInicialMN = oeObliFin.oeMovCajaBanco.TotalMN
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.MontoFinalME = oeObliFin.oeMovCajaBanco.TotalME
                                    oeAsientoMov.ObligacionFinanciera.oeObligacionPago.MontoInicialME = oeObliFin.oeMovCajaBanco.TotalME
                                    ' Generar Asiento Movimiento Obligacion
                                    oeAsiMovObli = New e_AsientoMov_ObligacionFin
                                    oeAsiMovObli.TipoOperacion = "I" : oeAsiMovObli.Activo = True
                                    oeAsiMovObli.IdObligacionFinanciera = oeObliFin.Id
                                    oeAsiMovObli.UsuarioCreacion = oeObliFin.UsuarioModifica
                                    ''Nueva
                                    Dim ln_ComisionMonto As Double = 0
                                    Dim _leGasto = oeAsientoModel.leDetalle.Where(Function(it) it.Fila = oeAuxDet.Formula.Trim And it.MontoAux > 0).ToList
                                    If _leGasto.Count > 0 Then
                                        If oeAsientoModel.Moneda.Trim = oeObliFin.IdMoneda.Trim Then
                                            ln_ComisionMonto = _leGasto(0).MontoAux
                                        Else
                                            ln_ComisionMonto = IIf(oeAsientoModel.Moneda = "SOLES", _leGasto(0).MontoAux * oeAsientoModel.TipoCambio, _leGasto(0).MontoAux / oeAsientoModel.TipoCambio)
                                        End If
                                    End If
                                    ''Nueva
                                    oeAsiMovObli.TotalMN = IIf(oeAsientoModel.Moneda = "SOLES", (_MontoClase4 + ln_ComisionMonto), (_MontoClase4 + ln_ComisionMonto) * oeAsientoModel.TipoCambio)
                                    oeAsiMovObli.TotalME = IIf(oeAsientoModel.Moneda = "SOLES", (_MontoClase4 + ln_ComisionMonto) / oeAsientoModel.TipoCambio, (_MontoClase4 + ln_ComisionMonto))
                                    ''
                                    If oeAuxDet.Partida = 1 Then
                                        oeAsientoMov.DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", (_MontoClase4 + ln_ComisionMonto), (_MontoClase4 + ln_ComisionMonto) * oeAsientoModel.TipoCambio)
                                        oeAsientoMov.DebeME = IIf(oeAsientoModel.Moneda = "SOLES", (_MontoClase4 + ln_ComisionMonto) / oeAsientoModel.TipoCambio, (_MontoClase4 + ln_ComisionMonto))
                                    Else
                                        oeAsientoMov.HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", (_MontoClase4 + ln_ComisionMonto), (_MontoClase4 + ln_ComisionMonto) * oeAsientoModel.TipoCambio)
                                        oeAsientoMov.HaberME = IIf(oeAsientoModel.Moneda = "SOLES", (_MontoClase4 + ln_ComisionMonto) / oeAsientoModel.TipoCambio, (_MontoClase4 + ln_ComisionMonto))
                                    End If
                                    oeAsientoMov.AsMov_ObligacionFin = oeAsiMovObli
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                End If
                            Case "7"
                                If oeAuxDet.IndAgregar And oeObliFin.MontoInteresDscto > 0 Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdUsuarioCrea = oeObliFin.UsuarioModifica
                                    oeAsientoMov.IdCuentaContable = oeAuxDet.IdCuentaContable : oeAsientoMov.Glosa = oeAuxDet.Titulo
                                    If oeAuxDet.Partida = 1 Then
                                        oeAsientoMov.DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", oeObliFin.MontoInteresDscto, oeObliFin.MontoInteresDscto * oeAsientoModel.TipoCambio)
                                        oeAsientoMov.DebeME = IIf(oeAsientoModel.Moneda = "SOLES", oeObliFin.MontoInteresDscto / oeAsientoModel.TipoCambio, oeObliFin.MontoInteresDscto)
                                    Else
                                        oeAsientoMov.HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", oeObliFin.MontoInteresDscto, oeObliFin.MontoInteresDscto * oeAsientoModel.TipoCambio)
                                        oeAsientoMov.HaberME = IIf(oeAsientoModel.Moneda = "SOLES", oeObliFin.MontoInteresDscto / oeAsientoModel.TipoCambio, oeObliFin.MontoInteresDscto)
                                    End If
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                End If
                            Case Else
                                If oeAuxDet.IndAgregar Then
                                    Dim ln_MontoAuxDet As Double = 0
                                    oeAsientoMov = New e_AsientoMovimiento
                                    oeAsientoMov.TipoOperacion = "I" : oeAsientoMov.IdUsuarioCrea = oeObliFin.UsuarioModifica
                                    oeAsientoMov.IdCuentaContable = oeAuxDet.IdCuentaContable : oeAsientoMov.Glosa = oeAsiento.Glosa
                                    If oeAsientoModel.Moneda.Trim = oeObliFin.IdMoneda.Trim Then
                                        ln_MontoAuxDet = oeAuxDet.MontoAux
                                    Else
                                        ln_MontoAuxDet = IIf(oeAsientoModel.Moneda = "SOLES", oeAuxDet.MontoAux * oeAsientoModel.TipoCambio, oeAuxDet.MontoAux / oeAsientoModel.TipoCambio)
                                    End If
                                    If oeAuxDet.Partida = 1 Then
                                        oeAsientoMov.DebeMN = IIf(oeAsientoModel.Moneda = "SOLES", ln_MontoAuxDet, ln_MontoAuxDet * oeAsientoModel.TipoCambio)
                                        oeAsientoMov.DebeME = IIf(oeAsientoModel.Moneda = "SOLES", ln_MontoAuxDet / oeAsientoModel.TipoCambio, ln_MontoAuxDet)
                                    Else
                                        oeAsientoMov.HaberMN = IIf(oeAsientoModel.Moneda = "SOLES", ln_MontoAuxDet, ln_MontoAuxDet * oeAsientoModel.TipoCambio)
                                        oeAsientoMov.HaberME = IIf(oeAsientoModel.Moneda = "SOLES", ln_MontoAuxDet / oeAsientoModel.TipoCambio, ln_MontoAuxDet)
                                    End If
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                End If
                        End Select
                    Next
                    If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                        oeObliFin.TipoOperacion = "S"
                        oeObliFin.Saldo = oeObliFin.Saldo - oeObliFin.MontoOperar
                        odObligacionFinanciera.Guardar(oeObliFin)
                        oeObliFin.oeMovCajaBanco.Id = oeAsiento._IdMovimientoCajaBanco

                        Dim ol_DocRetDet As l_DocumentoRetencionDetalle
                        For Each fila In lst_DocRetDet
                            ol_DocRetDet = New l_DocumentoRetencionDetalle
                            ol_DocRetDet.Guardar(fila)
                        Next
                        TransScope.Complete()
                        Return True
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener2(oeObligacionFin As e_ObligacionFin) As e_ObligacionFin Implements Il_ObligacionFinanciera.Obtener2
        Try
            Return odObligacionFinanciera.Obtener2(oeObligacionFin)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Obligaciones Financieras"

    Public Function GuardarLetras(ByVal leOblig As System.Collections.Generic.List(Of EntidadesWCF.e_ObligacionFinanciera), IdUsuario As String) As Boolean Implements Il_ObligacionFinanciera.GuardarLetras
        Try
            Dim loFuncionesGenerales As New l_FuncionesGenerales
            Dim oeOblig As New e_ObligacionFinanciera
            oeOblig = leOblig(0)
            oeOblig.IdTipoObligacion = "1CH000000072" ' TipoDoc

            ObtenerCuentas(Year(oeOblig.FechaEmision)) 'Reemplazo Modelo

            Dim Glosa As String = ""
            If leOblig.Count = 1 Then Glosa = "OBLIGACION FIN. LETRA " + oeOblig._NombreBanco
            If leOblig.Count > 1 Then Glosa = "OBLIGACION FIN. LETRAS VARIAS / " + oeOblig._NombreBanco

            Dim oePeriodo As New e_Periodo
            Dim lePeriodo As New List(Of e_Periodo)
            Dim olPeriodo As New l_Periodo
            oePeriodo.Activo = True
            oePeriodo.Id = ""
            oePeriodo.Codigo = oeOblig.FechaEmision.Year.ToString + "-" + oeOblig.FechaEmision.Month.ToString
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            oePeriodo = lePeriodo(0) ' Reemplazo Periodo

            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, oeOblig.FechaEmision, oeOblig.FechaEmision.Year.ToString + "-" + oeOblig.FechaEmision.Month.ToString)

            Dim CodigoUnico As String = Date.Now.Year.ToString + Strings.Right("0" + Date.Now.Month.ToString, 2) + Strings.Right("0" + Date.Now.Day.ToString, 2) + Strings.Right("0" + Date.Now.Hour.ToString, 2) _
           + Strings.Right("0" + Date.Now.Minute.ToString, 2) + Strings.Right("0" + Date.Now.Second.ToString, 2) + Strings.Right("0" + Date.Now.Millisecond.ToString, 2)

            Dim IdObligacion As String = odObligacionFinanciera.UltimoIdInserta()
            Dim lsPrefijoObligacion As String = Left(IdObligacion, 3)
            Dim lsNumeroObligacion As Integer = CInt(Right(IdObligacion, Len(IdObligacion) - 3))

            Dim IdFecLetras As String = odFecLetras.UltimoIdInserta()
            Dim lsPrefijoFecLetras As String = Left(IdFecLetras, 3)
            Dim lsNumeroFecLetras As Integer = CInt(Right(IdFecLetras, Len(IdFecLetras) - 3))

            Dim IdAsiento As String = odAsiento.UltimoIdInserta()
            Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
            Dim lsNumeroAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))

            Dim NroAsientoD As String = odAsiento.UltimoNroAsiento("1CH000020", oePeriodo.Id, "1")
            Dim lsPrefijoNroAsientoD As String = Left(NroAsientoD, 2)
            Dim lsNumeroNroAsientoD As Integer = CInt(Right(NroAsientoD, Len(NroAsientoD) - 2))

            Dim IdAsientoMovimiento As String = odAsientoMovimiento.UltimoIdInsertar()
            Dim lsPrefijoAsientoMovimiento As String = Left(IdAsientoMovimiento, 3)
            Dim lsNumeroAsientoMovimiento As Integer = CInt(Right(IdAsientoMovimiento, Len(IdAsientoMovimiento) - 3))

            Dim IdCuentaxCyP As String = odCuentaxCyP.UltimoIdInserta()
            Dim lsPrefijoCuentaxCyP As String = Left(IdCuentaxCyP, 3)
            Dim lsNumeroCuentaxCyP As Integer = CInt(Right(IdCuentaxCyP, Len(IdCuentaxCyP) - 3))

            Dim IdAsientoMov_MovDoc As String = odAsMovMovDoc.UltimoIdInsertar()
            Dim lsPrefijoAsientoMov_MovDoc As String = Left(IdAsientoMov_MovDoc, 3)
            Dim lsNumeroAsientoMov_MovDoc As Integer = CInt(Right(IdAsientoMov_MovDoc, Len(IdAsientoMov_MovDoc) - 3))

            Dim IdAsientoMov_ObliFin As String = odAsMovObliFin.UltimoIdInserta()
            Dim lsPrefijoAsientoMov_ObliFin As String = Left(IdAsientoMov_ObliFin, 3)
            Dim lsNumeroAsientoMov_ObliFin As Integer = CInt(Right(IdAsientoMov_ObliFin, Len(IdAsientoMov_ObliFin) - 3))

            Dim IdIdObligacionDocumento As String = odObligacionDocumento.UltimoIdInserta()
            Dim lsPrefijoObligacionDocumento As String = Left(IdIdObligacionDocumento, 3)
            Dim lsNumeroObligacionDocumento As Integer = CInt(Right(IdIdObligacionDocumento, Len(IdIdObligacionDocumento) - 3))

            Dim IdMovAna As String = odMovimientoAnalisis.UltimoIdInserta()
            Dim lsPrefijoMovAna As String = Left(IdMovAna, 3)
            Dim lsNumeroMovAna As Integer = CInt(Right(IdMovAna, Len(IdMovAna) - 3))

            Dim dt_OFIN As Data.DataTable = CrearDT()
            Dim dt_FecLetras As Data.DataTable = olFecLetras.CrearDT()
            Dim dt_A As Data.DataTable = olAsiento.CrearDT()
            Dim dt_AM As Data.DataTable = olAsientoMovimiento.CrearDT()
            Dim dt_CTAXCYP As Data.DataTable = olCuentaxCyP.CrearDT()
            Dim dt_AMMDOC As Data.DataTable = olAsMovMovDoc.CrearDT()
            Dim dt_AMOFIN As Data.DataTable = olAsMovObliFin.CrearDT()
            Dim dt_OBLIDOC As Data.DataTable = olObligacionDocuemto.CrearDT()
            Dim dt_MA As Data.DataTable = olMovimientoAnalisis.CrearDT
            Dim NroLinea = 1
            Dim BanderaAsientoMovimientoDocumento As Integer = 0

            '-----Reemplazo Asiento Modelo Obligacion
            Dim rowAsiento As Data.DataRow
            rowAsiento = dt_A.NewRow
            rowAsiento("Id") = lsPrefijoAsiento.ToString + CompletaConCeros(lsNumeroAsiento.ToString, 12)
            rowAsiento("IdPeriodo") = oePeriodo.Id
            rowAsiento("IdTipoAsiento") = "1CH000020"
            rowAsiento("NroAsiento") = lsPrefijoNroAsientoD + CompletaConCeros(lsNumeroNroAsientoD, 7).ToString
            rowAsiento("Fecha") = oeOblig.FechaEmision
            rowAsiento("Glosa") = Glosa
            rowAsiento("GlosaImprime") = Glosa
            rowAsiento("IdMoneda") = oeOblig.IdMoneda
            rowAsiento("TipoCambio") = oeOblig.TipoCambio
            rowAsiento("TotalDebe") = IIf(oeOblig.IdMoneda = "1CH01", leOblig.Sum(Function(i) i.MontoMN), leOblig.Sum(Function(i) i.MontoME))
            rowAsiento("TotalHaber") = IIf(oeOblig.IdMoneda = "1CH01", leOblig.Sum(Function(i) i.MontoMN), leOblig.Sum(Function(i) i.MontoME))
            rowAsiento("IdUsuarioBloquea") = IdUsuario
            rowAsiento("UsuarioCreacion") = IdUsuario
            rowAsiento("IdEstado") = "1CH00005"
            rowAsiento("IdAsientoExtorno") = ""
            rowAsiento("FechaCreacion") = Date.Now()
            rowAsiento("Activo") = True
            rowAsiento("NroAsientoImprime") = DBNull.Value
            rowAsiento("IdentificaAsiento") = DBNull.Value
            rowAsiento("IndRevision") = DBNull.Value
            rowAsiento("FechaRevision") = DBNull.Value
            rowAsiento("UsuarioRevision") = DBNull.Value
            rowAsiento("IndOrigen") = 30
            rowAsiento("UsuarioModificacion") = DBNull.Value
            rowAsiento("FechaModificacion") = DBNull.Value
            dt_A.Rows.Add(rowAsiento)
            '-------------------------------------

            'Reecorre Lista de Letras - Crear Obligacion - Reemplazar Obligacion Fin
            For Each obj In leOblig

                Dim rowOfin As Data.DataRow
                rowOfin = dt_OFIN.NewRow
                rowOfin("Id") = lsPrefijoObligacion.ToString + CompletaConCeros(lsNumeroObligacion.ToString, 12).ToString
                rowOfin("Codigo") = obj.Codigo
                rowOfin("IdEmpresaBanco") = obj.IdEmpresaBanco
                rowOfin("Glosa") = obj.Glosa
                rowOfin("FechaEmision") = obj.FechaEmision
                rowOfin("FechaVencimiento") = obj.FechaVencimiento
                rowOfin("IdTipoObligacion") = "1CH000000072"
                rowOfin("IdMoneda") = obj.IdMoneda
                rowOfin("TipoCambio") = obj.TipoCambio
                rowOfin("MontoMN") = obj.MontoMN
                rowOfin("MontoME") = obj.MontoME
                rowOfin("Saldo") = IIf(obj.IdMoneda = "1CH01", obj.MontoMN, obj.MontoME)
                rowOfin("TasaInteres") = 0.0
                rowOfin("MontoInteresTes") = 0.0
                rowOfin("MontoInteresCon") = 0.0
                rowOfin("MontoInteresMoratorio") = 0.0
                rowOfin("Comision") = 0.0
                rowOfin("Activo") = True
                rowOfin("IdCuentaContable") = IIf(oeOblig.IdMoneda = "1CH01", leCuentasGenerales.Where(Function(i) i.Nombre = "CTALETRASSOLES")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTALETRASDOLARES")(0).Texto2)
                rowOfin("UsuarioCreacion") = IdUsuario
                rowOfin("FechaCreacion") = Date.Now()
                rowOfin("MacPCLocalCreacion") = ""
                rowOfin("IdCuentaContableInteres") = ""
                rowOfin("IdCuentaBancaria") = ""
                rowOfin("Gastos") = 0.0
                rowOfin("CodigoUnico") = CodigoUnico
                rowOfin("Voucher") = DBNull.Value
                rowOfin("GlosaCtaxCyP") = DBNull.Value
                rowOfin("MontoInteresDscto") = 0.0
                dt_OFIN.Rows.Add(rowOfin)
                '-- Guardar Fec Letras por Letra
                Dim rowFecLetras As Data.DataRow
                rowFecLetras = dt_FecLetras.NewRow
                rowFecLetras("Id") = lsPrefijoFecLetras.ToString + CompletaConCeros(lsNumeroFecLetras.ToString, 12)
                rowFecLetras("IdObligacionFinanciera") = lsPrefijoObligacion.ToString + CompletaConCeros(lsNumeroObligacion.ToString, 12)
                rowFecLetras("IndClienteProveedor") = 1
                rowFecLetras("IdClienteProveedor") = obj.IdClienteProveedor
                rowFecLetras("Activo") = 1
                rowFecLetras("NroLetra") = obj.Codigo
                dt_FecLetras.Rows.Add(rowFecLetras)

                If BanderaAsientoMovimientoDocumento = 0 Then

                    ' Genera Asiento Movimiento por Documentos Agregados en Letra
                    For Each doc In obj.leDocumentoAgregados

                        Dim rowAsientoMovimientoDoc As Data.DataRow
                        rowAsientoMovimientoDoc = dt_AM.NewRow
                        rowAsientoMovimientoDoc("Id") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                        rowAsientoMovimientoDoc("IdAsiento") = lsPrefijoAsiento + CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rowAsientoMovimientoDoc("IdCuentaContable") = doc.IdCuentaContable
                        rowAsientoMovimientoDoc("Glosa") = "OBLIGACION FIN. LETRA " + doc._AbrevTipoDoc + "/" + doc.Serie + doc.Numero + " " + doc._NombreClienteProveedor
                        If doc.IdMoneda = "1CH01" Then
                            rowAsientoMovimientoDoc("DebeMN") = doc.MontoOperar
                            rowAsientoMovimientoDoc("HaberMN") = 0
                            rowAsientoMovimientoDoc("DebeME") = doc.MontoOperar / oeOblig.TipoCambio
                            rowAsientoMovimientoDoc("HaberME") = 0
                        Else
                            rowAsientoMovimientoDoc("DebeMN") = doc.MontoOperar * oeOblig.TipoCambio
                            rowAsientoMovimientoDoc("HaberMN") = 0
                            rowAsientoMovimientoDoc("DebeME") = doc.MontoOperar
                            rowAsientoMovimientoDoc("HaberME") = 0
                        End If
                        rowAsientoMovimientoDoc("IdUsuarioCrea") = IdUsuario
                        rowAsientoMovimientoDoc("FechaCreacion") = Date.Now()
                        rowAsientoMovimientoDoc("Activo") = True
                        rowAsientoMovimientoDoc("NroLinea") = NroLinea
                        dt_AM.Rows.Add(rowAsientoMovimientoDoc)

                        ' Generar Cuenta por Cobrar y Pagar
                        Dim rowCuentaxCyP As Data.DataRow
                        rowCuentaxCyP = dt_CTAXCYP.NewRow
                        rowCuentaxCyP("Id") = lsPrefijoCuentaxCyP + CompletaConCeros(lsNumeroCuentaxCyP.ToString, 12)
                        rowCuentaxCyP("IdMovimientoCajaBanco") = DBNull.Value
                        rowCuentaxCyP("IdMovimientoDocumento") = doc.Id
                        rowCuentaxCyP("Fecha") = obj.FechaEmision
                        If obj.IdMoneda = "1CH01" Then
                            rowCuentaxCyP("MontoMN") = doc.MontoOperar
                            rowCuentaxCyP("MontoME") = doc.MontoOperar / oeOblig.TipoCambio
                        Else
                            rowCuentaxCyP("MontoMN") = doc.MontoOperar * oeOblig.TipoCambio
                            rowCuentaxCyP("MontoME") = doc.MontoOperar
                        End If
                        rowCuentaxCyP("Activo") = True
                        rowCuentaxCyP("UsuarioCreacion") = IdUsuario
                        rowCuentaxCyP("FechaCreacion") = Date.Now()
                        rowCuentaxCyP("MacPCLocalCreacion") = ""
                        dt_CTAXCYP.Rows.Add(rowCuentaxCyP)

                        ' Generar Asiento Movimiento - Movimiento Documento
                        Dim rowAsMov_MovDoc As Data.DataRow
                        rowAsMov_MovDoc = dt_AMMDOC.NewRow
                        rowAsMov_MovDoc("Id") = lsPrefijoAsientoMov_MovDoc + CompletaConCeros(lsNumeroAsientoMov_MovDoc, 9)
                        rowAsMov_MovDoc("IdMovimientoDocumento") = doc.Id
                        rowAsMov_MovDoc("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento, 13)
                        rowAsMov_MovDoc("Activo") = True
                        rowAsMov_MovDoc("IdCuentaxCyP") = lsPrefijoCuentaxCyP + CompletaConCeros(lsNumeroCuentaxCyP.ToString, 12)
                        dt_AMMDOC.Rows.Add(rowAsMov_MovDoc)

                        lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1
                        lsNumeroCuentaxCyP = lsNumeroCuentaxCyP + 1
                        lsNumeroAsientoMov_MovDoc = lsNumeroAsientoMov_MovDoc + 1
                        NroLinea = NroLinea + 1
                    Next
                End If

                ' Generar Asiento Movineto LEtras
                Dim rowAsientoMovimiento As Data.DataRow
                rowAsientoMovimiento = dt_AM.NewRow
                rowAsientoMovimiento("Id") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                rowAsientoMovimiento("IdAsiento") = lsPrefijoAsiento + CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rowAsientoMovimiento("IdCuentaContable") = IIf(obj.Id = "1CH01", leCuentasGenerales.Where(Function(i) i.Nombre = "CTALETRASSOLES")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTALETRASDOLARES")(0).Texto2)
                rowAsientoMovimiento("Glosa") = "OBLIGACION FIN. LETRA " + obj.Codigo + " /" + obj._NombreBanco + " vence:" + obj.FechaVencimiento
                rowAsientoMovimiento("DebeMN") = 0
                rowAsientoMovimiento("HaberMN") = obj.MontoMN
                rowAsientoMovimiento("DebeME") = 0
                rowAsientoMovimiento("HaberME") = obj.MontoME
                rowAsientoMovimiento("IdUsuarioCrea") = IdUsuario
                rowAsientoMovimiento("FechaCreacion") = Date.Now()
                rowAsientoMovimiento("Activo") = True
                rowAsientoMovimiento("NroLinea") = NroLinea
                dt_AM.Rows.Add(rowAsientoMovimiento)

                ' Generar Asiento Obligacion Financiera por Letra
                Dim rowAsMov_ObliFin As Data.DataRow
                rowAsMov_ObliFin = dt_AMOFIN.NewRow
                rowAsMov_ObliFin("Id") = lsPrefijoAsientoMov_ObliFin + CompletaConCeros(lsNumeroAsientoMov_ObliFin, 12)
                rowAsMov_ObliFin("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                rowAsMov_ObliFin("IdObligacionFinanciera") = lsPrefijoObligacion.ToString + CompletaConCeros(lsNumeroObligacion.ToString, 12)
                rowAsMov_ObliFin("Activo") = True
                rowAsMov_ObliFin("IdObligacionPago") = DBNull.Value
                dt_AMOFIN.Rows.Add(rowAsMov_ObliFin)

                ' Generar Obligacion Fin - Movimiento Documento por Cuenta cobrar y Pagar
                For i As Integer = 0 To dt_CTAXCYP.Rows.Count() - 1
                    Dim rowObliDoc As Data.DataRow
                    rowObliDoc = dt_OBLIDOC.NewRow
                    rowObliDoc("Id") = lsPrefijoObligacionDocumento + CompletaConCeros(lsNumeroObligacionDocumento, 12)
                    rowObliDoc("IdMovimientoDocumento") = dt_CTAXCYP(i)("IdMovimientoDocumento").ToString
                    rowObliDoc("IdObligacionFinanciera") = lsPrefijoObligacion.ToString + CompletaConCeros(lsNumeroObligacion.ToString, 12)
                    rowObliDoc("MontoMN") = dt_CTAXCYP(i)("MontoMN").ToString
                    rowObliDoc("MontoME") = dt_CTAXCYP(i)("MontoME").ToString
                    rowObliDoc("Activo") = True
                    rowObliDoc("IdCuentaxCyP") = dt_CTAXCYP(i)("Id").ToString
                    dt_OBLIDOC.Rows.Add(rowObliDoc)
                    lsNumeroObligacionDocumento = lsNumeroObligacionDocumento + 1
                Next

                lsNumeroObligacion = lsNumeroObligacion + 1
                lsNumeroFecLetras = lsNumeroFecLetras + 1
                lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1
                lsNumeroAsientoMov_ObliFin = lsNumeroAsientoMov_ObliFin + 1
                NroLinea = NroLinea + 1
                BanderaAsientoMovimientoDocumento = BanderaAsientoMovimientoDocumento + 1 ''Para que no cree mas asientos del documento
            Next

            lsNumeroAsiento = lsNumeroAsiento + 1
            lsNumeroNroAsientoD = lsNumeroNroAsientoD + 1

            For Each obj In oeOblig.leDocumentoAgregados.Where(Function(i) i.IdMoneda = "1CH02" And (i.Saldo - i.MontoOperar) < 0.1 And (i.Saldo - i.MontoOperar) > -0.1)

                Dim ds As DataSet
                Dim odMovimientoDocumento As New d_MovimientoDocumento
                ds = odMovimientoDocumento.ObtenerAJusteTipoCambio("DOC", obj.Id, "", oeOblig.FechaEmision.Year)
                Dim DebeMN As Decimal = ds.Tables(0).Rows(0).Item("DebeMN") + (obj.MontoOperar * oeOblig.TipoCambio)
                Dim HaberMN As Decimal = ds.Tables(0).Rows(0).Item("HaberMN")

                If DebeMN <> HaberMN Then

                    Dim glosaajuste As String = IIf(DebeMN > HaberMN, "ASIENTO DE PERDIDA /", "ASIENTO DE GANACIA /") & "" & obj.Serie & obj.Numero & " " & obj._NombreClienteProveedor
                    ' Geneara Asiento Por Ajuste de Tipo Cambio
                    Dim rowAsientoDif As Data.DataRow
                    rowAsientoDif = dt_A.NewRow
                    rowAsientoDif("Id") = lsPrefijoAsiento.ToString + CompletaConCeros(lsNumeroAsiento.ToString, 12)
                    rowAsientoDif("IdPeriodo") = oePeriodo.Id
                    rowAsientoDif("IdTipoAsiento") = "1CH000020"
                    rowAsientoDif("NroAsiento") = lsPrefijoNroAsientoD + CompletaConCeros(lsNumeroNroAsientoD, 7).ToString
                    rowAsientoDif("Fecha") = oeOblig.FechaEmision
                    rowAsientoDif("Glosa") = glosaajuste
                    rowAsientoDif("GlosaImprime") = glosaajuste
                    rowAsientoDif("IdMoneda") = "1CH01"
                    rowAsientoDif("TipoCambio") = 0.0
                    rowAsientoDif("TotalDebe") = Math.Abs(Math.Round(DebeMN - HaberMN, 3))
                    rowAsientoDif("TotalHaber") = Math.Abs(Math.Round(DebeMN - HaberMN, 3))
                    rowAsientoDif("IdUsuarioBloquea") = ""
                    rowAsientoDif("UsuarioCreacion") = IdUsuario
                    rowAsientoDif("IdEstado") = "1CH00005"
                    rowAsientoDif("IdAsientoExtorno") = ""
                    rowAsientoDif("FechaCreacion") = Date.Now()
                    rowAsientoDif("Activo") = True
                    rowAsientoDif("NroAsientoImprime") = DBNull.Value
                    rowAsientoDif("IdentificaAsiento") = "AJUSTETCMD" + obj.Id
                    rowAsientoDif("IndRevision") = DBNull.Value
                    rowAsientoDif("FechaRevision") = DBNull.Value
                    rowAsientoDif("UsuarioRevision") = DBNull.Value
                    rowAsientoDif("IndOrigen") = 29
                    rowAsientoDif("UsuarioModificacion") = DBNull.Value
                    rowAsientoDif("FechaModificacion") = DBNull.Value
                    dt_A.Rows.Add(rowAsientoDif)

                    ' Generar Asiento Movimiento por linea 1
                    Dim rowAsientoMovimientoDif1 As Data.DataRow
                    rowAsientoMovimientoDif1 = dt_AM.NewRow
                    rowAsientoMovimientoDif1("Id") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                    rowAsientoMovimientoDif1("IdAsiento") = lsPrefijoAsiento.ToString + CompletaConCeros(lsNumeroAsiento.ToString, 12)
                    rowAsientoMovimientoDif1("IdCuentaContable") = obj.IdCuentaContable
                    rowAsientoMovimientoDif1("Glosa") = glosaajuste
                    rowAsientoMovimientoDif1("DebeMN") = IIf(DebeMN > HaberMN, 0, HaberMN - DebeMN)
                    rowAsientoMovimientoDif1("HaberMN") = IIf(HaberMN > DebeMN, 0, DebeMN - HaberMN)
                    rowAsientoMovimientoDif1("DebeME") = 0.0
                    rowAsientoMovimientoDif1("HaberME") = 0.0
                    rowAsientoMovimientoDif1("IdUsuarioCrea") = IdUsuario
                    rowAsientoMovimientoDif1("FechaCreacion") = Date.Now()
                    rowAsientoMovimientoDif1("Activo") = True
                    rowAsientoMovimientoDif1("NroLinea") = 1
                    dt_AM.Rows.Add(rowAsientoMovimientoDif1)

                    ' Generar Asiento Movimiento - Movimiento Documento 
                    Dim rowAsMov_MovDoc As Data.DataRow
                    rowAsMov_MovDoc = dt_AMMDOC.NewRow
                    rowAsMov_MovDoc("Id") = lsPrefijoAsientoMov_MovDoc + CompletaConCeros(lsNumeroAsientoMov_MovDoc, 9)
                    rowAsMov_MovDoc("IdMovimientoDocumento") = obj.Id
                    rowAsMov_MovDoc("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                    rowAsMov_MovDoc("Activo") = True
                    rowAsMov_MovDoc("IdCuentaxCyP") = DBNull.Value
                    dt_AMMDOC.Rows.Add(rowAsMov_MovDoc)
                    lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1

                    ' Genera Asiento Movimiento 
                    Dim rowAsientoMovimientoDif2 As Data.DataRow
                    rowAsientoMovimientoDif2 = dt_AM.NewRow
                    rowAsientoMovimientoDif2("Id") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                    rowAsientoMovimientoDif2("IdAsiento") = lsPrefijoAsiento.ToString + CompletaConCeros(lsNumeroAsiento.ToString, 12)
                    rowAsientoMovimientoDif2("IdCuentaContable") = IIf(HaberMN > DebeMN, leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_GANANCIA")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_PERDIDAS")(0).Texto2)
                    rowAsientoMovimientoDif2("Glosa") = glosaajuste
                    rowAsientoMovimientoDif2("DebeMN") = IIf(DebeMN > HaberMN, Math.Abs(DebeMN - HaberMN), 0.0)
                    rowAsientoMovimientoDif2("HaberMN") = IIf(HaberMN > DebeMN, Math.Abs(HaberMN - DebeMN), 0.0)
                    rowAsientoMovimientoDif2("DebeME") = 0.0
                    rowAsientoMovimientoDif2("HaberME") = 0.0
                    rowAsientoMovimientoDif2("IdUsuarioCrea") = IdUsuario
                    rowAsientoMovimientoDif2("FechaCreacion") = Date.Now()
                    rowAsientoMovimientoDif2("Activo") = True
                    rowAsientoMovimientoDif2("NroLinea") = 2
                    dt_AM.Rows.Add(rowAsientoMovimientoDif2)

                    If DebeMN > HaberMN Then 'CASO PÉRDIDA
                        ' Generar Movimiento Analisis
                        Dim rowMovAna As Data.DataRow
                        rowMovAna = dt_MA.NewRow
                        rowMovAna("Id") = lsPrefijoMovAna & CompletaConCeros(lsNumeroMovAna.ToString, 13)
                        rowMovAna("IdCentroCosto") = DBNull.Value
                        rowMovAna("IdItemGasto") = DBNull.Value
                        rowMovAna("IdTrabajador") = DBNull.Value
                        rowMovAna("IdVehiculo") = ""
                        rowMovAna("IdRuta") = DBNull.Value
                        rowMovAna("IdBanco") = DBNull.Value
                        rowMovAna("IdAnalisis1") = DBNull.Value
                        rowMovAna("IdAnalisis2") = DBNull.Value
                        rowMovAna("Activo") = 1
                        rowMovAna("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                        rowMovAna("Monto") = obj.MontoOperar * oeOblig.TipoCambio
                        rowMovAna("Saldo") = obj.MontoOperar * oeOblig.TipoCambio
                        rowMovAna("IdMovimientoAnalisis") = DBNull.Value
                        rowMovAna("IdGastoFuncion") = "1CH000090"
                        rowMovAna("IdOrigenProrrateo") = ""
                        dt_MA.Rows.Add(rowMovAna)
                        lsNumeroMovAna = lsNumeroMovAna + 1
                    End If

                    lsNumeroAsiento = lsNumeroAsiento + 1
                    lsNumeroNroAsientoD = lsNumeroNroAsientoD + 1
                    lsNumeroAsientoMov_MovDoc = lsNumeroAsientoMov_MovDoc + 1
                    lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1

                End If

            Next
            Return odObligacionFinanciera.GuardarLetras(dt_OFIN, dt_FecLetras, dt_OBLIDOC, dt_A, dt_AM, dt_AMMDOC, dt_CTAXCYP, dt_AMOFIN, dt_MA, oeOblig.leDocumentoAgregados)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarCreditoHipotecario(oeMovCajaBanco As e_MovimientoCajaBanco, leObligacion As List(Of e_ObligacionFinanciera), oeCtaCtble As e_CuentaContable) As Boolean Implements Il_ObligacionFinanciera.GuardarCreditoHipotecario
        Try
            If ValidarCreditoHipotecario(oeMovCajaBanco, leObligacion, oeCtaCtble) Then

                Dim oeOblig As New e_ObligacionFinanciera
                oeOblig = leObligacion(0)
                oeOblig.IdTipoObligacion = "1CH000000077"

                ObtenerCuentas(Year(oeOblig.FechaEmision))

                Dim oePeriodo As New e_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                Dim olPeriodo As New l_Periodo
                oePeriodo.Activo = True
                oePeriodo.Id = ""
                oePeriodo.Codigo = oeMovCajaBanco.Fecha.Year.ToString + "-" + oeMovCajaBanco.Fecha.Month.ToString
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
                oePeriodo = lePeriodo(0)

                Dim CodigoUnico As String = Date.Now.Year.ToString + Strings.Right("0" + Date.Now.Month.ToString, 2) + Strings.Right("0" + Date.Now.Day.ToString, 2) + Strings.Right("0" + Date.Now.Hour.ToString, 2) _
               + Strings.Right("0" + Date.Now.Minute.ToString, 2) + Strings.Right("0" + Date.Now.Second.ToString, 2) + Strings.Right("0" + Date.Now.Millisecond.ToString, 2)

                Dim IdObligacion As String = odObligacionFinanciera.UltimoIdInserta()
                Dim lsPrefijoObligacion As String = Left(IdObligacion, 3)
                Dim lsNumeroObligacion As Integer = CInt(Right(IdObligacion, Len(IdObligacion) - 3))

                Dim IdAsiento As String = odAsiento.UltimoIdInserta()
                Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
                Dim lsNumeroAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))

                Dim NroAsientoD As String = odAsiento.UltimoNroAsiento("1CH000020", oePeriodo.Id, "1")
                Dim lsPrefijoNroAsientoD As String = Left(NroAsientoD, 2)
                Dim lsNumeroNroAsientoD As Integer = CInt(Right(NroAsientoD, Len(NroAsientoD) - 2))

                Dim IdAsientoMovimiento As String = odAsientoMovimiento.UltimoIdInsertar()
                Dim lsPrefijoAsientoMovimiento As String = Left(IdAsientoMovimiento, 3)
                Dim lsNumeroAsientoMovimiento As Integer = CInt(Right(IdAsientoMovimiento, Len(IdAsientoMovimiento) - 3))

                Dim IdMovimientoCajaBanco As String = odMovCajaBanco.UltimoIdInserta()
                Dim lsPrefijoMovCajaBanco As String = Left(IdMovimientoCajaBanco, 3)
                Dim lsNumeroMovCajaBanco As Integer = CInt(Right(IdMovimientoCajaBanco, Len(IdMovimientoCajaBanco) - 3))

                Dim NroImpresion As String = ""
                Dim lsPrefijoNroImpresion As String = ""
                Dim lsNroImpresion As Integer = 0
                If Len(Trim(oeMovCajaBanco.IdCuentaBancaria)) = 12 Then
                    NroImpresion = odAsiento.UltimoNroAsiento(oeMovCajaBanco.IdCuentaBancaria, oePeriodo.Id, "2")
                    lsPrefijoNroImpresion = Left(NroImpresion, 2)
                    lsNroImpresion = CInt(Right(NroImpresion, Len(NroImpresion) - 2))
                End If

                Dim IdAsientoMov_ObliFin As String = odAsMovObliFin.UltimoIdInserta()
                Dim lsPrefijoAsientoMov_ObliFin As String = Left(IdAsientoMov_ObliFin, 3)
                Dim lsNumeroAsientoMov_ObliFin As Integer = CInt(Right(IdAsientoMov_ObliFin, Len(IdAsientoMov_ObliFin) - 3))

                Dim IdMovAna As String = odMovimientoAnalisis.UltimoIdInserta()
                Dim lsPrefijoMovAna As String = Left(IdMovAna, 3)
                Dim lsNumeroMovAna As Integer = CInt(Right(IdMovAna, Len(IdMovAna) - 3))

                Dim dt_A As Data.DataTable = olAsiento.CrearDT()
                Dim dt_MCB As Data.DataTable = olMovCajaBanco.CrearDT()
                Dim dt_AM As Data.DataTable = olAsientoMovimiento.CrearDT()
                Dim dt_OFIN As Data.DataTable = CrearDT()
                Dim dt_AMOFIN As Data.DataTable = olAsMovObliFin.CrearDT()
                Dim dt_MA As Data.DataTable = olMovimientoAnalisis.CrearDT

                Dim nrolinea As Integer = 2

                Dim rowAsiento As Data.DataRow
                rowAsiento = dt_A.NewRow
                rowAsiento("Id") = lsPrefijoAsiento.ToString + CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rowAsiento("IdPeriodo") = oePeriodo.Id
                rowAsiento("IdTipoAsiento") = "1CH000020"
                rowAsiento("NroAsiento") = lsPrefijoNroAsientoD + CompletaConCeros(lsNumeroNroAsientoD, 7).ToString
                rowAsiento("Fecha") = oeOblig.FechaEmision
                rowAsiento("Glosa") = "OBLIGACION FIN. CREDITO HIPOTECARIO " + oeOblig._NombreBanco.ToString
                rowAsiento("GlosaImprime") = "OBLIGACION FIN. CREDITO HIPOTECARIO " + oeOblig._NombreBanco.ToString
                rowAsiento("IdMoneda") = oeOblig.IdMoneda
                rowAsiento("TipoCambio") = oeOblig.TipoCambio
                rowAsiento("TotalDebe") = leObligacion.Sum(Function(i) i.Saldo)
                rowAsiento("TotalHaber") = leObligacion.Sum(Function(i) i.Saldo)
                rowAsiento("IdUsuarioBloquea") = ""
                rowAsiento("UsuarioCreacion") = oeOblig.UsuarioCreacion
                rowAsiento("IdEstado") = "1CH00005"
                rowAsiento("IdAsientoExtorno") = ""
                rowAsiento("FechaCreacion") = Date.Now()
                rowAsiento("Activo") = True
                rowAsiento("NroAsientoImprime") = DBNull.Value
                rowAsiento("IdentificaAsiento") = DBNull.Value
                rowAsiento("IndRevision") = DBNull.Value
                rowAsiento("FechaRevision") = DBNull.Value
                rowAsiento("UsuarioRevision") = DBNull.Value
                rowAsiento("IndOrigen") = 31
                rowAsiento("UsuarioModificacion") = DBNull.Value
                rowAsiento("FechaModificacion") = DBNull.Value
                dt_A.Rows.Add(rowAsiento)

                Dim rowMovCajaBanco As Data.DataRow
                rowMovCajaBanco = dt_MCB.NewRow
                rowMovCajaBanco("Id") = lsPrefijoMovCajaBanco + CompletaConCeros(lsNumeroMovCajaBanco.ToString, 13)
                rowMovCajaBanco("IdFlujoCaja") = oeMovCajaBanco.IdFlujoCaja
                rowMovCajaBanco("NroBoucher") = oeMovCajaBanco.NroBoucher
                rowMovCajaBanco("IdCuentaBancaria") = oeMovCajaBanco.IdCuentaBancaria
                rowMovCajaBanco("Fecha") = oeMovCajaBanco.Fecha
                rowMovCajaBanco("IdTipoDocumento") = oeMovCajaBanco.IdMedioPago
                rowMovCajaBanco("IdPeriodoConcilia") = ""
                rowMovCajaBanco("Activo") = True
                rowMovCajaBanco("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                rowMovCajaBanco("TipoCambio") = oeMovCajaBanco.TipoCambio
                rowMovCajaBanco("TotalMN") = oeMovCajaBanco.TotalMN
                rowMovCajaBanco("TotalME") = oeMovCajaBanco.TotalME
                rowMovCajaBanco("Operador") = 1
                rowMovCajaBanco("NroImpresion") = IIf(Len(Trim(oeMovCajaBanco.IdCuentaBancaria)) = 12, lsPrefijoNroImpresion + CompletaConCeros(lsNroImpresion.ToString, 8), "")
                rowMovCajaBanco("IdTipoGasto") = ""
                dt_MCB.Rows.Add(rowMovCajaBanco)

                Dim rowAsientoMov_Inicial As Data.DataRow
                rowAsientoMov_Inicial = dt_AM.NewRow
                rowAsientoMov_Inicial("Id") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                rowAsientoMov_Inicial("IdAsiento") = lsPrefijoAsiento + CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rowAsientoMov_Inicial("IdCuentaContable") = oeCtaCtble.Id
                rowAsientoMov_Inicial("Glosa") = oeMovCajaBanco.Glosa
                rowAsientoMov_Inicial("DebeMN") = oeMovCajaBanco.TotalMN
                rowAsientoMov_Inicial("HaberMN") = 0
                rowAsientoMov_Inicial("DebeME") = oeMovCajaBanco.TotalME
                rowAsientoMov_Inicial("HaberME") = 0
                rowAsientoMov_Inicial("IdUsuarioCrea") = oeOblig.UsuarioCreacion
                rowAsientoMov_Inicial("FechaCreacion") = Date.Now()
                rowAsientoMov_Inicial("Activo") = True
                rowAsientoMov_Inicial("NroLinea") = 1
                dt_AM.Rows.Add(rowAsientoMov_Inicial)
                lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1

                For Each obj In leObligacion

                    Dim rowOfin As Data.DataRow
                    rowOfin = dt_OFIN.NewRow
                    rowOfin("Id") = lsPrefijoObligacion.ToString + CompletaConCeros(lsNumeroObligacion.ToString, 12).ToString
                    rowOfin("Codigo") = obj.Codigo
                    rowOfin("IdEmpresaBanco") = obj.IdEmpresaBanco
                    rowOfin("Glosa") = obj.Glosa
                    rowOfin("FechaEmision") = obj.FechaEmision
                    rowOfin("FechaVencimiento") = obj.FechaVencimiento
                    rowOfin("IdTipoObligacion") = "1CH000000077"
                    rowOfin("IdMoneda") = obj.IdMoneda
                    rowOfin("TipoCambio") = obj.TipoCambio
                    rowOfin("MontoMN") = obj.MontoMN
                    rowOfin("MontoME") = obj.MontoME
                    rowOfin("Saldo") = IIf(obj.IdMoneda = "1CH01", obj.MontoMN, obj.MontoME)
                    rowOfin("TasaInteres") = obj.TasaInteres
                    rowOfin("MontoInteresTes") = obj.MontoInteresTes
                    rowOfin("MontoInteresCon") = 0.0
                    rowOfin("MontoInteresMoratorio") = 0.0
                    rowOfin("Comision") = 0.0
                    rowOfin("Activo") = True
                    rowOfin("IdCuentaContable") = IIf(obj.IdMoneda = "1CH01", leCuentasGenerales.Where(Function(i) i.Nombre = "CTACREDITOHIPOSOLES")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTACREDITOHIPODOLARES")(0).Texto2)
                    rowOfin("UsuarioCreacion") = obj.UsuarioCreacion
                    rowOfin("FechaCreacion") = Date.Now()
                    rowOfin("MacPCLocalCreacion") = obj.MacPcLocalCreacion
                    rowOfin("IdCuentaContableInteres") = IIf(obj.IdMoneda = "1CH01", leCuentasGenerales.Where(Function(i) i.Nombre = "CTACREDITOHIPOINTERESSOLES")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTACREDITOHIPOINTERESDOLARES")(0).Texto2)
                    rowOfin("IdCuentaBancaria") = oeMovCajaBanco.IdCuentaBancaria
                    rowOfin("Gastos") = 0.0
                    rowOfin("CodigoUnico") = CodigoUnico
                    rowOfin("Voucher") = DBNull.Value
                    rowOfin("GlosaCtaxCyP") = DBNull.Value
                    rowOfin("MontoInteresDscto") = 0.0
                    dt_OFIN.Rows.Add(rowOfin)

                    Dim rowAsientoMovimiento As Data.DataRow
                    rowAsientoMovimiento = dt_AM.NewRow
                    rowAsientoMovimiento("Id") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                    rowAsientoMovimiento("IdAsiento") = lsPrefijoAsiento + CompletaConCeros(lsNumeroAsiento.ToString, 12)
                    rowAsientoMovimiento("IdCuentaContable") = IIf(obj.IdMoneda = "1CH01", leCuentasGenerales.Where(Function(i) i.Nombre = "CTACREDITOHIPOSOLES")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTACREDITOHIPODOLARES")(0).Texto2)
                    rowAsientoMovimiento("Glosa") = obj.Glosa
                    rowAsientoMovimiento("DebeMN") = 0
                    rowAsientoMovimiento("HaberMN") = Math.Round(obj.MontoMN, 2) + Math.Round(IIf(obj.IdMoneda = "1CH01", obj.MontoInteresTes, obj.MontoInteresTes * obj.TipoCambio), 2)
                    rowAsientoMovimiento("DebeME") = 0
                    rowAsientoMovimiento("HaberME") = Math.Round(obj.MontoME, 2) + Math.Round(IIf(obj.IdMoneda = "1CH02", obj.MontoInteresTes, obj.MontoInteresTes / obj.TipoCambio), 2)
                    rowAsientoMovimiento("IdUsuarioCrea") = obj.UsuarioCreacion
                    rowAsientoMovimiento("FechaCreacion") = Date.Now()
                    rowAsientoMovimiento("Activo") = True
                    rowAsientoMovimiento("NroLinea") = nrolinea
                    dt_AM.Rows.Add(rowAsientoMovimiento)


                    Dim rowAsMov_ObliFin As Data.DataRow
                    rowAsMov_ObliFin = dt_AMOFIN.NewRow
                    rowAsMov_ObliFin("Id") = lsPrefijoAsientoMov_ObliFin + CompletaConCeros(lsNumeroAsientoMov_ObliFin, 12)
                    rowAsMov_ObliFin("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                    rowAsMov_ObliFin("IdObligacionFinanciera") = lsPrefijoObligacion.ToString + CompletaConCeros(lsNumeroObligacion.ToString, 12)
                    rowAsMov_ObliFin("Activo") = True
                    rowAsMov_ObliFin("IdObligacionPago") = DBNull.Value
                    dt_AMOFIN.Rows.Add(rowAsMov_ObliFin)

                    nrolinea = nrolinea + 1
                    lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1

                    If obj.MontoInteresTes > 0 Then
                        Dim rowAsientoMovimientoInteres As Data.DataRow
                        rowAsientoMovimientoInteres = dt_AM.NewRow
                        rowAsientoMovimientoInteres("Id") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                        rowAsientoMovimientoInteres("IdAsiento") = lsPrefijoAsiento + CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rowAsientoMovimientoInteres("IdCuentaContable") = IIf(obj.IdMoneda = "1CH01", leCuentasGenerales.Where(Function(i) i.Nombre = "CTACREDITOHIPOINTERESSOLES")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTACREDITOHIPOINTERESDOLARES")(0).Texto2)
                        rowAsientoMovimientoInteres("Glosa") = obj.Glosa
                        rowAsientoMovimientoInteres("DebeMN") = Math.Round(IIf(obj.IdMoneda = "1CH01", obj.MontoInteresTes, obj.MontoInteresTes * obj.TipoCambio), 2)
                        rowAsientoMovimientoInteres("HaberMN") = 0
                        rowAsientoMovimientoInteres("DebeME") = Math.Round(IIf(obj.IdMoneda = "1CH01", obj.MontoInteresTes / obj.TipoCambio, obj.MontoInteresTes), 2)
                        rowAsientoMovimientoInteres("HaberME") = 0
                        rowAsientoMovimientoInteres("IdUsuarioCrea") = obj.UsuarioCreacion
                        rowAsientoMovimientoInteres("FechaCreacion") = Date.Now()
                        rowAsientoMovimientoInteres("Activo") = True
                        rowAsientoMovimientoInteres("NroLinea") = nrolinea
                        dt_AM.Rows.Add(rowAsientoMovimientoInteres)

                        Dim rowMovAna As Data.DataRow
                        rowMovAna = dt_MA.NewRow
                        rowMovAna("Id") = lsPrefijoMovAna & CompletaConCeros(lsNumeroMovAna.ToString, 13)
                        rowMovAna("IdCentroCosto") = DBNull.Value
                        rowMovAna("IdItemGasto") = DBNull.Value
                        rowMovAna("IdTrabajador") = DBNull.Value
                        rowMovAna("IdVehiculo") = DBNull.Value
                        rowMovAna("IdRuta") = DBNull.Value
                        rowMovAna("IdBanco") = DBNull.Value
                        rowMovAna("IdAnalisis1") = DBNull.Value
                        rowMovAna("IdAnalisis2") = DBNull.Value
                        rowMovAna("Activo") = 1
                        rowMovAna("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                        rowMovAna("Monto") = obj.MontoInteresTes
                        rowMovAna("Saldo") = obj.MontoInteresTes
                        rowMovAna("IdMovimientoAnalisis") = DBNull.Value
                        rowMovAna("IdGastoFuncion") = "1CH000090"
                        rowMovAna("IdOrigenProrrateo") = ""
                        dt_MA.Rows.Add(rowMovAna)

                        nrolinea = nrolinea + 1
                        lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1
                        lsNumeroMovAna = lsNumeroMovAna + 1
                    End If


                    lsNumeroObligacion = lsNumeroObligacion + 1
                    lsNumeroAsientoMov_ObliFin = lsNumeroAsientoMov_ObliFin + 1

                Next

                odObligacionFinanciera.GuardarCreditoHipotecario(dt_OFIN, dt_A, dt_AM, dt_AMOFIN, dt_MCB, dt_MA)

                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCreditoHipotecario(oeMovCajaBanco As e_MovimientoCajaBanco, leObligacion As List(Of e_ObligacionFinanciera), oeCtaCtble As e_CuentaContable)
        Try
            If leObligacion.Count = 0 Then Throw New Exception("Agrege cuotas al detalle")
            If oeMovCajaBanco.NroBoucher = "" Then Throw New Exception("Ingrese el número de Operación.")
            For Each obj In leObligacion
                If obj.IdMoneda = "1CH01" Then
                    If oeCtaCtble.MonedaExtrangera = 1 Then Throw New Exception("La cuenta pertenece a moneda extranjera , la obligaión está en soles. Cuota: " + obj.Codigo)
                Else
                    If oeCtaCtble.MonedaExtrangera = 0 Then Throw New Exception("La cuenta pertenece a moneda nacional , la obligaión está en dólares. Cuota: " + obj.Codigo)
                End If
                If obj.TipoCambio <> oeMovCajaBanco.TipoCambio Then Throw New Exception("Tipo de cambio no coincide. Cuota: " + obj.Codigo)
            Next
            If oeCtaCtble.MonedaExtrangera = 0 Then
                If Math.Round(oeMovCajaBanco.TotalMN, 2) <> Math.Round((leObligacion.Sum(Function(i) i.MontoMN)), 2) Then Throw New Exception("Monto total y suma de cuotas en MN, no coincide")
            ElseIf oeCtaCtble.MonedaExtrangera = 1 Then
                If Math.Round(oeMovCajaBanco.TotalME, 2) <> Math.Round((leObligacion.Sum(Function(i) i.MontoME)), 2) Then Throw New Exception("Monto total y suma de cuotas en ME, no coincide")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Intereses de Obligaciones"

    Public Function GuardarInteresMensualPagoCrediHipoSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualPagoCrediHipoSoles
        Try

            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "CHCSOLES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH01"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para para Credito-Hipo")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "CHI"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH01"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres 67------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTACREDITOHIPOINTERESSOLES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres 45------------------------
            '    Dim oeTCD45 As New e_TablaContableDet
            '    oeTCD45.TipoOperacion = "N"
            '    oeTCD45.Activo = True
            '    oeTCD45.Nombre = "CUENTAS GENERALES"
            '    oeTCD45.Valor1 = Fecha.Year
            '    oeTCD45.Texto1 = "CTAPUENTECREDITOHIPOSOLES"
            '    oeTCD45 = odTCD.Listar(oeTCD45)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalSoles As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalSoles = TotalSoles + rows("MontoInteresTes")
            '    Next
            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PAGO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO"
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH01"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalSoles
            '        .TotalHaber = TotalSoles
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "CHCSOLES" & lsIdObligacion
            '    End With

            '    'Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    Dim oeAsientoMovimiento45A As New e_AsientoMovimiento
            '    Dim oeAsientoMovimiento10 As New e_AsientoMovimiento
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows

            '        '--------------- 45A------------------------------
            '        oeAsientoMovimiento45A = New e_AsientoMovimiento
            '        With oeAsientoMovimiento45A
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD45.Texto2
            '            .Glosa = "PAGO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = 0
            '            .HaberME = 0
            '            .DebeMN = rows("MontoInteresTes")
            '            .DebeME = rows("MontoInteresTes") / TipoCambio
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento45A)

            '        '--------------- 10-----------------------------------------------------------
            '        oeAsientoMovimiento10 = New e_AsientoMovimiento
            '        With oeAsientoMovimiento10
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = IIf(rows("IdCuentaContable") = "", IIf(oeAsiento.IdMoneda = "1CH01", rows("CuentaPagoMN"), rows("CuentaPagoME")), rows("IdCuentaContable"))
            '            .Glosa = "PAGO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("MontoInteresTes")
            '            .HaberME = rows("MontoInteresTes") / TipoCambio
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de la cuenta 10--------------
            '            .MovimientoCajaBanco = New e_MovimientoCajaBanco
            '            With .MovimientoCajaBanco
            '                .TipoOperacion = "I"
            '                .TotalMN = rows("MontoInteresTes")
            '                .TotalME = rows("MontoInteresTes") / TipoCambio
            '                .Activo = 1
            '                .Fecha = Fecha
            '                .IdFlujoCaja = "1CH000000212"
            '                .NroBoucher = "0000000000"
            '                .TipoCambio = TipoCambio
            '                ._Operador = -1
            '                .IdCuentaBancaria = rows("IdCuentaBancaria")
            '                .IdMedioPago = "1CH05"
            '                .IdPeriodoConcilia = ""
            '            End With
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento10)

            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarInteresMensualPagoCrediHipoDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean Implements Il_ObligacionFinanciera.GuardarInteresMensualPagoCrediHipoDolares
        Try
            'Dim leObligacion As New List(Of e_ObligacionFinanciera)
            'Dim oeObligacioDoc As New e_ObligacionDocumento
            'Dim oeObligFinan As New e_ObligacionFinanciera
            'Dim odObligFinan As New d_ObligacionFinanciera

            'Dim oePeriodo As New e_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            'Dim olPeriodo As New l_Periodo
            'oePeriodo.Activo = True
            'oePeriodo.Id = ""
            'oePeriodo.Codigo = Fecha.Year.ToString + "-" + Fecha.Month.ToString
            'lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            'Dim oeAsiento2 As New e_Asiento
            'Dim olAsiento2 As New l_Asiento
            'Dim leAsiento2 As New List(Of e_Asiento)

            'oeAsiento2.IdPeriodo = lePeriodo(0).Id
            'oeAsiento2.IdentificaAsiento = "CHCDOLARES" & lsIdObligacion
            'oeAsiento2.IdMoneda = "1CH02"
            'leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))

            'If leAsiento2.Count > 0 Then
            '    Throw New Exception("Ya existe el asiento para para Credito-Hipo")
            'End If

            ''------------
            'Dim DtTodos As DataTable
            'oeObligFinan.TipoOperacion = "CHI"
            'oeObligFinan.FechaEmision = Fecha
            'oeObligFinan.IdMoneda = "1CH02"
            'oeObligFinan.Id = lsIdObligacion
            'DtTodos = odObligFinan.ListarDatable(oeObligFinan)
            'If DtTodos.Rows.Count > 0 Then
            '    Dim olFuncionesGenerales As New l_FuncionesGenerales
            '    olFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, Fecha, Fecha.Year.ToString + "-" + Fecha.Month.ToString)

            '    '-----------ctaInteres 67------------------------
            '    Dim odTCD As New d_TablaContableDet
            '    Dim oeTCD2 As New e_TablaContableDet
            '    oeTCD2.TipoOperacion = "N"
            '    oeTCD2.Activo = True
            '    oeTCD2.Nombre = "CUENTAS GENERALES"
            '    oeTCD2.Valor1 = Fecha.Year
            '    oeTCD2.Texto1 = "CTACREDITOHIPOINTERESDOLARES"
            '    oeTCD2 = odTCD.Listar(oeTCD2)(0)
            '    '---------------------------------------
            '    '-----------ctaInteres 45------------------------
            '    Dim oeTCD45 As New e_TablaContableDet
            '    oeTCD45.TipoOperacion = "N"
            '    oeTCD45.Activo = True
            '    oeTCD45.Nombre = "CUENTAS GENERALES"
            '    oeTCD45.Valor1 = Fecha.Year
            '    oeTCD45.Texto1 = "CTAPUENTECREDITOHIPODOLARES"
            '    oeTCD45 = odTCD.Listar(oeTCD45)(0)
            '    '---------------------------------------
            '    '------------
            '    Dim TotalDolares As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows
            '        TotalDolares = TotalDolares + rows("MontoInteresTes")
            '    Next
            '    '----------------------ASIENTO PROVISION EN SOLES--------------------------

            '    Dim oeAsiento As New e_Asiento
            '    With oeAsiento
            '        .TipoOperacion = "I"
            '        .IdPeriodo = lePeriodo(0).Id
            '        .IdTipoAsiento = "DIARIO"
            '        .Fecha = lsFechaAsiento
            '        .Glosa = "PAGO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO"
            '        .GlosaImprime = .Glosa
            '        .IdMoneda = "1CH02"
            '        .TipoCambio = TipoCambio
            '        .TotalDebe = TotalDolares
            '        .TotalHaber = TotalDolares
            '        .IdUsuarioCrea = UsuarioCreacion
            '        .IdEstado = "CUADRADO"
            '        .IdentificaAsiento = "CHCSOLES" & lsIdObligacion
            '    End With

            '    'Dim oeAsientoMovimiento As New e_AsientoMovimiento
            '    Dim oeAsientoMovimiento45A As New e_AsientoMovimiento
            '    Dim oeAsientoMovimiento10 As New e_AsientoMovimiento
            '    Dim oeObli As New e_ObligacionFinanciera
            '    Dim InteresMN As Double = 0
            '    Dim InteresME As Double = 0
            '    For Each rows As DataRow In DtTodos.Rows

            '        '--------------- 45A------------------------------
            '        oeAsientoMovimiento45A = New e_AsientoMovimiento
            '        With oeAsientoMovimiento45A
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = oeTCD45.Texto2
            '            .Glosa = "PAGO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = 0
            '            .HaberME = 0
            '            .DebeMN = rows("MontoInteresTes") * TipoCambio
            '            .DebeME = rows("MontoInteresTes")
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de obligacion con asiento_movimiento--------------
            '            .AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
            '            With .AsMov_ObligacionFin
            '                .TipoOperacion = "I"
            '                .IdAsientoMovimiento = ""
            '                .IdObligacionFinanciera = rows("Id")
            '                .Activo = True
            '                .ObligacionFin = oeObli
            '            End With
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento45A)

            '        '--------------- 10-----------------------------------------------------------
            '        oeAsientoMovimiento10 = New e_AsientoMovimiento
            '        With oeAsientoMovimiento10
            '            .TipoOperacion = "I"
            '            .IdCuentaContable = IIf(rows("IdCuentaContable") = "", IIf(oeAsiento.IdMoneda = "1CH01", rows("CuentaPagoMN"), rows("CuentaPagoME")), rows("IdCuentaContable"))
            '            .Glosa = "PAGO INTERES OBLIGACION FIN. CREDITO HIPOTECARIO " & rows("Codigo") & "/" & rows("Banco")
            '            .HaberMN = rows("MontoInteresTes") * TipoCambio
            '            .HaberME = rows("MontoInteresTes")
            '            .DebeMN = 0
            '            .DebeME = 0
            '            .IdUsuarioCrea = UsuarioCreacion
            '            .Activo = True
            '            '----------------relacion de la cuenta 10--------------
            '            .MovimientoCajaBanco = New e_MovimientoCajaBanco
            '            With .MovimientoCajaBanco
            '                .TipoOperacion = "I"
            '                .TotalMN = rows("MontoInteresTes") * TipoCambio
            '                .TotalME = rows("MontoInteresTes")
            '                .Activo = 1
            '                .Fecha = Fecha
            '                .IdFlujoCaja = "1CH000000212"
            '                .NroBoucher = "0000000000"
            '                .TipoCambio = TipoCambio
            '                ._Operador = -1
            '                .IdCuentaBancaria = rows("IdCuentaBancaria")
            '                .IdMedioPago = "1CH05"
            '                .IdPeriodoConcilia = ""
            '            End With
            '        End With
            '        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento10)

            '    Next
            '    Return odObligacionFinanciera.GuardarVariasObligaciones(leObligacion, oeAsiento, Nothing, True)
            'Else
            '    Return True
            'End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

End Class
