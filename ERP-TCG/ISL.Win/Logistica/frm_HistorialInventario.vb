'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

''' <summary>
''' Formulario diseñado para almacenar la información del historial del inventario en un momento determinado
''' </summary>
''' <remarks></remarks>
Public Class frm_HistorialInventario
    Inherits frm_MenuPadre

#Region "Definicion de Variables"
    Dim oeCentro As New e_Centro
    Dim oeAlmacen As New e_Almacen
    Dim olCentro As New l_Centro
    Dim olAlmacen As New l_Almacen
    Dim oeHistorial As New e_Historial
    Dim oeHistorialInventario As New e_HistorialInventario

    Dim olHistorial As New l_Historial
    Dim olHistorialInventario As New l_HistorialInventario
    Dim listaHistorialInventario As New List(Of e_HistorialInventario)
    Dim oeInventario As New e_Inventario
#End Region

#Region "Inicialización del formulario"

    Private Shared Instancia As frm_HistorialInventario = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_HistorialInventario
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        Me.txtGlosa.Text = String.Empty
    End Sub

    Public Sub Inventario_Datos(loInventario As List(Of e_Inventario), IdSubAlmacen As String)
        'oeInventario = oeInv
        'oeInventario.TipoOperacion = "4"

        'listaHistorialInventario = olHistorialInventario.Listar_Inventario(oeInventario)
        oeHistorial.IdSubAlmacen = IdSubAlmacen
        listaHistorialInventario = New List(Of e_HistorialInventario)
        For Each oe As e_Inventario In loInventario.OrderBy(Function(i) i.Material).ToList
            oeHistorialInventario = New e_HistorialInventario
            With oeHistorialInventario
                .Codigo = oe.Codigo
                .Material = oe.Material
                .IdMaterial = oe.IdMaterial
                .IdUnidadMedida = oe.IdUnidadMedida
                .UnidadMedida = oe.UnidadMedida
                .CantidadFinal = oe.CantidadFinal
                .ValorUnitario = oe.ValorUnitario
                .ValorTotal = oe.ValorTotal
                .Fecha = oe.FechaCreacion
            End With
            oeHistorialInventario.PrefijoID = gs_PrefijoIdSucursal '@0001
            listaHistorialInventario.Add(oeHistorialInventario)
        Next
        griListaInventario.DataSource = listaHistorialInventario
        MostrarBotones(2)
        Me.txtGlosa.Select()
    End Sub

    Private Sub Listar()
        Try
            ValidarFechaDesde_Hasta(rfechasDesde, rfechasHasta)
            Me.Cursor = Cursors.WaitCursor
            oeHistorial = New e_Historial
            oeHistorial._fechaInicio = rfechasDesde.Value
            oeHistorial._fechaFin = rfechasHasta.Value
            grilla_Historial.DataSource = olHistorial.Listar(oeHistorial)
            ''Ubica el cursor en el primer registro de la grilla
            If grilla_Historial.Rows.Count > 0 Then
                grilla_Historial.Focus()
                grilla_Historial.Rows.Item(0).Selected = True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Cargar_Datos()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeHistorial = New e_Historial
            oeHistorial.Id = grilla_Historial.ActiveRow.Cells("Id").Value
            oeHistorial = olHistorial.Obtener(oeHistorial)
            'Cabecera
            Fecha.Value = oeHistorial.Fecha
            txtCentro.Text = oeHistorial.Centro
            txtAlmacen.Text = oeHistorial.Almacen
            txtSubAlmacen.Text = oeHistorial.SubAlmacen
            txtGlosa.Text = oeHistorial.Glosa
            'Detalle
            oeHistorialInventario = New e_HistorialInventario
            listaHistorialInventario = New List(Of e_HistorialInventario)
            oeHistorialInventario.IdHistorial = oeHistorial.Id
            listaHistorialInventario = olHistorialInventario.Listar(oeHistorialInventario)
            With griListaInventario
                .DataSource = listaHistorialInventario
            End With
            Me.txtGlosa.ReadOnly = True
            MostrarBotones(3)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GuardarHistorial() As Boolean
        Try
            oeHistorial.lstHistorialInventario = listaHistorialInventario
            oeHistorial.Fecha = Me.Fecha.Value
            oeHistorial.usuariocreacion = gUsuarioSGI.Id
            oeHistorial.Id = ""
            oeHistorial.TipoOperacion = "I"
            oeHistorial.FechaCreacion = ObtenerFechaServidor()
            oeHistorial.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olHistorial.GuardarMasivo(oeHistorial) Then mensajeEmergente.Confirmacion("Se Guardo satisfactoriamente en " & Me.Text)
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub MostrarBotones(Optional indicador As Integer = 1)
        Select Case indicador
            Case 1
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                MostrarTabs(0, ficHistorialInventario, 2)
            Case 2
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
                MostrarTabs(1, ficHistorialInventario, 1)
            Case 3
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 1)
                MostrarTabs(1, ficHistorialInventario, 1)
        End Select
    End Sub
#End Region

#Region "Eventos"

    Private Sub frm_HistorialInventario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficHistorialInventario.SelectedTab.Index
            Case 0
                MostrarBotones()
            Case 1
                MostrarBotones(2)
        End Select
    End Sub

    Private Sub frm_HistorialInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_HistorialInventario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub
    Private Sub frm_HistorialInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
        rfechasDesde.Value = Date.Today.AddDays(-4) : rfechasHasta.Value = Date.Today
    End Sub
    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeHistorial.Glosa = Me.txtGlosa.Text
    End Sub
    Private Sub grilla_Historial_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grilla_Historial.DoubleClick
        If grilla_Historial.Selected.Rows.Count > 0 Then Cargar_Datos()
    End Sub
    Private Sub grilla_Historial_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grilla_Historial.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub
    Private Sub griListaInventario_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaInventario.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub
#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        oeAlmacen.TipoOperacion = "I"
        MostrarTabs(1, ficHistorialInventario, 1)
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarHistorial() Then
                Operacion = "Inicializa"
                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If Operacion = "Nuevo" And ficHistorialInventario.SelectedTab.Index = 1 Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarHistorial() Then
                            Operacion = "Inicializa"
                        End If
                        Me.Close()
                    Case Windows.Forms.DialogResult.No
                        Operacion = "Inicializa"
                        Me.Close()
                End Select
            Else
                MostrarBotones()
                Listar()
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
            Select Case ficHistorialInventario.SelectedTab.Index
                Case 0
                    If grilla_Historial.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                    Exportar_Excel(grilla_Historial)
                Case 1
                    If griListaInventario.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                    Exportar_Excel(griListaInventario)
            End Select
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

End Class