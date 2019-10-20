'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ProcesoNegocio
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ProcesoNegocio = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ProcesoNegocio()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeProcesoNegocio As New e_ProcesoNegocio, olProcesoNegocio As New l_ProcesoNegocio, leProcesoNegocio As New List(Of e_ProcesoNegocio)
    Private oeActividadNegocio As New e_ActividadNegocio, leActividadNegocio As New List(Of e_ActividadNegocio)
    Private oeFlujoCaja As New e_FlujoCaja, leFlujoCaja As New List(Of e_FlujoCaja)
    Dim _ingresando_datos As Boolean = False
    Private _opePN As String = "", _acl As String = ""

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griProcesoNegocio.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                verActivo.Visible = False
                oeProcesoNegocio.TipoOperacion = "I"
                MostrarTabs(1, ficProcesoNegocio, 1)
                oeProcesoNegocio.Protegido = 1
                Inicializar()
                txtCodigo.Focus()
                oeProcesoNegocio.Modificado = False
                Operacion = "Nuevo"
                MyBase.Nuevo()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            _acl = gAccionSistema.EDITAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                verActivo.Visible = True
                Mostrar()
                oeProcesoNegocio.TipoOperacion = "A"
                txtCodigo.Focus()
                Operacion = "Editar"
                MyBase.Editar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficProcesoNegocio, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeProcesoNegocio.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficProcesoNegocio, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficProcesoNegocio, 1)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficProcesoNegocio, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                        'Exit Sub
                End Select
            Else
                MostrarTabs(0, ficProcesoNegocio, 2)
                _ingresando_datos = False
                Consultar(_Activo)
                'Exit Sub
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                With griProcesoNegocio
                    If ValidarGrilla(griProcesoNegocio, "TipoPago") Then
                        oeProcesoNegocio.Id = .ActiveRow.Cells("ID").Value
                        oeProcesoNegocio = olProcesoNegocio.Obtener(oeProcesoNegocio)
                        If oeProcesoNegocio.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el proceso : " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeProcesoNegocio.TipoOperacion = "E"
                                olProcesoNegocio.Eliminar(oeProcesoNegocio)
                                Consultar(_Activo)
                            End If
                        Else
                            Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                        End If
                    End If
                End With
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            _acl = gAccionSistema.EXPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If griProcesoNegocio.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(griProcesoNegocio)
                MyBase.Exportar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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

    Private Sub frm_ProcesoNegocio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ProcesoNegocio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_ProcesoNegocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cboTipoBus.Clear()
            cboTipoBus.Items.Add("[TODOS]")
            cboTipoBus.Items.Add("PROCESO NEGOCIO")
            cboTipoBus.Items.Add("FICHA SGI")
            cboTipoBus.SelectedIndex = 0
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            MostrarTabs(0, ficProcesoNegocio)
            griProcesoNegocio.DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
            griProcesoNegocio.DisplayLayout.Override.RowSelectors = DefaultableBoolean.True
            leProcesoNegocio = New List(Of e_ProcesoNegocio)
            CargarProcesoNegocio(leProcesoNegocio)
            InicializaTiempo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griProcesoNegocio_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griProcesoNegocio.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griProcesoNegocio_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griProcesoNegocio.DoubleClick
        If griProcesoNegocio.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeProcesoNegocio.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeProcesoNegocio.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeProcesoNegocio.Activo = verActivo.Checked
    End Sub

    Private Sub verProcesoProtegido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verProcesoProtegido.CheckedChanged
        oeProcesoNegocio.Protegido = verProcesoProtegido.Checked
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        oeProcesoNegocio.Modificado = True
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeProcesoNegocio.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeProcesoNegocio.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeProcesoNegocio.Modificado = True
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeProcesoNegocio.Modificado = True
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        oeProcesoNegocio.Modificado = True
    End Sub

    Private Sub griProcesoNegocio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griProcesoNegocio.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub tsmiAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregar.Click
        Agregar()
    End Sub

    Private Sub tsmiQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitar.Click
        Quitar()
    End Sub

    Private Sub griActividadNegocio_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griActividadNegocio.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Quitar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub griActividadNegocio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griActividadNegocio.KeyDown
        oeProcesoNegocio.Modificado = True
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

    Private Sub griActividadNegocio_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griActividadNegocio.CellChange
        Try
            griActividadNegocio.UpdateData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub varMenu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verMenu.CheckedChanged
        oeProcesoNegocio.Indicador = IIf(verMenu.Checked, 1, 0)
        If verMenu.Checked Then
            SeleccionaTab(0)
        Else
            SeleccionaTab(1)
        End If
    End Sub

    Private Sub oeProcesoNegocio_DatoCambiado() Handles oeProcesoNegocio.DatoCambiado
        oeProcesoNegocio.Modificado = True
    End Sub

