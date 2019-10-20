'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_ModeloFuncionalVehiculo

    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_ModeloFuncionalVehiculo = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ModeloFuncionalVehiculo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"
    Dim oeModeloFuncionalVehiculo As New e_ModeloFuncionalVehiculo
    Dim olModeloFuncionalVehiculo As New l_ModeloFuncionalVehiculo
    Dim _ingresando_datos As Boolean = False
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            If grid_ListaModeloFuncionalVeh.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeModeloFuncionalVehiculo.TipoOperacion = "I"
        MostrarTabs(1, tcModeloFuncionalVehiculo, 1)
        Inicializar()
        txtCodigo.Focus()
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        MostrarModeloFuncionalVehiculo()
        oeModeloFuncionalVehiculo.TipoOperacion = "A"
        txtCodigo.Focus()
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarMarca() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcModeloFuncionalVehiculo, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeModeloFuncionalVehiculo.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarMarca() Then
                            MostrarTabs(0, tcModeloFuncionalVehiculo, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcModeloFuncionalVehiculo, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcModeloFuncionalVehiculo, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)

                End Select
            Else
                MostrarTabs(0, tcModeloFuncionalVehiculo, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_ListaModeloFuncionalVeh
                If ValidarGrilla(grid_ListaModeloFuncionalVeh, "Modelo Funcional Vehiculo") Then
                    oeModeloFuncionalVehiculo.Id = .ActiveRow.Cells("ID").Value
                    oeModeloFuncionalVehiculo = olModeloFuncionalVehiculo.Obtener(oeModeloFuncionalVehiculo)
                    If oeModeloFuncionalVehiculo.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la Modelo Funcional: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeModeloFuncionalVehiculo.TipoOperacion = "E"
                            olModeloFuncionalVehiculo.Eliminar(oeModeloFuncionalVehiculo)
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

            If grid_ListaModeloFuncionalVeh.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_ListaModeloFuncionalVeh)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"
    Private Function GuardarMarca() As Boolean
        Try
            oeModeloFuncionalVehiculo.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olModeloFuncionalVehiculo.Guardar(oeModeloFuncionalVehiculo) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcModeloFuncionalVehiculo, 2)
                Consultar(True)
                grid_ListaModeloFuncionalVeh.Focus()
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
        If excepcion.Contains("abreviatura") Then
            txtAbreviatura.Focus()
        End If
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        AsociarMenu()
    End Sub

    Private Sub MostrarModeloFuncionalVehiculo()
        Try
            If grid_ListaModeloFuncionalVeh.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                oeModeloFuncionalVehiculo.Id = grid_ListaModeloFuncionalVeh.ActiveRow.Cells("Id").Value.ToString
                oeModeloFuncionalVehiculo = olModeloFuncionalVehiculo.Obtener(oeModeloFuncionalVehiculo)
                txtCodigo.Text = oeModeloFuncionalVehiculo.Codigo
                txtNombre.Text = oeModeloFuncionalVehiculo.Nombre
                txtAbreviatura.Text = oeModeloFuncionalVehiculo.Abreviatura
                verActivo.Checked = oeModeloFuncionalVehiculo.Activo
                MostrarTabs(1, tcModeloFuncionalVehiculo, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeModeloFuncionalVehiculo = New e_ModeloFuncionalVehiculo
            With grid_ListaModeloFuncionalVeh
                oeModeloFuncionalVehiculo.Activo = Activo
                .DataSource = olModeloFuncionalVehiculo.Listar(oeModeloFuncionalVehiculo)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoOperacion").Hidden = True

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
        grid_ListaModeloFuncionalVeh.Focus()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ModeloFuncionalVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, tcModeloFuncionalVehiculo)
        InicializaTiempo()
    End Sub

    Private Sub frm_ModeloFuncionalVehiculo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing

    End Sub

    Private Sub frm_ModeloFuncionalVehiculo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub grid_ListaModeloFuncionalVeh_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grid_ListaModeloFuncionalVeh_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_ListaModeloFuncionalVeh.DoubleClick
        If grid_ListaModeloFuncionalVeh.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeModeloFuncionalVehiculo.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeModeloFuncionalVehiculo.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
        oeModeloFuncionalVehiculo.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeModeloFuncionalVehiculo.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
        oeModeloFuncionalVehiculo.Modificado = True
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeModeloFuncionalVehiculo.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeModeloFuncionalVehiculo.Activo = verActivo.Checked
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        oeModeloFuncionalVehiculo.Modificado = True
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeModeloFuncionalVehiculo.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeModeloFuncionalVehiculo.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeModeloFuncionalVehiculo.Modificado = True
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeModeloFuncionalVehiculo.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        oeModeloFuncionalVehiculo.Modificado = True
    End Sub

    Private Sub grid_ListaModeloFuncionalVeh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub grid_ListaModeloFuncionalVeh_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)
        agrModeloFuncionalVehiculo.Text = "Total de Modelos funcionales de vehículo: " & e.Layout.Rows.Count
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_ModeloFuncionalVehiculo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub grid_ListaModeloFuncionalVeh_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_ListaModeloFuncionalVeh.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Modelo Funcional"

    Private Sub AsociarMenu()
        grid_ListaModeloFuncionalVeh.ContextMenuStrip = MenuContextual1
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
        If grid_ListaModeloFuncionalVeh.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class
