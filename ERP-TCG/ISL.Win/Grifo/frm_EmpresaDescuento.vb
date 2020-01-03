'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
' @0002  |  2020-01-02   | CESS
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_EmpresaDescuento

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_EmpresaDescuento = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_EmpresaDescuento
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Definición de variables"

    Private DESCUENTO As New e_EmpresaDescuento, d_EmpresaDescuento As New l_EmpresaDescuento, LISTA_DESCUENTO As New List(Of e_EmpresaDescuento)

    Private oeCombo As e_Combo, olCombo As New l_Combo
#End Region

#Region "Eventos"

    Private Sub frm_Almacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            MostrarTabs(0, ficAlmacen)
            udgDatos.DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
            udgDatos.DisplayLayout.Override.RowSelectors = DefaultableBoolean.True
            InicializaTiempo()
            mt_CargarCombo()
            mt_CargarIconos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


    Private Sub frm_Almacen_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub griAlmacen_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles udgDatos.InitializeLayout
        agrLista.Text = "Total de Descuentos: " & e.Layout.Rows.Count
    End Sub



#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If udgDatos.Rows.Count > 0 Then
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
            DESCUENTO.TipoOperacion = "I"
            MostrarTabs(1, ficAlmacen, 1)
            Inicializar()
            Operacion = "Nuevo"
            'GrillaZonaEdit.DataSource = ListaZona
            MyBase.Nuevo()
            DESCUENTO.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Mostrar()
            DESCUENTO.TipoOperacion = ""
            Operacion = "Editar"
            MyBase.Editar()
            DESCUENTO.Modificado = False
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
            If ficAlmacen.SelectedTab.Index = 1 Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficAlmacen, 2)
                            MyBase.Consultar(True)
                        Else
                            MostrarTabs(1, ficAlmacen, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficAlmacen, 2)
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficAlmacen, 2)
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try

            If ValidarGrilla(udgDatos, "Almacen") Then
                DESCUENTO.Id = udgDatos.ActiveRow.Cells("ID").Value
                DESCUENTO = d_EmpresaDescuento.Obtener(DESCUENTO)
                If DESCUENTO.Activo Then
                    If MessageBox.Show("Desea eliminar el Almacen: " &
                             udgDatos.ActiveRow.Cells("Nombre").Value.ToString & " ?",
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        DESCUENTO.TipoOperacion = "E"
                        d_EmpresaDescuento.Eliminar(DESCUENTO)
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

            If ficAlmacen.Tabs(0).Selected() AndAlso udgDatos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficAlmacen.Tabs(0).Selected() Then Exportar_Excel(udgDatos)

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


    Private Sub mt_CargarIconos()
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            cbgCliente.Value = ""
            cboProducto.Value = ""
            cboMoneda.Value = ""
            nudContado.Value = 0
            nudCredito.Value = 0
            dtpFechaInicio.Value = Now.Date()
            dtpFechaFin.Value = Now.Date()
            cboVendedor.Value = ""
            verActivo.Checked = True
            mt_CargarCombo()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Private Sub Mostrar()
        Try
            If udgDatos.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                With DESCUENTO
                    cbgCliente.Value = .IdEmpresa
                    cboProducto.Value = .IdProducto
                    cboMoneda.Value = .IdMoneda
                    nudContado.Value = .DescuentoContado
                    nudCredito.Value = .DescuentoCredito
                    dtpFechaInicio.Value = .FechaInicio
                    dtpFechaFin.Value = .FechaFin
                    cboVendedor.Value = .IdVendedorTrabajador
                    verActivo.Checked = .Activo
                End With
                MostrarTabs(1, ficAlmacen, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)

        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            DESCUENTO = New e_EmpresaDescuento
            With udgDatos
                .DataSource = d_EmpresaDescuento.Listar(DESCUENTO)
                .DisplayLayout.Bands(0).Columns("IdEmpresaSis").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdSucursal").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdProducto").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMoneda").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdVendedorTrabajador").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCrea").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCrea").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioModifica").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaModifica").Hidden = True
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub mt_CargarCombo()
        Try
            '' Moneda
            Dim olMoneda As New l_Moneda
            Dim loMoneda = olMoneda.Listar(New e_Moneda With {.TipoOperacion = 1, .Activo = True})
            gmt_ComboEspecifico(cboMoneda, loMoneda, 0, "Nombre")
            '' Material
            Dim olMaterial As New l_Material
            Dim loMaterial = olMaterial.Listar(New e_Material With {.TipoOperacion = "S", .Activo = True})
            gmt_ComboEspecifico(cboProducto, loMaterial, 0, "Nombre")
            '' Vendedores
            Dim olVendedores As New l_Persona
            Dim loVendedores = olVendedores.Listar(New e_Persona)
            gmt_ComboEspecifico(cboVendedor, loVendedores, 0, "NombreCompleto")
            '' Clientes
            Dim oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa, loEmpresa As New List(Of e_Empresa)
            cbgCliente.DataSource = loEmpresa
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region

#Region "Funciones"

    Private Function GuardarRegistro() As Boolean
        Try
            If cbgCliente.Value = "" Then Return False
            If cboProducto.Value = "" Then Return False

            With DESCUENTO
                .IdEmpresaSis = gs_IdEmpresaSistema
                .IdSucursalSistema = ""
                .PrefijoID = gs_PrefijoIdSucursal
                .IdEmpresa = cbgCliente.Value
                .Empresa = cbgCliente.Text
                .IdProducto = cboProducto.Value
                .Producto = cboProducto.Text
                .IdMoneda = cboMoneda.Value
                .Moneda = cboMoneda.Text
                .DescuentoContado = nudContado.Value
                .DescuentoCredito = nudCredito.Value
                .FechaInicio = dtpFechaInicio.Value
                .FechaFin = dtpFechaFin.Value
                .IdVendedorTrabajador = cboVendedor.Value
                .VendedorTrabajador = cboVendedor.Text
                .Activo = verActivo.Checked
            End With

            If Not d_EmpresaDescuento.Guardar(DESCUENTO) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficAlmacen, 2)
            Consultar(True)
            udgDatos.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
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
        udgDatos.ContextMenuStrip = MenuContextual1
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
        If udgDatos.Selected.Rows.Count > 0 Then
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

#Region "Combo Empresa"


    Private Sub cmbEmpresa_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cbgCliente.InitializeLayout
        cbgCliente.ValueMember = "Id"
        cbgCliente.DisplayMember = "Nombre"
        With cbgCliente.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("TipoEmpresa").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("IdDireccionTanqueo").Hidden = True
            .Columns("Morosidad").Hidden = True
            .Columns("Credito").Hidden = True
            .Columns("IndNivelComercial").Hidden = True
            .Columns("Moneda").Hidden = True
            .Columns("IndClasificacion").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("IndCategoriaEmpresaSGI").Hidden = True
            '.Columns("Activo").Hidden = True
            .Columns("Ruc").Header.Caption = "N° RUC"
            .Columns("Ruc").Width = 100
            .Columns("Nombre").Width = 500
        End With
    End Sub

    Private Sub cmbEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles cbgCliente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Not String.IsNullOrEmpty(cbgCliente.Text.Trim) Then
                    gmt_ListarEmpresa("6", cbgCliente, String.Empty, chkRuc.Checked)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cmbEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbgCliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cbgCliente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cmbEmpresa_Validated(sender As Object, e As EventArgs) Handles cbgCliente.Validated
        Try
            ' mt_ObtenerSaldoCtaCte()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

#End Region
End Class
