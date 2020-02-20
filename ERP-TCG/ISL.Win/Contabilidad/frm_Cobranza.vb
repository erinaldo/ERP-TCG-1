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

Public Class frm_Cobranza
    Inherits frm_MenuPadre

#Region "Métodos"

   Private Function GuardarCobros() As Boolean
        Try
            Dim indicadortipo As String = ""
            If validarcobranza() Then
                oeAsiento = New e_Asiento
                oeMovCajaBanco = New e_MovimientoCajaBanco
                oeMovCajaBanco._Operador = 1
                oeMovCajaBanco.Glosa = ""
                With oeMovCajaBanco
                    .IdFlujoCaja = cboFlujoGasto.Value
                    .NroBoucher = txtVoucher.Text
                    If oeCtaCble.Cuenta = "10111" Then
                        .IdCaja = oeCtaBancaria.Id
                    Else
                        .IdCuentaBancaria = oeCtaBancaria.Id
                    End If
                    .Fecha = Fecha.Value
                    .IdMedioPago = cboMedio.Value
                    .IdPeriodoConcilia = ""
                    .Activo = True
                    .TipoCambio = DecTC.Value
                    .TotalMN = Math.Round(Double.Parse(lblTotalesMN.Text), 2)
                    .TotalME = Math.Round(Double.Parse(lblTotalesME.Text), 2)
                    .TipoOperacion = "I"
                    .MovDoc = Nothing
                    .Glosa = txtGlosa.Text
                    .DifAGanancia = DecDifGanancia.Value
                    .IdCuentaCorriente = cboCliente.Value
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                End With
                
                If OptPerdida.Checked Then indicadortipo = "PER"
                If OptGanancia.Checked Then indicadortipo = "GAN"
                If OptCobro.Checked Then indicadortipo = "COB"

                If olAsiento.GuardarCobranza(leMovDocAgregado, oeMovCajaBanco, oeMedioPago, gUsuarioSGI.Id, MacPCLocal, oeCtaCble, indicadortipo) Then
                    If indicadortipo <> "PER" Then
                        mensajeEmergente.Confirmacion("Cobro(s) guardados satisfactoriamente", True)
                        Dim frm2 As New frm_ImprimeCobroPagoAnticipo(oeMovCajaBanco.Id, 1, "Documento")
                        frm2.ShowDialog()
                        frm2 = Nothing
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function validarcobranza() As Boolean
        Try

            ValidarCombo(cboMedio, "Medio de Pago")
            ValidarCombo(cboCuentaContable, "Cuenta Contable")
            ValidarCombo(cboFlujoGasto, "Flujo de Gasto")

            If cboCuentaBancaria.Enabled Then
                ValidarCombo(cboCuentaBancaria, "Cuenta Bancaria")
            End If

            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")

            If oeCtaCble.Cuenta <> "10111" Then
                l_FuncionesGenerales.ValidarCampoNoNulo(txtVoucher.Text, "Ingrese el Voucher")
            End If

            If Double.Parse(lblTotalesMN.Text) < 0 Then Throw New Exception("El importe debe ser mayor a 0")

            If leMovDocAgregado.Count <= 0 Then Throw New Exception("No Existen Cobros para registrar")

            If olMovimientoDocumento.ValidarMonto(leMovDocAgregado, "Cobrar") Then Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento

    Private oePeriodo As New e_Periodo
    Private oeFlujoCaja As New e_FlujoCaja
    Private olFlujoCaja As New l_FlujoCaja

    Private oeAsiento As New e_Asiento
    Private olAsiento As New l_Asiento

    Private oeCtaCble As New e_CuentaContable
    Private olCtaCble As New l_CuentaContable

    Private oeCtaBancaria As New e_CuentaBancaria
    Private olCtaBancaria As New l_CuentaBancaria
    Private leCuentaBancaria As New List(Of e_CuentaBancaria)

    Private oeMovCajaBanco As New e_MovimientoCajaBanco

    Private leMovDoc As New List(Of e_MovimientoDocumento)
    Private leMovDocAgregado As New List(Of e_MovimientoDocumento)

    Dim MontoCuota As Double

    Private _ComboPeriodo As Boolean = False
    Private _ComboFlujoCaja As Boolean = False

    Private Shared instancia As frm_Cobranza = Nothing
    Private Shared Operacion As String

    Private oeMedioPago As New e_MedioPago
    Private Ejercicio As Integer = 0
    Private EjercicioBanderaCtaBancari As Integer

    Private leCliente As New List(Of e_Cliente)

    Dim FechaServidor As Date = Now.Date

