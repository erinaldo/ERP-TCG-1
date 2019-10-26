'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_Servicio
    Inherits frm_MenuPadre

#Region "Inicializacion de Formulario"
    Private Shared instancia As frm_Servicio = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_Servicio
        End If
        instancia.Activate()
        Return instancia
    End Function
#End Region

#Region "Declaración de variables"

    Dim oeServicio As New e_Servicio
    Dim olServicio As New l_Servicio

    Dim oeServicioCuentaContable As New e_ServicioCuentaContable
    Dim olServicioCuentaContable As New l_ServicioCuentaContable

    Dim oeCategoriaServicio As New e_CategoriaServicio
    Dim olCategoriaServicio As New l_CategoriaServicio

    Private ServicioCuentaContable As New List(Of e_ServicioCuentaContable)
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            If grid_Servicios.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeServicio.TipoOperacion = "I"
        MostrarTabs(1, tcServicio, 1)
        Inicializar()
        cmbCategoriaServicio.Focus()
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        MostrarServicio()
        oeServicio.TipoOperacion = "A"
        cmbCategoriaServicio.Focus()
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarServicio() Then
                ActualizarListaPublica("CATEGORIASERVICIO")
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcServicio, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeServicio.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarServicio() Then
                            MostrarTabs(0, tcServicio, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcServicio, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcServicio, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)

                End Select
            Else
                MostrarTabs(0, tcServicio, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_Servicios
                If ValidarGrilla(grid_Servicios, "Servicios") Then
                    oeServicio.Id = .ActiveRow.Cells("Id").Value
                    oeServicio = olServicio.Obtener(oeServicio)
                    If oeServicio.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Servicio: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeServicio.TipoOperacion = "E"
                            olServicio.Eliminar(oeServicio)
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

            If grid_Servicios.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_Servicios)

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
    Private Sub frm_Servicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcServicio)
        Tiempo1.Enabled = False
        InicializaTiempo()
    End Sub
    Private Sub frm_Servicio_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub
    Private Sub frm_Servicio_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeServicio.Activo = verActivo.Checked
    End Sub

    Private Sub cboItemGasto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItemGasto.ValueChanged
        oeServicio.IdItemGasto = Me.cboItemGasto.Value
    End Sub

    Private Sub txtDescripcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.ValueChanged
        txtDescripcion.Text = LTrim(txtDescripcion.Text)
        oeServicio.Descripcion = txtDescripcion.Text
    End Sub

    Private Sub ndPrecio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndPrecio.ValueChanged
        oeServicio.Precio = ndPrecio.Value
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeServicio.Nombre = txtNombre.Text
    End Sub

    Private Sub cmbCategoriaServicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategoriaServicio.ValueChanged
        oeServicio.IdCategoriaServicio = cmbCategoriaServicio.Value
    End Sub

    Private Sub cboCuentaDebe_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaDebe.ValueChanged
        Dim oeCta As New e_CuentaContable
        If Me.cboCuentaDebe.SelectedIndex <> -1 Then
            If Me.cboCuentaDebe.Value = Me.cboCuentaHaber.Value Then
                mensajeEmergente.Problema("La Cuena Debe no Puede ser Igual a la Cuenta Haber")
                Me.cboCuentaDebe.SelectedIndex = -1
                Me.txtCuentaDebe.Text = String.Empty
            Else
                oeCta = Me.cboCuentaDebe.Items(Me.cboCuentaDebe.SelectedIndex).ListObject
                Me.txtCuentaDebe.Text = oeCta.Nombre
            End If
        End If
    End Sub

    Private Sub cboCuentaHaber_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaHaber.ValueChanged
        Dim oeCta As New e_CuentaContable
        If Me.cboCuentaHaber.SelectedIndex <> -1 Then
            If Me.cboCuentaHaber.Value = Me.cboCuentaDebe.Value Then
                mensajeEmergente.Problema("La Cuena Haber no Puede ser Igual a la Cuenta Debe")
                Me.cboCuentaHaber.SelectedIndex = -1
                Me.txtCuentaHaber.Text = String.Empty
                Exit Sub
            Else
                oeCta = Me.cboCuentaHaber.Items(Me.cboCuentaHaber.SelectedIndex).ListObject
                Me.txtCuentaHaber.Text = oeCta.Nombre
            End If
        End If
    End Sub

    Private Sub grid_Servicios_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_Servicios.DoubleClick
        If grid_Servicios.Rows.Count > 0 Then Editar()
    End Sub

#End Region

