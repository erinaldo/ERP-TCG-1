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

Public Class frm_Organigrama
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_Organigrama = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Organigrama()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim olOcupacion As New l_Ocupacion
    Private WithEvents oeOcupacion As New e_Ocupacion
    Private oeArea As New e_AreaAO, olArea As New l_AreaAO, leArea As New List(Of e_AreaAO)
    Private oeGerencia As New e_Gerencia, olGerencia As New l_Gerencia, leGerencia As New List(Of e_Gerencia)
    Private oeUnidad As New e_Area, olUnidad As New l_Area, leUnidad As New List(Of e_Area)
    Dim _ingresando_datos As Boolean = False
    Private dtOcupaciones As Data.DataTable
    Private _ope As String = "", _acl As String = "", _estado As String = ""

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            If ficOrganigrama.Tabs(0).Active Then
                Listar(Activo)
                Tiempo1.Enabled = True
                Operacion = "Inicializa"
                ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
            Else
                If ficDistrib.Tabs(0).Active Then Listar_Gerencias()
                If ficDistrib.Tabs(1).Active Then Listar_Areas()
                If ficDistrib.Tabs(2).Active Then Listar_Unidades()
                If ficDistrib.Tabs(3).Active Then Listar_Ocupaciones()
                ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Guardando()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If ueg_Datos.Enabled = False Then
                MostrarTabs(0, ficOrganigrama, 0)
                MostrarTabs(0, ficDistrib, 0)
                Consultar(True)
            Else
                ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
                ueg_Datos.Enabled = False
                ueg_Datos.Expanded = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
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
            'If ValidarAcl(_acl, pIdActividadNegocio) Then
            If griOrganigrama.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            ExportarGrillaAExcel(griOrganigrama, "Estructura_Organizacional")
            MyBase.Exportar()
            '
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Ocupacion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Ocupacion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Ocupacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Tiempo1.Enabled = False
            MostrarTabs(0, ficOrganigrama)
            InicializaTiempo()
            CargarOcupacion(New List(Of e_Ocupacion))
            ueg_Datos.Expanded = False
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            dtOcupaciones = GenerarDTConfigurable(CargarCTCD("T30_Ocupacion_Sprivado"))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeOcupacion.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeOcupacion.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub oeOcupacion_DatoCambiado() Handles oeOcupacion.DatoCambiado
        oeOcupacion.Modificado = True
    End Sub

    Private Sub griOrganigrama_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griOrganigrama.DoubleClick
        If griOrganigrama.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griOcupacion_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griOrganigrama.InitializeLayout
        griOrganigrama.Text = "Información de Organigrama: " & griOrganigrama.Rows.Count
    End Sub

    'Private Sub cboOcupacionSunat_ValueChanged(sender As Object, e As EventArgs) Handles cboOcupacionSunat.ValueChanged
    '    If cboOcupacionSunat.SelectedIndex > -1 Then oeOcupacion.OcupacionSunat = cboOcupacionSunat.Value
    'End Sub

    Private Sub cboOcuSunat_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboOcuSunat.InitializeLayout
        Try
            Me.cboOcuSunat.ValueMember = "CODIGO"
            Me.cboOcuSunat.DisplayMember = "NOMBRE"
            With cboOcuSunat.DisplayLayout.Bands(0)
                .Columns("CODIGO").Hidden = True
                .Columns("EJECUTIVO").Hidden = True
                .Columns("EMPLEADO").Hidden = True
                .Columns("OBRERO").Hidden = True
                .Columns("NOMBRE").Width = cboOcuSunat.Size.Width
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboOcuSunat_KeyDown(sender As Object, e As KeyEventArgs) Handles cboOcuSunat.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Not IsNumeric(cboOcuSunat.Value) Then
                    LlenaComboConfigurable(cboOcuSunat, FiltraDTable(dtOcupaciones, "NOMBRE LIKE '%" & cboOcuSunat.Value & "%' ", "NOMBRE"), "CODIGO", "NOMBRE")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboOcuSunat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboOcuSunat.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then cboOcuSunat.PerformAction(UltraComboAction.Dropdown)
    End Sub

    Private Sub cboOcuSunat_ValueChanged(sender As Object, e As EventArgs) Handles cboOcuSunat.ValueChanged
        Try
            If cboOcuSunat.Value IsNot Nothing AndAlso cboOcuSunat.Value.ToString.Trim <> "" Then
                Dim dsAuxVal As Data.DataTable
                If IsNumeric(cboOcuSunat.Value) Then
                    dsAuxVal = FiltraDTable(dtOcupaciones, "CODIGO = " & cboOcuSunat.Value, "")
                    If dsAuxVal.Rows.Count > 0 Then
                        oeOcupacion.OcupacionSunat = cboOcuSunat.Value
                    Else
                        oeOcupacion.OcupacionSunat = String.Empty
                    End If
                Else
                    oeOcupacion.OcupacionSunat = String.Empty
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarOcupacion(leOcupa As List(Of e_Ocupacion))
        Try
            With griOrganigrama

                .DataSource = leOcupa
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdArea").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdUnidad").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdGerencia").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("OcupacionSunat").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 300
                .DisplayLayout.Bands(0).Columns("Area").Width = 300
                .DisplayLayout.Bands(0).Columns("Unidad").Width = 300
                .DisplayLayout.Bands(0).Columns("Gerencia").Width = 300
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                '.DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                'Ubica el cursor el el primer registro de la grilla
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
            oeOcupacion = New e_Ocupacion
            oeOcupacion.Activo = Activo
            CargarOcupacion(olOcupacion.Listar2(oeOcupacion))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griOrganigrama.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        cboOcuSunat.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        ueg_Datos.Expanded = False
        LlenaComboConfigurable(cboOcuSunat, dtOcupaciones, "CODIGO", "NOMBRE")
    End Sub

    Private Sub Mostrar()
        Try
            If ficDistrib.Tabs(0).Active Then
                Inicializar()
                oeGerencia = New e_Gerencia
                oeGerencia.Id = ug_Gerencia.ActiveRow.Cells("Id").Value.ToString.Trim
                txtCodigo.Text = ug_Gerencia.ActiveRow.Cells("Codigo").Value.ToString.Trim
                txtNombre.Text = ug_Gerencia.ActiveRow.Cells("Nombre").Value.ToString.Trim
                txtAbreviatura.Text = ug_Gerencia.ActiveRow.Cells("Abreviatura").Value.ToString.Trim
            End If
            If ficDistrib.Tabs(1).Active Then
                Inicializar()
                oeArea = New e_AreaAO
                oeArea.Id = ug_Area.ActiveRow.Cells("Id").Value.ToString.Trim
                txtCodigo.Text = ug_Area.ActiveRow.Cells("Codigo").Value.ToString.Trim
                txtNombre.Text = ug_Area.ActiveRow.Cells("Nombre").Value.ToString.Trim
                cboForanea.Value = ug_Area.ActiveRow.Cells("IdGerencia").Value.ToString.Trim
                txtAbreviatura.Text = ug_Area.ActiveRow.Cells("Abreviatura").Value.ToString.Trim
            End If
            If ficDistrib.Tabs(2).Active Then
                Inicializar()
                oeUnidad = New e_Area
                oeUnidad.Id = ug_Unidad.ActiveRow.Cells("Id").Value.ToString.Trim
                txtCodigo.Text = ug_Unidad.ActiveRow.Cells("Codigo").Value.ToString.Trim
                txtNombre.Text = ug_Unidad.ActiveRow.Cells("Nombre").Value.ToString.Trim
                cboForanea.Value = ug_Unidad.ActiveRow.Cells("IdAreaOG").Value.ToString.Trim
                txtAbreviatura.Text = ug_Unidad.ActiveRow.Cells("Abreviatura").Value.ToString.Trim
            End If
            If ficDistrib.Tabs(3).Active Then
                Inicializar()
                oeOcupacion = New e_Ocupacion
                oeOcupacion.Id = ug_Ocupacion.ActiveRow.Cells("Id").Value.ToString.Trim
                txtCodigo.Text = ug_Ocupacion.ActiveRow.Cells("Codigo").Value.ToString.Trim
                txtNombre.Text = ug_Ocupacion.ActiveRow.Cells("Nombre").Value.ToString.Trim
                cboForanea.Value = ug_Ocupacion.ActiveRow.Cells("IdArea").Value.ToString.Trim
                cboOcuSunat.Value = ug_Ocupacion.ActiveRow.Cells("OcupacionSunat").Value.ToString.Trim
            End If
            ueg_Datos.Expanded = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Guardando()
        Try
            Dim _ban As Boolean = False
            If ficDistrib.Tabs(0).Active Then
                With oeGerencia
                    .TipoOperacion = IIf(Operacion = "Nuevo", "I", IIf(Operacion = "Editar", "A", "E"))
                    .Codigo = txtCodigo.Text
                    .Nombre = txtNombre.Text
                    .Activo = True
                    .Abreviatura = txtAbreviatura.Text
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                    If .TipoOperacion <> "E" Then
                        _ban = olGerencia.Guardar(oeGerencia)
                    Else
                        _ban = olGerencia.Eliminar(oeGerencia)
                    End If
                End With
            End If
            If ficDistrib.Tabs(1).Active Then
                With oeArea
                    .TipoOperacion = IIf(Operacion = "Nuevo", "I", IIf(Operacion = "Editar", "A", "E"))
                    .Codigo = txtCodigo.Text
                    .Nombre = txtNombre.Text
                    .Activo = True
                    .Abreviatura = txtAbreviatura.Text
                    .IdGerencia = cboForanea.Value
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                    If .TipoOperacion <> "E" Then
                        _ban = olArea.Guardar(oeArea)
                    Else
                        _ban = olArea.Eliminar(oeArea)
                    End If
                End With
            End If
            If ficDistrib.Tabs(2).Active Then
                With oeUnidad
                    .TipoOperacion = IIf(Operacion = "Nuevo", "I", IIf(Operacion = "Editar", "A", "E"))
                    .Codigo = txtCodigo.Text
                    .Nombre = txtNombre.Text
                    .Activo = True
                    .Abreviatura = txtAbreviatura.Text
                    .IdGerencia = cboForanea.Value
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                    If .TipoOperacion <> "E" Then
                        _ban = olUnidad.Guardar(oeUnidad)
                    Else
                        _ban = olUnidad.Eliminar(oeUnidad)
                    End If
                End With
            End If
            If ficDistrib.Tabs(3).Active Then
                With oeOcupacion
                    .TipoOperacion = IIf(Operacion = "Nuevo", "I", IIf(Operacion = "Editar", "A", "E"))
                    .Codigo = txtCodigo.Text
                    .Nombre = txtNombre.Text
                    .Activo = True
                    .OcupacionSunat = cboOcuSunat.Value
                    .IdUnidad = cboForanea.Value
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                    If .TipoOperacion <> "E" Then
                        _ban = olOcupacion.Guardar(oeOcupacion)
                    Else
                        _ban = olOcupacion.Eliminar(oeOcupacion)
                    End If
                End With
            End If
            If _ban Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                If Operacion = "Nuevo" Or Operacion = "Editar" Then Cancelar()
                Consultar(True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("Nombre") Then
            txtNombre.Focus()
        End If
    End Sub

    Private Sub TecladoTextos(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case (Keys.Escape)
                Cancelar()

            Case (Keys.Enter)
                SendKeys.Send("{TAB}")
        End Select

    End Sub

    'Private Sub TecladoGrilla(ByVal e As System.Windows.Forms.KeyEventArgs)
    '    Select Case e.KeyCode
    '        Case Keys.Insert
    '            Nuevo()
    '        Case Keys.Add
    '            Nuevo()

    '        Case Keys.Multiply
    '            Editar()

    '        Case Keys.Delete
    '            Eliminar()

    '        Case Keys.Subtract
    '            Eliminar()

    '        Case Keys.Escape
    '            Cancelar()
    '    End Select
    'End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Cargo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    'Private Sub griOcupacion_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griOrganigrama.MouseMove
    '    If _tiempo <= 0 Then
    '        Listar(_Activo)
    '    End If
    '    InicializaTiempo()
    'End Sub

#End Region

#Region "Menú contextual del maestro de Ocupación"

    Private Sub MenuContextual2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuContextual2.Opening
        MenuContextual2.Items("tsmiAreaNuevo").Visible = IIf(ug_Gerencia.Selected.Rows.Count > 0 And ueg_Datos.Enabled = False And ficDistrib.Tabs(0).Active, True, False)
        MenuContextual2.Items("tsmiUnidadNuevo").Visible = IIf(ug_Area.Selected.Rows.Count > 0 And ueg_Datos.Enabled = False And ficDistrib.Tabs(1).Active, True, False)
        MenuContextual2.Items("tsmiOcupacionNuevo").Visible = IIf(ug_Unidad.Selected.Rows.Count > 0 And ueg_Datos.Enabled = False And ficDistrib.Tabs(2).Active, True, False)
        MenuContextual2.Items("tsmiNuevo").Visible = IIf(ueg_Datos.Enabled = True, False, True)
        MenuContextual2.Items("tsmiEditar").Visible = IIf(ueg_Datos.Enabled = True, False, True)
        MenuContextual2.Items("tsmiEliminar").Visible = IIf(ueg_Datos.Enabled = True, False, True)
    End Sub

    Private Sub Listar_Gerencias()
        oeGerencia = New e_Gerencia
        oeGerencia.Activo = 1
        oeGerencia.TipoOperacion = ""
        ug_Gerencia.DataSource = olGerencia.Listar(oeGerencia)
    End Sub

    Private Sub Listar_Areas()
        oeArea = New e_AreaAO
        oeArea.Activo = 1
        oeArea.TipoOperacion = ""
        ug_Area.DataSource = olArea.Listar(oeArea)
    End Sub

    Private Sub Listar_Unidades()
        oeUnidad = New e_Area
        oeUnidad.Activo = 1
        oeUnidad.TipoOperacion = ""
        ug_Unidad.DataSource = olUnidad.Listar(oeUnidad)
    End Sub

    Private Sub Listar_Ocupaciones()
        oeOcupacion = New e_Ocupacion
        oeOcupacion.Activo = 1
        oeOcupacion.TipoOperacion = ""
        ug_Ocupacion.DataSource = olOcupacion.Listar2(oeOcupacion)
    End Sub

    Private Sub tsmiGerencia_Click(sender As Object, e As EventArgs) Handles tsmiGerencia.Click
        Try
            MostrarTabs(1, ficOrganigrama, 1)
            MostrarTabs(0, ficDistrib, 0)
            ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
            Listar_Gerencias()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub tsmiArea_Click(sender As Object, e As EventArgs) Handles tsmiArea.Click
        Try
            MostrarTabs(1, ficOrganigrama, 1)
            MostrarTabs(1, ficDistrib, 1)
            ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
            Listar_Areas()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub tsmiUnidad_Click(sender As Object, e As EventArgs) Handles tsmiUnidad.Click
        Try
            MostrarTabs(1, ficOrganigrama, 1)
            MostrarTabs(2, ficDistrib, 2)
            ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
            Listar_Unidades()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        Exportar()
    End Sub

#End Region

    Private Sub tsmiOcupacion_Click(sender As Object, e As EventArgs) Handles tsmiOcupacion.Click
        Try
            MostrarTabs(1, ficOrganigrama, 1)
            MostrarTabs(3, ficDistrib, 3)
            ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
            Listar_Ocupaciones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Controles_Datos(etiqueta As String, _ban As Boolean)
        lblForanea.Text = etiqueta
        lblForanea.Visible = _ban
        lblOcupSunat.Visible = _ban
        cboForanea.Visible = _ban
        cboOcuSunat.Visible = _ban
        If etiqueta <> "Unidad:" Then
            lblOcupSunat.Visible = False
            cboOcuSunat.Visible = False
        End If
    End Sub

    Private Sub Nueva_Distrib()
        Inicializar()
        cboForanea.Enabled = True
        If ficOrganigrama.Tabs(1).Active Then
            ueg_Datos.Expanded = True
            ueg_Datos.Enabled = True
            If ficDistrib.Tabs(0).Active Then Controles_Datos("", False)
            If Not ficDistrib.Tabs(0).Active Then
                cboForanea.ValueMember = "Id"
                cboForanea.DisplayMember = "Nombre"
            End If
           

            If ficDistrib.Tabs(1).Active Then
                Controles_Datos("Gerencia:", True)
                oeGerencia = New e_Gerencia
                oeGerencia.Activo = 1
                oeGerencia.TipoOperacion = ""
                cboForanea.DataSource = olGerencia.Listar(oeGerencia)
            End If

            If ficDistrib.Tabs(2).Active Then
                Controles_Datos("Área:", True)
                oeArea = New e_AreaAO
                oeArea.Activo = 1
                oeArea.TipoOperacion = ""
                cboForanea.DataSource = olArea.Listar(oeArea)
                cboForanea.DisplayLayout.Bands(0).Columns("IdGerencia").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("Gerencia").Hidden = True
            End If
            Etiqueta8.Visible = True
            txtAbreviatura.Visible = True
            If ficDistrib.Tabs(3).Active Then
                Controles_Datos("Unidad:", True)
                oeUnidad = New e_Area
                oeUnidad.Activo = 1
                oeUnidad.TipoOperacion = ""
                cboForanea.DataSource = olUnidad.Listar(oeUnidad)
                cboForanea.DisplayLayout.Bands(0).Columns("IndSector").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("IdSector").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("Sector").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("IdGerencia").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("Gerencia").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("IsGerencia").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("IdAreaOG").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("AreaOG").Hidden = True
                Etiqueta8.Visible = False
                txtAbreviatura.Visible = False
            End If
            If Not ficDistrib.Tabs(0).Active Then
                cboForanea.DisplayLayout.Bands(0).Columns("Id").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("Abreviatura").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                cboForanea.DisplayLayout.Bands(0).Columns("Nombre").Width = 312
                cboForanea.Text = ""
            End If
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
            txtCodigo.Focus()
        End If
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Try
            Nueva_Distrib()
            Operacion = "Nuevo"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        Try
            Dim grilla As UltraGrid = Nothing
            If ficDistrib.Tabs(0).Active Then grilla = ug_Gerencia
            If ficDistrib.Tabs(1).Active Then grilla = ug_Area
            If ficDistrib.Tabs(2).Active Then grilla = ug_Unidad
            If ficDistrib.Tabs(3).Active Then grilla = ug_Ocupacion
            If Sel_Grilla(grilla) Then
                Nueva_Distrib()
                Operacion = "Editar"
                Mostrar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Try
            Dim grilla As UltraGrid = Nothing
            If ficDistrib.Tabs(0).Active Then grilla = ug_Gerencia
            If ficDistrib.Tabs(1).Active Then grilla = ug_Area
            If ficDistrib.Tabs(2).Active Then grilla = ug_Unidad
            If ficDistrib.Tabs(3).Active Then grilla = ug_Ocupacion
            If Sel_Grilla(grilla) Then
                Operacion = "Eliminar"
                If ficDistrib.Tabs(0).Active Then
                    oeGerencia = New e_Gerencia
                    oeGerencia.Id = ug_Gerencia.ActiveRow.Cells("Id").Value.ToString.Trim
                End If
                If ficDistrib.Tabs(1).Active Then
                    oeArea = New e_AreaAO
                    oeArea.Id = ug_Area.ActiveRow.Cells("Id").Value.ToString.Trim
                End If
                If ficDistrib.Tabs(2).Active Then
                    oeUnidad = New e_Area
                    oeUnidad.Id = ug_Unidad.ActiveRow.Cells("Id").Value.ToString.Trim
                End If
                If ficDistrib.Tabs(3).Active Then
                    oeOcupacion = New e_Ocupacion
                    oeOcupacion.Id = ug_Ocupacion.ActiveRow.Cells("Id").Value.ToString.Trim
                End If
                Guardando()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Sel_Grilla(grilla As UltraGrid) As Boolean
        If grilla.ActiveRow.Index <> -1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub tsmiAreaNuevo_Click(sender As Object, e As EventArgs) Handles tsmiAreaNuevo.Click
        Dim val As String = ug_Gerencia.Rows(ug_Gerencia.ActiveRow.Index).Cells("Id").Value
        tsmiArea.PerformClick()
        Nueva_Distrib()
        cboForanea.Enabled = False
        cboForanea.Value = val
        Operacion = "Nuevo"
    End Sub

    Private Sub tsmiUnidadNuevo_Click(sender As Object, e As EventArgs) Handles tsmiUnidadNuevo.Click
        Dim val As String = ug_Area.Rows(ug_Area.ActiveRow.Index).Cells("Id").Value
        tsmiUnidad.PerformClick()
        Nueva_Distrib()
        cboForanea.Enabled = False
        cboForanea.Value = val
        Operacion = "Nuevo"
    End Sub

    Private Sub tsmiOcupacionNuevo_Click(sender As Object, e As EventArgs) Handles tsmiOcupacionNuevo.Click
        Dim val As String = ug_Unidad.Rows(ug_Unidad.ActiveRow.Index).Cells("Id").Value
        tsmiOcupacion.PerformClick()
        Nueva_Distrib()
        cboForanea.Enabled = False
        cboForanea.Value = val
        Operacion = "Nuevo"
    End Sub
End Class
