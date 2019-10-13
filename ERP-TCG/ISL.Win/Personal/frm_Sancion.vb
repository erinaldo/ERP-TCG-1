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

Public Class frm_Sancion
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Sancion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Sancion
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeSancion As New e_Sancion, olSancion As New l_Sancion, leSancion As New List(Of e_Sancion)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador
    Private leTrabajadorBus As New List(Of e_Trabajador), leTrabajador As New List(Of e_Trabajador)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeArea As New e_Area, olArea As New l_Area, leArea As New List(Of e_Area), leAreaBus As New List(Of e_Area)
    Private olPersona As New l_Persona
    Private oeGrupoSancion As New e_GrupoSancion, olGrupoSancion As New l_GrupoSancion
    Private _opeSanc As String = "", _acl As String = "", _estado As String = "", dtSituacion As Data.DataTable

    Dim _ingresando_datos As Boolean = False
    Dim bandCargar As Boolean

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griSancion.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeSanc = "PENDIENTE"
                MostrarTabs(1, ficSancion, 1)
                Inicializar()
                oeSancion.TipoOperacion = "I"
                oeSancion.Modificado = False
                Dim _leTrabAct = From le In leTrabajador _
                                Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado
                                Where Activo = True And IndEstado <> 0
                                Order By NombreCompleto
                LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAct.ToList, -1)
                cboTrabajador.ReadOnly = False
                cboEstado.Text = "PENDIENTE"
                fecFecha.Focus()
                fecFecha.Enabled = True
                cboArea.ReadOnly = False
                cboGrupo.ReadOnly = False
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
                _opeSanc = "EDITAR"
                Dim _leTrab = From le In leTrabajador _
                             Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni
                             Order By NombreCompleto
                LlenarCombo(cboTrabajador, "NombreCompleto", _leTrab.ToList, -1)
                cboTrabajador.ReadOnly = True
                Mostrar()
                oeSancion.TipoOperacion = "A"
                oeSancion.Modificado = False
                Operacion = "Editar"
                fecFecha.Enabled = False
                cboArea.ReadOnly = True
                cboGrupo.ReadOnly = True
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
                MostrarTabs(1, ficSancion, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeSancion.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficSancion)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficSancion)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficSancion)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficSancion)
                _ingresando_datos = False
                Consultar(_Activo)
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
                With griSancion
                    If ValidarGrilla(griSancion, "Sancion") Then
                        oeSancion.Id = .ActiveRow.Cells("ID").Value
                        oeSancion = olSancion.Obtener(oeSancion)
                        If oeSancion.Activo Then
                            _estado = gNombreEstadoPendiente
                            If oeSancion.Estado = _estado Then
                                If MessageBox.Show("¿Esta seguro de eliminar la Sancion: " & .ActiveRow.Cells("Trabajador").Value.ToString & " ?", _
                                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                    MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                    Dim formulario As frm_AutenticarTrabajador
                                    formulario = New frm_AutenticarTrabajador
                                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                                        Throw New Exception("Ingrese un Clave Correcta")
                                    Else
                                        oeSancion.TipoOperacion = "E"
                                        olSancion.Eliminar(oeSancion)
                                        Consultar(True)
                                    End If
                                End If
                            Else
                                Throw New Exception("La Sanción debe estar PENDIENTE para poder Eliminar")
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
                If ficSancion.Tabs(0).Selected AndAlso griSancion.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                If ficSancion.Tabs(0).Selected Then Exportar_Excel(griSancion)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Sancion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                Nuevo()
            Case "Editar"
                Editar()
            Case "Inicializa"
                If griSancion.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_Sancion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Sancion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Sancion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Tiempo1.Enabled = False
            MostrarTabs(0, ficSancion)
            CargarCombos()
            bandCargar = True
            colorPendiente.Color = Color.Transparent
            colorAprobada.Color = Color.LightYellow
            colorAnulado.Color = Color.LightCoral
            colorGenerada.Color = Color.LightBlue
            colorIntegrada.Color = Color.LightGreen
            leSancion = New List(Of e_Sancion)
            CargarSanciones(leSancion)
            bandCargar = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboArea_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.Validated
        If cboArea.SelectedIndex > -1 Then
            If oeSancion.TipoOperacion = "I" Then CargaGrupoConcepto()
        End If
    End Sub

    'Private Sub fecFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFecha.ValueChanged
    '    oeSancion.Fecha = fecFecha.Value
    'End Sub

    Private Sub cboTrabajador_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajador.ValueChanged
        If cboTrabajador.SelectedIndex > -1 Then
            Dim dtAux As Data.DataTable
            'oeSancion.IdTrabajador = cboTrabajador.Value
            oeTrabajador = New e_Trabajador
            oeTrabajador.Id = cboTrabajador.Value
            oeTrabajador.TipoBusca = 1
            If leTrabajador.Contains(oeTrabajador) Then
                oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                dtAux = FiltraDTable(dtSituacion, "CODIGO = '" & oeTrabajador.IndEstado & "'", "")
                If dtAux.Rows.Count > 0 Then txtEstado.Text = dtAux.Rows(0).Item("NOMBRE").ToString
                txtDni.Text = oeTrabajador.oePersona.Dni
                txtArea.Text = oeTrabajador.oeArea.Nombre
                txtOcupacion.Text = oeTrabajador.oeOcupacion.Nombre
                If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then picTrabajador.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
                'oeSueldo = New e_SueldoTrabajador
                'oeSueldo.IdTrabajador = oeTrabajador.Id
                'oeSueldo.Equivale = 1
                'If leSueldo.Contains(oeSueldo) Then
                '    oeSueldo = leSueldo.Item(leSueldo.IndexOf(oeSueldo))
                '    _sueldo = oeSueldo.Sueldo
                'End If
                'ndRenumeracion.Value = _sueldo + IIf(oeTrabajador.IndHijo = 1, _asigfam, 0)
                'ndDeuda.Value = 0 : ndTotalCuota.Value = 0 : ndTotalCuota.Appearance.BackColor = Color.Transparent
            End If
        End If

    End Sub

    'Private Sub cboArea_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.ValueChanged
    '    If cboArea.SelectedIndex > -1 Then oeSancion.IdArea = cboArea.Value
    'End Sub

    'Private Sub cboConceptoSancion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConceptoSancion.ValueChanged
    '    If cboConceptoSancion.SelectedIndex > -1 Then oeSancion.IdConcepto = cboConceptoSancion.Value
    'End Sub

    'Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
    '    oeSancion.Glosa = txtGlosa.Text
    'End Sub

    'Private Sub decImporte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImporte.ValueChanged
    '    oeSancion.Monto = decImporte.Value
    'End Sub

    'Private Sub cboGrupo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.ValueChanged
    '    If cboGrupo.SelectedIndex > -1 Then oeSancion.IdGrupo = cboGrupo.Value
    'End Sub

    Private Sub griSancion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griSancion.DoubleClick
        If griSancion.Rows.Count > 0 Then Editar()
    End Sub


#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            oeTrabajador = New e_Trabajador
            oeTrabajador.Id = ""
            oeTrabajador.oePersona.ApellidoPaterno = "TODOS"
            leTrabajadorBus.Add(oeTrabajador)

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            leTrabajadorBus.AddRange(leTrabajador.OrderBy(Function(it) it.oePersona.NombreCompleto))
            ' _leTrabBus[Lista] (Id, NombreCompleto) {e_Trabajador}
            Dim _leTrabBus = From le In leTrabajadorBus _
                             Select le.Id, le.oePersona.NombreCompleto
            LlenarCombo(cboTrabajadorBus, "NombreCompleto", _leTrabBus.ToList, 0)

            oeArea = New e_Area
            oeArea.Id = ""
            oeArea.Nombre = "TODOS"
            leAreaBus.Add(oeArea)
            oeArea = New e_Area
            oeArea.Activo = True
            oeArea.TipoOperacion = ""
            leArea.AddRange(olArea.Listar(oeArea))
            leAreaBus.AddRange(leArea)

            LlenarCombo(cboAreaBus, "Nombre", leAreaBus, 0)
            LlenarCombo(cboArea, "Nombre", leArea, -1)

            oeEstado = New e_Estado
            oeEstado.Nombre = "SANCION"
            leEstado = olEstado.Listar(oeEstado)
            LlenarCombo(cboEstado, "Nombre", leEstado, -1)

            Dim _leEstaAux As New List(Of e_Estado)
            oeEstado = New e_Estado
            oeEstado.Id = ""
            oeEstado.Nombre = " [TODOS] "
            _leEstaAux.Add(oeEstado)
            _leEstaAux.AddRange(leEstado)
            LlenarCombo(cboEstadoBus, "Nombre", _leEstaAux, 1)

            If gUsuarioSGI.Controlado > 0 Then
                cboAreaBus.Text = gUsuarioSGI.oeArea.Nombre
                cboAreaBus.ReadOnly = True
            Else
                cboAreaBus.SelectedIndex = 0
                cboAreaBus.ReadOnly = False
            End If

            dtSituacion = GenerarDTConfigurable(CargarCTCD("T15_Situacion"))

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar()
        Try
            oeSancion = New e_Sancion
            oeSancion.Activo = True
            oeSancion.TipoOperacion = "1"
            oeSancion.IdEstado = cboEstadoBus.Value
            oeSancion.IdTrabajador = cboTrabajadorBus.Value
            oeSancion.IdArea = cboAreaBus.Value
            leSancion = olSancion.Listar(oeSancion).OrderByDescending(Function(it) it.Fecha).ToList
            CargarSanciones(leSancion)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griSancion.Focus()
    End Sub

    Private Sub CargarSanciones(ByVal leSancion As List(Of e_Sancion))
        Try
            With griSancion

                .DataSource = leSancion

                If bandCargar Then

                    OcultarColumna(griSancion, True, "IdGrupo", "IdTrabajador", "IdArea", "Id", "IdConcepto", "IdResponsable", "IdEstado", _
                                   "Activo", "FechaCreacion", "UsuarioCreacion", "IdUsuarioAprueba", "FechaAprobacion")

                    .DisplayLayout.Bands(0).Columns("Area").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Concepto").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("Responsable").Header.VisiblePosition = 6

                    .DisplayLayout.Bands(0).Columns("Area").Width = 120
                    .DisplayLayout.Bands(0).Columns("Fecha").Width = 70
                    .DisplayLayout.Bands(0).Columns("Trabajador").Width = 200
                    .DisplayLayout.Bands(0).Columns("Concepto").Width = 120
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 250
                    .DisplayLayout.Bands(0).Columns("Responsable").Width = 150

                    FormatoColumna(griSancion, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")

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

                If .Rows.Count > 0 Then
                    For Each oFila As UltraGridRow In .Rows
                        Select Case oFila.Cells("Estado").Value
                            Case "PENDIENTE" : oFila.Cells("Estado").Appearance.BackColor = colorPendiente.Color
                            Case "APROBADA" : oFila.Cells("Estado").Appearance.BackColor = colorAprobada.Color
                            Case "ANULADO" : oFila.Cells("Estado").Appearance.BackColor = colorAnulado.Color
                            Case "GENERADA" : oFila.Cells("Estado").Appearance.BackColor = colorGenerada.Color
                            Case "INTEGRADA" : oFila.Cells("Estado").Appearance.BackColor = colorIntegrada.Color
                        End Select
                    Next
                End If

                CalcularTotales(griSancion, "Monto")

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        fecFecha.Value = Date.Now.Date
        cboEstado.ReadOnly = True
        cboTrabajador.SelectedIndex = -1
        cboArea.SelectedIndex = -1
        cboGrupo.SelectedIndex = -1
        cboConceptoSancion.SelectedIndex = -1
        txtGlosa.Text = String.Empty
        If gUsuarioSGI.Controlado > 0 Then
            cboArea.Text = gUsuarioSGI.oeArea.Nombre
            CargaGrupoConcepto()
            cboArea.ReadOnly = True
        Else
            cboArea.SelectedIndex = -1
            cboArea.ReadOnly = False
        End If
        decImporte.Value = 0
        numCuotas.Value = 1
        picTrabajador.Image = Nothing
        txtArea.Text = String.Empty
        txtEstado.Text = String.Empty
        txtDni.Text = String.Empty
        txtOcupacion.Text = String.Empty
    End Sub

    Private Sub Mostrar()
        Try
            If griSancion.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeSancion.TipoOperacion = "1"
                oeSancion.Id = griSancion.ActiveRow.Cells("Id").Value.ToString
                oeSancion = olSancion.Obtener(oeSancion)
                With oeSancion
                    fecFecha.Value = .Fecha
                    cboTrabajador.Value = .IdTrabajador
                    cboArea.Value = .IdArea
                    CargaGrupoConcepto()
                    cboGrupo.Value = .IdGrupo
                    cboConceptoSancion.Value = .IdConcepto
                    txtGlosa.Text = .Glosa
                    decImporte.Value = .Monto
                    numCuotas.Value = .NroCuota
                    cboEstado.Value = .IdEstado
                End With
                MostrarTabs(1, ficSancion, 1)
                MyBase.Editar()
                BuscaFoto()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            Select Case _opeSanc
                Case "PENDIENTE"
                    RecolectaDatos()
                    oeSancion.UsuarioCreacion = gUsuarioSGI.Id
                    oeSancion.IdResponsable = gUsuarioSGI.IdTrabajador
                    oeSancion.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olSancion.Guardar(oeSancion) Then
                        mensajeEmergente.Confirmacion("La Sanción ha sido guardado correctamente en " & Me.Text, True)
                        MostrarTabs(0, ficSancion, 2)
                        Consultar(True)
                        griSancion.Focus()
                        Return True
                    End If
                Case "EDITAR"
                    RecolectaDatos()
                    oeSancion.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olSancion.Guardar(oeSancion) Then
                        mensajeEmergente.Confirmacion("La Sanción ha sido editado correctamente en " & Me.Text, True)
                        MostrarTabs(0, ficSancion, 2)
                        Consultar(True)
                        griSancion.Focus()
                        Return True
                    End If
                Case "APROBAR"
                    RecolectaDatos()
                    oeSancion.IdUsuarioAprueba = gUsuarioSGI.Id
                    oeSancion.FechaAprobacion = Date.Now.Date
                    oeSancion.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olSancion.Guardar(oeSancion) Then
                        mensajeEmergente.Confirmacion("La Sanción ha sido APROBADA correctamente", True)
                        MostrarTabs(0, ficSancion, 2)
                        Consultar(True)
                        griSancion.Focus()
                        Return True
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            'Enfocar(ex.Message)
        End Try
    End Function

    Private Sub CargaGrupoConcepto()
        Dim oeConSan As New e_Concepto_Prestamo
        Dim olConSan As New l_Concepto_Prestamo
        oeConSan.Tipo = 2
        oeConSan.IdArea = cboArea.Value
        oeConSan.TipoOperacion = ""
        LlenarCombo(cboConceptoSancion, "Nombre", olConSan.Listar(oeConSan), -1)
        oeGrupoSancion = New e_GrupoSancion
        oeGrupoSancion.TipoOperacion = ""
        oeGrupoSancion.IdArea = cboArea.Value
        oeGrupoSancion._NombreEstado = "GENERADA"
        LlenarCombo(cboGrupo, "Codigo", olGrupoSancion.Listar(oeGrupoSancion).OrderByDescending(Function(item) item.Fecha).ToList, -1)
    End Sub

    Private Sub BuscaFoto()
        Try
            'oeTrab (Id, NombreCompleto, Dni) {e_Trabajador}
            Dim oeTrab = cboTrabajador.Items(cboTrabajador.SelectedIndex).ListObject
            If Not String.IsNullOrEmpty(oeTrab.Dni) Then picTrabajador.Image = olPersona.Foto(oeTrab.Dni)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecolectaDatos()
        oeSancion.Fecha = fecFecha.Value
        oeSancion.IdTrabajador = cboTrabajador.Value
        oeSancion.IdArea = cboArea.Value
        oeSancion.IdConcepto = cboConceptoSancion.Value
        oeSancion.Glosa = txtGlosa.Text
        oeSancion.NroCuota = numCuotas.Value
        oeSancion.IdEstado = cboEstado.Value
        oeSancion.Monto = decImporte.Value
        oeSancion.IdGrupo = cboGrupo.Value
    End Sub

    Private Sub Aprobar()
        Try
            _acl = gAccionSistema.APROBAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoPendiente
                If griSancion.ActiveRow.Cells("Estado").Value = _estado Then
                    Editar()
                    _estado = gEstadosSGI.APROBADA.ToString
                    cboEstado.Text = _estado
                    _opeSanc = "APROBAR"
                Else
                    Throw New Exception("No puede APROBAR la Sanción Del Trabajador :" & Environment.NewLine & _
                                        griSancion.ActiveRow.Cells("Trabajador").Value & " por que su solicitud no esta PENDIENTE.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Anular()
        Try
            _acl = gAccionSistema.ANULAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If griSancion.Selected.Rows.Count > 0 Then
                    If MessageBox.Show("¿Desea Anular la Sanción de " & griSancion.ActiveRow.Cells("Trabajador").Value & "?", _
                                       "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim formulario As frm_AutenticarTrabajador
                        formulario = New frm_AutenticarTrabajador
                        formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                        If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                            Throw New Exception("Ingrese un Clave Correcta")
                        Else
                            _estado = gNombreEstadoAnulado.ToString
                            Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                            oeSancion = New e_Sancion
                            oeSancion.Id = griSancion.ActiveRow.Cells("Id").Value
                            If leSancion.Contains(oeSancion) Then
                                oeSancion = leSancion.Item(leSancion.IndexOf(oeSancion))
                                oeSancion.TipoOperacion = "A"
                                If _leEstAux.Count > 0 Then oeSancion.IdEstado = _leEstAux(0).Id
                                oeSancion.PrefijoID = gs_PrefijoIdSucursal '@0001
                                If olSancion.Guardar(oeSancion) Then
                                    mensajeEmergente.Confirmacion("La Sancion se ha Anulado Correctamente", True)
                                    Consultar()
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mcSancion_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcSancion.Opening
        mcSancion.Items("tsmiNuevo").Enabled = True
        mcSancion.Items("tsmiEditar").Enabled = IIf(griSancion.Selected.Rows.Count > 0, True, False)
        mcSancion.Items("tsmiElimina").Enabled = IIf(griSancion.Selected.Rows.Count > 0, True, False)
        mcSancion.Items("tsmiAprobar").Enabled = IIf(griSancion.Selected.Rows.Count > 0, True, False)
        mcSancion.Items("tsmiAnular").Enabled = IIf(griSancion.Selected.Rows.Count > 0, True, False)
        mcSancion.Items("tsmiExportar").Enabled = IIf(griSancion.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        Editar()
    End Sub

    Private Sub tsmiElimina_Click(sender As Object, e As EventArgs) Handles tsmiElimina.Click
        Eliminar()
    End Sub

    Private Sub tsmiAprobar_Click(sender As Object, e As EventArgs) Handles tsmiAprobar.Click
        Aprobar()
    End Sub

    Private Sub tsmiAnular_Click(sender As Object, e As EventArgs) Handles tsmiAnular.Click
        Anular()
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        Exportar()
    End Sub

#End Region

End Class