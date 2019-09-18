'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios Centro y Giro
'=================================================================================================================


Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_GuiaRemisionRemitente

#Region "Inicializacion de Formulario"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_GuiaRemisionRemitente = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_GuiaRemisionRemitente
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function
#End Region

#Region "Declaración de variables"

    'Manejador de GuiaRemisionRemitente
    Dim oeGRRemitente As e_GuiaRemisionRemitente, olGRRemitente As l_GuiaRemisionRemitente
    Dim listaGRemision As List(Of e_GuiaRemisionRemitente)
    'Manejador de GuiaRRemitenteMaterial
    Dim oeGRemisionMaterial As e_GuiaRRemitenteMaterial
    Dim olGRemisionMaterial As l_GuiaRRemitenteMaterial
    Dim listaGRemisionMaterial As List(Of e_GuiaRRemitenteMaterial)
    'Manejador de Estados
    Private oeEstado As e_Estado
    Private olEstado As l_Estado
    'Manejador de Direccion
    Dim oeDireccion As e_Direccion, olDireccion As l_Direccion
    'Manejador de Proveedor
    Dim oeProveedor As e_Proveedor
    Dim olProveedor As l_Proveedor
    'Manejador de MotivoTraslado
    Dim oeMotivoTraslado As e_MotivoTraslado
    Dim olMotivoTraslado As l_MotivoTraslado
    'Manejador de Almacen
    Dim oeAlmacen As e_Almacen
    Dim olAlmacen As l_Almacen
    'Manejador de Material
    Dim oeMaterial As e_Material
    Dim olMaterial As l_Material
    Dim listaMaterial As List(Of e_Material)
    'Manejador de Unidad de Medida
    Dim oeUnidadMedida As e_UnidadMedida
    Dim olUnidadMedida As l_UnidadMedida
    'Manejador de Material - Almacen
    Dim oeMaterialAlmacen As e_MaterialAlmacen
    Dim olMaterialAlmacen As l_MaterialAlmacen
    'Manejador de Tipo de Documento
    Dim oeTipoDocumento As e_TipoDocumento, olTipoDocumento As l_TipoDocumento

    'Manejador de Orden - Documento
    Dim oeDetalleGuia As e_GuiaRRemitenteMaterial
    Dim sOrden As Boolean = 1 'Controla si viene de una orden
    'Para Buscar Ordenes Asociadas
    Dim oeOrden As e_Orden
    Dim lstOrden As List(Of e_Orden)
    'Lista Ordenes q no stan asociadas
    Dim listaO As List(Of e_Orden)
    Dim olOrden As l_Orden
    Dim _ingresando_datos As Boolean = False
    'Manejador TipoOrden
    Dim oeTipoOrden As e_TipoOrden
    Dim olTipoOrden As l_TipoOrden

    Dim _ref_orden As Integer = 0

#End Region

