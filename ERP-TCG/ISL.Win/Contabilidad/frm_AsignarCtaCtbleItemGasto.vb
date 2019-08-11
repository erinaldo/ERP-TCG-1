Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports ISL.Controles

Public Class frm_AsignarCtaCtbleItemGasto
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Private WithEvents oeItemGasto As New e_ItemGasto
    Private olItemGasto As New l_ItemGasto
    Private Ejercicio As Integer = 0
    Private Shared instancia As frm_AsignarCtaCtbleItemGasto = Nothing
    Private WithEvents oeCuentaItemGasto As New e_CuentaItemGasto
    Private olCuentaItemGasto As New l_CuentaItemGasto
    Private Shared Operacion As String
    Dim CuentaItemGasto As New List(Of e_CuentaItemGasto)

#End Region

#Region "Definición del Formulario base"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_AsignarCtaCtbleItemGasto()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If grid_ListaItemGasto.Rows.Count > 0 Then
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
            Inicializar()
            Me.Año1.Año = Date.Now.Year
            oeItemGasto.TipoOperacion = "I"
            oeItemGasto.Modificado = False
            'grDetalleCtaGto.DataSource = CuentaItemGasto
            RediseñarGridCta()
            txtNombre.Focus()
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If ValidarGrilla(grid_ListaItemGasto, "Item Gasto") Then
                If grid_ListaItemGasto.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    Inicializar()
                    MostrarItemGasto()
                    oeItemGasto.TipoOperacion = "A"
                    oeItemGasto.Modificado = False
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
            If GuardarItemGasto() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcItemGasto, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeItemGasto.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If Not GuardarItemGasto() Then
                            MostrarTabs(1, tcItemGasto)
                            Consultar(_Activo) 'activa desactiva botonera
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcItemGasto, 2)
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, tcItemGasto, 2)
                Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_ListaItemGasto
                If ValidarGrilla(grid_ListaItemGasto, "Item Gasto") Then
                    If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                        oeItemGasto.Id = .ActiveRow.Cells("ID").Value
                        If oeItemGasto.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Item Gasto: " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeItemGasto.TipoOperacion = "E"
                                olItemGasto.Eliminar(oeItemGasto)
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
            Throw ex
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

            If grid_ListaItemGasto.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_ListaItemGasto)

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
        Try
            oeItemGasto = New e_ItemGasto
            txtNombre.Text = String.Empty
            cboCuenta.SelectedIndex = -1
            'verActivo.Checked = True
            'verActivo.Visible = Not oeItemGasto.Activo
            CuentaItemGasto = New List(Of e_CuentaItemGasto)
            CuentaItemGasto.Clear()
            Me.grDetalleCtaGto.DataSource = CuentaItemGasto
            grDetalleCtaGto.DataBind()
            MostrarTabs(1, tcItemGasto, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeItemGasto = New e_ItemGasto
            oeItemGasto.Activo = Activo
            oeItemGasto.TipoOperacion = "M"
            oeItemGasto.Ejercicio = Año2.Año
            LimpiaGrid(grid_ListaItemGasto, UltraDataSource2)
            With grid_ListaItemGasto
                .DataSource = olItemGasto.Listar(oeItemGasto)
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                'Ubica el cursor el el primer registro de la grilla
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
            grid_ListaItemGasto.Focus()
        End Try
    End Sub

    Private Function GuardarItemGasto() As Boolean
        Try
            If Validar() Then
                oeItemGasto.ListaCuentaItemGasto = grDetalleCtaGto.DataSource
                If olItemGasto.Guardar(oeItemGasto) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente")
                    MostrarTabs(0, tcItemGasto, 2)
                    Consultar(_Activo)
                    grid_ListaItemGasto.Focus()
                    Return True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(txtNombre.Text, "Ingrese el Nombre")
            ValidarCombo(cboCuenta, "Cuenta")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub MostrarItemGasto()
        Try
            If grid_ListaItemGasto.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeItemGasto.Id = grid_ListaItemGasto.ActiveRow.Cells("Id").Value.ToString
                oeItemGasto.TipoOperacion = "X"
                oeItemGasto = olItemGasto.Obtener(oeItemGasto)
                txtNombre.Text = oeItemGasto.Nombre
                cboCuenta.Value = oeItemGasto.IdCuentaContable
                'verActivo.Checked = oeItemGasto.Activo
                'verActivo.Visible = Not oeItemGasto.Activo
                grDetalleCtaGto.Visible = True
                oeCuentaItemGasto = New e_CuentaItemGasto
                oeCuentaItemGasto.TipoOperacion = "L"
                oeCuentaItemGasto.IdItemGasto = oeItemGasto.Id
                oeCuentaItemGasto.Activo = True
                grDetalleCtaGto.DataSource = olCuentaItemGasto.Listar(oeCuentaItemGasto)
                RediseñarGridCta()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboCuenta()
        Try
            With cboCuenta
                If Ejercicio <> Año1.Año Then

                    Dim oeCuentaCtable As New e_CuentaContable
                    Dim leCuentaCtable As New List(Of e_CuentaContable)
                    Dim olCuentaContable As New l_CuentaContable
                    oeCuentaCtable.Activo = True
                    oeCuentaCtable.Movimiento = 1
                    oeCuentaCtable.Ejercicio = Año1.Año
                    leCuentaCtable.AddRange(olCuentaContable.Listar(oeCuentaCtable))
                    '---------------------para llenar combo en grilla
                    If Ejercicio = 0 Then
                        With grid_ListaItemGasto.DisplayLayout
                            If .Bands(0).Columns.Exists("IdCuentaContable") Then
                                .ValueLists.Clear()
                                .ValueLists.Add("IdCuentaContable")
                            End If
                        End With

                    End If

                    With grid_ListaItemGasto.DisplayLayout.ValueLists("IdCuentaContable").ValueListItems
                        .Clear()
                        For Each oeCC As e_CuentaContable In leCuentaCtable
                            .Add(oeCC.Id, oeCC.Cuenta)
                        Next
                    End With
                    CrearComboGrid3("IdCuentaContable", "Cuenta", grid_ListaItemGasto, True)
                    '------------------------------------------
                    .ValueMember = "Id"
                    .DisplayMember = "Cuenta"
                    .DataSource = leCuentaCtable
                    Ejercicio = Año1.Año
                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub AgregarCuentasGasto()
        Try
            'If Not ValidarEjercicio(Me.grDetalleCtaGto, Me.Año1) Then
            '    Exit Sub
            'Else
            For i = 0 To grDetalleCtaGto.Rows.Count - 1
                If Año1.Año = grDetalleCtaGto.Rows(i).Cells("Ejercicio").Value AndAlso cboCuenta.Value = grDetalleCtaGto.Rows(i).Cells("IdCuentaContable").Value Then
                    mensajeEmergente.Confirmacion("Ya existe la cuenta y el ejercicio con el Item Gasto")
                    Exit Sub
                End If
            Next

            If Not Validar() Then
                Exit Sub
            Else
                oeItemGasto.ListaCuentaItemGasto = grDetalleCtaGto.DataSource
                oeCuentaItemGasto.Id = ""
                oeCuentaItemGasto.IdItemGasto = ""
                oeCuentaItemGasto.IdCuentaContable = cboCuenta.Value
                oeCuentaItemGasto.Cuenta = cboCuenta.Text
                oeCuentaItemGasto.Ejercicio = Año1.Año
                oeCuentaItemGasto.Activo = True
                oeItemGasto.ListaCuentaItemGasto.Add(oeCuentaItemGasto)
                grDetalleCtaGto.DataBind()
                oeCuentaItemGasto = New e_CuentaItemGasto
            End If
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub RediseñarGridCta()
        With grDetalleCtaGto
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCuentaContable").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdItemGasto").Hidden = True
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
        End With
    End Sub

    Private Sub btnAgregarCg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCg.Click
        AgregarCuentasGasto()
    End Sub

#End Region

#Region "Eventos"

    Private Sub oeItemGasto_DatoCambiado() Handles oeItemGasto.DatoCambiado
        oeItemGasto.Modificado = True
    End Sub

    Private Sub frm_ItemGasto_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case _Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                MostrarTabs(0, tcItemGasto)
                'Consultar(True)
                InicializaTiempo()
            Case "Ayuda"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_ItemGasto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ItemGasto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ItemGasto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tcItemGasto)
            grid_ListaItemGasto.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            grid_ListaItemGasto.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            ComboCuenta()
            Me.Año1.Año = Date.Now.Year
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_ListaItemGasto_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_ListaItemGasto.DoubleClick
        If grid_ListaItemGasto.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_ListaItemGasto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub grid_ListaItemGasto_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)

        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeItemGasto.Nombre = txtNombre.Value
    End Sub

    Private Sub cboCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuenta.ValueChanged
        oeItemGasto.IdCuentaContable = cboCuenta.Value
    End Sub

    'Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    oeItemGasto.Activo = verActivo.Checked
    'End Sub

    Private Sub Año1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Año1.Validated
        ComboCuenta()
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If grid_ListaItemGasto.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
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
#End Region

End Class