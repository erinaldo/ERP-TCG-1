'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports ISL.Controles
Public Class frm_CuentaCorriente
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_CuentaCorriente = Nothing

    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_CuentaCorriente()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#Region "Declaración de variables"
    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim olCuentaCorriente As New l_CuentaCorriente
    'Dim lstTrabajador As New List(Of e_Trabajador) '
    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador
    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda
    Dim oeMotivoDocumento As New e_MotivoDocumento
    Dim olMotivoDocumento As New l_MotivoDocumento
    Dim oeViaje As New e_Viaje
    Dim olOperacion As New l_Operacion
    Dim _ingresando_datos As Boolean = False
    Dim _ingresando_datos_prestamo As Boolean = False
    Dim _monto As Decimal
    Dim _id As String = ""
    Dim Estado As String
    Dim oeSaldoCC As New e_SaldoCtaCorriente
    Dim olSaldoCC As New l_SaldoCtaCorriente

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar(True)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griListaCuentaCorriente.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            lblcodigo.Visible = False
            txtNumeroCuentaCorriente.Visible = False
            Inicializar()
            oeCuentaCorriente.TipoOperacion = "I"
            oeCuentaCorriente.IdEstado = "HABILITADA"
            MostrarTabs(1, ficCuentaCorriente, 1)
            cboTrabajador.Focus()
            oeCuentaCorriente.Tipo = 0
            Operacion = "Nuevo"
            opcTipo.Enabled = True
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            lblcodigo.Visible = True
            txtNumeroCuentaCorriente.Visible = True
            Inicializar()
            If MostrarCuentaCorriente() Then
                MostrarTabs(1, ficCuentaCorriente, 1)
                MyBase.Editar()
                oeCuentaCorriente.TipoOperacion = "A"
                cboTrabajador.Focus()
                Operacion = "Editar"
                opcTipo.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCuentaCorriente() Then
                MyBase.Guardar()
                MostrarTabs(0, ficCuentaCorriente, 2)
                Listar(True)
            Else
                MostrarTabs(1, ficCuentaCorriente, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarCuentaCorriente() Then
                        MostrarTabs(0, ficCuentaCorriente, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                    Else
                        _ingresando_datos = True
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficCuentaCorriente, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Case Windows.Forms.DialogResult.Cancel
                    _ingresando_datos = True
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            Dim oeCuentaCorriente As New e_CuentaCorriente

            With griListaCuentaCorriente
                If ValidarGrilla(griListaCuentaCorriente, "Cuenta Corriente") Then
                    If oeCuentaCorriente.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la Cuenta de : " & _
                                 .ActiveRow.Cells("Trabajador").Value.ToString & " ?", _
                                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeCuentaCorriente.Id = griListaCuentaCorriente.ActiveRow.Cells("Id").Value
                            oeCuentaCorriente.TipoOperacion = "E"
                            oeCuentaCorriente.Activo = False
                            olCuentaCorriente.Eliminar(oeCuentaCorriente)
                            Listar(_Activo)
                            Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griListaCuentaCorriente.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griListaCuentaCorriente)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Menus y Fichas"

    Public Sub r_Botonera(lb_Consultar As Boolean, lb_Nuevo As Boolean, lb_Editar As Boolean, _
                                       lb_Guardar As Boolean, lb_Eliminar As Boolean, lb_Cancelar As Boolean)
        o_Botonera.Consultar = lb_Consultar
        o_Botonera.Nuevo = lb_Nuevo
        o_Botonera.Editar = lb_Editar
        o_Botonera.Guardar = lb_Guardar
        o_Botonera.Eliminar = lb_Eliminar
        o_Botonera.Cancelar = lb_Cancelar
        Botones(o_Botonera)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CuentaCorriente_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_CuentaCorriente_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                MostrarTabs(0, ficCuentaCorriente)
                If _Activo Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_CuentaCorriente_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_CuentaCorriente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficCuentaCorriente)
        griListaCuentaCorriente.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griListaCuentaCorriente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
        LlenaCombos()
        r_Botonera(True, True, False, False, False, False)
    End Sub

    Private Sub LlenaCombos()
        Try
            LlenarCombo(cboTrabajador, "Nombre", TrabajadorPublic, -1)
            LlenarComboMaestro(cboMoneda, MonedaPublic, -1)
            LlenarComboMaestro(cboCliente, ClienteProveedorPublic, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griListaCuentaCorriente_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaCuentaCorriente.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub txtNumeroCuentaCorriente_GotFocus(sender As Object, e As System.EventArgs) Handles txtNumeroCuentaCorriente.GotFocus
        txtNumeroCuentaCorriente.SelectAll()
    End Sub

    Private Sub txtNumeroCuentaCorriente_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNumeroCuentaCorriente.KeyDown
        TeclaPulsada(e)
        oeCuentaCorriente.Modificado = True
    End Sub

    Private Sub txtNumeroCuentaCorriente_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtNumeroCuentaCorriente.ValueChanged
        txtNumeroCuentaCorriente.Text = LTrim(txtNumeroCuentaCorriente.Text)
        oeCuentaCorriente.Codigo = txtNumeroCuentaCorriente.Text.Trim
    End Sub

    Private Sub cboTrabajador_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cboTrabajador.KeyDown
        TeclaPulsada(e)
        oeCuentaCorriente.Modificado = True
    End Sub

    Private Sub cboMoneda_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cboMoneda.KeyDown
        TeclaPulsada(e)
        oeCuentaCorriente.Modificado = True
    End Sub

    Private Sub cboMoneda_ValueChanged(sender As Object, e As System.EventArgs) Handles cboMoneda.ValueChanged
        ' TeclaPulsada(e)
        oeCuentaCorriente.Modificado = True
        oeCuentaCorriente.IdMoneda = cboMoneda.Value
    End Sub

    Private Sub decSaldo_ValueChanged(sender As Object, e As System.EventArgs) Handles decSaldo.ValueChanged
        oeCuentaCorriente.Saldo = decSaldo.Value
    End Sub

    Private Sub decSaldo_GotFocus(sender As Object, e As System.EventArgs) Handles decSaldo.GotFocus
        decSaldo.SelectAll()
    End Sub

    Private Sub decSaldo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles decSaldo.KeyDown
        TeclaPulsada(e)
        oeCuentaCorriente.Modificado = True
    End Sub

    Private Sub txtglosa_GotFocus(sender As Object, e As System.EventArgs) Handles txtGlosa.GotFocus
        txtGlosa.SelectAll()
    End Sub

    Private Sub txtglosa_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtGlosa.KeyDown
        TeclaPulsada(e)
        oeCuentaCorriente.Modificado = True
    End Sub

    Private Sub txtglosa_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtGlosa.ValueChanged
        txtGlosa.Text = LTrim(txtGlosa.Text)
        oeCuentaCorriente.Glosa = txtGlosa.Text.Trim
    End Sub

    Private Sub griListaCuentaCorriente_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles griListaCuentaCorriente.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griListaCuentaCorriente_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griListaCuentaCorriente.DoubleClick
        If griListaCuentaCorriente.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griListaCuentaCorriente_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaCuentaCorriente.InitializeLayout
        agrTotalCuentaCorriente.Text = "Total de Cuentas Corriente: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub NuevoContext()
        If MenuContextual1.SourceControl Is griListaCuentaCorriente Then
            Nuevo()
        End If
    End Sub

    Private Sub EliminarContext()
        If MenuContextual1.SourceControl Is griListaCuentaCorriente Then
            Eliminar()
        End If
    End Sub

    Private Sub opcTipo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles opcTipo.ValueChanged
        oeCuentaCorriente.Tipo = opcTipo.CheckedIndex
        If oeCuentaCorriente.Tipo = 3 Then
            cboCliente.Enabled = True
            cboTrabajador.Enabled = False
            cboTrabajador.Text = ""
        Else
            cboCliente.Enabled = False
            cboCliente.Text = ""
            cboTrabajador.Enabled = True
        End If
    End Sub

#End Region

#Region "Métodos"

    Private Function GuardarCuentaCorriente() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With oeCuentaCorriente
                If .Tipo = 3 Then
                    .IdTrabajador = cboCliente.Value
                Else
                    .IdTrabajador = cboTrabajador.Value
                End If
                .TotalCargo = decTotalCargo.Value
                .TotalAbono = decTotalAbono.Value
                .Ejercicio = decEjercicio.Value
            End With
            oeCuentaCorriente.PrefijoID = gs_PrefijoIdSucursal '@0001
            olCuentaCorriente.Guardar(oeCuentaCorriente)
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
            Operacion = "Inicializa"
            If griListaCuentaCorriente.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Sub Inicializar()
        txtNumeroCuentaCorriente.Text = String.Empty
        cboTrabajador.SelectedIndex = -1
        cboMoneda.SelectedIndex = -1
        decSaldo.Value = 0
        txtGlosa.Text = ""
        decEjercicio.Value = 2013
        decTotalCargo.Value = 0
        decTotalAbono.Value = 0
        opcTipo.CheckedIndex = 0
        oeCuentaCorriente = New e_CuentaCorriente
        oeCuentaCorriente.Usuario = gUsuarioSGI.Id
    End Sub

    Private Function MostrarCuentaCorriente() As Boolean
        Try
            If griListaCuentaCorriente.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeCuentaCorriente = New e_CuentaCorriente
                oeCuentaCorriente.Id = griListaCuentaCorriente.ActiveRow.Cells("Id").Value.ToString
                oeCuentaCorriente = olCuentaCorriente.Obtener(oeCuentaCorriente)
                With oeCuentaCorriente
                    txtNumeroCuentaCorriente.Text = .Codigo
                    opcTipo.CheckedIndex = .Tipo
                    If .Tipo = 3 Then
                        cboCliente.Value = .IdTrabajador
                    Else
                        cboTrabajador.Value = .IdTrabajador
                    End If
                    cboMoneda.Value = .IdMoneda
                    decSaldo.Value = .Saldo
                    txtGlosa.Text = .Glosa
                    decTotalCargo.Value = .TotalCargo
                    decTotalAbono.Value = .TotalAbono
                    decEjercicio.Value = .Ejercicio
                End With
                If oeCuentaCorriente.Tipo = 3 Then
                    oeSaldoCC = New e_SaldoCtaCorriente
                    With oeSaldoCC
                        .TipoOperacion = "1"
                        .IdCuentaCorriente = oeCuentaCorriente.Id
                        .TipoCuenta = oeCuentaCorriente.Tipo
                    End With
                    griSaldoCC.DataSource = olSaldoCC.Listar(oeSaldoCC)
                    CalcularTotales(griSaldoCC, "Cargo", "Abono")
                End If
            Else
                Throw New Exception("Seleccione Registro a editar")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Listar(Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Estado = " Activo"
            oeCuentaCorriente = New e_CuentaCorriente
            If verEjercicio.Checked Then
                oeCuentaCorriente.Ejercicio = AñoEjercicio.Año
            Else
                oeCuentaCorriente.Ejercicio = 0
            End If
            oeCuentaCorriente.Tipo = opcListaCC.CheckedIndex
            griListaCuentaCorriente.DataSource = olCuentaCorriente.Listar(oeCuentaCorriente)
            'Ubica el cursor el el primer registro de la grilla
            If griListaCuentaCorriente.Rows.Count > 0 Then
                griListaCuentaCorriente.Focus()
                griListaCuentaCorriente.Rows.Item(0).Selected = True
            End If

            CalcularTotales(griListaCuentaCorriente, "Saldo", "TotalCargo", "TotalAbono")
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Menú contextual del maestro Cuenta Corriente"

    Private Sub AsociarMenu()
        griListaCuentaCorriente.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griListaCuentaCorriente.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class