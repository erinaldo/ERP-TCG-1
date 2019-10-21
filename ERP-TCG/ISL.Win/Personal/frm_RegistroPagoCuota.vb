'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_RegistroPagoCuota

#Region "Instancia"

    Public Sub New(ByVal ln_TipoOpe As Integer, _leDscto As List(Of e_Prestamo), _leCuota As List(Of e_PrestamoDetalle), _
                   ByVal ln_MontoPago As Double, ByVal ld_FecPeriodo As Date, ByVal ln_Doble As Integer, _
                   ByVal ln_Adelanto As Integer, ls_IdTrabajador As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        TipoOpe = ln_TipoOpe : MontoPago = ln_MontoPago : FecPeriodo = ld_FecPeriodo : IdTrabajador = ls_IdTrabajador
        IndDoble = ln_Doble : leDscto = _leDscto : leCuota = _leCuota : IndAdelanto = ln_Adelanto
    End Sub

    Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

#End Region

#Region "Declaracion de Variables"

    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private TipoOpe As Integer, MontoPago As Double, FecPeriodo As Date, IdTrabajador As String, IndDoble As Integer, IndAdelanto As Integer
    Private oeDscto As New e_Prestamo, olDscto As New l_Prestamo
    Public leDscto As New List(Of e_Prestamo), leCuota As New List(Of e_PrestamoDetalle)
    Private oeCuota As New e_PrestamoDetalle, olCuota As New l_PrestamoDetalle, leCPUltCP As New List(Of e_Prestamo)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)
    Private _MontoCuotaPend As Double = 0, _saldocob As Double = 0
    Private _SueldoMin As Double, _PorcDesc As Double, _MontoDesc As Double

#End Region

