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
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource

Public Class frm_RequerimientoD2
    Inherits frm_MenuPadre

#Region "Inicialización del formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_RequerimientoD2 = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        'Operacion = "Inicializa"
        If instancia Is Nothing Then
            instancia = New frm_RequerimientoD2()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim oeRequerimiento As New e_Requerimiento
    Dim olRequerimiento As New l_Requerimiento
    Dim oeEstadoRequerimiento As New e_EstadoRequerimiento, olEstadoRequerimiento As New l_EstadoRequerimiento

    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material
    Dim llMaterial As New List(Of e_Material)
    Dim olRequerimientoMaterial As New l_RequerimientoMaterial
    Dim oeRequerimientoMaterial As New e_RequerimientoMaterial()
    Dim lstRequerimientoMaterial As New List(Of e_RequerimientoMaterial)

    Dim oeControlEntregaMaterial As New e_ControlEntregaMaterial

    Dim oeServicio As New e_Servicio
    Dim olServicio As New l_Servicio
    Dim llServicio As New List(Of e_Servicio)
    Dim olRequerimientoServicio As New l_RequerimientoServicio
    Dim oeRequerimientoServicio As New e_RequerimientoServicio()
    Dim llRequerimientoServicio As New List(Of e_RequerimientoServicio)

    Dim oeCategoriaServicio As New e_CategoriaServicio
    Dim olCategoriaServicio As New l_CategoriaServicio
    Dim lstCategoriasServicio As New List(Of e_CategoriaServicio)

    Dim olArea As New l_Area
    Dim oeArea As New e_Area

    Dim oeUnidadMedida As New e_UnidadMedida
    Dim olUnidadMedida As New l_UnidadMedida

    Dim olMaterialAlmacen As New l_MaterialAlmacen
    Dim oeMaterialAlmacen As New e_MaterialAlmacen

    'Manejador de Subalmacen
    Dim oeSubalmacen As New e_SubAlmacen
    Dim olSubalmacen As New l_SubAlmacen

    Dim oeCentroCosto As New e_CentroCosto
    Dim olCentroCosto As New l_CentroCosto


    Dim olUsuario As New l_Usuario
    Dim oeUsuario As New e_Usuario
    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador
    Dim _ingresando_datos As Boolean = False

    Dim oeIGV As New e_Impuesto
    Dim olIGV As New l_Impuesto

    Dim tipoOperacionDetReq As String

    '---------------Datos para atención de requerimientos------------------
    Dim cantTotalAtender As Double
    Dim cantTotalRegularizar As Double
    Dim oeMovimientoInventario As New e_MovimientoInventario
    Dim olMovimientoInventario As New l_MovimientoInventario
    Dim oeTipoOrden As New e_TipoOrden
    Dim olTipoOrden As New l_TipoOrden

    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda

    Dim oeOrdenSalida As New e_Orden, olOrdenSalida As New l_Orden
    Dim oeDetalleOrdenSalida As New e_OrdenMaterial
    Dim lstDetalleOrdenSalida As New List(Of e_OrdenMaterial)
    '----------------------------------------------------------------------

    '------------Manejador de Inventario:Ejecucion de la ordenes de salida---------------------
    Dim oeRegistroInventario As New e_RegistroInventario
    Dim olRegistroInventario As New l_RegistroInventario
    Dim listaRegistroInventario As New List(Of e_RegistroInventario)
    '----------------------------------------------------------------------------------------
    Dim cantmat As Double = 0

    '---- Para OA DetalleOrdenAsignacion
    Dim oeDetalleMaterialAsignacion As New e_DetalleMaterialAsignacion
    Dim olDetalleMaterialAsignacion As New l_DetalleMaterialAsignacion
    Dim oeModelo As New e_Modelo, oeMarca As New e_Marca, oeEstado As New e_Estado, loMarca As New List(Of e_Marca)
    Dim olModelo As New l_Modelo, olMarca As New l_Marca, olEstado As New l_Estado, loModelo As New List(Of e_Modelo), loEstado As New List(Of e_Estado)
    Dim ds_RM_DE As New DataSet
    Dim relation As DataRelation
    Dim Referencia As String = ""
    Dim oeDetMA As New e_DetalleMaterialAsignacion

    '---- Para Hacer el Ingreso en la Asignacion
    Dim oeRegInv As New e_RegistroInventario
    Dim oeDetalleAsignacion As New e_DetalleAsignacion
    Dim ls_IdSubAlmacenAsignacion As String = ""
    Dim oeSubAlmacenIngreso As New e_SubAlmacen
    Dim oeOrdenIngreso As New e_Orden
    Dim oeDetalleOrdenIngreso As New e_OrdenMaterial
    Dim lstDetalleOrdenIngreso As New List(Of e_OrdenMaterial)
    'Manejador de Inventario
    Dim oeInventario As New e_Inventario
    Dim olInventario As New l_Inventario
    Dim listaInventario As New List(Of e_Inventario)

    Public Prefijo As New l_Configuracion

    Private oeCodBarMat As New e_CodigoBarraMaterial
    Private olCodBarMat As New l_CodigoBarraMaterial

    Dim RegistroEditado As Integer = 0
    Dim IdRegistroEditado As String = ""

    Dim oeRegistroEditado As New e_RegistrosEditados
    Dim olRegistroEditado As New l_RegistrosEditados

    Private oeAsientoModelo As e_AsientoModelo
    Private olAsientoModelo As l_AsientoModelo
    Private loAsientoModelo As List(Of e_AsientoModelo)
    Private oeReferencia As e_AsientoModelo_Referencia
    Private olReferencia As l_AsientoModelo_Referencia
    Private loReferencia As List(Of e_AsientoModelo_Referencia)

    Private oeCtaCtbleSFam As e_CtaCtbleSubFamiliaMat
    Private olCtaCtbleSFam As l_CtaCtbleSubFamiliaMat
    Private loCtaCtbleSFam, loCtaCtbleSFamOrden As List(Of e_CtaCtbleSubFamiliaMat)

    Private dtReferencia As New DataTable

