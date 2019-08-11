Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

Public Class l_MovimientoPeaje
    Implements Il_MovimientoPeaje

    Private odMovimientoPeaje As New d_MovimientoPeaje
    'Private olDetalle As New l_DetallePagoAdicional
    ' Private odDetalle As New d_DetallePagoAdicional
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oePagoAdicional As EntidadesWCF.e_MovimientoPeaje) As Boolean Implements Il_MovimientoPeaje.Eliminar
        Try
            Return odMovimientoPeaje.Eliminar(oePagoAdicional)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeMovimientoPeaje As EntidadesWCF.e_MovimientoPeaje) As Boolean Implements Il_MovimientoPeaje.Guardar
        Try
            If Validar(oeMovimientoPeaje) Then
                Return odMovimientoPeaje.Guardar(oeMovimientoPeaje)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarConDocumento(ListaMovimientoPeaje As List(Of e_MovimientoPeaje), ListaDocumentos As List(Of e_MovimientoDocumento)) As Boolean Implements Il_MovimientoPeaje.GuardarConDocumento
        Try
            Dim l_MovimientoDocumento As New l_MovimientoDocumento
            Dim tiempo As New TimeSpan(2, 0, 0)
            Dim options As New TransactionOptions
            options.Timeout = tiempo
            Using transScope As New TransactionScope(TransactionScopeOption.Required, options)
                For Each Doc In ListaDocumentos
                    Dim leMovDoc As New List(Of e_MovimientoDocumento)
                    leMovDoc.Add(Doc)
                    l_MovimientoDocumento.GuardarCompra(Doc, leMovDoc, True, Nothing)
                Next
                For Each fila In ListaMovimientoPeaje
                    fila.IdDocumento = ListaDocumentos.Where(Function(x) x.Serie.Trim = fila.Serie.Trim And x.Numero.Trim = fila.Numero.Trim).ToList(0).Id
                    Guardar(fila)
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeMovimientoPeaje As EntidadesWCF.e_MovimientoPeaje) As List(Of EntidadesWCF.e_MovimientoPeaje) Implements Il_MovimientoPeaje.Listar
        Try
            Return odMovimientoPeaje.Listar(oeMovimientoPeaje)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oePagoAdicional As EntidadesWCF.e_MovimientoPeaje) As EntidadesWCF.e_MovimientoPeaje Implements Il_MovimientoPeaje.Obtener
        Try
            Return odMovimientoPeaje.Obtener(oePagoAdicional)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oePagoAdicional As EntidadesWCF.e_MovimientoPeaje) As Boolean Implements Il_MovimientoPeaje.Validar
        Try
            'With oePagoAdicional
            '    l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
            'End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ImportarDatos(leMovimientoPeaje As List(Of e_MovimientoPeaje)) As Boolean Implements Il_MovimientoPeaje.ImportarDatos
        Try
            Return odMovimientoPeaje.ImportarDatos(leMovimientoPeaje)

            'Dim dtPA As Data.DataTable = olDetalle.CrearDT()
            'Dim id As String = odDetalle.UltimoIdInserta
            'Dim lsPrefijo As String = Left(id, 3)
            'Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            'For Each oeDet In oePagoAdicional.leDetalle
            '    Dim rwPA As Data.DataRow
            '    rwPA = dtPA.NewRow
            '    With oeDet
            '        rwPA("Id") = lsPrefijo & olDetalle.CompletaConCeros(lsNumero.ToString, Len(id) - 3)
            '        rwPA("IdPagoAdicional") = String.Empty
            '        rwPA("IdTrabajador") = .IdTrabajador
            '        rwPA("Sueldo") = .Sueldo
            '        rwPA("AsignacionFamiliar") = .AsignacionFamiliar
            '        rwPA("IndTipo") = .IndTipo
            '        rwPA("Cantidad") = .Cantidad
            '        rwPA("Monto") = .Monto
            '        rwPA("Redondeo") = .Redondeo
            '        rwPA("DiasVacaciones") = .DiasVacaciones
            '        rwPA("DiasFalta") = .DiasFalta
            '        rwPA("DiasDescanso") = .DiasDescanso
            '        rwPA("TotalPagar") = .TotalPagar
            '        rwPA("FechaCreacion") = Date.Now
            '        rwPA("UsuarioCreacion") = .UsuarioCreacion
            '        rwPA("FechaModifica") = .FechaModifica
            '        rwPA("UsuarioModifica") = .UsuarioModifica
            '        rwPA("Activo") = True
            '    End With
            '    rwPA("HorasExtras") = oeDet.HorasExtras
            '    rwPA("MinutosExtras") = oeDet.MinutosExtras
            '    dtPA.Rows.Add(rwPA)
            '    lsNumero = lsNumero + 1
            'Next
            'oePagoAdicional.dtDetallePA = dtPA
            'Return odPagoAdicional.ImportarDatos(oePagoAdicional)
            'Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function ListaAsociacionMovimientoPeaje(oeMovimientoPeaje As e_MovimientoPeaje) As DataSet Implements Il_MovimientoPeaje.ListaAsociacionMovimientoPeaje
        Try
            Dim ds As DataSet
            ds = odMovimientoPeaje.ListarDts(oeMovimientoPeaje)

            Dim relation_1 As DataRelation, relation_2 As DataRelation
            Dim parentCol As DataColumn = ds.Tables(0).Columns("Id")
            Dim childCol_1 As DataColumn = ds.Tables(1).Columns("IdTracto")
            relation_1 = New DataRelation("FK_RelacionRegConComb_1", parentCol, childCol_1, False)
            ds.Relations.Add(relation_1)

            Dim TransactionColumns() As DataColumn, DetailColumns() As DataColumn
            TransactionColumns = New DataColumn() {ds.Tables(1).Columns("IdViaje"), ds.Tables(1).Columns("IdTracto")}
            DetailColumns = New DataColumn() {ds.Tables(2).Columns("IdViaje"), ds.Tables(2).Columns("IdVehiculo")}
            relation_2 = New DataRelation("FK_Relacion_VT", TransactionColumns, DetailColumns, False)
            ds.Relations.Add(relation_2)

            'Dim dtTractos As DataTable = ds.Tables(0)
            'Dim dtViaje As DataTable = ds.Tables(1)
            'Dim dtTanqueo As DataTable = ds.Tables(2)

            'Dim dtViajeAnterior = New DataTable()
            'Dim dtTanqueoAnterior = New DataTable()
            'dtViajeAnterior = dtViaje.Clone()
            'dtTanqueoAnterior = dtTanqueo.Clone()

            'Dim ConsumoGls As Double = 0.0
            'Dim Metas As String = ""
            'Dim Pilotos As String = ""
            'Dim Pesos As String = ""
            'Dim Clientes As String = ""
            'Dim Cargas As String = ""
            'Dim LD As String = ""
            'Dim ViajeOrigen As String = ""
            'Dim ViajeDestino As String = ""
            'Dim SaltoViaje As Boolean
            'Dim SaltoTanqueo As Boolean

            'For Each vehRow As DataRow In dtTractos.Rows
            '    LD = ""
            '    vehRow("Desviacion") = 0
            '    vehRow("Cons") = 0
            '    vehRow("Dist") = 0
            '    For Each viajeRow As DataRow In vehRow.GetChildRows(relation_1)
            '        SaltoViaje = False
            '        ViajeOrigen = IIf(String.IsNullOrEmpty(Trim(viajeRow("EqOrigen"))), viajeRow("ROrigen"), viajeRow("EqOrigen"))
            '        ViajeDestino = IIf(String.IsNullOrEmpty(Trim(viajeRow("EqDestino"))), viajeRow("RDestino"), viajeRow("EqDestino"))
            '        If LD <> "" And ViajeOrigen <> LD Then
            '            LD = ViajeOrigen
            '            Metas = Metas + " - " + LD
            '            Pesos = IIf(Pesos = "", CInt(dtViajeAnterior(0)("Peso")).ToString, Pesos + " - 0")
            '            Clientes = IIf(Clientes = "", dtViajeAnterior(0)("Cliente").ToString, Clientes + " / --")
            '            Cargas = IIf(Cargas = "", dtViajeAnterior(0)("CargaMaterial").ToString, Cargas + " / --")
            '            Pilotos = Pilotos + " / " + viajeRow("Piloto") + " / " + viajeRow("Copiloto")
            '        End If
            '        SaltoTanqueo = True
            '        For Each tanqRow As DataRow In viajeRow.GetChildRows(relation_2)
            '            SaltoTanqueo = False
            '            If tanqRow("IndTanqueo") = True Then
            '                If dtTanqueoAnterior.Rows.Count > 0 Then
            '                    tanqRow("Cons") = Math.Round(tanqRow("CantidadGls") + ConsumoGls, 3)
            '                    tanqRow("Dist") = Math.Round(tanqRow("Kilometraje") - dtTanqueoAnterior(0)("Kilometraje"), 3)
            '                    tanqRow("Rend") = Math.Round(tanqRow("Dist") / tanqRow("Cons"), 3)
            '                    tanqRow("Rutas") = IIf(String.IsNullOrEmpty(Trim(dtTanqueoAnterior(0)("EqOrigen"))), dtTanqueoAnterior(0)("LugTanqueo"), dtTanqueoAnterior(0)("EqOrigen"))
            '                    tanqRow("Rutas") = tanqRow("Rutas") + Metas
            '                    tanqRow("IdPiloto") = Pilotos + " / " + viajeRow("Piloto") + " / " + viajeRow("CoPiloto")
            '                    Pilotos = ""
            '                    tanqRow("Pesos") = Pesos
            '                    tanqRow("IdMaterial") = Cargas
            '                    tanqRow("IdEmpresaGrifo") = Clientes
            '                    Dim LugarTanqueo As String = IIf(String.IsNullOrEmpty(Trim(tanqRow("EqOrigen"))), tanqRow("LugTanqueo"), tanqRow("EqOrigen"))
            '                    If LugarTanqueo <> LD Then
            '                        tanqRow("Rutas") = tanqRow("Rutas") + " - " + LugarTanqueo
            '                        tanqRow("Pesos") = IIf(Pesos = "", CInt(viajeRow("Peso")).ToString, Pesos + " - " + CInt(viajeRow("Peso")).ToString)
            '                        tanqRow("IdMaterial") = IIf(Cargas = "", viajeRow("CargaMaterial").ToString, Cargas + " - " + viajeRow("CargaMaterial").ToString)
            '                        tanqRow("IdEmpresaGrifo") = IIf(Clientes = "", viajeRow("Cliente").ToString, Clientes + " - " + viajeRow("Cliente").ToString)
            '                    End If
            '                    Dim tablaMetas() As String
            '                    tablaMetas = Split(tanqRow("Rutas"), " - ")
            '                    Dim tablaPesos() As String
            '                    tablaPesos = Split(tanqRow("Pesos"), " - ")
            '                    If tablaMetas.Length > 1 Then
            '                        Dim ConsumoStandar As Double = 0
            '                        Dim DistanciaStandar As Double = 0
            '                        Dim Validado As Boolean = True
            '                        For i As Integer = 0 To tablaMetas.Length - 2
            '                            If Validado = False Then Exit For
            '                            'If oeRegistroConsumoComb.leZonaD2.Where(Function(z) z.OrigenRuta = tablaMetas(i) And z.DestinoRuta = tablaMetas(i + 1)).Count = 0 Then
            '                            '    tanqRow("Piloto") = "No existe la Ruta: " + tablaMetas(i) + "-" + tablaMetas(i + 1)
            '                            '    Validado = False
            '                            'Else
            '                            '    For Each obj In oeRegistroConsumoComb.leZonaD2.Where(Function(z) z.OrigenRuta = tablaMetas(i) And z.DestinoRuta = tablaMetas(i + 1)).OrderBy(Function(y) y.Orden).ToList
            '                            '        If obj.Orden = 0 Then
            '                            '            tanqRow("Piloto") = "No existe Zona D2, Ruta: " + tablaMetas(i) + "-" + tablaMetas(i + 1)
            '                            '            Validado = False
            '                            '            Exit For
            '                            '        Else
            '                            '            If oeRegistroConsumoComb.leRendimiento.Where(Function(y) y.IdTipoVehiculo = vehRow("IdModeloTracto") And y.Peso = tablaPesos(i) And y.IdFlota = obj.IdFlota).Count > 0 Then
            '                            '                DistanciaStandar = DistanciaStandar + obj.Kilometros
            '                            '                ConsumoStandar = ConsumoStandar + Math.Round(obj.Kilometros / oeRegistroConsumoComb.leRendimiento.Where(Function(y) y.IdTipoVehiculo = vehRow("IdModeloTracto") And y.Peso = tablaPesos(i) And y.IdFlota = obj.IdFlota)(0).Rendimiento, 3)
            '                            '            Else
            '                            '                tanqRow("Piloto") = "No existe rendimiento, Ruta:" + tablaMetas(i) + "-" + tablaMetas(i + 1) + " , con peso:" + tablaPesos(i)
            '                            '                Validado = False
            '                            '                Exit For
            '                            '            End If
            '                            '        End If
            '                            '    Next
            '                            'End If
            '                            If oeRegistroConsumoComb.leRutas.Where(Function(y) y.Origen = tablaMetas(i) And y.Destino = tablaMetas(i + 1)).Count > 0 And Validado = True Then
            '                                Dim IdRuta As String = oeRegistroConsumoComb.leRutas.Where(Function(y) y.Origen = tablaMetas(i) And y.Destino = tablaMetas(i + 1))(0).Id
            '                                If oeRegistroConsumoComb.leZonaD2.Where(Function(y) y.IdRuta = IdRuta).Count > 0 And Validado = True Then
            '                                    For Each zona In oeRegistroConsumoComb.leZonaD2.Where(Function(y) y.IdRuta = IdRuta).OrderBy(Function(z) z.Orden).ToList
            '                                        If Validado = False Then Exit For
            '                                        If zona.Kilometros > -1 Then
            '                                            If oeRegistroConsumoComb.leRendimiento.Where(Function(y) y.IdTipoVehiculo = vehRow("IdModeloTracto") And y.Peso = tablaPesos(i) And y.IdFlota = zona.IdFlota).Count > 0 And Validado = True Then
            '                                                DistanciaStandar = DistanciaStandar + zona.Kilometros
            '                                                ConsumoStandar = ConsumoStandar + Math.Round(zona.Kilometros / oeRegistroConsumoComb.leRendimiento.Where(Function(y) y.IdTipoVehiculo = vehRow("IdModeloTracto") And y.Peso = tablaPesos(i) And y.IdFlota = zona.IdFlota)(0).Rendimiento, 3)
            '                                            Else
            '                                                Validado = False
            '                                                tanqRow("Piloto") = "No existe rendimiento para zona de Ruta:" + tablaMetas(i) + "-" + tablaMetas(i + 1)
            '                                            End If
            '                                        Else
            '                                            Validado = False
            '                                            tanqRow("Piloto") = "{" + tablaMetas(i) + "-" + tablaMetas(i + 1) + "}[La zona de metas, no existe como Ruta]"
            '                                        End If
            '                                    Next
            '                                Else
            '                                    'Mensaje de que Viaje no tiene Zonas
            '                                    Validado = False
            '                                    tanqRow("Piloto") = "Zonas de Combustible no configuradas, ruta:" + tablaMetas(i) + "-" + tablaMetas(i + 1)
            '                                End If
            '                            Else
            '                                'Mensaje para configurar Viajes
            '                                Validado = False
            '                                tanqRow("Piloto") = "No existe la Ruta:" + tablaMetas(i) + "-" + tablaMetas(i + 1)
            '                            End If
            '                        Next
            '                        If Validado = True Then
            '                            tanqRow("RendEsperado") = Math.Round(DistanciaStandar / ConsumoStandar, 3)
            '                            tanqRow("GlsEsperado") = Math.Round(tanqRow("Dist") / tanqRow("RendEsperado"), 2)
            '                            tanqRow("Desviacion") = Math.Round(tanqRow("Cons") - tanqRow("GlsEsperado"), 2)
            '                        Else
            '                            tanqRow("RendEsperado") = "0.0"
            '                            tanqRow("GlsEsperado") = "0.0"
            '                            tanqRow("Desviacion") = "0.0"
            '                        End If
            '                        vehRow("Desviacion") = CDbl(vehRow("Desviacion")) + CDbl(tanqRow("Desviacion"))
            '                    End If
            '                    vehRow("Cons") = CDbl(vehRow("Cons")) + tanqRow("Cons")
            '                    vehRow("Dist") = CDbl(vehRow("Dist")) + tanqRow("Dist")
            '                Else
            '                    tanqRow("IdPiloto") = Pilotos + " / " + viajeRow("Piloto") + " / " + viajeRow("CoPiloto")
            '                    Pilotos = ""
            '                End If
            '                Metas = ""
            '                'Pilotos = dtViaje(0)("Piloto") + " / " + dtViaje(0)("Copiloto")
            '                Pesos = ""
            '                Clientes = ""
            '                Cargas = ""
            '                ConsumoGls = 0.0
            '                LD = IIf(String.IsNullOrEmpty(Trim(tanqRow("EqOrigen"))), tanqRow("LugTanqueo"), tanqRow("EqOrigen"))
            '                SaltoViaje = True
            '                dtTanqueoAnterior.Clear()
            '                dtTanqueoAnterior.ImportRow(tanqRow)
            '            Else
            '                ConsumoGls = ConsumoGls + tanqRow("CantidadGls")
            '            End If
            '        Next
            '        If SaltoTanqueo Then
            '            If Pilotos <> "" Then
            '                Pilotos = Pilotos + " / " + viajeRow("Piloto").ToString + " / " + viajeRow("CoPiloto").ToString
            '            Else
            '                Pilotos = viajeRow("Piloto").ToString + " / " + viajeRow("CoPiloto").ToString
            '            End If
            '        End If
            '        If LD <> "" And SaltoViaje = False Then
            '            If ViajeDestino <> LD Then
            '                LD = ViajeDestino
            '                Metas = Metas + " - " + LD
            '                'Pilotos = Pilotos + " / " + viajeRow("Piloto").ToString + " / " + viajeRow("CoPiloto").ToString
            '                Pesos = IIf(Pesos = "", CInt(viajeRow("Peso")).ToString, Pesos + " - " + CInt(viajeRow("Peso")).ToString)
            '                Cargas = IIf(Cargas = "", viajeRow("CargaMaterial").ToString, Cargas + " / " + viajeRow("CargaMaterial").ToString)
            '                Clientes = IIf(Clientes = "", viajeRow("Cliente").ToString, Clientes + " / " + viajeRow("Cliente").ToString)
            '            End If
            '        End If
            '        dtViajeAnterior.Clear()
            '        dtViajeAnterior.ImportRow(viajeRow)
            '    Next
            '    dtTanqueoAnterior.Clear()
            '    dtViajeAnterior.Clear()
            '    Pilotos = ""
            'Next
            ds.AcceptChanges()
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
