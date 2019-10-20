'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb

Public Class frm_TipoDocumentoVehiculoDetalle
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_TipoDocumentoVehiculoDetalle = Nothing
    Private Shared Operacion As String

    ''' <summary>
    ''' Instancia unica de Formulario: frm_DemandaRapida
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre

        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_TipoDocumentoVehiculoDetalle()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Definicion de Variables"
    Dim _ingresando_datos As Boolean = False

    'Dim TiempoMaximoViaje As Long = 0
    'Public IdViaje As String = String.Empty

    Dim olTipoDocumentoVehiculoDetalle As New l_TipoDocumentoVehiculoDetalle
#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar()
            MostrarTabs(0, tcPrincipal)
            Tiempo1.Enabled = True
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
            Operacion = "Nuevo"
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Inicializar()

            MostrarTabs(1, tcPrincipal, 1)
            MyBase.Nuevo()
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
            MostrarTabs(1, tcPrincipal, 1)
            LimpiarEditar()
            Operacion = "Editar"
            cboTipoDocumento.Value = ""
            cboTipoDocumento.Value = griLista.ActiveRow.Cells("IdTipoDocumento").Value.ToString.Trim
            MyBase.Nuevo()
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
            If GuardarDetalle() Then
                MyBase.Guardar()
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados?", "Mensaje del sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    Guardar()
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, tcPrincipal)
                    MyBase.Cancelar()
                    Consultar(True)
                Case Windows.Forms.DialogResult.Cancel
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If ValidarGrilla(griLista, "Asociar Tipo Documento Con Cliente/Material.") Then
                Dim id As String = griLista.ActiveRow.Cells("Id").Value.ToString.Trim
                If id = "" Then Throw New Exception("No se puede eliminar registro sin asignar")
                If MessageBox.Show("Esta seguro de eliminar el registro seleccionado.", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Dim obj As New e_TipoDocumentoVehiculoDetalle
                    obj.TipoOperacion = "E"
                    obj.Id = griLista.ActiveRow.Cells("Id").Value.ToString.Trim
                    obj.UsuarioCreacion = gUsuarioSGI.Id.Trim
                    olTipoDocumentoVehiculoDetalle.Eliminar(obj)
                    Consultar(True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Imprimir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ExportarGrillaAExcel(griLista)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Eventos"
    Private Sub frm_TipoDocumentoVehiculoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            MostrarTabs(0, tcPrincipal)
            InicializaTiempo()
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoDocumento_SelectionChanged(sender As Object, e As EventArgs) Handles cboTipoDocumento.SelectionChanged
        chkTodosCliente.Checked = False
        chkTodosMaterial.Checked = False
        CambioIndTodosCliente(False)
        CambioIndTodosMaterial(False)
        CargarAsignados(cboTipoDocumento.Value)
    End Sub

    Private Sub chkTodosCliente_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodosCliente.CheckedChanged
        Try
            CambioIndTodosCliente(chkTodosCliente.Checked)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkTodosMaterial_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodosMaterial.CheckedChanged
        Try
            CambioIndTodosMaterial(chkTodosMaterial.Checked)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridClientes_CellChange(sender As Object, e As CellEventArgs) Handles gridClientes.CellChange
        Try
            With gridClientes
                If e.Cell.Row.Index > -1 Then
                    .UpdateData()
                    If .ActiveRow.Cells("Select").Activated Then
                        If .ActiveRow.Cells("Select").Value Then
                            .Rows(0).Cells("Select").Value = False
                            .Rows(0).Fixed = False
                            .ActiveRow.Fixed = True
                        Else
                            .ActiveRow.Fixed = False
                        End If
                    End If
                    .UpdateData()
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridMateriales_CellChange(sender As Object, e As CellEventArgs) Handles gridMateriales.CellChange
        Try
            With gridMateriales
                If e.Cell.Row.Index > -1 Then
                    .UpdateData()
                    If .ActiveRow.Cells("Select").Activated Then
                        If .ActiveRow.Cells("Select").Value Then
                            .ActiveRow.Fixed = True
                        Else
                            .ActiveRow.Fixed = False
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
            If griLista.Selected.Rows.Count < 1 Then Throw New Exception("Debe seleccionar registro a eliminar.")
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        Try
            If griLista.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridClientes_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles gridClientes.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridMateriales_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles gridMateriales.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_TipoDocumentoVehiculoDetalle_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub
    Private Sub frm_TipoDocumentoVehiculoDetalle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

#End Region

#Region "Metodos"
    Private Sub Inicializar()
        Try
            LlenarCombos()
            LimpiarEditar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombos()
        Dim ListaCombo As New List(Of e_Combo)
        Dim oeCombo As New e_Combo
        Dim olCombo As New l_Combo
        'llenamos combo tipo de documento de vehiculos en listar
        ListaCombo = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        ListaCombo.Add(oeCombo)
        ListaCombo.AddRange(TipoDocVehPublic)
        LlenarCombo(cboTipoDocumentoListar, "Nombre", ListaCombo, 0)
        'llenamos combo clientes listar
        ListaCombo = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        ListaCombo.Add(oeCombo)
        ListaCombo.AddRange(ClientesPublic)
        LlenarCombo(cboClienteListar, "Nombre", ListaCombo, 0)
        'llenamos combo clientes listar
        ListaCombo = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        ListaCombo.Add(oeCombo)
        ListaCombo.AddRange(MaterialesPublic.Where(Function(item) item.Descripcion = "OPERACIONESC").ToList)
        LlenarCombo(cboMaterialListar, "Nombre", ListaCombo, 0)
        'llenamos combo tipo de documento de vehiculos
        ListaCombo = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "---Seleccionar---"
        ListaCombo.Add(oeCombo)
        ListaCombo.AddRange(TipoDocVehPublic)
        LlenarCombo(cboTipoDocumento, "Nombre", ListaCombo, 0)
    End Sub

    Private Function GuardarDetalle() As Boolean
        Try
            Dim lista As New List(Of e_TipoDocumentoVehiculoDetalle)
            If cboTipoDocumento.Value = "" Then Throw New Exception("Debe Seleccionar Tipo Documento.")
            Dim oeDetalle As e_TipoDocumentoVehiculoDetalle
            If chkTodosCliente.Checked Then
                oeDetalle = New e_TipoDocumentoVehiculoDetalle
                oeDetalle.TipoOperacion = "I"
                oeDetalle.IdTipoDocumento = cboTipoDocumento.Value
                oeDetalle.IndTodosCliente = chkTodosCliente.Checked
                oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
                oeDetalle.PrefijoID = gs_PrefijoIdSucursal '@0001
                lista.Add(oeDetalle)
            Else
                For Each fila In gridClientes.Rows
                    If fila.Cells("Select").Value Then
                        oeDetalle = New e_TipoDocumentoVehiculoDetalle
                        oeDetalle.TipoOperacion = "I"
                        oeDetalle.IdCliente = fila.Cells("Id").Value
                        oeDetalle.IndTodosCliente = False
                        oeDetalle.IdTipoDocumento = cboTipoDocumento.Value
                        oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
                        oeDetalle.PrefijoID = gs_PrefijoIdSucursal '@0001
                        lista.Add(oeDetalle)
                    End If
                Next
                
            End If
            If chkTodosMaterial.Checked Then
                oeDetalle = New e_TipoDocumentoVehiculoDetalle
                oeDetalle.TipoOperacion = "I"
                oeDetalle.IdTipoDocumento = cboTipoDocumento.Value
                oeDetalle.IndTodosMaterial = chkTodosMaterial.Checked
                oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
                oeDetalle.PrefijoID = gs_PrefijoIdSucursal '@0001
                lista.Add(oeDetalle)
            Else
                For Each fila In gridMateriales.Rows
                    If fila.Cells("Select").Value Then
                        oeDetalle = New e_TipoDocumentoVehiculoDetalle
                        oeDetalle.TipoOperacion = "I"
                        oeDetalle.IdMaterial = fila.Cells("Id").Value
                        oeDetalle.IndTodosMaterial = chkTodosMaterial.Checked
                        oeDetalle.IdTipoDocumento = cboTipoDocumento.Value
                        oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
                        oeDetalle.PrefijoID = gs_PrefijoIdSucursal '@0001
                        lista.Add(oeDetalle)
                    End If
                Next
            End If
            If lista.Count < 1 Then
                mensajeEmergente.Problema("Debe Seleccionar Clientes/Materiales o Indicador Todos", True)
                Return False
            End If
            If olTipoDocumentoVehiculoDetalle.Guardar(lista) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CambioIndTodosCliente(ByVal IndTodos As Boolean)
        Try
            CargarCLientes()
            gridClientes.Enabled = Not IndTodos
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CambioIndTodosMaterial(ByVal IndTodos As Boolean)
        Try
            CargarMateriales()
            gridMateriales.Enabled = Not IndTodos
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpiarEditar()
        Try
            chkTodosCliente.Checked = False
            chkTodosMaterial.Checked = False
            CambioIndTodosCliente(chkTodosCliente.Checked)
            CambioIndTodosMaterial(chkTodosMaterial.Checked)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCLientes()
        Try
            gridClientes.DataSource = New List(Of e_Combo)
            gridClientes.DataSource = ClientesPublic
            gridClientes.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarMateriales()
        Try
            gridMateriales.DataSource = New List(Of e_Combo)
            gridMateriales.DataSource = MaterialesPublic.Where(Function(item) item.Descripcion = "OPERACIONESC").ToList
            gridMateriales.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAsignados(ByVal IdTipoDocumento As String)
        Try
            If IdTipoDocumento.Trim <> "" Then
                Dim listaAux As New List(Of e_TipoDocumentoVehiculoDetalle)
                Dim oeAux As New e_TipoDocumentoVehiculoDetalle
                oeAux.IdTipoDocumento = IdTipoDocumento
                oeAux.TipoOperacion = "G"
                listaAux = olTipoDocumentoVehiculoDetalle.Listar(oeAux)
                If listaAux.Count > 0 Then
                    For Each Item In listaAux
                        If Item.IndTodosCliente Then
                            chkTodosCliente.Checked = Item.IndTodosCliente
                            CambioIndTodosCliente(chkTodosCliente.Checked)
                            Exit For
                        End If
                        If Item.IdCliente.Trim <> "" Then
                            For Each Fila In gridClientes.Rows
                                If Item.IdCliente.Trim = Fila.Cells("Id").Value.ToString.Trim Then
                                    Fila.Cells("Select").Value = True
                                    Fila.Fixed = True
                                End If
                            Next
                        End If
                    Next
                Else
                    CambioIndTodosCliente(False)
                End If
                If listaAux.Count > 0 Then
                    For Each Item In listaAux
                        If Item.IndTodosMaterial Then
                            chkTodosMaterial.Checked = Item.IndTodosMaterial
                            CambioIndTodosMaterial(chkTodosMaterial.Checked)
                            Exit For
                        End If
                        If Item.IdMaterial.Trim <> "" Then
                            For Each Fila In gridMateriales.Rows
                                If Item.IdMaterial.Trim = Fila.Cells("Id").Value.ToString.Trim Then
                                    Fila.Cells("Select").Value = True
                                    Fila.Fixed = True
                                End If
                            Next
                        End If
                    Next
                Else
                    CambioIndTodosMaterial(False)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        'validar 
        If cboTipoDocumentoListar.SelectedIndex = -1 Then
            mensajeEmergente.Problema("Debe Seleccionar Tipo Documento", True)
            Return
        End If
        If cboClienteListar.SelectedIndex = -1 Then
            mensajeEmergente.Problema("Debe Seleccionar Cliente", True)
            Return
        End If
        If cboMaterialListar.SelectedIndex = -1 Then
            mensajeEmergente.Problema("Debe Seleccionar Material", True)
            Return
        End If
        Dim lista As New List(Of e_TipoDocumentoVehiculoDetalle)
        Dim obj As New e_TipoDocumentoVehiculoDetalle
        obj.TipoOperacion = "G"
        obj.IdTipoDocumento = cboTipoDocumentoListar.Value
        obj.IdCliente = cboClienteListar.Value
        obj.IdMaterial = cboMaterialListar.Value
        If cboTipoDocumentoListar.Value = "" Then
            For Each item In TipoDocVehPublic
                obj.IdTipoDocumento = item.Id
                Dim listaAux As New List(Of e_TipoDocumentoVehiculoDetalle)
                listaAux = olTipoDocumentoVehiculoDetalle.Listar(obj)
                If listaAux.Count = 0 Then
                    Dim objAux As New e_TipoDocumentoVehiculoDetalle
                    objAux.IdTipoDocumento = item.Id
                    objAux.TipoDocumento = item.Nombre
                    objAux.Cliente = "Sin Asignar"
                    objAux.Material = "Sin Asignar"
                    lista.Add(objAux)
                Else
                    lista.AddRange(listaAux)
                End If
            Next
        Else
            Dim listaAux As New List(Of e_TipoDocumentoVehiculoDetalle)
            listaAux = olTipoDocumentoVehiculoDetalle.Listar(obj)
            If listaAux.Count = 0 Then
                Dim objAux As New e_TipoDocumentoVehiculoDetalle
                objAux.IdTipoDocumento = objAux.IdTipoDocumento
                objAux.TipoDocumento = cboTipoDocumentoListar.Text.Trim
                objAux.Cliente = "Sin Asignar"
                objAux.Material = "Sin Asignar"
                lista.Add(objAux)
            Else
                lista.AddRange(listaAux)
            End If
        End If
        griLista.DataSource = lista
        griLista.DataBind()
        For Each fila In griLista.Rows
            If fila.Cells("Id").Value = "" Then
                'fila.Fixed = True
                fila.CellAppearance.BackColor = ColorSinAsignar.Color
            End If
            If fila.Cells("IndTodosCliente").Value Then
                fila.CellAppearance.BackColor = ColorTodos.Color
            End If
            If fila.Cells("IndTodosMaterial").Value Then
                fila.CellAppearance.BackColor = ColorTodos.Color
            End If
        Next



    End Sub
#End Region

    
End Class