'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ChequeContable
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_ChequeContable = Nothing
    Private Shared Operacion As String
    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_ChequeContable()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#Region "Declaración de variables"
    Dim oeChequeContable As New e_ChequeContable
    Dim olChequeContable As New l_ChequeContable
    Dim oeBanco As New e_Banco
    Dim olBanco As New l_Banco
    Dim oeCuentaBancaria As New e_CuentaBancaria
    Dim olCuentaBancaria As New l_CuentaBancaria
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String

#End Region

#Region "Botones"
    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griListaChequeContable.Rows.Count > 0 Then
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
        oeChequeContable.TipoOperacion = "I"
        MostrarTabs(1, tcChequeContable, 1)
        Inicializar()
        cboBanco.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        verActivo.Visible = True
        MostrarChequeContable()
        oeChequeContable.TipoOperacion = "A"
        cboBanco.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarChequeContable() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcChequeContable, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeChequeContable.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarChequeContable() Then
                            MostrarTabs(0, tcChequeContable, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcChequeContable, 1)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcChequeContable, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                        'Exit Sub

                End Select
            Else
                MostrarTabs(0, tcChequeContable, 2)
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
            With griListaChequeContable
                If ValidarGrilla(griListaChequeContable, "Cheque Contable") Then
                    oeChequeContable.Id = .ActiveRow.Cells("ID").Value
                    oeChequeContable = olChequeContable.Obtener(oeChequeContable)
                    If oeChequeContable.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar este cheque contable: " & _
                                 .ActiveRow.Cells("NumeroCuenta").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeChequeContable.TipoOperacion = "E"
                            olChequeContable.Eliminar(oeChequeContable)
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
            If griListaChequeContable.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griListaChequeContable)

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

    Private Sub frm_ChequeContable_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing

    End Sub

    Private Sub frm_ChequeContable_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_ChequeContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, tcChequeContable)
        griListaChequeContable.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griListaChequeContable.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
        LlenaCombos()
    End Sub

    Private Sub LlenaCombos()
        oeBanco.TipoOperacion = ""
        oeBanco.Activo = True
        LlenarComboMaestro(cboBanco, olBanco.Listar(oeBanco), -1)
    End Sub

    Private Sub cboBanco_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBanco.GotFocus
        ' cboBanco.SelectAll()
    End Sub

    Private Sub cboBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBanco.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub cboBanco_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBanco.LostFocus
        oeCuentaBancaria.IdBanco = cboBanco.Value
    End Sub

    Private Sub cboBanco_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBanco.ValueChanged
        oeCuentaBancaria.IdBanco = cboBanco.Value
        oeCuentaBancaria.Activo = True
        LlenarCombo(cboCuentaContable, "NumeroCuenta", olCuentaBancaria.Listar(oeCuentaBancaria), -1)
        oeChequeContable.IdBanco = cboBanco.Value
    End Sub

    Private Sub cboCuentaContable_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCuentaContable.GotFocus
        ' cboCuentaContable.SelectAll()
    End Sub

    Private Sub cboCuentaContable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCuentaContable.KeyDown
        TeclaPulsada(e)
        oeChequeContable.Modificado = True
    End Sub

    Private Sub cboCuentaContable_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCuentaContable.ValueChanged
        oeChequeContable.Modificado = True
        oeChequeContable.IdCuentaBancaria = cboCuentaContable.Value
    End Sub

    Private Sub txtNumeroChequera_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroChequera.GotFocus
        txtNumeroChequera.SelectAll()
    End Sub

    Private Sub txtNumeroChequera_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumeroChequera.KeyDown
        TeclaPulsada(e)
        oeChequeContable.Modificado = True
    End Sub

    Private Sub txtNumeroChequera_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroChequera.ValueChanged
        txtNumeroChequera.Text = LTrim(txtNumeroChequera.Text)
        oeChequeContable.NumeroChequera = txtNumeroChequera.Text.Trim
        oeChequeContable.Modificado = True
    End Sub

    Private Sub FecFecha_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecFecha.GotFocus
        FecFecha.SelectAll()
    End Sub

    Private Sub FecFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FecFecha.KeyDown
        TeclaPulsada(e)
        oeChequeContable.Fecha = FecFecha.Value
        oeChequeContable.Modificado = True
    End Sub

    Private Sub FecFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecFecha.ValueChanged
        oeChequeContable.Fecha = FecFecha.Value
        oeChequeContable.Modificado = True
    End Sub

    Private Sub numNumeroInicial_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles numNumeroInicial.GotFocus
        numNumeroInicial.SelectAll()
    End Sub

    Private Sub numNumeroInicial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numNumeroInicial.KeyDown
        TeclaPulsada(e)
        oeChequeContable.Modificado = True
    End Sub

    Private Sub numNumeroInicial_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numNumeroInicial.ValueChanged
        oeChequeContable.NumeroInicial = numNumeroInicial.Value
        oeChequeContable.Modificado = True
    End Sub

    Private Sub numNumeroFinal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles numNumeroFinal.GotFocus
        numNumeroFinal.SelectAll()
    End Sub

    Private Sub numNumeroFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numNumeroFinal.KeyDown
        TeclaPulsada(e)
        oeChequeContable.Modificado = True
    End Sub

    Private Sub numNumeroFinal_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numNumeroFinal.ValueChanged
        oeChequeContable.NumeroFinal = numNumeroFinal.Value
    End Sub

    Private Sub numNumeroEmitir_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles numNumeroEmitir.GotFocus
        numNumeroEmitir.SelectAll()
    End Sub

    Private Sub numNumeroEmitir_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numNumeroEmitir.KeyDown
        TeclaPulsada(e)
        oeChequeContable.Modificado = True
    End Sub

    Private Sub numNumeroEmitir_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numNumeroEmitir.ValueChanged
        oeChequeContable.NumeroEmitir = numNumeroEmitir.Value
    End Sub

    Private Sub griListaChequeContable_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaChequeContable.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub


    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeChequeContable.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeChequeContable.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeChequeContable.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeChequeContable.Modificado = True
    End Sub

    Private Sub griListaChequeContable_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaChequeContable.DoubleClick
        If griListaChequeContable.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griListaChequeContable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griListaChequeContable.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griListaChequeContable_InitializeLayout_1(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaChequeContable.InitializeLayout
        agrTotalChequeContable.Text = "Total Cheque Contable: " & e.Layout.Rows.Count & Estado
    End Sub
#End Region

#Region "Métodos"
    Private Function GuardarChequeContable() As Boolean
        Try
            oeChequeContable.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olChequeContable.Guardar(oeChequeContable) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcChequeContable, 2)
                Consultar(True)
                griListaChequeContable.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("banco") Then
            cboBanco.Focus()
        End If
        If excepcion.Contains("numerocuenta") Then
            cboCuentaContable.Focus()
        End If
        If excepcion.Contains("Ingrese Numero de Chequera") Then
            txtNumeroChequera.Focus()
        End If
        If excepcion.Contains("Ingrese Fecha") Then
            FecFecha.Focus()
        End If
        If excepcion.Contains("Ingrese Numero Inicial") Then
            numNumeroInicial.Focus()
        End If
        If excepcion.Contains("Ingrese Numero Final") Then
            FecFecha.Focus()
        End If
        If excepcion.Contains("Ingrese Numero a Emitir") Then
            numNumeroEmitir.Focus()
        End If

    End Sub

    Private Sub Inicializar()
        cboBanco.SelectedIndex = -1
        cboCuentaContable.SelectedIndex = -1
        txtNumeroChequera.Text = String.Empty
        FecFecha.Value = Date.Now
        numNumeroInicial.Value = Decimal.Zero
        numNumeroFinal.Value = Decimal.Zero
        numNumeroEmitir.Value = Decimal.Zero
        verActivo.Checked = True
        AsociarMenu()
    End Sub

    Private Sub MostrarChequeContable()
        Try
            If griListaChequeContable.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                oeChequeContable.Id = griListaChequeContable.ActiveRow.Cells("Id").Value.ToString
                oeChequeContable = olChequeContable.Obtener(oeChequeContable)
                cboBanco.Value = oeChequeContable.IdBanco
                cboCuentaContable.Value = oeChequeContable.IdCuentaBancaria
                txtNumeroChequera.Text = oeChequeContable.NumeroChequera
                FecFecha.Value = oeChequeContable.Fecha
                numNumeroInicial.Value = oeChequeContable.NumeroInicial
                numNumeroFinal.Value = oeChequeContable.NumeroFinal
                numNumeroEmitir.Value = oeChequeContable.NumeroEmitir
                verActivo.Checked = CBool(oeChequeContable.Activo)
                MostrarTabs(1, tcChequeContable, 1)
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
            oeChequeContable = New e_ChequeContable
            With griListaChequeContable
                oeChequeContable.Activo = Activo
                .DataSource = olChequeContable.Listar(oeChequeContable)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCuentaBancaria").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdBanco").Hidden = True
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
        griListaChequeContable.Focus()
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_ChequeContable_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griListaChequeContable_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaChequeContable.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro Cajas"

    Private Sub AsociarMenu()
        griListaChequeContable.ContextMenuStrip = MenuContextual1
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
        If griListaChequeContable.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class