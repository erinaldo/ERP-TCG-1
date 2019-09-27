'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource

Public Class frm_ControlGuias
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ControlGuias = Nothing
    Private Shared Operacion As String
    Private Estado As String
    ''' <summary>
    ''' Instancia unica de Formulario: frm_DemandaRapida
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ControlGuias()
        End If
        instancia.Activate()
        Return instancia
    End Function


#Region "Declaración de variables"

    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeGuiasControl As New e_GuiasControl

    Dim oeGuiasTalonarios As New e_GuiasTalonarios
    Dim olGuiasControl As New l_GuiasControl

    Dim _ingresando_datos As Boolean = False

    Dim Prefijo As New l_Configuracion

#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Estado = IIf(Activo, " Activo", " Inactivo")
            oeGuiasControl = New e_GuiasControl
            oeGuiasControl.Activo = Activo
            Listar()
            If griLista.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
            griLista.Focus()
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
            Dim ListaGuiasTalonarios As New List(Of e_GuiasTalonarios)
            Operacion = "Nuevo"
            Inicializar()
            MostrarTabs(1, ficControlGuias, 1)
            griTalonarios.DataSource = ListaGuiasTalonarios
            LlenaCombos("Nuevo")
            MyBase.Nuevo()
            ugb_Espera.Visible = False
            oeGuiasControl.Modificado = False
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
            LlenaCombos("Editar")
            If EditarControlGuias() Then
                Operacion = "Editar"
                MostrarTabs(1, ficControlGuias, 1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If
            ugb_Espera.Visible = False
            oeGuiasControl.Modificado = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarControlGuias() Then
                MostrarTabs(0, ficControlGuias, 2)
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficControlGuias, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarControlGuias() Then
                        MostrarTabs(0, ficControlGuias, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                    Else
                        _ingresando_datos = True
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficControlGuias, 2)
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
            If ValidarGrilla(griLista, "Ruta") Then MyBase.Eliminar()
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

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ninguna guía para exportar al Excel")
            Exportar_Excel(griLista)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ControlGuias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ColorTerminado.Color = Color.DodgerBlue
        ColorAnulado.Color = Color.Red
        ColorEnUso.Color = Color.White
        ColorStock.Color = Color.Yellow
        ColorStockTalonarios.Color = Color.PowderBlue
        numStockTalonarios.Value = 5
        Tiempo1.Enabled = False
        InicializaTiempo()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        AgregarRangoTalonarios(txtInicial.Value, txtFinal.Value)
    End Sub

    Private Sub oeGuiasControl_DatoCambiado() Handles oeGuiasControl.DatoCambiado
        oeGuiasControl.Modificado = True
    End Sub

    Private Sub frm_ControlGuias_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ControlGuias_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                MostrarTabs(0, ficControlGuias)
                'Consultar(True)
                'InicializaTiempo()
            Case "Ayuda"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_Ruta_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            Eliminar()
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTalonarios_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griTalonarios.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("Talonario: " & "¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub griTalonarios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTalonarios.CellChange
        Try
            griTalonarios.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        agrListaRegistro.Text = "Lista Registros: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If griLista.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
        Dim x As Char = e.KeyChar
        e.Handled = IIf(x >= "0" And x <= "9", False, True)
    End Sub

    Private Sub txtCorrelativo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCorrelativo.KeyPress
        Dim x As Char = e.KeyChar
        e.Handled = IIf(x >= "0" And x <= "9", False, True)
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        If txtSerie.Text <> "" Then txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
    End Sub

    Private Sub txtCorrelativo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorrelativo.Validated
        If txtCorrelativo.Text <> "" Then txtCorrelativo.Text = FormatoDocumento(txtCorrelativo.Text, 10)
    End Sub

    Private Sub griTalonarios_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griTalonarios.BeforeCellUpdate
        With griLista
            Select Case e.Cell.Column.Key
                Case "Observacion"
                    If e.Cell.Column.Key = "Observacion" Then If IsDBNull(e.NewValue) Then e.Cancel = True
            End Select
        End With
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        txtId.Text = ""
        txtSerie.Text = ""
        txtCorrelativo.Text = ""
        txtObservacion.Text = ""
        txtInicial.Value = 1
        txtFinal.Value = 50
        txtStockGuias.Value = 0
        txtStockTalonarios.Value = 0
        verAnulado.Checked = False
        verTerminado.Checked = False
        fecIngreso.Value = Date.Now
        LimpiaGrid(griTalonarios, ogdGuiasTalonarios)
    End Sub

    Public Sub LlenaCombos(ByVal Operacion As String)
        Try
            Dim ListaVehiculo As New List(Of e_Vehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.Id = "0"
            oeVehiculo.Placa = "LIBRE"
            ListaVehiculo.Add(oeVehiculo)
            cboTracto.Items.Clear()
            If Operacion = "Nuevo" Then
                oeVehiculo = New e_Vehiculo
                oeVehiculo.Motriz = 1
                oeVehiculo.Activo = True
                oeVehiculo.TipoOperacion = "M"
                ListaVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
                LlenarCombo(cboTracto, "Placa", ListaVehiculo.OrderBy(Function(Item) Item.Placa).ToList, -1)
            Else
                If Operacion = "Editar" Then
                    oeVehiculo = New e_Vehiculo
                    oeVehiculo.Motriz = 1
                    oeVehiculo.Activo = True
                    oeVehiculo.TipoOperacion = "A"
                    ListaVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
                    LlenarCombo(cboTracto, "Placa", ListaVehiculo.OrderBy(Function(Item) Item.Placa).ToList, 0)
                End If
            End If
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
            oeGuiasControl = New e_GuiasControl
            griLista.DataSource = olGuiasControl.Listar(oeGuiasControl)
            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
                If CInt(Fila.Cells("StockTalonarios").Value) < numStockTalonarios.Value Then
                    Fila.CellAppearance.BackColor = Me.ColorStockTalonarios.Color
                Else
                    Fila.CellAppearance.BackColor = Me.ColorEnUso.Color
                End If
            Next

            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Function EditarControlGuias() As Boolean
        Try
            Dim FinalUso As Integer = 0
            If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                With griLista.ActiveRow
                    'If Prefijo.PrefijoID = "1LU" And .Cells("Flota").Text <> "LIMA" Then '@0001
                    If gs_PrefijoIdSucursal = "1PY" And .Cells("Flota").Text <> "PACASMAYO" Then '@0001
                        Throw New Exception("No tiene permisos suficientes para editar registro no esta asignado a esta flota")
                    End If

                    'If Prefijo.PrefijoID = "1SA" And .Cells("Flota").Text <> "LIMA" Then '@0001
                    If gs_PrefijoIdSucursal = "1PY" And .Cells("Flota").Text <> "PACASMAYO" Then '@0001
                        Throw New Exception("No tiene permisos suficientes para editar registro no esta asignado a esta flota")
                    End If

                    'If Prefijo.PrefijoID = "1PY" And .Cells("Flota").Text <> "PACASMAYO" Then '@0001
                    If gs_PrefijoIdSucursal = "1PY" And .Cells("Flota").Text <> "PACASMAYO" Then '@0001
                        Throw New Exception("No tiene permisos suficientes para editar registro no esta asignado a esta flota")
                    End If
                    'If Prefijo.PrefijoID = "1CH" And .Cells("Flota").Text = "LIMA" Then
                    '    Throw New Exception("No tiene permisos suficientes para editar registro no esta asignado a esta flota")
                    'End If

                    'If Prefijo.PrefijoID = "1CH" And .Cells("Flota").Text = "PACASMAYO" Then
                    '    Throw New Exception("No tiene permisos suficientes para editar registro no esta asignado a esta flota")
                    'End If
                    oeGuiasControl = New e_GuiasControl
                    oeGuiasControl.Id = .Cells("Id").Value
                    oeGuiasControl = olGuiasControl.Obtener(oeGuiasControl)
                    If oeGuiasControl.Activo Then
                        txtId.Text = oeGuiasControl.Id
                        cboTracto.Value = oeGuiasControl.IdVehiculo
                        txtSerie.Value = oeGuiasControl.Serie
                        txtCorrelativo.Value = oeGuiasControl.Correlativo
                        txtObservacion.Text = oeGuiasControl.Observacion
                        txtStockGuias.Value = oeGuiasControl.StockGuias
                        txtStockTalonarios.Value = oeGuiasControl.StockTalonarios

                        oeGuiasTalonarios = New e_GuiasTalonarios
                        oeGuiasTalonarios.IdGuiasControl = oeGuiasControl.Id
                        griTalonarios.DataSource = olGuiasControl.ListarGuiasTalonarios(oeGuiasTalonarios)
                        For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griTalonarios.Rows
                            If FinalUso = 0 Then
                                If CInt(Fila.Cells("Final").Value) < CInt(txtCorrelativo.Text) Then
                                    Fila.CellAppearance.BackColor = Me.ColorTerminado.Color
                                    If Fila.Cells("Terminado").Value = 0 Then Fila.Cells("Terminado").Value = 1
                                    If Fila.Cells("Anulado").Value = 1 Then Fila.CellAppearance.BackColor = Me.ColorAnulado.Color
                                Else
                                    Fila.CellAppearance.BackColor = Me.ColorEnUso.Color
                                    FinalUso = CInt(Fila.Cells("Final").Value)
                                End If
                            Else
                                Fila.CellAppearance.BackColor = Me.ColorStock.Color
                            End If
                        Next
                        Return True
                    Else
                        Throw New Exception("El Registro se encuentra eliminada no se puede editar")
                    End If
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaCamposCabecera() As Boolean
        Try
            If ValidarCombo(cboTracto, "Tracto") AndAlso cboTracto.Value <> "0" Then
                oeVehiculo = New e_Vehiculo
                oeVehiculo.Id = cboTracto.Value
                olVehiculo.ValidarVehiculo(oeVehiculo)
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function GuardarControlGuias() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ValidaCamposCabecera() Then
                oeGuiasControl = New e_GuiasControl
                With oeGuiasControl
                    .Id = txtId.Text.Trim
                    .TipoOperacion = "I"
                    .IdVehiculo = cboTracto.Value
                    .Serie = txtSerie.Value
                    .Correlativo = txtCorrelativo.Value
                    .Observacion = txtObservacion.Text
                    .GuiasTalanonarios = griTalonarios.DataSource
                    .UsuarioCreacion = gUsuarioSGI.Id
                End With
                oeGuiasControl.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olGuiasControl.Guardar(oeGuiasControl) Then
                    mensajeEmergente.Confirmacion(Me.Text & ": La informacion ha sido grabada satisfactoriamente", True)
                    ugb_Espera.Visible = False
                    Consultar(True)
                    Return True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Origen") Then

        End If
        If excepcion.Contains("Destino") Then

        End If
        If excepcion.Contains("Base") Then

        End If
        If excepcion.Contains("Flota") Then

        End If
    End Sub

    Private Function ValidaTalonarios() As Boolean
        Try
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregarRangoTalonarios(ByVal Inicial As Integer, ByVal Final As Integer)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim NumeroInicial As Integer, _
                NumeroFinal As Integer, _
                Talonarios As Integer
            If Inicial = 1 Then
                Talonarios = Final \ 50
            Else
                Talonarios = (Final - Inicial + 1) \ 50
            End If
            NumeroInicial = Inicial
            NumeroFinal = Inicial
            Dim i As Integer
            For i = 0 To Talonarios - 1
                oeGuiasControl.GuiasTalanonarios = griTalonarios.DataSource
                With oeGuiasTalonarios
                    .Id = ""
                    .IdGuiasControl = ""
                    .Inicial = NumeroInicial
                    .Final = NumeroFinal + 49
                    .FechaIngreso = fecIngreso.Value
                    .Anulado = verAnulado.Checked
                    .Terminado = verTerminado.Checked
                    .Observacion = txtObservacionTalanario.Text
                    .Activo = True
                End With

                oeGuiasControl.GuiasTalanonarios.Add(oeGuiasTalonarios)
                griTalonarios.DataBind()
                oeGuiasTalonarios = New e_GuiasTalonarios
                NumeroInicial = NumeroInicial + 50
                NumeroFinal = NumeroInicial
            Next
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_ControlGuias_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griLista_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griLista.MouseMove
        If _tiempo <= 0 Then
            Consultar(True)
        End If
        InicializaTiempo()
    End Sub

    Public Overloads Function InicializaTiempo() As Integer
        _tiempo = 120
    End Function

#End Region

#Region "Menú contextual del maestro de Material"

    Private Sub AsociarMenu()
        griLista.ContextMenuStrip = Menu
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Menu.Opening
        Menu.Items("Insert").Visible = True
        If griLista.Selected.Rows.Count > 0 Then
            Menu.Items("Update").Visible = True
            Menu.Items("Delete").Visible = True
        Else
            Menu.Items("Update").Visible = False
            Menu.Items("Delete").Visible = False
        End If
    End Sub

#End Region

End Class