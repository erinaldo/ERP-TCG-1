Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports ISL.Controles
Public Class frm_ProcesoGlosa
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_ProcesoGlosa = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_ProcesoGlosa()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#Region "Declaracion de Variables"

    Dim oeProcesoNegocio As New e_ProcesoNegocio
    Dim olProcesoNegocio As New l_ProcesoNegocio

    Dim oeProcesoGlosa As New e_ProcesoGlosa
    Dim olProcesoGlosa As New l_ProcesoGlosa

    Dim loProcesoGlosa As New List(Of e_ProcesoGlosa)

    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try

            If cboProcesoNegocio.SelectedIndex > -1 Then
                Listar(Activo)
                Tiempo1.Enabled = True
                Operacion = "Inicializa"
                If griListaGlosa.Rows.Count > 0 Then
                    MyBase.Consultar(Activo)
                Else
                    MyBase.Consultar()
                End If
            Else
                mensajeEmergente.Problema("Seleccione Proceso")
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeProcesoGlosa = New e_ProcesoGlosa
            Inicializar()
            With griListaGlosa
                If Activo Then
                    oeProcesoGlosa.Activo = 1
                Else
                    oeProcesoGlosa.Activo = 0
                End If
                oeProcesoGlosa.IdProcesoNegocio = cboProcesoNegocio.Value
                'Obtiene la información de bancos desde la BD
                loProcesoGlosa = olProcesoGlosa.Listar(oeProcesoGlosa)
                .DataSource = loProcesoGlosa

                'Ordena los datos en forma ascendente por el campo Nombre
                '.DisplayLayout.Bands(0).Columns("Nombre").SortIndicator = SortOrder.Ascending

                'Ocultar columnas específicas
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdProcesoNegocio").Hidden = True
                .DisplayLayout.Bands(0).Columns("ProcesoNegocio").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                '.DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                '.DisplayLayout.Bands(0).Columns("TipoOperacion").Hidden = True
                ''.DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                'Especificar el ancho de las columnas que se muestran
                .DisplayLayout.Bands(0).Columns("ProcesoNegocio").Width = 300
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 700

                'Define el nombre que se mostrará en la cabecera de la lista
                '.DisplayLayout.Bands(0).Columns("ProcesoNegocio").Header.Caption = "ProcesoNegocio"
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Glosa"


                'Cofigura la grilla para que se seleccione la fila completa al hacer click en algun lado
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
            griListaGlosa.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            griListaGlosa.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Public Overrides Sub Nuevo()
        ' verActivo.Visible = False
        ' oebanco.TipoOperacion = "I"

        If cboProcesoNegocio.SelectedIndex > -1 Then
            Inicializar()
            ' txtCodigo.Focus()
            Operacion = "Nuevo"
            MyBase.Nuevo()
        Else
            mensajeEmergente.Problema("Seleccione un proceso")
        End If
    End Sub

    Public Overrides Sub Editar()
        ' verActivo.Visible = True
        'MostrarGlosas()
        'oeProcesoGlosa.TipoOperacion = "A"
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Private Sub MostrarGlosas()
        Try
            If griListaGlosa.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                oeProcesoGlosa.IdProcesoNegocio = cboProcesoNegocio.Value
                'oeProcesoGlosa = olb.Obtener(oebanco)
                'txtCodigo.Text = oebanco.Codigo
                'txtNombre.Text = oebanco.Nombre
                'txtAbreviatura.Text = oebanco.Abreviatura
                'verActivo.Checked = oebanco.Activo
                'MostrarTabs(1, tcbanco, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarGlosa() Then
                MyBase.Guardar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Public Overrides Sub Cancelar()
        Try

            If oeProcesoGlosa.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarGlosa() Then

                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True

                        End If
                    Case Windows.Forms.DialogResult.No

                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else

                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
            _ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function GuardarGlosa() As Boolean
        Try
            LlenarListaGlosa()
            If olProcesoGlosa.Guardar(loProcesoGlosa) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                Consultar(_Activo)
                griListaGlosa.Focus()
                Return True
            End If
        Catch ex As Exception

        End Try

    End Function

    Private Sub LlenarListaGlosa()
        If griListaGlosa.Rows.Count > 0 Then
            loProcesoGlosa = New List(Of e_ProcesoGlosa)
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaGlosa.Rows
                oeProcesoGlosa = New e_ProcesoGlosa
                oeProcesoGlosa.TipoOperacion = ""
                oeProcesoGlosa.Id = fila.Cells("Id").Value
                oeProcesoGlosa.IdProcesoNegocio = cboProcesoNegocio.Value
                oeProcesoGlosa.Nombre = fila.Cells("Nombre").Value
                oeProcesoGlosa.UsuarioCreacion = gUsuarioSGI.Id
                oeProcesoGlosa.Activo = 1
                'oeProcesoGlosa.Codigo = fila.Cells("Codigo").Value
                loProcesoGlosa.Add(oeProcesoGlosa)
                oeProcesoGlosa = Nothing
            Next
        End If
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griListaGlosa
                'If Not ValidarGrilla(griListaGlosa, "Banco") Then Exit Sub
                ''oebanco.Id = .ActiveRow.Cells("ID").Value
                ''oebanco = olbanco.Obtener(oebanco)
                ''If oebanco.Activo Then
                ''    If MessageBox.Show("Esta seguro de eliminar el Banco: " & _
                ''             .ActiveRow.Cells("Nombre").Value.ToString.Trim & "?", _
                ''             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                ''        oebanco.TipoOperacion = "E"
                ''        olbanco.Eliminar(oebanco)
                'Consultar(True)
                '    End If
                'Else
                'Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                'End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
        Dim frm As frm_ReporteBasico = frm_ReporteBanco
        frm.MdiParent = frm_Menu
        frm.Show()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If griListaGlosa.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griListaGlosa)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Private Sub LlenarCombos()
        oeProcesoNegocio.Indicador = -1
        LlenarComboMaestro(cboProcesoNegocio, olProcesoNegocio.Listar(oeProcesoNegocio), -1)
    End Sub

    Private Sub Inicializar()
        AsociarMenu()
    End Sub


