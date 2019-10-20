'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Public Class frm_FlujoGasto
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_FlujoGasto = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_FlujoGasto()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim oeFlujoGasto As New e_FlujoCaja
    Dim olFlujoGasto As New l_FlujoCaja
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String
    Private Ejercicio As Integer = 0
    Private WithEvents oeCuentaFlujoCaja As New e_CuentaFlujoCaja
    Private olCuentaFlujoCaja As New l_CuentaFlujoCaja

    Dim ListaCuentaFlujoCaja As New List(Of e_CuentaFlujoCaja)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griListaFlujoGasto.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        verActivo.Visible = False
        oeFlujoGasto.TipoOperacion = "I"
        MostrarTabs(1, tcFlujoGasto, 1)
        Inicializar()
        'grCtaFlujoCaja.DataSource = ListaCuentaFlujoCaja
        txtCodigo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        verActivo.Visible = True
        Inicializar()
        MostrarTipoGasto()
        oeFlujoGasto.TipoOperacion = "A"
        'grCuentaFlujoCaja.DataSource = ListaCuentaFlujoCaja
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarFlujoGasto() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcFlujoGasto, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeFlujoGasto.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarFlujoGasto() Then
                            MostrarTabs(0, tcFlujoGasto, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcFlujoGasto, 1)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcFlujoGasto, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                        'Exit Sub

                End Select
            Else
                MostrarTabs(0, tcFlujoGasto, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
                'Exit Sub
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griListaFlujoGasto
                If ValidarGrilla(griListaFlujoGasto, "Flujo Gasto") Then
                    oeFlujoGasto.Id = .ActiveRow.Cells("ID").Value
                    oeFlujoGasto = olFlujoGasto.Obtener(oeFlujoGasto)
                    If oeFlujoGasto.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Flujo Gasto: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeFlujoGasto.TipoOperacion = "E"
                            olFlujoGasto.Eliminar(oeFlujoGasto)
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
            If tcFlujoGasto.SelectedTab.Index = 0 AndAlso griListaFlujoGasto.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If tcFlujoGasto.SelectedTab.Index = 0 Then Exportar_Excel(griListaFlujoGasto)

            If tcFlujoGasto.SelectedTab.Index = 1 AndAlso grCtaFlujoCaja.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If tcFlujoGasto.SelectedTab.Index = 1 Then Exportar_Excel(grCtaFlujoCaja)

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

    Private Sub frm_FlujoGasto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_FlujoGasto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_FlujoGasto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gf_AsignarEventoSeleccionarTexto(Me)
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        ComboCuenta()
        ComboItemGasto()
        grCtaFlujoCaja.DataSource = ListaCuentaFlujoCaja
        MostrarTabs(0, tcFlujoGasto)
        griListaFlujoGasto.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griListaFlujoGasto.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
    End Sub

    Private Sub griListaFlujoGasto_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub griListaFlujoGasto_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaFlujoGasto.DoubleClick
        If griListaFlujoGasto.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub cboCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuenta.ValueChanged
        oeCuentaFlujoCaja.IdCuentaContable = cboCuenta.Value
        Dim oeCta As New e_CuentaContable
        If Me.cboCuenta.SelectedIndex <> -1 Then
            oeCta = Me.cboCuenta.Items(cboCuenta.SelectedIndex).ListObject
            Me.txtCuenta.Text = oeCta.Nombre
        End If
    End Sub

    Private Sub cboItemGasto_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItemGasto.ValueChanged
        oeFlujoGasto.IdItemGasto = cboItemGasto.Value
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeFlujoGasto.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeFlujoGasto.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        'TeclaPulsada(e)
        oeFlujoGasto.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeFlujoGasto.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
        oeFlujoGasto.Modificado = True
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeFlujoGasto.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeFlujoGasto.Activo = verActivo.Checked
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        oeFlujoGasto.Modificado = True
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeFlujoGasto.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeFlujoGasto.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeFlujoGasto.Modificado = True
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeFlujoGasto.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        oeFlujoGasto.Modificado = True
    End Sub

    Private Sub griListaFlujoGasto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCuentaFlujoCaja.CheckedChanged
        UltraGroupBox1.Enabled = rbCuentaFlujoCaja.Checked
        Me.grCtaFlujoCaja.Visible = rbCuentaFlujoCaja.Checked
        Me.btnAgregarCg.Enabled = rbCuentaFlujoCaja.Checked
    End Sub

    Private Sub rbNroOrden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNroOrden.CheckedChanged
        UltraGroupBox2.Enabled = rbNroOrden.Checked
        UltraGroupBox1.Enabled = rbCuentaFlujoCaja.Checked
        Me.grCtaFlujoCaja.Visible = rbCuentaFlujoCaja.Checked
        Me.cboItemGasto.Focus()
        ListaCuentaFlujoCaja = New List(Of e_CuentaFlujoCaja)
        Me.grCtaFlujoCaja.DataSource = ListaCuentaFlujoCaja
        grCtaFlujoCaja.DataBind()
        Me.btnAgregarCg.Enabled = False
    End Sub

    Private Sub frm_FlujoGasto_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case _Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                MostrarTabs(0, tcFlujoGasto)
                'Consultar(True)
                InicializaTiempo()
            Case "Ayuda"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        End Select
    End Sub

#End Region

#Region "Métodos"
    Private Function GuardarFlujoGasto() As Boolean
        Try
            oeFlujoGasto.IndMovimiento = optMovimiento.CheckedIndex
            oeFlujoGasto.UsuarioCreacion = gUsuarioSGI.Id
            oeFlujoGasto.PrefijoID = gs_PrefijoIdSucursal '@0001
            If rbCuentaFlujoCaja.Checked Then
                oeFlujoGasto.ListaCuentaFlujoCaja = Me.grCtaFlujoCaja.DataSource
                oeFlujoGasto.IdItemGasto = ""
                olFlujoGasto.Guardar(oeFlujoGasto)
            Else
                olFlujoGasto.Guardar(oeFlujoGasto)
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
            MostrarTabs(0, tcFlujoGasto, 2)
            Consultar(True)
            griListaFlujoGasto.Focus()
            Return True
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
        Me.txtCuenta.Text = String.Empty
        verActivo.Checked = True
        Año1.Año = Date.Now.Year
        cboCuenta.SelectedIndex = -1
        cboItemGasto.SelectedIndex = -1
        ListaCuentaFlujoCaja = New List(Of e_CuentaFlujoCaja)
        ListaCuentaFlujoCaja.Clear()
        Me.grCtaFlujoCaja.DataSource = ListaCuentaFlujoCaja
        grCtaFlujoCaja.DataBind()
    End Sub

    Private Sub MostrarTipoGasto()
        Try
            If griListaFlujoGasto.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeFlujoGasto = New e_FlujoCaja
                verActivo.Visible = True
                oeFlujoGasto.Id = griListaFlujoGasto.ActiveRow.Cells("Id").Value.ToString
                oeFlujoGasto.TipoOperacion = "N"
                oeFlujoGasto = olFlujoGasto.Obtener(oeFlujoGasto)
                txtCodigo.Text = oeFlujoGasto.Codigo
                txtNombre.Text = oeFlujoGasto.Nombre
                txtAbreviatura.Text = oeFlujoGasto.Abreviatura
                optMovimiento.CheckedIndex = oeFlujoGasto.IndMovimiento
                verActivo.Checked = oeFlujoGasto.Activo
                oeFlujoGasto.TipoOperacion = "M"
                If olFlujoGasto.Buscar(oeFlujoGasto) Then
                    Me.UltraGroupBox1.Enabled = False
                    Me.UltraGroupBox2.Enabled = True
                    Me.cboItemGasto.Value = oeFlujoGasto.IdItemGasto
                    Me.rbCuentaFlujoCaja.Checked = False
                    Me.rbNroOrden.Checked = True
                    oeFlujoGasto.TipoOperacion = "A"
                Else
                    oeFlujoGasto.TipoOperacion = "A"
                    Me.UltraGroupBox1.Enabled = True
                    Me.rbCuentaFlujoCaja.Checked = True
                    Me.UltraGroupBox2.Enabled = False
                    oeCuentaFlujoCaja = New e_CuentaFlujoCaja
                    grCtaFlujoCaja.Visible = True
                    oeCuentaFlujoCaja.TipoOperacion = "L"
                    oeCuentaFlujoCaja.Activo = True
                    oeCuentaFlujoCaja.IdFlujoCaja = oeFlujoGasto.Id
                    oeCuentaFlujoCaja = olCuentaFlujoCaja.Obtener(oeCuentaFlujoCaja)
                    Me.cboCuenta.Value = oeCuentaFlujoCaja.IdCuentaContable
                    grCtaFlujoCaja.DataSource = olCuentaFlujoCaja.Listar(oeCuentaFlujoCaja)
                    oeCuentaFlujoCaja.TipoOperacion = "A"
                    'grCuentaFlujoCaja.DataBind()
                End If

                MostrarTabs(1, tcFlujoGasto, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            If Activo Then
                Estado = " Activo"
            Else
                Estado = " Inactivo"
            End If
            Me.Cursor = Cursors.WaitCursor
            oeFlujoGasto = New e_FlujoCaja
            With griListaFlujoGasto
                oeFlujoGasto.Activo = Activo
                .DataSource = olFlujoGasto.Listar(oeFlujoGasto)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoOperacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdItemGasto").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndMovimiento").Hidden = True
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
        griListaFlujoGasto.Focus()
    End Sub

    Private Sub ComboCuenta()
        Try
            With cboCuenta
                If Ejercicio <> Año1.Año Then
                    Dim oeCuentaCtable As New e_CuentaContable
                    Dim leCuentaCtable As New List(Of e_CuentaContable)
                    Dim olCuentaContable As New l_CuentaContable
                    oeCuentaCtable.Activo = True
                    oeCuentaCtable.Movimiento = 1
                    oeCuentaCtable.Ejercicio = Año1.Año
                    leCuentaCtable.AddRange(olCuentaContable.Listar(oeCuentaCtable))
                    .ValueMember = "Id"
                    .DisplayMember = "Cuenta"
                    .DataSource = leCuentaCtable
                    Ejercicio = Año1.Año
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboItemGasto()
        With cboItemGasto
            Dim oeItemGasto As New e_ItemGasto
            Dim leItemGasto As New List(Of e_ItemGasto)
            Dim olItemGasto As New l_ItemGasto
            oeItemGasto.TipoOperacion = "W"
            oeItemGasto.Activo = True
            oeItemGasto.Ejercicio = Año1.Año
            leItemGasto.AddRange(olItemGasto.Listar(oeItemGasto))
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = leItemGasto
            Ejercicio = Año1.Año
        End With
    End Sub

    Public Sub AgregarFlujoCaja()
        Try
            If Not ValidarEjercicio(Me.grCtaFlujoCaja, Año1) Then
                Exit Sub
            Else
                If Validar() Then
                    oeFlujoGasto.ListaCuentaFlujoCaja = grCtaFlujoCaja.DataSource
                    oeCuentaFlujoCaja.Id = ""
                    oeCuentaFlujoCaja.IdFlujoCaja = ""
                    oeCuentaFlujoCaja.TipoOperacion = "I"
                    oeCuentaFlujoCaja.Ejercicio = Año1.Año
                    oeCuentaFlujoCaja.Cuenta = cboCuenta.Text
                    oeCuentaFlujoCaja.Activo = True
                    oeFlujoGasto.ListaCuentaFlujoCaja.Add(oeCuentaFlujoCaja)
                    grCtaFlujoCaja.DataBind()
                    oeCuentaFlujoCaja = New e_CuentaFlujoCaja
                    oeCuentaFlujoCaja.Modificado = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Validar() As Boolean
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(txtNombre.Text, "Nombre")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtAbreviatura.Text, "Abreviatura")
            ValidarCombo(cboCuenta, "Cuenta")
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub btnAgregarCg_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCg.Click
        AgregarFlujoCaja()
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_FlujoGasto_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griListaFlujoGasto_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de flujo de gastos"

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Eliminar()
    End Sub

    Private Sub MenuContextual_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual.Opening
        MenuContextual.Items("InsertarToolStripMenuItem").Visible = True
        If griListaFlujoGasto.Selected.Rows.Count > 0 Then
            MenuContextual.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class
