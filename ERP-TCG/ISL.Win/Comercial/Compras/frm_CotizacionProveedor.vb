'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios Centro y Giro
'=================================================================================================================


Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports Infragistics.Win.UltraWinGrid.UltraGridAction

Public Class frm_CotizacionProveedor
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Dim oeCotizacion As New e_Cotizacion
    Dim olCotizacion As New l_Cotizacion
    Dim llCotizacion As New List(Of e_Cotizacion)

    Dim oeCotizacionDetalleMat As New e_CotizacionDetalleMat
    Dim olCotizacionDetalleMat As New l_CotizacionDetalleMat
    Dim llCotizacionDetalleMat As New List(Of e_CotizacionDetalleMat)
    Dim loCotProDetMate As New List(Of e_CotizacionDetalleMat)

    Dim oeCotizacionDetalleSer As New e_CotizacionDetalleSer
    Dim olCotizacionDetalleSer As New l_CotizacionDetalleSer
    Dim llCotizacionDetalleSer As New List(Of e_CotizacionDetalleSer)
    Dim loCotProDetServ As New List(Of e_CotizacionDetalleSer)

    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material
    Dim llMaterial As New List(Of e_Material)

    Dim oeRequerimientoMaterial As New e_RequerimientoMaterial
    Dim olRequerimientoMaterial As New l_RequerimientoMaterial
    Dim llRequerimientoMaterial As New List(Of e_RequerimientoMaterial)

    Dim oeRequerimiento As New e_Requerimiento
    Dim olRequerimiento As New l_Requerimiento
    Dim loRequerimiento As New List(Of e_Requerimiento)

    Dim oeRequerimientoServicios As New e_RequerimientoServicio
    Dim olRequerimientoServicios As New l_RequerimientoServicio
    Dim llRequerimientoServicios As New List(Of e_RequerimientoServicio)

    Dim oeUnidadMedida As New e_UnidadMedida
    Dim olUnidadMedida As New l_UnidadMedida


    Dim olMaterialAlmacen As New l_MaterialAlmacen
    Dim oeMaterialAlmacen As New e_MaterialAlmacen

    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor
    Dim llProveedor As New List(Of e_Proveedor)

    Dim oeCotizacionProveedor As e_Cotizacion_Proveedor
    Dim llCotizacionProveedor As New List(Of e_Cotizacion_Proveedor)
    Dim olCotizacionProveedor As New l_Cotizacion_Proveedor

    Dim maxAltura As Integer = 400
    Dim minAltura As Integer = 235
    Dim posMat As Integer

    Dim olUsuario As New l_Usuario
    Dim oeUsuario As New e_Usuario

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda
    Dim loMoneda As New List(Of e_Moneda)

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro

    Dim oeAlmacen As New e_Almacen
    Dim olAlmacen As New l_Almacen

    Dim oeServicio As New e_Servicio
    Dim olServicio As New l_Servicio
    Dim llServicios As New List(Of e_Servicio)

    Dim listaauxser As New List(Of e_CotizacionDetalleSer)

    Dim _ingresando_datos As Boolean = False
    Dim IdCotizacionProveedor As String = String.Empty

#End Region

