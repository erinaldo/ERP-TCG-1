'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF


Public Class frm_ChequexCobrar
    Inherits frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ChequexCobrar = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ChequexCobrar()
        End If
        instancia.Activate()
        Return instancia
    End Function

    Enum EnumTipoCheque As Byte
        Todos = 2
        Cuentas = 0
        Fletes = 1
    End Enum

#Region "Declaracion de Variables"

    Dim WithEvents oeChequexCobrar As New e_ChequexCobrar
    Dim olChequexCobrar As New l_ChequexCobrar

    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim olCuentaCorriente As New l_CuentaCorriente

    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griChequexCobrar.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        MostrarTabs(1, ficChequexCobrar, 1)
        agrDatos.Height = 195
        Inicializar()
        oeChequexCobrar.TipoOperacion = "I"
        oeChequexCobrar.Fecha = Date.Now.Date
        oeChequexCobrar.Modificado = False
        'ChequeCtaCte()
        txtNroCheque.Focus()
        Operacion = "Nuevo"

        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        agrDatos.Height = 215
        oeChequexCobrar.TipoOperacion = "A"
        oeChequexCobrar.Modificado = False
        txtNroCheque.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficChequexCobrar, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeChequexCobrar.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficChequexCobrar, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficChequexCobrar, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficChequexCobrar, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficChequexCobrar, 2)
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
            With griChequexCobrar
                If ValidarGrilla(griChequexCobrar, "Cheque por Cobrar") Then
                    oeChequexCobrar.Id = .ActiveRow.Cells("ID").Value
                    oeChequexCobrar = olChequexCobrar.Obtener(oeChequexCobrar)
                    If Not oeChequexCobrar.Cobrado Then
                        If oeChequexCobrar.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Cheque: " & _
                                     .ActiveRow.Cells("NroCheque").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeChequexCobrar.TipoOperacion = "E"
                                olChequexCobrar.Eliminar(oeChequexCobrar)
                                Consultar(True)
                            End If
                        Else
                            Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                        End If
                    Else
                        Throw New Exception("El cheque Nº: " & oeChequexCobrar.NroCheque & ", esta Cobrado. No se puede Eliminar")
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
            If griChequexCobrar.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griChequexCobrar)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ChequexCobrar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub frm_ChequexCobrar_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ChequexCobrar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frm_ChequexCobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        colorCobrado.Color = Color.LightGreen
        etiCobrado.Appearance.BackColor = colorCobrado.Color
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        AsociarMenu()
        fecFechaCobro.Value = Date.Now
        LlenaCombosTipoCheque()
        MostrarTabs(0, ficChequexCobrar)
        Me.fecDesde.Value = Date.Now.AddDays(-7)
    End Sub

    Private Sub LlenaCombosTipoCheque()
        Dim Asociado As EnumTipoCheque = CType(2, EnumTipoCheque)
        cboTipoFlete.Items.Add(EnumTipoCheque.Todos)
        cboTipoFlete.Items.Add(EnumTipoCheque.Cuentas)
        cboTipoFlete.Items.Add(EnumTipoCheque.Fletes)
        cboTipoFlete.SelectedIndex = 0
    End Sub

    Private Sub oeChequexCobrar_DatoCambiado() Handles oeChequexCobrar.DatoCambiado
        oeChequexCobrar.Modificado = True
    End Sub

    Private Sub cboBanco_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBanco.ValueChanged
        If cboBanco.SelectedIndex > -1 Then oeChequexCobrar.IdBanco = cboBanco.Value
    End Sub

    Private Sub txtNroCheque_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroCheque.ValueChanged
        oeChequexCobrar.NroCheque = txtNroCheque.Text.Trim
    End Sub

    Private Sub cboTipoMoneda_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoMoneda.ValueChanged
        If cboTipoMoneda.SelectedIndex > -1 Then oeChequexCobrar.IdMoneda = cboTipoMoneda.Value
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeChequexCobrar.Activo = verActivo.Checked
    End Sub

    Private Sub verCobrar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verCobrar.CheckedChanged
        oeChequexCobrar.Cobrado = verCobrar.Checked
        cboBanco.ReadOnly = verCobrar.Checked
        txtNroCheque.ReadOnly = verCobrar.Checked
        fecFecha.ReadOnly = verCobrar.Checked
        cboTipoMoneda.ReadOnly = verCobrar.Checked
        numMonto.ReadOnly = verCobrar.Checked
        verActivo.Enabled = Not verCobrar.Checked
    End Sub

    Private Sub numMonto_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numMonto.ValueChanged
        oeChequexCobrar.Monto = numMonto.Value
        oeChequexCobrar.Saldo = numMonto.Value
    End Sub



    Private Sub cboTrabajador_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTrabajador.ValueChanged
        If cboTrabajador.SelectedIndex > -1 Then oeChequexCobrar.IdTrabajadorCobro = cboTrabajador.Value
    End Sub

    Private Sub colorCobrado_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorCobrado.ColorChanged
        etiCobrado.Appearance.BackColor = colorCobrado.Color
    End Sub

    Private Sub griChequexCobrar_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griChequexCobrar.DoubleClick
        If griChequexCobrar.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub verAsociacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verAsociacion.CheckedChanged
        If verAsociacion.Checked Then
            cboCuentaCorriente.Enabled = True
        Else
            cboCuentaCorriente.Enabled = False
        End If
    End Sub

    Private Sub cboCuentaCorriente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaCorriente.ValueChanged
        If cboCuentaCorriente.SelectedIndex > -1 Then oeChequexCobrar.IdCuentaCorriente = cboCuentaCorriente.Value
        If oeChequexCobrar.TipoOperacion = "A" Then cboCuentaCorriente_SelectionChangeCommitted(cboCuentaCorriente, e)
    End Sub

    Private Sub cboCuentaCorriente_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaCorriente.SelectionChangeCommitted
        oeCuentaCorriente = New e_CuentaCorriente
        With cboCuentaCorriente
            If .SelectedIndex > -1 Then
                Dim i As Integer = .SelectedIndex
                oeCuentaCorriente = .Items(i).ListObject
                agrCuentaTrabajador.Text = "     Asociado a la cuenta del trabajador" & " /" & oeCuentaCorriente.TipoCuenta

            End If
        End With
    End Sub
