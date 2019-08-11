Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_Utilidad
    Implements Il_Utilidad

    Private odUtilidad As New d_Utilidad
    Private olConsolidado As New l_ConsolidadoUtilidad
    Private odConsolidado As New d_ConsolidadoUtilidad
    Private olDetalle As New l_DetalleUtilidad
    Private odDetalle As New d_DetalleUtilidad
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeUtilidad As EntidadesWCF.e_Utilidad) As Boolean Implements Il_Utilidad.Eliminar
        Try
            Return odUtilidad.Eliminar(oeUtilidad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeUtilidad As EntidadesWCF.e_Utilidad) As Boolean Implements Il_Utilidad.Guardar
        Try
            If Validar(oeUtilidad) Then
                Return odUtilidad.Guardar(oeUtilidad)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeUtilidad As EntidadesWCF.e_Utilidad) As List(Of EntidadesWCF.e_Utilidad) Implements Il_Utilidad.Listar
        Try
            Return odUtilidad.Listar(oeUtilidad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeUtilidad As EntidadesWCF.e_Utilidad) As EntidadesWCF.e_Utilidad Implements Il_Utilidad.Obtener
        Try
            Return odUtilidad.Obtener(oeUtilidad)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(oeUtilidad As EntidadesWCF.e_Utilidad) As Boolean Implements Il_Utilidad.Validar
        Try
            With oeUtilidad
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                If Not oeUtilidad.IndImportar AndAlso oeUtilidad.TipoOperacion = "I" Then
                    Dim oeUTi As New e_Utilidad
                    oeUTi.TipoOperacion = "1"
                    oeUTi.Año = oeUtilidad.Año
                    oeUTi = odUtilidad.Obtener(oeUTi)
                    If oeUTi.Id <> "" Then Throw New Exception("Ya ha Generado Utilidad del Año: " & oeUTi.Año)
                    If oeUtilidad.leDetalle.Count = 0 Then Throw New Exception("No puede Guardar Utilidad sin Detallar")
                    If oeUtilidad.leConsolidado.Count = 0 Then Throw New Exception("No puede Guardar Utilidad sin Consolidar")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ImportarDatos(oeUtilidad As e_Utilidad) As Boolean Implements Il_Utilidad.ImportarDatos
        Try
            If Validar(oeUtilidad) Then
                Dim dtUtiCon As Data.DataTable = olConsolidado.CrearDT()
                Dim id As String = odConsolidado.UltimoIdInserta
                Dim lsPrefijo As String = Left(id, 3)
                Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))
                For Each oeDet In oeUtilidad.leConsolidado
                    Dim rwDR5 As Data.DataRow
                    rwDR5 = dtUtiCon.NewRow
                    With oeDet
                        rwDR5("Id") = lsPrefijo & olConsolidado.CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                        rwDR5("IdUtilidad") = String.Empty
                        rwDR5("IdTrabajador") = .IdTrabajador
                        rwDR5("IndSituacion") = .IndSituacion
                        rwDR5("SueldoAnual") = .SueldoAnual
                        rwDR5("Subsidios") = .Subsidios
                        rwDR5("SueldoNetoAnual") = .SueldoNetoAnual
                        rwDR5("UtilidadporSueldo") = .UtilidadporSueldo
                        rwDR5("DiasTrabajadosAnual") = .DiasTrabajadosAnual
                        rwDR5("UtilidadporDiasTrabajados") = .UtilidadporDiasTrabajados
                        rwDR5("UtilidadTotal") = .UtilidadTotal
                        rwDR5("FechaCreacion") = Date.Now
                        rwDR5("UsuarioCreacion") = .UsuarioCreacion
                        rwDR5("FechaModifica") = .FechaModifica
                        rwDR5("UsuarioModifica") = .UsuarioModfica
                        rwDR5("Activo") = True
                    End With
                    dtUtiCon.Rows.Add(rwDR5)
                    lsNumero = lsNumero + 1
                Next
                oeUtilidad.dtConsolidado = dtUtiCon
                If oeUtilidad.leDetalle IsNot Nothing Then
                    Dim dtUtiDet As Data.DataTable = olDetalle.CrearDT()
                    Dim idDet As String = odDetalle.UltimoIdInserta
                    Dim lsPrefijoDet As String = Left(idDet, 3)
                    Dim lsNumeroDet As Integer = CInt(Right(idDet, Len(idDet) - 3))
                    For Each oeDet In oeUtilidad.leDetalle
                        Dim rwDR6 As Data.DataRow
                        rwDR6 = dtUtiDet.NewRow
                        With oeDet
                            rwDR6("Id") = lsPrefijo & olDetalle.CompletaConCeros(lsNumeroDet.ToString, Len(idDet) - 3)
                            rwDR6("IdUtilidad") = String.Empty
                            rwDR6("IdPeriodo") = .IdPeriodo
                            rwDR6("IdTrabajador") = .IdTrabajador
                            rwDR6("Gratificacion") = .Gratificacion
                            rwDR6("BrutoMensual") = .BrutoMensual
                            rwDR6("IndEstado") = .IndEstado
                            rwDR6("DiasMes") = .DiasMes
                            rwDR6("DiasLaborados") = .DiasLaborados
                            rwDR6("Faltas") = .Faltas
                            rwDR6("FechaCreacion") = Date.Now
                            rwDR6("UsuarioCreacion") = .UsuarioCreacion
                            rwDR6("Activo") = True
                        End With
                        dtUtiDet.Rows.Add(rwDR6)
                        lsNumeroDet = lsNumeroDet + 1
                    Next
                    oeUtilidad.dtDetalle = dtUtiDet
                End If
                Return odUtilidad.ImportarDatos(oeUtilidad)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Provisionar(oeUtilidad As e_Utilidad, oeAsientoModel As e_AsientoModelo, oePeriodo As e_Periodo) As Boolean Implements Il_Utilidad.Provisionar
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
                        _MontoGen = Math.Round(oeUtilidad.leConsolidado.Sum(Function(it) it.UtilidadTotal), 2)
                        .TotalDebe = _MontoGen : .TotalHaber = _MontoGen
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeAsientoModel.UsuarioCreacion : oeAsiento.Activo = True
                        .IdentificaAsiento = oeAsientoModel.Id
                        For Each _oeAsiModDet In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila.Trim).ToList
                            If _oeAsiModDet.Partida = 1 Then
                                ' Asiento Movimiento - Costo de Ventas
                                _MontoAux = oeUtilidad.leConsolidado.Where(Function(it) it.IndAdministrativo = 0).Sum(Function(it) it.UtilidadTotal)
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
                                _MontoAux = oeUtilidad.leConsolidado.Where(Function(it) it.IndAdministrativo = 1).Sum(Function(it) it.UtilidadTotal)
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
                                For Each _oeDet In oeUtilidad.leConsolidado
                                    oeMovAnalisis = New e_MovimientoAnalisis
                                    oeMovAnalisis.TipoOperacion = ""
                                    oeMovAnalisis.IdMoneda = oeAsientoModel.IdMoneda
                                    oeMovAnalisis.IdUsuarioCrea = oeAsientoModel.UsuarioCreacion
                                    oeMovAnalisis.Monto = _oeDet.UtilidadTotal
                                    oeMovAnalisis.Saldo = _oeDet.UtilidadTotal
                                    oeMovAnalisis.IdTrabajador = _oeDet.IdTrabajador
                                    oeAsientoMov.MovimientoAnalisis.Add(oeMovAnalisis)
                                Next
                                oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                            End If
                        Next
                    End With
                    If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                        odUtilidad.Guardar(oeUtilidad)
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