#Region "Botones Menu Principal"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar(Activo)
            If griListadoGuiaRemision.Rows.Count > 0 Then
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
            Inicializar()
            txtProveedor.Text = TxtEmpresaSistema.Trim '@0001
            oeGRRemitente.TipoOperacion = "I"
            oeGRRemitente.UsuarioCreacion = gUsuarioSGI.Id
            oeGRRemitente.Activo = True
            oeGRRemitente.PrefijoID = PrefijoIdSucursal '@0001
            MostrarTabs(1, ficGuiaR, 1)
            MostrarTabs(0, ficDetalle, 1)
            ControlaBarraOperacionesDetalle(True, True)
            cboProveedores.Focus()
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            txtProveedor.Text = TxtEmpresaSistema.Trim '@0001
            EditarGuiaRemision()
            oeGRRemitente.TipoOperacion = "A"
            oeGRRemitente.PrefijoID = PrefijoIdSucursal '@0001
            cboProveedores.Focus()
            MostrarTabs(1, ficGuiaR, 1)
            MostrarTabs(0, ficDetalle, 1)
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarGuiaRemision() Then
                MyBase.Guardar()
            Else
                MostrarTabs(0, ficDetalle)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Inicializar()
            If oeGRRemitente.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarGuiaRemision() Then
                            MostrarTabs(0, ficGuiaR, 2)
                            '_ingresando_datos = False
                            Consultar(True)
                        Else
                            '_ingresando_datos = True
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficGuiaR, 2)
                        _ingresando_datos = False
                        Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        '_ingresando_datos = True
                End Select
            Else
                MostrarTabs(0, ficGuiaR, 2)
                '_ingresando_datos = False
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griListadoGuiaRemision
                If griListadoGuiaRemision.ActiveRow.Cells("Estado").Value <> "TERMINADA" Then
                    oeGRRemitente.TipoOperacion = ""
                    oeGRRemitente.Id = .ActiveRow.Cells("Id").Value
                    oeGRRemitente = olGRRemitente.Obtener(oeGRRemitente)
                    If oeGRRemitente.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la Guia de Remision Remitente: ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeGRRemitente.TipoOperacion = "E"
                            oeGRRemitente.PrefijoID = PrefijoIdSucursal '@0001
                            olGRRemitente.Eliminar(oeGRRemitente)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                Else
                    mensajeEmergente.Problema("La Guia de Remision Remitente no se puede Eliminar")
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficGuiaR.Tabs(0).Selected() AndAlso griListadoGuiaRemision.Rows.Count = 0 Then Throw New Exception("No hay ninguna Guía de Remisión Remitente para exportar al Excel")
            If ficGuiaR.Tabs(0).Selected() Then Exportar_Excel(griListadoGuiaRemision)

            If ficGuiaR.Tabs(1).Selected() Then

                If ficDetalle.Tabs(0).Selected() AndAlso griGuiaMaterial.Rows.Count = 0 Then Throw New Exception("No hay ninguna Guía de Remisión Remitente para exportar al Excel")
                If ficDetalle.Tabs(0).Selected() Then Exportar_Excel(griGuiaMaterial)

                If ficDetalle.Tabs(1).Selected() AndAlso griListaOrdenIngreso.Rows.Count = 0 Then Throw New Exception("No hay ninguna Guía de Remisión Remitente para exportar al Excel")
                If ficDetalle.Tabs(1).Selected() Then Exportar_Excel(griListaOrdenIngreso)

            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub griListaMateriales_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListaMateriales.DisplayLayout.Bands(0).Layout.ActiveRow
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.LightYellow
                            .Appearance.ForeColor = Color.Red
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaMateriales_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaMateriales.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListaMateriales_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaMateriales.InitializeLayout
        With griListaMateriales
            .DisplayLayout.Bands(0).SortedColumns.Add("CodigoNombre", False, True)
            .DisplayLayout.GroupByBox.Hidden = True
            .DisplayLayout.GroupByBox.Style = GroupByBoxStyle.Compact
        End With
    End Sub

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        Try
            ListarMateriales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboBuscarGR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtBuscarMateriales.Value = String.Empty
    End Sub

    Private Sub cboDirOrigen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDirOrigen.ValueChanged
        oeGRRemitente.IdDireccionOrigen = cboDirOrigen.Value
    End Sub

    Private Sub cboDirDestino_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDirDestino.ValueChanged
        oeGRRemitente.IdDireccionDestino = cboDirDestino.Value
    End Sub

    Private Sub cboProveedores_Validated(sender As Object, e As EventArgs) Handles cboProveedores.Validated
        Try
            CargarDireccion()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_GuiaRemisionRemitente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me, btnListarMateriales.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            InicializarLogicas()
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            If sOrden Then MostrarTabs(0, ficGuiaR)
            rfGuiaRRemitenteHasta.Value = Date.Now
            rfGuiaRRemitenteDesde.Value = Date.Now.AddDays(-7)
            sOrden = 1
            LlenaCombos()
            LlenaComboProveedor()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_GuiaRemisionRemitente_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                ControlBoton(1, 1)
                If griListadoGuiaRemision.Rows.Count > 0 Then ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
        End Select
    End Sub

    Private Sub frm_GuiaRemisionRemitente_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_GuiaRemisionRemitente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub txtVehiculo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVehiculo.ValueChanged
        oeGRRemitente.PlacaVehiculo = txtVehiculo.Value
    End Sub

    Private Sub txtCarreta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCarreta.ValueChanged
        oeGRRemitente.PlacaCarreta = txtCarreta.Value
    End Sub

    Private Sub txtPiloto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPiloto.ValueChanged
        oeGRRemitente.Piloto = txtPiloto.Value
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeGRRemitente.Glosa = txtGlosa.Value
    End Sub

    Private Sub cboEstado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstado.ValueChanged
        oeGRRemitente.IdEstado = cboEstado.Value
    End Sub

    Private Sub cboMotivoTraslado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMotivoTraslado.ValueChanged
        oeGRRemitente.IdMotivoTraslado = cboMotivoTraslado.Value
    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarMateriales()
        End If
    End Sub

    Private Sub griListaMateriales_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.CellChange
        Try
            griListaMateriales.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MenuDetalle_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuDetalle.ToolClick
        Select Case e.Tool.Key
            Case "Consultar"
                ListarMateriales()
            Case "Agregar"
                AgregarDetalle()
            Case "Eliminar"
                QuitarDetalle()
        End Select
    End Sub

    Private Sub griGuiaMaterial_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGuiaMaterial.CellChange
        Try
            griGuiaMaterial.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListadoGuiaRemision_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListadoGuiaRemision.InitializeLayout
        With griListadoGuiaRemision
            .DisplayLayout.Bands(0).Columns("Fecha").Width = 150
            .DisplayLayout.Bands(0).Columns("NroGuia").Width = 120
            .DisplayLayout.Bands(0).Columns("Nombre").Width = 300
            .DisplayLayout.Bands(0).Columns("MotivoTraslado").Width = 280
            .DisplayLayout.Bands(0).Columns("Estado").Width = 100
            .DisplayLayout.Bands(0).Columns("NombreUsuario").Width = 100
            .DisplayLayout.Bands(0).Columns("Glosa").Width = 250
        End With
    End Sub

    Private Sub griListadoGuiaRemision_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListadoGuiaRemision.DoubleClick
        If griListadoGuiaRemision.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnBuscarOrdenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOrdenes.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            ListarOrdenes()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub griOrdenes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griOrdenes.DoubleClick
        If griOrdenes.Rows.Count > 0 Then AsociarOrden()
    End Sub

    Private Sub fecGuiaRemision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecGuiaRemision.ValueChanged
        Try
            If Operacion = "Nuevo" Then
                Select Case fecGuiaRemision.Value
                    Case Is > Date.Now
                        fecGuiaRemision.Value = Date.Now
                        Throw New Exception("La fecha de transferencia no puede ser mayor al día actual")
                    Case Is < CDate(UltimoDiaMesAnterior()).AddMonths(-1)
                        fecGuiaRemision.Value = Date.Now
                        Throw New Exception("La fecha de transferencia no puede ser anterior al mes pasado")
                End Select
            End If
            oeGRRemitente.Fecha = fecGuiaRemision.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        If Not String.IsNullOrEmpty(txtSerie.Text) Then txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        If Not String.IsNullOrEmpty(txtNumero.Text) Then txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
    End Sub

