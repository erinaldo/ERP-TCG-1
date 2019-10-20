'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_AnticipoClienteProveedor
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de Variables"

    Private olMovimientoDocumento As New l_MovimientoDocumento
    Private oeMovimientoDocumento As New e_MovimientoDocumento
    Private leMovimientoDocumento As New List(Of e_MovimientoDocumento)
    Private oeMedioPago As New e_MedioPago

    Dim oeMovCajaBanco As New e_MovimientoCajaBanco

    Private leCuentaBancaria As New List(Of e_CuentaBancaria)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private _ComboPeriodo As Boolean = False

    Private Shared instancia As frm_AnticipoClienteProveedor = Nothing
    Private Shared Operacion As String
    Private var As String = ""
    Private ejercicio As Integer = 0
    Private EjercicioBanderaCtaBancari As Integer

    Dim oeCuota As New e_CuotaDocumentoVehiculo
    Dim olCuota As New l_CuotaDocumentoVehiculo
    Dim leCuota As New List(Of e_CuotaDocumentoVehiculo)

    Dim oeCuotaMovimiento As New e_CuotaDocVeh_Movimiento
    Dim leCuotaMovimiento As New List(Of e_CuotaDocVeh_Movimiento)
    Dim IdTipoAsiernto As String = ""

    Private olTrabajadorSeguridad As New l_TrabajadorSeguridad
    Dim ListaProveedor As New List(Of e_Combo)

    Dim oeDocumentoVehicular As New e_DocumentoVehicular
    Dim olDocumentoVehicular As New l_DocumentoVehicular

    Private oeAsientoModelo As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)

    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)
    Private dtReferencia As New DataTable

    Private IdActividadNegocio As String = ""
    Dim oeContratoTercero As New e_ViajesTerceros
    Dim olContratoTercero As New l_ViajesTerceros
    Dim IdContratoTercero As String = ""

    Private leCliente As List(Of e_Cliente), leProveedor As List(Of e_Proveedor)
    Private oeCtaContable As e_CuentaContable, olCtaContable As l_CuentaContable, leCtaContable As List(Of e_CuentaContable)

    Private oeAsiento As e_Asiento, olAsiento As l_Asiento
    Private leMovCajaBanco As List(Of e_MovimientoCajaBanco), olMovCajaBanco As l_MovimientoCajaBanco
    Private lb_Nuevo As Boolean = False

#End Region

