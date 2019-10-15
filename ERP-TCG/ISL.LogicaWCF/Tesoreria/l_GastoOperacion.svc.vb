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


<DataContract(), Serializable()> _
Public Class l_GastoOperacion
    Implements Il_GastoOperacion

    Dim odGastoOperacion As New d_GastoOperacion
    Dim olMovimientoDocumento As New l_MovimientoDocumento
    'Dim odMovimientoDocumento As New d_MovimientoDocumento
    Dim olDetalleDocumento As New l_DetalleDocumento
    'Dim odDetalleDocumento As New d_DetalleDocumento
    Dim olCompra As New l_Compra
    'Dim odCompra As New d_Compra
    'Dim odAsiento As New d_Asiento
    Dim olAsiento As New l_Asiento
    'Dim odAsientoMovDoc As New d_Asiento_MovDoc
    Dim olAsientoMovDoc As New l_Asiento_MovDoc
    'Dim odAsientoMovimiento As New d_AsientoMovimiento
    Dim olCtaCxP As New l_CuentaxCyP
    'Dim odCtaCxP As New d_CuentaxCyP
    'Dim odAsientoMovimientoMovDoc As New d_AsientoMov_MovDoc
    Dim olAsientoMovimientoMovDoc As New l_AsientoMov_MovDoc
    Dim olAsientoMovimiento As New l_AsientoMovimiento
    'Dim odMovCajaBanco As New d_MovimientoCajaBanco
    Dim olMovCajaBanco As New l_MovimientoCajaBanco
    'Dim odMovimientoAnalisis As New d_MovimientoAnalisis
    Dim olMovimientoAnalisis As New l_MovimientoAnalisis
    Dim olFunGen As New l_FuncionesGenerales
    Dim oeComboCta As e_Combo
    Dim odComboCta As d_Combo
    Dim loComboCTa As List(Of e_Combo)
    Dim odDatos As d_DatosConfiguracion

    Public Function Eliminar(ByVal oeGastoOperacion As EntidadesWCF.e_GastoOperacion) As Boolean Implements Il_GastoOperacion.Eliminar
        Try
            Return odGastoOperacion.Eliminar(oeGastoOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeGastoOperacion As EntidadesWCF.e_GastoOperacion) As Boolean Implements Il_GastoOperacion.Guardar
        Try
            Return odGastoOperacion.Guardar(oeGastoOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="oeGastoOperacion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GuardarGasto(ByVal oeGastoOperacion As EntidadesWCF.e_GastoOperacion) As Boolean Implements Il_GastoOperacion.GuardarGasto
        Try
            Return odGastoOperacion.GuardarGasto(oeGastoOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardaListaMasiva(ByVal loGastoOperacionMasiva As List(Of e_GastoOperacion), loCuentasContables As List(Of e_Combo), ByVal PrefijoID As String) As Boolean Implements Il_GastoOperacion.GuardarListaMasiva
        Try
            Using TransScope As New TransactionScope()
                'objeto para ctas ctbles
                Dim oeCombo As e_Combo
                oeComboCta = New e_Combo
                odComboCta = New d_Combo
                loComboCTa = New List(Of e_Combo)
                'datatables
                Dim dt_MD As Data.DataTable = olMovimientoDocumento.CrearDT()
                Dim dt_DD As Data.DataTable = olDetalleDocumento.CrearDT()
                Dim dt_CMP As Data.DataTable = olCompra.CrearDT()
                Dim dt_ASI As Data.DataTable = olAsiento.CrearDT()
                Dim dt_ASIMOVDOC As Data.DataTable = olAsientoMovDoc.CrearDT()
                Dim dt_ASIMOV As Data.DataTable = olAsientoMovimiento.CrearDT()
                Dim dt_ASIMOVMOVDOC As Data.DataTable = olAsientoMovimientoMovDoc.CrearDT()
                Dim dt_MOVANA As Data.DataTable = olMovimientoAnalisis.CrearDT()
                Dim dt_MOVCJB As Data.DataTable = olMovCajaBanco.CrearDT()
                Dim dt_CTAXCP As Data.DataTable = olCtaCxP.CrearDT()
                'Dim IdPeriodo As String = IIf(loGastoOperacionMasiva.Where(Function(i) i.IdPeriodo.Trim <> "").ToList.Count > 0, loGastoOperacionMasiva.Where(Function(i) i.IdPeriodo.Trim <> "").ToList(0).IdPeriodo, String.Empty)
                Dim IdPeriodo As String = String.Empty
                If loGastoOperacionMasiva.Where(Function(i) i.IdPeriodo.Trim <> "").ToList.Count > 0 Then
                    IdPeriodo = loGastoOperacionMasiva.Where(Function(i) i.IdPeriodo.Trim <> "").ToList(0).IdPeriodo
                End If
                If loGastoOperacionMasiva.Where(Function(item) item.TipoOperacion = "I").Count > 0 Then
                    oeComboCta.Id = PrefijoID '@0001
                    oeComboCta.Nombre = "IdSyNroAsiento"
                    oeComboCta.Descripcion = IdPeriodo
                    loComboCTa = odComboCta.Listar(oeComboCta)
                    'movimiento documento
                    Dim IdMovimientoDocumento As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "MovimientoDocumento").Count > 0 Then
                        IdMovimientoDocumento = loComboCTa.Where(Function(i) i.Nombre = "MovimientoDocumento").ToList(0).Id
                    Else
                        IdMovimientoDocumento = Left(oeComboCta.Id, 3) + "1"
                    End If
                    Dim lsPrefijoDocumento As String = Left(IdMovimientoDocumento, 3)
                    Dim lsNumeroIdDocumento As Integer = CInt(Right(IdMovimientoDocumento, Len(IdMovimientoDocumento) - 3)) + 1
                    'detalle documento
                    Dim IdDetalleDocumento As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "DetalleDocumento").ToList.Count > 0 Then
                        IdDetalleDocumento = loComboCTa.Where(Function(i) i.Nombre = "DetalleDocumento").ToList(0).Id
                    Else
                        IdDetalleDocumento = Left(oeComboCta.Id, 3) + "1"
                    End If
                    Dim lsPrefijoDetalle As String = Left(IdDetalleDocumento, 3)
                    Dim lsNumeroIdDetalle As Integer = CInt(Right(IdDetalleDocumento, Len(IdDetalleDocumento) - 3)) + 1
                    'compra
                    Dim IdCompra As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "Compra").ToList.Count > 0 Then
                        IdCompra = loComboCTa.Where(Function(i) i.Nombre = "Compra").ToList(0).Id
                    Else
                        IdCompra = Left(oeComboCta.Id, 3) + "1"
                    End If
                    Dim lsPrefijoCompra As String = Left(IdCompra, 3)
                    Dim lsNumeroIdCompra As Integer = CInt(Right(IdCompra, Len(IdCompra) - 3)) + 1
                    'asiento
                    Dim IdAsiento As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "Asiento").ToList.Count > 0 Then
                        IdAsiento = loComboCTa.Where(Function(i) i.Nombre = "Asiento").ToList(0).Id
                    Else
                        IdAsiento = Left(oeComboCta.Id, 3) + "1"
                    End If
                    Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
                    Dim lsNumeroIdAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3)) + 1
                    'nroasientodiario
                    Dim NroAsientoDiario As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "AsientoDiario").ToList.Count > 0 Then
                        NroAsientoDiario = loComboCTa.Where(Function(i) i.Nombre = "AsientoDiario").ToList(0).Id
                    Else
                        NroAsientoDiario = Left(oeComboCta.Id, 2) + "1"
                    End If
                    Dim lsPrefijoNroAsientoDiario As String = Left(NroAsientoDiario, 2)
                    Dim lsNumeroNroAsientoDiario As Integer = CInt(Right(NroAsientoDiario, Len(NroAsientoDiario) - 2)) + 1
                    'nroasientocompra
                    Dim NroAsientoCompra As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "AsientoCompra").ToList.Count > 0 Then
                        NroAsientoCompra = loComboCTa.Where(Function(i) i.Nombre = "AsientoCompra").ToList(0).Id
                    Else
                        NroAsientoCompra = Left(oeComboCta.Id, 2) + "1"
                    End If
                    Dim lsPrefijoNroAsientoCompra As String = Left(NroAsientoCompra, 2)
                    Dim lsNumeroNroAsientoCompra As Integer = CInt(Right(NroAsientoCompra, Len(NroAsientoCompra) - 2)) + 1
                    'asiento movdoc
                    Dim IdAsientoMovDoc As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "Asiento_MovDoc").ToList.Count > 0 Then
                        IdAsientoMovDoc = loComboCTa.Where(Function(i) i.Nombre = "Asiento_MovDoc").ToList(0).Id
                    Else
                        IdAsientoMovDoc = Left(oeComboCta.Id, 3) + "1"
                    End If
                    Dim lsPrefijoAsientoMovDoc As String = Left(IdAsientoMovDoc, 3)
                    Dim lsNumeroIdAsientoMovDoc As Integer = CInt(Right(IdAsientoMovDoc, Len(IdAsientoMovDoc) - 3)) + 1
                    'nroasientocaja
                    Dim NroAsientoCaja As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "AsientoCaja").ToList.Count > 0 Then
                        NroAsientoCaja = loComboCTa.Where(Function(i) i.Nombre = "AsientoCaja").ToList(0).Id
                    Else
                        NroAsientoCaja = Left(oeComboCta.Id, 2) + "1"
                    End If
                    Dim lsPrefijoNroAsientoCaja As String = Left(NroAsientoCaja, 2)
                    Dim lsNumeroNroAsientoCaja As Integer = CInt(Right(NroAsientoCaja, Len(NroAsientoCaja) - 2)) + 1
                    'asientmov
                    Dim IdAsientoMovimiento As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "AsientoMovimiento").ToList.Count > 0 Then
                        IdAsientoMovimiento = loComboCTa.Where(Function(i) i.Nombre = "AsientoMovimiento").ToList(0).Id
                    Else
                        IdAsientoMovimiento = Left(oeComboCta.Id, 3) + "1"
                    End If
                    Dim lsPrefijoAsientoMovimiento As String = Left(IdAsientoMovimiento, 3)
                    Dim lsNumeroIdAsientoMovimiento As Integer = CInt(Right(IdAsientoMovimiento, Len(IdAsientoMovimiento) - 3)) + 1
                    'cta x c y p
                    Dim IdCtaxCyP As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "CuentaxCyP").ToList.Count > 0 Then
                        IdCtaxCyP = loComboCTa.Where(Function(i) i.Nombre = "CuentaxCyP").ToList(0).Id
                    Else
                        IdCtaxCyP = Left(oeComboCta.Id, 3) + "1"
                    End If
                    Dim lsPrefijoIdCtaxCyP As String = Left(IdCtaxCyP, 3)
                    Dim lsNumeroIdCtaxCyP As Integer = CInt(Right(IdCtaxCyP, Len(IdCtaxCyP) - 3)) + 1
                    'asientomovimiento movdoc
                    Dim IdAsientoMovimientoMovDoc As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "AsientoMov_MovDoc").ToList.Count > 0 Then
                        IdAsientoMovimientoMovDoc = loComboCTa.Where(Function(i) i.Nombre = "AsientoMov_MovDoc").ToList(0).Id
                    Else
                        IdAsientoMovimientoMovDoc = Left(oeComboCta.Id, 3) + "1"
                    End If
                    Dim lsPrefijoAsientoMovimientoMovDoc As String = Left(IdAsientoMovimientoMovDoc, 3)
                    Dim lsNumeroIdAsientoMovimientoMovDoc As Integer = CInt(Right(IdAsientoMovimientoMovDoc, Len(IdAsientoMovimientoMovDoc) - 3)) + 1
                    'movcajabanco
                    Dim IdMovimientoCajaBanco As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "MovimientoCajaBanco").ToList.Count > 0 Then
                        IdMovimientoCajaBanco = loComboCTa.Where(Function(i) i.Nombre = "MovimientoCajaBanco").ToList(0).Id
                    Else
                        IdMovimientoCajaBanco = Left(oeComboCta.Id, 3) + "1"
                    End If
                    Dim lsPrefijoMovCajaBanco As String = Left(IdMovimientoCajaBanco, 3)
                    Dim lsNumeroIdMovCajaBanco As Integer = CInt(Right(IdMovimientoCajaBanco, Len(IdMovimientoCajaBanco) - 3)) + 1
                    'movi analisi
                    Dim IdMovAna As String = String.Empty
                    If loComboCTa.Where(Function(i) i.Nombre = "MovimientoAnalisis").ToList.Count > 0 Then
                        IdMovAna = loComboCTa.Where(Function(i) i.Nombre = "MovimientoAnalisis").ToList(0).Id
                    Else
                        IdMovAna = Left(oeComboCta.Id, 3) + "1"
                    End If
                    Dim lsPrefijoMovAna As String = Left(IdMovAna, 3)
                    Dim lsNumeroIdMovAna As Integer = CInt(Right(IdMovAna, Len(IdMovAna) - 3)) + 1

                    Dim fecAsiento As Date = #1/1/1901#

                    For Each oeGastoOperacion As e_GastoOperacion In loGastoOperacionMasiva.Where(Function(item) item.TipoOperacion = "I").ToList
                        Dim rowMovDoc As Data.DataRow
                        Dim rowDetDoc As Data.DataRow
                        Dim rowCompra As Data.DataRow
                        Dim rowAsiento As Data.DataRow
                        Dim rowAsiMovFlu As Data.DataRow
                        Dim rowAsiMov10 As Data.DataRow
                        Dim rowMovAna As Data.DataRow
                        Dim rowMovCajBan As Data.DataRow
                        Dim rowAsientoMovDoc As Data.DataRow
                        Dim rowAsientoMovMovDoc As Data.DataRow
                        Dim rowCtaxCP As Data.DataRow
                        oeGastoOperacion.PrefijoID = PrefijoID '@0001
                        With oeGastoOperacion
                            If .IdTipoDocumento = "1CH000000073" Then 'SUSTENTO CONTABLE

                                ' Genera Comprobante de Pago
                                rowMovDoc = dt_MD.NewRow
                                rowMovDoc("Id") = lsPrefijoDocumento + olFunGen.CompletaConCeros(lsNumeroIdDocumento.ToString, 12)
                                rowMovDoc("IdTipoDocumento") = .IdTipoDocumento
                                rowMovDoc("Serie") = .SerieDoc
                                rowMovDoc("Numero") = .NroDoc
                                rowMovDoc("FechaEmision") = .FechaEmision
                                rowMovDoc("FechaVencimiento") = .FechaEmision
                                rowMovDoc("NoGravadas") = .oeMovimientoDocumento.NoGravado
                                rowMovDoc("IGV") = .IGV
                                rowMovDoc("SubTotal") = .SubTotal
                                rowMovDoc("Total") = .Total
                                rowMovDoc("Saldo") = 0
                                rowMovDoc("IdClienteProveedor") = .IdProveedor
                                rowMovDoc("Activo") = True
                                rowMovDoc("IndCompraVenta") = "-1"
                                rowMovDoc("IdPeriodo") = .IdPeriodo
                                rowMovDoc("IdMoneda") = .IdMoneda
                                rowMovDoc("TipoCambio") = .TipoCambio
                                rowMovDoc("UsuarioCreacion") = .UsuarioCreacion
                                rowMovDoc("FechaCreacion") = .FechaCreacion
                                rowMovDoc("IdCuentaContable") = ""
                                rowMovDoc("IdEstadoDocumento") = "1CH00009"
                                rowMovDoc("Operador") = 1
                                rowMovDoc("MacPCLocalCreacion") = .Mac
                                rowMovDoc("IndServicioMaterial") = "S"
                                rowMovDoc("GlosaCtaxCyP") = ""
                                rowMovDoc("CuoMomentaneo") = ""
                                rowMovDoc("UsuarioModifica") = ""
                                rowMovDoc("FechaModificacion") = Date.Parse("01/01/1901")
                                dt_MD.Rows.Add(rowMovDoc)
                                lsNumeroIdDocumento += 1
                                .IdDocumento = rowMovDoc("Id")

                                ' Genera Detalle de Comprobante de Pago              
                                rowDetDoc = dt_DD.NewRow
                                rowDetDoc("Id") = lsPrefijoDetalle + olFunGen.CompletaConCeros(lsNumeroIdDetalle, 9)
                                rowDetDoc("IdMovimientoDocumento") = rowMovDoc("Id")
                                rowDetDoc("IndServicioMaterial") = "S"
                                rowDetDoc("IdMaterialServicio") = "1CH000000301"
                                rowDetDoc("Cantidad") = 1
                                rowDetDoc("PrecioUnitario") = .SubTotal
                                rowDetDoc("IndGravado") = IIf(.IGV > 0, True, False)
                                rowDetDoc("Valor") = .Total
                                rowDetDoc("Igv") = .IGV
                                rowDetDoc("IdOperacionDetalle") = ""
                                rowDetDoc("IdVehiculo") = .oeMovimientoDocumento.lstDetalleDocumento(0).IdVehiculo
                                rowDetDoc("Activo") = True
                                rowDetDoc("UsuarioCreacion") = .UsuarioCreacion
                                rowDetDoc("FechaCreacion") = .FechaCreacion
                                rowDetDoc("IdUnidadMedida") = "1CH000000001"
                                rowDetDoc("FactorRefUni") = 0
                                rowDetDoc("IdViaje") = ""
                                dt_DD.Rows.Add(rowDetDoc)
                                lsNumeroIdDetalle += 1

                                fecAsiento = olFunGen.gfc_ObtenerFechaAsiento(.oeMovimientoDocumento.FechaEmision, .oeMovimientoDocumento.FechaFinal)

                                ' Generar Asiento Contable
                                rowAsiento = dt_ASI.NewRow
                                rowAsiento("Id") = lsPrefijoAsiento.ToString + olFunGen.CompletaConCeros(lsNumeroIdAsiento.ToString, 12)
                                rowAsiento("IdPeriodo") = .IdPeriodo
                                rowAsiento("IdTipoAsiento") = "1CH000020"
                                rowAsiento("NroAsiento") = lsPrefijoNroAsientoDiario + olFunGen.CompletaConCeros(lsNumeroNroAsientoDiario, 7).ToString
                                rowAsiento("Fecha") = fecAsiento
                                rowAsiento("Glosa") = "DOC. SUSTENTO " & .oeMovimientoDocumento.Compra.TipoDoc.Abreviatura & "/" & .SerieDoc & .NroDoc & " " & .oeMovimientoDocumento.Compra.Proveedor.Nombre + " " + .FechaEmision.Date.Day.ToString + "/" +
                                .FechaEmision.Date.Month.ToString + "/" + .FechaEmision.Date.Year.ToString +
                                " " + .Glosa + " V,G:" + .oeMovimientoDocumento.GlosaViajeGrupo
                                rowAsiento("GlosaImprime") = "DOC. SUSTENTO " & .oeMovimientoDocumento.Compra.TipoDoc.Abreviatura & "/" & .SerieDoc & .NroDoc & " " & .oeMovimientoDocumento.Compra.Proveedor.Nombre + " " + .FechaEmision.Date.Day.ToString + "/" +
                                .FechaEmision.Date.Month.ToString + "/" + .FechaEmision.Date.Year.ToString
                                rowAsiento("IdMoneda") = .IdMoneda
                                rowAsiento("TipoCambio") = .TipoCambio
                                rowAsiento("TotalDebe") = .Total
                                rowAsiento("TotalHaber") = .Total
                                rowAsiento("IdUsuarioBloquea") = ""
                                rowAsiento("UsuarioCreacion") = .UsuarioCreacion
                                rowAsiento("IdEstado") = "1CH00005"
                                rowAsiento("IdAsientoExtorno") = ""
                                rowAsiento("FechaCreacion") = .FechaCreacion
                                rowAsiento("Activo") = True
                                rowAsiento("NroAsientoImprime") = DBNull.Value
                                rowAsiento("IdentificaAsiento") = DBNull.Value
                                rowAsiento("IndRevision") = DBNull.Value
                                rowAsiento("FechaRevision") = DBNull.Value
                                rowAsiento("UsuarioRevision") = DBNull.Value
                                rowAsiento("IndOrigen") = 0
                                rowAsiento("UsuarioModificacion") = ""
                                rowAsiento("FechaModificacion") = Date.Parse("01/01/1901")
                                'rowAsiento("CodigoUnicoOperacion") = olFunGen.ObtenerCUOAsiento(rowAsiento("NroAsiento"), rowAsiento("IdTipoAsiento"))
                                dt_ASI.Rows.Add(rowAsiento)
                                .GastoAsiento.IdAsiento = rowAsiento("Id")
                                lsNumeroIdAsiento += 1
                                lsNumeroNroAsientoDiario += 1

                                ' Generar Asiento Movimiento - Gasto
                                rowAsiMovFlu = dt_ASIMOV.NewRow
                                rowAsiMovFlu("Id") = lsPrefijoAsientoMovimiento + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                rowAsiMovFlu("IdAsiento") = rowAsiento("Id")
                                If .oeFlujoCaja.CtaContable = "" Then Throw New Exception("Flujo Caja sin Cuenta Contable. Verificar")
                                rowAsiMovFlu("IdCuentaContable") = .oeFlujoCaja.CtaContable
                                rowAsiMovFlu("Glosa") = rowAsiento("Glosa")
                                rowAsiMovFlu("DebeMN") = .Total
                                rowAsiMovFlu("HaberMN") = 0
                                rowAsiMovFlu("DebeME") = .Total / .TipoCambio
                                rowAsiMovFlu("HaberME") = 0
                                rowAsiMovFlu("IdUsuarioCrea") = .UsuarioCreacion
                                rowAsiMovFlu("FechaCreacion") = .FechaCreacion
                                rowAsiMovFlu("Activo") = True
                                rowAsiMovFlu("NroLinea") = 1
                                dt_ASIMOV.Rows.Add(rowAsiMovFlu)
                                lsNumeroIdAsientoMovimiento += 1


                                ' Generar Asiento Movimiento - Analisis
                                rowMovAna = dt_MOVANA.NewRow
                                rowMovAna("Id") = lsPrefijoMovAna & olFunGen.CompletaConCeros(lsNumeroIdMovAna.ToString, 13)
                                rowMovAna("IdCentroCosto") = DBNull.Value
                                rowMovAna("IdItemGasto") = .oeFlujoCaja.IdItemGasto
                                rowMovAna("IdTrabajador") = .oeGasto_Caja.IdTrabajador
                                rowMovAna("IdVehiculo") = .oeGasto_Caja.IdPlaca
                                rowMovAna("IdRuta") = DBNull.Value
                                rowMovAna("IdBanco") = DBNull.Value
                                rowMovAna("IdAnalisis1") = DBNull.Value
                                rowMovAna("IdAnalisis2") = DBNull.Value
                                rowMovAna("Activo") = 1
                                rowMovAna("IdAsientoMovimiento") = rowAsiMovFlu("Id")
                                rowMovAna("Monto") = .Total
                                rowMovAna("Saldo") = .Total
                                rowMovAna("IdMovimientoAnalisis") = DBNull.Value
                                If .TipoMovimiento = 2 Then
                                    rowMovAna("IdGastoFuncion") = .oeGasto_Caja.IdGastoFuncion
                                Else
                                    rowMovAna("IdGastoFuncion") = .oeMovimientoDocumento.MovimientoAnalisis(0).IdGastoFuncion
                                End If
                                rowMovAna("IdOrigenProrrateo") = ""
                                dt_MOVANA.Rows.Add(rowMovAna)
                                lsNumeroIdMovAna += 1

                                ' Generar Asiento Movimiento Caja
                                rowAsiMov10 = dt_ASIMOV.NewRow
                                rowAsiMov10("Id") = lsPrefijoAsientoMovimiento + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                rowAsiMov10("IdAsiento") = rowAsiento("Id")
                                oeCombo = New e_Combo
                                oeCombo.Descripcion = .Ejercicio.ToString
                                oeCombo.Nombre = "10211"
                                oeCombo.Tipo = 4
                                If loCuentasContables.Contains(oeCombo) Then
                                    oeCombo = loCuentasContables.Item(loCuentasContables.IndexOf(oeCombo))
                                Else
                                    Throw New Exception("Error en Cuenta Contable. Verificar")
                                End If
                                rowAsiMov10("IdCuentaContable") = oeCombo.Id
                                rowAsiMov10("Glosa") = rowAsiento("Glosa")
                                rowAsiMov10("DebeMN") = 0
                                rowAsiMov10("HaberMN") = .Total
                                rowAsiMov10("DebeME") = 0
                                rowAsiMov10("HaberME") = .Total / .TipoCambio
                                rowAsiMov10("IdUsuarioCrea") = .UsuarioCreacion
                                rowAsiMov10("FechaCreacion") = .FechaCreacion
                                rowAsiMov10("Activo") = True
                                rowAsiMov10("NroLinea") = 2
                                dt_ASIMOV.Rows.Add(rowAsiMov10)
                                lsNumeroIdAsientoMovimiento += 1

                                ' Generar Movimiento Caja Banco
                                rowMovCajBan = dt_MOVCJB.NewRow
                                rowMovCajBan("Id") = lsPrefijoMovCajaBanco + olFunGen.CompletaConCeros(lsNumeroIdMovCajaBanco.ToString, 13)
                                rowMovCajBan("IdFlujoCaja") = .IdFlujoCaja
                                rowMovCajBan("NroBoucher") = DBNull.Value
                                rowMovCajBan("IdCuentaBancaria") = DBNull.Value
                                rowMovCajBan("Fecha") = .FechaEmision
                                rowMovCajBan("IdTipoDocumento") = "1CH03"
                                rowMovCajBan("IdPeriodoConcilia") = ""
                                rowMovCajBan("Activo") = True
                                rowMovCajBan("IdAsientoMovimiento") = rowAsiMov10("Id")
                                rowMovCajBan("TipoCambio") = .TipoCambio
                                rowMovCajBan("TotalMN") = .Total
                                rowMovCajBan("TotalME") = .Total / .TipoCambio
                                rowMovCajBan("Operador") = -1
                                rowMovCajBan("NroImpresion") = DBNull.Value
                                rowMovCajBan("IdTipoGasto") = DBNull.Value
                                dt_MOVCJB.Rows.Add(rowMovCajBan)
                                lsNumeroIdMovCajaBanco += 1

                            ElseIf .IdTipoDocumento = "1CH000000062" Then 'VALE

                                fecAsiento = olFunGen.gfc_ObtenerFechaAsiento(.oeMovimientoDocumento.FechaEmision, .oeMovimientoDocumento.FechaFinal)

                                ' Genera Asiento Contable
                                rowAsiento = dt_ASI.NewRow
                                rowAsiento("Id") = lsPrefijoAsiento.ToString + olFunGen.CompletaConCeros(lsNumeroIdAsiento.ToString, 12)
                                rowAsiento("IdPeriodo") = .IdPeriodo
                                rowAsiento("IdTipoAsiento") = "1CH000020"
                                rowAsiento("NroAsiento") = lsPrefijoNroAsientoDiario + olFunGen.CompletaConCeros(lsNumeroNroAsientoDiario, 7).ToString
                                rowAsiento("Fecha") = fecAsiento
                                rowAsiento("Glosa") = "ASIENTO DE DOCS A RENDIR DE " & .Piloto & " V,G:" + .oeMovimientoDocumento.GlosaViajeGrupo
                                rowAsiento("GlosaImprime") = "ASIENTO DE DOCS A RENDIR DE " & .Piloto & " V,G:" + .oeMovimientoDocumento.GlosaViajeGrupo
                                rowAsiento("IdMoneda") = .IdMoneda
                                rowAsiento("TipoCambio") = .TipoCambio
                                rowAsiento("TotalDebe") = .Total
                                rowAsiento("TotalHaber") = .Total
                                rowAsiento("IdUsuarioBloquea") = ""
                                rowAsiento("UsuarioCreacion") = .UsuarioCreacion
                                rowAsiento("IdEstado") = "1CH00005"
                                rowAsiento("IdAsientoExtorno") = ""
                                rowAsiento("FechaCreacion") = .FechaCreacion
                                rowAsiento("Activo") = True
                                rowAsiento("NroAsientoImprime") = DBNull.Value
                                rowAsiento("IdentificaAsiento") = DBNull.Value
                                rowAsiento("IndRevision") = DBNull.Value
                                rowAsiento("FechaRevision") = DBNull.Value
                                rowAsiento("UsuarioRevision") = DBNull.Value
                                rowAsiento("IndOrigen") = 0
                                rowAsiento("UsuarioModificacion") = ""
                                rowAsiento("FechaModificacion") = Date.Parse("01/01/1901")
                                'rowAsiento("CodigoUnicoOperacion") = olFunGen.ObtenerCUOAsiento(rowAsiento("NroAsiento"), rowAsiento("IdTipoAsiento"))

                                dt_ASI.Rows.Add(rowAsiento)
                                lsNumeroIdAsiento += 1
                                lsNumeroNroAsientoDiario += 1
                                .GastoAsiento.IdAsiento = rowAsiento("Id")

                                ' Genera Asiento Movimiento de Otras Cuentas por Cobrar
                                Dim rowAsiMov16 As Data.DataRow
                                rowAsiMov16 = dt_ASIMOV.NewRow
                                rowAsiMov16("Id") = lsPrefijoAsientoMovimiento + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                rowAsiMov16("IdAsiento") = rowAsiento("Id")
                                oeCombo = New e_Combo
                                oeCombo.Descripcion = .Ejercicio.ToString
                                oeCombo.Nombre = "16811"
                                oeCombo.Tipo = 4
                                If loCuentasContables.Contains(oeCombo) Then
                                    oeCombo = loCuentasContables.Item(loCuentasContables.IndexOf(oeCombo))
                                Else
                                    Throw New Exception("Error en Cuenta Contable. Verificar")
                                End If
                                rowAsiMov16("IdCuentaContable") = oeCombo.Id
                                rowAsiMov16("Glosa") = rowAsiento("Glosa")
                                rowAsiMov16("DebeMN") = .Total
                                rowAsiMov16("HaberMN") = 0
                                rowAsiMov16("DebeME") = .Total / .TipoCambio
                                rowAsiMov16("HaberME") = 0
                                rowAsiMov16("IdUsuarioCrea") = .UsuarioCreacion
                                rowAsiMov16("FechaCreacion") = .FechaCreacion
                                rowAsiMov16("Activo") = True
                                rowAsiMov16("NroLinea") = 1
                                dt_ASIMOV.Rows.Add(rowAsiMov16)
                                lsNumeroIdAsientoMovimiento += 1

                                ' Generar Asiento Movimiento - Analisis
                                rowMovAna = dt_MOVANA.NewRow
                                rowMovAna("Id") = lsPrefijoMovAna & olFunGen.CompletaConCeros(lsNumeroIdMovAna.ToString, 13)
                                rowMovAna("IdCentroCosto") = DBNull.Value
                                rowMovAna("IdItemGasto") = .TipoBus
                                rowMovAna("IdTrabajador") = IIf(.TipoMovimiento = 2, .oeGasto_Caja.IdTrabajador, .IdPiloto)
                                rowMovAna("IdVehiculo") = IIf(.TipoMovimiento = 2, .oeGasto_Caja.IdPlaca, .IdTracto)
                                rowMovAna("IdRuta") = DBNull.Value
                                rowMovAna("IdBanco") = DBNull.Value
                                rowMovAna("IdAnalisis1") = DBNull.Value
                                rowMovAna("IdAnalisis2") = DBNull.Value
                                rowMovAna("Activo") = 1
                                rowMovAna("IdAsientoMovimiento") = rowAsiMov16("Id")
                                rowMovAna("Monto") = .Total
                                rowMovAna("Saldo") = .Total
                                rowMovAna("IdMovimientoAnalisis") = DBNull.Value
                                If .TipoMovimiento = 2 Then
                                    rowMovAna("IdGastoFuncion") = .oeGasto_Caja.IdGastoFuncion
                                Else
                                    rowMovAna("IdGastoFuncion") = .oeMovimientoDocumento.MovimientoAnalisis(0).IdGastoFuncion
                                End If
                                rowMovAna("IdOrigenProrrateo") = ""
                                dt_MOVANA.Rows.Add(rowMovAna)
                                lsNumeroIdMovAna += 1

                                ' Genera Asiento Movimiento de Caja
                                rowAsiMov10 = dt_ASIMOV.NewRow
                                rowAsiMov10("Id") = lsPrefijoAsientoMovimiento + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                rowAsiMov10("IdAsiento") = rowAsiento("Id")
                                oeCombo = New e_Combo
                                oeCombo.Descripcion = .Ejercicio.ToString
                                oeCombo.Nombre = "10211"
                                oeCombo.Tipo = 4
                                If loCuentasContables.Contains(oeCombo) Then
                                    oeCombo = loCuentasContables.Item(loCuentasContables.IndexOf(oeCombo))
                                Else
                                    Throw New Exception("Error en Cuenta Contable. Verificar")
                                End If
                                rowAsiMov10("IdCuentaContable") = oeCombo.Id
                                rowAsiMov10("Glosa") = rowAsiento("Glosa")
                                rowAsiMov10("DebeMN") = 0
                                rowAsiMov10("HaberMN") = .Total
                                rowAsiMov10("DebeME") = 0
                                rowAsiMov10("HaberME") = .Total / .TipoCambio
                                rowAsiMov10("IdUsuarioCrea") = .UsuarioCreacion
                                rowAsiMov10("FechaCreacion") = .FechaCreacion
                                rowAsiMov10("Activo") = True
                                rowAsiMov10("NroLinea") = 2
                                dt_ASIMOV.Rows.Add(rowAsiMov10)
                                lsNumeroIdAsientoMovimiento += 1

                                ' Genera Movimiento Caja Banco
                                rowMovCajBan = dt_MOVCJB.NewRow
                                rowMovCajBan("Id") = lsPrefijoMovCajaBanco + olFunGen.CompletaConCeros(lsNumeroIdMovCajaBanco.ToString, 13)
                                rowMovCajBan("IdFlujoCaja") = .IdFlujoCaja
                                rowMovCajBan("NroBoucher") = DBNull.Value
                                rowMovCajBan("IdCuentaBancaria") = DBNull.Value
                                rowMovCajBan("Fecha") = .FechaEmision
                                rowMovCajBan("IdTipoDocumento") = "1CH03"
                                rowMovCajBan("IdPeriodoConcilia") = ""
                                rowMovCajBan("Activo") = True
                                rowMovCajBan("IdAsientoMovimiento") = rowAsiMov10("Id")
                                rowMovCajBan("TipoCambio") = .TipoCambio
                                rowMovCajBan("TotalMN") = .Total
                                rowMovCajBan("TotalME") = .Total / .TipoCambio
                                rowMovCajBan("Operador") = -1
                                rowMovCajBan("NroImpresion") = DBNull.Value
                                rowMovCajBan("IdTipoGasto") = DBNull.Value
                                dt_MOVCJB.Rows.Add(rowMovCajBan)
                                lsNumeroIdMovCajaBanco += 1

                            Else

                                ' Generar Comprobante de Pago
                                rowMovDoc = dt_MD.NewRow

                                fecAsiento = olFunGen.gfc_ObtenerFechaAsiento(.oeMovimientoDocumento.FechaEmision, .oeMovimientoDocumento.FechaFinal)

                                If Not .oeGasto_Caja.IndCompraAlmacen Then
                                    rowMovDoc("Id") = lsPrefijoDocumento + olFunGen.CompletaConCeros(lsNumeroIdDocumento.ToString, 12)
                                    rowMovDoc("IdTipoDocumento") = .IdTipoDocumento
                                    rowMovDoc("Serie") = .SerieDoc
                                    rowMovDoc("Numero") = .NroDoc
                                    rowMovDoc("FechaEmision") = .FechaEmision
                                    rowMovDoc("FechaVencimiento") = .FechaEmision
                                    rowMovDoc("NoGravadas") = .oeMovimientoDocumento.NoGravado
                                    rowMovDoc("IGV") = .IGV
                                    rowMovDoc("SubTotal") = .SubTotal
                                    rowMovDoc("Total") = .Total
                                    rowMovDoc("Saldo") = 0
                                    rowMovDoc("IdClienteProveedor") = .IdProveedor
                                    rowMovDoc("Activo") = True
                                    If .IdTipoDocumento <> "1SI000000001" Then
                                        If .IndGasto = 1 Then
                                            rowMovDoc("IndCompraVenta") = "-1"
                                        Else
                                            rowMovDoc("IndCompraVenta") = "1"
                                        End If
                                    Else
                                        rowMovDoc("IndCompraVenta") = "-1"
                                    End If
                                    rowMovDoc("IdPeriodo") = .IdPeriodo
                                    rowMovDoc("IdMoneda") = .IdMoneda
                                    rowMovDoc("TipoCambio") = .TipoCambio
                                    rowMovDoc("UsuarioCreacion") = .UsuarioCreacion
                                    rowMovDoc("FechaCreacion") = .FechaCreacion
                                    rowMovDoc("IdCuentaContable") = ""
                                    rowMovDoc("IdEstadoDocumento") = "1CH00009"
                                    rowMovDoc("Operador") = 1
                                    rowMovDoc("MacPCLocalCreacion") = .Mac
                                    rowMovDoc("IndServicioMaterial") = IIf(.IdFlujoCaja = "1CH000000085", "M", "S")
                                    rowMovDoc("GlosaCtaxCyP") = ""
                                    rowMovDoc("CuoMomentaneo") = ""
                                    rowMovDoc("UsuarioModifica") = ""
                                    rowMovDoc("FechaModificacion") = Date.Parse("01/01/1901")
                                    dt_MD.Rows.Add(rowMovDoc)
                                    lsNumeroIdDocumento += 1
                                    .IdDocumento = rowMovDoc("Id")

                                    ' Generar Detalle de Comprobante de Pago
                                    If rowMovDoc("IndServicioMaterial") = "M" Then
                                        rowDetDoc = dt_DD.NewRow
                                        rowDetDoc("Id") = lsPrefijoDetalle + olFunGen.CompletaConCeros(lsNumeroIdDetalle, 9)
                                        rowDetDoc("IdMovimientoDocumento") = rowMovDoc("Id")
                                        rowDetDoc("IndServicioMaterial") = "M"
                                        rowDetDoc("IdMaterialServicio") = .oeMovimientoDocumento.lstDetalleDocumento(0).IdMaterialServicio
                                        rowDetDoc("Cantidad") = .oeRegistroCombustible.CantidadGalon
                                        rowDetDoc("PrecioUnitario") = .Total / .oeRegistroCombustible.CantidadGalon
                                        rowDetDoc("IndGravado") = IIf(.IGV > 0, True, False)
                                        rowDetDoc("Valor") = .SubTotal
                                        rowDetDoc("Igv") = .IGV
                                        rowDetDoc("IdOperacionDetalle") = ""
                                        rowDetDoc("IdVehiculo") = .oeGasto_Caja.IdPlaca
                                        rowDetDoc("Activo") = True
                                        rowDetDoc("UsuarioCreacion") = .UsuarioCreacion
                                        rowDetDoc("FechaCreacion") = .FechaCreacion
                                        rowDetDoc("IdUnidadMedida") = "1CH000000001"
                                        rowDetDoc("FactorRefUni") = 0
                                        rowDetDoc("IdViaje") = ""
                                    Else
                                        rowDetDoc = dt_DD.NewRow
                                        rowDetDoc("Id") = lsPrefijoDetalle + olFunGen.CompletaConCeros(lsNumeroIdDetalle, 9)
                                        rowDetDoc("IdMovimientoDocumento") = rowMovDoc("Id")
                                        rowDetDoc("IndServicioMaterial") = "S"
                                        rowDetDoc("IdMaterialServicio") = "1CH000000301"
                                        rowDetDoc("Cantidad") = 1
                                        rowDetDoc("PrecioUnitario") = .Total
                                        rowDetDoc("IndGravado") = IIf(.IGV > 0, True, False)
                                        rowDetDoc("Valor") = .SubTotal
                                        rowDetDoc("Igv") = .IGV
                                        rowDetDoc("IdOperacionDetalle") = ""
                                        rowDetDoc("IdVehiculo") = .oeGasto_Caja.IdPlaca
                                        rowDetDoc("Activo") = True
                                        rowDetDoc("UsuarioCreacion") = .UsuarioCreacion
                                        rowDetDoc("FechaCreacion") = .FechaCreacion
                                        rowDetDoc("IdUnidadMedida") = "1PY000000011"
                                        rowDetDoc("FactorRefUni") = 0
                                        rowDetDoc("IdViaje") = ""
                                    End If
                                    dt_DD.Rows.Add(rowDetDoc)
                                    lsNumeroIdDetalle += 1
                                    'INDGASTO = 1 PREPAGO
                                    'INDGASTO = 2 POSTPAGO
                                    'INDGASTO = 3 OT
                                    If .IdTipoDocumento <> "1SI000000001" Then
                                        If .IndGasto = 0 Then
                                            rowCompra = dt_CMP.NewRow
                                            rowCompra("Id") = lsPrefijoCompra + olFunGen.CompletaConCeros(lsNumeroIdCompra, 12)
                                            rowCompra("AnoEmisionAduana") = 0
                                            If .IGV > 0 Then
                                                rowCompra("Base1") = .SubTotal
                                                rowCompra("Igv1") = .IGV
                                                rowCompra("NoGravadas") = .oeMovimientoDocumento.NoGravado
                                            Else
                                                rowCompra("Base1") = 0
                                                rowCompra("Igv1") = 0
                                                rowCompra("NoGravadas") = .Total
                                            End If
                                            rowCompra("Base2") = 0
                                            rowCompra("Igv2") = 0
                                            rowCompra("Base3") = 0
                                            rowCompra("Igv3") = 0
                                            rowCompra("Isc") = 0
                                            rowCompra("OtrosTributos") = 0
                                            rowCompra("IdMovimientoDocumento") = rowMovDoc("Id")
                                            rowCompra("Activo") = True
                                            rowCompra("IdTipoCompra") = "1CH000053"
                                            rowCompra("IdTipoPago") = "1SI000000001"
                                            rowCompra("Percepcion") = 0
                                            rowCompra("Detraccion") = 0
                                            rowCompra("Retencion") = 0
                                            rowCompra("PercepcionPorc") = 0
                                            rowCompra("DetraccionPorc") = 0
                                            rowCompra("RetencionPorc") = 0
                                            rowCompra("IndTipoOperacion") = ""
                                            rowCompra("Glosa") = ""
                                            rowCompra("ImpRenta") = 0
                                            rowCompra("CobraCajaChica") = 1
                                            rowCompra("IdMotivoDocumento") = ""
                                            rowCompra("NroRegImprime") = ""
                                            dt_CMP.Rows.Add(rowCompra)
                                            lsNumeroIdCompra += 1
                                        End If
                                        If .IndGasto <> 2 Then
                                            'asiento provision

                                            rowAsiento = dt_ASI.NewRow
                                            rowAsiento("Id") = lsPrefijoAsiento.ToString + olFunGen.CompletaConCeros(lsNumeroIdAsiento.ToString, 12)
                                            rowAsiento("IdPeriodo") = .IdPeriodo
                                            rowAsiento("NroAsiento") = lsPrefijoNroAsientoCompra + olFunGen.CompletaConCeros(lsNumeroNroAsientoCompra, 7).ToString
                                            If .IndGasto = 0 Then
                                                rowAsiento("IdTipoAsiento") = "1CH000019"
                                                rowAsiento("Glosa") = "COMPRA " & .oeMovimientoDocumento.Compra.TipoDoc.Abreviatura & "/" & .oeMovimientoDocumento.Serie & .oeMovimientoDocumento.Numero & " " & .Proveedor + " V,G:" + .oeMovimientoDocumento.GlosaViajeGrupo
                                                rowAsiento("GlosaImprime") = "COMPRA " & .oeMovimientoDocumento.Compra.TipoDoc.Abreviatura & "/" & .oeMovimientoDocumento.Serie & .oeMovimientoDocumento.Numero & " " & .Proveedor
                                            Else
                                                rowAsiento("IdTipoAsiento") = "1CH000020"
                                                rowAsiento("Glosa") = "ASIENTO " & .oeMovimientoDocumento.Compra.TipoDoc.Abreviatura & "/" & .oeMovimientoDocumento.Serie & .oeMovimientoDocumento.Numero & " " & .Proveedor + " V,G:" + .oeMovimientoDocumento.GlosaViajeGrupo
                                                rowAsiento("GlosaImprime") = "ASIENTO " & .oeMovimientoDocumento.Compra.TipoDoc.Abreviatura & "/" & .oeMovimientoDocumento.Serie & .oeMovimientoDocumento.Numero & " " & .Proveedor
                                            End If
                                            rowAsiento("Fecha") = fecAsiento
                                            rowAsiento("IdMoneda") = .IdMoneda
                                            rowAsiento("TipoCambio") = .TipoCambio
                                            rowAsiento("TotalDebe") = .Total
                                            rowAsiento("TotalHaber") = .Total
                                            rowAsiento("IdUsuarioBloquea") = ""
                                            rowAsiento("UsuarioCreacion") = .UsuarioCreacion
                                            rowAsiento("IdEstado") = "1CH00005"
                                            rowAsiento("IdAsientoExtorno") = ""
                                            rowAsiento("FechaCreacion") = .FechaCreacion
                                            rowAsiento("Activo") = True
                                            rowAsiento("NroAsientoImprime") = DBNull.Value
                                            rowAsiento("IdentificaAsiento") = DBNull.Value
                                            rowAsiento("IndRevision") = DBNull.Value
                                            rowAsiento("FechaRevision") = DBNull.Value
                                            rowAsiento("UsuarioRevision") = DBNull.Value
                                            rowAsiento("IndOrigen") = 7
                                            rowAsiento("UsuarioModificacion") = ""
                                            rowAsiento("FechaModificacion") = Date.Parse("01/01/1901")
                                            'rowAsiento("CodigoUnicoOperacion") = olFunGen.ObtenerCUOAsiento(rowAsiento("NroAsiento"), rowAsiento("IdTipoAsiento"))
                                            dt_ASI.Rows.Add(rowAsiento)
                                            lsNumeroIdAsiento += 1
                                            lsNumeroNroAsientoCompra += 1

                                            ''asiento movimientodocumento
                                            rowAsientoMovDoc = dt_ASIMOVDOC.NewRow
                                            rowAsientoMovDoc("Id") = lsPrefijoAsientoMovDoc + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovDoc.ToString, 9)
                                            rowAsientoMovDoc("IdAsiento") = rowAsiento("Id")
                                            rowAsientoMovDoc("IdMovimientoDocumento") = rowMovDoc("Id")
                                            rowAsientoMovDoc("Activo") = True
                                            dt_ASIMOVDOC.Rows.Add(rowAsientoMovDoc)
                                            lsNumeroIdAsientoMovDoc += 1

                                            ''asientomovimiento flujo
                                            rowAsiMovFlu = dt_ASIMOV.NewRow
                                            rowAsiMovFlu("Id") = lsPrefijoAsientoMovimiento + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                            rowAsiMovFlu("IdAsiento") = rowAsiento("Id")
                                            If .oeFlujoCaja.CtaContable = "" Then Throw New Exception("Flujo Caja sin Cuenta Contable. Verificar")
                                            rowAsiMovFlu("IdCuentaContable") = .oeFlujoCaja.CtaContable
                                            rowAsiMovFlu("Glosa") = rowAsiento("Glosa")
                                            rowAsiMovFlu("DebeMN") = .SubTotal + .oeMovimientoDocumento.NoGravado
                                            rowAsiMovFlu("HaberMN") = 0
                                            rowAsiMovFlu("DebeME") = (.SubTotal + .oeMovimientoDocumento.NoGravado) / .TipoCambio
                                            rowAsiMovFlu("HaberME") = 0
                                            rowAsiMovFlu("IdUsuarioCrea") = .UsuarioCreacion
                                            rowAsiMovFlu("FechaCreacion") = .FechaCreacion
                                            rowAsiMovFlu("Activo") = True
                                            rowAsiMovFlu("NroLinea") = 1
                                            dt_ASIMOV.Rows.Add(rowAsiMovFlu)
                                            lsNumeroIdAsientoMovimiento += 1

                                            ''movimiento analisis

                                            rowMovAna = dt_MOVANA.NewRow
                                            rowMovAna("Id") = lsPrefijoMovAna & olFunGen.CompletaConCeros(lsNumeroIdMovAna.ToString, 13)
                                            rowMovAna("IdCentroCosto") = DBNull.Value
                                            rowMovAna("IdItemGasto") = .oeFlujoCaja.IdItemGasto
                                            rowMovAna("IdTrabajador") = IIf(.TipoMovimiento = 2, .oeGasto_Caja.IdTrabajador, "")
                                            rowMovAna("IdVehiculo") = IIf(.TipoMovimiento = 2, .oeGasto_Caja.IdPlaca, .IdTracto)
                                            rowMovAna("IdRuta") = DBNull.Value
                                            rowMovAna("IdBanco") = DBNull.Value
                                            rowMovAna("IdAnalisis1") = DBNull.Value
                                            rowMovAna("IdAnalisis2") = DBNull.Value
                                            rowMovAna("Activo") = 1
                                            rowMovAna("IdAsientoMovimiento") = rowAsiMovFlu("Id")
                                            rowMovAna("Monto") = .SubTotal + .oeMovimientoDocumento.NoGravado
                                            rowMovAna("Saldo") = .SubTotal + .oeMovimientoDocumento.NoGravado
                                            rowMovAna("IdMovimientoAnalisis") = DBNull.Value
                                            If .TipoMovimiento = 2 Then
                                                rowMovAna("IdGastoFuncion") = .oeGasto_Caja.IdGastoFuncion
                                            Else
                                                rowMovAna("IdGastoFuncion") = .oeMovimientoDocumento.MovimientoAnalisis(0).IdGastoFuncion
                                            End If
                                            rowMovAna("IdOrigenProrrateo") = ""
                                            dt_MOVANA.Rows.Add(rowMovAna)
                                            lsNumeroIdMovAna += 1
                                            If .IGV > 0 Then
                                                rowAsiMovFlu = dt_ASIMOV.NewRow
                                                rowAsiMovFlu("Id") = lsPrefijoAsientoMovimiento + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                                rowAsiMovFlu("IdAsiento") = rowAsiento("Id")
                                                oeCombo = New e_Combo
                                                oeCombo.Descripcion = .Ejercicio.ToString
                                                oeCombo.Nombre = "40111"
                                                oeCombo.Tipo = 4
                                                If loCuentasContables.Contains(oeCombo) Then
                                                    oeCombo = loCuentasContables.Item(loCuentasContables.IndexOf(oeCombo))
                                                Else
                                                    Throw New Exception("Error en Cuenta Contable. Verificar")
                                                End If
                                                rowAsiMovFlu("IdCuentaContable") = oeCombo.Id
                                                rowAsiMovFlu("Glosa") = rowAsiento("Glosa")
                                                rowAsiMovFlu("DebeMN") = .IGV
                                                rowAsiMovFlu("HaberMN") = 0
                                                rowAsiMovFlu("DebeME") = .IGV / .TipoCambio
                                                rowAsiMovFlu("HaberME") = 0
                                                rowAsiMovFlu("IdUsuarioCrea") = .UsuarioCreacion
                                                rowAsiMovFlu("FechaCreacion") = .FechaCreacion
                                                rowAsiMovFlu("Activo") = True
                                                rowAsiMovFlu("NroLinea") = 2
                                                dt_ASIMOV.Rows.Add(rowAsiMovFlu)
                                                lsNumeroIdAsientoMovimiento += 1
                                            End If
                                            rowAsiMovFlu = dt_ASIMOV.NewRow
                                            rowAsiMovFlu("Id") = lsPrefijoAsientoMovimiento + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                            rowAsiMovFlu("IdAsiento") = rowAsiento("Id")
                                            If .IndGasto = 0 Then
                                                oeCombo = New e_Combo
                                                oeCombo.Descripcion = .Ejercicio.ToString
                                                oeCombo.Nombre = "42121"
                                                oeCombo.Tipo = 4
                                            Else
                                                oeCombo = New e_Combo
                                                oeCombo.Descripcion = .Ejercicio.ToString
                                                oeCombo.Nombre = "18912"
                                                oeCombo.Tipo = 4
                                            End If
                                            If loCuentasContables.Contains(oeCombo) Then
                                                oeCombo = loCuentasContables.Item(loCuentasContables.IndexOf(oeCombo))
                                            Else
                                                Throw New Exception("Error en Cuenta Contable. Verificar")
                                            End If
                                            rowAsiMovFlu("IdCuentaContable") = oeCombo.Id
                                            rowAsiMovFlu("Glosa") = rowAsiento("Glosa")
                                            rowAsiMovFlu("DebeMN") = 0
                                            rowAsiMovFlu("HaberMN") = .Total
                                            rowAsiMovFlu("DebeME") = 0
                                            rowAsiMovFlu("HaberME") = .Total / .TipoCambio
                                            rowAsiMovFlu("IdUsuarioCrea") = .UsuarioCreacion
                                            rowAsiMovFlu("FechaCreacion") = .FechaCreacion
                                            rowAsiMovFlu("Activo") = True
                                            rowAsiMovFlu("NroLinea") = IIf(.IGV > 0, 3, 2)
                                            dt_ASIMOV.Rows.Add(rowAsiMovFlu)
                                            lsNumeroIdAsientoMovimiento += 1

                                            ''asientomovimiento movimientodocumento
                                            rowAsientoMovMovDoc = dt_ASIMOVMOVDOC.NewRow
                                            rowAsientoMovMovDoc("Id") = lsPrefijoAsientoMovimientoMovDoc + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovimientoMovDoc.ToString, 9)
                                            rowAsientoMovMovDoc("IdMovimientoDocumento") = rowMovDoc("Id")
                                            rowAsientoMovMovDoc("IdAsientoMovimiento") = rowAsiMovFlu("Id")
                                            rowAsientoMovMovDoc("IdCuentaxCyP") = DBNull.Value
                                            rowAsientoMovMovDoc("Activo") = True
                                            rowAsientoMovMovDoc("UsuarioCreacion") = .UsuarioCreacion
                                            rowAsientoMovMovDoc("FechaCreacion") = .FechaCreacion
                                            dt_ASIMOVMOVDOC.Rows.Add(rowAsientoMovMovDoc)

                                            lsNumeroIdAsientoMovimientoMovDoc += 1
                                        End If
                                    End If
                                End If

                                If .IdTipoDocumento <> "1SI000000001" And .IndGasto = 0 Then
                                    'asiento pago

                                    rowAsiento = dt_ASI.NewRow
                                    rowAsiento("Id") = lsPrefijoAsiento.ToString + olFunGen.CompletaConCeros(lsNumeroIdAsiento.ToString, 12)
                                    rowAsiento("IdPeriodo") = .IdPeriodo
                                    rowAsiento("IdTipoAsiento") = "1CH000017"
                                    rowAsiento("NroAsiento") = lsPrefijoNroAsientoCaja + olFunGen.CompletaConCeros(lsNumeroNroAsientoCaja, 7).ToString
                                    rowAsiento("Fecha") = fecAsiento
                                    rowAsiento("Glosa") = "PAGO " & .oeMovimientoDocumento.Compra.TipoDoc.Abreviatura & "/" & .oeMovimientoDocumento.Serie & .oeMovimientoDocumento.Numero & " " & .Proveedor + " V,G:" + .oeMovimientoDocumento.GlosaViajeGrupo
                                    rowAsiento("GlosaImprime") = "PAGO " & .oeMovimientoDocumento.Compra.TipoDoc.Abreviatura & "/" & .oeMovimientoDocumento.Serie & .oeMovimientoDocumento.Numero & " " & .Proveedor
                                    rowAsiento("IdMoneda") = .IdMoneda
                                    rowAsiento("TipoCambio") = .TipoCambio
                                    rowAsiento("TotalDebe") = .Total
                                    rowAsiento("TotalHaber") = .Total
                                    rowAsiento("IdUsuarioBloquea") = ""
                                    rowAsiento("UsuarioCreacion") = .UsuarioCreacion
                                    rowAsiento("IdEstado") = "1CH00005"
                                    rowAsiento("IdAsientoExtorno") = ""
                                    rowAsiento("FechaCreacion") = .FechaCreacion
                                    rowAsiento("Activo") = True
                                    rowAsiento("NroAsientoImprime") = DBNull.Value
                                    rowAsiento("IdentificaAsiento") = DBNull.Value
                                    rowAsiento("IndRevision") = DBNull.Value
                                    rowAsiento("FechaRevision") = DBNull.Value
                                    rowAsiento("UsuarioRevision") = DBNull.Value
                                    rowAsiento("IndOrigen") = 14
                                    rowAsiento("UsuarioModificacion") = ""
                                    rowAsiento("FechaModificacion") = Date.Parse("01/01/1901")
                                    'rowAsiento("CodigoUnicoOperacion") = olFunGen.ObtenerCUOAsiento(rowAsiento("NroAsiento"), rowAsiento("IdTipoAsiento"))
                                    dt_ASI.Rows.Add(rowAsiento)
                                    lsNumeroIdAsiento += 1
                                    lsNumeroNroAsientoCaja += 1

                                    ''asiento movimiento 42

                                    rowAsiMovFlu = dt_ASIMOV.NewRow
                                    rowAsiMovFlu("Id") = lsPrefijoAsientoMovimiento + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                    rowAsiMovFlu("IdAsiento") = rowAsiento("Id")
                                    oeCombo = New e_Combo
                                    oeCombo.Descripcion = .Ejercicio.ToString
                                    oeCombo.Nombre = "42121"
                                    oeCombo.Tipo = 4
                                    If loCuentasContables.Contains(oeCombo) Then
                                        oeCombo = loCuentasContables.Item(loCuentasContables.IndexOf(oeCombo))
                                    Else
                                        Throw New Exception("Error en Cuenta Contable. Verificar")
                                    End If
                                    rowAsiMovFlu("IdCuentaContable") = oeCombo.Id
                                    rowAsiMovFlu("Glosa") = rowAsiento("Glosa")
                                    rowAsiMovFlu("DebeMN") = .Total
                                    rowAsiMovFlu("HaberMN") = 0
                                    rowAsiMovFlu("DebeME") = .Total / .TipoCambio
                                    rowAsiMovFlu("HaberME") = 0
                                    rowAsiMovFlu("IdUsuarioCrea") = .UsuarioCreacion
                                    rowAsiMovFlu("FechaCreacion") = .FechaCreacion
                                    rowAsiMovFlu("Activo") = True
                                    rowAsiMovFlu("NroLinea") = 1
                                    dt_ASIMOV.Rows.Add(rowAsiMovFlu)
                                    lsNumeroIdAsientoMovimiento += 1

                                    ''asientomovimiento movimientodocumento
                                    rowAsientoMovMovDoc = dt_ASIMOVMOVDOC.NewRow
                                    rowAsientoMovMovDoc("Id") = lsPrefijoAsientoMovimientoMovDoc + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovimientoMovDoc.ToString, 9)
                                    rowAsientoMovMovDoc("IdMovimientoDocumento") = IIf(.oeGasto_Caja.IndCompraAlmacen, .oeMovimientoDocumento.Id, rowMovDoc("Id"))
                                    rowAsientoMovMovDoc("IdAsientoMovimiento") = rowAsiMovFlu("Id")
                                    rowAsientoMovMovDoc("IdCuentaxCyP") = lsPrefijoMovCajaBanco + olFunGen.CompletaConCeros(lsNumeroIdCtaxCyP.ToString, 12)
                                    rowAsientoMovMovDoc("Activo") = True
                                    rowAsientoMovMovDoc("UsuarioCreacion") = .UsuarioCreacion
                                    rowAsientoMovMovDoc("FechaCreacion") = .FechaCreacion
                                    dt_ASIMOVMOVDOC.Rows.Add(rowAsientoMovMovDoc)
                                    lsNumeroIdAsientoMovimientoMovDoc += 1

                                    ''asiento movimiento 10

                                    rowAsiMov10 = dt_ASIMOV.NewRow
                                    rowAsiMov10("Id") = lsPrefijoAsientoMovimiento + olFunGen.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                    rowAsiMov10("IdAsiento") = rowAsiento("Id")
                                    oeCombo = New e_Combo
                                    oeCombo.Descripcion = .Ejercicio.ToString
                                    oeCombo.Nombre = "10211"
                                    oeCombo.Tipo = 4
                                    If loCuentasContables.Contains(oeCombo) Then
                                        oeCombo = loCuentasContables.Item(loCuentasContables.IndexOf(oeCombo))
                                    Else
                                        Throw New Exception("Error en Cuenta Contable. Verificar")
                                    End If
                                    rowAsiMov10("IdCuentaContable") = oeCombo.Id
                                    rowAsiMov10("Glosa") = rowAsiento("Glosa")
                                    rowAsiMov10("DebeMN") = 0
                                    rowAsiMov10("HaberMN") = .Total
                                    rowAsiMov10("DebeME") = 0
                                    rowAsiMov10("HaberME") = .Total / .TipoCambio
                                    rowAsiMov10("IdUsuarioCrea") = .UsuarioCreacion
                                    rowAsiMov10("FechaCreacion") = .FechaCreacion
                                    rowAsiMov10("Activo") = True
                                    rowAsiMov10("NroLinea") = 2
                                    dt_ASIMOV.Rows.Add(rowAsiMov10)
                                    lsNumeroIdAsientoMovimiento += 1

                                    ''movimiento caja banco
                                    rowMovCajBan = dt_MOVCJB.NewRow
                                    rowMovCajBan("Id") = lsPrefijoMovCajaBanco + olFunGen.CompletaConCeros(lsNumeroIdMovCajaBanco.ToString, 13)
                                    rowMovCajBan("IdFlujoCaja") = .IdFlujoCaja
                                    rowMovCajBan("NroBoucher") = String.Empty
                                    rowMovCajBan("IdCuentaBancaria") = String.Empty
                                    rowMovCajBan("Fecha") = .FechaEmision
                                    rowMovCajBan("IdTipoDocumento") = "1CH03"
                                    rowMovCajBan("IdPeriodoConcilia") = ""
                                    rowMovCajBan("Activo") = True
                                    rowMovCajBan("IdAsientoMovimiento") = rowAsiMov10("Id")
                                    rowMovCajBan("TipoCambio") = .TipoCambio
                                    rowMovCajBan("TotalMN") = .Total
                                    rowMovCajBan("TotalME") = .Total / .TipoCambio
                                    rowMovCajBan("Operador") = -1
                                    rowMovCajBan("NroImpresion") = String.Empty
                                    rowMovCajBan("IdTipoGasto") = DBNull.Value
                                    dt_MOVCJB.Rows.Add(rowMovCajBan)
                                    lsNumeroIdMovCajaBanco += 1

                                    ''cta x c y p
                                    rowCtaxCP = dt_CTAXCP.NewRow
                                    rowCtaxCP("Id") = lsPrefijoMovCajaBanco + olFunGen.CompletaConCeros(lsNumeroIdCtaxCyP.ToString, 12)
                                    rowCtaxCP("IdMovimientoCajaBanco") = rowMovCajBan("Id")
                                    rowCtaxCP("IdMovimientoDocumento") = IIf(.oeGasto_Caja.IndCompraAlmacen, .oeMovimientoDocumento.Id, rowMovDoc("Id"))
                                    rowCtaxCP("Fecha") = .FechaCreacion
                                    rowCtaxCP("MontoMN") = .Total
                                    rowCtaxCP("MontoME") = .Total / .TipoCambio
                                    rowCtaxCP("Activo") = True
                                    rowCtaxCP("UsuarioCreacion") = .UsuarioCreacion
                                    rowCtaxCP("FechaCreacion") = .FechaCreacion
                                    rowCtaxCP("MacPCLocalCreacion") = String.Empty
                                    rowCtaxCP("IdCuentaCorriente") = DBNull.Value
                                    rowCtaxCP("IndCargoAbono") = DBNull.Value
                                    dt_CTAXCP.Rows.Add(rowCtaxCP)
                                    lsNumeroIdCtaxCyP += 1
                                End If
                            End If
                        End With
                    Next
                End If
                If Not odGastoOperacion.GuardaMasivo(loGastoOperacionMasiva, dt_MD, dt_DD, dt_CMP, dt_ASI, dt_ASIMOV, dt_MOVANA, dt_MOVCJB,
                                                     dt_ASIMOVDOC, dt_ASIMOVMOVDOC, dt_CTAXCP) Then
                    Return False
                End If
                'Actualizacion masiva de IndGuardado en TarjetaMovimiento
                If loGastoOperacionMasiva.Count > 0 Then
                    Dim XML As New StringBuilder
                    XML.AppendLine("<DETALLES>")
                    For Each _Movimiento As e_GastoOperacion In loGastoOperacionMasiva
                        With _Movimiento
                            XML.AppendLine("<DETALLE><Id>" & _Movimiento.IdTarjetaMovimiento & "</Id>")
                            XML.AppendLine("<IdGastoOperacion>" & IIf(_Movimiento.TipoOperacion = "E", "", _Movimiento.Id) & "</IdGastoOperacion>")
                            XML.AppendLine("<IndIngresado>" & IIf(_Movimiento.TipoOperacion = "E", 0, 1) & "</IndIngresado></DETALLE>")
                        End With
                    Next
                    XML.AppendLine("</DETALLES>")
                    Dim olTarjetaMovimiento As New l_TarjetaMovimiento
                    olTarjetaMovimiento.ActualizarMasivo(XML.ToString, PrefijoID)
                End If
                'If Not GuardarLista(loGastoOperacion) Then
                '    Return False
                'End If
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeGastoOperacion As EntidadesWCF.e_GastoOperacion) As System.Collections.Generic.List(Of EntidadesWCF.e_GastoOperacion) Implements Il_GastoOperacion.Listar
        Try
            Return odGastoOperacion.Listar(oeGastoOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGastoOperacion As EntidadesWCF.e_GastoOperacion) As EntidadesWCF.e_GastoOperacion Implements Il_GastoOperacion.Obtener
        Try
            Return odGastoOperacion.Obtener(oeGastoOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
