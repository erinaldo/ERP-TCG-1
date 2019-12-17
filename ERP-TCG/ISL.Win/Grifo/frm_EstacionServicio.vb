' Hola Maurixito

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid

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

#End Region

#Region "Declaracion de Variables"

    Private PRODUCTO As New e_Material 'Combustible Seleccionado
    Private INVENTARIO As New e_Inventario

    Private olEstacionServicio As New l_EstacionServicio
    Private sw_Documento As String = ""
    Private sw_TipoPago As String 'Contado "1SI000000001", 
    Private sw_Lado As String
    Private IdMaterial_Combustible As String, IdAlmacen_Combustible As String
    Private IdMoneda_Soles As String = "1CH01"
    Private TipoCambio As Double
    Private FechaOrden As Date

    Private OV As New e_OrdenVenta, dORDENVENTA As New l_OrdenVenta
    Private dORDENVENTAMATERIAL As New l_OrdenVentaMaterial
    Private ORDENMATERIAL As New e_OrdenMaterial, dORDENMATERIAL As New l_OrdenMaterial
    Private dMATERIALALMACEN As New l_MaterialAlmacen
    Private dMATERIAL As New l_Material
    Private OS As New e_Orden, LISTA_OS As New List(Of e_Orden), dORDEN As New l_Orden

    Private LISTA_MATERIAL As New List(Of e_Material)
    Private LISTA_ORDEN_MATERIAL As New List(Of e_OrdenMaterial)
    Private LISTA_INVENTARIO As New List(Of e_Inventario)
    Private REGISTROINVENTARIO As e_RegistroInventario

    Private oeCombo As New e_Combo, olCombo As New l_Combo
    Private loEmpresa As New List(Of e_Empresa)
    Private loEmpresaCliente As New List(Of e_Empresa)

    ''Carga mis Detalles Combos y Grillas
    Dim ds As Data.DataSet
    Dim ListLugar As List(Of e_Combo)
    ''Cargamos a los Vendedores
    Dim ListVendedores As List(Of e_Combo)

    Private oeVenta As e_Venta
    Private olVenta As l_Venta

    Private MOVIMIENTODOCUMENTO As e_MovimientoDocumento, dMOVIMIENTODOCUMENTO As l_MovimientoDocumento
    Private DETALLEDOCUMENTO As e_DetalleDocumento, LISTA_DETALLEDOCUMENTO As List(Of e_DetalleDocumento)
    Private oeOrdDocumento As e_Orden_Documento, olOrdDocumento As l_Orden_Documento, loOrdDocumento As List(Of e_Orden_Documento)

    Private oeCtaCtble As New e_CuentaContable, olCtaCtable As New l_CuentaContable, loCtaCtble As New List(Of e_CuentaContable)

    Private DTReferencia As Data.DataTable
    Private dtAux As Data.DataTable

    Private AMR As New e_AsientoModelo_Referencia, d_AMR As l_AsientoModelo_Referencia, l_AMR As List(Of e_AsientoModelo_Referencia)

    Private oeSaldoCtaCte As e_SaldoCtaCorriente, olSaldoCtaCte As New l_SaldoCtaCorriente, leSaldoCtaCte As New List(Of e_SaldoCtaCorriente)
    Private oeTDDato As e_TablaDinamica_Dato, olTDDato As l_TablaDinamica_Dato, leTipoMovCtaCte As List(Of e_TablaDinamica_Dato)
    Private ESTADOORDEN As e_EstadoOrden, d_ESTADOORDEN As l_EstadoOrden, l_ESTADOORDEN As List(Of e_EstadoOrden)

    Private mdblCantidadPrecio As Double = 0
    Private mdblIGV As Double = gfc_ParametroValor("IGV")
    Private mstrIdCuentaContable As String = ""

    Private Const ls_NotaCredito As String = "NOTA DE CREDITO"
    Private ls_IdProv1 As String = "", ls_IdProv2 As String = "", ls_EstadoGenerado As String = ""
    Private ejecuta As Integer = 0

    Private EMPRESA As New e_Empresa, dEMPRESA As New l_Empresa
    'Private loEmpresa As List(Of e_Empresa)

    Private TIPOPAGO As New e_TipoPago, dTIPOPAGO As New l_TipoPago, LISTA_TIPOPAGO As New List(Of e_TipoPago)

    Private indFacturaBoleta As Integer = 0
    Private DNI As String = "1CIX00000000000225"
    Private Ruc As String = "1CIX00000000000229"

    Private CLIENTE As New e_Cliente
    Private olCliente As New l_Cliente

    Private TIPODOC As New e_TipoDocumento, dTIPODOC As New l_TipoDocumento
    Private oeMoneda As e_Moneda

    Private ASIENTOMODELO As New e_AsientoModelo, dASIENTOMODELO As New l_AsientoModelo, LISTA_ASIENTOMODELO As New List(Of e_AsientoModelo)
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
            Case "1"
                btnDB5.Enabled = True
                btnG84.Enabled = True
                btnG90.Enabled = True
                btnG95.Enabled = True
            Case "2"
                btnDB5.Enabled = True
                btnG84.Enabled = True
                btnG90.Enabled = True
                btnG95.Enabled = True
            Case "3"
                btnDB5.Enabled = True
                btnG84.Enabled = False
                btnG90.Enabled = False
                btnG95.Enabled = False
            Case "4"
                btnDB5.Enabled = True
                btnG84.Enabled = False
                btnG90.Enabled = False
                btnG95.Enabled = False
            Case "5"
                btnDB5.Enabled = True
                btnG84.Enabled = True
                btnG90.Enabled = True
                btnG95.Enabled = True
            Case "6"
                btnDB5.Enabled = True
                btnG84.Enabled = True
                btnG90.Enabled = True
                btnG95.Enabled = True
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
            If fc_Guardar() Then
                'gmt_MostrarTabs(0, ficOrdenComercial, 2)
                Consultar(True)
            End If
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

