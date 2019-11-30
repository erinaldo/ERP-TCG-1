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

    Private olEstacionServicio As l_EstacionServicio
    Private sw_Documento As String
    Private sw_TipoPago As String
    Private sw_Lado As String
    Private sw_Combustible As String
    Private IdMonedaSoles As String
    Private TipoCambio As Double
    Private FechaOrden As Date

    Private oeOrdenComercial As e_OrdenVenta
    Private olOrdenComercial As l_OrdenVenta

    Private oeOrdenComercialMaterial As e_OrdenVentaMaterial
    Private olOrdenComercialMaterial As l_OrdenVentaMaterial
    Private loOrdenComercialMaterial As List(Of e_OrdenVentaMaterial)

    Private oeAlmMaterial As e_Material
    Private olAlmMaterial As l_MaterialAlmacen
    Private loAlmMaterial As List(Of e_Material)

    Private oeOrdenSalida As e_Orden
    Private olOrdenSalida As l_Orden
    Private loOrdenSalida As List(Of e_Orden)

    Private oeDetalleOrden As e_OrdenMaterial
    Private olDetalleOrden As l_OrdenMaterial
    'Private loDetalleOrden As List(Of e_OrdenMaterial)
    Private loDetalleOrdenSalida As List(Of e_OrdenMaterial)

    Private oeInventario As e_Inventario
    Private loInventario As List(Of e_Inventario)
    Private oeMovimientoInventario As e_RegistroInventario

    Private oeCombo As e_Combo
    Private olCombo As l_Combo
    Private loEmpresa As List(Of e_Empresa)
    Private loEmpresaCliente As List(Of e_Empresa)

    ''Carga mis Detalles Combos y Grillas
    Dim ds As Data.DataSet
    Dim ListLugar As List(Of e_Combo)
    ''Cargamos a los Vendedores
    Dim ListVendedores As List(Of e_Combo)

    Private oeVenta As e_Venta
    Private olVenta As l_Venta

    Private oeDocumento As e_MovimientoDocumento
    Private olDocumento As l_MovimientoDocumento
    Private oeDetDocumento As e_DetalleDocumento
    Private loDetDocumento As List(Of e_DetalleDocumento)
    Private oeOrdDocumento As e_Orden_Documento
    Private olOrdDocumento As l_Orden_Documento
    Private loOrdDocumento As List(Of e_Orden_Documento)

    Private oeCtaCtble As e_CuentaContable
    Private olCtaCtable As l_CuentaContable
    Private loCtaCtble As List(Of e_CuentaContable)

    Private DTReferencia As Data.DataTable
    Private dtAux As Data.DataTable

    Private oeReferencia As e_AsientoModelo_Referencia
    Private olReferencia As l_AsientoModelo_Referencia
    Private loReferencia As List(Of e_AsientoModelo_Referencia)

    'Private oeSaldoCtaCte As e_SaldoCuentaCorriente, olSaldoCtaCte As l_SaldoCuentaCorriente, leSaldoCtaCte As List(Of e_SaldoCuentaCorriente)
    Private oeTDDato As e_TablaDinamica_Dato, olTDDato As l_TablaDinamica_Dato, leTipoMovCtaCte As List(Of e_TablaDinamica_Dato)
    Private oeEstado As e_EstadoOrden, olEstado As l_EstadoOrden, leEstado As List(Of e_EstadoOrden)

    Private mdblCantidadPrecio As Double = 0
    Private mdblIGV As Double = gfc_ParametroValor("IGV")
    Private mstrIdCuentaContable As String = ""

    Private Const ls_NotaCredito As String = "NOTA DE CREDITO"
    Private ls_IdProv1 As String = "", ls_IdProv2 As String = "", ls_EstadoGenerado As String = ""
    Private ejecuta As Integer = 0

    Private oeEmpresa As e_Empresa
    Private olEmpresa As l_Empresa
    'Private loEmpresa As List(Of e_Empresa)

    Dim oeTipoPago As New e_TipoPago
    Dim olTipoPago As New l_TipoPago
    Dim llTipoPago As New List(Of e_TipoPago)

    Private indFacturaBoleta As Integer = 0
    Private DNI As String = "1CIX00000000000225"
    Private Ruc As String = "1CIX00000000000229"

    Private oeCliente As e_Cliente
    Private olCliente As l_Cliente

    Private oeTipoDoc As e_TipoDocumento
    Private olTipoDoc As l_TipoDocumento
    Private oeMoneda As e_Moneda

    Private oeAsientoModelo As e_AsientoModelo
    Private olAsientoModelo As l_AsientoModelo
    Private loAsientoModelo As List(Of e_AsientoModelo)
