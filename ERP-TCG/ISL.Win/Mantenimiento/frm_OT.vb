'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_OT
    Inherits ISL.Win.frm_MenuPadre

#Region "Definición del Formulario base"

    Public Sub New()
        oeOrdenTrabajo = New e_OrdenTrabajo
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_OT = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_OT()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de variables y/o objetos"

    Dim oeOrdenTrabajo As e_OrdenTrabajo : Dim olOrdenTrabajo As l_OrdenTrabajo
    Dim oeOTEquipoMantenimiento As e_OrdenTrabajo_MantenimientoEquipo : Dim olOTEquipoMantenimiento As l_OrdenTrabajo_MantenimientoEquipo
    Dim oeOTMaterial As e_OrdenTrabajo_Material : Dim olOTMaterial As l_OrdenTrabajo_Material
    Dim oeOTServicio As e_OrdenTrabajo_Servicio : Dim olOTServicio As l_OrdenTrabajo_Servicio
    Dim oeOTActividad As e_OrdenTrabajo_Actividad : Dim olOTActividad As l_OrdenTrabajo_Actividad
    Dim oeOTRecurso As e_OrdenTrabajo_Recurso : Dim olOTRecurso As l_OrdenTrabajo_Recurso

    Dim oeMantenimientoEquipo As e_MantenimientoEquipo : Dim olMantenimientoEquipo As l_MantenimientoEquipo
    Dim oeMaterial As e_Material : Dim olMaterial As l_Material
    Dim oeServicio As e_Servicio : Dim olServicio As l_Servicio
    Dim oeTrabajador As e_Trabajador : Dim olTrabajador As l_Trabajador
    Dim oeOcupacionTrabajador As e_OcupacionTrabajador : Dim olOcupacionTrabajador As l_OcupacionTrabajador

    Dim oeMantenimientoMaterial As e_MantenimientoMaterial : Dim olMantenimientoMaterial As l_MantenimientoMaterial
    Dim oeMantenimientoServicio As e_MantenimientoServicio : Dim olMantenimientoServicio As l_MantenimientoServicio
    Dim oeMantenimientoActividad As e_MantenimientoActividad : Dim olMantenimientoActividad As l_MantenimientoActividad
    Dim oeMantenimientoOcupacion As e_MantenimientoOcupacion : Dim olMantenimientoOcupacion As l_MantenimientoOcupacion
    Dim oeUnidadMedida As e_UnidadMedida : Dim olUnidadMedida As l_UnidadMedida
    Dim oeMantenimiento As e_Mantenimiento : Dim olMantenimiento As l_Mantenimiento
    Dim oeTipoMantenimiento As e_TipoMantenimiento : Dim olTipoMantenimiento As l_TipoMantenimiento
    Dim oeEstadoOT As e_EstadoOT : Dim olEstadoOT As l_EstadoOT
    Dim oeEquipo As e_Equipo : Dim olEquipo As l_Equipo
    Dim oeVehiculo As e_Vehiculo : Dim olVehiculo As l_Vehiculo
    Dim oeViaje As e_Viaje : Dim oeOperacion As e_Operacion : Dim olOperacion As l_Operacion

    Dim oeMaterialAlmacen As e_MaterialAlmacen : Dim olMaterialAlmacen As l_MaterialAlmacen
    Dim oeSubAlmacen As e_SubAlmacen : Dim olSubAlmacen As l_SubAlmacen
    'Dim oeCategoriaServicio As New e_CategoriaServicio, olCategoriaServicio As New l_CategoriaServicio
    Dim oeOcupacion As e_Ocupacion : Dim olOcupacion As l_Ocupacion
    Dim oeActividad As e_Actividad : Dim olActividad As l_Actividad

    Dim lstEquipoMantenimiento As List(Of e_MantenimientoEquipo)
    Dim lstMantenimientoMaterial As List(Of e_MantenimientoMaterial)
    Dim lstMantenimientoActividad As List(Of e_MantenimientoActividad)
    Dim lstMantenimientoOcupacion As List(Of e_MantenimientoOcupacion)
    Dim lstMantenimientoServicio As List(Of e_MantenimientoServicio)

    Dim lstMateriales As List(Of e_Material)
    Dim lstServicios As List(Of e_Servicio)
    Dim lstActividades As List(Of e_Actividad)
    Dim lstTrabajadores As New List(Of e_OcupacionTrabajador)
    Dim lstTipoMantenimiento As List(Of e_TipoMantenimiento)
    Dim lstEstadoOT As List(Of e_EstadoOT)
    Dim lstMantenimiento As List(Of e_Mantenimiento)
    Dim lstEquipo As List(Of e_Equipo)
    Dim lstCategoriasServicio As List(Of e_CategoriaServicio)
    Dim lstOcupaciones As List(Of e_Ocupacion)
    Dim lstResponsables As List(Of e_Trabajador)

    'Dim lstOTMaterial As New List(Of e_OrdenTrabajo_Material)
    'Dim lstOTEquipoMantenimiento As New List(Of e_OrdenTrabajo_MantenimientoEquipo)

    'Dim _ingresando_datos As Boolean = False
    Dim dsOT_ME As DataSet
    Dim dsOT_ME_Material As DataSet
    Dim dsOT_ME_Servicio As DataSet
    Dim dsOT_ME_Actividad As DataSet
    Dim dsOT_ME_Recurso As DataSet
    Dim dsOT As DataSet
    'Dim dsOTAnteriores As  DataSet

    Dim relationMantEqui As DataRelation
    Dim relationEquMant As DataRelation
    Dim relationEquMant2 As DataRelation ' relacion equipo mantenimiento para el dataset de actividades
    Dim relationEquMant3 As DataRelation ' relacion equipo mantenimiento para el dataset de recursos
    Dim relationEquMant4 As DataRelation ' relacion equipo mantenimiento para el dataset de servicios
    Dim relationMantMat As DataRelation
    Dim relationMantServ As DataRelation
    Dim relationMantAct As DataRelation
    Dim relationMantOcup As DataRelation
    Dim relationOcupTrab As DataRelation

    Dim oeArea As e_Area : Dim olArea As l_Area
    Dim oeUsuario As e_Usuario : Dim olUsuario As l_Usuario
    Dim oeRequerimiento As e_Requerimiento : Dim olRequerimiento As l_Requerimiento
    Dim oeEstadoRequerimiento As e_EstadoRequerimiento : Dim olEstadoRequerimiento As l_EstadoRequerimiento
    Dim oeRequerimientoMaterial As e_RequerimientoMaterial
    Dim oeRequerimientoServicio As e_RequerimientoServicio
    Dim ls_GlosaOrden As String = "" : Dim ls_GlosaEquipos As String = ""
    '
    Dim oeProveedor As e_Proveedor : Dim olProveedor As l_Proveedor
    Dim oeDetalleOrdenIngreso As e_OrdenMaterial : Dim olDetalleOrdenIngreso As l_OrdenMaterial
    Dim cantmat As Double = 0
    Dim costo As Double = 0
    Dim canthor As Date = Date.Parse("01/01/1900")
    Dim ch As Integer = 0
    Dim cd As Integer = 0
    Dim cm As Integer = 0
    '
    Dim IdOT As String = ""
    Dim sw As Boolean

    ''Manejador de Inventario
    Dim oeInventario As e_Inventario : Dim olInventario As l_Inventario
    ''IGV
    Dim oeIGV As e_Impuesto : Dim olIGV As l_Impuesto

    Dim _TipoCambio As Double = 0
    Dim oeTrabajadorSeguridad As e_TrabajadorSeguridad : Dim olTrabajadorSeguridad As l_TrabajadorSeguridad
    Dim oeProcesoNegocio As e_ProcesoNegocio : Dim olProcesoNegocio As l_ProcesoNegocio

    Public Prefijo As l_Configuracion
    Public _idcentro As String

    Dim leDetalleMatAux As List(Of e_OrdenTrabajo_Material)
    Dim oeDetalleMatAux As e_OrdenTrabajo_Material
    Dim olDetalleMarAux As l_OrdenTrabajo_Material
    Dim _lsMensajeAtiente As String = ""

    Dim oeCombo As e_Combo

    Private datoValido As Boolean

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ListarOrdenesTrabajo()
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_OrdenTrabajo.Rows.Count > 0 Then
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
            oeOrdenTrabajo = New e_OrdenTrabajo
            oeOrdenTrabajo.TipoOperacion = "I"
            oeOrdenTrabajo.UsuarioCreacion = gUsuarioSGI.Id
            oeEstadoOT = New e_EstadoOT
            oeEstadoOT.Nombre = "PENDIENTE"
            oeEstadoOT = olEstadoOT.Obtener(oeEstadoOT)
            oeOrdenTrabajo.IdEstadoOT = oeEstadoOT.Id
            MostrarTabs(1, ficOrdenTrabajo, 1)
            Inicializa()
            FormatearFormulario(True)
            FormatearGrillaMateriales()
            cbe_Tipo.Focus()
            Me.txtEstado.Text = "POR GENERAR"
            For i As Integer = 0 To ficOrdenTrabajoDet.Tabs.Count - 1
                ficOrdenTrabajoDet.Tabs(i).Enabled = False
            Next
            ficOrdenTrabajoDet.Tabs(0).Enabled = True
            cbe_Tipo.SelectedIndex = 0
            'Me.mnDetalle.Tools("Devolucion").SharedProps.Visible = False
            Operacion = "Nuevo"
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            oeOrdenTrabajo = New e_OrdenTrabajo
            FormatearGrillaMateriales()
            MostrarOrdenTrabajo(IdOT)
            oeOrdenTrabajo.TipoOperacion = "A"
            txtNroOT.Focus()
            For i As Integer = 0 To ficOrdenTrabajoDet.Tabs.Count - 1
                ficOrdenTrabajoDet.Tabs(i).Enabled = True
            Next
            Select Case oeOrdenTrabajo.EstadoOT
                Case gNombreEstadoTerminada, gNombreEstadoAnulado
                    Operacion = "Vista"
                    'MyBase.Vista()
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 0)
                Case Else
                    Operacion = "Editar"
                    'MyBase.Editar()
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarOrdenTrabajo() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficOrdenTrabajo, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeOrdenTrabajo.Modificado And txtEstado.Text <> "TERMINADA" Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarOrdenTrabajo() Then
                            MostrarTabs(0, ficOrdenTrabajo, 2)
                            Operacion = "Inicializa"
                            MyBase.Consultar(True)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficOrdenTrabajo, 2)
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                End Select
            Else
                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If ValidarGrilla(grid_OrdenTrabajo, "Orden Trabajo") Then
                With grid_OrdenTrabajo
                    If .ActiveRow.Band.Index = 0 Then
                        'AnularOT(.ActiveRow.Cells("IdOT").Value.ToString)
                    Else
                        Throw New Exception("Seleccione una Orden de Trabajo")
                    End If
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficOrdenTrabajo.SelectedTab.Index
                Case 0
                    If grid_OrdenTrabajo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                    Exportar_Excel(grid_OrdenTrabajo)
                Case 1
                    Select Case ficOrdenTrabajoDet.SelectedTab.Index
                        Case 0
                            If grid_OT_ME.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                            Exportar_Excel(grid_OT_ME)
                        Case 1
                            If grid_OTMateriales.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                            Exportar_Excel(grid_OTMateriales)
                        Case 2
                            If grid_OTServicios.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                            Exportar_Excel(grid_OTServicios)
                        Case 3
                            If grid_OTRecursos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                            Exportar_Excel(grid_OTRecursos)
                        Case 4
                            If grid_OTActividades.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                            Exportar_Excel(grid_OTActividades)
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_OT_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Editar", "Nuevo"
                'Editar()
                'cache.ForzarActualizacion = True
                'ListarEquiposMantenimiento(True)
            Case "Inicializa"
                Tiempo1.Enabled = False
                InicializaTiempo()
                MostrarTabs(0, ficOrdenTrabajo)
                'Consultar(True)
        End Select
    End Sub

    Private Sub frm_OT_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_OT_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            oeMantenimiento = New e_Mantenimiento
            oeMaterial = New e_Material
            InicializarLogicas()
            IniciarForm()
            ListarOT()
            LlenaCombos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbProveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ListarProveedores(cboProveedor, "0", cbRuc.Checked)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbProveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProveedor.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                cboProveedor.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.Dropdown)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbProveedor_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedor.InitializeLayout
        Me.cboProveedor.ValueMember = "Id"
        Me.cboProveedor.DisplayMember = "Nombre"
        With cboProveedor.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Email").Hidden = True
            .Columns("Seleccion").Hidden = True
            .Columns("Contacto").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("TipoPersonaEmpresa").Hidden = True
            .Columns("IdPersona").Hidden = True
            .Columns("IdEmpresa").Hidden = True
            .Columns("FechaActividad").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("NroDocumento").Header.Caption = "N° RUC"
            .Columns("NroDocumento").Width = 50
            .Columns("Nombre").Width = 150
        End With
    End Sub

    Private Sub rbNroOT_CheckedChanged(sender As Object, e As EventArgs) Handles rbNroOT.CheckedChanged
        gbNroOT.Enabled = rbNroOT.Checked
        txtOT.Focus()
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(sender As Object, e As EventArgs) Handles rbDatosAdicionales.CheckedChanged
        gbDatosAdicionales.Enabled = rbDatosAdicionales.Checked
        txtOT.Text = String.Empty
    End Sub

    Private Sub optFechas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optFechas.ValueChanged
        If optFechas.CheckedIndex <> -1 Then
            dtp_DesdeProg.Enabled = IIf(optFechas.CheckedIndex = 0, True, False)
            dtp_HastaProg.Enabled = IIf(optFechas.CheckedIndex = 0, True, False)
            rfDesde.Enabled = IIf(optFechas.CheckedIndex = 1, True, False)
            rfHasta.Enabled = IIf(optFechas.CheckedIndex = 1, True, False)
        End If
    End Sub

    Private Sub optIndicadorTipo_ValueChanged(sender As Object, e As EventArgs)
        If cbe_Tipo.SelectedIndex <> -1 Then
            Select Case cbe_Tipo.SelectedIndex
                Case 0
                    oeOrdenTrabajo.IndicadorTipo = "I"
                    ficOrdenTrabajoDet.Tabs(3).Visible = True
                    cboProveedor.Enabled = False
                    ListarProveedores(cboProveedor, ISL_IdProveedor, 0)
                    cboProveedor.Value = ISL_IdProveedor
                Case 1
                    oeOrdenTrabajo.IndicadorTipo = "E"
                    ficOrdenTrabajoDet.Tabs(3).Visible = False
                    ficOrdenTrabajoDet.Tabs(2).Visible = True
                    cboProveedor.Enabled = True
                    cboProveedor.Text = String.Empty
                    cboProveedor.DataSource = Nothing
            End Select
            FormatearGrillaMateriales()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            AgregarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            QuitarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnDevolucion_Click(sender As Object, e As EventArgs) Handles btnDevolucion.Click
        Try
            GenerarDevolucionMaterial()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If MessageBox.Show("AVERTENCIA: Si Usted a realizados cambios," & Environment.NewLine & _
                                   "al realizar esta operación se perderan" & Environment.NewLine & _
                                   "¿Desea Actualizar los Materiales?", "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                ListarMaterialesOT(IdOT)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Equipos_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Equipos.CellChange
        grid_Equipos.UpdateData()
    End Sub

    Private Sub btnBuscaOcupacion_Click(sender As Object, e As EventArgs) Handles btnBuscaOcupacion.Click
        ListarOperarios()
    End Sub

    Private Sub grid_Equipos_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Equipos.DoubleClickRow
        With grid_Equipos
            If .Rows.Count > 0 Then
                If .ActiveRow.IsGroupByRow Then
                    If .ActiveRow.ChildBands(0).Rows(0).Cells("IdEquipo").Value <> Nothing Then
                        Dim IdEquipo As String = .ActiveRow.ChildBands(0).Rows(0).Cells("IdEquipo").Value
                        'ConsultarMantenimientosAnteriores(IdEquipo)
                        'gbeOTsAnteriores.Expanded = True
                    End If
                Else
                    'gbeOTsAnteriores.Expanded = False
                End If
            End If
        End With
    End Sub

    Private Sub grid_Equipos_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_Equipos.InitializeLayout
        With grid_Equipos
            .DisplayLayout.Bands(0).SortedColumns.Add("Equipo", False, True)
            .DisplayLayout.GroupByBox.Hidden = True
        End With
    End Sub

    Private Sub txtBuscarEquipo_ValueChanged(sender As Object, e As EventArgs) Handles txtBuscarEquipo.ValueChanged
        With grid_Equipos.DisplayLayout.Bands(0)
            .ColumnFilters.ClearAllFilters()
            If Not String.IsNullOrEmpty(Me.txtBuscarEquipo.Text) Then
                .ColumnFilters.LogicalOperator = Infragistics.Win.UltraWinGrid.FilterLogicalOperator.Or
                .ColumnFilters("Equipo").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Contains, _
                                                                Me.txtBuscarEquipo.Text)
            Else
                .ColumnFilters.ClearAllFilters()
                For x As Integer = 0 To grid_Equipos.Rows.Count - 1
                    Me.grid_Equipos.Rows(x).CollapseAll()
                Next
            End If
        End With
    End Sub

    Private Sub txtOT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOT.KeyDown
        If e.KeyCode = Keys.Enter Then Consultar(True)
    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then ListarMateriales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_OrdenTrabajo_AfterRowActivate(sender As Object, e As EventArgs) Handles grid_OrdenTrabajo.AfterRowActivate
        If grid_OrdenTrabajo.ActiveRow.Band.Index = 0 Then
            Select Case grid_OrdenTrabajo.ActiveRow.Cells("Estado").Value
                Case "PENDIENTE"
                    Me.btnIniciarOT.Enabled = True : Me.btnTerminarOT.Enabled = False : Me.btnLiberarUnidad.Enabled = False : Me.btnAnularOT.Enabled = True
                Case "EN PROCESO"
                    Me.btnIniciarOT.Enabled = False : Me.btnTerminarOT.Enabled = True : Me.btnLiberarUnidad.Enabled = True : Me.btnAnularOT.Enabled = True
                Case "LIBERADA"
                    Me.btnIniciarOT.Enabled = False : Me.btnTerminarOT.Enabled = True : Me.btnLiberarUnidad.Enabled = False : Me.btnAnularOT.Enabled = True
                Case "TERMINADA", "ANULADA"
                    Me.btnIniciarOT.Enabled = False : Me.btnTerminarOT.Enabled = False : Me.btnLiberarUnidad.Enabled = False : Me.btnAnularOT.Enabled = False
            End Select
        Else
            Me.btnIniciarOT.Enabled = False : Me.btnTerminarOT.Enabled = False : Me.btnLiberarUnidad.Enabled = False : Me.btnAnularOT.Enabled = False
        End If
    End Sub

    Private Sub grid_OrdenTrabajo_DoubleClickCell(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles grid_OrdenTrabajo.DoubleClickCell
        Try
            If grid_OrdenTrabajo.Rows.Count > 0 AndAlso grid_OrdenTrabajo.ActiveRow.Band.Index = 0 Then
                If e.Cell.Column.Key = "Estado" Then
                    If grid_OrdenTrabajo.ActiveRow.Cells("Estado").Value.ToString = "TERMINADA" Then
                        Dim oeDetalleConfirma As New e_DetalleRegConformidadOT
                        Dim olDetalleConfirma As New l_DetalleRegConformidadOT
                        oeDetalleConfirma.TipoOperacion = ""
                        oeDetalleConfirma.IdOT = grid_OrdenTrabajo.ActiveRow.Cells("IdOT").Value.ToString
                        oeDetalleConfirma = olDetalleConfirma.Obtener(oeDetalleConfirma)
                        If oeDetalleConfirma IsNot Nothing Then
                            If oeDetalleConfirma.Activo = True And oeDetalleConfirma.IdRegConformidadOT <> "" Then
                                mensajeEmergente.Problema("No puede cambar la Orden Trabajo por que ya esta confirmada", True)
                            Else
                                If MessageBox.Show("¿Desea cambiar la OT Termina a en Proceso?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                    CambiarEstadoOT()
                                    Consultar(True)
                                    grid_OrdenTrabajo.Focus()
                                End If
                            End If
                        End If

                    End If
                Else
                    IdOT = grid_OrdenTrabajo.ActiveRow.Cells("IdOT").Value.ToString
                    Editar()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gbeServicios_ExpandedStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbeServicios.ExpandedStateChanged
        If gbeServicios.Expanded Then
            Try
                ListarServicios()
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try
            grid_Servicios.Focus()
        End If
    End Sub

    Private Sub gbeServicios_ExpandedStateChanging(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gbeServicios.ExpandedStateChanging
        Try
            If Not gbeServicios.Expanded Then
                If grid_OTServicios.ActiveRow.Band.Index <> 1 Then
                    e.Cancel = True
                    Throw New Exception("Seleccione un mantenimiento para agregar servicios")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gbeMateriales_ExpandedStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbeMateriales.ExpandedStateChanged
        If gbeMateriales.Expanded Then
            Me.txtBuscarMateriales.Text = String.Empty
            If PerfilAsignado(gNombrePerfilAdministrador) Or PerfilAsignado(gNombrePerfilJefeMantenimiento) Then
                cboCentroMaterial.Enabled = True
            Else
                cboCentroMaterial.Enabled = False
            End If
            cboCentroMaterial.Value = _idcentro
            lstMateriales = New List(Of e_Material)
        End If
    End Sub

    Private Sub gbeMateriales_ExpandedStateChanging(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gbeMateriales.ExpandedStateChanging
        Try
            If Not gbeMateriales.Expanded Then
                If grid_OTMateriales.ActiveRow.Band.Index <> 1 Then
                    e.Cancel = True
                    Throw New Exception("Seleccione un mantenimiento para agregar materiales")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbe_Tipo_ValueChanged(sender As Object, e As EventArgs) Handles cbe_Tipo.ValueChanged
        cboProveedor.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.Dropdown)
        ficOrdenTrabajoDet.Tabs(2).Visible = True
        ficOrdenTrabajoDet.Tabs(3).Visible = True
        ficOrdenTrabajoDet.Tabs(4).Visible = True
        If cbe_Tipo.SelectedIndex <> -1 Then
            oeMantenimiento.Modificado = True
            Select Case cbe_Tipo.SelectedIndex
                Case 0
                    oeOrdenTrabajo.IndicadorTipo = "I"
                    ficOrdenTrabajoDet.Tabs(3).Visible = True
                    cboProveedor.Enabled = False
                    ListarProveedores(cboProveedor, ISL_IdClienteProveedor, False)
                    cboProveedor.Value = ISL_IdProveedor
                    grid_Equipos.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
                    For x As Integer = 0 To grid_Equipos.Rows.Count - 1
                        Me.grid_Equipos.Rows(x).CollapseAll()
                    Next
                Case 1
                    oeOrdenTrabajo.IndicadorTipo = "E"
                    ficOrdenTrabajoDet.Tabs(3).Visible = False
                    ficOrdenTrabajoDet.Tabs(2).Visible = True
                    cboProveedor.Enabled = True
                    cboProveedor.Text = String.Empty
                    cboProveedor.DataSource = Nothing
                    grid_Equipos.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
                    For x As Integer = 0 To grid_Equipos.Rows.Count - 1
                        Me.grid_Equipos.Rows(x).CollapseAll()
                    Next
                Case 2
                    oeOrdenTrabajo.IndicadorTipo = "M"
                    dsOT_ME.Clear()
                    txtBuscarEquipo.Text = String.Empty
                    oeCombo = New e_Combo
                    oeCombo.Id = cbe_Tipo.Value
                    oeCombo.Tipo = 0
                    oeCombo = OTEquAlmPublic.Item(OTEquAlmPublic.IndexOf(oeCombo))
                    ficOrdenTrabajoDet.Tabs(2).Visible = False
                    ficOrdenTrabajoDet.Tabs(3).Visible = False
                    ficOrdenTrabajoDet.Tabs(4).Visible = False
                    cboProveedor.Enabled = False
                    ListarProveedores(cboProveedor, "1CH000010950", False)
                    cboProveedor.Value = "1CH000010950"
                    ConfiguarOTMack()
            End Select
            FormatearGrillaMateriales()
        End If
    End Sub

    Private Sub grid_OTMateriales_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_OTMateriales.AfterRowsDeleted
        oeOrdenTrabajo.Modificado = True
    End Sub

    Private Sub grid_OTServicios_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_OTServicios.AfterRowsDeleted
        oeOrdenTrabajo.Modificado = True
    End Sub

    Private Sub grid_OTRecursos_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_OTRecursos.AfterRowsDeleted
        oeOrdenTrabajo.Modificado = True
    End Sub

    Private Sub grid_OTActividades_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_OTActividades.AfterRowsDeleted
        oeOrdenTrabajo.Modificado = True
    End Sub

    Private Sub grid_OT_ME_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_OT_ME.AfterCellUpdate
        Try
            oeOrdenTrabajo.Modificado = True
            With grid_OT_ME
                Select Case e.Cell.Column.Key.ToUpper
                    Case "Odometro"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("Odometro").Value = 0
                            Exit Sub
                        End If
                        Dim kmver As Double = e.Cell.Value  '200,000 ingresa km
                        Dim km As Double = .ActiveRow.Cells("OdometroAct").Value '18,000 odometro
                        Dim kmmax As Double = km + 1000 '19,000
                        Dim kmmin As Double = km - 1000 '17,000
                        If km > 0 Then
                            If e.Cell.Value > 1 Then
                                If kmver >= kmmax OrElse kmver <= kmmin Then
                                    .ActiveRow.Cells("Odometro").Value = km
                                    Throw New Exception("El kilometraje de: " & .ActiveRow.Cells("EquipoMantenimiento").Value & " debe estar dentro del rango: " & kmmin & " a " & kmmax)
                                End If
                            Else
                                .ActiveRow.Cells("Odometro").Value = km
                                Throw New Exception("El kilometraje de: " & .ActiveRow.Cells("EquipoMantenimiento").Value & " debe ser mayor que: " & km)
                            End If
                        End If
                    Case "Horometro"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("Horometro").Value = 0
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_OT_ME_BeforeCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grid_OT_ME.BeforeCellUpdate
        Try
            With grid_OT_ME
                Select Case e.Cell.Column.Key.ToUpper
                    Case "Odometro"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                    Case "Horometro"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_OTMateriales_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_OTMateriales.AfterCellUpdate
        oeOrdenTrabajo.Modificado = True
        Try
            With grid_OTMateriales
                Select Case e.Cell.Column.Key.ToUpper
                    Case "CantidadMaterial"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("CantidadMaterial").Value = cantmat
                            Exit Sub
                        End If
                        If e.Cell.Value > 0 Then
                            If e.Cell.Value < .ActiveRow.Cells("CantidadMaterialEntregada").Value Then
                                .ActiveRow.Cells("CantidadMaterial").Value = .ActiveRow.Cells("CantidadMaterialEntregada").Value
                                datoValido = False
                                Throw New Exception("No se puede cambiar la cantidad programada, no puede ser menor a la cantidad entregada " & Environment.NewLine & "Cantidad entregada = " & .ActiveRow.Cells("CantidadMaterialEntregada").Value)
                            End If
                        Else
                            .ActiveRow.Cells("CantidadMaterial").Value = 1
                            datoValido = False
                            Throw New Exception("La cantidad programada, no puede ser 0.")
                        End If

                    Case "Costo"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("Costo").Value = 0
                            Exit Sub
                        End If
                    Case "IdAlmacen"
                        If .ActiveRow.Band.Index = 2 Then
                            oeMaterial = New e_Material
                            If .ActiveRow.Index > -1 Then
                                oeMaterial.TipoOperacion = "5"
                                oeMaterial.Id = .ActiveRow.Cells("IdMaterial").Value
                                oeMaterial.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value
                                oeMaterial.Activo = True
                                oeMaterial = olMaterial.ObtenerMaterialSegunAlmacen(oeMaterial)
                                .ActiveRow.Cells("Stock").Value = oeMaterial.Stock

                                .ActiveRow.Cells("Costo").Value = ObtenerValorUnitario(.ActiveRow.Cells("IdMaterial").Value, .ActiveRow.Cells("IdAlmacen").Value)


                                SubAlmacenValueList(.ActiveRow.Cells("IdAlmacen").Value.ToString)
                                .ActiveRow.Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")

                                oeSubAlmacen = New e_SubAlmacen
                                oeSubAlmacen.TipoOperacion = "S"
                                oeSubAlmacen.Activo = True
                                oeSubAlmacen.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value.ToString
                                .ActiveRow.Cells("IdSubAlmacen").Value = olSubAlmacen.Obtener(oeSubAlmacen).Id
                            End If
                        End If
                End Select
            End With
            datoValido = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_OTMateriales_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grid_OTMateriales.BeforeCellUpdate
        Try
            With grid_OTMateriales
                Select Case e.Cell.Column.Key.ToUpper
                    Case "CANTIDADMATERIAL"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                    Case "COSTO"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_OTMateriales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_OTMateriales.CellChange
        Try
            With grid_OTMateriales
                Select Case e.Cell.Column.Key.ToUpper
                    Case "SELECCION"
                        .UpdateData()
                        Select Case .ActiveRow.Band.Index
                            Case 1
                                For Each matRow As DataRow In dsOT_ME_Material.Tables(2).Rows
                                    If .ActiveRow.Cells("IdMantenimientoEquipo").Value = matRow("IdMantenimientoEquipo") Then
                                        matRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                                    End If
                                Next
                            Case 2
                                Dim cont As Integer = 0, cont2 As Integer = 0
                                For Each matRow As DataRow In dsOT_ME_Material.Tables(2).Rows
                                    If .ActiveRow.Cells("IdMantenimientoEquipo").Value = matRow("IdMantenimientoEquipo") Then
                                        If matRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value Then
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
                    Case "COSTO", "IDALMACEN"
                        .UpdateData()
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub grid_OTServicios_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_OTServicios.AfterCellUpdate
        Try
            oeOrdenTrabajo.Modificado = True
            With grid_OTServicios
                Select Case e.Cell.Column.Key.ToUpper
                    Case "COSTO"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("Costo").Value = 0
                            Exit Sub
                        End If
                        If e.Cell.Value <> Math.Round((.ActiveRow.Cells("CostoDolares").Value * _TipoCambio), 2) Then
                            .ActiveRow.Cells("CostoDolares").Value = Math.Round((e.Cell.Value / _TipoCambio), 2)
                        End If
                    Case "COSTODOLARES"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("CostoDolares").Value = 0
                            Exit Sub
                        End If
                        If e.Cell.Value <> Math.Round((.ActiveRow.Cells("Costo").Value / _TipoCambio), 2) Then
                            .ActiveRow.Cells("Costo").Value = Math.Round((e.Cell.Value * _TipoCambio), 2)
                        End If
                End Select
                CalcularTotalServicios()
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_OTRecursos_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_OTRecursos.AfterCellUpdate
        Try
            oeOrdenTrabajo.Modificado = True
            With grid_OTRecursos
                Dim cont As Integer = 0, cont2 As Integer = 0
                Select Case e.Cell.Column.Key.ToUpper
                    Case "SELECCION"
                        If .ActiveRow.ParentRow.Band.Index = 2 Then
                            For Each mantRow As DataRow In dsOT_ME_Recurso.Tables(1).Rows
                                For Each ocupRow As DataRow In mantRow.GetChildRows(relationMantOcup)
                                    If .ActiveRow.ParentRow.Cells("IdMantenimientoEquipo").Value = ocupRow("IdMantenimientoEquipo") Then
                                        If ocupRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value Then cont += 1
                                        cont2 += 1
                                    End If
                                Next
                                If cont = cont2 Then
                                    mantRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                                Else
                                    If Not .ActiveRow.Cells("Seleccion").Value Then
                                        mantRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                                    End If
                                End If
                            Next
                        End If
                    Case "CANTIDADHORAS"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("CantidadHoras").Value = canthor
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_OTActividades_BeforeCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grid_OTActividades.BeforeCellUpdate
        Try
            With grid_OTActividades
                Select Case e.Cell.Column.Key.ToUpper
                    Case "CANTIDADDIAS"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                        'If e.NewValue > 365 Then
                        '    ch = IIf(IsDBNull(e.Cell.Value), 0, e.Cell.Value)
                        'End If
                    Case "CANTIDADHORAS"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                        If e.NewValue > 23 Then
                            ch = e.NewValue
                        End If
                    Case "CANTIDADMINUTOS"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                        If e.NewValue > 59 Then
                            cm = e.NewValue
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_OTActividades_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_OTActividades.AfterCellUpdate
        oeOrdenTrabajo.Modificado = True
        With grid_OTActividades
            Select Case e.Cell.Column.Key
                Case "CantidadDias"
                    If IsDBNull(e.Cell.Value) Then
                        .ActiveRow.Cells("CantidadDias").Value = 0
                        Exit Sub
                    Else
                        If .ActiveRow.Cells("CantidadDias").Value > 365 Then
                            .ActiveRow.Cells("CantidadDias").Value = 0
                        End If
                    End If
                Case "CantidadHoras"
                    If IsDBNull(e.Cell.Value) Then
                        .ActiveRow.Cells("CantidadHoras").Value = 0
                        Exit Sub
                    Else
                        If .ActiveRow.Cells("CantidadHoras").Value > 23 Then
                            .ActiveRow.Cells("CantidadHoras").Value = ch Mod 24
                            .ActiveRow.Cells("CantidadDias").Value += (ch / 24)
                        End If
                    End If
                Case "CantidadMinutos"
                    If IsDBNull(e.Cell.Value) Then
                        .ActiveRow.Cells("CantidadMinutos").Value = 0
                        Exit Sub
                    Else
                        If .ActiveRow.Cells("CantidadMinutos").Value > 59 Then
                            .ActiveRow.Cells("CantidadMinutos").Value = cm Mod 60
                            .ActiveRow.Cells("CantidadHoras").Value += (cm / 60)
                        End If
                    End If
            End Select
            CalcularFechaTentativaSalida()
        End With
    End Sub

    Private Sub grid_Materiales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Materiales.CellChange
        grid_Materiales.UpdateData()
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        txtGlosa.Text = LTrim(txtGlosa.Text)
        oeOrdenTrabajo.Glosa = txtGlosa.Text
    End Sub

    Private Sub cbAuxilio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAuxilio.CheckedChanged
        oeOrdenTrabajo.Auxilio = cbAuxilio.Checked
    End Sub

    Private Sub cbSiniestro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSiniestro.CheckedChanged
        oeOrdenTrabajo.Siniestro = cbSiniestro.Checked
    End Sub

    Private Sub cbCalibracion_CheckedChanged(sender As Object, e As EventArgs) Handles cbCalibracion.CheckedChanged
        oeOrdenTrabajo.Calibracion = cbCalibracion.Checked
    End Sub

    Private Sub dtpFechaProg_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaProg.ValueChanged
        oeOrdenTrabajo.FechaProgramacionIni = dtpFechaProg.Value
    End Sub

    Private Sub btnIniciarOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciarOT.Click
        Try
            IniciarOT(grid_OrdenTrabajo.ActiveRow.Cells("IdOT").Value.ToString)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmTipoMantenimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmTipoMantenimiento.ValueChanged
        Try
            LlenaComboMantenimiento(cmTipoMantenimiento.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_OTRecursos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_OTRecursos.CellChange
        Try
            With grid_OTRecursos
                .UpdateData()
                If e.Cell.Column.Key.ToUpper = "SELECCION" Then
                    Dim cont As Integer = 0, cont2 As Integer = 0, cont3 As Integer = 0, cont4 As Integer = 0
                    Select Case .ActiveRow.Band.Index
                        Case 1
                            For Each ocupRow As DataRow In dsOT_ME_Recurso.Tables(2).Rows
                                If .ActiveRow.Cells("IdMantenimientoEquipo").Value = ocupRow("IdMantenimientoEquipo") Then
                                    ocupRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                                    For Each opeRow As DataRow In ocupRow.GetChildRows(relationOcupTrab)
                                        opeRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                                    Next
                                End If
                            Next
                        Case 2
                            For Each opeRow As DataRow In dsOT_ME_Recurso.Tables(3).Rows
                                If .ActiveRow.Cells("IdMantenimientoEquipo").Value = opeRow("IdMantenimientoEquipo") And .ActiveRow.Cells("IdOcupacion").Value = opeRow("IdOcupacion") Then
                                    opeRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                                End If
                            Next
                            For Each ocupRow As DataRow In dsOT_ME_Recurso.Tables(2).Rows
                                If .ActiveRow.Cells("IdMantenimientoEquipo").Value = ocupRow("IdMantenimientoEquipo") Then
                                    If ocupRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value Then cont += 1
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
                        Case 3
                            For Each opeRow As DataRow In dsOT_ME_Recurso.Tables(3).Rows
                                If .ActiveRow.Cells("IdMantenimientoEquipo").Value = opeRow("IdMantenimientoEquipo") And .ActiveRow.Cells("IdOcupacion").Value = opeRow("IdOcupacion") Then
                                    If opeRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value Then cont += 1
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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Operarios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Operarios.CellChange
        Try
            grid_Operarios.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Servicios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Servicios.CellChange
        Try
            grid_Servicios.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Actividades_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Actividades.CellChange
        Try
            grid_Actividades.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_OT_ME_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_OT_ME.CellChange
        Try
            With grid_OT_ME
                Select Case e.Cell.Column.Key.ToUpper
                    Case "Seleccion"
                        .UpdateData()
                        Select Case .ActiveRow.Band.Index
                            Case 0
                                For Each mantRow As DataRow In dsOT_ME.Tables(1).Rows
                                    If .ActiveRow.Cells("IdEquipo").Value = mantRow("IdEquipo") Then
                                        mantRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                                    End If
                                Next
                            Case 1
                                Dim cont As Integer = 0, cont2 As Integer = 0
                                For Each mantRow As DataRow In dsOT_ME.Tables(1).Rows
                                    If .ActiveRow.Cells("IdEquipo").Value = mantRow("IdEquipo") Then
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
                    Case "RESPONSABLE"
                        .UpdateData()
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_OT_ME_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_OT_ME.AfterRowsDeleted
        grid_OT_ME.UpdateData()
        dsOT_ME.AcceptChanges()
        oeOrdenTrabajo.Modificado = True
    End Sub

    Private Sub grid_OT_ME_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_OT_ME.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea eliminar los registros marcados?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True
    End Sub

    Private Sub grid_OTActividades_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_OTActividades.CellChange
        Try
            With grid_OTActividades
                .UpdateData()
                If e.Cell.Column.Key.ToUpper = "Seleccion" Then
                    Select Case .ActiveRow.Band.Index
                        Case 1
                            For Each actRow As DataRow In dsOT_ME_Actividad.Tables(2).Rows
                                If .ActiveRow.Cells("IdMantenimientoEquipo").Value = actRow("IdMantenimientoEquipo") Then
                                    actRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                                End If
                            Next
                        Case 2
                            Dim cont As Integer = 0, cont2 As Integer = 0
                            For Each actRow As DataRow In dsOT_ME_Actividad.Tables(2).Rows
                                If .ActiveRow.Cells("IdMantenimientoEquipo").Value = actRow("IdMantenimientoEquipo") Then
                                    If actRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value Then
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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_OTServicios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_OTServicios.CellChange
        Try
            With grid_OTServicios
                .UpdateData()
                If e.Cell.Column.Key.ToUpper = "Seleccion" Then
                    Select Case .ActiveRow.Band.Index
                        Case 1

                            For Each servRow As DataRow In dsOT_ME_Servicio.Tables(2).Rows
                                If .ActiveRow.Cells("IdMantenimientoEquipo").Value = servRow("IdMantenimientoEquipo") Then
                                    servRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                                End If
                            Next
                        Case 2
                            Dim cont As Integer = 0, cont2 As Integer = 0
                            For Each servRow As DataRow In dsOT_ME_Servicio.Tables(2).Rows
                                If .ActiveRow.Cells("IdMantenimientoEquipo").Value = servRow("IdMantenimientoEquipo") Then
                                    If servRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value Then
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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmbJefeTaller_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJefeTaller.ValueChanged
        oeOrdenTrabajo.Modificado = True
        oeOrdenTrabajo.IdJefeTaller = cmbJefeTaller.Value
    End Sub

    Private Sub cmbSupervisorMant_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSupervisorMant.ValueChanged
        oeOrdenTrabajo.Modificado = True
        oeOrdenTrabajo.IdSupervisorMant = cmbSupervisorMant.Value
    End Sub

    Private Sub btnListarMateriales_Click(sender As Object, e As EventArgs) Handles btnListarMateriales.Click
        Try
            ListarMateriales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtBuscarMateriales_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarMateriales.ValueChanged
        txtBuscarMateriales.Text = LTrim(txtBuscarMateriales.Text)
        oeMaterial.Nombre = txtBuscarMateriales.Text
    End Sub

    Private Sub btnTerminarOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminarOT.Click
        TerminarOT(grid_OrdenTrabajo.ActiveRow.Cells("IdOT").Value.ToString)
    End Sub

    Private Sub ficOrdenTrabajoDet_SelectedTabChanged(sender As Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficOrdenTrabajoDet.SelectedTabChanged
        btnDevolucion.Enabled = IIf(ficOrdenTrabajoDet.SelectedTab.Index = 1, True, False)
        btnActualizar.Enabled = IIf(ficOrdenTrabajoDet.SelectedTab.Index = 1, True, False)
    End Sub

    Private Sub cbAuxilio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAuxilio.Click
        oeOrdenTrabajo.Modificado = True
    End Sub

    Private Sub dtpFechaProg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaProg.KeyDown
        oeOrdenTrabajo.Modificado = True
    End Sub

    Private Sub dtpFechaProg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaProg.KeyPress
        oeOrdenTrabajo.Modificado = True
    End Sub

    Private Sub grid_OTRecursos_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grid_OTRecursos.BeforeCellUpdate
        Try
            With grid_OTRecursos
                If e.Cell.Column.Key.ToUpper = "CANTIDADHORAS" Then
                    If IsDBNull(e.NewValue) Then
                        canthor = IIf(IsDBNull(e.Cell.Value), 0, e.Cell.Value)
                        e.Cancel = True
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_OTServicios_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grid_OTServicios.BeforeCellUpdate
        Try
            With grid_OTServicios
                Select Case e.Cell.Column.Key.ToUpper
                    Case "COSTO", "COSTODOLARES"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_OTMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_OTMateriales.KeyDown
        Try
            With grid_OTMateriales
                If e.KeyValue = Keys.Enter Then
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Materiales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_Materiales.KeyDown
        Try
            With grid_Materiales
                If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Space Then
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gbeEquipos_ExpandedStateChanging(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gbeEquipos.ExpandedStateChanging
        Me.txtBuscarEquipo.Text = String.Empty
        For x As Integer = 0 To grid_Equipos.Rows.Count - 1
            Me.grid_Equipos.Rows(x).CollapseAll()
        Next
        With grid_OT_ME
            If Not gbeEquipos.Expanded Then
                If .Rows.Count > 0 Then
                    If .ActiveRow.Band.Index = 0 Then
                        Me.txtBuscarEquipo.Text = .ActiveRow.Cells("EquipoMantenimiento").Value.ToString
                        For x As Integer = 0 To grid_Equipos.Rows.Count - 1
                            Me.grid_Equipos.Rows(x).ExpandAll()
                        Next
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Me.txtBuscarEquipo.Text = String.Empty
        For x As Integer = 0 To grid_Equipos.Rows.Count - 1
            Me.grid_Equipos.Rows(x).CollapseAll()
        Next
        gbeEquipos.Expanded = True
        If grid_OT_ME.ActiveRow.Band.Index = 0 Then
            Me.txtBuscarEquipo.Text = grid_OT_ME.ActiveRow.Cells("EquipoMantenimiento").Value.ToString
            For x As Integer = 0 To grid_Equipos.Rows.Count - 1
                Me.grid_Equipos.Rows(x).ExpandAll()
            Next
        End If
    End Sub

    Private Sub btnAnularOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularOT.Click
        AnularOT(grid_OrdenTrabajo.ActiveRow.Cells("IdOT").Value.ToString)
    End Sub

    Sub AnularOT(ls_IdOT As String)
        Try
            oeOrdenTrabajo = New e_OrdenTrabajo
            oeOrdenTrabajo.Id = ls_IdOT
            oeOrdenTrabajo = olOrdenTrabajo.Obtener(oeOrdenTrabajo)
            If oeOrdenTrabajo.Activo Then
                If oeOrdenTrabajo.EstadoOT = "PENDIENTE" Or oeOrdenTrabajo.EstadoOT = "EN PROCESO" Or oeOrdenTrabajo.EstadoOT = "LIBERADA" Then
                    oeOTMaterial = New e_OrdenTrabajo_Material
                    oeOTMaterial.IdOrdenTrabajo = oeOrdenTrabajo.Id
                    oeOTMaterial.TipoOperacion = "T"
                    oeOTMaterial.Activo = True
                    If olOTMaterial.Listar(oeOTMaterial).Count = 0 Then
                        If MessageBox.Show("Esta seguro de anular la Orden Trabajo : " & _
                        oeOrdenTrabajo.NroOT & " ?", _
                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeOrdenTrabajo.TipoOperacion = "E"
                            olOrdenTrabajo.Eliminar(oeOrdenTrabajo)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La OT ya contiene materiales atendidos, no se puede ANULAR.")
                    End If
                Else
                    Throw New Exception("Solo se pueden anular Ordenes de Trabajo en estado PENDIENTE, EN PROCESO o LIBERADA sin atender.")
                End If
            Else
                Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mcAcciones_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcAcciones.Opening
        With mcAcciones
            .Items(0).Visible = False : .Items(1).Visible = False : .Items(2).Visible = False : .Items(3).Visible = False : .Items(5).Visible = False
            If .SourceControl Is grid_OTAnteriores Then
                If grid_OTAnteriores.ActiveRow.Band.Index = 0 Then
                    Select Case grid_OTAnteriores.ActiveRow.Cells("Estado").Value
                        Case "PENDIENTE"
                            .Items(0).Visible = True : .Items(2).Visible = True : .Items(3).Visible = True : .Items(5).Visible = False
                        Case "LIBERADA"
                            .Items(0).Visible = True : .Items(2).Visible = True : .Items(3).Visible = True : .Items(5).Visible = False
                        Case "EN PROCESO"
                            .Items(1).Visible = True : .Items(2).Visible = True : .Items(3).Visible = True : .Items(5).Visible = True
                    End Select
                End If
            ElseIf .SourceControl Is grid_OrdenTrabajo Then
                If grid_OrdenTrabajo.Rows.Count > 0 AndAlso grid_OrdenTrabajo.ActiveRow.Band.Index = 0 Then
                    Select Case grid_OrdenTrabajo.ActiveRow.Cells("Estado").Value
                        Case "PENDIENTE"
                            .Items(0).Visible = True : .Items(2).Visible = True : .Items(3).Visible = True : .Items(5).Visible = False
                        Case "EN PROCESO"
                            .Items(1).Visible = True : .Items(2).Visible = True : .Items(3).Visible = True : .Items(5).Visible = True
                        Case "LIBERADA"
                            .Items(1).Visible = True : .Items(2).Visible = True : .Items(3).Visible = True : .Items(5).Visible = False
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub tsmTerminarOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmTerminarOT.Click
        With mcAcciones
            If .SourceControl Is grid_OTAnteriores Then
                TerminarOT(grid_OTAnteriores.ActiveRow.Cells("IdOT").Value)
            ElseIf .SourceControl Is grid_OrdenTrabajo Then
                Me.btnTerminarOT.PerformClick()
            End If
        End With
    End Sub

    Private Sub tsmIniciarOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmIniciarOT.Click
        With mcAcciones
            If .SourceControl Is grid_OTAnteriores Then
                IniciarOT(grid_OTAnteriores.ActiveRow.Cells("IdOT").Value.ToString)
            ElseIf .SourceControl Is grid_OrdenTrabajo Then
                Me.btnIniciarOT.PerformClick()
            End If
        End With
    End Sub

    Private Sub tsmActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmActualizarOT.Click
        With mcAcciones
            If .SourceControl Is grid_OTAnteriores Then
                IdOT = grid_OTAnteriores.ActiveRow.Cells("IdOT").Value.ToString
                Editar()
            ElseIf .SourceControl Is grid_OrdenTrabajo Then
                IdOT = grid_OrdenTrabajo.ActiveRow.Cells("IdOT").Value.ToString
                Editar()
            End If
        End With
    End Sub

    Private Sub tsmAnularOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAnularOT.Click
        With mcAcciones
            If .SourceControl Is grid_OTAnteriores Then
                AnularOT(grid_OTAnteriores.ActiveRow.Cells("IdOT").Value.ToString)
            ElseIf .SourceControl Is grid_OrdenTrabajo Then
                Me.btnAnularOT.PerformClick()
            End If
        End With
    End Sub

    Private Sub btnLiberarUnidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiberarUnidad.Click
        LiberarUnidad(grid_OrdenTrabajo.ActiveRow.Cells("IdOT").Value.ToString)
    End Sub

    Private Sub LiberarUnidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiberarUnidadToolStripMenuItem.Click
        LiberarUnidad(grid_OrdenTrabajo.ActiveRow.Cells("IdOT").Value.ToString)
    End Sub

    Private Sub chkExpandirGrilla_CheckedChanged(sender As Object, e As EventArgs) Handles chkExpandirGrilla.CheckedChanged
        gGrillaExpandida = chkExpandirGrilla.Checked
        If oeOrdenTrabajo.TipoOperacion = "L" Then ListarOrdenesTrabajo()
    End Sub

    Private Sub dtp_FecIngTaller_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FecIngTaller.ValueChanged, dtp_HorIngTaller.ValueChanged
        If Not sw Then
            oeOrdenTrabajo.FechaIngresoTaller = Date.Parse(dtp_FecIngTaller.Value.Date & " " & dtp_HorIngTaller.Value.ToShortTimeString)
            If Date.Parse(dtp_FecIngTaller.Value.Date & " " & dtp_HorIngTaller.Value.ToShortTimeString) > Date.Parse(dtp_FecIniTrab.Value.Date & " " & dtp_HorIniTrab.Value.ToShortTimeString) Then
                dtp_FecIniTrab.Value = dtp_FecIngTaller.Value
                dtp_HorIniTrab.Value = dtp_HorIngTaller.Value
                dtp_FecFinTrab.Value = dtp_FecIngTaller.Value
                dtp_HorFinTrab.Value = dtp_HorIngTaller.Value
            End If
            ndTipoCambio.Value = TipoCambio(dtp_FecIngTaller.Value)(0)
        End If
    End Sub

    Private Sub dtp_FecIniTrab_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FecIniTrab.ValueChanged, dtp_HorIniTrab.ValueChanged
        If Not sw Then
            oeOrdenTrabajo.FechaInicioTrabajo = Date.Parse(dtp_FecIniTrab.Value.Date & " " & dtp_HorIniTrab.Value.ToShortTimeString)
            If Date.Parse(dtp_FecIniTrab.Value.Date & " " & dtp_HorIniTrab.Value.ToShortTimeString) > Date.Parse(dtp_FecFinTrab.Value.Date & " " & dtp_HorFinTrab.Value.ToShortTimeString) Then
                dtp_FecFinTrab.Value = dtp_FecIniTrab.Value
                dtp_HorFinTrab.Value = dtp_HorIniTrab.Value
            End If
        End If
    End Sub

    Private Sub dtp_FecFinTrab_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FecFinTrab.ValueChanged, dtp_HorFinTrab.ValueChanged
        If Not sw Then
            oeOrdenTrabajo.FechaFinTrabajo = Date.Parse(dtp_FecFinTrab.Value.Date & " " & dtp_HorFinTrab.Value.ToShortTimeString)
        End If
    End Sub

    Private Sub dtpFechaTentativaSalida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaTentativaSalida.ValueChanged
        oeOrdenTrabajo.FechaTentativaSalida = dtpFechaTentativaSalida.Value
    End Sub

    Private Sub cboTipoOrden_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoOrden.ValueChanged
        Try
            If cboTipoOrden.SelectedIndex > -1 Then
                oeOrdenTrabajo.Modificado = True
                oeOrdenTrabajo.TipoOrden = cboTipoOrden.SelectedIndex + 1
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedor.ValueChanged
        If cboProveedor.Value <> Nothing Then
            oeOrdenTrabajo.IdEmpresaExterna = cboProveedor.Value
        End If
    End Sub

    Private Sub frm_OT_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Metodos"

    Private Sub InicializarLogicas()
        olOrdenTrabajo = New l_OrdenTrabajo
        olOTActividad = New l_OrdenTrabajo_Actividad
        olOTEquipoMantenimiento = New l_OrdenTrabajo_MantenimientoEquipo
        olOTMaterial = New l_OrdenTrabajo_Material
        olOTRecurso = New l_OrdenTrabajo_Recurso
        olOTServicio = New l_OrdenTrabajo_Servicio
        olEstadoOT = New l_EstadoOT
        olEquipo = New l_Equipo
        olVehiculo = New l_Vehiculo
        olOperacion = New l_Operacion
        olMantenimientoEquipo = New l_MantenimientoEquipo
        olMantenimientoMaterial = New l_MantenimientoMaterial
        olMaterialAlmacen = New l_MaterialAlmacen
        olSubAlmacen = New l_SubAlmacen
        olMantenimiento = New l_Mantenimiento
        olMantenimientoActividad = New l_MantenimientoActividad
        olMantenimientoEquipo = New l_MantenimientoEquipo
        olMantenimientoMaterial = New l_MantenimientoMaterial
        olMantenimientoOcupacion = New l_MantenimientoOcupacion
        olMantenimientoServicio = New l_MantenimientoServicio
        olTrabajador = New l_Trabajador
        olActividad = New l_Actividad
        olUsuario = New l_Usuario
        Prefijo = New l_Configuracion
        olTrabajadorSeguridad = New l_TrabajadorSeguridad
        olTipoMantenimiento = New l_TipoMantenimiento
        olOcupacion = New l_Ocupacion
        olMaterial = New l_Material
        olProcesoNegocio = New l_ProcesoNegocio
        olIGV = New l_Impuesto
        olDetalleMarAux = New l_OrdenTrabajo_Material
        olRequerimiento = New l_Requerimiento
        olDetalleOrdenIngreso = New l_OrdenMaterial
        olEstadoRequerimiento = New l_EstadoRequerimiento
        olProveedor = New l_Proveedor
        olUnidadMedida = New l_UnidadMedida
        olOcupacionTrabajador = New l_OcupacionTrabajador
    End Sub

    Public Sub ListarOrdenesTrabajo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeOrdenTrabajo = New e_OrdenTrabajo
            oeOrdenTrabajo.Activo = True
            oeOrdenTrabajo.TipoOperacion = "L"
            oeOrdenTrabajo.FechaProgramacionIni = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.FechaProgramacionFin = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.FechaIngresoTaller = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.FechaInicioTrabajo = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.FechaFinTrabajo = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.FechaCreacion = Date.Parse("01/01/1901").Date
            oeOrdenTrabajo.NroOT = IIf(rbNroOT.Checked, Me.txtOT.Text, "")
            oeOrdenTrabajo.IdEstadoOT = IIf(cmEstadoOT.Value <> "CERO", cmEstadoOT.Value, "")
            oeOrdenTrabajo.IdEquipo = IIf(cmEquipo.Value <> "CERO", cmEquipo.Value, "")
            oeOrdenTrabajo.IdMantenimiento = IIf(cmMantenimiento.Value <> "CERO", cmMantenimiento.Value, "")
            oeOrdenTrabajo.IdTipoMantenimiento = IIf(cmTipoMantenimiento.Value <> "CERO", cmTipoMantenimiento.Value, "")
            oeOrdenTrabajo.IndicadorTipo = IIf(cmbTipo.SelectedIndex <> 0, Strings.Left(cmbTipo.Text, 1), "")
            oeOrdenTrabajo.PrefijoCentro = cboCentro.Value
            If rbDatosAdicionales.Checked Then
                If optFechas.CheckedIndex = 0 Then
                    oeOrdenTrabajo.FechaProgramacionIni = dtp_DesdeProg.Value
                    oeOrdenTrabajo.FechaProgramacionFin = dtp_HastaProg.Value
                End If
            End If

            dsOT = olOrdenTrabajo.Listar(oeOrdenTrabajo)

            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) OT
            'Tabla(1) Equipo
            'Tabla(2) Mantenimiento
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim IdOT As DataColumn = dsOT.Tables(0).Columns("IdOT")
            Dim IdOT_EM As DataColumn = dsOT.Tables(1).Columns("IdOrdenTrabajo")
            Dim relation1 As DataRelation = New DataRelation("FK_Relacion_OTE", IdOT, IdOT_EM, False)
            dsOT.Relations.Add(relation1)

            Dim TransactionColumns() As DataColumn, DetailColumns() As DataColumn
            TransactionColumns = New DataColumn() {dsOT.Tables(1).Columns("IdOrdenTrabajo"), dsOT.Tables(1).Columns("IdEquipo")}
            DetailColumns = New DataColumn() {dsOT.Tables(2).Columns("IdOrdenTrabajo"), dsOT.Tables(2).Columns("IdEquipo")}
            Dim Tran_Detail As New DataRelation("FK_Relacion_OTEM", TransactionColumns, DetailColumns)
            dsOT.Relations.Add(Tran_Detail)
            dsOT.AcceptChanges()
            grid_OrdenTrabajo.DataSource = dsOT

            grid_OrdenTrabajo.DisplayLayout.Bands(1).ColHeadersVisible = False
            grid_OrdenTrabajo.DisplayLayout.Bands(2).ColHeadersVisible = False
            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("IdOrdenTrabajo").Hidden = True
            grid_OrdenTrabajo.DisplayLayout.Bands(2).Columns("IdOrdenTrabajo").Hidden = True
            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("IdEquipo").Hidden = True
            grid_OrdenTrabajo.DisplayLayout.Bands(2).Columns("IdEquipo").Hidden = True
            grid_OrdenTrabajo.DisplayLayout.Bands(2).Columns("IdMantenimiento").Hidden = True
            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("Odometro").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("Horometro").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("Odometro").Format = "#,##0.00"
            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("Odometro").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("Odometro").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("Odometro").MaskInput = "{double:9.2}"

            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("Horometro").Format = "#,##0.00"
            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("Horometro").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("Horometro").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            grid_OrdenTrabajo.DisplayLayout.Bands(1).Columns("Horometro").MaskInput = "{double:9.2}"
            For x As Integer = 0 To grid_OrdenTrabajo.Rows.Count - 1
                If gGrillaExpandida Then
                    Me.grid_OrdenTrabajo.Rows(x).ExpandAll()
                Else
                    Me.grid_OrdenTrabajo.Rows(x).CollapseAll()
                End If
            Next
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grid_OrdenTrabajo.Rows
                Select Case fila.Cells("Estado").Value
                    Case "PENDIENTE"
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case "EN PROCESO"
                        fila.CellAppearance.BackColor = Me.ColoresEnProceso.Color
                    Case "LIBERADA"
                        fila.CellAppearance.BackColor = Me.ColoresLiberada.Color
                    Case "TERMINADA"
                        fila.CellAppearance.BackColor = Me.ColoresTerminada.Color
                    Case "ANULADA"
                        fila.CellAppearance.BackColor = Me.ColoresAnulada.Color
                End Select
            Next
            Agrupacion4.Text = "OT's: " & grid_OrdenTrabajo.Rows.Count & " Registros"
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
        grid_OrdenTrabajo.Focus()
    End Sub

    Public Sub Inicializa()
        oeCombo = New e_Combo
        oeIGV = olIGV.IGV(dtpFechaProg.Value)
        ficOrdenTrabajoDet.SelectedTab = ficOrdenTrabajoDet.Tabs(0)
        gbeEquipos.Expanded = False
        gbeMateriales.Expanded = False
        gbeServicios.Expanded = False
        gbeOperarios.Expanded = False
        gbeActividades.Expanded = False
        'gbeOTsAnteriores.Expanded = False
        dtpFechaProg.Value = Date.Now
        dtp_FecIngTaller.Value = Date.Now
        dtp_HorIngTaller.Value = Date.Now
        dtp_FecIniTrab.Value = Date.Now
        dtp_HorIniTrab.Value = Date.Now
        dtp_FecFinTrab.Value = Date.Now
        dtp_HorFinTrab.Value = Date.Now
        dtpFechaTentativaSalida.Value = Date.Now
        cmbJefeTaller.SelectedIndex = -1
        cmbSupervisorMant.SelectedIndex = -1
        cbe_Tipo.SelectedIndex = -1
        ndTotalServicios.Value = 0
        cbAuxilio.Checked = False
        cbSiniestro.Checked = False
        cbCalibracion.Checked = False
        Me.txtGlosa.Text = String.Empty
        Me.txtNroOT.Text = String.Empty
        Me.txtEstado.Text = String.Empty
        Me.txtBuscarEquipo.Text = String.Empty
        Me.lbl_etiqueta.Text = String.Empty
        Me.lbl_etiqueta.Visible = False
        grid_OTMateriales.Visible = True
        dsOT_ME.Clear()
        dsOT_ME_Material.Clear()
        dsOT_ME_Servicio.Clear()
        dsOT_ME_Recurso.Clear()
        dsOT_ME_Actividad.Clear()
        datoValido = True
        _TipoCambio = TipoCambio(dtp_FecIngTaller.Value, True)(0)
        If _TipoCambio = 0 Then
            Throw New Exception("No existe tipo de cambio para esta fecha.")
        End If
        ndTipoCambio.Value = IIf(_TipoCambio <> 0.0, _TipoCambio, "")
        cboTipoOrden.SelectedIndex = -1
        lstMateriales = New List(Of e_Material)
        grid_Materiales.DataSource = lstMateriales
        grid_Materiales.DataBind()
    End Sub

    Public Sub FormatearFormulario(ByVal lb_ok As Boolean)
        cmbJefeTaller.Enabled = lb_ok
        cmbSupervisorMant.Enabled = lb_ok
        UltraGroupBox1.Enabled = lb_ok
        'gbInd.Enabled = lb_ok

        txtGlosa.Enabled = lb_ok
        '.Visible = lb_ok
        gbeEquipos.Enabled = lb_ok
        gbeActividades.Enabled = lb_ok
        gbeMateriales.Enabled = lb_ok
        gbeServicios.Enabled = lb_ok
        gbeOperarios.Enabled = lb_ok
    End Sub

    Public Sub FormatearGrillaMateriales()
        Try
            With grid_OTMateriales.DisplayLayout.Bands(0)
                .Columns("CantidadMaterialEntregada").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I" OrElse cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("CantidadMaterialDevuelto").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I" OrElse cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("CantidadPendiente").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I" OrElse cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("Costo").Hidden = IIf(cbe_Tipo.SelectedIndex = 1, False, True)
                .Columns("IdAlmacen").Hidden = IIf(cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("Stock").Hidden = IIf(cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("FechaCreacion").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I", True, False)
                '.Columns("Costo").Hidden = IIf(cbe_Tipo.SelectedIndex = 1, False, True)
                .Columns("Costo").Hidden = IIf(PerfilAsignado(gNombrePerfilJefeMantenimiento) Or PerfilAsignado(gNombrePerfilAdministrador), False, True)
            End With
            With grid_OTMateriales.DisplayLayout.Bands(1)
                .Columns("CantidadMaterialEntregada").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I" OrElse cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("CantidadMaterialDevuelto").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I" OrElse cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("CantidadPendiente").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I" OrElse cbe_Tipo.SelectedIndex = 1, True, False)
                '.Columns("Costo").Hidden = IIf(cbe_Tipo.SelectedIndex = 1, False, True)
                .Columns("Costo").Hidden = IIf(PerfilAsignado(gNombrePerfilJefeMantenimiento) Or PerfilAsignado(gNombrePerfilAdministrador), False, True)
                .Columns("IdAlmacen").Hidden = IIf(cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("Stock").Hidden = IIf(cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("FechaCreacion").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I", True, False)
            End With
            With grid_OTMateriales.DisplayLayout.Bands(2)
                .Columns("CantidadMaterialEntregada").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I" OrElse cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("CantidadMaterialDevuelto").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I" OrElse cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("CantidadPendiente").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I" OrElse cbe_Tipo.SelectedIndex = 1, True, False)
                '.Columns("Costo").Hidden = IIf(cbe_Tipo.SelectedIndex = 1, False, True)
                .Columns("Costo").Hidden = IIf(PerfilAsignado(gNombrePerfilJefeMantenimiento) Or PerfilAsignado(gNombrePerfilAdministrador), False, True)
                .Columns("IdAlmacen").Hidden = IIf(cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("Stock").Hidden = IIf(cbe_Tipo.SelectedIndex = 1, True, False)
                .Columns("FechaCreacion").Hidden = IIf(oeOrdenTrabajo.TipoOperacion = "I", True, False)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AlmacenValueList(ls_IdMaterial As String)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            Me.grid_OTMateriales.DisplayLayout.ValueLists.Clear()
            objValueList = Me.grid_OTMateriales.DisplayLayout.ValueLists.Add("Almacenes")

            oeMaterialAlmacen = New e_MaterialAlmacen
            oeMaterialAlmacen.TipoOperacion = "6"
            oeMaterialAlmacen.Activo = True
            oeMaterialAlmacen.IdCentro = cboCentro.Value
            oeMaterialAlmacen.IdMaterial = ls_IdMaterial
            Dim dt As DataTable = olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SubAlmacenValueList(ls_IdAlmacen As String)
        Try
            Dim lstSubAlmacen As New List(Of e_SubAlmacen)
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            Me.grid_OTMateriales.DisplayLayout.ValueLists.Clear()
            objValueList = Me.grid_OTMateriales.DisplayLayout.ValueLists.Add("SubAlmacenes")

            oeSubAlmacen = New e_SubAlmacen
            oeSubAlmacen.TipoOperacion = "S"
            oeSubAlmacen.Activo = True
            oeSubAlmacen.IdAlmacen = ls_IdAlmacen
            lstSubAlmacen = olSubAlmacen.Listar_SubAlmacen(oeSubAlmacen)
            If lstSubAlmacen.Count > 0 Then
                For Each item As e_SubAlmacen In lstSubAlmacen
                    objValueList.ValueListItems.Add(item.Id, item.Descripcion)
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub UnidadMedidaValueList(ls_IdTipoUnidadMedida As String, stGrilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            stGrilla.DisplayLayout.ValueLists.Clear()
            objValueList = stGrilla.DisplayLayout.ValueLists.Add("Medidas")
            oeUnidadMedida = New e_UnidadMedida
            oeUnidadMedida.Activo = True
            oeUnidadMedida.Nombre = ""
            oeUnidadMedida.IdTipoUnidadMedida = ls_IdTipoUnidadMedida
            Dim dt As DataTable = olUnidadMedida.ComboGrilla(oeUnidadMedida)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ResponsableValueList(stGrilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        Try
            lstResponsables = New List(Of e_Trabajador)
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            stGrilla.DisplayLayout.ValueLists.Clear()
            objValueList = stGrilla.DisplayLayout.ValueLists.Add("Responsables")

            oeTrabajador = New e_Trabajador
            oeTrabajador.Activo = True
            lstResponsables = olTrabajador.Listar(oeTrabajador)
            For Each item As e_Trabajador In lstResponsables
                objValueList.ValueListItems.Add(item.Id, item.oePersona.NombreCompleto)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub AgregarDetalle()
        Try
            Select Case ficOrdenTrabajoDet.SelectedTab.Index
                Case 0 : AgregarEquiposMantenimiento()
                Case 1 : AgregarMaterialEquipoMantenimiento()
                Case 2 : AgregarServicioEquipoMantenimiento()
                Case 3 : AgregarTrabajadorEquipoMantenimientoOcupacion()
                Case 4 : AgregarActividadesEquipoMantenimiento()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarEquiposMantenimiento(Optional ByVal sw As Integer = 0)
        Try
            Dim _cant As Integer = 0, cont As Integer = 0
            For Each oeMantenimientoEquipo As e_MantenimientoEquipo In lstEquipoMantenimiento.Where(Function(Item) Item.Seleccion)
                For Each mantRow As Data.DataRow In dsOT_ME.Tables(1).Rows
                    If oeMantenimientoEquipo.Id = mantRow("IdMantenimientoEquipo").ToString Then
                        oeMantenimientoEquipo.Seleccion = False
                    End If
                Next
                If sw = 0 Then
                    If cbe_Tipo.SelectedIndex = 0 Then
                        If ValidarExistenciaOTAbierta(oeMantenimientoEquipo.IdEquipo) Then
                            oeMantenimientoEquipo.Seleccion = False
                            Exit For
                        End If
                    End If
                End If
                If oeMantenimientoEquipo.Seleccion Then
                    For Each o_Fila As Data.DataRow In dsOT_ME.Tables(0).Rows
                        If oeMantenimientoEquipo.IdEquipo = o_Fila("IdEquipo").ToString Then cont += 1
                    Next
                    If cont = 0 Then
                        Dim rowEquipo As DataRow
                        rowEquipo = dsOT_ME.Tables(0).NewRow
                        rowEquipo("Seleccion") = False
                        rowEquipo("Id") = ""
                        rowEquipo("IdEquipo") = oeMantenimientoEquipo.IdEquipo
                        rowEquipo("EquipoMantenimiento") = oeMantenimientoEquipo.Equipo
                        oeVehiculo = New e_Vehiculo
                        oeVehiculo.Id = oeMantenimientoEquipo.IdVehiculo
                        oeVehiculo.TipoOperacion = "A"
                        oeVehiculo = olVehiculo.Obtener(oeVehiculo)

                        oeViaje = New e_Viaje
                        oeViaje.Activo = True
                        oeViaje.ViajeVacio = 2
                        oeViaje.FechaDesde = ""
                        oeViaje.FechaHasta = ""
                        oeViaje.TipoOperacion = "U"
                        oeViaje.Zona = ""
                        oeViaje.IndMotriz = oeVehiculo.Motriz
                        oeViaje.IdTracto = oeVehiculo.Id
                        oeViaje = olOperacion.ObtenerViaje(oeViaje)

                        rowEquipo("Odometro") = oeVehiculo.Odometro
                        rowEquipo("Horometro") = oeVehiculo.Horometro
                        rowEquipo("OdometroAct") = oeVehiculo.Odometro
                        rowEquipo("HorometroAct") = oeVehiculo.Horometro
                        rowEquipo("Responsable") = oeViaje.IdPiloto
                        dsOT_ME.Tables(0).Rows.Add(rowEquipo)
                        dsOT_ME.Tables(0).AcceptChanges()
                    End If
                    Dim rowMantemimiento As DataRow
                    rowMantemimiento = dsOT_ME.Tables(1).NewRow
                    rowMantemimiento("Id") = ""
                    rowMantemimiento("Seleccion") = False
                    rowMantemimiento("IdEquipo") = oeMantenimientoEquipo.IdEquipo
                    rowMantemimiento("IdMantenimientoEquipo") = oeMantenimientoEquipo.Id
                    rowMantemimiento("EquipoMantenimiento") = oeMantenimientoEquipo.Mantenimiento
                    rowMantemimiento("TipoMantenimiento") = oeMantenimientoEquipo.TipoMantenimiento
                    dsOT_ME.Tables(1).Rows.Add(rowMantemimiento)
                    dsOT_ME.Tables(1).AcceptChanges()
                    CargarMaterialMantenimiento(oeMantenimientoEquipo.Id, oeMantenimientoEquipo.IdEquipo, oeMantenimientoEquipo.Equipo, _
                                                oeMantenimientoEquipo.IdMantenimiento, oeMantenimientoEquipo.Mantenimiento)
                    CargarServiciosMantenimiento(oeMantenimientoEquipo.Id, oeMantenimientoEquipo.IdEquipo, oeMantenimientoEquipo.Equipo, _
                                             oeMantenimientoEquipo.IdMantenimiento, oeMantenimientoEquipo.Mantenimiento)
                    CargarRecursosMantenimiento(oeMantenimientoEquipo.Id, oeMantenimientoEquipo.IdEquipo, oeMantenimientoEquipo.Equipo, _
                                                oeMantenimientoEquipo.IdMantenimiento, oeMantenimientoEquipo.Mantenimiento)
                    CargarActividadesMantenimiento(oeMantenimientoEquipo.Id, oeMantenimientoEquipo.IdEquipo, oeMantenimientoEquipo.Equipo, _
                                               oeMantenimientoEquipo.IdMantenimiento, oeMantenimientoEquipo.Mantenimiento)
                    _cant += 1
                End If
                oeMantenimientoEquipo.Seleccion = False
            Next
            If _cant > 0 Then
                oeOrdenTrabajo.Modificado = True
                grid_Equipos.DataBind()
                grid_OT_ME.DataBind()
                With grid_OT_ME.DisplayLayout
                    ResponsableValueList(grid_OT_ME)
                    .Bands(0).Columns("Responsable").ValueList = .ValueLists("Responsables")
                End With
                For i As Integer = 0 To ficOrdenTrabajoDet.Tabs.Count - 1
                    ficOrdenTrabajoDet.Tabs(i).Enabled = True
                Next
                gbeEquipos.Expanded = False

            End If
            For x As Integer = 0 To grid_OT_ME.Rows.Count - 1
                Me.grid_OT_ME.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarMaterialMantenimiento(ls_IdMantEquipo As String, ls_IdEquipo As String, ls_Equipo As String, ls_IdMant As String, ls_Mant As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim rowEquipo As DataRow, rowMantemimiento As DataRow, cont As Integer = 0

            For Each o_Fila As Data.DataRow In dsOT_ME_Material.Tables(0).Rows
                If ls_IdEquipo = o_Fila("IdEquipo").ToString Then cont += 1
            Next
            If cont = 0 Then
                rowEquipo = dsOT_ME_Material.Tables(0).NewRow
                rowEquipo("MantenimientoMaterial") = ""
                rowEquipo("Equipo") = ls_Equipo
                rowEquipo("IdEquipo") = ls_IdEquipo
                rowEquipo("CantidadMaterial") = ""
                rowEquipo("CantidadMaterialEntregada") = ""
                rowEquipo("CantidadMaterialDevuelto") = ""
                rowEquipo("CantidadPendiente") = ""
                dsOT_ME_Material.Tables(0).Rows.Add(rowEquipo)
                dsOT_ME_Material.Tables(0).AcceptChanges()
            End If
            rowMantemimiento = dsOT_ME_Material.Tables(1).NewRow
            rowMantemimiento("Seleccion") = False
            rowMantemimiento("IdOTME") = ""
            rowMantemimiento("IdMantenimientoEquipo") = ls_IdMantEquipo
            rowMantemimiento("IdEquipo") = ls_IdEquipo
            rowMantemimiento("Equipo") = ls_Equipo
            rowMantemimiento("IdMantenimiento") = ls_IdMant
            rowMantemimiento("MantenimientoMaterial") = ls_Mant
            rowMantemimiento("CantidadMaterial") = ""
            rowMantemimiento("CantidadMaterialEntregada") = ""
            rowMantemimiento("CantidadMaterialDevuelto") = ""
            rowMantemimiento("CantidadPendiente") = ""
            dsOT_ME_Material.Tables(1).Rows.Add(rowMantemimiento)
            dsOT_ME_Material.Tables(1).AcceptChanges()

            oeMantenimientoMaterial = New e_MantenimientoMaterial
            oeMantenimientoMaterial.TipoOperacion = "L"
            oeMantenimientoMaterial.Activo = True
            oeMantenimientoMaterial.IdMantenimiento = ls_IdMant
            lstMantenimientoMaterial = olMantenimientoMaterial.Listar(oeMantenimientoMaterial)
            For Each oeMantenimientoMaterial As e_MantenimientoMaterial In lstMantenimientoMaterial
                Dim rowMaterial As DataRow
                rowMaterial = dsOT_ME_Material.Tables(2).NewRow
                rowMaterial("Seleccion") = False
                rowMaterial("IdOTM") = ""
                rowMaterial("IdMantenimiento") = oeMantenimientoMaterial.IdMantenimiento
                rowMaterial("Equipo") = ls_Equipo
                rowMaterial("IdEquipo") = ls_IdEquipo
                rowMaterial("Mantenimiento") = ls_Mant
                rowMaterial("IdMantenimientoEquipo") = ls_IdMant
                rowMaterial("IdMaterial") = oeMantenimientoMaterial.IdMaterial
                rowMaterial("MantenimientoMaterial") = oeMantenimientoMaterial.CodigoNombreMaterial
                rowMaterial("IdTipoUnidadMedida") = oeMantenimientoMaterial.IdTipoUnidadMedida
                rowMaterial("IdUnidadMedida") = oeMantenimientoMaterial.IdUnidadMedida
                rowMaterial("CantidadMaterial") = oeMantenimientoMaterial.Cantidad
                rowMaterial("CantidadMaterialEntregada") = 0
                rowMaterial("CantidadMaterialDevuelto") = 0
                rowMaterial("IdSubAlmacen") = oeMantenimientoMaterial.IdSubAlmacen
                rowMaterial("IdAlmacen") = oeMantenimientoMaterial.IdAlmacen
                rowMaterial("Costo") = oeMantenimientoMaterial.Precio
                rowMaterial("Stock") = oeMantenimientoMaterial.Stock
                dsOT_ME_Material.Tables(2).Rows.Add(rowMaterial)
            Next
            dsOT_ME_Material.Tables(2).AcceptChanges()
            grid_OTMateriales.DataBind()

            With grid_OTMateriales
                For i As Integer = 0 To .Rows.Count - 1
                    For Each aChildBand1 As Infragistics.Win.UltraWinGrid.UltraGridChildBand In .Rows(i).ChildBands
                        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In aChildBand1.Rows
                            For Each aChildBand2 As Infragistics.Win.UltraWinGrid.UltraGridChildBand In fila.ChildBands
                                For y As Integer = 0 To aChildBand2.Rows.Count - 1
                                    UnidadMedidaValueList(aChildBand2.Rows(y).Cells("IdTipoUnidadMedida").Value.ToString, grid_OTMateriales)
                                    aChildBand2.Rows(y).Cells("IdUnidadMedida").ValueList = .DisplayLayout.ValueLists("Medidas")
                                    AlmacenValueList(aChildBand2.Rows(y).Cells("IdMaterial").Value.ToString)
                                    aChildBand2.Rows(y).Cells("IdAlmacen").ValueList = .DisplayLayout.ValueLists("Almacenes")
                                    SubAlmacenValueList(aChildBand2.Rows(y).Cells("IdAlmacen").Value.ToString)
                                    aChildBand2.Rows(y).Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")
                                Next
                            Next
                        Next
                    Next
                Next
            End With

            For x As Integer = 0 To grid_OTMateriales.Rows.Count - 1
                Me.grid_OTMateriales.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarActividadesMantenimiento(ls_IdMantEquipo As String, ls_IdEquipo As String, ls_Equipo As String, ls_IdMant As String, ls_Mant As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim rowEquipo As DataRow, rowMantemimiento As DataRow, cont As Integer = 0
            For Each o_Fila As DataRow In dsOT_ME_Actividad.Tables(0).Rows
                If ls_IdEquipo = o_Fila("IdEquipo").ToString Then cont += 1
            Next
            If cont = 0 Then
                rowEquipo = dsOT_ME_Actividad.Tables(0).NewRow
                rowEquipo("MantenimientoActividad") = ""
                rowEquipo("Equipo") = ls_Equipo
                rowEquipo("IdEquipo") = ls_IdEquipo
                rowEquipo("CantidadHoras") = ""
                dsOT_ME_Actividad.Tables(0).Rows.Add(rowEquipo)
                dsOT_ME_Actividad.Tables(0).AcceptChanges()
            End If
            rowMantemimiento = dsOT_ME_Actividad.Tables(1).NewRow
            rowMantemimiento("Seleccion") = False
            rowMantemimiento("IdOTME") = ""
            rowMantemimiento("IdMantenimientoEquipo") = ls_IdMantEquipo
            rowMantemimiento("IdEquipo") = ls_IdEquipo
            rowMantemimiento("IdMantenimiento") = ls_IdMant
            rowMantemimiento("MantenimientoActividad") = ls_Mant
            rowMantemimiento("CantidadHoras") = ""
            dsOT_ME_Actividad.Tables(1).Rows.Add(rowMantemimiento)
            dsOT_ME_Actividad.Tables(1).AcceptChanges()

            oeMantenimientoActividad = New e_MantenimientoActividad
            oeMantenimientoActividad.TipoOperacion = "L"
            oeMantenimientoActividad.Activo = True
            oeMantenimientoActividad.IdMantenimiento = ls_IdMant
            lstMantenimientoActividad = olMantenimientoActividad.Listar(oeMantenimientoActividad)
            For Each oeMantenimientoActividad As e_MantenimientoActividad In lstMantenimientoActividad
                Dim rowActividad As DataRow
                rowActividad = dsOT_ME_Actividad.Tables(2).NewRow
                rowActividad("Seleccion") = False
                rowActividad("IdOTA") = ""
                rowActividad("IdMantenimiento") = oeMantenimientoActividad.IdMantenimiento
                rowActividad("IdMantenimientoEquipo") = ls_IdMantEquipo
                rowActividad("IdActividad") = oeMantenimientoActividad.IdActividad
                rowActividad("MantenimientoActividad") = oeMantenimientoActividad.Actividad
                'rowActividad("CantidadHoras") = oeMantenimientoActividad.CantidadHoras
                rowActividad("CantidadDias") = 0
                rowActividad("CantidadHoras") = 0
                rowActividad("CantidadMinutos") = 0
                dsOT_ME_Actividad.Tables(2).Rows.Add(rowActividad)
            Next
            dsOT_ME_Actividad.Tables(2).AcceptChanges()
            grid_OTActividades.DataBind()
            For x As Integer = 0 To grid_OTActividades.Rows.Count - 1
                Me.grid_OTActividades.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Function ValidarExistenciaOTAbierta(ls_IdEquipo As String) As Boolean
        Try
            Dim ls_Msg As String = ""
            If oeOrdenTrabajo.TipoOperacion = "I" Then
                oeOTEquipoMantenimiento = New e_OrdenTrabajo_MantenimientoEquipo
                oeOTEquipoMantenimiento.TipoOperacion = "EO"
                oeOTEquipoMantenimiento.IdEquipo = ls_IdEquipo
                oeOTEquipoMantenimiento = olOTEquipoMantenimiento.Obtener(oeOTEquipoMantenimiento)
                If Not oeOTEquipoMantenimiento Is Nothing Then
                    Dim oeOT As New e_OrdenTrabajo
                    oeOT.Id = oeOTEquipoMantenimiento.IdOrdenTrabajo
                    oeOT = olOrdenTrabajo.Obtener(oeOT)
                    ls_Msg = "El Equipo: " & oeOTEquipoMantenimiento.Equipo & " tiene una OT abierta: " & oeOT.NroOT
                    MessageBox.Show(ls_Msg, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarServiciosMantenimiento(ls_IdMantEquipo As String, ls_IdEquipo As String, ls_Equipo As String, ls_IdMant As String, ls_Mant As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim rowEquipo As DataRow, rowMantemimiento As DataRow, cont As Integer = 0
            For Each o_Fila As DataRow In dsOT_ME_Servicio.Tables(0).Rows
                If ls_IdEquipo = o_Fila("IdEquipo").ToString Then cont += 1
            Next
            If cont = 0 Then
                rowEquipo = dsOT_ME_Servicio.Tables(0).NewRow
                rowEquipo("MantenimientoServicio") = ""
                rowEquipo("Equipo") = ls_Equipo
                rowEquipo("IdEquipo") = ls_IdEquipo
                rowEquipo("Cantidad") = ""
                rowEquipo("Costo") = ""
                dsOT_ME_Servicio.Tables(0).Rows.Add(rowEquipo)
                dsOT_ME_Servicio.Tables(0).AcceptChanges()
            End If
            rowMantemimiento = dsOT_ME_Servicio.Tables(1).NewRow
            rowMantemimiento("Seleccion") = False
            rowMantemimiento("IdOTME") = ""
            rowMantemimiento("IdMantenimientoEquipo") = ls_IdMantEquipo
            rowMantemimiento("IdEquipo") = ls_IdEquipo
            rowMantemimiento("IdMantenimiento") = ls_IdMant
            rowMantemimiento("MantenimientoServicio") = ls_Mant
            rowMantemimiento("Cantidad") = ""
            rowMantemimiento("Costo") = ""
            dsOT_ME_Servicio.Tables(1).Rows.Add(rowMantemimiento)
            dsOT_ME_Servicio.Tables(1).AcceptChanges()

            grid_OTServicios.DataBind()

            For x As Integer = 0 To grid_OTServicios.Rows.Count - 1
                Me.grid_OTServicios.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarRecursosMantenimiento(ls_IdMantEquipo As String, ls_IdEquipo As String, ls_Equipo As String, ls_IdMant As String, ByVal ls_Mant As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim rowEquipo As DataRow, rowMantemimiento As DataRow, cont As Integer = 0
            For Each o_Fila As DataRow In dsOT_ME_Recurso.Tables(0).Rows
                If ls_IdEquipo = o_Fila("IdEquipo").ToString Then cont += 1
            Next
            If cont = 0 Then
                rowEquipo = dsOT_ME_Recurso.Tables(0).NewRow
                rowEquipo("MantenimientoOcupacion") = ""
                rowEquipo("Equipo") = ls_Equipo
                rowEquipo("IdEquipo") = ls_IdEquipo
                rowEquipo("CantidadHoras") = ""
                dsOT_ME_Recurso.Tables(0).Rows.Add(rowEquipo)
                dsOT_ME_Recurso.Tables(0).AcceptChanges()
            End If
            rowMantemimiento = dsOT_ME_Recurso.Tables(1).NewRow
            rowMantemimiento("Seleccion") = False
            rowMantemimiento("IdOTME") = ""
            rowMantemimiento("IdMantenimientoEquipo") = ls_IdMantEquipo
            rowMantemimiento("IdEquipo") = ls_IdEquipo
            rowMantemimiento("IdMantenimiento") = ls_IdMant
            rowMantemimiento("MantenimientoOcupacion") = ls_Mant
            rowMantemimiento("CantidadHoras") = ""
            dsOT_ME_Recurso.Tables(1).Rows.Add(rowMantemimiento)
            dsOT_ME_Recurso.Tables(1).AcceptChanges()

            oeMantenimientoOcupacion = New e_MantenimientoOcupacion
            oeMantenimientoOcupacion.TipoOperacion = "L"
            oeMantenimientoOcupacion.Activo = True
            oeMantenimientoOcupacion.IdMantenimiento = ls_IdMant
            lstMantenimientoOcupacion = olMantenimientoOcupacion.Listar(oeMantenimientoOcupacion)
            For Each oeMantenimientoOcupacion As e_MantenimientoOcupacion In lstMantenimientoOcupacion
                Dim rowOcupacion As DataRow
                rowOcupacion = dsOT_ME_Recurso.Tables(2).NewRow
                rowOcupacion("Seleccion") = False
                rowOcupacion("IdMantenimientoEquipo") = ls_IdMantEquipo
                rowOcupacion("IdOcupacion") = oeMantenimientoOcupacion.IdOcupacion
                rowOcupacion("MantenimientoOcupacion") = oeMantenimientoOcupacion.Ocupacion
                rowOcupacion("Cantidad") = oeMantenimientoOcupacion.Cantidad
                dsOT_ME_Recurso.Tables(2).Rows.Add(rowOcupacion)
            Next
            dsOT_ME_Recurso.Tables(2).AcceptChanges()
            dsOT_ME_Recurso.Tables(3).AcceptChanges()
            dsOT_ME_Recurso.AcceptChanges()
            grid_OTRecursos.DataBind()

            For x As Integer = 0 To grid_OTRecursos.Rows.Count - 1
                Me.grid_OTRecursos.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub ListarEquiposMantenimiento()
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeMantenimientoEquipo = New e_MantenimientoEquipo
            lstEquipoMantenimiento = New List(Of e_MantenimientoEquipo)
            oeMantenimientoEquipo.TipoOperacion = "L"
            oeMantenimientoEquipo.Activo = True
            If Not cache.Contiene("EquiposMantenimiento") OrElse cache.ForzarActualizacion Then cache.Agregar("EquiposMantenimiento", olMantenimientoEquipo.Listar(oeMantenimientoEquipo))
            lstEquipoMantenimiento = DirectCast(cache.Obtener("EquiposMantenimiento"), List(Of e_MantenimientoEquipo))
            grid_Equipos.DataSource = lstEquipoMantenimiento
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
        grid_Equipos.Focus()
    End Sub

    Public Sub LlenaCombos()
        Try
            LlenaComboTipoMantenimiento()
            LlenaComboMantenimiento("")
            LlenaComboEstadoOT()
            LlenaComboEquipo()
            LlenaComboOcupaciones()
            LlenaComboJefeTaller()
            LlenaComboJefeFlota()
            LlenarCombo(cboCentro, "Nombre", CentroPublic, 0)
            LlenarCombo(cboCentroMaterial, "Nombre", CentroPublic, 0)
            _idcentro = gs_PrefijoIdSucursal '@0001
            cboCentro.Value = _idcentro
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "VER SEDES") Then
                cboCentro.Enabled = True
            Else
                cboCentro.Enabled = False
            End If
            cmbTipo.SelectedIndex = 0
            cboTipoOrden.Items.Clear()
            cboTipoOrden.Items.Add("PREVENTIVO")
            cboTipoOrden.Items.Add("PROACTIVO")
            cboTipoOrden.Items.Add("CORRECTIVO")
            cboTipoOrden.SelectedIndex = -1
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub LlenaComboJefeTaller()
        Try
            oeTrabajador = New e_Trabajador
            oeTrabajador.Activo = True
            oeTrabajador.TipoOperacion = "P"
            oeTrabajador.oeCargo.Id = "1CH005"
            Dim _leTrabJTAux = olTrabajador.Listar(oeTrabajador)
            Dim _leTrabJT = From le In _leTrabJTAux _
                            Select le.Id, le.oePersona.NombreCompleto, le.IndEstado
                            Where IndEstado = 1
            LlenarComboMaestro(cmbJefeTaller, _leTrabJT.ToList, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboJefeFlota()
        Try
            oeTrabajador = New e_Trabajador
            oeTrabajador.Activo = True
            oeTrabajador.TipoOperacion = "P"
            oeTrabajador.oeCargo.Id = "1CH004"
            Dim _leTrabJFAux = olTrabajador.Listar(oeTrabajador)
            Dim _leTrabJF = From le In _leTrabJFAux _
                            Select le.Id, le.oePersona.NombreCompleto, le.IndEstado
                            Where IndEstado = 1
            LlenarComboMaestro(cmbSupervisorMant, _leTrabJF.ToList, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboTipoMantenimiento()
        Try
            oeTipoMantenimiento = New e_TipoMantenimiento
            lstTipoMantenimiento = New List(Of e_TipoMantenimiento)
            oeTipoMantenimiento.Id = "CERO" : oeTipoMantenimiento.Nombre = "TODOS"
            lstTipoMantenimiento.Add(oeTipoMantenimiento)
            oeTipoMantenimiento = New e_TipoMantenimiento
            oeTipoMantenimiento.Activo = True
            lstTipoMantenimiento.AddRange(olTipoMantenimiento.Listar(oeTipoMantenimiento))
            LlenarComboMaestro(cmTipoMantenimiento, lstTipoMantenimiento, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboOcupaciones()
        Try
            oeOcupacion = New e_Ocupacion
            lstOcupaciones = New List(Of e_Ocupacion)
            oeOcupacion.Id = "CERO" : oeOcupacion.Nombre = "TODOS"
            lstOcupaciones.Add(oeOcupacion)
            oeOcupacion = New e_Ocupacion
            oeOcupacion.Activo = True
            lstOcupaciones.AddRange(olOcupacion.Listar(oeOcupacion))
            LlenarCombo(cboOcupacionBus, "Nombre", lstOcupaciones, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboEstadoOT()
        Try
            oeEstadoOT = New e_EstadoOT
            lstEstadoOT = New List(Of e_EstadoOT)
            oeEstadoOT.Id = "CERO" : oeEstadoOT.Nombre = "TODOS"
            lstEstadoOT.Add(oeEstadoOT)
            oeEstadoOT = New e_EstadoOT
            oeEstadoOT.Activo = True
            lstEstadoOT.AddRange(olEstadoOT.Listar(oeEstadoOT))
            LlenarComboMaestro(cmEstadoOT, lstEstadoOT, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboEquipo()
        Try
            oeEquipo = New e_Equipo
            lstEquipo = New List(Of e_Equipo)
            oeEquipo.Id = "CERO" : oeEquipo.Nombre = "TODOS"
            lstEquipo.Add(oeEquipo)
            oeEquipo = New e_Equipo
            oeEquipo.Activo = True
            lstEquipo.AddRange(olEquipo.Listar(oeEquipo))
            LlenarComboMaestro(cmEquipo, lstEquipo, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboMantenimiento(ls_IdTipoMantenimiento As String)
        Try
            oeMantenimiento = New e_Mantenimiento
            lstMantenimiento = New List(Of e_Mantenimiento)
            oeMantenimiento.Id = "CERO" : oeMantenimiento.Nombre = "TODOS"
            lstMantenimiento.Add(oeMantenimiento)
            oeMantenimiento = New e_Mantenimiento
            oeMantenimiento.IdTipoMantenimiento = ls_IdTipoMantenimiento
            oeMantenimiento.Activo = True
            lstMantenimiento.AddRange(olMantenimiento.Listar(oeMantenimiento))
            LlenarComboMaestro(cmMantenimiento, lstMantenimiento, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub IniciarForm()
        gf_AsignarEventoSeleccionarTexto(Me)
        gmt_ConfigurarEventoKeyEnter_Tab(Me, txtOT.Name, cboProveedor.Name, txtBuscarMateriales.Name)
        ColoresGenerado.Color = Color.White
        ColoresEnProceso.Color = Color.Khaki
        ColoresLiberada.Color = Color.LightSkyBlue
        ColoresTerminada.Color = Color.LightGreen
        ColoresAnulada.Color = Color.Coral
        oeUsuario = New e_Usuario
        oeUsuario.Id = gUsuarioSGI.Id
        oeUsuario = olUsuario.Obtener(oeUsuario)
        oeArea = New e_Area
        oeArea = olUsuario.Area(oeUsuario)
        dtp_DesdeProg.Value = Date.Today.AddDays(-4) : dtp_HastaProg.Value = Date.Today
        rfDesde.Value = Date.Today.AddDays(-4) : rfHasta.Value = Date.Today
    End Sub

    Private Sub ListarOT()
        ListarEquiposMantenimiento()
        ListarEquiposMantenimientoOT("")
        ListarActividades()
        ListarMaterialesOT("")
        ListarActividadesOT("")
        ListarRecursosOT("")
        ListarServiciosOT("")
    End Sub

    Public Sub ListarActividades()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeActividad = New e_Actividad
            lstActividades = New List(Of e_Actividad)
            oeActividad.TipoOperacion = "A"
            oeActividad.Activo = True
            lstActividades = olActividad.Listar(oeActividad)
            grid_Actividades.DataSource = lstActividades
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub ListarMaterialesOT(ls_IdOrdenTrabajo As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            oeOTMaterial = New e_OrdenTrabajo_Material
            dsOT_ME_Material = olOTMaterial.ListarDataSet(ls_IdOrdenTrabajo)
            Dim IdEquipo As DataColumn = dsOT_ME_Material.Tables(0).Columns("IdEquipo")
            Dim IdEquipoM As DataColumn = dsOT_ME_Material.Tables(1).Columns("IdEquipo")
            relationEquMant = New DataRelation("FK_Relacion_EM", IdEquipo, IdEquipoM, True)
            dsOT_ME_Material.Relations.Add(relationEquMant)
            Dim IdMantenimiento As DataColumn = dsOT_ME_Material.Tables(1).Columns("IdMantenimientoEquipo")
            Dim IdMantenimientoM As DataColumn = dsOT_ME_Material.Tables(2).Columns("IdMantenimientoEquipo")
            relationMantMat = New DataRelation("FK_Relacion_MM", IdMantenimiento, IdMantenimientoM, False)
            dsOT_ME_Material.Relations.Add(relationMantMat)
            dsOT_ME_Material.AcceptChanges()
            grid_OTMateriales.DataSource = dsOT_ME_Material
            With grid_OTMateriales.DisplayLayout.Bands(0)
                .Columns("IdUnidadMedida").Header.Caption = "Unidad Medida"
                .Columns("IdUnidadMedida").Width = 90
                .Columns("CantidadMaterial").Width = 60
                .Columns("CantidadMaterialEntregada").Width = 65
                .Columns("CantidadMaterialDevuelto").Width = 60
                .Columns("CantidadPendiente").Width = 65
                .Columns("Costo").Width = 70
                .Columns("Stock").Width = 60
                .Columns("IdAlmacen").Header.Caption = "Almacen"
                .Columns("IdAlmacen").Width = 150
            End With
            With grid_OTMateriales.DisplayLayout.Bands(1)
                .ColHeadersVisible = False
                .Columns("Seleccion").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .Columns("CantidadMaterial").Header.Caption = "Cantidad"
                .Columns("IdOTME").Hidden = True
                .Columns("IdEquipo").Hidden = True
                .Columns("IdMantenimiento").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("Equipo").Hidden = True
                .Columns("Seleccion").Width = 30
                .Columns("IdUnidadMedida").Width = 90
                .Columns("CantidadMaterial").Width = 60
                .Columns("CantidadMaterialEntregada").Width = 65
                .Columns("CantidadMaterialDevuelto").Width = 60
                .Columns("CantidadPendiente").Width = 65
                .Columns("Costo").Width = 70
                .Columns("Stock").Width = 60
                .Columns("IdAlmacen").Width = 150
            End With
            With grid_OTMateriales.DisplayLayout.Bands(2)
                .ColHeadersVisible = False
                .Columns("IdOTM").Hidden = True
                .Columns("Seleccion").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
                .Columns("CantidadMaterial").Header.Caption = "Cantidad"
                .Columns("IdMaterial").Hidden = True
                .Columns("IdEquipo").Hidden = True
                .Columns("IdMantenimiento").Hidden = True
                .Columns("Equipo").Hidden = True
                .Columns("Mantenimiento").Hidden = True
                .Columns("CantAux").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("IdTipoUnidadMedida").Hidden = True
                .Columns("IdSubAlmacen").Hidden = True
                .Columns("Seleccion").Width = 30
                .Columns("IdUnidadMedida").Width = 90
                .Columns("CantidadMaterial").Width = 60
                .Columns("CantidadMaterialEntregada").Width = 65
                .Columns("CantidadMaterialDevuelto").Width = 60
                .Columns("CantidadPendiente").Width = 65
                .Columns("Costo").Width = 70
                .Columns("Stock").Width = 60
                .Columns("IdAlmacen").Width = 150
                .Columns("CantidadMaterial").MaskInput = "{LOC}nnnnn.nnnn"
                .Columns("CantidadMaterial").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("CantidadMaterial").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
                .Columns("CantidadMaterialEntregada").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("CantidadMaterialDevuelto").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("CantidadPendiente").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Costo").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .Columns("Costo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Stock").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DoublePositive
                .Columns("Stock").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("FechaCreacion").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.FormattedText
            End With
            With grid_OTMateriales
                For i As Integer = 0 To .Rows.Count - 1
                    For Each aChildBand1 As Infragistics.Win.UltraWinGrid.UltraGridChildBand In .Rows(i).ChildBands
                        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In aChildBand1.Rows
                            For Each aChildBand2 As Infragistics.Win.UltraWinGrid.UltraGridChildBand In fila.ChildBands
                                For y As Integer = 0 To aChildBand2.Rows.Count - 1
                                    UnidadMedidaValueList(aChildBand2.Rows(y).Cells("IdTipoUnidadMedida").Value.ToString, grid_OTMateriales)
                                    aChildBand2.Rows(y).Cells("IdUnidadMedida").ValueList = .DisplayLayout.ValueLists("Medidas")
                                    AlmacenValueList(aChildBand2.Rows(y).Cells("IdMaterial").Value.ToString)
                                    aChildBand2.Rows(y).Cells("IdAlmacen").ValueList = .DisplayLayout.ValueLists("Almacenes")
                                    SubAlmacenValueList(aChildBand2.Rows(y).Cells("IdAlmacen").Value.ToString)
                                    aChildBand2.Rows(y).Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")
                                Next
                            Next
                        Next
                    Next
                Next
                .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditModeAndDropdown, False, False)
                .DisplayLayout.Bands(2).Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Bands(2).Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Bands(2).Override.FilterUIProvider = Filtro1
            End With
            For x As Integer = 0 To grid_OTMateriales.Rows.Count - 1
                Me.grid_OTMateriales.Rows(x).ExpandAll()
            Next
            Dim var As Double = costo
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarEquiposMantenimientoOT(ls_IdOrdenTrabajo As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            oeOTEquipoMantenimiento = New e_OrdenTrabajo_MantenimientoEquipo
            dsOT_ME = olOTEquipoMantenimiento.ListarDataSet(ls_IdOrdenTrabajo)
            Dim parentCol As DataColumn = dsOT_ME.Tables(0).Columns("IdEquipo")
            Dim childCol As DataColumn = dsOT_ME.Tables(1).Columns("IdEquipo")
            relationMantEqui = New DataRelation("FK_Relacion", parentCol, childCol, True)
            dsOT_ME.Relations.Add(relationMantEqui)
            dsOT_ME.AcceptChanges()
            grid_OT_ME.DataSource = dsOT_ME
            With grid_OT_ME.DisplayLayout.Bands(0)
                .Columns("EquipoMantenimiento").Width = 280
                ResponsableValueList(grid_OT_ME)
                .Columns("Responsable").ValueList = grid_OT_ME.DisplayLayout.ValueLists("Responsables")
            End With
            With grid_OT_ME.DisplayLayout.Bands(1)
                .ColHeadersVisible = False
                .Columns("Id").Hidden = True
                .Columns("Seleccion").Width = 30
                .Columns("Seleccion").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .Columns("IdEquipo").Hidden = True
                .Columns("IdOrdenTrabajo").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("EquipoMantenimiento").Width = 280
            End With
            For x As Integer = 0 To grid_OT_ME.Rows.Count - 1
                Me.grid_OT_ME.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        Finally
            grid_OT_ME.Focus()
        End Try
    End Sub

    Public Sub ListarActividadesOT(ls_IdOrdenTrabajo As String)
        Try
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) Equipo
            'Tabla(1) Mantenimiento
            'Tabla(2) Actividad
            ''''''''''''''''''''''''''''''''''''''''''''''
            Cursor.Current = Cursors.WaitCursor
            oeOTActividad = New e_OrdenTrabajo_Actividad

            dsOT_ME_Actividad = olOTActividad.ListarDataSet(ls_IdOrdenTrabajo)

            Dim IdEquipo As DataColumn = dsOT_ME_Actividad.Tables(0).Columns("IdEquipo")
            Dim IdEquipoM As DataColumn = dsOT_ME_Actividad.Tables(1).Columns("IdEquipo")
            relationEquMant2 = New DataRelation("FK_Relacion_EM", IdEquipo, IdEquipoM, True)
            dsOT_ME_Actividad.Relations.Add(relationEquMant2)

            Dim IdMantenimiento As DataColumn = dsOT_ME_Actividad.Tables(1).Columns("IdMantenimientoEquipo")
            Dim IdMantenimientoAct As DataColumn = dsOT_ME_Actividad.Tables(2).Columns("IdMantenimientoEquipo")
            relationMantAct = New DataRelation("FK_Relacion_MM", IdMantenimiento, IdMantenimientoAct, True)
            dsOT_ME_Actividad.Relations.Add(relationMantAct)
            dsOT_ME_Actividad.AcceptChanges()
            grid_OTActividades.DataSource = dsOT_ME_Actividad
            With grid_OTActividades.DisplayLayout.Bands(0)
                .Columns("CantidadDias").Width = 50
                .Columns("CantidadHoras").Width = 50
                .Columns("CantidadMinutos").Width = 50
            End With
            With grid_OTActividades.DisplayLayout.Bands(1)
                .ColHeadersVisible = False
                .Columns("IdOTME").Hidden = True
                .Columns("Seleccion").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .Columns("Seleccion").Width = 30
                .Columns("IdEquipo").Hidden = True
                .Columns("IdMantenimiento").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("CantidadDias").Width = 50
                .Columns("CantidadHoras").Width = 50
                .Columns("CantidadMinutos").Width = 50
            End With
            With grid_OTActividades.DisplayLayout.Bands(2)
                .ColHeadersVisible = False
                .Columns("IdOTA").Hidden = True
                .Columns("Seleccion").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .Columns("Seleccion").Width = 30
                .Columns("IdActividad").Hidden = True
                .Columns("IdMantenimiento").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True

                .Columns("CantidadDias").Width = 50
                .Columns("CantidadDias").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.IntegerNonNegativeWithSpin
                .Columns("CantidadDias").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("CantidadDias").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText

                .Columns("CantidadHoras").Width = 50
                .Columns("CantidadHoras").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.IntegerNonNegativeWithSpin
                .Columns("CantidadHoras").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("CantidadHoras").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText

                .Columns("CantidadMinutos").Width = 50
                .Columns("CantidadMinutos").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.IntegerNonNegativeWithSpin
                .Columns("CantidadMinutos").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("CantidadMinutos").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            End With
            For x As Integer = 0 To grid_OTActividades.Rows.Count - 1
                Me.grid_OTActividades.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        End Try
        grid_OTActividades.Focus()
    End Sub

    Public Sub ListarRecursosOT(ls_IdOrdenTrabajo As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            oeOTRecurso = New e_OrdenTrabajo_Recurso
            dsOT_ME_Recurso = olOTRecurso.ListarDataSet(ls_IdOrdenTrabajo)
            Dim IdEquipo As DataColumn = dsOT_ME_Recurso.Tables(0).Columns("IdEquipo")
            Dim IdEquipoM As DataColumn = dsOT_ME_Recurso.Tables(1).Columns("IdEquipo")
            relationEquMant3 = New DataRelation("FK_Relacion_EM", IdEquipo, IdEquipoM, True)
            dsOT_ME_Recurso.Relations.Add(relationEquMant3)
            Dim IdMantenimiento As DataColumn = dsOT_ME_Recurso.Tables(1).Columns("IdMantenimientoEquipo")
            Dim IdMantenimientoOcup As DataColumn = dsOT_ME_Recurso.Tables(2).Columns("IdMantenimientoEquipo")
            relationMantOcup = New DataRelation("FK_Relacion_MM", IdMantenimiento, IdMantenimientoOcup, True)
            dsOT_ME_Recurso.Relations.Add(relationMantOcup)
            Dim IdOTROcupacion As DataColumn(), IdOTRTrabajador As DataColumn()
            IdOTROcupacion = New DataColumn() {dsOT_ME_Recurso.Tables(2).Columns("IdMantenimientoEquipo"), dsOT_ME_Recurso.Tables(2).Columns("IdOcupacion")}
            IdOTRTrabajador = New DataColumn() {dsOT_ME_Recurso.Tables(3).Columns("IdMantenimientoEquipo"), dsOT_ME_Recurso.Tables(3).Columns("IdOcupacion")}
            relationOcupTrab = New DataRelation("FK_Relacion_OTR", IdOTROcupacion, IdOTRTrabajador, True)
            dsOT_ME_Recurso.Relations.Add(relationOcupTrab)
            dsOT_ME_Recurso.AcceptChanges()
            grid_OTRecursos.DataSource = dsOT_ME_Recurso
            With grid_OTRecursos.DisplayLayout.Bands(0)
                .Columns("Cantidad").Width = 40
                .Columns("CantidadHoras").Width = 40
            End With
            With grid_OTRecursos.DisplayLayout.Bands(1)
                .ColHeadersVisible = False
                .Columns("IdOTME").Hidden = True
                .Columns("Seleccion").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .Columns("Seleccion").Width = 30
                .Columns("IdEquipo").Hidden = True
                .Columns("IdMantenimiento").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("Cantidad").Width = 40
                .Columns("CantidadHoras").Width = 40
            End With
            With grid_OTRecursos.DisplayLayout.Bands(2)
                .ColHeadersVisible = False
                .Columns("Seleccion").Width = 30
                .Columns("Seleccion").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .Columns("IdOcupacion").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("Cantidad").Width = 40
                .Columns("Cantidad").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Cantidad").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            End With

            With grid_OTRecursos.DisplayLayout.Bands(3)
                .ColHeadersVisible = False
                .Columns("Seleccion").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .Columns("Seleccion").Width = 30
                .Columns("IdOTR").Hidden = True
                .Columns("IdOcupacionTrabajador").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("IdOcupacion").Hidden = True
                .Columns("CantidadHoras").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .Columns("CantidadHoras").Width = 40
                .Columns("CantidadHoras").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.TimeWithSpin
                .Columns("CantidadHoras").MaskInput = "hh:mm"
                .Columns("CantidadHoras").MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
                .Columns("CantidadHoras").MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars
                .Columns("CantidadHoras").DefaultCellValue = Date.Parse("01/01/1900")
                .Columns("CantidadHoras").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            End With
            For x As Integer = 0 To grid_OTRecursos.Rows.Count - 1
                Me.grid_OTRecursos.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        End Try
        grid_OTRecursos.Focus()
    End Sub

    Public Sub ListarServiciosOT(ls_IdOrdenTrabajo As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            oeOTServicio = New e_OrdenTrabajo_Servicio
            dsOT_ME_Servicio = olOTServicio.ListarDataSet(ls_IdOrdenTrabajo)
            Dim IdEquipo As DataColumn = dsOT_ME_Servicio.Tables(0).Columns("IdEquipo")
            Dim IdEquipoM As DataColumn = dsOT_ME_Servicio.Tables(1).Columns("IdEquipo")
            relationEquMant4 = New DataRelation("FK_Relacion_EM", IdEquipo, IdEquipoM, True)
            dsOT_ME_Servicio.Relations.Add(relationEquMant4)
            Dim IdMantenimiento As DataColumn = dsOT_ME_Servicio.Tables(1).Columns("IdMantenimientoEquipo")
            Dim IdMantenimientoS As DataColumn = dsOT_ME_Servicio.Tables(2).Columns("IdMantenimientoEquipo")
            relationMantServ = New DataRelation("FK_Relacion_MS", IdMantenimiento, IdMantenimientoS, True)
            dsOT_ME_Servicio.Relations.Add(relationMantServ)
            dsOT_ME_Servicio.AcceptChanges()
            grid_OTServicios.DataSource = dsOT_ME_Servicio
            With grid_OTServicios.DisplayLayout.Bands(0)
                .Columns("Cantidad").Width = 80
                .Columns("CostoDolares").Width = 80
            End With
            With grid_OTServicios.DisplayLayout.Bands(1)
                .ColHeadersVisible = False
                .Columns("IdOTME").Hidden = True
                .Columns("Seleccion").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .Columns("Seleccion").Width = 30
                .Columns("IdEquipo").Hidden = True
                .Columns("IdMantenimiento").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("Cantidad").Width = 80
                .Columns("Costo").Width = 80
                .Columns("CostoDolares").Width = 80
            End With
            With grid_OTServicios.DisplayLayout.Bands(2)
                .ColHeadersVisible = False
                .Columns("IdOTS").Hidden = True
                .Columns("Seleccion").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .Columns("Seleccion").Width = 30
                .Columns("IdServicio").Hidden = True
                .Columns("IdMantenimiento").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("Cantidad").Width = 80
                .Columns("Cantidad").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DoubleWithSpin
                .Columns("Cantidad").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Cantidad").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
                .Columns("Costo").Width = 80
                .Columns("Costo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Costo").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
                .Columns("Costo").MaskInput = "{double:9.2}"
                .Columns("CostoDolares").Width = 80
                .Columns("CostoDolares").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("CostoDolares").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
                .Columns("CostoDolares").MaskInput = "{double:9.2}"
            End With
            For x As Integer = 0 To grid_OTServicios.Rows.Count - 1
                Me.grid_OTServicios.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        End Try
        grid_OTServicios.Focus()
    End Sub

    Public Sub ListarMateriales()
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeMaterial = New e_Material
            lstMateriales = New List(Of e_Material)
            If Not String.IsNullOrEmpty(Trim(Me.txtBuscarMateriales.Text)) Then
                oeMaterial.IdAlmacen = ""
                Me.txtBuscarMateriales.Text = LTrim(Me.txtBuscarMateriales.Text)
                If cbCodigo.Checked Then
                    oeMaterial.Codigo = txtBuscarMateriales.Text
                Else
                    oeMaterial.Nombre = txtBuscarMateriales.Text
                End If
                oeMaterial.TipoOperacion = "7"
                oeMaterial.Activo = True
                oeMaterial.IdCentro = cboCentroMaterial.Value
                lstMateriales = olMaterial.Listar_(oeMaterial)
                If cbe_Tipo.SelectedIndex = 2 Then
                    grid_Materiales.DataSource = lstMateriales.Where(Function(i) i.IdAlmacen = "1PY000000001").OrderByDescending(Function(i) i.Stock).ToList
                Else
                    grid_Materiales.DataSource = lstMateriales.OrderByDescending(Function(i) i.Stock).ToList
                End If

                grid_Materiales.DisplayLayout.Bands(0).Columns("Precio").Hidden = IIf(PerfilAsignado(gNombrePerfilJefeMantenimiento) Or PerfilAsignado(gNombrePerfilAdministrador), False, True)
                grid_Materiales.DataBind()
                oeMaterial = New e_Material
            End If
        Catch ex As Exception
            Throw ex
        Finally
            grid_Materiales.Focus()
        End Try
    End Sub

    Private Sub AgregarMaterialEquipoMantenimiento()
        Try
            If grid_OTMateriales.ActiveRow.Band.Index = 1 Then
                Dim _cant As Integer = 0
                For Each oeMaterial As e_Material In lstMateriales.Where(Function(item) item.Seleccion)
                    If ValMatDup(oeMaterial.Id, oeMaterial.Nombre, grid_OTMateriales.ActiveRow.Cells("IdMantenimiento").Value) Then Exit For
                    Dim rowMaterial As DataRow
                    rowMaterial = dsOT_ME_Material.Tables(2).NewRow
                    rowMaterial("Seleccion") = False
                    rowMaterial("IdOTM") = ""
                    rowMaterial("IdMantenimiento") = grid_OTMateriales.ActiveRow.Cells("IdMantenimiento").Value
                    rowMaterial("IdEquipo") = grid_OTMateriales.ActiveRow.Cells("IdEquipo").Value
                    rowMaterial("Mantenimiento") = grid_OTMateriales.ActiveRow.Cells("MantenimientoMaterial").Value
                    rowMaterial("Equipo") = grid_OTMateriales.ActiveRow.Cells("Equipo").Value
                    rowMaterial("IdMantenimientoEquipo") = grid_OTMateriales.ActiveRow.Cells("IdMantenimientoEquipo").Value
                    rowMaterial("IdMaterial") = oeMaterial.Id
                    rowMaterial("MantenimientoMaterial") = oeMaterial.CodigoNombre
                    rowMaterial("IdTipoUnidadMedida") = oeMaterial.IdTipoUnidadMedida
                    rowMaterial("IdUnidadMedida") = oeMaterial.IdUnidadMedida
                    rowMaterial("CantidadMaterial") = 1
                    rowMaterial("CantidadMaterialEntregada") = 0
                    rowMaterial("CantidadMaterialDevuelto") = 0
                    rowMaterial("IdAlmacen") = oeMaterial.IdAlmacen
                    rowMaterial("IdSubAlmacen") = oeMaterial.IdSubAlmacen
                    rowMaterial("Stock") = oeMaterial.Stock
                    rowMaterial("Costo") = oeMaterial.Precio
                    dsOT_ME_Material.Tables(2).Rows.Add(rowMaterial)
                    dsOT_ME_Material.Tables(2).AcceptChanges()
                    oeMaterial.Seleccion = False
                    _cant += 1
                Next
                If _cant > 0 Then
                    dsOT_ME_Material.AcceptChanges()
                    grid_Materiales.DataBind()
                    grid_OTMateriales.DataBind()
                    With grid_OTMateriales
                        For i As Integer = 0 To .Rows.Count - 1
                            For Each aChildBand1 As Infragistics.Win.UltraWinGrid.UltraGridChildBand In .Rows(i).ChildBands
                                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In aChildBand1.Rows
                                    For Each aChildBand2 As Infragistics.Win.UltraWinGrid.UltraGridChildBand In fila.ChildBands
                                        For y As Integer = 0 To aChildBand2.Rows.Count - 1
                                            UnidadMedidaValueList(aChildBand2.Rows(y).Cells("IdTipoUnidadMedida").Value.ToString, grid_OTMateriales)
                                            aChildBand2.Rows(y).Cells("IdUnidadMedida").ValueList = .DisplayLayout.ValueLists("Medidas")
                                            AlmacenValueList(aChildBand2.Rows(y).Cells("IdMaterial").Value.ToString)
                                            aChildBand2.Rows(y).Cells("IdAlmacen").ValueList = .DisplayLayout.ValueLists("Almacenes")
                                            SubAlmacenValueList(aChildBand2.Rows(y).Cells("IdAlmacen").Value.ToString)
                                            aChildBand2.Rows(y).Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")
                                        Next
                                    Next
                                Next
                            Next
                        Next
                    End With
                    oeOrdenTrabajo.Modificado = True
                    gbeMateriales.Expanded = False
                End If
                For x As Integer = 0 To grid_OTMateriales.Rows.Count - 1
                    Me.grid_OTMateriales.Rows(x).ExpandAll()
                Next
            Else
                Throw New Exception("Seleccione un mantenimiento para agregar material")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValMatDup(ls_IdMaterial As String, ls_Material As String, ls_IdMantenimiento As String) As Boolean
        Try
            For Each matRow As DataRow In dsOT_ME_Material.Tables(2).Rows
                If matRow("IdMaterial") = ls_IdMaterial AndAlso matRow("IdMantenimiento") = ls_IdMantenimiento Then
                    mensajeEmergente.Problema("Ya se agrego anteriormente el material: " & ls_Material & " al mantenimiento seleccionado", True)
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregarServicioEquipoMantenimiento()
        Try
            If grid_OTServicios.ActiveRow.Band.Index = 1 Then
                Dim _cant As Integer = 0
                For Each oeServ As e_MantenimientoServicio In lstMantenimientoServicio.Where(Function(item) item.Seleccion)
                    Dim rowServicio As DataRow
                    rowServicio = dsOT_ME_Servicio.Tables(2).NewRow
                    rowServicio("Seleccion") = False
                    rowServicio("IdOTS") = ""
                    rowServicio("IdMantenimiento") = grid_OTServicios.ActiveRow.Cells("IdMantenimiento").Value
                    rowServicio("IdMantenimientoEquipo") = grid_OTServicios.ActiveRow.Cells("IdMantenimientoEquipo").Value
                    rowServicio("IdServicio") = oeServ.IdServicio
                    rowServicio("MantenimientoServicio") = oeServ.Servicio
                    rowServicio("Cantidad") = 1
                    rowServicio("Costo") = 0 'oeServ.Costo
                    rowServicio("CostoDolares") = 0
                    dsOT_ME_Servicio.Tables(2).Rows.Add(rowServicio)
                    dsOT_ME_Servicio.Tables(2).AcceptChanges()
                    oeServ.Seleccion = False
                    _cant = _cant + 1
                Next
                If _cant > 0 Then
                    grid_Servicios.DataBind()
                    grid_OTServicios.DataBind()
                    oeOrdenTrabajo.Modificado = True
                End If
                For x As Integer = 0 To grid_OTServicios.Rows.Count - 1
                    Me.grid_OTServicios.Rows(x).ExpandAll()
                Next
            Else
                Throw New Exception("Seleccione un mantenimiento para agregar un servicio")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarTrabajadorEquipoMantenimientoOcupacion()
        Try
            If grid_Operarios.Rows.Count > 0 Then
                Dim _cant As Integer = 0, rowOcupacion As DataRow, rowTrabajador As DataRow
                Dim ls_IdOcupacion As String = "", cont As Integer = 0
                If lstTrabajadores.Exists(Function(item) item.Seleccion) Then
                    Select Case grid_OTRecursos.ActiveRow.Band.Index
                        Case 1
                            For Each item As e_OcupacionTrabajador In lstTrabajadores.Where(Function(y) y.Seleccion)
                                For Each o_Fila As DataRow In dsOT_ME_Recurso.Tables(2).Rows
                                    If grid_OTRecursos.ActiveRow.Cells("IdMantenimientoEquipo").Value = o_Fila("IdMantenimientoEquipo").ToString Then
                                        If item.IdOcupacion = o_Fila("IdOcupacion").ToString Then cont += 1
                                    End If
                                Next
                                If cont = 0 Then
                                    rowOcupacion = dsOT_ME_Recurso.Tables(2).NewRow
                                    rowOcupacion("Seleccion") = False
                                    rowOcupacion("IdMantenimientoEquipo") = grid_OTRecursos.ActiveRow.Cells("IdMantenimientoEquipo").Value
                                    rowOcupacion("IdOcupacion") = item.IdOcupacion
                                    rowOcupacion("MantenimientoOcupacion") = item.Ocupacion
                                    ls_IdOcupacion = item.IdOcupacion
                                    rowOcupacion("Cantidad") = 1
                                    dsOT_ME_Recurso.Tables(2).Rows.Add(rowOcupacion)
                                    dsOT_ME_Recurso.Tables(2).AcceptChanges()
                                End If
                                rowTrabajador = dsOT_ME_Recurso.Tables(3).NewRow
                                rowTrabajador("Seleccion") = False
                                rowTrabajador("IdOTR") = ""
                                rowTrabajador("Cantidad") = ""
                                rowTrabajador("CantidadHoras") = "01/01/1901"
                                rowTrabajador("IdOcupacion") = item.IdOcupacion
                                rowTrabajador("IdOcupacionTrabajador") = item.Id
                                rowTrabajador("IdMantenimientoEquipo") = grid_OTRecursos.ActiveRow.Cells("IdMantenimientoEquipo").Value
                                rowTrabajador("Trabajador") = item.Trabajador
                                dsOT_ME_Recurso.Tables(3).Rows.Add(rowTrabajador)
                                dsOT_ME_Recurso.Tables(3).AcceptChanges()
                                item.Seleccion = False
                                _cant += 1
                            Next
                        Case 2
                            For Each item As e_OcupacionTrabajador In lstTrabajadores.Where(Function(x) x.Seleccion)
                                rowTrabajador = dsOT_ME_Recurso.Tables(3).NewRow
                                rowTrabajador("Seleccion") = False
                                rowTrabajador("IdOTR") = ""
                                rowTrabajador("Cantidad") = ""
                                rowTrabajador("CantidadHoras") = "01/01/1901"
                                rowTrabajador("IdOcupacion") = item.IdOcupacion
                                rowTrabajador("IdOcupacionTrabajador") = item.Id
                                rowTrabajador("IdMantenimientoEquipo") = grid_OTRecursos.ActiveRow.Cells("IdMantenimientoEquipo").Value
                                rowTrabajador("Trabajador") = item.Trabajador
                                dsOT_ME_Recurso.Tables(3).Rows.Add(rowTrabajador)
                                dsOT_ME_Recurso.Tables(3).AcceptChanges()
                                item.Seleccion = False
                                _cant += 1
                            Next
                        Case Else
                            Throw New Exception("Seleccione una ocupacion para agregar un operario")
                    End Select
                    If _cant > 0 Then
                        grid_OTRecursos.DataBind()
                        grid_Operarios.DataBind()
                        oeOrdenTrabajo.Modificado = True
                        gbeOperarios.Expanded = True
                    End If
                    For x As Integer = 0 To grid_OTRecursos.Rows.Count - 1
                        Me.grid_OTRecursos.Rows(x).ExpandAll()
                    Next
                Else
                    Throw New Exception("Seleccione un trabajador para agregar")
                End If
            Else
                Throw New Exception("No hay registros para agregar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarActividadesEquipoMantenimiento()
        Try
            If grid_OTActividades.ActiveRow.Band.Index = 1 Then
                Dim _cant As Integer = 0
                For Each oeAct As e_Actividad In lstActividades.Where(Function(j) j.Seleccion)
                    Dim rowActividad As DataRow
                    rowActividad = dsOT_ME_Actividad.Tables(2).NewRow
                    rowActividad("Seleccion") = False
                    rowActividad("IdOTA") = ""
                    rowActividad("IdMantenimiento") = grid_OTActividades.ActiveRow.Cells("IdMantenimiento").Value
                    rowActividad("IdMantenimientoEquipo") = grid_OTActividades.ActiveRow.Cells("IdMantenimientoEquipo").Value
                    rowActividad("IdActividad") = oeAct.Id
                    rowActividad("MantenimientoActividad") = oeAct.Nombre
                    rowActividad("CantidadDias") = 0
                    rowActividad("CantidadHoras") = 0
                    rowActividad("CantidadMinutos") = 0
                    dsOT_ME_Actividad.Tables(2).Rows.Add(rowActividad)
                    dsOT_ME_Actividad.Tables(2).AcceptChanges()
                    oeAct.Seleccion = False
                    _cant += 1
                Next
                If _cant > 0 Then
                    grid_Actividades.DataBind()
                    grid_OTActividades.DataBind()
                    oeOrdenTrabajo.Modificado = True
                    gbeActividades.Expanded = False
                End If
                For x As Integer = 0 To grid_OTActividades.Rows.Count - 1
                    Me.grid_OTActividades.Rows(x).ExpandAll()
                Next
            Else
                Throw New Exception("Seleccione un mantenimiento para agregar actividad")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarOrdenTrabajo(ls_IdOT As String)
        Try
            If Not String.IsNullOrEmpty(ls_IdOT) Then
                sw = True
                Inicializa()
                oeOrdenTrabajo.Id = ls_IdOT
                oeOrdenTrabajo = olOrdenTrabajo.Obtener(oeOrdenTrabajo)
                txtNroOT.Text = oeOrdenTrabajo.NroOT
                txtEstado.Text = oeOrdenTrabajo.EstadoOT
                Select Case oeOrdenTrabajo.EstadoOT
                    Case "PENDIENTE"
                        FormatearFormulario(True)
                        btnDevolucion.Enabled = False
                        btnActualizar.Enabled = False
                    Case "EN PROCESO"
                        FormatearFormulario(True)
                        btnDevolucion.Enabled = True
                        btnActualizar.Enabled = True
                    Case "LIBERADA"
                        FormatearFormulario(True)
                        btnDevolucion.Enabled = True
                        btnActualizar.Enabled = True
                    Case "TERMINADA", "ANULADA"
                        FormatearFormulario(False)
                        btnDevolucion.Enabled = False
                        btnActualizar.Enabled = False
                End Select
                txtGlosa.Text = oeOrdenTrabajo.Glosa
                cbAuxilio.Checked = oeOrdenTrabajo.Auxilio
                cbSiniestro.Checked = oeOrdenTrabajo.Siniestro
                cbCalibracion.Checked = oeOrdenTrabajo.Calibracion
                dtpFechaProg.Value = oeOrdenTrabajo.FechaProgramacionIni
                dtp_FecIngTaller.Value = oeOrdenTrabajo.FechaIngresoTaller
                dtp_HorIngTaller.Value = oeOrdenTrabajo.FechaIngresoTaller
                dtp_FecIniTrab.Value = oeOrdenTrabajo.FechaInicioTrabajo
                dtp_HorIniTrab.Value = oeOrdenTrabajo.FechaInicioTrabajo
                dtp_FecFinTrab.Value = oeOrdenTrabajo.FechaFinTrabajo
                dtp_HorFinTrab.Value = oeOrdenTrabajo.FechaFinTrabajo
                dtpFechaTentativaSalida.Value = oeOrdenTrabajo.FechaTentativaSalida
                cmbJefeTaller.Value = oeOrdenTrabajo.IdJefeTaller
                cmbSupervisorMant.Value = oeOrdenTrabajo.IdSupervisorMant
                cbe_Tipo.Value = oeOrdenTrabajo.IndicadorTipo
                Select Case oeOrdenTrabajo.TipoOrden.Trim
                    Case "1"
                        cboTipoOrden.SelectedIndex = 0
                    Case "2"
                        cboTipoOrden.SelectedIndex = 1
                    Case "3"
                        cboTipoOrden.SelectedIndex = 2
                    Case Else
                        cboTipoOrden.SelectedIndex = -1
                End Select
                If oeOrdenTrabajo.IdEmpresaExterna.Trim <> "" Then
                    ListarProveedores(cboProveedor, oeOrdenTrabajo.IdEmpresaExterna, 0)
                    cboProveedor.Value = oeOrdenTrabajo.IdEmpresaExterna
                End If
                MostrarTabs(1, ficOrdenTrabajo, 1)
                ListarEquiposMantenimientoOT(ls_IdOT)
                ListarMaterialesOT(ls_IdOT)
                ListarActividadesOT(ls_IdOT)
                ListarRecursosOT(ls_IdOT)
                ListarServiciosOT(ls_IdOT)
                CalcularTotalServicios()
                sw = False
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CalcularTotalServicios()
        Dim costo As Double = 0
        For Each servRow As DataRow In dsOT_ME_Servicio.Tables(2).Rows
            costo += servRow("Costo")
        Next
        Me.ndTotalServicios.Value = costo
    End Sub

    Private Sub QuitarDetalle()
        Try
            Select Case ficOrdenTrabajoDet.SelectedTab.Index
                Case 0 : QuitarEquiposMantenimiento()
                Case 1 : QuitarMaterialesMantenimientoOT()
                Case 2 : QuitarServiciosMantenimientoOT()
                Case 3 : QuitarRecursosMantenimientoOT()
                Case 4 : QuitarActividadesMantenimientoOT()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub QuitarEquiposMantenimiento()
        Try
            With grid_OT_ME
                Dim sw As Boolean = False
                For Each equiRow As DataRow In dsOT_ME.Tables(0).Rows
                    If equiRow("Seleccion") Then sw = True
                    For Each mantRow As DataRow In equiRow.GetChildRows(relationMantEqui)
                        If mantRow("Seleccion") Then sw = True
                    Next
                Next
                If Not sw Then Throw New Exception("Marque por lo menos un registro para quitar de lista")

                If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", _
                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    For Each equiRow As DataRow In dsOT_ME.Tables(0).Rows
                        If equiRow("Seleccion") Then
                            QuitarMaterialesEquipoMantenimiento(equiRow("IdEquipo"), "")
                            QuitarServiciosEquipoMantenimiento(equiRow("IdEquipo"), "")
                            QuitarActividadesEquipoMantenimiento(equiRow("IdEquipo"), "")
                            QuitarRecursosEquipoMantenimiento(equiRow("IdEquipo"), "")
                            equiRow.Delete()
                            If grid_OT_ME.Rows.Count = 0 Then
                                For i As Integer = 0 To ficOrdenTrabajoDet.Tabs.Count - 1
                                    ficOrdenTrabajoDet.Tabs(i).Enabled = False
                                Next
                                ficOrdenTrabajoDet.Tabs(0).Enabled = True
                            End If
                        Else
                            For Each mantRow As DataRow In equiRow.GetChildRows(relationMantEqui)
                                If mantRow("Seleccion") Then
                                    QuitarMaterialesEquipoMantenimiento("", mantRow("IdMantenimientoEquipo"))
                                    QuitarServiciosEquipoMantenimiento("", mantRow("IdMantenimientoEquipo"))
                                    QuitarActividadesEquipoMantenimiento("", mantRow("IdMantenimientoEquipo"))
                                    QuitarRecursosEquipoMantenimiento("", mantRow("IdMantenimientoEquipo"))
                                    mantRow.Delete()
                                End If
                            Next
                        End If
                    Next
                    dsOT_ME.AcceptChanges()
                    dsOT_ME_Material.AcceptChanges()
                    dsOT_ME_Servicio.AcceptChanges()
                    dsOT_ME_Actividad.AcceptChanges()
                    dsOT_ME_Recurso.AcceptChanges()
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub QuitarMaterialesEquipoMantenimiento(ls_IdEquipo As String, ls_IdMantenimientoEquipo As String)
        Try
            olDetalleMarAux = New l_OrdenTrabajo_Material
            For Each equiRow As DataRow In dsOT_ME_Material.Tables(0).Rows
                If equiRow("IdEquipo") = ls_IdEquipo Then
                    Dim _leDetMatAux As New List(Of e_OrdenTrabajo_Material)
                    If Not String.IsNullOrEmpty(IdOT) Then
                        oeDetalleMatAux = New e_OrdenTrabajo_Material
                        oeDetalleMatAux.TipoOperacion = ""
                        oeDetalleMatAux.IdOrdenTrabajo = IdOT
                        oeDetalleMatAux.Activo = True
                        leDetalleMatAux = olDetalleMarAux.Listar(oeDetalleMatAux)
                    End If
                    For Each mantRow As DataRow In equiRow.GetChildRows(relationEquMant)
                        For Each matRow As DataRow In mantRow.GetChildRows(relationMantMat)
                            If matRow("IdOTM").ToString <> "" Then
                                Dim _idOTM As String = matRow("IdOTM").ToString
                                _leDetMatAux = leDetalleMatAux.Where(Function(it) it.Id = _idOTM And it.CantidadMaterialEntregada > 0).ToList
                                If _leDetMatAux.Count > 0 Then
                                    'matRow("CantidadMaterialEntregada") = _leDetMatAux(0).CantidadMaterialEntregada
                                    Throw New Exception("Se acaba de atender el siguente material: " & Environment.NewLine & _
                                                        matRow("MantenimientoMaterial").ToString & _
                                                        ", Cantidad: " & _leDetMatAux(0).CantidadMaterialEntregada & _
                                                        Environment.NewLine & "Dele Clic en 'Actializar' para obtener las ultimas atenciones")
                                End If
                            Else
                                If matRow("CantidadMaterialEntregada") > 0 Then
                                    Throw New Exception("No se puede eliminar el mantenimiento, tiene materiales atendidos.")
                                End If
                            End If
                        Next
                    Next
                    For Each mantRow As DataRow In equiRow.GetChildRows(relationEquMant)
                        For Each matRow As DataRow In mantRow.GetChildRows(relationMantMat)
                            matRow.Delete()
                        Next
                        mantRow.Delete()
                    Next
                    equiRow.Delete()
                Else
                    '_lsMensajeAtiente = String.Empty
                    Dim _leDetMatAux As New List(Of e_OrdenTrabajo_Material)
                    If Not String.IsNullOrEmpty(IdOT) Then
                        oeDetalleMatAux = New e_OrdenTrabajo_Material
                        oeDetalleMatAux.TipoOperacion = ""
                        oeDetalleMatAux.IdOrdenTrabajo = IdOT
                        oeDetalleMatAux.Activo = True
                        leDetalleMatAux = olDetalleMarAux.Listar(oeDetalleMatAux)
                    End If
                    For Each mantRow As DataRow In equiRow.GetChildRows(relationEquMant)
                        If mantRow("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo Then
                            For Each matRow As DataRow In mantRow.GetChildRows(relationMantMat)
                                If matRow("IdOTM").ToString <> "" Then
                                    Dim _idOTM As String = matRow("IdOTM").ToString
                                    _leDetMatAux = leDetalleMatAux.Where(Function(it) it.Id = _idOTM And it.CantidadMaterialEntregada > 0).ToList
                                    If _leDetMatAux.Count > 0 Then
                                        'matRow("CantidadMaterialEntregada") = _leDetMatAux(0).CantidadMaterialEntregada
                                        Throw New Exception("Se acaba de atender el siguente material: " & Environment.NewLine & _
                                                            matRow("MantenimientoMaterial").ToString & _
                                                            ", Cantidad: " & _leDetMatAux(0).CantidadMaterialEntregada & _
                                                            Environment.NewLine & "Dele Clic en 'Actializar' para obtener las ultimas atenciones")
                                    End If
                                Else
                                    If matRow("CantidadMaterialEntregada") > 0 Then
                                        Throw New Exception("No se puede eliminar el mantenimiento, tiene materiales atendidos.")
                                    End If
                                End If
                            Next
                            For Each matRow As DataRow In mantRow.GetChildRows(relationMantMat)
                                matRow.Delete()
                            Next
                            mantRow.Delete()
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub QuitarServiciosEquipoMantenimiento(ls_IdEquipo As String, ls_IdMantenimientoEquipo As String)
        Try
            For Each equiRow As DataRow In dsOT_ME_Servicio.Tables(0).Rows
                If equiRow("IdEquipo") = ls_IdEquipo Then
                    equiRow.Delete()
                Else
                    For Each mantRow As DataRow In equiRow.GetChildRows(relationEquMant4)
                        If mantRow("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo Then
                            mantRow.Delete()
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub QuitarActividadesEquipoMantenimiento(ls_IdEquipo As String, ls_IdMantenimientoEquipo As String)
        Try
            For Each equiRow As DataRow In dsOT_ME_Actividad.Tables(0).Rows
                If equiRow("IdEquipo") = ls_IdEquipo Then
                    equiRow.Delete()
                Else
                    For Each mantRow As DataRow In equiRow.GetChildRows(relationEquMant2)
                        If mantRow("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo Then
                            mantRow.Delete()
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub QuitarRecursosEquipoMantenimiento(ls_IdEquipo As String, ls_IdMantenimientoEquipo As String)
        Try
            For Each equiRow As DataRow In dsOT_ME_Recurso.Tables(0).Rows
                If equiRow("IdEquipo") = ls_IdEquipo Then
                    equiRow.Delete()
                Else
                    For Each mantRow As DataRow In equiRow.GetChildRows(relationEquMant3)
                        If mantRow("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo Then mantRow.Delete()
                    Next
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub QuitarMaterialesMantenimientoOT()
        Try
            leDetalleMatAux = New List(Of e_OrdenTrabajo_Material)
            With grid_OTMateriales
                Dim sw As Boolean
                Dim _leDetMatAux As New List(Of e_OrdenTrabajo_Material)
                If Not String.IsNullOrEmpty(IdOT) Then
                    oeDetalleMatAux = New e_OrdenTrabajo_Material
                    oeDetalleMatAux.TipoOperacion = ""
                    oeDetalleMatAux.IdOrdenTrabajo = IdOT
                    oeDetalleMatAux.Activo = True
                    leDetalleMatAux = olDetalleMarAux.Listar(oeDetalleMatAux)
                End If
                For Each mantRow As DataRow In dsOT_ME_Material.Tables(1).Rows
                    For Each matRow As DataRow In mantRow.GetChildRows(relationMantMat)
                        If matRow("Seleccion") Then
                            sw = True
                            If matRow("IdOTM").ToString <> "" Then
                                Dim _idOTM As String = matRow("IdOTM").ToString
                                _leDetMatAux = leDetalleMatAux.Where(Function(it) it.Id = _idOTM And it.CantidadMaterialEntregada > 0).ToList
                                If _leDetMatAux.Count > 0 Then
                                    matRow("Seleccion") = 0
                                    'matRow("CantidadMaterialEntregada") = _leDetMatAux(0).CantidadMaterialEntregada
                                    Throw New Exception("El material: " & Environment.NewLine & _
                                                        matRow("MantenimientoMaterial").ToString & _
                                                        ", fue atendido.Cantidad: " & _leDetMatAux(0).CantidadMaterialEntregada & _
                                                        Environment.NewLine & "Dale Clic en 'Actualizar' para obtener las ultimas atenciones")
                                End If

                                If Not VerificarRegistroEditado(oeOrdenTrabajo.Id, matRow("MantenimientoMaterial").ToString) Then Exit Sub
                                'Else
                                'If matRow("CantidadMaterialEntregada") > 0 Then
                                '    matRow("Seleccion") = 0
                                '    Throw New Exception("No se puede eliminar el mantenimiento, tiene materiales atendidos.")
                                'End If
                            End If
                        End If
                    Next
                Next
                If Not sw Then Throw New Exception("Marque por lo menos un material para quitar de lista")
                If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    For Each mantRow As DataRow In dsOT_ME_Material.Tables(1).Rows
                        For Each matRow As DataRow In mantRow.GetChildRows(relationMantMat)
                            If matRow("Seleccion") Then matRow.Delete()
                        Next
                        mantRow("Seleccion") = False
                    Next
                    dsOT_ME_Material.AcceptChanges()
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function VerificarRegistroEditado(ls_IdOT As String, ls_Material As String) As Boolean
        Try
            Dim oeReq As New e_Requerimiento
            Dim lsteReq As New List(Of e_Requerimiento)
            oeReq.TipoOperacion = "7"
            oeReq.TipoReferencia = "ORDEN TRABAJO"
            oeReq.IdReferencia = ls_IdOT
            lsteReq = olRequerimiento.Listar(oeReq)
            For Each fila As e_Requerimiento In lsteReq
                If fila.UsuarioCreacion <> "" Then
                    mensajeEmergente.Confirmacion("El material " & ls_Material & " no es posible eliminarlo, esta siendo atendido por" & _
                                                  Environment.NewLine & _
                                                  "el Usuario: " & fila.IdArea & Environment.NewLine & _
                                                  "desde: " & fila.FechaCreacion & Environment.NewLine & _
                                                  "en la Sucursal: " & fila.IdUsuarioAtencion, True)
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub QuitarServiciosMantenimientoOT()
        Try
            With grid_OTServicios
                Dim sw As Boolean = False
                For Each mantRow As DataRow In dsOT_ME_Servicio.Tables(1).Rows
                    If mantRow("Seleccion") Then sw = True
                    For Each servRow As DataRow In mantRow.GetChildRows(relationMantServ)
                        If servRow("Seleccion") Then sw = True
                    Next
                Next
                If Not sw Then Throw New Exception("Marque por lo menos un registro para quitar de lista")

                If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    For Each mantRow As DataRow In dsOT_ME_Servicio.Tables(1).Rows
                        For Each servRow As DataRow In mantRow.GetChildRows(relationMantServ)
                            If servRow("Seleccion") Then
                                servRow.Delete()
                            End If
                        Next
                        mantRow("Seleccion") = False
                    Next
                    dsOT_ME_Servicio.AcceptChanges()
                    CalcularTotalServicios()
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub QuitarRecursosMantenimientoOT()
        Try
            With grid_OTRecursos
                Dim sw As Boolean = False
                For Each mantRow As DataRow In dsOT_ME_Recurso.Tables(1).Rows
                    If mantRow("Seleccion") Then sw = True
                    For Each ocupRow As DataRow In mantRow.GetChildRows(relationMantOcup)
                        If ocupRow("Seleccion") Then sw = True
                        For Each trabRow As DataRow In ocupRow.GetChildRows(relationOcupTrab)
                            If trabRow("Seleccion") Then sw = True
                        Next
                    Next
                Next
                If Not sw Then Throw New Exception("Marque por lo menos un registro para quitar de lista.")
                If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    For Each mantRow As DataRow In dsOT_ME_Recurso.Tables(1).Rows
                        For Each ocupRow As DataRow In mantRow.GetChildRows(relationMantOcup)
                            If ocupRow("Seleccion") Then
                                ocupRow.Delete()
                            Else
                                For Each trabRow As DataRow In ocupRow.GetChildRows(relationOcupTrab)
                                    If trabRow("Seleccion") Then trabRow.Delete()
                                Next
                            End If
                        Next
                        mantRow("Seleccion") = False
                    Next
                    dsOT_ME_Recurso.AcceptChanges()
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub QuitarActividadesMantenimientoOT()
        Try
            With grid_OTActividades
                Dim sw As Boolean = False
                For Each mantRow As DataRow In dsOT_ME_Actividad.Tables(1).Rows
                    If mantRow("Seleccion") Then sw = True
                    For Each actRow As DataRow In mantRow.GetChildRows(relationMantAct)
                        If actRow("Seleccion") Then sw = True
                    Next
                Next
                If Not sw Then Throw New Exception("Marque por lo menos un registro para quitar de lista")

                If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    For Each mantRow As DataRow In dsOT_ME_Actividad.Tables(1).Rows
                        For Each actRow As DataRow In mantRow.GetChildRows(relationMantAct)
                            If actRow("Seleccion") Then actRow.Delete()
                        Next
                        mantRow("Seleccion") = False
                    Next
                    dsOT_ME_Actividad.AcceptChanges()
                    CalcularFechaTentativaSalida()
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CalcularFechaTentativaSalida()
        Dim cantdias As Double = 0, canthor As Double = 0, cantmin As Double = 0
        For Each actRow As DataRow In dsOT_ME_Actividad.Tables(2).Rows
            cantdias += actRow("CantidadDias")
            canthor += actRow("CantidadHoras")
            cantmin += actRow("CantidadMinutos")
        Next
        Dim ff As DateTime = Me.dtp_FecIniTrab.Value
        ff = ff.AddMinutes(cantmin)
        ff = ff.AddHours(canthor)
        ff = ff.AddDays(cantdias)
        'Me.dtpFechaFinTrab.Value = ff
        Me.dtpFechaTentativaSalida.Value = ff
    End Sub

    Sub ListarServicios()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoServicio = New e_MantenimientoServicio
            lstMantenimientoServicio = New List(Of e_MantenimientoServicio)
            oeMantenimientoServicio.TipoOperacion = "L"
            oeMantenimientoServicio.Activo = True
            oeMantenimientoServicio.IdMantenimiento = grid_OTServicios.ActiveRow.Cells("IdMantenimiento").Value
            lstMantenimientoServicio = olMantenimientoServicio.Listar(oeMantenimientoServicio)
            grid_Servicios.DataSource = lstMantenimientoServicio
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CambiarEstadoOT()
        Try
            '------- CONTROLAR AUTENTICACIÓN DEL TRABAJADOR  ------------
            Dim formulario As frm_AutenticarTrabajador
            formulario = New frm_AutenticarTrabajador
            If formulario.ShowDialog = Windows.Forms.DialogResult.OK Then
                oeTrabajadorSeguridad = New e_TrabajadorSeguridad
                oeProcesoNegocio = New e_ProcesoNegocio

                oeProcesoNegocio.TipoOperacion = ""
                oeProcesoNegocio.Nombre = "CAMBIAR ESTADO OT"
                oeProcesoNegocio = olProcesoNegocio.Obtener(oeProcesoNegocio)

                oeTrabajadorSeguridad.TipoOperacion = ""
                oeTrabajadorSeguridad.IdTrabajador = formulario.cboTrabajador.Value
                oeTrabajadorSeguridad.IdProcesoNegocio = oeProcesoNegocio.Id
                oeTrabajadorSeguridad = olTrabajadorSeguridad.Obtener(oeTrabajadorSeguridad)

                If String.IsNullOrEmpty(oeTrabajadorSeguridad.Id) Then
                    mensajeEmergente.Problema("Trabajador no esta autorizado para cambiar estado de la OT.")
                Else
                    oeEstadoOT = New e_EstadoOT
                    oeEstadoOT.Activo = True
                    oeEstadoOT.Nombre = "EN PROCESO"
                    oeEstadoOT = olEstadoOT.Obtener(oeEstadoOT)

                    oeOrdenTrabajo = New e_OrdenTrabajo
                    oeOrdenTrabajo.Id = grid_OrdenTrabajo.ActiveRow.Cells("IdOT").Value.ToString
                    oeOrdenTrabajo.IdEstadoOT = oeEstadoOT.Id
                    oeOrdenTrabajo.EstadoOT = oeEstadoOT.Nombre
                    oeOrdenTrabajo.TipoOperacion = "C"
                    olOrdenTrabajo.ActualizaEstadoOT(oeOrdenTrabajo)
                End If
            End If
            formulario = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GenerarDevolucionMaterial()
        Try
            If ValidarGrilla(grid_OTMateriales, "Materiales") Then
                Dim _muestra As Boolean = True
                Dim oeOrdenIngreso As New e_Orden, olOrdenIngreso As New l_Orden
                Dim lstDetalleOrdenIngreso As New List(Of e_OrdenMaterial)
                Dim oeMovimientoInventario As New e_MovimientoInventario, olMovimientoInvetario As New l_MovimientoInventario
                Dim oeMoneda As New e_Moneda, olMoneda As New l_Moneda
                Dim oeTipoOrden As New e_TipoOrden, olTipoOrden As New l_TipoOrden
                With grid_OTMateriales
                    If .ActiveRow.Band.Index = 2 Then
                        If Not fn_VerificarExistenciaOIxMantDev() Then Exit Sub
                        If .ActiveRow.Cells("CantidadMaterial").Value = .ActiveRow.Cells("CantidadMaterialDevuelto").Value Then Throw New Exception("No se puede devolver mas de lo que se entrego")
                        If .ActiveRow.Cells("CantidadMaterialEntregada").Value = 0 Then Throw New Exception("No se puede Devolver mas de lo que entrego")
                        'Codigo Nuevo
                        Dim _cantpenddevol As Double = 0
                        Dim _cantentaux As Double = 0
                        Dim _lsDetalle As String = ""

                        oeDetalleMatAux = New e_OrdenTrabajo_Material
                        oeDetalleMatAux.TipoOperacion = ""
                        oeDetalleMatAux.Id = .ActiveRow.Cells("IdOTM").Value.ToString
                        oeDetalleMatAux.Activo = True
                        oeDetalleMatAux = olDetalleMarAux.Obtener(oeDetalleMatAux)

                        _cantpenddevol = oeDetalleMatAux.CantidadMaterialDevuelto
                        _cantentaux = oeDetalleMatAux.CantidadMaterialEntregada

                        If oeDetalleMatAux.CantidadMaterialDevuelto > .ActiveRow.Cells("CantidadMaterialDevuelto").Value Then
                            Throw New Exception("Se acaba de atender la  Orden de Ingreso por Devolucion del " & Environment.NewLine & _
                                                "Material: " & .ActiveRow.Cells("MantenimientoMaterial").Value.ToString & Environment.NewLine & _
                                                " Cantidad: " & oeDetalleMatAux.CantidadMaterialDevuelto.ToString("#,##0.00") & _
                                                Environment.NewLine & "Se Recomienda hacer clic en el Boton: 'Actualizar'" & _
                                                " para Obtener las devoluciones realizadas")
                            ' _cantpenddevol = oeDetalleMatAux.CantidadMaterialDevuelto
                        Else
                            Dim oeOM As New e_OrdenMaterial
                            Dim olOM As New l_OrdenMaterial
                            Dim leOM As New List(Of e_OrdenMaterial)
                            oeOM.TipoOperacion = "D"
                            oeOM.IdMaterial = .ActiveRow.Cells("IdMaterial").Value.ToString
                            oeOM.IdOrden = .ActiveRow.Cells("IdOTM").Value.ToString
                            oeOM.Id = .ActiveRow.Cells("IdSubAlmacen").Value.ToString
                            leOM = olOM.Listar(oeOM)
                            If leOM.Count > 0 Then
                                _cantpenddevol = _cantpenddevol + leOM.Sum(Function(it) it.CantidadMaterial)
                                For Each _oe In leOM
                                    _lsDetalle = _lsDetalle & Environment.NewLine & "(*) Nro Orden Ingreso: " & _oe.NroOrden & _
                                                Environment.NewLine & "Cantidad: " & _oe.CantidadMaterial.ToString("#,##0.00")
                                Next
                                If oeDetalleMatAux.CantidadMaterialDevuelto > 0 Then
                                    _lsDetalle = _lsDetalle & Environment.NewLine & _
                                    "Cantidad Devuelta: " & oeDetalleMatAux.CantidadMaterialDevuelto.ToString("#,##0.00") & _
                                    Environment.NewLine & "(Hacer clic en el Boton 'Actualizar')"
                                End If
                                If MessageBox.Show("El Material: " & leOM(0).Material & Environment.NewLine & _
                                                " Tiene Orden de Ingreso por Devolucion por atender:" & _
                                                _lsDetalle & _
                                                Environment.NewLine & "¿Desea Continuar con la Operacion?", _
                                                "Mensaje de Sistema", _
                                                MessageBoxButtons.YesNo, _
                                                MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                                    '    _muestra = True
                                    'Else
                                    _muestra = False
                                End If
                                '------------
                            End If
                            If .ActiveRow.Cells("CantidadMaterialEntregada").Value - _cantpenddevol = 0 Then
                                Throw New Exception("No tiene Cantidad Entregada de Materiales para hacer devoluciones")
                            End If

                            If _cantentaux - .ActiveRow.Cells("CantidadMaterialEntregada").Value > 0 Then
                                Dim _dir As Double = 0
                                _dir = _cantentaux - .ActiveRow.Cells("CantidadMaterialEntregada").Value
                                MessageBox.Show("Se acaba de atender " & _dir & _
                                                " Unidades de Material : " & .ActiveRow.Cells("MantenimientoMaterial").Value.ToString, _
                                                "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If

                            'Formulario
                            If _muestra Then
                                Dim o_Frm As New frm_DevolucionMaterial
                                If o_Frm.CargarDatosMaterial(.ActiveRow.Cells("IdMaterial").Value.ToString, _cantentaux, _cantpenddevol) Then
                                    If o_Frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                        oeDetalleOrdenIngreso = New e_OrdenMaterial
                                        oeDetalleOrdenIngreso.Activo = True
                                        oeDetalleOrdenIngreso.IdMaterial = .ActiveRow.Cells("IdMaterial").Value.ToString
                                        oeDetalleOrdenIngreso.Material = .ActiveRow.Cells("MantenimientoMaterial").Value.ToString
                                        oeDetalleOrdenIngreso.CantidadMaterial = CDbl(o_Frm.ndCantidad.Value)
                                        oeDetalleOrdenIngreso.PrecioUnitario = Math.Round((.ActiveRow.Cells("Costo").Value) * (1 + oeIGVGlobal.Porcentaje), 4) '(1 + oeIGV.Porcentaje)
                                        oeDetalleOrdenIngreso.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value.ToString
                                        oeDetalleOrdenIngreso.IdSubAlmacen = .ActiveRow.Cells("IdSubAlmacen").Value.ToString
                                        oeDetalleOrdenIngreso.IdTipoUnidadMedida = .ActiveRow.Cells("IdTipoUnidadMedida").Value.ToString
                                        oeDetalleOrdenIngreso.IdUnidadMedida = .ActiveRow.Cells("IdUnidadMedida").Value.ToString
                                        oeDetalleOrdenIngreso.UnidadMedida = ""
                                        oeDetalleOrdenIngreso.TipoReferencia = "OT"
                                        oeDetalleOrdenIngreso.IdReferencia = .ActiveRow.Cells("IdOTM").Value.ToString
                                        oeDetalleOrdenIngreso.ValorVenta = oeDetalleOrdenIngreso.PrecioUnitario * oeDetalleOrdenIngreso.CantidadMaterial
                                        lstDetalleOrdenIngreso.Add(oeDetalleOrdenIngreso)

                                        oeOrdenIngreso.lstOrdenMaterial = lstDetalleOrdenIngreso
                                        oeOrdenIngreso.Activo = True
                                        oeOrdenIngreso.Total = CDbl(o_Frm.ndCantidad.Value)
                                        '---------------------------------------
                                        oeOrdenIngreso.IdTipoOrden = "1CH000000001" 'ORDEN DE INGRESO
                                        '---------------------------------------
                                        oeOrdenIngreso.IdMovimientoInventario = "1CH000000013" 'MANTENIMIENTO - DEVOLUCION
                                        '---------------------------------------
                                        oeOrdenIngreso.IdMoneda = "1CH01" 'SOLES
                                        '---------------------------------------
                                        oeEquipo = New e_Equipo
                                        oeEquipo.Activo = True
                                        oeEquipo.Id = .ActiveRow.ParentRow.Cells("IdEquipo").Value.ToString
                                        oeEquipo = olEquipo.Obtener(oeEquipo)
                                        oeOrdenIngreso.Glosa = oeEquipo.Nombre & " / " & .ActiveRow.ParentRow.Cells("MantenimientoMaterial").Value.ToString
                                        '---------------------------------------
                                        oeOrdenIngreso.IdProveedor = ISL_IdProveedor  'idProveedor   

                                        '---------------------------------------
                                        oeOrdenIngreso.FechaOrden = Date.Now
                                        oeOrdenIngreso.TipoOperacion = "I"
                                        oeOrdenIngreso.IdSubAlmacenDestino = ""
                                        oeOrdenIngreso.IdSubAlmacenOrigen = ""
                                        oeOrdenIngreso.TipoReferencia = "ORDEN TRABAJO"
                                        oeOrdenIngreso.Referencia = oeOrdenTrabajo.NroOT
                                        oeOrdenIngreso.UsuarioCreacion = gUsuarioSGI.Id
                                        oeOrdenIngreso.PrefijoID = gs_PrefijoIdSucursal '@0001
                                        olOrdenIngreso.Guardar(oeOrdenIngreso, New List(Of e_RegistroInventario))
                                        mensajeEmergente.Confirmacion("Devolución realizada con exito", True)
                                    End If
                                Else
                                    Throw New Exception("El Material se encuentra eliminado")
                                End If
                            End If
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                        End If
                    Else
                        Throw New Exception("Selecccione un Material para generar una devolucion.")
                    End If
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_VerificarExistenciaOIxMantDev() As Boolean
        Try
            oeDetalleOrdenIngreso = New e_OrdenMaterial
            oeDetalleOrdenIngreso.Activo = True
            oeDetalleOrdenIngreso.TipoOperacion = "V"
            oeDetalleOrdenIngreso.IdMaterial = grid_OTMateriales.ActiveRow.Cells("IdMaterial").Value.ToString
            oeDetalleOrdenIngreso.TipoReferencia = "OT"
            oeDetalleOrdenIngreso.IdReferencia = grid_OTMateriales.ActiveRow.Cells("IdOTM").Value.ToString
            If olDetalleOrdenIngreso.Listar(oeDetalleOrdenIngreso).Count > 0 Then
                Throw New Exception("Existe una Orden de Ingreso (" & olDetalleOrdenIngreso.Listar(oeDetalleOrdenIngreso)(0).NroOrden.ToString & ") por devolucion de este material sin ejecutar")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarOrdenTrabajo() As Boolean
        Try
            fn_ValidarFechasOT()
            TransponerDetalleEquipoMantenimiento()
            TransponerDetalleMaterial()
            If datoValido Then
                TransponerDetalleServicio()
                oeOrdenTrabajo.UsuarioTermina = String.Empty
                If lbl_etiqueta.Text = "TERMINANDO OT" Then
                    ValidaPendientes()
                    oeOrdenTrabajo.UsuarioTermina = gUsuarioSGI.Id
                End If
                If oeOrdenTrabajo.IndicadorTipo = "I" Then
                    TransponerDetalleOperarios()
                End If
                TransponerDetalleActividades()
                VerificaCotizacion()
                oeOrdenTrabajo.PrefijoID = gs_PrefijoIdSucursal '@0001
                Dim _NroOT As String = olOrdenTrabajo.Guardar(oeOrdenTrabajo)
                If _NroOT <> "" Then
                    Select Case oeOrdenTrabajo.TipoOperacion
                        Case "I"
                            _NroOT = "OT" & Strings.Right(_NroOT, 11)
                            mensajeEmergente.Confirmacion("Se genero satisfactoriamente la OT N°: " & _NroOT & " satisfactoriamente", True)
                        Case "A"
                            If _lsMensajeAtiente.Length > 0 Then
                                _lsMensajeAtiente = "La información ha sido grabada satisfactoriamente en " & Me.Text & Environment.NewLine & _
                                "Se ha Atendido los Siguientes Materiales:" & Environment.NewLine & _lsMensajeAtiente
                                mensajeEmergente.Confirmacion(_lsMensajeAtiente, True)
                            Else
                                mensajeEmergente.Confirmacion("La información ha sido grabada satisfactoriamente en " & Me.Text, True)
                            End If
                        Case "S"
                            If oeOrdenTrabajo.oeOCOT.Id = "" Then
                                GenerarRequerimientos()
                            End If
                            mensajeEmergente.Confirmacion("La OT N°: " & Me.txtNroOT.Text & " fue iniciada satisfactoriamente", True)
                        Case "F"
                            mensajeEmergente.Confirmacion("La OT N°: " & Me.txtNroOT.Text & " fue terminada satisfactoriamente", True)
                            If oeOrdenTrabajo.IndicadorTipo = "E" Then
                                If MessageBox.Show("¿Desea enviar e-mail al proveedor para solicitar factura?", _
                                       "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                    Dim Msg As String = "Solicito enviar comprobante para los servicios realizados a las siguientes unidades:  " & _
                                    Environment.NewLine & ls_GlosaEquipos & Environment.NewLine & " " & Environment.NewLine & "Orden Trabajo N°: " & Me.txtNroOT.Text
                                    EnviarCorreo(Msg)
                                End If
                            End If
                    End Select
                    MostrarTabs(0, ficOrdenTrabajo, 2)
                    Consultar(True)
                    grid_OrdenTrabajo.Focus()
                    Return True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fn_ValidarFechasOT() As Boolean
        Try
            Dim _FechaIngreso As Date, _FechaInicio As Date, _FechaFin As Date
            _FechaIngreso = Date.Parse(dtp_FecIngTaller.Value.Date & " " & dtp_HorIngTaller.Value.ToShortTimeString)
            _FechaInicio = Date.Parse(dtp_FecIniTrab.Value.Date & " " & dtp_HorIniTrab.Value.ToShortTimeString)
            _FechaFin = Date.Parse(dtp_FecFinTrab.Value.Date & " " & dtp_HorFinTrab.Value.ToShortTimeString)
            If _FechaIngreso > _FechaInicio Then Throw New Exception("La Fecha de Ingreso a Taller no puede ser Mayor que la Fecha de Inicio de Trabajo")
            If _FechaIngreso > _FechaFin Then Throw New Exception("La Fecha de Ingreso a Taller no puede ser Mayor que la Fecha de Fin de Trabajo")
            If _FechaInicio > _FechaFin Then Throw New Exception("La Fecha de Inicio de Trabajo no puede ser Mayor que la Fecha de Fin de Trabajo")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub TransponerDetalleEquipoMantenimiento()
        Try
            oeOrdenTrabajo.lstDetalleEquipoMantenimiento.Clear()
            ls_GlosaEquipos = String.Empty
            For Each equiRow As DataRow In dsOT_ME.Tables(0).Rows
                ls_GlosaEquipos &= Environment.NewLine & equiRow("EquipoMantenimiento")
                For Each mantRow As DataRow In equiRow.GetChildRows(relationMantEqui)
                    oeOTEquipoMantenimiento = New e_OrdenTrabajo_MantenimientoEquipo
                    oeOTEquipoMantenimiento.Seleccion = True
                    oeOTEquipoMantenimiento.Id = mantRow("Id")
                    oeOTEquipoMantenimiento.IdOrdenTrabajo = IIf(String.IsNullOrEmpty(oeOrdenTrabajo.Id), "", oeOrdenTrabajo.Id)
                    oeOTEquipoMantenimiento.IdMantenimientoEquipo = mantRow("IdMantenimientoEquipo")
                    oeOTEquipoMantenimiento.IdMantenimiento = ""
                    oeOTEquipoMantenimiento.Mantenimiento = ""
                    oeOTEquipoMantenimiento.TipoMantenimiento = ""
                    oeOTEquipoMantenimiento.IdEquipo = ""
                    oeOTEquipoMantenimiento.Equipo = ""
                    oeOTEquipoMantenimiento.Odometro = equiRow("Odometro")
                    oeOTEquipoMantenimiento.Horometro = equiRow("Horometro")
                    If String.IsNullOrEmpty(equiRow("Responsable").ToString) Then
                        Throw New Exception("Seleccione un Responsable para el Equipo: " & equiRow("EquipoMantenimiento").ToString)
                    End If
                    oeOTEquipoMantenimiento.IdTrabajadorResponsable = equiRow("Responsable")
                    oeOTEquipoMantenimiento.Activo = True
                    oeOrdenTrabajo.lstDetalleEquipoMantenimiento.Add(oeOTEquipoMantenimiento)
                Next
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub TransponerDetalleMaterial()
        Try
            grid_OTMateriales.UpdateData()
            If datoValido Then
                _lsMensajeAtiente = String.Empty
                Dim _leDetMatAux As New List(Of e_OrdenTrabajo_Material)
                leDetalleMatAux = New List(Of e_OrdenTrabajo_Material)
                oeOrdenTrabajo.lstDetalleMaterial.Clear()
                If Not String.IsNullOrEmpty(IdOT) Then
                    oeDetalleMatAux = New e_OrdenTrabajo_Material
                    oeDetalleMatAux.TipoOperacion = ""
                    oeDetalleMatAux.IdOrdenTrabajo = IdOT
                    oeDetalleMatAux.Activo = True
                    leDetalleMatAux = olDetalleMarAux.Listar(oeDetalleMatAux)
                End If

                For Each matRow As DataRow In dsOT_ME_Material.Tables(2).Rows
                    oeOTMaterial = New e_OrdenTrabajo_Material
                    oeOTMaterial.Id = matRow("IdOTM")
                    oeOTMaterial.IdMantenimientoEquipo = matRow("IdMantenimientoEquipo")
                    oeOTMaterial.IdMaterial = matRow("IdMaterial")
                    oeOTMaterial.IdOrdenTrabajo = ""
                    oeOTMaterial.Equipo = IIf(String.IsNullOrEmpty(matRow("Equipo").ToString), "", matRow("Equipo").ToString)
                    oeOTMaterial.Mantenimiento = IIf(String.IsNullOrEmpty(matRow("Mantenimiento").ToString), "", matRow("Mantenimiento").ToString)
                    oeOTMaterial.Material = matRow("MantenimientoMaterial")
                    oeOTMaterial.UsuarioCreacion = oeOrdenTrabajo.UsuarioCreacion
                    oeOTMaterial.IdUnidadMedida = matRow("IdUnidadMedida")
                    oeOTMaterial.CantidadMaterial = matRow("CantidadMaterial")
                    oeOTMaterial.CantidadMaterialEntregada = matRow("CantidadMaterialEntregada")
                    oeOTMaterial.CantidadMaterialDevuelto = matRow("CantidadMaterialDevuelto")

                    If oeOTMaterial.Id <> "" AndAlso oeOTMaterial.CantidadMaterial - oeOTMaterial.CantidadMaterialEntregada > 0 Then
                        _leDetMatAux = leDetalleMatAux.Where(Function(it) it.Id = oeOTMaterial.Id And it.CantidadMaterialEntregada > 0).ToList
                        If _leDetMatAux.Count > 0 Then
                            If oeOTMaterial.CantidadMaterial < _leDetMatAux(0).CantidadMaterialEntregada Then
                                Throw New Exception("Material: " & oeOTMaterial.Material & Environment.NewLine _
                                                    & "La Cantidad Pedida (" & oeOTMaterial.CantidadMaterial & ")" _
                                                    & " no puede ser menor a Cantidad Entregada (" & _leDetMatAux(0).CantidadMaterialEntregada & ")" _
                                                    & Environment.NewLine & "Haga Click en el Boton 'Actualizar' para ver las ultimas atenciones")
                            End If
                            oeOTMaterial.CantidadMaterialEntregada = _leDetMatAux(0).CantidadMaterialEntregada
                            If oeOTMaterial.CantidadMaterialEntregada > matRow("CantidadMaterialEntregada") Then
                                _lsMensajeAtiente = _lsMensajeAtiente & oeOTMaterial.Material & " Cantidad Atendida: " _
                            & oeOTMaterial.CantidadMaterialEntregada - matRow("CantidadMaterialEntregada") & Environment.NewLine
                            End If
                        End If
                    End If

                    Dim _leDel = leDetalleMatAux.Where(Function(it) it.Id = oeOTMaterial.Id And it.CantidadMaterialEntregada > 0).ToList
                    If _leDel.Count > 0 AndAlso oeOTMaterial.CantidadMaterialDevuelto < _leDel(0).CantidadMaterialDevuelto Then
                        oeOTMaterial.CantidadMaterialDevuelto = _leDel(0).CantidadMaterialDevuelto
                    End If

                    oeOTMaterial.Costo = matRow("Costo")
                    oeOTMaterial.IdSubAlmacen = matRow("IdSubAlmacen")
                    oeOTMaterial.IdAlmacen = matRow("IdAlmacen")
                    oeOTMaterial.Activo = True
                    'Modificado EENEBA Fecha: 02/11/2012
                    oeOTMaterial.IdEquipo = IIf(String.IsNullOrEmpty(matRow("IdEquipo").ToString), "", matRow("IdEquipo").ToString)
                    oeOTMaterial.IdMantenimiento = IIf(String.IsNullOrEmpty(matRow("IdMantenimiento").ToString), "", matRow("IdMantenimiento").ToString)
                    oeOTMaterial.CantAux = IIf(String.IsNullOrEmpty(matRow("CantAux").ToString), "", matRow("CantAux").ToString)
                    '-----------------------------------
                    oeOrdenTrabajo.lstDetalleMaterial.Add(oeOTMaterial)
                Next
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub TransponerDetalleServicio()
        oeOrdenTrabajo.lstDetalleServicio.Clear()
        For Each servRow As DataRow In dsOT_ME_Servicio.Tables(2).Rows
            oeOTServicio = New e_OrdenTrabajo_Servicio
            oeOTServicio.Id = servRow("IdOTS")
            oeOTServicio.IdMantenimientoEquipo = servRow("IdMantenimientoEquipo")
            oeOTServicio.IdServicio = servRow("IdServicio")
            oeOTServicio.IdOrdenTrabajo = ""
            oeOTServicio.UsuarioCreacion = oeOrdenTrabajo.UsuarioCreacion
            oeOTServicio.Cantidad = servRow("Cantidad")
            oeOTServicio.Costo = servRow("Costo")
            oeOTServicio.CostoDolares = servRow("CostoDolares")
            oeOTServicio.Activo = True
            oeOrdenTrabajo.lstDetalleServicio.Add(oeOTServicio)
        Next
    End Sub

    Public Sub TransponerDetalleOperarios()
        oeOrdenTrabajo.lstDetalleRecurso.Clear()
        For Each recRow As DataRow In dsOT_ME_Recurso.Tables(3).Rows
            oeOTRecurso = New e_OrdenTrabajo_Recurso
            oeOTRecurso.Id = recRow("IdOTR")
            oeOTRecurso.IdMantenimientoEquipo = recRow("IdMantenimientoEquipo")
            oeOTRecurso.IdOcupacionTrabajador = recRow("IdOcupacionTrabajador")
            oeOTRecurso.IdOrdenTrabajo = ""
            oeOTRecurso.UsuarioCreacion = oeOrdenTrabajo.UsuarioCreacion
            oeOTRecurso.CantidadHoras = recRow("CantidadHoras")
            oeOTRecurso.Activo = True
            'oeOTRecurso.Costo = recRow("Costo")
            oeOrdenTrabajo.lstDetalleRecurso.Add(oeOTRecurso)
        Next
    End Sub

    Public Sub TransponerDetalleActividades()
        oeOrdenTrabajo.lstDetalleActividad.Clear()
        For Each actRow As DataRow In dsOT_ME_Actividad.Tables(2).Rows
            oeOTActividad = New e_OrdenTrabajo_Actividad
            oeOTActividad.Id = actRow("IdOTA")
            oeOTActividad.IdMantenimientoEquipo = actRow("IdMantenimientoEquipo")
            oeOTActividad.IdActividad = actRow("IdActividad")
            oeOTActividad.IdOrdenTrabajo = ""
            oeOTActividad.UsuarioCreacion = oeOrdenTrabajo.UsuarioCreacion
            oeOTActividad.CantidadDias = actRow("CantidadDias")
            oeOTActividad.CantidadHoras = actRow("CantidadHoras")
            oeOTActividad.CantidadMinutos = actRow("CantidadMinutos")
            oeOTActividad.Activo = True
            oeOrdenTrabajo.lstDetalleActividad.Add(oeOTActividad)
        Next
    End Sub

    Public Sub TransponerDetalleMaterialRequerimiento(ls_IdEquipo As String)
        Try
            oeRequerimiento.lstRequerimientoMaterial = New List(Of e_RequerimientoMaterial)
            ls_GlosaOrden = String.Empty
            oeEstadoRequerimiento = New e_EstadoRequerimiento
            oeEstadoRequerimiento.Nombre = "APROBADO"
            oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)
            For Each equiRow As DataRow In dsOT_ME_Material.Tables(0).Rows
                If equiRow("IdEquipo") = ls_IdEquipo Then
                    ls_GlosaOrden = ls_GlosaOrden & equiRow("Equipo")
                    For Each mantRow As DataRow In equiRow.GetChildRows(relationEquMant)
                        ls_GlosaOrden = ls_GlosaOrden & " / " & mantRow("MantenimientoMaterial") & ","
                        For Each matRow As DataRow In mantRow.GetChildRows(relationMantMat)
                            oeRequerimientoMaterial = New e_RequerimientoMaterial()
                            oeRequerimientoMaterial.IdMaterial = matRow("IdMaterial")
                            oeRequerimientoMaterial.IdAlmacen = matRow("IdAlmacen")
                            oeRequerimientoMaterial.IdSubAlmacen = matRow("IdSubAlmacen")
                            oeRequerimientoMaterial.UsuarioCreacion = gUsuarioSGI.Id
                            oeRequerimientoMaterial.IdUnidadMedida = matRow("IdUnidadMedida")
                            oeRequerimientoMaterial.Cantidad = matRow("CantidadMaterial")
                            oeRequerimientoMaterial.Precio = matRow("Costo") * (1 + oeIGV.Porcentaje)
                            oeRequerimientoMaterial.IdCentroCosto = ""
                            oeRequerimientoMaterial.Glosa = ""
                            oeRequerimientoMaterial.IndRegularizado = True
                            oeRequerimientoMaterial.CantidadPorRegularizar = 0
                            oeRequerimientoMaterial.IdEstadoRequerimientoMaterial = oeEstadoRequerimiento.Id
                            oeRequerimientoMaterial.IdMantenimiento = matRow("IdMantenimiento")
                            oeRequerimiento.lstRequerimientoMaterial.Add(oeRequerimientoMaterial)
                        Next
                    Next
                End If
            Next
            If ls_GlosaOrden <> "" Then
                ls_GlosaOrden = ls_GlosaOrden.Substring(0, ls_GlosaOrden.Length - 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub TransponerDetalleServicioRequerimiento(ls_IdEquipo As String)
        Try
            oeRequerimiento.lstRequerimientoServicio = New List(Of e_RequerimientoServicio)
            ls_GlosaOrden = String.Empty
            oeEstadoRequerimiento = New e_EstadoRequerimiento
            oeEstadoRequerimiento.Nombre = "APROBADO"
            oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)
            For Each equiRow As DataRow In dsOT_ME_Servicio.Tables(0).Rows
                If equiRow("IdEquipo") = ls_IdEquipo Then
                    ls_GlosaOrden = ls_GlosaOrden & equiRow("Equipo")
                    For Each mantRow As DataRow In equiRow.GetChildRows(relationEquMant4)
                        ls_GlosaOrden = ls_GlosaOrden & "/" & mantRow("MantenimientoServicio") & ","
                        For Each servRow As DataRow In mantRow.GetChildRows(relationMantServ)
                            oeRequerimientoServicio = New e_RequerimientoServicio()
                            oeRequerimientoServicio.IdServicio = servRow("IdServicio")
                            oeRequerimientoServicio.UsuarioCreacion = gUsuarioSGI.Id
                            oeRequerimientoServicio.Cantidad = servRow("Cantidad")
                            oeRequerimientoServicio.Precio = servRow("Costo")
                            oeRequerimientoServicio.IdCentroCosto = ""
                            oeRequerimientoServicio.IdEmpresaServicio = cboProveedor.Value
                            oeRequerimientoServicio.IdEstadoRequerimientoServicio = oeEstadoRequerimiento.Id
                            oeRequerimiento.lstRequerimientoServicio.Add(oeRequerimientoServicio)
                        Next
                    Next
                End If
            Next
            If ls_GlosaOrden <> "" Then
                ls_GlosaOrden = ls_GlosaOrden.Substring(0, ls_GlosaOrden.Length - 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidaPendientes() As Boolean
        Try
            Dim Var As Double = 0
            Dim Cadena As String = ""
            With grid_OTMateriales
                For i As Integer = 0 To .Rows.Count - 1
                    For Each aChildBand1 As Infragistics.Win.UltraWinGrid.UltraGridChildBand In .Rows(i).ChildBands
                        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In aChildBand1.Rows
                            For Each aChildBand2 As Infragistics.Win.UltraWinGrid.UltraGridChildBand In fila.ChildBands
                                For y As Integer = 0 To aChildBand2.Rows.Count - 1
                                    Var = aChildBand2.Rows(y).Cells("CantidadMaterial").Value - aChildBand2.Rows(y).Cells("CantidadMaterialEntregada").Value
                                    If Var > 0 Then
                                        Cadena = Cadena & aChildBand2.Rows(y).Cells("MantenimientoMaterial").Value & " - " & Var & " unidades" & Environment.NewLine
                                    End If
                                Next
                            Next
                        Next
                    Next
                Next
            End With
            If Cadena <> "" Then
                Throw New Exception("Quedan Pendientes por Atenter: " & Environment.NewLine & Cadena)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub GenerarRequerimientos()
        Try
            Select Case cbe_Tipo.SelectedIndex
                Case 0, 2
                    If dsOT_ME_Material.Tables(2).Rows.Count > 0 Then
                        For Each equiRow As DataRow In dsOT_ME_Material.Tables(0).Rows
                            GenerarRequerimientoMateriales(equiRow("IdEquipo").ToString)
                        Next
                    End If
                Case 1
                    If dsOT_ME_Servicio.Tables(2).Rows.Count > 0 Then
                        For Each equiRow As DataRow In dsOT_ME_Servicio.Tables(0).Rows
                            GenerarRequerimientoServicios(equiRow("IdEquipo").ToString)
                        Next
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GenerarRequerimientoMateriales(ls_IdEquipo As String)
        Try
            oeRequerimiento = New e_Requerimiento
            oeRequerimiento.TipoOperacion = "I"
            oeRequerimiento.TipoReferencia = "ORDEN TRABAJO"
            oeRequerimiento.IdReferencia = oeOrdenTrabajo.Id
            oeRequerimiento.IdEquipo = ls_IdEquipo
            oeRequerimiento.GlosaAtencion = ""
            oeEstadoRequerimiento = New e_EstadoRequerimiento
            oeEstadoRequerimiento.Activo = True
            oeEstadoRequerimiento.Nombre = "EVALUADO"
            oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)

            oeRequerimiento.IdEstadoRequerimiento = oeEstadoRequerimiento.Id
            oeRequerimiento.Activo = True
            oeRequerimiento.MaterialServicio = "M"
            oeRequerimiento.IdArea = "" 'oeArea.Id
            oeRequerimiento.UsuarioCreacion = gUsuarioSGI.Id
            oeRequerimiento.FechaAtencion = Date.Now
            TransponerDetalleMaterialRequerimiento(ls_IdEquipo)
            oeRequerimiento.Descripcion = ls_GlosaOrden
            oeRequerimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            olRequerimiento.Guardar(oeRequerimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GenerarRequerimientoServicios(ls_IdEquipo As String)
        Try
            oeRequerimiento = New e_Requerimiento
            oeRequerimiento.TipoOperacion = "I"
            oeRequerimiento.TipoReferencia = "ORDEN TRABAJO"
            oeRequerimiento.IdReferencia = oeOrdenTrabajo.Id
            oeRequerimiento.IdEquipo = ls_IdEquipo
            oeRequerimiento.GlosaAtencion = ""
            oeEstadoRequerimiento = New e_EstadoRequerimiento
            oeEstadoRequerimiento.Activo = True
            oeEstadoRequerimiento.Nombre = "EVALUADO"
            oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)

            oeRequerimiento.IdEstadoRequerimiento = oeEstadoRequerimiento.Id
            oeRequerimiento.Activo = True
            oeRequerimiento.MaterialServicio = "S"
            oeRequerimiento.IdArea = oeArea.Id
            oeRequerimiento.UsuarioCreacion = gUsuarioSGI.Id
            oeRequerimiento.FechaAtencion = Date.Now
            TransponerDetalleServicioRequerimiento(ls_IdEquipo)
            oeRequerimiento.Descripcion = ls_GlosaOrden
            oeRequerimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            olRequerimiento.Guardar(oeRequerimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub EnviarCorreo(ls_Msg As String)
        Try
            Dim correoTrabajador As String = "", correoProveedor As String = ""
            Dim formulario As frm_EnvioCorreo

            oeProveedor = New e_Proveedor
            oeProveedor.TipoOperacion = "2"
            oeProveedor.Id = oeOrdenTrabajo.IdEmpresaExterna
            oeProveedor = olProveedor.Obtener(oeProveedor)

            If oeProveedor.leEmail.Count > 0 Then correoProveedor = oeProveedor.leEmail.Item(0).Nombre
            If gUsuarioSGI.oePersona.leEmail.Count > 0 Then correoTrabajador = gUsuarioSGI.oePersona.leEmail.Item(0).Nombre

            formulario = frm_EnvioCorreo
            formulario.ObtenerDatos("", "", correoTrabajador, True, True, True, True, correoProveedor, ls_Msg)
            formulario.StartPosition = FormStartPosition.CenterScreen
            formulario.ShowDialog()
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
            formulario = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub VerificaCotizacion()
        Try
            Dim oeOCOT As New e_OrdenCmp_OrdenTrb
            Dim olOCOT As New l_OrdenCmp_OrdenTrb
            oeOrdenTrabajo.oeOCOT = New e_OrdenCmp_OrdenTrb
            oeOCOT.TipoOperacion = "1"
            oeOCOT.IdOrdenTrabajo = oeOrdenTrabajo.Id
            oeOCOT = olOCOT.Obtener(oeOCOT)
            If oeOCOT.Id <> "" Then
                oeOrdenTrabajo.oeOCOT = oeOCOT
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ObtenerValorUnitario(idMaterial As String, idSubAlmacen As String) As String
        Try
            oeInventario = New e_Inventario
            oeInventario.ValorUnitario = 0.0
            oeInventario.TipoOperacion = 1
            oeInventario.IdMaterial = idMaterial
            oeInventario.IdSubAlmacen = idSubAlmacen
            oeInventario = olInventario.Obtener(oeInventario)
            Return oeInventario.ValorUnitario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub IniciarOT(ls_IdOT As String)
        Try
            IdOT = ls_IdOT
            Editar()
            oeEstadoOT = New e_EstadoOT
            oeEstadoOT.Activo = True
            oeEstadoOT.Nombre = "EN PROCESO"
            oeEstadoOT = olEstadoOT.Obtener(oeEstadoOT)
            oeOrdenTrabajo.IdEstadoOT = oeEstadoOT.Id
            oeOrdenTrabajo.EstadoOT = oeEstadoOT.Nombre
            oeOrdenTrabajo.TipoOperacion = "S"
            FormatearGrillaMateriales()
            lbl_etiqueta.Visible = True
            lbl_etiqueta.Text = "INICIANDO OT"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub TerminarOT(ByVal ls_IdOT As String)
        Try
            IdOT = ls_IdOT
            Editar()
            oeEstadoOT = New e_EstadoOT
            oeEstadoOT.Activo = True
            oeEstadoOT.Nombre = "TERMINADA"
            oeEstadoOT = olEstadoOT.Obtener(oeEstadoOT)
            oeOrdenTrabajo.IdEstadoOT = oeEstadoOT.Id
            oeOrdenTrabajo.EstadoOT = oeEstadoOT.Nombre
            oeOrdenTrabajo.TipoOperacion = "F"
            FormatearGrillaMateriales()
            lbl_etiqueta.Visible = True
            lbl_etiqueta.Text = "TERMINANDO OT"
            'datoValido = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LiberarUnidad(ByVal ls_IdOT As String)
        Try
            oeEstadoOT = New e_EstadoOT
            oeEstadoOT.Activo = True
            oeEstadoOT.Nombre = "LIBERADA"
            oeEstadoOT = olEstadoOT.Obtener(oeEstadoOT)

            oeOrdenTrabajo = New e_OrdenTrabajo
            oeOrdenTrabajo.Id = ls_IdOT
            oeOrdenTrabajo.IdEstadoOT = oeEstadoOT.Id
            oeOrdenTrabajo.EstadoOT = oeEstadoOT.Nombre
            oeOrdenTrabajo.TipoOperacion = "C"
            olOrdenTrabajo.ActualizaEstadoOT(oeOrdenTrabajo)
            mensajeEmergente.Confirmacion("La Orden de Trabajo, fue liberada satisfactoriamente")
            ListarOrdenesTrabajo()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguarOTMack()
        Try
            With grid_Equipos.DisplayLayout.Bands(0)
                .ColumnFilters.ClearAllFilters()
                If Not String.IsNullOrEmpty(oeCombo.Nombre) Then
                    .ColumnFilters.LogicalOperator = Infragistics.Win.UltraWinGrid.FilterLogicalOperator.Or
                    .ColumnFilters("IdMarca").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, oeCombo.Nombre)
                Else
                    .ColumnFilters.ClearAllFilters()
                    For x As Integer = 0 To grid_Equipos.Rows.Count - 1
                        Me.grid_Equipos.Rows(x).CollapseAll()
                    Next
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub ListarOperarios()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeOcupacionTrabajador = New e_OcupacionTrabajador
            oeOcupacionTrabajador.TipoOperacion = ""
            oeOcupacionTrabajador.Activo = True
            oeOcupacionTrabajador.Principal = 1
            oeOcupacionTrabajador.IdOcupacion = IIf(cboOcupacionBus.Value = "CERO", "", cboOcupacionBus.Value)
            lstTrabajadores = olOcupacionTrabajador.Listar(oeOcupacionTrabajador).OrderBy(Function(i) i.Trabajador).ToList
            grid_Operarios.DataSource = lstTrabajadores
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

End Class