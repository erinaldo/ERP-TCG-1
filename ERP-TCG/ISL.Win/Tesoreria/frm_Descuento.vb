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
Imports MSScriptControl

Public Class frm_Descuento
    Inherits frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_Descuento = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Descuento()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeMovimiento As New e_Movimiento
    Private olPersona As New l_Persona

    Dim olMovimiento As New l_Movimiento
    Dim idCuentaTrabajador, idTrabajador As String
    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim olCuentaCorriente As New l_CuentaCorriente
    Dim oeMovimientoViaje As New e_Movimiento_Viaje

    Dim oeProcesoGlosa As New e_ProcesoGlosa
    Dim olProcesoGlosa As New l_ProcesoGlosa

    Dim oeCajaUsuario As New e_CajaUsuario
    Dim olCajaUsuario As New l_CajaUsuario
    Dim idCajaCentro As String = ""

    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador

    Dim loCuentaCorriente As New List(Of e_CuentaCorriente)

    Private oeSueldo As New e_SueldoTrabajador, olSueldo As New l_SueldoTrabajador, leSueldo As New List(Of e_SueldoTrabajador)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)

    Dim olTrabajadorSeguridad As New l_TrabajadorSeguridad
    Dim Prefijo As New l_Configuracion
    Dim loMovimiento As New List(Of e_Movimiento)
    Private Estado As String
    Dim _ingresando_datos As Boolean = False

    Dim idViaje As String = ""
    Dim IdMovimiento As String = ""
    Dim Importe As Double = 0
    Dim Opcion As Boolean

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, ficDescuentos, 1)
            oeMovimiento.Modificado = False
            Inicializar()
            cboTrabajadores.Focus()
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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If ValidaUsuarioCajaCentro(idCajaCentro, ObtenerCentro(gs_PrefijoIdSucursal).Id, gUsuarioSGI.IdTrabajador) Then
                Select Case ficDescuentos.SelectedTab.Index
                    Case 1
                        If GuardarDescuento() Then
                            MyBase.Guardar()
                        Else
                            MostrarTabs(1, ficDescuentos, 1)
                        End If
                    Case 2
                        If GuardarExtorno() Then
                            MyBase.Guardar()
                            Me.ficDescuentos.Tabs(2).Enabled = False
                        Else
                            MostrarTabs(1, ficDescuentos, 1)
                        End If
                End Select
            Else
                Throw New Exception("No puede Realizar Movimientos en esta Sede")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            Dim operacion As String = ""
            If griDescuentos.ActiveRow.Cells("Viaje").Value = "ADMINISTRATIVO" Then
                operacion = "6"
            Else
                operacion = "2"
            End If
            If griDescuentos.ActiveRow.Selected Then
                Dim formulario As New frm_ReporteVoucherMovimientoCaja
                formulario.CargarDatos(operacion, griDescuentos.ActiveRow.Cells("Id").Value)
                formulario.ShowDialog()
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMovimiento.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarDescuento() Then
                            MostrarTabs(0, ficDescuentos, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficDescuentos, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficDescuentos, 2)
                        ficDescuentos.Tabs(2).Enabled = False
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficDescuentos)
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
            If ficDescuentos.SelectedTab.Index = 0 AndAlso griDescuentos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficDescuentos.SelectedTab.Index = 0 Then Exportar_Excel(griDescuentos)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griDescuentos.Selected.Rows.Count > 0 Then
                Dim IdCaja As String = ""
                If Not griDescuentos.ActiveRow.Cells("Viaje").Value = "ADMINISTRATIVO" Then
                    Throw New Exception("Solo Puede Eliminar Descuentos Administrativos")
                End If
                oeMovimiento = New e_Movimiento
                oeMovimiento.Id = griDescuentos.ActiveRow.Cells("Id").Value
                IdCaja = griDescuentos.ActiveRow.Cells("IdMovimientoViaje").Value
                If IdCaja <> idCajaCentro Then Throw New Exception("Solo Puede Eliminar Descuentos de su Caja")
                oeMovimiento = olMovimiento.Obtener(oeMovimiento)
                Select Case MessageBox.Show("Desea Eliminar el Descuento Registrado?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        Dim oeSaldo As New e_Saldo
                        Dim olSaldo As New l_Saldo
                        oeSaldo.TipoOperacion = "3"
                        oeSaldo.IdCaja = idCajaCentro
                        oeSaldo = olSaldo.Obtener(oeSaldo)
                        If oeMovimiento.Fecha > oeSaldo.FechaHora Then
                            olMovimiento.Eliminar(oeMovimiento)
                        Else
                            Throw New Exception("No Puede Eliminar Movimientos Pasado el Cierre de Caja")
                        End If
                        Listar(True)
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Function ValidaCampos() As Boolean
        Try
            If Me.txtGlosa.Text = "" Then
                mensajeEmergente.Problema("Llene la Glosa por Favor")
                Return False
            ElseIf Me.txtImporte.Value = 0 Then
                mensajeEmergente.Problema("El Importe tiene que ser Mayor a 0")
                Return False
            ElseIf Me.cboTrabajadores.SelectedIndex = -1 Then
                mensajeEmergente.Problema("Tiene que Seleccionar un Trabajador")
                Return False
            ElseIf Me.cboConceptos.SelectedIndex = -1 Then
                mensajeEmergente.Problema("Seleccione Concepto de Prestamo")
                Return False
            End If
            If Me.cboConceptos.Text = "PRESTAMOS" And Me.txtArea.Text <> gNombreAreaGerenciaGeneral Then
                If numCuotas.Value = 0 Then
                    mensajeEmergente.Problema("Tiene que Ingresar el Numero de Cuotas para Prestamos")
                    Return False
                End If
            End If
            'If Me.cboConceptos.Text = "ADELANTOS" Then
            '    If txtImporte.Value > ndRenumeracion.Value * 0.25 Then
            '        mensajeEmergente.Problema("No Puede Adelantar un Monto Mayor al 25% Remuneracion del Trabajador")
            '        Return False
            '    End If
            'End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarDescuento() As Boolean
        Dim TipoOperacion = 0
        Try
            If ValidaCampos() Then
                oeMovimiento.Fecha = ObtenerFechaServidor()
                oeMovimiento.TipoOperacion = "I"
                oeMovimiento.IdCuentaCorrienteDestino = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
                oeMovimiento.IdCuentaCorrienteOrigen = BuscarIdCtaCte(Me.cboTrabajadores.Value, 0, loCuentaCorriente)
                If oeMovimiento.IdCuentaCorrienteOrigen = "" Then Throw New Exception("Trabajador sin Cuenta Corriente. Verificar")
                oeMovimiento.Ingreso = Me.txtImporte.Value
                oeMovimiento.Egreso = 0
                oeMovimiento.Saldo = Me.txtImporte.Value
                oeMovimiento.Glosa = Me.txtGlosa.Text
                oeMovimiento.IndPrestamoHab = 0
                oeMovimiento.Voucher = ""
                oeMovimiento.UsuarioCreacion = gUsuarioSGI.Id
                oeMovimiento.IdEstado = "HABILITADA"
                oeMovimiento.Descuento = 1
                oeMovimiento.TipoMovimiento = 2
                oeMovimiento.Activo = 1
                oeMovimiento.TipoTransa = 4
                oeMovimiento.AsignadoGrupo = 0
                oeMovimiento.SaldoPorDepositar = 0
                oeMovimiento.Depositado = 0
                oeMovimiento.IdCaja = idCajaCentro
                oeMovimiento.Concepto = cboConceptos.Value
                oeMovimiento.NroCuotas = numCuotas.Value
                oeMovimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olMovimiento.GuardarDsctoExtorno(oeMovimiento) Then
                    TipoOperacion = "6"
                    Dim formulario As New frm_ReporteVoucherMovimientoCaja
                    formulario.CargarDatos(TipoOperacion, oeMovimiento.Id)
                    formulario.ShowDialog()
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    MostrarTabs(0, ficDescuentos, 2)
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    Listar(True)
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Dim odMovimiento As New l_Movimiento
        Dim oeMovDesc As New e_Movimiento
        Try
            oeMovDesc.TipoOperacion = "D"
            griDescuentos.DataSource = odMovimiento.ListarDscto(oeMovDesc)
            CalcularTotales(griDescuentos, "Importe")
            griDescuentos.Focus()
            If griDescuentos.Rows.Count Then
                griDescuentos.Rows.Item(0).Selected = True
            End If
            ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        Finally
            Me.Cursor = Cursors.Default
            griDescuentos.Focus()
        End Try
    End Sub

    Private Sub Inicializar()
        Me.cboTrabajadores.Enabled = True
        Me.cboTrabajadores.SelectedIndex = -1
        Me.cboPilotoViaje.SelectedIndex = -1
        Me.cboViaje.SelectedIndex = -1
        Me.cboConceptos.SelectedIndex = -1
        Me.txtImporte.Value = 0
        Me.ndSueldo.Value = 0.0
        Me.ndAsigFam.Value = 0.0
        Me.ndRenumeracion.Value = 0.0
        Me.numCuotas.Value = 0
        Me.txtGlosa.Text = String.Empty
        Me.txtArea.Text = String.Empty
        Me.txtCargo.Text = String.Empty
        Me.FotoTrabajador.Visible = False
        Me.agrDatosBasicos.Visible = False
        Me.cbVerGlosa.Checked = False
        Me.expGlosa.Visible = False
        Importe = 0
        IdMovimiento = ""
        idViaje = ""
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub ListarCuentaCorriente()
        Try
            oeCuentaCorriente = New e_CuentaCorriente
            oeCuentaCorriente.Activo = True
            loCuentaCorriente = olCuentaCorriente.Listar(oeCuentaCorriente)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function BuscarIdTrab(ByVal idCuentaCorriente As String, ByVal TipoCuenta As Integer) As String
        Dim IdTrab As String = ""
        Try
            Dim oeCtaCte As New e_CuentaCorriente
            oeCtaCte.Id = idCuentaCorriente
            oeCtaCte.Tipo = TipoCuenta
            oeCtaCte = olCuentaCorriente.Obtener(oeCtaCte)
            IdTrab = oeCtaCte.IdTrabajador
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
        Return IdTrab
    End Function

    Private Sub ListarGlosa(ByVal proceso As String)
        Try
            Dim oeConcepto As New e_Concepto_Prestamo
            Dim olConcepto As New l_Concepto_Prestamo
            oeConcepto.TipoOperacion = "P"
            LlenarCombo(cboConceptos, "Nombre", olConcepto.Listar(oeConcepto).OrderBy(Function(item) item.Nombre).ToList, -1)
            oeProcesoGlosa.ProcesoNegocio = proceso
            With griListaGlosa
                oeProcesoGlosa.Activo = 1
                .DataSource = olProcesoGlosa.Listar(oeProcesoGlosa)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdProcesoNegocio").Hidden = True
                .DisplayLayout.Bands(0).Columns("ProcesoNegocio").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("ProcesoNegocio").Width = 300
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 700
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Glosa"
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                    .Rows.Item(0).Activated = True
                End If
            End With
            griListaGlosa.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            griListaGlosa.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GuardarExtorno() As Boolean
        Try
            If MessageBox.Show("Desea Extornar esta Operacion" & " " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                If cboPilotoViaje.SelectedIndex = -1 Or cboViaje.SelectedIndex = -1 Then
                    mensajeEmergente.Problema("Seleccion Piloto y/o Viaje")
                    Return False
                Else
                    oeMovimiento = New e_Movimiento
                    oeMovimiento.Id = ""
                    oeMovimiento.TipoOperacion = "I"
                    oeMovimiento.Fecha = ObtenerFechaServidor()
                    oeMovimiento.Ingreso = 0
                    oeMovimiento.Egreso = Importe
                    oeMovimiento.Descuento = 0
                    oeMovimiento.Saldo = Importe
                    oeMovimiento.IdCuentaCorrienteDestino = BuscarIdCtaCte(cboPilotoViaje.Value, 0, loCuentaCorriente)
                    oeMovimiento.IndPrestamoHab = 0
                    oeMovimiento.Voucher = ""
                    oeMovimiento.UsuarioCreacion = gUsuarioSGI.Id
                    oeMovimiento.TipoMovimiento = 1
                    oeMovimiento.Activo = 1
                    oeMovimiento.IdEstado = "HABILITADA"
                    oeMovimiento.TipoTransa = 2
                    oeMovimiento.AsignadoGrupo = 0
                    oeMovimiento.SaldoPorDepositar = 0
                    oeMovimiento.Depositado = 0
                    oeMovimiento.Glosa = "EXTORNO DE DESCUENTO"
                    oeMovimiento.IndCerrado = 2
                    oeMovimiento.oeMovimientoViaje = New e_Movimiento_Viaje
                    oeMovimiento.oeMovimientoViaje.IdViaje = idViaje
                    oeMovimiento.oeMovimientoViaje.IdTrabajadorRecepciona = cboPilotoViaje.Value
                    oeMovimiento.oeMovimientoViaje.TipoTRB = "E"
                    oeMovimiento.oeMovimientoViaje.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olMovimiento.GuardarDsctoExtorno(oeMovimiento) Then
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                        oeMovimiento = New e_Movimiento
                        oeMovimiento.Id = IdMovimiento
                        oeMovimiento.TipoOperacion = "X"
                        oeMovimiento.AsignadoGrupo = 1
                        oeMovimiento.oeMovimientoViaje = New e_Movimiento_Viaje
                        oeMovimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olMovimiento.GuardarDsctoExtorno(oeMovimiento)
                        MostrarTabs(0, ficDescuentos, 2)
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Listar(True)
                        Return True
                    Else
                        Return False
                    End If
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function Extornar() As Boolean
        Try
            idMovimiento = ""
            If griDescuentos.ActiveRow.Cells("Viaje").Value.ToString <> "ADMINISTRATIVO" Then
                Inicializar()
                MostrarTabs(2, ficDescuentos, 0)
                ficDescuentos.Tabs(0).Enabled = False
                ficDescuentos.Tabs(1).Enabled = False
                Dim id As String = BuscarIdTrab(griDescuentos.ActiveRow.Cells("IdCuentaCorrienteDestino").Value.ToString, 0)
                Me.cboPilotoViaje.Value = id
                IdMovimiento = griDescuentos.ActiveRow.Cells("Id").Value
                Importe = griDescuentos.ActiveRow.Cells("Importe").Value
                If Me.cboViaje.SelectedIndex = -1 Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
                Else
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                End If
            Else
                Throw New Exception("Solo puede Extornar Descuentos de Viaje")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub CargaComboViajePiloto(ByVal IdTrabajador As String)

        Try
            Dim oeViajePiloto As New e_Movimiento_Viaje
            Dim olViajePiloto As New l_Movimiento_Viaje
            Dim asd As String = ""
            oeViajePiloto.TipoOperacion = "D"
            oeViajePiloto.IdPiloto = IdTrabajador
            oeViajePiloto.VincularViajePiloto = "1"
            oeViajePiloto.TipoTransa = "1"
            LlenarCombo(cboViaje, "Viaje", olViajePiloto.Listar(oeViajePiloto), -1)
            asd = griDescuentos.ActiveRow.Cells("Id").Value.ToString
            Me.cboViaje.Value = asd
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ListarUsuarioCaja()
        Try
            oeCajaUsuario = New e_CajaUsuario
            oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
            If oeCajaUsuario.Id <> "" Then
                idCajaCentro = oeCajaUsuario.IdCaja
            Else
                mensajeEmergente.Problema("Este Usuario no esta asignado a ninguna caja")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Descuento_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficDescuentos.SelectedTab.Index
            Case 0
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            Case 2
                If Me.cboViaje.SelectedIndex = -1 Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
                Else
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_Descuento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_Descuento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub txtGlosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGlosa.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub frm_Descuento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, ficDescuentos)
        ListarCuentaCorriente()
        LlenarCombos()
        LlenaCombosTrabajadores()
        ListarUsuarioCaja()
        ListarGlosa("DESCUENTO")
        Me.cboTrabajadores.Enabled = True
    End Sub

    Private Sub txtImporte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.ValueChanged
        oeMovimiento.Ingreso = txtImporte.Value
        oeMovimiento.Modificado = True
    End Sub

    Private Sub txtGlosa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGlosa.Click
        Me.griListaGlosa.Visible = True
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeMovimiento.Modificado = True
    End Sub

    Private Sub griListaGlosa_AfterCellActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaGlosa.AfterCellActivate
        Try
            If griListaGlosa.Rows.Count > 0 Then
                txtGlosa.Text = griListaGlosa.ActiveRow.Cells("Nombre").Value.ToString & " " & Me.cboTrabajadores.Text
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cbVerGlosa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbVerGlosa.CheckedChanged
        If cbVerGlosa.Checked Then
            expGlosa.Visible = cbVerGlosa.Checked
            expGlosa.Expanded = cbVerGlosa.Checked
        Else
            expGlosa.Expanded = False
            expGlosa.Visible = False
        End If
    End Sub

    Private Sub cboPilotoViaje_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPilotoViaje.ValueChanged
        Try
            Dim oeTemp As New e_CuentaCorriente
            With cboPilotoViaje
                If .SelectedIndex > -1 Then
                    Dim i As Integer = .SelectedIndex
                    'oetemp(Id, NombreCompleto) {e_Trabajador}
                    Dim otemp = .Items(i).ListObject
                    CargaComboViajePiloto(otemp.Id)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboViaje_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboViaje.ValueChanged
        Dim oeTemp As New e_Movimiento_Viaje
        etiRutaDetalle.Text = String.Empty
        etiEstadoAsociado.Text = String.Empty
        etiFechaAsociada.Text = String.Empty
        Dim asd As String = ""
        asd = cboViaje.Value
        With cboViaje
            If .SelectedIndex > -1 Then
                Dim i As Integer = .SelectedIndex
                oeTemp = .Items(i).ListObject
                etiRutaDetalle.Text = oeTemp.Ruta
                etiEstadoAsociado.Text = oeTemp.Estado
                etiFechaAsociada.Text = oeTemp.Fecha
                idViaje = oeTemp.IdViaje
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        End With
    End Sub

    Private Sub griDescuentos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDescuentos.BeforeRowsDeleted
        e.Cancel = True
    End Sub

#End Region

#Region "Combo Trabajador"

    Public Sub LlenaCombosTrabajadores()
        Try
            Dim loTrabajador As New List(Of e_Trabajador)
            oeSueldo = New e_SueldoTrabajador
            oeSueldo.TipoOperacion = ""
            oeSueldo.Activo = True
            oeSueldo.Vigente = 1
            leSueldo = olSueldo.Listar(oeSueldo)
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            loTrabajador.AddRange(olTrabajador.Listar(oeTrabajador).Where(Function(item) item.Activo = True))
            Dim _leTrabTemp = From le In loTrabajador _
                              Select le.Id, le.oePersona.NombreCompleto
            LlenarCombo(cboTrabajadores, "NombreCompleto", _leTrabTemp.OrderBy(Function(item) item.NombreCompleto).ToList, -1)
            LlenarCombo(cboPilotoViaje, "NombreCompleto", _leTrabTemp.OrderBy(Function(item) item.NombreCompleto).ToList, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenarCombos()
        oeParametro = New e_AporteDescuento
        oeParametro.TipoOperacion = ""
        oeParametro.Activo = True
        leParametro = olParametro.Listar(oeParametro)
        oeDetParametro = New e_DetalleAporteDescuento
        oeDetParametro.TipoOperacion = ""
        oeDetParametro.Activo = True
        oeDetParametro.Vigencia = 1
        leDetParametro = olDetParametro.Listar(oeDetParametro)
        oeFormula = New e_Formula
        oeFormula.TipoOperacion = ""
        oeFormula.Activo = True
        leFormula = olFormula.Listar(oeFormula)
    End Sub

    Private Function ObtieneAsigFam() As Double
        Try
            oeFormula = New e_Formula
            oeFormula.Equivale = 3
            oeFormula.Nombre = "AsignacionFamiliar"
            If leFormula.Contains(oeFormula) Then
                oeFormula = leFormula.Item(leFormula.IndexOf(oeFormula))
                Dim val As Double = 0
                Dim sCodigo As String
                Dim sDeclara As String
                sDeclara = fn_ObtieneConstantes(oeFormula)
                sCodigo = sDeclara & " " & Environment.NewLine & _
                            "Function " & oeFormula.Nombre & Environment.NewLine _
                                & oeFormula.Nombre & " = " & oeFormula.Instrucciones & Environment.NewLine _
                             & "End Function"
                Dim sc As New ScriptControl
                With sc
                    .Language = "VBScript"
                    .AllowUI = True
                    .AddCode(sCodigo)
                    val = .Run(oeFormula.Nombre)
                End With
                Return val
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fn_ObtieneConstantes(_oeForAux As e_Formula) As String
        Try
            Dim aDatos As String = ""
            Dim sPar As String() = Nothing
            If _oeForAux.Parametros.Trim <> "" Then
                sPar = _oeForAux.Parametros.Split(",")
                For x = 0 To sPar.Length - 1
                    oeParametro = New e_AporteDescuento
                    oeParametro.Abreviatura = sPar(x)
                    oeParametro.Equivale = 4
                    If leParametro.Contains(oeParametro) Then
                        oeParametro = leParametro.Item(leParametro.IndexOf(oeParametro))
                        oeDetParametro = New e_DetalleAporteDescuento
                        oeDetParametro.IdAporteDescuento = oeParametro.Id
                        oeDetParametro.Equivale = 2
                        If leDetParametro.Contains(oeDetParametro) Then
                            oeDetParametro = leDetParametro.Item(leDetParametro.IndexOf(oeDetParametro))
                            aDatos = aDatos & "Dim " & sPar(x) & Environment.NewLine & _
                                sPar(x) & " = " & oeDetParametro.MontoCalculo & Environment.NewLine
                        End If
                        oeDetParametro.Dispose()
                    End If
                    oeParametro.Dispose()
                Next
            End If
            Return aDatos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cboTrabajadores_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadores.Validated
        Dim oeMovimientoPersonal As New e_MovimientoPersonal
        If cboTrabajadores.SelectedIndex > -1 Then
            oeMovimientoPersonal.IdTrabajador = cboTrabajadores.Value
            Dim oeTrabajador As New e_Trabajador
            Dim olTrabajador As New l_Trabajador
            oeTrabajador.Id = oeMovimientoPersonal.IdTrabajador
            oeTrabajador.CargaCompleto = False
            oeTrabajador = olTrabajador.Obtener(oeTrabajador)
            'If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then FotoTrabajador.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
            FotoTrabajador.Visible = True
            agrDatosBasicos.Visible = True
            txtArea.Text = oeTrabajador.oeArea.Nombre
            txtCargo.Text = oeTrabajador.oeCargo.Nombre
            fecFechaIngreso.Value = oeTrabajador.FechaIngreso
            ndSueldo.Value = 0.0
            ndAsigFam.Value = 0.0
            ndRenumeracion.Value = 0.0
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "VISUALIZAR SUELDOS") Then
                For Each sueldo As e_SueldoTrabajador In leSueldo
                    If sueldo.IdTrabajador = oeTrabajador.Id Then
                        ndSueldo.Value = sueldo.Sueldo
                    End If
                Next
                If oeTrabajador.IndHijo Then
                    ndAsigFam.Value = ObtieneAsigFam()
                End If
                chkDisponible.Checked = oeTrabajador.Disponible
                ndRenumeracion.Value = ndSueldo.Value + ndAsigFam.Value
            Else
                ndSueldo.Value = 0
                ndAsigFam.Value = 0
                ndRenumeracion.Value = 0
            End If
            If oeTrabajador.Disponible Then
                chkDisponible.BackColor = Color.Transparent
                chkDisponible.ForeColor = Color.Black
                chkDisponible.Text = "Disponible"
            Else
                chkDisponible.BackColor = Color.Red
                chkDisponible.ForeColor = Color.Yellow
                chkDisponible.Text = "Trabajador NO Disponible"
            End If
            oeMovimiento.Modificado = True
        End If
    End Sub

    Private Sub cboConceptos_ValueChanged(sender As Object, e As EventArgs) Handles cboConceptos.ValueChanged
        Me.numCuotas.Value = 0
        If cboConceptos.Text = "PRESTAMOS" Then
            Me.Etiqueta10.Visible = True
            Me.numCuotas.Visible = True
        ElseIf cboConceptos.Text = "SANCIONES" Then
            Me.Etiqueta10.Visible = True
            Me.numCuotas.Visible = True
        Else
            Me.Etiqueta10.Visible = False
            Me.numCuotas.Visible = False
        End If
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        If Me.griDescuentos.Rows.Count > 0 Then
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EXTORNO") Then
                MenuContextual1.Items("ExtornarToolStripMenuItem").Visible = True
            Else
                MenuContextual1.Items("ExtornarToolStripMenuItem").Visible = False
            End If
        Else
            MenuContextual1.Items("ExtornarToolStripMenuItem").Visible = False
        End If
    End Sub

    Private Sub ExtornarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtornarToolStripMenuItem.Click
        Extornar()
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

#End Region

End Class
