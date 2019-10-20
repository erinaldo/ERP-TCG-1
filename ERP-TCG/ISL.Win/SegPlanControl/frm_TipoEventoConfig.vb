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

Public Class frm_TipoEventoConfig
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_TipoEventoConfig = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre

        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_TipoEventoConfig()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Definicion de Variables"
    Dim _ingresando_datos As Boolean = False

    Dim olOperacion As New l_Operacion

    Dim loConcepto As New l_Concepto
    Dim oeConcepto As New e_Concepto
    Dim ListaConcepto As New List(Of e_Concepto)

    Dim listaAreaAsignada As New List(Of e_AreaTipoEvento)
    Dim NuevoAlarma As Boolean = True

    Dim olAreaTipoEvento As New l_AreaTipoEvento
    Dim oeAreaTipoEvento As New e_AreaTipoEvento
#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar(Activo)
            Tiempo1.Enabled = True
            If griLista.Rows.Count > 0 Then
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
            Operacion = "Nuevo"
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Inicializar()
            MostrarTabs(1, tcPrincipal, 1)
            oeConcepto.TipoOperacion = "I"
            oeConcepto.Id = ""
            oeConcepto.Correlativo = -1
            oeConcepto.Activo = True
            cboEvento.ReadOnly = False
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
            Inicializar()
            Operacion = "Editar"
            CargarEditar()
            cboEvento.ReadOnly = True
            MyBase.Editar()
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
            If GuardarTipoEvento() Then
                MyBase.Guardar()
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
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If ValidarGrilla(griLista, "Area Tipo Evento") Then
                Dim idArea As String = griLista.ActiveRow.Cells("IdArea").Value.ToString.Trim
                If idArea = "SIN ASIGNAR" Then
                    If MessageBox.Show("Esta seguro de eliminar Tipo: " & _
                             griLista.ActiveRow.Cells("Tipo").Value.ToString & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeConcepto = New e_Concepto
                        oeConcepto.Id = griLista.ActiveRow.Cells("ID").Value.ToString.Trim
                        oeConcepto.TipoOperacion = "E"
                        oeConcepto.Prefijo = griLista.ActiveRow.Cells("IdTipoEvento").Value.ToString.Trim
                        oeConcepto.Correlativo = griLista.ActiveRow.Cells("IdTipo").Value.ToString.Trim
                        oeConcepto.UsuarioCreacion = gUsuarioSGI.Id.Trim
                        loConcepto.Eliminar(oeConcepto)
                        Consultar(True)
                    End If
                Else
                    If MessageBox.Show("Esta seguro de eliminar Area Asignada: " & _
                             griLista.ActiveRow.Cells("Area").Value.ToString & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeAreaTipoEvento = New e_AreaTipoEvento
                        oeAreaTipoEvento.Id = griLista.ActiveRow.Cells("ID").Value.ToString.Trim
                        oeAreaTipoEvento.TipoOperacion = "E"
                        oeAreaTipoEvento.IdTipoEvento = griLista.ActiveRow.Cells("IdTipoEvento").Value.ToString.Trim
                        oeAreaTipoEvento.IdTipo = griLista.ActiveRow.Cells("IdTipo").Value.ToString.Trim
                        oeAreaTipoEvento.IdArea = griLista.ActiveRow.Cells("IdArea").Value.ToString.Trim
                        oeAreaTipoEvento.UsuarioCreacion = gUsuarioSGI.Id.Trim
                        olAreaTipoEvento.Eliminar(oeAreaTipoEvento)
                        Consultar(True)
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
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

    Private Sub frm_TipoEventoConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            MostrarTabs(0, tcPrincipal)
            InicializaTiempo()
            LlenaCombos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAreas_CellChange_1(sender As Object, e As CellEventArgs) Handles griAreas.CellChange
        Try
            With griAreas
                If e.Cell.Row.Index > -1 Then
                    .UpdateData()
                    If .ActiveRow.Cells("Selec").Activated Then
                        If .ActiveRow.Cells("Selec").Value Then
                            .ActiveRow.Fixed = True
                        Else
                            .ActiveRow.Fixed = False
                        End If

                        Dim oeAreaAsignada As New e_AreaTipoEvento
                        listaAreaAsignada = griAreasAsignadas.DataSource

                        oeAreaAsignada.IdArea = .ActiveRow.Cells("Id").Value
                        oeAreaAsignada.Codigo = .ActiveRow.Cells("Codigo").Value

                        If Not listaAreaAsignada.Contains(oeAreaAsignada) Then
                            If .ActiveRow.Cells("Selec").Value Then

                                oeAreaAsignada.Id = String.Empty
                                oeAreaAsignada.TipoOperacion = "I"
                                oeAreaAsignada.IdTipoEvento = cboEvento.Value
                                oeAreaAsignada.IdArea = .ActiveRow.Cells("Id").Value
                                oeAreaAsignada.Area = .ActiveRow.Cells("Nombre").Value
                                oeAreaAsignada.UsuarioCreacion = gUsuarioSGI.Id
                                oeAreaAsignada.PrefijoID = gs_PrefijoIdSucursal '@0001
                                listaAreaAsignada.Add(oeAreaAsignada)
                                If griAreasAsignadas.Rows.Count < 1 Then
                                    griAreasAsignadas.DataSource = listaAreaAsignada
                                End If

                            End If
                        Else
                            oeAreaAsignada = listaAreaAsignada.Item(listaAreaAsignada.IndexOf(oeAreaAsignada))
                            If .ActiveRow.Cells("Selec").Value Then
                                If oeAreaAsignada.TipoOperacion = "E" Then
                                    oeAreaAsignada.TipoOperacion = ""
                                    For Each fila As UltraWinGrid.UltraGridRow In griAreasAsignadas.Rows
                                        If fila.Cells("IdArea").Value = oeAreaAsignada.IdArea Then
                                            fila.Hidden = False
                                            Exit For
                                        End If
                                    Next
                                Else
                                    Throw New Exception("El Area: " & .ActiveRow.Cells("Area").Value & " ya esta Asignado")
                                End If

                            Else
                                If oeAreaAsignada.Id <> "" Then
                                    listaAreaAsignada.Remove(oeAreaAsignada)
                                Else
                                    listaAreaAsignada.Remove(oeAreaAsignada)
                                End If

                            End If

                        End If

                    End If
                End If
            End With

            griAreasAsignadas.DataSource = listaAreaAsignada
            griAreasAsignadas.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_TipoEventoConfig_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub
    Private Sub frm_TipoEventoConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

    Private Function GuardarTipoEvento() As Boolean
        Try
            If txtNombre.Text.Trim = "" Then
                mensajeEmergente.Confirmacion("Debe Ingresar Nombre del Tipo de Evento.", True)
                txtNombre.Focus()
                Return False
            End If
            listaAreaAsignada = griAreasAsignadas.DataSource
            oeConcepto.Nombre = txtNombre.Text.Trim
            oeConcepto.Descripcion = txtDescripcion.Text.Trim
            oeConcepto.Prefijo = cboEvento.Value
            oeConcepto.UsuarioCreacion = gUsuarioSGI.Id
            oeConcepto.Prefijo = gs_PrefijoIdSucursal '@0001
            If loConcepto.Guardar(oeConcepto, listaAreaAsignada) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, tcPrincipal)
                Consultar(True)
                griLista.Focus()
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LlenaCombos()
        'llenamos combo de tipo de eventos
        oeConcepto.Valor1 = ""
        oeConcepto.Nombre = "TODOS"
        ListaConcepto = New List(Of e_Concepto)
        ListaConcepto.Add(oeConcepto)
        oeConcepto = New e_Concepto
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "1"
        ListaConcepto.AddRange(loConcepto.Listar(oeConcepto))
        cboEventoBusqueda.DataSource = ListaConcepto
        cboEventoBusqueda.DisplayMember = "Nombre"
        cboEventoBusqueda.ValueMember = "Valor1"
        cboEventoBusqueda.SelectedIndex = 0

        'llenamos combo de tipo de eventos
        oeConcepto = New e_Concepto
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "1"
        ListaConcepto = loConcepto.Listar(oeConcepto)
        cboEvento.DataSource = ListaConcepto
        cboEvento.DisplayMember = "Nombre"
        cboEvento.ValueMember = "Valor1"
        cboEvento.SelectedIndex = 0

        CargarAreas()
    End Sub

    Private Sub CargarAreas()
        Try
            Dim leArea As l_Area = New l_Area
            Dim oeArea As e_Area = New e_Area
            Dim listaArea As List(Of e_Area)
            listaArea = leArea.Listar(oeArea)
            With griAreas
                .ResetDisplayLayout()
                Dim lista = From la In listaArea Select la.Id, la.Codigo, la.Nombre
                .DataSource = lista.ToList
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Selec")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Selec").Width = 30
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Area"
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 145
            End With
            listaAreaAsignada = New List(Of e_AreaTipoEvento)
            griAreasAsignadas.DataSource = listaAreaAsignada
            griAreasAsignadas.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeConcepto = New e_Concepto
            oeConcepto.Prefijo = cboEventoBusqueda.Value.Trim
            ListaConcepto = loConcepto.Listar(oeConcepto)

            Dim listaConceptoAux = From lc In ListaConcepto Select lc _
                     Where (lc.Prefijo = "2" Or lc.Prefijo = "3" Or lc.Prefijo = "6" Or lc.Prefijo = "7") And lc.Prefijo <> "0"

            Dim lista As New List(Of e_AreaTipoEvento)
            oeAreaTipoEvento = New e_AreaTipoEvento
            oeAreaTipoEvento.IdTipoEvento = cboEventoBusqueda.Value
            lista = olAreaTipoEvento.Listar(oeAreaTipoEvento)

            Dim listaAuxAreatipoEvento As New List(Of e_AreaTipoEvento)
            For Each c In listaConceptoAux
                Dim indicador As Boolean = True
                For Each a In lista
                    If c.Prefijo.Trim = a.IdTipoEvento.Trim And c.Valor1.Trim = a.IdTipo.Trim Then
                        indicador = False
                        Exit For
                    End If
                Next
                If indicador Then
                    Dim auxAreaTipoEvento As New e_AreaTipoEvento
                    auxAreaTipoEvento.Id = c.Id
                    auxAreaTipoEvento.Codigo = c.Codigo
                    auxAreaTipoEvento.IdTipoEvento = c.Prefijo.Trim
                    If auxAreaTipoEvento.IdTipoEvento = 2 Then auxAreaTipoEvento.TipoEvento = "ALARMA"
                    If auxAreaTipoEvento.IdTipoEvento = 3 Then auxAreaTipoEvento.TipoEvento = "ACCIDENTE"
                    If auxAreaTipoEvento.IdTipoEvento = 6 Then auxAreaTipoEvento.TipoEvento = "ROBO"
                    If auxAreaTipoEvento.IdTipoEvento = 7 Then auxAreaTipoEvento.TipoEvento = "INCIDENTE"
                    auxAreaTipoEvento.IdTipo = c.Valor1.Trim
                    auxAreaTipoEvento.Tipo = c.Nombre.Trim
                    auxAreaTipoEvento.IdArea = "SIN ASIGNAR"
                    auxAreaTipoEvento.Area = "SIN ASIGNAR"
                    auxAreaTipoEvento.Glosa = "SIN ASIGNAR"
                    auxAreaTipoEvento.Activo = True
                    auxAreaTipoEvento.UsuarioCreacion = c.UsuarioCreacion
                    auxAreaTipoEvento.UsuarioModifica = c.UsuarioModifica
                    auxAreaTipoEvento.FechaCreacion = c.FechaCreacion
                    auxAreaTipoEvento.FechaModifica = c.FechaModifica
                    listaAuxAreatipoEvento.Add(auxAreaTipoEvento)
                End If
            Next

            lista.AddRange(listaAuxAreatipoEvento)
            griLista.DataSource = lista
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
                Select Case fila.Cells("IdTipoEvento").Value.Trim
                    Case "2"
                        fila.CellAppearance.BackColor = Me.ColorAlarma.Color
                    Case "3"
                        fila.CellAppearance.BackColor = Me.ColorAccidente.Color
                    Case "7"
                        fila.CellAppearance.BackColor = Me.ColorIncidente.Color
                    Case "6"
                        fila.CellAppearance.BackColor = Me.ColorRobo.Color
                End Select
            Next
            griLista.DataBind()

        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            listaAreaAsignada = New List(Of e_AreaTipoEvento)
            oeAreaTipoEvento = New e_AreaTipoEvento

            griAreasAsignadas.DataSource = listaAreaAsignada
            griAreasAsignadas.DataBind()

            LimpiarEdicion()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LimpiarEdicion()
        cboEvento.SelectedIndex = 0
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        CargarAreas()
    End Sub

    Private Sub CargarEditar()
        Try
            oeConcepto = New e_Concepto
            oeConcepto.Prefijo = griLista.ActiveRow.Cells("IdTipoEvento").Value.ToString.Trim
            oeConcepto.Valor1 = griLista.ActiveRow.Cells("IdTipo").Value.ToString.Trim
            ListaConcepto = loConcepto.Listar(oeConcepto)
            oeConcepto = ListaConcepto(0)
            oeConcepto.TipoOperacion = "I"

            cboEvento.Value = oeConcepto.Prefijo.Trim
            txtNombre.Text = oeConcepto.Nombre.Trim
            txtDescripcion.Text = oeConcepto.Descripcion.Trim
            CargarAreasConfiguradas(oeConcepto.Prefijo.Trim, oeConcepto.Valor1.Trim)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CargarAreasConfiguradas(ByVal IdTipoEvento As String, ByVal IdTipo As String)
        Try
            oeAreaTipoEvento = New e_AreaTipoEvento
            oeAreaTipoEvento.IdTipoEvento = IdTipoEvento
            oeAreaTipoEvento.IdTipo = IdTipo
            listaAreaAsignada = olAreaTipoEvento.Listar(oeAreaTipoEvento)
            With griAreasAsignadas
                .DataSource = listaAreaAsignada
            End With
            griAreasAsignadas.DataBind()
            For Each oe As e_AreaTipoEvento In listaAreaAsignada
                oe.PrefijoID = gs_PrefijoIdSucursal '@0001
                For Each Fila As UltraWinGrid.UltraGridRow In griAreas.Rows
                    If Fila.Cells("Id").Value.trim = oe.IdArea.Trim And oe.Activo Then
                        Fila.Cells("Selec").Value = True
                        Fila.Fixed = True
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griLista_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.Cancel = True
            e.DisplayPromptMsg = False
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griAreas_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAreas.BeforeRowsDeleted
        Try
            e.Cancel = True
            e.DisplayPromptMsg = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griAreasAsignadas_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAreasAsignadas.BeforeRowsDeleted
        Try
            e.Cancel = True
            e.DisplayPromptMsg = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Try
            Dim idArea As String = griLista.ActiveRow.Cells("IdArea").Value.ToString.Trim
            oeConcepto = New e_Concepto

            If idArea = "SIN ASIGNAR" Then
                oeConcepto.Id = griLista.ActiveRow.Cells("ID").Value.ToString.Trim
                oeConcepto.TipoOperacion = "E"
                oeConcepto.Prefijo = griLista.ActiveRow.Cells("IdTipoEvento").Value.ToString.Trim
                oeConcepto.Valor1 = griLista.ActiveRow.Cells("IdTipo").Value.ToString.Trim
                oeConcepto.UsuarioCreacion = gUsuarioSGI.Id.Trim
                loConcepto.Eliminar(oeConcepto)
                Consultar(True)
            Else
                oeConcepto.Prefijo = griLista.ActiveRow.Cells("IdTipoEvento").Value.ToString.Trim
                oeConcepto.Valor1 = griLista.ActiveRow.Cells("IdTipo").Value.ToString.Trim
                ListaConcepto = loConcepto.Listar(oeConcepto)
                oeConcepto = ListaConcepto(0)
                oeConcepto.UsuarioCreacion = gUsuarioSGI.Id.Trim
                loConcepto.EliminarTipoEvento(oeConcepto)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
        
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        If griLista.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griAreasAsignadas_CellChange(sender As Object, e As CellEventArgs) Handles griAreasAsignadas.CellChange
        With griAreasAsignadas
            .UpdateData()
        End With
    End Sub
End Class