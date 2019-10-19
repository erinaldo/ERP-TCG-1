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
Imports System.IO
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win.UltraWinToolTip

Public Class frm_Trabajador
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    Private WithEvents oeTrabajador As New e_Trabajador
    Private leTrabajador As New List(Of e_Trabajador), olTrabajador As New l_Trabajador
    Private oeArea As New e_Area, olArea As New l_Area
    Private oeCargo As New e_Cargo, olCargo As New l_Cargo
    Private oeCentro As New e_Centro, olCentro As New l_Centro
    Private WithEvents oeOcupacionTrab As New e_OcupacionTrabajador
    Private olOcupacionTrabajador As New l_OcupacionTrabajador, loOcupacionTrabajador As New List(Of e_OcupacionTrabajador)
    Private oeOcupacion As New e_Ocupacion, olOcupacion As New l_Ocupacion
    Private olDatosConfiguracion As New l_Configuracion
    Private olPersona As New l_Persona
    Private _ingresando_datos As Boolean = False
    Private band As Boolean = False
    Private oeCC As New e_CuentaCorriente
    Private oePerDocumento As New e_PersonaDocumento
    Private oeCtaBancaria As New e_CuentaCtePersonal
    Private oeSueldoTrabajador As New e_SueldoTrabajador
    Private oeFondoPension As New e_FondoPensionTrabajador
    Private oeContrato As New e_Contratos
    Private oeRegimenSalud As New e_RegimenSalud
    Private oeSeguroComplementario As New e_SeguroComplementario
    Private oeRegimenPen As New e_RegimenPensionario, olRegimenPen As New l_RegimenPensionario, leRegimenPen As New List(Of e_RegimenPensionario)
    Private oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa, leEmpresa As New List(Of e_Empresa)
    Private oePlanEPS As New e_PlanesEPS, olPlanEPS As New l_PlanesEPS, lePlanEPS As New List(Of e_PlanesEPS)
    Private olDerechoHabiente As New l_DerechoHabiente, leDerechoHab As New List(Of e_DerechoHabiente), oeDerechoHab As New e_DerechoHabiente
    Private _opeTrab As String = "", _acl As String = "", _estado As String = ""
    Private Fs As FileStream = Nothing
    Private FotoRuta As String = ""
    Private FotoInsert As Integer = 0
    Private FotoTamaño As Integer = 0
