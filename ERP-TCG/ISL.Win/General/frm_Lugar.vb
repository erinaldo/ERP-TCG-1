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
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Lugar

#Region "Declaración de variables"

    Private Shared instancia As frm_Lugar = Nothing
    Private Shared Operacion As String
    Dim oeLugar As New e_Lugar
    Dim olLugar As New l_Lugar
    Dim _ingresando_datos As Boolean
    Dim oeClienteLugar As New e_ClienteLugar
    Dim oeVentanaHoraria As New e_VentanaHoraria
    Dim ListaClienteLugarTienda As New List(Of e_ClienteLugar)
    Dim ListaVentanaHoraria As New List(Of e_VentanaHoraria)
    Dim olCombo As New l_Combo
    Dim oeCombo As New e_Combo

    Public Proceso As String = ""

#End Region

#Region "Instancia"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Lugar()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griLista.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeLugar = New e_Lugar
        oeLugar.TipoOperacion = "I"
        txtId.Text = ""
        MostrarTabs(1, ficLugar, 1)
        Inicializar()
        txtNombre.Focus()
        Operacion = "Nuevo"
        griClienteLugarTienda.DataSource = ListaClienteLugarTienda
        griVentanaHoraria.DataSource = ListaVentanaHoraria
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Try
            If griLista.Selected.Rows.Count > 0 Then
                MostrarLugar()
                txtNombre.Focus()
                Operacion = "Editar"
                MyBase.Editar()
            Else
                mensajeEmergente.Problema("Seleecione registro", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarLugar() Then
                If Operacion = "Nuevo" Then
                    LugaresPublic = New List(Of e_Combo)
                    oeCombo = New e_Combo
                    oeCombo.Nombre = "Lugares"
                    LugaresPublic.AddRange(olCombo.Listar(oeCombo))
                End If
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficLugar, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If Proceso <> "TES" Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarLugar() Then
                            MostrarTabs(0, ficLugar, 2)
                            _ingresando_datos = False
                            Operacion = "Inicializa"
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficLugar, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficLugar, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griLista.Selected.Rows.Count > 0 Then
                griLista.ActiveRow.Delete()
            Else
                mensajeEmergente.Problema("Seleccione registro", True)
            End If
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
            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griLista)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeLugar = New e_Lugar
            With griLista
                oeLugar.Activo = Activo
                .DataSource = olLugar.Listar(oeLugar)
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
            griLista.Focus()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Sub

    Private Sub Inicializar()
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtTipoRuta.Text = String.Empty
        txtLugarTienda.Text = String.Empty
        txtCodigoTienda.Text = String.Empty
        txtCentroCosto.Text = String.Empty
        txtObservacion.Text = String.Empty
        Ubigeo1.Seleccionar("")
        If Proceso = "TES" Then
            UltraTabControl1.Visible = False
            btnGuardarLugar.Visible = True
        Else
            UltraTabControl1.Visible = True
            btnGuardarLugar.Visible = False
        End If
    End Sub

    Private Sub MostrarLugar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeLugar.Id = griLista.ActiveRow.Cells("Id").Value.ToString
                oeLugar = olLugar.Obtener(oeLugar)
                With oeLugar
                    txtId.Text = .Id
                    txtCodigo.Text = .Codigo
                    txtNombre.Text = .NombreCorto
                    txtAbreviatura.Text = .Abreviatura
                    txtTipoRuta.Text = .TipoRuta
                    Ubigeo1.Seleccionar(.IdUbigeo)
                    cboReferencia.Value = .IdReferencia
                End With
                oeClienteLugar = New e_ClienteLugar
                oeClienteLugar.IdLugar = txtId.Text
                griClienteLugarTienda.DataSource = olLugar.ListarClienteLugar(oeClienteLugar)
                oeVentanaHoraria = New e_VentanaHoraria
                oeVentanaHoraria.IdLugar = txtId.Text
                griVentanaHoraria.DataSource = olLugar.ListarVentanaHoraria(oeVentanaHoraria)
                MostrarTabs(1, ficLugar, 1)
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Function GuardarLugar() As Boolean
        Try
            oeLugar = New e_Lugar
            With oeLugar
                .TipoOperacion = "I"
                .Id = txtId.Text
                .Codigo = txtCodigo.Text
                .Nombre = txtNombre.Text
                .Abreviatura = txtAbreviatura.Text
                .TipoRuta = txtTipoRuta.Text
                .IdUbigeo = Ubigeo1.Id
                .UsuarioCreacion = gUsuarioSGI.Id
                .IdReferencia = cboReferencia.Value
            End With
            oeLugar.ListaClienteLugar = griClienteLugarTienda.DataSource
            oeLugar.ListaVentanaHoraria = griVentanaHoraria.DataSource
            oeLugar.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olLugar.Guardar(oeLugar) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                If Proceso = "TES" Then
                    Me.Close()
                End If
                MostrarTabs(0, ficLugar, 2)
                Consultar(True)
                griLista.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Sub LlenaCombos()
        Dim LugaresReferencia As New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = ""
        LugaresReferencia.Add(oeCombo)
        LugaresReferencia.AddRange(LugaresPublic)
        LlenarComboMaestro(cboReferencia, LugaresReferencia, 0)
        LlenarComboMaestro(cboListaReferencia, LugaresReferencia, 0)
        cbgClienteProveedor.DataSource = ClienteProveedorPublic
        For Each Col In cbgClienteProveedor.DisplayLayout.Bands(0).Columns
            Col.Hidden = "True"
        Next
        cbgClienteProveedor.DisplayMember = "Nombre"
        cbgClienteProveedor.ValueMember = "Id"
        cbgClienteProveedor.DropDownStyle = UltraComboStyle.DropDown
        cbgClienteProveedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        cbgClienteProveedor.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        cbgClienteProveedor.DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
        cbgClienteProveedor.DisplayLayout.Bands(0).ColHeadersVisible = False
        cbgClienteProveedor.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns

        LlenarComboMaestro(cboClienteVH, ClientesPublic, 1)
        CrearComboGrid("IdCliente", "Nombre", griClienteLugarTienda, olCombo.ComboGrilla(ClienteProveedorPublic), True)
        CrearComboGrid("IdCliente", "Nombre", griVentanaHoraria, olCombo.ComboGrilla(ClientesPublic), True)
        CrearComboGrid("IdReferencia", "Nombre", griLista, olCombo.ComboGrilla(LugaresReferencia), True)
    End Sub

    'Public Sub NuevoRegistro()
    '    Try
    '        Proceso = "TES"
    '        Nuevo()
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

