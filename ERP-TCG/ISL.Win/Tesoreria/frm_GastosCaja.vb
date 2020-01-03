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

Public Class frm_GastosCaja
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_GastosCaja = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_GastosCaja()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeGastoOpe As e_GastoOperacion
    Private olGastoOpe As l_GastoOperacion
    Private loGastoOpe As List(Of e_GastoOperacion)

    Private oeTipoGasto As e_TipoGasto
    Private olTipoGasto As l_TipoGasto

    Private oeFlujoGasto As e_TipoGastoDetalle
    Private olFlujoGasto As l_TipoGastoDetalle
    Private loFlujoGasto As List(Of e_TipoGastoDetalle)

    Private oeTipoDoc As e_TipoDocumento
    Private olTipoDoc As l_TipoDocumento
    Private loTipoDoc As List(Of e_TipoDocumento)

    Private oeFlujoCajaConta, oeFlujoCaja As e_FlujoCaja
    Private olFlujoCajaConta, olFlujoCaja As l_FlujoCaja
    Private loFlujoCajaConta, loFlujoCaja, loFlujoCuenta As List(Of e_FlujoCaja)

    Private oeFlujoPlaca As e_ProcesoFlujoCaja
    Private olFlujoPlaca As l_ProcesoFlujoCaja
    Private loFlujoPlaca As List(Of e_ProcesoFlujoCaja)

    Private oeCajaUsuario As e_CajaUsuario
    Private olCajaUsuario As l_CajaUsuario
    Private loCajaUsuario As List(Of e_CajaUsuario)

    Private oeCaja As e_Caja
    Private olCaja As l_Caja
    Private loCaja As List(Of e_Caja)

    Private oeCtaCte As e_CuentaCorriente
    Private olCtaCte As l_CuentaCorriente
    Private loCtaCte As List(Of e_CuentaCorriente)

    Private oeProveedor As e_Proveedor
    Private loProveedor As List(Of e_Proveedor)
    Private olProveedor As l_Proveedor

    Private oePeriodo, oePerGrupo As e_Periodo
    Private olPeriodo As l_Periodo

    Private oeMoneda As e_Moneda
    Private olMoneda As l_Moneda

    Private olFuncion As l_FuncionesGenerales

    Private oeEmpresa As e_Empresa
    Private olEmpresa As l_Empresa

    Private oeCcpp As e_CCPP
    Private olCcpp As l_CCPP

    Private oeDireccion As e_Direccion
    Private olDireccion As l_Direccion

    Private oeMaterial As e_Material
    Private olMaterial As l_Material

    Private Id As Integer = 0
    Private idCajaCentro As String = ""
    Private IndicadorIGV As Boolean = False
    Private IdDocumentoAlmacen As String = ""
    Private IndCompraAlmacen As Boolean = False

    Private lenSerie As Integer = 0, lenNumero As Integer = 0
    Private mb_Load As Boolean = False

    'Concepto
    Private oeConcepto As New e_Concepto
    Private olConcepto As New l_Concepto
    Private loConcepto As New List(Of e_Concepto)

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            MostrarTabs(1, ficGastosCaja, 1)
            LimpiarControles(True)
            Inicializar()
            CargarGrupo()
            cboGrupo.Focus()
            ControlBotones()
            ListarGastos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar()
            Tiempo1.Enabled = True
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Validar_ExistenciaComprobante(Optional _ban As Boolean = True)
        Try
            Dim oeMovDocAUx As New e_MovimientoDocumento
            Dim olMovimientoDocumento As New l_MovimientoDocumento
            Dim lst_MovDocAUx As New List(Of e_MovimientoDocumento)
            Dim oeGastoAux As New e_GastoOperacion
            Dim olGastoAux As New l_GastoOperacion
            Dim lst_GastoAux As New List(Of e_GastoOperacion)
            If _ban Then
                oeMovDocAUx.IdTipoDocumento = cboTipoDocumento.Value
                oeMovDocAUx.Serie = txtSerie.Value
                oeMovDocAUx.Numero = CStr(CType(txtNumero.Value, Int64))
                oeMovDocAUx.IdClienteProveedor = cboProveedores.Value
                oeMovDocAUx.TipoOperacion = "VDC"
                oeMovDocAUx.IndCompraVenta = "1"
                lst_MovDocAUx = olMovimientoDocumento.Listar(oeMovDocAUx)
                If lst_MovDocAUx.Count > 0 Then Throw New Exception("El comprobante " & txtSerie.Value & "-" & txtNumero.Value & " de " & cboProveedores.Text & " ya ha sido registrado.")
            Else
                Dim msj As String = String.Empty
                Dim cont As Integer = 0
                For Each gasto In loGastoOpe
                    If gasto.TipoOperacion = "I" Then
                        If Not gasto.IdDocumento Is String.Empty Then
                            oeGastoAux = New e_GastoOperacion
                            oeGastoAux.IdDocumento = gasto.IdDocumento
                            oeGastoAux.TipoOperacion = "1"
                            oeGastoAux.Activo = "1"
                            olGastoAux = New l_GastoOperacion
                            lst_GastoAux = olGastoAux.Listar(oeGastoAux)
                            If lst_GastoAux.Count > 0 Then
                                oeMovDocAUx = New e_MovimientoDocumento
                                olMovimientoDocumento = New l_MovimientoDocumento
                                oeMovDocAUx.Id = gasto.IdDocumento
                                oeMovDocAUx = olMovimientoDocumento.Obtener(oeMovDocAUx)
                                If Math.Round(oeMovDocAUx.Saldo, 2) < gasto.Total Then
                                    cont += 1
                                    msj &= gasto.SerieDoc & "-" & gasto.NroDoc & " de " & gasto.Proveedor & vbCrLf
                                End If
                            End If
                        Else
                            oeMovDocAUx = New e_MovimientoDocumento
                            olMovimientoDocumento = New l_MovimientoDocumento
                            oeMovDocAUx.IdTipoDocumento = gasto.IdTipoDocumento
                            oeMovDocAUx.Serie = gasto.SerieDoc
                            oeMovDocAUx.Numero = CStr(CType(gasto.NroDoc, Int64))
                            oeMovDocAUx.IdClienteProveedor = gasto.IdProveedor
                            oeMovDocAUx.TipoOperacion = "VDC"
                            oeMovDocAUx.IndCompraVenta = "1"
                            lst_GastoAux = New List(Of e_GastoOperacion)
                            lst_MovDocAUx = olMovimientoDocumento.Listar(oeMovDocAUx)
                            If lst_MovDocAUx.Count > 0 Then
                                If Math.Round(lst_MovDocAUx.Item(0).Saldo, 2) < gasto.Total Then
                                    cont += 1
                                    msj &= gasto.SerieDoc & "-" & gasto.NroDoc & " de " & gasto.Proveedor & vbCrLf
                                End If
                            End If
                        End If
                    End If
                Next
                If cont > 0 Then
                    Throw New Exception(cont & " Comprobantes(s)  ya han sido Registrados():" & vbCrLf & msj)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            'If ValidaUsuarioCajaCentro(oeCajaUsuario.IdCaja, ObtenerCentro.Id, gUsuarioSGI.IdTrabajador) Then
            Validar_ExistenciaComprobante(False)
            If GuardarGasto() Then
                    mensajeEmergente.Confirmacion("Gastos Ingresados Correctamente", True)
                    MostrarTabs(0, ficGastosCaja, 0)
                    Consultar(True)
                End If
            'Else
            '    Throw New Exception("No puede Realizar Movimientos en esta Sede")
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarGasto() Then
                        MostrarTabs(0, ficGastosCaja, 2)
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficGastosCaja, 2)
            End Select
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            'If ficChequesPendientes.Tabs(0).Selected AndAlso griListaChequesPendientes.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            'If ficChequesPendientes.Tabs(0).Selected Then Exportar_Excel(griListaChequesPendientes)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'Dim a As String = ""
            'a = griListaChequesPendientes.ActiveRow.Cells("Estado").Value
            'If a <> "COBRADO" Then
            '    If a <> "ANULADO" Then
            '        Select Case MessageBox.Show("Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            '            Case Windows.Forms.DialogResult.Yes
            '                EliminarCheque()
            '        End Select
            '    End If
            'End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

    Private Sub lr_ConfigurarGrillas(lo As List(Of e_MovimientoDocumento))
        Try
            With griListaDocumentoCompra
                .DataSource = lo
                If mb_Load Then
                    .ResetDisplayLayout()
                    .Text = String.Empty
                    gmt_ConfiguraGrilla(griListaDocumentoCompra, "Tahoma", True, UIElementBorderStyle.Default)
                    gmt_OcultarColumna(griListaDocumentoCompra, False, "NombreProveedor", "Serie", "Numero", "FechaEmision", "Moneda", "Saldo", "Total")
                    .DisplayLayout.Bands(0).Columns("NombreProveedor").Width = 140
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 90
                    .DisplayLayout.Bands(0).Columns("Serie").Width = 40
                    .DisplayLayout.Bands(0).Columns("Numero").Width = 80
                    .DisplayLayout.Bands(0).Columns("Moneda").Width = 100
                    .DisplayLayout.Bands(0).Columns("Saldo").Width = 100
                    .DisplayLayout.Bands(0).Columns("Total").Width = 100
                    '.DisplayLayout.Bands(0).Columns("Sel").CellClickAction = UltraWinGrid.CellClickAction.RowSelect
                    '.DisplayLayout.Bands(0).Columns("Sel").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                    '.DisplayLayout.Bands(0).Columns("Sel").Header.Caption = ""
                    .DisplayLayout.Bands(0).Columns("NombreProveedor").Header.Caption = "Proveedor"
                    .DisplayLayout.ViewStyle = UltraWinGrid.ViewStyle.SingleBand
                    .DisplayLayout.Override.AllowColSizing = UltraWinGrid.AllowColSizing.Free
                    .DisplayLayout.Override.CellClickAction = UltraWinGrid.CellClickAction.RowSelect
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                    .DisplayLayout.Override.BorderStyleCell = UIElementBorderStyle.Dotted
                    .DisplayLayout.Override.BorderStyleRow = UIElementBorderStyle.Dotted
                    '.DisplayLayout.Bands(0).Columns("FechaEmision").CellActivation = Activation.NoEdit
                    gmt_FormatoColumna(griListaDocumentoCompra, "#,##0.00", UltraWinGrid.ColumnStyle.Double, HAlign.Right, "Saldo", "Total")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "Eventos"

    Private Sub frm_GastosCaja_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ControlBotones()
    End Sub

    Private Sub frm_GastosCaja_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_GastosCaja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_GastosCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me, btnAceptarDetalle.Name, btnBuscarDocumento.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            InicializarLogicas()
            CargarCombos()
            mb_Load = True
            lr_ConfigurarGrillas(New List(Of e_MovimientoDocumento))
            dtp_FechaDesde.Value = Date.Now.AddDays(-15)
            mb_Load = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoGasto_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoGasto.ValueChanged
        Try
            LlenarFlujoItemGasto()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTrabajador_Validated(sender As Object, e As EventArgs) Handles cboTrabajador.Validated
        Try
            If cboTrabajador.SelectedIndex > -1 Then
                Dim oeTrabajador As New e_Trabajador
                Dim olTrabajador As New l_Trabajador
                oeTrabajador.Id = cboTrabajador.Value
                oeTrabajador.CargaCompleto = False
                oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                cboArea.Value = oeTrabajador.oeArea.Id
            Else
                cboArea.Value = "1PY000000001"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txtSerie.Validated
        txtSerie.Text = gfc_ConcatenarCeros(txtSerie.Text, lenSerie)
    End Sub

    Private Sub txtNumero_Validated(sender As Object, e As EventArgs) Handles txtNumero.Validated
        txtNumero.Text = gfc_ConcatenarCeros(txtNumero.Text, lenNumero)
    End Sub

    Private Sub cboProveedores_Validated(sender As Object, e As EventArgs) Handles cboProveedores.Validated
        Try
            If cboTipoDocumento.Value <> "1CH000000062" Then
                oeProveedor = New e_Proveedor
                oeProveedor.Id = IIf(cboProveedores.Value <> Nothing, cboProveedores.Value, "")
                oeProveedor.Tipo = 0
                If loProveedor.Contains(oeProveedor) Then
                    txtRUC.Value = loProveedor.Item(loProveedor.IndexOf(oeProveedor)).NroDocumento
                End If
                If cboFlujoCaja.Text = "COMBUSTIBLES" Then
                    LimpiaCombos(cboLugar)
                    LimpiaCombos(cboDireccion)
                    If Me.cboProveedores.Value <> "" Then
                        CargaLugaresEmpresa(cboProveedores.ActiveRow.Cells("IdEmpresa").Value)
                        Dim obj As New e_Empresa
                        obj.Id = cboProveedores.ActiveRow.Cells("IdEmpresa").Value
                        obj = olEmpresa.Obtener(obj)
                        If Not String.IsNullOrEmpty(obj.IdDireccionTanqueo) Then
                            oeDireccion = New e_Direccion
                            oeDireccion.Activo = True
                            oeDireccion.Id = obj.IdDireccionTanqueo
                            oeDireccion.TipoOperacion = ""
                            oeDireccion = olDireccion.Obtener(oeDireccion)
                            cboLugar.Value = oeDireccion.CCPP
                        End If
                    Else
                        Me.cboLugar.Value = Nothing
                        Me.cboLugar.DataSource = Nothing
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedores_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedores.InitializeLayout
        Try
            InicializarComboProveedor()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedores_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboProveedores.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'Select Case e.Button.Key
            '    Case "Right"
            Me.txtRUC.Text = String.Empty
            LlenaComboProveedor()
            'End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cboProveedores_Enter(sender As Object, e As EventArgs) Handles cboProveedores.Enter
        cboProveedores.SelectAll()
    End Sub

    Private Sub txtRUC_ValueChanged(sender As Object, e As EventArgs) Handles txtRUC.ValueChanged
        Try
            If Not txtRUC.Value Is Nothing Then
                If txtRUC.Value.ToString.Trim.Length > 10 Then
                    Dim leProveedorList As New List(Of e_Proveedor)
                    leProveedorList = loProveedor.ToList
                    leProveedorList = loProveedor.Where(Function(item) item.NroDocumento.Contains(txtRUC.Value)).ToList
                    If leProveedorList.Count > 0 Then
                        cboProveedores.Value = leProveedorList(0).Id
                    Else
                        cboProveedores.Value = Nothing
                    End If
                End If
            Else
                cboProveedores.Value = Nothing
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAceptarDetalle_Click(sender As Object, e As EventArgs) Handles btnAceptarDetalle.Click
        Try
            If ValidarGasto() Then
                AgregarGasto()
                CalcularTotales(griGastoOperacion, "Total")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub numSubTotal_ValueChanged(sender As Object, e As EventArgs) Handles numSubTotal.ValueChanged
        Try
            If IsDBNull(numSubTotal.Value) Then numSubTotal.Value = 0
            Calcular(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub numTotal_ValueChanged(sender As Object, e As EventArgs) Handles numTotal.ValueChanged
        'Try
        '    If IsDBNull(numTotal.Value) Then numTotal.Value = 0
        '    Calcular(1)
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

    Private Sub cboTipoDocumento_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoDocumento.ValueChanged
        Try
            If cboTipoDocumento.SelectedIndex <> -1 Then
                oeTipoDoc = New e_TipoDocumento
                oeTipoDoc = cboTipoDocumento.Items(cboTipoDocumento.SelectedIndex).ListObject
                If oeTipoDoc.IndIGV = 1 Then
                    IndicadorIGV = True
                Else
                    IndicadorIGV = False
                End If
                lenSerie = gfc_ObtieneLongitudSerie(oeTipoDoc.Codigo)
                txtSerie.MaxLength = lenSerie
                lenNumero = gfc_ObtieneLongitudNumero(oeTipoDoc.Codigo)
                txtNumero.MaxLength = lenNumero
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboDocumentoAlmacen_ValueChanged(sender As Object, e As EventArgs) Handles cboDocumentoAlmacen.ValueChanged
        Try
            If cboDocumentoAlmacen.SelectedIndex <> -1 Then
                oeTipoDoc = New e_TipoDocumento
                oeTipoDoc = cboTipoDocumento.Items(cboDocumentoAlmacen.SelectedIndex).ListObject
                'If oeTipoDoc.IndIGV = 1 Then
                    'IndicadorIGV = True
                'Else
                    'IndicadorIGV = False
                'End If
                lenSerie = gfc_ObtieneLongitudSerie(oeTipoDoc.Codigo)
                txtSerie.MaxLength = lenSerie
                lenNumero = gfc_ObtieneLongitudNumero(oeTipoDoc.Codigo)
                txtNumero.MaxLength = lenNumero
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub numIGV_ValueChanged(sender As Object, e As EventArgs) Handles numIGV.ValueChanged
        Try
            If IsDBNull(numIGV.Value) Then numIGV.Value = 0
            numTotal.Value = Math.Round(numSubTotal.Value + numIGV.Value + numGravada.Value + numPercepcion.Value, 2)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub numGravada_ValueChanged(sender As Object, e As EventArgs) Handles numGravada.ValueChanged
        Try
            If IsDBNull(numGravada.Value) Then numGravada.Value = 0
            numTotal.Value = Math.Round(numSubTotal.Value + numIGV.Value + numGravada.Value + numPercepcion.Value, 2)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_GastosCaja_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub txtSerie_Enter(sender As Object, e As EventArgs) Handles txtSerie.Enter
        txtSerie.SelectAll()
    End Sub

    Private Sub txtNumero_Enter(sender As Object, e As EventArgs) Handles txtNumero.Enter
        txtNumero.SelectAll()
    End Sub

    Private Sub txtRUC_Enter(sender As Object, e As EventArgs) Handles txtRUC.Enter
        txtRUC.SelectAll()
    End Sub

    Private Sub numSubTotal_KeyDown(sender As Object, e As KeyEventArgs) Handles numSubTotal.KeyDown
        If e.KeyCode = Keys.Tab Then numIGV.Focus()
    End Sub

    Private Sub btnCancelarDetalle_Click(sender As Object, e As EventArgs) Handles btnCancelarDetalle.Click
        Try
            QuitarGasto()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboFlujoCaja_ValueChanged(sender As Object, e As EventArgs) Handles cboFlujoCaja.ValueChanged
        If cboFlujoCaja.Value = "1CH000000085" Then
            ExpRegistroConsumoCombustible.Visible = True
            ExpRegistroConsumoCombustible.Expanded = True
            ChkVehiculoProper.Checked = False
            ChkVehiculoProper.Enabled = False
        Else
            ExpRegistroConsumoCombustible.Visible = False
            ExpRegistroConsumoCombustible.Expanded = False
            DecCantidadGalones.Value = 0
            ChkVehiculoProper.Enabled = True
        End If

        cboGastoFuncion.SelectedIndex = 0
        If Not cboFlujoCaja.Value Is Nothing Then
            Dim selecionado = loConcepto.Where(Function(x) x.Valor1.Trim = cboFlujoCaja.Value.ToString.Trim).ToList
            If selecionado.Count = 1 Then cboGastoFuncion.Value = selecionado(0).Valor2.Trim
        End If


    End Sub

    Private Sub btnBuscarDocumento_Click(sender As Object, e As EventArgs) Handles btnBuscarDocumento.Click
        Try
            If ValidarBusquedaDocumento() Then
                Ficha1.Tabs(0).Selected = True
                ListarDocumento()
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerieDoc_Validated(sender As Object, e As EventArgs) Handles txtSerieDoc.Validated
        txtSerieDoc.Text = FormatoDocumento(txtSerieDoc.Text, 4)
    End Sub

    Private Sub txtNumeroDoc_Validated(sender As Object, e As EventArgs) Handles txtNumeroDoc.Validated
        'txtNumeroDoc.Text = FormatoDocumento(txtNumeroDoc.Text, 10)
    End Sub

    Private Sub griListaDocumentoCompra_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griListaDocumentoCompra.DoubleClickRow
        Try
            With Me.griListaDocumentoCompra
                If .Rows.Count > 0 Then
                    Me.cboTipoDocumento.Value = Me.cboDocumentoAlmacen.Value
                    Me.txtNumero.Text = .ActiveRow.Cells("Numero").Value.ToString
                    Me.txtSerie.Text = .ActiveRow.Cells("Serie").Value.ToString
                    Me.numSubTotal.Value = .ActiveRow.Cells("SubTotal").Value
                    Me.numTotal.Value = .ActiveRow.Cells("Saldo").Value
                    Me.numIGV.Value = .ActiveRow.Cells("IGV").Value
                    Me.cboProveedores.Value = .ActiveRow.Cells("IdClienteProveedor").Value.ToString
                    dtpFechaEmision.Value = .ActiveRow.Cells("FechaEmision").Value
                    dtpFecVencimiento.Value = .ActiveRow.Cells("FechaVencimiento").Value
                    Me.fecPeriodo.Value = .ActiveRow.Cells("IdPeriodo").Value.ToString
                    IdDocumentoAlmacen = .ActiveRow.Cells("Id").Value.ToString
                    Me.txtGlosa.Text = .ActiveRow.Cells("TipoPago").Value.ToString & " " & Me.txtGlosaOC.Text
                    IndCompraAlmacen = True
                    Me.expDocumento.Expanded = False
                    griListaDocumentoCompra.DataSource = New List(Of e_MovimientoDocumento)
                    Me.cboDocumentoAlmacen.SelectedIndex = -1
                    txtSerieDoc.Text = String.Empty
                    txtNumeroDoc.Text = String.Empty
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboLugar_ValueChanged(sender As Object, e As EventArgs) Handles cboLugar.ValueChanged
        Try
            If cboLugar.SelectedIndex <> -1 Then
                CargaDireccionesGrifo(cboProveedores.ActiveRow.Cells("IdEmpresa").Value)
                If cboDireccion.Items.Count > 1 Then
                    cboDireccion.SelectedIndex = -1
                Else
                    cboDireccion.SelectedIndex = 0
                End If
            Else
                Me.cboDireccion.Value = Nothing
                Me.cboDireccion.DataSource = Nothing
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoGasto_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboTipoGasto.EditorButtonClick
        Try
            cboTipoGasto.DataSource = Nothing
            cboTipoGasto.SelectedIndex = -1
            CargarTipoGasto()
            CargarTipoGastoDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboFlujoCaja_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboFlujoCaja.EditorButtonClick
        Try
            CargarTipoGastoDetalle()
            LlenarFlujoItemGasto()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griGastoOperacion_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGastoOperacion.AfterCellUpdate
        Try
            With griGastoOperacion
                If .ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                    Select Case e.Cell.Column.Key
                        Case "Glosa"
                            Dim oeGO As New e_GastoOperacion
                            oeGO = griGastoOperacion.ActiveRow.ListObject
                            If oeGO.TipoOperacion <> "I" Then
                                oeGO = loGastoOpe.Item(loGastoOpe.IndexOf(oeGO))
                                oeGO.TipoOperacion = "A"
                            End If
                    End Select
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griGastoOperacion_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGastoOperacion.CellChange
        griGastoOperacion.UpdateData()
    End Sub

    Private Sub txtGlosa_Enter(sender As Object, e As EventArgs) Handles txtGlosa.Enter
        txtGlosa.SelectAll()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnNuevoProveedor_Click(sender As Object, e As EventArgs) Handles btnNuevoProveedor.Click
        Try
            Dim Formulario As New frm_Proveedor
            Formulario.RegistroProveedor = "TES"
            Formulario.ShowDialog()
            If Formulario.RegistroProveedor <> "TES" Then
                LlenaComboProveedor()
                txtRUC.Text = Formulario.RegistroProveedor
            End If
            Formulario.Dispose()
            Formulario.Close()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ChkVehiculoProper_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVehiculoProper.CheckedChanged
        Try
            If ChkVehiculoProper.Checked Then
                With cboPlaca.CheckedListSettings
                    .CheckBoxStyle = Infragistics.Win.CheckStyle.CheckBox
                    .EditorValueSource = Infragistics.Win.EditorWithComboValueSource.CheckedItems
                    .ListSeparator = ";"
                End With
                DescheckearTodosItemsCombo()
            Else
                Me.cboPlaca.CheckedListSettings.Reset()
                cboPlaca.SelectedIndex = -1
                'With cboPlaca.CheckedListSettings
                '    .CheckBoxStyle = Infragistics.Win.CheckStyle.None
                '    .EditorValueSource = Infragistics.Win.EditorWithComboValueSource.SelectedItem
                '    .ListSeparator = ""
                'End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub InicializarLogicas()
        olMoneda = New l_Moneda
        olPeriodo = New l_Periodo
        olCtaCte = New l_CuentaCorriente
        olFuncion = New l_FuncionesGenerales
        olGastoOpe = New l_GastoOperacion
        olTipoGasto = New l_TipoGasto
        olFlujoGasto = New l_TipoGastoDetalle
        olTipoDoc = New l_TipoDocumento
        olFlujoCajaConta = New l_FlujoCaja
        olFlujoPlaca = New l_ProcesoFlujoCaja
        olFlujoCaja = New l_FlujoCaja
        olCajaUsuario = New l_CajaUsuario
        olCaja = New l_Caja
        olProveedor = New l_Proveedor
        olEmpresa = New l_Empresa
        olCcpp = New l_CCPP
        olDireccion = New l_Direccion
        olMaterial = New l_Material
    End Sub

    Private Sub Inicializar()
        Id = 0
        oeGastoOpe = New e_GastoOperacion
        loGastoOpe = New List(Of e_GastoOperacion)
        griGastoOperacion.DataSource = loGastoOpe
        IdDocumentoAlmacen = String.Empty
        IndCompraAlmacen = False
        expDocumento.Expanded = False
    End Sub

    Private Sub CargarGrupo()
        Try
            oePerGrupo = New e_Periodo
            Dim oeGrupo As New e_Grupo
            Dim olGrupo As New l_Grupo
            oeGrupo.TipoOperacion = "1"
            oeGrupo.Tipo = 2
            oeGrupo.Estado = "GENERADA"
            oeGrupo.Activo = True
            oeGrupo.IdCentro = ObtenerCentro(gs_PrefijoIdSucursal).Id
            'oeGrupo.IdCentro = "1CH001"
            LlenarCombo(cboGrupo, "Codigo", olGrupo.Listar(oeGrupo).OrderByDescending(Function(item) item.FechaCreacion).ToList, 0)
            oeGrupo = olGrupo.Obtener(oeGrupo)
            oePerGrupo.Id = oeGrupo.IdPeriodo
            cboGrupo.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCombos()
        Try
            ListarCuentaCorriente()
            ListarCajas()
            ListarUsuarioCaja()
            CargarTipoGasto()
            CargarTipoDocumento()
            CargarFlujoCaja()
            CargarTipoGastoDetalle()
            CargarTrabajador()
            CargarPlaca()
            CargaFlujoCajaConta()
            CargarAreaTrabajador()
            CargarFlujoPlaca()
            CargarGastoFuncion()
            LlenaComboProveedor()
            CrearComboGrid("IdFlujoCaja", "Nombre", griGastoOperacion, olFlujoCaja.ComboGrilla(loFlujoCaja), True)
            CargarMoneda()
            CargarMaterial()
            ListarFlujoCajaConGastoFuncion()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarFlujoCajaConGastoFuncion()
        Try
            'cargar flujo caja concepto
            loConcepto = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "38"
            loConcepto = olConcepto.Listar(oeConcepto)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarCuentaCorriente()
        Try
            oeCtaCte = New e_CuentaCorriente
            loCtaCte = New List(Of e_CuentaCorriente)
            oeCtaCte.Activo = True
            loCtaCte = olCtaCte.Listar(oeCtaCte)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarFlujoCaja()
        Try
            oeFlujoCaja = New e_FlujoCaja
            oeFlujoCaja.TipoOperacion = "P"
            oeFlujoCaja.NombProceso = "Tesoreria"
            loFlujoCaja = New List(Of e_FlujoCaja)
            loFlujoCaja = olFlujoCaja.Listar(oeFlujoCaja)

            oeFlujoCaja = New e_FlujoCaja
            oeFlujoCaja.TipoOperacion = "C"
            oeFlujoCaja.NombProceso = "Tesoreria"
            loFlujoCuenta = New List(Of e_FlujoCaja)
            loFlujoCuenta.AddRange(olFlujoCaja.Listar(oeFlujoCaja))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarMoneda()
        Try
            oeMoneda = New e_Moneda
            oeMoneda.Id = "1CH01"
            oeMoneda = olMoneda.Obtener(oeMoneda)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarTipoDocumento()
        Try
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.TipoOperacion = "S"
            loTipoDoc = New List(Of e_TipoDocumento)
            loTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
            LlenarCombo(cboTipoDocumento, "Nombre", loTipoDoc, -1)
            LlenarCombo(cboDocumentoAlmacen, "Nombre", loTipoDoc, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarTipoGasto()
        Try
            oeTipoGasto = New e_TipoGasto
            LlenarCombo(cboTipoGasto, "Nombre", olTipoGasto.Listar2(oeTipoGasto), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarTipoGastoDetalle()
        Try
            oeFlujoGasto = New e_TipoGastoDetalle
            loFlujoGasto = New List(Of e_TipoGastoDetalle)
            oeFlujoGasto.TipoOperacion = "1"
            loFlujoGasto.AddRange(olFlujoGasto.Listar(oeFlujoGasto))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarTrabajador()
        Try
            LlenarCombo(cboTrabajador, "Nombre", TrabajadorPublic.Where(Function(item) item.Descripcion = "1").ToList, -1)
            LlenarCombo(cboAutoriza, "Nombre", TrabajadorPublic.Where(Function(item) item.Descripcion = "1").ToList, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPlaca()
        Try
            Dim lo As New List(Of e_Combo)
            lo.AddRange(TractoPublic)
            lo.AddRange(CarretaPublic)
            LlenarCombo(cboPlaca, "Nombre", lo.OrderBy(Function(i) i.Nombre).ToList, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaFlujoCajaConta()
        Try
            oeFlujoCajaConta = New e_FlujoCaja
            loFlujoCajaConta = New List(Of e_FlujoCaja)
            oeFlujoCajaConta.TipoOperacion = "P"
            oeFlujoCajaConta.NombProceso = "FLUJOCONTA"
            loFlujoCajaConta = olFlujoCajaConta.Listar(oeFlujoCajaConta)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAreaTrabajador()
        Try
            LlenarCombo(cboArea, "Nombre", AreasPublic, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarFlujoPlaca()
        Try
            loFlujoPlaca = New List(Of e_ProcesoFlujoCaja)
            oeFlujoPlaca = New e_ProcesoFlujoCaja
            oeFlujoPlaca.IdProcesoNegocio = "1CH000000006"
            loFlujoPlaca.AddRange(olFlujoPlaca.Listar(oeFlujoPlaca))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ControlBotones()
        If idCajaCentro = "" Then
            ControlBoton()
        Else
            Select Case ficGastosCaja.SelectedTab.Index
                Case 0
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                Case 1
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End Select
        End If
    End Sub

    Private Sub LlenarFlujoItemGasto()
        Try
            LimpiaCombos(cboFlujoCaja)
            If cboTipoGasto.SelectedIndex <> -1 Then
                Dim loTipGasDet1 As New List(Of e_TipoGastoDetalle)
                loTipGasDet1.AddRange(loFlujoGasto.Where(Function(item) item.IdTipoGasto = cboTipoGasto.Value).ToList)
                LlenarCombo(cboFlujoCaja, "FlujoCaja", loTipGasDet1.OrderBy(Function(item) item.FlujoCaja).ToList, -1)
            Else
                cboFlujoCaja.DataSource = Nothing
                cboFlujoCaja.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarCajas()
        Try
            oeCaja = New e_Caja
            loCaja = New List(Of e_Caja)
            loCaja = olCaja.Listar(oeCaja)
            LlenarCombo(cboCentroCosto, "Nombre", loCaja, -1)
            LlenarCombo(cboCaja, "Nombre", loCaja, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarUsuarioCaja()
        Try
            oeCajaUsuario = New e_CajaUsuario
            oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
            If oeCajaUsuario.Id <> "" Then
                For Each ListaCaja As e_Caja In loCaja
                    If ListaCaja.Id = oeCajaUsuario.IdCaja Then
                        idCajaCentro = ListaCaja.Id
                        cboCentroCosto.Value = idCajaCentro
                        cboCaja.Value = idCajaCentro
                        If ListaCaja.IndPrincipal Then cboCaja.Enabled = True
                    End If
                Next
            Else
                MsgBox("Este Usuario no esta asignado a ninguna Caja", MsgBoxStyle.Information, Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarGastoFuncion()
        Try
            Dim oeTablaContableDet As New e_TablaContableDet
            Dim olTablaContableDet As New l_TablaContableDet
            Dim leTabla As New List(Of e_TablaContableDet)
            oeTablaContableDet.TipoOperacion = "N"
            oeTablaContableDet.Nombre = "GASTO FUNCION" 'Tipo de medio de pago
            oeTablaContableDet.Activo = True
            oeTablaContableDet.Logico1 = 1
            leTabla.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
            With cboGastoFuncion
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leTabla
            End With
            cboGastoFuncion.Value = "1CH000087"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaComboProveedor()
        loProveedor = New List(Of e_Proveedor)
        oeProveedor = New e_Proveedor
        oeProveedor.TipoOperacion = "5"
        cboProveedores.Value = Nothing
        loProveedor.AddRange(olProveedor.Listar(oeProveedor))
        With cboProveedores
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = loProveedor
        End With
        InicializarComboProveedor()
    End Sub

    Private Sub InicializarComboProveedor()
        Try
            Me.cboProveedores.ValueMember = "Id"
            Me.cboProveedores.DisplayMember = "Nombre"
            With cboProveedores.DisplayLayout.Bands(0)
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
                .Columns("Nombre").Header.Caption = "Proveedor"
                .Columns("NroDocumento").Header.Caption = "RUC/DNI"
                .Columns("NroDocumento").Header.VisiblePosition = 0
                .Columns("Nombre").Header.VisiblePosition = 1
                .Columns("NroDocumento").Width = 120
                .Columns("Nombre").Width = 450
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarGasto()
        Try
            Dim FechaActual As Date = ObtenerFechaServidor()
            Dim TC As Double = TipoCambio(FechaActual, True)(0)
            oeGastoOpe = New e_GastoOperacion
            With oeGastoOpe
                .TipoOperacion = "I"
                Id = Id + 1
                .Id = Id
                .IdCaja = idCajaCentro
                .IdCuentaCorriente = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCtaCte)
                .IdMoneda = oeMoneda.Id
                .FechaCreacion = FechaActual
                .FechaEmision = dtpFechaEmision.Value
                .IdGrupo = String.Empty ' cboGrupo.Value
                .NroGrupo = String.Empty ' cboGrupo.Text
                .IdFlujoCaja = cboFlujoCaja.Value
                .TipoDocumento = cboTipoDocumento.Text
                .SerieDoc = gfc_ConcatenarCeros(Me.txtSerie.Text, lenSerie)
                .NroDoc = gfc_ConcatenarCeros(Me.txtNumero.Text, lenNumero)
                .Glosa = txtGlosa.Text
                .IdTipoDocumento = cboTipoDocumento.Value
                .TipoDocumento = cboTipoDocumento.Text.Trim
                .IdProveedor = IIf(cboProveedores.Value <> Nothing, cboProveedores.Value, "")
                .Proveedor = cboProveedores.Text
                .IdPeriodo = oePeriodo.Id ' oePerGrupo.Id
                .SubTotal = numSubTotal.Value
                .IGV = numIGV.Value
                .Total = numTotal.Value
                .UsuarioCreacion = gUsuarioSGI.Id
                .TipoCambio = TC
                .Ejercicio = oePeriodo.Ejercicio
                .Mac = MacPCLocal()
                .TipoMovimiento = 2
                .IdDocumento = IIf(IdDocumentoAlmacen = String.Empty, "", IdDocumentoAlmacen)
                'FlujoCuenta
                Dim oeFlCj As New e_FlujoCaja
                oeFlCj.Id = .IdFlujoCaja
                oeFlCj.Ejercicio = oePeriodo.Ejercicio
                If loFlujoCuenta.Where(Function(i) i.Id = oeFlCj.Id And i.Ejercicio = oeFlCj.Ejercicio).Count > 0 Then
                    oeFlCj = loFlujoCuenta.Item(loFlujoCuenta.IndexOf(oeFlCj))
                    .oeFlujoCaja = oeFlCj
                Else
                    Throw New Exception("Flujo Caja Sin Cuenta Contable... Verificar")
                End If
                .TipoBus = oeFlCj.IdItemGasto
                .IndAlmacen = IndCompraAlmacen
                .oeMovimientoDocumento = New e_MovimientoDocumento
                .oeMovimientoDocumento.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                With .oeMovimientoDocumento
                    .Id = IIf(IdDocumentoAlmacen = String.Empty, "", IdDocumentoAlmacen)
                    .Serie = gfc_ConcatenarCeros(Me.txtSerie.Text, lenSerie)
                    .Numero = gfc_ConcatenarCeros(Me.txtNumero.Text, lenNumero)
                    .IdTipoDocumento = cboTipoDocumento.Value
                    .IdClienteProveedor = IIf(cboProveedores.Value <> Nothing, cboProveedores.Value, "")
                    .IdCuentaContable = "" 'IdCuentaContableCompraAlmacen
                    .GlosaViajeGrupo = cboGrupo.Text
                    .SubTotal = numSubTotal.Value + numGravada.Value
                    .IGV = numIGV.Value + numPercepcion.Value
                    .Total = numTotal.Value
                    .Ejercicio = fecPeriodo.DateTime.Year
                    .FechaEmision = dtpFechaEmision.Value
                    .FechaVencimiento = .FechaEmision
                    .NoGravado = numGravada.Value
                    .TipoCambio = TC
                    .IndCompraVenta = 1
                    If .IdTipoDocumento <> "1CH000000062" And .IdClienteProveedor <> "" Then
                        olFuncion.ValidarDocumentoDuplicado(oeGastoOpe.oeMovimientoDocumento)
                    End If
                    .FechaFinal = oePeriodo.FechaFin
                End With
                With .oeMovimientoDocumento.Compra
                    .OtrosTributos = numPercepcion.Value
                    .NoGravadas = numPercepcion.Value + IIf(numIGV.Value = 0, numSubTotal.Value, 0)
                    .TipoDoc = cboTipoDocumento.Items(cboTipoDocumento.SelectedIndex).ListObject
                    oeProveedor = New e_Proveedor
                    oeProveedor.Id = IIf(cboProveedores.Value <> Nothing, cboProveedores.Value, "")
                    If loProveedor.Contains(oeProveedor) Then
                        .Proveedor = loProveedor.Item(loProveedor.IndexOf(oeProveedor))
                    End If
                    .Moneda = oeMoneda
                    .Base1 = IIf(numIGV.Value = 0, 0, numSubTotal.Value)
                    .Igv1 = numIGV.Value
                    .TotalIGVCompra = numIGV.Value
                    .TotalBaseCompra = IIf(numIGV.Value = 0, 0, numSubTotal.Value)
                    .TipoCompra = New e_TablaContableDet
                    .TipoCompra.Id = oeFlCj.IdTipoCompra
                End With
                .oeGasto_Caja = New e_Gasto_Caja
                With .oeGasto_Caja
                    .CentroGasto = cboCentroCosto.Value
                    .IdPiloto = cboTrabajador.Value
                    .IdRuta = ""
                    .UsuarioAutoriza = cboAutoriza.Value
                    .IdTipoGasto = cboTipoGasto.Value
                    .IdArea = cboArea.Value
                    .IdPlaca = cboPlaca.Value
                    .IndCompraAlmacen = IndCompraAlmacen
                    .IdGastoFuncion = cboGastoFuncion.Value
                    If .IdTipoGasto = "1CH000000006" Or .IdTipoGasto = "1CH000000009" Or .IdTipoGasto = "1CH000000010" Then
                        If cboPlaca.Text = "" Then
                            Throw New Exception("Ingrese Placa Por Favor")
                        End If
                    End If
                End With
                If cboTipoDocumento.Value = "1CH000000062" Or cboTipoDocumento.Value = "1CH000000073" Then
                    .GastoAsiento = New e_GastoAsiento
                    With .GastoAsiento
                        .TipoOperacion = "I"
                    End With
                End If
                'combustible
                If cboFlujoCaja.Value = "1CH000000085" Then
                    .oeRegistroCombustible = New e_RegistroConsumoCombustible
                    .oeRegistroCombustible.TipoOperacion = "I"
                    .oeRegistroCombustible.NroVale = .SerieDoc & " - " & .NroDoc
                    .oeRegistroCombustible.KilometrosTanqueo = 0
                    .oeRegistroCombustible.IdMaterial = cboMaterial.Value
                    .oeRegistroCombustible.IdGrifo = cboProveedores.ActiveRow.Cells("IdEmpresa").Value
                    .oeRegistroCombustible.IdLugar = cboLugar.Value
                    .oeRegistroCombustible.IdDireccion = cboDireccion.Value
                    .oeRegistroCombustible.IndCredito = False
                    .oeRegistroCombustible.IndTanqueo = False
                    .oeRegistroCombustible.IdRegistroInventario = ""
                    .oeRegistroCombustible.UsuarioCreacion = gUsuarioSGI.Id
                    .oeRegistroCombustible.CantidadGalon = DecCantidadGalones.Value
                    .oeRegistroCombustible.Activo = True
                    .oeRegistroCombustible.Ind_GastoViaje = 1
                    .oeRegistroCombustible.Estado = "CON"
                    .oeRegistroCombustible.FechaTanqueo = dtpFechaEmision.Value
                    .oeRegistroCombustible.IndIsl = False
                    .oeRegistroCombustible.IdVehiculo = .oeGasto_Caja.IdPlaca
                    .oeRegistroCombustible.IdPiloto = cboTrabajador.Value
                    .oeRegistroCombustible.IdViaje = ""
                    .oeMovimientoDocumento.IndServicioMaterial = "M"
                    Dim oeDetalleDoc As New e_DetalleDocumento
                    oeDetalleDoc.TipoOperacion = "I"
                    oeDetalleDoc.IndServicioMaterial = "M"
                    oeDetalleDoc.IdMaterialServicio = cboMaterial.Value
                    oeDetalleDoc.Cantidad = oeGastoOpe.oeRegistroCombustible.CantidadGalon
                    oeDetalleDoc.Precio = numSubTotal.Value / oeDetalleDoc.Cantidad
                    oeDetalleDoc.Subtotal = numSubTotal.Value
                    oeDetalleDoc.IndGravado = IIf(numIGV.Value > 0, True, False)
                    oeDetalleDoc.Igv = numIGV.Value + numPercepcion.Value
                    oeDetalleDoc.Total = numTotal.Value
                    oeDetalleDoc.IdVehiculo = .oeGasto_Caja.IdPlaca
                    oeDetalleDoc.PrefijoID = gs_PrefijoIdSucursal '@0001
                    .oeMovimientoDocumento.lstDetalleDocumento.Add(oeDetalleDoc)
                Else
                    .oeRegistroCombustible = Nothing
                    With .oeMovimientoDocumento
                        .IndServicioMaterial = "S"
                        Dim oeDetalleDoc As New e_DetalleDocumento
                        oeDetalleDoc.TipoOperacion = "I"
                        oeDetalleDoc.IndServicioMaterial = "S"
                        oeDetalleDoc.IdMaterialServicio = "1PY000000002" 'GASTOS DE VIAJE
                        oeDetalleDoc.Cantidad = 1
                        oeDetalleDoc.Precio = numSubTotal.Value + numGravada.Value
                        oeDetalleDoc.Subtotal = numSubTotal.Value + numGravada.Value
                        oeDetalleDoc.IndGravado = IIf(numIGV.Value > 0, True, False)
                        oeDetalleDoc.Igv = numIGV.Value + numPercepcion.Value
                        oeDetalleDoc.Total = numTotal.Value
                        oeDetalleDoc.IdVehiculo = cboPlaca.Value
                        oeDetalleDoc.PrefijoID = gs_PrefijoIdSucursal '@0001
                        .lstDetalleDocumento.Add(oeDetalleDoc)
                    End With
                End If
            End With
            If ValidaGastoDuplicado(oeGastoOpe.SerieDoc + oeGastoOpe.NroDoc, oeGastoOpe.IdTipoDocumento, oeGastoOpe.IdProveedor) Then
                oeGastoOpe.PrefijoID = gs_PrefijoIdSucursal '@0001
                loGastoOpe.Add(oeGastoOpe)
                griGastoOperacion.DataBind()
            End If
            If MessageBox.Show("¿Desea seguir Agregando Documentos?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                LimpiarControles(False)
            Else
                LimpiarControles(True)
            End If
            cboGrupo.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpiarControles(Completo As Boolean)
        Try
            IdDocumentoAlmacen = String.Empty
            IndCompraAlmacen = False
            txtSerie.Text = String.Empty
            txtNumero.Text = String.Empty
            dtpFechaEmision.Value = Date.Now
            dtpFecVencimiento.Value = Date.Now
            numSubTotal.Value = 0
            numIGV.Value = 0
            numGravada.Value = 0
            numPercepcion.Value = 0
            numTotal.Value = 0
            If Completo Then
                cboTipoGasto.SelectedIndex = -1
                cboTipoDocumento.SelectedIndex = -1
                txtRUC.Text = String.Empty
                cboProveedores.Text = String.Empty
                txtGlosa.Text = String.Empty
                cboTrabajador.SelectedIndex = -1
                cboArea.SelectedIndex = -1
                cboPlaca.SelectedIndex = -1
                cboAutoriza.SelectedIndex = -1
            End If

            If cboTipoDocumento.SelectedIndex <> -1 Then
                lenSerie = gfc_ObtieneLongitudSerie(oeTipoDoc.Codigo)
                txtSerie.MaxLength = lenSerie
                lenNumero = gfc_ObtieneLongitudNumero(oeTipoDoc.Codigo)
                txtNumero.MaxLength = lenNumero
            End If
            

            'lenSerie = 4
            'txtSerie.MaxLength = lenSerie
            'lenNumero = 10
            'txtNumero.MaxLength = lenNumero
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Calcular(Ind As Integer)
        Try
            If Ind = 0 Then
                If IndicadorIGV Then
                    numIGV.Value = Math.Round(numSubTotal.Value * (oeIGVGlobal.Porcentaje), 2)
                Else
                    numIGV.Value = 0
                End If
                numTotal.Value = numSubTotal.Value + numIGV.Value + numGravada.Value
            Else
                If IndicadorIGV Then
                    numSubTotal.Value = Math.Round(numTotal.Value / (1 + oeIGVGlobal.Porcentaje), 2)
                    numIGV.Value = Math.Round(numTotal.Value - numSubTotal.Value, 2)
                Else
                    numSubTotal.Value = numTotal.Value
                    numIGV.Value = 0
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarGastos()
        Try
            oeGastoOpe = New e_GastoOperacion
            oeGastoOpe.IdCuentaCorriente = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCtaCte)
            oeGastoOpe.IdCaja = idCajaCentro
            oeGastoOpe.TipoOperacion = "5"
            loGastoOpe = olGastoOpe.Listar(oeGastoOpe)
            griGastoOperacion.DataSource = loGastoOpe
            griGastoOperacion.DataBind()
            CalcularTotales(griGastoOperacion, "Total")
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
            oeGastoOpe = New e_GastoOperacion
            oeGastoOpe.IdCaja = cboCaja.Value
            oeGastoOpe.TipoOperacion = "5"
            oeGastoOpe.FechaEmision = dtp_FechaDesde.Value
            oeGastoOpe.FechaCreacion = dtp_FechaHasta.Value
            griGastosLista.DataSource = olGastoOpe.Listar(oeGastoOpe)
            CalcularTotales(griGastosLista, "Total")
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub CargarMaterial()
        oeMaterial = New e_Material
        oeMaterial.TipoOperacion = "O"
        oeMaterial.Activo = True
        LlenarComboMaestro(cboMaterial, olMaterial.Listar(oeMaterial), -1)
    End Sub

    Private Sub QuitarGasto()
        Try
            oeGastoOpe = New e_GastoOperacion
            Dim oeSaldo As New e_Saldo
            Dim olSaldo As New l_Saldo
            oeSaldo.TipoOperacion = "3"
            oeSaldo.IdCaja = idCajaCentro
            oeSaldo = olSaldo.Obtener(oeSaldo)
            If griGastoOperacion.Selected.Rows.Count > 0 Then
                oeGastoOpe = griGastoOperacion.ActiveRow.ListObject
                If oeGastoOpe.TipoOperacion = "I" Then
                    loGastoOpe.Remove(oeGastoOpe)
                Else
                    If oeGastoOpe.IndAlmacen Then
                        Throw New Exception("No Puede Eliminar Pagos de Facturas de Logistica")
                    End If
                    If oeGastoOpe.FechaCreacion > oeSaldo.FechaHora Then
                        oeGastoOpe.TipoOperacion = "E"
                        griGastoOperacion.ActiveRow.Hidden = True
                    Else
                        Throw New Exception("No Puede Quitar Gastos Despues del Cierre de Caja")
                    End If
                End If
                griGastoOperacion.DataSource = loGastoOpe
                griGastoOperacion.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaLugaresEmpresa(IdEmpresa As String)
        Try
            oeCcpp = New e_CCPP
            oeCcpp.TipOoperacion = 1
            oeCcpp.Activo = True
            oeCcpp.Nombre = IdEmpresa
            LimpiaCombos(cboLugar)
            LlenarCombo(cboLugar, "Nombre", olCcpp.Listar(oeCcpp), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarDocumento()
        Try
            Dim olMovimientoDocumento As New l_MovimientoDocumento
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim oeMovDoc As New e_MovimientoDocumento
            Dim oeOrdDoc As New e_Orden_Documento
            Dim olOrdDoc As New l_Orden_Documento
            With oeMovDoc
                .Serie = txtSerieDoc.Value : .Numero = CType(txtNumeroDoc.Value, Int64)
                .Serie = FormatoDocumento(.Serie.Trim, 4) ': .Numero = FormatoDocumento(.Numero.Trim, 10)
                .TipoOperacion = "MOV"
                .IdTipoDocumento = cboDocumentoAlmacen.Value
                .IdMoneda = "1CH01"
            End With
            'With griListaDocumentoCompra
            '    .DataSource = olMovimientoDocumento.ListarDocumentosPorCompras(oeMovDoc)
            '    .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            '    .DisplayLayout.Bands(0).Columns("IndServicioMaterial").Hidden = True
            '    .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            'End With+
            lr_ConfigurarGrillas(olMovimientoDocumento.ListarDocumentosPorCompras(oeMovDoc))
            With griListaDocumentoCompra
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                    oeOrdDoc.IdDocumento = .ActiveRow.Cells("Id").Value
                    oeOrdDoc.TipoOperacion = "Z"
                    oeOrdDoc = olOrdDoc.Obtener(oeOrdDoc)
                    Me.txt_NroOrden.Text = oeOrdDoc.IdOrden
                    Me.txtGlosaOC.Text = oeOrdDoc.UsuarioCreacion
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaDireccionesGrifo(IdEmpresa As String)
        Try
            oeDireccion = New e_Direccion
            oeDireccion.TipoOperacion = 1
            oeDireccion.IdTipoVia = IdEmpresa
            oeDireccion.Activo = True
            oeDireccion.Id = cboLugar.Value
            LimpiaCombos(cboDireccion)
            LlenarCombo(cboDireccion, "Via", olDireccion.Listar(oeDireccion), 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DescheckearTodosItemsCombo()
        Dim itemList As ICheckedItemList = DirectCast(Me.cboPlaca.Items.ValueList, ICheckedItemList)
        For i As Integer = 0 To Me.cboPlaca.Items.Count - 1
            itemList.SetCheckState(i, CheckState.Unchecked)
        Next
    End Sub

#End Region

#Region "Funciones"

    Private Function ValidarGasto() As Boolean
        Try
            Dim FechaActual As Date = ObtenerFechaServidor()
            'If cboProveedores.Text <> String.Empty And txtSerie.Text.Trim <> String.Empty And txtNumero.Text.Trim <> String.Empty And cboTipoDocumento.Text <> String.Empty Then
            '    Validar_ExistenciaComprobante()
            'End If
            If Not ValidarPeriodo() Then Return False
            If dtpFechaEmision.Value.Date > FechaActual.Date Then
                dtpFechaEmision.Focus()
                Throw New Exception("No Puede Guardar un Documento Mayor a la Fecha Actual")
            End If
            'If DateDiff(DateInterval.Month, dtpFechaEmision.Value, FechaActual) > 6 Then
            '    dtpFechaEmision.Focus()
            '    Throw New Exception("No Puede Ingresar Documento con mas 6 meses de Antiguedad")
            'End If
            'If cboGrupo.SelectedIndex = -1 Then
            '    cboGrupo.Focus()
            '    Throw New Exception("Seleccione Grupo")
            'End If
            If cboTipoGasto.SelectedIndex = -1 Then
                cboTipoGasto.Focus()
                Throw New Exception("Seleccione Tipo de Gasto")
            End If
            If cboFlujoCaja.SelectedIndex = -1 Then
                cboFlujoCaja.Focus()
                Throw New Exception("Seleccione Flujo de Caja")
            End If
            If cboTipoDocumento.SelectedIndex = -1 Then
                cboTipoDocumento.Focus()
                Throw New Exception("Seleccione Tipo de Documento")
            End If
            If cboTipoDocumento.Value <> "1CH000000062" Then
                'If txtSerie.Text = String.Empty Then Throw New Exception("Ingrese Serie del Documento")
                'If IsNumeric(txtSerie.Text) Then If CInt(txtSerie.Text) = 0 Then Throw New Exception("Error Serie de Documento")
                'If txtNumero.Text = String.Empty Then Throw New Exception("Ingrese Numero del Documento")
                'If IsNumeric(txtNumero.Text) Then If CInt(txtNumero.Text) = 0 Then Throw New Exception("Error Numero de Documento")    
                gfc_ValidarSerieDoc(txtSerie.Text.Trim, oeTipoDoc.Codigo)
                gfc_ValidarNumeroDoc(txtNumero.Text.Trim, oeTipoDoc.Codigo)
            End If
            If cboFlujoCaja.Value = "1CH000000085" Then 'COMBUSTIBLES
                If DecCantidadGalones.Value <= 0 Then
                    DecCantidadGalones.Focus()
                    Throw New Exception("Ingrese Cantidad de Galones del Consumo de Combustible")
                End If
                If cboMaterial.SelectedIndex = -1 Then
                    cboMaterial.Focus()
                    Throw New Exception("Seleccione Material")
                End If
                If cboLugar.SelectedIndex = -1 Then
                    cboLugar.Focus()
                    Throw New Exception("Seleccione Lugar del Grifo")
                End If
                If cboDireccion.SelectedIndex = -1 Then
                    cboDireccion.Focus()
                    Throw New Exception("Seleccione Dirección del Grifo")
                End If
            End If

            oeProveedor = New e_Proveedor
            oeProveedor.Id = cboProveedores.Value
            oeProveedor.Tipo = 0
            If oeProveedor.Id <> Nothing Then If Not loProveedor.Contains(oeProveedor) Then Throw New Exception("Seleccione Proveedor")
            If numTotal.Value = 0 Then
                numSubTotal.Focus()
                Throw New Exception("El Importe Tiene que ser Mayor a 0")
            End If
            If cboArea.SelectedIndex = -1 Then
                cboArea.Focus()
                Throw New Exception("Seleccione Area")
            End If
            If cboGastoFuncion.SelectedIndex = -1 Then
                cboGastoFuncion.Focus()
                Throw New Exception("Seleccione Gasto Función")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarPeriodo() As Boolean
        Try
            oePeriodo = New e_Periodo
            oePeriodo.Ejercicio = fecPeriodo.DateTime.Year
            oePeriodo.Mes = fecPeriodo.DateTime.Month
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If oePeriodo.Id = "" Then
                fecPeriodo.Focus()
                Throw New Exception("No Existe el Periodo: " & fecPeriodo.DateTime.Month.ToString)
            Else
                If oePeriodo.CierreCajaLiquidacion Then
                    fecPeriodo.Focus()
                    Throw New Exception("El periodo en CajaLiquidacion esta Cerrado: " & fecPeriodo.DateTime.Month.ToString)
                End If
            End If
            If oePeriodo.Ejercicio = dtpFechaEmision.Value.Year Then
                If oePeriodo.Mes < dtpFechaEmision.Value.Month Then
                    fecPeriodo.Focus()
                    Throw New Exception("No Puede Ingresar un Gasto a un Periodo Menor")
                End If
            ElseIf oePeriodo.Ejercicio < dtpFechaEmision.Value.Year Then
                fecPeriodo.Focus()
                Throw New Exception("No Puede Ingresar un Gasto a un Periodo Menor")
            End If
            'If oePeriodo.Id <> oePerGrupo.Id Then
            '    fecPeriodo.Focus()
            '    Throw New Exception("Periodo Seleccionado Diferente al Periodo del Grupo")
            'End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaGastoDuplicado(Documento As String, IdTipoDoc As String, IdProveedor As String) As Boolean
        Try
            If IdTipoDoc = "1CH000000062" Then Return True
            If loGastoOpe.Where(Function(i) i.TipoOperacion <> "E").Count > 0 Then
                For Each oe As e_GastoOperacion In loGastoOpe.Where(Function(i) i.TipoOperacion <> "E").ToList
                    If oe.SerieDoc + oe.NroDoc = Documento And oe.IdTipoDocumento = IdTipoDoc And oe.IdProveedor = IdProveedor Then
                        Throw New Exception("El Documento " + Documento + " ya ha Sido Registrado")
                    End If
                Next
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarGasto() As Boolean
        Try
            Dim loGastoOperacionMasivo As New List(Of e_GastoOperacion)
            loGastoOperacionMasivo.AddRange(loGastoOpe)
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If Not olGastoOpe.GuardaListaMasiva(loGastoOperacionMasivo, CtaCtblePublic, gs_PrefijoIdSucursal) Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function ValidarBusquedaDocumento() As Boolean
        Try
            If Me.cboDocumentoAlmacen.SelectedIndex = -1 Then
                Me.cboDocumentoAlmacen.Focus()
                Throw New Exception("Seleccione Tipo de Documento Por Favor")
            ElseIf Me.txtNumeroDoc.Text = "" Then
                Me.txtNumeroDoc.Focus()
                Throw New Exception("Escriba el Numero de Documento Por Favor")
            ElseIf Me.txtSerieDoc.Text = "" Then
                Me.txtSerieDoc.Focus()
                Throw New Exception("Escriba el Numero de Serie Por Favor")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class