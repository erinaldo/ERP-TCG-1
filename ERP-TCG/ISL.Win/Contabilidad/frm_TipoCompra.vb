'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_TipoCompra
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Private WithEvents oeTablaCtbleDet As New e_TablaContableDet
    Private olTablaCtbleDet As New l_TablaContableDet
    Private WithEvents oeTipoCompra As New e_TipoCompra
    Private olTipoCompra As New l_TipoCompra
    Private Ejercicio As Integer = 0
    Private Shared instancia As frm_TipoCompra = Nothing
    Private Shared Operacion As String
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String
    Private TipoCompra As New List(Of e_TipoCompra)

#End Region

#Region "Definición del Formulario base"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_TipoCompra()
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
            If grTablaCtbleDet.Rows.Count > 0 Then
                'MyBase.Consultar(Activo)
                ControlBoton(1, 0, 1)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If ValidarGrilla(grTablaCtbleDet, "Tabla Contable - Tipo Compra") Then
                If grTablaCtbleDet.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    Inicializar()
                    MostrarTipoCompra()
                    oeTipoCompra.TipoOperacion = "A"
                    Me.Año.Focus()
                    oeTipoCompra.Modificado = False
                    Operacion = "Editar"
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
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
            If Me.grTipoCompra.Rows.Count > 0 Then
                If GuardarTipoCompra() Then
                    MyBase.Guardar()
                Else
                    MostrarTabs(1, tc_TipoCompra, 1)
                End If
            Else
                Throw New Exception("Inserte Detalles")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTipoCompra.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarTipoCompra() Then
                            MostrarTabs(0, tc_TipoCompra, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 0, 1) 'activa desactiva botonera
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tc_TipoCompra, 1)
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        _ingresando_datos = False
                        MostrarTabs(0, tc_TipoCompra, 2)
                        ControlBoton(1, 0, 1)
                End Select
            Else
                MostrarTabs(0, tc_TipoCompra, 2)
                _ingresando_datos = False
                'MyBase.Consultar(True)
                ControlBoton(1, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grTipoCompra
                If ValidarGrilla(grTipoCompra, "Tipo Compra") Then
                    If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                        oeTablaCtbleDet.Id = .ActiveRow.Cells("IdTablaContableDet").Value
                        oeTablaCtbleDet = olTablaCtbleDet.Obtener(oeTablaCtbleDet)
                        oeTipoCompra.IdTablaContableDet = oeTablaCtbleDet.Id
                        oeTipoCompra.Id = .ActiveRow.Cells("Id").Value.ToString
                        If oeTipoCompra.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Tipo de Compra Asociado a: " & _
                                     oeTablaCtbleDet.Nombre & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeTipoCompra.TipoOperacion = "E"
                                olTipoCompra.Eliminar(oeTipoCompra)
                                MostrarTipoCompra()
                                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
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
            mensajeEmergente.Problema("Tiene que Registrar el Tipo Compra antes de poder Eliminarlo")
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

            If grTipoCompra.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grTipoCompra)

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
        oeTablaCtbleDet = New e_TablaContableDet
        Me.Año.Año = Date.Now.Year
        cboCuenta60.SelectedIndex = -1
        cboCuenta61.SelectedIndex = -1
        Me.txtCuenta.Text = String.Empty
        Me.txtCuenta60.Text = String.Empty
        Me.txtCuenta61.Text = String.Empty
        TipoCompra = New List(Of e_TipoCompra)
        TipoCompra.Clear()
        Me.grTipoCompra.DataSource = TipoCompra
        Me.grTipoCompra.DataBind()
        MostrarTabs(1, tc_TipoCompra, 1)
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeTablaCtbleDet = New e_TablaContableDet
            oeTablaCtbleDet.Activo = True
            oeTablaCtbleDet.TipoOperacion = "C"
            LimpiaGrid(grTipoCompra, odTipoCompra)
            With grTablaCtbleDet
                .DataSource = olTablaCtbleDet.Listar(oeTablaCtbleDet)
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grTipoCompra.Focus()
    End Sub

    Private Function GuardarTipoCompra() As Boolean
        Try
            If Validar() Then
                oeTablaCtbleDet.TipoOperacion = "X"
                oeTablaCtbleDet.ListaTipoCompra = grTipoCompra.DataSource
                oeTablaCtbleDet.PrefijoID = gs_PrefijoIdSucursal '@0001
                olTablaCtbleDet.Guardar(oeTablaCtbleDet)
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente")
                MostrarTabs(0, tc_TipoCompra, 2)
                Consultar(_Activo)
                grTipoCompra.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(txtCuenta.Text, "Ingrese la Cuenta")
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub MostrarTipoCompra()
        Try
            If grTablaCtbleDet.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeTablaCtbleDet.Id = grTablaCtbleDet.ActiveRow.Cells("Id").Value.ToString
                oeTablaCtbleDet.TipoOperacion = "1"
                oeTablaCtbleDet = olTablaCtbleDet.Obtener(oeTablaCtbleDet)
                Me.txtNombre.Text = oeTablaCtbleDet.Nombre
                oeTipoCompra = New e_TipoCompra

                oeTipoCompra.TipoOperacion = "L"
                oeTipoCompra.IdTablaContableDet = oeTablaCtbleDet.Id
                oeTipoCompra.Activo = True
                grTipoCompra.DataSource = olTipoCompra.Listar(oeTipoCompra)
                oeTipoCompra = olTipoCompra.Obtener(oeTipoCompra)
                Me.txtCuenta.Text = oeTipoCompra.Cuenta
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboCuenta()
        Try
            With Me.cboCuenta60
                If Ejercicio <> Año.Año Then
                    Dim oeCuentaCtable As New e_CuentaContable
                    Dim leCuentaCtable As New List(Of e_CuentaContable)
                    Dim olCuentaContable As New l_CuentaContable
                    oeCuentaCtable.Activo = True
                    oeCuentaCtable.Movimiento = 1
                    oeCuentaCtable.Ejercicio = Año.Año
                    leCuentaCtable.AddRange(olCuentaContable.Listar(oeCuentaCtable))
                    .ValueMember = "Id"
                    .DisplayMember = "Cuenta"
                    .DataSource = leCuentaCtable
                    Me.cboCuenta61.ValueMember = "Id"
                    Me.cboCuenta61.DisplayMember = "Cuenta"
                    Me.cboCuenta61.DataSource = leCuentaCtable
                    Ejercicio = Año.Año
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub AgregarTipoCompra()
        If ValidarEjercicio(Me.grTipoCompra, Me.Año) AndAlso Validar() Then
            oeTablaCtbleDet.Id = grTablaCtbleDet.ActiveRow.Cells("Id").Value.ToString
            oeTipoCompra.IdTablaContableDet = oeTablaCtbleDet.Id
            oeTablaCtbleDet.ListaTipoCompra = grTipoCompra.DataSource
            oeTipoCompra.TipoOperacion = "I"
            oeTipoCompra.Id = ""
            oeTipoCompra.Ejercicio = Año.Año
            oeTipoCompra.IdCuentaContable60 = cboCuenta60.Value
            oeTipoCompra.NombreCuenta60 = Me.cboCuenta60.Text
            oeTipoCompra.NombreCuenta61 = Me.cboCuenta61.Text
            oeTipoCompra.IdCuentaContable61 = cboCuenta61.Value
            oeTipoCompra.Cuenta = Me.txtCuenta.Text
            oeTipoCompra.Activo = True
            oeTipoCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeTablaCtbleDet.ListaTipoCompra.Add(oeTipoCompra)
            grTipoCompra.DataBind()
            oeTipoCompra = New e_TipoCompra
            oeTipoCompra.Modificado = True
        End If
    End Sub

    Private Sub QuitarDetalle()
        Try
            oeTipoCompra = New e_TipoCompra
            oeTipoCompra = grTipoCompra.ActiveRow.ListObject
            If oeTipoCompra.Id.Length <> 0 Then
                oeTipoCompra.TipoOperacion = "E"
                grTipoCompra.ActiveRow.Hidden = True
            Else
                oeTablaCtbleDet.ListaTipoCompra.Remove(oeTipoCompra)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ItemGasto_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case _Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                MostrarTabs(0, tc_TipoCompra)
                ''Consultar(True)
                InicializaTiempo()
            Case "Ayuda"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_ItemGasto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ItemGasto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub txtCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuenta.KeyDown
        oeTipoCompra.Modificado = 1
    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuenta.KeyPress
        oeTipoCompra.Modificado = 1
    End Sub

    Private Sub txtCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuenta.ValueChanged
        oeTipoCompra.Cuenta = Me.txtCuenta.Text
    End Sub

    Private Sub frm_ItemGasto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tc_TipoCompra)
            grTipoCompra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            grTipoCompra.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            Tiempo1.Enabled = False
            InicializaTiempo()
            ComboCuenta()
            Me.Año.Año = Date.Now.Year
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grTipoCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub grTipoCompra_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)

        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub Año_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Año.Validated
        ComboCuenta()
    End Sub

    Private Sub grTablaCtbleDet_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grTablaCtbleDet.DoubleClick
        If grTablaCtbleDet.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btn_TipoCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddTipoCompra.Click
        AgregarTipoCompra()
    End Sub

    Private Sub MenuDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuDetalle.Opening
        If Me.grTablaCtbleDet.Rows.Count > 0 Then
            MenuDetalle.Items("EditarToolStripMenuItem").Visible = 1
            MenuDetalle.Items("mnuEliminar").Visible = 1
        Else
            MenuDetalle.Items("EditarToolStripMenuItem").Visible = 0
            MenuDetalle.Items("mnuEliminar").Visible = 0
        End If
    End Sub

    Private Sub btn_DelTipoCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DelTipoCompra.Click
        Try
            If grTipoCompra.Selected.Rows.Count > 0 Then QuitarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboCuenta60_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuenta60.ValueChanged
        Try
            Dim oeCta As New e_CuentaContable
            If Me.cboCuenta60.SelectedIndex <> -1 Then
                If Me.cboCuenta60.Value = Me.cboCuenta61.Value Then
                    Me.cboCuenta60.SelectedIndex = -1
                    Me.txtCuenta60.Text = String.Empty
                    Throw New Exception("No Puede Seleccionar la Cuenta61 para la Cuenta60")
                Else
                    oeCta = cboCuenta60.Items(cboCuenta60.SelectedIndex).ListObject
                    txtCuenta60.Text = oeCta.Nombre
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboCuenta61_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuenta61.ValueChanged
        Try
            Dim oeCta As New e_CuentaContable
            If Me.cboCuenta61.SelectedIndex <> -1 Then
                If Me.cboCuenta61.Value = Me.cboCuenta60.Value Then
                    Me.cboCuenta61.SelectedIndex = -1
                    Me.txtCuenta61.Text = String.Empty
                    Throw New Exception("No puede Seleccionar la Cuenta60 para la Cuenta61")
                End If
                oeCta = cboCuenta61.Items(cboCuenta61.SelectedIndex).ListObject
                txtCuenta61.Text = oeCta.Nombre
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

End Class