#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar(Activo)
            Tiempo1.Enabled = True
            If grid_Requerimientos.Rows.Count > 0 Then
                '' ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1) ''D2
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1) ''D2
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1) ''D2
            Throw New Exception("Lo sentimos, no se puede crear requerimientos")
            Inicializar()
            Operacion = "Nuevo"
            ValidaFicha()
            controlaColumnasMateriales(True, False, True, True, True, 0, True, True, True)
            controlaColumnasServicio(True, False, True)
            MostrarTabs(1, ficRequerimiento, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            oeEstadoRequerimiento.Nombre = "GENERADO"
            oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)
            oeRequerimiento.IdEstadoRequerimiento = oeEstadoRequerimiento.Id
            CodigoBarras(False)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1) ''D2
            Throw New Exception("Lo sentimos, no se pueden editar los requerimientos")
            tipoOperacionDetReq = "2"
            controlaColumnasMateriales(True, False, True, True, True, 0, True, True)
            controlaColumnasServicio(True, False, True)
            ValidaFicha()
            Inicializar()
            Operacion = "Editar"
            CodigoBarras(False)
            'If VerificarRegistroEditado() Then
            If EditarRequerimiento() Then
                If oeRequerimiento.EstadoRequerimiento = "ATENDIDO" Or oeRequerimiento.EstadoRequerimiento = "EVALUADO" Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 0) 'Inhabilito el boton Guardar
                Else
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0) 'Habilito el boton Guardar                
                End If
                'GuardarRegistroEditado()
                grid_MaterialRequeridos.DisplayLayout.Bands(0).Columns("Glosa").Style = ColumnStyle.EditButton
            End If
            'End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRequerimiento() Then
                'ActualizaRegistroEditado()
                MostrarTabs(0, ficRequerimiento, 2)
                InicializaTiempo()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Inicializar()
            If oeRequerimiento.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRequerimiento() Then
                            MostrarTabs(0, ficRequerimiento, 2)
                            '_ingresando_datos = False
                            Consultar(True)
                        Else
                            '_ingresando_datos = True
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficRequerimiento, 2)
                        _ingresando_datos = False
                        Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        '_ingresando_datos = True
                End Select
            Else
                MostrarTabs(0, ficRequerimiento, 2)
                '_ingresando_datos = False
                Consultar(True)
            End If
            'ActualizaRegistroEditado()
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1) ''D2
            Throw New Exception("Lo sentimos, no se pueden eliminar los requerimientos")
            With grid_Requerimientos

                If .ActiveRow.Index > -1 Then
                    If ValidarGrilla(grid_Requerimientos, "Requerimiento") Then
                        If .ActiveRow.Cells("EstadoRequerimiento").Value = "GENERADO" Then

                            oeRequerimiento.Id = .ActiveRow.Cells("Id").Value
                            oeRequerimiento = olRequerimiento.Obtener(oeRequerimiento)
                            If oeRequerimiento.Activo Then
                                If MessageBox.Show("Esta seguro de eliminar el Requerimiento: " & _
                                   .ActiveRow.Cells("Codigo").Value.ToString & " ?", _
                                   "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                    oeRequerimiento.TipoOperacion = "E"
                                    oeRequerimiento.MaterialServicio = cboRequerimiento.Value
                                    olRequerimiento.Eliminar(oeRequerimiento)
                                    Consultar(True)
                                End If
                            Else
                                Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                            End If
                        Else
                            Throw New Exception("Solo podrá eliminar requerimientos que esten Generados")
                        End If
                    End If
                Else
                    Throw New Exception("Seleccione un requerimiento para eliminarla. ")
                End If


            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1) ''D2
        Throw New Exception("Lo sentimos, no se puedeimprimir")
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficRequerimiento.Tabs(0).Selected() AndAlso grid_Requerimientos.Rows.Count = 0 Then Throw New Exception("No hay ningún requerimiento para exportar al Excel")
            If ficRequerimiento.Tabs(0).Selected() Then Exportar_Excel(grid_Requerimientos)

            If ficRequerimiento.Tabs(1).Selected() Then

                If ficDetalle.Tabs(0).Selected() Then

                    If grid_MaterialRequeridos.Rows.Count = 0 Then Throw New Exception("No hay ningún material para exportar al Excel")
                    Exportar_Excel(grid_MaterialRequeridos)

                End If

                If ficDetalle.Tabs(1).Selected() Then

                    If griListaServiciosRequeridos.Rows.Count = 0 Then Throw New Exception("No hay ningún servicio para exportar al Excel")
                    Exportar_Excel(griListaServiciosRequeridos)

                End If

                If ficDetalle.Tabs(2).Selected() Then

                    If grilla_OA_Material.Rows.Count = 0 Then Throw New Exception("No hay ningún material de la Orden de Asignación para exportar al Excel")
                    Exportar_Excel(grilla_OA_Material)

                End If

            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        Try
            oeIGV = olIGV.IGV(fecFecha.Value)
            oeRequerimiento = New e_Requerimiento
            ls_IdSubAlmacenAsignacion = ""
            LimpiarListas()
            oeRequerimiento.TipoOperacion = "I"
            ControlaBarraOperacionesDetalle(1, 0, 0)
            agrMaterialesRequeridos.Text = "Materiales requeridos : 0"
            oeRequerimiento.IdArea = oeArea.Id 'cboAreaM.Value
            oeRequerimiento.UsuarioCreacion = gUsuarioSGI.Id
            fecFecha.Value = Date.Now
            fecAtencion.Value = Date.Now
            txtDescripcion.Value = String.Empty
            txtArea.Value = oeArea.Nombre
            txtCodigo.Value = String.Empty
            txtCodigoBarras.Text = String.Empty
            txtMaterial.Text = String.Empty
            oeRequerimiento.MaterialServicio = cboRequerimiento.Value
            lbl_etiqueta.Visible = 0
            grid_MaterialRequeridos.DisplayLayout.Bands(0).Columns("Glosa").Style = ColumnStyle.Default
            AsociarMenu()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub CodigoBarras(ByVal Activo As Boolean)
        Me.txtCodigoBarras.Visible = Activo
        Me.txtMaterial.Visible = Activo
        Me.UltraLabel6.Visible = Activo
        Me.UltraLabel7.Visible = Activo
    End Sub

    Private Sub ValidaFicha()

        If cboRequerimiento.Text = "MATERIALES" Then
            Referencia = ""
            If Operacion <> "Nuevo" Then
                Referencia = IIf(String.IsNullOrEmpty(grid_Requerimientos.ActiveRow.Cells("Referencia").Value.ToString), "  ", grid_Requerimientos.ActiveRow.Cells("Referencia").Value.ToString)
                Referencia = Referencia.Substring(0, 2)
            End If

            ficDetalle.Tabs("Servicio").Visible = False
            If Referencia.Equals("OA") Then
                ficDetalle.Tabs("OA_Material").Visible = True
                ficDetalle.Tabs("OA_Material").Selected = True
                ficDetalle.Tabs("Material").Visible = False
            Else
                ficDetalle.Tabs("Material").Visible = True
                ficDetalle.Tabs("Material").Selected = True
                ficDetalle.Tabs("OA_Material").Visible = False
            End If
        Else
            ficDetalle.Tabs("Material").Visible = False
            ficDetalle.Tabs("OA_Material").Visible = False
            ficDetalle.Tabs("Servicio").Visible = True
            ficDetalle.Tabs("Servicio").Selected = True
        End If

    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            ValidarFechaDesde_Hasta(rangoFechaDesde, rangoFechaHasta)
            oeRequerimiento.UsuarioCreacion = gUsuarioSGI.Id
            oeRequerimiento.IdArea = oeArea.Id
            oeRequerimiento.FechaInicio = rangoFechaDesde.Value
            oeRequerimiento.FechaFinal = rangoFechaHasta.Value
            oeRequerimiento.OpcionFecha = IIf(Me.cboFormaBusqueda.SelectedIndex = 1, "FA", "FS")
            oeRequerimiento.Activo = Activo
            oeRequerimiento.TipoOperacion = "5"
            oeRequerimiento.PrefijoCentro = cboCentro.Value
            btnAtenderReq.Visible = IIf(cboRequerimiento.Text.Equals("SERVICIOS"), 0, 1)
            If cbArea.Checked Then oeRequerimiento.IdArea = cboAreaL.Value
            With grid_Requerimientos
                .DataSource = olRequerimiento.Listar(oeRequerimiento)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                agrRequerimientos.Text = "Requerimientos : " & .Rows.Count
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With

            For Each fila As UltraGridRow In grid_Requerimientos.Rows
                Select Case fila.Cells("EstadoRequerimiento").Value
                    Case "GENERADO"
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case "EVALUADO"
                        fila.CellAppearance.BackColor = Me.ColoresEvaluado.Color
                    Case "PARCIALMENTE ATENDIDO"
                        fila.CellAppearance.BackColor = Me.ColoresAtendidoParcialmente.Color
                    Case "ATENDIDO"
                        fila.CellAppearance.BackColor = Me.ColoresAtendido.Color
                    Case Else
                        fila.CellAppearance.BackColor = Color.White
                End Select
            Next

            With grid_Requerimientos

                If grid_Requerimientos.Rows.Count > 0 Then

                    Select Case .Rows(0).Cells("EstadoRequerimiento").Value
                        Case "EVALUADO"
                        Case "ATENDIDO"
                    End Select

                End If
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Function ObtenerValorUnitario(ByVal idMaterial As String, ByVal idAlmacen As String) As String
        Try
            oeInventario = New e_Inventario
            oeInventario.ValorUnitario = 0.0
            oeInventario.TipoOperacion = 1
            oeInventario.IdMaterial = idMaterial
            oeInventario.IdSubAlmacen = idAlmacen
            oeInventario = olInventario.Obtener(oeInventario)
            If oeInventario.ValorUnitario = 0 Then
                oeInventario.TipoOperacion = "P"
                oeInventario = olInventario.Obtener(oeInventario)
                Return oeInventario.ValorUnitario * (1 + oeIGV.Porcentaje)
            Else
                Return oeInventario.ValorUnitario * (1 + oeIGV.Porcentaje)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Function VerificaListaMateriales(ByVal oeMat As e_Material) As Boolean
        For Each filaReqMat As e_RequerimientoMaterial In lstRequerimientoMaterial
            If oeMat.Id = filaReqMat.IdMaterial Then Return True
        Next
    End Function

    Private Function VerificaListaServicios(ByVal oeSer As e_Servicio) As Boolean
        For Each filaReqSer As e_RequerimientoServicio In llRequerimientoServicio
            If oeSer.Id = filaReqSer.IdServicio Then Return True
        Next
    End Function

    Public Function TransponerRequerimientoMaterial() As List(Of e_RequerimientoMaterial)
        lstRequerimientoMaterial.Clear()
        For Each matRow As DataRow In ds_RM_DE.Tables(0).Rows
            oeRequerimientoMaterial = New e_RequerimientoMaterial
            oeRequerimientoMaterial.IdRequerimiento = matRow("IdRequerimiento")
            oeRequerimientoMaterial.Id = matRow("IdDetalleRequerimiento")
            oeRequerimientoMaterial.IdAlmacen = matRow("IdAlmacen")
            oeRequerimientoMaterial.IdSubAlmacen = matRow("IdSubAlmacen")
            oeRequerimientoMaterial.IdMaterial = matRow("IdMaterial")
            oeRequerimientoMaterial.Cantidad = matRow("Cantidad")
            oeRequerimientoMaterial.IdUnidadMedida = matRow("IdUnidadMedida")
            oeRequerimientoMaterial.CantidadAAtender = matRow("CantidadAAtender")
            oeRequerimientoMaterial.IdCentroCosto = IIf(String.IsNullOrEmpty(matRow("IdCentroCosto").ToString), "", matRow("IdCentroCosto").ToString)
            oeRequerimientoMaterial.Glosa = matRow("Glosa")
            oeRequerimientoMaterial.Precio = matRow("Precio")
            oeRequerimientoMaterial.CantidadPorAtender = matRow("CantidadPorAtender")
            If oeRequerimientoMaterial.CantidadAAtender > 0 Then
                oeRequerimientoMaterial.FechaAtencion = ObtenerFechaServidor()
            End If
            oeRequerimientoMaterial.IdEstadoRequerimientoMaterial = matRow("IdEstadoRequerimientoMaterial")
            oeRequerimientoMaterial.IndRegularizado = True
            oeRequerimientoMaterial.CantidadPorRegularizar = 0
            oeRequerimientoMaterial.UsuarioCreacion = gUsuarioSGI.Id
            oeRequerimientoMaterial.lstDetalleMaterialAsignacion = TransponerDetalleAsignacion(oeRequerimientoMaterial.Id)
            lstRequerimientoMaterial.Add(oeRequerimientoMaterial)
        Next
        Return lstRequerimientoMaterial
    End Function

    Public Function TransponerDetalleAsignacion(ByVal lsIdRequerimientoMaterial As String) As List(Of e_DetalleMaterialAsignacion)
        Dim lstDMA As New List(Of e_DetalleMaterialAsignacion)
        For Each matRow As DataRow In ds_RM_DE.Tables(1).Rows
            If lsIdRequerimientoMaterial = matRow("IdRequerimientoMaterial") Then
                oeDetMA = New e_DetalleMaterialAsignacion
                oeDetMA.Id = matRow("Id")
                oeDetMA.IdRequerimientoMaterial = matRow("IdRequerimientoMaterial")
                oeDetMA.IdMarca = matRow("IdMarca")
                oeDetMA.IdModelo = matRow("IdModelo")
                oeDetMA.IdEstado = matRow("IdEstado")
                oeDetMA.Serie = matRow("Serie")
                oeDetMA.Especificaciones = matRow("Especificaciones")
                lstDMA.Add(oeDetMA)
            End If
        Next
        Return lstDMA
    End Function

    Private Function Inventario(lo As List(Of e_OrdenMaterial)) As List(Of e_Inventario)
        Try
            Dim FechaActual As Date = ObtenerFechaServidor()
            Dim loInventario As New List(Of e_Inventario)
            Dim oeInventario As e_Inventario
            Dim oeRegInventario As e_RegistroInventario
            For Each oe As e_OrdenMaterial In lo
                oeInventario = New e_Inventario
                With oeInventario
                    .FechaCreacion = FechaActual
                    .IdMaterial = oe.IdMaterial
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .CantidadSalida = oe.CantidadMaterial
                    .ValorUnitario = Math.Round(oe.PrecioUnitario / (oeIGVGlobal.Porcentaje + 1), 4)
                    .Usuario = gUsuarioSGI.Id
                    .IndValidar = True
                End With
                oeRegInventario = New e_RegistroInventario
                With oeRegInventario
                    .TipoOperacion = "I"
                    .IdMaterial = oe.IdMaterial
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .IdMovimientoInventario = oeOrdenSalida.IdMovimientoInventario
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .Cantidad = oe.CantidadMaterial
                    .UsuarioCreacion = gUsuarioSGI.Id
                End With
                oeInventario.oeRegistroInventario = New e_RegistroInventario
                oeInventario.oeRegistroInventario = oeRegInventario
                loInventario.Add(oeInventario)
            Next
            Return loInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub CargarIngresoAsignacion(FechaServidor As Date)
        Try
            Dim oeInventario As e_Inventario
            Dim loInventario As New List(Of e_Inventario)
            '---------------------------------------------------------------------
            'Carga Detalle Ingreso
            oeOrdenIngreso = New e_Orden
            lstDetalleOrdenIngreso = New List(Of e_OrdenMaterial)
            For Each obj As e_RequerimientoMaterial In lstRequerimientoMaterial.Where(Function(i) i.CantidadAAtender > 0).ToList
                oeDetalleOrdenIngreso = New e_OrdenMaterial
                oeDetalleOrdenIngreso.Activo = True
                oeDetalleOrdenIngreso.IdMaterial = obj.IdMaterial
                oeDetalleOrdenIngreso.Material = obj.Material
                oeDetalleOrdenIngreso.CantidadMaterial = obj.CantidadAAtender
                oeDetalleOrdenIngreso.PrecioUnitario = obj.Precio 'Falta obtener de la BD.
                'oeDetalleOrdenIngreso.IdAlmacen = obj.IdAlmacen
                oeDetalleOrdenIngreso.IdSubAlmacen = ls_IdSubAlmacenAsignacion
                oeDetalleOrdenIngreso.IdTipoUnidadMedida = obj.IdTipoUnidadMedida
                oeDetalleOrdenIngreso.IdUnidadMedida = obj.IdUnidadMedida
                oeDetalleOrdenIngreso.UnidadMedida = obj.UnidadMedida
                oeDetalleOrdenIngreso.ValorVenta = oeDetalleOrdenIngreso.PrecioUnitario * oeDetalleOrdenIngreso.CantidadMaterial
                lstDetalleOrdenIngreso.Add(oeDetalleOrdenIngreso)
            Next
            '---------------------------------------------------------------------
            oeOrdenIngreso.lstOrdenMaterial = lstDetalleOrdenIngreso
            oeOrdenIngreso.Activo = True
            oeOrdenIngreso.IdMoneda = "1CH01" ' Soles 
            oeOrdenIngreso.IdTipoOrden = "1CH000000001" 'ORDEN DE INGRESO
            oeOrdenIngreso.IdProveedor = gs_IdClienteProveedorSistema.Trim
            oeOrdenIngreso.IdMovimientoInventario = "1CH000000036" 'INGRESO POR ASIGNACION
            oeOrdenIngreso.FechaOrden = FechaServidor
            oeOrdenIngreso.TipoOperacion = "O"
            oeOrdenIngreso.IdSubAlmacenDestino = ""
            oeOrdenIngreso.IdSubAlmacenOrigen = ""
            oeOrdenIngreso.TipoReferencia = "REQUERIMIENTO"
            oeOrdenIngreso.Referencia = oeRequerimiento.Codigo
            oeOrdenIngreso.UsuarioCreacion = gUsuarioSGI.Id
            oeOrdenIngreso.IdUsuarioEjecucion = gUsuarioSGI.Id
            lstDetalleOrdenIngreso = New List(Of e_OrdenMaterial)
            oeRequerimiento.oeOrdenIngreso = oeOrdenIngreso
            '-------
            oeRequerimiento.oeOrdenIngreso.lstInventario = New List(Of e_Inventario)
            For Each item As e_RequerimientoMaterial In oeRequerimiento.lstRequerimientoMaterial.Where(Function(i) i.CantidadAAtender > 0).ToList
                oeInventario = New e_Inventario
                With oeInventario
                    .IdMaterial = item.IdMaterial
                    .IdSubAlmacen = ls_IdSubAlmacenAsignacion
                    .CantidadIngreso = item.CantidadAAtender
                    .ValorUnitario = Math.Round(item.Precio / (oeIGVGlobal.Porcentaje + 1), 4)
                    .Usuario = gUsuarioSGI.Id
                    .FechaCreacion = FechaServidor
                End With
                oeRegInv = New e_RegistroInventario
                With oeRegInv
                    .TipoOperacion = "I"
                    .IdMaterial = item.IdMaterial
                    .IdSubAlmacen = ls_IdSubAlmacenAsignacion
                    .IdMovimientoInventario = oeOrdenIngreso.IdMovimientoInventario
                    .IdUnidadMedida = item.IdUnidadMedida
                    .Cantidad = item.CantidadAAtender
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .lstDetalleAsignacion = New List(Of e_DetalleAsignacion)
                    For Each itemDetalle As e_DetalleMaterialAsignacion In item.lstDetalleMaterialAsignacion
                        oeDetalleAsignacion = New e_DetalleAsignacion
                        If itemDetalle.Id = "" Then
                            oeDetalleAsignacion.Id = ""
                            oeDetalleAsignacion.IdEstado = itemDetalle.IdEstado
                            oeDetalleAsignacion.IdModelo = itemDetalle.IdModelo
                            oeDetalleAsignacion.Serie = itemDetalle.Serie
                            oeDetalleAsignacion.Especificaciones = itemDetalle.Especificaciones
                            oeDetalleAsignacion.FechaVencimiento = itemDetalle.FechaVencimiento
                            oeRegInv.lstDetalleAsignacion.Add(oeDetalleAsignacion)
                        End If
                    Next
                End With
                oeInventario.oeRegistroInventario = New e_RegistroInventario
                oeInventario.oeRegistroInventario = oeRegInv
                loInventario.Add(oeInventario)
            Next
            oeRequerimiento.oeOrdenIngreso.lstInventario.AddRange(loInventario)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GuardarRequerimiento() As Boolean
        Try
            If oeRequerimiento.MaterialServicio = "M" Then
                Dim oeComboPropio As e_Combo
                Dim oeEquipo As e_Equipo
                Dim olEquipo As l_Equipo
                If Referencia.Equals("OA") Then
                    oeRequerimiento.lstRequerimientoMaterial = TransponerRequerimientoMaterial()
                    CargarIngresoAsignacion(ObtenerFechaServidor())
                Else
                    For Each obj As e_RequerimientoMaterial In lstRequerimientoMaterial
                        If obj.IndRegularizado = False Then
                            obj.IdEstadoRequerimientoMaterial = "1CH000000008"
                        Else
                            obj.IdEstadoRequerimientoMaterial = "1CH000000006"
                            If obj.CantidadAAtender > 0 Then
                                obj.FechaAtencion = ObtenerFechaServidor()
                            End If
                        End If
                    Next
                    If oeRequerimiento.TipoOperacion = "D" Then
                        Dim lsReqMat As New List(Of e_RequerimientoMaterial)
                        lsReqMat = ListarRequerimientoActualizado()
                        For Each reqmat As e_RequerimientoMaterial In lsReqMat
                            For Each rm As e_RequerimientoMaterial In lstRequerimientoMaterial
                                If reqmat.Id = rm.Id And reqmat.IdMantenimiento = rm.IdMantenimiento Then
                                    If reqmat.CantidadPorAtender <> rm.CantidadPorAtender Then
                                        mensajeEmergente.Confirmacion("El Requerimiento ha sido Modificado. La Cantidad Pendiente por Atender de: " _
                                                                      & reqmat.Material & " es ahora de: " & reqmat.CantidadPorAtender - rm.CantidadPorAtender, True)
                                        rm.CantidadPorAtender = reqmat.CantidadPorAtender
                                    End If
                                End If
                            Next
                        Next
                    End If
                    oeRequerimiento.lstRequerimientoMaterial = lstRequerimientoMaterial
                End If
                ''NO SE ATIENDED2''
                For Each obj In oeRequerimiento.lstRequerimientoMaterial.Where(Function(item) item.IdMaterial <> "1CH000001990").ToList
                    obj.CantidadAAtender = 0
                    obj.Glosa = ""
                Next

                If oeRequerimiento.TipoOperacion = "D" Then 'Si se genera una atención de requerimientos.
                    lstRequerimientoMaterial.ForEach(AddressOf obtenerCantidadTotalAtender)
                    If cantTotalAtender = 0 Then
                        Throw New Exception("Debe ingresar cantidad para atender los requerimientos de materiales.")
                    End If
                    cantTotalAtender = 0
                    '------- CONTROLAR AUTENTICACIÓN DEL TRABAJADOR PREVIO A LA ATENCIÓN ------------
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    Dim idTrabEntr As String = ""
                    'formulario.IdArea = oeRequerimiento.IdArea
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        Exit Function
                    Else
                        'For Each reqmat As e_RequerimientoMaterial In lstRequerimientoMaterial
                        '    oeControlEntregaMaterial = New e_ControlEntregaMaterial
                        '    If reqmat.CantidadAAtender > 0 Then
                        '        oeControlEntregaMaterial.FechaCreacion = Date.Now
                        '        oeControlEntregaMaterial.CantidadEntregada = reqmat.CantidadAAtender
                        '        oeControlEntregaMaterial.IdTrabajador = formulario.idTrabajador

                        '        oeControlEntregaMaterial.UsuarioCreacion = gUsuarioSGI.Id
                        '        oeControlEntregaMaterial.IdUnidadMedida = reqmat.IdUnidadMedida
                        '        reqmat.loControlEntregaMaterial.Add(oeControlEntregaMaterial)
                        '    End If
                        'Next
                        idTrabEntr = formulario.idTrabajador
                    End If
                    formulario = Nothing
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                    '-------------------------------------------------------------------------------

                    '---------------------GENERANDO UNA ORDEN DE SALIDA-----------------------------
                    '--------------Obteniendo los datos segun consulta-------------------
                    oeMovimientoInventario = New e_MovimientoInventario
                    oeMovimientoInventario.Activo = True
                    oeMovimientoInventario.Nombre = IIf(String.IsNullOrEmpty(oeRequerimiento.IdReferencia.Trim), "SALIDA POR ATENCION DE REQUERIMIENTO", "SALIDA POR MANTENIMIENTO")
                    oeMovimientoInventario.Nombre = IIf(Referencia.Equals("OA"), "SALIDA POR ATENCION DE REQUERIMIENTO", oeMovimientoInventario.Nombre)
                    oeMovimientoInventario = olMovimientoInventario.Obtener(oeMovimientoInventario)

                    oeTipoOrden = New e_TipoOrden
                    oeTipoOrden.Activo = True
                    oeTipoOrden.Nombre = "ORDEN DE SALIDA"
                    oeTipoOrden = olTipoOrden.Obtener(oeTipoOrden)

                    oeMoneda = New e_Moneda
                    oeMoneda.Activo = True
                    oeMoneda.Nombre = "SOLES"
                    oeMoneda = olMoneda.Obtener(oeMoneda)

                    AgregarDetalleOrdenSalida()
                    If lstDetalleOrdenSalida.Count > 0 Then
                        oeOrdenSalida.lstOrdenMaterial = lstDetalleOrdenSalida
                        oeOrdenSalida.Activo = True
                        oeOrdenSalida.IdMoneda = oeMoneda.Id  'Definir: Soles 
                        oeOrdenSalida.IdTipoOrden = oeTipoOrden.Id
                        oeOrdenSalida.IdProveedor = gs_IdClienteProveedorSistema.Trim
                        oeOrdenSalida.IdMovimientoInventario = oeMovimientoInventario.Id
                        oeOrdenSalida.TipoReferencia = "REQUERIMIENTO"
                        oeOrdenSalida.Referencia = oeRequerimiento.Codigo
                        oeOrdenSalida.FechaOrden = Date.Now
                        oeOrdenSalida.TipoOperacion = "D"
                        oeOrdenSalida.IdSubAlmacenDestino = ""
                        oeOrdenSalida.IdSubAlmacenOrigen = ""
                        oeOrdenSalida.UsuarioCreacion = gUsuarioSGI.Id
                        oeOrdenSalida.IdUsuarioEjecucion = gUsuarioSGI.Id
                        oeOrdenSalida.lstInventario = New List(Of e_Inventario)
                        oeOrdenSalida.lstInventario = Inventario(oeOrdenSalida.lstOrdenMaterial)
                        For Each ordsalmat As e_OrdenMaterial In oeOrdenSalida.lstOrdenMaterial
                            oeControlEntregaMaterial = New e_ControlEntregaMaterial
                            If ordsalmat.CantidadMaterial > 0 Then
                                oeControlEntregaMaterial.FechaCreacion = Date.Now
                                oeControlEntregaMaterial.CantidadEntregada = ordsalmat.CantidadMaterial
                                oeControlEntregaMaterial.IdTrabajador = idTrabEntr
                                oeControlEntregaMaterial.UsuarioCreacion = gUsuarioSGI.Id
                                oeControlEntregaMaterial.IdUnidadMedida = ordsalmat.IdUnidadMedida
                                ordsalmat.loControlEntregaMaterial.Add(oeControlEntregaMaterial)
                            End If
                            oeComboPropio = New e_Combo
                            oeComboPropio.Tipo = 3
                            oeComboPropio.Nombre = "0"
                            oeComboPropio.Id = ordsalmat.IdAlmacen
                            If AlmacenesPublic.Contains(oeComboPropio) Then
                                ordsalmat.IndPropio = True
                            End If
                        Next
                        If oeOrdenSalida.lstOrdenMaterial.Where(Function(i) i.IndPropio = True).Count > 0 Then
                            oeEquipo = New e_Equipo
                            If Not Referencia.Equals("OA") Then
                                olEquipo = New l_Equipo
                                oeEquipo.TipoOperacion = ""
                                oeEquipo.Id = oeRequerimiento.IdEquipo
                                oeEquipo = olEquipo.Obtener(oeEquipo)
                            End If
                            Dim oePeriodo As New e_Periodo
                            Dim olPeriodo As New l_Periodo
                            Dim fechaactual As Date = ObtenerFechaServidor.Date
                            oePeriodo.Ejercicio = fechaactual.Year
                            oePeriodo.Mes = fechaactual.Month
                            oePeriodo = olPeriodo.Obtener(oePeriodo)
                            If oePeriodo.Id = "" Then Throw New Exception("No Existe el Periodo Contable de Este Periodo. Comunicar a Contabilidad")
                            oeOrdenSalida.IndAsiento = True
                            oeOrdenSalida.loAsientoModelo = New List(Of e_AsientoModelo)
                            ObtenerAsientoModelo("1CH01", oePeriodo.Ejercicio)
                            LlenaCuentaOrden(oeOrdenSalida, oePeriodo.Ejercicio, loCtaCtbleSFam)
                            oeOrdenSalida.IdPeriodo = oePeriodo.Id
                            oeOrdenSalida.TipoCambio = TipoCambio(fechaactual, True)(0)
                            oeOrdenSalida.IdOrdenCompra = oeEquipo.IdVehiculo
                        End If
                        listaRegistroInventario = New List(Of e_RegistroInventario)
                        lstDetalleOrdenSalida = New List(Of e_OrdenMaterial)
                        oeRequerimiento.oeOrdenSalida = oeOrdenSalida
                        oeRequerimiento.oeOrdenIngreso = oeOrdenIngreso
                    Else
                        oeRequerimiento.oeOrdenSalida = New e_Orden
                        oeRequerimiento.oeOrdenIngresoAlmPrincipal = New e_Orden
                        oeRequerimiento.oeOrdenSalidaAlmPrincipal = New e_Orden
                    End If
                ElseIf oeRequerimiento.TipoOperacion = "R" Then

                    lstRequerimientoMaterial.ForEach(AddressOf obtenerCantidadTotalRegulariar)
                    If cantTotalRegularizar = 0 Then
                        Throw New Exception("Debe ingresar cantidad para regularizar los requerimientos de materiales.")
                    End If
                    cantTotalRegularizar = 0
                    For Each obj As e_RequerimientoMaterial In lstRequerimientoMaterial
                        If obj.CantidadARegularizar > 0 Then
                            obj.FechaAtencion = ObtenerFechaServidor()
                        End If
                    Next
                    oeMovimientoInventario = New e_MovimientoInventario
                    oeMovimientoInventario.Activo = True
                    oeMovimientoInventario.Nombre = IIf(String.IsNullOrEmpty(oeRequerimiento.IdReferencia.Trim), "SALIDA POR ATENCION DE REQUERIMIENTO", "SALIDA POR MANTENIMIENTO")
                    oeMovimientoInventario.Nombre = IIf(Referencia.Equals("OA"), "SALIDA POR ATENCION DE REQUERIMIENTO", oeMovimientoInventario.Nombre)
                    oeMovimientoInventario = olMovimientoInventario.Obtener(oeMovimientoInventario)

                    oeTipoOrden = New e_TipoOrden
                    oeTipoOrden.Activo = True
                    oeTipoOrden.Nombre = "ORDEN DE SALIDA"
                    oeTipoOrden = olTipoOrden.Obtener(oeTipoOrden)

                    oeMoneda = New e_Moneda
                    oeMoneda.Activo = True
                    oeMoneda.Nombre = "SOLES"
                    oeMoneda = olMoneda.Obtener(oeMoneda)

                    AgregarDetalleOrdenSalidaRegularizacion()
                    If lstDetalleOrdenSalida.Count > 0 Then
                        oeOrdenSalida.lstOrdenMaterial = lstDetalleOrdenSalida
                        oeOrdenSalida.Activo = True
                        oeOrdenSalida.IdMoneda = oeMoneda.Id  'Definir: Soles 
                        oeOrdenSalida.IdTipoOrden = oeTipoOrden.Id
                        oeOrdenSalida.IdProveedor = gs_IdClienteProveedorSistema.Trim
                        oeOrdenSalida.IdMovimientoInventario = oeMovimientoInventario.Id
                        oeOrdenSalida.TipoReferencia = "REQUERIMIENTO"
                        oeOrdenSalida.Referencia = oeRequerimiento.Codigo
                        oeOrdenSalida.FechaOrden = Date.Now
                        oeOrdenSalida.TipoOperacion = "D"
                        oeOrdenSalida.IdSubAlmacenDestino = ""
                        oeOrdenSalida.IdSubAlmacenOrigen = ""
                        oeOrdenSalida.UsuarioCreacion = gUsuarioSGI.Id
                        oeOrdenSalida.IdUsuarioEjecucion = gUsuarioSGI.Id
                        oeOrdenSalida.lstInventario = New List(Of e_Inventario)
                        oeOrdenSalida.lstInventario = Inventario(oeOrdenSalida.lstOrdenMaterial)
                        For Each oe As e_OrdenMaterial In oeOrdenSalida.lstOrdenMaterial
                            oeComboPropio = New e_Combo
                            oeComboPropio.Tipo = 3
                            oeComboPropio.Nombre = "0"
                            oeComboPropio.Id = oe.IdAlmacen
                            If AlmacenesPublic.Contains(oeComboPropio) Then
                                oe.IndPropio = True
                            End If
                        Next
                        If oeOrdenSalida.lstOrdenMaterial.Where(Function(i) i.IndPropio = True).Count > 0 Then
                            oeEquipo = New e_Equipo
                            If Not Referencia.Equals("OA") Then
                                olEquipo = New l_Equipo
                                oeEquipo.TipoOperacion = ""
                                oeEquipo.Id = oeRequerimiento.IdEquipo
                                oeEquipo = olEquipo.Obtener(oeEquipo)
                            End If
                            Dim oePeriodo As New e_Periodo
                            Dim olPeriodo As New l_Periodo
                            Dim fechaactual As Date = ObtenerFechaServidor.Date
                            oePeriodo.Ejercicio = fechaactual.Year
                            oePeriodo.Mes = fechaactual.Month
                            oePeriodo = olPeriodo.Obtener(oePeriodo)
                            If oePeriodo.Id = "" Then Throw New Exception("No Existe el Periodo Contable de Este Periodo. Comunicar a Contabilidad")
                            oeOrdenSalida.IndAsiento = True
                            oeOrdenSalida.loAsientoModelo = New List(Of e_AsientoModelo)
                            ObtenerAsientoModelo("1CH01", oePeriodo.Ejercicio)
                            LlenaCuentaOrden(oeOrdenSalida, oePeriodo.Ejercicio, loCtaCtbleSFam)
                            oeOrdenSalida.IdPeriodo = oePeriodo.Id
                            oeOrdenSalida.TipoCambio = TipoCambio(fechaactual, True)(0)
                            oeOrdenSalida.IdOrdenCompra = oeEquipo.IdVehiculo
                        End If
                        oeOrdenIngreso = New e_Orden
                        oeOrdenIngreso.lstOrdenMaterial = New List(Of e_OrdenMaterial)
                        listaRegistroInventario = New List(Of e_RegistroInventario)
                        lstDetalleOrdenSalida = New List(Of e_OrdenMaterial)
                        oeRequerimiento.oeOrdenSalida = oeOrdenSalida
                        oeRequerimiento.oeOrdenIngreso = oeOrdenIngreso
                    Else
                        oeRequerimiento.oeOrdenSalida = New e_Orden
                        oeRequerimiento.oeOrdenIngresoAlmPrincipal = New e_Orden
                        oeRequerimiento.oeOrdenSalidaAlmPrincipal = New e_Orden
                    End If
                End If
            Else
                oeRequerimiento.lstRequerimientoServicio = llRequerimientoServicio
            End If
            oeRequerimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olRequerimiento.Guardar(oeRequerimiento) Then
                'If oeRequerimiento.TipoOperacion = "D" Then
                '    Dim frm As New frm_ImprimirMaterialEntregado
                '    Dim id As String = ""
                '    For Each materialrequerimiento As e_RequerimientoMaterial In oeRequerimiento.lstRequerimientoMaterial.Where(Function(item) item.CantidadAAtender > 0)
                '        For Each mat As e_ControlEntregaMaterial In materialrequerimiento.loControlEntregaMaterial
                '            id = id & "'" & mat.Id & "',"
                '        Next
                '    Next
                '    If id <> "" Then
                '        id = id.Substring(0, id.Length - 1)
                '    End If
                '    frm.CargarDatos(id)
                '    frm.ShowDialog()
                'End If

                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                Consultar(True)
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub BuscarSubAlmacen_Ingreso()
        oeSubAlmacenIngreso = New e_SubAlmacen
        oeSubAlmacenIngreso.TipoOperacion = "5"
        oeSubAlmacenIngreso.Activo = True
        oeSubAlmacenIngreso.IdOrdenAsignacion = oeRequerimiento.IdReferencia
        oeSubAlmacenIngreso = olSubalmacen.Obtener(oeSubAlmacenIngreso)
        ls_IdSubAlmacenAsignacion = oeSubAlmacenIngreso.Id
    End Sub

    Public Function EditarRequerimiento() As Boolean
        Dim id As String
        Try
            With grid_Requerimientos
                id = .ActiveRow.Cells("Id").Value.ToString
                If id.Length > 0 Then
                    oeRequerimiento = New e_Requerimiento
                    oeRequerimiento.Id = id
                    oeRequerimiento.Activo = .ActiveRow.Cells("Activo").Value.ToString
                    oeRequerimiento.Descripcion = .ActiveRow.Cells("Descripcion").Value.ToString
                    oeRequerimiento.TipoOperacion = "1"
                    oeRequerimiento = olRequerimiento.Obtener(oeRequerimiento)
                    If oeRequerimiento.Activo Then
                        txtCodigo.Value = oeRequerimiento.Codigo
                        txtDescripcion.Text = oeRequerimiento.Descripcion
                        txtArea.Value = oeRequerimiento.Area
                        fecFecha.Value = oeRequerimiento.FechaCreacion
                        fecAtencion.Value = oeRequerimiento.FechaAtencion
                        MostrarTabs(1, ficRequerimiento, 1)
                        oeRequerimiento.TipoOperacion = "A"
                        If Referencia.Equals("OA") Then
                            ListarRM_Detalle(id)
                            BuscarSubAlmacen_Ingreso()
                        Else
                            listarDetalleRequerimiento()
                        End If
                        Return True
                    Else
                        Throw New Exception(Me.Text & ": El Registro se encuentra eliminado y no se puede editar")
                    End If
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Public Sub listarDetalleRequerimiento()
        Try
            If cboRequerimiento.Text = "MATERIALES" Then
                ListarRequerimientoMaterial(True)
                If grid_MaterialRequeridos.Rows.Count > 0 Then
                    ControlaBarraOperacionesDetalle(1, 1, 1)
                Else
                    ControlaBarraOperacionesDetalle(1, 1, 0)
                End If
            Else
                ListarRequerimientoServicio(True)
                If griListaServiciosRequeridos.Rows.Count > 0 Then
                    ControlaBarraOperacionesDetalle(1, 1, 1)
                Else
                    ControlaBarraOperacionesDetalle(1, 1, 0)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarRequerimientoMaterial(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeRequerimientoMaterial = New e_RequerimientoMaterial
            With grid_MaterialRequeridos

                oeRequerimientoMaterial.Tipooperacion = tipoOperacionDetReq
                oeRequerimientoMaterial.Activo = 0
                oeRequerimientoMaterial.IdRequerimiento = oeRequerimiento.Id
                lstRequerimientoMaterial = olRequerimientoMaterial.Listar(oeRequerimientoMaterial)
                .DataSource = lstRequerimientoMaterial
                agrMaterialesRequeridos.Text = "Materiales requeridos : " & lstRequerimientoMaterial.Count

                llenaCombosGrillaMaterialRequerido(grid_MaterialRequeridos)
                asignarColoresSegunEstado(grid_MaterialRequeridos)

            End With

        Catch ex As Exception
            Throw ex
        End Try
        grid_MaterialRequeridos.Focus()

    End Sub

    Public Function ListarRequerimientoActualizado() As List(Of e_RequerimientoMaterial)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeRequerimientoMaterial = New e_RequerimientoMaterial
            Dim lst As New List(Of e_RequerimientoMaterial)
            oeRequerimientoMaterial.Tipooperacion = tipoOperacionDetReq
            oeRequerimientoMaterial.Activo = True
            oeRequerimientoMaterial.IdRequerimiento = oeRequerimiento.Id
            lst = olRequerimientoMaterial.Listar(oeRequerimientoMaterial)
            Return lst
        Catch ex As Exception
            Throw ex
        End Try
        grid_MaterialRequeridos.Focus()

    End Function

    Public Sub ListarRequerimientoServicio(ByVal Activo As Boolean)
        Try

            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            'agrMateriales.Visible = False
            'agrMaterialesRequeridos.Dock = DockStyle.Fill
            oeRequerimientoServicio = New e_RequerimientoServicio
            With griListaServiciosRequeridos

                oeRequerimientoServicio.Tipooperacion = "1"
                oeRequerimientoServicio.Activo = Activo
                oeRequerimientoServicio.IdRequerimiento = oeRequerimiento.Id
                llRequerimientoServicio = olRequerimientoServicio.Listar(oeRequerimientoServicio)
                .DataSource = llRequerimientoServicio
                agrServiciosRequeridos.Text = "Servicios requeridos : " & llRequerimientoServicio.Count
                llenaCombosGrillaServicioRequerido()
                asignarColoresSegunEstadoServicio()

            End With

        Catch ex As Exception
            Throw ex
        End Try
        grid_MaterialRequeridos.Focus()

    End Sub

    Public Sub asignarColoresSegunEstado(ByVal grilla As UltraGrid)
        For Each fila As UltraGridRow In grilla.Rows
            If fila.Cells("CantidadPorRegularizar").Value > 0 Then
                fila.Appearance.BackColor = Me.ColoresPorRegularizar.Color
            ElseIf fila.Cells("CantidadPorAtender").Value = 0 Then
                fila.Appearance.BackColor = Me.colorAtendido.Color
            ElseIf fila.Cells("Cantidad").Value > fila.Cells("CantidadPorAtender").Value And fila.Cells("CantidadPorAtender").Value > 0 Then
                fila.Appearance.BackColor = Me.colorAtendidoParcial.Color
            ElseIf fila.Cells("Cantidad").Value = fila.Cells("CantidadPorAtender").Value Then
                fila.Appearance.BackColor = Me.colorPendiente.Color
            End If
            Select Case fila.Cells("EstadoRequerimientoMaterial").Value
                Case "GENERADO"
                    fila.Cells("EstadoRequerimientoMaterial").Appearance.BackColor = Me.ColoresGeneradaDetalle.Color
                Case "PREAPROBADO"
                    fila.Cells("EstadoRequerimientoMaterial").Appearance.BackColor = Me.ColoresPreaprobado.Color
                Case "APROBADO"
                    fila.Cells("EstadoRequerimientoMaterial").Appearance.BackColor = Me.ColoresAprobado.Color
                Case "RECHAZADO"
                    fila.Cells("EstadoRequerimientoMaterial").Appearance.BackColor = Me.ColoresRechazado.Color
                Case "POR REGULARIZAR"
                    fila.Cells("EstadoRequerimientoMaterial").Appearance.BackColor = Me.ColoresPorRegularizar.Color
                Case Else
                    fila.Cells("EstadoRequerimientoMaterial").Appearance.BackColor = Color.White
            End Select
        Next
    End Sub

    Public Sub asignarColoresSegunEstadoServicio()
        For Each fila As UltraGridRow In griListaServiciosRequeridos.Rows

            Select Case fila.Cells("EstadoRequerimientoServicio").Value
                Case "GENERADO"
                    fila.Cells("EstadoRequerimientoServicio").Appearance.BackColor = Me.ColoresGeneradaDetalle.Color
                Case "PREAPROBADO"
                    fila.Cells("EstadoRequerimientoServicio").Appearance.BackColor = Me.ColoresPreaprobado.Color
                Case "APROBADO"
                    fila.Cells("EstadoRequerimientoServicio").Appearance.BackColor = Me.ColoresAprobado.Color
                Case "RECHAZADO"
                    fila.Cells("EstadoRequerimientoServicio").Appearance.BackColor = Me.ColoresRechazado.Color
                Case Else
                    fila.Cells("EstadoRequerimientoServicio").Appearance.BackColor = Color.White
            End Select
        Next
    End Sub

    Private Sub AsignarMaterialRequerimiento()
        Try
            '-----------------------Obteniendo estado para los detalles-------------------
            'oeEstadoRequerimiento = New e_EstadoRequerimiento
            'oeEstadoRequerimiento.Nombre = "GENERADO"
            'oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)
            '-----------------------------------------------------------------------------
            oeCentroCosto.Activo = True
            oeCentroCosto.IdArea = oeArea.Id
            oeCentroCosto = olCentroCosto.Obtener(oeCentroCosto)
            For Each oeMat As e_Material In llMaterial
                If oeMat.Seleccion Then
                    oeRequerimientoMaterial = New e_RequerimientoMaterial()
                    oeRequerimientoMaterial.Seleccion = False 'llMaterial.Item(i).Seleccion
                    oeRequerimientoMaterial.Activo = True
                    oeRequerimientoMaterial.IdMaterial = oeMat.Id
                    oeRequerimientoMaterial.Material = oeMat.Nombre
                    oeRequerimientoMaterial.IdAlmacen = oeMat.IdAlmacen
                    oeRequerimientoMaterial.Almacen = oeMat.Almacen
                    oeRequerimientoMaterial.IdSubAlmacen = oeMat.IdSubAlmacen
                    oeRequerimientoMaterial.UsuarioCreacion = gUsuarioSGI.Id
                    oeRequerimientoMaterial.IdUnidadMedida = oeMat.IdUnidadMedida
                    oeRequerimientoMaterial.IdTipoUnidadMedida = oeMat.IdTipoUnidadMedida
                    oeRequerimientoMaterial.Cantidad = 1
                    oeRequerimientoMaterial.IdCentroCosto = oeCentroCosto.Id ' "1CH000000025" 'Este valor se obtendrá cuando el usuario se autentique.Sale de la tabla trabajador
                    oeRequerimientoMaterial.IdEstadoRequerimientoMaterial = oeEstadoRequerimiento.Id
                    oeRequerimientoMaterial.StockActual = oeMat.Stock  'Falta Asignar Stock
                    oeRequerimientoMaterial.Precio = Math.Round(oeMat.Precio * (1 + oeIGV.Porcentaje), 2)
                    oeRequerimientoMaterial.CodigoMaterial = oeMat.Codigo
                    oeRequerimientoMaterial.CantidadPorRegularizar = 0
                    oeRequerimientoMaterial.IndRegularizado = True
                    lstRequerimientoMaterial.Add(oeRequerimientoMaterial)
                End If
            Next
            grid_MaterialRequeridos.DataBind()
            llenaCombosGrillaMaterialRequerido(grid_MaterialRequeridos)
            llMaterial.RemoveAll(AddressOf eliminaMateriales)
            'griListaMateriales.Rows.ExpandAll(True)
            muestraCantidadElementosGrilla()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsignarServicioRequerimiento()
        Try
            oeCentroCosto.Activo = True
            oeCentroCosto.IdArea = oeArea.Id
            oeCentroCosto = olCentroCosto.Obtener(oeCentroCosto)
            For Each oeSer As e_Servicio In llServicio
                If oeSer.Seleccion Then
                    oeRequerimientoServicio = New e_RequerimientoServicio()
                    oeRequerimientoServicio.Seleccion = False 'llMaterial.Item(i).Seleccion
                    oeRequerimientoServicio.Activo = True
                    oeRequerimientoServicio.IdServicio = oeSer.Id
                    oeRequerimientoServicio.Servicio = oeSer.Nombre
                    oeRequerimientoServicio.CodigoServicio = oeSer.Codigo
                    oeRequerimientoServicio.UsuarioCreacion = gUsuarioSGI.Id
                    oeRequerimientoServicio.Cantidad = 1
                    oeRequerimientoServicio.Precio = oeSer.Precio
                    oeRequerimientoServicio.IdCentroCosto = oeCentroCosto.Id ' "1CH000000025" 'Este valor se obtendrá cuando el usuario se autentique.Sale de la tabla trabajador
                    oeRequerimientoServicio.IdEstadoRequerimientoServicio = oeEstadoRequerimiento.Id
                    llRequerimientoServicio.Add(oeRequerimientoServicio)
                End If
            Next
            griListaServiciosRequeridos.DataBind()
            llenaCombosGrillaServicioRequerido()
            llServicio.RemoveAll(AddressOf eliminaServicios)
            muestraCantidadElementosGrillaServicio()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarDetalleOrdenSalida()
        Try
            For Each obj As e_RequerimientoMaterial In lstRequerimientoMaterial
                If obj.CantidadAAtender > 0 And obj.IndRegularizado Then
                    oeDetalleOrdenSalida = New e_OrdenMaterial
                    oeDetalleOrdenSalida.Activo = True
                    oeDetalleOrdenSalida.IdMaterial = obj.IdMaterial
                    oeDetalleOrdenSalida.Material = obj.Material
                    oeDetalleOrdenSalida.CantidadMaterial = obj.CantidadAAtender
                    oeDetalleOrdenSalida.PrecioUnitario = obj.Precio 'Falta obtener de la BD.
                    oeDetalleOrdenSalida.IdAlmacen = obj.IdAlmacen
                    oeDetalleOrdenSalida.IdSubAlmacen = obj.IdSubAlmacen
                    oeDetalleOrdenSalida.IdTipoUnidadMedida = obj.IdTipoUnidadMedida
                    oeDetalleOrdenSalida.IdUnidadMedida = obj.IdUnidadMedida
                    oeDetalleOrdenSalida.UnidadMedida = obj.UnidadMedida
                    oeDetalleOrdenSalida.ValorVenta = oeDetalleOrdenSalida.PrecioUnitario * oeDetalleOrdenSalida.CantidadMaterial
                    oeDetalleOrdenSalida.IdRequerimientoMaterial = obj.Id
                    lstDetalleOrdenSalida.Add(oeDetalleOrdenSalida)
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Sub TransponerRegistroInv()
    '    For Each item As e_OrdenMaterial In oeOrdenSalida.lstOrdenMaterial.Where(Function(oe) oe.CantidadMaterial > 0).ToList
    '        oeRegistroInventario = New e_RegistroInventario
    '        oeRegistroInventario.Id = ""
    '        oeRegistroInventario.IdMovimientoInventario = oeOrdenSalida.IdMovimientoInventario
    '        oeRegistroInventario.IdMaterial = item.IdMaterial
    '        oeRegistroInventario.IdUnidadMedida = item.IdUnidadMedida
    '        oeRegistroInventario.Cantidad = item.CantidadMaterial
    '        oeRegistroInventario.CantidadReal = ConvertirUnidadBase(item.CantidadMaterial, item.IdUnidadMedida)
    '        oeRegistroInventario.ValorUnitarioReal = (item.ValorVenta / oeRegistroInventario.CantidadReal)
    '        oeRegistroInventario.ValorUnitario = item.PrecioUnitario
    '        oeRegistroInventario.ValorTotal = oeRegistroInventario.CantidadReal * oeRegistroInventario.ValorUnitarioReal
    '        oeRegistroInventario.Activo = item.Activo
    '        oeRegistroInventario.UsuarioCreacion = gUsuarioSGI.Id
    '        oeRegistroInventario.Fecha = Date.Now
    '        oeRegistroInventario.IdSubAlmacen = item.IdSubAlmacen
    '        'oeRegistroInventario.IdAlmacen = item.IdAlmacen 'envia almacen
    '        oeRegistroInventario.TipoOperacion = "T"

    '        oeInventario = New e_Inventario
    '        oeInventario.TipoOperacion = "I"
    '        oeInventario.IdMaterial = oeRegistroInventario.IdMaterial
    '        oeInventario.IdSubAlmacen = oeRegistroInventario.IdSubAlmacen
    '        oeInventario.ValorUnitario = oeRegistroInventario.ValorUnitario
    '        oeInventario.FechaCreacion = Date.Now
    '        oeInventario.CantidadIngreso = 0
    '        oeInventario.CantidadSalida = oeRegistroInventario.Cantidad
    '        oeInventario.ValorTotal = oeRegistroInventario.ValorTotal
    '        oeInventario.Usuario = gUsuarioSGI.Id

    '        oeRegistroInventario.oeInventario = oeInventario

    '        listaRegistroInventario.Add(oeRegistroInventario)
    '    Next
    '    oeOrdenSalida.lstRegistroInventario = listaRegistroInventario
    'End Sub

    Private Sub AgregarDetalleOrdenSalidaRegularizacion()
        Try
            For Each obj As e_RequerimientoMaterial In lstRequerimientoMaterial
                If obj.CantidadPorRegularizar > 0 Then
                    oeDetalleOrdenSalida = New e_OrdenMaterial
                    oeDetalleOrdenSalida.Activo = True
                    oeDetalleOrdenSalida.IdMaterial = obj.IdMaterial
                    oeDetalleOrdenSalida.Material = obj.Material
                    oeDetalleOrdenSalida.CantidadMaterial = obj.CantidadARegularizar
                    oeDetalleOrdenSalida.PrecioUnitario = obj.Precio 'Falta obtener de la BD.
                    oeDetalleOrdenSalida.IdAlmacen = obj.IdAlmacen
                    oeDetalleOrdenSalida.IdSubAlmacen = obj.IdSubAlmacen
                    oeDetalleOrdenSalida.IdTipoUnidadMedida = obj.IdTipoUnidadMedida
                    oeDetalleOrdenSalida.IdUnidadMedida = obj.IdUnidadMedida
                    oeDetalleOrdenSalida.UnidadMedida = obj.UnidadMedida
                    oeDetalleOrdenSalida.ValorVenta = oeDetalleOrdenSalida.PrecioUnitario * oeDetalleOrdenSalida.CantidadMaterial
                    oeDetalleOrdenSalida.IdRequerimientoMaterial = obj.Id
                    lstDetalleOrdenSalida.Add(oeDetalleOrdenSalida)
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub llenaCombosGrillaMaterialRequerido(ByVal grilla As UltraGrid)
        Try
            'oeCentroCosto = New e_CentroCosto
            'oeCentroCosto.Activo = True
            'oeCentroCosto.IdArea = oeArea.Id
            'CrearComboGrid("IdCentroCosto", "Nombre", grilla, olCentroCosto.ComboGrilla(oeCentroCosto), True)

            For i As Integer = 0 To grilla.Rows.Count - 1
                oeUnidadMedida = New e_UnidadMedida()
                oeUnidadMedida.Activo = True
                oeUnidadMedida.Factor = 0
                oeUnidadMedida.IdTipoUnidadMedida = grilla.Rows(i).Cells("IdTipoUnidadMedida").Value.ToString
                CrearComboGridPorCelda("IdUnidadMedida", "Nombre", i, grilla, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)

                oeMaterialAlmacen = New e_MaterialAlmacen()
                oeMaterialAlmacen.Activo = True
                oeMaterialAlmacen.IdCentro = cboCentro.Value
                oeMaterialAlmacen.TipoOperacion = "6"
                oeMaterialAlmacen.IdMaterial = grilla.Rows(i).Cells("IdMaterial").Value.ToString
                CrearComboGridPorCelda("IdAlmacen", "Nombre", i, grilla, olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen), True)

                oeSubalmacen = New e_SubAlmacen
                oeSubalmacen.TipoOperacion = "S"
                oeSubalmacen.Activo = True
                oeSubalmacen.IdAlmacen = grilla.Rows(i).Cells("IdAlmacen").Value.ToString
                CrearComboGridPorCelda("IdSubAlmacen", "Nombre", i, grilla, olSubalmacen.ComboGrilla(oeSubalmacen), True)
            Next
            grilla.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub llenaCombosGrillaServicioRequerido()
        Try
            oeCentroCosto = New e_CentroCosto
            oeCentroCosto.Activo = True
            oeCentroCosto.IdArea = oeArea.Id
            CrearComboGrid("IdCentroCosto", "Nombre", griListaServiciosRequeridos, olCentroCosto.ComboGrilla(oeCentroCosto), True)
            griListaServiciosRequeridos.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function eliminaMateriales(ByVal oeMat As e_Material) As Boolean
        Return oeMat.Seleccion
    End Function

    Private Function eliminaServicios(ByVal oeSer As e_Servicio) As Boolean
        Return oeSer.Seleccion
    End Function

    Private Sub LimpiarListas()
        Try
            llMaterial.Clear()
            llServicio.Clear()
            lstRequerimientoMaterial.Clear()
            llRequerimientoServicio.Clear()
            grid_MaterialRequeridos.DataSource = lstRequerimientoMaterial
            griListaServiciosRequeridos.DataSource = llRequerimientoServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub muestraCantidadElementosGrilla()
        agrMaterialesRequeridos.Text = "Materiales requeridos : " & grid_MaterialRequeridos.Rows.Count
    End Sub

    Public Sub muestraCantidadElementosGrillaServicio()
        agrServiciosRequeridos.Text = "Servicios requeridos : " & griListaServiciosRequeridos.Rows.Count
    End Sub

    Private Function verificarSeleccionadoServicio(ByVal oeReqSer As e_RequerimientoServicio) As Boolean
        Try
            If Not String.IsNullOrEmpty(oeReqSer.IdServicio) AndAlso oeReqSer.Seleccion Then
                Dim oeServicio As New e_Servicio
                oeServicio.TipoOperacion = "S"
                oeServicio.Id = oeReqSer.IdServicio
                oeServicio.Activo = True
                oeServicio = olServicio.Obtener(oeServicio)
                llServicio.Add(oeServicio)
            End If
            Return oeReqSer.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function verificarSeleccionado(ByVal oeReqMat As e_RequerimientoMaterial) As Boolean
        Try
            If Not String.IsNullOrEmpty(oeReqMat.IdMaterial) AndAlso oeReqMat.Seleccion Then
                Dim oeMaterial As New e_Material
                oeMaterial.TipoOperacion = "5"
                oeMaterial.Id = oeReqMat.IdMaterial
                oeMaterial.IdAlmacen = oeReqMat.IdAlmacen
                oeMaterial.Activo = True
                oeMaterial = olMaterial.ObtenerMaterialSegunAlmacen(oeMaterial)
                llMaterial.Add(oeMaterial)
            End If
            Return oeReqMat.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Public Sub controlaColumnasMateriales(ByVal activoIA As Boolean, ByVal activoSR As Boolean, ByVal activoCA As Boolean, _
                                          ByVal activoCAA As Boolean, ByVal visibleLisMat As Boolean, ByVal cellClickAction As Integer, _
                                          ByVal cantPorRegularizar As Boolean, ByVal cantARegul As Boolean, Optional ByVal IndRegularizar As Boolean = False) 'cellClickAction-> 0:Default y 4: SelectAndEditCell
        Try
            With grid_MaterialRequeridos
                .DisplayLayout.Bands(0).Columns("IndicadorAprobacion").Hidden = activoIA
                .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = activoSR
                .DisplayLayout.Bands(0).Columns("CantidadPorAtender").Hidden = activoCA
                .DisplayLayout.Bands(0).Columns("CantidadAAtender").Hidden = activoCAA
                If Operacion <> "Nuevo" Then
                    .DisplayLayout.Bands(0).Columns("Cantidad").CellActivation = Activation.NoEdit
                Else
                    .DisplayLayout.Bands(0).Columns("Cantidad").CellActivation = Activation.AllowEdit
                End If
                .DisplayLayout.Bands(0).Columns("CantidadAAtender").CellClickAction = cellClickAction
                '.DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("CantidadPorRegularizar").Hidden = cantPorRegularizar
                .DisplayLayout.Bands(0).Columns("CantidadARegularizar").Hidden = cantARegul
                .DisplayLayout.Bands(0).Columns("IndRegularizado").Hidden = IndRegularizar
            End With
            With grilla_OA_Material
                .DisplayLayout.Bands(0).Columns("CantidadPorAtender").Hidden = activoCA
                .DisplayLayout.Bands(0).Columns("CantidadAAtender").Hidden = activoCAA
                .DisplayLayout.Bands(0).Columns("CantidadAAtender").CellClickAction = cellClickAction
                .DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.NoEdit
                If Operacion <> "Nuevo" Then
                    .DisplayLayout.Bands(0).Columns("Cantidad").CellActivation = Activation.NoEdit
                Else
                    .DisplayLayout.Bands(0).Columns("Cantidad").CellActivation = Activation.AllowEdit
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub controlaColumnasServicio(ByVal activoIA As Boolean, ByVal activoSR As Boolean, ByVal visibleLisSer As Boolean)
        Try
            With griListaServiciosRequeridos
                .DisplayLayout.Bands(0).Columns("IndicadorAprobacion").Hidden = activoIA
                .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = activoSR
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub obtenerCantidadTotalAtender(ByVal oeReqMat As e_RequerimientoMaterial)
        Try
            cantTotalAtender += oeReqMat.CantidadAAtender
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub obtenerCantidadTotalRegulariar(ByVal oeReqMat As e_RequerimientoMaterial)
        Try
            cantTotalRegularizar += oeReqMat.CantidadARegularizar
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub EvaluarRequerimiento()
        Try
            Throw New Exception("No se pueden evaluar los requerimientos")
            tipoOperacionDetReq = "2"
            controlaColumnasMateriales(False, True, True, True, False, 0, True, True, True)
            controlaColumnasServicio(False, True, False)
            ValidaFicha()
            Inicializar()
            If VerificarPermisoAprobacion() Then
                lbl_etiqueta.Text = "Evaluando RQ"
                lbl_etiqueta.Visible = 1
                CodigoBarras(False)
                Operacion = "Editar"
                'If VerificarRegistroEditado() Then
                If EditarRequerimiento() Then
                    oeRequerimiento.TipoOperacion = "C"
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                    'GuardarRegistroEditado()
                End If
                'End If
            Else
                Throw New Exception("No Tiene Permiso Para Evaluar Requerimientos")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Public Sub AtenderRequerimientos()
        Try
            tipoOperacionDetReq = "4"
            controlaColumnasMateriales(True, True, False, False, False, 4, True, True)
            grid_MaterialRequeridos.DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.AllowEdit
            grilla_OA_Material.DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.AllowEdit
            ValidaFicha()
            Inicializar()
            lbl_etiqueta.Text = "Atendiendo RQ"
            CodigoBarras(True)
            lbl_etiqueta.Visible = 1
            Operacion = "Editar"
            'If VerificarRegistroEditado() Then
            If EditarRequerimiento() Then
                oeRequerimiento.TipoOperacion = "D"
                oeRequerimiento.IdUsuarioAtencion = gUsuarioSGI.Id
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                'GuardarRegistroEditado()
            End If
            txtCodigoBarras.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub GuardarRegistroEditado()
        'If RegistroEditado = 1 Then
        '    oeRegistroEditado = New e_RegistrosEditados
        '    With oeRegistroEditado
        '        .IdRegistro = griListaRequerimientos.ActiveRow.Cells("Id").Value()
        '        .Referencia = "Requerimiento"
        '        .UsuarioEdita = gUsuarioSGI.Id
        '    End With
        '    IdRegistroEditado = olRegistroEditado.Guardar(oeRegistroEditado)
        'End If
    End Sub

    Public Function VerificarRegistroEditado() As Boolean
        'Try
        '    Dim oeReq As New e_Requerimiento
        '    Dim olReq As New l_Requerimiento
        '    oeReq.Id = griListaRequerimientos.ActiveRow.Cells("Id").Value
        '    oeReq.TipoOperacion = "6"
        '    oeReq = olReq.Obtener(oeReq)
        '    If oeReq.UsuarioCreacion <> "" Then
        '        If oeReq.IdArea <> gUsuarioSGI.oePersona.NombreCompleto Then
        '            mensajeEmergente.Confirmacion("La información del Requerimiento no es accesible pues esta siendo editado por" & Environment.NewLine & Environment.NewLine & _
        '                                "el Usuario: " & oeReq.IdArea & Environment.NewLine & _
        '                                "desde: " & oeReq.FechaCreacion & Environment.NewLine & _
        '                                "en la Sucursal: " & oeReq.IdUsuarioAtencion, True)
        '            Return False
        '        Else
        '            oeRegistroEditado = New e_RegistrosEditados
        '            With oeRegistroEditado
        '                .TipoOperacion = "A"
        '                .Id = oeReq.UsuarioCreacion
        '                .FechaModificado = DateAdd(DateInterval.Minute, 5, oeReq.FechaCreacion)
        '            End With
        '            olRegistroEditado.Guardar(oeRegistroEditado)
        '            RegistroEditado = 1
        '        End If
        '    Else
        '        RegistroEditado = 1
        '    End If
        '    Return True
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Function

    Private Function ActualizaRegistroEditado() As Boolean
        'Try
        '    If RegistroEditado = 1 Then
        '        oeRegistroEditado = New e_RegistrosEditados
        '        With oeRegistroEditado
        '            .Id = IdRegistroEditado
        '        End With
        '        olRegistroEditado.Guardar(oeRegistroEditado)
        '        RegistroEditado = 0
        '    End If
        '    Return True
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Function

    Private Function VerificarPermisoAprobacion() As Boolean
        Try
            Dim oeTrabSeg As New e_TrabajadorSeguridad
            Dim olTrabSeg As New l_TrabajadorSeguridad
            oeTrabSeg.IdTrabajador = gUsuarioSGI.IdTrabajador
            oeTrabSeg.TipoOperacion = "H"
            oeTrabSeg.NombreProceso = "APROBACION DE REQUERIMIENTOS"
            oeTrabSeg = olTrabSeg.Obtener(oeTrabSeg)
            If oeTrabSeg.IdTrabajador = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub RegularizarRequerimientos()
        Try
            tipoOperacionDetReq = "R"
            controlaColumnasMateriales(True, True, True, True, False, 4, False, False, True)
            grid_MaterialRequeridos.DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.AllowEdit
            grilla_OA_Material.DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.AllowEdit
            ValidaFicha()
            Inicializar()
            lbl_etiqueta.Text = "Regularizando RQ"
            lbl_etiqueta.Visible = 1
            CodigoBarras(True)
            Operacion = "Editar"
            'If VerificarRegistroEditado() Then
            If EditarRequerimiento() Then
                oeRequerimiento.TipoOperacion = "R"
                oeRequerimiento.IdUsuarioAtencion = gUsuarioSGI.Id
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                'GuardarRegistroEditado()
            End If
            'End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub ControlarEstadoRequerimiento()
        btnAtenderReq.Enabled = 0
        If grid_Requerimientos.ActiveRow.Index > -1 Then
            If cboRequerimiento.Text = "MATERIALES" Then
                Select Case grid_Requerimientos.ActiveRow.Cells("EstadoRequerimiento").Value
                    Case "EVALUADO", "PARCIALMENTE ATENDIDO"
                        btnAtenderReq.Enabled = 1
                        If grid_Requerimientos.ActiveRow.Cells("TipoReferencia").Value <> "ORDEN ASIGNACION" Then
                            btnRegReq.Enabled = 1
                        End If
                End Select
            Else
                Select Case grid_Requerimientos.ActiveRow.Cells("EstadoRequerimiento").Value
                    Case "GENERADO"
                End Select
            End If
        End If
    End Sub

    Public Sub LlenaComboCategoriaServicios()
        Try
            oeCategoriaServicio.Id = "CERO" : oeCategoriaServicio.Nombre = "TODOS"
            lstCategoriasServicio.Add(oeCategoriaServicio)
            oeCategoriaServicio = New e_CategoriaServicio
            oeCategoriaServicio.Activo = True
            lstCategoriasServicio.AddRange(olCategoriaServicio.Listar(oeCategoriaServicio))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarRM_Detalle(ByVal lsIdRequerimiento As String)
        Try

            oeDetalleMaterialAsignacion = New e_DetalleMaterialAsignacion
            oeDetalleMaterialAsignacion.TipoOperacion = "1"
            oeDetalleMaterialAsignacion.Activo = True
            oeDetalleMaterialAsignacion.IdRequerimiento = lsIdRequerimiento

            ds_RM_DE = olDetalleMaterialAsignacion.ListarDetalle(oeDetalleMaterialAsignacion)
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) UnidadAsignacion
            'Tabla(1) Material
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Dim parentCol As DataColumn = ds_RM_DE.Tables(0).Columns("IdDetalleRequerimiento")
            'Dim childCol As DataColumn = ds_RM_DE.Tables(1).Columns("IdRequerimientoMaterial")
            'relation = New DataRelation("FK_Relacion", parentCol, childCol, True)
            'ds_RM_DE.Relations.Add(relation)

            'ds_RM_DE.AcceptChanges()
            grilla_OA_Material.DataSource = ds_RM_DE
            llenaCombosGrillaMaterialRequerido(grilla_OA_Material)
            asignarColoresSegunEstado(grilla_OA_Material)
            Agrupacion8.Text = "Materiales requeridos : " & ds_RM_DE.Tables(0).Rows.Count
            With grilla_OA_Material.DisplayLayout
                'ocultar
                .Bands(0).Columns("Id").Hidden = True
                .Bands(0).Columns("IndRegularizado").Hidden = True
                .Bands(0).Columns("CantidadPorRegularizar").Hidden = True
                .Bands(0).Columns("CodigoMaterial").Width = 100
                .Bands(0).Columns("Cantidad").MaskInput = "{double:9.2}"
                .Bands(0).Columns("CantidadAAtender").MaskInput = "{double:9.2}"
                .Bands(0).Columns("CantidadPorAtender").MaskInput = "{double:9.2}"

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EstadosValueList(ByVal stGrilla As UltraWinGrid.UltraGrid)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            stGrilla.DisplayLayout.ValueLists.Clear()
            objValueList = stGrilla.DisplayLayout.ValueLists.Add("Estados")
            Dim dt As DataTable = olEstado.ComboGrilla(loEstado)
            For i As Integer = 0 To dt.Rows.Count - 1
                objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MarcasValueList(ByVal stGrilla As UltraWinGrid.UltraGrid)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            stGrilla.DisplayLayout.ValueLists.Clear()
            objValueList = stGrilla.DisplayLayout.ValueLists.Add("Marcas")

            oeMarca = New e_Marca
            oeMarca.TipoOperacion = "" 'Verificar 
            oeMarca.Activo = True
            Dim dt As DataTable = olMarca.ComboGrilla(loMarca)
            If dt.Rows.Count = 0 Then Throw New Exception("Información no registrada")

            For i As Integer = 0 To dt.Rows.Count - 1
                objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ModelosValueList(ByVal lsIdMarca As String, ByVal stGrilla As UltraWinGrid.UltraGrid)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            stGrilla.DisplayLayout.ValueLists.Clear()
            objValueList = stGrilla.DisplayLayout.ValueLists.Add("Modelos")
            Dim dt As DataTable = olModelo.ComboGrilla(loModelo)
            If dt.Rows.Count = 0 Then Throw New Exception("Información no registrada")

            For i As Integer = 0 To dt.Rows.Count - 1
                objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AgregarReqMatDetalle(ByVal lsIdRM As String, ByVal cant As Integer)
        Try
            ds_RM_DE.Tables(1).AcceptChanges()

            For Each matRow As DataRow In ds_RM_DE.Tables(1).Rows
                If matRow("IdRequerimientoMaterial") = lsIdRM And matRow("Id") = "" Then
                    matRow.Delete()
                End If
            Next

            For i As Integer = 0 To cant - 1
                Dim row As DataRow
                row = ds_RM_DE.Tables(1).NewRow
                row("Id") = ""
                row("IdRequerimientoMaterial") = lsIdRM
                row("IdMarca") = ""
                row("IdModelo") = ""
                row("IdEstado") = ""
                row("Serie") = ""
                row("Especificaciones") = ""
                ds_RM_DE.Tables(1).Rows.Add(row)
                ds_RM_DE.Tables(1).AcceptChanges()
                ds_RM_DE.AcceptChanges()
            Next
            grilla_OA_Material.DataBind()
            With grilla_OA_Material
                'For i As Integer = 0 To .Rows.Count - 1
                '    For Each aChildBand1 As UltraGridChildBand In .Rows(i).ChildBands
                '        For Each fila As UltraGridRow In aChildBand1.Rows
                '            For y As Integer = 0 To aChildBand1.Rows.Count - 1
                '                MarcasValueList(grilla_OA_Material)
                '                aChildBand1.Rows(y).Cells("IdMarca").ValueList = .DisplayLayout.ValueLists("Marcas")
                '                aChildBand1.Rows(y).Cells("IdMarca").Value = "1CH000000000"

                '                ModelosValueList(aChildBand1.Rows(y).Cells("IdMarca").Value.ToString(), grilla_OA_Material)
                '                aChildBand1.Rows(y).Cells("IdModelo").ValueList = .DisplayLayout.ValueLists("Modelos")
                '                aChildBand1.Rows(y).Cells("IdModelo").Value = "1CH000000000"

                '                EstadosValueList(grilla_OA_Material)
                '                aChildBand1.Rows(y).Cells("IdEstado").ValueList = .DisplayLayout.ValueLists("Estados")
                '                aChildBand1.Rows(y).Cells("IdEstado").Value = "1CH00022"
                '            Next
                '        Next
                '    Next
                'Next
                For x As Integer = 0 To .Rows.Count - 1
                    .Rows(x).ExpandAll()
                Next
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BuscarCodigoBarras()
        Try
            Dim loCodBarMar As New List(Of e_CodigoBarraMaterial)
            oeCodBarMat = New e_CodigoBarraMaterial
            Dim flag As Boolean = False
            Dim idReqMat As String = ""
            oeCodBarMat.TipoOperacion = "1"
            oeCodBarMat.CodigoBarras = Trim(Me.txtCodigoBarras.Text)
            loCodBarMar = olCodBarMat.Listar(oeCodBarMat)
            If loCodBarMar.Count > 0 Then
                For Each codbarmat As e_CodigoBarraMaterial In loCodBarMar
                    For Each reqmat As e_RequerimientoMaterial In lstRequerimientoMaterial
                        If codbarmat.IdMaterial = reqmat.IdMaterial Then
                            flag = True
                        End If
                    Next
                Next
                If flag = False Then
                    Throw New Exception("Material no Encontrado en el Requerimiento")
                End If
                Dim listareqmaterial As New List(Of e_RequerimientoMaterial)
                For Each mat As e_RequerimientoMaterial In lstRequerimientoMaterial
                    For Each codmat As e_CodigoBarraMaterial In loCodBarMar
                        If mat.IdMaterial = codmat.IdMaterial Then
                            listareqmaterial.Add(mat)
                        End If
                    Next
                Next
                If listareqmaterial.Count = 1 Then
                    For Each mat As e_RequerimientoMaterial In lstRequerimientoMaterial
                        If mat.IdMaterial = listareqmaterial.Item(0).IdMaterial Then
                            txtMaterial.Text = ""
                            txtMaterial.Text = mat.Material
                            With grid_MaterialRequeridos
                                If .Rows.Count > 0 And txtCodigoBarras.Text <> "" Then
                                    For i = 0 To .Rows.Count - 1
                                        If .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.YellowGreen Then
                                            .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.Khaki
                                        End If
                                        If Trim(.Rows(i).Cells("Id").Value) = mat.Id And .Rows(i).Cells("StockActual").Value > 0 Then
                                            If .Rows(i).Cells("CantidadPorAtender").Value > .Rows(i).Cells("StockActual").Value Then
                                                .Rows(i).Cells("CantidadAAtender").Value = .Rows(i).Cells("StockActual").Value
                                                mensajeEmergente.Problema("Cantidad por Atender Mayor a Stock, Solo se Está Atendiendo: " & .Rows(i).Cells("StockActual").Value, True)
                                            Else
                                                .Rows(i).Cells("CantidadAAtender").Value = .Rows(i).Cells("CantidadPorAtender").Value
                                            End If
                                            .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.YellowGreen
                                            txtMaterial.Text = .Rows(i).Cells("Material").Value
                                        End If
                                    Next
                                End If
                            End With
                            Exit For
                        End If
                    Next
                Else
                    Dim frm As New frm_DetalleCodigoBarra
                    frm.RequerimientoMaterial(listareqmaterial)
                    frm.ShowDialog()
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                    txtMaterial.Text = ""
                    txtMaterial.Text = frm.SeleccionRequerimiento.Material
                    With grid_MaterialRequeridos
                        If .Rows.Count > 0 And txtCodigoBarras.Text <> "" Then
                            For i = 0 To .Rows.Count - 1
                                If .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.YellowGreen Then
                                    .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.Khaki
                                End If
                                If Trim(.Rows(i).Cells("Id").Value) = frm.SeleccionRequerimiento.Id And .Rows(i).Cells("StockActual").Value > 0 Then
                                    If .Rows(i).Cells("CantidadPorAtender").Value > .Rows(i).Cells("StockActual").Value Then
                                        .Rows(i).Cells("CantidadAAtender").Value = .Rows(i).Cells("StockActual").Value
                                        mensajeEmergente.Problema("Cantidad por Atender Mayor a Stock, Solo se Está Atendiendo: " & .Rows(i).Cells("StockActual").Value, True)
                                    Else
                                        .Rows(i).Cells("CantidadAAtender").Value = .Rows(i).Cells("CantidadPorAtender").Value
                                    End If
                                    .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.YellowGreen
                                    txtMaterial.Text = .Rows(i).Cells("Material").Value
                                End If
                            Next
                        End If
                    End With
                End If
            Else
                Throw New Exception("Codigo de Barra no Asignado a Material")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region

