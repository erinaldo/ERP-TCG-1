'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios Centro y Giro
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports Microsoft.Office.Interop


Public Class frm_MaterialesNegociados
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_MaterialesNegociados = Nothing
    Private Shared Operacion As String = ""

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_MaterialesNegociados()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeMaterialesNegociados As e_MaterialesNegociados
    Private olMaterialesNegociados As l_MaterialesNegociados
    Private loMaterialesNegociados As List(Of e_MaterialesNegociados)

    Private oeMatNegociadosDet As e_MaterialesNegociadosDet
    Private olMatNegociadosDet As l_MaterialesNegociadosDet
    Private loMatNegociadosDet As List(Of e_MaterialesNegociadosDet)
    Private loMatNegVig As List(Of e_MaterialesNegociadosDet)
    Private loMatNegHis As List(Of e_MaterialesNegociadosDet)

    Dim oeCotizacionDetalle As e_CotizacionDetalleMat
    Dim olCotizacionDetalle As l_CotizacionDetalleMat
    Dim loCotizacionDetalle As List(Of e_CotizacionDetalleMat)

    Private oeMaterial As e_Material
    Private olMaterial As l_Material
    Private loMaterial As List(Of e_Material)

    Private Estado As String
    Private olTraSeg As l_TrabajadorSeguridad

    Dim oeIGV As e_Impuesto
    Dim olIGV As l_Impuesto

    Dim oeMoneda As e_Moneda
    Dim olMoneda As l_Moneda
    Dim loMoneda As List(Of e_Moneda)

    Dim _ingresando_datos As Boolean = False

    Dim Opcion As Boolean

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, ficMaterialesNegociables, 1)
            Operacion = "Nuevo"
            Inicializar()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            cboProveedorL.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            Mostrar()
            If Operacion = "NOEDIT" Then
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
            Else
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarMaterialNegociable() Then
                MostrarTabs(0, ficMaterialesNegociables, 0)
                Listar()
                ControlBotones()
            Else
                MostrarTabs(1, ficMaterialesNegociables, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMaterialesNegociados.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarMaterialNegociable() Then
                            MostrarTabs(0, ficMaterialesNegociables, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficMaterialesNegociables, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficMaterialesNegociables, 2)
                        ficMaterialesNegociables.Tabs(2).Enabled = False
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficMaterialesNegociables)
                _ingresando_datos = False
                Operacion = ""
                Listar()
                ControlBotones()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficMaterialesNegociables.SelectedTab.Index = 0 AndAlso griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficMaterialesNegociables.SelectedTab.Index = 0 Then Exportar_Excel(griLista)
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            oeMaterialesNegociados = New e_MaterialesNegociados
            If griLista.ActiveRow.Band.Index = 0 Then
                oeMaterialesNegociados.Id = griLista.ActiveRow.Cells("Id").Value
                oeMaterialesNegociados.TipoOperacion = "E"
                If MessageBox.Show("¿Esta seguro eliminar el registro? ", _
             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    If olMaterialesNegociados.Eliminar(oeMaterialesNegociados) Then
                        mensajeEmergente.Confirmacion("La Informacion ha Sido Eliminada Correctamente")
                        Listar()
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CambiarVigencia()
        Try
            oeMaterialesNegociados = New e_MaterialesNegociados
            oeMaterialesNegociados.Id = griLista.ActiveRow.Cells("Id").Value
            oeMaterialesNegociados.TipoOperacion = "V"
            oeMaterialesNegociados.PrefijoID = gs_PrefijoIdSucursal '@0001
            Select Case MessageBox.Show("Seguro que Desea Caducar el Registro?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    olMaterialesNegociados.Eliminar(oeMaterialesNegociados)
                    Listar()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarLogicas()
        olMaterialesNegociados = New l_MaterialesNegociados
        olMatNegociadosDet = New l_MaterialesNegociadosDet
        olMaterial = New l_Material
        olIGV = New l_Impuesto
        olTraSeg = New l_TrabajadorSeguridad
        olMoneda = New l_Moneda
    End Sub

    Public Sub Inicializar()
        oeMaterialesNegociados = New e_MaterialesNegociados
        oeMatNegociadosDet = New e_MaterialesNegociadosDet
        oeIGV = New e_Impuesto
        oeIGV = olIGV.IGV(fecFecha.Value)
        LimpiarListas()
        oeMaterialesNegociados.TipoOperacion = "I"
        oeMaterialesNegociados.PrefijoID = gs_PrefijoIdSucursal '@0001
        cboProveedorL.Enabled = True
        cboMateriales.Value = Nothing
        cboMateriales.Text = String.Empty
        gbeMateriales.Expanded = False
    End Sub

    Public Sub LimpiarListas()
        loMatNegociadosDet = New List(Of e_MaterialesNegociadosDet)
        loMatNegVig = New List(Of e_MaterialesNegociadosDet)
        loMatNegHis = New List(Of e_MaterialesNegociadosDet)
        loCotizacionDetalle = New List(Of e_CotizacionDetalleMat)
        cboProveedorL.DataSource = Nothing
        cboProveedorL.Text = ""
        cboProveedorL.Value = ""
        txtDescripcion.Text = String.Empty
        griMatNegDet.DataSource = loMatNegVig
        griHistorial.DataSource = loMatNegHis
        griListadoCotizacionDetalle.DataSource = loCotizacionDetalle
    End Sub

    Private Sub ControlBotones()
        If griLista.Rows.Count > 0 Then
            ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
        Else
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Public Sub Listar()
        Try
            oeMaterialesNegociados = New e_MaterialesNegociados
            oeMaterialesNegociados.TipoOperacion = ""
            oeMaterialesNegociados.Fecha = Me.rangoFechaDesde.Value
            oeMaterialesNegociados.PrefijoID = gs_PrefijoIdSucursal '@0001
            Dim ds As DataSet = olMaterialesNegociados.Listar(oeMaterialesNegociados)
            Dim parentCol As DataColumn = ds.Tables(0).Columns("Id")
            Dim childCol As DataColumn = ds.Tables(1).Columns("IdMaterialesNegociados")
            Dim relation As DataRelation = New DataRelation("FKMaterialesNegociados", parentCol, childCol, True)
            ds.Relations.Add(relation)
            ds.AcceptChanges()
            griLista.DataSource = ds
            With griLista
                .DisplayLayout.Bands(1).Columns("Id").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdMaterialesNegociados").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdMaterial").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdMoneda").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdMaterial").Hidden = True
                .DisplayLayout.Bands(1).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(1).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(1).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdMaterial").Hidden = True

                .DisplayLayout.Bands(1).Columns("Material").Header.VisiblePosition = 1
                .DisplayLayout.Bands(1).Columns("Precio").Header.VisiblePosition = 2
                .DisplayLayout.Bands(1).Columns("Moneda").Header.VisiblePosition = 3
                .DisplayLayout.Bands(1).Columns("Glosa").Header.VisiblePosition = 4

                .DisplayLayout.Bands(1).Columns("Material").Width = 250
                .DisplayLayout.Bands(1).Columns("Precio").Style = ColumnStyle.Double
                .DisplayLayout.Bands(1).Columns("Precio").Format = "#,###,###,####0.00"
                .DisplayLayout.Bands(1).Columns("Precio").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(1).Columns("Precio").Header.Appearance.TextHAlign = HAlign.Right
                FormatoColorGrilla(griLista)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FormatoColorGrilla(ByVal grilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grilla.Rows
            Select Case fila.Cells("Vigente").Value
                Case True
                    fila.CellAppearance.BackColor = Me.ColoresVigente.Color
                Case False
                    fila.CellAppearance.BackColor = Me.ColoresCaducado.Color
            End Select
        Next
    End Sub

    Public Sub Mostrar()
        Try
            oeMaterialesNegociados = New e_MaterialesNegociados
            oeMatNegociadosDet = New e_MaterialesNegociadosDet
            oeMaterialesNegociados.TipoOperacion = "2"
            oeMaterialesNegociados.Id = griLista.ActiveRow.Cells("Id").Value
            oeMaterialesNegociados.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeMaterialesNegociados = olMaterialesNegociados.Obtener(oeMaterialesNegociados)
            ListarProveedores(cboProveedorL, oeMaterialesNegociados.IdProveedor, 0)
            cboProveedorL.Value = oeMaterialesNegociados.IdProveedor
            cboProveedorL.Enabled = False
            If griLista.ActiveRow.Cells("Vigente").Value = False Then
                Operacion = "NOEDIT"
            End If
            Me.txtDescripcion.Text = oeMaterialesNegociados.Glosa
            MostrarTabs(1, ficMaterialesNegociables, 1)
            oeMaterialesNegociados.TipoOperacion = "A"
            If olTraSeg.Permisos(gUsuarioSGI.IdTrabajador, "CAMBIAR PRECIO NEGOCIADO") Then
                griMatNegDet.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
            Else
                griMatNegDet.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
            End If
            ListarDetalle()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarDetalle()
        Try
            With oeMatNegociadosDet
                .TipoOperacion = "2"
                .IdMaterialesNegociados = oeMaterialesNegociados.Id
                .FechaCreacion = Date.Parse("01/01/1901")
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            loMatNegociadosDet = New List(Of e_MaterialesNegociadosDet)
            loMatNegVig = New List(Of e_MaterialesNegociadosDet)
            loMatNegHis = New List(Of e_MaterialesNegociadosDet)
            loMatNegociadosDet = olMatNegociadosDet.Listar(oeMatNegociadosDet)
            loMatNegVig.AddRange(loMatNegociadosDet.Where(Function(i) i.Vigente = True))
            griMatNegDet.DataSource = loMatNegVig.OrderBy(Function(i) i.Material).ToList
            loMatNegHis.AddRange(loMatNegociadosDet.Where(Function(i) i.Vigente = False))
            griHistorial.DataSource = loMatNegHis.OrderBy(Function(i) i.Material).ToList
            If griMatNegDet.Rows.Count > 0 Then
                oeMaterialesNegociados.TipoOperacion = "A"
            Else
                oeMaterialesNegociados.TipoOperacion = "I"
            End If
            FormatoColorGrilla(griMatNegDet)
            llenaCombosGrillaMaterialRequerido(griMatNegDet)
            llenaCombosGrillaMaterialRequerido(griHistorial)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GuardarMaterialNegociable() As Boolean
        Try
            oeMaterialesNegociados.IdProveedor = cboProveedorL.Value
            l_FuncionesGenerales.ValidarCampoNoNulo(oeMaterialesNegociados.IdProveedor, "Debe seleccionar un proveedor")
            If loMatNegVig.Count = 0 Then Throw New Exception("Agregue Materiales")
            If ValidarPrecios(loMatNegVig) = False Then Throw New Exception("El Precio no Puede ser 0")
            oeMaterialesNegociados.loMaterialesNegociadosDet = New List(Of e_MaterialesNegociadosDet)
            oeMaterialesNegociados.loMaterialesNegociadosDet = loMatNegVig
            oeMaterialesNegociados.loMaterialesNegociadosDet.AddRange(loMatNegHis)
            oeMaterialesNegociados.Fecha = fecFecha.Value
            oeMaterialesNegociados.UsuarioCreacion = gUsuarioSGI.Id
            oeMaterialesNegociados.Vigente = 1
            oeMaterialesNegociados.FechaCreacion = Date.Now
            oeMaterialesNegociados.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMaterialesNegociados.Guardar(oeMaterialesNegociados) Then
                mensajeEmergente.Confirmacion("La Información ha sido Guardada con Exito")
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarPrecios(ByVal lista As List(Of e_MaterialesNegociadosDet)) As Boolean
        For Each material As e_MaterialesNegociadosDet In lista
            If material.Precio > 0 Then
                Return True
            End If
        Next
    End Function

    Private Sub AgregarDetalle()
        Try
            Select Case ficMatCot.SelectedTab.Index
                Case 0
                    If Not olTraSeg.Permisos(gUsuarioSGI.IdTrabajador, "CAMBIAR PRECIO NEGOCIADO") Then Throw New Exception("Ud. no tiene permiso para agregar precio.")

                    gbeMateriales.Expanded = False
                    If loMatNegVig.Count > 0 Then
                        oeMaterial = New e_Material
                        oeMaterial.TipoOperacion = "G"
                        oeMaterial.Id = cboMateriales.Value
                        If oeMaterial.Id = Nothing Or oeMaterial.Id.Trim = "" Then Throw New Exception("Seleccione Material")
                        oeMaterial = olMaterial.Obtener(oeMaterial)
                        For Each matnegdet As e_MaterialesNegociadosDet In loMatNegVig
                            If oeMaterial.Id = matnegdet.IdMaterial Then
                                Throw New Exception("Material: " & oeMaterial.Nombre & " ya asignado al Contrato.")
                            End If
                        Next
                    End If
                    If numPrecio.Value = 0 Then Throw New Exception("El Precio no Puede ser 0")
                    Dim FechaActual As Date = ObtenerFechaServidor()
                    oeMatNegociadosDet = New e_MaterialesNegociadosDet
                    With oeMatNegociadosDet
                        .Activo = True
                        .IdMaterial = oeMaterial.Id
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .FechaCreacion = FechaActual
                        .IdMoneda = cboMoneda.Value
                        .Precio = numPrecio.Value
                        .Material = oeMaterial.Nombre
                        .Codigo = oeMaterial.Codigo
                        .TipoOperacion = "I"
                        .Vigente = True
                        .FechaInicio = FechaActual
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                    End With
                    loMatNegVig.Add(oeMatNegociadosDet)
                    griMatNegDet.DataSource = loMatNegVig
                    griMatNegDet.DataBind()
                    llenaCombosGrillaMaterialRequerido(griMatNegDet)
                    numPrecio.Value = 0
                    cboMateriales.Focus()
                Case 1
                    gbeMateriales.Expanded = False
                    Dim flag As Boolean = False
                    For Each oeCot As e_CotizacionDetalleMat In loCotizacionDetalle
                        oeCot.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If oeCot.Seleccion Then
                            If loMatNegVig.Count > 0 Then
                                For Each matnegdet As e_MaterialesNegociadosDet In loMatNegVig
                                    If oeCot.IdMaterial = matnegdet.IdMaterial Then
                                        flag = True
                                        Exit For
                                    End If
                                Next
                            End If
                            If flag = False Then
                                oeMatNegociadosDet = New e_MaterialesNegociadosDet
                                With oeMatNegociadosDet
                                    .Activo = True
                                    .IdMaterial = oeCot.IdMaterial
                                    .UsuarioCreacion = gUsuarioSGI.Id
                                    .FechaCreacion = Date.Parse(Now)
                                    .IdMoneda = "1CH01"
                                    .Precio = 0
                                    .Material = oeCot.Material
                                    .Codigo = oeCot.CodigoMaterial
                                    .TipoOperacion = "I"
                                    .Vigente = True
                                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                                End With
                                loMatNegVig.Add(oeMatNegociadosDet)
                            End If
                        End If
                    Next
                    griMatNegDet.DataBind()
                    llenaCombosGrillaMaterialRequerido(griMatNegDet)
                    'loMaterial.RemoveAll(AddressOf EliminaMateriales)
                    'griListaMateriales.DataBind()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub llenaCombosGrillaMaterialRequerido(ByVal grilla As UltraGrid)
        Try
            For i As Integer = 0 To grilla.Rows.Count - 1
                CrearComboGridPorCelda("IdMoneda", "Nombre", i, grilla, olMoneda.ComboGrilla(loMoneda), True)
            Next
            grilla.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ClonarContrato()
        Dim oeMatNeg As New e_MaterialesNegociados
        Dim olMatNeg As New l_MaterialesNegociados
        Dim oeMatNegDet As New e_MaterialesNegociados
        Dim olMatNegDet As New l_MaterialesNegociadosDet
        Dim loMatNegDet As New List(Of e_MaterialesNegociadosDet)
        Try
            oeMaterialesNegociados.Id = griLista.ActiveRow.Cells("Id").Value
            oeMaterialesNegociados = olMaterialesNegociados.Obtener(oeMaterialesNegociados)
            With oeMatNegociadosDet
                .TipoOperacion = "1"
                .IdMaterialesNegociados = oeMaterialesNegociados.Id
                .FechaCreacion = Date.Parse("01/01/1901")
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            loMatNegociadosDet = olMatNegociadosDet.Listar(oeMatNegociadosDet)
            oeMaterialesNegociados.loMaterialesNegociadosDet = loMatNegociadosDet
            oeMatNeg = oeMaterialesNegociados
            oeMaterialesNegociados.TipoOperacion = "V"
            oeMaterialesNegociados.PrefijoID = gs_PrefijoIdSucursal '@0001
            olMaterialesNegociados.Guardar(oeMaterialesNegociados)
            oeMatNeg.Id = ""
            oeMatNeg.Vigente = 1
            oeMatNeg.TipoOperacion = "I"
            oeMatNeg.Fecha = Date.Now
            oeMatNeg.FechaCreacion = Date.Now
            oeMatNeg.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMatNeg.Guardar(oeMatNeg) Then
                mensajeEmergente.Confirmacion("Contrato Clonado Correctamente " & griLista.ActiveRow.Cells("Proveedor").Value.ToString)
                Listar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ImportarArchivoExcel()
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If loMatNegociadosDet.Count > 0 Then
                If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    PathFilePTRA = OpenFileDialog1.FileName
                    Dim objXls As Excel.Application
                    Dim objWorkbook As Excel.Workbook
                    Dim objWorkSheet As Excel.Worksheet
                    Dim ObjExcel() As Object = Nothing
                    Dim men As String = ""
                    'objXls = New Excel.Application
                    objXls = CreateObject("Excel.Application")
                    objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                    objXls.Visible = False
                    objWorkSheet = objXls.Worksheets(1)
                    For ln_Fila As Integer = 1 To 100000
                        If Not objWorkSheet.Cells(ln_Fila + 16, 1).Value Is Nothing Then
                            For Each detalle As e_MaterialesNegociadosDet In loMatNegociadosDet
                                Dim idmaterial As String = objWorkSheet.Cells(ln_Fila + 16, 17).Value.ToString.Trim
                                Dim precio As Double = CDbl(objWorkSheet.Cells(ln_Fila + 16, 18).Value)
                                If detalle.IdMaterial = idmaterial Then
                                    detalle.Precio = Math.Round(Convert.ToDouble(objWorkSheet.Cells(ln_Fila + 16, 18).Value), 4) / Math.Round(Convert.ToDouble(objWorkSheet.Cells(ln_Fila + 16, 4).Value), 4)
                                    'detalle.IndicadorIgv = True
                                    'detalle.PrecioUnitarioConImp = Math.Round(Convert.ToDouble(objWorkSheet.Cells(ln_Fila + 16, 16).Value), 4)
                                    'detalle.PrecioUnitarioSinImp = Math.Round(detalle.PrecioUnitarioConImp / (oeIGV.Porcentaje + 1), 4)
                                    'If cambioMon = 0.0 Then cambioMon = 1
                                    'If cboMoneda.Text = "DOLARES" Then
                                    '    detalle.PrecioUnitarioDolaresSinImp = detalle.PrecioUnitarioSinImp
                                    '    detalle.PrecioUnitarioSolesSinImp = detalle.PrecioUnitarioSinImp * cambioMon
                                    'Else
                                    '    detalle.PrecioUnitarioSolesSinImp = detalle.PrecioUnitarioSinImp
                                    '    detalle.PrecioUnitarioDolaresSinImp = detalle.PrecioUnitarioSinImp / cambioMon
                                    'End If
                                End If
                            Next
                        Else
                            Exit For
                        End If
                    Next
                    griMatNegDet.DataBind()
                    If Not objXls Is Nothing Then
                        objWorkbook.Close()
                        objXls.Quit()
                    End If
                    OpenFileDialog1.Dispose()
                    ObjExcel = Nothing
                    objWorkSheet = Nothing
                    objWorkbook = Nothing
                    objXls = Nothing
                Else
                    OpenFileDialog1.Dispose()
                End If
            Else
                Throw New Exception("Agregue materiales al detalle para importar precios según cotizaciones.")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarCotizaciones()
        Try
            oeCotizacionDetalle = New e_CotizacionDetalleMat
            oeCotizacionDetalle.FechaInicio = rfFechaCotDesde.Value
            oeCotizacionDetalle.FechaFinal = rfFechaCotHasta.Value
            oeCotizacionDetalle.TipoOperacion = "A"
            ValidarFechaDesde_Hasta(rfFechaCotDesde, rfFechaCotHasta)
            oeCotizacionDetalle.PrefijoID = gs_PrefijoIdSucursal '@0001
            loCotizacionDetalle = olCotizacionDetalle.Listar(oeCotizacionDetalle)
            '------Quitamos los registros de lista de materiales si es que estos ya estan en la lista requerimientos.------
            'If loMatNegociadosDet.Count > 0 Then
            '    loCotizacionDetalle.RemoveAll(AddressOf eliminaCotDet)
            '    griListadoCotizacionDetalle.DataBind()
            'End If
            '--------------------------------------------------------------------------------------------------------------                 
            griListadoCotizacionDetalle.DataSource = loCotizacionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarDetalle()
        Try
            oeMatNegociadosDet = New e_MaterialesNegociadosDet
            oeMatNegociadosDet = griMatNegDet.ActiveRow.ListObject
            oeMatNegociadosDet.PrefijoID = gs_PrefijoIdSucursal '@0001
            If oeMatNegociadosDet.TipoOperacion = "I" Then
                loMatNegVig.Remove(oeMatNegociadosDet)
            End If
            griMatNegDet.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub btnBuscarCot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCot.Click
        Try
            ListarCotizaciones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedorL_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedorL.ValueChanged
        Try
            If Operacion = "Nuevo" Then
                If cboProveedorL.Value Is Nothing Then Exit Sub
                If cboProveedorL.Value.ToString.Length = 12 Then
                    oeMaterialesNegociados = New e_MaterialesNegociados
                    oeMaterialesNegociados.IdProveedor = cboProveedorL.Value
                    oeMaterialesNegociados.TipoOperacion = "1"
                    oeMaterialesNegociados = olMaterialesNegociados.Obtener(oeMaterialesNegociados)
                    oeMaterialesNegociados.PrefijoID = gs_PrefijoIdSucursal '@0001
                    ListarDetalle()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    AgregarDetalle()
                Case "Eliminar"
                    QuitarDetalle()
                Case "ButtonTool1"
                    ImportarArchivoExcel()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_MaterialesNegociados_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            If ficMaterialesNegociables.SelectedTab.Index = 0 Then
                ControlBotones()
            Else
                If Operacion = "NOEDIT" Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
                Else
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_MaterialesNegociados_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_MaterialesNegociados_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_MaterialesNegociados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            InicializarLogicas()
            gmt_ConfigurarEventoKeyEnter_Tab(Me, btnBuscarCot.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            LlenaComboMaterial()
            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            loMoneda = olMoneda.Listar(oeMoneda)
            LlenarCombo(cboMoneda, "Nombre", loMoneda, 1)
            rangoFechaDesde.Value = Date.Now.AddDays(-15)
            rfFechaCotDesde.Value = Date.Now.AddDays(-30)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtDescripcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.ValueChanged
        Try
            oeMaterialesNegociados.Glosa = txtDescripcion.Text
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griMatNegDet_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMatNegDet.CellChange
        Try
            griMatNegDet.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        Try
            If griLista.ActiveRow.Band.Index = 0 And griLista.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griMatNegDet_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griMatNegDet.BeforeCellUpdate
        With griMatNegDet
            Select Case e.Cell.Column.Key
                Case "Precio"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
                Case "Glosa"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
            End Select
        End With
    End Sub

    Private Sub griListadoCotizacionDetalle_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListadoCotizacionDetalle.CellChange
        Try
            griListadoCotizacionDetalle.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListadoCotizacionDetalle_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs)
        With griListadoCotizacionDetalle
            Select Case e.Cell.Column.Key
                Case "Cantidad", "Precio"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
            End Select
        End With
    End Sub

    Private Sub griListadoCotizacionDetalle_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListadoCotizacionDetalle.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListadoCotizacionDetalle.Rows(e.Cell.Row.Index)
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = VerdeClaro
                            .Appearance.ForeColor = Rojo
                            '.Fixed = True
                        Else
                            .Appearance.BackColor = Blanco
                            .Appearance.ForeColor = Negro
                            '.Fixed = False
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region
    
#Region "Combo Proveedor"

    Private Sub cboProveedorL_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedorL.InitializeLayout
        Me.cboProveedorL.ValueMember = "Id"
        Me.cboProveedorL.DisplayMember = "Nombre"
        With cboProveedorL.DisplayLayout.Bands(0)
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

    Private Sub cboProveedorL_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedorL.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ListarProveedores(cboProveedorL, "0", chkRuc2.Checked)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedorL_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProveedorL.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboProveedorL.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

#End Region

#Region "Combo Material"

    Private Sub InicializarComboMaterial()
        Try
            Me.cboMateriales.ValueMember = "Id"
            Me.cboMateriales.DisplayMember = "Nombre"
            For Each Col In cboMateriales.DisplayLayout.Bands(0).Columns
                Col.Hidden = "True"
            Next
            cboMateriales.DropDownStyle = UltraComboStyle.DropDown
            cboMateriales.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
            cboMateriales.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
            cboMateriales.DisplayLayout.Bands(0).ColHeadersVisible = False
            cboMateriales.DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
            cboMateriales.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaComboMaterial()
        Try
            oeMaterial = New e_Material
            loMaterial = New List(Of e_Material)
            oeMaterial.Activo = True
            oeMaterial.TipoOperacion = "G"
            loMaterial = olMaterial.Listar(oeMaterial)
            With cboMateriales
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = loMaterial
            End With
            InicializarComboMaterial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenu.Opening
        Try
            ContextMenu.Items("ToolStripMenuNuevo").Visible = 1
            ContextMenu.Items("ToolStripMenuEditar").Visible = 0
            ContextMenu.Items("ToolStripMenuEliminar").Visible = 0
            ContextMenu.Items("ToolStripMenuVigencia").Visible = 0
            ContextMenu.Items(4).Visible = 0
            If griLista.Rows.Count > 0 Then
                ContextMenu.Items("ToolStripMenuEditar").Visible = 1
                ContextMenu.Items("ToolStripMenuEliminar").Visible = 1
                If griLista.ActiveRow.Band.Index = 0 Then
                    If griLista.ActiveRow.Cells("Vigente").Value = True Then
                        ContextMenu.Items("ToolStripMenuVigencia").Visible = 1
                        ContextMenu.Items(4).Visible = 1
                    End If
                Else
                    ContextMenu.Items("ToolStripMenuEditar").Visible = 0
                    ContextMenu.Items("ToolStripMenuEliminar").Visible = 0
                    ContextMenu.Items("ToolStripMenuVigencia").Visible = 0
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuNuevo.Click
        Try
            Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuEditar.Click
        Try
            Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuEliminar.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuVigencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuVigencia.Click
        Try
            CambiarVigencia()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripClonarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripClonarContrato.Click
        Try
            ClonarContrato()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griMatNegDet_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griMatNegDet.AfterCellUpdate
        Try
            If griMatNegDet.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "Vigente"
                        With griMatNegDet.Rows(e.Cell.Row.Index)
                            If .Cells("Id").Value.ToString.Length > 0 Then
                                If .Cells("Vigente").Value Then
                                    .Cells("FechaFin").Value = Date.Parse("01/01/1901")
                                Else
                                    .Cells("FechaFin").Value = ObtenerFechaServidor()
                                End If
                            Else
                                If Not .Cells("Vigente").Value Then
                                    .Cells("Vigente").Value = True
                                End If
                            End If                     
                        End With
                    Case "Precio"
                        With griMatNegDet.Rows(e.Cell.Row.Index)
                            If .Cells("Id").Value.ToString.Length > 0 Then
                                .Cells("Vigente").Value = False
                            End If
                        End With
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gbeMateriales_ExpandedStateChanging(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles gbeMateriales.ExpandedStateChanging
        Try
            If gbeMateriales.Expanded Then
                cboMateriales.Focus()
                cboMateriales.SelectAll()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMateriales_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboMateriales.InitializeLayout
        Try
            InicializarComboMaterial()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMateriales_Enter(sender As Object, e As EventArgs) Handles cboMateriales.Enter
        cboMateriales.SelectAll()
    End Sub

#End Region

End Class