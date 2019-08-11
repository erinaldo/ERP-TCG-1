Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_Gratificacion
    Implements Il_Gratificacion

    Private odGratificacion As New d_Gratificacion
    Private olDetalle As New l_DetalleGratificacion
    Private odDetalle As New d_DetalleGratificacion
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeGratificacion As EntidadesWCF.e_Gratificacion) As Boolean Implements Il_Gratificacion.Eliminar
        Try
            Return odGratificacion.Eliminar(oeGratificacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeGratificacion As EntidadesWCF.e_Gratificacion) As Boolean Implements Il_Gratificacion.Guardar
        Try
            If Validar(oeGratificacion) Then
                Return odGratificacion.Guardar(oeGratificacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeGratificacion As EntidadesWCF.e_Gratificacion) As List(Of EntidadesWCF.e_Gratificacion) Implements Il_Gratificacion.Listar
        Try
            Return odGratificacion.Listar(oeGratificacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeGratificacion As EntidadesWCF.e_Gratificacion) As EntidadesWCF.e_Gratificacion Implements Il_Gratificacion.Obtener
        Try
            Return odGratificacion.Obtener(oeGratificacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeGratificacion As EntidadesWCF.e_Gratificacion) As Boolean Implements Il_Gratificacion.Validar
        Try
            With oeGratificacion
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ImportarDatos(oeGratificacion As e_Gratificacion) As Boolean Implements Il_Gratificacion.ImportarDatos
        Try
            Dim dtDet As Data.DataTable = olDetalle.CrearDT()
            Dim id As String = odDetalle.UltimoIdInserta
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeDet In oeGratificacion.leDetalle
                Dim rwDet As Data.DataRow
                rwDet = dtDet.NewRow
                With oeDet
                    rwDet("Id") = lsPrefijo & olDetalle.CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwDet("IdBonoCompensatorio") = String.Empty
                    rwDet("IdTrabajador") = .IdTrabajador
                    rwDet("IdCentro") = .IdCentro
                    rwDet("IdArea") = .IdArea
                    rwDet("IdOcupacion") = .IdOcupacion
                    rwDet("IdCuentaCorriente") = .IdCuentaCorriente
                    rwDet("DatoApoyo") = .DatoApoyo
                    rwDet("IndTipoAux") = .IndTipoAux
                    rwDet("FechaIngreso") = .FechaIngreso
                    rwDet("TempIngreso") = .TempIngreso
                    rwDet("Sueldo") = .Sueldo
                    rwDet("AsignacionFamiliar") = .AsignacionFamiliar
                    rwDet("Renumeracion") = .Renumeracion
                    rwDet("HoraExtra1") = .HoraExtra1
                    rwDet("HoraExtra2") = .HoraExtra2
                    rwDet("HoraExtra3") = .HoraExtra3
                    rwDet("HoraExtra4") = .HoraExtra4
                    rwDet("HoraExtra5") = .HoraExtra5
                    rwDet("HoraExtra6") = .HoraExtra6
                    rwDet("IndPromExtra") = .IndPromExtra
                    rwDet("PromedioHoraExtra") = .PromedioHoraExtra
                    rwDet("Bono1") = .Bono1
                    rwDet("Bono2") = .Bono2
                    rwDet("Bono3") = .Bono3
                    rwDet("Bono4") = .Bono4
                    rwDet("Bono5") = .Bono5
                    rwDet("Bono6") = .Bono6
                    rwDet("IndPromedio") = .IndPromedio
                    rwDet("PromedioBono") = .PromedioBono
                    rwDet("Gratificacion") = .Gratificacion
                    rwDet("FraccionGrati") = .FraccionGrati
                    rwDet("RenumeracionComputable") = .RenumeracionComputable
                    rwDet("TiempoLaborado") = .TiempoLaborado
                    rwDet("DiasFaltas") = .DiasFaltas
                    rwDet("MesesFalta") = .MesesFalta
                    rwDet("PeriodoComputable") = .PeriodoComputable
                    rwDet("Importe") = .Importe
                    rwDet("BonoExtra") = .BonoExtra
                    rwDet("Total") = .Total
                    rwDet("DescuentosJudiciales") = .DescuentosJudiciales
                    rwDet("AdelantoSueldo") = .AdelantoSueldo
                    rwDet("TotalDescuento") = .TotalDescuento
                    rwDet("NetoTotal") = .NetoTotal
                    rwDet("FechaCreacion") = Date.Now
                    rwDet("UsuarioCreacion") = .UsuarioCreacion
                    rwDet("FechaModifica") = .FechaModifica
                    rwDet("UsuarioModifica") = .UsuarioModifica
                    rwDet("Activo") = True
                    rwDet("IndPendiente") = .IndPendiente
                End With
                dtDet.Rows.Add(rwDet)
                lsNumero = lsNumero + 1
            Next
            oeGratificacion.dtDetalle = dtDet
            Return odGratificacion.ImportarDatos(oeGratificacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Provisionar(oeGratificacion As e_Gratificacion, oeAsientoModel As e_AsientoModelo, oePeriodo As e_Periodo) As Boolean Implements Il_Gratificacion.Provisionar
        Try
            Using TransScope As New TransactionScope()
                Dim oeAsiento As New e_Asiento, olAsiento As New l_Asiento, oeAsientoMov As New e_AsientoMovimiento, oeMovAnalisis As New e_MovimientoAnalisis
                Dim _MontoAux As Double = 0, _MontoGen As Double = 0
                If l_FuncionesGenerales.ValidarPeriodo(oePeriodo.Id, gAreasSGI.Planilla, oeAsientoModel.FechaMov, "") Then
                    With oeAsiento
                        .TipoOperacion = "I" : .IdPeriodo = oePeriodo.Id : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = oeAsientoModel.FechaMov
                        .Glosa = oeAsientoModel.Nombre : .GlosaImprime = String.Empty
                        .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeAsientoModel.TipoCambio
                        _MontoGen = Math.Round(oeGratificacion.leDetalle.Where(Function(it) it.IndPendiente = 0).Sum(Function(it) it.NetoTotal), 2)
                        .TotalDebe = _MontoGen : .TotalHaber = _MontoGen
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeAsientoModel.UsuarioCreacion : oeAsiento.Activo = True
                        .IdentificaAsiento = oeAsientoModel.Id
                        For Each _oeAsiModDet In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila.Trim).ToList
                            If _oeAsiModDet.Partida = 1 Then
                                ' Asiento Movimiento - Costo de Ventas
                                _MontoAux = oeGratificacion.leDetalle.Where(Function(it) it.IndPendiente = 0 And (it.Area = "OPERACIONES" Or it.Area = "MANTENIMIENTO")).Sum(Function(it) it.NetoTotal)
                                If _MontoAux > 0 Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    With oeAsientoMov
                                        .TipoOperacion = "I" : .IdCuentaContable = _oeAsiModDet.IdCuentaContable.Trim : .Glosa = _oeAsiModDet.Titulo & " OPERATIVO"
                                        .DebeMN = _MontoAux : .DebeME = Math.Round(_MontoAux / oeAsientoModel.TipoCambio, 2)
                                        .HaberMN = 0 : .HaberME = 0
                                        .IdUsuarioCrea = oeAsientoModel.UsuarioCreacion : .Activo = True : .AsMov_MovDoc = Nothing
                                    End With
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                End If
                                ' Asiento Movimiento - Gasto Administrativo
                                _MontoAux = oeGratificacion.leDetalle.Where(Function(it) it.IndPendiente = 0 And (it.Area <> "OPERACIONES" And it.Area <> "MANTENIMIENTO")).Sum(Function(it) it.NetoTotal)
                                If _MontoAux > 0 Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    With oeAsientoMov
                                        .TipoOperacion = "I" : .IdCuentaContable = _oeAsiModDet.IdCuentaContable.Trim : .Glosa = _oeAsiModDet.Titulo & " ADMINISTRATIVO"
                                        .DebeMN = _MontoAux : .DebeME = Math.Round(_MontoAux / oeAsientoModel.TipoCambio, 2)
                                        .HaberMN = 0 : .HaberME = 0
                                        .IdUsuarioCrea = oeAsientoModel.UsuarioCreacion : .Activo = True : .AsMov_MovDoc = Nothing
                                    End With
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                End If
                            Else
                                oeAsientoMov = New e_AsientoMovimiento
                                With oeAsientoMov
                                    .TipoOperacion = "I" : .IdCuentaContable = _oeAsiModDet.IdCuentaContable.Trim : .Glosa = _oeAsiModDet.Titulo
                                    .DebeMN = 0 : .DebeME = 0
                                    .HaberMN = _MontoGen : .HaberME = Math.Round(_MontoGen / oeAsientoModel.TipoCambio, 2)
                                    .IdUsuarioCrea = oeAsientoModel.UsuarioCreacion : .Activo = True : .AsMov_MovDoc = Nothing
                                End With
                                For Each _oeBonoDet In oeGratificacion.leDetalle.Where(Function(it) it.IndPendiente = 0).ToList
                                    oeMovAnalisis = New e_MovimientoAnalisis
                                    oeMovAnalisis.TipoOperacion = ""
                                    oeMovAnalisis.IdMoneda = oeAsientoModel.IdMoneda
                                    oeMovAnalisis.IdUsuarioCrea = oeAsientoModel.UsuarioCreacion
                                    oeMovAnalisis.Monto = _oeBonoDet.NetoTotal
                                    oeMovAnalisis.Saldo = _oeBonoDet.NetoTotal
                                    oeMovAnalisis.IdTrabajador = _oeBonoDet.IdTrabajador
                                    oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                Next
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            End If
                        Next
                    End With
                    If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                        odGratificacion.Guardar(oeGratificacion)
                        TransScope.Complete()
                        Return True
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
