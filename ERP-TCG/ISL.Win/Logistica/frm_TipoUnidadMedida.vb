'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_TipoUnidadMedida

    Private Shared instancia As frm_TipoUnidadMedida = Nothing
    Private Shared Operacion As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_TipoUnidadMedida
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de Variables"
    Dim olTipoUnidadMedida As New l_TipoUnidadMedida
    Dim oeTipoUnidadMedida As New e_TipoUnidadMedida
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String
#End Region

#Region "Botones"
    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griTipoUnidadMedida.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        verActivo.Visible = False
        oeTipoUnidadMedida.TipoOperacion = "I"
        MostrarTabs(1, ficTipoUnidadMedida, 1)
        Inicializar()
        txtCodigo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        verActivo.Visible = True
        Mostrar()
        oeTipoUnidadMedida.TipoOperacion = "A"
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficTipoUnidadMedida, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTipoUnidadMedida.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficTipoUnidadMedida, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficTipoUnidadMedida, 1)
                        End If
                        'Exit Sub
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficTipoUnidadMedida, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                        'Exit Sub
                End Select
            Else
                MostrarTabs(0, ficTipoUnidadMedida, 2)
                _ingresando_datos = False
                Operacion = "Inicializa"
                MyBase.Consultar(True)
                'Exit Sub
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try

            If ValidarGrilla(griTipoUnidadMedida, "TipoUnidadMedida") Then
                oeTipoUnidadMedida = New e_TipoUnidadMedida
                oeTipoUnidadMedida.Id = griTipoUnidadMedida.ActiveRow.Cells("ID").Value
                oeTipoUnidadMedida = olTipoUnidadMedida.Obtener(oeTipoUnidadMedida)
                If oeTipoUnidadMedida.Activo Then
                    If MessageBox.Show("Esta seguro de eliminar Tipo de Unidad de Medida: " & _
                             griTipoUnidadMedida.ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeTipoUnidadMedida.TipoOperacion = "E"
                        olTipoUnidadMedida.Eliminar(oeTipoUnidadMedida)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            End If

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

            If griTipoUnidadMedida.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griTipoUnidadMedida)

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
    Private Sub frm_TipoUnidadMedida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficTipoUnidadMedida)
        griTipoUnidadMedida.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griTipoUnidadMedida.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
    End Sub

    Private Sub frm_TipoUnidadMedida_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_TipoUnidadMedida_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeTipoUnidadMedida.Modificado = True
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
        oeTipoUnidadMedida.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
        oeTipoUnidadMedida.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeTipoUnidadMedida.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeTipoUnidadMedida.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeTipoUnidadMedida.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeTipoUnidadMedida.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeTipoUnidadMedida.Activo = verActivo.Checked
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        oeTipoUnidadMedida.Modificado = True
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeTipoUnidadMedida.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        oeTipoUnidadMedida.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeTipoUnidadMedida.Modificado = True
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeTipoUnidadMedida.Modificado = True
    End Sub

    Private Sub griTipoUnidadMedida_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griTipoUnidadMedida.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griTipoUnidadMedida_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griTipoUnidadMedida.DoubleClick
        If griTipoUnidadMedida.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griTipoUnidadMedida_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griTipoUnidadMedida.InitializeLayout
        agrLista.Text = "Total de Almacenes: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub griTipoUnidadMedida_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griTipoUnidadMedida.KeyDown
        TeclaPulsada(e)
    End Sub

#End Region

#Region "Métodos"
    Private Sub Inicializar()
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        verActivo.Checked = True
        AsociarMenu()
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
        If excepcion.Contains("abreviatura") Then
            txtAbreviatura.Focus()
        End If
    End Sub

    Private Function GuardarRegistro() As Boolean
        Try
            oeTipoUnidadMedida.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olTipoUnidadMedida.Guardar(oeTipoUnidadMedida) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficTipoUnidadMedida, 2)
            Consultar(True)
            griTipoUnidadMedida.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            If Activo Then
                Estado = " Activo"
            Else
                Estado = " Inactivo"
            End If
            Me.Cursor = Cursors.WaitCursor
            oeTipoUnidadMedida = New e_TipoUnidadMedida
            oeTipoUnidadMedida.Activo = Activo
            griTipoUnidadMedida.DataSource = olTipoUnidadMedida.Listar(oeTipoUnidadMedida)

            With griTipoUnidadMedida
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = False
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
                .DisplayLayout.Bands(0).Columns("Abreviatura").Hidden = False
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = False
                .DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoOperacion").Hidden = True
                agrLista.Text = "Total de Tipo de Movimientos de Inventario: " & griTipoUnidadMedida.Rows.Count.ToString

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
    End Sub

    Private Sub Mostrar()
        Try
            If griTipoUnidadMedida.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeTipoUnidadMedida.Id = griTipoUnidadMedida.ActiveRow.Cells("Id").Value.ToString
                oeTipoUnidadMedida = olTipoUnidadMedida.Obtener(oeTipoUnidadMedida)
                txtId.Text = oeTipoUnidadMedida.Id
                txtCodigo.Text = oeTipoUnidadMedida.Codigo
                txtNombre.Text = oeTipoUnidadMedida.Nombre
                txtAbreviatura.Text = oeTipoUnidadMedida.Abreviatura
                verActivo.Checked = oeTipoUnidadMedida.Activo
                MostrarTabs(1, ficTipoUnidadMedida, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)

        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_TipoUnidadMedida_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griTipoUnidadMedida_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griTipoUnidadMedida.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Tipo de Unidad de Medida"

    Private Sub AsociarMenu()
        griTipoUnidadMedida.ContextMenuStrip = MenuContextual1
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
        If griTipoUnidadMedida.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class


