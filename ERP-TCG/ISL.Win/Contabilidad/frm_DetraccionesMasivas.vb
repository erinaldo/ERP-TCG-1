'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_DetraccionesMasivas
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_DetraccionesMasivas = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_DetraccionesMasivas()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Variables"

    Private oeDetraccion As e_Detraccion
    Private olDetraccion As l_Detraccion
    Private loDetraccion As List(Of e_Detraccion)

    Private oeDetDetalle As e_DetraccionDetalle
    Private olDetDetalle As l_DetraccionDetalle
    Private loDetDetAdqu As List(Of e_DetraccionDetalle)
    Private loDetDetProo As List(Of e_DetraccionDetalle)

    Private oePeriodo As e_Periodo
    Private olPeriodo As l_Periodo

    Private oeTipoBien As e_TipoBien
    Private olTipoBien As l_TipoBien
    Private loTipobien As List(Of e_TipoBien)

    Private oeTipoOpe As e_TipoOpeCon
    Private olTipoOpe As l_TipoOpeCon
    Private loTipoOpe As List(Of e_TipoOpeCon)

    Private oeCtaCte As e_CtaCte_ProAdq
    Private olCtaCte As l_CtaCte_ProAdq

    Private oeTipoDoc As e_TipoDocumento
    Private olTipoDoc As l_TipoDocumento
    Private loTipoDoc As List(Of e_TipoDocumento)

    Private oeCtaBanco As e_CuentaBancaria
    Private olCtaBanco As l_CuentaBancaria
    Private loCtaBanco As List(Of e_CuentaBancaria)

    Private olCombo As l_Combo

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar()
            Tiempo1.Enabled = True
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griDetraccion.Selected.Rows.Count > 0 Then
                Operacion = "Editar"
                Inicializar()
                Mostrar()
                If oeDetraccion.Tipo = 1 Then
                    SeleccionTabs(1, ficDetraccion)
                Else
                    SeleccionTabs(2, ficDetraccion)
                End If
                ControlBotones()
                BotonesFichas(0, Operacion)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarDetraccion() Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                SeleccionTabs(0, ficDetraccion)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            SeleccionTabs(0, ficDetraccion)
            Consultar()
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficDetraccion.Tabs(0).Selected AndAlso griDetraccion.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griDetraccion)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Detraccion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ControlBotones()
    End Sub

    Private Sub frm_Detraccion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_Detraccion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_Detraccion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ListaCtaCte()
            InicializarLogicas()
            CargarListas()
            ComboGrids()
            txtRucAdq.Text = ISL_RUC : txtRucPro.Text = ISL_RUC
            txtRazonSocialAdq.Text = ISL_Nombre : txtRazonSocialPro.Text = ISL_Nombre
            UltraColorPicker1.Color = Color.White
            UltraColorPicker2.Color = Color.LightSteelBlue
            UltraColorPicker3.Color = Color.LightGreen
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            ConsultarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAdquiriente_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griAdquiriente.AfterCellUpdate
        Try
            Dim Importe As Double = 0
            If griAdquiriente.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "IdTipoBien"
                        With griAdquiriente.Rows(e.Cell.Row.Index)
                            oeTipoBien = New e_TipoBien
                            oeTipoBien.Id = .Cells("IdTipoBien").Value
                            oeTipoBien = olTipoBien.Obtener(oeTipoBien)
                            Importe = .Cells("TotalDocumento").Value * oeTipoBien.Porcentaje / 100
                            If .Cells("IdMoneda").Value = "1CH02" Then
                                .Cells("Importe").Value = Math.Round(Importe * numTCAdq.Value, 2, MidpointRounding.AwayFromZero)
                            Else
                                .Cells("Importe").Value = CInt(Importe)
                            End If
                        End With
                End Select
            End If
            CalcularTotales(griAdquiriente, "Importe")
            CalcularTotalDetraccion()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAdquiriente_BeforeCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griAdquiriente.BeforeCellUpdate
        Try
            With griAdquiriente
                Select Case e.Cell.Column.Key
                    Case "IdTipoBien"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAdquiriente_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griAdquiriente.CellChange
        griAdquiriente.UpdateData()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Try
            With ContextMenuStrip1
                .Items("ToolStripMenuItem1").Visible = True
                .Items("ToolStripMenuItem2").Visible = True
                .Items("ToolStripMenuItem3").Visible = False
                .Items("ToolStripMenuItem4").Visible = False
            End With
            With griDetraccion
                If .Selected.Rows.Count > 0 Then
                    If .ActiveRow.Cells("IdEstado").Value = "1CH00016" Then
                        ContextMenuStrip1.Items("ToolStripMenuItem3").Visible = True
                    End If
                    If .ActiveRow.Cells("IdEstado").Value = "1CH00014" Then
                        If .ActiveRow.Cells("Tipo").Value = 1 Then
                            ContextMenuStrip1.Items("ToolStripMenuItem4").Visible = True
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            Editar()
            Operacion = "Archivo"
            Select Case oeDetraccion.Tipo
                Case 1
                    btnConsultar.Enabled = False
                    btnGenArchivo.Enabled = True
                    btnGuardar.Enabled = True
                    griAdquiriente.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
                    BotonesFichas(0, Operacion)
                    SeleccionTabs(1, ficDetraccion)
                Case 2
                    btnConsultarPro.Enabled = False
                    btnGenArchPro.Enabled = True
                    btnGuardarPro.Enabled = True
                    'griProveedor.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
                    BotonesFichas(1, Operacion)
                    SeleccionTabs(2, ficDetraccion)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGenArchivo_Click(sender As Object, e As EventArgs) Handles btnGenArchivo.Click
        Try
            GenerarArchivo(1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            NuevoAdquiriente()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            NuevoProveedor()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            GuardarArchivo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAdquiriente_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griAdquiriente.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griPago_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griPagoAdq.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griPago_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griPagoAdq.CellChange
        griPagoAdq.UpdateData()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Try
            Editar()
            Operacion = "Asiento"
            btnConsultar.Enabled = False
            btnGenArchivo.Enabled = False
            btnGuardar.Enabled = False
            btnAsiento.Enabled = True
            griPagoAdq.DataSource = loDetDetAdqu
            griPagoAdq.DataBind()
            CrearComboGrid("IdCtaCte_ProAdq", "Cuenta", griPagoAdq, olCtaCte.ComboGrilla(loCtaCteEmpresa), False)
            fecPeriodoAdq.Value = Date.Now
            BotonesFichas(0, Operacion)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAsiento_Click(sender As Object, e As EventArgs) Handles btnAsiento.Click
        Try
            Dim oeMovDoc As e_MovimientoDocumento
            oeDetraccion.loDetraccionDet = New List(Of e_DetraccionDetalle)
            oeDetraccion.TipoOperacion = "S"
            If cboCtaBancariaSolesAdq.SelectedIndex = -1 Then Throw New Exception("Error En Cta Soles")
            oePeriodo = New e_Periodo
            oePeriodo.Ejercicio = fecPeriodoAdq.DateTime.Year
            oePeriodo.Mes = fecPeriodoAdq.DateTime.Month
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            Dim FechaActual As Date = ObtenerFechaServidor()
            oeDetraccion.loDocumento = New List(Of e_MovimientoDocumento)
            oeDetraccion.loDetraccionDet = New List(Of e_DetraccionDetalle)
            oeDetraccion.loDetraccionDet.AddRange(loDetDetAdqu)
            For Each oe As e_DetraccionDetalle In oeDetraccion.loDetraccionDet
                oe.Voucher = FormatoDocumento(oe.Voucher, 10)
            Next
            If loDetDetAdqu.Where(Function(i) i.IdTipoGasto = "").Count > 0 Then
                Throw New Exception("Los Documentos deben Tener Tipo de Gasto")
            End If
            If loDetDetAdqu.Where(Function(i) i.Voucher = "").Count > 0 Then
                Throw New Exception("Los Documentos deben Tener Voucher")
            End If
            For Each oe As e_DetraccionDetalle In loDetDetAdqu
                oe.UsuarioCreacion = gUsuarioSGI.Id
                oe.FechaCreacion = FechaActual
                oeMovDoc = New e_MovimientoDocumento
                oeMovDoc.TipoOperacion = "CAM"
                oeMovDoc.Id = oe.IdMovimientoDocumento
                oeMovDoc.Total = IIf(oe.IdMoneda = "1CH01", oe.Importe, Math.Round(oe.Importe / numTCAdq.Value, 2))
                oeMovDoc.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeDetraccion.loDocumento.Add(oeMovDoc)
            Next
            oeDetraccion.IdPeriodo = oePeriodo.Id
            oeDetraccion.TipoCambio = numTCAdq.Value
            oeDetraccion.Ejercicio = oePeriodo.Ejercicio
            oeDetraccion.IdCtaBancoSoles = cboCtaBancariaSolesAdq.Value
            oeDetraccion.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olDetraccion.GuardarAsiento(oeDetraccion, loDetDetAdqu, CtaCtblePublic) Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                SeleccionTabs(0, ficDetraccion)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetraccion_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griDetraccion.DoubleClickRow
        Editar()
    End Sub

    Private Sub btnConsultarPro_Click(sender As Object, e As EventArgs) Handles btnConsultarPro.Click
        Try
            ListarDetProveedor()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardarPro_Click(sender As Object, e As EventArgs) Handles btnGuardarPro.Click
        Try
            GuardarArchivo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGenArchPro_Click(sender As Object, e As EventArgs) Handles btnGenArchPro.Click
        Try
            GenerarArchivo(2)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtLoteAdq_Validated(sender As Object, e As EventArgs) Handles txtLoteAdq.Validated
        txtLoteAdq.Text = FormatoDocumento(txtLoteAdq.Text, 6)
    End Sub

    Private Sub txtNroLotePro_Validated(sender As Object, e As EventArgs) Handles txtNroLotePro.Validated
        txtNroLotePro.Text = FormatoDocumento(txtNroLotePro.Text, 6)
    End Sub

    Private Sub griPagoAdq_KeyDown(sender As Object, e As KeyEventArgs) Handles griPagoAdq.KeyDown
        With griPagoAdq
            Dim int As Integer = .ActiveRow.Index
            If int > -1 Then
                If e.KeyCode = Keys.Down Then
                    If .Rows(int).Cells("Voucher").IsActiveCell Then
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.BelowCell, False, False)
                        e.Handled = True
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                End If
                If e.KeyCode = Keys.Up Then
                    If .Rows(int).Cells("Voucher").IsActiveCell Then
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.AboveCell, False, False)
                        e.Handled = True
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                End If
                If e.KeyValue = Keys.Space Then
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, 0, 0)
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, 0, 0)
                End If
            End If
        End With
    End Sub

    Private Sub frm_DetraccionesMasivas_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Metodos"

    Private Sub InicializarLogicas()
        olDetDetalle = New l_DetraccionDetalle
        olDetraccion = New l_Detraccion
        olTipoBien = New l_TipoBien
        olTipoOpe = New l_TipoOpeCon
        olCtaCte = New l_CtaCte_ProAdq
        olTipoDoc = New l_TipoDocumento
        olPeriodo = New l_Periodo
        olCombo = New l_Combo
        olCtaBanco = New l_CuentaBancaria
    End Sub

    Private Sub CargarListas()
        Try
            oeTipoBien = New e_TipoBien
            loTipobien = New List(Of e_TipoBien)
            loTipobien.AddRange(olTipoBien.Listar(oeTipoBien))

            oeTipoDoc = New e_TipoDocumento
            loTipoDoc = New List(Of e_TipoDocumento)
            oeTipoDoc.TipoOperacion = "F"
            loTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))

            oeTipoOpe = New e_TipoOpeCon
            loTipoOpe = New List(Of e_TipoOpeCon)
            loTipoOpe.AddRange(olTipoOpe.Listar(oeTipoOpe))

            oeCtaBanco = New e_CuentaBancaria
            loCtaBanco = New List(Of e_CuentaBancaria)
            oeCtaBanco.Activo = 1
            loCtaBanco.AddRange(olCtaBanco.Listar(oeCtaBanco))

            LlenarCombo(cboCtaBancariaSolesAdq, "BancoCuenta", loCtaBanco.Where(Function(i) i.IdMoneda = "1CH01").ToList, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        oeDetraccion = New e_Detraccion
        oeDetDetalle = New e_DetraccionDetalle
        loDetDetAdqu = New List(Of e_DetraccionDetalle)
        griAdquiriente.DataSource = loDetDetAdqu
        loDetDetProo = New List(Of e_DetraccionDetalle)
        griProveedor.DataSource = loDetDetProo
        griPagoPro.DataSource = loDetDetProo
        numImporteAdq.Value = 0
        numImportePro.Value = 0
        numTCAdq.Value = TipoCambio(Date.Now, True)(0)
        numTCPro.Value = numTCAdq.Value
        txtLoteAdq.Text = String.Empty
        txtNroLotePro.Text = String.Empty
        griAdquiriente.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        'griProveedor.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        btnConsultar.Enabled = True
        btnGenArchivo.Enabled = False
        btnGuardar.Enabled = False
        btnAsiento.Enabled = False
        btnConsultarPro.Enabled = True
        btnGenArchPro.Enabled = False
        btnGuardarPro.Enabled = False
        btnGenPagoPro.Enabled = False
        cboCtaBancariaSolesAdq.SelectedIndex = -1
    End Sub

    Private Sub ControlBotones()
        Select Case ficDetraccion.SelectedTab.Index
            Case 0
                If griDetraccion.Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1, 2
                If Operacion = "Nuevo" Then
                    ControlBoton(0, 0, 0, 1, 1)
                Else
                    ControlBoton(0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub Listar()
        Try
            oeDetraccion = New e_Detraccion
            loDetraccion = New List(Of e_Detraccion)
            oeDetraccion.TipoOperacion = ""
            loDetraccion.AddRange(olDetraccion.Listar(oeDetraccion))
            griDetraccion.DataSource = loDetraccion.OrderByDescending(Function(i) i.NroLote).ToList
            griDetraccion.DataBind()
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griDetraccion.Rows
                Select Case fila.Cells("IdEstado").Value
                    Case "1CH00016"
                        fila.CellAppearance.BackColor = Me.UltraColorPicker1.Color
                    Case "1CH00014"
                        fila.CellAppearance.BackColor = Me.UltraColorPicker2.Color
                    Case "1CH00038"
                        fila.CellAppearance.BackColor = Me.UltraColorPicker3.Color
                    Case Else
                        fila.CellAppearance.BackColor = Color.White
                End Select
                If fila.Cells("Tipo").Value = 1 Then
                    fila.Cells("NombreTipo").Appearance.BackColor = Color.LightBlue
                Else
                    fila.Cells("NombreTipo").Appearance.BackColor = Color.WhiteSmoke
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            oeDetraccion.Id = griDetraccion.ActiveRow.Cells("Id").Value
            oeDetraccion = olDetraccion.Obtener(oeDetraccion)
            With oeDetraccion
                If oeDetraccion.Tipo = 1 Then
                    txtLoteAdq.Text = .NroLote
                    numImporteAdq.Value = .Total
                    If oeDetraccion.IdEstado = "1CH00014" Then btnGenArchivo.Enabled = True
                Else
                    txtNroLotePro.Text = .NroLote
                    numImportePro.Value = .Total
                    If oeDetraccion.IdEstado = "1CH00014" Then btnGenArchPro.Enabled = True
                End If
                MostrarDetalle(.Id, .Tipo)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarDetalle(IdDetraccion As String, Tipo As Integer)
        Try
            oeDetDetalle.IdDetraccion = IdDetraccion
            oeDetDetalle.TipoOperacion = ""
            Select Case Tipo
                Case 1
                    loDetDetAdqu.AddRange(olDetDetalle.Listar(oeDetDetalle))
                    griAdquiriente.DataSource = loDetDetAdqu
                    griAdquiriente.DataBind()
                    CalcularTotales(griAdquiriente, "Importe")
                Case 2
                    loDetDetProo.AddRange(olDetDetalle.Listar(oeDetDetalle))
                    griProveedor.DataSource = loDetDetProo
                    griProveedor.DataBind()
                    CalcularTotales(griProveedor, "Importe")
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboGrids()
        CrearComboGrid("IdTipoBien", "Nombre", griAdquiriente, olTipoBien.ComboGrilla(loTipobien), True)
        CrearComboGrid("IdTipoBien", "Nombre", griPagoAdq, olTipoBien.ComboGrilla(loTipobien), True)
        CrearComboGrid("IdTipoBien", "Nombre", griProveedor, olTipoBien.ComboGrilla(loTipobien), True)
        CrearComboGrid("IdTipoBien", "Nombre", griPagoPro, olTipoBien.ComboGrilla(loTipobien), True)
        CrearComboGrid("IdCtaCte_ProAdq", "Cuenta", griAdquiriente, olCtaCte.ComboGrilla(loCtaCteEmpresa), False)
        CrearComboGrid("IdCtaCte_ProAdq", "Cuenta", griPagoAdq, olCtaCte.ComboGrilla(loCtaCteEmpresa), False)
        CrearComboGrid("IdCtaCte_ProAdq", "Cuenta", griProveedor, olCtaCte.ComboGrilla(loCtaCteEmpresa), False)
        CrearComboGrid("IdCtaCte_ProAdq", "Cuenta", griPagoPro, olCtaCte.ComboGrilla(loCtaCteEmpresa), False)
        CrearComboGrid("IdTipoDocumento", "Codigo", griAdquiriente, olTipoDoc.ComboGrillaCodigo(loTipoDoc.OrderBy(Function(I) I.Codigo).ToList), False)
        CrearComboGrid("IdTipoOperacion", "Nombre", griAdquiriente, olTipoOpe.ComboGrillaCodigo(loTipoOpe), True)
        CrearComboGrid("IdTipoDocumento", "Codigo", griProveedor, olTipoDoc.ComboGrillaCodigo(loTipoDoc.OrderBy(Function(I) I.Codigo).ToList), False)
        CrearComboGrid("IdTipoOperacion", "Nombre", griProveedor, olTipoOpe.ComboGrillaCodigo(loTipoOpe), True)
        CrearComboGrid("IdTipoGasto", "Nombre", griPagoAdq, olCombo.ComboGrilla(TipoGastoPublic), True)
        CrearComboGrid("IdTipoGasto", "Nombre", griPagoPro, olCombo.ComboGrilla(TipoGastoPublic), True)
    End Sub

    Private Sub ConsultarDetalle()
        Try
            oeDetDetalle = New e_DetraccionDetalle
            loDetDetAdqu = New List(Of e_DetraccionDetalle)
            griAdquiriente.DataSource = loDetDetAdqu
            oeDetDetalle.TipoOperacion = "1"
            loDetDetAdqu.AddRange(olDetDetalle.Listar(oeDetDetalle))
            griAdquiriente.DataSource = loDetDetAdqu.OrderBy(Function(i) i.ClienteProveedor).ToList
            CrearComboGrid("IdCtaCte_ProAdq", "Cuenta", griAdquiriente, olCtaCte.ComboGrilla(loCtaCteEmpresa), False)
            griAdquiriente.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CalcularTotalDetraccion()
        Try
            numImporteAdq.Value = loDetDetAdqu.Sum(Function(i) i.Importe)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaObjeto()
        Try
            With oeDetraccion
                If Operacion = "Nuevo" Then .TipoOperacion = "I"
                .IdAdquirienteProveedor = ISL_IdClienteProveedor
                .UsuarioCreacion = gUsuarioSGI.Id
                .IdEstado = "1CH00016"
                .loDetraccionDet = New List(Of e_DetraccionDetalle)
                Select Case ficDetraccion.SelectedTab.Index
                    Case 1
                        .Tipo = 1
                        .Total = numImporteAdq.Value
                        .NroLote = FormatoDocumento(txtLoteAdq.Text, 6)
                        .loDetraccionDet.AddRange(loDetDetAdqu)
                    Case 2
                        .Tipo = 2
                        .Total = numImportePro.Value
                        .NroLote = FormatoDocumento(txtNroLotePro.Text, 6)
                        .loDetraccionDet.AddRange(loDetDetProo)
                End Select
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarDetraccion() As Boolean
        Try
            LlenaObjeto()
            oeDetraccion.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olDetraccion.Guardar(oeDetraccion) Then Return False
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub BotonesFichas(Tipo As Integer, Operacion As String)
        Select Case Tipo
            Case 0
                Select Case Operacion
                    Case "Nuevo", "Editar"
                        ficDetAdq.Tabs(0).Enabled = True
                        ficDetAdq.Tabs(1).Enabled = False
                        ficDetAdq.Tabs(0).Selected = True
                    Case "Asiento"
                        ficDetAdq.Tabs(0).Enabled = False
                        ficDetAdq.Tabs(1).Enabled = True
                        ficDetAdq.Tabs(1).Selected = True
                End Select
            Case 1
                Select Case Operacion
                    Case "Nuevo", "Editar"
                        ficDetPro.Tabs(0).Enabled = True
                        ficDetPro.Tabs(1).Enabled = False
                        ficDetPro.Tabs(0).Selected = True
                    Case "Asiento"
                        ficDetPro.Tabs(0).Enabled = False
                        ficDetPro.Tabs(1).Enabled = True
                        ficDetPro.Tabs(1).Selected = True
                End Select
        End Select
    End Sub

    Private Function ObtenerNroLote() As String
        Dim Lote As String = ""
        Try
            Dim oe As New e_Detraccion
            oe.TipoOperacion = "1"
            oe = olDetraccion.Obtener(oe)
            If oe.NroLote = "" Then
                oe.NroLote = "0"
                txtLoteAdq.ReadOnly = False
                txtNroLotePro.ReadOnly = False
            End If
            Lote = FormatoDocumento(CStr(CInt(oe.NroLote) + 1), 6)
        Catch ex As Exception
            Throw ex
        End Try
        Return Lote
    End Function

    Private Sub NuevoAdquiriente()
        Try
            Operacion = "Nuevo"
            SeleccionTabs(1, ficDetraccion)
            Inicializar()
            ControlBotones()
            txtLoteAdq.Text = ObtenerNroLote()
            BotonesFichas(0, Operacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub NuevoProveedor()
        Try
            Operacion = "Nuevo"
            SeleccionTabs(2, ficDetraccion)
            Inicializar()
            ControlBotones()
            txtNroLotePro.Text = ObtenerNroLote()
            BotonesFichas(1, Operacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarDetProveedor()
        Try
            loDetDetProo = New List(Of e_DetraccionDetalle)
            griProveedor.DataSource = loDetDetProo
            oeDetDetalle = New e_DetraccionDetalle
            oeDetDetalle.TipoOperacion = "2"
            loDetDetProo.AddRange(olDetDetalle.Listar(oeDetDetalle))
            griProveedor.DataSource = loDetDetProo
            griProveedor.DataBind()
            numImportePro.Value = loDetDetProo.Sum(Function(i) i.Importe)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GenerarArchivo(Tipo As Integer)
        Dim NombreArchivo As String = ""
        NombreArchivo = "D" & ISL_RUC & IIf(Tipo = 1, txtLoteAdq.Text, txtNroLotePro.Text)
        Try
            Dim stTexto As String = ""
            Dim LibroTipo As String = ""
            Dim LibroSubTipo As String = ""
            Dim Ctr As Integer = 0
            Dim sfd_Dialogo As New System.Windows.Forms.SaveFileDialog
            With sfd_Dialogo
                .Filter = "Libros de Texto Plano (*.txt)|*.txt|Todos Los Archivos (*.*)|*.*"
                .DefaultExt = "txt"
                .FilterIndex = 1
                .Title = "Exportar a ..."
                .FileName = NombreArchivo
            End With
            Dim result As DialogResult = sfd_Dialogo.ShowDialog()
            Dim stNombreArchivo As String = sfd_Dialogo.FileName

            Dim ObjTxt As New System.IO.StreamWriter(stNombreArchivo, False)
            If result = Windows.Forms.DialogResult.Cancel Then Exit Sub

            If IO.File.Exists(stNombreArchivo) = False Then IO.File.Create(stNombreArchivo)
            Dim Total As Double = 0
            If Tipo = 1 Then
                For Each oe As e_DetraccionDetalle In loDetDetAdqu
                    Total += CInt(oe.Importe)
                Next
            Else
                For Each oe As e_DetraccionDetalle In loDetDetProo
                    Total += CInt(oe.Importe)
                Next
            End If
            stTexto = IIf(Tipo = 1, "*", "P") + ISL_RUC + Replace(Replace(ISL_Nombre, ".", ""), " ", "") + "  " _
                + oeDetraccion.NroLote + FormatoDocumento(CStr(CInt(Total)), 13) + "00"
            ObjTxt.WriteLine(stTexto)
            Dim listaArchivo As New List(Of e_DetraccionDetalle)
            If Tipo = 1 Then
                listaArchivo.AddRange(loDetDetAdqu)
            Else
                listaArchivo.AddRange(loDetDetProo)
            End If
            For Each oe As e_DetraccionDetalle In listaArchivo
                stTexto = "6" + oe.RUC
                stTexto += "                                   "
                stTexto += oe.NroProforma
                stTexto += oe.CodigoBien
                oeCtaCte = New e_CtaCte_ProAdq
                oeCtaCte.Id = oe.IdCtaCte_ProAdq
                If loCtaCteEmpresa.Contains(oeCtaCte) Then
                    oeCtaCte = loCtaCteEmpresa.Item(loCtaCteEmpresa.IndexOf(oeCtaCte))
                Else
                    Throw New Exception("Error en Cta Corriente. Empresa: " & oe.ClienteProveedor)
                End If
                stTexto += oeCtaCte.Cuenta
                stTexto += FormatoDocumento(CStr(CInt(oe.Importe)), 13) + "00"
                stTexto += oe.CodigoOpe
                stTexto += oe.Periodo
                oeTipoDoc = New e_TipoDocumento
                oeTipoDoc.Id = oe.IdTipoDocumento
                oeTipoDoc.Equivale = 0
                If loTipoDoc.Contains(oeTipoDoc) Then
                    oeTipoDoc = loTipoDoc.Item(loTipoDoc.IndexOf(oeTipoDoc))
                Else
                    Throw New Exception("Error en Documento. Empresa: " & oe.ClienteProveedor)
                End If
                stTexto += oeTipoDoc.Codigo
                stTexto += oe.Serie.Substring(0, 4)
                stTexto += Strings.Right(oe.Numero, 8)
                ObjTxt.WriteLine(stTexto)
            Next
            ObjTxt.Close()
            If MessageBox.Show("Se ha Generado Satisfactoriamente el archivo, desea poder visualizarlo?", "ISL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Process.Start(stNombreArchivo)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GuardarArchivo()
        Try
            If Operacion = "Archivo" Then
                oeDetraccion.TipoOperacion = "C"
                oeDetraccion.loDetraccionDet = New List(Of e_DetraccionDetalle)
                oeDetraccion.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olDetraccion.Guardar(oeDetraccion) Then
                    mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                    SeleccionTabs(0, ficDetraccion)
                    Consultar(True)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    Private Sub griProveedor_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griProveedor.AfterCellUpdate
        Try
            Dim Importe As Double = 0
            If griProveedor.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "IdTipoBien"
                        With griProveedor.Rows(e.Cell.Row.Index)
                            oeTipoBien = New e_TipoBien
                            oeTipoBien.Id = .Cells("IdTipoBien").Value
                            oeTipoBien = olTipoBien.Obtener(oeTipoBien)
                            Importe = .Cells("TotalDocumento").Value * oeTipoBien.Porcentaje / 100
                            If .Cells("IdMoneda").Value = "1CH02" Then
                                .Cells("Importe").Value = Math.Round(Importe * numTCAdq.Value, 2, MidpointRounding.AwayFromZero)
                            Else
                                .Cells("Importe").Value = CInt(Importe)
                            End If
                        End With
                End Select
            End If
            CalcularTotales(griProveedor, "Importe")
            numImportePro.Value = loDetDetProo.Sum(Function(i) i.Importe)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griProveedor_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griProveedor.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griProveedor_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griProveedor.CellChange
        griProveedor.UpdateData()
    End Sub
End Class