#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            With griChequexCobrar
                oeChequexCobrar = New e_ChequexCobrar
                oeChequexCobrar.TipoTransa = CInt(cboTipoFlete.Value)
                oeChequexCobrar.Activo = Activo
                oeChequexCobrar.Fecha = fecDesde.Value
                oeChequexCobrar.TipoOperacion = ""
                .DataSource = olChequexCobrar.Listar(oeChequexCobrar)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoTransa").Hidden = True



                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In .Rows
                    If Fila.Cells("Cobrado").Value Then Fila.Appearance.BackColor = colorCobrado.Color
                Next

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                    'CalcularTotales(griChequexCobrar, "Monto")
                End If

            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griChequexCobrar.Focus()
    End Sub

    Private Sub ChequeCtaCte()
        PermisoCtaCte()
    End Sub

    Private Sub PermisoCtaCte()
        Dim oeTrabSeg As New e_TrabajadorSeguridad
        Dim olTrabSeg As New l_TrabajadorSeguridad
        oeTrabSeg.IdTrabajador = gUsuarioSGI.IdTrabajador

        oeTrabSeg = olTrabSeg.Obtener(oeTrabSeg)
        If oeTrabSeg.IdTrabajador = "" Then
            Me.agrCuentaTrabajador.Visible = False
        Else
            Me.agrCuentaTrabajador.Visible = True
        End If
    End Sub

    Private Sub Inicializar()
        Try
            txtNroCheque.Text = String.Empty
            numMonto.Value = 0
            fecFecha.Value = Date.Now.Date
            fecFechaCobro.Value = Date.Now.Date
            Dim oeEmpresa As New e_Empresa
            Dim olEmpresa As New l_Empresa
            oeEmpresa.IdTipoEmpresa = "1CH000000003"
            LlenarCombo(cboBanco, "Nombre", olEmpresa.Listar(oeEmpresa), -1)
            Dim oeTipoMoneda As New e_Moneda
            Dim olTipoMoneda As New l_Moneda
            oeTipoMoneda.Activo = True
            LlenarCombo(cboTipoMoneda, "Nombre", olTipoMoneda.Listar(oeTipoMoneda), 0)

            oeCuentaCorriente.IdTrabajador = String.Empty
            oeCuentaCorriente.Id = String.Empty
            oeCuentaCorriente.Codigo = String.Empty
            LlenarCombo(cboCuentaCorriente, "Trabajador", olCuentaCorriente.Listar(oeCuentaCorriente), -1)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            If griChequexCobrar.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeChequexCobrar.Id = griChequexCobrar.ActiveRow.Cells("Id").Value.ToString
                oeChequexCobrar = olChequexCobrar.Obtener(oeChequexCobrar)
                cboBanco.Value = oeChequexCobrar.IdBanco
                txtNroCheque.Text = oeChequexCobrar.NroCheque
                cboTipoMoneda.Value = oeChequexCobrar.IdMoneda
                fecFecha.Value = oeChequexCobrar.Fecha
                numMonto.Value = oeChequexCobrar.Monto
                verActivo.Checked = oeChequexCobrar.Activo
                verCobrar.Checked = oeChequexCobrar.Cobrado
                verCobrar.Visible = True
                cboCuentaCorriente.Value = oeChequexCobrar.IdCuentaCorriente
                If verCobrar.Checked Then
                    fecFechaCobro.Value = oeChequexCobrar.FechaCobro
                    cboTrabajador.Value = oeChequexCobrar.IdTrabajadorCobro
                End If
                MostrarTabs(1, ficChequexCobrar, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeChequexCobrar.UsuarioCreacion = gUsuarioSGI.Id
            oeChequexCobrar.TipoTransa = 0
            oeChequexCobrar.Fecha = Me.fecFecha.Value
            oeChequexCobrar.FechaCobro = Me.fecFechaCobro.Value
            oeChequexCobrar.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olChequexCobrar.Guardar(oeChequexCobrar) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, ficChequexCobrar, 2)
                Consultar(_Activo)
                griChequexCobrar.Focus()
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)

    End Sub

    Private Sub TecladoTextos(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case (Keys.Escape)
                Cancelar()

            Case (Keys.Enter)
                SendKeys.Send("{TAB}")
        End Select

    End Sub

    Private Sub TecladoGrilla(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Insert
                Nuevo()
            Case Keys.Add
                Nuevo()

            Case Keys.Multiply
                Editar()

            Case Keys.Delete
                Eliminar()

            Case Keys.Subtract
                Eliminar()

            Case Keys.Escape
                Cancelar()
        End Select
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_ChequexCobrar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griChequexCobrar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griChequexCobrar.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del Cheque por Cobrar"

    Private Sub AsociarMenu()
        griChequexCobrar.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("tsmiInsertar").Visible = True
        If griChequexCobrar.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("tsmiActualizar").Visible = True
            MenuContextual1.Items("tsmiEliminar").Visible = True
            If griChequexCobrar.ActiveRow.Cells("Cobrado").Value Then
                MenuContextual1.Items("tsmiCobrar").Visible = False
            Else
                MenuContextual1.Items("tsmiCobrar").Visible = True
            End If

        Else
            MenuContextual1.Items("tsmiActualizar").Visible = False
            MenuContextual1.Items("tsmiEliminar").Visible = False
            MenuContextual1.Items("tsmiCobrar").Visible = False
        End If
    End Sub

    Private Sub tsmiInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiInsertar.Click
        Nuevo()
    End Sub

    Private Sub tsmiActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiActualizar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub tsmiCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiCobrar.Click
        If griChequexCobrar.Rows.Count > 0 Then
            Dim oeTrabajador As New e_Trabajador
            Dim olTrabajador As New l_Trabajador
            oeTrabajador.Activo = True
            LlenarCombo(cboTrabajador, "NombreCompleto", olTrabajador.Listar(oeTrabajador), -1)
            Mostrar()
            agrDatos.Height = 287
            oeChequexCobrar.TipoOperacion = "C"
            oeChequexCobrar.FechaCobro = Date.Now.Date
            oeChequexCobrar.Modificado = False
            verCobrar.Checked = True
            verCobrar.Enabled = False
            fecFechaCobro.Focus()
        End If
    End Sub

#End Region

End Class
