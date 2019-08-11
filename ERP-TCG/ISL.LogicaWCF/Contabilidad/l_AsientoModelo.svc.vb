Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_AsientoModelo

    Implements Il_AsientoModelo

    Dim odAsientoModelo As New d_AsientoModelo
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeAsiModActNeg As EntidadesWCF.e_AsientoModelo) As Boolean Implements Il_AsientoModelo.Eliminar
        Try
            Return odAsientoModelo.Eliminar(oeAsiModActNeg)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeAsiModActNeg As EntidadesWCF.e_AsientoModelo) As Boolean Implements Il_AsientoModelo.Guardar
        Try
            If Validar(oeAsiModActNeg) Then
                Return odAsientoModelo.Guardar(oeAsiModActNeg)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeAsiModActNeg As EntidadesWCF.e_AsientoModelo) As List(Of EntidadesWCF.e_AsientoModelo) Implements Il_AsientoModelo.Listar
        Try
            Return odAsientoModelo.Listar(oeAsiModActNeg)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeAsiModActNeg As EntidadesWCF.e_AsientoModelo) As EntidadesWCF.e_AsientoModelo Implements Il_AsientoModelo.Obtener
        Try
            Return odAsientoModelo.Obtener(oeAsiModActNeg)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeAsiModActNeg As EntidadesWCF.e_AsientoModelo) As Boolean Implements Il_AsientoModelo.Validar
        Try
            With oeAsiModActNeg
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "No ha Ingresado Abreviatura")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdMoneda, "No ha Seleccionado Tipo Moneda")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoAsiento, "No ha Seleccionado Tipo Asiento")
                If oeAsiModActNeg.leDetalle.Count = 0 Then Throw New Exception("No se ha Ingresado Detalles al Asiento Modelo")
                If oeAsiModActNeg.leAMActiviad.Count = 0 Then Throw New Exception("No se ha Referenciado el Asiento Modelo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ProvisionaBeneficios(oeAsientoModelo As e_AsientoModelo, oePeriodo As e_Periodo, leBeneficios As List(Of e_ProvisionBonificacion)) As Boolean Implements Il_AsientoModelo.ProvisionaBeneficios
        Try
            Using TransScope As New TransactionScope()
                Dim oeAsiento As New e_Asiento, olAsiento As New l_Asiento, oeAsientoMov As New e_AsientoMovimiento, oeMovAnalisis As New e_MovimientoAnalisis
                Dim _MontoAux As Double = 0, _MontoGen As Double = 0
                If l_FuncionesGenerales.ValidarPeriodo(oePeriodo.Id, gAreasSGI.Planilla, oeAsientoModelo.FechaMov, "") Then
                    With oeAsiento
                        .TipoOperacion = "I" : .IdPeriodo = oePeriodo.Id : .IdTipoAsiento = oeAsientoModelo.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = oeAsientoModelo.FechaMov
                        .Glosa = oeAsientoModelo.Nombre : .GlosaImprime = String.Empty
                        .IdMoneda = oeAsientoModelo.IdMoneda : .TipoCambio = oeAsientoModelo.TipoCambio
                        _MontoGen = Math.Round(leBeneficios.Sum(Function(it) it.Importe), 2)
                        .TotalDebe = _MontoGen : .TotalHaber = _MontoGen
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeAsientoModelo.UsuarioCreacion : oeAsiento.Activo = True
                        .IdentificaAsiento = oeAsientoModelo.Id
                        For Each _oeAsiModDet In oeAsientoModelo.leDetalle.OrderBy(Function(it) it.Fila.Trim).ToList
                            If _oeAsiModDet.Partida = 1 Then
                                ' Asiento Movimiento - Costo de Ventas
                                _MontoAux = Math.Round(leBeneficios.Where(Function(it) it.CentroCosto = "OPERACIONES").Sum(Function(it) it.Importe), 2)
                                If _MontoAux > 0 Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    With oeAsientoMov
                                        .TipoOperacion = "I" : .IdCuentaContable = _oeAsiModDet.IdCuentaContable.Trim : .Glosa = _oeAsiModDet.Titulo & " OPERATIVO"
                                        .DebeMN = _MontoAux : .DebeME = Math.Round(_MontoAux / oeAsientoModelo.TipoCambio, 2)
                                        .HaberMN = 0 : .HaberME = 0
                                        .IdUsuarioCrea = oeAsientoModelo.UsuarioCreacion : .Activo = True : .AsMov_MovDoc = Nothing
                                    End With
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                End If
                                ' Asiento Movimiento - Gasto Administrativo
                                _MontoAux = Math.Round(leBeneficios.Where(Function(it) it.CentroCosto = "ADMINISTRATIVO").Sum(Function(it) it.Importe), 2)
                                If _MontoAux > 0 Then
                                    oeAsientoMov = New e_AsientoMovimiento
                                    With oeAsientoMov
                                        .TipoOperacion = "I" : .IdCuentaContable = _oeAsiModDet.IdCuentaContable.Trim : .Glosa = _oeAsiModDet.Titulo & " ADMINISTRATIVO"
                                        .DebeMN = _MontoAux : .DebeME = Math.Round(_MontoAux / oeAsientoModelo.TipoCambio, 2)
                                        .HaberMN = 0 : .HaberME = 0
                                        .IdUsuarioCrea = oeAsientoModelo.UsuarioCreacion : .Activo = True : .AsMov_MovDoc = Nothing
                                    End With
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                End If
                            Else
                                oeAsientoMov = New e_AsientoMovimiento
                                With oeAsientoMov
                                    .TipoOperacion = "I" : .IdCuentaContable = _oeAsiModDet.IdCuentaContable.Trim : .Glosa = _oeAsiModDet.Titulo
                                    .DebeMN = 0 : .DebeME = 0
                                    .HaberMN = _MontoGen : .HaberME = Math.Round(_MontoGen / oeAsientoModelo.TipoCambio, 2)
                                    .IdUsuarioCrea = oeAsientoModelo.UsuarioCreacion : .Activo = True : .AsMov_MovDoc = Nothing
                                End With
                                For Each _oeBonoDet In leBeneficios.Where(Function(it) it.Importe > 0).ToList
                                    oeMovAnalisis = New e_MovimientoAnalisis
                                    oeMovAnalisis.TipoOperacion = ""
                                    oeMovAnalisis.IdMoneda = oeAsientoModelo.IdMoneda
                                    oeMovAnalisis.IdUsuarioCrea = oeAsientoModelo.UsuarioCreacion
                                    oeMovAnalisis.Monto = _oeBonoDet.Importe
                                    oeMovAnalisis.Saldo = _oeBonoDet.Importe
                                    oeMovAnalisis.IdTrabajador = _oeBonoDet.IdTrabajador
                                    oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                Next
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            End If
                        Next
                    End With
                    If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                        'odGratificacion.Guardar(oeGratificacion)
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
