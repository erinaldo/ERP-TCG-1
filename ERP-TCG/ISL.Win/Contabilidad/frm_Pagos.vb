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
Imports System.ServiceModel

Public Class frm_Pagos
    Inherits frm_MenuPadre

#Region "Declaración de variables"

    Private WithEvents oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento

    Private oeFlujoCaja As New e_FlujoCaja
    Private olFlujoCaja As New l_FlujoCaja

    Private olAsiento As New l_Asiento

    Private oeCtaCble As New e_CuentaContable
    Private olCtaCble As New l_CuentaContable
    Private leCtaCble As New List(Of e_CuentaContable)

    Private oeCtaBancaria As New e_CuentaBancaria
    Private olCtaBancaria As New l_CuentaBancaria
    Private leCuentaBancaria As New List(Of e_CuentaBancaria)

    Private oeMovCajaBanco As New e_MovimientoCajaBanco
    Private olMovCajaBanco As New l_MovimientoCajaBanco

    Private oeMedioPago As New e_MedioPago

    Private leMovDoc As New List(Of e_MovimientoDocumento)
    Private leMovDocAgregado As New List(Of e_MovimientoDocumento)

    Dim MontoCuota As Double

    Private _ComboPeriodo As Boolean = False
    Private _ComboFlujoCaja As Boolean = False

    Private Shared instancia As frm_Pagos = Nothing
    Private Shared Operacion As String
    Private Ejercicio As Integer = 0
    Private leProveedor As New List(Of e_Proveedor)
    Private EjercicioBanderaCtaBancari As Integer

    Dim Opcion As String
    Dim _ingresando_datos As Boolean = False

    Dim FechaServidor As Date = Now.Date

    Private ln_TasaRetencion As Double = 0
    Private olRetencion As l_DocumentoRetencion

#End Region

