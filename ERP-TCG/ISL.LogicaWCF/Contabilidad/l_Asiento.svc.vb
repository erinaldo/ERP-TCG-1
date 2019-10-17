'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()>
Public Class l_Asiento
    Implements Il_Asiento

    Dim odAsiento As New d_Asiento
    Dim odAsientoMovimiento As New d_AsientoMovimiento
    Dim odMovCajaBanco As New d_MovimientoCajaBanco
    Dim odCuentaxCyP As New d_CuentaxCyP
    Dim odAsMovMovDoc As New d_AsientoMov_MovDoc
    Dim odMovimientoAnalisis As New d_MovimientoAnalisis
    Dim odMovimientoDocumento As New d_MovimientoDocumento
    Dim odAsiMovOblFin As New d_AsientoMov_ObligacionFin
    Dim olAsientoReferencia As l_AsientoReferencia
    Dim odAsientoReferencia As d_AsientoReferencia

    Dim olAsientoMovimiento As New l_AsientoMovimiento
    Dim olMovCajaBanco As New l_MovimientoCajaBanco
    Dim olCuentaxCyP As New l_CuentaxCyP
    Dim olAsientoMov_MovDoc As New l_AsientoMov_MovDoc
    Dim olMovimientoAnalisis As New l_MovimientoAnalisis
    Dim olAsiMovOblFin As New l_AsientoMov_ObligacionFin

    Dim oeCuentaGenerales As New e_TablaContableDet
    Dim leCuentasGenerales As New List(Of e_TablaContableDet)
    Dim olFuncionesGenerales As New l_FuncionesGenerales

    Private _IdAsientoRef As String
    Private odSaldoCtaCte As New d_SaldoCtaCorriente

