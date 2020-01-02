﻿' Hola Maurixito

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
    Private PRODUCTO As New e_Material 'Combustible Seleccionado
    Private INVENTARIO As New e_Inventario
    Private TIPODOC As New e_TipoDocumento, dTIPODOC As New l_TipoDocumento
    Private oeMoneda As e_Moneda
    Private olEstacionServicio As New l_EstacionServicio
    Private sw_Documento As String = ""
    Private sw_TipoPago As String 'Contado "1SI000000001", 
    Private sw_Lado As String
    Private IdMaterial_Combustible As String, IdAlmacen_Combustible As String
    Private IdMoneda_Soles As String = "1CH01"
    Private TipoCambio As Double
    Private FechaOrden As Date

    Private OV As New e_OrdenVenta, dOV As New l_OrdenVenta
    Private dOVM As New l_OrdenVentaMaterial
    Private OM As New e_OrdenMaterial, dOM As New l_OrdenMaterial, LISTA_ORDEN_MATERIAL As New List(Of e_OrdenMaterial)
    Private dMA As New l_MaterialAlmacen
    Private dM As New l_Material, LISTA_MATERIAL As New List(Of e_Material)
    Private OS As New e_Orden, LISTA_OS As New List(Of e_Orden), dORDEN As New l_Orden

    Private LISTA_INVENTARIO As New List(Of e_Inventario)
    Private REGISTROINVENTARIO As e_RegistroInventario

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

    Private oeOrdDocumento As e_Orden_Documento, olOrdDocumento As l_Orden_Documento, loOrdDocumento As List(Of e_Orden_Documento)
    Private oeCtaCtble As New e_CuentaContable, olCtaCtable As New l_CuentaContable, loCtaCtble As New List(Of e_CuentaContable)

    Private DTReferencia As Data.DataTable
    Private dtAux As Data.DataTable

    Private AMR As New e_AsientoModelo_Referencia, d_AMR As l_AsientoModelo_Referencia, l_AMR As List(Of e_AsientoModelo_Referencia)

    Private oeSaldoCtaCte As e_SaldoCtaCorriente, olSaldoCtaCte As New l_SaldoCtaCorriente, leSaldoCtaCte As New List(Of e_SaldoCtaCorriente)
    Private oeTDDato As e_TablaDinamica_Dato, olTDDato As l_TablaDinamica_Dato, leTipoMovCtaCte As List(Of e_TablaDinamica_Dato)
    'Private EstadoOrden As e_EstadoOrden, dEstadoOrden As l_EstadoOrden, ListaEstadoOrden As List(Of e_EstadoOrden)

    Private mdblCantidadPrecio As Double = 0
    Private mdblIGV As Double = gfc_ParametroValor("IGV")
    Private mstrIdCuentaContable As String = ""

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
            olEstacionServicio = New l_EstacionServicio
            'Me.UltraGrid1.DataSource = olEstacionServicio.mt_Listar(New e_EstacionServicio With {.TipoOperacion = "N"})
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
                btnVale.Appearance.BackColor = Color.White
                btnVarios.Appearance.BackColor = Color.White
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
                btnVale.Appearance.BackColor = Color.White
                btnVarios.Appearance.BackColor = Color.White
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
            If dOV.Guardar(OV) Then
                If cbDocumento.Checked = True AndAlso cmbTipoDocumento.Text <> "" Then
                    If MovimientoDocumento.Id.Trim <> "" Then
                        Select Case MessageBox.Show("¿Desea Emitir el Documento?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                            Case Windows.Forms.DialogResult.Yes
                                mt_Emitir_Documento(False)
                        End Select
                        MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
                        MovimientoDocumento = dMovimientoDocumento.Obtener(New e_MovimientoDocumento With {.TipoOperacion = "", .Id = OV.oeDocumento.Id})
                        'Select Case oeDocumento.IdTipoDocumento
                        '    Case "1CIX001"
                        '        gmt_GeneraZip(oeDocumento.RutaImpresionXML)
                        '    Case "1CIX007", "1CIX008"
                        '        If oeDocumento.RutaImpresionXML <> "" Then gmt_GeneraZip(oeDocumento.RutaImpresionXML)
                        'End Select
                        'gmt_ImprimirDocElectronico(oeDocumento.Id, oeDocumento.IdTipoDocumento)
                        'If My.Computer.Network.IsAvailable Then gr_EnviarEmail(oeDocumento)
                    End If
                End If
                'MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
                'fc_Imprimir_Documento()
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function fc_Cargar_OrdenVenta() As Boolean
        Try
            With OV
                .PrefijoID = gs_PrefijoIdSucursal
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .UsuarioCrea = gUsuarioSGI.Login
                .Tipo = 2
                .TipoExistencia = 1
                .TipoCambio = gfc_TipoCambio(Now, True) 'Revisar
                .IndFactSer = True 'Revisar
                .IdVendedorTrabajador = "" 'Revisar Objeto Global Trabajador
                If cbgCliente.SelectedRow Is Nothing Then Throw New Exception("Seleccione Cliente")
                .IdEmpresa = cbgCliente.Value
                'Select Case Operacion
                '    Case "Nuevo"
                '        .TipoOperacion = "I"
                '        .IdEstado = "1CH000000011" 'Evaluado
                '        If cbDocumento.Checked = True Then : .IndFacturadoProducto = True : End If
                '        .IdTrabajadorAprobacion = gUsuarioSGI.oePersona.Id
                fc_ValidarNumeroDoc()
                If Not fc_EmitirDocumento() Then
                    Return False
                End If
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
                .TipoOperacion = "T"
                .oeOrdenSalida = New e_Orden
                .oeOrdenSalida = fc_Cargar_OrdenSalida()
                .oeOrdenSalida.IdOrdenDocumento = fc_OrdenDocumento().Id
                For Each oe As e_OrdenVentaMaterial In OV.lstOrdenComercialMaterial
                    If oe.CantidadPendiente - oe.CantidadAtender >= 0 Then
                        oe.CantidadPendiente = oe.CantidadPendiente - oe.CantidadAtender
                        oe.CantidadAtender = 0
                    End If
                Next
                If OV.lstOrdenComercialMaterial.Sum(Function(i) i.CantidadPendiente) = 0 Then
                    .IdEstado = "1CIX004"
                Else
                    .IdEstado = "1CIX005"
                End If
                'End Select
                '.lstOrdenComercialMaterial = New List(Of e_OrdenVentaMaterial)
                '.lstOrdenComercialMaterial.AddRange(LISTA_ORDENVENTA_MATERIAL)
                .Fecha = ObtenerFechaServidor()
                .IdMoneda = IdMoneda_Soles
                .IdTipoPago = sw_TipoPago
                .Glosa = txtGlosa.Value
                .Total = decTotal.Value
                .SubTotal = decSubTotal.Value
                .Impuesto = decImpuesto.Value
                .TipoCompra = 0
                .IdTipoVenta = "VENTA_COMBUSTIBLE"
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
        cmbTipoDocumento.Value = 0
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        txtGlosa.Text = String.Empty
        grb_Documento.Visible = False
        grbCombustible.Enabled = False
        mstrIdCuentaContable = ""

        '' Valores Default
        FechaOrden = ObtenerFechaServidor()
        TipoCambio = gfc_TipoCambio(FechaOrden, True)
        PaintBotones("Clean")
        udg_Detalle.DataSource = New List(Of e_OrdenVentaMaterial)
        gmt_OcultarColumna(udg_Detalle, True, "IndOperacion", "IdOrigen", "IdDestino")

        '' Cargar Listas y Combos
        leCuentaBancaria.AddRange(olCtaBancaria.Listar(New e_CuentaBancaria With {.IdCuentaContable = oeCtaCtble.Id, .Activo = True, .Ejercicio = Date.Parse(OV.Fecha).Year, .TipoOperacion = "C"}))
        ListaServicioCuentaContable = dServicioCuentaContable.Listar(New e_ServicioCuentaContable With {.TipoOperacion = "V", .Activo = True, .Ejercicio = Date.Now.Year})
        gmt_ComboEspecifico(cmbTipoDocumento, dTIPODOC.Listar(New e_TipoDocumento With {.TipoOperacion = "X"}), -1)

        'ListaVehiculo.AddRange(dVehiculo.Listar(New e_Vehiculo With {.Motriz = 1, .Activo = True, .TipoOperacion = "M"}))
        LlenarCombo(cmbVehiculo, "Nombre", TractoPublic, -1)
    End Sub

    Private Sub mt_AgregarDetalle()
        Try

            Dim OV_DETALLE As New e_OrdenVentaMaterial
            With OV_DETALLE
                PRODUCTO.Seleccion = False
                .TipoOperacion = "I"
                .PrefijoID = gs_PrefijoIdSucursal
                .IndImpuesto = True
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .UsuarioCrea = gUsuarioSGI.Id
                .IdMaterial = PRODUCTO.Id
                .Material = PRODUCTO.Nombre
                .Codigo = PRODUCTO.Codigo
                .Cantidad = decCantidad.Value
                .CantidadPendiente = decCantidad.Value
                .CostoUnitario = decPrecio.Value
                .CostoInventario = 0 'DETALLE.CostoUnitario
                .PrecioUnitario = decPrecio.Value
                .Dscto = decDescuento.Value
                '.IdTipoUnidadMedida = DETALLE.idu
                .IdAlmacen = PRODUCTO.IdAlmacen
                .IdUnidadMedida = PRODUCTO.IdUnidadMedida
                .IdSubAlmacen = PRODUCTO.IdSubAlmacen
                .PrecioTotal = Math.Round(.PrecioUnitario * .Cantidad, 4)
                '.IndOperacion = IIf(chkTransporte.Checked, 1, 0)
                '.IdOrigen = cboOrigenViaje.Value
                '.IdDestino = cboDestinoViaje.Value
            End With
            If OV.lstOrdenComercialMaterial.Where(Function(i) i.IdMaterial = OV_DETALLE.IdMaterial And i.TipoOperacion <> "E").ToList.Count > 0 Then
                udg_Detalle.DataBind()
                mt_CalcularTotalOrden()
                'mt_CombosGrilla(griOrdenComercialMaterial)
                'griAlmacenMaterial.DataBind()
                Throw New Exception("Material: " & OV_DETALLE.Material & " ya Asignado a la Orden")
            End If
            OV.lstOrdenComercialMaterial.Add(OV_DETALLE)
            udg_Detalle.DataSource = OV.lstOrdenComercialMaterial
            udg_Detalle.DataBind()
            mt_CalcularTotalOrden()
            'mt_CombosGrilla(griOrdenComercialMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CalcularTotalOrden()
        Try
            Dim bolIndicador As Boolean = False
            Dim dblTotalOrden As Double = 0
            For Each oe As e_OrdenVentaMaterial In OV.lstOrdenComercialMaterial.Where(Function(i) i.TipoOperacion <> "E").ToList
                dblTotalOrden += oe.PrecioTotal '- DETALLE.Dscto
                If oe.IndImpuesto Then
                    bolIndicador = True
                    oe.CostoUnitario = Math.Round(oe.PrecioUnitario / (1 + mdblIGV), 2)
                Else
                    oe.CostoUnitario = Math.Round(oe.PrecioUnitario, 2, MidpointRounding.AwayFromZero)
                End If
            Next
            decTotal.Value = Math.Round(dblTotalOrden, 2)
            If bolIndicador Then
                decSubTotal.Value = Math.Round(dblTotalOrden / (1 + mdblIGV), 2)
                decImpuesto.Value = decTotal.Value - decSubTotal.Value
            Else
                decImpuesto.Value = 0
                decSubTotal.Value = decTotal.Value
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_ObtenerDescuento(IdEmpresa As String, IdProducto As String, TipoPago As String) As Double
        Dim DESCUENTOS As New List(Of e_EmpresaDescuento)
        Dim d_Descuentos As New l_EmpresaDescuento
        DESCUENTOS = d_Descuentos.Listar(New e_EmpresaDescuento With {.IdEmpresa = cbgCliente.Value, .IdProducto = IdMaterial_Combustible})
        If DESCUENTOS.Count > 0 Then
            For Each Item In DESCUENTOS
                If sw_TipoPago = "" Then
                    Return Item.DescuentoCredito
                Else
                    Return Item.DescuentoContado
                End If
            Next
        Else
            Return 0
        End If
    End Function

    Private Sub mt_Cargar_MovimientoDocumento()
        Try
            MovimientoDocumento = New e_MovimientoDocumento
            With MovimientoDocumento
                .TipoOperacion = "I"
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .PrefijoID = gs_PrefijoIdSucursal
                .IdClienteProveedor = OV.IdEmpresa
                .IdTipoDocumento = cmbTipoDocumento.Value
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
                For Each oe As e_OrdenVentaMaterial In OV.lstOrdenComercialMaterial
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
                .Venta.IdTipoPago = sw_TipoPago
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
            MEDIOPAGO = dMEDIOPAGO.Obtener(New e_MedioPago With {.Id = ""})

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
                .TipoCambio = gfc_TipoCambio(Now.Date, True)
                .TotalMN = OV.Total
                .TotalME = OV.Total / OV.TipoCambio
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
            If dASIENTO.GuardarCobranza(ListaMovimientoDocumento, MOVIMIENTO, MEDIOPAGO, gUsuarioSGI.Id, MacPCLocal, oeCtaCtble, indicadortipo) Then
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

            Cliente = dCliente.Obtener(New e_Cliente With {.TipoOperacion = "", .TipoClienteProveedor = 1, .Id = OV.IdEmpresa})
            TIPODOC = dTIPODOC.Obtener(New e_TipoDocumento With {.TipoOperacion = "", .Id = cmbTipoDocumento.Value})
            oeMoneda.Id = IdMoneda_Soles 'Revisar

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                loCtaCtble = olCtaCtable.Listar(New e_CuentaContable With {.Ejercicio = frm.Año1.Año, .TipoOperacion = "N", .Movimiento = 1})
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

    Private Sub mt_CargarSaldoCtaCte()
        Try
            Dim CC As New e_CuentaCorriente, d_CC As New l_CuentaCorriente, l_CC As New List(Of e_CuentaCorriente)
            'l_CC = d_CC.Listar(New e_CuentaCorriente With {.Idempr = "C", .IdCuentaCorriente = ""})
            leSaldoCtaCte = olSaldoCtaCte.Listar(New e_SaldoCtaCorriente With {.TipoOperacion = "C", .IdCuentaCorriente = ""})
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ObtenerSaldoCtaCte()
        Try
            'txtCodSaldoCtaCte.Text = String.Empty : txtCodSaldoCtaCte.Tag = String.Empty
            'txtCodSaldoCtaCte.Appearance.ForeColor = Color.Black
            'btnCrearCtaCte.Enabled = False
            'Dim _IdEmpresaAux As String = String.Empty
            'If cbgCliente.Value <> "" Then _IdEmpresaAux = cbgCliente.Value 'IIf(gfc_ValidarEmpresa(cbgCliente.Value), cbgCliente.Value, "")
            'If _IdEmpresaAux <> "" AndAlso cmbMoneda.SelectedIndex > -1 Then
            '    If leSaldoCtaCte.Count > 0 Then
            '        oeSaldoCtaCte = New e_SaldoCuentaCorriente
            '        oeSaldoCtaCte.TipoBusca = 3
            '        oeSaldoCtaCte.IdReferencia = _IdEmpresaAux
            '        oeSaldoCtaCte.IdMoneda = cmbMoneda.Value
            '        If leSaldoCtaCte.Contains(oeSaldoCtaCte) Then
            '            oeSaldoCtaCte = leSaldoCtaCte.Item(leSaldoCtaCte.IndexOf(oeSaldoCtaCte))
            '            txtCodSaldoCtaCte.Text = oeSaldoCtaCte.NroCuentaCte
            '            txtCodSaldoCtaCte.Tag = oeSaldoCtaCte.Id
            '        Else
            '            txtCodSaldoCtaCte.Text = "NO TIENE CUENTA CTE"
            '            txtCodSaldoCtaCte.Tag = String.Empty
            '            txtCodSaldoCtaCte.Appearance.ForeColor = Color.Red
            '            btnCrearCtaCte.Enabled = True
            '        End If
            '    Else
            '        txtCodSaldoCtaCte.Text = "NO TIENE CUENTA CTE"
            '        txtCodSaldoCtaCte.Tag = String.Empty
            '        txtCodSaldoCtaCte.Appearance.ForeColor = Color.Red
            '        btnCrearCtaCte.Enabled = True
            '    End If
            'End If
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
            oe.Id = sw_TipoPago
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
            If cbDocumento.Checked Then
                mt_Cargar_MovimientoDocumento()
                OV.oeDocumento = MovimientoDocumento
            Else
                Select Case MessageBox.Show("¿Desea Guardar la Orden sin Documento?", "Mensaje del Sistema",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.No
                        Return False
                End Select
            End If
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
                .Glosa = cmbTipoDocumento.Text & " " & txtSerie.Text & " - " & txtNumero.Text
                .TipoOperacion = "I"
                .TipoReferencia = "ORDEN VENTA"
                .Referencia = OV.OrdenComercial
                .TipoCambio = TipoCambioCompraVenta(ObtenerFechaServidor) ' decTipoCambio.Value
                .IdEmpresaSis = OV.IdEmpresa
                .IdMovimientoInventario = "1CIX006"
                .IdMoneda = OV.IdMoneda
                .IdEstadoOrden = "1CIX025"
                .UsuarioCreacion = gUsuarioSGI.Id
                .lstOrdenMaterial = New List(Of e_OrdenMaterial)
                .lstInventario = New List(Of e_Inventario)
            End With
            LISTA_ORDEN_MATERIAL = New List(Of e_OrdenMaterial)
            For Each oe As e_OrdenVentaMaterial In OV.lstOrdenComercialMaterial.Where(Function(i) i.CantidadAtender > 0).ToList
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
                IdMaterial_Combustible = "1CH000007256"
                IdAlmacen_Combustible = ""
            Case "G84" 'G84
                btnG84.Appearance.ForeColor = Color.White
                IdMaterial_Combustible = "1CH000000147"
                IdAlmacen_Combustible = ""
            Case "G90" 'G90
                btnG90.Appearance.ForeColor = Color.White
                IdMaterial_Combustible = "1CH000000148"
                IdAlmacen_Combustible = ""
            Case "G95" 'G95
                btnG95.Appearance.ForeColor = Color.White
                IdMaterial_Combustible = "1CH000000149"
                IdAlmacen_Combustible = ""
        End Select

        '' Cargar Producto
        LISTA_MATERIAL = dM.Listar(New e_Material With {.TipoOperacion = "C", .Activo = True})
        LISTA_MATERIAL = LISTA_MATERIAL.Where(Function(it) it.Id = IdMaterial_Combustible).ToList
        For Each Item As e_Material In LISTA_MATERIAL
            PRODUCTO = Item
        Next
        decPrecio.Value = PRODUCTO.Precio
        decDescuento.Value = fc_ObtenerDescuento(cbgCliente.Value, IdMaterial_Combustible, sw_TipoPago)
        decCantidad.SelectAll()
    End Sub

    Private Sub btnDocumento_Click(sender As Object, e As EventArgs) Handles btnDocumento.Click
        sw_Documento = "DOC" : grb_Documento.Visible = True
        PaintBotones("TipoDocumento") : btnDocumento.Appearance.BackColor = Color.Blue
    End Sub

    Private Sub btnVale_Click(sender As Object, e As EventArgs) Handles btnVale.Click
        sw_Documento = "VALE" : grb_Documento.Visible = False
        PaintBotones("TipoDocumento") : btnVale.Appearance.BackColor = Color.Blue
    End Sub

    Private Sub btnVarios_Click(sender As Object, e As EventArgs) Handles btnVarios.Click
        sw_Documento = "OTROS" : grb_Documento.Visible = False
        PaintBotones("TipoDocumento") : btnVarios.Appearance.BackColor = Color.Blue
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

    Private Async Sub btnObtenerSunat_Click(sender As Object, e As EventArgs)
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
        sw_TipoPago = "1SI000000001"
        PaintBotones("TipoPago") : btnContado.Appearance.BackColor = Color.Blue
    End Sub

    Private Sub btnCredito_Click(sender As Object, e As EventArgs) Handles btnCredito.Click
        sw_TipoPago = ""
        PaintBotones("TipoPago") : btnCredito.Appearance.BackColor = Color.Blue
    End Sub

    Private Function fc_OrdenDocumento() As e_Orden_Documento
        Try
            oeOrdDocumento = New e_Orden_Documento
            With oeOrdDocumento
                .IdDocumento = MovimientoDocumento.Id.Trim
                .IdTipoDocumento = MovimientoDocumento.IdTipoDocumento
                .IdOrden = String.Empty
                .TipoOrden = 1
                .TipoOperacion = "I"
                .TipoExistencia = 1
                .UsuarioCreacion = gUsuarioSGI.Id
            End With
            Return oeOrdDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click
        mt_AgregarDetalle()
    End Sub

    Private Function fc_AnularOrdenVenta() As Boolean

    End Function

    Private Function fc_ValidarNumeroDoc() As Boolean
        Try
            If cbDocumento.Checked = True Then
                If txtNumero.Text = "" Or txtSerie.Text = "" Or txtNumero.Text = "0000000000" Or txtSerie.Text = "0000" Then
                    Throw New Exception("!..El Numero de Documento es Incorrecto..!")
                End If
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

    Private Sub txtSerie_Leave(sender As Object, e As EventArgs) Handles txtSerie.Leave
        If txtSerie.Text <> "" Then txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
    End Sub

    Private Sub txtNumero_Leave(sender As Object, e As EventArgs) Handles txtNumero.Leave
        If txtNumero.Text <> "" Then txtNumero.Text = FormatoDocumento(txtNumero.Text, 8)
    End Sub
End Class