#End Region

#Region "Procedimientos"

    Public Sub ListarMateriales()
        Try
            oeMaterial = New e_Material
            Me.Cursor = Cursors.WaitCursor
            If Not String.IsNullOrEmpty(Trim(txtBuscarMateriales.Text)) Then
                oeMaterial.TipoOperacion = "5"
                oeMaterial.Tipo = 0
                If Not chkBuscaCodigo.Checked Then
                    oeMaterial.Nombre = txtBuscarMateriales.Text
                    oeMaterial.Codigo = String.Empty
                Else
                    oeMaterial.Nombre = String.Empty
                    oeMaterial.Codigo = txtBuscarMateriales.Text
                End If
                listaMaterial = olMaterial.Listar_(oeMaterial)
                With griListaMateriales
                    .DataSource = listaMaterial
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Ubicacion").Hidden = True
                End With
                '------Quitamos los registros de lista de materiales si es que estos ya estan en la lista requerimientos.------
                If listaGRemisionMaterial.Count > 0 Then
                    listaMaterial.RemoveAll(AddressOf VerificaListaMateriales)
                    griListaMateriales.DataBind()
                End If
            Else
                listaMaterial = New List(Of e_Material)
                griListaMateriales.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            griListaMateriales.Focus()
        End Try
    End Sub

    Public Function EditarGuiaRemision() As Boolean
        Try
            If griListadoGuiaRemision.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeGRRemitente.Id = griListadoGuiaRemision.ActiveRow.Cells("Id").Value.ToString
                oeGRRemitente.TipoOperacion = "1"
                oeGRRemitente = olGRRemitente.Obtener(oeGRRemitente)
                oeGRRemitente.PrefijoID = PrefijoIdSucursal '@0001
                cboProveedores.Value = oeGRRemitente.IdEmpresaProveedor
                txtSerie.Value = oeGRRemitente.Serie
                txtNumero.Value = oeGRRemitente.Numero
                fecGuiaRemision.Value = oeGRRemitente.Fecha
                cboEstado.Value = oeGRRemitente.IdEstado
                cboEmpresaOrigen.Value = oeGRRemitente.IdEmpresaOrigen
                CargarDireccion()
                cboDirOrigen.Value = oeGRRemitente.IdDireccionOrigen
                cboDirDestino.Value = oeGRRemitente.IdDireccionDestino
                cboMotivoTraslado.Value = oeGRRemitente.IdMotivoTraslado
                txtVehiculo.Text = oeGRRemitente.PlacaVehiculo
                txtCarreta.Text = oeGRRemitente.PlacaCarreta
                txtPiloto.Text = oeGRRemitente.Piloto
                txtGlosa.Text = oeGRRemitente.Glosa
                ConsultarGuiaMaterial()
                ConsultarAsociaciones(oeGRRemitente.Id, oeGRRemitente.IdTipoGuia)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ConsultarGuiaMaterial()
        Try
            ListarGRRMaterial(True)
            If griGuiaMaterial.Rows.Count > 0 Then
                ControlaBarraOperacionesDetalle(True, True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarGRRMaterial(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeGRemisionMaterial = New e_GuiaRRemitenteMaterial
            listaGRemisionMaterial = New List(Of e_GuiaRRemitenteMaterial)
            oeGRemisionMaterial.TipoOperacion = ""
            oeGRemisionMaterial.IdGuiaRemision = oeGRRemitente.Id
            oeGRemisionMaterial.PrefijoID = PrefijoIdSucursal '@0001
            listaGRemisionMaterial = olGRemisionMaterial.Listar(oeGRemisionMaterial)
            griGuiaMaterial.DataSource = listaGRemisionMaterial
            llenaCombosGrillaOrdenMaterial()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griGuiaMaterial.Focus()
    End Sub

    Sub QuitarDetalle()
        Try
            Select Case ficDetalle.SelectedTab.Index
                Case 0
                    QuitarOrdenMaterial()
                Case 1
                    If lstOrden.Count > 0 Then
                        If MessageBox.Show("¿Esta seguro eliminar la OI Asociada? ", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            Dim IdOrden As String = griListaOrdenIngreso.ActiveRow.Cells("Id").Value.ToString
                            Dim _ref As String = griListaOrdenIngreso.ActiveRow.Cells("Referencia").Value.ToString
                            lstOrden.RemoveAll(Function(item) item.Id = IdOrden)
                            listaGRemisionMaterial.RemoveAll(Function(item) item.Pos.ToString = _ref)
                            griListaOrdenIngreso.DataBind()
                            MostrarListaOrdenes("")
                        End If
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub QuitarOrdenMaterial()
        Try
            Dim sw As Boolean = False
            For Each lista As e_GuiaRRemitenteMaterial In listaGRemisionMaterial.Where(Function(item) item.Seleccion)
                sw = True
                Dim Referencia As String = lista.Pos.ToString
                For Each oeO As e_Orden In lstOrden.Where(Function(item2) item2.Referencia = Referencia)
                    Throw New Exception("Los Materiales se encuentran Asociados a una Orden")
                Next
            Next
            If Not sw Then Throw New Exception("Marque por lo menos un registro para quitar de lista")

            If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", _
                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                listaGRemisionMaterial.RemoveAll(AddressOf verificarSeleccionado)
                griListaMateriales.DataBind()
                griGuiaMaterial.DataBind()
                'CalcularTotalesDetalle()
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function verificarSeleccionado(ByVal obj As e_GuiaRRemitenteMaterial) As Boolean
        Try
            If Not String.IsNullOrEmpty(obj.IdMaterial) Then
                If obj.Seleccion Then
                    Dim oeMaterial As New e_Material
                    oeMaterial.Id = obj.IdMaterial
                    'oeMaterial.IdAlmacen = obj.IdAlmacen
                    oeMaterial.TipoOperacion = "5"
                    oeMaterial.Activo = True
                    oeMaterial = olMaterial.ObtenerMaterialSegunAlmacen(oeMaterial)
                    listaMaterial.Add(oeMaterial)
                End If
            End If
            Return obj.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Sub AgregarDetalle()
        Try
            Dim sw As Boolean = False

            For i As Integer = 0 To listaMaterial.Count - 1
                If listaMaterial.Item(i).Seleccion Then
                    sw = True
                End If
            Next
            If Not sw Then Throw New Exception("Marque por lo menos un Material para Agregar a la Lista de Materiales de la Orden.")
            AsignarGRRMaterial()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    'Pasar los datos de los materiales seleccionado a la los materiales de la guia de remision remitente
    Private Sub AsignarGRRMaterial()
        Try
            For Each obj As e_Material In listaMaterial.Where(Function(item) item.Seleccion)
                oeGRemisionMaterial = New e_GuiaRRemitenteMaterial
                oeGRemisionMaterial.Seleccion = False
                oeGRemisionMaterial.IdMaterial = obj.Id
                oeGRemisionMaterial.Material = obj.Nombre
                oeGRemisionMaterial.CantidadMaterial = 1
                oeGRemisionMaterial.IdTipoUnidadMedida = obj.IdTipoUnidadMedida
                oeGRemisionMaterial.IdUnidadMedida = obj.IdUnidadMedida
                oeGRemisionMaterial.UnidadMedida = obj.UnidadMedida
                oeGRemisionMaterial.Activo = True
                oeGRemisionMaterial.CodigoMaterial = obj.Codigo
                oeGRemisionMaterial.IdSubAlmacen = obj.IdSubAlmacen
                oeGRemisionMaterial.IdAlmacen = obj.IdAlmacen
                oeGRemisionMaterial.Almacen = obj.Almacen
                oeGRemisionMaterial.PrefijoID = PrefijoIdSucursal '@0001
                listaGRemisionMaterial.Add(oeGRemisionMaterial)
            Next
            griGuiaMaterial.DataBind()
            gbeMateriales.Expanded = False
            llenaCombosGrillaOrdenMaterial()
            listaMaterial.RemoveAll(Function(item) item.Seleccion)
            griListaMateriales.DataBind()
            'CalcularTotalesDetalle()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub llenaCombosGrillaOrdenMaterial()
        For j As Integer = 0 To griGuiaMaterial.Rows.Count - 1
            oeUnidadMedida = New e_UnidadMedida()
            oeUnidadMedida.Activo = True
            oeUnidadMedida.Factor = 0
            oeUnidadMedida.IdTipoUnidadMedida = griGuiaMaterial.Rows(j).Cells("IdTipoUnidadMedida").Value.ToString
            CrearComboGridPorCelda("IdUnidadMedida", "Nombre", j, griGuiaMaterial, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)
        Next
        griGuiaMaterial.DataBind()
    End Sub

    Public Sub LlenarDirEmpOrigen(ByVal IdEmpresaOrigen As String)
        oeDireccion = New e_Direccion
        oeDireccion.TipoOperacion = 2
        oeDireccion.Activo = True
        oeDireccion.Id = IdEmpresaOrigen
        LlenarCombo(cboDirOrigen, "Via", olDireccion.Listar(oeDireccion), 0)
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            ValidarFechaDesde_Hasta(rfGuiaRRemitenteDesde, rfGuiaRRemitenteHasta)
            oeGRRemitente = New e_GuiaRemisionRemitente
            oeGRRemitente.TipoOperacion = ""
            oeGRRemitente.IdTipoGuia = ObtenerTipoDocumento("GUÍA DE REMISIÓN - REMITENTE")
            oeGRRemitente.fechaInicio = rfGuiaRRemitenteDesde.Value
            oeGRRemitente.fechaFin = rfGuiaRRemitenteHasta.Value
            oeGRRemitente.Id = ""
            oeGRRemitente.PrefijoID = PrefijoIdSucursal '@0001
            listaGRemision = olGRRemitente.Listar(oeGRRemitente)
            griListadoGuiaRemision.DataSource = listaGRemision
            ''Ubica el cursor el el primer registro de la grilla
            ''grilistaorden.Rows
            If griListadoGuiaRemision.Rows.Count > 0 Then
                griListadoGuiaRemision.Focus()
                griListadoGuiaRemision.Rows.Item(0).Selected = True
            End If

            'For Each fila As UltraGridRow In griListadoGuiaRemision.Rows
            '    Select Case fila.Cells("Estado").Value
            '        Case "GENERADA"
            '            fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
            '        Case "RECEPCIONADA"
            '            fila.CellAppearance.BackColor = Me.ColoresEvaluado.Color
            '        Case "TERMINADA"
            '            fila.CellAppearance.BackColor = Me.ColoresTerminado.Color
            '    End Select
            'Next

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub ObtenerIdProveedorInduamerica(ByVal cad As String)
        Try
            oeProveedor.TipoOperacion = 1
            oeProveedor.Activo = True
            oeProveedor.Nombre = cad
            oeProveedor = olProveedor.ObtenerNomProveedor(oeProveedor)
            oeGRRemitente.IdEmpresaDestino = oeProveedor.IdEmpresa

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Function ObtenerTipoDocumento(ByVal NomTipoDocumento As String) As String
        Try
            oeTipoDocumento = New e_TipoDocumento
            oeTipoDocumento.TipoOperacion = "L"
            oeTipoDocumento.Nombre = NomTipoDocumento
            oeTipoDocumento = olTipoDocumento.Obtener(oeTipoDocumento)
            Return oeTipoDocumento.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Inicializar()
        Try
            oeGRRemitente = New e_GuiaRemisionRemitente
            _ref_orden = 0
            Me.gbeMateriales.Enabled = True
            Me.MenuDetalle.Enabled = True
            txtSerie.Text = String.Empty : txtNumero.Text = String.Empty
            txtVehiculo.Text = String.Empty : txtCarreta.Text = String.Empty : txtPiloto.Text = String.Empty
            txtNFactura.Text = String.Empty : txtGlosa.Text = String.Empty : fecGuiaRemision.Value = Date.Now
            'Fechas para listar Ordenes
            rfechasDesde.Value = Date.Now.AddDays(-7)
            rfechasHasta.Value = Date.Now
            oeGRRemitente.UsuarioCreacion = gUsuarioSGI.Id
            oeGRRemitente.Fecha = fecGuiaRemision.Value
            'Obtener Id de Induamerica como empresa destino
            ObtenerIdProveedorInduamerica(Me.txtProveedor.Text.Trim)
            'Obtener tipo de documento
            oeGRRemitente.IdTipoGuia = ObtenerTipoDocumento("GUÍA DE REMISIÓN - REMITENTE")
            oeGRRemitente.IdEstado = cboEstado.Value
            oeGRRemitente.IdDireccionDestino = cboDirDestino.Value
            gbeMateriales.Expanded = False
            txtBuscarMateriales.Text = String.Empty
            'Limpio las listas
            LimpiarListas()
            'controlo el sub menu
            ControlaBarraOperacionesDetalle(1, 1)
            ''InicializarColores()
            If Operacion = "Nuevo" Then
                txtNumero.Enabled = True
                txtSerie.Enabled = True
            Else
                txtNumero.Enabled = False
                txtSerie.Enabled = False
            End If
            cboProveedores.Text = String.Empty
            cboEmpresaOrigen.SelectedIndex = -1
            cboDirOrigen.SelectedIndex = -1
            cboMotivoTraslado.SelectedIndex = -1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaCombos()
        Try
            oeGRRemitente = New e_GuiaRemisionRemitente
            'LimpiaCombos
            LimpiaCombos(cboEmpresaOrigen)
            LimpiaCombos(cboMotivoTraslado)
            LimpiaCombos(cboEstado)
            LimpiaCombos(cboDirOrigen)

            'Empresa Proveedor
            oeProveedor = New e_Proveedor
            LlenarComboMaestro(cboEmpresaOrigen, olProveedor.Listar(oeProveedor), -1)

            'Motivo Traslado
            oeMotivoTraslado = New e_MotivoTraslado
            oeMotivoTraslado.TipoOperacion = ""
            LlenarComboMaestro(cboMotivoTraslado, olMotivoTraslado.Listar(oeMotivoTraslado), -1)
            'Estados del Proceso de Compras
            oeEstado = New e_Estado
            oeEstado.Nombre = "COMPRAS"
            LlenarComboMaestro(cboEstado, olEstado.Listar(oeEstado), 0)

            'Direcciones de induamerica
            'If oeGRRemitente.IdEmpresaDestino <> "" Then
            oeDireccion = New e_Direccion
            oeDireccion.TipoOperacion = 2
            oeDireccion.Activo = True
            oeDireccion.Id = ISL_IdEmpresa
            LlenarCombo(cboDirDestino, "Via", olDireccion.Listar(oeDireccion), 0)
            'End If

            'Llena Combo Tipo de Orden
            oeTipoOrden = New e_TipoOrden
            oeTipoOrden.TipOoperacion = "D"
            oeTipoOrden.Activo = 1
            cbTipoOrden.ValueMember = "Id"
            cbTipoOrden.DisplayMember = "Nombre"
            cbTipoOrden.DataSource = olTipoOrden.Listar(oeTipoOrden)
            cbTipoOrden.SelectedIndex = 1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpiarListas()
        Try
            lstOrden = New List(Of e_Orden)
            listaMaterial = New List(Of e_Material)
            listaGRemisionMaterial = New List(Of e_GuiaRRemitenteMaterial)
            griListaMateriales.DataSource = listaMaterial
            griGuiaMaterial.DataSource = listaGRemisionMaterial
            griListaOrdenIngreso.DataSource = lstOrden
            cboDirOrigen.DataSource = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ControlaBarraOperacionesDetalle(ByVal lb_Agregar As Boolean, ByVal lb_Quitar As Boolean)
        o_Botonera.Nuevo = lb_Agregar
        o_Botonera.Eliminar = lb_Quitar
        Botones(o_Botonera)
    End Sub



    Private Function GuardarGuiaRemision() As Boolean
        Try
            oeGRRemitente.lstGRRMaterial = listaGRemisionMaterial
            oeGRRemitente.lstOrden = lstOrden
            'If oeGRRemitente.IdMotivoTraslado = "1CH000000001" Then
            '    For Each guimat As e_GuiaRRemitenteMaterial In oeGRRemitente.lstGRRMaterial
            '        If guimat.IdAlmacen <> "1SI000000003" Then
            '            Throw New Exception("La Venta solo se puede Realizar desde el Almacen de Baja")
            '        End If
            '    Next
            'End If
            If CInt(txtSerie.Text) = 0 Then Throw New Exception("Error en Serie de GRR")
            If CInt(txtNumero.Text) = 0 Then Throw New Exception("Error en Numero de GRR")
            If Not String.IsNullOrEmpty(txtSerie.Value) Then oeGRRemitente.Serie = FormatoDocumento(txtSerie.Value.ToString.Trim, 4)
            If Not String.IsNullOrEmpty(txtNumero.Value) Then oeGRRemitente.Numero = FormatoDocumento(txtNumero.Value.ToString.Trim, 10)
            oeGRRemitente.PrefijoID = PrefijoIdSucursal '@0001
            If Not olGRRemitente.Guardar(oeGRRemitente) Then Return False
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            Consultar(True)
            MostrarTabs(0, ficGuiaR)
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function VerificaListaMateriales(ByVal oeMat As e_Material) As Boolean
        For Each filaOrdMat As e_GuiaRRemitenteMaterial In listaGRemisionMaterial
            If (oeMat.Id = filaOrdMat.IdMaterial) Then Return True
        Next
    End Function

    Private Sub ConsultarAsociaciones(ByVal IdDocumento As String, ByVal IdTipoDocumento As String)
        'Buscar Ordenes Asociadas
        oeOrden = New e_Orden
        oeOrden.TipoOperacion = "3"
        oeOrden.Referencia = IdDocumento
        oeOrden.IdTipoOrden = IdTipoDocumento
        oeOrden.PrefijoID = PrefijoIdSucursal '@0001
        lstOrden = olOrden.Listar(oeOrden)
        MostrarListaOrdenes("")
        If lstOrden.Count > 0 Then griListaOrdenIngreso.DataSource = lstOrden : griListaOrdenIngreso.DataBind() : MostrarListaOrdenes(lstOrden.Item(0).TipoOrden)
    End Sub

    Public Sub TrasponerOrdenGuia(ByVal oeOrden As e_Orden)
        Try
            Me.Cursor = Cursors.WaitCursor
            Inicializar()
            Me.Nuevo()
            Me.gbeMateriales.Enabled = 0
            Me.gbeMateriales.Expanded = 0
            Me.MenuDetalle.Enabled = 0
            CargarOrdenAsociada(oeOrden)
            MostrarListaOrdenes("")
            sOrden = 0
            CargarDireccion()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarOrdenAsociada(ByVal oeOrden As e_Orden, Optional ByRef _ref As Integer = 0)
        Try
            Me.cboProveedores.Value = oeOrden.IdProveedor
            oeOrden.Referencia = _ref.ToString
            'Llena la Asociacion
            lstOrden.Add(oeOrden)
            griListaOrdenIngreso.DataSource = lstOrden
            griListaOrdenIngreso.DataBind()
            'Carga el Detalle de la Orden
            Dim llDetalleOrdenIngreso As New List(Of e_OrdenMaterial)
            Dim olDetalleOrdenIngreso As New l_OrdenMaterial
            Dim oeDetalleOrdenIngreso As New e_OrdenMaterial
            oeDetalleOrdenIngreso.TipoOperacion = "L"
            oeDetalleOrdenIngreso.Activo = 1
            oeDetalleOrdenIngreso.IdOrden = oeOrden.Id
            oeDetalleOrdenIngreso.PrefijoID = PrefijoIdSucursal '@0001
            llDetalleOrdenIngreso = olDetalleOrdenIngreso.Listar(oeDetalleOrdenIngreso)
            'Transpone el Detalle de la Orden al Detalle del Documento
            TrasponerDetalleOrden(llDetalleOrdenIngreso, _ref.ToString)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TrasponerDetalleOrden(ByVal lstDetalleOrden As List(Of e_OrdenMaterial), Optional ByVal _ref As String = "0")
        For Each oeDetOrden As e_OrdenMaterial In lstDetalleOrden
            oeDetalleGuia = New e_GuiaRRemitenteMaterial()
            With oeDetalleGuia
                .UsuarioCreacion = gUsuarioSGI.Id
                .Seleccion = False
                .Activo = True
                .IdMaterial = oeDetOrden.IdMaterial
                .CodigoMaterial = oeDetOrden.CodigoMaterial
                .Material = oeDetOrden.Material
                .IdUnidadMedida = oeDetOrden.IdUnidadMedida
                .IdTipoUnidadMedida = oeDetOrden.IdTipoUnidadMedida
                .CantidadMaterial = oeDetOrden.CantidadMaterial
                .IdSubAlmacen = oeDetOrden.IdSubAlmacen
                .Pos = _ref
                .PrefijoID = PrefijoIdSucursal '@0001
            End With
            listaGRemisionMaterial.Add(oeDetalleGuia)
        Next
        griGuiaMaterial.DataBind()
        llenaCombosGrillaOrdenMaterial()
        griGuiaMaterial.DataBind()
    End Sub

    Private Sub AsociarOrden()
        Try
            oeOrden = New e_Orden
            oeOrden = griOrdenes.ActiveRow.ListObject
            For Each oeO As e_Orden In lstOrden.Where(Function(item) item.Id = oeOrden.Id)
                Throw New Exception("La Orden ya esta Asociada")
            Next
            For Each oeOrdenItem As e_Orden In lstOrden.Where(Function(item) item.NombreProveedor <> oeOrden.NombreProveedor)
                Throw New Exception("Escoja Orden del mismo Proveedor")
            Next
            oeOrden = olOrden.Obtener(oeOrden)
            oeOrden.PrefijoID = PrefijoIdSucursal '@0001
            _ref_orden = _ref_orden + 1
            CargarOrdenAsociada(oeOrden, _ref_orden)
            MostrarListaOrdenes(oeOrden.TipoOrden)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Sub MostrarListaOrdenes(ByVal tipo As String)
        If lstOrden.Count > 0 Then
            If tipo.Equals("ORDEN DE COMPRA") Then
                cbTipoOrden.SelectedIndex = 0
                Me.UEGB_Ordenes.Enabled = 0
                Me.UEGB_Ordenes.Expanded = 0
            Else
                Me.UEGB_Ordenes.Enabled = 1
                Me.UEGB_Ordenes.Expanded = 1
            End If
            cbTipoOrden.Enabled = 0
        Else
            cbTipoOrden.Enabled = 1
            Me.UEGB_Ordenes.Enabled = 1
            Me.UEGB_Ordenes.Expanded = 1
        End If
    End Sub

    Private Sub ListarOrdenes()
        Try
            ValidarFechaDesde_Hasta(rfechasDesde, rfechasHasta)
            oeOrden = New e_Orden
            oeOrden.fechaInicio = rfechasDesde.Value
            oeOrden.fechaFin = rfechasHasta.Value
            oeOrden.TipoOperacion = "4"
            oeOrden.IdTipoOrden = cbTipoOrden.Value
            oeOrden.PrefijoID = PrefijoIdSucursal '@0001
            listaO = olOrden.Listar(oeOrden)
            griOrdenes.DataSource = listaO
            griOrdenes.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarLogicas()
        Try
            olGRRemitente = New l_GuiaRemisionRemitente
            olGRemisionMaterial = New l_GuiaRRemitenteMaterial
            olEstado = New l_Estado
            olDireccion = New l_Direccion
            olProveedor = New l_Proveedor
            olMotivoTraslado = New l_MotivoTraslado
            olAlmacen = New l_Almacen
            olMaterial = New l_Material
            olUnidadMedida = New l_UnidadMedida
            olMaterialAlmacen = New l_MaterialAlmacen
            olTipoDocumento = New l_TipoDocumento
            olOrden = New l_Orden
            olTipoOrden = New l_TipoOrden
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaComboProveedor()
        oeProveedor = New e_Proveedor
        oeProveedor.TipoOperacion = "5"
        cboProveedores.Value = Nothing
        With cboProveedores
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = olProveedor.Listar(oeProveedor)
        End With
        InicializarComboProveedor()
    End Sub

    Public Sub CargarDireccion()
        Try
            If cboProveedores.Value <> Nothing Then
                Dim obj As New e_Proveedor
                obj.Id = cboProveedores.Value
                If obj.Id.Trim <> "" Then
                    obj = olProveedor.Obtener(obj)
                    oeGRRemitente.IdEmpresaProveedor = cboProveedores.Value
                    oeGRRemitente.IdEmpresaOrigen = cboProveedores.Value
                    cboEmpresaOrigen.Value = cboProveedores.Value
                    LlenarDirEmpOrigen(obj.IdEmpresa)
                End If
            Else
                cboDirOrigen.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InicializarComboProveedor()
        Try
            Me.cboProveedores.ValueMember = "Id"
            Me.cboProveedores.DisplayMember = "Nombre"
            With cboProveedores.DisplayLayout.Bands(0)
                '.Columns("Id").Hidden = True
                .Columns("Codigo").Hidden = True
                .Columns("TipoPersonaEmpresa").Hidden = True
                .Columns("IdPersona").Hidden = True
                .Columns("IdEmpresa").Hidden = True
                .Columns("FechaActividad").Hidden = True
                .Columns("UsuarioCreacion").Hidden = True
                .Columns("Activo").Hidden = True
                .Columns("Seleccion").Hidden = True
                .Columns("Email").Hidden = True
                .Columns("Contacto").Hidden = True
                .Columns("NroDocumento").Header.Caption = "RUC/DNI"
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"
    'Sub InicializarColores()
    '    Me.ColoresGenerado.Color = Color.White
    '    Me.ColoresEvaluado.Color = Color.Khaki
    '    Me.ColoresTerminado.Color = Color.LightGreen
    'End Sub
    ''Private Sub frm_OrdenIngreso_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    ''    InicializaTiempo()
    ''End Sub
#End Region

#Region "Menú contextual del maestro de Orden de Ingreso"

    Private Sub AsociarMenu()
        griListadoGuiaRemision.ContextMenuStrip = MenuContextual1
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
        If griListadoGuiaRemision.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub
    Private Sub EjecutarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
#End Region

#Region "Valida Solo Ingrese Numeros"
    Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region

End Class
