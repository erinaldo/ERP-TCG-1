'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Public Class frm_PagosObligacionesFinancieras
    Inherits frm_MenuPadre

#Region "Declaración de variables"

    Private olObligacionFinanciera As New l_ObligacionFinanciera
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private oeFlujoCaja As New e_FlujoCaja, olFlujoCaja As New l_FlujoCaja
    Private oeCtaCble As New e_CuentaContable, olCtaCble As New l_CuentaContable, leCtaCble As New List(Of e_CuentaContable)
    Private oeCtaBancaria As New e_CuentaBancaria, olCtaBancaria As New l_CuentaBancaria, leCuentaBancaria As New List(Of e_CuentaBancaria)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeCtaCtbleAux As New e_CuentaContable, leCtaCtbleAux As New List(Of e_CuentaContable)
    Private oeDetalleAM As New e_DetalleAsientoModelo
    Private oeMedioPago As New e_MedioPago, leProveedor As New List(Of e_Proveedor)
    Private oeObliFin As New e_ObligacionFin, leObliFinPago As New List(Of e_ObligacionFin), leObliFinPend As New List(Of e_ObligacionFin)
    Private oeMoneda As New e_Moneda, olMoneda As New l_Moneda, leMoneda As New List(Of e_Moneda)
    Private MontoCuota As Double
    Private _ComboPeriodo As Boolean = False, _ComboFlujoCaja As Boolean = False
    Private Ejercicio As Integer = 0, EjercicioBanderaCtaBancari As Integer = 0, EjercicioCtaCtble As Integer = 0

#End Region

