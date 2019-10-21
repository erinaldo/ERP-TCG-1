'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_UnidadMedida

#Region "Inicializacion de Formulario"
    Private Shared instancia As frm_UnidadMedida = Nothing
    Private Shared Operacion As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_UnidadMedida
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function
#End Region

#Region "Declaración de Variables"
    Dim olUnidadMedida As New l_UnidadMedida
    Dim oeUnidadMedida As New e_UnidadMedida
    Dim olTipoUnidadMedida As New l_TipoUnidadMedida
    Dim oeTipoUnidadMedida As New e_TipoUnidadMedida
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String
#End Region

#Region "Botones"
    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Listar(Activo)
        Tiempo1.Enabled = True
        Operacion = "Inicializa"
        If griUnidadMedidaNoAsignado.Rows.Count > 0 Then
            MyBase.Consultar(Activo)
        Else
            MyBase.Consultar()
        End If
    End Sub

    Public Overrides Sub Nuevo()
        verActivo.Visible = False
        oeUnidadMedida.TipoOperacion = "I"
        MostrarTabs(1, ficUnidadMedida, 1)
        Inicializar()
        txtCodigo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        verActivo.Visible = True
        Mostrar()
        oeUnidadMedida.TipoOperacion = "A"
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficUnidadMedida, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeUnidadMedida.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficUnidadMedida, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficUnidadMedida, 1)
                        End If
                        'Exit Sub
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficUnidadMedida, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                        'Exit Sub
                End Select
            Else
                MostrarTabs(0, ficUnidadMedida, 2)
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
            oeUnidadMedida = New e_UnidadMedida
            If griUnidadMedidaAsignado.ActiveRow.Selected Then
                With griUnidadMedidaAsignado
                    If ValidarGrilla(griUnidadMedidaAsignado, "UnidadMedida") Then
                        oeUnidadMedida.Id = .ActiveRow.Cells("Id").Value
                        oeUnidadMedida = olUnidadMedida.Obtener(oeUnidadMedida)
                        MensajeConfirmaEliminacionUnidadMedida(oeUnidadMedida)
                    End If
                End With
            End If

            If griUnidadMedidaNoAsignado.ActiveRow.Selected Then
                With griUnidadMedidaNoAsignado
                    If ValidarGrilla(griUnidadMedidaNoAsignado, "UnidadMedida") Then
                        oeUnidadMedida.Id = .ActiveRow.Cells("Id").Value
                        oeUnidadMedida = olUnidadMedida.Obtener(oeUnidadMedida)
                        MensajeConfirmaEliminacionUnidadMedida(oeUnidadMedida)
                    End If
                End With
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Mensaje para confirmar la eliminación de la unidad de medida 
    ''' </summary>
    ''' <param name="oeUnidadMedida">Unidad de medida que se va a eliminar</param>
    ''' <remarks></remarks>
    Private Sub MensajeConfirmaEliminacionUnidadMedida(ByVal oeUnidadMedida As e_UnidadMedida)
        Try
            If oeUnidadMedida.Activo Then
                If MessageBox.Show("Esta seguro de eliminar la Unidad de Medida: " & _
                         oeUnidadMedida.Nombre & " ?", _
                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    oeUnidadMedida.TipoOperacion = "E"
                    olUnidadMedida.Eliminar(oeUnidadMedida)
                    Consultar(True)
                End If
            Else
                Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If griUnidadMedidaAsignado.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griUnidadMedidaAsignado)

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
    Private Sub frm_UnidadMedida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficUnidadMedida)
        'griUnidadMedidaNoAsignado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        'griUnidadMedidaNoAsignado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
        cboBuscar.SelectedIndex = 0
        llenarTipoUnidadMedida()
    End Sub

    Private Sub frm_UnidadMedida_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_UnidadMedida_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub chkActivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub frm_UnidadMedida_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub


    Private Sub griUnidadMedida_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griUnidadMedidaNoAsignado.DoubleClick, griUnidadMedidaAsignado.DoubleClick
        If griUnidadMedidaNoAsignado.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griUnidadMedida_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griUnidadMedidaNoAsignado.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griUnidadMedida_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griUnidadMedidaNoAsignado.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

    Private Sub llenarTipoUnidadMedida()
        oeTipoUnidadMedida.TipoOperacion = ""
        oeTipoUnidadMedida.Activo = True
        LlenarComboMaestro(cboUnidadMedida, olTipoUnidadMedida.Listar(oeTipoUnidadMedida), -1)
    End Sub

    Private Sub cboUnidadMedida_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboUnidadMedida.KeyDown
        TeclaPulsada(e)
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub cboUnidadMedida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUnidadMedida.ValueChanged
        oeUnidadMedida.IdTipoUnidadMedida = cboUnidadMedida.Value
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub verUnidadBase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verUnidadBase.CheckedChanged
        If verUnidadBase.Checked = True Then
            decFactor.Value = 1
            decFactor.Enabled = False
        Else
            decFactor.Value = 0
            decFactor.Enabled = True
        End If
        oeUnidadMedida.Base = verUnidadBase.Checked
    End Sub

    Private Sub verUnidadBase_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verUnidadBase.Click
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub verUnidadBase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verUnidadBase.KeyPress
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub decFactor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles decFactor.GotFocus
        decFactor.SelectAll()
    End Sub

    Private Sub decFactor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles decFactor.KeyDown
        TeclaPulsada(e)
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub decFactor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles decFactor.KeyPress
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub decFactor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decFactor.ValueChanged
        oeUnidadMedida.Factor = decFactor.Value
        If oeUnidadMedida.Factor = 0 Then
            oeUnidadMedida.Asignado = False
        Else
            oeUnidadMedida.Asignado = True
        End If
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeUnidadMedida.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeUnidadMedida.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeUnidadMedida.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeUnidadMedida.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeUnidadMedida.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub griUnidadMedidaAsignado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles griUnidadMedidaAsignado.Click
        oeUnidadMedida.Asignado = True
    End Sub

    Private Sub griUnidadMedidaNoAsignado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles griUnidadMedidaNoAsignado.Click
        oeUnidadMedida.Asignado = False
    End Sub

    Private Sub cboBuscar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuscar.ValueChanged
        If cboBuscar.Text = "Asignado" Then
            Agrupacion3.Dock = DockStyle.Fill
            Agrupacion3.Visible = True
            Agrupacion2.Visible = False
            griUnidadMedidaAsignado.Dock = DockStyle.Fill
            griUnidadMedidaAsignado.Visible = True
        ElseIf cboBuscar.Text = "No Asignado" Then
            Agrupacion2.Dock = DockStyle.Fill
            Agrupacion2.Visible = True
            Agrupacion3.Visible = False
            griUnidadMedidaNoAsignado.Visible = True
            griUnidadMedidaNoAsignado.Dock = DockStyle.Fill
        ElseIf cboBuscar.Text = "Todos" Then
            Agrupacion3.Visible = True
            Agrupacion2.Visible = True
            Agrupacion2.Dock = DockStyle.Top
            Agrupacion3.Dock = DockStyle.Fill
            griUnidadMedidaNoAsignado.Visible = True
            griUnidadMedidaAsignado.Visible = True
        End If
    End Sub

    Private Sub griUnidadMedidaAsignado_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griUnidadMedidaAsignado.InitializeLayout
        Agrupacion2.Text = "Total de Unidades de Medidas Asignadas: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub griUnidadMedidaNoAsignado_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griUnidadMedidaNoAsignado.InitializeLayout
        Agrupacion3.Text = "Total de Unidades Medidas no Asignadas: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub griUnidadMedidaNoAsignado_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griUnidadMedidaNoAsignado.CellChange
        griUnidadMedidaAsignado.UpdateData()
    End Sub

    Private Sub griUnidadMedidaAsignado_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griUnidadMedidaAsignado.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griUnidadMedidaNoAsignado_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griUnidadMedidaNoAsignado.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub
#End Region

#Region "Métodos"
    Private Sub Inicializar()
        cboUnidadMedida.SelectedIndex = -1
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        verActivo.Checked = True
        decFactor.Value = 0
        verUnidadBase.Checked = False
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
            oeUnidadMedida.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olUnidadMedida.Guardar(oeUnidadMedida) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficUnidadMedida, 2)
                Consultar(True)
                griUnidadMedidaNoAsignado.Focus()
                Return True
            End If
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
            oeUnidadMedida = New e_UnidadMedida
            oeUnidadMedida.Activo = Activo
            oeUnidadMedida.TipoOperacion = "L"
            oeUnidadMedida.Asignado = False
            Dim ds As DataSet = olUnidadMedida.ListarD(oeUnidadMedida)
            Dim parentCol As DataColumn = ds.Tables(0).Columns("Id")
            Dim childCol As DataColumn = ds.Tables(1).Columns("IdTipoUnidadMedida")
            Dim relation As DataRelation = New DataRelation("FK_RelacionUnidadMedida", parentCol, childCol, False)
            ds.Relations.Add(relation)
            ds.AcceptChanges()
            griUnidadMedidaNoAsignado.DataSource = ds
            oeUnidadMedida = New e_UnidadMedida
            oeUnidadMedida.Activo = Activo
            oeUnidadMedida.TipoOperacion = "L"
            oeUnidadMedida.Asignado = True
            Dim ds1 As DataSet = olUnidadMedida.ListarD(oeUnidadMedida)
            Dim parentCol1 As DataColumn = ds1.Tables(0).Columns("Id")
            Dim childCol1 As DataColumn = ds1.Tables(1).Columns("IdTipoUnidadMedida")
            Dim relation1 As DataRelation = New DataRelation("FK_RelacionUnidadMedida1", parentCol1, childCol1, False)
            ds1.Relations.Add(relation1)
            ds1.AcceptChanges()
            griUnidadMedidaAsignado.DataSource = ds1
            With griUnidadMedidaNoAsignado
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = False
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
                .DisplayLayout.Bands(0).Columns("Abreviatura").Hidden = False
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(1).Columns("Id").Hidden = True
                .DisplayLayout.Bands(1).Columns("Codigo").Hidden = False
                .DisplayLayout.Bands(1).Columns("Nombre").Hidden = False
                .DisplayLayout.Bands(1).Columns("Abreviatura").Hidden = False
                .DisplayLayout.Bands(1).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdTipoUnidadMedida").Hidden = True
            End With
            With griUnidadMedidaAsignado
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = False
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
                .DisplayLayout.Bands(0).Columns("Abreviatura").Hidden = False
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(1).Columns("Id").Hidden = True
                .DisplayLayout.Bands(1).Columns("Codigo").Hidden = False
                .DisplayLayout.Bands(1).Columns("Nombre").Hidden = False
                .DisplayLayout.Bands(1).Columns("Abreviatura").Hidden = False
                .DisplayLayout.Bands(1).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdTipoUnidadMedida").Hidden = True
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            'If griUnidadMedidaNoAsignado.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
            Inicializar()
            Dim oeUnidadMedida As New e_UnidadMedida
            If cboBuscar.Text = "Asignado" Then
                'oeUnidadMedida.Asignado = True
                oeUnidadMedida.Id = griUnidadMedidaAsignado.ActiveRow.Cells("Id").Value.ToString
            ElseIf cboBuscar.Text = "No Asignado" Then
                'oeUnidadMedida.Asignado = False
                oeUnidadMedida.Id = griUnidadMedidaNoAsignado.ActiveRow.Cells("Id").Value.ToString
            End If
            oeUnidadMedida.TipoOperacion = ""
            oeUnidadMedida = olUnidadMedida.Obtener(oeUnidadMedida)
            txtId.Text = oeUnidadMedida.Id
            txtCodigo.Text = oeUnidadMedida.Codigo
            txtNombre.Text = oeUnidadMedida.Nombre
            txtAbreviatura.Text = oeUnidadMedida.Abreviatura
            verActivo.Checked = oeUnidadMedida.Activo
            decFactor.Value = oeUnidadMedida.Factor
            verUnidadBase.Checked = oeUnidadMedida.Base
            cboUnidadMedida.Value = oeUnidadMedida.IdTipoUnidadMedida
            MostrarTabs(1, ficUnidadMedida, 1)
            MyBase.Editar()
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)

        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_TipoUnidadMedida_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griUnidadMedidaAsignado_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griUnidadMedidaAsignado.MouseMove, griUnidadMedidaNoAsignado.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de la Unidad de Medida"

    Private Sub AsociarMenu()
        griUnidadMedidaNoAsignado.ContextMenuStrip = MenuContextual1
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
        If griUnidadMedidaAsignado.Visible Then
            If griUnidadMedidaAsignado.Selected.Rows.Count > 0 Then
                MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
            Else
                MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
            End If
        End If
        If griUnidadMedidaNoAsignado.Visible Then
            If griUnidadMedidaNoAsignado.Selected.Rows.Count > 0 Then
                MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
            Else
                MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
            End If
        End If
    End Sub

#End Region

End Class


