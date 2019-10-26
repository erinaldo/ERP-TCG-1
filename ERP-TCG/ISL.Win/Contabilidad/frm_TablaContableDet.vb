'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_TablaContableDet

    Inherits frm_MenuPadre
    Private WithEvents oeTablaContableDet As New e_TablaContableDet
    Private olTablaContableDet As New l_TablaContableDet
    Private oeTablaContable As New e_TablaContable
    Private Shared instancia As frm_TablaContableDet = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_TablaContableDet()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"
    Dim dtSubGrupoActivo As Data.DataTable

    Dim oeCuentaCtable As New e_CuentaContable, olCuentaContable As New l_CuentaContable
    Dim leCuentaCtable As New List(Of e_CuentaContable)

    Dim ListTablaContableDet As New List(Of e_Combo)
    Dim olCombo As New l_Combo
    Dim oeCombo As New e_Combo
    Dim ListaTablaContableDet As New List(Of e_Combo)


#End Region
#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If grid_ListaTablaContableDet.Rows.Count > 0 Then
                MyBase.Consultar(Activo) 'activa desactiva botonera
            Else
                MyBase.Consultar() 'activa desactiva botonera
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Inicializar()
        oeTablaContableDet.TipoOperacion = "I"
        oeTablaContableDet.Modificado = False
        txtNombre.Focus()
        MyBase.Nuevo() 'activa desactiva botonera
    End Sub

    Public Overrides Sub Editar()
        Try
            If ValidarGrilla(grid_ListaTablaContableDet, "Tabla Contable") Then
                If grid_ListaTablaContableDet.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    Inicializar()
                    Mostrar()
                    oeTablaContableDet.TipoOperacion = "A"
                    oeTablaContableDet.Modificado = False
                    txtNombre.Focus()
                    MyBase.Editar()
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarTabla() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcTablaContable)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTablaContableDet.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If Not GuardarTabla() Then
                            MostrarTabs(1, tcTablaContable)
                            Consultar(_Activo) 'activa desactiva botonera
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcTablaContable)
                        Consultar(_Activo) 'activa desactiva botonera
                End Select
            Else
                MostrarTabs(0, tcTablaContable)
                Consultar(_Activo) 'activa desactiva botonera
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_ListaTablaContableDet
                If ValidarGrilla(grid_ListaTablaContableDet, "Tabla Contable") Then
                    If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                        oeTablaContableDet.Id = .ActiveRow.Cells("Id").Value
                        oeTablaContableDet = olTablaContableDet.Obtener(oeTablaContableDet)
                        If oeTablaContableDet.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar la Tabla: " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeTablaContableDet.TipoOperacion = "E"
                                olTablaContableDet.Eliminar(oeTablaContableDet)
                                Consultar(_Activo)
                            End If
                        Else
                            Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                        End If
                    Else
                        Throw New Exception("Seleccione una Fila!")
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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

            If grid_ListaTablaContableDet.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_ListaTablaContableDet)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        oeTablaContableDet = New e_TablaContableDet
        oeTablaContableDet.IdTabla = oeTablaContable.Id
        txtNombre.Text = String.Empty
        txtTexto1.Text = String.Empty
        txtTexto2.Text = String.Empty
        txtTexto3.Text = String.Empty
        decValor1.Value = 0
        decValor2.Value = 0
        decValor3.Value = 0
        verLogico1.Checked = False
        verLogico2.Checked = False
        verLogico3.Checked = False
        verActivo.Checked = oeTablaContableDet.Activo
        verActivo.Visible = Not oeTablaContableDet.Activo
        MostrarTabs(1, tcTablaContable)
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            If cboTablaContable.Value = "" Then Throw New Exception("Ingrese nombre de Tabla")
            Me.Cursor = Cursors.WaitCursor
            oeTablaContableDet = New e_TablaContableDet
            oeTablaContableDet.IdTabla = cboTablaContable.Value
            oeTablaContableDet.TipoOperacion = "1"
            LimpiaGrid(grid_ListaTablaContableDet, ogdTablaContableDet)
            With grid_ListaTablaContableDet
                .DataSource = olTablaContableDet.Listar(oeTablaContableDet)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTabla").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
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
        grid_ListaTablaContableDet.Focus()
    End Sub

    Private Sub ListarTablaContable()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim oeTablaContable As New e_TablaContable
            Dim olTablaContable As New l_TablaContable
            Dim listTablaContable As New List(Of e_TablaContable)
            listTablaContable = olTablaContable.Listar(oeTablaContable)
            cboTablaContable.DataSource = listTablaContable
            cboTablaContableMan.DataSource = listTablaContable

            oeCombo = New e_Combo
            oeCombo.Nombre = "Tabla Contable"
            ListaTablaContableDet = olCombo.Listar(oeCombo)
            CrearComboGrid("IdTablaContableDet", "Nombre", grid_ListaTablaContableDet, olCombo.ComboGrilla(ListaTablaContableDet), True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GuardarTabla() As Boolean
        Try
            With oeTablaContableDet
                .IdTabla = cboTablaContable.Value
                .Nombre = txtNombre.Text.Trim
                .IndTablaContable = IIf(verIndTablaContable.Checked, 1, 0)
                .IdTablaContableDet = cboTablaContableDet.Value
            End With
            oeTablaContableDet.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTablaContableDet.Guardar(oeTablaContableDet) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                MostrarTabs(0, tcTablaContable, 2)
                Consultar(True)
                grid_ListaTablaContableDet.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub Mostrar()
        Try
            If grid_ListaTablaContableDet.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeTablaContableDet.Id = grid_ListaTablaContableDet.ActiveRow.Cells("Id").Value.ToString
                oeTablaContableDet.TipoOperacion = "1"
                oeTablaContableDet = olTablaContableDet.Obtener(oeTablaContableDet)
                With oeTablaContableDet
                    txtNombre.Text = .Nombre
                    txtTexto1.Text = .Texto1
                    txtTexto2.Text = .Texto2
                    txtTexto3.Text = .Texto3
                    decValor1.Value = .Valor1
                    decValor2.Value = .Valor2
                    decValor3.Value = .Valor3
                    verLogico1.Checked = .Logico1
                    verLogico2.Checked = .Logico2
                    verLogico3.Checked = .Logico3
                    verActivo.Checked = .Activo
                    verActivo.Visible = Not oeTablaContableDet.Activo
                    verIndTablaContable.Checked = .IndTablaContable
                    oeCombo = New e_Combo
                    oeCombo.Id = .IdTablaContableDet
                    oeCombo.Nombre = "Tabla Contable Detalle"
                    oeCombo = olCombo.Obtener(oeCombo)
                    cboTablaContableMan.Value = oeCombo.Descripcion
                    cboTablaContableMan_Validated(Nothing, Nothing)
                    cboTablaContableDet.Value = .IdTablaContableDet
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub MostrarDatosSegunCombo()
    '    With grid_ListaTablaContableDet
    '        agrTablaContableDet.Text = "Datos de " & LCase(oeTablaContable.Nombre)
    '        If oeTablaContable.Texto1 <> "" Then
    '            .DisplayLayout.Bands(0).Columns("Texto1").Hidden = False
    '            .DisplayLayout.Bands(0).Columns("Texto1").Header.Caption = oeTablaContable.Texto1
    '            etiTexto1.Text = oeTablaContable.Texto1
    '            etiTexto1.Visible = True
    '            txtTexto1.Visible = True
    '        Else
    '            .DisplayLayout.Bands(0).Columns("Texto1").Hidden = True
    '            etiTexto1.Visible = False
    '            txtTexto1.Visible = False
    '        End If
    '        If oeTablaContable.Texto2 <> "" Then
    '            .DisplayLayout.Bands(0).Columns("Texto2").Hidden = False
    '            .DisplayLayout.Bands(0).Columns("Texto2").Header.Caption = oeTablaContable.Texto2
    '            etiTexto2.Text = oeTablaContable.Texto2
    '            etiTexto2.Visible = True
    '            txtTexto2.Visible = True
    '        Else
    '            .DisplayLayout.Bands(0).Columns("Texto2").Hidden = True
    '            etiTexto2.Visible = False
    '            txtTexto2.Visible = False
    '        End If
    '        If oeTablaContable.Texto3 <> "" Then
    '            .DisplayLayout.Bands(0).Columns("Texto3").Hidden = False
    '            .DisplayLayout.Bands(0).Columns("Texto3").Header.Caption = oeTablaContable.Texto3
    '            etiTexto3.Text = oeTablaContable.Texto3
    '            etiTexto3.Visible = True
    '            txtTexto3.Visible = True
    '        Else
    '            .DisplayLayout.Bands(0).Columns("Texto3").Hidden = True
    '            etiTexto3.Visible = False
    '            txtTexto3.Visible = False
    '        End If
    '        If oeTablaContable.Valor1 <> "" Then
    '            .DisplayLayout.Bands(0).Columns("Valor1").Hidden = False
    '            .DisplayLayout.Bands(0).Columns("Valor1").Header.Caption = oeTablaContable.Valor1
    '            etiValor1.Text = oeTablaContable.Valor1
    '            etiValor1.Visible = True
    '            decValor1.Visible = True
    '        Else
    '            .DisplayLayout.Bands(0).Columns("Valor1").Hidden = True
    '            etiValor1.Visible = False
    '            decValor1.Visible = False
    '        End If
    '        If oeTablaContable.Valor2 <> "" Then
    '            .DisplayLayout.Bands(0).Columns("Valor2").Hidden = False
    '            .DisplayLayout.Bands(0).Columns("Valor2").Header.Caption = oeTablaContable.Valor2
    '            etiValor2.Text = oeTablaContable.Valor2
    '            etiValor2.Visible = True
    '            decValor2.Visible = True
    '        Else
    '            .DisplayLayout.Bands(0).Columns("Valor2").Hidden = True
    '            etiValor2.Visible = False
    '            decValor2.Visible = False
    '        End If
    '        If oeTablaContable.Valor3 <> "" Then
    '            .DisplayLayout.Bands(0).Columns("Valor3").Hidden = False
    '            .DisplayLayout.Bands(0).Columns("Valor3").Header.Caption = oeTablaContable.Valor3
    '            etiValor3.Text = oeTablaContable.Valor3
    '            etiValor3.Visible = True
    '            decValor3.Visible = True
    '        Else
    '            .DisplayLayout.Bands(0).Columns("Valor3").Hidden = True
    '            etiValor3.Visible = False
    '            decValor3.Visible = False
    '        End If
    '        If oeTablaContable.Logico1 <> "" Then
    '            .DisplayLayout.Bands(0).Columns("Logico1").Hidden = False
    '            .DisplayLayout.Bands(0).Columns("Logico1").Header.Caption = oeTablaContable.Logico1
    '            verLogico1.Text = oeTablaContable.Logico1
    '            verLogico1.Visible = True
    '        Else
    '            .DisplayLayout.Bands(0).Columns("Logico1").Hidden = True
    '            verLogico1.Visible = False
    '        End If
    '        If oeTablaContable.Logico2 <> "" Then
    '            .DisplayLayout.Bands(0).Columns("Logico2").Hidden = False
    '            .DisplayLayout.Bands(0).Columns("Logico2").Header.Caption = oeTablaContable.Logico2
    '            verLogico2.Text = oeTablaContable.Logico2
    '            verLogico2.Visible = True
    '        Else
    '            .DisplayLayout.Bands(0).Columns("Logico2").Hidden = True
    '            .DisplayLayout.Bands(0).Columns("Logico2").Header.Caption = oeTablaContable.Logico2
    '            verLogico2.Visible = False
    '        End If
    '        If oeTablaContable.Logico3 <> "" Then
    '            .DisplayLayout.Bands(0).Columns("Logico3").Hidden = False
    '            .DisplayLayout.Bands(0).Columns("Logico3").Header.Caption = oeTablaContable.Logico3
    '            verLogico3.Text = oeTablaContable.Logico3
    '            verLogico3.Visible = True
    '        Else
    '            .DisplayLayout.Bands(0).Columns("Logico3").Hidden = True
    '            verLogico3.Visible = False
    '        End If
    '    End With
    'End Sub

#End Region

#Region "Eventos"

    Private Sub oeTablaContableDet_DatoCambiado() Handles oeTablaContableDet.DatoCambiado
        oeTablaContableDet.Modificado = True
    End Sub

    Private Sub frm_TablaContableDet_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_TablaContableDet_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_TablaContableDet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcTablaContable)
        grid_ListaTablaContableDet.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        grid_ListaTablaContableDet.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
        ListarTablaContable()
    End Sub

    Private Sub timTiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timTiempo.Tick
        _tiempo = _tiempo - 1
    End Sub

    Private Sub grid_ListaTablaContableDet_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_ListaTablaContableDet.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grid_ListaTablaContableDet_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles grid_ListaTablaContableDet.DoubleClick
        If grid_ListaTablaContableDet.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_ListaTablaContableDet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_ListaTablaContableDet.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub grid_ListaTablaContableDet_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_ListaTablaContableDet.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        Eliminar()
    End Sub

    Private Sub cboTablaContable_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTablaContable.SelectionChangeCommitted
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Consultar(True)
    End Sub

    Private Sub txtTexto1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTexto1.ValueChanged
        oeTablaContableDet.Texto1 = txtTexto1.Text.Trim
    End Sub

    Private Sub txtTexto2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTexto2.ValueChanged
        oeTablaContableDet.Texto2 = txtTexto2.Text.Trim
    End Sub

    Private Sub txtTexto3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTexto3.ValueChanged
        oeTablaContableDet.Texto3 = txtTexto3.Text.Trim
    End Sub

    Private Sub decValor1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decValor1.ValueChanged
        oeTablaContableDet.Valor1 = decValor1.Value
    End Sub

    Private Sub decValor2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decValor2.ValueChanged
        oeTablaContableDet.Valor2 = decValor2.Value
    End Sub

    Private Sub decValor3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decValor3.ValueChanged
        oeTablaContableDet.Valor3 = decValor3.Value
    End Sub

    Private Sub verLogico1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verLogico1.CheckedChanged
        oeTablaContableDet.Logico1 = verLogico1.Checked
    End Sub

    Private Sub verLogico2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verLogico2.CheckedChanged
        oeTablaContableDet.Logico2 = verLogico2.Checked
    End Sub

    Private Sub verLogico3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verLogico3.CheckedChanged
        oeTablaContableDet.Logico3 = verLogico3.Checked
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeTablaContableDet.Activo = verActivo.Checked
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub
#End Region

    Private Sub cboTablaContableMan_Validated(sender As Object, e As EventArgs) Handles cboTablaContableMan.Validated
        ListTablaContableDet = New List(Of e_Combo)
        cboTablaContableDet.DataSource = ListTablaContableDet
        oeCombo = New e_Combo
        oeCombo.Id = cboTablaContableMan.Value
        oeCombo.Nombre = "Tabla Contable"
        ListTablaContableDet = olCombo.Listar(oeCombo)
        LlenarComboMaestro(cboTablaContableDet, ListTablaContableDet, 1)
    End Sub

    Private Sub cboTablaContableDet_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboTablaContableDet.InitializeLayout
        With cboTablaContableDet.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Width = 250
            .Columns("Descripcion").Hidden = True
        End With
    End Sub


End Class
