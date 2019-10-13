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

Public Class frm_ControlPermisos
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_ControlPermisos = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_ControlPermisos()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeCtrlPermisos As New e_ControlPermisos
    Private olCtrlPermisos As New l_ControlPermisos
    Private loCtrlPermisos As New List(Of e_ControlPermisos)

    Private loHistorialPermisos As New List(Of e_ControlPermisos)
    Private loDetalles As New List(Of e_ControlPermisos)

    Private oeTrabajador As New e_Trabajador
    Private olTrabajador As New l_Trabajador

    Private oeOcupacionTrabajador As New e_OcupacionTrabajador
    Private olOcupacionTrabajador As New l_OcupacionTrabajador

    Private olPersona As New l_Persona
    Private olTrajadorabSeg As New l_TrabajadorSeguridad

    Private oeCentro As New e_Centro
    Private olCentro As New l_Centro

    Dim _ingresando_datos As Boolean = False
    Private Const IdSAVacaciones As String = "1PY007"
    Private Const strPermisoCambiarFechas As String = "CAMBIAR FECHAS CONFIRMADAS"
#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            oeCtrlPermisos.Modificado = False
            Operacion = "Nuevo"
            Inicializar()
            oeCtrlPermisos.TipoOperacion = "I"
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            griDetalles.DataBind()
            MostrarTabs(1, ficCtrlPermisos, 1)
            cboTrabajadores.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            Inicializar()
            MostrarPermiso()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Overrides Sub Guardar()
        Try
            If loDetalles.Count > 0 Then 'Guarda Masivo
                If fc_GuardarMasivo() Then
                    MessageBox.Show("Operación realizada con éxito, Registros guardados (" & loDetalles.Count.ToString() & ")", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MostrarTabs(0, ficCtrlPermisos)
                    Consultar(True)
                End If
            Else
                If GuardarPapeleta() Then
                    MensajeConfirmacion()
                    MostrarTabs(0, ficCtrlPermisos)
                    Consultar(True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCtrlPermisos.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarPapeleta() Then
                            MostrarTabs(0, ficCtrlPermisos, 2)
                            _ingresando_datos = False
                            Listar()
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficCtrlPermisos, 1)
                            mt_ControlBotoneria()
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficCtrlPermisos, 2)
                        _ingresando_datos = False
                        mt_ControlBotoneria()
                End Select
            Else
                MostrarTabs(0, ficCtrlPermisos)
                _ingresando_datos = False
                mt_ControlBotoneria()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficCtrlPermisos.SelectedTab.Index = 0 AndAlso griControlPermisos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficCtrlPermisos.SelectedTab.Index = 0 Then Exportar_Excel(griControlPermisos)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Dim id As String = ""
        Try
            Dim formulario As New frm_ReportePapeletaPermisos
            If griControlPermisos.Selected.Rows.Count > 0 And griControlPermisos.ActiveRow.Selected = True And griControlPermisos.ActiveRow.Band.Index = 0 Then
                If ficCtrlPermisos.SelectedTab.Index = 0 Then
                    id = griControlPermisos.ActiveRow.Cells("Id").Value
                    formulario.CargarDatos(id, "1")
                    formulario.ShowDialog()
                    ControlBoton(1, 1, 1, 0, 0, 0, 1, 1, 1)
                Else
                    id = oeCtrlPermisos.Id
                    formulario.CargarDatos(id, "1")
                    formulario.ShowDialog()
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        griControlPermisos.ActiveRow.Delete()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ControlPermisos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ControlPermisos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_ControlPermisos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ControlPermisos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            mt_PersonalizarForm()
            LlenaCombosTrabajadores()
            Me.fecDesde.Value = Date.Now.AddDays(-30)
            MostrarTabs(0, ficCtrlPermisos, 0)
            LlenaComboSituacion()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_PersonalizarForm()
        Try
            ColoresExcedidos.Color = Color.Salmon
            Colores4.Color = Color.Khaki
            Colores3.Color = Color.Gainsboro
            ColorFilaActualizada.Color = Color.PaleTurquoise
            Colores1.Color = Color.LightSteelBlue
            Colores2.Color = Color.LightGreen
            griDetalles.DataSource = loDetalles

            With griDetalles
                For Each col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    With col
                        col.CellActivation = Activation.NoEdit
                        col.CellClickAction = CellClickAction.RowSelect
                    End With
                Next
                .DisplayLayout.UseFixedHeaders = True
                .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                .DisplayLayout.Bands(0).Columns("Fecha").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("IdTrabajador").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("IdSituacionAdministrativa").Header.Fixed = True
            End With
            With griControlPermisos
                For Each col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    With col
                        col.CellActivation = Activation.NoEdit
                        col.CellClickAction = CellClickAction.RowSelect
                    End With
                Next
                .DisplayLayout.Bands(0).Columns("IndConfirmaSalida").CellClickAction = CellClickAction.Edit
                .DisplayLayout.Bands(0).Columns("IndConfirmaSalida").CellActivation = Activation.AllowEdit
                .DisplayLayout.Bands(0).Columns("FechaConfirmaSalida").CellClickAction = CellClickAction.Edit
                .DisplayLayout.Bands(0).Columns("FechaConfirmaSalida").CellActivation = Activation.AllowEdit
                .DisplayLayout.Bands(0).Columns("IndConfirmaIngreso").CellClickAction = CellClickAction.Edit
                .DisplayLayout.Bands(0).Columns("IndConfirmaIngreso").CellActivation = Activation.AllowEdit
                .DisplayLayout.Bands(0).Columns("FechaConfirmaIngreso").CellClickAction = CellClickAction.Edit
                .DisplayLayout.Bands(0).Columns("FechaConfirmaIngreso").CellActivation = Activation.AllowEdit
                .DisplayLayout.UseFixedHeaders = True
                .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                .DisplayLayout.Bands(0).Columns("Fecha").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("Motivo").Header.Fixed = True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboJefeArea_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboJefeArea.ValueChanged
        oeCtrlPermisos.IdJefeArea = cboJefeArea.Value
    End Sub

    Private Sub cboJefeAdministrador_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboJefeAdministrador.ValueChanged
        oeCtrlPermisos.IdJefeAdministracion = cboJefeAdministrador.Value
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeCtrlPermisos.Observacion = txtGlosa.Text
    End Sub

    Private Sub chkConfirmarSalida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConfirmarSalida.CheckedChanged
        oeCtrlPermisos.IndConfirmaSalida = chkConfirmarSalida.Checked
        If chkConfirmarSalida.Checked Then
            fecSalida.Enabled = False
        Else
            fecSalida.Enabled = True
        End If
    End Sub

    Private Sub chkConfirmarIngreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConfirmarIngreso.CheckedChanged
        oeCtrlPermisos.IndConfirmaIngreso = chkConfirmarIngreso.Checked
        If chkConfirmarIngreso.Checked Then
            fecIngreso.Enabled = False
        Else
            fecIngreso.Enabled = True
        End If
    End Sub

    Private Sub griControlPermisos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griControlPermisos.DoubleClick
        Editar()
    End Sub

    Private Sub fecSalidaConfirmada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecSalidaConfirmada.ValueChanged
        If fecSalidaConfirmada.Value.Date < fecSalida.Value.Date Then
            fecSalidaConfirmada.Value = Date.Now
        End If
    End Sub

    Private Sub fecIngresoConfirmado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecIngresoConfirmado.ValueChanged
        If fecIngresoConfirmado.Value < fecIngreso.Value Then
            fecIngresoConfirmado.Value = fecIngreso.Value
        End If
    End Sub

    Private Sub fecIngreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecIngreso.ValueChanged
        If fecIngreso.Value < fecSalida.Value Then
            fecIngreso.Value = fecSalida.Value
        End If
    End Sub

    Private Sub fecSalida_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecSalida.Validated
        Try
            If chkConfirmarSalida.Checked = False Then
                fecSalidaConfirmada.Value = fecSalida.Value
                Dim ln_Diferencia As Integer = 0
                ln_Diferencia = DateTime.Compare(fecSalida.Value.Date, fecIngreso.Value.Date)
                If ln_Diferencia > 0 Then
                    fecIngreso.Value = fecSalida.Value.AddDays(2)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecIngreso_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecIngreso.Validated
        If chkConfirmarIngreso.Checked = False Then
            fecIngresoConfirmado.Value = fecIngreso.Value
        End If
    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub griControlPermisos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griControlPermisos.BeforeRowsDeleted
        Try
            If griControlPermisos.Rows.Count > 1 Then
                e.DisplayPromptMsg = False
                Dim a, b As Boolean
                a = griControlPermisos.ActiveRow.Cells("IndConfirmaSalida").Value
                b = griControlPermisos.ActiveRow.Cells("IndConfirmaIngreso").Value
                If CBool(griControlPermisos.ActiveRow.Cells("IndConfirmaSalida").Value) = True Or CBool(griControlPermisos.ActiveRow.Cells("IndConfirmaIngreso").Value) = True Then
                    e.Cancel = True
                    Throw New Exception("No se puede eliminar este registro ya fue confirmado su salida/ingreso")
                Else
                    If EliminarPermiso() Then
                        e.Cancel = False
                    Else
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboSituacionAdministrativa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSituacionAdministrativa.ValueChanged
        Try
            oeCtrlPermisos.IdSituacionAdministrativa = cboSituacionAdministrativa.Value
            oeCtrlPermisos.Modificado = True
            If cboSituacionAdministrativa.Value = IdSAVacaciones Then
                chbVenta.Visible = True
            Else
                chbVenta.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbVta_CheckedChanged(sender As Object, e As EventArgs) Handles chbVenta.CheckedChanged
        Try
            If chbVenta.Checked Then
                fecInicioVta.Visible = True
                fecFinVta.Visible = True
                Me.Etiqueta17.Visible = True
                Me.Etiqueta18.Visible = True
            Else
                fecInicioVta.Visible = False
                fecFinVta.Visible = False
                Me.Etiqueta17.Visible = False
                Me.Etiqueta18.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


    Private Sub frm_ControlPermisos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case ficCtrlPermisos.SelectedTab.Index
                Case tabMantenimiento.Tab.Index
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                        Case Keys.Insert
                            tsbAgregar.PerformClick()
                        Case Keys.Delete
                            tsbQuitar.PerformClick()
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tspControlPermiso_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspControlPermiso.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregar.Name
                    mt_Agregar()
                Case tsbQuitar.Name
                    mt_Quitar()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griControlPermisos_ClickCellButton(sender As Object, e As CellEventArgs) Handles griControlPermisos.ClickCellButton
        Try
            Select Case e.Cell.Column.Key
                Case "GuardarSalidaConfirmada"
                    With griControlPermisos.Rows(e.Cell.Row.Index)
                        If fc_ValidarGuardarSalida(griControlPermisos.Rows(e.Cell.Row.Index)) Then
                            Dim oe As New e_ControlPermisos
                            oe.TipoOperacion = "2"
                            oe.Id = .Cells("Id").Value
                            oe.IndConfirmaSalida = .Cells("IndConfirmaSalida").Value
                            oe.FechaConfirmaSalida = .Cells("FechaConfirmaSalida").Value
                            oe.IdTrabajador = .Cells("IdTrabajador").Value
                            oe.PrefijoID = gs_PrefijoIdSucursal '@0001
                            If olCtrlPermisos.Guardar(oe) Then
                                MensajeConfirmacion()
                                If oe.IndConfirmaIngreso Then
                                    'Agregar Permiso para Cambiar fechas confirmadas
                                    If Not olTrajadorabSeg.Permisos(gUsuarioSGI.IdTrabajador, strPermisoCambiarFechas) Then
                                        .Cells("IndConfirmaSalida").Activation = Activation.NoEdit
                                        .Cells("FechaConfirmaSalida").Activation = Activation.NoEdit
                                        .Cells("GuardarSalidaConfirmada").Activation = Activation.Disabled
                                    End If
                                End If
                                e.Cell.Row.Appearance.BackColor = ColorFilaActualizada.Color
                            End If
                        End If
                    End With
                Case "GuardarIngresoConfirmado"
                    With griControlPermisos.Rows(e.Cell.Row.Index)
                        If fc_ValidarGuardarIngreso(griControlPermisos.Rows(e.Cell.Row.Index)) Then
                            Dim oe As New e_ControlPermisos
                            oe.TipoOperacion = "1"
                            oe.Id = .Cells("Id").Value
                            oe.IndConfirmaIngreso = .Cells("IndConfirmaIngreso").Value
                            oe.FechaConfirmaIngreso = .Cells("FechaConfirmaIngreso").Value
                            oe.IdTrabajador = .Cells("IdTrabajador").Value
                            oe.PrefijoID = gs_PrefijoIdSucursal '@0001
                            If olCtrlPermisos.Guardar(oe) Then
                                MensajeConfirmacion()
                                If oe.IndConfirmaIngreso Then
                                    'Agregar Permiso para Cambiar fechas confirmadas
                                    If Not olTrajadorabSeg.Permisos(gUsuarioSGI.IdTrabajador, strPermisoCambiarFechas) Then
                                        .Cells("IndConfirmaIngreso").Activation = Activation.NoEdit
                                        .Cells("FechaConfirmaIngreso").Activation = Activation.NoEdit
                                        .Cells("GuardarIngresoConfirmado").Activation = Activation.Disabled
                                    End If
                                End If
                                e.Cell.Row.Appearance.BackColor = ColorFilaActualizada.Color
                            End If
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griControlPermisos_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griControlPermisos.BeforeCellUpdate
        Try
            If griControlPermisos.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "FechaConfirmaIngreso", "FechaConfirmaSalida"
                        If IsDBNull(e.NewValue) OrElse e.NewValue Is Nothing Then
                            e.Cancel = True
                            Exit Sub
                        End If
                        If IsDBNull(e.Cell.Value) Then e.Cell.Value = Date.Parse("01/01/1901")
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griControlPermisos_CellDataError(sender As Object, e As CellDataErrorEventArgs) Handles griControlPermisos.CellDataError
        Try
            e.RaiseErrorEvent = False
            e.RestoreOriginalValue = True
            e.StayInEditMode = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griControlPermisos_CellChange(sender As Object, e As CellEventArgs) Handles griControlPermisos.CellChange
        Try
            If griControlPermisos.ActiveCell.EditorResolved IsNot Nothing AndAlso griControlPermisos.ActiveCell.EditorResolved.IsValid Then
                griControlPermisos.UpdateData()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Combo Trabajador"

    Public Sub LlenaCombosTrabajadores()
        Try
            LlenaComboCentro()
            LlenarCombo(cboTrabajadores, "Nombre", TrabajadorPublic, -1)
            LlenarCombo(cboJefeAdministrador, "Nombre", TrabajadorPublic, -1)
            LlenarCombo(cboJefeArea, "Nombre", TrabajadorPublic, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaComboCentro()
        Try
            Dim oe As New e_Centro
            Dim leCentro As New List(Of e_Centro)
            oe.Id = ""
            oe.Nombre = "TODOS"
            leCentro.Add(oe)
            leCentro.AddRange(olCentro.Listar(oeCentro))
            LlenarCombo(cboCentroBus, "Nombre", leCentro, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaComboSituacion()
        Try
            Dim oeSituacionAdministrativa As New e_SituacionAdministrativa
            Dim olSituacionAdministrativa As New l_SituacionAdministrativa
            oeSituacionAdministrativa.Activo = True
            LlenarCombo(cboSituacionAdministrativa, "Nombre", olSituacionAdministrativa.Listar(oeSituacionAdministrativa), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboTrabajadores_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadores.Validated
        Try
            If cboTrabajadores.SelectedIndex > -1 Then
                'Dim oeMovimientoPersonal As New e_MovimientoPersonal
                oeTrabajador = New e_Trabajador
                oeOcupacionTrabajador = New e_OcupacionTrabajador
                'oeMovimientoPersonal.IdTrabajador = cboTrabajadores.Value
                oeTrabajador.Id = cboTrabajadores.Value 'oeMovimientoPersonal.IdTrabajador
                oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then FotoTrabajador.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
                FotoTrabajador.Visible = True
                agrDatosBasicos.Visible = True
                txtArea.Text = oeTrabajador.oeArea.Nombre
                txtCargo.Text = oeTrabajador.oeCargo.Nombre
                fecFechaIngreso.Value = oeTrabajador.FechaIngreso
                oeCtrlPermisos.IdArea = oeTrabajador.oeArea.Id
                oeCtrlPermisos.Area = oeTrabajador.oeArea.Nombre
                chkDisponible.Checked = oeTrabajador.Disponible
                oeOcupacionTrabajador.IdTrabajador = oeTrabajador.Id
                oeOcupacionTrabajador.Principal = 1
                oeOcupacionTrabajador = olOcupacionTrabajador.Obtener(oeOcupacionTrabajador)
                Me.txtOcupacion.Text = oeOcupacionTrabajador.Ocupacion
                If oeTrabajador.Disponible Then
                    chkDisponible.BackColor = Color.Transparent
                    chkDisponible.ForeColor = Color.Black
                    chkDisponible.Text = "Disponible"
                Else
                    chkDisponible.BackColor = Color.Red
                    chkDisponible.ForeColor = Color.Yellow
                    chkDisponible.Text = "NO Disponible"
                End If
                oeCtrlPermisos.IdTrabajador = cboTrabajadores.Value
                CargarHistorialPermisos()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub Inicializar()
        Try
            oeCtrlPermisos = New e_ControlPermisos
            loHistorialPermisos = New List(Of e_ControlPermisos)
            griPermisosHistorial.DataSource = loHistorialPermisos
            Me.FotoTrabajador.Visible = False
            Me.agrDatosBasicos.Visible = False
            Me.fecFecha.Value = Date.Now.Date
            Me.cboTrabajadores.SelectedIndex = -1
            Me.cboJefeArea.SelectedIndex = -1
            Me.cboJefeAdministrador.SelectedIndex = -1
            Me.txtGlosa.Text = String.Empty
            Me.chkConfirmarIngreso.Checked = 0
            Me.chkConfirmarIngreso.Enabled = True
            Me.chkConfirmarSalida.Checked = 0
            Me.chkConfirmarSalida.Enabled = True
            Me.fecIngreso.Value = Date.Now.AddDays(2)
            Me.fecIngresoConfirmado.Value = Date.Now.AddDays(2)
            Me.fecIngresoConfirmado.Enabled = True
            Me.fecSalida.Value = Date.Now
            Me.fecSalidaConfirmada.Value = Date.Now
            Me.fecSalidaConfirmada.Enabled = True
            Me.txtOcupacion.Value = String.Empty
            Me.cboSituacionAdministrativa.SelectedIndex = -1
            Me.chbVenta.Visible = False
            Me.Etiqueta17.Visible = False
            Me.Etiqueta18.Visible = False
            Me.fecFinVta.Visible = False
            Me.fecInicioVta.Value = Date.Now
            Me.fecFinVta.Value = Date.Now
            Me.fecInicioVta.Visible = False
            Me.chkPapeleta.Checked = True
            If Operacion = "Nuevo" Then
                tspControlPermiso.Visible = True
                griDetalles.Visible = True
                Agrupacion3.Visible = True
            ElseIf Operacion = "Editar" Then
                tspControlPermiso.Visible = False
                griDetalles.Visible = False
                Agrupacion3.Visible = False
            End If
            loDetalles.Clear()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar()
        Try
            oeCtrlPermisos = New e_ControlPermisos
            oeCtrlPermisos.TipoOperacion = ""
            If ckbMostrarTodos.Checked Then
                oeCtrlPermisos.Fecha = fecDesde.Value
                oeCtrlPermisos.FechaSalida = fecHasta.Value
            Else
                oeCtrlPermisos.Fecha = Date.Parse("01/01/1901")
                oeCtrlPermisos.FechaSalida = Date.Parse("01/01/1901")
            End If
            oeCtrlPermisos.IdCentro = cboCentroBus.Value
            loCtrlPermisos = olCtrlPermisos.Listar(oeCtrlPermisos)
            If ckbMostrarTodos.Checked Then
                griControlPermisos.DataSource = loCtrlPermisos
            Else
                griControlPermisos.DataSource = loCtrlPermisos.Where(Function(Item) Item.IndConfirmaIngreso = False Or Item.IndConfirmaSalida = False).ToList
            End If
            Dim y As Date 'Fecha Actual
            y = ObtenerFechaServidor()
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griControlPermisos.Rows
                Dim x As Date = CDate(fila.Cells("FechaIngreso").Value)
                Dim z As Date = CDate(fila.Cells("FechaSalida").Value)
                'Dim y As Date = ObtenerFechaServidor() 'Date.Now
                If z.Date <= y.Date And x.Date >= y.Date And fila.Cells("IndConfirmaSalida").Value = True Then
                    fila.CellAppearance.BackColor = Me.Colores3.Color
                End If
                Dim b As Integer = DateDiff(DateInterval.Day, y.Date, x.Date) 'x.Day - y.Day
                If b = 0 Then
                    fila.CellAppearance.BackColor = Me.Colores2.Color
                End If
                Dim a As Integer = DateDiff(DateInterval.Day, y.Date, z.Date) 'z.Day - y.Day
                If a = 1 Then
                    fila.CellAppearance.BackColor = Me.Colores1.Color
                End If
                If b = 1 Then
                    fila.CellAppearance.BackColor = Me.Colores4.Color
                End If
                If fila.Cells("IndConfirmaIngreso").Value = True Then
                    fila.CellAppearance.BackColor = Color.White
                End If
                If fila.Cells("DiasExcedidos").Value > 0 And fila.Cells("IndConfirmaIngreso").Value = False And fila.Cells("IndConfirmaSalida").Value = True Then
                    fila.CellAppearance.BackColor = Me.ColoresExcedidos.Color
                End If
                'Añadir Permiso para Cambiar Fecha Confirmacion
                If Not olTrajadorabSeg.Permisos(gUsuarioSGI.IdTrabajador, strPermisoCambiarFechas) Then
                    If Convert.ToBoolean(fila.Cells("IndConfirmaSalida").Value) Then
                        fila.Cells("IndConfirmaSalida").Activation = Activation.NoEdit
                        fila.Cells("FechaConfirmaSalida").Activation = Activation.NoEdit
                        fila.Cells("GuardarSalidaConfirmada").Activation = Activation.Disabled
                    End If
                    If Convert.ToBoolean(fila.Cells("IndConfirmaIngreso").Value) Then
                        fila.Cells("IndConfirmaIngreso").Activation = Activation.NoEdit
                        fila.Cells("FechaConfirmaIngreso").Activation = Activation.NoEdit
                        fila.Cells("GuardarIngresoConfirmado").Activation = Activation.Disabled
                    End If
                End If
            Next
            mt_ControlBotoneria()
            MostrarTabs(0, ficCtrlPermisos)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_LlenarObjeto()
        Try
            With oeCtrlPermisos
                .Fecha = fecFecha.Value
                .FechaIngreso = fecIngreso.Value
                .FechaSalida = fecSalida.Value
                .FechaConfirmaIngreso = fecIngresoConfirmado.Value
                .FechaConfirmaSalida = fecSalidaConfirmada.Value
                .IndPapeleta = chkPapeleta.Checked
                .UsuarioCreacion = gUsuarioSGI.Id
                .IdCentro = ObtenerCentro.Id
                .IdOcupacion = oeOcupacionTrabajador.Id
                .Ocupacion = oeOcupacionTrabajador.Ocupacion
                .IndVenta = chbVenta.Checked
                .FechaInicioVtaVacaciones = fecInicioVta.Value
                .FechaFinVtaVacaciones = fecFinVta.Value
                .IndGoce = chkGoce.Checked
                If .IndConfirmaIngreso AndAlso .IndConfirmaSalida Then
                    .TotalDias = fecIngresoConfirmado.Value.Date.Subtract(fecSalidaConfirmada.Value.Date).TotalDays
                End If
            End With
            ValidarObjeto()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarPapeleta() As Boolean
        Try
            mt_LlenarObjeto()
            oeCtrlPermisos.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olCtrlPermisos.Guardar(oeCtrlPermisos) Then
                If oeCtrlPermisos.TipoOperacion = "I" Then
                    Dim frm As New frm_ReportePapeletaPermisos
                    frm.CargarDatos(oeCtrlPermisos.Id, "1")
                    frm.StartPosition = FormStartPosition.CenterScreen
                    frm.ShowDialog()
                End If
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Sub ValidarObjeto()
        Try
            With oeCtrlPermisos
                If cboTrabajadores.SelectedIndex = -1 Then
                    cboTrabajadores.Focus()
                    Throw New Exception("Seleccione Trabajador")
                End If
                If cboSituacionAdministrativa.SelectedIndex = -1 Then
                    cboSituacionAdministrativa.Focus()
                    Throw New Exception("Seleccione Situacion Administrativa")
                End If
                If cboJefeArea.SelectedIndex < 0 Then
                    cboJefeArea.Focus()
                    Throw New Exception("Seleccione jefe de area")
                End If
                If cboJefeAdministrador.SelectedIndex < 0 Then
                    cboJefeAdministrador.Focus()
                    Throw New Exception("Seleccione jefe administrativo")
                End If
                If Operacion = "Nuevo" Then
                    .TipoOperacion = "I"
                    If oeTrabajador.Disponible = False Then Throw New Exception("No Puede Dar Permiso a Trabajadores No Disponibles")
                Else
                    .TipoOperacion = "A"
                End If
                If .FechaIngreso < .FechaSalida Then Throw New Exception("La fecha de ingreso no puede ser mayor a la fecha de salida ")
                If .IndConfirmaSalida And .FechaConfirmaSalida.Date < .FechaSalida.Date Then Throw New Exception("La fecha de salida confirmada no puede ser menor que la fecha de salida")
                If .IndConfirmaIngreso And .FechaConfirmaIngreso.Date < .FechaIngreso.Date Then Throw New Exception("La fecha de ingreso confirmada no puede ser menor que la fecha de ingreso")
                If .IdSituacionAdministrativa = IdSAVacaciones And .IndVenta Then
                    If .FechaInicioVtaVacaciones.Date < .FechaConfirmaSalida.Date Then
                        Throw New Exception("No Puede Vender Vacaciones que empiezen antes de sus Vacaciones")
                    End If
                    If .FechaFinVtaVacaciones.Date > .FechaConfirmaIngreso Then
                        Throw New Exception("No Puede Vender Vacaciones que excedan sus Vacaciones")
                    End If
                End If
                If chkConfirmarIngreso.Checked Then
                    Dim FechaActual As Date = ObtenerFechaServidor()
                    If DateTime.Compare(.FechaConfirmaIngreso, FechaActual) > 0 Then
                        Throw New Exception("La fecha de ingreso confirmada no puede ser mayor que la fecha actual")
                    End If
                End If
                If chkConfirmarSalida.Checked Then
                    Dim FechaActual As Date = ObtenerFechaServidor()
                    If DateTime.Compare(.FechaConfirmaSalida, FechaActual) > 0 Then
                        Throw New Exception("La fecha de salida confirmada no puede ser mayor que la fecha actual")
                    End If
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarHistorialPermisos()
        Try
            Dim oeCtrlPerm As New e_ControlPermisos
            loHistorialPermisos = New List(Of e_ControlPermisos)
            oeCtrlPerm.IdTrabajador = oeTrabajador.Id
            oeCtrlPerm.TipoOperacion = ""
            loHistorialPermisos = olCtrlPermisos.Listar(oeCtrlPerm)
            griPermisosHistorial.DataSource = loHistorialPermisos
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarPermiso()
        Try
            If griControlPermisos.Rows.Count > 0 And griControlPermisos.ActiveRow.Selected Then
                oeCtrlPermisos.Id = griControlPermisos.ActiveRow.Cells("Id").Value
                oeCtrlPermisos = olCtrlPermisos.Obtener(oeCtrlPermisos)
                With oeCtrlPermisos
                    cboTrabajadores.Value = .IdTrabajador
                    cboJefeAdministrador.Value = .IdJefeAdministracion
                    cboJefeArea.Value = .IdJefeArea
                    fecFecha.Value = .Fecha
                    fecSalida.Value = .FechaSalida
                    fecSalidaConfirmada.Value = .FechaConfirmaSalida
                    fecIngreso.Value = .FechaIngreso
                    fecIngresoConfirmado.Value = .FechaConfirmaIngreso
                    chkConfirmarIngreso.Checked = .IndConfirmaIngreso
                    'Agregar Permiso
                    If Not olTrajadorabSeg.Permisos(gUsuarioSGI.IdTrabajador, strPermisoCambiarFechas) Then
                        If .IndConfirmaIngreso Then
                            fecIngresoConfirmado.Enabled = False
                            chkConfirmarIngreso.Enabled = False
                        End If
                        If .IndConfirmaSalida Then
                            fecSalidaConfirmada.Enabled = False
                            chkConfirmarSalida.Enabled = False
                        End If
                    End If
                    chkConfirmarSalida.Checked = .IndConfirmaSalida
                    cboSituacionAdministrativa.Value = .IdSituacionAdministrativa
                    txtGlosa.Text = .Observacion
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                    MostrarTabs(1, ficCtrlPermisos, 1)
                End With
            Else
                mt_ControlBotoneria()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function EliminarPermiso() As Boolean
        Try
            If MessageBox.Show("Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                oeCtrlPermisos = New e_ControlPermisos
                oeCtrlPermisos.Id = griControlPermisos.ActiveRow.Cells("Id").Value
                olCtrlPermisos.Eliminar(oeCtrlPermisos)
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub mt_ControlBotoneria()
        Try
            Select Case ficCtrlPermisos.SelectedTab.Index
                Case 0
                    If griControlPermisos.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case 1
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Agregar()
        Try
            If fc_ValidarAgregar() Then
                mt_LlenarObjeto()
                Dim oePermiso As New e_ControlPermisos
                oePermiso = oeCtrlPermisos.Clone
                oePermiso.PrefijoID = gs_PrefijoIdSucursal '@0001
                loDetalles.Add(oePermiso)
                griDetalles.DataBind()
                cboTrabajadores.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Quitar()
        Try
            If griDetalles.ActiveRow IsNot Nothing AndAlso griDetalles.ActiveRow.Index <> -1 AndAlso griDetalles.Selected.Rows.Count > 0 Then
                If griDetalles.ActiveRow.Cells("Id").Value.ToString().Trim().Length = 0 Then
                    loDetalles.Remove(griDetalles.ActiveRow.ListObject)
                    griDetalles.DataBind()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_ValidarAgregar() As Boolean
        Try
            Dim oeControl As New e_ControlPermisos
            oeControl.IdTrabajador = oeCtrlPermisos.IdTrabajador
            Dim lstControl As List(Of e_ControlPermisos) = olCtrlPermisos.Listar(oeControl)
            lstControl.AddRange(loDetalles.Where(Function(x) x.IdTrabajador = oeCtrlPermisos.IdTrabajador).ToList())

            If lstControl.Where(Function(x) x.IdTrabajador = oeCtrlPermisos.IdTrabajador).Count > 0 AndAlso _
                DateTime.Compare(lstControl.Where(Function(x) x.IdTrabajador = oeCtrlPermisos.IdTrabajador).OrderByDescending(Function(x) x.FechaConfirmaIngreso).ToList(0).FechaConfirmaIngreso, fecSalidaConfirmada.Value) > 0 Then
                MessageBox.Show("El trabajador seleccionado ya tiene un permiso en las fechas ingresadas" & Environment.NewLine & _
                                "La fecha de ingreso del trabajador es : " & lstControl.Where(Function(x) x.IdTrabajador = oeCtrlPermisos.IdTrabajador).OrderByDescending(Function(x) x.FechaConfirmaIngreso).ToList(0).FechaConfirmaIngreso.ToShortDateString() _
                                 , "Control Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            'If loDetalles.Where(Function(x) x.IdTrabajador = oeCtrlPermisos.IdTrabajador).Count > 0 AndAlso _
            '    DateTime.Compare(loDetalles.Where(Function(x) x.IdTrabajador = oeCtrlPermisos.IdTrabajador).OrderByDescending(Function(x) x.FechaConfirmaIngreso).ToList(0).FechaConfirmaIngreso, fecSalidaConfirmada.Value) > 0 Then
            '    MessageBox.Show("El trabajador seleccionado ya tiene un permiso en las fechas ingresadas", "Control Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Return False
            'End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_GuardarMasivo() As Boolean
        Try
            Return olCtrlPermisos.GuardarMasivo(loDetalles, gs_PrefijoIdSucursal)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_ValidarGuardarSalida(Fila As UltraGridRow) As Boolean
        Try
            If Convert.ToBoolean(Fila.Cells("IndConfirmaSalida").Value) Then
                Dim FechaActual As Date = ObtenerFechaServidor()
                If DateTime.Compare(Convert.ToDateTime(Fila.Cells("FechaConfirmaSalida").Value), FechaActual) > 0 Then
                    MessageBox.Show("La fecha de salida confirmada no puede ser mayor que la fecha actual", "SGI-ISL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
            End If
            If MessageBox.Show("Desea modificar los datos de salida del trabajador:" & Environment.NewLine & _
                                           Fila.Cells("Trabajador").Value.ToString() & Environment.NewLine & _
                                            "Fecha Salida Confirmacion: " & Fila.Cells("FechaConfirmaSalida").Value.ToString(), "SGI-ISL", _
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_ValidarGuardarIngreso(Fila As UltraGridRow) As Boolean
        Try
            If Convert.ToBoolean(Fila.Cells("IndConfirmaIngreso").Value) Then
                Dim FechaActual As Date = ObtenerFechaServidor()
                If DateTime.Compare(Convert.ToDateTime(Fila.Cells("FechaConfirmaIngreso").Value), FechaActual) > 0 Then
                    MessageBox.Show("La fecha de ingreso confirmada no puede ser mayor que la fecha actual", "SGI-ISL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
            End If
            If MessageBox.Show("Desea modificar los datos de ingreso del trabajador:" & Environment.NewLine _
                                           & Fila.Cells("Trabajador").Value.ToString() & Environment.NewLine & _
                                           "Fecha Ingreso Confirmacion: " & Fila.Cells("FechaConfirmaIngreso").Value.ToString(), "SGI-ISL", _
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class