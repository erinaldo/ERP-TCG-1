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
Imports Infragistics.Win.UltraWinGrid
Imports System.Transactions

Public Class frm_ProgramacionPago
    Inherits frm_MenuPadre
#Region "Declaración de variables"

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario  oeMovSaldo, oeMovObtener,
    Dim lst_DetalleProgramacionPago As List(Of e_DetalleProgramacionPago)
    Dim lst_MovimientoDocumento As List(Of e_MovimientoDocumento)
    Private oe_MovimientoDocumento As e_MovimientoDocumento, olMovDocumento As New l_MovimientoDocumento
    Dim oe_ProgramacionPago As e_ProgramacionPago
    Dim oe_DetalleProgramacionPago As e_DetalleProgramacionPago
    Dim ol_MovimientoDocumento As l_MovimientoDocumento
    Private leMovDoc As New List(Of e_MovimientoDocumento)
    Dim ol_ProgramacionPago As I_ProgramacionPago
    Dim ol_DetalleProgramacionPago As I_DetalleProgramacionPago
    Private oeIGV As New e_Impuesto, olIGV As New l_Impuesto
    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda
    Dim llMoneda As New List(Of e_Moneda)
    Private Shared Operacion As String
    Private Shared instancia As frm_ProgramacionPago = Nothing
    Dim _ingresando_datos As Boolean = False
    Private oeMedioPago As New e_MedioPago
    Private oeTipoGasto As New e_TipoGasto
    Private oeFlujoCaja As New e_FlujoCaja
    Private oeCtaBancaria As New e_CuentaBancaria
    Private olCtaBancaria As New l_CuentaBancaria
    Private leCuentaBancaria As New List(Of e_CuentaBancaria)
    Private Ejercicio As Integer = 0
    Private oeCtaCble As New e_CuentaContable
    Private olCtaCble As New l_CuentaContable
    Private leCtaCble As New List(Of e_CuentaContable)
    Private ln_TasaRetencion As Double = 0
    Private oeMovCajaBanco As New e_MovimientoCajaBanco
    Private olMovCajaBanco As New l_MovimientoCajaBanco
    Private olAsiento As New l_Asiento
#End Region