#Region "Inicialización del formulario"

    Private Shared instancia As frm_PagosObligacionesFinancieras = Nothing
    Private Shared Operacion As String

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_PagosObligacionesFinancieras()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarPago() Then
                limpiarcontroles()
                Listar(True)
                gridObligacion.DisplayLayout.Bands(0).Columns("RetencionME").Hidden = True
                gridObligacion.DisplayLayout.Bands(0).Columns("RetencionMN").Hidden = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If leObliFinPago.Count > 0 Then leObliFinPago.Clear() : gridPagoAgregado.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()

    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
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
            If gridObligacion.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(gridObligacion)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub limpiarcontroles()
        Try
            txtVoucher.Clear()
            EtiImporteDolares.Text = "0.0" : etiImporteSoles.Text = "0.0"
            EtiInteresObligacionDolares.Text = "0.0" : etiInteresObligacionSoles.Text = "0.0"
            etiIntMoratorioDolares.Text = "0.0" : etiIntMoratorioSoles.Text = "0.0"
            etiDsctoInteresDolares.Text = "0.0" : etiDsctoInteresSoles.Text = "0.0"
            etiComisionDolares.Text = "0.0" : etiComisionSoles.Text = "0.0"
            etiGastosDolares.Text = "0.0" : etiGastosSoles.Text = "0.0"
            etiITFDolares.Text = "0.0" : etiITFSoles.Text = "0.0"
            etiTotalmasInteresDol.Text = "0.0" : etiTotalMasInteresSol.Text = "0.0"
            etiTotalObliFinPagarDolares.Text = "0.0" : etiTotalObliFinPagarSoles.Text = "0.0"
            leObliFinPago.Clear()
            gridPagoAgregado.DataBind()
            LimpiaGrid(gridObligacion, odObliFinPend)
            'cboMoneda.SelectedIndex = -1
            chkExcluyeInteresPagare.Checked = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarPago() As Boolean
        Try
            If validarPagos() Then
                'Obtener Periodo
                oePeriodo = New e_Periodo
                oePeriodo = ObtenerPeriodo(CDate(Fecha.Value))
                'Obtiene Asiento Modelo
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Id = leAsientoModel(0).Id
                oeAsientoModel.Ejercicio = CDate(Fecha.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                oeAsientoModel.IdPeriodo = oePeriodo.Id : oeAsientoModel.FechaMov = Fecha.Value
                oeAsientoModel.TipoCambio = DecTC.Value : oeAsientoModel.IdMoneda = oeMoneda.Id : oeAsientoModel.Moneda = oeMoneda.Nombre
                'Cargar Datos Obligacion Financiera
                oeObliFin = New e_ObligacionFin
                oeObliFin = leObliFinPago(0)
                oeObliFin.UsuarioModifica = gUsuarioSGI.Id
                oeObliFin.IndExcluirInteres = chkExcluyeInteresPagare.Checked
                'Cargar Linea Especial Para FEC y PAGARE
                If oeObliFin.IdTipoObligacion = gTOFec Or oeObliFin.IdTipoObligacion = gTOPagare Or oeObliFin.IdTipoObligacion = gTOCreditoHipotecario Then
                    Dim _CtaFec As String = "", _IdCtaFec As String = ""
                    If oeObliFin.IdTipoObligacion = gTOFec Or oeObliFin.IdTipoObligacion = gTOCreditoHipotecario Then
                        _CtaFec = IIf(oeMoneda.Nombre = "SOLES", gPOEFecSol, gPOEFecDol)
                    Else
                        _CtaFec = gPOEPagare
                    End If
                    Dim _leAux = leCtaCtbleAux.Where(Function(it) it.Cuenta = _CtaFec).ToList
                    If _leAux.Count > 0 Then
                        oeObliFin.IndFec = True
                        oeObliFin.CtaFec = _CtaFec
                        _IdCtaFec = _leAux(0).Id
                        oeDetalleAM = New e_DetalleAsientoModelo
                        oeDetalleAM.Fila = "B"
                        oeDetalleAM.Activo = True
                        oeDetalleAM.IdAsientoModelo = oeAsientoModel.Id
                        oeDetalleAM.Partida = 1
                        oeDetalleAM.MontoAux = oeObliFin.MontoInteres
                        oeDetalleAM.IdCuentaContable = _IdCtaFec
                        oeDetalleAM.Cuenta = _CtaFec
                        oeAsientoModel.leDetalle.Add(oeDetalleAM)
                    End If
                End If
                'Cargar Datos de Movimiento Caja Banco
                oeObliFin.oeMovCajaBanco = New e_MovimientoCajaBanco
                With oeObliFin.oeMovCajaBanco
                    ._Operador = -1
                    .IdFlujoCaja = cboFlujoGasto.Value
                    .NroBoucher = txtVoucher.Text
                    .IdCuentaBancaria = oeCtaBancaria.Id
                    .Fecha = Fecha.Value
                    .IdMedioPago = cboMedio.Value
                    .IdPeriodoConcilia = ""
                    .Activo = True
                    .TipoCambio = DecTC.Value
                    .TotalMN = Double.Parse(etiTotalMasInteresSol.Text)
                    .TotalME = Double.Parse(etiTotalmasInteresDol.Text)
                    .TipoOperacion = "I"
                    .MovDoc = Nothing
                    .IdCta10 = cboCuentaContable.Value
                    .MacLocal = MacPCLocal()
                End With
                For Each oeDetAux In oeAsientoModel.leDetalle
                    Select Case oeDetAux.Cuenta
                        Case gPODescuento
                            If oeObliFin.MontoInteresDscto > 0 Then oeDetAux.IndAgregar = True : oeDetAux.MontoAux = oeObliFin.MontoInteresDscto
                        Case gPOMora
                            If oeObliFin.MontoInteresMoratorio > 0 Then oeDetAux.IndAgregar = True : oeDetAux.MontoAux = oeObliFin.MontoInteresMoratorio
                        Case gPOComision
                            If oeObliFin.Comision > 0 Then oeDetAux.IndAgregar = True : oeDetAux.MontoAux = oeObliFin.Comision
                        Case gPOGastos
                            If oeObliFin.Gastos > 0 Then oeDetAux.IndAgregar = True : oeDetAux.MontoAux = oeObliFin.Gastos
                        Case gPOITF
                            If oeObliFin.ITF > 0 Then oeDetAux.IndAgregar = True : oeDetAux.MontoAux = oeObliFin.ITF
                    End Select
                Next
                Dim lst_ObligFin_MovDoc As New List(Of e_ObligacionDocumento)
                Dim oe_DocRetDet As e_DocumentoRetencionDetalle
                Dim aux As e_DocumentoRetencionDetalle
                Dim ol_DocRetDet As l_DocumentoRetencionDetalle
                Dim lst_DocRetDet As New List(Of e_DocumentoRetencionDetalle)
                Dim aux_lst As New List(Of e_DocumentoRetencionDetalle)
                Dim oe_ObligFin_MovDoc As New e_ObligacionDocumento
                Dim ol_ObligFin_MovDoc As New l_ObligacionDocumento
                Dim oe_MovDoc As New e_MovimientoDocumento
                Dim ol_MovDoc As New l_MovimientoDocumento
                Dim retencion_orig As Double = 0.0
                Dim moneda As String = ""
                oe_ObligFin_MovDoc.IdObligacionFinanciera = oeObliFin.Id
                lst_ObligFin_MovDoc = ol_ObligFin_MovDoc.Listar(oe_ObligFin_MovDoc).ToList
                If lst_ObligFin_MovDoc.Where(Function(g) g.RetencionME > 0.0).Count > 0 Then
                    For Each fila In lst_ObligFin_MovDoc
                        oe_MovDoc = New e_MovimientoDocumento
                        oe_MovDoc.Id = fila.IdMovimientoDocumento
                        oe_MovDoc.TipoOperacion = ""
                        oe_MovDoc = ol_MovDoc.Listar(oe_MovDoc).Item(0)
                        oe_DocRetDet = New e_DocumentoRetencionDetalle
                        With oe_DocRetDet
                            .IdMovimientoDocumento = fila.IdMovimientoDocumento
                            .FechaPago = oeObliFin.FechaVencimiento
                            .NumeroPago = oeObliFin.NroVencimiento
                            .IdProveedor = oe_MovDoc.IdClienteProveedor
                            .TipoOperacion = ""
                            .NroVoucher = "LETRA " & oeObliFin.NroVencimiento
                            .Activo = 1
                            .MontoPagoOrigen = oe_MovDoc.Total
                            moneda = oe_MovDoc.IdMoneda
                            retencion_orig = IIf(moneda = "1CH01", fila.RetencionMN, fila.RetencionME)
                            .RetencionOrigen = retencion_orig
                            ol_DocRetDet = New l_DocumentoRetencionDetalle
                            aux_lst = New List(Of e_DocumentoRetencionDetalle)
                            aux_lst = ol_DocRetDet.Listar(oe_DocRetDet)
                            aux = New e_DocumentoRetencionDetalle
                            .UsuarioCreacion = gUsuarioSGI.IdTrabajador
                            .UsuarioModifica = gUsuarioSGI.IdTrabajador
                            .TipoCambio = DecTC.Value
                            .RetencionSoles = IIf(moneda = "1CH01", fila.RetencionMN, fila.RetencionME * DecTC.Value)
                            .MontoPagoSoles = IIf(moneda = "1CH01", oe_MovDoc.Total, oe_MovDoc.Total * DecTC.Value)
                            .TipoOperacion = "I"
                            .PrefijoID = gs_PrefijoIdSucursal '@0001
                            If aux_lst.Count = 0 Then lst_DocRetDet.Add(oe_DocRetDet)

                        End With
                    Next
                End If
                oeObliFin.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olObligacionFinanciera.GuardarPago2(oeObliFin, oeAsientoModel, lst_DocRetDet) Then
                    mensajeEmergente.Confirmacion("Los Datos se han Guardado Correctamente", True)
                    Dim frm2 As New frm_ImprimeCobroPagoAnticipo(oeObliFin.oeMovCajaBanco.Id, 0, "Obligacion")
                    frm2.ShowDialog()
                    frm2 = Nothing
                    Return True
                End If
                'If olObligacionFinanciera.GuardarPago(leObligacFinan, oeMovCajaBanco, oeMedioPago, gUsuarioSGI.Id, MacPCLocal, oeCtaCble) Then
                '    mensajeEmergente.Confirmacion("Pago(s) guardados satisfactoriamente")
                '    Dim olMoviminetodocumento As New l_MovimientoDocumento      'Para llamar a la funcion Ajuste Tipo de Cambio
                '    Dim Operacion As String = "PAG"      'Tipo de Operacion Cobranza
                '    Dim oePeriodo As New e_Periodo
                '    oePeriodo.Ejercicio = Fecha.DateTime.Year
                '    oePeriodo.Mes = Fecha.DateTime.Month
                '    If olMoviminetodocumento.AjusteTipoCambioObligacion(Operacion, oePeriodo, leObligacFinan, gUsuarioSGI.Id) Then
                '        mensajeEmergente.Confirmacion("Se Realizo Ajuste de Tipo Cambio")
                '    End If
                '    Dim frm2 As New frm_ImprimeCobroPagoAnticipo(oeMovCajaBanco.Id, 0, "Obligacion")
                '    frm2.ShowDialog()
                '    frm2 = Nothing
                'End If
                'Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            If cboMoneda.SelectedIndex = -1 Then Throw New Exception("Seleccione un Cuenta Bancaria en Moneda")
            If gridPagoAgregado.Rows.Count > 0 Then
                If MessageBox.Show("Existen Pagos agregados, desea eliminarlos", "Mensaje del Sistema", _
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                = Windows.Forms.DialogResult.Yes Then
                    leObliFinPago.Clear() : gridPagoAgregado.DataBind()
                Else
                    Exit Sub
                End If
            Else
                leObliFinPago.Clear()
            End If
            ValidarCombo(cboProveedor, "Banco")
            Me.Cursor = Cursors.WaitCursor
            oeObliFin = New e_ObligacionFin
            oeObliFin.TipoOperacion = "P" : oeObliFin.Banco = cboProveedor.Value
            oeObliFin.Ejercicio = Date.Parse(Fecha.Value).Year : oeObliFin.IdMoneda = cboMoneda.Value
            LimpiaGrid(gridObligacion, odObliFinPend)
            leObliFinPend.Clear()
            leObliFinPend.AddRange(olObligacionFinanciera.Listar2(oeObliFin))
            gridObligacion.DataBind()
            gridObligacion.DataSource = leObliFinPend
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            gridObligacion.Focus()
        End Try
    End Sub

    Private Sub LlenaFlujoCaja()
        Try
            Dim oeFlujoCaja As New e_FlujoCaja
            Dim olFlujoCaja As New l_FlujoCaja
            LlenarCombo(cboFlujoGasto, "Nombre", olFlujoCaja.Listar(oeFlujoCaja), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaCuentaBancaria()
        Try
            If leCuentaBancaria.Count = 0 Then
                oeCtaBancaria = New e_CuentaBancaria
                oeCtaBancaria.IdCuentaContable = oeCtaCble.Id 'Relacionada con Cuenta COntale
                oeCtaBancaria.TipoOperacion = "P"
                oeCtaBancaria.Ejercicio = Date.Parse(Fecha.Value).Year
                oeCtaBancaria.Activo = True
                leCuentaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
                LlenarCombo(cboCuentaBancaria, "BancoCuenta", leCuentaBancaria, -1)
                cboCuentaBancaria.Enabled = IIf(leCuentaBancaria.Count = 0, False, True)
            Else
                Dim lista As New List(Of e_CuentaBancaria)
                lista = leCuentaBancaria.ToList
                lista = lista.Where(Function(item) item.IdCuentaContable = oeCtaCble.Id).ToList()
                If lista.Count = 0 Then
                    cboCuentaBancaria.SelectedIndex = -1 : cboCuentaBancaria.Enabled = False
                Else
                    LlenarCombo(cboCuentaBancaria, "BancoCuenta", lista, -1)
                    cboCuentaBancaria.Enabled = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaMoneda()
        Try
            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            LlenarCombo(cboMoneda, "Nombre", leMoneda, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub llenacuenta()
        Try
            If Ejercicio <> Year(Fecha.Value) Then
                Ejercicio = Year(Fecha.Value)
                oeCtaCble = New e_CuentaContable
                oeCtaCble.Activo = True : oeCtaCble.Movimiento = 1
                oeCtaCble.FlujoCaja = 1 : oeCtaCble.Ejercicio = Year(Fecha.Value)
                With cboCuentaContable
                    .ValueMember = "Id" : .DisplayMember = "Nombre" : .DataSource = olCtaCble.Listar(oeCtaCble)
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaProveedor()
        Try
            Dim oeProveedor As New e_Proveedor
            Dim olProveedor As New l_Proveedor
            oeProveedor.Activo = True
            oeProveedor.TipoOperacion = "4"
            leProveedor.AddRange(olProveedor.Listar(oeProveedor))
            With cboProveedor
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leProveedor
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaTipoDocumentoOperacion()
        Try
            Dim oeTipoDoc As New e_TipoDocumento
            Dim leTipoDoc As New List(Of e_TipoDocumento)
            Dim olTipoDoc As New l_TipoDocumento
            oeTipoDoc.Activo = True
            oeTipoDoc.TipoOperacion = "I" 'proceso contabilidad
            leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombos()
        Try
            LlenaFlujoCaja()
            LlenaMoneda()
            LlenaProveedor()
            llenaMedio()
            LlenaCuentaBancaria()
            LlenaTipoDocumentoOperacion()
            llenacuenta()
            CargarAsientoModel()
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
                .Text = "DEPOSITO EN CUENTA"
            End With

            'cboMedio.Enabled = False 'Desativa el control 
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function validarPagos() As Boolean
        Try
            ValidarCombo(cboMedio, "Medio de Pago")
            ValidarCombo(cboCuentaContable, "Cuenta Contable")
            If cboCuentaBancaria.Enabled Then ValidarCombo(cboCuentaBancaria, "Cuenta Bancaria")
            ValidarCombo(cboFlujoGasto, "Flujo de Gasto")
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            If Double.Parse(etiImporteSoles.Text) < 0 Then Throw New Exception("El importe debe ser mayor a 0")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtVoucher.Text, "Ingrese el Voucher")
            If leObliFinPago.Count <= 0 Then Throw New Exception("No Existen Pagos para registrar")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Private Function validarmonto() As Boolean
    '    Try
    '        For Each oeobligFinc As e_ObligacionFinanciera In leObligacFinan
    '            With oeobligFinc
    '                If .MontoOperar > .Saldo Then Throw New Exception("El Monto a Pagar es mayor al Saldo")
    '                If .MontoOperar <= 0 Then Throw New Exception("El Monto a Pagar es igual a cero")
    '            End With
    '        Next
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Private Sub AgregarDetalle()
        Try
            'Dim _CtaCtableAct As String = String.Empty
            If DecTC.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
            If gridPagoAgregado.Rows.Count > 0 Then Throw New Exception("Solo puede Agregar una Obigacion para Pagar")
            If gridObligacion.Rows.Count > 0 AndAlso Not gridObligacion.ActiveRow.ListObject Is Nothing Then
                chkExcluyeInteresPagare.Checked = False
                oeObliFin = New e_ObligacionFin
                oeObliFin = gridObligacion.ActiveRow.ListObject
                oeObliFin.TipoOperacion = "I"
                'Actualiza Cuenta Contable
                If oeObliFin.IdCuentaContable.Trim.Length > 0 Then
                    oeCtaCtbleAux = New e_CuentaContable
                    oeCtaCtbleAux.Id = oeObliFin.IdCuentaContable
                    oeCtaCtbleAux = olCtaCble.Obtener(oeCtaCtbleAux)
                    If oeCtaCtbleAux.Ejercicio <> EjercicioCtaCtble Then
                        Dim _leCCAux = leCtaCtbleAux.Where(Function(it) it.Cuenta = oeCtaCtbleAux.Cuenta).ToList
                        If _leCCAux.Count > 0 Then oeObliFin.IdCuentaContable = _leCCAux(0).Id
                    End If
                Else
                    Throw New Exception("No se asignado Cuenta Contable para esta Obligación Financiera")
                End If
                '--------------------------
                leObliFinPago.Clear()
                leObliFinPago.Add(oeObliFin)
                mostrar_totales()
                gridPagoAgregado.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mostrar_totales()
        Try
            Dim importeMN As Double = 0, importeME As Double = 0, importeIntMoratorioMN As Double = 0, importeIntMoratorioME As Double = 0
            Dim importeInteresMN As Double = 0, importeInteresME As Double = 0, importeDsctoInteresMN As Double = 0, importeDsctoInteresME As Double = 0
            Dim comisionMN As Double = 0, comisionME As Double = 0, gastosMN As Double = 0, gastosME As Double = 0, itfMN As Double = 0, itfME As Double = 0
            Dim SumaInteres As Boolean = True
            For Each oeOFAux In leObliFinPago
                With oeOFAux
                    'If .IdTipoObligacion = gTOPagare Or .IdTipoObligacion = gTOPrestamo Then
                    SumaInteres = Not chkExcluyeInteresPagare.Checked
                    'End If
                    If .IdMoneda = "SOLES" Then
                        importeMN = .MontoMN : importeME = .MontoMN / DecTC.Value
                        importeInteresMN = importeInteresMN + .MontoInteres
                        importeInteresME = importeInteresME + .MontoInteres / DecTC.Value
                        importeIntMoratorioMN = importeIntMoratorioMN + .MontoInteresMoratorio
                        importeIntMoratorioME = importeIntMoratorioME + .MontoInteresMoratorio / DecTC.Value
                        importeDsctoInteresMN = importeDsctoInteresMN + .MontoInteresDscto
                        importeDsctoInteresME = importeDsctoInteresME + .MontoInteresDscto / DecTC.Value
                        comisionMN = comisionMN + .Comision
                        comisionME = comisionME + .Comision / DecTC.Value
                        gastosMN = gastosMN + .Gastos
                        gastosME = gastosME + .Gastos / DecTC.Value
                        itfMN = itfMN + .ITF
                        itfME = itfME + .ITF / DecTC.Value
                    Else
                        importeMN = .MontoME * DecTC.Value : importeME = .MontoME
                        importeInteresMN = importeInteresMN + .MontoInteres * DecTC.Value
                        importeInteresME = importeInteresME + .MontoInteres
                        importeIntMoratorioMN = importeIntMoratorioMN + .MontoInteresMoratorio * DecTC.Value
                        importeIntMoratorioME = importeIntMoratorioME + .MontoInteresMoratorio
                        importeDsctoInteresMN = importeDsctoInteresMN + .MontoInteresDscto * DecTC.Value
                        importeDsctoInteresME = importeDsctoInteresME + .MontoInteresDscto
                        comisionMN = comisionMN + .Comision * DecTC.Value
                        comisionME = comisionME + .Comision
                        gastosMN = gastosMN + .Gastos * DecTC.Value
                        gastosME = gastosME + .Gastos
                        itfMN = itfMN + .ITF * DecTC.Value
                        itfME = itfME + .ITF
                    End If
                End With
            Next
            etiImporteSoles.Text = Format(Math.Round(importeMN, 4), "##,##0.0000")
            EtiImporteDolares.Text = Format(Math.Round(importeME, 4), "##,##0.0000")
            etiIntMoratorioSoles.Text = Format(Math.Round(importeIntMoratorioMN, 4), "##,##0.0000")
            etiIntMoratorioDolares.Text = Format(Math.Round(importeIntMoratorioME, 4), "##,##0.0000")
            etiDsctoInteresSoles.Text = Format(Math.Round(importeDsctoInteresMN, 4), "##,##0.0000")
            etiDsctoInteresDolares.Text = Format(Math.Round(importeDsctoInteresME, 4), "##,##0.0000")
            etiComisionSoles.Text = Format(Math.Round(comisionMN, 4), "##,##0.0000")
            etiComisionDolares.Text = Format(Math.Round(comisionME, 4), "##,##0.0000")
            etiGastosSoles.Text = Format(Math.Round(gastosMN, 4), "##,##0.0000")
            etiGastosDolares.Text = Format(Math.Round(gastosME, 4), "##,##0.0000")
            etiITFSoles.Text = Format(Math.Round(itfMN, 4), "##,##0.0000")
            etiITFDolares.Text = Format(Math.Round(itfME, 4), "##,##0.0000")
            etiTotalObliFinPagarSoles.Text = Format(Math.Round(importeMN + importeIntMoratorioMN + comisionMN + gastosMN + itfMN - importeDsctoInteresMN, 4), "##,##0.0000")
            etiTotalObliFinPagarDolares.Text = Format(Math.Round(importeME + importeIntMoratorioME + comisionME + gastosME + itfME - importeDsctoInteresME, 4), "##,##0.0000")
            If SumaInteres Then
                etiInteresObligacionSoles.Text = Format(Math.Round(importeInteresMN, 4), "##,##0.0000")
                EtiInteresObligacionDolares.Text = Format(Math.Round(importeInteresME, 4), "##,##0.0000")
                etiTotalMasInteresSol.Text = Format(Math.Round(importeMN + importeIntMoratorioMN + importeInteresMN + comisionMN + gastosMN + itfMN - importeDsctoInteresMN, 4), "##,##0.0000")
                etiTotalmasInteresDol.Text = Format(Math.Round(importeME + importeIntMoratorioME + importeInteresME + comisionME + gastosME + itfME - importeDsctoInteresME, 4), "##,##0.0000")
            Else
                etiInteresObligacionSoles.Text = "0.00" : EtiInteresObligacionDolares.Text = "0.00"
                etiTotalMasInteresSol.Text = etiTotalObliFinPagarSoles.Text : etiTotalmasInteresDol.Text = etiTotalObliFinPagarDolares.Text
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub QuitarDetalle()
        Try
            If gridPagoAgregado.Rows.Count <= 0 Then Throw New Exception("Seleccione una fila")
            ValidarGrilla(gridPagoAgregado, "Documentos x Rendir agregados")
            If Not gridPagoAgregado.ActiveRow.ListObject Is Nothing AndAlso _
                gridPagoAgregado.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            leObliFinPago.Clear()
            mostrar_totales()
            gridPagoAgregado.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function ValidarAgregarDetalle(ByVal oeObligFinanc As e_ObligacionFinanciera) As Boolean
        Try
            'If oeObligacionFinanciera.IdTipoObligacion = "1CH000000067" Then ''no se puede pagar leasing
            '    Throw New Exception("No se puede pagar Leasing")
            'End If
            'If oeObligFinanc.Saldo < 0 Then Throw New Exception("No se puede operar: es negativo")
            'ValidarGrilla(gridObligacion, "Obligaciones x Pagar")
            'If Not gridObligacion.ActiveRow Is Nothing AndAlso gridObligacion.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            'If gridPagoAgregado.Rows.Count > 0 Then 'Verificar que solo pueda ingresar Pagos de un solo Banco
            '    If gridPagoAgregado.Rows.Item(0).Cells("IdClienteProveedor").Value <> oeObligacionFinanciera.IdClienteProveedor Then
            '        Throw New Exception("Solo puede agregar Documentos de un Solo Banco")
            '    End If
            '    If gridPagoAgregado.Rows.Item(0).Cells("IdTipoObligacion").Value <> oeObligacionFinanciera.IdTipoObligacion Then
            '        Throw New Exception("Solo puede agregar Obligaciones de un solo tipo")
            '    End If
            'End If
            'l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Return False
        End Try
    End Function

    Private Sub inicializar()
        Try
            ControlBoton(1, 1, 1, 1, 0, 0, 0, 0, 1)
            oePeriodo.Ejercicio = Date.Now.Year
            gridPagoAgregado.DataSource = leObliFinPago
            gridObligacion.DataSource = leObliFinPend
            gridPagoAgregado.DisplayLayout.Bands(0).Columns("RetencionMN").Hidden = True
            gridPagoAgregado.DisplayLayout.Bands(0).Columns("RetencionME").Hidden = True
            gridObligacion.DisplayLayout.Bands(0).Columns("RetencionME").Hidden = True
            gridObligacion.DisplayLayout.Bands(0).Columns("RetencionMN").Hidden = True
            _ComboPeriodo = True
            LlenarCombos()
            EjercicioBanderaCtaBancari = Date.Parse(Fecha.Value).Year
            DecTC.Value = TipoCambio(Fecha.Value, False)(0)
            If DecTC.Value = 0.0 Then
                mensajeEmergente.Problema("No existe tipo de cambio. Comuníquese con el área de contabilidad para actualizar.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CargarAsientoModel()
        'Cargar Cuentas Contables
        oeCtaCtbleAux = New e_CuentaContable
        oeCtaCtbleAux.TipoOperacion = "N"
        oeCtaCtbleAux.Activo = True : oeCtaCtbleAux.Ejercicio = Date.Now.Year : EjercicioCtaCtble = Date.Now.Year
        leCtaCtbleAux = olCtaCble.Listar(oeCtaCtbleAux).OrderBy(Function(it) it.Nombre).ToList
        'Cargar Modelo
        oeAsientoModel = New e_AsientoModelo
        oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
        leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
    End Sub

    Private Sub RecargarCtaCtable(AnioPago As Integer)
        Try
            oeCtaCtbleAux = New e_CuentaContable
            oeCtaCtbleAux.TipoOperacion = "N"
            oeCtaCtbleAux.Activo = True : oeCtaCtbleAux.Ejercicio = AnioPago
            leCtaCtbleAux = olCtaCble.Listar(oeCtaCtbleAux).OrderBy(Function(it) it.Nombre).ToList
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_PagosObligacionesFinancieras_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub frm_PagosObligacionesFinancieras_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_PagosObligacionesFinancieras_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_PagosObligacionesFinancieras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub gridObligacion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridObligacion.DoubleClick
        Try
            AgregarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub DecTC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTC.ValueChanged
        Try
            mostrar_totales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Fecha_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha.Validated
        Try
            If EjercicioBanderaCtaBancari <> Date.Parse(Fecha.Value).Year Then
                EjercicioBanderaCtaBancari = Date.Parse(Fecha.Value).Year
                leCuentaBancaria.Clear()
                cboCuentaBancaria.SelectedIndex = -1
                cboCuentaContable.SelectedIndex = -1
                cboCuentaBancaria.DataSource = Nothing
                cboCuentaContable.DataSource = Nothing
                oeCtaBancaria = New e_CuentaBancaria
                oeCtaCble = New e_CuentaContable
                LlenaCuentaBancaria()
                llenacuenta()
                leObliFinPend.Clear()
                gridPagoAgregado.DataBind()
                LimpiaGrid(gridObligacion, odObliFinPend)
            End If
            If DecTC.Value = 0 Then
                DecTC.Value = TipoCambio(Fecha.Value)(0)
            Else
                If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                   = Windows.Forms.DialogResult.Yes Then
                    DecTC.Value = TipoCambio(Fecha.Value)(0)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCuentaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaBancaria.ValueChanged
        Try
            With cboCuentaBancaria
                If cboCuentaBancaria.SelectedIndex <> -1 Then
                    oeCtaBancaria = New e_CuentaBancaria
                    Dim i As Integer = .SelectedIndex
                    oeCtaBancaria = .Items(i).ListObject
                    Dim _leMonAux = leMoneda.Where(Function(it) it.Id = oeCtaBancaria.IdMoneda).ToList
                    If _leMonAux.Count > 0 Then
                        oeMoneda = New e_Moneda : oeMoneda.Id = _leMonAux(0).Id : oeMoneda.Nombre = _leMonAux(0).Nombre : cboMoneda.Value = oeMoneda.Id
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCuentaContable_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaContable.ValueChanged
        Try
            oeCtaCble = New e_CuentaContable
            With cboCuentaContable
                If .SelectedIndex <> -1 Then
                    Dim i As Integer = .SelectedIndex
                    oeCtaCble = .Items(i).ListObject
                End If
            End With
            If cboCuentaContable.Enabled Then LlenaCuentaBancaria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridPagoAgregado_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridPagoAgregado.CellChange
        Try
            With gridPagoAgregado
                l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
                .UpdateData()
                If IsNumeric(e.Cell.Value) Then
                    Dim obj As New e_ObligacionFin
                    obj = gridPagoAgregado.ActiveRow.ListObject
                    If Math.Abs(obj.Saldo) < Math.Abs(CDbl(e.Cell.Value)) Then Throw New Exception("El monto ingresado es mayor al saldo")
                    mostrar_totales()
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMedio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedio.ValueChanged
        oeMedioPago = New e_MedioPago
        With cboMedio
            Dim i As Integer = .SelectedIndex
            oeMedioPago = .Items(i).ListObject
        End With
    End Sub

    Private Sub QuitarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarDocumento.Click
        Try
            QuitarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha.ValueChanged
        Try
            If EjercicioCtaCtble <> Date.Parse(Fecha.Value).Year Then
                EjercicioCtaCtble = Date.Parse(Fecha.Value).Year
                RecargarCtaCtable(EjercicioCtaCtble)
            End If
            Validar_TipoCambio()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtRuc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuc.ValueChanged
        If Not txtRuc.Value Is Nothing Then
            If txtRuc.Value.ToString.Trim.Length > 7 Then
                Dim leProveedorList As New List(Of e_Proveedor)
                leProveedorList = leProveedor.ToList
                leProveedorList = leProveedor.Where(Function(item) item.NroDocumento.Contains(txtRuc.Value)).ToList
                If leProveedorList.Count > 0 Then
                    cboProveedor.Value = leProveedorList(0).Id
                End If
            End If
        End If
    End Sub

    Private Sub chkCalculadora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCalculadora.CheckedChanged
        If chkCalculadora.Checked Then
            gridPagoAgregado.DisplayLayout.Bands(0).Columns("MontoOperar").EditorComponent = Me.UltraCalculatorDropDown1
        Else
            gridPagoAgregado.DisplayLayout.Bands(0).Columns("MontoOperar").EditorComponent = Nothing
        End If

    End Sub

    Private Sub chkExcluyeInteresPagare_CheckedChanged(sender As Object, e As EventArgs) Handles chkExcluyeInteresPagare.CheckedChanged
        If gridPagoAgregado.Rows.Count > 0 Then
            mostrar_totales()
        End If
    End Sub

    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar.Click
        Consultar(True)
        gridObligacion.DisplayLayout.Bands(0).Columns("RetencionME").Hidden = True
        gridObligacion.DisplayLayout.Bands(0).Columns("RetencionMN").Hidden = True
    End Sub

    Private Sub gridPagoAgregado_BeforeCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles gridPagoAgregado.BeforeCellUpdate
        Try
            If IsDBNull(e.NewValue) Then e.Cancel = True : Exit Sub
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridPagoAgregado_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridPagoAgregado.AfterCellUpdate
        Try
            If IsDBNull(e.Cell.Value) Then e.Cell.Value = 0 : Exit Sub
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

   
#End Region

    Private Sub DecTC_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles DecTC.EditorButtonClick
        Validar_TipoCambio()
    End Sub

    Private Sub Validar_TipoCambio()
        Try
            DecTC.Value = TipoCambio(Fecha.Value, False)(0)
            If DecTC.Value = 0.0 Then Throw New Exception("Comuníquese con el Área de Contabilidad para actualizar el T.C. del día seleccionado.")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub
End Class
