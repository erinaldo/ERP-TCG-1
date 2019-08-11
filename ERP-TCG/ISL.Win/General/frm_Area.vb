Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Area
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_Area = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Area()
        End If
        instancia.Activate()
        Return instancia

    End Function

#Region "Declaracion de Variables"

    Private WithEvents oeArea As New e_Area
    Private olArea As New l_Area, leArea As New List(Of e_Area), leSeccion As New List(Of e_Area)
    Dim _ingresando_datos As Boolean = False
    Private _opeArea As String = "", _acl As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Instancia"
            If griArea.Rows.Count > 0 Then
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
                MostrarTabs(1, ficArea, 1)
                Inicializar()
                oeArea = New e_Area
                oeArea.TipoOperacion = "I"
                oeArea.Activo = True
                oeArea.Modificado = False
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
                oeArea.TipoOperacion = "A"
                oeArea.Modificado = False
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
                MostrarTabs(1, ficArea, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeArea.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficArea, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficArea, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficArea, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficArea, 2)
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
                If ValidarGrilla(griArea, "Area") Then
                    oeArea.Id = griArea.ActiveRow.Cells("ID").Value
                    oeArea = olArea.Obtener(oeArea)
                    If oeArea.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Area: " & _
                                 griArea.ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeArea.TipoOperacion = "E"
                            olArea.Eliminar(oeArea)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
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
                If griArea.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(griArea, "Registro de Areas")
                MyBase.Exportar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Area_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

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
            Tiempo1.Enabled = False
            CargarCombo()
            leSeccion = New List(Of e_Area)
            CargarSecciones(leSeccion)
            MostrarTabs(0, ficArea)
            InicializaTiempo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griArea_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griArea.DoubleClick
        If griArea.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griArea_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griArea.InitializeLayout
        agrListaAreas.Text = "Total de Areas: " & e.Layout.Rows.Count
    End Sub

    Private Sub chkSeccion_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeccion.CheckedChanged
        If chkSeccion.Checked Then
            cboArea.ReadOnly = False
            cboArea.Focus()
        Else
            cboArea.SelectedIndex = -1
            cboArea.ReadOnly = True
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombo()
        Try
            oeArea = New e_Area
            oeArea.TipoOperacion = ""
            oeArea.Activo = True
            oeArea.IndSector = 0
            leArea = olArea.Listar(oeArea)
            LlenarCombo(cboArea, "Nombre", leArea.Where(Function(x) x.IsGerencia = 0).ToList, -1)

            oeArea = New e_Area
            leArea = New List(Of e_Area)
            oeArea.Nombre = "--Seleccionar--"
            oeArea.IsGerencia = 1
            oeArea.Id = ""
            leArea.Add(oeArea)
            oeArea = New e_Area
            oeArea.TipoOperacion = ""
            oeArea.Activo = True
            leArea.AddRange(olArea.Listar(oeArea))
            Dim lista = leArea.Where(Function(x) x.IsGerencia = 1).ToList
            LlenarCombo(cboGerencia, "Nombre", lista, 0)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarSecciones(leSec As List(Of e_Area))
        Try
            With griArea
                .ResetDisplayLayout()
                .DataSource = leSec
                OcultarColumna(griArea, True, "Id", "IndSector", "IdSector", "Activo", "UsuarioCreacion", "FechaCreacion", "IsGerencia", "IdGerencia")
                ExcluirColumna(griArea, "Id", "IndSector", "IdSector", "Activo", "UsuarioCreacion", "FechaCreacion", "IsGerencia", "IdGerencia")

                'Ubica el cursor el el primer registro de la grilla

                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Abreviatura").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Sector").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Gerencia").Header.VisiblePosition = 4

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 100
                .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 150
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .DisplayLayout.Bands(0).Columns("Sector").Width = 250
                .DisplayLayout.Bands(0).Columns("Gerencia").Width = 250

                .DisplayLayout.Bands(0).Columns("Sector").Header.Caption = "Area Superior"

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
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

            oeArea = New e_Area
            oeArea.TipoOperacion = "I"
            oeArea.IndSector = -1
            oeArea.Activo = True
            leSeccion = olArea.Listar(oeArea)
            CargarSecciones(leSeccion)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griArea.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        verActivo.Checked = True
        chkSeccion.Checked = True
        cboArea.SelectedIndex = -1
        cboArea.ReadOnly = False
    End Sub

    Private Sub Mostrar()
        Try
            If griArea.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeArea = New e_Area
                oeArea.Id = griArea.ActiveRow.Cells("Id").Value.ToString
                oeArea = olArea.Obtener(oeArea)
                txtCodigo.Text = oeArea.Codigo
                txtNombre.Text = oeArea.Nombre
                txtAbreviatura.Text = oeArea.Abreviatura
                verActivo.Checked = oeArea.Activo
                chkSeccion.Checked = IIf(oeArea.IndSector = 1, True, False)
                cboArea.Value = oeArea.IdSector
                chkGerencia.Checked = IIf(oeArea.IsGerencia = 1, True, False)
                cboGerencia.Value = oeArea.IdGerencia
                MostrarTabs(1, ficArea, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            RecolectarDatos()
            oeArea.UsuarioCreacion = gUsuarioSGI.Id
            If olArea.Guardar(oeArea) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficArea, 2)
                Consultar(_Activo)
                griArea.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub RecolectarDatos()
        oeArea.Codigo = txtCodigo.Text.Trim
        oeArea.Nombre = txtNombre.Text.Trim
        oeArea.Abreviatura = txtAbreviatura.Text.Trim
        oeArea.IndSector = IIf(chkSeccion.Checked, 1, 0)
        oeArea.IdSector = cboArea.Value
        oeArea.IsGerencia = IIf(chkGerencia.Checked, 1, 0)
        oeArea.IdGerencia = cboGerencia.Value
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("Nombre") Then
            txtNombre.Focus()
        End If
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Area_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griArea_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griArea.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de areas"

    Private Sub mcArea_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcArea.Opening
        mcArea.Items("tsmiNuevo").Enabled = True
        mcArea.Items("tsmiEditar").Enabled = IIf(griArea.Selected.Rows.Count > 0, True, False)
        mcArea.Items("tsmiEliminar").Enabled = IIf(griArea.Selected.Rows.Count > 0, True, False)
        mcArea.Items("tsmiExportar").Enabled = IIf(griArea.Rows.Count > 0, True, False)
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

    Private Sub chkGerencia_CheckedChanged(sender As Object, e As EventArgs) Handles chkGerencia.CheckedChanged
        If chkGerencia.Checked Then
            cboGerencia.SelectedIndex = 0
            cboGerencia.ReadOnly = True
        Else
            cboGerencia.ReadOnly = False
            cboGerencia.Focus()
        End If
    End Sub
End Class