#Region "Eventos"

    Private Sub frm_RegistroPagoCuota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarTrabajador()
            CargarEstado()
            Inicializar()
            CargarDeuda()
            CargarPar()
            _SueldoMin = ValorParametro(gPSueldoMinimo, leParametro, leDetParametro)
            _PorcDesc = ValorParametro(gPPorcentajeDescuento, leParametro, leDetParametro)
            _MontoDesc = _SueldoMin * _PorcDesc / 100
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub griPrestamo_DoubleClick(sender As Object, e As EventArgs) Handles griPrestamo.DoubleClick
        Try
            If leDscto.Count > 0 Then
                'If decMontoDep.Value = 0 Then decMontoDep.Focus() : Throw New Exception("Ingrese Monto a Cobrar")
                'If agrCuotaCP.Visible Then fecCCP.Focus() : Throw New Exception("Ingrese Datos de Cuota")
                _MontoCuotaPend = 0
                oeDscto = New e_Prestamo
                oeDscto.Equivale = 0 : oeDscto.Id = griPrestamo.ActiveRow.Cells("Id").Value
                If leDscto.Contains(oeDscto) Then
                    oeDscto = leDscto.Item(leDscto.IndexOf(oeDscto))
                    fecDscto.Value = oeDscto.Fecha
                    decSaldoDscto.Value = oeDscto.Saldo
                    If oeDscto.Saldo > 0 Then btnAgregar.Enabled = True : btnQuitar.Enabled = True
                    Dim _leCCPAux = leCuota.Where(Function(it) it.IdPrestamo = oeDscto.Id And it.Activo = True).ToList
                    CargarCuota(_leCCPAux)
                    _MontoCuotaPend = decSaldoDscto.Value - _leCCPAux.Sum(Function(it) it.Importe)
                    btnAgregar.Enabled = IIf(_MontoCuotaPend > 0, True, False)
                    btnQuitar.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If TipoOpe = 1 Then
            If _MontoCuotaPend > 0 Then
                agrCuota.Visible = True : fecCuota.Value = FecPeriodo : fecCuota.Enabled = False
                decImporteCuota.Value = _MontoCuotaPend : decImporteCuota.Focus()
            End If
        Else
            Dim _MontoAux As Double = 0
            If _saldocob > 0 Then
                If griCuota.Rows.Count > 0 Then
                    _MontoAux = griCuota.Rows.Where(Function(it) it.Cells("Cancelado").Value = 0).Sum(Function(it) it.Cells("Importe").Value)
                End If
                If _MontoAux > 0 Then
                    MessageBox.Show("Tiene Cuotas Pendientes por Cobrar", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If _saldocob >= decSaldoDscto.Value Then
                        decImporteCuota.Value = Math.Round(decSaldoDscto.Value, 2)
                    Else
                        decImporteCuota.Value = Math.Round(_saldocob, 2)
                    End If
                    agrCuota.Visible = True : fecCuota.Focus()
                End If
            Else
                MessageBox.Show("Ya se ha Cobrado el Monto Ingresado", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            If griCuota.Selected.Rows.Count > 0 Then
                oeCuota = New e_PrestamoDetalle
                oeCuota.Equivale = 2 : oeCuota.IdPrestamo = oeDscto.Id
                oeCuota.NroCuota = griCuota.ActiveRow.Cells("NroCuota").Value
                If leCuota.Contains(oeCuota) Then
                    oeCuota = leCuota.Item(leCuota.IndexOf(oeCuota))
                    If oeCuota.Id <> "" Then
                        oeCuota.TipoOperacion = "A" : oeCuota.Activo = False : oeCuota.Cancelado = 0
                        oeCuota.Fecha = #1/1/1901# : oeCuota.Glosa = String.Empty : oeCuota.PeriodoEjec = String.Empty
                    Else
                        leCuota.Remove(oeCuota)
                    End If
                    If TipoOpe = 2 Then
                        Dim _oePAux As New e_Prestamo
                        _oePAux.Equivale = 0
                        _oePAux.Id = oeDscto.Id
                        If leDscto.Contains(_oePAux) Then
                            _oePAux = leDscto.Item(leDscto.IndexOf(_oePAux))
                            _oePAux.TipoOperacion = "A"
                            _oePAux.Saldo = _oePAux.Saldo + oeCuota.Importe
                            _saldocob = Math.Round((_saldocob + oeCuota.Importe), 2)
                            decSaldoDscto.Value = _oePAux.Saldo
                            If _oePAux.Saldo > 0 Then
                                _oePAux.Cancelado = 0
                                Dim _estado = gEstadosSGI.APROBADA.ToString
                                Dim _leEAux = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                                If _leEAux.Count > 0 Then _oePAux.IdEstado = _leEAux(0).Id
                            End If
                        End If
                        CargarDsctoPend(leDscto)
                    End If
                End If
                Dim _leCCPAux = leCuota.Where(Function(it) it.IdPrestamo = oeDscto.Id And it.Activo = True).ToList
                CargarCuota(_leCCPAux)
                If TipoOpe = 2 Then decCobrando.Value = leCuota.Where(Function(it) it.Cancelado = 1 And it.Activo = True).Sum(Function(it) it.Importe)
                If TipoOpe = 1 Then CalcularMontoCuota()
                _MontoCuotaPend = decSaldoDscto.Value - _leCCPAux.Sum(Function(it) it.Importe)
                btnAgregar.Enabled = IIf(_MontoCuotaPend > 0, True, False)
            Else
                Throw New Exception("Seleccione una Cuota para Quitar")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If decImporteCuota.Value = 0 Then Throw New Exception("Ingrese Monto de Cuota")
            Dim _leAux = leCPUltCP.Where(Function(it) it.Id = oeDscto.Id).ToList
            If _leAux.Count > 0 Then
                If TipoOpe = 2 Then
                    Dim _saldoaux = Math.Round((MontoPago - decCobrando.Value), 2)
                    If _saldoaux >= decImporteCuota.Value Then
                        _saldocob = Math.Round((_saldoaux - decImporteCuota.Value), 2)
                    Else
                        _saldocob = _saldoaux
                        Throw New Exception("El Monto a Cobrar (" & decImporteCuota.Value & ") es mayor al Monto ingresado (" & _
                                            _saldocob & ")")
                    End If
                End If
                oeCuota = New e_PrestamoDetalle
                oeCuota.TipoOperacion = "I" : oeCuota.Activo = True : oeCuota.IdPrestamo = oeDscto.Id
                oeCuota.NroCuota = FormatoDocumento((_leAux(0).CantidadCuotas + 1), 3) : oeCuota.Anio = fecCuota.Value.Year.ToString
                oeCuota.Mes = FormatoDocumento(fecCuota.Value.Month.ToString, 2) : oeCuota.Importe = decImporteCuota.Value
                oeCuota.DobleMes = IndDoble : oeCuota.Fecha = #1/1/1901# : oeCuota.UsuarioCreacion = gUsuarioSGI.Id
                oeCuota.Cancelado = 0 : oeCuota.Glosa = String.Empty : oeCuota.PeriodoEjec = String.Empty
                If TipoOpe = 2 Then
                    oeCuota.Cancelado = 1 : oeCuota.Fecha = Date.Now.Date : oeCuota.PeriodoEjec = "DEPOSIT"
                    oeCuota.Glosa = ""
                    Dim _oePAux As New e_Prestamo
                    _oePAux.Equivale = 0 : _oePAux.Id = oeDscto.Id
                    If leDscto.Contains(_oePAux) Then
                        _oePAux = leDscto.Item(leDscto.IndexOf(_oePAux))
                        _oePAux.TipoOperacion = "A" : _oePAux.CantidadCuotas = _leAux(0).CantidadCuotas + 1
                        _oePAux.Saldo = _oePAux.Saldo - oeCuota.Importe
                        decSaldoDscto.Value = _oePAux.Saldo
                        Select Case _oePAux.Concepto
                            Case gCPPrestamos : oeCuota.IndProv = "A"
                            Case gCPAdelantos : oeCuota.IndProv = "B"
                            Case Else : oeCuota.IndProv = IIf(_oePAux.Monto > _MontoDesc, "A", "B")
                        End Select
                        If _oePAux.Saldo = 0 Then
                            _oePAux.Cancelado = 1
                            Dim _estado = gNombreEstadoCancelada
                            Dim _leEAux = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                            If _leEAux.Count > 0 Then _oePAux.IdEstado = _leEAux(0).Id
                        End If
                    End If
                    CargarDsctoPend(leDscto)
                End If
                oeCuota.PrefijoID = gs_PrefijoIdSucursal '@0001
                leCuota.Add(oeCuota)
                Dim _leCCPAux = leCuota.Where(Function(it) it.IdPrestamo = oeDscto.Id).ToList
                CargarCuota(_leCCPAux)
                If TipoOpe = 2 Then decCobrando.Value = leCuota.Where(Function(it) it.Cancelado = 1 And it.Activo = True).Sum(Function(it) it.Importe)
                If TipoOpe = 1 Then CalcularMontoCuota()
                agrCuota.Visible = False
                _MontoCuotaPend = decSaldoDscto.Value - _leCCPAux.Sum(Function(it) it.Importe)
                btnAgregar.Enabled = IIf(_MontoCuotaPend > 0, True, False)
                MessageBox.Show("Se ha generado la cuota.", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Desea Cancelar la Operacion de Agregar Cuota?", "Mensaje de Sistema", _
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            agrCuota.Visible = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If TipoOpe = 1 Then
                MontoPago = decMontoPago.Value
                Dim _anio = FecPeriodo.Year.ToString
                Dim _mes = FormatoDocumento(FecPeriodo.Month.ToString, 2)
                Dim _leAux = leCuota.Where(Function(it) it.Activo = True And it.Cancelado = 0 And it.Anio = _anio And it.Mes = _mes And it.DobleMes = IndDoble).ToList
                If _leAux.Count > 0 Then
                    If olCuota.GuardarLista(_leAux) Then Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    Throw New Exception("No hay Datos para Guardar")
                End If
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            leDscto = New List(Of e_Prestamo) : leCuota = New List(Of e_PrestamoDetalle)
            Me.DialogResult = Windows.Forms.DialogResult.No
        End If
    End Sub

    Private Sub decCobrando_ValueChanged(sender As Object, e As EventArgs) Handles decCobrando.ValueChanged
        decSaldoPago.Value = decMontoPago.Value - decCobrando.Value
    End Sub

    Private Sub griCuota_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griCuota.ClickCell
        Try
            With griCuota
                If .Selected.Rows.Count = 0 Then
                    If .ActiveCell.Row.Index > -1 AndAlso .ActiveCell.Column.Key = "Cancelado" Then
                        If agrCuota.Visible Then fecDscto.Focus() : Throw New Exception("Ingrese Datos de Cuota")
                        Dim _oePAux As New e_Prestamo
                        _oePAux.Equivale = 0
                        _oePAux.Id = oeDscto.Id
                        If leDscto.Contains(_oePAux) Then
                            _oePAux = leDscto.Item(leDscto.IndexOf(_oePAux))
                            _oePAux.TipoOperacion = "A"
                        End If
                        oeCuota = New e_PrestamoDetalle
                        oeCuota.Equivale = 2
                        oeCuota.IdPrestamo = oeDscto.Id
                        oeCuota.NroCuota = .ActiveRow.Cells("NroCuota").Value
                        If leCuota.Contains(oeCuota) Then
                            oeCuota = leCuota.Item(leCuota.IndexOf(oeCuota))
                            If .ActiveRow.Cells("Cancelado").Value = False Then
                                If MessageBox.Show("¿Desea Cobrar esta Cuota?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                                   MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    If (MontoPago - decCobrando.Value) >= oeCuota.Importe Then
                                        _saldocob = (MontoPago - decCobrando.Value) - oeCuota.Importe
                                    Else
                                        _saldocob = (MontoPago - decCobrando.Value)
                                        .ActiveRow.Cells("Cancelado").Value = False
                                        .Update()
                                        Throw New Exception("El Monto a Cobrar (" & oeCuota.Importe & ") es mayor al Monto ingresado (" & _saldocob & ")")
                                    End If
                                    oeCuota.Cancelado = 1
                                    oeCuota.Fecha = Date.Now.Date
                                    oeCuota.NroCuota = FormatoDocumento(oeCuota.NroCuota, 3)
                                    oeCuota.TipoOperacion = IIf(oeCuota.Id <> "", "A", "I")
                                    oeCuota.Glosa = String.Empty
                                    oeCuota.PeriodoEjec = "DEPOSIT"
                                    _oePAux.Saldo = _oePAux.Saldo - oeCuota.Importe
                                    Select Case _oePAux.Concepto
                                        Case gCPPrestamos : oeCuota.IndProv = "A"
                                        Case gCPAdelantos : oeCuota.IndProv = "B"
                                        Case Else : oeCuota.IndProv = IIf(_oePAux.Monto > _MontoDesc, "A", "B")
                                    End Select
                                    If _oePAux.Saldo = 0 Then
                                        _oePAux.Cancelado = 1
                                        Dim _estado = gNombreEstadoCancelada
                                        Dim _leEAux = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                                        If _leEAux.Count > 0 Then _oePAux.IdEstado = _leEAux(0).Id
                                    End If
                                End If
                            Else
                                If MessageBox.Show("¿Desea Anular el Cobro esta Cuota?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                                  MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    oeCuota.Cancelado = 0
                                    oeCuota.Fecha = #1/1/1901#
                                    oeCuota.Glosa = String.Empty
                                    oeCuota.PeriodoEjec = String.Empty
                                    _oePAux.Saldo = _oePAux.Saldo + oeCuota.Importe
                                    _saldocob = _saldocob + oeCuota.Importe
                                    If _oePAux.Saldo > 0 Then
                                        _oePAux.Cancelado = 0
                                        Dim _estado = gEstadosSGI.APROBADA.ToString
                                        Dim _leEAux = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                                        If _leEAux.Count > 0 Then _oePAux.IdEstado = _leEAux(0).Id
                                    End If
                                End If
                            End If
                            decSaldoDscto.Value = _oePAux.Saldo
                            CargarCuota(leCuota)
                            Dim _leCCPAux = leCuota.Where(Function(it) it.IdPrestamo = oeDscto.Id And it.Activo = True).ToList
                            CargarCuota(_leCCPAux)
                            decCobrando.Value = leCuota.Where(Function(it) it.Cancelado = 1 And it.Activo = True).Sum(Function(it) it.Importe)
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        cboTrabajador.Value = IdTrabajador : cboTrabajador.ReadOnly = True
        decMontoPago.Value = MontoPago : decMontoPago.ReadOnly = True
        decCobrando.ReadOnly = True : decSaldoPago.ReadOnly = True
        decCobrando.Visible = IIf(TipoOpe = 1, False, True) : etiCobrando.Visible = IIf(TipoOpe = 1, False, True)
        decSaldoPago.Visible = IIf(TipoOpe = 1, False, True) : etiSaldoPago.Visible = IIf(TipoOpe = 1, False, True)
        agrCuota.Visible = False : btnAgregar.Enabled = False : btnQuitar.Enabled = False
        fecDscto.Enabled = False : decSaldoDscto.ReadOnly = True : _saldocob = Math.Round(MontoPago, 2)
    End Sub

    Private Sub CargarTrabajador()
        Try
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            Dim _leTrabAux = From le In leTrabajador Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.IndEstado _
                        Where IndEstado > 0 Order By NombreCompleto
            LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAux.ToList, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarEstado()
        Try
            oeEstado = New e_Estado
            oeEstado.Nombre = "PRESTAMO"
            leEstado = olEstado.Listar(oeEstado)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDeuda()
        Try
            'Cargar los Descuentos Aprobados
            oeDscto = New e_Prestamo
            oeDscto.TipoOperacion = "" : oeDscto.IdTrabajador = IdTrabajador
            Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gEstadosSGI.APROBADA.ToString).ToList
            If _leEstAux.Count > 0 Then oeDscto.IdEstado = _leEstAux(0).Id
            Select Case IndAdelanto
                Case -1 : leDscto = olDscto.Listar(oeDscto)
                Case 0 : leDscto = olDscto.Listar(oeDscto).Where(Function(it) it.Concepto <> gCPSanciones).ToList
                Case 1 : leDscto = olDscto.Listar(oeDscto).Where(Function(it) it.Concepto = gCPSanciones).ToList
            End Select
            CargarDsctoPend(leDscto)
            If leDscto.Count > 0 Then
                'Cargar Ultima cuota de cada descuento
                oeDscto = New e_Prestamo
                oeDscto.TipoOperacion = "T" : oeDscto.IdTrabajador = IdTrabajador
                Select Case IndAdelanto
                    Case -1 : leCPUltCP = olDscto.Listar(oeDscto)
                    Case 0 : leCPUltCP = olDscto.Listar(oeDscto).Where(Function(it) it.Concepto <> gCPSanciones).ToList
                    Case 1 : leCPUltCP = olDscto.Listar(oeDscto).Where(Function(it) it.Concepto = gCPSanciones).ToList
                End Select
                'Cargar las cuotas de cada descuento
                oeCuota = New e_PrestamoDetalle
                oeCuota.TipoOperacion = "N" : oeCuota.IdPrestamo = IdTrabajador
                Select Case IndAdelanto
                    Case -1 : leCuota = olCuota.Listar(oeCuota)
                    Case 0 : leCuota = olCuota.Listar(oeCuota).Where(Function(it) it.PeriodoEjec <> gCPSanciones).ToList
                    Case 1 : leCuota = olCuota.Listar(oeCuota).Where(Function(it) it.PeriodoEjec = gCPSanciones).ToList
                End Select
            Else
                leCuota = New List(Of e_PrestamoDetalle)
            End If
            CargarCuota(New List(Of e_PrestamoDetalle))
            If TipoOpe = 1 Then CalcularMontoCuota()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDsctoPend(leCPend As List(Of e_Prestamo))
        Try
            With griPrestamo
                .ResetDisplayLayout()
                Dim _leAux = leCPend.OrderBy(Function(it) it.Fecha).ToList
                .DataSource = _leAux
                OcultarColumna(griPrestamo, True, "Id", "IdTrabajador", "Trabajador", "Activo", "Cancelado", "FechaCreacion", _
                               "UsuarioCreacion", "IdConcepto", "IdEstado", "Estado", "UsuarioAprueba", "FechaAprueba", "GlosaCancelado", _
                               "FechaCancelado", "FechaIntegracion", "IdCtaBancaria")
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Concepto").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("CantidadCuotas").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Saldo").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("CantidadCuotas").Header.Caption = "Cuotas"
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 65
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 300
                FormatoColumna(griPrestamo, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto", "Saldo")
                FormatoColumna(griPrestamo, "", ColumnStyle.Integer, HAlign.Center, "CantidadCuotas")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
            CalcularTotales(griPrestamo, "Monto", "Saldo")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCuota(leCCPend As List(Of e_PrestamoDetalle))
        Try
            With griCuota
                .ResetDisplayLayout()
                Dim _leAux = leCCPend.OrderBy(Function(it) it.NroCuota).ToList
                .DataSource = _leAux
                For Each col In .DisplayLayout.Bands(0).Columns
                    col.CellClickAction = IIf(col.Key = "Cancelado", CellClickAction.Edit, CellClickAction.RowSelect)
                    col.CellActivation = IIf(col.Key = "Cancelado", Activation.AllowEdit, Activation.NoEdit)
                Next
                OcultarColumna(griCuota, True, "Id", "IdPrestamo", "FechaCreacion", "FechaAnulado", "Activo", "Anulado", "UsuarioCreacion")
                If TipoOpe = 1 Then OcultarColumna(griCuota, True, "Cancelado", "Fecha")
                .DisplayLayout.Bands(0).Columns("NroCuota").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Cancelado").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Anio").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Mes").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("DobleMes").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Fecha").Header.Caption = "Fec. Cancelado"
                .DisplayLayout.Bands(0).Columns("Anio").Header.Caption = "Periodo"
                FormatoColumna(griCuota, "", ColumnStyle.CheckBox, HAlign.Default, "Cancelado", "DobleMes")
                .DisplayLayout.Bands(0).Columns("Anio").Width = 50
                .DisplayLayout.Bands(0).Columns("Mes").Width = 40
                .DisplayLayout.Bands(0).Columns("Importe").Width = 100
                .DisplayLayout.Bands(0).Columns("Cancelado").Width = 60
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 100
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 300
                FormatoColumna(griCuota, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Importe")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InizializarCuota()

    End Sub

    Private Sub CalcularMontoCuota()
        Dim _mes = FormatoDocumento(FecPeriodo.Month.ToString, 2)
        Dim _anio = FecPeriodo.Year.ToString
        If leCuota.Count > 0 Then
            Dim _leAuxC = leCuota.Where(Function(it) it.Anio = _anio And it.Mes = _mes And it.DobleMes = IndDoble And it.Cancelado = 0 And it.Activo = True And it.TipoOperacion <> "E").ToList
            If _leAuxC.Count > 0 Then decMontoPago.Value = _leAuxC.Sum(Function(it) it.Importe)
        End If
    End Sub

    Private Sub CargarPar()
        Try
            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = "" : oeParametro.Activo = True
            leParametro = olParametro.Listar(oeParametro)
            oeDetParametro = New e_DetalleAporteDescuento
            oeDetParametro.TipoOperacion = "" : oeDetParametro.Activo = True : oeDetParametro.Vigencia = 1
            leDetParametro = olDetParametro.Listar(oeDetParametro)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class