#Region "Procedimientos y Funciones"

    Private Function GuardarServicio() As Boolean
        Try
            oeServicio.ListaServicioCuentaContable = Me.grServCtaCtble.DataSource
            oeServicio.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olServicio.Guardar(oeServicio) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcServicio, 2)
                Consultar(True)
                grid_Servicios.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function
    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
        If excepcion.Contains("precio") Then
            ndPrecio.Focus()
        End If
        If excepcion.Contains("categoria") Then
            cmbCategoriaServicio.Focus()
        End If
    End Sub
    Public Sub LlenaCombos()
        oeCategoriaServicio.Activo = True
        LlenarComboMaestro(cmbCategoriaServicio, olCategoriaServicio.Listar(oeCategoriaServicio), -1)
        ComboCuenta()
        ComboItemGasto()
    End Sub

    Private Sub ComboItemGasto()
        With cboItemGasto
            Dim oeItemGasto As New e_ItemGasto
            Dim leItemGasto As New List(Of e_ItemGasto)
            Dim olItemGasto As New l_ItemGasto
            oeItemGasto.TipoOperacion = "W"
            oeItemGasto.Activo = True
            oeItemGasto.Ejercicio = CInt(Date.Now.Year)
            leItemGasto.AddRange(olItemGasto.Listar(oeItemGasto))
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = leItemGasto
        End With
    End Sub

    Private Sub Inicializar()
        LlenaCombos()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtDescripcion.Text = String.Empty
        txtCuentaDebe.Text = String.Empty
        txtCuentaHaber.Text = String.Empty
        Me.cboCuentaDebe.SelectedIndex = -1
        Me.cboCuentaHaber.SelectedIndex = -1
        Me.cboItemGasto.SelectedIndex = -1
        ServicioCuentaContable = New List(Of e_ServicioCuentaContable)
        ServicioCuentaContable.Clear()
        Me.grServCtaCtble.DataSource = ServicioCuentaContable
        grServCtaCtble.DataBind()
        verActivo.Checked = True
        AsociarMenu()
        If grServCtaCtble.Rows.Count > 0 Then
            cboItemGasto.Enabled = False
        Else
            cboItemGasto.Enabled = True
        End If
    End Sub

    Private Sub MostrarServicio()
        Try
            If grid_Servicios.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeServicio.Id = grid_Servicios.ActiveRow.Cells("Id").Value.ToString
                oeServicio = olServicio.Obtener(oeServicio)
                txtCodigo.Text = oeServicio.Codigo
                txtNombre.Text = oeServicio.Nombre
                txtDescripcion.Text = oeServicio.Descripcion
                ndPrecio.Value = oeServicio.Precio
                verActivo.Checked = oeServicio.Activo
                cmbCategoriaServicio.Value = oeServicio.IdCategoriaServicio
                Me.cboItemGasto.Value = oeServicio.IdItemGasto

                oeServicioCuentaContable = New e_ServicioCuentaContable
                oeServicioCuentaContable.TipoOperacion = "L"
                oeServicioCuentaContable.IdServicio = oeServicio.Id
                oeServicioCuentaContable.Activo = True
                grServCtaCtble.DataSource = olServicioCuentaContable.Listar(oeServicioCuentaContable)

                MostrarTabs(1, tcServicio, 1)
                MyBase.Editar()
                'If grServCtaCtble.Rows.Count > 0 Then
                '    cboItemGasto.Enabled = False
                '    cboItemGasto.SelectedIndex = -1
                'Else
                '    cboItemGasto.Enabled = True
                'End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeServicio = New e_Servicio
            With grid_Servicios
                oeServicio.Activo = Activo
                .DataSource = olServicio.Listar(oeServicio)

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
                agrListaServicios.Text = "Total Servicios: " & .Rows.Count.ToString
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_Servicios.Focus()
    End Sub

    Private Sub ComboCuenta()
        Try
            Dim oeCuentaCtable As New e_CuentaContable
            Dim leCuentaCtable As New List(Of e_CuentaContable)
            Dim olCuentaContable As New l_CuentaContable
            oeCuentaCtable.Activo = True
            oeCuentaCtable.Movimiento = 1
            oeCuentaCtable.Ejercicio = Año.Año
            leCuentaCtable.AddRange(olCuentaContable.Listar(oeCuentaCtable))
            cboCuentaDebe.SelectedIndex = -1
            cboCuentaHaber.SelectedIndex = -1
            cboCuentaDebe.DataSource = Nothing
            cboCuentaHaber.DataSource = Nothing
            txtCuentaDebe.Text = ""
            txtCuentaHaber.Text = ""
            With Me.cboCuentaDebe
                .ValueMember = "Id"
                .DisplayMember = "Cuenta"
                .DataSource = leCuentaCtable
            End With
            Me.cboCuentaHaber.ValueMember = "Id"
            Me.cboCuentaHaber.DisplayMember = "Cuenta"
            Me.cboCuentaHaber.DataSource = leCuentaCtable
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btn_AddTipoCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddTipoCompra.Click
        AgregarCuentaContable()
        'If grServCtaCtble.Rows.Count > 0 Then
        '    cboItemGasto.Enabled = False
        '    cboItemGasto.SelectedIndex = -1
        'Else
        '    cboItemGasto.Enabled = True
        'End If

    End Sub

    Private Function ValidarCuenta() As Boolean
        Try
            'ValidarCombo(Me.cboCuentaDebe, "Cuenta Debe")
            Return 1
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Function

    Private Sub AgregarCuentaContable()
        If Not ValidarEjercicio(grServCtaCtble, Me.Año) Then
            Exit Sub
        Else
            If Not ValidarCuenta() Then
                Exit Sub
            Else
                oeServicio.ListaServicioCuentaContable = Me.grServCtaCtble.DataSource
                oeServicioCuentaContable.Id = ""
                oeServicioCuentaContable.IdServicio = ""
                oeServicioCuentaContable.Ejercicio = Año.Año
                oeServicioCuentaContable.IdCuentaContableDebe = Me.cboCuentaDebe.Value
                oeServicioCuentaContable.IdCuentaContableHaber = Me.cboCuentaHaber.Value
                oeServicioCuentaContable.CuentaDebe = Me.cboCuentaDebe.Text
                oeServicioCuentaContable.CuentaHaber = Me.cboCuentaHaber.Text
                oeServicioCuentaContable.Activo = True
                oeServicioCuentaContable.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeServicio.ListaServicioCuentaContable.Add(oeServicioCuentaContable)
                grServCtaCtble.DataBind()
                oeServicioCuentaContable = New e_ServicioCuentaContable
            End If
        End If
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Servicio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub grid_Servicios_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Servicios"

    Private Sub AsociarMenu()
        grid_Servicios.ContextMenuStrip = MenuContextual1
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
        If grid_Servicios.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

    Private Sub Año_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Año.Load

    End Sub

    Private Sub Año_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Año.Validated
        ComboCuenta()
    End Sub
End Class
