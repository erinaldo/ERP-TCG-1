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

Public Class frm_Ocupacion
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_Ocupacion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Ocupacion()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim olOcupacion As New l_Ocupacion
    Private WithEvents oeOcupacion As New e_Ocupacion
    Private oeArea As New e_Area, olArea As New l_Area, leArea As New List(Of e_Area)
    Dim _ingresando_datos As Boolean = False
    Private dtOcupaciones As Data.DataTable
    Private _ope As String = "", _acl As String = "", _estado As String = ""

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griOcupacion.Rows.Count > 0 Then
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
                _ope = "GENERADA"
                oeOcupacion.TipoOperacion = "I"
                MostrarTabs(1, ficOcupacion, 1)
                Inicializar()
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
                _ope = "GENERADA"
                Mostrar()
                oeOcupacion.TipoOperacion = "A"
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
                MostrarTabs(1, ficOcupacion, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeOcupacion.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficOcupacion, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficOcupacion, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficOcupacion, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficOcupacion, 2)
                _ingresando_datos = False
                Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                With griOcupacion
                    If ValidarGrilla(griOcupacion, "Trabajador") Then
                        oeOcupacion.Id = .ActiveRow.Cells("ID").Value
                        oeOcupacion = olOcupacion.Obtener(oeOcupacion)
                        If oeOcupacion.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Cargo: " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeOcupacion.TipoOperacion = "E"
                                olOcupacion.Eliminar(oeOcupacion)
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
                If griOcupacion.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(griOcupacion, "Listado_Ocupaciones")
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
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            MostrarTabs(0, ficOcupacion)
            InicializaTiempo()
            CargarOcupacion(New List(Of e_Ocupacion))
            CargarCombos()
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

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeOcupacion.Activo = verActivo.Checked
    End Sub

    Private Sub cboAreaBase_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAreaBase.ValueChanged
        oeOcupacion.IdArea = cboAreaBase.Value
    End Sub

    Private Sub oeOcupacion_DatoCambiado() Handles oeOcupacion.DatoCambiado
        oeOcupacion.Modificado = True
    End Sub

    Private Sub griOcupacion_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griOcupacion.DoubleClick
        If griOcupacion.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griOcupacion_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griOcupacion.InitializeLayout
        agrGillaOcupacion.Text = "Total de Ocupaciones: " & griOcupacion.Rows.Count
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

    Private Sub CargarCombos()
        Try

            oeArea = New e_Area
            oeArea.TipoOperacion = ""
            oeArea.Activo = True
            oeArea.IndSector = -1
            leArea = olArea.Listar(oeArea)

            LlenarCombo(cboAreaBase, "Nombre", leArea, -1)

            dtOcupaciones = GenerarDTConfigurable(CargarCTCD("T30_Ocupacion_Sprivado"))
            ' LlenaComboConfigurable(cboOcupacionSunat, dtOcupaciones, "CODIGO", "NOMBRE", -1)
            'LlenaComboConfigurable(cboOcupacionSunat, "T30_Ocupacion_Sprivado", "CODIGO", "NOMBRE", -1, "NOMBRE")

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarOcupacion(leOcupa As List(Of e_Ocupacion))
        Try
            With griOcupacion

                .DataSource = leOcupa
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdArea").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 300
                .DisplayLayout.Bands(0).Columns("Area").Width = 200

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
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
            CargarOcupacion(olOcupacion.Listar(oeOcupacion))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griOcupacion.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        cboAreaBase.SelectedIndex = -1
        ' cboOcupacionSunat.SelectedIndex = -1
        cboOcuSunat.Text = String.Empty
        LlenaComboConfigurable(cboOcuSunat, dtOcupaciones, "CODIGO", "NOMBRE")
    End Sub

    Private Sub Mostrar()
        Try
            If griOcupacion.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeOcupacion.Id = griOcupacion.ActiveRow.Cells("Id").Value.ToString
                oeOcupacion = olOcupacion.Obtener(oeOcupacion)
                txtCodigo.Text = oeOcupacion.Codigo
                txtNombre.Text = oeOcupacion.Nombre
                cboAreaBase.Value = oeOcupacion.IdArea
                cboOcuSunat.Value = oeOcupacion.OcupacionSunat
                verActivo.Checked = oeOcupacion.Activo
                MostrarTabs(1, ficOcupacion, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeOcupacion.UsuarioCreacion = gUsuarioSGI.Id
            oeOcupacion.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olOcupacion.Guardar(oeOcupacion) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, ficOcupacion, 2)
                Consultar(True)
                griOcupacion.Focus()
                Return True
            End If
        Catch ex As Exception
            Throw ex
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

    Private Sub TecladoTextos(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case (Keys.Escape)
                Cancelar()

            Case (Keys.Enter)
                SendKeys.Send("{TAB}")
        End Select

    End Sub

    Private Sub TecladoGrilla(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Insert
                Nuevo()
            Case Keys.Add
                Nuevo()

            Case Keys.Multiply
                Editar()

            Case Keys.Delete
                Eliminar()

            Case Keys.Subtract
                Eliminar()

            Case Keys.Escape
                Cancelar()
        End Select
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Cargo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griOcupacion_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griOcupacion.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Ocupación"

    Private Sub mcOcupacion_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcOcupacion.Opening
        mcOcupacion.Items("tsmiNuevo").Enabled = True
        mcOcupacion.Items("tsmiEditar").Enabled = IIf(griOcupacion.Selected.Rows.Count > 0, True, False)
        mcOcupacion.Items("tsmiEliminar").Enabled = IIf(griOcupacion.Selected.Rows.Count > 0, True, False)
        mcOcupacion.Items("tsmiExportar").Enabled = IIf(griOcupacion.Rows.Count > 0, True, False)
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