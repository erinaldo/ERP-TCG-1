Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ConfimarOTs

#Region "Declaracion de variables y/o objetos"

    Dim oeOrdenTrabajo As New e_OrdenTrabajo, olOrdenTrabajo As New l_OrdenTrabajo

    Dim oeMantenimiento As New e_Mantenimiento, olMantenimiento As New l_Mantenimiento
    Dim oeTipoMantenimiento As New e_TipoMantenimiento, olTipoMantenimiento As New l_TipoMantenimiento
    Dim oeEstadoOT As New e_EstadoOT, olEstadoOT As New l_EstadoOT
    Dim oeEquipo As New e_Equipo, olEquipo As New l_Equipo

    Dim lstTipoMantenimiento As New List(Of e_TipoMantenimiento)
    Dim lstEstadoOT As New List(Of e_EstadoOT)
    Dim lstMantenimiento As New List(Of e_Mantenimiento)
    Dim lstEquipo As New List(Of e_Equipo)
    Dim lstTrabajador As New List(Of e_Trabajador)
    Dim oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador

    Private oeRegConformidadOT As New e_RegistroConformidadOT
    Private olRegConformidadOT As New l_RegistroConformidadOT

    Private oeDetRegConformidadOT As New e_DetalleRegConformidadOT
    Private olDetRegConformidadOT As New l_DetalleRegConformidadOT

    Dim dsOT As DataSet
    Private muestraBotones As Integer = 1
    Private Shared instancia As frm_ConfimarOTs = Nothing
    Private Shared Operacion As String


#End Region

