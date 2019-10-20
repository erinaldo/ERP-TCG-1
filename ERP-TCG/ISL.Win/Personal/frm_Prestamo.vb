'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Prestamo
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Prestamo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Prestamo
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oePrestamo As New e_Prestamo, oePrestTrans As New e_Prestamo, olPrestamo As New l_Prestamo, _lePrestAux As New List(Of e_Prestamo)
    Private leCargoPend As New List(Of e_Prestamo), leCPUltCP As New List(Of e_Prestamo), oeCuotaAnu As New e_PrestamoDetalle
    Private oePrestamoDetalle As New e_PrestamoDetalle, olPrestamoDetalle As New l_PrestamoDetalle, lePrestamoDetalle As New List(Of e_PrestamoDetalle)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private leTrabajadorBus As New List(Of e_Trabajador), leTrabPasar As New List(Of e_Trabajador)
    Private oeSueldo As New e_SueldoTrabajador, olSueldo As New l_SueldoTrabajador, leSueldo As New List(Of e_SueldoTrabajador)
    Private oePagoDescuento As New e_PagoDescuento, olPagoDescuento As New l_PagoDescuento, lePagoDescuento As New List(Of e_PagoDescuento)
    Private oeConceptoPres As New e_Concepto_Prestamo, olConceptoPres As New l_Concepto_Prestamo, leConceptoPres As New List(Of e_Concepto_Prestamo)
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private oeMoneda As New e_Moneda, olMoneda As New l_Moneda, leMoneda As New List(Of e_Moneda)
    Private oeCtaBancaria As New e_CuentaBancaria, olCtaBancaria As New l_CuentaBancaria, leCtaBancaria As New List(Of e_CuentaBancaria)
    Private olPersona As New l_Persona, leCuotaCargoPend As New List(Of e_PrestamoDetalle), leConceptoAux As New List(Of e_Concepto_Prestamo)
    Private oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa, leEmpresa As New List(Of e_Empresa)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo
    Dim _ingresando_datos As Boolean = False, _pereje As String = "", _empr As String = ""
    Dim BandCargar As Boolean, BandGenera As Boolean = False, BandCuota As Boolean = False, _saldocob As Double = 0
    Private _asigfam As Double = 0, dtSituacion As Data.DataTable, _porc As Double = 0, _lmonto As Double = 0
    Private _opePrest As String = "", _acl As String = "", _estado As String = "", bandact As Boolean = False, _idDscto As String = String.Empty
    Private _SueldoMin As Double, _PorcDesc As Double, _MontoDesc As Double
    Private IdPrestamo As String, IdAdelanto As String

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griPrestamo.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opePrest = "PENDIENTE"
                SeleccionaTab(1)
                Inicializar()
                oePrestamo.TipoOperacion = "I"
                oePrestamo.Modificado = False
                Dim _leTrabAct = From le In leTrabajador _
                                Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado
                                Where Activo = True And IndEstado <> 0
                                Order By NombreCompleto
                LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAct.ToList, -1)
                cboTrabajador.ReadOnly = False
                cboEstado.Text = "PENDIENTE"
                cboCuentaBancaria.ReadOnly = False
                cboConcepto.ReadOnly = False
                fecFecha.Focus()
                fecFecha.Enabled = True
                decMonto.ReadOnly = False
                Operacion = "Nuevo"
                MyBase.Nuevo()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            _acl = gAccionSistema.EDITAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opePrest = "PENDIENTE"
                Inicializar()
                Dim _leTrab = From le In leTrabajador _
                             Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni
                             Order By NombreCompleto
                LlenarCombo(cboTrabajador, "NombreCompleto", _leTrab.ToList, -1)
                cboTrabajador.ReadOnly = True
                Dim _leTraPasar = From le In leTrabajador _
                                Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado
                                Where Activo = True And IndEstado <> 0
                                Order By NombreCompleto
                LlenarCombo(cboTrabaPasar, "NombreCompleto", _leTraPasar.ToList, -1)
                Mostrar()
                cboTrabajador.ReadOnly = True
                cboCuentaBancaria.ReadOnly = True
                cboConcepto.ReadOnly = True
                oePrestamo.TipoOperacion = "A"
                oePrestamo.Modificado = False
                fecFecha.Focus()
                fecFecha.Enabled = False
                decMonto.ReadOnly = IIf(cboEstado.Text <> "PENDIENTE", True, False)
                BandCuota = True
                Operacion = "Editar"
                MyBase.Editar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                If _opePrest <> "CANCELAR" Then
                    SeleccionaTab(1)
                Else
                    SeleccionaTab(2)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case _opePrest
                Case "PENDIENTE"
                    If oePrestamo.Modificado Then
                        Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", _
                                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                            Case Windows.Forms.DialogResult.Yes
                                If Guardando() Then
                                    SeleccionaTab(0)
                                    _ingresando_datos = False
                                    Consultar(_Activo)
                                Else
                                    _ingresando_datos = True
                                    SeleccionaTab(1)
                                End If

                            Case Windows.Forms.DialogResult.No
                                SeleccionaTab(0)
                                _ingresando_datos = False
                                Consultar(_Activo)
                        End Select
                    Else
                        SeleccionaTab(0)
                        _ingresando_datos = False
                        Consultar(_Activo)
                    End If
                Case "CANCELAR"
                    If MessageBox.Show("¿Desea cancelar en cobro realizado?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        SeleccionaTab(0)
                        _ingresando_datos = False
                        Consultar(_Activo)
                    End If
                Case "APROBAR"
                    If MessageBox.Show("¿Desea cancelar la aprobacion del cargo a sueldo del Trabajador: " & cboTrabajador.Text & "?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        SeleccionaTab(0)
                        _ingresando_datos = False
                        Consultar(_Activo)
                    End If
                Case "ANULAR"
                    If MessageBox.Show("¿Desea cancelar la anulacion del cargo a sueldo del Trabajador: " & cboTrabajador.Text & "?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        SeleccionaTab(0)
                        _ingresando_datos = False
                        Consultar(_Activo)
                    End If
                Case "CONDONAR"
                    If MessageBox.Show("¿Desea cancelar la condonación del cargo a sueldo del Trabajador: " & cboTrabajador.Text & "?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        SeleccionaTab(0)
                        _ingresando_datos = False
                        Consultar(_Activo)
                    End If
                Case "TRANSFERIR"
                    If MessageBox.Show("¿Desea cancelar la Transferencia del cargo a sueldo del Trabajador: " & cboTrabajador.Text & "?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        SeleccionaTab(0)
                        _ingresando_datos = False
                        Consultar(_Activo)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                With griPrestamo
                    oePrestamo.Id = .ActiveRow.Cells("ID").Value
                    oePrestamo = olPrestamo.Obtener(oePrestamo)
                    If oePrestamo.Activo Then
                        _estado = gNombreEstadoPendiente
                        If oePrestamo.Estado = _estado Then
                            If MessageBox.Show("¿Esta seguro de eliminar el prestamo: " & .ActiveRow.Cells("Trabajador").Value.ToString & " ?", _
                                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                Dim formulario As frm_AutenticarTrabajador
                                formulario = New frm_AutenticarTrabajador
                                formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                                If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                                    Throw New Exception("Ingrese un Clave Correcta")
                                Else
                                    oePrestamo.TipoOperacion = "E"
                                    olPrestamo.Eliminar(oePrestamo)
                                    Consultar(True)
                                End If
                            End If
                        Else
                            Throw New Exception("El Prestamo debe estar PENDIENTE para poder Eliminar")
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End With
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            _acl = gAccionSistema.EXPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If ficPrestamo.Tabs(0).Selected AndAlso griPrestamo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                If ficPrestamo.Tabs(0).Selected Then Exportar_Excel(griPrestamo)
                MyBase.Exportar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Prestamo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Case "Editar"
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Case "Inicializa"
                If griPrestamo.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_Prestamo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Prestamo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            BandCargar = True
            CargarPrestamos(New List(Of e_Prestamo))
            CargarDetalle(New List(Of e_PrestamoDetalle))
            BandCargar = False
            SeleccionaTab(0)
            agrAdicional.Visible = True : verCancelar.Checked = False
            colorPendiente.Color = Color.Transparent : colorAprobada.Color = Color.LightYellow
            colorCancelado.Color = Color.LightGreen : colorAnulada.Color = Color.LightCoral
            verCancelado.Enabled = False : chkLiquidacion.Enabled = False
            _asigfam = EjecutaFormula(gFAsignacionFamiliar, False, Nothing, leFormula, leParametro, leDetParametro)
            _porc = ObtieneValorParametro(gPPorcentajeDescuento)
            _lmonto = ObtieneValorParametro(gPMontoLimitePrest)
            'Cargar Parametros para procesar informacion
            _SueldoMin = ValorParametro(gPSueldoMinimo, leParametro, leDetParametro)
            _PorcDesc = ValorParametro(gPPorcentajeDescuento, leParametro, leDetParametro)
            _MontoDesc = _SueldoMin * _PorcDesc / 100
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griPrestamo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griPrestamo.DoubleClick
        If griPrestamo.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Desea Cancelar el Operacion en Cuota?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            BandGenera = False
            MostrarTabs(0, ficCuota)
        End If
    End Sub

    Private Sub decImporte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImporte.ValueChanged
        If IsDBNull(decImporte.Value) Then decImporte.Value = 0
    End Sub

    Private Sub fecFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFecha.ValueChanged
        oePrestamo.Fecha = fecFecha.Value
    End Sub

    Private Sub cboTrabajador_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajador.ValueChanged
        Dim _sueldo As Double = 0
        Dim dtAux As Data.DataTable
        If cboTrabajador.SelectedIndex > -1 Then
            oePrestamo.IdTrabajador = cboTrabajador.Value
            oeTrabajador = New e_Trabajador
            oeTrabajador.Id = cboTrabajador.Value
            oeTrabajador.TipoBusca = 1
            If leTrabajador.Contains(oeTrabajador) Then
                oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                dtAux = FiltraDTable(dtSituacion, "CODIGO = '" & oeTrabajador.IndEstado & "'", "")
                If dtAux.Rows.Count > 0 Then txtEstado.Text = dtAux.Rows(0).Item("NOMBRE").ToString
                txtDni.Text = oeTrabajador.oePersona.Dni
                txtArea.Text = oeTrabajador.oeArea.Nombre
                txtOcupacion.Text = oeTrabajador.oeOcupacion.Nombre
                'If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then picTrabajador.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
                oeSueldo = New e_SueldoTrabajador
                oeSueldo.IdTrabajador = oeTrabajador.Id
                oeSueldo.Equivale = 1
                If leSueldo.Contains(oeSueldo) Then
                    oeSueldo = leSueldo.Item(leSueldo.IndexOf(oeSueldo))
                    _sueldo = oeSueldo.Sueldo
                End If
                ndRenumeracion.Value = _sueldo + IIf(oeTrabajador.IndHijo = 1, _asigfam, 0)
                ndDeuda.Value = 0 : ndTotalCuota.Value = 0 : ndTotalCuota.Appearance.BackColor = Color.Transparent
            End If
        End If
    End Sub

    Private Sub cboConcepto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.ValueChanged
        Try
            If cboConcepto.SelectedIndex > -1 Then
                oePrestamo.IdConcepto = cboConcepto.Value
                If cboTrabajador.SelectedIndex = -1 Then
                    cboConcepto.SelectedIndex = -1
                    cboTrabajador.Focus()
                    Throw New Exception("Seleccione Trabajador para Evaluar Cargo")
                End If
                If oePrestamo.TipoOperacion = "I" Then
                    numCuota.ReadOnly = False
                    Select Case cboConcepto.Text.Trim
                        Case "ADELANTOS"
                            numCuota.Value = 1
                            numCuota.ReadOnly = True
                        Case "BOLSA DE VIAJE"
                            numCuota.Value = 1
                            numCuota.ReadOnly = True
                    End Select
                    txtGlosa.Focus()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboConcepto_Validated(sender As Object, e As EventArgs) Handles cboConcepto.Validated
        Dim _lsMsg As String = ""
        If cboConcepto.SelectedIndex > -1 AndAlso oePrestamo.TipoOperacion = "I" Then
            'Select Case cboConcepto.Text.Trim
            '    Case "ADELANTOS"
            '        _lsMsg = "Sólo se le puede Cargar a su Cuenta como máximo " & (ndRenumeracion.Value * _porc / 100) & Environment.NewLine & _
            '            " (*) El " & _porc & "% de su Renumeración" & Environment.NewLine & _
            '            " (*) El Monto Entregado se le descontará en una sóla cuota"
            '    Case "BOLSA DE VIAJE"
            '        _lsMsg = "Sólo se le puede Cargar a su Cuenta como máximo " & (ndRenumeracion.Value * _porc / 100) & Environment.NewLine & _
            '            " (*) El " & _porc & "% de su Renumeración" & Environment.NewLine & _
            '            " (*) El Monto Entregado se le descontará en una sóla cuota"
            '    Case "PRESTAMOS"
            '        _lsMsg = "Sólo se le puede Cargar a su Cuenta como máximo " & (ndRenumeracion.Value * _porc / 100) & Environment.NewLine & _
            '            " (*) El " & _porc & "% de su Renumeración" & Environment.NewLine & _
            '            " (*) El Monto Entregado se le descontará en una sóla cuota"
            '    Case Else
            '        _lsMsg = "Sólo se le puede Cargar a su Cuenta como máximo " & (ndRenumeracion.Value * _porc / 100) & Environment.NewLine & _
            '                    " (*) El " & _porc & "% de su Renumeración" & Environment.NewLine & _
            '                    " (*) El Monto Entregado se le descontará en una sóla cuota"
            'End Select
            'MessageBox.Show(_lsMsg, "Mensaje de Sistema")
        End If
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oePrestamo.Glosa = txtGlosa.Text
    End Sub

    Private Sub decMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decMonto.ValueChanged
        If IsDBNull(decMonto.Value) Then decMonto.Value = 0
        oePrestamo.Monto = decMonto.Value
        If cboEstado.Text = "PENDIENTE" Or oePrestamo.IdEstado.Trim = "1CH00016" Then
            decSaldo.Value = decMonto.Value
        End If
    End Sub

    Private Sub decSaldo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decSaldo.ValueChanged
        oePrestamo.Saldo = decSaldo.Value
    End Sub

    Private Sub numCuota_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numCuota.ValueChanged
        oePrestamo.CantidadCuotas = numCuota.Value
    End Sub

    Private Sub cboTrabajador_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajador.Validated
        Try
            If cboTrabajador.SelectedIndex > -1 Then
                Dim _oePrestAux As New e_Prestamo
                _oePrestAux.TipoOperacion = ""
                _oePrestAux.IdTrabajador = cboTrabajador.Value
                Dim _leEst = leEstado.Where(Function(it) it.Nombre = "APROBADA").ToList
                If _leEst.Count > 0 Then _oePrestAux.IdEstado = _leEst(0).Id
                _lePrestAux = olPrestamo.Listar(_oePrestAux)
                If _lePrestAux.Count > 0 Then
                    ndDeuda.Value = _lePrestAux.Sum(Function(it) it.Saldo)
                    oePagoDescuento = New e_PagoDescuento
                    oePagoDescuento.TipoOperacion = "A"
                    oePagoDescuento.IdTrabajador = cboTrabajador.Value
                    lePagoDescuento = olPagoDescuento.Listar(oePagoDescuento)
                    If lePagoDescuento.Count > 0 Then ndTotalCuota.Value = lePagoDescuento.Sum(Function(it) it.Cuota)
                    If ndRenumeracion.Value * _porc / 100 <= ndTotalCuota.Value Then
                        ndTotalCuota.Appearance.BackColor = Color.Red
                        MessageBox.Show("El Trabajador ha Superado el límite de Descuento por Mes." & Environment.NewLine & _
                                        _porc & " % de Renumeracion ---> " & (ndRenumeracion.Value * _porc / 100), "Mensaje de Sistema", _
                                        MessageBoxButtons.OK, MessageBoxIcon.Question)
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDetalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Quitar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Not BandGenera Then
                If decImporte.Value = 0 Then decImporte.Focus() : Throw New Exception("Ingrese Importe")
                RecoletaDetalle()
                If Not bandact AndAlso oePrestamoDetalle.TipoOperacion = "I" Then
                    lePrestamoDetalle.Add(oePrestamoDetalle)
                End If
                bandact = False
                CargarDetalle(lePrestamoDetalle)
                MostrarTabs(0, ficCuota)
            Else
                'If decMonto.Value = 0 Then Throw New Exception("Ingrese Monto de Prestamo")
                'Dim montoAux As Decimal = 0
                'Dim fecpre As Date = fecPerido.Value
                'fecpre = fecpre.AddMonths(-1)
                'Dim xa As Integer = 1
                'For i As Integer = 1 To numCuota.Value
                '    fecpre = fecpre.AddMonths(xa)
                '    If xa = 0 Then
                '        xa = 1
                '    Else
                '        If fecpre.Month = 7 Or fecpre.Month = 12 Then
                '            xa = 0
                '        End If
                '    End If
                '    oePrestamoDetalle = New e_PrestamoDetalle
                '    oePrestamoDetalle.NroCuota = FormatoDocumento(i, 3)
                '    oePrestamoDetalle.DobleMes = IIf(xa = 0, 1, 0)
                '    oePrestamoDetalle.TipoOperacion = "I"
                '    oePrestamoDetalle.UsuarioCreacion = gUsuarioSGI.Id
                '    oePrestamoDetalle.Anio = fecpre.Year
                '    oePrestamoDetalle.Mes = FormatoDocumento(fecpre.Month, 2)
                '    If numCuota.Value = i Then
                '        oePrestamoDetalle.Importe = Math.Round(oePrestamo.Monto - montoAux, 2)
                '    Else
                '        oePrestamoDetalle.Importe = Math.Round(decMonto.Value / numCuota.Value, 2)
                '    End If
                '    montoAux = montoAux + oePrestamoDetalle.Importe
                '    'oePrestamoDetalle.Importe = Math.Round(decMonto.Value / numCuota.Value, 2)
                '    lePrestamoDetalle.Add(oePrestamoDetalle)
                'Next
                lePrestamoDetalle.AddRange(GenerarCuotas(decMonto.Value, fecPerido.Value, numCuota.Value))
                CargarDetalle(lePrestamoDetalle)
                griDetalle.DataBind()
                MostrarTabs(0, ficCuota)
                BandGenera = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    'Private Function GenerarCuotas(ByVal MontoPrestamo As Decimal, ByVal fecpre As Date, ByVal NunCuota As Integer, Optional InicioNumCuota As Integer = 0) As List(Of e_PrestamoDetalle)
    '    Try
    '        Dim listaPrestamoDetalle As New List(Of e_PrestamoDetalle)
    '        If MontoPrestamo = 0 Then Throw New Exception("Ingrese Monto de Prestamo")
    '        Dim montoAux As Decimal = 0
    '        fecpre = fecpre.AddMonths(-1)
    '        Dim xa As Integer = 1
    '        For i As Integer = 1 To NunCuota
    '            fecpre = fecpre.AddMonths(xa)
    '            If xa = 0 Then
    '                xa = 1
    '            Else
    '                If fecpre.Month = 7 Or fecpre.Month = 12 Then
    '                    xa = 0
    '                End If
    '            End If
    '            oePrestamoDetalle = New e_PrestamoDetalle
    '            oePrestamoDetalle.NroCuota = FormatoDocumento(i + InicioNumCuota, 3)
    '            oePrestamoDetalle.DobleMes = IIf(xa = 0, 1, 0)
    '            oePrestamoDetalle.TipoOperacion = "I"
    '            oePrestamoDetalle.UsuarioCreacion = gUsuarioSGI.Id
    '            oePrestamoDetalle.Anio = fecpre.Year
    '            oePrestamoDetalle.Mes = FormatoDocumento(fecpre.Month, 2)
    '            If NunCuota = i Then
    '                oePrestamoDetalle.Importe = Math.Round(MontoPrestamo - montoAux, 2)
    '            Else
    '                oePrestamoDetalle.Importe = Math.Round(MontoPrestamo / NunCuota, 2)
    '            End If
    '            montoAux = montoAux + oePrestamoDetalle.Importe
    '            listaPrestamoDetalle.Add(oePrestamoDetalle)
    '        Next
    '        Return listaPrestamoDetalle
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try

    'End Function

    Private Sub decMontoCom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decMontoCom.ValueChanged
        Try
            If IsDBNull(decMontoCom.Value) Then decMontoCom.Value = 0
            If decMontoCom.Value > 0 Then
                If decMontoCom.Value > CalculaSaldo() Then Throw New Exception("No puede transferir una cantidad mayor con el saldo.")
                ndMontoAct.Value = decMonto.Value - decMontoCom.Value
                ndSaldoAct.Value = CalculaSaldo() - decMontoCom.Value
            Else
                ndMontoAct.Value = decMonto.Value : ndSaldoAct.Value = CalculaSaldo()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            ndMontoAct.Value = decMonto.Value : ndSaldoAct.Value = CalculaSaldo() : decMontoCom.Value = 0
        End Try
    End Sub

    Private Sub agrPagar_ExpandedStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agrPagar.ExpandedStateChanged
        If agrPagar.Expanded Then
            decSaldoPenCta.Value = decSaldo.Value
        Else
            decSaldoPenCta.Value = 0
        End If
        decMontoPagCta.Value = 0
        txtGlosaCuota.Text = ""
    End Sub

    Private Sub decMontoPagCta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decMontoPagCta.ValueChanged
        If IsDBNull(decMontoPagCta.Value) Then decMontoPagCta.Value = 0
        decSaldoPenCta.Value = decSaldo.Value - decMontoPagCta.Value
    End Sub

    Private Sub btnPagarCuota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarCuota.Click
        Try
            If decMontoPagCta.Value = 0 Then Throw New Exception("El Monto a Pagar debe ser Mayor a Cero.")
            If decMontoPagCta.Value > decSaldo.Value Then Throw New Exception("El Monto no puede Sueprar al Saldo")
            Dim xPago As Double = decMontoPagCta.Value
            Dim oePresDetTemp As New e_PrestamoDetalle
            Dim leDet As New List(Of e_PrestamoDetalle)
            'leDet = lePrestamoDetalle.Where(Function(item) item.Cancelado = 0).ToList
            If lePrestamoDetalle.Count > 0 Then
                For Each oePDet As e_PrestamoDetalle In lePrestamoDetalle.Where(Function(item) item.Cancelado = 0).ToList
                    If xPago > 0 Then
                        If oePDet.Importe > xPago Then
                            oePDet.TipoOperacion = "A"
                            oePDet.Importe = xPago
                            oePDet.Cancelado = 1
                            oePDet.Glosa = txtGlosaCuota.Text
                            oePDet.Fecha = fecPago.Value
                            xPago = 0
                        Else
                            xPago = xPago - oePDet.Importe
                            oePDet.TipoOperacion = "A"
                            oePDet.Cancelado = 1
                            oePDet.Fecha = fecPago.Value
                            oePDet.Glosa = txtGlosaCuota.Text
                        End If
                    Else
                        Exit For
                    End If
                Next
                If xPago > 0 Then
                    oePresDetTemp = New e_PrestamoDetalle
                    oePresDetTemp.TipoOperacion = "I"
                    oePresDetTemp.NroCuota = lePrestamoDetalle.Count + 1
                    oePresDetTemp.IdPrestamo = oePrestamo.Id
                    oePresDetTemp.Mes = FormatoDocumento(fecPago.Value.Month.ToString, 2)
                    oePresDetTemp.Anio = fecPago.Value.Year
                    oePresDetTemp.Cancelado = 1
                    oePresDetTemp.Importe = xPago
                    oePresDetTemp.DobleMes = 0
                    oePresDetTemp.Fecha = fecPago.Value
                    oePresDetTemp.Glosa = txtGlosaCuota.Text
                    lePrestamoDetalle.Add(oePresDetTemp)
                End If
            Else
                oePresDetTemp = New e_PrestamoDetalle
                oePresDetTemp.TipoOperacion = "I"
                oePresDetTemp.NroCuota = 1
                oePresDetTemp.IdPrestamo = oePrestamo.Id
                oePresDetTemp.Mes = FormatoDocumento(fecPago.Value.Month.ToString, 2)
                oePresDetTemp.Anio = fecPago.Value.Year
                oePresDetTemp.Cancelado = 1
                oePresDetTemp.DobleMes = 0
                oePresDetTemp.Importe = xPago
                oePresDetTemp.Glosa = txtGlosaCuota.Text
                oePresDetTemp.Fecha = fecPago.Value
                lePrestamoDetalle.Add(oePresDetTemp)
            End If
            oePrestamo.Saldo = decSaldoPenCta.Value
            If oePrestamo.CtaBancaria Is Nothing Then oePrestamo.CtaBancaria = New e_CuentaBancaria
            oePrestamo.PrefijoID = gs_PrefijoIdSucursal '@0001
            olPrestamo.Guardar(oePrestamo)
            decSaldo.Value = decSaldoPenCta.Value
            ' olPrestamoDetalle.GuardarLista(lePrestamoDetalle)
            agrPagar.Expanded = False
            oePresDetTemp.TipoOperacion = ""
            oePresDetTemp.IdPrestamo = oePrestamo.Id
            oePresDetTemp.Cancelado = -1
            oePresDetTemp.Anulado = 0
            oePresDetTemp.Activo = 1
            lePrestamoDetalle = olPrestamoDetalle.Listar(oePresDetTemp)
            CargarDetalle(lePrestamoDetalle)
            mensajeEmergente.Confirmacion("Se Pago Correctamente su cuota", True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelaCta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelaCta.Click
        If MessageBox.Show("¿Desea Cancelar la Operación", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            agrPagar.Expanded = False
        End If
    End Sub

    Private Sub colorCancelado_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorCancelado.ColorChanged
        etiCancelado.Appearance.BackColor = colorCancelado.Color
    End Sub

    Private Sub cboCuentaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaBancaria.ValueChanged
        oePrestamo.IdCtaBancaria = cboCuentaBancaria.Value
    End Sub

    Private Sub ndDeuda_DoubleClick(sender As Object, e As EventArgs) Handles ndDeuda.DoubleClick
        Dim _lsMsg As String = ""
        If _lePrestAux.Count > 0 Then
            _lsMsg = "Relación de Cargos a Cuenta del Trabajador: " & cboTrabajador.Text & Environment.NewLine
            For Each _oeAux In _lePrestAux
                _lsMsg = _lsMsg & " --> Fecha: " & _oeAux.Fecha & " || Concepto: " & _oeAux.Concepto & " || Saldo: " & _oeAux.Saldo & Environment.NewLine
            Next
            MessageBox.Show(_lsMsg, "Mensaje de Sistema")
        End If
    End Sub

    Private Sub ndTotalCuota_DoubleClick(sender As Object, e As EventArgs) Handles ndTotalCuota.DoubleClick
        Dim _lsMsg As String = ""
        If lePagoDescuento.Count > 0 Then
            _lsMsg = "Relación de Cuotas Mensual del Trabajador: " & cboTrabajador.Text & Environment.NewLine
            _lsMsg = _lsMsg & " (*) Límite Descuento por Mes: " & (ndRenumeracion.Value * _porc / 100) & Environment.NewLine
            _lsMsg = _lsMsg & " (*) Crédito Disponible: " & ((ndRenumeracion.Value * _porc / 100) - ndTotalCuota.Value) & Environment.NewLine
            For Each _oeAux In lePagoDescuento
                _lsMsg = _lsMsg & " --> Concepto: " & _oeAux.CadIdPrestamoDet & " || Cuota: " & _oeAux.Cuota & Environment.NewLine
            Next
            MessageBox.Show(_lsMsg, "Mensaje de Sistema")
        End If
    End Sub

    Private Sub griDetalle_DoubleClick(sender As Object, e As EventArgs) Handles griDetalle.DoubleClick
        EditarDetalle()
    End Sub

    Private Sub cboTipoPago_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoPago.ValueChanged
        If cboTipoPago.SelectedIndex > -1 Then
            Select Case cboTipoPago.SelectedIndex
                Case 0
                    cboTipoMoneda.SelectedIndex = -1 : cboTipoMoneda.ReadOnly = False
                    'cboCtaBancariaDep.SelectedIndex = -1 : cboCtaBancariaDep.ReadOnly = False
                    'txtNroOperacion.Value = String.Empty : txtNroOperacion.ReadOnly = False
                    _pereje = "DEPOSIT"
                Case 1
                    cboTipoMoneda.Text = "SOLES" : cboTipoMoneda.ReadOnly = True
                    'cboCtaBancariaDep.SelectedIndex = -1 : cboCtaBancariaDep.ReadOnly = True
                    'txtNroOperacion.Value = String.Empty : txtNroOperacion.ReadOnly = True
                    _pereje = "LIQUIDA"
                Case 2
                    cboTipoMoneda.Text = "SOLES" : cboTipoMoneda.ReadOnly = True
                    'cboCtaBancariaDep.SelectedIndex = -1 : cboCtaBancariaDep.ReadOnly = True
                    'txtNroOperacion.Value = String.Empty : txtNroOperacion.ReadOnly = True
                    _pereje = IIf(chkLiquidacion.Checked, "CONDLIQ", "CONDNOM")
            End Select
            GeneraGlosa()
        End If
    End Sub

    Private Sub cboTipoMoneda_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoMoneda.ValueChanged
        If cboTipoMoneda.SelectedIndex > -1 Then
            'Dim _leCtaBan = leCtaBancaria.Where(Function(it) it.IdMoneda = cboTipoMoneda.Value).ToList
            'If _leCtaBan.Count > 0 Then LlenarCombo(cboCtaBancariaDep, "BancoCuenta", _leCtaBan, -1)
            CalcularCambioMoneda()
            GeneraGlosa()
            'Else
            '    cboCtaBancariaDep.SelectedIndex = -1
            '    LlenarCombo(cboCtaBancariaDep, "BancoCuenta", New List(Of e_CuentaBancaria), -1)
        End If
    End Sub

    Private Sub fecDeposito_ValueChanged(sender As Object, e As EventArgs) Handles fecDeposito.ValueChanged
        ndTipoCambio.Value = TipoCambio(fecDeposito.Value, True)(0)
        CalcularCambioMoneda() : GeneraGlosa()
    End Sub

    Private Sub decMontoDep_ValueChanged(sender As Object, e As EventArgs) Handles decMontoDep.ValueChanged
        Try
            If ndTipoCambio.Value = 0 Then Throw New Exception("No hay Tipo Cambio")
            If decMontoDep.Value > ndDeudaCargo.Value Then Throw New Exception("El Monto supera la Deuda: " & ndDeudaCargo.Value)
            CalcularCambioMoneda() : GeneraGlosa()
            _saldocob = ndSoles.Value - ndCobrado.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            decMontoDep.Value = 0 : decMontoDep.Focus()
        End Try
    End Sub

    Private Sub griPrestamoPend_DoubleClick(sender As Object, e As EventArgs) Handles griPrestamoPend.DoubleClick
        Try
            If leCargoPend.Count > 0 Then
                If decMontoDep.Value = 0 Then decMontoDep.Focus() : Throw New Exception("Ingrese Monto a Cobrar")
                If agrCuotaCP.Visible Then fecCCP.Focus() : Throw New Exception("Ingrese Datos de Cuota")
                oePrestamo = New e_Prestamo
                oePrestamo.Equivale = 0
                oePrestamo.Id = griPrestamoPend.ActiveRow.Cells("Id").Value
                If leCargoPend.Contains(oePrestamo) Then
                    oePrestamo = leCargoPend.Item(leCargoPend.IndexOf(oePrestamo))
                    fecCCP.Value = oePrestamo.Fecha
                    txtConceptoCCP.Text = oePrestamo.Concepto
                    decSaldoCCP.Value = oePrestamo.Saldo
                    If oePrestamo.Saldo > 0 Then btnAgregarCCP.Enabled = True : btnQuitarCCP.Enabled = True
                    Dim _leCCPAux = leCuotaCargoPend.Where(Function(it) it.IdPrestamo = oePrestamo.Id And it.Activo = True).ToList
                    CargarCuotaCargoPend(_leCCPAux)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarCCP_Click(sender As Object, e As EventArgs) Handles btnAgregarCCP.Click
        Dim _MontoAux As Double = 0
        If _saldocob > 0 Then
            If griCuotaCargoPend.Rows.Count > 0 Then
                _MontoAux = griCuotaCargoPend.Rows.Where(Function(it) it.Cells("Cancelado").Value = 0).Sum(Function(it) it.Cells("Importe").Value)
            End If
            If _MontoAux > 0 Then
                mensajeEmergente.Confirmacion("Tiene Cuotas Pendientes por Cobrar", True)
            Else
                If _saldocob >= decSaldoCCP.Value Then
                    decImporteCuota.Value = decSaldoCCP.Value
                Else
                    decImporteCuota.Value = _saldocob
                End If
                agrCuotaCP.Visible = True : fecPeriodoCuota.Focus()
            End If
        Else
            mensajeEmergente.Problema("Ya se ha Cobrado el Monto Ingresado", True)
        End If
    End Sub

    Private Sub btnQuitarCCP_Click(sender As Object, e As EventArgs) Handles btnQuitarCCP.Click
        Try
            If griCuotaCargoPend.Selected.Rows.Count > 0 Then
                If griCuotaCargoPend.ActiveRow.Cells("Cancelado").Value = 1 Then Throw New Exception("No se puede quitar una cuota cobrada")
                oePrestamoDetalle = New e_PrestamoDetalle
                oePrestamoDetalle.Equivale = 2
                oePrestamoDetalle.IdPrestamo = oePrestamo.Id
                oePrestamoDetalle.NroCuota = griCuotaCargoPend.ActiveRow.Cells("NroCuota").Value
                If leCuotaCargoPend.Contains(oePrestamoDetalle) Then
                    oePrestamoDetalle = leCuotaCargoPend.Item(leCuotaCargoPend.IndexOf(oePrestamoDetalle))
                    If oePrestamoDetalle.Id <> "" Then
                        oePrestamoDetalle.TipoOperacion = "A"
                        oePrestamoDetalle.Activo = False
                        oePrestamoDetalle.Cancelado = 0
                        oePrestamoDetalle.Fecha = #1/1/1901#
                        oePrestamoDetalle.Glosa = String.Empty
                        oePrestamoDetalle.PeriodoEjec = String.Empty
                    Else
                        leCuotaCargoPend.Remove(oePrestamoDetalle)
                    End If
                    'Dim _oePAux As New e_Prestamo
                    '_oePAux.Equivale = 0
                    '_oePAux.Id = oePrestamo.Id
                    'If leCargoPend.Contains(_oePAux) Then
                    '    _oePAux = leCargoPend.Item(leCargoPend.IndexOf(_oePAux))
                    '    _oePAux.TipoOperacion = "A"
                    '    _oePAux.Saldo = _oePAux.Saldo + oePrestamoDetalle.Importe
                    '    _saldocob = _saldocob + oePrestamoDetalle.Importe
                    '    decSaldoCCP.Value = _oePAux.Saldo
                    '    If _oePAux.Saldo > 0 Then
                    '        _oePAux.Cancelado = 0
                    '        _estado = gEstadosSGI.APROBADA.ToString
                    '        Dim _leEAux = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                    '        If _leEAux.Count > 0 Then _oePAux.IdEstado = _leEAux(0).Id
                    '    End If
                    'End If
                    'CargarCargosPend(leCargoPend)
                End If
                Dim _leCCPAux = leCuotaCargoPend.Where(Function(it) it.IdPrestamo = oePrestamo.Id And it.Activo = True).ToList
                CargarCuotaCargoPend(_leCCPAux)
                ndCobrado.Value = leCuotaCargoPend.Where(Function(it) it.Cancelado = 1 And it.Activo = True).Sum(Function(it) it.Importe)
            Else
                Throw New Exception("Seleccione una Cuota para Quitar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If decImporteCuota.Value = 0 Then Throw New Exception("Ingrese Monto de Cuota")
            Dim _leAux = leCPUltCP.Where(Function(it) it.Id = oePrestamo.Id).ToList
            If _leAux.Count > 0 Then
                Dim _saldoaux = Math.Round((ndSoles.Value - ndCobrado.Value), 2)
                If _saldoaux >= decImporteCuota.Value Then
                    _saldocob = _saldoaux - decImporteCuota.Value
                Else
                    _saldocob = _saldoaux
                    Throw New Exception("El Monto a Cobrar (" & decImporteCuota.Value & ") es mayor al Monto ingresado (" & _
                                        _saldocob & ")")
                End If
                oePrestamoDetalle = New e_PrestamoDetalle
                oePrestamoDetalle.TipoOperacion = "I"
                oePrestamoDetalle.Activo = True
                oePrestamoDetalle.IdPrestamo = oePrestamo.Id
                oePrestamoDetalle.NroCuota = FormatoDocumento((_leAux(0).CantidadCuotas + 1), 3)
                oePrestamoDetalle.Anio = fecPeriodoCuota.Value.Year.ToString
                oePrestamoDetalle.Mes = FormatoDocumento(fecPeriodoCuota.Value.Month.ToString, 2)
                oePrestamoDetalle.Importe = decImporteCuota.Value
                oePrestamoDetalle.Fecha = Date.Now.Date
                oePrestamoDetalle.UsuarioCreacion = gUsuarioSGI.Id
                oePrestamoDetalle.Cancelado = 1
                oePrestamoDetalle.Glosa = txtDescripconDep.Text
                oePrestamoDetalle.PeriodoEjec = _pereje
                leCuotaCargoPend.Add(oePrestamoDetalle)
                Dim _oePAux As New e_Prestamo
                _oePAux.Equivale = 0
                _oePAux.Id = oePrestamo.Id
                If leCargoPend.Contains(_oePAux) Then
                    _oePAux = leCargoPend.Item(leCargoPend.IndexOf(_oePAux))
                    _oePAux.TipoOperacion = "A"
                    _oePAux.CantidadCuotas = 1
                    _oePAux.Saldo = _oePAux.Saldo - oePrestamoDetalle.Importe
                    decSaldoCCP.Value = _oePAux.Saldo
                    If _oePAux.Saldo = 0 Then
                        _oePAux.Cancelado = 1
                        _estado = gNombreEstadoCancelada
                        Dim _leEAux = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                        If _leEAux.Count > 0 Then _oePAux.IdEstado = _leEAux(0).Id
                    End If
                End If
                CargarCargosPend(leCargoPend)
                Dim _leCCPAux = leCuotaCargoPend.Where(Function(it) it.IdPrestamo = oePrestamo.Id And it.Activo = True).ToList
                CargarCuotaCargoPend(_leCCPAux)
                ndCobrado.Value = leCuotaCargoPend.Where(Function(it) it.Cancelado = 1 And it.Activo = True).Sum(Function(it) it.Importe)
                agrCuotaCP.Visible = False
                mensajeEmergente.Confirmacion("Se ha generado la cuota cobrada", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelarCCP_Click(sender As Object, e As EventArgs) Handles btnCancelarCCP.Click
        If MessageBox.Show("¿Desea Cancelar la Operacion de Agregar Cuota?", "Mensaje de Sistema", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            agrCuotaCP.Visible = False
        End If
    End Sub

    Private Sub ndCobrado_ValueChanged(sender As Object, e As EventArgs) Handles ndCobrado.ValueChanged
        ndDeudaCargoAct.Value = ndSoles.Value - ndCobrado.Value
        decMontoDep.ReadOnly = IIf(ndCobrado.Value > 0, True, False)
        cboTipoMoneda.ReadOnly = IIf(ndCobrado.Value > 0, True, False)
        cboTrabajadorDep.ReadOnly = IIf(ndCobrado.Value > 0, True, False)
        cboTipoPago.ReadOnly = IIf(ndCobrado.Value > 0, True, False)
    End Sub

    Private Sub griCuotaCargoPend_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griCuotaCargoPend.ClickCell
        Try
            With griCuotaCargoPend
                If .Selected.Rows.Count = 0 Then
                    If .ActiveCell.Row.Index > -1 AndAlso .ActiveCell.Column.Key = "Cancelado" Then
                        If agrCuotaCP.Visible Then fecCCP.Focus() : Throw New Exception("Ingrese Datos de Cuota")
                        Dim _oePAux As New e_Prestamo
                        _oePAux.Equivale = 0
                        _oePAux.Id = oePrestamo.Id
                        If leCargoPend.Contains(_oePAux) Then
                            _oePAux = leCargoPend.Item(leCargoPend.IndexOf(_oePAux))
                            _oePAux.TipoOperacion = "A"
                        End If
                        oePrestamoDetalle = New e_PrestamoDetalle
                        oePrestamoDetalle.Equivale = 2
                        oePrestamoDetalle.IdPrestamo = oePrestamo.Id
                        oePrestamoDetalle.NroCuota = .ActiveRow.Cells("NroCuota").Value
                        If leCuotaCargoPend.Contains(oePrestamoDetalle) Then
                            oePrestamoDetalle = leCuotaCargoPend.Item(leCuotaCargoPend.IndexOf(oePrestamoDetalle))
                            If .ActiveRow.Cells("Cancelado").Value = False Then
                                If MessageBox.Show("¿Desea Cobrar esta Cuota?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                                   MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    If (ndSoles.Value - ndCobrado.Value) >= oePrestamoDetalle.Importe Then
                                        _saldocob = (ndSoles.Value - ndCobrado.Value) - oePrestamoDetalle.Importe
                                    Else
                                        _saldocob = (ndSoles.Value - ndCobrado.Value)
                                        .ActiveRow.Cells("Cancelado").Value = False
                                        .Update()
                                        Throw New Exception("El Monto a Cobrar (" & oePrestamoDetalle.Importe & ") es mayor al Monto ingresado (" & _
                                                            _saldocob & ")")
                                    End If
                                    oePrestamoDetalle.Cancelado = 1
                                    oePrestamoDetalle.Fecha = Date.Now.Date
                                    oePrestamoDetalle.NroCuota = FormatoDocumento(oePrestamoDetalle.NroCuota, 3)
                                    oePrestamoDetalle.TipoOperacion = IIf(oePrestamoDetalle.Id <> "", "A", "I")
                                    oePrestamoDetalle.Glosa = txtDescripconDep.Text
                                    oePrestamoDetalle.PeriodoEjec = _pereje
                                    _oePAux.Saldo = _oePAux.Saldo - oePrestamoDetalle.Importe
                                    If _oePAux.Saldo = 0 Then
                                        _oePAux.Cancelado = 1
                                        _estado = gNombreEstadoCancelada
                                        Dim _leEAux = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                                        If _leEAux.Count > 0 Then _oePAux.IdEstado = _leEAux(0).Id
                                    End If
                                End If
                            Else
                                If MessageBox.Show("¿Desea Anular el Cobro esta Cuota?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                                   MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    oePrestamoDetalle.Cancelado = 0
                                    oePrestamoDetalle.Fecha = #1/1/1901#
                                    oePrestamoDetalle.Glosa = String.Empty
                                    oePrestamoDetalle.PeriodoEjec = String.Empty
                                    _oePAux.Saldo = _oePAux.Saldo + oePrestamoDetalle.Importe
                                    _saldocob = _saldocob + oePrestamoDetalle.Importe
                                    If _oePAux.Saldo > 0 Then
                                        _oePAux.Cancelado = 0
                                        _estado = gEstadosSGI.APROBADA.ToString
                                        Dim _leEAux = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                                        If _leEAux.Count > 0 Then _oePAux.IdEstado = _leEAux(0).Id
                                    End If
                                End If
                            End If
                            decSaldoCCP.Value = _oePAux.Saldo
                            CargarCargosPend(leCargoPend)
                            Dim _leCCPAux = leCuotaCargoPend.Where(Function(it) it.IdPrestamo = oePrestamo.Id And it.Activo = True).ToList
                            CargarCuotaCargoPend(_leCCPAux)
                            ndCobrado.Value = leCuotaCargoPend.Where(Function(it) it.Cancelado = 1 And it.Activo = True).Sum(Function(it) it.Importe)
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTrabajadorDep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTrabajadorDep.KeyPress
        If cboTipoPago.SelectedIndex = -1 Then mensajeEmergente.Problema("Seleccione Tipo Pago", True) : cboTipoPago.Focus()
    End Sub

    Private Sub cboTipoMoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTipoMoneda.KeyPress
        If cboTrabajadorDep.SelectedIndex = -1 Then mensajeEmergente.Problema("Seleccione Trabajador", True) : cboTrabajadorDep.Focus()
    End Sub

    Private Sub decMontoDep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles decMontoDep.KeyPress
        If cboTipoMoneda.SelectedIndex = -1 Then mensajeEmergente.Problema("Seleccione Moneda", True) : cboTipoMoneda.Focus()
        'If cboTipoMoneda.SelectedIndex > -1 And cboTipoPago.SelectedIndex = 0 And txtNroOperacion.Text.Trim = "" Then
        '    mensajeEmergente.Problema("Ingrese Numero Operacion", True) : txtNroOperacion.Focus()
        'End If
    End Sub

    Private Sub decSaldoCCP_ValueChanged(sender As Object, e As EventArgs) Handles decSaldoCCP.ValueChanged
        btnAgregarCCP.Enabled = IIf(decSaldoCCP.Value > 0, True, False)
    End Sub

    Private Sub decImporteCuota_ValueChanged(sender As Object, e As EventArgs) Handles decImporteCuota.ValueChanged
        Try
            If decImporteCuota.Value > 0 Then
                If decImporteCuota.Value > decSaldoCCP.Value Then Throw New Exception("Ingrese otro Monto. El Saldo de la deuda es: " & decSaldoCCP.Value)
                If decImporteCuota.Value > _saldocob Then Throw New Exception("Ingrese otro Monto. Le queda por cobrar: " & _saldocob)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            decImporteCuota.Focus() : decImporteCuota.Value = 0
        End Try
    End Sub

    Private Sub btnLiqCobrar_Click(sender As Object, e As EventArgs) Handles btnLiqCobrar.Click
        If cboTrabajadorBus.SelectedIndex < 1 Then
            mensajeEmergente.Problema("Seleccione un Trabajador", True) : cboTrabajadorBus.Focus()
        Else
            chkLiquidacion.Visible = False : chkLiquidacion.Checked = False
            Cobrar() : cboTrabajadorDep.Value = cboTrabajadorBus.Value
            cboTrabajadorDep.ReadOnly = True : CargarDscto(1)
        End If
    End Sub

    Private Sub btnCondonar_Click(sender As Object, e As EventArgs) Handles btnCondonar.Click
        If cboTrabajadorBus.SelectedIndex < 1 Then
            mensajeEmergente.Problema("Seleccione un Trabajador", True) : cboTrabajadorBus.Focus()
        Else
            chkLiquidacion.Visible = True : chkLiquidacion.Checked = True
            Condonar() : cboTrabajadorDep.Value = cboTrabajadorBus.Value
            cboTrabajadorDep.ReadOnly = True : CargarDscto(1)
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub LlenaCuentaBancaria()
        Try
            Dim oeCtaBancaria As New e_CuentaBancaria
            Dim leCuentaBancaria As New List(Of e_CuentaBancaria)
            Dim olCtaBancaria As New l_CuentaBancaria
            oeCtaBancaria.Activo = True
            'oeCtaBancaria.IdMoneda = "1ch01"
            leCuentaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
            oeCtaBancaria = New e_CuentaBancaria
            oeCtaBancaria.BancoCuenta = "NINGUNO"
            oeCtaBancaria.Id = ""
            leCuentaBancaria.Add(oeCtaBancaria)
            LlenarCombo(cboCuentaBancaria, "BancoCuenta", leCuentaBancaria, -1)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCombos()
        Try

            oeTrabajador = New e_Trabajador
            oeTrabajador.Id = "" : oeTrabajador.oePersona.ApellidoPaterno = "TODOS"
            leTrabajadorBus.Add(oeTrabajador)

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            leTrabajadorBus.AddRange(leTrabajador.OrderBy(Function(it) it.oePersona.NombreCompleto).ToList)
            ' _leTrabBus[Lista] (Id, NombreCompleto) {e_Trabajador}
            Dim _leTrabBus = From le In leTrabajadorBus Select le.Id, le.oePersona.NombreCompleto
            LlenarCombo(cboTrabajadorBus, "NombreCompleto", _leTrabBus.ToList, 0)

            oeConceptoPres = New e_Concepto_Prestamo
            oeConceptoPres.TipoOperacion = String.Empty : oeConceptoPres.Tipo = 1
            leConceptoPres = olConceptoPres.Listar(oeConceptoPres)
            LlenarCombo(cboConcepto, "Nombre", leConceptoPres, -1)

            leConceptoAux = New List(Of e_Concepto_Prestamo)
            leConceptoAux = leConceptoPres.Where(Function(item) item.Nombre = gCPPrestamos).ToList
            IdPrestamo = leConceptoAux(0).Id
            leConceptoAux = New List(Of e_Concepto_Prestamo)
            leConceptoAux = leConceptoPres.Where(Function(item) item.Nombre = gCPAdelantos).ToList
            IdAdelanto = leConceptoAux(0).Id

            LlenaCuentaBancaria()

            oeEstado = New e_Estado
            oeEstado.Nombre = "PRESTAMO"
            leEstado = olEstado.Listar(oeEstado)
            LlenarCombo(cboEstado, "Nombre", leEstado, -1)

            Dim _leEstaAux As New List(Of e_Estado)
            oeEstado = New e_Estado
            oeEstado.Id = "" : oeEstado.Nombre = " [TODOS] "
            _leEstaAux.Add(oeEstado)
            _leEstaAux.AddRange(leEstado)
            LlenarCombo(cboEstadoBus, "Nombre", _leEstaAux, 1)

            oeSueldo = New e_SueldoTrabajador
            oeSueldo.TipoOperacion = ""
            oeSueldo.Activo = True : oeSueldo.Vigente = 1
            leSueldo = olSueldo.Listar(oeSueldo)

            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = "" : oeParametro.Activo = True
            leParametro = olParametro.Listar(oeParametro)

            oeDetParametro = New e_DetalleAporteDescuento
            oeDetParametro.TipoOperacion = ""
            oeDetParametro.Activo = True : oeDetParametro.Vigencia = 1
            leDetParametro = olDetParametro.Listar(oeDetParametro)

            oeFormula = New e_Formula
            oeFormula.TipoOperacion = "" : oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)

            dtSituacion = GenerarDTConfigurable(CargarCTCD("T15_Situacion"))

            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            leMoneda = olMoneda.Listar(oeMoneda)
            LlenarCombo(cboTipoMoneda, "Nombre", leMoneda, -1)

            oeCtaBancaria = New e_CuentaBancaria
            oeCtaBancaria.Activo = True
            leCtaBancaria = olCtaBancaria.Listar(oeCtaBancaria)

            oeEmpresa = New e_Empresa
            oeEmpresa.TipoOperacion = "" : oeEmpresa.Activo = True
            leEmpresa = olEmpresa.Listar(oeEmpresa).Where(Function(it) it.TipoEmpresa = "ENTIDADES FINANCIERAS").ToList

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            'ValidarFechaDesde_Hasta(fecDesde, fecHasta)
            oePrestamo = New e_Prestamo
            oePrestamo.TipoOperacion = ""
            oePrestamo.Activo = 1
            oePrestamo.TipoOperacion = String.Empty
            oePrestamo.IdTrabajador = cboTrabajadorBus.Value
            oePrestamo.fecInicio = #1/1/1901#  'fecDesde.Value
            oePrestamo.fecFin = #1/1/1901# 'fecHasta.Value
            oePrestamo.IdEstado = cboEstadoBus.Value
            'oePrestamo.Cancelado = IIf(verCancelar.Checked, 1, 0)
            CargarPrestamos(olPrestamo.Listar(oePrestamo))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griPrestamo.Focus()
    End Sub

    Public Sub CargarPrestamos(ByVal lePrest As List(Of e_Prestamo))

        With griPrestamo

            .DataSource = lePrest.OrderBy(Function(i) i.Fecha).ToList

            If BandCargar Then
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key.Contains("Id") Then Col.Hidden = True
                Next

                OcultarColumna(griPrestamo, True, "Activo", "FechaCreacion", "UsuarioCreacion", "Cancelado", "GlosaCancelado", "FechaCancelado", _
                               "FechaIntegracion", "UsuarioAprueba", "FechaAprueba")

                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Concepto").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("CantidadCuotas").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Saldo").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("FechaCese").Header.VisiblePosition = 7

                '.DisplayLayout.Bands(0).Columns("Fecha").SortIndicator = SortOrder.Ascending

                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 300
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 70
                .DisplayLayout.Bands(0).Columns("Monto").Width = 80
                .DisplayLayout.Bands(0).Columns("CantidadCuotas").Width = 40
                .DisplayLayout.Bands(0).Columns("Saldo").Width = 80
                .DisplayLayout.Bands(0).Columns("Concepto").Width = 100

                FormatoColumna(griPrestamo, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto", "Saldo")
                FormatoColumna(griPrestamo, "", ColumnStyle.Default, HAlign.Center, "CantidadCuotas")

                .DisplayLayout.Bands(0).Columns("CantidadCuotas").Header.Caption = "Cuotas"

                CalcularTotales(griPrestamo, "Monto", "Saldo")

                .Font = New System.Drawing.Font("Tahoma", 8.25!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End If

            If .Rows.Count > 0 Then
                For Each oFila As UltraGridRow In .Rows
                    Select Case oFila.Cells("Estado").Value
                        Case "PENDIENTE" : oFila.Cells("Estado").Appearance.BackColor = colorPendiente.Color
                        Case "APROBADA" : oFila.Cells("Estado").Appearance.BackColor = colorAprobada.Color
                        Case "CANCELADA" : oFila.Cells("Estado").Appearance.BackColor = colorCancelado.Color
                        Case "ANULADO" : oFila.Cells("Estado").Appearance.BackColor = colorAnulada.Color
                    End Select
                    Select Case oFila.Cells("FechaCese").Value
                        Case Is <> "01/01/1901" : oFila.Cells("FechaCese").Appearance.BackColor = Color.Pink
                    End Select
                Next
            End If

        End With
    End Sub

    Private Sub Inicializar()
        fecFecha.Value = Date.Now.Date
        cboEstado.ReadOnly = True
        cboTrabajador.SelectedIndex = -1
        cboConcepto.SelectedIndex = -1
        cboTrabaPasar.SelectedIndex = -1
        txtGlosa.Text = String.Empty
        decSaldo.Value = 0
        numCuota.Value = 0
        decMonto.Value = 0
        verCancelado.Checked = False
        decSaldoAnterior.Visible = False
        etiSaldoAnterior.Visible = False
        decSaldoAnterior.Value = 0
        picTrabajador.Image = Nothing
        cboCuentaBancaria.Value = String.Empty
        txtDni.Text = String.Empty
        txtEstado.Text = String.Empty
        txtArea.Text = String.Empty
        txtOcupacion.Text = String.Empty
        fecIngreso.Value = Date.Now.Date
        ndRenumeracion.Value = 0
        ndDeuda.Value = 0
        ndTotalCuota.Value = 0
        ndTotalCuota.Appearance.BackColor = Color.Transparent
        _lePrestAux = New List(Of e_Prestamo)
        lePagoDescuento = New List(Of e_PagoDescuento)
        bandact = False
        '-----Refinanciar
        decMontoCom.Value = 0
        cboTrabaPasar.SelectedIndex = -1
        txtGlosaTransferir.Text = String.Empty
        numCuotaTrans.Value = 1
        '-----Anular
        fecAnular.Value = Date.Now.Date
        txtAnular.Text = String.Empty
        '---------------------------------
        ficComplemento.SelectedTab = ficComplemento.Tabs(0)
        agrTransferir.Visible = False
        agrPagar.Visible = False
        agrAnular.Visible = False
        lePrestamoDetalle = New List(Of e_PrestamoDetalle)
        CargarDetalle(lePrestamoDetalle)
        MostrarTabs(0, ficCuota)
    End Sub

    Private Sub Mostrar()
        Try
            If griPrestamo.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oePrestamo.Id = griPrestamo.ActiveRow.Cells("Id").Value.ToString
                oePrestamo = olPrestamo.Obtener(oePrestamo)
                With oePrestamo
                    fecFecha.Value = .Fecha
                    cboEstado.Value = .IdEstado
                    cboTrabajador.Value = .IdTrabajador
                    cboConcepto.Value = .IdConcepto
                    txtGlosa.Text = .Glosa
                    decMonto.Value = .Monto
                    decSaldo.Value = .Saldo
                    numCuota.Value = .CantidadCuotas
                    cboCuentaBancaria.Value = .IdCtaBancaria.Trim
                    verCancelado.Checked = IIf(.Cancelado = 1, True, False)
                    lePrestamoDetalle = .leDetalle
                    CargarDetalle(lePrestamoDetalle)
                    CargarHistorial(.leHistorial)
                End With
                SeleccionaTab(1)
                MyBase.Editar()
                BuscaFoto()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            If _opePrest <> "CANCELAR" Then
                _estado = gEstadosSGI.APROBADA.ToString
                If cboEstado.Text = _estado And oePrestamo.CantidadCuotas = 0 Then
                    oePrestamo.CantidadCuotas = lePrestamoDetalle.Where(Function(it) it.Activo = True).Count
                End If
            End If
            Select Case _opePrest
                Case "PENDIENTE"
                    RecolectarDatos()
                    oePrestamo.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olPrestamo.Guardar(oePrestamo) Then
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                        SeleccionaTab(0)
                        Consultar(_Activo)
                        griPrestamo.Focus()
                        Return True
                    End If
                Case "APROBAR"
                    RecolectarDatos()
                    oePrestamo.FechaAprueba = Date.Now.Date
                    oePrestamo.UsuarioAprueba = gUsuarioSGI.Id
                    '''''''''''''''validar monto total es igual a la suma monto cuotas'''''''''''''
                    Dim montoDetalle As Decimal = 0
                    For Each item In oePrestamo.leDetalle
                        montoDetalle = montoDetalle + item.Importe
                    Next
                    If montoDetalle <> oePrestamo.Monto Then Throw New Exception("La suma del importe de cuotas debe ser igual al monto total")
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    oePrestamo.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olPrestamo.Guardar(oePrestamo) Then
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                        SeleccionaTab(0)
                        Consultar(_Activo)
                        griPrestamo.Focus()
                        Return True
                    End If
                    Return True
                Case "ANULAR"
                    RecolectarDatos()
                    If txtAnular.Text.Trim = "" Then Throw New Exception("Ingrese Descripcion del por que se esta anulando el prestamo")
                    oePrestamo.Estado = cboEstado.Text
                    oePrestamo.FechaCancelado = fecAnular.Value
                    oePrestamo.GlosaCancelado = txtGlosa.Value
                    oePrestamo.Cancelado = 1
                    oePrestamo.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olPrestamo.Guardar(oePrestamo) Then
                        mensajeEmergente.Confirmacion("Se ha ANULADO Correctamente el Prestamo en " & Me.Text, True)
                        SeleccionaTab(0)
                        Consultar(_Activo)
                        griPrestamo.Focus()
                        Return True
                    End If
                Case "CONDONAR"
                    If ndCobrado.Value = 0 Then Throw New Exception("No se ha realizado ningun cobro de cuotas")
                    oeAsientoModel = New e_AsientoModelo
                    Dim _leCarPendAux = leCargoPend.Where(Function(it) it.TipoOperacion <> "").ToList
                    Dim _leCuoCarPendAux = leCuotaCargoPend.Where(Function(it) it.TipoOperacion <> "").ToList
                    If chkLiquidacion.Checked Then
                        For Each _oeCCPAux In _leCuoCarPendAux
                            oePrestamo = New e_Prestamo
                            oePrestamo.Equivale = 0
                            If _leCarPendAux.Contains(oePrestamo) Then
                                oePrestamo = _leCarPendAux.Item(_leCarPendAux.IndexOf(oePrestamo))
                                Select Case oePrestamo.IdConcepto
                                    Case IdPrestamo : _oeCCPAux.IndProv = "B"
                                    Case IdAdelanto : _oeCCPAux.IndProv = "C"
                                    Case Else : _oeCCPAux.IndProv = IIf(oePrestamo.Monto > _MontoDesc, "B", "C")
                                End Select
                            End If
                        Next
                    End If
                    If olPrestamo.CobrarCuota(_leCarPendAux, _leCuoCarPendAux, chkLiquidacion.Checked, oeAsientoModel) Then
                        mensajeEmergente.Confirmacion("Se ha cobrado Correctamente en " & Me.Text, True)
                        SeleccionaTab(0)
                        Consultar(_Activo)
                        griPrestamo.Focus()
                        Return True
                    End If
                Case "TRANSFERIR"
                    If cboTrabaPasar.SelectedIndex = -1 Then Throw New Exception("Seleccione Trabajador para Transferir Deuda")
                    If decMontoCom.Value = 0 Then Throw New Exception("Ingrese Monto de deuda a Transferir")
                    If txtGlosa.Text.Trim.Length = 0 Then Throw New Exception("Ingrese Glosa de Deduda a Transferir")
                    oePrestamo.Monto = ndMontoAct.Value : oePrestamo.Saldo = ndSaldoAct.Value : oePrestamo.TipoOperacion = "A"
                    oeCuotaAnu = New e_PrestamoDetalle
                    oeCuotaAnu.TipoOperacion = "I" : oeCuotaAnu.Activo = True : oeCuotaAnu.NroCuota = FormatoDocumento(oePrestamo.leHistorial.Count + 1, 3)
                    oeCuotaAnu.Importe = decMontoCom.Value : oeCuotaAnu.Fecha = fecTransferirDeuda.Value : oeCuotaAnu.FechaAnulado = fecTransferirDeuda.Value
                    oeCuotaAnu.Anulado = 1 : oeCuotaAnu.Mes = FormatoDocumento(fecTransferirDeuda.Value.Month, 2) : oeCuotaAnu.Anio = fecTransferirDeuda.Value.Year
                    oeCuotaAnu.UsuarioCreacion = gUsuarioSGI.Id : oeCuotaAnu.IdPrestamo = oePrestamo.Id : oeCuotaAnu.DobleMes = 0 : oeCuotaAnu.Cancelado = 1
                    oeCuotaAnu.Glosa = "TRANSFERIDO A TRABAJADOR: " & cboTrabaPasar.Text.Trim
                    oePrestamo.leHistorial.Add(oeCuotaAnu)
                    '''''''''''''''''''''''''''''''
                    Dim listaaux1 As New List(Of e_PrestamoDetalle)
                    Dim listaaux2 As New List(Of e_PrestamoDetalle)
                    For Each i In oePrestamo.leDetalle
                        If i.Cancelado = 1 Then listaaux1.Add(i)
                        If i.Cancelado = 0 And i.Id.Trim <> "" Then
                            i.TipoOperacion = "E"
                            i.Activo = False
                            listaaux2.Add(i)
                        End If
                    Next
                    If listaaux2.Count > 0 AndAlso oePrestamo.Saldo > 0 Then
                        listaaux1.AddRange(GenerarCuotas(oePrestamo.Saldo, "01/" & listaaux2(0).Mes & "/" & listaaux2(0).Anio, oePrestamo.CantidadCuotas - listaaux1.Count, listaaux1.Count))
                    End If
                    oePrestamo.leDetalle = listaaux1
                    oePrestamo.leHistorial.AddRange(listaaux2)
                    'Throw New Exception("hasta aqui todo bien")
                    '''''''''''''''''''''''''''''''
                    oePrestTrans = New e_Prestamo
                    oePrestTrans.TipoOperacion = "I" : oePrestTrans.IdTrabajador = cboTrabaPasar.Value : oePrestTrans.Fecha = fecTransferirDeuda.Value
                    oePrestTrans.UsuarioCreacion = gUsuarioSGI.Id : oePrestTrans.UsuarioAprueba = gUsuarioSGI.Id : oePrestTrans.Glosa = txtGlosaTransferir.Text.Trim
                    oePrestTrans.IdConcepto = oePrestamo.IdConcepto : oePrestTrans.Monto = decMontoCom.Value : oePrestTrans.Saldo = decMontoCom.Value
                    oePrestTrans.Cancelado = 0 : oePrestTrans.CantidadCuotas = numCuotaTrans.Value
                    oePrestTrans.leDetalle = GenerarCuotas(oePrestTrans.Monto, fecCuotaTransf.Value, oePrestTrans.CantidadCuotas)
                    Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoAprobada).ToList
                    If _leEstAux.Count > 0 Then oePrestTrans.IdEstado = _leEstAux(0).Id
                    If olPrestamo.TransferirDeuda(oePrestamo, oePrestTrans) Then
                        mensajeEmergente.Confirmacion("Se ha Transferirdo la Deuda Correctamente en " & Me.Text, True)
                        SeleccionaTab(0)
                        Consultar(_Activo)
                        griPrestamo.Focus()
                        Return True
                    End If
                Case "CANCELAR"
                    If ndCobrado.Value = 0 Then Throw New Exception("No se ha realizado ningun cobro de cuotas")
                    If cboTipoPago.SelectedIndex = 1 Then
                        oeAsientoModel = New e_AsientoModelo
                        Dim _leCarPendAux = leCargoPend.Where(Function(it) it.TipoOperacion <> "").ToList
                        Dim _leCuoCarPendAux = leCuotaCargoPend.Where(Function(it) it.TipoOperacion <> "").ToList
                        If olPrestamo.CobrarCuota(_leCarPendAux, _leCuoCarPendAux, chkLiquidacion.Checked, oeAsientoModel) Then
                            mensajeEmergente.Confirmacion("Se ha cobrado Correctamente en " & Me.Text, True)
                            SeleccionaTab(0)
                            Consultar(_Activo)
                            griPrestamo.Focus()
                            Return True
                        End If
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub CargarDetalle(ByVal leDetalle As List(Of e_PrestamoDetalle))
        With griDetalle
            Dim leActivo As New List(Of e_PrestamoDetalle)
            leActivo = leDetalle.Where(Function(item) item.Activo = True).ToList
            For Each oeDetAux In leActivo
                oeDetAux.NroCuota = FormatoDocumento(oeDetAux.NroCuota.Trim, 3)
                If oeDetAux.Id.Trim <> "" AndAlso oeDetAux.Cancelado = 0 Then oeDetAux.TipoOperacion = "A"
            Next
            .DataSource = leActivo.OrderBy(Function(it) it.NroCuota).ToList
            If BandCargar Then DiseniaGrilla(griDetalle, 1)
            For Each Fila As UltraGridRow In .Rows
                If Fila.Cells("Fecha").Value = "01/01/1901" Then Fila.Cells("Fecha").Appearance.ForeColor = Color.White
            Next
            CalcularTotales(griDetalle, "Importe")
            Dim ln_XD = leActivo.Sum(Function(it) it.Importe)
            If Math.Round(ln_XD, 2) > Math.Round(decMonto.Value, 2) Then
                MessageBox.Show("El total de importe de cuotas (" & leActivo.Sum(Function(it) it.Importe) & _
                                ") supera al Monto Prestamo (" & decMonto.Value & ")" & Environment.NewLine & _
                                "Se recomienda actualizar las cuotas asignadas", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End If
        End With
    End Sub

    Private Sub InicializaDetalle()
        Dim _anio As Integer = Date.Now.Year, _mes As Integer = Date.Now.Month.ToString
        txtNroCuota.Text = FormatoDocumento(griDetalle.Rows.Count + 1, 3)
        txtNroCuota.ReadOnly = True
        Dim _lePDAux = lePrestamoDetalle.Where(Function(it) it.Activo = True).ToList
        If _lePDAux.Count > 0 Then
            Dim _xanio = _lePDAux.Max(Function(it) CInt(it.Anio))
            Dim _xmes = _lePDAux.Where(Function(it) CInt(it.Anio) = _xanio).Max(Function(it) CInt(it.Mes))
            If _xmes = 12 Then _xmes = 0 : _xanio = _xanio + 1
            _xmes = _xmes + 1
            If _xanio < _anio Then
                _xanio = _anio
                _xmes = _mes
            Else
                If _xanio = _anio AndAlso _xmes < _mes Then _xmes = _mes
            End If
            fecPerido.Value = Convert.ToDateTime("01/" & _xmes.ToString & "/" & _xanio.ToString)
        Else
            fecPerido.Value = Convert.ToDateTime("01/" & _mes.ToString & "/" & _anio.ToString)
        End If
        decImporte.Value = 0
        decImporte.ReadOnly = False
        chkDobleMes.Checked = False
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Trabajador") Then cboTrabajador.Focus()
        If excepcion.Contains("Concepto") Then cboConcepto.Focus()
        If excepcion.Contains("Glosa") Then txtGlosa.Focus()
        If excepcion.Contains("Monto") Then decMonto.Focus()
        If excepcion.Contains("Cantidad de Cuotas") Then numCuota.Focus()
        If excepcion.Contains("Año/Mes") Then fecPerido.Focus()
        If excepcion.Contains("Importe de la Cuota") Then decImporte.Focus()
    End Sub

    Private Sub BuscaFoto()
        Try
            'oeTrab (Id, NombreCompleto, Dni) {e_Trabajador}
            Dim oeTrab = cboTrabajador.Items(cboTrabajador.SelectedIndex).ListObject
            'If Not String.IsNullOrEmpty(oeTrab.Dni) Then picTrabajador.Image = olPersona.Foto(oeTrab.Dni)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_ObtineNroCuota() As Integer
        Dim leDetAct As New List(Of e_PrestamoDetalle)
        Dim Nro As Integer = 0
        leDetAct = lePrestamoDetalle.Where(Function(item) item.Activo = True).ToList
        If leDetAct.Count > 0 Then
            Dim oe As New e_PrestamoDetalle
            oe = leDetAct.OrderByDescending(Function(item) item.NroCuota)(0)
            If oe.NroCuota <> "" Then Nro = oe.NroCuota + 1
        Else
            Nro = 1
        End If
        Return Nro
    End Function

    Private Function ValidarMonto() As Boolean
        Dim leSum As New List(Of e_PrestamoDetalle)
        Dim dpsum As Double
        Dim retorna As Boolean = True
        leSum = lePrestamoDetalle.Where(Function(item) item.Activo = True).ToList
        dpsum = leSum.Sum(Function(item) item.Importe)
        If dpsum + oePrestamoDetalle.Importe > decMonto.Value Then
            Throw New Exception("La Importe de la Cuota no debe ser mayor que : S/ " & Math.Round(decMonto.Value - dpsum, 2))
        End If
        Return retorna
    End Function

    Private Sub CargarHistorial(ByVal leHist As List(Of e_PrestamoDetalle))
        With griHistorial
            .DataSource = leHist
            DiseniaGrilla(griHistorial, 2)
            CalcularTotales(griHistorial, "Importe")
        End With
    End Sub

    Private Sub DiseniaGrilla(ByVal Grilla As UltraGrid, ByVal Tipo As Integer)

        With Grilla

            OcultarColumna(Grilla, True, "Id", "IdPrestamo", "Activo", "FechaCreacion", "UsuarioCreacion")

            If Tipo = 1 Then OcultarColumna(Grilla, True, "Anulado", "FechaAnulado")

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

            FormatoColumna(Grilla, "", ColumnStyle.CheckBox, HAlign.Default, "Cancelado", "Anulado", "DobleMes")

            .DisplayLayout.Bands(0).Columns("Anio").Width = 50
            .DisplayLayout.Bands(0).Columns("Mes").Width = 40
            .DisplayLayout.Bands(0).Columns("Importe").Width = 100
            .DisplayLayout.Bands(0).Columns("Cancelado").Width = 60
            .DisplayLayout.Bands(0).Columns("Fecha").Width = 100
            .DisplayLayout.Bands(0).Columns("Glosa").Width = 300

            FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Importe")

            .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
            .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
            .DisplayLayout.Override.FilterUIProvider = Filtro1
            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
            .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            .DisplayLayout.MaxColScrollRegions = 1
            .DisplayLayout.MaxRowScrollRegions = 1

        End With

    End Sub

    Private Function ObtieneValorParametro(ls_Nombre_Parametro As String) As Double
        Try
            oeParametro = New e_AporteDescuento
            oeParametro.Abreviatura = ls_Nombre_Parametro
            oeParametro.Equivale = 4
            If leParametro.Contains(oeParametro) Then
                oeParametro = leParametro.Item(leParametro.IndexOf(oeParametro))
                oeDetParametro = New e_DetalleAporteDescuento
                oeDetParametro.IdAporteDescuento = oeParametro.Id
                oeDetParametro.Equivale = 2
                If leDetParametro.Contains(oeDetParametro) Then
                    oeDetParametro = leDetParametro.Item(leDetParametro.IndexOf(oeDetParametro))
                End If
            End If
            Return oeDetParametro.MontoCalculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Aprobar()
        Try
            _acl = gAccionSistema.APROBAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoPendiente
                If griPrestamo.ActiveRow.Cells("Estado").Value = _estado Then
                    Editar()
                    _estado = gEstadosSGI.APROBADA.ToString
                    cboEstado.Text = _estado
                    _opePrest = "APROBAR"
                Else
                    Throw New Exception("No puede APROBAR el Prestamo Del Trabajador :" & Environment.NewLine & _
                                        griPrestamo.ActiveRow.Cells("Trabajador").Value & " por que su solicitud no esta PENDIENTE.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Anular()
        Try
            _acl = gAccionSistema.ANULAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gEstadosSGI.APROBADA.ToString
                If griPrestamo.ActiveRow.Cells("Estado").Value = _estado Then
                    If griPrestamo.ActiveRow.Cells("Saldo").Value <> griPrestamo.ActiveRow.Cells("Monto").Value Then
                        Throw New Exception("No puede ANULAR el Prestamo Del Trabajador :" & Environment.NewLine & _
                                  griPrestamo.ActiveRow.Cells("Trabajador").Value & " por que ya a cancelado mas de una cuota")
                    End If
                    Editar()
                    _estado = gNombreEstadoAnulado.ToString
                    cboEstado.Text = _estado
                    _opePrest = "ANULAR"
                    agrAnular.Visible = True
                    agrAnular.Expanded = True
                    txtAnular.Focus()
                Else
                    Throw New Exception("No puede ANULAR el Prestamo Del Trabajador :" & Environment.NewLine & _
                                        griPrestamo.ActiveRow.Cells("Trabajador").Value & " por que su solicitud no esta APROBADA")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Condonar()
        Try
            _acl = gAccionSistema.CONDONAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                SeleccionaTab(2)
                _opePrest = "CONDONAR"
                InicializarCobro()
                cboTipoPago.Items.Clear()
                cboTipoPago.Items.Add("DEPOSITO A CUENTA")
                cboTipoPago.Items.Add("RETENCION DE LIQUIDACION")
                cboTipoPago.Items.Add("CONDONAR DEUDA")
                cboTipoPago.SelectedIndex = 2 : cboTipoPago.ReadOnly = True
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Refinanciar()
        Try
            _acl = gAccionSistema.REFINANCIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gEstadosSGI.APROBADA.ToString
                If griPrestamo.ActiveRow.Cells("Estado").Value = _estado Then
                    Editar()
                    ' _estado = gEstadosSGI.APROBADA.ToString
                    cboEstado.Text = _estado
                    _opePrest = "REFINANCIAR"
                Else
                    Throw New Exception("No puede REFINANCIAR el Prestamo Del Trabajador :" & Environment.NewLine & _
                                        griPrestamo.ActiveRow.Cells("Trabajador").Value & " por que su solicitud no esta APROBADO.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Transferir()
        Try
            _acl = gAccionSistema.TRANSFERIR.ToString()
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gEstadosSGI.APROBADA.ToString
                If griPrestamo.ActiveRow.Cells("Estado").Value = _estado Then
                    If griPrestamo.ActiveRow.Cells("Saldo").Value = 0 Then Throw New Exception("Para Transferir la Deuda debe tener un saldo mayor a cero.")
                    Editar()
                    cboEstado.Text = _estado
                    _opePrest = "TRANSFERIR"
                    agrTransferir.Visible = True
                    agrTransferir.Expanded = True
                    cboTrabaPasar.Focus()
                    ndMontoAct.Value = decMonto.Value
                    ndSaldoAct.Value = CalculaSaldo()
                Else
                    Throw New Exception("No puede TRANSFERIR el Prestamo Del Trabajador :" & Environment.NewLine & _
                                        griPrestamo.ActiveRow.Cells("Trabajador").Value & " por que su solicitud no esta APROBADO.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub RecoletaDetalle()
        oePrestamoDetalle.NroCuota = txtNroCuota.Text.Trim
        oePrestamoDetalle.Anio = fecPerido.Value.Year.ToString
        oePrestamoDetalle.Mes = FormatoDocumento(fecPerido.Value.Month.ToString, 2)
        oePrestamoDetalle.DobleMes = IIf(chkDobleMes.Checked, 1, 0)
        oePrestamoDetalle.Importe = decImporte.Value
    End Sub

    Private Sub MostrarDetalle()
        Try
            If griDetalle.Selected.Rows.Count > 0 Then
                If griDetalle.ActiveRow.Cells("Cancelado").Value <> 1 Then
                    oePrestamoDetalle = New e_PrestamoDetalle
                    If griDetalle.ActiveRow.Cells("Id").Value.ToString.Trim <> "" Then
                        oePrestamoDetalle.Equivale = 1
                        oePrestamoDetalle.Id = griDetalle.ActiveRow.Cells("Id").Value
                    Else
                        oePrestamoDetalle.Equivale = 0
                        oePrestamoDetalle.NroCuota = griDetalle.ActiveRow.Cells("NroCuota").Value
                    End If
                    If lePrestamoDetalle.Contains(oePrestamoDetalle) Then
                        oePrestamoDetalle = lePrestamoDetalle.Item(lePrestamoDetalle.IndexOf(oePrestamoDetalle))
                        txtNroCuota.Text = oePrestamoDetalle.NroCuota
                        fecPerido.Value = "01/" & oePrestamoDetalle.Mes.Trim.ToString & "/" & oePrestamoDetalle.Anio.Trim.ToString
                        decImporte.Value = oePrestamoDetalle.Importe
                        chkDobleMes.Checked = oePrestamoDetalle.DobleMes
                    End If
                Else
                    Throw New Exception("No se Puede Editar una Cuota Cobrada")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarDetalle()
        Try
            _estado = gEstadosSGI.APROBADA.ToString
            If cboEstado.Text = _estado Then
                InicializaDetalle()
                MostrarDetalle()
                txtNroCuota.ReadOnly = True
                MostrarTabs(1, ficCuota)
                bandact = True
            Else
                Throw New Exception("Usted no puede editar esta cuota. " & Environment.NewLine & _
                                        "Para poder efectuar esta Operacion el prestamo debe estar APROBADA")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub RecolectarDatos()
        oePrestamo.Fecha = fecFecha.Value
        oePrestamo.leDetalle = lePrestamoDetalle
        oePrestamo.IdCtaBancaria = cboCuentaBancaria.Value
        If oePrestamo.TipoOperacion = "I" Then
            oePrestamo.UsuarioCreacion = gUsuarioSGI.Id
            ValidarCombo(cboCuentaBancaria, "Cuenta Bancaria")
        End If
        oePrestamo.CtaBancaria = cboCuentaBancaria.Items(cboCuentaBancaria.SelectedIndex).ListObject
        Dim oeTrabajador As New e_Trabajador
        Dim olPeriodo As New l_Periodo
        Dim oePeriodo As New e_Periodo
        oePeriodo.Ejercicio = fecFecha.Value.Year
        oePeriodo.Mes = fecFecha.Value.Month
        oePeriodo = olPeriodo.Obtener(oePeriodo)
        If oePrestamo.TipoOperacion = "I" Then l_FuncionesGenerales.ValidarPeriodo(oePeriodo.Id, gAreasSGI.Tesoreria)
        oePrestamo.oePeriodo = oePeriodo
        Dim _oeTrab = cboTrabajador.Items(cboTrabajador.SelectedIndex).ListObject
        oePrestamo.Trabajador = _oeTrab.NombreCompleto
        oePrestamo.Dni = _oeTrab.Dni
        oePrestamo.Concepto = cboConcepto.Text
        oePrestamo.IdEstado = cboEstado.Value
        oePrestamo.Estado = cboEstado.Text
    End Sub

    Private Sub Cobrar()
        Try
            _acl = gAccionSistema.CANCELAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                SeleccionaTab(2)
                _opePrest = "CANCELAR"
                InicializarCobro()
                cboTipoPago.Items.Clear()
                cboTipoPago.Items.Add("DEPOSITO A CUENTA")
                cboTipoPago.Items.Add("RETENCION DE LIQUIDACION")
                cboTipoPago.SelectedIndex = 1 : cboTipoPago.ReadOnly = True
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarCargosPend(leCPend As List(Of e_Prestamo))
        Try
            With griPrestamoPend
                .ResetDisplayLayout()
                Dim _leAux = leCPend.OrderBy(Function(it) it.Fecha).ToList
                .DataSource = _leAux
                OcultarColumna(griPrestamoPend, True, "Id", "IdTrabajador", "Trabajador", "Activo", "Cancelado", "FechaCreacion", _
                               "UsuarioCreacion", "IdConcepto", "IdEstado", "Estado", "UsuarioAprueba", "FechaAprueba", "GlosaCancelado", _
                               "FechaCancelado", "FechaIntegracion", "IdCtaBancaria")
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Concepto").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Saldo").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("CantidadCuotas").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("CantidadCuotas").Header.Caption = "Cuotas"
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 65
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 250
                FormatoColumna(griPrestamoPend, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto", "Saldo")
                FormatoColumna(griPrestamoPend, "", ColumnStyle.Integer, HAlign.Center, "CantidadCuotas")
                .Font = New System.Drawing.Font("Tahoma", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
            CalcularTotales(griPrestamoPend, "Saldo")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCuotaCargoPend(leCCPend As List(Of e_PrestamoDetalle))
        Try
            With griCuotaCargoPend
                .ResetDisplayLayout()
                Dim _leAux = leCCPend.OrderBy(Function(it) it.NroCuota).ToList
                .DataSource = _leAux
                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key = "Cancelado" Then
                        col.CellClickAction = CellClickAction.Edit : col.CellActivation = Activation.AllowEdit
                    Else
                        col.CellClickAction = CellClickAction.RowSelect : col.CellActivation = Activation.NoEdit
                    End If
                Next
                OcultarColumna(griCuotaCargoPend, True, "Id", "IdPrestamo", "FechaCreacion", "FechaAnulado", "Activo", "Anulado", "UsuarioCreacion")
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
                FormatoColumna(griCuotaCargoPend, "", ColumnStyle.CheckBox, HAlign.Default, "Cancelado", "DobleMes")
                .DisplayLayout.Bands(0).Columns("Anio").Width = 50
                .DisplayLayout.Bands(0).Columns("Mes").Width = 40
                .DisplayLayout.Bands(0).Columns("Importe").Width = 100
                .DisplayLayout.Bands(0).Columns("Cancelado").Width = 60
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 100
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 300
                FormatoColumna(griCuotaCargoPend, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Importe")
                .Font = New System.Drawing.Font("Tahoma", 7.5!)
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

    Private Sub SeleccionaTab(_index As Integer)
        ficPrestamo.Tabs(0).Enabled = False
        ficPrestamo.Tabs(1).Enabled = False
        ficPrestamo.Tabs(2).Enabled = False
        ficPrestamo.Tabs(_index).Enabled = True
        ficPrestamo.Tabs(_index).Selected = True
    End Sub

    Private Sub CalcularCambioMoneda()
        If cboTipoMoneda.Text = "SOLES" Then
            ndSoles.Value = decMontoDep.Value
            ndDolares.Value = Math.Round(decMontoDep.Value / ndTipoCambio.Value, 2)
        Else
            ndSoles.Value = Math.Round(decMontoDep.Value * ndTipoCambio.Value, 2)
            ndDolares.Value = decMontoDep.Value
        End If
    End Sub

    Private Sub GeneraGlosa()
        Select Case cboTipoPago.SelectedIndex
            Case 0
                'txtDescripconDep.Text = cboTipoPago.Text & ", Periodo: " & FormatoDocumento(fecDeposito.Value.Month, 2) & "/" & _
                'FormatoDocumento(fecDeposito.Value.Year, 4) & ", Monto: " & decMontoDep.Value & " " & cboTipoMoneda.Text & _
                '" EN " & _empr & " OP:" & txtNroOperacion.Text
            Case 1
                txtDescripconDep.Text = cboTipoPago.Text & ", Periodo: " & FormatoDocumento(fecDeposito.Value.Month, 2) & "/" & _
                FormatoDocumento(fecDeposito.Value.Year, 4) & ", Monto: " & decMontoDep.Value & " " & cboTipoMoneda.Text
            Case 2
                txtDescripconDep.Text = cboTipoPago.Text & ", Periodo: " & FormatoDocumento(fecDeposito.Value.Month, 2) & "/" & _
               FormatoDocumento(fecDeposito.Value.Year, 4) & ", Monto: " & decMontoDep.Value & " " & cboTipoMoneda.Text
        End Select
    End Sub

    Private Sub InicializarCobro()
        Dim _leTrabAct = From le In leTrabajador _
                               Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado
                               Where Activo = True
                               Order By NombreCompleto
        LlenarCombo(cboTrabajadorDep, "NombreCompleto", _leTrabAct.ToList, -1)
        oePrestamo = New e_Prestamo : oePrestamoDetalle = New e_PrestamoDetalle
        cboTrabajadorDep.SelectedIndex = -1
        cboTipoMoneda.SelectedIndex = -1
        fecDeposito.Value = Date.Now.Date
        'cboCtaBancariaDep.SelectedIndex = -1
        decMontoDep.Value = 0
        ' txtNroOperacion.Text = String.Empty
        txtDescripconDep.Text = String.Empty
        leCargoPend = New List(Of e_Prestamo) : CargarCargosPend(leCargoPend)
        leCuotaCargoPend = New List(Of e_PrestamoDetalle) : CargarCuotaCargoPend(leCuotaCargoPend)
        leCPUltCP = New List(Of e_Prestamo)
        '--Cargo Pendiente -------
        ndDeudaCargo.Value = 0 : ndDeudaCargoAct.Value = 0 : ndCobrado.Value = 0
        '--Datos Prestamo Sel ---
        fecCCP.Value = Date.Now.Date : txtConceptoCCP.Text = String.Empty : decSaldoCCP.Value = 0
        agrCuotaCP.Visible = False : btnAgregarCCP.Enabled = False : btnQuitarCCP.Enabled = False
        '--Nva Cuota ----
        fecPeriodoCuota.Value = Convert.ToDateTime("01/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString)
        decImporteCuota.Value = 0 : _saldocob = 0 : _pereje = String.Empty : _empr = String.Empty
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
    End Sub

    Private Sub CargarDscto(ByVal IndTipo As Integer)
        Try
            If cboTrabajadorDep.SelectedIndex > -1 AndAlso ndCobrado.Value = 0 Then
                'Cargar los descuentos aprobados
                oePrestamo = New e_Prestamo
                oePrestamo.TipoOperacion = "" : oePrestamo.IdTrabajador = cboTrabajadorDep.Value
                _estado = gEstadosSGI.APROBADA.ToString
                Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                If _leEstAux.Count > 0 Then oePrestamo.IdEstado = _leEstAux(0).Id
                If IndTipo = 1 Then
                    leCargoPend = olPrestamo.Listar(oePrestamo)
                Else
                    leCargoPend = olPrestamo.Listar(oePrestamo).Where(Function(it) it.Id = _idDscto).ToList
                End If
                CargarCargosPend(leCargoPend)
                If leCargoPend.Count > 0 Then
                    'Cargar Ultima cuota de cada descuento
                    oePrestamo = New e_Prestamo
                    oePrestamo.TipoOperacion = "T" : oePrestamo.IdTrabajador = cboTrabajadorDep.Value
                    If IndTipo = 1 Then
                        leCPUltCP = olPrestamo.Listar(oePrestamo)
                    Else
                        leCPUltCP = olPrestamo.Listar(oePrestamo).Where(Function(it) it.Id = _idDscto).ToList
                    End If
                    ndDeudaCargo.Value = leCargoPend.Sum(Function(it) it.Saldo)
                    'Cargar las cuotas de cada descuento
                    oePrestamoDetalle = New e_PrestamoDetalle
                    oePrestamoDetalle.TipoOperacion = "T"
                    oePrestamoDetalle.IdPrestamo = cboTrabajadorDep.Value
                    If IndTipo = 1 Then
                        leCuotaCargoPend = olPrestamoDetalle.Listar(oePrestamoDetalle)
                    Else
                        leCuotaCargoPend = olPrestamoDetalle.Listar(oePrestamoDetalle).Where(Function(it) it.IdPrestamo = _idDscto).ToList
                    End If
                Else
                    leCuotaCargoPend = New List(Of e_PrestamoDetalle)
                End If
                CargarCuotaCargoPend(New List(Of e_PrestamoDetalle))
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function CalculaSaldo() As Double
        Dim _montocancelado As Double = 0, _saldoactual As Double = 0
        Dim _leAux = lePrestamoDetalle.Where(Function(it) it.Cancelado = 1).ToList
        _montocancelado = _leAux.Sum(Function(it) it.Importe)
        _saldoactual = Math.Round(decMonto.Value - _montocancelado, 2)
        Return _saldoactual
    End Function

#End Region

#Region "Menu Contextual"

    Private Sub mnuDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuDetalle.Opening
        mnuDetalle.Items("tsmiAgregar").Enabled = True
        mnuDetalle.Items("tsmiEditar").Enabled = IIf(griDetalle.Selected.Rows.Count > 0, True, False)
        mnuDetalle.Items("tsmiQuitar").Enabled = IIf(griDetalle.Selected.Rows.Count > 0, True, False)
        mnuDetalle.Items("tsmiGenerarCuotas").Enabled = IIf(griDetalle.Rows.Count > 0, False, True)
    End Sub

    Private Sub tsmiAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregar.Click
        Try
            If decMonto.Value > 0 Then
                _estado = gEstadosSGI.APROBADA.ToString
                If cboEstado.Text = _estado Then
                    Dim _lePDAux = lePrestamoDetalle.Where(Function(it) it.Activo = True).ToList
                    If oePrestamo.TipoOperacion = "A" AndAlso _lePDAux.Count > 0 Then
                        Dim _nro As Integer = 0
                        For Each oeAux In _lePDAux.OrderBy(Function(it) it.NroCuota).ToList
                            _nro = _nro + 1
                            oeAux.NroCuota = FormatoDocumento(_nro, 3)
                            oeAux.TipoOperacion = IIf(oeAux.Id.Trim <> "", "A", "I")
                        Next
                    End If
                    InicializaDetalle()
                    oePrestamoDetalle = New e_PrestamoDetalle
                    oePrestamoDetalle.TipoOperacion = "I"
                    oePrestamoDetalle.Activo = True
                    MostrarTabs(1, ficCuota)
                    decImporte.Focus()
                Else
                    Throw New Exception("Usted no puede agregar otra cuota. " & Environment.NewLine & _
                                        "Para poder efectuar esta Operacion el prestamo debe estar APROBADA")
                End If
            Else
                mensajeEmergente.Problema("Ingrese Monto", True)
                decMonto.Focus()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar.Click
        EditarDetalle()
    End Sub

    Private Sub tsmiQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitar.Click
        Try
            If griDetalle.Selected.Rows.Count > 0 Then
                _estado = gEstadosSGI.APROBADA.ToString
                If cboEstado.Text = _estado Then
                    If MessageBox.Show("¿Desea Eliminar la Cuota Nº " & griDetalle.ActiveRow.Cells("NroCuota").Value & "?", "Mensaje de Sistema", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                        oePrestamoDetalle = New e_PrestamoDetalle
                        If griDetalle.ActiveRow.Cells("Id").Value.ToString.Trim <> "" Then
                            oePrestamoDetalle.Equivale = 1
                            oePrestamoDetalle.Id = griDetalle.ActiveRow.Cells("Id").Value.ToString.Trim
                        Else
                            oePrestamoDetalle.Equivale = 0
                            oePrestamoDetalle.NroCuota = griDetalle.ActiveRow.Cells("NroCuota").Value.ToString.Trim
                        End If
                        If lePrestamoDetalle.Contains(oePrestamoDetalle) Then
                            oePrestamoDetalle = lePrestamoDetalle.Item(lePrestamoDetalle.IndexOf(oePrestamoDetalle))
                            If oePrestamoDetalle.Cancelado <> 1 Then
                                If oePrestamoDetalle.Id.Trim <> "" Then
                                    oePrestamoDetalle.TipoOperacion = "E"
                                    oePrestamoDetalle.Activo = False
                                Else
                                    lePrestamoDetalle.Remove(oePrestamoDetalle)
                                End If
                                CargarDetalle(lePrestamoDetalle)
                            Else
                                Throw New Exception("No se Puede Eliminar una Cuota Cobrada")
                            End If
                        End If
                    End If
                Else
                    Throw New Exception("Usted no puede quitar esta cuota. " & Environment.NewLine & _
                                        "Para poder efectuar esta Operacion el prestamo debe estar APROBADA")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiGenerarCuotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGenerarCuotas.Click
        Try
            _estado = gEstadosSGI.APROBADA.ToString
            If cboEstado.Text = _estado Then
                If numCuota.Value = 0 Then Throw New Exception("Ingrese Cantidad de Cuotas para Generar")
                BandGenera = True
                InicializaDetalle()
                decImporte.ReadOnly = True
                MostrarTabs(1, ficCuota)
            Else
                Throw New Exception("Usted no puede autogenerar cuota. " & Environment.NewLine & _
                                       "Para poder efectuar esta Operacion el prestamo debe estar APROBADA")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Sub

    Private Sub mcPrestamo_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcPrestamo.Opening
        mcPrestamo.Items("tsmiNuevo").Enabled = True
        mcPrestamo.Items("tsmiEdita").Enabled = IIf(griPrestamo.Selected.Rows.Count > 0, True, False)
        mcPrestamo.Items("tsmiEliminar").Enabled = IIf(griPrestamo.Selected.Rows.Count > 0, True, False)
        mcPrestamo.Items("tsmiAprobar").Enabled = IIf(griPrestamo.Selected.Rows.Count > 0, True, False)
        mcPrestamo.Items("tsmiAnular").Enabled = IIf(griPrestamo.Selected.Rows.Count > 0, True, False)
        mcPrestamo.Items("tsmiCondonar").Enabled = True
        mcPrestamo.Items("tsmiRefinanciar").Enabled = IIf(griPrestamo.Selected.Rows.Count > 0, True, False)
        mcPrestamo.Items("tsmiTransferir").Enabled = IIf(griPrestamo.Selected.Rows.Count > 0, True, False)
        mcPrestamo.Items("tsmiExportar").Enabled = IIf(griPrestamo.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEdita_Click(sender As Object, e As EventArgs) Handles tsmiEdita.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        Exportar()
    End Sub

    Private Sub tsmiAprobar_Click(sender As Object, e As EventArgs) Handles tsmiAprobar.Click
        Aprobar()
    End Sub

    Private Sub tsmiAnular_Click(sender As Object, e As EventArgs) Handles tsmiAnular.Click
        Anular()
    End Sub

    Private Sub tsmiCondonar_Click(sender As Object, e As EventArgs) Handles tsmiCondonar.Click
        If griPrestamo.Selected.Rows.Count = 0 Then
            mensajeEmergente.Problema("Seleccione un Prestamo", True)
        Else
            _idDscto = String.Empty
            _idDscto = griPrestamo.ActiveRow.Cells("Id").Value
            If griPrestamo.ActiveRow.Cells("Estado").Value <> gEstadosSGI.APROBADA.ToString Then
                mensajeEmergente.Problema("El Descuento debe estar en estado " & gEstadosSGI.APROBADA.ToString, True)
            Else
                If griPrestamo.ActiveRow.Cells("Monto").Value = griPrestamo.ActiveRow.Cells("Saldo").Value Then
                    mensajeEmergente.Problema("El Descuento debe ser Anulado", True)
                Else
                    chkLiquidacion.Visible = True : chkLiquidacion.Checked = False
                    Condonar() : cboTrabajadorDep.Value = griPrestamo.ActiveRow.Cells("IdTrabajador").Value
                    cboTrabajadorDep.ReadOnly = True : CargarDscto(2)
                End If
            End If
        End If
    End Sub

    Private Sub tsmiRefinanciar_Click(sender As Object, e As EventArgs) Handles tsmiRefinanciar.Click
        Refinanciar()
    End Sub

    Private Sub tsmiTransferir_Click(sender As Object, e As EventArgs) Handles tsmiTransferir.Click
        Transferir()
    End Sub

#End Region

End Class
