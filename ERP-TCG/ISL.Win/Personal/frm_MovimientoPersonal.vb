'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop

Public Class frm_MovimientoPersonal
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_MovimientoPersonal = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_MovimientoPersonal()
        End If
        instancia.Activate()
        Return instancia

    End Function

#Region "Declaracion de Variables"

    Dim oeMovimientoPersonal As New e_MovimientoPersonal
    Dim olMovimientoPersonal As New l_MovimientoPersonal
    Private olPersona As New l_Persona
    Dim _ingresando_datos As Boolean = False
    Private oePlanilla As New e_Planilla, olPlanilla As New l_Planilla, lePlanilla As New List(Of e_Planilla)
    Private oeResumenAsis As New e_ResumenAsistencia, olResumenAsis As New l_ResumenAsistencia
    Private leResumenAsis As New List(Of e_ResumenAsistencia), leResAsisAux As New List(Of e_ResumenAsistencia)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador
    Private leTrabajador As New List(Of e_Trabajador), leTrabActivo As New List(Of e_Trabajador)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private _acl As String = "", _bandload As Boolean = False
    Dim oeSituacionAdministrativa As New e_SituacionAdministrativa
    Dim olSituacionAdministrativa As New l_SituacionAdministrativa
    Dim ListaoeSituacionAdministrativa As New List(Of e_SituacionAdministrativa)

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case ficMovimientoPersonal.SelectedTab.Index
                Case 0
                    ListarResumenAsistencia()
                    'Case 2
                    '    ListarResumenAsistencia()
                Case 2
                    ListarRecordVacaciones()
            End Select
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            'MostrarTabs(1, ficMovimientoPersonal, 1)
            SeleccionarTab(1)
            InicializarEdicion()
            oeResumenAsis = New e_ResumenAsistencia
            MyBase.Nuevo()
            cboTrabajadores.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            If griConsolidado.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeResumenAsis = New e_ResumenAsistencia
                oeResumenAsis.Id = griConsolidado.ActiveRow.Cells("Id").Value.ToString
            Else
                Throw New Exception("Seleccione registro a editar.")
            End If
            Operacion = "Editar"
            SeleccionarTab(1)
            Mostrar()
            'oeMovimientoPersonal.TipoOperacion = "A"
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        
    End Sub

    Public Overrides Sub Guardar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If Guardando() Then
                MyBase.Guardar()
            Else
                'MostrarTabs(1, ficMovimientoPersonal, 1)
                SeleccionarTab(1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try

            SeleccionarTab(0) : Consultar(_Activo)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            'Select Case ficMovimientoPersonal.SelectedTab.Index
            '    Case 1
            '        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            '        SeleccionarTab(0) : Consultar(_Activo)
            '        'If oeMovimientoPersonal.Modificado Then
            '        '    Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", _
            '        '                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            '        '        Case Windows.Forms.DialogResult.Yes
            '        '            If Guardando() Then
            '        '                SeleccionarTab(0) : Consultar(_Activo)
            '        '            Else
            '        '                _ingresando_datos = True : SeleccionarTab(0)
            '        '            End If
            '        '        Case Windows.Forms.DialogResult.No
            '        '            SeleccionarTab(0) : Consultar(_Activo)
            '        '    End Select
            '        'Else
            '        '    SeleccionarTab(0) : Consultar(_Activo)
            '        'End If
            '    Case 2
            '        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            '        SeleccionarTab(0) : Consultar(_Activo)
            '        'If MessageBox.Show("¿Desea Cancelar la Importacion de Datos?", "Mensaje de Sistema", _
            '        '                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            '        '    SeleccionarTab(0) : Consultar(_Activo)
            '        'End If
            'End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Public Overrides Sub Eliminar()
    '    Try
    '        With griListaMovimientosPersonal
    '            If ValidarGrilla(griListaMovimientosPersonal, "Trabajador") Then
    '                oeMovimientoPersonal.Id = .ActiveRow.Cells("ID").Value
    '                oeMovimientoPersonal = olMovimientoPersonal.Obtener(oeMovimientoPersonal)
    '                If oeMovimientoPersonal.Activo Then
    '                    If MessageBox.Show("Esta seguro de eliminar el MovimientoPersonal: " & _
    '                             .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
    '                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
    '                        oeMovimientoPersonal.TipoOperacion = "E"
    '                        olMovimientoPersonal.Eliminar(oeMovimientoPersonal)
    '                        Consultar(True)
    '                    End If
    '                Else
    '                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
    '                End If
    '            End If
    '        End With
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message)
    '    End Try
    'End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            Select Case ficMovimientoPersonal.SelectedTab.Index
                Case 0
                    Select Case ficDetalle.SelectedTab.Index
                        Case 0
                            If griConsolidado.Rows.Count = 0 Then Throw New Exception("No hay Registros para exportar")
                            Exportar_Excel(griConsolidado, "Resumen Asistencia")
                        Case 1

                    End Select
                Case 1

                Case 2
                    If gridRecordVacaciones.Rows.Count = 0 Then Throw New Exception("No hay Registros para exportar")
                    Exportar_Excel(gridRecordVacaciones, "Record Vacaciones")
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Cargo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Cargo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select

        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Cargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            SeleccionarTab(0)
            ficDetalle.Tabs(1).Enabled = False
            InicializaTiempo()

            colorBaja.Color = Color.LightCoral
            colorActivo.Color = Color.LightGreen
            colorPorLiquidar.Color = Color.Khaki

            verFiltro.Checked = False
            LlenaComboConfigurable(cboBuscaEstado, "T15_Situacion", "CODIGO", "NOMBRE", -1)
            cboBuscaEstado.ReadOnly = True

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = "A"
            oePlanilla.Activo = True
            oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla).OrderByDescending(Function(it) it.Codigo).ToList
            LlenarCombo(cboPlanilla, "Codigo", lePlanilla, -1)

            LlenarCombo(cboPlanillaEdicion, "Codigo", lePlanilla, -1)

            oeTrabajador = New e_Trabajador
            oeTrabajador.Activo = True
            Dim _leTrab = olTrabajador.Listar(oeTrabajador)
            Dim _leTrabAux = From le In _leTrab Select le.Id, le.oePersona.NombreCompleto
            cboTrabajadores.DataSource = _leTrabAux.ToList
            cboTrabajadores.DisplayMember = "NombreCompleto"

            
            oeSituacionAdministrativa = New e_SituacionAdministrativa
            oeSituacionAdministrativa.Activo = True
            ListaoeSituacionAdministrativa = olSituacionAdministrativa.Listar(oeSituacionAdministrativa)
            cboTipo.DataSource = ListaoeSituacionAdministrativa

            oeEstado = New e_Estado
            oeEstado.Nombre = "PLANILLA EPS"
            leEstado = olEstado.Listar(oeEstado)
            LlenarCombo(cboEstadoCon, "Nombre", leEstado, -1)
            LlenarCombo(cboEstadoEdicion, "Nombre", leEstado, -1)

            _bandload = True
            leResumenAsis = New List(Of e_ResumenAsistencia)
            CargarResumenAsistencia(leResumenAsis)
            leResAsisAux = New List(Of e_ResumenAsistencia)
            CargarResAsisImportar(leResAsisAux)
            _bandload = False

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub



    'Private Sub griListaMovimientosPersonal_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)
    '    agrListaMovimientoPersonals.Text = "Total de Movimientos registrados: " & e.Layout.Rows.Count
    'End Sub

    ''' <summary>
    ''' Asigna el Id del trabajador seleccionado al Movimiento de personal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboTrabajadores_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadores.ValueChanged
        If cboTrabajadores.SelectedIndex > -1 Then
            oeMovimientoPersonal.IdTrabajador = cboTrabajadores.Value
            Dim oeTrabajador As New e_Trabajador
            Dim olTrabajador As New l_Trabajador
            oeTrabajador.Id = oeMovimientoPersonal.IdTrabajador
            oeTrabajador = olTrabajador.Obtener(oeTrabajador)

            If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then FotoTrabajador.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)

            'ListarMovimientos(True)

            agrDatosBasicos.Visible = True
            txtArea.Text = oeTrabajador.oeArea.Nombre
            txtCargo.Text = oeTrabajador.oeCargo.Nombre
            fecFechaIngreso.Value = oeTrabajador.FechaIngreso

            chkDisponible.Checked = oeTrabajador.Disponible
            If oeTrabajador.Disponible Then
                chkDisponible.BackColor = Color.Transparent
                chkDisponible.ForeColor = Color.Black
                chkDisponible.Text = "Disponible"
            Else
                chkDisponible.BackColor = Color.Red
                chkDisponible.ForeColor = Color.Yellow
                chkDisponible.Text = "Trabajador NO Disponible"
            End If

        End If

    End Sub

    ''' <summary>
    ''' Asigna el Id de la situación administrativa seleccionada al Movimiento de personal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboSituacionAdministrativa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.ValueChanged
        If cboTipo.SelectedIndex > -1 Then
            oeSituacionAdministrativa = ListaoeSituacionAdministrativa.Where(Function(x) x.Id = cboTipo.Value).First
            'oeSituacionAdministrativa = ListaoeSituacionAdministrativa.where(F)
            oeMovimientoPersonal.IdSituacionAdministrativa = cboTipo.Value
            chkGoze.Checked = oeSituacionAdministrativa.Remunerado
            chkIndicadorAux.Checked = oeSituacionAdministrativa.AcumulaVacaciones
            txtCodigoPlame.Text = oeSituacionAdministrativa.CodigoPlame
        End If

    End Sub

    Private Sub txtObservacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObservacion.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtObservacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservacion.ValueChanged
        oeMovimientoPersonal.Observacion = txtObservacion.Text.Trim
    End Sub

    Private Sub fecFechaFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaFin.ValueChanged
        oeMovimientoPersonal.FechaFin = fecFechaFin.Value
    End Sub

    'Private Sub griListaMovimientosPersonal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griListaMovimientosPersonal.DoubleClick
    '    If griListaMovimientosPersonal.Selected.Rows.Count > 0 Then Editar()
    'End Sub

    Private Sub cboPlanilla_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanilla.ValueChanged
        If cboPlanilla.SelectedIndex > -1 Then
            oePlanilla = New e_Planilla
            oePlanilla = cboPlanilla.Items(cboPlanilla.SelectedIndex).ListObject
            fecInicioPla.Value = oePlanilla.FechaInicio
            fecFinPla.Value = oePlanilla.FechaFin
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                leResAsisAux.Clear()
                Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoGenerada).ToList
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        etiEjecuta.Text = "Procesando " & ln_Fila & " registros ... "
                        oeResumenAsis = New e_ResumenAsistencia
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2 : oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leTrabajador.Contains(oeTrabajador) Then
                            Dim _leAux = leTrabajador.Where(Function(it) it.oePersona.Dni = oeTrabajador.oePersona.Dni).ToList
                            If _leAux.Count > 0 Then oeTrabajador = _leAux(0)
                        End If
                        With oeResumenAsis
                            .Id = String.Empty
                            .IdTrabajador = oeTrabajador.Id
                            .Trabajador = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                            .Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            'Select Case objWorkSheet.Cells(ln_Fila + 1, 3).Value
                            '    Case "D" : .IndTipo = 1
                            '    Case "F" : .IndTipo = 0
                            '    Case "V" : .IndTipo = 2
                            '    Case "C" : .IndTipo = 3
                            '    Case "E" : .IndTipo = 4
                            '    Case "X" : .IndTipo = 5
                            '    Case "N" : .IndTipo = 6
                            'End Select
                            Select Case objWorkSheet.Cells(ln_Fila + 1, 3).Value
                                Case "D"
                                    .IndTipo = 1
                                    .CodigoSuspension = "20"
                                Case "F1"
                                    .IndTipo = 0
                                    .CodigoSuspension = "01"
                                Case "F5"
                                    .IndTipo = 0
                                    .CodigoSuspension = "05"
                                Case "F7"
                                    .IndTipo = 0
                                    .CodigoSuspension = "07"
                                Case "V"
                                    .IndTipo = 2
                                    .CodigoSuspension = "23"
                                Case "C" : .IndTipo = 3
                                Case "E" : .IndTipo = 4
                                Case "X" : .IndTipo = 5
                                Case "N" : .IndTipo = 6
                            End Select
                            .Cantidad = objWorkSheet.Cells(ln_Fila + 1, 4).Value
                            .FechaInicio = objWorkSheet.Cells(ln_Fila + 1, 5).Value
                            .FechaTermino = objWorkSheet.Cells(ln_Fila + 1, 6).Value
                            .Observacion = objWorkSheet.Cells(ln_Fila + 1, 7).Value
                            .DiasNetos = objWorkSheet.Cells(ln_Fila + 1, 8).Value
                            .IndTipoAux = 0
                            .IdPlanilla = cboPlanilla.Value
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .GozedeHaber = IIf(.IndTipo > 0, 1, 0)
                            If _leEstAux.Count > 0 Then .IdEstado = _leEstAux(0).Id : .Estado = _leEstAux(0).Nombre
                            .Activo = False
                        End With
                        oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leResAsisAux.Add(oeResumenAsis)
                    Else
                        Exit For
                    End If
                Next
                CargarResAsisImportar(leResAsisAux)
                griImportar.DataBind()

                btnVerificar.Enabled = IIf(leResAsisAux.Count > 0, True, False)
                btnVerificarFaltas.Enabled = False
                btnGrabar.Enabled = False
                btnGrabarFaltas.Enabled = False

                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
            Else
                OpenFileDialog1.Dispose()
            End If
            mensajeEmergente.Confirmacion("Se han Procesado " & leResAsisAux.Count & " registros", True)
        Catch ex As Exception
            etiEjecuta.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta.Visible = False
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            VerificarMovimiento()

            btnGrabar.Enabled = True
            btnVerificar.Enabled = False
            btnVerificarFaltas.Enabled = False
            btnGrabarFaltas.Enabled = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            etiEjecuta.Visible = False : upbLoad.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta.Visible = False : upbLoad.Visible = False
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnVerificarFaltas_Click(sender As Object, e As EventArgs) Handles btnVerificarFaltas.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            VerificarMovimiento()

            btnGrabarFaltas.Enabled = True
            btnGrabar.Enabled = False
            btnVerificar.Enabled = False
            btnVerificarFaltas.Enabled = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            etiEjecuta.Visible = False : upbLoad.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta.Visible = False : upbLoad.Visible = False
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            GrabarMovimiento()

            btnVerificar.Enabled = False
            btnVerificarFaltas.Enabled = False
            btnGrabar.Enabled = False
            btnGrabarFaltas.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnGrabarFaltas_Click(sender As Object, e As EventArgs) Handles btnGrabarFaltas.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            GrabarMovimiento()

            btnVerificar.Enabled = False
            btnVerificarFaltas.Enabled = False
            btnGrabar.Enabled = False
            btnGrabarFaltas.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griConsolidado_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles griConsolidado.DoubleClickCell
        Try
            With griConsolidado
                If .ActiveRow.Index > -1 Then
                    If .ActiveCell.Column.Key = "IndTipoAux" Then
                        oeResumenAsis = New e_ResumenAsistencia
                        oeResumenAsis.Id = .ActiveRow.Cells("Id").Value
                        oeResumenAsis.Equivale = 1
                        If leResumenAsis.Contains(oeResumenAsis) Then
                            oeResumenAsis = leResumenAsis.Item(leResumenAsis.IndexOf(oeResumenAsis))
                            oeResumenAsis.UsuarioModifica = gUsuarioSGI.Id
                            oeResumenAsis.TipoOperacion = "A"
                        End If
                        Select Case .ActiveRow.Cells("IndTipo").Value
                            Case 0 ' Faltas
                                If cboEstadoCon.Text = gNombreEstadoEnviado Or cboEstadoCon.Text = gNombreEstadoTerminada Then
                                    If .ActiveRow.Cells("IndTipoAux").Value = False Then
                                        If MessageBox.Show("¿Desea Generar Falta para Gratificacion al Trabajador: " & _
                                                          .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                            oeResumenAsis.IndTipoAux = 1
                                            oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            If olResumenAsis.Guardar(oeResumenAsis) Then
                                                mensajeEmergente.Confirmacion("El dato se ha actulizado correctamente", True)
                                                Consultar(True)
                                            End If
                                        End If
                                    Else
                                        If MessageBox.Show("¿Desea quitar Falta para Gratificacion al Trabajador: " & _
                                                         .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                            oeResumenAsis.IndTipoAux = 0
                                            oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            If olResumenAsis.Guardar(oeResumenAsis) Then
                                                mensajeEmergente.Confirmacion("El dato se ha actulizado correctamente", True)
                                                Consultar(True)
                                            End If
                                        End If
                                    End If
                                End If
                            Case 1 ' Descansos
                                If cboEstadoCon.Text = gNombreEstadoGenerada Then
                                    If .ActiveRow.Cells("IndTipoAux").Value = False Then
                                        If MessageBox.Show("¿Desea Generar Subsidio al Trabajador: " & _
                                                          .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                            oeResumenAsis.IndTipoAux = 1
                                            oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            If olResumenAsis.Guardar(oeResumenAsis) Then
                                                mensajeEmergente.Confirmacion("El dato se ha actulizado correctamente", True)
                                                Consultar(True)
                                            End If
                                        End If
                                    Else
                                        If MessageBox.Show("¿Desea quitar Subsidio al Trabajador: " & _
                                                         .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                            oeResumenAsis.IndTipoAux = 0
                                            oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            If olResumenAsis.Guardar(oeResumenAsis) Then
                                                mensajeEmergente.Confirmacion("El dato se ha actulizado correctamente", True)
                                                Consultar(True)
                                            End If
                                        End If
                                    End If
                                End If
                            Case 2 ' Vacaciones
                                If cboEstadoCon.Text = gNombreEstadoGenerada Then
                                    If .ActiveRow.Cells("IndTipoAux").Value = False Then
                                        If MessageBox.Show("¿Desea Generar Compra de Vacaciones al Trabajador: " & _
                                                          .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                            oeResumenAsis.IndTipoAux = 1
                                            oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            If olResumenAsis.Guardar(oeResumenAsis) Then
                                                mensajeEmergente.Confirmacion("El dato se ha actulizado correctamente", True)
                                                Consultar(True)
                                            End If
                                        End If
                                    Else
                                        If MessageBox.Show("¿Desea quitar Compra de Vacaciones al Trabajador: " & _
                                                         .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                            oeResumenAsis.IndTipoAux = 0
                                            oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            If olResumenAsis.Guardar(oeResumenAsis) Then
                                                mensajeEmergente.Confirmacion("El dato se ha actulizado correctamente", True)
                                                Consultar(True)
                                            End If
                                        End If
                                    End If
                                End If
                        End Select
                        Return
                    End If
                    If .ActiveCell.Column.Key = "GozedeHaber" Then
                        oeResumenAsis = New e_ResumenAsistencia
                        oeResumenAsis.Id = .ActiveRow.Cells("Id").Value
                        oeResumenAsis.Equivale = 1
                        If leResumenAsis.Contains(oeResumenAsis) Then
                            oeResumenAsis = leResumenAsis.Item(leResumenAsis.IndexOf(oeResumenAsis))
                            oeResumenAsis.UsuarioModifica = gUsuarioSGI.Id
                            oeResumenAsis.TipoOperacion = "A"
                        End If
                        Select Case .ActiveRow.Cells("IndTipo").Value
                            Case 0, 1
                                If cboEstadoCon.Text = gNombreEstadoEnviado Or cboEstadoCon.Text = gNombreEstadoTerminada Then
                                    If .ActiveRow.Cells("GozedeHaber").Value = False Then
                                        oeResumenAsis.GozedeHaber = 1
                                        oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
                                        If olResumenAsis.Guardar(oeResumenAsis) Then
                                            mensajeEmergente.Confirmacion("El dato se ha actualizado correctamente", True)
                                            Consultar(True)
                                        End If

                                    Else
                                        oeResumenAsis.GozedeHaber = 0
                                        oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
                                        If olResumenAsis.Guardar(oeResumenAsis) Then
                                            mensajeEmergente.Confirmacion("El dato se ha actualizado correctamente", True)
                                            Consultar(True)
                                        End If
                                    End If
                                End If
                        End Select
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles verFiltro.CheckedChanged
        cboBuscaEstado.ReadOnly = Not verFiltro.Checked
        cboBuscaEstado.SelectedIndex = IIf(verFiltro.Checked, 1, -1)
    End Sub


#End Region

#Region "Metodos"

    Private Sub VerificarMovimiento()
        Try
            Dim nroreg As Integer = 0, nrotrab As Integer = 0
            Dim ls_msg As String = String.Empty
            If leResAsisAux.Count > 0 Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty : upbLoad.Visible = True
                upbLoad.Visible = True : upbLoad.Minimum = 0 : upbLoad.Maximum = 100
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                For Each oeAux In leResAsisAux
                    nroreg = nroreg + 1
                    etiEjecuta.Text = "Validando Registro " & nroreg & " de " & leResAsisAux.Count
                    upbLoad.Value = Math.Round(nroreg / leResAsisAux.Count, 2) * 100
                    ' Verifica si los Trabajadores entan registradas en el SGI
                    If oeAux.IdTrabajador = "" Then
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2
                        oeTrabajador.oePersona.Dni = oeAux.Dni
                        If leTrabActivo.Contains(oeTrabajador) Then
                            Dim _leAux = leTrabActivo.Where(Function(it) it.oePersona.Dni = oeTrabajador.oePersona.Dni).ToList
                            If _leAux.Count > 0 Then
                                oeTrabajador = _leAux(0)
                                oeAux.IdTrabajador = oeTrabajador.Id
                                oeAux.Activo = True
                            End If
                        End If
                    Else
                        oeAux.Activo = True
                    End If
                    If oeAux.IdTrabajador.Trim = String.Empty Then nrotrab = nrotrab + 1
                Next
                CargarResAsisImportar(leResAsisAux) : griImportar.DataBind()
                For Each fil In griImportar.Rows
                    If fil.Cells("IdTrabajador").Value = "" Then fil.Cells("Trabajador").Appearance.BackColor = Color.LightCoral
                Next
            Else
                Throw New Exception("No hay Datos para validar")
            End If
            If nrotrab > 0 Then ls_msg = " * " & nrotrab & " Trabajadores no registrados."
            If ls_msg.Trim.Length > 0 Then
                ls_msg = "Se necesita solucionar lo siguente: " & Environment.NewLine & ls_msg
            Else
                ls_msg = "Todos los Datos estan Listos para Importar"
            End If
            mensajeEmergente.Confirmacion("Se Validaron " & leResAsisAux.Count & " Registros" & Environment.NewLine & ls_msg, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GrabarMovimiento()
        Try
            Dim _leGrabar = leResAsisAux.Where(Function(it) it.Activo = True).ToList
            If _leGrabar.Count > 0 Then

                Validar(cboPlanilla.Value)

                olResumenAsis.GuardarMasivo(_leGrabar, gs_PrefijoIdSucursal)
                mensajeEmergente.Confirmacion("Los Datos se han importado correctamente!!", True)
                ficDetalle.Tabs(0).Enabled = True
                ficDetalle.Tabs(1).Enabled = False
                ficDetalle.Tabs(0).Selected = True
                Consultar(_Activo)
            Else
                Throw New Exception("No hay Datos para Guargar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Validar(IdPlanilla As String)
        oeResumenAsis = New e_ResumenAsistencia
        oeResumenAsis.TipoOperacion = ""
        oeResumenAsis.Activo = True
        oeResumenAsis.IdPlanilla = IdPlanilla
        oeResumenAsis.IndTipo = -1
        oeResumenAsis.GozedeHaber = -1
        leResumenAsis = olResumenAsis.Listar(oeResumenAsis)
        If leResumenAsis.Count > 0 Then
            If gNombreEstadoGenerada <> leResumenAsis(0).Estado Then
                Throw New Exception("Estado actual debe estar en " + gNombreEstadoGenerada)
            End If
        End If
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeMovimientoPersonal = New e_MovimientoPersonal
            Tiempo1.Enabled = True
            'With griListaMovimientosPersonal
            '    oeMovimientoPersonal.Activo = Activo


            '    .DataSource = olMovimientoPersonal.Listar(oeMovimientoPersonal)
            '    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            '    .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
            '    .DisplayLayout.Bands(0).Columns("IdSituacionAdministrativa").Hidden = True
            '    .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
            '    .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
            '    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            '    .DisplayLayout.Bands(0).Columns("FechaRetorno").Hidden = True
            'End With



            'Ubica el cursor el el primer registro de la grilla
            'If griListaMovimientosPersonal.Rows.Count > 0 Then
            '    griListaMovimientosPersonal.Focus()
            '    griListaMovimientosPersonal.Rows.Item(0).Selected = True
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        'griListaMovimientosPersonal.Focus()
    End Sub

    Private Sub Inicializar()


        cboTrabajadores.ReadOnly = False
        cboTrabajadores.Value = Nothing

        cboPlanillaEdicion.Value = Nothing
        cboEstadoEdicion.Value = Nothing
        cboTipo.Value = Nothing
        chkGoze.Checked = False
        chkIndicadorAux.Checked = False
        txtObservacion.Text = String.Empty
        fecFechaInicio.Value = Date.Now
        txtCodigoPlame.Text = String.Empty
        nroDias.Value = 1
        fecFechaFin.Value = fecFechaInicio.DateTime.AddDays(nroDias.Value - 1)

        FotoTrabajador.Image = Nothing
        agrDatosBasicos.Visible = False

        Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoGenerada).ToList
        If _leEstAux.Count > 0 Then cboEstadoEdicion.Value = _leEstAux(0).Id

    End Sub
    Private Sub InicializarEdicion()
        cboTrabajadores.ReadOnly = False
        cboTrabajadores.Value = Nothing

        cboPlanillaEdicion.Value = Nothing
        cboEstadoEdicion.Value = Nothing
        cboTipo.Value = Nothing
        chkGoze.Checked = False
        chkIndicadorAux.Checked = False
        txtObservacion.Text = String.Empty
        fecFechaInicio.Value = Date.Now
        txtCodigoPlame.Text = String.Empty
        nroDias.Value = 1
        fecFechaFin.Value = fecFechaInicio.DateTime.AddDays(nroDias.Value - 1)

        FotoTrabajador.Image = Nothing
        agrDatosBasicos.Visible = False

        Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoGenerada).ToList
        If _leEstAux.Count > 0 Then cboEstadoEdicion.Value = _leEstAux(0).Id

    End Sub

    Private Sub Mostrar()
        Try
            cboTrabajadores.Value = oeResumenAsis.IdTrabajador
            cboPlanillaEdicion.Value = oeResumenAsis.IdPlanilla
            cboTipo.Value = oeResumenAsis.IndTipo
            nroDias.Value = oeResumenAsis.Cantidad
            fecFechaInicio.Value = oeResumenAsis.FechaInicio
            fecFechaFin.Value = oeResumenAsis.FechaTermino
            txtObservacion.Value = oeResumenAsis.Observacion
            chkIndicadorAux.Checked = oeResumenAsis.IndTipoAux
            chkGoze.Checked = oeResumenAsis.GozedeHaber
            txtCodigoPlame.Text = oeResumenAsis.CodigoSuspension
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            Validar(cboPlanillaEdicion.Value)
            LlenarObjeto()
            oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olResumenAsis.Guardar(oeResumenAsis) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                'MostrarTabs(0, ficMovimientoPersonal, 2)
                SeleccionarTab(0)
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                Consultar(_Activo)
                'griListaMovimientosPersonal.Focus()
                Return True
            Else
                Return False
            End If

            'oeMovimientoPersonal.UsuarioCreacion = gUsuarioSGI.Id.ToString

            'If olMovimientoPersonal.Guardar(oeMovimientoPersonal) Then
            '    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            '    'MostrarTabs(0, ficMovimientoPersonal, 2)
            '    SeleccionarTab(0)
            '    Consultar(_Activo)
            '    'griListaMovimientosPersonal.Focus()
            '    Return True
            'Else
            '    Return False
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("FechaInicio") Then
            fecFechaInicio.Focus()
        End If
        If excepcion.Contains("FechaFin") Then
            fecFechaFin.Focus()
        End If
    End Sub

    Private Sub SeleccionarTab(_index)
        ficMovimientoPersonal.Tabs(0).Enabled = False
        ficMovimientoPersonal.Tabs(1).Enabled = False
        ficMovimientoPersonal.Tabs(2).Enabled = False
        ficMovimientoPersonal.Tabs(_index).Enabled = True
        ficMovimientoPersonal.Tabs(_index).Selected = True
        If _index = 0 Then ficMovimientoPersonal.Tabs(2).Enabled = True
    End Sub

    Private Sub ListarResumenAsistencia()
        Try
            If cboPlanilla.SelectedIndex > -1 Then
                oeResumenAsis = New e_ResumenAsistencia
                oeResumenAsis.TipoOperacion = ""
                oeResumenAsis.Activo = True
                oeResumenAsis.IdPlanilla = cboPlanilla.Value
                oeResumenAsis.IndTipo = -1
                oeResumenAsis.GozedeHaber = -1
                leResumenAsis = olResumenAsis.Listar(oeResumenAsis)
                CargarResumenAsistencia(leResumenAsis)
                btnEnviar.Enabled = False : btnExtornar.Enabled = False
                If leResumenAsis.Count = 0 Then
                    cboEstadoCon.SelectedIndex = -1
                    'ficDetalle.Tabs(1).Enabled = True
                    MessageBox.Show("No se Encontraron Registros.", "Mensaje de Sistema", _
                                       MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'If MessageBox.Show("No se Encontraron Registros. ¿Desea Importar Datos?", "Mensaje de Sistema", _
                    '                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'ficDetalle.Tabs(1).Selected = True
                    'leResAsisAux = New List(Of e_ResumenAsistencia)
                    'CargarResAsisImportar(leResAsisAux)
                    'End If
                Else
                    cboEstadoCon.Value = leResumenAsis(0).IdEstado
                    ficDetalle.Tabs(1).Enabled = False
                    If oeResumenAsis.IdPlanilla.Trim <> String.Empty Then
                        If leResumenAsis.Count > 0 AndAlso leResumenAsis(0).Estado = gNombreEstadoGenerada Then
                            btnEnviar.Enabled = True : btnExtornar.Enabled = False : btnEliminar.Enabled = True
                        End If
                        If leResumenAsis.Count > 0 AndAlso leResumenAsis(0).Estado = gNombreEstadoEnviado Then
                            btnEnviar.Enabled = False : btnExtornar.Enabled = True : btnEliminar.Enabled = False
                        End If
                    End If
                End If
            Else
                Throw New Exception("Seleccione una Planilla para Consultar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarResumenAsistencia(leResAsis As List(Of e_ResumenAsistencia))
        Try
            With griConsolidado
                If _bandload Then .ResetDisplayLayout()
                .Text = "Registros Consolidado de Asistencia (" & leResAsis.Count & ")"
                .DataSource = leResAsis
            End With
            If _bandload Then ConfiguraGriConsolidado(griConsolidado, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarResAsisImportar(leRAImportar As List(Of e_ResumenAsistencia))
        Try
            With griImportar
                .ResetDisplayLayout()
                .Text = "Registros a Importar (" & leRAImportar.Count & ")"
                .DataSource = leRAImportar
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
            End With
            ConfiguraGriConsolidado(griImportar, 2)
            'btnVerificar.Enabled = IIf(leRAImportar.Count > 0, True, False)
            ''btnFaltaIngresoCese.Enabled = IIf(leRAImportar.Count > 0, True, False)
            'Dim _leAux = leRAImportar.Where(Function(it) it.Activo = True).ToList
            'btnGrabar.Enabled = IIf(_leAux.Count > 0, True, False)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGriConsolidado(grilla As UltraGrid, Tipo As Integer)
        Try
            With grilla
                OcultarColumna(grilla, True, "Id", "IdPlanilla", "IdTrabajador", "IndTipo", "FechaCreacion", "UsuarioCreacion", "FechaModifica", _
                               "UsuarioModifica", "DiasNetos", "IdEstado")
                If Tipo <> 2 Then .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 350
                If Tipo = 2 Then .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                .DisplayLayout.Bands(0).Columns("IndTipoAux").Header.Caption = "Auxiliar"
                .DisplayLayout.Bands(0).Columns("Tipo").Width = 150
                .DisplayLayout.Bands(0).Columns("GozedeHaber").Style = ColumnStyle.CheckBox
                .DisplayLayout.Bands(0).Columns("IndTipoAux").Style = ColumnStyle.CheckBox
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.CellSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarRecordVacaciones()
        Try
            'obtener trabajadores
            Dim oeTrabajadorVac As New e_Trabajador
            Dim leTrabajadorVac As New List(Of e_Trabajador)
            oeTrabajadorVac.TipoOperacion = "N"
            leTrabajadorVac = olTrabajador.Listar(oeTrabajadorVac)

            'obtener ResumenAsistencia
            Dim oeResumenAsisVac As New e_ResumenAsistencia
            Dim leResumenAsisVac As New List(Of e_ResumenAsistencia)
            oeResumenAsisVac.TipoOperacion = ""
            oeResumenAsisVac.Activo = True
            'oeResumenAsisVac.IdPlanilla = cboPlanilla.Value
            oeResumenAsisVac.IndTipo = -1
            oeResumenAsis.GozedeHaber = -1
            leResumenAsisVac = olResumenAsis.Listar(oeResumenAsisVac)

            Dim drVacaciones As DataRow
            Dim dtVacaciones As DataTable
            dtVacaciones = CrearDTRecordVacaciones()
            Dim drVacaciones2 As DataRow
            Dim dtVacaciones2 As DataTable
            dtVacaciones2 = CrearDTVacaciones()
            Dim TotalVacaciones As Integer = 0
            Dim VacacionesGozadas As Integer = 0
            Dim VacacionesTruncas As Integer = 0
            For Each item In leTrabajadorVac

                If verFiltro.Checked Then
                    If cboBuscaEstado.Value = 0 And item.IndEstado <> 0 Then Continue For
                    If cboBuscaEstado.Value = 1 And item.IndEstado <> 1 Then Continue For
                    If cboBuscaEstado.Value = 2 And item.IndEstado <> 2 Then Continue For
                    If cboBuscaEstado.Value = 3 And item.IndEstado <> 3 Then Continue For
                End If

                For Each item2 In leResumenAsisVac
                    If item2.IdTrabajador = item.Id And item2.IndTipo = 2 And item2.FechaInicio >= item.FechaIngreso Then
                        drVacaciones2 = dtVacaciones2.NewRow
                        drVacaciones2("IdTrabajador") = item.Id
                        drVacaciones2("DNI") = item.oePersona.Dni
                        drVacaciones2("NombreCompleto") = item.oePersona.NombreCompleto
                        drVacaciones2("Cantidad") = item2.Cantidad
                        drVacaciones2("FechaInicio") = item2.FechaInicio.ToShortDateString
                        drVacaciones2("FechaFin") = item2.FechaTermino.ToShortDateString
                        drVacaciones2("Glosa") = item2.Observacion
                        dtVacaciones2.Rows.Add(drVacaciones2)
                    End If
                Next
                Dim query = leResumenAsisVac.Where(Function(x) x.IdTrabajador = item.Id And x.IndTipo = 2 And x.FechaInicio >= item.FechaIngreso)
                drVacaciones = dtVacaciones.NewRow
                drVacaciones("IdTrabajador") = item.Id
                drVacaciones("DNI") = item.oePersona.Dni
                drVacaciones("NombreCompleto") = item.oePersona.NombreCompleto
                drVacaciones("FechaIngreso") = item.FechaIngreso.Date.ToShortDateString
                drVacaciones("FechaCese") = item.FechaCese.Date.ToShortDateString
                drVacaciones("IndEstado") = item.IndEstado
                ''calcular total de vacaciones
                If item.IndEstado = 1 Then
                    TotalVacaciones = Math.Truncate(DateDiff(DateInterval.Day, item.FechaIngreso, Now.Date) / 365) * 30
                    VacacionesTruncas = Math.Truncate((DateDiff(DateInterval.Day, item.FechaIngreso, Now.Date) Mod 365) * 30 / 365)
                ElseIf item.FechaCese.Date <> "01/01/1901" Then
                    TotalVacaciones = Math.Truncate(DateDiff(DateInterval.Day, item.FechaIngreso, item.FechaCese) / 365) * 30
                    VacacionesTruncas = Math.Truncate((DateDiff(DateInterval.Day, item.FechaIngreso, item.FechaCese) Mod 365) * 30 / 365)
                Else
                    TotalVacaciones = Math.Truncate(DateDiff(DateInterval.Day, item.FechaIngreso, Now.Date) / 365) * 30
                    VacacionesTruncas = Math.Truncate((DateDiff(DateInterval.Day, item.FechaIngreso, Now.Date) Mod 365) * 30 / 365)
                End If
                drVacaciones("TotalVacaciones") = TotalVacaciones
                ''vacaciones gozadas
                VacacionesGozadas = query.Sum(Function(x) x.Cantidad)
                drVacaciones("VacacionesGozadas") = VacacionesGozadas
                drVacaciones("VacacionesPendientes") = TotalVacaciones - VacacionesGozadas
                drVacaciones("VacacionesTruncas") = VacacionesTruncas

                dtVacaciones.Rows.Add(drVacaciones)
            Next
            Dim ds As New DataSet
            ds.Tables.Add(dtVacaciones)
            ds.Tables.Add(dtVacaciones2)
            Dim PadreCol As DataColumn = ds.Tables(0).Columns("IdTrabajador")
            Dim HijoCol As DataColumn = ds.Tables(1).Columns("IdTrabajador")
            Dim Relacion As DataRelation = New DataRelation("Grupo_Detalle", PadreCol, HijoCol, True)
            ds.Relations.Add(Relacion)
            ds.AcceptChanges()

            gridRecordVacaciones.DataSource = ds
            gridRecordVacaciones.DataBind()

            For Each fila As UltraGridRow In gridRecordVacaciones.Rows
                Select Case fila.Cells("IndEstado").Value
                    Case 0 : fila.CellAppearance.BackColor = colorBaja.Color
                    Case 1 : fila.CellAppearance.BackColor = colorActivo.Color
                    Case 2 : fila.CellAppearance.BackColor = colorPorLiquidar.Color
                End Select
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarObjeto()
        Try
            'oeResumenAsis = New e_ResumenAsistencia
            IIf(oeResumenAsis.Id.Trim.Length = 0, oeResumenAsis.TipoOperacion = "I", oeResumenAsis.TipoOperacion = "A")
            If oeResumenAsis.Id.Trim.Length > 0 Then
                oeResumenAsis.TipoOperacion = "A"
            Else
                oeResumenAsis.TipoOperacion = "I"
            End If
            oeResumenAsis.Activo = True
            oeResumenAsis.IdTrabajador = cboTrabajadores.Value
            oeResumenAsis.IdPlanilla = cboPlanillaEdicion.Value
            oeResumenAsis.IdEstado = cboEstadoEdicion.Value

            oeSituacionAdministrativa = ListaoeSituacionAdministrativa.Where(Function(x) x.Id = cboTipo.Value).First

            oeResumenAsis.IndTipo = oeSituacionAdministrativa.IndTipo
            oeResumenAsis.CodigoSuspension = txtCodigoPlame.Text.Trim
            oeResumenAsis.Cantidad = nroDias.Value
            oeResumenAsis.FechaInicio = fecFechaInicio.Value
            oeResumenAsis.FechaTermino = fecFechaFin.Value
            oeResumenAsis.Observacion = txtObservacion.Value
            oeResumenAsis.DiasNetos = 0
            oeResumenAsis.IndTipoAux = IIf(chkIndicadorAux.Checked, 1, 0)
            oeResumenAsis.UsuarioCreacion = gUsuarioSGI.Id
            oeResumenAsis.UsuarioModifica = gUsuarioSGI.Id
            oeResumenAsis.FechaCreacion = Date.Now
            oeResumenAsis.FechaModifica = Date.Now
            oeResumenAsis.GozedeHaber = IIf(chkGoze.Checked, 1, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_MovimientoPersonal_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    

    

#End Region

#Region "Menú contextual del maestro de MovimientoPersonals"

    

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    

    

    Private Sub tsmiConsolidar_Click(sender As Object, e As EventArgs) Handles tsmiConsolidar.Click
        Try
            SeleccionarTab(2)
            ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = "A"
            oePlanilla.Activo = True
            oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla).OrderByDescending(Function(it) it.Codigo).ToList
            LlenarCombo(cboPlanilla, "Codigo", lePlanilla, -1)
            fecInicioPla.Value = Date.Now.Date
            fecFinPla.Value = Date.Now.Date
            ficDetalle.Tabs(0).Enabled = True
            ficDetalle.Tabs(1).Enabled = False
            ficDetalle.Tabs(0).Selected = True
            leResumenAsis = New List(Of e_ResumenAsistencia)
            CargarResumenAsistencia(leResumenAsis)
            leResAsisAux = New List(Of e_ResumenAsistencia)
            CargarResAsisImportar(leResAsisAux)
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            leTrabActivo = leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 1).ToList
            btnVerificar.Enabled = False : btnGrabar.Enabled = False
            'btnFaltaIngresoCese.Enabled = False
            btnGrabar.Enabled = False
            btnEnviar.Enabled = False : btnExtornar.Enabled = False : btnEliminar.Enabled = False
            cboEstadoCon.SelectedIndex = -1
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
    '    MenuContextual1.Items(0).Visible = True
    '    MenuContextual1.Items(5).Visible = True
    '    'If griListaMovimientosPersonal.Selected.Rows.Count > 0 Then
    '    '    MenuContextual1.Items(1).Visible = True
    '    '    MenuContextual1.Items(2).Visible = True
    '    '    MenuContextual1.Items(3).Visible = True
    '    '    MenuContextual1.Items(4).Visible = True
    '    'Else
    '    '    MenuContextual1.Items(1).Visible = False
    '    '    MenuContextual1.Items(2).Visible = False
    '    '    MenuContextual1.Items(3).Visible = False
    '    '    MenuContextual1.Items(4).Visible = False
    '    'End If
    'End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If Not ficDetalle.Tabs(0).Selected Then Throw New Exception("Debe ubicarse en la ficha listado.")
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If leResumenAsis.Count > 0 Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoEnviado).ToList
                        For Each oeRA In leResumenAsis
                            oeRA.PrefijoID = gs_PrefijoIdSucursal '@0001
                            oeRA.TipoOperacion = "A" : oeRA.UsuarioModifica = gUsuarioSGI.Id
                            If _leEstAux.Count > 0 Then oeRA.IdEstado = _leEstAux(0).Id
                        Next
                        If olResumenAsis.GuardarLista(leResumenAsis) Then
                            mensajeEmergente.Confirmacion("Se la Asistencia se Envio correctamente", True)
                            btnEnviar.Enabled = False
                            Consultar(True)
                        End If
                    End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnExtornar_Click(sender As Object, e As EventArgs) Handles btnExtornar.Click
        Try
            If Not ficDetalle.Tabs(0).Selected Then Throw New Exception("Debe ubicarse en la ficha listado.")
            _acl = gAccionSistema.EXTORNAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If leResumenAsis.Count > 0 Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoGenerada).ToList
                        For Each oePEPS In leResumenAsis
                            oePEPS.PrefijoID = gs_PrefijoIdSucursal '@0001
                            oePEPS.TipoOperacion = "A" : oePEPS.UsuarioModifica = gUsuarioSGI.Id
                            If _leEstAux.Count > 0 Then oePEPS.IdEstado = _leEstAux(0).Id
                        Next
                        If olResumenAsis.GuardarLista(leResumenAsis) Then
                            mensajeEmergente.Confirmacion("Se la Asistencia se Extorno correctamente", True)
                            btnExtornar.Enabled = False
                            Consultar(True)
                        End If
                    End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not ficDetalle.Tabs(0).Selected Then Throw New Exception("Debe ubicarse en la ficha listado.")
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If leResumenAsis.Count > 0 Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        For Each oePEPS In leResumenAsis
                            oePEPS.TipoOperacion = "E" : oePEPS.UsuarioModifica = gUsuarioSGI.Id
                        Next
                        If olResumenAsis.EliminarLista(leResumenAsis) Then
                            mensajeEmergente.Confirmacion("Se la Asistencia se Envio correctamente", True)
                            btnEnviar.Enabled = False
                            Consultar(True)
                        End If
                    End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Actualización de fechas"

    Private Sub fecFechaInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaInicio.ValueChanged
        oeMovimientoPersonal.FechaInicio = fecFechaInicio.Value
        ActualizaFechaFin()
    End Sub

    Private Sub nroDias_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nroDias.ValueChanged
        oeMovimientoPersonal.NroDias = nroDias.Value
        ActualizaFechaFin()
    End Sub

    Private Sub ActualizaFechaFin()
        oeMovimientoPersonal.FechaFin = oeMovimientoPersonal.FechaInicio.Date.AddDays(oeMovimientoPersonal.NroDias - 1)
        fecFechaFin.Value = oeMovimientoPersonal.FechaFin
        etiDiaInicial.Text = oeMovimientoPersonal.FechaInicio.Date.ToLongDateString
        etiDiaFinal.Text = oeMovimientoPersonal.FechaFin.Date.ToLongDateString
        oeMovimientoPersonal.FechaRetorno = oeMovimientoPersonal.FechaFin

    End Sub

#End Region

    Private Sub btnFaltaIngresoCese_Click(sender As Object, e As EventArgs) Handles btnFaltaIngresoCese.Click
        Try
            'periodo
            Dim oePeriodoAux As New e_Periodo
            Dim olPeriodoAux As New l_Periodo
            oePeriodoAux.Id = oePlanilla.IdPeriodo
            oePeriodoAux = olPeriodoAux.Obtener(oePeriodoAux)
            'trabajadores
            Dim listaTrabajador As New List(Of e_Trabajador)
            Dim oeTrabajadorAux As New e_Trabajador
            oeTrabajadorAux.TipoOperacion = "N"
            listaTrabajador = olTrabajador.Listar(oeTrabajadorAux)

            'estados
            Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoGenerada).ToList

            leResAsisAux.Clear()

            Dim diasFaltas As Integer = 0
            For Each item In listaTrabajador
                If item.FechaIngreso >= oePeriodoAux.FechaInicio And item.FechaIngreso <= oePeriodoAux.FechaFin Then
                    diasFaltas = DateDiff(DateInterval.Day, oePeriodoAux.FechaInicio, item.FechaIngreso)
                    If diasFaltas > 0 Then
                        oeResumenAsis = New e_ResumenAsistencia
                        With oeResumenAsis
                            .Id = String.Empty
                            .IdTrabajador = item.Id
                            .Trabajador = item.oePersona.NombreCompleto
                            .Dni = item.oePersona.Dni
                            .IndTipo = 0
                            .CodigoSuspension = ""
                            .Cantidad = diasFaltas
                            .FechaInicio = oePeriodoAux.FechaInicio
                            .FechaTermino = item.FechaIngreso.AddDays(-1)
                            .Observacion = "FALTAS POR INGRESO"
                            .DiasNetos = 0
                            .IndTipoAux = 0
                            .IdPlanilla = cboPlanilla.Value
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .GozedeHaber = 0
                            If _leEstAux.Count > 0 Then .IdEstado = _leEstAux(0).Id : .Estado = _leEstAux(0).Nombre
                            .Activo = False
                        End With
                        oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leResAsisAux.Add(oeResumenAsis)
                    End If
                End If

                If item.FechaCese >= oePeriodoAux.FechaInicio And item.FechaCese <= oePeriodoAux.FechaFin Then
                    diasFaltas = DateDiff(DateInterval.Day, item.FechaCese, oePeriodoAux.FechaFin)
                    If diasFaltas > 0 Then
                        oeResumenAsis = New e_ResumenAsistencia
                        With oeResumenAsis
                            .Id = String.Empty
                            .IdTrabajador = item.Id
                            .Trabajador = item.oePersona.NombreCompleto
                            .Dni = item.oePersona.Dni
                            .IndTipo = 0
                            .CodigoSuspension = ""
                            .Cantidad = diasFaltas
                            .FechaInicio = item.FechaCese.AddDays(1)
                            .FechaTermino = oePeriodoAux.FechaFin
                            .Observacion = "FALTAS POR CESE"
                            .DiasNetos = 0
                            .IndTipoAux = 0
                            .IdPlanilla = cboPlanilla.Value
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .GozedeHaber = 0
                            If _leEstAux.Count > 0 Then .IdEstado = _leEstAux(0).Id : .Estado = _leEstAux(0).Nombre
                            .Activo = False
                        End With
                        oeResumenAsis.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leResAsisAux.Add(oeResumenAsis)
                    End If
                End If
            Next
            CargarResAsisImportar(leResAsisAux)
            griImportar.DataBind()
            'btnFaltaIngresoCese.Enabled = False

            btnVerificarFaltas.Enabled = IIf(leResAsisAux.Count > 0, True, False)
            btnVerificar.Enabled = False
            btnGrabar.Enabled = False
            btnGrabarFaltas.Enabled = False
            'btnFaltaIngresoCese.Enabled = IIf(leRAImportar.Count > 0, True, False)
            Dim _leAux = leResAsisAux.Where(Function(it) it.Activo = True).ToList
            btnGrabar.Enabled = IIf(_leAux.Count > 0, True, False)
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            leTrabActivo = leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 1).ToList
            ficDetalle.Tabs(1).Enabled = True
            ficDetalle.Tabs(1).Selected = True
            leResAsisAux = New List(Of e_ResumenAsistencia)
            CargarResAsisImportar(leResAsisAux)
            btnGrabar.Enabled = False
            btnVerificar.Enabled = False
            btnVerificarFaltas.Enabled = False
            btnGrabarFaltas.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If griConsolidado.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro.")
                If griConsolidado.ActiveRow.Cells("Estado").Value.ToString.Trim <> gNombreEstadoGenerada Then Throw New Exception("Registros debe estar en Generada.")


                oeResumenAsis = New e_ResumenAsistencia
                oeResumenAsis.TipoOperacion = ""
                oeResumenAsis.Activo = True
                oeResumenAsis.IdPlanilla = cboPlanilla.Value
                oeResumenAsis.IndTipo = -1
                oeResumenAsis.GozedeHaber = -1
                oeResumenAsis.Id = griConsolidado.ActiveRow.Cells("Id").Value
                oeResumenAsis = olResumenAsis.Obtener(oeResumenAsis)
                oeResumenAsis.UsuarioCreacion = gUsuarioSGI.Id
                oeResumenAsis.UsuarioModifica = gUsuarioSGI.Id

                If oeResumenAsis.Estado.Trim <> gNombreEstadoGenerada Then Throw New Exception("Registros debe estar en Generada.")

                If olResumenAsis.Eliminar(oeResumenAsis) Then
                    mensajeEmergente.Confirmacion("Eliminado correctamente.", True)
                    Consultar(_Activo)
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        
    End Sub


    'Private Sub ficMovimientoPersonal_ActiveTabChanged(sender As Object, e As UltraWinTabControl.ActiveTabChangedEventArgs) Handles ficMovimientoPersonal.ActiveTabChanged
    '    Try
    '        Select Case ficMovimientoPersonal.SelectedTab.Index
    '            Case 0
    '                Select Case ficDetalle.SelectedTab.Index
    '                    Case 0
    '                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
    '                    Case 1
    '                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
    '                End Select
    '            Case 1
    '                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
    '            Case 2
    '                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
    '        End Select
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    Private Sub ficMovimientoPersonal_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficMovimientoPersonal.SelectedTabChanged
        Try
            Select Case ficMovimientoPersonal.SelectedTab.Index
                Case 0
                    Select Case ficDetalle.SelectedTab.Index
                        Case 0
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                        Case 1
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                    End Select
                Case 1
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                Case 2
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
End Class