#Region "Menu y tabs"

    Public Sub ControlaBarraOperacionesDetalle(ByVal lb_Consultar As Boolean, _
                                   ByVal lb_Agregar As Boolean, ByVal lb_Quitar As Boolean)
        o_Botonera.Consultar = lb_Consultar
        o_Botonera.Guardar = lb_Agregar
        o_Botonera.Eliminar = lb_Quitar
        Botones(o_Botonera)
    End Sub

    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs)
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    ' AgregarDetalle()
                Case "Eliminar"
                    '     QuitarDetalle()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub SubAlmacenValueList(ByVal ls_IdAlmacen As String, ByVal grilla As UltraGrid)
        Try
            Dim lstSubAlmacen As New List(Of e_SubAlmacen)
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            grilla.DisplayLayout.ValueLists.Clear()
            objValueList = grilla.DisplayLayout.ValueLists.Add("SubAlmacenes")
            oeSubalmacen = New e_SubAlmacen
            oeSubalmacen.TipoOperacion = "S"
            oeSubalmacen.Activo = True
            oeSubalmacen.IdAlmacen = ls_IdAlmacen
            lstSubAlmacen = olSubalmacen.Listar_SubAlmacen(oeSubalmacen)
            For Each item As e_SubAlmacen In lstSubAlmacen
                objValueList.ValueListItems.Add(item.Id, item.Descripcion)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Public Sub ValidaBotonesEvaluacionAtencion()

        If oeTrabajador.oeCargo.Nombre = "EMPLEADO DEL AREA" Then
            btnAtenderReq.Visible = False
        Else
            If oeTrabajador.oeCargo.Nombre = "JEFE DE AREA" And oeArea.Nombre = "LOGÍSTICA" Then
                btnAtenderReq.Visible = True
            Else
                btnAtenderReq.Visible = False
            End If
        End If

    End Sub

    Private Sub frm_RequerimientoD2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Para las cabezeras
            ColoresGenerado.Color = Color.White
            ColoresEvaluado.Color = Color.Khaki
            ColoresAtendidoParcialmente.Color = Color.PowderBlue
            ColoresAtendido.Color = Color.LightGreen

            'Para los estados de los detalles
            ColoresGeneradaDetalle.Color = Color.White
            ColoresPreaprobado.Color = Color.Khaki
            ColoresAprobado.Color = Color.PowderBlue
            ColoresRechazado.Color = Color.LightPink
            ColoresPorRegularizar.Color = Color.Turquoise

            'Para los detalles 
            colorAtendido.Color = Color.LightGreen
            colorAtendidoParcial.Color = Color.PowderBlue
            colorPendiente.Color = Color.White

            'Obtener la información del área del usuario        
            oeUsuario.Id = gUsuarioSGI.Id
            oeUsuario = olUsuario.Obtener(oeUsuario)
            oeTrabajador.oePersona.Id = oeUsuario.oePersona.Id
            oeTrabajador = olTrabajador.Obtener(oeTrabajador)
            oeArea = olUsuario.Area(oeUsuario)
            'ValidaBotonesEvaluacionAtencion()


            Dim oeAr As e_Area = New e_Area
            oeAr.Activo = True
            LlenarComboMaestro(cboAreaL, olArea.Listar(oeAr), 0)

            cboRequerimiento.SelectedIndex = 0
            cboFormaBusqueda.SelectedIndex = 0
            rangoFechaDesde.Value = Date.Now.AddDays(-7)
            rangoFechaHasta.Value = Date.Now
            cboAreaL.Enabled = False
            cboAreaL.Value = oeArea.Id
            LlenaComboCategoriaServicios()

            LlenarCombo(cboCentro, "Nombre", CentroPublic, 0)
            cboCentro.Value = gs_PrefijoIdSucursal '@0001

            If PerfilAsignado(gNombrePerfilAdministrador) Or PerfilAsignado(gNombrePerfilJefeAlmacen) _
            Or PerfilAsignado(gNombrePerfilJefeLogistica) Or PerfilAsignado(gNombrePerfilJefeTesoreria) Then
                cboCentro.Enabled = True
            Else
                cboCentro.Enabled = False
            End If

            grid_MaterialRequeridos.DisplayLayout.Bands(0).Columns("IdUnidadMedida").Header.Caption = "U. Medida"
            grid_MaterialRequeridos.DisplayLayout.Bands(0).Columns("IdAlmacen").Header.Caption = "Almacen"
            grid_MaterialRequeridos.DisplayLayout.Bands(0).Columns("IdCentroCosto").Header.Caption = "PreRegistro"
            controlaColumnasMateriales(True, False, True, True, True, 0, False, True)
            controlaColumnasServicio(True, False, True)
            'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficRequerimiento)
            InicializaTiempo()
            CodigoBarras(False)

            LlenarMarModEst()
            AsientoContable()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Requerimiento_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'ActualizaRegistroEditado()
        instancia = Nothing
    End Sub

    Private Sub frm_RequerimientoD2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            'ActualizaRegistroEditado()
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_Requerimientos.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
        mensajeEmergente.Problema("No tiene permisos paa eliminar un requerimiento")
    End Sub

    Private Sub verArea_AfterCheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbArea.AfterCheckStateChanged
        cboAreaL.Enabled = cbArea.Checked
    End Sub

    Private Sub griListaMaterialRequeridos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_MaterialRequeridos.CellChange
        Try
            grid_MaterialRequeridos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaServiciosRequeridos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaServiciosRequeridos.CellChange
        Try
            griListaServiciosRequeridos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_Requerimientos.DoubleClick
        If grid_Requerimientos.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griListaMaterialRequeridos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_MaterialRequeridos.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True
    End Sub

    Private Sub griListaMaterialRequeridos_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grid_MaterialRequeridos.BeforeCellUpdate
        Try
            With grid_MaterialRequeridos
                Select Case e.Cell.Column.Key
                    Case "Cantidad", "CantidadPorAtender", "CantidadAAtender"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                        cantmat = e.Cell.Value
                    Case "Glosa"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            e.Cell.Value = ""
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaMaterialRequeridos_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_MaterialRequeridos.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With grid_MaterialRequeridos.Rows(e.Cell.Row.Index)
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.LightYellow
                            .Appearance.ForeColor = Color.Red
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                        End If
                    End With
                Case "IdAlmacen"
                    Dim oeMat As New e_Material
                    With grid_MaterialRequeridos
                        If .ActiveRow.Index > -1 Then
                            SubAlmacenValueList(.ActiveRow.Cells("IdAlmacen").Value.ToString, grid_MaterialRequeridos)
                            .ActiveRow.Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")
                            oeSubalmacen = New e_SubAlmacen
                            oeSubalmacen.TipoOperacion = "S"
                            oeSubalmacen.Activo = True
                            oeSubalmacen.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value.ToString
                            .ActiveRow.Cells("IdSubAlmacen").Value = olSubalmacen.Obtener(oeSubalmacen).Id

                            oeMat.TipoOperacion = "5"
                            oeMat.Id = .ActiveRow.Cells("IdMaterial").Value
                            oeMat.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value
                            oeMat.Activo = True
                            oeMat.IdSubAlmacen = .ActiveRow.Cells("IdSubAlmacen").Value

                            oeMat = olMaterial.ObtenerMaterialSegunAlmacen(oeMat)
                            .ActiveRow.Cells("StockActual").Value = oeMat.Stock
                            .ActiveRow.Cells("CantidadAAtender").Value = 0
                            .ActiveRow.Cells("CantidadARegularizar").Value = 0
                            .ActiveRow.Cells("Precio").Value = ObtenerValorUnitario(.ActiveRow.Cells("IdMaterial").Value, .ActiveRow.Cells("IdSubAlmacen").Value)
                        End If
                    End With
                Case "IdSubAlmacen"
                    Dim oeMat As New e_Material
                    With grid_MaterialRequeridos
                        If .ActiveRow.Index > -1 Then
                            oeMat.TipoOperacion = "5"
                            oeMat.Id = .ActiveRow.Cells("IdMaterial").Value
                            oeMat.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value
                            oeMat.Activo = True
                            oeMat.IdSubAlmacen = .ActiveRow.Cells("IdSubAlmacen").Value

                            oeMat = olMaterial.ObtenerMaterialSegunAlmacen(oeMat)
                            .ActiveRow.Cells("StockActual").Value = oeMat.Stock
                            .ActiveRow.Cells("CantidadAAtender").Value = 0
                            .ActiveRow.Cells("CantidadARegularizar").Value = 0
                            .ActiveRow.Cells("Precio").Value = ObtenerValorUnitario(.ActiveRow.Cells("IdMaterial").Value, .ActiveRow.Cells("IdSubAlmacen").Value)
                        End If
                    End With
                Case "CantidadAAtender"
                    Dim cantPorAtender As Double
                    Dim cantAAtender As Double
                    Dim stockActual As Double
                    Dim IdUnidadMedida As String
                    With grid_MaterialRequeridos.ActiveRow
                        If .Index > -1 Then
                            cantAAtender = Convert.ToDouble(.Cells("CantidadAAtender").Value)
                            cantPorAtender = Convert.ToDouble(.Cells("CantidadPorAtender").Value)
                            stockActual = Convert.ToDouble(.Cells("StockActual").Value)
                            If stockActual < 0 Then stockActual = 0
                            If cantAAtender > cantPorAtender Then
                                .Cells("CantidadAAtender").Value = cantPorAtender
                                Throw New Exception("La cantidad ingresada excede a la cantidad por atender.")
                            End If
                            If .Cells("IndRegularizado").Value = True Then
                                IdUnidadMedida = .Cells("IdUnidadMedida").Value
                                cantAAtender = ConvertirUnidadBase(cantAAtender, IdUnidadMedida)
                                If stockActual = 0 And cantAAtender > 0 Then
                                    .Cells("CantidadAAtender").Value = 0
                                    Throw New Exception("No puede atender el material  '" & .Cells("Material").Value & "'  ya que tiene stock 0.")
                                End If
                                If cantAAtender > stockActual Then
                                    .Cells("CantidadAAtender").Value = 0
                                    Throw New Exception("No puede atender el material  '" & .Cells("Material").Value & "'  ya que la cantidad a atender es mayor que el stock actual.")
                                End If
                                'Else
                                '    .Cells("CantidadPorRegularizar").Value = cantAAtender
                            End If
                        End If
                    End With
                Case "CantidadPorAtender"
                    Dim cantPorAtender As Double
                    Dim cantidad As Double
                    With grid_MaterialRequeridos.ActiveRow
                        If .Index > -1 Then
                            cantPorAtender = Convert.ToDouble(.Cells("CantidadPorAtender").Value)
                            cantidad = Convert.ToDouble(.Cells("Cantidad").Value)
                            If cantPorAtender > cantidad Then
                                .Cells("CantidadPorAtender").Value = cantmat
                                Throw New Exception("La cantidad por atender no puede ser mayor que la cantidad requerida.")
                            End If
                        End If
                    End With
                Case "Cantidad"
                    Dim cantidad As Double
                    With grid_MaterialRequeridos.ActiveRow
                        cantidad = Convert.ToDouble(.Cells("Cantidad").Value)
                        If cantidad <= 0 Then
                            .Cells("Cantidad").Value = cantmat
                            Throw New Exception("La cantidad ingresada no puede ser menor o igual a 0. ")
                        End If
                    End With
                Case "IndRegularizado"
                    Dim stock As Double = 0
                    With grid_MaterialRequeridos.ActiveRow
                        stock = Convert.ToDouble(.Cells("StockActual").Value)
                        If .Index > -1 Then
                            If stock = 0 Then
                                If .Cells("IndRegularizado").Value = True Then
                                    .Cells("CantidadAAtender").Value = 0
                                End If
                            ElseIf stock > 0 And .Cells("IndRegularizado").Value = False Then
                                .Cells("IndRegularizado").Value = True
                                'Throw New Exception("Solo puede regularizar materiales con stock igual a 0. ")
                            End If
                        End If
                    End With
                Case "CantidadARegularizar"
                    Dim cantidad As Double = 0
                    Dim stock As Double = 0
                    With grid_MaterialRequeridos.ActiveRow
                        cantidad = Convert.ToDouble(.Cells("CantidadPorRegularizar").Value)
                        stock = Convert.ToDouble(.Cells("StockActual").Value)
                        If stock < 0 Then stock = 0
                        If .Index > -1 Then
                            If .Cells("CantidadARegularizar").Value > cantidad Or .Cells("CantidadARegularizar").Value > stock Then
                                .Cells("CantidadARegularizar").Value = 0
                                .Cells("IndRegularizado").Value = False
                            Else
                                .Cells("IndRegularizado").Value = True
                            End If
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaRequerimientos_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_Requerimientos.AfterRowActivate
        ControlarEstadoRequerimiento()
    End Sub

    Private Sub btnAtenderReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtenderReq.Click
        AtenderRequerimientos()
    End Sub

    Private Sub cboRequerimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRequerimiento.ValueChanged
        oeRequerimiento.MaterialServicio = cboRequerimiento.Value 'M: Material , S:Servicio            
    End Sub

    Private Sub txtDescripcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.ValueChanged
        oeRequerimiento.Descripcion = txtDescripcion.Text
    End Sub

    Private Sub cboFormaBusqueda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFormaBusqueda.ValueChanged
        oeRequerimiento.OpcionFecha = cboFormaBusqueda.Value
    End Sub

    Private Sub UltraTextEditor1_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs)
        grid_MaterialRequeridos.ActiveRow.Cells("CantidadAAtender").Value = grid_MaterialRequeridos.ActiveCell.Value
    End Sub

    Private Sub grilla_OA_Material_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grilla_OA_Material.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With grilla_OA_Material.Rows(e.Cell.Row.Index)

                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.LightYellow
                            .Appearance.ForeColor = Color.Red
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                        End If
                    End With
                Case "IdAlmacen"
                    Dim oeMat As New e_Material
                    With grilla_OA_Material
                        If .ActiveRow.Index > -1 Then
                            oeMat.TipoOperacion = "5"
                            oeMat.Id = .ActiveRow.Cells("IdMaterial").Value
                            oeMat.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value
                            oeMat.Activo = True
                            oeMat = olMaterial.ObtenerMaterialSegunAlmacen(oeMat)
                            .ActiveRow.Cells("StockActual").Value = oeMat.Stock
                            .ActiveRow.Cells("CantidadAAtender").Value = 0
                            SubAlmacenValueList(.ActiveRow.Cells("IdAlmacen").Value.ToString, grilla_OA_Material)
                            .ActiveRow.Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")

                            oeSubalmacen = New e_SubAlmacen
                            oeSubalmacen.TipoOperacion = "S"
                            oeSubalmacen.Activo = True
                            oeSubalmacen.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value.ToString
                            .ActiveRow.Cells("IdSubAlmacen").Value = olSubalmacen.Obtener(oeSubalmacen).Id
                        End If
                    End With
                Case "IdSubAlmacen"
                    Dim oeMat As New e_Material
                    With grilla_OA_Material
                        If .ActiveRow.Index > -1 Then
                            oeMat.TipoOperacion = "5"
                            oeMat.Id = .ActiveRow.Cells("IdMaterial").Value
                            oeMat.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value
                            oeMat.Activo = True
                            oeMat.IdSubAlmacen = .ActiveRow.Cells("IdSubAlmacen").Value

                            oeMat = olMaterial.ObtenerMaterialSegunAlmacen(oeMat)
                            .ActiveRow.Cells("StockActual").Value = oeMat.Stock
                            .ActiveRow.Cells("CantidadAAtender").Value = 0
                            .ActiveRow.Cells("Precio").Value = ObtenerValorUnitario(.ActiveRow.Cells("IdMaterial").Value, .ActiveRow.Cells("IdSubAlmacen").Value)
                        End If
                    End With
                Case "CantidadAAtender"
                    Dim cantPorAtender As Double
                    Dim cantAAtender As Double
                    Dim stockActual As Double
                    Dim IdUnidadMedida As String
                    With grilla_OA_Material.ActiveRow
                        If .Index > -1 Then

                            cantAAtender = Convert.ToDouble(.Cells("CantidadAAtender").Value)
                            cantPorAtender = Convert.ToDouble(.Cells("CantidadPorAtender").Value)
                            stockActual = Convert.ToDouble(.Cells("StockActual").Value)
                            If stockActual < 0 Then stockActual = 0
                            If cantAAtender > cantPorAtender Then
                                .Cells("CantidadAAtender").Value = cantPorAtender
                                Throw New Exception("La cantidad ingresada excede a la cantidad por atender.")
                            End If

                            IdUnidadMedida = .Cells("IdUnidadMedida").Value
                            cantAAtender = ConvertirUnidadBase(cantAAtender, IdUnidadMedida)
                            If stockActual = 0 And cantAAtender > 0 Then
                                .Cells("CantidadAAtender").Value = 0
                                Throw New Exception("No puede atender el material  '" & .Cells("Material").Value & "'  ya que tiene stock 0.")
                            End If
                            If cantAAtender > stockActual Then
                                .Cells("CantidadAAtender").Value = 0
                                Throw New Exception("No puede atender el material  '" & .Cells("Material").Value & "'  ya que la cantidad a atender es mayor que el stock actual.")
                            End If
                            AgregarReqMatDetalle(.Cells("IdDetalleRequerimiento").Value, Convert.ToInt64(cantAAtender))
                        End If
                    End With

                Case "CantidadPorAtender"
                    Dim cantPorAtender As Double
                    Dim cantidad As Double
                    With grilla_OA_Material.ActiveRow
                        If .Index > -1 Then
                            cantPorAtender = Convert.ToDouble(.Cells("CantidadPorAtender").Value)
                            cantidad = Convert.ToDouble(.Cells("Cantidad").Value)
                            If cantPorAtender > cantidad Then
                                .Cells("CantidadPorAtender").Value = cantmat
                                Throw New Exception("La cantidad por atender no puede ser mayor que la cantidad requerida.")
                            End If
                        End If
                    End With
                Case "Cantidad"
                    Dim cantidad As Double
                    With grilla_OA_Material.ActiveRow

                        cantidad = Convert.ToDouble(.Cells("Cantidad").Value)
                        If cantidad <= 0 Then
                            .Cells("Cantidad").Value = cantmat
                            Throw New Exception("El cantidad ingresada no puede ser menor o igual a 0. ")
                        End If
                    End With
                Case "IdMarca"
                    With grilla_OA_Material
                        If .ActiveRow.Band.Index = 1 Then
                            If .ActiveRow.Index > -1 Then
                                ModelosValueList(.ActiveRow.Cells("IdMarca").Value.ToString, grilla_OA_Material)
                                .ActiveRow.Cells("IdModelo").ValueList = .DisplayLayout.ValueLists("Modelos")
                                .ActiveRow.Cells("IdModelo").Value = .ActiveRow.Cells("IdMarca").Value.ToString
                            End If
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grilla_OA_Material_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grilla_OA_Material.BeforeCellUpdate
        With grilla_OA_Material
            Select Case e.Cell.Column.Key
                Case "Cantidad", "CantidadPorAtender", "CantidadAAtender"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
                    cantmat = e.Cell.Value

                Case "Glosa"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
            End Select
        End With
    End Sub

    Private Sub grilla_OA_Material_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grilla_OA_Material.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub UltraTextEditor2_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs)
        grilla_OA_Material.ActiveRow.Cells("CantidadAAtender").Value = grilla_OA_Material.ActiveCell.Value
    End Sub

    Private Sub griListaMaterialRequeridos_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_MaterialRequeridos.ClickCellButton
        Try
            Dim oeReqMat As New e_RequerimientoMaterial
            Dim odReqMat As New l_RequerimientoMaterial
            With grid_MaterialRequeridos
                Select Case e.Cell.Column.Key
                    Case "CantidadPorAtender"
                        .ActiveRow.Cells("CantidadAAtender").Value = grid_MaterialRequeridos.ActiveCell.Value
                        .ActiveRow.Selected = True
                    Case "CantidadPorRegularizar"
                        .ActiveRow.Cells("CantidadARegularizar").Value = grid_MaterialRequeridos.ActiveCell.Value
                        .ActiveRow.Selected = True
                    Case "Glosa"
                        Dim glosa As String = .ActiveRow.Cells("Glosa").Value
                        If IsDBNull(glosa) Then grid_MaterialRequeridos.ActiveRow.Cells("Glosa").Value = ""
                        oeReqMat.Id = .ActiveRow.Cells("Id").Value
                        oeReqMat.Glosa = .ActiveRow.Cells("Glosa").Value
                        oeReqMat.Tipooperacion = "G"
                        oeReqMat.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If odReqMat.Guardar(oeReqMat) Then
                            mensajeEmergente.Confirmacion("Glosa Actualizada")
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grilla_OA_Material_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grilla_OA_Material.ClickCellButton
        Try
            Dim oeReqMat As New e_RequerimientoMaterial
            Dim odReqMat As New l_RequerimientoMaterial
            With grilla_OA_Material
                Select Case e.Cell.Column.Key
                    Case "CantidadPorAtender"
                        .ActiveRow.Cells("CantidadAAtender").Value = grilla_OA_Material.ActiveCell.Value
                    Case "Glosa"
                        oeReqMat.Id = .ActiveRow.Cells("Id").Value
                        oeReqMat.Glosa = .ActiveRow.Cells("Glosa").Value
                        oeReqMat.Tipooperacion = "G"
                        oeReqMat.PrefijoID = gs_PrefijoIdSucursal
                        If odReqMat.Guardar(oeReqMat) Then
                            mensajeEmergente.Confirmacion("Glosa Actualizada")
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grilla_OA_Material_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grilla_OA_Material.CellChange
        Try
            grilla_OA_Material.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub fecFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFecha.ValueChanged
        oeRequerimiento.FechaCreacion = fecFecha.Value
    End Sub

    Private Sub fecAtencion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecAtencion.ValueChanged
        Try
            If fecAtencion.Value < Date.Today AndAlso Operacion = "Nuevo" Then
                fecAtencion.Value = Date.Today
                Throw New Exception("La fecha de requerimiento no puede ser anterior a hoy")
            End If
            oeRequerimiento.FechaAtencion = fecAtencion.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnRegReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegReq.Click
        RegularizarRequerimientos()
    End Sub

    Private Sub griListaMaterialRequeridos_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_MaterialRequeridos.InitializeLayout
        e.Layout.Bands(0).Columns("Glosa").Nullable = Nullable.Nothing
    End Sub

    Private Sub txtCodigoBarras_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoBarras.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                If txtCodigoBarras.Text <> "" Then
                    BuscarCodigoBarras()
                    txtCodigoBarras.Text = ""
                    txtCodigoBarras.Focus()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_RequerimientoD2_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
                If lbl_etiqueta.Visible = 0 And (oeRequerimiento.EstadoRequerimiento.Equals("EVALUADO") Or oeRequerimiento.EstadoRequerimiento.Contains("ATENDIDO")) Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 1)
                End If
            Case "Inicializa"
                Tiempo1.Enabled = False
                InicializaTiempo()
                MostrarTabs(0, ficRequerimiento)
                Consultar(True)
            Case "Ayuda"

        End Select

    End Sub

    Private Sub frm_RequerimientoD2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griLista_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_Requerimientos.MouseMove
        If _tiempo <= 0 Then
            Listar(True)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        grid_Requerimientos.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Eliminar()
    End Sub

    Private Sub EvaluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EvaluarRequerimiento()
    End Sub

    Private Sub AtenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtenderToolStripMenuItem.Click
        AtenderRequerimientos()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("AtenderToolStripMenuItem").Enabled = 0
        If grid_Requerimientos.Selected.Rows.Count > 0 Then
            ControlarEstadoRequerimiento()
            If cboRequerimiento.Text = "MATERIALES" Then
                Select Case grid_Requerimientos.ActiveRow.Cells("EstadoRequerimiento").Value
                    Case "GENERADO"
                    Case "EVALUADO", "PARCIALMENTE ATENDIDO"
                        MenuContextual1.Items("AtenderToolStripMenuItem").Enabled = 1
                End Select
            Else
                Select Case grid_Requerimientos.ActiveRow.Cells("EstadoRequerimiento").Value
                    Case "GENERADO"
                End Select
            End If
        End If
    End Sub