#Region "Definición del Formulario base"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ConfimarOTs()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Metodos y Funciones"

    Private Sub MostrarBotones()
        Select Case muestraBotones
            Case 1
                ControlBoton(1)
            Case 2
                ControlBoton(1, 0, 0, 1)
        End Select
    End Sub

    Public Sub ListarRegistroConfirmadaOTs(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            oeRegConformidadOT = New e_RegistroConformidadOT
            oeRegConformidadOT.Activo = Activo
            oeRegConformidadOT.TipoOperacion = ""
            oeRegConformidadOT.FechaInicio = rfDesde.Value
            oeRegConformidadOT.FechaFin = rfHasta.Value
            grilla_Confirmadas.DataSource = olRegConformidadOT.Listar(oeRegConformidadOT)

        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub MostrarOTsConfirmadas()
        Try
            Cursor.Current = Cursors.WaitCursor
            oeDetRegConformidadOT = New e_DetalleRegConformidadOT
            oeDetRegConformidadOT.TipoOperacion = "C" 'Lista OT's Confirmadas
            oeDetRegConformidadOT.IdRegConformidadOT = grilla_Confirmadas.ActiveRow.Cells("Id").Value

            dsOT = olDetRegConformidadOT.Listar(oeDetRegConformidadOT)

            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) OT
            'Tabla(1) Equipo
            'Tabla(2) Mantenimiento
            'Tabla(3) Material
            ''''''''''''''''''''''''''''''''''''''''''''''

            Dim IdOT As DataColumn = dsOT.Tables(0).Columns("IdOT")
            Dim IdOT_EM As DataColumn = dsOT.Tables(1).Columns("IdOrdenTrabajo")
            Dim relation1 As DataRelation = New DataRelation("FK_Relacion_OTE", IdOT, IdOT_EM, True)
            dsOT.Relations.Add(relation1)

            Dim TransactionColumns() As DataColumn, DetailColumns() As DataColumn
            TransactionColumns = New DataColumn() {dsOT.Tables(1).Columns("IdOrdenTrabajo"), dsOT.Tables(1).Columns("IdEquipo")}
            DetailColumns = New DataColumn() {dsOT.Tables(2).Columns("IdOrdenTrabajo"), dsOT.Tables(2).Columns("IdEquipo")}
            Dim Tran_Detail As New DataRelation("FK_Relacion_OTEM", TransactionColumns, DetailColumns)
            dsOT.Relations.Add(Tran_Detail)

            TransactionColumns = New DataColumn() {dsOT.Tables(2).Columns("IdOrdenTrabajo"), dsOT.Tables(2).Columns("IdEquipo"), dsOT.Tables(2).Columns("IdMantenimiento")}
            DetailColumns = New DataColumn() {dsOT.Tables(3).Columns("IdOrdenTrabajo"), dsOT.Tables(3).Columns("IdEquipo"), dsOT.Tables(3).Columns("IdMantenimiento")}
            Tran_Detail = New DataRelation("FK_Relacion_MM", TransactionColumns, DetailColumns)
            dsOT.Relations.Add(Tran_Detail)

            dsOT.AcceptChanges()

            With grilla_OTs
                .DataSource = dsOT

                .DisplayLayout.Bands(1).ColHeadersVisible = False
                .DisplayLayout.Bands(2).ColHeadersVisible = False
                .DisplayLayout.Bands(3).ColHeadersVisible = False

                .DisplayLayout.Bands(1).Columns("IdOrdenTrabajo").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdEquipo").Hidden = True
                .DisplayLayout.Bands(2).Columns("IdOrdenTrabajo").Hidden = True
                .DisplayLayout.Bands(2).Columns("IdEquipo").Hidden = True
                .DisplayLayout.Bands(2).Columns("IdMantenimiento").Hidden = True

                .DisplayLayout.Bands(3).Columns("IdOrdenTrabajo").Hidden = True
                .DisplayLayout.Bands(3).Columns("IdEquipo").Hidden = True
                .DisplayLayout.Bands(3).Columns("IdMantenimiento").Hidden = True
                .DisplayLayout.Bands(3).Columns("IdMaterial").Hidden = True

                .DisplayLayout.Bands(1).Columns("Odometro").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(1).Columns("Horometro").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(3).Columns("CantidadMaterialEntregada").CellAppearance.TextHAlign = HAlign.Right
            End With
            If dsOT.Tables(0).Rows.Count > 0 Then
                Me.gr_expande_OT.Expanded = True
            End If


        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub ListarOrdenesTrabajo(ByVal Activo As Boolean)
        'Lista Ordenes Para Confirmar
        Try
            Cursor.Current = Cursors.WaitCursor
            oeOrdenTrabajo = New e_OrdenTrabajo
            oeOrdenTrabajo.Activo = Activo
            oeOrdenTrabajo.TipoOperacion = "C"
            oeOrdenTrabajo.FechaProgramacionIni = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.FechaProgramacionFin = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.FechaIngresoTaller = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.FechaInicioTrabajo = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.FechaFinTrabajo = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.FechaCreacion = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.NroOT = IIf(rbNroOT.Checked, Me.txtOT.Text, "")
            oeOrdenTrabajo.IdEstadoOT = IIf(cmEstadoOT.Value <> "CERO", cmEstadoOT.Value, "")
            oeOrdenTrabajo.IdEquipo = IIf(cmEquipo.Value <> "CERO", cmEquipo.Value, "")
            oeOrdenTrabajo.IdSupervisorMant = IIf(Me.cmbSupervisorMant.Value <> "CERO", cmbSupervisorMant.Value, "")
            oeOrdenTrabajo.IdMantenimiento = IIf(cmMantenimiento.Value <> "CERO", cmMantenimiento.Value, "")
            oeOrdenTrabajo.IdTipoMantenimiento = IIf(cmTipoMantenimiento.Value <> "CERO", cmTipoMantenimiento.Value, "")
            oeOrdenTrabajo.IndicadorTipo = IIf(cmbTipo.SelectedIndex <> 0, Strings.Left(cmbTipo.Text, 1), "")
            If optFechas.CheckedIndex = 0 Then
                oeOrdenTrabajo.FechaProgramacionIni = dtp_DesdeProg.Value
                oeOrdenTrabajo.FechaProgramacionFin = dtp_HastaProg.Value
                'Else
                '    oeOrdenTrabajo.FechaFinTrabajo = rfEjecucion.Desde
                '    oeOrdenTrabajo.FechaFinTrabajo = rfEjecucion.Hasta
            End If

            dsOT = olOrdenTrabajo.Listar(oeOrdenTrabajo)

            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) OT
            'Tabla(1) Equipo
            'Tabla(2) Mantenimiento
            'Tabla(3) Material
            ''''''''''''''''''''''''''''''''''''''''''''''

            Dim IdOT As DataColumn = dsOT.Tables(0).Columns("IdOT")
            Dim IdOT_EM As DataColumn = dsOT.Tables(1).Columns("IdOrdenTrabajo")
            Dim relation1 As DataRelation = New DataRelation("FK_Relacion_OTOT", IdOT, IdOT_EM, True)
            dsOT.Relations.Add(relation1)

            Dim TransactionColumns() As DataColumn, DetailColumns() As DataColumn
            TransactionColumns = New DataColumn() {dsOT.Tables(1).Columns("IdOrdenTrabajo"), dsOT.Tables(1).Columns("IdEquipo")}
            DetailColumns = New DataColumn() {dsOT.Tables(2).Columns("IdOrdenTrabajo"), dsOT.Tables(2).Columns("IdEquipo")}
            Dim Tran_Detail As New DataRelation("FK_Relacion_OTEM", TransactionColumns, DetailColumns)
            dsOT.Relations.Add(Tran_Detail)
            dsOT.AcceptChanges()

            Dim TransactionColumns1() As DataColumn, DetailColumns1() As DataColumn
            TransactionColumns1 = New DataColumn() {dsOT.Tables(2).Columns("IdOrdenTrabajo"), dsOT.Tables(2).Columns("IdEquipo"), dsOT.Tables(2).Columns("IdMantenimiento")}
            DetailColumns1 = New DataColumn() {dsOT.Tables(3).Columns("IdOrdenTrabajo"), dsOT.Tables(3).Columns("IdEquipo"), dsOT.Tables(3).Columns("IdMantenimiento")}
            Dim Tran_Detail1 As New DataRelation("FK_Relacion_MM", TransactionColumns1, DetailColumns1, True)
            dsOT.Relations.Add(Tran_Detail1)

            dsOT.AcceptChanges()
            grid_OrdenTrabajo.DataSource = dsOT
            With grid_OrdenTrabajo.DisplayLayout
                .UseFixedHeaders = True
                .Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                With .Bands(0)
                    .Columns("IndConformidad").Width = 8
                    .Columns("Odometro").CellActivation = Activation.NoEdit

                    .Columns("IdOT").Header.Fixed = True
                    .Columns("NroOT").Header.Fixed = True
                    .Columns("TipoMantenimiento").Header.Fixed = True
                End With

                With .Bands(1)
                    .ColHeadersVisible = False
                    .Columns("IdOrdenTrabajo").Hidden = True
                    .Columns("IdEquipo").Hidden = True
                    .Columns("Odometro").CellAppearance.TextHAlign = HAlign.Right
                    .Columns("Horometro").CellAppearance.TextHAlign = HAlign.Right

                    .Columns("IdOrdenTrabajo").Header.Fixed = True
                    .Columns("IdEquipo").Header.Fixed = True
                    .Columns("Equipo").Header.Fixed = True
                    .Columns("TipoMantenimiento").Header.Fixed = True
                End With

                With .Bands(2)
                    .ColHeadersVisible = False
                    .Columns("IdOrdenTrabajo").Hidden = True
                    .Columns("IdEquipo").Hidden = True
                    .Columns("IdMantenimiento").Hidden = True

                    .Columns("IdOrdenTrabajo").Header.Fixed = True
                    .Columns("IdEquipo").Header.Fixed = True
                    .Columns("IdMantenimiento").Header.Fixed = True
                    .Columns("Mantenimiento").Header.Fixed = True
                    .Columns("TipoMantenimiento").Header.Fixed = True
                End With

                With .Bands(3)
                    .ColHeadersVisible = False
                    .Columns("IdOrdenTrabajo").Hidden = True
                    .Columns("IdEquipo").Hidden = True
                    .Columns("IdMantenimiento").Hidden = True
                    .Columns("IdMaterial").Hidden = True
                    .Columns("CantidadMaterialEntregada").CellAppearance.TextHAlign = HAlign.Right

                    .Columns("IdOrdenTrabajo").Header.Fixed = True
                    .Columns("IdEquipo").Header.Fixed = True
                    .Columns("IdMantenimiento").Header.Fixed = True
                    .Columns("IdMaterial").Header.Fixed = True
                    .Columns("MantenimientoMaterial").Header.Fixed = True
                    .Columns("CantidadMaterialEntregada").Header.Fixed = True
                End With


                For Each fila As UltraGridRow In .Rows
                    Select Case fila.Cells("Estado").Value
                        Case "PENDIENTE"
                            fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                            .Bands(0).Columns("IndConformidad").CellActivation = Activation.NoEdit
                        Case "EN PROCESO"
                            fila.CellAppearance.BackColor = Me.ColoresEnProceso.Color
                            .Bands(0).Columns("IndConformidad").CellActivation = Activation.NoEdit
                        Case "TERMINADA"
                            fila.CellAppearance.BackColor = Me.ColoresTerminada.Color
                            .Bands(0).Columns("IndConformidad").CellActivation = Activation.AllowEdit
                    End Select
                Next

                For x As Integer = 0 To .Rows.Count - 1
                    .Rows(x).ExpandAll()
                Next

            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_OrdenTrabajo.Focus()
    End Sub

    Public Sub LlenaCombos()
        Try
            LlenaComboTipoMantenimiento()
            LlenaComboMantenimiento("")
            LlenaComboEstadoOT()
            LlenaComboEquipo()
            LlenaComboJefeFlota()
            cmbTipo.SelectedIndex = 0
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub LlenaComboJefeFlota()
        Try
            oeTrabajador.Id = "CERO" : oeTrabajador.oePersona.Nombre = "TODOS"
            lstTrabajador.Add(oeTrabajador)
            oeTrabajador = New e_Trabajador
            oeTrabajador.Activo = True
            oeTrabajador.TipoOperacion = ""
            oeTrabajador.oeCargo.Id = "1CH004"
            lstTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))
            Dim _leTrabAux = From le In lstTrabajador _
                             Select le.Id, le.oePersona.NombreCompleto
            LlenarComboMaestro(cmbSupervisorMant, _leTrabAux.ToList, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboTipoMantenimiento()
        Try
            oeTipoMantenimiento.Id = "CERO" : oeTipoMantenimiento.Nombre = "TODOS"
            lstTipoMantenimiento.Add(oeTipoMantenimiento)
            oeTipoMantenimiento = New e_TipoMantenimiento
            oeTipoMantenimiento.Activo = True
            lstTipoMantenimiento.AddRange(olTipoMantenimiento.Listar(oeTipoMantenimiento))
            LlenarComboMaestro(cmTipoMantenimiento, lstTipoMantenimiento, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboEstadoOT()
        Try
            oeEstadoOT.Id = "CERO" : oeEstadoOT.Nombre = "TODOS"
            lstEstadoOT.Add(oeEstadoOT)
            oeEstadoOT = New e_EstadoOT
            oeEstadoOT.Activo = True
            lstEstadoOT.AddRange(olEstadoOT.Listar(oeEstadoOT))
            LlenarComboMaestro(cmEstadoOT, lstEstadoOT, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboEquipo()
        Try
            oeEquipo.Id = "CERO" : oeEquipo.Nombre = "TODOS"
            lstEquipo.Add(oeEquipo)
            oeEquipo = New e_Equipo
            oeEquipo.Activo = True
            lstEquipo.AddRange(olEquipo.Listar(oeEquipo))
            LlenarComboMaestro(cmEquipo, lstEquipo, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboMantenimiento(ByVal ls_IdTipoMantenimiento As String)
        lstMantenimiento = New List(Of e_Mantenimiento)
        oeMantenimiento.Id = "CERO" : oeMantenimiento.Nombre = "TODOS"
        lstMantenimiento.Add(oeMantenimiento)
        oeMantenimiento = New e_Mantenimiento
        oeMantenimiento.IdTipoMantenimiento = ls_IdTipoMantenimiento
        oeMantenimiento.Activo = True
        lstMantenimiento.AddRange(olMantenimiento.Listar(oeMantenimiento))
        LlenarComboMaestro(cmMantenimiento, lstMantenimiento, 0)
    End Sub

    Private Sub CargarOrdenTrabajoConfirmadas()
        oeRegConformidadOT.lstDetalleRegConformidadOT.Clear()
        Dim ls_NroOT As String = "", Msg As String = ""
        For Each matRow As DataRow In dsOT.Tables(0).Rows
            If matRow("Seleccion") Then
                oeDetRegConformidadOT = New e_DetalleRegConformidadOT
                oeDetRegConformidadOT.Id = ""
                oeDetRegConformidadOT.IdOT = matRow("IdOT")
                oeRegConformidadOT.lstDetalleRegConformidadOT.Add(oeDetRegConformidadOT)
                ls_NroOT &= Environment.NewLine & matRow("NroOT") & " : " & matRow("FechaProgramacion")
            End If
        Next

        If oeRegConformidadOT.lstDetalleRegConformidadOT.Count > 0 Then
            Dim frmGuardar As frm_GuardaConfirmacionOTs
            frmGuardar = New frm_GuardaConfirmacionOTs(oeRegConformidadOT)
            frmGuardar.StartPosition = FormStartPosition.CenterScreen
            If frmGuardar.ShowDialog = Windows.Forms.DialogResult.OK Then
                If frmGuardar.chkEnviarmail.Checked Then
                    Msg = "Ordenes de Trabajo " & IIf(frmGuardar.chkEnviarmail.Checked, "conformes", "disconformes") _
                    & Environment.NewLine & ls_NroOT & Environment.NewLine & " " & frmGuardar.txtGlosa.Text
                    EnviarCorreo(Msg)
                End If
                LimpiaLista(2)
                MostrarTabs(0, tcOrdenTrabajo, 1)
                ListarRegistroConfirmadaOTs(True)
            End If
        Else
            mensajeEmergente.Problema("Seleccione OT's")
        End If
    End Sub

    Sub EnviarCorreo(ByVal ls_Msg As String)
        Try
            Dim correoTrabajador As String = ""
            Dim formulario As frm_EnvioCorreo
            formulario = frm_EnvioCorreo
            If gUsuarioSGI.oePersona.leEmail.Count > 0 Then correoTrabajador = gUsuarioSGI.oePersona.leEmail.Item(0).Nombre '"weezer@hotmail.com" 'Quien lo envia                
            If formulario.ObtenerDatos("", "", correoTrabajador, False, True, True, True, _
                 "ojcm2754@gmail.com", ls_Msg) Then
                formulario.StartPosition = FormStartPosition.CenterScreen
                formulario.ShowDialog()
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
            End If
            formulario = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
    Sub LimpiaLista(ByVal opc As Integer)
        If opc = 2 Then
            grid_OrdenTrabajo.DataSource = odOrdenTrabajo
        Else
            grilla_Confirmadas.DataSource = odRegConfirmadas
            grilla_OTs.DataSource = odOrdenTrabajo
        End If
    End Sub
#End Region

#Region "Eventos"

    Private Sub frm_ConfimarOTs_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        MostrarBotones()
    End Sub

    Private Sub frm_ConfimarOTs_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ConfimarOTs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_ConfimarOTs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ColoresGenerado.Color = Color.White
            ColoresEnProceso.Color = Color.Khaki
            ColoresTerminada.Color = Color.LightGreen
            dtp_DesdeProg.Value = Date.Today.AddDays(-4) : dtp_HastaProg.Value = Date.Today
            dtp_DesdeTer.Value = Date.Today.AddDays(-4) : dtp_HastaTer.Value = Date.Today
            rfDesde.Value = Date.Today.AddDays(-7) : rfHasta.Value = Date.Today
            LlenaCombos()
            MostrarBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
    Private Sub mcDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcDetalle.Opening
        mcDetalle.Items("VerToolStripMenuItem").Visible = IIf(grilla_Confirmadas.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarToolStripMenuItem.Click
        MostrarTabs(1, tcOrdenTrabajo, 0)
    End Sub

    Private Sub VerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerToolStripMenuItem.Click
        Try
            MostrarOTsConfirmadas()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grilla_Confirmadas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grilla_Confirmadas.DoubleClick
        Try
            If grilla_Confirmadas.Selected.Rows.Count > 0 Then MostrarOTsConfirmadas()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
    Private Sub rbNroOT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNroOT.CheckedChanged
        gbNroOT.Enabled = rbNroOT.Checked
        txtOT.Focus()
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDatosAdicionales.CheckedChanged
        gbDatosAdicionales.Enabled = rbDatosAdicionales.Checked
        txtOT.Text = String.Empty
    End Sub

    Private Sub grid_OrdenTrabajo_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_OrdenTrabajo.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub tcOrdenTrabajo_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tcOrdenTrabajo.SelectedTabChanged
        If tcOrdenTrabajo.Tabs(0).Selected Then
            muestraBotones = 1
            MostrarBotones()
        Else
            muestraBotones = 2
            MostrarBotones()
        End If
    End Sub
    Private Sub optFechas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optFechas.ValueChanged
        If optFechas.CheckedIndex <> -1 Then
            dtp_DesdeProg.Enabled = IIf(optFechas.CheckedIndex = 0, True, False)
            dtp_HastaProg.Enabled = IIf(optFechas.CheckedIndex = 0, True, False)
            dtp_DesdeTer.Enabled = IIf(optFechas.CheckedIndex = 1, True, False)
            dtp_HastaTer.Enabled = IIf(optFechas.CheckedIndex = 1, True, False)
        End If
    End Sub
#End Region

    Private Sub grid_OrdenTrabajo_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles grid_OrdenTrabajo.AfterHeaderCheckStateChanged
        grid_OrdenTrabajo.UpdateData()
    End Sub

#Region "Botones" 'Manejo de botones del menú principal del sistema

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            If tcOrdenTrabajo.Tabs(1).Selected Then
                ListarOrdenesTrabajo(Activo)
            Else
                ListarRegistroConfirmadaOTs(Activo)
            End If
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            grid_OrdenTrabajo.DataBind()
            CargarOrdenTrabajoConfirmadas()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        If tcOrdenTrabajo.SelectedTab.Index = 0 Then
            Exportar_Excel(grilla_Confirmadas)
        Else
            Exportar_Excel(grid_OrdenTrabajo)
        End If
    End Sub

#End Region

    Private Sub grilla_Confirmadas_InitializeRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles grilla_Confirmadas.InitializeRow
        Select Case e.Row.Cells("Indicador").Value
            Case "C"
                e.Row.Cells("Indicador").Value = "CONFORME"
            Case "D"
                e.Row.Cells("Indicador").Value = "DISCONFORME"
        End Select
    End Sub

    Private Sub grilla_Confirmadas_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grilla_Confirmadas.CellChange
        grilla_Confirmadas.UpdateData()
    End Sub

    Private Sub grid_OrdenTrabajo_BeforeCellActivate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableCellEventArgs) Handles grid_OrdenTrabajo.BeforeCellActivate
        With grid_OrdenTrabajo
            Select Case e.Cell.Column.Key.ToUpper
                Case "SELECCION"
                    If .ActiveRow.Cells("Estado").Value <> "TERMINADA" Then
                        .DisplayLayout.Bands(0).Columns("Seleccion").CellActivation = Activation.NoEdit
                    Else
                        .DisplayLayout.Bands(0).Columns("Seleccion").CellActivation = Activation.AllowEdit
                    End If
            End Select
        End With
       
    End Sub

End Class