#End Region

#Region "Eventos"
    Private Sub frm_Lugar_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Lugar_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            oeLugar.ListaClienteLugar = griClienteLugarTienda.DataSource
            With oeClienteLugar
                .Id = ""
                .IdLugar = txtId.Text
                .IdCliente = cbgClienteProveedor.Value
                .Nombre = txtLugarTienda.Text
                .Codigo = txtCodigoTienda.Text
                .CentroCosto = txtCentroCosto.Text
                .Observacion = txtObservacion.Text
            End With
            oeClienteLugar.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeLugar.ListaClienteLugar.Add(oeClienteLugar)
            griClienteLugarTienda.DataBind()
            oeClienteLugar = New e_ClienteLugar
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Lugar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LlenaCombos()
            fecHoraFinVH.Value = Date.Now
            fecHoraInicioVH.Value = Date.Now
            If Proceso = "TES" Then
                Nuevo()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griClienteLugarTienda_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griClienteLugarTienda.CellChange
        Try
            griClienteLugarTienda.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griClienteLugarTienda_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griClienteLugarTienda.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("Tienda Cliente: " & "¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inserta.Click
        Try
            Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiza.Click
        Try
            Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimina.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Menu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Menu.Opening
        Try
            Menu.Items("Inserta").Visible = True
            If griLista.Selected.Rows.Count > 0 Then
                Menu.Items("Actualiza").Visible = True
                Menu.Items("Elimina").Visible = True
            Else
                Menu.Items("Actualiza").Visible = False
                Menu.Items("Elimina").Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Lugar_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            Select Case Operacion
                Case "Nuevo"
                    MyBase.Nuevo()
                Case "Editar"
                    MyBase.Editar()
                Case "Inicializa"
                    'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    MostrarTabs(0, ficLugar)
                    'Consultar(True)
                    'InicializaTiempo()
                Case "Ayuda"
                    'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            With griLista
                If ValidarGrilla(griLista, "Lugares") Then
                    oeLugar.Id = .ActiveRow.Cells("Id").Value
                    oeLugar = olLugar.Obtener(oeLugar)
                    If oeLugar.Activo Then
                        If olLugar.VerificarAntesEliminar(oeLugar) = 0 Then
                            If MessageBox.Show("Esta seguro de eliminar el lugar: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeLugar.TipoOperacion = "E"
                                olLugar.Eliminar(oeLugar)
                                e.Cancel = False
                            Else
                                e.Cancel = True
                            End If
                        Else
                            MessageBox.Show("No se puede ELIMINAR este Lugar, porque esta siendo utilizada en el origen y/o destino de una RUTA",
                                            "Información del Sistema")
                            e.Cancel = True
                        End If
                    Else
                        Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        agrListaRegistro.Text = "Total Registros: " & e.Layout.Rows.Count
    End Sub

    Private Sub btnAgregarVH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarVH.Click
        Try
            oeLugar.ListaVentanaHoraria = griVentanaHoraria.DataSource
            With oeVentanaHoraria
                .Id = ""
                .IdLugar = txtId.Text
                .IdCliente = cboClienteVH.Value
                .Nombre = txtLugarTiendaVH.Text
                .Codigo = txtCodigoTiendaVH.Text
                .Activo = True
                'Dim fechaservidor As Date = ObtenerFechaServidor()
                '.HoraInicio = Date.Parse(fechaservidor.ToShortDateString & " " & fecHoraInicioVH.Value.ToShortTimeString)
                '.HoraFin = Date.Parse(fechaservidor.ToShortDateString & " " & fecHoraFinVH.Value.ToShortTimeString)
                .HoraInicio = fecHoraInicioVH.Value
                .HoraFin = fecHoraFinVH.Value
            End With
            oeVentanaHoraria.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeLugar.ListaVentanaHoraria.Add(oeVentanaHoraria)
            griVentanaHoraria.DataBind()
            oeVentanaHoraria = New e_VentanaHoraria
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griVentanaHoraria_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griVentanaHoraria.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If MessageBox.Show("Ventana Horaria: " & "¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griVentanaHoraria_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griVentanaHoraria.CellChange
        Try
            griVentanaHoraria.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_DoubleClick(sender As Object, e As EventArgs) Handles griLista.DoubleClick
        If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
            Editar()
        End If
    End Sub

    Private Sub cboLugarReferencia_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboListaReferencia.EditorButtonClick
        If griLista.Rows.Count > 0 Then
            If MessageBox.Show("Se va actualizar todos los lugares de la lista activa por: ", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                If griLista.Rows.Count > 0 Then
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                        Fila.Cells("IdReferencia").Value = cboListaReferencia.Value
                    Next
                End If
                ugb_Espera.Visible = False
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If griLista.Rows.Count > 0 Then
                If MessageBox.Show("Se va actualizar todos los REGISTROS de la lista activa desea continuar ? " & _
                                     cboListaReferencia.Text & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    If griLista.Rows.Count > 0 Then
                        For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                            oeLugar = New e_Lugar
                            With oeLugar
                                .TipoOperacion = "B"
                                .Id = RTrim(Fila.Cells("Id").Value)
                                .UsuarioCreacion = gUsuarioSGI.Id
                                .IdReferencia = Fila.Cells("IdReferencia").Value
                            End With
                            If olLugar.Guardar(oeLugar) Then
                                Fila.CellAppearance.BackColor = Me.ColorBloque.Color
                            End If
                        Next
                    End If
                End If
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griLista_ClickCellButton(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "Activo"
                    oeLugar = New e_Lugar
                    With oeLugar
                        .TipoOperacion = "B"
                        .Id = RTrim(griLista.ActiveRow.Cells("Id").Value)
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .IdReferencia = griLista.ActiveRow.Cells("IdReferencia").Value
                        .TipoRuta = griLista.ActiveRow.Cells("TipoRuta").Value
                    End With
                    If olLugar.Guardar(oeLugar) Then
                        griLista.ActiveRow.CellAppearance.BackColor = Me.ColorBloque.Color
                    End If
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

    Private Sub btnGuardarLugar_Click(sender As Object, e As EventArgs) Handles btnGuardarLugar.Click
        Guardar()
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        Try
            If e.Shift = False Then
                If e.KeyCode = Keys.Subtract Or e.KeyCode = Keys.OemMinus Then
                    e.SuppressKeyPress = True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtAbreviatura_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAbreviatura.KeyDown
        Try
            If e.Shift = False Then
                If e.KeyCode = Keys.Subtract Or e.KeyCode = Keys.OemMinus Then
                    e.SuppressKeyPress = True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_Lugar_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case ficLugar.SelectedTab.Index
                Case 0
                Case 1
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtObservacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservacion.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


#End Region

End Class
