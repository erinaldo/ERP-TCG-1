'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Cliente

    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Shared instancia As frm_Cliente = Nothing
    Private Shared Operacion As String
    Private var As Integer = 0
    Public codigoExterno As String = ""
    Public indiceExterno As Integer = -1

    Public Overrides Function getInstancia() As frm_MenuPadre
        For Each Form As frm_MenuPadre In frm_Menu.MdiChildren
            If Form.Tag = TipoCliente Then
                instancia = Form
                instancia.Activate()
                Return instancia
            End If
        Next
        If instancia Is Nothing Then
            var = TipoCliente
            Operacion = "Inicializa"
            instancia = New frm_Cliente()
            instancia.Tag = TipoCliente
            instancia.Text = IIf(TipoCliente = 1, "Cliente - Persona", "Cliente - Empresa")
        Else
            If var <> TipoCliente Then
                instancia = New frm_Cliente()
                instancia.Tag = TipoCliente
                instancia.Text = IIf(TipoCliente = 1, "Cliente - Persona", "Cliente - Empresa")
            End If
        End If
        instancia.Activate()
        Return instancia
    End Function


#Region "Declaracion de Variables"
    Dim WithEvents oeCliente As New e_Cliente
    Dim olCliente As New l_Cliente
    Dim _ingresando_datos As Boolean = False
    Dim _tipo As Boolean
    Dim band As Boolean = False