#Region "Metodos"

    Private Sub mt_Inicializar()
        MOVIMIENTODOCUMENTO = New e_MovimientoDocumento
        OV = New e_OrdenVenta
        LISTA_MATERIAL = New List(Of e_Material)
        loEmpresa = New List(Of e_Empresa)
        cbgCliente.DataSource = loEmpresa
        cbgCliente.Text = String.Empty
        LISTA_OS = New List(Of e_Orden)
        LISTA_ORDEN_MATERIAL = New List(Of e_OrdenMaterial)
        decSubTotal.Value = 0
        decImpuesto.Value = 0
        decTotal.Value = 0
        cmbTipoDocumento.Value = 0
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        txtGlosa.Text = String.Empty
        cbDocumento.Enabled = True
        cbDocumento.Checked = False
        mstrIdCuentaContable = ""
        ' Valores Default
        FechaOrden = ObtenerFechaServidor()
        IdMoneda_Soles = ""
        TipoCambio = gfc_TipoCambio(FechaOrden, True)
        PaintBotones("Clean")
        udg_Detalle.DataSource = New List(Of e_OrdenVentaMaterial)
        gmt_OcultarColumna(udg_Detalle, True, "IndOperacion", "IdOrigen", "IdDestino")
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

    Private Sub mt_GeneraDocumento()
        Try
            MOVIMIENTODOCUMENTO = New e_MovimientoDocumento
            With MOVIMIENTODOCUMENTO
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
                .lstDetalleDocumento = New List(Of e_DetalleDocumento)
                .lstDetalleDocumento = fc_DetalleDoc()
                '.lstOrdenDocumento = New List(Of e_Orden_Documento)
                '.lstOrdenDocumento = fc_OrdDocumento()
                .Venta = New e_Venta
                .Venta = fc_LlenarVenta()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub mt_ListarCtaCtble(ByVal numEjercicio As Integer)
        Try
            oeCtaCtble = New e_CuentaContable
            oeCtaCtble.Ejercicio = numEjercicio
            oeCtaCtble.TipoOperacion = "N"
            oeCtaCtble.Movimiento = 1 : oeCtaCtble.CuentaAsociada = New List(Of e_CuentaAsociada)
            'oeCtaCtble.MonedaExtranjera = -1 : oeCtaCtble.FlujoCaja = -1 : oeCtaCtble.Conciliacion = -1
            'oeCtaCtble.IndDocumento = -1
            'oeCtaCtble.ob = -1
            'oeCtaCtble.de = -1 : oeCtaCtble.IndHaber = -1
            loCtaCtble = olCtaCtable.Listar(oeCtaCtble)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_EmitirDocumento(IndMensaje As Boolean)
        Try
            Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "VTA")
            CLIENTE = New e_Cliente
            CLIENTE.TipoClienteProveedor = 1
            CLIENTE = olCliente.Obtener(CLIENTE)

            oeMoneda.Id = IdMoneda_Soles 'Revisar

            TIPODOC = New e_TipoDocumento
            TIPODOC.TipoOperacion = ""
            TIPODOC.Id = cmbTipoDocumento.Value
            TIPODOC = dTIPODOC.Obtener(TIPODOC)

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                mt_ListarCtaCtble(frm.Año1.Año)

                Dim oeDoc As New e_MovimientoDocumento
                oeDoc.Id = MOVIMIENTODOCUMENTO.Id : oeDoc.CargaCompleta = True
                oeDoc = dMOVIMIENTODOCUMENTO.Obtener(oeDoc)

                oeDoc.IdPeriodo = frm.cboMes.Value : oeDoc.Ejercicio = frm.Año1.Año
                oeDoc.Venta.TipoDoc = TIPODOC : oeDoc.Venta.Cliente = CLIENTE : oeDoc.Venta.Moneda = oeMoneda

                ASIENTOMODELO = New e_AsientoModelo
                ASIENTOMODELO.Equivale = 1 : ASIENTOMODELO.IdMoneda = oeMoneda.Id

                If LISTA_ASIENTOMODELO.Contains(ASIENTOMODELO) Then
                    ASIENTOMODELO = LISTA_ASIENTOMODELO.Item(LISTA_ASIENTOMODELO.IndexOf(ASIENTOMODELO))
                    ASIENTOMODELO.TipoOperacion = ""
                    ASIENTOMODELO.Ejercicio = oeDoc.FechaEmision.Year
                    ASIENTOMODELO = dASIENTOMODELO.Obtener(ASIENTOMODELO)
                    For Each _oeDet In ASIENTOMODELO.leDetalle
                        oeCtaCtble = New e_CuentaContable
                        oeCtaCtble.Cuenta = "12121" : oeCtaCtble.Equivale = 0
                        If loCtaCtble.Contains(oeCtaCtble) Then
                            oeCtaCtble = loCtaCtble.Item(loCtaCtble.IndexOf(oeCtaCtble))
                            _oeDet.IdCuentaContable = oeCtaCtble.Id
                        End If
                    Next

                    'oeCuentaCorriente = New e_CuentaCorriente
                    'oeCuentaCorriente.Tipo = 3 : oeCuentaCorriente.IdTrabajador = oeMovDocumento.IdClienteProveedor
                    'oeCuentaCorriente = olCuentaCorriente.Obtener(oeCuentaCorriente)
                    'oeMovDocumento.IdUsuarioCrea = gUsuarioSGI.Id
                    'If oeMovDocumento.IndAfectaAnticipo Then
                    '    oeDocAsoc = New e_DocumentoAsociado
                    '    oeDocAsoc.TipoOperacion = "T"
                    '    oeDocAsoc.IdMovimientoDocumento = oeMovDocumento.Id
                    '    oeMovDocumento.DocAsoc = olDocAsoc.Listar(oeDocAsoc)
                    'End If
                    'oeMovDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    'If oeCuentaCorriente.Id <> "" Then
                    '    _banEmis = olMovDocumento.GuardarVentaAsiento(oeMovDocumento, oeAsientoModel, oeServCtaCtble, False, String.Empty, b_anticipo)
                    'Else
                    '    With oeCuentaCorriente
                    '        .Tipooperacion = "I" : .Tipo = 3 : .IdTrabajador = oeMovDocumento.IdClienteProveedor
                    '        .Saldo = 0 : .TotalCargo = 0 : .TotalAbono = 0 : .Ejercicio = frm.Año1.Año : .Usuario = gUsuarioSGI.Id
                    '        .IdEstado = "HABILITADA" : .IdMoneda = "1CH01" : .Glosa = "CUENTA DE EMPRESA"
                    '    End With
                    '    oeCuentaCorriente.PrefijoID = gs_PrefijoIdSucursal '@0001
                    '    olCuentaCorriente.Guardar(oeCuentaCorriente)
                    '    _banEmis = olMovDocumento.GuardarVentaAsiento(oeMovDocumento, oeAsientoModel, oeServCtaCtble, False, String.Empty, b_anticipo)
                    'End If

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

    Private Function fc_Guardar() As Boolean
        Try
            If Not fc_LlenaObjeto() Then Return False
            'mt_ObtenerSaldoCtaCte()
            'If txtCodSaldoCtaCte.Tag.ToString.Trim = "" Then Throw New Exception("¡Ingrese Cuenta Corriente!")
            If dORDENVENTA.Guardar(OV) Then
                If cbDocumento.Checked = True AndAlso cmbTipoDocumento.Text <> "" Then
                    If MOVIMIENTODOCUMENTO.Id.Trim <> "" Then
                        Select Case MessageBox.Show("¿Desea Emitir el Documento?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                            Case Windows.Forms.DialogResult.Yes
                                mt_EmitirDocumento(False)
                        End Select
                        MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
                        MOVIMIENTODOCUMENTO = New e_MovimientoDocumento
                        MOVIMIENTODOCUMENTO.TipoOperacion = ""
                        MOVIMIENTODOCUMENTO.Id = OV.oeDocumento.Id
                        MOVIMIENTODOCUMENTO = dMOVIMIENTODOCUMENTO.Obtener(MOVIMIENTODOCUMENTO)
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


    Public Function fc_LlenaObjeto() As Boolean
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
                Select Case Operacion
                    Case "Nuevo"
                        .TipoOperacion = "I"
                        .IdEstado = "1CH000000011" 'Evaluado
                        If cbDocumento.Checked = True Then : .IndFacturadoProducto = True : End If
                        .IdTrabajadorAprobacion = gUsuarioSGI.oePersona.Id
                        fc_ValidarNumeroDoc()
                        If Not fc_EmitirDocumento() Then
                            Return False
                        End If
                    Case "Editar"
                        .TipoOperacion = "A"
                        If cbDocumento.Checked = True Then : .IndFacturadoProducto = True : End If
                        fc_ValidarNumeroDoc()
                        If MOVIMIENTODOCUMENTO.Id = "" Then
                            If Not fc_EmitirDocumento() Then
                                Return False
                            End If
                        End If
                    Case "Atender"
                        If OV.lstOrdenComercialMaterial.Sum(Function(i) i.CantidadAtender) = 0 Then Throw New Exception("Cantidad a Atender no Puede ser 0.")
                        .TipoOperacion = "T"
                        .oeOrdenSalida = New e_Orden
                        .oeOrdenSalida = fc_GenerarOrdenSalida()
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
                End Select
                '.lstOrdenComercialMaterial = New List(Of e_OrdenVentaMaterial)
                '.lstOrdenComercialMaterial.AddRange(LISTA_ORDENVENTA_MATERIAL)
                .Fecha = ObtenerFechaServidor()
                .IdMoneda = "" 'Revisar
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
                mt_GeneraDocumento()
                OV.oeDocumento = MOVIMIENTODOCUMENTO
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

    Private Function fc_GenerarOrdenSalida() As e_Orden
        Try
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
                ORDENMATERIAL = New e_OrdenMaterial
                With ORDENMATERIAL
                    .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                    .IdSucursal = gs_PrefijoIdSucursal
                    .UsuarioCreacion = OS.UsuarioCreacion
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .IdMaterial = oe.IdMaterial
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .CantidadMaterial = oe.CantidadAtender
                    .PrecioUnitario = oe.PrecioUnitario
                    '.PrecioTotal = Math.Round(.PrecioUnitario * .CantidadMaterial, 4)
                End With
                LISTA_ORDEN_MATERIAL.Add(ORDENMATERIAL)
            Next
            OS.Total = LISTA_ORDEN_MATERIAL.Sum(Function(i) i.PrecioUnitario * i.CantidadMaterial)
            OS.lstOrdenMaterial.AddRange(LISTA_ORDEN_MATERIAL)
            Return OS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_DetalleDoc() As List(Of e_DetalleDocumento)
        Try
            LISTA_DETALLEDOCUMENTO = New List(Of e_DetalleDocumento)
            For Each oe As e_OrdenVentaMaterial In OV.lstOrdenComercialMaterial
                DETALLEDOCUMENTO = New e_DetalleDocumento
                With DETALLEDOCUMENTO
                    .TipoOperacion = "I"
                    .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                    .IdSucursal = gs_PrefijoIdSucursal
                    .PrefijoID = gs_PrefijoIdSucursal
                    .IdMaterialServicio = oe.IdMaterial
                    .IdTipoUnidadMedida = oe.IdTipoUnidadMedida
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .CodigoMaterialServicio = oe.Codigo
                    .Cantidad = oe.Cantidad
                    .IndGravado = oe.IndImpuesto
                    .IndServicioMaterial = "M"
                    .Precio = oe.PrecioUnitario
                    .Total = oe.PrecioTotal
                    .PrecioUnitarioSinImp = Math.Round(IIf(oe.IndImpuesto, (oe.PrecioUnitario - oe.Dscto) / (1 + mdblIGV), oe.PrecioUnitario - oe.Dscto), 4, MidpointRounding.AwayFromZero)
                    .UsuarioCreacion = gUsuarioSGI.Id
                End With
                LISTA_DETALLEDOCUMENTO.Add(DETALLEDOCUMENTO)
            Next
            Return LISTA_DETALLEDOCUMENTO
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_OrdDocumento() As List(Of e_Orden_Documento)
        Try
            oeOrdDocumento = New e_Orden_Documento
            loOrdDocumento = New List(Of e_Orden_Documento)
            With oeOrdDocumento
                .IdOrden = OV.Id
                .TipoOrden = 2
                .TipoOperacion = "I"
                .TipoExistencia = 1
                .UsuarioCreacion = gUsuarioSGI.Id
                loOrdDocumento.Add(oeOrdDocumento)
            End With
            Return loOrdDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

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

        'Cargar Producto
        LISTA_MATERIAL = dMATERIAL.Listar(New e_Material With {.TipoOperacion = "C", .Activo = True})
        LISTA_MATERIAL = LISTA_MATERIAL.Where(Function(it) it.Id = IdMaterial_Combustible).ToList
        For Each Item As e_Material In LISTA_MATERIAL
            PRODUCTO = Item
        Next
        decPrecio.Value = PRODUCTO.Precio
        decDescuento.Value = fc_ObtenerDescuento(cbgCliente.Value, IdMaterial_Combustible, sw_TipoPago)
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
        Try
            sw_Lado = Lado
            ValidarSurtidor() : PaintBotones("Lado")
        Catch ex As Exception
            Throw ex
        End Try
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
                .IdDocumento = MOVIMIENTODOCUMENTO.Id.Trim
                .IdTipoDocumento = MOVIMIENTODOCUMENTO.IdTipoDocumento
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

    Private Function fc_LlenarVenta() As e_Venta
        Try
            oeVenta = New e_Venta
            With oeVenta
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .PrefijoID = gs_PrefijoIdSucursal
                .Gravado = Math.Round(decSubTotal.Value, 2)
                .IGV = Math.Round(decImpuesto.Value, 2)
                .IdTipoPago = sw_TipoPago
                .Glosa = txtGlosa.Text
                .IdTipoVenta = "1CH000036"
                .IndCliente = 2
                '.u = gUsuarioSGI.Id
                .TipoOperacion = "I"
                '.IdVendedorTrabajador = cboVendedor.Value
            End With
            Return oeVenta
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


    'Private Sub cbgCliente_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cbgCliente.EditorButtonClick
    '    Try
    '        If txtEstado.Text = "TERMINADO" Or txtEstado.Text = "ATENDIDO PARCIALMENTE" Or txtEstado.Text = "ATENDIDO" Then
    '            ORDENVENTA.UsuarioCrea = gUsuarioSGI.Id
    '            ORDENVENTA.lstOrdenComercialMaterial.AddRange(loOrdenComercialMaterial)
    '            ORDENVENTA.Guardar(oeOrdenComercial)
    '            MsgBox("Se actualizó la Orden para el Vendedor: " & cboVendedor.Text, MsgBoxStyle.Information, "EOS")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End Try

    'End Sub

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
End Class