#Region "Inicializazión de formulario"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        For Each Form As frm_MenuPadre In frm_Menu.MdiChildren
            If Form.Tag = TipoAnticipo Then
                instancia = Form
                instancia.Activate()
                Return instancia
            End If
        Next
        If instancia Is Nothing Then
            var = TipoAnticipo
            Operacion = "Inicializa"
            instancia = New frm_AnticipoClienteProveedor()
            instancia.Tag = TipoAnticipo
        Else
            If var <> TipoAnticipo Then
                instancia = New frm_AnticipoClienteProveedor()
                instancia.Tag = TipoAnticipo
            End If
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If gridAnticipos.Rows.Count > 0 Then
                If TipoAnticipo = "Cliente" Then
                    ControlBoton(1, 0, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                End If
            Else
                If TipoAnticipo = "Cliente" Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Inicializar()
        Operacion = "Nuevo"
        lb_Nuevo = True
        GroupObligacion.Expanded = True
        mt_Habilitar(False)
        MyBase.Nuevo() 'activa desactiva botonera
    End Sub

    Public Overrides Sub Guardar()
        Try
            If lb_Nuevo Then
                If GuardarAnticipo() Then
                    ' ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1) 'activa desactiva botonera
                Else
                    MostrarTabs(1, tcAnticipos)
                End If
            Else
                mt_GuadarMovCajaBanco()
            End If
            Operacion = "Inicializa"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If Not gridAnticipos.ActiveRow Is Nothing AndAlso gridAnticipos.ActiveRow.Cells("Id").Value.ToString <> "" Then
                Inicializar()
                Operacion = "Editar"
                lb_Nuevo = False
                GroupObligacion.Expanded = False
                mt_Habilitar(True)
                ' Obtener Datos del Anticipo
                oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento.Id = gridAnticipos.ActiveRow.Cells("Id").Value
                oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                ' Obtener Datos de Asiento Contable
                oeAsiento = New e_Asiento : olAsiento = New l_Asiento
                oeAsiento.TipoOperacion = "Z" : oeAsiento.Glosa = oeMovimientoDocumento.Id
                oeAsiento = olAsiento.Obtener(oeAsiento)
                leMovCajaBanco = New List(Of e_MovimientoCajaBanco)
                ' Obtener Datos de Movimiento Caja Banco
                If Not IsNothing(oeAsiento) AndAlso oeAsiento.Id.Trim.Length > 0 Then
                    oeMovCajaBanco = New e_MovimientoCajaBanco : olMovCajaBanco = New l_MovimientoCajaBanco
                    oeMovCajaBanco.TipoOperacion = "D" : oeMovCajaBanco.IdAsientoMovimiento = oeAsiento.Id
                    leMovCajaBanco = olMovCajaBanco.Listar(oeMovCajaBanco)
                End If
                ' Cargar Datos
                FecAnticipo.Value = oeMovimientoDocumento.FechaEmision
                DecTC.Value = oeMovimientoDocumento.TipoCambio
                cboClienteProveedor.Value = oeMovimientoDocumento.IdClienteProveedor
                cboMoneda.Value = oeMovimientoDocumento.IdMoneda
                DecImporte.Value = oeMovimientoDocumento.Total
                If leMovCajaBanco.Count > 0 Then
                    cboMedioPago.Value = leMovCajaBanco(0).IdMedioPago
                    Dim _leAsiMov = oeAsiento.AsientoMovimiento.Where(Function(it) it.Id = leMovCajaBanco(0).IdAsientoMovimiento).ToList
                    If _leAsiMov.Count > 0 Then
                        cboCuentaCtble.Value = _leAsiMov(0).IdCuentaContable
                        cboCuentaBancaria.Value = leMovCajaBanco(0).IdCuentaBancaria
                        txtCheque.Text = leMovCajaBanco(0).NroBoucher
                        cboFlujoGasto.Value = leMovCajaBanco(0).IdFlujoCaja
                        cboTipoGasto.Value = leMovCajaBanco(0).IdTipoGasto
                        TxtGlosa.Value = leMovCajaBanco(0).Glosa
                    End If
                End If
                If TipoAnticipo = "Cliente" Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
                Else
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, tcAnticipos)
                Operacion = "Inicializa"
                Consultar(True)
                lb_Nuevo = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With gridAnticipos
                ValidarGrilla(gridAnticipos, "Comprobante")
                If Not .ActiveRow Is Nothing AndAlso .ActiveRow.Cells("Id").Value.ToString <> "" Then
                    oeMovimientoDocumento.Id = .ActiveRow.Cells("Id").Value
                    oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                    If oeMovimientoDocumento.Activo Then
                        oeAsiento = New e_Asiento : olAsiento = New l_Asiento
                        oeAsiento.TipoOperacion = "Z" : oeAsiento.Glosa = oeMovimientoDocumento.Id
                        oeAsiento = olAsiento.Obtener2(oeAsiento)
                        If Not IsNothing(oeAsiento) AndAlso oeAsiento.Id.Trim.Length > 0 Then
                            oeMovCajaBanco = New e_MovimientoCajaBanco : olMovCajaBanco = New l_MovimientoCajaBanco : leMovCajaBanco = New List(Of e_MovimientoCajaBanco)
                            oeMovCajaBanco.TipoOperacion = "D" : oeMovCajaBanco.IdAsientoMovimiento = oeAsiento.Id
                            leMovCajaBanco = olMovCajaBanco.Listar(oeMovCajaBanco)
                            If leMovCajaBanco.Count > 0 Then
                                Dim _leMCB = leMovCajaBanco.Where(Function(it) it.IdPeriodoConcilia.Trim <> "").ToList
                                If _leMCB.Count > 0 Then Throw New Exception("No se puede extornar por que el Asiento esta conciliado")
                            End If
                            If MessageBox.Show("Esta seguro de eliminar el Anticipo?", "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeMovimientoDocumento.TipoOperacion = "ANT"
                                olMovimientoDocumento.EliminarAnticipo(oeMovimientoDocumento)
                                Consultar(True)
                            End If
                        Else
                            Throw New Exception("No se encontro Asiento Contable")
                        End If
                        
                    Else
                        Throw New Exception("El registro ya esta eliminado")
                    End If
                Else
                    Throw New Exception("Seleccione un registro")
                End If

            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If gridAnticipos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(gridAnticipos)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Function GuardarAnticipo() As Boolean
        Try
            If GroupObligacion.Visible = True Then
                TipoAnticipo = "Proveedor"
            Else
                TipoAnticipo = "Cliente"
            End If
            If Validar() Then
                Dim olPeriodo As New l_Periodo
                Dim oePeriodo As New e_Periodo
                oePeriodo.Ejercicio = Date.Parse(FecAnticipo.Value).Year
                oePeriodo.Mes = Date.Parse(FecAnticipo.Value).Month
                oePeriodo = olPeriodo.Obtener(oePeriodo)
                oeMovimientoDocumento = New e_MovimientoDocumento
                Dim o_NroCheque() As String = txtCheque.Text.Split("-")
                With oeMovimientoDocumento
                    .Activo = "1"
                    .TipoOperacion = "I"
                    .IdTipoDocumento = "1CH000000070"
                    If o_NroCheque.Length > 1 Then
                        .Serie = o_NroCheque(0).ToString.Trim
                        .Numero = o_NroCheque(1).ToString.Trim
                    Else
                        .Serie = "0001"
                        .Numero = o_NroCheque(0).ToString.Trim
                    End If
                    .FechaEmision = CDate(FecAnticipo.Value)
                    .FechaVencimiento = CDate(FecAnticipo.Value)
                    .IGV = 0
                    .SubTotal = DecImporte.Value
                    .Total = DecImporte.Value
                    .Saldo = DecImporte.Value
                    .IdClienteProveedor = cboClienteProveedor.Value
                    .Activo = True
                    .IndCompraVenta = IIf(TipoAnticipo = "Proveedor", 4, 5)
                    .IdPeriodo = oePeriodo.Id
                    .IdMoneda = cboMoneda.Value
                    .TipoCambio = DecTC.Value
                    .IdUsuarioCrea = gUsuarioSGI.Id
                    .IdCuentaContable = ""
                    .EstadoDocumento = "EMITIDA"
                    ._Operador = -1
                    .Mac_PC_Local = MacPCLocal()
                    .Glosa = "ANTICIPO DE: " + cboClienteProveedor.Text + " " + TxtGlosa.Text
                    If VerContratoTercero.Checked Then
                        .IdLiquidacion = IdContratoTercero
                    End If
                    leCuotaMovimiento.Clear()
                    If TipoAnticipo = "Proveedor" And verCuponPoliza.Checked = True Then
                        Dim oe As New e_CuotaDocumentoVehiculo
                        oeCuotaMovimiento = New e_CuotaDocVeh_Movimiento
                        oeCuotaMovimiento.TipoOperacion = "I"
                        oeCuotaMovimiento.Tipo = "A"
                        oeCuotaMovimiento.Glosa = "PAGO DE CUOTA: " + CboFilPoliza.Text + ". POR ANTICIPO EL: " + CDate(FecAnticipo.Value).Date
                        oeCuotaMovimiento.Fecha = FecAnticipo.Value
                        oeCuotaMovimiento.IdMovimientoDocumento = ""
                        oeCuotaMovimiento.IdMovimientoCajaBanco = ""
                        oeCuotaMovimiento.IdMoneda = cboMoneda.Value
                        oeCuotaMovimiento.TipoCambio = DecTC.Value
                        'If oeCuotaMovimiento.IdMoneda = "1CH01" Then
                        '    oeCuotaMovimiento.MontoMN = nd_MontoOperaCupon.Value
                        '    oeCuotaMovimiento.MontoME = nd_MontoOperaCupon.Value / DecTC.Value
                        'ElseIf oeCuotaMovimiento.IdMoneda = "1CH02" Then
                        '    oeCuotaMovimiento.MontoMN = nd_MontoOperaCupon.Value * DecTC.Value
                        '    oeCuotaMovimiento.MontoME = nd_MontoOperaCupon.Value
                        'End If
                        oeCuotaMovimiento.MontoMN = IIf(oeCuotaMovimiento.IdMoneda = "1CH01", DecImporte.Value, DecImporte.Value * DecTC.Value)
                        oeCuotaMovimiento.MontoME = IIf(oeCuotaMovimiento.IdMoneda = "1CH01", DecImporte.Value / DecTC.Value, DecImporte.Value)
                        oeCuotaMovimiento.Activo = 1
                        oeCuotaMovimiento.UsuarioCreacion = gUsuarioSGI.Id
                        oeCuotaMovimiento.FechaCeacion = Date.Now()
                        oeCuotaMovimiento.leCuota.Clear()
                        oe = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0)
                        oe.MontoOpera = DecImporte.Value
                        oeCuotaMovimiento.leCuota.Add(oe)
                        leCuotaMovimiento.Add(oeCuotaMovimiento)
                        .leCuotaDocVehMovimiento = leCuotaMovimiento
                    End If
                End With
                oeMovCajaBanco = New e_MovimientoCajaBanco
                With oeMovCajaBanco
                    .TipoOperacion = "I"
                    .IdFlujoCaja = cboFlujoGasto.Value
                    .IdTipoGasto = IIf(TipoAnticipo = "Cliente", "", IIf(TipoAnticipo = "Proveedor", cboTipoGasto.Value, ""))
                    .NroBoucher = txtCheque.Text
                    .IdCuentaBancaria = cboCuentaBancaria.Value
                    .Fecha = CDate(FecAnticipo.Value)
                    .IdMedioPago = cboMedioPago.Value
                    .TipoCambio = DecTC.Value
                    If oeMovimientoDocumento.IdMoneda = "1CH01" Then 'SOLES
                        .TotalMN = oeMovimientoDocumento.Total
                        .TotalME = Math.Round(oeMovimientoDocumento.Total / oeMovimientoDocumento.TipoCambio, 3)
                    ElseIf oeMovimientoDocumento.IdMoneda = "1CH02" Then
                        .TotalMN = Math.Round(oeMovimientoDocumento.Total * oeMovimientoDocumento.TipoCambio, 3)
                        .TotalME = oeMovimientoDocumento.Total
                    End If
                    ._Operador = IIf(TipoAnticipo = "Proveedor", -1, 1)
                    ._IdTipoAsiento = oeMedioPago.IdTipoAsiento
                    ._IdCuentaContable = cboCuentaCtble.Value
                End With

                oeMovimientoDocumento.oeAsientoModelo = ObtenerAsientoModelo(cboMoneda.Value)
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeMovCajaBanco.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeMovimientoDocumento.oeAsientoModelo.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olMovimientoDocumento.GuardarAnticipo(oeMovimientoDocumento, oeMovCajaBanco, TipoAnticipo) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                    MostrarTabs(0, tcAnticipos, 2)
                    Dim I As Integer = IIf(TipoAnticipo = "Cliente", 1, 0)
                    Dim frm2 As New frm_ImprimeCobroPagoAnticipo(oeMovCajaBanco.Id, I, "Documento")
                    frm2.ShowDialog()
                    frm2 = Nothing
                    Consultar(True)
                    Return True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            ValidarCombo(cboMedioPago, "Medio Pago")
            ValidarCombo(cboCuentaCtble, "Cuenta Contable")
            If cboCuentaBancaria.Enabled = True Then
                ValidarCombo(cboCuentaBancaria, "Cuenta Bancaria")
            End If
            ValidarCombo(cboFlujoGasto, "Flujo de Caja")
            ValidarCombo(cboMoneda, "Moneda")
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            l_FuncionesGenerales.ValidarNumero(DecImporte.Value, "Importe")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtCheque.Text, "Ingrese el Cheque/Voucher")
            If TipoAnticipo = "Proveedor" Then
                ValidarCombo(cboTipoGasto, "Tipo de Gasto")
            End If
            If TipoAnticipo = "Proveedor" And verCuponPoliza.Checked = True Then
                If CboMonedaCupon.SelectedIndex = -1 Then Throw New Exception("Cupon no tiene moneda especifica.")
                If cboMoneda.SelectedIndex = -1 Then Throw New Exception("Anticipo no tiene moneda.")
                If nd_MontoOperaCupon.Value = 0.0 Then Throw New Exception("Monto a pagar de cupón no puede ser 0.0")

                If cboMoneda.Value = "1CH01" Then
                    If CboMonedaCupon.Value = "1CH01" Then
                        If Math.Round(DecImporte.Value, 2) <> Math.Round(nd_MontoOperaCupon.Value, 2) Then Throw New Exception("Monto Soles deben ser iguales")
                    ElseIf CboMonedaCupon.Value = "1CH02" Then
                        Dim monto As Double = 0.0
                        monto = Math.Round(DecImporte.Value / DecTC.Value, 2)
                        If monto <> Math.Round(nd_MontoOperaCupon.Value, 2) Then Throw New Exception("El equivalente en dólares dle anticipo es diferente al monto en dólares del cupón.")
                    End If
                ElseIf cboMoneda.Value = "1CH02" Then
                    If CboMonedaCupon.Value = "1CH01" Then
                        Dim monto As Double = 0.0
                        monto = Math.Round(DecImporte.Value * DecTC.Value, 2)
                        If monto <> Math.Round(nd_MontoOperaCupon.Value, 2) Then Throw New Exception("El equivalente en soles dle anticipo es diferente al monto en soles del cupón.")
                    ElseIf CboMonedaCupon.Value = "1CH02" Then
                        If Math.Round(DecImporte.Value, 2) <> Math.Round(nd_MontoOperaCupon.Value, 2) Then Throw New Exception("Monto en dólares deben ser iguales")
                    End If
                End If
            End If
            If TipoAnticipo = "Proveedor" Then
                If ProveedorPublic.Where(Function(i) i.Id = cboClienteProveedor.Value).Count() = 0 Then
                    Throw New Exception("Seleccione un Proveedor válido.")
                End If
            ElseIf TipoAnticipo = "Cliente" Then
                If ClientesPublic.Where(Function(i) i.Id = cboClienteProveedor.Value).Count() = 0 Then
                    Throw New Exception("Seleccione un Cliente válido.")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Inicializar()
        Try
            cboMedioPago.SelectedIndex = -1
            cboCuentaBancaria.SelectedIndex = -1
            cboCuentaBancaria.Enabled = False
            cboCuentaCtble.SelectedIndex = -1
            cboMoneda.SelectedIndex = -1
            cboFlujoGasto.SelectedIndex = -1
            DecImporte.Value = 0
            txtCheque.Value = ""
            TxtGlosa.Value = ""
            FecAnticipo.Value = Date.Now
            DecTC.Value = TipoCambio(FecAnticipo.Value, True)(0)
            MostrarTabs(1, tcAnticipos, 1)
            'cboMes.Value = Month(FecAnticipo.Value)
            TxtNumeroPoliza.Value = ""
            ndMontoCupon.Value = 0.0
            nd_SaldoCupon.Value = 0.0
            nd_MontoOperaCupon.Value = 0.0
            dtpFechaCupon.Value = Date.Now()
            cboClienteProveedor.Value = Nothing
            cboTipoGasto.Value = -1
            verCuponPoliza.Checked = False
            verSoats.Checked = False
            VerContratoTercero.Checked = False
            TabFinanciero.Tabs(0).Enabled = False
            TabFinanciero.Tabs(1).Enabled = False
            TabFinanciero.Tabs(2).Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ValidarCombo(cboMes, "Mes")
            oeMovimientoDocumento = New e_MovimientoDocumento
            With oeMovimientoDocumento
                .Activo = Activo
                .IdPeriodo = cboMes.Value
                .Ejercicio = dtpFechaEjercicio.Value.Year
                .NombreDocumento = "ANTICIPO"
                .TipoOperacion = "ANT"
                If TipoAnticipo = "Cliente" Then
                    .IndCompraVenta = 5 'clientes
                ElseIf TipoAnticipo = "Proveedor" Then
                    .IndCompraVenta = 4 'Proveedor
                End If
                .IdMoneda = cboMonedaLista.Value
                .IdClienteProveedor = cmbClienteProveedor.Value
            End With
            leMovimientoDocumento.Clear()
            leMovimientoDocumento.AddRange(olMovimientoDocumento.Listar(oeMovimientoDocumento))
            'Ubica el cursor el el primer registro de la grilla
            With gridAnticipos
                .DataBind()
                'If .Rows.Count > 0 Then
                '    .Focus()
                '    .Rows.Item(0).Selected = True
                'End If
            End With
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ComboPeriodo()
        Try
            'If _ComboPeriodo = True Then
            '    Dim lePeriodo As New List(Of e_Periodo)
            '    lePeriodo.AddRange(ObtenerPeriodoActivo(Año1.Año))
            '    LlenaComboMes(cboMes, lePeriodo)
            'End If

            If _ComboPeriodo = True Then
                oePeriodo = New e_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                oePeriodo.Id = ""
                oePeriodo.Mes = 0
                oePeriodo.NomMes = "(0) TODOS"
                lePeriodo.Add(oePeriodo)

                oePeriodo = New e_Periodo
                oePeriodo.Ejercicio = dtpFechaEjercicio.Value.Year
                oePeriodo.Activo = True
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
                With cboMes
                    .DisplayMember = "NomMes"
                    .ValueMember = "Id"
                    .DataSource = lePeriodo
                    If .Items.Count > 0 Then
                        .SelectedIndex = 0
                    End If
                End With
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaMaestros()
        EjercicioBanderaCtaBancari = Year(FecAnticipo.Value)
        FlujoCaja()
        TipoGasto()
        CuentaBancaria()
        MedioPago()
        CuentaContable()
        ComboMoneda()
        ComboPeriodo()
        mt_CargarCtaContable(ObtenerFechaServidor().Year)
        If TipoAnticipo = "Cliente" Then
            Cliente()
        ElseIf TipoAnticipo = "Proveedor" Then
            Proveedor()
        End If
    End Sub

    Private Sub ComboMoneda()
        Try
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla   
            With gridAnticipos.DisplayLayout
                If .Bands(0).Columns.Exists("IdMoneda") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdMoneda")
                End If
            End With
            With gridAnticipos.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Codigo", gridAnticipos, True)
            '------------------------------------------
            With cboMoneda
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leMoneda
            End With
            With CboMonedaCupon
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leMoneda
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FlujoCaja()
        Try
            Dim oeFlujo As New e_FlujoCaja
            Dim leFlujo As New List(Of e_FlujoCaja)
            Dim olFlujo As New l_FlujoCaja
            oeFlujo.Activo = True
            leFlujo.AddRange(olFlujo.Listar(oeFlujo))
            With cboFlujoGasto
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leFlujo
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TipoGasto()
        Try
            If cboTipoGasto.Items.Count = 0 Then
                Dim oeTipoGasto As New e_TipoGasto
                Dim olTipoGasto As New l_TipoGasto
                LlenarCombo(cboTipoGasto, "Nombre", olTipoGasto.Listar2(oeTipoGasto), -1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CuentaBancaria()
        Try
            If leCuentaBancaria.Count = 0 Then
                Dim oeCtaBancaria As New e_CuentaBancaria
                Dim olCtaBancaria As New l_CuentaBancaria
                oeCtaBancaria.IdCuentaContable = cboCuentaCtble.Value  'Relacionada con Cuenta COntale
                oeCtaBancaria.Activo = True
                oeCtaBancaria.Ejercicio = Date.Parse(FecAnticipo.Value).Year
                oeCtaBancaria.TipoOperacion = "C"
                leCuentaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
                'LlenarCombo(cboCuentaBancaria, "BancoCuenta", leCuentaBancaria, -1)
                With cboCuentaBancaria
                    .ValueMember = "Id"
                    .DisplayMember = "BancoCuenta"
                    .DataSource = leCuentaBancaria
                End With

                If leCuentaBancaria.Count = 0 Then
                    cboCuentaBancaria.Enabled = False
                Else
                    cboCuentaBancaria.Enabled = True
                End If
            Else
                Dim lista As New List(Of e_CuentaBancaria)
                lista = leCuentaBancaria.ToList
                lista = lista.Where(Function(item) item.IdCuentaContable = cboCuentaCtble.Value).ToList()
                If lista.Count = 0 Then
                    cboCuentaBancaria.SelectedIndex = -1
                    cboCuentaBancaria.Enabled = False
                Else
                    LlenarCombo(cboCuentaBancaria, "BancoCuenta", lista, -1)
                    cboCuentaBancaria.Enabled = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MedioPago()
        Try
            Dim oeMedioPago As New e_MedioPago
            Dim olMedioPago As New l_MedioPago
            Dim leMedioPago As New List(Of e_MedioPago)
            leMedioPago.AddRange(olMedioPago.Listar(oeMedioPago))
            With cboMedioPago
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leMedioPago
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CuentaContable()
        'If ejercicio <> Date.Parse(FecAnticipo.Value).Year Then
        'ejercicio = Date.Parse(FecAnticipo.Value).Year
        Dim oeCtaCble As New e_CuentaContable
        Dim olCtaCble As New l_CuentaContable
        Dim leCtaCbleOrigen As New List(Of e_CuentaContable)
        oeCtaCble.Activo = True
        oeCtaCble.Movimiento = 1
        oeCtaCble.Ejercicio = Date.Parse(FecAnticipo.Value).Year
        oeCtaCble.FlujoCaja = 1
        leCtaCbleOrigen.AddRange(olCtaCble.Listar(oeCtaCble))
        With cboCuentaCtble
            .SelectedIndex = -1
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = leCtaCbleOrigen
        End With
        'End If
    End Sub

    Private Sub Cliente()
        Dim oeCtaCte As New e_Cliente
        Dim olCtaCte As New l_Cliente
        Dim leCtaCte As New List(Of e_Cliente)
        leCliente = New List(Of e_Cliente)
        oeCtaCte.Activo = True
        leCtaCte.AddRange(olCtaCte.Listar(oeCtaCte))
        leCliente.AddRange(leCtaCte)
        '--------------------- para llenar combo en grilla   
        With gridAnticipos.DisplayLayout
            If .Bands(0).Columns.Exists("IdClienteProveedor") Then
                .ValueLists.Clear()
                .ValueLists.Add("IdClienteProveedor")
            End If
        End With
        With gridAnticipos.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
            .Clear()
            For Each oeTD As e_Cliente In leCtaCte
                .Add(oeTD.Id, oeTD.Nombre)
            Next
        End With
        CrearComboGrid3("IdClienteProveedor", "Codigo", gridAnticipos, True)
        '------------------------------------------

    End Sub

    Private Sub Proveedor()
        Dim oeCtaCte As New e_Proveedor
        Dim olCtaCte As New l_Proveedor
        Dim leCtaCte As New List(Of e_Proveedor)
        leProveedor = New List(Of e_Proveedor)
        oeCtaCte.Activo = True
        leCtaCte.AddRange(olCtaCte.Listar(oeCtaCte))
        leProveedor.AddRange(leCtaCte)
        '--------------------- para llenar combo en grilla   
        With gridAnticipos.DisplayLayout
            If .Bands(0).Columns.Exists("IdClienteProveedor") Then
                .ValueLists.Clear()
                .ValueLists.Add("IdClienteProveedor")
            End If
        End With
        With gridAnticipos.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
            .Clear()
            For Each oeTD As e_Proveedor In leCtaCte
                .Add(oeTD.Id, oeTD.Nombre)
            Next
        End With
        CrearComboGrid3("IdClienteProveedor", "Codigo", gridAnticipos, True)
        '------------------------------------------
    End Sub

    Private Sub CuentaBancariaSegunCta(ByVal Combo As Infragistics.Win.UltraWinEditors.UltraComboEditor,
   ByVal IndMonedaExtranjera As Integer, ByVal lsCta As String)
        If IndMonedaExtranjera = 0 Then
            cboMoneda.Value = "1CH01"
        End If
    End Sub

    Private Sub ExtornarAnticipo()
        Try

            oeMovimientoDocumento = New e_MovimientoDocumento
            oeMovimientoDocumento.Id = gridAnticipos.ActiveRow.Cells("Id").Value.ToString
            oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)

            Dim oeAsiento As New e_Asiento
            Dim olAsiento As New l_Asiento
            Dim oeAsientoMovimiento As New e_AsientoMovimiento
            Dim olAsientoMovimiento As New l_AsientoMovimiento
            Dim oeAsientoMovMovDoc As New e_AsientoMov_MovDoc
            Dim olAsientoMovMovDoc As New l_AsientoMov_MovDoc
            oeAsientoMovMovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
            oeAsientoMovMovDoc = olAsientoMovMovDoc.Obtener(oeAsientoMovMovDoc)

            oeAsientoMovimiento.Id = oeAsientoMovMovDoc.IdAsientoMovimiento
            oeAsientoMovimiento.TipoOperacion = ""
            oeAsientoMovimiento = olAsientoMovimiento.Obtener(oeAsientoMovimiento)

            oeAsiento.Id = oeAsientoMovimiento.IdAsiento
            oeAsiento = olAsiento.Obtener(oeAsiento)

            If oeAsiento.AsientoMovimiento.Count = 0 Then Throw New Exception("Error en Detalle Asiento Origen. Verificar")

            Dim frm As New Frm_PeriodoTipoAsiento(True, True, True, "CTB")
            frm.etiEmision.Visible = True
            frm.FecEmision.Visible = False
            frm.etiEmision.Text = "Voucher:"
            frm.txtVoucher.Visible = True
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim oeAsientoExtorno As New e_Asiento
                oeAsientoExtorno.IdPeriodo = frm.cboMes.Value
                oeAsientoExtorno.IdTipoAsiento = frm.cboTipoAsiento.Value
                oeAsientoExtorno.Fecha = frm.FecEmision.Value
                oeAsientoExtorno.IdUsuarioCrea = gUsuarioSGI.Id
                oeAsientoExtorno.FechaCreacion = ObtenerFechaServidor()
                oeMovimientoDocumento.GlosaViajeGrupo = FormatoDocumento(frm.txtVoucher.Text, 10)
                oeMovimientoDocumento.TipoCambio = TipoCambio(oeAsientoExtorno.Fecha, True)(0)
                oeMovimientoDocumento.Ejercicio = frm.Año1.Año
                l_FuncionesGenerales.ValidarPeriodo(oeAsientoExtorno.IdPeriodo, gAreasSGI.Contabilidad, Date.Parse("01/01/1901"), "")
                If olMovimientoDocumento.ExtornarAnticipo(oeAsiento, oeAsientoExtorno, oeMovimientoDocumento, CtaCtblePublic) Then
                    mensajeEmergente.Confirmacion("Anticio Extornado Correctamente", True)
                    Listar(True)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCtaContable(ByVal Ejercicio As Integer)
        Try
            oeCtaContable = New e_CuentaContable : olCtaContable = New l_CuentaContable : leCtaContable = New List(Of e_CuentaContable)
            oeCtaContable.Activo = True : oeCtaContable.Ejercicio = Ejercicio
            leCtaContable = olCtaContable.Listar(oeCtaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Habilitar(ByVal lb_Band As Boolean)
        FecAnticipo.ReadOnly = lb_Band
        DecTC.ReadOnly = lb_Band
        cboMedioPago.ReadOnly = lb_Band
        cboCuentaCtble.ReadOnly = lb_Band
        cboClienteProveedor.ReadOnly = lb_Band
        cboMoneda.ReadOnly = lb_Band
        DecImporte.ReadOnly = lb_Band
        txtCheque.ReadOnly = lb_Band
        TxtGlosa.ReadOnly = lb_Band
        GroupObligacion.Enabled = Not lb_Band
    End Sub

    Private Sub mt_GuadarMovCajaBanco()
        Try
            oeMovCajaBanco = New e_MovimientoCajaBanco
            olMovCajaBanco = New l_MovimientoCajaBanco
            If leMovCajaBanco.Count > 0 Then
                oeMovCajaBanco.TipoOperacion = "D"
                oeMovCajaBanco.Id = leMovCajaBanco(0).Id
                oeMovCajaBanco.IdFlujoCaja = cboFlujoGasto.Value
                oeMovCajaBanco.IdTipoGasto = cboTipoGasto.Value
                oeMovCajaBanco.IdCuentaBancaria = cboCuentaBancaria.Value
                oeMovCajaBanco.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olMovCajaBanco.Guardar(oeMovCajaBanco) Then
                    mensajeEmergente.Confirmacion("Se actualizo correctamente", True)
                    MostrarTabs(0, tcAnticipos)
                    Operacion = "Inicializa"
                    Consultar(True)
                    lb_Nuevo = False
                End If
            Else
                Throw New Exception("No Hay Datos para Guardar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub dtpFechaEjercicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEjercicio.ValueChanged
        Try
            ComboPeriodo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_AnticipoClienteProveedor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        getInstancia()
        If tcAnticipos.Tabs(0).Selected = True Then
            If TipoAnticipo = "Cliente" Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            End If
        ElseIf tcAnticipos.Tabs(1).Selected = True Then
            If TipoAnticipo = "Cliente" Then
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
            Else
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If
        End If
    End Sub

    Private Sub frm_AnticipoClienteProveedor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_AnticipoClienteProveedor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_AnticipoClienteProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me, cboClienteProveedor.Name, TxtGlosa.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            gridAnticipos.DataSource = leMovimientoDocumento
            _ComboPeriodo = True
            CargaMaestros()
            If TipoAnticipo = "Cliente" Then
                gridAnticipos.Text = "Anticipos Clientes"
                Me.Text = "Anticipos Clientes"
                LlenarComboMaestro(cboClienteProveedor, ClientesPublic, 0)
                cboTipoGasto.Visible = False
                Etiqueta11.Visible = False
                GroupObligacion.Visible = False
                GroupObligacion.Enabled = False
                IdActividadNegocio = "1CH000000178"
            ElseIf TipoAnticipo = "Proveedor" Then
                gridAnticipos.Text = "Anticipos Proveedores"
                Me.Text = "Anticipos Proveedores"
                LlenarComboMaestro(cboClienteProveedor, ProveedorPublic, 0)
                LimpiaGrid(griSegurosZ, ogdSeguros)
                cboTipoGasto.Visible = True
                Etiqueta11.Visible = True
                GroupObligacion.Visible = True
                GroupObligacion.Enabled = True
                CmbMes.Value = Month(Date.Now)
                IdActividadNegocio = "1CH000000179"
            End If
            LlenarComboMaestro(cboMonedaLista, MonedaPublic, -1)
            LlenarComboMaestro(cmbClienteProveedor, ClienteProveedorPublic, -1)
            ListaUsuarios(gridAnticipos, "IdUsuarioCrea")
            CalcularTotales(gridAnticipos, "Total")
            CalcularTotales(griSegurosZ, "Importe")
            AsientosContables()
            dtpFechaEjercicio.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCuentaCtble_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaCtble.ValueChanged
        Dim i As Integer = cboCuentaCtble.SelectedIndex
        If i >= 0 Then
            Dim obj As New e_CuentaContable
            obj = cboCuentaCtble.Items(i).ListObject
            CuentaBancaria()
            txtCtaOrigen.Text = obj.Cuenta
            CuentaBancariaSegunCta(cboCuentaBancaria, obj.MonedaExtranjera, obj.Id)
        End If
    End Sub

    Private Sub cboMedioPago_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedioPago.ValueChanged
        Dim i As Integer = cboMedioPago.SelectedIndex
        If i >= 0 Then
            oeMedioPago = New e_MedioPago
            oeMedioPago = cboMedioPago.Items(i).ListObject
        End If
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        Dim i As Integer = cboMoneda.SelectedIndex
        If i >= 0 Then
            Dim obj As New e_Moneda
            obj = cboMoneda.Items(i).ListObject
            EtiImporte.Text = "Importe " & obj.Abreviatura
        End If
    End Sub

    Private Sub cboCtaCte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtGlosa.Text = "ANTICIPO DE: " & cboClienteProveedor.Text
    End Sub

    Private Sub FecAnticipo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecAnticipo.Validated
        Try
            If EjercicioBanderaCtaBancari <> Date.Parse(FecAnticipo.Value).Year Then
                EjercicioBanderaCtaBancari = Date.Parse(FecAnticipo.Value).Year
                leCuentaBancaria.Clear()
                cboCuentaBancaria.SelectedIndex = -1
                cboCuentaCtble.SelectedIndex = -1
                cboCuentaBancaria.DataSource = Nothing
                cboCuentaCtble.DataSource = Nothing
                CuentaContable()
                CuentaBancaria()
            End If
            If DecTC.Value = 0 Then
                DecTC.Value = TipoCambio(FecAnticipo.Value, True)(0)
            Else
                DecTC.Value = TipoCambio(FecAnticipo.Value, True)(0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ChkCupon_CheckedChanged(sender As Object, e As EventArgs) Handles verCuponPoliza.CheckedChanged
        Try
            If verCuponPoliza.Checked Then
                TabFinanciero.Tabs(0).Visible = True
                TabFinanciero.Tabs(0).Enabled = True
                TabFinanciero.Tabs(0).Selected = True
                verSoats.Checked = False
                VerContratoTercero.Checked = False
                TabFinanciero.Tabs(2).Enabled = False
            Else
                TabFinanciero.Tabs(0).Visible = True
                TabFinanciero.Tabs(0).Enabled = False
                TabFinanciero.Tabs(2).Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            If verCuponPoliza.Checked = True Then
                leCuota.Clear()
                oeCuota.TipoOperacion = "3"
                oeCuota.Activo = 1
                oeCuota.FechaDesde = Date.Parse("01/" + CmbMes.Value.ToString + "/" + DateTimePicker1.Value.Year.ToString)
                leCuota = olCuota.Listar(oeCuota)
                LlenarCombo(CboFilPoliza, "Glosa", leCuota, -1)
                TxtNumeroPoliza.Value = ""
                ndMontoCupon.Value = 0.0
                nd_SaldoCupon.Value = 0.0
                nd_MontoOperaCupon.Value = 0.0
                dtpFechaCupon.Value = Date.Now()
            Else
                oeDocumentoVehicular = New e_DocumentoVehicular
                oeDocumentoVehicular.TipoOperacion = "1"
                oeDocumentoVehicular.IdVehiculo = ("01/" + CmbMes.Value.ToString + "/" + DateTimePicker1.Value.Year.ToString)
                Dim ds As DataSet = olDocumentoVehicular.ListarDts(oeDocumentoVehicular)
                griSegurosZ.DataSource = ds
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CboFilPoliza_ValueChanged(sender As Object, e As EventArgs) Handles CboFilPoliza.ValueChanged
        Try
            If CboFilPoliza.SelectedIndex <> -1 Then
                TxtNumeroPoliza.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).IdDocumento
                ndMontoCupon.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).Monto
                nd_SaldoCupon.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).SaldoAdministrativo
                nd_MontoOperaCupon.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).MontoOpera
                dtpFechaCupon.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).Fecha
                CboMonedaCupon.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).IdMoneda

                FecAnticipo.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).Fecha
                cboMoneda.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).IdMoneda
                DecImporte.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).MontoOpera
            Else
                TxtNumeroPoliza.Value = ""
                ndMontoCupon.Value = 0.0
                nd_SaldoCupon.Value = 0.0
                nd_MontoOperaCupon.Value = 0.0
                dtpFechaCupon.Value = Date.Now()
                CboMonedaCupon.SelectedIndex = -1
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub nd_MontoOperaCupon_ValueChanged(sender As Object, e As EventArgs) Handles nd_MontoOperaCupon.ValueChanged
        Try
            If CboFilPoliza.SelectedIndex <> -1 Then
                If Math.Round(nd_MontoOperaCupon.Value, 2) > Math.Round(nd_SaldoCupon.Value, 2) Then
                    nd_MontoOperaCupon.Value = nd_SaldoCupon.Value
                    TxtGlosa.Focus()
                    nd_MontoOperaCupon.Focus()
                    nd_MontoOperaCupon.SelectAll()
                End If
            Else
                nd_MontoOperaCupon.Value = 0.0
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedor_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboClienteProveedor.InitializeLayout
        Try
            With cboClienteProveedor.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Descripcion").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Width = 350
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles cboClienteProveedor.KeyDown
        Try
            If GroupObligacion.Visible = True Then
                TipoAnticipo = "Proveedor"
            Else
                TipoAnticipo = "Cliente"
            End If
            With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
                If e.KeyData = Keys.Delete Then
                    .Text = ""
                End If
            End With
            If e.KeyCode = Keys.Enter Then
                If TipoAnticipo = "Proveedor" Then
                    If cboClienteProveedor.Text.Trim = "" Then
                        cboClienteProveedor.DataSource = Nothing
                        cboClienteProveedor.DataSource = ProveedorPublic
                    Else
                        cboClienteProveedor.DataSource = Nothing
                        ListaProveedor = New List(Of e_Combo)
                        ListaProveedor = ProveedorPublic
                        cboClienteProveedor.DataSource = ListaProveedor.Where(Function(Item) Item.Nombre.Contains(cboClienteProveedor.Text.Trim)).ToList
                    End If
                ElseIf TipoAnticipo = "Cliente" Then
                    If cboClienteProveedor.Text.Trim = "" Then
                        cboClienteProveedor.DataSource = Nothing
                        cboClienteProveedor.DataSource = ClientesPublic
                    Else
                        cboClienteProveedor.DataSource = Nothing
                        ListaProveedor = New List(Of e_Combo)
                        ListaProveedor = ClientesPublic
                        cboClienteProveedor.DataSource = ListaProveedor.Where(Function(Item) Item.Nombre.Contains(cboClienteProveedor.Text.Trim)).ToList
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboClienteProveedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboClienteProveedor.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub txtCheque_Validated(sender As Object, e As EventArgs) Handles txtCheque.Validated
        Try
            If txtCheque.Text <> "" Then ValidarNroCheque(txtCheque)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verSoats_CheckedChanged(sender As Object, e As EventArgs) Handles verSoats.CheckedChanged
        Try
            If verSoats.Checked Then
                TabFinanciero.Tabs(1).Visible = True
                TabFinanciero.Tabs(1).Enabled = True
                TabFinanciero.Tabs(1).Selected = True
                verCuponPoliza.Checked = False
                VerContratoTercero.Checked = False
                TabFinanciero.Tabs(2).Enabled = False
                LimpiaGrid(griSegurosZ, ogdSeguros)
            Else
                TabFinanciero.Tabs(1).Visible = True
                TabFinanciero.Tabs(1).Enabled = False
                TabFinanciero.Tabs(2).Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griSegurosZ_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griSegurosZ.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griSegurosZ_CellChange(sender As Object, e As CellEventArgs) Handles griSegurosZ.CellChange
        griSegurosZ.UpdateData()
    End Sub

    Private Sub griSegurosZ_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griSegurosZ.AfterCellUpdate
        Try
            Dim Total_Selec As Integer = 0
            Select Case e.Cell.Column.Key
                Case "IndExcluido"
                    If griSegurosZ.Rows.Count > 1 Then
                        If griSegurosZ.ActiveRow.Cells("IndExcluido").Value Then
                            Total_Selec += 1
                            DecImporte.Value += griSegurosZ.ActiveRow.Cells("Importe").Value
                            cboMoneda.Text = griSegurosZ.ActiveRow.Cells("Moneda").Text.ToString
                            cboMoneda.Text = griSegurosZ.ActiveRow.Cells("Moneda").Text
                            griSegurosZ.ActiveRow.Appearance.BackColor = Color.Aqua
                            griSegurosZ.ActiveRow.Fixed = True
                        Else
                            Total_Selec -= 1
                            DecImporte.Value -= griSegurosZ.ActiveRow.Cells("Importe").Value
                            griSegurosZ.ActiveRow.Appearance.BackColor = Color.White
                            griSegurosZ.ActiveRow.Fixed = False
                        End If
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_AnticipoClienteProveedor_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub cmdBuscarContrato_Click(sender As Object, e As EventArgs) Handles cmdBuscarContrato.Click
        oeContratoTercero = New e_ViajesTerceros
        With oeContratoTercero
            .TipoOperacion = 1
            .Documento = txtContratoTercero.Text
            .IdTercero = cboClienteProveedor.Value
        End With
        griContatoTercero.DataSource = olContratoTercero.Listar(oeContratoTercero)
        IdContratoTercero = ""
    End Sub

    Private Sub txtContratoTercero_Validated(sender As Object, e As EventArgs) Handles txtContratoTercero.Validated
        If txtContratoTercero.Text <> "" Then
            txtContratoTercero.Text = FormatoDocumento(txtContratoTercero.Text, 10)
        End If
    End Sub

    Private Sub griContatoTercero_CellChange(sender As Object, e As CellEventArgs) Handles griContatoTercero.CellChange
        griContatoTercero.UpdateData()
        With griContatoTercero.ActiveRow
            If .Cells("Activo").Value = True Then
                cboMoneda.Text = .Cells("IdMoneda").Text
                DecImporte.Value = .Cells("AdelantoFlete").Value
                cboClienteProveedor.Text = .Cells("IdTercero").Text
                IdContratoTercero = .Cells("Id").Text
            Else
                If .Cells("Id").Text = IdContratoTercero Then
                    IdContratoTercero = ""
                    DecImporte.Value = 0
                End If

            End If
        End With
    End Sub

    Private Sub VerContratoTercero_CheckedChanged(sender As Object, e As EventArgs) Handles VerContratoTercero.CheckedChanged
        Try
            If VerContratoTercero.Checked Then
                TabFinanciero.Tabs(2).Visible = True
                TabFinanciero.Tabs(2).Enabled = True
                TabFinanciero.Tabs(2).Selected = True
                verCuponPoliza.Checked = False
                verSoats.Checked = False
                TabFinanciero.Tabs(0).Enabled = False
                TabFinanciero.Tabs(1).Enabled = False
                LimpiaGrid(griContatoTercero, ogdDetalleTercero)
            Else
                TabFinanciero.Tabs(2).Visible = True
                TabFinanciero.Tabs(2).Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griContatoTercero_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griContatoTercero.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Activo"
                    With griContatoTercero.Rows(e.Cell.Row.Index)
                        If .Cells("Activo").Value Then
                            .Appearance.BackColor = Color.Aqua
                            .Fixed = True
                            If IdContratoTercero <> "" Then
                                If .Cells("Id").Text <> IdContratoTercero Then
                                    .Appearance.BackColor = Color.White
                                    .Fixed = False
                                    .Cells("Activo").Value = False
                                    Throw New Exception("Ya se selecciono un registro")
                                End If
                            End If
                            '' AgregarDemanda()
                        Else
                            .Appearance.BackColor = Color.White
                            .Fixed = False
                            'DecImporte.Value = 0
                            ''EliminarDemanda()
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmbClienteProveedor_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cmbClienteProveedor.InitializeLayout
        Me.cmbClienteProveedor.ValueMember = "Id"
        Me.cmbClienteProveedor.DisplayMember = "Nombre"
        With cmbClienteProveedor.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Descripcion").Header.Caption = "RUC/DNI"
            .Columns("Nombre").Header.Caption = "ClienteProveedor"
            .Columns("Descripcion").Header.VisiblePosition = 0
            .Columns("Nombre").Header.VisiblePosition = 1
            .Columns("Descripcion").Width = 80
            .Columns("Nombre").Width = 250
        End With
    End Sub

    Private Sub FecAnticipo_ValueChanged(sender As Object, e As EventArgs) Handles FecAnticipo.ValueChanged
        If DecTC.Value = 0 Then
            DecTC.Value = TipoCambio(FecAnticipo.Value, True)(0)
        Else
            DecTC.Value = TipoCambio(FecAnticipo.Value, True)(0)
        End If
    End Sub

    Private Sub MenuCabecera_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuCabecera.Opening
        Try
            MenuCabecera.Items("AgregarCabecera").Enabled = True
            MenuCabecera.Items("EditarCabecera").Enabled = False
            MenuCabecera.Items("EliminaCabecera").Enabled = False
            MenuCabecera.Items("ExtornaCabecera").Enabled = False
            If gridAnticipos.Rows.Count > 0 And gridAnticipos.Selected.Rows.Count > 0 Then
                If gridAnticipos.ActiveRow.Cells("Saldo").Value = gridAnticipos.ActiveRow.Cells("Total").Value Then
                    MenuCabecera.Items("ExtornaCabecera").Enabled = True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ExtornaCabecera_Click(sender As Object, e As EventArgs) Handles ExtornaCabecera.Click
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EXTORNO") Then
                ExtornarAnticipo()
            Else
                Throw New Exception("No Tiene Permiso para Extornar Anticipos")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridAnticipos_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles gridAnticipos.DoubleClickRow
        Try
            Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
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
        oeAsientoModelo.TipoOperacion = "A"
        oeAsientoModelo.Nombre = IdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N"
        oeReferencia.IdReferencia = IdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Public Function ObtenerAsientoModelo(IdMoneda As String) As e_AsientoModelo
        Try
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModelo = New e_AsientoModelo
            oeAsientoModelo.TipoOperacion = ""
            oeAsientoModelo.Ejercicio = FecAnticipo.DateTime.Year
            oeAsientoModelo.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)
            If TipoAnticipo = "Proveedor" Then ' Cuentas por Pagar Comerciales - Relacionadas
                Dim _oePro As New e_Proveedor
                _oePro.Tipo = 0
                _oePro.Id = cboClienteProveedor.Value
                If leProveedor.Contains(_oePro) Then
                    _oePro = leProveedor.Item(leProveedor.IndexOf(_oePro))
                    If _oePro.IndRelacionada = 1 Then
                        For Each _oeDet In oeAsientoModelo.leDetalle
                            If Microsoft.VisualBasic.Left(_oeDet.Cuenta.Trim, 2) = "42" Then
                                Dim strCuenta As String = Replace(_oeDet.Cuenta, "2", "3", 1, 1)
                                Dim strNuevaCuenta As String = Microsoft.VisualBasic.Left(strCuenta, 4) & "3" & Microsoft.VisualBasic.Right(strCuenta, 1)
                                _oeDet.Cuenta = strNuevaCuenta
                                oeCtaContable = New e_CuentaContable
                                oeCtaContable.Cuenta = strNuevaCuenta : oeCtaContable.Equivale = 0
                                If leCtaContable.Contains(oeCtaContable) Then
                                    oeCtaContable = leCtaContable.Item(leCtaContable.IndexOf(oeCtaContable))
                                    _oeDet.IdCuentaContable = oeCtaContable.Id
                                End If
                            End If
                        Next
                    End If
                End If
            Else ' Cuentas por Cobrar Comerciales - Relacionadas
                Dim _oeCli As New e_Cliente
                _oeCli.Equivale = 1
                _oeCli.Id = cboClienteProveedor.Value
                If leCliente.Contains(_oeCli) Then
                    _oeCli = leCliente.Item(leCliente.IndexOf(_oeCli))
                    If _oeCli.IndRelacionada = 1 Then
                        For Each _oeDet In oeAsientoModelo.leDetalle
                            If Microsoft.VisualBasic.Left(_oeDet.Cuenta.Trim, 2) = "12" Then
                                Dim strCuenta As String = Replace(_oeDet.Cuenta, "2", "3", 1, 1)
                                Dim strNuevaCuenta As String = Microsoft.VisualBasic.Left(strCuenta, 4) & "3" & Microsoft.VisualBasic.Right(strCuenta, 1)
                                _oeDet.Cuenta = strNuevaCuenta
                                oeCtaContable = New e_CuentaContable
                                oeCtaContable.Cuenta = strNuevaCuenta : oeCtaContable.Equivale = 0
                                If leCtaContable.Contains(oeCtaContable) Then
                                    oeCtaContable = leCtaContable.Item(leCtaContable.IndexOf(oeCtaContable))
                                    _oeDet.IdCuentaContable = oeCtaContable.Id
                                End If
                            End If
                        Next
                    End If
                End If
            End If
            Return oeAsientoModelo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Funciones"

    Function ValidarNroCheque(ByVal txt_control As ISL.Controles.Texto) As Boolean
        Try
            Dim ls_Serie As String
            Dim ls_Numero As String

            Dim o_NroCheque() As String = txt_control.Text.Split("-")
            If o_NroCheque.Length > 1 Then
                ls_Serie = o_NroCheque(0).ToString.Trim
                If ls_Serie.Length > 4 Then
                    txt_control.Focus()
                    Throw New Exception("Nº Serie debe ser Menor o Igual a 4 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
                End If

                If txt_control.Text.Trim.Length = 0 Or Not txt_control.Text.Contains("-") Then
                    txt_control.Focus()
                    Throw New Exception("Ingrese Correctamente Doc./Cheque, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
                End If

                ls_Numero = o_NroCheque(1).ToString.Trim
                If ls_Numero.Length < 1 Then
                    txt_control.Focus()
                    Throw New Exception("Numero Seguido de Serie debe ser Mayor a 1 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
                End If

                ls_Serie = FormatoDocumento(ls_Serie, 4)
                ls_Numero = FormatoDocumento(ls_Numero, 10)
                txt_control.Text = ls_Serie & "-" & ls_Numero
            Else
                ls_Numero = o_NroCheque(0).ToString.Trim
                ls_Numero = FormatoDocumento(ls_Numero, 10)
                txt_control.Text = ls_Numero
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class
