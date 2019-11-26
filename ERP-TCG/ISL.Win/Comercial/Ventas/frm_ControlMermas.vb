'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ControlMermas
    Inherits frm_MenuPadre

#Region "Inicializacion del Formulario"

    'Private Xpos As Integer
    'Private Ypos As Integer

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ControlMermas = Nothing
    Private Shared Operacion As String
    Private Estado As String
    ''' <summary>
    ''' Instancia unica de Formulario: frm_DemandaRapida
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre

        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ControlMermas()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim oeIngresoSalida As New e_ControlMerma
    Dim olIngresoSalida As New l_ControlMerma
    Dim ListaIngresoSalida As New List(Of e_ControlMerma)

    Dim oeOtrosIngresos As New e_OtrosIngresos

    Dim oeEstado As New e_Estado
    Dim olEstado As New l_Estado
    Dim ListaEstado As New List(Of e_Estado)

    Dim _ingresando_datos As Boolean = False

    Dim olCombo As New l_Combo
    Dim oeCombo As New e_Combo


    Dim oeGrupoSancion As New e_GrupoSancion
    Dim olGrupoSancion As New l_GrupoSancion

    Dim oeOperacion As New e_Operacion
    Dim olOperacion As New l_Operacion

    Dim oeViaje As New e_Viaje
    Dim ListaViaje As New List(Of e_Viaje)

    Dim oeMovimientoMermas As New e_MovimientoMermas
    Dim olMovimientoMermas As New l_MovimientoMermas
    Dim loMovimientoMermas As New List(Of e_MovimientoMermas)

    Dim oeAlmacenMermas As New e_AlmacenMermas
    Dim olAlmacenMermas As New l_AlmacenMermas
    Dim ListaAlmacenMermas As New List(Of e_AlmacenMermas)

    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim olCuentaCorriente As New l_CuentaCorriente
    Dim loCuentaCorriente As New List(Of e_CuentaCorriente)

    Dim oeCaja As New e_Caja
    Dim olCaja As New l_Caja
    Dim loCaja As New List(Of e_Caja)

    Dim oeCajaUsuario As New e_CajaUsuario
    Dim olCajaUsuario As New l_CajaUsuario

    Private oeAsientoModelo, oeAsientoModeloMerma As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)

    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)
    Private dtReferencia As New DataTable

    Dim idCajaCentro As String = String.Empty

    Private olTrabajadorSeguridad As New l_TrabajadorSeguridad

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Try
                If gUsuarioSGI.oeArea.Nombre = gNombreAreaCoordinacionSupervisionOperacion Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    Operacion = "Editar"
                    Inicializar()
                    oeMovimientoMermas = New e_MovimientoMermas
                    ListaIngresoSalida = New List(Of e_ControlMerma)
                    ListaAlmacenMermas = New List(Of e_AlmacenMermas)
                    oeMovimientoMermas.ListaControlMermas = New List(Of e_ControlMerma)
                    Select Case ficListar.SelectedTab.Index
                        Case 0
                            LimpiaGrid(griDetalleMermasI, ogdIngSal)
                            LimpiaGrid(griAlmacenMermasI, ogdAlmMer)
                            LimpiaGrid(griViajes, ogdViajes)
                            MostrarTabs(1, ficCtrlMerma, 1)
                            MostrarTabs(0, ficIngresoSalida, 0)
                            griDetalleMermasI.DataSource = ListaIngresoSalida
                            griAlmacenMermasI.DataSource = ListaAlmacenMermas
                            oeMovimientoMermas.TipoOperacion = ""
                            oeMovimientoMermas.Id = griListaIngresos.ActiveRow.Cells("IdMovimientoMermas").Value
                            oeMovimientoMermas = olMovimientoMermas.Obtener(oeMovimientoMermas)
                            With oeMovimientoMermas
                                txtIdMovimientoI.Text = .Id
                                fecFechaI.Value = .Fecha
                                txtGlosaI.Text = .Glosa
                                txtTotalI.Text = .Total
                            End With
                            oeIngresoSalida = New e_ControlMerma
                            oeIngresoSalida.TipoOperacion = "0"
                            oeIngresoSalida.IdMovimientoMermas = oeMovimientoMermas.Id
                            griDetalleMermasI.DataSource = olIngresoSalida.Listar(oeIngresoSalida)

                        Case 1
                            If griListaSalidas.ActiveRow.Cells("Numero").Value <> "COBRADO" Then
                                LimpiaGrid(griDetalleMermasS, ogdIngSal)
                                LimpiaGrid(griAlmacenMermasS, ogdAlmMer)
                                MostrarTabs(1, ficCtrlMerma, 1)
                                MostrarTabs(1, ficIngresoSalida, 1)
                                griDetalleMermasS.DataSource = ListaIngresoSalida
                                griAlmacenMermasS.DataSource = ListaAlmacenMermas
                                CalcularTotales(griDetalleMermasS, "PrecioUnitario", "PrecioTotal")
                                oeMovimientoMermas.TipoOperacion = ""
                                oeMovimientoMermas.Id = griListaSalidas.ActiveRow.Cells("IdMovimientoMermas").Value
                                oeMovimientoMermas = olMovimientoMermas.Obtener(oeMovimientoMermas)
                                With oeMovimientoMermas
                                    txtIdMovimientoS.Text = .Id
                                    fecFechaS.Value = .Fecha
                                    cboPersonaS.Value = .IdPersona
                                    txtIdSancion.Text = .IdSancion
                                    txtGlosaS.Text = .Glosa
                                    cboTipoPagoS.SelectedIndex = .TipoPago
                                    txtSaldoS.Text = .Saldo
                                    txtPorcentajeDescuentoS.Text = .PorcentajeDescuento
                                    txtSubTotalS.Text = .SubTotal
                                    txtDescuentoS.Text = .Descuento
                                    txtTotalS.Text = .Total
                                End With
                                oeIngresoSalida = New e_ControlMerma
                                oeIngresoSalida.TipoOperacion = "1"
                                oeIngresoSalida.IdMovimientoMermas = oeMovimientoMermas.Id
                                griDetalleMermasS.DataSource = olIngresoSalida.Listar(oeIngresoSalida)
                            Else
                                Throw New Exception("Movimiento no se puede editar ya fue COBRADO")
                            End If

                        Case Else
                            Exit Select
                    End Select
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                End If
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            Finally
                Windows.Forms.Cursor.Current = Cursors.Default
                Cursor.Show()
            End Try
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            If gUsuarioSGI.oeArea.Nombre = gNombreAreaCoordinacionSupervisionOperacion Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                Operacion = "Nuevo"
                Inicializar()
                oeMovimientoMermas = New e_MovimientoMermas
                ListaIngresoSalida = New List(Of e_ControlMerma)
                ListaAlmacenMermas = New List(Of e_AlmacenMermas)
                oeMovimientoMermas.ListaControlMermas = New List(Of e_ControlMerma)
                Select Case ficListar.SelectedTab.Index
                    Case 0
                        LimpiaGrid(griDetalleMermasI, ogdIngSal)
                        LimpiaGrid(griAlmacenMermasI, ogdAlmMer)
                        LimpiaGrid(griViajes, ogdViajes)
                        MostrarTabs(1, ficCtrlMerma, 1)
                        MostrarTabs(0, ficIngresoSalida, 0)
                        griDetalleMermasI.DataSource = ListaIngresoSalida
                        griAlmacenMermasI.DataSource = ListaAlmacenMermas

                    Case 1
                        LimpiaGrid(griDetalleMermasS, ogdIngSal)
                        LimpiaGrid(griAlmacenMermasS, ogdAlmMer)
                        MostrarTabs(1, ficCtrlMerma, 1)
                        MostrarTabs(1, ficIngresoSalida, 1)
                        griDetalleMermasS.DataSource = ListaIngresoSalida
                        griAlmacenMermasS.DataSource = ListaAlmacenMermas
                        CalcularTotales(griDetalleMermasS, "PrecioUnitario", "PrecioTotal")
                    Case Else
                        Exit Select
                End Select
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try

    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarMovimientoMermas() Then
                MostrarTabs(0, ficCtrlMerma, 2)
                Listar()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarMovimientoMermas() Then
                        MostrarTabs(0, ficCtrlMerma, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                    Else
                        _ingresando_datos = True
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficCtrlMerma, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                Case Windows.Forms.DialogResult.Cancel
                    _ingresando_datos = True
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
        Catch ex As Exception
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficListar.SelectedTab.Index
                Case 0
                    If griListaIngresos.Rows.Count > 0 Then
                        Exportar_Excel(griListaIngresos)
                    End If
                Case 1
                    If griListaSalidas.Rows.Count > 0 Then
                        Exportar_Excel(griListaSalidas)
                    End If
                Case 2
                    If griAlmacenMermas.Rows.Count > 0 Then
                        Exportar_Excel(griAlmacenMermas)
                    End If
                Case 3
                    If griMovimiento.Rows.Count > 0 Then
                        Exportar_Excel(griMovimiento)
                    End If

            End Select
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            Select Case ficListar.SelectedTab.Index
                Case 1
                    If griListaSalidas.Selected.Rows.Count > 0 Then
                        Dim frm As New frm_VentaMerma
                        Dim id As String = griListaSalidas.ActiveRow.Cells("Serie").Value
                        frm.CargarDatos(id)
                        frm.ShowDialog()
                        ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
                    End If
                Case 3

            End Select     
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        MyBase.Eliminar()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ControlMermas_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_ControlMermas_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case ficCtrlMerma.SelectedTab.Index
            Case 0
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                Select Case ficListar.SelectedTab.Index
                    Case 1
                        ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
                    Case 2
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                    Case 3
                        ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
                End Select
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_ControlMermas_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieI.Validated
        If txtSerieI.Text <> "" Then
            txtSerieI.Text = FormatoDocumento(txtSerieI.Text, 4)
        End If
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroI.Validated
        If txtNumeroI.Text <> "" Then
            txtNumeroI.Text = FormatoDocumento(txtNumeroI.Text, 10)
        End If
    End Sub

    Private Sub txtMateriales_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMateriales.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnBuscarMaterial.PerformClick()
        End If
    End Sub

    Private Sub btnListarViajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarViajes.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            LimpiaGrid(griViajes, ogdViajes)
            With oeViaje
                .TipoOperacion = "0"
                .ViajeVacio = 2
                .FechaDesde = fecDesdeViaje.Value.ToString
                .FechaHasta = fecHastaViaje.Value.ToString
                .UsuarioCreacion = ""
                .Zona = ""
                .Centro = cboCentro.Value
                .IndMotriz = 1
                .IdTracto = cboTractoLista.Value
            End With
            griViajes.DataSource = olOperacion.ListarViaje(oeViaje)
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub frm_ControlMermas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Inicializar()
            Tiempo1.Enabled = False
            InicializaTiempo()
            LlenaCombos()
            RangoFechaInicializa()
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EVALUACION GRUPOS") Then
                griMovimiento.DisplayLayout.Bands(0).Columns("Total").CellActivation = Activation.AllowEdit
                griMovimiento.DisplayLayout.Bands(0).Columns("Total").CellClickAction = CellClickAction.EditAndSelectText
                griMovimiento.DisplayLayout.Bands(0).Columns("Mod").Hidden = False
                griMovimiento.DisplayLayout.Bands(0).Columns("Mod").Style = ColumnStyle.Button
            Else
                griMovimiento.DisplayLayout.Bands(0).Columns("Total").CellActivation = Activation.NoEdit
                griMovimiento.DisplayLayout.Bands(0).Columns("Total").CellClickAction = CellClickAction.RowSelect
                griMovimiento.DisplayLayout.Bands(0).Columns("Mod").Hidden = True
                griMovimiento.DisplayLayout.Bands(0).Columns("Mod").Style = ColumnStyle.Default
            End If
            If gUsuarioSGI.oeArea.Nombre = gNombreAreaCoordinacionSupervisionOperacion Then
                ficListar.Tabs(0).Selected = True
                ficListar.Tabs(0).Enabled = True
                ficListar.Tabs(1).Enabled = True
                ficListar.Tabs(2).Enabled = True
                ficListar.Tabs(3).Enabled = False
            ElseIf gUsuarioSGI.oeArea.Nombre = gNombreAreaCaja Then
                ficListar.Tabs(0).Enabled = False
                ficListar.Tabs(1).Enabled = False
                ficListar.Tabs(2).Enabled = False
                ficListar.Tabs(3).Enabled = True
                ficListar.Tabs(3).Selected = True
                DatosTesoreria()
            ElseIf gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
                ficListar.Tabs(0).Enabled = True
                ficListar.Tabs(1).Enabled = True
                ficListar.Tabs(2).Enabled = True
                ficListar.Tabs(3).Enabled = True
                ficListar.Tabs(0).Selected = True
            End If
            MostrarTabs(0, ficCtrlMerma, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try      
    End Sub

    Private Sub cboTipoPago_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoPagoS.ValueChanged
        Try
            Select Case cboTipoPagoS.SelectedIndex
                Case 0
                    lblMontoAmortizadoS.Visible = False
                    txtSaldoS.Visible = False
                    lblPorcentajeDescuentoS.Visible = True
                    txtPorcentajeDescuentoS.Visible = True
                    txtSaldoS.Text = 0.0
                    txtPorcentajeDescuentoS.Text = 0.0
                    txtDescuentoS.Text = 0.0
                    'Case 1
                    '    lblMontoAmortizadoS.Visible = False
                    '    txtSaldoS.Visible = False
                    '    lblPorcentajeDescuentoS.Visible = True
                    '    txtPorcentajeDescuentoS.Visible = True
                    '    txtSaldoS.Text = 0.0
                    '    txtPorcentajeDescuentoS.Text = 0.0
                Case 2
                    lblMontoAmortizadoS.Visible = True
                    txtSaldoS.Visible = True
                    lblPorcentajeDescuentoS.Visible = False
                    txtPorcentajeDescuentoS.Visible = False
                    txtSaldoS.Text = 0.0
                    txtPorcentajeDescuentoS.Text = 0.0
                    txtDescuentoS.Text = 0.0

                Case Else
                    lblMontoAmortizadoS.Visible = False
                    txtSaldoS.Visible = False
                    lblPorcentajeDescuentoS.Visible = False
                    txtPorcentajeDescuentoS.Visible = False
                    txtSaldoS.Text = 0.0
                    txtPorcentajeDescuentoS.Text = 0.0
                    txtDescuentoS.Text = 0.0
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevoProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frm_Material
        frm.MaterialMerma = "1"
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub Grilla1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Editar()
    End Sub

    Private Sub btnAgregarPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frm_Persona
        frm.PersonaMerma = "1"
        frm.ShowDialog()
    End Sub

    Private Sub decFactor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFactorCovI.ValueChanged
        If IsDBNull(txtFactorCovI.Value) Then txtFactorCovI.Value = 1
        If txtFactorCovI.Value = 0 Then
            txtFactorCovI.Value = 1
            Throw New Exception("El Factor no Puede ser Igual a 0")
        End If

    End Sub

    Private Sub cboPersona_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboPersonaS.EditorButtonClick
        Dim frm As New frm_Persona
        frm.PersonaMerma = "1"
        frm.ShowDialog()
    End Sub

    Private Sub cboMaterial_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboMaterialI.EditorButtonClick
        Dim frm As New frm_Material
        frm.MaterialMerma = "1"
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        LlenarComboMaestro(cboMaterialI, MaterialesPublic.Where(Function(i) i.Descripcion.Trim = "MERMA").ToList, -1)
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub verTracto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verTracto.CheckedChanged
        If verTracto.Checked Then
            cboTractoLista.Enabled = verTracto.Checked
            cboTractoLista.Focus()
        Else
            cboTractoLista.Enabled = verTracto.Checked
            cboTractoLista.Text = ""
        End If
    End Sub

    Private Sub btnIngresoMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarI.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeMovimientoMermas.ListaControlMermas = griDetalleMermasI.DataSource
            If ValidaDetalleIngreso() Then
                With oeIngresoSalida
                    .Id = ""
                    .IdMovimientoMermas = ""
                    .IndIngresoSalida = 0
                    .IdClientePersona = cboClienteI.Value
                    .Fecha = fecFechaI.Value
                    .IdViaje = txtIdViajeI.Text.Trim
                    .IdMaterial = cboMaterialI.Value
                    .ClientePersona = cboClienteI.Text
                    .Material = cboMaterialI.Text
                    .UnidadCantidad = cboUnidadI.Text.Trim
                    .Cantidad = txtCantidadI.Value
                    .PrecioUnitario = txtPrecioAlmacenI.Value
                    .PrecioTotal = .Cantidad * .PrecioUnitario
                    .Saldo = 0
                    .FactorConversion = txtFactorCovI.Value
                    .Glosa = txtNroViajeI.Text.Trim
                    .IdEstado = cboEstadoI.Value
                    .Estado = cboEstadoI.Text
                    .Serie = txtSerieI.Text.Trim
                    .Numero = txtNumeroI.Text.Trim
                    .PrecioFactura = txtPrecioFacturaI.Value
                    .IndCobro = 0
                    .TipoPago = 0
                    .UsuarioCreacion = gUsuarioSGI.Id
                End With
                oeMovimientoMermas.ListaControlMermas.Add(oeIngresoSalida)
                griDetalleMermasI.DataBind()
                oeIngresoSalida = New e_ControlMerma
                CalcularSubTotal()
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnListaMermas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaMermasI.Click
        uebAlmacenMermas.Expanded = True
        ListarAlmacenMermas()
        griAlmacenMermasI.DataSource = ListaAlmacenMermas
    End Sub

    Private Sub btnListaMermasS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaMermasS.Click
        ListarAlmacenMermas()
        griAlmacenMermasS.DataSource = ListaAlmacenMermas
    End Sub

    Private Sub frm_ControlMermas_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griAlmacenMermasS_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griAlmacenMermasS.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "UsuarioCreacion"
                    oeMovimientoMermas.ListaControlMermas = griDetalleMermasS.DataSource
                    If ValidaDetalleSalidas() Then
                        With oeIngresoSalida
                            .Id = ""
                            .IdMovimientoMermas = ""
                            .IndIngresoSalida = 1
                            .IdClientePersona = cboPersonaS.Value
                            .Material = Trim(griAlmacenMermasS.ActiveRow.Cells("Material").Value)
                            .Fecha = fecFechaS.Value
                            .IdViaje = ""
                            .IdMaterial = RTrim(griAlmacenMermasS.ActiveRow.Cells("IdMaterial").Value)
                            .UnidadCantidad = RTrim(griAlmacenMermasS.ActiveRow.Cells("IdUnidadMedida").Value)
                            .Cantidad = RTrim(griAlmacenMermasS.ActiveRow.Cells("FactorConversion").Value)
                            .PrecioUnitario = RTrim(griAlmacenMermasS.ActiveRow.Cells("PrecioVenta").Value)
                            .PrecioTotal = .Cantidad * .PrecioUnitario
                            .Saldo = 0
                            .FactorConversion = 1
                            .Glosa = ""
                            .IdEstado = "1CH00021"
                            .Serie = ""
                            .Numero = ""
                            .PrecioFactura = .PrecioTotal
                            .IndCobro = 0
                            .TipoPago = cboTipoPagoS.SelectedIndex
                            .UsuarioCreacion = gUsuarioSGI.Id
                        End With
                        oeMovimientoMermas.ListaControlMermas.Add(oeIngresoSalida)
                        griDetalleMermasS.DataBind()
                        oeIngresoSalida = New e_ControlMerma
                        CalcularSubTotal()
                        griAlmacenMermasS.ActiveRow.CellAppearance.BackColor = Me.ColorAltualizar.Color
                    End If

            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griAlmacenMermasS_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griAlmacenMermasS.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griAlmacenMermasI_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griAlmacenMermas_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griAlmacenMermas.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griMovimiento_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griMovimiento.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub txtPorcentajeDescuentoS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPorcentajeDescuentoS.TextChanged
        If cboTipoPagoS.SelectedIndex = 0 Then
            If IsDBNull(txtPorcentajeDescuentoS.Value) Then txtPorcentajeDescuentoS.Value = 0
            If txtPorcentajeDescuentoS.Value <> 0 Then
                txtDescuentoS.Value = txtSubTotalS.Value * txtPorcentajeDescuentoS.Value / 100
                'txtTotalS.Value = txtSubTotalS.Value - txtDescuentoS.Value
            Else
                txtDescuentoS.Value = 0
                If Not IsDBNull(txtSubTotalS.Value) Then
                    CalcularSubTotal()
                End If
            End If
        End If
    End Sub

    Private Sub griViajes_ClickCell(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles griViajes.ClickCell, griAlmacenMermasI.ClickCell
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ugb_Espera.Visible = True
            griViajes.UpdateData()
            If griViajes.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "Seleccion"
                        With griViajes.ActiveRow
                            If .Cells("Seleccion").Value = True Then
                                txtIdViajeI.Text = .Cells("Id").Value
                                txtNroViajeI.Text = .Cells("Codigo").Value
                                cboClienteI.Text = .Cells("Cliente").Value
                            Else
                                txtIdViajeI.Text = ""
                                txtNroViajeI.Text = ""
                                cboClienteI.Text = ""
                            End If
                        End With
                End Select
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griViajes_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajes.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griViajes_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajes.CellChange
        griViajes.UpdateData()
    End Sub

    Private Sub griViajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griViajes.Click
        If griViajes.Rows.Count > 0 Then
            With griViajes.ActiveRow
                txtIdViajeI.Text = ""
                txtNroViajeI.Text = ""
                cboClienteI.Text = ""
            End With
        End If
    End Sub

    Private Sub txtPrecioFacturaI_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioFacturaI.Validated
        txtPrecioAlmacenI.Value = txtPrecioFacturaI.Value
    End Sub

    Private Sub MenuTesoreria_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuTesoreria.Opening
        Try
            MenuTesoreria.Items("Cobrar").Visible = False
            MenuTesoreria.Items("VerVenta").Visible = False
            If griMovimiento.Selected.Rows.Count > 0 Then
                MenuTesoreria.Items("VerVenta").Visible = True
            End If
            If loMovimientoMermas.Where(Function(i) i.Seleccion = True).ToList.Count > 0 Then
                MenuTesoreria.Items("Cobrar").Visible = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Cobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cobrar.Click
        Try
            'If ValidaUsuarioCajaCentro(idCajaCentro, ObtenerCentro.Id, gUsuarioSGI.IdTrabajador) Then
            Dim listaaux As New List(Of e_MovimientoMermas)
            Dim idTrabajador As String = ""
            Dim id As String = ""
            Dim Trabajador As String = ""
            Dim flag As Boolean = False
            listaaux.AddRange(loMovimientoMermas.Where(Function(i) i.Seleccion = True).ToList)
            For Each movmeras As e_MovimientoMermas In listaaux
                If id = "" Then id = movmeras.IdPersona
                idTrabajador = movmeras.IdPersona
                Trabajador = movmeras.Trabajador
                Exit For
            Next
            If listaaux.Where(Function(i) i.IdPersona <> id).ToList.Count > 0 Then Throw New Exception("Solo Puede Cobrar a un Trabajador a la vez. Verificar")
            If MessageBox.Show("Se efectuara el cobro por un Total: " & listaaux.Sum(Function(i) i.Saldo) & " Al Personal: " & Trabajador, _
                               "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                For Each movmer As e_MovimientoMermas In listaaux
                    movmer.TipoOperacion = "C"
                    movmer.UsuarioCreacion = gUsuarioSGI.Id
                    movmer.ListaControlMermas = New List(Of e_ControlMerma)
                Next
                Dim olPeriodo As New l_Periodo
                Dim oePeriodo As New e_Periodo
                Dim Fecha As Date = ObtenerFechaServidor()
                oePeriodo.Ejercicio = Date.Parse(Fecha).Year
                oePeriodo.Mes = Date.Parse(Fecha).Month
                oePeriodo = olPeriodo.Obtener(oePeriodo)
                oeOtrosIngresos = New e_OtrosIngresos
                With oeOtrosIngresos
                    .TipoOperacion = "I"
                    .IdCentro = ObtenerCentro(gs_PrefijoIdSucursal).Id
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .IdCuentaCorriente = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
                    .IdCaja = idCajaCentro
                    .IdTrabajador = idTrabajador
                    .IdConceptoIngresos = "1SI000000019"
                    .Importe = listaaux.Sum(Function(i) i.Saldo)
                    .Fecha = Fecha
                    .IdPeriodo = oePeriodo.Id
                    .IndIngresoEgreso = 1
                    .TipoReferencia = "VENTA DE MERMA"
                    .Glosa = "VENTA DE MERMA " & " // " & Trabajador
                    .IdCuentaBancaria = ""
                    .TipoCambio = TipoCambio(Fecha, True)(0)
                    ObtenerAsientoModelo(oePeriodo.Ejercicio)
                End With
                ImprimirVoucher(olMovimientoMermas.Cobrar(listaaux, oeOtrosIngresos))
                Consultar(True)
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            End If
            'Else
            'Throw New Exception("No puede Realizar Movimientos en esta Sede")
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub VerVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerVenta.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeIngresoSalida = New e_ControlMerma
            oeIngresoSalida.TipoOperacion = "1"
            oeIngresoSalida.IdMovimientoMermas = griMovimiento.ActiveRow.Cells("Id").Value
            griListaSalidas.DataSource = olIngresoSalida.Listar(oeIngresoSalida)
            CalcularTotales(griListaSalidas, "PrecioUnitario", "PrecioTotal")
            Exportar_Excel(griListaSalidas)
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub txtSaldoS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSaldoS.TextChanged
        'If IsDBNull(txtSaldoS.Value) Then txtSaldoS.Value = 0.0
        'If cboTipoPagoS.SelectedIndex = 2 Then
        '    If txtSaldoS.Value <> 0 Then
        '        txtTotalS.Text = txtSubTotalS.Value - txtSaldoS.Value
        '    Else
        '        If Not IsDBNull(txtSubTotalS.Value) Then
        '            CalcularSubTotal()
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub griViajes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griViajes.DoubleClick
        If griViajes.Rows.Count > 0 Then
            With griViajes.ActiveRow
                txtIdViajeI.Text = .Cells("Id").Value
                txtNroViajeI.Text = .Cells("Codigo").Value
                cboClienteI.Text = .Cells("Cliente").Value
            End With
        End If
        expViaje.Expanded = False
        LimpiaGrid(griViajes, ogdViajes)
    End Sub

    Private Sub griDetalleMermasS_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetalleMermasS.CellChange
        griDetalleMermasS.UpdateData()
    End Sub

    Private Sub cboClienteI_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClienteI.Validated
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim IdCombo As New e_Combo
            IdCombo.Id = cboClienteI.Value
            IdCombo.Tipo = 0
            If IdCombo.Id <> Nothing Then
                If Not ClientesPublic.Contains(IdCombo) Then
                    cboClienteI.Focus()
                    Throw New Exception("Seleccione nuevamente el Cliente")
                End If
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cboPersonaS_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPersonaS.Validated
        Try
            Dim IdCombo As New e_Combo
            IdCombo.Id = cboPersonaS.Value
            If TrabajadorPublic.Contains(IdCombo) = False Then
                cboPersonaS.Focus()
                Throw New Exception("Seleccione nuevamente el Personal")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub ficListar_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficListar.SelectedTabChanged
        Try
            Select Case ficListar.SelectedTab.Index
                Case 0
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                Case 1
                    ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
                Case 2
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Case 3
                    ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griDetalleMermasS_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDetalleMermasS.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaIngresos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaIngresos.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaSalidas_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaSalidas.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True

    End Sub

    Private Sub griDetalleMermasI_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDetalleMermasI.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griAlmacenMermasI_ClickCellButton(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griAlmacenMermasI.ClickCellButton
        Try
            AgregarMaterialIngreso(griAlmacenMermasI.ActiveRow.Cells("IdMaterial").Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaIngresos_ClickCellButton(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaIngresos.ClickCellButton
        Try
            If ActualizarIngreso() Then
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griMovimiento_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMovimiento.CellChange
        Try
            griMovimiento.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griMovimiento_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMovimiento.AfterCellUpdate
        Try
            With griMovimiento.ActiveRow
                Dim ind As Boolean = .Cells("IndCobro").Value
                If .Cells("Seleccion").Value = True Then
                    If .Cells("IndCobro").Value = 1 Then
                        .Cells("Seleccion").Value = False
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griMovimiento_MouseEnterElement(sender As Object, e As Infragistics.Win.UIElementEventArgs) Handles griMovimiento.MouseEnterElement
        Try
            If griMovimiento.Rows.Count > 0 Then
                Dim celda As UltraGridCell = TryCast(e.Element.GetContext(GetType(UltraGridCell), True), UltraGridCell)
                If Not celda Is Nothing Then
                    If celda.Column.Key = "Mod" AndAlso Not IsDBNull(celda.Value) Then
                        Dim tipInfo As New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Modificacion de Precio para Venta", Infragistics.Win.ToolTipImage.Default, "Modificar Precio", Infragistics.Win.DefaultableBoolean.True)
                        utp1.SetUltraToolTip(griMovimiento, tipInfo)
                        utp1.ShowToolTip(griMovimiento)
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griMovimiento_ClickCellButton(sender As Object, e As CellEventArgs) Handles griMovimiento.ClickCellButton
        Try
            If ActualizarPrecioVenta() Then
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAlmacenMermas_ClickCellButton(sender As Object, e As CellEventArgs) Handles griAlmacenMermas.ClickCellButton
        Try
            Select Case e.Cell.Column.Key
                Case "UsuarioCreacion"
                    If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "CAMBIAR PRECIO MERMAS") Then
                        oeAlmacenMermas = New e_AlmacenMermas
                        With griAlmacenMermas.Rows(e.Cell.Row.Index)
                            oeAlmacenMermas.Id = .Cells("Id").Value
                            oeAlmacenMermas.PrecioVenta = .Cells("PrecioVenta").Value
                        End With
                        oeAlmacenMermas.TipoOperacion = "A"
                        oeAlmacenMermas.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olAlmacenMermas.Guardar(oeAlmacenMermas) Then
                            mensajeEmergente.Confirmacion("Se Modifico el Precio Correctamente")

                        End If
                    Else
                        Throw New Exception("No Tiene Permisos Para Cambiar el Precio en Mermas")
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAlmacenMermas_CellChange(sender As Object, e As CellEventArgs) Handles griAlmacenMermas.CellChange
        Try
            griAlmacenMermas.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        txtIdMovimientoI.Text = ""
        txtIdMovimientoS.Text = ""
        txtIdSancion.Text = ""
        uebAlmacenMermas.Expanded = False
        fecFechaI.Value = Date.Today
        txtNroViajeI.Text = String.Empty
        txtGlosaI.Text = ""
        cboClienteI.SelectedIndex = -1
        cboMaterialI.SelectedIndex = -1
        cboTractoLista.SelectedIndex = -1
        cboEstadoI.SelectedIndex = 0
        cboPersonaS.SelectedIndex = -1
        cboUnidadI.SelectedIndex = 0
        txtCantidadI.Value = 1.0
        txtPrecioAlmacenI.Value = 0
        txtNumeroI.Text = String.Empty
        txtFactorCovI.Value = 1.0
        txtSerieI.Text = String.Empty
        txtGlosaS.Text = String.Empty
        txtMateriales.Text = String.Empty
        txtPrecioFacturaI.Value = 0.0
        cboTipoPagoS.SelectedIndex = -1
        txtTotalI.Value = 0.0
        txtTotalS.Value = 0.0
        txtSubTotalS.Value = 0.0
        txtSaldoS.Value = 0.0
        txtDescuentoS.Value = 0.0
        txtPorcentajeDescuentoS.Value = 0.0
        oeMovimientoMermas.ListaControlMermas = New List(Of e_ControlMerma)
        lblMontoAmortizadoS.Visible = False
        txtSaldoS.Visible = False
        lblPorcentajeDescuentoS.Visible = False
        txtPorcentajeDescuentoS.Visible = False
    End Sub

    Public Sub LlenaCombos()
        Try
            LlenarCombo(cboTractoLista, "Nombre", TractoPublic, -1)
            LlenarComboMaestro(cboClienteI, ClientesPublic, -1)
            LlenarComboMaestro(cboCentro, CentroPublic, 0)
            oeEstado = New e_Estado
            oeEstado.Nombre = "MERMAS"
            ListaEstado.AddRange(olEstado.Listar(oeEstado))
            LlenarCombo(cboEstadoI, "Nombre", ListaEstado.OrderBy(Function(item) item.Nombre).ToList, 0)
            LlenarComboMaestro(cboMaterialI, MaterialesPublic, -1)
            LlenarCombo(cboPersonaS, "Nombre", TrabajadorPublic, -1)
            Dim oeCentro As New e_Centro
            Dim olCentro As New l_Centro
            Dim leCentro As New List(Of e_Centro)
            leCentro.AddRange(olCentro.Listar(oeCentro))
            LlenarCombo(cboCentroL, "Nombre", leCentro, 0)
            oeCentro = New e_Centro
            oeCentro = ObtenerCentro(gs_PrefijoIdSucursal)
            cboCentroL.Value = oeCentro.Id
            If gUsuarioSGI.oeArea.Nombre <> gNombreAreaCoordinacionSupervisionOperacion Then
                DatosTesoreria()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub Listar()
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ugb_Espera.Visible = True
            oeIngresoSalida = New e_ControlMerma
            oeMovimientoMermas = New e_MovimientoMermas
            loMovimientoMermas = New List(Of e_MovimientoMermas)
            oeIngresoSalida.IdCentro = cboCentroL.Value
            Select Case ficListar.SelectedTab.Index
                Case 0
                    oeIngresoSalida.TipoOperacion = "0"
                    oeIngresoSalida.FechaDesde = fecDesde.Value.ToString
                    oeIngresoSalida.FechaHasta = fecHasta.Value.ToString
                    griListaIngresos.DataSource = olIngresoSalida.Listar(oeIngresoSalida)
                    CalcularTotales(griListaIngresos, "PrecioUnitario", "PrecioTotal", "PrecioFactura")
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                Case 1
                    oeIngresoSalida.TipoOperacion = "1"
                    oeIngresoSalida.FechaDesde = fecDesde.Value.ToString
                    oeIngresoSalida.FechaHasta = fecHasta.Value.ToString
                    griListaSalidas.DataSource = olIngresoSalida.Listar(oeIngresoSalida)
                    CalcularTotales(griListaSalidas, "PrecioUnitario", "PrecioTotal", "IdViaje")
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaSalidas.Rows
                        Select Case fila.Cells("Numero").Value
                            Case "POR COBRAR"
                                fila.CellAppearance.BackColor = Me.colorPorCobrar.Color
                            Case "COBRADO"
                                fila.CellAppearance.BackColor = Me.colorCobrado.Color
                        End Select
                        Select Case fila.Cells("IdEstado").Value
                            Case "CONTADO"
                                fila.Cells("IdEstado").Appearance.BackColor = Me.colorContado.Color
                            Case "CREDITO"
                                fila.Cells("IdEstado").Appearance.BackColor = Me.colorCredito.Color
                            Case "AMORTIZADO"
                                fila.Cells("IdEstado").Appearance.BackColor = Me.ColorAmortizado.Color
                            Case "AL GASTO"
                                fila.Cells("IdEstado").Appearance.BackColor = Me.colorAlGasto.Color
                        End Select
                    Next
                    ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
                Case 2
                    ListarAlmacenMermas()
                    griAlmacenMermas.DataSource = ListaAlmacenMermas
                    CalcularTotales(griAlmacenMermas, "PrecioVenta", "Stock")
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Case 3
                    oeMovimientoMermas.TipoOperacion = "1"
                    oeMovimientoMermas.FechaDesde = fecDesde.Value.ToString
                    oeMovimientoMermas.FechaHasta = fecHasta.Value.ToString
                    oeMovimientoMermas.IdCentro = cboCentroL.Value
                    loMovimientoMermas.AddRange(olMovimientoMermas.Listar(oeMovimientoMermas))
                    griMovimiento.DataSource = loMovimientoMermas
                    CalcularTotales(griMovimiento, "SubTotal", "Saldo", "Descuento", "Total")
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griMovimiento.Rows
                        Select Case fila.Cells("Serie").Value
                            Case "POR COBRAR"
                                fila.CellAppearance.BackColor = Me.colorPorCobrar.Color
                            Case "COBRADO"
                                fila.CellAppearance.BackColor = Me.colorCobrado.Color
                        End Select
                        Select Case fila.Cells("IdEstado").Value
                            Case "CONTADO"
                                fila.Cells("IdEstado").Appearance.BackColor = Me.colorContado.Color
                            Case "CREDITO"
                                fila.Cells("IdEstado").Appearance.BackColor = Me.colorCredito.Color
                            Case "AMORTIZADO"
                                fila.Cells("IdEstado").Appearance.BackColor = Me.ColorAmortizado.Color
                            Case "AL GASTO"
                                fila.Cells("IdEstado").Appearance.BackColor = Me.colorAlGasto.Color
                        End Select
                    Next
                    ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub ListarAlmacenMermas()
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ugb_Espera.Visible = True
            ListaAlmacenMermas = New List(Of e_AlmacenMermas)
            oeAlmacenMermas = New e_AlmacenMermas
            oeAlmacenMermas.TipoOperacion = "1"
            oeAlmacenMermas.IdCentro = "1CH001" 'cboCentroL.Value
            ListaAlmacenMermas.AddRange(olAlmacenMermas.Listar(oeAlmacenMermas))
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ControlPestañas(ByVal Ind As String)
        If Ind = "I" Then
            MostrarTabs(0, ficIngresoSalida, 0)
        Else
            MostrarTabs(1, ficIngresoSalida, 1)
        End If
    End Sub

    Private Function ValidaMovimientoSalida() As Boolean
        Try
            If cboTipoPagoS.SelectedIndex = 1 Or cboTipoPagoS.SelectedIndex = 2 Then
                oeGrupoSancion = New e_GrupoSancion
                oeGrupoSancion.IdArea = "1CH000000022"
                oeGrupoSancion.IdEstado = "1CH00014"
                oeGrupoSancion = olGrupoSancion.ObtenerGrupoGenerado(oeGrupoSancion)
                If oeGrupoSancion.Id = "" Then
                    Throw New Exception("No se puede Atender al Credito / Amortizado" & Environment.NewLine & _
                                        "Falta crear Grupo Sancion informe al Jefe de Operaciones")
                Else
                    oeMovimientoMermas.Serie = oeGrupoSancion.Id
                    oeMovimientoMermas.Numero = gUsuarioSGI.IdTrabajador
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarMovimientoMermas() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeMovimientoMermas.IdCentro = ObtenerCentro(gs_PrefijoIdSucursal).Id
            Select Case ficIngresoSalida.SelectedTab.Index
                Case 0
                    With oeMovimientoMermas
                        .TipoOperacion = "I"
                        .Id = txtIdMovimientoI.Text.Trim
                        .IndIngresoSalida = 0
                        .IdPersona = ""
                        .IdSancion = ""
                        .Fecha = fecFechaI.Value
                        .PorcentajeDescuento = 0
                        .SubTotal = txtTotalI.Value
                        .Saldo = 0
                        .Descuento = 0
                        .Total = txtTotalI.Value
                        .Glosa = txtGlosaI.Text.Trim
                        .IdEstado = "1CH00022"
                        .Serie = txtSerieI.Text
                        .Numero = txtNumeroI.Text
                        .IndCobro = 0
                        .TipoPago = 0
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .ListaControlMermas = griDetalleMermasI.DataSource
                    End With
                Case 1
                    If ValidaMovimientoSalida() Then
                        With oeMovimientoMermas
                            .TipoOperacion = "I"
                            .Id = txtIdMovimientoS.Text.Trim
                            .IndIngresoSalida = 1
                            .IdPersona = cboPersonaS.Value
                            .IdSancion = txtIdSancion.Text
                            .Fecha = fecFechaS.Value
                            .PorcentajeDescuento = txtPorcentajeDescuentoS.Value
                            .SubTotal = txtSubTotalS.Value
                            Select Case cboTipoPagoS.SelectedIndex
                                Case 0
                                    .Saldo = txtTotalS.Value - txtDescuentoS.Value
                                Case 1
                                    .Saldo = 0
                                Case 2
                                    .Saldo = txtTotalS.Value - txtSaldoS.Value
                            End Select
                            .Descuento = txtDescuentoS.Value
                            .Total = txtTotalS.Value
                            .Glosa = txtGlosaS.Text.Trim
                            .IdEstado = "1CH00022"
                            .IndCobro = 0
                            .TipoPago = cboTipoPagoS.SelectedIndex
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .ListaControlMermas = griDetalleMermasS.DataSource
                        End With
                    End If
            End Select
            oeMovimientoMermas.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMovimientoMermas.Guardar(oeMovimientoMermas) Then
                If oeMovimientoMermas.IndIngresoSalida = 1 Then
                    Dim frm As New frm_VentaMerma
                    Dim id As String = oeMovimientoMermas.Id
                    frm.CargarDatos(id)
                    frm.ShowDialog()
                End If
                mensajeEmergente.Confirmacion("La Informacion ha sido Guardada Correctamente. " & Me.Text)
            End If
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Sub DatosTesoreria()
        Try
            ListarCuentaCorriente()
            ListarUsuarioCaja()
            AsientosContables()
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

    Private Sub ListarUsuarioCaja()
        Try
            'Carga Listado de cajas
            oeCaja = New e_Caja
            loCaja = olCaja.Listar(oeCaja)

            oeCajaUsuario = New e_CajaUsuario
            oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
            If oeCajaUsuario.Id <> "" Then
                For Each ListaCaja As e_Caja In loCaja
                    If ListaCaja.Id = oeCajaUsuario.IdCaja Then
                        idCajaCentro = ListaCaja.Id
                    End If
                Next
            Else
                mensajeEmergente.Problema("Este Usuario no esta Asignado a Ninguna Caja")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarIngreso()
        Try
            MostrarTabs(1, ficCtrlMerma, 1)
            Select Case ficListar.SelectedTab.Index
                Case 0
                    ficIngresoSalida.Tabs(0).Selected = True
                    ficIngresoSalida.Tabs(1).Enabled = False
                    ficIngresoSalida.Tabs(0).Enabled = True
                Case 1
                    ficIngresoSalida.Tabs(1).Selected = True
                    ficIngresoSalida.Tabs(0).Enabled = False
                    ficIngresoSalida.Tabs(1).Enabled = True
            End Select
            ActivarBotones(False)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ActivarBotones(ByVal Activo As Boolean)
        cboMaterialI.Enabled = Activo
        cboClienteI.Enabled = Activo
        Me.txtFactorCovI.Enabled = Activo
        Me.txtCantidadI.Enabled = Activo
        Me.cboEstadoI.Enabled = Activo
        Me.cboUnidadI.Enabled = Activo
        Me.txtGlosaI.Enabled = Activo
        Me.fecFechaI.Enabled = Activo
        Me.expViaje.Expanded = Activo
        Me.expViaje.Enabled = Activo
    End Sub

    Private Function ValidaDetalleIngreso() As Boolean
        Try
            cboClienteI.Focus()
            ValidarCombo(cboClienteI, "Cliente")
            cboMaterialI.Focus()
            ValidarCombo(cboMaterialI, "Material")
            cboUnidadI.Focus()
            ValidarCombo(cboUnidadI, "Unidad Medida")
            cboEstadoI.Focus()
            ValidarCombo(cboEstadoI, "Estado")
            If CDbl(txtCantidadI.Value) = 0 Then
                txtCantidadI.Focus()
                Throw New Exception("Cantidad mayor 0")
            End If
            If CDbl(txtFactorCovI.Value) = 0 Then
                txtCantidadI.Focus()
                Throw New Exception("Factor Conversion debe ser mayor 0")
            End If
            If CDbl(txtPrecioAlmacenI.Value) = 0 Then
                txtPrecioAlmacenI.Focus()
                Throw New Exception("Precio debe ser mayor 0")
            End If
            If oeMovimientoMermas.ListaControlMermas.Where(Function(Item) Item.IdMaterial = cboMaterialI.Value).Count() > 0 Then
                Throw New Exception("Producto ya se encuentra en la lista del pedido")
            End If
            If Me.txtIdViajeI.Text.Trim = "" Then
                Throw New Exception("Seleccione Viaje Origen de la Merma")
            End If
            Dim oeCom As New e_Combo
            oeCom.Id = cboMaterialI.Value
            oeCom.Tipo = 0
            If MaterialesPublic.Contains(oeCom) Then
                oeAlmacenMermas = New e_AlmacenMermas
                oeAlmacenMermas.IdMaterial = oeCom.Id
                oeAlmacenMermas = olAlmacenMermas.Obtener(oeAlmacenMermas)
                If oeAlmacenMermas.Id = "" Then
                    oeAlmacenMermas = New e_AlmacenMermas
                    oeAlmacenMermas.TipoOperacion = "I"
                    oeAlmacenMermas.IdMaterial = oeCom.Id
                    oeAlmacenMermas.IdUnidadMedida = "1PY000000011"
                    oeAlmacenMermas.UsuarioCreacion = gUsuarioSGI.Id
                    oeAlmacenMermas.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olAlmacenMermas.Guardar(oeAlmacenMermas)
                End If
            Else
                Throw New Exception("Seleccione Material Correctamente")
            End If
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CalcularSubTotal()
        Try
            If oeMovimientoMermas.ListaControlMermas.Count > 0 Then
                txtTotalI.Text = 0.0
                txtSubTotalS.Text = 0.0
                Select Case ficIngresoSalida.SelectedTab.Index
                    Case 0
                        For Each Detalle As e_ControlMerma In oeMovimientoMermas.ListaControlMermas
                            txtTotalI.Value += Detalle.PrecioUnitario * Detalle.Cantidad
                        Next
                    Case 1
                        For Each Detalle As e_ControlMerma In oeMovimientoMermas.ListaControlMermas
                            txtSubTotalS.Value += Detalle.PrecioUnitario * Detalle.Cantidad
                        Next
                        txtTotalS.Value = Math.Round((txtSubTotalS.Value - (txtSubTotalS.Value * txtPorcentajeDescuentoS.Value / 100)) - txtSaldoS.Value, 2, MidpointRounding.AwayFromZero)
                    Case Else
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidaDetalleSalidas() As Boolean
        Try
            ValidarCombo(cboPersonaS, "Persona")
            ValidarCombo(cboTipoPagoS, "Tipo Pago")
            If CInt(griAlmacenMermasS.ActiveRow.Cells("FactorConversion").Value) = 0 Then
                Throw New Exception("Cantidad mayor 0")
            End If
            If CInt(griAlmacenMermasS.ActiveRow.Cells("FactorConversion").Value) > CDec(griAlmacenMermasS.ActiveRow.Cells("Stock").Value) Then
                Throw New Exception("Cantidad supera el Stock del producto")
            End If

            If oeMovimientoMermas.ListaControlMermas.Where(Function(Item) Item.IdMaterial = griAlmacenMermasS.ActiveRow.Cells("IdIngresoSalidaMermas").Value).Count() > 0 Then
                Throw New Exception("Producto ya se encuentra en la lista del pedido")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub RangoFechaInicializa()
        Dim FechaServidor As Date = ObtenerFechaServidor()
        fecDesde.Value = FechaServidor.AddDays(-15)
        fecHasta.Value = FechaServidor.AddDays(+1)
        fecDesdeViaje.Value = FechaServidor.AddDays(-30)
    End Sub

    Private Sub AgregarMaterialIngreso(IdMaterial As String)
        Try
            Me.cboMaterialI.Value = IdMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ActualizarIngreso() As Boolean
        Try
            oeIngresoSalida = New e_ControlMerma
            oeIngresoSalida.TipoOperacion = "F"
            oeIngresoSalida.Id = griListaIngresos.ActiveRow.Cells("Id").Value
            oeIngresoSalida.Serie = FormatoDocumento(griListaIngresos.ActiveRow.Cells("Serie").Value.ToString, 4)
            oeIngresoSalida.Numero = FormatoDocumento(griListaIngresos.ActiveRow.Cells("Numero").Value, 10)
            oeIngresoSalida.PrecioFactura = griListaIngresos.ActiveRow.Cells("PrecioFactura").Value
            oeIngresoSalida.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olIngresoSalida.Guardar(oeIngresoSalida) Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ActualizarPrecioVenta() As Boolean
        Try
            Dim oe As New e_MovimientoMermas
            oe.TipoOperacion = "V"
            oe.Id = griMovimiento.ActiveRow.Cells("Id").Value
            oe.UsuarioCreacion = gUsuarioSGI.Id
            oe.Total = griMovimiento.ActiveRow.Cells("Total").Value
            oe.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olMovimientoMermas.Guardar(oe) Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ImprimirVoucher(IdMovimiento As String)
        Try
            Dim TipoOperacion As String = "O"
            Dim formulario As New frm_ReporteVoucherMovimientoCaja
            formulario.CargarDatos(TipoOperacion, IdMovimiento)
            formulario.ShowDialog()
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

    Public Sub ObtenerAsientoModelo(Ejericio As Integer)
        Try
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '1CH01'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModeloMerma = New e_AsientoModelo
            oeAsientoModeloMerma.TipoOperacion = ""
            oeAsientoModeloMerma.Activo = True
            oeAsientoModeloMerma.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModeloMerma.Ejercicio = Ejericio
            oeAsientoModeloMerma = olAsientoModelo.Obtener(oeAsientoModeloMerma)
            oeOtrosIngresos.loAsientoModelo = New List(Of e_AsientoModelo)
            oeOtrosIngresos.loAsientoModelo.Add(oeAsientoModeloMerma)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mnuQuitarDetalle_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuQuitDetS.Opening
        Try
            mnuQuitDetS.Items("ToolStripMenuItem1").Visible = False
            If griDetalleMermasS.Selected.Rows.Count > 0 Then
                mnuQuitDetS.Items("ToolStripMenuItem1").Visible = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            QuitarDetalleS()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarDetalleS()
        Try
            oeIngresoSalida = New e_ControlMerma
            oeIngresoSalida = griDetalleMermasS.ActiveRow.ListObject
            oeMovimientoMermas.ListaControlMermas.Remove(oeIngresoSalida)
            griDetalleMermasS.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuQuitDetI.Opening
        Try
            mnuQuitDetI.Items("ToolStripMenuItem2").Visible = False
            If griDetalleMermasI.Selected.Rows.Count > 0 Then
                mnuQuitDetI.Items("ToolStripMenuItem2").Visible = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            QuitarDetalleI()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarDetalleI()
        Try
            oeIngresoSalida = New e_ControlMerma
            oeIngresoSalida = griDetalleMermasI.ActiveRow.ListObject
            oeMovimientoMermas.ListaControlMermas.Remove(oeIngresoSalida)
            griDetalleMermasI.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class