Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Public Class frm_BolsaRuta
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_BolsaRuta = Nothing
    Private Shared Operacion As String
    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_BolsaRuta()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#Region "Declaración de variables"
    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeBolsaRuta As New e_BolsaRuta
    Dim olBolsaRuta As New l_BolsaRuta
    Dim olRuta As New l_Ruta
    Dim oeRuta As New e_Ruta
    Dim oeTipoVehiculo As New e_TipoVehiculo
    Dim olTipoVehiculo As New l_TipoVehiculo

    Dim _ingresando_datos As Boolean = False
    Dim Estado As String
#End Region

#Region "Botones"
    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griListaBolsaRuta.Rows.Count > 0 Then
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
        oeBolsaRuta.TipoOperacion = "I"
        MostrarTabs(1, tcBolsaRuta, 1)
        Inicializar()
        cboRuta.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
        oeBolsaRuta.Modificado = False
    End Sub

    Public Overrides Sub Editar()
        Try
            verActivo.Visible = True
            MostrarBolsaRuta()
            oeBolsaRuta.TipoOperacion = "A"
            cboRuta.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oeBolsaRuta.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarBolsaRuta() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcBolsaRuta, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeBolsaRuta.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarBolsaRuta() Then
                            MostrarTabs(0, tcBolsaRuta, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcBolsaRuta, 1)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcBolsaRuta, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                        'Exit Sub

                End Select
            Else
                MostrarTabs(0, tcBolsaRuta, 2)
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
            With griListaBolsaRuta
                If ValidarGrilla(griListaBolsaRuta, "Bolsa Ruta") Then
                    oeBolsaRuta.Id = .ActiveRow.Cells("ID").Value
                    oeBolsaRuta = olBolsaRuta.Obtener(oeBolsaRuta)
                    If oeBolsaRuta.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar los montos de la ruta: " & _
                                 .ActiveRow.Cells("Ruta").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeBolsaRuta.TipoOperacion = "E"
                            olBolsaRuta.Eliminar(oeBolsaRuta)
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
            If griListaBolsaRuta.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griListaBolsaRuta)

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

    Private Sub frm_BolsaRuta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing

    End Sub

    Private Sub frm_BolsaRuta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_BolsaRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tcBolsaRuta)
            griListaBolsaRuta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            griListaBolsaRuta.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            InicializaTiempo()
            LlenaCombos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub oeBolsaRuta_DatoCambiado() Handles oeBolsaRuta.DatoCambiado
        oeBolsaRuta.Modificado = True
    End Sub

    Private Sub LlenaCombos()
        Try
            oeRuta.TipoOperacion = ""
            oeRuta.Activo = True
            LlenarComboMaestro(cboRuta, olRuta.Listar(oeRuta), 0)
            oeTipoVehiculo.Carga = 1
            oeTipoVehiculo.Activo = True
            LlenarComboMaestro(cboTipoVehiculoTc, olTipoVehiculo.Listar(oeTipoVehiculo), 0)
            'LlenarCombo(cboRuta1, "Ruta", olRuta.Listar(oeRuta), 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaBolsaRuta_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaBolsaRuta.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub cboRuta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboRuta.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub cboRuta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRuta.ValueChanged
        ' TeclaPulsada(e)
        oeBolsaRuta.IdRuta = cboRuta.Value
    End Sub
    Private Sub cboTipoVehiculoTc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVehiculoTc.ValueChanged
        oeBolsaRuta.IdTipoVehiculo = cboTipoVehiculoTc.Value
    End Sub

    Private Sub cboTipoVehiculoTc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTipoVehiculoTc.KeyDown
        TeclaPulsada(e)
    End Sub
    Private Sub decMontoMinimo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles decMontoMinimo.ValueChanged
        oeBolsaRuta.MontoMinimo = decMontoMinimo.Value
    End Sub

    Private Sub decMontoMinimo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles decMontoMinimo.GotFocus
        decMontoMinimo.SelectAll()
    End Sub

    Private Sub decMontoMinimo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles decMontoMinimo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub decMontoNormal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles decMontoNormal.GotFocus
        decMontoNormal.SelectAll()

    End Sub

    Private Sub decMontoNormal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles decMontoNormal.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub decMontoNormal_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles decMontoNormal.ValueChanged
        oeBolsaRuta.MontoNormal = decMontoNormal.Value
    End Sub

    Private Sub decMontoMaximo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles decMontoMaximo.GotFocus
        decMontoMaximo.SelectAll()
    End Sub

    Private Sub decMontoMaximo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles decMontoMaximo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub decMontoMaximo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles decMontoMaximo.ValueChanged
        oeBolsaRuta.MontoMaximo = decMontoMaximo.Value
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeBolsaRuta.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griListaBolsaRuta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griListaBolsaRuta.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griListaBolsaRuta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griListaBolsaRuta.DoubleClick
        If griListaBolsaRuta.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griListaBolsaRuta_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaBolsaRuta.InitializeLayout
        agrBolsaRuta.Text = "Total de configuraciones de montos por rutas: " & e.Layout.Rows.Count & Estado
    End Sub
    Private Sub griListaBolsaRuta_InitializeLayout_1(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaBolsaRuta.InitializeLayout
        agrBolsaRuta.Text = "Total: " & e.Layout.Rows.Count
    End Sub

#End Region

#Region "Métodos"

    Private Function GuardarBolsaRuta() As Boolean
        Try
            oeBolsaRuta.Activo = verActivo.Checked
            If olBolsaRuta.Guardar(oeBolsaRuta) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcBolsaRuta, 2)
                Consultar(True)
                griListaBolsaRuta.Focus()
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Seleccione Ruta") Then
            cboRuta.Focus()
        End If
        If excepcion.Contains("Ingrese Monto Minimo") Then
            decMontoMinimo.Focus()
        End If
        If excepcion.Contains("Ingrese Monto Normal") Then
            decMontoNormal.Focus()
        End If
        If excepcion.Contains("Ingrese Monto Maximo") Then
            decMontoMaximo.Focus()
        End If
    End Sub

    Private Sub Inicializar()
        cboRuta.SelectedIndex = -1
        cboTipoVehiculoTc.SelectedIndex = -1
        decMontoMinimo.Value = Decimal.Zero
        decMontoNormal.Value = Decimal.Zero
        decMontoMaximo.Value = Decimal.Zero
        verActivo.Checked = True
        oeBolsaRuta.Usuario = gUsuarioSGI.Id
        AsociarMenu()
    End Sub

    Private Sub MostrarBolsaRuta()
        Try
            If griListaBolsaRuta.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeBolsaRuta.Id = griListaBolsaRuta.ActiveRow.Cells("Id").Value.ToString
                oeBolsaRuta = olBolsaRuta.Obtener(oeBolsaRuta)
                With oeBolsaRuta
                    cboRuta.Value = .IdRuta
                    cboTipoVehiculoTc.Value = .IdTipoVehiculo
                    decMontoMinimo.Value = .MontoMinimo
                    decMontoNormal.Value = .MontoNormal
                    decMontoMaximo.Text = .MontoMaximo
                    verActivo.Checked = .Activo
                End With
                MostrarTabs(1, tcBolsaRuta, 1)
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
            oeBolsaRuta = New e_BolsaRuta
            With griListaBolsaRuta
                Inicializar()
                oeBolsaRuta.Activo = Activo
                .DataSource = olBolsaRuta.Listar(oeBolsaRuta)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdRuta").Hidden = True
                .DisplayLayout.Bands(0).Columns("Usuario").Hidden = True

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
        griListaBolsaRuta.Focus()
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_BolsaRuta_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griListaBolsaRuta_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaBolsaRuta.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griListaBolsaRuta.ContextMenuStrip = MenuContextual1
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
        If griListaBolsaRuta.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class