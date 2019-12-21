' Hola Maurixito

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frm_EstacionServicio
    Inherits frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#Region "Instancia"

    Private Shared instancia As frm_EstacionServicio = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_EstacionServicio()
        End If
        instancia.Activate()
        Return instancia
    End Function

    Private Sub frm_EstacionServicio_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        gmt_ControlBoton(0, 1, 0, 1, 0, 0, 0, 0, 1)
    End Sub

#End Region

#Region "Declaracion de Variables"

    Private TurnoActivo As New e_CierreTurno
    Private ListaVehiculo As New List(Of e_Vehiculo), dVehiculo As New l_Vehiculo
    Private MovimientoDocumento As New e_MovimientoDocumento, dMovimientoDocumento As New l_MovimientoDocumento, ListaMovimientoDocumento As New List(Of e_MovimientoDocumento)
    Private DetalleDocumento As New e_DetalleDocumento, ListaDetalleDocumento As New List(Of e_DetalleDocumento)
    Private CuentaCorriente As New e_CuentaCorriente, dCuentaCorriente As New l_CuentaCorriente
    Private Cliente As New e_Cliente, dCliente As New l_Cliente
    Private AsientoModelo As New e_AsientoModelo, dAsientoModelo As New l_AsientoModelo, ListaAsientoModelo As New List(Of e_AsientoModelo)
    Private ServicioCuentaContable As New e_ServicioCuentaContable, dServicioCuentaContable As New l_ServicioCuentaContable, ListaServicioCuentaContable As New List(Of e_ServicioCuentaContable)
    Private TipoPago As New e_TipoPago, dTipoPago As New l_TipoPago, ListaTipoPago As New List(Of e_TipoPago)

    Private ASIENTO As New e_Asiento, dASIENTO As New l_Asiento
    Private MOVIMIENTO As New e_MovimientoCajaBanco, dMCB As New l_MovimientoCajaBanco
    Private MEDIOPAGO As New e_MedioPago, dMEDIOPAGO As New l_MedioPago
    Private INVENTARIO As New e_Inventario
    Private TIPODOC As New e_TipoDocumento, dTIPODOC As New l_TipoDocumento
    Private oeMoneda As New e_Moneda
    Private olEstacionServicio As New l_EstacionServicio
    Private IdTipoDocumento As String, TipoDocumento As String
    Private IdTipoVenta As String, IdTipoPago As String 'Contado "1SI000000001", 
    Private sw_Lado As String
    Private IdMaterial_Combustible As String, Material_Combustible As String, Codigo_Combustible As String, IdAlmacen_Combustible As String, IdSubAlmacen_Combustible As String
    Private IdMoneda_Soles As String = "1CH01"
    Private CanDescuento As Double
    Private TipoCambio As Double = gfc_TipoCambio(ObtenerFechaServidor(), 1)
    Private FechaOrden As Date
    Private CodCuentaCorriente As String

    Private OrdenVenta As New e_OrdenVenta, dOrdenVenta As New l_OrdenVenta
    'Private dOVM As New l_OrdenVentaMaterial
    Private OM As New e_OrdenMaterial, dOM As New l_OrdenMaterial, LISTA_ORDEN_MATERIAL As New List(Of e_OrdenMaterial)
    'Private dMA As New l_MaterialAlmacen
    'Private dM As New l_Material, LISTA_MATERIAL As New List(Of e_Material)
    Private OS As New e_Orden, LISTA_OS As New List(Of e_Orden), dORDEN As New l_Orden

    'Private LISTA_INVENTARIO As New List(Of e_Inventario)
    'Private REGISTROINVENTARIO As e_RegistroInventario
    'Private CuentaCorriente As New e_CuentaCorriente, dCuentaCorriente As New l_CuentaCorriente, ListaCuentaCorriente As New List(Of e_CuentaCorriente)
    Private oeCtaBancaria As New e_CuentaBancaria, olCtaBancaria As New l_CuentaBancaria, leCuentaBancaria As New List(Of e_CuentaBancaria)
    Private oeCombo As New e_Combo, olCombo As New l_Combo
    Private loEmpresa As New List(Of e_Empresa)
    Private loEmpresaCliente As New List(Of e_Empresa)

    ''Carga mis Detalles Combos y Grillas
    Dim ds As Data.DataSet
    Dim ListLugar As List(Of e_Combo)
    ''Cargamos a los Vendedores
    Dim ListVendedores As List(Of e_Combo)

    Private oeVenta As New e_Venta
    Private olVenta As New l_Venta

    Private OrdenDocumento As New e_Orden_Documento, dOrdenDocumento As New l_Orden_Documento, ListaOrdenDocumento As New List(Of e_Orden_Documento)
    Private CuentaContable As New e_CuentaContable, dCuentaContable As New l_CuentaContable, ListaCuentaCotable As New List(Of e_CuentaContable)

    Private DTReferencia As Data.DataTable
    Private dtAux As Data.DataTable

    ' Private AMR As New e_AsientoModelo_Referencia, d_AMR As l_AsientoModelo_Referencia, l_AMR As List(Of e_AsientoModelo_Referencia)

    Private oeSaldoCtaCte As e_SaldoCtaCorriente, olSaldoCtaCte As New l_SaldoCtaCorriente, leSaldoCtaCte As New List(Of e_SaldoCtaCorriente)
    Private oeTDDato As e_TablaDinamica_Dato, olTDDato As l_TablaDinamica_Dato, leTipoMovCtaCte As List(Of e_TablaDinamica_Dato)
    'Private EstadoOrden As e_EstadoOrden, dEstadoOrden As l_EstadoOrden, ListaEstadoOrden As List(Of e_EstadoOrden)

    'Private mdblCantidadPrecio As Double = 0
    Private mdblIGV As Double = gfc_ParametroValor("IGV")
    'Private mstrIdCuentaContable As String = ""

    Private Const ls_NotaCredito As String = "NOTA DE CREDITO"
    Private ls_IdProv1 As String = "", ls_IdProv2 As String = "", ls_EstadoGenerado As String = ""
    Private ejecuta As Integer = 0

    Private EMPRESA As New e_Empresa, dEMPRESA As New l_Empresa
    'Private loEmpresa As List(Of e_Empresa)


    Private indFacturaBoleta As Integer = 0
    Private DNI As String = "1CIX00000000000225"
    Private Ruc As String = "1CIX00000000000229"

#End Region

