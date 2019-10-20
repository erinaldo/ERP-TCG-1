Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_Detraccion
    Implements Il_Detraccion

    Private odDetraccion As New d_Detraccion

    Public Function Obtener(ByVal oeDetraccion As e_Detraccion) As e_Detraccion Implements Il_Detraccion.Obtener
        Try
            Return odDetraccion.Obtener(oeDetraccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDetraccion As e_Detraccion) As List(Of e_Detraccion) Implements Il_Detraccion.Listar
        Try
            Return odDetraccion.Listar(oeDetraccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDetraccion As e_Detraccion) As Boolean Implements Il_Detraccion.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeDetraccion) Then
                bol_guardado = odDetraccion.Guardar(oeDetraccion)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetraccion As e_Detraccion) As Boolean Implements Il_Detraccion.Eliminar
        Try
            Return odDetraccion.Eliminar(oeDetraccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeDetraccion As e_Detraccion) As Boolean
        Try
            If oeDetraccion.TipoOperacion = "I" Then
                With oeDetraccion
                    If .loDetraccionDet.Count = 0 Then Throw New Exception("Ingrese Detalles")
                    If .Total = 0 Then Throw New Exception("El Total no Puede ser 0")
                    If .NroLote.Trim = "" Then Throw New Exception("Ingrese Lote")
                    If CInt(.NroLote) = 0 Then Throw New Exception("Ingrese Lote")
                    For Each oe As e_DetraccionDetalle In .loDetraccionDet
                        If oe.IdCtaCte_ProAdq.Trim = "" Then
                            Throw New Exception("La Empresa: " & oe.ClienteProveedor & " No Tiene CtaCte")
                        End If
                        If oe.Importe = 0 Then
                            Throw New Exception("La Empresa: " & oe.ClienteProveedor & " Tiene Importe 0")
                        End If
                        If oe.IdTipoOperacion = "" Then
                            Throw New Exception("La Empresa: " & oe.ClienteProveedor & " No Tiene Tipo Operacion")
                        End If
                    Next
                End With
            End If       
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarAsiento(oeDetraccion As e_Detraccion, loDetDetalle As List(Of e_DetraccionDetalle), loCtaCtble As List(Of e_Combo)) As Boolean Implements Il_Detraccion.GuardarAsiento
        Try
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
            Dim dt_ASI As Data.DataTable = olAsiento.CrearDT()
            Dim dt_ASIMOV As Data.DataTable = olAsientoMovimiento.CrearDT()
            Dim dt_ASIMOVMOVDOC As Data.DataTable = olAsientoMovimientoMovDoc.CrearDT()
            Dim dt_MOVCJB As Data.DataTable = olMovCajaBanco.CrearDT()
            Dim dt_CTAXCP As Data.DataTable = olCtaCxP.CrearDT()
            Dim oeCombo As e_Combo
            Using TransScope As New TransactionScope()
                If Not odDetraccion.Guardar(oeDetraccion) Then Return False

                Dim IdAsiento As String = odAsiento.UltimoIdInserta(oeDetraccion.PrefijoID)
                Dim lsPrefijoAsiento As String = Left(IdAsiento, 3)
                Dim lsNumeroIdAsiento As Integer = CInt(Right(IdAsiento, Len(IdAsiento) - 3))
                'nroasiento
                Dim NroAsientoCompra As String = odAsiento.UltimoNroAsiento("1CH000016", oeDetraccion.IdPeriodo, "1", oeDetraccion.PrefijoID)
                Dim lsPrefijoNroAsientoCompra As String = Left(NroAsientoCompra, 2)
                Dim lsNumeroNroAsientoCompra As Integer = CInt(Right(NroAsientoCompra, Len(NroAsientoCompra) - 2))
                'asientmov
                Dim IdAsientoMovimiento As String = odAsientoMovimiento.UltimoIdInsertar(oeDetraccion.PrefijoID)
                Dim lsPrefijoAsientoMovimiento As String = Left(IdAsientoMovimiento, 3)
                Dim lsNumeroIdAsientoMovimiento As Integer = CInt(Right(IdAsientoMovimiento, Len(IdAsientoMovimiento) - 3))
                'cta x c y p
                Dim IdCtaxCyP As String = odCtaCxP.UltimoIdInserta(oeDetraccion.PrefijoID)
                Dim lsPrefijoIdCtaxCyP As String = Left(IdCtaxCyP, 3)
                Dim lsNumeroIdCtaxCyP As Integer = CInt(Right(IdCtaxCyP, Len(IdCtaxCyP) - 3))
                'asientomovimiento movdoc
                Dim IdAsientoMovimientoMovDoc As String = odAsientoMovimientoMovDoc.UltimoIdInsertar(oeDetraccion.PrefijoID)
                Dim lsPrefijoAsientoMovimientoMovDoc As String = Left(IdAsientoMovimientoMovDoc, 3)
                Dim lsNumeroIdAsientoMovimientoMovDoc As Integer = CInt(Right(IdAsientoMovimientoMovDoc, Len(IdAsientoMovimientoMovDoc) - 3))
                'movcajabanco
                Dim IdMovimientoCajaBanco As String = odMovCajaBanco.UltimoIdInserta(oeDetraccion.PrefijoID)
                Dim lsPrefijoMovCajaBanco As String = Left(IdMovimientoCajaBanco, 3)
                Dim lsNumeroIdMovCajaBanco As Integer = CInt(Right(IdMovimientoCajaBanco, Len(IdMovimientoCajaBanco) - 3))

                Dim rowAsiento As Data.DataRow
                Dim rowAsiMovDebe As Data.DataRow
                Dim rowAsiMovHaber As Data.DataRow
                Dim rowMovCajBan As Data.DataRow
                Dim rowAsientoMovMovDoc As Data.DataRow
                Dim rowCtaxCP As Data.DataRow

                For Each oeDetDetalle As e_DetraccionDetalle In loDetDetalle
                    rowAsiento = dt_ASI.NewRow
                    rowAsiento("Id") = lsPrefijoAsiento.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsiento.ToString, 12)
                    rowAsiento("IdPeriodo") = oeDetraccion.IdPeriodo
                    rowAsiento("IdTipoAsiento") = "1CH000016"
                    rowAsiento("NroAsiento") = lsPrefijoNroAsientoCompra + olFuncionesGenerales.CompletaConCeros(lsNumeroNroAsientoCompra, 7).ToString
                    rowAsiento("Fecha") = oeDetDetalle.FechaPago
                    rowAsiento("Glosa") = "PAGO DETRACCION MASIVA F/" + oeDetDetalle.Serie + oeDetDetalle.Numero + " " + oeDetDetalle.ClienteProveedor
                    rowAsiento("GlosaImprime") = "PAGO DETRACCION MASIVA F/" + oeDetDetalle.Serie + oeDetDetalle.Numero + " " + oeDetDetalle.ClienteProveedor
                    rowAsiento("IdMoneda") = "1CH01"
                    rowAsiento("TipoCambio") = oeDetraccion.TipoCambio
                    rowAsiento("TotalDebe") = IIf(oeDetDetalle.IdMoneda = "1CH01", oeDetDetalle.Importe, Math.Round(oeDetDetalle.Importe / oeDetraccion.TipoCambio, 2))
                    rowAsiento("TotalHaber") = IIf(oeDetDetalle.IdMoneda = "1CH01", oeDetDetalle.Importe, Math.Round(oeDetDetalle.Importe / oeDetraccion.TipoCambio, 2))
                    rowAsiento("IdUsuarioBloquea") = ""
                    rowAsiento("UsuarioCreacion") = oeDetDetalle.UsuarioCreacion
                    rowAsiento("IdEstado") = "1CH00005"
                    rowAsiento("IdAsientoExtorno") = ""
                    rowAsiento("FechaCreacion") = oeDetDetalle.FechaCreacion
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
                    lsNumeroIdAsiento += 1
                    lsNumeroNroAsientoCompra += 1

                    rowAsiMovDebe = dt_ASIMOV.NewRow
                    rowAsiMovDebe("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                    rowAsiMovDebe("IdAsiento") = rowAsiento("Id")
                    rowAsiMovDebe("Glosa") = rowAsiento("Glosa")
                    'If oeDetDetalle.IdMoneda = "1CH01" Then
                    oeCombo = New e_Combo
                    oeCombo.Descripcion = oeDetraccion.Ejercicio
                    oeCombo.Nombre = "10411"
                    oeCombo.Tipo = 4
                    If loCtaCtble.Contains(oeCombo) Then
                        oeCombo = loCtaCtble.Item(loCtaCtble.IndexOf(oeCombo))
                    Else
                        Throw New Exception("Error en Cuenta Contable. Verificar")
                    End If
                    rowAsiMovDebe("IdCuentaContable") = oeCombo.Id
                    'Else
                    '    oeCombo = New e_Combo
                    '    oeCombo.Descripcion = oeDetraccion.Ejercicio
                    '    oeCombo.Nombre = "10412"
                    '    oeCombo.Tipo = 4
                    '    If loCtaCtble.Contains(oeCombo) Then
                    '        oeCombo = loCtaCtble.Item(loCtaCtble.IndexOf(oeCombo))
                    '    Else
                    '        Throw New Exception("Error en Cuenta Contable. Verificar")
                    '    End If
                    '    rowAsiMovDebe("IdCuentaContable") = oeCombo.Id
                    'End If
                    rowAsiMovDebe("DebeMN") = 0
                    rowAsiMovDebe("HaberMN") = oeDetDetalle.Importe
                    rowAsiMovDebe("DebeME") = 0
                    rowAsiMovDebe("HaberME") = Math.Round((oeDetDetalle.Importe / oeDetraccion.TipoCambio), 2)
                    rowAsiMovDebe("IdUsuarioCrea") = oeDetDetalle.UsuarioCreacion
                    rowAsiMovDebe("FechaCreacion") = oeDetDetalle.FechaCreacion
                    rowAsiMovDebe("Activo") = True
                    rowAsiMovDebe("NroLinea") = 1
                    dt_ASIMOV.Rows.Add(rowAsiMovDebe)
                    lsNumeroIdAsientoMovimiento += 1

                    rowMovCajBan = dt_MOVCJB.NewRow
                    rowMovCajBan("Id") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdMovCajaBanco.ToString, 13)
                    rowMovCajBan("IdFlujoCaja") = "1CH000000269"
                    rowMovCajBan("NroBoucher") = olFuncionesGenerales.CompletaConCeros(oeDetDetalle.Voucher, 10)
                    rowMovCajBan("IdCuentaBancaria") = oeDetraccion.IdCtaBancoSoles
                    rowMovCajBan("Fecha") = oeDetDetalle.FechaPago
                    rowMovCajBan("IdTipoDocumento") = "1CH05"
                    rowMovCajBan("IdPeriodoConcilia") = ""
                    rowMovCajBan("Activo") = True
                    rowMovCajBan("IdAsientoMovimiento") = rowAsiMovDebe("Id")
                    rowMovCajBan("TipoCambio") = oeDetraccion.TipoCambio
                    rowMovCajBan("TotalMN") = oeDetDetalle.Importe
                    rowMovCajBan("TotalME") = IIf(oeDetDetalle.IdMoneda = "1CH01", Math.Round((oeDetDetalle.Importe / oeDetraccion.TipoCambio), 2), Math.Round((oeDetDetalle.Importe / oeDetraccion.TipoCambio), 0))
                    rowMovCajBan("Operador") = -1
                    rowMovCajBan("NroImpresion") = String.Empty
                    rowMovCajBan("IdTipoGasto") = oeDetDetalle.IdTipoGasto
                    dt_MOVCJB.Rows.Add(rowMovCajBan)
                    lsNumeroIdMovCajaBanco += 1

                    rowAsiMovHaber = dt_ASIMOV.NewRow
                    rowAsiMovHaber("Id") = lsPrefijoAsientoMovimiento + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimiento.ToString, 13)
                    rowAsiMovHaber("IdAsiento") = rowAsiento("Id")
                    rowAsiMovHaber("Glosa") = rowAsiento("Glosa")
                    If oeDetDetalle.IdMoneda = "1CH01" Then
                        oeCombo = New e_Combo
                        oeCombo.Descripcion = oeDetraccion.Ejercicio
                        oeCombo.Nombre = oeDetDetalle.CtaContable
                        oeCombo.Tipo = 4
                        If loCtaCtble.Contains(oeCombo) Then
                            oeCombo = loCtaCtble.Item(loCtaCtble.IndexOf(oeCombo))
                        Else
                            Throw New Exception("Error en Cuenta Contable. Verificar")
                        End If
                        rowAsiMovHaber("IdCuentaContable") = oeCombo.Id
                    Else
                        oeCombo = New e_Combo
                        oeCombo.Descripcion = oeDetraccion.Ejercicio
                        oeCombo.Nombre = oeDetDetalle.CtaContable
                        oeCombo.Tipo = 4
                        If loCtaCtble.Contains(oeCombo) Then
                            oeCombo = loCtaCtble.Item(loCtaCtble.IndexOf(oeCombo))
                        Else
                            Throw New Exception("Error en Cuenta Contable. Verificar")
                        End If
                        rowAsiMovHaber("IdCuentaContable") = oeCombo.Id
                    End If
                    rowAsiMovHaber("DebeMN") = oeDetDetalle.Importe
                    rowAsiMovHaber("HaberMN") = 0
                    rowAsiMovHaber("DebeME") = Math.Round(oeDetDetalle.Importe / oeDetraccion.TipoCambio, 2)
                    rowAsiMovHaber("HaberME") = 0
                    rowAsiMovHaber("IdUsuarioCrea") = oeDetDetalle.UsuarioCreacion
                    rowAsiMovHaber("FechaCreacion") = oeDetDetalle.FechaCreacion
                    rowAsiMovHaber("Activo") = True
                    rowAsiMovHaber("NroLinea") = 2
                    dt_ASIMOV.Rows.Add(rowAsiMovHaber)
                    lsNumeroIdAsientoMovimiento += 1

                    rowAsientoMovMovDoc = dt_ASIMOVMOVDOC.NewRow
                    rowAsientoMovMovDoc("Id") = lsPrefijoAsientoMovimientoMovDoc + olFuncionesGenerales.CompletaConCeros(lsNumeroIdAsientoMovimientoMovDoc.ToString, 9)
                    rowAsientoMovMovDoc("IdMovimientoDocumento") = oeDetDetalle.IdMovimientoDocumento
                    rowAsientoMovMovDoc("IdAsientoMovimiento") = rowAsiMovHaber("Id")
                    rowAsientoMovMovDoc("IdCuentaxCyP") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdCtaxCyP.ToString, 12)
                    rowAsientoMovMovDoc("Activo") = True
                    rowAsientoMovMovDoc("UsuarioCreacion") = oeDetDetalle.UsuarioCreacion
                    rowAsientoMovMovDoc("FechaCreacion") = oeDetDetalle.FechaCreacion
                    dt_ASIMOVMOVDOC.Rows.Add(rowAsientoMovMovDoc)
                    lsNumeroIdAsientoMovimientoMovDoc += 1

                    rowCtaxCP = dt_CTAXCP.NewRow
                    rowCtaxCP("Id") = lsPrefijoMovCajaBanco + olFuncionesGenerales.CompletaConCeros(lsNumeroIdCtaxCyP.ToString, 12)
                    rowCtaxCP("IdMovimientoCajaBanco") = rowMovCajBan("Id")
                    rowCtaxCP("IdMovimientoDocumento") = oeDetDetalle.IdMovimientoDocumento
                    rowCtaxCP("Fecha") = oeDetDetalle.FechaPago
                    rowCtaxCP("MontoMN") = Math.Round(oeDetDetalle.Importe, 2)
                    rowCtaxCP("MontoME") = Math.Round((oeDetDetalle.Importe / oeDetraccion.TipoCambio), 2)
                    rowCtaxCP("Activo") = True
                    rowCtaxCP("UsuarioCreacion") = oeDetDetalle.UsuarioCreacion
                    rowCtaxCP("FechaCreacion") = oeDetDetalle.FechaCreacion
                    rowCtaxCP("MacPCLocalCreacion") = String.Empty
                    rowCtaxCP("IdCuentaCorriente") = DBNull.Value
                    rowCtaxCP("IndCargoAbono") = DBNull.Value
                    dt_CTAXCP.Rows.Add(rowCtaxCP)
                    lsNumeroIdCtaxCyP += 1
                Next
                odDetraccion.GuardaMasivo(dt_ASI, dt_ASIMOV, dt_MOVCJB, dt_ASIMOVMOVDOC, dt_CTAXCP)
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
