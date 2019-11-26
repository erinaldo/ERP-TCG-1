'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frm_MaterialAlmacen

#Region "Inicializa Formulario"

    Private Shared instancia As frm_MaterialAlmacen = Nothing
    Private Shared Operacion As String

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_MaterialAlmacen()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function
#End Region

#Region "Declaración de variables"

    Dim oeMaterialAlmacen As New e_MaterialAlmacen
    Dim olMaterialAlmacen As New l_MaterialAlmacen

    Dim olCentro As New l_Centro
    Dim oeCentro As New e_Centro

    Dim olAlmacen As New l_Almacen
    Dim oeAlmacen As New e_Almacen

    Dim oeZona As New e_Zona
    Dim olZona As New l_Zona

    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material

    Dim lstMateriales As New List(Of e_MaterialAlmacen)
    Dim ltMateriales As New List(Of e_MaterialAlmacen)
    Dim listaMat As New List(Of e_MaterialAlmacen)
    Dim lstAlmacenes As New List(Of e_Almacen)

    'Dim llMaterialAlmacen As New List(Of e_MaterialAlmacen)
    Dim ds_MA_AL As DataSet
    Dim relation As DataRelation
    Dim _ingresando_datos As Boolean = False
    Dim dsMaterialAlmacen As New DataSet

    Public MaterialAlmacen As Boolean = False

