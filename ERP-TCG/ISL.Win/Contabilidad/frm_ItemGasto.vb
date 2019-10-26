'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports ISL.Controles
Imports System.ComponentModel
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors

Public Class frm_ItemGasto
    Inherits frm_MenuPadre

#Region "Declaración de variables"

    Private WithEvents oeItemGasto As New e_ItemGasto
    Dim olItemGasto As New l_ItemGasto
    Dim instancia As frm_ItemGasto = Nothing
    Dim oeCuentaItemGasto As New e_CuentaItemGasto
    Dim olCuentaItemGasto As New l_CuentaItemGasto
    Dim Operacion As String
    Dim lstItemGasto As New BindingList(Of e_ItemGasto)
    Dim ListaCuenta As New List(Of e_Combo)
    Dim ListaCuentaItemGasto As New List(Of e_CuentaItemGasto)
    Dim oeCombo As New e_Combo
    Dim olCombo As New l_Combo
    Dim ListGastoFuncion As New List(Of e_Combo)
#End Region

#Region "Definición del Formulario base"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ItemGasto()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
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
        Try
            Inicializar()
            oeItemGasto.Modificado = False
            txtNombre.Focus()
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If ValidarGrilla(griLista, "Item Gasto") Then
                If griLista.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    Inicializar()
                    MostrarItemGasto()
                    oeItemGasto.Modificado = False
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
            If GuardarItemGasto() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcItemGasto, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griLista
                If ValidarGrilla(griLista, "Item Gasto") Then
                    If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                        oeItemGasto.Id = .ActiveRow.Cells("ID").Value
                        If oeItemGasto.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Item Gasto: " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeItemGasto.TipoOperacion = "E"
                                oeItemGasto.UsuarioCrea = gUsuarioSGI.Id
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

