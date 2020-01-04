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

Public Class frm_OtrosIngresos
    Inherits frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_OtrosIngresos = Nothing
    Private Shared Operacion As String = ""

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_OtrosIngresos()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private WithEvents oeOtrosIngresos As New e_OtrosIngresos
    Private olOtrosIngresos As New l_OtrosIngresos
    Private loOtrosIngresos As New List(Of e_OtrosIngresos)
    'Centro
    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    'CuentaCorriente
    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim olCuentaCorriente As New l_CuentaCorriente
    Dim loCuentaCorriente As New List(Of e_CuentaCorriente)
    'ConceptoIngresos
    Private oeConceptoIngresos As New e_ConceptoIngresos
    Private olConceptoIngresos As New l_ConceptoIngresos
    Private loConceptoIngresos As New List(Of e_ConceptoIngresos)
    'CuentaBancaria
    Private oeCtaBancaria As New e_CuentaBancaria
    Private olCtaBancaria As New l_CuentaBancaria
    Private loCtaBancaria As New List(Of e_CuentaBancaria)
    'Trabajador
    Private oeTrabajador As New e_Trabajador
    Private olTrabajador As New l_Trabajador
    Private loTrabajador As New List(Of e_Trabajador)
    'Caja
    Private IdCajaCentro As String = ""
    Dim _ingresando_datos As Boolean = False
    Dim EjercicioAyuda As Integer
    'Orden de Salida
    Private oeOrden As New e_Orden
    Private olOrden As New l_Orden
    Private loOrden As New List(Of e_Orden)

    Dim oeOrdenMaterial As New e_OrdenMaterial
    Dim olOrdenMaterial As New l_OrdenMaterial
    Dim loOrdenMaterial As New List(Of e_OrdenMaterial)

    Private oeAsientoModelo, oeAsientoModeloOI As New e_AsientoModelo
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
            MostrarTabs(1, ficOtrosIngresos, 1)
            Inicializar()
            oeOtrosIngresos.TipoOperacion = "I"
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            'ListarUsuarioCaja()
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar(Activo)
            If griOtrosIngresos.Rows.Count > 0 Then
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
            Else

                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            'If ValidaUsuarioCajaCentro(IdCajaCentro, ObtenerCentro(gs_PrefijoIdSucursal).Id, gUsuarioSGI.IdTrabajador) Then
            If GuardarIE() Then
                MostrarTabs(0, ficOtrosIngresos, 0)
                Consultar(True)
            Else
                MostrarTabs(1, ficOtrosIngresos, 0)
            End If
            'Else
            '    Throw New Exception("No puede Realizar Movimientos en esta Sede")
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            If griOtrosIngresos.ActiveRow.Selected Then
                If griOtrosIngresos.ActiveRow.Cells("Ingreso").Value <> 0 Then
                    Dim formulario As New frm_ReporteVoucherMovimientoCaja
                    formulario.CargarDatos("O", griOtrosIngresos.ActiveRow.Cells("Id").Value)
                    formulario.ShowDialog()
                    ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeOtrosIngresos.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarIE() Then
                            MostrarTabs(0, ficOtrosIngresos, 1)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficOtrosIngresos, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficOtrosIngresos, 2)
                        ficOtrosIngresos.Tabs(1).Enabled = False
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficOtrosIngresos)
                _ingresando_datos = False
                Listar(True)
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griOtrosIngresos.Rows.Count > 0 Then
                Exportar_Excel(griOtrosIngresos)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_OtrosIngresos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficOtrosIngresos.SelectedTab.Index
            Case 0
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_OtrosIngresos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_OtrosIngresos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_OtrosIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        LlenaComboCentro()
        ListarCuentaCorriente()
        BuscarUsuarioCaja()
        LlenaCuentaBancaria()
        CargarConceptos()
        LlenaCombosTrabajadores()
        ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
        CargarTipoCambio()
        AsientosContables()
    End Sub

    Private Sub btnIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresos.Click
        MostrarTabs(1, ficOtrosIngresos, 1)
        Inicializar()
        uebOrdenSalida.Visible = True
        oeOtrosIngresos.TipoOperacion = "I"
        rdbIngresos.Checked = True
        cboCuentaBancaria.Focus()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub btnEgresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEgresos.Click
        MostrarTabs(1, ficOtrosIngresos, 1)
        Inicializar()
        uebOrdenSalida.Visible = False
        oeOtrosIngresos.TipoOperacion = "I"
        rdbEgresos.Checked = True
        cboCuentaBancaria.Focus()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub IngresosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresosToolStripMenuItem.Click
        btnIngresos.PerformClick()
    End Sub

    Private Sub EgresosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgresosToolStripMenuItem.Click
        btnEgresos.PerformClick()
    End Sub

    Private Sub cboCuentaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaBancaria.ValueChanged
        oeOtrosIngresos.Modificado = True
    End Sub

    Private Sub cboTrabajadores_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadores.ValueChanged
        oeOtrosIngresos.Modificado = True
    End Sub

    Private Sub txtImporte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.ValueChanged
        oeOtrosIngresos.Modificado = True
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeOtrosIngresos.Modificado = True
    End Sub

    Private Sub cboConcepto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.ValueChanged
        oeOtrosIngresos.Modificado = True
        If rdbIngresos.Checked Then
            If cboConcepto.Value = "1SI000000019" Then
                cboCuentaBancaria.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        oeOtrosIngresos.Modificado = True
    End Sub

    Private Sub rdbIngresos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbIngresos.CheckedChanged
        If rdbIngresos.Checked Then
            cboCuentaBancaria.Enabled = False
            cboCuentaBancaria.SelectedIndex = -1
            cboTrabajadores.Enabled = True
            cboTrabajadores.SelectedIndex = -1
            uebOrdenSalida.Visible = True
            uebOrdenSalida.Expanded = False
        End If
    End Sub

    Private Sub rdbEgresos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbEgresos.CheckedChanged
        If rdbEgresos.Checked Then
            cboCuentaBancaria.Enabled = True
            cboCuentaBancaria.SelectedIndex = -1
            cboTrabajadores.Enabled = False
            cboTrabajadores.SelectedIndex = -1
            uebOrdenSalida.Visible = False
        End If
    End Sub

    Private Sub verBuscarFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verBuscarFecha.CheckedChanged
        If verBuscarFecha.Checked Then
            agrBuscarFecha.Enabled = True
        Else
            agrBuscarFecha.Enabled = False
        End If
    End Sub

    Private Sub dtpFecha_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.Validated
        Try
            If DecTC.Value = 0 Then
                DecTC.Value = TipoCambio(dtpFecha.Value, True)(0)
            End If

            If Year(dtpFecha.Value) <> EjercicioAyuda Then
                LlenaCuentaBancaria()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridListaOrden_DoubleClick(sender As Object, e As EventArgs) Handles gridListaOrden.DoubleClick
        Try
            If gridListaOrden.Selected.Rows.Count > 0 Then
                AgregarReferencia()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscarOrdenes_Click(sender As Object, e As EventArgs) Handles btnBuscarOrdenes.Click
        Try
            ListarOrdenSalida()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNIngreso_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNIngreso.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ListarOrdenSalida()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridListaOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles gridListaOrden.KeyDown
        Try
            If gridListaOrden.Selected.Rows.Count > 0 Then
                If e.KeyCode = Keys.Enter Then
                    AgregarReferencia()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        oeOtrosIngresos = New e_OtrosIngresos
        rdbEgresos.Checked = False
        rdbIngresos.Checked = False
        uebOrdenSalida.Expanded = False
        uebOrdenSalida.Visible = False
        cboCuentaBancaria.SelectedIndex = -1
        cboTrabajadores.SelectedIndex = -1
        Me.txtImporte.Value = 0.0
        Me.txtGlosa.Text = String.Empty
        Me.TxtVoucher.Text = String.Empty
        cboConcepto.SelectedIndex = -1
        Me.dtpFecha.Value = ObtenerFechaServidor()
        oeOrden = New e_Orden
        loOrden = New List(Of e_Orden)
        oeOrdenMaterial = New e_OrdenMaterial
        loOrdenMaterial = New List(Of e_OrdenMaterial)
    End Sub

    Private Sub LlenaComboCentro()
        Dim oe As New e_Centro
        Dim leCentro As New List(Of e_Centro)
        oe.Id = ""
        oe.Nombre = "TODOS"
        leCentro.Add(oe)
        leCentro.AddRange(olCentro.Listar(oeCentro))
        LlenarCombo(cboCentroL, "Nombre", leCentro, 0)
    End Sub

    Private Sub ListarCuentaCorriente()
        Try
            oeCuentaCorriente = New e_CuentaCorriente
            oeCuentaCorriente.Activo = True
            loCuentaCorriente = olCuentaCorriente.Listar(oeCuentaCorriente).OrderBy(Function(item) item.Trabajador).ToList
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BuscarUsuarioCaja()
        Try
            Dim oeCajaUsuario As New e_CajaUsuario
            Dim olCajaUsuario As New l_CajaUsuario
            oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
            If oeCajaUsuario.Id <> "" Then
                cboCentroL.Value = oeCajaUsuario.IdCentro
                IdCajaCentro = oeCajaUsuario.IdCaja
                If oeCajaUsuario.IdCentro = "1CH001" Then
                    cboCentroL.Enabled = True
                Else
                    cboCentroL.Enabled = False
                End If
            Else
                Throw New Exception("Usuario no Asignado a Caja")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaCuentaBancaria()
        Try
            oeCtaBancaria = New e_CuentaBancaria
            oeCtaBancaria.Activo = True
            oeCtaBancaria.IdMoneda = "1CH01"
            oeCtaBancaria.Ejercicio = Year(dtpFecha.Value)
            loCtaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
            LlenarCombo(cboCuentaBancaria, "BancoCuenta", loCtaBancaria, -1)
            If loCtaBancaria.Count = 0 Then
                cboCuentaBancaria.Enabled = False
            Else
                cboCuentaBancaria.Enabled = True
            End If
            EjercicioAyuda = Year(dtpFecha.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            oeOtrosIngresos = New e_OtrosIngresos
            loOtrosIngresos = New List(Of e_OtrosIngresos)
            oeOtrosIngresos.TipoOperacion = "1"
            If cboCentroL.SelectedIndex = 0 Then
                oeOtrosIngresos.IdCentro = ""
            Else
                oeOtrosIngresos.IdCentro = cboCentroL.Value
            End If
            If Me.verBuscarFecha.Checked Then
                oeOtrosIngresos.IdCentro = ""
                oeOtrosIngresos.Fecha = Me.fecDesde.Value
                oeOtrosIngresos.FechaCierre = Me.fecHasta.Value
            End If
            loOtrosIngresos = olOtrosIngresos.Listar(oeOtrosIngresos)
            griOtrosIngresos.DataSource = loOtrosIngresos
            griOtrosIngresos.Focus()
            CalcularTotales(griOtrosIngresos, "Ingreso", "Egreso")
            Dim cantingreso As Double = loOtrosIngresos.Sum(Function(item) item.Ingreso)
            Dim cantegreso As Double = loOtrosIngresos.Sum(Function(item) item.Egreso)
            Me.decSaldo.Value = cantingreso - cantegreso
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function GuardarIE() As Boolean
        Try
            LlenaObjeto()
            If oeOrdenMaterial.IdOrden <> "" Then
                oeOtrosIngresos.IdReferencia = oeOrdenMaterial.IdOrden
                oeOtrosIngresos.TipoReferencia = "ORDEN DE SALIDA"
            End If
            oeOtrosIngresos.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olOtrosIngresos.Guardar(oeOtrosIngresos) Then
                If oeOtrosIngresos.IndIngresoEgreso = True Then
                    Dim formulario As New frm_ReporteVoucherMovimientoCaja
                    formulario.CargarDatos("O", oeOtrosIngresos.Id)
                    formulario.ShowDialog()
                    mensajeEmergente.Confirmacion("La Informacion ha sido Guardada Correctamente en: " & Me.Text)
                End If
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub CargarConceptos()
        Try
            oeConceptoIngresos = New e_ConceptoIngresos
            oeConceptoIngresos.IdProcesoNegocio = "1CH000000003"
            loConceptoIngresos.AddRange(olConceptoIngresos.Listar(oeConceptoIngresos).Where(Function(i) i.Id = "1SI000000019" Or i.Id = "1SI000000002" Or i.Id = "1SI000000005"))
            LlenarCombo(cboConcepto, "Nombre", loConceptoIngresos, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub LlenaCombosTrabajadores()
        Try
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = ""
            loTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))
            Dim _leTrabAux = From le In loTrabajador Select le.Id, le.oePersona.NombreCompleto
            LlenarCombo(cboTrabajadores, "NombreCompleto", _leTrabAux.ToList, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaObjeto()
        Try
            Dim olPeriodo As New l_Periodo
            Dim oePeriodo As New e_Periodo
            oePeriodo.Ejercicio = Date.Parse(dtpFecha.Value).Year
            oePeriodo.Mes = Date.Parse(dtpFecha.Value).Month
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If ValidaCampos(oePeriodo) Then
                oeOtrosIngresos.TipoOperacion = "I"
                oeOtrosIngresos.Fecha = dtpFecha.Value
                oeOtrosIngresos.FechaCreacion = ObtenerFechaServidor()
                oeOtrosIngresos.Importe = txtImporte.Value
                oeOtrosIngresos.Glosa = txtGlosa.Text
                oeOtrosIngresos.Voucher = FormatoDocumento(TxtVoucher.Text, 8)
                oeOtrosIngresos.UsuarioCreacion = gUsuarioSGI.Id
                oeOtrosIngresos.IdPeriodo = oePeriodo.Id
                oeOtrosIngresos.IdConceptoIngresos = cboConcepto.Value
                oeOtrosIngresos.IdCuentaBancaria = cboCuentaBancaria.Value
                oeOtrosIngresos.TipoCambio = DecTC.Value
                oeOtrosIngresos.IdCentro = ObtenerCentro(gs_PrefijoIdSucursal).Id
                oeOtrosIngresos.UsuarioCreacion = gUsuarioSGI.Id
                oeOtrosIngresos.IdCuentaCorriente = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
                oeOtrosIngresos.IdTrabajador = cboTrabajadores.Value
                oeOtrosIngresos.DifDepositada = decDifDepositada.Value 
                oeOtrosIngresos.IdCaja = IdCajaCentro
                ObtenerAsientoModelo(oeOtrosIngresos.IndIngresoEgreso, oePeriodo.Ejercicio)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function ValidaCampos(ByVal oePeriodo As e_Periodo) As Boolean
        Try
            If cboConcepto.Value <> "1SI000000019" Then ValidarCombo(cboCuentaBancaria, "Cuenta Bancaria")
            If Me.txtGlosa.Text = "" Then
                Throw New Exception("Llene la Glosa por Favor")
            ElseIf Me.txtImporte.Value = 0 Then
                Throw New Exception("El Importe tiene que ser Mayor a 0")
            ElseIf Me.cboConcepto.SelectedIndex = -1 Then
                Throw New Exception("Seleccione Concepto por Favor")
            End If
            If oePeriodo.Id Is Nothing Then
                Throw New Exception("No existe Periodo")
            End If
            If rdbIngresos.Checked Then
                oeOtrosIngresos.IndIngresoEgreso = True
            Else
                oeOtrosIngresos.IndIngresoEgreso = False
                If Me.TxtVoucher.Text = String.Empty Then Throw New Exception("Escriba el Numero de Voucher del Deposito")
            End If
            If rdbEgresos.Checked = False And rdbIngresos.Checked = False Then
                Throw New Exception("Seleccione Ingreso o Egreso")
            End If
            l_FuncionesGenerales.ValidarPeriodo(oePeriodo.Id, gAreasSGI.Tesoreria)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub CargarTipoCambio()
        DecTC.Value = TipoCambio(dtpFecha.Value, True)(0)
    End Sub

    Private Sub ListarOrdenSalida()
        Try
            oeOrden = New e_Orden
            loOrden = New List(Of e_Orden)
            oeOrden.TipoOperacion = ""
            oeOrden.Activo = True
            oeOrden.IdTipoOrden = "1CH000000002"
            oeOrden.Id = ""
            If String.IsNullOrEmpty(txtNIngreso.Text.Trim) Then Throw New Exception("Ingrese N° de la Orden.")
            oeOrden.NroOrden = Me.txtNIngreso.Text.Trim
            oeOrden.fechaInicio = "01/01/1901"
            oeOrden.fechaFin = "01/01/1901"
            oeOrden.IdMovimientoInventario = "1CH000000038"
            oeOrden.EstadoOrden = "1CH000000003"
            loOrden = olOrden.Listar(oeOrden)
            gridListaOrden.DataSource = loOrden
            gridListaOrden.DisplayLayout.Bands(0).Columns("NombreSubEstado").Hidden = True
            'Ubica el cursor el el primer registro de la grilla
            If gridListaOrden.Rows.Count > 0 Then
                gridListaOrden.Focus()
                gridListaOrden.Rows.Item(0).Selected = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarReferencia()
        Try
            oeOrdenMaterial = New e_OrdenMaterial
            loOrdenMaterial = New List(Of e_OrdenMaterial)
            oeOrdenMaterial.TipoOperacion = "L"
            oeOrdenMaterial.Activo = True
            oeOrdenMaterial.IdOrden = gridListaOrden.ActiveRow.Cells("Id").Value
            loOrdenMaterial = olOrdenMaterial.Listar(oeOrdenMaterial)
            Me.txtGlosa.Text = ""
            Me.txtImporte.Value = Math.Round(CDbl(gridListaOrden.ActiveRow.Cells("Total").Value), 2)
            If loOrdenMaterial.Count > 0 Then
                For Each ordmat As e_OrdenMaterial In loOrdenMaterial
                    Me.txtGlosa.Text = Me.txtGlosa.Text & ordmat.Material & " "
                Next
                uebOrdenSalida.Expanded = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Asiento Modelo"

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

    Public Sub ObtenerAsientoModelo(Indicador As Boolean, Ejercicio As Boolean)
        Try
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            If Indicador Then
                cadSQL = "TipoRef1 = 4 AND IdRef1 = '1CH01' AND TipoRef2 = 10 AND IdRef2 = '1PK000000001' "
            Else
                cadSQL = "TipoRef1 = 4 AND IdRef1 = '1CH01' AND TipoRef2 = 10 AND IdRef2 = '1PK000000003' "
            End If
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModeloOI = New e_AsientoModelo
            oeAsientoModeloOI.TipoOperacion = ""
            oeAsientoModeloOI.Activo = True
            oeAsientoModeloOI.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModeloOI = olAsientoModelo.Obtener(oeAsientoModeloOI)
            oeOtrosIngresos.loAsientoModelo = New List(Of e_AsientoModelo)
            oeOtrosIngresos.loAsientoModelo.Add(oeAsientoModeloOI)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    Private Sub TxtVoucher_Validated(sender As Object, e As EventArgs) Handles TxtVoucher.Validated
        TxtVoucher.Text = FormatoDocumento(TxtVoucher.Text, 8)
    End Sub

End Class