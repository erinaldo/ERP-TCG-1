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
Public Class l_Grupo_Asiento
    Implements Il_Grupo_Asiento
    Dim odGrupo_Asiento As New d_Grupo_Asiento
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function GuardarAsiento(oeGrupoAsiento As e_Grupo_Asiento, oeAsiento As e_Asiento) As Boolean Implements Il_Grupo_Asiento.GuardarAsiento
        Try
            Dim oeAsientoMovimiento As New e_AsientoMovimiento
            Dim oeGruAsi As New e_Grupo_Asiento
            Dim loAsientoMovimiento As New List(Of e_AsientoMovimiento)
            Dim oeAsi As New e_Asiento
            Dim loAsiento As New List(Of e_Asiento)
            Dim ImporteTotal As Double = 0
            Dim olAsiento As New l_Asiento
            Using TransScope As New TransactionScope()
                ImporteTotal = Math.Round(oeGrupoAsiento.loGrupoAsiento.Sum(Function(item) item.ImporteTotal), 2)
                For Each asimod As e_AsientoModelo In oeGrupoAsiento.loAsientoModelo
                    asimod.PrefijoID = oeGrupoAsiento.PrefijoID '@0001
                    oeAsiento.PrefijoID = oeGrupoAsiento.PrefijoID '@0001
                    With oeAsiento
                        .TipoOperacion = "I" : .IdTipoAsiento = asimod.IdTipoAsiento : .NroAsiento = String.Empty
                        .Glosa = asimod.Nombre & " CON CHEQUE NRO: " & oeGrupoAsiento.NroCheque : .GlosaImprime = String.Empty
                        .IdMoneda = asimod.IdMoneda : .IdEstado = "CUADRADO" : oeAsiento.Activo = True
                        .TotalDebe = ImporteTotal : .TotalHaber = ImporteTotal
                    End With
                    For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle
                        asidet.PrefijoID = oeGrupoAsiento.PrefijoID '@0001
                        If asidet.Partida = "1" Then
                            For Each gruasi As e_Grupo_Asiento In oeGrupoAsiento.loGrupoAsiento
                                gruasi.PrefijoID = oeGrupoAsiento.PrefijoID '@0001
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                oeAsientoMovimiento.PrefijoID = oeGrupoAsiento.PrefijoID '@0001
                                With oeAsientoMovimiento
                                    .TipoOperacion = "I"
                                    .IdUsuarioCrea = oeAsiento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                    .IdCuentaContable = asidet.IdCuentaContable
                                    .Glosa = asidet.Titulo & " // GRUPO: " & gruasi.Codigo
                                    If asimod.IdMoneda = "1CH01" Then
                                        .DebeMN = Math.Round(gruasi.ImporteTotal, 2)
                                        .DebeME = Math.Round(gruasi.ImporteTotal / oeAsiento.TipoCambio, 2)
                                    Else
                                        .DebeME = Math.Round(gruasi.ImporteTotal, 2)
                                        .DebeMN = Math.Round(gruasi.ImporteTotal * oeAsiento.TipoCambio, 2)
                                    End If
                                    With .MovimientoCajaBanco
                                        .TipoOperacion = "I"
                                        .IdFlujoCaja = oeGrupoAsiento.IdFlujoCaja
                                        .NroBoucher = ""
                                        .IdCuentaBancaria = ""
                                        .Fecha = oeAsiento.Fecha
                                        .IdMedioPago = ""
                                        .Activo = True
                                        .TipoCambio = oeAsiento.TipoCambio
                                        .TotalMN = ImporteTotal
                                        .TotalME = Math.Round(ImporteTotal / oeAsiento.TipoCambio, 2)
                                        ._Operador = 1
                                        .PrefijoID = oeGrupoAsiento.PrefijoID '@0001
                                    End With
                                    oeGruAsi = New e_Grupo_Asiento
                                    oeGruAsi.PrefijoID = oeGrupoAsiento.PrefijoID '@0001
                                    With oeGruAsi
                                        .TipoOperacion = "I"
                                        .ImporteTotal = gruasi.ImporteTotal
                                        .IdGrupo = gruasi.IdGrupo
                                        .IdCheque = oeGrupoAsiento.IdCheque
                                        .UsuarioCreacion = oeAsiento.IdUsuarioCrea
                                        .Activo = True
                                    End With
                                    .GrupoAsiento = oeGruAsi
                                    If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                End With
                            Next
                        Else
                            oeAsientoMovimiento = New e_AsientoMovimiento
                            oeAsientoMovimiento.PrefijoID = oeGrupoAsiento.PrefijoID '@0001
                            With oeAsientoMovimiento
                                .TipoOperacion = "I"
                                .IdUsuarioCrea = oeAsiento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                .IdCuentaContable = asidet.IdCuentaContable
                                .Glosa = asidet.Titulo
                                If asimod.IdMoneda = "1CH01" Then
                                    .HaberMN = ImporteTotal
                                    .HaberME = Math.Round(ImporteTotal / oeAsiento.TipoCambio, 2)
                                Else
                                    .HaberME = ImporteTotal
                                    .HaberMN = Math.Round(ImporteTotal * oeAsiento.TipoCambio, 2)
                                End If
                                .Glosa = oeAsiento.Glosa
                                With .MovimientoCajaBanco
                                    .TipoOperacion = "I"
                                    .IdFlujoCaja = oeGrupoAsiento.IdFlujoCaja
                                    .NroBoucher = oeGrupoAsiento.NroCheque
                                    .IdCuentaBancaria = oeGrupoAsiento.IdCtaBancaria
                                    .Fecha = oeAsiento.Fecha
                                    .IdMedioPago = oeGrupoAsiento.IdTipoMedio
                                    .Activo = True
                                    .TipoCambio = oeAsiento.TipoCambio
                                    .TotalMN = ImporteTotal
                                    .TotalME = Math.Round(ImporteTotal, 2)
                                    ._Operador = -1
                                    .PrefijoID = oeGrupoAsiento.PrefijoID '@0001
                                End With
                                If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                            End With

                        End If
                    Next
                Next
                oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                loAsiento.Add(oeAsiento)
                If olAsiento.GuardarLista(loAsiento) Then
                    TransScope.Complete()
                End If
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(ByVal loGrupoAsiento As System.Collections.Generic.List(Of EntidadesWCF.e_Grupo_Asiento), ByVal obj As Object) As String Implements Il_Grupo_Asiento.GuardarLista
        Try
            'obj(0) Tipo de Asiento
            'obj(1) cuenta contable
            'obj(2) cuenta corriente
            'obj(3) moneda
            'obj(4) flujo de caja
            'obj(5) fecha de reembolso
            'obj(6) tipo de cambio
            'obj(7) importe soles
            'obj(8) importe dolares
            'obj(9) CHEQUE O TRANSF
            'obj(10) usuario
            'obj(11) MEDIO DE PAGO
            Dim ListaGrupos As String = ""
            For Each o_o As e_Grupo_Asiento In loGrupoAsiento
                ListaGrupos = ListaGrupos + o_o.Codigo + "-"
            Next

            Dim FechaReembolso As Date = obj(5)
            Dim oePeriodo As New e_Periodo
            Dim lePeriodo As New List(Of e_Periodo)
            Dim olPeriodo As New l_Periodo
            oePeriodo.Activo = True
            oePeriodo.Id = ""
            oePeriodo.Codigo = FechaReembolso.Year.ToString + "-" + FechaReembolso.Month.ToString
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            Dim oeAsiento As New e_Asiento
            With oeAsiento
                .TipoOperacion = "I"
                .IdPeriodo = lePeriodo(0).Id
                .IdTipoAsiento = obj(0)
                .Fecha = obj(5)
                .Glosa = "TRANSFERENCIA DE FONDOS DE LIQUIDACION NRO " & obj(9) + "/" + ListaGrupos
                .GlosaImprime = .Glosa
                .IdMoneda = obj(3)
                .TipoCambio = obj(6)
                If .IdMoneda = "1CH01" Then 'MONEDA DE OBLIGACION FINANCIERA
                    .TotalDebe = obj(7)
                    .TotalHaber = obj(7)
                Else
                    .TotalDebe = obj(8)
                    .TotalHaber = obj(8)
                End If
                .IdUsuarioCrea = obj(10)
                .IdEstado = "CUADRADO"
            End With

            '-----------------------------------------------------------
            '----------------------asiento movimiento-------------------------------------
            Dim oeAsientoMovimiento As New e_AsientoMovimiento
            Dim oeTCD As New e_TablaContableDet
            Dim odTCD As New d_TablaContableDet
            Dim IdCuentacontableFondo As String
            oeTCD.TipoOperacion = "N"
            oeTCD.Activo = True
            oeTCD.Nombre = "CUENTAS GENERALES"
            oeTCD.Texto1 = "CTAFONDOFIJOSOLES"
            oeTCD.Valor1 = FechaReembolso.Year
            oeTCD = odTCD.Listar(oeTCD)(0)
            IdCuentacontableFondo = oeTCD.Texto2
            Dim oeGrupoASiento As New e_Grupo_Asiento
            For Each o As e_Grupo_Asiento In loGrupoAsiento
                o.NroCheque = obj(9)
                o.IdCheque = obj(12)
                oeAsientoMovimiento = New e_AsientoMovimiento
                With oeAsientoMovimiento
                    .TipoOperacion = "I"
                    .IdCuentaContable = IdCuentacontableFondo
                    .Glosa = "TRANSFERENCIA DE FONDOS DE LIQUIDACION NRO " & o.Codigo
                    .HaberMN = 0
                    .HaberME = 0
                    .DebeMN = o.ImportePagar
                    .DebeME = o.ImportePagar / obj(6)
                    .IdUsuarioCrea = obj(10)
                    .Activo = True

                    With .MovimientoCajaBanco
                        .TipoOperacion = "I"
                        .IdFlujoCaja = obj(4)
                        .NroBoucher = ""
                        .IdCuentaBancaria = ""
                        .Fecha = obj(5)
                        .IdMedioPago = ""
                        .Activo = True
                        .TipoCambio = obj(6)
                        .TotalMN = o.ImportePagar
                        .TotalME = o.ImportePagar / obj(6)
                        ._Operador = 1
                    End With
                End With

                oeGrupoASiento = New e_Grupo_Asiento
                With oeGrupoASiento
                    .TipoOperacion = "I"
                    .ImporteTotal = o.ImportePagar
                    .IdGrupo = o.IdGrupo
                    .IdCheque = obj(12)
                    .UsuarioCreacion = obj(10)
                    .Activo = True
                End With
                oeAsientoMovimiento.GrupoAsiento = oeGrupoASiento
                oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            Next
            oeAsientoMovimiento = New e_AsientoMovimiento
            With oeAsientoMovimiento
                .TipoOperacion = "I"
                .IdCuentaContable = obj(1)
                .Glosa = "TRANSFERENCIA DE FONDOS DE LIQUIDACION NRO " & obj(9)
                .HaberMN = obj(7)
                .HaberME = obj(8)
                .DebeMN = 0
                .DebeME = 0
                .IdUsuarioCrea = obj(10)
                .Activo = True
                With .MovimientoCajaBanco
                    .TipoOperacion = "I"
                    .IdFlujoCaja = obj(4)
                    .NroBoucher = obj(9)
                    .IdCuentaBancaria = obj(2)
                    .Fecha = obj(5)
                    .IdMedioPago = obj(11)
                    .Activo = True
                    .TipoCambio = obj(6)
                    .TotalMN = obj(7)
                    .TotalME = obj(8)
                    ._Operador = -1
                End With
            End With
            oeAsiento.AsientoMovimiento.Add(oeAsientoMovimiento)
            Return odGrupo_Asiento.GuardarLista(loGrupoAsiento, oeAsiento)

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Obtener(ByVal oeGrupo_Asiento As EntidadesWCF.e_Grupo_Asiento) As EntidadesWCF.e_Grupo_Asiento Implements Il_Grupo_Asiento.Obtener
        Try
            Return odGrupo_Asiento.Obtener(oeGrupo_Asiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarLista(ByVal leGrupo_Asiento As System.Collections.Generic.List(Of EntidadesWCF.e_Grupo_Asiento), ByVal ldFechaOperacion As Date) As Boolean Implements Il_Grupo_Asiento.ValidarLista
        Try
            l_FuncionesGenerales.ValidarPeriodo("", gAreasSGI.Tesoreria, ldFechaOperacion, ldFechaOperacion.Year.ToString + "-" + ldFechaOperacion.Month.ToString)
            For Each obj As e_Grupo_Asiento In leGrupo_Asiento
                If obj.Fecha.Date > ldFechaOperacion.Date Then
                    Throw New Exception("La fecha de un grupo es mayor a la fecha de la operacion de reembolso")
                End If
                Dim oeGrupo As New e_Grupo
                Dim odGrupo As New d_Grupo
                oeGrupo.Id = obj.IdGrupo
                oeGrupo = odGrupo.Obtener(oeGrupo)
                If oeGrupo.IdEstado <> obj._IdEstado Then
                    Throw New Exception("El estado del grupo cambio")
                End If
                If oeGrupo.Saldo <> obj.Saldo Then
                    Throw New Exception("El estado del grupo cambio")
                End If
            Next

            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
