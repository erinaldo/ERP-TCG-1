'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_ProcesoTipoDocumento

    Inherits frm_MenuPadre

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_ProcesoTipoDocumento = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ProcesoTipoDocumento()
        End If
        instancia.Activate()
        Return instancia

    End Function

#Region "Declaración de variables"
    Dim oeProcesoTipoDocumento As New e_ProcesoTipoDocumento
    Dim olProcesoTipoDocumento As New l_ProcesoTipoDocumento
    Dim _ingresando_datos As Boolean = False
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griConceptosGenerales.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeProcesoTipoDocumento.TipoOperacion = "I"
        MostrarTabs(1, ficConceptosGenerales, 1)
        Inicializar()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeProcesoTipoDocumento.TipoOperacion = "A"
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficConceptosGenerales, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeProcesoTipoDocumento.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficConceptosGenerales, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficConceptosGenerales, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficConceptosGenerales, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficConceptosGenerales, 2)
                _ingresando_datos = False
                Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griConceptosGenerales
                oeProcesoTipoDocumento.Id = .ActiveRow.Cells("ID").Value
                oeProcesoTipoDocumento = olProcesoTipoDocumento.Obtener(oeProcesoTipoDocumento)
                If oeProcesoTipoDocumento.Activo Then
                    If MessageBox.Show("Esta seguro de eliminar el proceso : " & _
                             .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeProcesoTipoDocumento.TipoOperacion = "E"
                        olProcesoTipoDocumento.Eliminar(oeProcesoTipoDocumento)
                        Consultar(_Activo)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If griConceptosGenerales.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griConceptosGenerales)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ProcesoTipoDocumento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ProcesoTipoDocumento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_ProcesoTipoDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficConceptosGenerales)
        griConceptosGenerales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griConceptosGenerales.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
    End Sub

    Private Sub griProcesoTipoDocumento_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griConceptosGenerales.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griProcesoTipoDocumento_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griConceptosGenerales.DoubleClick
        If griConceptosGenerales.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeProcesoTipoDocumento.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeProcesoTipoDocumento.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeProcesoTipoDocumento.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeProcesoTipoDocumento.Modificado = True
    End Sub

    Private Sub griProcesoTipoDocumento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griConceptosGenerales.KeyDown
        TeclaPulsada(e)
    End Sub

#End Region

#Region "Métodos"

    Private Function Guardando() As Boolean
        Try
            oeProcesoTipoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olProcesoTipoDocumento.Guardar(oeProcesoTipoDocumento) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficConceptosGenerales, 2)
                Consultar(_Activo)
                griConceptosGenerales.Focus()
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub Inicializar()
        Try
            verActivo.Checked = True
            AsociarMenu()
            CargarCboProceso()
            CargarCboTipoDocumento()
            griProcesosVinculados.DataSource = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            If griConceptosGenerales.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                oeProcesoTipoDocumento.Id = griConceptosGenerales.ActiveRow.Cells("Id").Value.ToString
                oeProcesoTipoDocumento = olProcesoTipoDocumento.Obtener(oeProcesoTipoDocumento)
                verActivo.Checked = oeProcesoTipoDocumento.Activo
                MostrarTabs(1, ficConceptosGenerales, 1)

                CargarCboProceso()
                CargarCboTipoDocumento()

                MyBase.Editar()

                cboProceso.SelectedIndex = cboProceso.FindString(oeProcesoTipoDocumento.Proceso)
                cboTipoDocumento.SelectedIndex = cboTipoDocumento.FindString(oeProcesoTipoDocumento.TipoDocumento)

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CargarCboProceso()
        Try

            Dim oeProceso As New e_ProcesoNegocio
            Dim olProceso As New l_ProcesoNegocio
            oeProceso.TipoOperacion = ""
            oeProceso.Indicador = -1
            cboProceso.Items.Clear()
            cboProceso.DataSource = olProceso.Listar(oeProceso)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub CargarCboTipoDocumento()
        Try

            Dim oeTipoDocumento As New e_TipoDocumento
            Dim olTipoDocumento As New l_TipoDocumento
            oeTipoDocumento.Activo = True
            oeTipoDocumento.TipoOperacion = ""
            cboTipoDocumento.Items.Clear()
            cboTipoDocumento.DataSource = olTipoDocumento.Listar(oeTipoDocumento)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeProcesoTipoDocumento = New e_ProcesoTipoDocumento
            With griConceptosGenerales
                oeProcesoTipoDocumento.Activo = Activo
                .DataSource = olProcesoTipoDocumento.Listar(oeProcesoTipoDocumento)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdProceso").Hidden = True
                .DisplayLayout.Bands(0).Columns("idTipoDocumento").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Proceso").Width = 200
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 1000

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griConceptosGenerales.Focus()
    End Sub
#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_ProcesoTipoDocumento_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griProcesoTipoDocumento_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griConceptosGenerales.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Material"

    Private Sub AsociarMenu()
        griConceptosGenerales.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griConceptosGenerales.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

#Region "Trabajo con combos"

    Private Sub cboProceso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProceso.ValueChanged

        Try
            If cboProceso.SelectedIndex > -1 Then oeProcesoTipoDocumento.IdProceso = cboProceso.Value.ToString.Trim
            agrListaProcesosExistentes.Text = "Lista de documentos ya vinculados a : " & cboProceso.Text

            Dim oeProcesoTipoDocumento2 As New e_ProcesoTipoDocumento
            Dim oltipoProcesoDocumento As New l_ProcesoTipoDocumento
            oeProcesoTipoDocumento2.Activo = True
            oeProcesoTipoDocumento2.IdProceso = cboProceso.Value
            griProcesosVinculados.DataSource = oltipoProcesoDocumento.Listar(oeProcesoTipoDocumento2)

            With griProcesosVinculados
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdProceso").Hidden = True
                .DisplayLayout.Bands(0).Columns("idTipoDocumento").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Proceso").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 1200
            End With

            ' ''Elimina del combo los documentos que están asignados al proceso
            'For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griProcesosVinculados.Rows
            '    Dim valor As Integer = cboTipoDocumento.FindString(fila.Cells("TipoDocumento").Value)
            '    If valor > -1 AndAlso cboTipoDocumento.Items.Count > 0 Then cboTipoDocumento.Items.RemoveAt(valor)
            'Next

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub cboTipoDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.ValueChanged
        If cboTipoDocumento.SelectedIndex > -1 Then oeProcesoTipoDocumento.IdTipoDocumento = cboTipoDocumento.Value.ToString.Trim
    End Sub

#End Region

End Class
