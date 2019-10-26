'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Shared
Imports System.Drawing.Graphics
Imports Infragistics.Win.UltraWinGrid.UltraGridAction

Public Class frm_AsistenteOT
    Public mensajeEmergente As New c_Alertas


#Region "Declaracion de variables"
    Dim _IdOT As String
    Dim olArea As New l_Area, oeArea As New e_Area
    Dim oeOrdenTrabajo As New e_OrdenTrabajo, olOrdenTrabajo As New l_OrdenTrabajo
    Dim oeEstadoOT As New e_EstadoOT, olEstadoOT As New l_EstadoOT
    Dim oeTipoMantenimiento As New e_TipoMantenimiento, olTipoMantenimiento As New l_TipoMantenimiento
    Dim oeMantenimientoEquipo As New e_MantenimientoEquipo, olMantenimientoEquipo As New l_MantenimientoEquipo
    Dim oeMantenimientoMaterial As New e_MantenimientoMaterial, olMantenimientoMaterial As New l_MantenimientoMaterial
    Dim oeMantenimientoServicio As New e_MantenimientoServicio, olMantenimientoServicio As New l_MantenimientoServicio
    Dim oeMantenimientoActividad As New e_MantenimientoActividad, olMantenimientoActividad As New l_MantenimientoActividad
    Dim oeMantenimientoOcupacion As New e_MantenimientoOcupacion, olMantenimientoOcupacion As New l_MantenimientoOcupacion
    Dim oeViaje As New e_Viaje
    Dim oeOperacion As New e_Operacion, olOperacion As New l_Operacion
    Dim lstEquipoMantenimiento As New List(Of e_MantenimientoEquipo)
    Dim lstMantenimientoMaterial As New List(Of e_MantenimientoMaterial)
    Dim lstMantenimientoServicio As New List(Of e_MantenimientoServicio)
    Dim lstMantenimientoActividad As New List(Of e_MantenimientoActividad)
    Dim lstMantenimientoOcupacion As New List(Of e_MantenimientoOcupacion)
    Dim lstTipoMantenimiento As New List(Of e_TipoMantenimiento)
    Dim oeMaterialAlmacen As New e_MaterialAlmacen, olMaterialAlmacen As New l_MaterialAlmacen
    Dim oeSubAlmacen As New e_SubAlmacen, olSubAlmacen As New l_SubAlmacen
    Dim oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador
    Dim oeVehiculo As New e_Vehiculo, olVehiculo As New l_Vehiculo
    Dim oeEquipo As New e_Equipo, olEquipo As New l_Equipo
    Dim oeUnidadMedida As New e_UnidadMedida, olUnidadMedida As New l_UnidadMedida

    Dim dsOT_ME As DataSet
    Dim dsOT_ME_Material As DataSet
    Dim dsOT_ME_Servicio As DataSet
    Dim dsOT_ME_Actividad As DataSet
    Dim dsOT_ME_Recurso As DataSet
    Dim dsOTAnteriores As New DataSet
    Dim relationMantEqui As DataRelation

    Dim relationEquMant As DataRelation
    Dim relationMantMat As DataRelation
    Dim relationEquMant2 As DataRelation ' relacion equipo mantenimiento para el dataset de actividades
    Dim relationEquMant3 As DataRelation ' relacion equipo mantenimiento para el dataset de recursos
    Dim relationEquMant4 As DataRelation ' relacion equipo mantenimiento para el dataset de servicios
    Dim relationMantServ As DataRelation
    Dim relationMantAct As DataRelation
    Dim relationMantOcup As DataRelation
    Dim relationOcupTrab As DataRelation

    Dim oeOTEquipoMantenimiento As New e_OrdenTrabajo_MantenimientoEquipo, olOTEquipoMantenimiento As New l_OrdenTrabajo_MantenimientoEquipo
    Dim oeOTMaterial As New e_OrdenTrabajo_Material, olOTMaterial As New l_OrdenTrabajo_Material
    Dim oeOTServicio As New e_OrdenTrabajo_Servicio, olOTServicio As New l_OrdenTrabajo_Servicio
    Dim oeOTActividad As New e_OrdenTrabajo_Actividad, olOTActividad As New l_OrdenTrabajo_Actividad
    Dim oeOTRecurso As New e_OrdenTrabajo_Recurso, olOTRecurso As New l_OrdenTrabajo_Recurso
    Dim oeOcupacionTrabajador As New e_OcupacionTrabajador, olOcupacionTrabajador As New l_OcupacionTrabajador
    Dim oeMaterial As New e_Material, olMaterial As New l_Material
    Dim oeServicio As New e_Servicio, olServicio As New l_Servicio
    Dim oeOcupacion As New e_Ocupacion, olOcupacion As New l_Ocupacion
    Dim oeActividad As New e_Actividad, olActividad As New l_Actividad
    Dim lstMateriales As New List(Of e_Material)
    Dim lstServicios As New List(Of e_Servicio)
    Dim lstActividades As New List(Of e_Actividad)
    Dim lstOcupaciones As New List(Of e_Ocupacion)
    Dim lstTrabajadores As New List(Of e_OcupacionTrabajador)
    Dim oeCategoriaServicio As New e_CategoriaServicio, olCategoriaServicio As New l_CategoriaServicio
    Dim lstCategoriasServicio As New List(Of e_CategoriaServicio)
    Dim lstResponsables As New List(Of e_Trabajador)
    Dim oeProveedor As New e_Proveedor, olProveedor As New l_Proveedor

    Dim oeRequerimiento As New e_Requerimiento, olRequerimiento As New l_Requerimiento
    Dim oeEstadoRequerimiento As New e_EstadoRequerimiento, olEstadoRequerimiento As New l_EstadoRequerimiento
    Dim oeRequerimientoMaterial As New e_RequerimientoMaterial
    Dim oeRequerimientoServicio As New e_RequerimientoServicio
    Dim ls_GlosaOrden As String = ""
    Dim ch As Integer = 0, cd As Integer = 0, cm As Integer = 0
    Dim _TipoCambio As Double = 0
#End Region