#Region "Inicializacion"
    Private _buscarIdCta As String

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ProgramacionPago()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"
    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
            If griProgramacionPagos.Rows.Count > 0 Then ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Imprimir_Prog(Optional _ban As Boolean = False)
        With griProgramacionPagos.Rows(griProgramacionPagos.ActiveRow.Index)
            If txtEstado.Text = "PAGADO" Or .Cells("Estado").Value = "PAGADA" Or .Cells("Estado").Value = "PARCIAL" Or (txtEstado.Text = "PROGRAMADO" And _ban = True) Then
                Dim frm2 As New frm_ImprimirProgramacionPago
                If Operacion = "Inicializa" Then
                    frm2.CargarDatos(griProgramacionPagos.Rows(griProgramacionPagos.ActiveRow.Index).Cells("Id").Value)
                Else
                    frm2.CargarDatos(lblId.Text)
                End If
                frm2.ShowDialog()
                frm2 = Nothing
                ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
            ElseIf txtEstado.Text = "ANULADO" Or .Cells("Estado").Value = "ANULADO" Then
                mensajeEmergente.Confirmacion("La Programación ha sido Anulada.", True)
            Else
                mensajeEmergente.Confirmacion("La Programación aun no ha sido pagada.", True)
            End If
        End With
    End Sub

    Public Overrides Sub Guardar()
        Try
            ugb_Guardar.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If Operacion = "Pagar" Then
                Validar_TipoCambio()
                If Not (txtProveedor.Text.Trim Is String.Empty) And chkPagar.Checked Then
                    If PagarProgramacion() Then
                        mensajeEmergente.Confirmacion("Se Efectuó el Pago de la Programación Nro.: " & Trim(txtNroLote.Value), True)
                        Dim c As Integer = gridDocumentos.Rows.Where(Function(g) g.Cells("Seleccion").Value = False And g.Cells("Estado").Value = "PROGRAMADO").Count()
                        Dim _ban As Boolean = False

                        LimpiarControles_Pagos()
                        chkPagar.Checked = False
                        txtProveedor.Text = ""
                        'mensajeEmergente.Confirmacion("Pago(s) guardados satisfactoriamente", True)
                        Dim frm2 As New frm_ImprimeCobroPagoAnticipo(oeMovCajaBanco.Id, 0, "Documento")
                        frm2.ShowDialog()
                        frm2 = Nothing
                        If c = 0 Then
                            _ban = True
                        Else
                            If MessageBox.Show("Se Efectuó el Pago de la Programación Nro.: " & Trim(txtNroLote.Value) & ". ¿Desea continuar con el Registro de Pagos?", _
                              "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                                _ban = True
                            End If
                        End If
                        If _ban = True Then
                            'Imprimir_Prog(True)
                            Listar()
                            MostrarTabs(0, ficAprobpagos)
                            ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                            Operacion = "Inicializa"
                            IniciarFormulario()
                        Else
                            gmt_MostrarDetallesProgramacion()
                            With gridDocumentos.Rows(gridDocumentos.Rows.Count - 1)
                                DecSaldo.Value = .Cells("Saldo").Value
                            End With
                        End If
                    End If

                Else
                    mensajeEmergente.Problema("Debe seleccionar un Proveedor para Efectuar Pago.", True)
                End If
            Else
                Dim c As Integer = gridDocumentos.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Seleccion").Value).Count
                If c = 0 Then
                    mensajeEmergente.Problema("Para Anular Registros deberá seleccionar mínimo 1 fila.", True)
                Else
                    If MessageBox.Show("Esta seguro de Anular las Cuentas Seleccionadas de la Programación de Pagos ?", _
                                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        Anular_DetalleProgramacion()
                        If gridDocumentos.Rows.Where(Function(item) item.Cells("Seleccion").Value = False And item.Cells("Estado").Value = "PROGRAMADO").Count > 0 Then
                            If MessageBox.Show("Desea Seguir Editando la Programación de Pagos Actual?", _
                                  "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                                Listar()
                                MostrarTabs(0, ficAprobpagos)
                                ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                                Operacion = "Inicializa"
                                IniciarFormulario()
                            Else
                                gmt_MostrarDetallesProgramacion()
                            End If
                        Else
                            Listar()
                            MostrarTabs(0, ficAprobpagos)
                            ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                            Operacion = "Inicializa"
                            IniciarFormulario()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Guardar.Visible = False
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Operacion = "Inicializa"
            IniciarFormulario()
            Listar()
            LimpiarControles_Pagos()
            chkPagar.Checked = False
            txtProveedor.Text = ""
            MostrarTabs(0, ficAprobpagos)
            ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Control_Pagos(state As Boolean)
        lblEtProv.Visible = state
        txtProveedor.Visible = state
        chkPagar.Visible = state
    End Sub

    Public Overrides Sub Editar()
        Try
            If griProgramacionPagos.Selected.Rows.Count > 0 Then
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 1)
                If Operacion <> "Pagar" Then
                    Operacion = "Editar" : Control_Pagos(False)
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 1)
                Else
                    Validar_TipoCambio()
                    Control_Pagos(True)
                End If

                gmt_MostrarProgramacion(griProgramacionPagos.ActiveRow.Index)
                If txtEstado.Text = "PAGADO" Or txtEstado.Text = "ANULADO" Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 1, 1, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficAprobpagos.Tabs(0).Selected = True Then
                If griProgramacionPagos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(griProgramacionPagos, "PROGRAMACIONES DE PAGO: " & fecDesde.Value.ToShortDateString & " AL " & fecHasta.Value.ToShortDateString)
            ElseIf ficAprobpagos.Tabs(1).Selected = True Then
                If gridDocumentos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(gridDocumentos, "PROGRAMACIÓN N° " & txtNroLote.Text)
            End If
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Dim TipoOperacion As String = "0"
        Dim id As String = ""
        Try
            Imprimir_Prog()
            If ficAprobpagos.Tabs(1).Selected Then ControlBoton(0, 0, 0, 0, 1, 0, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region
#Region "Metodos"
    Private Sub LlenarEstado()
        Try
            Dim dt As New DataTable
            dt.Columns.Add("Id")
            dt.Columns.Add("Nombre")
            Dim F As DataRow
            F = dt.NewRow
            F("Id") = "1CH00001"
            F("Nombre") = "ANULADO"
            dt.Rows.Add(F)
            F = dt.NewRow
            F("Id") = "1CH00031"
            F("Nombre") = "APROBADO"
            dt.Rows.Add(F)
            F = dt.NewRow
            F("Id") = "1CH00014"
            F("Nombre") = "GENERADO"
            dt.Rows.Add(F)
            F = dt.NewRow
            F("Id") = "1CH00038"
            F("Nombre") = "PAGADO"
            dt.Rows.Add(F)
            F = dt.NewRow
            F("Id") = ""
            F("Nombre") = "TODOS"
            dt.Rows.Add(F)
            cboEstado.ValueMember = "Id"
            cboEstado.DisplayMember = "Nombre"
            cboEstado.DataSource = dt
            cboEstado.Value = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar()
        Dim DatatableProgPago As New DataTable
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ol_ProgramacionPago = New I_ProgramacionPago
            oe_ProgramacionPago = New e_ProgramacionPago
            With oe_ProgramacionPago
                .TipoOperacion = ""
                .Id = ""
                .FechaCrea = fecDesde.Value
                .FechaModifica = fecHasta.Value
                If rbDatosAdicionales.Checked Then
                    .IdEstado = cboEstado.Value
                End If
                If rbLote.Checked Then
                    .NroLote = txtLote.Value
                End If
            End With
            DatatableProgPago = ol_ProgramacionPago.ListarProgramacionPagos(oe_ProgramacionPago)
            griProgramacionPagos.DataSource = DatatableProgPago
            For Each fila As UltraGridRow In griProgramacionPagos.Rows
                If fila.Cells("Estado").Value = "PAGADA" Then
                    fila.CellAppearance.BackColor = Me.ColorPagado.Color
                End If
                If fila.Cells("Estado").Value = "PARCIAL" Then
                    fila.CellAppearance.BackColor = Me.ColorParcial.Color
                End If
                If fila.Cells("Estado").Value = "ANULADO" Then
                    fila.CellAppearance.BackColor = Me.ColorAnulado.Color
                End If
            Next
            If griProgramacionPagos.Rows.Count = 0 Then mensajeEmergente.Problema("No hay Registros en el Sistema", True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False

        End Try
    End Sub



    Private Sub IniciarFormulario()
        LlenarEstado()
        'Cargar Moneda
        oeMoneda = New e_Moneda
        olMoneda = New l_Moneda
        llMoneda = olMoneda.Listar(oeMoneda)
        LlenarCombo(cboMoneda, "Nombre", llMoneda, 1)
        CalculaTipoCambio(Date.Now)
        txtEstado.Value = ""
        cboCuentaContable.SelectedIndex = -1
        fecProgramacion.Enabled = False
    End Sub

    Private Sub LlenarCombos()
        LlenaTipoGasto()
        LlenaFlujoCaja()
        llenaMedio()
        LlenaCuentaBancaria()
        llenacuenta()
    End Sub

    Private Sub LlenaCuentaBancaria()
        Try
            If leCuentaBancaria.Count = 0 Then
                oeCtaBancaria = New e_CuentaBancaria
                oeCtaBancaria.IdCuentaContable = oeCtaCble.Id 'Relacionada con Cuenta COntale
                oeCtaBancaria.TipoOperacion = "P"
                oeCtaBancaria.Ejercicio = Date.Parse(fecProgramacion.Value).Year
                oeCtaBancaria.Activo = True
                leCuentaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
                LlenarCombo(cboCuentaBancaria, "BancoCuenta", leCuentaBancaria, -1)
                cboCuentaBancaria.Enabled = IIf(leCuentaBancaria.Count = 0, False, True)
            Else
                Dim lista As New List(Of e_CuentaBancaria)
                lista = leCuentaBancaria.ToList
                lista = lista.Where(Function(item) item.IdCuentaContable = oeCtaCble.Id).ToList()
                If lista.Count = 0 Then
                    cboCuentaBancaria.SelectedIndex = -1
                    cboCuentaBancaria.Enabled = False
                Else
                    'cboCuentaBancaria.SelectedIndex = -1
                    LlenarCombo(cboCuentaBancaria, "BancoCuenta", lista, -1)
                    cboCuentaBancaria.Enabled = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Sub LlenaTipoGasto_1()
    '    Try
    '        Dim oeTipoGasto As New e_TipoGasto
    '        Dim olTipoGasto As New l_TipoGasto
    '        Dim lst_TipoGasto As New List(Of e_TipoGasto)
    '        lst_TipoGAsto = olTipoGasto.Listar2(oeTipoGasto)
    '        '--------------------- para llenar combo en grilla    
    '        gridDocumentos.DisplayLayout.ValueLists.Add("IdTipoGasto")
    '        With gridDocumentos.DisplayLayout.ValueLists("IdTipoGasto").ValueListItems
    '            .Clear()

    '            For Each oeTD As e_TipoGasto In lst_TipoGAsto
    '                .Add(oeTD.Id, oeTD.Nombre)
    '            Next
    '            .Add("", "SELECCIONE...")
    '        End With
    '        CrearComboGrid3("IdTipoGasto", "Nombre", gridDocumentos, True)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    'Private Sub LlenaFlujoCaja_1()
    '    Try
    '        Dim oeFlujoCaja As New e_FlujoCaja
    '        Dim olFlujoCaja As New l_FlujoCaja
    '        Dim lst_FlujoCaja As New List(Of e_FlujoCaja)
    '        lst_FlujoCaja = olFlujoCaja.Listar(oeFlujoCaja)
    '        '--------------------- para llenar combo en grilla    
    '        gridDocumentos.DisplayLayout.ValueLists.Add("FlujoCaja")
    '        With gridDocumentos.DisplayLayout.ValueLists("FlujoCaja").ValueListItems
    '            .Clear()

    '            For Each oeTD As e_FlujoCaja In lst_FlujoCaja
    '                .Add(oeTD.Id, oeTD.Nombre)
    '            Next
    '            .Add("", "SELECCIONE...")
    '        End With
    '        CrearComboGrid3("FlujoCaja", "Nombre", gridDocumentos, True)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub LlenaFlujoCaja()
        Try
            Dim oeFlujoCaja As New e_FlujoCaja
            Dim olFlujoCaja As New l_FlujoCaja
            Dim vl As New DataTable
            cboFlujoCaja.DataSource = vl
            LlenarCombo(cboFlujoCaja, "Nombre", olFlujoCaja.Listar(oeFlujoCaja), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaTipoGasto()
        Try
            Dim oeTipoGasto As New e_TipoGasto
            Dim olTipoGasto As New l_TipoGasto
            Dim vl As New DataTable
            cboTipoGasto.DataSource = vl
            LlenarCombo(cboTipoGasto, "Nombre", olTipoGasto.Listar2(oeTipoGasto), -1)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub llenaMedio()
        Try
            oeMedioPago = New e_MedioPago
            Dim olMedioPago As New l_MedioPago
            Dim leMedioPago As New List(Of e_MedioPago)
            oeMedioPago.Activo = True
            leMedioPago.AddRange(olMedioPago.Listar(oeMedioPago))
            '--------------------- para llenar combo en grilla    
            With cboMedio
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leMedioPago
                .Text = "TRANSFERENCIA DE FONDOS"
            End With
            oeMedioPago = New e_MedioPago
            With cboMedio
                Dim i As Integer = .SelectedIndex
                oeMedioPago = .Items(i).ListObject
            End With
            'cboMedio.Enabled = False 'Desativa el control 
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub llenacuenta()
        Try
            If Ejercicio <> Year(fecProgramacion.Value) Then
                Ejercicio = Year(fecProgramacion.Value)
                oeCtaCble = New e_CuentaContable
                oeCtaCble.Activo = True
                oeCtaCble.Movimiento = 1
                oeCtaCble.FlujoCaja = 1
                oeCtaCble.Ejercicio = Year(fecProgramacion.Value)
                With cboCuentaContable
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = olCtaCble.Listar(oeCtaCble)
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CalculaTipoCambio(ByVal Fecha As Date)
        Try
            decTipoCambio.Value = TipoCambio(Fecha, True)(0)
            oe_MovimientoDocumento = New e_MovimientoDocumento
            oe_MovimientoDocumento.TipoCambio = decTipoCambio.Value
            oeIGV = New e_Impuesto
            oeIGV = olIGV.IGV(Fecha)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


#End Region

#Region "Eventos"

    Private Sub frm_ProgramacionPago_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ProgramacionPago_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub


    Private Sub frm_ProgramacionPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'gmt_ConfigurarEventoKeyEnter_Tab(Me, cboProveedor.Name, txtBuscarMateriales.Name, btnListarMateriales.Name, txtNroOrdenCompra.Name, cboProveedorL.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            InicializaTiempo()
            IniciarFormulario()
            MostrarTabs(0, ficAprobpagos)
            ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
            ln_TasaRetencion = ObtenerRetencion()
            LlenarCombos()
            lblOperacion.AutoSize = False
            lblOperacion.Width = 369
            lblOperacion.Height = 35
            fecHasta.Value = Date.Now
            fecDesde.Value = DateAdd(DateInterval.Day, -7, Date.Now)
            Validar_TipoCambio()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ProgramacionPago_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub
#End Region

    Private Sub rbDatosAdicionales_CheckedChanged(sender As Object, e As EventArgs) Handles rbDatosAdicionales.CheckedChanged
        If rbDatosAdicionales.Checked Then
            agrLote.Enabled = False
            agrDatos.Enabled = True
            cboEstado.SelectedIndex = 0
            txtLote.Value = ""
        End If
    End Sub

    Private Sub rbLote_CheckedChanged(sender As Object, e As EventArgs) Handles rbLote.CheckedChanged
        If rbLote.Checked Then
            agrLote.Enabled = True
            agrDatos.Enabled = False
            cboEstado.SelectedIndex = 0
            txtLote.Value = ""
        End If
    End Sub

    Private Sub griProgramacionPagos_DoubleClick(sender As Object, e As EventArgs) Handles griProgramacionPagos.DoubleClick
        Editar()
    End Sub


    Private Sub gmt_DatosCabecera(tb As DataTable)
        decMontoOriginal.Value = tb.Rows(0).Item("MontoOriginal")
        decRetencion.Value = tb.Rows(0).Item("Retencion")
        DecDetraccion.Value = tb.Rows(0).Item("Detraccion")
        decMontoPago.Value = tb.Rows(0).Item("MontoPago")
        DecSaldo.Value = tb.Rows(0).Item("Saldo")
        decPagoTC.Value = IIf(tb.Rows(0).Item("Moneda") = "DOLARES", tb.Rows(0).Item("MontoPago") * decTipoCambio.Value, tb.Rows(0).Item("MontoPago"))
    End Sub


    Private Sub gmt_MostrarProgramacion(pos As Integer)
        Try
            Dim tb As DataTable
            oe_ProgramacionPago = New e_ProgramacionPago
            oe_ProgramacionPago.TipoOperacion = ""
            oe_ProgramacionPago.Id = griProgramacionPagos.Rows(pos).Cells("Id").Value
            ol_ProgramacionPago = New I_ProgramacionPago
            tb = ol_ProgramacionPago.ListarProgramacionPagos(oe_ProgramacionPago)
            decTipoCambio.Value = TipoCambio(fecPago.Value.Date, True)(0)
            lblId.Text = tb.Rows(0).Item("Id")
            txtNroLote.Text = tb.Rows(0).Item("NroLote")
            txtTrabProg.Text = tb.Rows(0).Item("PersonaProgramo")
            fecProgramacion.Value = tb.Rows(0).Item("FechaProgramo")
            txtObservaciones.Text = IIf(tb.Rows(0).Item("Observaciones") Is DBNull.Value, "", tb.Rows(0).Item("Observaciones"))
            gmt_DatosCabecera(tb)
            cboMoneda.Value = IIf(tb.Rows(0).Item("Moneda") = "DOLARES", "1CH02", "1CH01")
            gridDocumentos.DisplayLayout.Bands(0).Columns("Seleccion").Hidden = False
            If griProgramacionPagos.Rows(pos).Cells("Estado").Value <> "GENERADA" And griProgramacionPagos.Rows(pos).Cells("Estado").Value <> "PARCIAL" Then
                Call Me.Habilitar_Controles_Pago(True)
                lblOperacion.Text = ""
                txtEstado.Text = "PAGADO"
                If griProgramacionPagos.Rows(pos).Cells("Estado").Value = "PAGADA" Then gridDocumentos.DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
                If griProgramacionPagos.Rows(pos).Cells("Estado").Value = "ANULADO" Then txtEstado.Text = "ANULADO"
            Else
                txtEstado.Text = "PROGRAMADO"
                If Operacion = "Editar" Then
                    Call Me.Habilitar_Controles_Pago(True)
                    lblOperacion.Text = "EDITANDO PROGRAMACIÓN"
                End If
                If Operacion = "Pagar" Then
                    Call Me.Habilitar_Controles_Pago(False)
                    lblOperacion.Text = "EFECTUANDO PAGO"
                End If
            End If
            gmt_MostrarDetallesProgramacion()
            MostrarTabs(1, ficAprobpagos, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Habilitar_Controles_Pago(_ban As Boolean)
        cboCuentaBancaria.ReadOnly = _ban
        txtOperaciones.ReadOnly = _ban
        txtObservaciones.ReadOnly = _ban
        cboCuentaContable.ReadOnly = _ban
        cboTipoGasto.ReadOnly = _ban
        cboFlujoCaja.ReadOnly = _ban
        cboMedio.ReadOnly = _ban
    End Sub

    Private Sub gmt_MostrarDetallesProgramacion()
        Dim dtb As DataTable

        If cboMoneda.Value = "1CH01" Then
            gridDocumentos.DisplayLayout.Bands(0).Columns("SALDO_S").Hidden = False
            gridDocumentos.DisplayLayout.Bands(0).Columns("SALDO_D").Hidden = True
        Else
            gridDocumentos.DisplayLayout.Bands(0).Columns("SALDO_S").Hidden = True
            gridDocumentos.DisplayLayout.Bands(0).Columns("SALDO_D").Hidden = False
        End If
        oe_DetalleProgramacionPago = New e_DetalleProgramacionPago
        oe_DetalleProgramacionPago.TipoOperacion = ""
        oe_DetalleProgramacionPago.Id = ""
        oe_DetalleProgramacionPago.IdProgramacionPago = lblId.Text
        If Operacion = "Pagar" Then
            oe_DetalleProgramacionPago.IdEstado = "1CH00017"
        Else
            oe_DetalleProgramacionPago.IdEstado = ""
        End If
        ol_DetalleProgramacionPago = New I_DetalleProgramacionPago
        dtb = ol_DetalleProgramacionPago.Listar(oe_DetalleProgramacionPago)
        gridDocumentos.DataSource = dtb '.Select(Nothing, "CtaCte")
        gridDocumentos.DisplayLayout.Bands(0).Columns("Seleccion").Header.VisiblePosition = 2
        gridDocumentos.DisplayLayout.Bands(0).Columns("Seleccion").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
        leMovDoc.Clear()
        Dim cliente As String = gridDocumentos.Rows(0).Cells("CtaCte").Value
        Dim contclie As Integer = 0
        'Dim vl As New ValueList      
        For Each fila As UltraGridRow In gridDocumentos.Rows
            Select Case fila.Cells("Numero").Value
                Case "SubTotal", "TOTALES"
                    fila.Cells("Seleccion").Hidden = True
                    fila.CellAppearance.BackColor = Color.LightBlue
                    fila.CellAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                Case "TOTALES"
                    decMontoOriginal.Value = fila.Cells("MontoOriginal")
                    decRetencion.Value = fila.Cells("Afectacion")
                    decMontoPago.Value = fila.Cells("MontoPago")
            End Select

            If fila.Cells("Estado").Value = "ANULADO" Then
                fila.Cells("Estado").Appearance.BackColor = Colores1.Color
                fila.Cells("Estado").Appearance.ForeColor = Color.White
                fila.Cells("Seleccion").Hidden = True
                If Operacion = "Pagar" Then
                    fila.Hidden = True
                End If
            End If
            If fila.Cells("Estado").Value = "PAGADA" Then
                fila.Cells("Estado").Appearance.BackColor = ColorPagado.Color
                fila.Cells("Estado").Appearance.ForeColor = Color.Black
                fila.Cells("Seleccion").Hidden = True
                If Operacion = "Pagar" Then
                    fila.Hidden = True
                End If
            End If
            If Operacion = "Pagar" Then
                If fila.Cells("Estado").Value <> "ANULADO" Then
                    If Not (fila.Cells("Numero").Value = "SubTotal" Or fila.Cells("Numero").Value = "TOTALES") Then
                        '---capturo datos a ingresar-----
                        CargarMovimientoDocumentos(fila.Cells("IdMovimientoDocumento").Value)
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub CargarMovimientoDocumentos(id As String)
        oe_MovimientoDocumento = New e_MovimientoDocumento
        oe_MovimientoDocumento.Id = id
        oe_MovimientoDocumento.IdPeriodo = ""
        oe_MovimientoDocumento.TipoOperacion = "PAG"
        oe_MovimientoDocumento.Ejercicio = Date.Parse(fecProgramacion.Value).Year
        'leMovDoc.Clear()
        ol_MovimientoDocumento = New l_MovimientoDocumento
        leMovDoc.AddRange(ol_MovimientoDocumento.Listar(oe_MovimientoDocumento))
    End Sub

    Private Sub frm_ProgramacionPago_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Select Case ficAprobpagos.SelectedTab.Index
            Case 0
                If griProgramacionPagos.Rows.Count > 0 Then
                    ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
        End Select
    End Sub

    Private Sub gridDocumentos_CellChange(sender As Object, e As CellEventArgs) Handles gridDocumentos.CellChange
        Try
            Dim oeMovimientoDocumento As e_MovimientoDocumento
            Dim olMovimientoDocumento As l_MovimientoDocumento
            Dim saldo As Double = 0.0
            gridDocumentos.UpdateData()
            With gridDocumentos.Rows(e.Cell.Row.Index)
                If Operacion = "Pagar" Then
                    If .Cells("Seleccion").Value = True Then
                        oeMovimientoDocumento = New e_MovimientoDocumento
                        '---capturo datos a ingresar-----
                        oeMovimientoDocumento.Id = .Cells("IdMovimientoDocumento").Value
                        olMovimientoDocumento = New l_MovimientoDocumento
                        saldo = olMovimientoDocumento.Listar(oeMovimientoDocumento).Item(0).Saldo
                        Dim dif As Double = (Math.Round(saldo, 2) - Math.Round(.Cells("Saldo").Value, 2))
                        If Math.Round(saldo, 2) >= Math.Round(.Cells("Saldo").Value, 2) Or (dif <= 0.0 OrElse dif >= 0.1) Then
                            If txtProveedor.Value Is String.Empty Or txtProveedor.Value Is DBNull.Value Or txtProveedor.Value Is Nothing Then
                                mensajeEmergente.Problema("Debe Seleccionar el Proveedor a Pagar.", True)
                                .Cells("Seleccion").Value = False
                            Else
                                If txtProveedor.Value <> .Cells("Ctacte").Value Then
                                    mensajeEmergente.Problema("El Comprobante a Pagar Seleccionado no Corresponde al Proveedor.", True)
                                    .Cells("Seleccion").Value = False
                                End If
                            End If
                        Else
                            .Cells("Seleccion").Value = False
                            mensajeEmergente.Problema("El Monto a Pagar es Mayor al Saldo del Documento. Proceder a Revisar el Documento.", True)
                        End If
                    End If
                End If
            End With
            gridDocumentos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
    Private Sub gridDocumentos_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles gridDocumentos.InitializeLayout
        Try
            If {"gridDocumentos"}.Contains(e.Layout.Grid.Name) Then
                e.Layout.Override.CellClickAction = CellClickAction.RowSelect
                For Each r In e.Layout.Bands(0).Columns
                    If r.Key = "Seleccion" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Anular_DetalleProgramacion()
        Dim _ban As Boolean = False
        oe_ProgramacionPago = New e_ProgramacionPago
        lst_DetalleProgramacionPago = New List(Of e_DetalleProgramacionPago)
        lst_MovimientoDocumento = New List(Of e_MovimientoDocumento)
        oe_ProgramacionPago.Id = lblId.Text
        Dim s_montoorig As Decimal = 0.0
        Dim s_retenc As Decimal = 0.0
        Dim s_detrac As Decimal = 0.0
        Dim s_montopag As Decimal = 0.0
        For Each drFila In gridDocumentos.Rows
            If Not (drFila.Cells("Numero").Value = "SubTotal" Or drFila.Cells("Numero").Value = "TOTALES") Then
                If drFila.Cells("Seleccion").Value = True Then
                    oe_DetalleProgramacionPago = New e_DetalleProgramacionPago
                    oe_DetalleProgramacionPago.IdUsuario = gUsuarioSGI.IdTrabajador
                    oe_DetalleProgramacionPago.TipoOperacion = "E"
                    oe_DetalleProgramacionPago.IdMovimientoDocumento = drFila.Cells("Id").Value
                    oe_DetalleProgramacionPago.IdEstado = "1CH00001"
                    oe_DetalleProgramacionPago.Id = drFila.Cells("IDetProgPag").Value
                    lst_DetalleProgramacionPago.Add(oe_DetalleProgramacionPago)

                    oe_MovimientoDocumento = New e_MovimientoDocumento
                    oe_MovimientoDocumento.TipoOperacion = "P"
                    oe_MovimientoDocumento.IdUsuarioCrea = oe_DetalleProgramacionPago.IdUsuario
                    oe_MovimientoDocumento.IdEstadoDocumento = "1CH00039"
                    oe_MovimientoDocumento.Id = drFila.Cells("Id").Value
                    lst_MovimientoDocumento.Add(oe_MovimientoDocumento)

                    s_montoorig = s_montoorig + drFila.Cells("MontoOriginal").Value
                    If drFila.Cells("TipoAfect").Value = "RETENCIÓN" Then
                        s_retenc = s_retenc + drFila.Cells("Afectacion").Value
                    ElseIf drFila.Cells("TipoAfect").Value = "DETRACCIÓN" Then
                        s_detrac = s_detrac + drFila.Cells("Afectacion").Value
                    End If
                    s_montopag = s_montopag + drFila.Cells("MontoPago").Value
                End If
            End If
        Next
        If gridDocumentos.Rows.Where(Function(item) item.Cells("Seleccion").Value = False And (item.Cells("Estado").Value = "PAGADA" Or item.Cells("Estado").Value = "PROGRAMADO")).Count = 0 Then
            oe_ProgramacionPago.IdEstado = "1CH00001"
        Else
            oe_ProgramacionPago.IdEstado = "1CH00014"
            If gridDocumentos.Rows.Where(Function(item) item.Cells("Seleccion").Value = False And item.Cells("Estado").Value = "PAGADA").Count > 0 Then
                If gridDocumentos.Rows.Where(Function(item) item.Cells("Seleccion").Value = False And item.Cells("Estado").Value = "PROGRAMADO").Count = 0 Then
                    oe_ProgramacionPago.IdEstado = "1CH00038"
                Else
                    oe_ProgramacionPago.IdEstado = "1CH00015"
                End If
            End If
        End If
        oe_ProgramacionPago.Observaciones = IIf(oe_ProgramacionPago.IdEstado = "1CH00001", "ANULACIÓN DE LA PROGRAMACIÓN - SIN AFECTO", txtObservaciones.Text)
        oe_ProgramacionPago.MontoPago = s_montopag
        oe_ProgramacionPago.MontoOriginal = s_montoorig
        oe_ProgramacionPago.Retencion = s_retenc
        oe_ProgramacionPago.lst_DetalleProgPago = lst_DetalleProgramacionPago
        oe_ProgramacionPago.lst_MovimientoDocumento = lst_MovimientoDocumento
        oe_ProgramacionPago.TipoOperacion = "A"
        ol_ProgramacionPago = New I_ProgramacionPago
        oe_ProgramacionPago.PrefijoID = gs_PrefijoIdSucursal '@0001
        If ol_ProgramacionPago.Guardar(oe_ProgramacionPago) Then
            mensajeEmergente.Confirmacion("Se Efectuó la Anulación de Cuentas Programados para Pagar.", True)
            gmt_MostrarDetallesProgramacion()
            With gridDocumentos.Rows(gridDocumentos.Rows.Count - 1)
                DecSaldo.Value = .Cells("Saldo").Value
                'decMontoOriginal.Value = .Cells("MontoOriginal").Value
                'decRetencion.Value = Math.Round(CDbl(decRetencion.Value) - s_retenc, 2)
                'DecDetraccion.Value = Math.Round(CDbl(DecDetraccion.Value) - s_detrac, 2)
                'decMontoPago.Value = .Cells("MontoPago").Value
                'decPagoTC.Value = IIf(cboMoneda.Value = "1CH02", .Cells("MontoPago").Value * decTipoCambio.Value, .Cells("MontoPago").Value)
            End With
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If griProgramacionPagos.Selected.Rows.Count = 0 Then
                mensajeEmergente.Problema("Debe seleccionar una Programación para Efecturar la Anulación.", True)
            Else
                If MessageBox.Show("Esta seguro de Efecutar el Anulación de la Programación N°: " & _
                                Trim(griProgramacionPagos.ActiveRow.Cells("NroLote").Value.ToString) & " ?", _
                                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                    oe_ProgramacionPago = New e_ProgramacionPago
                    lst_DetalleProgramacionPago = New List(Of e_DetalleProgramacionPago)
                    lst_MovimientoDocumento = New List(Of e_MovimientoDocumento)
                    oe_ProgramacionPago.Id = griProgramacionPagos.Rows(griProgramacionPagos.ActiveRow.Index).Cells("Id").Value
                    oe_ProgramacionPago.IdEstado = "1CH00001"
                    oe_ProgramacionPago.MontoPago = 0.0
                    oe_ProgramacionPago.MontoOriginal = 0.0
                    oe_ProgramacionPago.Retencion = 0.0
                    oe_ProgramacionPago.TipoOperacion = "E"
                    ol_ProgramacionPago = New I_ProgramacionPago
                    oe_ProgramacionPago.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If ol_ProgramacionPago.Guardar(oe_ProgramacionPago) Then
                        mensajeEmergente.Confirmacion("Se Efectuó la Anulación de Cuentas Programados para Pagar.", True)
                        gmt_MostrarDetallesProgramacion()
                        Listar()
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

        If griProgramacionPagos.Selected.Rows.Count = 0 Then
            mensajeEmergente.Problema("Debe seleccionar una Programación para Efecturar el Pago.", True)
        Else
            If MessageBox.Show("Esta seguro de Efecutar el Pago de la Programación N°: " & _
                                Trim(griProgramacionPagos.ActiveRow.Cells("NroLote").Value.ToString) & " ?", _
                                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Operacion = "Pagar"
                Editar() ': gmt_MostrarProgramacion(griProgramacionPagos.ActiveRow.Index)
            End If
        End If
    End Sub

    Private Sub griProgramacionPagos_AfterRowActivate(sender As Object, e As EventArgs) Handles griProgramacionPagos.AfterRowActivate
        ControlarEstadoProgramacion()
    End Sub

    Public Sub ControlarEstadoProgramacion()
        btnEliminar.Enabled = 0 : btnPagar.Enabled = 0
        If griProgramacionPagos.ActiveRow.Index > -1 Then
            Select Case griProgramacionPagos.ActiveRow.Cells("Estado").Value
                Case "GENERADA"
                    btnPagar.Enabled = 1
                    btnEliminar.Enabled = 1
                Case "PARCIAL"
                    btnPagar.Enabled = 1
            End Select
        End If
    End Sub

    Private Function PagarProgramacion() As Boolean
        Try
            Dim datos() As String = Nothing
            Dim monto_total As Double = 0.0
            Dim listaMovDoc As List(Of e_MovimientoDocumento)
            If validarPagos() Then

                Using TS As New TransactionScope
                    listaMovDoc = New List(Of e_MovimientoDocumento)
                    monto_total = 0.0
                    Dim tipocamb_pag As Double = TipoCambio(fecPago.Value.Date, True)(0)
                    For Each fila As UltraGridRow In gridDocumentos.Rows.Where(Function(g) g.Cells("Seleccion").Value = True And g.Cells("CtaCte").Value = txtProveedor.Text And g.Cells("Estado").Value = "PROGRAMADO").ToList
                        monto_total += fila.Cells("MontoPago").Value
                        For Each oeDoc In leMovDoc
                            If oeDoc.Id = fila.Cells("Id").Value Then
                                oeDoc.OrdenCompra = cboMoneda.Value
                                oeDoc.IdTipoBien = tipocamb_pag
                                oeDoc.Glosa = txtOperaciones.Text.Trim
                                oeDoc.IdLiquidacion = IIf(fila.Cells("TipoAfect").Value = "RETENCIÓN", fila.Cells("Afectacion").Value, 0.0)
                                oeDoc.MontoOperar = fila.Cells("MontoPago").Value
                                If CDbl(oeDoc.IdLiquidacion) > 0.0 Then
                                    oeDoc.CodMotivo = "RET"
                                End If
                                listaMovDoc.Add(oeDoc)
                            End If
                        Next
                        oe_DetalleProgramacionPago = New e_DetalleProgramacionPago
                        oe_DetalleProgramacionPago.Id = fila.Cells("IDetProgPag").Value
                        oe_DetalleProgramacionPago.IdProgramacionPago = lblId.Text
                        oe_DetalleProgramacionPago.IdEstado = "1CH00038"
                        oe_DetalleProgramacionPago.IdTipoGasto = cboTipoGasto.Value
                        oe_DetalleProgramacionPago.CtaBancaria = cboCuentaBancaria.Value
                        oe_DetalleProgramacionPago.NroOperacion = txtOperaciones.Text
                        oe_DetalleProgramacionPago.CtaContable = cboCuentaContable.Value
                        oe_DetalleProgramacionPago.FlujoGasto = cboFlujoCaja.Value
                        oe_DetalleProgramacionPago.MedioPago = cboMedio.Value
                        oe_DetalleProgramacionPago.TipoOperacion = "P"
                        oe_DetalleProgramacionPago.MontoPago = fila.Cells("MontoPago").Value
                        oe_DetalleProgramacionPago.FechaPago = fecPago.Value
                        ol_DetalleProgramacionPago = New I_DetalleProgramacionPago
                        oe_DetalleProgramacionPago.PrefijoID = gs_PrefijoIdSucursal '@0001
                        ol_DetalleProgramacionPago.Guardar(oe_DetalleProgramacionPago)
                    Next
                    oeMovCajaBanco.PrefijoID = gs_PrefijoIdSucursal '@0001
                    With oeMovCajaBanco
                        .IdFlujoCaja = cboFlujoCaja.Value
                        .NroBoucher = txtOperaciones.Text
                        .IdCuentaBancaria = oeCtaBancaria.Id
                        .Fecha = fecPago.Value
                        .IdMedioPago = cboMedio.Value
                        .IdPeriodoConcilia = ""
                        .Activo = True
                        .TipoCambio = tipocamb_pag
                        .TotalMN = IIf(cboMoneda.Value = "1CH01", monto_total, (monto_total * tipocamb_pag))
                        .TotalME = IIf(cboMoneda.Value = "1CH01", (monto_total / tipocamb_pag), monto_total)
                        .TipoOperacion = "I"
                        .MovDoc = Nothing
                        .IdTipoGasto = cboTipoGasto.Value
                    End With
                    Dim c_t As Integer = gridDocumentos.Rows.Where(Function(g) g.Cells("CtaCte").Value = txtProveedor.Text And Not g.Cells("Seleccion").Value = True And g.Cells("Estado").Value = "PROGRAMADO").Count()
                    Dim c As Integer = gridDocumentos.Rows.Where(Function(g) (g.Cells("CtaCte").Value <> txtProveedor.Text Or (g.Cells("CtaCte").Value = txtProveedor.Text And Not g.Cells("Seleccion").Value = True)) And g.Cells("Estado").Value = "PROGRAMADO").Count()
                    oe_ProgramacionPago = New e_ProgramacionPago
                    oe_ProgramacionPago.Id = lblId.Text
                    oe_ProgramacionPago.IdEstado = IIf(c > 0, "1CH00015", IIf(c_t > 0, "1CH00015", "1CH00038"))
                    oe_ProgramacionPago.TipoOperacion = "P"
                    oe_ProgramacionPago.Observaciones = txtObservaciones.Text
                    oe_ProgramacionPago.MontoPago = monto_total
                    oe_ProgramacionPago.IdUsuario = gUsuarioSGI.IdTrabajador
                    ol_ProgramacionPago = New I_ProgramacionPago
                    oe_ProgramacionPago.PrefijoID = gs_PrefijoIdSucursal '@0001
                    ol_ProgramacionPago.Guardar(oe_ProgramacionPago)
                    oeMedioPago.PrefijoID = gs_PrefijoIdSucursal '@0001
                    oeCtaCble.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olAsiento.GuardarPago(listaMovDoc, oeMovCajaBanco, oeMedioPago, gUsuarioSGI.Id, MacPCLocal, oeCtaCble, "PAG")
                    TS.Complete()
                    Return True
                End Using
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cboCuentaContable_ValueChanged(sender As Object, e As EventArgs) Handles cboCuentaContable.ValueChanged
        Try
            oeCtaCble = New e_CuentaContable
            With cboCuentaContable
                If .SelectedIndex <> -1 Then
                    Dim i As Integer = .SelectedIndex
                    oeCtaCble = .Items(i).ListObject
                End If
            End With
            If cboCuentaContable.Enabled Then
                LlenaCuentaBancaria()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMedio_ValueChanged(sender As Object, e As EventArgs) Handles cboMedio.ValueChanged
        oeMedioPago = New e_MedioPago
        With cboMedio
            Dim i As Integer = .SelectedIndex
            oeMedioPago = .Items(i).ListObject
        End With
    End Sub

    Private Sub cboTipoGasto_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoGasto.ValueChanged
        oeTipoGasto = New e_TipoGasto
        With cboTipoGasto
            Dim i As Integer = .SelectedIndex
            oeTipoGasto = .Items(i).ListObject
        End With
    End Sub

    Private Sub cboFlujoCaja_ValueChanged(sender As Object, e As EventArgs) Handles cboFlujoCaja.ValueChanged
        oeFlujoCaja = New e_FlujoCaja
        With cboFlujoCaja
            Dim i As Integer = .SelectedIndex
            oeFlujoCaja = .Items(i).ListObject
        End With
    End Sub

    Private Sub cboCuentaBancaria_ValueChanged(sender As Object, e As EventArgs) Handles cboCuentaBancaria.ValueChanged
        Try
            With cboCuentaBancaria
                If cboCuentaBancaria.SelectedIndex <> -1 Then
                    oeCtaBancaria = New e_CuentaBancaria
                    Dim i As Integer = .SelectedIndex
                    oeCtaBancaria = .Items(i).ListObject
                    llenacuenta()
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function validarPagos() As Boolean
        Try
            ValidarCombo(cboMedio, "Medio de Pago")
            ValidarCombo(cboCuentaContable, "Cuenta Contable")
            If cboCuentaBancaria.Enabled Then ValidarCombo(cboCuentaBancaria, "Cuenta Bancaria")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtOperaciones.Text, "Ingrese el Voucher")
            ValidarCombo(cboTipoGasto, "Tipo de Gasto")
            ValidarCombo(cboFlujoCaja, "Flujo de Caja")
            If fecPago.Value.Date < fecProgramacion.Value.Date Then
                Throw New Exception("La Fecha de Pago no debe ser menos a la la Fecha de Programación.")
            End If
            Dim c_t As Integer = gridDocumentos.Rows.Where(Function(g) g.Cells("CtaCte").Value = txtProveedor.Text And g.Cells("Estado").Value = "PROGRAMADO").Count()
            Dim c_g As Integer = gridDocumentos.Rows.Where(Function(g) g.Cells("Seleccion").Value = True And g.Cells("CtaCte").Value = txtProveedor.Text And g.Cells("Estado").Value = "PROGRAMADO").Count()
            If c_g > 0 Then
                If c_g < c_t Then
                    If MessageBox.Show("Se Realizará el Pago  de " & c_g & " Comprobante(s)" & ", pero la cantidad de Comprobantes a Pagar del Proveedor " & txtProveedor.Text & " es de " & c_t & ". ¿Desea Continuar con el Pago?", _
                               "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                        Throw New Exception("Complete los Campos de los Comprobantes a Pagar.")
                    End If
                End If
            Else
                Throw New Exception("Debe Seleccionar los Comprobantes a Pagar.")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub gridDocumentos_DoubleClick(sender As Object, e As EventArgs) Handles gridDocumentos.DoubleClick
        Dim proveedor As String = ""
        If txtProveedor.Text.Trim Is String.Empty And chkPagar.Checked = False Then
            If gridDocumentos.ActiveRow.Index > -1 And Operacion = "Pagar" Then
                proveedor = gridDocumentos.Rows(gridDocumentos.ActiveRow.Index).Cells("CtaCte").Value
                If MessageBox.Show("Esta seguro de Realizar el Pago del Proveedor " & proveedor.ToUpper & " ?", _
                                   "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    txtProveedor.Value = proveedor
                    chkPagar.Checked = True
                Else
                    txtProveedor.Value = ""
                    chkPagar.Checked = False
                End If
            End If
        End If
    End Sub

    Private Sub chkPagar_CheckedChanged(sender As Object, e As EventArgs) Handles chkPagar.CheckedChanged
        If Not txtProveedor.Text Is String.Empty Then
            If chkPagar.Checked = False Then
                If MessageBox.Show("Esta seguro de Suspender el Pago al Proveedor:" & txtProveedor.Text.ToUpper & " ?", _
                                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    LimpiarControles_Pagos()
                Else
                    chkPagar.Checked = True
                End If
            End If
        Else
            chkPagar.Checked = False
        End If
    End Sub

    Private Sub LimpiarControles_Pagos()
        LlenarCombos()
        txtOperaciones.Text = ""
        txtProveedor.Text = ""
        chkPagar.Checked = False
    End Sub

    Private Sub fecPago_ValueChanged(sender As Object, e As EventArgs) Handles fecPago.ValueChanged
        Validar_TipoCambio()
        Dim tb As DataTable
        oe_ProgramacionPago = New e_ProgramacionPago
        oe_ProgramacionPago.TipoOperacion = ""
        oe_ProgramacionPago.Id = lblId.Text
        ol_ProgramacionPago = New I_ProgramacionPago
        tb = ol_ProgramacionPago.ListarProgramacionPagos(oe_ProgramacionPago)
        gmt_DatosCabecera(tb)
    End Sub

    Private Sub Validar_TipoCambio()
        Try
            DecTipoCambio.Value = TipoCambio(fecPago.Value, False)(0)
            If DecTipoCambio.Value = 0.0 Then Throw New Exception("Comuníquese con el Área de Contabilidad para actualizar el T.C. del día seleccionado.")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub DecTipoCambio_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles decTipoCambio.EditorButtonClick
        Validar_TipoCambio()
    End Sub
End Class