Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

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

    Private oeAlmMaterial As e_Material
    Private olAlmMaterial As l_MaterialAlmacen
    Private loAlmMaterial As List(Of e_Material)

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
            cboTransportista.Focus() '@0001
            cboTransportista.Select() '@0001
            cmb_Cliente.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griDocumento.Selected.Rows.Count > 0 Then
                mt_Inicializar()
                mt_Mostrar()
                gmt_MostrarTabs(1, ficGuiaRR, 1)
                Operacion = "Editar"
                mt_ControlBotoneria()
                gmt_ControlBoton(0, 0, 0, 0, 1, 0, 0, 0)
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

    Public Overrides Sub Eliminar()
        Try
            If MessageBox.Show("Esta seguro de eliminar el Documento: " & griDocumento.ActiveRow.Cells("Serie").Value.ToString & " - " & griDocumento.ActiveRow.Cells("Numero").Value.ToString & " ?",
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                mt_Eliminar(griDocumento.ActiveRow.Cells("Id").Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griDocumento.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griDocumento, Me.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            If griDocumento.Selected.Rows.Count > 0 Then
                mt_ImprimirGRR_Venta(griDocumento.ActiveRow.Cells("Id").Value)
            End If
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
    '    txtSerieD.Text = FormatoDocumento(txtSerieD.Text, 4)
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If griDocumento.Selected.Rows.Count > 0 Then
                Eliminar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Try
            If griDocumento.Selected.Rows.Count > 0 Then
                mt_Anular(griDocumento.ActiveRow.Cells("Id").Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griDocumento_DoubleClickRow(sender As Object, e As EventArgs) Handles griDocumento.DoubleClickRow
        Try
            Editar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griAlmacenMaterial_CellChange(sender As Object, e As CellEventArgs) Handles griAlmacenMaterial.CellChange
        Try
            griAlmacenMaterial.UpdateData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griAlmacenMaterial_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griAlmacenMaterial.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griAlmacenMaterial.DisplayLayout.Bands(0).Layout.ActiveRow
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.Yellow
                            .Appearance.ForeColor = Color.Red
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                        End If
                    End With
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griAlmacenMaterial_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs)
        e.Cancel = True
    End Sub

    Private Sub griDetalleDocumento_BeforeRowsDeleted_1(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDetalleDocumento.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub txtSerieDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerieDoc.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNroDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDoc.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSerieDoc_Enter(sender As Object, e As EventArgs) Handles txtSerieDoc.Enter
        txtSerieDoc.Select(0, 4)
        Me.txtSerieDoc.SelectAll()
    End Sub

    Private Sub txtNroDoc_Enter(sender As Object, e As EventArgs) Handles txtNroDoc.Enter
        txtNroDoc.Select(0, 10)
        Me.txtNroDoc.SelectAll()
    End Sub

    Private Sub txtSerieDoc_Validated(sender As Object, e As EventArgs) Handles txtSerieDoc.Validated
        txtSerieDoc.Text = FormatoDocumento(txtSerieDoc.Text, 4)
    End Sub

    Private Sub txtNroDoc_Validated(sender As Object, e As EventArgs) Handles txtNroDoc.Validated
        txtNroDoc.Text = FormatoDocumento(txtNroDoc.Text, 10)
    End Sub

    Private Sub griDocumento_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDocumento.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub btnAgregarD_Click(sender As Object, e As EventArgs) Handles btnAgregarD.Click
        Try
            mt_AgregarMaterial()
            mt_CalcularTotalPeso()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitarD.Click
        Try
            mt_QuitarMaterial()
            mt_CalcularTotalPeso()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub txt_Material_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Material.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                mt_ListarMateriales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click
        Try
            mt_ListarMateriales()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griDetalleDocumento_CellChange(sender As Object, e As CellEventArgs) Handles griDetalleDocumento.CellChange
        griDetalleDocumento.UpdateData()
    End Sub

    Private Sub griDetalleDocumento_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griDetalleDocumento.AfterCellUpdate
        Try
            If griDetalleDocumento.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "Cantidad"
                        With griDetalleDocumento.ActiveRow
                            If .Cells("Cantidad").Value < 0 Then
                                .Cells("Cantidad").Value = 1
                            End If
                            .Cells("PesoTotal").Value = .Cells("Cantidad").Value * .Cells("Peso").Value
                        End With
                End Select
            End If
            mt_CalcularTotalPeso()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_CalcularTotalPeso()
        Try
            Dim mn_TotalPeso As Double = 0
            For Each detalle In loGuiaRRDetalle.Where(Function(i) i.TipoOperacion <> "E").ToList
                mn_TotalPeso += detalle.PesoTotal
            Next
            une_Peso.Value = mn_TotalPeso
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_AgregarMaterial()
        Try
            For Each detalle In loGuiaRRDetalle.Where(Function(i) i.TipoOperacion <> "E").ToList
                For Each oe As e_Material In loAlmMaterial.Where(Function(i) i.Seleccion = True).ToList
                    If detalle.IdMaterial = oe.Id Then
                        Throw New Exception("Material: " & oe.Nombre & ". Ya Agregado a la Guia")
                    End If
                Next
            Next
            For Each oe As e_Material In loAlmMaterial.Where(Function(i) i.Seleccion = True).ToList
                oeGuiaRRDetalle = New e_GuiaRemisionRemitente_Detalle
                With oeGuiaRRDetalle
                    .TipoOperacion = "I"
                    .IdEmpresaSis = gs_IdEmpresaSistema
                    .IdSucursal = gs_IdSucursal
                    .PrefijoID = gs_PrefijoIdSucursal
                    .IdMaterial = oe.Id
                    .CodigoMaterial = oe.Codigo
                    .Material = oe.Nombre
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .Cantidad = 1
                    .Peso = oe.Peso
                    .PesoTotal = .Peso
                    .UsuarioCrea = gUsuarioSGI.Id
                End With
                loGuiaRRDetalle.Add(oeGuiaRRDetalle)
            Next
            griDetalleDocumento.DataSource = loGuiaRRDetalle
            griDetalleDocumento.DataBind()
            mt_CombosGrilla()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarMaterial()
        Try
            If griDetalleDocumento.Selected.Rows.Count > 0 Then
                oeGuiaRRDetalle = New e_GuiaRemisionRemitente_Detalle
                oeGuiaRRDetalle = griDetalleDocumento.ActiveRow.ListObject
                If oeGuiaRRDetalle.TipoOperacion = "I" Then
                    loGuiaRRDetalle.Remove(oeGuiaRRDetalle)
                Else
                    oeGuiaRRDetalle.TipoOperacion = "E"
                    griDetalleDocumento.ActiveRow.Hidden = True
                End If
            End If
            griDetalleDocumento.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ImprimirGRR_Venta(Id As String)
        Try
            Dim DT1 As DataTable, DT2 As DataTable
            Dim objXls As Excel.Application
            Dim objWorkbook As Excel.Workbook
            Dim objWorkSheet As Excel.Worksheet
            Dim NroLinea As Integer = 19
            objXls = New Excel.Application
            Dim FileToCopy As String
            Dim PathFilePTRA As String
            Dim Fecha As String
            Dim FechaTraslado As String
            DT1 = olGuiaRR.ListarDT(New e_GRR_Venta With {.TipoOperacion = "PRI", .Id = Id})
            DT2 = olGuiaRRDetalle.ListarDT(New e_GuiaRemisionRemitente_Detalle With {.TipoOperacion = "PRI", .IdGRR_Venta = Id})

            FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\Plantilla_GRR_Venta.xlt"
            PathFilePTRA = Application.StartupPath & "\PLANTILLAS_SGI\Plantilla_GRR_Venta.xls"

            Dim OldCultureInfo As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-PE")
            objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
            objWorkSheet = objXls.Worksheets(1)

            objWorkSheet.Name = "Guia Remision Remitente" ' " & griDocumento.ActiveRow.Cells("Serie").Value & " - " & griDocumento.ActiveRow.Cells("Numero").Value

            For Each datarow As DataRow In DT1.Rows
                Fecha = datarow("FecEmision")
                FechaTraslado = datarow("FecTraslado")
                objWorkSheet.Cells(5, 5) = datarow("Partida").ToString
                objWorkSheet.Cells(6, 5) = datarow("LocPartida").ToString
                objWorkSheet.Cells(8, 5) = datarow("Destinatario").ToString
                objWorkSheet.Cells(9, 5) = datarow("Ruc").ToString
                objWorkSheet.Cells(10, 5) = datarow("Llegada").ToString
                objWorkSheet.Cells(11, 5) = datarow("LocLlegada").ToString
                objWorkSheet.Cells(13, 5) = datarow("Transportista").ToString
                objWorkSheet.Cells(13, 22) = Strings.Left(datarow("FecEmision").ToString, 10)
                objWorkSheet.Cells(15, 5) = datarow("RucTrans").ToString
                objWorkSheet.Cells(15, 9) = datarow("Marca").ToString
                objWorkSheet.Cells(15, 14) = datarow("Placas").ToString
                objWorkSheet.Cells(15, 23) = Strings.Left(datarow("FecTraslado").ToString, 10)
                objWorkSheet.Cells(16, 4) = datarow("Chofer").ToString
                objWorkSheet.Cells(16, 9) = datarow("Brevete").ToString
                objWorkSheet.Cells(16, 14) = datarow("MTC").ToString
                objWorkSheet.Cells(16, 23) = datarow("DocAsoc").ToString
                objWorkSheet.Cells(35, 6) = datarow("Motivo").ToString
                objWorkSheet.Cells(35, 11) = datarow("Peso")
            Next

            For Each datarow As DataRow In DT2.Rows
                objWorkSheet.Cells(NroLinea, 4) = datarow("CodigoMaterial").ToString
                objWorkSheet.Cells(NroLinea, 6) = datarow("Material").ToString
                objWorkSheet.Cells(NroLinea, 12) = datarow("Cantidad")
                objWorkSheet.Cells(NroLinea, 16) = datarow("IdUnidadMedida").ToString
                objWorkSheet.Cells(NroLinea, 18) = datarow("Peso").ToString
                NroLinea += 1
            Next

            objXls.ActiveWindow.Zoom = 100
            objXls.ActiveWindow.DisplayGridlines = False
            objXls.Sheets.Item(1).Select()
            objXls.Visible = True
            If Not (objWorkSheet Is Nothing) Then
                Marshal.ReleaseComObject(objWorkSheet)
            End If
            If Not (objWorkbook Is Nothing) Then
                Marshal.ReleaseComObject(objWorkbook)
            End If
            If Not (objXls Is Nothing) Then
                Marshal.ReleaseComObject(objXls)
            End If
            objWorkSheet = Nothing
            objWorkbook = Nothing
            objXls = Nothing
            System.Threading.Thread.CurrentThread.CurrentCulture = OldCultureInfo
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
                .DisplayLayout.Override.BorderStyleCell = UIElementBorderStyle.Dotted
                .DisplayLayout.Override.BorderStyleRow = UIElementBorderStyle.Dotted

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
                    .Columns("Serie").Width = 60
                    .Columns("Numero").Hidden = False
                    .Columns("Numero").Header.VisiblePosition = 2
                    .Columns("Numero").Width = 100
                    .Columns("FechaTraslado").Hidden = False
                    .Columns("FechaTraslado").Header.VisiblePosition = 3
                    .Columns("FechaTraslado").Width = 100
                    .Columns("Estado").Hidden = False
                    .Columns("Estado").Header.VisiblePosition = 4
                    .Columns("Estado").Width = 100
                    .Columns("Cliente").Hidden = False
                    .Columns("Cliente").Header.VisiblePosition = 5
                    .Columns("Cliente").Width = 300
                    .Columns("Transportista").Hidden = False
                    .Columns("Transportista").Header.VisiblePosition = 6
                    .Columns("Transportista").Width = 300
                    .Columns("Vehiculo").Hidden = False
                    .Columns("Vehiculo").Header.VisiblePosition = 7
                    .Columns("Vehiculo").Width = 100
                    .Columns("Carreta").Hidden = False
                    .Columns("Carreta").Header.VisiblePosition = 8
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
                .DisplayLayout.Override.BorderStyleCell = UIElementBorderStyle.Dotted
                .DisplayLayout.Override.BorderStyleRow = UIElementBorderStyle.Dotted
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
                    .Columns("IdUnidadMedida").Header.Caption = "UMedida"
                    .Columns("Cantidad").Hidden = False
                    .Columns("Cantidad").Width = 130
                    .Columns("Cantidad").Header.VisiblePosition = 3
                    .Columns("Peso").Hidden = False 'IdUnidadMedida
                    .Columns("Peso").Width = 130
                    .Columns("Peso").Header.VisiblePosition = 4
                    .Columns("PesoTotal").Hidden = False 'IdUnidadMedida
                    .Columns("PesoTotal").Width = 130
                    .Columns("PesoTotal").Header.VisiblePosition = 5
                End With
                FormatoColumna(griDetalleDocumento, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Cantidad", "Peso", "PesoTotal")
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("Cantidad").CellActivation = Activation.AllowEdit
                .DisplayLayout.Bands(0).Columns("Cantidad").CellClickAction = CellClickAction.EditAndSelectText
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Inicializar()
        oeGuiaRR = New e_GRR_Venta

        UltraExpandableGroupBox1.Expanded = False

        loAlmMaterial = New List(Of e_Material)
        griAlmacenMaterial.DataSource = loAlmMaterial

        oeGuiaRRDetalle = New e_GuiaRemisionRemitente_Detalle
        loGuiaRRDetalle = New List(Of e_GuiaRemisionRemitente_Detalle)

        oeRefAsoc = New e_ReferenciaAsociada

        griDetalleDocumento.DataSource = loGuiaRRDetalle
        cmb_Cliente.DataSource = Nothing
        cmb_Cliente.Text = String.Empty

        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        cmbMotivoTraslado.SelectedIndex = -1
        dtpFechaDocumento.Value = Date.Now
        dtp_FechaTraslado.Value = Date.Now

        cboTransportista.DataSource = Nothing
        cboTransportista.Text = String.Empty

        gmt_ListarEmpresa("6", cboTransportista, gs_IdClienteProveedorSistema, False)
        cboTransportista.Value = gs_IdClienteProveedorSistema
        cboTransportista.Focus() '@0001
        cboTransportista.Select() '@0001
        cmbVehiculo.SelectedIndex = -1
        cmbVehiculo.Text = String.Empty
        txtMarcaVehiculo.Text = String.Empty
        txtMTC.Text = String.Empty

        cboCarreta.SelectedIndex = -1
        cboCarreta.Text = String.Empty

        cboChofer.DataSource = Nothing
        cboChofer.Text = String.Empty

        txtNroLicencia.Text = String.Empty
        txt_DocAsoc.Text = String.Empty


        une_Peso.Value = 0


        cboPuntoLlegada.SelectedIndex = -1
        txtLlegada.Text = String.Empty
        cboPuntoPartida.SelectedIndex = -1
        txtPartida.Text = String.Empty


        ' griDetalleDocumento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False

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
        olAlmMaterial = New l_MaterialAlmacen
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
            cboTransportista.Focus()
            cboTransportista.Select()
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
            For Each fila As UltraGridRow In griDocumento.Rows
                Select Case fila.Cells("Estado").Value
                    'Case "EVALUADA"
                    '    fila.CellAppearance.BackColor = Me.colorEvaluado.Color
                    'Case "ATENDIDO PARCIALMENTE"
                    '    fila.CellAppearance.BackColor = Me.colorParcial.Color
                    Case "ATENDIDO"
                        fila.CellAppearance.BackColor = Me.ColorAtendido.Color
                    Case "ANULADO"
                        fila.CellAppearance.BackColor = Me.colorAnulado.Color
                        'Case "TERMINADA"
                        '    fila.CellAppearance.BackColor = Me.colorTerminado.Color
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Mostrar()
        Try
            oeGuiaRR = New e_GRR_Venta
            oeGuiaRR.TipoOperacion = ""
            oeGuiaRR.Id = griDocumento.ActiveRow.Cells("Id").Value
            oeGuiaRR = olGuiaRR.Obtener(oeGuiaRR)

            gmt_ListarEmpresa("6", cmb_Cliente, oeGuiaRR.IdCliente, False)
            cmb_Cliente.Value = oeGuiaRR.IdCliente

            txtSerie.Text = oeGuiaRR.Serie
            txtNumero.Text = oeGuiaRR.Numero
            dtpFechaDocumento.Value = oeGuiaRR.Fecha
            dtp_FechaTraslado.Value = oeGuiaRR.FechaTraslado

            gmt_ListarEmpresa("6", cboTransportista, oeGuiaRR.IdTransportista, False)
            cboTransportista.Value = oeGuiaRR.IdTransportista

            cmbMotivoTraslado.Value = oeGuiaRR.IdMotivoTraslado

            txt_DocAsoc.Text = oeGuiaRR.DocAsoc

            If oeGuiaRR.IdTransportista = gs_IdClienteProveedorSistema Then
                cboCarreta.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
                cmbVehiculo.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
                cboChofer.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
                gmt_ComboEspecifico(cmbVehiculo, loVehiculo.Where(Function(i) i.Id <> "" And i.Motriz = 1).OrderBy(Function(y) y.Placa).ToList, -1, "Placa")
                gmt_ComboEspecifico(cboCarreta, loCarreta.Where(Function(i) i.Id <> "" And i.Motriz = 0).OrderBy(Function(y) y.Placa).ToList, -1, "Placa")
                cboChofer.DataSource = PilotoPublic
                cmbVehiculo.Value = oeGuiaRR.IdVehiculo
                cboCarreta.Value = oeGuiaRR.IdCarreta
                cboChofer.Value = oeGuiaRR.IdChofer
            Else
                cmbVehiculo.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
                cboCarreta.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
                cboChofer.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
                cmbVehiculo.Text = oeGuiaRR.Vehiculo
                cboCarreta.Text = oeGuiaRR.Carreta
                cboChofer.Text = oeGuiaRR.Chofer
            End If

            txtMTC.Text = oeGuiaRR.MTCVehiculo
            txtMarcaVehiculo.Text = oeGuiaRR.Marca
            txtNroLicencia.Text = oeGuiaRR.Brevete
            une_Peso.Value = oeGuiaRR.TotalPeso

            cboPuntoPartida.Value = oeGuiaRR.IdPartida
            txtPartida.Text = oeGuiaRR.Partida
            cboPuntoLlegada.Value = oeGuiaRR.IdDestino
            txtLlegada.Text = oeGuiaRR.Destino

            loGuiaRRDetalle = olGuiaRRDetalle.Listar(New e_GuiaRemisionRemitente_Detalle With {.IdGRR_Venta = oeGuiaRR.Id})

            griDetalleDocumento.DataSource = loGuiaRRDetalle

            mt_CombosGrilla()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub mt_CargarOrden_OrdenVenta(OrdenVenta As e_OrdenVenta)
        Try
            'Dim TotalPeso As Double = 0
            olCombo = New l_Combo
            mt_Inicializar()
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
                    .TipoOperacion = "I"
                    .IdEmpresaSis = gs_IdEmpresaSistema
                    .IdSucursal = gs_IdSucursal
                    .PrefijoID = gs_PrefijoIdSucursal
                    .IdMaterial = detalle.IdMaterial
                    .CodigoMaterial = detalle.Codigo
                    .Material = detalle.Material
                    .IdUnidadMedida = detalle.IdUnidadMedida
                    .Cantidad = detalle.Cantidad
                    .Peso = detalle.CantidadReal
                    .PesoTotal = detalle.CostoUnitario
                    .UsuarioCrea = gUsuarioSGI.Id
                End With

                loGuiaRRDetalle.Add(oeGuiaRRDetalle)
            Next

            griDetalleDocumento.DataSource = loGuiaRRDetalle
            griDetalleDocumento.DataBind()

            mt_CalcularTotalPeso()

            mt_CombosGrilla()

            oeRefAsoc = New e_ReferenciaAsociada
            oeRefAsoc.TipoOperacion = "I"
            oeRefAsoc.PrefijoID = gs_PrefijoIdSucursal
            oeRefAsoc.IdTablaPrincipal = OrdenVenta.Id
            oeRefAsoc.TipoRelacion = 1
            oeRefAsoc.Glosa = "ORDENVENTA_GRR"
            oeRefAsoc.UsuarioCreacion = gUsuarioSGI.Id

            Operacion = "Nuevo"
            oeGuiaRR = New e_GRR_Venta
            cboTransportista.Focus() '@0001
            cboTransportista.Select() '@0001
            mt_ControlBotoneria()

            cmb_Cliente.Focus()

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
                    mt_ImprimirGRR_Venta(oeGuiaRR.Id)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

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
                    .IdEstado = "1CH00014"
                    .Serie = FormatoDocumento(txtSerie.Text, 4)
                    .Numero = FormatoDocumento(txtNumero.Text, 8)
                    .IdMotivoTraslado = cmbMotivoTraslado.Value
                    .DocAsoc = txt_DocAsoc.Text
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
                    .Brevete = txtNroLicencia.Text
                    .Marca = txtMarcaVehiculo.Text
                    .TotalPeso = loGuiaRRDetalle.Sum(Function(i) i.Peso)
                    .MTCVehiculo = txtMTC.Text
                    .IdPartida = cboPuntoPartida.Value
                    .Partida = txtPartida.Text
                    .IdDestino = cboPuntoLlegada.Value
                    .Destino = txtLlegada.Text
                    .UsuarioCrea = gUsuarioSGI.Id
                    .lo_GRRVenta_Detalle = New List(Of e_GuiaRemisionRemitente_Detalle)
                    .lo_GRRVenta_Detalle = loGuiaRRDetalle

                    .oeReferenciaAsoc = oeRefAsoc
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
            If txtMarcaVehiculo.Text.Trim = String.Empty Then Throw New Exception("Ingrese Marca del Vehiculo")
            'If txtNroMTCC.Text.Trim = String.Empty Then Throw New Exception("Ingrese MTC de la Carreta")
            If cboPuntoPartida.SelectedIndex = -1 Then Throw New Exception("Seleccione Partida")
            If cboPuntoLlegada.SelectedIndex = -1 Then Throw New Exception("Seleccione Llegada")
            If txtPartida.Text.Trim = String.Empty Then Throw New Exception("Ingrese Partida")
            If txtLlegada.Text.Trim = String.Empty Then Throw New Exception("Ingrese Llegada")
            If txtNroLicencia.Text.Trim = String.Empty Then Throw New Exception("Ingrese Brevete del Conductor")
            If cboTransportista.Value = gs_IdClienteProveedorSistema Then
                If cmbVehiculo.SelectedIndex = -1 Then Throw New Exception("Seleccione Traco")
                'If cboCarreta.SelectedIndex = -1 Then Throw New Exception("Seleccione Carreta")
                If cboChofer.SelectedRow Is Nothing Then Throw New Exception("Seleccione Conductor")
            Else
                If cmbVehiculo.Text.Trim = String.Empty Then Throw New Exception("Ingrese Tracto")
                'If cboCarreta.Text.Trim = String.Empty Then Throw New Exception("Ingrese Carreta")
                If cboChofer.Text.Trim = String.Empty Then Throw New Exception("Ingrese Conductor")
            End If
            If loGuiaRRDetalle.Sum(Function(i) i.Peso) = 0 Then Throw New Exception("El Peso No Puede Ser 0.00")

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

    Private Sub mt_Eliminar(Id As String)
        Try
            oeGuiaRR = New e_GRR_Venta
            oeGuiaRR.TipoOperacion = "E"
            oeGuiaRR.Id = Id
            oeGuiaRR.UsuarioCrea = gUsuarioSGI.Id
            olGuiaRR.Eliminar(oeGuiaRR)
            mt_Listar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Anular(id As String)
        Try
            If MessageBox.Show("Esta seguro de anular el Documento: " & griDocumento.ActiveRow.Cells("Serie").Value.ToString & " - " & griDocumento.ActiveRow.Cells("Numero").Value.ToString & " ?",
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                oeGuiaRR = New e_GRR_Venta
                oeGuiaRR.TipoOperacion = "U"
                oeGuiaRR.Id = id
                oeGuiaRR.UsuarioCrea = gUsuarioSGI.Id
                olGuiaRR.Eliminar(oeGuiaRR)
                mt_Listar()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ListarMateriales()
        Try
            If txt_Material.Text = String.Empty Then Throw New Exception("Escriba Nombre del Material")
            loAlmMaterial = New List(Of e_Material)
            loAlmMaterial = olAlmMaterial.Listar(New e_MaterialAlmacen With {.IdMaterial = txt_Material.Text})
            griAlmacenMaterial.DataSource = loAlmMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


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

#End Region

End Class