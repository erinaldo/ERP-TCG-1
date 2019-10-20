'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_RendimientoCombustible
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_RendimientoCombustible = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_RendimientoCombustible()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de Variables"
    Dim oeCombo As e_Combo
    Dim olCombo As l_Combo
    Dim leTipoVehiculo As List(Of e_Combo)
    Dim oeUnidadMedida As e_UnidadMedida
    Dim olUnidadMedida As l_UnidadMedida
    Dim oeRendimientoCombustible As e_RendimientoCombustible
    Dim olRendimientoCombustible As l_RendimientoCombustible
    Dim leRendimientoCombustible As List(Of e_RendimientoCombustible)
    Dim _ingresando_datos As Boolean = False
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            If ficRendimientoD2.Tabs(0).Selected Then
                Listar()
                If GridRendCombustible.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
                GridRendCombustible.Focus()
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Inicializar()
            oeRendimientoCombustible = New e_RendimientoCombustible
            oeRendimientoCombustible.TipoOperacion = "I"
            oeRendimientoCombustible.Id = ""
            Operacion = "Nuevo"
            cboUnidadMedida.Enabled = False
            MostrarTabs(1, ficRendimientoD2, 1)
            ugb_Espera.Visible = False
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            cboTipoVehiculoMantenedor.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Inicializar()
            If EditarRendimientoCombustible() Then
                Operacion = "Editar"
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If
            ugb_Espera.Visible = False
            cboTipoVehiculoMantenedor.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRendimiento() Then
                MostrarTabs(0, ficRendimientoD2, 1)
                Consultar(True)
                If GridRendCombustible.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Else
                MostrarTabs(1, ficRendimientoD2, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try

            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarRendimiento() Then
                        MostrarTabs(0, ficRendimientoD2, 2)
                        Operacion = "Inicializa"
                        Consultar(True)
                    Else
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficRendimientoD2, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                    MyBase.Consultar(True)
                Case Windows.Forms.DialogResult.Cancel
                    _ingresando_datos = True
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With GridRendCombustible
                If .Rows.Count < 1 Then Throw New Exception("No existen filas a eliminar ")
                If IsNothing(GridRendCombustible.ActiveRow.Cells("Id").Value) Then Throw New Exception("Seleccione una fila válida")
                If IsDBNull(GridRendCombustible.ActiveRow.Cells("Id").Value) Then Throw New Exception("Seleccione una fila válida")
                    oeRendimientoCombustible = New e_RendimientoCombustible
                    oeRendimientoCombustible.Id = GridRendCombustible.ActiveRow.Cells("Id").Value
                    oeRendimientoCombustible = olRendimientoCombustible.Obtener(oeRendimientoCombustible)
                    If oeRendimientoCombustible.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la configuración de Rendimiento de Combustible ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            If olRendimientoCombustible.Eliminar(oeRendimientoCombustible) Then
                                Consultar(True)
                            End If
                        Else
                            Exit Sub
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                       End With
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If GridRendCombustible.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(GridRendCombustible)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub LlenarCombos()
        Try
            LlenarComboMaestro(cboZonaLista, ZonaD2Public, 0)
            LlenarComboMaestro(CboZonaMantenedor, ZonaD2Public.Where(Function(Item) Item.Nombre <> "TODOS").ToList, 0)
            leTipoVehiculo = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Id = ""
            oeCombo.Nombre = "TODOS"
            leTipoVehiculo.Add(oeCombo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "TipoVehiculo"
            oeCombo.Id = 1
            oeCombo.Descripcion = ""
            leTipoVehiculo.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            LlenarComboMaestro(cboTipoVehiculoLista, leTipoVehiculo, 0)
            LlenarComboMaestro(cboTipoVehiculoMantenedor, leTipoVehiculo.Where(Function(Item) Item.Nombre <> "TODOS").ToList, 0)
            oeUnidadMedida = New e_UnidadMedida
            oeUnidadMedida.TipoOperacion = ""
            oeUnidadMedida.Activo = True
            oeUnidadMedida.Asignado = True
            oeUnidadMedida.IdTipoUnidadMedida = "1CH000000002"
            LlenarComboMaestro(cboUnidadMedida, olUnidadMedida.Listar(oeUnidadMedida), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboGrilla()
        Try
            Dim ZonaD2 = New DataTable
            Dim TipoVehiculo As New DataTable
            ZonaD2 = olCombo.ComboGrilla(ZonaD2Public.Where(Function(i) i.Nombre <> "TODOS").ToList)
            CrearComboGrid("IdFlota", "Nombre", GridRendCombustible, ZonaD2, True)
            TipoVehiculo = olCombo.ComboGrilla(leTipoVehiculo.Where(Function(i) i.Nombre <> "TODOS").ToList)
            CrearComboGrid("IdTipoVehiculo", "Nombre", GridRendCombustible, TipoVehiculo, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeRendimientoCombustible = New e_RendimientoCombustible
            leRendimientoCombustible = New List(Of e_RendimientoCombustible)
            oeRendimientoCombustible.Id = ""
            oeRendimientoCombustible.IdTipoVehiculo = cboTipoVehiculoLista.Value
            oeRendimientoCombustible.IdFlota = cboZonaLista.Value
            leRendimientoCombustible = olRendimientoCombustible.Listar(oeRendimientoCombustible)
            GridRendCombustible.DataSource = leRendimientoCombustible
            GridRendCombustible.DataBind()
            If GridRendCombustible.Rows.Count > 0 Then
                GridRendCombustible.Rows(0).Activate()
                GridRendCombustible.Rows(0).Selected = True
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

    Private Sub Inicializar()
        Try
            cboTipoVehiculoMantenedor.SelectedIndex = 0
            CboZonaMantenedor.SelectedIndex = 0
            cboUnidadMedida.Value = "1PY000000006"
            numPeso.Value = 0.0
            numRendimiento.Value = 0.0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Funciones"

    Public Function EditarRendimientoCombustible() As Boolean
        Try
            If IsNothing(GridRendCombustible.ActiveRow.Cells("Id").Value) Then Throw New Exception("Seleccione una fila válida")
            If IsDBNull(GridRendCombustible.ActiveRow.Cells("Id").Value) Then Throw New Exception("Seleccione una fila válida")
            If GridRendCombustible.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeRendimientoCombustible = New e_RendimientoCombustible
                oeRendimientoCombustible.Id = GridRendCombustible.ActiveRow.Cells("Id").Value.ToString
                oeRendimientoCombustible.TipoOperacion = ""
                oeRendimientoCombustible = olRendimientoCombustible.Obtener(oeRendimientoCombustible)
                oeRendimientoCombustible.TipoOperacion = "A"
                cboTipoVehiculoMantenedor.Value = oeRendimientoCombustible.IdTipoVehiculo
                CboZonaMantenedor.Value = oeRendimientoCombustible.IdFlota
                numPeso.Value = oeRendimientoCombustible.Peso
                numRendimiento.Value = oeRendimientoCombustible.Rendimiento
                MostrarTabs(1, ficRendimientoD2, 1)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function

    Private Function GuardarRendimiento() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With oeRendimientoCombustible
                .IdFlota = CboZonaMantenedor.Value
                .IdTipoVehiculo = cboTipoVehiculoMantenedor.Value
                .IdUnidadMedida = cboUnidadMedida.Value
                .Peso = numPeso.Value
                .Rendimiento = numRendimiento.Value
                .UsuarioCreacion = gUsuarioSGI.Id
                .UsuarioModificacion = gUsuarioSGI.Id
            End With
            oeRendimientoCombustible.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olRendimientoCombustible.Guardar(oeRendimientoCombustible) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Operacion = "Inicializa"
                If GridRendCombustible.Rows.Count > 0 Then
                    MyBase.Consultar(True)
                Else
                    MyBase.Consultar()
                End If
            End If
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

#End Region

#Region "Eventos"

    Private Sub frm_RendimientoCombustible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GridRendCombustible.DisplayLayout.Bands(0).Columns("Peso").Header.Caption = "Peso" & Environment.NewLine & "(tm)"
            GridRendCombustible.DisplayLayout.Bands(0).Columns("Rendimiento").Header.Caption = "Rendimiento" & Environment.NewLine & "(gal/km)"
            gf_AsignarEventoSeleccionarTexto(Me)
            olUnidadMedida = New l_UnidadMedida
            olRendimientoCombustible = New l_RendimientoCombustible
            olCombo = New l_Combo
            LlenarCombos()
            ComboGrilla()
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_RendimientoCombustible_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_RendimientoCombustible_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub frm_RendimientoCombustible_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            Select Case ficRendimientoD2.SelectedTab.Index
                Case 0
                    If GridRendCombustible.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case 1
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GridRendCombustible_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles GridRendCombustible.BeforeRowsDeleted
        Eliminar()
        e.Cancel() = True
    End Sub

    Private Sub GridRendCombustible_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles GridRendCombustible.DoubleClickRow
        Editar()
    End Sub

    Private Sub frm_RendimientoCombustible_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub GridRendCombustible_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles GridRendCombustible.CellChange
        Try
            GridRendCombustible.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GridRendCombustible_ClickCellButton(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles GridRendCombustible.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "Guardar"
                    oeRendimientoCombustible = New e_RendimientoCombustible
                    With oeRendimientoCombustible
                        .TipoOperacion = "A"
                        .Id = RTrim(GridRendCombustible.ActiveRow.Cells("Id").Value)
                        .IdTipoVehiculo = RTrim(GridRendCombustible.ActiveRow.Cells("IdTipoVehiculo").Value)
                        .IdFlota = GridRendCombustible.ActiveRow.Cells("IdFlota").Value
                        .Peso = GridRendCombustible.ActiveRow.Cells("Peso").Value
                        .Rendimiento = GridRendCombustible.ActiveRow.Cells("Rendimiento").Value
                        .Activo = GridRendCombustible.ActiveRow.Cells("Activo").Value
                        .UsuarioModificacion = gUsuarioSGI.Id
                    End With
                    oeRendimientoCombustible.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olRendimientoCombustible.Guardar(oeRendimientoCombustible) Then
                        GridRendCombustible.ActiveRow.CellAppearance.BackColor = Me.ColorBloque.Color
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

    Private Sub frm_RendimientoCombustible_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case ficRendimientoD2.SelectedTab.Index
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

End Class