'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_TipoVenta
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Private WithEvents oeTablaCtbleDet As New e_TablaContableDet
    Private olTablaCtbleDet As New l_TablaContableDet
    Private WithEvents oeTipoVenta As New e_TipoVenta
    Private olTipoVenta As New l_TipoVenta
    Private Ejercicio As Integer = 0
    Private Shared instancia As frm_TipoVenta = Nothing
    Private Shared Operacion As String
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String
    Private TipoVenta As New List(Of e_TipoVenta)


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
            instancia = New frm_TipoVenta()
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
            If ValidarGrilla(grTablaCtbleDet, "Tabla Contable - Tipo Venta") Then
                If grTablaCtbleDet.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    Inicializar()
                    MostrarTipoVenta()
                    oeTipoVenta.TipoOperacion = "A"
                    Me.Año.Focus()
                    oeTipoVenta.Modificado = False
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
            If GuardarTipoVenta() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tc_TipoVenta, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTipoVenta.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarTipoVenta() Then
                            MostrarTabs(0, tc_TipoVenta, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 0, 1) 'activa desactiva botonera
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tc_TipoVenta, 1)
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        _ingresando_datos = False
                        MostrarTabs(0, tc_TipoVenta, 2)
                        ControlBoton(1, 0, 1)
                End Select
            Else
                MostrarTabs(0, tc_TipoVenta, 2)
                _ingresando_datos = False
                ControlBoton(1, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grTipoVenta
                If ValidarGrilla(grTipoVenta, "Tipo Venta") Then
                    If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                        oeTablaCtbleDet.Id = .ActiveRow.Cells("ID").Value
                        oeTablaCtbleDet = olTablaCtbleDet.Obtener(oeTablaCtbleDet)
                        oeTipoVenta.IdTablaContableDet = oeTablaCtbleDet.Id
                        oeTipoVenta.Id = .ActiveRow.Cells("Id").Value.ToString
                        If oeTipoVenta.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Tipo de Venta Asociado a: " & _
                                     oeTablaCtbleDet.Nombre & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeTipoVenta.TipoOperacion = "E"
                                olTipoVenta.Eliminar(oeTipoVenta)
                                MostrarTipoVenta()
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
            mensajeEmergente.Problema("Tiene que Registrar el Tipo Venta antes de poder Eliminarla")
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
            If grTipoVenta.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grTipoVenta)
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
        cboCuenta.SelectedIndex = -1
        Me.txtCuenta.Text = String.Empty
        TipoVenta = New List(Of e_TipoVenta)
        TipoVenta.Clear()
        Me.grTipoVenta.DataSource = TipoVenta
        Me.grTipoVenta.DataBind()
        MostrarTabs(1, tc_TipoVenta, 1)
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeTablaCtbleDet = New e_TablaContableDet
            oeTablaCtbleDet.Activo = True
            oeTablaCtbleDet.TipoOperacion = "V"
            LimpiaGrid(grTipoVenta, odTipoVenta)
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
        grTipoVenta.Focus()
    End Sub

    Private Function GuardarTipoVenta() As Boolean
        Try
            oeTablaCtbleDet.TipoOperacion = "X"
            oeTablaCtbleDet.ListaTipoVenta = grTipoVenta.DataSource
            oeTablaCtbleDet.PrefijoID = gs_PrefijoIdSucursal '@0001
            olTablaCtbleDet.Guardar(oeTablaCtbleDet)
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente")
            MostrarTabs(0, tc_TipoVenta, 2)
            Consultar(_Activo)
            grTipoVenta.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            ValidarCombo(cboCuenta, "Cuenta")
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub MostrarTipoVenta()
        Try
            If grTablaCtbleDet.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeTablaCtbleDet.Id = grTablaCtbleDet.ActiveRow.Cells("Id").Value.ToString
                oeTablaCtbleDet.TipoOperacion = "1"
                oeTablaCtbleDet = olTablaCtbleDet.Obtener(oeTablaCtbleDet)
                Me.txtNombre.Text = oeTablaCtbleDet.Nombre
                oeTipoVenta = New e_TipoVenta
                oeTipoVenta.TipoOperacion = "L"
                oeTipoVenta.IdTablaContableDet = oeTablaCtbleDet.Id
                oeTipoVenta.Activo = True
                grTipoVenta.DataSource = olTipoVenta.Listar(oeTipoVenta)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboCuenta()
        Try
            With Me.cboCuenta
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
                    Ejercicio = Año.Año
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub AgregarTipoVenta()
        If ValidarEjercicio(Me.grTipoVenta, Me.Año) AndAlso Validar() Then
            oeTablaCtbleDet.Id = grTablaCtbleDet.ActiveRow.Cells("Id").Value.ToString
            oeTipoVenta.IdTablaContableDet = oeTablaCtbleDet.Id
            oeTablaCtbleDet.ListaTipoVenta = grTipoVenta.DataSource
            oeTipoVenta.TipoOperacion = "I"
            oeTipoVenta.Id = ""
            oeTipoVenta.Ejercicio = Año.Año
            oeTipoVenta.IdCuentaContable = Me.cboCuenta.Value
            oeTipoVenta.Cuenta = Me.cboCuenta.Text
            oeTipoVenta.Activo = True
            oeTipoVenta.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeTablaCtbleDet.ListaTipoVenta.Add(oeTipoVenta)
            grTipoVenta.DataBind()
            oeTipoVenta = New e_TipoVenta
            oeTipoVenta.Modificado = True
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_TipoVenta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case _Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                MostrarTabs(0, tc_TipoVenta)
                ''Consultar(True)
                InicializaTiempo()
            Case "Ayuda"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_TipoVenta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_TipoVenta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_TipoVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tc_TipoVenta)
            grTipoVenta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            grTipoVenta.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            Tiempo1.Enabled = False
            InicializaTiempo()
            ComboCuenta()
            Me.Año.Año = Date.Now.Year
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub


    Private Sub grTablaCtbleDet_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grTablaCtbleDet.DoubleClick
        If grTablaCtbleDet.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grTipoVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub grTipoVenta_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
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

    Private Sub btn_TipoVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddTipoVenta.Click
        AgregarTipoVenta()
    End Sub

    Private Sub btn_DelTipoVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDetalle.Click
        Try
            If grTipoVenta.Selected.Rows.Count > 0 Then QuitarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
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

    Private Sub cboCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuenta.ValueChanged
        Dim oeCta As New e_CuentaContable
        If Me.cboCuenta.SelectedIndex <> -1 Then
            oeCta = Me.cboCuenta.Items(Me.cboCuenta.SelectedIndex).ListObject
            Me.txtCuenta.Text = oeCta.Nombre
        End If
    End Sub

#End Region

    Private Sub QuitarDetalle()
        Try
            oeTipoVenta = New e_TipoVenta
            oeTipoVenta = grTipoVenta.ActiveRow.ListObject
            If oeTipoVenta.Id.Length <> 0 Then
                oeTipoVenta.TipoOperacion = "E"
                grTipoVenta.ActiveRow.Hidden = True
            Else
                oeTablaCtbleDet.ListaTipoVenta.Remove(oeTipoVenta)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class