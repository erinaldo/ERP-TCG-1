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
Imports System.Threading
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Public Class frm_Liquidaciones

    Inherits frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Liquidaciones = Nothing
    Private Shared Operacion As String
    Private Estado As String
    ''' <summary>
    ''' Instancia unica de Formulario: frm_InformeGRT
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    '''
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Liquidaciones()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    Dim ListaCentro As New List(Of e_Centro)

    Dim oeGuiaTransportista As New e_GuiaTransportista
    Dim olGuiaTransportista As New l_GuiaTransportista

    Dim GuiaTransportistaLista As New List(Of e_GuiaTransportista)

    Dim oeGuiaRemitente As New e_GuiaRemitente
    Dim olGuiaRemitente As New l_GuiaRemitente

    Dim oeLiquidacion As New e_Liquidaciones
    Dim olLiquidacion As New l_Liquidacion
    Dim ListaLiquidacion As New List(Of e_Liquidaciones)
    Dim oeLiquidacionDetalle As New e_LiquidacionDetalle
    Dim ListaViaje As New List(Of e_LiquidacionDetalle)
    Dim ListaLiquidacionDetalle As New List(Of e_LiquidacionDetalle)
    Dim ListaViajeSinLiquidar As New List(Of e_LiquidacionDetalle)
    Dim olOperacion As New l_Operacion
    Dim oeOperacion As New e_Operacion
    Dim oeViaje As New e_Viaje

    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo
    Dim ListaTracto As New List(Of e_Vehiculo)

    Dim oeFlete As New e_Flete
    Dim olFlete As New l_Flete

    Dim oeFechas As New e_Fechas
    Dim _ingresando_datos As Boolean = False
    Dim Opcion As Boolean

    Dim olCombo As New l_Combo
    Dim oeTipoIV As New e_Combo
    Dim oeClaseServicio As New e_Combo
    Dim oeSubClaseServicio As New e_Combo
    Dim oeOrigenTottus As New e_Combo
    Dim oeOrigenSPSA As New e_Combo
    Dim ListaTipoIV As New List(Of e_Combo)
    Dim ListaClaseServicio As New List(Of e_Combo)
    Dim ListaSubClaseServicio As New List(Of e_Combo)
    Dim ListaOrigenTottus As New List(Of e_Combo)
    Dim ListaOrigenSPSA As New List(Of e_Combo)
    Dim FleteUnitario As Decimal = 0
    Dim IndIdFlete As String = ""

    Dim gIgv As Double = ObtenerIGV()

#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Operacion = "Inicializa"
        If Activo Then
            Estado = " Activo"
        Else
            Estado = " Inactivo"
        End If
        Try
            If ValidarFechaInicioFin(fecDesde, fecHasta) Then
                Listar()
            End If
            ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Nuevo"
            Inicializar()
            cboClienteLiquidacion.Text = "SUPERMERCADOS PERUANOS S.A."
            MostrarTabs(1, ficLiquidacion, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            tabDetalleLiquidacion.Tabs(0).Selected = True
            LimpiaGrid(griViajesSinLiquidar, ogdLiquidacionDetalle)
            LimpiaGrid(griViajesLiquidacionDetalle, ogdLiquidacionDetalle)
            LimpiaGrid(griViajesSinLiquidarSPSA, ogdLiquidacionDetalleSPSA)
            LimpiaGrid(griViajesLiquidacionDetalleSPSA, ogdLiquidacionDetalleSPSA)
            LimpiaGrid(griViajesSinLiquidarTOTTUS, ogdLiquidacionDetalleTOTTUS)
            LimpiaGrid(griViajesLiquidacionDetalleTOTTUS, ogdLiquidacionDetalleTOTTUS)
            LimpiaGrid(griViajesSinLiquidarMAESTRO, ogdLiquidacionDetalleMAESTRO)
            LimpiaGrid(griViajesLiquidacionDetalleMAESTRO, ogdLiquidacionDetalleMAESTRO)
            fecDesdeViaje.Value = Date.Today.AddDays(-5)
            fecHastaViaje.Value = Date.Today.AddDays(+1)
            opcFormatoLiquidacion_ValueChanged(Nothing, Nothing)
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'Inicializar()
            If griLiquidacion.ActiveRow.Cells("Id").Value.ToString.Length Then
                Operacion = "Editar"
                LimpiaGrid(griViajesSinLiquidar, ogdLiquidacionDetalle)
                LimpiaGrid(griViajesLiquidacionDetalle, ogdLiquidacionDetalle)
                LimpiaGrid(griViajesSinLiquidarSPSA, ogdLiquidacionDetalleSPSA)
                LimpiaGrid(griViajesLiquidacionDetalleSPSA, ogdLiquidacionDetalleSPSA)
                LimpiaGrid(griViajesSinLiquidarTOTTUS, ogdLiquidacionDetalleTOTTUS)
                LimpiaGrid(griViajesLiquidacionDetalleTOTTUS, ogdLiquidacionDetalleTOTTUS)
                LimpiaGrid(griViajesSinLiquidarMAESTRO, ogdLiquidacionDetalleMAESTRO)
                LimpiaGrid(griViajesLiquidacionDetalleMAESTRO, ogdLiquidacionDetalleMAESTRO)
                If EditarLiquidacion() Then
                    Select Case opcFormatoLiquidacion.CheckedIndex
                        Case 0
                            tabDetalleLiquidacion.Tabs(1).Selected = True
                        Case 1
                            tabDetalleLiquidacion.Tabs(3).Selected = True
                        Case 2
                            tabDetalleLiquidacion.Tabs(3).Selected = True
                        Case 3
                            tabDetalleLiquidacion.Tabs(3).Selected = True
                        Case 4
                            tabDetalleLiquidacion.Tabs(5).Selected = True
                        Case 5
                            tabDetalleLiquidacion.Tabs(7).Selected = True
                        Case 6
                            tabDetalleLiquidacion.Tabs(5).Selected = True
                        Case 7
                            tabDetalleLiquidacion.Tabs(5).Selected = True
                        Case 8
                            tabDetalleLiquidacion.Tabs(3).Selected = True

                    End Select
                Else
                    Operacion = "Inicializa"
                End If
                fecDesdeViaje.Value = Date.Today.AddDays(-5)
                fecHastaViaje.Value = Date.Today.AddDays(+1)
            End If
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarLiquidacion() Then
                MostrarTabs(0, ficLiquidacion, 2)
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            Else
                MostrarTabs(1, ficLiquidacion, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarLiquidacion() Then
                        MostrarTabs(0, ficLiquidacion, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                    Else
                        _ingresando_datos = True
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficLiquidacion, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                    MyBase.Consultar(True)
                Case Windows.Forms.DialogResult.Cancel
                    _ingresando_datos = True
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        griLiquidacion.ActiveRow.Delete()
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            MyBase.Imprimir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            MyBase.Salir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If tabListaLiquidaciones.Tabs(0).Selected Then
                If griListaViajesAntiguos.Rows.Count > 0 Then Exportar_Excel(griListaViajesAntiguos)
            Else
                If tabListaLiquidaciones.Tabs(1).Selected Then
                    If griLista.Rows.Count > 0 Then Exportar_Excel(griLista)
                Else
                    If griLiquidacion.Rows.Count > 0 Then Exportar_Excel(griLiquidacion)
                End If
            End If
            MyBase.Exportar()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Eventos"
    Private Sub Inicializar()
        txtIdLiquidacion.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtObservacion.Text = String.Empty
        fecLiquidacion.Value = ObtenerFechaServidor.Date
        txtSubTotal.Value = 0
        txtIgv.Value = 0
        txtTotal.Value = 0
    End Sub

    Private Sub frm_Liquidaciones_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_Liquidaciones_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                MostrarTabs(0, ficLiquidacion)
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
                cboCliente.Text = "SUPERMERCADOS PERUANOS S.A."
        End Select
    End Sub

    Private Sub frm_LiquidacionesT_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

#End Region

#Region "Métodos"

    'Private Sub CargarCombos()
    '    Try
    '        'Cargar Tracto para Lista
    '        Dim loVeh As New List(Of e_Vehiculo)
    '        oeVehiculo = New e_Vehiculo
    '        oeVehiculo.Id = ""
    '        oeVehiculo.Placa = "TODOS"
    '        loVeh.Add(oeVehiculo)
    '        oeVehiculo = New e_Vehiculo
    '        oeVehiculo.TipoOperacion = "A"
    '        oeVehiculo.Motriz = 1
    '        oeVehiculo.Activo = 1
    '        loVeh.AddRange(olVehiculo.Listar(oeVehiculo).OrderBy(Function(item) item.Placa).ToList)
    '        LlenarCombo(cboTracto, "Placa", loVeh, 0)
    '        LlenarCombo(cboTracto3, "Placa", loVeh, 0)

    '        'Cargar Moneda
    '        oeMoneda = New e_Moneda
    '        leMoneda = olMoneda.Listar(oeMoneda)
    '        LlenarCombo(cboMoneda, "Abreviatura", leMoneda, 0)

    '        'Cargar Cliente
    '        leCliente = New List(Of e_Cliente)
    '        oeCliente = New e_Cliente
    '        oeCliente.TipoClienteProveedor = 1
    '        leCliente = olCliente.Listar(oeCliente)
    '        'LlenarCombo(cboCliente, "Nombre", leCliente, -1)
    '        cboOtroCliente.Text = String.Empty
    '        cboOtroCliente.DataSource = New List(Of e_Cliente)
    '        cboOtroCliente.DataSource = leCliente
    '        cboOtroCliente.PerformAction(UltraComboAction.Dropdown)

    '        'Cargar Tipo de Pago
    '        oeTipoPago = New e_TipoPago
    '        oeTipoPago.Activo = True
    '        leTipoPago = olTipoPago.Listar(oeTipoPago)

    '        'Cargar Tipo Documento
    '        oeTipoDoc = New e_TipoDocumento
    '        Dim olTipoDoc As New l_TipoDocumento
    '        Dim leTipoDocB As New List(Of e_TipoDocumento)
    '        oeTipoDoc.TipoOperacion = "F"
    '        leTipoDoc = olTipoDoc.Listar(oeTipoDoc)
    '        oeTipoDoc = New e_TipoDocumento
    '        oeTipoDoc.Id = "FACBO"
    '        oeTipoDoc.Nombre = "TODOS"
    '        leTipoDocB.Add(oeTipoDoc)
    '        leTipoDocB.AddRange(leTipoDoc)
    '        LlenarCombo(cboTipoDocumento, "Nombre", leTipoDoc, 0)
    '        LlenarCombo(cboTipoDocB, "Nombre", leTipoDocB, 0)

    '        'Cargar Estado Factura
    '        oeEstado = New e_Estado
    '        oeEstado.Nombre = "FACTURAR"
    '        leEstado = olEstado.Listar(oeEstado)
    '        LlenarCombo(cboEstado, "Nombre", leEstado, -1)

    '        'Cargar Tipo Carga
    '        oeTipoCarga = New e_TipoCarga
    '        oeTipoCarga.Activo = True
    '        leTipoCarga = olTipoCarga.Listar(oeTipoCarga)

    '        'Cargar Material
    '        oeMaterial = New e_Material
    '        oeMaterial.TipoOperacion = "O"
    '        oeMaterial.Activo = True
    '        leMaterial = olMaterial.Listar(oeMaterial)

    '        'Cargar Lugar
    '        oeLugar = New e_Lugar
    '        oeLugar.Activo = True
    '        leLugar = olLugar.Listar(oeLugar)

    '        'Cargar Estado de Carga
    '        cboFactura.Items.Clear()
    '        cboFactura.Items.Add("TODOS")
    '        cboFactura.Items.Add("POR FACTURAR")
    '        cboFactura.Items.Add("FACTURADOS")
    '        cboFactura.SelectedIndex = 1

    '        'Cargar Estado de Documentos
    '        cboRecuperado.Items.Clear()
    '        cboRecuperado.Items.Add("TODOS")
    '        cboRecuperado.Items.Add("SIN DOCUMENTOS")
    '        cboRecuperado.Items.Add("CON DOCUMENTOS")
    '        cboRecuperado.Items.Add("DOC. PERDIDOS")
    '        cboRecuperado.SelectedIndex = 0

    '        'Cargar Centro
    '        oeCentro.Abreviatura = ""
    '        oeCentro.Nombre = "TODOS"
    '        ListaCentro.Add(oeCentro)
    '        oeCentro = New e_Centro
    '        oeCentro.TipoOperacion = "O"
    '        ListaCentro.AddRange(olCentro.Listar(oeCentro))
    '        LlenarCombo(cboCentro, "Nombre", ListaCentro, 0)
    '        'cboCentro.Value = Prefijo.PrefijoID

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If tabListaLiquidaciones.Tabs(0).Selected Or tabListaLiquidaciones.Tabs(1).Selected Then
                'Select Case ficDemanda.SelectedTab.Index
                '    Case 0
                '        oeViaje = New e_Viaje
                '        ValidarFechaDesde_Hasta(fecDesde, fecHasta)
                '        oeViaje.FechaDesde = fecDesde.Value
                '        oeViaje.FechaHasta = fecHasta.Value
                '        oeViaje.TipoOperacion = "7"
                '        oeViaje.IdEstado = cboTracto.Value
                '        oeViaje.Centro = cboCentro.Value
                '        Select Case cboFactura.SelectedIndex
                '            Case 0 : oeViaje.IndMotriz = -1
                '            Case 1 : oeViaje.IndMotriz = 0
                '            Case 2 : oeViaje.IndMotriz = 1
                '        End Select
                '        If txtNroGuiaT.Text.Trim <> "" Then oeViaje.Zona = "%" & txtNroGuiaT.Text.Trim & "%"
                '        oeViaje.Activo = True
                '        Select Case cboRecuperado.Text
                '            Case "TODOS" : oeViaje.Serie = ""
                '            Case "SIN DOCUMENTOS" : oeViaje.Serie = 3
                '            Case "CON DOCUMENTOS" : oeViaje.Serie = 1
                '            Case "DOC. PERDIDOS" : oeViaje.Serie = 2
                '        End Select
                '        If BandSave Then
                '            If griFactura.Rows.Count > 0 Then
                '                griFactura.DataBind()
                '                leSelec = leCargas.Where(Function(item) item.Seleccion = True).ToList
                '            End If
                '        End If
                '        griLista.DataSource = olOperacion.ListarViaje(oeViaje)
                'End Select
                oeViaje = New e_Viaje
                oeViaje.Id = cboCliente.Value
                oeViaje.FechaDesde = fecDesde.Value
                oeViaje.FechaHasta = fecHasta.Value
                Dim dsOperacion As DataSet = olOperacion.ListarDataSet(oeViaje)
                Dim parentCol As DataColumn = dsOperacion.Tables(0).Columns("IdOperacion")
                Dim childCol_1 As DataColumn = dsOperacion.Tables(1).Columns("IdOperacion")
                'Dim childCol_11 As DataColumn = dsOperacion.Tables(1).Columns("IdViaje")
                'Dim childCol_2 As DataColumn = dsOperacion.Tables(2).Columns("IdViaje")
                'Dim childCol_3 As DataColumn = dsOperacion.Tables(2).Columns("IdGuiaTransportista")
                'Dim childCol_4 As DataColumn = dsOperacion.Tables(3).Columns("IdGuiaTransportista")
                Dim relation_1 As DataRelation = New DataRelation("FK_Ruta_1", parentCol, childCol_1, False)
                'Dim relation_2 As DataRelation = New DataRelation("FK_Ruta_2", childCol_11, childCol_2, False)
                'Dim relation_3 As DataRelation = New DataRelation("FK_Ruta_3", childCol_3, childCol_4, False)
                dsOperacion.Relations.Add(relation_1)
                'dsOperacion.Relations.Add(relation_2)
                'dsOperacion.Relations.Add(relation_3)
                dsOperacion.AcceptChanges()
                griLista.DataSource = dsOperacion
                With griLista.DisplayLayout.Bands(1)
                    .Columns("IdOperacion").Hidden = True
                    .Columns("Viaje").Width = 100
                    .Columns("Fecha").Width = 100
                    .Columns("Fecha").Style = ColumnStyle.DateTime
                    .Columns("CentroOrigen").Width = 50
                    .Columns("Origen").Width = 150
                    .Columns("CentroDestino").Width = 50
                    .Columns("Destino").Width = 150
                    .Columns("Escala").Width = 100
                    .Columns("Piloto").Width = 200
                    .Columns("Tracto").Width = 70
                    .Columns("Carreta").Width = 70
                    .Columns("PesoToneladas").Width = 40
                    .Columns("PesoToneladas").CellAppearance.TextHAlign = HAlign.Right
                    .Columns("PesoToneladas").CellAppearance.BackColor = Color.Khaki
                    .Columns("PesoToneladas").MaskInput = "{LOC}nn.nn"
                    .Columns("PesoToneladas").Header.Caption = "TN"
                    .Columns("Cantidad").Width = 40
                    .Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
                    .Columns("Cantidad").CellAppearance.BackColor = Color.Khaki
                    .Columns("Cantidad").MaskInput = "{LOC}nn.nn"
                    .Columns("FleteUnitario").Width = 50
                    .Columns("FleteUnitario").CellAppearance.BackColor = Color.Plum
                    .Columns("FleteUnitario").CellAppearance.TextHAlign = HAlign.Right
                    .Columns("FleteUnitario").Format = "#,###,###,##0.00"
                    .Columns("TotalFlete").Width = 70
                    .Columns("TotalFlete").CellAppearance.BackColor = Color.Plum
                    .Columns("TotalFlete").CellAppearance.TextHAlign = HAlign.Right
                    .Columns("TotalFlete").Format = "#,###,###,##0.00"
                    .Columns("PorcentajeFlete").Width = 40
                    .Columns("PorcentajeFlete").CellAppearance.TextHAlign = HAlign.Right
                    .Columns("PorcentajeFlete").CellAppearance.BackColor = Color.Khaki
                    .Columns("PorcentajeFlete").MaskInput = "{LOC}nnn.nn"
                    .Columns("PorcentajeFlete").Header.Caption = "%"
                    .Columns("Glosa").Width = 200
                    .Columns("Incidencia").Width = 150
                    .Columns("Ruta").Width = 40
                    .Override.FilterUIType = FilterUIType.HeaderIcons
                    .Override.AllowRowFiltering = DefaultableBoolean.False
                    .Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.None
                    .Override.CellPadding = 1
                End With
                'With griLista.DisplayLayout.Bands(2)
                '    .Override.FilterUIType = FilterUIType.HeaderIcons
                '    .Override.AllowRowFiltering = DefaultableBoolean.False
                '    '.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.None
                '    .Override.CellPadding = 1
                'End With
                'With griLista.DisplayLayout.Bands(3)
                '    .Override.FilterUIType = FilterUIType.HeaderIcons
                '    .Override.AllowRowFiltering = DefaultableBoolean.False
                '    '.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.None
                '    .Override.CellPadding = 1
                'End With
                griListaViajesAntiguos.DataSource = olOperacion.ListarDataSetViajesAntiguos(oeViaje)
            Else
                If tabListaLiquidaciones.Tabs(2).Selected Then
                    oeLiquidacion = New e_Liquidaciones
                    oeLiquidacion.IdCliente = cboCliente.Value
                    oeLiquidacion.FechaDesde = fecDesde.Value
                    oeLiquidacion.FechaHasta = fecHasta.Value
                    griLiquidacion.DataSource = olLiquidacion.Listar(oeLiquidacion)
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLiquidacion.Rows
                        Select Case fila.Cells("IndFormato").Value
                            Case 0
                                fila.CellAppearance.BackColor = Me.ColorFormato0.Color
                            Case 1
                                fila.CellAppearance.BackColor = Me.ColorFormato1.Color
                            Case 2
                                fila.CellAppearance.BackColor = Me.ColorFormato2.Color
                            Case 3
                                fila.CellAppearance.BackColor = Me.ColorFormato3.Color
                            Case 4
                                fila.CellAppearance.BackColor = Me.ColorFormato4.Color
                            Case 5
                                fila.CellAppearance.BackColor = Me.ColorFormato5.Color
                            Case 6
                                fila.CellAppearance.BackColor = Me.ColorFormato6.Color
                            Case 7
                                fila.CellAppearance.BackColor = Me.ColorFormato7.Color
                        End Select
                    Next
                    'Ubica el cursor el el primer registro de la grilla
                    If griLiquidacion.Rows.Count > 0 Then
                        griLiquidacion.Focus()
                        griLiquidacion.Rows.Item(0).Activated = True
                    End If
                    CalcularTotales(griLiquidacion, "SubTotal", "Igv", "Total")
                Else
                    oeViaje = New e_Viaje
                    oeViaje.TipoOperacion = ""
                    oeViaje.FechaDesde = fecDesde.Value
                    oeViaje.FechaHasta = fecHasta.Value
                    griControlViajesSPSA.DataSource = olOperacion.ListarViajeLurin(oeViaje)
                    CalcularTotales(griControlViajesSPSA, "Viajes", "Monto")

                    oeViaje.TipoOperacion = "T"
                    griTarifasSPSA.DataSource = olOperacion.ListarViajeLurin(oeViaje)

                    oeViaje.TipoOperacion = "V"
                    griViajesSPSA.DataSource = olOperacion.ListarViajeLurin(oeViaje)
                    CalcularTotales(griViajesSPSA, "Viajes")

                    CalcularPromedioMonto()

                End If

            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Function CalcularPromedioMonto() As Boolean
        Dim VLunes, VMartes, VMiercoles, VJueves, VViernes, VSabado, VDomingo As Double
        Dim CLunes, CMartes, CMiercoles, CJueves, CViernes, CSabado, CDomingo As Double
        Dim PLunes, PMartes, PMiercoles, PJueves, PViernes, PSabado, PDomingo As Double
        Dim MLunes, MMartes, MMiercoles, MJueves, MViernes, MSabado, MDomingo As Double
        MLunes = 0
        For Each ControlViaje As Infragistics.Win.UltraWinGrid.UltraGridRow In griControlViajesSPSA.Rows
            Select Case ControlViaje.Cells("DiaSemana").Value
                Case "Lunes"
                    VLunes = ControlViaje.Cells("Viajes").Value
                    CLunes = ControlViaje.Cells("Camiones").Value
                    PLunes = (VLunes / CLunes).ToString("#0.0")
                Case "Martes"
                    VMartes = ControlViaje.Cells("Viajes").Value
                    CMartes = ControlViaje.Cells("Camiones").Value
                    PMartes = (VMartes / CMartes).ToString("#0.0")
                    ControlViaje.Cells("Promedio").Value = PMartes
                    For Each TarifasSPSA As Infragistics.Win.UltraWinGrid.UltraGridRow In griTarifasSPSA.Rows
                        MMartes = CMartes * TarifasSPSA.Cells("Mes").Value
                        Select Case PMartes
                            Case TarifasSPSA.Cells("Año").Value To TarifasSPSA.Cells("Viajes").Value
                                ControlViaje.Cells("Monto").Value = CMartes * TarifasSPSA.Cells("Mes").Value
                                Exit For
                            Case Else
                                If MLunes = 0 Then
                                    MLunes = MMartes
                                    ControlViaje.Cells("Monto").Value = MMartes
                                End If

                        End Select
                        MLunes = 0
                    Next
                Case "Miercoles"
                    VMiercoles = ControlViaje.Cells("Viajes").Value
                    CMiercoles = ControlViaje.Cells("Camiones").Value
                    PMiercoles = (VMiercoles / CMiercoles).ToString("#0.0")
                    ControlViaje.Cells("Promedio").Value = PMiercoles
                    For Each TarifasSPSA As Infragistics.Win.UltraWinGrid.UltraGridRow In griTarifasSPSA.Rows
                        MMiercoles = CMiercoles * TarifasSPSA.Cells("Mes").Value
                        Select Case PMiercoles
                            Case TarifasSPSA.Cells("Año").Value To TarifasSPSA.Cells("Viajes").Value
                                ControlViaje.Cells("Monto").Value = CMiercoles * TarifasSPSA.Cells("Mes").Value
                                Exit For
                            Case Else
                                If MLunes = 0 Then
                                    MLunes = MMiercoles
                                    ControlViaje.Cells("Monto").Value = MMiercoles
                                End If

                        End Select
                        MLunes = 0
                    Next
                Case "Jueves"
                    VJueves = ControlViaje.Cells("Viajes").Value
                    CJueves = ControlViaje.Cells("Camiones").Value
                    PJueves = (VJueves / CJueves).ToString("#0.0")
                    ControlViaje.Cells("Promedio").Value = PJueves
                    For Each TarifasSPSA As Infragistics.Win.UltraWinGrid.UltraGridRow In griTarifasSPSA.Rows
                        MJueves = CJueves * TarifasSPSA.Cells("Mes").Value
                        Select Case PJueves
                            Case TarifasSPSA.Cells("Año").Value To TarifasSPSA.Cells("Viajes").Value
                                ControlViaje.Cells("Monto").Value = CJueves * TarifasSPSA.Cells("Mes").Value
                                Exit For
                            Case Else
                                If MLunes = 0 Then
                                    MLunes = MJueves
                                    ControlViaje.Cells("Monto").Value = MJueves
                                End If

                        End Select
                        MLunes = 0
                    Next
                Case "Viernes"
                    VViernes = ControlViaje.Cells("Viajes").Value
                    CViernes = ControlViaje.Cells("Camiones").Value
                    PViernes = (VViernes / CViernes).ToString("#0.0")
                    ControlViaje.Cells("Promedio").Value = PViernes
                    For Each TarifasSPSA As Infragistics.Win.UltraWinGrid.UltraGridRow In griTarifasSPSA.Rows
                        MViernes = CViernes * TarifasSPSA.Cells("Mes").Value
                        Select Case PViernes
                            Case TarifasSPSA.Cells("Año").Value To TarifasSPSA.Cells("Viajes").Value
                                ControlViaje.Cells("Monto").Value = CViernes * TarifasSPSA.Cells("Mes").Value
                                Exit For
                            Case Else
                                If MLunes = 0 Then
                                    MLunes = MViernes
                                    ControlViaje.Cells("Monto").Value = MViernes
                                End If

                        End Select
                        MLunes = 0
                    Next
                Case "Sabado"
                    VSabado = ControlViaje.Cells("Viajes").Value
                    CSabado = ControlViaje.Cells("Camiones").Value
                    PSabado = (VSabado / CSabado).ToString("#0.0")
                    ControlViaje.Cells("Promedio").Value = PSabado
                    For Each TarifasSPSA As Infragistics.Win.UltraWinGrid.UltraGridRow In griTarifasSPSA.Rows
                        MSabado = CSabado * TarifasSPSA.Cells("Mes").Value
                        Select Case PSabado
                            Case TarifasSPSA.Cells("Año").Value To TarifasSPSA.Cells("Viajes").Value
                                ControlViaje.Cells("Monto").Value = CSabado * TarifasSPSA.Cells("Mes").Value
                                Exit For
                            Case Else
                                If MLunes = 0 Then
                                    MLunes = MSabado
                                    ControlViaje.Cells("Monto").Value = MSabado
                                End If

                        End Select
                        MLunes = 0
                    Next
                Case "Domingo"
                    VDomingo = ControlViaje.Cells("Viajes").Value
                    CDomingo = ControlViaje.Cells("Camiones").Value
                    PDomingo = ((VLunes + VDomingo) / CLunes).ToString("#0.0")
                    ControlViaje.Cells("Promedio").Value = PDomingo
                    For Each TarifasSPSA As Infragistics.Win.UltraWinGrid.UltraGridRow In griTarifasSPSA.Rows
                        MDomingo = CLunes * TarifasSPSA.Cells("Mes").Value
                        Select Case PDomingo
                            Case TarifasSPSA.Cells("Año").Value To TarifasSPSA.Cells("Viajes").Value
                                ControlViaje.Cells("Monto").Value = CLunes * TarifasSPSA.Cells("Mes").Value
                                Exit For
                            Case Else
                                If MLunes = 0 Then
                                    MLunes = MDomingo
                                    ControlViaje.Cells("Monto").Value = MDomingo
                                End If

                        End Select
                        MLunes = 0
                    Next

            End Select
        Next
        Return True
    End Function

    Function ValidarGrtAnular(ByVal txt_controlInicial As UltraWinMaskedEdit.UltraMaskedEdit, ByVal txt_controlFinal As UltraWinMaskedEdit.UltraMaskedEdit) As Boolean
        Try
            Dim ls_NroDocInicial As String = "", _
                    ls_NroDocFinal As String = ""
            ls_NroDocInicial = txt_controlInicial.Text
            ls_NroDocFinal = txt_controlFinal.Text
            If CDbl(ls_NroDocInicial) > CDbl(ls_NroDocFinal) Then
                txt_controlFinal.Focus()
                Throw New Exception("Nº Documento Inicial debe ser Menor a Nº Documento Final")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ControlRangoFechaInicializa()
        fecDesde.Value = Date.Today.AddDays(-5)
        fecHasta.Value = Date.Today.AddDays(+1)
    End Sub

    Private Function GuardarLiquidacion() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ValidaCamposCabecera() Then
                oeLiquidacion = New e_Liquidaciones
                With oeLiquidacion
                    .TipoOperacion = "I"
                    .Id = txtIdLiquidacion.Text.Trim
                    .IdCliente = cboClienteLiquidacion.Value
                    .Fecha = fecLiquidacion.Value
                    .SubTotal = txtSubTotal.Text.Trim
                    .Igv = txtIgv.Text.Trim
                    .Total = txtTotal.Text.Trim
                    .Observacion = txtObservacion.Text.Trim
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .IndFormato = opcFormatoLiquidacion.CheckedIndex
                End With

                If Operacion = "Nuevo" Then
                    Select Case opcFormatoLiquidacion.CheckedIndex
                        Case 0
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidar.DataSource
                        Case 1
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarSPSA.DataSource
                        Case 2
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarSPSA.DataSource
                        Case 3
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarSPSA.DataSource
                        Case 4
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarTOTTUS.DataSource
                        Case 5
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarMAESTRO.DataSource
                        Case 6
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarTOTTUS.DataSource
                        Case 7
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarTOTTUS.DataSource
                        Case 8
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarSPSA.DataSource
                    End Select
                Else
                    Select Case opcFormatoLiquidacion.CheckedIndex
                        Case 0
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalle.DataSource
                        Case 1
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleSPSA.DataSource
                        Case 2
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleSPSA.DataSource
                        Case 3
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleSPSA.DataSource
                        Case 4
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleTOTTUS.DataSource
                        Case 5
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleMAESTRO.DataSource
                        Case 6
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleTOTTUS.DataSource
                        Case 7
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleTOTTUS.DataSource
                        Case 8
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleSPSA.DataSource
                    End Select
                End If

                If oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True).Count < 1 Then
                    Throw New Exception("No a seleccionado los viajes que entraran a la liquidacion")
                End If
                oeLiquidacion.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olLiquidacion.Guardar(oeLiquidacion) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    If MessageBox.Show("Desea Visualizar la Liquidacion en Excel:  ?", _
                                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                        Select Case opcFormatoLiquidacion.CheckedIndex
                            Case 0
                                GenerarExcelFlotaPequeña()
                            Case 1
                                GenerarExcelSPSA123(1, opcPlantilla.CheckedIndex)
                            Case 2
                                GenerarExcelSPSA123(2, opcPlantilla.CheckedIndex)
                            Case 3
                                GenerarExcelSPSA123(3, opcPlantilla.CheckedIndex)
                            Case 4
                                GenerarExcelTottus()
                            Case 5
                                GenerarExcelMaestro()
                            Case 6
                                GenerarExcelTottus()
                            Case 7
                                GenerarExcelTottus()
                            Case 8
                                GenerarExcelSPSA123(8, opcPlantilla.CheckedIndex)
                        End Select
                    End If
                End If
                MyBase.Consultar()
                ugb_Espera.Visible = False
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Function

    Private Function ValidaCamposCabecera() As Boolean
        Try
            ValidarCombo(cboClienteLiquidacion, "Cliente")
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Function

    Private Sub CalcularSubTotal()
        Try
            txtSubTotal.Text = 0.0
            Select Case opcFormatoLiquidacion.CheckedIndex
                Case 0
                    For Each LiquidacionDetalle As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                        txtSubTotal.Text += LiquidacionDetalle.FleteUnitario
                    Next
                Case 1
                    For Each LiquidacionDetalle As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                        txtSubTotal.Text += LiquidacionDetalle.FleteUnitario + LiquidacionDetalle.Consolidado
                    Next
                Case 2
                    For Each LiquidacionDetalle As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                        txtSubTotal.Text += LiquidacionDetalle.FleteUnitario + LiquidacionDetalle.Consolidado
                    Next
                Case 3
                    For Each LiquidacionDetalle As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                        txtSubTotal.Text += LiquidacionDetalle.FleteUnitario + LiquidacionDetalle.Consolidado
                    Next
                Case 4
                    For Each LiquidacionDetalle As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                        txtSubTotal.Text += LiquidacionDetalle.FleteUnitario
                    Next
                Case 5
                    For Each LiquidacionDetalle As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                        txtSubTotal.Text += LiquidacionDetalle.FleteUnitario
                    Next
                Case 6
                    For Each LiquidacionDetalle As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                        txtSubTotal.Text += LiquidacionDetalle.FleteUnitario
                    Next
                Case 7
                    For Each LiquidacionDetalle As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                        txtSubTotal.Text += LiquidacionDetalle.FleteUnitario
                    Next
                Case 8
                    For Each LiquidacionDetalle As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                        txtSubTotal.Text += LiquidacionDetalle.FleteUnitario + LiquidacionDetalle.Consolidado
                    Next
            End Select
            txtIgv.Text = txtSubTotal.Value * gIgv
            txtTotal.Text = txtSubTotal.Value + txtIgv.Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GenerarExcelFlotaPequeña()

        Dim objXls As Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objWorkSheet As Excel.Worksheet
        objXls = New Excel.Application
        Dim FileToCopy As String
        Dim PathFilePTRA As String
        Try
            If oeLiquidacion.ListaLiquidacionDetalle.Count > 0 Then
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\PlantillaSPSAFlotaPequeña.xlt" 'gs_RutaPlantillas & "Plantilla_Orden_Compra_SGI.xlt"
                PathFilePTRA = Application.StartupPath & "\PlantillaSPSAFlotaPequeña.xls"

                If System.IO.File.Exists(FileToCopy) Then
                    If System.IO.File.Exists(PathFilePTRA) Then
                        System.IO.File.SetAttributes(PathFilePTRA, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                    End If
                    System.IO.File.Copy(FileToCopy, PathFilePTRA, True)
                    System.IO.File.SetAttributes(PathFilePTRA, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                Else
                    Throw New Exception("No se encontró el archivo de Plantilla en el servidor, Consulte con Soporte")
                End If

                ' Creamos una variable para guardar la cultura actual
                Dim OldCultureInfo As System.Globalization.CultureInfo = _
                System.Threading.Thread.CurrentThread.CurrentCulture

                'Crear una cultura standard (en-US) inglés estados unidos
                System.Threading.Thread.CurrentThread.CurrentCulture = _
                New System.Globalization.CultureInfo("es-PE")

                'Abrimos la plantilla

                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objWorkSheet = objXls.Worksheets(1)

                objWorkSheet.Name = "Liquidacion"     'Asignamos el nombre al archivo en excel.

                Dim ln_Fila As Integer = 1
                For Each obj As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                    With objWorkSheet
                        .Cells(ln_Fila + 9, 1) = obj.Fecha.Date
                        .Cells(ln_Fila + 9, 2) = obj.CodigoOrigen
                        .Cells(ln_Fila + 9, 3) = obj.Origen
                        .Cells(ln_Fila + 9, 4) = obj.CodigoDestino
                        .Cells(ln_Fila + 9, 5) = obj.Destino
                        .Cells(ln_Fila + 9, 6) = obj.Tracto
                        .Cells(ln_Fila + 9, 7) = obj.Capacidad
                        .Cells(ln_Fila + 9, 8) = gs_TxtEmpresaSistema
                        .Cells(ln_Fila + 9, 9) = obj.FleteUnitario
                        .Cells(ln_Fila + 9, 10) = obj.Ruta
                        .Cells(ln_Fila + 9, 11) = obj.NroCarga
                        .Cells(ln_Fila + 9, 12) = obj.GuiaRemitente
                        .Cells(ln_Fila + 9, 13) = obj.GuiaTransportista
                        .Cells(ln_Fila + 9, 14) = obj.Observacion
                    End With
                    ln_Fila = ln_Fila + 1
                Next
                'Mostramos el documento en pantalla
                objXls.ActiveWindow.Zoom = 100
                objXls.ActiveWindow.DisplayGridlines = False
                objXls.Sheets.Item(1).Select()

                objXls.Visible = True 'Permite visualizar el excel.

                If Not (objWorkSheet Is Nothing) Then
                    Marshal.ReleaseComObject(objWorkSheet)
                End If
                If Not (objWorkbook Is Nothing) Then
                    Marshal.ReleaseComObject(objWorkbook)
                End If
                If Not (objXls Is Nothing) Then
                    Marshal.ReleaseComObject(objXls)
                End If
                objWorkSheet = Nothing
                objWorkbook = Nothing
                objXls = Nothing
                System.Threading.Thread.CurrentThread.CurrentCulture = OldCultureInfo
                'psb_Generacion_txt()
            Else
                Throw New Exception("No se genero detalle para la liquidacion")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub psb_Generacion_txt()
        Try

            Dim stTexto As String
            Dim sfd_Dialogo As New System.Windows.Forms.SaveFileDialog
            With sfd_Dialogo
                .Filter = "Libros de Texto Plano (*.txt)|*.txt|Todos Los Archivos (*.*)|*.*"
                .DefaultExt = "txt"
                .FilterIndex = 1
                .Title = "Exportar a ..."
                .FileName = "D" & gUsuarioSGI.IdTrabajador
            End With

            Dim result As DialogResult = sfd_Dialogo.ShowDialog()
            Dim stNombreArchivo As String = sfd_Dialogo.FileName
            stNombreArchivo = stNombreArchivo.Substring(0, stNombreArchivo.LastIndexOf("\")) & "\"
            stNombreArchivo += "D" & gUsuarioSGI.IdTrabajador & ".txt"

            Dim ObjDetraccionTxt As New System.IO.StreamWriter(stNombreArchivo, False)
            If result = Windows.Forms.DialogResult.Cancel Then Exit Sub
            ugb_Espera.Visible = True
            If IO.File.Exists(stNombreArchivo) = False Then IO.File.Create(stNombreArchivo)
            For Each obj As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                stTexto = Microsoft.VisualBasic.Right(obj.Origen, 50) & "|"
                stTexto += Microsoft.VisualBasic.Left(obj.Destino, 100)
                ObjDetraccionTxt.WriteLine(stTexto)
            Next
            ObjDetraccionTxt.Close()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub GenerarExcelTottus()

        Dim objXls As Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objWorkSheet As Excel.Worksheet
        objXls = New Excel.Application
        Dim FileToCopy As String
        Dim PathFilePTRA As String
        Try
            If oeLiquidacion.ListaLiquidacionDetalle.Count > 0 Then
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\PlantillasTottus.xlt" 'gs_RutaPlantillas & "Plantilla_Orden_Compra_SGI.xlt"
                PathFilePTRA = Application.StartupPath & "\PlantillasTottus.xls"

                If System.IO.File.Exists(FileToCopy) Then
                    If System.IO.File.Exists(PathFilePTRA) Then
                        System.IO.File.SetAttributes(PathFilePTRA, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                    End If
                    System.IO.File.Copy(FileToCopy, PathFilePTRA, True)
                    System.IO.File.SetAttributes(PathFilePTRA, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                Else
                    Throw New Exception("No se encontró el archivo de Plantilla en el servidor, Consulte con Soporte")
                End If

                ' Creamos una variable para guardar la cultura actual
                Dim OldCultureInfo As System.Globalization.CultureInfo = _
                System.Threading.Thread.CurrentThread.CurrentCulture

                'Crear una cultura standard (en-US) inglés estados unidos
                System.Threading.Thread.CurrentThread.CurrentCulture = _
                New System.Globalization.CultureInfo("es-PE")

                'Abrimos la plantilla

                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objWorkSheet = objXls.Worksheets(3)


                objWorkSheet.Name = "DATA"     'Asignamos el nombre al archivo en excel.

                Dim ln_Fila As Integer = 1
                Dim Entro3 As Integer = 0
                Dim Entro2 As Integer = 0
                Dim Entro1 As Integer = 0

                For Each obj As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                    Entro3 = 0
                    Entro2 = 0
                    Entro1 = 0
                    With objWorkSheet
                        If obj.CentroCosto3 <> "" Then
                            obj.Observacion = "COMPARTIDO"
                            .Cells(ln_Fila + 1, 1) = obj.NroCarga
                            .Cells(ln_Fila + 1, 2) = obj.Tracto
                            .Cells(ln_Fila + 1, 3) = obj.Carreta
                            .Cells(ln_Fila + 1, 7) = obj.CentroCosto1
                            .Cells(ln_Fila + 1, 9) = obj.Consolidado2
                            .Cells(ln_Fila + 1, 10) = obj.Consolidado3
                            .Cells(ln_Fila + 1, 13) = obj.Fecha.Date
                            .Cells(ln_Fila + 1, 14) = obj.FechaLlegada.Date
                            .Cells(ln_Fila + 1, 16) = obj.FechaSalida.ToShortTimeString
                            .Cells(ln_Fila + 1, 17) = obj.Consolidado1
                            .Cells(ln_Fila + 1, 18) = obj.Destino
                            .Cells(ln_Fila + 1, 20) = obj.GuiaTransportista
                            .Cells(ln_Fila + 1, 22) = obj.FleteUnitario
                            .Cells(ln_Fila + 1, 23) = obj.Observacion
                            ln_Fila = ln_Fila + 1
                            Entro3 = 1
                        End If
                        If obj.CentroCosto2 <> "" Then
                            obj.Observacion = "COMPARTIDO"
                            .Cells(ln_Fila + 1, 1) = obj.NroCarga
                            .Cells(ln_Fila + 1, 2) = obj.Tracto
                            .Cells(ln_Fila + 1, 3) = obj.Carreta
                            If Entro3 = 1 Then
                                objWorkSheet.Cells(ln_Fila + 1, 7) = obj.CentroCosto2
                            Else
                                objWorkSheet.Cells(ln_Fila + 1, 7) = obj.CentroCosto1
                            End If
                            .Cells(ln_Fila + 1, 9) = obj.Consolidado2
                            .Cells(ln_Fila + 1, 10) = obj.Consolidado3
                            .Cells(ln_Fila + 1, 13) = obj.Fecha.Date
                            .Cells(ln_Fila + 1, 14) = obj.FechaLlegada.Date
                            .Cells(ln_Fila + 1, 16) = obj.FechaSalida.ToShortTimeString
                            .Cells(ln_Fila + 1, 17) = obj.Consolidado1
                            .Cells(ln_Fila + 1, 18) = obj.Destino
                            .Cells(ln_Fila + 1, 20) = obj.GuiaTransportista
                            If Entro3 = 1 Then
                                obj.FleteUnitario = 0
                            End If
                            .Cells(ln_Fila + 1, 22) = obj.FleteUnitario
                            .Cells(ln_Fila + 1, 23) = obj.Observacion
                            ln_Fila = ln_Fila + 1
                            Entro2 = 1
                        End If
                        If obj.CentroCosto1 <> "" Then
                            .Cells(ln_Fila + 1, 1) = obj.NroCarga
                            .Cells(ln_Fila + 1, 2) = obj.Tracto
                            .Cells(ln_Fila + 1, 3) = obj.Carreta
                            If Entro2 = 1 Then
                                .Cells(ln_Fila + 1, 7) = obj.CentroCosto2
                            Else
                                .Cells(ln_Fila + 1, 7) = obj.CentroCosto1
                            End If
                            .Cells(ln_Fila + 1, 9) = obj.Consolidado2
                            .Cells(ln_Fila + 1, 10) = obj.Consolidado3
                            .Cells(ln_Fila + 1, 13) = obj.Fecha.Date
                            .Cells(ln_Fila + 1, 14) = obj.FechaLlegada.Date
                            .Cells(ln_Fila + 1, 16) = obj.FechaSalida.ToShortTimeString
                            .Cells(ln_Fila + 1, 17) = obj.Consolidado1
                            .Cells(ln_Fila + 1, 18) = obj.Destino
                            .Cells(ln_Fila + 1, 20) = obj.GuiaTransportista
                            If Entro2 = 1 Then
                                obj.FleteUnitario = 0
                            End If
                            .Cells(ln_Fila + 1, 22) = obj.FleteUnitario
                            .Cells(ln_Fila + 1, 23) = obj.Observacion
                            ln_Fila = ln_Fila + 1
                        End If
                    End With
                Next
                'Mostramos el documento en pantalla
                objXls.ActiveWindow.Zoom = 100
                objXls.ActiveWindow.DisplayGridlines = False
                objXls.Sheets.Item(3).Select()

                objXls.Visible = True 'Permite visualizar el excel.

                If Not (objWorkSheet Is Nothing) Then
                    Marshal.ReleaseComObject(objWorkSheet)
                End If
                If Not (objWorkbook Is Nothing) Then
                    Marshal.ReleaseComObject(objWorkbook)
                End If
                If Not (objXls Is Nothing) Then
                    Marshal.ReleaseComObject(objXls)
                End If
                objWorkSheet = Nothing
                objWorkbook = Nothing
                objXls = Nothing
                System.Threading.Thread.CurrentThread.CurrentCulture = OldCultureInfo
            Else
                Throw New Exception("No se genero detalle para la liquidacion")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub GenerarExcelMaestro()
        Dim objXls As Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objWorkSheet As Excel.Worksheet
        objXls = New Excel.Application
        Dim FileToCopy As String
        Dim PathFilePTRA As String
        Try
            If oeLiquidacion.ListaLiquidacionDetalle.Count > 0 Then
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\PlantillasMaestro.xlt" 'gs_RutaPlantillas & "Plantilla_Orden_Compra_SGI.xlt"
                PathFilePTRA = Application.StartupPath & "\PlantillasMaestro.xls"

                If System.IO.File.Exists(FileToCopy) Then
                    If System.IO.File.Exists(PathFilePTRA) Then
                        System.IO.File.SetAttributes(PathFilePTRA, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                    End If
                    System.IO.File.Copy(FileToCopy, PathFilePTRA, True)
                    System.IO.File.SetAttributes(PathFilePTRA, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                Else
                    Throw New Exception("No se encontró el archivo de Plantilla en el servidor, Consulte con Soporte")
                End If

                ' Creamos una variable para guardar la cultura actual
                Dim OldCultureInfo As System.Globalization.CultureInfo = _
                System.Threading.Thread.CurrentThread.CurrentCulture

                'Crear una cultura standard (en-US) inglés estados unidos
                System.Threading.Thread.CurrentThread.CurrentCulture = _
                New System.Globalization.CultureInfo("es-PE")

                'Abrimos la plantilla

                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objWorkSheet = objXls.Worksheets(1)


                objWorkSheet.Name = "Hoja1"     'Asignamos el nombre al archivo en excel.

                Dim ln_Fila As Integer = 1
                Dim Entro3 As Integer = 0
                Dim Entro2 As Integer = 0
                Dim Entro1 As Integer = 0
                objWorkSheet.Cells(1, 1) = "FACTURACION          - TRANSPORTES" + gs_TxtEmpresaSistema
                For Each obj As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                    With objWorkSheet
                        .Cells(ln_Fila + 2, 1) = obj.Fecha.Date
                        .Cells(ln_Fila + 2, 2) = obj.Tracto
                        .Cells(ln_Fila + 2, 3) = obj.TipoVehiculo
                        .Cells(ln_Fila + 2, 4) = obj.CentroCosto3
                        .Cells(ln_Fila + 2, 5) = obj.CodigoDestino
                        .Cells(ln_Fila + 2, 6) = obj.GuiaRemitente
                        .Cells(ln_Fila + 2, 7) = obj.GuiaTransportista
                        .Cells(ln_Fila + 2, 8) = obj.CentroCosto1
                        .Cells(ln_Fila + 2, 9) = obj.CentroCosto2
                        .Cells(ln_Fila + 2, 10) = obj.Volumen
                        .Cells(ln_Fila + 2, 11) = obj.Consolidado
                        .Cells(ln_Fila + 2, 12) = obj.FleteUnitario
                    End With
                    ln_Fila = ln_Fila + 1
                Next
                'Mostramos el documento en pantalla
                objXls.ActiveWindow.Zoom = 100
                objXls.ActiveWindow.DisplayGridlines = False
                objXls.Sheets.Item(1).Select()

                objXls.Visible = True 'Permite visualizar el excel.

                If Not (objWorkSheet Is Nothing) Then
                    Marshal.ReleaseComObject(objWorkSheet)
                End If
                If Not (objWorkbook Is Nothing) Then
                    Marshal.ReleaseComObject(objWorkbook)
                End If
                If Not (objXls Is Nothing) Then
                    Marshal.ReleaseComObject(objXls)
                End If
                objWorkSheet = Nothing
                objWorkbook = Nothing
                objXls = Nothing
                System.Threading.Thread.CurrentThread.CurrentCulture = OldCultureInfo
            Else
                Throw New Exception("No se genero detalle para la liquidacion")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub GenerarExcelSPSA123(ByVal Tipo As Integer, ByVal Formato As Integer)
        Dim objXls As Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objWorkSheet As Excel.Worksheet
        objXls = New Excel.Application
        Dim FileToCopy As String = ""
        Dim PathFilePTRA As String = ""
        Dim Origen As String = ""
        Try
            If oeLiquidacion.ListaLiquidacionDetalle.Count > 0 Then
                If Tipo = 1 Then
                    Origen = "Cd - Lurin"
                    If Formato = 0 Then
                        FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\PlantillasSPSACDLurin_Prov.xlt"
                        PathFilePTRA = Application.StartupPath & "\PlantillasSPSACDLurin_Prov.xls"
                    End If
                ElseIf Tipo = 2 Then
                    Origen = "Cd -  Lima -  Ransa"
                    If Formato = 0 Then
                        FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\PlantillasSPSACDRansa.xlt"
                        PathFilePTRA = Application.StartupPath & "\PlantillasSPSACDRansa.xls"
                    End If
                ElseIf Tipo = 3 Then
                    Origen = "Cd - San Francisco"
                    If Formato = 0 Then
                        FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\PlantillasSPSACDSFVES.xlt"
                        PathFilePTRA = Application.StartupPath & "\PlantillasSPSACDSFVES.xls"
                    End If
                End If
                If Formato <> 0 Then
                    FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\PlantillasSPSACDLurin_Prov2.xlt" 
                    PathFilePTRA = Application.StartupPath & "\PlantillasSPSACDLurin_Prov2.xls"
                End If

                If System.IO.File.Exists(FileToCopy) Then
                    If System.IO.File.Exists(PathFilePTRA) Then
                        System.IO.File.SetAttributes(PathFilePTRA, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                    End If
                    System.IO.File.Copy(FileToCopy, PathFilePTRA, True)
                    System.IO.File.SetAttributes(PathFilePTRA, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                Else
                    Throw New Exception("No se encontró el archivo de Plantilla en el servidor, Consulte con Soporte")
                End If

                ' Creamos una variable para guardar la cultura actual
                Dim OldCultureInfo As System.Globalization.CultureInfo = _
                System.Threading.Thread.CurrentThread.CurrentCulture

                'Crear una cultura standard (en-US) inglés estados unidos
                System.Threading.Thread.CurrentThread.CurrentCulture = _
                New System.Globalization.CultureInfo("es-PE")

                'Abrimos la plantilla

                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objWorkSheet = objXls.Worksheets(1)


                objWorkSheet.Name = "Detalle"     'Asignamos el nombre al archivo en excel.
                '.OrderBy(Function(Item) Item.Nombre).ToList
                Dim ln_Fila As Integer = 1

                If Formato <> 0 Then
                    For Each obj As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True).OrderBy(Function(Item) Item.Fecha).ToList
                        With objWorkSheet
                            '.Cells(ln_Fila + 56, 2) = CStr(ln_Fila)
                            .Cells(ln_Fila + 56, 10) = obj.Fecha.Date
                            If Tipo <> 8 Then
                                .Cells(ln_Fila + 56, 11) = Origen
                            Else
                                .Cells(ln_Fila + 56, 11) = obj.Origen
                            End If

                            .Cells(ln_Fila + 56, 12) = obj.Destino
                            If obj.Consolidado2 = "." Then
                                obj.Consolidado2 = ""
                            End If
                            If obj.Consolidado3 = "." Then
                                obj.Consolidado3 = ""
                            End If
                            .Cells(ln_Fila + 56, 13) = obj.Consolidado2
                            .Cells(ln_Fila + 56, 14) = obj.Consolidado3
                            .Cells(ln_Fila + 56, 17) = obj.Capacidad
                            .Cells(ln_Fila + 56, 19) = "ISL"
                            .Cells(ln_Fila + 56, 25) = obj.Tracto
                            .Cells(ln_Fila + 56, 26) = obj.Carreta
                            .Cells(ln_Fila + 56, 27) = obj.Ruta
                            .Cells(ln_Fila + 56, 28) = obj.FleteUnitario + obj.Consolidado
                            '.Cells(ln_Fila + 56, 18) = "=SI.ERROR(BUSCARV(E" & CStr(56 + ln_Fila) & ",Formatos!$A:$C,2,0),0)"
                            .Cells(ln_Fila + 56, 30) = obj.GuiaRemitente
                            ''.Cells(ln_Fila + 56, 20) = obj.GuiaTransportista
                            .Cells(ln_Fila + 56, 31) = obj.NroCarga
                            .Cells(ln_Fila + 56, 34) = obj.FleteUnitario
                            .Cells(ln_Fila + 56, 35) = obj.Consolidado
                        End With
                        ln_Fila = ln_Fila + 1
                    Next
                Else
                    For Each obj As e_LiquidacionDetalle In oeLiquidacion.ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True).OrderBy(Function(Item) Item.Fecha).ToList
                        With objWorkSheet
                            .Cells(ln_Fila + 105, 2) = CStr(ln_Fila)
                            .Cells(ln_Fila + 105, 3) = obj.Fecha.Date
                            If Tipo <> 8 Then
                                .Cells(ln_Fila + 56, 11) = Origen
                            Else
                                .Cells(ln_Fila + 56, 11) = obj.Origen
                            End If
                            .Cells(ln_Fila + 105, 5) = obj.Destino
                            If obj.Consolidado2 = "." Then
                                obj.Consolidado2 = ""
                            End If
                            If obj.Consolidado3 = "." Then
                                obj.Consolidado3 = ""
                            End If
                            .Cells(ln_Fila + 105, 6) = obj.Consolidado2
                            .Cells(ln_Fila + 105, 7) = obj.Consolidado3
                            .Cells(ln_Fila + 105, 8) = obj.Capacidad
                            .Cells(ln_Fila + 105, 10) = "ISL"
                            .Cells(ln_Fila + 105, 14) = obj.Tracto
                            .Cells(ln_Fila + 105, 15) = obj.Carreta
                            .Cells(ln_Fila + 105, 16) = obj.Ruta
                            .Cells(ln_Fila + 105, 18) = "=SI.ERROR(BUSCARV(E" & CStr(105 + ln_Fila) & ",Formatos!$A:$C,2,0),0)"
                            .Cells(ln_Fila + 105, 19) = obj.GuiaRemitente
                            .Cells(ln_Fila + 105, 20) = obj.GuiaTransportista
                            .Cells(ln_Fila + 105, 21) = obj.NroCarga
                            .Cells(ln_Fila + 105, 25) = obj.FleteUnitario
                            .Cells(ln_Fila + 105, 26) = obj.Consolidado
                        End With
                        ln_Fila = ln_Fila + 1
                    Next
                End If

                'Mostramos el documento en pantalla
                objXls.ActiveWindow.Zoom = 100
                objXls.ActiveWindow.DisplayGridlines = False
                objXls.Sheets.Item(1).Select()

                objXls.Visible = True 'Permite visualizar el excel.

                If Not (objWorkSheet Is Nothing) Then
                    Marshal.ReleaseComObject(objWorkSheet)
                End If
                If Not (objWorkbook Is Nothing) Then
                    Marshal.ReleaseComObject(objWorkbook)
                End If
                If Not (objXls Is Nothing) Then
                    Marshal.ReleaseComObject(objXls)
                End If
                objWorkSheet = Nothing
                objWorkbook = Nothing
                objXls = Nothing
                System.Threading.Thread.CurrentThread.CurrentCulture = OldCultureInfo
            Else
                Throw New Exception("No se genero detalle para la liquidacion")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub Editar123(ByVal Tipo As String)
        Try
            oeLiquidacionDetalle.TipoOperacion = Tipo
            griViajesLiquidacionDetalleSPSA.DataSource = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
            CalcularTotales(griViajesLiquidacionDetalleSPSA, "TotalFlete", "FleteUnitario", "Consolidado")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Function EditarLiquidacion() As Boolean
        Try
            With griLiquidacion.ActiveRow
                If .Cells("Id").Value.ToString.Length > 0 Then
                    oeLiquidacion = New e_Liquidaciones
                    txtIdLiquidacion.Text = .Cells("Id").Value.ToString
                    oeLiquidacion.Id = txtIdLiquidacion.Text
                    oeLiquidacion = olLiquidacion.Obtener(oeLiquidacion)
                    With oeLiquidacion
                        txtCodigo.Text = .Codigo
                        fecLiquidacion.Value = .Fecha
                        cboClienteLiquidacion.Text = .IdCliente
                        txtSubTotal.Value = .SubTotal
                        txtIgv.Value = .Igv
                        txtTotal.Value = .Total
                        txtObservacion.Text = .Observacion
                        opcFormatoLiquidacion.CheckedIndex = .IndFormato
                    End With
                    oeLiquidacionDetalle = New e_LiquidacionDetalle
                    oeLiquidacionDetalle.IdLiquidacion = txtIdLiquidacion.Text
                    Select Case opcFormatoLiquidacion.CheckedIndex
                        Case 0
                            oeLiquidacionDetalle.TipoOperacion = ""
                            griViajesLiquidacionDetalle.DataSource = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
                            CalcularTotales(griViajesLiquidacionDetalle, "TotalFlete", "FleteUnitario")
                        Case 1
                            Editar123("A")
                        Case 2
                            Editar123("B")
                        Case 3
                            Editar123("C")
                        Case 4
                            Editar467()
                        Case 5
                            oeLiquidacionDetalle.TipoOperacion = "E"
                            griViajesLiquidacionDetalleMAESTRO.DataSource = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
                            CalcularTotales(griViajesLiquidacionDetalleMAESTRO, "TotalFlete", "FleteUnitario")
                        Case 6
                            Editar467()
                        Case 7
                            Editar467()
                        Case 8
                            Editar123("P")
                    End Select
                End If
            End With
            MostrarTabs(1, ficLiquidacion, 1)
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Function

    Private Sub Editar467()
        Try
            oeLiquidacionDetalle.TipoOperacion = "D"
            oeLiquidacionDetalle.IdCliente = oeLiquidacion.IdCliente
            griViajesLiquidacionDetalleTOTTUS.DataSource = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
            CalcularTotales(griViajesLiquidacionDetalleTOTTUS, "TotalFlete", "FleteUnitario")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub frm_Liquidaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LlenarComboMaestro(cboCliente, ClientesPublic, 0)
            LlenarComboMaestro(cboClienteLiquidacion, ClientesPublic, 0)
            ControlRangoFechaInicializa()

            'Cargar Centro            
            LlenarCombo(cboCentro, "Nombre", CentroPublic, 0)
            'cboCentro.Value = Prefijo.PrefijoID

            oeTipoIV.Id = "I"
            oeTipoIV.Nombre = "I"
            ListaTipoIV.Add(oeTipoIV)
            oeTipoIV = New e_Combo
            oeTipoIV.Id = "I y V"
            oeTipoIV.Nombre = "I y V"
            ListaTipoIV.Add(oeTipoIV)
            Dim TipoIV = New DataTable
            TipoIV = olCombo.ComboGrilla(ListaTipoIV)
            CrearComboGrid("Ruta", "Nombre", griViajesSinLiquidarSPSA, TipoIV, True)
            CrearComboGrid("Ruta", "Nombre", griViajesLiquidacionDetalleSPSA, TipoIV, True)

            oeClaseServicio.Id = "DESPACHO LOCAL"
            oeClaseServicio.Nombre = "DESPACHO LOCAL"
            ListaClaseServicio.Add(oeClaseServicio)
            oeClaseServicio = New e_Combo
            oeClaseServicio.Id = "DESPACHO PROVINCIA"
            oeClaseServicio.Nombre = "DESPACHO PROVINCIA"
            ListaClaseServicio.Add(oeClaseServicio)
            oeClaseServicio = New e_Combo
            oeClaseServicio.Id = "LOCAL-CHICLAYO"
            oeClaseServicio.Nombre = "LOCAL-CHICLAYO"
            ListaClaseServicio.Add(oeClaseServicio)
            Dim ClaseServicio = New DataTable
            ClaseServicio = olCombo.ComboGrilla(ListaClaseServicio)

            oeSubClaseServicio.Id = "REGULAR"
            oeSubClaseServicio.Nombre = "REGULAR"
            ListaSubClaseServicio.Add(oeSubClaseServicio)
            oeSubClaseServicio = New e_Combo
            oeSubClaseServicio.Id = "DEVOLUCION"
            oeSubClaseServicio.Nombre = "DEVOLUCION"
            ListaSubClaseServicio.Add(oeSubClaseServicio)
            oeSubClaseServicio = New e_Combo
            oeSubClaseServicio.Id = "ESPECIAL"
            oeSubClaseServicio.Nombre = "ESPECIAL"
            ListaSubClaseServicio.Add(oeSubClaseServicio)
            oeSubClaseServicio = New e_Combo
            oeSubClaseServicio.Id = "LOCAL-CHICLAYO"
            oeSubClaseServicio.Nombre = "LOCAL-CHICLAYO"
            ListaSubClaseServicio.Add(oeSubClaseServicio)
            Dim SubClaseServicio = New DataTable
            SubClaseServicio = olCombo.ComboGrilla(ListaSubClaseServicio)

            CrearComboGrid("Consolidado2", "Nombre", griViajesSinLiquidarTOTTUS, ClaseServicio, False)
            CrearComboGrid("Consolidado2", "Nombre", griViajesLiquidacionDetalleTOTTUS, ClaseServicio, False)
            CrearComboGrid("Consolidado3", "Nombre", griViajesSinLiquidarTOTTUS, SubClaseServicio, False)
            CrearComboGrid("Consolidado3", "Nombre", griViajesLiquidacionDetalleTOTTUS, SubClaseServicio, False)

            oeOrigenSPSA.Id = "CD -  LIMA -  RANSA"
            oeOrigenSPSA.Nombre = "CD -  LIMA -  RANSA"
            ListaOrigenSPSA.Add(oeOrigenSPSA)
            oeOrigenSPSA = New e_Combo
            oeOrigenSPSA.Id = "CD - LURIN"
            oeOrigenSPSA.Nombre = "CD - LURIN"
            ListaOrigenSPSA.Add(oeOrigenSPSA)
            oeOrigenSPSA = New e_Combo
            oeOrigenSPSA.Id = "CD - SAN FRANCISCO"
            oeOrigenSPSA.Nombre = "CD - SAN FRANCISCO"
            ListaOrigenSPSA.Add(oeOrigenSPSA)
            Dim OrigenSPSA = New DataTable
            OrigenSPSA = olCombo.ComboGrilla(ListaOrigenSPSA)
            CrearComboGrid("CentroCosto1", "Nombre", griViajesSinLiquidarSPSA, OrigenSPSA, False)
            CrearComboGrid("CentroCosto1", "Nombre", griViajesLiquidacionDetalleSPSA, OrigenSPSA, False)

            oeOrigenTottus.Id = "CD"
            oeOrigenTottus.Nombre = "CD"
            ListaOrigenTottus.Add(oeOrigenTottus)
            oeOrigenTottus = New e_Combo
            oeOrigenTottus.Id = "LURIN"
            oeOrigenTottus.Nombre = "LURIN"
            ListaOrigenTottus.Add(oeOrigenTottus)
            oeOrigenTottus = New e_Combo
            oeOrigenTottus.Id = "SAN FRANCISCO"
            oeOrigenTottus.Nombre = "SAN FRANCISCO"
            ListaOrigenTottus.Add(oeOrigenTottus)
            Dim OrigenTottus = New DataTable
            OrigenTottus = olCombo.ComboGrilla(ListaOrigenTottus)
            CrearComboGrid("Consolidado1", "Nombre", griViajesSinLiquidarTOTTUS, OrigenTottus, False)
            CrearComboGrid("Consolidado1", "Nombre", griViajesLiquidacionDetalleTOTTUS, OrigenTottus, False)
            CrearComboGrid("IdCliente", "Nombre", griLiquidacion, olCombo.ComboGrilla(ClientesPublic), True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnExpandido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandido.Click
        For x As Integer = 0 To griLista.Rows.Count - 1
            Me.griLista.Rows(x).ExpandAll()
        Next
    End Sub

    Private Sub btnN1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN1.Click
        For x As Integer = 0 To griLista.Rows.Count - 1
            Me.griLista.Rows(x).CollapseAll()
        Next
    End Sub

    Private Sub BtnN2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnN2.Click
        btnExpandido.PerformClick()
        For i As Integer = 0 To griLista.Rows.Count - 1
            For Each aChildBand1 As UltraGridChildBand In griLista.Rows(i).ChildBands
                For x As Integer = 0 To aChildBand1.Rows.Count - 1
                    aChildBand1.Rows(x).CollapseAll()
                Next
            Next
        Next
    End Sub

    'Private Sub btnN3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN3.Click
    '    For x As Integer = 0 To griLista.Rows.Count - 1
    '        Me.griLista.Rows(x).ExpandAll()
    '    Next
    'End Sub

    Private Sub btnEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarCorreo.Click
        Dim formulario As frm_EnvioCorreo
        formulario = frm_EnvioCorreo
        formulario.Modulo = "Liquidaciones"
        formulario.ShowDialog()
    End Sub

    Private Sub ViajesSinLiquidarSPSA(ByVal Tipo As String)
        With oeLiquidacionDetalle
            .TipoOperacion = Tipo
            .IdLiquidacion = cboClienteLiquidacion.Value
            .FechaDesde = fecDesdeViaje.Value
            .FechaHasta = fecHastaViaje.Value
        End With

        griViajesSinLiquidarSPSA.DataSource = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSinLiquidarSPSA.Rows
            If fila.Cells("IndGrtConfirmada").Value Then
                If fila.Cells("IndDocumentos").Value Then
                    fila.CellAppearance.BackColor = Me.ColorConDocts.Color
                Else
                    fila.CellAppearance.BackColor = Me.ColorSinDocts.Color
                End If
            Else
                fila.CellAppearance.BackColor = Me.ColorSinConfirmar.Color
            End If
            If fila.Cells("IndGrtPerdido").Value Then
                fila.Cells("Fecha").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                fila.Cells("GuiaTransportista").Appearance.BackColor = Me.ColorDoctsPerdido.Color
            End If
        Next
        CalcularTotales(griViajesSinLiquidarSPSA, "TotalFlete", "FleteUnitario", "Consolidado")
    End Sub

    Private Sub ViajesSinLiquidarTottus(ByVal Tipo As String)
        With oeLiquidacionDetalle
            .TipoOperacion = Tipo
            .IdLiquidacion = cboClienteLiquidacion.Value
            .IdCliente = cboClienteLiquidacion.Value
            .FechaDesde = fecDesdeViaje.Value
            .FechaHasta = fecHastaViaje.Value
        End With

        griViajesSinLiquidarTOTTUS.DataSource = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSinLiquidarTOTTUS.Rows
            If fila.Cells("IndGrtConfirmada").Value Then
                If fila.Cells("IndDocumentos").Value Then
                    fila.CellAppearance.BackColor = Me.ColorConDocts.Color
                Else
                    fila.CellAppearance.BackColor = Me.ColorSinDocts.Color
                End If
            Else
                fila.CellAppearance.BackColor = Me.ColorSinConfirmar.Color
            End If
            If fila.Cells("IndGrtPerdido").Value Then
                fila.Cells("Fecha").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                fila.Cells("GuiaTransportista").Appearance.BackColor = Me.ColorDoctsPerdido.Color
            End If
        Next
        CalcularTotales(griViajesSinLiquidarTOTTUS, "TotalFlete", "FleteUnitario")
    End Sub

    Private Sub ViajesSinLiquidarMaestro(ByVal Tipo As String)
        With oeLiquidacionDetalle
            .TipoOperacion = Tipo
            .IdLiquidacion = cboClienteLiquidacion.Value
            .FechaDesde = fecDesdeViaje.Value
            .FechaHasta = fecHastaViaje.Value
        End With

        griViajesSinLiquidarMAESTRO.DataSource = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSinLiquidarMAESTRO.Rows
            If fila.Cells("IndGrtConfirmada").Value Then
                If fila.Cells("IndDocumentos").Value Then
                    fila.CellAppearance.BackColor = Me.ColorConDocts.Color
                Else
                    fila.CellAppearance.BackColor = Me.ColorSinDocts.Color
                End If
            Else
                fila.CellAppearance.BackColor = Me.ColorSinConfirmar.Color
            End If
            If fila.Cells("IndGrtPerdido").Value Then
                fila.Cells("Fecha").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                fila.Cells("GuiaTransportista").Appearance.BackColor = Me.ColorDoctsPerdido.Color
            End If
        Next
        CalcularTotales(griViajesSinLiquidarMAESTRO, "TotalFlete", "FleteUnitario")
    End Sub

    Private Sub btnViajesSinLiquidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViajesSinLiquidar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeLiquidacionDetalle = New e_LiquidacionDetalle
            Select Case opcFormatoLiquidacion.CheckedIndex
                Case 0
                    With oeLiquidacionDetalle
                        .TipoOperacion = "V"
                        .IdLiquidacion = cboClienteLiquidacion.Value
                        .FechaDesde = fecDesdeViaje.Value
                        .FechaHasta = fecHastaViaje.Value
                    End With
                    griViajesSinLiquidar.DataSource = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSinLiquidar.Rows
                        If fila.Cells("IndGrtConfirmada").Value Then
                            If fila.Cells("IndDocumentos").Value Then
                                fila.CellAppearance.BackColor = Me.ColorConDocts.Color
                            Else
                                fila.CellAppearance.BackColor = Me.ColorSinDocts.Color
                            End If
                        Else
                            fila.CellAppearance.BackColor = Me.ColorSinConfirmar.Color
                        End If
                        If fila.Cells("IndGrtPerdido").Value Then
                            fila.Cells("Fecha").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                            fila.Cells("GuiaTransportista").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                        End If
                    Next
                    CalcularTotales(griViajesSinLiquidar, "TotalFlete", "FleteUnitario")
                    tabDetalleLiquidacion.Tabs(0).Selected = True
                Case 1
                    ViajesSinLiquidarSPSA("1")
                    tabDetalleLiquidacion.Tabs(2).Selected = True
                Case 2
                    ViajesSinLiquidarSPSA("2")
                    tabDetalleLiquidacion.Tabs(2).Selected = True
                Case 3
                    ViajesSinLiquidarSPSA("3")
                    tabDetalleLiquidacion.Tabs(2).Selected = True
                Case 4
                    ViajesSinLiquidarTottus("4")
                    tabDetalleLiquidacion.Tabs(4).Selected = True
                Case 5
                    ViajesSinLiquidarMaestro("5")
                    tabDetalleLiquidacion.Tabs(6).Selected = True
                Case 6
                    ViajesSinLiquidarTottus("4")
                    tabDetalleLiquidacion.Tabs(4).Selected = True
                Case 7
                    ViajesSinLiquidarTottus("4")
                    tabDetalleLiquidacion.Tabs(4).Selected = True
                Case 8
                    ViajesSinLiquidarSPSA("1")
                    tabDetalleLiquidacion.Tabs(2).Selected = True
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griViajesSinLiquidar_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajesSinLiquidar.CellChange
        Try
            griViajesSinLiquidar.UpdateData()
            Select Case e.Cell.Column.Key
                Case "FleteUnitario"
                    With griViajesSinLiquidar.ActiveRow
                        .Cells("TotalFlete").Value = (.Cells("FleteUnitario").Value * gIgv) + .Cells("FleteUnitario").Value
                    End With
                    If Operacion = "Nuevo" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidar.DataSource
                        CalcularSubTotal()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub SeleccionarViajes123()
        If griViajesSinLiquidarSPSA.Rows.Count > 0 Then
            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSinLiquidarSPSA.Rows.Where(Function(item) item.IsFilteredOut = False)
                If Fila.Cells("IndGrtConfirmada").Value = 1 Then
                    Fila.Cells("Seleccion").Value = True
                Else
                    txtOperacionesSinConfirmar.Text += Fila.Cells("Operacion").Value & " / "
                End If
            Next
            If Operacion = "Nuevo" Then
                oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarSPSA.DataSource
                CalcularSubTotal()
            End If
        End If
    End Sub

    Private Sub SeleccionarViajes467()
        If griViajesSinLiquidarTOTTUS.Rows.Count > 0 Then
            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSinLiquidarTOTTUS.Rows.Where(Function(item) item.IsFilteredOut = False)
                If Fila.Cells("IndGrtConfirmada").Value = 1 Then
                    Fila.Cells("Seleccion").Value = True
                Else
                    txtOperacionesSinConfirmar.Text += Fila.Cells("Operacion").Value & " / "
                End If
            Next
            If Operacion = "Nuevo" Then
                oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarTOTTUS.DataSource
                CalcularSubTotal()
            End If
        End If
    End Sub

    Private Sub btnSeleccionaViajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionaViajes.Click
        Select Case opcFormatoLiquidacion.CheckedIndex
            Case 0
                If griViajesSinLiquidar.Rows.Count > 0 Then
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSinLiquidar.Rows.Where(Function(item) item.IsFilteredOut = False)
                        If Fila.Cells("IndGrtConfirmada").Value = 1 Then
                            Fila.Cells("Seleccion").Value = True
                        Else
                            txtOperacionesSinConfirmar.Text += Fila.Cells("Operacion").Value & " / "
                        End If
                    Next
                    If Operacion = "Nuevo" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidar.DataSource
                        CalcularSubTotal()
                    End If
                End If
            Case 1
                SeleccionarViajes123()
            Case 2
                SeleccionarViajes123()
            Case 3
                SeleccionarViajes123()
            Case 4
                SeleccionarViajes467()
            Case 5
                If griViajesSinLiquidarMAESTRO.Rows.Count > 0 Then
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSinLiquidarMAESTRO.Rows.Where(Function(item) item.IsFilteredOut = False)
                        If Fila.Cells("IndGrtConfirmada").Value = 1 Then
                            Fila.Cells("Seleccion").Value = True
                        Else
                            txtOperacionesSinConfirmar.Text += Fila.Cells("Operacion").Value & " / "
                        End If
                    Next
                    If Operacion = "Nuevo" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarMAESTRO.DataSource
                        CalcularSubTotal()
                    End If
                End If
            Case 6
                SeleccionarViajes467()
            Case 7
                SeleccionarViajes467()
            Case 8
                SeleccionarViajes123()
        End Select
    End Sub

    Private Sub griViajesSinLiquidar_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajesSinLiquidar.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub griLiquidacion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLiquidacion.DoubleClick
        If griLiquidacion.Selected.Rows.Count > 0 Then
            Editar()
        End If
    End Sub

    Private Function EliminarLiquidacion() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griLiquidacion
                If ValidarGrilla(griLiquidacion, "Liquidacion") Then
                    oeLiquidacion = New e_Liquidaciones
                    oeLiquidacion.Id = griLiquidacion.ActiveRow.Cells("Id").Value
                    oeLiquidacion = olLiquidacion.Obtener(oeLiquidacion)
                    If oeLiquidacion.Id <> "" Then
                        If oeLiquidacion.IdEstado = "GENERADA" Then
                            If MessageBox.Show("Esta seguro de eliminar la liquidacion: " & _
                                                             oeLiquidacion.Codigo & " ?", _
                                                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeLiquidacion.TipoOperacion = "E"
                                olLiquidacion.Eliminar(oeLiquidacion)
                            Else
                                Return False
                                Exit Function
                            End If
                        Else
                            Throw New Exception("Liquidacion: " & oeViaje.Codigo & " no se puede eliminar su estado es :" & oeLiquidacion.IdEstado)
                        End If
                    End If
                End If
            End With
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            ugb_Espera.Visible = False
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Function

    Private Function EliminarLiquidacionDetalle123() As Boolean
        With griViajesLiquidacionDetalleSPSA.ActiveRow
            If ValidarGrilla(griViajesLiquidacionDetalleSPSA, "Liquidacion Detalle") Then
                oeLiquidacion = New e_Liquidaciones
                oeLiquidacion.Id = txtIdLiquidacion.Text.Trim
                oeLiquidacion = olLiquidacion.Obtener(oeLiquidacion)
                If oeLiquidacion.Id <> "" Then
                    If oeLiquidacion.IdEstado = "GENERADA" Then
                        If MessageBox.Show("Esta seguro de eliminar el viaje de la liquidacion: " & _
                                            oeLiquidacion.Codigo & " ?", _
                                           "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeLiquidacionDetalle = New e_LiquidacionDetalle
                            oeLiquidacionDetalle.TipoOperacion = "D"
                            oeLiquidacionDetalle.Id = .Cells("Id").Value
                            oeLiquidacionDetalle.IdViaje = .Cells("IdOperacion").Value
                            olLiquidacion.EliminarLiquidacionDetalle(oeLiquidacionDetalle)
                        Else
                            Return False
                            Exit Function
                        End If
                    Else
                        Throw New Exception("Liquidacion: " & oeViaje.Codigo & " no se puede eliminar sus viajes su estado es :" & oeLiquidacion.IdEstado)
                    End If
                End If
            End If
        End With
        Return True
    End Function

    Private Function EliminarLiquidacionDetalle467() As Boolean
        With griViajesLiquidacionDetalleTOTTUS.ActiveRow
            If ValidarGrilla(griViajesLiquidacionDetalleTOTTUS, "Liquidacion Detalle") Then
                oeLiquidacion = New e_Liquidaciones
                oeLiquidacion.Id = txtIdLiquidacion.Text.Trim
                oeLiquidacion = olLiquidacion.Obtener(oeLiquidacion)
                If oeLiquidacion.Id <> "" Then
                    If oeLiquidacion.IdEstado = "GENERADA" Then
                        If MessageBox.Show("Esta seguro de eliminar el viaje de la liquidacion: " & _
                                                         oeLiquidacion.Codigo & " ?", _
                                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeLiquidacionDetalle = New e_LiquidacionDetalle
                            oeLiquidacionDetalle.TipoOperacion = "D"
                            oeLiquidacionDetalle.Id = .Cells("Id").Value
                            oeLiquidacionDetalle.IdViaje = .Cells("IdOperacion").Value
                            olLiquidacion.EliminarLiquidacionDetalle(oeLiquidacionDetalle)
                        Else
                            Return False
                            Exit Function
                        End If
                    Else
                        Throw New Exception("Liquidacion: " & oeViaje.Codigo & " no se puede eliminar sus viajes su estado es :" & oeLiquidacion.IdEstado)
                    End If
                End If
            End If
        End With
        Return True
    End Function

    Private Function EliminarLiquidacionDetalle() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case opcFormatoLiquidacion.CheckedIndex
                Case 0
                    With griViajesLiquidacionDetalle.ActiveRow
                        If ValidarGrilla(griViajesLiquidacionDetalle, "Liquidacion Detalle") Then
                            oeLiquidacion = New e_Liquidaciones
                            oeLiquidacion.Id = txtIdLiquidacion.Text.Trim
                            oeLiquidacion = olLiquidacion.Obtener(oeLiquidacion)
                            If oeLiquidacion.Id <> "" Then
                                If oeLiquidacion.IdEstado = "GENERADA" Then
                                    If MessageBox.Show("Esta seguro de eliminar el viaje de la liquidacion: " & _
                                                                     oeLiquidacion.Codigo & " ?", _
                                                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                        oeLiquidacionDetalle = New e_LiquidacionDetalle
                                        oeLiquidacionDetalle.TipoOperacion = "E"
                                        oeLiquidacionDetalle.Id = .Cells("Id").Value
                                        oeLiquidacionDetalle.IdViaje = .Cells("IdViaje").Value
                                        olLiquidacion.EliminarLiquidacionDetalle(oeLiquidacionDetalle)
                                    Else
                                        Return False
                                        Exit Function
                                    End If
                                Else
                                    Throw New Exception("Liquidacion: " & oeViaje.Codigo & " no se puede eliminar sus viajes su estado es :" & oeLiquidacion.IdEstado)
                                End If
                            End If
                        End If
                    End With
                Case 1
                    EliminarLiquidacionDetalle123()
                Case 2
                    EliminarLiquidacionDetalle123()
                Case 3
                    EliminarLiquidacionDetalle123()
                Case 4
                    EliminarLiquidacionDetalle467()
                Case 5
                    With griViajesLiquidacionDetalleMAESTRO.ActiveRow
                        If ValidarGrilla(griViajesLiquidacionDetalleMAESTRO, "Liquidacion Detalle") Then
                            oeLiquidacion = New e_Liquidaciones
                            oeLiquidacion.Id = txtIdLiquidacion.Text.Trim
                            oeLiquidacion = olLiquidacion.Obtener(oeLiquidacion)
                            If oeLiquidacion.Id <> "" Then
                                If oeLiquidacion.IdEstado = "GENERADA" Then
                                    If MessageBox.Show("Esta seguro de eliminar el viaje de la liquidacion: " & _
                                                        oeLiquidacion.Codigo & " ?", _
                                                        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                        oeLiquidacionDetalle = New e_LiquidacionDetalle
                                        oeLiquidacionDetalle.TipoOperacion = "D"
                                        oeLiquidacionDetalle.Id = .Cells("Id").Value
                                        oeLiquidacionDetalle.IdViaje = .Cells("IdOperacion").Value
                                        olLiquidacion.EliminarLiquidacionDetalle(oeLiquidacionDetalle)
                                    Else
                                        Return False
                                        Exit Function
                                    End If
                                Else
                                    Throw New Exception("Liquidacion: " & oeViaje.Codigo & " no se puede eliminar sus viajes su estado es :" & oeLiquidacion.IdEstado)
                                End If
                            End If
                        End If
                    End With
                Case 6
                    EliminarLiquidacionDetalle467()
                Case 7
                    EliminarLiquidacionDetalle467()
                Case 8
                    EliminarLiquidacionDetalle123()
            End Select
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            ugb_Espera.Visible = False
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Function

    Private Sub griLiquidacion_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLiquidacion.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarLiquidacion() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Liquidaciones_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griViajesLiquidacionDetalle_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajesLiquidacionDetalle.CellChange
        Try
            griViajesLiquidacionDetalle.UpdateData()
            Select Case e.Cell.Column.Key
                Case "FleteUnitario"
                    With griViajesLiquidacionDetalle.ActiveRow
                        .Cells("TotalFlete").Value = (.Cells("FleteUnitario").Value * gIgv) + .Cells("FleteUnitario").Value
                    End With
                    If Operacion = "Editar" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalle.DataSource
                        CalcularSubTotal()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajesLiquidacionDetalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajesLiquidacionDetalle.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarLiquidacionDetalle() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
            griViajesLiquidacionDetalle.UpdateData()
            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalle.DataSource
            CalcularSubTotal()
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub griListaViajesAntiguos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaViajesAntiguos.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub Menu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Menu.Opening
        With Menu
            .Items("Insert").Visible = True
            If griLiquidacion.Selected.Rows.Count > 0 Then
                .Items("Update").Visible = True
                .Items("Delete").Visible = True
                .Items("VerArchivo").Visible = True
                .Items("Enviar").Visible = True
                .Items("DivideLiquidacion").Visible = True
            Else
                .Items("Update").Visible = False
                .Items("Delete").Visible = False
                .Items("VerArchivo").Visible = False
                .Items("Enviar").Visible = False
                .Items("DivideLiquidacion").Visible = False
            End If
        End With
    End Sub

    Private Sub Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        Nuevo()
    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        Editar()
    End Sub

    Private Sub VerArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerArchivo.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griLiquidacion.ActiveRow
                If .Cells("Id").Value.ToString.Length > 0 Then
                    oeLiquidacion = New e_Liquidaciones
                    oeLiquidacionDetalle = New e_LiquidacionDetalle

                    Select Case CInt(.Cells("IndFormato").Value)
                        Case 0
                            oeLiquidacionDetalle.TipoOperacion = ""
                            oeLiquidacionDetalle.IdLiquidacion = .Cells("Id").Value.ToString
                            oeLiquidacion.ListaLiquidacionDetalle = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
                            GenerarExcelFlotaPequeña()
                        Case 1
                            oeLiquidacionDetalle.TipoOperacion = "A"
                            oeLiquidacionDetalle.IdLiquidacion = .Cells("Id").Value.ToString
                            oeLiquidacion.ListaLiquidacionDetalle = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
                            GenerarExcelSPSA123(1, opcPlantillaLista.CheckedIndex)
                        Case 2
                            oeLiquidacionDetalle.TipoOperacion = "B"
                            oeLiquidacionDetalle.IdLiquidacion = .Cells("Id").Value.ToString
                            oeLiquidacion.ListaLiquidacionDetalle = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
                            GenerarExcelSPSA123(2, opcPlantillaLista.CheckedIndex)
                        Case 3
                            oeLiquidacionDetalle.TipoOperacion = "C"
                            oeLiquidacionDetalle.IdLiquidacion = .Cells("Id").Value.ToString
                            oeLiquidacion.ListaLiquidacionDetalle = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
                            GenerarExcelSPSA123(3, opcPlantillaLista.CheckedIndex)
                        Case 4
                            VerArchivo467(.Cells("IdCliente").Value.ToString)
                        Case 5
                            oeLiquidacionDetalle.TipoOperacion = "E"
                            oeLiquidacionDetalle.IdLiquidacion = .Cells("Id").Value.ToString
                            oeLiquidacion.ListaLiquidacionDetalle = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
                            GenerarExcelMaestro()
                        Case 6
                            VerArchivo467(.Cells("IdCliente").Value.ToString)
                        Case 7
                            VerArchivo467(.Cells("IdCliente").Value.ToString)
                        Case 8
                            oeLiquidacionDetalle.TipoOperacion = "P"
                            oeLiquidacionDetalle.IdLiquidacion = .Cells("Id").Value.ToString
                            oeLiquidacion.ListaLiquidacionDetalle = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
                            GenerarExcelSPSA123(8, opcPlantillaLista.CheckedIndex)
                    End Select

                End If
            End With
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub VerArchivo467(IdCliente As String)
        With griLiquidacion.ActiveRow
            oeLiquidacionDetalle.TipoOperacion = "D"
            oeLiquidacionDetalle.IdCliente = IdCliente
            oeLiquidacionDetalle.IdLiquidacion = .Cells("Id").Value.ToString
            oeLiquidacion.ListaLiquidacionDetalle = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
            GenerarExcelTottus()
        End With
    End Sub
    Private Sub Enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enviar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLiquidacion.ActiveRow.Cells("IdEstado").Value = "GENERADA" Then
                oeLiquidacion = New e_Liquidaciones
                With oeLiquidacion
                    .TipoOperacion = "F"
                    .Id = griLiquidacion.ActiveRow.Cells("Id").Value
                    .Fecha = fecLiquidacion.Value
                    .UsuarioCreacion = gUsuarioSGI.Id
                End With

                ListaLiquidacionDetalle = New List(Of e_LiquidacionDetalle)
                oeLiquidacion.ListaLiquidacionDetalle = ListaLiquidacionDetalle
                If MessageBox.Show("Se cambiara el estado de la Liquidacion " & Environment.NewLine & _
                                    "a EMITIDA para que sea Factura ", _
                                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    oeLiquidacion.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olLiquidacion.Guardar(oeLiquidacion)
                    griLiquidacion.ActiveRow.CellAppearance.BackColor = Me.colorCambio.Color
                End If
            Else
                Throw New Exception("La liquidacion ya fue EMITIDA/LIQUIDADA")
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub Tarifas123()
        oeFlete.TipoOperacion = "N"
        With griTarifas.DisplayLayout.Bands(0)
            .Columns("20M3").Header.Caption = "Furgon"
            .Columns("30M3").Header.Caption = "Parihuelero"
            .Columns("40M3").Header.Caption = "Consolidado"
            .Columns("50M3").Header.Caption = ""
            .Columns("65M3").Header.Caption = ""
        End With
        oeFlete.Id = cboCliente.Value
        griTarifas.DataSource = olFlete.ListarTarifas(oeFlete)
    End Sub

    Private Sub cboClienteLiquidacion_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClienteLiquidacion.Validated
        'oeFlete = New e_Flete
        'oeFlete.TipoOperacion = "T"
        'oeFlete.Id = cboCliente.Value
        'griTarifas.DataSource = olFlete.ListarTarifas(oeFlete)
        LimpiaGrid(griTarifas, ogdTarifas)
        LimpiaGrid(griTarifasRetorno, ogdTarifas)
        oeFlete = New e_Flete
        If cboClienteLiquidacion.Text = "SUPERMERCADOS PERUANOS S.A." Then
            LimpiaGrid(griTarifas, ogdTarifas)
            LimpiaGrid(griTarifasRetorno, ogdTarifas)
            Select Case opcFormatoLiquidacion.CheckedIndex
                Case 0
                    oeFlete.TipoOperacion = "L"
                    With griTarifas.DisplayLayout.Bands(0)
                        .Columns("20M3").Header.Caption = "20M3"
                        .Columns("30M3").Header.Caption = "30M3"
                        .Columns("40M3").Header.Caption = "40M3"
                        .Columns("50M3").Header.Caption = "50M3"
                        .Columns("65M3").Header.Caption = "65M3"
                    End With
                    oeFlete.Id = cboClienteLiquidacion.Value
                    griTarifas.DataSource = olFlete.ListarTarifas(oeFlete)
                Case 1
                    Tarifas123()
                Case 2
                    Tarifas123()
                Case 3
                    Tarifas123()
                Case 8
                    Tarifas123()
            End Select
        Else
            If cboClienteLiquidacion.Text = "HIPERMERCADOS TOTTUS S.A." Then
                LimpiaGrid(griTarifas, ogdTarifas)
                LimpiaGrid(griTarifasRetorno, ogdTarifas)
                Select Case opcFormatoLiquidacion.CheckedIndex
                    Case 4
                        oeFlete.TipoOperacion = "H"
                        With griTarifas.DisplayLayout.Bands(0)
                            .Columns("20M3").Header.Caption = "Furgon"
                            .Columns("30M3").Header.Caption = "Furgon Largo"
                            .Columns("40M3").Header.Caption = ""
                            .Columns("50M3").Header.Caption = ""
                            .Columns("65M3").Header.Caption = ""
                        End With
                        oeFlete.Id = cboClienteLiquidacion.Value
                        griTarifas.DataSource = olFlete.ListarTarifas(oeFlete)
                        '----------------------------------------------------
                        oeFlete.TipoOperacion = "T"
                        With griTarifasRetorno.DisplayLayout.Bands(0)
                            .Columns("20M3").Header.Caption = "Furgon"
                            .Columns("30M3").Header.Caption = "Parihuelero"
                            .Columns("40M3").Header.Caption = "Devoluciones"
                            .Columns("50M3").Header.Caption = ""
                            .Columns("65M3").Header.Caption = ""
                        End With
                        oeFlete.Id = cboClienteLiquidacion.Value
                        griTarifasRetorno.DataSource = olFlete.ListarTarifas(oeFlete)
                End Select
            Else
                If cboClienteLiquidacion.Text = "MAESTRO PERU S.A." Then
                    LimpiaGrid(griTarifas, ogdTarifas)
                    LimpiaGrid(griTarifasRetorno, ogdTarifas)
                    Select Case opcFormatoLiquidacion.CheckedIndex
                        Case 5
                            oeFlete.TipoOperacion = "P"
                            With griTarifas.DisplayLayout.Bands(0)
                                .Columns("20M3").Header.Caption = "Furgon"
                                .Columns("30M3").Header.Caption = "Plataformas"
                                .Columns("40M3").Header.Caption = ""
                                .Columns("50M3").Header.Caption = ""
                                .Columns("65M3").Header.Caption = ""
                            End With
                            oeFlete.Id = cboClienteLiquidacion.Value
                            griTarifas.DataSource = olFlete.ListarTarifas(oeFlete)
                    End Select
                End If
            End If
        End If
    End Sub

    Private Sub griTarifas_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griTarifas.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Eliminar()
    End Sub

    Private Sub MenuAgregar_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuAgregar.Opening
        Select Case opcFormatoLiquidacion.CheckedIndex
            Case 0
                If griViajesSinLiquidar.Rows.Count > 0 Then
                    MenuAgregar1234567()
                End If
            Case 1
                If griViajesSinLiquidarSPSA.Rows.Count > 0 Then
                    MenuAgregar1234567()
                End If
            Case 2
                If griViajesSinLiquidarSPSA.Rows.Count > 0 Then
                    MenuAgregar1234567()
                End If
            Case 3
                If griViajesSinLiquidarSPSA.Rows.Count > 0 Then
                    MenuAgregar1234567()
                End If
            Case 4
                If griViajesSinLiquidarTOTTUS.Rows.Count > 0 Then
                    MenuAgregar1234567()
                End If
            Case 5
                If griViajesSinLiquidarMAESTRO.Rows.Count > 0 Then
                    MenuAgregar1234567()
                End If
            Case 6
                If griViajesSinLiquidarTOTTUS.Rows.Count > 0 Then
                    MenuAgregar1234567()
                End If
            Case 7
                If griViajesSinLiquidarTOTTUS.Rows.Count > 0 Then
                    MenuAgregar1234567()
                End If
            Case 8
                If griViajesSinLiquidarSPSA.Rows.Count > 0 Then
                    MenuAgregar1234567()
                End If
        End Select
    End Sub

    Private Sub MenuAgregar1234567()
        If Operacion = "Editar" Then
            MenuAgregar.Items("Agregar").Visible = True
        Else
            MenuAgregar.Items("Agregar").Visible = False
        End If
    End Sub

    Private Sub Agregar123()
        If griViajesSinLiquidarSPSA.Rows.Count > 0 Then
            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleSPSA.DataSource
            ListaLiquidacionDetalle = griViajesSinLiquidarSPSA.DataSource
            For Each LiquidacionDetalle As e_LiquidacionDetalle In ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                With oeLiquidacionDetalle
                    .Seleccion = LiquidacionDetalle.Seleccion
                    .Id = ""
                    .IdLiquidacion = ""
                    .Operacion = LiquidacionDetalle.Operacion
                    .IdOperacion = LiquidacionDetalle.IdOperacion
                    .Viaje = LiquidacionDetalle.Viaje
                    .IdViaje = LiquidacionDetalle.IdViaje
                    .Fecha = LiquidacionDetalle.Fecha
                    .CodigoOrigen = LiquidacionDetalle.CodigoOrigen
                    .Origen = LiquidacionDetalle.Origen
                    .CodigoDestino = LiquidacionDetalle.CodigoDestino
                    .Destino = LiquidacionDetalle.Destino
                    .Tracto = LiquidacionDetalle.Tracto
                    .Carreta = LiquidacionDetalle.Carreta
                    .Capacidad = LiquidacionDetalle.Capacidad
                    .FleteUnitario = LiquidacionDetalle.FleteUnitario
                    .TotalFlete = LiquidacionDetalle.TotalFlete
                    .Ruta = LiquidacionDetalle.Ruta
                    .TipoVehiculo = LiquidacionDetalle.TipoVehiculo
                    .NroCarga = LiquidacionDetalle.NroCarga
                    .GuiaRemitente = LiquidacionDetalle.GuiaRemitente
                    .GuiaTransportista = LiquidacionDetalle.GuiaTransportista
                    .IndFacturado = LiquidacionDetalle.IndFacturado
                    .IndGrtConfirmada = LiquidacionDetalle.IndGrtConfirmada
                    .IndDocumentos = LiquidacionDetalle.IndDocumentos
                    .IndGrtPerdido = LiquidacionDetalle.IndGrtPerdido
                    .Observacion = LiquidacionDetalle.Observacion
                    .Activo = LiquidacionDetalle.Activo
                    .Consolidado2 = LiquidacionDetalle.Consolidado2
                    .Consolidado3 = LiquidacionDetalle.Consolidado3
                    .Consolidado = LiquidacionDetalle.Consolidado
                    .IdVehiculo = LiquidacionDetalle.IdVehiculo
                End With
                oeLiquidacion.ListaLiquidacionDetalle.Add(oeLiquidacionDetalle)
                griViajesLiquidacionDetalleSPSA.DataBind()
                oeLiquidacionDetalle = New e_LiquidacionDetalle
            Next
            ListaLiquidacionDetalle.RemoveAll(Function(Item) Item.Seleccion = True)
            griViajesSinLiquidar.DataBind()
            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleSPSA.DataSource
        End If
    End Sub

    Private Sub Agregar467()
        If griViajesSinLiquidarTOTTUS.Rows.Count > 0 Then
            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleTOTTUS.DataSource
            ListaLiquidacionDetalle = griViajesSinLiquidarTOTTUS.DataSource
            For Each LiquidacionDetalle As e_LiquidacionDetalle In ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                With oeLiquidacionDetalle
                    .Seleccion = LiquidacionDetalle.Seleccion
                    .Id = ""
                    .IdLiquidacion = ""
                    .Operacion = LiquidacionDetalle.Operacion
                    .IdOperacion = LiquidacionDetalle.IdOperacion
                    .Viaje = LiquidacionDetalle.Viaje
                    .IdViaje = LiquidacionDetalle.IdViaje
                    .Fecha = LiquidacionDetalle.Fecha
                    .CodigoOrigen = LiquidacionDetalle.CodigoOrigen
                    .Origen = LiquidacionDetalle.Origen
                    .CodigoDestino = LiquidacionDetalle.CodigoDestino
                    .Destino = LiquidacionDetalle.Destino
                    .Tracto = LiquidacionDetalle.Tracto
                    .Carreta = LiquidacionDetalle.Carreta
                    .Capacidad = LiquidacionDetalle.Capacidad
                    .FleteUnitario = LiquidacionDetalle.FleteUnitario
                    .TotalFlete = LiquidacionDetalle.TotalFlete
                    .Ruta = LiquidacionDetalle.Ruta
                    .TipoVehiculo = LiquidacionDetalle.TipoVehiculo
                    .NroCarga = LiquidacionDetalle.NroCarga
                    .GuiaRemitente = LiquidacionDetalle.GuiaRemitente
                    .GuiaTransportista = LiquidacionDetalle.GuiaTransportista
                    .IndFacturado = LiquidacionDetalle.IndFacturado
                    .IndGrtConfirmada = LiquidacionDetalle.IndGrtConfirmada
                    .IndDocumentos = LiquidacionDetalle.IndDocumentos
                    .IndGrtPerdido = LiquidacionDetalle.IndGrtPerdido
                    .Observacion = LiquidacionDetalle.Observacion
                    .Activo = LiquidacionDetalle.Activo
                    .Consolidado2 = LiquidacionDetalle.Consolidado2
                    .Consolidado3 = LiquidacionDetalle.Consolidado3
                    .Consolidado = LiquidacionDetalle.Consolidado
                    .IdVehiculo = LiquidacionDetalle.IdVehiculo
                    .FechaLlegada = LiquidacionDetalle.FechaLlegada
                    .FechaSalida = LiquidacionDetalle.FechaSalida
                    .Consolidado1 = LiquidacionDetalle.Consolidado1
                    .CentroCosto1 = LiquidacionDetalle.CentroCosto1
                    .CentroCosto2 = LiquidacionDetalle.CentroCosto2
                    .CentroCosto3 = LiquidacionDetalle.CentroCosto3
                End With
                oeLiquidacion.ListaLiquidacionDetalle.Add(oeLiquidacionDetalle)
                griViajesLiquidacionDetalleTOTTUS.DataBind()
                oeLiquidacionDetalle = New e_LiquidacionDetalle
            Next
            ListaLiquidacionDetalle.RemoveAll(Function(Item) Item.Seleccion = True)
            griViajesSinLiquidarTOTTUS.DataBind()
            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleTOTTUS.DataSource
        End If
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        Try
            oeLiquidacionDetalle = New e_LiquidacionDetalle
            ListaLiquidacionDetalle = New List(Of e_LiquidacionDetalle)
            ListaViajeSinLiquidar = New List(Of e_LiquidacionDetalle)
            Select Case opcFormatoLiquidacion.CheckedIndex
                Case 0
                    If griViajesSinLiquidar.Rows.Count > 0 Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalle.DataSource
                        ListaLiquidacionDetalle = griViajesSinLiquidar.DataSource
                        For Each LiquidacionDetalle As e_LiquidacionDetalle In ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                            With oeLiquidacionDetalle
                                .Seleccion = LiquidacionDetalle.Seleccion
                                .Id = ""
                                .IdLiquidacion = ""
                                .Operacion = LiquidacionDetalle.Operacion
                                .IdOperacion = LiquidacionDetalle.IdOperacion
                                .Viaje = LiquidacionDetalle.Viaje
                                .IdViaje = LiquidacionDetalle.IdViaje
                                .Fecha = LiquidacionDetalle.Fecha
                                .CodigoOrigen = LiquidacionDetalle.CodigoOrigen
                                .Origen = LiquidacionDetalle.Origen
                                .CodigoDestino = LiquidacionDetalle.CodigoDestino
                                .Destino = LiquidacionDetalle.Destino
                                .Tracto = LiquidacionDetalle.Tracto
                                .Carreta = LiquidacionDetalle.Carreta
                                .Capacidad = LiquidacionDetalle.Capacidad
                                .FleteUnitario = LiquidacionDetalle.FleteUnitario
                                .TotalFlete = LiquidacionDetalle.TotalFlete
                                .Ruta = LiquidacionDetalle.Ruta
                                .TipoVehiculo = LiquidacionDetalle.TipoVehiculo
                                .NroCarga = LiquidacionDetalle.NroCarga
                                .GuiaRemitente = LiquidacionDetalle.GuiaRemitente
                                .GuiaTransportista = LiquidacionDetalle.GuiaTransportista
                                .IndFacturado = LiquidacionDetalle.IndFacturado
                                .IndGrtConfirmada = LiquidacionDetalle.IndGrtConfirmada
                                .IndDocumentos = LiquidacionDetalle.IndDocumentos
                                .IndGrtPerdido = LiquidacionDetalle.IndGrtPerdido
                                .Observacion = LiquidacionDetalle.Observacion
                                .Activo = LiquidacionDetalle.Activo
                                .Consolidado2 = LiquidacionDetalle.Consolidado2
                                .Consolidado3 = LiquidacionDetalle.Consolidado3
                                .Consolidado = LiquidacionDetalle.Consolidado
                                .IdVehiculo = LiquidacionDetalle.IdVehiculo
                            End With
                            oeLiquidacion.ListaLiquidacionDetalle.Add(oeLiquidacionDetalle)
                            griViajesLiquidacionDetalle.DataBind()
                            oeLiquidacionDetalle = New e_LiquidacionDetalle
                        Next
                        ListaLiquidacionDetalle.RemoveAll(Function(Item) Item.Seleccion = True)
                        griViajesSinLiquidar.DataBind()
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalle.DataSource
                    End If
                Case 1
                    Agregar123()
                Case 2
                    Agregar123()
                Case 3
                    Agregar123()
                Case 4
                    Agregar467()
                Case 5
                    If griViajesSinLiquidarMAESTRO.Rows.Count > 0 Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleMAESTRO.DataSource
                        ListaLiquidacionDetalle = griViajesSinLiquidarMAESTRO.DataSource
                        For Each LiquidacionDetalle As e_LiquidacionDetalle In ListaLiquidacionDetalle.Where(Function(Item) Item.Seleccion = True)
                            With oeLiquidacionDetalle
                                .Seleccion = LiquidacionDetalle.Seleccion
                                .Id = ""
                                .IdLiquidacion = ""
                                .Operacion = LiquidacionDetalle.Operacion
                                .IdOperacion = LiquidacionDetalle.IdOperacion
                                .Viaje = LiquidacionDetalle.Viaje
                                .IdViaje = LiquidacionDetalle.IdViaje
                                .Fecha = LiquidacionDetalle.Fecha
                                .CodigoOrigen = LiquidacionDetalle.CodigoOrigen
                                .Origen = LiquidacionDetalle.Origen
                                .CodigoDestino = LiquidacionDetalle.CodigoDestino
                                .Destino = LiquidacionDetalle.Destino
                                .Tracto = LiquidacionDetalle.Tracto
                                .Carreta = LiquidacionDetalle.Carreta
                                .Capacidad = LiquidacionDetalle.Capacidad
                                .FleteUnitario = LiquidacionDetalle.FleteUnitario
                                .TotalFlete = LiquidacionDetalle.TotalFlete
                                .Ruta = LiquidacionDetalle.Ruta
                                .TipoVehiculo = LiquidacionDetalle.TipoVehiculo
                                .NroCarga = LiquidacionDetalle.NroCarga
                                .GuiaRemitente = LiquidacionDetalle.GuiaRemitente
                                .GuiaTransportista = LiquidacionDetalle.GuiaTransportista
                                .IndFacturado = LiquidacionDetalle.IndFacturado
                                .IndGrtConfirmada = LiquidacionDetalle.IndGrtConfirmada
                                .IndDocumentos = LiquidacionDetalle.IndDocumentos
                                .IndGrtPerdido = LiquidacionDetalle.IndGrtPerdido
                                .Observacion = LiquidacionDetalle.Observacion
                                .Activo = LiquidacionDetalle.Activo
                                .Consolidado1 = LiquidacionDetalle.Consolidado1
                                .Consolidado2 = LiquidacionDetalle.Consolidado2
                                .Consolidado3 = LiquidacionDetalle.Consolidado3
                                .Consolidado = LiquidacionDetalle.Consolidado
                                .CentroCosto1 = LiquidacionDetalle.CentroCosto1
                                .CentroCosto2 = LiquidacionDetalle.CentroCosto2
                                .CentroCosto3 = LiquidacionDetalle.CentroCosto3
                                .IdVehiculo = LiquidacionDetalle.IdVehiculo
                                .Volumen = LiquidacionDetalle.Volumen
                            End With
                            oeLiquidacion.ListaLiquidacionDetalle.Add(oeLiquidacionDetalle)
                            griViajesLiquidacionDetalleMAESTRO.DataBind()
                            oeLiquidacionDetalle = New e_LiquidacionDetalle
                        Next
                        ListaLiquidacionDetalle.RemoveAll(Function(Item) Item.Seleccion = True)
                        griViajesSinLiquidarMAESTRO.DataBind()
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleMAESTRO.DataSource
                    End If
                Case 6
                    Agregar467()
                Case 7
                    Agregar467()
                Case 8
                    Agregar123()
            End Select
            CalcularSubTotal()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Quitar123()
        If griViajesLiquidacionDetalleSPSA.Rows.Count > 0 Then
            griViajesLiquidacionDetalleSPSA.ActiveRow.Delete()
            griViajesLiquidacionDetalleSPSA.UpdateData()
            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleSPSA.DataSource
        End If
    End Sub

    Private Sub Quitar467()
        If griViajesLiquidacionDetalleTOTTUS.Rows.Count > 0 Then
            griViajesLiquidacionDetalleTOTTUS.ActiveRow.Delete()
            griViajesLiquidacionDetalleTOTTUS.UpdateData()
            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleTOTTUS.DataSource
        End If
    End Sub

    Private Sub Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitar.Click
        Select Case opcFormatoLiquidacion.CheckedIndex
            Case 0
                If griViajesLiquidacionDetalle.Rows.Count > 0 Then
                    griViajesLiquidacionDetalle.ActiveRow.Delete()
                    griViajesLiquidacionDetalle.UpdateData()
                    oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalle.DataSource
                End If
            Case 1
                Quitar123()
            Case 2
                Quitar123()
            Case 3
                Quitar123()
            Case 4
                Quitar467()
            Case 5
                If griViajesLiquidacionDetalleMAESTRO.Rows.Count > 0 Then
                    griViajesLiquidacionDetalleMAESTRO.ActiveRow.Delete()
                    griViajesLiquidacionDetalleMAESTRO.UpdateData()
                    oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleMAESTRO.DataSource
                End If
            Case 6
                Quitar467()
            Case 7
                Quitar467()
            Case 8
                Quitar123()
        End Select
        CalcularSubTotal()
    End Sub

    Private Sub btnActualizarFleteUnitario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarFleteUnitario.Click
        If tabDetalleLiquidacion.Tabs(0).Selected = True Then
            If griViajesSinLiquidar.Rows.Count > 0 Then
                If MessageBox.Show("Se va actualizar todos los Fletes Unitarios de la lista activa ? ", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSinLiquidar.Rows.Where(Function(item) item.IsFilteredOut = False)
                        Fila.Cells("FleteUnitario").Value = txtFleteUnitario.Text
                    Next
                    ugb_Espera.Visible = False
                End If
            End If
        Else
            If griViajesLiquidacionDetalle.Rows.Count > 0 Then
                If MessageBox.Show("Se va actualizar todos los Fletes Unitarios de la lista activa ? ", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesLiquidacionDetalle.Rows.Where(Function(item) item.IsFilteredOut = False)
                        Fila.Cells("FleteUnitario").Value = txtFleteUnitario.Text
                    Next
                    ugb_Espera.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub fecDesde_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fecDesde.Validating
        If fecDesde.Value = Nothing Then
            fecDesde.Value = Today.Date
        End If
    End Sub

    Private Sub fecHasta_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fecHasta.Validating
        If fecHasta.Value = Nothing Then
            fecHasta.Value = Today.Date
        End If
    End Sub

    Private Sub fecDesdeViaje_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fecDesdeViaje.Validating
        If fecDesdeViaje.Value = Nothing Then
            fecDesdeViaje.Value = Today.Date
        End If
    End Sub

    Private Sub fecHastaViaje_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fecHastaViaje.Validating
        If fecHastaViaje.Value = Nothing Then
            fecHastaViaje.Value = Today.Date
        End If
    End Sub

    Private Sub btnActualizaDocumentosGuias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizaDocumentosGuias.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeLiquidacion = New e_Liquidaciones
            With oeLiquidacion
                .TipoOperacion = "A"
                If opcActualizarGuias.CheckedIndex = 0 Then
                    .Id = "GRT"
                Else
                    If opcActualizarGuias.CheckedIndex = 1 Then
                        .Id = "GRR"
                    Else
                        .Id = "CARGA"
                    End If
                End If
                .IdCliente = cboCliente.Value
                .FechaDesde = fecDesde.Value
                .FechaHasta = fecHasta.Value
            End With
            griLiquidacion.DataSource = olLiquidacion.Listar(oeLiquidacion)
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ControltabDetalleLiquidacion(ByVal Tab0 As Boolean, ByVal Tab1 As Boolean, ByVal Tab2 As Boolean, ByVal Tab3 As Boolean, ByVal Tab4 As Boolean, ByVal Tab5 As Boolean, ByVal Tab6 As Boolean, ByVal Tab7 As Boolean)
        With tabDetalleLiquidacion
            .Tabs(0).Enabled = Tab0
            .Tabs(1).Enabled = Tab1
            .Tabs(2).Enabled = Tab2
            .Tabs(3).Enabled = Tab3
            .Tabs(4).Enabled = Tab4
            .Tabs(5).Enabled = Tab5
            .Tabs(6).Enabled = Tab6
            .Tabs(7).Enabled = Tab7
        End With
    End Sub

    Private Sub opcFormatoLiquidacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcFormatoLiquidacion.ValueChanged
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Select Case opcFormatoLiquidacion.CheckedIndex
                Case 0
                    tabDetalleLiquidacion.Tabs(0).Selected = True
                    cboClienteLiquidacion.Text = "SUPERMERCADOS PERUANOS S.A."
                    ControltabDetalleLiquidacion(1, 1, 0, 0, 0, 0, 0, 0)
                Case 1
                    tabDetalleLiquidacion.Tabs(2).Selected = True
                    cboClienteLiquidacion.Text = "SUPERMERCADOS PERUANOS S.A."
                    ControltabDetalleLiquidacion(0, 0, 1, 1, 0, 0, 0, 0)
                Case 2
                    tabDetalleLiquidacion.Tabs(2).Selected = True
                    cboClienteLiquidacion.Text = "SUPERMERCADOS PERUANOS S.A."
                    ControltabDetalleLiquidacion(0, 0, 1, 1, 0, 0, 0, 0)
                Case 3
                    tabDetalleLiquidacion.Tabs(2).Selected = True
                    cboClienteLiquidacion.Text = "SUPERMERCADOS PERUANOS S.A."
                    ControltabDetalleLiquidacion(0, 0, 1, 1, 0, 0, 0, 0)
                Case 4
                    tabDetalleLiquidacion.Tabs(4).Selected = True
                    tabDetalleLiquidacion.Tabs(4).Text = "V.S.L - TOTTUS"
                    tabDetalleLiquidacion.Tabs(5).Text = "L.D - TOTTUS"
                    cboClienteLiquidacion.Text = "HIPERMERCADOS TOTTUS S.A."
                    ControltabDetalleLiquidacion(0, 0, 0, 0, 1, 1, 0, 0)
                Case 5
                    tabDetalleLiquidacion.Tabs(6).Selected = True
                    cboClienteLiquidacion.Text = "MAESTRO PERU S.A."
                    ControltabDetalleLiquidacion(0, 0, 0, 0, 0, 0, 1, 1)
                Case 6
                    tabDetalleLiquidacion.Tabs(4).Selected = True
                    tabDetalleLiquidacion.Tabs(4).Text = "V.S.L - FALABELLA"
                    tabDetalleLiquidacion.Tabs(5).Text = "L.D - FALABELLA"
                    cboClienteLiquidacion.Text = "SAGA FALABELLA SA"
                    ControltabDetalleLiquidacion(0, 0, 0, 0, 1, 1, 0, 0)
                Case 7
                    tabDetalleLiquidacion.Tabs(4).Selected = True
                    tabDetalleLiquidacion.Tabs(4).Text = "V.S.L - SODIMAC"
                    tabDetalleLiquidacion.Tabs(5).Text = "L.D - SODIMAC"
                    cboClienteLiquidacion.Text = "SODIMAC PERU S.A."
                    ControltabDetalleLiquidacion(0, 0, 0, 0, 1, 1, 0, 0)
                Case 8
                    tabDetalleLiquidacion.Tabs(2).Selected = True
                    cboClienteLiquidacion.Text = "SUPERMERCADOS PERUANOS S.A."
                    ControltabDetalleLiquidacion(0, 0, 1, 1, 0, 0, 0, 0)
            End Select
        End If
    End Sub

    Private Sub griViajesSinLiquidarSPSA_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajesSinLiquidarSPSA.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub griViajesSinLiquidarSPSA_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajesSinLiquidarSPSA.CellChange
        Try
            griViajesSinLiquidarSPSA.UpdateData()
            Select Case e.Cell.Column.Key
                Case "FleteUnitario"
                    With griViajesSinLiquidarSPSA.ActiveRow
                        .Cells("TotalFlete").Value = ((.Cells("FleteUnitario").Value + .Cells("Consolidado").Value) * gIgv) + (.Cells("FleteUnitario").Value + .Cells("Consolidado").Value)
                    End With
                    If Operacion = "Nuevo" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarSPSA.DataSource
                        CalcularSubTotal()
                    End If
                Case "Consolidado"
                    With griViajesSinLiquidarSPSA.ActiveRow
                        .Cells("TotalFlete").Value = ((.Cells("FleteUnitario").Value + .Cells("Consolidado").Value) * gIgv) + (.Cells("FleteUnitario").Value + .Cells("Consolidado").Value)
                    End With
                    If Operacion = "Nuevo" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarSPSA.DataSource
                        CalcularSubTotal()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajesLiquidacionDetalleSPSA_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajesLiquidacionDetalleSPSA.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarLiquidacionDetalle() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
            griViajesLiquidacionDetalleSPSA.UpdateData()
            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleSPSA.DataSource
            CalcularSubTotal()
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajesLiquidacionDetalleSPSA_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajesLiquidacionDetalleSPSA.CellChange
        Try
            griViajesLiquidacionDetalleSPSA.UpdateData()
            Select Case e.Cell.Column.Key
                Case "FleteUnitario"
                    With griViajesLiquidacionDetalleSPSA.ActiveRow
                        .Cells("TotalFlete").Value = ((.Cells("FleteUnitario").Value + .Cells("Consolidado").Value) * gIgv) + (.Cells("FleteUnitario").Value + .Cells("Consolidado").Value)
                    End With
                    If Operacion = "Editar" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleSPSA.DataSource
                        CalcularSubTotal()
                    End If
                Case "Consolidado"
                    With griViajesLiquidacionDetalleSPSA.ActiveRow
                        .Cells("TotalFlete").Value = ((.Cells("FleteUnitario").Value + .Cells("Consolidado").Value) * gIgv) + (.Cells("FleteUnitario").Value + .Cells("Consolidado").Value)
                    End With
                    If Operacion = "Editar" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleSPSA.DataSource
                        CalcularSubTotal()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajesSinLiquidarTOTTUS_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajesSinLiquidarTOTTUS.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub griViajesSinLiquidarTOTTUS_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajesSinLiquidarTOTTUS.CellChange
        Try
            griViajesSinLiquidarTOTTUS.UpdateData()
            Select Case e.Cell.Column.Key
                Case "FleteUnitario"
                    With griViajesSinLiquidarTOTTUS.ActiveRow
                        .Cells("TotalFlete").Value = (.Cells("FleteUnitario").Value * gIgv) + .Cells("FleteUnitario").Value
                    End With
                    If Operacion = "Nuevo" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarTOTTUS.DataSource
                        CalcularSubTotal()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajesLiquidacionDetalleTOTTUS_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajesLiquidacionDetalleTOTTUS.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarLiquidacionDetalle() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
            griViajesLiquidacionDetalleTOTTUS.UpdateData()
            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleTOTTUS.DataSource
            CalcularSubTotal()
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajesLiquidacionDetalleTOTTUS_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajesLiquidacionDetalleTOTTUS.CellChange
        Try
            griViajesLiquidacionDetalleTOTTUS.UpdateData()
            Select Case e.Cell.Column.Key
                Case "FleteUnitario"
                    With griViajesLiquidacionDetalleTOTTUS.ActiveRow
                        .Cells("TotalFlete").Value = (.Cells("FleteUnitario").Value * gIgv) + .Cells("FleteUnitario").Value
                    End With
                    If Operacion = "Editar" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleTOTTUS.DataSource
                        CalcularSubTotal()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MenuQuitar_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuQuitar.Opening
        Select Case opcFormatoLiquidacion.CheckedIndex
            Case 0
                If griViajesLiquidacionDetalle.Rows.Count > 0 Then
                    MenuQuitar1234567()
                End If
            Case 1
                If griViajesLiquidacionDetalleSPSA.Rows.Count > 0 Then
                    MenuQuitar1234567()
                End If
            Case 2
                If griViajesLiquidacionDetalleSPSA.Rows.Count > 0 Then
                    MenuQuitar1234567()
                End If
            Case 3
                If griViajesLiquidacionDetalleSPSA.Rows.Count > 0 Then
                    MenuQuitar1234567()
                End If
            Case 4
                If griViajesLiquidacionDetalleTOTTUS.Rows.Count > 0 Then
                    MenuQuitar1234567()
                End If
            Case 5
                If griViajesLiquidacionDetalleMAESTRO.Rows.Count > 0 Then
                    MenuQuitar1234567()
                End If
            Case 6
                If griViajesLiquidacionDetalleTOTTUS.Rows.Count > 0 Then
                    MenuQuitar1234567()
                End If
            Case 7
                If griViajesLiquidacionDetalleTOTTUS.Rows.Count > 0 Then
                    MenuQuitar1234567()
                End If
            Case 8
                If griViajesLiquidacionDetalleSPSA.Rows.Count > 0 Then
                    MenuQuitar1234567()
                End If
        End Select
    End Sub
    Private Sub MenuQuitar1234567()
        If Operacion = "Editar" Then
            MenuQuitar.Items("Quitar").Visible = True
        Else
            MenuQuitar.Items("Quitar").Visible = False
        End If
    End Sub
    Private Sub griViajesSinLiquidarMAESTRO_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajesSinLiquidarMAESTRO.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub griViajesSinLiquidarMAESTRO_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajesSinLiquidarMAESTRO.CellChange
        Try
            griViajesSinLiquidarMAESTRO.UpdateData()
            Select Case e.Cell.Column.Key
                Case "Volumen"
                    With griViajesSinLiquidarMAESTRO.ActiveRow
                        If .Cells("Volumen").Value <= 65 Then
                            .Cells("FleteUnitario").Value = (FleteUnitario / 65) * .Cells("Volumen").Value
                            .Cells("TotalFlete").Value = (.Cells("FleteUnitario").Value * gIgv) + .Cells("FleteUnitario").Value
                        Else
                            .Cells("FleteUnitario").Value = FleteUnitario
                            .Cells("TotalFlete").Value = (FleteUnitario * gIgv) + FleteUnitario
                        End If
                        If Operacion = "Nuevo" Then
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarMAESTRO.DataSource
                            CalcularSubTotal()
                        End If
                    End With
                Case "FleteUnitario"
                    With griViajesSinLiquidarMAESTRO.ActiveRow
                        .Cells("TotalFlete").Value = (.Cells("FleteUnitario").Value * gIgv) + .Cells("FleteUnitario").Value
                    End With
                    If Operacion = "Nuevo" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesSinLiquidarMAESTRO.DataSource
                        CalcularSubTotal()
                    End If
                    IndIdFlete = ""
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajesSinLiquidarMAESTRO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griViajesSinLiquidarMAESTRO.Click
        If griViajesSinLiquidarMAESTRO.Rows.Count > 0 Then
            With griViajesSinLiquidarMAESTRO.ActiveRow
                If IndIdFlete <> .Cells("Operacion").Value Then
                    FleteUnitario = .Cells("FleteUnitario").Value
                    IndIdFlete = .Cells("Operacion").Value
                End If
            End With
        End If
    End Sub

    Private Sub griViajesLiquidacionDetalleMAESTRO_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajesLiquidacionDetalleMAESTRO.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarLiquidacionDetalle() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
            griViajesLiquidacionDetalleMAESTRO.UpdateData()
            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleMAESTRO.DataSource
            CalcularSubTotal()
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajesLiquidacionDetalleMAESTRO_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajesLiquidacionDetalleMAESTRO.CellChange
        Try
            griViajesLiquidacionDetalleMAESTRO.UpdateData()
            Select Case e.Cell.Column.Key
                Case "Volumen"
                    With griViajesLiquidacionDetalleMAESTRO.ActiveRow
                        If .Cells("Volumen").Value <= 65 Then
                            .Cells("FleteUnitario").Value = (FleteUnitario / 65) * .Cells("Volumen").Value
                            .Cells("TotalFlete").Value = (.Cells("FleteUnitario").Value * gIgv) + .Cells("FleteUnitario").Value
                        Else
                            .Cells("FleteUnitario").Value = FleteUnitario
                            .Cells("TotalFlete").Value = (FleteUnitario * gIgv) + FleteUnitario
                        End If
                        If Operacion = "Editar" Then
                            oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleMAESTRO.DataSource
                            CalcularSubTotal()
                        End If
                    End With
                Case "FleteUnitario"
                    With griViajesLiquidacionDetalleMAESTRO.ActiveRow
                        .Cells("TotalFlete").Value = (.Cells("FleteUnitario").Value * gIgv) + .Cells("FleteUnitario").Value
                    End With
                    If Operacion = "Editar" Then
                        oeLiquidacion.ListaLiquidacionDetalle = griViajesLiquidacionDetalleMAESTRO.DataSource
                        CalcularSubTotal()
                    End If
                    IndIdFlete = ""
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajesLiquidacionDetalleMAESTRO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griViajesLiquidacionDetalleMAESTRO.Click
        If griViajesLiquidacionDetalleMAESTRO.Rows.Count > 0 Then
            With griViajesLiquidacionDetalleMAESTRO.ActiveRow
                If IndIdFlete <> .Cells("Operacion").Value Then
                    FleteUnitario = .Cells("FleteUnitario").Value
                    IndIdFlete = .Cells("Operacion").Value
                End If
            End With
        End If
    End Sub

    Private Sub DivideLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DivideLiquidacion.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If griLiquidacion.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                If griLiquidacion.ActiveRow.Cells("IdEstado").Value = "GENERADA" Then
                    oeLiquidacion = New e_Liquidaciones
                    oeLiquidacionDetalle = New e_LiquidacionDetalle
                    Select Case CInt(griLiquidacion.ActiveRow.Cells("IndFormato").Value)
                        Case 0
                        Case 1
                        Case 2
                        Case 3
                        Case 4
                            DividirLiquidacion467()
                        Case 5
                        Case 6
                            DividirLiquidacion467()
                        Case 7
                            DividirLiquidacion467()
                    End Select
                Else
                    Throw New Exception("La liquidacion ya fue EMITIDA/LIQUIDADA/HABILITADA")
                End If
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub DividirLiquidacion467()
        Try
            If MessageBox.Show("Esta seguro de dividir la liquidacion por sus Clases de Servicio: " & _
                                                        griLiquidacion.ActiveRow.Cells("Codigo").Value.ToString & " ?", _
                                                       "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                oeLiquidacionDetalle.TipoOperacion = "D"
                oeLiquidacionDetalle.IdLiquidacion = griLiquidacion.ActiveRow.Cells("Id").Value.ToString
                oeLiquidacionDetalle.IdCliente = griLiquidacion.ActiveRow.Cells("IdCliente").Value.ToString
                oeLiquidacion.ListaLiquidacionDetalle = olLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
                With oeLiquidacion
                    .Fecha = griLiquidacion.ActiveRow.Cells("Fecha").Value.ToString
                    .TipoOperacion = "T"
                    .Id = griLiquidacion.ActiveRow.Cells("Id").Value.ToString
                    .Codigo = griLiquidacion.ActiveRow.Cells("Codigo").Value.ToString
                    .IdCliente = griLiquidacion.ActiveRow.Cells("IdCliente").Value.ToString
                    .IndFormato = 100
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Observacion = griLiquidacion.ActiveRow.Cells("Observacion").Value.ToString
                    .Igv = gIgv
                End With
                oeLiquidacion.PrefijoID = gs_PrefijoIdSucursal '@0001
                olLiquidacion.Guardar(oeLiquidacion)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
    Private Sub griControlViajesSPSA_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griControlViajesSPSA.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griTarifasSPSA_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griTarifasSPSA.BeforeRowsDeleted

        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griViajesSPSA_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajesSPSA.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griControlViajesSPSA_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griControlViajesSPSA.CellChange
        griControlViajesSPSA.UpdateData()
    End Sub

    Private Sub griControlViajesSPSA_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griControlViajesSPSA.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim Monto As Double
            Dim Prorratear As Double
            Dim Contador As Integer
            Dim IdOperacion As String
            Dim Operaciones As String
            Select Case e.Cell.Column.Key
                Case "Guardar"
                    With griControlViajesSPSA.ActiveRow
                        If .Cells("Monto").Value > 0 Then
                            IdOperacion = ""
                            Operaciones = ""
                            Monto = 0
                            Select Case .Cells("DiaSemana").Value
                                Case "Lunes"
                                Case "Martes"
                                    Monto = .Cells("Monto").Value
                                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSPSA.Rows.Where(Function(Item) Item.Cells("DiaSemana").Value = "Martes")
                                        If fila.Cells("Guardar").Value <> IdOperacion Then
                                            IdOperacion = fila.Cells("Guardar").Value
                                            Operaciones = Operaciones & "'" & IdOperacion & "',"
                                            Contador = Contador + 1
                                        End If
                                    Next
                                    Prorratear = (Monto / Contador).ToString("###,##0.00")
                                    .Cells("Prorrateo").Value = Prorratear
                                Case "Miercoles"
                                    Monto = .Cells("Monto").Value
                                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSPSA.Rows.Where(Function(Item) Item.Cells("DiaSemana").Value = "Miercoles")
                                        If fila.Cells("Guardar").Value <> IdOperacion Then
                                            IdOperacion = fila.Cells("Guardar").Value
                                            Operaciones = Operaciones & "'" & IdOperacion & "',"
                                            Contador = Contador + 1
                                        End If
                                    Next
                                    Prorratear = (Monto / Contador).ToString("###,##0.00")
                                    .Cells("Prorrateo").Value = Prorratear
                                Case "Jueves"
                                    Monto = .Cells("Monto").Value
                                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSPSA.Rows.Where(Function(Item) Item.Cells("DiaSemana").Value = "Jueves")
                                        If fila.Cells("Guardar").Value <> IdOperacion Then
                                            IdOperacion = fila.Cells("Guardar").Value
                                            Operaciones = Operaciones & "'" & IdOperacion & "',"
                                            Contador = Contador + 1
                                        End If
                                    Next
                                    Prorratear = (Monto / Contador).ToString("###,##0.00")
                                    .Cells("Prorrateo").Value = Prorratear
                                Case "Viernes"
                                    Monto = .Cells("Monto").Value
                                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSPSA.Rows.Where(Function(Item) Item.Cells("DiaSemana").Value = "Viernes")
                                        If fila.Cells("Guardar").Value <> IdOperacion Then
                                            IdOperacion = fila.Cells("Guardar").Value
                                            Operaciones = Operaciones & "'" & IdOperacion & "',"
                                            Contador = Contador + 1
                                        End If
                                    Next
                                    Prorratear = (Monto / Contador).ToString("###,##0.00")
                                    .Cells("Prorrateo").Value = Prorratear
                                Case "Sabado"
                                    Monto = .Cells("Monto").Value
                                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSPSA.Rows.Where(Function(Item) Item.Cells("DiaSemana").Value = "Sabado")
                                        If fila.Cells("Guardar").Value <> IdOperacion Then
                                            IdOperacion = fila.Cells("Guardar").Value
                                            Operaciones = Operaciones & "'" & IdOperacion & "',"
                                            Contador = Contador + 1
                                        End If
                                    Next
                                    Prorratear = (Monto / Contador).ToString("###,##0.00")
                                    .Cells("Prorrateo").Value = Prorratear
                                Case "Domingo"
                                    Monto = .Cells("Monto").Value
                                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesSPSA.Rows.Where(Function(Item) Item.Cells("DiaSemana").Value = "Lunes" Or Item.Cells("DiaSemana").Value = "Domingo")
                                        If fila.Cells("Guardar").Value <> IdOperacion Then
                                            IdOperacion = fila.Cells("Guardar").Value
                                            Operaciones = Operaciones & "'" & IdOperacion & "',"
                                            Contador = Contador + 1
                                        End If
                                    Next
                                    Prorratear = (Monto / Contador).ToString("###,##0.00")
                                    .Cells("Prorrateo").Value = Prorratear
                            End Select
                            Dim oeOperacionDetalle = New e_OperacionDetalle
                            Operaciones = Operaciones.Substring(0, Operaciones.Length - 1)
                            With oeOperacionDetalle
                                .TipoOperacion = "P"
                                .Glosa = Operaciones
                                .FleteUnitario = Prorratear
                                .Flete = ((Prorratear * gIgv) + Prorratear).ToString("###,##0.00")
                                .UsuarioCreacion = gUsuarioSGI.Id
                            End With
                            oeOperacionDetalle.PrefijoID = gs_PrefijoIdSucursal '@0001
                            If olOperacion.GuardarOperacionDetalle(oeOperacionDetalle) Then
                                .CellAppearance.BackColor = Me.colorCambio.Color
                            End If
                        End If
                    End With
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Function Prorratear(ByVal Dia As String) As Boolean
        Select Case Dia
            Case "Lunes"
            Case "Martes"
            Case "Miercoles"
            Case "Jueves"
            Case "Viernes"
            Case "Sabado"
            Case "Domingo"
        End Select
    End Function

    Private Sub tabDetalleLiquidacion_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabDetalleLiquidacion.SelectedTabChanged

    End Sub

    Private Sub griViajesSinLiquidarSPSA_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles griViajesSinLiquidarSPSA.InitializeLayout

    End Sub
End Class