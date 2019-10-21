'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Perfil
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Perfil = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Perfil()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oePerfil As New e_Perfil, olPerfil As New l_Perfil, lePerfil As New List(Of e_Perfil)
    Private oeActividadNegocio As New e_ActividadNegocio, olActividadNegocio As New l_ActividadNegocio
    Private leActividadNegocio As New List(Of e_ActividadNegocio), leActNegSel As New List(Of e_ActividadNegocio)
    Private oeDetalle As New e_PerfilActividadNegocio, leDetalle As New List(Of e_PerfilActividadNegocio)
    Private oeUsuario As New e_Usuario, olUsuario As New l_Usuario, leUsuario As New List(Of e_Usuario)
    Private oeAccionSistema As New e_AccionSistema, olAccionSistema As New l_AccionSistema, leAccionSistema As New List(Of e_AccionSistema)
    Private oeProcesoNegocio As New e_ProcesoNegocio, olProcesoNegocio As New l_ProcesoNegocio
    Private leProcesoNegocio As New List(Of e_ProcesoNegocio), leProNegSel As New List(Of e_ProcesoNegocio)
    Private oeARUsuario As New e_ActividadRestringida_Usuario, olARUsuario As New l_ActividadRestringido_Usuario, leARUsuario As New List(Of e_ActividadRestringida_Usuario)

    Dim _ingresando_datos As Boolean = False
    Dim idPA As String
    Dim idPerfil As String = ""
    Dim _BandValida As Boolean = True

    Private _opePer As String = "", _acl As String = ""


