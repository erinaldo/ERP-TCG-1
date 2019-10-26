'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports System.ComponentModel
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors

Public Class frm_TablaContable
    Inherits frm_MenuPadre

#Region "Declaración de variables"

    Private WithEvents oeTablaContable As New e_TablaContable
    Private olTablaContable As New l_TablaContable
    Private lstTablaContableDet As New BindingList(Of e_TablaContableDet)
    Private WithEvents oeTablaContableDet As New e_TablaContableDet
    Private olTablaContableDet As New l_TablaContableDet
    Private Shared instancia As frm_TablaContable = Nothing

#End Region

#Region "Definición del Formulario base"

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_TablaContable()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If grid_ListaTablaContable.Rows.Count > 0 Then
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
        oeTablaContable.TipoOperacion = "I"
        oeTablaContable.Modificado = False
        oeTablaContable.PrefijoID = gs_PrefijoIdSucursal '@0001
        txtNombre.Focus()
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Try
            If ValidarGrilla(grid_ListaTablaContable, "Tabla Contable") Then
                If grid_ListaTablaContable.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    Inicializar()
                    Mostrar()
                    oeTablaContable.Tipooperacion = "A"
                    oeTablaContable.Modificado = False
                    txtNombre.Focus()
                    MyBase.Editar()
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarTabla() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcTablaContable, 1)
                Consultar(_Activo) 'activa desactiva botonera
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTablaContable.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If Not GuardarTabla() Then
                            MostrarTabs(1, tcTablaContable, 1)
                            Consultar(_Activo) 'activa desactiva botonera
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcTablaContable, 2)
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, tcTablaContable, 2)
                Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_ListaTablaContable
                If ValidarGrilla(grid_ListaTablaContable, "Tabla Contable") Then
                    If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                        oeTablaContable.Id = .ActiveRow.Cells("Id").Value
                        oeTablaContable = olTablaContable.Obtener(oeTablaContable)
                        If oeTablaContable.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar la Tabla: " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                                     MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeTablaContable.Tipooperacion = "E"
                                olTablaContable.Eliminar(oeTablaContable)
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
            If grid_ListaTablaContable.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_ListaTablaContable)

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

    Private Sub Inicializar()
        oeTablaContable = New e_TablaContable
        txtNombre.Text = String.Empty
        txtColumnaTexto1.Text = String.Empty
        txtColumnaTexto2.Text = String.Empty
        txtColumnaTexto3.Text = String.Empty
        txtColumnaValor1.Text = String.Empty
        txtColumnaValor2.Text = String.Empty
        txtColumnaValor3.Text = String.Empty
        txtColumnaLogico1.Text = String.Empty
        txtColumnaLogico2.Text = String.Empty
        txtColumnaLogico3.Text = String.Empty
        verActivo.Checked = oeTablaContable.Activo
        verActivo.Visible = Not oeTablaContable.Activo
        MostrarTabs(1, tcTablaContable, 1)
        LimpiarListas()
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeTablaContable = New e_TablaContable
            oeTablaContable.Activo = Activo

            LimpiaGrid(grid_ListaTablaContable, odTablaCtble)
            With grid_ListaTablaContable
                .DataSource = olTablaContable.Listar(oeTablaContable)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Texto1").Hidden = True
                .DisplayLayout.Bands(0).Columns("Texto2").Hidden = True
                .DisplayLayout.Bands(0).Columns("Texto3").Hidden = True
                .DisplayLayout.Bands(0).Columns("Valor1").Hidden = True
                .DisplayLayout.Bands(0).Columns("Valor2").Hidden = True
                .DisplayLayout.Bands(0).Columns("Valor3").Hidden = True
                .DisplayLayout.Bands(0).Columns("Logico1").Hidden = True
                .DisplayLayout.Bands(0).Columns("Logico2").Hidden = True
                .DisplayLayout.Bands(0).Columns("Logico3").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With

        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_ListaTablaContable.Focus()
    End Sub

    Private Function GuardarTabla() As Boolean
        Try
            oeTablaContable.lstTablaCtbleDet = lstTablaContableDet.Where(Function(item) Not String.IsNullOrEmpty(item.TipoOperacion)).ToList
            oeTablaContable.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTablaContable.Guardar(oeTablaContable) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente")
                MostrarTabs(0, tcTablaContable, 2)
                Consultar(True)
                grid_ListaTablaContable.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub Mostrar()
        Try
            If grid_ListaTablaContable.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeTablaContable.Id = grid_ListaTablaContable.ActiveRow.Cells("Id").Value.ToString
                oeTablaContable = olTablaContable.Obtener(oeTablaContable)
                With oeTablaContable
                    txtNombre.Text = .Nombre
                    txtColumnaTexto1.Text = .Texto1
                    txtColumnaTexto2.Text = .Texto2
                    txtColumnaTexto3.Text = .Texto3
                    txtColumnaValor1.Text = .Valor1
                    txtColumnaValor2.Text = .Valor2
                    txtColumnaValor3.Text = .Valor3
                    txtColumnaLogico1.Text = .Logico1
                    txtColumnaLogico2.Text = .Logico2
                    txtColumnaLogico3.Text = .Logico3
                    verActivo.Checked = .Activo
                    verActivo.Visible = Not oeTablaContable.Activo
                    ListarDatosTablaCtble(.Id)
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarDatosTablaCtble(ByVal ls_IdTablaCtble As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeTablaContableDet = New e_TablaContableDet
            oeTablaContableDet.IdTabla = ls_IdTablaCtble
            oeTablaContableDet.TipoOperacion = "1"
            lstTablaContableDet = olTablaContableDet.ListarBind(oeTablaContableDet)
            DatosTablaCtble(lstTablaContableDet)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_TablaContableDet.Focus()
    End Sub

    Private Sub LimpiarListas()
        lstTablaContableDet = New BindingList(Of e_TablaContableDet)
        lstTablaContableDet.AllowNew = True
        lstTablaContableDet.AllowRemove = True
        lstTablaContableDet.RaiseListChangedEvents = True
        lstTablaContableDet.AllowEdit = True
        grid_TablaContableDet.DataSource = lstTablaContableDet
    End Sub

    'Private Sub AgregarDatoTablaCtble(ByVal oeTablaContableDet As e_TablaContableDet)
    '    Try
    '        With oeTablaContable
    '            If .Tipooperacion = "I" Then ' cuando inserto o nuevo cabecera y detalles
    '                If Not lstTablaContableDet.Contains(oeTablaContableDet) Then
    '                    ' si no esta en la lista o no esta contenido AGREGOOO
    '                    lstTablaContableDet.Add(oeTablaContableDet)
    '                Else
    '                    Throw New Exception("Ya existe este Centro")
    '                End If
    '            ElseIf .Tipooperacion = "A" Then ' cuando actualizo o edito el objeto
    '                If Not lstTablaContableDet.Contains(oeTablaContableDet) Then
    '                    ' si no esta en la lista o no esta contenido AGREGOOO
    '                    lstTablaContableDet.Add(oeTablaContableDet)
    '                Else
    '                    '-------BUSCA OBJETO EN LA LISTA DE OBJETOS
    '                    oeTablaContableDet = lstTablaContableDet.Item(lstTablaContableDet.IndexOf(oeTablaContableDet))
    '                    '---------
    '                    If oeTablaContableDet.TipoOperacion = "E" Then 'Existe en la BD y esta para eliminarse
    '                        ' la dejo como estaba al inicio(carga)
    '                        oeTablaContableDet.TipoOperacion = ""
    '                    Else
    '                        Throw New Exception("Ya existe este Centro")
    '                    End If
    '                End If
    '            End If
    '            'recargo grilla
    '            'CargaDatosTabla(lstTablaContableDet)
    '        End With
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message)
    '    End Try
    'End Sub

