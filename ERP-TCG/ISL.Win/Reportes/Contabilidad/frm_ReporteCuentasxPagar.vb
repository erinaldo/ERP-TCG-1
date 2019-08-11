Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ReporteCuentasxPagar
    Inherits frm_MenuPadre

    Private leProveedor As New List(Of e_Proveedor)
    Private Shared instancia As frm_ReporteCuentasxPagar = Nothing
    Private Shared Operacion As String
    Private estado As String = ""
    Private moneda As String = ""
    Private tipo_camb As Double = 0.0
    Private ln_TasaRetencion As Double = 0.0

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_ReporteCuentasxPagar()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_ReporteCuentasxPagar
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_ReporteCuentasxPagar
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Call Me.Guardar_Regsitros()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Exportar_Excel(gridDocumentos)
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar()
        Dim DatatableCtaXpagar As New DataTable
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'Dim moneda As String = ""
            If cbMoneda.Checked = False Then
                moneda = cboMoneda.Value
            End If
            If cboEstado.Value = "1CH00039" Then
                cbMoneda.Checked = False : cboMoneda.Value = IIf(moneda Is String.Empty, "1CH01", moneda) : cbMoneda.Enabled = False
            Else
                cbMoneda.Checked = True : cboMoneda.Value = "" : cbMoneda.Enabled = True
            End If

            
            If tipo_camb <= 0.0 Then decTipoCambio.Focus() : Throw New Exception("Actualice Tipo de Cambio")
            Dim olCtasxPagar As New l_MovimientoDocumento
            DatatableCtaXpagar = olCtasxPagar.ListarCtasXPagar(cboProveedor.Value, cbExcluirBancos.Checked, cboEstado.Value, cbSoloDeudas.Checked, moneda)
            If DatatableCtaXpagar.Rows.Count > 0 Then
                gridDocumentos.DataSource = DatatableCtaXpagar
                gridDocumentos.DisplayLayout.Bands(0).Columns("Seleccion").Header.VisiblePosition = 2
                gridDocumentos.DisplayLayout.Bands(0).Columns("Seleccion").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                gridDocumentos.DisplayLayout.Bands(0).Columns("Afectacion").Header.VisiblePosition = 4
                gridDocumentos.DisplayLayout.Bands(0).Columns("Afectacion").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                gridDocumentos.DataSource = DatatableCtaXpagar
                Dim cliente As String = gridDocumentos.Rows(0).Cells("CtaCte").Value
                'Dim tipo_ord As String = gridDocumentos.Rows(0).Cells("TipoOrden").Value
                Dim cont_mat As Boolean = False
                Dim cont_serv As Boolean = False
                Dim contclie As Integer = 0

                If cboEstado.Value = "" And cboEstado.Value = "" Then
                    gridDocumentos.DisplayLayout.Bands(0).Columns("Seleccion").Hidden = False
                End If
            End If
            If gridDocumentos.Rows.Count = 0 Then mensajeEmergente.Problema("No hay Registros en el Sistema", True)
            'VALIDAR CONTROLES Y CELDAS
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            estado = IIf(cboEstado.Value = String.Empty, "1CH00039", IIf(cboEstado.Value = "1CH00039", "1CH00017", ""))
            moneda = IIf(Not cboMoneda.Value Is String.Empty, cboMoneda.Value, "")
            If gridDocumentos.Rows.Count > 0 Then
                Select Case cboEstado.Value
                    Case String.Empty : Botones_Estado(0) : Mostrar_GrillaCheck(True)
                    Case "1CH00039" : Botones_Estado(1) : Mostrar_GrillaCheck(False)
                    Case Else
                        Botones_Estado() : Mostrar_GrillaCheck(True)
                End Select
            End If
            If estado = "1CH00039" Or estado = "1CH00017" Then
                ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False

        End Try
    End Sub



    Private Sub LlenaProveedor()
        Try
            Dim oeProveedor As New e_Proveedor
            Dim olProveedor As New l_Proveedor
            oeProveedor.Activo = True
            leProveedor.AddRange(olProveedor.Listar(oeProveedor))
            With cboProveedor
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leProveedor
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarEstado()
        Try
            Dim oeEstado As New e_Estado
            Dim olEstado As New l_Estado
            Dim operacion As String = ""
            Dim oeTrabajadorSeguridad As New e_TrabajadorSeguridad
            Dim loTrabajadorSeguridad As New l_TrabajadorSeguridad
            Dim lst_TrabjadorSeguridad As New List(Of e_TrabajadorSeguridad)
            Dim usuario As String = ""
            oeTrabajadorSeguridad.IdProcesoNegocio = "1CH000000076"
            lst_TrabjadorSeguridad.AddRange(loTrabajadorSeguridad.Listar(oeTrabajadorSeguridad))
            oeTrabajadorSeguridad = New e_TrabajadorSeguridad
            oeTrabajadorSeguridad.IdProcesoNegocio = "1SI000000004"
            lst_TrabjadorSeguridad.AddRange(loTrabajadorSeguridad.Listar(oeTrabajadorSeguridad))
            usuario = gUsuarioSGI.IdTrabajador
            If lst_TrabjadorSeguridad.Where(Function(g) g.IdTrabajador = usuario And g.IdProcesoNegocio = "1CH000000076").Count > 0 Then
                operacion = "R"
            elseIf lst_TrabjadorSeguridad.Where(Function(g) g.IdTrabajador = usuario And g.IdProcesoNegocio = "1SI000000004").Count > 0 Then
                operacion = "P"
            Else
                operacion = "T"
            End If
            oeEstado.Nombre = operacion
            cboEstado.ValueMember = "Id"
            cboEstado.DisplayMember = "Nombre"
            cboEstado.DataSource = olEstado.Listar(oeEstado)
            cboEstado.Value = "TODOS"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Botones_Estado(Optional programar As Boolean = False)
        gbMonto.Visible = programar
        If programar = True Then
            decMontoOriginal.Text = "0.00"
            decRetencion.Text = "0.00"
            decDetracción.Text = "0.00"
            decMontoPago.Text = "0.00"
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteCuentasxPagar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        If cboEstado.Value = "1CH00039" Then
            If gridDocumentos.Rows.Where(Function(g) g.Cells("EstadoPago").Value = "SIN REVISIÓN" Or g.Cells("EstadoPago").Value = "PROGRAMADO").Count = 0 Then
                ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
            End If
        ElseIf cboEstado.Value = "" Then
            If gridDocumentos.Rows.Where(Function(g) g.Cells("EstadoPago").Value = "PAGADO" Or g.Cells("EstadoPago").Value = "PROGRAMADO").Count = 0 Then
                ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
            End If
        End If
    End Sub

    Private Sub frm_ReporteCuentasxPagar_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub txtRuc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuc.ValueChanged
        If Not txtRuc.Value Is Nothing Then
            If txtRuc.Value.ToString.Trim.Length > 7 Then
                Dim leProveedorList As New List(Of e_Proveedor)
                leProveedorList = leProveedor.ToList
                leProveedorList = leProveedorList.Where(Function(item) item.NroDocumento.Contains(txtRuc.Value)).ToList
                cboProveedor.DataSource = leProveedorList
                If leProveedorList.Count > 0 Then
                    cboProveedor.Value = leProveedorList(0).Id
                End If
            End If
        End If
    End Sub

    Private Sub cboProveedor_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) _
    Handles cboProveedor.InitializeLayout
        Me.cboProveedor.ValueMember = "Id"
        Me.cboProveedor.DisplayMember = "Nombre"
        With cboProveedor.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("TipoPersonaEmpresa").Hidden = True
            .Columns("IdPersona").Hidden = True
            .Columns("IdEmpresa").Hidden = True
            .Columns("Email").Hidden = True
            .Columns("FechaActividad").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("Contacto").Hidden = True
            .Columns("Seleccion").Hidden = True
            .Columns("Nombre").Width = 300
            .Columns("NroDocumento").Width = 100
            .Columns("NroDocumento").Header.Caption = "RUC/DNI"
        End With
    End Sub

    Private Sub cboProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cboProveedor.Text.Trim = "" Then
                cboProveedor.DataSource = Nothing
                cboProveedor.DataSource = leProveedor
            Else
                cboProveedor.DataSource = Nothing
                Dim leProveedorList2 As New List(Of e_Proveedor)
                leProveedorList2 = leProveedor.ToList
                cboProveedor.DataSource = leProveedorList2.Where(Function(Item) Item.Nombre.Contains(cboProveedor.Text.Trim)).ToList
            End If
        End If
    End Sub

    Private Sub cboProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProveedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboProveedor.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub frm_ReporteCuentasxCobrar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Colores1.Color = Color.SkyBlue
            LlenaProveedor()
            Botones_Estado()
            LlenarEstado()
            tipo_camb = TipoCambio(Date.Now.Date, True)(0)
            If tipo_camb > 0.0 Then decTipoCambio.Value = tipo_camb Else decTipoCambio.Focus() : Throw New Exception("Actualice Tipo de Cambio")
            'Cargar Moneda
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            LlenarCombo(cboMoneda, "Nombre", olMoneda.Listar(oeMoneda), -1)
            cboMoneda.Value = ""
            ln_TasaRetencion = ObtenerRetencion()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub gridDocumentos_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles gridDocumentos.AfterRowUpdate
        Try
            Dim obj As DataRowView
            obj = gridDocumentos.ActiveRow.ListObject
            If obj("Id") <> "" Then
                If obj("Indicador") = 0 Then
                    Dim oeDocumento As New e_MovimientoDocumento
                    Dim olMovDoc As New l_MovimientoDocumento
                    oeDocumento.Glosa = obj("GlosaCtaxCyP").ToString
                    oeDocumento.Id = obj("Id")
                    olMovDoc.CambiarGlosa(oeDocumento)
                ElseIf obj("Indicador") = 1 Then
                    Dim oeObligacion As New e_ObligacionFinanciera
                    Dim olObligacion As New l_ObligacionFinanciera
                    oeObligacion.Glosa = obj("GlosaCtaxCyP").ToString
                    oeObligacion.Id = obj("Id").ToString
                    olObligacion.CambiarGlosa(oeObligacion)
                End If
            Else
                Throw New Exception("Solo se actualizarán líneas de documentos válidos")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_ReporteCuentasxPagar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

    Private Sub gridDocumentos_CellChange(sender As Object, e As CellEventArgs) Handles gridDocumentos.CellChange
        Try
            Dim oeEmpresa As e_Empresa
            Dim olEmpresa As l_Empresa
            If estado = "1CH00017" Then
                Dim afectado As Double = 0.0
                Dim cont As Integer = 0
                gridDocumentos.UpdateData()
                If e.Cell.Row.Index > -1 Then
                    With CType(sender, UltraGrid).Rows((e.Cell.Row.Index))
                        If e.Cell.Column.Key = "Afectacion" Then
                            If .Cells("TipoOrden").Value = "MATERIAL" Then
                                If e.Cell.Value = False Then
                                    For Each fila In gridDocumentos.Rows.Where(Function(g) g.Cells("Seleccion").Value = True And g.Cells("CtaCte").Value = .Cells("CtaCte").Value And g.Cells("TipoOrden").Value = "MATERIAL").ToList
                                        fila.Cells("Afectacion").Value = False
                                        fila.Cells("PorcAfect").Value = "0.0000"
                                        'fila.Cells("MontoPago").Value = (CDbl(fila.Cells("MontoPago").Value) + CDbl(fila.Cells("MontoAfectado").Value))
                                        fila.Cells("MontoAfectado").Value = "0.0000"
                                    Next
                                Else
                                    .Cells("Seleccion").Value = True
                                    Recorrer_Seleccionados(.Cells("CtaCte").Value)
                                End If
                            ElseIf .Cells("TipoOrden").Value = "SERVICIO" Then
                                Afectacion_Servicios(e.Cell.Row.Index)
                                .Cells("Seleccion").Value = True
                            End If
                        End If
                        If e.Cell.Column.Key = "Seleccion" Then
                            .Cells("Afectacion").Value = False
                            .Cells("PorcAfect").Value = "0.0000"
                            .Cells("MontoAfectado").Value = "0.0000"

                            If e.Cell.Value = True Then
                                .Cells("MontoPago").Value = IIf(moneda = "1CH02", .Cells("SALDO_D").Value, .Cells("SALDO_S").Value)
                                .Cells("MontoPago").Activation = Activation.AllowEdit
                            Else
                                .Cells("MontoPago").Value = "0.0000"
                                .Cells("MontoPago").Activation = Activation.NoEdit
                            End If
                            If .Cells("TipoOrden").Value = "MATERIAL" Then
                                oeEmpresa = New e_Empresa
                                olEmpresa = New l_Empresa
                                oeEmpresa.Nombre = .Cells("CtaCte").Value
                                oeEmpresa.Ruc = .Cells("Dni").Value
                                Dim olRetencion As New l_DocumentoRetencion
                                If olRetencion.Obtener(New e_DocumentoRetencion With {.TipoOperacion = "R", .IdAsientoMovimiento = cboProveedor.Value}).ImporteRetencion > 0 Then
                                    .Cells("Afectacion").Value = True
                                Else
                                    .Cells("Afectacion").Value = False
                                End If
                                cont = gridDocumentos.Rows.Where(Function(g) g.Cells("Afectacion").Value = True And g.Cells("Seleccion").Value = True And g.Cells("CtaCte").Value = .Cells("CtaCte").Value And IIf(IsDBNull(g.Cells("TipoOrden").Value), "", g.Cells("TipoOrden").Value) = "MATERIAL").Count
                                If cont > 0 Then
                                    Recorrer_Seleccionados(.Cells("CtaCte").Value)
                                End If
                            ElseIf .Cells("TipoOrden").Value = "SERVICIO" Then
                                .Cells("PorcAfect").Activation = Activation.NoEdit
                            End If

                        End If
                If e.Cell.Column.Key = "MontoPago" Or e.Cell.Column.Key = "PorcAfect" Then
                    If .Cells("TipoOrden").Value = "MATERIAL" Then
                        cont = gridDocumentos.Rows.Where(Function(g) g.Cells("Afectacion").Value = True And g.Cells("Seleccion").Value = True And g.Cells("CtaCte").Value = CType(sender, UltraGrid).Rows((e.Cell.Row.Index)).Cells("CtaCte").Value And g.Cells("TipoOrden").Value = "MATERIAL").Count
                        If cont > 0 Then
                            Recorrer_Seleccionados(.Cells("CtaCte").Value)
                        End If
                    ElseIf .Cells("TipoOrden").Value = "SERVICIO" Then
                        Afectacion_Servicios(e.Cell.Row.Index)
                    End If
                End If
                    End With
                End If
            End If
            gridDocumentos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Afectacion_Servicios(index As Integer)
        Dim afectado As Double = 0.0
        With gridDocumentos.Rows(index)
            If .Cells("Afectacion").Value = False Then
                .Cells("PorcAfect").Activation = Activation.NoEdit
                '.Cells("MontoPago").Value = (CDbl(.Cells("MontoPago").Value) + CDbl(.Cells("MontoAfectado").Value))
                .Cells("PorcAfect").Value = "0.0000"
                .Cells("MontoAfectado").Value = "0.0000"
            Else
                If .Cells("Seleccion").Value = True Then
                    If CDbl((.Cells("PorcAfect").Value)) > 0.0 Then
                        afectado = Math.Round((.Cells("MontoPago").Value * (.Cells("PorcAfect").Value) / 100.0), 0)
                        .Cells("MontoAfectado").Value = FormatNumber(afectado, 4)
                        '(CDbl(.Cells("MontoPago").Value) - afectado)
                    Else
                        '.Cells("MontoPago").Value =  (CDbl(.Cells("MontoPago").Value) + CDbl(.Cells("MontoAfectado").Value))
                        .Cells("PorcAfect").Value = "0.0000"
                        .Cells("MontoAfectado").Value = "0.0000"
                    End If
                End If
            End If
        End With
    End Sub
    Private Sub Recorrer_Seleccionados(cliente As String)
        Dim sum_monto As Double = 0.0
        Dim afectado As Double = 0.0
        sum_monto = gridDocumentos.Rows.Where(Function(g) g.Cells("CtaCte").Value = cliente And g.Cells("Seleccion").Value = True And g.Cells("TipoOrden").Value = "MATERIAL").Sum(Function(g) g.Cells("MontoPago").Value)
        If moneda = "1CH02" Then sum_monto = sum_monto * CDbl(tipo_camb)
        For Each fila In gridDocumentos.Rows.Where(Function(g) g.Cells("Seleccion").Value = True And g.Cells("CtaCte").Value = cliente And g.Cells("TipoOrden").Value = "MATERIAL").ToList
            fila.Cells("Afectacion").Value = True
            fila.Cells("PorcAfect").Value = FormatNumber(ln_TasaRetencion * 100.0, 4)
            If sum_monto > 700.0 Then
                fila.Cells("MontoAfectado").Value = FormatNumber((fila.Cells("MontoPago").Value * (fila.Cells("PorcAfect").Value) / 100.0), 4)
                'fila.Cells("MontoPago").Value = (CDbl(fila.Cells("MontoPago").Value) - fila.Cells("MontoAfectado").Value)
            Else
                fila.Cells("MontoAfectado").Value = "0.0000"
            End If
        Next
    End Sub
    Private Sub gridDocumentos_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles gridDocumentos.InitializeLayout
        Try
            If {"gridDocumentos"}.Contains(e.Layout.Grid.Name) Then
                e.Layout.Override.CellClickAction = CellClickAction.RowSelect
                For Each r In e.Layout.Bands(0).Columns
                    If r.Key = "Seleccion" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                    If r.Key = "MontoPago" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                    If r.Key = "Afectacion" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                    If r.Key = "PorDetrac" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mostrar_GrillaCheck(_ban As Boolean)
       
        With gridDocumentos.DisplayLayout.Bands(0)
            .Columns("Seleccion").Hidden = _ban
            .Columns("Afectacion").Hidden = _ban
            .Columns("PorcAfect").Hidden = _ban
            .Columns("MontoAfectado").Hidden = _ban
            .Columns("MontoPago").Hidden = _ban
            If estado = "1CH00039" Or estado = "1CH00017" Then
                .Columns("Seleccion").Hidden = False
            Else
                .Columns("Seleccion").Hidden = True
            End If
        End With
        For Each fila As UltraGridRow In gridDocumentos.Rows
            Select Case fila.Cells("Numero").Value
                Case "SubTotal", "TOTALES"
                    fila.Cells("Seleccion").Hidden = True
                    fila.Cells("Afectacion").Hidden = True
                    fila.Activation = Activation.NoEdit
                    'fila.Cells("PorcAfect").Activation = Activation.NoEdit
                    'fila.Cells("MontoPago").Activation = Activation.NoEdit
                    fila.CellAppearance.BackColor = Me.Colores1.Color
                    fila.CellAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                Case Else
                    fila.Cells("MontoPago").Value = "0.0000"
                    fila.Cells("PorcAfect").Value = "0.0000"
                    fila.Cells("MontoAfectado").Value = "0.0000"
            End Select

        Next

    End Sub

    Private Sub Guardar_Regsitros()
        Dim c As Integer = gridDocumentos.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Seleccion").Value).Count
        If c = 0 Then
            mensajeEmergente.Problema("Para Guardar estos Registros deberá seleccionar mínimo 1 fila.", True)
        Else
            ActualizarEstadoPago()
        End If
    End Sub


    Private Sub ActualizarEstadoPago()
        Dim oeMovDoc As e_MovimientoDocumento
        Dim olMovDoc As l_MovimientoDocumento
        Dim lstMovDoc As New List(Of e_MovimientoDocumento)
        Dim lstDetProgPago As New List(Of e_DetalleProgramacionPago)
        Try
            If (moneda = "1CH01" And cboMoneda.Value = "1CH01") Or (moneda = "1CH02" And cboMoneda.Value = "1CH02") Or (moneda = "" And cboMoneda.Value = "") Then
                If estado <> "" Then
                    If estado = "1CH00017" And cboEstado.Value = "1CH00039" Then
                        If MessageBox.Show("¿Está conforme de Generar la Programación de Pagos para los Documentos Seleccionados?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            Dim monto As Decimal = 0.0
                            Dim montoorig_t As Decimal = 0.0
                            Dim retencion_t As Decimal = 0.0
                            Dim montopag_t As Decimal = 0.0
                            Dim oeProgramacionPago As New e_ProgramacionPago
                            Dim oeDetProgPago As e_DetalleProgramacionPago
                            Dim olProgramacionPago As New I_ProgramacionPago
                            Dim oeprogpago As New e_ProgramacionPago
                            Dim nro_aux As String = ""
                            '-----------GENERARO EL NÚMERO DE LOTE Y CARGO LA CABECERA DE PROG. PAGO-------
                            oeProgramacionPago.TipoOperacion = "NUM"
                            oeprogpago = olProgramacionPago.ObtenerLote(oeProgramacionPago)
                            nro_aux = oeprogpago.NroLote
                            With oeprogpago
                                .IdUsuario = gUsuarioSGI.IdTrabajador
                                .NroLote = nro_aux
                                .IdEstado = "1CH00014"
                                .TipoOperacion = "I"
                                .Observaciones = ""
                                .Moneda = cboMoneda.Value
                                .MontoOriginal = CDbl(decMontoOriginal.Value)
                                .MontoPago = CDbl(decMontoPago.Value)
                                .Retencion = CDbl(decRetencion.Value)
                                .Detraccion = CDbl(decDetracción.Value)

                                For Each drFila In gridDocumentos.Rows.Where(Function(g) g.Cells("Seleccion").Value = True).ToList
                                    '-----------CARGA LOS DETALLES DE PROG. PAGO Y MOV. DOC.---------
                                    oeMovDoc = New e_MovimientoDocumento
                                    oeDetProgPago = New e_DetalleProgramacionPago
                                    oeMovDoc.IdUsuarioCrea = gUsuarioSGI.IdTrabajador
                                    oeMovDoc.TipoOperacion = "P"
                                    oeMovDoc.Id = drFila.Cells("Id").Value
                                    oeMovDoc.IdEstadoDocumento = estado
                                    lstMovDoc.Add(oeMovDoc)
                                    With oeDetProgPago
                                        .Id = ""
                                        .IdEstado = estado
                                        .IdUsuario = gUsuarioSGI.IdTrabajador
                                        .TipoOperacion = "I"
                                        .IdMovimientoDocumento = drFila.Cells("Id").Value
                                        .MontoOriginal = drFila.Cells("MontoPago").Value
                                        .MontoPago = (drFila.Cells("MontoPago").Value - drFila.Cells("MontoAfectado").Value)
                                        .Afectacion = drFila.Cells("MontoAfectado").Value
                                        .TipoOrden = drFila.Cells("TipoOrden").Value
                                        If drFila.Cells("Afectacion").Value Then
                                            .TipoAfect = IIf(drFila.Cells("TipoOrden").Value = "MATERIAL", "RETENCIÓN", "DETRACCIÓN")
                                        End If
                                        .PorcAfect = drFila.Cells("PorcAfect").Value
                                    End With
                                    lstDetProgPago.Add(oeDetProgPago)
                                Next
                                .lst_MovimientoDocumento = lstMovDoc
                                .lst_DetalleProgPago = lstDetProgPago
                            End With
                            If olProgramacionPago.Guardar(oeprogpago) Then mensajeEmergente.Confirmacion("Se ha Generado una Programación. Nro: " & nro_aux, True)
                            Listar()
                            Botones_Estado(1)
                        End If
                    ElseIf estado = "1CH00039" And cboEstado.Value Is String.Empty Then
                        If MessageBox.Show("¿Está seguro de que la revisión de los Documentos es Correcta?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            For Each drFila In gridDocumentos.Rows.Where(Function(g) g.Cells("Seleccion").Value = True).ToList
                                '-----------CARGa LOS DETALLES DE PROG. PAGO Y MOV. DOC.---------
                                oeMovDoc = New e_MovimientoDocumento
                                oeMovDoc.IdUsuarioCrea = gUsuarioSGI.Id
                                oeMovDoc.Id = drFila.Cells("Id").Value
                                oeMovDoc.IdEstadoDocumento = estado
                                lstMovDoc.Add(oeMovDoc)
                                oeMovDoc.IdEstadoDocumento = estado
                                oeMovDoc.IdUsuarioCrea = gUsuarioSGI.Id
                                oeMovDoc.TipoOperacion = "P"
                                olMovDoc = New l_MovimientoDocumento
                                olMovDoc.ActualizarEstadoPago(oeMovDoc)
                            Next
                            mensajeEmergente.Confirmacion("Se ha Registrado la Revisión de Documentos", True)
                            Listar()
                            Botones_Estado(0)
                        End If
                    Else
                        mensajeEmergente.Problema("La selección de Estados no coincide con el Tipo de Operación", True)
                        If estado = "1CH00039" Then cboEstado.Value = String.Empty
                        If estado = "1CH00017" Then cboEstado.Value = "1CH00039"
                    End If
                End If
            Else
                mensajeEmergente.Problema("La selección de Moneda no coincide la Selección de Documentos", True)
                If moneda <> "" Then
                    cboMoneda.Value = moneda : cbMoneda.Checked = False : cboMoneda.Enabled = True
                Else
                    cbMoneda.Checked = True : cboMoneda.Enabled = False : cboMoneda.Value = ""
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub gridDocumentos_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles gridDocumentos.AfterCellUpdate
        Try
            Dim saldo As Decimal = 0.0
            Dim monto As Decimal = 0.0
            If gbMonto.Visible Then
                If estado = "1CH00017" Then
                    If e.Cell.Row.Index > -1 Then
                        With gridDocumentos.Rows(e.Cell.Row.Index)
                            If .Cells("Seleccion").Value = True Then
                                Dim cont As Integer = gridDocumentos.Rows.Where(Function(g) g.Cells("Seleccion").Value = True And g.Cells("CtaCte").Value = .Cells("CtaCte").Value And g.Cells("Afectacion").Value = True).Count
                                For Each fila In gridDocumentos.Rows.Where(Function(g) g.Cells("CtaCte").Value = .Cells("CtaCte").Value And g.Cells("TipoOrden").Value = "SERVICIO").ToList
                                    fila.Cells("PorcAfect").Activation = Activation.NoEdit
                                Next
                                If cont > 0 Then
                                    For Each fila In gridDocumentos.Rows.Where(Function(g) g.Cells("Seleccion").Value = True And g.Cells("CtaCte").Value = .Cells("CtaCte").Value And g.Cells("TipoOrden").Value = "SERVICIO").ToList
                                        fila.Cells("PorcAfect").Activation = Activation.AllowEdit
                                    Next
                                End If
                                .Cells("MontoPago").Activation = Activation.AllowEdit
                                monto = IIf(moneda = "1CH02", .Cells("SALDO_D").Value, .Cells("SALDO_S").Value)
                                If CStr(.Cells("MontoPago").Value) = "0.0000" Or CStr(.Cells("MontoPago").Value) = "" Then
                                    saldo = monto
                                    .Cells("MontoPago").Value = FormatNumber(saldo, 4)
                                    Calcular_Montos()
                                    Exit Sub
                                End If
                                If .Cells("MontoPago").Value < 0.0 Then
                                    MsgBox("Ingrese Monto a Pagar .", MsgBoxStyle.Information)
                                    Calcular_Montos()
                                    Exit Sub
                                End If
                                If .Cells("MontoPago").Value > monto Then
                                    MsgBox("El monto a Pagar es Mayor al Saldo de " & CStr(monto), MsgBoxStyle.Information)
                                    Calcular_Montos()
                                End If
                                If CStr(.Cells("PorcAfect").Value) = String.Empty Then
                                    If CStr(.Cells("PorcAfect").Value) = String.Empty Then .Cells("PorcAfect").Value = FormatNumber(0, 4)
                                    If IsNumeric(.Cells("PorcAfect").Value) Then
                                        Calcular_Montos()
                                    End If
                                    Exit Sub
                                End If
                                If CDbl(.Cells("PorcAfect").Value) < 0 Then
                                    MsgBox("Ingrese % de Detracción .", MsgBoxStyle.Information)
                                    Calcular_Montos()
                                    Exit Sub
                                End If

                            Else
                                .Cells("PorcAfect").Activation = Activation.NoEdit
                                .Cells("MontoPago").Activation = Activation.NoEdit
                                .Cells("MontoPago").Value = "0.0000"
                                .Cells("PorcAfect").Value = "0.0000"
                                Calcular_Montos()
                                Exit Sub
                            End If
                            Calcular_Montos()
                        End With

                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function gmt_AgenteRetencion(aux As String)
        Dim _ban As Boolean = 0
        Dim oe_Empresa As New e_Empresa
        oe_Empresa.TipoOperacion = ""
        oe_Empresa.Ruc = aux
        Dim ol_Empresa As New l_Empresa
        Dim lst_Empresa As New List(Of e_Empresa)
        lst_Empresa = ol_Empresa.Listar(oe_Empresa)
        _ban = lst_Empresa.Item(0).IndAgenteRetencion
        Return _ban
    End Function

    Private Sub Calcular_Montos()
        Dim monto As Decimal = 0.0
        Dim montoorig_t As Decimal = 0.0
        Dim retencion_t As Decimal = 0.0
        Dim detraccion_t As Decimal = 0.0
        Dim sum_monto As Double = 0.0
        For Each drFila In gridDocumentos.Rows.Where(Function(g) g.Cells("Seleccion").Value = True).ToList
            sum_monto = gridDocumentos.Rows.Where(Function(g) g.Cells("CtaCte").Value = drFila.Cells("CtaCte").Value).Sum(Function(g) g.Cells("MontoPago").Value)
            monto = drFila.Cells("MontoPago").Value
            montoorig_t += monto
            If drFila.Cells("Afectacion").Value = True Then
                If drFila.Cells("TipoOrden").Value = "MATERIAL" Then
                    If moneda = "1CH02" Then sum_monto = sum_monto * CDbl(tipo_camb)
                    If sum_monto > 700.0 Then
                        retencion_t += (drFila.Cells("MontoPago").Value * (drFila.Cells("PorcAfect").Value) / 100)
                    End If
                Else
                    detraccion_t += Math.Round((drFila.Cells("MontoPago").Value * (drFila.Cells("PorcAfect").Value) / 100), 0)
                End If
            End If
        Next
        decMontoOriginal.Value = montoorig_t
        decRetencion.Value = retencion_t
        decDetracción.Value = detraccion_t
        decMontoPago.Value = (montoorig_t - (retencion_t + detraccion_t))
    End Sub

    Private Sub cbMoneda_CheckedChanged(sender As Object, e As EventArgs) Handles cbMoneda.CheckedChanged
        If cbMoneda.Checked Then
            cboMoneda.Enabled = False
            cboMoneda.Value = ""
        Else
            cboMoneda.Enabled = True
        End If
    End Sub

    Private Sub cboEstado_ValueChanged(sender As Object, e As EventArgs) Handles cboEstado.ValueChanged
        If cboEstado.Value = "1CH00039" Then
            cbMoneda.Enabled = False
            cbMoneda.Checked = False
            cboMoneda.Enabled = True
            cboMoneda.Value = "1CH01"
        Else
            cbMoneda.Checked = True
            cbMoneda.Enabled = True
            cboMoneda.Value = ""
            cboMoneda.Enabled = False
        End If
    End Sub
End Class