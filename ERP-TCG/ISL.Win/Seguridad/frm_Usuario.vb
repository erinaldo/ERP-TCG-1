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

Public Class frm_Usuario
    Inherits frm_MenuPadre

#Region "Inicializa"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Usuario = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Usuario()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Definicion de Variables"
    Private oeUsuario As New e_Usuario, olUsuario As New l_Usuario, leUsuario As New List(Of e_Usuario)
    Private olUsuarioPerfil As New List(Of e_UsuarioPerfil)
    Private olUsuarioSucursal As New List(Of e_UsuarioSucursal) '@0001
    Private olTurnoUsuario As New List(Of e_TurnoUsuario)
    Private oePerfil As New e_Perfil, olPerfil As New l_Perfil
    Private oeCentro As New e_Centro, olCentro As New l_Centro '@0001
    Private oeTurno As New e_Turno, olTurno As New l_Turno
    Private oeControlTU As New e_ControlTurnoUsuario
    Private olPersona As New l_Persona
    Dim _ingresando_datos As Boolean = False
    Dim idUP As String
    Dim idU As String
    Private _opeUsu As String = "", _acl As String = ""
#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griUsuario.Rows.Count > 0 Then
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
                oeUsuario = New e_Usuario
                oeUsuario.TipoOperacion = "I"
                MostrarTabs(1, ficUsuario, 1)
                Inicializar()
                txtDni.Text = String.Empty
                txtDni.Focus()
                txtCodigo.Text = ObtieneCodigo()
                agrListaPerfil.Expanded = True
                agrListaTurno.Expanded = True
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
                Inicializar()
                Mostrar()
                oeUsuario.TipoOperacion = "A"
                txtDni.Focus()
                'Habilitar(IIf(Not PerfilIdAsignado("1CH000000001"), False, True))
                agrListaPerfil.Expanded = False
                agrListaCentro.Expanded = False
                agrListaTurno.Expanded = False
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
            LlenarDatos()
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficUsuario, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeUsuario.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficUsuario, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficUsuario, 1)
                        End If
                        'Exit Sub
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficUsuario, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                        'Exit Sub
                End Select
            Else
                MostrarTabs(0, ficUsuario, 2)
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
            'If Not PerfilIdAsignado("1CH000000001") Then Throw New Exception("Usted no tiene permiso para realizar esta operacion")
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                With griUsuario
                    If ValidarGrilla(griUsuario, "Usuario") Then
                        oeUsuario.Id = .ActiveRow.Cells("ID").Value
                        oeUsuario = olUsuario.Obtener(oeUsuario)
                        If oeUsuario.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Usuario: " & _
                                     .ActiveRow.Cells("NombreCompleto").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                     MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeUsuario.TipoOperacion = "E"
                                olUsuario.Eliminar(oeUsuario)
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
                If griUsuario.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(griUsuario)
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

    Private Sub frm_Usuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            MostrarTabs(0, ficUsuario)
            InicializaTiempo()
            CargarUsuario(leUsuario)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Usuario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub griUsuario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Editar()
    End Sub

    Private Sub txtDni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDni.KeyDown
        oeUsuario.Modificado = True
    End Sub

    Private Sub txtDni_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDni.ValueChanged
        oeUsuario.oePersona.Dni = txtDni.Text.Trim
        If oeUsuario.TipoOperacion = "I" Then
            If txtDni.Text.Length = 8 Then
                'Obtiene y muestra los datos personales del trabajador, si ya está registrado como persona
                Dim oePersona As New e_Persona
                oePersona.Dni = oeUsuario.oePersona.Dni
                Dim olPersona As New l_Persona
                oePersona.CargaCompleta = True
                oePersona = olPersona.Obtener(oePersona)
                If Not String.IsNullOrEmpty(oePersona.Id) Then

                    oeUsuario.oePersona.Id = oePersona.Id
                    oeUsuario.oePersona.ApellidoPaterno = oePersona.ApellidoPaterno
                    oeUsuario.oePersona.ApellidoMaterno = oePersona.ApellidoMaterno
                    oeUsuario.oePersona.Nombre = oePersona.Nombre
                    oeUsuario.oePersona.FechaNacimiento = oePersona.FechaNacimiento
                    oeUsuario.oePersona.oeSexo = oePersona.oeSexo
                    oeUsuario.oePersona.Dni = oePersona.Dni

                    Dim oeTemp As New e_Usuario
                    oeTemp.TipoOperacion = "D"
                    oeTemp.oePersona.Dni = oeUsuario.oePersona.Dni
                    oeTemp = olUsuario.Obtener2(oeTemp)
                    If Not String.IsNullOrEmpty(oeTemp.Id) Then
                        oeUsuario.TipoOperacion = "A"
                        oeUsuario.Id = oeTemp.Id
                        oeUsuario.Codigo = oeTemp.Codigo
                        oeUsuario.Login = oeTemp.Login
                        oeUsuario.Clave = oeTemp.Clave
                        oeUsuario.Activo = oeTemp.Activo
                        oeUsuario.Controlado = oeTemp.Controlado
                        oeUsuario.leUsuarioPerfil = oeTemp.leUsuarioPerfil
                    End If

                    'Actualiza los textos con los datos de la persona obtenidos desde el DNI
                    CargaDatosPersonales()

                End If
                'If Not String.IsNullOrEmpty(oeUsuario.oePersona.Dni) Then PictureBox1.Image = olPersona.Foto(oeUsuario.oePersona.Dni)
            Else
                Inicializar()
            End If
        End If
    End Sub

    Private Sub txtApellidoPaterno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoPaterno.KeyDown
        oeUsuario.Modificado = True
    End Sub

    Private Sub txtApellidoPaterno_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoPaterno.ValueChanged
        oeUsuario.oePersona.ApellidoPaterno = txtApellidoPaterno.Text.Trim
    End Sub

    Private Sub txtApellidoMaterno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoMaterno.KeyDown
        oeUsuario.Modificado = True
    End Sub

    Private Sub txtApellidoMaterno_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoMaterno.ValueChanged
        oeUsuario.oePersona.ApellidoMaterno = txtApellidoMaterno.Text.Trim
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        oeUsuario.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeUsuario.oePersona.Nombre = txtNombre.Text.Trim
        If txtNombre.Text.Trim <> "" Then
            txtLogin.Text = fs_devNomUsuario(txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombre.Text)
        End If
    End Sub

    Private Sub txtEstadoCivil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        oeUsuario.Modificado = True
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        oeUsuario.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeUsuario.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLogin.KeyDown
        oeUsuario.Modificado = True
    End Sub

    Private Sub txtLogin_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLogin.ValueChanged
        oeUsuario.Login = txtLogin.Text.Trim
    End Sub

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        oeUsuario.Modificado = True
    End Sub

    Private Sub txtClave_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClave.ValueChanged
        oeUsuario.Clave = txtClave.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeUsuario.Activo = verActivo.Checked
    End Sub

    Private Sub griUsuario_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)
        agrTotalUsuarios.Text = "Total de Usuarios: " & griUsuario.Rows.Count
    End Sub

    Private Sub Sexo1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sexo1.Validated
        oeUsuario.oePersona.oeSexo.Nombre = Sexo1.Sexo.Nombre
    End Sub

    Private Sub fecNacimiento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fecNacimiento.KeyDown
        oeUsuario.Modificado = True
    End Sub

    Private Sub fecNacimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecNacimiento.ValueChanged
        oeUsuario.oePersona.FechaNacimiento = fecNacimiento.Value
    End Sub

    Private Sub griUsuario_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griUsuario.DoubleClick
        If griUsuario.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griPerfil_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griPerfil.CellChange
        Try
            With griPerfil
                If .ActiveRow.Cells("Principal").Activated Then
                    Dim oeUsuarioPerfil As New e_UsuarioPerfil
                    olUsuarioPerfil = oeUsuario.leUsuarioPerfil
                    oeUsuarioPerfil.oePerfil.Id = .ActiveRow.Cells("IdPerfil").Value
                    oeUsuarioPerfil = olUsuarioPerfil.Item(olUsuarioPerfil.IndexOf(oeUsuarioPerfil))
                    oeUsuarioPerfil.Principal = Not .ActiveRow.Cells("Principal").Value
                    For Each fila As UltraWinGrid.UltraGridRow In .Rows
                        If fila.Cells("IdPerfil").Value <> oeUsuarioPerfil.oePerfil.Id Then fila.Cells("Principal").Value = False
                    Next
                    .DataBind()
                    .UpdateData()
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griPerfilder_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griPerfilder.CellChange
        Try
            With griPerfilder
                .UpdateData()
                If .ActiveRow.Cells("Selec").Activated Then
                    Dim oeUsuarioPerfil As New e_UsuarioPerfil
                    olUsuarioPerfil = oeUsuario.leUsuarioPerfil

                    oeUsuarioPerfil.oePerfil.Id = .ActiveRow.Cells("Id").Value

                    If Not olUsuarioPerfil.Contains(oeUsuarioPerfil) Then
                        If .ActiveRow.Cells("Selec").Value Then
                            oeUsuarioPerfil.oeUsuario.Id = oeUsuario.Id
                            oeUsuarioPerfil.oePerfil.Nombre = .ActiveRow.Cells("Nombre").Value
                            If griPerfil.Rows.Count < 1 Then
                                LlenarPerfil(olUsuarioPerfil)
                                'oeOcupacionTrabajador.Principal = True
                            End If

                            olUsuarioPerfil.Add(oeUsuarioPerfil)

                        End If
                    Else
                        oeUsuarioPerfil = olUsuarioPerfil.Item(olUsuarioPerfil.IndexOf(oeUsuarioPerfil))
                        If .ActiveRow.Cells("Selec").Value Then
                            If oeUsuarioPerfil.TipoOperacion = "E" Then
                                oeUsuarioPerfil.TipoOperacion = ""
                                For Each fila As UltraWinGrid.UltraGridRow In griPerfil.Rows
                                    If fila.Cells("IdPerfil").Value = oeUsuarioPerfil.oePerfil.Id Then
                                        fila.Hidden = False
                                        Exit For
                                    End If
                                Next
                            Else
                                Throw New Exception("El Perfil: " & .ActiveRow.Cells("Nombre").Value & " ya esta Asignada")
                            End If

                        Else
                            If oeUsuarioPerfil.Id <> "" Then
                                oeUsuarioPerfil.TipoOperacion = "E"
                                For Each fila As UltraWinGrid.UltraGridRow In griPerfil.Rows
                                    If fila.Cells("IdPerfil").Value = oeUsuarioPerfil.oePerfil.Id Then
                                        fila.Hidden = True
                                        Exit For
                                    End If
                                Next
                            Else
                                olUsuarioPerfil.Remove(oeUsuarioPerfil)
                            End If

                        End If

                    End If

                End If

            End With
            LlenarPerfil(olUsuarioPerfil)
            griPerfil.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaTurno_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaTurno.CellChange
        Try
            With griListaTurno
                .UpdateData()
                If .ActiveRow.Cells("Selec").Activated Then
                    Dim oeTurnoUsuario As New e_TurnoUsuario
                    olTurnoUsuario = oeUsuario.leTurnoUsuario

                    oeturnoUsuario.IdTurno = .ActiveRow.Cells("Id").Value

                    If Not olTurnoUsuario.Contains(oeTurnoUsuario) Then
                        If .ActiveRow.Cells("Selec").Value Then
                            oeTurnoUsuario.IdUsuario = oeUsuario.Id
                            oeTurnoUsuario.HoraInicio = .ActiveRow.Cells("HoraInicio").Value
                            oeTurnoUsuario.HoraSalida = .ActiveRow.Cells("HoraSalida").Value
                            oeTurnoUsuario.Dia = .ActiveRow.Cells("Dia").Value
                            oeTurnoUsuario.Turno = .ActiveRow.Cells("Turno").Value
                            If griTurno.Rows.Count < 1 Then
                                LlenarTurno(olTurnoUsuario)
                                'oeOcupacionTrabajador.Principal = True
                            End If

                            olTurnoUsuario.Add(oeTurnoUsuario)

                        End If
                    Else
                        oeTurnoUsuario = olTurnoUsuario.Item(olTurnoUsuario.IndexOf(oeTurnoUsuario))
                        If .ActiveRow.Cells("Selec").Value Then
                            If oeTurnoUsuario.TipoOperacion = "E" Then
                                oeTurnoUsuario.TipoOperacion = ""
                                For Each fila As UltraWinGrid.UltraGridRow In griTurno.Rows
                                    If fila.Cells("IdTurno").Value = oeTurnoUsuario.IdTurno Then
                                        fila.Hidden = False
                                        Exit For
                                    End If
                                Next
                            Else
                                Throw New Exception("El Turno: " & .ActiveRow.Cells("IdTurno").Value & " ya esta Asignada")
                            End If

                        Else
                            If oeTurnoUsuario.Id <> "" Then
                                oeTurnoUsuario.TipoOperacion = "E"
                                For Each fila As UltraWinGrid.UltraGridRow In griTurno.Rows
                                    If fila.Cells("Idturno").Value = oeTurnoUsuario.IdTurno Then
                                        fila.Hidden = True
                                        Exit For
                                    End If
                                Next
                            Else
                                olTurnoUsuario.Remove(oeTurnoUsuario)
                            End If

                        End If

                    End If

                End If

            End With
            griTurno.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub verLanzaAlerta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verLanzaAlerta.CheckedChanged
        oeControlTU.LanzaAlerta = verLanzaAlerta.Checked
        numIntervalo.Enabled = verLanzaAlerta.Checked
        numTiempoAlerta.Enabled = verLanzaAlerta.Checked
    End Sub

    Private Sub verCierreAutomatico_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verCierreAutomatico.CheckedChanged
        oeControlTU.CierreAutomatico = verCierreAutomatico.Checked
    End Sub

    Private Sub numIntervalo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numIntervalo.ValueChanged
        oeControlTU.Intervalo = numIntervalo.Value
    End Sub

    Private Sub numTiempoAlerta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numTiempoAlerta.ValueChanged
        oeControlTU.TiempoAlerta = numTiempoAlerta.Value
    End Sub

    Private Sub verControlado_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verControlado.CheckedChanged
        oeUsuario.Controlado = IIf(verControlado.Checked, 1, 0)
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal v_activo As Boolean)
        Try
            oeUsuario = New e_Usuario
            With griUsuario
                oeUsuario.Activo = True
                oeUsuario.Controlado = -1
                leUsuario = olUsuario.Listar(oeUsuario)
                CargarUsuario(leUsuario)
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griUsuario.Focus()
    End Sub

    Private Sub Inicializar()
        Try
            txtCodigo.Text = String.Empty
            txtApellidoPaterno.Text = String.Empty
            txtApellidoMaterno.Text = String.Empty
            txtNombre.Text = String.Empty
            txtLogin.Text = String.Empty
            txtClave.Text = String.Empty
            fecNacimiento.Value = Date.Now.Date
            PictureBox1.Image = Nothing
            verActivo.Checked = True
            LimpiaGrid(griPerfil, ordPerfil)
            LlenarTurno(New List(Of e_TurnoUsuario))
            ListarPerfil()
            ListarTurno()
            AsociarMenu()
            oeControlTU = New e_ControlTurnoUsuario
            LimpiaGrid(griCentro, ordCentro)
            ListarSucursal() '@0001
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub Mostrar()
        Try
            If griUsuario.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeUsuario = New e_Usuario
                oeUsuario.TipoOperacion = ""
                oeUsuario.Id = griUsuario.ActiveRow.Cells("Id").Value.ToString
                oeUsuario.IndCompleto = True
                oeUsuario = olUsuario.Obtener(oeUsuario)
                CargaDatosPersonales()
                'If Not String.IsNullOrEmpty(oeUsuario.oePersona.Dni) Then PictureBox1.Image = olPersona.Foto(oeUsuario.oePersona.Dni)
                MostrarTabs(1, ficUsuario, 1)
                ficDetalle.Tabs("Perfil").Selected = True
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            'LlenarPerfil()
            oeUsuario.oePersona.oeSexo.Id = Sexo1.Sexo.Id
            oeUsuario.leUsuarioPerfil = olUsuarioPerfil
            oeUsuario.leUsuarioSucursal = olUsuarioSucursal
            oeUsuario.leTurnoUsuario = olTurnoUsuario
            oeUsuario.oeControlTurnoUsuario = oeControlTU
            oeUsuario.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeUsuario.oeControlTurnoUsuario.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeUsuario.oeArea.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeUsuario.oePersona.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olUsuario.Guardar(oeUsuario) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficUsuario, 2)
                Consultar(_Activo)
                griUsuario.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("Apellido Paterno") Then
            txtApellidoPaterno.Focus()
        End If
        If excepcion.Contains("Apellido Materno") Then
            txtApellidoMaterno.Focus()
        End If
        If excepcion.Contains("Nombre") Then
            txtNombre.Focus()
        End If
    End Sub

    Private Sub LlenarDatos()
        Dim oePersona As New e_Persona
        With oePersona
            .TipoOperacion = oeUsuario.TipoOperacion
            .Activo = verActivo.Checked
            .Id = oeUsuario.oePersona.Id
            .Codigo = oeUsuario.oePersona.Codigo
        End With
        Dim oeUsuarioTemp As New e_Usuario(oePersona)
        With oeUsuarioTemp
            .Id = oeUsuario.Id
            .oePersona.Dni = oeUsuario.oePersona.Dni
            .oePersona.Id = oeUsuario.oePersona.Id
            .oePersona.ApellidoPaterno = oeUsuario.oePersona.ApellidoPaterno
            .oePersona.ApellidoMaterno = oeUsuario.oePersona.ApellidoMaterno
            .oePersona.Nombre = oeUsuario.oePersona.Nombre
            .oePersona.FechaNacimiento = oeUsuario.oePersona.FechaNacimiento
            .oePersona.oeSexo = oeUsuario.oePersona.oeSexo
            .Codigo = oeUsuario.Codigo
            .Login = oeUsuario.Login
            .Clave = oeUsuario.Clave
            .Activo = oeUsuario.Activo
            .TipoOperacion = oeUsuario.TipoOperacion
            .Controlado = oeUsuario.Controlado
        End With
        oeUsuario = oeUsuarioTemp
    End Sub

    Private Sub ListarPerfil()
        Try

            oePerfil = New e_Perfil
            olPerfil = New l_Perfil

            With griPerfilder

                .ResetDisplayLayout()
                .DataSource = olPerfil.Listar(oePerfil)

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 60

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Abreviatura").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 80
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

                .DisplayLayout.Bands(0).Columns("Codigo").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Nombre").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenarPerfil(ByVal lePerfilUsuario As List(Of e_UsuarioPerfil))
        Try

            With griPerfil

                Dim _leUsuAux = From le In lePerfilUsuario _
                                Select le.Id, IdPerfil = le.oePerfil.Id, Perfil = le.oePerfil.Nombre, le.Principal

                .DataSource = _leUsuAux.ToList

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPerfil").Hidden = True

                .DisplayLayout.Bands(0).Columns("Principal").Style = UltraWinGrid.ColumnStyle.CheckBox

                .DisplayLayout.Bands(0).Columns("Perfil").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit


            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MostrarPerfil()
        Try
            If oeUsuario.leUsuarioPerfil.Count > 0 Then

                LlenarPerfil(oeUsuario.leUsuarioPerfil)

                For Each oe As e_UsuarioPerfil In oeUsuario.leUsuarioPerfil
                    For Each Fila As UltraWinGrid.UltraGridRow In griPerfilder.Rows
                        If Fila.Cells("Id").Value = oe.oePerfil.Id And oe.Activo Then
                            Fila.Cells("Selec").Value = True
                            Exit For
                        End If
                    Next
                Next

                griPerfilder.UpdateData()

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CargaDatosPersonales()
        Try

            txtCodigo.Text = oeUsuario.Codigo
            txtApellidoPaterno.Text = oeUsuario.oePersona.ApellidoPaterno
            txtApellidoMaterno.Text = oeUsuario.oePersona.ApellidoMaterno
            txtNombre.Text = oeUsuario.oePersona.Nombre
            txtDni.Text = oeUsuario.oePersona.Dni
            txtLogin.Text = oeUsuario.Login
            txtClave.Text = oeUsuario.Clave
            fecNacimiento.Value = oeUsuario.oePersona.FechaNacimiento
            Sexo1.Sexo = New e_Sexo(CType(oeUsuario.oePersona.oeSexo.Id, String))
            verControlado.Checked = IIf(oeUsuario.Controlado = 1, True, False)
            verActivo.Checked = oeUsuario.Activo
            olUsuarioPerfil = oeUsuario.leUsuarioPerfil
            olTurnoUsuario = oeUsuario.leTurnoUsuario
            olUsuarioSucursal = oeUsuario.leUsuarioSucursal '@0001
            verCierreAutomatico.Checked = oeUsuario.oeControlTurnoUsuario.CierreAutomatico
            verLanzaAlerta.Checked = oeUsuario.oeControlTurnoUsuario.LanzaAlerta
            numIntervalo.Value = oeUsuario.oeControlTurnoUsuario.Intervalo
            numTiempoAlerta.Value = oeUsuario.oeControlTurnoUsuario.TiempoAlerta

            oeControlTU = oeUsuario.oeControlTurnoUsuario

            MostrarPerfil()
            MostrarTurno()
            MostrarSucursal() '@0001
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ListarTurno()
        Try

            oeTurno = New e_Turno
            olTurno = New l_Turno

            griListaTurno.ResetDisplayLayout()
            griListaTurno.DataSource = olTurno.Listar(oeTurno)

            griListaTurno.DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
            griListaTurno.DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
            griListaTurno.DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
            griListaTurno.DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
            griListaTurno.DisplayLayout.Bands(0).Columns("Selec").Width = 60

            griListaTurno.DisplayLayout.Bands(0).Columns("Id").Hidden = True
            griListaTurno.DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            griListaTurno.DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
            griListaTurno.DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

            griListaTurno.DisplayLayout.Bands(0).Columns("HoraInicio").Width = 80
            griListaTurno.DisplayLayout.Bands(0).Columns("HoraSalida").Width = 80
            griListaTurno.DisplayLayout.Bands(0).Columns("Dia").Width = 80
            griListaTurno.DisplayLayout.Bands(0).Columns("Turno").Width = 80

            griListaTurno.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            griListaTurno.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

            griListaTurno.DisplayLayout.Bands(0).Columns("HoraInicio").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            griListaTurno.DisplayLayout.Bands(0).Columns("HoraSalida").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            griListaTurno.DisplayLayout.Bands(0).Columns("Dia").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            griListaTurno.DisplayLayout.Bands(0).Columns("Turno").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenarTurno(ByVal leTurnoUsuario As List(Of e_TurnoUsuario))
        Try

            griTurno.ResetDisplayLayout()

            griTurno.DataSource = leTurnoUsuario
            griTurno.DisplayLayout.Bands(0).Columns("Id").Hidden = True
            griTurno.DisplayLayout.Bands(0).Columns("IdTurno").Hidden = True
            griTurno.DisplayLayout.Bands(0).Columns("IdUsuario").Hidden = True
            griTurno.DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            griTurno.DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
            griTurno.DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

            griTurno.DisplayLayout.Bands(0).Columns("HoraInicio").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            griTurno.DisplayLayout.Bands(0).Columns("HoraSalida").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            griTurno.DisplayLayout.Bands(0).Columns("Dia").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            griTurno.DisplayLayout.Bands(0).Columns("Turno").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MostrarTurno()
        Try
            If oeUsuario.leTurnoUsuario.Count > 0 Then
                LlenarTurno(oeUsuario.leTurnoUsuario)
                For Each oe As e_TurnoUsuario In oeUsuario.leTurnoUsuario
                    For Each Fila As UltraWinGrid.UltraGridRow In griListaTurno.Rows
                        If Fila.Cells("Id").Value = oe.IdTurno And oe.Activo Then
                            Fila.Cells("Selec").Value = True
                            Exit For
                        End If
                    Next
                Next
                griListaTurno.UpdateData()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Habilitar(ByVal Band As Boolean)
        txtDni.Enabled = Band
        txtApellidoPaterno.Enabled = Band
        txtApellidoMaterno.Enabled = Band
        txtNombre.Enabled = Band
        Sexo1.Enabled = Band
        'fecFechaNacimiento.Enabled = Band
        fecNacimiento.Enabled = Band
        txtCodigo.Enabled = Band
        txtLogin.Enabled = Band
        txtClave.Enabled = Band
        verControlado.Enabled = Band
    End Sub

    Public Function fs_devNomUsuario(ByVal ls_ApePat As String, ByVal ls_ApeMat As String, ByVal ls_Nombres As String)
        Dim ls_Cad_1 As String = "", ln_faltante As Integer = 0
        '1C Nombre + 6C ApePaterno + 1C ApeMaterno
        ls_Cad_1 = Strings.Left(ls_Nombres, 1) & Strings.Left(ls_ApePat, 6) & Strings.Left(ls_ApeMat, 1)
        ln_faltante = 8 - ls_Cad_1.Length
        'si no completa los 8C completa con caracteres de apellido materno
        ls_Cad_1 = ls_Cad_1 & Strings.Mid(ls_ApeMat, 2, ln_faltante)
        Return ls_Cad_1
    End Function

    Private Function ObtieneCodigo() As String
        Try
            Dim oe As New e_Usuario
            oe.TipoOperacion = "C"
            Return olUsuario.Obtener(oe).Codigo
        Catch ex As Exception
            'mensajeEmergente.Problema(ex.Message, True)
            Return ""
        End Try
    End Function

    Private Sub CargarUsuario(ByVal _leUsuario As List(Of e_Usuario))
        Try

            Dim leUsuarioTemp = From le In _leUsuario _
                                Select le.Id, le.oePersona.Dni, le.oePersona.NombreCompleto, le.oePersona.oeSexo.Nombre, _
                                le.Codigo, le.Login, Area = le.oeArea.Nombre, le.Controlado, le.Activo

            griUsuario.DataSource = leUsuarioTemp.ToList

            For Each col As UltraGridColumn In griUsuario.DisplayLayout.Bands(0).Columns
                If col.Key.Contains("Id") Then col.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
            Next

            griUsuario.DisplayLayout.Bands(0).Columns("Id").Hidden = True

            griUsuario.DisplayLayout.Bands(0).Columns("NombreCompleto").SortIndicator = SortOrder.Ascending

            griUsuario.DisplayLayout.Bands(0).Columns("Dni").Width = 80
            griUsuario.DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 300
            griUsuario.DisplayLayout.Bands(0).Columns("Codigo").Width = 80
            griUsuario.DisplayLayout.Bands(0).Columns("Login").Width = 80
            griUsuario.DisplayLayout.Bands(0).Columns("Area").Width = 300

            griUsuario.DisplayLayout.Bands(0).Columns("Controlado").Style = ColumnStyle.CheckBox

            griUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
            griUsuario.DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
            griUsuario.DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
            griUsuario.DisplayLayout.Override.FilterUIProvider = Filtro1
            griUsuario.DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            griUsuario.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
            griUsuario.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            griUsuario.DisplayLayout.MaxColScrollRegions = 1
            griUsuario.DisplayLayout.MaxRowScrollRegions = 1

            'Ubica el cursor el el primer registro de la grilla
            If griUsuario.Rows.Count > 0 Then
                agrTotalUsuarios.Text = "Total de Registros: " & griUsuario.Rows.Count
                griUsuario.Focus()
                griUsuario.Rows.Item(0).Selected = True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    '@0001 Inicio
    Private Sub ListarSucursal()
        Try

            oeCentro = New e_Centro
            olCentro = New l_Centro

            With griCentroder

                .ResetDisplayLayout()
                .DataSource = olCentro.Listar(oeCentro)

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 60

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdAlmacen").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdLugar").Hidden = True
                .DisplayLayout.Bands(0).Columns("Abreviatura").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 80
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

                .DisplayLayout.Bands(0).Columns("Codigo").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Nombre").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenarSucursal(ByVal leSucursalUsuario As List(Of e_UsuarioSucursal))
        Try

            With griCentro

                Dim _leUsuAux = From le In leSucursalUsuario
                                Select le.Id, IdCentro = le.oeCentro.Id, Centro = le.oeCentro.Nombre, le.Principal

                .DataSource = _leUsuAux.ToList

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
                .DisplayLayout.Bands(0).Columns("Principal").Style = UltraWinGrid.ColumnStyle.CheckBox

                .DisplayLayout.Bands(0).Columns("Centro").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit


            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MostrarSucursal()
        Try
            If oeUsuario.leUsuarioSucursal.Count > 0 Then

                LlenarSucursal(oeUsuario.leUsuarioSucursal)

                For Each oe As e_UsuarioSucursal In oeUsuario.leUsuarioSucursal
                    For Each Fila As UltraWinGrid.UltraGridRow In griCentroder.Rows
                        If Fila.Cells("Id").Value = oe.oeCentro.Id And oe.Activo Then
                            Fila.Cells("Selec").Value = True
                            Exit For
                        End If
                    Next
                Next

                griCentroder.UpdateData()

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
    '@0001 Fin