#End Region

#Region "Eventos"

    Private Sub frm_EstacionServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            olEstacionServicio = New l_EstacionServicio
            'Me.UltraGrid1.DataSource = olEstacionServicio.mt_Listar(New e_EstacionServicio With {.TipoOperacion = "N"})
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_EstacionServicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_EstacionServicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

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
                btnDB5.Appearance.BackColor = Color.White
                btnG84.Appearance.BackColor = Color.White
                btnG90.Appearance.BackColor = Color.White
                btnG95.Appearance.BackColor = Color.White

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
            mt_ControlBotoneria()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            'gmt_MostrarTabs(1, ficOrdenComercial, 1)
            mt_Inicializar()
            Operacion = "Nuevo"
            mt_ControlBotoneria()
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
        oeDocumento = New e_MovimientoDocumento
        oeOrdenComercial = New e_OrdenVenta
        oeOrdenComercialMaterial = New e_OrdenVentaMaterial
        loOrdenComercialMaterial = New List(Of e_OrdenVentaMaterial)
        'griOrdenComercialMaterial.DataSource = loOrdenComercialMaterial
        oeAlmMaterial = New e_Material
        loAlmMaterial = New List(Of e_Material)
        'griAlmacenMaterial.DataSource = loAlmMaterial
        loEmpresa = New List(Of e_Empresa)
        cbgCliente.DataSource = loEmpresa
        cbgCliente.Text = String.Empty
        loOrdenSalida = New List(Of e_Orden)
        'griOrdenSalida.DataSource = loOrdenSalida
        loDetalleOrdenSalida = New List(Of e_OrdenMaterial)
        'griDetalleOrden.DataSource = loDetalleOrdenSalida
        'dtpFecha.Value = Date.Now
        'dtpFechaPago.Value = Date.Now
        decSubTotal.Value = 0
        decImpuesto.Value = 0
        decTotal.Value = 0
        'txtOrden.Text = String.Empty
        'txtEstado.Text = "POR GENERAR"
        'txtGlosa.Text = String.Empty
        'cmbMoneda.SelectedIndex = 0
        'txtMaterial.Text = String.Empty
        'gbeMateriales.Visible = True
        'cboTipoPago.SelectedIndex = 0
        cmbTipoDocumento.Value = 0
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        txtGlosa.Text = String.Empty
        'ficDetalleOrdenComercial.Tabs(0).Selected = True
        cbDocumento.Enabled = True
        cbDocumento.Checked = False
        'grbDocAsoc.Enabled = False
        'mt_MenuDetalle(1, 1, 1, 1, 1)
        'Me.decTipoCambio.Value = gfc_TipoCambio(Me.dtpFecha.Value, True)
        'btnEmitirDoc.Enabled = False
        mstrIdCuentaContable = ""
        'txtCodSaldoCtaCte.Text = String.Empty
        'txtCodSaldoCtaCte.Tag = String.Empty
        'txtCodSaldoCtaCte.Appearance.ForeColor = Color.Black
        'btnCrearCtaCte.Enabled = False
        'chkFactSer.Checked = False '19-8
        'chkFacturado.Checked = False '19-8
        'btnFacturarSer.Enabled = False '19-08
        'btnBoletearSer.Enabled = False
        'chkFacturado.Enabled = False '19-8
        'btn_ActualizarDetOrden.Enabled = False

        ' Valores Default
        FechaOrden = ObtenerFechaServidor()
        IdMonedaSoles = ""
        TipoCambio = gfc_TipoCambio(FechaOrden, True)
    End Sub

    Private Sub mt_ControlBotoneria()
        'Select Case ficOrdenComercial.SelectedTab.Index
        '    Case 0
        '        If griOrdenComercial.Rows.Count > 0 Then
        '            gmt_ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
        '        Else
        '            gmt_ControlBoton(1, 1)
        '        End If
        '    Case 1
        If oeOrdenComercial.Estado = "GENERADO" Or oeOrdenComercial.Estado = "" Then
            gmt_ControlBoton(0, 0, 0, 1, 1)
        ElseIf oeOrdenComercial.Estado = "EVALUADA" And Operacion = "Editar" Then
            gmt_ControlBoton(0, 0, 0, 1, 1)
        Else
            gmt_ControlBoton(0, 0, 0, 0, 1)
        End If
        'End Select
    End Sub


    Private Sub mt_GeneraDocumento()
        Try
            oeDocumento = New e_MovimientoDocumento
            With oeDocumento
                .TipoOperacion = "I"
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .PrefijoID = gs_PrefijoIdSucursal
                .IdClienteProveedor = oeOrdenComercial.IdEmpresa
                .IdTipoDocumento = cmbTipoDocumento.Value
                .IdEstadoDocumento = "1CIX025"
                .IdPeriodo = ""
                '.CuentaContable = ""
                .IdMoneda = IdMonedaSoles
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
            oeCliente = New e_Cliente
            oeCliente.TipoClienteProveedor = 1
            oeCliente = olCliente.Obtener(oeCliente)

            oeMoneda.Id = IdMonedaSoles 'Revisar

            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.TipoOperacion = ""
            oeTipoDoc.Id = cmbTipoDocumento.Value
            oeTipoDoc = olTipoDoc.Obtener(oeTipoDoc)

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                mt_ListarCtaCtble(frm.Año1.Año)

                Dim oeDoc As New e_MovimientoDocumento
                oeDoc.Id = oeDocumento.Id : oeDoc.CargaCompleta = True
                oeDoc = olDocumento.Obtener(oeDoc)

                oeDoc.IdPeriodo = frm.cboMes.Value : oeDoc.Ejercicio = frm.Año1.Año
                oeDoc.Venta.TipoDoc = oeTipoDoc : oeDoc.Venta.Cliente = oeCliente : oeDoc.Venta.Moneda = oeMoneda

                oeAsientoModelo = New e_AsientoModelo
                oeAsientoModelo.Equivale = 1 : oeAsientoModelo.IdMoneda = oeMoneda.Id

                If loAsientoModelo.Contains(oeAsientoModelo) Then
                    oeAsientoModelo = loAsientoModelo.Item(loAsientoModelo.IndexOf(oeAsientoModelo))
                    oeAsientoModelo.TipoOperacion = ""
                    oeAsientoModelo.Ejercicio = oeDoc.FechaEmision.Year
                    oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)
                    For Each _oeDet In oeAsientoModelo.leDetalle
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
            If olOrdenComercial.Guardar(oeOrdenComercial) Then
                If cbDocumento.Checked = True AndAlso cmbTipoDocumento.Text <> "" Then
                    If oeDocumento.Id.Trim <> "" Then
                        Select Case MessageBox.Show("¿Desea Emitir el Documento?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                            Case Windows.Forms.DialogResult.Yes
                                mt_EmitirDocumento(False)
                        End Select
                        MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
                        oeDocumento = New e_MovimientoDocumento
                        oeDocumento.TipoOperacion = ""
                        oeDocumento.Id = oeOrdenComercial.oeDocumento.Id
                        oeDocumento = olDocumento.Obtener(oeDocumento)
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

    Public Function fc_LlenaObjeto() As Boolean
        Try
            With oeOrdenComercial
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
                        If oeDocumento.Id = "" Then
                            If Not fc_EmitirDocumento() Then
                                Return False
                            End If
                        End If
                    Case "Atender"
                        If loOrdenComercialMaterial.Sum(Function(i) i.CantidadAtender) = 0 Then Throw New Exception("Cantidad a Atender no Puede ser 0.")
                        .TipoOperacion = "T"
                        .oeOrdenSalida = New e_Orden
                        .oeOrdenSalida = fc_GenerarOrdenSalida()
                        .oeOrdenSalida.IdOrdenDocumento = fc_OrdenDocumento().Id
                        For Each oe As e_OrdenVentaMaterial In loOrdenComercialMaterial
                            If oe.CantidadPendiente - oe.CantidadAtender >= 0 Then
                                oe.CantidadPendiente = oe.CantidadPendiente - oe.CantidadAtender
                                oe.CantidadAtender = 0
                            End If
                        Next
                        If loOrdenComercialMaterial.Sum(Function(i) i.CantidadPendiente) = 0 Then
                            .IdEstado = "1CIX004"
                        Else
                            .IdEstado = "1CIX005"
                        End If
                End Select
                .lstOrdenComercialMaterial = New List(Of e_OrdenVentaMaterial)
                .lstOrdenComercialMaterial.AddRange(loOrdenComercialMaterial)
                .Fecha = ObtenerFechaServidor()
                .IdMoneda = "" 'Revisar
                .IdTipoPago = sw_TipoPago
                .Glosa = txtGlosa.Value
                .Total = decTotal.Value
                .SubTotal = decSubTotal.Value
                .Impuesto = decImpuesto.Value
                .TipoCompra = 0
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ActualizarTipoPago()
        Try
            Dim oe As New e_Combo
            oe.Id = sw_TipoPago
            oe.Tipo = 0
            If TipoPagoPublic.Contains(oe) Then
                oe = TipoPagoPublic.Item(TipoPagoPublic.IndexOf(oe))
                'dtpFechaPago.Value = dtpFecha.Value.AddDays(CInt(oe.Descripcion))
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
                oeOrdenComercial.oeDocumento = oeDocumento
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
            oeOrdenSalida = New e_Orden
            With oeOrdenSalida
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .Glosa = cmbTipoDocumento.Text & " " & txtSerie.Text & " - " & txtNumero.Text
                .TipoOperacion = "I"
                .TipoReferencia = "ORDEN VENTA"
                .Referencia = oeOrdenComercial.OrdenComercial
                .TipoCambio = TipoCambioCompraVenta(ObtenerFechaServidor) ' decTipoCambio.Value
                .IdEmpresa = oeOrdenComercial.IdEmpresa
                .IdMovimientoInventario = "1CIX006"
                .IdMoneda = oeOrdenComercial.IdMoneda
                .IdEstadoOrden = "1CIX025"
                .UsuarioCreacion = gUsuarioSGI.Id
                .lstOrdenMaterial = New List(Of e_OrdenMaterial)
                .lstInventario = New List(Of e_Inventario)
            End With
            loDetalleOrdenSalida = New List(Of e_OrdenMaterial)
            For Each oe As e_OrdenVentaMaterial In loOrdenComercialMaterial.Where(Function(i) i.CantidadAtender > 0).ToList
                oeDetalleOrden = New e_OrdenMaterial
                With oeDetalleOrden
                    .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                    .IdSucursal = gs_PrefijoIdSucursal
                    .UsuarioCreacion = oeOrdenSalida.UsuarioCreacion
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .IdMaterial = oe.IdMaterial
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .CantidadMaterial = oe.CantidadAtender
                    .PrecioUnitario = oe.PrecioUnitario
                    '.PrecioTotal = Math.Round(.PrecioUnitario * .CantidadMaterial, 4)
                End With
                loDetalleOrdenSalida.Add(oeDetalleOrden)
            Next
            oeOrdenSalida.Total = loDetalleOrdenSalida.Sum(Function(i) i.PrecioUnitario * i.CantidadMaterial)
            oeOrdenSalida.lstOrdenMaterial.AddRange(loDetalleOrdenSalida)
            Return oeOrdenSalida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Private Sub cbgClienteAlterno_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cbgClienteAlterno.InitializeLayout
    '    Me.cbgClienteAlterno.ValueMember = "Id"
    '    Me.cbgClienteAlterno.DisplayMember = "Nombre"
    '    With cbgClienteAlterno.DisplayLayout.Bands(0)
    '        .Columns("Id").Hidden = True
    '        .Columns("TipoEmpresa").Hidden = True
    '        .Columns("Codigo").Hidden = True
    '        .Columns("IdDireccionTanqueo").Hidden = True
    '        .Columns("Morosidad").Hidden = True
    '        .Columns("Credito").Hidden = True
    '        .Columns("IndNivelComercial").Hidden = True
    '        .Columns("Moneda").Hidden = True
    '        .Columns("IndClasificacion").Hidden = True
    '        .Columns("UsuarioCreacion").Hidden = True
    '        .Columns("IndCategoriaEmpresaSGI").Hidden = True
    '        '.Columns("Activo").Hidden = True
    '        .Columns("Ruc").Header.Caption = "N° RUC"
    '        .Columns("Ruc").Width = 80
    '        .Columns("Nombre").Width = 250
    '    End With
    'End Sub

    Private Function fc_DetalleDoc() As List(Of e_DetalleDocumento)
        Try
            loDetDocumento = New List(Of e_DetalleDocumento)
            For Each oe As e_OrdenVentaMaterial In loOrdenComercialMaterial
                oeDetDocumento = New e_DetalleDocumento
                With oeDetDocumento
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
                loDetDocumento.Add(oeDetDocumento)
            Next
            Return loDetDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_OrdDocumento() As List(Of e_Orden_Documento)
        Try
            oeOrdDocumento = New e_Orden_Documento
            loOrdDocumento = New List(Of e_Orden_Documento)
            With oeOrdDocumento
                .IdOrden = oeOrdenComercial.Id
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
            .Columns("Ruc").Width = 80
            .Columns("Nombre").Width = 250
        End With
    End Sub

    'Private Sub cboTipoPago_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoPago.ValueChanged
    '    Try
    '        ActualizarTipoPago()
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    Private Sub btnDB5_Click(sender As Object, e As EventArgs) Handles btnDB5.Click

    End Sub

    Private Sub btnG84_Click(sender As Object, e As EventArgs) Handles btnG84.Click

    End Sub

    Private Sub btnG90_Click(sender As Object, e As EventArgs) Handles btnG90.Click

    End Sub

    Private Sub btnG95_Click(sender As Object, e As EventArgs) Handles btnG95.Click

    End Sub

    Private Sub btnLado1_Click(sender As Object, e As EventArgs) Handles btnLado1.Click
        With btnLado1
            sw_Lado = .Text
            ValidarSurtidor() : PaintBotones("Lado") : .Appearance.BackColor = Color.Green
        End With
    End Sub

    Private Sub btnLado2_Click(sender As Object, e As EventArgs) Handles btnLado2.Click
        With btnLado2
            sw_Lado = .Text
            ValidarSurtidor() : PaintBotones("Lado") : .Appearance.BackColor = Color.Green
        End With
    End Sub

    Private Sub btnLado3_Click(sender As Object, e As EventArgs) Handles btnLado3.Click
        With btnLado3
            sw_Lado = .Text
            ValidarSurtidor() : PaintBotones("Lado") : .Appearance.BackColor = Color.Green
        End With
    End Sub

    Private Sub btnLado4_Click(sender As Object, e As EventArgs) Handles btnLado4.Click
        With btnLado4
            sw_Lado = .Text
            ValidarSurtidor() : PaintBotones("Lado") : .Appearance.BackColor = Color.Green
        End With
    End Sub

    Private Sub btnLado5_Click(sender As Object, e As EventArgs) Handles btnLado5.Click
        With btnLado5
            sw_Lado = .Text
            ValidarSurtidor() : PaintBotones("Lado") : .Appearance.BackColor = Color.Green
        End With
    End Sub

    Private Sub btnLado6_Click(sender As Object, e As EventArgs) Handles btnLado6.Click
        With btnLado6
            sw_Lado = .Text
            ValidarSurtidor() : PaintBotones("Lado") : .Appearance.BackColor = Color.Green
        End With
    End Sub

    Private Sub btnContado_Click(sender As Object, e As EventArgs) Handles btnContado.Click
        sw_TipoPago = ""
    End Sub

    Private Sub btnCredito_Click(sender As Object, e As EventArgs) Handles btnCredito.Click
        sw_TipoPago = ""
    End Sub

    Private Function fc_OrdenDocumento() As e_Orden_Documento
        Try
            oeOrdDocumento = New e_Orden_Documento
            With oeOrdDocumento
                .IdDocumento = oeDocumento.Id.Trim
                .IdTipoDocumento = oeDocumento.IdTipoDocumento
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

    Private Function fc_AnularOrdenVenta() As Boolean
        'Try
        '    oeOrdenComercial = New e_OrdenVenta
        '    oeOrdenComercial.Id = griOrdenComercial.ActiveRow.Cells("Id").Value
        '    oeOrdenComercial = olOrdenComercial.Obtener(oeOrdenComercial)
        '    oeOrdenComercial.TipoOperacion = "X"

        '    'oeOrdDocumento = New e_Orden_Documento
        '    'oeOrdDocumento.IdOrden = oeOrdenComercial.Id
        '    'oeOrdDocumento.TipoOrden = 2
        '    'oeOrdDocumento = olOrdDocumento.Obtener(oeOrdDocumento)
        '    'If oeOrdDocumento.Id <> "" Then Throw New Exception("Cuenta con un documento asociado, no es posible anularla")
        '    If olOrdenComercial.Guardar(oeOrdenComercial) Then
        '        Return True
        '    End If
        'Catch ex As Exception
        '    Throw ex
        'End Try
        'Return False
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

End Class