#Region "Métodos"

    Private Sub Inicializar()
        Try
            oeItemGasto = New e_ItemGasto
            txtNombre.Text = String.Empty
            ListaCuentaItemGasto = New List(Of e_CuentaItemGasto)
            griCuentaItemGasto.DataSource = ListaCuentaItemGasto
            MostrarTabs(1, tcItemGasto, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeItemGasto = New e_ItemGasto
            oeItemGasto.TipoOperacion = ""
            oeItemGasto.Ejercicio = AñoLista.Año
            DatosItemGasto(olItemGasto.ListarBind(oeItemGasto))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griLista.Focus()
    End Sub

    Public Sub DatosItemGasto(ByVal lstDatos As BindingList(Of e_ItemGasto))
        Dim selectedDatos As New BindingList(Of e_ItemGasto)
        For Each dato As e_ItemGasto In lstDatos
            If String.IsNullOrEmpty(dato.TipoOperacion) OrElse Not dato.TipoOperacion.ToUpper().Equals("E") Then
                selectedDatos.Add(dato)
            End If
        Next
        Me.griLista.DataSource = selectedDatos
        griLista.DataBind()
    End Sub

    Private Function GuardarItemGasto() As Boolean
        Try
            If Validar() Then
                With oeItemGasto
                    .TipoOperacion = "I"
                    .IdTablaContableDet = cboGastoFuncion.Value
                    .UsuarioCrea = gUsuarioSGI.Id
                    .ListaCuentaItemGasto = griCuentaItemGasto.DataSource
                End With
                oeItemGasto.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olItemGasto.Guardar(oeItemGasto) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                    MostrarTabs(0, tcItemGasto, 2)
                    Consultar(_Activo)
                    griLista.Focus()
                    Return True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(txtNombre.Text, "Ingrese el Nombre")
            'ValidarCombo(cboCuenta, "Cuenta")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub MostrarItemGasto()
        Try
            If griLista.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeItemGasto = New e_ItemGasto
                oeItemGasto.Id = griLista.ActiveRow.Cells("Id").Value.ToString
                oeItemGasto.TipoOperacion = "X"
                oeItemGasto = olItemGasto.Obtener(oeItemGasto)
                txtNombre.Text = oeItemGasto.Nombre
                cboGastoFuncion.Value = oeItemGasto.IdTablaContableDet
                oeCuentaItemGasto = New e_CuentaItemGasto
                oeCuentaItemGasto.TipoOperacion = "L"
                oeCuentaItemGasto.IdItemGasto = oeItemGasto.Id
                griCuentaItemGasto.DataSource = olCuentaItemGasto.Listar(oeCuentaItemGasto)
            End If
        Catch ex As Exception
            Throw ex
        End Try
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
            ListGastoFuncion = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "GASTO FUNCION"
            ListGastoFuncion.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            LlenarComboMaestro(cboGastoFuncion, ListGastoFuncion, 0)
            CrearComboGrid("IdTablaContableDet", "Nombre", griLista, olCombo.ComboGrilla(ListGastoFuncion), True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_ListaItemGasto_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeItemGasto.Nombre = txtNombre.Value
    End Sub

    Private Sub AñoGuarda_Validated(sender As Object, e As EventArgs) Handles numEjercicio.Validated
        oeCombo = New e_Combo
        olCombo = New l_Combo
        oeCombo.Id = numEjercicio.Año
        oeCombo.Nombre = "CuentaContable"
        ListaCuenta = New List(Of e_Combo)
        ListaCuenta.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        LlenarComboMaestro(cboCuenta, ListaCuenta, 0)
    End Sub

    Private Sub gridLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If griLista.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griLista_CellChange(sender As Object, e As CellEventArgs) Handles griLista.CellChange
        griLista.UpdateData()
    End Sub

    Private Sub griLista_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
        Me.Eliminar()
    End Sub

    Private Sub griCuentaItemGasto_CellChange(sender As Object, e As CellEventArgs) Handles griCuentaItemGasto.CellChange
        griCuentaItemGasto.UpdateData()
    End Sub

    Private Sub griCuentaItemGasto_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griCuentaItemGasto.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub cboGastoFuncion_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboGastoFuncion.InitializeLayout
        With cboGastoFuncion.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Header.Caption = "Nombre"
            .Columns("Nombre").Width = 300
            .Columns("Descripcion").Hidden = True
        End With
    End Sub

    Private Sub griLista_ClickCellButton(sender As Object, e As CellEventArgs) Handles griLista.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "IdCuentaContable"
                    oeItemGasto = New e_ItemGasto
                    With oeItemGasto
                        .TipoOperacion = "L"
                        .Nombre = RTrim(griLista.ActiveRow.Cells("Nombre").Value)
                        .Id = RTrim(griLista.ActiveRow.Cells("Id").Value)
                        .IdTablaContableDet = RTrim(griLista.ActiveRow.Cells("IdTablaContableDet").Value)
                        .UsuarioCrea = gUsuarioSGI.Id
                    End With
                    oeItemGasto.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olItemGasto.Guardar(oeItemGasto) Then
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

    Private Sub btnAgregarCg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCg.Click
        Try
            If cboCuenta.Value <> "" Then
                oeItemGasto.ListaCuentaItemGasto = griCuentaItemGasto.DataSource
                With oeCuentaItemGasto
                    .TipoOperacion = "I"
                    .Id = ""
                    .IdItemGasto = oeItemGasto.Id
                    .IdCuentaContable = cboCuenta.Value
                    .Cuenta = cboCuenta.Text
                    .Ejercicio = numEjercicio.Año
                    .Equivale = 2
                End With
                If oeItemGasto.ListaCuentaItemGasto.Contains(oeCuentaItemGasto) Then
                    oeCuentaItemGasto = oeItemGasto.ListaCuentaItemGasto.Item(oeItemGasto.ListaCuentaItemGasto.IndexOf(oeCuentaItemGasto))
                    oeCuentaItemGasto.TipoOperacion = "A"
                    oeCuentaItemGasto.IdCuentaContable = cboCuenta.Value
                    oeCuentaItemGasto.Cuenta = cboCuenta.Text
                Else
                    oeItemGasto.ListaCuentaItemGasto.Add(oeCuentaItemGasto)
                End If
                griCuentaItemGasto.DataBind()
                oeCuentaItemGasto = New e_CuentaItemGasto
            Else
                numAño.Focus()
                Throw New Exception("Seleccione Cuenta Contable para el Ejercicio")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuCabecera.Opening
        MenuCabecera.Items("InsertarToolStripMenuItem").Visible = True
        If griLista.Selected.Rows.Count > 0 Then
            MenuCabecera.Items("ActualizarToolStripMenuItem").Visible = True
            MenuCabecera.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuCabecera.Items("ActualizarToolStripMenuItem").Visible = False
            MenuCabecera.Items("EliminarToolStripMenuItem").Visible = False
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