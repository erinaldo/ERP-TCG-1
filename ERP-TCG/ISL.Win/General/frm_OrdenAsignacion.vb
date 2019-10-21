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

Public Class frm_OrdenAsignacion
    Inherits frm_MenuPadre

#Region "Inicialización del formulario"

    Private Shared Instancia As frm_OrdenAsignacion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_OrdenAsignacion
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Definicion de Variables"
    '
    Dim oeMaterial As New e_Material, olMaterial As New l_Material
    Dim lstMateriales As New List(Of e_Material)
    Dim oeUnidadMedida As New e_UnidadMedida, olUnidadMedida As New l_UnidadMedida
    Dim oeMaterialAlmacen As New e_MaterialAlmacen
    Dim olMaterialAlmacen As New l_MaterialAlmacen

    Private oeSubAlmacen As New e_SubAlmacen
    Private olSubAlmacen As New l_SubAlmacen

    Dim oeMarca As New e_Marca, olMarca As New l_Marca
    Dim oeModelo As New e_Modelo, olModelo As New l_Modelo

    Private olOrdenAsignacion As New l_OrdenAsignacion
    Private WithEvents oeOrdenAsignacion As New e_OrdenAsignacion

    Private oeUnidadAsignada As New e_OrdenAsignacion_UnidadAsignacion
    Private oeUnidadAsignadaMaterial As New e_OrdenAsignacion_Material
    Private olUnidadAsignadaMaterial As New l_OrdenAsignacion_Material

    Private oeDetalleMaterialAsignacion As New e_DetalleMaterialAsignacion
    Private olDetalleMaterialAsignacion As New l_DetalleMaterialAsignacion

    Private cantTotalAtender As Double = 0

    Private oeEstado As New e_Estado
    Private lstEstado As New List(Of e_Estado)
    Private olEstado As New l_Estado

    Private lstTipoUnidadAsignada As New List(Of e_Estado)

    'Para Lista Equipos
    Private oeEquipo As New e_Equipo
    Private olEquipo As New l_Equipo
    'Para Lista Areas 
    Private oeArea As New e_Area
    Private olArea As New l_Area
    'Para Lista Trabajadores
    Private oeTrabajador As New e_Trabajador
    Private olTrabajador As New l_Trabajador

    'listas para Combos
    Private lstArea As New List(Of e_Area)
    Private lstEquipo As New List(Of e_Equipo)
    Private lstTrabajador As New List(Of e_Trabajador)
    'Listas para grillas
    Private lstAreas As New List(Of e_Area)
    Private lstEquipos As New List(Of e_Equipo)
    Private lstTrabajadores As New List(Of e_Trabajador)
    Private lstOA As New List(Of e_OrdenAsignacion)
    Dim ds_UA_MA As DataSet
    Dim dsRegistroInv As New DataSet
    'Dim ds_MA_DT As DataSet
    Dim relation As DataRelation

    'Para Generar Requerimiento
    Dim lstRequerimiento As New List(Of e_Requerimiento)
    Dim oeRequerimiento As New e_Requerimiento, olRequerimiento As New l_Requerimiento
    Dim oeDetReq As New e_RequerimientoMaterial
    Dim oeEstadoRequerimiento As New e_EstadoRequerimiento, olEstadoRequerimiento As New l_EstadoRequerimiento

    'Para Sub Almacen Virtual
    Dim oeSubAlmacenIngreso As New e_SubAlmacen

    Dim cantmat As Double = 0
    Dim _ingresando_datos As Boolean = False

    'Revisar si estan en MaterialAlmacen
    Dim lstMaterialesAlmacen As New List(Of e_MaterialAlmacen)
    Dim oeMaterial_Almacen As New e_MaterialAlmacen
    Dim oeDetalleOrdenIngreso As New e_OrdenMaterial, olDetalleOrdenIngreso As New l_OrdenMaterial

    'IGV
    Dim oeIGV As New e_Impuesto
    Dim olIGV As New l_Impuesto

    'Manejador de Inventario
    Dim oeInventario As New e_Inventario
    Dim olInventario As New l_Inventario
    Dim listaInventario As New List(Of e_Inventario)

    Private olTrabajadorSeguridad As New l_TrabajadorSeguridad

    Private oeOcupacionTrabajador As New e_OcupacionTrabajador
    Private olOcupacionTrabajador As New l_OcupacionTrabajador

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        Try
            Me.gbEAT.Visible = True
            oeIGV = olIGV.IGV(dtpFecha.Value)
            Me.etiGenerando.Visible = False
            Me.txtNroOA.Text = String.Empty
            Me.txtGlosa.Text = String.Empty
            Me.txtEstado.Text = String.Empty
            uebHistorialMaterial.Expanded = False

            dtpFecha.Value = Date.Now
            Me.txtBuscarMateriales.Text = String.Empty
            rbDatosAdicionales.Checked = True
            oeOrdenAsignacion = New e_OrdenAsignacion
            oeOrdenAsignacion.Modificado = False
            Me.grid_Materiales.DataSource = odMaterial
            agrDatoGeneral.Enabled = True
            Me.mnDetalle.Tools("Agregar").SharedProps.Visible = True
            Me.mnDetalle.Tools("Quitar").SharedProps.Visible = True
            Me.mnDetalle.Tools("Devolucion").SharedProps.Visible = False
            Me.mnDetalle.Tools("Actualizar").SharedProps.Visible = False
            mnDetalle.Visible = True
            lstMateriales.Clear()
            ds_UA_MA.Tables(1).Clear()
            ds_UA_MA.Tables(0).Clear()
            dsRegistroInv = New DataSet
            dsRegistroInv = ObtenerDetalleAsignacion("", "")
            grReg_Inv.DataSource = dsRegistroInv
            ficHistorialMaterial.Tabs(1).Text = "Material"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            ValidarFechaDesde_Hasta(rfFechaDesde, rfFechaHasta)
            Me.Cursor = Cursors.WaitCursor
            oeOrdenAsignacion = New e_OrdenAsignacion
            oeOrdenAsignacion.TipoOperacion = "1"
            oeOrdenAsignacion.Activo = Activo
            oeOrdenAsignacion.FechaDesde = Date.Parse("01/01/1901").Date
            oeOrdenAsignacion.FechaHasta = Date.Parse("01/01/1901").Date
            If rbDatosAdicionales.Checked Then
                oeOrdenAsignacion.FechaDesde = rfFechaDesde.Value
                oeOrdenAsignacion.FechaHasta = rfFechaHasta.Value
                oeOrdenAsignacion.IdEstadoOA = cmEstadoOA.Value
                oeOrdenAsignacion.IndUnidad = cmdTipoUnidadAsignada.Value
                oeOrdenAsignacion.Idunidadasignada = cmEAT.Value
            ElseIf rbNroOA.Checked Then
                oeOrdenAsignacion.NroOA = Trim(Me.txtOA.Text)
                If String.IsNullOrEmpty(oeOrdenAsignacion.NroOA) Then
                    Me.txtNroOA.Focus()
                    Throw New Exception("Escribir N° Orden")
                End If
            End If
            lstOA = New List(Of e_OrdenAsignacion)
            With grid_OA
                lstOA = olOrdenAsignacion.Listar(oeOrdenAsignacion)
                .DataSource = lstOA
                ''Ubica el cursor en el primer registro de la grilla    
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                    Me.Agrupacion4.Text = "Ordenes de Asignacion : " & .Rows.Count
                End If
                For Each fila As UltraGridRow In .Rows
                    Select Case fila.Cells("EstadoOA").Value
                        Case "GENERADA"
                            fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                        Case "EN PROCESO"
                            fila.CellAppearance.BackColor = Me.ColoresEnProceso.Color
                        Case "TERMINADA"
                            fila.CellAppearance.BackColor = Me.ColoresTerminada.Color
                        Case "ANULADO"
                            fila.CellAppearance.BackColor = Me.ColoresAnulado.Color
                    End Select
                Next
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListarCombosFiltros()
        ComboEstados()
        ComboTipoAsignadas()
    End Sub

    Private Sub ComboEstados()
        'Estados
        oeEstado.Id = ""
        oeEstado.Nombre = "TODOS"
        lstEstado.Add(oeEstado)
        oeEstado = New e_Estado
        oeEstado.Nombre = "ORDEN DE ASIGNACION"
        lstEstado.AddRange(olEstado.Listar(oeEstado))
        LlenarComboMaestro(cmEstadoOA, lstEstado, 0)
    End Sub

    Private Sub ComboTipoAsignadas()
        'Unidad Asignada
        oeEstado = New e_Estado
        oeEstado.Id = ""
        oeEstado.Nombre = "TODOS"
        lstTipoUnidadAsignada.Add(oeEstado)
        oeEstado = New e_Estado
        oeEstado.Id = "V" 'Vehiculo
        oeEstado.Nombre = "EQUIPO"
        lstTipoUnidadAsignada.Add(oeEstado)
        oeEstado = New e_Estado
        oeEstado.Id = "A" 'Area
        oeEstado.Nombre = "AREA"
        lstTipoUnidadAsignada.Add(oeEstado)
        oeEstado = New e_Estado
        oeEstado.Id = "T" 'Trabajador
        oeEstado.Nombre = "TRABAJADOR"
        lstTipoUnidadAsignada.Add(oeEstado)
        LlenarComboMaestro(cmdTipoUnidadAsignada, lstTipoUnidadAsignada, 0)
    End Sub

    Private Sub Combo_VAT(ByVal TipoUnidad As String)
        LimpiaCombos(cmEAT)
        Select Case TipoUnidad
            Case "V"
                lstEquipo.Clear()
                oeEquipo.Id = "" : oeEquipo.Nombre = "TODOS"
                lstEquipo.Add(oeEquipo)
                oeEquipo = New e_Equipo
                lstEquipo.AddRange(olEquipo.Listar(oeEquipo))
                LlenarComboMaestro(cmEAT, lstEquipo, 0)
            Case "A"
                lstArea = New List(Of e_Area)
                oeArea.Id = "" : oeArea.Nombre = "TODOS"
                lstArea.Add(oeArea)
                oeArea = New e_Area
                lstArea.AddRange(olArea.Listar(oeArea))
                LlenarComboMaestro(cmEAT, lstArea, 0)
            Case "T"
                lstTrabajador.Clear()
                oeTrabajador.Id = "" : oeTrabajador.oePersona.Nombre = "TODOS"
                lstTrabajador.Add(oeTrabajador)
                oeTrabajador = New e_Trabajador
                lstTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))
                Dim _leTrabAux = From le In lstTrabajador Select le.Id, Nombre = le.oePersona.NombreCompleto, le.oePersona.Dni
                'For Each item As e_Trabajador In lstTrabajador
                '    item.oePersona.Nombre = item.oePersona.NombreCompleto
                'Next
                LlenarComboMaestro(cmEAT, _leTrabAux.ToList, 0)
            Case ""
                lstEquipo.Clear()
                oeEquipo.Id = "" : oeEquipo.Nombre = "TODOS"
                lstEquipo.Add(oeEquipo)
                LlenarComboMaestro(cmEAT, lstEquipo, 0)
        End Select
    End Sub

    Private Sub SubAlmacenValueList(ByVal ls_IdAlmacen As String)
        Try
            Dim lstSubAlmacen As New List(Of e_SubAlmacen)
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            Me.grid_UA_Material.DisplayLayout.ValueLists.Clear()
            objValueList = Me.grid_UA_Material.DisplayLayout.ValueLists.Add("SubAlmacenes")
            oeSubAlmacen = New e_SubAlmacen
            oeSubAlmacen.TipoOperacion = "S"
            oeSubAlmacen.Activo = True
            oeSubAlmacen.IdAlmacen = ls_IdAlmacen
            'lstSubAlmacen = olSubAlmacen.Listar_SubAlmacen(oeSubAlmacen)
            Dim dt As DataTable = olSubAlmacen.ComboGrilla(oeSubAlmacen)
            'For Each item As e_SubAlmacen In lstSubAlmacen
            '    objValueList.ValueListItems.Add(dt.Rows(I)
            'Next
            For i As Integer = 0 To dt.Rows.Count - 1
                objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AlmacenValueList(ByVal ls_IdMaterial As String, ByVal stGrilla As UltraWinGrid.UltraGrid)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            stGrilla.DisplayLayout.ValueLists.Clear()
            objValueList = stGrilla.DisplayLayout.ValueLists.Add("Almacenes")

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

    Private Sub AgregarDetalle(ByVal lsId As String)
        Try
            Select Case fcEAT.SelectedTab.Index
                Case 0
                    AgregarEquipo(lsId)
                Case 1
                    AgregarArea(lsId)
                Case 2
                    AgregarTrabajador(lsId)
            End Select
            DetalleMenu()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function BuscaMaterial(ByVal lsId As String) As Boolean
        With ds_UA_MA.Tables(1)
            For i As Integer = 0 To .Rows.Count - 1
                If .Rows(i).Item("IdMaterial").ToString = lsId Then
                    Return True
                End If
            Next
            Return False
        End With
    End Function

    Private Function ObtenerValorUnitario(ByVal idMaterial As String, ByVal idAlmacen As String) As String
        Try
            oeInventario.ValorUnitario = 0.0
            oeInventario.TipoOperacion = 1
            oeInventario.IdMaterial = idMaterial
            oeInventario.IdSubAlmacen = idAlmacen
            oeInventario = olInventario.Obtener(oeInventario)
            Return oeInventario.ValorUnitario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub AgregarMaterial()
        Try
            'Dim lsIdOA_Material As Integer
            'If grid_UA_Material.ActiveRow.Band.Index = 0 Then
            Dim _cant As Integer = 0
            For Each oeMaterial As e_Material In lstMateriales.Where(Function(item) item.Seleccion)
                If BuscaMaterial(oeMaterial.Id) Then
                    oeMaterial.Seleccion = 0
                    grid_Materiales.DataBind()
                    Throw New Exception("Material ya esta Agregado")
                End If
                'lsIdOA_Material = ds_UA_MA.Tables(1).Rows.Count() + 1
                Dim rowMaterial As DataRow
                rowMaterial = ds_UA_MA.Tables(1).NewRow
                rowMaterial("Seleccion") = False
                rowMaterial("IdOrdenAsignacion") = grid_UA_Material.ActiveRow.Cells("IdOrdenAsignacion").Value
                rowMaterial("IdUnidadAsignacion") = grid_UA_Material.ActiveRow.Cells("IdUnidadAsignacion").Value
                rowMaterial("IdMaterial") = oeMaterial.Id
                rowMaterial("Material") = oeMaterial.CodigoNombre
                rowMaterial("TipoUnidad") = ""
                rowMaterial("CantidadMaterial") = 1
                rowMaterial("CantidadMaterialEntregada") = 0
                rowMaterial("CantidadMaterialDevuelto") = 0
                rowMaterial("Stock") = oeMaterial.Stock
                rowMaterial("IdSubAlmacen") = oeMaterial.IdSubAlmacen
                rowMaterial("IdTipoUnidadMedida") = oeMaterial.IdTipoUnidadMedida
                rowMaterial("IdAlmacen") = oeMaterial.IdAlmacen
                rowMaterial("IdUnidadMedida") = oeMaterial.IdUnidadMedida
                rowMaterial("IndUnidadAsignacion") = grid_UA_Material.ActiveRow.Cells("IndUnidadAsignacion").Value
                rowMaterial("IdOA_Material") = "" 'lsIdOA_Material.ToString
                rowMaterial("CostoUnitario") = oeMaterial.Precio
                rowMaterial("IndDescuento") = False
                rowMaterial("MontoDescuento") = 0
                ds_UA_MA.Tables(1).Rows.Add(rowMaterial)
                ds_UA_MA.Tables(1).AcceptChanges()
                oeMaterial.Seleccion = False
                _cant += 1
            Next
            If _cant > 0 Then
                grid_Materiales.DataBind()
                grid_UA_Material.DataBind()
                With grid_UA_Material
                    For i As Integer = 0 To .Rows.Count - 1
                        For Each aChildBand1 As UltraGridChildBand In .Rows(i).ChildBands
                            For Each fila As UltraGridRow In aChildBand1.Rows
                                For y As Integer = 0 To aChildBand1.Rows.Count - 1
                                    UnidadMedidaValueList(aChildBand1.Rows(y).Cells("IdTipoUnidadMedida").Value.ToString, grid_UA_Material)
                                    aChildBand1.Rows(y).Cells("IdUnidadMedida").ValueList = .DisplayLayout.ValueLists("Medidas")

                                    AlmacenValueList(aChildBand1.Rows(y).Cells("IdMaterial").Value.ToString(), grid_UA_Material)
                                    aChildBand1.Rows(y).Cells("IdAlmacen").ValueList = .DisplayLayout.ValueLists("Almacenes")

                                    SubAlmacenValueList(aChildBand1.Rows(y).Cells("IdAlmacen").Value.ToString)
                                    aChildBand1.Rows(y).Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")
                                Next
                            Next
                        Next
                    Next
                End With
            End If

            For x As Integer = 0 To grid_UA_Material.Rows.Count - 1
                Me.grid_UA_Material.Rows(x).ExpandAll()
            Next
            DetalleMenu()
            oeOrdenAsignacion.Modificado = True
            'Else
            'mensajeEmergente.Confirmacion("Seleccione Unidad Asignada para agregar Material")
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarEquipo(ByVal lsId As String)
        Try
            Dim _cant As Integer = 0
            For Each oeEquipo As e_Equipo In lstEquipos.Where(Function(item) item.Id = lsId)
                Dim row As DataRow
                row = ds_UA_MA.Tables(0).NewRow
                row("IdOrdenAsignacion") = ""
                row("Seleccion") = False
                row("IdUnidadAsignacion") = oeEquipo.Id
                row("IndUnidadAsignacion") = "V"
                row("UnidadAsignada") = oeEquipo.Nombre
                row("TipoUnidad") = "Equipo"
                ds_UA_MA.Tables(0).Rows.Add(row)
                ds_UA_MA.Tables(0).AcceptChanges()
                _cant += 1

            Next
            ds_UA_MA.AcceptChanges()
            If _cant > 0 Then
                oeUnidadAsignadaMaterial.Modificado = True
                grid_UA_Material.DataBind()
                griArea.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarArea(ByVal lsID As String)
        Try
            Dim _cant As Integer = 0
            For Each oeArea As e_Area In lstAreas.Where(Function(item) item.Id = lsID)
                Dim row As DataRow
                row = ds_UA_MA.Tables(0).NewRow
                row("IdOrdenAsignacion") = ""
                row("Seleccion") = False
                row("IdUnidadAsignacion") = oeArea.Id
                row("IndUnidadAsignacion") = "A"
                row("UnidadAsignada") = oeArea.Nombre
                row("TipoUnidad") = "Area"
                ds_UA_MA.Tables(0).Rows.Add(row)
                ds_UA_MA.Tables(0).AcceptChanges()
                _cant += 1

            Next
            ds_UA_MA.AcceptChanges()
            If _cant > 0 Then
                oeUnidadAsignadaMaterial.Modificado = True
                grid_UA_Material.DataBind()
                griArea.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarTrabajador(ByVal lsId As String)
        Try
            Dim _cant As Integer = 0
            For Each oeTrabajador As e_Trabajador In lstTrabajadores.Where(Function(item) item.Id = lsId)
                Dim row As DataRow
                row = ds_UA_MA.Tables(0).NewRow
                row("IdOrdenAsignacion") = ""
                row("Seleccion") = False
                row("IdUnidadAsignacion") = oeTrabajador.Id
                row("IndUnidadAsignacion") = "T"
                row("UnidadAsignada") = oeTrabajador.oePersona.NombreCompleto
                row("TipoUnidad") = oeTrabajador.oeCargo.Nombre
                ds_UA_MA.Tables(0).Rows.Add(row)
                ds_UA_MA.Tables(0).AcceptChanges()
                _cant += 1
            Next
            ds_UA_MA.AcceptChanges()
            If _cant > 0 Then
                oeUnidadAsignadaMaterial.Modificado = True
                grid_UA_Material.DataBind()
                griArea.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarDetalle()
        Try
            QuitarUnidadMaterial()
            DetalleMenu()
            oeOrdenAsignacion.Modificado = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarUnidadMaterial()
        Try
            With grid_UA_Material
                Dim sw As Boolean = False
                'For Each matRow As DataRow In ds_UA_MA.Tables(2).Rows
                '    If matRow("Seleccion") Then sw = True
                'Next
                For Each matRow As DataRow In ds_UA_MA.Tables(1).Rows
                    If matRow("Seleccion") Then sw = True
                Next
                For Each matRow As DataRow In ds_UA_MA.Tables(0).Rows
                    If matRow("Seleccion") Then sw = True
                Next
                If Not sw Then
                    Throw New Exception("Marque por lo menos un registro para quitar de lista.")
                End If
                If grid_UA_Material.ActiveRow.Band.Index = 1 Then
                    If .ActiveRow.Cells("CantidadMaterialEntregada").Value <> 0 Then
                        Throw New Exception("No Puede Quitar Materiales Atendidos")
                    End If
                End If

                If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    'For Each matRow As DataRow In ds_UA_MA.Tables(2).Rows
                    '    If matRow("Seleccion") Then
                    '        matRow.Delete()
                    '    End If
                    'Next
                    For Each matRow As DataRow In ds_UA_MA.Tables(1).Rows
                        If matRow("Seleccion") Then
                            matRow.Delete()
                        End If
                    Next
                    For Each matRow As DataRow In ds_UA_MA.Tables(0).Rows
                        If matRow("Seleccion") Then
                            matRow.Delete()
                        End If
                    Next
                    ds_UA_MA.AcceptChanges()
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DetalleMenu()
        fcEAT.Tabs(0).Enabled = IIf(ds_UA_MA.Tables(0).Rows.Count = 0, True, False)
        fcEAT.Tabs(1).Enabled = IIf(ds_UA_MA.Tables(0).Rows.Count = 0, True, False)
        fcEAT.Tabs(2).Enabled = IIf(ds_UA_MA.Tables(0).Rows.Count = 0, True, False)
        fcEAT.Tabs(3).Enabled = IIf(ds_UA_MA.Tables(0).Rows.Count = 0, False, True)
        mnDetalle.Tools("Agregar").SharedProps.Enabled = IIf(ds_UA_MA.Tables(0).Rows.Count = 1, True, False)
        mnDetalle.Tools("Quitar").SharedProps.Enabled = IIf(ds_UA_MA.Tables(0).Rows.Count = 1, True, False)
        If ds_UA_MA.Tables(0).Rows.Count = 0 Then
            fcEAT.Tabs(0).Selected = True
        Else
            fcEAT.Tabs(3).Selected = True
        End If
    End Sub

    Private Sub ListarAreas(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeArea = New e_Area
            oeArea.Activo = Activo
            If lstAreas.Count = 0 Then
                lstAreas = olArea.Listar(oeArea)
            End If
            With griArea
                .DataSource = lstAreas
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListarEquipos(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeEquipo = New e_Equipo
            With griEquipos
                If lstEquipos.Count = 0 Then
                    oeEquipo.TipoOperacion = "O"
                    oeEquipo.Activo = Activo
                    lstEquipos = olEquipo.Listar(oeEquipo)
                End If
                oeEquipo.Activo = Activo
                .DataSource = lstEquipos
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListarTrabajadores()
        Try
            Me.Cursor = Cursors.WaitCursor
            With griTrabajadores
                Dim oeTrab As New e_Trabajador
                Dim olTrab As New l_Trabajador
                oeTrab.Activo = True
                lstTrabajadores = olTrab.Listar(oeTrab)
                Dim _leTrab = From le In lstTrabajadores _
                              Select le.Id, le.oePersona.Dni, le.oePersona.NombreCompleto, Area = le.oeArea.Nombre, Cargo = le.oeCargo.Nombre

                .DataSource = _leTrab.ToList

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Id").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True

                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 250
                .DisplayLayout.Bands(0).Columns("Area").Width = 200
                .DisplayLayout.Bands(0).Columns("Cargo").Width = 150

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                '.DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub ListarMateriales()
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If Not String.IsNullOrEmpty(Trim(txtBuscarMateriales.Text)) Then
                Select Case optBusqueda.CheckedIndex
                    Case 0 : oeMaterial.Codigo = txtBuscarMateriales.Text
                    Case 1 : oeMaterial.Nombre = txtBuscarMateriales.Text
                End Select
                oeMaterial.TipoOperacion = "5"
                oeMaterial.Tipo = 1
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

    Private Sub ListarUnidadAsignada_Material(ByVal ls_IdOrdenAsignacion As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            oeUnidadAsignadaMaterial = New e_OrdenAsignacion_Material
            oeUnidadAsignadaMaterial.TipoOperacion = "1"
            oeUnidadAsignadaMaterial.Activo = True
            oeUnidadAsignadaMaterial.IdOrdenAsignacion = ls_IdOrdenAsignacion

            ds_UA_MA = olUnidadAsignadaMaterial.ListarUnidadAsignadaMaterial(oeUnidadAsignadaMaterial)
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) UnidadAsignacion
            'Tabla(1) Material
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim parentCol As DataColumn = ds_UA_MA.Tables(0).Columns("IdUnidadAsignacion")
            Dim childCol As DataColumn = ds_UA_MA.Tables(1).Columns("IdUnidadAsignacion")
            relation = New DataRelation("FK_Relacion", parentCol, childCol, True)
            ds_UA_MA.Relations.Add(relation)

            ds_UA_MA.AcceptChanges()
            grid_UA_Material.DataSource = ds_UA_MA
            With grid_UA_Material.DisplayLayout
                'ocultar
                .Bands(0).Columns("IdOrdenAsignacion").Hidden = True
                .Bands(0).Columns("Id_Unidad").Hidden = True
                .Bands(0).Columns("IdUnidadAsignacion").Hidden = True
                .Bands(0).Columns("IndUnidadAsignacion").Hidden = True
                .Bands(1).Columns("IdOrdenAsignacion").Hidden = True
                .Bands(1).Columns("IdUnidadAsignacion").Hidden = True
                .Bands(1).Columns("IndUnidadAsignacion").Hidden = True
                'If .BAND
                .Bands(1).Columns("Almacen").Hidden = True
                .Bands(1).Columns("IdMaterial").Hidden = True
                '.Bands(1).Columns("IdSubAlmacen").Hidden = True
                .Bands(0).Columns("IdTipoUnidadMedida").Hidden = True
                .Bands(1).Columns("IdTipoUnidadMedida").Hidden = True
                .Bands(1).Columns("IdOA_Material").Hidden = True
                .Bands(1).Columns("CostoUnitario").Hidden = True
                .Bands(1).Columns("CantAux").Hidden = True
                If Operacion = "Nuevo" Then
                    .Bands(0).Columns("IndDescuento").Hidden = True
                    .Bands(0).Columns("MontoDescuento").Hidden = True
                    .Bands(1).Columns("IndDescuento").Hidden = True
                    .Bands(1).Columns("MontoDescuento").Hidden = True
                Else
                    .Bands(0).Columns("IndDescuento").Hidden = False
                    .Bands(0).Columns("MontoDescuento").Hidden = False
                    .Bands(1).Columns("IndDescuento").Hidden = False
                    .Bands(1).Columns("MontoDescuento").Hidden = False
                End If
                .Bands(1).Columns("CantidadMaterial").MaskInput = "{double:9.4}"
                .Bands(1).Columns("CantidadMaterialEntregada").MaskInput = "{double:9.4}"
                .Bands(1).Columns("CantidadMaterialDevuelto").MaskInput = "{double:9.4}"
                .Bands(1).Columns("Stock").MaskInput = "{double:9.4}"
                .Bands(1).Columns("MontoDescuento").MaskInput = "{double:9.4}"
                .Bands(1).Columns("Stock").CellAppearance.TextHAlign = HAlign.Right

                .Bands(1).Columns("CantidadMaterial").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("CantidadMaterialEntregada").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("CantidadMaterialDevuelto").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoDescuento").CellAppearance.TextHAlign = HAlign.Right


                .Bands(0).Columns("Seleccion").Style = ColumnStyle.CheckBox
                .Bands(1).Columns("Seleccion").Style = ColumnStyle.CheckBox
                .Bands(1).Columns("IdUnidadMedida").Style = ColumnStyle.DropDownList
                .Bands(1).Columns("IdAlmacen").Style = ColumnStyle.DropDownList
                .Bands(1).Columns("IdSubAlmacen").Style = ColumnStyle.DropDownList
                '.Bands(1).Columns("CantidadMaterial").Style = ColumnStyle.IntegerWithSpin

                .Bands(0).Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Bands(1).Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Bands(1).Columns("CantidadMaterial").CellClickAction = CellClickAction.EditAndSelectText
                .Bands(1).Columns("CantidadMaterialDevuelto").CellActivation = Activation.NoEdit
                .Bands(1).Columns("CantidadMaterialEntregada").CellActivation = Activation.NoEdit
                .Bands(1).Columns("IdAlmacen").CellClickAction = CellClickAction.Edit
                If Not ValidarPermisoReq() Then
                    .Bands(1).Columns("IndDescuento").CellActivation = Activation.NoEdit
                    .Bands(1).Columns("IndDescuento").CellClickAction = CellClickAction.RowSelect
                    .Bands(1).Columns("MontoDescuento").CellClickAction = CellClickAction.RowSelect
                Else
                    .Bands(1).Columns("IndDescuento").CellActivation = Activation.AllowEdit
                    .Bands(1).Columns("IndDescuento").CellClickAction = CellClickAction.Edit
                    .Bands(1).Columns("MontoDescuento").CellClickAction = CellClickAction.EditAndSelectText
                End If
                
                .Bands(0).Columns("Seleccion").Width = 15
                .Bands(1).Columns("Seleccion").Width = 15
                .Bands(0).Columns("UnidadAsignada").Width = 280
                .Bands(0).Columns("TipoUnidad").Width = 65
                .Bands(1).Columns("IdUnidadMedida").Width = 65
                .Bands(0).Columns("CantidadMaterial").Width = 50
                .Bands(1).Columns("IndDescuento").Width = 50
                .Bands(1).Columns("MontoDescuento").Width = 100
                .Bands(0).Columns("CantidadMaterialEntregada").Width = 80
                .Bands(0).Columns("CantidadMaterialDevuelto").Width = 85
                .Bands(1).Columns("CantidadMaterial").Width = 50
                .Bands(1).Columns("CantidadMaterialEntregada").Width = 80
                .Bands(1).Columns("CantidadMaterialDevuelto").Width = 85
                .Bands(0).Columns("IdAlmacen").Width = 150
                .Bands(0).Columns("Almacen").Width = 150
                .Bands(1).Columns("IdAlmacen").Width = 150
                .Bands(1).Columns("Almacen").Width = 150
                .Bands(0).Columns("IdSubAlmacen").Width = 150
                .Bands(1).Columns("IdSubAlmacen").Width = 150
                .Bands(1).ColHeadersVisible = False
            End With
            If ds_UA_MA.Tables(1).Rows.Count > 0 Then
                grid_UA_Material.DataBind()
                With grid_UA_Material
                    For i As Integer = 0 To .Rows.Count - 1
                        For Each aChildBand1 As UltraGridChildBand In .Rows(i).ChildBands
                            For Each fila As UltraGridRow In aChildBand1.Rows
                                For y As Integer = 0 To aChildBand1.Rows.Count - 1
                                    UnidadMedidaValueList(aChildBand1.Rows(y).Cells("IdTipoUnidadMedida").Value.ToString, grid_UA_Material)
                                    aChildBand1.Rows(y).Cells("IdUnidadMedida").ValueList = .DisplayLayout.ValueLists("Medidas")

                                    AlmacenValueList(aChildBand1.Rows(y).Cells("IdMaterial").Value.ToString(), grid_UA_Material)
                                    aChildBand1.Rows(y).Cells("IdAlmacen").ValueList = .DisplayLayout.ValueLists("Almacenes")

                                    SubAlmacenValueList(aChildBand1.Rows(y).Cells("IdAlmacen").Value.ToString)
                                    aChildBand1.Rows(y).Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")
                                Next
                            Next
                        Next
                    Next
                End With
            End If
            For x As Integer = 0 To grid_UA_Material.Rows.Count - 1
                grid_UA_Material.Rows(x).ExpandAll()
            Next

        Catch ex As Exception
            Throw ex
        Finally
            grid_UA_Material.Focus()
        End Try
    End Sub

    Sub Visualizar(ByVal lb_Ok As Boolean)
        agrDatoGeneral.Enabled = lb_Ok
        mnDetalle.Visible = lb_Ok
    End Sub

    Private Sub MostrarOrden()
        Try
            With grid_OA
                If .ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                    oeOrdenAsignacion.Id = .ActiveRow.Cells("Id").Value.ToString
                    oeOrdenAsignacion = olOrdenAsignacion.Obtener(oeOrdenAsignacion)
                    oeOrdenAsignacion.Activo = True
                    dtpFecha.Value = oeOrdenAsignacion.Fecha
                    txtGlosa.Text = oeOrdenAsignacion.Glosa
                    txtNroOA.Text = oeOrdenAsignacion.NroOA
                    txtEstado.Text = oeOrdenAsignacion.EstadoOA
                    ListarUnidadAsignada_Material(oeOrdenAsignacion.Id)
                    MostrarTabs(1, tcOA, 1)
                    Select Case oeOrdenAsignacion.EstadoOA
                        Case "GENERADA"
                            Visualizar(1)
                            Me.mnDetalle.Tools("Agregar").SharedProps.Visible = True
                            Me.mnDetalle.Tools("Quitar").SharedProps.Visible = True
                            Me.mnDetalle.Tools("Devolucion").SharedProps.Visible = False
                            Me.mnDetalle.Tools("Actualizar").SharedProps.Visible = False
                        Case "EN PROCESO"
                            Visualizar(1)
                            Me.mnDetalle.Tools("Agregar").SharedProps.Visible = True
                            Me.mnDetalle.Tools("Quitar").SharedProps.Visible = True
                            Me.mnDetalle.Tools("Devolucion").SharedProps.Visible = True
                            Me.mnDetalle.Tools("Actualizar").SharedProps.Visible = True
                        Case "TERMINADA"
                            Me.mnDetalle.Visible = True
                            Me.mnDetalle.Tools("Agregar").SharedProps.Visible = False
                            Me.mnDetalle.Tools("Quitar").SharedProps.Visible = False
                            Me.mnDetalle.Tools("Devolucion").SharedProps.Visible = True
                            Me.mnDetalle.Tools("Actualizar").SharedProps.Visible = True
                    End Select
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub TransponerUnidadAsignada()
        oeOrdenAsignacion.lstUnidadAsignada.Clear()
        For Each matRow As DataRow In ds_UA_MA.Tables(0).Rows
            oeUnidadAsignada = New e_OrdenAsignacion_UnidadAsignacion
            oeUnidadAsignada.Id = IIf(IsDBNull(matRow("Id_Unidad")), "", matRow("Id_Unidad"))
            oeUnidadAsignada.IdOrdenAsignacion = matRow("IdOrdenAsignacion")
            oeUnidadAsignada.IndUnidadAsignacion = matRow("IndUnidadAsignacion")
            oeUnidadAsignada.IdUnidadAsignacion = matRow("IdUnidadAsignacion")
            oeOrdenAsignacion.lstUnidadAsignada.Add(oeUnidadAsignada)
        Next
    End Sub

    Private Sub TransponerMaterial()
        oeOrdenAsignacion.lstUnidadAsignadaMat.Clear()
        For Each matRow As DataRow In ds_UA_MA.Tables(1).Rows
            oeUnidadAsignadaMaterial = New e_OrdenAsignacion_Material
            With oeUnidadAsignadaMaterial
                .Id = matRow("IdOA_Material")
                .IdOrdenAsignacion = matRow("IdOrdenAsignacion")
                .IdMaterial = matRow("IdMaterial")
                .IndUnidadAsignacion = matRow("IndUnidadAsignacion")
                .IdUnidadAsignacion = matRow("IdUnidadAsignacion")
                .IdUnidadMedida = matRow("IdUnidadMedida")
                .CantidadMaterial = matRow("CantidadMaterial")
                .CostoUnitario = matRow("CostoUnitario")
                .CantidadMaterialEntregada = matRow("CantidadMaterialEntregada")
                .CantidadMaterialDevuelto = matRow("CantidadMaterialDevuelto")
                .IdSubAlmacen = matRow("IdSubAlmacen")
                .Material = matRow("Material")
                .IndDescuento = IIf(.IndUnidadAsignacion = "T", matRow("IndDescuento"), 0)
                .MontoDescuento = IIf(.IndUnidadAsignacion = "T", matRow("MontoDescuento"), 0)
                .CantAux = IIf(String.IsNullOrEmpty(matRow("CantAux").ToString), 0, matRow("CantAux").ToString)
                .UsuarioCreacion = gUsuarioSGI.Id
            End With        
            oeOrdenAsignacion.lstUnidadAsignadaMat.Add(oeUnidadAsignadaMaterial)
        Next
    End Sub

    Public Sub Verificar_SubAlmacen(ByVal ls_TipoReferencia As String, ByVal oeRequerimiento As e_Requerimiento)
        Try
            oeSubAlmacenIngreso = New e_SubAlmacen
            oeSubAlmacenIngreso.Activo = True
            oeSubAlmacenIngreso.TipoOperacion = "5"
            oeSubAlmacenIngreso.TipoReferencia = ls_TipoReferencia
            oeSubAlmacenIngreso.IdOrdenAsignacion = oeOrdenAsignacion.Id
            oeSubAlmacenIngreso = olSubAlmacen.Obtener(oeSubAlmacenIngreso)
            If oeSubAlmacenIngreso.Id Is Nothing Then
                GuardarAlmacen(ls_TipoReferencia, True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Verificar_MaterialAlmacen(ByVal listaMateriles As List(Of e_OrdenAsignacion_Material))
        Try
            lstMaterialesAlmacen = New List(Of e_MaterialAlmacen)
            For Each oeOAM As e_OrdenAsignacion_Material In listaMateriles
                oeMaterial_Almacen = New e_MaterialAlmacen
                oeMaterial_Almacen.TipoOperacion = "S"
                oeMaterial_Almacen.IdAlmacen = oeSubAlmacenIngreso.IdAlmacen
                oeMaterial_Almacen.IdMaterial = oeOAM.IdMaterial
                oeMaterial_Almacen.StockMinimo = 1
                oeMaterial_Almacen.StockMaximo = 1
                oeMaterial_Almacen.IdZona = ""
                oeMaterial_Almacen.UsuarioCreacion = gUsuarioSGI.Id
                oeMaterial_Almacen.PrefijoID = gs_PrefijoIdSucursal '@0001
                lstMaterialesAlmacen.Add(oeMaterial_Almacen)
            Next
            olMaterialAlmacen.Guardar(lstMaterialesAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GuardarAlmacen(Tipo As String, IndGuardar As Boolean)
        Try
            Dim oeComboAux As New e_Combo
            Select Case Tipo
                Case "V"
                    oeSubAlmacenIngreso.IdEquipo = oeRequerimiento.IdEquipo
                    Dim oeEqu As New e_Equipo
                    Dim olEqu As New l_Equipo
                    oeEqu.TipoOperacion = "S"
                    oeEqu.Id = oeRequerimiento.IdEquipo
                    oeEqu = olEqu.Obtener(oeEqu)
                    If oeEqu.Marca = "C" Then
                        oeSubAlmacenIngreso.IdAlmacen = "1CH000000009"
                    Else
                        If oeEqu.Modelo = "1" Then
                            oeSubAlmacenIngreso.IdAlmacen = "1CH000000008"
                        Else
                            oeSubAlmacenIngreso.IdAlmacen = "1CH000000024"
                        End If
                    End If
                    oeSubAlmacenIngreso.Descripcion = oeEqu.Nombre
                Case "A"
                    oeComboAux = New e_Combo
                    oeComboAux.Tipo = 1
                    oeComboAux.Id = oeRequerimiento.IdArea
                    If AreasPublic.Contains(oeComboAux) Then
                        oeComboAux = AreasPublic.Item(AreasPublic.IndexOf(oeComboAux))
                    End If
                    oeSubAlmacenIngreso.IdArea = oeComboAux.Id
                    oeSubAlmacenIngreso.Descripcion = oeComboAux.Nombre
                    oeSubAlmacenIngreso.IdAlmacen = "1CH000000026"
                Case "T"
                    oeComboAux = New e_Combo
                    oeComboAux.Id = oeRequerimiento.IdTrabajador
                    oeComboAux.Tipo = 1
                    If TrabajadorPublic.Contains(oeComboAux) Then
                        oeComboAux = TrabajadorPublic.Item(TrabajadorPublic.IndexOf(oeComboAux))
                    End If
                    oeSubAlmacenIngreso.IdTrabajador = oeComboAux.Id
                    oeSubAlmacenIngreso.Descripcion = oeComboAux.Nombre
                    oeSubAlmacenIngreso.IdAlmacen = "1CH000000010"
            End Select
            If IndGuardar Then
                oeSubAlmacenIngreso.TipoOperacion = "I"
                oeSubAlmacenIngreso.Codigo = ""
                oeSubAlmacenIngreso.UsuarioCreacion = gUsuarioSGI.Id
                oeSubAlmacenIngreso.PrefijoID = gs_PrefijoIdSucursal '@0001
                olSubAlmacen.Guardar(oeSubAlmacenIngreso)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GenerarRequerimiento()
        Try
            lstRequerimiento = New List(Of e_Requerimiento)
            For Each item As e_OrdenAsignacion_UnidadAsignacion In oeOrdenAsignacion.lstUnidadAsignada
                oeRequerimiento = New e_Requerimiento
                oeRequerimiento.TipoOperacion = "I"
                oeRequerimiento.Id = ""
                oeRequerimiento.Codigo = ""
                oeRequerimiento.FechaAtencion = Date.Today
                oeRequerimiento.Descripcion = oeOrdenAsignacion.UnidadAsignada & " / " & "ASIGNACION DE MATERIALES"
                oeRequerimiento.TipoReferencia = "ORDEN ASIGNACION"
                oeRequerimiento.IdReferencia = oeOrdenAsignacion.Id
                oeRequerimiento.UsuarioCreacion = gUsuarioSGI.Id
                oeRequerimiento.Activo = True
                oeRequerimiento.MaterialServicio = "M"
                oeRequerimiento.FechaAtencion = Date.Parse("01/01/1901")
                Select Case item.IndUnidadAsignacion
                    Case "V"
                        oeRequerimiento.IdEquipo = item.IdUnidadAsignacion
                    Case "A"
                        oeRequerimiento.IdArea = item.IdUnidadAsignacion
                    Case "T"
                        oeRequerimiento.IdTrabajador = item.IdUnidadAsignacion
                End Select
                oeEstadoRequerimiento = New e_EstadoRequerimiento
                oeEstadoRequerimiento.Activo = True
                oeEstadoRequerimiento.Nombre = "EVALUADO"
                oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)
                oeRequerimiento.IdEstadoRequerimiento = oeEstadoRequerimiento.Id
                oeRequerimiento.lstRequerimientoMaterial = TransponerDetalleMaterialRequerimiento(oeRequerimiento)
                Verificar_SubAlmacen(item.IndUnidadAsignacion, oeRequerimiento)
                oeRequerimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                lstRequerimiento.Add(oeRequerimiento)
            Next
            olRequerimiento.GuardarLista(lstRequerimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function TransponerDetalleMaterialRequerimiento(ByVal oeReq As e_Requerimiento) As List(Of e_RequerimientoMaterial)
        Try
            Dim Fecha As Date = ObtenerFechaServidor()
            oeReq.lstRequerimientoMaterial = New List(Of e_RequerimientoMaterial)
            oeEstadoRequerimiento = New e_EstadoRequerimiento
            oeEstadoRequerimiento.Nombre = "APROBADO"
            oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)
            For Each item As e_OrdenAsignacion_Material In oeOrdenAsignacion.lstUnidadAsignadaMat
                oeDetReq = New e_RequerimientoMaterial
                oeDetReq.IdMaterial = item.IdMaterial
                oeDetReq.IdSubAlmacen = item.IdSubAlmacen
                oeDetReq.UsuarioCreacion = gUsuarioSGI.Id
                oeDetReq.IdUnidadMedida = item.IdUnidadMedida
                oeDetReq.Precio = item.CostoUnitario * (1 + oeIGV.Porcentaje)
                oeDetReq.Cantidad = item.CantidadMaterial
                oeDetReq.IdCentroCosto = ""
                oeDetReq.IdEstadoRequerimientoMaterial = oeEstadoRequerimiento.Id
                oeDetReq.IdOrdenAsignacionMaterial = item.Id
                If item.IndDescuento And item.IndUnidadAsignacion = "T" Then
                    oeDetReq.oeSancion = New e_Sancion
                    With oeDetReq.oeSancion
                        .TipoOperacion = "I"
                        .IdTrabajador = item.IdUnidadAsignacion
                        .IdArea = gUsuarioSGI.oeArea.Id
                        .IdConcepto = "1CH000017"
                        .IdResponsable = gUsuarioSGI.IdTrabajador
                        If item.MontoDescuento = 0 Then Throw New Exception("El Monto de Descuento Tiene que ser Mayor a 0. Verificar")
                        .Monto = item.MontoDescuento
                        .Glosa = "IMPLEMENTO: " & item.Material & ". ASIGNADO AL TRABAJADOR."
                        .NroCuota = 1
                        .Fecha = Fecha
                        .Activo = True
                        .FechaCreacion = Fecha
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .IdGrupo = ObtenerGrupoDsct(.IdArea)
                        .IdEstado = "1CH00016"
                    End With
                End If
                oeReq.lstRequerimientoMaterial.Add(oeDetReq)
            Next
            Return oeReq.lstRequerimientoMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarOrdenAsignacion() As Boolean
        Try
            oeOrdenAsignacion.Fecha = Me.dtpFecha.Value
            oeOrdenAsignacion.Glosa = Trim(Me.txtGlosa.Text)
            If oeOrdenAsignacion.TipoOperacion = "A" Then
                If oeOrdenAsignacion.IdUsuario <> gUsuarioSGI.Id Then Throw New Exception("No puede Modificar una OA generada por Otro Usuario")
            End If
            oeOrdenAsignacion.IdUsuario = gUsuarioSGI.Id
            TransponerUnidadAsignada()
            TransponerMaterial()
            If oeOrdenAsignacion.TipoOperacion = "T" Then
                oeOrdenAsignacion.lstUnidadAsignadaMat.ForEach(AddressOf obtenerCantidadTotalAtender)
                If cantTotalAtender <> 0 Then
                    Throw New Exception("Todo los Materiales deben ser Atendidos para Terminar la OA.")
                End If
                cantTotalAtender = 1
            End If
            If VerificarCambios(oeOrdenAsignacion.Id) Then Throw New Exception("Orden Actualizada Verificar")
            oeOrdenAsignacion.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olOrdenAsignacion.Guardar(oeOrdenAsignacion) Then Return False
            Select Case oeOrdenAsignacion.TipoOperacion
                Case "I"
                    mensajeEmergente.Confirmacion("La información se grabado satisfactoriamente se genero la OA N°: " & oeOrdenAsignacion.NroOA, True)
                Case "A"
                    oeUnidadAsignada.PrefijoID = gs_PrefijoIdSucursal '@0001
                    GuardarAlmacen(oeUnidadAsignada.IndUnidadAsignacion, False)
                    Verificar_MaterialAlmacen(oeOrdenAsignacion.lstUnidadAsignadaMat)
                    mensajeEmergente.Confirmacion("La información se actualizo satisfactoriamente.", True)
                Case "S"
                    GenerarRequerimiento()
                    Verificar_MaterialAlmacen(oeOrdenAsignacion.lstUnidadAsignadaMat)
                    mensajeEmergente.Confirmacion("La OA N°: " & oeOrdenAsignacion.NroOA & " Genero Requerimiento", True)
                Case "T"
                    mensajeEmergente.Confirmacion("La OA N°: " & oeOrdenAsignacion.NroOA & " Termino", True)
            End Select
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function VerificarCambios(IdOA) As Boolean
        Try
            If IdOA <> "" Then
                Dim oe As New e_OrdenAsignacion_Material
                Dim ol As New l_OrdenAsignacion_Material
                Dim lo As New List(Of e_OrdenAsignacion_Material)
                oe.IdOrdenAsignacion = IdOA
                oe.TipoOperacion = ""
                oe.FechaCreacion = Date.Parse("01/01/1901")
                lo.AddRange(ol.Listar(oe))
                For Each eos As e_OrdenAsignacion_Material In lo
                    For Each det As e_OrdenAsignacion_Material In oeOrdenAsignacion.lstUnidadAsignadaMat.Where(Function(i) i.IdMaterial = eos.IdMaterial).ToList
                        If eos.CantidadMaterialEntregada <> det.CantidadMaterialEntregada Then
                            Return True
                        End If
                    Next
                Next
            End If    
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub AnularOA(ByVal ls_IdOA As String)
        Try
            oeOrdenAsignacion = New e_OrdenAsignacion
            oeOrdenAsignacion.Id = ls_IdOA
            oeOrdenAsignacion = olOrdenAsignacion.Obtener(oeOrdenAsignacion)
            If oeOrdenAsignacion.EstadoOA = "EN PROCESO" Or oeOrdenAsignacion.EstadoOA = "GENERADA" Then
                oeUnidadAsignadaMaterial = New e_OrdenAsignacion_Material
                oeUnidadAsignadaMaterial.IdOrdenAsignacion = oeOrdenAsignacion.Id
                oeUnidadAsignadaMaterial.TipoOperacion = "T"
                oeUnidadAsignadaMaterial.Activo = 1
                oeUnidadAsignadaMaterial.FechaCreacion = Date.Now
                If olUnidadAsignadaMaterial.Listar(oeUnidadAsignadaMaterial).Count = 0 Then
                    If MessageBox.Show("Esta seguro de anular la Orden Asignacion : " & _
                    oeOrdenAsignacion.NroOA & " ?", _
                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeOrdenAsignacion.TipoOperacion = "X"
                        olOrdenAsignacion.Eliminar(oeOrdenAsignacion)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La OA ya contiene materiales atendidos, no se puede ANULAR.")
                End If
            Else
                Throw New Exception("Solo se pueden anular Ordenes de Asignacion en estado EN PROCESO sin atender.")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub obtenerCantidadTotalAtender(ByVal oeOrdAsigMat As e_OrdenAsignacion_Material)
        Try
            Dim cantmat As Double = 0
            Dim cantent As Double = 0
            cantmat += oeOrdAsigMat.CantidadMaterial
            cantent += oeOrdAsigMat.CantidadMaterialEntregada
            cantTotalAtender = cantmat - cantent
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarPermisoReq() As Boolean
        Try
            oeOcupacionTrabajador = New e_OcupacionTrabajador
            oeOcupacionTrabajador.IdTrabajador = gUsuarioSGI.IdTrabajador
            oeOcupacionTrabajador.Principal = 1
            oeOcupacionTrabajador = olOcupacionTrabajador.Obtener(oeOcupacionTrabajador)
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "APROBACION DE REQUERIMIENTOS") Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub GenerarDevolucionMaterial()
        Try
            If ValidarGrilla(grid_UA_Material, "Materiales") Then
                Dim oeOrdenIngreso As New e_Orden, olOrdenIngreso As New l_Orden
                Dim lstDetalleOrdenIngreso As New List(Of e_OrdenMaterial)
                Dim oeMovimientoInventario As New e_MovimientoInventario, olMovimientoInvetario As New l_MovimientoInventario
                Dim oeMoneda As New e_Moneda, olMoneda As New l_Moneda
                Dim oeTipoOrden As New e_TipoOrden, olTipoOrden As New l_TipoOrden
                Dim oeOrdAsiMat, oeUAOrdAsiMat As New e_OrdenAsignacion_Material
                Dim olOrdAsiMat As New l_OrdenAsignacion_Material
                With grid_UA_Material
                    If .ActiveRow.Band.Index = 1 Then
                        If fn_VerificarExistenciaOIxMantDev() Then Exit Sub
                        If .ActiveRow.Cells("CantidadMaterialEntregada").Value = 0 Then Throw New Exception("No tiene Cantidad Entregada. No Puede Devolver")
                        oeOrdAsiMat.Id = .ActiveRow.Cells("IdOA_Material").Value
                        oeOrdAsiMat = olOrdAsiMat.Obtener(oeOrdAsiMat)
                        If .ActiveRow.Cells("CantidadMaterial").Value = oeOrdAsiMat.CantidadMaterial And .ActiveRow.Cells("CantidadMaterialDevuelto").Value = oeOrdAsiMat.CantidadMaterialDevuelto And .ActiveRow.Cells("CantidadMaterialEntregada").Value = oeOrdAsiMat.CantidadMaterialEntregada Then
                            If .ActiveRow.Cells("CantidadMaterial").Value = .ActiveRow.Cells("CantidadMaterialDevuelto").Value Then Throw New Exception("No se puede devolver mas de lo que se entrego")
                            Dim o_Frm As New frm_DevolucionMaterial
                            If o_Frm.CargarDatosMaterial(.ActiveRow.Cells("IdMaterial").Value.ToString, .ActiveRow.Cells("CantidadMaterialEntregada").Value - .ActiveRow.Cells("CantidadMaterialDevuelto").Value) Then
                                If o_Frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                    oeDetalleOrdenIngreso = New e_OrdenMaterial
                                    oeDetalleOrdenIngreso.Activo = True
                                    oeDetalleOrdenIngreso.IdMaterial = .ActiveRow.Cells("IdMaterial").Value.ToString
                                    oeDetalleOrdenIngreso.Material = .ActiveRow.Cells("Material").Value.ToString
                                    oeDetalleOrdenIngreso.CantidadMaterial = CDbl(o_Frm.ndCantidad.Value)
                                    oeDetalleOrdenIngreso.PrecioUnitario = Math.Round(.ActiveRow.Cells("CostoUnitario").Value * (1 + oeIGVGlobal.Porcentaje), 4)
                                    oeDetalleOrdenIngreso.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value.ToString
                                    oeDetalleOrdenIngreso.IdSubAlmacen = .ActiveRow.Cells("IdSubAlmacen").Value.ToString
                                    oeDetalleOrdenIngreso.IdTipoUnidadMedida = .ActiveRow.Cells("IdTipoUnidadMedida").Value.ToString
                                    oeDetalleOrdenIngreso.IdUnidadMedida = .ActiveRow.Cells("IdUnidadMedida").Value.ToString
                                    oeDetalleOrdenIngreso.UnidadMedida = ""
                                    oeDetalleOrdenIngreso.TipoReferencia = "OA"
                                    oeDetalleOrdenIngreso.IdReferencia = .ActiveRow.Cells("IdOA_Material").Value.ToString
                                    oeDetalleOrdenIngreso.ValorVenta = Math.Round(oeDetalleOrdenIngreso.PrecioUnitario * oeDetalleOrdenIngreso.CantidadMaterial, 4)
                                    lstDetalleOrdenIngreso.Add(oeDetalleOrdenIngreso)

                                    oeOrdenIngreso.lstOrdenMaterial = lstDetalleOrdenIngreso
                                    oeOrdenIngreso.Activo = True
                                    oeOrdenIngreso.Total = CDbl(o_Frm.ndCantidad.Value)
                                    '---------------------------------------
                                    oeOrdenIngreso.IdTipoOrden = "1CH000000001" ' "ORDEN DE INGRESO"
                                    '---------------------------------------
                                    oeOrdenIngreso.IdMovimientoInventario = "1CH000000018" ' "DEVOLUCION"
                                    '---------------------------------------
                                    oeOrdenIngreso.IdMoneda = "1CH01" ' Soles
                                    '---------------------------------------
                                    Dim UnidadAsignada As String = ""
                                    Dim TipoUnidad As String = ""
                                    UnidadAsignada = .ActiveRow.ParentRow.Cells("UnidadAsignada").Value.ToString
                                    TipoUnidad = .ActiveRow.ParentRow.Cells("TipoUnidad").Value.ToString()
                                    oeOrdenIngreso.Glosa = TipoUnidad & " / " & UnidadAsignada
                                    oeOrdenIngreso.IdProveedor = ISL_IdProveedor
                                    oeOrdenIngreso.FechaOrden = Date.Now
                                    oeOrdenIngreso.TipoOperacion = "I"
                                    oeOrdenIngreso.IdSubAlmacenDestino = ""
                                    oeOrdenIngreso.IdSubAlmacenOrigen = ""
                                    oeOrdenIngreso.TipoReferencia = "ORDEN ASIGNACION"
                                    oeOrdenIngreso.Referencia = oeOrdenAsignacion.NroOA
                                    oeOrdenIngreso.UsuarioCreacion = gUsuarioSGI.Id
                                    oeOrdenIngreso.PrefijoID = gs_PrefijoIdSucursal '@0001
                                    If olOrdenIngreso.Guardar(oeOrdenIngreso, New List(Of e_RegistroInventario)) Then mensajeEmergente.Confirmacion("Devolucion Generada", True)
                                End If
                            Else
                                Throw New Exception("El Material se encuentra eliminado")
                            End If
                        Else
                            Throw New Exception("El Registro ha Sido Modificado. Actualizar")
                        End If

                    Else
                        Throw New Exception("Selecccione un Material para generar una devolucion.")
                    End If
                End With
            End If
            If oeOrdenAsignacion.EstadoOA = gNombreEstadoTerminada Then
                MyBase.Vista()
            Else
                ControlBoton(0, 0, 0, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function fn_VerificarExistenciaOIxMantDev() As Boolean
        Try
            oeDetalleOrdenIngreso = New e_OrdenMaterial
            oeDetalleOrdenIngreso.Activo = True
            oeDetalleOrdenIngreso.TipoOperacion = "V"
            oeDetalleOrdenIngreso.IdMaterial = grid_UA_Material.ActiveRow.Cells("IdMaterial").Value.ToString
            oeDetalleOrdenIngreso.TipoReferencia = "OA"
            oeDetalleOrdenIngreso.IdReferencia = grid_UA_Material.ActiveRow.Cells("IdOA_Material").Value.ToString
            If olDetalleOrdenIngreso.Listar(oeDetalleOrdenIngreso).Count > 0 Then
                mensajeEmergente.Problema("Existe una Orden de Ingreso (" & olDetalleOrdenIngreso.Listar(oeDetalleOrdenIngreso)(0).NroOrden.ToString & ") por devolucion de este material sin ejecutar", True)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub MostrarDetalle()
        Try
            oeSubAlmacenIngreso = New e_SubAlmacen
            oeSubAlmacenIngreso.Activo = True
            oeSubAlmacenIngreso.TipoOperacion = "5"
            oeSubAlmacenIngreso.TipoReferencia = "T"
            oeSubAlmacenIngreso.IdOrdenAsignacion = oeOrdenAsignacion.Id
            oeSubAlmacenIngreso = olSubAlmacen.Obtener(oeSubAlmacenIngreso)
            dsRegistroInv = New DataSet
            dsRegistroInv = ObtenerDetalleAsignacion("", "")
            grReg_Inv.DataSource = dsRegistroInv
            dsRegistroInv = ObtenerDetalleAsignacion(grid_UA_Material.ActiveRow.Cells("IdMaterial").Value, oeSubAlmacenIngreso.Id)
            grReg_Inv.DataSource = dsRegistroInv
            ficHistorialMaterial.Tabs(1).Text = grid_UA_Material.ActiveRow.Cells("Material").Value
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub MostrarInventario()
        Try
            Dim oeSubAlm As New e_SubAlmacen
            oeSubAlm.TipoOperacion = ""
            Select Case grid_UA_Material.ActiveRow.Cells("IndUnidadAsignacion").Value
                Case "A"
                    oeSubAlm.IdArea = grid_UA_Material.ActiveRow.Cells("IdUnidadAsignacion").Value
                Case "T"
                    oeSubAlm.IdTrabajador = grid_UA_Material.ActiveRow.Cells("IdUnidadAsignacion").Value
                Case "V"
                    oeSubAlm.IdEquipo = grid_UA_Material.ActiveRow.Cells("IdUnidadAsignacion").Value
            End Select
            oeSubAlm = olSubAlmacen.Obtener(oeSubAlm)
            Dim oeInventario As New e_Inventario
            gridInventario.DataSource = listaInventario
            oeInventario.FechaCreacion = ObtenerFechaServidor()
            oeInventario.IdSubAlmacen = oeSubAlm.Id
            oeInventario.TipoOperacion = "S"
            oeInventario.Activo = True
            listaInventario = olInventario.Listar(oeInventario)
            gridInventario.DataSource = listaInventario.OrderBy(Function(item) item.Material).ToList
            If gridInventario.Rows.Count > 0 Then
                gridInventario.Focus()
                gridInventario.Rows.Item(0).Selected = True
            End If
            For Each fila As UltraGridRow In gridInventario.Rows
                If fila.Cells("CantidadFinal").Value < fila.Cells("StockMin").Value Then
                    fila.Cells("CantidadFinal").Appearance.BackColor = Color.Tomato
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub MostrarKardex()
        Try
            ficHistorialMaterial.Tabs(1).Selected = True
            dsRegistroInv = New DataSet
            dsRegistroInv = ObtenerDetalleAsignacion("", "")
            grReg_Inv.DataSource = dsRegistroInv
            dsRegistroInv = ObtenerDetalleAsignacion(gridInventario.ActiveRow.Cells("IdMaterial").Value, gridInventario.ActiveRow.Cells("IdSubAlmacen").Value)
            grReg_Inv.DataSource = dsRegistroInv
            ficHistorialMaterial.Tabs(1).Text = gridInventario.ActiveRow.Cells("Material").Value
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub griArea_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griArea.DoubleClick
        Try
            If griArea.ActiveRow.Index > -1 AndAlso griArea.Rows.Count > 0 Then AgregarDetalle(griArea.ActiveRow.Cells("Id").Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griTrabajadores_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griTrabajadores.DoubleClick
        Try
            If griTrabajadores.ActiveRow.Index > -1 AndAlso griTrabajadores.Rows.Count > 0 Then AgregarDetalle(griTrabajadores.ActiveRow.Cells("Id").Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griEquipos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griEquipos.DoubleClick
        Try
            If griEquipos.ActiveRow.Index > -1 AndAlso griEquipos.Rows.Count > 0 Then AgregarDetalle(griEquipos.ActiveRow.Cells("Id").Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_OrdenAsignacion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Inicializa"
                If grid_OA.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
                Else
                    MyBase.Consultar()
                End If
            Case "Vista"
                Vista()
        End Select
    End Sub

    Private Sub frm_OrdenAsignacion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_OrdenAsignacion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_OrdenAsignacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            ColoresGenerado.Color = Color.White
            ColoresEnProceso.Color = Color.Khaki
            ColoresTerminada.Color = Color.LightGreen
            ColoresAnulado.Color = Color.Coral
            ListarCombosFiltros()
            rfFechaHasta.Value = Date.Now
            rfFechaDesde.Value = Date.Now.AddDays(-7)
            MostrarTabs(0, tcOA)
            ListarUnidadAsignada_Material("")
            grid_OA.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            grid_OA.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            Tiempo1.Enabled = False
            InicializaTiempo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmdTipoUnidadAsignada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTipoUnidadAsignada.ValueChanged
        Select Case cmdTipoUnidadAsignada.Value
            Case ""
                etiEPA.Text = "Equipo/Area/Trabajador:"
            Case "V"
                etiEPA.Text = "Equipo:"
            Case "A"
                etiEPA.Text = "Area :"
            Case "T"
                etiEPA.Text = "Trabajador:"
        End Select
        Combo_VAT(cmdTipoUnidadAsignada.Value)
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDatosAdicionales.CheckedChanged
        gbDatosAdicionales.Enabled = rbDatosAdicionales.Checked
        txtOA.Text = String.Empty
    End Sub

    Private Sub rbNroOA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNroOA.CheckedChanged
        gbNroOA.Enabled = rbNroOA.Checked
        txtOA.Focus()
    End Sub

    Private Sub griArea_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griArea.CellChange
        griArea.UpdateData()
    End Sub

    Private Sub griTrabajadores_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTrabajadores.CellChange
        griTrabajadores.UpdateData()
    End Sub

    Private Sub mnDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    AgregarMaterial()
                Case "Quitar"
                    QuitarDetalle()
                Case "Devolucion"
                    GenerarDevolucionMaterial()
                Case "Actualizar"
                    If MessageBox.Show("AVERTENCIA: Si Usted a realizados cambios," & Environment.NewLine & _
                                   "al realizar esta operación se perderan" & Environment.NewLine & _
                                   "¿Desea Actualizar los Materiales?", "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        ListarUnidadAsignada_Material(oeOrdenAsignacion.Id)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        ListarMateriales()
    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        If e.KeyCode = Keys.Enter Then ListarMateriales()
    End Sub

    Private Sub txtBuscarMateriales_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarMateriales.ValueChanged
        txtBuscarMateriales.Text = LTrim(txtBuscarMateriales.Text)
    End Sub

    Private Sub grid_Materiales_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_Materiales.InitializeLayout
        With grid_Materiales
            .DisplayLayout.Bands(0).SortedColumns.Add("CodigoNombre", False, True)
            .DisplayLayout.GroupByBox.Hidden = True
        End With
    End Sub

    Private Sub grid_Materiales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Materiales.CellChange
        grid_Materiales.UpdateData()
    End Sub

    Private Sub grid_UA_Material_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_UA_Material.AfterCellUpdate
        Try
            With grid_UA_Material
                Select Case e.Cell.Column.Key
                    Case "CantidadMaterial"
                        If .ActiveRow.Band.Index = 1 Then
                            If IsDBNull(e.Cell.Value) Then
                                .ActiveRow.Cells("CantidadMaterial").Value = cantmat
                                Exit Sub
                            End If
                            If .ActiveRow.Cells("CantidadMaterial").Value.ToString <> "" Then
                                If .ActiveRow.Cells("CantidadMaterial").Value.ToString < 0 Then
                                    .ActiveRow.Cells("CantidadMaterial").Value = 0
                                End If
                            End If
                            If Not IsDBNull(e.Cell.Value) AndAlso .ActiveRow.Cells("CantidadMaterial").Value < .ActiveRow.Cells("CantidadMaterialEntregada").Value Then
                                .ActiveRow.Cells("CantidadMaterial").Value = cantmat
                            End If
                        End If
                    Case "IdAlmacen"
                        If .ActiveRow.Band.Index = 1 Then
                            If .ActiveRow.Index > -1 Then
                                SubAlmacenValueList(.ActiveRow.Cells("IdAlmacen").Value.ToString)
                                .ActiveRow.Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")
                                .ActiveRow.Cells("CostoUnitario").Value = ObtenerValorUnitario(.ActiveRow.Cells("IdMaterial").Value, .ActiveRow.Cells("IdAlmacen").Value)
                                oeSubAlmacen = New e_SubAlmacen
                                oeSubAlmacen.TipoOperacion = "S"
                                oeSubAlmacen.Activo = True
                                oeSubAlmacen.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value.ToString
                                .ActiveRow.Cells("IdSubAlmacen").Value = olSubAlmacen.Obtener(oeSubAlmacen).Id
                                Dim oeMat As New e_Material
                                With grid_UA_Material.ActiveRow
                                    If .Index > -1 Then
                                        oeMat.TipoOperacion = "5"
                                        oeMat.Id = .Cells("IdMaterial").Value
                                        oeMat.IdSubAlmacen = .Cells("IdSubAlmacen").Value
                                        oeMat.Activo = True
                                        oeMat = olMaterial.ObtenerMaterialSegunAlmacen(oeMat)
                                        .Cells("Stock").Value = oeMat.Stock
                                    End If
                                End With
                            End If
                        End If
                    Case "IndDescuento"
                        If .ActiveRow.Band.Index = 1 Then
                            If .ActiveRow.Index > -1 Then
                                If .ActiveRow.Cells("CantidadMaterial").Value <> .ActiveRow.Cells("CantidadMaterialEntregada").Value Then
                                    If .ActiveRow.Cells("IndDescuento").Value And .ActiveRow.Cells("MontoDescuento").Value = 0 Then
                                        .ActiveRow.Cells("MontoDescuento").Value = (.ActiveRow.Cells("CantidadMaterial").Value - .ActiveRow.Cells("CantidadMaterialEntregada").Value) * .ActiveRow.Cells("CostoUnitario").Value
                                    Else
                                        .ActiveRow.Cells("MontoDescuento").Value = 0
                                    End If
                                ElseIf .ActiveRow.Cells("IndDescuento").Value Then
                                    .ActiveRow.Cells("IndDescuento").Value = False
                                End If
                            End If
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_UA_Material_DoubleClick(sender As Object, e As EventArgs) Handles grid_UA_Material.DoubleClick
        Try
            uebHistorialMaterial.Expanded = True
            Select Case grid_UA_Material.ActiveRow.Band.Index
                Case 0
                    ficHistorialMaterial.Tabs(0).Selected = True
                    MostrarInventario()
                Case 1
                    ficHistorialMaterial.Tabs(1).Selected = True
                    MostrarDetalle()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_UA_Material_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_UA_Material.CellChange
        Try
            With grid_UA_Material
                .UpdateData()
                If e.Cell.Column.Key.ToUpper = "SELECCION" Then
                    Select Case .ActiveRow.Band.Index
                        Case 0
                            For Each mantRow As DataRow In ds_UA_MA.Tables(1).Rows
                                If .ActiveRow.Cells("IdUnidadAsignacion").Value = mantRow("IdUnidadAsignacion") Then
                                    mantRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                                End If
                            Next
                        Case 1
                            Dim cont As Integer = 0, cont2 As Integer = 0
                            For Each mantRow As DataRow In ds_UA_MA.Tables(1).Rows
                                If .ActiveRow.Cells("IdUnidadAsignacion").Value = mantRow("IdUnidadAsignacion") Then
                                    If mantRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value Then
                                        cont += 1
                                    End If
                                    cont2 += 1
                                End If
                            Next
                            If cont = cont2 Then
                                .ActiveRow.ParentRow.Cells("Seleccion").Value = .ActiveRow.Cells("Seleccion").Value
                            Else
                                If Not .ActiveRow.Cells("Seleccion").Value = 1 Then
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

    Private Sub grid_UA_Material_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grid_UA_Material.BeforeCellUpdate
        Try
            With grid_UA_Material
                Select Case e.Cell.Column.Key
                    Case "CantidadMaterial"
                        If .ActiveRow.Band.Index = 1 Then
                            If (e.NewValue < .ActiveRow.Cells("CantidadMaterialEntregada").Value) Then
                                cantmat = IIf(IsDBNull(e.Cell.Value), 0, e.Cell.Value)
                                Throw New Exception("No se puede cambiar la cantidad programada por que no puede ser menor a la cantidad entregada " & Environment.NewLine & "Cantidad entregada = " & .ActiveRow.Cells("CantidadMaterialEntregada").Value)
                            End If
                        End If
                        'Case "IndDescuento"
                        '    If .ActiveRow.Band.Index = 1 Then
                        '        If .ActiveRow.Index > -1 Then
                        '            If .ActiveRow.Cells("IndDescuento").Value Then
                        '                If .ActiveRow.Cells("CantidadMaterial").Value = .ActiveRow.Cells("CantidadMaterialEntregada").Value Then
                        '                    If .ActiveRow.Cells("MontoDescuento").Value = 0 Then
                        '                        .ActiveRow.Cells("IndDescuento").Value = False
                        '                    End If
                        '                End If
                        '            Else
                        '                If .ActiveRow.Cells("CantidadMaterial").Value = .ActiveRow.Cells("CantidadMaterialEntregada").Value Then
                        '                    .ActiveRow.Cells("IndDescuento").Value = True
                        '                    Exit Sub
                        '                End If
                        '            End If
                        '        End If
                        '    End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeOrdenAsignacion.Glosa = Trim(txtGlosa.Text)
        oeOrdenAsignacion.Modificado = True
    End Sub

    Private Sub grid_OA_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_OA.DoubleClick
        If grid_OA.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_OA_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_OA.AfterRowActivate
        With grid_OA
            btnEjecutar.Enabled = 0 : btnCerrar.Enabled = 0 : btnAnular.Enabled = 0
            If .ActiveRow.Index > -1 Then
                If .ActiveRow.Cells("EstadoOA").Value = "GENERADA" Then btnEjecutar.Enabled = 1 : btnAnular.Enabled = 1
                If .ActiveRow.Cells("EstadoOA").Value = "EN PROCESO" Then btnCerrar.Enabled = 1 : btnAnular.Enabled = 1
            End If

        End With
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

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Try

            If Not ValidarPermisoReq() Then Throw New Exception("No Tiene Permisos para Generar Requerimientos")
            Editar()
            Me.etiGenerando.Text = "Generando RQ" : Me.etiGenerando.Visible = True : oeOrdenAsignacion.TipoOperacion = "S" : gbEAT.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GenerarRequerimientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarRequerimientoToolStripMenuItem.Click
        Try
            If Not ValidarPermisoReq() Then Throw New Exception("No Tiene Permisos para Generar Requerimientos")
            Editar()
            Me.etiGenerando.Text = "Generando RQ" : Me.etiGenerando.Visible = True : oeOrdenAsignacion.TipoOperacion = "S"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try     
    End Sub

    Private Sub TerminarOAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Editar()
        Me.etiGenerando.Text = "Terminando OA" : Me.etiGenerando.Visible = True : oeOrdenAsignacion.TipoOperacion = "T"
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Editar()
        Me.etiGenerando.Text = "Terminando OA" : Me.etiGenerando.Visible = True : oeOrdenAsignacion.TipoOperacion = "T"
        Me.gbEAT.Visible = False
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Try
            AnularOA(grid_OA.ActiveRow.Cells("Id").Value.ToString)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        oeOrdenAsignacion.Fecha = dtpFecha.Value
    End Sub

    Private Sub AnularOAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularOAToolStripMenuItem.Click
        AnularOA(grid_OA.ActiveRow.Cells("Id").Value.ToString)
    End Sub

    Private Sub txtOA_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOA.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar(True)
        End If
    End Sub

    Private Sub txtOA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOA.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub gridInventario_DoubleClick(sender As Object, e As EventArgs) Handles gridInventario.DoubleClick
        Try
            MostrarKardex()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            Inicializar()
            oeOrdenAsignacion.TipoOperacion = "I"
            MostrarTabs(1, tcOA, 1)
            Operacion = "Nuevo"
            ListarUnidadAsignada_Material("")
            Me.txtEstado.Text = "POR GENERAR"
            Me.ListarAreas(True)
            Me.ListarTrabajadores()
            Me.ListarEquipos(True)
            txtGlosa.Focus()
            Me.mnDetalle.Tools("Devolucion").SharedProps.Visible = False
            Me.mnDetalle.Tools("Actualizar").SharedProps.Visible = False
            DetalleMenu()
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_OA.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
            Else
                _Activo = False
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarOrdenAsignacion() Then
                MostrarTabs(0, tcOA, 2)
                _ingresando_datos = False
                Me.Consultar(True)
            Else
                MostrarTabs(1, tcOA, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            Operacion = "Editar"
            MostrarOrden()
            Me.ListarAreas(True)
            Me.ListarTrabajadores()
            Me.ListarEquipos(True)
            oeOrdenAsignacion.TipoOperacion = "A"
            txtGlosa.Focus()
            DetalleMenu()
            Select Case oeOrdenAsignacion.EstadoOA
                Case "TERMINADA", "ANULADO"
                    Operacion = "Inicializa"
                    Vista()
                    gbEAT.Visible = False
                Case Else
                    MyBase.Editar()
                    gbEAT.Visible = True
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try     
    End Sub

    Public Overrides Sub Vista()
        Operacion = "Vista"
        MyBase.Vista()
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeOrdenAsignacion.Modificado And oeOrdenAsignacion.EstadoOA <> "TERMINADA" And oeOrdenAsignacion.EstadoOA <> "ANULADO" Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarOrdenAsignacion() Then
                            MostrarTabs(0, tcOA, 2)
                            _ingresando_datos = False
                            oeOrdenAsignacion.Modificado = False
                            Me.Consultar(True)
                        Else
                            _ingresando_datos = True
                            oeOrdenAsignacion.Modificado = True
                            MostrarTabs(1, tcOA, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcOA, 2)
                        _ingresando_datos = False
                        oeOrdenAsignacion.Modificado = False
                        Me.Consultar(True)
                End Select
            Else
                MostrarTabs(0, tcOA, 2)
                _ingresando_datos = False
                Me.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_OA
                If ValidarGrilla(grid_OA, "Orden Asignacion") Then
                    If .ActiveRow.Cells("EstadoOA").Value.ToString <> "GENERADA" Then
                        Throw New Exception("Solo Se Pueden Eliminar Orden en Estado GENERADA")
                    End If
                    oeOrdenAsignacion.Id = .ActiveRow.Cells("ID").Value
                    oeOrdenAsignacion = olOrdenAsignacion.Obtener(oeOrdenAsignacion)
                    oeOrdenAsignacion.TipoOperacion = "E"
                    If MessageBox.Show("Esta seguro de eliminar la OA N°: " & _
                    .ActiveRow.Cells("NroOA").Value.ToString.Trim & "?", _
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        olOrdenAsignacion.Eliminar(oeOrdenAsignacion)
                        Consultar(True)
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If tcOA.SelectedTab.Index = 0 Then
                If grid_OA.Rows.Count = 0 Then Throw New Exception("No hay ninguna orden de asignación para exportar a Excel")
                Exportar_Excel(grid_OA)
            Else
                If grid_UA_Material.Rows.Count > 0 Then Exportar_Excel(grid_UA_Material)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Menu y tabs"

    Private Sub mcDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcDetalle.Opening
        mcDetalle.Items("InsertarToolStripMenuItem").Visible = 1
        mcDetalle.Items("ActualizarToolStripMenuItem").Visible = IIf(grid_OA.Selected.Rows.Count > 0, 1, 0)
        mcDetalle.Items("EliminarToolStripMenuItem").Visible = IIf(grid_OA.Selected.Rows.Count > 0, 1, 0)
        mcDetalle.Items("GenerarRequerimientoToolStripMenuItem").Visible = IIf(grid_OA.Selected.Rows.Count > 0 AndAlso grid_OA.ActiveRow.Cells("EstadoOA").Value.ToString = "GENERADA", 1, 0)
        'mcDetalle.Items("TerminarOAToolStripMenuItem").Visible = IIf(grid_OA.Selected.Rows.Count > 0 AndAlso grid_OA.ActiveRow.Cells("EstadoOA").Value.ToString = "EN PROCESO", 1, 0)
        mcDetalle.Items("AnularOAToolStripMenuItem").Visible = IIf(grid_OA.Selected.Rows.Count > 0 AndAlso grid_OA.ActiveRow.Cells("EstadoOA").Value.ToString = "EN PROCESO", 1, 0)
    End Sub

#End Region

End Class