Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_Marca
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Marca = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Marca()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region
    

#Region "Declaración de variables"
    Dim oeMarca As New e_Marca
    Dim olMarca As New l_Marca
    Dim _ingresando_datos As Boolean = False
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_ListaMarcas.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Inicializar()
        oeMarca.TipoOperacion = "I"
        oeMarca.UsuarioCreacion = gUsuarioSGI.Id
        MostrarTabs(1, tcMarca, 1)
        txtNombre.Focus()
        Operacion = "Nuevo"
        oeMarca.Id = ""
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            MostrarMarca()
            oeMarca.TipoOperacion = "A"
            txtCodigo.Focus()
            Operacion = "Editar"
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarMarca() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcMarca, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMarca.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarMarca() Then
                            MostrarTabs(0, tcMarca, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcMarca, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcMarca, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, tcMarca, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_ListaMarcas
                If ValidarGrilla(grid_ListaMarcas, "Marca") Then
                    oeMarca = New e_Marca
                    oeMarca.Id = .ActiveRow.Cells("ID").Value
                    oeMarca = olMarca.Obtener(oeMarca)
                    If oeMarca.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la Marca: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeMarca.TipoOperacion = "E"
                            olMarca.Eliminar(oeMarca)
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

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If grid_ListaMarcas.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_ListaMarcas)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Marca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcMarca)
        Tiempo1.Enabled = False
        InicializaTiempo()
    End Sub

    Private Sub frm_TipoMantenimiento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing

    End Sub

    Private Sub frm_TipoMantenimiento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select

        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub grid_ListaTipoMantenimiento_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeMarca.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeMarca.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
        oeMarca.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeMarca.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeMarca.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeMarca.Activo = verActivo.Checked
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        oeMarca.Modificado = True
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeMarca.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeMarca.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeMarca.Modificado = True
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeMarca.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        oeMarca.Modificado = True
    End Sub

    Private Sub grid_ListaTipoMantenimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_ListaMarcas.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub grid_ListaMarcas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_ListaMarcas.DoubleClick
        If grid_ListaMarcas.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_ListaMarcas_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_ListaMarcas.InitializeLayout
        grid_ListaMarcas.Text = "Total de Marcas: " & e.Layout.Rows.Count
        agrTotalMarcas.Text = "Total Registros: " & e.Layout.Rows.Count
    End Sub

#End Region

#Region "Métodos"

    Private Function GuardarMarca() As Boolean
        Try
            Select Case opcTipoMarca.CheckedIndex
                Case 0
                    oeMarca.TipoMarca = 0
                Case 1
                    oeMarca.TipoMarca = 1
                Case 2
                    oeMarca.TipoMarca = 2
            End Select

            If Not olMarca.Guardar(oeMarca) Then Return False
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, tcMarca, 2)
            Consultar(True)
            grid_ListaMarcas.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then txtCodigo.Focus()
        If excepcion.Contains("nombre") Then txtNombre.Focus()
        If excepcion.Contains("abreviatura") Then txtAbreviatura.Focus()
    End Sub

    Private Sub Inicializar()
        oeMarca = New e_Marca
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        AsociarMenu()
    End Sub

    Private Sub MostrarMarca()
        Try
            If grid_ListaMarcas.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeMarca.Id = grid_ListaMarcas.ActiveRow.Cells("Id").Value.ToString
                oeMarca = olMarca.Obtener(oeMarca)
                txtId.Text = oeMarca.Id
                txtCodigo.Text = oeMarca.Codigo
                txtNombre.Text = oeMarca.Nombre
                txtAbreviatura.Text = oeMarca.Abreviatura
                verActivo.Checked = oeMarca.Activo
                opcTipoMarca.CheckedIndex = oeMarca.TipoMarca
                MostrarTabs(1, tcMarca, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMarca = New e_Marca
            With grid_ListaMarcas
                oeMarca.Activo = Activo
                oeMarca.TipoMarca = opcBuscarTipoMarca.CheckedIndex
                .DataSource = olMarca.Listar(oeMarca)
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
        grid_ListaMarcas.Focus()
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Marca_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub grid_ListaMarcas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_ListaMarcas.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Marcas"

    Private Sub AsociarMenu()
        grid_ListaMarcas.ContextMenuStrip = MenuContextual1
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
        If grid_ListaMarcas.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class