#End Region

#Region "Eventos"

    Private Sub oeTablaContable_DatoCambiado() Handles oeTablaContable.DatoCambiado
        oeTablaContable.Modificado = True
    End Sub

    Private Sub frm_TablaContable_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_TablaContable_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_TablaContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tcTablaContable)
            grid_ListaTablaContable.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            grid_ListaTablaContable.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            InicializaTiempo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub timTiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timTiempo.Tick
        _tiempo = _tiempo - 1
    End Sub

    Private Sub grid_ListaTablaContable_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_ListaTablaContable.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grid_ListaTablaContable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_ListaTablaContable.DoubleClick
        If grid_ListaTablaContable.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_ListaTablaContable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_ListaTablaContable.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub grid_ListaTablaContable_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_ListaTablaContable.MouseMove
        If _tiempo <= 0 Then Listar(_Activo)
        InicializaTiempo()
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeTablaContable.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtColumnaTexto1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColumnaTexto1.ValueChanged
        oeTablaContable.Texto1 = txtColumnaTexto1.Text.Trim
    End Sub

    Private Sub txtColumnaTexto2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColumnaTexto2.ValueChanged
        oeTablaContable.Texto2 = txtColumnaTexto2.Text.Trim
    End Sub

    Private Sub txtColumnaTexto3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColumnaTexto3.ValueChanged
        oeTablaContable.Texto3 = txtColumnaTexto3.Text.Trim
    End Sub

    Private Sub txtColumnaValor1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColumnaValor1.ValueChanged
        oeTablaContable.Valor1 = txtColumnaValor1.Text.Trim
    End Sub

    Private Sub txtColumnaValor2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColumnaValor2.ValueChanged
        oeTablaContable.Valor2 = txtColumnaValor2.Text.Trim
    End Sub

    Private Sub txtColumnaValor3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColumnaValor3.ValueChanged
        oeTablaContable.Valor3 = txtColumnaValor3.Text.Trim
    End Sub

    Private Sub txtColumnaLogico1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColumnaLogico1.ValueChanged
        oeTablaContable.Logico1 = txtColumnaLogico1.Text.Trim
    End Sub

    Private Sub txtColumnaLogico2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColumnaLogico2.ValueChanged
        oeTablaContable.Logico2 = txtColumnaLogico2.Text.Trim
    End Sub

    Private Sub txtColumnaLogico3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColumnaLogico3.ValueChanged
        oeTablaContable.Logico3 = txtColumnaLogico3.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeTablaContable.Activo = verActivo.Checked
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

