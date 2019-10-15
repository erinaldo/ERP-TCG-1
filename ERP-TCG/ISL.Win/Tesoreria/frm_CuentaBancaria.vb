'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Public Class frm_CuentaBancaria
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Shared Instancia As frm_CuentaBancaria = Nothing
    Private Shared Operacion As String
    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_CuentaBancaria()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#Region "Declaración de variables"
    Dim oeCuentaBancaria As New e_CuentaBancaria
    Dim olCuentaBancaria As New l_CuentaBancaria
    Dim olBanco As New l_Banco
    Dim oeBanco As New e_Banco
    Dim olMoneda As New l_Moneda
    Dim oeMoneda As New e_Moneda
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String

#End Region

#Region "Botones"
    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griListaCuentaBancaria.Rows.Count > 0 Then
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
        MostrarTabs(1, tcCuentaBancaria, 1)
        Inicializar()
        oeCuentaBancaria.TipoOperacion = "I"
        cboBanco.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        verActivo.Visible = True
        MostrarCuentaBancaria()
        oeCuentaBancaria.TipoOperacion = "A"
        cboBanco.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCuentaBancaria() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcCuentaBancaria, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCuentaBancaria.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarCuentaBancaria() Then
                            MostrarTabs(0, tcCuentaBancaria, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcCuentaBancaria, 1)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcCuentaBancaria, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                        'Exit Sub

                End Select
            Else
                MostrarTabs(0, tcCuentaBancaria, 2)
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
            With griListaCuentaBancaria
                If ValidarGrilla(griListaCuentaBancaria, "Cuenta Bancaria") Then
                    oeCuentaBancaria.Id = .ActiveRow.Cells("ID").Value
                    oeCuentaBancaria = olCuentaBancaria.Obtener(oeCuentaBancaria)
                    If oeCuentaBancaria.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la cuenta bancaria: " & _
                                 .ActiveRow.Cells("NumeroCuenta").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeCuentaBancaria.TipoOperacion = "E"
                            olCuentaBancaria.Eliminar(oeCuentaBancaria)
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
            If griListaCuentaBancaria.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griListaCuentaBancaria)

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

    Private Sub frm_CuentaBancaria_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                Tiempo1.Enabled = False
                MostrarTabs(0, tcCuentaBancaria)
                griListaCuentaBancaria.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
                griListaCuentaBancaria.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
                InicializaTiempo()
                LlenaCombos()

            Case "Ayuda"

        End Select
    End Sub

    Private Sub frm_CuentaBancaria_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing

    End Sub

    Private Sub frm_CuentaBancaria_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    'Private Sub frm_Banco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
    '    Tiempo1.Enabled = False
    '    MostrarTabs(0, tcCuentaBancaria)
    '    griListaCuentaBancaria.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
    '    griListaCuentaBancaria.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
    '    InicializaTiempo()
    '    LlenaCombos()

    'End Sub

    Private Sub LlenaCombos()
        'oeBanco.TipoOperacion = ""
        'oeBanco.Activo = True
        'LlenarComboMaestro(cboBanco, olBanco.Listar(oeBanco), -1)
        Dim oeEmpresa As New e_Empresa
        Dim olEmpresa As New l_Empresa
        oeEmpresa.IdTipoEmpresa = "1CH000000003"
        LlenarComboMaestro(cboBanco, olEmpresa.Listar(oeEmpresa), -1)
        LlenarComboMaestro(cboMoneda, olMoneda.Listar(oeMoneda), -1)
    End Sub

    Private Sub griListaCuentaBancaria_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaCuentaBancaria.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaCuentaBancaria_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaCuentaBancaria.DoubleClick
        Editar()
    End Sub

    Private Sub cboBanco_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBanco.GotFocus
        ' cboBanco.SelectAll()
    End Sub

    Private Sub cboBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBanco.KeyDown
        TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub cboBanco_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBanco.ValueChanged
        ' TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
        oeCuentaBancaria.IdBanco = cboBanco.Value
        oeCuentaBancaria.NombreBanco = cboBanco.Text
    End Sub

    Private Sub txtNumeroCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroCuenta.ValueChanged
        txtNumeroCuenta.Text = LTrim(txtNumeroCuenta.Text.ToString)
        oeCuentaBancaria.NumeroCuenta = txtNumeroCuenta.Text.Trim
    End Sub

    Private Sub txtNumeroCuenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroCuenta.GotFocus
        txtNumeroCuenta.SelectAll()
    End Sub

    Private Sub txtNumeroCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumeroCuenta.KeyDown
        'TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub cboMoneda_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMoneda.GotFocus
        'cboMoneda.SelectAll()
    End Sub

    Private Sub cboMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMoneda.KeyDown
        TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        oeCuentaBancaria.Modificado = True
        oeCuentaBancaria.IdMoneda = cboMoneda.Value
    End Sub

    Private Sub DecSaldoInicial_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DecSaldoInicial.GotFocus
        DecSaldoInicial.SelectAll()
    End Sub

    Private Sub DecSaldoInicial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DecSaldoInicial.KeyDown
        TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub DecSaldoInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecSaldoInicial.ValueChanged
        oeCuentaBancaria.SaldoInicial = DecSaldoInicial.Value
    End Sub

    Private Sub txtContacto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContacto.GotFocus
        txtContacto.SelectAll()
    End Sub

    Private Sub txtContacto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContacto.KeyDown
        TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub txtContacto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContacto.ValueChanged
        txtContacto.Text = LTrim(txtContacto.Text)
        oeCuentaBancaria.Contacto = txtContacto.Text
    End Sub

    Private Sub txtContactoTelefono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactoTelefono.GotFocus
        txtContactoTelefono.SelectAll()
    End Sub

    Private Sub txtContactoTelefono_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContactoTelefono.KeyDown
        TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub txtContactoTelefono_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactoTelefono.ValueChanged
        txtContactoTelefono.Text = txtContactoTelefono.Text.Trim
        oeCuentaBancaria.ContactoTelefono = txtContactoTelefono.Text
    End Sub
    Private Sub decTasaActiva_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles decTasaActiva.ValueChanged
        oeCuentaBancaria.TasaActiva = decTasaActiva.Value
    End Sub
    Private Sub decTasaActiva_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles decTasaActiva.GotFocus
        decTasaActiva.SelectAll()
    End Sub

    Private Sub decTasaActiva_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles decTasaActiva.KeyDown
        TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub decTasaPasiva_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles decTasaPasiva.GotFocus
        decTasaPasiva.SelectAll()

    End Sub

    Private Sub decTasaPasiva_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles decTasaPasiva.KeyDown
        TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub decTasaPasiva_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles decTasaPasiva.ValueChanged
        oeCuentaBancaria.TasaPasiva = decTasaPasiva.Value
    End Sub

    Private Sub decLineaCredito_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles decLineaCredito.GotFocus
        decLineaCredito.SelectAll()
    End Sub

    Private Sub decLineaCredito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles decLineaCredito.KeyDown
        TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub decLineaCredito_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles decLineaCredito.ValueChanged
        oeCuentaBancaria.LineaCredito = decLineaCredito.Value
    End Sub

    Private Sub entNumeroCorrelativo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles entNumeroCorrelativo.GotFocus
        entNumeroCorrelativo.SelectAll()
    End Sub

    Private Sub entNumeroCorrelativo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles entNumeroCorrelativo.KeyDown
        TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub entNumeroCorrelativo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles entNumeroCorrelativo.ValueChanged
        oeCuentaBancaria.NumeroCorrelativo = entNumeroCorrelativo.Value
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeCuentaBancaria.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeCuentaBancaria.Modificado = True
    End Sub

    Private Sub griListaCuentaBancaria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griListaCuentaBancaria.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griListaCuentaBancaria_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaCuentaBancaria.InitializeLayout
        agrTotalCuentaBancaria.Text = "Total de cuentas bancarias: " & e.Layout.Rows.Count & Estado
    End Sub