#End Region

#Region "Inicialización del formulario"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Cobranza()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If gridCobranza.Rows.Count > 0 Then
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
        oeMovimientoDocumento.Modificado = False
    End Sub

    Public Overrides Sub Editar()
        MyBase.Editar()
        oeMovimientoDocumento.Modificado = False
    End Sub

    Public Overrides Sub Guardar()
        Try
            If OptCobro.Checked Then
                If MessageBox.Show("Se cobrara un monto normal (COBRO), Desea continuar?", _
                Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Try
                End If
            End If
            If OptGanancia.Checked Then
                If MessageBox.Show("Se cobra con ganancia(GANANCIA), Desea Continuar?", _
                Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Try
                End If
            End If
            If OptPerdida.Checked Then
                If MessageBox.Show("Se cobra con perdida (PERDIDA), Desea Continuar?", _
                Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Try
                End If
            End If
            If GuardarCobros() Then
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
                        If Not GuardarCobros() Then
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
        Try
            Throw New Exception("No se permite esta acción en este formulario")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If gridCobranza.Rows.Count = 0 Then Throw New Exception("No hay ninguna Cobranza para exportar al Excel")
            Exportar_Excel(gridCobranza)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos del formulario"

    Private Sub limpiarcontroles()
        Try
            txtVoucher.Clear()
            EtiImporteDolares.Text = "0"
            EtiImporteSoles.Text = "0"
            DecDifGanancia.Value = 0
            lblTotalesME.Text = "0"
            lblTotalesMN.Text = "0"
            leMovDocAgregado.Clear()
            gridCobranzaAgregado.DataBind()
            LimpiaGrid(gridCobranza, UltraDataSource1)
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
            EtiImporteSoles.Text = Math.Round(importeMN, 2).ToString
            EtiImporteDolares.Text = Math.Round(importeME, 2).ToString

            If cboCuentaBancaria.Enabled = True Then
                If OptGanancia.Checked Then
                    If oeCtaBancaria.IdMoneda = "1CH01" Then
                        lblTotalesMN.Text = Math.Round(importeMN + DecDifGanancia.Value, 2).ToString
                        lblTotalesME.Text = Math.Round(importeME + IIf(DecDifGanancia.Value > 0, (DecDifGanancia.Value / DecTC.Value), 0.0), 2).ToString
                    ElseIf oeCtaBancaria.IdMoneda = "1CH02" Then
                        lblTotalesMN.Text = Math.Round(importeMN + DecDifGanancia.Value * DecTC.Value, 2).ToString
                        lblTotalesME.Text = Math.Round(importeME + DecDifGanancia.Value, 2).ToString
                    Else
                        lblTotalesMN.Text = EtiImporteSoles.Text
                        lblTotalesME.Text = EtiImporteDolares.Text
                    End If
                ElseIf OptPerdida.Checked Then
                    If oeCtaBancaria.IdMoneda = "1CH01" Then
                        lblTotalesMN.Text = Math.Round(importeMN - DecDifGanancia.Value, 2).ToString
                        lblTotalesME.Text = Math.Round(importeME - IIf(DecDifGanancia.Value > 0, (DecDifGanancia.Value / DecTC.Value), 0.0), 2).ToString
                    ElseIf oeCtaBancaria.IdMoneda = "1CH02" Then
                        lblTotalesMN.Text = Math.Round(importeMN - DecDifGanancia.Value * DecTC.Value, 2).ToString
                        lblTotalesME.Text = Math.Round(importeME - DecDifGanancia.Value, 2).ToString
                    Else
                        lblTotalesMN.Text = importeMN
                        lblTotalesME.Text = importeME
                    End If
                ElseIf OptCobro.Checked Then
                    lblTotalesMN.Text = importeMN
                    lblTotalesME.Text = importeME
                End If
            Else
                lblTotalesMN.Text = importeMN
                lblTotalesME.Text = importeME
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor

            ValidarCombo(cboCliente, "Cliente")
            Me.Cursor = Cursors.WaitCursor
            oeMovimientoDocumento = New e_MovimientoDocumento
            oeMovimientoDocumento.IdPeriodo = ""
            oeMovimientoDocumento.Ejercicio = Date.Parse(Fecha.Value).Year
            oeMovimientoDocumento.IdClienteProveedor = cboCliente.Value
            oeMovimientoDocumento.TipoOperacion = "COB"
            LimpiaGrid(gridCobranza, UltraDataSource1)
            leMovDoc.Clear()
            leMovDoc.AddRange(olMovimientoDocumento.Listar(oeMovimientoDocumento))
            gridCobranza.DataBind()
            gridCobranza.DataSource = leMovDoc.OrderBy(Function(i) i.FechaEmision).ToList
            gridCobranzaAgregado.DataBind()
            Configurar_Grilla(gridCobranza)
            Configurar_Grilla(gridCobranzaAgregado)
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            gridCobranza.Focus()
        End Try
    End Sub

    Private Sub LlenaFlujoCaja()
        Try
            Dim oeFlujoCaja As New e_FlujoCaja
            Dim olFlujoCaja As New l_FlujoCaja
            LlenarCombo(cboFlujoGasto, "Nombre", olFlujoCaja.Listar(oeFlujoCaja), -1)
            cboFlujoGasto.Text = "COBRANZA DE VENTA DE SERVICIOS"
            cboFlujoGasto.Enabled = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaCuentaBancaria()
        Try
            If leCuentaBancaria.Count = 0 Then
                oeCtaBancaria = New e_CuentaBancaria
                oeCtaBancaria.IdCuentaContable = oeCtaCble.Id 'Relacionada con Cuenta COntale
                oeCtaBancaria.Activo = True
                oeCtaBancaria.Ejercicio = Date.Parse(Fecha.Value).Year
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
                lista = lista.Where(Function(item) item.IdCuentaContable = oeCtaCble.Id).ToList()
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

    Private Sub LlenaMoneda()
        Try
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla    
            gridCobranza.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridCobranza.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridCobranza, True)
            '--------------------- para llenar combo en grilla    
            gridCobranzaAgregado.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridCobranzaAgregado.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridCobranzaAgregado, True)
            '-------------------------------
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Llenacuenta()
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
            If cboCuentaBancaria.SelectedIndex <> -1 Then
                oeCtaBancaria = cboCuentaBancaria.Items(cboCuentaBancaria.SelectedIndex).ListObject
                cboCuentaContable.Value = oeCtaBancaria.IdCuentaContable
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaCliente()
        Try
            Dim oeCliente As New e_Cliente
            Dim olCliente As New l_Cliente
            oeCliente.Activo = True

            leCliente.AddRange(olCliente.Listar(oeCliente))
            '--------------------- para llenar combo en grilla gridventas   
            gridCobranza.DisplayLayout.ValueLists.Add("IdClienteProveedor")
            With gridCobranza.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                .Clear()
                For Each oeTD As e_Cliente In leCliente
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdClienteProveedor", "Nombre", gridCobranza, True)
            '--------------------------------------
            '--------------------- para llenar combo en grilla gridventas   
            gridCobranzaAgregado.DisplayLayout.ValueLists.Add("IdClienteProveedor")
            With gridCobranzaAgregado.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                .Clear()
                For Each oeTD As e_Cliente In leCliente
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdClienteProveedor", "Nombre", gridCobranzaAgregado, True)
            '--------------------------------------
            With cboCliente
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leCliente
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
            gridCobranza.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With gridCobranza.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", gridCobranza, True)
            '------------------------------------------
            '--------------------- para llenar combo en grilla    
            gridCobranzaAgregado.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With gridCobranzaAgregado.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", gridCobranzaAgregado, True)
            '------------------------------------------
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombos()
        Try
            LlenaFlujoCaja()
            LlenaMoneda()
            LlenaCliente()
            llenaMedio()
            LlenaCuentaBancaria()
            llenacuenta()
            LlenaTipoDocumentoOperacion()
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
            cboMedio.Enabled = False 'Desativa el control 
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub AgregarDetalle()
        Try
            If gridCobranza.Rows.Count > 0 AndAlso Not gridCobranza.ActiveRow.ListObject Is Nothing Then
                oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento = gridCobranza.ActiveRow.ListObject
                oeMovimientoDocumento.TipoOperacion = "I"
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                '-----------------------
                If ValidarAgregarDetalle(oeMovimientoDocumento) Then
                    With leMovDocAgregado
                        If Not .Contains(oeMovimientoDocumento) Then
                            .Add(oeMovimientoDocumento.Clonar)
                        Else
                            Throw New Exception("Ya existe este documento asociado")
                        End If
                    End With
                    mostrar_totales()
                    gridCobranzaAgregado.DataBind()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarDetalle()
        Try
            If gridCobranzaAgregado.Rows.Count <= 0 Then Throw New Exception("Seleccione una fila")
            ValidarGrilla(gridCobranzaAgregado, "Documentos x Rendir agregados")
            If gridCobranzaAgregado.ActiveRow Is Nothing Then Throw New Exception("Seleccione una fila")
            If gridCobranzaAgregado.ActiveRow.ListObject Is Nothing Then Throw New Exception("Seleccione una fila")
            If gridCobranzaAgregado.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            'inicialializo mi objeto
            oeMovimientoDocumento = New e_MovimientoDocumento
            '---Obtengo O CAPTURO objeto de la grilla 
            oeMovimientoDocumento = gridCobranzaAgregado.ActiveRow.ListObject
            '----------------------
            With leMovDocAgregado
                '-----remuevo o elimino de mi lista de objetos
                .Remove(oeMovimientoDocumento)
                '-------------------
            End With
            mostrar_totales()
            gridCobranzaAgregado.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarAgregarDetalle(ByVal oeMovDoc As e_MovimientoDocumento) As Boolean
        Try
            If oeMovDoc.Saldo < 0 Then Throw New Exception("No se puede operar: es Negativo")
            ValidarGrilla(gridCobranza, "Documentos Cobranzas")
            If Not gridCobranza.ActiveRow Is Nothing AndAlso gridCobranza.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
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

    Private Sub Inicializar()
        Try
            uce_Decimales.SelectedIndex = 0
            Me.Text = "Cobranza"
            ControlBoton(1, 1, 1, 1, 0, 0, 0, 0, 1)
            Fecha.Value = FechaServidor.Date
            oePeriodo.Ejercicio = FechaServidor.Date.Year
            EjercicioBanderaCtaBancari = FechaServidor.Date.Year
            gridCobranzaAgregado.DataSource = leMovDocAgregado
            gridCobranza.DataSource = leMovDoc
            Configurar_Grilla(gridCobranza)
            Configurar_Grilla(gridCobranzaAgregado)
            _ComboPeriodo = True
            LlenarCombos()
            cboCuentaContable.Enabled = False 'Se desactiva el Combo Cuenta Contable
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Configurar_Grilla(grilla As UltraGrid)
        With grilla
            OcultarColumna(grilla, True, "Retencion_Saldo", "Retencion_Letra", "Retencion", "IndDetalleGlosa", "MontoCanje", "IdUsuarioCrea",
                      "IdTipoBien", "OrdenCompra", "FechaCreacion", "IndAnexo", "CodMotivo", "IndElectronico", "EstadoSunat")
            .DisplayLayout.Bands(0).Columns("Monto_Anticipo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .DisplayLayout.Bands(0).Columns("Monto_Anticipo").Format = "#,##0.00"
        End With
    End Sub

    Private Sub mt_llenarcajas()
        Dim leCaja As New List(Of e_Caja)
        Dim olCaja As New l_Caja
        'If IndMonedaExtrangera = 0 Then
        'leCtaBanc = leCtaBancaria.Where(Function(item) item.IdMoneda = "1CH01" And item.IdCuentaContable = lsCta).ToList
        leCaja = olCaja.Listar(New e_Caja With {.Tipooperacion = "", .Activo = True})
        'Else
        ' leCtaBanc = leCtaBancaria.Where(Function(item) item.IdMoneda <> "1CH01" And item.IdCuentaContable = lsCta).ToList
        'End If
        If leCaja.Count > 0 Then
            Me.cboCuentaBancaria.Enabled = True
            With cboCuentaBancaria
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leCaja
            End With
        Else
            cboCuentaBancaria.SelectedIndex = -1
            cboCuentaBancaria.Enabled = False
        End If
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub gridCobranzaAgregado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridCobranzaAgregado.KeyDown
        Try
            With gridCobranzaAgregado
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

    Private Sub DecDifGanancia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecDifGanancia.ValueChanged
        mostrar_totales()
    End Sub

    Private Sub OptGanancia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptGanancia.CheckedChanged
        Try
            If OptGanancia.Checked Then
                DecDifGanancia.Value = 0.0
                DecDifGanancia.Enabled = True
                If cboCuentaBancaria.Enabled = True Then
                    If cboCuentaBancaria.SelectedIndex = -1 Then
                        Throw New Exception("Especifique primero una Cuenta")
                    End If
                    mostrar_totales()
                End If
            Else
                DecDifGanancia.Value = 0.0
                DecDifGanancia.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub OptPerdida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptPerdida.CheckedChanged
        Try
            If OptPerdida.Checked Then
                DecDifGanancia.Value = 0.0
                DecDifGanancia.Enabled = False
                If cboCuentaBancaria.Enabled = True Then
                    If cboCuentaBancaria.SelectedIndex = -1 Then
                        Throw New Exception("Especifique primero una Cuenta")
                    End If
                    mostrar_totales()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub OptCobro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptCobro.CheckedChanged
        Try
            If OptGanancia.Checked Then
                DecDifGanancia.Value = 0.0
                DecDifGanancia.Enabled = False
                If cboCuentaBancaria.Enabled = True Then
                    If cboCuentaBancaria.SelectedIndex = -1 Then
                        Throw New Exception("Especifique primero una Cuenta")
                    End If
                    mostrar_totales()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub oeMovimientoDocumento_DatoCambiado() Handles oeMovimientoDocumento.DatoCambiado
        oeMovimientoDocumento.Modificado = True
    End Sub

    Private Sub frm_Cobranza_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub frm_Cobranza_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Cobranza_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Cobranza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me, gridCobranzaAgregado.Name, cboCliente.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            FechaServidor = ObtenerFechaServidor()
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridCobranza_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles gridCobranza.DoubleClickRow
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
            mensajeEmergente.Problema(ex.Message, True)
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
                leMovDocAgregado.Clear()
                gridCobranzaAgregado.DataBind()
                LimpiaGrid(gridCobranza, UltraDataSource1)
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
                If .SelectedIndex <> -1 Then
                    oeCtaBancaria = New e_CuentaBancaria
                    Dim i As Integer = .SelectedIndex
                    If oeCtaCble.Cuenta = "10111" Then
                        Dim oeCaja As New e_Caja
                        oeCaja = .Items(i).ListObject
                        oeCtaBancaria.Id = oeCaja.Id
                        oeCtaBancaria.IdMoneda = "1CH01"
                        mostrar_totales()
                    Else
                        oeCtaBancaria = .Items(i).ListObject
                        mostrar_totales()
                        If cboCuentaContable.Enabled = False Then Llenacuenta()
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbMedioPago_CheckedChanged(sender As Object, e As EventArgs) Handles cbMedioPago.CheckedChanged
        If Me.cbMedioPago.Checked = True Then
            cboMedio.Enabled = True
            cboCuentaContable.Enabled = True
            Llenacuenta()
        Else
            cboMedio.Enabled = False
            cboCuentaContable.Enabled = False
        End If
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
            'Me.cboCuentaBancaria.Enabled = True
            Me.cboCuentaBancaria.ReadOnly = False
            If cboCuentaContable.Enabled Then
                If oeCtaCble.Cuenta = "10111" Then
                    Dim _oeCajaUsuario As e_CajaUsuario
                    _oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
                    Me.lblCtaBancaria.Text = "Cajas:"
                    mt_llenarcajas()
                    If _oeCajaUsuario.IdCaja <> "" Then
                        Me.cboCuentaBancaria.Value = _oeCajaUsuario.IdCaja
                        Me.cboCuentaBancaria.ReadOnly = True
                    End If
                Else
                    LlenaCuentaBancaria()
                    Me.lblCtaBancaria.Text = "Cuentas Bancarias:"
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridCobranzaAgregado_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridCobranzaAgregado.CellChange
        'Verificar que el monto a operar no sea mayor al saldo ni sea 0
        Try
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            Dim obj As New e_MovimientoDocumento
            obj = gridCobranzaAgregado.ActiveRow.ListObject
            If IsNumeric(e.Cell.Value) Then
                Dim total As Double = obj.MontoOperar
                gridCobranzaAgregado.UpdateData()
                If Math.Abs(obj.Saldo) < Math.Abs(CDbl(e.Cell.Value)) Then
                    If Math.Round(Math.Abs(CDbl(e.Cell.Value)) - Math.Abs(obj.Saldo), 2) > 0 Then
                        e.Cell.Value = total
                        gridCobranzaAgregado.UpdateData()
                        Throw New Exception("El monto ingresado es mayor al saldo")
                    End If
                End If
                gridCobranzaAgregado.UpdateData()
                mostrar_totales()
            Else
                e.Cell.Value = obj.MontoOperar
                gridCobranzaAgregado.UpdateData()
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

    Private Sub txtRuc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuc.ValueChanged
        If Not txtRuc.Value Is Nothing Then
            If txtRuc.Value.ToString.Trim.Length > 7 Then
                Dim leClienteList As New List(Of e_Cliente)
                leClienteList = leCliente.ToList
                leClienteList = leCliente.Where(Function(item) item.Dni.Contains(txtRuc.Value)).ToList
                cboCliente.DataSource = leClienteList
                If leClienteList.Count > 0 Then
                    cboCliente.Value = leClienteList(0).Id
                End If
            End If
        End If
    End Sub

    Private Sub chkCalculadora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCalculadora.CheckedChanged
        If chkCalculadora.Checked Then
            gridCobranzaAgregado.DisplayLayout.Bands(0).Columns("MontoOperar").EditorComponent = Me.UltraCalculatorDropDown1
        Else
            gridCobranzaAgregado.DisplayLayout.Bands(0).Columns("MontoOperar").EditorComponent = Nothing
        End If
    End Sub

    Private Sub cboCliente_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboCliente.InitializeLayout
        Me.cboCliente.ValueMember = "Id"
        Me.cboCliente.DisplayMember = "Nombre"
        With cboCliente.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("TipoPersonaEmpresa").Hidden = True
            .Columns("IdPersona").Hidden = True
            .Columns("IdEmpresa").Hidden = True
            .Columns("Comisionista").Hidden = True
            .Columns("FechaActividad").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("oeEmpresa").Hidden = True
            .Columns("oepersona").Hidden = True
        End With
    End Sub

    Private Sub cboCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCliente.KeyDown
        Try
            With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
                If e.KeyData = Keys.Delete Then
                    .Text = ""
                End If
            End With
            If e.KeyCode = Keys.Enter Then
                If cboCliente.Text.Trim = "" Then
                    cboCliente.DataSource = Nothing
                    cboCliente.DataSource = leCliente
                Else
                    cboCliente.DataSource = Nothing
                    Dim leClienteList2 As New List(Of e_Cliente)
                    leClienteList2 = leCliente
                    cboCliente.DataSource = leClienteList2.Where(Function(Item) Item.Nombre.Contains(cboCliente.Text.Trim)).ToList
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboCliente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub MenuDocumentos_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuDocumentos.Opening
        Try
            MenuDocumentos.Items(0).Visible = False
            MenuDocumentos.Items(1).Visible = False
            MenuDocumentos.Items(2).Visible = False
            If gridCobranzaAgregado.Rows.Count > 0 Then
                MenuDocumentos.Items(1).Visible = True
                MenuDocumentos.Items(2).Visible = True
            End If
            If gridCobranzaAgregado.Selected.Rows.Count > 0 Then
                MenuDocumentos.Items(0).Visible = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
        Try
            QuitarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarNetoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarNetoToolStripMenuItem.Click
        Try
            ValidarGrilla(gridCobranzaAgregado, "Agregado")
            For Each obj As e_MovimientoDocumento In leMovDocAgregado
                obj.MontoOperar = obj.Neto
            Next
            mostrar_totales()
            gridCobranzaAgregado.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarDetracciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarDetracciónToolStripMenuItem.Click
        Try
            ValidarGrilla(gridCobranzaAgregado, "Agregado")
            For Each obj As e_MovimientoDocumento In leMovDocAgregado
                obj.MontoOperar = obj.SaldoDetraccion
            Next
            mostrar_totales()
            gridCobranzaAgregado.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub uce_Decimales_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles uce_Decimales.EditorButtonClick
        Try
            Dim ms_Decimales As String
            Dim ms_Mask As String
            If uce_Decimales.Text = 2 Then
                ms_Decimales = "#,##0.00"
                ms_Mask = "{double:9.2}"
            Else
                ms_Decimales = "#,##0.0000"
                ms_Mask = "{double:9.4}"
            End If
            gridCobranzaAgregado.DisplayLayout.Bands(0).Columns("MontoOperar").MaskInput = ms_Mask
            FormatoColumna(gridCobranzaAgregado, ms_Decimales, ColumnStyle.Double, Infragistics.Win.HAlign.Right, "MontoOperar")

            gridCobranzaAgregado.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class