#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Instancia"
            If griPerfil.Rows.Count > 0 Then
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
                MostrarTabs(1, ficPerfil, 1)
                ficPerfil.Tabs(2).Enabled = False
                Inicializar()
                oePerfil.TipoOperacion = "I"
                oePerfil.Modificado = False
                txtCodigo.Focus()
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
                oePerfil.TipoOperacion = "A"
                oePerfil.Modificado = False
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
                MostrarTabs(1, ficPerfil, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oePerfil.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficPerfil, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficPerfil, 1)
                        End If
                        'Exit Sub
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficPerfil, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                        'Exit Sub
                End Select
            Else
                MostrarTabs(0, ficPerfil, 2)
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
                With griPerfil
                    If ValidarGrilla(griPerfil, "Trabajador") Then
                        oePerfil.Id = .ActiveRow.Cells("ID").Value
                        oePerfil = olPerfil.Obtener(oePerfil)
                        If oePerfil.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Tipo Perfil: " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oePerfil.TipoOperacion = "E"
                                olPerfil.Eliminar(oePerfil)
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
                If griPerfil.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(griPerfil)
                MyBase.Exportar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
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

            oeProcesoNegocio = New e_ProcesoNegocio
            oeProcesoNegocio.TipoOperacion = ""
            oeProcesoNegocio.Activo = True
            oeProcesoNegocio.Indicador = 1
            leProNegSel = olProcesoNegocio.Listar(oeProcesoNegocio).OrderBy(Function(it) it.Nombre).ToList
            LlenarCombo(cboProNegBus, "Nombre", leProNegSel, -1)

            oeActividadNegocio = New e_ActividadNegocio
            oeActividadNegocio.Activo = True
            oeActividadNegocio.TipoOperacion = ""
            leActNegSel = olActividadNegocio.Listar(oeActividadNegocio)

            Tiempo1.Enabled = False
            MostrarTabs(0, ficPerfil)
            ficPerfil.Tabs(2).Enabled = False
            InicializaTiempo()
            lePerfil = New List(Of e_Perfil)
            CargarPerfil(lePerfil)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        oePerfil.Modificado = True
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        oePerfil.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        oePerfil.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oePerfil.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        oePerfil.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oePerfil.Nombre = txtNombre.Text
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oePerfil.Activo = verActivo.Checked
    End Sub

    Private Sub griPerfil_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griPerfil.DoubleClick
        If griPerfil.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub cboProcesoNegocio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProcesoNegocio.ValueChanged
        Try
            If cboProcesoNegocio.SelectedIndex > -1 Then
                Dim _leACAux = leAccionSistema.Where(Function(it) it.UsuarioCreacion = cboProcesoNegocio.Value).ToList
                LlenarCombo(cboAccionSistema, "Nombre", _leACAux, -1)
            Else
                Dim _le As New List(Of e_AccionSistema)
                LlenarCombo(cboAccionSistema, "Nombre", _le, -1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboAccionSistema_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAccionSistema.ValueChanged
        Try
            If cboAccionSistema.SelectedIndex > -1 Then
                Dim _leANAux = leActividadNegocio.Where(Function(it) it.IdProcesoNegocio = cboProcesoNegocio.Value And it.UsuarioCreacion = cboAccionSistema.Value).ToList
                CargarActividadNegocio(_leANAux)
                RemarcarActividadRU()
            Else
                CargarActividadNegocio(New List(Of e_ActividadNegocio))
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griActividadRestringida_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griActividadRestringida.CellChange
        Try
            If _BandValida Then
                With griActividadRestringida
                    If .ActiveRow.Index > -1 Then
                        .UpdateData()
                        oeARUsuario = New e_ActividadRestringida_Usuario
                        oeARUsuario.IdActividadRestringida = .ActiveRow.Cells("Id").Value
                        oeARUsuario.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If .ActiveRow.Cells("Selec").Value Then
                            If Not leARUsuario.Contains(oeARUsuario) Then
                                oeARUsuario.TipoOperacion = "I"
                                oeARUsuario.Activo = True
                                oeARUsuario.ActividadRestringida = .ActiveRow.Cells("Nombre").Value
                                oeARUsuario.IdUsuario = oeUsuario.Id
                                oeARUsuario.AccionSistema = cboAccionSistema.Text
                                leARUsuario.Add(oeARUsuario)
                            Else
                                oeARUsuario = leARUsuario.Item(leARUsuario.IndexOf(oeARUsuario))
                                If Not oeARUsuario.Activo Then
                                    oeARUsuario.TipoOperacion = "A"
                                    oeARUsuario.Activo = True
                                Else
                                    Throw New Exception("La Actividad: " & .ActiveRow.Cells("Nombre").Value & " ya esta agregada")
                                End If
                            End If
                        Else
                            oeARUsuario = leARUsuario.Item(leARUsuario.IndexOf(oeARUsuario))
                            oeARUsuario.Activo = False
                            oeARUsuario.TipoOperacion = "E"
                        End If
                    End If
                End With
                CargarActividadRestringidaU(leARUsuario)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griUsuario_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griUsuario.DoubleClick
        Try
            If griUsuario.Rows.Count > 0 Then
                oeUsuario = New e_Usuario
                oeUsuario.Id = griUsuario.ActiveRow.Cells("Id").Value
                oeUsuario.IndCompleto = True
                oeUsuario = olUsuario.Obtener(oeUsuario)
                leARUsuario = oeUsuario.leARUsuario
                CargarActividadRestringidaU(leARUsuario)
                griActividadRestringidaUsuario.Text = "Actividades Restringidas al Usuario: " & oeUsuario.oePersona.NombreCompleto
                cboProcesoNegocio.SelectedIndex = -1
                cboAccionSistema.SelectedIndex = -1
                cboProcesoNegocio.Enabled = True
                cboAccionSistema.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGrabar.Click
        Try
            olARUsuario.GuardarLista(leARUsuario)
            If MessageBox.Show("¿Desea Continuar agregando Restrinciones a Usuario?", _
                               "Mensaje Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                cboProcesoNegocio.SelectedIndex = -1
                cboAccionSistema.SelectedIndex = -1
                leARUsuario = New List(Of e_ActividadRestringida_Usuario)
                CargarActividadRestringidaU(leARUsuario)
            Else
                ficPerfil.Tabs(2).Enabled = True
                MostrarTabs(0, ficPerfil)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiAplicarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAplicarTodo.Click
        Try
            If griUsuario.Rows.Count > 0 Then
                Dim leARAAux As New List(Of e_ActividadRestringida_Usuario)
                For Each row In griUsuario.Rows
                    For Each row2 In griActividadRestringidaUsuario.Rows
                        oeARUsuario = New e_ActividadRestringida_Usuario
                        oeARUsuario.TipoOperacion = "I"
                        oeARUsuario.IdUsuario = row.Cells("Id").Value
                        oeARUsuario.IdActividadRestringida = row2.Cells("IdActividadRestringida").Value
                        oeARUsuario.Activo = True
                        oeARUsuario.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leARAAux.Add(oeARUsuario)
                    Next
                Next
                olARUsuario.GuardarLista2(leARAAux)
                mensajeEmergente.Confirmacion("Los datos se guardaron correctamente!!!!", True)
                MostrarTabs(0, ficPerfil)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProNegBus_ValueChanged(sender As Object, e As EventArgs) Handles cboProNegBus.ValueChanged
        Try
            If cboProNegBus.SelectedIndex > -1 Then
                Dim _leActividadProceso = leActNegSel.Where(Function(it) it.IdProcesoNegocio = cboProNegBus.Value).ToList
                CargarActividadProceso(_leActividadProceso)
                CargarPerfilAN(leDetalle)
                _BandValida = False
                RemarcarActividad()
                _BandValida = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griActNegSel_CellChange(sender As Object, e As CellEventArgs) Handles griActNegSel.CellChange
        Try
            If _BandValida Then
                With griActNegSel
                    If .ActiveRow.Index > -1 Then
                        .UpdateData()
                        oeDetalle = New e_PerfilActividadNegocio
                        oeDetalle.IdActividadNegocio = .ActiveRow.Cells("Id").Value
                        oeDetalle.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If .ActiveRow.Cells("Selec").Value Then
                            If Not leDetalle.Contains(oeDetalle) Then
                                oeDetalle.TipoOperacion = "I"
                                oeDetalle.Activo = True
                                oeDetalle.ActividadNegocio = .ActiveRow.Cells("Nombre").Value
                                oeDetalle.ProcesoNegocio = cboProNegBus.Text
                                oeDetalle.IdProcesoNegocio = cboProNegBus.Value
                                oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
                                leDetalle.Add(oeDetalle)
                            Else
                                oeDetalle = leDetalle.Item(leDetalle.IndexOf(oeDetalle))
                                If Not oeDetalle.Activo Then
                                    oeDetalle.TipoOperacion = "A"
                                    oeDetalle.UsuarioModifica = gUsuarioSGI.Id
                                    oeDetalle.Activo = True
                                Else
                                    Throw New Exception("La Actividad: " & .ActiveRow.Cells("Nombre").Value & " ya esta agregada")
                                End If
                            End If
                        Else
                            oeDetalle = leDetalle.Item(leDetalle.IndexOf(oeDetalle))
                            oeDetalle.Activo = False
                            oeDetalle.TipoOperacion = "E"
                            oeDetalle.UsuarioModifica = gUsuarioSGI.Id
                        End If
                    End If
                End With
                CargarPerfilAN(leDetalle)
                griActividadNegocio.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oePerfil = New e_Perfil
            With griPerfil
                oePerfil.Activo = True
                lePerfil = olPerfil.Listar(oePerfil).OrderBy(Function(item) item.Nombre).ToList
                CargarPerfil(lePerfil)
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
            ficPerfil.Tabs(2).Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griPerfil.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        verActivo.Checked = True
        leDetalle = New List(Of e_PerfilActividadNegocio)
        CargarPerfilAN(leDetalle)
        AsociarMenu()
        cboProNegBus.SelectedIndex = -1
        CargarActividadProceso(New List(Of e_ActividadNegocio))
    End Sub

    Private Sub Mostrar()
        Try
            If griPerfil.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oePerfil.Id = griPerfil.ActiveRow.Cells("Id").Value.ToString
                oePerfil = olPerfil.Obtener(oePerfil)
                txtCodigo.Text = oePerfil.Codigo
                txtNombre.Text = oePerfil.Nombre
                txtAbreviatura.Text = oePerfil.Abreviatura
                verActivo.Checked = oePerfil.Activo
                leDetalle = oePerfil.lePerfilActividadNegocio
                MostrarTabs(1, ficPerfil, 1)
                ficPerfil.Tabs(2).Enabled = False
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oePerfil.lePerfilActividadNegocio = leDetalle
            oePerfil.UsuarioCreacion = gUsuarioSGI.Id
            oePerfil.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olPerfil.Guardar(oePerfil) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, ficPerfil, 2)
                Consultar(_Activo)
                griPerfil.Focus()
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
    End Sub

    Private Function BuscaId(ByVal oePATemp As e_PerfilActividadNegocio) As Boolean
        Try
            Dim band As Boolean = False
            If oePATemp.IdActividadNegocio = idPA Then
                band = True
            End If
            Return band
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Function

    Private Sub CargarUsuarioPerfil(ByVal leUsu As List(Of e_Usuario))
        Try
            With griUsuario
                .ResetDisplayLayout()
                Dim _leAux = From oe In leUsu _
                             Select oe.Id, oe.Login, oe.oePersona.NombreCompleto, Area = oe.oeArea.Nombre _
                             Order By NombreCompleto
                .DataSource = _leAux.ToList
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Login").Width = 80
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 200
                .DisplayLayout.Bands(0).Columns("Area").Width = 200
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
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

    Private Sub CargarCombo()
        Try

            oeProcesoNegocio = New e_ProcesoNegocio
            oeProcesoNegocio.Activo = True
            oeProcesoNegocio.TipoOperacion = "P"
            oeProcesoNegocio.Id = idPerfil
            leProcesoNegocio = olProcesoNegocio.Listar(oeProcesoNegocio)
            LlenarCombo(cboProcesoNegocio, "Nombre", leProcesoNegocio, -1)

            oeAccionSistema = New e_AccionSistema
            oeAccionSistema.Activo = True
            oeAccionSistema.TipoOperacion = "P"
            oeAccionSistema.Descripcion = idPerfil
            leAccionSistema = olAccionSistema.Listar(oeAccionSistema)

            oeActividadNegocio = New e_ActividadNegocio
            oeActividadNegocio.Activo = True
            oeActividadNegocio.TipoOperacion = "P"
            oeActividadNegocio.Id = idPerfil
            leActividadNegocio = olActividadNegocio.Listar(oeActividadNegocio)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarActividadNegocio(ByVal leAN As List(Of e_ActividadNegocio))
        Try
            With griActividadRestringida

                .ResetDisplayLayout()
                .DataSource = leAN

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 60

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key = "Selec" Then
                        col.CellClickAction = CellClickAction.Edit
                    Else
                        col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                OcultarColumna(griActividadRestringida, True, "Id", "IdProcesoNegocio", "Abreviatura", "UsuarioCreacion", "FechaCreacion", "Activo")

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 80
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 400

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarActividadRestringidaU(ByVal leARU As List(Of e_ActividadRestringida_Usuario))
        Try
            With griActividadRestringidaUsuario
                Dim _leAux = leARU.Where(Function(it) it.Activo = True).ToList
                .DataSource = _leAux
                .Text = "Actividad Negocio Asociada"

                OcultarColumna(griActividadRestringidaUsuario, True, "Id", "IdActividadRestringida", "IdUsuario", "FechaCreacion", "Activo", "IdProcesoNegocio")

                .DisplayLayout.Bands(0).Columns("AccionSistema").Width = 250
                .DisplayLayout.Bands(0).Columns("ActividadRestringida").Width = 400

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
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

    Private Sub RemarcarActividadRU()
        Try
            If leARUsuario.Count > 0 Then
                For Each Fila In griActividadRestringida.Rows
                    Dim _idan = Fila.Cells("Id").Value
                    Dim _leARAux = leARUsuario.Where(Function(it) it.Activo = True And it.IdActividadRestringida = _idan).ToList
                    If _leARAux.Count > 0 Then Fila.Cells("Selec").Value = True
                Next
                griActividadRestringida.UpdateData()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPerfil(_lePerfil As List(Of e_Perfil))
        Try
            With griPerfil

                .DataSource = _lePerfil

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 120
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 400

                OcultarColumna(griPerfil, True, "Id", "FechaCreacion", "UsuarioCreacion", "Abreviatura", "Activo")

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

    Private Sub SelecionarTab(_index As Integer)
        ficPerfil.Tabs(0).Enabled = False
        ficPerfil.Tabs(1).Enabled = False
        ficPerfil.Tabs(2).Enabled = False
        ficPerfil.Tabs(_index).Enabled = True
        ficPerfil.Tabs(_index).Selected = True
    End Sub

    Private Sub CargarActividadProceso(ByVal leAP As List(Of e_ActividadNegocio))
        Try
            With griActNegSel

                .ResetDisplayLayout()
                .Text = "Actividad de Negocio de Proceso: " & IIf(cboProNegBus.SelectedIndex > -1, cboProNegBus.Text, "")
                .DataSource = leAP.OrderBy(Function(i) i.Codigo).ToList

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 60

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key = "Selec" Then
                        col.CellClickAction = CellClickAction.Edit
                    Else
                        col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                OcultarColumna(griActNegSel, True, "Id", "IdProcesoNegocio", "Abreviatura", "UsuarioCreacion", "FechaCreacion", "Activo")

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 80
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 400

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPerfilAN(ByVal lePerfilAN As List(Of e_PerfilActividadNegocio))
        Try
            With griActividadNegocio

                Dim _leAux As New List(Of e_PerfilActividadNegocio)
                If cboProNegBus.SelectedIndex > -1 Then
                    _leAux = lePerfilAN.Where(Function(it) it.Activo = True And it.IdProcesoNegocio = cboProNegBus.Value).ToList
                End If

                .DataSource = _leAux

                .Text = "Actividad Negocio Asociada"

                OcultarColumna(griActividadNegocio, True, "Id", "IdActividadNegocio", "IdPerfil", "Perfil", "UsuarioCreacion", _
                               "Descripcion", "IdProcesoNegocio", "FechaCreacion", "Activo", "FechaModifica", "UsuarioModifica")

                .DisplayLayout.Bands(0).Columns("ProcesoNegocio").Width = 200
                .DisplayLayout.Bands(0).Columns("ActividadNegocio").Width = 400

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
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

    Private Sub RemarcarActividad()
        Try
            If leDetalle.Count > 0 Then
                For Each Fila In griActNegSel.Rows
                    Dim _idan = Fila.Cells("Id").Value
                    Dim _leARAux = leDetalle.Where(Function(it) it.Activo = True And it.IdActividadNegocio = _idan).ToList
                    If _leARAux.Count > 0 Then Fila.Cells("Selec").Value = True
                Next
                griActNegSel.UpdateData()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griPerfil.ContextMenuStrip = MenuContextual1
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

    Private Sub tsmiAcciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAcciones.Click
        Try
            If griPerfil.Selected.Rows.Count > 0 Then
                SelecionarTab(2)
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
                idPerfil = griPerfil.ActiveRow.Cells("Id").Value
                oeUsuario = New e_Usuario
                oeUsuario.TipoOperacion = "P" : oeUsuario.Codigo = idPerfil
                leUsuario = olUsuario.Listar(oeUsuario)
                CargarUsuarioPerfil(leUsuario)
                cboAccionSistema.SelectedIndex = -1
                CargarCombo()
                cboProcesoNegocio.Enabled = False
                cboAccionSistema.Enabled = False
                leARUsuario = New List(Of e_ActividadRestringida_Usuario)
                CargarActividadRestringidaU(leARUsuario)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("tsmiNuevo").Enabled = True
        MenuContextual1.Items("tsmiEditar").Enabled = IIf(griPerfil.Selected.Rows.Count > 0, True, False)
        MenuContextual1.Items("tsmiEliminar").Enabled = IIf(griPerfil.Selected.Rows.Count > 0, True, False)
        MenuContextual1.Items("tsmiExportar").Enabled = IIf(griPerfil.Rows.Count > 0, True, False)
        MenuContextual1.Items("tsmiAcciones").Enabled = IIf(griPerfil.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub MenuContextual2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual2.Opening
        'If griActividadRestringidaUsuario.Rows.Count > 0 Then
        '    MenuContextual2.Items("tsmiGrabar").Visible = True
        '    MenuContextual2.Items("tsmiAplicarTodo").Visible = True
        'Else
        '    MenuContextual2.Items("tsmiGrabar").Visible = False
        '    MenuContextual2.Items("tsmiAplicarTodo").Visible = False
        'End If
    End Sub

#End Region

    Private Sub frm_Perfil_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Case Else
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
        End Select
    End Sub
End Class