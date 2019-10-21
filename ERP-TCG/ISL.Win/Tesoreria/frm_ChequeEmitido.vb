'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading

Public Class frm_ChequeEmitido
    Inherits frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ChequeEmitido = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ChequeEmitido()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private WithEvents oeChequeEmitido As New e_ChequeEmitido
    Private olChequeEmitido As New l_ChequeEmitido

    Private oeCuentaCorriente As New e_CuentaCorriente
    Private olCuentaCorriente As New l_CuentaCorriente
    Private loCuentaCorriente As New List(Of e_CuentaCorriente)

    Private oeCentro As New e_Centro
    Private olCentro As New l_Centro

    Private oeChequeControl As New e_ChequesControl
    Private olChequeControl As New l_ChequesControl

    Private oeChequesTalonarios As New e_ChequesTalonarios
    Private olChequesTalonarios As New l_ChequesTalonarios

    Private oeCajaUsuario As New e_CajaUsuario
    Private olCajaUsuario As New l_CajaUsuario

    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor
    Dim loProveedor As New List(Of e_Proveedor)

    Private loCtaBancaria As New List(Of e_CuentaBancaria)
    Private loCtaCtble_Concepto As New List(Of e_CtaCtble_Concepto)

    Private oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento

    Private oeChequeDocumento As e_ChequeDocumento
    Private olChequeDocumento As l_ChequeDocumento
    Private loChequeDocumento As List(Of e_ChequeDocumento)

    Private _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            MostrarTabs(1, ficChequesPendientes, 1)
            Inicializar()
            ActivarBotones(True)
            cboProveedores.Focus()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
            ActivarBotones(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            Operacion = "Editar"
            If Me.griListaChequesPendientes.ActiveRow.Cells("Estado").Value.ToString = "APROBADA" Or Me.griListaChequesPendientes.ActiveRow.Cells("Estado").Value.ToString = "COBRADO" Then
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                MostrarTabs(1, ficChequesPendientes, 1)
                ActivarBotones(True)
                Mostrar()
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If ValidaUsuarioCajaCentro(oeCajaUsuario.IdCaja, ObtenerCentro.Id, gUsuarioSGI.IdTrabajador) Then
                Select Case ficChequesPendientes.SelectedTab.Index
                    Case 1
                        If GuardarCheque() Then
                            MostrarTabs(0, ficChequesPendientes, 0)
                            Listar()
                        Else
                            MostrarTabs(1, ficChequesPendientes, 1)
                        End If
                End Select
            Else
                Throw New Exception("No puede Realizar Movimientos en esta Sede")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeChequeEmitido.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarCheque() Then
                            MostrarTabs(0, ficChequesPendientes, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficChequesPendientes, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficChequesPendientes, 2)
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficChequesPendientes)
                _ingresando_datos = False
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficChequesPendientes.Tabs(0).Selected AndAlso griListaChequesPendientes.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficChequesPendientes.Tabs(0).Selected Then Exportar_Excel(griListaChequesPendientes)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Dim id As String = ""
        Try
            Dim formulario As New frm_ImprimirChequesEmitidos
            If griListaChequesPendientes.Selected.Rows.Count > 0 And griListaChequesPendientes.ActiveRow.Selected = True And griListaChequesPendientes.ActiveRow.Band.Index = 0 Then
                If ficChequesPendientes.SelectedTab.Index = 0 Then
                    id = griListaChequesPendientes.ActiveRow.Cells("Id").Value
                    formulario.CargarDatos(id)
                    formulario.ShowDialog()
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    id = oeChequeEmitido.Id
                    formulario.CargarDatos(id)
                    formulario.ShowDialog()
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            Dim a As String = ""
            a = griListaChequesPendientes.ActiveRow.Cells("Estado").Value
            If a <> "COBRADO" Then
                If a <> "ANULADO" Then
                    Select Case MessageBox.Show("Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        Case Windows.Forms.DialogResult.Yes
                            EliminarCheque()
                    End Select
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ChequeEmitido_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            Select Case ficChequesPendientes.SelectedTab.Index
                Case 0
                    If griListaChequesPendientes.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case 1
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
            End Select
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub frm_ChequeEmitido_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ChequeEmitido_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ChequeEmitido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            gf_AsignarEventoSeleccionarTexto(Me)
            CargarCuentaBancaria()
            LlenaCombosTrabajadores()
            LlenaProveedores()
            CargarConceptos()
            ListarCuentaCorriente()
            LlenaComboCentro()
            BuscarUsuarioCaja()
            CargarTipoDocumento()
            fecDesde.Value = Date.Now.AddDays(-20)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ChequeEmitido_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub btnEvaluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click
        Try
            If griListaChequesPendientes.ActiveRow.Selected Then
                Operacion = "Evaluar"
                MostrarTabs(1, ficChequesPendientes, 1)
                ActivarBotones(False)
                Mostrar()
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobrar.Click
        Try
            Operacion = "Cobrar"
            MostrarTabs(1, ficChequesPendientes, 1)
            ActivarBotones(False)
            Mostrar()
            Agrupacion4.Enabled = True
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Try
            Operacion = "Anular"
            MostrarTabs(1, ficChequesPendientes, 1)
            ActivarBotones(False)
            Mostrar()
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnNuevoProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoProveedor.Click
        Dim Formulario As New frm_Proveedor
        Formulario.RegistroProveedor = "TES"
        Formulario.ShowDialog()
        If Formulario.RegistroProveedor <> "TES" Then
            LlenaProveedores()
        End If
        Formulario.Dispose()
        Formulario.Close()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub txtNroCheque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroCheque.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtNroCheque_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroCheque.ValueChanged
        oeChequeEmitido.NroCheque = txtNroCheque.Value
    End Sub

    Private Sub cboConcepto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.ValueChanged
        oeChequeEmitido.IdConcepto = cboConcepto.Value
        If cboConcepto.Value = "1SI000000018" Then
            Agrupacion6.Visible = True
        Else
            Agrupacion6.Visible = False
        End If
    End Sub

    Private Sub numMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numMonto.ValueChanged
        oeChequeEmitido.Importe = numMonto.Value
        oeChequeEmitido.Saldo = numMonto.Value
    End Sub

    Private Sub rdbCtaAdm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCtaAdm.CheckedChanged
        Try
            If rdbCtaAdm.Checked Then
                oeChequeEmitido.IdCuentaCorriente = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
                oeChequeEmitido.IdProveedor = ""
                oeChequeEmitido.IdEstado = "1CH00031"
                If ObtenerCentro.Id <> "1CH001" Then
                    cboConcepto.Value = "1SI000000017"
                    cboConcepto.Enabled = False
                End If
                cboTrabajadores.Enabled = False
            Else
                cboTrabajadores.Enabled = True
                oeChequeEmitido.IdCuentaCorriente = ""
                oeChequeEmitido.IdEstado = ""
                If ObtenerCentro.Id <> "1CH001" Then
                    cboConcepto.SelectedIndex = -1
                    cboConcepto.Enabled = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub chkCtaAdm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCtaAdm.CheckedChanged
        If chkCtaAdm.Checked Then
            rbtCtaTrabajador.Enabled = True
            rbtCtaTrabajador.Checked = True
            rdbCtaAdm.Enabled = True
            cboProveedores.Enabled = 0
            btnNuevoProveedor.Enabled = 0
            cboTrabajadores.Enabled = 1
        Else
            cboProveedores.Enabled = 1
            btnNuevoProveedor.Enabled = 1
            rbtCtaTrabajador.Enabled = False
            rbtCtaTrabajador.Checked = False
            rdbCtaAdm.Enabled = False
            cboTrabajadores.Enabled = 0
        End If
    End Sub

    Private Sub txtDescripcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.ValueChanged
        oeChequeEmitido.Detalle = txtDescripcion.Value
    End Sub

    Private Sub griListaChequesPendientes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaChequesPendientes.DoubleClick
        If griListaChequesPendientes.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griListaChequesPendientes_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaChequesPendientes.AfterRowActivate
        Try
            ControlarEstadoOrden()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtNroCheque_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroCheque.Validated
        txtNroCheque.Text = FormatoDocumento(txtNroCheque.Text, 8)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            btnEliminar.PerformClick()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griListaChequesPendientes_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaChequesPendientes.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCuentaBancaria_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaBancaria.Validated
        Try
            CargaNumeroCheque()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscarDocumento_Click(sender As Object, e As EventArgs) Handles btnBuscarDocumento.Click
        Try
            If Not ValidarBusquedaDocumento() Then
                Throw New Exception
            Else
                ListarDocumento()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDocumentoCompra_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griListaDocumentoCompra.DoubleClickRow
        Try
            With Me.griListaDocumentoCompra
                If .Rows.Count > 0 Then
                    CargarDocumento(.ActiveRow.Cells("Id").Value, 1)
                End If
            End With
            Me.expDocumento.Expanded = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerieDoc_GotFocus(sender As Object, e As EventArgs) Handles txtSerieDoc.GotFocus
        Me.txtSerieDoc.SelectAll()
        txtSerieDoc.Select(0, 4)
    End Sub

    Private Sub txtSerieDoc_Enter(sender As Object, e As EventArgs) Handles txtSerieDoc.Enter
        txtSerieDoc.Select(0, 4)
        Me.txtSerieDoc.SelectAll()
    End Sub

    Private Sub txtSerieDoc_Validated(sender As Object, e As EventArgs) Handles txtSerieDoc.Validated
        txtSerieDoc.Text = FormatoDocumento(txtSerieDoc.Text, 4)
    End Sub

    Private Sub txtNumeroDoc_GotFocus(sender As Object, e As EventArgs) Handles txtNumeroDoc.GotFocus
        Me.txtNumeroDoc.SelectAll()
        txtNumeroDoc.Select(0, 10)
    End Sub

    Private Sub txtNumeroDoc_Validated(sender As Object, e As EventArgs) Handles txtNumeroDoc.Validated
        txtNumeroDoc.Text = FormatoDocumento(txtNumeroDoc.Text, 10)
    End Sub

    Private Sub txtNumeroDoc_Enter(sender As Object, e As EventArgs) Handles txtNumeroDoc.Enter
        txtNumeroDoc.Select(0, 10)
        Me.txtNumeroDoc.SelectAll()
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCuentaBancaria()
        Try
            Dim oeCtaCte As New e_CuentaBancaria
            Dim olCtaCte As New l_CuentaBancaria
            oeCtaCte.Activo = 1
            loCtaBancaria.AddRange(olCtaCte.Listar(oeCtaCte))
            LlenarCombo(cboCuentaBancaria, "BancoCuenta", loCtaBancaria, -1)
        Catch ex As Exception
            Throw ex
        End Try
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

    Private Sub LlenaProveedores()
        Try
            oeProveedor = New e_Proveedor
            oeProveedor.TipoOperacion = "5"
            cboProveedores.Value = Nothing
            loProveedor = New List(Of e_Proveedor)
            loProveedor.AddRange(olProveedor.Listar(oeProveedor))
            With cboProveedores
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = loProveedor
            End With
            InicializarComboProveedor()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InicializarComboProveedor()
        Try
            Me.cboProveedores.ValueMember = "Id"
            Me.cboProveedores.DisplayMember = "Nombre"
            With cboProveedores.DisplayLayout.Bands(0)
                '.Columns("Id").Hidden = True
                .Columns("Codigo").Hidden = True
                .Columns("TipoPersonaEmpresa").Hidden = True
                .Columns("IdPersona").Hidden = True
                .Columns("IdEmpresa").Hidden = True
                .Columns("FechaActividad").Hidden = True
                .Columns("UsuarioCreacion").Hidden = True
                .Columns("Activo").Hidden = True
                .Columns("Seleccion").Hidden = True
                .Columns("Email").Hidden = True
                .Columns("Contacto").Hidden = True
                .Columns("NroDocumento").Header.Caption = "RUC/DNI"
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function BuscarIdTrabajador(ByVal idCuenta As String) As String
        Try
            Dim IdTrab As String = ""
            For Each Lista As e_CuentaCorriente In loCuentaCorriente
                If Lista.Id = idCuenta Then
                    IdTrab = Lista.IdTrabajador
                    Return IdTrab
                End If
            Next
            Return IdTrab
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Inicializar()
        Try
            oeChequeEmitido = New e_ChequeEmitido
            oeChequeEmitido.TipoOperacion = "I"
            Me.cboTrabajadores.SelectedIndex = -1
            rdbCtaAdm.Checked = False
            rbtCtaTrabajador.Checked = False
            cboProveedores.Value = Nothing
            Me.cboConcepto.SelectedIndex = -1
            Me.cboCuentaBancaria.SelectedIndex = -1
            Me.txtNroCheque.Value = String.Empty
            Me.numMonto.Value = 0.0
            Me.fecFechaEmision.Value = Date.Now
            Me.txtDescripcion.Value = String.Empty
            Me.chkCtaAdm.Checked = False
            Me.Agrupacion6.Visible = False
            Me.expDocumento.Expanded = False
            loChequeDocumento = New List(Of e_ChequeDocumento)
            gridDocumentosAsociados.DataSource = loChequeDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ActivarBotones(ByVal Activo As Boolean)
        Me.Agrupacion3.Enabled = Activo
        Me.Agrupacion4.Enabled = Activo
    End Sub

    Private Sub Mostrar()
        Try
            Inicializar()
            oeChequeEmitido.Id = griListaChequesPendientes.ActiveRow.Cells("Id").Value
            oeChequeEmitido.Fecha = Date.Parse("01/01/1901")
            oeChequeEmitido.FechaCreacion = Date.Parse("01/01/1901")
            oeChequeEmitido.TipoOperacion = "1"
            oeChequeEmitido = olChequeEmitido.Obtener(oeChequeEmitido)
            If oeChequeEmitido.IdProveedor.Trim <> "" Then
                cboProveedores.Value = oeChequeEmitido.IdProveedor
            Else
                chkCtaAdm.Checked = True
                cboTrabajadores.Value = BuscarIdTrabajador(oeChequeEmitido.IdCuentaCorriente)
            End If
            numMonto.Value = oeChequeEmitido.Importe
            cboConcepto.Value = oeChequeEmitido.IdConcepto
            cboCuentaBancaria.Value = oeChequeEmitido.IdCuentaBancaria
            txtDescripcion.Value = oeChequeEmitido.Detalle
            txtNroCheque.Value = oeChequeEmitido.NroCheque
            fecFechaEmision.Value = oeChequeEmitido.Fecha
            fecFechaCobro.Value = oeChequeEmitido.FechaCobro
            If oeChequeEmitido.IdConcepto = "1SI000000018" Then CargarDocumento(oeChequeEmitido.Id, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeChequeEmitido = New e_ChequeEmitido
            With oeChequeEmitido
                .Fecha = fecDesde.Value
                .FechaCreacion = fecHasta.Value
                .TipoOperacion = ""
                If cboCentroL.SelectedIndex <> 0 Then
                    .IdCentro = cboCentroL.Value
                Else
                    .IdCentro = ""
                End If
                griListaChequesPendientes.DataSource = olChequeEmitido.Listar(oeChequeEmitido)
                If griListaChequesPendientes.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
                FormatoColorGrilla(griListaChequesPendientes)
                End With
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Function GuardarCheque() As Boolean
        Try
            Dim oeCtaBancaria As New e_CuentaBancaria
            Dim loCtaCtble As New List(Of e_Combo)
            Dim FechaActual As Date = ObtenerFechaServidor()
            If FechaActual.Date < fecFechaEmision.Value.Date Then
                Throw New Exception("La fecha de emisión no debe superar fecha actual.")
            End If
            LlenaObjeto()

            oeCtaBancaria.Id = cboCuentaBancaria.Value
            For Each ctaban As e_CuentaBancaria In loCtaBancaria
                If oeCtaBancaria.Id = ctaban.Id Then
                    oeCtaBancaria = ctaban
                End If
            Next
            With oeChequeEmitido
                .loAsientoModelo = New List(Of e_AsientoModelo)
                .IdCuentaBancaria = oeCtaBancaria.Id
                .IdMoneda = oeCtaBancaria.IdMoneda
                .Concepto = cboConcepto.Text
                If .IdConcepto = "1SI000000018" And loChequeDocumento.Count = 0 Then
                    Throw New Exception("Debe Asociar un Documento para el Pago a Proveedores")
                Else
                    .loChequeDocumento = loChequeDocumento
                End If
                If Operacion = "Nuevo" Then
                    .TipoOperacion = "I"
                    .Fecha = fecFechaEmision.Value
                    .FechaCobro = fecFechaCobro.Value
                    .FechaCreacion = Date.Now
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .IdCentro = ObtenerCentro.Id
                    If .IdEstado = "" Then .IdEstado = "1CH00008"
                ElseIf Operacion = "Editar" Then
                    .TipoOperacion = "A"
                    .Fecha = fecFechaEmision.Value
                    If .IdEstado = "" Then .IdEstado = "1CH00008"
                ElseIf Operacion = "Evaluar" Then
                    .TipoOperacion = "V"
                    .IdEstado = "1CH00031"
                ElseIf Operacion = "Cobrar" Then
                    .TipoOperacion = "C"
                    .TipoCambio = TipoCambio(fecFechaCobro.Value, True)(0)
                    .FechaCobro = fecFechaCobro.Value
                    .IdEstado = "1CH00032"
                    .oePeriodo = New e_Periodo
                    Dim olPeriodo As New l_Periodo

                    .oePeriodo.Ejercicio = FechaActual.Year
                    .oePeriodo.Mes = FechaActual.Month
                    .oePeriodo = olPeriodo.Obtener(.oePeriodo)
                    loCtaCtble_Concepto = New List(Of e_CtaCtble_Concepto)
                    CargarCuentaConcepto(.IdConcepto, .IdMoneda, .oePeriodo.Ejercicio)
                    If loCtaCtble_Concepto.Count > 0 Then
                        loCtaCtble.AddRange(CtaCtblePublic)
                    End If
                ElseIf Operacion = "Anular" Then
                    .TipoOperacion = "N"
                    .IdEstado = "1CH00001"
                End If
                .IdTrabajador = gUsuarioSGI.IdTrabajador
            End With
            oeChequeEmitido.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olChequeEmitido.Guardar(oeChequeEmitido, loCtaCtble_Concepto, CtaCtblePublic) Then
                If oeChequeEmitido.TipoOperacion = "I" Then
                    Dim frm As New frm_ImprimirChequesEmitidos
                    frm.CargarDatos(oeChequeEmitido.Id)
                    frm.ShowDialog()
                End If
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Return True
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarConceptos()
        Try
            Dim loConceptosIngresos As New List(Of e_ConceptoIngresos)
            Dim oeConceptoIngresos As New e_ConceptoIngresos
            Dim olConceptoIngresos As New l_ConceptoIngresos
            oeConceptoIngresos.IdProcesoNegocio = "1CH000000003"
            loConceptosIngresos.AddRange(olConceptoIngresos.Listar(oeConceptoIngresos))
            LlenarCombo(cboConcepto, "Nombre", loConceptosIngresos, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub LlenaObjeto()
        Try
            With oeChequeEmitido
                Select Case Operacion
                    Case "Nuevo", "Editar"
                        If chkCtaAdm.Checked Then
                            .IdProveedor = ""
                            If Not rdbCtaAdm.Checked Then
                                .IdCuentaCorriente = BuscarIdCtaCte(cboTrabajadores.Value, 0, loCuentaCorriente)
                                If .IdCuentaCorriente = "" Then Throw New Exception("Trabajador sin Cta. Corriente. Verificar")
                            End If
                        Else
                            .IdCuentaCorriente = ""
                            Dim oepro As New e_Proveedor
                            oepro.Id = cboProveedores.Value
                            If loProveedor.Contains(oepro) Then
                                .IdProveedor = oepro.Id
                            Else
                                Throw New Exception("Seleccione Proveedor Correctamente.")
                            End If
                        End If
                End Select
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCuentaConcepto(IdConcepto As String, IdMoneda As String, Ejercicio As Double)
        Try
            Dim oeCtaCtbleConcepto As New e_CtaCtble_Concepto
            Dim olCtaCtbleConcepto As New l_CtaCtble_Concepto
            oeCtaCtbleConcepto.IdConceptoIngresos = IdConcepto
            oeCtaCtbleConcepto.IdMoneda = IdMoneda
            oeCtaCtbleConcepto.Ejercicio = Ejercicio
            loCtaCtble_Concepto.AddRange(olCtaCtbleConcepto.Listar(oeCtaCtbleConcepto))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FormatoColorGrilla(ByVal grilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        Try
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grilla.Rows
                Select Case fila.Cells("Estado").Value
                    Case gNombreEstadoEmitida
                        fila.CellAppearance.BackColor = Me.ColorEmitido.Color
                    Case gNombreEstadoAprobada
                        fila.CellAppearance.BackColor = Me.ColoresAprobado.Color
                    Case gNombreEstadoCobrado
                        fila.CellAppearance.BackColor = Me.ColorCobrado.Color
                    Case gNombreEstadoAnulado
                        fila.CellAppearance.BackColor = Me.ColorAnulado.Color
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EliminarCheque()
        Try
            oeChequeEmitido = New e_ChequeEmitido
            oeChequeEmitido.Id = griListaChequesPendientes.ActiveRow.Cells("id").Value
            oeChequeEmitido.IdTrabajador = gUsuarioSGI.IdTrabajador
            If olChequeEmitido.Eliminar(oeChequeEmitido) Then
                mensajeEmergente.Confirmacion("La Informacion se ha Eliminado Correctamente" & Me.Text, True)
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub ControlarEstadoOrden()
        Try
            btnAnular.Enabled = False
            btnCobrar.Enabled = False
            btnAprobar.Enabled = False
            btnEliminar.Enabled = False
            If griListaChequesPendientes.ActiveRow.Band.Index = 0 Then
                If griListaChequesPendientes.ActiveRow.Index > -1 Then
                    Select Case griListaChequesPendientes.ActiveRow.Cells("Estado").Value
                        Case gNombreEstadoEmitida
                            If PermisoEvaluacion() Then
                                btnAprobar.Enabled = True
                                btnAnular.Enabled = True
                            End If
                            btnEliminar.Enabled = True
                        Case gNombreEstadoAprobada
                            btnCobrar.Enabled = True
                            btnAnular.Enabled = True
                            btnEliminar.Enabled = True
                    End Select
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Function PermisoEvaluacion() As Boolean
        Return True
    End Function

    Private Sub LlenaComboCentro()
        Try
            Dim oe As New e_Centro
            Dim leCentro As New List(Of e_Centro)
            oe.Id = ""
            oe.Nombre = "TODOS"
            leCentro.Add(oe)
            leCentro.AddRange(olCentro.Listar(oeCentro))
            LlenarCombo(cboCentroL, "Nombre", leCentro, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaNumeroCheque()
        Try
            oeChequeControl = New e_ChequesControl
            oeChequesTalonarios = New e_ChequesTalonarios
            oeChequeControl.IdCuentaBancaria = cboCuentaBancaria.Value
            oeChequeControl.TipoOperacion = "2"
            oeChequeControl = olChequeControl.Obtener(oeChequeControl)
            If oeChequeControl.Id <> "" Then
                oeChequesTalonarios.TipoOperacion = "2"
                oeChequesTalonarios.IdChequesControl = oeChequeControl.Id
                oeChequesTalonarios.IdResponsable = gUsuarioSGI.IdTrabajador
                oeChequesTalonarios = olChequesTalonarios.Obtener(oeChequesTalonarios)
                If oeChequesTalonarios.Id <> "" Then
                    Me.txtNroCheque.Text = oeChequesTalonarios.Correlativo
                Else
                    Me.txtNroCheque.Text = ""
                    Throw New Exception("Chequera No Asignada, Terminada y/o Anulada. No Puede Crear Cheques")
                End If
            Else
                Me.txtNroCheque.Text = ""
                Throw New Exception("Talonario de Cheques del Banco no Registrado en el Sistema. Verificar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BuscarUsuarioCaja()
        Try
            oeCajaUsuario = New e_CajaUsuario
            oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
            If oeCajaUsuario.Id <> "" Then
                cboCentroL.Value = oeCajaUsuario.IdCentro
                If oeCajaUsuario.IdCentro = "1CH001" Then
                    cboCentroL.Enabled = True
                Else
                    cboCentroL.Enabled = False
                End If
            Else
                mensajeEmergente.Problema("Usuario no Asignado a Caja", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function ValidarBusquedaDocumento() As Boolean
        Try
            If Me.cboDocumentoAlmacen.SelectedIndex = -1 Then
                mensajeEmergente.Problema("Seleccione Tipo de Documento Por Favor")
                Me.txtNumeroDoc.Focus()
                Return False
            ElseIf Me.txtNumeroDoc.Text = "" Then
                mensajeEmergente.Problema("Escriba el Numero de Documento Por Favor")
                Me.txtNumeroDoc.Focus()
                Return False
            ElseIf Me.txtSerieDoc.Text = "" Then
                mensajeEmergente.Problema("Escriba el Numero de Serie Por Favor")
                Me.txtNumeroDoc.Focus()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ListarDocumento()
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim oeMovDoc As New e_MovimientoDocumento
            With oeMovDoc
                .Serie = txtSerieDoc.Value : .Numero = txtNumeroDoc.Value
                .Serie = FormatoDocumento(.Serie.Trim, 4) : .Numero = FormatoDocumento(.Numero.Trim, 10)
                .TipoOperacion = "MOV"
                .IdTipoDocumento = cboDocumentoAlmacen.Value
            End With
            With griListaDocumentoCompra
                .DataSource = olMovimientoDocumento.ListarDocumentosPorCompras(oeMovDoc)
                .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndServicioMaterial").Hidden = True
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            End With
            With griListaDocumentoCompra
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarTipoDocumento()
        Try
            Dim oeTipoDoc As New e_TipoDocumento
            Dim olTipoDoc As New l_TipoDocumento
            Dim loTipoDoc As New List(Of e_TipoDocumento)
            oeTipoDoc.TipoOperacion = "S"
            loTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
            LlenarCombo(cboDocumentoAlmacen, "Nombre", loTipoDoc, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarDocumento(Id As String, Tipo As Integer)
        Try
            If Tipo = 1 Then
                oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento.Id = Id
                oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                If loChequeDocumento.Where(Function(i) i.IdMovimientoDocumento = oeMovimientoDocumento.Id).Count > 0 Then
                    Throw New Exception("El Documento: " + oeMovimientoDocumento.Serie + oeMovimientoDocumento.Numero + " ya ha Sido Agregado")
                End If
                oeChequeDocumento = New e_ChequeDocumento
                With oeChequeDocumento
                    .IdMovimientoDocumento = oeMovimientoDocumento.Id
                    .Documento = oeMovimientoDocumento.NombreDocumento
                    .Proveedor = oeMovimientoDocumento.NombreProveedor
                    .Importe = oeMovimientoDocumento.Saldo
                    .Moneda = oeMovimientoDocumento.Moneda
                    .UsuarioCreacion = .UsuarioCreacion
                End With
                loChequeDocumento.Add(oeChequeDocumento)
                numMonto.Value = Math.Round(numMonto.Value + oeMovimientoDocumento.Saldo, 2)
            Else
                oeChequeDocumento = New e_ChequeDocumento
                olChequeDocumento = New l_ChequeDocumento
                oeChequeDocumento.IdChequeEmitido = Id
                loChequeDocumento = olChequeDocumento.Listar(oeChequeDocumento)
            End If          
            gridDocumentosAsociados.DataSource = loChequeDocumento
            gridDocumentosAsociados.DataBind()
            CalcularTotales(gridDocumentosAsociados, "Importe")
            ' Me.numMonto.Value = Math.Round(Me.numMonto.Value + oeMovimientoDocumento.Saldo, 2)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        Try
            MenuContextual1.Items("NuevoToolStripMenuItem").Visible = True
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EvaluarToolStripMenuItem").Visible = False
            MenuContextual1.Items("CobrarToolStripMenuItem").Visible = False
            MenuContextual1.Items("AnularToolStripMenuItem").Visible = False
            If griListaChequesPendientes.Rows.Count > 0 Then
                If griListaChequesPendientes.ActiveRow.Cells("Estado").Value = gNombreEstadoEmitida Then
                    MenuContextual1.Items("EditarToolStripMenuItem").Visible = True
                    MenuContextual1.Items("EvaluarToolStripMenuItem").Visible = True
                    MenuContextual1.Items("AnularToolStripMenuItem").Visible = True
                    MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
                ElseIf griListaChequesPendientes.ActiveRow.Cells("Estado").Value = gNombreEstadoAprobada Then
                    MenuContextual1.Items("CobrarToolStripMenuItem").Visible = True
                    MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EvaluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvaluarToolStripMenuItem.Click
        btnAprobar.PerformClick()
    End Sub

    Private Sub CobrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CobrarToolStripMenuItem.Click
        btnCobrar.PerformClick()
    End Sub

    Private Sub AnularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularToolStripMenuItem.Click
        btnAnular.PerformClick()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Eliminar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Combo Trabajador"

    Public Sub LlenaCombosTrabajadores()
        Try
            Dim loTrabajador As New List(Of e_Trabajador)
            Dim oeTrabajador As New e_Trabajador
            Dim olTrabajador As New l_Trabajador
            oeTrabajador.TipoOperacion = ""
            loTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))
            Dim _leTrabAux = From le In loTrabajador Select le.Id, le.oePersona.NombreCompleto
            LlenarCombo(cboTrabajadores, "NombreCompleto", _leTrabAux.ToList, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTrabajadores_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboTrabajadores.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            LlenaCombosTrabajadores()
            ListarCuentaCorriente()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

End Class