Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_CanjeDocumentos
    Inherits frm_MenuPadre

#Region "Inicializacion del Formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_CanjeND_F = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_CanjeND_F()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Private ListaDocumentoSeleccionados As List(Of e_MovimientoDocumento)
    Private ListaDocumentos As List(Of e_MovimientoDocumento)
    Private Documento As e_MovimientoDocumento
    Private DocumentoGenerado As e_MovimientoDocumento
    Private dMovimientoDocumento As l_MovimientoDocumento


    Private oe_Venta As e_Venta
    Private ol_Venta As l_Venta

    Private oe_Cliente As e_Cliente
    Private ol_Cliente As l_Cliente

    Private oe_TipoDoc As e_TipoDocumento
    Private ol_TipoDoc As l_TipoDocumento
    Private oe_Moneda As e_Moneda

    Private ListaDetalleSeleccionados As List(Of e_DetalleDocumento)
    Private ListaDetalle As List(Of e_DetalleDocumento)
    Private Detalle As e_DetalleDocumento
    Private dDetalleDocumento As l_DetalleDocumento


    Private oe_RefAsoc As e_ReferenciaAsociada
    Private ol_RefAsoc As l_ReferenciaAsociada

    Dim oeTipoPago As e_TipoPago
    Dim olTipoPago As l_TipoPago
    Dim llTipoPago As List(Of e_TipoPago)

    Private oeCtaCtble As e_CuentaContable
    Private olCtaCtable As l_CuentaContable
    Private loCtaCtble As List(Of e_CuentaContable)

    Private DTReferencia As Data.DataTable
    Private dtAux As Data.DataTable

    Private oeReferencia As e_AsientoModelo_Referencia
    Private olReferencia As l_AsientoModelo_Referencia
    Private loReferencia As List(Of e_AsientoModelo_Referencia)

    Private oeEmpresa As e_Empresa

    Private oeAsientoModelo As e_AsientoModelo
    Private olAsientoModelo As l_AsientoModelo
    Private loAsientoModelo As List(Of e_AsientoModelo)

    Private oeCuentaCorriente As New e_CuentaCorriente
    Private olCuentaCorriente As New l_CuentaCorriente

    Private oeServCtaCtble As e_ServicioCuentaContable
    Private olServCtaCtble As New l_ServicioCuentaContable
    Private leServCtaCtble As List(Of e_ServicioCuentaContable)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
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
            If udg_Documentos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(udg_Documentos, Me.Text)
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
        cmbTipoDocumento.SelectedIndex = -1

    End Sub

    Private Sub mt_Listar()
        Try
            Documento = New e_MovimientoDocumento
            Documento.IdTipoDocumento = "GCH000000001"
            Documento.TipoOperacion = ""
            Documento.FechaInicio = dtp_FechaDesde.Value
            Documento.FechaFinal = dtp_FechaHasta.Value
            ListaDocumentos = dMovimientoDocumento.Listar(Documento)
            udg_Documentos.DataSource = ListaDocumentos
            udg_Documentos.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        mt_CanjearDocumentos()
    End Sub

    Private Sub mt_CanjearDocumentos()
        Try
            '' Valida
            If udg_Documentos.Selected.Rows.Count = 0 Then Exit Sub

            '' Inicializa
            ListaDocumentoSeleccionados = New List(Of e_MovimientoDocumento)
            ListaDetalleSeleccionados = New List(Of e_DetalleDocumento)

            '' Agregar los documentos seleccionados
            For Each Item In udg_Documentos.Rows
                If Item.Cells("IndAnexo").Value = True Then
                    If fc_ValidaCanje(Item.Cells("Id").Value) Then
                        Documento = New e_MovimientoDocumento
                        Documento = CType(udg_Documentos.ActiveRow.ListObject, e_MovimientoDocumento)
                        ListaDocumentoSeleccionados.Add(Documento)
                        'mt_MostrarDocumento(Item.Cells("Id").Value)
                    End If
                End If
            Next

            '' Agrega los detalles de cada documento seleccionado
            If ListaDocumentoSeleccionados.Count > 0 Then
                For Each Doc In ListaDocumentoSeleccionados
                    ListaDetalle = New List(Of e_DetalleDocumento)
                    ListaDetalle = dDetalleDocumento.Listar(New e_DetalleDocumento With {.TipoOperacion = "VEN", .IdMovimientoDocumento = Doc.Id, .IndServicioMaterial = "M"})
                    For Each Item In ListaDetalle
                        Item.IdOperacionDetalle = Item.IdMovimientoDocumento
                        ListaDetalleSeleccionados.Add(Item)
                    Next
                Next

                '' Muestra el documento que vamos a generar
                gmt_MostrarTabs(1, fic_Canje, 1)
                mt_ControlBotoneria()
                cmbTipoDocumento.Focus()
                bso_Detalle.DataSource = ListaDetalleSeleccionados
                udg_Detalles.DataBind()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cbgCliente_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cbgCliente.InitializeLayout
        Me.cbgCliente.ValueMember = "Id"
        Me.cbgCliente.DisplayMember = "Nombre"
        For i As Integer = cbgCliente.DisplayLayout.Bands(0).Columns.Count - 1 To 0 Step -1
            cbgCliente.DisplayLayout.Bands(0).Columns(i).Hidden = False
        Next

        With cbgCliente.DisplayLayout.Bands(0)
            '.Columns("Id").Hidden = True
            '.Columns("TipoEmpresa").Hidden = True
            '.Columns("Codigo").Hidden = True
            '.Columns("IdDireccionTanqueo").Hidden = True
            '.Columns("Morosidad").Hidden = True
            '.Columns("Credito").Hidden = True
            '.Columns("IndNivelComercial").Hidden = True
            '.Columns("Moneda").Hidden = True
            '.Columns("IndClasificacion").Hidden = True
            '.Columns("UsuarioCreacion").Hidden = True
            '.Columns("IndCategoriaEmpresaSGI").Hidden = True
            '.Columns("Activo").Hidden = True
            .Columns("Ruc").Hidden = False
            .Columns("Nombre").Hidden = False
            .Columns("Ruc").Header.Caption = "N° RUC"
            .Columns("Ruc").Width = 80
            .Columns("Nombre").Width = 250
        End With
    End Sub

    Private Sub cbgCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles cbgCliente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Not String.IsNullOrEmpty(cbgCliente.Text.Trim) Then
                    gmt_ListarEmpresa("6", cbgCliente, String.Empty, False)
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
            'Documento = New e_MovimientoDocumento
            'Documento.Id = IdDocumento
            'Documento = dMovimientoDocumento.Obtener(Documento)

            'oe_Venta = New e_Venta
            'oe_Venta.IdMovimientoDocumento = IdDocumento
            'oe_Venta = ol_Venta.ObtenerIdDocumento(oe_Venta)

            'Detalle = New e_DetalleDocumento
            'Detalle.TipoOperacion = "VEN"
            'Detalle.IdMovimientoDocumento = IdDocumento
            'Detalle.IndServicioMaterial = "M"
            'ListaDetalle = dDetalleDocumento.Listar(Detalle)

            'udg_Detalles.DataSource = ListaDetalle
            'udg_Detalles.DataBind()

            DocumentoGenerado = New e_MovimientoDocumento
            DocumentoGenerado = ListaDocumentoSeleccionados(0).Clonar
            DocumentoGenerado.Id = String.Empty
            gmt_ListarEmpresa("6", cbgCliente, DocumentoGenerado.IdClienteProveedor, False)
            cbgCliente.Value = DocumentoGenerado.IdClienteProveedor
            dtp_FechaEmision.Value = DocumentoGenerado.FechaEmision
            Me.decTipoCambio.Value = gfc_TipoCambio(dtp_FechaEmision.Value, True)
            cboTipoPago.Value = DocumentoGenerado.IdTipoPago
            cmbMoneda.Value = DocumentoGenerado.IdMoneda
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_LlenaObjeto()
        Try
            If cbgCliente.SelectedRow Is Nothing Then Throw New Exception("Seleccione Cliente")
            If cmbTipoDocumento.SelectedIndex = -1 Then Throw New Exception("Seleccione Tipo de Documento")
            DocumentoGenerado.TipoOperacion = "I"
            DocumentoGenerado.IdSucursal = gs_PrefijoIdSucursal
            DocumentoGenerado.PrefijoID = gs_PrefijoIdSucursal
            DocumentoGenerado.Serie = txtSerie.Text
            DocumentoGenerado.Numero = FormatoDocumento(CStr(gfc_ObtenerNumeroDoc(txtSerie.Text, cmbTipoDocumento.Value, 2)), 8)
            DocumentoGenerado.IdEstadoDocumento = "1CH00014"
            DocumentoGenerado.IdTipoDocumento = cmbTipoDocumento.Value
            DocumentoGenerado.IdPeriodo = ""
            DocumentoGenerado.IdTipoPago = cboTipoPago.Value
            DocumentoGenerado.Mac_PC_Local = MacPCLocal()
            DocumentoGenerado.IdClienteProveedor = cbgCliente.Value
            DocumentoGenerado.Saldo = DocumentoGenerado.Total
            DocumentoGenerado.lstDetalleDocumento = New List(Of e_DetalleDocumento)
            DocumentoGenerado.lstDetalleDocumento = ListaDetalle
            For Each detalle In DocumentoGenerado.lstDetalleDocumento
                With detalle
                    .TipoOperacion = "I"
                    .Id = String.Empty
                    .IdMovimientoDocumento = String.Empty
                End With
            Next
            DocumentoGenerado.Venta = New e_Venta
            DocumentoGenerado.Venta = fc_LlenarVenta()
            DocumentoGenerado.IdUsuarioCrea = gUsuarioSGI.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_EmitirDocumento(IndMensaje As Boolean)
        Try
            Dim _banEmis As Boolean = False
            Dim oeDoc As New e_MovimientoDocumento
            Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "VTA")
            oe_Cliente = New e_Cliente
            oe_Cliente.TipoOperacion = ""
            oe_Cliente.TipoClienteProveedor = 1
            oe_Cliente.Id = DocumentoGenerado.IdClienteProveedor
            oe_Cliente = ol_Cliente.Obtener(oe_Cliente)

            oe_Moneda = cmbMoneda.Items(cmbMoneda.SelectedIndex).ListObject

            oe_TipoDoc = New e_TipoDocumento
            oe_TipoDoc.TipoOperacion = ""
            oe_TipoDoc.Id = cmbTipoDocumento.Value
            oe_TipoDoc = ol_TipoDoc.Obtener(oe_TipoDoc)

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                mt_ListarCtaCtble(frm.Año1.Año)

                oeDoc.Id = DocumentoGenerado.Id : oeDoc.CargaCompleta = True

                oeDoc = dMovimientoDocumento.Obtener(oeDoc)
                oeDoc.IdPeriodo = frm.cboMes.Value : oeDoc.Ejercicio = frm.Año1.Año
                oeDoc.Venta.TipoDoc = oe_TipoDoc : oeDoc.Venta.Cliente = oe_Cliente : oeDoc.Venta.Moneda = oe_Moneda

                oeAsientoModelo = New e_AsientoModelo
                oeAsientoModelo.Equivale = 1 : oeAsientoModelo.IdMoneda = oe_Moneda.Id

                If loAsientoModelo.Contains(oeAsientoModelo) Then
                    oeAsientoModelo = loAsientoModelo.Item(loAsientoModelo.IndexOf(oeAsientoModelo))
                    oeAsientoModelo.TipoOperacion = ""
                    oeAsientoModelo.Ejercicio = oeDoc.FechaEmision.Year
                    oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)
                    'For Each _oeDet In oeAsientoModelo.leDetalle
                    '    oeCtaCtble = New e_CuentaContable
                    '    oeCtaCtble.Cuenta = "12121" : oeCtaCtble.Equivale = 0
                    '    If loCtaCtble.Contains(oeCtaCtble) Then
                    '        oeCtaCtble = loCtaCtble.Item(loCtaCtble.IndexOf(oeCtaCtble))
                    '        _oeDet.IdCuentaContable = oeCtaCtble.Id
                    '    End If
                    'Next

                    oeCuentaCorriente = New e_CuentaCorriente
                    oeCuentaCorriente.Tipo = 3 : oeCuentaCorriente.IdTrabajador = oeDoc.IdClienteProveedor
                    oeCuentaCorriente = olCuentaCorriente.Obtener(oeCuentaCorriente)
                    oeDoc.IdUsuarioCrea = gUsuarioSGI.Id

                    oeServCtaCtble = New e_ServicioCuentaContable
                    oeServCtaCtble.IdServicio = gVSMercaderia : oeServCtaCtble.Equivale = 1
                    If leServCtaCtble.Contains(oeServCtaCtble) Then
                        oeServCtaCtble = leServCtaCtble.Item(leServCtaCtble.IndexOf(oeServCtaCtble))
                    Else
                        Throw New Exception("No Existen Cuenta Contable para el Servicio: " & gVSMercaderia & " para el Año: " & Date.Now.Year &
                                        Environment.NewLine & "Solicite el Apoyo del Area Contable.")
                    End If

                    oeDoc.PrefijoID = gs_PrefijoIdSucursal
                    If oeCuentaCorriente.Id <> "" Then
                        _banEmis = dMovimientoDocumento.GuardarVentaAsiento(oeDoc, oeAsientoModelo, oeServCtaCtble, True, String.Empty, False)
                    Else
                        With oeCuentaCorriente
                            .Tipooperacion = "I" : .Tipo = 3 : .IdTrabajador = oeDoc.IdClienteProveedor
                            .Saldo = 0 : .TotalCargo = 0 : .TotalAbono = 0 : .Ejercicio = frm.Año1.Año : .Usuario = gUsuarioSGI.Id
                            .IdEstado = "HABILITADA" : .IdMoneda = "1CH01" : .Glosa = "CUENTA DE EMPRESA"
                        End With
                        oeCuentaCorriente.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olCuentaCorriente.Guardar(oeCuentaCorriente)
                        _banEmis = dMovimientoDocumento.GuardarVentaAsiento(oeDoc, oeAsientoModelo, oeServCtaCtble, False, String.Empty, False)
                    End If

                Else
                    Throw New Exception("No Existe Configuracion Contable")
                End If
            End If
            If _banEmis = True Then mensajeEmergente.Confirmacion("El Documento Nº " & oeDoc.Serie & " - " & oeDoc.Numero & " ha sido Emitido", True)

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
            mt_LlenaObjeto()
            dMovimientoDocumento.GuardarCanjeDocumentos(DocumentoGenerado, ListaDocumentoSeleccionados)
            Select Case MessageBox.Show("¿Desea Emitir el Documento?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    mt_EmitirDocumento(False)
            End Select
            MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
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


#End Region

End Class