#End Region

#Region "Eventos"

    Private Sub frm_ProcesoGlosa_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_ProcesoGlosa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub cboProcesoNegocio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProcesoNegocio.ValueChanged
        If cboProcesoNegocio.SelectedIndex > -1 Then
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Else
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griListaGlosa.ContextMenuStrip = mcDetalles
    End Sub

    'Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
    '    Nuevo()
    'End Sub

    'Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
    '    Editar()
    'End Sub

    'Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
    '    Eliminar()
    'End Sub

    'Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
    '    MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
    '    If griListaBanco.Selected.Rows.Count > 0 Then
    '        MenuContextual1.Items("EditarToolStripMenuItem").Visible = True
    '        MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
    '    Else
    '        MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
    '        MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
    '    End If
    'End Sub

#End Region


#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_ProcesoGlosa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LlenarCombos()
    End Sub


    Private Sub frm_ProcesoGlosa_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griListaGlosa_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaGlosa.MouseMove
        If _tiempo <= 0 Then
            ' Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

    Private Sub Agregar()
        Try
            oeProcesoGlosa = New e_ProcesoGlosa
            'loProcesoGlosa = New List(Of e_ProcesoGlosa)
            If griListaGlosa.Rows.Count = 0 Then
                Listar(True)
            End If
            loProcesoGlosa.Add(oeProcesoGlosa)
            griListaGlosa.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Quitar()
        Try
            If griListaGlosa.Rows.Count > 0 Then
                griListaGlosa.ActiveRow.Delete()
                griListaGlosa.Select()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub tsmiAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregar.Click
        Agregar()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub tsmiQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitar.Click
        Quitar()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub


    Private Sub griListaGlosa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griListaGlosa.KeyDown
        oeProcesoGlosa.Modificado = True
        Select Case e.KeyCode
            Case Keys.Insert
                Agregar()
            Case Keys.Delete
                Quitar()
            Case Keys.Add
                Agregar()
            Case Keys.Subtract
                Quitar()
        End Select
    End Sub

    Private Sub griListaGlosa_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaGlosa.CellChange
        Try
            griListaGlosa.UpdateData()
        Catch

        End Try
    End Sub

    Private Sub griListaGlosa_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaGlosa.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Quitar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub mcDetalles_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcDetalles.Opening
        mcDetalles.Items("tsmiAgregar").Visible = True
        mcDetalles.Items("tsmiQuitar").Visible = False

        If griListaGlosa.Selected.Rows.Count > 0 Then
            mcDetalles.Items("tsmiQuitar").Visible = True
        End If
    End Sub
End Class