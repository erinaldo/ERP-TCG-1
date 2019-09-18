Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_DocumentosAsociados
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_DocumentosAsociados = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_DocumentosAsociados
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeSaldoCuentaCte As New e_SaldoCtaCorriente, olSaldoCuentaCte As l_SaldoCtaCorriente, leSaldoCuentaCte As New List(Of e_SaldoCtaCorriente)
    Private oeMovCuentaCte As New e_MovCuentaCte, olMovCuentaCte As l_MovCuentaCte, leMovCuentaCte As New List(Of e_MovCuentaCte)
    Private oeMovimientoDoc As New e_MovimientoDocumento, olMovimientoDoc As l_MovimientoDocumento, leMovimientoDoc As New List(Of e_MovimientoDocumento)
    Private oeCuentaCte As New e_CuentaCorriente, olCuentaCte As l_CuentaCorriente
    Private leCuentaCte As New List(Of e_CuentaCorriente), leCuentaCteBusq As New List(Of e_CuentaCorriente), leCuentaCteTrabBus As New List(Of e_CuentaCorriente)
    Private oeTrabajador As New e_Trabajador, olTrabajador As l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private olPersona As New l_Persona
    Private oeEstado As New e_Estado, olEstado As l_Estado, leEstado As New List(Of e_Estado)
    Private oeMoneda As New e_Moneda, olMoneda As l_Moneda, leMoneda As New List(Of e_Moneda)
    Private leMonedaTrans As New List(Of e_Moneda), leMonedaDoc As New List(Of e_Moneda), oeMonedaAux As New e_Moneda
    Private oeTipoDoc As New e_TipoDocumento, olTipoDoc As l_TipoDocumento, leTipoDocBono As List(Of e_TipoDocumento)
    Private leTipoDoc As New List(Of e_TipoDocumento), leTipoDocBus As New List(Of e_TipoDocumento), oeTipoDocAux As New e_TipoDocumento
    Private oeBanco As New e_Banco, olBanco As l_Banco, leBanco As New List(Of e_Banco)
    Private oeCuentaBancaria As New e_CuentaBancaria, olCuentaBancaria As l_CuentaBancaria, leCuentaBancaria As New List(Of e_CuentaBancaria)
    Private oeProveedor As New e_Proveedor, olProveedor As l_Proveedor, leProveedor As New List(Of e_Proveedor), oeProveedorAux As New e_Proveedor
    Private oeIgv As New e_Impuesto, olIgv As l_Impuesto
    Private oePeriodo As New e_Periodo, olPeriodo As l_Periodo
    Private oeFlujoCaja As New e_FlujoCaja, olFlujoCaja As l_FlujoCaja, leFlujoCaja As New List(Of e_FlujoCaja), oeFlujoCajaAux As New e_FlujoCaja
    Private olFunciones As l_FuncionesGenerales
    Private oeAsientoModel As e_AsientoModelo, olAsientoModel As l_AsientoModelo, leAsientoModel As List(Of e_AsientoModelo), oeAsiModPago As e_AsientoModelo
    Private oeCtaCtble As e_CuentaContable, olCtaCtble As l_CuentaContable, leCtaCtble As List(Of e_CuentaContable)
    Private leDocumentos As List(Of e_MovimientoDocumento), leDocPago As List(Of e_MovimientoDocumento), oeDocPago As e_MovimientoDocumento
    Dim tc As Double
    Dim IdCuentaCorriente As String = String.Empty, Trabajador As String = String.Empty, IdTrabajador As String = String.Empty, IdFlujoCaja As String = String.Empty
    Dim mxid As Integer = 0, ln_TipoCta As Integer = 0, ln_Ejercicio As Integer = Date.Now.Year
    Dim oeMonedaObtien As e_Moneda
    Dim BandBusDoc As Boolean = False
    Dim IdCtaContable As String = "", IdDocCompra As String = "", IdCtaSoles As String = "", IdCtaDolares As String = ""
    Private lb_Load As Boolean = False
    Private Const CtaTrans As String = "63112"
    Private IdCtaTrans As String = String.Empty

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            If griCuentas.Rows.Count > 0 Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1) Else ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Guardando()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        'MyBase.Cancelar()
        Select Case ficDocAosciados.SelectedTab.Index
            Case 1
                MostrarTabs(0, ficDocAosciados, 0)
                Consultar(True)
            Case 2
                MostrarTabs(0, ficDocAosciados, 0)
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Case 3
                MostrarTabs(1, ficDocAosciados, 1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            Case 4
                If MessageBox.Show("¿Desea Cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    MostrarTabs(0, ficDocAosciados, 0)
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                End If
        End Select
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficDocAosciados.SelectedTab.Index
                Case 0
                Case 1
                    If griMovimiento.Rows.Count = 0 Then Throw New Exception("¡No hay Registros para exportar!")
                    ExportarGrillaAExcel(griMovimiento, "RegistroDetalle")
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_DocumentosAsociados_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficDocAosciados.SelectedTab.Index
            Case 0
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            Case 2
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Case 4
                ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_DocumentosAsociados_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_DocumentosAsociados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            MostrarTabs(0, ficDocAosciados)
            olSaldoCuentaCte = New l_SaldoCtaCorriente : olMovCuentaCte = New l_MovCuentaCte : olMovimientoDoc = New l_MovimientoDocumento
            olCuentaCte = New l_CuentaCorriente : olTrabajador = New l_Trabajador : olEstado = New l_Estado : olMoneda = New l_Moneda
            olTipoDoc = New l_TipoDocumento : olBanco = New l_Banco : olCuentaBancaria = New l_CuentaBancaria : olProveedor = New l_Proveedor
            olIgv = New l_Impuesto : olPeriodo = New l_Periodo : olFlujoCaja = New l_FlujoCaja : olFunciones = New l_FuncionesGenerales
            olAsientoModel = New l_AsientoModelo : olCtaCtble = New l_CuentaContable
            CargarCombo()
            CargarAsiMod()
            lb_Load = True
            CargarSaldoCtaCte(New List(Of e_SaldoCtaCorriente))
            CargarCuenta(New List(Of e_CuentaCorriente))
            CargarMovCuentaCte(New List(Of e_MovCuentaCte))
            CargarDocumentos(New List(Of e_MovimientoDocumento))
            CargarDocPagos(New List(Of e_MovimientoDocumento))
            Cargar_DocumentosCompra(New List(Of e_MovimientoDocumento))
            lb_Load = False
            CargarConfPerfil()
            fecPeriodo.Value = ObtenerFechaServidor()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCrearCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearCuenta.Click
        Try
            'If cboTipoCuentaBusq.SelectedIndex = 0 Then Throw New Exception("Selecione Tipo de cuenta")
            MostrarTabs(2, ficDocAosciados, 2)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            InicializaCuentaCte()
            cboTipoCuenta.Text = cboTipoCuentaBusq.Text.Trim
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTrabajador_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajador.ValueChanged
        If cboTrabajador.SelectedIndex > -1 Then CargarDatosTrab()
    End Sub

    Private Sub griSaldoCuenta_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griSaldoCuenta.DoubleClick
        Try
            If griSaldoCuenta.Selected.Rows.Count > 0 Then
                Dim _monto As Double = griSaldoCuenta.ActiveRow.Cells("Monto").Value
                ln_TipoCta = griSaldoCuenta.ActiveRow.Cells("TipoCuenta").Value
                If ln_TipoCta = 2 Then
                    If _monto > 0 Then Movimiento(1) : cboTipoDoc.Focus() : HabilitarDoc(True) Else Movimiento(0) : fecTransferencia.Focus()
                    cboMovimiento.ReadOnly = False : cboTipo.ReadOnly = False
                Else
                    Movimiento(1) : cboTipoDoc.Focus() : HabilitarDoc(False)
                    cboMovimiento.ReadOnly = True : cboTipo.ReadOnly = True
                End If
            Else
                Throw New Exception("¡Seleccione un Registro para realizar un movimiento!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMovimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMovimiento.ValueChanged
        agrContenedor.Text = cboMovimiento.Text & " por " & cboTipo.Text & " para: " & Trabajador
    End Sub

    Private Sub cboTipo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.Validated
        If cboTipo.SelectedIndex = 0 Then
            CalculaDatosContable(fecTransferencia.Value.Date, 0)
        Else
            CalculaDatosContable(fecEmision.Value.Date, 1)
        End If
    End Sub

    Private Sub cboTipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.ValueChanged
        agrContenedor.Text = cboMovimiento.Text & " por " & cboTipo.Text & " para: " & Trabajador
        pnTransferencia.Visible = IIf(cboTipo.SelectedIndex = 0, True, False)
        pnTransferencia.Dock = IIf(cboTipo.SelectedIndex = 0, DockStyle.Fill, DockStyle.None)
        pnDocumentos.Visible = IIf(cboTipo.SelectedIndex = 0, False, True)
        pnDocumentos.Dock = IIf(cboTipo.SelectedIndex = 0, DockStyle.None, DockStyle.Fill)
        Inicializa_Contenido()
    End Sub

    Private Sub cboBanco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBanco.ValueChanged
        If cboBanco.SelectedIndex > -1 Then
            Dim leCuentaBancariaTemp As New List(Of e_CuentaBancaria)
            leCuentaBancariaTemp = leCuentaBancaria.Where(Function(item) item.IdBanco = cboBanco.Value And item.IdMoneda = cboMonedaTrans.Value).ToList
            LlenarCombo(cboCuentaBancaria, "NumeroCuenta", leCuentaBancariaTemp, -1)
        End If
    End Sub

    Private Sub cboMonedaTrans_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonedaTrans.ValueChanged
        If cboBanco.SelectedIndex > -1 Then
            Dim leCuentaBancariaTemp As New List(Of e_CuentaBancaria)
            leCuentaBancariaTemp = leCuentaBancaria.Where(Function(item) item.IdBanco = cboBanco.Value And item.IdMoneda = cboMonedaTrans.Value).ToList
            LlenarCombo(cboCuentaBancaria, "NumeroCuenta", leCuentaBancariaTemp, -1)
            decImporteSoles.ReadOnly = IIf(cboMoneda.SelectedIndex = 0, False, True)
            decImporteDolares.ReadOnly = IIf(cboMoneda.SelectedIndex = 0, True, False)
            oeMonedaAux = cboMoneda.Items(cboMonedaDoc.SelectedIndex).ListObject
        End If
    End Sub

    Private Sub fecTransferencia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecTransferencia.ValueChanged
        CalculaDatosContable(fecTransferencia.Value.Date, 0)
    End Sub

    Private Sub fecEmision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecEmision.ValueChanged
        Try
            CalculaDatosContable(fecEmision.Value.Date, 1)
            If fecEmision.Value.Year <> ln_Ejercicio Then
                ln_Ejercicio = fecEmision.Value.Year
                CargarCta(ln_Ejercicio)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Inicializa_Contenido()
        BandBusDoc = False
        IdCtaContable = String.Empty
        IdDocCompra = String.Empty
        If cboTipo.SelectedIndex = 0 Then
            fecTransferencia.Focus()
        Else
            cboTipoDoc.Focus()
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            oeMovCuentaCte = New e_MovCuentaCte
            With oeMovCuentaCte
                mxid = mxid + 1
                .Id = mxid : .TipoOperacion = "I"
                .IdCuentaCorriente = IdCuentaCorriente : .IdTrabajador = IdTrabajador : .Trabajador = Trabajador
                .IngresoEgreso = cboMovimiento.SelectedIndex : .TipoReferencia = cboTipo.SelectedIndex
                .UsuarioCreacion = gUsuarioSGI.Id : .Mac = MacPCLocal() : .Liquidado = 0
                If cboTipo.SelectedIndex = 0 Then
                    ' Llenar Movimiento
                    .oeTransferencia.TipoOperacion = "I" : .oeTransferencia.Activo = 1
                    .Fecha = fecTransferencia.Value
                    .Importe = IIf(cboMonedaTrans.Text = "SOLES", decImporteSoles.Value, decImporteDolares.Value)
                    .Glosa = txtGlosaTrans.Text.Trim : .Referencia = cboTipo.Text.Trim
                    .Numero = txtNroOperacion.Text.Trim : .Proveedor = cboBanco.Text.Trim
                    If cboMovimiento.SelectedIndex = 0 Then
                        .Ingreso = IIf(cboMonedaTrans.Text = "SOLES", decImporteSoles.Value, decImporteDolares.Value)
                        .oeTransferencia.IdCuentaCorrienteDestino = IdCuentaCorriente
                    Else
                        oeMovCuentaCte.oeTransferencia.IdCuentaCorrienteOrigen = IdCuentaCorriente
                        oeMovCuentaCte.Egreso = IIf(cboMonedaTrans.Text = "SOLES", decImporteSoles.Value, decImporteDolares.Value)
                    End If
                    .Ingreso = Math.Round(.Ingreso, 2) : .Egreso = Math.Round(.Egreso, 2)
                    .IdMoneda = cboMonedaTrans.Value : .TipoCambio = decTipoCambio.Value
                    ' Llenar Transferencia
                    .oeTransferencia.Fecha = fecTransferencia.Value.Date
                    .oeTransferencia.IdBanco = cboCuentaBancaria.Value
                    .oeTransferencia.IdMoneda = cboMonedaTrans.Value
                    .oeTransferencia.TipoCambio = decTipoCambio.Value
                    .oeTransferencia.Numero = txtNroOperacion.Text.Trim
                    .oeTransferencia.Monto = IIf(cboMonedaTrans.Text = "SOLES", decImporteSoles.Value, decImporteDolares.Value)
                    .oeTransferencia.Concepto = txtGlosaTrans.Text.Trim
                    .oeTransferencia.UsuarioCreacion = gUsuarioSGI.Id
                    .oeTransferencia.oeCtaBancaria = cboCuentaBancaria.Items(cboCuentaBancaria.SelectedIndex).ListObject
                    .oeTransferencia.oePeriodo = oePeriodo
                Else
                    If ln_TipoCta = 4 Then
                        If decNeto.Value = 0 Then Throw New Exception("¡Ingrese Monto de Documento!")
                        If cboProveedor.SelectedIndex = -1 Then Throw New Exception("¡Seleccione Proveedor!")
                        If cboFlujoCaja.SelectedIndex = -1 Then Throw New Exception("¡Seleccione Flujo Caja!")
                        If oeTipoDocAux.Codigo = "16" Then .IdCtaTrans = IdCtaTrans
                    End If
                    oePeriodo = New e_Periodo
                    oePeriodo.Ejercicio = fecPeriodo.DateTime.Year
                    oePeriodo.Mes = fecPeriodo.DateTime.Month
                    oePeriodo = olPeriodo.Obtener(oePeriodo)
                    If oePeriodo.Id = "" Then
                        fecPeriodo.Focus()
                        Throw New Exception("No existe el periodo: " & fecPeriodo.DateTime.Month.ToString)
                    Else
                        If oePeriodo.CierreCompras Then
                            Throw New Exception("El periodo en Compras esta Cerrado: " & fecPeriodo.DateTime.Month.ToString)
                        End If
                    End If
                    If oePeriodo.Ejercicio = fecEmision.Value.Year Then
                        If oePeriodo.Mes < fecEmision.Value.Month Then
                            Throw New Exception("No Puede Ingresar un Documento Compra a un Periodo Menor")
                        End If
                    ElseIf oePeriodo.Ejercicio < fecEmision.Value.Year Then
                        Throw New Exception("No Puede Ingresar un Documento Compra a un Periodo Menor")
                    End If
                    ' LLenar Movimiento
                    .Fecha = fecEmision.Value
                    .Importe = decNeto.Value
                    .IdTipoDocumento = cboTipoDoc.Value
                    .Ingreso = IIf(cboMovimiento.SelectedIndex = 0, decNeto.Value, 0)
                    .Egreso = IIf(cboMovimiento.SelectedIndex = 0, 0, decNeto.Value)
                    .Glosa = txtGlosaDoc.Text.Trim
                    .Referencia = cboTipoDoc.Text.Trim
                    .IdFlujoCaja = IdFlujoCaja
                    .Numero = FormatoDocumento(txtSerie.Text, 4) & " - " & FormatoDocumento(txtNumero.Text, 10)
                    .Proveedor = cboProveedor.Text.Trim
                    .IdMoneda = cboMonedaDoc.Value
                    .TipoCambio = decTipoCambioDoc.Value
                    ' If decIgv.Value = 0 Then .IndNoGrabado = True


                    ' Llenar Movimiento Documento
                    .oeMovimientoDoc.TipoOperacion = IIf(BandBusDoc, "A", "I")
                    .oeMovimientoDoc.Id = IIf(BandBusDoc, IdDocCompra, String.Empty)
                    .oeMovimientoDoc.FechaEmision = fecEmision.Value
                    .oeMovimientoDoc.IdTipoDocumento = cboTipoDoc.Value
                    .oeMovimientoDoc.Serie = FormatoDocumento(txtSerie.Text, 4)
                    .oeMovimientoDoc.Numero = FormatoDocumento(txtNumero.Text, 4)
                    .oeMovimientoDoc.IdClienteProveedor = cboProveedor.Value
                    .oeMovimientoDoc.IdMoneda = cboMonedaDoc.Value
                    .oeMovimientoDoc.IdPeriodo = oePeriodo.Id
                    .oeMovimientoDoc.TipoCambio = decTipoCambioDoc.Value
                    '.oeMovimientoDoc.SubTotal = decSubtotal.Value
                    .oeMovimientoDoc.SubTotal = decSubtotal.Value + decNoGravada.Value
                    .oeMovimientoDoc.IGV = decIgv.Value + decPercepcion.Value
                    .oeMovimientoDoc.Total = decNeto.Value
                    .oeMovimientoDoc.IdUsuarioCrea = gUsuarioSGI.Id
                    .oeMovimientoDoc.Ejercicio = fecEmision.Value.Year
                    .oeMovimientoDoc.GlosaViajeGrupo = String.Empty
                    .oeMovimientoDoc.Mac_PC_Local = MacPCLocal()
                    .oeMovimientoDoc.NoGravado = decNoGravada.Value
                    If ln_TipoCta = 4 Then
                        .oeMovimientoDoc.Saldo = decNeto.Value
                        .oeMovimientoDoc.IndCompraVenta = 1
                        .oeMovimientoDoc.IdEstadoDocumento = "1CH00009"
                        .oeMovimientoDoc.IndServicioMaterial = "S"
                    End If
                    .oeMovimientoDoc.Compra.OtrosTributos = decPercepcion.Value
                    .oeMovimientoDoc.Compra.NoGravadas = decNoGravada.Value
                    .oeMovimientoDoc.Compra.TipoDoc = oeTipoDocAux
                    .oeMovimientoDoc.Compra.Proveedor = oeProveedorAux
                    .oeMovimientoDoc.Compra.Moneda = oeMonedaObtien
                    .oeMovimientoDoc.Compra.Base1 = IIf(decIgv.Value = 0, 0, decSubtotal.Value)
                    .oeMovimientoDoc.Compra.Igv1 = decIgv.Value
                    .oeMovimientoDoc.Compra.TotalIGVCompra = decIgv.Value
                    .oeMovimientoDoc.Compra.TotalBaseCompra = IIf(decIgv.Value = 0, 0, decSubtotal.Value)
                    .oeMovimientoDoc.Compra.TipoCompra = New e_TablaContableDet
                    .oeMovimientoDoc.Compra.TipoCompra.Id = oeFlujoCajaAux.IdTipoCompra
                    .oeMovimientoDoc.Compra.Glosa = txtGlosaDoc.Text.Trim
                    .oeMovimientoDoc.Compra.CobraCajaChica = 2
                    If ln_TipoCta = 4 Then
                        .oeMovimientoDoc.IdCuentaContable = IIf(cboMonedaDoc.Text = "SOLES", IdCtaSoles, IdCtaDolares)
                    Else
                        .oeMovimientoDoc.IdCuentaContable = IdCtaContable
                    End If
                    If ln_TipoCta = 4 Then olFunciones.ValidarDocumentoDuplicado(.oeMovimientoDoc)
                    Dim oeMovAn As New e_MovimientoAnalisis
                    Dim leListaAn As New List(Of e_MovimientoAnalisis)
                    Dim Divide As Integer = 0
                    .oeMovimientoDoc.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                    Divide = 1
                    oeMovAn.TipoOperacion = "I"
                    oeMovAn.IdItemGasto = oeFlujoCajaAux.IdItemGasto
                    oeMovAn.IdTrabajador = oeMovCuentaCte.IdTrabajador
                    oeMovAn.IdVehiculo = ""
                    oeMovAn.IdRuta = "" 'viaje trabaja con origen y destino
                    oeMovAn.Monto = decSubtotal.Value + decNoGravada.Value
                    oeMovAn.Saldo = decSubtotal.Value + decNoGravada.Value
                    oeMovAn.IdGastoFuncion = "1CH000087" '--costo de venta
                    oeMovAn.IdCuentaContable = oeFlujoCajaAux.CtaContable
                    leListaAn.Add(oeMovAn)
                    'End If
                    If cboTipoDoc.Text = "SUSTENTO CONTABLE" And oeMovAn.IdCuentaContable.Trim = "" Then
                        mensajeEmergente.Problema("Cuenta no Existe para este Flujo")
                    End If
                    For Each obj As e_MovimientoAnalisis In leListaAn
                        obj.Monto = obj.Monto / Divide
                        obj.Saldo = obj.Saldo / Divide
                        .oeMovimientoDoc.MovimientoAnalisis.Add(obj)
                    Next
                    BandBusDoc = False
                    IdCtaContable = String.Empty : IdDocCompra = String.Empty
                End If
            End With
            olMovCuentaCte.Validar(oeMovCuentaCte)
            leMovCuentaCte.Add(oeMovCuentaCte)
            'CalculaSaldo(leMovCuentaCte)
            'griMovimiento.DataBind()
            CargarMovCuentaCte(leMovCuentaCte)
            Inicializa_Contenido()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            If griMovimiento.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Registro para Eliminar!")
            Dim oeMovCtaCteAux As New e_MovCuentaCte
            oeMovCtaCteAux = griMovimiento.ActiveRow.ListObject
            If Len(griMovimiento.ActiveRow.Cells("Id").Value.ToString.Trim) < 3 Then
                If MessageBox.Show("¿Desea Eliminar el Registro?", "Mensaje del Sistema", _
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    oeMovCtaCteAux = leMovCuentaCte.Item(leMovCuentaCte.IndexOf(oeMovCtaCteAux))
                    If oeMovCtaCteAux.TipoOperacion = "I" Then
                        leMovCuentaCte.Remove(oeMovCtaCteAux)
                    Else
                        oeMovCtaCteAux.TipoOperacion = "E"
                    End If
                    CargarMovCuentaCte(leMovCuentaCte)
                End If
            Else
                Throw New Exception("No se puede quitar registro se encuentra Comprobantes de Compras?")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub decImporteSoles_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImporteSoles.ValueChanged
        If IsDBNull(decImporteSoles.Value) Then decImporteSoles.Value = 0
        If decTipoCambio.Value > 0 Then
            decImporteDolares.Value = Math.Round(decImporteSoles.Value / decTipoCambio.Value, 4)
        Else
            decImporteDolares.Value = 0
        End If
    End Sub

    Private Sub decImporteDolares_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImporteDolares.ValueChanged
        If IsDBNull(decImporteDolares.Value) Then decImporteDolares.Value = 0
        If decImporteDolares.Value > 0 Then decImporteSoles.Value = Math.Round(decImporteDolares.Value * decTipoCambio.Value, 4)
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
    End Sub

    Private Sub decSubtotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decSubtotal.ValueChanged
        If IsDBNull(decSubtotal.Value) Then decSubtotal.Value = 0
        mt_HabilitarIgv()
    End Sub

    Private Sub decIgv_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decIgv.ValueChanged
        If IsDBNull(decIgv.Value) Then decIgv.Value = 0
        decTotal.Value = decSubtotal.Value + decIgv.Value
    End Sub

    Private Sub cboTipoDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDoc.ValueChanged
        If cboTipoDoc.SelectedIndex > -1 Then
            oeTipoDocAux = cboTipoDoc.Items(cboTipoDoc.SelectedIndex).ListObject
            If oeTipoDocAux.Codigo = "02" Or oeTipoDocAux.Codigo = "16" Then
                decSubtotal.Value = 0
            Else
                decNoGravada.Value = 0
            End If
            mt_HabilitarIgv
        End If
    End Sub

    Private Sub cboProveedor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedor.ValueChanged
        If cboProveedor.SelectedIndex > -1 Then oeProveedorAux = cboProveedor.Items(cboProveedor.SelectedIndex).ListObject
    End Sub

    Private Sub cboFlujoCaja_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFlujoCaja.ValueChanged
        If cboFlujoCaja.SelectedIndex > -1 Then oeFlujoCajaAux = cboFlujoCaja.Items(cboFlujoCaja.SelectedIndex).ListObject : IdFlujoCaja = cboFlujoCaja.Value
    End Sub

    Private Sub btnLiquidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiquidar.Click
        Try
            If MessageBox.Show("¿Desea Liquidar la Cuenta de: " & Trabajador & "?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                For Each oeMovCtaCte As e_MovCuentaCte In leMovCuentaCte
                    oeMovCtaCte.TipoOperacion = "L"
                    oeMovCtaCte.Liquidado = 0
                    oeMovCtaCte.UsuarioLiquida = gUsuarioSGI.Id
                Next
                olMovCuentaCte.GuardarLista(leMovCuentaCte)
                MostrarTabs(0, ficDocAosciados)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griMovimiento_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griMovimiento.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub decNoGravada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decNoGravada.ValueChanged
        If IsDBNull(decNoGravada.Value) Then decNoGravada.Value = 0
        mt_HabilitarIgv()
    End Sub

    Private Sub decPrecepcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decPercepcion.ValueChanged
        If IsDBNull(decPercepcion.Value) Then decPercepcion.Value = 0
        CalcularNeto()
    End Sub

    Private Sub cboMonedaDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonedaDoc.ValueChanged
        If cboMonedaDoc.SelectedIndex <> -1 Then
            oeMonedaObtien = cboMonedaDoc.Items(cboMonedaDoc.SelectedIndex).ListObject
        End If
    End Sub

    Private Sub btnBuscaDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaDoc.Click
        Try
            MostrarTabs(3, ficDocAosciados, 3)
            ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
            leMovimientoDoc = New List(Of e_MovimientoDocumento)
            Cargar_DocumentosCompra(leMovimientoDoc)
            txtBusSerieDoc.Text = String.Empty
            txtBusNumero.Text = String.Empty
            cboBusTipoDoc.SelectedIndex = -1
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDoc.Click
        Try
            oeMovimientoDoc = New e_MovimientoDocumento
            oeMovimientoDoc.Serie = txtBusSerieDoc.Text.Trim
            oeMovimientoDoc.Numero = txtBusNumero.Text.Trim
            oeMovimientoDoc.IdTipoDocumento = cboBusTipoDoc.Value
            oeMovimientoDoc.TipoOperacion = "MOV"
            leMovimientoDoc = olMovimientoDoc.ListarDocumentosPorCompras(oeMovimientoDoc)
            Cargar_DocumentosCompra(leMovimientoDoc)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtBusSerieDoc_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusSerieDoc.Validated
        If txtBusSerieDoc.Text.Trim <> "" Then txtBusSerieDoc.Text = FormatoDocumento(txtBusSerieDoc.Text, 4)
    End Sub

    Private Sub txtBusNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusNumero.Validated
        If txtBusNumero.Text.Trim <> "" Then txtBusNumero.Text = FormatoDocumento(txtBusNumero.Text, 10)
    End Sub

    Private Sub griDocCompra_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griDocCompra.DoubleClick
        Try
            If griDocCompra.Rows.Count > 0 Then
                If MessageBox.Show("¿Desea Seleccionar este Documento?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    oeMovimientoDoc = New e_MovimientoDocumento
                    oeMovimientoDoc = griDocCompra.ActiveRow.ListObject
                    MostrarTabs(1, ficDocAosciados, 1)
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                    cboTipoDoc.Value = oeMovimientoDoc.IdTipoDocumento
                    txtSerie.Text = oeMovimientoDoc.Serie
                    txtNumero.Text = oeMovimientoDoc.Numero
                    cboMonedaDoc.Value = oeMovimientoDoc.IdMoneda
                    fecEmision.Value = oeMovimientoDoc.FechaEmision
                    CalculaDatosContable(fecEmision.Value.Date, 1)
                    cboProveedor.Value = oeMovimientoDoc.IdClienteProveedor
                    decSubtotal.Value = oeMovimientoDoc.SubTotal
                    decIgv.Value = oeMovimientoDoc.IGV
                    decTotal.Value = oeMovimientoDoc.Total
                    decPercepcion.Value = oeMovimientoDoc.Percepcion
                    decDetraccion.Value = oeMovimientoDoc.Detraccion
                    decNeto.Value = oeMovimientoDoc.Saldo
                    decTipoCambioDoc.Value = oeMovimientoDoc.TipoCambio
                    IdCtaContable = oeMovimientoDoc.IdCuentaContable
                    cboFlujoCaja.Text = "OTROS"
                    txtGlosaDoc.Text = oeMovimientoDoc.TipoPago
                    IdDocCompra = oeMovimientoDoc.Id
                    BandBusDoc = True
                End If
            Else
                Throw New Exception("No hay Documentos para Seleccionar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub decTotal_ValueChanged(sender As Object, e As EventArgs) Handles decTotal.ValueChanged
        CalcularNeto()
    End Sub

    Private Sub decDetraccion_ValueChanged(sender As Object, e As EventArgs) Handles decDetraccion.ValueChanged
        CalcularNeto()
    End Sub

    Private Sub cboTipoCuentaBusq_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoCuentaBusq.ValueChanged
        If cboTipoCuentaBusq.SelectedIndex > -1 Then
            leCuentaCteBusq = New List(Of e_CuentaCorriente)
            oeCuentaCte = New e_CuentaCorriente
            oeCuentaCte.Id = String.Empty : oeCuentaCte.Trabajador = "[TODOS]"
            leCuentaCteBusq.Add(oeCuentaCte)
            If cboTipoCuentaBusq.SelectedIndex = 0 Then
                leCuentaCteBusq.AddRange(leCuentaCte.Where(Function(it) it.Tipo = 2).ToList)
                LlenarCombo(cboCuentaTrans, "Trabajador", leCuentaCteBusq, 0)
            Else
                leCuentaCteBusq.AddRange(leCuentaCte.Where(Function(it) it.Tipo = 4).ToList)
                LlenarCombo(cboCuentaTrans, "Trabajador", leCuentaCteBusq, 0)
            End If
            CargarSaldoCtaCte(New List(Of e_SaldoCtaCorriente))
        End If
    End Sub

    Private Sub griDocumentos_DoubleClick(sender As Object, e As EventArgs) Handles griDocumentos.DoubleClick
        Try
            If griDocumentos.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Registro!")
            oeDocPago = New e_MovimientoDocumento
            oeDocPago = griDocumentos.ActiveRow.ListObject
            oeDocPago.TipoOperacion = "I"
            If ValidarAgregarDetalle(oeDocPago) Then
                With leDocPago
                    If Not .Contains(oeDocPago) Then
                        .Add(oeDocPago.Clonar)
                    Else
                        Throw New Exception("Ya existe este documento asociado")
                    End If
                End With
                griDocPagar.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    'Private Sub LlenaMovimiento()
    '    Dim objValueList As Infragistics.Win.ValueList = Nothing
    '    Me.griMovimiento.DisplayLayout.ValueLists.Clear()
    '    objValueList = Me.griMovimiento.DisplayLayout.ValueLists.Add("Movimientos")

    '    objValueList.ValueListItems.Add(0, "INGRESO")
    '    objValueList.ValueListItems.Add(1, "EGRESO")

    '    griMovimiento.DisplayLayout.Bands(0).Columns("IngresoEgreso").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
    '    griMovimiento.DisplayLayout.Bands(0).Columns("IngresoEgreso").ValueList = objValueList
    '    griMovimiento.DisplayLayout.ValueLists("Movimientos").MaxDropDownItems = 20
    'End Sub

    Private Sub LlenaMoneda()
        Try
            Dim oeMoneda As New e_Moneda, olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla    
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            Me.griMovimiento.DisplayLayout.ValueLists.Clear()
            objValueList = Me.griMovimiento.DisplayLayout.ValueLists.Add("IdMoneda")

            For Each oeTD As e_Moneda In leMoneda
                objValueList.ValueListItems.Add(oeTD.Id, oeTD.Nombre)
            Next
            CrearComboGrid3("IdMoneda", "Nombre", griMovimiento, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCombo()
        Try
            ' Cargar Cuentas
            oeCuentaCte = New e_CuentaCorriente
            oeCuentaCte.Tipooperacion = String.Empty : oeCuentaCte.Tipo = 2
            leCuentaCte = olCuentaCte.Listar(oeCuentaCte)
            oeCuentaCte = New e_CuentaCorriente
            oeCuentaCte.Tipooperacion = String.Empty : oeCuentaCte.Tipo = 4
            leCuentaCte.AddRange(olCuentaCte.Listar(oeCuentaCte))
            ' Cargar Cuentas para Pago
            Dim leCuentaCtaPago As New List(Of e_CuentaCorriente)
            leCuentaCtaPago.AddRange(leCuentaCte.Where(Function(it) it.Tipo = 4).ToList)
            LlenarCombo(cboTrabajadorPago, "Trabajador", leCuentaCtaPago, -1)
            ' Cargar Trabajador
            oeTrabajador.TipoOperacion = "P"
            Dim _leTrabTemp = olTrabajador.Listar(oeTrabajador)
            Dim _leTrabAux = From le In _leTrabTemp _
                             Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.oePersona.ApellidoPaterno, le.oePersona.ApellidoMaterno, _
                             le.oePersona.Nombre, Area = le.oeArea.Nombre, Cargo = le.oeCargo.Nombre, Sexo = le.oePersona.oeSexo.Abreviatura, _
                             le.oePersona.FechaNacimiento, le.FechaIngreso, Ocupacion = le.oeOcupacion.Nombre
            LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAux.ToList, -1)
            ' Cargar Moneda
            oeMoneda = New e_Moneda
            oeMoneda.TipoOperacion = String.Empty : oeMoneda.Activo = 1
            leMoneda = olMoneda.Listar(oeMoneda)
            leMonedaTrans = olMoneda.Listar(oeMoneda)
            leMonedaDoc = olMoneda.Listar(oeMoneda)
            LlenarCombo(cboMoneda, "Nombre", leMoneda, 0)
            LlenarCombo(cboMonedaTrans, "Nombre", leMonedaTrans, 0)
            LlenarCombo(cboMonedaDoc, "Nombre", leMonedaDoc, 0)
            ' Cargar Estado
            oeEstado = New e_Estado
            oeEstado.Nombre = "BOLSA DE VIAJE"
            leEstado = olEstado.Listar(oeEstado)
            ' Cargar Movimientos
            cboMovimiento.Items.Clear()
            cboMovimiento.Items.Add("INGRESO")
            cboMovimiento.Items.Add("EGRESO")
            ' Cargar Tipo Movimientos
            cboTipo.Items.Clear()
            cboTipo.Items.Add("TRANSFERENCIA")
            cboTipo.Items.Add("DOCUMENTOS")
            ' Cargar Tipo Cuentas
            cboTipoCuenta.Clear()
            cboTipoCuenta.Items.Add("POR TRANSFERENCIA")
            cboTipoCuenta.Items.Add("POR BONIFICACION")
            cboTipoCuentaBusq.Clear()
            cboTipoCuentaBusq.Items.Add("POR TRANSFERENCIA")
            cboTipoCuentaBusq.Items.Add("POR BONIFICACION")
            cboTipoCuentaBusq.SelectedIndex = 0
            ' Cargar Estado
            cboEstadoBusq.Clear()
            cboEstadoBusq.Items.Add("[TODOS]")
            cboEstadoBusq.Items.Add("GENERADA/HABILITADA")
            cboEstadoBusq.Items.Add("LIQUIDADA")
            cboEstadoBusq.SelectedIndex = 1
            ' Cargar Bancos
            oeBanco = New e_Banco
            oeBanco.TipoOperacion = String.Empty : oeBanco.Activo = 1
            leBanco = olBanco.Listar(oeBanco)
            LlenarCombo(cboBanco, "Nombre", leBanco, -1)
            ' Cargar Cuentas Bancarias
            oeCuentaBancaria = New e_CuentaBancaria
            oeCuentaBancaria.TipoOperacion = String.Empty : oeCuentaBancaria.Activo = 1
            leCuentaBancaria = olCuentaBancaria.Listar(oeCuentaBancaria)
            ' Cargar Proveedores
            oeProveedor = New e_Proveedor
            oeProveedor.TipoOperacion = String.Empty : oeProveedor.Activo = 1
            leProveedor = olProveedor.Listar(oeProveedor)
            LlenarCombo(cboProveedor, "Nombre", leProveedor, -1)
            ' Cargar Tipo Documentos
            oeTipoDoc = New e_TipoDocumento : leTipoDocBono = New List(Of e_TipoDocumento)
            oeTipoDoc.TipoOperacion = "S" : oeTipoDoc.Activo = 1
            leTipoDoc = olTipoDoc.Listar(oeTipoDoc)
            leTipoDocBono.AddRange(leTipoDoc.Where(Function(it) it.Codigo = "16" Or it.Codigo = "01" Or it.Codigo = "02" Or it.Codigo = "12").ToList)
            leTipoDocBus.AddRange(leTipoDoc)
            ' LlenarCombo(cboTipoDoc, "Nombre", leTipoDoc, -1)
            LlenarCombo(cboBusTipoDoc, "Nombre", leTipoDocBus, 0)
            ' Cargar Flujo
            oeFlujoCaja = New e_FlujoCaja
            oeFlujoCaja.TipoOperacion = "P" : oeFlujoCaja.NombProceso = "Tesoreria"
            leFlujoCaja = olFlujoCaja.Listar(oeFlujoCaja)
            LlenarCombo(cboFlujoCaja, "Nombre", leFlujoCaja, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializaCuentaCte()
        cboTrabajador.SelectedIndex = -1
        cboMoneda.SelectedIndex = 0
        cboTrabajador.Focus()
        InicializaDatosTrab()
    End Sub

    Private Sub InicializaDatosTrab()
        txtNroDni.Text = String.Empty
        txtApellidoPaterno.Text = String.Empty
        txtApellidoMaterno.Text = String.Empty
        txtNombre.Text = String.Empty
        txtArea.Text = String.Empty
        txtCargo.Text = String.Empty
        imaTrab.Image = Nothing
        optSexo.CheckedIndex = -1
        fecNacimiento.Value = Date.Now.Date
        CargarCuenta(New List(Of e_CuentaCorriente))
    End Sub

    Private Sub CargarDatosTrab()
        Try
            InicializaDatosTrab()
            Dim _oeTrab = cboTrabajador.SelectedItem.ListObject
            With _oeTrab
                txtNroDni.Text = .Dni
                If Not String.IsNullOrEmpty(.Dni) Then imaTrab.Image = olPersona.Foto(.Dni)
                txtApellidoPaterno.Text = .ApellidoPaterno
                txtApellidoMaterno.Text = .ApellidoMaterno
                txtNombre.Text = .Nombre
                optSexo.CheckedIndex = IIf(.Sexo = "M", 0, 1)
                fecNacimiento.Value = .FechaNacimiento
                txtArea.Text = .Area
                txtCargo.Text = .Cargo
                txtOcupacion.Text = .Ocupacion
                fecInicio.Value = .FechaIngreso
                griCuentas.Text = "Cuentas Asociadas al Trabajador: " & .NombreCompleto
                oeCuentaCte = New e_CuentaCorriente
                oeCuentaCte.Tipooperacion = String.Empty : oeCuentaCte.Activo = 1 : oeCuentaCte.IdTrabajador = .Id : oeCuentaCte.Tipo = -1
                Dim leCuentaCteTrab As New List(Of e_CuentaCorriente)
                leCuentaCteTrab = olCuentaCte.Listar(oeCuentaCte)
                CargarCuenta(leCuentaCteTrab)
                leCuentaCteTrabBus = leCuentaCteTrab.Where(Function(item) item.Tipo = ((cboTipoCuenta.SelectedIndex + 1) * 2)).ToList
                If leCuentaCteTrabBus.Count > 0 Then ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0) Else ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarCuenta(ByVal leCuentaCte As List(Of e_CuentaCorriente))
        Try
            With griCuentas
                If lb_Load Then .ResetDisplayLayout()
                .DataSource = leCuentaCte
                If lb_Load Then
                    ConfiguraGrilla(griCuentas, "Tahoma", False, UIElementBorderStyle.Default)
                    OcultarColumna2(griCuentas, False, "Codigo", "TipoCuenta", "NombreMoneda", "TotalCargo", "TotalAbono", "Saldo", "Glosa", "Estado")
                    .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("TipoCuenta").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("NombreMoneda").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("TotalCargo").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("TotalAbono").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("Saldo").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("TipoCuenta").Width = 120
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 300
                    .DisplayLayout.Bands(0).Columns("NombreMoneda").Width = 60
                    .DisplayLayout.Bands(0).Columns("NombreMoneda").Header.Caption = "Moneda"
                    FormatoColumna(griCuentas, "#,##0.00", ColumnStyle.Double, HAlign.Right, "TotalCargo", "TotalAbono", "Saldo")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Guardando()
        Try
            Select Case ficDocAosciados.SelectedTab.Index
                Case 1
                    If ln_TipoCta = 2 Then ' Transferencia
                        olMovCuentaCte.GuardarLista(leMovCuentaCte)
                        mensajeEmergente.Confirmacion("Los Movimientos se guardaron correctamente", True)
                        MostrarTabs(0, ficDocAosciados)
                        Consultar(True)
                    Else ' Bonos
                        Dim _leMovGuardar = leMovCuentaCte.Where(Function(it) it.TipoOperacion.Trim <> "").ToList
                        If _leMovGuardar.Count > 0 Then
                            ' Cargar Fecha Servidor
                            Dim _FechaServ = ObtenerFechaServidor()
                            Dim _TipoCambio = TipoCambio(_FechaServ, True)(0)
                            ' Obtener Periodo

                            'oePeriodo = New e_Periodo
                            'oePeriodo.Ejercicio = _FechaServ.Year : oePeriodo.Mes = _FechaServ.Month : oePeriodo.Activo = True
                            'oePeriodo = olPeriodo.Obtener(oePeriodo)

                            ' Cargar Datos de Asiento Modelo
                            Dim leAsiMod As New List(Of e_AsientoModelo)
                            Dim oeAsiModAux As New e_AsientoModelo
                            oeAsiModAux.TipoOperacion = ""
                            oeAsiModAux.Id = oeAsientoModel.Id
                            oeAsiModAux = olAsientoModel.Obtener(oeAsiModAux)
                            oeAsiModAux.FechaMov = _FechaServ
                            oeAsiModAux.IdPeriodo = oePeriodo.Id
                            oeAsiModAux.TipoCambio = _TipoCambio
                            oeAsiModAux.UsuarioCreacion = gUsuarioSGI.Id
                            oeAsiModAux.IndVinculado = True
                            leAsiMod.Add(oeAsiModAux)
                            If olMovCuentaCte.GuardarLista2(leMovCuentaCte, leAsiMod, PrefijoIdSucursal) Then
                                mensajeEmergente.Confirmacion("Los Documentos se guardaron correctamente", True)
                                MostrarTabs(0, ficDocAosciados)
                                Consultar(True)
                            End If
                        Else
                            mensajeEmergente.Problema("No ha ingresado informacion para guardar", True)
                        End If
                    End If
                Case 2
                    oeCuentaCte = New e_CuentaCorriente
                    oeCuentaCte.TipoOperacion = "I"
                    oeCuentaCte.IdTrabajador = cboTrabajador.Value
                    oeCuentaCte.IdMoneda = cboMoneda.Value
                    oeCuentaCte.Usuario = gUsuarioSGI.Id
                    oeCuentaCte.Saldo = 0
                    oeCuentaCte.Tipo = (cboTipoCuenta.SelectedIndex + 1) * 2
                    oeCuentaCte.Glosa = IIf(cboTipoCuenta.SelectedIndex = 0, "PARA TRASFERENCIA", "PARA BONIFICACION")
                    Dim leEst As New List(Of e_Estado)
                    leEst = leEstado.Where(Function(item) item.Nombre = "HABILITADA").ToList
                    oeCuentaCte.IdEstado = leEst(0).Id
                    If olCuentaCte.Guardar(oeCuentaCte) Then
                        mensajeEmergente.Confirmacion("Los Movimientos se guardaron correctamente", True)
                        If MessageBox.Show("¿Desea Agregar Movimiento a esta Cuenta?", "Mensaje de Sistema", _
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            IdCuentaCorriente = oeCuentaCte.Id : Trabajador = cboTrabajador.Text.Trim
                            MostrarTabs(1, ficDocAosciados, 1)
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                            InicializaMovCuentaCte(0)
                            oeMovCuentaCte = New e_MovCuentaCte
                            oeMovCuentaCte.IdCuentaCorriente = IdCuentaCorriente
                            leMovCuentaCte = olMovCuentaCte.Listar(oeMovCuentaCte)
                            CargarMovCuentaCte(leMovCuentaCte)
                            CalculaDatosContable(fecTransferencia.Value.Date, 0)
                            fecTransferencia.Focus()
                        Else
                            MostrarTabs(0, ficDocAosciados)
                            Consultar(True)
                        End If
                    End If
                Case 4
                    If leDocPago.Count = 0 Then Throw New Exception("¡Ingrese Documentos a Pagar!")
                    Dim _MontoAux = leDocPago.Sum(Function(it) it.MontoOperar)
                    If _MontoAux > decMontoPagar.Value Then Throw New Exception("¡El total de documentos excede el monto a pagar!")
                    ' Obtener Periodo 
                    oePeriodo = New e_Periodo
                    oePeriodo.Ejercicio = fecPago.Value.Year : oePeriodo.Mes = fecPago.Value.Month : oePeriodo.Activo = True
                    oePeriodo = olPeriodo.Obtener(oePeriodo)
                    ' Cargar Asiento Modelo
                    Dim oeAsiModAux As New e_AsientoModelo
                    oeAsiModAux.TipoOperacion = ""
                    oeAsiModAux.Id = oeAsiModPago.Id
                    oeAsiModAux = olAsientoModel.Obtener(oeAsiModAux)
                    oeAsiModAux.FechaMov = fecPago.Value
                    oeAsiModAux.IdPeriodo = oePeriodo.Id
                    oeAsiModAux.TipoCambio = numTipoCambioPago.Value
                    oeAsiModAux.UsuarioCreacion = gUsuarioSGI.Id
                    oeSaldoCuentaCte.leMovCtaCte = New List(Of e_MovCuentaCte)
                    ' Actualizar Cuenta Contable
                    Dim _oeMovAux As e_MovCuentaCte
                    For Each _oeMovDoc In leDocPago
                        _oeMovDoc.IdCtaPagarCobrar = IIf(_oeMovDoc.IdCuentaContable.Trim = "42121", IdCtaSoles, IdCtaDolares)
                        _oeMovAux = New e_MovCuentaCte
                        _oeMovAux.Id = _oeMovDoc.IdMotivoDocumento
                        _oeMovAux.MontoPago = _oeMovDoc.MontoOperar
                        _oeMovAux.IdReferencia = _oeMovDoc.Id
                        Dim _saldo As Double = 0
                        _saldo = Math.Abs(_oeMovDoc.Saldo - _oeMovDoc.MontoOperar)
                        _oeMovAux.Importe = _saldo
                        _oeMovAux.IngresoEgreso = "1"
                        _oeMovAux.TipoOperacion = "D"
                        If _saldo > -0.005 And _saldo < 0.005 Then
                            _oeMovAux.FechaLiquida = fecPago.Value
                            _oeMovAux.UsuarioLiquida = gUsuarioSGI.Id
                            _oeMovAux.Liquidado = 1
                        End If
                        oeSaldoCuentaCte.leMovCtaCte.Add(_oeMovAux)
                    Next
                    ' Crear Movimiento de Pago
                    _oeMovAux = New e_MovCuentaCte
                    _oeMovAux.TipoOperacion = "I"
                    _oeMovAux.Activo = True
                    _oeMovAux.IdCuentaCorriente = oeSaldoCuentaCte.IdCuentaCorriente
                    _oeMovAux.Fecha = fecPago.Value
                    _oeMovAux.Importe = _MontoAux
                    _oeMovAux.Glosa = "PAGO EN EFECTIVO"
                    _oeMovAux.TipoReferencia = 2
                    _oeMovAux.IngresoEgreso = 0
                    _oeMovAux.UsuarioCreacion = gUsuarioSGI.Id
                    _oeMovAux.TipoCambio = numTipoCambioPago.Value
                    _oeMovAux.IdMoneda = "1CH01"
                    _oeMovAux.Liquidado = 1
                    _oeMovAux.FechaLiquida = Date.Now
                    _oeMovAux.UsuarioLiquida = gUsuarioSGI.Id
                    oeSaldoCuentaCte.leMovCtaCte.Add(_oeMovAux)
                    ' Actualiza datos de Saldo
                    oeSaldoCuentaCte.FechaLiquida = fecPago.Value
                    oeSaldoCuentaCte.Liquidado = 1
                    oeSaldoCuentaCte.Cargo = _MontoAux
                    oeSaldoCuentaCte.Saldo = oeSaldoCuentaCte.Cargo - oeSaldoCuentaCte.Abono
                    Dim _olAsiento As New l_Asiento
                    If _olAsiento.PagoBono(leDocPago, oeAsiModAux, oeSaldoCuentaCte) Then
                        mensajeEmergente.Confirmacion("¡Pago efectuado correctamente!", True)
                        MostrarTabs(0, ficDocAosciados, 0)
                        Consultar(True)
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeSaldoCuentaCte = New e_SaldoCtaCorriente
            oeSaldoCuentaCte.TipoOperacion = String.Empty : oeSaldoCuentaCte.Activo = 1
            oeSaldoCuentaCte.TipoCuenta = (cboTipoCuentaBusq.SelectedIndex + 1) * 2
            If cboEstadoBusq.SelectedIndex > 0 Then oeSaldoCuentaCte.Liquidado = cboEstadoBusq.SelectedIndex - 1
            oeSaldoCuentaCte.IdCuentaCorriente = cboCuentaTrans.Value
            CargarSaldoCtaCte(olSaldoCuentaCte.Listar(oeSaldoCuentaCte))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarSaldoCtaCte(ByVal leSaldoCtaCte As List(Of e_SaldoCtaCorriente))
        Try
            With griSaldoCuenta
                If lb_Load Then .ResetDisplayLayout()
                .DataSource = leSaldoCtaCte.OrderByDescending(Function(it) it.FechaCreacion).ToList
                If lb_Load Then
                    ConfiguraGrilla(griSaldoCuenta, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna2(griSaldoCuenta, False, "Dni", "Trabajador", "FechaCreacion", "Monto", "Saldo", "Liquidado")
                    .DisplayLayout.Bands(0).Columns("Dni").Width = 80
                    .DisplayLayout.Bands(0).Columns("Trabajador").Width = 300
                    .DisplayLayout.Bands(0).Columns("Monto").Width = 100
                    .DisplayLayout.Bands(0).Columns("Saldo").Width = 100
                    .DisplayLayout.Bands(0).Columns("Cargo").Width = 100
                    .DisplayLayout.Bands(0).Columns("Abono").Width = 100
                    .DisplayLayout.Bands(0).Columns("FechaCreacion").Width = 80
                    .DisplayLayout.Bands(0).Columns("FechaCreacion").Header.Caption = "Fecha"
                    FormatoColumna(griSaldoCuenta, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto", "Saldo", "Cargo", "Abono")
                    FormatoColumna(griSaldoCuenta, "", ColumnStyle.CheckBox, HAlign.Center, "Liquidado")
                    FormatoColumna(griSaldoCuenta, "", ColumnStyle.Date, HAlign.Default, "FechaCreacion")
                End If
                If cboTipoCuentaBusq.SelectedIndex = 0 Then
                    OcultarColumna2(griSaldoCuenta, False, "FechaCreacion", "Dni", "Trabajador", "Monto", "Saldo", "Liquidado")
                Else
                    OcultarColumna2(griSaldoCuenta, False, "FechaCreacion", "Dni", "Trabajador", "Monto", "Cargo", "Abono", "Saldo", "Liquidado")
                End If
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarMovCuentaCte(ByVal leMovCtaCte As List(Of e_MovCuentaCte))
        Try
            With griMovimiento
                If lb_Load Then .ResetDisplayLayout()
                Dim leActivo As New List(Of e_MovCuentaCte)
                leActivo = leMovCtaCte.Where(Function(item) item.TipoOperacion <> "E").ToList
                .DataSource = leActivo
                LlenaMoneda()
                If lb_Load Then
                    ConfiguraGrilla(griMovimiento, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna2(griMovimiento, False, "Fecha", "Referencia", "Proveedor", "Numero", "Glosa", "TipoCambio", "Ingreso", "Egreso", "Liquidado", "IdMoneda")
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Header.Caption = "Moneda"
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Header.Caption = "T.C."
                    .DisplayLayout.Bands(0).Columns("Referencia").Width = 120
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Width = 60
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Width = 50
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 250
                    .DisplayLayout.Bands(0).Columns("Numero").Width = 120
                    .DisplayLayout.Bands(0).Columns("Proveedor").Width = 200
                    FormatoColumna(griMovimiento, "", ColumnStyle.CheckBox, HAlign.Center, "Liquidado")
                    FormatoColumna(griMovimiento, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Importe", "Ingreso", "Egreso", "TipoCambio")
                End If
            End With
            CalculaSaldo(leMovCtaCte)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializaMovCuentaCte(ByVal ind As Integer)
        cboMovimiento.SelectedIndex = ind
        cboTipo.SelectedIndex = ind
        agrContenedor.Text = cboMovimiento.Text & " por " & cboTipo.Text & " para: " & Trabajador
        Inicializa_Contenido()
        leMovCuentaCte = New List(Of e_MovCuentaCte)
        CargarMovCuentaCte(leMovCuentaCte)
    End Sub

    Private Sub Inicializa_Contenido()
        'Transferencias
        decTipoCambio.Value = 0
        fecTransferencia.Value = Date.Now.Date
        'CalculaDatosContable(Date.Now.Date, 0)
        cboBanco.SelectedIndex = -1
        cboMonedaTrans.SelectedIndex = 0
        cboCuentaBancaria.SelectedIndex = -1
        txtNroOperacion.Text = String.Empty
        decImporteSoles.Value = 0
        decImporteDolares.Value = 0
        txtGlosaTrans.Text = String.Empty
        'Documentos
        If cboTipoCuentaBusq.SelectedIndex = 0 Then
            LlenarCombo(cboTipoDoc, "Nombre", leTipoDoc, -1)
            cboTipoDoc.ReadOnly = True
            btnBuscaDoc.Enabled = True
        Else
            LlenarCombo(cboTipoDoc, "Nombre", leTipoDocBono, -1)
            cboTipoDoc.ReadOnly = False
            btnBuscaDoc.Enabled = False
        End If
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        cboProveedor.SelectedIndex = -1
        fecEmision.Value = Date.Now.Date
        decTipoCambioDoc.Value = TipoCambio(Date.Now.Date, True)(0)
        'CalculaDatosContable(Date.Now.Date, 1)
        cboMonedaDoc.SelectedIndex = 0
        decNoGravada.Value = 0
        decPercepcion.Value = 0
        decSubtotal.Value = 0
        decIgv.Value = 0
        decTotal.Value = 0
        decNeto.Value = 0
        decDetraccion.Value = 0
        txtGlosaDoc.Text = String.Empty
        cboFlujoCaja.SelectedIndex = -1
    End Sub

    Private Sub CalculaDatosContable(ByVal Fecha As Date, ByVal tipo As Integer)
        Try
            tc = TipoCambio(Fecha, True)(0)
            If tipo = 0 Then decTipoCambio.Value = tc Else decTipoCambioDoc.Value = tc
            oeIgv = New e_Impuesto
            oeIgv = olIgv.IGV(Fecha)
            oePeriodo = New e_Periodo
            oePeriodo.Ejercicio = Fecha.Year : oePeriodo.Mes = Fecha.Month : oePeriodo.Activo = 1
            oePeriodo = olPeriodo.Obtener(oePeriodo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        'Transferencia
        If excepcion.Contains("Cuenta Bancaria") Then cboCuentaBancaria.Focus()
        If excepcion.Contains("Número Operación") Then txtNroOperacion.Focus()
        'Documentos
        If excepcion.Contains("Tipo Documento") Then cboTipoDoc.Focus()
        If excepcion.Contains("Serie") Then txtSerie.Focus()
        If excepcion.Contains("Numero") Then txtNumero.Focus()
        If excepcion.Contains("Proveedor") Then cboProveedor.Focus()
        If excepcion.Contains("Documento") Then cboProveedor.Focus()
        If excepcion.Contains("Periodo") Then fecEmision.Focus()
    End Sub

    Private Sub CalculaSaldo(ByVal leMovCtaCte As List(Of e_MovCuentaCte))
        If leMovCtaCte.Count > 0 Then
            Dim leMovCtaCteAux As New List(Of e_MovCuentaCte)
            leMovCtaCteAux = leMovCtaCte.Where(Function(item) item.TipoOperacion <> "E").ToList
            Dim importeIng As Decimal = 0, importeEgr As Decimal = 0
            For Each obj As e_MovCuentaCte In leMovCtaCteAux
                If obj.IdMoneda = "1CH01" Then
                    importeIng = importeIng + obj.Ingreso : importeEgr = importeEgr + obj.Egreso
                Else
                    importeIng = importeIng + (obj.Ingreso * obj.TipoCambio) : importeEgr = importeEgr + (obj.Egreso * obj.TipoCambio)
                End If
            Next
            decIngreso.Value = importeIng : decEgreso.Value = importeEgr : decSaldo.Value = importeIng - importeEgr
            btnLiquidar.Enabled = IIf(Math.Round(decSaldo.Value) = 0, True, False)
        Else
            decIngreso.Value = 0 : decEgreso.Value = 0 : decSaldo.Value = 0 : btnLiquidar.Enabled = False
        End If
    End Sub

    Private Sub Habilita(ByVal var As Boolean)
        btnLiquidar.Enabled = var : btnAgregar.Enabled = var : btnLimpiar.Enabled = var : btnQuitar.Enabled = var
    End Sub

    Private Sub Movimiento(ByVal xind As Integer)
        Try
            If griSaldoCuenta.Rows.Count > 0 Then
                IdTrabajador = String.Empty
                Dim liq As Integer = -1
                MostrarTabs(1, ficDocAosciados, 1)
                Habilita(True)
                mxid = 0
                IdCuentaCorriente = griSaldoCuenta.ActiveRow.Cells("IdCuentaCorriente").Value.ToString
                Trabajador = griSaldoCuenta.ActiveRow.Cells("Trabajador").Value.ToString
                Dim leCtaCte As New List(Of e_CuentaCorriente)
                leCtaCte = leCuentaCte.Where(Function(item) item.Id = IdCuentaCorriente).ToList
                If leCtaCte.Count > 0 Then IdTrabajador = leCtaCte(0).IdTrabajador
                liq = IIf(griSaldoCuenta.ActiveRow.Cells("Liquidado").Value = 1, 1, 0)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                InicializaMovCuentaCte(xind)
                oeMovCuentaCte = New e_MovCuentaCte
                oeMovCuentaCte.IdCuentaCorriente = IdCuentaCorriente
                oeMovCuentaCte.Liquidado = liq
                If liq = 1 Then oeMovCuentaCte.FechaLiquida = griSaldoCuenta.ActiveRow.Cells("FechaLiquida").Value.ToString
                leMovCuentaCte = olMovCuentaCte.Listar(oeMovCuentaCte)
                CargarMovCuentaCte(leMovCuentaCte)
                CalculaDatosContable(fecTransferencia.Value.Date, 0)
                If liq = 1 Then Habilita(False)
            Else
                Throw New Exception("No hay Registros para Editar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub HabilitaxTipoDocumento(ByVal ind As Boolean)
        txtSerie.ReadOnly = ind
        txtNumero.ReadOnly = ind
        cboProveedor.ReadOnly = ind
        cboMonedaDoc.ReadOnly = ind
        decIgv.ReadOnly = ind
        'decNoGravada.ReadOnly = ind
        decPercepcion.ReadOnly = ind
    End Sub

    Private Sub Cargar_DocumentosCompra(ByVal leDocCompra As List(Of e_MovimientoDocumento))
        Try
            With griDocCompra
                If lb_Load Then .ResetDisplayLayout()
                .DataSource = leDocCompra
                .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                If lb_Load Then
                    ConfiguraGrilla(griDocCompra, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna2(griDocCompra, False, "NombreDocumento", "NombreProveedor", "FechaEmision", "Moneda", "TipoCambio", "IGV", _
                                    "Subtotal", "Total", "Saldo", "TipoPago")
                    .DisplayLayout.Bands(0).Columns("NombreDocumento").Header.Caption = "Serie - Numero"
                    .DisplayLayout.Bands(0).Columns("NombreProveedor").Header.Caption = "Proveedor"
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fec. Emision"
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Header.Caption = "T.C."
                    .DisplayLayout.Bands(0).Columns("TipoPago").Header.Caption = "Glosa"
                    .DisplayLayout.Bands(0).Columns("NombreDocumento").Width = 95
                    .DisplayLayout.Bands(0).Columns("NombreProveedor").Width = 250
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 70
                    .DisplayLayout.Bands(0).Columns("Moneda").Width = 60
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Width = 30
                    .DisplayLayout.Bands(0).Columns("TipoPago").Width = 250
                    FormatoColumna(griDocCompra, "#,###,##0.00", ColumnStyle.Double, HAlign.Right, "TipoCambio", "IGV", "Subtotal", "Total", "Saldo")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarConfPerfil()
        Try
            Dim _leAux As New List(Of e_UsuarioPerfil)
            ' Por Perfil Caja
            _leAux = gUsuarioSGI.leUsuarioPerfil.Where(Function(it) it.oePerfil.Nombre = gNombrePerfilCaja Or it.oePerfil.Nombre = "CAJA - FONDO FIJO").ToList
            If _leAux.Count > 0 Then cboTipoCuentaBusq.SelectedIndex = 1 : cboTipoCuentaBusq.ReadOnly = True : cboTipoCuenta.SelectedIndex = 1 : cboTipoCuenta.ReadOnly = True
            ' Por Perfil Contabilidad
            _leAux = gUsuarioSGI.leUsuarioPerfil.Where(Function(it) it.oePerfil.Nombre = "ASISTENTE DE CONTABILIDAD" Or it.oePerfil.Nombre = gNombrePerfilAsistenteTesoreria).ToList
            If _leAux.Count > 0 Then cboTipoCuentaBusq.SelectedIndex = 0 : cboTipoCuentaBusq.ReadOnly = True : cboTipoCuenta.SelectedIndex = 0 : cboTipoCuenta.ReadOnly = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub HabilitarDoc(ByVal _band As Boolean)
        If ln_TipoCta = 4 Then
            LlenarCombo(cboTipoDoc, "Nombre", leTipoDocBono, -1)
            cboTipoDoc.ReadOnly = False
        Else
            LlenarCombo(cboTipoDoc, "Nombre", leTipoDoc, -1)
            cboTipoDoc.ReadOnly = True
        End If
        txtSerie.ReadOnly = _band
        txtNumero.ReadOnly = _band
        cboProveedor.ReadOnly = _band
        cboFlujoCaja.ReadOnly = _band
        'cboMonedaDoc.ReadOnly = _band
        decTipoCambioDoc.ReadOnly = _band
        decSubtotal.ReadOnly = _band
        decIgv.ReadOnly = _band
        'decNoGravada.ReadOnly = _band
        decPercepcion.ReadOnly = _band
        decDetraccion.ReadOnly = _band
        decTotal.ReadOnly = _band
        decNeto.ReadOnly = _band
        btnBuscaDoc.Enabled = _band
    End Sub

    Private Sub CalcularNeto()
        decNeto.Value = decTotal.Value + decPercepcion.Value - decDetraccion.Value
    End Sub

    Private Sub CargarAsiMod()
        Try
            ' Cargar Asiento Modelo
            oeAsientoModel = New e_AsientoModelo : leAsientoModel = New List(Of e_AsientoModelo)
            oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
            leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
            Dim _leComDiv = leAsientoModel.Where(Function(it) it.Abreviatura = "CMP_DIV").ToList
            If _leComDiv.Count > 0 Then oeAsientoModel = _leComDiv(0)
            oeAsiModPago = New e_AsientoModelo
            Dim _lePago = leAsientoModel.Where(Function(it) it.Abreviatura = "PAGO_BONO").ToList
            If _lePago.Count > 0 Then oeAsiModPago = _lePago(0)
            ' Cargar Cuentas por Ejercicio
            CargarCta(ln_Ejercicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCta(ByVal Año As Integer)
        Try
            oeCtaCtble = New e_CuentaContable : leCtaCtble = New List(Of e_CuentaContable)
            oeCtaCtble.TipoOperacion = "N" : oeCtaCtble.Ejercicio = Año : oeCtaCtble.Activo = True
            leCtaCtble = olCtaCtble.Listar(oeCtaCtble)
            If leCtaCtble.Count > 0 Then
                Dim _leAux = leCtaCtble.Where(Function(it) it.Cuenta.Trim.Length > 4).ToList
                If _leAux.Count > 0 Then
                    Dim _leAuxME = _leAux.Where(Function(it) it.Cuenta.Substring(0, 4) = "4212" And it.MonedaExtranjera = 1).ToList
                    If _leAuxME.Count > 0 Then IdCtaDolares = _leAuxME(0).Id
                    Dim _leAuxMN = _leAux.Where(Function(it) it.Cuenta.Substring(0, 4) = "4212" And it.MonedaExtranjera = 0).ToList
                    If _leAuxMN.Count > 0 Then IdCtaSoles = _leAuxMN(0).Id
                End If
                Dim _leAuxTrans = leCtaCtble.Where(Function(it) it.Cuenta.Trim = CtaTrans).ToList
                If _leAuxTrans.Count > 0 Then IdCtaTrans = _leAuxTrans(0).Id
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDocumentos(ByVal leDoc As List(Of e_MovimientoDocumento))
        Try
            With griDocumentos
                If lb_Load Then .ResetDisplayLayout()
                .DataSource = leDoc
                .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                .Text = String.Empty
                If lb_Load Then
                    ConfiguraGrilla(griDocumentos, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna2(griDocumentos, False, "FechaEmision", "NombreProveedor", "NombreDocumento", "Moneda", "TipoCambio", _
                                    "SubTotal", "IGV", "Total", "Saldo")
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 70
                    .DisplayLayout.Bands(0).Columns("NombreProveedor").Width = 300
                    .DisplayLayout.Bands(0).Columns("NombreDocumento").Width = 130
                    .DisplayLayout.Bands(0).Columns("Moneda").Width = 50
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Width = 50
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fec. Emision"
                    .DisplayLayout.Bands(0).Columns("NombreProveedor").Header.Caption = "Proveedor"
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Header.Caption = "T.C."
                    .DisplayLayout.Bands(0).Columns("NombreDocumento").Header.Caption = "Serie - Numero"
                    FormatoColumna(griDocumentos, "#,##0.00", ColumnStyle.Double, HAlign.Right, "TipoCambio", "SubTotal", "IGV", "Total", "Saldo")
                    CalcularTotales(griDocumentos, "Saldo")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDocPagos(ByVal leDocPag As List(Of e_MovimientoDocumento))
        Try
            With griDocPagar
                If lb_Load Then .ResetDisplayLayout()
                .DataSource = leDocPag
                .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                .Text = String.Empty
                If lb_Load Then
                    ConfiguraGrilla(griDocPagar, "Tahoma", False, UIElementBorderStyle.Default, "MontoOperar")
                    OcultarColumna2(griDocPagar, False, "FechaEmision", "NombreProveedor", "NombreDocumento", "Moneda", "TipoCambio", _
                                    "SubTotal", "IGV", "Total", "Saldo", "MontoOperar")
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 70
                    .DisplayLayout.Bands(0).Columns("NombreProveedor").Width = 300
                    .DisplayLayout.Bands(0).Columns("NombreDocumento").Width = 130
                    .DisplayLayout.Bands(0).Columns("Moneda").Width = 50
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Width = 50
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fec. Emision"
                    .DisplayLayout.Bands(0).Columns("NombreProveedor").Header.Caption = "Proveedor"
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Header.Caption = "T.C."
                    .DisplayLayout.Bands(0).Columns("NombreDocumento").Header.Caption = "Serie - Numero"
                    FormatoColumna(griDocPagar, "#,##0.00", ColumnStyle.Double, HAlign.Right, "TipoCambio", "SubTotal", "IGV", "Total", "Saldo", "MontoOperar")
                    ColorFondoColumna(griDocPagar, Color.LightYellow, "MontoOperar")
                    CalcularTotales(griDocPagar, "MontoOperar")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_HabilitarIgv()
        If oeTipoDocAux.Codigo = "02" Or oeTipoDocAux.Codigo = "16" Then
            decIgv.Value = 0
            'decNoGravada.Value = decSubtotal.Value
            decSubtotal.Value = 0
            decSubtotal.ReadOnly = True
            decIgv.ReadOnly = True
        Else
            decIgv.Value = Math.Round(decSubtotal.Value * oeIgv.Porcentaje, 2)
            'decNoGravada.Value = 0
            decSubtotal.ReadOnly = False
            decIgv.ReadOnly = False
        End If
        'decNoGravada.ReadOnly = True
        decTotal.Value = decSubtotal.Value + decIgv.Value + decNoGravada.Value
    End Sub

    Private Function ValidarAgregarDetalle(ByVal oeMovDoc As e_MovimientoDocumento) As Boolean
        Try
            If oeMovDoc.Saldo < 0 Then Throw New Exception("No se puede operar: es negativo")
            ValidarGrilla(griDocumentos, "Documentos a Pagar")
            If Not griDocumentos.ActiveRow Is Nothing AndAlso griDocumentos.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            l_FuncionesGenerales.ValidarNumero(numTipoCambioPago.Value, "Tipo de Cambio")
            If oeMovDoc.IdCuentaContable.Trim = "" Then
                Throw New Exception("!El Documento no tiene cuenta contable!" & Environment.NewLine & _
                                     "Sirvase a informar al Area de Contabilidad o Sistemas")
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

#End Region

#Region "Menu Contextual"

    Private Sub mnuSaldoCuentaCte_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuSaldoCuentaCte.Opening
        mnuSaldoCuentaCte.Items("tsmiIngreso").Visible = IIf(griSaldoCuenta.Selected.Rows.Count > 0, True, False)
        mnuSaldoCuentaCte.Items("tsmiEgreso").Visible = IIf(griSaldoCuenta.Selected.Rows.Count > 0, True, False)
        mnuSaldoCuentaCte.Items("tsmiActualizarMonto").Visible = IIf(griSaldoCuenta.Selected.Rows.Count > 0, True, False)
        ' If mnuSaldoCuentaCte.Items("tsmiActualizarMonto").Visible Then
        mnuSaldoCuentaCte.Items("tsmiActualizarMonto").Enabled = IIf(cboTipoCuentaBusq.SelectedIndex = 0, False, True)
        ' End If
    End Sub

    Private Sub tsmiIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiIngreso.Click
        Try
            If cboTipoCuentaBusq.SelectedIndex > -1 Then
                If cboTipoCuentaBusq.SelectedIndex = 0 Then
                    ln_TipoCta = griSaldoCuenta.ActiveRow.Cells("TipoCuenta").Value
                    Movimiento(0) : fecTransferencia.Focus()
                Else
                    If griSaldoCuenta.ActiveRow.Cells("Monto").Value = 0 Then Throw New Exception("¡Ingrese Monto a Pagar!")
                    If griSaldoCuenta.ActiveRow.Cells("Abono").Value = 0 Then Throw New Exception("¡Ingrese Documentos!")
                    MostrarTabs(4, ficDocAosciados, 4)
                    decMontoPagar.Value = 0
                    fecPago.Value = Date.Now.Date
                    numTipoCambioPago.Value = TipoCambio(fecPago.Value, True)(0)
                    cboTrabajadorPago.Value = griSaldoCuenta.ActiveRow.Cells("IdCuentaCorriente").Value
                    oeSaldoCuentaCte = New e_SaldoCtaCorriente
                    oeSaldoCuentaCte.TipoOperacion = String.Empty
                    oeSaldoCuentaCte.Id = griSaldoCuenta.ActiveRow.Cells("Id").Value
                    oeSaldoCuentaCte = olSaldoCuentaCte.Obtener(oeSaldoCuentaCte)
                    decMontoPagar.Value = oeSaldoCuentaCte.Monto
                    leDocumentos = New List(Of e_MovimientoDocumento)
                    oeMovCuentaCte = New e_MovCuentaCte
                    oeMovCuentaCte.TipoOperacion = "D"
                    oeMovCuentaCte.IdCuentaCorriente = cboTrabajadorPago.Value
                    oeMovCuentaCte.FechaLiquida = fecPago.Value
                    leDocumentos = olMovCuentaCte.ListarDocumentos(oeMovCuentaCte)
                    CargarDocumentos(leDocumentos)
                    leDocPago = New List(Of e_MovimientoDocumento)
                    CargarDocPagos(leDocPago)
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEgreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEgreso.Click
        Try
            ln_TipoCta = griSaldoCuenta.ActiveRow.Cells("TipoCuenta").Value
            Movimiento(1) : cboTipoDoc.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiActualizarMonto_Click(sender As Object, e As EventArgs) Handles tsmiActualizarMonto.Click
        Try
            If cboTipoCuentaBusq.SelectedIndex > -1 Then
                Dim _Monto As String
                _Monto = InputBox("Ingrese Monto de Pago para " & griSaldoCuenta.ActiveRow.Cells("Trabajador").Value & ":", _
                                  "Mensaje de Sistema", griSaldoCuenta.ActiveRow.Cells("Monto").Value)
                If Not IsNumeric(_Monto) Then Throw New Exception("Solo se Permite Ingresar Números")
                If _Monto < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                oeSaldoCuentaCte = New e_SaldoCtaCorriente
                oeSaldoCuentaCte.TipoOperacion = "N"
                oeSaldoCuentaCte.Id = griSaldoCuenta.ActiveRow.Cells("Id").Value
                oeSaldoCuentaCte.Monto = _Monto
                If olSaldoCuentaCte.Guardar(oeSaldoCuentaCte) Then
                    mensajeEmergente.Confirmacion("Se Actualizo el Registro", True)
                    Consultar(True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class