#Region "Metodos y Funciones"

    Public Sub LlenaComboJefeTaller()
        Try
            oeTrabajador = New e_Trabajador
            oeTrabajador.Activo = True
            oeTrabajador.TipoOperacion = ""
            oeTrabajador.oeCargo.Id = "1CH005"
            Dim _leTrabJTAux = olTrabajador.Listar(oeTrabajador)
            Dim _leTrabJT = From le In _leTrabJTAux _
                            Select le.Id, le.oePersona.NombreCompleto
            LlenarComboMaestro(cmbJefeTaller, _leTrabJT.ToList, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboJefeFlota()
        Try
            oeTrabajador = New e_Trabajador
            oeTrabajador.Activo = True
            oeTrabajador.TipoOperacion = ""
            oeTrabajador.oeCargo.Id = "1CH004"
            Dim _leTrabJFAux = olTrabajador.Listar(oeTrabajador)
            Dim _leTrabJF = From le In _leTrabJFAux _
                            Select le.Id, le.oePersona.NombreCompleto
            LlenarComboMaestro(cmbSupervisorMant, _leTrabJFAux.ToList, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LlenaCombos()
        LlenaComboJefeTaller()
        LlenaComboJefeFlota()
        LlenaComboEmpresaExterna()
        'LlenaComboCategoriaServicios()
        LlenaComboOcupaciones()
    End Sub

    Private Sub AgregarEquiposMantenimiento()
        Try
            Dim _cant As Integer = 0, cont As Integer = 0

            For Each oeMantenimientoEquipo As e_MantenimientoEquipo In lstEquipoMantenimiento.Where(Function(Item) Item.Seleccion)
                For Each mantRow As Data.DataRow In dsOT_ME.Tables(1).Rows
                    If oeMantenimientoEquipo.Id = mantRow("IdMantenimientoEquipo").ToString Then
                        oeMantenimientoEquipo.Seleccion = False
                    End If
                Next

                If Me.optIndicadorTipo.CheckedIndex = 0 Then
                    '    If RetornaEstadoUltimoViaje(oeMantenimientoEquipo.IdVehiculo) Then
                    '        oeMantenimientoEquipo.Seleccion = False
                    '        Exit For
                    '    End If
                    If ValidarExistenciaOTAbierta(oeMantenimientoEquipo.IdEquipo) Then
                        oeMantenimientoEquipo.Seleccion = False
                        Exit For
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
                    CargarActividadesMantenimiento(oeMantenimientoEquipo.Id, oeMantenimientoEquipo.IdEquipo, oeMantenimientoEquipo.Equipo, _
                                                oeMantenimientoEquipo.IdMantenimiento, oeMantenimientoEquipo.Mantenimiento)
                    CargarRecursosMantenimiento(oeMantenimientoEquipo.Id, oeMantenimientoEquipo.IdEquipo, oeMantenimientoEquipo.Equipo, _
                                                oeMantenimientoEquipo.IdMantenimiento, oeMantenimientoEquipo.Mantenimiento)
                    CargarServiciosMantenimiento(oeMantenimientoEquipo.Id, oeMantenimientoEquipo.IdEquipo, oeMantenimientoEquipo.Equipo, _
                                                oeMantenimientoEquipo.IdMantenimiento, oeMantenimientoEquipo.Mantenimiento)
                    _cant += 1

                End If
                oeMantenimientoEquipo.Seleccion = False
            Next

            If _cant > 0 Then
                grid_Equipos.DataBind()
                grid_OT_ME.DataBind()

                With grid_OT_ME.DisplayLayout
                    ResponsableValueList(grid_OT_ME)
                    .Bands(0).Columns("Responsable").ValueList = .ValueLists("Responsables")
                End With
                gbeOTsAnteriores.Expanded = False
            End If

            For x As Integer = 0 To grid_OT_ME.Rows.Count - 1
                Me.grid_OT_ME.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ResponsableValueList(ByVal stGrilla As UltraWinGrid.UltraGrid)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            stGrilla.DisplayLayout.ValueLists.Clear()
            objValueList = stGrilla.DisplayLayout.ValueLists.Add("Responsables")

            oeTrabajador = New e_Trabajador()
            oeTrabajador.Activo = True
            lstResponsables = olTrabajador.Listar(oeTrabajador)
            For Each item As e_Trabajador In lstResponsables
                objValueList.ValueListItems.Add(item.Id, item.oePersona.NombreCompleto)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarEquiposMantenimientoOT(ByVal ls_IdOrdenTrabajo As String)
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
            With grid_OT_ME.DisplayLayout
                .Bands(1).ColHeadersVisible = False
                .Bands(1).Columns("Id").Hidden = True
                .Bands(1).Columns("Seleccion").Width = 30
                .Bands(1).Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Bands(1).Columns("IdEquipo").Hidden = True
                .Bands(1).Columns("IdOrdenTrabajo").Hidden = True
                .Bands(1).Columns("IdMantenimientoEquipo").Hidden = True
                .Bands(1).Columns("EquipoMantenimiento").Width = 280
                .Bands(0).Columns("EquipoMantenimiento").Width = 280
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

    Public Sub ListarEquiposMantenimiento()
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeMantenimientoEquipo = New e_MantenimientoEquipo
            oeMantenimientoEquipo.TipoOperacion = "L"
            oeMantenimientoEquipo.Activo = True
            lstEquipoMantenimiento = olMantenimientoEquipo.Listar(oeMantenimientoEquipo)
            grid_Equipos.DataSource = lstEquipoMantenimiento
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
        grid_Equipos.Focus()
    End Sub

    Private Sub CargarMantenimientoMaterial()
        Try
            Dim _cant As Integer = 0, cont As Integer = 0

            For Each oeMantenimientoEquipo As e_MantenimientoEquipo In lstEquipoMantenimiento.Where(Function(item) item.Seleccion)
                CargarMaterialMantenimiento(oeMantenimientoEquipo.Id, oeMantenimientoEquipo.IdEquipo, oeMantenimientoEquipo.Equipo, _
                                            oeMantenimientoEquipo.IdMantenimiento, oeMantenimientoEquipo.Mantenimiento)
                CargarServiciosMantenimiento(oeMantenimientoEquipo.Id, oeMantenimientoEquipo.IdEquipo, oeMantenimientoEquipo.Equipo, _
                                           oeMantenimientoEquipo.IdMantenimiento, oeMantenimientoEquipo.Mantenimiento)
                CargarRecursosMantenimiento(oeMantenimientoEquipo.Id, oeMantenimientoEquipo.IdEquipo, oeMantenimientoEquipo.Equipo, _
                                           oeMantenimientoEquipo.IdMantenimiento, oeMantenimientoEquipo.Mantenimiento)
                CargarActividadesMantenimiento(oeMantenimientoEquipo.Id, oeMantenimientoEquipo.IdEquipo, oeMantenimientoEquipo.Equipo, _
                                           oeMantenimientoEquipo.IdMantenimiento, oeMantenimientoEquipo.Mantenimiento)

                _cant += 1
                oeMantenimientoEquipo.Seleccion = False
            Next

            If _cant > 0 Then
                'grid_Equipos.DataBind()
                'gbeEquipos.Expanded = False
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarMaterialMantenimiento(ByVal ls_IdMantenimientoEquipo As String, ByVal ls_IdEquipo As String, ByVal ls_Equipo As String, _
                                           ByVal ls_IdMantenimiento As String, ByVal ls_Mantenimiento As String)

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
            rowMantemimiento("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo
            rowMantemimiento("IdEquipo") = ls_IdEquipo
            rowMantemimiento("IdMantenimiento") = ls_IdMantenimiento
            rowMantemimiento("MantenimientoMaterial") = ls_Mantenimiento
            rowMantemimiento("CantidadMaterial") = ""
            rowMantemimiento("CantidadMaterialEntregada") = ""
            rowMantemimiento("CantidadMaterialDevuelto") = ""
            rowMantemimiento("CantidadPendiente") = ""
            dsOT_ME_Material.Tables(1).Rows.Add(rowMantemimiento)
            dsOT_ME_Material.Tables(1).AcceptChanges()

            oeMantenimientoMaterial = New e_MantenimientoMaterial
            oeMantenimientoMaterial.TipoOperacion = "L"
            oeMantenimientoMaterial.Activo = True
            oeMantenimientoMaterial.IdMantenimiento = ls_IdMantenimiento
            lstMantenimientoMaterial = olMantenimientoMaterial.Listar(oeMantenimientoMaterial)
            For Each oeMantenimientoMaterial As e_MantenimientoMaterial In lstMantenimientoMaterial
                Dim rowMaterial As DataRow
                rowMaterial = dsOT_ME_Material.Tables(2).NewRow
                rowMaterial("Seleccion") = False
                rowMaterial("IdOTM") = ""
                rowMaterial("IdMantenimiento") = oeMantenimientoMaterial.IdMantenimiento
                rowMaterial("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo
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
                    For Each aChildBand1 As UltraGridChildBand In .Rows(i).ChildBands
                        For Each fila As UltraGridRow In aChildBand1.Rows
                            For Each aChildBand2 As UltraGridChildBand In fila.ChildBands
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

    Private Sub AlmacenValueList(ByVal ls_IdMaterial As String)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            Me.grid_OTMateriales.DisplayLayout.ValueLists.Clear()
            objValueList = Me.grid_OTMateriales.DisplayLayout.ValueLists.Add("Almacenes")

            oeMaterialAlmacen = New e_MaterialAlmacen
            oeMaterialAlmacen.TipoOperacion = "4"
            oeMaterialAlmacen.Activo = True
            oeMaterialAlmacen.IdMaterial = ls_IdMaterial
            Dim dt As DataTable = olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen)
            For i As Integer = 0 To dt.Rows.Count - 1
                objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SubAlmacenValueList(ByVal ls_IdAlmacen As String)
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
            For Each item As e_SubAlmacen In lstSubAlmacen
                objValueList.ValueListItems.Add(item.Id, item.Descripcion)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub UnidadMedidaValueList(ByVal ls_IdTipoUnidadMedida As String, ByVal stGrilla As UltraWinGrid.UltraGrid)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            stGrilla.DisplayLayout.ValueLists.Clear()
            objValueList = stGrilla.DisplayLayout.ValueLists.Add("Medidas")

            oeUnidadMedida = New e_UnidadMedida()
            oeUnidadMedida.Activo = True
            oeUnidadMedida.Nombre = ""
            oeUnidadMedida.IdTipoUnidadMedida = ls_IdTipoUnidadMedida
            Dim dt As DataTable = olUnidadMedida.ComboGrilla(oeUnidadMedida)
            For i As Integer = 0 To dt.Rows.Count - 1
                objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarServiciosOT(ByVal ls_IdOrdenTrabajo As String)
        Try
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) Equipo
            'Tabla(1) Mantenimiento
            'Tabla(2) Servicio
            ''''''''''''''''''''''''''''''''''''''''''''''
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
            End With
            With grid_OTServicios.DisplayLayout.Bands(1)
                .ColHeadersVisible = False
                .Columns("IdOTME").Hidden = True
                .Columns("Seleccion").CellClickAction = CellClickAction.Edit
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
                .Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Columns("Seleccion").Width = 30
                .Columns("IdServicio").Hidden = True
                .Columns("IdMantenimiento").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("Cantidad").Width = 80
                .Columns("Cantidad").Style = ColumnStyle.DoublePositiveWithSpin
                .Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
                .Columns("Cantidad").CellClickAction = CellClickAction.EditAndSelectText
                .Columns("Costo").Width = 80
                .Columns("Costo").CellAppearance.TextHAlign = HAlign.Right
                .Columns("Costo").CellClickAction = CellClickAction.EditAndSelectText
                .Columns("Costo").MaskInput = "{double:9.2}"
                .Columns("CostoDolares").Width = 80
                .Columns("CostoDolares").CellAppearance.TextHAlign = HAlign.Right
                .Columns("CostoDolares").CellClickAction = CellClickAction.EditAndSelectText
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

    Public Sub ListarMaterialesOT(ByVal ls_IdOrdenTrabajo As String)
        Try
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) Equipo
            'Tabla(1) Mantenimiento
            'Tabla(2) Material
            ''''''''''''''''''''''''''''''''''''''''''''''
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
                .Columns("CantidadMaterial").Width = 60
                .Columns("CantidadMaterialEntregada").Hidden = True
                .Columns("CantidadMaterialEntregada").Width = 80
                .Columns("CantidadMaterialDevuelto").Hidden = True
                .Columns("CantidadMaterialDevuelto").Width = 80
                .Columns("CantidadPendiente").Hidden = True
                .Columns("CantidadPendiente").Width = 80
                .Columns("Costo").Width = 60
                .Columns("Stock").Width = 60
                .Columns("IdUnidadMedida").Header.Caption = "Unidad Medida"
                .Columns("IdUnidadMedida").Width = 100
                .Columns("IdAlmacen").Header.Caption = "Almacen"
                .Columns("IdAlmacen").Width = 200
            End With
            With grid_OTMateriales.DisplayLayout.Bands(1)
                .ColHeadersVisible = False
                .Columns("IdOTME").Hidden = True
                .Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Columns("Seleccion").Width = 30
                .Columns("IdEquipo").Hidden = True
                .Columns("IdMantenimiento").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("CantidadMaterial").Width = 60
                .Columns("CantidadMaterialEntregada").Hidden = True
                .Columns("CantidadMaterialEntregada").Width = 80
                .Columns("CantidadMaterialDevuelto").Hidden = True
                .Columns("CantidadMaterialDevuelto").Width = 80
                .Columns("CantidadPendiente").Hidden = True
                .Columns("CantidadPendiente").Width = 80
                .Columns("Stock").Width = 60
                .Columns("IdUnidadMedida").Width = 100
                .Columns("Costo").Width = 60
            End With
            With grid_OTMateriales.DisplayLayout.Bands(2)
                .ColHeadersVisible = False
                .Columns("IdOTM").Hidden = True
                .Columns("Seleccion").CellClickAction = CellClickAction.EditAndSelectText
                .Columns("Seleccion").Width = 30
                .Columns("IdMaterial").Hidden = True
                .Columns("IdMantenimiento").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("IdTipoUnidadMedida").Hidden = True
                .Columns("CantidadMaterial").Width = 60
                .Columns("CantidadMaterial").MaskInput = "{double:9.2}"
                .Columns("CantidadMaterial").CellAppearance.TextHAlign = HAlign.Right
                .Columns("CantidadMaterial").CellClickAction = CellClickAction.EditAndSelectText
                .Columns("CantidadMaterialEntregada").Hidden = True
                .Columns("CantidadMaterialEntregada").Width = 80
                .Columns("CantidadMaterialEntregada").CellAppearance.TextHAlign = HAlign.Right
                .Columns("CantidadMaterialDevuelto").Hidden = True
                .Columns("CantidadMaterialDevuelto").Width = 80
                .Columns("CantidadMaterialDevuelto").CellAppearance.TextHAlign = HAlign.Right
                .Columns("CantidadPendiente").Hidden = True
                .Columns("CantidadPendiente").Width = 80
                .Columns("CantidadPendiente").CellAppearance.TextHAlign = HAlign.Right
                .Columns("Costo").Width = 60
                .Columns("Costo").Style = ColumnStyle.DoublePositive
                .Columns("Costo").CellAppearance.TextHAlign = HAlign.Right
                .Columns("Costo").CellClickAction = CellClickAction.Edit
                .Columns("Stock").Width = 60
                .Columns("Stock").Style = ColumnStyle.DoublePositive
                .Columns("Stock").CellAppearance.TextHAlign = HAlign.Right
                .Columns("IdUnidadMedida").Width = 100
                .Columns("IdAlmacen").Width = 200
                .Columns("IdSubAlmacen").Hidden = True
            End With

            With grid_OTMateriales
                For i As Integer = 0 To .Rows.Count - 1
                    For Each aChildBand1 As UltraGridChildBand In .Rows(i).ChildBands
                        For Each fila As UltraGridRow In aChildBand1.Rows
                            For Each aChildBand2 As UltraGridChildBand In fila.ChildBands
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

            End With

            For x As Integer = 0 To grid_OTMateriales.Rows.Count - 1
                Me.grid_OTMateriales.Rows(x).ExpandAll()
            Next

        Catch ex As Exception
            Throw ex
        Finally
            grid_OTMateriales.Focus()
        End Try
    End Sub

    Public Sub ListarMateriales()
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Me.txtBuscarMateriales.Text = LTrim(Me.txtBuscarMateriales.Text)
            oeMaterial.Nombre = txtBuscarMateriales.Text
            If Not String.IsNullOrEmpty(Trim(oeMaterial.Nombre)) Then
                oeMaterial.TipoOperacion = "7"
                oeMaterial.Activo = True
                oeMaterial.IdCentro = ""
                lstMateriales = olMaterial.Listar_(oeMaterial)
                grid_Materiales.DataSource = lstMateriales
                grid_Materiales.DataBind()
                oeMaterial = New e_Material
            End If
        Catch ex As Exception
            Throw ex
        Finally
            grid_Materiales.Focus()
        End Try
    End Sub

    Private Function ValidarExistenciaMaterialMatenimiento(ByVal ls_IdMaterial As String, ByVal ls_Material As String, ByVal ls_IdMantenimiento As String) As Boolean
        Try
            For Each matRow As DataRow In dsOT_ME_Material.Tables(2).Rows
                If matRow("IdMaterial") = ls_IdMaterial AndAlso matRow("IdMantenimiento") = ls_IdMantenimiento Then
                    MessageBox.Show("Ya se agrego anteriormente el material: " & ls_Material & " al mantenimiento seleccionado")
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregarMaterialEquipoMantenimiento()
        Try
            If grid_OTMateriales.ActiveRow.Band.Index = 1 Then
                Dim _cant As Integer = 0
                For Each oeMaterial As e_Material In lstMateriales.Where(Function(item) item.Seleccion)
                    If ValidarExistenciaMaterialMatenimiento(oeMaterial.Id, oeMaterial.Nombre, grid_OTMateriales.ActiveRow.Cells("IdMantenimiento").Value) Then Exit For
                    Dim rowMaterial As DataRow
                    rowMaterial = dsOT_ME_Material.Tables(2).NewRow
                    rowMaterial("Seleccion") = False
                    rowMaterial("IdOTM") = ""
                    rowMaterial("IdMantenimiento") = grid_OTMateriales.ActiveRow.Cells("IdMantenimiento").Value
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
                            For Each aChildBand1 As UltraGridChildBand In .Rows(i).ChildBands
                                For Each fila As UltraGridRow In aChildBand1.Rows
                                    For Each aChildBand2 As UltraGridChildBand In fila.ChildBands
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
                    'gbeMateriales.Expanded = False
                End If

                For x As Integer = 0 To grid_OTMateriales.Rows.Count - 1
                    Me.grid_OTMateriales.Rows(x).ExpandAll()
                Next
            Else
                Throw New Exception("Seleccione un mantenimiento para agregar material")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    'Public Sub LlenaComboCategoriaServicios()
    '    Try
    '        oeCategoriaServicio.Id = "CERO" : oeCategoriaServicio.Nombre = "TODOS"
    '        lstCategoriasServicio.Add(oeCategoriaServicio)
    '        oeCategoriaServicio = New e_CategoriaServicio
    '        oeCategoriaServicio.Activo = True
    '        lstCategoriasServicio.AddRange(olCategoriaServicio.Listar(oeCategoriaServicio))
    '        LlenarComboMaestro(cmbCategoriaServicios, lstCategoriasServicio, 0)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub CargarServiciosMantenimiento(ByVal ls_IdMantenimientoEquipo As String, ByVal ls_IdEquipo As String, ByVal ls_Equipo As String, _
                                      ByVal ls_IdMantenimiento As String, ByVal ls_Mantenimiento As String)

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
            rowMantemimiento("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo
            rowMantemimiento("IdEquipo") = ls_IdEquipo
            rowMantemimiento("IdMantenimiento") = ls_IdMantenimiento
            rowMantemimiento("MantenimientoServicio") = ls_Mantenimiento
            rowMantemimiento("Cantidad") = ""
            rowMantemimiento("Costo") = ""
            dsOT_ME_Servicio.Tables(1).Rows.Add(rowMantemimiento)
            dsOT_ME_Servicio.Tables(1).AcceptChanges()

            'oeMantenimientoServicio = New e_MantenimientoServicio
            'oeMantenimientoServicio.TipoOperacion = "L"
            'oeMantenimientoServicio.Activo = True
            'oeMantenimientoServicio.IdMantenimiento = ls_IdMantenimiento
            'lstMantenimientoServicio = olMantenimientoServicio.Listar(oeMantenimientoServicio)
            'For Each oeMantenimientoServicio As e_MantenimientoServicio In lstMantenimientoServicio
            '    Dim rowServicio As DataRow
            '    rowServicio = dsOT_ME_Servicio.Tables(2).NewRow
            '    rowServicio("Seleccion") = False
            '    rowServicio("IdOTS") = ""
            '    rowServicio("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo
            '    rowServicio("IdServicio") = oeMantenimientoServicio.IdServicio
            '    rowServicio("MantenimientoServicio") = oeMantenimientoServicio.Servicio
            '    rowServicio("Cantidad") = oeMantenimientoServicio.Cantidad
            '    rowServicio("Costo") = oeMantenimientoServicio.Costo
            '    dsOT_ME_Servicio.Tables(2).Rows.Add(rowServicio)
            'Next
            'dsOT_ME_Servicio.Tables(2).AcceptChanges()
            grid_OTServicios.DataBind()

            For x As Integer = 0 To grid_OTServicios.Rows.Count - 1
                Me.grid_OTServicios.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub AgregarServicioEquipoMantenimiento()
        Try
            If grid_OTServicios.ActiveRow.Band.Index = 1 Then
                Dim _cant As Integer = 0
                For Each objServicio As e_MantenimientoServicio In lstMantenimientoServicio.Where(Function(item) item.Seleccion)
                    Dim rowServicio As DataRow
                    rowServicio = dsOT_ME_Servicio.Tables(2).NewRow
                    rowServicio("Seleccion") = False
                    rowServicio("IdOTS") = ""
                    rowServicio("IdMantenimiento") = grid_OTServicios.ActiveRow.Cells("IdMantenimiento").Value
                    rowServicio("IdMantenimientoEquipo") = grid_OTServicios.ActiveRow.Cells("IdMantenimientoEquipo").Value
                    rowServicio("IdServicio") = objServicio.IdServicio
                    rowServicio("MantenimientoServicio") = objServicio.Servicio
                    rowServicio("Cantidad") = 1
                    rowServicio("Costo") = 0 'objServicio.Precio
                    rowServicio("CostoDolares") = 0

                    dsOT_ME_Servicio.Tables(2).Rows.Add(rowServicio)
                    dsOT_ME_Servicio.Tables(2).AcceptChanges()
                    objServicio.Seleccion = False
                    _cant = _cant + 1
                Next

                If _cant > 0 Then
                    grid_Servicios.DataBind()
                    grid_OTServicios.DataBind()
                End If

                For x As Integer = 0 To grid_OTServicios.Rows.Count - 1
                    Me.grid_OTServicios.Rows(x).ExpandAll()
                Next

            Else
                Throw New Exception("Seleccione un mantenimiento para agregar material")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub LlenaComboOcupaciones()
        Try
            oeOcupacion.Id = "CERO" : oeOcupacion.Nombre = "TODOS"
            lstOcupaciones.Add(oeOcupacion)
            oeOcupacion = New e_Ocupacion
            oeOcupacion.Activo = True
            lstOcupaciones.AddRange(olOcupacion.Listar(oeOcupacion))
            LlenarComboMaestro(cmbOcupaciones, lstOcupaciones, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarRecursosOT(ByVal ls_IdOrdenTrabajo As String)
        Try
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) Equipo
            'Tabla(1) Mantenimiento
            'Tabla(2) Ocupacion
            'Tabla(3) Trabajador
            ''''''''''''''''''''''''''''''''''''''''''''''
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
                .Columns("Seleccion").CellClickAction = CellClickAction.Edit
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
                .Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Columns("IdOcupacion").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("Cantidad").Width = 40
                .Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
                .Columns("Cantidad").CellClickAction = CellClickAction.EditAndSelectText
            End With

            With grid_OTRecursos.DisplayLayout.Bands(3)
                .ColHeadersVisible = False
                .Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Columns("Seleccion").Width = 30
                .Columns("IdOTR").Hidden = True
                .Columns("IdOcupacionTrabajador").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("IdOcupacion").Hidden = True
                .Columns("CantidadHoras").CellClickAction = CellClickAction.Edit
                .Columns("CantidadHoras").Width = 40
                .Columns("CantidadHoras").Style = ColumnStyle.TimeWithSpin
                .Columns("CantidadHoras").MaskInput = "hh:mm"
                .Columns("CantidadHoras").MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
                .Columns("CantidadHoras").MaskDataMode = UltraWinMaskedEdit.MaskMode.IncludePromptChars
                .Columns("CantidadHoras").DefaultCellValue = Date.Parse("01/01/1900")

                .Columns("CantidadHoras").CellAppearance.TextHAlign = HAlign.Right
            End With
            For x As Integer = 0 To grid_OTRecursos.Rows.Count - 1
                Me.grid_OTRecursos.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
        grid_OTRecursos.Focus()
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
                                    If item.IdOcupacion = o_Fila("IdOcupacion").ToString Then cont += 1
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
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Function RetornaEstadoUltimoViaje(ByVal IdVehiculo As String) As Boolean
        Try
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Id = IdVehiculo
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
            Select Case oeViaje.Estado
                Case "TRANSITO", "CARGA", "DESCARGA"
                    mensajeEmergente.Confirmacion("El vehiculo a programar se encuentra en " & oeViaje.Estado, False)
                    Return True
                Case Else
                    Return False
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarRecursosMantenimiento(ByVal ls_IdMantenimientoEquipo As String, ByVal ls_IdEquipo As String, ByVal ls_Equipo As String, _
                                       ByVal ls_IdMantenimiento As String, ByVal ls_Mantenimiento As String)

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
            rowMantemimiento("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo
            rowMantemimiento("IdEquipo") = ls_IdEquipo
            rowMantemimiento("IdMantenimiento") = ls_IdMantenimiento
            rowMantemimiento("MantenimientoOcupacion") = ls_Mantenimiento
            rowMantemimiento("CantidadHoras") = ""
            dsOT_ME_Recurso.Tables(1).Rows.Add(rowMantemimiento)
            dsOT_ME_Recurso.Tables(1).AcceptChanges()

            oeMantenimientoOcupacion = New e_MantenimientoOcupacion
            oeMantenimientoOcupacion.TipoOperacion = "L"
            oeMantenimientoOcupacion.Activo = True
            oeMantenimientoOcupacion.IdMantenimiento = ls_IdMantenimiento
            lstMantenimientoOcupacion = olMantenimientoOcupacion.Listar(oeMantenimientoOcupacion)
            For Each oeMantenimientoOcupacion As e_MantenimientoOcupacion In lstMantenimientoOcupacion
                Dim rowOcupacion As DataRow
                rowOcupacion = dsOT_ME_Recurso.Tables(2).NewRow
                rowOcupacion("Seleccion") = False
                rowOcupacion("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo
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

    Public Sub ListarActividadesOT(ByVal ls_IdOrdenTrabajo As String)
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
                .Columns("Seleccion").CellClickAction = CellClickAction.Edit
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
                .Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Columns("Seleccion").Width = 30
                .Columns("IdActividad").Hidden = True
                .Columns("IdMantenimiento").Hidden = True
                .Columns("IdMantenimientoEquipo").Hidden = True
                .Columns("CantidadDias").Width = 50
                .Columns("CantidadDias").Style = ColumnStyle.IntegerNonNegativeWithSpin
                .Columns("CantidadDias").CellAppearance.TextHAlign = HAlign.Right
                .Columns("CantidadDias").CellClickAction = CellClickAction.EditAndSelectText

                .Columns("CantidadHoras").Width = 50
                .Columns("CantidadHoras").Style = ColumnStyle.IntegerNonNegativeWithSpin
                .Columns("CantidadHoras").CellAppearance.TextHAlign = HAlign.Right
                .Columns("CantidadHoras").CellClickAction = CellClickAction.EditAndSelectText

                .Columns("CantidadMinutos").Width = 50
                .Columns("CantidadMinutos").Style = ColumnStyle.IntegerNonNegativeWithSpin
                .Columns("CantidadMinutos").CellAppearance.TextHAlign = HAlign.Right
                .Columns("CantidadMinutos").CellClickAction = CellClickAction.EditAndSelectText
            End With
            For x As Integer = 0 To grid_OTActividades.Rows.Count - 1
                Me.grid_OTActividades.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
        grid_OTActividades.Focus()
    End Sub

    Public Sub ListarActividades()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeActividad = New e_Actividad
            oeActividad.TipoOperacion = "A"
            oeActividad.Activo = True
            lstActividades = olActividad.Listar(oeActividad)
            grid_Actividades.DataSource = lstActividades
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_Actividades.Focus()
    End Sub

    Private Sub CargarActividadesMantenimiento(ByVal ls_IdMantenimientoEquipo As String, ByVal ls_IdEquipo As String, ByVal ls_Equipo As String, _
                                   ByVal ls_IdMantenimiento As String, ByVal ls_Mantenimiento As String)

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
            rowMantemimiento("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo
            rowMantemimiento("IdEquipo") = ls_IdEquipo
            rowMantemimiento("IdMantenimiento") = ls_IdMantenimiento
            rowMantemimiento("MantenimientoActividad") = ls_Mantenimiento
            rowMantemimiento("CantidadHoras") = ""
            dsOT_ME_Actividad.Tables(1).Rows.Add(rowMantemimiento)
            dsOT_ME_Actividad.Tables(1).AcceptChanges()

            oeMantenimientoActividad = New e_MantenimientoActividad
            oeMantenimientoActividad.TipoOperacion = "L"
            oeMantenimientoActividad.Activo = True
            oeMantenimientoActividad.IdMantenimiento = ls_IdMantenimiento
            lstMantenimientoActividad = olMantenimientoActividad.Listar(oeMantenimientoActividad)
            For Each oeMantenimientoActividad As e_MantenimientoActividad In lstMantenimientoActividad
                Dim rowActividad As DataRow
                rowActividad = dsOT_ME_Actividad.Tables(2).NewRow
                rowActividad("Seleccion") = False
                rowActividad("IdOTA") = ""
                rowActividad("IdMantenimiento") = oeMantenimientoActividad.IdMantenimiento
                rowActividad("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo
                rowActividad("IdActividad") = oeMantenimientoActividad.IdActividad
                rowActividad("MantenimientoActividad") = oeMantenimientoActividad.Actividad
                rowActividad("CantidadHoras") = oeMantenimientoActividad.CantidadHoras
                dsOT_ME_Actividad.Tables(2).Rows.Add(rowActividad)
            Next
            dsOT_ME_Actividad.Tables(2).AcceptChanges()
            grid_OTActividades.DataBind()

            For x As Integer = 0 To grid_OTActividades.Rows.Count - 1
                Me.grid_OTActividades.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
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
                End If

                For x As Integer = 0 To grid_OTActividades.Rows.Count - 1
                    Me.grid_OTActividades.Rows(x).ExpandAll()
                Next
            Else
                Throw New Exception("Seleccione un mantenimiento para agregar actividad")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, False)
        End Try
    End Sub

    Public Sub LlenaComboEmpresaExterna()
        oeProveedor = New e_Proveedor
        oeProveedor.Activo = True
        LlenarComboMaestro(cmbEmpresaExterna, olProveedor.Listar(oeProveedor), -1)
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
                        If mantRow("Seleccion") Then
                            mantRow.Delete()
                        Else
                            For Each actRow As DataRow In mantRow.GetChildRows(relationMantAct)
                                If actRow("Seleccion") Then actRow.Delete()
                            Next
                        End If
                    Next
                    dsOT_ME_Actividad.AcceptChanges()
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
                        If mantRow("Seleccion") Then
                            mantRow.Delete()
                        Else
                            For Each ocupRow As DataRow In mantRow.GetChildRows(relationMantOcup)
                                If ocupRow("Seleccion") Then
                                    ocupRow.Delete()
                                Else
                                    For Each trabRow As DataRow In ocupRow.GetChildRows(relationOcupTrab)
                                        If trabRow("Seleccion") Then trabRow.Delete()
                                    Next
                                End If
                            Next
                        End If
                    Next
                    dsOT_ME_Recurso.AcceptChanges()
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

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
                        If mantRow("Seleccion") Then
                            mantRow.Delete()
                        Else
                            For Each servRow As DataRow In mantRow.GetChildRows(relationMantServ)
                                If servRow("Seleccion") Then
                                    servRow.Delete()
                                End If
                            Next
                        End If
                    Next
                    dsOT_ME_Servicio.AcceptChanges()
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub QuitarMaterialesMantenimientoOT()
        Try
            With grid_OTMateriales
                Dim sw As Boolean
                For Each mantRow As DataRow In dsOT_ME_Material.Tables(1).Rows
                    'If mantRow("Seleccion") Then sw = True
                    For Each matRow As DataRow In mantRow.GetChildRows(relationMantMat)
                        If matRow("Seleccion") Then
                            sw = True
                            If matRow("CantidadMaterialEntregada") > 0 Then
                                matRow("Seleccion") = 0
                                Throw New Exception("No se puede eliminar Materiales que fueron entregados")
                            End If

                        End If
                    Next
                Next
                If Not sw Then Throw New Exception("Marque por lo menos un material para quitar de lista")
                If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    For Each mantRow As DataRow In dsOT_ME_Material.Tables(1).Rows
                        'If mantRow("Seleccion") Then
                        '    mantRow.Delete()
                        'Else
                        For Each matRow As DataRow In mantRow.GetChildRows(relationMantMat)
                            If matRow("Seleccion") Then matRow.Delete()
                        Next
                        'End If
                    Next
                    dsOT_ME_Material.AcceptChanges()
                End If
            End With
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

    Public Sub QuitarMaterialesEquipoMantenimiento(ByVal ls_IdEquipo As String, ByVal ls_IdMantenimientoEquipo As String)
        Try
            For Each equiRow As DataRow In dsOT_ME_Material.Tables(0).Rows
                If equiRow("IdEquipo") = ls_IdEquipo Then
                    For Each mantRow As DataRow In equiRow.GetChildRows(relationEquMant)
                        For Each matRow As DataRow In mantRow.GetChildRows(relationMantMat)
                            If matRow("CantidadMaterialEntregada") > 0 Then
                                Throw New Exception("No se puede eliminar el equipo con sus matenimientos, tiene algun material atendido.")
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
                    For Each mantRow As DataRow In equiRow.GetChildRows(relationEquMant)
                        If mantRow("IdMantenimientoEquipo") = ls_IdMantenimientoEquipo Then
                            For Each matRow As DataRow In mantRow.GetChildRows(relationMantMat)
                                If matRow("CantidadMaterialEntregada") > 0 Then
                                    Throw New Exception("No se puede eliminar el mantenimiento, tiene materiales atendidos.")
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

    Public Sub QuitarServiciosEquipoMantenimiento(ByVal ls_IdEquipo As String, ByVal ls_IdMantenimientoEquipo As String)
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

    Public Sub QuitarActividadesEquipoMantenimiento(ByVal ls_IdEquipo As String, ByVal ls_IdMantenimientoEquipo As String)
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

    Public Sub QuitarRecursosEquipoMantenimiento(ByVal ls_IdEquipo As String, ByVal ls_IdMantenimientoEquipo As String)
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

    Public Function ValidarExistenciaOTAbierta(ByVal ls_IdEquipo As String) As Boolean
        Try
            Dim ls_Msg As String = ""
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
            Return False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Public Sub TransponerDetalleEquipoMantenimiento()
        oeOrdenTrabajo.lstDetalleEquipoMantenimiento.Clear()
        For Each equiRow As DataRow In dsOT_ME.Tables(0).Rows
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
                oeOTEquipoMantenimiento.IdTrabajadorResponsable = equiRow("Responsable")
                oeOTEquipoMantenimiento.Activo = True
                oeOrdenTrabajo.lstDetalleEquipoMantenimiento.Add(oeOTEquipoMantenimiento)
            Next
        Next
    End Sub

    Public Sub TransponerDetalleMaterial()
        oeOrdenTrabajo.lstDetalleMaterial.Clear()
        For Each matRow As DataRow In dsOT_ME_Material.Tables(2).Rows
            oeOTMaterial = New e_OrdenTrabajo_Material
            oeOTMaterial.Id = matRow("IdOTM")
            oeOTMaterial.IdMantenimientoEquipo = matRow("IdMantenimientoEquipo")
            oeOTMaterial.IdMaterial = matRow("IdMaterial")
            oeOTMaterial.IdOrdenTrabajo = ""
            oeOTMaterial.Equipo = ""
            oeOTMaterial.Mantenimiento = ""
            oeOTMaterial.Material = matRow("MantenimientoMaterial")
            oeOTMaterial.UsuarioCreacion = oeOrdenTrabajo.UsuarioCreacion
            oeOTMaterial.IdUnidadMedida = matRow("IdUnidadMedida")
            oeOTMaterial.CantidadMaterial = matRow("CantidadMaterial")
            oeOTMaterial.CantidadMaterialEntregada = matRow("CantidadMaterialEntregada")
            oeOTMaterial.CantidadMaterialDevuelto = matRow("CantidadMaterialDevuelto")
            oeOTMaterial.Costo = matRow("Costo")
            oeOTMaterial.IdSubAlmacen = matRow("IdSubAlmacen")
            oeOTMaterial.IdAlmacen = matRow("IdAlmacen")
            oeOTMaterial.Activo = True
            oeOrdenTrabajo.lstDetalleMaterial.Add(oeOTMaterial)
        Next
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

    Private Function GuardarOrdenTrabajo() As Boolean
        Try
            oeOrdenTrabajo.TipoOperacion = "I"
            oeOrdenTrabajo.UsuarioCreacion = gUsuarioSGI.Id
            oeEstadoOT = New e_EstadoOT
            oeEstadoOT.Nombre = "PENDIENTE"
            oeEstadoOT = olEstadoOT.Obtener(oeEstadoOT)
            oeOrdenTrabajo.IdEstadoOT = oeEstadoOT.Id
            TransponerDetalleEquipoMantenimiento()
            TransponerDetalleMaterial()
            TransponerDetalleServicio()
            If oeOrdenTrabajo.IndicadorTipo = "I" Then
                TransponerDetalleOperarios()
            End If
            TransponerDetalleActividades()
            oeOrdenTrabajo.PrefijoID = gs_PrefijoIdSucursal '@0001
            _IdOT = olOrdenTrabajo.Guardar(oeOrdenTrabajo)
            If _IdOT <> "" Then
                If chkAutoIniciar.Checked Then
                    IniciarOT()
                    oeEstadoOT = New e_EstadoOT
                    oeEstadoOT.Nombre = "EN PROCESO"
                    oeEstadoOT = olEstadoOT.Obtener(oeEstadoOT)
                    oeOrdenTrabajo.IdEstadoOT = oeEstadoOT.Id
                    oeOrdenTrabajo.TipoOperacion = "A"
                    oeOrdenTrabajo.Id = _IdOT
                    olOrdenTrabajo.ActualizaEstadoOT(oeOrdenTrabajo)

                    _IdOT = "OT" & Strings.Right(_IdOT, 11)
                    mensajeEmergente.Confirmacion("Se genero e inicio satisfactoriamente la OT N°: " & _IdOT & " satisfactoriamente")
                Else
                    _IdOT = "OT" & Strings.Right(_IdOT, 11)
                    mensajeEmergente.Confirmacion("Se genero satisfactoriamente la OT N°: " & _IdOT & " satisfactoriamente")
                End If
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Public Sub IniciarOT()
        Try
            Select Case optIndicadorTipo.CheckedIndex
                Case 0
                    For Each equiRow As DataRow In dsOT_ME_Material.Tables(0).Rows
                        GenerarRequerimientoMateriales(equiRow("IdEquipo").ToString)
                    Next
                Case 1
                    GenerarRequerimientoServicios()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GenerarRequerimientoMateriales(ByVal ls_IdEquipo As String)
        Try
            oeRequerimiento = New e_Requerimiento
            oeRequerimiento.TipoOperacion = "I"
            oeRequerimiento.TipoReferencia = "ORDEN TRABAJO"
            oeRequerimiento.IdReferencia = _IdOT
            oeRequerimiento.IdEquipo = ls_IdEquipo

            oeEstadoRequerimiento = New e_EstadoRequerimiento
            oeEstadoRequerimiento.Activo = True
            oeEstadoRequerimiento.Nombre = "EVALUADO"
            oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)

            oeRequerimiento.IdEstadoRequerimiento = oeEstadoRequerimiento.Id
            oeRequerimiento.Activo = True
            oeRequerimiento.MaterialServicio = "M"
            oeRequerimiento.IdArea = oeArea.Id
            oeRequerimiento.UsuarioCreacion = gUsuarioSGI.Id
            oeRequerimiento.FechaAtencion = Date.Parse("01/01/1901")
            TransponerDetalleMaterialRequerimiento(ls_IdEquipo)
            oeRequerimiento.Descripcion = ls_GlosaOrden
            oeRequerimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            olRequerimiento.Guardar(oeRequerimiento)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GenerarRequerimientoServicios()
        Try
            oeRequerimiento = New e_Requerimiento
            oeRequerimiento.TipoOperacion = "I"
            oeRequerimiento.TipoReferencia = "ORDEN TRABAJO"
            oeRequerimiento.IdReferencia = _IdOT

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
            TransponerDetalleServicioRequerimiento()
            oeRequerimiento.Descripcion = ls_GlosaOrden
            oeRequerimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            olRequerimiento.Guardar(oeRequerimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub TransponerDetalleMaterialRequerimiento(ByVal ls_IdEquipo As String)
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
                        oeRequerimientoMaterial.Precio = matRow("Costo")
                        oeRequerimientoMaterial.IdCentroCosto = ""
                        oeRequerimientoMaterial.IdEstadoRequerimientoMaterial = oeEstadoRequerimiento.Id
                        oeRequerimiento.lstRequerimientoMaterial.Add(oeRequerimientoMaterial)
                    Next
                Next
            End If
        Next
        If ls_GlosaOrden <> "" Then
            ls_GlosaOrden = ls_GlosaOrden.Substring(0, ls_GlosaOrden.Length - 1)
        End If
    End Sub

    Public Sub TransponerDetalleServicioRequerimiento()
        oeRequerimiento.lstRequerimientoServicio = New List(Of e_RequerimientoServicio)
        ls_GlosaOrden = String.Empty
        oeEstadoRequerimiento = New e_EstadoRequerimiento
        oeEstadoRequerimiento.Nombre = "APROBADO"
        oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)
        For Each equiRow As DataRow In dsOT_ME_Servicio.Tables(0).Rows
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
                    oeRequerimientoServicio.IdEmpresaServicio = cmbEmpresaExterna.Value
                    oeRequerimientoServicio.IdEstadoRequerimientoServicio = oeEstadoRequerimiento.Id
                    oeRequerimiento.lstRequerimientoServicio.Add(oeRequerimientoServicio)
                Next
            Next
        Next
        If ls_GlosaOrden <> "" Then
            ls_GlosaOrden = ls_GlosaOrden.Substring(0, ls_GlosaOrden.Length - 1)
        End If
    End Sub

    Sub ConsultarMantenimientosAnteriores(ByVal ls_IdEquipo As String)
        Try
            Try
                Cursor.Current = Cursors.WaitCursor
                Dim oeOT As New e_OrdenTrabajo
                oeOT.Activo = True
                oeOT.TipoOperacion = "A"
                oeOT.FechaProgramacionIni = Date.Parse("01/01/1901").Date
                oeOT.FechaProgramacionFin = Date.Parse("01/01/1901").Date
                oeOT.FechaIngresoTaller = Date.Parse("01/01/1901").Date
                oeOT.FechaInicioTrabajo = Date.Parse("01/01/1901").Date
                oeOT.FechaFinTrabajo = Date.Parse("01/01/1901").Date
                oeOT.FechaCreacion = Date.Parse("01/01/1901").Date
                oeOT.NroOT = ""
                oeOT.IdEstadoOT = ""
                oeOT.IdEquipo = ls_IdEquipo
                oeOT.IdSupervisorMant = ""
                oeOT.IdMantenimiento = ""
                oeOT.IdTipoMantenimiento = ""
                oeOT.IndicadorTipo = ""

                oeOT.FechaProgramacionIni = Date.Today.AddDays(-60)
                oeOT.FechaProgramacionFin = Date.Today

                dsOTAnteriores = olOrdenTrabajo.Listar(oeOT)

                ''''''''''''''''''''''''''''''''''''''''''''''
                'Tabla(0) OT
                'Tabla(1) Equipo
                'Tabla(2) Mantenimiento
                'Tabla(3) Material
                ''''''''''''''''''''''''''''''''''''''''''''''

                Dim IdOT As DataColumn = dsOTAnteriores.Tables(0).Columns("IdOT")
                Dim IdOT_EM As DataColumn = dsOTAnteriores.Tables(1).Columns("IdOrdenTrabajo")
                Dim relation1 As DataRelation = New DataRelation("FK_Relacion_OTOT", IdOT, IdOT_EM, True)
                dsOTAnteriores.Relations.Add(relation1)

                Dim TransactionColumns() As DataColumn, DetailColumns() As DataColumn
                TransactionColumns = New DataColumn() {dsOTAnteriores.Tables(1).Columns("IdOrdenTrabajo"), dsOTAnteriores.Tables(1).Columns("IdEquipo")}
                DetailColumns = New DataColumn() {dsOTAnteriores.Tables(2).Columns("IdOrdenTrabajo"), dsOTAnteriores.Tables(2).Columns("IdEquipo")}
                Dim Tran_Detail As New DataRelation("FK_Relacion_OTEM", TransactionColumns, DetailColumns)
                dsOTAnteriores.Relations.Add(Tran_Detail)

                Dim TransactionColumns1() As DataColumn, DetailColumns1() As DataColumn
                TransactionColumns1 = New DataColumn() {dsOTAnteriores.Tables(2).Columns("IdOrdenTrabajo"), dsOTAnteriores.Tables(2).Columns("IdEquipo"), dsOTAnteriores.Tables(2).Columns("IdMantenimiento")}
                DetailColumns1 = New DataColumn() {dsOTAnteriores.Tables(3).Columns("IdOrdenTrabajo"), dsOTAnteriores.Tables(3).Columns("IdEquipo"), dsOTAnteriores.Tables(3).Columns("IdMantenimiento")}
                Dim Tran_Detail1 As New DataRelation("FK_Relacion_MM", TransactionColumns1, DetailColumns1, True)
                dsOTAnteriores.Relations.Add(Tran_Detail1)

                dsOTAnteriores.AcceptChanges()
                With grid_OTAnteriores
                    .DataSource = dsOTAnteriores

                    .DisplayLayout.Bands(1).ColHeadersVisible = False
                    .DisplayLayout.Bands(2).ColHeadersVisible = False
                    .DisplayLayout.Bands(3).ColHeadersVisible = False

                    .DisplayLayout.Bands(1).Columns("IdOrdenTrabajo").Hidden = True
                    .DisplayLayout.Bands(1).Columns("IdEquipo").Hidden = True
                    .DisplayLayout.Bands(2).Columns("IdOrdenTrabajo").Hidden = True
                    .DisplayLayout.Bands(2).Columns("IdEquipo").Hidden = True
                    .DisplayLayout.Bands(2).Columns("IdMantenimiento").Hidden = True

                    .DisplayLayout.Bands(3).Columns("IdOrdenTrabajo").Hidden = True
                    .DisplayLayout.Bands(3).Columns("IdEquipo").Hidden = True
                    .DisplayLayout.Bands(3).Columns("IdMantenimiento").Hidden = True
                    .DisplayLayout.Bands(3).Columns("IdMaterial").Hidden = True

                    .DisplayLayout.Bands(1).Columns("Odometro").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(1).Columns("Horometro").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(3).Columns("CantidadMaterialEntregada").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Auxilio").Width = 80

                    'For x As Integer = 0 To .Rows.Count - 1
                    '    .Rows(x).ExpandAll()
                    'Next
                    .DisplayLayout.Bands(0).Columns("Odometro").CellActivation = Activation.NoEdit

                End With
            Catch ex As Exception
                Throw ex
            Finally
                Me.Cursor = Cursors.Default
            End Try
            grid_OTAnteriores.Focus()
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Eventos"

    Private Sub frm_AsistenteOT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me, txtBuscarMateriales.Name, btnListarMateriales.Name)
        gf_AsignarEventoSeleccionarTexto(Me)
        MostrarTabs(0, TabGeneral)
        dtp_FechaProg.Value = Date.Now
        dtp_FecIngTaller.Value = Date.Now
        dtp_HorIngTaller.Value = Date.Now
        dtp_FecIniTrab.Value = Date.Now
        dtp_HorIniTrab.Value = Date.Now
        dtp_FecFinTrab.Value = Date.Now
        dtp_HorFinTrab.Value = Date.Now
        dtp_FecTentSal.Value = Date.Now
        dtp_HorTentSal.Value = Date.Now
        chkAutoIniciar.Checked = False
        ListarEquiposMantenimiento()
        ListarEquiposMantenimientoOT("")
        ListarActividades()
        ListarMaterialesOT("")
        ListarServiciosOT("")
        ListarRecursosOT("")
        ListarActividadesOT("")
        LlenaCombos()
        btnAtras.Visible = False
        Me.cmbEmpresaExterna.Enabled = False
        cmbEmpresaExterna.Value = ISL_IdProveedor

        _TipoCambio = TipoCambio(dtp_FecIngTaller.Value, True)(0)
        If _TipoCambio = 0 Then
            Throw New Exception("No existe tipo de cambio para esta fecha.")
        End If
        ndTipoCambio.Value = IIf(_TipoCambio <> 0.0, _TipoCambio, "")
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Dim tb As Integer = TabGeneral.SelectedTab.Index
        If tb <> 0 Then
            For i As Integer = 0 To TabGeneral.Tabs.Count - 1
                TabGeneral.Tabs(i).Enabled = False
            Next
            Select Case tb
                Case 1
                    TabGeneral.Tabs(0).Enabled = True
                    TabGeneral.Tabs(0).Selected = True
                    btnAtras.Visible = False
                Case 2
                    TabGeneral.Tabs(1).Enabled = True
                    TabGeneral.Tabs(1).Selected = True
                Case 3
                    TabGeneral.Tabs(2).Enabled = True
                    TabGeneral.Tabs(2).Selected = True
                    Me.txtBuscarMateriales.Text = String.Empty
                    lstMateriales.Clear()
                Case 4
                    TabGeneral.Tabs(3).Enabled = True
                    TabGeneral.Tabs(3).Selected = True
                Case 5
                    TabGeneral.Tabs(4).Enabled = True
                    TabGeneral.Tabs(4).Selected = True
                Case 6
                    TabGeneral.Tabs(5).Enabled = True
                    TabGeneral.Tabs(5).Selected = True
                    btnSiguiente.Text = "Siguiente >"
            End Select
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function ValidarPaso1() As Boolean
        Try
            If cmbEmpresaExterna.SelectedIndex = -1 Then Throw New Exception("Seleccione la empresa")
            If cmbJefeTaller.SelectedIndex = -1 Then Throw New Exception("Seleccione un Jefe Taller")
            If cmbSupervisorMant.SelectedIndex = -1 Then Throw New Exception("Seleccione un Supervisor Mantenimiento")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarPaso2() As Boolean
        Try
            If dsOT_ME.Tables(0).Rows.Count = 0 Then Throw New Exception("Agregue por los menos un equipo y matenimiento")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarPaso3() As Boolean
        Try
            If dsOT_ME_Material.Tables(2).Rows.Count = 0 Then Throw New Exception("Agregue por los menos un material")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarPaso4() As Boolean
        Try
            If dsOT_ME_Servicio.Tables(2).Rows.Count = 0 Then Throw New Exception("Agregue por los menos un servicio")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function FinalizarAsistente() As Boolean
        Return GuardarOrdenTrabajo()
    End Function

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        Dim tb As Integer
        Try
            tb = TabGeneral.SelectedTab.Index
            If tb <> 7 Then
                For i As Integer = 0 To TabGeneral.Tabs.Count - 1
                    TabGeneral.Tabs(i).Enabled = False
                Next
                Select Case tb
                    Case 0
                        If ValidarPaso1() Then
                            TabGeneral.Tabs(1).Enabled = True
                            TabGeneral.Tabs(1).Selected = True
                        Else
                            TabGeneral.Tabs(0).Enabled = True
                            TabGeneral.Tabs(0).Selected = True
                            Exit Sub
                        End If
                    Case 1
                        If ValidarPaso2() Then
                            TabGeneral.Tabs(2).Enabled = True
                            TabGeneral.Tabs(2).Selected = True
                            CargarMantenimientoMaterial()
                            Me.txtBuscarMateriales.Focus()
                        Else
                            TabGeneral.Tabs(1).Enabled = True
                            TabGeneral.Tabs(1).Selected = True
                            Exit Sub
                        End If
                    Case 2
                        If ValidarPaso3() Then
                            TabGeneral.Tabs(3).Enabled = True
                            TabGeneral.Tabs(3).Selected = True
                        Else
                            TabGeneral.Tabs(2).Enabled = True
                            TabGeneral.Tabs(2).Selected = True
                            Exit Sub
                        End If
                    Case 3
                        TabGeneral.Tabs(4).Enabled = True
                        TabGeneral.Tabs(4).Selected = True
                    Case 4
                        TabGeneral.Tabs(5).Enabled = True
                        TabGeneral.Tabs(5).Selected = True
                    Case 5
                        TabGeneral.Tabs(6).Enabled = True
                        TabGeneral.Tabs(6).Selected = True
                        Me.btnSiguiente.Text = "Finalizar"
                    Case 6
                        If FinalizarAsistente() Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                End Select
                btnAtras.Visible = True
            End If
        Catch ex As Exception
            TabGeneral.Tabs(tb).Enabled = True
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        ListarMateriales()
    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        If e.KeyCode = Keys.Enter Then ListarMateriales()
    End Sub

    Private Sub grid_Materiales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Materiales.CellChange
        grid_Materiales.UpdateData()
    End Sub

    Private Sub btnAgregarMat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMat.Click
        AgregarMaterialEquipoMantenimiento()
    End Sub

    Private Sub btnAgregarServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarServ.Click
        AgregarServicioEquipoMantenimiento()
    End Sub

    Private Sub grid_Servicios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Servicios.CellChange
        grid_Servicios.UpdateData()
    End Sub

    Private Sub btnListarOperarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarOperarios.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            oeOcupacionTrabajador = New e_OcupacionTrabajador
            oeOcupacionTrabajador.TipoOperacion = ""
            oeOcupacionTrabajador.Activo = True
            oeOcupacionTrabajador.Principal = 1
            oeOcupacionTrabajador.IdOcupacion = IIf(cmbOcupaciones.Value = "CERO", "", cmbOcupaciones.Value)
            lstTrabajadores = olOcupacionTrabajador.Listar(oeOcupacionTrabajador)
            grid_Operarios.DataSource = lstTrabajadores
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_Operarios.Focus()
    End Sub

    Private Sub grid_Operarios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Operarios.CellChange
        grid_Operarios.UpdateData()
    End Sub

    Private Sub btnAgregarTrab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTrab.Click
        AgregarTrabajadorEquipoMantenimientoOcupacion()
    End Sub

    Private Sub grid_Actividades_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Actividades.CellChange
        grid_Actividades.UpdateData()
    End Sub

    Private Sub btnAgregarAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAct.Click
        AgregarActividadesEquipoMantenimiento()
    End Sub

    Private Sub txtBuscarEquipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarEquipo.ValueChanged
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

    Private Sub grid_Equipos_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_Equipos.InitializeLayout
        With grid_Equipos
            .DisplayLayout.Bands(0).SortedColumns.Add("Equipo", True, True)
            .DisplayLayout.GroupByBox.Hidden = True
        End With
    End Sub

    Private Sub btnAgregarEquipoMant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarEquipoMant.Click
        AgregarEquiposMantenimiento()
    End Sub

    Private Sub optIndicadorTipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optIndicadorTipo.ValueChanged
        If optIndicadorTipo.CheckedIndex <> -1 Then
            Select Case optIndicadorTipo.CheckedIndex
                Case 0
                    oeOrdenTrabajo.IndicadorTipo = "I"
                    cmbEmpresaExterna.Enabled = False
                    cmbEmpresaExterna.Value = ISL_IdProveedor
                Case 1
                    oeOrdenTrabajo.IndicadorTipo = "E"
                    cmbEmpresaExterna.Enabled = True
                    cmbEmpresaExterna.SelectedIndex = -1
            End Select

        End If
    End Sub

    Private Sub grid_Equipos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Equipos.CellChange
        grid_Equipos.UpdateData()
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
        Try
            If mcDetalle.SourceControl Is grid_OT_ME Then
                QuitarEquiposMantenimiento()
            ElseIf mcDetalle.SourceControl Is grid_OTServicios Then
                QuitarServiciosMantenimientoOT()
            ElseIf mcDetalle.SourceControl Is grid_OTMateriales Then
                QuitarMaterialesMantenimientoOT()
            ElseIf mcDetalle.SourceControl Is grid_OTRecursos Then
                QuitarRecursosMantenimientoOT()
            ElseIf mcDetalle.SourceControl Is grid_OTActividades Then
                QuitarActividadesMantenimientoOT()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        If mcDetalle.SourceControl Is grid_Equipos Then
            AgregarEquiposMantenimiento()
        ElseIf mcDetalle.SourceControl Is grid_Servicios Then
            AgregarServicioEquipoMantenimiento()
        ElseIf mcDetalle.SourceControl Is grid_Materiales Then
            AgregarMaterialEquipoMantenimiento()
        ElseIf mcDetalle.SourceControl Is grid_Operarios Then
            AgregarTrabajadorEquipoMantenimientoOcupacion()
        ElseIf mcDetalle.SourceControl Is grid_Actividades Then
            AgregarActividadesEquipoMantenimiento()
        End If
    End Sub

    Private Sub mcDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcDetalle.Opening
        Try
            mcDetalle.Items(0).Visible = True : mcDetalle.Items(1).Visible = True
            If mcDetalle.SourceControl Is grid_Equipos Then
                mcDetalle.Items(1).Visible = False
                If grid_Equipos.Rows.Count = 0 Then
                    mcDetalle.Items(0).Visible = False
                End If
            ElseIf mcDetalle.SourceControl Is grid_OT_ME Then
                mcDetalle.Items(0).Visible = False
                If grid_OT_ME.Rows.Count = 0 Then
                    mcDetalle.Items(1).Visible = False
                End If
            End If
            If mcDetalle.SourceControl Is grid_Materiales Then
                mcDetalle.Items(1).Visible = False
                If grid_Materiales.Rows.Count = 0 Then
                    mcDetalle.Items(0).Visible = False
                End If
            ElseIf mcDetalle.SourceControl Is grid_OTMateriales Then
                mcDetalle.Items(0).Visible = False
                If grid_OTMateriales.Rows.Count = 0 Then
                    mcDetalle.Items(1).Visible = False
                End If
            End If

            If mcDetalle.SourceControl Is grid_Servicios Then
                mcDetalle.Items(1).Visible = False
                If grid_Servicios.Rows.Count = 0 Then
                    mcDetalle.Items(0).Visible = False
                End If
            ElseIf mcDetalle.SourceControl Is grid_OTServicios Then
                mcDetalle.Items(0).Visible = False
                If grid_OTServicios.Rows.Count = 0 Then
                    mcDetalle.Items(1).Visible = False
                End If
            End If

            If mcDetalle.SourceControl Is grid_Operarios Then
                mcDetalle.Items(1).Visible = False
                If grid_Operarios.Rows.Count = 0 Then
                    mcDetalle.Items(0).Visible = False
                End If
            ElseIf mcDetalle.SourceControl Is grid_OTRecursos Then
                mcDetalle.Items(0).Visible = False
                If grid_OTRecursos.Rows.Count = 0 Then
                    mcDetalle.Items(1).Visible = False
                End If
            End If

            If mcDetalle.SourceControl Is grid_Actividades Then
                mcDetalle.Items(1).Visible = False
                If grid_Actividades.Rows.Count = 0 Then
                    mcDetalle.Items(0).Visible = False
                End If
            ElseIf mcDetalle.SourceControl Is grid_OTActividades Then
                mcDetalle.Items(0).Visible = False
                If grid_OTActividades.Rows.Count = 0 Then
                    mcDetalle.Items(1).Visible = False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmbEmpresaExterna_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresaExterna.ValueChanged
        oeOrdenTrabajo.IdEmpresaExterna = cmbEmpresaExterna.Value
    End Sub

    Private Sub verAuxilio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verAuxilio.CheckedChanged
        oeOrdenTrabajo.Auxilio = verAuxilio.Checked
    End Sub

    Private Sub cmbJefeTaller_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJefeTaller.ValueChanged
        oeOrdenTrabajo.IdJefeTaller = cmbJefeTaller.Value
    End Sub

    Private Sub cmbSupervisorMant_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSupervisorMant.ValueChanged
        oeOrdenTrabajo.IdSupervisorMant = cmbSupervisorMant.Value
    End Sub

    'Private Sub dtpFechaIngTaller_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    oeOrdenTrabajo.FechaIngresoTaller = dtpFechaIngTaller.Value
    '    If dtpFechaIngTaller.Value > dtpFechaIniTrab.Value Then
    '        dtpFechaIniTrab.Value = dtpFechaIngTaller.Value
    '        dtpFechaFinTrab.Value = dtpFechaIngTaller.Value
    '    End If
    'End Sub

    'Private Sub dtpFechaIniTrab_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    oeOrdenTrabajo.FechaInicioTrabajo = dtpFechaIniTrab.Value
    '    If dtpFechaIniTrab.Value > dtpFechaFinTrab.Value Then
    '        dtpFechaFinTrab.Value = dtpFechaIniTrab.Value
    '    End If
    'End Sub

    'Private Sub dtpFechaFinTrab_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    oeOrdenTrabajo.FechaFinTrabajo = dtpFechaFinTrab.Value
    'End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        txtGlosa.Text = LTrim(txtGlosa.Text)
        oeOrdenTrabajo.Glosa = txtGlosa.Text
    End Sub

    Private Sub grid_Equipos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Equipos.DoubleClickRow
        With grid_Equipos
            If .Rows.Count > 0 Then
                If .ActiveRow.IsGroupByRow Then
                    If .ActiveRow.ChildBands(0).Rows(0).Cells("IdEquipo").Value <> Nothing Then
                        Dim IdEquipo As String = .ActiveRow.ChildBands(0).Rows(0).Cells("IdEquipo").Value
                        ConsultarMantenimientosAnteriores(IdEquipo)
                        gbeOTsAnteriores.Expanded = True
                    End If
                Else
                    gbeOTsAnteriores.Expanded = False
                End If
            End If
        End With
    End Sub

    Private Sub grid_OT_ME_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_OT_ME.DoubleClickRow
        With grid_OT_ME
            If .ActiveRow.Band.Index = 0 Then
                If .Rows.Count > 0 Then
                    If .ActiveRow.Cells("IdEquipo").Value <> Nothing Then
                        ConsultarMantenimientosAnteriores(.ActiveRow.Cells("IdEquipo").Value.ToString)
                        gbeOTsAnteriores.Expanded = True
                    End If
                End If
            Else
                gbeOTsAnteriores.Expanded = False
            End If
        End With
    End Sub

    Private Sub grid_OTActividades_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_OTActividades.CellChange
        grid_OTActividades.UpdateData()
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

#End Region

    Private Sub grid_Actividades_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Actividades.DoubleClickRow
        Try
            If grid_OTActividades.ActiveRow.Band.Index = 1 Then
                Dim rowActividad As DataRow
                rowActividad = dsOT_ME_Actividad.Tables(2).NewRow
                rowActividad("Seleccion") = False
                rowActividad("IdOTA") = ""
                rowActividad("IdMantenimiento") = grid_OTActividades.ActiveRow.Cells("IdMantenimiento").Value
                rowActividad("IdMantenimientoEquipo") = grid_OTActividades.ActiveRow.Cells("IdMantenimientoEquipo").Value
                rowActividad("IdActividad") = grid_Actividades.ActiveRow.Cells("Id").Value
                rowActividad("MantenimientoActividad") = grid_Actividades.ActiveRow.Cells("Nombre").Value
                rowActividad("CantidadDias") = 0
                rowActividad("CantidadHoras") = 0
                rowActividad("CantidadMinutos") = 0

                dsOT_ME_Actividad.Tables(2).Rows.Add(rowActividad)
                dsOT_ME_Actividad.Tables(2).AcceptChanges()

                grid_Actividades.DataBind()
                grid_OTActividades.DataBind()

                For x As Integer = 0 To grid_OTActividades.Rows.Count - 1
                    Me.grid_OTActividades.Rows(x).ExpandAll()
                Next
            Else
                Throw New Exception("Seleccione un mantenimiento para agregar actividad")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, False)
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

    ''' <summary>
    ''' Calcular la fecha estimada de salida del vehículo del área de mantenimiento
    ''' </summary>
    ''' <remarks></remarks>
    ''' 

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
        Me.dtp_FecFinTrab.Value = ff
    End Sub

    Private Sub grid_OTServicios_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_OTServicios.DoubleClickRow
        If grid_OTServicios.Rows.Count > 0 AndAlso grid_OTServicios.ActiveRow.Band.Index = 1 Then
            Try
                Me.Cursor = Cursors.WaitCursor
                oeMantenimientoServicio = New e_MantenimientoServicio
                oeMantenimientoServicio.TipoOperacion = "L"
                oeMantenimientoServicio.Activo = True
                oeMantenimientoServicio.IdMantenimiento = grid_OTServicios.ActiveRow.Cells("IdMantenimiento").Value
                lstMantenimientoServicio = olMantenimientoServicio.Listar(oeMantenimientoServicio)
                grid_Servicios.DataSource = lstMantenimientoServicio
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message)
            Finally
                Me.Cursor = Cursors.Default
                grid_Servicios.Focus()
            End Try
        End If

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

    Private Sub CalcularTotalServicios()
        Dim costo As Double = 0
        For Each servRow As DataRow In dsOT_ME_Servicio.Tables(2).Rows
            costo += servRow("Costo")
        Next
        Me.ndTotalServicios.Value = costo
    End Sub

    Private Sub dtp_FecIngTaller_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FecIngTaller.ValueChanged, dtp_HorIngTaller.ValueChanged
        oeOrdenTrabajo.FechaIngresoTaller = Date.Parse(dtp_FecIngTaller.Value.Date & " " & dtp_HorIngTaller.Value.ToShortTimeString)
        If Date.Parse(dtp_FecIngTaller.Value.Date & " " & dtp_HorIngTaller.Value.ToShortTimeString) > Date.Parse(dtp_FecIniTrab.Value.Date & " " & dtp_HorIniTrab.Value.ToShortTimeString) Then
            dtp_FecIniTrab.Value = dtp_FecIngTaller.Value
            dtp_HorIniTrab.Value = dtp_HorIngTaller.Value
            dtp_FecFinTrab.Value = dtp_FecIngTaller.Value
            dtp_HorFinTrab.Value = dtp_HorIngTaller.Value
        End If
        ndTipoCambio.Value = TipoCambio(dtp_FecIngTaller.Value)(0)
    End Sub


    Private Sub dtp_FecIniTrab_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FecIniTrab.ValueChanged, dtp_HorIniTrab.ValueChanged
        oeOrdenTrabajo.FechaInicioTrabajo = Date.Parse(dtp_FecIniTrab.Value.Date & " " & dtp_HorIniTrab.Value.ToShortTimeString)
        If Date.Parse(dtp_FecIniTrab.Value.Date & " " & dtp_HorIniTrab.Value.ToShortTimeString) > Date.Parse(dtp_FecFinTrab.Value.Date & " " & dtp_HorFinTrab.Value.ToShortTimeString) Then
            dtp_FecFinTrab.Value = dtp_FecIniTrab.Value
            dtp_HorFinTrab.Value = dtp_HorIniTrab.Value
        End If
    End Sub

    Private Sub dtp_FecFinTrab_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FecFinTrab.ValueChanged, dtp_HorFinTrab.ValueChanged
        oeOrdenTrabajo.FechaFinTrabajo = Date.Parse(dtp_FecFinTrab.Value.Date & " " & dtp_HorFinTrab.Value.ToShortTimeString)
    End Sub

    Private Sub dtp_FechaProg_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaProg.ValueChanged
        oeOrdenTrabajo.FechaProgramacionIni = dtp_FechaProg.Value
    End Sub

    Private Sub dtp_FecTentSal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FecTentSal.ValueChanged, dtp_HorTentSal.ValueChanged
        oeOrdenTrabajo.FechaTentativaSalida = Date.Parse(dtp_FecTentSal.Value.Date & " " & dtp_HorTentSal.Value.ToShortTimeString)
    End Sub

  
End Class
