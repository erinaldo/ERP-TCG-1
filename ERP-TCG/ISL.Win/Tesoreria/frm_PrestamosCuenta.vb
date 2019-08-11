Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win

Public Class frm_PrestamosCuenta
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_PrestamosCuenta = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_PrestamosCuenta()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oePrestamosCuenta As New e_PrestamosCuenta
    Private olPrestamosCuenta As New l_PrestamosCuenta
    Private oeConceptoIngresos As New e_ConceptoIngresos
    Private olConceptoIngresos As New l_ConceptoIngresos
    Private oeCtaBancaria As New e_CuentaBancaria
    Dim idMovimiento, idCuentaTrabajador, idTrabajador As String

    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro

    Dim Prefijo As New l_Configuracion
    Private Estado As String

    Private idCajaCentro As String = ""

    Dim _ingresando_datos As Boolean = False
    Dim Opcion As Boolean
    Dim EjercicioAyuda As Integer

    Private oeAsientoModelo, oeAsientoModeloPrestamo As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)

    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)
    Private dtReferencia As New DataTable

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, ficPrestamosCuenta, 1)
            oePrestamosCuenta.Modificado = False
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar(Activo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If ValidaUsuarioCajaCentro(idCajaCentro, ObtenerCentro.Id, gUsuarioSGI.IdTrabajador) Then
                Select Case ficPrestamosCuenta.SelectedTab.Index
                    Case 1
                        If GuardarIngreso() Then
                            Inicializar()
                            ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
                            MostrarTabs(0, ficPrestamosCuenta, 0)
                        Else
                            MostrarTabs(1, ficPrestamosCuenta, 1)
                        End If
                End Select
            Else
                Throw New Exception("No puede Realizar Movimientos en esta Sede")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oePrestamosCuenta.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarIngreso() Then
                            MostrarTabs(0, ficPrestamosCuenta, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficPrestamosCuenta, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficPrestamosCuenta, 2)
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficPrestamosCuenta)
                _ingresando_datos = False
                Listar(True)
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            Dim id As String
            If griPrestamosCuenta.Rows.Count > 0 Then
                id = griPrestamosCuenta.ActiveRow.Cells("Id").Value
                Dim formulario As New frm_ReporteVoucherMovimientoCaja
                formulario.CargarDatos("9", id)
                formulario.ShowDialog()
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficPrestamosCuenta.Tabs(0).Selected AndAlso griPrestamosCuenta.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficPrestamosCuenta.Tabs(0).Selected Then Exportar_Excel(griPrestamosCuenta)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If idCajaCentro = "" Then
                Throw New Exception("No Puede Eliminar Prestamos. No esta Asignado a la Caja.")
            End If
            'Select Case MessageBox.Show("Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            '    Case Windows.Forms.DialogResult.Yes
            '        EliminarPrestamo()
            'End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Function ValidaCampos(ByVal oePeriodo As e_Periodo) As Boolean
        Try
            If cboConcepto.Value <> "1SI000000019" Then ValidarCombo(cboCuentaBancaria, "Cuenta Bancaria")
            If Me.txtGlosa.Text.Trim Is String.Empty Then
                Throw New Exception("Llene la Glosa por Favor")
            ElseIf Me.txtImporte.Value = 0 Then
                Throw New Exception("El Importe tiene que ser Mayor a 0")
            ElseIf Me.cboConcepto.SelectedIndex = -1 Then
                Throw New Exception("Seleccione Concepto por Favor")
            ElseIf Me.cboTrabajadores.SelectedIndex = -1 Then
                Throw New Exception("Seleccione Autorizador por Favor")
            End If
            l_FuncionesGenerales.ValidarPeriodo(oePeriodo.Id, gAreasSGI.Tesoreria)
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function GuardarIngreso() As Boolean
        Dim TipoOperacion = 0
        Try
            Dim olPeriodo As New l_Periodo
            Dim oePeriodo As New e_Periodo
            oePeriodo.Ejercicio = Date.Parse(Fecha1.Value).Year
            oePeriodo.Mes = Date.Parse(Fecha1.Value).Month
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If ValidaCampos(oePeriodo) Then
                oePrestamosCuenta.TipoOperacion = "I"
                oePrestamosCuenta.Fecha = Me.Fecha1.Value
                oePrestamosCuenta.FechaCreacion = Date.Now
                oePrestamosCuenta.Importe = Me.txtImporte.Value
                oePrestamosCuenta.Glosa = Me.txtGlosa.Text
                oePrestamosCuenta.NroDocumento = FormatoDocumento(Me.txtVoucher.Text, 8)
                oePrestamosCuenta.UsuarioCreacion = gUsuarioSGI.Id
                oePrestamosCuenta.oePeriodo = oePeriodo
                oePrestamosCuenta.oeCtaBancaria = cboCuentaBancaria.Items(cboCuentaBancaria.SelectedIndex).ListObject
                oePrestamosCuenta.TipoCambio = DecTC.Value
                oePrestamosCuenta.IndIngEgr = IIf(rbIngreso.Checked, "I", "E")
                oePrestamosCuenta.FechaCreacion = ObtenerFechaServidor()
                oePrestamosCuenta.loAsientoModelo = New List(Of e_AsientoModelo)
                ObtenerAsientoModelo(oePrestamosCuenta.IdConceptoIngresos, oePeriodo.Ejercicio)
                oePrestamosCuenta.IdCentro = ObtenerCentro.Id
                If olPrestamosCuenta.Guardar(oePrestamosCuenta) Then
                    If oePrestamosCuenta.IndIngEgr = "I" Then
                        TipoOperacion = "9"
                        Dim formulario As New frm_ReporteVoucherMovimientoCaja
                        formulario.CargarDatos(TipoOperacion, oePrestamosCuenta.Id)
                        formulario.ShowDialog()
                    End If
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                    MostrarTabs(0, ficPrestamosCuenta, 1)
                    ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
                    Listar(True)
                    Return True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Dim odOtrosIngreso As New l_PrestamosCuenta
        Dim oeOtrIng As New e_PrestamosCuenta
        Dim loOtrIng As New List(Of e_PrestamosCuenta)
        Try
            If verBuscarFecha.Checked Then
                oeOtrIng.TipoOperacion = "1"
                oeOtrIng.Fecha = Me.fecDesde.Value
                oeOtrIng.FechaHasta = Me.fecHasta.Value
            Else
                oeOtrIng.TipoOperacion = "2"
                oeOtrIng.Fecha = Date.Parse("01/01/1901")
                oeOtrIng.FechaHasta = Date.Parse("01/01/1901")
            End If

            If cboCentroL.SelectedIndex = 0 Then
                oeOtrIng.IdCentro = ""
            Else
                oeOtrIng.IdCentro = cboCentroL.Value
            End If
            loOtrIng = odOtrosIngreso.Listar(oeOtrIng)
            griPrestamosCuenta.DataSource = loOtrIng
            griPrestamosCuenta.Focus()
            CalcularTotales(griPrestamosCuenta, "Ingreso", "Egreso")
            Dim cantingreso As Double = loOtrIng.Sum(Function(item) item.Ingreso)
            Dim cantegreso As Double = loOtrIng.Sum(Function(item) item.Egreso)
            Me.decSaldo.Value = cantingreso - cantegreso
            If griPrestamosCuenta.Rows.Count > 0 Then
                griPrestamosCuenta.Focus()
                griPrestamosCuenta.Rows.Item(0).Selected = True
                MostrarTabs(0, ficPrestamosCuenta, 0)
                ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1)
            End If
        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        Finally
            Me.Cursor = Cursors.Default
            griPrestamosCuenta.Focus()
        End Try
    End Sub

    Private Sub Inicializar()
        oePrestamosCuenta = New e_PrestamosCuenta
        Me.cboConcepto.Enabled = True
        Me.cboConcepto.SelectedIndex = -1
        Me.txtImporte.Value = 0
        Me.txtGlosa.Text = String.Empty
        Me.txtImporte.Value = 0.0
        Me.txtVoucher.Text = String.Empty
        Me.cboTrabajadores.SelectedIndex = -1
        Me.cboCuentaBancaria.Focus()
        Me.cboCuentaBancaria.SelectedIndex = -1
        Me.rbIngreso.Checked = True
        oePrestamosCuenta.Modificado = False
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub CargarConceptos()
        Try
            Dim loConceptosIngresos As New List(Of e_ConceptoIngresos)
            oeConceptoIngresos = New e_ConceptoIngresos
            oeConceptoIngresos.IdProcesoNegocio = "1CH000000003"
            loConceptosIngresos.AddRange(olConceptoIngresos.Listar(oeConceptoIngresos).Where(Function(i) i.Id = "1SI000000002" Or i.Id = "1SI000000005"))
            LlenarCombo(cboConcepto, "Nombre", loConceptosIngresos, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub LlenaCombosTrabajadores()
        Try
            Dim loTrabajador As New List(Of e_Trabajador)
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = ""
            loTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))
            Dim _leTrabAux = From le In loTrabajador _
                             Select le.Id, le.oePersona.NombreCompleto
            LlenarCombo(cboTrabajadores, "NombreCompleto", _leTrabAux.ToList, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenaCuentaBancaria()
        Try
            Dim oeCtaBancaria As New e_CuentaBancaria
            Dim olCtaBancaria As New l_CuentaBancaria
            Dim leCuentaBancaria As New List(Of e_CuentaBancaria)
            oeCtaBancaria.Activo = True
            oeCtaBancaria.IdMoneda = "1CH01"
            oeCtaBancaria.Ejercicio = Year(Fecha1.Value)
            leCuentaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
            LlenarCombo(cboCuentaBancaria, "BancoCuenta", leCuentaBancaria, -1)
            If leCuentaBancaria.Count = 0 Then
                cboCuentaBancaria.Enabled = False
            Else
                cboCuentaBancaria.Enabled = True
            End If
            EjercicioAyuda = Year(Fecha1.Value)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub r_DatosExtras()
        Try
            If rbIngreso.Checked And cboConcepto.Value = "1SI000000005" Then
                oePrestamosCuenta.IndIngEgr = "I"
                etiVoucher.Text = "Cheque:"
                etiDifDepositada.Visible = False
                decDifDepositada.Value = 0
                decDifDepositada.Visible = False
                etiTotalCheque.Visible = True
                etiTotalChequeEgreso.Visible = True
            Else
                etiDifDepositada.Visible = False
                decDifDepositada.Value = 0
                etiTotalCheque.Visible = False
                etiVoucher.Text = "Operacion:"
                etiTotalChequeEgreso.Visible = False
                decDifDepositada.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function BuscarIdCta(ByVal idtrabajador As String, ByVal TipoCuenta As Integer) As String
        Dim idctacte As String = ""
        Dim e_CtaCte As New e_CuentaCorriente
        Dim l_CtaCte As New l_CuentaCorriente
        e_CtaCte.IdTrabajador = idtrabajador
        e_CtaCte.Tipo = TipoCuenta
        e_CtaCte = l_CtaCte.Obtener(e_CtaCte)
        idctacte = e_CtaCte.Id
        Return idctacte
    End Function

    Private Sub LlenaComboCentro()
        Dim oe As New e_Centro
        Dim leCentro As New List(Of e_Centro)
        oe.Id = ""
        oe.Nombre = "TODOS"
        leCentro.Add(oe)
        leCentro.AddRange(olCentro.Listar(oeCentro))
        LlenarCombo(cboCentroL, "Nombre", leCentro, 0)
        cboCentroL.Value = ObtenerCentro.Id
    End Sub

    Public Sub EliminarPrestamo()
        Try
            Dim oeSaldo As New e_Saldo
            Dim olSaldo As New l_Saldo
            oeSaldo.TipoOperacion = "3"
            oeSaldo.IdCaja = idCajaCentro
            oeSaldo = olSaldo.Obtener(oeSaldo)
            oePrestamosCuenta = New e_PrestamosCuenta
            oePrestamosCuenta.Id = griPrestamosCuenta.ActiveRow.Cells("Id").Value
            oePrestamosCuenta.FechaCreacion = griPrestamosCuenta.ActiveRow.Cells("FechaCreacion").Value
            If oePrestamosCuenta.FechaCreacion > oeSaldo.FechaHora Then
                oePrestamosCuenta.TipoOperacion = "E"
                If olPrestamosCuenta.Eliminar(oePrestamosCuenta) Then
                    mensajeEmergente.Confirmacion("La Informacion ha Sido Eliminada Correctamente")
                    Listar(True)
                End If
            Else
                Throw New Exception("No Puede Eliminar Vales Pasado el Cierre de Caja")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BuscarUsuarioCaja()
        Try
            Dim oeCajaUsuario As New e_CajaUsuario
            Dim olCajaUsuario As New l_CajaUsuario
            oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
            idCajaCentro = oeCajaUsuario.IdCaja
            If oeCajaUsuario.Id <> "" Then
                cboCentroL.Value = oeCajaUsuario.IdCentro
                If oeCajaUsuario.IdCentro = "1CH001" Then
                    cboCentroL.Enabled = True
                Else
                    cboCentroL.Enabled = False
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function CierreCuenta() As Boolean
        Try
            If griPrestamosCuenta.Rows.Count > 0 Then
                oePrestamosCuenta = New e_PrestamosCuenta
                oePrestamosCuenta.oeSaldo = New e_Saldo
                oePrestamosCuenta.oeSaldo.Tipo = 3
                oePrestamosCuenta.oeSaldo.IdCaja = idCajaCentro
                oePrestamosCuenta.oeSaldo.IdCuentaCorriente = BuscarIdCta(gUsuarioSGI.IdTrabajador, 1)
                oePrestamosCuenta.oeSaldo.FechaHora = ObtenerFechaServidor()
                oePrestamosCuenta.oeSaldo.Saldo = decSaldo.Value
                oePrestamosCuenta.oeSaldo.UsuarioCreacion = gUsuarioSGI.Id

                oePrestamosCuenta.TipoOperacion = "C"
                oePrestamosCuenta.FechaCierre = oePrestamosCuenta.oeSaldo.FechaHora
                oePrestamosCuenta.IdConceptoIngresos = oePrestamosCuenta.oeSaldo.IdCuentaCorriente
                If olPrestamosCuenta.CerrarCuenta(oePrestamosCuenta) Then
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Eventos"

    Private Sub frm_PrestamosCuenta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficPrestamosCuenta.SelectedTab.Index
            Case 0
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_PrestamosCuenta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_PrestamosCuenta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_PrestamosCuenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        CargarConceptos()
        LlenaCombosTrabajadores()
        LlenaCuentaBancaria()
        LlenaComboCentro()
        BuscarUsuarioCaja()
        AsientosContables()
        fecDesde.Value = Date.Now.AddDays(-30)
        MostrarTabs(0, ficPrestamosCuenta)
        Me.cboConcepto.Enabled = True
        DecTC.Value = TipoCambio(Fecha1.Value, True)(0)
    End Sub

    Private Sub txtImporte_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.GotFocus
        Me.txtImporte.SelectAll()
    End Sub

    Private Sub txtImporte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.ValueChanged
        oePrestamosCuenta.Modificado = True
        If oeCtaBancaria.IdMoneda = "1CH01" Then
            EtiImporteDolares.Text = Math.Round(txtImporte.Value / DecTC.Value, 2)
        Else
            EtiImporteDolares.Text = Math.Round(txtImporte.Value * DecTC.Value, 2)
        End If
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oePrestamosCuenta.Modificado = True
    End Sub

    Private Sub griOtrosIngresos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.Cancel = True
    End Sub

    Private Sub cboTrabajadores_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadores.ValueChanged
        oePrestamosCuenta.UsuarioAutoriza = cboTrabajadores.Value
        oePrestamosCuenta.Modificado = True
    End Sub

    Private Sub cboConcepto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.ValueChanged
        oePrestamosCuenta.IdConceptoIngresos = cboConcepto.Value
        oePrestamosCuenta.Modificado = True
        r_DatosExtras()
        If rbIngreso.Checked Then
            If cboConcepto.Value = "1SI000000019" Then
                cboCuentaBancaria.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub verBuscarFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verBuscarFecha.CheckedChanged
        agrBuscarFecha.Enabled = verBuscarFecha.Checked
    End Sub

    Private Sub rbEgreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEgreso.CheckedChanged
        If rbEgreso.Checked Then oePrestamosCuenta.IndIngEgr = "E"
    End Sub

    Private Sub rbIngreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIngreso.CheckedChanged
        If rbIngreso.Checked Then oePrestamosCuenta.IndIngEgr = "I"
        r_DatosExtras()
    End Sub

    Private Sub txtVoucher_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVoucher.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVoucher_Validated(sender As Object, e As EventArgs) Handles txtVoucher.Validated
        If Me.txtVoucher.Text <> String.Empty Then txtVoucher.Text = FormatoDocumento(txtVoucher.Text, 8)
    End Sub

    Private Sub txtVoucher_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVoucher.ValueChanged
        oePrestamosCuenta.Modificado = True
    End Sub

    Private Sub Fecha1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fecha1.Validated
        Try
            If DecTC.Value = 0 Then
                DecTC.Value = TipoCambio(Fecha1.Value, True)(0)
            End If

            If Year(Fecha1.Value) <> EjercicioAyuda Then
                LlenaCuentaBancaria()
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Fecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha1.ValueChanged
        oePrestamosCuenta.Modificado = True
    End Sub

    Private Sub DecTC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTC.ValueChanged
        Try
            If oeCtaBancaria.IdMoneda = "1CH01" Then
                EtiImporteDolares.Text = Math.Round(txtImporte.Value / DecTC.Value, 2)
            Else
                EtiImporteDolares.Text = Math.Round(txtImporte.Value * DecTC.Value, 2)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboCuentaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaBancaria.ValueChanged
        Try
            If cboCuentaBancaria.SelectedIndex <> -1 Then
                oeCtaBancaria = cboCuentaBancaria.Items(cboCuentaBancaria.SelectedIndex).ListObject
            End If
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message)
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
        Me.rbIngreso.Checked = True
        oePrestamosCuenta.IndIngEgr = "I"
    End Sub

    Private Sub EgresosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgresosToolStripMenuItem.Click
        Nuevo()
        Me.rbEgreso.Checked = True
        oePrestamosCuenta.IndIngEgr = "E"
    End Sub

    Private Sub CierreCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreCuentaToolStripMenuItem.Click
        Try
            If CierreCuenta() Then
                Listar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

#End Region

#Region "Asiento Contable"

    Private Sub AsientosContables()
        AsientoModelo()
        dtReferencia = GeneraDTRef(loReferencia)
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        loAsientoModelo = New List(Of e_AsientoModelo)
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = pIdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Public Sub ObtenerAsientoModelo(IdConceptoIngresos As String, Ejercicio As Integer)
        Try
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 9 AND IdRef1 = '" & IdConceptoIngresos & "'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModeloPrestamo = New e_AsientoModelo
            oeAsientoModeloPrestamo.TipoOperacion = ""
            oeAsientoModeloPrestamo.Activo = True
            oeAsientoModeloPrestamo.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModeloPrestamo.Ejercicio = Ejercicio
            oeAsientoModeloPrestamo = olAsientoModelo.Obtener(oeAsientoModeloPrestamo)
            oePrestamosCuenta.loAsientoModelo = New List(Of e_AsientoModelo)
            oePrestamosCuenta.loAsientoModelo.Add(oeAsientoModeloPrestamo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class