#Region "Eventos"

    Private Sub frm_EstacionServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _Activo = True
            TurnoActivo = gfc_obtener_TurnoActivo()
            mt_Inicializar()
            Nuevo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PaintBotones(Grupo As String)
        Select Case Grupo
            Case "TipoDocumento"
                btnDocumento.Appearance.BackColor = Color.White
                btnBoleta.Appearance.BackColor = Color.White
                btnNotaDespacho.Appearance.BackColor = Color.White
            Case "TipoPago"
                btnContado.Appearance.BackColor = Color.White
                btnCredito.Appearance.BackColor = Color.White
            Case "Lado"
                btnLado1.Appearance.BackColor = Color.White
                btnLado2.Appearance.BackColor = Color.White
                btnLado3.Appearance.BackColor = Color.White
                btnLado4.Appearance.BackColor = Color.White
                btnLado5.Appearance.BackColor = Color.White
                btnLado6.Appearance.BackColor = Color.White
            Case "Combustible"
                btnDB5.Appearance.ForeColor = Color.Black
                btnG84.Appearance.ForeColor = Color.Black
                btnG90.Appearance.ForeColor = Color.Black
                btnG95.Appearance.ForeColor = Color.Black
            Case "Clean"
                btnDocumento.Appearance.BackColor = Color.White
                btnBoleta.Appearance.BackColor = Color.White
                btnNotaDespacho.Appearance.BackColor = Color.White
                btnContado.Appearance.BackColor = Color.White
                btnCredito.Appearance.BackColor = Color.White
                btnLado1.Appearance.ForeColor = Color.Black
                btnLado2.Appearance.ForeColor = Color.Black
                btnLado3.Appearance.ForeColor = Color.Black
                btnLado4.Appearance.ForeColor = Color.Black
                btnLado5.Appearance.ForeColor = Color.Black
                btnLado6.Appearance.ForeColor = Color.Black
                btnDB5.Appearance.ForeColor = Color.Black
                btnG84.Appearance.ForeColor = Color.Black
                btnG90.Appearance.ForeColor = Color.Black
                btnG95.Appearance.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub ValidarSurtidor()
        Select Case sw_Lado
            Case "1" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
            Case "2" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
            Case "3" : btnDB5.Enabled = True : btnG84.Enabled = False : btnG90.Enabled = False : btnG95.Enabled = False
            Case "4" : btnDB5.Enabled = True : btnG84.Enabled = False : btnG90.Enabled = False : btnG95.Enabled = False
            Case "5" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
            Case "6" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
        End Select
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            'mt_Listar()
            Operacion = "Inicializa"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            'gmt_MostrarTabs(1, ficOrdenComercial, 1)
            mt_Inicializar()
            Operacion = "Nuevo"
            gmt_ControlBoton(0, 0, 0, 1, 0, 0, 0, 0, 1)
            'mt_ControlColumnas()
            'gbeMateriales.Expanded = True
            cbgCliente.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Editar()
        'Try
        '    If griOrdenComercial.Selected.Rows.Count > 0 Then
        '        mt_Inicializar()
        '        mt_Mostrar()
        '        gmt_MostrarTabs(1, ficOrdenComercial, 1)
        '        Operacion = "Editar"
        '        mt_ControlBotoneria()
        '        mt_ControlColumnas()
        '        gbeMateriales.Expanded = False
        '        Me.lblOperacion.Text = ""
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        'End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Not fc_Cargar_OrdenVenta() Then Throw New Exception
            If Not fc_Guardar_OrdenVenta() Then Throw New Exception
            If Not fc_EmitirDocumento() Then Throw New Exception
            If Not fc_Guardar_Cobros() Then Throw New Exception
            Consultar(True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            'Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            '    Case Windows.Forms.DialogResult.Yes
            '        Guardar()
            '    Case Windows.Forms.DialogResult.No
            'gmt_MostrarTabs(0, ficOrdenComercial, 2)
            Consultar(True)
            'End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        '    Try
        '        'Throw New Exception("No es posible eliminar Ordenes de Venta, solo se permite anular")
        '        With griOrdenComercial
        '            oeOrdenComercial = New e_OrdenVenta
        '            If .Selected.Rows.Count > 0 Then
        '                oeOrdenComercial.Id = .ActiveRow.Cells("Id").Value
        '                oeOrdenComercial = olOrdenComercial.Obtener(oeOrdenComercial)
        '                If oeOrdenComercial.IdEstado = "1CIX043" Then
        '                    If MessageBox.Show("Esta seguro de eliminar la Orden: " &
        '                             .ActiveRow.Cells("OrdenComercial").Value.ToString & " ?",
        '                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
        '                        oeOrdenComercial.TipoOperacion = "N"
        '                        oeOrdenComercial.UsuarioCrea = gUsuarioSGI.Id
        '                        olOrdenComercial.EliminarExtornar(oeOrdenComercial)
        '                        MsgBox("La Informacion ha Sido Eliminada Correctamente", MsgBoxStyle.Information, Me.Text)
        '                        Consultar(True)
        '                    End If
        '                Else
        '                    Throw New Exception("Solo Puede Eliminar Ordenes Terminadas")
        '                End If
        '            End If
        '        End With
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        '    End Try
    End Sub

    Public Overrides Sub Exportar()
        'Try
        '    If griOrdenComercial.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
        '    Exportar_Excel(griOrdenComercial, Me.Text)
        '    MyBase.Exportar()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        'End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

    Private Function fc_Guardar_OrdenVenta() As Boolean
        Try

            'mt_ObtenerSaldoCtaCte()
            'If txtCodSaldoCtaCte.Tag.ToString.Trim = "" Then Throw New Exception("¡Ingrese Cuenta Corriente!")
            OrdenVenta = dOrdenVenta.Guardar_VentaRapida(OrdenVenta)
            'If IdTipoDocumento <> "" Then
            '    If MovimientoDocumento.Id.Trim <> "" Then
            '        mt_Emitir_Documento(False)
            '        MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
            '        MovimientoDocumento = dMovimientoDocumento.Obtener(New e_MovimientoDocumento With {.TipoOperacion = "", .Id = OV.oeDocumento.Id})

            '    End If
            'End If
            'MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
            'fc_Imprimir_Documento()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function fc_Cargar_OrdenVenta() As Boolean
        Try
            With OrdenVenta
                .PrefijoID = gs_PrefijoIdSucursal
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .UsuarioCrea = gUsuarioSGI.Login
                .Tipo = 2
                .TipoExistencia = 1
                .TipoCambio = TipoCambio
                .IndFactSer = True 'Revisar
                .IdVendedorTrabajador = "" ' Trabajador
                If cbgCliente.SelectedRow Is Nothing Then Throw New Exception("Seleccione Cliente")
                .IdEmpresa = cbgCliente.Value
                'Select Case Operacion
                '    Case "Nuevo"
                '        .TipoOperacion = "I"
                '        .IdEstado = "1CH000000011" 'Evaluado
                '        If cbDocumento.Checked = True Then : .IndFacturadoProducto = True : End If
                '        .IdTrabajadorAprobacion = gUsuarioSGI.oePersona.Id
                '    Case "Editar"
                '        .TipoOperacion = "A"
                '        If cbDocumento.Checked = True Then : .IndFacturadoProducto = True : End If
                '        fc_ValidarNumeroDoc()
                '        If MOVIMIENTODOCUMENTO.Id = "" Then
                '            If Not fc_EmitirDocumento() Then
                '                Return False
                '            End If
                '        End If
                '    Case "Atender"
                '        If OV.lstOrdenComercialMaterial.Sum(Function(i) i.CantidadAtender) = 0 Then Throw New Exception("Cantidad a Atender no Puede ser 0.")
                .TipoOperacion = "I"
                .oeOrdenSalida = New e_Orden
                .oeOrdenSalida = fc_Cargar_OrdenSalida()
                .oeOrdenSalida.IdOrdenDocumento = fc_OrdenDocumento().Id
                For Each oe As e_OrdenVentaMaterial In OrdenVenta.lstOrdenComercialMaterial
                    If oe.CantidadPendiente - oe.CantidadAtender >= 0 Then
                        oe.CantidadPendiente = oe.CantidadPendiente - oe.CantidadAtender
                        oe.CantidadAtender = 0
                    End If
                Next
                If OrdenVenta.lstOrdenComercialMaterial.Sum(Function(i) i.CantidadPendiente) = 0 Then
                    .IdEstado = "1CIX004"
                Else
                    .IdEstado = "1CIX005"
                End If
                'End Select
                '.lstOrdenComercialMaterial = New List(Of e_OrdenVentaMaterial)
                '.lstOrdenComercialMaterial.AddRange(LISTA_ORDENVENTA_MATERIAL)
                .Fecha = ObtenerFechaServidor()
                .IdMoneda = IdMoneda_Soles
                .IdTipoPago = IdTipoPago
                .Glosa = txtGlosa.Value
                .Total = decTotal.Value
                .SubTotal = decSubTotal.Value
                .Impuesto = decImpuesto.Value
                .TipoCompra = 0
                .IdTipoVenta = IdTipoVenta
                .IdPlaca = cmbVehiculo.Value
                .IdPiloto = cmbPiloto.Value
                .Kilometraje = decKilometraje.Value
            End With

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Metodos"

    Private Sub mt_Inicializar()
        loEmpresa = New List(Of e_Empresa)
        cbgCliente.DataSource = loEmpresa
        cbgCliente.Text = String.Empty

        '' Limpiar Controles
        txtDireccionFiscal.Text = ""
        decCantidad.Value = 0
        decPrecio.Value = 0
        decDescuento.Value = 0
        decPrecioTotal.Value = 0
        decSubTotal.Value = 0
        decImpuesto.Value = 0
        decTotal.Value = 0

        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        txtGlosa.Text = String.Empty
        grb_Documento.Visible = False
        grbCombustible.Enabled = False
        'mstrIdCuentaContable = ""

        '' Valores Default
        FechaOrden = ObtenerFechaServidor()
        TipoCambio = gfc_TipoCambio(FechaOrden, True)
        PaintBotones("Clean")
        udg_Detalle.DataSource = New List(Of e_OrdenVentaMaterial)
        gmt_OcultarColumna(udg_Detalle, True, "IndOperacion", "IdOrigen", "IdDestino")

        '' Cargar Listas y Combos
        ListaAsientoModelo = dAsientoModelo.Listar(New e_AsientoModelo With {.TipoOperacion = "A", .Activo = True, .Nombre = "1PY000000005"})
        leCuentaBancaria.AddRange(olCtaBancaria.Listar(New e_CuentaBancaria With {.IdCuentaContable = CuentaContable.Id, .Activo = True, .Ejercicio = Date.Parse(OrdenVenta.Fecha).Year, .TipoOperacion = "C"}))
        ListaServicioCuentaContable = dServicioCuentaContable.Listar(New e_ServicioCuentaContable With {.TipoOperacion = "V", .Activo = True, .Ejercicio = Date.Now.Year})

        If cbgCliente.Value = gs_IdEmpresaSistema Then
            ListaVehiculo.AddRange(dVehiculo.Listar(New e_Vehiculo With {.Motriz = 1, .IndPropiedad = 1, .Activo = True, .TipoOperacion = "M"}))
        End If
        If cbgCliente.Value <> gs_IdEmpresaSistema Then
            ListaVehiculo.AddRange(dVehiculo.Listar(New e_Vehiculo With {.Motriz = 1, .IndPropiedad = 0, .IdEmpresaPropietaria = .Activo = True, .TipoOperacion = "M"}))
        End If
        LlenarCombo(cmbVehiculo, "Nombre", ListaVehiculo, -1)
        LlenarCombo(cmbPiloto, "Nombre", PilotoPublic, -1)
    End Sub

    Private Sub mt_AgregarDetalle()
        Try

            Dim OV_DETALLE As New e_OrdenVentaMaterial
            With OV_DETALLE

                .TipoOperacion = "I"
                .PrefijoID = gs_PrefijoIdSucursal
                .IndImpuesto = True
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .UsuarioCrea = gUsuarioSGI.Id
                .IdMaterial = IdMaterial_Combustible
                .Material = Material_Combustible
                .Codigo = Codigo_Combustible
                .Cantidad = decCantidad.Value
                .CantidadPendiente = decCantidad.Value
                .CostoUnitario = decPrecio.Value
                .CostoInventario = 0 'DETALLE.CostoUnitario
                .PrecioUnitario = decPrecio.Value
                .Dscto = decDescuento.Value
                '.IdTipoUnidadMedida = DETALLE.idu
                .IdAlmacen = IdAlmacen_Combustible
                .IdUnidadMedida = "1CH000000001"
                .IdSubAlmacen = IdSubAlmacen_Combustible
                .PrecioTotal = Math.Round(.PrecioUnitario * .Cantidad, 4) - .Dscto
                .Glosa = "LADO_" & sw_Lado
                '.IndOperacion = IIf(chkTransporte.Checked, 1, 0)
                '.IdOrigen = cboOrigenViaje.Value
                '.IdDestino = cboDestinoViaje.Value
            End With
            If OrdenVenta.lstOrdenComercialMaterial.Where(Function(i) i.IdMaterial = OV_DETALLE.IdMaterial And i.TipoOperacion <> "E").ToList.Count > 0 Then
                udg_Detalle.DataBind()
                mt_CalcularTotalOrden()
                'mt_CombosGrilla(griOrdenComercialMaterial)
                'griAlmacenMaterial.DataBind()
                Throw New Exception("Material: " & OV_DETALLE.Material & " ya Asignado a la Orden")
            End If
            OrdenVenta.lstOrdenComercialMaterial.Add(OV_DETALLE)
            udg_Detalle.DataSource = OrdenVenta.lstOrdenComercialMaterial
            udg_Detalle.DataBind()
            mt_CalcularTotalOrden()
            'mt_CombosGrilla(griOrdenComercialMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnCalibracion_Click(sender As Object, e As EventArgs) Handles btnCalibracion.Click
        IdTipoPago = "" : IdTipoVenta = "CALIBRACION"
        PaintBotones("TipoPago") : btnCalibracion.Appearance.BackColor = Color.Blue
        btnDocumento.Enabled = False : btnBoleta.Enabled = False : btnNotaDespacho.Enabled = True
        Calcular_DescuentoCombustible()
    End Sub

    Private Sub decKilometraje_ValueChanged(sender As Object, e As EventArgs) Handles decKilometraje.ValueChanged

    End Sub

    Private Sub mt_CalcularTotalOrden()
        Try
            Dim SubTotal As Double = 0, DescuentoTotal As Double = 0, Total As Double = 0
            For Each Item In OrdenVenta.lstOrdenComercialMaterial
                SubTotal += Item.PrecioTotal
                DescuentoTotal += Item.Dscto
                Total += SubTotal
            Next
            decSubTotal.Value = SubTotal
            decDescuentoTotal.Value = DescuentoTotal
            decTotal.Value = Total
            decImpuesto.Value = Total * mdblIGV
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub decDescuento_ValueChanged(sender As Object, e As EventArgs) Handles decDescuento.ValueChanged
        decPrecioTotal.Value = decPrecio.Value * decCantidad.Value - decDescuento.Value
    End Sub

    Private Sub decCantidad_ValueChanged(sender As Object, e As EventArgs) Handles decCantidad.ValueChanged
        decDescuento.Value = CanDescuento * decCantidad.Value
        decPrecioTotal.Value = decPrecio.Value * decCantidad.Value - decDescuento.Value
    End Sub

    Private Sub Calcular_DescuentoCombustible()
        Dim ListaDescuentos As New List(Of e_EmpresaDescuento), dEmpresaDescuento As New l_EmpresaDescuento
        If IdMaterial_Combustible = "" Then Exit Sub
        If cbgCliente.Value = "" Then Exit Sub

        ListaDescuentos = dEmpresaDescuento.Listar(New e_EmpresaDescuento With {.IdEmpresa = cbgCliente.Value, .IdProducto = IdMaterial_Combustible})
        If ListaDescuentos.Count > 0 Then
            For Each Item In ListaDescuentos
                CanDescuento = IIf(IdTipoPago = "", Item.DescuentoCredito, Item.DescuentoContado)
            Next
        Else
            CanDescuento = 0
        End If
        decDescuento.Value = CanDescuento
        If decCantidad.Value <> 0 Then
            decDescuento.Value = decCantidad.Value * CanDescuento
        End If
        decCantidad.SelectAll()
    End Sub

    Private Sub mt_Cargar_MovimientoDocumento()
        Try
            MovimientoDocumento = New e_MovimientoDocumento
            With MovimientoDocumento
                .TipoOperacion = "I"
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .PrefijoID = gs_PrefijoIdSucursal
                .IdClienteProveedor = OrdenVenta.IdEmpresa
                .IdTipoDocumento = IdTipoDocumento
                .IdEstadoDocumento = "1CIX025"
                .IdPeriodo = ""
                '.CuentaContable = ""
                .IdMoneda = IdMoneda_Soles
                .Tipo = 2
                .IdTipoBien = 1
                If txtSerie.Text <> "" Then .Serie = FormatoDocumento(txtSerie.Text, 4)
                If txtNumero.Text <> "" Then .Numero = FormatoDocumento(txtNumero.Text, 8)
                .FechaEmision = dtpFechaDoc.Value
                .FechaVencimiento = dtpFechaDoc.Value
                .NoGravado = 0
                .IndCompraVenta = 2
                .SubTotal = Math.Round(decSubTotal.Value, 2)
                .IGV = Math.Round(decImpuesto.Value, 2)
                .Total = Math.Round(decTotal.Value, 2)
                .Saldo = .Total
                .TipoCambio = TipoCambio
                .IdUsuarioCrea = gUsuarioSGI.Id
                .Mac_PC_Local = MacPCLocal()

                '' Cargar Detalle de Documento
                .lstDetalleDocumento = New List(Of e_DetalleDocumento)
                For Each oe As e_OrdenVentaMaterial In OrdenVenta.lstOrdenComercialMaterial
                    DetalleDocumento = New e_DetalleDocumento
                    DetalleDocumento.TipoOperacion = "I"
                    DetalleDocumento.IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                    DetalleDocumento.IdSucursal = gs_PrefijoIdSucursal
                    DetalleDocumento.PrefijoID = gs_PrefijoIdSucursal
                    DetalleDocumento.IdMaterialServicio = oe.IdMaterial
                    DetalleDocumento.IdTipoUnidadMedida = oe.IdTipoUnidadMedida
                    DetalleDocumento.IdUnidadMedida = oe.IdUnidadMedida
                    DetalleDocumento.CodigoMaterialServicio = oe.Codigo
                    DetalleDocumento.Cantidad = oe.Cantidad
                    DetalleDocumento.IndGravado = oe.IndImpuesto
                    DetalleDocumento.IndServicioMaterial = "M"
                    DetalleDocumento.Precio = oe.PrecioUnitario
                    DetalleDocumento.Total = oe.PrecioTotal
                    DetalleDocumento.PrecioUnitarioSinImp = Math.Round(IIf(oe.IndImpuesto, (oe.PrecioUnitario - oe.Dscto) / (1 + mdblIGV), oe.PrecioUnitario - oe.Dscto), 4, MidpointRounding.AwayFromZero)
                    DetalleDocumento.UsuarioCreacion = gUsuarioSGI.Id
                    .lstDetalleDocumento.Add(DetalleDocumento)
                Next
                '.lstOrdenDocumento = New List(Of e_Orden_Documento)
                '.lstOrdenDocumento = fc_OrdDocumento()

                '' Cargar Venta
                .Venta = New e_Venta
                .Venta.IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .Venta.IdSucursal = gs_PrefijoIdSucursal
                .Venta.PrefijoID = gs_PrefijoIdSucursal
                .Venta.Gravado = Math.Round(decSubTotal.Value, 2)
                .Venta.IGV = Math.Round(decImpuesto.Value, 2)
                .Venta.IdTipoPago = IdTipoPago
                .Venta.Glosa = txtGlosa.Text
                .Venta.IdTipoVenta = "1CH000036"
                .Venta.IndCliente = 2
                .Venta.TipoOperacion = "I"
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_Guardar_Cobros() As Boolean
        Try


            '' Cargar Medio de Pago
            MEDIOPAGO = dMEDIOPAGO.Obtener(New e_MedioPago With {.Id = "1CH03"})

            Dim indicadortipo As String = ""
            MOVIMIENTO = New e_MovimientoCajaBanco
            With MOVIMIENTO
                ._Operador = 1
                .Glosa = ""
                .IdFlujoCaja = "1CH000000085" '1CH000000002 Venta de bienes
                .NroBoucher = ""
                .IdCuentaBancaria = oeCtaBancaria.Id
                .Fecha = ObtenerFechaServidor()
                .IdMedioPago = "1CH03" 'Efectivo
                .IdPeriodoConcilia = ""
                .Activo = True
                .TipoCambio = OrdenVenta.TipoCambio
                .TotalMN = OrdenVenta.Total
                .TotalME = OrdenVenta.Total / OrdenVenta.TipoCambio
                .TipoOperacion = "I"
                .MovDoc = Nothing
                .Glosa = txtGlosa.Text
                .DifAGanancia = 0
                .IdCuentaCorriente = cbgCliente.Value
                .UsuarioCreacion = gUsuarioSGI.Id
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With

            'If OptPerdida.Checked Then indicadortipo = "PER"
            'If OptGanancia.Checked Then indicadortipo = "GAN"
            'If OptCobro.Checked Then indicadortipo = "COB"
            ListaMovimientoDocumento.Add(MovimientoDocumento)
            If dASIENTO.GuardarCobranza(ListaMovimientoDocumento, MOVIMIENTO, MEDIOPAGO, gUsuarioSGI.Id, MacPCLocal, CuentaContable, indicadortipo) Then
                If indicadortipo <> "PER" Then
                    mensajeEmergente.Confirmacion("Cobro(s) guardados satisfactoriamente", True)
                    Dim frm2 As New frm_ImprimeCobroPagoAnticipo(MOVIMIENTO.Id, 1, "Documento")
                    frm2.ShowDialog()
                    frm2 = Nothing
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_Emitir_Documento(IndMensaje As Boolean)
        Try

            Dim _banEmis As Boolean = False
            Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "VTA")

            Cliente = dCliente.Obtener(New e_Cliente With {.TipoOperacion = "", .TipoClienteProveedor = 1, .Id = OrdenVenta.IdEmpresa})
            TIPODOC = dTIPODOC.Obtener(New e_TipoDocumento With {.TipoOperacion = "", .Id = IdTipoDocumento})
            oeMoneda.Id = IdMoneda_Soles 'Revisar

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                ListaCuentaCotable = dCuentaContable.Listar(New e_CuentaContable With {.Ejercicio = frm.Año1.Año, .TipoOperacion = "N", .Movimiento = 1})
                MovimientoDocumento = dMovimientoDocumento.Obtener(New e_MovimientoDocumento With {.Id = Me.MovimientoDocumento.Id, .CargaCompleta = True})
                MovimientoDocumento.IdPeriodo = frm.cboMes.Value : MovimientoDocumento.Ejercicio = frm.Año1.Año
                MovimientoDocumento.Venta.TipoDoc = TIPODOC : MovimientoDocumento.Venta.Cliente = Cliente : MovimientoDocumento.Venta.Moneda = oeMoneda

                AsientoModelo.Equivale = 1 : AsientoModelo.IdMoneda = oeMoneda.Id

                If ListaAsientoModelo.Contains(AsientoModelo) Then
                    AsientoModelo = ListaAsientoModelo.Item(ListaAsientoModelo.IndexOf(AsientoModelo))
                    AsientoModelo.TipoOperacion = ""
                    AsientoModelo.Ejercicio = MovimientoDocumento.FechaEmision.Year
                    AsientoModelo = dAsientoModelo.Obtener(AsientoModelo)
                    'For Each _oeDet In ASIENTOMODELO.leDetalle
                    '    oeCtaCtble = New e_CuentaContable
                    '    oeCtaCtble.Cuenta = "12121" : oeCtaCtble.Equivale = 0
                    '    If loCtaCtble.Contains(oeCtaCtble) Then
                    '        oeCtaCtble = loCtaCtble.Item(loCtaCtble.IndexOf(oeCtaCtble))
                    '        _oeDet.IdCuentaContable = oeCtaCtble.Id
                    '    End If
                    'Next

                    CuentaCorriente = dCuentaCorriente.Obtener(New e_CuentaCorriente With {.Tipo = 3, .IdTrabajador = Me.MovimientoDocumento.IdClienteProveedor})
                    MovimientoDocumento.IdUsuarioCrea = gUsuarioSGI.Id

                    ServicioCuentaContable.IdServicio = gVSMercaderia : ServicioCuentaContable.Equivale = 1
                    If ListaServicioCuentaContable.Contains(ServicioCuentaContable) Then
                        ServicioCuentaContable = ListaServicioCuentaContable.Item(ListaServicioCuentaContable.IndexOf(ServicioCuentaContable))
                    Else
                        Throw New Exception("No Existen Cuenta Contable para el Servicio: " & gVSMercaderia & " para el Año: " & Date.Now.Year &
                                        Environment.NewLine & "Solicite el Apoyo del Area Contable.")
                    End If

                    MovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If CuentaCorriente.Id <> "" Then
                        _banEmis = dMovimientoDocumento.GuardarVentaAsiento(MovimientoDocumento, AsientoModelo, ServicioCuentaContable, False, String.Empty)
                    Else
                        With CuentaCorriente
                            .Tipooperacion = "I" : .Tipo = 3 : .IdTrabajador = Me.MovimientoDocumento.IdClienteProveedor
                            .Saldo = 0 : .TotalCargo = 0 : .TotalAbono = 0 : .Ejercicio = frm.Año1.Año : .Usuario = gUsuarioSGI.Id
                            .IdEstado = "HABILITADA" : .IdMoneda = "1CH01" : .Glosa = "CUENTA DE EMPRESA"
                        End With
                        CuentaCorriente.PrefijoID = gs_PrefijoIdSucursal '@0001
                        dCuentaCorriente.Guardar(CuentaCorriente)
                        _banEmis = dMovimientoDocumento.GuardarVentaAsiento(Me.MovimientoDocumento, AsientoModelo, ServicioCuentaContable, False, String.Empty)
                    End If

                    ' Actualizar Cuenta para Empresas Relacionada
                    'Dim _oeEmpr As New e_Cliente
                    '_oeEmpr.Equivale = 1
                    '_oeEmpr.Id = oeDoc.IdClienteProveedor.Trim
                    'If leCliente.Contains(_oeEmpr) Then
                    '    _oeEmpr = leCliente.Item(leCliente.IndexOf(_oeEmpr))
                    '    If _oeEmpr.IndRelacionada = 1 Then
                    '        For Each _oeDet In oeAsientoModelo.leDetalle
                    '            If Microsoft.VisualBasic.Left(_oeDet.Cuenta.Trim, 2) = "12" Then
                    '                Dim strCuenta As String = Replace(_oeDet.Cuenta, "2", "3", 1, 1)
                    '                Dim strNuevaCuenta As String = Microsoft.VisualBasic.Left(strCuenta, 3) & "33" & Microsoft.VisualBasic.Right(strCuenta, 1)
                    '                _oeDet.Cuenta = strNuevaCuenta
                    '                oeCtaContable = New e_CuentaContable
                    '                oeCtaContable.Cuenta = strNuevaCuenta : oeCtaContable.Equivale = 0
                    '                If leCtaContable.Contains(oeCtaContable) Then
                    '                    oeCtaContable = leCtaContable.Item(leCtaContable.IndexOf(oeCtaContable))
                    '                    _oeDet.IdCuentaContable = oeCtaContable.Id
                    '                End If
                    '            End If
                    '        Next
                    '    End If
                    'End If
                Else
                    Throw New Exception("No Existe Configuracion Contable")
                End If
            End If
            If _banEmis = True Then mensajeEmergente.Confirmacion("El Documento Nº " & txtSerie.Text & " - " & txtNumero.Text & " ha sido Emitido", True)
            '    Ejercicio = frm.cmbEjercicio.Text
            '    mt_ListarCtaCtble(Ejercicio)
            '    Dim oeDoc As New e_MovimientoDocumento
            '    If frm.cmbPeriodo.Value <> gfc_ObtenerPeriodo(dtpFechaDoc.Value) Then Throw New Exception("El documento no se puede emitir, Pertenece a otro Periodo..!")
            '    oeDoc.TipoOperacion = "2"
            '    oeDoc.Id = oeDocumento.Id : oeDoc.CargaCompleta = True
            '    oeDoc = olDocumento.Obtener(oeDoc)
            '    oeDoc.TipoOperacion = "C"
            '    oeDoc.IdUsuarioCrea = gUsuarioSGI.Id
            '    oeDoc.IdPeriodo = frm.cmbPeriodo.Value
            '    oeDoc.IdEstadoDocumento = "1CIX020"
            '    oeDoc.FechaCreacion = ObtenerFechaServidor()
            '    mt_ObtenerAsiento(oeDoc.IdMoneda)
            '    oeDoc.IdCuentaContable = oeCtaCtble.Cuenta
            '    'oeDoc.Venta.IdAsientoModelo = oeAsientoModelo.Id
            '    oeDoc.Venta.TipoOperacion = "A"
            '    'oeDoc.Venta. = gUsuarioSGI.Id
            '    'If Not olAsientoModelo.GuardarVentaMaterial(oeAsientoModelo, oeDoc) Then
            '    '    Throw New Exception("Error Enviando el Documento")
            '    'Else
            '    '    If IndMensaje Then
            '    '        MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
            '    '        gmt_MostrarTabs(0, ficOrdenComercial, 2)
            '    '        Consultar(True)
            '    '    End If
            '    'End If
            '    'If cb_CobroAutomatico.Checked Then gfc_CobroAutomatico(oeDocumento.Id, frm.cmbPeriodo.Value, loCtaCtble, oeDoc.FechaCrea)
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Funciones"

    Private Sub mt_ObtenerSaldoCtaCte()
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub fc_Imprimir_Documento()
        Dim id As String = ""
        Try
            'If cbDocumento.Checked = True Then
            '    If cmbTipoDocumento.Text = "FACTURA" And txtSerie.Text = "0003" Or cmbTipoDocumento.Text = "FACTURA" And txtSerie.Text = "0004" Then
            '        Dim formulario As New frm_ImpresionFacturas
            '        id = oeDocumento.Id
            '        formulario.mt_CargarDatos(id, "")
            '        formulario.ShowDialog()
            '    ElseIf cmbTipoDocumento.Text = "BOLETA DE VENTA" And txtSerie.Text = "0003" Or cmbTipoDocumento.Text = "BOLETA DE VENTA" And txtSerie.Text = "0004" Then
            '        Dim formulario As New frm_ImpresionBoletas
            '        id = oeDocumento.Id
            '        formulario.mt_CargarDatos(id, "")
            '        formulario.ShowDialog()
            '    ElseIf cmbTipoDocumento.Text = "FACTURA" And txtSerie.Text = "0028" Then
            '        Dim formulario As New frm_ImpresionFacturasPiedra
            '        id = oeDocumento.Id
            '        formulario.mt_CargarDatos(id, "")
            '        formulario.ShowDialog()
            '    ElseIf cmbTipoDocumento.Text = "BOLETA DE VENTA" And txtSerie.Text = "0028" Then
            '        Dim formulario As New frm_ImpresionBoletasPiedra
            '        id = oeDocumento.Id
            '        formulario.mt_CargarDatos(id, "")
            '        formulario.ShowDialog()
            '    End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub mt_CobroAutomatico()
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ActualizarTipoPago()
        Try
            Dim oe As New e_Combo
            oe.Id = IdTipoPago
            oe.Tipo = 0
            If TipoPagoPublic.Contains(oe) Then
                oe = TipoPagoPublic.Item(TipoPagoPublic.IndexOf(oe))
                'dtpFechaPago.Value = dtpFecha.Value.AddDays(CInt(DETALLE.Descripcion))
            Else
                Throw New Exception("No se Encuentra el Tipo de Pago. Verificar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_EmitirDocumento() As Boolean
        Try
            fc_ValidarNumeroDoc()
            mt_Cargar_MovimientoDocumento()
            OrdenVenta.oeDocumento = MovimientoDocumento
            mt_Emitir_Documento(False)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_Cargar_OrdenSalida() As e_Orden
        Try
            '' Cargar OS
            OS = New e_Orden
            With OS
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .Glosa = TipoDocumento & " " & txtSerie.Text & " - " & txtNumero.Text
                .IdTipoOrden = "1CH000000002"
                .TipoOrden = "ORDEN DE SALIDA"
                .TipoOperacion = "I"
                .TipoReferencia = "ORDEN VENTA"
                .Referencia = OrdenVenta.Id
                .TipoCambio = TipoCambio
                .IdEmpresaSis = OrdenVenta.IdEmpresa
                .IdMovimientoInventario = "1CIX006"
                .IdMoneda = OrdenVenta.IdMoneda
                .IdEstadoOrden = "1CIX025"
                .UsuarioCreacion = gUsuarioSGI.Id
                .lstOrdenMaterial = New List(Of e_OrdenMaterial)
                .lstInventario = New List(Of e_Inventario)
            End With
            LISTA_ORDEN_MATERIAL = New List(Of e_OrdenMaterial)
            For Each oe As e_OrdenVentaMaterial In OrdenVenta.lstOrdenComercialMaterial.Where(Function(i) i.CantidadAtender > 0).ToList
                OM = New e_OrdenMaterial
                With OM
                    .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                    .IdSucursal = gs_PrefijoIdSucursal
                    .UsuarioCreacion = OS.UsuarioCreacion
                    .IdAlmacen = oe.IdAlmacen
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .IdMaterial = oe.IdMaterial
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .CantidadMaterial = oe.CantidadAtender
                    .PrecioUnitario = oe.PrecioUnitario
                    .Importe = Math.Round(.PrecioUnitario * .CantidadMaterial, 4)
                End With
                LISTA_ORDEN_MATERIAL.Add(OM)
            Next
            OS.Total = LISTA_ORDEN_MATERIAL.Sum(Function(i) i.PrecioUnitario * i.CantidadMaterial)
            OS.lstOrdenMaterial.AddRange(LISTA_ORDEN_MATERIAL)
            OrdenVenta.oeOrdenSalida = OS
            '' Generar OS
            'OS = dORDEN.Guardar(OS)
            Return OS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Private Function fc_OrdDocumento() As List(Of e_Orden_Documento)
    '    Try
    '        oeOrdDocumento = New e_Orden_Documento
    '        loOrdDocumento = New List(Of e_Orden_Documento)
    '        With oeOrdDocumento
    '            .IdOrden = OV.Id
    '            .TipoOrden = 2
    '            .TipoOperacion = "I"
    '            .TipoExistencia = 1
    '            .UsuarioCreacion = gUsuarioSGI.Id
    '            loOrdDocumento.Add(oeOrdDocumento)
    '        End With
    '        Return loOrdDocumento
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Private Sub btnDB5_Click(sender As Object, e As EventArgs) Handles btnDB5.Click
        Procesar_BotonCombustible(btnDB5.Text)
    End Sub

    Private Sub btnG84_Click(sender As Object, e As EventArgs) Handles btnG84.Click
        Procesar_BotonCombustible(btnG84.Text)
    End Sub

    Private Sub btnG90_Click(sender As Object, e As EventArgs) Handles btnG90.Click
        Procesar_BotonCombustible(btnG90.Text)
    End Sub

    Private Sub btnG95_Click(sender As Object, e As EventArgs) Handles btnG95.Click
        Procesar_BotonCombustible(btnG95.Text)
    End Sub

    Private Sub Procesar_BotonCombustible(Titulo As String)
        PaintBotones("Combustible")
        Select Case Titulo
            Case "DB5" 'DB5
                btnDB5.Appearance.ForeColor = Color.White
                IdMaterial_Combustible = "1CH000007256" : Material_Combustible = "DIESEL DB5" : Codigo_Combustible = "TR0012145"
                IdAlmacen_Combustible = "CHT000000001" : IdSubAlmacen_Combustible = IIf(sw_Lado = 3 Or sw_Lado = 4, "CHT000000001", "CHT000000002")
            Case "G84" 'G84
                btnG84.Appearance.ForeColor = Color.White
                IdMaterial_Combustible = "1CH000000147" : Material_Combustible = "GASOHOL 84" : Codigo_Combustible = "TR0000154"
                IdAlmacen_Combustible = "CHT000000001" : IdSubAlmacen_Combustible = "CHT000000003"
            Case "G90" 'G90
                btnG90.Appearance.ForeColor = Color.White
                IdMaterial_Combustible = "1CH000000148" : Material_Combustible = "GASOHOL 90" : Codigo_Combustible = "TR0000155"
                IdAlmacen_Combustible = "CHT000000001" : IdSubAlmacen_Combustible = "CHT000000004"
            Case "G95" 'G95
                btnG95.Appearance.ForeColor = Color.White
                IdMaterial_Combustible = "1CH000000149" : Material_Combustible = "GASOHOL 95" : Codigo_Combustible = "TR0000156"
                IdAlmacen_Combustible = "CHT000000001" : IdSubAlmacen_Combustible = "CHT000000004"
        End Select

        '' Cargar Producto
        decPrecio.Value = fc_Obtener_PrecioCombustible()
        Calcular_DescuentoCombustible()
    End Sub

    Public Function fc_Obtener_PrecioCombustible() As Double
        For Each Item In TurnoActivo.Detalles
            If Item.IdConcepto = IdMaterial_Combustible Then
                Return Item.ValorERP
            End If
        Next
        Return 0
    End Function

    Private Sub btnDocumento_Click(sender As Object, e As EventArgs) Handles btnDocumento.Click
        IdTipoDocumento = "1CH000000026" : TipoDocumento = "FACTURA" : grb_Documento.Visible = True
        PaintBotones("TipoDocumento") : btnDocumento.Appearance.BackColor = Color.Blue
    End Sub

    Private Sub btnVale_Click(sender As Object, e As EventArgs) Handles btnBoleta.Click
        IdTipoDocumento = "1CH000000002" : TipoDocumento = "BOLETA DE VENTA" : grb_Documento.Visible = False
        PaintBotones("TipoDocumento") : btnBoleta.Appearance.BackColor = Color.Blue
    End Sub

    Private Sub btnVarios_Click(sender As Object, e As EventArgs) Handles btnNotaDespacho.Click
        IdTipoDocumento = "GCH000000001" : TipoDocumento = "NOTA DE DESPACHO" : grb_Documento.Visible = False
        PaintBotones("TipoDocumento") : btnNotaDespacho.Appearance.BackColor = Color.Blue
    End Sub

    Private Sub btnLado1_Click(sender As Object, e As EventArgs) Handles btnLado1.Click
        Procesar_Lado(btnLado1.Text)
        btnLado1.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub btnLado2_Click(sender As Object, e As EventArgs) Handles btnLado2.Click
        Procesar_Lado(btnLado2.Text)
        btnLado2.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub btnLado3_Click(sender As Object, e As EventArgs) Handles btnLado3.Click
        Procesar_Lado(btnLado3.Text)
        btnLado3.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub btnLado4_Click(sender As Object, e As EventArgs) Handles btnLado4.Click
        Procesar_Lado(btnLado4.Text)
        btnLado4.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub btnLado5_Click(sender As Object, e As EventArgs) Handles btnLado5.Click
        Procesar_Lado(btnLado5.Text)
        btnLado5.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub btnLado6_Click(sender As Object, e As EventArgs) Handles btnLado6.Click
        Procesar_Lado(btnLado6.Text)
        btnLado6.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub Procesar_Lado(Lado As String)
        sw_Lado = Lado : ValidarSurtidor() : PaintBotones("Lado") : grbCombustible.Enabled = True
    End Sub

    Private Async Sub btnObtenerSunat_Click(sender As Object, e As EventArgs) Handles btnConsultarSUNAT.Click
        Try
            Dim empresa As New e_Empresa, lista_Empresa As New List(Of e_Empresa), d_Empresa As New l_Empresa
            Dim consultaRucSunat As New ConsultaRucSunat()
            Dim contribuyente As New Contribuyente
            Dim RUC As String = cbgCliente.Text
            contribuyente = Await consultaRucSunat.SunatConsultaRuc(RUC)

            lista_Empresa = d_Empresa.Listar(New e_Empresa)
            If lista_Empresa.Where(Function(it) it.Ruc = RUC).ToList.Count = 0 Then
                With empresa
                    .Ruc = contribuyente.RUC
                    .Nombre = contribuyente.RazonSocial
                    .DireccionFiscal = contribuyente.Direccion
                End With
                d_Empresa.Guardar(empresa)
            End If
            cbgCliente.Text = contribuyente.RazonSocial
            txtDireccionFiscal.Text = contribuyente.Direccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnContado_Click(sender As Object, e As EventArgs) Handles btnContado.Click
        IdTipoPago = "1SI000000001" : IdTipoVenta = "VENTA_COMBUSTIBLE"
        PaintBotones("TipoPago") : btnContado.Appearance.BackColor = Color.Blue
        btnDocumento.Enabled = True : btnBoleta.Enabled = True : btnNotaDespacho.Enabled = False
        Calcular_DescuentoCombustible()
    End Sub

    Private Sub btnCredito_Click(sender As Object, e As EventArgs) Handles btnCredito.Click
        IdTipoPago = "" : IdTipoVenta = "VENTA_COMBUSTIBLE"
        PaintBotones("TipoPago") : btnCredito.Appearance.BackColor = Color.Blue
        btnDocumento.Enabled = False : btnBoleta.Enabled = False : btnNotaDespacho.Enabled = True
        Calcular_DescuentoCombustible()
    End Sub

    Private Function fc_OrdenDocumento() As e_Orden_Documento
        Try
            OrdenDocumento = New e_Orden_Documento
            With OrdenDocumento
                .IdDocumento = MovimientoDocumento.Id.Trim
                .IdTipoDocumento = MovimientoDocumento.IdTipoDocumento
                .IdOrden = String.Empty
                .TipoOrden = 1
                .TipoOperacion = "I"
                .TipoExistencia = 1
                .UsuarioCreacion = gUsuarioSGI.Id
            End With
            Return OrdenDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click
        mt_AgregarDetalle()
        decCantidad.Value = 0
        decPrecio.Value = 0
        decDescuento.Value = 0
        decPrecioTotal.Value = 0
        decCantidad.SelectAll()
    End Sub

    Private Function fc_ValidarNumeroDoc() As Boolean
        Try
            If txtNumero.Text = "" Or txtSerie.Text = "" Or txtNumero.Text = "0000000000" Or txtSerie.Text = "0000" Then
                Throw New Exception("!..El Numero de Documento es Incorrecto..!")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

    Private Sub cbgCliente_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cbgCliente.InitializeLayout
        Me.cbgCliente.ValueMember = "Id"
        Me.cbgCliente.DisplayMember = "Nombre"
        With cbgCliente.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("TipoEmpresa").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("IdDireccionTanqueo").Hidden = True
            .Columns("Morosidad").Hidden = True
            .Columns("Credito").Hidden = True
            .Columns("IndNivelComercial").Hidden = True
            .Columns("Moneda").Hidden = True
            .Columns("IndClasificacion").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("IndCategoriaEmpresaSGI").Hidden = True
            '.Columns("Activo").Hidden = True
            .Columns("Ruc").Header.Caption = "N° RUC"
            .Columns("Ruc").Width = 100
            .Columns("Nombre").Width = 500
        End With
    End Sub

    Private Sub cbgCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles cbgCliente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Not String.IsNullOrEmpty(cbgCliente.Text.Trim) Then
                    gmt_ListarEmpresa("6", cbgCliente, String.Empty, cbRuc.Checked)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cbgCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbgCliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cbgCliente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cbgCliente_Validated(sender As Object, e As EventArgs) Handles cbgCliente.Validated
        Try
            ' mt_ObtenerSaldoCtaCte()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cbgCliente_Leave(sender As Object, e As EventArgs) Handles cbgCliente.Leave
        Try
            If Not cbgCliente.Value = "" Then
                EMPRESA.Id = cbgCliente.Value
                loEmpresa = dEMPRESA.Listar(EMPRESA)
                For Each Item As e_Empresa In loEmpresa
                    txtDireccionFiscal.Text = Item.DireccionFiscal
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmbVehiculo_EditorButtonClick(sender As Object, e As EventArgs) Handles cmbVehiculo.EditorButtonClick
        Try
            If MessageBox.Show("¿Desea Agregar Nuevo Vehículo?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim frm As New frm_Vehiculo
                frm = frm.getInstancia()
                With frm
                    .MdiParent = frm_Menu
                    .Show()
                    .Nuevo()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txtSerie.Validated
        txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
        txtNumero.Text = FormatoDocumento(CStr(gfc_ObtenerNumeroDoc(txtSerie.Text, IdTipoDocumento, 2)), 8)
    End Sub

    Private Sub txtNumero_Leave(sender As Object, e As EventArgs) Handles txtNumero.Leave
        If txtNumero.Text <> "" Then txtNumero.Text = FormatoDocumento(txtNumero.Text, 8)
    End Sub

    Private Sub decKilometraje_Click(sender As Object, e As EventArgs) Handles decKilometraje.Click
        decKilometraje.SelectAll()
    End Sub
End Class