#End Region

#Region "Métodos"

    Private Function GuardarCuentaBancaria() As Boolean
        Try
            oeCuentaBancaria.Usuario = gUsuarioSGI.Id
            oeCuentaBancaria.IdCuentaContable = 1
            oeCuentaBancaria.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olCuentaBancaria.Guardar(oeCuentaBancaria) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, tcCuentaBancaria, 2)
            Consultar(True)
            griListaCuentaBancaria.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Seleccione Banco") Then
            cboBanco.Focus()
        End If
        If excepcion.Contains("Ingrese numero de cuenta") Then
            txtNumeroCuenta.Focus()
        End If
        If excepcion.Contains("Seleccione moneda") Then
            cboMoneda.Focus()
        End If
        If excepcion.Contains("Ingrese Saldo Inicial") Then
            DecSaldoInicial.Focus()
        End If

        If excepcion.Contains("Ingrese contacto") Then
            txtContacto.Focus()
        End If
        If excepcion.Contains("Ingrese tasa activa") Then
            decTasaActiva.Focus()
        End If
        If excepcion.Contains("Ingrese tasa pasiva") Then
            decTasaPasiva.Focus()
        End If
        If excepcion.Contains("Ingrese linea de credito") Then
            decLineaCredito.Focus()
        End If
    End Sub

    Private Sub Inicializar()
        oeCuentaBancaria = New e_CuentaBancaria
        cboBanco.SelectedIndex = -1
        txtNumeroCuenta.Text = String.Empty
        cboMoneda.SelectedIndex = -1
        DecSaldoInicial.Value = Decimal.Zero
        txtContacto.Text = String.Empty
        txtContactoTelefono.Text = String.Empty
        decTasaActiva.Value = Decimal.Zero
        decTasaPasiva.Value = Decimal.Zero
        decLineaCredito.Value = Decimal.Zero
        entNumeroCorrelativo.Value = 0
        verActivo.Checked = True
        AsociarMenu()
    End Sub

    Private Sub MostrarCuentaBancaria()
        Try
            If griListaCuentaBancaria.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                verActivo.Visible = True
                oeCuentaBancaria.Id = griListaCuentaBancaria.ActiveRow.Cells("Id").Value.ToString
                oeCuentaBancaria.TipoOperacion = ""
                oeCuentaBancaria = olCuentaBancaria.Obtener(oeCuentaBancaria)

                With oeCuentaBancaria
                    cboBanco.Value = .IdBanco
                    txtNumeroCuenta.Text = .NumeroCuenta
                    cboMoneda.Value = .IdMoneda
                    DecSaldoInicial.Value = .SaldoInicial
                    txtContacto.Text = .Contacto
                    txtContactoTelefono.Text = .ContactoTelefono
                    decTasaActiva.Value = .TasaActiva
                    decTasaPasiva.Value = .TasaPasiva
                    decLineaCredito.Value = .LineaCredito
                    entNumeroCorrelativo.Value = .NumeroCorrelativo
                    verActivo.Checked = .Activo
                End With
                MostrarTabs(1, tcCuentaBancaria, 1)
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
            oeCuentaBancaria = New e_CuentaBancaria
            With griListaCuentaBancaria
                oeCuentaBancaria.Activo = Activo
                .DataSource = olCuentaBancaria.Listar(oeCuentaBancaria)
                .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Idbanco").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMoneda").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCuentaContable").Hidden = True
                .DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("BancoCuenta").Hidden = True

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griListaCuentaBancaria.Focus()
    End Sub

    Public Function InformacionCuentaBancaria(ByVal IdCuentaBancaria As String) As Boolean
        Operacion = "Ayuda"
        MostrarTabs(1, tcCuentaBancaria, 1)
        Try
            LlenaCombos()
            Inicializar()
            oeCuentaBancaria.Id = IdCuentaBancaria
            oeCuentaBancaria = olCuentaBancaria.Obtener(oeCuentaBancaria)
            cboBanco.ReadOnly = True
            txtNumeroCuenta.ReadOnly = True
            cboMoneda.ReadOnly = True
            DecSaldoInicial.ReadOnly = True
            txtContacto.ReadOnly = True
            txtContactoTelefono.ReadOnly = True
            decTasaActiva.ReadOnly = True
            decTasaPasiva.ReadOnly = True
            decLineaCredito.ReadOnly = True
            entNumeroCorrelativo.ReadOnly = True

            If oeCuentaBancaria.Activo Then
                With oeCuentaBancaria
                    cboBanco.Value = .IdBanco
                    txtNumeroCuenta.Text = .NumeroCuenta
                    cboMoneda.Value = .IdMoneda
                    DecSaldoInicial.Value = .SaldoInicial
                    txtContacto.Text = .Contacto
                    txtContactoTelefono.Text = .ContactoTelefono
                    decTasaActiva.Value = .TasaActiva
                    decTasaPasiva.Value = .TasaPasiva
                    decLineaCredito.Value = .LineaCredito
                    entNumeroCorrelativo.Value = .NumeroCorrelativo
                    verActivo.Checked = .Activo
                End With
                'MostrarTabs(1, tcCuentaBancaria, 1)
            Else
                Throw New Exception(Me.Text & ": El Registro se encuentra eliminado, no se puede editar")
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_CuentaBancaria_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griListaCuentaBancaria_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaCuentaBancaria.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro Cuenta Bancaria"

    Private Sub AsociarMenu()
        griListaCuentaBancaria.ContextMenuStrip = MenuContextual1
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
        If griListaCuentaBancaria.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

    Private Sub frm_CuentaBancaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
    End Sub
End Class