#Region "Inicialización del formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_CotizacionProveedor = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            instancia = New frm_CotizacionProveedor()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar(Activo)
            Tiempo1.Enabled = True
            If griCotizacion.Rows.Count > 0 Then
                If Activo Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                End If
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
            'Ubica el cursor el el primer registro de la grilla

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        'ControlaTabMantenimiento(True, True, minAltura)
        oeCotizacion.TipoOperacion = "I"
        oeCotizacion.PrefijoID = gs_PrefijoIdSucursal '@0001
        Operacion = "Nuevo"
        MostrarTabs(1, ficCotizacionProveedor, 1)
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        InicializarListas()
        ListarProveedores(True)
    End Sub

    Public Overrides Sub Editar()
        Try
            'ControlaTabMantenimiento(False, False, maxAltura)
            Operacion = "Editar"
            InicializarListas()
            ListarProveedores(True)
            If griCotizacion.Rows.Count > 0 Then
                If EditarCotizacion() Then ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0) 'Habilito el boton Guardar                                
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            GuardarCotizacion()
            MostrarTabs(0, ficCotizacionProveedor, 2)
            InicializaTiempo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCotizacion.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarCotizacion() Then
                            MostrarTabs(0, ficCotizacionProveedor, 2)
                            '_ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            ' _ingresando_datos = True
                            MostrarTabs(1, ficCotizacionProveedor, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficCotizacionProveedor, 2)
                        ' _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficCotizacionProveedor, 2)
                '_ingresando_datos = False
                Consultar(_Activo)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griCotizacion
                If .ActiveRow.Index > -1 AndAlso ValidarGrilla(griCotizacion, "Cotización") Then
                    oeCotizacion.Id = .ActiveRow.Cells("ID").Value
                    'oeCotizacion.FechaInicio = "01/01/1901"
                    oeCotizacion.PrefijoID = gs_PrefijoIdSucursal '@0001
                    oeCotizacion = olCotizacion.Obtener(oeCotizacion)
                    If oeCotizacion.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la cotización : " & _
                                 .ActiveRow.Cells("Codigo").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeCotizacion.TipoOperacion = "E"
                            oeCotizacion.PrefijoID = gs_PrefijoIdSucursal '@0001
                            olCotizacion.Eliminar(oeCotizacion)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                Else
                    Throw New Exception("Seleccione una cotización para eliminarla. ")
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griCotizacion.Rows.Count = 0 Then Throw New Exception("No Existen Datos a Exportar")
            Exportar_Excel(griCotizacion)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        ImprimirCotizacion(False)
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Private Function GuardarCotizacion() As Boolean
        Try
            LlenarObjeto()
            oeCotizacion.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeCotizacion.IndMaterialServicio = IIf(cboRequerimiento.SelectedIndex = 0, "M", "S")
            If olCotizacion.Guardar(oeCotizacion) Then
                If Operacion <> "Evaluar" Then
                    Select Case MessageBox.Show("Desea Enviar el Mail al Proveedor?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                        Case Windows.Forms.DialogResult.Yes
                            ImprimirCotizacion(True)
                    End Select
                End If
                mensajeEmergente.Confirmacion("La información ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficCotizacionProveedor, 2)
                Consultar(_Activo)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub LlenarObjeto()
        Try
            oeCotizacion.Glosa = txtGlosa.Text
            oeCotizacion.IdMoneda = cboMoneda.Value
            oeCotizacion.UsuarioCreacion = gUsuarioSGI.Id
            oeCotizacion.lstCotizacionProveedor = llCotizacionProveedor
            oeCotizacion.IdEquipo = txtEquipo.Tag
            oeCotizacion.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Operacion = "Nuevo" Then
                oeCotizacion.IdEstado = "1CH00014"
                For Each cotpro As e_Cotizacion_Proveedor In oeCotizacion.lstCotizacionProveedor
                    cotpro.lstCotizacionDetalleMat = llCotizacionDetalleMat
                    cotpro.lstCotizacionDetalleSer = llCotizacionDetalleSer
                Next
            Else
                For Each cotpro As e_Cotizacion_Proveedor In oeCotizacion.lstCotizacionProveedor
                    cotpro.lstCotizacionDetalleSer = New List(Of e_CotizacionDetalleSer)
                    cotpro.lstCotizacionDetalleSer = IIf(loCotProDetServ.Count > 0, loCotProDetServ.Where(Function(item) item.IdCotizacionProveedor = cotpro.Id).ToList, _
                                                         llCotizacionDetalleSer.Where(Function(item) item.IdCotizacionProveedor = cotpro.Id).ToList)
                    If Operacion = "Evaluar" Then
                        If cotpro.IdProveedor = txtProveedor.Tag Then
                            cotpro.IndAprobado = True
                        End If
                    End If
                Next
                If Operacion = "Evaluar" Then
                    If txtProveedor.Text = "" Then Throw New Exception("Debe Seleccionar Un Proveedor")
                    oeCotizacion.IdEstado = "1CH00031"
                    oeCotizacion.IdProveedor = txtProveedor.Tag
                    oeCotizacion.Importe = numTotalCotizacion.Value
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        dtpFechaCotDesde.Value = Date.Now.AddDays(-7)
        dtpFechaCotHasta.Value = Date.Now
        dtpReqDesde.Value = Date.Now.AddDays(-7)
        dtpReqHasta.Value = Date.Now
        cboRequerimiento.SelectedIndex = 0
    End Sub

    Private Function EditarCotizacion() As Boolean
        Dim id As String
        Try
            With griCotizacion
                id = .ActiveRow.Cells("Id").Value.ToString
                If id.Trim.Length > 0 Then
                    oeCotizacion.Id = id
                    oeCotizacion.Activo = True
                    oeCotizacion = olCotizacion.Obtener(oeCotizacion)
                    oeCotizacion.PrefijoID = gs_PrefijoIdSucursal '@0001
                    oeCotizacion.TipoOperacion = "A"
                    cboMoneda.Value = oeCotizacion.IdMoneda
                    txtGlosa.Value = oeCotizacion.Glosa
                    txtProveedor.Text = oeCotizacion.Proveedor
                    txtProveedor.Tag = oeCotizacion.IdProveedor
                    txtEquipo.Text = oeCotizacion.Equipo
                    txtEquipo.Tag = oeCotizacion.IdEquipo
                    MostrarTabs(1, ficCotizacionProveedor, 1)
                    ListarProveedoresCotizar(True)
                    Return True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ListarCotizacionDetalle(IndAprobado As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case cboRequerimiento.SelectedIndex
                Case 0
                    oeCotizacionDetalleMat = New e_CotizacionDetalleMat
                    oeCotizacionDetalleMat.IdCotizacionProveedor = oeCotizacion.Id
                    oeCotizacionDetalleMat.TipoOperacion = "1"
                    oeCotizacionDetalleMat.PrefijoID = gs_PrefijoIdSucursal '@0001
                    With griListadoCotizacionDetalle
                        llCotizacionDetalleMat = olCotizacionDetalleMat.Listar(oeCotizacionDetalleMat)
                        '.DataSource = llCotizacionDetalleMat
                    End With
                    'llenaCombosGrillaMatReqCotizacion()
                Case 1
                    oeCotizacionDetalleSer = New e_CotizacionDetalleSer
                    oeCotizacionDetalleSer.IdCotizacionProveedor = oeCotizacion.Id
                    oeCotizacionDetalleSer.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If IndAprobado Then
                        oeCotizacionDetalleSer.TipoOperacion = "2"
                        llCotizacionDetalleSer = olCotizacionDetalleSer.Listar(oeCotizacionDetalleSer)
                        griCotizacionDetalleSer.DataSource = llCotizacionDetalleSer
                    Else
                        oeCotizacionDetalleSer.TipoOperacion = "1"
                        llCotizacionDetalleSer = olCotizacionDetalleSer.Listar(oeCotizacionDetalleSer)
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarProveedoresCotizar(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeCotizacionProveedor = New e_Cotizacion_Proveedor
            oeCotizacionProveedor.IdCotizacion = oeCotizacion.Id
            oeCotizacionProveedor.Activo = Activo
            oeCotizacionProveedor.Tipooperacion = ""
            oeCotizacionProveedor.PrefijoID = gs_PrefijoIdSucursal '@0001
            If oeCotizacion.Estado = gNombreEstadoAprobada Then
                oeCotizacionProveedor.IndAprobado = True
                griCotizacionDetalleSer.Enabled = False
                Agrupacion10.Visible = False
                With mnuCotizacionProveedor
                    .Tools("Agregar").SharedProps.Visible = False
                    .Tools("Eliminar").SharedProps.Visible = False
                End With
            End If
            With griListadoProveedoresCotizar
                llCotizacionProveedor = olCotizacionProveedor.Listar(oeCotizacionProveedor)
                .DataSource = llCotizacionProveedor
            End With
            ListarCotizacionDetalle(oeCotizacionProveedor.IndAprobado)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Dim loCotizacion As New List(Of e_Cotizacion)
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ValidarFechaDesde_Hasta(dtpFechaCotDesde, dtpFechaCotHasta)
            oeCotizacion = New e_Cotizacion
            oeCotizacion.FechaInicio = dtpFechaCotDesde.Value
            oeCotizacion.FechaFinal = dtpFechaCotHasta.Value
            oeCotizacion.Activo = True
            oeCotizacion.IndMaterialServicio = IIf(cboRequerimiento.SelectedIndex = 0, "M", "S")
            oeCotizacion.PrefijoID = gs_PrefijoIdSucursal '@0001
            loCotizacion.AddRange(olCotizacion.Listar(oeCotizacion).OrderByDescending(Function(item) item.FechaCreacion))
            With griCotizacion
                .DataSource = loCotizacion
                If .Rows.Count > 0 Then
                    .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                    .Focus()
                    .Rows(0).Selected = True
                End If
                For Each fila As UltraGridRow In .Rows
                    Select Case fila.Cells("Estado").Value
                        Case gNombreEstadoGenerada
                            fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                        Case gNombreEstadoAprobada
                            fila.CellAppearance.BackColor = Me.ColoresEvaluado.Color
                        Case gNombreEstadoTerminada
                            fila.CellAppearance.BackColor = Me.ColoresAtendido.Color
                        Case Else
                            fila.CellAppearance.BackColor = Color.White
                    End Select
                Next
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub llenaGrillaReqMat(ByVal Activo As Boolean)
        Try
            Select Case cboRequerimiento.SelectedIndex
                Case 0
                    oeRequerimientoMaterial = New e_RequerimientoMaterial
                    ValidarFechaDesde_Hasta(dtpReqDesde, dtpReqHasta)
                    oeRequerimientoMaterial.Tipooperacion = "3"
                    oeRequerimientoMaterial.Activo = Activo
                    oeRequerimientoMaterial.FechaInicio = dtpReqDesde.Value
                    oeRequerimientoMaterial.FechaFinal = dtpReqHasta.Value
                    oeRequerimientoMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
                    llRequerimientoMaterial = olRequerimientoMaterial.Listar(oeRequerimientoMaterial)
                    '--------------------------------------------------------------------------------------------------------------            
                    With griListaRequerimiento
                        .DataSource = llRequerimientoMaterial
                    End With
                    ConfigurarGrilla(griListaRequerimiento, 0)
                Case 1
                    oeRequerimiento = New e_Requerimiento
                    ValidarFechaDesde_Hasta(dtpReqDesde, dtpReqHasta)
                    oeRequerimiento.TipoOperacion = "8"
                    oeRequerimiento.MaterialServicio = "S"
                    oeRequerimiento.FechaInicio = dtpReqDesde.Value
                    oeRequerimiento.FechaFinal = dtpReqHasta.Value
                    oeRequerimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    loRequerimiento = olRequerimiento.Listar(oeRequerimiento)
                    griListaRequerimiento.DataSource = loRequerimiento
                    'ConfigurarGrilla(griListaRequerimiento, 1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ConfigurarGrilla(Grilla As ISL.Controles.Grilla, Tipo As Integer)
        Try
            'With Grilla
            '    Select Case Tipo
            '        Case 0
            '            .DataSource = llRequerimientoMaterial
            '            .DisplayLayout.Bands(0).Columns("IdSubAlmacen").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("Ubicacion").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("CantidadARegularizar").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("FechaAtencion").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("CantidadPorRegularizar").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("IndRegularizado").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("IdEstadoRequerimientoMaterial").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("IdUnidadMedida").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("IdTipoUnidadMedida").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("IdMaterial").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("IdAlmacen").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("CantidadAAtender").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("Trabajador").Hidden = True
            '            .DisplayLayout.Bands(0).Columns("EstadoRequerimientoMaterial").Hidden = True

            '            .DisplayLayout.Bands(0).Columns("CodigoMaterial").Header.VisiblePosition = 0
            '            .DisplayLayout.Bands(0).Columns("Material").Header.VisiblePosition = 1
            '            .DisplayLayout.Bands(0).Columns("UnidadMedida").Header.VisiblePosition = 3
            '            .DisplayLayout.Bands(0).Columns("CantidadPorAtender").Header.VisiblePosition = 4
            '            .DisplayLayout.Bands(0).Columns("Almacen").Header.VisiblePosition = 5
            '            .DisplayLayout.Bands(0).Columns("StockActual").Header.VisiblePosition = 6

            '            .DisplayLayout.Bands(0).Columns("CodigoMaterial").Width = 100
            '            .DisplayLayout.Bands(0).Columns("Material").Width = 300
            '            .DisplayLayout.Bands(0).Columns("UnidadMedida").Width = 90
            '            .DisplayLayout.Bands(0).Columns("CantidadPorAtender").Width = 100
            '            .DisplayLayout.Bands(0).Columns("Almacen").Width = 200
            '            .DisplayLayout.Bands(0).Columns("StockActual").Width = 80

            '            .DisplayLayout.Bands(0).Columns("CantidadPorAtender").Style = ColumnStyle.Double
            '            .DisplayLayout.Bands(0).Columns("StockActual").Style = ColumnStyle.Double
            '            .DisplayLayout.Bands(0).Columns("CantidadPorAtender").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '            .DisplayLayout.Bands(0).Columns("StockActual").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '        Case 1
            '            .DataSource = llRequerimientoServicios
            '            OcultarColumna(Grilla, True, "IdServicio", "Asignado", "IdEmpresaServicio", "IdEquipo", "IdEstadoRequerimientoServicio", "Aprobacion")

            '            .DisplayLayout.Bands(0).Columns("NroOT").Header.Caption = "Requerimiento"
            '            .DisplayLayout.Bands(0).Columns("NroOT").CellAppearance.TextVAlign = Infragistics.Win.VAlign.Middle

            '            .DisplayLayout.Bands(0).Columns("NroOT").MergedCellStyle = MergedCellStyle.Always
            '            .DisplayLayout.Bands(0).Columns("Equipo").MergedCellStyle = MergedCellStyle.Always

            '            .DisplayLayout.Bands(0).Columns("NroOT").Header.VisiblePosition = 0
            '            .DisplayLayout.Bands(0).Columns("CodigoServicio").Header.VisiblePosition = 1
            '            .DisplayLayout.Bands(0).Columns("Servicio").Header.VisiblePosition = 2
            '            .DisplayLayout.Bands(0).Columns("EstadoRequerimientoServicio").Header.VisiblePosition = 3

            '            .DisplayLayout.Bands(0).Columns("NroOT").Width = 90
            '            .DisplayLayout.Bands(0).Columns("CodigoServicio").Width = 100
            '            .DisplayLayout.Bands(0).Columns("Servicio").Width = 250
            '            .DisplayLayout.Bands(0).Columns("EstadoRequerimientoServicio").Width = 150
            '    End Select
            '    .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            '    .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
            '    .DisplayLayout.Override.FilterUIProvider = Filtro1
            '    .DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
            '    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            '    .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
            '    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            'End With
            'OcultarColumna(Grilla, True, "CodigoRequerimiento", "IdArea", "Area", "IndicadorAprobacion", "Activo", "UsuarioCreacion", "FechaCreacion" _
            '   , "Mantenimiento", "IdMantenimiento", "Seleccion", "IdCentroCosto", "CentroCosto", "Id", "Cantidad", "Precio", "Glosa", "IdRequerimiento")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarListas()
        Try
            Me.txtGlosa.Text = String.Empty
            Me.txtBuscarMateriales.Text = String.Empty

            Select Case cboRequerimiento.SelectedIndex
                Case 0
                    ficCotizacionDetalle.Tabs(0).Visible = True
                    ficCotizacionDetalle.Tabs(1).Visible = False
                    ficDetalles.Tabs(2).Visible = True
                    ficDetalles.Tabs(3).Visible = False
                Case 1
                    ficCotizacionDetalle.Tabs(0).Visible = False
                    ficCotizacionDetalle.Tabs(1).Visible = True
                    ficDetalles.Tabs(2).Visible = False
                    ficDetalles.Tabs(3).Visible = True
            End Select

            ficDetalles.Tabs(0).Selected = True

            'LimpiaGrid(griCotizacion, odCotizaciones)
            LimpiaGrid(griListadoCotizacionDetalle, odCotizacionDetalle)
            'LimpiaGrid(griListadoProveedor, ordProveedor)
            LimpiaGrid(griListaMateriales, odMaterial)

            LimpiaGrid(griListadoProveedoresCotizar, odCotizacionProveedor)

            With mnuCotizacionProveedor
                .Tools("Agregar").SharedProps.Visible = True
                .Tools("Eliminar").SharedProps.Visible = True
                If Operacion = "Editar" Then .Tools("Agregar").SharedProps.Visible = False
            End With

            llRequerimientoMaterial.Clear()
            llRequerimientoServicios.Clear()
            llMaterial.Clear()
            llCotizacionDetalleMat.Clear()
            llProveedor.Clear()
            llCotizacionProveedor.Clear()

            IdCotizacionProveedor = ""

            griCotizacionDetalleSer.Enabled = True
            Agrupacion10.Visible = True

            txtProveedor.Text = String.Empty
            txtProveedor.Tag = Nothing
            txtEquipo.Text = String.Empty
            txtEquipo.Tag = Nothing

            loCotProDetMate = New List(Of e_CotizacionDetalleMat)
            loCotProDetServ = New List(Of e_CotizacionDetalleSer)

            llCotizacionDetalleSer = New List(Of e_CotizacionDetalleSer)
            griCotizacionDetalleSer.DataSource = llCotizacionDetalleSer

            griListaMateriales.DataSource = llMaterial
            griListadoCotizacionDetalle.DataSource = llCotizacionDetalleMat

            griListadoProveedor.DataSource = llProveedor
            griListadoProveedoresCotizar.DataSource = llCotizacionProveedor

            loRequerimiento = New List(Of e_Requerimiento)
            griListaRequerimiento.DataSource = loRequerimiento
            '.ResetDisplayLayout()
            'ConfigurarGrilla(griListaRequerimiento, cboRequerimiento.SelectedIndex)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ListarMateriales(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If Not String.IsNullOrEmpty(Trim(oeMaterial.Nombre)) Then
                oeMaterial = New e_Material
                oeMaterial.Activo = True
                oeMaterial.TipoOperacion = "G"
                oeMaterial.Nombre = txtBuscarMateriales.Text
                llMaterial = olMaterial.Listar(oeMaterial)
                griListaMateriales.DataSource = llMaterial
                With griListaMateriales
                    .DataSource = llMaterial
                    .Rows.ExpandAll(True)
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                End With
                llenaCombosGrillaMaterialRequerido()

            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Sub llenaCombosGrillaMaterialRequerido()
        Try
            For i As Integer = 0 To griListaMateriales.Rows.Count - 1
                oeUnidadMedida = New e_UnidadMedida()
                oeUnidadMedida.Activo = True
                oeUnidadMedida.Factor = 0
                oeUnidadMedida.IdTipoUnidadMedida = griListaMateriales.Rows(i).Cells("IdTipoUnidadMedida").Value.ToString
                CrearComboGridPorCelda("IdUnidadMedida", "Nombre", i, griListaMateriales, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)

                oeMaterialAlmacen = New e_MaterialAlmacen()
                oeMaterialAlmacen.Activo = True
                oeMaterialAlmacen.TipoOperacion = "4"
                oeMaterialAlmacen.IdMaterial = griListaMateriales.Rows(i).Cells("Id").Value.ToString
                CrearComboGridPorCelda("IdAlmacen", "Nombre", i, griListaMateriales, olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen), True)
            Next
            griListaMateriales.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub llenaCombosGrillaMatReqCotizacion()
        Try
            For i As Integer = 0 To griListadoCotizacionDetalle.Rows.Count - 1
                oeUnidadMedida = New e_UnidadMedida()
                oeUnidadMedida.Activo = True
                oeUnidadMedida.Factor = 0
                oeUnidadMedida.IdTipoUnidadMedida = griListadoCotizacionDetalle.Rows(i).Cells("IdTipoUnidadMedida").Value.ToString
                CrearComboGridPorCelda("IdUnidadMedida", "Nombre", i, griListadoCotizacionDetalle, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)

                oeMaterialAlmacen = New e_MaterialAlmacen()
                oeMaterialAlmacen.Activo = True
                oeMaterialAlmacen.TipoOperacion = "4"
                oeMaterialAlmacen.IdMaterial = griListadoCotizacionDetalle.Rows(i).Cells("IdMaterial").Value.ToString
                CrearComboGridPorCelda("IdAlmacen", "Nombre", i, griListadoCotizacionDetalle, olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen), True)

            Next
            griListaMateriales.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AsignarProveedorCotizacion(ByVal IdProveedor As String)
        Try
            oeProveedor = New e_Proveedor
            oeProveedor.Id = IdProveedor
            oeProveedor.Activo = True
            oeProveedor.TipoOperacion = "2"
            oeProveedor = olProveedor.Obtener(oeProveedor)

            oeCotizacionProveedor = New e_Cotizacion_Proveedor
            oeCotizacionProveedor.IdProveedor = oeProveedor.Id
            oeCotizacionProveedor.CodigoProveedor = oeProveedor.Codigo
            oeCotizacionProveedor.UsuarioCreacion = gUsuarioSGI.Id
            oeCotizacionProveedor.Proveedor = oeProveedor.Nombre
            oeCotizacionProveedor.Contacto = oeProveedor.Contacto
            oeCotizacionProveedor.Email = oeProveedor.Email ' "edaloliva@hotmail.com" '   
            oeCotizacionProveedor.PrefijoID = gs_PrefijoIdSucursal '@0001
            llCotizacionProveedor.Add(oeCotizacionProveedor)

            llProveedor.RemoveAll(AddressOf eliminaproveedor)
            griListadoProveedoresCotizar.DataBind()
            griListadoProveedor.DataBind()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub AsignarMaterialesCotizacion()
        Try
            For Each cotdet As e_CotizacionDetalleMat In llCotizacionDetalleMat
                If oeMaterial.Id = cotdet.IdMaterial Then
                    Throw New Exception("Material ya Asignado")
                End If
            Next
            oeCotizacionDetalleMat = New e_CotizacionDetalleMat
            oeCotizacionDetalleMat.UsuarioCreacion = gUsuarioSGI.Id
            oeCotizacionDetalleMat.IdMaterial = oeMaterial.Id
            oeCotizacionDetalleMat.Cantidad = oeMaterial.Peso
            oeCotizacionDetalleMat.Material = oeMaterial.Nombre
            oeCotizacionDetalleMat.IdUnidadMedida = oeMaterial.IdUnidadMedida
            oeCotizacionDetalleMat.UnidadMedida = oeMaterial.UnidadMedida
            oeCotizacionDetalleMat.IdTipoUnidadMedida = oeMaterial.IdTipoUnidadMedida
            oeCotizacionDetalleMat.IdSubAlmacen = oeMaterial.IdSubAlmacen
            oeCotizacionDetalleMat.IdAlmacen = oeMaterial.IdAlmacen
            oeCotizacionDetalleMat.Almacen = oeMaterial.Almacen
            oeCotizacionDetalleMat.CodigoMaterial = oeMaterial.Codigo
            oeCotizacionDetalleMat.TipoCotizacion = "M"
            posMat = posMat + 1
            oeCotizacionDetalleMat.PosMat = posMat
            oeCotizacionDetalleMat.PrefijoID = gs_PrefijoIdSucursal '@0001
            llCotizacionDetalleMat.Add(oeCotizacionDetalleMat)

            griListaMateriales.DataBind()
            griListadoCotizacionDetalle.DataBind()
            llenaCombosGrillaMatReqCotizacion()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub AsignarRequerimientoCotizacion(ByVal IdRequerimiento As String)
        Try
            Select Case cboRequerimiento.SelectedIndex
                Case 0
                    oeCotizacionDetalleMat = New e_CotizacionDetalleMat
                    oeRequerimientoMaterial = New e_RequerimientoMaterial
                    oeRequerimientoMaterial.Id = IdRequerimiento
                    oeRequerimientoMaterial.Activo = True
                    oeRequerimientoMaterial.Tipooperacion = "3"
                    oeRequerimientoMaterial = olRequerimientoMaterial.Obtener(oeRequerimientoMaterial)
                    oeRequerimientoMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
                    oeCotizacionDetalleMat.UsuarioCreacion = gUsuarioSGI.Id
                    oeCotizacionDetalleMat.IdMaterial = oeRequerimientoMaterial.IdMaterial
                    oeCotizacionDetalleMat.Cantidad = oeRequerimientoMaterial.Cantidad
                    oeCotizacionDetalleMat.Material = oeRequerimientoMaterial.Material
                    oeCotizacionDetalleMat.IdUnidadMedida = oeRequerimientoMaterial.IdUnidadMedida
                    oeCotizacionDetalleMat.UnidadMedida = oeRequerimientoMaterial.UnidadMedida
                    oeCotizacionDetalleMat.IdTipoUnidadMedida = oeRequerimientoMaterial.IdTipoUnidadMedida
                    oeCotizacionDetalleMat.IdAlmacen = oeRequerimientoMaterial.IdAlmacen
                    oeCotizacionDetalleMat.IdSubAlmacen = oeRequerimientoMaterial.IdSubAlmacen
                    oeCotizacionDetalleMat.Almacen = oeRequerimientoMaterial.Almacen
                    oeCotizacionDetalleMat.TipoCotizacion = "RM"
                    oeCotizacionDetalleMat.IdRequerimientoMaterial = oeRequerimientoMaterial.Id
                    oeCotizacionDetalleMat.CodigoMaterial = oeRequerimientoMaterial.CodigoMaterial
                    oeCotizacionDetalleMat.PrefijoID = gs_PrefijoIdSucursal '@0001
                    llCotizacionDetalleMat.Add(oeCotizacionDetalleMat)

                    llRequerimientoMaterial.RemoveAll(AddressOf eliminaRequerimientoMaterial)
                    griListaRequerimiento.DataBind()
                    griListadoCotizacionDetalle.DataBind()
                    llenaCombosGrillaMatReqCotizacion()

                Case 1

                    oeRequerimientoServicios = New e_RequerimientoServicio
                    oeRequerimientoServicios.Tipooperacion = "1"
                    oeRequerimientoServicios.IdRequerimiento = IdRequerimiento
                    oeRequerimientoServicios.PrefijoID = gs_PrefijoIdSucursal '@0001
                    Me.txtEquipo.Tag = griListaRequerimiento.ActiveRow.Cells("IdEquipo").Value
                    Me.txtEquipo.Text = griListaRequerimiento.ActiveRow.Cells("Referencia").Value
                    llRequerimientoServicios = olRequerimientoServicios.Listar(oeRequerimientoServicios)
                    For Each reqser As e_RequerimientoServicio In llRequerimientoServicios
                        reqser.PrefijoID = gs_PrefijoIdSucursal '@0001
                        oeCotizacionDetalleSer = New e_CotizacionDetalleSer
                        With oeCotizacionDetalleSer
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .IdServicio = reqser.IdServicio
                            .CodigoServicio = reqser.CodigoServicio
                            .Servicio = reqser.Servicio
                            .Precio = 0
                            .Cantidad = reqser.Cantidad
                            .IdRequerimientoServicio = reqser.Id
                            .PrefijoID = gs_PrefijoIdSucursal '@0001
                        End With
                        llCotizacionDetalleSer.Add(oeCotizacionDetalleSer)
                    Next
                    'llRequerimientoServicios.RemoveAll(AddressOf eliminaRequerimientoServicio)
                    'griListaRequerimiento.DataBind()
                    griCotizacionDetalleSer.DataBind()
            End Select
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function eliminaRequerimientoMaterial(ByVal oeReqMat As e_RequerimientoMaterial) As Boolean
        Return oeReqMat.Id = oeCotizacionDetalleMat.IdRequerimientoMaterial
    End Function

    Private Sub MostrarDetalleCot(IdCotPro As String)
        Try
            Dim listaauxmat As New List(Of e_CotizacionDetalleMat)
            Select Case cboRequerimiento.SelectedIndex
                Case 0
                    LimpiaGrid(griListadoCotizacionDetalle, odCotizacionDetalle)
                Case 1
                    Me.numTotalCotizacion.Value = 0
                    listaauxser = New List(Of e_CotizacionDetalleSer)
                    griCotizacionDetalleSer.DataSource = listaauxser
                    If loCotProDetServ.Where(Function(item) item.IdCotizacionProveedor = IdCotPro).ToList.Count > 0 Then
                        griCotizacionDetalleSer.DataSource = loCotProDetServ.Where(Function(item) item.IdCotizacionProveedor = IdCotPro).ToList
                    Else
                        loCotProDetServ.AddRange(llCotizacionDetalleSer.Where(Function(item) item.IdCotizacionProveedor = IdCotPro).ToList)
                        griCotizacionDetalleSer.DataSource = loCotProDetServ.Where(Function(item) item.IdCotizacionProveedor = IdCotPro).ToList
                    End If
                    Me.numTotalCotizacion.Value = loCotProDetServ.Where(Function(item) item.IdCotizacionProveedor = IdCotPro).ToList.Sum(Function(item) item.Precio)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarProveedores(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griListadoProveedor
                oeProveedor = New e_Proveedor
                oeProveedor.Activo = Activo
                oeProveedor.TipoOperacion = "2"
                oeProveedor.TipoPersonaEmpresa = 1
                llProveedor = olProveedor.Listar(oeProveedor)
                .DataSource = llProveedor
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        griListadoProveedor.Focus()

    End Sub

    Public Sub ImprimirCotizacion(ByVal enviarCorreo As Boolean)

        Dim objXls As Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objWorkSheet As Excel.Worksheet
        objXls = New Excel.Application
        Dim FileToCopy As String
        Dim PathFile As String
        Try
            If llCotizacionDetalleMat.Count > 0 Or llCotizacionDetalleSer.Count > 0 Then
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\Plantilla_Cotizacion.xlt"
                PathFile = Application.StartupPath & "\" & "Cotizacion.xls"
                If System.IO.File.Exists(FileToCopy) = True And System.IO.File.Exists(PathFile) = True Then
                    System.IO.File.SetAttributes(PathFile, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                    System.IO.File.Copy(FileToCopy, PathFile, True)
                    System.IO.File.SetAttributes(PathFile, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                Else
                    If System.IO.File.Exists(FileToCopy) = True Then
                        System.IO.File.Copy(FileToCopy, PathFile, True)
                        System.IO.File.SetAttributes(PathFile, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                    Else
                        Throw New Exception("No se encontro el archivo de Plantilla, Consulte con Soporte")
                    End If
                End If
                ' Creamos una variable para guardar la cultura actual
                Dim OldCultureInfo As System.Globalization.CultureInfo = _
                System.Threading.Thread.CurrentThread.CurrentCulture
                'Crear una cultura standard (en-US) inglés estados unidos
                System.Threading.Thread.CurrentThread.CurrentCulture = _
                New System.Globalization.CultureInfo("es-PE")

                objWorkbook = objXls.Workbooks.Open(PathFile)
                objWorkSheet = objXls.Worksheets(1)
                objWorkSheet.Name = "Cotizacion"

                objWorkSheet.Cells(4, 9) = oeCotizacion.Codigo
                objWorkSheet.Cells(9, 13) = Date.Now.Date

                objWorkSheet.Cells(7, 13) = cboMoneda.Text

                Dim ln_Fila As Integer = 1
                If oeCotizacion.IndMaterialServicio = "M" Then
                    For Each detalle As e_CotizacionDetalleMat In llCotizacionDetalleMat
                        objWorkSheet.Cells(ln_Fila + 16, 1) = ln_Fila
                        objWorkSheet.Cells(ln_Fila + 16, 2) = detalle.CodigoMaterial
                        objWorkSheet.Cells(ln_Fila + 16, 4) = detalle.Cantidad
                        objWorkSheet.Cells(ln_Fila + 16, 5) = detalle.Material
                        objWorkSheet.Cells(ln_Fila + 16, 13) = detalle.UnidadMedida
                        objWorkSheet.Cells(ln_Fila + 16, 17) = detalle.IdMaterial
                        ln_Fila = ln_Fila + 1
                    Next
                Else
                    For Each detalle As e_CotizacionDetalleSer In llCotizacionDetalleSer
                        objWorkSheet.Cells(ln_Fila + 16, 1) = ln_Fila
                        objWorkSheet.Cells(ln_Fila + 16, 2) = detalle.CodigoServicio
                        objWorkSheet.Cells(ln_Fila + 16, 4) = detalle.Cantidad
                        objWorkSheet.Cells(ln_Fila + 16, 5) = detalle.Servicio
                        objWorkSheet.Cells(ln_Fila + 16, 13) = ""
                        objWorkSheet.Cells(ln_Fila + 16, 17) = detalle.IdServicio
                        ln_Fila = ln_Fila + 1
                    Next
                End If

                'Mostramos el documento en pantalla
                objXls.ActiveWindow.Zoom = 100
                objXls.ActiveWindow.DisplayGridlines = False
                objXls.Sheets.Item(1).Select()
                ' Proteger con password la hoja de calculo para que no se pueda editar. 
                'objWorkSheet.Protect("SOFTCOM", True, True, True, True)
                System.IO.File.SetAttributes(PathFile, IO.FileAttributes.ReadOnly)
                If Not enviarCorreo Then
                    objXls.Visible = True
                Else
                    Dim ruta As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & objWorkbook.Name & ".xls"
                    Dim ruta2 As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & objWorkbook.Name & ".xlsx"
                    Dim Documento As String
                    If System.IO.File.Exists(ruta) Then
                        System.IO.File.Delete(ruta)
                    End If
                    If System.IO.File.Exists(ruta2) Then
                        System.IO.File.Delete(ruta2)
                    End If
                    objWorkbook.Save()
                    Documento = objWorkbook.Path & "\" & objWorkbook.Name
                    objXls.Workbooks.Close()
                    objXls.Quit()
                    If Not llCotizacionProveedor.Count > 0 Then Throw New Exception("Seleccione al menos un proveedor")
                    Dim listaMailProveedor As String = ""
                    For Each detalle As e_Cotizacion_Proveedor In llCotizacionProveedor
                        listaMailProveedor &= detalle.Email.Trim & ";"
                    Next
                    listaMailProveedor = Strings.Left(listaMailProveedor, listaMailProveedor.Length - 1)
                    Dim correoTrabajador As String = "" 'Quien lo envia                    
                    Dim formulario As frm_EnvioCorreo
                    formulario = frm_EnvioCorreo
                    If gUsuarioSGI.oePersona.leEmail.Count > 0 Then correoTrabajador = gUsuarioSGI.oePersona.leEmail.Item(0).Nombre '"weezer@hotmail.com" 'Quiem lo envia                
                    If formulario.ObtenerDatos("", Documento, correoTrabajador, True, True, True, True, _
                         listaMailProveedor, "Por favor solicito cotización de los materiales especificados en el documento adjunto.") Then
                        formulario.ShowDialog()
                        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                    End If
                    formulario = Nothing
                End If
                'objXls.ActiveWorkbook.Close(False)
                objWorkSheet = Nothing
                objWorkbook = Nothing
                objXls = Nothing
                'Restauramos la cultura original
                System.Threading.Thread.CurrentThread.CurrentCulture = OldCultureInfo

            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Sub LlenaCombo()
        oeMoneda = New e_Moneda
        oeMoneda.Activo = True
        oeMoneda.TipoOperacion = "1"
        loMoneda.AddRange(olMoneda.Listar(oeMoneda))
        LlenarComboMaestro(cboMoneda, loMoneda, 0)

        oeCentro.TipoOperacion = ""
        oeCentro.Activo = True
        LlenarComboMaestro(cboCentro, olCentro.Listar(oeCentro), 0)
        cboCentro.Value = ObtenerCentro.Id

        Dim oeCategoriaServicio As New e_CategoriaServicio
        Dim olCategoriaServicio As New l_CategoriaServicio
        Dim lstCategoriasServicio As New List(Of e_CategoriaServicio)

        oeCategoriaServicio.Id = "CERO" : oeCategoriaServicio.Nombre = "TODOS"
        lstCategoriasServicio.Add(oeCategoriaServicio)
        oeCategoriaServicio = New e_CategoriaServicio
        oeCategoriaServicio.Activo = True
        lstCategoriasServicio.AddRange(olCategoriaServicio.Listar(oeCategoriaServicio))
        LlenarComboMaestro(cboCategoriaServicios, lstCategoriasServicio, 0)

    End Sub

    Private Sub AsignarProveedorCotizacion()
        Try
            Dim count As Integer = llProveedor.Where(Function(item) item.Seleccion = True).ToList.Count + llCotizacionProveedor.Count
            If count > 3 Then Throw New Exception("Solo Puede Cotizar Maximo a 3 Proveedores")
            If llProveedor.Where(Function(item) item.Seleccion = True).ToList.Count > 3 Then Throw New Exception("Solo Puede Cotizar Maximo a 3 Proveedores")
            If llCotizacionProveedor.Count > 3 Then Throw New Exception("Solo Puede Cotizar Maximo a 3 Proveedores")
            For Each prove As e_Proveedor In llProveedor
                If prove.Seleccion Then
                    oeCotizacionProveedor = New e_Cotizacion_Proveedor
                    oeCotizacionProveedor.IdProveedor = prove.Id
                    oeCotizacionProveedor.CodigoProveedor = prove.Codigo
                    oeCotizacionProveedor.UsuarioCreacion = gUsuarioSGI.Id
                    oeCotizacionProveedor.Proveedor = prove.Nombre
                    oeCotizacionProveedor.Contacto = prove.Contacto
                    oeCotizacionProveedor.Email = prove.Email
                    oeCotizacionProveedor.PrefijoID = gs_PrefijoIdSucursal '@0001
                    llCotizacionProveedor.Add(oeCotizacionProveedor)
                End If
            Next
            griListadoProveedoresCotizar.DataBind()
            llenaCombosGrillaMatReqCotizacion()
            llProveedor.RemoveAll(AddressOf eliminaproveedor)
            griListadoProveedor.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarProveedorCotizacion()
        Try
            If griListadoProveedoresCotizar.Rows.Count > 0 Then
                llCotizacionProveedor.RemoveAll(AddressOf verificarseleccionado)
                griListadoProveedor.DataBind()
                griListadoProveedoresCotizar.DataBind()
                'muestraCantidadElementosGrilla()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function verificarseleccionado(ByVal oeCotPro As e_Cotizacion_Proveedor) As Boolean
        Try
            If Not String.IsNullOrEmpty(oeCotPro.IdProveedor) AndAlso oeCotPro.Seleccion Then
                Dim oePro As New e_Proveedor
                oePro.Id = oeCotPro.IdProveedor
                oePro.Activo = True
                oePro.TipoOperacion = "2"
                oePro = olProveedor.Obtener(oePro)
                llProveedor.Add(oePro)
                llProveedor.OrderBy(Function(item) item.Nombre)
            End If
            Return oeCotPro.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function eliminaproveedor(ByVal oeProv As e_Proveedor) As Boolean
        Return oeProv.Seleccion
    End Function

    Private Sub LimpiaCombo(ByVal cboCombo As ISL.Controles.Combo)
        If cboCombo.Items.Count > 0 Then
            cboCombo.Items.Clear()
        End If
    End Sub

    Private Sub ComboAlmacen(ByVal idCentro As String)
        Try
            oeAlmacen.TipoOperacion = ""
            oeAlmacen.Activo = True
            oeAlmacen.IdCentro = idCentro
            LlenarComboMaestro(cboAlmacen, olAlmacen.Listar(oeAlmacen), 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub QuitarMaterial()
        Try
            If griListadoCotizacionDetalle.ActiveRow.Selected Then
                Dim oeCotDet As New e_CotizacionDetalleMat
                oeCotDet = griListadoCotizacionDetalle.ActiveRow.ListObject
                If oeCotDet.TipoCotizacion = "RM" Or oeCotDet.TipoCotizacion = "M" Then
                    oeCotDet = llCotizacionDetalleMat.Item(llCotizacionDetalleMat.IndexOf(oeCotDet))
                    llCotizacionDetalleMat.Remove(oeCotDet)
                End If
                griListadoCotizacionDetalle.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CotizacionProveedor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficCotizacionProveedor.SelectedTab.Index
            Case 0
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_CotizacionProveedor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_CotizacionProveedor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_CotizacionProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, ficCotizacionProveedor)
        Tiempo1.Enabled = False
        InicializaTiempo()
        Inicializar()
        LlenaCombo()
        'griListaRequerimiento.ResetDisplayLayout()
    End Sub

    Private Sub griCotizacion_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griCotizacion.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListaRequerimientoMaterial_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.Cancel = True
    End Sub

    Private Sub griListadoProveedoresCotizar_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListadoProveedoresCotizar.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListadoProveedor_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListadoProveedor.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListadoCotizacionDetalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListadoCotizacionDetalle.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub btnListarMaterialesReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMaterialesReq.Click
        llenaGrillaReqMat(True)
    End Sub

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        ListarMateriales(True)
    End Sub

    Private Sub txtBuscarMateriales_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarMateriales.ValueChanged
        txtBuscarMateriales.Text = LTrim(txtBuscarMateriales.Text)
        oeMaterial.Nombre = txtBuscarMateriales.Text
    End Sub

    Private Sub griListaMateriales_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "IdAlmacen"
                    Dim oeMat As New e_Material
                    With griListaMateriales.ActiveRow
                        If .Index > -1 Then
                            oeMat.TipoOperacion = "5"
                            oeMat.Id = .Cells("Id").Value
                            oeMat.IdAlmacen = .Cells("IdAlmacen").Value
                            oeMat.Activo = True
                            oeMat = olMaterial.ObtenerMaterialSegunAlmacen(oeMat)
                            .Cells("Stock").Value = oeMat.Stock
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaMateriales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.CellChange
        griListaMateriales.UpdateData()
    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        If e.KeyCode = Keys.Enter Then ListarMateriales(True)
    End Sub

    Private Sub griListaRequerimientoMaterial_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaRequerimiento.DoubleClick
        Try
            If cboRequerimiento.SelectedIndex = 0 Then

            Else
                If griCotizacionDetalleSer.Rows.Count > 0 Then
                    Throw New Exception("Ya Asigno un Requerimiento para esta Cotizacion")
                End If
            End If
            If griListaRequerimiento.ActiveRow.Index > -1 AndAlso griListaRequerimiento.Rows.Count > 0 Then
                AsignarRequerimientoCotizacion(griListaRequerimiento.ActiveRow.Cells("Id").Value)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaMateriales_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaMateriales.DoubleClick
        Try
            With griListaMateriales
                If .ActiveRow.Index > -1 AndAlso .Rows.Count > 0 Then
                    oeMaterial = New e_Material
                    oeMaterial.Id = .ActiveRow.Cells("Id").Value
                    oeMaterial.Nombre = .ActiveRow.Cells("Nombre").Value
                    oeMaterial.IdUnidadMedida = .ActiveRow.Cells("IdUnidadMedida").Value
                    oeMaterial.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value
                    oeMaterial.IdSubAlmacen = .ActiveRow.Cells("IdSubAlmacen").Value
                    oeMaterial.Almacen = .ActiveRow.Cells("Almacen").Value
                    oeMaterial.Peso = .ActiveRow.Cells("Peso").Value 'Contiene la cantidad a cotizar
                    oeMaterial.Codigo = .ActiveRow.Cells("Codigo").Value
                    oeMaterial.IdTipoUnidadMedida = .ActiveRow.Cells("IdTipoUnidadMedida").Value
                    oeUnidadMedida = New e_UnidadMedida
                    oeUnidadMedida.Id = oeMaterial.IdUnidadMedida
                    oeUnidadMedida = olUnidadMedida.Obtener(oeUnidadMedida)
                    oeMaterial.UnidadMedida = oeUnidadMedida.Nombre
                    AsignarMaterialesCotizacion()
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Boton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton1.Click
        ImprimirCotizacion(True)
    End Sub

    Private Sub griListadoProveedoresCotizar_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griListadoProveedoresCotizar.BeforeCellUpdate
        Try
            With griListadoProveedoresCotizar
                Select Case e.Cell.Column.Key
                    Case "Email"
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

    Private Sub griListadoCotizacionDetalle_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griListadoCotizacionDetalle.BeforeCellUpdate
        Try
            With griListadoCotizacionDetalle
                Select Case e.Cell.Column.Key
                    Case "Cantidad"
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

    Private Sub mnuCotizacionProveedor_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuCotizacionProveedor.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    AsignarProveedorCotizacion()
                Case "Eliminar"
                    QuitarProveedorCotizacion()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListadoProveedor_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListadoProveedor.CellChange
        griListadoProveedor.UpdateData()
    End Sub

    Private Sub griListadoProveedoresCotizar_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListadoProveedoresCotizar.CellChange
        griListadoProveedoresCotizar.UpdateData()
    End Sub

    Private Sub cboCentro_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cboCentro.ValueChanged
        LimpiaCombo(cboAlmacen)
        ComboAlmacen(cboCentro.Value)
    End Sub

    Private Sub griCotizacion_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griCotizacion.DoubleClick
        Editar()
    End Sub

    Private Sub MenuContextual1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        Try
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
            If griListadoCotizacionDetalle.Rows.Count > 0 Then
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            QuitarMaterial()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListadoCotizacionDetalle_CellChange(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListadoCotizacionDetalle.CellChange
        griListadoCotizacionDetalle.UpdateData()
    End Sub

    Private Sub griCotizacionDetalleSer_CellChange(sender As Object, e As CellEventArgs) Handles griCotizacionDetalleSer.CellChange
        griCotizacionDetalleSer.UpdateData()
    End Sub

    Private Sub MenuContextual2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuContextual2.Opening
        MenuContextual2.Items("InsertarToolStripMenuItem").Visible = 1
        MenuContextual2.Items("EditarToolStripMenuItem").Visible = 0
        MenuContextual2.Items("ToolStripMenuItem1").Visible = 0
        MenuContextual2.Items("AprobarToolStripMenuItem").Visible = 0
        If griCotizacion.Selected.Rows.Count > 0 Then
            MenuContextual2.Items("EditarToolStripMenuItem").Visible = 1
            MenuContextual2.Items("ToolStripMenuItem1").Visible = 1
            Select Case griCotizacion.ActiveRow.Cells("Estado").Value
                Case "GENERADA"
                    MenuContextual2.Items("AprobarToolStripMenuItem").Visible = 1
                Case "APROBADA", "TERMINADA"
                    MenuContextual2.Items("AprobarToolStripMenuItem").Visible = 0
                    MenuContextual2.Items("ToolStripMenuItem1").Visible = 0
            End Select
        End If
    End Sub

    Private Sub griListadoProveedoresCotizar_Click(sender As Object, e As EventArgs) Handles griListadoProveedoresCotizar.Click
        Try
            If Operacion <> "Nuevo" Then
                IdCotizacionProveedor = ""
                IdCotizacionProveedor = griListadoProveedoresCotizar.ActiveRow.Cells("Id").Value
                MostrarDetalleCot(IdCotizacionProveedor)
                Me.txtProveedor.Text = griListadoProveedoresCotizar.ActiveRow.Cells("Proveedor").Value
                Me.txtProveedor.Tag = griListadoProveedoresCotizar.ActiveRow.Cells("IdProveedor").Value
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AprobarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AprobarToolStripMenuItem.Click
        Editar()
        Operacion = "Evaluar"
        griCotizacionDetalleSer.Enabled = False
        Agrupacion10.Visible = False
        With mnuCotizacionProveedor
            .Tools("Agregar").SharedProps.Visible = False
            .Tools("Eliminar").SharedProps.Visible = False
        End With
    End Sub

    Private Sub griCotizacionDetalleSer_KeyDown(sender As Object, e As KeyEventArgs) Handles griCotizacionDetalleSer.KeyDown
        With griCotizacionDetalleSer
            Dim int As Integer = .ActiveRow.Index
            If .Rows(Int).Cells("Precio").IsActiveCell Then
                If e.KeyCode = Keys.Down Then
                    .PerformAction(ExitEditMode, False, False)
                    .PerformAction(BelowCell, False, False)
                    e.Handled = True
                    .PerformAction(EnterEditMode, False, False)
                End If
                If e.KeyCode = Keys.Up Then
                    .PerformAction(ExitEditMode, False, False)
                    .PerformAction(AboveCell, False, False)
                    e.Handled = True
                    .PerformAction(EnterEditMode, False, False)
                End If
                If e.KeyValue = Keys.Space Then
                    .PerformAction(UltraGridAction.ExitEditMode, 0, 0)
                    .PerformAction(UltraGridAction.EnterEditMode, 0, 0)
                End If
            End If
        End With
    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeServicio.TipoOperacion = "S"
            oeServicio.Activo = True
            oeServicio.IdCategoriaServicio = IIf(cboCategoriaServicios.Value = "CERO", "", cboCategoriaServicios.Value)
            llServicios = olServicio.Listar(oeServicio)
            With griListaServicio
                .DataSource = llServicios
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DataBind()
                .Focus()
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaServicio_DoubleClick(sender As Object, e As EventArgs) Handles griListaServicio.DoubleClick
        Try
            If griListaServicio.Selected.Rows.Count > 0 Then
                Dim oecot As New e_CotizacionDetalleSer
                Dim oeServ As New e_Servicio
                oeServ = griListaServicio.ActiveRow.ListObject
                oecot.Tipo = 0
                oecot.IdServicio = oeServ.Id
                If llCotizacionDetalleSer.Contains(oecot) Then
                    Throw New Exception("Servicio ya Asignado a la Cotizacion")
                Else
                    If Operacion = "Nuevo" Then
                        oeCotizacionDetalleSer = New e_CotizacionDetalleSer
                        With oeCotizacionDetalleSer
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .IdServicio = oeServ.Id
                            .CodigoServicio = oeServ.Codigo
                            .Servicio = oeServ.Nombre
                            .Precio = 0
                            .Cantidad = 1
                            .IdRequerimientoServicio = ""
                            .PrefijoID = gs_PrefijoIdSucursal '@0001
                        End With
                        llCotizacionDetalleSer.Add(oeCotizacionDetalleSer)
                        griCotizacionDetalleSer.DataBind()
                    Else
                        If loCotProDetServ.Count = 0 Then
                            Throw New Exception("Seleccione Proveedor Para Agregar Servicio Adicional")
                        Else
                            oecot = New e_CotizacionDetalleSer
                            oecot.IdServicio = oeServ.Id
                            If loCotProDetServ.Contains(oecot) Then
                                Throw New Exception("Servicio ya Asignado")
                            End If
                        End If
                        listaauxser = New List(Of e_CotizacionDetalleSer)
                        griCotizacionDetalleSer.DataSource = listaauxser
                        oeCotizacionDetalleSer = New e_CotizacionDetalleSer
                        With oeCotizacionDetalleSer
                            .TipoOperacion = "I"
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .IdServicio = oeServ.Id
                            .CodigoServicio = oeServ.Codigo
                            .Servicio = oeServ.Nombre
                            .Precio = 0
                            .Cantidad = 1
                            .IdRequerimientoServicio = ""
                            .IdCotizacionProveedor = IdCotizacionProveedor
                            .PrefijoID = gs_PrefijoIdSucursal '@0001
                        End With
                        loCotProDetServ.Add(oeCotizacionDetalleSer)
                        griCotizacionDetalleSer.DataSource = loCotProDetServ.Where(Function(item) item.IdCotizacionProveedor = IdCotizacionProveedor).ToList
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class