#Region "Inicialización del formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Pagos()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If gridPago.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
            Else
                ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
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
            If OptPago.Checked Then
                If MessageBox.Show("Se pagará un monto normal(NORMAL), Desea continuar?", _
                Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
            If OptGanancia.Checked Then
                If MessageBox.Show("Se enviará a ganancia(GANANCIA), Desea Continuar?", _
                Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
            If GuardarPago() Then
                limpiarcontroles()
                Listar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMovimientoDocumento.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If Not GuardarPago() Then
                            Consultar(True)
                        End If
                    Case Windows.Forms.DialogResult.No
                        Consultar(True)
                End Select
            Else
                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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
            If gridPago.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(gridPago)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub limpiarcontroles()
        Try
            txtVoucher.Clear()
            EtiImporteDolares.Text = "0"
            EtiImporteSoles.Text = "0"
            chkRetencion.Checked = False
            decRetencion.Value = 0
            leMovDocAgregado.Clear()
            gridPagoAgregado.DataBind()
            LimpiaGrid(gridPago, UltraDataSource1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarPago() As Boolean
        Try
            If validarPagos() Then
                ''Lleno el objeto MovimientoCajaBanco (SOLO INSERCIONES)
                With oeMovCajaBanco
                    .IdFlujoCaja = cboFlujoGasto.Value
                    .NroBoucher = txtVoucher.Text
                    .IdCuentaBancaria = oeCtaBancaria.Id
                    .Fecha = Fecha.Value
                    .IdMedioPago = cboMedio.Value
                    .IdPeriodoConcilia = ""
                    .Activo = True
                    .TipoCambio = DecTC.Value
                    If chkRetencion.Checked Then
                        .TotalMN = Math.Round(CDbl(EtiImporteSoles.Text) * (1 - ln_TasaRetencion), 4)
                        .TotalME = Math.Round(CDbl(EtiImporteDolares.Text) * (1 - ln_TasaRetencion), 4)
                    Else
                        .TotalMN = Math.Round(Double.Parse(EtiImporteSoles.Text), 4)
                        .TotalME = Math.Round(Double.Parse(EtiImporteDolares.Text), 4)
                    End If
                    .TipoOperacion = "I"
                    .MovDoc = Nothing
                    .IdTipoGasto = cboTipoGasto.Value
                    .IdCuentaCorriente = cboProveedores.Value
                End With

                If chkRetencion.Checked Then mt_ActualizarMontoPago()

                If OptPago.Checked Then Opcion = "PAG"
                If OptGanancia.Checked Then Opcion = "GAN"
                oeMovCajaBanco.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olAsiento.GuardarPago(leMovDocAgregado, oeMovCajaBanco, oeMedioPago, gUsuarioSGI.Id, MacPCLocal, oeCtaCble, Opcion) Then
                    If Opcion <> "GAN" Then
                        mensajeEmergente.Confirmacion("Pago(s) guardados satisfactoriamente", True)
                        Dim frm2 As New frm_ImprimeCobroPagoAnticipo(oeMovCajaBanco.Id, 0, "Documento")
                        frm2.ShowDialog()
                        frm2 = Nothing
                    End If
                End If
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            If gridPagoAgregado.Rows.Count > 0 Then
                If MessageBox.Show("Existen Pagos agregados, desea eliminarlos", "Mensaje del Sistema", _
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
               = Windows.Forms.DialogResult.Yes Then
                    leMovDocAgregado.Clear()
                    gridPagoAgregado.DataBind()
                Else
                    Exit Sub
                End If
            Else
                leMovDocAgregado.Clear()
            End If
            EtiImporteDolares.Text = "0"
            EtiImporteSoles.Text = "0"
            ValidarCombo(cboProveedores, "Proveedor")
            Me.Cursor = Cursors.WaitCursor
            oeMovimientoDocumento = New e_MovimientoDocumento
            oeMovimientoDocumento.IdPeriodo = ""
            oeMovimientoDocumento.Ejercicio = Date.Parse(Fecha.Value).Year
            oeMovimientoDocumento.IdClienteProveedor = cboProveedores.Value
            oeMovimientoDocumento.TipoOperacion = "PAG"
            LimpiaGrid(gridPago, UltraDataSource1)
            leMovDoc.Clear()
            leMovDoc.AddRange(olMovimientoDocumento.Listar(oeMovimientoDocumento))
            gridPago.DataBind()
            gridPago.DataSource = leMovDoc
            ' Verificar si tiene Retencion
            chkRetencion.Checked = False
            decRetencion.Value = 0
            decPagoNeto.Value = 0
            If olRetencion.Obtener(New e_DocumentoRetencion With {.TipoOperacion = "R", .IdAsientoMovimiento = cboProveedores.Value}).ImporteRetencion > 0 Then
                If MessageBox.Show("El Proveedor: " & cboProveedores.Text.Trim & " se ha retenido en operaciones anteriores." & Environment.NewLine & _
                                   "¿Desea Activar la Retencion para esta Operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    chkRetencion.Checked = True
                End If
            End If
            OcultarColumna(gridPago, True, "MontoCanje", "Retencion", "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa")
            OcultarColumna(gridPagoAgregado, True, "MontoCanje", "Retencion", "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa", "EstadoSunat")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            gridPago.Focus()
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

    Private Sub LlenaMoneda()
        Try
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla    
            gridPago.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridPago.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridPago, True)
            '--------------------- para llenar combo en grilla    
            gridPagoAgregado.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridPagoAgregado.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridPagoAgregado, True)
            '-------------------------------
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub llenacuenta()
        Try
            If Ejercicio <> Year(Fecha.Value) Then
                Ejercicio = Year(Fecha.Value)
                oeCtaCble = New e_CuentaContable
                oeCtaCble.Activo = True
                oeCtaCble.Movimiento = 1
                oeCtaCble.FlujoCaja = 1
                oeCtaCble.Ejercicio = Year(Fecha.Value)
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

    Private Sub LlenaTipoGasto()
        Try
            If cboTipoGasto.Items.Count = 0 Then
                Dim oeTipoGasto As New e_TipoGasto
                Dim olTipoGasto As New l_TipoGasto
                LlenarCombo(cboTipoGasto, "Nombre", olTipoGasto.Listar2(oeTipoGasto), -1)
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
            ' oeCliente.TipoOperacion = "PAG"
            '   LlenarCombo(cboCliente, "Nombre", olCliente.Listar(oeCliente), 0)
            leProveedor.AddRange(olProveedor.Listar(oeProveedor))
            '--------------------- para llenar combo en grilla gridventas   
            gridPago.DisplayLayout.ValueLists.Add("IdClienteProveedor")
            With gridPago.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                .Clear()
                For Each oeTD As e_Proveedor In leProveedor
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdClienteProveedor", "Nombre", gridPago, True)
            '--------------------------------------
            '--------------------- para llenar combo en grilla gridventas   
            gridPagoAgregado.DisplayLayout.ValueLists.Add("IdClienteProveedor")
            With gridPagoAgregado.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                .Clear()
                For Each oeTD As e_Proveedor In leProveedor
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdClienteProveedor", "Nombre", gridPagoAgregado, True)
            '--------------------------------------
            With cboProveedores
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
            oeTipoDoc.TipoOperacion = "C" 'proceso contabilidad
            leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
            '--------------------- para llenar combo en grilla    
            gridPago.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With gridPago.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", gridPago, True)
            '------------------------------------------
            '--------------------- para llenar combo en grilla    
            gridPagoAgregado.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With gridPagoAgregado.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", gridPagoAgregado, True)
            '------------------------------------------
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
            LlenaTipoGasto()
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
            ValidarCombo(cboTipoGasto, "Tipo de Gasto")
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            If Double.Parse(EtiImporteSoles.Text) < 0 Then Throw New Exception("El importe debe ser mayor a 0")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtVoucher.Text, "Ingrese el Voucher")
            If leMovDocAgregado.Count <= 0 Then Throw New Exception("No Existen Pagos para registrar")
            If olMovimientoDocumento.ValidarMonto(leMovDocAgregado, "Pagar") Then Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregarDetalle()
        Try
            Dim oe_DetProgPag As New e_DetalleProgramacionPago
            Dim ol_DetProgPag As New I_DetalleProgramacionPago
            If gridPago.Rows.Count > 0 AndAlso Not gridPago.ActiveRow.ListObject Is Nothing Then
                'Inicializo(objeto)
                oeMovimientoDocumento = New e_MovimientoDocumento
                '---capturo datos a ingresar-----
                oeMovimientoDocumento = gridPago.ActiveRow.ListObject
                oeMovimientoDocumento.TipoOperacion = "I"
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                oe_DetProgPag.IdMovimientoDocumento = oeMovimientoDocumento.Id
                oe_DetProgPag.IdEstado = "1CH00017"
                '-----------------------
                If ol_DetProgPag.Listar(oe_DetProgPag).Rows.Count > 0 Then
                    Throw New Exception("Este Documento ya ha sido generado en una Programación de Pagos.")
                Else

                    If ValidarAgregarDetalle(oeMovimientoDocumento) Then
                        With leMovDocAgregado
                            If Not .Contains(oeMovimientoDocumento) Then
                                ' si no esta en la lista o no esta contenido AGREGOOO
                                'oeMovAnalisis.SaldoSinIgv = oeMovAnalisis.Saldo / (1 + oeIGV.Porcentaje)
                                .Add(oeMovimientoDocumento.Clonar)
                                '.Item(.Count - 1).Monto = oeMovAnalisis.Saldo
                            Else
                                Throw New Exception("Ya existe este documento asociado")
                            End If
                        End With
                        mostrar_totales()
                        gridPagoAgregado.DataBind()
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mostrar_totales()
        Try
            Dim importeMN As Double = 0
            Dim importeME As Double = 0
            For Each oeMovimientoDocumento As e_MovimientoDocumento In leMovDocAgregado
                With oeMovimientoDocumento
                    If .IdMoneda = "1CH01" Then
                        importeMN = importeMN + .MontoOperar
                        importeME = importeME + .MontoOperar / DecTC.Value
                    Else
                        importeMN = importeMN + .MontoOperar * DecTC.Value
                        importeME = importeME + .MontoOperar
                    End If
                End With
            Next
            importeME = Math.Round(importeME, 4)
            importeMN = Math.Round(importeMN, 4)
            EtiImporteSoles.Text = importeMN.ToString
            EtiImporteDolares.Text = importeME.ToString
            mt_CalcularRetencion()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarDetalle()
        Try
            If gridPagoAgregado.Rows.Count <= 0 Then Throw New Exception("Seleccione una fila")
            ValidarGrilla(gridPagoAgregado, "Documentos x Rendir agregados")
            If Not gridPagoAgregado.ActiveRow.ListObject Is Nothing AndAlso gridPagoAgregado.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            'inicialializo mi objeto
            oeMovimientoDocumento = New e_MovimientoDocumento
            '---Obtengo O CAPTURO objeto de la grilla 
            oeMovimientoDocumento = gridPagoAgregado.ActiveRow.ListObject
            '----------------------
            With leMovDocAgregado
                '-----remuevo o elimino de mi lista de objetos
                .Remove(oeMovimientoDocumento)
                '-------------------
            End With
            mostrar_totales()
            gridPagoAgregado.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function ValidarAgregarDetalle(ByVal oeMovDoc As e_MovimientoDocumento) As Boolean
        Try
            If oeMovDoc.Saldo < 0 Then Throw New Exception("No se puede operar: es negativo")
            ValidarGrilla(gridPago, "Documentos x Pagar")
            If Not gridPago.ActiveRow Is Nothing AndAlso gridPago.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")

            If gridPagoAgregado.Rows.Count > 0 Then 'Verificar que solo pueda ingresar Pagos de un solo cliente
                If gridPagoAgregado.Rows.Item(0).Cells("IdClienteProveedor").Value <> oeMovimientoDocumento.IdClienteProveedor Then
                    Throw New Exception("Solo puede agregar Documentos de un Solo Proveedor")
                End If
            End If
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            If oeMovDoc.IdCuentaContable.Trim = "" Then
                Throw New Exception("!El Documento no tiene cuenta contable!" & Environment.NewLine & _
                                     "Sirvase a informar al Area de Contabilidad o Sistemas")
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Return False
        End Try
    End Function

    Private Sub inicializar()
        Try
            Me.Text = "Pagos"
            ControlBoton(1, 1, 1, 1, 0, 0, 0, 0, 1)
            'oePeriodo.Ejercicio = Date.Now.Year
            EjercicioBanderaCtaBancari = FechaServidor.Date.Year
            Fecha.Value = FechaServidor.Date
            gridPagoAgregado.DataSource = leMovDocAgregado
            gridPago.DataSource = leMovDoc
            _ComboPeriodo = True
            LlenarCombos()

            'cboCuentaContable.Enabled = False 'Se desactiva el Combo Cuenta Contable
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_CalcularRetencion()
        If chkRetencion.Checked Then
            If oeCtaCble.MonedaExtranjera = 1 Then
                decRetencion.Value = CDbl(EtiImporteDolares.Text) * ln_TasaRetencion
                decPagoNeto.Value = CDbl(EtiImporteDolares.Text) * (1 - ln_TasaRetencion)
            Else
                decRetencion.Value = CDbl(EtiImporteSoles.Text) * ln_TasaRetencion
                decPagoNeto.Value = CDbl(EtiImporteSoles.Text) * (1 - ln_TasaRetencion)
            End If
        Else
            decRetencion.Value = 0
        End If
    End Sub

    Private Sub mt_InicializarLogicas()
        olRetencion = New l_DocumentoRetencion
    End Sub

    Private Sub mt_ActualizarMontoPago()
        Try
            For Each oeDoc In leMovDocAgregado
                oeDoc.CodMotivo = "RET"
                oeDoc.IdLiquidacion = Math.Round(oeDoc.MontoOperar * ln_TasaRetencion, 4)
                oeDoc.MontoOperar = Math.Round(oeDoc.MontoOperar * (1 - ln_TasaRetencion), 4)
                oeDoc.OrdenCompra = IIf(oeCtaCble.MonedaExtranjera = 1, "1CH02", "1CH01")
                oeDoc.IdTipoBien = DecTC.Value
                oeDoc.Glosa = txtVoucher.Text.Trim
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Pagos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub frm_Pagos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Pagos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Pagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            FechaServidor = ObtenerFechaServidor()
            inicializar()
            ln_TasaRetencion = ObtenerRetencion()
            mt_InicializarLogicas()
            OcultarColumna(gridPago, True, "MontoCanje", "Retencion", "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa")
            OcultarColumna(gridPagoAgregado, True, "MontoCanje", "Retencion", "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa", "EstadoSunat")
            Validar_TipoCambio()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridVentas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridPago.DoubleClick
        Try
            AgregarDetalle()
            OcultarColumna(gridPagoAgregado, True, "MontoCanje", "Retencion", "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa", "EstadoSunat")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub DecTC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTC.ValueChanged
        Try
            mostrar_totales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Fecha_ValueChanged(sender As Object, e As EventArgs) Handles Fecha.ValueChanged
        DecTC.Value = TipoCambio(Fecha.Value, True)(0)
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
                leMovDocAgregado.Clear()
                gridPagoAgregado.DataBind()
                LimpiaGrid(gridPago, UltraDataSource1)
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
                    llenacuenta()
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
            If cboCuentaContable.Enabled Then
                LlenaCuentaBancaria()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridCobranzaAgregado_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridPagoAgregado.CellChange
        Try
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            Dim obj As New e_MovimientoDocumento
            obj = gridPagoAgregado.ActiveRow.ListObject
            If IsNumeric(e.Cell.Value) Then
                Dim total As Double = obj.MontoOperar
                gridPagoAgregado.UpdateData()
                If Math.Abs(obj.Saldo) < Math.Abs(CDbl(e.Cell.Value)) Then
                    If Math.Round(Math.Abs(CDbl(e.Cell.Value)) - Math.Abs(obj.Saldo), 2) > 0 Then
                        e.Cell.Value = total
                        gridPagoAgregado.UpdateData()
                        Throw New Exception("El monto ingresado es mayor al saldo")
                    End If
                End If
                gridPagoAgregado.UpdateData()
                mostrar_totales()
            Else
                e.Cell.Value = obj.MontoOperar
                gridPagoAgregado.UpdateData()
            End If
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
                    cboProveedores.Value = leProveedorList(0).Id
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

    Private Sub gridCobranzaAgregado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridPagoAgregado.KeyDown
        Try
            With gridPagoAgregado
                If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Down Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                ElseIf e.KeyValue = Keys.Up Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.AboveCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedores_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboProveedores.InitializeLayout
        Me.cboProveedores.ValueMember = "Id"
        Me.cboProveedores.DisplayMember = "Nombre"
        With cboProveedores.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
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
            .Columns("Nombre").Width = 400
            .Columns("NroDocumento").Width = 100
            .Columns("NroDocumento").Header.Caption = "RUC/DNI"
        End With
    End Sub

    Private Sub cboProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProveedores.KeyDown
        Try
            With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
                If e.KeyData = Keys.Delete Then
                    .Text = ""
                End If
            End With
            If e.KeyCode = Keys.Enter Then
                If cboProveedores.Text.Trim = "" Then
                    cboProveedores.DataSource = Nothing
                    cboProveedores.DataSource = leProveedor
                Else
                    cboProveedores.DataSource = Nothing
                    Dim leProveedorList As New List(Of e_Proveedor)
                    leProveedorList = leProveedor
                    cboProveedores.DataSource = leProveedorList.Where(Function(Item) Item.Nombre.Contains(cboProveedores.Text.Trim)).ToList
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProveedores.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboProveedores.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub chkRetencion_CheckedChanged(sender As Object, e As EventArgs) Handles chkRetencion.CheckedChanged
        Validar_TipoCambio()
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
