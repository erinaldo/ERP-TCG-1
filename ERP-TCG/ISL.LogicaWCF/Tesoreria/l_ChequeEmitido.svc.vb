' NOTA: si cambia aquí el nombre de clase "l_ChequeEmitido", también debe actualizar la referencia a "l_ChequeEmitido" tanto en Web.config como en el archivo .svc asociado.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_ChequeEmitido
    Implements Il_ChequeEmitido

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
    Dim odMovimientoAnalisis As New d_MovimientoAnalisis
    Dim olMovimientoAnalisis As New l_MovimientoAnalisis
    Dim olFuncionesGenerales As New l_FuncionesGenerales

    Dim odChequeEmitido As New d_ChequeEmitido

    Public Function Obtener(ByVal oeChequeEmitido As e_ChequeEmitido) As e_ChequeEmitido Implements Il_ChequeEmitido.Obtener
        Try
            Return odChequeEmitido.Obtener(oeChequeEmitido)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeChequeEmitido As e_ChequeEmitido) As List(Of e_ChequeEmitido) Implements Il_ChequeEmitido.Listar
        Try
            Return odChequeEmitido.Listar(oeChequeEmitido)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeChequeEmitido As e_ChequeEmitido) As Boolean Implements Il_ChequeEmitido.Validar
        Try
            With oeChequeEmitido
                If oeChequeEmitido.Importe = 0 Then
                    Throw New Exception("El Monto del Cheque Tiene que ser Mayor 0")
                End If
                If oeChequeEmitido.IdCuentaBancaria = "" Then
                    Throw New Exception("Ingrese Cuenta Bancaria del Cheque")
                End If
                If oeChequeEmitido.NroCheque = "" Then
                    Throw New Exception("Ingrese el Numero del Cheque")
                End If
                If CInt(oeChequeEmitido.NroCheque) = 0 Then
                    Throw New Exception("Ingrese el Numero del Cheque")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeChequeEmitido As e_ChequeEmitido, loCtaCtbleConcepto As List(Of e_CtaCtble_Concepto), loCtactble As List(Of e_Combo)) As Boolean Implements Il_ChequeEmitido.Guardar
        Try
            'datatables
            Dim dt_ASI As Data.DataTable = olAsiento.CrearDT()
            Dim dt_ASIMOV As Data.DataTable = olAsientoMovimiento.CrearDT()
            Dim dt_ASIMOVMOVDOC As Data.DataTable = olAsientoMovimientoMovDoc.CrearDT()
            Dim dt_MOVCJB As Data.DataTable = olMovCajaBanco.CrearDT()
            Dim dt_CTAXCP As Data.DataTable = olCtaCxP.CrearDT()
            Dim oeCombo As e_Combo
            Using TransScope As New TransactionScope()
                If Validar(oeChequeEmitido) Then
                    If odChequeEmitido.Guardar(oeChequeEmitido) Then
                        If loCtaCtbleConcepto.Count > 0 Then
                            'asiento
                            Dim IdAsiento As String = odAsiento.UltimoIdInserta(oeChequeEmitido.PrefijoID)
                            Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
                            Dim lsNumeroIdAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))
                            'nroasiento
                            Dim NroAsientoCompra As String = odAsiento.UltimoNroAsiento("1CH000016", oeChequeEmitido.oePeriodo.Id, "1", oeChequeEmitido.PrefijoID)
                            Dim lsPrefijoNroAsientoCompra As String = Left(NroAsientoCompra, 2)
                            Dim lsNumeroNroAsientoCompra As Integer = CInt(Right(NroAsientoCompra, Len(NroAsientoCompra) - 2))
                            'asientmov
                            Dim IdAsientoMovimiento As String = odAsientoMovimiento.UltimoIdInsertar(oeChequeEmitido.PrefijoID)
                            Dim lsPrefijoAsientoMovimiento As String = Left(IdAsientoMovimiento, 3)
                            Dim lsNumeroIdAsientoMovimiento As Integer = CInt(Right(IdAsientoMovimiento, Len(IdAsientoMovimiento) - 3))
                            'cta x c y p
                            Dim IdCtaxCyP As String = odCtaCxP.UltimoIdInserta(oeChequeEmitido.PrefijoID)
                            Dim lsPrefijoIdCtaxCyP As String = Left(IdCtaxCyP, 3)
                            Dim lsNumeroIdCtaxCyP As Integer = CInt(Right(IdCtaxCyP, Len(IdCtaxCyP) - 3))
                            'asientomovimiento movdoc
                            Dim IdAsientoMovimientoMovDoc As String = odAsientoMovimientoMovDoc.UltimoIdInsertar(oeChequeEmitido.PrefijoID)
                            Dim lsPrefijoAsientoMovimientoMovDoc As String = Left(IdAsientoMovimientoMovDoc, 3)
                            Dim lsNumeroIdAsientoMovimientoMovDoc As Integer = CInt(Right(IdAsientoMovimientoMovDoc, Len(IdAsientoMovimientoMovDoc) - 3))
                            'movcajabanco
                            Dim IdMovimientoCajaBanco As String = odMovCajaBanco.UltimoIdInserta(oeChequeEmitido.PrefijoID)
                            Dim lsPrefijoMovCajaBanco As String = Left(IdMovimientoCajaBanco, 3)
                            Dim lsNumeroIdMovCajaBanco As Integer = CInt(Right(IdMovimientoCajaBanco, Len(IdMovimientoCajaBanco) - 3))

                            Dim rowAsiento As Data.DataRow
                            Dim rowAsiMovDebe As Data.DataRow
                            Dim rowAsiMovHaber As Data.DataRow
                            Dim rowMovCajBan As Data.DataRow

                            Dim rowAsientoMovMovDoc As Data.DataRow
                            Dim rowCtaxCP As Data.DataRow
                            Dim oeCtaCon As New e_CtaCtble_Concepto

                            With oeChequeEmitido

                                oeCtaCon = New e_CtaCtble_Concepto
                                oeCtaCon.IdConceptoIngresos = .IdConcepto
                                oeCtaCon.Tipo = 1
                                If loCtaCtbleConcepto.Contains(oeCtaCon) Then
                                    oeCtaCon = loCtaCtbleConcepto.Item(loCtaCtbleConcepto.IndexOf(oeCtaCon))
                                End If

                                rowAsiento = dt_ASI.NewRow
                                rowAsiento("Id") = lsPrefijoAsiento.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsiento.ToString, 12)
                                rowAsiento("IdPeriodo") = .oePeriodo.Id
                                rowAsiento("IdTipoAsiento") = "1CH000016"
                                rowAsiento("NroAsiento") = lsPrefijoNroAsientoCompra + olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsientoCompra, 7).ToString
                                rowAsiento("Fecha") = .FechaCobro
                                rowAsiento("Glosa") = "CHEQUE EMITIDO NRO: " & .NroCheque & " " & .Concepto & " / " & .Proveedor
                                rowAsiento("GlosaImprime") = "CHEQUE EMITIDO NRO: " & .NroCheque & " " & .Concepto & " / " & .Proveedor
                                rowAsiento("IdMoneda") = .IdMoneda
                                rowAsiento("TipoCambio") = .TipoCambio
                                rowAsiento("TotalDebe") = .Importe
                                rowAsiento("TotalHaber") = .Importe
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
                                rowAsiento("IndOrigen") = 16
                                rowAsiento("UsuarioModificacion") = ""
                                rowAsiento("FechaModificacion") = Date.Parse("01/01/1901")
                                dt_ASI.Rows.Add(rowAsiento)

                                rowAsiMovHaber = dt_ASIMOV.NewRow
                                rowAsiMovHaber("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                rowAsiMovHaber("IdAsiento") = rowAsiento("Id")
                                If .IdMoneda = "1CH01" Then
                                    oeCombo = New e_Combo
                                    oeCombo.Descripcion = .oePeriodo.Ejercicio
                                    oeCombo.Nombre = "10411"
                                    oeCombo.Tipo = 4
                                    If loCtactble.Contains(oeCombo) Then
                                        oeCombo = loCtactble.Item(loCtactble.IndexOf(oeCombo))
                                    Else
                                        Throw New Exception("Error en Cuenta Contable. Verificar")
                                    End If
                                    rowAsiMovHaber("IdCuentaContable") = oeCombo.Id
                                    rowAsiMovHaber("Glosa") = rowAsiento("Glosa")
                                    rowAsiMovHaber("DebeMN") = 0
                                    rowAsiMovHaber("HaberMN") = .Importe
                                    rowAsiMovHaber("DebeME") = 0
                                    rowAsiMovHaber("HaberME") = Math.Round((.Importe / .TipoCambio), 2)
                                Else
                                    oeCombo = New e_Combo
                                    oeCombo.Descripcion = .oePeriodo.Ejercicio
                                    oeCombo.Nombre = "10412"
                                    oeCombo.Tipo = 4
                                    If loCtactble.Contains(oeCombo) Then
                                        oeCombo = loCtactble.Item(loCtactble.IndexOf(oeCombo))
                                    Else
                                        Throw New Exception("Error en Cuenta Contable. Verificar")
                                    End If
                                    rowAsiMovHaber("IdCuentaContable") = oeCombo.Id
                                    rowAsiMovHaber("Glosa") = rowAsiento("Glosa")
                                    rowAsiMovHaber("DebeMN") = 0
                                    rowAsiMovHaber("HaberMN") = Math.Round((.Importe * .TipoCambio), 2)
                                    rowAsiMovHaber("DebeME") = 0
                                    rowAsiMovHaber("HaberME") = .Importe
                                End If
                                rowAsiMovHaber("IdUsuarioCrea") = .UsuarioCreacion
                                rowAsiMovHaber("FechaCreacion") = .FechaCreacion
                                rowAsiMovHaber("Activo") = True
                                rowAsiMovHaber("NroLinea") = IIf(.loChequeDocumento.Count > 0, .loChequeDocumento.Count + 1, 2)
                                dt_ASIMOV.Rows.Add(rowAsiMovHaber)
                                lsNumeroIdAsientoMovimiento += 1

                                rowMovCajBan = dt_MOVCJB.NewRow
                                rowMovCajBan("Id") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdMovCajaBanco.ToString, 13)
                                rowMovCajBan("IdFlujoCaja") = oeCtaCon.IdFlujoCaja
                                rowMovCajBan("NroBoucher") = .NroCheque
                                rowMovCajBan("IdCuentaBancaria") = .IdCuentaBancaria
                                rowMovCajBan("Fecha") = .Fecha
                                rowMovCajBan("IdTipoDocumento") = "1CH01"
                                rowMovCajBan("IdPeriodoConcilia") = ""
                                rowMovCajBan("Activo") = True
                                rowMovCajBan("IdAsientoMovimiento") = rowAsiMovHaber("Id")
                                rowMovCajBan("TipoCambio") = .TipoCambio
                                rowMovCajBan("TotalMN") = .Importe
                                rowMovCajBan("TotalME") = Math.Round((.Importe / .TipoCambio), 2)
                                rowMovCajBan("Operador") = -1
                                rowMovCajBan("NroImpresion") = String.Empty
                                rowMovCajBan("IdTipoGasto") = DBNull.Value
                                dt_MOVCJB.Rows.Add(rowMovCajBan)

                                If .loChequeDocumento.Count > 0 Then
                                    Dim i As Integer = 1
                                    For Each oe As e_ChequeDocumento In .loChequeDocumento
                                        rowAsiMovDebe = dt_ASIMOV.NewRow
                                        rowAsiMovDebe("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                        rowAsiMovDebe("IdAsiento") = rowAsiento("Id")
                                        rowAsiMovDebe("IdCuentaContable") = oeCtaCon.IdCuentaContable
                                        rowAsiMovDebe("Glosa") = "CHEQUE EMITIDO NRO: " & .NroCheque & " " & .Concepto & " / " & oe.Documento
                                        If .IdMoneda = "1CH01" Then
                                            rowAsiMovDebe("DebeMN") = Math.Round(.Importe, 2)
                                            rowAsiMovDebe("HaberMN") = 0
                                            rowAsiMovDebe("DebeME") = Math.Round((.Importe / .TipoCambio), 2)
                                            rowAsiMovDebe("HaberME") = 0
                                        Else
                                            rowAsiMovDebe("DebeMN") = Math.Round((.Importe * .TipoCambio), 2)
                                            rowAsiMovDebe("HaberMN") = 0
                                            rowAsiMovDebe("DebeME") = Math.Round(.Importe, 2)
                                            rowAsiMovDebe("HaberME") = 0
                                        End If
                                        rowAsiMovDebe("IdUsuarioCrea") = .UsuarioCreacion
                                        rowAsiMovDebe("FechaCreacion") = .FechaCreacion
                                        rowAsiMovDebe("Activo") = True
                                        rowAsiMovDebe("NroLinea") = i
                                        dt_ASIMOV.Rows.Add(rowAsiMovDebe)
                                        lsNumeroIdAsientoMovimiento += 1

                                        rowAsientoMovMovDoc = dt_ASIMOVMOVDOC.NewRow
                                        rowAsientoMovMovDoc("Id") = lsPrefijoAsientoMovimientoMovDoc + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimientoMovDoc.ToString, 9)
                                        rowAsientoMovMovDoc("IdMovimientoDocumento") = oe.IdMovimientoDocumento
                                        rowAsientoMovMovDoc("IdAsientoMovimiento") = rowAsiMovDebe("Id")
                                        rowAsientoMovMovDoc("IdCuentaxCyP") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdCtaxCyP.ToString, 12)
                                        rowAsientoMovMovDoc("Activo") = True
                                        rowAsientoMovMovDoc("UsuarioCreacion") = .UsuarioCreacion
                                        rowAsientoMovMovDoc("FechaCreacion") = .FechaCreacion
                                        dt_ASIMOVMOVDOC.Rows.Add(rowAsientoMovMovDoc)
                                        lsNumeroIdAsientoMovimientoMovDoc += 1

                                        rowCtaxCP = dt_CTAXCP.NewRow
                                        rowCtaxCP("Id") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdCtaxCyP.ToString, 12)
                                        rowCtaxCP("IdMovimientoCajaBanco") = rowMovCajBan("Id")
                                        rowCtaxCP("IdMovimientoDocumento") = oe.IdMovimientoDocumento
                                        rowCtaxCP("Fecha") = .FechaCreacion
                                        If .IdMoneda = "1CH01" Then
                                            rowCtaxCP("MontoMN") = Math.Round(.Importe, 2)
                                            rowCtaxCP("MontoME") = Math.Round((.Importe / .TipoCambio), 2)
                                        Else
                                            rowCtaxCP("MontoMN") = Math.Round((.Importe * .TipoCambio), 2)
                                            rowCtaxCP("MontoME") = Math.Round(.Importe, 2)
                                        End If
                                        rowCtaxCP("Activo") = True
                                        rowCtaxCP("UsuarioCreacion") = .UsuarioCreacion
                                        rowCtaxCP("FechaCreacion") = .FechaCreacion
                                        rowCtaxCP("MacPCLocalCreacion") = String.Empty
                                        rowCtaxCP("IdCuentaCorriente") = DBNull.Value
                                        rowCtaxCP("IndCargoAbono") = DBNull.Value
                                        dt_CTAXCP.Rows.Add(rowCtaxCP)
                                        lsNumeroIdCtaxCyP += 1
                                        i += 1
                                    Next
                                Else
                                    rowAsiMovDebe = dt_ASIMOV.NewRow
                                    rowAsiMovDebe("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                                    rowAsiMovDebe("IdAsiento") = rowAsiento("Id")
                                    rowAsiMovDebe("IdCuentaContable") = oeCtaCon.IdCuentaContable
                                    rowAsiMovDebe("Glosa") = rowAsiento("Glosa")
                                    If .IdMoneda = "1CH01" Then
                                        rowAsiMovDebe("DebeMN") = .Importe
                                        rowAsiMovDebe("HaberMN") = 0
                                        rowAsiMovDebe("DebeME") = Math.Round((.Importe / .TipoCambio), 2)
                                        rowAsiMovDebe("HaberME") = 0
                                    Else
                                        rowAsiMovDebe("DebeMN") = Math.Round((.Importe * .TipoCambio), 2)
                                        rowAsiMovDebe("HaberMN") = 0
                                        rowAsiMovDebe("DebeME") = .Importe
                                        rowAsiMovDebe("HaberME") = 0
                                    End If
                                    rowAsiMovDebe("IdUsuarioCrea") = .UsuarioCreacion
                                    rowAsiMovDebe("FechaCreacion") = .FechaCreacion
                                    rowAsiMovDebe("Activo") = True
                                    rowAsiMovDebe("NroLinea") = 1
                                    dt_ASIMOV.Rows.Add(rowAsiMovDebe)
                                    lsNumeroIdAsientoMovimiento += 1
                                End If
                            End With
                            If odChequeEmitido.GuardaMasivo(dt_ASI, dt_ASIMOV, dt_MOVCJB, dt_ASIMOVMOVDOC, dt_CTAXCP) Then
                                TransScope.Complete()
                            End If
                        Else
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

    Public Function Eliminar(ByVal oeChequeEmitido As e_ChequeEmitido) As Boolean Implements Il_ChequeEmitido.Eliminar
        Try
            Return odChequeEmitido.Eliminar(oeChequeEmitido)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class