'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Proveedor

    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Proveedor = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Proveedor()
        End If
        instancia.Activate()
        Return instancia
    End Function


#Region "Declaracion de Variables"
    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor
    Dim _ingresando_datos As Boolean = False
    Dim _tipo As Boolean
    Public RegistroProveedor As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griProveedor.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeProveedor.TipoOperacion = "I"
        'MostrarTabs(1, ficCliente, 1)
        MostrarTabs(TipoProveedor, ficProveedor, TipoProveedor)
        Inicializar()
        If TipoProveedor = 1 Then
            oeProveedor.oePersona.TipoOperacion = "I"
            'txtDni.Focus()
        Else
            oeProveedor.oeEmpresa.TipoOperacion = "I"
            'txtRuc.Focus()
        End If
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeProveedor.TipoOperacion = "A"
        'IIf(TipoCliente = 1, oeCliente.oePersona.TipoOperacion = "A", oeCliente.oeEmpresa.TipoOperacion = "A")
        'IIf(TipoCliente = 1, txtDni.Focus(), txtRuc.Focus)
        If TipoProveedor = 1 Then
            oeProveedor.oePersona.TipoOperacion = "A"
            txtDni.Focus()
        Else
            oeProveedor.oeEmpresa.TipoOperacion = "A"
            'txtRuc.Focus()
        End If
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(TipoProveedor, ficProveedor, TipoProveedor)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeProveedor.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            'MostrarTabs(0, ficCliente, 2)
                            MostrarTabs(0, ficProveedor, 3)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            'MostrarTabs(1, ficCliente, 1)
                            MostrarTabs(TipoProveedor, ficProveedor, TipoProveedor)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        'MostrarTabs(0, ficCliente, 2)
                        MostrarTabs(0, ficProveedor, 3)
                        _ingresando_datos = False
                        Consultar(_Activo)
                        'Exit Sub

                End Select
            Else
                'MostrarTabs(0, ficCliente, 2)
                MostrarTabs(0, ficProveedor, 3)
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
            With griProveedor
                If ValidarGrilla(griProveedor, "Proveedor") Then
                    oeProveedor.Id = .ActiveRow.Cells("Id").Value
                    oeProveedor = olProveedor.Obtener(oeProveedor)
                    If oeProveedor.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar Proveedor: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeProveedor.TipoOperacion = "E"
                            olProveedor.Eliminar(oeProveedor)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
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

            If griProveedor.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griProveedor)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
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

    Private Sub frm_Proveedor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Proveedor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficProveedor)
        InicializaTiempo()
        'IIf(TipoCliente = 1, ficCliente.Tabs(2).Visible = False, ficCliente.Tabs(1).Visible = False)
        If TipoProveedor = 1 Then
            ficProveedor.Tabs(2).Visible = False
        Else
            ficProveedor.Tabs(1).Visible = False
        End If
        If RegistroProveedor = "TES" Then
            MostrarTabs(2, ficProveedor, 2)
            btnGuardarProveedor.Visible = True

            oeProveedor.TipoOperacion = "I"
            oeProveedor.UsuarioCreacion = gUsuarioSGI.Id
            TipoProveedor = 2
            oeProveedor.TipoPersonaEmpresa = 2
            oeProveedor.oeEmpresa.IdTipoEmpresa = "1CH000000001"
            oeProveedor.oeEmpresa.TipoOperacion = "I"
        End If

        'ficProveedor.Scroll(Infragistics.Win.UltraWinTabs.ScrollType.First)
    End Sub

    Private Sub griProveedor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griProveedor.DoubleClick
        If griProveedor.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griProveedor_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griProveedor.InitializeLayout
        agrGrillaProveedor.Text = "Total de Proveedores: " & e.Layout.Rows.Count
    End Sub

    Private Sub txtApellidoMaterno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoMaterno.KeyDown
        oeProveedor.Modificado = True
    End Sub

    Private Sub txtApellidoMaterno_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoMaterno.ValueChanged
        oeProveedor.oePersona.ApellidoMaterno = txtApellidoMaterno.Text.Trim
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        oeProveedor.Modificado = True
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        oeProveedor.oeEmpresa.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub txtApellidoPaterno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoPaterno.KeyDown
        oeProveedor.Modificado = True
    End Sub

    Private Sub txtApellidoPaterno_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoPaterno.ValueChanged
        oeProveedor.oePersona.ApellidoPaterno = txtApellidoPaterno.Text
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        oeProveedor.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeProveedor.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtCodigoCE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoCE.KeyDown
        oeProveedor.Modificado = True
    End Sub

    Private Sub txtCodigoCE_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCE.ValueChanged
        oeProveedor.Codigo = txtCodigoCE.Text.Trim
    End Sub

    Private Sub txtDni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDni.KeyDown
        oeProveedor.Modificado = True
    End Sub

    Private Sub txtDni_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDni.ValueChanged
        oeProveedor.oePersona.Dni = txtDni.Text.Trim
        'If Not String.IsNullOrEmpty(txtDni.Text) Then PictureBox1.Image = olProveedor.Foto(oeProveedor.oePersona.Dni)
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        oeProveedor.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeProveedor.oePersona.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtRazonSocial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRazonSocial.KeyDown
        oeProveedor.Modificado = True
    End Sub

    Private Sub txtRazonSocial_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRazonSocial.ValueChanged
        oeProveedor.oeEmpresa.Nombre = txtRazonSocial.Text.Trim
    End Sub

    Private Sub txtRuc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRuc.KeyDown
        oeProveedor.Modificado = True
    End Sub

    Private Sub txtRuc_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRuc.ValueChanged
        oeProveedor.oeEmpresa.Ruc = txtRuc.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeProveedor.Activo = verActivo.Checked
    End Sub

    Private Sub verActivoCE_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivoCE.CheckedChanged
        oeProveedor.Activo = verActivoCE.Checked
    End Sub

    Private Sub fecFechaNacimiento_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecFechaNacimiento.ValueChanged
        oeProveedor.oePersona.FechaNacimiento = fecFechaNacimiento.Value
    End Sub

    Private Sub btnGuardarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarProveedor.Click
        Guardar()
    End Sub

    Private Sub btnObtenerSunat_Click(sender As Object, e As EventArgs) Handles btnObtenerSunat.Click
        Try
            Dim oeEmp As New e_Persona
            oeEmp = ObtenerDesdeSunat(Me.txtRuc.Value)
            txtRazonSocial.Text = oeEmp.Nombre
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodo"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeProveedor = New e_Proveedor
            With griProveedor
                oeProveedor.Activo = Activo
                oeProveedor.TipoPersonaEmpresa = TipoProveedor
                .DataSource = olProveedor.Listar(oeProveedor)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoPersonaEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPersona").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("NroDocumento").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("FechaActividad").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Activo").Header.VisiblePosition = 5

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 100
                .DisplayLayout.Bands(0).Columns("NroDocumento").Width = 100
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 300
                .DisplayLayout.Bands(0).Columns("FechaActividad").Width = 100

                .DisplayLayout.Bands(0).Columns("NroDocumento").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("Nombre").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griProveedor.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtApellidoPaterno.Text = String.Empty
        txtApellidoMaterno.Text = String.Empty
        txtNombre.Text = String.Empty
        txtDni.Text = String.Empty
        fecFechaNacimiento.Value = Nothing
        verActivo.Checked = True
        Sexo1.opcMasculino.Checked = True

        txtCodigoCE.Text = String.Empty
        txtRuc.Text = String.Empty
        txtRazonSocial.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        verActivoCE.Checked = True

        AsociarMenu()

    End Sub

    Private Sub Mostrar()
        Try
            If griProveedor.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeProveedor.Id = griProveedor.ActiveRow.Cells("Id").Value.ToString
                oeProveedor = olProveedor.Obtener(oeProveedor)

                If TipoProveedor = 1 Then
                    txtCodigo.Text = oeProveedor.Codigo
                    txtApellidoPaterno.Text = oeProveedor.oePersona.ApellidoPaterno
                    txtApellidoMaterno.Text = oeProveedor.oePersona.ApellidoMaterno
                    txtNombre.Text = oeProveedor.oePersona.Nombre
                    txtDni.Text = oeProveedor.oePersona.Dni
                    fecFechaNacimiento.Value = oeProveedor.oePersona.FechaNacimiento
                    Sexo1.Sexo = New e_Sexo(CType(oeProveedor.oePersona.oeSexo.Id, String))
                    verActivo.Checked = oeProveedor.Activo
                Else
                    txtCodigoCE.Text = oeProveedor.Codigo
                    txtRazonSocial.Text = oeProveedor.oeEmpresa.Nombre
                    txtAbreviatura.Text = oeProveedor.oeEmpresa.Abreviatura
                    txtRuc.Text = oeProveedor.oeEmpresa.Ruc
                    verActivoCE.Checked = oeProveedor.Activo
                End If
                'IIf(TipoCliente = 1, MostrarTabs(1, ficCliente, 1), MostrarTabs(2, ficCliente, 2))
                MostrarTabs(TipoProveedor, ficProveedor, TipoProveedor)

                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            'LlenaTelefono()
            'LlenaEmail()
            If TipoProveedor = 1 Then
                oeProveedor.oePersona.oeSexo.Id = Sexo1.Sexo.Id
                oeProveedor.oePersona.UsuarioCreacion = gUsuarioSGI.Id
            Else
                oeProveedor.oeEmpresa.UsuarioCreacion = gUsuarioSGI.Id
            End If
            oeProveedor.oePersona.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeProveedor.oeEmpresa.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeProveedor.TipoPersonaEmpresa = TipoProveedor
            oeProveedor.UsuarioCreacion = gUsuarioSGI.Id
            oeProveedor.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olProveedor.Guardar(oeProveedor) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                If RegistroProveedor = "TES" Then
                    'frm_Movimiento.AgregarNuevoProveedor(oeProveedor)
                    RegistroProveedor = oeProveedor.oeEmpresa.Ruc
                    Hide()
                    'frm_Movimiento.LlenaCombosTrabajadores()
                    'frm_Movimiento.txtRUC.Text = txtRuc.Text
                    Exit Function
                End If
                MostrarTabs(0, ficProveedor, 2)
                Consultar(_Activo)
                griProveedor.Focus()
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

   


#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Proveedor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griProveedor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griProveedor.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Proveedor"

    Private Sub AsociarMenu()
        griProveedor.ContextMenuStrip = MenuContextual1
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

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griProveedor.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class