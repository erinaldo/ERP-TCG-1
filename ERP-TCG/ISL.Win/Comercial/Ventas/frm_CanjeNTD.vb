Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win.UltraWinGrid

'' Add by Cess 22/02
Public Class frm_CanjeNTD
    Inherits frm_MenuPadre

#Region "Inicializacion del Formulario"

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Shared instancia As frm_CanjeNTD = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_CanjeNTD()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Private dDetalleDocumento As New l_DetalleDocumento
    Private ListaDetalleSeleccionados As New List(Of e_DetalleDocumento)

    Private dMovimientoDocumento As New l_MovimientoDocumento
    Private ListaNotasDespachoSelecionadas As New List(Of e_MovimientoDocumento)
    Private ListaNotasDespacho As New List(Of e_MovimientoDocumento)
    Private ListaOtrosDocumentos As New List(Of e_MovimientoDocumento)
    Private Documento As New e_MovimientoDocumento
    Private DocumentoOrigen As New e_MovimientoDocumento
    Private DocumentoGenerado As New e_MovimientoDocumento

    Private oe_Venta As New e_Venta
    Private ol_Venta As New l_Venta

    Private oe_Cliente As New e_Cliente
    Private ol_Cliente As New l_Cliente

    Private oe_TipoDoc As New e_TipoDocumento
    Private ol_TipoDoc As New l_TipoDocumento
    Private oe_Moneda As New e_Moneda


    Private oe_RefAsoc As New e_ReferenciaAsociada
    Private ol_RefAsoc As New l_ReferenciaAsociada

    Dim oeTipoPago As New e_TipoPago
    Dim olTipoPago As New l_TipoPago
    Dim llTipoPago As New List(Of e_TipoPago)

    Private oeCtaCtble As New e_CuentaContable
    Private olCtaCtable As New l_CuentaContable
    Private loCtaCtble As New List(Of e_CuentaContable)

    Private DTReferencia As Data.DataTable
    Private dtAux As Data.DataTable

    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)

    Private oeCombo As New e_Combo
    Private olCombo As New l_Combo

    Private oeEmpresa As New e_Empresa
    Private olEmpresa As New l_Empresa
    Private loEmpresa As New List(Of e_Empresa)
    Private loEmpresaCliente As New List(Of e_Empresa)

    Private oeAsientoModelo As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)

    Private oeCuentaCorriente As New e_CuentaCorriente
    Private olCuentaCorriente As New l_CuentaCorriente

    Private oeServCtaCtble As New e_ServicioCuentaContable
    Private olServCtaCtble As New l_ServicioCuentaContable
    Private leServCtaCtble As New List(Of e_ServicioCuentaContable)

    Private mdblIGV As Double = gfc_ParametroValor("IGV")

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            mt_Inicializar()
            mt_Listar()
            Operacion = "Inicializa"
            mt_ControlBotoneria()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If fc_Guardar() Then
                gmt_MostrarTabs(0, fic_Canje, 2)
                Consultar(True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    Guardar()
                Case Windows.Forms.DialogResult.No
                    gmt_MostrarTabs(0, fic_Canje, 2)
                    Consultar(True)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If udg_Documentos.Rows.Count = 0 Then
                Exportar_Excel(udg_Documentos, cmb_ClienteBuscado.Text & " . Notas de Despacho")
            End If
            If udg_DocumentosCanjeados.Rows.Count = 0 Then
                Exportar_Excel(udg_DocumentosCanjeados, cmb_ClienteBuscado.Text & " . Otros Documentos")
            End If
            MyBase.Exportar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_AsientoModelo()
        Try
            oeReferencia = New e_AsientoModelo_Referencia
            loReferencia = New List(Of e_AsientoModelo_Referencia)
            oeReferencia.TipoOperacion = "N"
            'oeReferencia.IdReferencia = ls_IdActividadNegocio
            oeReferencia.Activo = True
            loReferencia = olReferencia.Listar(oeReferencia)
            If loReferencia.Count > 0 Then DTReferencia = gfc_GeneraDTRef(loReferencia)
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

    'Private Sub mt_ObtenerAsiento(IdMoneda As String)
    '    Try
    '        dtAux = New Data.DataTable
    '        Dim _rwAux() As Data.DataRow
    '        Dim cadSQL As String = String.Empty
    '        Dim _TipoDocAux As String = String.Empty
    '        cadSQL = "TipoRef1 = 5 AND IdRef1 = '" & IdMoneda & "'"
    '        _rwAux = DTReferencia.Select(cadSQL, "")
    '        If _rwAux.Count = 0 Then Throw New Exception("No existe configuración contable para Ventas.")
    '        dtAux = _rwAux.CopyToDataTable
    '        oeAsientoModelo = New e_AsientoModelo
    '        oeAsientoModelo.TipoOperacion = "" : oeAsientoModelo.Activo = True : oeAsientoModelo.CargaCompleta = True : oeAsientoModelo.Cuentas = -1
    '        oeAsientoModelo.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
    '        oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)
    '        For Each oe As e_DetalleAsientoModelo In oeAsientoModelo.leDetalle
    '            oeCtaCtble = New e_CuentaContable
    '            oeCtaCtble.Cuenta = oe.Cuenta : oeCtaCtble.TipoBusca = 2
    '            oeEmpresa = New e_Empresa
    '            Dim olEmpresa As New l_Empresa
    '            oeEmpresa.TipoOperacion = "CLI"
    '            oeEmpresa.Id = oeOrdenComercial.IdEmpresa
    '            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
    '            If Microsoft.VisualBasic.Left(oe.Cuenta.Trim, 2) = "12" Then '20-07
    '                If oeEmpresa.IndRelacionada Then
    '                    oeCtaCtble.Cuenta = Replace(oe.Cuenta, "2", "3", 1, 1)
    '                End If
    '            End If
    '            If loCtaCtble.Contains(oeCtaCtble) Then
    '                oe.oeCtaCtble = loCtaCtble.Item(loCtaCtble.IndexOf(oeCtaCtble))
    '            End If
    '        Next
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub mt_CargarCombos()

        Dim olMoneda As New l_Moneda
        oe_Moneda = New e_Moneda
        oe_Moneda.Activo = True
        oe_Moneda.TipoOperacion = "1"
        Dim loMoneda = olMoneda.Listar(oe_Moneda)
        gmt_ComboEspecifico(cmbMoneda, loMoneda, 0, "Nombre")

        oeTipoPago = New e_TipoPago
        oeTipoPago.Activo = True
        llTipoPago = olTipoPago.Listar(oeTipoPago)

        oeTipoPago.Activo = True
        LlenarComboMaestro(cboTipoPago, olTipoPago.Listar(oeTipoPago), 0)

        oe_TipoDoc = New e_TipoDocumento
        oe_TipoDoc.TipoOperacion = "H"
        gmt_ComboEspecifico(cmbTipoDocumento, ol_TipoDoc.Listar(oe_TipoDoc), -1)

        oeAsientoModelo = New e_AsientoModelo
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = "1PY000000005"
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeServCtaCtble = New e_ServicioCuentaContable
        oeServCtaCtble.TipoOperacion = "V" : oeServCtaCtble.Activo = True : oeServCtaCtble.Ejercicio = Date.Now.Year
        leServCtaCtble = olServCtaCtble.Listar(oeServCtaCtble)

        oeEmpresa = New e_Empresa
        olEmpresa = New l_Empresa
        loEmpresaCliente = New List(Of e_Empresa)

        cmb_Cliente.DataSource = loEmpresaCliente

    End Sub

    Private Sub mt_ControlBotoneria()
        Select Case fic_Canje.SelectedTab.Index
            Case 0
                gmt_ControlBoton(1, 0, 0, 0, 0, 0, 0, 1)
            Case 1
                gmt_ControlBoton(0, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub mt_InicializaLogicas()
        dMovimientoDocumento = New l_MovimientoDocumento
        dDetalleDocumento = New l_DetalleDocumento
        ol_RefAsoc = New l_ReferenciaAsociada
        olTipoPago = New l_TipoPago
        ol_Venta = New l_Venta
        ol_Cliente = New l_Cliente
        olAsientoModelo = New l_AsientoModelo
        olReferencia = New l_AsientoModelo_Referencia
        olServCtaCtble = New l_ServicioCuentaContable
        ol_TipoDoc = New l_TipoDocumento
        olCtaCtable = New l_CuentaContable
    End Sub

    Private Sub mt_Inicializar()
        dtp_FechaEmision.Value = Date.Now
        txtSerie.Text = String.Empty
        tsb_Emitir.Enabled = False
        tsb_Eliminar.Enabled = False
        tsb_Imprimir.Enabled = False
    End Sub

    Private Sub mt_Listar()
        Try
            If cmb_ClienteBuscado.Value = "" Then Throw New Exception("Debe seleccionar un CLIENTE")
            Documento = New e_MovimientoDocumento
            Documento.IdClienteProveedor = cmb_ClienteBuscado.Value
            Documento.FechaInicio = dtp_FechaDesde.Value
            Documento.FechaFinal = dtp_FechaHasta.Value

            '' Lista de Documentos
            Documento.TipoOperacion = "CND"
            ListaNotasDespacho = dMovimientoDocumento.Listar(Documento)
            bso_Documento.DataSource = ListaNotasDespacho
            udg_Documentos.DataBind()

            '' Lista de Documentos
            Documento.TipoOperacion = "CNF"
            ListaOtrosDocumentos = dMovimientoDocumento.Listar(Documento)
            bso_DocumentosCanjeados.DataSource = ListaOtrosDocumentos
            udg_DocumentosCanjeados.DataBind()

            For Each fila As UltraGridRow In udg_Documentos.Rows
                Select Case fila.Cells("EstadoDocumento").Value
                    Case "GENERADA" : fila.CellAppearance.BackColor = Color.LightBlue
                    Case "EMITIDA" : fila.CellAppearance.BackColor = Color.LightGreen
                    Case "ANULADO" : fila.CellAppearance.BackColor = Color.LightGray
                End Select
            Next

            For Each fila As UltraGridRow In udg_DocumentosCanjeados.Rows
                Select Case fila.Cells("EstadoDocumento").Value
                    Case "GENERADA" : fila.CellAppearance.BackColor = Color.LightBlue
                    Case "EMITIDA" : fila.CellAppearance.BackColor = Color.LightGreen
                    Case "ANULADO" : fila.CellAppearance.BackColor = Color.LightGray
                End Select
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub txtNumero_Leave(sender As Object, e As EventArgs) Handles txt_Numero.Leave
        If txt_Numero.Text <> "" Then txt_Numero.Text = FormatoDocumento(txt_Numero.Text, 8)
    End Sub

    Private Sub frm_CanjeND_F_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        mt_ControlBotoneria()
        dtp_FechaDesde.Value = Date.Now.AddDays(-15)
    End Sub

    Private Sub frm_CanjeND_F_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            mt_InicializaLogicas()
            mt_CargarCombos()
            mt_AsientoModelo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsb_Canjear.Click
        mt_CanjearDocumentos()
    End Sub

    Private Sub mt_CanjearDocumentos()
        Try
            Dim Seleccionados As Integer = 0

            '' Valida
            If udg_Documentos.Rows.Count = 0 Then Exit Sub
            udg_Documentos.UpdateData()

            '' Inicializa
            ListaNotasDespachoSelecionadas = New List(Of e_MovimientoDocumento)
            ListaDetalleSeleccionados = New List(Of e_DetalleDocumento)

            '' Agregar los documentos seleccionados
            For Each Documento In ListaNotasDespacho
                If Documento.IndAnexo = True Then
                    Seleccionados += 1
                    ListaNotasDespachoSelecionadas.Add(Documento)
                    Dim ListaDetalle As New List(Of e_DetalleDocumento)
                    ListaDetalle = dDetalleDocumento.Listar(New e_DetalleDocumento With {.TipoOperacion = "CSS", .IdMovimientoDocumento = Documento.Id, .IndServicioMaterial = "M"})
                    For Each Item In ListaDetalle
                        Item.Id = ""
                        Item.IdOperacionDetalle = Documento.Id 'Guarda el IDDocumento de origen
                        Item.IdMovimientoDocumento = ""
                        Item.Total = Item.Cantidad * Item.Precio
                        ListaDetalleSeleccionados.Add(Item)
                    Next
                End If
            Next

            '' Agrega los detalles de cada documento seleccionado
            'If ListaDocumentoSeleccionados.Count > 0 Then
            '    For Each Doc In ListaDocumentoSeleccionados
            '        Dim ListaDetalle As New List(Of e_DetalleDocumento)
            '        ListaDetalle = dDetalleDocumento.Listar(New e_DetalleDocumento With {.TipoOperacion = "VEN", .IdMovimientoDocumento = Doc.Id, .IndServicioMaterial = "M"})
            '        For Each Item In ListaDetalle
            '            Item.Id = ""
            '            Item.IdOperacionDetalle = Doc.Id 'Guarda el IDDocumento de origen
            '            Item.IdMovimientoDocumento = ""
            '            Item.Total = Item.Cantidad * Item.Precio
            '            ListaDetalleSeleccionados.Add(Item)
            '        Next
            '    Next

            '' Muestra el documento que vamos a generar
            If Seleccionados > 0 Then
                gmt_MostrarTabs(1, fic_Canje, 1)
                mt_MostrarDocumento("")
                mt_ControlBotoneria()
                cmbTipoDocumento.Focus()
                bso_Detalle.DataSource = ListaDetalleSeleccionados
                udg_Detalles.DataBind()
                bso_DocumentosSeleccionados.DataSource = ListaNotasDespachoSelecionadas
                udg_DocumentosSeleccionados.DataBind()
                mt_CalcularTotalOrden()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Function fc_Agrupar_ListaDetalles(Lista As List(Of e_OrdenVentaMaterial)) As List(Of e_OrdenVentaMaterial)
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Function

    Private Sub cbgCliente_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cmb_Cliente.InitializeLayout
        Me.cmb_Cliente.ValueMember = "Id"
        Me.cmb_Cliente.DisplayMember = "Nombre"

        With cmb_Cliente.DisplayLayout.Bands(0)
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

    Private Sub cbgCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Cliente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Not String.IsNullOrEmpty(cmb_Cliente.Text.Trim) Then
                    gmt_ListarEmpresa("6", cmb_Cliente, String.Empty, False)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cbgCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_Cliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cmb_Cliente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cmb_ClienteBuscado_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cmb_ClienteBuscado.InitializeLayout
        Me.cmb_ClienteBuscado.ValueMember = "Id"
        Me.cmb_ClienteBuscado.DisplayMember = "Nombre"
        For Each Columna In cmb_ClienteBuscado.DisplayLayout.Bands(0).Columns
            Columna.Hidden = True
        Next

        With cmb_ClienteBuscado.DisplayLayout.Bands(0)
            .Columns("Ruc").Hidden = False
            .Columns("Nombre").Hidden = False
            .Columns("Ruc").Header.Caption = "N° RUC"
            .Columns("Ruc").Width = 80
            .Columns("Nombre").Width = 250
        End With
    End Sub

    Private Sub cmb_ClienteBuscado_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_ClienteBuscado.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Not String.IsNullOrEmpty(cmb_ClienteBuscado.Text.Trim) Then
                    gmt_ListarEmpresa("6", cmb_ClienteBuscado, String.Empty, False)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cmb_ClienteBuscado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_ClienteBuscado.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cmb_ClienteBuscado.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboTipoPago_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoPago.ValueChanged
        Try
            ActualizarTipoPago()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub dtp_FechaEmision_ValueChanged(sender As Object, e As EventArgs) Handles dtp_FechaEmision.ValueChanged
        Me.decTipoCambio.Value = gfc_TipoCambio(dtp_FechaEmision.Value, True)
    End Sub

#End Region

#Region "Funciones"

    Private Sub ActualizarTipoPago()
        Try
            Dim oe As New e_Combo
            oe.Id = cboTipoPago.Value
            oe.Tipo = 0
            If TipoPagoPublic.Contains(oe) Then
                oe = TipoPagoPublic.Item(TipoPagoPublic.IndexOf(oe))
                dtpFechaPago.Value = dtp_FechaEmision.Value.AddDays(CInt(oe.Descripcion))
            Else
                Throw New Exception("No se Encuentra el Tipo de Pago. Verificar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_MostrarDocumento(IdDocumento As String)
        Try
            DocumentoOrigen = New e_MovimientoDocumento
            DocumentoGenerado = New e_MovimientoDocumento

            DocumentoOrigen = dMovimientoDocumento.Obtener(New e_MovimientoDocumento With {.Id = ListaNotasDespachoSelecionadas(0).Id})
            DocumentoGenerado = DocumentoOrigen.Clonar
            DocumentoGenerado.Id = String.Empty

            gmt_ListarEmpresa("6", cmb_Cliente, DocumentoGenerado.IdClienteProveedor, False)

            '' Controles
            cmb_Cliente.Value = DocumentoGenerado.IdClienteProveedor
            dtp_FechaEmision.Value = ObtenerFechaServidor()
            dtpFechaPago.Value = ObtenerFechaServidor()
            decTipoCambio.Value = gfc_TipoCambio(dtp_FechaEmision.Value, True)
            cboTipoPago.SelectedIndex = 0
            cmbMoneda.Value = "1CH01"

            mt_CalcularTotalOrden()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_LlenaObjeto()
        '1CH00001	ANULADO
        '1CH00014	GENERADA
        '1CH00008	EMITIDA
        Try
            Dim SubTotal As Double = 0, IGV As Double = 0, Total As Double = 0
            If cmb_Cliente.SelectedRow Is Nothing Then Throw New Exception("Seleccione Cliente")
            If cmbTipoDocumento.SelectedIndex = -1 Then Throw New Exception("Seleccione Tipo de Documento")
            gfc_ObtenerNumeroDoc(txtSerie.Text, cmbTipoDocumento.Value, 2) '@0001
            txt_Numero.Text = FormatoDocumento(CStr(gfc_ObtenerNumeroDoc(txtSerie.Text, cmbTipoDocumento.Value, 2)), 8) '@0001
            With DocumentoGenerado
                '' Cabecera
                .TipoOperacion = "I"
                .FechaEmision = dtp_FechaEmision.Value
                .FechaVencimiento = dtpFechaPago.Value
                .IdSucursal = gs_PrefijoIdSucursal
                .PrefijoID = gs_PrefijoIdSucursal
                .Serie = txtSerie.Text
                '.Numero = FormatoDocumento(CStr(gfc_ObtenerNumeroDoc(txtSerie.Text, cmbTipoDocumento.Value, 2)), 8) '@0001
                .Numero = txt_Numero.Text
                .IdEstadoDocumento = "1CH00014"
                .EstadoDocumento = "GENERADA"
                .IdTipoDocumento = cmbTipoDocumento.Value
                .IdPeriodo = ""
                .IdMoneda = "1CH01"
                .IdTipoPago = cboTipoPago.Value
                .Mac_PC_Local = MacPCLocal()
                .IdClienteProveedor = cmb_Cliente.Value
                .IndElectronico = True
                .Glosa = txt_Observacion.Text.Trim
                .lstDetalleDocumento = ListaDetalleSeleccionados
                ._Operador = 1
                '' Detalle
                For Each detalle In DocumentoGenerado.lstDetalleDocumento
                    With detalle
                        .TipoOperacion = "I"
                        .Id = String.Empty
                        .IdMovimientoDocumento = String.Empty
                        SubTotal += detalle.Subtotal
                        IGV += detalle.Igv
                        Total += detalle.Total
                    End With
                Next
                .SubTotal = SubTotal
                .IGV = IGV
                .Total = Total
                .Saldo = Total

                '' Datos Impresion
                .DatosImpresion = New e_MovimientoDocumento_Impresion
                .DatosImpresion.TipoOperacion = "I"
                .DatosImpresion.UsuarioCreacion = gUsuarioSGI.Id
                .DatosImpresion.FechaCreacion = Date.Now
                .DatosImpresion.UsuarioModifica = gUsuarioSGI.Id
                .DatosImpresion.FechaModificacion = Date.Now
                .DatosImpresion.IdEmpresaSistema = gs_IdClienteProveedorSistema.Trim
                .DatosImpresion.IdSucursalSistema = gs_IdSucursal
                .DatosImpresion.PrefijoID = gs_PrefijoIdSucursal
                .DatosImpresion.IdTipoDocumento = cmbTipoDocumento.Value
                .DatosImpresion.TipoDocumento = cmbTipoDocumento.Text
                .DatosImpresion.IdTurno = gfc_obtener_TurnoActivo.IdTurno
                .DatosImpresion.Turno = gfc_obtener_TurnoActivo.Turno
                .DatosImpresion.NombreClienteProveedor = cmb_Cliente.Text
                .DatosImpresion.IdDireccion = DocumentoOrigen.DatosImpresion.IdDireccion
                .DatosImpresion.Direccion = DocumentoOrigen.DatosImpresion.Direccion
                If DireccionClienteProveedorPublic.Where(Function(i) i.Descripcion = cmb_Cliente.Value).ToList.Count > 0 Then
                    oeCombo = DireccionClienteProveedorPublic.Where(Function(i) i.Descripcion = cmb_Cliente.Value)(0)
                    .DatosImpresion.IdDireccion = oeCombo.Id
                    .DatosImpresion.Direccion = oeCombo.Nombre
                Else
                    If cmbTipoDocumento.Value = "1CH000000026" Then
                        Throw New Exception("El Cliente Seleccionado no Tiene Direccion Principal")
                    End If
                End If
                .DatosImpresion.IdPiloto = DocumentoOrigen.DatosImpresion.IdPiloto
                .DatosImpresion.Piloto = DocumentoOrigen.DatosImpresion.Piloto
                .DatosImpresion.IdVechiculo = DocumentoOrigen.DatosImpresion.IdVechiculo
                .DatosImpresion.Placa = DocumentoOrigen.DatosImpresion.Placa
                .DatosImpresion.IdMedioPago = cboTipoPago.Value
                .DatosImpresion.MedioPago = cboTipoPago.Text
                .DatosImpresion.IdTrabajador = gUsuarioSGI.IdTrabajador
                .DatosImpresion.Trabajador = gUsuarioSGI.oePersona.NombreCompleto
                .DatosImpresion.MontoLetras = Conversiones.NumerosALetras.Ejecutar(Total, 2) & " SOLES"
                '.DatosImpresion.HashResumen = ""
                '.DatosImpresion.HashSunat = ""
                '.DatosImpresion.QRCode = ""
                '.DatosImpresion.Ruta = ""
                '.DatosImpresion.ValorAux1 = 0
                '.DatosImpresion.ValorAux2 = 0
                '.DatosImpresion.ValorAux3 = 0
                '.DatosImpresion.TextoAux1 = sw_Lado
                '.DatosImpresion.TextoAux2 = ""
                '.DatosImpresion.TextoAux3 = ""

                '' Venta
                .Venta = New e_Venta
                .Venta = fc_LlenarVenta()
                .IdUsuarioCrea = gUsuarioSGI.Id

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_LlenarVenta() As e_Venta
        Try
            oe_Venta = New e_Venta
            With oe_Venta
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .PrefijoID = gs_PrefijoIdSucursal
                .Gravado = Math.Round(DocumentoGenerado.SubTotal, 2)
                .IGV = Math.Round(Documento.IGV, 2)
                .IdTipoPago = cboTipoPago.Value
                .Glosa = String.Empty
                .IdTipoVenta = "1CH000036"
                .IndCliente = 2
                '.u = gUsuarioSGI.Id
                .TipoOperacion = "I"
                '.IdVendedorTrabajador = cboVendedor.Value
            End With
            Return oe_Venta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_ValidaCanje(IdNota As String) As Boolean
        Try
            oe_RefAsoc = New e_ReferenciaAsociada
            oe_RefAsoc.TipoOperacion = "1"
            oe_RefAsoc.IdTablaPrincipal = IdNota
            oe_RefAsoc.TipoRelacion = 0
            oe_RefAsoc = ol_RefAsoc.Obtener(oe_RefAsoc)
            If oe_RefAsoc.IdTablaAsociada.Trim <> "" Then
                Throw New Exception("Nota de Despacho ya Generó el Documento: " & oe_RefAsoc.Glosa)
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Private Function fc_Guardar() As Boolean
        Try
            ' ======================================================================================================================== >>>>>
            mt_LlenaObjeto()
            DocumentoGenerado.IndServicioMaterial = "M"
            DocumentoGenerado = dMovimientoDocumento.GuardarCanjeDocumentos(DocumentoGenerado, ListaNotasDespachoSelecionadas)
            'gtm_Imprimir_Documento(DocumentoGenerado.Id, "A4", "GRIFO")
            gmt_Imprimir_Documento(DocumentoGenerado.Id, "TICKET", "OV", "")
            mt_EmitirDocumento(DocumentoGenerado.Id)
            'MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
            ' ======================================================================================================================== >>>>>
        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Private Sub frm_CanjeND_F_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_CanjeND_F_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        gmt_ControlBoton()
    End Sub

    Private Sub cmbTipoDocumento_ValueChanged(sender As Object, e As EventArgs) Handles cmbTipoDocumento.ValueChanged
        Try
            ' ======================================================================================================================== >>>>>
            Select Case cmbTipoDocumento.Value
                Case "1CH000000026" : txtSerie.Text = "F101" : cmb_Cliente.Focus()
                Case "1CH000000002" : txtSerie.Text = "B101" : cmb_Cliente.Focus()
            End Select
            txt_Numero.Text = FormatoDocumento(CStr(gfc_ObtenerNumeroDoc(txtSerie.Text, cmbTipoDocumento.Value, 2)), 8)
            ' ======================================================================================================================== >>>>>
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub tsb_Emitir_Click(sender As Object, e As EventArgs) Handles tsb_Emitir.Click
        Try
            ' ======================================================================================================================== >>>>>
            If MessageBox.Show("¿Desea Emitir el Documento?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) Then
                For Each Documento In ListaOtrosDocumentos
                    If Documento.IndAnexo = True Then
                        mt_EmitirDocumento(Documento.Id)
                    End If
                Next
                mt_Listar()
            End If
            ' ======================================================================================================================== >>>>>
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub mt_CalcularTotalOrden()
        Try
            ' ======================================================================================================================== >>>>>
            Dim SubTotal As Double = 0, DescuentoTotal As Double = 0, Total As Double = 0, IGV As Double = ObtenerIGV()
            For Each Item In ListaDetalleSeleccionados
                Item.Total = Item.Cantidad * Item.Precio
                Item.Subtotal = Item.Total / (1 + mdblIGV)
                Item.Igv = Item.Total - Item.Subtotal

                SubTotal += Item.Subtotal
                DescuentoTotal = 0
                Total += Item.Total
            Next
            nud_SubTotal.Value = SubTotal
            nud_Total.Value = Total
            nud_Impuesto.Value = Total - SubTotal

            DocumentoGenerado.SubTotal = nud_SubTotal.Value
            DocumentoGenerado.IGV = nud_Impuesto.Value
            DocumentoGenerado.Total = nud_Total.Value
            ' ======================================================================================================================== >>>>>
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub udg_Detalles_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles udg_Detalles.InitializeLayout
        udg_Detalles.UpdateData()
        mt_CalcularTotalOrden()
    End Sub

    Private Sub udg_Detalles_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles udg_Detalles.AfterCellUpdate
        udg_Detalles.UpdateData()
        mt_CalcularTotalOrden()
    End Sub

    Private Sub tsb_Eliminar_Click(sender As Object, e As EventArgs) Handles tsb_Eliminar.Click
        '' Validar
        If udg_DocumentosCanjeados.Rows.Count = 0 Then Exit Sub
        udg_DocumentosCanjeados.UpdateData()

        '' Eliminar
        For Each Documento In ListaOtrosDocumentos
            If Documento.IndAnexo = True Then
                mt_Eliminar(Documento.Id)
            End If
        Next
        mt_Listar()
    End Sub


    Private Sub mt_EmitirDocumento(IdDocumentoCtble As String)
        Try
            ' ======================================================================================================================== >>>>>
            Dim _banEmis As Boolean = False
            Dim DocumentoCtble As New e_MovimientoDocumento
            Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "VTA")

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                mt_ListarCtaCtble(frm.Año1.Año)

                DocumentoCtble = dMovimientoDocumento.Obtener(New e_MovimientoDocumento With {.Id = IdDocumentoCtble, .CargaCompleta = True})

                oe_Cliente = New e_Cliente
                oe_Cliente = ol_Cliente.Obtener(New e_Cliente With {.TipoOperacion = "", .TipoClienteProveedor = 1, .Id = DocumentoCtble.IdClienteProveedor})

                oe_Moneda = cmbMoneda.Items(cmbMoneda.SelectedIndex).ListObject

                oe_TipoDoc = New e_TipoDocumento
                oe_TipoDoc = ol_TipoDoc.Obtener(New e_TipoDocumento With {.TipoOperacion = "", .Id = DocumentoCtble.IdTipoDocumento})

                DocumentoCtble.IdPeriodo = frm.cboMes.Value : DocumentoCtble.Ejercicio = frm.Año1.Año
                DocumentoCtble.Venta.TipoDoc = oe_TipoDoc : DocumentoCtble.Venta.Cliente = oe_Cliente : DocumentoCtble.Venta.Moneda = oe_Moneda

                oeAsientoModelo = New e_AsientoModelo
                oeAsientoModelo.Equivale = 1 : oeAsientoModelo.IdMoneda = oe_Moneda.Id

                If loAsientoModelo.Contains(oeAsientoModelo) Then
                    '' Asiento Modelo
                    oeAsientoModelo = loAsientoModelo.Item(loAsientoModelo.IndexOf(oeAsientoModelo))
                    oeAsientoModelo.TipoOperacion = ""
                    oeAsientoModelo.Ejercicio = DocumentoCtble.FechaEmision.Year
                    oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)

                    '' Cuenta Corriente
                    oeCuentaCorriente = New e_CuentaCorriente
                    oeCuentaCorriente.Tipo = 3 : oeCuentaCorriente.IdTrabajador = DocumentoCtble.IdClienteProveedor
                    oeCuentaCorriente = olCuentaCorriente.Obtener(oeCuentaCorriente)
                    DocumentoCtble.IdUsuarioCrea = gUsuarioSGI.Id

                    oeServCtaCtble = New e_ServicioCuentaContable
                    oeServCtaCtble.IdServicio = gVSMercaderia : oeServCtaCtble.Equivale = 1
                    If leServCtaCtble.Contains(oeServCtaCtble) Then
                        oeServCtaCtble = leServCtaCtble.Item(leServCtaCtble.IndexOf(oeServCtaCtble))
                    Else
                        Throw New Exception("No Existen Cuenta Contable para la Venta: " & gVSMercaderia & " para el Año: " & Date.Now.Year &
                                        Environment.NewLine & "Solicite el Apoyo del Area Contable.")
                    End If

                    DocumentoCtble.PrefijoID = gs_PrefijoIdSucursal
                    If oeCuentaCorriente.Id <> "" Then
                        _banEmis = dMovimientoDocumento.GuardarVentaAsiento(DocumentoCtble, oeAsientoModelo, oeServCtaCtble, True, String.Empty, False)
                    Else
                        With oeCuentaCorriente
                            .Tipooperacion = "I" : .Tipo = 3 : .IdTrabajador = DocumentoCtble.IdClienteProveedor
                            .Saldo = 0 : .TotalCargo = 0 : .TotalAbono = 0 : .Ejercicio = frm.Año1.Año : .Usuario = gUsuarioSGI.Id
                            .IdEstado = "HABILITADA" : .IdMoneda = "1CH01" : .Glosa = "CUENTA DE EMPRESA"
                        End With
                        oeCuentaCorriente.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olCuentaCorriente.Guardar(oeCuentaCorriente)
                        _banEmis = dMovimientoDocumento.GuardarVentaAsiento(DocumentoCtble, oeAsientoModelo, oeServCtaCtble, False, String.Empty, False)
                    End If

                Else
                    Throw New Exception("No Existe Configuracion Contable")
                End If
            End If
            If _banEmis = True Then mensajeEmergente.Confirmacion("El Documento Nº " & DocumentoCtble.Serie & " - " & DocumentoCtble.Numero & " ha sido Emitido", True)
            ' ======================================================================================================================== >>>>>
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub mt_Eliminar(IdDocumento As String)
        Try
            ' ======================================================================================================================== >>>>>
            Dim DocumentoCtble As New e_MovimientoDocumento
            DocumentoCtble.Id = IdDocumento
            DocumentoCtble = dMovimientoDocumento.Obtener(DocumentoCtble)
            If DocumentoCtble.IdEstadoDocumento = "1CH00014" Then
                If DocumentoCtble.Activo Then
                    If MessageBox.Show("Esta seguro de eliminar el Documento: " & DocumentoCtble.Serie & "-" & DocumentoCtble.Numero & " ?",
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        DocumentoCtble.TipoOperacion = "Y"
                        dMovimientoDocumento.EliminarDocumento(DocumentoCtble)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            Else
                Throw New Exception("¡¡El Documento debe estar en Estado Generado para poder ser Eliminado!! " & Me.Text)
            End If
            ' ======================================================================================================================== >>>>>
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub tsb_ImprimirA4_Click(sender As Object, e As EventArgs) Handles tsb_ImprimirA4.Click
        '' Validar
        If udg_DocumentosCanjeados.Rows.Count = 0 Then Exit Sub
        udg_DocumentosCanjeados.UpdateData()

        '' Imprimir
        For Each Documento In ListaOtrosDocumentos
            If Documento.IndAnexo = True Then
                gmt_Imprimir_Documento(Documento.Id, "A4", "GRIFO", "") '@0001
            End If
        Next

    End Sub

    Private Sub mt_Ver_Detalles(IdDocumento As String)
        Try
            ' ======================================================================================================================== >>>>>
            Documento = New e_MovimientoDocumento
            Documento.Id = IdDocumento
            bso_DetalleProductos.DataSource = dDetalleDocumento.Listar(New e_DetalleDocumento With {.TipoOperacion = "CSS", .IdMovimientoDocumento = Documento.Id, .IndServicioMaterial = "M"})
            udg_DetalleProductos.DataBind()
            ' ======================================================================================================================== >>>>>
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub udg_Documentos_Click(sender As Object, e As EventArgs) Handles udg_Documentos.Click
        If udg_Documentos.Selected.Rows.Count > 0 Then
            mt_Ver_Detalles(udg_Documentos.ActiveRow.Cells("Id").Value)
        End If
    End Sub

    Private Sub udg_Detalles_CellChange(sender As Object, e As CellEventArgs) Handles udg_Detalles.CellChange
        udg_Detalles.UpdateData()
        Select Case e.Cell.Column.Key
            Case "Precio"
                mt_CalcularTotalOrden()
        End Select
    End Sub

    Private Sub udg_DocumentosCanjeados_Click(sender As Object, e As EventArgs) Handles udg_DocumentosCanjeados.Click
        If udg_DocumentosCanjeados.Selected.Rows.Count > 0 Then
            mt_Ver_Detalles(udg_DocumentosCanjeados.ActiveRow.Cells("Id").Value)
        End If
    End Sub

    Private Sub tab_Bandeja_Click(sender As Object, e As EventArgs) Handles tab_Bandeja.Click
        If tab_Bandeja.Tabs(0).Selected Then
            tsb_Canjear.Enabled = True
            tsb_Emitir.Enabled = False
            tsb_Eliminar.Enabled = False
            tsb_Imprimir.Enabled = False
        Else
            tsb_Canjear.Enabled = False
            tsb_Emitir.Enabled = True
            tsb_Eliminar.Enabled = True
            tsb_Imprimir.Enabled = True
        End If
    End Sub

    Private Sub cmb_Cliente_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cmb_Cliente.EditorButtonClick
        Try
            oeCombo = New e_Combo
            DireccionClienteProveedorPublic = New List(Of e_Combo)
            oeCombo.Nombre = "DireccionEmpresaFiscal"
            DireccionClienteProveedorPublic = olCombo.Listar(oeCombo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub TickeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TickeToolStripMenuItem.Click
        '' Validar
        If udg_DocumentosCanjeados.Rows.Count = 0 Then Exit Sub
        udg_DocumentosCanjeados.UpdateData()

        '' Imprimir
        For Each Documento In ListaOtrosDocumentos
            If Documento.IndAnexo = True Then
                gmt_Imprimir_Documento(Documento.Id, "TICKET", "OV", "")
            End If
        Next
    End Sub

    Private Sub txtSerie_ValueChanged(sender As Object, e As EventArgs) Handles txtSerie.ValueChanged
        txt_Numero.Text = FormatoDocumento(CStr(gfc_ObtenerNumeroDoc(txtSerie.Text, cmbTipoDocumento.Value, 2)), 8) '@0001
    End Sub

#End Region

End Class