#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griCliente.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        band = True
        MostrarTabs(TipoCliente, ficCliente, TipoCliente)
        Inicializar()
        txtDni.Text = String.Empty
        oeCliente.TipoOperacion = "I"
        oeCliente.Modificado = False
        If TipoCliente = 1 Then
            oeCliente.oePersona.TipoOperacion = "I"
            txtDni.Focus()
        Else
            oeCliente.oeEmpresa.TipoOperacion = "I"
            txtRuc.Focus()
        End If
        If codigoExterno = "CO" Then
            verComisionista.Checked = True
        End If
        If codigoExterno = "CL" Then
            verComisionista.Checked = False            
        End If
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        band = False
        Mostrar()
        oeCliente.TipoOperacion = "A"
        oeCliente.Modificado = False
        If TipoCliente = 1 Then
            oeCliente.oePersona.TipoOperacion = "A"
            txtDni.Focus()
        Else
            oeCliente.oeEmpresa.TipoOperacion = "A"
            txtRuc.Focus()
        End If
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(TipoCliente, ficCliente, TipoCliente)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCliente.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficCliente, 3)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(TipoCliente, ficCliente, TipoCliente)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficCliente, 3)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficCliente, 3)
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

            If ValidarGrilla(griCliente, "Cliente") Then
                oeCliente.Id = griCliente.ActiveRow.Cells("Id").Value
                oeCliente = olCliente.Obtener(oeCliente)
                If oeCliente.Activo Then
                    If MessageBox.Show("Esta seguro de eliminar Cliente: " & _
                             griCliente.ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeCliente.TipoOperacion = "E"
                        olCliente.Eliminar(oeCliente)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
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

            If griCliente.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griCliente)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Public Sub frm_Cliente_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Public Sub frm_Cliente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        colorComisionista.Color = Color.Gainsboro
        etiComisionista.Appearance.BackColor = colorComisionista.Color
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, ficCliente)
        'IIf(TipoCliente = 1, ficCliente.Tabs(2).Visible = False, ficCliente.Tabs(1).Visible = False)
        If TipoCliente = 1 Then
            ficCliente.Tabs(2).Visible = False
        Else
            ficCliente.Tabs(1).Visible = False
        End If
        UltraTabPageControl1.HorizontalScroll.Visible = True
        UltraTabPageControl2.HorizontalScroll.Visible = True
        UltraTabPageControl3.HorizontalScroll.Visible = True

        'UltraTabSharedControlsPage1.HorizontalScroll.Visible = True

        Tiempo1.Enabled = False
        InicializaTiempo()

    End Sub

    Private Sub txtDni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDni.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtDni_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDni.ValueChanged
        Try
            oeCliente.oePersona.Dni = txtDni.Text.Trim
            If band Then
                If txtDni.Text.Length = 8 Then
                    Dim oePersona As New e_Persona
                    oePersona.Dni = oeCliente.oePersona.Dni
                    Dim olPersona As New l_Persona
                    oePersona = olPersona.Obtener(oePersona)
                    If Not String.IsNullOrEmpty(oePersona.Id) Then
                        oeCliente.oePersona.Id = oePersona.Id
                        oeCliente.oePersona.ApellidoPaterno = oePersona.ApellidoPaterno
                        oeCliente.oePersona.ApellidoMaterno = oePersona.ApellidoMaterno
                        oeCliente.oePersona.Nombre = oePersona.Nombre
                        oeCliente.oePersona.FechaNacimiento = oePersona.FechaNacimiento
                        oeCliente.oePersona.oeSexo = oePersona.oeSexo

                        Dim oeTemp As New e_Cliente
                        oeTemp.TipoOperacion = "X"
                        oeTemp.TipoPersonaEmpresa = 1
                        oeTemp.IdPersona = oeCliente.oePersona.Id
                        oeTemp = olCliente.Obtener(oeTemp)

                        If Not String.IsNullOrEmpty(oeTemp.Id) Then
                            oeCliente.Id = oeTemp.Id
                            oeCliente.Codigo = oeTemp.Codigo
                            oeCliente.Comisionista = oeTemp.Comisionista
                            oeCliente.FechaActividad = oeTemp.FechaActividad
                            oeCliente.TipoPersonaEmpresa = oeTemp.TipoPersonaEmpresa
                            oeCliente.IdPersona = oeTemp.IdPersona
                            oeCliente.TipoOperacion = "A"
                        Else
                            oeCliente.Comisionista = 0
                        End If

                        CargarDatos()
                    End If
                Else
                    Inicializar()
                End If
            End If
            'If Not String.IsNullOrEmpty(txtDni.Text) Then PictureBox1.Image = olCliente.Foto(oeCliente.oePersona.Dni)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
        
    End Sub

    Private Sub txtApellidoPaterno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoPaterno.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtApellidoPaterno_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoPaterno.ValueChanged
        oeCliente.oePersona.ApellidoPaterno = txtApellidoPaterno.Text.Trim
    End Sub

    Private Sub txtApellidoMaterno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoMaterno.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtApellidoMaterno_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoMaterno.ValueChanged
        oeCliente.oePersona.ApellidoMaterno = txtApellidoMaterno.Text.Trim
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeCliente.oePersona.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeCliente.Activo = verActivo.Checked
    End Sub

    Private Sub verComisionista_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verComisionista.CheckedChanged
        oeCliente.Comisionista = verComisionista.Checked
    End Sub

    Private Sub fecFechaNacimiento_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecFechaNacimiento.ValueChanged
        oeCliente.oePersona.FechaNacimiento = fecFechaNacimiento.Value
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeCliente.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub griCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griCliente.DoubleClick
        If griCliente.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub txtCodigoCE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoCE.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCodigoCE_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCE.ValueChanged
        oeCliente.Codigo = txtCodigoCE.Text.Trim
    End Sub

    Private Sub txtRazonSocial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRazonSocial.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtRazonSocial_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRazonSocial.ValueChanged
        oeCliente.oeEmpresa.Nombre = txtRazonSocial.Text.Trim
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        oeCliente.oeEmpresa.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub txtRuc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRuc.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtRuc_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRuc.ValueChanged
        oeCliente.oeEmpresa.Ruc = txtRuc.Text.Trim
    End Sub

    Private Sub verActivoCE_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivoCE.CheckedChanged
        oeCliente.Activo = verActivoCE.Checked
    End Sub

    Private Sub colorComisionista_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorComisionista.ColorChanged
        etiComisionista.Appearance.BackColor = colorComisionista.Color
    End Sub

    Private Sub griCliente_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griCliente.InitializeLayout
        agrGrillaCliente.Text = "Total de Clientes: " & e.Layout.Rows.Count
    End Sub

    Private Sub oeCliente_DatoCambiado() Handles oeCliente.DatoCambiado
        oeCliente.Modificado = True
    End Sub

    Private Sub txtDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDni.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRuc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRuc.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeCliente = New e_Cliente
            With griCliente
                oeCliente.Activo = Activo
                oeCliente.TipoClienteProveedor = 1
                oeCliente.TipoPersonaEmpresa = TipoCliente
                .DataSource = olCliente.Listar(oeCliente)
            End With

            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griCliente.Rows
                If Fila.Cells("Comisionista").Value = 1 Then Fila.Appearance.BackColor = colorComisionista.Color
            Next

            'Ubica el cursor el el primer registro de la grilla
            If griCliente.Rows.Count > 0 Then
                griCliente.Focus()
                griCliente.Rows.Item(0).Selected = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griCliente.Focus()
    End Sub

    Private Sub Inicializar()
        If TipoCliente = 1 Then
            txtCodigo.Text = String.Empty
            txtApellidoPaterno.Text = String.Empty
            txtApellidoMaterno.Text = String.Empty
            txtNombre.Text = String.Empty
            'txtDni.Text = String.Empty
            fecFechaNacimiento.Value = Nothing
            verActivo.Checked = True
            verComisionista.Checked = False
            Sexo1.opcMasculino.Checked = True
        Else
            txtCodigoCE.Text = String.Empty
            txtRuc.Text = String.Empty
            txtRazonSocial.Text = String.Empty
            txtAbreviatura.Text = String.Empty
            verActivoCE.Checked = True
        End If
    End Sub

    ''' <summary>
    ''' Obtener el ID del Cliente y mostrar su información específica
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Mostrar()
        Try
            If codigoExterno = "" Then
                If griCliente.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                    Inicializar()
                    oeCliente = New e_Cliente
                    oeCliente.Id = griCliente.ActiveRow.Cells("Id").Value.ToString                    
                End If
            Else
                oeCliente = New e_Cliente
                oeCliente.Id = codigoExterno
                TipoCliente = "1"
            End If
            oeCliente = olCliente.Obtener(oeCliente)
            CargarDatos()
            'IIf(TipoCliente = 1, MostrarTabs(1, ficCliente, 1), MostrarTabs(2, ficCliente, 2))
            MostrarTabs(TipoCliente, ficCliente, TipoCliente)
            MyBase.Editar()
           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Guardar la información del Cliente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Guardando() As Boolean
        Try
            'LlenaTelefono()
            'LlenaEmail()
            If TipoCliente = 1 Then
                oeCliente.oePersona.oeSexo.Id = Sexo1.Sexo.Id
                oeCliente.oePersona.UsuarioCreacion = gUsuarioSGI.Id
            Else
                oeCliente.oeEmpresa.UsuarioCreacion = gUsuarioSGI.Id
            End If
            oeCliente.TipoPersonaEmpresa = TipoCliente
            oeCliente.UsuarioCreacion = gUsuarioSGI.Id
            oeCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If codigoExterno <> "" Then
                frm_DemandaRapida.codigoNuevoCom = codigoExterno
                If codigoExterno = "CO" Then
                    '  Consultar(_Activo)
                    Dim codigoNuevo = olCliente.GuardarCliente(oeCliente)
                    frm_DemandaRapida.txtApellidoMaterno.Text = oeCliente.oePersona.ApellidoMaterno
                    frm_DemandaRapida.txtApellidoPaternoComisionista.Text = oeCliente.oePersona.ApellidoPaterno
                    frm_DemandaRapida.txtNombreComisonista.Text = oeCliente.oePersona.NombreCompleto
                    '   LlenarComboMaestro(frm_DemandaRapida.cboComisionista, ComisionistasPublic, 0)
                    ' frm_DemandaRapida.cboComisionista.Value = codigoNuevo
                    '    frm_DemandaRapida.codigoNuevoCom = oeCliente.Id
                Else
                    If olCliente.Guardar(oeCliente) Then
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                        frm_DemandaRapida.txtApellidoMaterno.Text = oeCliente.oePersona.ApellidoMaterno
                        frm_DemandaRapida.txtApellidoPaternoComisionista.Text = oeCliente.oePersona.ApellidoPaterno
                        frm_DemandaRapida.txtNombreComisonista.Text = oeCliente.oePersona.NombreCompleto
                        ' frm_DemandaRapida.txtTelefonoComisionista.Text = oeCliente.oePersona.Telefono
                    End If
                End If
                Me.Dispose()
            Else
                If olCliente.Guardar(oeCliente) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)

                    Consultar(_Activo)
                    griCliente.Focus()
                    Return True
                End If
                MostrarTabs(0, ficCliente, 2)

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

    Private Sub CargarDatos()
        If TipoCliente = 1 Then
            txtCodigo.Text = oeCliente.Codigo
            txtApellidoPaterno.Text = oeCliente.oePersona.ApellidoPaterno
            txtApellidoMaterno.Text = oeCliente.oePersona.ApellidoMaterno
            txtNombre.Text = oeCliente.oePersona.Nombre
            txtDni.Text = oeCliente.oePersona.Dni
            Sexo1.Sexo = New e_Sexo(CType(oeCliente.oePersona.oeSexo.Id, String))
            fecFechaNacimiento.Value = oeCliente.oePersona.FechaNacimiento
            verComisionista.Checked = oeCliente.Comisionista
            verActivo.Checked = oeCliente.Activo
        Else
            txtCodigoCE.Text = oeCliente.Codigo
            txtRazonSocial.Text = oeCliente.oeEmpresa.Nombre
            txtAbreviatura.Text = oeCliente.oeEmpresa.Abreviatura
            txtRuc.Text = oeCliente.oeEmpresa.Ruc
            verActivoCE.Checked = oeCliente.Activo
        End If
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Cliente_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griCliente_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griCliente.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Cliente"

    Private Sub AsociarMenu()
        griCliente.ContextMenuStrip = MenuContextual1
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
        If griCliente.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region


End Class