Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors

Public Class frm_GRR_Venta
    Inherits frm_MenuPadre

#Region "Inicializacion del Formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_GRR_Venta = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_GRR_Venta()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

    Private Sub frm_GRR_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_IniciarFormulario()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

#End Region

#Region "Variables"

    '    Private oeDocumento As e_Documento
    '    Private olDocumento As l_Documento

    '    Private oeDetalleDocumento As e_DetalleDocumento
    '    Private olDetalleDocumento As l_DetalleDocumento
    '    Private loDetalleDocumento As List(Of e_DetalleDocumento)

    Private oeGuiaRR As e_GRR_Venta
    Private olGuiaRR As l_GRR_Venta

    Private oeGuiaRRDetalle As e_GuiaRemisionRemitente_Detalle
    Private olGuiaRRDetalle As l_GuiaRemisionRemitente_Detalle
    Private loGuiaRRDetalle As List(Of e_GuiaRemisionRemitente_Detalle)

    Private oeVehiculo As e_Vehiculo
    Private olVehiculo As l_Vehiculo
    Private loVehiculo As List(Of e_Vehiculo)
    Private loCarreta As List(Of e_Vehiculo)

    Private oeMotivoTraslado As e_MotivoTraslado
    Private olMotivoTraslado As l_MotivoTraslado

    Private oeRefAsoc As e_ReferenciaAsociada
    Private olCombo As l_Combo

    '    Private oeAlmMaterial As e_AlmacenMaterial
    '    Private olAlmMaterial As l_AlmacenMaterial
    '    Private loAlmMaterial As List(Of e_AlmacenMaterial)

    '    Private oeMaterial As e_Material
    '    Private olMaterial As l_Material
    '    Private loMaterial As List(Of e_Material)

    '    Private oeOrdenDocumento As e_OrdenDocumento
    '    Private olOrdenDocumento As l_OrdenDocumento
    '    Private loOrdenDocumento As List(Of e_OrdenDocumento)

    '    Private oeOrdenComercial As e_OrdenComercial
    '    Private olOrdenComercial As l_OrdenComercial

    '    Private oeOrdenSalida As e_Orden
    '    Private olOrdenSalida As l_Orden
    '    Private loOrdenSalida As List(Of e_Orden)

    '    Private oeDetalleOrden As e_DetalleOrden
    '    Private olDetalleOrden As l_DetalleOrden
    '    Private loDetalleOrden As List(Of e_DetalleOrden)

    '    Private loEmpresa As List(Of e_Empresa)
    '    Private oeCombo As e_Combo
    '    Private olCombo As l_Combo
    '    Dim ListDireccion As List(Of e_Combo)

    '    Private oePersonaDocumento As e_PersonaDocumento
    '    Private olPersonaDocumento As l_PersonaDocumento
    '    Private loPersonaDocumento As List(Of e_PersonaDocumento)

    '    Private oeDireccion As e_Direccion
    '    Private olDireccion As l_Direccion
    '    Private leDireccion As List(Of e_Direccion)

    '    Private intExistencia As Integer = 2

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

    Public Overrides Sub Nuevo()
        Try
            gmt_MostrarTabs(1, ficGuiaRR, 1)
            mt_Inicializar()
            Operacion = "Nuevo"
            mt_ControlBotoneria()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griDocumento.Selected.Rows.Count > 0 Then
                If griDocumento.ActiveRow.Cells("Estado").Value.ToString = "ANULADO" Then
                    Throw New Exception("No se puede Visualizar, El documento está anulado")
                Else
                    If griDocumento.ActiveRow.Cells("Estado").Value.ToString = "ATENDIDO" Then
                        mt_Inicializar()
                        mt_Mostrar()
                        gmt_MostrarTabs(1, ficGuiaRR, 1)
                        Operacion = "Editar"
                        mt_ControlBotoneria()
                        UltraGroupBox6.Enabled = False
                        txtLlegada.ReadOnly = True
                        txtPartida.ReadOnly = True
                        txtSerie.ReadOnly = True
                        txtNumero.ReadOnly = True
                        cmbMotivoTraslado.ReadOnly = True
                        gmt_ControlBoton(0, 0, 0, 0, 1, 0, 0, 0)
                    Else
                        mt_Inicializar()
                        mt_Mostrar()
                        gmt_MostrarTabs(1, ficGuiaRR, 1)
                        Operacion = "Editar"
                        mt_ControlBotoneria()
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If fc_Guardar() Then
                gmt_MostrarTabs(0, ficGuiaRR, 2)
                Consultar(True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            gmt_MostrarTabs(0, ficGuiaRR, 2)
            Consultar(True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    '    Public Overrides Sub Eliminar()
    '        Try
    '            With griDocumento
    '                oeGuiaRR = New e_GRR_Venta
    '                If griDocumento.Selected.Rows.Count > 0 Then
    '                    oeGuiaRR.Id = .ActiveRow.Cells("Id").Value
    '                    oeGuiaRR = olGuiaRR.Obtener(oeGuiaRR)
    '                    If oeGuiaRR.IdEstado = "1CIX025" Then
    '                        If gfc_ValidarOrdEjecutada(oeGuiaRR.Id, "1CIX009") Then
    '                            If MessageBox.Show("Esta seguro de eliminar el Documento: " &
    '                                 .ActiveRow.Cells("Serie").Value.ToString & " - " & .ActiveRow.Cells("Numero").Value.ToString & " ?",
    '                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
    '                                oeGuiaRR.TipoOperacion = "E"
    '                                oeGuiaRR.UsuarioCrea = gUsuarioEOS.Nombre
    '                                olGuiaRR.Eliminar(oeGuiaRR)
    '                                MsgBox("La Informacion ha Sido Eliminada Correctamente", MsgBoxStyle.Information, Me.Text)
    '                                Consultar(True)
    '                            End If
    '                        End If
    '                    Else
    '                        Throw New Exception("Solo Puede Eliminar Documentos Emitidos")
    '                    End If
    '                End If
    '            End With
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '        End Try
    '    End Sub

    Public Overrides Sub Exportar()
        Try
            If griDocumento.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griDocumento, Me.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Dim id As String = ""
        Try
            'If griDocumento.Selected.Rows.Count > 0 Then
            '    Dim formulario As New frm_ImprimirGRR
            '    id = griDocumento.ActiveRow.Cells("Id").Value
            '    formulario.mt_CargarDatos(id)
            '    formulario.ShowDialog()
            '    gmt_ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub cboTransportista_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboTransportista.InitializeLayout
        Me.cboTransportista.ValueMember = "Id"
        Me.cboTransportista.DisplayMember = "Nombre"
        For i As Integer = cboTransportista.DisplayLayout.Bands(0).Columns.Count - 1 To 0 Step -1
            cboTransportista.DisplayLayout.Bands(0).Columns(i).Hidden = True
        Next

        With cboTransportista.DisplayLayout.Bands(0)

            .Columns("Ruc").Hidden = False
            .Columns("Nombre").Hidden = False
            .Columns("Ruc").Header.Caption = "N° RUC"
            .Columns("Ruc").Width = 80
            .Columns("Nombre").Width = 250
        End With
    End Sub

    Private Sub cboTransportista_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTransportista.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Not String.IsNullOrEmpty(cboTransportista.Text.Trim) Then
                    gmt_ListarEmpresa("6", cboTransportista, String.Empty, False)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cboTransportista_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTransportista.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboTransportista.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub frm_GuiaRemisionVenta_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        mt_ControlBotoneria()
        'If ficGuiaRR.Tabs(0).Selected Then
        '    Consultar(True)
        'End If
    End Sub

    Private Sub frm_GuiaRemisionVenta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_GuiaRemisionVenta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        gmt_ControlBoton()
    End Sub

    Private Sub griDetalleDocumento_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDetalleDocumento.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub txtSerie_Enter(sender As Object, e As EventArgs) Handles txtSerie.Enter
        txtSerie.Select(0, 4)
        Me.txtSerie.SelectAll()
    End Sub

    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumero_Enter(sender As Object, e As EventArgs) Handles txtNumero.Enter
        txtNumero.Select(0, 10)
        Me.txtNumero.SelectAll()
    End Sub

    'Private Sub txtSerieD_Enter(sender As Object, e As EventArgs) Handles txtSerieD.Enter
    '    txtSerieD.Select(0, 4)
    '    Me.txtSerieD.SelectAll()
    'End Sub

    'Private Sub txtSerieD_Validated(sender As Object, e As EventArgs) Handles txtSerieD.Validated
    '    txtSerieD.Text = gmt_FormatoDocumento(txtSerieD.Text, 4)
    'End Sub

    'Private Sub txtSerieD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerieD.KeyPress
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    '    Private Sub txtNroD_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroD.KeyDown
    '        If e.KeyCode = Keys.Enter Then
    '            Consultar(True)
    '        End If
    '    End Sub

    '    Private Sub txtNroD_Enter(sender As Object, e As EventArgs) Handles txtNroD.Enter
    '        txtNroD.Select(0, 10)
    '        Me.txtNroD.SelectAll()
    '    End Sub

    '    Private Sub txtNroD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroD.KeyPress
    '        If Char.IsDigit(e.KeyChar) Then
    '            e.Handled = False
    '        ElseIf Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '        End If
    '    End Sub


    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txtSerie.Validated
        Try
            txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
            txtNumero.Text = FormatoDocumento(CStr(gfc_ObtenerNumeroGRR(txtSerie.Text)), 8)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub txtNumero_Validated(sender As Object, e As EventArgs) Handles txtNumero.Validated
        txtNumero.Text = FormatoDocumento(txtNumero.Text, 8)
    End Sub

    Private Sub rdbNroOrden_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNroDocumento.CheckedChanged
        If rdbNroDocumento.Checked Then
            grbDatosBasicos.Enabled = False
            grbNroOrden.Enabled = True
            txtSerieDoc.Focus()
        Else
            grbDatosBasicos.Enabled = True
            grbNroOrden.Enabled = False
        End If
    End Sub

    Private Sub rdbDatosBasicos_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDatosBasicos.CheckedChanged
        If rdbDatosBasicos.Checked Then
            grbDatosBasicos.Enabled = True
            grbNroOrden.Enabled = False
        Else
            grbDatosBasicos.Enabled = False
            grbNroOrden.Enabled = True
            txtSerieDoc.Focus()
        End If
    End Sub

    Private Sub cmbVehiculo_Validated(sender As Object, e As EventArgs) Handles cmbVehiculo.Validated
        Try
            If cmbVehiculo.SelectedIndex > -1 Then
                mt_CargaDatosTracto(cmbVehiculo.Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub frm_GRR_Venta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_GRR_Venta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub cmb_Cliente_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cmb_Cliente.InitializeLayout
        Me.cmb_Cliente.ValueMember = "Id"
        Me.cmb_Cliente.DisplayMember = "Nombre"
        For i As Integer = cmb_Cliente.DisplayLayout.Bands(0).Columns.Count - 1 To 0 Step -1
            cmb_Cliente.DisplayLayout.Bands(0).Columns(i).Hidden = True
        Next
        With cmb_Cliente.DisplayLayout.Bands(0)
            .Columns("Ruc").Hidden = False
            .Columns("Nombre").Hidden = False
            .Columns("Ruc").Header.Caption = "N° RUC"
            .Columns("Ruc").Width = 80
            .Columns("Nombre").Width = 250
        End With
    End Sub

    Private Sub cmb_Cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Cliente.KeyDown
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

    Private Sub cmb_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_Cliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cmb_Cliente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboTransportista_Validated(sender As Object, e As EventArgs) Handles cboTransportista.Validated
        Try
            If cboTransportista.Value = gs_IdClienteProveedorSistema Then
                cboCarreta.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
                cmbVehiculo.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
                cboChofer.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
                gmt_ComboEspecifico(cmbVehiculo, loVehiculo.Where(Function(i) i.Id <> "" And i.Motriz = 1).OrderBy(Function(y) y.Placa).ToList, -1, "Placa")
                gmt_ComboEspecifico(cboCarreta, loCarreta.Where(Function(i) i.Id <> "" And i.Motriz = 0).OrderBy(Function(y) y.Placa).ToList, -1, "Placa")
                cboChofer.DataSource = PilotoPublic

            Else
                cmbVehiculo.DataSource = Nothing
                cmbVehiculo.Text = String.Empty
                cmbVehiculo.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never

                cboCarreta.DataSource = Nothing
                cboCarreta.Text = String.Empty
                cboCarreta.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never

                cboChofer.Text = String.Empty
                cboChofer.DataSource = New List(Of e_Combo)
                cboChofer.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub


    Private Sub cboChofer_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboChofer.InitializeLayout
        For i As Integer = cboChofer.DisplayLayout.Bands(0).Columns.Count - 1 To 0 Step -1
            cboChofer.DisplayLayout.Bands(0).Columns(i).Hidden = True
        Next
        With cboChofer.DisplayLayout.Bands(0)
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Header.Caption = "Trabajador"
            .Columns("Nombre").Width = 400
        End With
    End Sub

    Private Sub cboChofer_Validated(sender As Object, e As EventArgs) Handles cboChofer.Validated
        Try
            If cboChofer.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always Then
                Dim oeCombo As e_Combo = olCombo.Obtener(New e_Combo With {.Nombre = "", .Id = cboChofer.Value})
                txtNroLicencia.Text = oeCombo.Descripcion
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_CargarDetalleOV()
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_IniciarFormulario()
        Try
            mt_InicializarLogicas()
            mt_CargarCombos()
            mt_ConfigurarGrillas()
            dtpFechaInicio.Value = Date.Now.AddDays(-20)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ConfigurarGrillas()
        Try
            With griDocumento
                .ResetDisplayLayout()
                .Text = String.Empty
                .DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.True
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = UltraGridFilterUIProvider1
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                ConfiguraGrilla(griDocumento, "Tahoma", False, UIElementBorderStyle.Default)
                For i As Integer = griDocumento.DisplayLayout.Bands(0).Columns.Count - 1 To 0 Step -1
                    griDocumento.DisplayLayout.Bands(0).Columns(i).Hidden = True
                    griDocumento.DisplayLayout.Bands(0).Columns(i).CellActivation = Activation.NoEdit
                Next
                With .DisplayLayout.Bands(0)
                    .Columns("Fecha").Hidden = False
                    .Columns("Fecha").Header.VisiblePosition = 0
                    .Columns("Fecha").Width = 100
                    .Columns("Serie").Hidden = False
                    .Columns("Serie").Header.VisiblePosition = 1
                    .Columns("Serie").Width = 80
                    .Columns("Numero").Hidden = False
                    .Columns("Numero").Header.VisiblePosition = 2
                    .Columns("Numero").Width = 120
                    .Columns("FechaTraslado").Hidden = False
                    .Columns("FechaTraslado").Header.VisiblePosition = 3
                    .Columns("FechaTraslado").Width = 100
                    .Columns("Cliente").Hidden = False
                    .Columns("Cliente").Header.VisiblePosition = 4
                    .Columns("Cliente").Width = 300
                    .Columns("Transportista").Hidden = False
                    .Columns("Transportista").Header.VisiblePosition = 5
                    .Columns("Transportista").Width = 300
                    .Columns("Vehiculo").Hidden = False
                    .Columns("Vehiculo").Header.VisiblePosition = 6
                    .Columns("Vehiculo").Width = 100
                    .Columns("Carreta").Hidden = False
                    .Columns("Carreta").Header.VisiblePosition = 7
                    .Columns("Carreta").Width = 100
                End With
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            End With

            With griDetalleDocumento
                .ResetDisplayLayout()
                .Text = String.Empty
                .DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.True
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = UltraGridFilterUIProvider1
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                ConfiguraGrilla(griDetalleDocumento, "Tahoma", False, UIElementBorderStyle.Default)
                For i As Integer = griDetalleDocumento.DisplayLayout.Bands(0).Columns.Count - 1 To 0 Step -1
                    griDetalleDocumento.DisplayLayout.Bands(0).Columns(i).Hidden = True
                    griDetalleDocumento.DisplayLayout.Bands(0).Columns(i).CellActivation = Activation.NoEdit
                Next

                With .DisplayLayout.Bands(0)
                    .Columns("CodigoMaterial").Hidden = False
                    .Columns("CodigoMaterial").Width = 120
                    .Columns("CodigoMaterial").Header.VisiblePosition = 0
                    .Columns("CodigoMaterial").Header.Caption = "Codigo"
                    .Columns("Material").Hidden = False
                    .Columns("Material").Width = 400
                    .Columns("Material").Header.VisiblePosition = 1
                    .Columns("IdUnidadMedida").Hidden = False
                    .Columns("IdUnidadMedida").Width = 120
                    .Columns("IdUnidadMedida").Header.VisiblePosition = 2
                    .Columns("Cantidad").Hidden = False
                    .Columns("Cantidad").Width = 130
                    .Columns("Cantidad").Header.VisiblePosition = 3
                    .Columns("Peso").Hidden = False 'IdUnidadMedida
                    .Columns("Peso").Width = 130
                    .Columns("Peso").Header.VisiblePosition = 4
                End With
                FormatoColumna(griDetalleDocumento, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Cantidad", "Peso")

                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Inicializar()
        'oeDocumento = New e_Documento
        oeGuiaRR = New e_GRR_Venta
        'oeDetalleDocumento = New e_DetalleDocumento
        'loDetalleDocumento = New List(Of e_DetalleDocumento)
        'griDetalleDocumento.DataSource = loDetalleDocumento
        oeGuiaRRDetalle = New e_GuiaRemisionRemitente_Detalle
        loGuiaRRDetalle = New List(Of e_GuiaRemisionRemitente_Detalle)
        griDetalleDocumento.DataSource = loGuiaRRDetalle
        'oeOrdenDocumento = New e_OrdenDocumento
        'loOrdenDocumento = New List(Of e_OrdenDocumento)
        'loEmpresa = New List(Of e_Empresa)
        'txtProveedor.Text = String.Empty
        'txtProveedor.Tag = String.Empty
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        cmbMotivoTraslado.SelectedIndex = -1
        dtpFechaDocumento.Value = Date.Now
        txt_DocAsoc.Text = String.Empty
        UltraGroupBox5.Enabled = True
        txtLlegada.Text = String.Empty
        txtPartida.Text = String.Empty
        Me.txtMTC.Text = String.Empty
        cboChofer.Text = ""
        txtNroLicencia.Text = ""
        cmbVehiculo.SelectedIndex = -1
        txtNroMTCC.Text = ""
        cboCarreta.Text = ""
        'txtPropietarioVehiculo.Text = ""
        'txtPropietarioCarreta.Text = ""
        'griDetalleDocumento.Enabled = True
        UltraGroupBox3.Enabled = True
        'gbeMateriales.Visible = False
        'gbeMateriales.Expanded = True
        UltraGroupBox6.Enabled = True
        txtLlegada.ReadOnly = False
        txtPartida.ReadOnly = False
        txtSerie.ReadOnly = False
        txtNumero.ReadOnly = False
        btnAgregarOs.Enabled = True
        btnQuitarOs.Enabled = True
        'btnAgregarD.Enabled = False
        'btnQuitarD.Enabled = False
        btnAgregarOv.Enabled = False
        BtnQuitarOv.Enabled = False
        cmbMotivoTraslado.ReadOnly = False
        griDetalleDocumento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        'mt_HabilitarGrilla(True)
        'mt_VisibilidadDetalles()
        'loOrdenDocumento = New List(Of e_OrdenDocumento)
        '  loDetalleDocumento = New List(Of e_DetalleDocumento)
        'loOrdenSalida = New List(Of e_Orden)
        'griOrdenSalida.DataSource = loOrdenSalida
        'griDetalleDocumento.DataSource = loDetalleDocumento
        'griOrdenDocumento.DataSource = loOrdenDocumento
    End Sub

    Private Sub mt_ControlBotoneria()
        Select Case ficGuiaRR.SelectedTab.Index
            Case 0
                If griDocumento.Rows.Count > 0 Then
                    gmt_ControlBoton(1, 1, 1, 0, 0, 1, 1, 1)
                Else
                    gmt_ControlBoton(1, 1)
                End If
            Case 1
                gmt_ControlBoton(0, 0, 0, 1, 1, 0, 1)
        End Select
    End Sub

    Private Sub mt_InicializarLogicas()
        'olDocumento = New l_Documento
        'olDetalleDocumento = New l_DetalleDocumento
        'olOrdenDocumento = New l_OrdenDocumento
        'olDetalleOrden = New l_DetalleOrden
        'olAlmMaterial = New l_AlmacenMaterial
        'olCombo = New l_Combo
        olGuiaRR = New l_GRR_Venta
        olVehiculo = New l_Vehiculo
        olMotivoTraslado = New l_MotivoTraslado
        olGuiaRRDetalle = New l_GuiaRemisionRemitente_Detalle
        olCombo = New l_Combo
        'olPersonaDocumento = New l_PersonaDocumento
        'olOrdenComercial = New l_OrdenComercial
        'olMaterial = New l_Material
        'olDireccion = New l_Direccion
    End Sub

    Private Sub mt_CargarCombos()
        Try
            LlenarComboMaestro(cboPuntoPartida, LugaresPublic, -1)
            LlenarComboMaestro(cboPuntoLlegada, LugaresPublic, -1)

            cboTransportista.DropDownStyle = DropDownStyle.DropDown
            cboTransportista.AutoCompleteMode = AutoCompleteMode.SuggestAppend

            mt_CargarTractos()
            mt_CargarCarretas()
            mt_MotivoTraslado()

            cboChofer.DataSource = PilotoPublic
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCarretas()
        Try
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Motriz = 0
            loCarreta = olVehiculo.Listar(oeVehiculo)
            '
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarTractos()
        Try
            oeVehiculo = New e_Vehiculo
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Motriz = 1
            loVehiculo = olVehiculo.Listar(oeVehiculo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_MotivoTraslado()
        Try
            oeMotivoTraslado = New e_MotivoTraslado
            gmt_ComboEspecifico(cmbMotivoTraslado, olMotivoTraslado.Listar(oeMotivoTraslado), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargaDatosTracto(IdVehiculo As String)
        Try
            ''''Para el certif MTC
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Id = cmbVehiculo.Value
            oeVehiculo = olVehiculo.Obtener(oeVehiculo)
            txtMTC.Text = oeVehiculo.NroMTC
            txtMarcaVehiculo.Text = oeVehiculo.Marca
            '''''Para el Propietario
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Listar()
        Try
            oeGuiaRR = New e_GRR_Venta
            oeGuiaRR.TipoOperacion = ""
            If rdbDatosBasicos.Checked Then
                oeGuiaRR.Fecha = dtpFechaInicio.Value
                oeGuiaRR.FechaTraslado = dtpFechaFin.Value
            Else
                oeGuiaRR.Serie = FormatoDocumento(txtSerieDoc.Text, 4)
                oeGuiaRR.Numero = FormatoDocumento(txtNroDoc.Text, 8)
            End If
            griDocumento.DataSource = olGuiaRR.Listar(oeGuiaRR)
            'fc_Grias()
            'For Each fila As UltraGridRow In griDocumento.Rows
            '    Select Case fila.Cells("Estado").Value
            '        Case "GENERADO"
            '            fila.CellAppearance.BackColor = Me.colorGenerado.Color
            '        Case "ANULADO"
            '            fila.CellAppearance.BackColor = Me.colorAnulado.Color
            '        Case "ATENDIDO"
            '            fila.CellAppearance.BackColor = Me.ColorAtendido.Color
            '    End Select
            'Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region




    '    Private Sub griAlmacenMaterial_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griAlmacenMaterial.AfterCellUpdate
    '        Try
    '            Select Case e.Cell.Column.Key
    '                Case "Seleccion"
    '                    With griAlmacenMaterial.DisplayLayout.Bands(0).Layout.ActiveRow
    '                        If .Cells("Seleccion").Value Then
    '                            .Appearance.BackColor = Color.Yellow
    '                            .Appearance.ForeColor = Color.Red
    '                        Else
    '                            .Appearance.BackColor = Color.White
    '                            .Appearance.ForeColor = Color.Black
    '                        End If
    '                    End With
    '            End Select
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Private Sub griAlmacenMaterial_CellChange(sender As Object, e As CellEventArgs) Handles griAlmacenMaterial.CellChange
    '        Try
    '            griAlmacenMaterial.UpdateData()
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '        End Try
    '    End Sub

    '    Private Sub griAlmacenMaterial_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAlmacenMaterial.BeforeRowsDeleted
    '        e.Cancel = True
    '    End Sub

    '    Private Sub griAlmacenMaterial_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles griAlmacenMaterial.InitializeLayout
    '        With griAlmacenMaterial
    '            .DisplayLayout.Bands(0).SortedColumns.Add("CodigoMaterial", False, True)
    '            .DisplayLayout.GroupByBox.Hidden = True
    '            .DisplayLayout.GroupByBox.Style = GroupByBoxStyle.Compact
    '        End With
    '    End Sub

    '    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
    '        Try
    '            mt_AgregarMaterial()
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '        End Try
    '    End Sub

    '    Private Sub btnQuitar_Click(sender As Object, e As EventArgs)
    '        Try
    '            mt_QuitarMaterial()
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '        End Try
    '    End Sub

    '    Private Sub txtMaterial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaterial.KeyDown
    '        Try
    '            If e.KeyCode = Keys.Enter Then
    '                mt_ListarMateriales()
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '        End Try
    '    End Sub



    Private Sub griDocumento_DoubleClickRow(sender As Object, e As EventArgs) Handles griDocumento.DoubleClickRow
        Try
            Editar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub



    '    Private Sub txtMTC_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles txtMTC.EditorButtonClick
    '        Try
    '            Select Case e.Button.Key
    '                Case "Right"
    '                    'If txtMTC.Text = "" Then
    '                    Dim oeVehiculo As New e_Vehiculo
    '                    Dim olVehiculo As New l_Vehiculo

    '                    oeVehiculo = New e_Vehiculo
    '                    oeVehiculo.TipoOperacion = "L"
    '                    oeVehiculo.Id = cmbVehiculo.Value
    '                    oeVehiculo = olVehiculo.Obtener(oeVehiculo)

    '                    oeVehiculo.TipoOperacion = "A"
    '                    oeVehiculo.NroMTC = txtMTC.Text
    '                    '  Operacion = "Editar"
    '                    If MessageBox.Show("¿Desea Actualizar el Nro. MTC del Vehículo?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '                        olVehiculo.Guardar(oeVehiculo)
    '                    End If
    '                    'End If
    '            End Select
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '        End Try
    '    End Sub

    '    Private Sub cboChofer_ValueChanged(sender As Object, e As EventArgs) Handles cboChofer.ValueChanged
    '        If cboChofer.Value <> Nothing Then
    '            Dim oeChofer As New e_PersonaDocumento
    '            Dim olChofer As New l_PersonaDocumento
    '            oeChofer = New e_PersonaDocumento
    '            oeChofer.TipoOperacion = "L"
    '            oeChofer.IdPersona = cboChofer.Value
    '            oeChofer = olChofer.Obtener(oeChofer)
    '            txtNroLicencia.Text = oeChofer.NumeroDocumento
    '        End If
    '    End Sub

    '    Private Sub cboCarreta_ValueChanged(sender As Object, e As EventArgs) Handles cboCarreta.ValueChanged
    '        If cboCarreta.Value <> Nothing Then
    '            Dim oeVehiculo As New e_Vehiculo
    '            Dim olVehiculo As New l_Vehiculo

    '            oeVehiculo = New e_Vehiculo
    '            oeVehiculo.TipoOperacion = "L"
    '            oeVehiculo.Id = cboCarreta.Value
    '            oeVehiculo = olVehiculo.Obtener(oeVehiculo)
    '            txtNroMTCC.Text = oeVehiculo.NroMTC

    '            ''''Muestra el propietario de las Carretas
    '            Dim oeEmpresa As New e_Empresa
    '            Dim olEmpresa As New l_Empresa
    '            oeEmpresa.TipoOperacion = "LST"
    '            oeEmpresa.Id = oeVehiculo.IdEmpresaPropietaria
    '            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
    '            txtPropietarioCarreta.Text = oeEmpresa.Nombre

    '        End If
    '    End Sub

    '    Private Sub txtNroMTCC_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles txtNroMTCC.EditorButtonClick
    '        Try
    '            Select Case e.Button.Key
    '                Case "Right"
    '                    'If txtMTC.Text = "" Then
    '                    Dim oeVehiculo As New e_Vehiculo
    '                    Dim olVehiculo As New l_Vehiculo

    '                    oeVehiculo = New e_Vehiculo
    '                    oeVehiculo.TipoOperacion = "L"
    '                    oeVehiculo.Id = cboCarreta.Value
    '                    oeVehiculo = olVehiculo.Obtener(oeVehiculo)

    '                    oeVehiculo.TipoOperacion = "A"
    '                    oeVehiculo.NroMTC = txtNroMTCC.Text
    '                    ' Operacion = "Editar"
    '                    If MessageBox.Show("¿Desea Actualizar el Nro. MTC de la Carreta?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '                        olVehiculo.Guardar(oeVehiculo)
    '                    End If
    '                    'End If
    '            End Select
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '        End Try
    '    End Sub

    '    Private Sub txtNroLicencia_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles txtNroLicencia.EditorButtonClick
    '        Try
    '            Select Case e.Button.Key
    '                Case "Right"
    '                    'If txtMTC.Text = "" Then
    '                    Dim oePersonaDocumento As New e_PersonaDocumento
    '                    Dim olPersonaDocumento As New l_PersonaDocumento

    '                    oePersonaDocumento = New e_PersonaDocumento
    '                    oePersonaDocumento.TipoOperacion = "L"
    '                    oePersonaDocumento.IdPersona = cboChofer.Value
    '                    oePersonaDocumento = olPersonaDocumento.Obtener(oePersonaDocumento)

    '                    oePersonaDocumento.TipoOperacion = "A"
    '                    oePersonaDocumento.NumeroDocumento = txtNroLicencia.Text
    '                    ' Operacion = "Editar"
    '                    If MessageBox.Show("¿Desea Actualizar la Licencia del Conductor?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '                        olPersonaDocumento.Guardar(oePersonaDocumento)
    '                    End If
    '                    'End If
    '            End Select
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '        End Try
    '    End Sub

    '    Private Sub griDetalleDocumento_BeforeRowsDeleted_1(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDetalleDocumento.BeforeRowsDeleted
    '        e.Cancel = True
    '    End Sub

    '    Private Sub txtSerieDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerieDoc.KeyPress
    '        If Char.IsDigit(e.KeyChar) Then
    '            e.Handled = False
    '        ElseIf Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '        End If
    '    End Sub

    '    Private Sub txtNroDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDoc.KeyPress
    '        If Char.IsDigit(e.KeyChar) Then
    '            e.Handled = False
    '        ElseIf Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '        End If
    '    End Sub

    '    Private Sub txtSerieDoc_Enter(sender As Object, e As EventArgs) Handles txtSerieDoc.Enter
    '        txtSerieDoc.Select(0, 4)
    '        Me.txtSerieDoc.SelectAll()
    '    End Sub

    '    Private Sub txtNroDoc_Enter(sender As Object, e As EventArgs) Handles txtNroDoc.Enter
    '        txtNroDoc.Select(0, 10)
    '        Me.txtNroDoc.SelectAll()
    '    End Sub

    '    Private Sub txtSerieDoc_Validated(sender As Object, e As EventArgs) Handles txtSerieDoc.Validated
    '        txtSerieDoc.Text = gmt_FormatoDocumento(txtSerieDoc.Text, 4)
    '    End Sub

    '    Private Sub txtNroDoc_Validated(sender As Object, e As EventArgs) Handles txtNroDoc.Validated
    '        txtNroDoc.Text = gmt_FormatoDocumento(txtNroDoc.Text, 10)
    '    End Sub

    '    Private Sub griDocumento_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDocumento.BeforeRowsDeleted
    '        e.Cancel = True
    '    End Sub

    '    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
    '        Try
    '            With griDocumento
    '                If griDocumento.ActiveRow.Cells("Estado").Value.ToString = "ANULADO" Or griDocumento.ActiveRow.Cells("Estado").Value.ToString = "ATENDIDO" Then
    '                    Throw New Exception("! Solo se puede anular Documentos en estado Generado..!")
    '                Else
    '                    oeGuiaRR = New e_GRR_Venta
    '                    If griDocumento.Selected.Rows.Count > 0 Then
    '                        oeGuiaRR.Id = .ActiveRow.Cells("Id").Value
    '                        oeGuiaRR = olGuiaRR.Obtener(oeGuiaRR)
    '                        oeGuiaRRDetalle = New e_GuiaRemisionRemitente_Detalle
    '                        olGuiaRRDetalle = New l_GuiaRemisionRemitente_Detalle
    '                        oeGuiaRRDetalle.IdGuiaRemRemitente = .ActiveRow.Cells("Id").Value
    '                        oeGuiaRR.lstDetalleGuiaRemitente = olGuiaRRDetalle.Listar(oeGuiaRRDetalle)
    '                        '  If gfc_ValidarOrdEjecutada(oeDocumento.Id) Then
    '                        If MessageBox.Show("Esta seguro de anular el documento : " &
    '                             .ActiveRow.Cells("Serie").Value.ToString & "-" & .ActiveRow.Cells("Numero").Value.ToString & " ?",
    '                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
    '                            oeGuiaRR.TipoOperacion = "N"
    '                            oeGuiaRR.UsuarioCrea = gUsuarioEOS.Nombre
    '                            olGuiaRR.Guardar(oeGuiaRR)
    '                            MsgBox("El documento ha sido anulado exitosamente", MsgBoxStyle.Information, Me.Text)
    '                            Consultar(True)
    '                        End If
    '                        'End If

    '                    End If
    '                End If
    '            End With
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '        End Try
    '    End Sub

    '    Private Sub cboPuntoLlegada_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboPuntoLlegada.EditorButtonClick
    '        Try
    '            Select Case e.Button.Key
    '                Case "Right"
    '                    cboPuntoLlegada.SelectedIndex = -1
    '                    mt_CargarDirecciones()
    '                Case "Left"
    '                    If MessageBox.Show("¿Desea Agregar Nueva Dirección?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

    '                        Dim frm As New frm_EmpresaDireccion
    '                        With frm
    '                            .IdEmpresa.Text = txtProveedor.Tag
    '                            .ShowDialog()
    '                        End With
    '                    End If
    '            End Select
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '        End Try
    '    End Sub

    '    Private Sub btmConsultar_Click(sender As Object, e As EventArgs) Handles btmConsultar.Click
    '        Try
    '            oeOrdenSalida = New e_Orden
    '            olOrdenSalida = New l_Orden
    '            oeOrdenSalida.TipoOperacion = "E"
    '            GriOrdenesSalidas.DataSource = olOrdenSalida.Listar(oeOrdenSalida)
    '        Catch ex As Exception
    '            Throw ex
    '        End Try


    '    End Sub

    '    Private Sub btnAgregarOs_Click(sender As Object, e As EventArgs) Handles btnAgregarOs.Click
    '        Try
    '            mt_AgregarOrden(1)
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '        End Try
    '    End Sub

    '    Private Sub btnQuitarD_Click(sender As Object, e As EventArgs) Handles btnQuitarD.Click
    '        mt_QuitarMaterial()
    '    End Sub
    '#End Region

    '#Region "Metodos"


    Private Sub mt_Mostrar()
        Try
            oeGuiaRR = New e_GRR_Venta
            'loOrdenDocumento = New List(Of e_OrdenDocumento)
            oeGuiaRR.Id = griDocumento.ActiveRow.Cells("Id").Value
            oeGuiaRR = olGuiaRR.Obtener(oeGuiaRR)

            gmt_ListarEmpresa("6", cmb_Cliente, oeGuiaRR.IdCliente, False)

            cmb_Cliente.Value = oeGuiaRR.IdCliente


            'txtProveedor.Text = oeGuiaRR.Proveedor
            'txtProveedor.Tag = oeGuiaRR.IdClienteProveedor
            txtSerie.Text = oeGuiaRR.Serie
            txtNumero.Text = oeGuiaRR.Numero
            cmbMotivoTraslado.Value = oeGuiaRR.IdMotivoTraslado
            'txtLlegada.Text = oeGuiaRR.Destino
            txtPartida.Text = oeGuiaRR.Partida
            cmbVehiculo.Value = oeGuiaRR.IdVehiculo
            cboCarreta.Value = oeGuiaRR.IdCarreta
            'gmt_ListarChoferes("", cboChofer, oeGuiaRR.IdChofer)
            cboChofer.Value = oeGuiaRR.IdChofer
            dtpFechaDocumento.Value = oeGuiaRR.Fecha

            griDetalleDocumento.DataSource = loGuiaRRDetalle
            oeGuiaRRDetalle = New e_GuiaRemisionRemitente_Detalle
            oeGuiaRRDetalle.IdGRR_Venta = oeGuiaRR.Id
            loGuiaRRDetalle = New List(Of e_GuiaRemisionRemitente_Detalle)
            olGuiaRRDetalle = New l_GuiaRemisionRemitente_Detalle
            ''Obtenemos las listas

            loGuiaRRDetalle = olGuiaRRDetalle.Listar(oeGuiaRRDetalle)
            'loGuiaRRDetalle.AddRange(olGuiaRRDetalle.Listar(oeGuiaRRDetalle))
            griDetalleDocumento.DataSource = loGuiaRRDetalle
            griDetalleDocumento.DataBind()
            mt_CombosGrilla()
            'fc_Grias()
            'mt_CargarDirecciones()
            cboPuntoLlegada.Text = oeGuiaRR.Destino
            chkAsociar.Visible = False
            'oeDocumento.Id = griDocumento.ActiveRow.Cells("Id").Value
            'oeDocumento = olDocumento.Obtener(oeDocumento)
            'oeDocumento.oeGuiaRR = New e_GRR_Venta
            'olGuiaRR = New l_GuiaRR
            ' '' ''oeDocumento.oeGuiaRR.IdDocumento = oeDocumento.Id
            'oeDocumento.oeGuiaRR = olGuiaRR.Obtener(oeDocumento.oeGuiaRR)
            'txtProveedor.Text = oeDocumento.ClienteProveedor
            'txtProveedor.Tag = oeDocumento.IdClienteProveedor
            'txtSerie.Text = oeDocumento.Serie
            'txtNumero.Text = oeDocumento.Numero
            'cmbMotivoTraslado.Value = oeDocumento.IdMotivoTraslado
            'txtLlegada.Text = oeDocumento.oeGuiaRR.Destino
            'txtPartida.Text = oeDocumento.oeGuiaRR.Partida
            'cmbVehiculo.Value = oeDocumento.oeGuiaRR.IdVehiculo
            'cboCarreta.Value = oeDocumento.oeGuiaRR.IdCarreta
            'gmt_ListarChoferes("", cboChofer, oeDocumento.oeGuiaRR.IdChofer)
            'cboChofer.Value = oeDocumento.oeGuiaRR.IdChofer
            'dtpFechaDocumento.Value = oeDocumento.FechaEmision

            'Mostramos la Orden Salida
            'oeOrdenDocumento = New e_OrdenDocumento
            'loOrdenDocumento = New List(Of e_OrdenDocumento)
            'oeOrdenDocumento.TipoOperacion = "4"
            'oeOrdenDocumento.IdDocumento = oeGuiaRR.Id
            'oeOrdenDocumento.TipoExistencia = 1
            'oeOrdenDocumento.TipoOrden = 1
            'oeOrdenDocumento.IdTipoDocumento = "1CIX009"
            'loOrdenDocumento.AddRange(olOrdenDocumento.Listar(oeOrdenDocumento))

            'If loOrdenDocumento.Count > 0 Then
            '    loOrdenDocumento(0).NombreTipo = "ORDEN SALIDA"
            '    griOrdenSalida.DataSource = loOrdenDocumento
            '    gmt_OcultarColumna(griOrdenSalida, True, "IdDocumento", "IdTipoDocumento", "Fecha", "IdOrden", "TipoOrden", "TipoExistencia")
            '    mt_CargarOrden_OrdenComercial()
            'End If
            btnAgregarD.Enabled = False
            btnQuitarD.Enabled = False
            btnAgregarOv.Enabled = False
            BtnQuitarOv.Enabled = False
            btnAgregarOs.Enabled = False
            btnQuitarOs.Enabled = False


            'oeDetalleDocumento = New e_DetalleDocumento
            '' '' ''  oeDetalleDocumento.IdDocumento = oeDocumento.Id
            ' oeDetalleDocumento.IdEmpresaSis = gstrIdEmpresaSis
            ' oeDetalleDocumento.IdSucursal = gstrIdSucursal
            'loDetalleDocumento.AddRange(olDetalleDocumento.Listar(oeDetalleDocumento))
            ' griDetalleDocumento.DataSource = loDetalleDocumento


            ' '' ''If oeDocumento.Estado = "TERMINADO" Then
            ' '' ''    gbeMateriales.Visible = False
            ' '' ''    UltraGroupBox5.Enabled = False
            ' '' ''End If
            ' '' ''If oeDocumento.TipoReferencia <> 0 Then
            ' '' ''    gbeMateriales.Visible = False
            ' '' ''    UltraGroupBox5.Enabled = False
            ' '' ''End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub mt_CargarOrden_OrdenVenta(OrdenVenta As e_OrdenVenta)
        Try
            olCombo = New l_Combo
            gmt_MostrarTabs(1, ficGuiaRR, 1)
            gmt_ListarEmpresa("6", cmb_Cliente, OrdenVenta.IdEmpresa, False)
            cmb_Cliente.Value = OrdenVenta.IdEmpresa

            Dim lo_OrdenVentaMaterial As List(Of e_OrdenVentaMaterial)
            Dim ol_OrdenVentaMaterial As New l_OrdenVentaMaterial
            lo_OrdenVentaMaterial = ol_OrdenVentaMaterial.Listar(New e_OrdenVentaMaterial With {.TipoOperacion = "GRR", .IdOrdenComercial = OrdenVenta.Id})

            loGuiaRRDetalle = New List(Of e_GuiaRemisionRemitente_Detalle)
            For Each detalle In lo_OrdenVentaMaterial
                oeGuiaRRDetalle = New e_GuiaRemisionRemitente_Detalle
                With oeGuiaRRDetalle
                    .IdEmpresaSis = gs_IdEmpresaSistema
                    .IdSucursal = gs_IdSucursal
                    .PrefijoID = gs_PrefijoIdSucursal
                    .IdMaterial = detalle.IdMaterial
                    .CodigoMaterial = detalle.Codigo
                    .Material = detalle.Material
                    .IdUnidadMedida = detalle.IdUnidadMedida
                    .Cantidad = detalle.Cantidad
                    .Peso = detalle.CantidadReal
                End With
                loGuiaRRDetalle.Add(oeGuiaRRDetalle)
            Next

            griDetalleDocumento.DataSource = loGuiaRRDetalle
            griDetalleDocumento.DataBind()

            mt_CombosGrilla()

            oeRefAsoc = New e_ReferenciaAsociada
            oeRefAsoc.TipoOperacion = "I"
            oeRefAsoc.PrefijoID = gs_PrefijoIdSucursal
            oeRefAsoc.IdTablaPrincipal = OrdenVenta.Id
            oeRefAsoc.TipoRelacion = 2

            cmb_Cliente.Focus()
            Operacion = "Nuevo"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Function fc_Guardar() As Boolean
        Try
            mt_LlenaObjeto()
            If olGuiaRR.Guardar(oeGuiaRR) Then
                MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)

                If MessageBox.Show("¿Desea Imprimir la Guía de Remisión Remitente..?" & "Con número: " & txtSerie.Text & "-" & txtNumero.Text, "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'Dim formulario As New frm_ImprimirGRR
                    'formulario.mt_CargarDatos(oeGuiaRR.Id)
                    'formulario.ShowDialog()
                End If

            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '    Public Sub mt_LlenaObjeto()
    '        Try
    '            With oeDocumento
    '                .IdEmpresaSis = gstrIdEmpresaSis
    '                .IdSucursal = gstrIdSucursal
    '                .IdClienteProveedor = txtProveedor.Tag
    '                .ClienteProveedor = txtProveedor.Text
    '                .IdTipoDocumento = "1CIX009"
    '                .IdEstado = "1CIX020"
    '                .IdPeriodo = ""
    '                .CuentaContable = ""
    '                .IdMoneda = "1CIX00000000000005"
    '                .Tipo = 2
    '                .TipoExistencia = 1
    '                .Serie = gmt_FormatoDocumento(txtSerie.Text, 4)
    '                .Numero = gmt_FormatoDocumento(txtNumero.Text, 8)
    '                .FechaEmision = dtpFechaDocumento.Value
    '                .FechaVencimiento = Date.Parse("01/01/1901")
    '                .UsuarioCrea = gUsuarioEOS.Nombre
    '                With .oeGuiaRR
    '                    .IdMotivoTraslado = cmbMotivoTraslado.Value
    '                    .IdVehiculo = cmbVehiculo.Value
    '                    .IdCarreta = cboCarreta.Value
    '                    .IdChofer = cboChofer.Value
    '                    .Partida = txtPartida.Text
    '                    .Destino = cboPuntoLlegada.Text 'txtLlegada.Text
    '                    .UsuarioCrea = gUsuarioEOS.Nombre
    '                    .UsuarioModifica = gUsuarioEOS.Nombre
    '                End With
    '                .lstDetalleDocumento = New List(Of e_DetalleDocumento)
    '                .lstDetalleDocumento.AddRange(loDetalleDocumento)
    '                .lstOrdenDocumento = New List(Of e_OrdenDocumento)
    '                .lstOrdenDocumento.AddRange(loOrdenDocumento)
    '                If Operacion = "Nuevo" Then
    '                    .TipoOperacion = "I"
    '                Else
    '                    .TipoOperacion = "A"
    '                End If
    '            End With
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    Public Sub mt_LlenaObjeto()
        Try
            If fc_Validar() Then
                'loGuiaRRDetalle = New List(Of e_GuiaRemisionRemitente_Detalle)
                With oeGuiaRR
                    If Operacion = "Nuevo" Then : .TipoOperacion = "I" : Else : .TipoOperacion = "A" : End If
                    .PrefijoID = gs_PrefijoIdSucursal
                    .IdEmpresaSis = gs_IdEmpresaSistema
                    .IdSucursal = gs_IdSucursal
                    .IdCliente = cmb_Cliente.Value
                    .IdTransportista = cboTransportista.Value
                    .Fecha = dtpFechaDocumento.Value
                    .FechaTraslado = dtp_FechaTraslado.Value
                    .Serie = FormatoDocumento(txtSerie.Text, 4)
                    .Numero = FormatoDocumento(txtNumero.Text, 8)
                    .IdMotivoTraslado = cmbMotivoTraslado.Value
                    If .IdTransportista = gs_IdClienteProveedorSistema Then
                        .IdVehiculo = cmbVehiculo.Value
                        .IdCarreta = cboCarreta.Value
                        .IdChofer = cboChofer.Value
                        .Vehiculo = String.Empty
                        .Carreta = String.Empty
                        .Chofer = String.Empty
                    Else
                        .IdVehiculo = String.Empty
                        .IdCarreta = String.Empty
                        .IdChofer = String.Empty
                        .Vehiculo = cmbVehiculo.Text
                        .Carreta = cboCarreta.Text
                        .Chofer = cboChofer.Text
                    End If


                    .IdPartida = cboPuntoPartida.Value
                    .Partida = txtPartida.Text
                    .IdDestino = cboPuntoLlegada.Value
                    .Destino = cboPuntoLlegada.Text
                    .UsuarioCrea = gUsuarioSGI.Id
                    .lo_GRRVenta_Detalle = New List(Of e_GuiaRemisionRemitente_Detalle)
                    .lo_GRRVenta_Detalle = loGuiaRRDetalle
                End With
            End If


            'With oeOrdenDocumento
            '    loOrdenDocumento = New List(Of e_OrdenDocumento)
            '    .TipoOrden = 1
            '    .TipoOperacion = oeGuiaRR.TipoOperacion
            '    .IdTipoDocumento = "1CIX009"
            '    .UsuarioCrea = gUsuarioEOS.Nombre
            '    .UsuarioModifica = gUsuarioEOS.Nombre
            '    loOrdenDocumento.Add(oeOrdenDocumento)
            '    oeGuiaRR.lstOrdenGuia = loOrdenDocumento
            'End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_Validar() As Boolean
        Try
            If cmb_Cliente.SelectedRow Is Nothing Then Throw New Exception("Seleccione Cliente")
            If cboTransportista.SelectedRow Is Nothing Then Throw New Exception("Seleccione Transporista")
            If txtMTC.Text.Trim = String.Empty Then Throw New Exception("Ingrese MTC del Tracto")
            If txtNroMTCC.Text.Trim = String.Empty Then Throw New Exception("Ingrese MTC de la Carreta")
            If cboPuntoPartida.SelectedIndex = -1 Then Throw New Exception("Seleccione Partida")
            If cboPuntoLlegada.SelectedIndex = -1 Then Throw New Exception("Seleccione Llegada")
            If txtPartida.Text.Trim = String.Empty Then Throw New Exception("Ingrese Partida")
            If txtLlegada.Text.Trim = String.Empty Then Throw New Exception("Ingrese Llegada")
            If txtNroLicencia.Text.Trim = String.Empty Then Throw New Exception("Ingrese Brevete del Conductor")
            If cboTransportista.Value = gs_IdClienteProveedorSistema Then
                If cmbVehiculo.SelectedIndex = -1 Then Throw New Exception("Seleccione Traco")
                If cboCarreta.SelectedIndex = -1 Then Throw New Exception("Seleccione Carreta")
                If cboChofer.SelectedRow Is Nothing Then Throw New Exception("Seleccione Conductor")
            Else
                If cmbVehiculo.Text.Trim = String.Empty Then Throw New Exception("Ingrese Tracto")
                If cboCarreta.Text.Trim = String.Empty Then Throw New Exception("Ingrese Carreta")
                If cboChofer.Text.Trim = String.Empty Then Throw New Exception("Ingrese Conductor")
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Private Sub mt_CombosGrilla()
        Try
            With griDetalleDocumento
                For j As Integer = 0 To .Rows.Count - 1
                    Dim strIdTipoUnidad As String = .Rows(j).Cells("IdUnidadMedida").Value
                    gfc_CombroGrillaCelda("IdUnidadMedida", "Nombre", j, griDetalleDocumento, olCombo.ComboGrilla(UnidadMedidaPublic.Where(Function(i) i.Id = strIdTipoUnidad).ToList))

                    'Dim strIdMaterial As String = .Rows(j).Cells("IdMaterial").Value.ToString
                    'gfc_CombroGrillaCelda("IdAlmacen", "Nombre", j, Grilla, olCombo.ComboGrilla(gloAlmMat.Where(Function(i) i.Descripcion = strIdMaterial).ToList))

                    'Dim strIdAlmacen As String = .Rows(j).Cells("IdAlmacen").Value.ToString
                    'gfc_CombroGrillaCelda("IdSubAlmacen", "Nombre", j, Grilla, olCombo.ComboGrilla(gloSubAlm.Where(Function(i) i.Descripcion = strIdAlmacen).ToList))
                Next
                .DataBind()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    '    Private Sub mt_ListarMateriales()
    '        Try
    '            If txtMaterial.Text = String.Empty Then Throw New Exception("Escriba Nombre del Material")
    '            oeAlmMaterial = New e_AlmacenMaterial
    '            loAlmMaterial = New List(Of e_AlmacenMaterial)
    '            With oeAlmMaterial
    '                .TipoOperacion = "1"
    '                .IdEmpresaSis = gstrIdEmpresaSis
    '                .IdSucursal = gstrIdSucursal
    '                If chbBuscarCod.Checked Then
    '                    .CodigoMaterial = txtMaterial.Text
    '                Else
    '                    .Material = txtMaterial.Text
    '                End If
    '                loAlmMaterial.AddRange(olAlmMaterial.Listar(oeAlmMaterial))
    '                griAlmacenMaterial.DataSource = loAlmMaterial
    '            End With
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Public Sub mt_QuitarMaterial()
    '        Try
    '            If griDetalleDocumento.Selected.Rows.Count > 0 Then
    '                oeDetalleDocumento = New e_DetalleDocumento
    '                oeDetalleDocumento = griDetalleDocumento.ActiveRow.ListObject
    '                If oeDetalleDocumento.TipoOperacion = "I" Then
    '                    loDetalleDocumento.Remove(oeDetalleDocumento)
    '                    griDetalleDocumento.DataSource = loDetalleDocumento
    '                Else
    '                    oeDetalleDocumento.TipoOperacion = "E"
    '                    griDetalleDocumento.ActiveRow.Hidden = True
    '                End If
    '            End If
    '            griDetalleDocumento.DataBind()
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Public Sub mt_TransponerOrdenDocumento(oeOrden As e_Orden)
    '        Try
    '            Dim oeEmpresa As New e_Empresa
    '            Dim olEmpresa As New l_Empresa
    '            mt_IniciarFormulario()
    '            Nuevo()
    '            oeOrdenSalida = New e_Orden
    '            oeOrdenSalida = oeOrden
    '            mt_AgregarOrden()
    '            Me.txtSerie.Focus()
    '            Me.cmbMotivoTraslado.SelectedIndex = 0
    '            oeEmpresa.TipoOperacion = "CLI"
    '            oeEmpresa.Id = oeOrdenSalida.IdEmpresa
    '            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
    '            ' txtLlegada.Text = oeEmpresa.DireccionFiscal
    '            'cboPuntoLlegada.Text=
    '            ' txtNroBrevete.Text = oeEmpresa.NroBrevete
    '            oeEmpresa = New e_Empresa
    '            oeEmpresa.TipoOperacion = "LST"
    '            oeEmpresa.Id = gstrIdEmpresa
    '            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
    '            txtPartida.Text = oeEmpresa.DireccionFiscal
    '            fc_Grias()

    '            'Cargamos la Orden de Salida
    '            loOrdenDocumento(0).NombreTipo = "ORDEN SALIDA"
    '            griOrdenSalida.DataSource = loOrdenDocumento
    '            gmt_OcultarColumna(griOrdenSalida, True, "IdDocumento", "IdTipoDocumento", "Fecha", "IdOrden", "TipoOrden", "TipoExistencia")


    '            mt_CargarOrden_OrdenComercial()

    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Public Sub mt_TransponerDocumentoCtable(oeDocumento As e_Documento)
    '        Try
    '            Dim oeEmpresa As New e_Empresa
    '            Dim olEmpresa As New l_Empresa
    '            mt_IniciarFormulario()
    '            Nuevo()
    '            Dim oeDocumentos As e_Documento
    '            oeDocumentos = New e_Documento
    '            oeDocumentos = oeDocumento
    '            ' mt_AgregarOrden()
    '            Me.txtSerie.Focus()
    '            Me.cmbMotivoTraslado.SelectedIndex = 0
    '            oeEmpresa.TipoOperacion = "CLI"
    '            oeEmpresa.Id = oeDocumentos.IdClienteProveedor
    '            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
    '            '  txtLlegada.Text = oeEmpresa.DireccionFiscal
    '            ' txtNroBrevete.Text = oeEmpresa.NroBrevete
    '            oeEmpresa = New e_Empresa
    '            oeEmpresa.TipoOperacion = "LST"
    '            oeEmpresa.Id = gstrIdEmpresa
    '            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
    '            txtPartida.Text = oeEmpresa.DireccionFiscal
    '            txtProveedor.Text = oeDocumento.ClienteProveedor
    '            txtProveedor.Tag = oeDocumento.IdClienteProveedor
    '            griDetalleDocumento.DataSource = oeDocumento.lstDetalleDocumento
    '            loDetalleDocumento = oeDocumento.lstDetalleDocumento

    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Private Sub mt_AgregarOrden()
    '        oeOrdenDocumento = New e_OrdenDocumento
    '        With oeOrdenDocumento
    '            .IdOrden = oeOrdenSalida.Id
    '            .Orden = oeOrdenSalida.Orden
    '            .TipoOrden = 1
    '            .TipoOperacion = "I"
    '            .FechaOrden = oeOrdenSalida.FechaCrea
    '            .NombreTipo = "ORDEN INGRESO"
    '            .Proveedor = oeOrdenSalida.Empresa
    '            .TipoExistencia = 1
    '            .UsuarioCrea = gUsuarioEOS.Nombre
    '        End With
    '        Me.txtProveedor.Text = oeOrdenSalida.Empresa
    '        Me.txtProveedor.Tag = oeOrdenSalida.IdEmpresa
    '        Me.dtpFechaDocumento.Value = oeOrdenSalida.FechaCrea
    '        loOrdenDocumento.Add(oeOrdenDocumento)
    '        mt_AsociarDetallesOCM(oeOrdenDocumento.IdOrden)
    '        griDetalleDocumento.DataBind()
    '    End Sub

    '    Private Sub mt_AsociarDetallesOCM(IdOrden As String)
    '        Try
    '            oeDetalleOrden = New e_DetalleOrden
    '            loDetalleOrden = New List(Of e_DetalleOrden)
    '            oeDetalleOrden.IdOrden = IdOrden
    '            loDetalleOrden.AddRange(olDetalleOrden.Listar(oeDetalleOrden))

    '            loGuiaRRDetalle = New List(Of e_GuiaRemisionRemitente_Detalle)
    '            griDetalleDocumento.DataSource = loGuiaRRDetalle
    '            Dim PesoMat As Double = 0
    '            For Each oe As e_DetalleOrden In loDetalleOrden
    '                oeMaterial = New e_Material
    '                olMaterial = New l_Material
    '                loMaterial = New List(Of e_Material)
    '                oeMaterial.TipoOperacion = ""
    '                oeMaterial.Id = oe.IdMaterial
    '                loMaterial = olMaterial.Listar(oeMaterial)
    '                PesoMat = oeMaterial.Peso
    '                oeGuiaRRDetalle = New e_GuiaRemisionRemitente_Detalle
    '                PesoMat = loMaterial(0).Peso
    '                oeGuiaRRDetalle.TipoOperacion = "I"
    '                oeGuiaRRDetalle.Peso = oe.Cantidad * PesoMat
    '                oeGuiaRRDetalle.IdEmpresaSis = gstrIdEmpresaSis
    '                oeGuiaRRDetalle.IdSucursal = gstrIdSucursal
    '                oeGuiaRRDetalle.IdUnidadMedida = oe.IdUnidadMedida
    '                oeGuiaRRDetalle.IdMaterialServicio = oe.IdMaterial
    '                oeGuiaRRDetalle.Codigo = oe.Codigo
    '                oeGuiaRRDetalle.MaterialServicio = oe.Material
    '                oeGuiaRRDetalle.Cantidad = oe.Cantidad
    '                oeGuiaRRDetalle.Tipo = 1
    '                oeGuiaRRDetalle.UsuarioCrea = gUsuarioEOS.Nombre
    '                loGuiaRRDetalle.Add(oeGuiaRRDetalle)
    '            Next
    '            griDetalleDocumento.DataSource = loGuiaRRDetalle
    '            griDetalleDocumento.DataBind()
    '            gmt_OcultarColumna(griDetalleDocumento, True, "IdGuiaRemRemitente")

    '            'For Each oe As e_DetalleOrden In loDetalleOrden
    '            '    loDetalleDocumento = New List(Of e_DetalleDocumento)
    '            '    oeDetalleDocumento = New e_DetalleDocumento
    '            '    oeDetalleDocumento.TipoOperacion = "I"
    '            '    oeDetalleDocumento.IdEmpresaSis = gstrIdEmpresaSis
    '            '    oeDetalleDocumento.IdSucursal = gstrIdSucursal
    '            '    oeDetalleDocumento.IdTipoUnidadMedida = oe.IdTipoUnidadMedida
    '            '    oeDetalleDocumento.IdAlmacen = oe.IdAlmacen
    '            '    oeDetalleDocumento.IdUnidadMedida = oe.IdUnidadMedida
    '            '    oeDetalleDocumento.IdSubAlmacen = oe.IdSubAlmacen
    '            '    oeDetalleDocumento.IdMaterialServicio = oe.IdMaterial
    '            '    oeDetalleDocumento.Codigo = oe.Codigo
    '            '    oeDetalleDocumento.MaterialServicio = oe.Material
    '            '    oeDetalleDocumento.Cantidad = oe.Cantidad
    '            '    oeDetalleDocumento.IndImpuesto = False
    '            '    oeDetalleDocumento.Tipo = 1
    '            '    oeDetalleDocumento.UsuarioCrea = gUsuarioEOS.Nombre
    '            '    loDetalleDocumento.Add(oeDetalleDocumento)
    '            'Next
    '            mt_CombosGrilla()
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub


    '    Public Sub gmt_ListarChoferes(Tipo As String, Combo As UltraCombo, IdPersona As String)
    '        Try
    '            loPersonaDocumento = New List(Of e_PersonaDocumento)
    '            oePersonaDocumento = New e_PersonaDocumento
    '            oePersonaDocumento.TipoOperacion = Tipo
    '            If IdPersona = "" Then
    '                oePersonaDocumento.Descripcion = Combo.Text.Trim
    '                loPersonaDocumento = olPersonaDocumento.Listar(oePersonaDocumento)
    '            Else
    '                oePersonaDocumento.IdPersona = IdPersona
    '                loPersonaDocumento = olPersonaDocumento.Listar(oePersonaDocumento)
    '            End If

    '            'Dim _lePer = (From le In loPersonaDocumento Select IdChofer = le.IdPersona.Trim, Conductor = le.Conductor)
    '            'Combo.DataSource = _lePer.ToList

    '            Dim _lePer = (From le In loPersonaDocumento Select le)
    '            Combo.DataSource = _lePer.ToList
    '            With cboChofer.DisplayLayout.Bands(0)
    '                .Columns("IdPersona").Hidden = True
    '                .Columns("NroDocumento").Hidden = True
    '            End With

    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub


    '    Private Sub mt_AgregarOrden(Tipo As Integer)
    '        Try
    '            Select Case Tipo 'TIPO DE ORDEN :ORDEN SALIDA
    '                Case 1
    '                    oeOrdenDocumento = New e_OrdenDocumento
    '                    oeOrdenDocumento.IdOrden = GriOrdenesSalidas.ActiveRow.Cells("Id").Value
    '                    oeOrdenSalida = New e_Orden
    '                    oeOrdenSalida = GriOrdenesSalidas.ActiveRow.ListObject
    '                    With oeOrdenDocumento
    '                        .IdOrden = oeOrdenSalida.Id
    '                        .Orden = oeOrdenSalida.Orden
    '                        .TipoOrden = Tipo
    '                        .TipoOperacion = "I"
    '                        .FechaOrden = oeOrdenSalida.FechaCrea
    '                        .NombreTipo = "ORDEN SALIDA"
    '                        .Proveedor = oeOrdenSalida.Empresa
    '                        .TipoExistencia = 1
    '                        .UsuarioCrea = gUsuarioEOS.Nombre
    '                    End With
    '                    intExistencia = oeOrdenDocumento.TipoExistencia
    '                    Me.txtProveedor.Text = oeOrdenSalida.Empresa
    '                    Me.txtProveedor.Tag = oeOrdenSalida.IdEmpresa
    '                    loOrdenDocumento.Add(oeOrdenDocumento)
    '                    mt_AsociarDetallesOCM(oeOrdenDocumento.IdOrden, 1, intExistencia)
    '                    griOrdenSalida.DataBind()
    '                    griDetalleDocumento.DataBind()
    '                    gmt_OcultarColumna(griDetalleDocumento, True, "IdDocumento", "IdAlmacen", "IdSubAlmacen", "IdTipoUnidadMedida", "CostoUnitario", "PrecioUnitario", "Dscto", "PrecioTotal", "IndImpuesto")
    '                    mt_CombosGrilla(griDetalleDocumento)
    '                    If Tipo = 3 Then
    '                        mt_ConvertirUnidad(griDetalleDocumento) '18-08
    '                    End If
    '                    ficDetalle.Tabs(0).Selected = True
    '            End Select
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Private Sub mt_ConvertirUnidad(Grilla As UltraGrid)
    '        Try
    '            With Grilla
    '                For j As Integer = 0 To .Rows.Count - 1
    '                    Dim strIdUnidad As String = .Rows(j).Cells("IdUnidadMedida").Text '.Value.ToString
    '                    Dim cant As String = .Rows(j).Cells("Cantidad").Value

    '                    If Trim(strIdUnidad.ToUpper) = Trim("MILLAR") Then
    '                        oeMaterial = New e_Material
    '                        oeDetalleDocumento = New e_DetalleDocumento ' e_OrdenComercialMaterial

    '                        oeDetalleDocumento = griDetalleDocumento.Rows(j).ListObject
    '                        oeMaterial.TipoOperacion = ""
    '                        oeMaterial.Id = oeDetalleDocumento.IdMaterialServicio
    '                        oeMaterial = olMaterial.Obtener(oeMaterial)

    '                        'CONVERSION A  CANTIDAD DE  TONELADAS = CANTIDAD PRODUCTO(cant) x PESO EN TONELADAS
    '                        If oeMaterial.IdTipoUnidadMedidaE = "1CIX002" And oeMaterial.IdUnidadMedidaE = "1CIX009" Then 'PESO Y TONELADA
    '                            oeDetalleDocumento.Cantidad = oeMaterial.CantidadE * cant
    '                        Else

    '                            If oeMaterial.IdTipoUnidadMedidaE = "1CIX005" And oeMaterial.IdUnidadMedidaE = "1CIX016" Then 'CANTIDAD Y MILLAR
    '                                oeDetalleDocumento.Cantidad = ((oeMaterial.Peso * 1000) / 1000) * cant
    '                            Else
    '                                oeDetalleDocumento.Cantidad = oeMaterial.Peso * cant
    '                            End If

    '                        End If
    '                        oeDetalleDocumento.IdUnidadMedida = "1CIX009"
    '                        oeDetalleDocumento.IdTipoUnidadMedida = "1CIX002"
    '                    End If

    '                Next
    '                mt_CombosGrilla(griDetalleDocumento)
    '                .DataBind()
    '            End With
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Private Sub mt_CombosGrilla(Grilla As UltraGrid)
    '        Try
    '            With Grilla
    '                For j As Integer = 0 To .Rows.Count - 1
    '                    Dim strIdTipoUnidad As String = .Rows(j).Cells("IdUnidadMedida").Value.ToString
    '                    gfc_CombroGrillaCelda("IdUnidadMedida", "Nombre", j, Grilla, olCombo.ComboGrilla(gloUniMed.Where(Function(i) i.Descripcion = strIdTipoUnidad).ToList))
    '                Next
    '                .DataBind()
    '            End With
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Private Function fc_ValidaOrden() As Boolean
    '        Try
    '            If loOrdenDocumento.Count = 0 Then Return True
    '            With griOrdenComercial.ActiveRow
    '                For Each oe As e_OrdenDocumento In loOrdenDocumento
    '                    If oe.Proveedor <> .Cells("Empresa").Value Then
    '                        Throw New Exception("Seleccione Orden del Mismo Proveedor ")
    '                    End If
    '                    If oe.IdOrden = .Cells("Id").Value Then
    '                        Throw New Exception("Orden ya Asignada")
    '                    End If
    '                    If oe.TipoExistencia <> .Cells("TipoExistencia").Value Then
    '                        Throw New Exception("Ya Selecciono un Tipo de Orden: " & IIf(oe.TipoExistencia = 1, "MATERIAL", "SERVICIO"))
    '                    End If
    '                    If oe.TipoOrden = 1 Then Throw New Exception("No Puede Agregar OC a Ordenes de Ingreso")
    '                Next
    '            End With
    '            Return True
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Function

    '    Private Sub mt_AsociarDetallesOCM(IdOrden As String, Tipo As Integer, Existencia As Integer)
    '        Try
    '            Dim bolIndicador As Boolean = False
    '            Select Case Tipo 'TIPO DE ORDEN
    '                Case 1 'ORDEN SALIDA
    '                    oeDetalleOrden = New e_DetalleOrden
    '                    loDetalleOrden = New List(Of e_DetalleOrden)
    '                    oeDetalleOrden.IdOrden = GriOrdenesSalidas.ActiveRow.Cells("Id").Value
    '                    loDetalleOrden.AddRange(olDetalleOrden.Listar(oeDetalleOrden))
    '                    loDetalleDocumento = New List(Of e_DetalleDocumento)
    '                    For Each oe As e_DetalleOrden In loDetalleOrden
    '                        oeDetalleDocumento = New e_DetalleDocumento
    '                        oeDetalleDocumento.TipoOperacion = "I"
    '                        oeDetalleDocumento.IdEmpresaSis = gstrIdEmpresaSis
    '                        oeDetalleDocumento.IdSucursal = gstrIdSucursal
    '                        oeDetalleDocumento.IdMaterialServicio = oe.IdMaterial
    '                        oeDetalleDocumento.IdUnidadMedida = oe.IdUnidadMedida
    '                        oeDetalleDocumento.Codigo = oe.Codigo
    '                        oeDetalleDocumento.MaterialServicio = oe.Material
    '                        oeDetalleDocumento.Cantidad = oe.Cantidad
    '                        oeDetalleDocumento.Tipo = Existencia
    '                        oeDetalleDocumento.PrecioUnitario = oe.PrecioUnitario
    '                        oeDetalleDocumento.PrecioTotal = oe.PrecioTotal
    '                        oeDetalleDocumento.UsuarioCrea = gUsuarioEOS.Nombre
    '                        loDetalleDocumento.Add(oeDetalleDocumento)
    '                    Next
    '            End Select
    '            griDetalleDocumento.DataSource = loDetalleDocumento.Where(Function(i) i.TipoOperacion <> "E").ToList
    '            griDetalleDocumento.DisplayLayout.Bands(0).Columns("MaterialServicio").Header.Caption = IIf(Existencia = 1, "Material", "Servicio")
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub


    '#End Region

End Class