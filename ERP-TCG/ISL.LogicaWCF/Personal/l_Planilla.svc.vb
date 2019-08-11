Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_Planilla
    Implements Il_Planilla

    Private odPlanilla As New d_Planilla
    Private olDetallePlanilla As New l_DetallePlanilla
    Private odDetallePlanilla As New d_DetallePlanilla
    Private olDetalleConcepto As New l_DetalleConcepto
    Private odDetalleConcepto As New d_DetalleConcepto
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oePlanilla As e_Planilla) As Boolean Implements Il_Planilla.Eliminar
        Try
            Return odPlanilla.Eliminar(oePlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oePlanilla As e_Planilla) As Boolean Implements Il_Planilla.Guardar
        Try
            If Validar(oePlanilla) Then
                With oePlanilla
                    If .leDetalle.Count > 0 Then

                        Dim dsDetPla As Data.DataTable = olDetallePlanilla.CrearDT
                        Dim rwDetPla As Data.DataRow
                        Dim _idDetPla As String = odDetallePlanilla.UltimoIdInserta
                        Dim _preDetPla As String = Left(_idDetPla, 3)
                        Dim _numDetPla As Integer = CInt(Right(_idDetPla, Len(_idDetPla) - 3))
                        Dim _idAux As String = ""

                        Dim dsDetCon As Data.DataTable = olDetalleConcepto.CrearDT
                        Dim rwDetCon As Data.DataRow
                        Dim _idDetCon As String = odDetalleConcepto.UltimoIdInserta
                        Dim _preDetCon As String = Left(_idDetCon, 3)
                        Dim _numDetCon As Integer = CInt(Right(_idDetCon, Len(_idDetCon) - 3))

                        Dim _leDetIns = .leDetalle.Where(Function(it) it.TipoOperacion = "I").ToList
                        For Each _oeDetIns In _leDetIns
                            rwDetPla = dsDetPla.NewRow
                            With _oeDetIns
                                _idAux = _preDetPla & CompletaConCeros(_numDetPla.ToString, Len(_idDetPla) - 3)
                                rwDetPla("Id") = _idAux
                                rwDetPla("IdPlanilla") = .IdPlanilla
                                rwDetPla("IdTrabajador") = .IdTrabajador
                                rwDetPla("IdCentro") = .IdCentro
                                rwDetPla("IdArea") = .IdArea
                                rwDetPla("IdOcupacion") = .IdOcupacion
                                rwDetPla("IndRuta") = .IndRuta
                                rwDetPla("IndEstado") = .IndEstado
                                rwDetPla("IndHijo") = .IndHijo
                                rwDetPla("IdEmpresaAFP") = .IdEmpresaAFP
                                rwDetPla("IndTipoAFP") = .IndTipoAFP
                                rwDetPla("IndTipoAux") = .IndTipoAux
                                rwDetPla("DiasFaltas") = .DiasFaltas
                                rwDetPla("DiasDescanso") = .DiasDescanso
                                rwDetPla("DiasVacaciones") = .DiasVacaciones
                                rwDetPla("DiasCompra") = .DiasCompra
                                rwDetPla("IdCuentaCorriente") = .IdCuentaCorriente
                                rwDetPla("Ingresos") = .Ingresos
                                rwDetPla("Deducciones") = .Deducciones
                                rwDetPla("Aportes") = .Aportes
                                rwDetPla("ImportePagar") = .ImportePagar
                                rwDetPla("FechaCreacion") = Date.Now.Date
                                rwDetPla("UsuarioCreacion") = .UsuarioCreacion
                                rwDetPla("FechaModifica") = Date.Now.Date
                                rwDetPla("UsuarioModifica") = .UsuarioModifica
                                rwDetPla("Activo") = .Activo
                                rwDetPla("IsPagado") = .IsPagado
                                rwDetPla("IndTipo") = .IndTipo
                            End With
                            dsDetPla.Rows.Add(rwDetPla)
                            _numDetPla = _numDetPla + 1
                            Dim _leDetConIns = .leDetalleConcepto.Where(Function(it) it.IdTrabajador = _oeDetIns.IdTrabajador And it.TipoOperacion = "I" And it.Importe > 0).ToList
                            For Each _oeDetCon In _leDetConIns
                                rwDetCon = dsDetCon.NewRow
                                With _oeDetCon
                                    rwDetCon("Id") = _preDetCon & CompletaConCeros(_numDetCon.ToString, Len(_idDetCon) - 3)
                                    rwDetCon("IdDetallePlanilla") = _idAux
                                    rwDetCon("IdAporteDescuento") = .IdAporteDescuento
                                    rwDetCon("Importe") = .Importe
                                    rwDetCon("Tipo") = .Tipo
                                    rwDetCon("FechaCreacion") = Date.Now.Date
                                    rwDetCon("UsuarioCreacion") = .UsuarioCreacion
                                    rwDetCon("FechaModifica") = Date.Now.Date
                                    rwDetCon("UsuarioModifica") = .UsuarioModifica
                                    rwDetCon("Activo") = .Activo
                                End With
                                dsDetCon.Rows.Add(rwDetCon)
                                _numDetCon = _numDetCon + 1
                            Next
                        Next
                        .dsDetalle = dsDetPla
                        .dsDetCon = dsDetCon
                    End If
                End With
                Return odPlanilla.Guardar(oePlanilla)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oePlanilla As e_Planilla) As List(Of e_Planilla) Implements Il_Planilla.Listar
        Try
            Return odPlanilla.Listar(oePlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oePlanilla As e_Planilla) As e_Planilla Implements Il_Planilla.Obtener
        Try
            Return odPlanilla.Obtener(oePlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerUltimaPlanilla(oePlanilla As e_Planilla) As e_Planilla Implements Il_Planilla.ObtenerUltimaPlanilla
        Try
            Return odPlanilla.ObtenerUltimaPlanilla(oePlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oePlanilla As e_Planilla) As Boolean Implements Il_Planilla.Validar
        Try
            With oePlanilla
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'If .Importe = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_Planilla.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function Provisionar(oePlanilla As e_Planilla, oeAsientoModel As e_AsientoModelo, oePeriodo As e_Periodo) As Boolean Implements Il_Planilla.Provisionar
        Try
            Using TransScope As New TransactionScope()
                Dim oeAsiento As New e_Asiento, olAsiento As New l_Asiento, oeAsientoMov As New e_AsientoMovimiento
                If l_FuncionesGenerales.ValidarPeriodo(oePeriodo.Id, gAreasSGI.Planilla, oeAsientoModel.FechaMov, "") Then
                    With oeAsiento
                        .TipoOperacion = "I" : .IdPeriodo = oePeriodo.Id : .IdTipoAsiento = oeAsientoModel.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = oeAsientoModel.FechaMov
                        .Glosa = oeAsientoModel.Nombre : .GlosaImprime = String.Empty
                        .IdMoneda = oeAsientoModel.IdMoneda : .TipoCambio = oeAsientoModel.TipoCambio
                        .TotalDebe = oeAsientoModel.leDetalle.Where(Function(it) it.Partida = 1).Sum(Function(it) it.MontoAux)
                        .TotalHaber = oeAsientoModel.leDetalle.Where(Function(it) it.Partida = 2).Sum(Function(it) it.MontoAux)
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeAsientoModel.UsuarioCreacion : oeAsiento.Activo = True
                        .IdentificaAsiento = oeAsientoModel.Id
                        For Each _oeAsiModDet In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila.Trim).ToList
                            If _oeAsiModDet.MontoAux > 0 Then
                                oeAsientoMov = New e_AsientoMovimiento
                                With oeAsientoMov
                                    .TipoOperacion = "I" : .IdCuentaContable = _oeAsiModDet.IdCuentaContable.Trim
                                    .Glosa = _oeAsiModDet.Titulo
                                    .DebeMN = IIf(_oeAsiModDet.Partida = 1, _oeAsiModDet.MontoAux, 0)
                                    .DebeME = IIf(_oeAsiModDet.Partida = 1, _oeAsiModDet.MontoAux / oeAsientoModel.TipoCambio, 0)
                                    .HaberMN = IIf(_oeAsiModDet.Partida = 2, _oeAsiModDet.MontoAux, 0)
                                    .HaberME = IIf(_oeAsiModDet.Partida = 2, _oeAsiModDet.MontoAux / oeAsientoModel.TipoCambio, 0)
                                    .IdUsuarioCrea = oeAsientoModel.UsuarioCreacion : .Activo = True : .AsMov_MovDoc = Nothing
                                    oeAsiento.AsientoMovimiento.Add(oeAsientoMov)
                                End With
                            End If
                        Next
                    End With
                    If olAsiento.GuardarAsientoDscto(oeAsiento) Then
                        odPlanilla.Guardar(oePlanilla)
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
