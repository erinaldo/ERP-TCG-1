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

Public Class frm_Requerimiento
    Inherits frm_MenuPadre

#Region "Inicialización del formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Requerimiento = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        'Operacion = "Inicializa"
        If instancia Is Nothing Then
            instancia = New frm_Requerimiento()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim oeRequerimiento As e_Requerimiento
    Dim olRequerimiento As l_Requerimiento
    Dim oeEstadoRequerimiento As e_EstadoRequerimiento, olEstadoRequerimiento As l_EstadoRequerimiento

    Dim oeMaterial, oeMaterialSubFamilia As e_Material
    Dim olMaterial As l_Material
    Dim llMaterial As List(Of e_Material)
    Dim olRequerimientoMaterial As l_RequerimientoMaterial
    Dim oeRequerimientoMaterial As e_RequerimientoMaterial
    Dim lstRequerimientoMaterial As List(Of e_RequerimientoMaterial)

    Dim oeControlEntregaMaterial As e_ControlEntregaMaterial
    Dim olControlEntregaMaterial As l_ControlEntregaMaterial

    Dim oeServicio As e_Servicio
    Dim olServicio As l_Servicio
    Dim llServicio As List(Of e_Servicio)
    Dim olRequerimientoServicio As l_RequerimientoServicio
    Dim oeRequerimientoServicio As e_RequerimientoServicio
    Dim llRequerimientoServicio As List(Of e_RequerimientoServicio)

    Dim oeCategoriaServicio As e_CategoriaServicio
    Dim olCategoriaServicio As l_CategoriaServicio
    Dim lstCategoriasServicio As List(Of e_CategoriaServicio)

    Dim olArea As l_Area
    Dim oeArea As e_Area

    Dim oeUnidadMedida As e_UnidadMedida
    Dim olUnidadMedida As l_UnidadMedida

    Dim olMaterialAlmacen As l_MaterialAlmacen
    Dim oeMaterialAlmacen As e_MaterialAlmacen

    'Manejador de Subalmacen
    Dim oeSubalmacen As e_SubAlmacen
    Dim olSubalmacen As l_SubAlmacen

    Dim oeCentroCosto As e_CentroCosto
    Dim olCentroCosto As l_CentroCosto

    Dim olUsuario As l_Usuario
    Dim oeUsuario As e_Usuario
    Dim oeTrabajador As e_Trabajador
    Dim olTrabajador As l_Trabajador
    Dim _ingresando_datos As Boolean = False

    Dim oeIGV As e_Impuesto
    Dim olIGV As l_Impuesto

    Dim tipoOperacionDetReq As String

    '---------------Datos para atención de requerimientos------------------
    Dim cantTotalAtender As Double
    Dim cantTotalRegularizar As Double
    Dim oeMovimientoInventario As New e_MovimientoInventario, olMovimientoInventario As l_MovimientoInventario

    Dim oeOrdenSalida As e_Orden, olOrdenSalida As l_Orden
    Dim oeDetalleOrdenSalida As e_OrdenMaterial
    Dim lstDetalleOrdenSalida As List(Of e_OrdenMaterial)
    '----------------------------------------------------------------------

    '------------Manejador de Inventario:Ejecucion de la ordenes de salida---------------------
    Dim oeRegistroInventario As e_RegistroInventario
    Dim olRegistroInventario As l_RegistroInventario
    Dim listaRegistroInventario As List(Of e_RegistroInventario)
    '----------------------------------------------------------------------------------------
    Dim cantmat As Double = 0

    '---- Para OA DetalleOrdenAsignacion
    Dim oeDetalleMaterialAsignacion As e_DetalleMaterialAsignacion
    Dim olDetalleMaterialAsignacion As l_DetalleMaterialAsignacion
    Dim oeModelo As e_Modelo, oeMarca As e_Marca, oeEstado As e_Estado, loMarca As List(Of e_Marca), IdModelo As String = ""
    Dim olModelo As l_Modelo, olMarca As l_Marca, olEstado As l_Estado, loModelo As List(Of e_Modelo), loEstado As List(Of e_Estado)
    Dim ds_RM_DE As DataSet
    Dim relation As DataRelation
    Dim Referencia As String = ""
    Dim oeDetMA As e_DetalleMaterialAsignacion

    '---- Para Hacer el Ingreso en la Asignacion
    Dim oeRegInv As e_RegistroInventario
    Dim oeDetalleAsignacion As e_DetalleAsignacion
    Dim ls_IdSubAlmacenAsignacion As String = ""
    'Dim oeSubAlmacenIngreso As New e_SubAlmacen
    Dim oeOrdenIngreso As e_Orden
    Dim oeDetalleOrdenIngreso As e_OrdenMaterial
    Dim lstDetalleOrdenIngreso As List(Of e_OrdenMaterial)
    'Manejador de Inventario
    Dim oeInventario As e_Inventario
    Dim olInventario As l_Inventario
    Dim listaInventario As List(Of e_Inventario)

    Public Prefijo As l_Configuracion

    Private oeCodBarMat As e_CodigoBarraMaterial
    Private olCodBarMat As l_CodigoBarraMaterial

    Dim RegistroEditado As Integer = 0
    Dim IdRegistroEditado As String = ""

    Dim oeRegistroEditado As e_RegistrosEditados
    Dim olRegistroEditado As l_RegistrosEditados

    'Para Detalle De Orden de Salida a Pre Registro de Neumatico
    Private oeDetOrdenNeu As e_DetalleOrdenNeumatico
    Private olDetOrdenNeu As l_DetalleOrdenNeumatico
    Private leDetOrdenNeu As List(Of e_DetalleOrdenNeumatico)

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

    Private olTrabajadorSeguridad As l_TrabajadorSeguridad
    Private IndOtMack As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar(Activo)
            Tiempo1.Enabled = True
            ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Inicializar()
            Operacion = "Nuevo"
            ValidaFicha()
            controlaColumnasMateriales(1, 0, 1, 1, 1, 0, 1, 1, 1)
            controlaColumnasServicio(True, False, True)
            ConsultarDetalle(True)
            MostrarTabs(1, ficRequerimiento, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            oeEstadoRequerimiento = New e_EstadoRequerimiento
            oeEstadoRequerimiento.Nombre = "GENERADO"
            oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)
            oeRequerimiento.IdEstadoRequerimiento = oeEstadoRequerimiento.Id
            CodigoBarras(False)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            tipoOperacionDetReq = "2"
            controlaColumnasMateriales(True, False, True, True, True, 0, True, True)
            controlaColumnasServicio(True, False, True)
            ValidaFicha()
            Inicializar()
            Operacion = "Editar"
            CodigoBarras(False)
            If EditarRequerimiento() Then
                ConsultarDetalle(False)
                If oeRequerimiento.EstadoRequerimiento = "ATENDIDO" Or oeRequerimiento.EstadoRequerimiento = "EVALUADO" Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 0) 'Inhabilito el boton Guardar
                    gbeMateriales.Visible = False 'Oculto el listado de materiales
                    gbeServicios.Visible = False  'Oculto el listado de servicios
                Else
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0) 'Habilito el boton Guardar                
                End If
                griListaMaterialRequeridos.DisplayLayout.Bands(0).Columns("Glosa").Style = ColumnStyle.EditButton
                VerificarOTMack()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRequerimiento() Then
                ActualizaRegistroEditado()
                MostrarTabs(0, ficRequerimiento, 2)
                InicializaTiempo()
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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
                            Consultar(True)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficRequerimiento, 2)
                        _ingresando_datos = False
                        Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficRequerimiento, 2)
                Consultar(True)
            End If
            ActualizaRegistroEditado()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griListaRequerimientos
                If .ActiveRow.Index > -1 Then
                    If ValidarGrilla(griListaRequerimientos, "Requerimiento") Then
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
                                Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
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
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficRequerimiento.Tabs(0).Selected() AndAlso griListaRequerimientos.Rows.Count = 0 Then Throw New Exception("No hay ningún requerimiento para exportar al Excel")
            If ficRequerimiento.Tabs(0).Selected() Then Exportar_Excel(griListaRequerimientos)
            If ficRequerimiento.Tabs(1).Selected() Then
                If ficDetalle.Tabs(0).Selected() Then
                    If griListaMaterialRequeridos.Rows.Count = 0 Then Throw New Exception("No hay ningún material para exportar al Excel")
                    Exportar_Excel(griListaMaterialRequeridos)
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
            IndOtMack = False
            oeIGV = New e_Impuesto
            oeIGV = olIGV.IGV(fecFecha.Value)
            oeRequerimiento = New e_Requerimiento
            ls_IdSubAlmacenAsignacion = ""
            LimpiarListas()
            oeRequerimiento.TipoOperacion = "I"
            ControlaBarraOperacionesDetalle(1, 0, 0)
            agrMaterialesRequeridos.Text = "Materiales requeridos : 0"
            agrMateriales.Text = "Materiales : 0"
            oeRequerimiento.IdArea = oeArea.Id 'cboAreaM.Value
            oeRequerimiento.UsuarioCreacion = gUsuarioSGI.Id
            fecFecha.Value = Date.Now
            fecAtencion.Value = Date.Now
            txtDescripcion.Value = String.Empty
            txtArea.Value = oeArea.Nombre
            txtBuscarMateriales.Value = String.Empty
            txtCodigo.Value = String.Empty
            txtCodigoBarras.Text = String.Empty
            txtMaterial.Text = String.Empty
            Me.btnActualizarDetalle.Enabled = False
            uebHistorialMaterial.Expanded = False
            cboCategoriaServicios.SelectedIndex = 0
            oeRequerimiento.MaterialServicio = cboRequerimiento.Value
            lbl_etiqueta.Visible = 0
            With griListaMaterialRequeridos.DisplayLayout.Bands(0)
                .Columns("Glosa").Style = ColumnStyle.Default
                .Columns("IdAlmacen").CellActivation = Activation.AllowEdit
                .Columns("IdSubAlmacen").CellActivation = Activation.AllowEdit
            End With  
            cmEquipo.SelectedIndex = -1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CodigoBarras(ByVal Activo As Boolean)
        Me.txtCodigoBarras.Visible = Activo
        Me.txtMaterial.Visible = Activo
        Me.UltraLabel6.Visible = Activo
        Me.UltraLabel7.Visible = Activo
    End Sub

    Private Sub ValidaFicha()
        Try
            If cboRequerimiento.Text = "MATERIALES" Then
                Referencia = ""
                If Operacion <> "Nuevo" Then
                    Referencia = IIf(String.IsNullOrEmpty(griListaRequerimientos.ActiveRow.Cells("Referencia").Value.ToString), "  ", griListaRequerimientos.ActiveRow.Cells("Referencia").Value.ToString)
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
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ValidarFechaDesde_Hasta(rangoFechaDesde, rangoFechaHasta)
            oeRequerimiento = New e_Requerimiento
            oeRequerimiento.UsuarioCreacion = gUsuarioSGI.Id
            oeRequerimiento.IdArea = oeArea.Id
            oeRequerimiento.FechaInicio = rangoFechaDesde.Value
            oeRequerimiento.FechaFinal = rangoFechaHasta.Value
            oeRequerimiento.OpcionFecha = IIf(Me.cboFormaBusqueda.SelectedIndex = 1, "FA", "FS")
            oeRequerimiento.Activo = Activo
            oeRequerimiento.TipoOperacion = "1"
            oeRequerimiento.PrefijoCentro = cboCentro.Value
            oeRequerimiento.MaterialServicio = cboRequerimiento.Value
            btnAtenderReq.Visible = IIf(cboRequerimiento.Text.Equals("SERVICIOS"), 0, 1)
            If cbArea.Checked Then oeRequerimiento.IdArea = cboAreaL.Value
            With griListaRequerimientos
                .DataSource = olRequerimiento.Listar(oeRequerimiento)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                agrRequerimientos.Text = "Requerimientos : " & .Rows.Count
                If .Rows.Count > 0 Then
                    .Focus()
                End If
            End With
            For Each fila As UltraGridRow In griListaRequerimientos.Rows
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
            With griListaRequerimientos
                If griListaRequerimientos.Rows.Count > 0 Then
                    Select Case .Rows(0).Cells("EstadoRequerimiento").Value
                        Case "EVALUADO"
                            btnEvaluarReq.Enabled = False
                            btnAtenderReq.Enabled = True
                            btnActualizaOT.Enabled = False
                        Case "ATENDIDO"
                            btnEvaluarReq.Enabled = False
                            btnAtenderReq.Enabled = False
                            btnActualizaOT.Enabled = False
                    End Select
                End If
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Cursor = Cursors.Default
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub ListarMateriales(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If Not String.IsNullOrEmpty(Trim(oeMaterial.Nombre)) Then
                oeMaterial = New e_Material
                llMaterial = New List(Of e_Material)
                oeMaterial.TipoOperacion = "5"
                oeMaterial.Activo = Activo
                llMaterial = olMaterial.Listar_(oeMaterial)
                '------Quitamos los registros de lista de materiales si es que estos ya estan en la lista requerimientos.------
                If lstRequerimientoMaterial.Count > 0 Then
                    llMaterial.RemoveAll(AddressOf VerificaListaMateriales)
                    griListaMateriales.DataBind()
                End If
                '--------------------------------------------------------------------------------------------------------------            
                With griListaMateriales
                    .DataSource = llMaterial
                    '.Rows.ExpandAll(True)
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                    agrMateriales.Text = "Materiales : " & .Rows.Count
                End With
                'llenaCombosGrillaMaterial()
            End If
            muestraCantidadElementosGrilla()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarServicios(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeServicio = New e_Servicio
            llServicio = New List(Of e_Servicio)
            oeServicio.TipoOperacion = "S"
            oeServicio.Activo = Activo
            oeServicio.IdCategoriaServicio = IIf(cboCategoriaServicios.Value = "CERO", "", cboCategoriaServicios.Value)
            llServicio = olServicio.Listar(oeServicio)
            '------Quitamos los registros de lista de servicios si es que estos ya estan en la lista requerimientos.------
            If llRequerimientoServicio.Count > 0 Then
                llServicio.RemoveAll(AddressOf VerificaListaServicios)
                griListaServicio.DataBind()
            End If
            '--------------------------------------------------------------------------------------------------------------            
            With griListaServicio
                .DataSource = llServicio
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                agrServicio.Text = "Servicios : " & .Rows.Count
                .DataBind()
                .Focus()
            End With
        Catch ex As Exception
            Throw ex
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
            Throw ex
        End Try
    End Function

    Private Function VerificaListaMateriales(ByVal oeMat As e_Material) As Boolean
        Try
            For Each filaReqMat As e_RequerimientoMaterial In lstRequerimientoMaterial
                If oeMat.Id = filaReqMat.IdMaterial Then Return True
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function VerificaListaServicios(ByVal oeSer As e_Servicio) As Boolean
        Try
            For Each filaReqSer As e_RequerimientoServicio In llRequerimientoServicio
                If oeSer.Id = filaReqSer.IdServicio Then Return True
            Next
        Catch ex As Exception
            Throw ex
        End Try 
    End Function

    Public Function TransponerRequerimientoMaterial() As List(Of e_RequerimientoMaterial)
        Try
            lstRequerimientoMaterial = New List(Of e_RequerimientoMaterial)
            Dim FechaAtencion As Date = ObtenerFechaServidor()
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
                oeRequerimientoMaterial.oeSancion.Id = matRow("IdSancion")
                If oeRequerimientoMaterial.CantidadAAtender > 0 Then
                    oeRequerimientoMaterial.FechaAtencion = FechaAtencion
                End If
                oeRequerimientoMaterial.IdEstadoRequerimientoMaterial = matRow("IdEstadoRequerimientoMaterial")
                oeRequerimientoMaterial.IndRegularizado = True
                oeRequerimientoMaterial.CantidadPorRegularizar = 0
                oeRequerimientoMaterial.UsuarioCreacion = gUsuarioSGI.Id
                oeRequerimientoMaterial.lstDetalleMaterialAsignacion = TransponerDetalleAsignacion(oeRequerimientoMaterial.Id)
                lstRequerimientoMaterial.Add(oeRequerimientoMaterial)
            Next
            Return lstRequerimientoMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function TransponerDetalleAsignacion(ByVal lsIdRequerimientoMaterial As String) As List(Of e_DetalleMaterialAsignacion)
        Dim lstDMA As New List(Of e_DetalleMaterialAsignacion)
        Try
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
                    oeDetMA.FechaVencimiento = matRow("FechaVencimiento")
                    lstDMA.Add(oeDetMA)
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return lstDMA
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
            oeOrdenIngreso.IdProveedor = gs_IdClienteProveedorSistema.Trim '@0001
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
                    .FechaCreacion = FechaServidor
                    .IdMaterial = item.IdMaterial
                    .IdSubAlmacen = ls_IdSubAlmacenAsignacion
                    .CantidadIngreso = item.CantidadAAtender
                    .ValorUnitario = Math.Round(item.Precio / (oeIGVGlobal.Porcentaje + 1), 4)
                    .Usuario = gUsuarioSGI.Id
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
            Dim FechaAtencion As Date = ObtenerFechaServidor()
            Dim oeComboPropio As e_Combo
            Dim oeEquipo As e_Equipo
            Dim olEquipo As l_Equipo
            If oeRequerimiento.MaterialServicio = "M" Then
                If oeRequerimiento.TipoOperacion = "D" Or oeRequerimiento.TipoOperacion = "R" Then
                    If Not Referencia.Equals("OA") Then
                        If Not VerificarModificaciones() Then
                            Me.btnActualizarDetalle.Focus()
                            Throw New Exception("El Requerimiento ha Sido Actualizado por Mantenimiento. Actualizar Detalles")
                        End If
                    End If
                End If
                If oeRequerimiento.TipoOperacion = "C" Then oeRequerimiento.IdTrabajadorAprobacion = gUsuarioSGI.IdTrabajador
                If Referencia.Equals("OA") Then
                    oeRequerimiento.lstRequerimientoMaterial = TransponerRequerimientoMaterial()
                    CargarIngresoAsignacion(FechaAtencion)
                Else
                    For Each obj As e_RequerimientoMaterial In lstRequerimientoMaterial
                        If obj.IndRegularizado = False Then
                            obj.IdEstadoRequerimientoMaterial = "1CH000000008"
                        Else
                            obj.IdEstadoRequerimientoMaterial = "1CH000000006"
                            If obj.CantidadAAtender > 0 Then
                                obj.FechaAtencion = FechaAtencion
                            End If
                        End If
                    Next
                    oeRequerimiento.lstRequerimientoMaterial = lstRequerimientoMaterial
                End If
                ''SOLO SE ATIENDED2''
                For Each obj In oeRequerimiento.lstRequerimientoMaterial.Where(Function(item) item.IdMaterial = "1CH000001990").ToList
                    obj.CantidadAAtender = 0
                    obj.Glosa = ""
                Next
                'Validacion para no atender desde Materiales de Baja
                For Each reqmat As e_RequerimientoMaterial In lstRequerimientoMaterial
                    If reqmat.IdAlmacen = "1SI000000003" Then
                        Throw New Exception("No se Pueden Atender Requerimientos del Almacen de Baja")
                    End If
                Next

                If oeRequerimiento.TipoOperacion = "D" Then 'Si se genera una atención de requerimientos.                
                    If Not ValidaPreRegistro() Then
                        Throw New Exception("Confirme PreRegistro de Neumatico. Hacer Doble Clik en Centro de Costo ('FALTA')")
                    End If
                    ' fin ---------
                    lstRequerimientoMaterial.ForEach(AddressOf obtenerCantidadTotalAtender)
                    If cantTotalAtender = 0 Then
                        Throw New Exception("Debe ingresar cantidad para atender los requerimientos de materiales.")
                    End If
                    cantTotalAtender = 0
                    '------- CONTROLAR AUTENTICACIÓN DEL TRABAJADOR PREVIO A LA ATENCIÓN ------------
                    'Dim formulario As frm_AutenticarTrabajador
                    'formulario = New frm_AutenticarTrabajador
                    'Dim idTrabEntr As String = ""
                    ''formulario.IdArea = oeRequerimiento.IdArea
                    'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                    '    Exit Function
                    'Else
                    '    For Each reqmat As e_RequerimientoMaterial In lstRequerimientoMaterial
                    '        oeControlEntregaMaterial = New e_ControlEntregaMaterial
                    '        If reqmat.CantidadAAtender > 0 Then
                    '            oeControlEntregaMaterial.FechaCreacion = FechaAtencion
                    '            oeControlEntregaMaterial.CantidadEntregada = reqmat.CantidadAAtender
                    '            oeControlEntregaMaterial.IdTrabajador = formulario.idTrabajador

                    '            oeControlEntregaMaterial.UsuarioCreacion = gUsuarioSGI.Id
                    '            oeControlEntregaMaterial.IdUnidadMedida = reqmat.IdUnidadMedida
                    '            reqmat.loControlEntregaMaterial.Add(oeControlEntregaMaterial)
                    '        End If
                    '    Next
                    '    idTrabEntr = formulario.idTrabajador
                    'End If
                    'formulario = Nothing
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                    '-------------------------------------------------------------------------------
                    '---------------------GENERANDO UNA ORDEN DE SALIDA-----------------------------
                    '--------------Obteniendo los datos segun consulta-------------------
                    oeMovimientoInventario = New e_MovimientoInventario
                    oeMovimientoInventario.Activo = True
                    If IndOtMack Then
                        oeMovimientoInventario.Nombre = "SALIDA PARA MANTENIMIENTO EXTERNO"
                    Else
                        oeMovimientoInventario.Nombre = IIf(String.IsNullOrEmpty(oeRequerimiento.IdReferencia.Trim), "SALIDA POR ATENCION DE REQUERIMIENTO", "SALIDA POR MANTENIMIENTO")
                        oeMovimientoInventario.Nombre = IIf(Referencia.Equals("OA"), "SALIDA POR ATENCION DE REQUERIMIENTO", oeMovimientoInventario.Nombre)
                    End If
                    oeMovimientoInventario = olMovimientoInventario.Obtener(oeMovimientoInventario)

                    oeOrdenSalida = New e_Orden
                    AgregarDetalleOrdenSalida()
                    oeOrdenSalida.lstOrdenMaterial = New List(Of e_OrdenMaterial)

                    If Not Referencia.Equals("OA") Then
                        oeOrdenIngreso = New e_Orden
                        oeOrdenIngreso.lstOrdenMaterial = New List(Of e_OrdenMaterial)
                    End If

                    If lstDetalleOrdenSalida.Count > 0 Then
                        oeOrdenSalida.lstOrdenMaterial.AddRange(lstDetalleOrdenSalida)
                        oeOrdenSalida.Activo = True
                        oeOrdenSalida.IdMoneda = "1CH01" ' Soles 
                        oeOrdenSalida.IdTipoOrden = "1CH000000002" 'ORDEN DE SALIDA
                        oeOrdenSalida.IdProveedor = gs_IdClienteProveedorSistema.Trim
                        oeOrdenSalida.IdMovimientoInventario = oeMovimientoInventario.Id
                        oeOrdenSalida.TipoReferencia = "REQUERIMIENTO"
                        oeOrdenSalida.Referencia = oeRequerimiento.Codigo
                        oeOrdenSalida.FechaOrden = FechaAtencion
                        oeOrdenSalida.TipoOperacion = "D"
                        oeOrdenSalida.IdSubAlmacenDestino = ""
                        oeOrdenSalida.IdSubAlmacenOrigen = ""
                        oeOrdenSalida.UsuarioCreacion = gUsuarioSGI.Id
                        oeOrdenSalida.IdUsuarioEjecucion = gUsuarioSGI.Id
                        oeOrdenSalida.lstInventario = New List(Of e_Inventario)
                        oeOrdenSalida.lstInventario = Inventario(oeOrdenSalida.lstOrdenMaterial)
                        For Each ordsalmat As e_OrdenMaterial In oeOrdenSalida.lstOrdenMaterial
                            'oeControlEntregaMaterial = New e_ControlEntregaMaterial
                            'If ordsalmat.CantidadMaterial > 0 Then
                            '    oeControlEntregaMaterial.FechaCreacion = FechaAtencion
                            '    oeControlEntregaMaterial.CantidadEntregada = ordsalmat.CantidadMaterial
                            '    oeControlEntregaMaterial.IdTrabajador = String.Empty
                            '    oeControlEntregaMaterial.UsuarioCreacion = gUsuarioSGI.Id
                            '    oeControlEntregaMaterial.IdUnidadMedida = ordsalmat.IdUnidadMedida
                            '    ordsalmat.loControlEntregaMaterial.Add(oeControlEntregaMaterial)
                            'End If
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
                            oeOrdenSalida.Glosa = DevolverCadena(oeOrdenSalida.lstOrdenMaterial)
                        End If
                        If leDetOrdenNeu.Count > 0 Then
                            oeOrdenSalida.bandNeu = "N"
                            oeOrdenSalida.lstDetOrdenNeu = leDetOrdenNeu
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
                    oeMovimientoInventario = New e_MovimientoInventario
                    oeMovimientoInventario.Activo = True
                    If IndOtMack Then
                        oeMovimientoInventario.Nombre = "SALIDA PARA MANTENIMIENTO EXTERNO"
                    Else
                        oeMovimientoInventario.Nombre = IIf(String.IsNullOrEmpty(oeRequerimiento.IdReferencia.Trim), "SALIDA POR ATENCION DE REQUERIMIENTO", "SALIDA POR MANTENIMIENTO")
                        oeMovimientoInventario.Nombre = IIf(Referencia.Equals("OA"), "SALIDA POR ATENCION DE REQUERIMIENTO", oeMovimientoInventario.Nombre)
                    End If
                    oeMovimientoInventario = olMovimientoInventario.Obtener(oeMovimientoInventario)
                    AgregarDetalleOrdenSalidaRegularizacion()
                    oeOrdenSalida = New e_Orden
                    oeOrdenSalida.lstOrdenMaterial = New List(Of e_OrdenMaterial)
                    If lstDetalleOrdenSalida.Count > 0 Then
                        oeOrdenSalida.lstOrdenMaterial.AddRange(lstDetalleOrdenSalida)
                        oeOrdenSalida.Activo = True
                        oeOrdenSalida.IdMoneda = "1CH01" ' Soles 
                        oeOrdenSalida.IdTipoOrden = "1CH000000002" 'oeTipoOrden.Id ORDEN DE SALIDA
                        oeOrdenSalida.IdProveedor = gs_IdClienteProveedorSistema.Trim
                        oeOrdenSalida.IdMovimientoInventario = oeMovimientoInventario.Id
                        oeOrdenSalida.TipoReferencia = "REQUERIMIENTO"
                        oeOrdenSalida.Referencia = oeRequerimiento.Codigo
                        oeOrdenSalida.FechaOrden = FechaAtencion
                        oeOrdenSalida.TipoOperacion = "D"
                        oeOrdenSalida.IdSubAlmacenDestino = ""
                        oeOrdenSalida.IdSubAlmacenOrigen = ""
                        oeOrdenSalida.UsuarioCreacion = gUsuarioSGI.Id
                        oeOrdenSalida.IdUsuarioEjecucion = gUsuarioSGI.Id
                        oeOrdenSalida.lstInventario = New List(Of e_Inventario)
                        oeOrdenSalida.lstInventario = Inventario(oeOrdenSalida.lstOrdenMaterial)
                        For Each ordsalmat As e_OrdenMaterial In oeOrdenSalida.lstOrdenMaterial
                            oeControlEntregaMaterial = New e_ControlEntregaMaterial
                            Dim oeCtrlEntrMat As New e_ControlEntregaMaterial
                            If ordsalmat.CantidadMaterial > 0 Then
                                oeControlEntregaMaterial.FechaCreacion = FechaAtencion
                                oeControlEntregaMaterial.CantidadEntregada = ordsalmat.CantidadMaterial
                                oeCtrlEntrMat.IdRequerimientoMaterial = ordsalmat.IdRequerimientoMaterial
                                oeCtrlEntrMat.TipoOperacion = "3"
                                oeCtrlEntrMat = olControlEntregaMaterial.Obtener(oeCtrlEntrMat)
                                oeControlEntregaMaterial.UsuarioCreacion = gUsuarioSGI.Id
                                oeControlEntregaMaterial.IdUnidadMedida = ordsalmat.IdUnidadMedida
                                If oeCtrlEntrMat.Id <> "" Then
                                    oeControlEntregaMaterial.IdTrabajador = oeCtrlEntrMat.Id
                                    ordsalmat.loControlEntregaMaterial.Add(oeControlEntregaMaterial)
                                End If
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
                            oeOrdenSalida.Glosa = DevolverCadena(oeOrdenSalida.lstOrdenMaterial)
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
                ElseIf oeRequerimiento.TipoOperacion = "T" Then
                    If oeRequerimiento.lstRequerimientoMaterial.Where(Function(i) i.CantidadPorAtender > 0).Count > 0 Then
                        Throw New Exception("Para Terminar el Requerimiento Todos los Materiales Deben ser Atendidos")
                    End If
                    If oeRequerimiento.lstRequerimientoMaterial.Where(Function(i) i.CantidadPorRegularizar > 0).Count > 0 Then
                        Throw New Exception("Para Terminar el Requerimiento Todos los Materiales Deben ser Regularizados")
                    End If
                ElseIf oeRequerimiento.TipoOperacion = "E" Then
                    If oeRequerimiento.lstRequerimientoMaterial.Count > 0 Then
                        Throw New Exception("No Puede Eliminar Requerimientos con Detalles")
                    End If
                End If
            Else
                If cmEquipo.SelectedIndex <> -1 Then
                    oeRequerimiento.IdEquipo = cmEquipo.Value
                Else
                    Throw New Exception("Seleccione Equipo para Requerimiento de Servicios")
                End If
                oeRequerimiento.lstRequerimientoServicio = llRequerimientoServicio
            End If
            oeRequerimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olRequerimiento.Guardar(oeRequerimiento) Then
                If oeRequerimiento.TipoOperacion = "D" Then
                    Dim frm As New frm_ImprimirMaterialEntregado
                    Dim id As String = ""
                    Dim tipo As String = ""
                    If oeOrdenSalida.lstOrdenMaterial.Count > 0 Then
                        tipo = "E"
                        For Each ordensalidamat As e_OrdenMaterial In oeOrdenSalida.lstOrdenMaterial
                            id = id & "'" & ordensalidamat.Id & "',"
                        Next
                        If id <> "" Then
                            id = id.Substring(0, id.Length - 1)
                        End If
                    Else
                        For Each reqmat As e_RequerimientoMaterial In lstRequerimientoMaterial.Where(Function(item) item.CantidadAAtender > 0)
                            For Each ctrlentremat As e_ControlEntregaMaterial In reqmat.loControlEntregaMaterial
                                id = id & "'" & ctrlentremat.IdRequerimientoMaterial & "',"
                            Next
                        Next
                        If id <> "" Then
                            id = id.Substring(0, id.Length - 1)
                        End If
                    End If
                    frm.CargarDatos(id, tipo)
                    frm.ShowDialog()
                End If
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EditarRequerimiento() As Boolean
        Dim id As String
        Try
            With griListaRequerimientos
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

                        If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "REGULARIZAR REQUERIMIENTO") Then
                            griListaMaterialRequeridos.DisplayLayout.Bands(0).Columns("IndRegularizado").Hidden = False
                        Else
                            griListaMaterialRequeridos.DisplayLayout.Bands(0).Columns("IndRegularizado").Hidden = True
                        End If

                        If Referencia.Equals("OA") Then
                            ListarRM_Detalle(id)
                            ls_IdSubAlmacenAsignacion = BuscarSubAlmacen_Ingreso(oeRequerimiento.IdReferencia)
                            Me.btnActualizarDetalle.Enabled = False
                        Else
                            ListarDetalleRequerimiento()
                            If oeRequerimiento.EstadoRequerimiento <> "ATENDIDO" Then Me.btnActualizarDetalle.Enabled = True
                            If oeRequerimiento.MaterialServicio = "S" Then Me.btnActualizarDetalle.Enabled = False
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
            Throw ex
        End Try
    End Function

    Public Sub ListarDetalleRequerimiento()
        Try
            If cboRequerimiento.Text = "MATERIALES" Then
                ListarRequerimientoMaterial(True)
                If griListaMaterialRequeridos.Rows.Count > 0 Then
                    ControlaBarraOperacionesDetalle(1, 1, 1)
                Else
                    ControlaBarraOperacionesDetalle(1, 1, 0)
                End If
            Else
                cmEquipo.Value = oeRequerimiento.IdEquipo
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
            oeRequerimientoMaterial.Tipooperacion = tipoOperacionDetReq
            oeRequerimientoMaterial.Activo = Activo
            oeRequerimientoMaterial.IdRequerimiento = oeRequerimiento.Id
            lstRequerimientoMaterial = olRequerimientoMaterial.Listar(oeRequerimientoMaterial)
            griListaMaterialRequeridos.DataSource = lstRequerimientoMaterial
            agrMaterialesRequeridos.Text = "Materiales requeridos : " & lstRequerimientoMaterial.Count
            llenaCombosGrillaMaterialRequerido(griListaMaterialRequeridos)
            asignarColoresSegunEstado(griListaMaterialRequeridos)
            If tipoOperacionDetReq = "4" Then ActualizaPreRegistro()
        Catch ex As Exception
            Throw ex
        End Try
        griListaMaterialRequeridos.Focus()
    End Sub

    Public Function ListarRequerimientoActualizado() As List(Of e_RequerimientoMaterial)
        Try
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
    End Function

    Public Sub ListarRequerimientoServicio(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeRequerimientoServicio = New e_RequerimientoServicio
            llRequerimientoServicio = New List(Of e_RequerimientoServicio)
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
        griListaMaterialRequeridos.Focus()
    End Sub

    Public Sub asignarColoresSegunEstado(ByVal grilla As UltraGrid)
        Try
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
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub asignarColoresSegunEstadoServicio()
        Try
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
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsignarMaterialRequerimiento()
        Try
            '-----------------------Obteniendo estado para los detalles-------------------
            'oeEstadoRequerimiento = New e_EstadoRequerimiento
            'oeEstadoRequerimiento.Nombre = "GENERADO"
            'oeEstadoRequerimiento = olEstadoRequerimiento.Obtener(oeEstadoRequerimiento)
            '-----------------------------------------------------------------------------
            oeCentroCosto = New e_CentroCosto
            oeCentroCosto.IdArea = oeArea.Id
            oeCentroCosto = olCentroCosto.Obtener(oeCentroCosto)
            For Each oeMat As e_Material In llMaterial
                If oeMat.Seleccion Then
                    oeRequerimientoMaterial = New e_RequerimientoMaterial
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
            griListaMaterialRequeridos.DataBind()
            llenaCombosGrillaMaterialRequerido(griListaMaterialRequeridos)
            llMaterial.RemoveAll(AddressOf eliminaMateriales)
            griListaMateriales.DataBind()
            muestraCantidadElementosGrilla()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsignarServicioRequerimiento()
        Try
            oeCentroCosto = New e_CentroCosto
            oeCentroCosto.Activo = True
            oeCentroCosto.IdArea = oeArea.Id
            oeCentroCosto = olCentroCosto.Obtener(oeCentroCosto)
            'For Each oeSer As e_Servicio In llServicio
            If llRequerimientoServicio.Count > 0 Then
                For Each reqser As e_RequerimientoServicio In llRequerimientoServicio
                    If reqser.IdServicio = griListaServicio.ActiveRow.Cells("Id").Value Then Throw New Exception("Servicio ya Asignado")
                Next
            End If
            With griListaServicio.ActiveRow
                oeRequerimientoServicio = New e_RequerimientoServicio()
                oeRequerimientoServicio.Seleccion = False 'llMaterial.Item(i).Seleccion
                oeRequerimientoServicio.Activo = True
                oeRequerimientoServicio.IdServicio = .Cells("Id").Value
                oeRequerimientoServicio.Servicio = .Cells("Nombre").Value
                oeRequerimientoServicio.CodigoServicio = .Cells("Codigo").Value
                oeRequerimientoServicio.UsuarioCreacion = gUsuarioSGI.Id
                oeRequerimientoServicio.Cantidad = 1
                oeRequerimientoServicio.Precio = .Cells("Precio").Value
                oeRequerimientoServicio.IdCentroCosto = oeCentroCosto.Id ' "1CH000000025" 'Este valor se obtendrá cuando el usuario se autentique.Sale de la tabla trabajador
                oeRequerimientoServicio.IdEstadoRequerimientoServicio = oeEstadoRequerimiento.Id
                llRequerimientoServicio.Add(oeRequerimientoServicio)
            End With
            ' Next
            griListaServiciosRequeridos.DataBind()
            llenaCombosGrillaServicioRequerido()
            'llServicio.RemoveAll(AddressOf eliminaServicios)
            griListaServicio.DataBind()
            muestraCantidadElementosGrillaServicio()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarDetalleOrdenSalida()
        Try
            lstDetalleOrdenSalida = New List(Of e_OrdenMaterial)
            For Each obj As e_RequerimientoMaterial In lstRequerimientoMaterial
                If obj.CantidadAAtender > 0 And obj.IndRegularizado Then
                    oeDetalleOrdenSalida = New e_OrdenMaterial
                    oeDetalleOrdenSalida.Activo = True
                    oeDetalleOrdenSalida.IdMaterial = obj.IdMaterial
                    oeDetalleOrdenSalida.Material = obj.Material
                    oeDetalleOrdenSalida.CantidadMaterial = obj.CantidadAAtender
                    oeDetalleOrdenSalida.PrecioUnitario = obj.Precio
                    'If obj.IdAlmacen <> "1CH000000022" Then
                    '    If obj.Precio = 0 Then Throw New Exception("Material: " & obj.Material & " con Precio 0. Verificar")
                    'End If
                    oeDetalleOrdenSalida.IdAlmacen = obj.IdAlmacen
                    oeDetalleOrdenSalida.Almacen = obj.Almacen
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

    'Sub TransponerRegistroInv()
    '    Try
    '        For Each item As e_OrdenMaterial In oeOrdenSalida.lstOrdenMaterial.Where(Function(oe) oe.CantidadMaterial > 0).ToList
    '            oeRegistroInventario = New e_RegistroInventario
    '            oeRegistroInventario.Id = ""
    '            oeRegistroInventario.IdMovimientoInventario = oeOrdenSalida.IdMovimientoInventario
    '            oeRegistroInventario.IdMaterial = item.IdMaterial
    '            oeRegistroInventario.IdUnidadMedida = item.IdUnidadMedida
    '            oeRegistroInventario.Cantidad = item.CantidadMaterial
    '            oeRegistroInventario.CantidadReal = ConvertirUnidadBase(item.CantidadMaterial, item.IdUnidadMedida)
    '            oeRegistroInventario.ValorUnitarioReal = (item.ValorVenta / oeRegistroInventario.CantidadReal)
    '            oeRegistroInventario.ValorUnitario = item.PrecioUnitario
    '            oeRegistroInventario.ValorTotal = oeRegistroInventario.CantidadReal * oeRegistroInventario.ValorUnitarioReal
    '            oeRegistroInventario.Activo = item.Activo
    '            oeRegistroInventario.UsuarioCreacion = gUsuarioSGI.Id
    '            oeRegistroInventario.Fecha = Date.Now
    '            oeRegistroInventario.IdSubAlmacen = item.IdSubAlmacen
    '            'oeRegistroInventario.IdAlmacen = item.IdAlmacen 'envia almacen
    '            oeRegistroInventario.TipoOperacion = "T"
    '            oeInventario = New e_Inventario
    '            oeInventario.TipoOperacion = "I"
    '            oeInventario.IdMaterial = oeRegistroInventario.IdMaterial
    '            oeInventario.IdSubAlmacen = oeRegistroInventario.IdSubAlmacen
    '            oeInventario.ValorUnitario = oeRegistroInventario.ValorUnitario
    '            oeInventario.FechaCreacion = Date.Now
    '            oeInventario.CantidadIngreso = 0
    '            oeInventario.CantidadSalida = oeRegistroInventario.Cantidad
    '            oeInventario.ValorTotal = oeRegistroInventario.ValorTotal
    '            oeInventario.Usuario = gUsuarioSGI.Id
    '            oeRegistroInventario.oeInventario = oeInventario
    '            listaRegistroInventario.Add(oeRegistroInventario)
    '        Next
    '        oeOrdenSalida.lstRegistroInventario = listaRegistroInventario
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub AgregarDetalleOrdenSalidaRegularizacion()
        Try
            lstDetalleOrdenSalida = New List(Of e_OrdenMaterial)
            For Each obj As e_RequerimientoMaterial In lstRequerimientoMaterial
                If obj.CantidadARegularizar > 0 Then
                    oeDetalleOrdenSalida = New e_OrdenMaterial
                    oeDetalleOrdenSalida.Activo = True
                    oeDetalleOrdenSalida.IdMaterial = obj.IdMaterial
                    oeDetalleOrdenSalida.Material = obj.Material
                    oeDetalleOrdenSalida.CantidadMaterial = obj.CantidadARegularizar
                    oeDetalleOrdenSalida.PrecioUnitario = obj.Precio 'Falta obtener de la BD.
                    If obj.Precio = 0 Then Throw New Exception("Material: " & obj.Material & " con Precio 0. Verificar")
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
            For i As Integer = 0 To grilla.Rows.Count - 1
                oeUnidadMedida = New e_UnidadMedida()
                oeUnidadMedida.Activo = True
                oeUnidadMedida.Factor = 0
                oeUnidadMedida.IdTipoUnidadMedida = grilla.Rows(i).Cells("IdTipoUnidadMedida").Value.ToString
                CrearComboGridPorCelda("IdUnidadMedida", "Nombre", i, grilla, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)

                oeMaterialAlmacen = New e_MaterialAlmacen()
                oeMaterialAlmacen.Activo = True

                If oeRequerimiento.TipoReferencia = "ORDEN TRABAJO" Then
                    If oeRequerimiento.IdReferencia.Length > 0 Then
                        oeMaterialAlmacen.IdCentro = oeRequerimiento.IdReferencia.Substring(0, 3)
                    Else
                        'oeMaterialAlmacen.IdCentro = Prefijo.PrefijoID '@0001
                        oeMaterialAlmacen.IdCentro = gs_PrefijoIdSucursal '@0001
                    End If
                Else
                    oeMaterialAlmacen.IdCentro = cboCentro.Value
                End If

                'If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "VER SEDES LOGISTICA") Then
                '    oeMaterialAlmacen.IdCentro = cboCentro.Value
                'End If

                oeMaterialAlmacen.TipoOperacion = "6"
                oeMaterialAlmacen.IdMaterial = grilla.Rows(i).Cells("IdMaterial").Value.ToString
                CrearComboGridPorCelda("IdAlmacen", "Nombre", i, grilla, olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen), True)

                oeSubalmacen = New e_SubAlmacen
                oeSubalmacen.TipoOperacion = "S"
                oeSubalmacen.Activo = True
                oeSubalmacen.IdAlmacen = grilla.Rows(i).Cells("IdAlmacen").Value.ToString
                CrearComboGridPorCelda("IdSubAlmacen", "Nombre", i, grilla, olSubalmacen.ComboGrilla(oeSubalmacen), True)
            Next

            If grilla.Name = "grilla_OA_Material" Then
                With grilla
                    For i As Integer = 0 To .Rows.Count - 1
                        For Each aChildBand1 As UltraGridChildBand In .Rows(i).ChildBands
                            For Each fila As UltraGridRow In aChildBand1.Rows
                                For y As Integer = 0 To aChildBand1.Rows.Count - 1
                                    MarcasValueList(grilla)
                                    aChildBand1.Rows(y).Cells("IdMarca").ValueList = .DisplayLayout.ValueLists("Marcas")
                                    'aChildBand1.Rows(y).Cells("IdMarca").Value = "1CH000000000"

                                    ModelosValueList(aChildBand1.Rows(y).Cells("IdMarca").Value.ToString(), grilla)
                                    aChildBand1.Rows(y).Cells("IdModelo").ValueList = .DisplayLayout.ValueLists("Modelos")
                                    'aChildBand1.Rows(y).Cells("IdModelo").Value = "1CH000000000"

                                    EstadosValueList(grilla)
                                    aChildBand1.Rows(y).Cells("IdEstado").ValueList = .DisplayLayout.ValueLists("Estados")
                                    'aChildBand1.Rows(y).Cells("IdEstado").Value = "1CH00022"
                                Next
                            Next
                        Next
                    Next
                    For x As Integer = 0 To .Rows.Count - 1
                        .Rows(x).ExpandAll()
                    Next
                End With
            End If
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
            llMaterial = New List(Of e_Material)
            llServicio = New List(Of e_Servicio)
            lstRequerimientoMaterial = New List(Of e_RequerimientoMaterial)
            llRequerimientoServicio = New List(Of e_RequerimientoServicio)
            griListaServicio.DataSource = llServicio
            griListaMaterialRequeridos.DataSource = lstRequerimientoMaterial
            griListaServiciosRequeridos.DataSource = llRequerimientoServicio
            With griListaMateriales
                .DataSource = llMaterial
                .DisplayLayout.Bands(0).SortedColumns.Clear()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub QuitarMaterialRequerimiento()
        Try
            If griListaMaterialRequeridos.ActiveRow.Cells("CantidadPorAtender").Value <> 0 Then
                lstRequerimientoMaterial.RemoveAll(AddressOf verificarSeleccionado)
                griListaMateriales.DataBind()
                griListaMateriales.Rows.ExpandAll(True)
                'llenaCombosGrillaMaterial()
                griListaMaterialRequeridos.DataBind()
                muestraCantidadElementosGrilla()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub muestraCantidadElementosGrilla()
        agrMateriales.Text = "Materiales : " & llMaterial.Count  'griListaMateriales.Rows.Count
        agrMaterialesRequeridos.Text = "Materiales requeridos : " & griListaMaterialRequeridos.Rows.Count
    End Sub

    Public Sub muestraCantidadElementosGrillaServicio()
        agrServicio.Text = "Servicios : " & griListaServicio.Rows.Count
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
            Throw ex
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
            Throw ex
        End Try
    End Function

    Sub QuitarServicioRequerimiento()
        Try
            llRequerimientoServicio.RemoveAll(AddressOf verificarSeleccionadoServicio)
            griListaServicio.DataBind()
            'llenaCombosGrillaMaterial()
            griListaServiciosRequeridos.DataBind()
            muestraCantidadElementosGrillaServicio()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub controlaColumnasMateriales(activoIA As Boolean, activoSR As Boolean, activoCA As Boolean, activoCAA As Boolean, visibleLisMat As Boolean, _
                                          cellClickAction As Integer, cantPorRegularizar As Boolean, cantARegul As Boolean, Optional IndRegularizar As Boolean = False)
        Try
            With griListaMaterialRequeridos
                .DisplayLayout.Bands(0).Columns("IndicadorAprobacion").Hidden = activoIA
                .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
                .DisplayLayout.Bands(0).Columns("CantidadPorAtender").Hidden = activoCA
                .DisplayLayout.Bands(0).Columns("CantidadAAtender").Hidden = activoCAA
                .DisplayLayout.Bands(0).Columns("Cantidad").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("CantidadAAtender").CellClickAction = UltraWinGrid.CellClickAction.EditAndSelectText
                .DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("CantidadPorRegularizar").Hidden = cantPorRegularizar
                .DisplayLayout.Bands(0).Columns("CantidadARegularizar").Hidden = cantARegul
                .DisplayLayout.Bands(0).Columns("IndRegularizado").Hidden = IndRegularizar
            End With
            gbeMateriales.Visible = visibleLisMat
            With grilla_OA_Material
                .DisplayLayout.Bands(0).Columns("CantidadPorAtender").Hidden = activoCA
                .DisplayLayout.Bands(0).Columns("CantidadAAtender").Hidden = activoCAA
                .DisplayLayout.Bands(0).Columns("CantidadAAtender").CellClickAction = cellClickAction
                .DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Cantidad").CellActivation = Activation.NoEdit
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
            gbeServicios.Visible = visibleLisSer
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub obtenerCantidadTotalAtender(ByVal oeReqMat As e_RequerimientoMaterial)
        Try
            cantTotalAtender += oeReqMat.CantidadAAtender
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub obtenerCantidadTotalRegulariar(ByVal oeReqMat As e_RequerimientoMaterial)
        Try
            cantTotalRegularizar += oeReqMat.CantidadARegularizar
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EvaluarRequerimiento()
        Try
            If VerificarPermisoEvaluacion() Then
                tipoOperacionDetReq = "2"
                controlaColumnasMateriales(False, True, True, True, False, 0, True, True, True)
                controlaColumnasServicio(False, True, False)
                ValidaFicha()
                Inicializar()
                lbl_etiqueta.Text = "Evaluando RQ"
                lbl_etiqueta.Visible = 1
                CodigoBarras(False)
                Operacion = "Editar"
                If EditarRequerimiento() Then
                    oeRequerimiento.TipoOperacion = "C"
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                End If
            Else
                Throw New Exception("No Tiene Permiso Para Evaluar Requerimientos")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AtenderRequerimientos()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ATENCION DE REQUERIMIENTOS") Then
                tipoOperacionDetReq = "4"
                controlaColumnasMateriales(True, True, False, False, False, 4, True, True)
                griListaMaterialRequeridos.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                grilla_OA_Material.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                griListaMaterialRequeridos.DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.NoEdit
                grilla_OA_Material.DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.NoEdit
                ValidaFicha()
                Inicializar()
                lbl_etiqueta.Text = "Atendiendo RQ"
                CodigoBarras(True)
                lbl_etiqueta.Visible = 1
                Operacion = "Editar"
                leDetOrdenNeu = New List(Of e_DetalleOrdenNeumatico)
                If VerificarRegistroEditado() Then
                    If EditarRequerimiento() Then
                        oeRequerimiento.TipoOperacion = "D"
                        oeRequerimiento.IdUsuarioAtencion = gUsuarioSGI.Id
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        GuardarRegistroEditado()
                    End If
                End If
                txtCodigoBarras.Focus()
            Else
                Throw New Exception("No Tiene Permiso Para Atender Requerimientos")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GuardarRegistroEditado()
        Try
            If RegistroEditado = 1 Then
                oeRegistroEditado = New e_RegistrosEditados
                oeRegistroEditado.IdRegistro = griListaRequerimientos.ActiveRow.Cells("Id").Value()
                oeRegistroEditado.Referencia = "Requerimiento"
                oeRegistroEditado.UsuarioEdita = gUsuarioSGI.Id
                oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                IdRegistroEditado = olRegistroEditado.Guardar(oeRegistroEditado)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function VerificarRegistroEditado() As Boolean
        Try
            Dim oeReq As New e_Requerimiento
            oeReq.Id = griListaRequerimientos.ActiveRow.Cells("Id").Value
            oeReq.TipoOperacion = "6"
            oeReq = olRequerimiento.Obtener(oeReq)

            If oeReq.UsuarioCreacion <> "" Then
                If oeReq.IdArea <> gUsuarioSGI.oePersona.NombreCompleto Then
                    mensajeEmergente.Confirmacion("La información del Requerimiento no es accesible, esta siendo editado por" & Environment.NewLine & Environment.NewLine & _
                                        "el Usuario: " & oeReq.IdArea & Environment.NewLine & _
                                        "desde: " & oeReq.FechaCreacion & Environment.NewLine & _
                                        "en la Sucursal: " & oeReq.IdUsuarioAtencion, True)
                    Return False
                Else
                    oeRegistroEditado = New e_RegistrosEditados
                    With oeRegistroEditado
                        .TipoOperacion = "A"
                        .Id = oeReq.UsuarioCreacion
                        .FechaModificado = DateAdd(DateInterval.Minute, 5, oeReq.FechaCreacion)
                    End With
                    oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olRegistroEditado.Guardar(oeRegistroEditado)
                    RegistroEditado = 1
                End If
            Else
                RegistroEditado = 1
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ActualizaRegistroEditado() As Boolean
        Try
            If RegistroEditado = 1 Then
                oeRegistroEditado = New e_RegistrosEditados
                oeRegistroEditado.Id = IdRegistroEditado
                oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                olRegistroEditado.Guardar(oeRegistroEditado)
                RegistroEditado = 0
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function VerificarPermisoEvaluacion() As Boolean
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
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ATENCION DE REQUERIMIENTOS") Then
                tipoOperacionDetReq = "R"
                controlaColumnasMateriales(True, True, True, True, False, 4, False, False, True)
                griListaMaterialRequeridos.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                grilla_OA_Material.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                griListaMaterialRequeridos.DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.NoEdit
                grilla_OA_Material.DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellActivation = Activation.NoEdit
                ValidaFicha()
                Inicializar()
                lbl_etiqueta.Text = "Regularizando RQ"
                lbl_etiqueta.Visible = 1
                CodigoBarras(True)
                Operacion = "Editar"
                If VerificarRegistroEditado() Then
                    If EditarRequerimiento() Then
                        oeRequerimiento.TipoOperacion = "R"
                        oeRequerimiento.IdUsuarioAtencion = gUsuarioSGI.Id
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        GuardarRegistroEditado()
                    End If
                End If
            Else
                Throw New Exception("No Tiene Permiso Para Regularizar Requerimientos")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ControlarEstadoRequerimiento()
        Try
            btnEvaluarReq.Enabled = 0 : btnAtenderReq.Enabled = 0 : btnRegReq.Enabled = 0 : btnActualizaOT.Enabled = 0 : btnTerminarRQ.Enabled = 0 : btnEliminar.Enabled = 0
            If griListaRequerimientos.ActiveRow.Index > -1 Then
                If cboRequerimiento.Text = "MATERIALES" Then
                    Select Case griListaRequerimientos.ActiveRow.Cells("EstadoRequerimiento").Value
                        Case "GENERADO"
                            btnEvaluarReq.Enabled = 1
                        Case "EVALUADO"
                            btnAtenderReq.Enabled = 1
                            If griListaRequerimientos.ActiveRow.Cells("TipoReferencia").Value <> "ORDEN ASIGNACION" Then
                                btnRegReq.Enabled = 1
                            End If
                            btnEliminar.Enabled = 1
                        Case "PARCIALMENTE ATENDIDO"
                            btnAtenderReq.Enabled = 1
                            If griListaRequerimientos.ActiveRow.Cells("TipoReferencia").Value <> "ORDEN ASIGNACION" Then
                                btnRegReq.Enabled = 1
                            End If
                            btnTerminarRQ.Enabled = 1
                    End Select
                Else
                    Select Case griListaRequerimientos.ActiveRow.Cells("EstadoRequerimiento").Value
                        Case "GENERADO"
                            btnEvaluarReq.Enabled = 1
                        Case "EVALUADO"
                            If griListaRequerimientos.ActiveRow.Cells("TipoReferencia").Value.ToString.Trim = "" Then
                                btnActualizaOT.Enabled = 1
                            End If
                    End Select
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboCategoriaServicios()
        Try
            oeCategoriaServicio = New e_CategoriaServicio
            lstCategoriasServicio = New List(Of e_CategoriaServicio)
            oeCategoriaServicio.Id = "CERO" : oeCategoriaServicio.Nombre = "TODOS"
            lstCategoriasServicio.Add(oeCategoriaServicio)
            oeCategoriaServicio = New e_CategoriaServicio
            oeCategoriaServicio.Activo = True
            lstCategoriasServicio.AddRange(olCategoriaServicio.Listar(oeCategoriaServicio))
            LlenarComboMaestro(cboCategoriaServicios, lstCategoriasServicio, 0)
            LlenaComboEquipo()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboEquipo()
        Try
            Dim oeEquipo As New e_Equipo
            Dim olEquipo As New l_Equipo
            oeEquipo.Activo = True
            oeEquipo.TipoOperacion = "R"
            LlenarComboMaestro(cmEquipo, olEquipo.Listar(oeEquipo), -1)
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
            Dim parentCol As DataColumn = ds_RM_DE.Tables(0).Columns("IdDetalleRequerimiento")
            Dim childCol As DataColumn = ds_RM_DE.Tables(1).Columns("IdRequerimientoMaterial")
            relation = New DataRelation("FK_Relacion", parentCol, childCol, True)
            ds_RM_DE.Relations.Add(relation)

            ds_RM_DE.AcceptChanges()
            grilla_OA_Material.DataSource = ds_RM_DE
            llenaCombosGrillaMaterialRequerido(grilla_OA_Material)
            asignarColoresSegunEstado(grilla_OA_Material)
            Agrupacion8.Text = "Materiales requeridos : " & ds_RM_DE.Tables(0).Rows.Count
            With grilla_OA_Material.DisplayLayout
                'ocultar
                .Bands(0).Columns("Id").Hidden = True
                .Bands(0).Columns("IndRegularizado").Hidden = True
                .Bands(0).Columns("CantidadPorRegularizar").Hidden = True
                .Bands(0).Columns("CentroCosto").Hidden = True
                .Bands(0).Columns("CodigoMaterial").Width = 100
                '.Bands(0).Columns("Cantidad").MaskInput = "{double:9.4}"
                '.Bands(0).Columns("CantidadAAtender").MaskInput = "{double:9.2}"
                '.Bands(0).Columns("CantidadPorAtender").MaskInput = "{double:9.2}"

                .Bands(1).Columns("Id").Hidden = True
                .Bands(1).Columns("IdRequerimientoMaterial").Hidden = True


                .Bands(0).Columns("CodigoMaterial").Width = 80
                .Bands(0).Columns("Cantidad").Width = 80
                .Bands(0).Columns("UnidadMedida").Width = 80

                .Bands(1).Columns("IdMarca").Width = 150
                .Bands(1).Columns("IdModelo").Width = 150

                .Bands(1).Columns("Serie").Header.Appearance.TextHAlign = HAlign.Center
                .Bands(1).Columns("Serie").CellClickAction = CellClickAction.EditAndSelectText
                .Bands(1).Columns("Serie").CharacterCasing = CharacterCasing.Upper
                .Bands(1).Columns("Especificaciones").Header.Appearance.TextHAlign = HAlign.Center
                .Bands(1).Columns("Especificaciones").CellClickAction = CellClickAction.EditAndSelectText
                .Bands(1).Columns("Especificaciones").CharacterCasing = CharacterCasing.Upper
                .Bands(1).Columns("IdMarca").Header.Appearance.TextHAlign = HAlign.Center
                .Bands(1).Columns("IdMarca").Header.Caption = "Marca"
                .Bands(1).Columns("IdModelo").Header.Appearance.TextHAlign = HAlign.Center
                .Bands(1).Columns("IdModelo").Header.Caption = "Modelo"
                .Bands(1).Columns("IdEstado").Header.Appearance.TextHAlign = HAlign.Center
                .Bands(1).Columns("IdEstado").Header.Caption = "Estado"
                .Override.FilterUIType = FilterUIType.HeaderIcons
                .Override.AllowRowFiltering = DefaultableBoolean.False
                .Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .Override.CellPadding = 1
            End With
            For x As Integer = 0 To grilla_OA_Material.Rows.Count - 1
                Me.grilla_OA_Material.Rows(x).CollapseAll()
            Next
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
            Dim dt As DataTable = olModelo.ComboGrilla(loModelo.Where(Function(item) item.IdMarca = lsIdMarca).ToList)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    If i = 0 Then IdModelo = dt.Rows(i).Item("Id").ToString
                    objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
                Next
            Else
                Throw New Exception("Información no registrada")
            End If         
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AgregarReqMatDetalle(ByVal lsIdRM As String, ByVal cant As Integer, IndDivisible As Boolean)
        Try
            ds_RM_DE.Tables(1).AcceptChanges()

            For Each matRow As DataRow In ds_RM_DE.Tables(1).Rows
                If matRow("IdRequerimientoMaterial") = lsIdRM And matRow("Id") = "" Then
                    matRow.Delete()
                End If
            Next
            If Not IndDivisible Then
                Dim row As DataRow
                row = ds_RM_DE.Tables(1).NewRow
                row("Id") = ""
                row("IdRequerimientoMaterial") = lsIdRM
                row("IdMarca") = ""
                row("IdModelo") = ""
                row("IdEstado") = ""
                row("Serie") = "NINGUNA"
                row("Especificaciones") = "NINGUNA"
                row("FechaVencimiento") = "01/01/1901"
                ds_RM_DE.Tables(1).Rows.Add(row)
                ds_RM_DE.Tables(1).AcceptChanges()
                ds_RM_DE.AcceptChanges()
            Else
                For i As Integer = 0 To cant - 1
                    Dim row As DataRow
                    row = ds_RM_DE.Tables(1).NewRow
                    row("Id") = ""
                    row("IdRequerimientoMaterial") = lsIdRM
                    row("IdMarca") = ""
                    row("IdModelo") = ""
                    row("IdEstado") = ""
                    row("Serie") = "NINGUNA"
                    row("Especificaciones") = "NINGUNA"
                    row("FechaVencimiento") = "01/01/1901"
                    ds_RM_DE.Tables(1).Rows.Add(row)
                    ds_RM_DE.Tables(1).AcceptChanges()
                    ds_RM_DE.AcceptChanges()
                Next
            End If
            With grilla_OA_Material
                For i As Integer = 0 To .Rows.Count - 1
                    For Each aChildBand1 As UltraGridChildBand In .Rows(i).ChildBands
                        For Each fila As UltraGridRow In aChildBand1.Rows
                            For y As Integer = 0 To aChildBand1.Rows.Count - 1
                                MarcasValueList(grilla_OA_Material)
                                aChildBand1.Rows(y).Cells("IdMarca").ValueList = .DisplayLayout.ValueLists("Marcas")
                                aChildBand1.Rows(y).Cells("IdMarca").Value = "1CH000000000"

                                ModelosValueList(aChildBand1.Rows(y).Cells("IdMarca").Value.ToString(), grilla_OA_Material)
                                aChildBand1.Rows(y).Cells("IdModelo").ValueList = .DisplayLayout.ValueLists("Modelos")
                                aChildBand1.Rows(y).Cells("IdModelo").Value = "1CH000000000"

                                EstadosValueList(grilla_OA_Material)
                                aChildBand1.Rows(y).Cells("IdEstado").ValueList = .DisplayLayout.ValueLists("Estados")
                                aChildBand1.Rows(y).Cells("IdEstado").Value = "1CH00022"
                            Next
                        Next
                    Next
                Next
                For x As Integer = 0 To .Rows.Count - 1
                    .Rows(x).ExpandAll()
                Next
            End With
            grilla_OA_Material.UpdateData()
            grilla_OA_Material.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BuscarCodigoBarras(GrillaActual As ISL.Controles.Grilla, Tipo As Integer)
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
                    Select Case Tipo
                        Case 0 'OT
                            For Each reqmat As e_RequerimientoMaterial In lstRequerimientoMaterial
                                If codbarmat.IdMaterial = reqmat.IdMaterial Then
                                    flag = True
                                End If
                            Next
                        Case 1 'OA
                            For Each row As DataRow In ds_RM_DE.Tables(0).Rows
                                If codbarmat.IdMaterial = row("IdMaterial") Then
                                    flag = True
                                End If
                            Next
                    End Select
                Next
                If flag = False Then
                    Throw New Exception("Material no Encontrado en el Requerimiento")
                End If
                Select Case Tipo
                    Case 0 'OT
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
                                    With GrillaActual
                                        If .Rows.Count > 0 And txtCodigoBarras.Text <> "" Then
                                            For i = 0 To .Rows.Count - 1
                                                If .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.YellowGreen Then
                                                    .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.Khaki
                                                End If
                                                If Trim(.Rows(i).Cells("Id").Value) = mat.Id And .Rows(i).Cells("StockActual").Value > 0 Then
                                                    If .Rows(i).Cells("CantidadPorAtender").Value > .Rows(i).Cells("StockActual").Value Then
                                                        .Rows(i).Cells("CantidadAAtender").Value = .Rows(i).Cells("StockActual").Value
                                                        Throw New Exception("Cantidad por Atender Mayor a Stock, Solo se Está Atendiendo: " & .Rows(i).Cells("StockActual").Value)
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
                            Next
                        Else
                            Dim frm As New frm_DetalleCodigoBarra
                            frm.RequerimientoMaterial(listareqmaterial)
                            frm.ShowDialog()
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                            txtMaterial.Text = ""
                            txtMaterial.Text = frm.SeleccionRequerimiento.Material
                            With GrillaActual
                                If .Rows.Count > 0 And txtCodigoBarras.Text <> "" Then
                                    For i = 0 To .Rows.Count - 1
                                        If .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.YellowGreen Then
                                            .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.Khaki
                                        End If
                                        If Trim(.Rows(i).Cells("Id").Value) = frm.SeleccionRequerimiento.Id And .Rows(i).Cells("StockActual").Value > 0 Then
                                            If .Rows(i).Cells("CantidadPorAtender").Value > .Rows(i).Cells("StockActual").Value Then
                                                .Rows(i).Cells("CantidadAAtender").Value = .Rows(i).Cells("StockActual").Value
                                                Throw New Exception("Cantidad por Atender Mayor a Stock, Solo se Está Atendiendo: " & .Rows(i).Cells("StockActual").Value)
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
                    Case 1
                        Dim IdMat As String = ""
                        For Each row As DataRow In ds_RM_DE.Tables(0).Rows
                            For Each codmat As e_CodigoBarraMaterial In loCodBarMar
                                If row("IdMaterial") = codmat.IdMaterial Then
                                    IdMat = row("IdMaterial")
                                End If
                            Next
                        Next
                        If IdMat <> "" Then
                            With GrillaActual
                                If .Rows.Count > 0 And txtCodigoBarras.Text <> "" Then
                                    For i = 0 To .Rows.Count - 1
                                        If .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.YellowGreen Then
                                            .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.Khaki
                                        End If
                                        If Trim(.Rows(i).Cells("IdMaterial").Value) = IdMat And .Rows(i).Cells("StockActual").Value > 0 Then
                                            If .Rows(i).Cells("CantidadPorAtender").Value > .Rows(i).Cells("StockActual").Value Then
                                                .Rows(i).Cells("CantidadAAtender").Value = .Rows(i).Cells("StockActual").Value
                                                Throw New Exception("Cantidad por Atender Mayor a Stock, Solo se Está Atendiendo: " & .Rows(i).Cells("StockActual").Value)
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
                End Select    
            Else
                Throw New Exception("Codigo de Barra no Asignado a Material")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ActualizaPreRegistro()
        Try
            With griListaMaterialRequeridos
                For Each Fila In .Rows
                    If Fila.Cells("IdSubAlmacen").Value = "1CH000000002" Then
                        If Fila.Cells("CantidadPorAtender").Value > 0 Then
                            Fila.Cells("IdCentroCosto").Value = "FALTA"
                        Else
                            Fila.Cells("IdCentroCosto").Value = "OK"
                        End If
                    End If
                Next
                .UpdateData()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarDetalleOrdenNeu(ByVal leAux As List(Of e_DetalleOrdenNeumatico))
        Try
            Dim _IdAct As String = ""
            If leDetOrdenNeu.Count > 0 Then
                For Each oeAux In leAux
                    Dim _cod As String
                    _cod = oeAux.CodNeumatico
                    Dim _leAux = leDetOrdenNeu.Where(Function(it) it.CodNeumatico = _cod).ToList
                    If _leAux.Count = 0 Then
                        _IdAct = oeAux.IdReqMat
                        leDetOrdenNeu.Add(oeAux)
                    End If
                Next
            Else
                leDetOrdenNeu.AddRange(leAux)
                Dim _oeAct = leAux(0)
                _IdAct = _oeAct.IdReqMat
            End If
            If _IdAct.Trim <> "" Then
                Dim Fila = griListaMaterialRequeridos.Rows.Where(Function(it) it.Cells("Id").Value = _IdAct).ToList
                If Fila.Count > 0 Then
                    Fila(0).Cells("IdCentroCosto").Value = "OK"
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidaPreRegistro() As Boolean
        Try
            Dim bandpre As Boolean = True
            With griListaMaterialRequeridos
                For Each Fila In .Rows
                    If Fila.Cells("IdSubAlmacen").Value = "1CH000000002" Then
                        If Fila.Cells("IdCentroCosto").Value = "FALTA" Then
                            bandpre = False
                            Exit For
                        End If
                    End If
                Next
            End With
            Return bandpre
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnActualizarDetalle_Click(sender As Object, e As EventArgs) Handles btnActualizarDetalle.Click
        ActualizarDetalles()
    End Sub

    Private Function VerificarModificaciones() As Boolean
        Try
            Dim lsReqMat As New List(Of e_RequerimientoMaterial)
            Dim flag As Boolean = False
            lsReqMat = ListarRequerimientoActualizado()
            If lsReqMat.Count <> lstRequerimientoMaterial.Count Then Return False
            For Each reqmat As e_RequerimientoMaterial In lsReqMat
                flag = False
                For Each rm As e_RequerimientoMaterial In lstRequerimientoMaterial.Where(Function(item) item.Id = reqmat.Id).ToList
                    flag = True
                    With reqmat
                        If .Cantidad <> rm.Cantidad Then Return False
                    End With
                Next
                If flag = False Then
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub ActualizarDetalles()
        Try
            ListarDetalleRequerimiento()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarMarModEst()
        Try
            oeEstado = New e_Estado
            loEstado = New List(Of e_Estado)
            oeEstado.Nombre = "USO DEL MATERIAL"
            loEstado.AddRange(olEstado.Listar(oeEstado))

            oeMarca = New e_Marca
            loMarca = New List(Of e_Marca)
            oeMarca.TipoOperacion = "" 'Verificar 
            oeMarca.Activo = True
            loMarca.AddRange(olMarca.Listar(oeMarca))

            oeModelo = New e_Modelo
            loModelo = New List(Of e_Modelo)
            oeModelo.TipoOperacion = ""
            oeModelo.Activo = True
            loModelo.AddRange(olModelo.Listar(oeModelo))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TerminarRequerimiento()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ATENCION DE REQUERIMIENTOS") Then
                tipoOperacionDetReq = "4"
                controlaColumnasMateriales(False, False, False, False, False, 0, False, False, False)
                griListaMaterialRequeridos.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                grilla_OA_Material.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                ValidaFicha()
                Inicializar()
                lbl_etiqueta.Text = "Terminando RQ"
                lbl_etiqueta.Visible = 1
                CodigoBarras(False)
                If VerificarRegistroEditado() Then
                    If EditarRequerimiento() Then
                        oeRequerimiento.TipoOperacion = "T"
                        oeRequerimiento.IdUsuarioAtencion = gUsuarioSGI.Id
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        GuardarRegistroEditado()
                    End If
                End If
            Else
                Throw New Exception("No Tiene Permiso Para Regularizar Requerimientos")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EliminarRequerimiento()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ATENCION DE REQUERIMIENTOS") Then
                tipoOperacionDetReq = "4"
                controlaColumnasMateriales(False, False, False, False, False, 0, False, False, False)
                griListaMaterialRequeridos.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                grilla_OA_Material.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                ValidaFicha()
                Inicializar()
                lbl_etiqueta.Text = "Eliminando RQ"
                lbl_etiqueta.Visible = 1
                CodigoBarras(False)
                If VerificarRegistroEditado() Then
                    If EditarRequerimiento() Then
                        oeRequerimiento.TipoOperacion = "E"
                        oeRequerimiento.IdUsuarioAtencion = gUsuarioSGI.Id
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        GuardarRegistroEditado()
                    End If
                End If
            Else
                Throw New Exception("No Tiene Permiso Para Regularizar Requerimientos")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ValidaBotonesEvaluacionAtencion()
        Try
            If oeTrabajador.oeCargo.Nombre = "EMPLEADO DEL AREA" Then
                btnEvaluarReq.Visible = False
                btnAtenderReq.Visible = False
            Else
                If oeTrabajador.oeCargo.Nombre = "JEFE DE AREA" And oeArea.Nombre = "LOGÍSTICA" Then
                    btnEvaluarReq.Visible = True
                    btnAtenderReq.Visible = True
                Else
                    btnEvaluarReq.Visible = True
                    btnAtenderReq.Visible = False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarLogicas()
        Try
            olRequerimiento = New l_Requerimiento
            olMarca = New l_Marca
            olRequerimientoMaterial = New l_RequerimientoMaterial
            olRequerimientoServicio = New l_RequerimientoServicio
            olMaterial = New l_Material
            olControlEntregaMaterial = New l_ControlEntregaMaterial
            olServicio = New l_Servicio
            olCategoriaServicio = New l_CategoriaServicio
            olArea = New l_Area
            olUnidadMedida = New l_UnidadMedida
            olMaterialAlmacen = New l_MaterialAlmacen
            olCentroCosto = New l_CentroCosto
            olUsuario = New l_Usuario
            olSubalmacen = New l_SubAlmacen
            olTrabajador = New l_Trabajador
            olIGV = New l_Impuesto
            olOrdenSalida = New l_Orden
            olRegistroInventario = New l_RegistroInventario
            olDetalleMaterialAsignacion = New l_DetalleMaterialAsignacion
            olDetOrdenNeu = New l_DetalleOrdenNeumatico
            olMarca = New l_Marca
            olEstado = New l_Estado
            olModelo = New l_Modelo
            olInventario = New l_Inventario
            olCodBarMat = New l_CodigoBarraMaterial
            olRegistroEditado = New l_RegistrosEditados
            Prefijo = New l_Configuracion
            olTrabajadorSeguridad = New l_TrabajadorSeguridad
            olMovimientoInventario = New l_MovimientoInventario
            olEstadoRequerimiento = New l_EstadoRequerimiento
            oeRequerimiento = New e_Requerimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub VerificarOTMack()
        Try
            Dim oeOrdenTrabajo As New e_OrdenTrabajo
            Dim olOrdenTrabajo As New l_OrdenTrabajo
            oeOrdenTrabajo.Id = oeRequerimiento.IdReferencia
            oeOrdenTrabajo = olOrdenTrabajo.Obtener(oeOrdenTrabajo)
            If oeOrdenTrabajo.IndicadorTipo = "M" Then IndOtMack = True
            If IndOtMack Then
                With griListaMaterialRequeridos.DisplayLayout.Bands(0)
                    .Columns("IdAlmacen").CellActivation = Activation.NoEdit
                    .Columns("IdSubAlmacen").CellActivation = Activation.NoEdit
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu y tabs"

    Public Sub ControlaBarraOperacionesDetalle(lb_Consultar As Boolean, lb_Agregar As Boolean, lb_Quitar As Boolean)
        Try
            o_Botonera.Consultar = lb_Consultar
            o_Botonera.Guardar = lb_Agregar
            o_Botonera.Eliminar = lb_Quitar
            Botones(o_Botonera)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ConsultarDetalle(estadoPanel As Boolean)
        Try
            Select Case ficDetalle.SelectedTab.Index
                Case 0
                    gbeMateriales.Expanded = estadoPanel
                    'ListarMateriales(True)
                Case 1
                    'spcRequerimientoServicio.Panel2Collapsed = estadoPanel
                    gbeServicios.Expanded = estadoPanel
                    'ListarServicios(True)
            End Select
            ControlaBarraOperacionesDetalle(1, 1, 1)
        Catch ex As Exception
            Throw ex
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

    Private Sub griListaServicio_DoubleClick(sender As Object, e As EventArgs) Handles griListaServicio.DoubleClick
        Try
            AsignarServicioRequerimiento()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Requerimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InicializarLogicas()
            gf_AsignarEventoSeleccionarTexto(Me)
            gmt_ConfigurarEventoKeyEnter_Tab(Me, txtCodigoBarras.Name)
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
            oeUsuario = New e_Usuario
            oeUsuario.Id = gUsuarioSGI.Id
            oeUsuario = olUsuario.Obtener(oeUsuario)
            oeTrabajador = New e_Trabajador
            oeTrabajador.oePersona.Id = oeUsuario.oePersona.Id
            oeTrabajador = olTrabajador.ObtenerObjeto(oeTrabajador)
            oeArea = New e_Area
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
            'cboCentro.Value = Prefijo.PrefijoID '@0001
            cboCentro.Value = gs_PrefijoIdSucursal '@0001
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "VER SEDES LOGISTICA") Then
                cboCentro.Enabled = True
            Else
                cboCentro.Enabled = False
            End If
            griListaMaterialRequeridos.DisplayLayout.Bands(0).Columns("IdUnidadMedida").Header.Caption = "U. Medida"
            griListaMaterialRequeridos.DisplayLayout.Bands(0).Columns("IdAlmacen").Header.Caption = "Almacen"
            griListaMaterialRequeridos.DisplayLayout.Bands(0).Columns("IdCentroCosto").Header.Caption = "PreRegistro"
            controlaColumnasMateriales(True, False, True, True, True, 0, False, True)
            controlaColumnasServicio(True, False, True)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficRequerimiento)
            InicializaTiempo()
            CodigoBarras(False)
            LlenarMarModEst()
            If gUsuarioSGI.oeArea.Nombre = gNombreAreaMantenimiento Then
                cboRequerimiento.SelectedIndex = 1
            Else
                cboRequerimiento.SelectedIndex = 0
            End If
            AsientoContable()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Requerimiento_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'ActualizaRegistroEditado()
        instancia = Nothing
    End Sub

    Private Sub frm_Requerimiento_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ActualizaRegistroEditado()
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaRequerimientos.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        Eliminar()
        e.Cancel = True
    End Sub

    Private Sub verArea_AfterCheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cboAreaL.Enabled = cbArea.Checked
    End Sub

    Private Sub griListaMateriales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.CellChange
        Try
            griListaMateriales.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaMateriales_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaMateriales.InitializeLayout
        With griListaMateriales
            .DisplayLayout.Bands(0).SortedColumns.Add("Nombre", True, True)
            .DisplayLayout.GroupByBox.Hidden = True
        End With
    End Sub

    Private Sub griListaServicio_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaServicio.CellChange
        Try
            griListaServicio.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaMaterialRequeridos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMaterialRequeridos.CellChange
        Try
            griListaMaterialRequeridos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaServiciosRequeridos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaServiciosRequeridos.CellChange
        Try
            griListaServiciosRequeridos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaRequerimientos_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griListaRequerimientos.DoubleClickRow
        If griListaRequerimientos.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griListaMaterialRequeridos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaMaterialRequeridos.BeforeRowsDeleted
        e.Cancel = True
    End Sub

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

    Private Sub griListaMaterialRequeridos_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griListaMaterialRequeridos.BeforeCellUpdate
        Try
            With griListaMaterialRequeridos
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
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaMaterialRequeridos_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMaterialRequeridos.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListaMaterialRequeridos.Rows(e.Cell.Row.Index)
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
                    With griListaMaterialRequeridos
                        If .ActiveRow.Index > -1 Then
                            SubAlmacenValueList(.ActiveRow.Cells("IdAlmacen").Value.ToString, griListaMaterialRequeridos)
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
                            .ActiveRow.Cells("Ubicacion").Value = oeMat.Ubicacion
                            .ActiveRow.Cells("Precio").Value = ObtenerValorUnitario(.ActiveRow.Cells("IdMaterial").Value, .ActiveRow.Cells("IdSubAlmacen").Value)
                        End If
                    End With
                Case "IdSubAlmacen"
                    Dim oeMat As New e_Material
                    With griListaMaterialRequeridos
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
                    With griListaMaterialRequeridos.ActiveRow
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
                    With griListaMaterialRequeridos.ActiveRow
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
                    With griListaMaterialRequeridos.ActiveRow
                        cantidad = Convert.ToDouble(.Cells("Cantidad").Value)
                        If cantidad <= 0 Then
                            .Cells("Cantidad").Value = cantmat
                            Throw New Exception("La cantidad ingresada no puede ser menor o igual a 0. ")
                        End If
                    End With
                Case "IndRegularizado"
                    Dim stock As Double = 0
                    With griListaMaterialRequeridos.ActiveRow
                        If .Cells("CantidadPorAtender").Value > 0 Then
                            stock = Convert.ToDouble(.Cells("StockActual").Value)
                            If .Index > -1 Then
                                If stock = 0 Then
                                    If .Cells("IndRegularizado").Value = True Then
                                        .Cells("CantidadAAtender").Value = 0
                                    End If
                                ElseIf stock > 0 And .Cells("IndRegularizado").Value = False Then
                                    .Cells("IndRegularizado").Value = True
                                End If
                            End If
                        ElseIf .Cells("IndRegularizado").Value = False Then
                            .Cells("IndRegularizado").Value = True
                        End If
                    End With
                Case "CantidadARegularizar"
                    Dim cantidad As Double = 0
                    Dim stock As Double = 0
                    With griListaMaterialRequeridos.ActiveRow
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
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaRequerimientos_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaRequerimientos.AfterRowActivate
        Try
            ControlarEstadoRequerimiento()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEvaluarReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvaluarReq.Click
        Try
            EvaluarRequerimiento()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAtenderReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtenderReq.Click
        Try
            AtenderRequerimientos()
            Operacion = "Atender"
            VerificarOTMack()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboRequerimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRequerimiento.ValueChanged
        Try
            oeRequerimiento.MaterialServicio = cboRequerimiento.Value 'M: Material , S:Servicio 
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtDescripcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.ValueChanged
        Try
            oeRequerimiento.Descripcion = txtDescripcion.Text
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboFormaBusqueda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFormaBusqueda.ValueChanged
        Try
            oeRequerimiento.OpcionFecha = cboFormaBusqueda.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(txtBuscarMateriales.Text, "Ingrese el nombre del material que busca")
            ListarMateriales(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtBuscarMateriales_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarMateriales.ValueChanged
        Try
            txtBuscarMateriales.Text = LTrim(txtBuscarMateriales.Text)
            oeMaterial.Nombre = txtBuscarMateriales.Text
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ListarMateriales(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategoria.Click
        Try
            ListarServicios(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
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
                            AgregarReqMatDetalle(.Cells("IdDetalleRequerimiento").Value, Convert.ToInt64(cantAAtender), .Cells("IndDivisible").Value)
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
                                '.ActiveRow.Cells("IdModelo").Value = "" '.ActiveRow.Cells("IdMarca").Value.ToString
                                If .ActiveRow.Cells("IdModelo").ValueList.ItemCount > 0 Then
                                    .ActiveRow.Cells("IdModelo").ValueList.SelectedItemIndex = 0
                                    .ActiveRow.Cells("IdModelo").Value = IdModelo
                                End If
                                .UpdateData()
                                .DataBind()
                            End If
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grilla_OA_Material_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grilla_OA_Material.BeforeCellUpdate
        Try
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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grilla_OA_Material_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grilla_OA_Material.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaMaterialRequeridos_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMaterialRequeridos.ClickCellButton
        Try
            Dim oeReqMat As New e_RequerimientoMaterial
            Dim odReqMat As New l_RequerimientoMaterial
            With griListaMaterialRequeridos
                Select Case e.Cell.Column.Key
                    Case "CantidadPorAtender"
                        .ActiveRow.Cells("CantidadAAtender").Value = griListaMaterialRequeridos.ActiveCell.Value
                        .ActiveRow.Selected = True
                    Case "CantidadPorRegularizar"
                        .ActiveRow.Cells("CantidadARegularizar").Value = griListaMaterialRequeridos.ActiveCell.Value
                        .ActiveRow.Selected = True
                    Case "Glosa"
                        Dim glosa As String = .ActiveRow.Cells("Glosa").Value
                        If IsDBNull(glosa) Then griListaMaterialRequeridos.ActiveRow.Cells("Glosa").Value = ""
                        oeReqMat.Id = .ActiveRow.Cells("Id").Value
                        oeReqMat.Glosa = .ActiveRow.Cells("Glosa").Value
                        oeReqMat.Tipooperacion = "G"
                        oeReqMat.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If odReqMat.Guardar(oeReqMat) Then
                            mensajeEmergente.Confirmacion("Glosa Actualizada", True)
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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
                        oeReqMat.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If odReqMat.Guardar(oeReqMat) Then
                            mensajeEmergente.Confirmacion("Glosa Actualizada", True)
                        End If
                End Select
                .UpdateData()
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grilla_OA_Material_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grilla_OA_Material.CellChange
        Try
            grilla_OA_Material.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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
            If fecAtencion.Value = Date.Parse("01/01/1901") Then fecAtencion.Value = Date.Today
            oeRequerimiento.FechaAtencion = fecAtencion.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnRegReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegReq.Click
        RegularizarRequerimientos()
        Operacion = "Atender"
    End Sub

    Private Sub griListaMaterialRequeridos_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaMaterialRequeridos.InitializeLayout
        e.Layout.Bands(0).Columns("Glosa").Nullable = Nullable.Nothing
    End Sub

    Private Sub txtCodigoBarras_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoBarras.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                Select Case ficDetalle.SelectedTab.Index
                    Case 0
                        If txtCodigoBarras.Text <> "" Then
                            BuscarCodigoBarras(griListaMaterialRequeridos, 0)
                            txtCodigoBarras.Text = ""
                            txtCodigoBarras.Focus()
                        End If
                    Case 2
                        If txtCodigoBarras.Text <> "" Then
                            BuscarCodigoBarras(grilla_OA_Material, 1)
                            txtCodigoBarras.Text = ""
                            txtCodigoBarras.Focus()
                        End If
                End Select            
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaMaterialRequeridos_DoubleClickCell(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles griListaMaterialRequeridos.DoubleClickCell
        Try
            Select Case e.Cell.Column.Key
                Case "IdCentroCosto"
                    If e.Cell.Row.Cells("IdSubAlmacen").Value = "1CH000000002" AndAlso _
                    e.Cell.Row.Cells("IdCentroCosto").Value = "FALTA" Then
                        If e.Cell.Row.Cells("CantidadAAtender").Value = 0 Then
                            Throw New Exception("Ingrese Cantidad por Atender")
                        Else
                            oeMaterial = New e_Material
                            oeMaterial.TipoOperacion = "G"
                            oeMaterial.Id = e.Cell.Row.Cells("IdMaterial").Value.ToString
                            oeMaterial = olMaterial.Obtener(oeMaterial)
                            'oeMaterial.Precio = griDetalleOrdenIngreso.ActiveRow.Cells("PrecioUnitario").Value
                            If oeMaterial.oeMaterial_DisenoNeu IsNot Nothing AndAlso oeMaterial.oeMaterial_DisenoNeu.Id <> "" Then
                                oeDetOrdenNeu = New e_DetalleOrdenNeumatico
                                oeDetOrdenNeu.CantMat = e.Cell.Row.Cells("CantidadAAtender").Value
                                oeDetOrdenNeu.IdReqMat = e.Cell.Row.Cells("Id").Value
                                Dim oeOrdenAux As New e_Orden
                                oeOrdenAux.Total = leDetOrdenNeu.Count
                                Dim _leDONAux = leDetOrdenNeu.Where(Function(it) it.IdReqMat = e.Cell.Row.Cells("Id").Value).ToList
                                Dim ofrm As frm_DetalleOrdenNeumatico
                                ofrm = New frm_DetalleOrdenNeumatico(oeDetOrdenNeu, oeMaterial, oeOrdenAux, _leDONAux, 1)
                                If ofrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                                    LlenarDetalleOrdenNeu(leNOD)
                                End If
                            End If
                        End If
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbArea_CheckedChanged(sender As Object, e As EventArgs) Handles cbArea.CheckedChanged
        cboAreaL.Enabled = cbArea.Checked
    End Sub

    Private Sub grilla_OA_Material_DoubleClick(sender As Object, e As EventArgs) Handles grilla_OA_Material.DoubleClick
        Try
            If grilla_OA_Material.ActiveRow.Band.Index = 0 Then
                uebHistorialMaterial.Expanded = True
                Dim dsRegistroInv As New DataSet
                dsRegistroInv = ObtenerDetalleAsignacion(grilla_OA_Material.ActiveRow.Cells("IdMaterial").Value, ls_IdSubAlmacenAsignacion)
                Dim saldo As Double = 0
                Dim ingreso As Double = 0
                Dim salida As Double = 0
                If dsRegistroInv.Tables.Count > 0 AndAlso dsRegistroInv.Tables(0).Rows.Count > 0 Then
                    Dim i As Integer = 0
                    For Each Data As DataRow In dsRegistroInv.Tables(0).Rows
                        ingreso += Data("Ingreso")
                        salida += Data("Salida")
                    Next
                    saldo = ingreso - salida
                    While i <= dsRegistroInv.Tables(0).Rows.Count - 1
                        dsRegistroInv.Tables(0).Rows(i).Item("Saldo") = saldo
                        ingreso = dsRegistroInv.Tables(0).Rows(i).Item("Ingreso")
                        salida = dsRegistroInv.Tables(0).Rows(i).Item("Salida")
                        saldo = saldo - ingreso + salida
                        i += 1
                    End While
                End If
                grReg_Inv.DataSource = dsRegistroInv
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnActualizaOT_Click(sender As Object, e As EventArgs) Handles btnActualizaOT.Click
        Try
            Dim oeReq As New e_Requerimiento, olReq As New l_Requerimiento
            oeReq.TipoOperacion = "O"
            oeReq.Id = griListaRequerimientos.ActiveRow.Cells("Id").Value
            If olReq.ActualizaOT(oeReq) Then
                mensajeEmergente.Confirmacion("Los Datos se Actualizaron", True)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnTerminarRQ_Click(sender As Object, e As EventArgs) Handles btnTerminarRQ.Click
        Try
            TerminarRequerimiento()
            Operacion = "Terminar"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try   
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            EliminarRequerimiento()
            Operacion = "Eliminar"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Requerimiento_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Requerimiento_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            Select Case Operacion
                Case "Inicializa"
                    Tiempo1.Enabled = False
                    InicializaTiempo()
                    MostrarTabs(0, ficRequerimiento)
                    If gUsuarioSGI.oeArea.Nombre = gNombreAreaMantenimiento Then
                        cboRequerimiento.Enabled = False
                        'cboRequerimiento.SelectedIndex = 1
                        cmEquipo.Visible = True
                        Etiqueta11.Visible = True
                    Else
                        cboRequerimiento.Enabled = True
                        'cboRequerimiento.SelectedIndex = 0
                        cmEquipo.Visible = False
                        Etiqueta11.Visible = False
                    End If
                    Consultar(True)
                    If gUsuarioSGI.oeArea.Nombre = gNombreAreaMantenimiento Then
                        If griListaRequerimientos.Rows.Count > 0 Then
                            ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Else
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        End If
                    Else
                        If griListaRequerimientos.Rows.Count > 0 Then
                            ControlBoton(1, 0, 1, 0, 0, 1, 0, 1, 1)
                        Else
                            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                        End If
                    End If

                Case "Ayuda"
            End Select
            ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Requerimiento_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub ControlBotoneria()
        Try
            If gUsuarioSGI.oeArea.Nombre = gNombreAreaMantenimiento Then
                Select Case ficRequerimiento.SelectedTab.Index
                    Case 0
                        If griListaRequerimientos.Rows.Count > 0 Then
                            ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Else
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        End If
                    Case 1
                        If (oeRequerimiento.EstadoRequerimiento.Equals("EVALUADO") Or oeRequerimiento.EstadoRequerimiento.Contains("ATENDIDO")) Then
                            ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 1)
                        Else
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
                        End If
                End Select
            Else
                Select Case ficRequerimiento.SelectedTab.Index
                    Case 0
                        If griListaRequerimientos.Rows.Count > 0 Then
                            ControlBoton(1, 0, 1, 0, 0, 1, 0, 1, 1)
                        Else
                            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                        End If
                    Case 1
                        If (oeRequerimiento.EstadoRequerimiento.Equals("EVALUADO") Or oeRequerimiento.EstadoRequerimiento.Contains("ATENDIDO")) Then
                            If Operacion = "Atender" Or Operacion = "Terminar" Or Operacion = "Eliminar" Then
                                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
                            Else
                                ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 1)
                            End If
                        Else
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
                        End If
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Try
            Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Try
            Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EvaluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvaluarToolStripMenuItem.Click
        Try
            EvaluarRequerimiento()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AtenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtenderToolStripMenuItem.Click
        Try
            AtenderRequerimientos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        Try
            MenuContextual1.Items("InsertarToolStripMenuItem").Visible = 0
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = 0
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 0
            MenuContextual1.Items("EvaluarToolStripMenuItem").Enabled = 0
            MenuContextual1.Items("AtenderToolStripMenuItem").Enabled = 0
            If griListaRequerimientos.Selected.Rows.Count > 0 Then
                MenuContextual1.Items("EditarToolStripMenuItem").Visible = 1
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 1
                ControlarEstadoRequerimiento()
                If cboRequerimiento.Text = "MATERIALES" Then
                    Select Case griListaRequerimientos.ActiveRow.Cells("EstadoRequerimiento").Value
                        Case "GENERADO"
                            MenuContextual1.Items("EvaluarToolStripMenuItem").Enabled = 1
                        Case "EVALUADO", "PARCIALMENTE ATENDIDO"
                            MenuContextual1.Items("AtenderToolStripMenuItem").Enabled = 1
                    End Select
                Else
                    Select Case griListaRequerimientos.ActiveRow.Cells("EstadoRequerimiento").Value
                        Case "GENERADO"
                            MenuContextual1.Items("EvaluarToolStripMenuItem").Enabled = 1
                    End Select
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

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