#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griUsuario.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub griCentro_CellChange(sender As Object, e As CellEventArgs) Handles griCentro.CellChange
        Try
            With griCentro
                If .ActiveRow.Cells("Principal").Activated Then
                    Dim oeUsuarioSucursal As New e_UsuarioSucursal
                    olUsuarioSucursal = oeUsuario.leUsuarioSucursal
                    oeUsuarioSucursal.oeCentro.Id = .ActiveRow.Cells("IdCentro").Value
                    oeUsuarioSucursal = olUsuarioSucursal.Item(olUsuarioSucursal.IndexOf(oeUsuarioSucursal))
                    oeUsuarioSucursal.Principal = Not .ActiveRow.Cells("Principal").Value
                    For Each fila As UltraWinGrid.UltraGridRow In .Rows
                        If fila.Cells("IdCentro").Value <> oeUsuarioSucursal.oeCentro.Id Then fila.Cells("Principal").Value = False
                    Next
                    .DataBind()
                    .UpdateData()
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griCentroder_CellChange(sender As Object, e As CellEventArgs) Handles griCentroder.CellChange
        Try
            With griCentroder
                .UpdateData()
                If .ActiveRow.Cells("Selec").Activated Then
                    Dim oeUsuarioSucursal As New e_UsuarioSucursal
                    olUsuarioSucursal = oeUsuario.leUsuarioSucursal

                    oeUsuarioSucursal.oeCentro.Id = .ActiveRow.Cells("Id").Value

                    If Not olUsuarioSucursal.Contains(oeUsuarioSucursal) Then
                        If .ActiveRow.Cells("Selec").Value Then
                            oeUsuarioSucursal.oeUsuario.Id = oeUsuario.Id
                            oeUsuarioSucursal.oeCentro.Nombre = .ActiveRow.Cells("Nombre").Value
                            If griCentro.Rows.Count < 1 Then
                                LlenarSucursal(olUsuarioSucursal)
                                'oeOcupacionTrabajador.Principal = True
                            End If

                            olUsuarioSucursal.Add(oeUsuarioSucursal)

                        End If
                    Else
                        oeUsuarioSucursal = olUsuarioSucursal.Item(olUsuarioSucursal.IndexOf(oeUsuarioSucursal))
                        If .ActiveRow.Cells("Selec").Value Then
                            If oeUsuarioSucursal.TipoOperacion = "E" Then
                                oeUsuarioSucursal.TipoOperacion = ""
                                For Each fila As UltraWinGrid.UltraGridRow In griCentro.Rows
                                    If fila.Cells("IdCentro").Value = oeUsuarioSucursal.oeCentro.Id Then
                                        fila.Hidden = False
                                        Exit For
                                    End If
                                Next
                            Else
                                Throw New Exception("El Centro: " & .ActiveRow.Cells("Nombre").Value & " ya esta Asignada")
                            End If

                        Else
                            If oeUsuarioSucursal.Id <> "" Then
                                oeUsuarioSucursal.TipoOperacion = "E"
                                For Each fila As UltraWinGrid.UltraGridRow In griCentro.Rows
                                    If fila.Cells("IdCentro").Value = oeUsuarioSucursal.oeCentro.Id Then
                                        fila.Hidden = True
                                        Exit For
                                    End If
                                Next
                            Else
                                olUsuarioSucursal.Remove(oeUsuarioSucursal)
                            End If

                        End If

                    End If

                End If

            End With
            LlenarSucursal(olUsuarioSucursal)
            griCentro.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
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

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("tsmiNuevo").Enabled = True
        MenuContextual1.Items("tsmiEditar").Enabled = IIf(griUsuario.Selected.Rows.Count > 0, True, False)
        MenuContextual1.Items("tsmiEliminar").Enabled = IIf(griUsuario.Selected.Rows.Count > 0, True, False)
        MenuContextual1.Items("tsmiExportar").Enabled = IIf(griUsuario.Rows.Count > 0, True, False)

    End Sub

#End Region

End Class