#End Region

    Private Sub grid_ListaTablaContableDet_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_TablaContableDet.InitializeLayout

        e.Layout.Override.AllowAddNew = AllowAddNew.FixedAddRowOnTop

        e.Layout.Override.TemplateAddRowAppearance.BackColor = Color.FromArgb(245, 250, 255)
        e.Layout.Override.TemplateAddRowAppearance.ForeColor = SystemColors.GrayText

        e.Layout.Override.AddRowAppearance.BackColor = Color.LightYellow
        e.Layout.Override.AddRowAppearance.ForeColor = Color.Blue

        e.Layout.Override.SpecialRowSeparator = SpecialRowSeparator.TemplateAddRow
        e.Layout.Override.SpecialRowSeparatorAppearance.BackColor = SystemColors.Control

        e.Layout.Override.TemplateAddRowPrompt = "Click aqui para agregar un nuevo registro..."

        e.Layout.Override.TemplateAddRowPromptAppearance.ForeColor = Color.Maroon
        e.Layout.Override.TemplateAddRowPromptAppearance.FontData.Bold = DefaultableBoolean.True

        e.Layout.ScrollStyle = ScrollStyle.Immediate
        e.Layout.ScrollBounds = ScrollBounds.ScrollToFill
        '' --------------------------------------------------------------------------------
    End Sub

    Private Sub grid_ListaTablaContableDet_AfterRowInsert(sender As Object, e As RowEventArgs) Handles grid_TablaContableDet.AfterRowInsert
        Try
            Me.grid_TablaContableDet.Rows.Refresh(RefreshRow.ReloadData)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_TablaContableDet_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grid_TablaContableDet.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If e.Rows.Count > 0 AndAlso Not grid_TablaContableDet.ActiveRow.ListObject Is Nothing Then
                If System.Windows.Forms.MessageBox.Show("Desea eliminar " & grid_TablaContableDet.ActiveRow.Cells("Nombre").Value & " ?", _
                        "Elimina fila?", System.Windows.Forms.MessageBoxButtons.YesNo, _
                        System.Windows.Forms.MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    With oeTablaContable
                        Dim oeTablaContableDet As New e_TablaContableDet
                        oeTablaContableDet = grid_TablaContableDet.ActiveRow.ListObject
                        If .Tipooperacion = "A" Then ' cuando actualizo o edito el objeto
                            If Not String.IsNullOrEmpty(oeTablaContableDet.Id) Then '---viene de BD
                                oeTablaContableDet.TipoOperacion = "E"
                                e.Cancel = True
                            End If
                        Else
                            lstTablaContableDet.RemoveAt(lstTablaContableDet.IndexOf(oeTablaContableDet))
                        End If
                        DatosTablaCtble(lstTablaContableDet)
                    End With
                Else
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_TablaContableDet_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles grid_TablaContableDet.AfterRowUpdate
        Try
            Dim oeTablaContableDet As New e_TablaContableDet
            oeTablaContableDet = e.Row.ListObject
            If oeTablaContable.Tipooperacion = "A" Then
                If Not String.IsNullOrEmpty(oeTablaContableDet.Id) Then
                    oeTablaContableDet.TipoOperacion = "A"
                Else
                    oeTablaContableDet.TipoOperacion = "I"
                    oeTablaContableDet.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If Not String.IsNullOrEmpty(oeTablaContableDet.Nombre) Then
                        lstTablaContableDet.Add(oeTablaContableDet)
                    End If
                End If
            ElseIf oeTablaContable.Tipooperacion = "I" Then
                oeTablaContableDet.TipoOperacion = "I"
                oeTablaContableDet.PrefijoID = gs_PrefijoIdSucursal '@0001
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub DatosTablaCtble(ByVal lstDatos As BindingList(Of e_TablaContableDet))
        Dim selectedDatos As New BindingList(Of e_TablaContableDet)
        For Each dato As e_TablaContableDet In lstDatos
            dato.PrefijoID = gs_PrefijoIdSucursal '@0001
            If String.IsNullOrEmpty(dato.TipoOperacion) OrElse Not dato.TipoOperacion.ToUpper().Equals("E") Then
                selectedDatos.Add(dato)
            End If
        Next
        Me.grid_TablaContableDet.DataSource = selectedDatos
        grid_TablaContableDet.DataBind()
    End Sub

End Class