#Region "Variables"

    Public Function CrearDT() As System.Data.DataTable Implements Il_Asiento.CrearDT
        Dim Asiento As New Data.DataTable
        With Asiento
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPeriodo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTipoAsiento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NroAsiento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Fecha", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Glosa", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("GlosaImprime", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMoneda", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoCambio", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TotalDebe", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TotalHaber", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdUsuarioBloquea", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdEstado", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdAsientoExtorno", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("NroAsientoImprime", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdentificaAsiento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndRevision", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("FechaRevision", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioRevision", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndOrigen", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("UsuarioModificacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModificacion", Type.GetType("System.DateTime")))
            '.Columns.Add(New Data.DataColumn("CodigoUnicoOperacion", Type.GetType("System.String")))
        End With
        Return Asiento
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

    Public Function Captura_Valor(ByVal cta As String, ByVal dsobj As System.Data.DataTable) As Single Implements Il_Asiento.Captura_Valor
        Dim var As Single = 0
        For i As Integer = 0 To dsobj.Rows.Count - 1
            If dsobj.Rows(i).Item("IdCuentaContable").ToString = cta Then
                var = dsobj.Rows(i).Item("Total")
                Return var
                Exit For
            End If
        Next
        Return var
    End Function

    Public Function ValidaConsumoAlmacen(oeAsiento As e_Asiento) As Boolean
        Try
            Dim oeAsi As New e_Asiento
            Dim loAsi As New List(Of e_Asiento)
            With oeAsiento
                If .TipoOperacion = "I" Then
                    oeAsi.IdentificaAsiento = .IdentificaAsiento
                    oeAsi.IdPeriodo = .IdPeriodo
                    loAsi.AddRange(odAsiento.Listar(oeAsi))
                    If loAsi.Count > 0 Then
                        Throw New Exception("Asiento de Comsumo Ya Genereado para Este Almacen y Periodo")
                    End If
                End If
                Return True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CorrelativoAsiento(ByVal IdPeriodo As String) As Boolean Implements Il_Asiento.CorrelativoAsiento
        Try
            Return odAsiento.CorrelativoAsiento(IdPeriodo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function DuplicaAsiento(ByVal oeAsiento As EntidadesWCF.e_Asiento) As Boolean Implements Il_Asiento.DuplicaAsiento
        Try
            '----------valida-----------------
            Dim loFuncionesGenerales As New l_FuncionesGenerales
            loFuncionesGenerales.ValidarPeriodo(oeAsiento.IdPeriodo, gAreasSGI.Contabilidad, oeAsiento.Fecha, "")
            '----------------------------------
            Return odAsiento.DuplicaAsiento(oeAsiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsiento As EntidadesWCF.e_Asiento) As Boolean Implements Il_Asiento.Eliminar
        Try
            Return odAsiento.Eliminar(oeAsiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EliminarCobroPago(ByVal oeAsiento As EntidadesWCF.e_Asiento) As Boolean Implements Il_Asiento.EliminarCobroPago
        Try
            Dim oe_Asto As New e_Asiento
            Dim ol_Asto As New l_Asiento
            oe_Asto.Id = oeAsiento.Id
            Dim oe_periodo As New e_Periodo
            Dim ol_periodo As New l_Periodo
            oe_periodo.Id = ol_Asto.Listar(oe_Asto).Item(0).IdPeriodo
            oeAsiento.IdPeriodo = ol_periodo.Listar(oe_periodo).Item(0).Codigo
            Dim loFuncionesGenerales As New l_FuncionesGenerales
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, "01/01/1901", oeAsiento.IdPeriodo)
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, "01/01/1901", oeAsiento.IdPeriodo)

            Dim oeMovCajaBanco As New e_MovimientoCajaBanco
            Dim olMovCajaBanco As New l_MovimientoCajaBanco
            Dim leMovCajaBanco As New List(Of e_MovimientoCajaBanco)
            oeMovCajaBanco.TipoOperacion = "C"
            oeMovCajaBanco.Id = oeAsiento._IdMovimientoCajaBanco
            leMovCajaBanco.Clear()
            leMovCajaBanco = olMovCajaBanco.Listar(oeMovCajaBanco)
            If leMovCajaBanco.Count() > 0 Then Throw New Exception("No se puede extonar, el monto fué conciliado por Contabilidad")

            Dim oeCCP As New e_CuentaxCyP
            Dim leCCP As New List(Of e_CuentaxCyP)
            Dim olCCP As New l_CuentaxCyP
            oeCCP.Activo = True
            oeCCP.TipoOperacion = "REL"
            oeCCP.IdAsientoElimina = oeAsiento.Id
            leCCP.AddRange(olCCP.Listar(oeCCP))
            ' ################## SI SE EXTORNA UN PAGO DESDE CONTROL DE PAGO: VALIDA RETENCIONES ################### 
            Dim oeDocRetDet As e_DocumentoRetencionDetalle
            Dim olDocRetDet As l_DocumentoRetencionDetalle
            Dim list_DocRetDet As List(Of e_DocumentoRetencionDetalle)
            Dim list_CtaPMR As List(Of e_CuentaxPDocumentoRetencion)
            Dim oeDocRet As e_DocumentoRetencion
            Dim olDocRet As l_DocumentoRetencion
            Dim oeMovDoc As e_MovimientoDocumento
            Dim olMovDoc As l_MovimientoDocumento
            Dim oeCtaPMR As e_CuentaxPDocumentoRetencion
            Dim olCtaPMR As l_CuentaxPDocumentoRetencion
            Dim msj As String = String.Empty
            Dim lista As New List(Of e_DocumentoRetencionDetalle)
            If Not oeAsiento.NroAsiento.Trim Is String.Empty Then
                ' EXTORNO DE UN PAGO DE UN DOCUMENTO NORMAL
                For Each fila In leCCP
                    oeDocRetDet = New e_DocumentoRetencionDetalle
                    oeDocRetDet.IdMovimientoDocumento = fila.IdMovimientoDocumento
                    If oeAsiento.NroAsiento.StartsWith("LETRA") Then
                        oeDocRetDet.NroVoucher = ""
                    Else
                        oeDocRetDet.NroVoucher = oeAsiento.NroAsiento
                    End If
                    oeDocRetDet.Activo = True
                    olDocRetDet = New l_DocumentoRetencionDetalle
                    list_DocRetDet = New List(Of e_DocumentoRetencionDetalle)
                    list_DocRetDet = olDocRetDet.Listar(oeDocRetDet)
                    If list_DocRetDet.Count > 0 Then
                        oeDocRetDet = list_DocRetDet.Item(0)
                        lista.Add(oeDocRetDet)
                        If Not oeDocRetDet.IdDocumentoRetencion.Trim Is String.Empty Then
                            oeMovDoc = New e_MovimientoDocumento
                            oeMovDoc.Id = fila.IdMovimientoDocumento()
                            olMovDoc = New l_MovimientoDocumento
                            oeMovDoc = olMovDoc.Listar(oeMovDoc).Item(0)
                            msj &= oeMovDoc.Serie & "-" & oeMovDoc.Numero & ", "
                        End If
                    End If
                Next
                If Not msj Is String.Empty Then
                    Throw New Exception("Existen retenciones pagadas a las siguientes facturas a extornar: " & vbCrLf &
                                     msj.Substring(0, Len(msj) - 2))
                End If

                oeAsiento.NroAsiento = "CONTROL"
            Else
                'EXTORNO DE UNA RETENCIÓN VALIDA SI FUE EMITIDO A SUNAT
                For Each fila In leCCP
                    oeCtaPMR = New e_CuentaxPDocumentoRetencion
                    oeCtaPMR.IdCuentaxCyP = fila.Id
                    oeCtaPMR.IdMovimientoDocumento = fila.Id
                    oeCtaPMR.Activo = True
                    olCtaPMR = New l_CuentaxPDocumentoRetencion
                    list_CtaPMR = New List(Of e_CuentaxPDocumentoRetencion)
                    list_CtaPMR = olCtaPMR.Listar(oeCtaPMR)
                    If list_CtaPMR.Count > 0 Then
                        oeCtaPMR = list_CtaPMR.Item(0)
                        oeDocRet = New e_DocumentoRetencion
                        oeDocRet.Id = oeCtaPMR.IdDocumentoRetencion
                        oeDocRet.Activo = 1
                        olDocRet = New l_DocumentoRetencion
                        oeDocRet = olDocRet.Obtener(oeDocRet)
                        If oeDocRet.EstadoElectronico <> "C" Then
                            Throw New Exception("La retención del documento ha sido emitida a SUNAT. No se puede extornar.")
                        End If
                    End If
                Next
            End If
            ' ############################## ############################## ############################## 
            If odAsiento.EliminarCobroPago(oeAsiento, leCCP) Then
                If oeAsiento.NroAsiento = "CONTROL" Then
                    ' SI EL PAGO SE ELIMINA SE ELIMINA LA RETENCIONES PAGADAS ASOCIADAS SIN VOLVERLAS A GENERAR.
                    For Each obj In lista
                        olDocRetDet = New l_DocumentoRetencionDetalle
                        obj.TipoOperacion = "Z"
                        olDocRetDet.Eliminar(obj)
                    Next
                End If
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarCobroPago2(ByVal oeAsiento As EntidadesWCF.e_Asiento) As Boolean Implements Il_Asiento.EliminarCobroPago2
        Try
            Dim loFuncionesGenerales As New l_FuncionesGenerales
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, "01/01/1901", oeAsiento.IdPeriodo)
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Contabilidad, "01/01/1901", oeAsiento.IdPeriodo)

            Dim oeMovCajaBanco As New e_MovimientoCajaBanco
            Dim olMovCajaBanco As New l_MovimientoCajaBanco
            Dim leMovCajaBanco As New List(Of e_MovimientoCajaBanco)
            oeMovCajaBanco.TipoOperacion = "C"
            oeMovCajaBanco.Id = oeAsiento._IdMovimientoCajaBanco
            leMovCajaBanco.Clear()
            leMovCajaBanco = olMovCajaBanco.Listar(oeMovCajaBanco)
            If leMovCajaBanco.Count() > 0 Then Throw New Exception("No se puede extonar, el monto fué conciliado por Contabilidad")

            Dim oeCCP As New e_CuentaxCyP
            Dim leCCP As New List(Of e_CuentaxCyP)
            Dim olCCP As New l_CuentaxCyP
            oeCCP.Activo = True
            oeCCP.TipoOperacion = "REL"
            oeCCP.IdAsientoElimina = oeAsiento.Id
            leCCP.AddRange(olCCP.Listar(oeCCP))
            Return odAsiento.EliminarCobroPago(oeAsiento, leCCP)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Evalua_Monto(ByVal monto As Double, ByVal cta As String, ByVal ds_Monto As System.Data.DataTable, ByVal ds_Div As System.Data.DataTable) As Double Implements Il_Asiento.Evalua_Monto
        Dim monto_act As Double
        If cta <> "" Then
            Dim var_Monto As Single = 0
            Dim var_Div As Single = 0
            var_Monto = Captura_Valor(cta, ds_Monto)
            var_Div = Captura_Valor(cta, ds_Div)
            If var_Monto = 0 Or var_Div = 0 Then
                monto_act = monto
            Else
                monto_act = monto + (var_Monto / var_Div)
            End If
            Return monto_act
        Else
            Return monto
        End If
    End Function

    Public Function GenerarAsientoConsumo(ByVal DtConsumo As System.Data.DataTable, ByVal ls_IdSubAlmacen As String, ByVal TipoCambio As Double,
    ByVal IdPeriodo As String, ByVal FecUltimoDia As Date, ByVal IdUsuarioCrea As String, ByVal PrefijoId As String) As Boolean Implements Il_Asiento.GenerarAsientoConsumo
        Dim lnCont As Integer = 0
        Try
            Dim oeAsiento As New e_Asiento
            Dim oeAsientoMovimiento As New e_AsientoMovimiento
            With oeAsiento
                .TipoOperacion = "I"
                .IdPeriodo = IdPeriodo
                .IdTipoAsiento = "DIARIO"
                .Fecha = FecUltimoDia
                .Glosa = "POR EL CONSUMO DE SUMINISTROS DE ALMACEN DEL MES DE " + FecUltimoDia.Month.ToString + "/" + FecUltimoDia.Year.ToString
                .GlosaImprime = oeAsiento.Glosa
                .IdMoneda = "1CH01"
                .TipoCambio = TipoCambio
                .IdUsuarioCrea = IdUsuarioCrea
                .IdEstado = "CUADRADO"
                .IdentificaAsiento = "CONMESUMIALM" + ls_IdSubAlmacen
                .Activo = True
            End With
            If ValidaConsumoAlmacen(oeAsiento) Then
                Dim Monto As Double = 0
                Dim MontoTotal As Double = 0
                Dim lsCuenta20 As String = ""
                Dim lsCuenta61 As String = ""
                Dim lnUltimo As Integer = DtConsumo.Rows.Count

                Dim oeMovAn As New e_MovimientoAnalisis
                DtConsumo.Select(Nothing, "IdCuentaContable")
                For Each obj As DataRow In DtConsumo.Rows
                    lnCont = lnCont + 1
                    If lsCuenta20 <> obj("IdCuentaContable") Then
                        If lsCuenta20 <> "" Then
                            oeAsientoMovimiento.DebeMN = Monto
                            oeAsientoMovimiento.DebeME = Monto / TipoCambio
                            oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                            oeAsientoMovimiento = New e_AsientoMovimiento
                            oeMovAn = New e_MovimientoAnalisis
                            oeAsientoMovimiento.TipoOperacion = "I"
                            oeAsientoMovimiento.IdCuentaContable = lsCuenta20
                            oeAsientoMovimiento.DebeMN = 0
                            oeAsientoMovimiento.DebeME = 0
                            oeAsientoMovimiento.HaberMN = Monto
                            oeAsientoMovimiento.HaberME = Monto / TipoCambio
                            oeAsientoMovimiento.Glosa = oeAsiento.Glosa
                            oeAsientoMovimiento.IdUsuarioCrea = IdUsuarioCrea
                            oeAsientoMovimiento.PrefijoID = PrefijoId '@0001
                            oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                        End If
                        Monto = 0
                        lsCuenta20 = obj("IdCuentaContable")
                        oeAsientoMovimiento = New e_AsientoMovimiento
                        oeMovAn = New e_MovimientoAnalisis
                        oeAsientoMovimiento.TipoOperacion = "I"
                        oeAsientoMovimiento.IdCuentaContable = obj("IdCuentaContable61")
                        oeAsientoMovimiento.DebeMN = obj("Total")
                        oeAsientoMovimiento.DebeME = obj("Total") / TipoCambio
                        oeAsientoMovimiento.HaberMN = 0
                        oeAsientoMovimiento.HaberME = 0
                        oeAsientoMovimiento.Glosa = oeAsiento.Glosa
                        oeAsientoMovimiento.IdUsuarioCrea = IdUsuarioCrea

                        oeMovAn.TipoOperacion = "I"
                        oeMovAn.IdGastoFuncion = "1CH000087"
                        oeMovAn.IdVehiculo = obj("IdVehiculo")
                        oeMovAn.Monto = obj("Total")
                        oeMovAn.Saldo = obj("Total")
                        oeMovAn.PrefijoID = PrefijoId '@0001
                        oeAsientoMovimiento.MovimientoAnalisis.Add(oeMovAn)
                    Else
                        oeMovAn = New e_MovimientoAnalisis
                        oeMovAn.TipoOperacion = "I"
                        oeMovAn.IdGastoFuncion = "1CH000087"

                        oeMovAn.IdVehiculo = obj("IdVehiculo").ToString

                        oeMovAn.Monto = obj("Total")
                        oeMovAn.Saldo = obj("Total")
                        oeMovAn.PrefijoID = PrefijoId
                        oeAsientoMovimiento.MovimientoAnalisis.Add(oeMovAn)
                    End If
                    Monto = Monto + obj("Total")
                    MontoTotal = MontoTotal + obj("Total")
                    If lnUltimo = lnCont Then
                        oeAsientoMovimiento.DebeMN = Monto
                        oeAsientoMovimiento.DebeME = Monto / TipoCambio
                        oeAsientoMovimiento.PrefijoID = PrefijoId
                        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                        oeAsientoMovimiento = New e_AsientoMovimiento
                        oeAsientoMovimiento.TipoOperacion = "I"
                        oeAsientoMovimiento.IdCuentaContable = lsCuenta20
                        oeAsientoMovimiento.DebeMN = 0
                        oeAsientoMovimiento.DebeME = 0
                        oeAsientoMovimiento.HaberMN = Monto
                        oeAsientoMovimiento.HaberME = Monto / TipoCambio
                        oeAsientoMovimiento.Glosa = oeAsiento.Glosa
                        oeAsientoMovimiento.IdUsuarioCrea = IdUsuarioCrea
                        oeAsientoMovimiento.PrefijoID = PrefijoId '@0001
                        oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                    End If

                Next
                oeAsiento.TotalDebe = MontoTotal
                oeAsiento.TotalHaber = MontoTotal
                oeAsiento.PrefijoID = PrefijoId '@0001
                Return Guardar(oeAsiento)
                lnCont = lnCont
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeAsiento As EntidadesWCF.e_Asiento, Optional idAsientoDocCmp As String = Nothing) As Boolean Implements Il_Asiento.Guardar
        Try
            If Validar(oeAsiento) Then
                Dim bandera As Boolean = True
                Dim Id As String = ""
                Dim lsPrefijo As String = ""
                Dim lsNumero As Integer = 0
                Dim ContadorAnalisis As Integer = 0

                Dim odMovimientoAnalisis As New d_MovimientoAnalisis
                Dim olMovimientoAnalisis As New l_MovimientoAnalisis
                'revisa si hay mas de 3 detalles en compras para inserta en masivo
                For Each o_o As e_AsientoMovimiento In oeAsiento.AsientoMovimiento
                    o_o.PrefijoID = oeAsiento.PrefijoID '@0001
                    If Not o_o.MovimientoAnalisis Is Nothing Then
                        If o_o.MovimientoAnalisis.Count > 3 Then
                            If bandera Then
                                Id = odMovimientoAnalisis.UltimoIdInserta(oeAsiento.PrefijoID)
                                lsPrefijo = Left(Id, 3)
                                lsNumero = CInt(Right(Id, Len(Id) - 3))
                                bandera = False 'me indica si ya hizo un masivo
                            End If
                            lsNumero = lsNumero + ContadorAnalisis
                            o_o.BandGuardMasivo = True
                            Dim dt_MA1 As Data.DataTable = olMovimientoAnalisis.CrearDT
                            For Each ob As e_MovimientoAnalisis In o_o.MovimientoAnalisis
                                ob.PrefijoID = oeAsiento.PrefijoID '@0001
                                If ob.TipoOperacion = "I" Then
                                    Dim rowDetalle As Data.DataRow
                                    rowDetalle = dt_MA1.NewRow
                                    rowDetalle("Id") = lsPrefijo & olFuncionesGenerales.CompletaConCeros(lsNumero.ToString, 13)
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
                                End If
                            Next
                            o_o.DataTableAnalisis = dt_MA1
                        End If
                        ContadorAnalisis = ContadorAnalisis + o_o.MovimientoAnalisis.Count
                    End If
                Next
                Return odAsiento.Guardar(oeAsiento, idAsientoDocCmp)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarAsientoDocumentoRendir(ByVal oeAsiento As EntidadesWCF.e_Asiento) As Boolean
        Try
            'If Validar(oeAsiento) Then
            Dim bandera As Boolean = True
            Dim Id As String = ""
            Dim lsPrefijo As String = ""
            Dim lsNumero As Integer = 0
            Dim ContadorAnalisis As Integer = 0

            Dim odMovimientoAnalisis As New d_MovimientoAnalisis
            Dim olMovimientoAnalisis As New l_MovimientoAnalisis
            'revisa si hay mas de 3 detalles en compras para inserta en masivo
            For Each o_o As e_AsientoMovimiento In oeAsiento.AsientoMovimiento
                If Not o_o.MovimientoAnalisis Is Nothing Then
                    If o_o.MovimientoAnalisis.Count > 3 Then
                        If bandera Then
                            Id = odMovimientoAnalisis.UltimoIdInserta(oeAsiento.PrefijoID)
                            lsPrefijo = Left(Id, 3)
                            lsNumero = CInt(Right(Id, Len(Id) - 3))
                            bandera = False 'me indica si ya hizo un masivo
                        End If
                        lsNumero = lsNumero + ContadorAnalisis
                        o_o.BandGuardMasivo = True
                        Dim dt_MA1 As Data.DataTable = olMovimientoAnalisis.CrearDT
                        For Each ob As e_MovimientoAnalisis In o_o.MovimientoAnalisis
                            ob._TipoGuardarMasivo = "Rendir"
                            If ob.TipoOperacion = "I" Then
                                Dim rowDetalle As Data.DataRow
                                rowDetalle = dt_MA1.NewRow
                                rowDetalle("Id") = lsPrefijo & olFuncionesGenerales.CompletaConCeros(lsNumero.ToString, 13)
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
                                rowDetalle("Saldo") = 0
                                rowDetalle("IdMovimientoAnalisis") = ob.Id
                                rowDetalle("IdGastoFuncion") = ob.IdGastoFuncion
                                rowDetalle("IdOrigenProrrateo") = ""
                                dt_MA1.Rows.Add(rowDetalle)
                                lsNumero = lsNumero + 1
                            End If
                        Next
                        o_o.DataTableAnalisis = dt_MA1
                    End If
                    ContadorAnalisis = ContadorAnalisis + o_o.MovimientoAnalisis.Count
                End If
            Next
            Return odAsiento.Guardar(oeAsiento, Nothing)
            'End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarDocumentoxRendir(ByVal leMovAnalisisAgrega As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoAnalisis), ByVal oeAsiento As EntidadesWCF.e_Asiento, ByVal oeDocumento As EntidadesWCF.e_MovimientoDocumento) As Boolean Implements Il_Asiento.GuardarDocumentoxRendir
        Try
            Dim olDocumento As New l_MovimientoDocumento
            Dim odDcoumento As New d_MovimientoDocumento
            'Dim oeAsientoAsoc As New e_AsientoMov_MovDoc
            Using TransScope As New TransactionScope()
                With oeAsiento
                    .Id = ""
                    .TipoOperacion = "I"
                    .IdTipoAsiento = "DIARIO"
                    '.IdTipoAsiento = "1CH000020" '07 tipo de asiento diario
                    .NroAsiento = ""
                    .Glosa = "CANC. POR APLIC. DE DCTOS"
                    .GlosaImprime = .Glosa
                    .IdUsuarioBloquea = ""
                    .IdEstado = "CUADRADO"
                    .IdAsientoExtorno = ""
                    '-------------------Compras--------------------'
                    Dim oeAsientoMov As New e_AsientoMovimiento
                    '------------------------------------------------
                    'cuenta 42
                    Dim oeEmpresaCuenta As New e_EmpresaCuenta
                    Dim leEC As New List(Of e_EmpresaCuenta)
                    Dim odEmpresaCuenta As New d_EmpresaCuenta
                    Dim oeTCD As New e_TablaContableDet
                    Dim odTCD As New d_TablaContableDet

                    'obtengo Cta 43 asociado a empresa
                    oeEmpresaCuenta.IdProveedorCliente = oeDocumento.Compra.Proveedor.Id
                    oeEmpresaCuenta.Ejercicio = oeAsiento.Fecha.Year
                    oeEmpresaCuenta.Activo = True
                    oeEmpresaCuenta.IdMoneda = oeAsiento.IdMoneda
                    oeEmpresaCuenta.IndCompraVenta = 1
                    leEC.AddRange(odEmpresaCuenta.Listar(oeEmpresaCuenta))
                    If leEC.Count > 0 Then
                        oeAsientoMov.IdCuentaContable = leEC(0).IdCuentaContable
                    Else
                        oeTCD.TipoOperacion = "N"
                        oeTCD.Activo = True
                        oeTCD.Nombre = "CUENTAS GENERALES"
                        oeTCD.Valor1 = oeAsiento.Fecha.Year
                        If oeDocumento.Compra.Moneda.Codigo = "1" Then 'soles(codigo de sunat)
                            oeTCD.Texto1 = "CTACOMPRASOLES"
                        Else
                            oeTCD.Texto1 = "CTACOMPRADOLARES"
                        End If
                        oeTCD = odTCD.Listar(oeTCD)(0)
                        oeAsientoMov.IdCuentaContable = oeTCD.Texto2
                    End If

                    '.AsMov_MovDoc = New e_AsientoMov_MovDoc
                    'Asignar datos a tabla CuentaxCyP
                    oeAsientoMov.MovimientoDocumento = oeDocumento.Clonar

                    With oeAsientoMov.MovimientoDocumento
                        .CuentaxCyP = New e_CuentaxCyP
                        .CuentaxCyP.IdMovimientoDocumento = .Id
                        .CuentaxCyP.TipoOperacion = "I" 'Tipo Insertar
                        .CuentaxCyP.Fecha = oeAsiento.Fecha
                        .CuentaxCyP.Activo = True
                        .CuentaxCyP.UsuarioCreacion = oeAsiento.IdUsuarioCrea
                        .CuentaxCyP.MacPCLocalCreacion = oeDocumento.Mac_PC_Local
                        Dim DecTC As Double = oeAsiento.TipoCambio 'Asigno el tipo de cmabio a una variable

                        'Asigno el monto pagado dependiendo si es soles o dolares
                        If .IdMoneda = "1CH01" Then 'Si es soles la moneda
                            .CuentaxCyP.MontoMN = oeAsiento.TotalDebe
                            .CuentaxCyP.MontoMe = oeAsiento.TotalDebe / DecTC
                        Else 'Moneda extranjera
                            .CuentaxCyP.MontoMN = oeAsiento.TotalDebe * DecTC
                            .CuentaxCyP.MontoMe = oeAsiento.TotalDebe
                        End If
                        .Saldo = 0  'Asigno la resta del monto cobrado con el saldo
                        .TipoOperacion = "S" 'Se actualiza el saldo del documento
                        'oeAsientoMov.MovimientoDocumento = oeAsientoMov.MovimientoDocumento

                        'Relacion AsientoMov_MovDoc
                        .CuentaxCyP.AsMov_MovDoc = New e_AsientoMov_MovDoc
                        With .CuentaxCyP.AsMov_MovDoc
                            .IdMovimientoDocumento = oeAsientoMov.MovimientoDocumento.Id
                            .TipoOperacion = "I"
                            .Activo = True
                        End With
                    End With
                    With oeAsientoMov
                        .TipoOperacion = "I"
                        .Glosa = "CANC. POR APLIC. COMPRA " & oeDocumento.Compra.TipoDoc.Abreviatura & "/" & oeDocumento._AbrevTipoDoc & "-" & oeDocumento.Serie & oeDocumento.Numero & " " & oeDocumento.Compra.Proveedor.Nombre
                        .DebeMN = oeAsiento.TotalDebe
                        .HaberMN = 0
                        .DebeME = oeAsiento.TotalDebe / oeAsiento.TipoCambio
                        .HaberME = 0
                        .IdUsuarioCrea = oeAsiento.IdUsuarioCrea

                    End With
                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                    '--------------------------------------------
                    '---LINEA DE LA 16---------
                    oeAsientoMov = New e_AsientoMovimiento
                    oeAsientoMov.TipoOperacion = "I"
                    oeAsientoMov.IdCuentaContable = leMovAnalisisAgrega.Item(0).IdCuentaContable
                    oeAsientoMov.Glosa = "CANC. POR APLIC. DE DCTOS VARIOS"
                    oeAsientoMov.DebeMN = 0
                    oeAsientoMov.HaberMN = oeAsiento.TotalDebe
                    oeAsientoMov.DebeME = 0
                    oeAsientoMov.HaberME = oeAsiento.TotalDebe / oeAsiento.TipoCambio
                    oeAsientoMov.IdUsuarioCrea = oeAsiento.IdUsuarioCrea

                    For Each OBJ As e_MovimientoAnalisis In leMovAnalisisAgrega
                        OBJ.Saldo = 0
                        OBJ._CambiaSaldo = True 'Variable que controla cambio de saldo
                        oeAsientoMov.MovimientoAnalisis.Add(OBJ)
                    Next
                    oeAsientoMov.DivideAnalisis = False
                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                    '---------------------------
                End With
                oeDocumento.Saldo = 0 ' DOCUMENTO YA CANCELADO
                If olDocumento.Validar(oeDocumento) Then
                    oeDocumento.Compra.TipoOperacion = "I"
                    olDocumento.GuardarCompra(oeDocumento, Nothing, True)
                    oeAsiento.AsientoMovimiento.Item(0).MovimientoDocumento.Id = oeDocumento.Id
                    oeAsiento.AsientoMovimiento.Item(0).MovimientoDocumento.CuentaxCyP.IdMovimientoDocumento = oeDocumento.Id
                    oeAsiento.AsientoMovimiento.Item(0).MovimientoDocumento.CuentaxCyP.AsMov_MovDoc.IdMovimientoDocumento = oeDocumento.Id
                    GuardarAsientoDocumentoRendir(oeAsiento)
                End If
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarPagoRetencion(ByVal leMovDocAgregado As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoDocumento),
                                         ByRef oeDocumentoRetencion As EntidadesWCF.e_DocumentoRetencion,
                                         ByVal ls_Actualizar As String) As Object Implements Il_Asiento.GuardarPagoRetencion
        Try
            If ValidarCobranzaPago(leMovDocAgregado, oeDocumentoRetencion.FechaEmision) Then
                ' Inicializar Clases
                Dim oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
                Dim oeAsiento As New e_Asiento, leAsiento As New List(Of e_Asiento)
                Dim oeAsientoMovimiento As New e_AsientoMovimiento, leAsientoMovimiento As New List(Of e_AsientoMovimiento)
                ' Obtiene Cuentas Contables 
                oePeriodo.Ejercicio = oeDocumentoRetencion.FechaEmision.Year
                oePeriodo.Mes = oeDocumentoRetencion.FechaEmision.Month
                oePeriodo = olPeriodo.Obtener(oePeriodo)
                ObtenerCuentas(oePeriodo.Ejercicio)
                ' Generar Asiento Contable
                With oeAsiento
                    .IdPeriodo = oePeriodo.Id : .IdTipoAsiento = "DIARIO" : .NroAsiento = "" : .Fecha = oeDocumentoRetencion.FechaEmision
                    .Glosa = "RETENCION DEL IGV POR PAGAR CR " & oeDocumentoRetencion.Serie & "-" &
                             oeDocumentoRetencion.Numero & " " & leMovDocAgregado.Item(0)._NombreClienteProveedor
                    .GlosaImprime = .Glosa : .IdMoneda = oeDocumentoRetencion.IdMoneda : .TipoCambio = oeDocumentoRetencion.TipoCambio
                    .TotalDebe = IIf(.IdMoneda = "1CH01", oeDocumentoRetencion.ImporteSol, oeDocumentoRetencion.ImporteDol)
                    .TotalHaber = .TotalDebe : .IdUsuarioCrea = oeDocumentoRetencion.IdUsuario : .IdEstado = "CUADRADO"
                    .Activo = True : .TipoOperacion = "I" : .IndOrigen = 23
                End With
                ' Generar Lineas de Asiento (42)
                For Each oeMovimientoDocumento As e_MovimientoDocumento In leMovDocAgregado
                    oeAsientoMovimiento = New e_AsientoMovimiento
                    With oeMovimientoDocumento
                        ' Generar Cuenta por Cobrar y Pagar
                        .CuentaxCyP = New e_CuentaxCyP
                        .CuentaxCyP.IdMovimientoDocumento = .Id : .CuentaxCyP.TipoOperacion = "I" : .CuentaxCyP.Fecha = oeDocumentoRetencion.FechaEmision
                        .CuentaxCyP.Activo = True : .CuentaxCyP.UsuarioCreacion = oeDocumentoRetencion.IdUsuario
                        .CuentaxCyP.MacPCLocalCreacion = oeDocumentoRetencion.MacPCLocal
                        .CuentaxCyP.IndCargoAbono = 0 : .CuentaxCyP.IdMoneda = oeMovimientoDocumento.IdMoneda
                        .CuentaxCyP.TipoCambio = oeDocumentoRetencion.TipoCambio : .CuentaxCyP.UsuarioModifica = oeDocumentoRetencion.IdUsuario
                        If oeMovimientoDocumento.IdMoneda = "1CH01" Then
                            .CuentaxCyP.MontoMN = .MontoOperar : oeAsientoMovimiento.DebeMN = .MontoOperar
                            .CuentaxCyP.MontoMe = .MontoOperar / oeDocumentoRetencion.TipoCambio : oeAsientoMovimiento.DebeME = .MontoOperar / oeDocumentoRetencion.TipoCambio
                        Else
                            .CuentaxCyP.MontoMN = .MontoOperar * oeDocumentoRetencion.TipoCambio : oeAsientoMovimiento.DebeMN = .MontoOperar * oeDocumentoRetencion.TipoCambio
                            .CuentaxCyP.MontoMe = .MontoOperar : oeAsientoMovimiento.DebeME = .MontoOperar
                        End If
                        .Saldo = Math.Round(.Saldo - .MontoOperar, 2) : .TipoOperacion = "A"
                        ' Actualizar Registro de Compras
                        .Compra.TipoOperacion = "R"
                        .Compra.IdMovimientoDocumento = .Id : .Compra.Retencion = .MontoOperar : .Compra.RetencionPorc = (100 * .MontoOperar / .Total)
                        oeAsientoMovimiento.MovimientoDocumento = oeMovimientoDocumento

                        .CuentaxCyP.AsMov_MovDoc = New e_AsientoMov_MovDoc
                        With .CuentaxCyP.AsMov_MovDoc
                            .IdMovimientoDocumento = oeMovimientoDocumento.Id
                            .TipoOperacion = "I"
                            .Activo = True
                        End With
                        oeAsientoMovimiento.IdCuentaContable = .IdCuentaContable
                        oeAsientoMovimiento.Glosa = oeAsiento.Glosa
                        oeAsientoMovimiento.IdUsuarioCrea = oeDocumentoRetencion.IdUsuario
                        oeAsientoMovimiento.Activo = True
                        oeAsientoMovimiento.TipoOperacion = "I"
                        oeAsientoMovimiento.MovimientoCajaBanco = Nothing

                        .CuentaxCyP.CuentaxPDocumentoRetencion = New e_CuentaxPDocumentoRetencion
                        .CuentaxCyP.CuentaxPDocumentoRetencion.TipoOperacion = "I"
                        .CuentaxCyP.CuentaxPDocumentoRetencion.IdMovimientoDocumento = .Id
                        .CuentaxCyP.CuentaxPDocumentoRetencion.UsuarioCrea = oeDocumentoRetencion.IdUsuario

                        leAsientoMovimiento.Add(oeAsientoMovimiento)
                    End With
                Next

                oeAsientoMovimiento = New e_AsientoMovimiento
                With oeAsientoMovimiento
                    .Id = ""
                    .IdCuentaContable = leCuentasGenerales.Where(Function(i) i.Nombre = "CTARETENCION")(0).Texto2         ' oeTCD.Texto2  'Asigno el tipo de asiento guardado en la TablaContableDetalle segun combo Medio de Pago
                    .Glosa = oeAsiento.Glosa
                    .HaberMN = oeDocumentoRetencion.ImporteSol
                    .HaberME = oeDocumentoRetencion.ImporteDol
                    .DebeMN = 0
                    .DebeME = 0
                    .IdUsuarioCrea = oeDocumentoRetencion.IdUsuario
                    .Activo = True
                    .TipoOperacion = "I"
                    .AsMov_MovDoc = Nothing
                    .DocumentoRetencion = New e_DocumentoRetencion
                    oeDocumentoRetencion.NombreTipoDoc = "RETENCION"
                    .DocumentoRetencion = oeDocumentoRetencion
                End With
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
                oeAsiento.AsientoMovimiento.AddRange(leAsientoMovimiento)

                Using transScope As New TransactionScope()

                    If odAsiento.Guardar(oeAsiento, Nothing) Then
                        oeDocumentoRetencion.Id = oeAsiento.IdRetencion
                    End If

                    For Each doc In leMovDocAgregado.Where(Function(i) i.IdMoneda = "1CH02" And i.Saldo = 0)
                        Dim ds As DataSet
                        ds = odMovimientoDocumento.ObtenerAJusteTipoCambio("DOC", doc.Id, "", oeDocumentoRetencion.FechaEmision.Year)
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
                                .Fecha = oeDocumentoRetencion.FechaEmision
                                .Glosa = glosaajuste
                                .GlosaImprime = .Glosa
                                .IdMoneda = "1CH01"
                                .TipoCambio = 0.0
                                .TotalDebe = Math.Abs(Math.Round(DebeMN - HaberMN, 2))
                                .TotalHaber = Math.Abs(Math.Round(DebeMN - HaberMN, 2))
                                .IdUsuarioCrea = oeDocumentoRetencion.IdUsuario
                                .IdEstado = "CUADRADO"
                                .Activo = True
                                .TipoOperacion = "I"
                                .IdentificaAsiento = "AJUSTETCMD" + doc.Id
                                .IndOrigen = 24

                                oeAsientoMovDoc = New e_AsientoMovimiento
                                oeAsientoMovDoc.TipoOperacion = "I"
                                oeAsientoMovDoc.Id = ""
                                oeAsientoMovDoc.IdCuentaContable = doc.IdCuentaContable
                                oeAsientoMovDoc.Glosa = .Glosa
                                oeAsientoMovDoc.DebeME = 0
                                oeAsientoMovDoc.HaberME = 0
                                oeAsientoMovDoc.DebeMN = IIf(DebeMN > HaberMN, 0, HaberMN - DebeMN)
                                oeAsientoMovDoc.HaberMN = IIf(HaberMN > DebeMN, 0, DebeMN - HaberMN)
                                oeAsientoMovDoc.IdUsuarioCrea = oeDocumentoRetencion.IdUsuario
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
                                oeAsientoMovDif.IdUsuarioCrea = oeDocumentoRetencion.IdUsuario
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
                    Dim _ban As Boolean = False
                    If ls_Actualizar.Trim.Length > 0 Then
                        Dim oe_DocRetDet As New e_DocumentoRetencionDetalle
                        Dim olDetRetencion As New l_DocumentoRetencionDetalle
                        If olDetRetencion.Guardar(New e_DocumentoRetencionDetalle With {.TipoOperacion = "U", .IdMovimientoDocumento = ls_Actualizar,
                                                                                     .IdDocumentoRetencion = oeDocumentoRetencion.Id, .UsuarioModifica = oeDocumentoRetencion.IdUsuario}) Then
                            oe_DocRetDet.IdDocumentoRetencion = oeDocumentoRetencion.Id
                            oe_DocRetDet.TipoOperacion = "D"
                            oe_DocRetDet.Activo = 1
                            olDetRetencion = New l_DocumentoRetencionDetalle
                            olDetRetencion.Guardar(oe_DocRetDet)
                        End If
                    End If
                    transScope.Complete()
                End Using
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ImprimeCobroPagoAnticipoObligacion(ByVal IdMovCajaBanco As String, ByVal lsTipoOperacion As String) _
    As System.Data.DataTable Implements Il_Asiento.ImprimeCobroPagoAnticipoObligacion
        Try
            Return odAsiento.ImprimirCobroPagoAnticipo(IdMovCajaBanco, lsTipoOperacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ImprimeTranferencia(ByVal IdMovCajaBanco As String) As System.Data.DataTable Implements Il_Asiento.ImprimeTranferencia
        Try
            Return odAsiento.ImprimirTranferencia(IdMovCajaBanco)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsiento As EntidadesWCF.e_Asiento) As System.Collections.Generic.List(Of EntidadesWCF.e_Asiento) Implements Il_Asiento.Listar
        Try
            Return odAsiento.Listar(oeAsiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarAsientosDescuadrados(ByVal oeAsiento As EntidadesWCF.e_Asiento) As System.Data.DataTable Implements Il_Asiento.ListarAsientosDescuadrados
        Try
            Return odAsiento.ListarAsientosDescuadrados(oeAsiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarBalanceComprobacion(ByVal oeAsiento As EntidadesWCF.e_Asiento) As System.Data.DataTable Implements Il_Asiento.ListarBalanceComprobacion
        Try
            Return odAsiento.ListarBalanceComprobacion(oeAsiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarBalanceComprobacionDestino(ByVal oeAsiento As EntidadesWCF.e_Asiento) As System.Data.DataTable Implements Il_Asiento.ListarBalanceComprobacionDestino
        Try
            Return odAsiento.ListarBalanceComprobacionDestino(oeAsiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarConsumoMaterial(ByVal oePeriodo As EntidadesWCF.e_Periodo, ByVal lsIdSubAlmacen As String) As System.Data.DataTable Implements Il_Asiento.ListarConsumoMaterial
        Try
            Dim dtConsumo As DataTable
            Dim dtCantidad As DataTable
            Dim dtMonto As DataTable
            Dim dtRetorna As DataTable

            oePeriodo.TipoOperacion = "C"
            dtConsumo = odAsiento.ListarConsumoMaterial(oePeriodo, lsIdSubAlmacen)

            oePeriodo.TipoOperacion = "CAN"
            dtCantidad = odAsiento.ListarConsumoMaterial(oePeriodo, lsIdSubAlmacen)

            oePeriodo.TipoOperacion = "MON"
            dtMonto = odAsiento.ListarConsumoMaterial(oePeriodo, lsIdSubAlmacen)

            dtRetorna = dtConsumo.Copy
            dtRetorna.Clear()
            For Each o_Fila As Data.DataRow In dtConsumo.Rows
                If o_Fila.Item("IndMotriz") = "1" Then
                    o_Fila("Total") = Evalua_Monto(o_Fila("Total").ToString, IIf(o_Fila("IdCuentaContable").ToString = "", 0, o_Fila("IdCuentaContable").ToString), dtMonto, dtCantidad)
                    dtRetorna.ImportRow(o_Fila)
                End If
                If o_Fila.Item("AbrevGasto") = "94" Then
                    dtRetorna.ImportRow(o_Fila)
                End If
            Next

            Return dtRetorna
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ListarDetalles(ByVal TipoOperacion As String, ByVal IdPeriodo As String, ByVal IdCuentaContable As String, ByVal IdGastoFuncion As String) As System.Data.DataTable Implements Il_Asiento.ListarDetalles
        Try
            Return odAsiento.ListarDetalles(TipoOperacion, IdPeriodo, IdCuentaContable, IdGastoFuncion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarEEFF(ByVal li_Ejercicio As Integer, ByVal li_Mes As Integer, Optional ls_Operacion As String = "") As System.Data.DataTable Implements Il_Asiento.ListarEEFF
        Try
            Return odAsiento.ListarEEFF(li_Ejercicio, li_Mes, ls_Operacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarBalanceGeneral(ByVal ln_Ejercicio As Integer, ByVal ln_Mes As Integer) As System.Data.DataTable Implements Il_Asiento.ListarBalanceGeneral
        Try
            Return odAsiento.ListarBalanceGeneral(ln_Ejercicio, ln_Mes)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarEstadoGanaciasPerdidas(ByVal ls_IdPeriodo As String, ByVal ls_Rpt As String) As System.Data.DataSet Implements Il_Asiento.ListarEstadoGanaciasPerdidas
        Try
            Return odAsiento.ListarEstadoGanaciasPerdidas(ls_IdPeriodo, ls_Rpt)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarUtilidadBrutaVehicular(ByVal Ejercicio As Integer, ByVal Mes As Integer, ByVal Acumulado As Integer) As System.Data.DataSet Implements Il_Asiento.ListarUtilidadBrutaVehicular
        Try
            Dim ds As New DataSet
            Dim dt As DataTable
            dt = odAsiento.ListarUtilidadBrutaVehicular(Ejercicio, Mes, Acumulado)
            Dim dt1Nivel As DataTable
            Dim dt2Nivel As DataTable
            Dim DtTodos As DataRow() = dt.Select("", "Distribucion, Placa")
            dt1Nivel = Suma1Nivel(DtTodos.CopyToDataTable)
            Dim DtTodos2 As DataRow() = dt.Select("", "Distribucion,NombreCuenta, Placa")
            dt2Nivel = Suma2Nivel(DtTodos2.CopyToDataTable)
            ds.Tables.Add(dt1Nivel)
            ds.Tables.Add(dt2Nivel)
            ds.Tables.Add(dt.Copy)

            Dim PadreCol As DataColumn = ds.Tables(0).Columns("Distribucion")
            Dim HijoCol As DataColumn = ds.Tables(1).Columns("Distribucion")
            Dim Relacion As DataRelation = New DataRelation("Distribucion2222", PadreCol, HijoCol, True)
            ds.Relations.Add(Relacion)
            ds.AcceptChanges()

            'Dim PadreCol() As DataColumn
            'PadreCol = New DataColumn() {ds.Tables(0).Columns("Distribucion"), ds.Tables(0).Columns("Distribucion")}
            'Dim HijoCol() As DataColumn
            'HijoCol = New DataColumn() {ds.Tables(0).Columns("Distribucion"), ds.Tables(0).Columns("Distribucion")}
            'Dim Relacion As New DataRelation("Distribucion1", PadreCol, HijoCol)
            'ds.Relations.Add(Relacion)
            'ds.AcceptChanges()

            Dim PadreCol2 As DataColumn = ds.Tables(1).Columns("DisCuenta")
            Dim HijoCol2 As DataColumn = ds.Tables(2).Columns("DisCuenta")
            Dim Relacion2 As DataRelation = New DataRelation("DisCuenta1", PadreCol2, HijoCol2, True)
            ds.Relations.Add(Relacion2)
            ds.AcceptChanges()

            Return ds
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Obtener(ByVal oeAsiento As EntidadesWCF.e_Asiento) As EntidadesWCF.e_Asiento Implements Il_Asiento.Obtener
        Try
            Return odAsiento.Obtener(oeAsiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Suma1Nivel(ByVal Filas As System.Data.DataTable) As System.Data.DataTable Implements Il_Asiento.Suma1Nivel
        Try
            Dim Dt As New DataTable
            Dt = Filas.Clone
            Dim Distribucion As String = ""
            For Each obj As DataRow In Filas.Rows
                If obj("Distribucion") <> Distribucion Then
                    Dt.ImportRow(obj)
                    Distribucion = obj("Distribucion")
                    Dt.Rows(Dt.Rows.Count - 1).Item("Cuenta") = ""
                    Dt.Rows(Dt.Rows.Count - 1).Item("NombreCuenta") = ""
                    Dt.Rows(Dt.Rows.Count - 1).Item("IdItemGasto") = ""
                    Dt.Rows(Dt.Rows.Count - 1).Item("ItemGasto") = ""
                    Dt.Rows(Dt.Rows.Count - 1).Item("Placa") = ""
                Else
                    Dt.Rows(Dt.Rows.Count - 1).Item("TMN") = Dt.Rows(Dt.Rows.Count - 1).Item("TMN") + obj("TMN")
                    'Dt.Rows(Dt.Rows.Count - 1).Item("TME") = Dt.Rows(Dt.Rows.Count - 1).Item("TME") + obj("TME")
                End If
            Next
            Return Dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Suma2Nivel(ByVal Filas As System.Data.DataTable) As System.Data.DataTable Implements Il_Asiento.Suma2Nivel
        Try
            Dim Dt As New DataTable
            Dt = Filas.Clone
            Dim Distribucion As String = ""
            Dim NombreCuenta As String = ""
            For Each obj As DataRow In Filas.Rows
                If obj("Distribucion") <> Distribucion Or NombreCuenta <> obj("NombreCuenta") Then
                    Dt.ImportRow(obj)
                    Distribucion = obj("Distribucion")
                    NombreCuenta = obj("NombreCuenta")
                    Dt.Rows(Dt.Rows.Count - 1).Item("IdItemGasto") = ""
                    Dt.Rows(Dt.Rows.Count - 1).Item("ItemGasto") = ""
                    Dt.Rows(Dt.Rows.Count - 1).Item("Placa") = ""

                Else
                    Dt.Rows(Dt.Rows.Count - 1).Item("TMN") = Dt.Rows(Dt.Rows.Count - 1).Item("TMN") + obj("TMN")
                    'Dt.Rows(Dt.Rows.Count - 1).Item("TME") = Dt.Rows(Dt.Rows.Count - 1).Item("TME") + obj("TME")
                End If
            Next
            Return Dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Validar(ByVal oeAsiento As EntidadesWCF.e_Asiento) As Boolean Implements Il_Asiento.Validar
        Try
            With oeAsiento
                For Each obj As e_AsientoMovimiento In .AsientoMovimiento
                    With obj.MovimientoCajaBanco
                        If Not obj.MovimientoCajaBanco Is Nothing Then
                            If .IdFlujoCaja = "" And .IdCuentaBancaria = "" And .IdMedioPago = "" And .NroBoucher = "" Then
                                obj.MovimientoCajaBanco = Nothing
                            Else
                                If .IdAsientoMovimiento <> "" Then
                                    If .Id <> "" Then
                                        .TipoOperacion = "A"
                                    Else
                                        .TipoOperacion = "I"
                                    End If
                                Else
                                    .TipoOperacion = "I"
                                End If
                                .TipoCambio = oeAsiento.TipoCambio
                                .TotalMN = obj.DebeMN + obj.HaberMN
                                .TotalME = obj.DebeME + obj.HaberME
                            End If
                        End If

                    End With
                    With obj.MovimientoDocumento
                        If Not obj.MovimientoDocumento Is Nothing Then
                            If .IdTipoDocumento = "" And .Serie = "" And .Numero = "" And .IdClienteProveedor = "" Then
                                obj.MovimientoDocumento = Nothing
                            Else
                                If .IdAsientoMovimiento <> "" Then
                                    If .Id <> "" Then
                                        If .TipoOperacion <> "E" Then
                                            .TipoOperacion = "ADI" 'tipo actualiza tambien el operador
                                        End If
                                    Else
                                        .TipoOperacion = "I"
                                    End If
                                    'Else
                                    '    .TipoOperacion = "I"
                                End If
                            End If
                            '.IndCompraVenta = -1
                            .IdPeriodo = oeAsiento.IdPeriodo
                        End If
                    End With
                Next
                oeAsiento.GlosaImprime = oeAsiento.Glosa
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCobranzaPago(ByVal leDocumentosAgregados As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoDocumento), ByVal fecha As Date) As Object Implements Il_Asiento.ValidarCobranzaPago
        Try
            Dim loFuncionesGenerales As New l_FuncionesGenerales
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, fecha, fecha.Year.ToString + "-" + fecha.Month.ToString)
            loFuncionesGenerales.ValidarDatosDeDctoExistente(leDocumentosAgregados)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function IntegracionPrestamosProvision(ByVal lePrestamos As System.Collections.Generic.List(Of EntidadesWCF.e_Prestamo),
                                                  ByVal oePeriodo As e_Periodo, ByVal IdUsuario As String, ByVal lnTipoCambio As Double,
                                                  ByVal IdCuentaCaja As String, ByRef oeMovCajaBanco As e_MovimientoCajaBanco,
                                                  ByVal indMonedaExtranjera As Integer, ByVal lsGlosa As String) As String
        Try
            Dim oeAsMov As New e_AsientoMovimiento
            oeAsMov.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
            If lePrestamos.Count > 0 Then
                Dim oeAsiento As New e_Asiento 'Asigno los datos al asiento
                oeAsiento.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                With oeAsiento
                    'Obtener el periodo deacuerdo a la fecha ingresada en el Formulario Cobranza
                    .IdPeriodo = oePeriodo.Id       'Prueba no admite campo nulos
                    .NroAsiento = "" 'Se genera
                    .Fecha = lePrestamos(0).FechaIntegracion
                    .IdTipoAsiento = "PLANILLAS"  'Asigno el tipo de asiento guardado en la TablaContableDetalle, 
                    If lePrestamos.Count > 1 Then
                        .Glosa = "REEMBOLSO DE GRUPO " + lsGlosa
                    Else
                        If oeMovCajaBanco.IdCuentaBancaria <> "" Then .IdTipoAsiento = "BANCO" 'Asigno el tipo de asiento guardado en la TablaContableDetalle 
                        .Glosa = "PRESTAMO " + lsGlosa
                    End If
                    .GlosaImprime = .Glosa
                    'Se obtiene el IdMoneda dependiendo de la Cuenta COntable
                    If indMonedaExtranjera = 1 Then
                        .IdMoneda = "1CH02"
                    Else
                        .IdMoneda = "1CH01"
                    End If
                    .TipoCambio = 3 'Obtener Tipo de Cambio del Objeto MovCajaBanco DecTC.Value
                    'Total Debe y Total Haber depende de la Moneda
                    .TotalDebe = lePrestamos.Sum(Function(item As e_Prestamo) item.Monto)
                    .TotalHaber = .TotalDebe 'Debe = Haber
                    .IdUsuarioCrea = IdUsuario 'Pedir parametro
                    .IdEstado = "CUADRADO"
                    .Activo = True
                    .TipoOperacion = "I"

                End With

                Dim lsConcepto As String = ""
                Dim leLista As New List(Of e_AsientoMovimiento)
                Dim oeMovimientoAnalisis As New e_MovimientoAnalisis
                oeMovimientoAnalisis.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                Dim oeTCD As New e_TablaContableDet, odTCD As New d_TablaContableDet
                lePrestamos = lePrestamos.OrderBy(Function(item) item.IdConcepto).ToList

                Dim MontoFilt As Double = 0
                'Detalle
                For Each oePrest As e_Prestamo In lePrestamos
                    oePrest.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                    With oePrest
                        If lsConcepto.Trim <> oePrest.IdConcepto.Trim Then
                            lsConcepto = oePrest.IdConcepto
                            oeAsMov = New e_AsientoMovimiento 'Detalles AsientoMovimiento
                            oeAsMov.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                            oeTCD.TipoOperacion = "N"
                            oeTCD.Activo = True
                            oeTCD.Nombre = "CUENTAS GENERALES"
                            oeTCD.Valor1 = lePrestamos(0).FechaIntegracion.Year
                            If .IdConcepto.Trim = "1SI000005" Then 'ADELANTOS
                                oeTCD.Texto1 = "CTA14_ADELANTOS"
                                MontoFilt = lePrestamos.Where(Function(it) it.IdConcepto.Trim = "1SI000005").Sum(Function(it) it.Monto)
                                oeAsMov.Glosa = "ADELANTO DE SUELDOS MES " & lePrestamos(0).FechaIntegracion.Month.ToString & "/ " & lsGlosa
                            ElseIf .IdConcepto.Trim = "1SI000002" Then 'PRESTAMOS
                                oeTCD.Texto1 = "CTA14_PRESTAMOS"
                                MontoFilt = lePrestamos.Where(Function(it) it.IdConcepto.Trim = "1SI000002").Sum(Function(it) it.Monto)
                                oeAsMov.Glosa = "PRESTAMOS AL PERSONAL MES " & lePrestamos(0).FechaIntegracion.Month.ToString & "/ " & lsGlosa
                            ElseIf .IdConcepto.Trim = "1SI000003" Then 'SANCIONES
                                oeTCD.Texto1 = "CTA14_OTRASCTAS"
                                MontoFilt = lePrestamos.Where(Function(it) it.IdConcepto.Trim = "1SI000003").Sum(Function(it) it.Monto)
                                oeAsMov.Glosa = "OTRAS CUENTAS POR COBRAR AL PERSONAL MES " & lePrestamos(0).FechaIntegracion.Month.ToString & "/ " & lsGlosa
                            Else 'OTROS -DEMAS
                                oeTCD.Texto1 = "CTA16"
                                MontoFilt = lePrestamos.Where(Function(it) it.IdConcepto.Trim <> "1SI000002" And it.IdConcepto.Trim <> "1SI000005" _
                                                                  And it.IdConcepto.Trim <> "1SI000003").Sum(Function(it) it.Monto)
                                oeAsMov.Glosa = "FONDO FIJO DEL MES" & lePrestamos(0).FechaIntegracion.Month.ToString & "/ " & lsGlosa
                            End If
                            'odTCD.Listar(oeTCD)
                            oeTCD = odTCD.Listar(oeTCD)(0)
                            oeAsMov.DivideAnalisis = False
                            oeAsMov.IdCuentaContable = oeTCD.Texto2
                            oeAsMov.DebeMN = MontoFilt
                            oeAsMov.DebeME = MontoFilt / lnTipoCambio
                            oeAsMov.HaberMN = 0
                            oeAsMov.HaberME = 0
                            oeAsMov.IdUsuarioCrea = IdUsuario 'gUsuarioSGI.Id
                            oeAsMov.Activo = True
                            oeAsMov.TipoOperacion = "I"
                            oeMovimientoAnalisis = New e_MovimientoAnalisis
                            oeMovimientoAnalisis.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                            oeMovimientoAnalisis.TipoOperacion = "I"
                            If indMonedaExtranjera = 1 Then
                                oeMovimientoAnalisis.Monto = .Monto / lnTipoCambio
                            Else
                                oeMovimientoAnalisis.Monto = .Monto
                            End If
                            oeMovimientoAnalisis.Saldo = .Monto
                            oeMovimientoAnalisis.IdTrabajador = .IdTrabajador
                            oeAsMov.MovimientoAnalisis.Add(oeMovimientoAnalisis)
                            leLista.Add(oeAsMov)
                        Else
                            oeMovimientoAnalisis = New e_MovimientoAnalisis
                            oeMovimientoAnalisis.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                            oeMovimientoAnalisis.TipoOperacion = "I"
                            oeMovimientoAnalisis.Monto = .Monto
                            oeMovimientoAnalisis.Saldo = .Monto
                            oeMovimientoAnalisis.IdTrabajador = .IdTrabajador
                            oeAsMov.MovimientoAnalisis.Add(oeMovimientoAnalisis)
                        End If

                    End With
                Next

                ' asiento detalle de cuenta 10
                oeAsMov = New e_AsientoMovimiento
                oeAsMov.PrefijoID = oeMovCajaBanco.PrefijoID '@0001
                With oeAsMov
                    'Asiento Movimiento Cabecera
                    .Id = ""
                    .IdCuentaContable = IdCuentaCaja   'Asigno el tipo de asiento guardado en la TablaContableDetalle segun combo Medio de Pago
                    .Glosa = oeAsiento.Glosa
                    .HaberMN = oeMovCajaBanco.TotalMN
                    .HaberME = oeMovCajaBanco.TotalMN / lnTipoCambio
                    .DebeMN = 0
                    .DebeME = 0
                    .IdUsuarioCrea = IdUsuario
                    .Activo = True
                    .TipoOperacion = "I"
                    'Asigna datos al objeto MovCaja Banco
                    'oeMovCajaBanco.MovDoc = leMovDocAgregado 'Se le asigna la lista de los Movimientos dcumentos a cambiar el saldo
                    oeAsMov.MovimientoCajaBanco = oeMovCajaBanco
                    .AsMov_MovDoc = Nothing ' No se Genera relacion
                End With
                oeAsiento.AsientoMovimiento.AddRange(leLista)
                oeAsiento.AsientoMovimiento.Add(oeAsMov)
                Dim BAND As Boolean = Guardar(oeAsiento) 'Se guarda toda la transaccion
                oeMovCajaBanco.Id = oeAsiento._IdMovimientoCajaBanco
                Return oeMovCajaBanco.Id
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function IntegracionPrestamosDescuentoPlanilla(ByVal lePrestamos As System.Collections.Generic.List(Of EntidadesWCF.e_Prestamo),
                                                  ByVal oePeriodo As e_Periodo, ByVal IdUsuario As String, ByVal lnTipoCambio As Double,
                                                  ByVal fechaEjecucion As Date) As String
        Try
            Dim oeAsMov As New e_AsientoMovimiento
            Dim olFuncionesGen As New l_FuncionesGenerales
            If lePrestamos.Count > 0 Then
                Dim oeAsiento As New e_Asiento 'Asigno los datos al asiento
                With oeAsiento
                    'Obtener el periodo deacuerdo a la fecha ingresada en el Formulario Cobranza
                    .IdPeriodo = oePeriodo.Id       'Prueba no admite campo nulos
                    .IdTipoAsiento = "PLANILLAS"  'Asigno el tipo de asiento guardado en la TablaContableDetalle, 
                    .NroAsiento = "" 'Se genera
                    .Fecha = olFuncionesGen.UltimoDiaMes(fechaEjecucion)
                    .Glosa = "ASIENTO PLANILLA "
                    .GlosaImprime = .Glosa
                    'Se obtiene el IdMoneda dependiendo de la Cuenta COntable
                    .IdMoneda = "1CH01"

                    .TipoCambio = 3 'Obtener Tipo de Cambio del Objeto MovCajaBanco DecTC.Value
                    'Total Debe y Total Haber depende de la Moneda
                    .TotalDebe = lePrestamos.Sum(Function(item As e_Prestamo) item.Monto)
                    .TotalHaber = .TotalDebe 'Debe = Haber
                    .IdUsuarioCrea = IdUsuario 'Pedir parametro
                    .IdEstado = "CUADRADO"
                    .Activo = True
                    .TipoOperacion = "I"

                End With

                Dim lsConcepto As String = ""
                Dim leLista As New List(Of e_AsientoMovimiento)
                Dim oeMovimientoAnalisis As New e_MovimientoAnalisis
                Dim oeTCD As New e_TablaContableDet
                Dim odTCD As New d_TablaContableDet
                lePrestamos = lePrestamos.OrderBy(Function(item) item.IdConcepto).ToList
                'Dim lePrestamosAdelantos As New List(Of e_Prestamo)
                'lePrestamosAdelantos = lePrestamos
                'Dim lePrestamosprestamos As New List(Of e_Prestamo)
                'lePrestamosprestamos = lePrestamos
                'Dim lePrestamosOtros As New List(Of e_Prestamo)
                'lePrestamosOtros = lePrestamos
                Dim MontoFilt As Double = 0
                'Detalle
                For Each oePrest As e_Prestamo In lePrestamos
                    With oePrest
                        If lsConcepto <> oePrest.IdConcepto Then
                            lsConcepto = oePrest.IdConcepto
                            oeAsMov = New e_AsientoMovimiento 'Detalles AsientoMovimiento
                            oeTCD.TipoOperacion = "N"
                            oeTCD.Activo = True
                            oeTCD.Nombre = "CUENTAS GENERALES"
                            oeTCD.Valor1 = fechaEjecucion.Year
                            If .IdConcepto.Trim = "1SI000005" Then 'ADELANTOS
                                oeTCD.Texto1 = "CTA14_ADELANTOS"
                                'lePrestamosAdelantos = lePrestamosAdelantos.Where(Function(item) item.IdConcepto = "1SI000005").ToList
                                'MontoFilt = lePrestamosAdelantos.Sum(Function(item As e_Prestamo) item.Monto)
                                MontoFilt = lePrestamos.Where(Function(it) it.IdConcepto.Trim = "1SI000005").Sum(Function(it) it.Monto)
                                oeAsMov.Glosa = "ADELANTO DE SUELDOS MES " & lePrestamos(0).FechaIntegracion.Month.ToString
                            ElseIf .IdConcepto.Trim = "1SI000002" Then 'PRESTAMOS
                                oeTCD.Texto1 = "CTA14_PRESTAMOS"
                                'lePrestamosprestamos = lePrestamosprestamos.Where(Function(item) item.IdConcepto = "1SI000002").ToList
                                'MontoFilt = lePrestamosprestamos.Sum(Function(item As e_Prestamo) item.Monto)
                                MontoFilt = lePrestamos.Where(Function(it) it.IdConcepto.Trim = "1SI000002").Sum(Function(it) it.Monto)
                                oeAsMov.Glosa = "PRESTAMOS AL PERSONAL MES " & lePrestamos(0).FechaIntegracion.Month.ToString
                            ElseIf .IdConcepto.Trim = "1SI000003" Then 'SANCIONES
                                oeTCD.Texto1 = "CTA14_OTRASCTAS"
                                'lePrestamosSanciones = lePrestamos.Where(Function(item) item.IdConcepto = "1SI000003").ToList
                                'MontoFilt = lePrestamosSanciones.Sum(Function(item As e_Prestamo) item.Monto)
                                MontoFilt = lePrestamos.Where(Function(it) it.IdConcepto.Trim = "1SI000003").Sum(Function(it) it.Monto)
                                oeAsMov.Glosa = "OTRAS CUENTAS POR COBRAR AL PERSONAL MES " & lePrestamos(0).FechaIntegracion.Month.ToString
                            Else 'OTROS -DEMAS
                                oeTCD.Texto1 = "CTA16"
                                'lePrestamosOtros = lePrestamosOtros.Where(Function(item) item.IdConcepto <> "1SI000002" And item.IdConcepto <> "1SI000005").ToList
                                'MontoFilt = lePrestamosOtros.Sum(Function(item As e_Prestamo) item.Monto)
                                MontoFilt = lePrestamos.Where(Function(it) it.IdConcepto.Trim <> "1SI000002" And it.IdConcepto.Trim <> "1SI000005" _
                                                                  And it.IdConcepto.Trim <> "1SI000003").Sum(Function(it) it.Monto)
                                oeAsMov.Glosa = "FONDO FIJO DEL MES" & lePrestamos(0).FechaIntegracion.Month.ToString
                            End If
                            'odTCD.Listar(oeTCD)
                            oeTCD = odTCD.Listar(oeTCD)(0)
                            oeAsMov.DivideAnalisis = False
                            oeAsMov.IdCuentaContable = oeTCD.Texto2
                            oeAsMov.HaberMN = MontoFilt
                            oeAsMov.HaberME = MontoFilt / lnTipoCambio
                            oeAsMov.DebeMN = 0
                            oeAsMov.DebeME = 0

                            oeAsMov.IdUsuarioCrea = IdUsuario 'gUsuarioSGI.Id
                            oeAsMov.Activo = True
                            oeAsMov.TipoOperacion = "I"
                            oeMovimientoAnalisis = New e_MovimientoAnalisis
                            oeMovimientoAnalisis.TipoOperacion = "I"
                            oeMovimientoAnalisis.Monto = .Monto

                            oeMovimientoAnalisis.IdTrabajador = .IdTrabajador
                            oeAsMov.MovimientoAnalisis.Add(oeMovimientoAnalisis)
                            leLista.Add(oeAsMov)
                        Else
                            oeMovimientoAnalisis = New e_MovimientoAnalisis
                            oeMovimientoAnalisis.TipoOperacion = "I"
                            oeMovimientoAnalisis.Monto = .Monto
                            oeMovimientoAnalisis.IdTrabajador = .IdTrabajador
                            oeAsMov.MovimientoAnalisis.Add(oeMovimientoAnalisis)
                        End If

                    End With
                Next
                oeAsiento.AsientoMovimiento.AddRange(leLista)
                Dim BAND As Boolean = Guardar(oeAsiento) 'Se guarda toda la transaccion
            End If
            Return ""
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarInventarioYBalances(ByVal Mes As String, ByVal TipoConsulta As String) As System.Data.DataTable Implements Il_Asiento.InventariosYBalances
        Try
            Return odAsiento.InventariosYBalances(Mes, TipoConsulta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDevengadoSeguros(ByVal FechaVencimiento As Date,
    ByVal lsTipoOper As String, ByVal lsIddoc As String) As System.Data.DataTable Implements Il_Asiento.ListarDevengadoSeguros
        Try
            Return odAsiento.ListarDevengadoSeguros(FechaVencimiento, lsTipoOper, lsIddoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarSegurosDevengados(ByVal DtSeguros As DataTable,
    ByVal oePeriodo As e_Periodo, ByVal IdUsuarioCreacion As String,
    ByVal oemoneda As e_Moneda, ByVal lnTipoCambio As Double, ByVal lsTipo As String, ByVal PrefijoID As String) As Boolean Implements Il_Asiento.GuardarSegurosDevengados
        Try
            Dim MonedaGlosa As String = "SOLES"
            Dim oeAsiento2 As New e_Asiento
            Dim olAsiento2 As New l_Asiento
            Dim leAsiento2 As New List(Of e_Asiento)

            Dim oeTCD As New e_TablaContableDet
            Dim odTCD As New d_TablaContableDet
            Dim Cta65 As String
            oeTCD.TipoOperacion = "N"
            oeTCD.Activo = True
            oeTCD.Nombre = "CUENTAS GENERALES"
            oeTCD.Texto1 = "CTA65SEGUROS"
            oeTCD.Valor1 = oePeriodo.Ejercicio
            oeTCD = odTCD.Listar(oeTCD)(0)
            Cta65 = oeTCD.Texto2

            Dim Cta18 As String
            oeTCD.TipoOperacion = "N"
            oeTCD.Activo = True
            oeTCD.Nombre = "CUENTAS GENERALES"
            If lsTipo = "POLIZA" Then
                oeTCD.Texto1 = "CTA18POLIZA"
            Else
                oeTCD.Texto1 = "CTA18SOAT"
            End If
            oeTCD.Valor1 = oePeriodo.Ejercicio
            oeTCD = odTCD.Listar(oeTCD)(0)
            Cta18 = oeTCD.Texto2

            oeAsiento2.IdPeriodo = oePeriodo.Id
            If lsTipo = "POLIZA" Then
                oeAsiento2.IdentificaAsiento = "SEGUROS " & oePeriodo.Codigo
            Else
                oeAsiento2.IdentificaAsiento = "SOAT " & oePeriodo.Codigo
            End If
            oeAsiento2.IdMoneda = oemoneda.Id
            leAsiento2.AddRange(olAsiento2.Listar(oeAsiento2))
            If leAsiento2.Count > 0 Then
                Throw New Exception("Ya existe el asiento de seguros para el periodo " & oePeriodo.Codigo)
            End If
            '------------

            Dim oeAsiento As New e_Asiento
            oeAsiento.TipoOperacion = "I"
            oeAsiento.Fecha = oePeriodo.FechaFin
            oeAsiento.IdPeriodo = oePeriodo.Id
            oeAsiento.IdTipoAsiento = "DIARIO"
            If lsTipo = "POLIZA" Then
                oeAsiento.Glosa = "PROV. SEGURO VEHICULOS DEVENGADOS MES " & oePeriodo.Codigo
            Else
                oeAsiento.Glosa = "PROV. SOAT DEVENGADOS MES " & oePeriodo.Codigo
            End If
            oeAsiento.GlosaImprime = oeAsiento.Glosa
            oeAsiento.IdMoneda = oemoneda.Id
            oeAsiento.TipoCambio = lnTipoCambio
            oeAsiento.TotalDebe = 0
            oeAsiento.TotalHaber = 0
            oeAsiento.IdUsuarioBloquea = ""
            oeAsiento.IdEstado = "CUADRADO" 'Estado Cuadrado
            oeAsiento.IdAsientoExtorno = ""
            oeAsiento.IdUsuarioCrea = IdUsuarioCreacion
            If lsTipo = "POLIZA" Then
                oeAsiento.IdentificaAsiento = "SEGUROS " & oePeriodo.Codigo
            Else
                oeAsiento.IdentificaAsiento = "SOAT " & oePeriodo.Codigo
            End If

            Dim olMovimientoAnalisis As New l_MovimientoAnalisis
            Dim odAMovimientoAnalisis As New d_MovimientoAnalisis

            Dim Id As String = odAMovimientoAnalisis.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(Id, 1) & "SI"
            Dim lsNumero As Integer = CInt(Right(Id, Len(Id) - 3))
            ''---------------------------asientos de apertura----------------
            Dim lnHaberMN As Double = 0
            Dim lnHaberME As Double = 0
            Dim oeAsMov As New e_AsientoMovimiento
            For Each ofila As DataRow In DtSeguros.Rows
                If ofila.Item("seleccion") = 1 Then
                    Dim dt_MovAn As Data.DataTable = olMovimientoAnalisis.CrearDT
                    Dim DebeMN As Double = 0
                    Dim DebeME As Double = 0
                    Dim TotalAsiento As Double = ofila.Item("TotalAsiento") - (ofila.Item("TotalxVehiculo") * ofila.Item("Excluido"))
                    If ofila.Item("IdMoneda") = "1CH01" Then
                        DebeMN = TotalAsiento
                        DebeME = TotalAsiento / lnTipoCambio
                    Else
                        DebeMN = TotalAsiento * lnTipoCambio
                        DebeME = TotalAsiento
                    End If
                    lnHaberMN = lnHaberMN + DebeMN
                    lnHaberME = lnHaberME + DebeME
                    oeAsMov = New e_AsientoMovimiento
                    With oeAsMov
                        'Asiento Movimiento Cabecera
                        .Id = ""
                        .IdCuentaContable = Cta65  'Asigno el tipo de asiento guardado en la TablaContableDetalle segun combo Medio de Pago
                        .Glosa = oeAsiento.Glosa & " SEG:" & ofila.Item("Numero")
                        .HaberMN = 0
                        .HaberME = 0
                        .DebeMN = DebeMN
                        .DebeME = DebeME
                        .IdUsuarioCrea = IdUsuarioCreacion
                        .Activo = True
                        .TipoOperacion = "I"
                        .MovimientoCajaBanco = Nothing
                        .AsMov_MovDoc = Nothing ' No se Genera relacion
                        .BandGuardMasivo = True
                        '----consultat lista de vehiculos------------
                        Dim dt As DataTable = ListarDevengadoSeguros(Date.Now, "DET", ofila.Item("IdDocumento"))
                        For Each obj As DataRow In dt.Rows
                            Dim rowDetalle As Data.DataRow
                            rowDetalle = dt_MovAn.NewRow
                            rowDetalle("Id") = lsPrefijo & olFuncionesGenerales.CompletaConCeros(lsNumero.ToString, 13)
                            rowDetalle("IdCentroCosto") = "1CH000000007" 'GERENCIA COORPORATIVA DE CONTABILIDAD
                            If lsTipo = "POLIZA" Then
                                rowDetalle("IdItemGasto") = "1CH000096" 'seguro de vehiculo
                            Else
                                rowDetalle("IdItemGasto") = "1CH000097" 'soat
                            End If
                            rowDetalle("IdTrabajador") = ""
                            rowDetalle("IdVehiculo") = obj.Item("IdVehiculo")
                            rowDetalle("IdRuta") = ""
                            rowDetalle("IdBanco") = ""
                            rowDetalle("IdAnalisis1") = ""
                            rowDetalle("IdAnalisis2") = ""
                            rowDetalle("Activo") = 1
                            rowDetalle("IdAsientoMovimiento") = ""
                            rowDetalle("Monto") = ofila.Item("TotalxVehiculo")
                            rowDetalle("Saldo") = ofila.Item("TotalxVehiculo")
                            rowDetalle("IdMovimientoAnalisis") = ""
                            rowDetalle("IdGastoFuncion") = "1CH000087" 'costo de venta
                            dt_MovAn.Rows.Add(rowDetalle)
                            lsNumero = lsNumero + 1
                        Next
                        .DataTableAnalisis = dt_MovAn
                    End With
                    oeAsiento.AsientoMovimiento.Add(oeAsMov)
                End If
            Next
            oeAsMov = New e_AsientoMovimiento

            With oeAsMov
                'Asiento Movimiento Cabecera
                .Id = ""
                .IdCuentaContable = Cta18  'Asigno el tipo de asiento guardado en la TablaContableDetalle segun combo Medio de Pago
                .Glosa = oeAsiento.Glosa
                .HaberMN = lnHaberMN
                .HaberME = lnHaberME
                .DebeMN = 0
                .DebeME = 0
                .IdUsuarioCrea = IdUsuarioCreacion
                .Activo = True
                .TipoOperacion = "I"
                .MovimientoCajaBanco = Nothing
                .AsMov_MovDoc = Nothing ' No se Genera relacion
            End With
            oeAsiento.AsientoMovimiento.Add(oeAsMov)
            ''-------------------------------------------------------------------
            Dim odAsiento As New d_Asiento
            Return odAsiento.GuardarMasivo(oeAsiento)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener2(oeAsiento As e_Asiento) As e_Asiento Implements Il_Asiento.Obtener2
        Try
            Return odAsiento.Obtener2(oeAsiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Cobranzas y Pagos"

    Public Function GuardarCobranza(ByVal leMovDocAgregado As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoDocumento),
                                    ByVal oeMovCajaBanco As EntidadesWCF.e_MovimientoCajaBanco,
                                    ByVal oeMedioCobro As EntidadesWCF.e_MedioPago,
                                    ByVal idUsuario As String,
                                    ByVal MacLocal As String,
                                    ByVal oeCtaCble As EntidadesWCF.e_CuentaContable,
                                    ByVal Opcion As String) As Boolean Implements Il_Asiento.GuardarCobranza
        Try
            Dim cadena As String = ""
            For i = 0 To leMovDocAgregado.Count() - 1
                If i = 0 Then
                    cadena &= "'" & leMovDocAgregado(0).Id & "'"
                ElseIf i > 0 Then
                    cadena &= ",'" & leMovDocAgregado(i).Id & "'"
                End If
            Next

            If ValidarCobranza(cadena, leMovDocAgregado, oeMovCajaBanco.Fecha, Opcion) Then

                Dim oePeriodo As New e_Periodo
                Dim olPeriodo As New l_Periodo
                Dim IdPeriodo As String = ""
                oePeriodo.Ejercicio = oeMovCajaBanco.Fecha.Year
                oePeriodo.Mes = oeMovCajaBanco.Fecha.Month
                IdPeriodo = olPeriodo.Obtener(oePeriodo).Id

                ObtenerCuentas(oePeriodo.Ejercicio)

                Dim oeTipoAsiento As New e_TablaContableDet
                Dim loTipoAsiento As New l_TablaContableDet
                Dim leTablaContableDet As New List(Of e_TablaContableDet)
                Dim IdTipoAsiento As String
                oeTipoAsiento.TipoOperacion = "N"
                oeTipoAsiento.Nombre = "TIPO DE ASIENTO" 'tipo de asiento
                oeTipoAsiento.Logico1 = True
                oeTipoAsiento.Activo = True
                leTablaContableDet.AddRange(loTipoAsiento.Listar(oeTipoAsiento))
                IdTipoAsiento = leTablaContableDet.Where(Function(i) i.Nombre = oeMedioCobro.IdTipoAsiento)(0).Id

                Dim Glosa As String = ""
                If leMovDocAgregado.Count > 1 Then
                    Dim ls_ClienteProve As String = leMovDocAgregado.Item(0)._NombreClienteProveedor
                    Dim lbBandera As Boolean = False
                    For Each o_o As e_MovimientoDocumento In leMovDocAgregado
                        If ls_ClienteProve <> o_o._NombreClienteProveedor Then lbBandera = True
                        Exit For
                    Next
                    If lbBandera Then
                        Glosa = "COBRO DCMTOS. VARIOS " & oeMedioCobro.Abreviatura & "/ " & oeMovCajaBanco.Glosa
                    Else
                        Glosa = "COBRO DCMTOS. VARIOS " & oeMedioCobro.Abreviatura & "/" & leMovDocAgregado.Item(0)._NombreClienteProveedor & " " & oeMovCajaBanco.Glosa
                    End If
                ElseIf leMovDocAgregado.Count = 1 Then
                    Glosa = "COBRO " & leMovDocAgregado.Item(0)._AbrevTipoDoc & "/" & leMovDocAgregado.Item(0).Serie & leMovDocAgregado.Item(0).Numero & " " &
                        leMovDocAgregado.Item(0)._NombreClienteProveedor & " " & oeMovCajaBanco.Glosa
                End If

                Dim IdMoneda = ""
                If oeCtaCble.MonedaExtranjera = 0 Then
                    IdMoneda = "1CH01"
                Else
                    IdMoneda = "1CH02"
                End If

                Dim IdAsiento As String = odAsiento.UltimoIdInserta(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
                Dim lsNumeroAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))

                Dim NroAsientoT As String = odAsiento.UltimoNroAsiento(IdTipoAsiento, IdPeriodo, "1", oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoNroAsientoT As String = Left(NroAsientoT, 2)
                Dim lsNumeroNroAsientoT As Integer = CInt(Right(NroAsientoT, Len(NroAsientoT) - 2))

                Dim NroAsientoD As String = odAsiento.UltimoNroAsiento("1CH000020", IdPeriodo, "1", oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoNroAsientoD As String = Left(NroAsientoD, 2)
                Dim lsNumeroNroAsientoD As Integer = CInt(Right(NroAsientoD, Len(NroAsientoD) - 2))

                Dim IdAsientoMovimiento As String = odAsientoMovimiento.UltimoIdInsertar(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoAsientoMovimiento As String = Left(IdAsientoMovimiento, 3)
                Dim lsNumeroAsientoMovimiento As Integer = CInt(Right(IdAsientoMovimiento, Len(IdAsientoMovimiento) - 3))

                Dim IdMovimientoCajaBanco As String = odMovCajaBanco.UltimoIdInserta(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoMovCajaBanco As String = Left(IdMovimientoCajaBanco, 3)
                Dim lsNumeroMovCajaBanco As Integer = CInt(Right(IdMovimientoCajaBanco, Len(IdMovimientoCajaBanco) - 3))

                Dim NroImpresion As String = ""
                Dim lsPrefijoNroImpresion As String = ""
                Dim lsNroImpresion As Integer = 0
                If Len(Trim(oeMovCajaBanco.IdCuentaBancaria)) = 12 Then
                    NroImpresion = odAsiento.UltimoNroAsiento(oeMovCajaBanco.IdCuentaBancaria, IdPeriodo, "2", oeMovCajaBanco.PrefijoID)
                    lsPrefijoNroImpresion = Left(NroImpresion, 2)
                    lsNroImpresion = CInt(Right(NroImpresion, Len(NroImpresion) - 2))
                End If

                Dim IdCuentaxCyP As String = odCuentaxCyP.UltimoIdInserta(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoCuentaxCyP As String = Left(IdCuentaxCyP, 3)
                Dim lsNumeroCuentaxCyP As Integer = CInt(Right(IdCuentaxCyP, Len(IdCuentaxCyP) - 3))

                Dim IdAsientoMov_MovDoc As String = odAsMovMovDoc.UltimoIdInsertar(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoAsientoMov_MovDoc As String = Left(IdAsientoMov_MovDoc, 3)
                Dim lsNumeroAsientoMov_MovDoc As Integer = CInt(Right(IdAsientoMov_MovDoc, Len(IdAsientoMov_MovDoc) - 3))

                Dim IdMovAna As String = odMovimientoAnalisis.UltimoIdInserta(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoMovAna As String = Left(IdMovAna, 3)
                Dim lsNumeroMovAna As Integer = CInt(Right(IdMovAna, Len(IdMovAna) - 3))

                Dim dt_A As Data.DataTable = CrearDT()
                Dim dt_AM As Data.DataTable = olAsientoMovimiento.CrearDT()
                Dim dt_MCB As Data.DataTable = olMovCajaBanco.CrearDT()
                Dim dt_CTAXCYP As Data.DataTable = olCuentaxCyP.CrearDT()
                Dim dt_AMMDOC As Data.DataTable = olAsientoMov_MovDoc.CrearDT()
                Dim dt_MA As Data.DataTable = olMovimientoAnalisis.CrearDT

                Dim nrolinea As Integer = 2

                Dim rowAsiento As Data.DataRow
                rowAsiento = dt_A.NewRow
                rowAsiento("Id") = lsPrefijoAsiento.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rowAsiento("IdPeriodo") = IdPeriodo
                rowAsiento("IdTipoAsiento") = IIf(Opcion = "PER", "1CH000020", IdTipoAsiento)
                rowAsiento("NroAsiento") = IIf(Opcion = "PER", lsPrefijoNroAsientoD + olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsientoD, 7).ToString, lsPrefijoNroAsientoT + olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsientoT, 7).ToString)
                rowAsiento("Fecha") = oeMovCajaBanco.Fecha
                rowAsiento("Glosa") = Glosa
                rowAsiento("GlosaImprime") = Glosa
                rowAsiento("IdMoneda") = IdMoneda
                rowAsiento("TipoCambio") = oeMovCajaBanco.TipoCambio
                rowAsiento("TotalDebe") = IIf(IdMoneda = "1CH01", oeMovCajaBanco.TotalMN, oeMovCajaBanco.TotalME)
                rowAsiento("TotalHaber") = IIf(IdMoneda = "1CH01", oeMovCajaBanco.TotalMN, oeMovCajaBanco.TotalME)
                rowAsiento("IdUsuarioBloquea") = ""
                rowAsiento("UsuarioCreacion") = idUsuario
                rowAsiento("IdEstado") = "1CH00005"
                rowAsiento("IdAsientoExtorno") = ""
                rowAsiento("FechaCreacion") = Date.Now()
                rowAsiento("Activo") = True
                rowAsiento("NroAsientoImprime") = DBNull.Value
                rowAsiento("IdentificaAsiento") = DBNull.Value
                rowAsiento("IndRevision") = DBNull.Value
                rowAsiento("FechaRevision") = DBNull.Value
                rowAsiento("UsuarioRevision") = DBNull.Value
                rowAsiento("IndOrigen") = 20
                rowAsiento("UsuarioModificacion") = DBNull.Value
                rowAsiento("FechaModificacion") = DBNull.Value
                dt_A.Rows.Add(rowAsiento)

                If Opcion <> "PER" Then
                    Dim rowMovCajaBanco As Data.DataRow
                    rowMovCajaBanco = dt_MCB.NewRow
                    rowMovCajaBanco("Id") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroMovCajaBanco.ToString, 13)
                    rowMovCajaBanco("IdFlujoCaja") = oeMovCajaBanco.IdFlujoCaja
                    rowMovCajaBanco("NroBoucher") = oeMovCajaBanco.NroBoucher
                    rowMovCajaBanco("IdCuentaBancaria") = oeMovCajaBanco.IdCuentaBancaria
                    rowMovCajaBanco("Fecha") = oeMovCajaBanco.Fecha
                    rowMovCajaBanco("IdTipoDocumento") = oeMovCajaBanco.IdMedioPago
                    rowMovCajaBanco("IdPeriodoConcilia") = ""
                    rowMovCajaBanco("Activo") = True
                    rowMovCajaBanco("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                    rowMovCajaBanco("TipoCambio") = oeMovCajaBanco.TipoCambio
                    rowMovCajaBanco("TotalMN") = oeMovCajaBanco.TotalMN
                    rowMovCajaBanco("TotalME") = oeMovCajaBanco.TotalME
                    rowMovCajaBanco("Operador") = 1
                    rowMovCajaBanco("NroImpresion") = IIf(Len(Trim(oeMovCajaBanco.IdCuentaBancaria)) = 12, lsPrefijoNroImpresion + olFuncionesGenerales.CompletaConCeros(lsNroImpresion.ToString, 8), "")
                    rowMovCajaBanco("IdTipoGasto") = ""
                    dt_MCB.Rows.Add(rowMovCajaBanco)
                    IdMovimientoCajaBanco = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroMovCajaBanco.ToString, 13)
                Else
                    Dim rowMovAna As Data.DataRow
                    rowMovAna = dt_MA.NewRow
                    rowMovAna("Id") = lsPrefijoMovAna & olFuncionesGenerales.CompletaConCeros(lsNumeroMovAna.ToString, 13)
                    rowMovAna("IdCentroCosto") = DBNull.Value
                    rowMovAna("IdItemGasto") = DBNull.Value
                    rowMovAna("IdTrabajador") = DBNull.Value
                    rowMovAna("IdVehiculo") = ""
                    rowMovAna("IdRuta") = DBNull.Value
                    rowMovAna("IdBanco") = DBNull.Value
                    rowMovAna("IdAnalisis1") = DBNull.Value
                    rowMovAna("IdAnalisis2") = DBNull.Value
                    rowMovAna("Activo") = 1
                    rowMovAna("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                    rowMovAna("Monto") = IIf(IdMoneda = "1CH01", oeMovCajaBanco.TotalMN, oeMovCajaBanco.TotalME)
                    rowMovAna("Saldo") = IIf(IdMoneda = "1CH01", oeMovCajaBanco.TotalMN, oeMovCajaBanco.TotalME)
                    rowMovAna("IdMovimientoAnalisis") = DBNull.Value
                    rowMovAna("IdGastoFuncion") = "1CH000090"
                    rowMovAna("IdOrigenProrrateo") = ""
                    dt_MA.Rows.Add(rowMovAna)
                    lsNumeroMovAna = lsNumeroMovAna + 1
                End If

                Dim rowAsientoMov_Inicial As Data.DataRow
                rowAsientoMov_Inicial = dt_AM.NewRow
                rowAsientoMov_Inicial("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                rowAsientoMov_Inicial("IdAsiento") = lsPrefijoAsiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rowAsientoMov_Inicial("IdCuentaContable") = IIf(Opcion = "PER", leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_PERDIDAS")(0).Texto2, oeCtaCble.Id)
                rowAsientoMov_Inicial("Glosa") = Glosa
                rowAsientoMov_Inicial("DebeMN") = oeMovCajaBanco.TotalMN
                rowAsientoMov_Inicial("HaberMN") = 0
                rowAsientoMov_Inicial("DebeME") = oeMovCajaBanco.TotalME
                rowAsientoMov_Inicial("HaberME") = 0
                rowAsientoMov_Inicial("IdUsuarioCrea") = idUsuario
                rowAsientoMov_Inicial("FechaCreacion") = Date.Now()
                rowAsientoMov_Inicial("Activo") = True
                rowAsientoMov_Inicial("NroLinea") = 1
                dt_AM.Rows.Add(rowAsientoMov_Inicial)
                lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1

                For Each obj In leMovDocAgregado

                    Dim rowCuentaxCyP As Data.DataRow
                    rowCuentaxCyP = dt_CTAXCYP.NewRow
                    rowCuentaxCyP("Id") = lsPrefijoCuentaxCyP + olFuncionesGenerales.CompletaConCeros(lsNumeroCuentaxCyP.ToString, 12)
                    rowCuentaxCyP("IdMovimientoCajaBanco") = IIf(Opcion = "PER", DBNull.Value, IdMovimientoCajaBanco)
                    rowCuentaxCyP("IdMovimientoDocumento") = obj.Id
                    rowCuentaxCyP("Fecha") = oeMovCajaBanco.Fecha
                    If obj.IdMoneda = "1CH01" Then
                        rowCuentaxCyP("MontoMN") = obj.MontoOperar
                        rowCuentaxCyP("MontoME") = obj.MontoOperar / oeMovCajaBanco.TipoCambio
                    Else
                        rowCuentaxCyP("MontoMN") = obj.MontoOperar * oeMovCajaBanco.TipoCambio
                        rowCuentaxCyP("MontoME") = obj.MontoOperar
                    End If
                    rowCuentaxCyP("Activo") = True
                    rowCuentaxCyP("UsuarioCreacion") = idUsuario
                    rowCuentaxCyP("FechaCreacion") = Date.Now()
                    rowCuentaxCyP("MacPCLocalCreacion") = MacLocal
                    rowCuentaxCyP("IdCuentaCorriente") = oeMovCajaBanco.IdCuentaCorriente
                    dt_CTAXCYP.Rows.Add(rowCuentaxCyP)

                    Dim rowAsientoMovimiento As Data.DataRow
                    rowAsientoMovimiento = dt_AM.NewRow
                    rowAsientoMovimiento("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                    rowAsientoMovimiento("IdAsiento") = lsPrefijoAsiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                    rowAsientoMovimiento("IdCuentaContable") = obj.IdCuentaContable
                    rowAsientoMovimiento("Glosa") = "COBRO " & obj._AbrevTipoDoc & "/" & obj.Serie & obj.Numero & " " & obj._NombreClienteProveedor
                    If obj.IdMoneda = "1CH01" Then
                        rowAsientoMovimiento("DebeMN") = 0
                        rowAsientoMovimiento("HaberMN") = obj.MontoOperar
                        rowAsientoMovimiento("DebeME") = 0
                        rowAsientoMovimiento("HaberME") = obj.MontoOperar / oeMovCajaBanco.TipoCambio
                    Else
                        rowAsientoMovimiento("DebeMN") = 0
                        rowAsientoMovimiento("HaberMN") = obj.MontoOperar * oeMovCajaBanco.TipoCambio
                        rowAsientoMovimiento("DebeME") = 0
                        rowAsientoMovimiento("HaberME") = obj.MontoOperar
                    End If
                    rowAsientoMovimiento("IdUsuarioCrea") = idUsuario
                    rowAsientoMovimiento("FechaCreacion") = Date.Now()
                    rowAsientoMovimiento("Activo") = True
                    rowAsientoMovimiento("NroLinea") = nrolinea
                    dt_AM.Rows.Add(rowAsientoMovimiento)

                    Dim rowAsMov_MovDoc As Data.DataRow
                    rowAsMov_MovDoc = dt_AMMDOC.NewRow
                    rowAsMov_MovDoc("Id") = lsPrefijoAsientoMov_MovDoc + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMov_MovDoc, 9)
                    rowAsMov_MovDoc("IdMovimientoDocumento") = obj.Id
                    rowAsMov_MovDoc("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento, 13)
                    rowAsMov_MovDoc("Activo") = True
                    rowAsMov_MovDoc("IdCuentaxCyP") = lsPrefijoCuentaxCyP + olFuncionesGenerales.CompletaConCeros(lsNumeroCuentaxCyP.ToString, 12)
                    rowAsMov_MovDoc("UsuarioCreacion") = idUsuario
                    rowAsMov_MovDoc("FechaCreacion") = Date.Now()
                    dt_AMMDOC.Rows.Add(rowAsMov_MovDoc)

                    lsNumeroCuentaxCyP = lsNumeroCuentaxCyP + 1
                    lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1
                    lsNumeroAsientoMov_MovDoc = lsNumeroAsientoMov_MovDoc + 1
                    nrolinea = nrolinea + 1
                Next

                If Opcion = "GAN" Then
                    Dim rowAsientoMovimientoGan As Data.DataRow
                    rowAsientoMovimientoGan = dt_AM.NewRow
                    rowAsientoMovimientoGan("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                    rowAsientoMovimientoGan("IdAsiento") = lsPrefijoAsiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                    rowAsientoMovimientoGan("IdCuentaContable") = leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_GANANCIA")(0).Texto2
                    rowAsientoMovimientoGan("Glosa") = Glosa
                    If IdMoneda = "1CH01" Then
                        rowAsientoMovimientoGan("DebeMN") = 0
                        rowAsientoMovimientoGan("HaberMN") = oeMovCajaBanco.DifAGanancia
                        rowAsientoMovimientoGan("DebeME") = 0
                        rowAsientoMovimientoGan("HaberME") = oeMovCajaBanco.DifAGanancia / oeMovCajaBanco.TipoCambio
                    Else
                        rowAsientoMovimientoGan("DebeMN") = 0
                        rowAsientoMovimientoGan("HaberMN") = oeMovCajaBanco.DifAGanancia * oeMovCajaBanco.TipoCambio
                        rowAsientoMovimientoGan("DebeME") = 0
                        rowAsientoMovimientoGan("HaberME") = oeMovCajaBanco.DifAGanancia
                    End If
                    rowAsientoMovimientoGan("IdUsuarioCrea") = idUsuario
                    rowAsientoMovimientoGan("FechaCreacion") = Date.Now()
                    rowAsientoMovimientoGan("Activo") = True
                    rowAsientoMovimientoGan("NroLinea") = nrolinea
                    dt_AM.Rows.Add(rowAsientoMovimientoGan)
                    lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1
                End If

                lsNumeroAsiento = lsNumeroAsiento + 1
                lsNumeroNroAsientoD = lsNumeroNroAsientoD + 1
                lsNumeroNroAsientoT = lsNumeroNroAsientoT + 1

                For Each obj In leMovDocAgregado.Where(Function(i) i.IdMoneda = "1CH02" And (i.Saldo - i.MontoOperar) < 0.1 And (i.Saldo - i.MontoOperar) > -0.1)
                    Dim ds As DataSet
                    ds = odMovimientoDocumento.ObtenerAJusteTipoCambio("DOC", obj.Id, "", oeMovCajaBanco.Fecha.Year)
                    Dim DebeMN As Decimal = ds.Tables(0).Rows(0).Item("DebeMN")
                    Dim HaberMN As Decimal = ds.Tables(0).Rows(0).Item("HaberMN") + (obj.MontoOperar * oeMovCajaBanco.TipoCambio)
                    If DebeMN <> HaberMN Then
                        Dim glosaajuste As String = IIf(DebeMN > HaberMN, "ASIENTO DE PERDIDA ", "ASIENTO DE GANACIA ") & obj._AbrevTipoDoc & "/" &
                            obj.Serie & obj.Numero & " " & obj._NombreClienteProveedor
                        Dim rowAsientoDif As Data.DataRow
                        rowAsientoDif = dt_A.NewRow
                        rowAsientoDif("Id") = lsPrefijoAsiento.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rowAsientoDif("IdPeriodo") = IdPeriodo
                        rowAsientoDif("IdTipoAsiento") = "1CH000020"
                        rowAsientoDif("NroAsiento") = lsPrefijoNroAsientoD + olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsientoD, 7).ToString
                        rowAsientoDif("Fecha") = oeMovCajaBanco.Fecha
                        rowAsientoDif("Glosa") = glosaajuste
                        rowAsientoDif("GlosaImprime") = glosaajuste
                        rowAsientoDif("IdMoneda") = "1CH01"
                        rowAsientoDif("TipoCambio") = 0.0
                        rowAsientoDif("TotalDebe") = Math.Abs(Math.Round(DebeMN - HaberMN, 3))
                        rowAsientoDif("TotalHaber") = Math.Abs(Math.Round(DebeMN - HaberMN, 3))
                        rowAsientoDif("IdUsuarioBloquea") = ""
                        rowAsientoDif("UsuarioCreacion") = idUsuario
                        rowAsientoDif("IdEstado") = "1CH00005"
                        rowAsientoDif("IdAsientoExtorno") = ""
                        rowAsientoDif("FechaCreacion") = Date.Now()
                        rowAsientoDif("Activo") = True
                        rowAsientoDif("NroAsientoImprime") = DBNull.Value
                        rowAsientoDif("IdentificaAsiento") = "AJUSTETCMD" + obj.Id
                        rowAsientoDif("IndRevision") = DBNull.Value
                        rowAsientoDif("FechaRevision") = DBNull.Value
                        rowAsientoDif("UsuarioRevision") = DBNull.Value
                        rowAsientoDif("IndOrigen") = 21
                        rowAsientoDif("UsuarioModificacion") = DBNull.Value
                        rowAsientoDif("FechaModificacion") = DBNull.Value
                        dt_A.Rows.Add(rowAsientoDif)

                        Dim rowAsientoMovimientoDif1 As Data.DataRow
                        rowAsientoMovimientoDif1 = dt_AM.NewRow
                        rowAsientoMovimientoDif1("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                        rowAsientoMovimientoDif1("IdAsiento") = lsPrefijoAsiento.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rowAsientoMovimientoDif1("IdCuentaContable") = obj.IdCuentaContable
                        rowAsientoMovimientoDif1("Glosa") = glosaajuste
                        rowAsientoMovimientoDif1("DebeMN") = IIf(DebeMN > HaberMN, 0, HaberMN - DebeMN)
                        rowAsientoMovimientoDif1("HaberMN") = IIf(HaberMN > DebeMN, 0, DebeMN - HaberMN)
                        rowAsientoMovimientoDif1("DebeME") = 0.0
                        rowAsientoMovimientoDif1("HaberME") = 0.0
                        rowAsientoMovimientoDif1("IdUsuarioCrea") = idUsuario
                        rowAsientoMovimientoDif1("FechaCreacion") = Date.Now()
                        rowAsientoMovimientoDif1("Activo") = True
                        rowAsientoMovimientoDif1("NroLinea") = 1
                        dt_AM.Rows.Add(rowAsientoMovimientoDif1)

                        Dim rowAsMov_MovDoc As Data.DataRow
                        rowAsMov_MovDoc = dt_AMMDOC.NewRow
                        rowAsMov_MovDoc("Id") = lsPrefijoAsientoMov_MovDoc + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMov_MovDoc, 9)
                        rowAsMov_MovDoc("IdMovimientoDocumento") = obj.Id
                        rowAsMov_MovDoc("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                        rowAsMov_MovDoc("Activo") = True
                        rowAsMov_MovDoc("IdCuentaxCyP") = DBNull.Value
                        rowAsMov_MovDoc("UsuarioCreacion") = idUsuario
                        rowAsMov_MovDoc("FechaCreacion") = Date.Now()
                        dt_AMMDOC.Rows.Add(rowAsMov_MovDoc)
                        lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1

                        Dim rowAsientoMovimientoDif2 As Data.DataRow
                        rowAsientoMovimientoDif2 = dt_AM.NewRow
                        rowAsientoMovimientoDif2("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                        rowAsientoMovimientoDif2("IdAsiento") = lsPrefijoAsiento.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rowAsientoMovimientoDif2("IdCuentaContable") = IIf(HaberMN > DebeMN, leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_GANANCIA")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_PERDIDAS")(0).Texto2)
                        rowAsientoMovimientoDif2("Glosa") = glosaajuste
                        rowAsientoMovimientoDif2("DebeMN") = IIf(DebeMN > HaberMN, Math.Abs(DebeMN - HaberMN), 0.0)
                        rowAsientoMovimientoDif2("HaberMN") = IIf(HaberMN > DebeMN, Math.Abs(HaberMN - DebeMN), 0.0)
                        rowAsientoMovimientoDif2("DebeME") = 0.0
                        rowAsientoMovimientoDif2("HaberME") = 0.0
                        rowAsientoMovimientoDif2("IdUsuarioCrea") = idUsuario
                        rowAsientoMovimientoDif2("FechaCreacion") = Date.Now()
                        rowAsientoMovimientoDif2("Activo") = True
                        rowAsientoMovimientoDif2("NroLinea") = 2
                        dt_AM.Rows.Add(rowAsientoMovimientoDif2)

                        If DebeMN > HaberMN Then 'CASO PÉRDIDA
                            Dim rowMovAna As Data.DataRow
                            rowMovAna = dt_MA.NewRow
                            rowMovAna("Id") = lsPrefijoMovAna & olFuncionesGenerales.CompletaConCeros(lsNumeroMovAna.ToString, 13)
                            rowMovAna("IdCentroCosto") = DBNull.Value
                            rowMovAna("IdItemGasto") = DBNull.Value
                            rowMovAna("IdTrabajador") = DBNull.Value
                            rowMovAna("IdVehiculo") = ""
                            rowMovAna("IdRuta") = DBNull.Value
                            rowMovAna("IdBanco") = DBNull.Value
                            rowMovAna("IdAnalisis1") = DBNull.Value
                            rowMovAna("IdAnalisis2") = DBNull.Value
                            rowMovAna("Activo") = 1
                            rowMovAna("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                            rowMovAna("Monto") = obj.MontoOperar * oeMovCajaBanco.TipoCambio
                            rowMovAna("Saldo") = obj.MontoOperar * oeMovCajaBanco.TipoCambio
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

                oeMovCajaBanco.Id = IdMovimientoCajaBanco
                oeMovCajaBanco.TipoOperacion = "S"

                odAsiento.GuardarCobranzaPago(dt_A, dt_AM, dt_MCB, dt_AMMDOC, dt_CTAXCYP, dt_MA, leMovDocAgregado, oeMovCajaBanco)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCobranza(ByVal cadena As String, ByVal leDocumentosAgregados As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoDocumento), ByVal fecha As Date, ByVal Opcion As String) As Object Implements Il_Asiento.ValidarCobranza
        Try
            Dim loFuncionesGenerales As New l_FuncionesGenerales
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, fecha, fecha.Year.ToString + "-" + fecha.Month.ToString)

            Dim ListaValida As New List(Of e_MovimientoDocumento)
            Dim oeMD As New e_MovimientoDocumento
            Dim olMD As New l_MovimientoDocumento
            oeMD.TipoOperacion = "SAL"
            oeMD.Activo = True
            oeMD.Documentos = cadena
            ListaValida = olMD.Listar(oeMD)

            For Each obj In leDocumentosAgregados
                Dim doc As Double = obj.Saldo
                Dim actual As Double = ListaValida.Where(Function(i) i.Id = obj.Id)(0).Saldo
                If doc - actual > 0.1 Or doc - actual < -0.1 Then
                    Throw New Exception("Los saldos ya cambiaron para el documento:" & obj.Serie & "-" & obj.Numero & " a cambiado a: " & ListaValida.Where(Function(i) i.Id = obj.Id)(0).Saldo.ToString)
                End If
                If obj.MontoOperar > (actual + 0.01) Then
                    Throw New Exception("El monto a operar es mayor que el saldo actual")
                End If
                If Opcion = "PER" Then
                    If obj.MontoOperar > 5.0 Then Throw New Exception("No se puede enviar a pérdida mas de 5.00 Doc." + obj.Serie + obj.Numero)
                End If
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarPago(ByVal leMovDocAgregado As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoDocumento),
    ByRef oeMovCajaBanco As EntidadesWCF.e_MovimientoCajaBanco,
    ByVal oeMedioPago As EntidadesWCF.e_MedioPago, ByVal idUsuario As String, ByVal MacLocal As String,
    ByVal oeCtaCble As EntidadesWCF.e_CuentaContable, ByVal lsOpcion As String) As Boolean Implements Il_Asiento.GuardarPago
        Try

            Dim cadena As String = ""
            For i = 0 To leMovDocAgregado.Count() - 1
                If i = 0 Then
                    cadena &= "'" & leMovDocAgregado(0).Id & "'"
                ElseIf i > 0 Then
                    cadena &= ",'" & leMovDocAgregado(i).Id & "'"
                End If
            Next

            If ValidarPago(cadena, leMovDocAgregado, oeMovCajaBanco.Fecha, lsOpcion) Then

                ObtenerCuentas(Year(oeMovCajaBanco.Fecha))

                Dim oePeriodo As New e_Periodo
                Dim olPeriodo As New l_Periodo
                Dim IdPeriodo As String = ""
                oePeriodo.Ejercicio = oeMovCajaBanco.Fecha.Year
                oePeriodo.Mes = oeMovCajaBanco.Fecha.Month
                IdPeriodo = olPeriodo.Obtener(oePeriodo).Id

                Dim oeTipoAsiento As New e_TablaContableDet
                Dim loTipoAsiento As New l_TablaContableDet
                Dim leTablaContableDet As New List(Of e_TablaContableDet)
                Dim IdTipoAsiento As String
                oeTipoAsiento.TipoOperacion = "N"
                oeTipoAsiento.Nombre = "TIPO DE ASIENTO"
                oeTipoAsiento.Logico1 = True
                oeTipoAsiento.Activo = True
                leTablaContableDet.AddRange(loTipoAsiento.Listar(oeTipoAsiento))
                IdTipoAsiento = leTablaContableDet.Where(Function(i) i.Nombre = oeMedioPago.IdTipoAsiento)(0).Id

                Dim Glosa As String = ""
                If leMovDocAgregado.Count > 1 Then
                    If lsOpcion = "PAG" Then Glosa = "PAGO DCMTOS. VARIOS " & oeMedioPago.Abreviatura & "/" & leMovDocAgregado.Item(0)._NombreClienteProveedor
                    If lsOpcion = "GAN" Then Glosa = "ASIENTO DE GANACIA " & oeMedioPago.Abreviatura & "/" & leMovDocAgregado.Item(0)._NombreClienteProveedor
                ElseIf leMovDocAgregado.Count = 1 Then
                    If lsOpcion = "PAG" Then Glosa = "PAGO " & leMovDocAgregado.Item(0)._AbrevTipoDoc & "/" & leMovDocAgregado.Item(0).Serie & leMovDocAgregado.Item(0).Numero & " " & leMovDocAgregado.Item(0)._NombreClienteProveedor
                    If lsOpcion = "GAN" Then Glosa = "ASIENTO DE GANANCIA " & leMovDocAgregado.Item(0)._AbrevTipoDoc & "/" & leMovDocAgregado.Item(0).Serie & leMovDocAgregado.Item(0).Numero & " " & leMovDocAgregado.Item(0)._NombreClienteProveedor
                End If

                Dim IdMoneda = ""
                If oeCtaCble.MonedaExtranjera = 0 Then
                    IdMoneda = "1CH01"
                Else
                    IdMoneda = "1CH02"
                End If

                Dim IdAsiento As String = odAsiento.UltimoIdInserta(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
                Dim lsNumeroAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))

                Dim NroAsientoT As String = odAsiento.UltimoNroAsiento(IdTipoAsiento, IdPeriodo, "1", oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoNroAsientoT As String = Left(NroAsientoT, 2)
                Dim lsNumeroNroAsientoT As Integer = CInt(Right(NroAsientoT, Len(NroAsientoT) - 2))

                Dim NroAsientoD As String = odAsiento.UltimoNroAsiento("1CH000020", IdPeriodo, "1", oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoNroAsientoD As String = Left(NroAsientoD, 2)
                Dim lsNumeroNroAsientoD As Integer = CInt(Right(NroAsientoD, Len(NroAsientoD) - 2))

                Dim IdAsientoMovimiento As String = odAsientoMovimiento.UltimoIdInsertar(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoAsientoMovimiento As String = Left(IdAsientoMovimiento, 3)
                Dim lsNumeroAsientoMovimiento As Integer = CInt(Right(IdAsientoMovimiento, Len(IdAsientoMovimiento) - 3))

                Dim IdMovimientoCajaBanco As String = odMovCajaBanco.UltimoIdInserta(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoMovCajaBanco As String = Left(IdMovimientoCajaBanco, 3)
                Dim lsNumeroMovCajaBanco As Integer = CInt(Right(IdMovimientoCajaBanco, Len(IdMovimientoCajaBanco) - 3))

                Dim NroImpresion As String = ""
                Dim lsPrefijoNroImpresion As String = ""
                Dim lsNroImpresion As Integer = 0
                If Len(Trim(oeMovCajaBanco.IdCuentaBancaria)) = 12 Then
                    NroImpresion = odAsiento.UltimoNroAsiento(oeMovCajaBanco.IdCuentaBancaria, IdPeriodo, "2", oeMovCajaBanco.PrefijoID)
                    lsPrefijoNroImpresion = Left(NroImpresion, 2)
                    lsNroImpresion = CInt(Right(NroImpresion, Len(NroImpresion) - 2))
                End If

                Dim IdCuentaxCyP As String = odCuentaxCyP.UltimoIdInserta(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoCuentaxCyP As String = Left(IdCuentaxCyP, 3)
                Dim lsNumeroCuentaxCyP As Integer = CInt(Right(IdCuentaxCyP, Len(IdCuentaxCyP) - 3))

                Dim IdAsientoMov_MovDoc As String = odAsMovMovDoc.UltimoIdInsertar(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoAsientoMov_MovDoc As String = Left(IdAsientoMov_MovDoc, 3)
                Dim lsNumeroAsientoMov_MovDoc As Integer = CInt(Right(IdAsientoMov_MovDoc, Len(IdAsientoMov_MovDoc) - 3))

                Dim IdMovAna As String = odMovimientoAnalisis.UltimoIdInserta(oeMovCajaBanco.PrefijoID)
                Dim lsPrefijoMovAna As String = Left(IdMovAna, 3)
                Dim lsNumeroMovAna As Integer = CInt(Right(IdMovAna, Len(IdMovAna) - 3))

                Dim dt_A As Data.DataTable = CrearDT()
                Dim dt_AM As Data.DataTable = olAsientoMovimiento.CrearDT()
                Dim dt_MCB As Data.DataTable = olMovCajaBanco.CrearDT()
                Dim dt_CTAXCYP As Data.DataTable = olCuentaxCyP.CrearDT()
                Dim dt_AMMDOC As Data.DataTable = olAsientoMov_MovDoc.CrearDT()
                Dim dt_MA As Data.DataTable = olMovimientoAnalisis.CrearDT

                Dim nrolinea As Integer = 2

                Dim rowAsiento As Data.DataRow
                rowAsiento = dt_A.NewRow
                rowAsiento("Id") = lsPrefijoAsiento.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rowAsiento("IdPeriodo") = IdPeriodo
                rowAsiento("IdTipoAsiento") = IIf(lsOpcion = "GAN", "1CH000020", IdTipoAsiento)
                rowAsiento("NroAsiento") = IIf(lsOpcion = "GAN", lsPrefijoNroAsientoD + olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsientoD, 7).ToString, lsPrefijoNroAsientoT + olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsientoT, 7).ToString)
                rowAsiento("Fecha") = oeMovCajaBanco.Fecha
                rowAsiento("Glosa") = Glosa
                rowAsiento("GlosaImprime") = Glosa
                rowAsiento("IdMoneda") = IdMoneda
                rowAsiento("TipoCambio") = oeMovCajaBanco.TipoCambio
                rowAsiento("TotalDebe") = IIf(IdMoneda = "1CH01", oeMovCajaBanco.TotalMN, oeMovCajaBanco.TotalME)
                rowAsiento("TotalHaber") = IIf(IdMoneda = "1CH01", oeMovCajaBanco.TotalMN, oeMovCajaBanco.TotalME)
                rowAsiento("IdUsuarioBloquea") = ""
                rowAsiento("UsuarioCreacion") = idUsuario
                rowAsiento("IdEstado") = "1CH00005"
                rowAsiento("IdAsientoExtorno") = ""
                rowAsiento("FechaCreacion") = Date.Now()
                rowAsiento("Activo") = True
                rowAsiento("NroAsientoImprime") = DBNull.Value
                rowAsiento("IdentificaAsiento") = DBNull.Value
                rowAsiento("IndRevision") = DBNull.Value
                rowAsiento("FechaRevision") = DBNull.Value
                rowAsiento("UsuarioRevision") = DBNull.Value
                rowAsiento("IndOrigen") = 10
                rowAsiento("UsuarioModificacion") = idUsuario
                rowAsiento("FechaModificacion") = Date.Now
                dt_A.Rows.Add(rowAsiento)

                If lsOpcion = "PAG" Then
                    Dim rowMovCajaBanco As Data.DataRow
                    rowMovCajaBanco = dt_MCB.NewRow
                    rowMovCajaBanco("Id") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroMovCajaBanco.ToString, 13)
                    rowMovCajaBanco("IdFlujoCaja") = oeMovCajaBanco.IdFlujoCaja
                    rowMovCajaBanco("NroBoucher") = oeMovCajaBanco.NroBoucher
                    rowMovCajaBanco("IdCuentaBancaria") = oeMovCajaBanco.IdCuentaBancaria
                    rowMovCajaBanco("Fecha") = oeMovCajaBanco.Fecha
                    rowMovCajaBanco("IdTipoDocumento") = oeMovCajaBanco.IdMedioPago
                    rowMovCajaBanco("IdPeriodoConcilia") = ""
                    rowMovCajaBanco("Activo") = True
                    rowMovCajaBanco("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                    rowMovCajaBanco("TipoCambio") = oeMovCajaBanco.TipoCambio
                    rowMovCajaBanco("TotalMN") = oeMovCajaBanco.TotalMN
                    rowMovCajaBanco("TotalME") = oeMovCajaBanco.TotalME
                    rowMovCajaBanco("Operador") = -1
                    rowMovCajaBanco("NroImpresion") = IIf(Len(Trim(oeMovCajaBanco.IdCuentaBancaria)) = 12, lsPrefijoNroImpresion + olFuncionesGenerales.CompletaConCeros(lsNroImpresion.ToString, 8), "")
                    rowMovCajaBanco("IdTipoGasto") = oeMovCajaBanco.IdTipoGasto
                    dt_MCB.Rows.Add(rowMovCajaBanco)
                    IdMovimientoCajaBanco = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroMovCajaBanco.ToString, 13)
                End If

                Dim rowAsientoMov_Inicial As Data.DataRow
                rowAsientoMov_Inicial = dt_AM.NewRow
                rowAsientoMov_Inicial("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                rowAsientoMov_Inicial("IdAsiento") = lsPrefijoAsiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rowAsientoMov_Inicial("IdCuentaContable") = IIf(lsOpcion = "GAN", leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_GANANCIA")(0).Texto2, oeCtaCble.Id)
                rowAsientoMov_Inicial("Glosa") = Glosa
                rowAsientoMov_Inicial("DebeMN") = 0
                rowAsientoMov_Inicial("HaberMN") = oeMovCajaBanco.TotalMN
                rowAsientoMov_Inicial("DebeME") = 0
                rowAsientoMov_Inicial("HaberME") = oeMovCajaBanco.TotalME
                rowAsientoMov_Inicial("IdUsuarioCrea") = idUsuario
                rowAsientoMov_Inicial("FechaCreacion") = Date.Now()
                rowAsientoMov_Inicial("Activo") = True
                rowAsientoMov_Inicial("NroLinea") = 1
                dt_AM.Rows.Add(rowAsientoMov_Inicial)
                lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1

                For Each obj In leMovDocAgregado

                    Dim rowCuentaxCyP As Data.DataRow
                    rowCuentaxCyP = dt_CTAXCYP.NewRow
                    rowCuentaxCyP("Id") = lsPrefijoCuentaxCyP + olFuncionesGenerales.CompletaConCeros(lsNumeroCuentaxCyP.ToString, 12)
                    rowCuentaxCyP("IdMovimientoCajaBanco") = IIf(lsOpcion = "GAN", DBNull.Value, IdMovimientoCajaBanco)
                    rowCuentaxCyP("IdMovimientoDocumento") = obj.Id
                    rowCuentaxCyP("Fecha") = oeMovCajaBanco.Fecha
                    If obj.IdMoneda = "1CH01" Then
                        rowCuentaxCyP("MontoMN") = obj.MontoOperar
                        rowCuentaxCyP("MontoME") = obj.MontoOperar / oeMovCajaBanco.TipoCambio
                    Else
                        rowCuentaxCyP("MontoMN") = obj.MontoOperar * oeMovCajaBanco.TipoCambio
                        rowCuentaxCyP("MontoME") = obj.MontoOperar
                    End If
                    rowCuentaxCyP("Activo") = True
                    rowCuentaxCyP("UsuarioCreacion") = idUsuario
                    rowCuentaxCyP("FechaCreacion") = Date.Now()
                    rowCuentaxCyP("MacPCLocalCreacion") = MacLocal
                    rowCuentaxCyP("IdCuentaCorriente") = oeMovCajaBanco.IdCuentaCorriente
                    dt_CTAXCYP.Rows.Add(rowCuentaxCyP)

                    Dim rowAsientoMovimiento As Data.DataRow
                    rowAsientoMovimiento = dt_AM.NewRow
                    rowAsientoMovimiento("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                    rowAsientoMovimiento("IdAsiento") = lsPrefijoAsiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                    rowAsientoMovimiento("IdCuentaContable") = obj.IdCuentaContable
                    rowAsientoMovimiento("Glosa") = IIf(lsOpcion = "PAG", "PAGO  ", "ASIENTO DE GANANCIA ") & obj._AbrevTipoDoc & "/" & obj.Serie & obj.Numero & " " & obj._NombreClienteProveedor
                    If obj.IdMoneda = "1CH01" Then
                        rowAsientoMovimiento("DebeMN") = obj.MontoOperar
                        rowAsientoMovimiento("HaberMN") = 0
                        rowAsientoMovimiento("DebeME") = obj.MontoOperar / oeMovCajaBanco.TipoCambio
                        rowAsientoMovimiento("HaberME") = 0
                    Else
                        rowAsientoMovimiento("DebeMN") = obj.MontoOperar * oeMovCajaBanco.TipoCambio
                        rowAsientoMovimiento("HaberMN") = 0
                        rowAsientoMovimiento("DebeME") = obj.MontoOperar
                        rowAsientoMovimiento("HaberME") = 0
                    End If
                    rowAsientoMovimiento("IdUsuarioCrea") = idUsuario
                    rowAsientoMovimiento("FechaCreacion") = Date.Now()
                    rowAsientoMovimiento("Activo") = True
                    rowAsientoMovimiento("NroLinea") = nrolinea
                    dt_AM.Rows.Add(rowAsientoMovimiento)

                    Dim rowAsMov_MovDoc As Data.DataRow
                    rowAsMov_MovDoc = dt_AMMDOC.NewRow
                    rowAsMov_MovDoc("Id") = lsPrefijoAsientoMov_MovDoc + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMov_MovDoc, 9)
                    rowAsMov_MovDoc("IdMovimientoDocumento") = obj.Id
                    rowAsMov_MovDoc("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento, 13)
                    rowAsMov_MovDoc("Activo") = True
                    rowAsMov_MovDoc("IdCuentaxCyP") = lsPrefijoCuentaxCyP + olFuncionesGenerales.CompletaConCeros(lsNumeroCuentaxCyP.ToString, 12)
                    dt_AMMDOC.Rows.Add(rowAsMov_MovDoc)

                    lsNumeroCuentaxCyP = lsNumeroCuentaxCyP + 1
                    lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1
                    lsNumeroAsientoMov_MovDoc = lsNumeroAsientoMov_MovDoc + 1
                    nrolinea = nrolinea + 1
                Next

                lsNumeroAsiento = lsNumeroAsiento + 1
                lsNumeroNroAsientoD = lsNumeroNroAsientoD + 1
                lsNumeroNroAsientoT = lsNumeroNroAsientoT + 1

                For Each obj In leMovDocAgregado.Where(Function(i) i.IdMoneda = "1CH02" And (i.Saldo - i.MontoOperar) < 0.1 And (i.Saldo - i.MontoOperar) > -0.1)
                    Dim ds As DataSet
                    ds = odMovimientoDocumento.ObtenerAJusteTipoCambio("DOC", obj.Id, "", oeMovCajaBanco.Fecha.Year)
                    Dim DebeMN As Decimal = ds.Tables(0).Rows(0).Item("DebeMN") + (obj.MontoOperar * oeMovCajaBanco.TipoCambio)
                    Dim HaberMN As Decimal = ds.Tables(0).Rows(0).Item("HaberMN")
                    If DebeMN <> HaberMN Then
                        Dim glosaajuste As String = IIf(DebeMN > HaberMN, "ASIENTO DE PERDIDA ", "ASIENTO DE GANACIA ") & obj._AbrevTipoDoc & "/" &
                            obj.Serie & obj.Numero & " " & obj._NombreClienteProveedor
                        Dim rowAsientoDif As Data.DataRow
                        rowAsientoDif = dt_A.NewRow
                        rowAsientoDif("Id") = lsPrefijoAsiento.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rowAsientoDif("IdPeriodo") = IdPeriodo
                        rowAsientoDif("IdTipoAsiento") = "1CH000020"
                        rowAsientoDif("NroAsiento") = lsPrefijoNroAsientoD + olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsientoD, 7).ToString
                        rowAsientoDif("Fecha") = oeMovCajaBanco.Fecha
                        rowAsientoDif("Glosa") = glosaajuste
                        rowAsientoDif("GlosaImprime") = glosaajuste
                        rowAsientoDif("IdMoneda") = "1CH01"
                        rowAsientoDif("TipoCambio") = 0.0
                        rowAsientoDif("TotalDebe") = Math.Abs(Math.Round(DebeMN - HaberMN, 3))
                        rowAsientoDif("TotalHaber") = Math.Abs(Math.Round(DebeMN - HaberMN, 3))
                        rowAsientoDif("IdUsuarioBloquea") = ""
                        rowAsientoDif("UsuarioCreacion") = idUsuario
                        rowAsientoDif("IdEstado") = "1CH00005"
                        rowAsientoDif("IdAsientoExtorno") = ""
                        rowAsientoDif("FechaCreacion") = Date.Now()
                        rowAsientoDif("Activo") = True
                        rowAsientoDif("NroAsientoImprime") = DBNull.Value
                        rowAsientoDif("IdentificaAsiento") = "AJUSTETCMD" + obj.Id
                        rowAsientoDif("IndRevision") = DBNull.Value
                        rowAsientoDif("FechaRevision") = DBNull.Value
                        rowAsientoDif("UsuarioRevision") = DBNull.Value
                        rowAsientoDif("IndOrigen") = 15
                        rowAsientoDif("UsuarioModificacion") = idUsuario
                        rowAsientoDif("FechaModificacion") = Date.Now
                        dt_A.Rows.Add(rowAsientoDif)

                        Dim rowAsientoMovimientoDif1 As Data.DataRow
                        rowAsientoMovimientoDif1 = dt_AM.NewRow
                        rowAsientoMovimientoDif1("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                        rowAsientoMovimientoDif1("IdAsiento") = lsPrefijoAsiento.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rowAsientoMovimientoDif1("IdCuentaContable") = obj.IdCuentaContable
                        rowAsientoMovimientoDif1("Glosa") = glosaajuste
                        rowAsientoMovimientoDif1("DebeMN") = IIf(DebeMN > HaberMN, 0, HaberMN - DebeMN)
                        rowAsientoMovimientoDif1("HaberMN") = IIf(HaberMN > DebeMN, 0, DebeMN - HaberMN)
                        rowAsientoMovimientoDif1("DebeME") = 0.0
                        rowAsientoMovimientoDif1("HaberME") = 0.0
                        rowAsientoMovimientoDif1("IdUsuarioCrea") = idUsuario
                        rowAsientoMovimientoDif1("FechaCreacion") = Date.Now()
                        rowAsientoMovimientoDif1("Activo") = True
                        rowAsientoMovimientoDif1("NroLinea") = 1
                        dt_AM.Rows.Add(rowAsientoMovimientoDif1)

                        Dim rowAsMov_MovDoc As Data.DataRow
                        rowAsMov_MovDoc = dt_AMMDOC.NewRow
                        rowAsMov_MovDoc("Id") = lsPrefijoAsientoMov_MovDoc + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMov_MovDoc, 9)
                        rowAsMov_MovDoc("IdMovimientoDocumento") = obj.Id
                        rowAsMov_MovDoc("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                        rowAsMov_MovDoc("Activo") = True
                        rowAsMov_MovDoc("IdCuentaxCyP") = DBNull.Value
                        dt_AMMDOC.Rows.Add(rowAsMov_MovDoc)
                        lsNumeroAsientoMovimiento = lsNumeroAsientoMovimiento + 1

                        Dim rowAsientoMovimientoDif2 As Data.DataRow
                        rowAsientoMovimientoDif2 = dt_AM.NewRow
                        rowAsientoMovimientoDif2("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                        rowAsientoMovimientoDif2("IdAsiento") = lsPrefijoAsiento.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rowAsientoMovimientoDif2("IdCuentaContable") = IIf(HaberMN > DebeMN, leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_GANANCIA")(0).Texto2, leCuentasGenerales.Where(Function(i) i.Nombre = "CTA_PERDIDAS")(0).Texto2)
                        rowAsientoMovimientoDif2("Glosa") = glosaajuste
                        rowAsientoMovimientoDif2("DebeMN") = IIf(DebeMN > HaberMN, Math.Abs(DebeMN - HaberMN), 0.0)
                        rowAsientoMovimientoDif2("HaberMN") = IIf(HaberMN > DebeMN, Math.Abs(HaberMN - DebeMN), 0.0)
                        rowAsientoMovimientoDif2("DebeME") = 0.0
                        rowAsientoMovimientoDif2("HaberME") = 0.0
                        rowAsientoMovimientoDif2("IdUsuarioCrea") = idUsuario
                        rowAsientoMovimientoDif2("FechaCreacion") = Date.Now()
                        rowAsientoMovimientoDif2("Activo") = True
                        rowAsientoMovimientoDif2("NroLinea") = 2
                        dt_AM.Rows.Add(rowAsientoMovimientoDif2)

                        If DebeMN > HaberMN Then 'CASO PÉRDIDA
                            Dim rowMovAna As Data.DataRow
                            rowMovAna = dt_MA.NewRow
                            rowMovAna("Id") = lsPrefijoMovAna & olFuncionesGenerales.CompletaConCeros(lsNumeroMovAna.ToString, 13)
                            rowMovAna("IdCentroCosto") = DBNull.Value
                            rowMovAna("IdItemGasto") = DBNull.Value
                            rowMovAna("IdTrabajador") = DBNull.Value
                            rowMovAna("IdVehiculo") = ""
                            rowMovAna("IdRuta") = DBNull.Value
                            rowMovAna("IdBanco") = DBNull.Value
                            rowMovAna("IdAnalisis1") = DBNull.Value
                            rowMovAna("IdAnalisis2") = DBNull.Value
                            rowMovAna("Activo") = 1
                            rowMovAna("IdAsientoMovimiento") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroAsientoMovimiento.ToString, 13)
                            rowMovAna("Monto") = Math.Abs(DebeMN - HaberMN)
                            rowMovAna("Saldo") = Math.Abs(DebeMN - HaberMN)
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

                oeMovCajaBanco.Id = IdMovimientoCajaBanco
                odAsiento.GuardarCobranzaPago(dt_A, dt_AM, dt_MCB, dt_AMMDOC, dt_CTAXCYP, dt_MA, leMovDocAgregado, oeMovCajaBanco)
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarPago(ByVal cadena As String, ByVal leDocumentosAgregados As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoDocumento), ByVal fecha As Date, ByVal Opcion As String) As Object Implements Il_Asiento.ValidarPago
        Try
            Dim loFuncionesGenerales As New l_FuncionesGenerales
            loFuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, fecha, fecha.Year.ToString + "-" + fecha.Month.ToString)

            Dim ListaValida As New List(Of e_MovimientoDocumento)
            Dim oeMD As New e_MovimientoDocumento
            Dim olMD As New l_MovimientoDocumento
            oeMD.TipoOperacion = "SAL"
            oeMD.Activo = True
            oeMD.Documentos = cadena
            ListaValida = olMD.Listar(oeMD)

            For Each obj In leDocumentosAgregados
                Dim doc As Double = obj.Saldo
                Dim actual As Double = ListaValida.Where(Function(i) i.Id = obj.Id)(0).Saldo
                If doc - actual > 0.1 Or doc - actual < -0.1 Then
                    Throw New Exception("Los saldos ya cambiaron para el documento:" & obj.Serie & "-" & obj.Numero & " a cambiado a: " & ListaValida.Where(Function(i) i.Id = obj.Id)(0).Saldo.ToString)
                End If
                If obj.MontoOperar > (actual + 0.01) Then
                    Throw New Exception("El monto a operar es mayor que el saldo actual")
                End If
                If Opcion = "GAN" Then
                    If obj.MontoOperar > 100.0 Then Throw New Exception("No se puede enviar a ganacia mas de 100.00 Doc." + obj.Serie + obj.Numero)
                End If
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function PagoBono(leMovDoc As List(Of e_MovimientoDocumento), oeAsiMod As e_AsientoModelo, oeSaldoCta As e_SaldoCtaCorriente) As Boolean Implements Il_Asiento.PagoBono
        Try
            Using TransScope As New TransactionScope()
                If olFuncionesGenerales.ValidarPeriodo(oeAsiMod.IdPeriodo, gAreasSGI.Tesoreria) Then
                    Dim _leAsiento As New List(Of e_Asiento), _oeAsiento As New e_Asiento, _oeAsientoMov As New e_AsientoMovimiento
                    Dim _MontoAsiento = leMovDoc.Sum(Function(it) it.MontoOperar)
                    With _oeAsiento
                        .TipoOperacion = "I" : .IdPeriodo = oeAsiMod.IdPeriodo : .IdTipoAsiento = oeAsiMod.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = oeAsiMod.FechaMov
                        .Glosa = oeAsiMod.Nombre
                        .GlosaImprime = String.Empty
                        .IdMoneda = oeAsiMod.IdMoneda : .TipoCambio = oeAsiMod.TipoCambio : .TotalDebe = _MontoAsiento : .TotalHaber = _MontoAsiento
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeAsiMod.UsuarioCreacion : .Activo = True
                        .IdentificaAsiento = oeAsiMod.Id
                    End With
                    For Each oeAux In oeAsiMod.leDetalle.OrderBy(Function(it) it.Fila).ToList
                        If oeAux.Repetir = 0 Then
                            _oeAsientoMov = New e_AsientoMovimiento
                            With _oeAsientoMov
                                .TipoOperacion = "I" : .IdCuentaContable = oeAux.IdCuentaContable : .IdUsuarioCrea = oeAsiMod.UsuarioCreacion
                                .Glosa = oeAsiMod.Nombre
                                .Activo = True
                                .DebeMN = 0 : .DebeME = 0
                                .HaberMN = IIf(oeAsiMod.Moneda = "SOLES", _MontoAsiento, _MontoAsiento * oeAsiMod.TipoCambio)
                                .HaberME = IIf(oeAsiMod.Moneda = "SOLES", _MontoAsiento / oeAsiMod.TipoCambio, _MontoAsiento)
                                ' Movimiento Caja Banco
                                .IndMovCajaBanco = True
                                .MovimientoCajaBanco = New e_MovimientoCajaBanco
                                .MovimientoCajaBanco.TipoOperacion = "I"
                                .MovimientoCajaBanco.UsuarioCreacion = oeAsiMod.UsuarioCreacion
                                .MovimientoCajaBanco.IdFlujoCaja = "1CH000000168"
                                .MovimientoCajaBanco.NroBoucher = "0000000000"
                                .MovimientoCajaBanco.IdCuentaBancaria = String.Empty
                                .MovimientoCajaBanco.Fecha = oeAsiMod.FechaMov
                                .MovimientoCajaBanco.IdMedioPago = "1CH03"
                                .MovimientoCajaBanco.IdPeriodoConcilia = String.Empty
                                .MovimientoDocumento.Activo = True
                                .MovimientoCajaBanco.TipoCambio = oeAsiMod.TipoCambio
                                .MovimientoCajaBanco.TotalMN = .HaberMN
                                .MovimientoCajaBanco.TotalME = .HaberME
                                .MovimientoCajaBanco._Operador = -1
                                .MovimientoCajaBanco.IdTipoGasto = String.Empty
                            End With
                            _oeAsiento.AsientoMovimiento.Add(_oeAsientoMov)
                        Else
                            For Each oeMovDoc In leMovDoc
                                _oeAsientoMov = New e_AsientoMovimiento
                                With _oeAsientoMov
                                    .TipoOperacion = "I" : .IdCuentaContable = oeMovDoc.IdCtaPagarCobrar : .IdUsuarioCrea = oeAsiMod.UsuarioCreacion
                                    .Glosa = "PAGO " & oeMovDoc._AbrevTipoDoc & "/" & oeMovDoc.Serie & oeMovDoc.Numero & " " & oeMovDoc.NombreProveedor
                                    .Activo = True
                                    .DebeMN = IIf(oeAsiMod.Moneda = "SOLES", oeMovDoc.MontoOperar, oeMovDoc.MontoOperar * oeAsiMod.TipoCambio)
                                    .DebeME = IIf(oeAsiMod.Moneda = "SOLES", oeMovDoc.MontoOperar / oeAsiMod.TipoCambio, oeMovDoc.MontoOperar)
                                    .HaberMN = 0 : .HaberME = 0
                                    ' Asiento Movimiento Documento
                                    .IndDocumento = True
                                    .AsMov_MovDoc = New e_AsientoMov_MovDoc
                                    .AsMov_MovDoc.TipoOperacion = "I" : _oeAsientoMov.AsMov_MovDoc.Activo = True
                                    .AsMov_MovDoc.IdMovimientoDocumento = oeMovDoc.Id
                                    .AsMov_MovDoc.IdCuentaxCyP = String.Empty
                                    .AsMov_MovDoc.IdAsientoMovimiento = String.Empty
                                    ' Cuenta por Cobrar y Pagar
                                    .IndPagoCobro = True
                                    .oeCuentaCP = New e_CuentaxCyP
                                    .oeCuentaCP.TipoOperacion = "I" : _oeAsientoMov.oeCuentaCP.Activo = True
                                    .oeCuentaCP.IdMovimientoCajaBanco = String.Empty
                                    .oeCuentaCP.IdMovimientoDocumento = oeMovDoc.Id
                                    .oeCuentaCP.Fecha = oeAsiMod.FechaMov
                                    .oeCuentaCP.MontoMN = .DebeMN
                                    .oeCuentaCP.MontoMe = .DebeME
                                    .oeCuentaCP.UsuarioCreacion = oeAsiMod.UsuarioCreacion
                                End With
                                _oeAsiento.AsientoMovimiento.Add(_oeAsientoMov)
                            Next
                        End If
                    Next
                    _leAsiento.Add(_oeAsiento)
                    If GuardarListaMasiva3(_leAsiento, oeSaldoCta.PrefijoID) Then
                        oeSaldoCta.IdReferencia = _IdAsientoRef
                        If odSaldoCtaCte.PagoBono(oeSaldoCta) Then
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

#End Region

#Region "Glosas, Identificadores y Validaciones de Asientos"

    Public Function ObtenerOrigenContable(ByVal Tipo As String, ByVal IdMovDoc As String) As Integer Implements Il_Asiento.ObtenerOrigenContable
        Try
            Return odAsiento.ObtenerOrigenContable(Tipo, IdMovDoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Porrrateos , Extornos"

    Public Function GuardarProrrateoCompra(ByVal leListaOrigen As System.Collections.Generic.List(Of EntidadesWCF.e_Vehiculo), ByVal leListaDestino As System.Collections.Generic.List(Of EntidadesWCF.e_Vehiculo), ByVal oeAsiento As EntidadesWCF.e_Asiento) As Boolean Implements Il_Asiento.GuardarProrrateoCompra
        Try
            Dim cadena As String = ""
            For i = 0 To leListaOrigen.Count() - 1
                If i = 0 Then
                    cadena &= "'" & leListaOrigen(0).Id & "'"
                ElseIf i > 0 Then
                    cadena &= ",'" & leListaOrigen(i).Id & "'"
                End If
            Next
            If leListaOrigen.Where(Function(i) i.Id = "1CH000000415").Count > 0 Then
                cadena = cadena + ",''"
            End If

            Dim oe_MovimientoAnalisis As New e_MovimientoAnalisis
            Dim le_MovimientoAnalisis As New List(Of e_MovimientoAnalisis)
            Dim olMovimientoAnalisis As New l_MovimientoAnalisis
            Dim odMovimientoAnalisis As New d_MovimientoAnalisis

            oe_MovimientoAnalisis.TipoOperacion = "C"
            oe_MovimientoAnalisis.Activo = True
            oe_MovimientoAnalisis.IdPeriodo = oeAsiento.IdPeriodo
            oe_MovimientoAnalisis._ListaV = cadena
            le_MovimientoAnalisis = olMovimientoAnalisis.Listar(oe_MovimientoAnalisis)

            Dim Id As String = odMovimientoAnalisis.UltimoIdInsertaProrrateo()
            Dim lsPrefijo As String = Left(Id, 3)
            Dim lsNumero As Integer = CInt(Right(Id, Len(Id) - 3))
            Dim dt_MA As Data.DataTable = olMovimientoAnalisis.CrearDT
            Dim cantidadplaca As Integer = leListaDestino.Count()

            For Each obj In le_MovimientoAnalisis
                For Each oo In leListaDestino
                    Dim rowDetalle As Data.DataRow
                    rowDetalle = dt_MA.NewRow
                    rowDetalle("Id") = lsPrefijo & olFuncionesGenerales.CompletaConCeros(lsNumero.ToString, 13)
                    rowDetalle("IdCentroCosto") = obj.IdCentroCosto
                    rowDetalle("IdItemGasto") = obj.IdItemGasto
                    rowDetalle("IdTrabajador") = obj.IdTrabajador
                    rowDetalle("IdVehiculo") = oo.Id
                    rowDetalle("IdRuta") = obj.IdRuta
                    rowDetalle("IdBanco") = obj.IdBanco
                    rowDetalle("IdAnalisis1") = obj.IdAnalisis1
                    rowDetalle("IdAnalisis2") = obj.IdAnalisis2
                    rowDetalle("Activo") = 1
                    rowDetalle("IdAsientoMovimiento") = obj.IdAsientoMovimiento
                    rowDetalle("Monto") = Math.Round(obj.Monto / cantidadplaca, 3)
                    rowDetalle("Saldo") = Math.Round(obj.Saldo / cantidadplaca, 3)
                    rowDetalle("IdMovimientoAnalisis") = ""
                    rowDetalle("IdGastoFuncion") = obj.IdGastoFuncion
                    rowDetalle("IdOrigenProrrateo") = obj.Id
                    dt_MA.Rows.Add(rowDetalle)
                    lsNumero = lsNumero + 1
                Next
            Next
            odMovimientoAnalisis.GuardarProrrateo(le_MovimientoAnalisis, dt_MA)
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function GuardarProrrateoVenta(ByVal leListaOrigen As System.Collections.Generic.List(Of EntidadesWCF.e_Vehiculo), ByVal leListaDestino As System.Collections.Generic.List(Of EntidadesWCF.e_Vehiculo), ByVal oeAsiento As EntidadesWCF.e_Asiento) As Boolean Implements Il_Asiento.GuardarProrrateoVenta
        Try
            Dim cadena As String = ""
            For i = 0 To leListaOrigen.Count() - 1
                If i = 0 Then
                    cadena &= "'" & leListaOrigen(0).Id & "'"
                ElseIf i > 0 Then
                    cadena &= ",'" & leListaOrigen(i).Id & "'"
                End If
            Next
            If leListaOrigen.Where(Function(i) i.Id = "1CH000000415").Count > 0 Then
                cadena = cadena + ",''"
            End If

            Dim oe_MovimientoAnalisis As New e_MovimientoAnalisis
            Dim le_MovimientoAnalisis As New List(Of e_MovimientoAnalisis)
            Dim olMovimientoAnalisis As New l_MovimientoAnalisis
            Dim odMovimientoAnalisis As New d_MovimientoAnalisis

            oe_MovimientoAnalisis.TipoOperacion = "V"
            oe_MovimientoAnalisis.Activo = True
            oe_MovimientoAnalisis.IdPeriodo = oeAsiento.IdPeriodo
            oe_MovimientoAnalisis._ListaV = cadena
            le_MovimientoAnalisis = olMovimientoAnalisis.Listar(oe_MovimientoAnalisis)

            Dim Id As String = odMovimientoAnalisis.UltimoIdInsertaProrrateo()
            Dim lsPrefijo As String = Left(Id, 3)
            Dim lsNumero As Integer = CInt(Right(Id, Len(Id) - 3))
            Dim dt_MA As Data.DataTable = olMovimientoAnalisis.CrearDT
            Dim cantidadplaca As Integer = leListaDestino.Count()

            For Each obj In le_MovimientoAnalisis
                For Each oo In leListaDestino
                    Dim rowDetalle As Data.DataRow
                    rowDetalle = dt_MA.NewRow
                    rowDetalle("Id") = lsPrefijo & olFuncionesGenerales.CompletaConCeros(lsNumero.ToString, 13)
                    rowDetalle("IdCentroCosto") = obj.IdCentroCosto
                    rowDetalle("IdItemGasto") = obj.IdItemGasto
                    rowDetalle("IdTrabajador") = obj.IdTrabajador
                    rowDetalle("IdVehiculo") = oo.Id
                    rowDetalle("IdRuta") = obj.IdRuta
                    rowDetalle("IdBanco") = obj.IdBanco
                    rowDetalle("IdAnalisis1") = obj.IdAnalisis1
                    rowDetalle("IdAnalisis2") = obj.IdAnalisis2
                    rowDetalle("Activo") = 1
                    rowDetalle("IdAsientoMovimiento") = obj.IdAsientoMovimiento
                    rowDetalle("Monto") = Math.Round(obj.Monto / cantidadplaca, 3)
                    rowDetalle("Saldo") = Math.Round(obj.Saldo / cantidadplaca, 3)
                    rowDetalle("IdMovimientoAnalisis") = ""
                    rowDetalle("IdGastoFuncion") = obj.IdGastoFuncion
                    rowDetalle("IdOrigenProrrateo") = obj.Id
                    dt_MA.Rows.Add(rowDetalle)
                    lsNumero = lsNumero + 1
                Next
            Next
            odMovimientoAnalisis.GuardarProrrateo(le_MovimientoAnalisis, dt_MA)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ExtornarAsiento(ByVal oeAsiento As EntidadesWCF.e_Asiento) As Boolean Implements Il_Asiento.ExtornarAsiento
        Try
            Return odAsiento.ExtornarAsiento(oeAsiento)
        Catch ex As Exception
            Throw
        End Try
    End Function



#End Region

#Region "Descuentos a Personal"

    ''' <summary>
    ''' Guadar Asiento para Reembolso de Descuento por Caja y Otras Areas
    ''' </summary>
    ''' <param name="oeAsiento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GuardarAsientoDscto(oeAsiento As e_Asiento, Optional oeAsientoAnticipo As e_Asiento = Nothing) As Boolean Implements Il_Asiento.GuardarAsientoDscto
        Try
            Dim olMovAnalisis As New l_MovimientoAnalisis, odMovAnalisis As New d_MovimientoAnalisis
            Dim Id As String = "", lsPrefijo As String = "", lsNumero As Integer = 0
            Id = odMovimientoAnalisis.UltimoIdInserta(oeAsiento.PrefijoID) : lsPrefijo = Left(Id, 3) : lsNumero = CInt(Right(Id, Len(Id) - 3))
            For Each oeAsiMov In oeAsiento.AsientoMovimiento
                oeAsiMov.PrefijoID = oeAsiento.PrefijoID '@0001
                If oeAsiMov.MovimientoAnalisis.Count > 0 Then
                    Dim dtMovAna As Data.DataTable = olMovimientoAnalisis.CrearDT
                    For Each oeMovAna In oeAsiMov.MovimientoAnalisis
                        oeMovAna.PrefijoID = oeAsiento.PrefijoID '@0001
                        Dim rowMovAna As Data.DataRow
                        rowMovAna = dtMovAna.NewRow
                        rowMovAna("Id") = lsPrefijo & olFuncionesGenerales.CompletaConCeros(lsNumero.ToString, 13)
                        rowMovAna("IdCentroCosto") = oeMovAna.IdCentroCosto
                        rowMovAna("IdItemGasto") = oeMovAna.IdItemGasto
                        rowMovAna("IdTrabajador") = oeMovAna.IdTrabajador
                        rowMovAna("IdVehiculo") = oeMovAna.IdVehiculo
                        rowMovAna("IdRuta") = oeMovAna.IdRuta
                        rowMovAna("IdBanco") = oeMovAna.IdBanco
                        rowMovAna("IdAnalisis1") = oeMovAna.IdAnalisis1
                        rowMovAna("IdAnalisis2") = oeMovAna.IdAnalisis2
                        rowMovAna("Activo") = 1
                        rowMovAna("IdAsientoMovimiento") = String.Empty
                        rowMovAna("Monto") = oeMovAna.Monto
                        rowMovAna("Saldo") = oeMovAna.Saldo
                        rowMovAna("IdMovimientoAnalisis") = String.Empty
                        rowMovAna("IdGastoFuncion") = oeMovAna.IdGastoFuncion
                        rowMovAna("IdOrigenProrrateo") = String.Empty
                        dtMovAna.Rows.Add(rowMovAna)
                        lsNumero = lsNumero + 1
                    Next
                    oeAsiMov.DataTableAnalisis = dtMovAna
                End If
            Next
            oeAsientoAnticipo.PrefijoID = oeAsiento.PrefijoID '@0001
            Return odAsiento.GuardarAsientoDscto(oeAsiento, oeAsientoAnticipo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(loAsiento As List(Of e_Asiento)) As Boolean Implements Il_Asiento.GuardarLista
        Try
            'For Each asiento As e_Asiento In loAsiento.Where(Function(it) it.IdMoneda = "1CH01").ToList
            For Each asiento As e_Asiento In loAsiento
                GuardarAsientoDscto(asiento)
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarListaMasiva(loAsiento As List(Of e_Asiento), ByVal PrefijoID As String) As Boolean Implements Il_Asiento.GuardarListaMasiva
        Try
            Dim IdAsiento As String = odAsiento.UltimoIdInserta(PrefijoID)
            Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
            Dim lsNumeroAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))

            Dim NroAsiento As String = odAsiento.UltimoNroAsiento(loAsiento(0).IdTipoAsiento, loAsiento(0).IdPeriodo, "1", PrefijoID)
            Dim lsPrefijoNroAsiento As String = Left(NroAsiento, 2)
            Dim lsNumeroNroAsiento As Integer = CInt(Right(NroAsiento, Len(NroAsiento) - 2))

            Dim idAsiMov As String = odAsientoMovimiento.UltimoIdInserta(PrefijoID)
            Dim lsPrefijoAsiMov As String = Left(idAsiMov, 3)
            Dim lsNumeroAsiMov As Integer = CInt(Right(idAsiMov, Len(idAsiMov) - 3))

            Dim fil As Integer = 0

            Dim idAsiMovDoc As String = odAsMovMovDoc.UltimoIdInserta(PrefijoID)
            Dim lsPrefijoAsiMovDoc As String = Left(idAsiMovDoc, 3)
            Dim lsNumeroAsiMovDoc As Integer = CInt(Right(idAsiMovDoc, Len(idAsiMovDoc) - 3))

            Dim idAsiMovObli As String = odAsiMovOblFin.UltimoIdInserta(PrefijoID)
            Dim lsPrefijoAsiMovObli As String = Left(idAsiMovObli, 3)
            Dim lsNumeroAsiMovObli As Integer = CInt(Right(idAsiMovObli, Len(idAsiMovObli) - 3))

            Dim dtAsiento As Data.DataTable = CrearDT()
            Dim dtAsiMov As Data.DataTable = olAsientoMovimiento.CrearDT
            Dim dtAsiMovDoc As Data.DataTable = olAsientoMov_MovDoc.CrearDT
            Dim dtAsiMovObli As Data.DataTable = olAsiMovOblFin.CrearDT

            For Each oeAsi In loAsiento
                fil = 0
                Dim rwAsiento As Data.DataRow
                rwAsiento = dtAsiento.NewRow
                rwAsiento("Id") = lsPrefijoAsiento.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rwAsiento("IdPeriodo") = oeAsi.IdPeriodo
                rwAsiento("IdTipoAsiento") = oeAsi.IdTipoAsiento
                rwAsiento("NroAsiento") = lsPrefijoNroAsiento & olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsiento, 7).ToString
                rwAsiento("Fecha") = oeAsi.Fecha
                rwAsiento("Glosa") = oeAsi.Glosa
                rwAsiento("GlosaImprime") = oeAsi.Glosa
                rwAsiento("IdMoneda") = oeAsi.IdMoneda
                rwAsiento("TipoCambio") = oeAsi.TipoCambio
                rwAsiento("TotalDebe") = oeAsi.TotalDebe
                rwAsiento("TotalHaber") = oeAsi.TotalHaber
                rwAsiento("IdUsuarioBloquea") = ""
                rwAsiento("UsuarioCreacion") = oeAsi.IdUsuarioCrea
                rwAsiento("IdEstado") = "1CH00005"
                rwAsiento("IdAsientoExtorno") = ""
                rwAsiento("FechaCreacion") = Date.Now()
                rwAsiento("Activo") = True
                rwAsiento("NroAsientoImprime") = DBNull.Value
                rwAsiento("IdentificaAsiento") = ""
                rwAsiento("IndRevision") = DBNull.Value
                rwAsiento("FechaRevision") = DBNull.Value
                rwAsiento("UsuarioRevision") = DBNull.Value
                rwAsiento("IndOrigen") = 0
                rwAsiento("UsuarioModificacion") = DBNull.Value
                rwAsiento("FechaModificacion") = DBNull.Value
                dtAsiento.Rows.Add(rwAsiento)
                For Each oeAsiMov In oeAsi.AsientoMovimiento
                    Dim rwAM As Data.DataRow
                    rwAM = dtAsiMov.NewRow
                    fil = fil + 1
                    With oeAsiMov
                        rwAM("Id") = lsPrefijoAsiMov & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMov.ToString, Len(idAsiMov) - 3)
                        rwAM("IdAsiento") = lsPrefijoAsiento.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rwAM("IdCuentaContable") = .IdCuentaContable
                        rwAM("Glosa") = .Glosa.Trim
                        rwAM("DebeMN") = .DebeMN
                        rwAM("HaberMN") = .HaberMN
                        rwAM("DebeME") = .DebeME
                        rwAM("HaberME") = .HaberME
                        rwAM("IdUsuarioCrea") = .IdUsuarioCrea.Trim
                        rwAM("FechaCreacion") = Date.Now()
                        rwAM("Activo") = True
                        rwAM("NroLinea") = fil
                        'rwAM("CodigoUnicoOperacion") = String.Empty
                        If .AsMov_MovDoc.TipoOperacion = "I" Then
                            Dim rwAMD As Data.DataRow
                            rwAMD = dtAsiMovDoc.NewRow
                            rwAMD("Id") = lsPrefijoAsiMovDoc & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMovDoc.ToString, Len(idAsiMovDoc) - 3)
                            rwAMD("IdMovimientoDocumento") = .AsMov_MovDoc.IdMovimientoDocumento
                            rwAMD("IdAsientoMovimiento") = lsPrefijoAsiMov & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMov.ToString, Len(idAsiMov) - 3)
                            rwAMD("Activo") = True
                            rwAMD("IdCuentaxCyP") = DBNull.Value
                            rwAMD("UsuarioCreacion") = .IdUsuarioCrea
                            rwAMD("FechaCreacion") = Date.Now()
                            dtAsiMovDoc.Rows.Add(rwAMD)
                            lsNumeroAsiMovDoc = lsNumeroAsiMovDoc + 1
                        End If
                        If .AsMov_ObligacionFin.TipoOperacion = "I" Then
                            Dim rwAOF As Data.DataRow
                            rwAOF = dtAsiMovObli.NewRow
                            rwAOF("Id") = lsPrefijoAsiMovObli & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMovObli.ToString, Len(idAsiMovObli) - 3)
                            rwAOF("IdAsientoMovimiento") = lsPrefijoAsiMov & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMov.ToString, Len(idAsiMov) - 3)
                            rwAOF("IdObligacionFinanciera") = .AsMov_ObligacionFin.IdObligacionFinanciera
                            rwAOF("IdObligacionPago") = DBNull.Value
                            rwAOF("Activo") = True
                            rwAOF("FechaCreacion") = Date.Now()
                            rwAOF("UsuarioCreacion") = .IdUsuarioCrea
                            dtAsiMovObli.Rows.Add(rwAOF)
                            lsNumeroAsiMovObli = lsNumeroAsiMovObli + 1
                        End If
                    End With
                    dtAsiMov.Rows.Add(rwAM)
                    lsNumeroAsiMov = lsNumeroAsiMov + 1
                Next
                lsNumeroAsiento = lsNumeroAsiento + 1
                lsNumeroNroAsiento = lsNumeroNroAsiento + 1
            Next
            Return odAsiento.GuardarAsientoMasivo5(dtAsiento, dtAsiMov, dtAsiMovDoc, dtAsiMovObli)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarListaMasiva2(loAsiento As List(Of e_Asiento), ByVal PrefijoID As String) As Boolean Implements Il_Asiento.GuardarListaMasiva2
        Try
            Dim IdAsiento As String = odAsiento.UltimoIdInserta(PrefijoID)
            Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
            Dim lsNumeroAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))

            Dim NroAsiento As String = odAsiento.UltimoNroAsiento(loAsiento(0).IdTipoAsiento, loAsiento(0).IdPeriodo, "1", PrefijoID)
            Dim lsPrefijoNroAsiento As String = Left(NroAsiento, 2)
            Dim lsNumeroNroAsiento As Integer = CInt(Right(NroAsiento, Len(NroAsiento) - 2))

            Dim idAsiMov As String = odAsientoMovimiento.UltimoIdInserta(PrefijoID)
            Dim lsPrefijoAsiMov As String = Left(idAsiMov, 3)
            Dim lsNumeroAsiMov As Integer = CInt(Right(idAsiMov, Len(idAsiMov) - 3))

            Dim fil As Integer = 0

            Dim idAsiMovOF As String = odAsiMovOblFin.UltimoIdInserta(PrefijoID)
            Dim lsPrefijoAsiMovOF As String = Left(idAsiMovOF, 3)
            Dim lsNumeroAsiMovOF As Integer = CInt(Right(idAsiMovOF, Len(idAsiMovOF) - 3))

            Dim dtAsiento As Data.DataTable = CrearDT()
            Dim dtAsiMov As Data.DataTable = olAsientoMovimiento.CrearDT
            Dim dtAsiMovOF As Data.DataTable = olAsiMovOblFin.CrearDT

            For Each oeAsi In loAsiento
                fil = 0

                Dim rwAsiento As Data.DataRow
                rwAsiento = dtAsiento.NewRow
                rwAsiento("Id") = lsPrefijoAsiento.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rwAsiento("IdPeriodo") = oeAsi.IdPeriodo
                rwAsiento("IdTipoAsiento") = oeAsi.IdTipoAsiento
                rwAsiento("NroAsiento") = lsPrefijoNroAsiento & olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsiento, 7).ToString
                rwAsiento("Fecha") = oeAsi.Fecha
                rwAsiento("Glosa") = oeAsi.Glosa
                rwAsiento("GlosaImprime") = oeAsi.Glosa
                rwAsiento("IdMoneda") = oeAsi.IdMoneda
                rwAsiento("TipoCambio") = oeAsi.TipoCambio
                rwAsiento("TotalDebe") = oeAsi.TotalDebe
                rwAsiento("TotalHaber") = oeAsi.TotalHaber
                rwAsiento("IdUsuarioBloquea") = ""
                rwAsiento("UsuarioCreacion") = oeAsi.IdUsuarioCrea
                rwAsiento("IdEstado") = "1CH00005"
                rwAsiento("IdAsientoExtorno") = ""
                rwAsiento("FechaCreacion") = Date.Now()
                rwAsiento("Activo") = True
                rwAsiento("NroAsientoImprime") = DBNull.Value
                rwAsiento("IdentificaAsiento") = ""
                rwAsiento("IndRevision") = DBNull.Value
                rwAsiento("FechaRevision") = DBNull.Value
                rwAsiento("UsuarioRevision") = DBNull.Value
                rwAsiento("IndOrigen") = 0
                rwAsiento("UsuarioModificacion") = DBNull.Value
                rwAsiento("FechaModificacion") = DBNull.Value
                dtAsiento.Rows.Add(rwAsiento)
                For Each oeAsiMov In oeAsi.AsientoMovimiento
                    Dim rwAM As Data.DataRow
                    rwAM = dtAsiMov.NewRow
                    fil = fil + 1
                    With oeAsiMov
                        rwAM("Id") = lsPrefijoAsiMov & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMov.ToString, Len(idAsiMov) - 3)
                        rwAM("IdAsiento") = lsPrefijoAsiento.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rwAM("IdCuentaContable") = .IdCuentaContable
                        rwAM("Glosa") = .Glosa.Trim
                        rwAM("DebeMN") = .DebeMN
                        rwAM("HaberMN") = .HaberMN
                        rwAM("DebeME") = .DebeME
                        rwAM("HaberME") = .HaberME
                        rwAM("IdUsuarioCrea") = .IdUsuarioCrea.Trim
                        rwAM("FechaCreacion") = Date.Now()
                        rwAM("Activo") = True
                        rwAM("NroLinea") = fil
                        If .AsMov_ObligacionFin.TipoOperacion = "I" Then
                            Dim rwAMOF As Data.DataRow
                            rwAMOF = dtAsiMovOF.NewRow
                            rwAMOF("Id") = lsPrefijoAsiMovOF & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMovOF.ToString, Len(idAsiMovOF) - 3)
                            rwAMOF("IdAsientoMovimiento") = lsPrefijoAsiMov & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMov.ToString, Len(idAsiMov) - 3)
                            rwAMOF("IdObligacionFinanciera") = .AsMov_ObligacionFin.IdObligacionFinanciera
                            rwAMOF("IdObligacionPago") = String.Empty
                            rwAMOF("Activo") = True
                            rwAMOF("FechaCreacion") = Date.Now()
                            rwAMOF("UsuarioCreacion") = .IdUsuarioCrea
                            dtAsiMovOF.Rows.Add(rwAMOF)
                            lsNumeroAsiMovOF = lsNumeroAsiMovOF + 1
                        End If
                    End With
                    dtAsiMov.Rows.Add(rwAM)
                    lsNumeroAsiMov = lsNumeroAsiMov + 1
                Next
                lsNumeroAsiento = lsNumeroAsiento + 1
                lsNumeroNroAsiento = lsNumeroNroAsiento + 1
            Next
            Return odAsiento.GuardarAsientoMasivo2(dtAsiento, dtAsiMov, dtAsiMovOF)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarListaMasiva3(loAsiento As List(Of e_Asiento), ByVal PrefijoId As String) As Boolean Implements Il_Asiento.GuardarListaMasiva3
        Try
            Dim IdAsiento As String = odAsiento.UltimoIdInserta(PrefijoId)
            Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
            Dim lsNumeroAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))

            Dim NroAsiento As String = odAsiento.UltimoNroAsiento(loAsiento(0).IdTipoAsiento, loAsiento(0).IdPeriodo, "1", PrefijoId)
            Dim lsPrefijoNroAsiento As String = Left(NroAsiento, 2)
            Dim lsNumeroNroAsiento As Integer = CInt(Right(NroAsiento, Len(NroAsiento) - 2))

            Dim idAsiMov As String = odAsientoMovimiento.UltimoIdInserta(PrefijoId)
            Dim lsPrefijoAsiMov As String = Left(idAsiMov, 3)
            Dim lsNumeroAsiMov As Integer = CInt(Right(idAsiMov, Len(idAsiMov) - 3))

            Dim idCPC As String = odCuentaxCyP.UltimoIdInserta(PrefijoId)
            Dim lsPrefijoCPC As String = Left(idCPC, 3)
            Dim lsNumeroCPC As Integer = CInt(Right(idCPC, Len(idCPC) - 3))

            Dim idMCB As String = odMovCajaBanco.UltimoIdInserta(PrefijoId)
            Dim lsPrefijoMCB As String = Left(idMCB, 3)
            Dim lsNumeroMCB As Integer = CInt(Right(idMCB, Len(idMCB) - 3))

            Dim fil As Integer = 0

            Dim idAsiMovDoc As String = odAsMovMovDoc.UltimoIdInserta(PrefijoId)
            Dim lsPrefijoAsiMovDoc As String = Left(idAsiMovDoc, 3)
            Dim lsNumeroAsiMovDoc As Integer = CInt(Right(idAsiMovDoc, Len(idAsiMovDoc) - 3))

            Dim dtAsiento As Data.DataTable = CrearDT()
            Dim dtAsiMov As Data.DataTable = olAsientoMovimiento.CrearDT
            Dim dtAsiMovDoc As Data.DataTable = olAsientoMov_MovDoc.CrearDT
            Dim dtCPC As Data.DataTable = olCuentaxCyP.CrearDT
            Dim dtMCB As Data.DataTable = olMovCajaBanco.CrearDT

            For Each oeAsi In loAsiento
                fil = 0
                Dim rwAsiento As Data.DataRow
                rwAsiento = dtAsiento.NewRow
                _IdAsientoRef = lsPrefijoAsiento.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rwAsiento("Id") = lsPrefijoAsiento.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rwAsiento("IdPeriodo") = oeAsi.IdPeriodo
                rwAsiento("IdTipoAsiento") = oeAsi.IdTipoAsiento
                rwAsiento("NroAsiento") = lsPrefijoNroAsiento & olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsiento, 7).ToString
                rwAsiento("Fecha") = oeAsi.Fecha
                rwAsiento("Glosa") = oeAsi.Glosa
                rwAsiento("GlosaImprime") = oeAsi.Glosa
                rwAsiento("IdMoneda") = oeAsi.IdMoneda
                rwAsiento("TipoCambio") = oeAsi.TipoCambio
                rwAsiento("TotalDebe") = oeAsi.TotalDebe
                rwAsiento("TotalHaber") = oeAsi.TotalHaber
                rwAsiento("IdUsuarioBloquea") = ""
                rwAsiento("UsuarioCreacion") = oeAsi.IdUsuarioCrea
                rwAsiento("IdEstado") = "1CH00005"
                rwAsiento("IdAsientoExtorno") = ""
                rwAsiento("FechaCreacion") = Date.Now()
                rwAsiento("Activo") = True
                rwAsiento("NroAsientoImprime") = DBNull.Value
                rwAsiento("IdentificaAsiento") = ""
                rwAsiento("IndRevision") = DBNull.Value
                rwAsiento("FechaRevision") = DBNull.Value
                rwAsiento("UsuarioRevision") = DBNull.Value
                rwAsiento("IndOrigen") = 0
                rwAsiento("UsuarioModificacion") = DBNull.Value
                rwAsiento("FechaModificacion") = DBNull.Value
                dtAsiento.Rows.Add(rwAsiento)
                For Each oeAsiMov In oeAsi.AsientoMovimiento
                    Dim rwAM As Data.DataRow
                    rwAM = dtAsiMov.NewRow
                    fil = fil + 1
                    With oeAsiMov
                        rwAM("Id") = lsPrefijoAsiMov & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMov.ToString, Len(idAsiMov) - 3)
                        rwAM("IdAsiento") = lsPrefijoAsiento.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rwAM("IdCuentaContable") = .IdCuentaContable
                        rwAM("Glosa") = .Glosa.Trim
                        rwAM("DebeMN") = .DebeMN
                        rwAM("HaberMN") = .HaberMN
                        rwAM("DebeME") = .DebeME
                        rwAM("HaberME") = .HaberME
                        rwAM("IdUsuarioCrea") = .IdUsuarioCrea.Trim
                        rwAM("FechaCreacion") = Date.Now()
                        rwAM("Activo") = True
                        rwAM("NroLinea") = fil
                        'rwAM("CodigoUnicoOperacion") = String.Empty
                        If .IndMovCajaBanco Then
                            Dim rwMCB As Data.DataRow
                            rwMCB = dtMCB.NewRow
                            rwMCB("Id") = lsPrefijoMCB & olFuncionesGenerales.CompletaConCeros(lsNumeroMCB.ToString, Len(idMCB) - 3)
                            rwMCB("IdFlujoCaja") = .MovimientoCajaBanco.IdFlujoCaja
                            rwMCB("NroBoucher") = .MovimientoCajaBanco.NroBoucher
                            rwMCB("IdCuentaBancaria") = .MovimientoCajaBanco.IdCuentaBancaria
                            rwMCB("Fecha") = .MovimientoCajaBanco.Fecha
                            rwMCB("IdTipoDocumento") = .MovimientoCajaBanco.IdMedioPago
                            rwMCB("IdPeriodoConcilia") = .MovimientoCajaBanco.IdPeriodoConcilia
                            rwMCB("Activo") = .MovimientoCajaBanco.Activo
                            rwMCB("IdAsientoMovimiento") = lsPrefijoAsiMov & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMov.ToString, Len(idAsiMov) - 3)
                            rwMCB("TipoCambio") = .MovimientoCajaBanco.TipoCambio
                            rwMCB("TotalMN") = .MovimientoCajaBanco.TotalMN
                            rwMCB("TotalME") = .MovimientoCajaBanco.TotalME
                            rwMCB("Operador") = .MovimientoCajaBanco._Operador
                            rwMCB("NroImpresion") = String.Empty
                            rwMCB("IdTipoGasto") = .MovimientoCajaBanco.IdTipoGasto
                            dtMCB.Rows.Add(rwMCB)
                        End If
                        If .IndDocumento Then
                            If .IndPagoCobro Then
                                Dim rwCPC As Data.DataRow
                                rwCPC = dtCPC.NewRow
                                rwCPC("Id") = lsPrefijoCPC.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroCPC.ToString, 12)
                                rwCPC("IdMovimientoCajaBanco") = lsPrefijoMCB & olFuncionesGenerales.CompletaConCeros(lsNumeroMCB.ToString, Len(idMCB) - 3)
                                rwCPC("IdMovimientoDocumento") = .oeCuentaCP.IdMovimientoDocumento
                                rwCPC("Fecha") = .oeCuentaCP.Fecha
                                rwCPC("MontoMN") = .oeCuentaCP.MontoMN
                                rwCPC("MontoME") = .oeCuentaCP.MontoMe
                                rwCPC("Activo") = .oeCuentaCP.Activo
                                rwCPC("UsuarioCreacion") = .IdUsuarioCrea
                                rwCPC("FechaCreacion") = Date.Now
                                rwCPC("MacPCLocalCreacion") = String.Empty
                                rwCPC("IdCuentaCorriente") = DBNull.Value
                                rwCPC("IndCargoAbono") = DBNull.Value
                                dtCPC.Rows.Add(rwCPC)
                            End If
                            Dim rwAMD As Data.DataRow
                            rwAMD = dtAsiMovDoc.NewRow
                            rwAMD("Id") = lsPrefijoAsiMovDoc & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMovDoc.ToString, Len(idAsiMovDoc) - 3)
                            rwAMD("IdMovimientoDocumento") = .AsMov_MovDoc.IdMovimientoDocumento
                            rwAMD("IdAsientoMovimiento") = lsPrefijoAsiMov & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMov.ToString, Len(idAsiMov) - 3)
                            rwAMD("Activo") = True
                            rwAMD("IdCuentaxCyP") = lsPrefijoCPC.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroCPC.ToString, 12)
                            rwAMD("UsuarioCreacion") = .IdUsuarioCrea
                            rwAMD("FechaCreacion") = Date.Now()
                            dtAsiMovDoc.Rows.Add(rwAMD)
                            lsNumeroAsiMovDoc = lsNumeroAsiMovDoc + 1
                            lsNumeroCPC = lsNumeroCPC + 1
                        End If
                    End With
                    dtAsiMov.Rows.Add(rwAM)
                    lsNumeroAsiMov = lsNumeroAsiMov + 1
                Next
                lsNumeroAsiento = lsNumeroAsiento + 1
                lsNumeroNroAsiento = lsNumeroNroAsiento + 1
            Next
            Return odAsiento.GuardarAsientoMasivo3(dtAsiento, dtAsiMov, dtMCB, dtCPC, dtAsiMovDoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarListaMasiva4(loAsiento As List(Of e_Asiento), ByVal PrefijoID As String) As Boolean Implements Il_Asiento.GuardarListaMasiva4
        Try
            olAsientoReferencia = New l_AsientoReferencia
            odAsientoReferencia = New d_AsientoReferencia

            Dim IdAsiento As String = odAsiento.UltimoIdInserta(PrefijoID)
            Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
            Dim lsNumeroAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))

            Dim NroAsiento As String = odAsiento.UltimoNroAsiento(loAsiento(0).IdTipoAsiento, loAsiento(0).IdPeriodo, "1", PrefijoID)
            Dim lsPrefijoNroAsiento As String = Left(NroAsiento, 2)
            Dim lsNumeroNroAsiento As Integer = CInt(Right(NroAsiento, Len(NroAsiento) - 2))

            Dim idAsiMov As String = odAsientoMovimiento.UltimoIdInserta(PrefijoID)
            Dim lsPrefijoAsiMov As String = Left(idAsiMov, 3)
            Dim lsNumeroAsiMov As Integer = CInt(Right(idAsiMov, Len(idAsiMov) - 3))

            Dim idMovAna As String = odMovimientoAnalisis.UltimoIdInserta(PrefijoID)
            Dim lsPrefijoMovAna As String = Left(idMovAna, 3)
            Dim lsNumeroMovAna As Integer = CInt(Right(idMovAna, Len(idMovAna) - 3))

            Dim idAsiRef As String = odAsientoReferencia.UltimoIdInserta(PrefijoID)
            Dim lsPrefijoAsiRef As String = Left(idAsiRef, 3)
            Dim lsNumeroAsiRef As Integer = CInt(Right(idAsiRef, Len(idAsiRef) - 3))

            Dim fil As Integer = 0

            Dim dtAsiento As Data.DataTable = CrearDT()
            Dim dtAsiMov As Data.DataTable = olAsientoMovimiento.CrearDT
            Dim dtMovAna As Data.DataTable = olMovimientoAnalisis.CrearDT
            Dim dtAsientoRef As Data.DataTable = olAsientoReferencia.CrearDT

            For Each oeAsi In loAsiento
                fil = 0
                Dim rwAsiento As Data.DataRow
                rwAsiento = dtAsiento.NewRow
                rwAsiento("Id") = lsPrefijoAsiento.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                rwAsiento("IdPeriodo") = oeAsi.IdPeriodo
                rwAsiento("IdTipoAsiento") = oeAsi.IdTipoAsiento
                rwAsiento("NroAsiento") = lsPrefijoNroAsiento & olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsiento, 7).ToString
                rwAsiento("Fecha") = oeAsi.Fecha
                rwAsiento("Glosa") = oeAsi.Glosa
                rwAsiento("GlosaImprime") = oeAsi.Glosa
                rwAsiento("IdMoneda") = oeAsi.IdMoneda
                rwAsiento("TipoCambio") = oeAsi.TipoCambio
                rwAsiento("TotalDebe") = oeAsi.TotalDebe
                rwAsiento("TotalHaber") = oeAsi.TotalHaber
                rwAsiento("IdUsuarioBloquea") = ""
                rwAsiento("UsuarioCreacion") = oeAsi.IdUsuarioCrea
                rwAsiento("IdEstado") = "1CH00005"
                rwAsiento("IdAsientoExtorno") = ""
                rwAsiento("FechaCreacion") = Date.Now()
                rwAsiento("Activo") = True
                rwAsiento("NroAsientoImprime") = DBNull.Value
                rwAsiento("IdentificaAsiento") = ""
                rwAsiento("IndRevision") = DBNull.Value
                rwAsiento("FechaRevision") = DBNull.Value
                rwAsiento("UsuarioRevision") = DBNull.Value
                rwAsiento("IndOrigen") = 0
                rwAsiento("UsuarioModificacion") = DBNull.Value
                rwAsiento("FechaModificacion") = DBNull.Value
                dtAsiento.Rows.Add(rwAsiento)

                Dim rwAsientoReferencia As Data.DataRow
                rwAsientoReferencia = dtAsientoRef.NewRow
                rwAsientoReferencia("Id") = lsPrefijoAsiRef.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiRef.ToString, 12)
                rwAsientoReferencia("IdAsiento") = rwAsiento("Id")
                rwAsientoReferencia("IdReferencia") = oeAsi.AsientoReferencia.IdReferencia
                rwAsientoReferencia("TipoReferencia") = 5
                rwAsientoReferencia("FechaCreacion") = Date.Now
                rwAsientoReferencia("Activo") = True
                dtAsientoRef.Rows.Add(rwAsientoReferencia)
                For Each oeAsiMov In oeAsi.AsientoMovimiento
                    Dim rwAM As Data.DataRow
                    rwAM = dtAsiMov.NewRow
                    fil = fil + 1
                    With oeAsiMov
                        rwAM("Id") = lsPrefijoAsiMov & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMov.ToString, Len(idAsiMov) - 3)
                        rwAM("IdAsiento") = lsPrefijoAsiento.ToString & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiento.ToString, 12)
                        rwAM("IdCuentaContable") = .IdCuentaContable
                        rwAM("Glosa") = .Glosa.Trim
                        rwAM("DebeMN") = .DebeMN
                        rwAM("HaberMN") = .HaberMN
                        rwAM("DebeME") = .DebeME
                        rwAM("HaberME") = .HaberME
                        rwAM("IdUsuarioCrea") = .IdUsuarioCrea.Trim
                        rwAM("FechaCreacion") = Date.Now()
                        rwAM("Activo") = True
                        rwAM("NroLinea") = fil
                        'rwAM("CodigoUnicoOperacion") = String.Empty
                        For Each oe As e_MovimientoAnalisis In .MovimientoAnalisis
                            Dim rwMA As Data.DataRow
                            rwMA = dtMovAna.NewRow
                            rwMA("Id") = lsPrefijoMovAna & olFuncionesGenerales.CompletaConCeros(lsNumeroMovAna.ToString, Len(idMovAna) - 3)
                            rwMA("IdCentroCosto") = String.Empty
                            rwMA("IdItemGasto") = String.Empty
                            rwMA("IdTrabajador") = String.Empty
                            rwMA("IdVehiculo") = oe.IdVehiculo
                            rwMA("IdRuta") = String.Empty
                            rwMA("IdBanco") = String.Empty
                            rwMA("IdAnalisis1") = String.Empty
                            rwMA("IdAnalisis2") = String.Empty
                            rwMA("Activo") = True
                            rwMA("IdAsientoMovimiento") = lsPrefijoAsiMov & olFuncionesGenerales.CompletaConCeros(lsNumeroAsiMov.ToString, Len(idAsiMov) - 3)
                            rwMA("Monto") = .DebeMN
                            rwMA("Saldo") = .DebeMN
                            rwMA("IdMovimientoAnalisis") = String.Empty
                            rwMA("IdGastoFuncion") = "1CH000087"
                            rwMA("IdOrigenProrrateo") = String.Empty
                            dtMovAna.Rows.Add(rwMA)
                            lsNumeroMovAna = lsNumeroMovAna + 1
                        Next
                    End With
                    dtAsiMov.Rows.Add(rwAM)
                    lsNumeroAsiMov = lsNumeroAsiMov + 1
                Next
                lsNumeroAsiento = lsNumeroAsiento + 1
                lsNumeroNroAsiento = lsNumeroNroAsiento + 1
                lsNumeroAsiRef = lsNumeroAsiRef + 1
            Next
            Return odAsiento.GuardarAsientoMasivo4(dtAsiento, dtAsiMov, dtMovAna, dtAsientoRef)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Ajuste Tipo Cambio y Aperturas"

    Public Function ListarAjusteTC(oeAjusteTC As e_AjusteTC) As List(Of e_AjusteTC) Implements Il_Asiento.ListarAjusteTC
        Try
            Return odAsiento.ListarAjusteTC(oeAjusteTC)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarAjusteTC(leAsientoModelo As List(Of e_AsientoModelo), leAjusteTC As List(Of e_AjusteTC)) As Boolean Implements Il_Asiento.GuardarAjusteTC
        Try
            Dim oeMovAn As New e_MovimientoAnalisis
            olFuncionesGenerales.ValidarPeriodo(leAsientoModelo(0).IdPeriodo, gAreasSGI.Contabilidad, leAsientoModelo(0).FechaMov, "")
            Dim leAsiento As New List(Of e_Asiento), oeAsientoAux As New e_Asiento, oeAsientoMov As New e_AsientoMovimiento
            Dim _MontoGanancia As Double = 0, _MontoPerdida As Double = 0
            _MontoGanancia = leAjusteTC.Sum(Function(it) it.Debe)
            _MontoPerdida = leAjusteTC.Sum(Function(it) it.Haber)
            For Each oeAsiMod In leAsientoModelo
                Dim lb_Obligacion As Boolean = False
                Dim _MontoAsiMod As Double = 0
                _MontoAsiMod = IIf(oeAsiMod.IndVinculado, _MontoGanancia, _MontoPerdida)
                If oeAsiMod.Tipo = 3 Then lb_Obligacion = True
                If _MontoAsiMod > 0 Then
                    oeAsientoAux = New e_Asiento
                    With oeAsientoAux
                        .TipoOperacion = "I" : .IdPeriodo = oeAsiMod.IdPeriodo : .IdTipoAsiento = oeAsiMod.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = oeAsiMod.FechaMov : .Glosa = leAjusteTC.Item(0).Glosa : .GlosaImprime = String.Empty
                        .IdMoneda = oeAsiMod.IdMoneda : .TipoCambio = 0 : .TotalDebe = _MontoAsiMod : .TotalHaber = _MontoAsiMod
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeAsiMod.UsuarioCreacion : .Activo = True
                        .IdentificaAsiento = oeAsiMod.Id
                    End With
                    For Each oeAux In oeAsiMod.leDetalle.OrderBy(Function(it) it.Fila).ToList
                        If oeAux.Repetir = 0 Then
                            oeAsientoMov = New e_AsientoMovimiento
                            With oeAsientoMov
                                .TipoOperacion = "I" : .IdCuentaContable = oeAux.IdCuentaContable : .IdUsuarioCrea = oeAsiMod.UsuarioCreacion
                                .Glosa = leAjusteTC.Item(0).Glosa : .Activo = True
                                .DebeMN = IIf(oeAux.Partida = 1, _MontoAsiMod, 0) : .DebeME = 0
                                .HaberMN = IIf(oeAux.Partida = 1, 0, _MontoAsiMod) : .HaberME = 0
                                oeMovAn = New e_MovimientoAnalisis
                                oeMovAn.TipoOperacion = "I"
                                oeMovAn.IdGastoFuncion = "1CH000090"
                                oeMovAn.Monto = _MontoAsiMod
                                .MovimientoAnalisis.Add(oeMovAn)
                            End With
                            oeAsientoAux.AsientoMovimiento.Add(oeAsientoMov)
                        Else
                            Dim _leMovAux As List(Of e_AjusteTC)
                            If oeAsiMod.IndVinculado Then
                                _leMovAux = leAjusteTC.Where(Function(it) it.Cuenta = oeAux.Cuenta And it.Debe > 0).ToList
                            Else
                                _leMovAux = leAjusteTC.Where(Function(it) it.Cuenta = oeAux.Cuenta And it.Haber > 0).ToList
                            End If
                            For Each oeMovDoc In _leMovAux
                                oeAsientoMov = New e_AsientoMovimiento
                                With oeAsientoMov
                                    .TipoOperacion = "I" : .IdCuentaContable = oeAux.IdCuentaContable : .IdUsuarioCrea = oeAsiMod.UsuarioCreacion
                                    .Glosa = oeMovDoc.Glosa : .Activo = True
                                    .DebeMN = IIf(oeAux.Partida = 1, oeMovDoc.Debe, 0) : .DebeME = 0
                                    .HaberMN = IIf(oeAux.Partida = 1, 0, oeMovDoc.Haber) : .HaberME = 0
                                End With
                                If lb_Obligacion Then
                                    ' Asiento Obligacion Financiera
                                    oeAsientoMov.AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                                    oeAsientoMov.AsMov_ObligacionFin.TipoOperacion = "I" : oeAsientoMov.AsMov_ObligacionFin.Activo = True
                                    oeAsientoMov.AsMov_ObligacionFin.IdObligacionFinanciera = oeMovDoc.IdMovimientoDocumento
                                Else
                                    ' Asiento Movimiento Documento
                                    oeAsientoMov.AsMov_MovDoc = New e_AsientoMov_MovDoc
                                    oeAsientoMov.AsMov_MovDoc.TipoOperacion = "I" : oeAsientoMov.AsMov_MovDoc.Activo = True
                                    oeAsientoMov.AsMov_MovDoc.IdMovimientoDocumento = oeMovDoc.IdMovimientoDocumento
                                End If
                                oeAsientoAux.AsientoMovimiento.Add(oeAsientoMov)
                            Next
                        End If
                    Next
                    leAsiento.Add(oeAsientoAux)
                End If
            Next
            Return GuardarLista(leAsiento)
            'Return GuardarListaMasiva(leAsiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarAjusteTC(leAsientoModelo As List(Of e_AsientoModelo), oeAjusteTC As e_AjusteTC) As Boolean Implements Il_Asiento.GuardarAjusteTC
        Try
            olFuncionesGenerales.ValidarPeriodo(leAsientoModelo(0).IdPeriodo, gAreasSGI.Contabilidad, leAsientoModelo(0).FechaMov, "")
            Dim leAsiento As New List(Of e_Asiento), oeAsientoAux As New e_Asiento, oeAsientoMov As New e_AsientoMovimiento
            Dim _MontoGanancia As Double = 0, _MontoPerdida As Double = 0
            _MontoGanancia = oeAjusteTC.Debe
            _MontoPerdida = oeAjusteTC.Haber
            For Each oeAsiMod In leAsientoModelo
                Dim lb_Obligacion As Boolean = False
                Dim _MontoAsiMod As Double = 0
                _MontoAsiMod = IIf(oeAsiMod.IndVinculado, _MontoGanancia, _MontoPerdida)
                If oeAsiMod.Tipo = 3 Then lb_Obligacion = True
                If _MontoAsiMod > 0 Then
                    oeAsientoAux = New e_Asiento
                    With oeAsientoAux
                        .TipoOperacion = "I" : .IdPeriodo = oeAsiMod.IdPeriodo : .IdTipoAsiento = oeAsiMod.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = oeAsiMod.FechaMov : .Glosa = oeAjusteTC.Glosa : .GlosaImprime = String.Empty
                        .IdMoneda = oeAsiMod.IdMoneda : .TipoCambio = 0 : .TotalDebe = _MontoAsiMod : .TotalHaber = _MontoAsiMod
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeAsiMod.UsuarioCreacion : .Activo = True
                        .IdentificaAsiento = oeAsiMod.Id
                    End With
                    For Each oeAux In oeAsiMod.leDetalle.OrderBy(Function(it) it.Fila).ToList
                        If oeAux.Repetir = 0 Then
                            oeAsientoMov = New e_AsientoMovimiento
                            With oeAsientoMov
                                .TipoOperacion = "I" : .IdCuentaContable = oeAux.IdCuentaContable : .IdUsuarioCrea = oeAsiMod.UsuarioCreacion
                                .Glosa = oeAjusteTC.Glosa : .Activo = True
                                .DebeMN = IIf(oeAux.Partida = 1, _MontoAsiMod, 0) : .DebeME = 0
                                .HaberMN = IIf(oeAux.Partida = 1, 0, _MontoAsiMod) : .HaberME = 0
                            End With
                            oeAsientoAux.AsientoMovimiento.Add(oeAsientoMov)
                        Else
                            If oeAjusteTC.Cuenta = oeAux.Cuenta Then
                                oeAsientoMov = New e_AsientoMovimiento
                                With oeAsientoMov
                                    .TipoOperacion = "I" : .IdCuentaContable = oeAux.IdCuentaContable : .IdUsuarioCrea = oeAsiMod.UsuarioCreacion
                                    .Glosa = oeAjusteTC.Glosa : .Activo = True
                                    .DebeMN = IIf(oeAux.Partida = 1, oeAjusteTC.Debe, 0) : .DebeME = 0
                                    .HaberMN = IIf(oeAux.Partida = 1, 0, oeAjusteTC.Haber) : .HaberME = 0
                                End With
                                If lb_Obligacion Then
                                    ' Asiento Obligacion Financiera
                                    oeAsientoMov.AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                                    oeAsientoMov.AsMov_ObligacionFin.TipoOperacion = "I" : oeAsientoMov.AsMov_ObligacionFin.Activo = True
                                    oeAsientoMov.AsMov_ObligacionFin.IdObligacionFinanciera = oeAjusteTC.IdMovimientoDocumento
                                Else
                                    ' Asiento Movimiento Documento
                                    oeAsientoMov.AsMov_MovDoc = New e_AsientoMov_MovDoc
                                    oeAsientoMov.AsMov_MovDoc.TipoOperacion = "I" : oeAsientoMov.AsMov_MovDoc.Activo = True
                                    oeAsientoMov.AsMov_MovDoc.IdMovimientoDocumento = oeAjusteTC.IdMovimientoDocumento
                                End If
                                oeAsientoAux.AsientoMovimiento.Add(oeAsientoMov)
                            End If
                        End If
                    Next
                    leAsiento.Add(oeAsientoAux)
                End If
            Next
            'Return GuardarLista(leAsiento)
            Return GuardarListaMasiva(leAsiento, oeAjusteTC.PrefijoID)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarApertura(leAsientoModel As List(Of e_AsientoModelo), leApertura As List(Of e_AjusteTC), lb_Obligacion As Boolean, ByVal PrefijoID As String) As Boolean Implements Il_Asiento.GuardarApertura
        Try
            Dim leAsiento As New List(Of e_Asiento), oeAsientoAux As New e_Asiento, oeAsientoMov As New e_AsientoMovimiento
            Dim _MontoDebe As Double = 0, _MontoHaber As Double = 0, _totalaux As Double = 0
            Dim lb_Retorna As Boolean = False
            For Each _oeAsiMod In leAsientoModel
                oeAsientoAux = New e_Asiento
                'olFuncionesGenerales.ValidarPeriodo(_oeAsiMod.IdPeriodo, gAreasSGI.Contabilidad, _oeAsiMod.FechaMov, "")
                _MontoDebe = leApertura.Where(Function(it) it.IdAsientoModelo = _oeAsiMod.Id).Sum(Function(it) it.Debe)
                _MontoHaber = leApertura.Where(Function(it) it.IdAsientoModelo = _oeAsiMod.Id).Sum(Function(it) it.Haber)
                _totalaux = _MontoDebe + _MontoHaber
                If _totalaux > 0 Then
                    With oeAsientoAux
                        .TipoOperacion = "I" : .IdPeriodo = _oeAsiMod.IdPeriodo : .IdTipoAsiento = _oeAsiMod.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = _oeAsiMod.FechaMov : .Glosa = _oeAsiMod.Nombre : .GlosaImprime = String.Empty
                        .IdMoneda = _oeAsiMod.IdMoneda : .TipoCambio = IIf(_oeAsiMod.IndVinculado, 0, _oeAsiMod.TipoCambio)
                        If _oeAsiMod.IndVinculado Then
                            .TotalDebe = _MontoDebe + _MontoHaber : .TotalHaber = _MontoDebe + _MontoHaber
                        Else
                            .TotalDebe = _MontoDebe : .TotalHaber = _MontoHaber
                        End If
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = _oeAsiMod.UsuarioCreacion : .Activo = True
                        .IdentificaAsiento = _oeAsiMod.Id
                    End With
                    For Each oeDet In _oeAsiMod.leDetalle.OrderBy(Function(it) it.Fila).ToList
                        If oeDet.Repetir = 1 Then
                            Dim _leDet = leApertura.Where(Function(it) it.Cuenta = oeDet.Cuenta And it.IdAsientoModelo = _oeAsiMod.Id).ToList
                            If _leDet.Count > 0 Then
                                For Each oeMovDoc In _leDet
                                    oeAsientoMov = New e_AsientoMovimiento
                                    With oeAsientoMov
                                        .TipoOperacion = "I" : .IdCuentaContable = oeMovDoc.IdCuentaContable : .IdUsuarioCrea = _oeAsiMod.UsuarioCreacion
                                        .Glosa = IIf(_oeAsiMod.IndVinculado = True, "CIERRE ", "APERTURA ") & oeMovDoc.Glosa : .Activo = True
                                        If oeMovDoc.Debe > 0 Then
                                            .DebeMN = IIf(_oeAsiMod.Moneda = "SOLES", oeMovDoc.Debe, oeMovDoc.Debe * _oeAsiMod.TipoCambio)
                                            If _oeAsiMod.IndVinculado Then
                                                .DebeME = 0
                                            Else
                                                .DebeME = IIf(_oeAsiMod.Moneda = "SOLES", oeMovDoc.Debe / _oeAsiMod.TipoCambio, oeMovDoc.Debe)
                                            End If
                                        Else
                                            .HaberMN = IIf(_oeAsiMod.Moneda = "SOLES", oeMovDoc.Haber, oeMovDoc.Haber * _oeAsiMod.TipoCambio)
                                            If _oeAsiMod.IndVinculado Then
                                                .HaberME = 0
                                            Else
                                                .HaberME = IIf(_oeAsiMod.Moneda = "SOLES", oeMovDoc.Haber / _oeAsiMod.TipoCambio, oeMovDoc.Haber)
                                            End If
                                        End If
                                    End With
                                    If lb_Obligacion Then
                                        ' Asiento Movimiento Obligacion Financiera
                                        oeAsientoMov.AsMov_ObligacionFin = New e_AsientoMov_ObligacionFin
                                        oeAsientoMov.AsMov_ObligacionFin.TipoOperacion = "I" : oeAsientoMov.AsMov_ObligacionFin.Activo = True
                                        oeAsientoMov.AsMov_ObligacionFin.IdObligacionFinanciera = oeMovDoc.IdMovimientoDocumento
                                    Else
                                        ' Asiento Movimiento Documento
                                        oeAsientoMov.AsMov_MovDoc = New e_AsientoMov_MovDoc
                                        oeAsientoMov.AsMov_MovDoc.TipoOperacion = "I" : oeAsientoMov.AsMov_MovDoc.Activo = True
                                        oeAsientoMov.AsMov_MovDoc.IdMovimientoDocumento = oeMovDoc.IdMovimientoDocumento
                                    End If
                                    oeAsientoAux.AsientoMovimiento.Add(oeAsientoMov)
                                Next
                            End If
                        Else
                            oeAsientoMov = New e_AsientoMovimiento
                            With oeAsientoMov
                                .TipoOperacion = "I" : .IdCuentaContable = oeDet.IdCuentaContable : .IdUsuarioCrea = _oeAsiMod.UsuarioCreacion
                                .Glosa = _oeAsiMod.Nombre : .Activo = True
                                ' Invertir Partida para Cuadrar Asiento
                                If oeDet.Partida = 1 Then
                                    .DebeMN = IIf(_oeAsiMod.Moneda = "SOLES", _MontoHaber, _MontoHaber * _oeAsiMod.TipoCambio) : .HaberMN = 0
                                Else
                                    .DebeMN = 0 : .HaberMN = IIf(_oeAsiMod.Moneda = "SOLES", _MontoDebe, _MontoDebe * _oeAsiMod.TipoCambio)
                                End If
                                .DebeME = 0 : .HaberME = 0
                                oeAsientoAux.AsientoMovimiento.Add(oeAsientoMov)
                                ' Analisis Movimiento
                            End With
                        End If
                    Next
                    leAsiento.Add(oeAsientoAux)
                End If
            Next
            'Return GuardarLista(leAsiento)
            If lb_Obligacion Then
                lb_Retorna = GuardarListaMasiva2(leAsiento, PrefijoID)
            Else
                lb_Retorna = GuardarListaMasiva(leAsiento, PrefijoID)
            End If
            Return lb_Retorna
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class
