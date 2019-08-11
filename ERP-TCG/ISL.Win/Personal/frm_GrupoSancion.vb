Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_GrupoSancion
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_GrupoSancion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_GrupoSancion
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variable"

    Private oeGrupoSancion As New e_GrupoSancion, olGrupoSancion As New l_GrupoSancion
    Private oeArea As New e_Area, olArea As New l_Area, oeSancion As New e_Sancion
    Private leArea As New List(Of e_Area), leAreaBus As New List(Of e_Area)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado), leEstSancion As New List(Of e_Estado)
    Private olSancion As New l_Sancion, leDetalleGrupo As New List(Of e_Sancion), leSancion As New List(Of e_Sancion)
    Private _opeGS As String = "", _acl As String = "", _estado As String = ""

    Dim bandCargar As Boolean
    Dim bandRestaura As Boolean = False
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griGrupoSancion.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
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
                _opeGS = "GENERAR"
                MostrarTabs(1, ficGrupoSancion, 1)
                Operacion = "Nuevo"
                Inicializar()
                cboArea.ReadOnly = False
                oeGrupoSancion.TipoOperacion = "I"
                cboEstado.Text = "GENERADA"
                oeGrupoSancion.Glosa = txtGlosa.Text
                oeGrupoSancion.Fecha = fecFecha.Value
                oeGrupoSancion.IdEstado = cboEstado.Value
                oeGrupoSancion.Modificado = False
                scDetalle.Panel2Collapsed = True
                fecFecha.Enabled = True
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
                _opeGS = "GENERAR"
                Mostrar()
                cboArea.ReadOnly = True
                oeGrupoSancion.TipoOperacion = "A"
                oeGrupoSancion.Modificado = False
                scDetalle.Panel2Collapsed = False
                fecFecha.Enabled = False
                Operacion = "Editar"
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
                MostrarTabs(1, ficGrupoSancion, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeGrupoSancion.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficGrupoSancion, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficGrupoSancion, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficGrupoSancion, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficGrupoSancion, 2)
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
                With griGrupoSancion
                    If ValidarGrilla(griGrupoSancion, "Grupo Sancion") Then
                        oeGrupoSancion.Id = .ActiveRow.Cells("ID").Value
                        oeGrupoSancion = olGrupoSancion.Obtener(oeGrupoSancion)
                        If oeGrupoSancion.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Grupo Sancion: " & _
                                     .ActiveRow.Cells("Codigo").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeGrupoSancion.TipoOperacion = "E"
                                olGrupoSancion.Eliminar(oeGrupoSancion)
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

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            _acl = gAccionSistema.EXPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If ficGrupoSancion.Tabs(0).Selected AndAlso griGrupoSancion.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                If ficGrupoSancion.Tabs(0).Selected Then Exportar_Excel(griGrupoSancion)
                If ficGrupoSancion.Tabs(1).Selected AndAlso griGrupoDetalle.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                If ficGrupoSancion.Tabs(1).Selected Then Exportar_Excel(griGrupoDetalle)
                MyBase.Exportar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            Dim oe As New e_GrupoSancion
            oe.Id = griGrupoSancion.ActiveRow.Cells("Id").Value
            oe.TipoOperacion = ""
            oe.Activo = 1
            oe = olGrupoSancion.Obtener(oe)
            If oe.leDetalle.Count > 0 Then
                Dim ofrm As New frm_ReporteGrupoSancion
                ofrm.CargarDetalleInforme(oe)
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
            Else
                Throw New Exception("El grupo no tiene detalle")
            End If
            
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_GrupoSancion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                Nuevo()
            Case "Editar"
                Editar()
            Case "Inicializa"
                If griGrupoSancion.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_GrupoSancion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_GrupoSancion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            MostrarTabs(0, ficGrupoSancion)
            colorGenerada.Color = Color.LightYellow
            colorEnviado.Color = Color.LightGreen
            colorIntegrado.Color = Color.LightSteelBlue
            CargarCombos()
            bandCargar = True
            CargarGrupoSancion(New List(Of e_GrupoSancion))
            CargarSanciones(New List(Of e_Sancion), 1)
            CargarSanciones(New List(Of e_Sancion), 2)
            bandCargar = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub cboArea_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.Validated
        If cboArea.SelectedIndex > -1 Then
            If Operacion = "Nuevo" Then
                txtCodigo.Text = fn_ObtenerCodigo()
                oeGrupoSancion.Codigo = txtCodigo.Text.Trim
            End If
        End If
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeGrupoSancion.Glosa = txtGlosa.Text
    End Sub

    Private Sub cboArea_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.ValueChanged
        If cboArea.SelectedIndex > -1 Then oeGrupoSancion.IdArea = cboArea.Value
    End Sub

    Private Sub fecFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFecha.ValueChanged
        oeGrupoSancion.Fecha = fecFecha.Value
    End Sub

    Private Sub decMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decMonto.ValueChanged
        oeGrupoSancion.Monto = decMonto.Value
    End Sub

    Private Sub cboEstado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstado.ValueChanged
        If cboEstado.SelectedIndex > -1 Then oeGrupoSancion.IdEstado = cboEstado.Value
    End Sub

    Private Sub griGrupoSancion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griGrupoSancion.DoubleClick
        If griGrupoSancion.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griListaSancion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaSancion.DoubleClick
        Try
            If griListaSancion.Rows.Count > 0 Then
                Dim oe As New e_Sancion
                oe = griListaSancion.ActiveRow.ListObject
                AgregarSancion(oe)
                CargarSanciones(leSancion, 2)
                griGrupoDetalle.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griGrupoDetalle_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griGrupoDetalle.DoubleClick
        Try
            If griGrupoDetalle.Rows.Count > 0 Then
                Dim oe As New e_Sancion
                oe = griGrupoDetalle.ActiveRow.ListObject
                QuitarSancion(oe)
                CargarSanciones(leDetalleGrupo, 1)
                griListaSancion.DataBind()
            End If

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()

        Try
            oeArea = New e_Area
            oeArea.Id = ""
            oeArea.Nombre = "TODOS"
            leAreaBus.Add(oeArea)
            oeArea = New e_Area
            oeArea.Activo = 1
            leArea = olArea.Listar(oeArea)
            leAreaBus.AddRange(leArea)

            LlenarCombo(cboAreaBus, "Nombre", leAreaBus, 0)
            LlenarCombo(cboArea, "Nombre", leArea, -1)

            If gUsuarioSGI.Controlado > 0 Then
                cboAreaBus.Text = gUsuarioSGI.oeArea.Nombre
                cboAreaBus.ReadOnly = True
            Else
                cboAreaBus.SelectedIndex = 0
                cboAreaBus.ReadOnly = False
            End If

            oeEstado = New e_Estado
            oeEstado.Activo = 1
            oeEstado.Nombre = "GRUPO SANCION"
            leEstado = olEstado.Listar(oeEstado).OrderBy(Function(it) it.Nombre).ToList
            LlenarCombo(cboEstado, "Nombre", leEstado, -1)

            Dim _leEstaAux As New List(Of e_Estado)
            oeEstado = New e_Estado
            oeEstado.Id = ""
            oeEstado.Nombre = " [TODOS] "
            _leEstaAux.Add(oeEstado)
            _leEstaAux.AddRange(leEstado)
            LlenarCombo(cboEstadoBus, "Nombre", _leEstaAux, 2)

            oeEstado = New e_Estado
            oeEstado.Activo = 1
            oeEstado.Nombre = "SANCION"
            leEstSancion = olEstado.Listar(oeEstado)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Listar()
        Try
            oeGrupoSancion = New e_GrupoSancion
            oeGrupoSancion.Activo = True
            oeGrupoSancion.IdArea = cboAreaBus.Value
            oeGrupoSancion.IdEstado = cboEstadoBus.Value
            CargarGrupoSancion(olGrupoSancion.Listar(oeGrupoSancion).OrderByDescending(Function(it) it.Fecha).ToList)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griGrupoSancion.Focus()
    End Sub

    Public Sub CargarGrupoSancion(ByVal leGrupoSancion As List(Of e_GrupoSancion))
        Try
            With griGrupoSancion

                .DataSource = leGrupoSancion

                If bandCargar Then

                    OcultarColumna(griGrupoSancion, True, "Id", "IdArea", "IdEstado", "Activo", "FechaCreacion", "UsuarioCreacion", "Tipo")

                    .DisplayLayout.Bands(0).Columns("Area").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 5

                    FormatoColumna(griGrupoSancion, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")

                    .DisplayLayout.Bands(0).Columns("Area").Width = 200
                    .DisplayLayout.Bands(0).Columns("Codigo").Width = 80
                    .DisplayLayout.Bands(0).Columns("Fecha").Width = 120
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 200
                    .DisplayLayout.Bands(0).Columns("Estado").Width = 100

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
                    For Each Fila As UltraGridRow In .Rows
                        Select Case Fila.Cells("Estado").Value
                            Case "GENERADA" : Fila.Appearance.BackColor = colorGenerada.Color
                            Case "ENVIADO" : Fila.Appearance.BackColor = colorEnviado.Color
                            Case "INTEGRADA" : Fila.Appearance.BackColor = colorIntegrado.Color
                        End Select
                    Next
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        oeGrupoSancion = New e_GrupoSancion
        txtCodigo.Text = String.Empty
        txtCodigo.ReadOnly = True
        cboArea.SelectedIndex = -1
        fecFecha.Value = Date.Now.Date
        txtGlosa.Text = "RENDICION DE SANCIONES"
        decMonto.Value = 0
        If gUsuarioSGI.Controlado > 0 Then
            cboArea.Text = gUsuarioSGI.oeArea.Nombre
            oeGrupoSancion.IdArea = cboArea.Value
            If Operacion = "Nuevo" Then
                txtCodigo.Text = fn_ObtenerCodigo()
                oeGrupoSancion.Codigo = txtCodigo.Text.Trim
            End If
            cboArea.ReadOnly = True
        Else
            cboArea.SelectedIndex = -1
            cboArea.ReadOnly = False
        End If
        leDetalleGrupo = New List(Of e_Sancion)
        CargarSanciones(leDetalleGrupo, 1)
        leSancion = New List(Of e_Sancion)
        CargarSanciones(leDetalleGrupo, 2)
    End Sub

    Private Sub Mostrar()
        Try
            If griGrupoSancion.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeGrupoSancion.Id = griGrupoSancion.ActiveRow.Cells("Id").Value.ToString
                oeGrupoSancion = olGrupoSancion.Obtener(oeGrupoSancion)
                If oeGrupoSancion.Estado = "GENERADA" Then
                    With oeGrupoSancion
                        cboArea.Value = .IdArea
                        txtCodigo.Text = .Codigo
                        fecFecha.Value = .Fecha
                        txtGlosa.Text = .Glosa
                        decMonto.Value = .Monto
                        cboEstado.Value = .IdEstado
                        leDetalleGrupo = .leDetalle
                        CargarSanciones(leDetalleGrupo, 1)
                        CargarSancAprob(.Id)
                        MostrarTabs(1, ficGrupoSancion, 1)
                        MyBase.Editar()
                    End With
                Else
                    Throw New Exception("No puede Editar el Grupo Nº: " & oeGrupoSancion.Codigo & ", porque esta " & oeGrupoSancion.Estado)
                End If
                
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            Select Case _opeGS
                Case "GENERAR"
                    If olGrupoSancion.Guardar(oeGrupoSancion) Then
                        mensajeEmergente.Confirmacion("El Grupo Sancion de ha guardado correctamente en " & Me.Text, True)
                        MostrarTabs(0, ficGrupoSancion, 2)
                        Consultar(_Activo)
                        griGrupoSancion.Focus()
                        Return True
                    End If
                Case "ENVIAR"
                    If leSancion.Count > 0 Then
                        Throw New Exception("!No se puede Enviar por que hay " & leSancion.Count & " Sanciones que no se han confirmado!" & Environment.NewLine & _
                                            "Se recomienda Pasar a Otro Grupo GENERADO o ANULAR las Sanciones")
                    End If
                    If olGrupoSancion.Guardar(oeGrupoSancion) Then
                        mensajeEmergente.Confirmacion("El Grupo Sancion de ha ENVIADO correctamente en" & Me.Text, True)
                        MostrarTabs(0, ficGrupoSancion, 2)
                        Consultar(_Activo)
                        griGrupoSancion.Focus()
                        Return True
                    End If
                Case "EXTORNAR"
                    If Not bandRestaura Then
                        oeGrupoSancion.UsuarioCreacion = gUsuarioSGI.Id
                        oeGrupoSancion.leDetalle = leDetalleGrupo
                        oeGrupoSancion.Estado = cboEstado.Text
                    End If
                    If olGrupoSancion.Guardar(oeGrupoSancion) Then
                        mensajeEmergente.Confirmacion("El Grupo Sancion de ha EXTORNADO correctamente en " & Me.Text, True)
                        MostrarTabs(0, ficGrupoSancion, 2)
                        Consultar(_Activo)
                        griGrupoSancion.Focus()

                        Return True
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim oe As New e_GrupoSancion
            Dim oeAre As New e_Area
            oe.TipoOperacion = "C"
            oeAre = cboArea.Items(cboArea.SelectedIndex).ListObject
            oe.Codigo = oeAre.Codigo
            oe = olGrupoSancion.Obtener(oe)
            Return oe.Codigo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarSanciones(ByVal lista As List(Of e_Sancion), ByVal tip As Integer)
        Dim leActivo As New List(Of e_Sancion)
        If tip = 1 Then
            leActivo = lista.Where(Function(item) item.TipoOperacion <> "E").ToList
            griGrupoDetalle.DataSource = leActivo
            decMonto.Value = leActivo.Sum(Function(item) item.Monto)
            If bandCargar Then CargarDisenio(griGrupoDetalle)
        Else
            leActivo = lista.Where(Function(item) item.TipoOperacion <> "A").ToList
            griListaSancion.DataSource = leActivo
            If bandCargar Then CargarDisenio(griListaSancion)
        End If
    End Sub

    Private Sub CargarDisenio(ByVal grilla As UltraGrid)

        With grilla
            For Each col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                If col.Key.Contains("Id") Then col.Hidden = True
            Next

            OcultarColumna(grilla, True, "Activo", "FechaCreacion", "UsuarioCreacion", "FechaAprobacion", "Area")

            .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 0
            .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 1
            .DisplayLayout.Bands(0).Columns("Concepto").Header.VisiblePosition = 2
            .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 3
            .DisplayLayout.Bands(0).Columns("NroCuota").Header.VisiblePosition = 4
            .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 5
            .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 6
            .DisplayLayout.Bands(0).Columns("Responsable").Header.VisiblePosition = 7

            .DisplayLayout.Bands(0).Columns("Fecha").Width = 70
            .DisplayLayout.Bands(0).Columns("NroCuota").Width = 60
            .DisplayLayout.Bands(0).Columns("Trabajador").Width = 200
            .DisplayLayout.Bands(0).Columns("Concepto").Width = 150
            .DisplayLayout.Bands(0).Columns("Glosa").Width = 250
            .DisplayLayout.Bands(0).Columns("Monto").Width = 70
            .DisplayLayout.Bands(0).Columns("Responsable").Width = 200

            FormatoColumna(grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")

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


        CalcularTotales(grilla, "Monto")

    End Sub

    Private Sub AgregarSancion(ByVal _oeSancion As e_Sancion)
        Try
            Dim id As String = _oeSancion.Id
            If Not leDetalleGrupo.Contains(_oeSancion) Then
                If griGrupoDetalle.Rows.Count = 0 Then CargarSanciones(New List(Of e_Sancion), 1)
                _oeSancion.TipoOperacion = "A"
                _oeSancion.IdEstado = oeGrupoSancion.IdEstado
                leDetalleGrupo.Add(_oeSancion)
                CargarSanciones(leDetalleGrupo, 1)
            Else
                Dim oeAgre As New e_Sancion
                oeAgre.Id = _oeSancion.Id
                oeAgre = leDetalleGrupo.Item(leDetalleGrupo.IndexOf(oeAgre))
                oeAgre.IdEstado = oeGrupoSancion.IdEstado
                oeAgre.TipoOperacion = "A"
                CargarSanciones(leDetalleGrupo, 1)
            End If

            Dim oeEli As New e_Sancion
            oeEli.Id = id
            oeEli = leSancion.Item(leSancion.IndexOf(oeEli))
            oeEli.TipoOperacion = "A"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarSancion(ByVal _oeSancion As e_Sancion)
        Try
            Dim id As String = _oeSancion.Id
            If Not leSancion.Contains(_oeSancion) Then
                If griListaSancion.Rows.Count = 0 Then CargarSanciones(New List(Of e_Sancion), 2)
                _oeSancion.TipoOperacion = ""
                _oeSancion.Activo = 1
                leSancion.Add(_oeSancion)
                CargarSanciones(leSancion, 2)
            Else
                Dim oeAgre As New e_Sancion
                oeAgre.Id = _oeSancion.Id
                oeAgre = leSancion.Item(leSancion.IndexOf(oeAgre))
                oeAgre.TipoOperacion = ""
                oeAgre.Activo = 1
                CargarSanciones(leSancion, 2)
            End If

            Dim oeEli As New e_Sancion
            oeEli.Id = id
            oeEli = leDetalleGrupo.Item(leDetalleGrupo.IndexOf(oeEli))
            oeEli.TipoOperacion = "E"
            oeEli.IdEstado = ""
            'oeEli.Activo = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Enviar()
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoGenerada
                If griGrupoSancion.ActiveRow.Cells("Estado").Value = _estado AndAlso griGrupoSancion.ActiveRow.Cells("Monto").Value > 0 Then
                    Editar()
                    _estado = gNombreEstadoEnviado
                    cboEstado.Text = _estado
                    oeGrupoSancion.Estado = _estado
                    _opeGS = "ENVIAR"
                Else
                    Throw New Exception("No puede en ENVIAR el Registro de Grupo Sancion " & Environment.NewLine & _
                                        "Nº: " & griGrupoSancion.ActiveRow.Cells("Codigo").Value & " por que no esta en GENERADA." & _
                                        Environment.NewLine & "O no tiene ni un solo registro de detalle.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Extornar()
        Try
            _acl = gAccionSistema.EXTORNAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoEnviado
                If griGrupoSancion.ActiveRow.Cells("Estado").Value = _estado Then
                    If MessageBox.Show("¿Estas Seguro que desea cambiar de estado a generado?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                        Dim formulario As frm_AutenticarTrabajador
                        formulario = New frm_AutenticarTrabajador
                        formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                        If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                            ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                            Throw New Exception("Ingrese un Clave Correcta")
                        Else
                            oeGrupoSancion = New e_GrupoSancion
                            oeGrupoSancion.Id = griGrupoSancion.ActiveRow.Cells("Id").Value
                            oeGrupoSancion = olGrupoSancion.Obtener(oeGrupoSancion)
                            oeGrupoSancion.TipoOperacion = "A"
                            Dim leEst As New List(Of e_Estado)
                            leEst = leEstado.Where(Function(item) item.Nombre = "GENERADA").ToList
                            oeGrupoSancion.IdEstado = leEst(0).Id
                            oeGrupoSancion.Estado = "RESTAURA"
                            _opeGS = "EXTORNAR"
                            bandRestaura = True
                            Guardando()
                            bandRestaura = False
                        End If
                    End If
                Else
                    Throw New Exception("No se puede EXTORNAR el Registro de Grupo Sanción " & Environment.NewLine & _
                                        "Nº: " & griGrupoSancion.ActiveRow.Cells("Codigo").Value & " por que no esta ENVIADO")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarSancAprob(IdGrupo As String)
        Try
            _estado = gEstadosSGI.APROBADA.ToString
            Dim _leEst = leEstSancion.Where(Function(it) it.Nombre = _estado).ToList
            Dim oeSancion As New e_Sancion
            oeSancion.TipoOperacion = "1"
            oeSancion.Activo = 1
            oeSancion.IdGrupo = IdGrupo
            oeSancion.IdEstado = IIf(_leEst.Count > 0, _leEst(0).Id, "SIN")
            leSancion = olSancion.Listar(oeSancion).OrderByDescending(Function(it) it.Fecha).ToList
            CargarSanciones(leSancion, 2)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mnuGrupoDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuGrupoDetalle.Opening
        mnuGrupoDetalle.Items("tsmiQuitar").Visible = IIf(griGrupoDetalle.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitar.Click
        Try
            Dim oeDetalle As New e_Sancion
            For Each Fila As UltraGridRow In griGrupoDetalle.Rows
                oeDetalle = New e_Sancion
                oeDetalle = Fila.ListObject
                QuitarSancion(oeDetalle)
            Next
            CargarSanciones(leDetalleGrupo, 1)
            griListaSancion.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


    Private Sub mnuSancion_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuSancion.Opening
        mnuSancion.Items("tsmiAgregar").Enabled = IIf(griListaSancion.Rows.Count > 0, True, False)
        mnuSancion.Items("tsmiAnular").Enabled = IIf(griListaSancion.Selected.Rows.Count > 0, True, False)
        mnuSancion.Items("tsmiAnularAll").Enabled = IIf(griListaSancion.Rows.Count > 0, True, False)
        mnuSancion.Items("tsmiPasar").Enabled = IIf(griListaSancion.Selected.Rows.Count > 0, True, False)
        mnuSancion.Items("tsmiPasarAll").Enabled = IIf(griListaSancion.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregar.Click
        Try
            Dim oeSanc As New e_Sancion
            Dim grilla As UltraGrid = griListaSancion
            For Each Fila As UltraGridRow In grilla.Rows
                oeSanc = New e_Sancion
                oeSanc = Fila.ListObject
                AgregarSancion(oeSanc)
            Next
            CargarSanciones(leSancion, 2)
            griGrupoDetalle.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub tsmiAnular_Click(sender As Object, e As EventArgs) Handles tsmiAnular.Click
        Try
            If griListaSancion.Selected.Rows.Count > 0 Then
                If MessageBox.Show("¿Desea Anular la Sanción de " & griListaSancion.ActiveRow.Cells("Trabajador").Value & "?", _
                                   "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        _estado = gNombreEstadoAnulado.ToString
                        Dim _leEstAux = leEstSancion.Where(Function(it) it.Nombre = _estado).ToList
                        oeSancion = New e_Sancion
                        oeSancion.Id = griListaSancion.ActiveRow.Cells("Id").Value
                        If leSancion.Contains(oeSancion) Then
                            oeSancion = leSancion.Item(leSancion.IndexOf(oeSancion))
                            oeSancion.TipoOperacion = "A"
                            If _leEstAux.Count > 0 Then oeSancion.IdEstado = _leEstAux(0).Id
                            If olSancion.Guardar(oeSancion) Then
                                mensajeEmergente.Confirmacion("La Sancion se ha Anulado Correctamente", True)
                                CargarSancAprob(oeGrupoSancion.Id)
                                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiAnularAll_Click(sender As Object, e As EventArgs) Handles tsmiAnularAll.Click
        Try
            If leSancion.Count > 0 Then
                If MessageBox.Show("¿Desea Anular todas las Sanciones?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        _estado = gNombreEstadoAnulado.ToString
                        Dim _leEstAux = leEstSancion.Where(Function(it) it.Nombre = _estado).ToList
                        For Each oeSanc In leSancion
                            oeSanc.TipoOperacion = "A"
                            If _leEstAux.Count > 0 Then oeSanc.IdEstado = _leEstAux(0).Id
                        Next
                        If olSancion.GuardarLista(leSancion) Then
                            mensajeEmergente.Confirmacion("Las Sanciones se han Anulado correctamente", True)
                            CargarSancAprob(oeGrupoSancion.Id)
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiPasar_Click(sender As Object, e As EventArgs) Handles tsmiPasar.Click
        Try
            If griListaSancion.Selected.Rows.Count > 0 Then
                If MessageBox.Show("¿Desea Pasar a Otro Grupo la Sanción de " & griListaSancion.ActiveRow.Cells("Trabajador").Value & "?", _
                                  "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        ls_IdGSancion = ""
                        Dim _frm As New frm_Seleccionar("GSancion", gNombreEstadoGenerada, cboArea.Value)
                        _frm.StartPosition = FormStartPosition.CenterScreen
                        _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                        If _frm.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                            If ls_IdGSancion.Trim <> "" Then
                                If ls_IdGSancion = oeGrupoSancion.Id Then Throw New Exception("No puede Elegir el mismo Grupo")
                                oeSancion = New e_Sancion
                                oeSancion.Id = griListaSancion.ActiveRow.Cells("Id").Value
                                If leSancion.Contains(oeSancion) Then
                                    oeSancion = leSancion.Item(leSancion.IndexOf(oeSancion))
                                    oeSancion.TipoOperacion = "A"
                                    oeSancion.IdGrupo = ls_IdGSancion
                                    If olSancion.Guardar(oeSancion) Then
                                        mensajeEmergente.Confirmacion("La Sancion se ha Pasado al Grupo Correctamente", True)
                                        CargarSancAprob(oeGrupoSancion.Id)
                                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                                    End If
                                End If
                            Else
                                Throw New Exception("No ha Seleccionado ningun grupo")
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiPasarAll_Click(sender As Object, e As EventArgs) Handles tsmiPasarAll.Click

    End Sub


    Private Sub mnuGrupoSancion_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuGrupoSancion.Opening
        mnuGrupoSancion.Items("tsmiNuevo").Enabled = True
        mnuGrupoSancion.Items("tsmiEditar").Enabled = IIf(griGrupoSancion.Selected.Rows.Count > 0, True, False)
        mnuGrupoSancion.Items("tsmiEliminar").Enabled = IIf(griGrupoSancion.Selected.Rows.Count > 0, True, False)
        mnuGrupoSancion.Items("tsmiEnviar").Enabled = IIf(griGrupoSancion.Selected.Rows.Count > 0, True, False)
        mnuGrupoSancion.Items("tsmiGenerar").Enabled = IIf(griGrupoSancion.Selected.Rows.Count > 0, True, False)
        mnuGrupoSancion.Items("tsmiExportar").Enabled = IIf(griGrupoSancion.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub tsmiEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEnviar.Click
        Try
            If griGrupoSancion.Selected.Rows.Count > 0 Then Enviar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGenerar.Click
        Extornar()
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        Exportar()
    End Sub

#End Region

End Class