#End Region

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Trabajador = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_Trabajador()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            Tiempo1.Enabled = True
            If griTrabajador.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeTrab = "GENERADA"
                oeTrabajador.TipoOperacion = "I"
                MostrarTabs(1, ficTrabajador, 1)
                Inicializar()
                txtDni.Text = String.Empty
                EstadoCivil1.Seleccionar("1CH002")
                GradoInstruccion1.Seleccionar("1CH009")
                LugarNacimiento.Seleccionar("140101")
                TipoRelacionLaboral1.Seleccionar("1SI002")
                cboEstadoTra.SelectedIndex = 1
                oeTrabajador.IndEstado = cboEstadoTra.Value
                cboEstadoTra.ReadOnly = True
                txtDni.Focus()
                MyBase.Nuevo()
                oeTrabajador.Modificado = False
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
                _opeTrab = "GENERADA"
                Mostrar()
                oeTrabajador.TipoOperacion = "A"
                cboEstadoTra.ReadOnly = False
                txtDni.Focus()
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
                MostrarTabs(1, ficTrabajador, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTrabajador.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficTrabajador, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficTrabajador, 1)
                        End If
                        'Exit Sub
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficTrabajador, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                        'Exit Sub
                End Select
            Else
                MostrarTabs(0, ficTrabajador, 2)
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
                With griTrabajador
                    If ValidarGrilla(griTrabajador, "Trabajador") Then
                        oeTrabajador.Id = .ActiveRow.Cells("ID").Value
                        oeTrabajador.CargaCompleto = True
                        oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                        If oeTrabajador.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Trabajador: " & oeTrabajador.oePersona.NombreCompleto & " ?", "Mensaje del Sistema", _
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeTrabajador.TipoOperacion = "E"
                                olTrabajador.Eliminar(oeTrabajador)
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
                If griTrabajador.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(griTrabajador)
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

    Private Sub oeTrabajador_DatoCambiado() Handles oeTrabajador.DatoCambiado
        oeTrabajador.Modificado = True
    End Sub

    Private Sub frm_Trabajador_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficTrabajador.SelectedTab.Index
            Case 0
                If griTrabajador.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_Trabajador_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Trabajador_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Select Case _Operacion
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

    Private Sub frm_Trabajador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargaCombos()
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficTrabajador)
            colorBaja.Color = Color.LightCoral
            colorActivo.Color = Color.LightGreen
            colorPorLiquidar.Color = Color.Khaki
            verFiltro.Checked = False
            cboBuscaEstado.ReadOnly = True
            cboTipoTrabBus.ReadOnly = True
            Tiempo1.Enabled = False
            InicializaTiempo()
            'agrListaOcupaciones.Expanded = False
            CargarTrabajador(New List(Of e_Trabajador))
            loOcupacionTrabajador = New List(Of e_OcupacionTrabajador)
            LlenarOcupacion(loOcupacionTrabajador)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtApellidoMaterno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoMaterno.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtApellidoMaterno_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoMaterno.ValueChanged
        oeTrabajador.oePersona.ApellidoMaterno = txtApellidoMaterno.Text.Trim
    End Sub

    Private Sub txtApellidoPaterno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoPaterno.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtApellidoPaterno_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoPaterno.ValueChanged
        oeTrabajador.oePersona.ApellidoPaterno = txtApellidoPaterno.Text.Trim
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeTrabajador.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtDni_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDni.ValueChanged
        oeTrabajador.oePersona.Dni = txtDni.Text.Trim
        If bandForm <> "T" Then
            If oeTrabajador.TipoOperacion = "I" Then

                If txtDni.Text.Length = 8 Then
                    'Obtiene y muestra los datos personales del trabajador, si ya está registrado como persona
                    Dim oePersona As New e_Persona
                    oePersona.Dni = oeTrabajador.oePersona.Dni
                    Dim olPersona As New l_Persona
                    oePersona.CargaCompleta = True
                    oePersona = olPersona.Obtener(oePersona)
                    If Not String.IsNullOrEmpty(oePersona.Id) Then
                        oeTrabajador.oePersona.Id = oePersona.Id
                        oeTrabajador.oePersona.ApellidoPaterno = oePersona.ApellidoPaterno
                        oeTrabajador.oePersona.ApellidoMaterno = oePersona.ApellidoMaterno
                        oeTrabajador.oePersona.Nombre = oePersona.Nombre
                        oeTrabajador.oePersona.FechaNacimiento = oePersona.FechaNacimiento
                        oeTrabajador.oePersona.oeSexo = oePersona.oeSexo
                        oeTrabajador.FechaIngreso = #1/1/1901#

                        Dim oeTemp As New e_Trabajador
                        oeTemp.oePersona.Id = oeTrabajador.oePersona.Id
                        oeTemp.CargaCompleto = True
                        oeTemp = olTrabajador.Obtener(oeTemp)

                        If Not String.IsNullOrEmpty(oeTemp.Id) Then
                            oeTrabajador.Id = oeTemp.Id
                            oeTrabajador.oePersona.Id = oeTemp.oePersona.Id
                            oeTrabajador.Codigo = oeTemp.Codigo
                            oeTrabajador.Activo = oeTemp.Activo
                            oeTrabajador.oeArea.Id = oeTemp.oeArea.Id
                            oeTrabajador.oeCargo.Id = oeTemp.oeCargo.Id
                            oeTrabajador.FechaIngreso = oeTemp.FechaIngreso
                            oeTrabajador.leOcupacionTrabajador = oeTemp.leOcupacionTrabajador
                            oeTrabajador.TipoOperacion = "A"
                        Else
                            oeTrabajador.leOcupacionTrabajador = New List(Of e_OcupacionTrabajador)
                        End If

                        'Actualiza los textos con los datos de la persona obtenidos desde el DNI
                        CargaDatosPersonales(oeTrabajador)

                    End If
                    'If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then PictureBox1.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
                Else
                    Inicializar()
                End If
            End If
        Else
            oeTrabajador.oePersona.Dni = txtDni.Text.Trim
            oeTrabajador.oePersona.oeSexo = New e_Sexo(1)
        End If
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeTrabajador.oePersona.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeTrabajador.Activo = verActivo.Checked
    End Sub

    Private Sub Sexo1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sexo1.Validated
        oeTrabajador.oePersona.oeSexo.Nombre = Sexo1.Sexo.Nombre
    End Sub

    Private Sub fecNacimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecNacimiento.ValueChanged
        oeTrabajador.oePersona.FechaNacimiento = fecNacimiento.Value
    End Sub

    Private Sub griTrabajador_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griTrabajador.DoubleClick
        If griTrabajador.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griOcupacion_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griOcupacion.CellChange
        Try
            With griOcupacion
                .UpdateData()
                If .ActiveRow.Cells("Principal").Activated Then
                    Dim oeOcupacionTrabajador As New e_OcupacionTrabajador
                    'loOcupacionTrabajador = oeTrabajador.leOcupacionTabajador
                    oeOcupacionTrabajador.IdOcupacion = .ActiveRow.Cells("IdOcupacion").Value
                    oeOcupacionTrabajador = loOcupacionTrabajador.Item(loOcupacionTrabajador.IndexOf(oeOcupacionTrabajador))
                    oeOcupacionTrabajador.Principal = IIf(.ActiveRow.Cells("Principal").Value, 1, 0)
                    'For Each fila As UltraWinGrid.UltraGridRow In .Rows
                    '    If fila.Cells("IdOcupacion").Value <> oeOcupacionTrabajador.IdOcupacion Then fila.Cells("Principal").Value = False
                    'Next
                    '.DataBind()
                    For Each oe As e_OcupacionTrabajador In loOcupacionTrabajador
                        If oe.IdOcupacion <> oeOcupacionTrabajador.IdOcupacion Then oe.Principal = 0
                        If oe.TipoOperacion.Trim = "" Then oe.TipoOperacion = "A"
                    Next
                    LlenarOcupacion(loOcupacionTrabajador)
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ColoresTrabajadoresNoDisponibles_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorBaja.ColorChanged
        ' etiTrabajadoresNoDisponibles.Appearance.BackColor = ColoresTrabajadoresNoDisponibles.Color
    End Sub

    Private Sub EstadoCivil1_DatosCambiados(ByVal idEstadoCivil As String, ByVal NombreEstadoCivil As String) Handles EstadoCivil1.DatosCambiados
        If EstadoCivil1.cboEstadoCivil.SelectedIndex > -1 Then oeTrabajador.IdEstadoCivil = idEstadoCivil
    End Sub

    'Private Sub TipoRelacionLaboral1_DatosCambiados(ByVal idTipoRelacionLaboral As String, ByVal NombreRelacionLaboral As String) Handles TipoRelacionLaboral1.DatosCambiados
    '    If TipoRelacionLaboral1.cboTipoRelacionLaboral.SelectedIndex > -1 Then oeOcupacionTrab.IdTipoRelacionLaboral = idTipoRelacionLaboral
    'End Sub

    Private Sub GradoInstruccion1_DatosCambiados1(ByVal idGradoInstruccion As String, ByVal NombreGradoInstruccion As String) Handles GradoInstruccion1.DatosCambiados
        If GradoInstruccion1.cboGradoInstruccion.SelectedIndex > -1 Then oeTrabajador.IdGradoInstruccion = idGradoInstruccion
    End Sub

    Private Sub LugarNacimiento_DatoCambiado(ByVal Id As String) Handles LugarNacimiento.DatoCambiado
        If LugarNacimiento.Distrito1.cboDistrito.SelectedIndex > -1 Then oeTrabajador.IdLugarNacimiento = Id
    End Sub

    'Private Sub cboArea_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboArea.ValueChanged
    '    If cboArea.SelectedIndex > -1 Then oeOcupacionTrab.IdArea = cboArea.Value.ToString.Trim : oeOcupacionTrab.Area = cboArea.Text.Trim
    'End Sub

    'Private Sub cboCargo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCargo.ValueChanged
    '    If cboCargo.SelectedIndex > -1 Then oeOcupacionTrab.IdCargo = cboCargo.Value.ToString.Trim : oeOcupacionTrab.Cargo = cboCargo.Text.Trim
    'End Sub

    'Private Sub CboCentro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCentro.ValueChanged
    '    If CboCentro.SelectedIndex > -1 Then oeOcupacionTrab.IdCentro = CboCentro.Value.ToString.Trim : oeOcupacionTrab.Centro = CboCentro.Text.Trim
    'End Sub

    'Private Sub cboOcupacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOcupacion.ValueChanged
    '    If cboOcupacion.SelectedIndex > -1 Then oeOcupacionTrab.IdOcupacion = cboOcupacion.Value.ToString.Trim : oeOcupacionTrab.Ocupacion = cboOcupacion.Text.Trim
    'End Sub

    'Private Sub fecFechaIngreso_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecFechaIngreso.ValueChanged
    '    oeOcupacionTrab.FechaIngreso = fecFechaIngreso.Value
    'End Sub

    Private Sub FecFechaCese_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecFechaCese.ValueChanged
        oeOcupacionTrab.FechaCese = IIf(IsDate(FecFechaCese.Value), FecFechaCese.Value, "01/01/1901")
    End Sub

    'Private Sub verPrincipal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verPrincipal.CheckedChanged
    '    oeOcupacionTrab.Principal = IIf(verPrincipal.Checked, 1, 0)
    'End Sub

    Private Sub chkYaNoLabora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkYaNoLabora.CheckedChanged
        FecFechaCese.Enabled = IIf(chkYaNoLabora.Checked, True, False)
        If chkYaNoLabora.Checked Then
            If FecFechaCese.Value = "01/01/1901" Then
                FecFechaCese.Value = Date.Now
                oeOcupacionTrab.FechaEjecutaCese = Date.Now.Date
                oeOcupacionTrab.UsuarioEjecutaCese = gUsuarioSGI.Id
            End If
        Else
            FecFechaCese.Value = "01/01/1901"
        End If
    End Sub

    Private Sub oeOcupacionTrab_DatoCambiado() Handles oeOcupacionTrab.DatoCambiado
        oeOcupacionTrab.Modificado = True
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        GuardarOcupacion()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If oeOcupacionTrab.Modificado Then
            Select Case MessageBox.Show("¿Desea Guardar los Cambios?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    GuardarOcupacion()
                Case Windows.Forms.DialogResult.No
                    ' agrListaOcupaciones.Expanded = False
                    MostrarTabs(0, ficManOcupacion)
            End Select
        Else
            MostrarTabs(0, ficManOcupacion)
            'agrListaOcupaciones.Expanded = False
        End If
    End Sub

    Private Sub griOcupacion_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griOcupacion.DoubleClick
        'Try
        '    If griOcupacion.Selected.Rows.Count > 0 Then
        '        If griOcupacion.ActiveRow.Cells("FechaCese").Value = "01/01/1901" Then
        '            CargaOcupacion()
        '        Else
        '            Throw New Exception("No Puede Actualizar Datos de un Trabajador Cesado")
        '        End If
        '    Else
        '        Throw New Exception("Seleccion un Registro de Ocupacion Para Editar")
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
        ms_EditarOcupacion()
    End Sub

    Private Sub btnDireccion_Click(sender As System.Object, e As System.EventArgs) Handles btnDireccion.Click
        Try
            MostrarDatoPer("Dir")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEmail_Click(sender As System.Object, e As System.EventArgs) Handles btnEmail.Click
        Try
            MostrarDatoPer("Ema")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnTelefono_Click(sender As System.Object, e As System.EventArgs) Handles btnTelefono.Click
        Try
            MostrarDatoPer("Tel2")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCelular_Click(sender As System.Object, e As System.EventArgs) Handles btnCelular.Click
        Try
            MostrarDatoPer("Tel1")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDocPersonales_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griDocPersonales.DoubleClick
        Try
            If griDocPersonales.Selected.Rows.Count > 0 Then
                EditarDoc(oeTrabajador.oePersona.leDocumento)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuDocPer_ToolClick(sender As System.Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuDocPer.ToolClick
        Try
            With oeTrabajador.oePersona
                oePerDocumento = New e_PersonaDocumento
                Select Case e.Tool.Key
                    Case "AgregarDoc"
                        oePerDocumento.Vigente = 1
                        oePerDocumento.IdPersona = .Id
                        oePerDocumento.Activo = True
                        MantDocPer("Agregar", oePerDocumento)
                    Case "ModificarDoc"
                        EditarDoc(.leDocumento)
                    Case "QuitarDoc"
                        oePerDocumento.Id = griDocPersonales.ActiveRow.Cells("Id").Value
                        oePerDocumento.Equivale = 1
                        If .leDocumento.Contains(oePerDocumento) Then
                            oePerDocumento = .leDocumento.Item(.leDocumento.IndexOf(oePerDocumento))
                            If oePerDocumento.TipoOperacion = "I" Then
                                .leDocumento.Remove(oePerDocumento)
                            Else
                                oePerDocumento.TipoOperacion = "E"
                                oePerDocumento.Activo = False
                            End If
                            CargarDocumentos(.leDocumento)
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuCuentasBancarias_ToolClick(sender As System.Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuCuentasBancarias.ToolClick
        Try
            With oeTrabajador
                oeCtaBancaria = New e_CuentaCtePersonal
                Select Case e.Tool.Key
                    Case "AgregarCta"
                        oeCtaBancaria.Vigente = 1
                        oeCtaBancaria.IdTrabajador = .Id
                        oeCtaBancaria.Activo = True
                        MantCtaPer("Agregar", oeCtaBancaria)
                    Case "ModificarCta"
                        EditarCtaBan(.leCtaBancaria)
                    Case "QuitarCta"
                        oeCtaBancaria.Id = griCtaBancaria.ActiveRow.Cells("Id").Value
                        oeCtaBancaria.Equivale = 1
                        If .leCtaBancaria.Contains(oeCtaBancaria) Then
                            oeCtaBancaria = .leCtaBancaria.Item(.leCtaBancaria.IndexOf(oeCtaBancaria))
                            If oePerDocumento.TipoOperacion = "I" Then
                                .leCtaBancaria.Remove(oeCtaBancaria)
                            Else
                                oeCtaBancaria.TipoOperacion = "E"
                                oeCtaBancaria.Activo = False
                            End If
                            CargarCuentasBancarias(.leCtaBancaria)
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub griCtaBancaria_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griCtaBancaria.DoubleClick
        If griCtaBancaria.Selected.Rows.Count > 0 Then EditarCtaBan(oeTrabajador.leCtaBancaria)
    End Sub

    Private Sub verMixta_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles verMixta.CheckedChanged
        agrComisionFlujo.Visible = Not verMixta.Checked
        agrComisionMixta.Visible = verMixta.Checked
    End Sub

    Private Sub btnEditarSueldo_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarSueldo.Click
        Try
            With oeTrabajador
                oeSueldoTrabajador = New e_SueldoTrabajador
                Dim _leSuelAux = .leSueldo.Where(Function(it) it.Activo = True And it.Vigente = 1).ToList
                If _leSuelAux.Count > 0 Then
                    oeSueldoTrabajador = _leSuelAux(0)
                    MantSuelTrab("Editar", oeSueldoTrabajador)
                Else
                    oeSueldoTrabajador.Vigente = 1
                    oeSueldoTrabajador.IdTrabajador = .Id
                    oeSueldoTrabajador.Activo = True
                    MantSuelTrab("Agregar", oeSueldoTrabajador)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEditarFondo_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarFondo.Click
        Try
            With oeTrabajador
                oeFondoPension = New e_FondoPensionTrabajador
                Dim _leFondAux = .leFondoPension.Where(Function(it) it.Activo = True And it.Vigente = 1).ToList
                If _leFondAux.Count > 0 Then
                    oeFondoPension = _leFondAux(0)
                    MantFonPen("Editar", oeFondoPension)
                Else
                    oeFondoPension.Vigente = 1
                    oeFondoPension.IdTrabajador = .Id
                    oeFondoPension.Mixta = 1
                    oeFondoPension.Activo = True
                    MantFonPen("Agregar", oeFondoPension)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnContrato_Click(sender As Object, e As EventArgs) Handles btnContrato.Click
        Try
            With oeTrabajador
                oeContrato = New e_Contratos
                Dim _leContAux = .leContratos.Where(Function(it) it.Activo = True And it.Vigencia = True).ToList
                If _leContAux.Count > 0 Then
                    oeContrato = _leContAux(0)
                    MantContrTrab("Editar", oeContrato)
                Else
                    oeContrato.Vigencia = 1
                    oeContrato.IdTrabajador = .Id
                    oeContrato.Activo = True
                    MantContrTrab("Agregar", oeContrato)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles verFiltro.CheckedChanged
        cboBuscaEstado.ReadOnly = Not verFiltro.Checked
        cboTipoTrabBus.ReadOnly = Not verFiltro.Checked
        cboBuscaEstado.SelectedIndex = IIf(verFiltro.Checked, 1, -1)
        cboTipoTrabBus.SelectedIndex = IIf(verFiltro.Checked, 0, -1)
        If Not verFiltro.Checked Then CargarTrabajador(leTrabajador)
    End Sub

    Private Sub cboBuscaEstado_ValueChanged(sender As Object, e As EventArgs) Handles cboBuscaEstado.ValueChanged
        If cboBuscaEstado.SelectedIndex > -1 Then
            CargarTrabajador(leTrabajador)
        End If
    End Sub

    Private Sub verHijos_CheckedChanged(sender As Object, e As EventArgs) Handles verHijos.CheckedChanged
        oeTrabajador.IndHijo = IIf(verHijos.Checked, 1, 0)
    End Sub

    Private Sub optDobleTributacion_ValueChanged(sender As Object, e As EventArgs) Handles optDobleTributacion.ValueChanged
        cboConvenio.ReadOnly = IIf(optDobleTributacion.CheckedIndex = 0, True, False)
    End Sub

    'Private Sub cboIndRuta_ValueChanged(sender As Object, e As EventArgs) Handles cboIndRuta.ValueChanged
    '    If cboIndRuta.SelectedIndex > -1 Then oeOcupacionTrab.IndRuta = cboIndRuta.Value
    'End Sub

    Private Sub cboEstadoTra_ValueChanged(sender As Object, e As EventArgs) Handles cboEstadoTra.ValueChanged
        If cboEstadoTra.SelectedIndex > -1 Then oeTrabajador.IndEstado = cboEstadoTra.Value
    End Sub

    Private Sub btnEditarRegSalud_Click(sender As Object, e As EventArgs) Handles btnEditarRegSalud.Click
        Try
            With oeTrabajador
                oeRegimenSalud = New e_RegimenSalud
                Dim _leRSaludAux = .leRegimenSalud.Where(Function(it) it.Activo = True And it.Vigente = 1).ToList
                If _leRSaludAux.Count > 0 Then
                    oeRegimenSalud = _leRSaludAux(0)
                    MantRegSalud("Editar", oeRegimenSalud)
                Else
                    oeRegimenSalud.Vigente = 1
                    oeRegimenSalud.IdTrabajador = .Id
                    oeRegimenSalud.Activo = True
                    MantRegSalud("Agregar", oeRegimenSalud)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEditarSComp_Click(sender As Object, e As EventArgs) Handles btnEditarSComp.Click
        Try
            With oeTrabajador
                oeSeguroComplementario = New e_SeguroComplementario
                Dim _leSCompAux = .leSeguroComp.Where(Function(it) it.Activo = True And it.Vigencia = 1).ToList
                If _leSCompAux.Count > 0 Then
                    oeSeguroComplementario = _leSCompAux(0)
                    MantSeguroComp("Editar", oeSeguroComplementario)
                Else
                    oeSeguroComplementario.Vigencia = 1
                    oeSeguroComplementario.IdTrabajador = .Id
                    oeSeguroComplementario.Activo = True
                    MantSeguroComp("Agregar", oeSeguroComplementario)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoTrabajador_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoTrabajador.ValueChanged
        oeTrabajador.IndTipo = cboTipoTrabajador.Value
    End Sub

    Private Sub cboTipoTrabBus_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoTrabBus.ValueChanged
        If cboTipoTrabBus.SelectedIndex > -1 Then
            CargarTrabajador(leTrabajador)
        End If
    End Sub

    Private Sub cboCategoriaPiloto_ValueChanged(sender As Object, e As EventArgs) Handles cboCategoriaPiloto.ValueChanged
        oeTrabajador.IndPiloto = cboCategoriaPiloto.Value
    End Sub

    Private Sub btnCancelarDH_Click(sender As Object, e As EventArgs) Handles btnCancelarDH.Click
        If MessageBox.Show("¿Desea Cancelar la Operacíon?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MostrarTabs(0, ficDerechoHabiente)
        End If
    End Sub

    Private Sub btnAceptarDH_Click(sender As Object, e As EventArgs) Handles btnAceptarDH.Click
        Try
            If txtDniDH.Text.Trim.Length = 0 Then Throw New Exception("Ingrese Datos de la Persona Vinculada")
            If cboVinculoDH.SelectedIndex = -1 Then Throw New Exception("Seleccione Vinculo")
            If cboTipoDocDH.SelectedIndex = -1 Then Throw New Exception("Selecione Tipo de Documento que Acredite Vinculo")
            oeDerechoHab.IndVinculo = cboVinculoDH.Value
            oeDerechoHab.TipoDocAcredita = cboTipoDocDH.Value
            oeDerechoHab.NroDocumentoAcredita = txtNroDocDH.Text
            oeDerechoHab.MesConcepcion = numMesGestacion.Value
            oeDerechoHab.TipoOperacion = IIf(oeDerechoHab.Id.Trim = String.Empty, "I", "A")
            If btnPersonaDH.Tag = "Agregar" Then
                oeDerechoHab.TipoBuscar = 1
                If leDerechoHab.Contains(oeDerechoHab) Then
                    Throw New Exception("Ya se Ingreso el DNI: " & oeDerechoHab.oePersona.Dni & " en Derecho Habiente")
                Else
                    leDerechoHab.Add(oeDerechoHab)
                End If
            End If
            CargarDerechoHabiente(leDerechoHab)
            MostrarTabs(0, ficDerechoHabiente)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDerechoHabiente_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griDerechoHabiente.DoubleClickRow
        EditarDerechoHabiente()
    End Sub

    Private Sub btnPersonaDH_Click(sender As Object, e As EventArgs) Handles btnPersonaDH.Click
        Try
            Dim _ope As Boolean = IIf(btnPersonaDH.Tag = "Agregar", True, False)
            Dim _frm As New frm_Persona(_ope, oeDerechoHab)
            _frm.StartPosition = FormStartPosition.CenterScreen
            _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            _frm.ShowDialog()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            btnPersonaDH.Visible = False
            oeDerechoHab.oePersona = _frm.oeDerHab.oePersona
            MostrarPersDH()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar()
        Try
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            CargarTrabajador(leTrabajador)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griTrabajador.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtApellidoPaterno.Text = String.Empty
        txtApellidoMaterno.Text = String.Empty
        txtNombre.Text = String.Empty
        fecNacimiento.Value = Date.Now.Date
        fecFechaIngreso.Value = Nothing
        PictureBox1.Image = Nothing
        cboArea.SelectedIndex = -1
        cboCargo.SelectedIndex = -1
        verActivo.Checked = True
        loOcupacionTrabajador = New List(Of e_OcupacionTrabajador)
        LlenarOcupacion(loOcupacionTrabajador)
        FecFechaCese.Value = #1/1/1901#
        AsociarMenu()
        txtEmail.Text = String.Empty
        txtEmail.CharacterCasing = CharacterCasing.Normal
        txtCelular.Text = String.Empty
        txtDireccion.Text = String.Empty
        txtTelefono.Text = String.Empty
        MostrarTabs(0, ficManOcupacion)
        ndSueldoBasico.Value = 0
        cboTipoPago.SelectedIndex = -1
        cboPeriocidad.SelectedIndex = -1
        fecSueldoActividad.Value = Date.Now.Date
        fecSueldoActividad.Enabled = False
        txtEmpresaFondo.Text = String.Empty
        txtCussp.Text = String.Empty
        fecFondoTrab.Value = Date.Now.Date
        fecFondoTrab.Enabled = False
        ndObligacion.Value = 0
        ndComision.Value = 0
        ndSeguro.Value = 0
        ndComisionMixta.Value = 0
        ndSaldoMixta.Value = 0
        verMixta.Checked = False
        agrComisionMixta.Visible = False
        ficMantenimientoTrab.Tabs(0).Selected = True
        MostrarTabs(0, ficDerechoHabiente)
        leDerechoHab = New List(Of e_DerechoHabiente)
        CargarDerechoHabiente(leDerechoHab)
        ficCompletoLab.Tabs(0).Selected = True
        ficDatos2.Tabs(0).Selected = True
        verHijos.Checked = False
        optExonera5ta.CheckedIndex = 0
        optDobleTributacion.CheckedIndex = 0
        cboConvenio.ReadOnly = True
        cboEstadoTra.SelectedIndex = 1
        cboTipoTrabajador.SelectedIndex = 0
        cboCategoriaPiloto.SelectedIndex = 0
        cboRegimenSalud.SelectedIndex = -1
        cboEntidadPS.SelectedIndex = -1
        cboPlanEPS.SelectedIndex = -1
        ndCuotaEPS.Value = 0
        fecInicioRSalud.Value = Date.Now.Date
        fecFinRSalud.Value = Date.Now.Date
        optAportaSCTR.CheckedIndex = -1
        optCoberturaSalud.CheckedIndex = -1
        optSCTRPension.CheckedIndex = -1
        fecInicioSComp.Value = Date.Now.Date
        fecFinSComp.Value = Date.Now.Date
        ocultarTabs(True)
    End Sub

    Private Sub Mostrar()
        Try
            If griTrabajador.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeTrabajador.TipoOperacion = "N"
                oeTrabajador.Id = griTrabajador.ActiveRow.Cells("Id").Value.ToString
                oeTrabajador.CargaCompleto = True
                oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                If oeTrabajador.Activo Then
                    CargaDatosPersonales(oeTrabajador)
                    'If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then PictureBox1.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
                    oeTrabajador.Modificado = False
                    MostrarTabs(1, ficTrabajador, 1)
                    MyBase.Editar()
                Else
                    Throw New Exception("El Trabajador: " & oeTrabajador.oePersona.NombreCompleto & " ha sido inhabilitado por Recursos Humanos")
                End If
            End If
        Catch ex As Exception
            'mensajeEmergente.Problema(ex.Message, True)
            Throw ex
        End Try
    End Sub
    Dim bandForm As String = ""
    Dim Prefijo As New l_Configuracion
    Public Sub MostrarTrabajador(ByVal idTrabajador As String)
        Try
            bandForm = "T"
            Inicializar()
            txtDni.Text = ""
            If idTrabajador <> "" Then
                oeTrabajador.TipoOperacion = "N"
                oeTrabajador.Id = idTrabajador
                oeTrabajador.CargaCompleto = True
                oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                If oeTrabajador.Activo Then
                    CargaDatosPersonales(oeTrabajador)
                    'If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then PictureBox1.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
                    oeTrabajador.Modificado = False
                    MostrarTabs(1, ficTrabajador, 1)
                    MyBase.Editar()
                Else
                    Throw New Exception("El Trabajador: " & oeTrabajador.oePersona.NombreCompleto & " ha sido inhabilitado por Recursos Humanos")
                End If
                ocultarTabs(False)
            Else
                MostrarTabs(1, ficTrabajador, 1)
                loOcupacionTrabajador.Clear()
                Dim oeOcupacionTrab = New e_OcupacionTrabajador()
                With oeOcupacionTrab
                    .IdArea = "1CH000000015" 'OPERACIONES
                    .IdCargo = "1PY004" 'LOCACION DE SERVICIOS
                    .IdCentro = gs_PrefijoIdSucursal 'PACASMAYO, SEGUN PREFIJO
                    .IdOcupacion = "1CH000000023" ' CONDUCTOR
                    TipoRelacionLaboral1.Seleccionar("1SI003") ' LOCACION DE SERVICIOS
                    '.IndRuta
                    .FechaIngreso = ObtenerFechaServidor()
                    .Principal = 1
                    .FechaCese = FecFechaCese.DateTime.AddDays(10).Date
                    .Area = "OPERACIONES"
                    .Cargo = "LOCACION DE SERVICIOS"
                    'prefijocambio
                    .Centro = DevolverCentroXPrefijo(gs_PrefijoIdSucursal)
                    .Ocupacion = "CONDUCTOR"
                    .TipoRelacionLaboral = "LOCACION DE SERVICIOS"
                    chkYaNoLabora.Checked = False
                    oeOcupacionTrab.TipoOperacion = "I"

                End With
                loOcupacionTrabajador.Add(oeOcupacionTrab)
                LlenarOcupacion(loOcupacionTrabajador)           
                oeTrabajador.leOcupacionTrabajador = loOcupacionTrabajador
                oeTrabajador.TipoOperacion = "I"
                oeTrabajador.IndTipo = 3
                oeTrabajador.IndPiloto = 1
                cboEstadoTra.SelectedIndex = 0
                oeTrabajador.IndEstado = cboEstadoTra.Value
                MyBase.Nuevo()
                ocultarTabs(False)
            End If
            oeTrabajador.leContratos = Nothing
            oeTrabajador.leCtaBancaria = Nothing
            oeTrabajador.leDerechoHabiente = Nothing
            oeTrabajador.leSeguroComp = Nothing
            oeTrabajador.leRegimenSalud = Nothing
            oeTrabajador.leFondoPension = Nothing
            oeTrabajador.leSueldo = Nothing
            oeTrabajador.oeCuentaCorriente = Nothing
        Catch ex As Exception
            'mensajeEmergente.Problema(ex.Message, True)
            Throw ex
        End Try
    End Sub

    Private Function DevolverCentroXPrefijo(ByVal prefijo As String) As String
        Try
            Select Case prefijo
                Case "1PY"
                    Return "PACASMAYO"
                Case "1CH"
                    Return "CHICLAYO"
                Case "1LU"
                    Return "LIMA LURIN"
                Case "1SA"
                    Return "LIMA"
                Case "1SI"
                    Return "SISTEMAS"
                Case "1PU"
                    Return "PUCALLPA"

            End Select
        Catch ex As Exception
            Throw ex
        End Try
        Return ""
    End Function

    Private Sub ocultarTabs(ByVal activo As Boolean)
        Try
            agrSueldoTrab.Visible = activo
            '  agrOcupacion.Visible = activo
            ficDatos2.Tabs(1).Enabled = activo
            ficDatos2.Tabs(2).Enabled = activo
            ficMantenimientoTrab.Tabs(1).Enabled = activo
            Me.cboTipoTrabajador.Enabled = activo
            Me.cboCategoriaPiloto.Enabled = activo
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaDatosPersonales(ByVal oeTrabajador As e_Trabajador)
        Try
            With oeTrabajador
                txtCodigo.Text = .Codigo
                txtApellidoPaterno.Text = .oePersona.ApellidoPaterno
                txtApellidoMaterno.Text = .oePersona.ApellidoMaterno
                txtNombre.Text = .oePersona.Nombre
                txtDni.Text = .oePersona.Dni
                loOcupacionTrabajador = New List(Of e_OcupacionTrabajador)
                loOcupacionTrabajador = .leOcupacionTrabajador
                oeCC = New e_CuentaCorriente
                oeCC = .oeCuentaCorriente
                fecNacimiento.Value = .oePersona.FechaNacimiento
                Sexo1.Sexo = New e_Sexo(CType(.oePersona.oeSexo.Id, String))
                txtCodigo.Text = .Codigo
                verActivo.Checked = .Activo
                verHijos.Checked = .IndHijo
                cboTipoTrabajador.Value = .IndTipo
                cboCategoriaPiloto.Value = .IndPiloto
                TrabajadorDisponible1.Disponible = .Disponible
                If Not String.IsNullOrEmpty(.IdEstadoCivil) Then EstadoCivil1.Seleccionar(.IdEstadoCivil)
                If Not String.IsNullOrEmpty(.IdGradoInstruccion) Then GradoInstruccion1.Seleccionar(.IdGradoInstruccion)
                If Not String.IsNullOrEmpty(.IdLugarNacimiento) Then LugarNacimiento.Seleccionar(.IdLugarNacimiento)
                cboEstadoTra.Value = .IndEstado
                LlenarOcupacion(.leOcupacionTrabajador)
                CargarDirEmaTel("Dir")
                CargarDirEmaTel("Tel1")
                CargarDirEmaTel("Tel2")
                CargarDirEmaTel("Ema")
                CargarDocumentos(.oePersona.leDocumento)
                CargarCuentasBancarias(.leCtaBancaria)
                CargarSueldo(.leSueldo)
                CargarFondoPension(.leFondoPension)
                CargarContrato(.leContratos)
                CargarRegimenSalud(.leRegimenSalud)
                CargarSeguroComp(.leSeguroComp)
                leDerechoHab = .leDerechoHabiente
                CargarDerechoHabiente(leDerechoHab)
                If .Foto.Length <> 4 Then
                    upbFoto.Image = .Foto
                    Dim tc As TypeConverter = TypeDescriptor.GetConverter(GetType(Bitmap))
                    Dim bitmap As Bitmap = DirectCast(tc.ConvertFrom(.Foto), Bitmap)
                    Dim imagen As Image = bitmap
                    imagenGuardar.Image = imagen
                    btnDescargarJpg.Enabled = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            If Not ValidarDatos() Then
                Throw New Exception("Ingrese la información sugerida")
            End If
            oeTrabajador.oePersona.oeSexo.Id = Sexo1.Sexo.Id
            oeTrabajador.UsuarioCreacion = gUsuarioSGI.Id
            oeTrabajador.FechaCreacion = Date.Now
            oeTrabajador.ClaveSeguridad = oeTrabajador.oePersona.Dni
            oeTrabajador.leOcupacionTrabajador = loOcupacionTrabajador
            oeTrabajador.oeCuentaCorriente = IIf(bandForm = "T", Nothing, oeCC)
            If loOcupacionTrabajador.Count > 0 Then
                'Pone el trabajador en no disponible si su última fecha de cese es distinta a 01/01/1901
                Dim _leAux = loOcupacionTrabajador.Where(Function(it) it.Principal = 1).ToList
                If _leAux.Count > 0 Then
                    Dim _Aux = _leAux(0)
                    'If _Aux.FechaCese <> "01/01/1901" And _Aux.FechaCese <= Date.Now Then
                    If _Aux.FechaCese <> "01/01/1901" Then
                        oeTrabajador.Disponible = 0 : oeTrabajador.Activo = 1
                        If oeTrabajador.IndEstado > 0 Then oeTrabajador.IndEstado = 2
                    Else
                        oeTrabajador.Disponible = 1 : oeTrabajador.IndEstado = 1 : oeTrabajador.Activo = 1
                    End If
                End If
            End If
            oeTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
            If upbFoto.Image IsNot Nothing Then
                Dim ms As New System.IO.MemoryStream()
                If ms.Length <> 0 Or FotoInsert = 1 Then
                    upbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    oeTrabajador.Foto = ms.GetBuffer()
                Else
                    oeTrabajador.Foto = upbFoto.Image()
                End If
            End If
            If olTrabajador.Guardar(oeTrabajador) Then
                mensajeEmergente.Confirmacion("El trabajador " & oeTrabajador.oePersona.NombreCompleto & ", ha sido grabado satisfactoriamente", True)
                If bandForm = "" Then
                    MostrarTabs(0, ficTrabajador, 2)
                    Consultar(True)
                    griTrabajador.Focus()
                Else
                    If bandForm = "T" Then
                        frm_Guias.codigoPilotoTercero = IIf(frm_Guias.codigoPilotoTercero = "", oeTrabajador.Id, frm_Guias.codigoPilotoTercero)
                        bandForm = ""
                        Me.Close()
                    End If
                End If
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
            .Activo = verActivo.Checked
            .Id = oeTrabajador.oePersona.Id
            .Codigo = oeTrabajador.oePersona.Codigo
        End With
        Dim oeTrabajadorTemp As New e_Trabajador(oePersona)
        With oeTrabajadorTemp
            .Id = oeTrabajador.Id
            .oeArea.Id = oeTrabajador.oeArea.Id
            .oeCargo.Id = oeTrabajador.oeCargo.Id
            .oePersona.Dni = oeTrabajador.oePersona.Dni
            .oePersona.ApellidoPaterno = oeTrabajador.oePersona.ApellidoPaterno
            .oePersona.ApellidoMaterno = oeTrabajador.oePersona.ApellidoMaterno
            .oePersona.Nombre = oeTrabajador.oePersona.Nombre
            .oePersona.FechaNacimiento = oeTrabajador.oePersona.FechaNacimiento
            .oePersona.oeSexo = oeTrabajador.oePersona.oeSexo
            .Codigo = oeTrabajador.Codigo
            .Activo = oeTrabajador.Activo
            .IndEstado = oeTrabajador.IndEstado
            .TipoOperacion = oeTrabajador.TipoOperacion
            .FechaIngreso = oeTrabajador.FechaIngreso
            .IdEstadoCivil = oeTrabajador.IdEstadoCivil
            .IdGradoInstruccion = oeTrabajador.IdGradoInstruccion
            .IdLugarNacimiento = oeTrabajador.IdLugarNacimiento
            .IndHijo = oeTrabajador.IndHijo
            .IndTipo = oeTrabajador.IndTipo
            .IndPiloto = oeTrabajador.IndPiloto
            .oePersona.leDireccionEP = oeTrabajador.oePersona.leDireccionEP
            .oePersona.leTelefono = oeTrabajador.oePersona.leTelefono
            .oePersona.leEmail = oeTrabajador.oePersona.leEmail
            .oePersona.leDocumento = oeTrabajador.oePersona.leDocumento
            .leCtaBancaria = oeTrabajador.leCtaBancaria
            .leSueldo = oeTrabajador.leSueldo
            .leFondoPension = oeTrabajador.leFondoPension
            .leContratos = oeTrabajador.leContratos
            .leRegimenSalud = oeTrabajador.leRegimenSalud
            .leSeguroComp = oeTrabajador.leSeguroComp
            .leDerechoHabiente = oeTrabajador.leDerechoHabiente
        End With

        oeTrabajador = oeTrabajadorTemp

    End Sub

    Private Sub LlenarOcupacion(ByVal leOcupacionTrab As List(Of e_OcupacionTrabajador))
        With griOcupacion
            '.DataSource = oeTrabajador.leOcupacionTabajador
            Dim leActivo As New List(Of e_OcupacionTrabajador)
            leActivo = leOcupacionTrab.Where(Function(item) item.TipoOperacion <> "E").ToList
            .DataSource = leActivo
            '.DataSource = leOcupacionTrab.ToList
            For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                If Col.Key.Contains("Id") Then Col.Hidden = True
                If Col.Key = "Principal" Then
                    Col.CellActivation = Activation.AllowEdit
                    Col.CellClickAction = CellClickAction.Edit
                Else
                    Col.CellActivation = Activation.NoEdit
                    Col.CellClickAction = CellClickAction.RowSelect
                End If
            Next

            .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
            .DisplayLayout.Bands(0).Columns("Trabajador").Hidden = True
            .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
            .DisplayLayout.Bands(0).Columns("TipoRelacionLaboral").Hidden = True
            .DisplayLayout.Bands(0).Columns("IndRuta").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

            .DisplayLayout.Bands(0).Columns("Principal").Header.VisiblePosition = 1
            .DisplayLayout.Bands(0).Columns("Ocupacion").Header.VisiblePosition = 2
            .DisplayLayout.Bands(0).Columns("Cargo").Header.VisiblePosition = 3
            .DisplayLayout.Bands(0).Columns("Area").Header.VisiblePosition = 4
            .DisplayLayout.Bands(0).Columns("AreaOG").Header.VisiblePosition = 5
            .DisplayLayout.Bands(0).Columns("Gerencia").Header.VisiblePosition = 6
            .DisplayLayout.Bands(0).Columns("Centro").Header.VisiblePosition = 7
            '.DisplayLayout.Bands(0).Columns("IndRuta").Header.VisiblePosition = 8
            .DisplayLayout.Bands(0).Columns("FechaIngreso").Header.VisiblePosition = 8
            .DisplayLayout.Bands(0).Columns("FechaCese").Header.VisiblePosition = 9
            .DisplayLayout.Bands(0).Columns("Area").Header.Caption = "Unidad"
            .DisplayLayout.Bands(0).Columns("AreaOG").Header.Caption = "Area"
            .DisplayLayout.Bands(0).Columns("Principal").Width = 40
            .DisplayLayout.Bands(0).Columns("Ocupacion").Width = 250
            .DisplayLayout.Bands(0).Columns("Cargo").Width = 150
            .DisplayLayout.Bands(0).Columns("Area").Width = 150
            .DisplayLayout.Bands(0).Columns("AreaOG").Width = 150
            .DisplayLayout.Bands(0).Columns("Gerencia").Width = 150
            .DisplayLayout.Bands(0).Columns("FechaCese").Width = 70
            .DisplayLayout.Bands(0).Columns("Principal").Style = UltraWinGrid.ColumnStyle.CheckBox
            .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griOcupacion.Rows
                If fila.Cells("FechaCese").Value = "01/01/1901" Then
                    fila.Cells("FechaCese").Appearance.ForeColor = Color.White
                    fila.Cells("FechaCese").Appearance.BackColor = Color.White
                Else
                    If fila.Cells("FechaCese").Value >= Date.Now Then
                        fila.Cells("FechaCese").Appearance.ForeColor = Color.Yellow
                        fila.Cells("FechaCese").Appearance.BackColor = Color.Red
                    Else
                        fila.Cells("FechaCese").Appearance.ForeColor = Color.Red
                        fila.Cells("FechaCese").Appearance.BackColor = Color.Yellow
                    End If
                End If
            Next
        End With
    End Sub

    Private Sub CargaCombos()
        Try
            oeArea = New e_Area
            LlenarComboMaestro(cboArea, olArea.Listar(oeArea), -1)
            oeCargo = New e_Cargo
            LlenarComboMaestro(cboCargo, olCargo.Listar(oeCargo), -1)
            oeCentro = New e_Centro
            LlenarComboMaestro(CboCentro, olCentro.Listar(oeCentro), -1)
            oeOcupacion = New e_Ocupacion
            LlenarComboMaestro(cboOcupacion, olOcupacion.Listar(oeOcupacion).OrderBy(Function(i) i.Nombre).ToList, -1)
            oeRegimenPen = New e_RegimenPensionario
            oeRegimenPen.TipoOperacion = ""
            oeRegimenPen.Activo = True
            oeRegimenPen.Vigente = 1
            leRegimenPen = olRegimenPen.Listar(oeRegimenPen)

            oeEmpresa = New e_Empresa
            oeEmpresa.TipoOperacion = ""
            oeEmpresa.Activo = True
            leEmpresa = olEmpresa.Listar(oeEmpresa)
            Dim _leEmp = leEmpresa.Where(Function(it) it.TipoEmpresa = "PRESTADORA DE SALUD").ToList
            LlenarCombo(cboEntidadPS, "Nombre", _leEmp, -1)

            oePlanEPS = New e_PlanesEPS
            oePlanEPS.TipoOperacion = ""
            oePlanEPS.Activo = True
            oePlanEPS.Vigente = 1
            lePlanEPS = olPlanEPS.Listar(oePlanEPS)
            LlenarCombo(cboPlanEPS, "Nombre", lePlanEPS, -1)

            LlenaComboConfigurable(cboPeriocidad, "T13_Periocidad", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboTipoPago, "T16_TipoPago", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboRegimenSalud, "T32_Reg_Aseg_Salud", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboConvenio, "T25_Convenios", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboBuscaEstado, "T15_Situacion", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboEstadoTra, "T15_Situacion", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboIndRuta, "IT1_RutaConductor", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboTipoTrabajador, "IT2_CategoriaTrabajador", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboTipoTrabBus, "IT2_CategoriaTrabajador", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboCategoriaPiloto, "IT3_CategoriaConductor", "ID", "NOMBRE", 0)
            LlenaComboConfigurable(cboVinculoDH, "T19_VinculoFamiliar", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboTipoDocDH, "T27_Acredita_Vinc_Fam", "CODIGO", "NOMBRE", -1)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializaOcupacion()
        'oeOcupacionTrab = New e_OcupacionTrabajador
        'oeOcupacionTrab.UsuarioCreacion = gUsuarioSGI.Id
        Dim _leContrAux = oeTrabajador.leContratos.Where(Function(it) it.Activo = True And it.Vigencia = True).ToList
        If _leContrAux.Count = 0 Then txtNroContrato.Text = String.Empty
        cboArea.Text = "RECURSOS HUMANOS"
        cboCargo.Text = "EMPLEADO DEL AREA"
        CboCentro.Text = "PACASMAYO"
        cboOcupacion.Text = "SIN OCUPACION ASIGNADA"
        TipoRelacionLaboral1.Seleccionar("1SI002")
        cboIndRuta.SelectedIndex = 0
        'oeOcupacionTrab.IdTipoRelacionLaboral = "1SI002"
        cboIndRuta.SelectedIndex = 0
        'oeOcupacionTrab.IdArea = cboArea.Value
        'oeOcupacionTrab.IdCargo = cboCargo.Value
        'oeOcupacionTrab.IdCentro = CboCentro.Value
        'oeOcupacionTrab.IdOcupacion = cboOcupacion.Value
        'oeOcupacionTrab.IndRuta = cboIndRuta.Value
        'If griOcupacion.Rows.Count = 0 Then
        '    oeOcupacionTrab.Principal = 1
        'Else
        '    oeOcupacionTrab.Principal = 0
        'End If
        fecFechaIngreso.Value = Date.Now.Date
        'oeOcupacionTrab.FechaIngreso = fecFechaIngreso.Value
        chkYaNoLabora.Checked = False
        verPrincipal.Checked = IIf(griOcupacion.Rows.Count > 0, False, True)
        FecFechaCese.Enabled = IIf(chkYaNoLabora.Checked, True, False)
    End Sub

    Private Sub MostrarOcupacion()
        Try
            oeOcupacionTrab = griOcupacion.ActiveRow.ListObject
            With oeOcupacionTrab
                cboArea.Value = .IdArea
                cboCargo.Value = .IdCargo
                CboCentro.Value = .IdCentro
                cboOcupacion.Value = .IdOcupacion
                TipoRelacionLaboral1.Seleccionar(.IdTipoRelacionLaboral)
                cboIndRuta.Value = .IndRuta
                fecFechaIngreso.Value = .FechaIngreso
                verPrincipal.Checked = IIf(.Principal = 1, True, False)
                If .FechaCese <> "01/01/1901" Then
                    FecFechaCese.Value = .FechaCese
                    chkYaNoLabora.Checked = True
                Else
                    chkYaNoLabora.Checked = False
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EnfocarOcupacion(ByVal ex As String)
        If ex.Contains("Area") Then cboArea.Focus()
        If ex.Contains("Cargo") Then cboCargo.Focus()
        If ex.Contains("Centro") Then CboCentro.Focus()
        If ex.Contains("Ocupacion") Then cboOcupacion.Focus()
    End Sub

    Private Sub GuardarOcupacion()
        Try
            oeOcupacionTrab.Modificado = True
            oeOcupacionTrab.IdArea = cboArea.Value
            oeOcupacionTrab.Area = cboArea.Text.Trim
            oeOcupacionTrab.IdCargo = cboCargo.Value
            oeOcupacionTrab.Cargo = cboCargo.Text.Trim
            oeOcupacionTrab.IdCentro = CboCentro.Value
            oeOcupacionTrab.Centro = CboCentro.Text.Trim
            oeOcupacionTrab.IdOcupacion = cboOcupacion.Value
            oeOcupacionTrab.Ocupacion = cboOcupacion.Text.Trim
            oeOcupacionTrab.IdTipoRelacionLaboral = TipoRelacionLaboral1.cboTipoRelacionLaboral.Value
            oeOcupacionTrab.TipoRelacionLaboral = TipoRelacionLaboral1.cboTipoRelacionLaboral.Text.Trim
            oeOcupacionTrab.FechaIngreso = fecFechaIngreso.Value
            oeOcupacionTrab.FechaCese = FecFechaCese.Value
            oeOcupacionTrab.Principal = IIf(verPrincipal.Checked, 1, 0)
            oeOcupacionTrab.IndRuta = cboIndRuta.Value
            oeOcupacionTrab.PrefijoID = gs_PrefijoIdSucursal '@0001
            If oeOcupacionTrab.TipoOperacion = "I" Then
                If griOcupacion.Rows.Count = 0 Then oeOcupacionTrab.Principal = 1
                loOcupacionTrabajador.Add(oeOcupacionTrab)
            Else
                If oeOcupacionTrab.Id.Trim.Length > 0 Then
                    oeOcupacionTrab.TipoOperacion = "A"
                Else
                    oeOcupacionTrab.TipoOperacion = "I"
                End If
            End If
            LlenarOcupacion(loOcupacionTrabajador)
            griOcupacion.DataBind()
            MostrarTabs(0, ficManOcupacion)
            'If olOcupacionTrabajador.Validar(oeOcupacionTrab) Then
            '    If oeOcupacionTrab.Id.Trim <> "" Then oeOcupacionTrab.Equivale = 1
            '    If Not loOcupacionTrabajador.Contains(oeOcupacionTrab) Then
            '        If griOcupacion.Rows.Count < 1 Then
            '            LlenarOcupacion(loOcupacionTrabajador)
            '            oeOcupacionTrab.Principal = 1
            '        End If
            '        oeOcupacionTrab.TipoOperacion = "I"
            '        loOcupacionTrabajador.Add(oeOcupacionTrab)
            '    Else
            '        Dim oe As New e_OcupacionTrabajador
            '        oe.Id = oeOcupacionTrab.Id.Trim : oe.Equivale = 1
            '        oe = loOcupacionTrabajador.Item(loOcupacionTrabajador.IndexOf(oe))
            '        'If oe.FechaCese <> "01/01/1901" And Not chkYaNoLabora.Checked Then
            '        '    For Each oeaux In loOcupacionTrabajador
            '        '        If oeaux.Principal = 1 AndAlso oeaux.Id.Trim <> oe.Id.Trim Then oeaux.Principal = 0 : oeaux.TipoOperacion = "A"
            '        '    Next
            '        '    'oeOcupacionTrab.Principal = 1
            '        '    'oeOcupacionTrab.TipoOperacion = "I"
            '        '    'loOcupacionTrabajador.Add(oeOcupacionTrab)
            '        'End If
            '        oe.IdArea = oeOcupacionTrab.IdArea
            '        oe.Area = oeOcupacionTrab.Area
            '        oe.IdCargo = oeOcupacionTrab.IdCargo
            '        oe.Cargo = oeOcupacionTrab.Cargo
            '        oe.IdCentro = oeOcupacionTrab.IdCentro
            '        oe.Centro = oeOcupacionTrab.Centro
            '        oe.IdTipoRelacionLaboral = oeOcupacionTrab.IdTipoRelacionLaboral
            '        oe.TipoRelacionLaboral = oeOcupacionTrab.TipoRelacionLaboral
            '        oe.FechaIngreso = oeOcupacionTrab.FechaIngreso
            '        oe.FechaCese = oeOcupacionTrab.FechaCese
            '        oe.Principal = oeOcupacionTrab.Principal
            '        oe.IndRuta = oeOcupacionTrab.IndRuta
            '        If band Then
            '            If oe.TipoOperacion.Trim = "E" Then
            '                oe.TipoOperacion = "A"
            '            Else
            '                Throw New Exception("Verifique la lista de ocupaciones de : " & oeTrabajador.oePersona.NombreCompleto & _
            '                                    ", pues " & oeOcupacionTrab.Ocupacion & ", ya ha sido agregada")
            '                ' oe.TipoOperacion = "A"
            '            End If
            '        Else
            '            oe.TipoOperacion = "A"
            '        End If
            '    End If
            '    LlenarOcupacion(loOcupacionTrabajador)
            '    'agrListaOcupaciones.Expanded = False
            '    MostrarTabs(0, ficManOcupacion)
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            EnfocarOcupacion(ex.Message)
        End Try

    End Sub

    Private Sub CargarTrabajador(ByVal _leTrabajador As List(Of e_Trabajador))
        Try
            With griTrabajador
                'Artificio para quitar los trabajadores que no se desean visualizar 
                Dim listadoGeneral = From le In _leTrabajador _
                           Select le.Id, le.oePersona.Dni, le.oePersona.NombreCompleto, Sexo = le.oePersona.oeSexo.Nombre _
                           , le.oePersona.FechaNacimiento, le.Codigo, le.FechaIngreso, le.FechaCese, Area = le.oeArea.Nombre _
                           , Ocupacion = le.oeOcupacion.Nombre, le.RelacionLaboral, le.Disponible, le.Activo, le.IndEstado, le.IndTipo

                If verFiltro.Checked Then
                    Dim _leAux = listadoGeneral.Where(Function(it) it.IndEstado = cboBuscaEstado.Value _
                                                          And it.IndTipo = cboTipoTrabBus.Value).OrderBy(Function(it) it.NombreCompleto).ToList
                    .DataSource = _leAux
                Else
                    .DataSource = listadoGeneral.ToList.OrderBy(Function(it) it.NombreCompleto).ToList
                End If

                OcultarColumna(griTrabajador, True, "Id", "IndEstado", "IndTipo", "Activo", "FechaCese")
                ExcluirColumna(griTrabajador, "Id")

                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 250
                .DisplayLayout.Bands(0).Columns("Area").Width = 200
                .DisplayLayout.Bands(0).Columns("Sexo").Width = 70
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 70
                .DisplayLayout.Bands(0).Columns("Ocupacion").Width = 200
                .DisplayLayout.Bands(0).Columns("RelacionLaboral").Width = 150

                .Font = New System.Drawing.Font("Tahoma", 8.25!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With

            For Each fila As UltraGridRow In griTrabajador.Rows
                Select Case fila.Cells("IndEstado").Value
                    Case 0 : fila.CellAppearance.BackColor = colorBaja.Color
                    Case 1 : fila.CellAppearance.BackColor = colorActivo.Color
                    Case 2 : fila.CellAppearance.BackColor = colorPorLiquidar.Color
                End Select
            Next

            'Ubica el cursor el el primer registro de la grilla
            If griTrabajador.Rows.Count > 0 Then
                griTrabajador.Focus()
                griTrabajador.Rows.Item(0).Selected = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarDatoPer(Pre As String)
        Try
            Dim _frm As New frm_Persona(Pre, oeTrabajador.oePersona)
            _frm.Width = 860
            _frm.Height = 400
            _frm.StartPosition = FormStartPosition.CenterScreen
            _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            _frm.ShowDialog()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            CargarDirEmaTel(Pre)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDirEmaTel(Pre As String)
        Select Case Pre
            Case "Dir"
                If oeTrabajador.oePersona.leDireccionEP.Count > 0 Then
                    Dim _leDirPri = oeTrabajador.oePersona.leDireccionEP.Where(Function(it) it.Principal = 1).ToList
                    If _leDirPri.Count > 0 Then
                        txtDireccion.Text = _leDirPri(0).Nombre
                    End If
                End If
            Case "Tel1"
                If oeTrabajador.oePersona.leTelefono.Count > 0 Then
                    Dim _leTel1Pri = oeTrabajador.oePersona.leTelefono.Where(Function(it) it.Principal = 1 And it.Tipo = 1).ToList
                    If _leTel1Pri.Count > 0 Then
                        txtCelular.Text = _leTel1Pri(0).Nombre
                    End If
                End If
            Case "Tel2"
                If oeTrabajador.oePersona.leTelefono.Count > 0 Then
                    Dim _leTel2Pri = oeTrabajador.oePersona.leTelefono.Where(Function(it) it.Principal = 1 And it.Tipo = 2).ToList
                    If _leTel2Pri.Count > 0 Then
                        txtTelefono.Text = _leTel2Pri(0).NumeroCompleto
                    End If
                End If
            Case "Ema"
                If oeTrabajador.oePersona.leEmail.Count > 0 Then
                    Dim _leEmaPri = oeTrabajador.oePersona.leEmail.Where(Function(it) it.Principal = 1).ToList
                    If _leEmaPri.Count > 0 Then
                        txtEmail.Text = _leEmaPri(0).Nombre
                    End If
                End If
        End Select
    End Sub

    Private Sub MantDocPer(Accion As String, oePerDoc As e_PersonaDocumento)
        Dim _frm As New frm_PersonaDocumento(Accion, oePerDoc, oeTrabajador.oePersona)
        _frm.Width = 700
        _frm.Height = 500
        _frm.StartPosition = FormStartPosition.CenterScreen
        _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        _frm.ShowDialog()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        CargarDocumentos(oeTrabajador.oePersona.leDocumento)
    End Sub

    Private Sub CargarDocumentos(leDocPer As List(Of e_PersonaDocumento))
        Try
            With griDocPersonales

                .ResetDisplayLayout()

                Dim _leActivo = leDocPer.Where(Function(it) it.Activo = True And it.Vigente = 1).ToList

                .DataSource = _leActivo

                .Text = String.Empty

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key <> "TipoDocumento" And col.Key <> "NumeroDocumento" And col.Key <> "Descripcion" And _
                        col.Key <> "FechaActividad" And col.Key <> "FechaVencimiento" Then col.Hidden = True
                    If col.Key.Contains("Id") Then col.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                Next

                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.Caption = "Tipo Doc."
                .DisplayLayout.Bands(0).Columns("NumeroDocumento").Header.Caption = "Nro Doc."

                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 250

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarDoc(leDocAux As List(Of e_PersonaDocumento))
        oePerDocumento.Id = griDocPersonales.ActiveRow.Cells("Id").Value
        oePerDocumento.Equivale = 1
        If leDocAux.Contains(oePerDocumento) Then
            oePerDocumento = leDocAux.Item(leDocAux.IndexOf(oePerDocumento))
            MantDocPer("Editar", oePerDocumento)
        End If
    End Sub

    Private Sub MantCtaPer(Accion As String, oeCtaBan As e_CuentaCtePersonal)
        Dim _frm As New frm_CuentaCtePersonal(Accion, oeCtaBan, oeTrabajador)
        _frm.Width = 700
        _frm.Height = 500
        _frm.StartPosition = FormStartPosition.CenterScreen
        _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        _frm.ShowDialog()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        CargarCuentasBancarias(oeTrabajador.leCtaBancaria)
    End Sub

    Private Sub CargarCuentasBancarias(leCtaBan As List(Of e_CuentaCtePersonal))
        Try
            With griCtaBancaria
                .ResetDisplayLayout()
                Dim _leActivo = leCtaBan.Where(Function(it) it.Activo = True And it.Vigente = 1).ToList
                .DataSource = _leActivo

                .Text = String.Empty

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key <> "NroCuenta" And col.Key <> "EntidadBancaria" And col.Key <> "TipoConcepto" And _
                        col.Key <> "Moneda" Then col.Hidden = True
                    If col.Key.Contains("Id") Then col.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                Next

                .DisplayLayout.Bands(0).Columns("EntidadBancaria").Width = 250
                .DisplayLayout.Bands(0).Columns("NroCuenta").Width = 150

                .DisplayLayout.Bands(0).Columns("NroCuenta").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("EntidadBancaria").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("TipoConcepto").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Moneda").Header.VisiblePosition = 3

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarCtaBan(leCtaAux As List(Of e_CuentaCtePersonal))
        oeCtaBancaria.Id = griCtaBancaria.ActiveRow.Cells("Id").Value
        oeCtaBancaria.Equivale = 1
        If leCtaAux.Contains(oeCtaBancaria) Then
            oeCtaBancaria = leCtaAux.Item(leCtaAux.IndexOf(oeCtaBancaria))
            MantCtaPer("Editar", oeCtaBancaria)
        End If
    End Sub

    Private Sub MantSuelTrab(Accion As String, oeSueTra As e_SueldoTrabajador)
        Dim _frm As New frm_SueldoTrabajador(Accion, oeSueTra, oeTrabajador)
        _frm.Width = 700
        _frm.Height = 500
        _frm.StartPosition = FormStartPosition.CenterScreen
        _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        _frm.ShowDialog()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        CargarSueldo(oeTrabajador.leSueldo)
    End Sub

    Private Sub CargarSueldo(leSue As List(Of e_SueldoTrabajador))
        Try
            If leSue.Count > 0 Then
                Dim _leSueAux = leSue.Where(Function(it) it.Activo = True And it.Vigente = 1).ToList
                If _leSueAux.Count > 0 Then
                    ndSueldoBasico.Value = _leSueAux(0).Sueldo
                    cboTipoPago.Value = _leSueAux(0).TipoPago
                    cboPeriocidad.Value = _leSueAux(0).Periocidad
                    fecSueldoActividad.Value = _leSueAux(0).FechaActividad
                Else
                    fecSueldoActividad.Value = Date.Now.Date
                End If
                btnEditarSueldo.Text = "Editar"
            Else
                fecSueldoActividad.Value = Date.Now.Date
                btnEditarSueldo.Text = "Agregar"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MantFonPen(Accion As String, oeFonPen As e_FondoPensionTrabajador)
        Dim _frm As New frm_FondoPensionTrabajador(Accion, oeFonPen, oeTrabajador)
        _frm.Width = 800
        _frm.Height = 500
        _frm.StartPosition = FormStartPosition.CenterScreen
        _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        _frm.ShowDialog()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        CargarFondoPension(oeTrabajador.leFondoPension)
    End Sub

    Private Sub CargarFondoPension(leFondoPen As List(Of e_FondoPensionTrabajador))
        Try
            If leFondoPen.Count > 0 Then
                Dim _leFonAux = leFondoPen.Where(Function(it) it.Activo = True And it.Vigente = 1).ToList
                If _leFonAux.Count > 0 Then
                    txtEmpresaFondo.Text = _leFonAux(0).Empresa
                    txtCussp.Text = _leFonAux(0).CUSPP
                    fecFondoTrab.Value = _leFonAux(0).FechaActividad
                    verMixta.Checked = _leFonAux(0).Mixta
                    agrComisionFlujo.Visible = IIf(_leFonAux(0).Mixta = 0, 1, 0)
                    agrComisionMixta.Visible = _leFonAux(0).Mixta
                    Dim _leRegAux = leRegimenPen.Where(Function(it) it.IdEmpresa = _leFonAux(0).IdEmpresa).ToList
                    If _leRegAux.Count > 0 Then
                        ndObligacion.Value = _leRegAux(0).PorcentajeObligatorio
                        ndComision.Value = _leRegAux(0).PorcentajeComision
                        ndSeguro.Value = _leRegAux(0).PorcentajeSeguros
                        ndComisionMixta.Value = _leRegAux(0).PorcentajeComisionMixta
                        ndSaldoMixta.Value = _leRegAux(0).PorcentajeSaldoMixta
                    End If
                    'ndObligacion.Value = _leFonAux(0)
                End If
                btnEditarFondo.Text = "Editar"
            Else
                btnEditarFondo.Text = "Agregar"
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub MantContrTrab(Accion As String, oeContrTrab As e_Contratos)
        Dim _frm As New frm_Contratos(Accion, oeContrTrab, oeTrabajador)
        _frm.Width = 1000
        _frm.Height = 500
        _frm.StartPosition = FormStartPosition.CenterScreen
        _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        _frm.ShowDialog()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        CargarContrato(oeTrabajador.leContratos)
    End Sub

    Private Sub CargarContrato(leContr As List(Of e_Contratos))
        Try
            If leContr.Count > 0 Then
                Dim _leContrAux = leContr.Where(Function(it) it.Activo = True And it.Vigencia = True).ToList
                If _leContrAux.Count > 0 Then
                    txtNroContrato.Text = _leContrAux(0).Codigo
                    If band Then
                        cboOcupacion.Value = _leContrAux(0).IdOcupacion
                        TipoRelacionLaboral1.Seleccionar(_leContrAux(0).IdTipoContrato)
                        fecFechaIngreso.Value = _leContrAux(0).FechaInicio
                    End If
                    Dim _leSuelAux = oeTrabajador.leSueldo.Where(Function(it) it.Activo = True And it.Vigente = 1).ToList
                    If _leSuelAux.Count = 0 Then
                        oeSueldoTrabajador = New e_SueldoTrabajador
                        oeSueldoTrabajador.Id = "ID"
                        oeSueldoTrabajador.Sueldo = _leContrAux(0).Sueldo
                        oeSueldoTrabajador.FechaActividad = _leContrAux(0).FechaInicio
                        oeSueldoTrabajador.Periocidad = 1
                        oeSueldoTrabajador.TipoPago = 2
                        oeSueldoTrabajador.Activo = True
                        oeSueldoTrabajador.Vigente = 1
                        oeSueldoTrabajador.UsuarioCreacion = gUsuarioSGI.Id
                        oeSueldoTrabajador.TipoOperacion = "I"
                        oeTrabajador.leSueldo.Add(oeSueldoTrabajador)
                        CargarSueldo(oeTrabajador.leSueldo)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MantRegSalud(Accion As String, oeRSalud As e_RegimenSalud)
        Dim _frm As New frm_PlanesEPS(Accion, oeRSalud, oeTrabajador)
        _frm.Width = 484
        _frm.Height = 301
        _frm.StartPosition = FormStartPosition.CenterScreen
        _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        _frm.ShowDialog()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        CargarRegimenSalud(oeTrabajador.leRegimenSalud)
    End Sub

    Private Sub CargarRegimenSalud(leRSalud As List(Of e_RegimenSalud))
        Try
            If leRSalud.Count > 0 Then
                Dim _leRSeg = leRSalud.Where(Function(it) it.Activo = True And it.Vigente = 1).ToList
                If _leRSeg.Count > 0 Then
                    cboRegimenSalud.Value = _leRSeg(0).Regimen
                    fecInicioRSalud.Value = _leRSeg(0).FechaInicio
                    fecFinRSalud.Value = _leRSeg(0).FechaFin
                    cboPlanEPS.Value = _leRSeg(0).IdPlanEPS
                    If cboPlanEPS.SelectedIndex > -1 Then
                        oePlanEPS = New e_PlanesEPS
                        oePlanEPS = cboPlanEPS.Items(cboPlanEPS.SelectedIndex).ListObject
                        cboEntidadPS.Value = oePlanEPS.IdEmpresa
                        Select Case _leRSeg(0).Adicional
                            Case 0 : ndCuotaEPS.Value = oePlanEPS.Precio
                            Case 1 : ndCuotaEPS.Value = oePlanEPS.Adicional1
                            Case 2 : ndCuotaEPS.Value = oePlanEPS.Adicional2
                            Case 3 : ndCuotaEPS.Value = oePlanEPS.Adicional3
                            Case 4 : ndCuotaEPS.Value = oePlanEPS.Adicional4
                            Case 5 : ndCuotaEPS.Value = oePlanEPS.Adicional5
                        End Select

                    End If
                End If
                btnEditarRegSalud.Text = "Editar"
            Else
                btnEditarRegSalud.Text = "Agregar"
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub MantSeguroComp(Accion As String, oeSComp As e_SeguroComplementario)
        Dim _frm As New frm_PlanesEPS(Accion, oeSComp, oeTrabajador)
        _frm.Width = 484
        _frm.Height = 301
        _frm.StartPosition = FormStartPosition.CenterScreen
        _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        _frm.ShowDialog()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        CargarSeguroComp(oeTrabajador.leSeguroComp)
    End Sub

    Private Sub CargarSeguroComp(leSComp As List(Of e_SeguroComplementario))
        Try
            If leSComp.Count > 0 Then
                Dim _leSComp = leSComp.Where(Function(it) it.Activo = True And it.Vigencia = 1).ToList
                If _leSComp.Count > 0 Then
                    optAportaSCTR.CheckedIndex = IIf(_leSComp(0).AportaSCTR, 1, 0)
                    optCoberturaSalud.CheckedIndex = _leSComp(0).CoberturaSalud
                    optSCTRPension.CheckedIndex = _leSComp(0).CoberturaPension
                    fecInicioSComp.Value = _leSComp(0).FechaInicio
                    fecFinSComp.Value = _leSComp(0).FechaFin
                    'cboEntidadPS.Value = 
                End If
                btnEditarSComp.Text = "Editar"
            Else
                btnEditarSComp.Text = "Agregar"
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarDerechoHabiente(leDerHab As List(Of e_DerechoHabiente))
        Try
            With griDerechoHabiente
                .ResetDisplayLayout()
                Dim _leDerHab = From le In leDerHab _
                                Select le.Id, IdPersona = le.oePersona.Id, le.oePersona.Dni, le.oePersona.FechaNacimiento, le.oePersona.NombreCompleto, _
                                Sexo = le.oePersona.oeSexo.Nombre, le.IndVinculo
                .DataSource = _leDerHab.ToList
                OcultarColumna(griDerechoHabiente, True, "Id", "IdPersona")
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 300
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

    Private Sub InicializaDerechoHabiente()
        txtDniDH.Text = String.Empty
        fecNacimientoDH.Value = Date.Now.Date
        txtApePaternoDH.Text = String.Empty
        txtApeMaternoDH.Text = String.Empty
        txtNombresDH.Text = String.Empty
        txtDireccion1DH.Text = String.Empty
        txtDireccion2DH.Text = String.Empty
        txtTelefono1DH.Text = String.Empty
        txtTelefono2DH.Text = String.Empty
        cboVinculoDH.SelectedIndex = -1
        cboTipoDocDH.SelectedIndex = -1
        txtNroDocDH.Text = String.Empty
        numMesGestacion.Value = 0
        btnPersonaDH.Visible = True
    End Sub

    Private Sub EditarDerechoHabiente()
        Try
            If griDerechoHabiente.Selected.Rows.Count > 0 Then
                btnPersonaDH.Text = " EDITAR " : btnPersonaDH.Tag = "Editar" : btnPersonaDH.Visible = True
                oeDerechoHab = New e_DerechoHabiente
                oeDerechoHab.TipoBuscar = 1
                oeDerechoHab.oePersona.Dni = griDerechoHabiente.ActiveRow.Cells("Dni").Value
                If leDerechoHab.Contains(oeDerechoHab) Then
                    oeDerechoHab = leDerechoHab.Item(leDerechoHab.IndexOf(oeDerechoHab))
                    MostrarDerechoHabiente()
                    MostrarTabs(1, ficDerechoHabiente, 0)
                End If
            Else
                Throw New Exception("Seleccione un Registro de Derecho Habiente para editar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MostrarDerechoHabiente()
        MostrarPersDH()
        cboVinculoDH.Value = oeDerechoHab.IndVinculo.Trim
        cboTipoDocDH.Value = oeDerechoHab.TipoDocAcredita.Trim
        txtNroDocDH.Text = oeDerechoHab.NroDocumentoAcredita
        numMesGestacion.Value = oeDerechoHab.MesConcepcion
    End Sub

    Private Sub MostrarPersDH()
        Try
            txtDniDH.Text = oeDerechoHab.oePersona.Dni
            txtApePaternoDH.Text = oeDerechoHab.oePersona.ApellidoPaterno
            txtApeMaternoDH.Text = oeDerechoHab.oePersona.ApellidoMaterno
            txtNombresDH.Text = oeDerechoHab.oePersona.Nombre
            fecNacimientoDH.Value = oeDerechoHab.oePersona.FechaNacimiento
            Sexo2.Sexo = New e_Sexo(CType(oeDerechoHab.oePersona.oeSexo.Id, String))
            If oeDerechoHab.oePersona.leDireccionEP.Count > 0 Then
                Dim _leDir1 = oeDerechoHab.oePersona.leDireccionEP.Where(Function(it) it.Principal = 1).ToList
                If _leDir1.Count > 0 Then txtDireccion1DH.Text = _leDir1(0).Nombre
                Dim _leDir2 = oeDerechoHab.oePersona.leDireccionEP.Where(Function(it) it.Principal = 0).ToList
                If _leDir2.Count > 0 Then txtDireccion2DH.Text = _leDir2(0).Nombre
            End If
            If oeDerechoHab.oePersona.leTelefono.Count > 0 Then
                Dim _leTel1 = oeDerechoHab.oePersona.leTelefono.Where(Function(it) it.Principal = 1).ToList
                If _leTel1.Count > 0 Then txtTelefono1DH.Text = _leTel1(0).NumeroCompleto
                Dim _leTel2 = oeDerechoHab.oePersona.leTelefono.Where(Function(it) it.Principal = 0).ToList
                If _leTel2.Count > 0 Then txtDireccion2DH.Text = _leTel2(0).NumeroCompleto
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarDatos() As Boolean
        Try
            If bandForm <> "T" Then
                Dim ls_Msg As String = String.Empty
                If oeTrabajador.IndTipo = 0 And oeTrabajador.IndEstado > 0 Then
                    If oeTrabajador.leContratos.Count = 0 Then ls_Msg = " (*) Contrato." & Environment.NewLine
                    If oeTrabajador.leSueldo.Count = 0 Then ls_Msg = ls_Msg & " (*) Sueldo." & Environment.NewLine
                    If oeTrabajador.leRegimenSalud.Count = 0 Then ls_Msg = ls_Msg & " (*) Regimen de Salud." & Environment.NewLine
                    If oeTrabajador.leFondoPension.Count = 0 Then ls_Msg = ls_Msg & " (*) Fondo de Pension." & Environment.NewLine
                    If oeTrabajador.leSeguroComp.Count = 0 Then ls_Msg = ls_Msg & " (*) Seguro Complementario." & Environment.NewLine
                    If ls_Msg.Length > 0 Then
                        ls_Msg = "Necesita Ingresar la Siguiente Información: " & Environment.NewLine & ls_Msg & "¿Desea Continuar con la Operación?"
                        If MessageBox.Show(ls_Msg, "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            Return False
                        End If
                    End If
                End If
            End If            
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ms_EditarOcupacion()
        Try
            If griOcupacion.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Registro!")
            If griOcupacion.ActiveRow.Index = -1 Then Throw New Exception("¡Seleccione un Registro!")
            InicializaOcupacion()
            oeOcupacionTrab = New e_OcupacionTrabajador
            oeOcupacionTrab = griOcupacion.ActiveRow.ListObject
            If oeOcupacionTrab.FechaCese <> #1/1/1901# Then Throw New Exception("¡No se puede Modificar por que el trabajador esta cesado!")
            oeOcupacionTrab.TipoOperacion = "A"
            With oeOcupacionTrab
                cboArea.Value = .IdArea
                cboCargo.Value = .IdCargo
                CboCentro.Value = .IdCentro
                cboOcupacion.Value = .IdOcupacion
                TipoRelacionLaboral1.Seleccionar(.IdTipoRelacionLaboral)
                cboIndRuta.Value = .IndRuta
                fecFechaIngreso.Value = .FechaIngreso
                verPrincipal.Checked = IIf(.Principal = 1, True, False)
                If .FechaCese <> "01/01/1901" Then
                    FecFechaCese.Value = .FechaCese
                    chkYaNoLabora.Checked = True
                Else
                    chkYaNoLabora.Checked = False
                End If
            End With
            oeOcupacionTrab.Modificado = False
            MostrarTabs(1, ficManOcupacion)
            band = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Trabajador_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griTrabajador_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griTrabajador.InitializeLayout
        AgrGrillaTrabajador.Text = "Total de Trabajadores: " & e.Layout.Rows.Count
    End Sub

    Private Sub griTrabajador_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griTrabajador.MouseMove
        If _tiempo <= 0 Then
            'Listar(_Activo)
            Listar()
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Trabajador"

    Private Sub AsociarMenu()
        griTrabajador.ContextMenuStrip = mcTrabajador
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

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcTrabajador.Opening
        mcTrabajador.Items("InsertarToolStripMenuItem").Visible = True
        If griTrabajador.Selected.Rows.Count > 0 Then
            mcTrabajador.Items("ActualizarToolStripMenuItem").Visible = True
            mcTrabajador.Items(1).Text = "Actualizar información de : " & griTrabajador.ActiveRow.Cells("NombreCompleto").Value
            mcTrabajador.Items("EliminarToolStripMenuItem").Visible = True
            mcTrabajador.Items(2).Text = "Eliminar información de : " & griTrabajador.ActiveRow.Cells("NombreCompleto").Value
            mcTrabajador.Items(3).Visible = True
        Else
            mcTrabajador.Items("ActualizarToolStripMenuItem").Visible = False
            mcTrabajador.Items("EliminarToolStripMenuItem").Visible = False
            mcTrabajador.Items(3).Visible = False
        End If
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Try
            FotoInsert = 0
            FotoRuta = ""
            FotoTamaño = 0
            Dim ofd_Imagen As New OpenFileDialog
            With ofd_Imagen
                .Filter = "Imágenes JPG (*.jpg)|*.jpg"
                .FilterIndex = 1
                .Title = "Abrir imagen ..."
            End With
            If ofd_Imagen.ShowDialog = Windows.Forms.DialogResult.OK Then
                FotoRuta = ofd_Imagen.FileName
                Fs = New FileStream(ofd_Imagen.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                upbFoto.Image = System.Drawing.Image.FromStream(Fs)
                FotoInsert = 1
            End If
            ofd_Imagen.Dispose()
            ofd_Imagen = Nothing
            If FotoRuta <> "" Then
                Dim fichero As New FileInfo(FotoRuta)
                FotoTamaño = fichero.Length
                If FotoTamaño > 51200 Then
                    FotoRuta = ""
                    Fs.Dispose()
                    upbFoto.Image = Nothing
                    Throw New Exception("El tamaño del archivo es: " & FormatNumber((FotoTamaño / 1024), 2) & " KB. excede a lo permito de 50 KB.")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            FotoInsert = 0
            upbFoto.Image = Nothing
            oeTrabajador.Foto = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnDescargarJpg_Click(sender As Object, e As EventArgs) Handles btnDescargarJpg.Click
        Try
            If upbFoto.Image IsNot Nothing Then
                Dim NombreArchivo As String = ""
                Dim sfd_Dialogo As New System.Windows.Forms.SaveFileDialog
                sfd_Dialogo.Filter = "Imágenes JPG (*.jpg)|*.jpg"
                sfd_Dialogo.DefaultExt = "jpg"
                sfd_Dialogo.FilterIndex = 1
                sfd_Dialogo.Title = "Guardar imagen ..."
                sfd_Dialogo.FileName = txtDni.Text.Trim
                Dim result As DialogResult = sfd_Dialogo.ShowDialog()
                If result = DialogResult.Cancel Then Return
                Dim stNombreArchivo As String = sfd_Dialogo.FileName
                imagenGuardar.Image.Save(stNombreArchivo, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminaciónDefinitivaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminaciónDefinitivaToolStripMenuItem.Click
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                With griTrabajador
                    If ValidarGrilla(griTrabajador, "Trabajador") Then
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.Id = .ActiveRow.Cells("ID").Value : oeTrabajador.CargaCompleto = True
                        oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                        If oeTrabajador.IndEstado = 2 Then
                            If MessageBox.Show("Esta seguro en dar de baja el Trabajador: " & oeTrabajador.oePersona.NombreCompleto & " ?", "Mensaje de Sistema",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                Dim formulario As frm_AutenticarTrabajador
                                formulario = New frm_AutenticarTrabajador
                                formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                                If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                                    Throw New Exception("Ingrese un Clave Correcta")
                                Else
                                    oeTrabajador.TipoOperacion = "A" : oeTrabajador.IndEstado = 0 : oeTrabajador.FechaCreacion = Date.Now
                                    oeTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                                    If olTrabajador.Guardar(oeTrabajador) Then Consultar(True)
                                End If
                            End If
                        Else
                            Throw New Exception("Para Realizar esta Operacion el Trabajador debe tener el estado: PENDIENTE POR LIQUIDAR")
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

#End Region

#Region "Menú Contextual de Ocupacion"

    Private Sub mnuOcupacion_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuOcupacion.Opening
        mnuOcupacion.Items("tsmiAgregar").Visible = True
        mnuOcupacion.Items(0).Text = "Agregar Ocupación a : " & oeTrabajador.oePersona.NombreCompleto
        mnuOcupacion.Items("tsmiEditar").Visible = False
        mnuOcupacion.Items("tsmiQuitar").Visible = False
        If griOcupacion.Selected.Rows.Count > 0 Then
            mnuOcupacion.Items("tsmiEditar").Visible = True
            mnuOcupacion.Items(1).Text = "Actualizar Ocupación de : " & oeTrabajador.oePersona.NombreCompleto
            mnuOcupacion.Items("tsmiQuitar").Visible = True
            mnuOcupacion.Items(2).Text = "Quitar Ocupación de: " & oeOcupacionTrab.Ocupacion & " a " & oeTrabajador.oePersona.NombreCompleto
        End If
    End Sub

    Private Sub tsmiAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregar.Click
        ' agrListaOcupaciones.Expanded = True
        oeOcupacionTrab = New e_OcupacionTrabajador
        oeOcupacionTrab.TipoOperacion = "I" : oeOcupacionTrab.Activo = True
        oeOcupacionTrab.UsuarioCreacion = gUsuarioSGI.Id
        InicializaOcupacion()
        oeOcupacionTrab.Modificado = False
        MostrarTabs(1, ficManOcupacion)
        band = True
    End Sub

    Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar.Click
        'Try
        '    If griOcupacion.Selected.Rows.Count > 0 Then
        '        If griOcupacion.ActiveRow.Cells("FechaCese").Value = "01/01/1901" Then
        '            CargaOcupacion()
        '        Else
        '            Throw New Exception("No Puede Actualizar Datos de un Trabajador Cesado")
        '        End If
        '    Else
        '        Throw New Exception("Seleccion un Registro de Ocupacion Para Editar")
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
        ms_EditarOcupacion()
    End Sub

    Private Sub CargaOcupacion()
        'agrListaOcupaciones.Expanded = True
        MostrarTabs(1, ficManOcupacion)
        InicializaOcupacion()
        MostrarOcupacion()
        oeOcupacionTrab.Modificado = False
        band = False
    End Sub

    Private Sub tsmiQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitar.Click
        QuitarOcupacion()
    End Sub

    Private Sub QuitarOcupacion()
        Try
            oeOcupacionTrab = griOcupacion.ActiveRow.ListObject

            If griOcupacion.Rows.Count <= 1 Then
                Throw New Exception("Operación no permitida, porque todo trabajador, debe tener al menos una ocupación")
            End If

            If oeOcupacionTrab.Principal Then
                Throw New Exception("No se puede eliminar la ocupación principal, si desea hacerlo, primero elija otra ocupación como principal")
            End If

            oeOcupacionTrab = loOcupacionTrabajador.Item(loOcupacionTrabajador.IndexOf(oeOcupacionTrab))
            If MessageBox.Show("¿Desea Eliminar la Ocupacion: " & oeOcupacionTrab.Ocupacion & "?", "Mensaje de sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If oeOcupacionTrab.Id <> "" Then
                    oeOcupacionTrab.TipoOperacion = "E"
                Else
                    loOcupacionTrabajador.Remove(oeOcupacionTrab)
                End If
                LlenarOcupacion(loOcupacionTrabajador)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menu Contextual Derecho Habiente"

    Private Sub mnuDerechoHabiente_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuDerechoHabiente.Opening
        mnuDerechoHabiente.Items("tsmiAgregarDH").Enabled = True
        mnuDerechoHabiente.Items("tsmiEditarDH").Enabled = IIf(griDerechoHabiente.Selected.Rows.Count > 0, True, False)
        mnuDerechoHabiente.Items("tsmiQuitarDH").Enabled = IIf(griDerechoHabiente.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiAgregarDH_Click(sender As Object, e As EventArgs) Handles tsmiAgregarDH.Click
        MostrarTabs(1, ficDerechoHabiente, 0)
        InicializaDerechoHabiente()
        oeDerechoHab = New e_DerechoHabiente
        oeDerechoHab.NroLinea = griDerechoHabiente.Rows.Count + 1
        txtDniDH.Focus()
        btnPersonaDH.Text = " AGREGAR " : btnPersonaDH.Tag = "Agregar"
    End Sub

    Private Sub tsmiEditarDH_Click(sender As Object, e As EventArgs) Handles tsmiEditarDH.Click
        EditarDerechoHabiente()
    End Sub

    Private Sub tsmiQuitarDH_Click(sender As Object, e As EventArgs) Handles tsmiQuitarDH.Click
        Try
            If MessageBox.Show("¿Desea Eliminar el Registro de Derecho Habiente?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oeDerechoHab = New e_DerechoHabiente
                oeDerechoHab.oePersona.Dni = griDerechoHabiente.ActiveRow.Cells("Dni").Value
                oeDerechoHab.TipoBuscar = 1
                If leDerechoHab.Contains(oeDerechoHab) Then
                    oeDerechoHab = leDerechoHab.Item(leDerechoHab.IndexOf(oeDerechoHab))
                    If oeDerechoHab.Id.Trim = String.Empty Then
                        leDerechoHab.Remove(oeDerechoHab)
                    Else
                        oeDerechoHab.TipoOperacion = "E" : oeDerechoHab.Activo = False
                    End If
                    CargarDerechoHabiente(leDerechoHab)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Ayuda contextual"

    'Private Sub frm_Trabajador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, griOcupacion.KeyDown
    '    If e.KeyCode = Keys.F1 Then
    '        MostrarAyudaTrabajador()
    '    End If
    'End Sub

    ''' <summary>
    ''' Mostrar la ayuda contextual de listado de trabajadores
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griTrabajador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griTrabajador.KeyDown
        If e.KeyCode = Keys.F1 Then
            Help.ShowHelp(griTrabajador, m_Funciones.SiteAyudaSGI & "Personal/PER_Trabajador.aspx/#Listar")
        End If
    End Sub

    ''' <summary>
    ''' Método para mostrar la ayuda contextual del trabajador
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MostrarAyudaTrabajador()
        Help.ShowHelp(ficTrabajador, m_Funciones.SiteAyudaSGI & "Personal/PER_Trabajador.aspx")
    End Sub

    ''' <summary>
    ''' Mostrar la ayuda contextual de creación de trabajadores
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtDni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDni.KeyDown
        TeclaPulsada(e)
        If e.KeyCode = Keys.F1 Then
            If oeTrabajador.TipoOperacion = "I" Then
                Help.ShowHelp(griTrabajador, m_Funciones.SiteAyudaSGI & "Personal/PER_Trabajador.aspx/#Nuevo")
            Else
                Help.ShowHelp(griTrabajador, m_Funciones.SiteAyudaSGI & "Personal/PER_Trabajador.aspx/#Actualizar")
            End If
        End If
    End Sub

    Private Sub AyudaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem1.Click
        MostrarAyudaTrabajador()
    End Sub

    Private Sub AyudaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem2.Click
        MostrarAyudaTrabajador()
    End Sub

#End Region

End Class