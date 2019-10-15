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
Imports Infragistics.Win.UltraWinToolbars

Public Class frm_MenuActividad
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    Private oeMenuActividad As New e_MenuActividad, olMenuActividad As New l_MenuActividad, leMenuActividad As New List(Of e_MenuActividad)
    Private oeMenuGrupo As New e_MenuGrupo, olMenuGrupo As New l_MenuGrupo
    Private oeActividadNegocio As New e_ActividadNegocio, olActividadNegocio As New l_ActividadNegocio
    Private oeProcesoNegocio As New e_ProcesoNegocio, olProcesoNegocio As New l_ProcesoNegocio
    Private oeMenuProceso As New e_MenuProceso, olMenuProceso As New l_MenuProceso
    Private olDatosConfiguracion As New l_Configuracion
    Private oeFormulario As New e_Formulario, olFormulario As New l_Formulario
    Dim oeTemp As New e_MenuActividad
    Dim _ingresando_datos As Boolean
    Private _opeMA As String = "", _acl As String = ""
    Private bandload As Boolean = False

#End Region

#Region "Instancia"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_MenuActividad = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_MenuActividad()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Eventos"

    Private Sub frm_Proceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtCodigo.CharacterCasing = CharacterCasing.Normal
            txtAbreviatura.CharacterCasing = CharacterCasing.Normal
            txtNombre.CharacterCasing = CharacterCasing.Normal
            txtImagen.CharacterCasing = CharacterCasing.Normal
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            MostrarTabs(0, ficMenuActividad)
            InicializaTiempo()
            leMenuActividad = New List(Of e_MenuActividad)
            bandload = True
            CargarMenuActividad(leMenuActividad)
            bandload = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Proceso_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Proceso_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        oeMenuActividad.Modificado = True
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        oeMenuActividad.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        oeMenuActividad.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeMenuActividad.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        oeMenuActividad.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeMenuActividad.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeMenuActividad.Activo = verActivo.Checked
    End Sub

    Private Sub griMenuActividad_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Editar()
    End Sub

    Private Sub verProtegido_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verProtegido.CheckedChanged
        oeMenuActividad.Protegido = verProtegido.Checked
    End Sub

    Private Sub nroOrden_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nroOrden.ValueChanged
        oeMenuActividad.Orden = nroOrden.Text
    End Sub

    Private Sub griMenuActividad_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles griMenuActividad.DoubleClick
        If griMenuActividad.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griMenuActividad_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griMenuActividad.InitializeLayout
        agrGrillaMenuActividad.Text = "Total de actividades: " & griMenuActividad.Rows.Count
    End Sub

    Private Sub btnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrir.Click
        Dim olConfiguracion As New l_Configuracion
        OpenFileDialog1.InitialDirectory = olConfiguracion.RutaImagen
        OpenFileDialog1.Filter = "Icono (*.ico)|*.ico|Portable Network Graphics (*.png)|*.png"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtImagen.Text = "\" & OpenFileDialog1.SafeFileName
            oeMenuActividad.Imagen = txtImagen.Text.Trim
            imaIcono.Image = GeneraImagen(txtImagen.Text.Trim)

        End If
    End Sub

    Private Sub verExplorador_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verExplorador.CheckedChanged
        oeMenuActividad.Explorer = verExplorador.Checked
    End Sub

    Private Sub verTamano_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verTamano.CheckedChanged
        oeMenuActividad.Tamano = verTamano.Checked
    End Sub

    Private Sub txtImagen_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImagen.ValueChanged
        oeMenuActividad.Imagen = txtImagen.Text.Trim
    End Sub

    Private Sub cboMenuGrupo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMenuGrupo.ValueChanged
        Try
            If cboMenuGrupo.SelectedIndex > -1 Then
                oeMenuActividad.IdMenuGrupo = cboMenuGrupo.Value.ToString.Trim
                oeTemp.IdMenuGrupo = cboMenuGrupo.Value
                oeTemp.Menu = 1
                LlenarCombo(cboSubMenu, "Abreviatura", olMenuActividad.Listar(oeTemp), -1)
                If oeMenuActividad.TipoOperacion = "I" Then
                    Dim _ficha As String = "", _grupo As String = ""
                    For Each Ficha As RibbonTab In frm_Menu.utm_ISLSGI.Ribbon.Tabs
                        If Ficha.Caption = cboMenuProceso.Text Then _ficha = Ficha.Key : Exit For
                    Next
                    If _ficha <> "" Then
                        For Each Grupo As RibbonGroup In frm_Menu.utm_ISLSGI.Ribbon.Tabs(_ficha).Groups
                            If Grupo.Caption = cboMenuGrupo.Text Then _grupo = Grupo.Key : Exit For
                        Next
                    End If
                    If _ficha <> "" AndAlso _grupo <> "" Then
                        nroOrden.Value = frm_Menu.utm_ISLSGI.Ribbon.Tabs(_ficha).Groups(_grupo).Tools.Count + 1
                    Else
                        nroOrden.Value = 1
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub cboActividadNegocio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboActividadNegocio.ValueChanged
        If cboActividadNegocio.SelectedIndex > -1 Then oeMenuActividad.IdActividadNegocio = cboActividadNegocio.Value.ToString.Trim
    End Sub

    Private Sub cboProcesoNegocio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProcesoNegocio.ValueChanged
        If cboProcesoNegocio.SelectedIndex > -1 Then
            oeActividadNegocio.IdProcesoNegocio = cboProcesoNegocio.Value.ToString.Trim
            oeActividadNegocio.TipoOperacion = ""
            LlenarCombo(cboActividadNegocio, "Nombre", olActividadNegocio.Listar(oeActividadNegocio), -1)
        End If
    End Sub

    Private Sub cboMenuProceso_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMenuProceso.ValueChanged
        If cboMenuProceso.SelectedIndex > -1 Then
            oeMenuGrupo.IdMenuProceso = cboMenuProceso.Value.ToString.Trim
            LlenarCombo(cboMenuGrupo, "Abreviatura", olMenuGrupo.Listar(oeMenuGrupo), -1)
        End If
    End Sub

    Private Sub verTexto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verTexto.CheckedChanged
        oeMenuActividad.Texto = verTexto.Checked
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeActividadNegocio.Modificado = True
    End Sub

    Private Sub verExplorador_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verExplorador.Click
        oeMenuActividad.Modificado = True
    End Sub

    Private Sub verProtegido_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verProtegido.Click
        oeMenuActividad.Modificado = True
    End Sub

    Private Sub verTamano_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verTamano.Click
        oeMenuActividad.Modificado = True
    End Sub

    Private Sub verTexto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verTexto.Click
        oeMenuActividad.Modificado = True
    End Sub

    Private Sub verSubMenu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verSubMenu.CheckedChanged
        cboSubMenu.Enabled = Not verSubMenu.Checked
        cboFormulario.Enabled = Not verSubMenu.Checked
        oeMenuActividad.Menu = IIf(verSubMenu.Checked, 1, 0)
    End Sub

    Private Sub verSubMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verSubMenu.Click
        oeMenuActividad.Modificado = True
    End Sub

    Private Sub cboFormulario_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFormulario.ValueChanged
        If cboFormulario.SelectedIndex > -1 Then oeMenuActividad.Formulario = cboFormulario.Value
    End Sub

    Private Sub cboSubMenu_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSubMenu.ValueChanged
        If oeMenuActividad.TipoOperacion <> "" Then
            If cboSubMenu.SelectedIndex > -1 Then
                oeMenuActividad.IdMenuItem = cboSubMenu.Value
            Else
                oeMenuActividad.IdMenuItem = ""
            End If
        End If
    End Sub

    Private Sub txtAbreviatura_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.Leave
        If txtAbreviatura.Text.Length > 0 AndAlso txtAbreviatura.Text.Trim <> "" AndAlso txtNombre.Text.Trim = "" Then txtNombre.Text = txtAbreviatura.Text
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try

            oeMenuActividad = New e_MenuActividad
            oeMenuActividad.Menu = -1
            oeMenuActividad.Activo = Activo
            leMenuActividad = olMenuActividad.Listar(oeMenuActividad)
            CargarMenuActividad(leMenuActividad)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griMenuActividad.Focus()
    End Sub

    Private Sub CargarMenuActividad(leMenuAct As List(Of e_MenuActividad))
        Try
            With griMenuActividad
                If bandload Then .ResetDisplayLayout()
                .DataSource = leMenuAct
                If bandload Then
                    OcultarColumna(griMenuActividad, True, "Id", "IdActividadNegocio", "IdMenuGrupo", "IdMenuItem", "IdMenuProceso", _
                              "IdProcesoNegocio", "FechaCreacion", "UsuarioCreacion", "Formulario", "Activo", "Explorer", "Tamano", "Texto")
                    ExcluirColumna(griMenuActividad, "Id", "IdActividadNegocio", "IdMenuGrupo", "IdMenuItem", "IdMenuProceso", "IdProcesoNegocio", _
                                   "FechaCreacion", "UsuarioCreacion", "Activo")
                    .DisplayLayout.Bands(0).Columns("MenuProceso").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("MenuGrupo").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Abreviatura").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Imagen").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("Form").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("Orden").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("Menu").Header.VisiblePosition = 8
                    .DisplayLayout.Bands(0).Columns("Protegido").Header.VisiblePosition = 9
                    .DisplayLayout.Bands(0).Columns("MenuProceso").Width = 150
                    .DisplayLayout.Bands(0).Columns("MenuGrupo").Width = 150
                    .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 150
                    .DisplayLayout.Bands(0).Columns("Nombre").Width = 200
                    .DisplayLayout.Bands(0).Columns("Imagen").Width = 120
                    .DisplayLayout.Bands(0).Columns("Form").Width = 150
                    .DisplayLayout.Bands(0).Columns("Menu").Style = ColumnStyle.CheckBox
                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                    .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            txtCodigo.Text = String.Empty
            txtNombre.Text = String.Empty
            txtAbreviatura.Text = String.Empty
            txtImagen.Text = String.Empty
            imaIcono.Image = Nothing
            cboMenuProceso.Clear()
            cboMenuGrupo.Clear()
            cboProcesoNegocio.Clear()
            cboActividadNegocio.Clear()
            LlenarCombo(cboMenuProceso, "Abreviatura", olMenuProceso.Listar(oeMenuProceso), -1)
            oeProcesoNegocio.Indicador = 1
            oeProcesoNegocio.TipoOperacion = ""
            LlenarCombo(cboProcesoNegocio, "Nombre", olProcesoNegocio.Listar(oeProcesoNegocio), -1)
            LlenarCombo(cboFormulario, "Nombre", olFormulario.Listar(oeFormulario), -1)
            'oeTemp.Menu = 1
            'LlenarCombo(cboSubMenu, "Abreviatura", olMenuActividad.Listar(oeTemp), -1)
            verProtegido.Checked = False
            verTamano.Checked = False
            verExplorador.Checked = False
            verActivo.Checked = True
            verTexto.Checked = True
            verSubMenu.Checked = False
            cboProcesoNegocio.Focus()
            AsociarMenu()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            If griMenuActividad.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeMenuActividad.Id = griMenuActividad.ActiveRow.Cells("Id").Value.ToString
                oeMenuActividad = olMenuActividad.Obtener(oeMenuActividad)
                cboMenuProceso.Value = oeMenuActividad.IdMenuProceso
                cboProcesoNegocio.Value = oeMenuActividad.IdProcesoNegocio
                txtCodigo.Text = oeMenuActividad.Codigo
                txtNombre.Text = oeMenuActividad.Nombre
                txtAbreviatura.Text = oeMenuActividad.Abreviatura
                nroOrden.Value = oeMenuActividad.Orden
                verExplorador.Checked = oeMenuActividad.Explorer
                verProtegido.Checked = oeMenuActividad.Protegido
                verActivo.Checked = oeMenuActividad.Activo
                verTamano.Checked = oeMenuActividad.Tamano
                txtImagen.Text = oeMenuActividad.Imagen
                cboActividadNegocio.Value = oeMenuActividad.IdActividadNegocio
                cboMenuGrupo.Value = oeMenuActividad.IdMenuGrupo
                cboFormulario.Value = oeMenuActividad.Formulario
                verTexto.Checked = oeMenuActividad.Texto
                verSubMenu.Checked = oeMenuActividad.Menu
                cboSubMenu.Value = oeMenuActividad.IdMenuItem
                If oeMenuActividad.Imagen <> "" Then imaIcono.Image = GeneraImagen(oeMenuActividad.Imagen)

                MostrarTabs(1, ficMenuActividad, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeMenuActividad.UsuarioCreacion = gUsuarioSGI.Id
            If oeMenuActividad.Menu = -1 Then oeMenuActividad.Menu = 0
            oeMenuActividad.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMenuActividad.Guardar(oeMenuActividad) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, ficMenuActividad, 2)
                'If oeMenuActividad.TipoOperacion = "A" Then ActualizarMenuActividad(oeMenuActividad)
                Consultar(_Activo)
                griMenuActividad.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("Nombre") Then
            txtNombre.Focus()
        End If
        If excepcion.Contains("Abreviatura") Then
            txtAbreviatura.Focus()
        End If
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griMenuActividad.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                oeMenuActividad.TipoOperacion = "I"
                MostrarTabs(1, ficMenuActividad, 1)
                Inicializar()
                txtCodigo.Focus()
                'nroOrden.Text = frm_Menu.utm_ISLSGI.Ribbon.Tabs.Count
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
                Mostrar()
                oeMenuActividad.TipoOperacion = "A"
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
                MostrarTabs(1, ficMenuActividad, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMenuActividad.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficMenuActividad, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficMenuActividad, 1)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficMenuActividad, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                        'Exit Sub

                End Select
            Else
                MostrarTabs(0, ficMenuActividad, 2)
                _ingresando_datos = False
                Consultar(_Activo)
                'Exit Sub
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                With griMenuActividad
                    If ValidarGrilla(griMenuActividad, "Proceso") Then
                        oeMenuActividad.Id = .ActiveRow.Cells("Id").Value
                        oeMenuActividad = olMenuActividad.Obtener(oeMenuActividad)
                        If oeMenuActividad.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar Menu Actividad: " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeMenuActividad.TipoOperacion = "E"
                                olMenuActividad.Eliminar(oeMenuActividad)
                                Consultar(True)
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

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            _acl = gAccionSistema.EXPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If griMenuActividad.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(griMenuActividad)
                MyBase.Exportar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_MenuActividad_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub grid_griMenuActividad_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griMenuActividad.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griMenuActividad.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griMenuActividad.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region


End Class