#End Region

    Private Sub LlenarMarModEst()
        Try
            oeEstado = New e_Estado
            oeEstado.Nombre = "USO DEL MATERIAL"
            loEstado.AddRange(olEstado.Listar(oeEstado))

            oeMarca = New e_Marca
            oeMarca.TipoOperacion = "" 'Verificar 
            oeMarca.Activo = True
            loMarca.AddRange(olMarca.Listar(oeMarca))

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsientoContable()
        AsientoModelo()
        CtaCtbleSubFamilia()
        dtReferencia = New DataTable
        dtReferencia = GeneraDTRef(loReferencia)
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        olAsientoModelo = New l_AsientoModelo
        loAsientoModelo = New List(Of e_AsientoModelo)
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = pIdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        olReferencia = New l_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Private Sub CtaCtbleSubFamilia()
        oeCtaCtbleSFam = New e_CtaCtbleSubFamiliaMat
        olCtaCtbleSFam = New l_CtaCtbleSubFamiliaMat
        loCtaCtbleSFam = New List(Of e_CtaCtbleSubFamiliaMat)
        loCtaCtbleSFam = olCtaCtbleSFam.Listar(oeCtaCtbleSFam)
    End Sub

    Public Sub ObtenerAsientoModelo(IdMoneda As String, Ejercicio As Integer)
        Try
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModelo = New e_AsientoModelo
            oeAsientoModelo.TipoOperacion = "" : oeAsientoModelo.Activo = True
            oeAsientoModelo.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModelo.Ejercicio = Ejercicio
            oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)
            oeOrdenSalida.loAsientoModelo = New List(Of e_AsientoModelo)
            oeOrdenSalida.loAsientoModelo.Add(oeAsientoModelo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class