#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar(Activo)
            If griListaMaterialesAlmacen.Rows.Count > 0 Then
                If Activo Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                End If
            Else
                ControlBoton(1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Inicializar()
            Operacion = "Nuevo"
            oeMaterialAlmacen.TipoOperacion = "I"
            MostrarTabs(1, ficMaterialAlmacen, 1)
            LlenarComboMaestro(cboCentroM, olCentro.Listar(oeCentro), 0)
            MyBase.Nuevo()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Public Overrides Sub Editar()
        Try
            If ltMateriales.Where(Function(item) item.Seleccion).Count > 0 Then
                Mostrar()
                oeMaterialAlmacen.TipoOperacion = "A"
                Operacion = "Editar"
                LimpiarListas()
                MostrarTabs(1, ficMaterialAlmacen, 1)
                LlenarComboMaestro(cboCentroM, olCentro.Listar(oeCentro), 0)
                MostrarTabs(1, tcDetalle, 0)
                MyBase.Editar()
            Else
                mensajeEmergente.Confirmacion("Seleccione Materiales", True)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        oeMaterialAlmacen.Activo = True
        If GuardarMaterialAlmacen() Then
            ActualizarListaPublica("MATERIAL ALMACEN")
            MyBase.Guardar()
            MostrarTabs(0, ficMaterialAlmacen)
            Consultar(True)
        End If
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMaterialAlmacen.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarMaterialAlmacen() Then
                            MostrarTabs(0, ficMaterialAlmacen, 2)
                            _ingresando_datos = False
                            Inicializar()
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficMaterialAlmacen, 2)
                        _ingresando_datos = False
                        Inicializar()
                        Consultar(True)
                        Exit Sub
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select

            Else
                MostrarTabs(0, ficMaterialAlmacen, 2)
                _ingresando_datos = False
                Consultar(True)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'With griListaMaterialesAlmacen
            '    If ltMateriales.Where(Function(item) item.Seleccion).Count = 0 Then
            '        mensajeEmergente.Problema("Seleccione Materiales")
            '        Exit Sub
            '    End If
            '    listaMat = New List(Of e_MaterialAlmacen)
            '    For Each oeMaterial As e_MaterialAlmacen In ltMateriales.Where(Function(item) item.Seleccion)
            '        oeMaterial.Seleccion = False
            '        listaMat.Add(oeMaterial)
            '    Next
            '    For Each oeMatAlm As e_MaterialAlmacen In listaMat
            '        Dim oeInv As New e_Inventario
            '        Dim olInv As New l_Inventario
            '        oeInv.IdMaterial = oeMatAlm.IdMaterial
            '        oeInv.IdSubAlmacen = oeMatAlm.IdAlmacen
            '        oeInv.TipoOperacion = "7"
            '        oeInv = olInv.Obtener(oeInv)
            '        If oeInv.CantidadFinal > 0 Then
            '            Throw New Exception("No Puede Eliminar el Material: " & oeMatAlm.Material & ", puesto que tiene Stock: " & oeInv.CantidadFinal)
            '        End If
            '    Next
            '    If MessageBox.Show("Esta seguro de desasignar los material seleccionados ? ", _
            '              "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            '        olMaterialAlmacen.Eliminar(listaMat)
            '        Inicializar()
            '        Consultar(True)
            '        Throw New Exception("La informacion  se elimino en " & Me.Text)
            '    End If
            'End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If grid_MA_AL.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_MA_AL)

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

    Private Sub LimpiarListas()
        lstMateriales.Clear()
        lstAlmacenes.Clear()
        listaMat.Clear()
        ltMateriales.Clear()
    End Sub

    Private Sub Inicializar()
        LimpiaGrid(griListaAlmacenes, odListaAlmacenes)
        LimpiaGrid(griListaMateriales, odMateriales)
        Me.txtBuscarMateriales.Text = String.Empty
        LimpiarListas()
        cboCentroM.SelectedIndex = -1
        oeMaterialAlmacen = New e_MaterialAlmacen
        AsociarMenu()
        UE_AM.Expanded = False
        tcDetalle.Tabs(0).Selected = True
        ds_MA_AL.Clear()

    End Sub

    Private Sub ListarMateriales()
        Try
            Me.Cursor = Cursors.WaitCursor
            lstMateriales = New List(Of e_MaterialAlmacen)
            oeMaterial.TipoOperacion = "G"
            oeMaterial.Activo = True
            oeMaterial.Id = ""
            If Not String.IsNullOrEmpty(oeMaterial.Nombre.Trim) Then
                lstMateriales = olMaterial.ListarMatAlm(oeMaterial)
                griListaMateriales.DataSource = lstMateriales
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMaterialAlmacen.IdAlmacen = cboAlmacenL.Value
            oeMaterialAlmacen.Activo = Nothing
            oeMaterialAlmacen.TipoOperacion = "S"
            'With griListaMaterialesAlmacen
            ltMateriales = New List(Of e_MaterialAlmacen)
            ltMateriales.Clear()
            ltMateriales = olMaterialAlmacen.Listar_(oeMaterialAlmacen)
            griListaMaterialesAlmacen.DataSource = ltMateriales
            griListaMaterialesAlmacen.DisplayLayout.Bands(0).Columns("Id").Hidden = True
            agrMaterialesAsignados.Text = "Materiales asignados: " & Convert.ToString(griListaMaterialesAlmacen.Rows.Count)
            'Ubica el cursor el el primer registro de la grilla
            If griListaMaterialesAlmacen.Rows.Count > 0 Then
                griListaMaterialesAlmacen.Focus()
                griListaMaterialesAlmacen.Rows.Item(0).Selected = True
            End If
            'End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Function GuardarMaterialAlmacen() As Boolean
        Try
            lstMateriales = New List(Of e_MaterialAlmacen)

            For Each matRow As DataRow In ds_MA_AL.Tables(1).Rows
                oeMaterialAlmacen = New e_MaterialAlmacen
                oeMaterialAlmacen.TipoOperacion = "I" : oeMaterialAlmacen.Id = ""
                oeMaterialAlmacen.IdMaterial = matRow("IdMaterial")
                oeMaterialAlmacen.IdAlmacen = matRow("IdAlmacen")
                oeMaterialAlmacen.StockMinimo = matRow("StockMinimo")
                oeMaterialAlmacen.StockMaximo = matRow("StockMaximo")
                oeMaterialAlmacen.IdZona = matRow("Zona")
                oeMaterialAlmacen.UsuarioCreacion = gUsuarioSGI.Id
                oeMaterialAlmacen.PrefijoID = gs_PrefijoIdSucursal '@0001
                lstMateriales.Add(oeMaterialAlmacen)
            Next

            If olMaterialAlmacen.Guardar(lstMateriales) Then
                mensajeEmergente.Confirmacion("La información ha sido grabada satisfactoriamente en " & Me.Text)
                Inicializar()
                Consultar(True)
                Return True
            End If
            mensajeEmergente.Confirmacion("No se ha completado Grabar la Información en " & Me.Text)
            Return False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Return False
        End Try
    End Function

    Private Sub Mostrar()
        Try
            Dim listaIdsMateriales As String = ""
            Dim listaIdsAlmacenes As String = ""
            For Each oeMaterial As e_MaterialAlmacen In ltMateriales.Where(Function(item) item.Seleccion)
                listaIdsMateriales = listaIdsMateriales & "'" & oeMaterial.IdMaterial.Trim & "',"
                oeMaterial.Seleccion = False
            Next
            listaIdsAlmacenes = Me.cboAlmacenL.Value
            listaIdsMateriales = listaIdsMateriales.Substring(0, listaIdsMateriales.Trim.Length - 1)
            ListarAlmacen_Materiales(listaIdsAlmacenes, " " & listaIdsMateriales)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarDetalle()
        Try
            Select Case tcDetalle.SelectedTab.Index
                Case 0
                    AgregarAlmacen()
                Case 1
                    AgregarMaterial()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub AgregarAlmacen()
        Try
            Dim _cant As Integer = 0, cont As Integer = 0
            For Each oeAlmacen As e_Almacen In lstAlmacenes.Where(Function(item) item.Seleccion)
                If ValidarAlmacenMaterial(oeAlmacen.Id, "A", oeAlmacen.Nombre) Then Exit Sub
                oeAlmacen.Seleccion = False
                Dim row As DataRow
                row = ds_MA_AL.Tables(0).NewRow
                row("IdAlmacen") = oeAlmacen.Id
                row("Seleccion") = False
                row("Almacen") = oeAlmacen.Nombre
                row("Abreviatura") = oeAlmacen.Abreviatura
                row("UnidadMedida") = ""
                row("IdZona") = ""
                row("Zona") = ""
                row("StockMinimo") = ""
                row("StockMaximo") = ""
                ds_MA_AL.Tables(0).Rows.Add(row)
                ds_MA_AL.Tables(0).AcceptChanges()
                _cant += 1
            Next
            ds_MA_AL.AcceptChanges()
            If _cant > 0 Then
                oeMaterialAlmacen.Modificado = True
                grid_MA_AL.DataBind()
                griListaAlmacenes.DataBind()
                MostrarTabs(1, tcDetalle, 0)
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarMaterial()
        Try
            If ds_MA_AL.Tables(0).Rows.Count = 0 Then
                mensajeEmergente.Problema("Agregar Almacén")
                MostrarTabs(0, tcDetalle, 0)
                Exit Sub
            End If
            If grid_MA_AL.ActiveRow.Band.Index = 0 Then
                Dim _cant As Integer = 0
                For Each oeMaterial As e_MaterialAlmacen In lstMateriales.Where(Function(item) item.Seleccion)
                    If ValidarAlmacenMaterial(oeMaterial.IdMaterial, "M", oeMaterial.Material, grid_MA_AL.ActiveRow.Cells("IdAlmacen").Value) Then
                        oeMaterial.Seleccion = False
                        griListaMateriales.DataBind()
                        Exit Sub
                    End If
                    Dim rowMaterial As DataRow
                    rowMaterial = ds_MA_AL.Tables(1).NewRow
                    rowMaterial("Seleccion") = False
                    rowMaterial("IdMaterial") = oeMaterial.IdMaterial
                    rowMaterial("Material") = oeMaterial.Material
                    rowMaterial("Abreviatura") = ""
                    rowMaterial("UnidadMedida") = oeMaterial.UnidadMedida
                    rowMaterial("IdZona") = ""
                    rowMaterial("Zona") = ""
                    rowMaterial("StockMinimo") = 0
                    rowMaterial("StockMaximo") = 0
                    rowMaterial("IdAlmacen") = grid_MA_AL.ActiveRow.Cells("IdAlmacen").Value
                    ds_MA_AL.Tables(1).Rows.Add(rowMaterial)
                    ds_MA_AL.Tables(1).AcceptChanges()
                    oeMaterial.Seleccion = False
                    _cant += 1
                Next
                If _cant > 0 Then
                    griListaMateriales.DataBind()
                    grid_MA_AL.DataBind()
                    With grid_MA_AL
                        For i As Integer = 0 To .Rows.Count - 1
                            For Each aChildBand1 As UltraGridChildBand In .Rows(i).ChildBands
                                For Each fila As UltraGridRow In aChildBand1.Rows

                                    For y As Integer = 0 To aChildBand1.Rows.Count - 1
                                        ZonasValueList(aChildBand1.Rows(y).Cells("IdAlmacen").Value.ToString(), grid_MA_AL)
                                        aChildBand1.Rows(y).Cells("IdZona").ValueList = .DisplayLayout.ValueLists("Zonas")
                                    Next

                                Next
                            Next
                        Next
                    End With
                    oeMaterialAlmacen.Modificado = True
                End If

                For x As Integer = 0 To grid_MA_AL.Rows.Count - 1
                    Me.grid_MA_AL.Rows(x).ExpandAll()
                Next
            Else
                mensajeEmergente.Confirmacion("Seleccione un Almacen para agregar Material")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarAlmacenMaterial(ByVal ls_Id As String, ByVal ls_tipo As String, ByVal ls_Nombre As String, Optional ByVal ls_IdAlmacen As String = "") As Boolean
        Select Case ls_tipo
            Case "M"
                For Each matRow As DataRow In ds_MA_AL.Tables(1).Rows
                    If matRow("IdMaterial") = ls_Id And matRow("IdAlmacen") = ls_IdAlmacen Then
                        mensajeEmergente.Confirmacion("Ya se Agrego el Material: " & ls_Nombre & " al Almacen seleccionado")
                        Return True
                    End If
                Next
                Return False
            Case "A"
                For Each matRow As DataRow In ds_MA_AL.Tables(0).Rows
                    If matRow("IdAlmacen") = ls_Id Then
                        mensajeEmergente.Confirmacion("Ya se Agrego el Almacen: " & ls_Nombre)
                        Return True
                    End If
                Next
                Return False
        End Select
    End Function

    Private Sub QuitarDetalle()
        Try
            QuitarMaterialAlmacen()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub QuitarMaterialAlmacen()
        Try
            With grid_MA_AL
                Dim sw As Boolean = False
                For Each matRow As DataRow In ds_MA_AL.Tables(1).Rows
                    If matRow("Seleccion") Then sw = True
                Next
                For Each matRow As DataRow In ds_MA_AL.Tables(0).Rows
                    If matRow("Seleccion") Then sw = True
                Next
                If Not sw Then
                    mensajeEmergente.Confirmacion("Marque por lo menos un registro para quitar de lista.")
                    Exit Sub
                End If
                If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    For Each matRow As DataRow In ds_MA_AL.Tables(1).Rows
                        If matRow("Seleccion") Then
                            matRow.Delete()
                        End If
                    Next
                    For Each matRow As DataRow In ds_MA_AL.Tables(0).Rows
                        If matRow("Seleccion") Then
                            matRow.Delete()
                        End If
                    Next
                    ds_MA_AL.AcceptChanges()
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarAlmacen_Materiales(ByVal ls_IdAlmacen As String, Optional ByVal ls_IdsMateriales As String = "")
        Try
            Cursor.Current = Cursors.WaitCursor
            oeMaterialAlmacen = New e_MaterialAlmacen
            oeMaterialAlmacen.TipoOperacion = "L"
            oeMaterialAlmacen.IdsAlmacenes = ls_IdAlmacen
            oeMaterialAlmacen.IdsMateriales = ls_IdsMateriales
            ds_MA_AL = olMaterialAlmacen.ListarAlmacenMateriales(oeMaterialAlmacen)
            Dim parentCol As DataColumn = ds_MA_AL.Tables(0).Columns("IdAlmacen")
            Dim childCol As DataColumn = ds_MA_AL.Tables(1).Columns("IdAlmacen")
            relation = New DataRelation("FK_Relacion", parentCol, childCol, True)
            ds_MA_AL.Relations.Add(relation)
            ds_MA_AL.AcceptChanges()
            grid_MA_AL.DataSource = ds_MA_AL
            With grid_MA_AL.DisplayLayout

                'ocultar
                .Bands(0).Columns("IdAlmacen").Hidden = True
                .Bands(0).Columns("IdZona").Hidden = True
                .Bands(1).Columns("IdMaterial").Hidden = True
                .Bands(1).Columns("IdAlmacen").Hidden = True
                .Bands(1).Columns("IdZona").Hidden = True
                'Definir Tamaño
                .Bands(0).Columns("Almacen").Width = 320
                .Bands(1).Columns("Material").Width = 320
                .Bands(0).Columns("Abreviatura").Width = 80
                .Bands(1).Columns("Abreviatura").Width = 80
                .Bands(0).Columns("UnidadMedida").Width = 80
                .Bands(1).Columns("UnidadMedida").Width = 80
                .Bands(0).Columns("Zona").Width = 140
                .Bands(1).Columns("Zona").Width = 140
                .Bands(0).Columns("StockMinimo").Width = 75
                .Bands(1).Columns("StockMinimo").Width = 75
                .Bands(0).Columns("StockMaximo").Width = 75
                .Bands(1).Columns("StockMaximo").Width = 75
                .Bands(1).Columns("StockMinimo").MaskInput = "{double:9.2}"
                .Bands(1).Columns("StockMaximo").MaskInput = "{double:9.2}"
                .Bands(1).Columns("StockMinimo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("StockMaximo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(0).Columns("Seleccion").Style = ColumnStyle.CheckBox
                .Bands(1).Columns("Seleccion").Style = ColumnStyle.CheckBox
                .Bands(0).Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Bands(1).Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Bands(1).Columns("IdZona").CellClickAction = CellClickAction.Edit
                .Bands(1).Columns("StockMinimo").CellClickAction = CellClickAction.Edit
                .Bands(1).Columns("StockMaximo").CellClickAction = CellClickAction.Edit
                .Bands(1).Columns("Zona").CellClickAction = CellClickAction.RowSelect
                '.Bands(1).Columns("Zona").CharacterCasing = CharacterCasing.Upper
                '.Bands(1).Columns("Zona").MaxLength = 6
                .Bands(1).ColHeadersVisible = False
            End With
            'If ds_MA_AL.Tables(1).Rows.Count > 0 Then
            '    griListaMateriales.DataBind()
            '    grid_MA_AL.DataBind()
            '    With grid_MA_AL
            '        ZonasValueList(Me.cboAlmacenL.Value.ToString, grid_MA_AL)
            '        For i As Integer = 0 To .Rows.Count - 1
            '            For Each aChildBand1 As UltraGridChildBand In .Rows(i).ChildBands
            '                For Each fila As UltraGridRow In aChildBand1.Rows
            '                    For y As Integer = 0 To aChildBand1.Rows.Count - 1
            '                        aChildBand1.Rows(y).Cells("IdZona").ValueList = .DisplayLayout.ValueLists("Zonas")
            '                    Next

            '                Next
            '            Next
            '        Next
            '    End With
            '    oeMaterialAlmacen.Modificado = True
            'End If
            For x As Integer = 0 To grid_MA_AL.Rows.Count - 1
                grid_MA_AL.Rows(x).ExpandAll()
            Next

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            grid_MA_AL.Focus()
        End Try
    End Sub

    Private Sub ZonasValueList(ByVal ls_IdAlmacen As String, ByVal stGrilla As UltraWinGrid.UltraGrid)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            stGrilla.DisplayLayout.ValueLists.Clear()
            objValueList = stGrilla.DisplayLayout.ValueLists.Add("Zonas")
            oeZona = New e_Zona()
            oeZona.Activo = True
            oeZona.Zona = ""
            oeZona.IdAlmacen = ls_IdAlmacen
            Dim dt As DataTable = olZona.ComboGrilla(oeZona)
            For i As Integer = 0 To dt.Rows.Count - 1
                objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub frm_MaterialAlmacen_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Select Case ficMaterialAlmacen.SelectedTab.Index
            Case 0
                If griListaMaterialesAlmacen.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub frm_MaterialAlmacen_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_MaterialAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gf_AsignarEventoSeleccionarTexto(Me)
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        MostrarTabs(0, ficMaterialAlmacen)
        InicializaTiempo()
        Tiempo1.Enabled = False
        ListarAlmacen_Materiales("")
        Inicializar()
        LlenarComboMaestro(cboCentroL, olCentro.Listar(oeCentro), 0)
        InicializarCombos()
    End Sub

    Private Sub frm_MaterialAlmacen_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

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

    Private Sub griListaMateriales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.CellChange
        griListaMateriales.UpdateData()
    End Sub

    Private Sub griListaAlmacenes_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaAlmacenes.CellChange
        griListaAlmacenes.UpdateData()
    End Sub

    Private Sub cboCentroL_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroL.ValueChanged
        Try
            oeAlmacen.IdCentro = cboCentroL.Value
            oeAlmacen.Activo = True
            LimpiaCombos(cboAlmacenL)
            LlenarComboMaestro(cboAlmacenL, olAlmacen.Listar(oeAlmacen), 0)
            Dim centro As String = cboCentroL.Text.Substring(0, 1)
            If centro <> "S" Then
                cboCtroAlmacen.Text = centro
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboCentroM_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroM.ValueChanged
        Try
            oeAlmacen.IdCentro = cboCentroM.Value
            oeAlmacen.Activo = True
            With griListaAlmacenes
                lstAlmacenes = olAlmacen.Listar(oeAlmacen)
                .DataSource = lstAlmacenes
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaMaterialesAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles griListaMaterialesAlmacen.KeyPress
        Try
            If griListaMaterialesAlmacen.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                If Char.IsLetter(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsDigit(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    'Private Sub griListaMaterialesAlmacen_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMaterialesAlmacen.AfterCellUpdate
    '    Try
    '        Dim a As String = ""
    '        For Each x As e_Combo In CentroPublic
    '            If x.Descripcion = ObtenerCentro.Nombre Then
    '                a = x.Nombre.Substring(0, 1)
    '            End If
    '        Next
    '        If griListaMaterialesAlmacen.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
    '            Select Case e.Cell.Column.Key
    '                Case "Zona"
    '                    With griListaMaterialesAlmacen
    '                        Dim x As String = ""
    '                        Dim zona As String = .ActiveRow.Cells("Zona").Value.ToString.Substring(0, 1)
    '                        If zona <> "P" And zona <> "C" And zona <> "L" Then
    '                            .ActiveRow.Cells("Zona").Value = a
    '                            Throw New Exception("El Primer Digito de la Zona debe ser la Primera Letra del Centro")
    '                        End If
    '                        If Len(.ActiveRow.Cells("Zona").Value.ToString) > 2 Then
    '                            Dim zona2 As String = .ActiveRow.Cells("Zona").Value.ToString.Substring(2, 1)
    '                            If IsNumeric(zona2) = True Then
    '                                x = .ActiveRow.Cells("Zona").Value.ToString.Substring(0, 2)
    '                                .ActiveRow.Cells("Zona").Value = x
    '                                Throw New Exception("El Tercer Digito de la Zona debe Ser una Letra")
    '                            End If
    '                            If Len(.ActiveRow.Cells("Zona").Value.ToString) > 3 Then
    '                                Dim zona3 As String = .ActiveRow.Cells("Zona").Value.ToString.Substring(3, 1)
    '                                If zona3 <> "D" And zona3 <> "I" Then
    '                                    x = .ActiveRow.Cells("Zona").Value.ToString.Substring(0, 3)
    '                                    .ActiveRow.Cells("Zona").Value = x
    '                                    Throw New Exception("El Cuarto Digito indica un lado del Anaquel/Zona")
    '                                End If
    '                                If Len(.ActiveRow.Cells("Zona").Value.ToString) > 4 Then
    '                                    Dim zona4 As String = .ActiveRow.Cells("Zona").Value.ToString.Substring(4, 1)
    '                                    If IsNumeric(zona4) = False Then
    '                                        x = .ActiveRow.Cells("Zona").Value.ToString.Substring(0, 4)
    '                                        .ActiveRow.Cells("Zona").Value = x
    '                                        Throw New Exception("El Quinto Digito de la Zona debe Ser un Numero")
    '                                    End If
    '                                    If Len(.ActiveRow.Cells("Zona").Value.ToString) > 5 Then
    '                                        Dim zona5 As String = .ActiveRow.Cells("Zona").Value.ToString.Substring(5, 1)
    '                                        If IsNumeric(zona5) = False Then
    '                                            x = .ActiveRow.Cells("Zona").Value.ToString.Substring(0, 5)
    '                                            .ActiveRow.Cells("Zona").Value = x
    '                                            Throw New Exception("El Sexto Digito de la Zona debe Ser un Numero")
    '                                        End If
    '                                    End If
    '                                End If
    '                            End If

    '                        End If
    '                    End With
    '            End Select
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message)
    '    End Try
    'End Sub

    Private Sub griListaMaterialesAlmacen_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMaterialesAlmacen.CellChange
        'If IsDBNull(griListaMaterialesAlmacen.ActiveRow.Cells("Zona").Value) Then griListaMaterialesAlmacen.ActiveRow.Cells("Zona").Value = "NINGUNA"
        griListaMaterialesAlmacen.UpdateData()
    End Sub

    Private Sub UE_AM_ExpandedStateChanging(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles UE_AM.ExpandedStateChanging
        If UE_AM.Expanded = True Then
            If grid_MA_AL.Rows.Count > 0 Then
                tcDetalle.Tabs(1).Enabled = True
                MostrarTabs(1, tcDetalle, 0)
            Else
                tcDetalle.Tabs(1).Enabled = False
                MostrarTabs(0, tcDetalle, 0)
            End If
        End If
    End Sub

    Private Sub ficMaterialAlmacen_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficMaterialAlmacen.SelectedTabChanged
        If ficMaterialAlmacen.Tabs(1).Selected Then
            'ListaMateriales()
        Else
            Me.Consultar()
        End If
    End Sub

    Private Sub mnDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnDetalle.ToolClick
        Select Case e.Tool.Key
            Case "Agregar"
                AgregarDetalle()
            Case "Quitar"
                QuitarDetalle()
        End Select
    End Sub

    Private Sub txtBuscarMateriales_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarMateriales.ValueChanged
        txtBuscarMateriales.Text = LTrim(txtBuscarMateriales.Text)
        oeMaterial.Nombre = txtBuscarMateriales.Text
    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarMateriales()
        End If
    End Sub

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        ListarMateriales()
    End Sub

    Private Sub grid_MA_AL_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_MA_AL.CellChange
        With grid_MA_AL
            .UpdateData()
            If e.Cell.Column.Key.ToUpper = "SELECCION" Then
                Select Case .ActiveRow.Band.Index
                    Case 0
                        For Each mantRow As DataRow In ds_MA_AL.Tables(1).Rows
                            If .ActiveRow.Cells("IdAlmacen").Value = mantRow("IdAlmacen") Then
                                mantRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                            End If
                        Next
                    Case 1
                        Dim cont As Integer = 0, cont2 As Integer = 0
                        For Each mantRow As DataRow In ds_MA_AL.Tables(1).Rows
                            If .ActiveRow.Cells("IdAlmacen").Value = mantRow("IdAlmacen") Then
                                If mantRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value Then
                                    cont += 1
                                End If
                                cont2 += 1
                            End If
                        Next
                        If cont = cont2 Then
                            .ActiveRow.ParentRow.Cells("Seleccion").Value = .ActiveRow.Cells("Seleccion").Value
                        Else
                            If Not .ActiveRow.Cells("Seleccion").Value Then
                                .ActiveRow.ParentRow.Cells("Seleccion").Value = .ActiveRow.Cells("Seleccion").Value
                            End If
                        End If

                End Select
                .UpdateData()
                .DataBind()
            End If
        End With
    End Sub

    Private Sub griListaAlmacenes_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaAlmacenes.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaMateriales_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaMateriales.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grid_MA_AL_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_MA_AL.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        QuitarDetalle()
        e.Cancel = True
    End Sub

    Private Sub grid_MA_AL_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grid_MA_AL.BeforeCellUpdate
        With grid_MA_AL
            Select Case e.Cell.Column.Key
                Case "StockMinimo"
                    If e.Cell.Column.Key = "StockMinimo" Then
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                Case "StockMaximo"
                    If e.Cell.Column.Key = "StockMaximo" Then
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
            End Select
        End With
    End Sub

    Private Sub grid_MA_AL_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_MA_AL.AfterCellUpdate
        Try
            'With grid_MA_AL.Rows(e.Cell.Row.Index)
            '    Select Case e.Cell.Column.Key
            '        Case "StockMaximo"
            '            If IsDBNull(e.Cell.Value) Then
            '                .Cells("StockMaximo").Value = 0
            '                Exit Sub
            '            End If
            '        Case "StockMinimo"
            '            If IsDBNull(e.Cell.Value) Then
            '                .Cells("StockMinimo").Value = 0
            '                Exit Sub
            '            End If
            '    End Select
            'End With
            Dim a As String = ""
            For Each x As e_Combo In CentroPublic
                If x.Descripcion = ObtenerCentro(gs_PrefijoIdSucursal).Id Then
                    a = x.Nombre.Substring(0, 1)
                End If
            Next
            If grid_MA_AL.ActiveRow.Band.Index = 1 Then
                Select Case e.Cell.Column.Key
                    Case "Zona"
                        With grid_MA_AL
                            Dim x As String = ""
                            Dim zona As String = .ActiveRow.Cells("Zona").Value.ToString.Substring(0, 1)
                            If zona <> "P" And zona <> "C" And zona <> "L" Then
                                .ActiveRow.Cells("Zona").Value = a
                                Throw New Exception("El Primer Digito de la Zona debe ser la Primera Letra del Centro")
                            End If
                            If Len(.ActiveRow.Cells("Zona").Value.ToString) > 2 Then
                                Dim zona2 As String = .ActiveRow.Cells("Zona").Value.ToString.Substring(2, 1)
                                If IsNumeric(zona2) = True Then
                                    x = .ActiveRow.Cells("Zona").Value.ToString.Substring(0, 2)
                                    .ActiveRow.Cells("Zona").Value = x
                                    Throw New Exception("El Tercer Digito de la Zona debe Ser una Letra")
                                End If
                                If Len(.ActiveRow.Cells("Zona").Value.ToString) > 3 Then
                                    Dim zona3 As String = .ActiveRow.Cells("Zona").Value.ToString.Substring(3, 1)
                                    If zona3 <> "D" And zona3 <> "I" Then
                                        x = .ActiveRow.Cells("Zona").Value.ToString.Substring(0, 3)
                                        .ActiveRow.Cells("Zona").Value = x
                                        Throw New Exception("El Cuarto Digito indica un lado del Anaquel/Zona")
                                    End If
                                    If Len(.ActiveRow.Cells("Zona").Value.ToString) > 4 Then
                                        Dim zona4 As String = .ActiveRow.Cells("Zona").Value.ToString.Substring(4, 1)
                                        If IsNumeric(zona4) = False Then
                                            x = .ActiveRow.Cells("Zona").Value.ToString.Substring(0, 4)
                                            .ActiveRow.Cells("Zona").Value = x
                                            Throw New Exception("El Quinto Digito de la Zona debe Ser un Numero")
                                        End If
                                        If Len(.ActiveRow.Cells("Zona").Value.ToString) > 5 Then
                                            Dim zona5 As String = .ActiveRow.Cells("Zona").Value.ToString.Substring(5, 1)
                                            If IsNumeric(zona5) = False Then
                                                x = .ActiveRow.Cells("Zona").Value.ToString.Substring(0, 5)
                                                .ActiveRow.Cells("Zona").Value = x
                                                Throw New Exception("El Sexto Digito de la Zona debe Ser un Numero")
                                            End If
                                        End If
                                    End If
                                End If

                            End If
                        End With
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_MaterialAlmacen_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griListaMaterialesAlmacen_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaMaterialesAlmacen.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Asignación de Material a Almacén"

    Private Sub AsociarMenu()
        griListaMaterialesAlmacen.ContextMenuStrip = MenuContextual1
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
        If grid_MA_AL.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

#Region "Zonas Almacen"

    Private Sub grid_MA_AL_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grid_MA_AL.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub griListaMaterialesAlmacen_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMaterialesAlmacen.ClickCellButton
        Try
            Dim oeMatAlm As New e_MaterialAlmacen
            With griListaMaterialesAlmacen
                oeMatAlm.Id = .ActiveRow.Cells("Id").Value
                oeMatAlm.IdZona = .ActiveRow.Cells("Zona").Value
                oeMatAlm.TipoOperacion = "Z"
                oeMatAlm.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olMaterialAlmacen.Guardar1(oeMatAlm) Then
                    mensajeEmergente.Confirmacion("Informacion Actualizada Correctamente")
                    Listar(True)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtZona_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtZona.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Trim(txtZona.Text) = "" Then Throw New Exception("Ingrese Zona")
            If griListaMaterialesAlmacen.Rows.Where(Function(item) item.IsFilteredOut = False).Count > 0 Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()

                lstMateriales = New List(Of e_MaterialAlmacen)
                If griListaMaterialesAlmacen.Rows.Count > 0 Then
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaMaterialesAlmacen.Rows.Where(Function(item) item.IsFilteredOut = False)
                        oeMaterialAlmacen = New e_MaterialAlmacen
                        With oeMaterialAlmacen
                            .TipoOperacion = "Z"
                            .Id = RTrim(Fila.Cells("Id").Value)
                            .IdZona = Fila.Cells("Zona").Value
                        End With
                        oeMaterialAlmacen.PrefijoID = gs_PrefijoIdSucursal '@0001
                        lstMateriales.Add(oeMaterialAlmacen)
                    Next
                End If
                If olMaterialAlmacen.Guardar(lstMateriales) Then
                    mensajeEmergente.Confirmacion("La información ha sido grabada satisfactoriamente en " & Me.Text)
                    Inicializar()
                    Consultar(True)
                End If
                ugb_Espera.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtAnaquel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnaquel.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSeccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeccion.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNivel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNivel.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Combo1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCtroAlmacen.Enter
        Me.ToolTip1.SetToolTip(cboCtroAlmacen, "Informacion sobre la Centro del Almacen")
    End Sub

    Private Sub txtSeccion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeccion.Enter
        Me.ToolTip1.SetToolTip(txtSeccion, "Informacion sobre la Seccion del Anaquel")
    End Sub

    Private Sub cboLado_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLado.Enter
        Me.ToolTip1.SetToolTip(cboLado, "Informacion lado del Anaquel (DERECHO, IZQUIERDO, NINGUNO")
    End Sub

    Private Sub InicializarCombos()
        cboLado.SelectedIndex = 2
        cboCtroAlmacen.SelectedIndex = -1
    End Sub

    Private Sub txtSeccion_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeccion.Validated
        txtSeccion.Text = FormatoDocumento(txtSeccion.Text, 2)
    End Sub

    Private Sub txtNivel_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNivel.Validated
        txtNivel.Text = FormatoDocumento(txtNivel.Text, 2)
    End Sub

    Private Sub Boton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton1.Click
        Try
            If griListaMaterialesAlmacen.Rows.Count > 0 Then
                If cboCtroAlmacen.SelectedIndex = -1 Then Throw New Exception("Seleccione Centro del Almacen")
                If txtZona.Text = "" Then Throw New Exception("Escriba la Primera letra del Almacen")
                If txtAnaquel.Text = "" Then Throw New Exception("Escriba el Anaquel")
                If cboLado.SelectedIndex = -1 Then Throw New Exception("Seleccione Lado")
                If txtSeccion.Text = "" Then Throw New Exception("Escriba la Seccion")
                If txtNivel.Text = "" Then Throw New Exception("Escriba el Nivel")
                Dim zona As String = ""
                zona = cboCtroAlmacen.Text & txtZona.Text & txtAnaquel.Text & cboLado.Text & _
                FormatoDocumento(txtSeccion.Text, 2) & FormatoDocumento(txtNivel.Text, 2)
                If MessageBox.Show("Se va Actualizar todos las Zonas de la Seleccion por: " & zona & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaMaterialesAlmacen.Rows.Where(Function(item) item.IsFilteredOut = False)
                        If Fila.Cells("Seleccion").Value = True Then
                            Fila.Cells("Zona").Value = zona
                        End If
                    Next
                    ugb_Espera.Visible = False
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub txtZona_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZona.Enter
        Me.ToolTip1.SetToolTip(txtZona, "Informacion sobre el Almacen")
    End Sub

    Private Sub txtAnaquel_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAnaquel.Enter
        Me.ToolTip1.SetToolTip(txtAnaquel, "Informacion sobre el Anaquel")
    End Sub

    Private Sub Boton1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton1.Enter
        Me.ToolTip1.SetToolTip(Boton1, "Actualiza los Registros Mostrados")
    End Sub

    Private Sub btnLimpiar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Enter
        Me.ToolTip1.SetToolTip(btnLimpiar, "Limpia los Registros Mostrados")
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Try
            If griListaMaterialesAlmacen.Rows.Count > 0 Then
                Dim strng As String = "NINGUNA"
                If MessageBox.Show("Se va actualizar todos las Zonas de la lista activa por: " & _
                                     strng & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    If griListaMaterialesAlmacen.Rows.Count > 0 Then
                        For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaMaterialesAlmacen.Rows.Where(Function(item) item.IsFilteredOut = False)
                            Fila.Cells("Zona").Value = strng
                        Next
                    End If
                    ugb_Espera.Visible = False
                End If

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region


End Class