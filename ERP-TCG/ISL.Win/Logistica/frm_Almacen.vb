'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Almacen

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_Almacen = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_Almacen
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Definición de variables"

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeAlmacen As New e_Almacen
    Dim oeZona As New e_Zona
    Dim olZonas As New l_Zona
    Dim olAlmacen As New l_Almacen
    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    Dim _ingresando_datos As Boolean = False
    Dim llZonas As New List(Of e_Zona)
    Dim Estado As String
    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor

    Private oeSubAlmacen As e_SubAlmacen, leSubAlmacen As List(Of e_SubAlmacen)
    Private oeGrifo As e_Empresa, olGrifo As l_Empresa, leGrifo As List(Of e_Empresa)
    Private oeCCPP As e_CCPP, olCCPP As l_CCPP, leCCPP As List(Of e_CCPP)
    Private oeDireccion As e_Direccion, olDireccion As l_Direccion, leDireccion As List(Of e_Direccion)

#End Region

#Region "Eventos"

    Private Sub frm_Almacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            MostrarTabs(0, ficAlmacen)
            mt_InicializarLogicas()
            griAlmacen.DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
            griAlmacen.DisplayLayout.Override.RowSelectors = DefaultableBoolean.True
            InicializaTiempo()
            llenarComboCentro()
            mt_CargarCombo()
            mt_CargarIconos()
            mt_CargarSubAlmacen(New List(Of e_SubAlmacen))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub oeAlmacen_DatoCambiado() Handles oeAlmacen.DatoCambiado
        oeAlmacen.Modificado = True
    End Sub

    Private Sub frm_Almacen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Almacen_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        Me.txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeAlmacen.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeAlmacen.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        Me.txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        Me.txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeAlmacen.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub decCapacidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles decCapacidad.GotFocus
        decCapacidad.SelectAll()
    End Sub

    Private Sub txtDireccion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.GotFocus
        txtDireccion.SelectAll()
    End Sub

    Private Sub txtDireccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDireccion.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtDireccion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.ValueChanged
        txtDireccion.Text = LTrim(txtDireccion.Text)
        oeAlmacen.Direccion = txtDireccion.Text.Trim
        Ubigeo1.Id = IIf(String.IsNullOrEmpty(txtDireccion.Text), "010101", oeAlmacen.Ubigeo)
        MuestraControlUbigeo()
    End Sub

    Private Sub Ubigeo1_DatoCambiado(ByVal Id As System.String) Handles Ubigeo1.DatoCambiado
        oeAlmacen.Ubigeo = Ubigeo1.Id
    End Sub

    Private Sub decCapacidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles decCapacidad.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub decCapacidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decCapacidad.ValueChanged
        oeAlmacen.Capacidad = decCapacidad.Value
    End Sub

    Private Sub verPropio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verPropio.CheckedChanged
        oeAlmacen.Propio = verPropio.Checked
        If verPropio.Checked Then
            cboProveedor.Enabled = False
            ListarProveedores(ISL_IdProveedor)
            cboProveedor.Value = ISL_IdProveedor
        Else
            cboProveedor.Enabled = True
            cboProveedor.Text = String.Empty
            cboProveedor.DataSource = Nothing
        End If
    End Sub

    Private Sub verPropio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verPropio.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub verLotizable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verLotizable.CheckedChanged
        oeAlmacen.Lotizable = verLotizable.Checked
    End Sub

    Private Sub verLotizable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verLotizable.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub verProduccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verPropio.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub cboCentro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentro.ValueChanged
        oeAlmacen.IdCentro = cboCentro.Value
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeAlmacen.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griAlmacen_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griAlmacen.DoubleClick
        If griAlmacen.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griAlmacen.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griAlmacen_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griAlmacen.InitializeLayout
        agrLista.Text = "Total de Almacenes: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub cboProveedor_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedor.InitializeLayout
        Me.cboProveedor.ValueMember = "Id"
        Me.cboProveedor.DisplayMember = "Nombre"
        With cboProveedor.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Email").Hidden = True
            .Columns("Seleccion").Hidden = True
            .Columns("Contacto").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("TipoPersonaEmpresa").Hidden = True
            .Columns("IdPersona").Hidden = True
            .Columns("IdEmpresa").Hidden = True
            .Columns("FechaActividad").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("NroDocumento").Header.Caption = "N° RUC"
            .Columns("NroDocumento").Width = 50
            .Columns("Nombre").Width = 150
        End With
    End Sub

    Private Sub cboProveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarProveedores()
        End If
    End Sub

    Private Sub cboProveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProveedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboProveedor.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboGrifo_ValueChanged(sender As Object, e As EventArgs) Handles cboGrifo.ValueChanged
        Try
            If cboGrifo.SelectedIndex > -1 Then
                LlenarCombo(cboLugar, "Nombre", leCCPP.Where(Function(it) it.IdEmpresa.Trim = cboGrifo.Value.ToString.Trim).ToList, -1)
            Else
                LlenarCombo(cboLugar, "Nombre", New List(Of e_CCPP), -1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboLugar_ValueChanged(sender As Object, e As EventArgs) Handles cboLugar.ValueChanged
        Try
            If cboLugar.SelectedIndex > -1 Then
                LlenarCombo(cboDireccion, "Via", leDireccion.Where(Function(it) it.IdPais.Trim = cboGrifo.Value.ToString.Trim And _
                                                                       it.CCPP.Trim = cboLugar.Value.ToString.Trim).ToList, -1)
            Else
                LlenarCombo(cboDireccion, "Via", New List(Of e_Direccion), -1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            'If txtCodigoSub.Text.Trim.Length = 0 Then Throw New Exception("Ingrese Codigo de SubAlmacen")
            If cboGrifo.SelectedIndex = -1 Then Throw New Exception("Seleccione Grifo de SubAlmacen")
            If cboDireccion.SelectedIndex = -1 Then Throw New Exception("Seleccione Direccion de Grifo de SubAlmacen")
            If MessageBox.Show("¿Desea Guardar los Cambios?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oeSubAlmacen = New e_SubAlmacen
                oeSubAlmacen.TipoOperacion = "I"
                oeSubAlmacen.Equivale = 2
                oeSubAlmacen.Codigo = txtCodigoSub.Text.Trim
                oeSubAlmacen.IdGrifo = cboGrifo.Value
                oeSubAlmacen.Descripcion = cboGrifo.Text.Trim + " " + txtDescripcion.Text.Trim
                oeSubAlmacen.IdDireccion = cboDireccion.Value
                oeSubAlmacen.Referencia = cboDireccion.Text.Trim
                oeSubAlmacen.Activo = True
                oeSubAlmacen.PrefijoID = gs_PrefijoIdSucursal '@0001
                If Not leSubAlmacen.Contains(oeSubAlmacen) Then
                    leSubAlmacen.Add(oeSubAlmacen)
                    griSubAlmacen.DataBind()
                Else
                    Throw New Exception("Ya se encuentra registro el SubAlmacen")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            If MessageBox.Show("¿Desea cancelar la operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                mt_InicializarSubAlmacen()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griAlmacen.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Dim ListaZona As New List(Of e_Zona)
            oeAlmacen.TipoOperacion = "I"
            MostrarTabs(1, ficAlmacen, 1)
            Inicializar()
            txtCodigo.Focus()
            Operacion = "Nuevo"
            'GrillaZonaEdit.DataSource = ListaZona
            MyBase.Nuevo()
            oeAlmacen.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Mostrar()
            oeAlmacen.TipoOperacion = ""
            txtCodigo.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oeAlmacen.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficAlmacen, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeAlmacen.Modificado And ficAlmacen.SelectedTab.Index = 1 Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficAlmacen, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficAlmacen, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficAlmacen, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficAlmacen, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try

            If ValidarGrilla(griAlmacen, "Almacen") Then
                oeAlmacen.Id = griAlmacen.ActiveRow.Cells("ID").Value
                oeAlmacen = olAlmacen.Obtener(oeAlmacen)
                If oeAlmacen.Activo Then
                    If MessageBox.Show("Desea eliminar el Almacen: " & _
                             griAlmacen.ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeAlmacen.TipoOperacion = "E"
                        olAlmacen.Eliminar(oeAlmacen)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            End If

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

            If ficAlmacen.Tabs(0).Selected() AndAlso griAlmacen.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficAlmacen.Tabs(0).Selected() Then Exportar_Excel(griAlmacen)

            'If ficAlmacen.Tabs(1).Selected() AndAlso GrillaZonaEdit.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            'If ficAlmacen.Tabs(1).Selected() Then Exportar_Excel(GrillaZonaEdit)

            MyBase.Exportar()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
        Dim frm As frm_ReporteBasico = frm_ReporteAlmacen
        frm.MdiParent = frm_Menu
        frm.Show()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Private Sub mt_InicializarLogicas()
        Try
            olGrifo = New l_Empresa
            olCCPP = New l_CCPP
            olDireccion = New l_Direccion
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarIconos()
        Try
            For Each Item In gLstIconos
                Select Case Item.Nombre
                    Case "Aprobar" : btnAceptar.Appearance.Image = Item.Icono
                    Case "Cancelar" : btnCancelar.Appearance.Image = Item.Icono
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        cboCentro.SelectedIndex = -1
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtDireccion.Text = String.Empty
        decCapacidad.Value = 0
        verPropio.Checked = 1 : verLotizable.Checked = 0 : verActivo.Checked = 1
        AsociarMenu()
        leSubAlmacen = New List(Of e_SubAlmacen)
        mt_CargarSubAlmacen(leSubAlmacen)
        'Ubigeo1.Visible = False
    End Sub

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

    Private Sub Mostrar()
        Try
            If griAlmacen.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeAlmacen.Id = griAlmacen.ActiveRow.Cells("Id").Value.ToString
                oeZona.IdAlmacen = oeAlmacen.Id
                oeAlmacen.CargaCompleta = True
                oeAlmacen = olAlmacen.Obtener(oeAlmacen)
                'oeAlmacen.lstZona = ListarZonasEditar(_Activo)
                txtId.Text = oeAlmacen.Id
                txtCodigo.Text = oeAlmacen.Codigo
                txtNombre.Text = oeAlmacen.Nombre
                txtAbreviatura.Text = oeAlmacen.Abreviatura
                verActivo.Checked = oeAlmacen.Activo
                decCapacidad.Value = oeAlmacen.Capacidad
                txtDireccion.Text = oeAlmacen.Direccion
                verPropio.Checked = oeAlmacen.Propio
                If Not String.IsNullOrEmpty(oeAlmacen.IdProveedor.Trim) Then
                    ListarProveedores(oeAlmacen.IdProveedor)
                    cboProveedor.Value = oeAlmacen.IdProveedor
                Else
                    cboProveedor.Text = String.Empty
                    cboProveedor.DataSource = Nothing
                End If
                cboProveedor.Enabled = Not verPropio.Checked
                verLotizable.Checked = oeAlmacen.Lotizable
                cboCentro.Value = oeAlmacen.IdCentro
                leSubAlmacen = New List(Of e_SubAlmacen)
                leSubAlmacen = oeAlmacen.leSubAlmacen
                mt_InicializarSubAlmacen()
                agrDatosSubAlmacen.Enabled = IIf(txtNombre.Text.Contains("GRIFO"), True, False)
                mt_CargarSubAlmacen(leSubAlmacen)
                MostrarTabs(1, ficAlmacen, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)

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
            oeAlmacen = New e_Almacen
            With griAlmacen
                oeAlmacen.Activo = Activo
                .DataSource = olAlmacen.Listar(oeAlmacen)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = False
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
                .DisplayLayout.Bands(0).Columns("Abreviatura").Hidden = False
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                    agrLista.Text = "Total de Almacenes: " & .Rows.Count
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MuestraControlUbigeo()
        If txtDireccion.Text.Length > 0 Then
            Ubigeo1.Seleccionar(Ubigeo1.Id)
            Ubigeo1.Visible = True
        Else
            Ubigeo1.Visible = False
        End If
    End Sub

    Private Sub ListarDireccion(ByVal leDireccion As List(Of e_Direccion))
        Try

            If leDireccion.Count > 0 Then
                'txtDireccion.Text = leDireccion.Item(0).Direccion.ToString
                'Ubigeo1.Id = leDireccion.Item(0).Ubigeo.ToString
            Else
                Ubigeo1.Id = "010101"
            End If
            Ubigeo1.Seleccionar(Ubigeo1.Id)
            MuestraControlUbigeo()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub ListarProveedores(Optional ByVal IdProveedor As String = "0")
        Try
            Cursor.Current = Cursors.WaitCursor
            oeProveedor = New e_Proveedor
            cboProveedor.DataSource = Nothing
            If chkRuc.Checked Then oeProveedor._chkRuc = 1
            If Not String.IsNullOrEmpty(cboProveedor.Text.Trim) And IdProveedor = "0" Then
                oeProveedor.Nombre = cboProveedor.Text.Trim
                cboProveedor.DataSource = olProveedor.Listar(oeProveedor)
            ElseIf IdProveedor <> "0" Then
                oeProveedor.Id = IdProveedor
                cboProveedor.DataSource = olProveedor.Listar(oeProveedor)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub llenarComboCentro()
        Try
            oeCentro.TipoOperacion = ""
            oeCentro.Activo = True
            LlenarComboMaestro(cboCentro, olCentro.Listar(oeCentro), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarSubAlmacen(leSub As List(Of e_SubAlmacen))
        Try
            With griSubAlmacen
                .ResetDisplayLayout()
                .DataSource = leSub
                ConfiguraGrilla(griSubAlmacen, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna2(griSubAlmacen, False, "Codigo", "Descripcion", "Referencia")
                .DisplayLayout.Bands(0).Columns("Descripcion").Width = 250
                .DisplayLayout.Bands(0).Columns("Referencia").Width = 350
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCombo()
        Try
            ' Cargar Grifos
            oeGrifo = New e_Empresa : leGrifo = New List(Of e_Empresa)
            oeGrifo.TipoOperacion = "1"
            oeGrifo.IdTipoEmpresa = "1CH000000002"
            leGrifo = olGrifo.Listar(oeGrifo)
            LlenarCombo(cboGrifo, "Nombre", leGrifo, -1)
            ' Cargar Lugares CCPP
            oeCCPP = New e_CCPP : leCCPP = New List(Of e_CCPP)
            oeCCPP.TipOoperacion = 1
            leCCPP = olCCPP.Listar(oeCCPP)
            ' Cargar Direccion 
            oeDireccion = New e_Direccion : leDireccion = New List(Of e_Direccion)
            oeDireccion.TipoOperacion = 1
            leDireccion = olDireccion.Listar(oeDireccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarSubAlmacen()
        txtCodigoSub.Text = String.Empty
        cboGrifo.SelectedIndex = -1
    End Sub

#End Region

#Region "Funciones"

    Private Function GuardarRegistro() As Boolean
        Try
            oeAlmacen.Propio = verPropio.Checked
            oeAlmacen.Lotizable = verLotizable.Checked
            oeAlmacen.IdProveedor = cboProveedor.Value.ToString
            oeAlmacen.lstZona = llZonas
            oeAlmacen.leSubAlmacen = leSubAlmacen
            oeAlmacen.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olAlmacen.Guardar(oeAlmacen) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficAlmacen, 2)
            Consultar(True)
            griAlmacen.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Public Function ListarZonasEditar(ByVal Activo As Boolean)
        Try
            If Activo Then
                Estado = " Activo"
            Else
                Estado = " Inactivo"
            End If
            Me.Cursor = Cursors.WaitCursor
            oeAlmacen.Id = griAlmacen.ActiveRow.Cells("Id").Value.ToString
            oeZona = New e_Zona
            oeZona.IdAlmacen = oeAlmacen.Id
            oeZona.Activo = Activo
            Return olZonas.Listar(oeZona)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Return Nothing
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Almacen_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griAlmacen_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Almacén"

    Private Sub AsociarMenu()
        griAlmacen.ContextMenuStrip = MenuContextual1
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
        If griAlmacen.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

#Region "Zonas - Almacen"

    Private Sub txtLado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region

End Class
