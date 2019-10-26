'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_CategoriaServicio
    Inherits frm_MenuPadre

#Region "Definición de variables"

    Dim oeCategoriaServicio As New e_CategoriaServicio
    Dim olCategoriaServicio As New l_CategoriaServicio

    Dim oeCtaCtbleCatSer As New e_CtaCtbleCatServicio
    Dim olCtaCtbleCatSer As New l_CtaCtbleCatServicio
    Dim loCtaCtbleCatSer As New List(Of e_CtaCtbleCatServicio)

    Private oeCuenta As New e_CuentaContable

    Private oeCtaCtble As New e_CuentaContable
    Private olCtaCtble As New l_CuentaContable
    Private loCtaCtble As New List(Of e_CuentaContable)

    Private loCtaCtbleCmp As New List(Of e_CuentaContable)

    Private oeItemGasto As New e_ItemGasto
    Private olItemGasto As New l_ItemGasto
    Private loItemGasto As New List(Of e_ItemGasto)

    Dim _ingresando_datos As Boolean = False
    Private Shared Operacion As String
    Private Shared instancia As frm_CategoriaServicio = Nothing

#End Region

#Region "Instancia"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_CategoriaServicio()
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
            If grid_CategoriaServicio.Rows.Count > 0 Then
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
            oeCategoriaServicio.TipoOperacion = "I"
            MostrarTabs(1, tcCategoriaServicio, 1)
            Inicializar()
            txtNombre.Focus()
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        
    End Sub

    Public Overrides Sub Editar()
        Try
            MostrarCategoriaServicio()
            oeCategoriaServicio.TipoOperacion = "A"
            txtCodigo.Focus()
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCategoriaServicio() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcCategoriaServicio, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCategoriaServicio.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarCategoriaServicio() Then
                            MostrarTabs(0, tcCategoriaServicio, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcCategoriaServicio, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcCategoriaServicio, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, tcCategoriaServicio, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try

            If ValidarGrilla(grid_CategoriaServicio, "Categoria Servicio") Then
                oeCategoriaServicio.Id = grid_CategoriaServicio.ActiveRow.Cells("ID").Value
                oeCategoriaServicio = olCategoriaServicio.Obtener(oeCategoriaServicio)
                If oeCategoriaServicio.Activo Then
                    If MessageBox.Show("Esta seguro de eliminar la Categoria Servicio: " & _
                             grid_CategoriaServicio.ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeCategoriaServicio.TipoOperacion = "E"
                        olCategoriaServicio.Eliminar(oeCategoriaServicio)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If grid_CategoriaServicio.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_CategoriaServicio)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeCategoriaServicio = New e_CategoriaServicio
            oeCategoriaServicio.Activo = Activo
            grid_CategoriaServicio.DataSource = olCategoriaServicio.Listar(oeCategoriaServicio)

            'Ubica el cursor el el primer registro de la grilla
            If grid_CategoriaServicio.Rows.Count > 0 Then
                grid_CategoriaServicio.Focus()
                grid_CategoriaServicio.Rows.Item(0).Selected = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_CategoriaServicio.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtDescripcion.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        cboCtaCmp.SelectedIndex = -1
        cboItemGasto.SelectedIndex = -1
        loCtaCtbleCatSer = New List(Of e_CtaCtbleCatServicio)
        griCtaCatServ.DataSource = loCtaCtbleCatSer
    End Sub

    Private Sub MostrarCategoriaServicio()
        Try
            If grid_CategoriaServicio.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeCategoriaServicio.Id = grid_CategoriaServicio.ActiveRow.Cells("Id").Value.ToString
                oeCategoriaServicio = olCategoriaServicio.Obtener(oeCategoriaServicio)
                txtCodigo.Text = oeCategoriaServicio.Codigo
                txtNombre.Text = oeCategoriaServicio.Nombre
                txtDescripcion.Text = oeCategoriaServicio.Descripcion
                verActivo.Checked = oeCategoriaServicio.Activo
                ListarCuenta(oeCategoriaServicio.Id)
                MostrarTabs(1, tcCategoriaServicio, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ListarCuenta(IdCategoriaServicio As String)
        Try
            oeCtaCtbleCatSer = New e_CtaCtbleCatServicio
            oeCtaCtbleCatSer.IdCategoriaServicio = IdCategoriaServicio
            loCtaCtbleCatSer = olCtaCtbleCatSer.Listar(oeCtaCtbleCatSer)
            griCtaCatServ.DataSource = loCtaCtbleCatSer
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarCategoriaServicio() As Boolean
        Try
            oeCategoriaServicio.loCtaCtbleCatServ = New List(Of e_CtaCtbleCatServicio)
            oeCategoriaServicio.loCtaCtbleCatServ.AddRange(loCtaCtbleCatSer)
            oeCategoriaServicio.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olCategoriaServicio.Guardar(oeCategoriaServicio) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcCategoriaServicio, 2)
                Consultar(True)
                grid_CategoriaServicio.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
        If excepcion.Contains("Descripcion") Then
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub AgregarCC()
        Try
            oeCtaCtbleCatSer = New e_CtaCtbleCatServicio
            oeCuenta = New e_CuentaContable
            oeCuenta.Equivale = 1
            oeCuenta.Id = cboCtaCmp.Value
            oeCuenta = loCtaCtble.Item(loCtaCtble.IndexOf(oeCuenta))
            If loCtaCtbleCatSer.Count > 0 Then
                For Each ctacte As e_CtaCtbleCatServicio In loCtaCtbleCatSer
                    If ctacte.TipoOperacion <> "E" Then
                        If oeCuenta.Ejercicio = ctacte.Ejercicio Then
                            Throw New Exception("Ya Agrego CuentaContable para el Ejercicio: " & oeCuenta.Ejercicio)
                        End If
                    End If     
                Next
            End If
            With oeCtaCtbleCatSer
                .TipoOperacion = "I"
                .IdCuentaContable = oeCuenta.Id
                .CuentaContable = oeCuenta.Nombre
                .NroCuentaContable = oeCuenta.Cuenta
                .Ejercicio = oeCuenta.Ejercicio
                .IdItemGasto = cboItemGasto.Value
                .ItemGasto = cboItemGasto.Text
            End With
            oeCtaCtbleCatSer.PrefijoID = gs_PrefijoIdSucursal '@0001
            loCtaCtbleCatSer.Add(oeCtaCtbleCatSer)
            griCtaCatServ.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaCombosCS()
        loCtaCtble = New List(Of e_CuentaContable)
        oeCtaCtble = New e_CuentaContable
        oeCtaCtble.TipoOperacion = "M"
        oeCtaCtble.Ejercicio = ObtenerFechaServidor.Year
        loCtaCtble.AddRange(olCtaCtble.Listar(oeCtaCtble))
        loCtaCtbleCmp = New List(Of e_CuentaContable)
        loCtaCtbleCmp.AddRange(loCtaCtble.Where(Function(item) item.Tesoreria = 3).ToList)
        LlenarCombo(cboCtaCmp, "Cuenta", loCtaCtbleCmp, -1)
        oeItemGasto = New e_ItemGasto
        oeItemGasto.TipoOperacion = "W"
        oeItemGasto.Activo = True
        oeItemGasto.Ejercicio = oeCtaCtble.Ejercicio
        loItemGasto.AddRange(olItemGasto.Listar(oeItemGasto))
        LlenarCombo(cboItemGasto, "Nombre", loItemGasto, -1)
    End Sub

    Private Sub QuitarCC()
        Try
            oeCtaCtbleCatSer = New e_CtaCtbleCatServicio
            oeCtaCtbleCatSer = griCtaCatServ.ActiveRow.ListObject
            If oeCtaCtbleCatSer.TipoOperacion = "I" Then
                loCtaCtbleCatSer.Remove(oeCtaCtbleCatSer)
            Else
                oeCtaCtbleCatSer.TipoOperacion = "E"
                griCtaCatServ.ActiveRow.Hidden = True
            End If
            griCtaCatServ.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CategoriaServicio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_CategoriaServicio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_CategoriaServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcCategoriaServicio)
        LlenaCombosCS()
        Tiempo1.Enabled = False
        InicializaTiempo()
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeCategoriaServicio.Nombre = txtNombre.Text
    End Sub

    Private Sub txtDescripcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.ValueChanged
        txtDescripcion.Text = LTrim(txtDescripcion.Text)
        oeCategoriaServicio.Descripcion = txtDescripcion.Text
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeCategoriaServicio.Codigo = txtCodigo.Text
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeCategoriaServicio.Activo = verActivo.Checked
    End Sub

    Private Sub grid_CategoriaServicio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_CategoriaServicio.DoubleClick
        If grid_CategoriaServicio.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_CategoriaServicio_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)
        agrTotalCategoriaServicio.Text = "Total de Categorías de servicio" & e.Layout.Rows.Count
    End Sub

    Private Sub btnAgregarCC_Click(sender As Object, e As EventArgs) Handles btnAgregarCC.Click
        Try
            If cboCtaCmp.SelectedIndex <> -1 And cboItemGasto.SelectedIndex <> -1 Then AgregarCC()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCtaCmp_ValueChanged(sender As Object, e As EventArgs) Handles cboCtaCmp.ValueChanged
        If cboCtaCmp.SelectedIndex <> -1 Then
            oeCuenta = New e_CuentaContable
            oeCuenta.Equivale = 1
            oeCuenta.Id = cboCtaCmp.Value
            oeCuenta = loCtaCtble.Item(loCtaCtble.IndexOf(oeCuenta))
            Me.txtCtaCmp.Value = oeCuenta.Nombre
        End If
    End Sub

    Private Sub btnQuitarCC_Click(sender As Object, e As EventArgs) Handles btnQuitarCC.Click
        Try
            If griCtaCatServ.Selected.Rows.Count > 0 Then QuitarCC()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_CategoriaServicio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griCategoriaServicio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de categorías de servicio"

    Private Sub AsociarMenu()
        grid_CategoriaServicio.ContextMenuStrip = MenuContextual1
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
        If grid_CategoriaServicio.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class