#End Region

#Region "Métodos"

    Private Function Guardando() As Boolean
        Try
            LlenarActividadNegocio()
            oeProcesoNegocio.Seguridad = cbSeguridad.Checked
            oeProcesoNegocio.UsuarioCreacion = gUsuarioSGI.Id
            oeProcesoNegocio.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olProcesoNegocio.Guardar(oeProcesoNegocio) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, ficProcesoNegocio, 2)
                Consultar(_Activo)
                griProcesoNegocio.Focus()
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        oeProcesoNegocio.Indicador = 0
        verActivo.Checked = True
        verMenu.Checked = False
        cbSeguridad.Checked = False
        SeleccionaTab(1)
        leActividadNegocio = New List(Of e_ActividadNegocio)
        ListarActividadNegocio(leActividadNegocio)
        leFlujoCaja = New List(Of e_FlujoCaja)
        CargarFlujoCaja(leFlujoCaja)
        'griActividadNegocio.ContextMenuStrip = mcDetalles
        'griActividadNegocio.DataSource = Nothing
        'AsociarMenu()
    End Sub

    Private Sub Mostrar()
        Try
            If griProcesoNegocio.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                verActivo.Visible = True
                oeProcesoNegocio.Id = griProcesoNegocio.ActiveRow.Cells("Id").Value.ToString
                oeProcesoNegocio = olProcesoNegocio.Obtener(oeProcesoNegocio)
                txtCodigo.Text = oeProcesoNegocio.Codigo
                txtNombre.Text = oeProcesoNegocio.Nombre
                verMenu.Checked = IIf(oeProcesoNegocio.Indicador = 1, True, False)
                cbSeguridad.Checked = oeProcesoNegocio.Seguridad
                verActivo.Checked = oeProcesoNegocio.Activo
                verProcesoProtegido.Checked = IIf(oeProcesoNegocio.Protegido = 1, True, False)
                ListarActividadNegocio(oeProcesoNegocio.leActividadNegocio)
                leFlujoCaja = oeProcesoNegocio.leFlujoCaja
                CargarFlujoCaja(leFlujoCaja)
                oeProcesoNegocio.Modificado = False
                MostrarTabs(1, ficProcesoNegocio, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarProcesoNegocio(leProNeg As List(Of e_ProcesoNegocio))
        Try
            With griProcesoNegocio
                .ResetDisplayLayout()
                .DataSource = leProNeg

                OcultarColumna(griProcesoNegocio, True, "Id", "FechaCreacion", "UsuarioCreacion", "Activo")
                ExcluirColumna(griProcesoNegocio, "Id", "Activo")

                .DisplayLayout.Bands(0).Columns("Indicador").Header.Caption = "Ficha"

                .DisplayLayout.Bands(0).Columns("Indicador").Style = ColumnStyle.CheckBox
                .DisplayLayout.Bands(0).Columns("Protegido").Style = ColumnStyle.CheckBox

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 100
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 300

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeProcesoNegocio = New e_ProcesoNegocio
            oeProcesoNegocio.TipoOperacion = ""
            oeProcesoNegocio.Indicador = cboTipoBus.SelectedIndex - 1
            oeProcesoNegocio.Activo = True
            leProcesoNegocio = olProcesoNegocio.Listar(oeProcesoNegocio)
            CargarProcesoNegocio(leProcesoNegocio)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griProcesoNegocio.Focus()
    End Sub

    Private Sub ListarActividadNegocio(ByVal leActNeg As List(Of e_ActividadNegocio))
        Try
            With griActividadNegocio
                .DataSource = leActNeg
                OcultarColumna(griActividadNegocio, True, "Id", "IdProcesoNegocio", "FechaCreacion", "UsuarioCreacion", "Abreviatura")
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 100
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 350
                .DisplayLayout.Bands(0).Columns("Codigo").SortIndicator = SortOrder.Ascending
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarFlujoCaja(ByVal leFluCaja As List(Of e_FlujoCaja))
        Try
            With griFlujoCaja
                .ResetDisplayLayout()
                .DataSource = leFluCaja
                OcultarColumna(griFlujoCaja, True, "Activo", "Abreviatura", "FechaCreacion", "Id", "IdItemGasto", "IndMovimiento", _
                               "Modificado", "Movimiento", "TipoOperacion", "UsuarioCreacion")
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 100
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 350
                .DisplayLayout.Bands(0).Columns("Codigo").SortIndicator = SortOrder.Ascending
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarActividadNegocio()

        If griActividadNegocio.Rows.Count > 0 Then
            oeProcesoNegocio.leActividadNegocio = New List(Of e_ActividadNegocio)
            For Each fila As UltraGridRow In griActividadNegocio.Rows
                oeActividadNegocio = New e_ActividadNegocio
                oeActividadNegocio.Id = fila.Cells("Id").Value
                oeActividadNegocio.IdProcesoNegocio = oeProcesoNegocio.Id
                oeActividadNegocio.UsuarioCreacion = gUsuarioSGI.Id
                oeActividadNegocio.Nombre = fila.Cells("Nombre").Value
                oeActividadNegocio.Codigo = fila.Cells("Codigo").Value
                oeActividadNegocio.Abreviatura = fila.Cells("Abreviatura").Value
                oeActividadNegocio.Activo = fila.Cells("Activo").Value
                oeActividadNegocio.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeProcesoNegocio.leActividadNegocio.Add(oeActividadNegocio)
                oeActividadNegocio = Nothing
            Next
        End If
    End Sub

    Private Sub Agregar()
        Try
            oeActividadNegocio = New e_ActividadNegocio
            leActividadNegocio = New List(Of e_ActividadNegocio)
            If griActividadNegocio.Rows.Count = 0 Then
                ListarActividadNegocio(leActividadNegocio)
                oeProcesoNegocio.leActividadNegocio = leActividadNegocio
            End If
            leActividadNegocio = oeProcesoNegocio.leActividadNegocio
            leActividadNegocio.Add(oeActividadNegocio)
            griActividadNegocio.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Quitar()
        Try
            If griActividadNegocio.Rows.Count > 0 Then
                griActividadNegocio.ActiveRow.Delete()
                griActividadNegocio.Select()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub SeleccionaTab(_index As Integer)
        ficDetalle.Tabs(0).Enabled = False
        ficDetalle.Tabs(1).Enabled = False
        ficDetalle.Tabs(_index).Enabled = True
        ficDetalle.Tabs(_index).Selected = True
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_ProcesoNegocio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griProcesoNegocio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griProcesoNegocio.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Material"

    Private Sub AsociarMenu()
        griProcesoNegocio.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("tsmiNuevo").Enabled = True
        MenuContextual1.Items("tsmiExportar").Enabled = IIf(griProcesoNegocio.Rows.Count > 0, True, False)
        MenuContextual1.Items("tsmiEditar").Enabled = IIf(griProcesoNegocio.Selected.Rows.Count > 0, True, False)
        MenuContextual1.Items("tsmiEliminar").Enabled = IIf(griProcesoNegocio.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        Exportar()
    End Sub

#End Region

End Class
